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
            List<TorrentFile> current = new List<TorrentFile>();
            current = this.List();

            if (last != null)
            {
                List<TorrentFile> completed = this.FindDone(current, last);
                List<TorrentFile> added = this.FindNew(current, last);

                if ((completed.Count > 0) && (this.DownloadComplete != null))
                    this.DownloadComplete(completed);

                if ((added.Count > 0) && (this.TorrentAdded != null))
                    this.TorrentAdded(added);
            }

            last = current;
        }

        public List<TorrentFile> FindDone(List<TorrentFile> current, List<TorrentFile> last)
        {
            List<TorrentFile> finishedTorrents = new List<TorrentFile>();

            if (last.Count > 0)
            {
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
            }

            return finishedTorrents;
        }

        public List<TorrentFile> FindNew(List<TorrentFile> current, List<TorrentFile> last)
        {
            List<TorrentFile> newTorrents = new List<TorrentFile>();

            if (last.Count > 0)
            {
                foreach (TorrentFile currentTorrent in current)
                {
                    TorrentFile result = last.Find(item => item.Hash == currentTorrent.Hash);

                    if (result == null)
                        newTorrents.Add(currentTorrent);
                }
            }

            return newTorrents;
        }

        public void PauseAll()
        {

        }

        public void StartAll()
        {

        }

        public List<TorrentFile> List()
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

        private string _Get(KeyValuePair<string, string>[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this._Config.URI);
            sb.Append("/");
            sb.Append("?");

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
