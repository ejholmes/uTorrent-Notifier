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
    public partial class WebUIAPI : IDisposable
    {
        private Timer timer = new Timer();

        private Config _Config;

        private List<TorrentFile> LastListing = null;
        private List<TorrentFile> CurrentListing = null;

        private string Token = "";
        private CookieContainer Cookies = new CookieContainer();

        public WebUIAPI(Config config)
        {
            this._Config = config;
            this.timer.Tick += new EventHandler(timer_Tick);
            this.timer.Interval = 10000;
        }

        public void Start()
        {
            this.timer.Start();
            this.timer_Tick(null, null);
        }

        public void Stop()
        {
            this.timer.Stop();
        }

        public bool Stopped
        {
            get { return timer.Enabled; }
        }

        void timer_Tick(object sender, EventArgs e)
        {
            this.CurrentListing = new List<TorrentFile>();
            this.CurrentListing = this.List();

            if (LastListing != null)
            {
                List<TorrentFile> completed = this.FindDone();
                List<TorrentFile> added = this.FindNew();

                if ((completed.Count > 0) && (this.DownloadComplete != null))
                    this.DownloadComplete(completed);

                if ((added.Count > 0) && (this.TorrentAdded != null))
                    this.TorrentAdded(added);
            }

            this.LastListing = this.CurrentListing;
        }

        private List<TorrentFile> FindDone()
        {
            List<TorrentFile> finishedTorrents = new List<TorrentFile>();

            if (this.LastListing.Count > 0 && this.CurrentListing != null)
            {
                foreach (TorrentFile currentTorrent in this.CurrentListing)
                {
                    foreach (TorrentFile lastTorrent in this.LastListing)
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

        private List<TorrentFile> FindNew()
        {
            List<TorrentFile> newTorrents = new List<TorrentFile>();

			if (this.CurrentListing != null)
			{
				foreach (TorrentFile currentTorrent in this.CurrentListing)
				{
					TorrentFile result = this.LastListing.Find(item => item.Hash == currentTorrent.Hash);

					if (result == null)
						newTorrents.Add(currentTorrent);
				}
			}

            return newTorrents;
        }

        private List<TorrentFile> List()
        {
            List<TorrentFile> torrents = new List<TorrentFile>();

            List<KeyValuePair<string, string>> args = new List<KeyValuePair<string, string>>();

            args.Add(new KeyValuePair<string, string>("list", "1"));
            args.Add(new KeyValuePair<string, string>("token", this.Token));

            string json = this.Send(args.ToArray());

            if (!String.IsNullOrEmpty(json))
            {
                JObject o = JObject.Parse(json);
                IList<JToken> results = o["torrents"].Children().ToList();

                foreach (JToken result in results)
                {
                    TorrentFile f = TorrentFile.ConvertStringArray(JsonConvert.DeserializeObject<string[]>(result.ToString()));
                    torrents.Add(f);
                }
            }
            else
            {
                return null;
            }

            this.UpdatedList(torrents);

            return torrents;
        }

        private string Send(string action, KeyValuePair<string, string>[] args)
        {
            List<KeyValuePair<string, string>> l = new List<KeyValuePair<string, string>>();
            l.Add(new KeyValuePair<string, string>("action", action));
            l.Add(new KeyValuePair<string, string>("token", this.Token));
            l.AddRange(args);

            return this.Send(l.ToArray());
        }

        private string Send(KeyValuePair<string, string>[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this._Config.Uri);
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
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(this._Config.Uri + "/token.html");
                request.Credentials = new NetworkCredential(this._Config.UserName, this._Config.Password);
                request.CookieContainer = Cookies;

                Stream resStream = request.GetResponse().GetResponseStream();
				this.Token = System.Text.RegularExpressions.Regex.Replace(new StreamReader(resStream).ReadToEnd(), @"(<[^>]+>)", string.Empty);
                resStream.Close();
            }
            catch (WebException webex)
            {
                if (LogOnError != null)
                    LogOnError(this, webex);
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
                request.Credentials = new NetworkCredential(this._Config.UserName, this._Config.Password);
                request.CookieContainer = Cookies;
            
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

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.timer.Dispose();
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public Config Config
        {
            get { return this._Config; }
            set { this._Config = value; }
        }
    }
}
