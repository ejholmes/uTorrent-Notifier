using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace uTorrentNotifier
{
    public partial class Config
    {
        public class NotificationsConfig
        {
            private bool _DownloadComplete = true;
            private bool _TorrentAdded = true;

            public NotificationsConfig()
            {
                try
                {
                    this._TorrentAdded = Properties.Settings.Default.Notification_TorrentAdded;
                }
                catch { }

                try
                {
                    this._DownloadComplete = Properties.Settings.Default.Notification_DownloadComplete;
                }
                catch { }
            }

            public bool DownloadComplete
            {
                get { return this._DownloadComplete; }
                set
                {
                    Properties.Settings.Default.Notification_DownloadComplete = value;
                    this._DownloadComplete= value;
                }
            }

            public bool TorrentAdded
            {
                get { return this._TorrentAdded; }
                set
                {
                    Properties.Settings.Default.Notification_TorrentAdded = value;
                    this._TorrentAdded = value;
                }
            }
        }
    }
}
