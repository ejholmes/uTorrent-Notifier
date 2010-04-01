using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace µTorrent
{
    public class Config
    {
        private string _URI = "";
        private string _Username = "";
        private string _Password = "";

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
    }
}
