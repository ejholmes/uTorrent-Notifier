using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Web;
using System.Threading;
using System.ComponentModel;

using ExtensionMethods;

namespace uTorrentNotifier
{
    public class Twitter
    {
        private Config.TwitterConfig TwitterConfig;
        private oAuthTwitter oAuth;

        public Twitter(Config.TwitterConfig twitterConfig)
		{
            this.TwitterConfig = twitterConfig;
		}

        public void Update(string message)
        {
            BackgroundWorker bw = new BackgroundWorker();
            bw.WorkerReportsProgress = false;
            bw.WorkerSupportsCancellation = false;
            bw.DoWork += new DoWorkEventHandler(bw_Update);
            bw.RunWorkerAsync(message);
        }

        void bw_Update(object sender, DoWorkEventArgs e)
        {
            try
            {
                oAuth = new oAuthTwitter();
                oAuth.ConsumerKey = TwitterConfig.ConsumerKey;
                oAuth.ConsumerSecret = TwitterConfig.ConsumerSecret;
                oAuth.Token = TwitterConfig.Token;
                oAuth.TokenSecret = TwitterConfig.TokenSecret;

                string tweet = HttpUtility.UrlEncode(e.Argument.ToString());

                if (tweet.Length > 140) tweet = tweet.Substring(0, 140);

                string xml = oAuth.oAuthWebRequest(
                    oAuthTwitter.Method.POST,
                    "http://twitter.com/statuses/update.xml",
                    "status=" + tweet
                    );
            }
            catch
            {
            }
        }
    }
}