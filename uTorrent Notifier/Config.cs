using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace uTorrentNotifier
{
    public class Config
    {
        private string _URI             = "";
        private string _Username        = "";
        private string _Password        = "";
        private string _ProwlAPIKey     = "";

        private bool _ProwlEnable               = false;
        private bool _ProwlNotificationMode     = false;
        private bool _RunOnStartup              = false;

        public Config()
        {
            try
            {
                this._URI = Properties.Settings.Default.URI;
            }
            catch { }

            try
            {
                this._Username = Properties.Settings.Default.username;
            }
            catch { }

            try
            {
                this._Password = Properties.Settings.Default.password;
            }
            catch { }

            try
            {
                this._ProwlAPIKey = Properties.Settings.Default.prowlapikey;
            }
            catch { }

            try
            {
                this._ProwlEnable = Properties.Settings.Default.prowlenable;
            }
            catch { }

            try
            {
                this._ProwlNotificationMode = Properties.Settings.Default.prowlnotificationmode;
            }
            catch { }

            try
            {
                this._RunOnStartup = Properties.Settings.Default.RunOnStartup;
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
                Properties.Settings.Default.URI = value;
                this._URI = value; 
            }
        }
        public string Username
        {
            get { return this._Username; }
            set 
            {
                Properties.Settings.Default.username = value;
                this._Username = value; 
            }
        }
        public string Password
        {
            get { return this._Password; }
            set 
            {
                Properties.Settings.Default.password = value;
                this._Password = value; 
            }
        }

        public string ProwlAPIKey
        {
            get { return this._ProwlAPIKey; }
            set 
            {
                Properties.Settings.Default.prowlapikey = value;
                this._ProwlAPIKey = value; 
            }
        }

        public bool ProwlEnable
        {
            get { return this._ProwlEnable; }
            set 
            {
                Properties.Settings.Default.prowlenable = value;
                this._ProwlEnable = value; 
            }
        }

        public bool ProwlNotificationMode
        {
            get { return this._ProwlNotificationMode; }
            set 
            {
                Properties.Settings.Default.prowlnotificationmode = value;
                this._ProwlNotificationMode = value; 
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
                    key.SetValue(Properties.Settings.Default.applicationName, System.Windows.Forms.Application.ExecutablePath.ToString());
                else
                    key.DeleteValue(Properties.Settings.Default.applicationName, false);

                Properties.Settings.Default.RunOnStartup = value;
                this._RunOnStartup = value;
            }
        }
    }
}
