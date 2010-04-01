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
        public event DownloadFinishedEventHandler DownloadComplete;

        public delegate void TorrentAddedEventHandler(List<TorrentFile> added);
        public event TorrentAddedEventHandler TorrentAdded;

        private Timer timer = new Timer();

        private Config _Config;
        private List<TorrentFile> last = new List<TorrentFile>();

        public WebUIAPI(Config cfg)
        {
            this._Config = cfg;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 5000;
        }

        public void Start()
        {
            timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            List<TorrentFile> current = new List<TorrentFile>();
            current = this.List();
        }

        public List<TorrentFile> FindDone(List<TorrentFile> current, List<TorrentFile> last)
        {
            List<TorrentFile> finishedTorrents = new List<TorrentFile>();

            foreach (TorrentFile currentTorrent in current)
            {
                foreach (TorrentFile lastTorrent in last)
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

            return finishedTorrents;
        }

        public List<TorrentFile> FindNew(List<TorrentFile> current, List<TorrentFile> last)
        {
            List<TorrentFile> newTorrents = new List<TorrentFile>();

            foreach (TorrentFile currentTorrent in current)
            {
                TorrentFile result = last.Find(item => item.Hash == currentTorrent.Hash);

                if (result == null)
                    newTorrents.Add(currentTorrent);
            }

            return newTorrents;
        }

        public string Get(string action, params KeyValuePair<string, string>[] args)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(this._Config.URI);
            sb.Append("?action=");
            sb.Append(action);

            foreach (KeyValuePair<string, string> kv in args)
            {
                sb.Append("&");
                sb.Append(kv.Key);
                sb.Append("=");
                sb.Append(kv.Value);
            }

            return this._Get(sb.ToString());
        }

        public string Get(string action)
        {
            return this.Get(action, null);
        }

        public List<TorrentFile> List()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(this._Config.URI);
            sb.Append("?list=1");

            string json = this._Get(sb.ToString());

            List<TorrentFile> l = new List<TorrentFile>();

            JObject o = JObject.Parse(json);

            IList<JToken> results = o["torrents"].Children().ToList();

            foreach (JToken result in results)
            {
                TorrentFile f = TorrentFile.ConvertStringArray(JsonConvert.DeserializeObject<string[]>(result.ToString()));

                l.Add(f);
            }

            List<TorrentFile> completed = this.FindDone(l, last);
            List<TorrentFile> added = this.FindNew(l, last);

            if (completed.Count > 0)
                DownloadComplete(completed);

            if (added.Count > 0)
                TorrentAdded(added);

            return l;
        }

        private string _Get(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

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

        public Config Config
        {
            get { return this._Config; }
            set { this._Config = value; }
        }
    }
}
