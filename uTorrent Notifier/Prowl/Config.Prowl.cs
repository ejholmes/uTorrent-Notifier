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
            private bool _Notification_DownloadComplete = true;
            private bool _Notification_TorrentAdded     = true;

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

                try
                {
                    this._Notification_TorrentAdded = Properties.Settings.Default.ProwlNotification_TorrentAdded;
                }
                catch { }

                try
                {
                    this._Notification_DownloadComplete = Properties.Settings.Default.ProwlNotification_DownloadComplete;
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

            public bool Notification_TorrentAdded
            {
                get { return this._Notification_TorrentAdded; }
                set
                {
                    Properties.Settings.Default.ProwlNotification_TorrentAdded = value;
                    this._Notification_TorrentAdded = value;
                }
            }

            public bool Notification_DownloadComplete
            {
                get { return this._Notification_DownloadComplete; }
                set
                {
                    Properties.Settings.Default.ProwlNotification_DownloadComplete = value;
                    this._Notification_DownloadComplete = value;
                }
            }
        }
    }
}
