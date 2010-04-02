using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Web;

using ExtensionMethods;

namespace uTorrentNotifier
{
    class Prowl
    {
        public enum Priority
        {
            VeryLow = -2,
            Moderate = -1,
            Normal = 0,
            High = 1,
            Emergency = 2
        }
        private string _uri = "https://prowl.weks.net/publicapi/";
        private string _application = "uTorrent Notifier";
        private string _description = "";
        private string _providerKey = "";

        private Priority _priority = Priority.Normal;

        List<KeyValuePair<string, string>> defaults = new List<KeyValuePair<string,string>>();

        public Prowl(string apikey)
        {
            defaults.Add(new KeyValuePair<string, string>("apikey", apikey));
            defaults.Add(new KeyValuePair<string, string>("providerkey", this._providerKey));
            defaults.Add(new KeyValuePair<string, string>("priority", this._priority.ToString()));
            defaults.Add(new KeyValuePair<string, string>("application", this._application));
            defaults.Add(new KeyValuePair<string, string>("description", this._description));
        }

        public void Add(string message, List<KeyValuePair<string, string>> options)
        {
            List<KeyValuePair<string, string>> data = new List<KeyValuePair<string, string>>();

            data.AddRange(options);
            data = data.Merge(defaults);
            data.Add(new KeyValuePair<string, string>("event", message));

            this._api("add", data);
        }

        public void Add(string message, string description)
        {
            List<KeyValuePair<string, string>> opts = new List<KeyValuePair<string, string>>();
            opts.Add(new KeyValuePair<string, string>("description", description));

            this.Add(message, opts);
        }

        public void Add(string message)
        {
            this.Add(message, new List<KeyValuePair<string, string>>());
        }

        private void _api(string method, List<KeyValuePair<string, string>> data)
        {
            StringBuilder sb = new StringBuilder();

            foreach (KeyValuePair<string, string> kv in data)
            {
                if (sb.Length > 0)
                    sb.Append("&");

                sb.Append(HttpUtility.UrlEncode(kv.Key));
                sb.Append("=");
                sb.Append(HttpUtility.UrlEncode(kv.Value));
            }

            string url = this._uri + method + "?" + sb.ToString(); 

            WebRequest request = WebRequest.Create(url);
            ((HttpWebRequest)request).UserAgent = "uTorrent Notifier";
            request.ContentType = "appication/x-www-form-urlencoded";
            request.Method = "POST";

            request.GetResponse();
        }
    }
}
