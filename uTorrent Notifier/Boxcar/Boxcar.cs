using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Web;

namespace uTorrentNotifier
{
    public class Boxcar
    {
        private string _uri = "http://boxcar.io";
        private Config.BoxcarConfig BoxcarConfig;

        public Boxcar(Config.BoxcarConfig boxcarConfig)
        {
            this.BoxcarConfig = boxcarConfig;
        }

        public void Add(string message)
        {
            string url = this._uri + "/devices/providers/" + this.BoxcarConfig.ProviderKey + "/notifications";
            try
            {
                WebClient client = new WebClient();
                client.Headers.Add("user-agent", "uTorrent Notifier");
                client.UploadData(url, Encoding.ASCII.GetBytes("email=" + this.BoxcarConfig.MD5Email + "&notification[message]=" + message.Replace(" ", "+")));
            }
            catch (Exception)
            {
            }
        }

        public void SendInvite()
        {
            string url = this._uri + "/devices/providers/" + this.BoxcarConfig.ProviderKey + "/notifications/subscribe";
            try
            {
                WebClient client = new WebClient();
                client.Headers.Add("user-agent", "uTorrent Notifier");
                client.UploadData(url, Encoding.ASCII.GetBytes("email=" + this.BoxcarConfig.MD5Email));
            }
            catch (Exception)
            {
            }
        }
    }
}
