using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace uTorrentNotifier
{
    public partial class Config
    {
        public class ProwlConfig
        {
            private string _ApiKey = String.Empty;

            private bool _Enable                        = false;

            public ProwlConfig()
            {
                this._ApiKey = Properties.Settings.Default.ProwlAPIKey;
                this._Enable = Properties.Settings.Default.ProwlEnable;
            }

            public string ApiKey
            {
                get { return this._ApiKey; }
                set
                {
                    Properties.Settings.Default.ProwlAPIKey = value;
                    this._ApiKey = value;
                }
            }

            public bool Enable
            {
                get { return this._Enable; }
                set
                {
                    Properties.Settings.Default.ProwlEnable = value;
                    this._Enable = value;
                }
            }
        }
    }
}
