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
        public delegate void LoginErrorEventHandler();

        public event DownloadFinishedEventHandler DownloadComplete;
        public event TorrentAddedEventHandler TorrentAdded;
        public event LoginErrorEventHandler LoginError;

        private Timer timer = new Timer();

        private Config _Config;

        private List<TorrentFile> last = null;
        private List<TorrentFile> current = null;

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

            if (this.last.Count > 0)
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

            if (last.Count > 0)
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

            try
            {
                List<KeyValuePair<string, string>> args = new List<KeyValuePair<string, string>>();

                args.Add(new KeyValuePair<string, string>("list", "1"));

                string json = this._Get(args.ToArray());

                JObject o = JObject.Parse(json);

                IList<JToken> results = o["torrents"].Children().ToList();

                foreach (JToken result in results)
                {
                    TorrentFile f = TorrentFile.ConvertStringArray(JsonConvert.DeserializeObject<string[]>(result.ToString()));

                    l.Add(f);
                }
            }
            catch { }

            return l;
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

        private string _Get(string action, KeyValuePair<string, string>[] args)
        {
            List<KeyValuePair<string, string>> l = new List<KeyValuePair<string, string>>();
            l.Add(new KeyValuePair<string, string>("action", action));
            l.AddRange(args);

            return this._Get(l.ToArray());
        }

        private string _Get(KeyValuePair<string, string>[] args)
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

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(sb.ToString());

                string authInfo = this._Config.Username + ":" + this._Config.Password;
                authInfo = Convert.ToBase64String(Encoding.Default.GetBytes(authInfo));
                request.Headers["Authorization"] = "Basic" + authInfo;
            
            
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream resStream = response.GetResponseStream();

                StreamReader reader = new StreamReader(resStream);

                string json = reader.ReadToEnd();

                reader.Close();
                resStream.Close();
                response.Close();

                return json;
            }
            catch
            {
                if (LoginError != null)
                    LoginError();
                return "";
            }
        }

        public Config Config
        {
            get { return this._Config; }
            set { this._Config = value; }
        }
    }

    public class LoginException : ApplicationException
    {
    }
}
