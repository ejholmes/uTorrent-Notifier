using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace uTorrentNotifier
{
    public partial class Config
    {
        public const string LatestVersion = "http://ejholmes.github.com/uTorrent-Notifier/latest";
        public const string LatestDownload = "http://github.com/downloads/ejholmes/uTorrent-Notifier/setup.exe";
        private string _Uri             = "";
        private string _UserName        = "";
        private string _Password        = "";

        private bool _RunOnStartup      = false;
        private bool _ShowBalloonTips   = true;
        private bool _CheckForUpdates   = false;

        public ProwlConfig Prowl = new ProwlConfig();
		public GrowlConfig Growl = new GrowlConfig();
        public TwitterConfig Twitter = new TwitterConfig();
        public BoxcarConfig Boxcar = new BoxcarConfig();
        public NotificationsConfig Notifications = new NotificationsConfig();

        public Config()
        {
            this._Uri = Properties.Settings.Default.URI;
            this._UserName = Properties.Settings.Default.UserName;
            this._Password = Properties.Settings.Default.Password;
            this._RunOnStartup = Properties.Settings.Default.RunOnStartup;
            this._ShowBalloonTips = Properties.Settings.Default.ShowBalloonTips;
            this._CheckForUpdates = Properties.Settings.Default.CheckForUpdates;
        }

        public void Save()
        {
            /* Save registry info only if we're changing the value */
            if (this._RunOnStartup != Properties.Settings.Default.RunOnStartup)
            {
                Microsoft.Win32.RegistryKey key =
                    Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

                if (this._RunOnStartup)
                    key.SetValue(Properties.Settings.Default.ApplicationName, System.Windows.Forms.Application.ExecutablePath.ToString());
                else
                    key.DeleteValue(Properties.Settings.Default.ApplicationName, false);

                Properties.Settings.Default.RunOnStartup = this._RunOnStartup;
            }
            Properties.Settings.Default.Save();
        }

        public string Uri
        {
            get { return this._Uri; }
            set 
            {
                string uri = value.TrimEnd('/');

                Properties.Settings.Default.URI = uri;
                this._Uri = uri; 
            }
        }
        public string UserName
        {
            get { return this._UserName; }
            set 
            {
                Properties.Settings.Default.UserName = value;
                this._UserName = value; 
            }
        }
        public string Password
        {
            get { return this._Password; }
            set 
            {
                Properties.Settings.Default.Password = value;
                this._Password = value; 
            }
        }

        public bool RunOnStartup
        {
            get { return this._RunOnStartup; }
            set 
            {
                this._RunOnStartup = value;
            }
        }

        public bool ShowBalloonTips
        {
            get { return this._ShowBalloonTips; }
            set
            {
                Properties.Settings.Default.ShowBalloonTips = value;
                this._ShowBalloonTips = value;
            }
        }

        public bool CheckForUpdates
        {
            get { return this._CheckForUpdates; }
            set
            {
                Properties.Settings.Default.CheckForUpdates = value;
                this._CheckForUpdates = value;
            }
        }
    }
}
