using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace uTorrentNotifier
{
    public partial class Config
    {
        private string _URI             = "";
        private string _Username        = "";
        private string _Password        = "";

        private bool _RunOnStartup      = false;
        private bool _ShowBalloonTips   = true;

        public ProwlConfig Prowl = new ProwlConfig();

        public Config()
        {
            try
            {
                this._URI = Properties.Settings.Default.URI;
            }
            catch { }

            try
            {
                this._Username = Properties.Settings.Default.Username;
            }
            catch { }

            try
            {
                this._Password = Properties.Settings.Default.Password;
            }
            catch { }

            try
            {
                this._RunOnStartup = Properties.Settings.Default.RunOnStartup;
            }
            catch { }

            try
            {
                this._ShowBalloonTips = Properties.Settings.Default.ShowBalloonTips;
            }
            catch { }
        }

        public void Save()
        {
            Properties.Settings.Default.Save();
        }

        public string URI
        {
            get { return this._URI; }
            set 
            {
                string uri = value.TrimEnd('/');

                Properties.Settings.Default.URI = uri;
                this._URI = uri; 
            }
        }
        public string Username
        {
            get { return this._Username; }
            set 
            {
                Properties.Settings.Default.Username = value;
                this._Username = value; 
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
                Microsoft.Win32.RegistryKey key = 
                    Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

                if (value)
                    key.SetValue(Properties.Settings.Default.ApplicationName, System.Windows.Forms.Application.ExecutablePath.ToString());
                else
                    key.DeleteValue(Properties.Settings.Default.ApplicationName, false);

                Properties.Settings.Default.RunOnStartup = value;
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
    }
}
