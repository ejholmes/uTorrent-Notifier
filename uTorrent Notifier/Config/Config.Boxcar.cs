using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace uTorrentNotifier
{
    public partial class Config
    {
        public class BoxcarConfig
        {
            private bool _Enable            = false;
            private string _APIKey          = String.Empty;
            private string _Email           = String.Empty;

            public BoxcarConfig()
            {
                this._Email = Properties.Settings.Default.BoxcarEmail;
                this._Enable = Properties.Settings.Default.BoxcarEnable;
            }

            public bool Enable
            {
                get { return this._Enable; }
                set
                {
                    Properties.Settings.Default.BoxcarEnable = value;
                    this._Enable = value;
                }
            }

            public string APIKey
            {
                get { return this._APIKey; }
                set
                {
                    this._APIKey = value;
                }
            }

            public string Email
            {
                get { return this._Email; }
                set
                {
                    Properties.Settings.Default.BoxcarEmail = value;
                    this._Email = value;
                }
            }

            public string MD5Email
            {
                get { return BitConverter.ToString(new MD5CryptoServiceProvider().ComputeHash(Encoding.UTF8.GetBytes(this._Email))).Replace("-", "").ToLower(); }
            }
        }
    }
}
