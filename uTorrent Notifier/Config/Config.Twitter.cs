using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace uTorrentNotifier
{
    public partial class Config
    {
        public class TwitterConfig
        {
            private string _ConsumerKey = "";
            private string _ConsumerSecret = "";
            private string _Token = "";
            private string _TokenSecret = "";
            private string _Pin = "";

            private bool _Enable = false;

            public TwitterConfig()
            {
                this._ConsumerKey = Properties.Settings.Default.TwitterConsumerKey;
                this._ConsumerSecret = Properties.Settings.Default.TwitterConsumerSecret;
                this._Token = Properties.Settings.Default.TwitterToken;
                this._TokenSecret = Properties.Settings.Default.TwitterTokenSecret;
                this._Pin = Properties.Settings.Default.TwitterPIN;
                this._Enable = Properties.Settings.Default.TwitterEnable;
            }

            public string ConsumerKey
            {
                get { return this._ConsumerKey; }
            }

            public string ConsumerSecret
            {
                get { return this._ConsumerSecret; }
            }

            public string Token
            {
                get { return this._Token; }
                set
                {
                    Properties.Settings.Default.TwitterToken = value;
                    this._Token = value;
                }
            }

            public string TokenSecret
            {
                get { return this._TokenSecret; }
                set
                {
                    Properties.Settings.Default.TwitterTokenSecret = value;
                    this._TokenSecret = value;
                }
            }

            public string Pin
            {
                get { return this._Pin; }
                set
                {
                    Properties.Settings.Default.TwitterPIN = value;
                    this._Pin = value;
                }
            }

            public bool Enable
            {
                get { return this._Enable; }
                set
                {
                    Properties.Settings.Default.TwitterEnable = value;
                    this._Enable = value;
                }
            }
        }
    }
}