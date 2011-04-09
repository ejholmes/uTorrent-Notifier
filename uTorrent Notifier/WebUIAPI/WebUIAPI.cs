using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Windows.Forms;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace uTorrentNotifier
{
    public partial class WebUIAPI
    {
        public delegate void DownloadFinishedEventHandler(List<TorrentFile> finished);
        public delegate void TorrentAddedEventHandler(List<TorrentFile> added);
        public delegate void LoginErrorEventHandler(object sender, Exception e);

        public event DownloadFinishedEventHandler DownloadComplete;
        public event TorrentAddedEventHandler TorrentAdded;
        public event LoginErrorEventHandler LoginError;

        private Timer timer = new Timer();

        private Config _Config;

        private List<TorrentFile> last = null;
        private List<TorrentFile> current = null;

        private string token = "";
        private CookieContainer cookies = new CookieContainer();

        public WebUIAPI(Config cfg)
        {
            this._Config = cfg;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 10000;
        }

        public void Start()
        {
            timer.Start();
        }

        public void Stop()
        {
            timer.Stop();
        }

        public bool Stopped
        {
            get { return timer.Enabled; }
        }

        void timer_Tick(object sender, EventArgs e)
        {
            this.current = new List<TorrentFile>();
            this.current = this.List();

            if (last != null)
            {
                List<TorrentFile> completed = this.FindDone(this.current, this.last);
                List<TorrentFile> added = this.FindNew(this.current, this.last);

                if ((completed.Count > 0) && (this.DownloadComplete != null))
                    this.DownloadComplete(completed);

                if ((added.Count > 0) && (this.TorrentAdded != null))
                    this.TorrentAdded(added);
            }

            this.last = this.current;
        }

        private List<TorrentFile> FindDone(List<TorrentFile> current, List<TorrentFile> last)
        {
            List<TorrentFile> finishedTorrents = new List<TorrentFile>();

            if (this.last.Count > 0 && this.current != null)
            {
                foreach (TorrentFile currentTorrent in this.current)
                {
                    foreach (TorrentFile lastTorrent in this.last)
                    {
                        if (currentTorrent.Hash == lastTorrent.Hash)
                        {
                            if ((currentTorrent.PercentProgress == 1000) &&
                                (lastTorrent.PercentProgress != 1000))
                            {
                                finishedTorrents.Add(currentTorrent);
                            }
                        }
                    }
                }
            }

            return finishedTorrents;
        }

        private List<TorrentFile> FindNew(List<TorrentFile> current, List<TorrentFile> last)
        {
            List<TorrentFile> newTorrents = new List<TorrentFile>();

			if (this.current != null)
			{
				foreach (TorrentFile currentTorrent in this.current)
				{
					TorrentFile result = this.last.Find(item => item.Hash == currentTorrent.Hash);

					if (result == null)
						newTorrents.Add(currentTorrent);
				}
			}

            return newTorrents;
        }

        private List<TorrentFile> List()
        {
            List<TorrentFile> l = new List<TorrentFile>();

            List<KeyValuePair<string, string>> args = new List<KeyValuePair<string, string>>();

            args.Add(new KeyValuePair<string, string>("list", "1"));
            args.Add(new KeyValuePair<string, string>("token", this.token));

            string json = this.Send(args.ToArray());

            if (json != "")
            {
                try
                {
                    JObject o = JObject.Parse(json);

                    IList<JToken> results = o["torrents"].Children().ToList();

                    foreach (JToken result in results)
                    {
                        TorrentFile f = TorrentFile.ConvertStringArray(JsonConvert.DeserializeObject<string[]>(result.ToString()));

                        l.Add(f);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                return null;
            }

            return l;
        }

        private string Send(string action, KeyValuePair<string, string>[] args)
        {
            List<KeyValuePair<string, string>> l = new List<KeyValuePair<string, string>>();
            l.Add(new KeyValuePair<string, string>("action", action));
            l.Add(new KeyValuePair<string, string>("token", this.token));
            l.AddRange(args);

            return this.Send(l.ToArray());
        }

        private string Send(KeyValuePair<string, string>[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this._Config.URI);
            sb.Append("/?");

            foreach (KeyValuePair<string, string> kv in args)
            {
                sb.Append(kv.Key);
                sb.Append("=");
                sb.Append(kv.Value);
                sb.Append("&");
            }

            return this._Get(sb.ToString());
        }

        private void _Token()
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(this._Config.URI + "/token.html");
                request.Credentials = new NetworkCredential(this._Config.Username, this._Config.Password);
                request.CookieContainer = cookies;

                Stream resStream = request.GetResponse().GetResponseStream();
				this.token = System.Text.RegularExpressions.Regex.Replace(new StreamReader(resStream).ReadToEnd(), @"(<[^>]+>)", string.Empty);
                resStream.Close();
            }
            catch (WebException webex)
            {
                if (LoginError != null)
                    LoginError(this, webex);
            }
            catch
            {
            }
        }

        private string _Get(string get)
        {
            if (get.Contains("token=&"))
            {
                this._Token();
                return "";
            }
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(get);
                request.Credentials = new NetworkCredential(this._Config.Username, this._Config.Password);
                request.CookieContainer = cookies;
            
                Stream resStream = request.GetResponse().GetResponseStream();
                string html = new StreamReader(resStream).ReadToEnd();
                resStream.Close();

                return html;
            }
            catch
            {
                this._Token();
                return "";
            }
        }

        private void _Post(string action, string file)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this._Config.URI);
            sb.Append("/?action=");
            sb.Append(action);

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(sb.ToString());
            byte[] data = null;

            using (BinaryReader reader = new BinaryReader(File.OpenRead(file)))
            {
                data = reader.ReadBytes((int)reader.BaseStream.Length);
            }

            request.Method = "POST";
            request.ContentType = "multipart/form-data";
            request.SendChunked = true;
            request.Timeout = 1000;
            request.ContentLength = data.Length;
            request.KeepAlive = true;

            using (Stream s = request.GetRequestStream())
            {
                s.Write(data, 0, data.Length);
                s.Close();
            }

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

        }

        public Config Config
        {
            get { return this._Config; }
            set { this._Config = value; }
        }
    }
}
