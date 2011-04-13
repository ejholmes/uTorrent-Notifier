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
        public Config Config;
        private Timer Timer;
        private string Token;
        private CookieContainer Cookies;
        private TorrentListing Torrents;

        public WebUIAPI(Config config)
        {
            this.Config         = config;
            this.Torrents       = new TorrentListing();
            this.Timer          = new Timer();
            this.Cookies        = new CookieContainer();

            this.Timer.Tick += new EventHandler(Timer_Tick);
            this.Timer.Interval = 5000;
        }

        public void Start()
        {
            this.Token = this.GetToken();

            if (this.Token == null)
                return;

            this.Timer.Start();
        }

        public void Stop()
        {
            this.Timer.Stop();
        }

        void Timer_Tick(object sender, EventArgs e)
        {
            this.Torrents.Current = this.ListTorrents();

            if (this.Torrents.Last != null)
            {
                List<TorrentFile> completed = this.FindDone();
                List<TorrentFile> added = this.FindNew();

                if ((completed.Count > 0) && (this.DownloadComplete != null))
                    this.DownloadComplete(completed);

                if ((added.Count > 0) && (this.TorrentAdded != null))
                    this.TorrentAdded(added);
            }
        }

        private string GetToken()
        {
            try
            {
                if (String.IsNullOrEmpty(this.Config.Uri))
                    return null;
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(this.Config.Uri + "/token.html");
                request.Credentials = new NetworkCredential(this.Config.UserName, this.Config.Password);
                request.CookieContainer = Cookies;

                Stream resStream = request.GetResponse().GetResponseStream();
                string token = System.Text.RegularExpressions.Regex.Replace(new StreamReader(resStream).ReadToEnd(), @"(<[^>]+>)", string.Empty);
                resStream.Close();

                return token;
            }
            catch (WebException webex)
            {
                if (LogOnError != null)
                    LogOnError(this, webex);
                return null;
            }
        }

        private List<TorrentFile> ListTorrents()
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
            sb.Append(this.Config.Uri);
            sb.Append("/?");

            foreach (KeyValuePair<string, string> kv in args)
            {
                sb.Append(kv.Key);
                sb.Append("=");
                sb.Append(kv.Value);
                sb.Append("&");
            }

            return this.Get(sb.ToString());
        }

        private string Get(string get)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(get);
            request.Credentials = new NetworkCredential(this.Config.UserName, this.Config.Password);
            request.CookieContainer = Cookies;

            Stream resStream = request.GetResponse().GetResponseStream();
            string html = new StreamReader(resStream).ReadToEnd();
            resStream.Close();

            return html;
        }

        private List<TorrentFile> FindDone()
        {
            List<TorrentFile> finishedTorrents = new List<TorrentFile>();

            if (this.Torrents.Last.Count > 0 && this.Torrents.Current != null)
            {
                foreach (TorrentFile currentTorrent in this.Torrents.Current)
                {
                    foreach (TorrentFile lastTorrent in this.Torrents.Last)
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

            if (this.Torrents.Last != null)
            {
                foreach (TorrentFile currentTorrent in this.Torrents.Current)
                {
                    TorrentFile result = this.Torrents.Last.Find(item => item.Hash == currentTorrent.Hash);

                    if (result == null)
                        newTorrents.Add(currentTorrent);
                }
            }

            return newTorrents;
        }

        public bool Stopped
        {
            get { return !this.Timer.Enabled; }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.Timer.Dispose();
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }

    class TorrentListing
    {
        private List<TorrentFile> _Last;
        private List<TorrentFile> _Current;

        public TorrentListing()
        {
            this._Last = null;
            this._Current = null;
        }

        public List<TorrentFile> Last
        {
            get { return this._Last; }
            set { this._Last = value; }
        }

        public List<TorrentFile> Current
        {
            get { return this._Current; }
            set
            {
                this._Last = this._Current;
                this._Current = value;
            }
        }
    }
}
