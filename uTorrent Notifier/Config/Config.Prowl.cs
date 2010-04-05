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
            private string _APIKey = "";

            private bool _Enable                        = false;

            public ProwlConfig()
            {
                try
                {
                    this._APIKey = Properties.Settings.Default.ProwlAPIKey;
                }
                catch { }

                try
                {
                    this._Enable = Properties.Settings.Default.ProwlEnable;
                }
                catch { }
            }

            public string APIKey
            {
                get { return this._APIKey; }
                set
                {
                    Properties.Settings.Default.ProwlAPIKey = value;
                    this._APIKey = value;
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
