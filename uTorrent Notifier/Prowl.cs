using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

using ExtensionMethods;

namespace uTorrentNotifier
{
    class Prowl
    {
        private string _uri = "https://prowl.weks.net/publicapi/";

        List<KeyValuePair<string, string>> defaults = new List<KeyValuePair<string,string>>();

        public Prowl(string apikey, string providerkey)
        {
            defaults.Add(new KeyValuePair<string,string>("apikey", apikey));
            defaults.Add(new KeyValuePair<string, string>("providerkey", providerkey));
        }

        public Prowl(string apikey) : this(apikey, "") { }

        public void add(string message, List<KeyValuePair<string, string>> options)
        {
            List<KeyValuePair<string, string>> data = new List<KeyValuePair<string, string>>();

            data.AddRange(options);
            data.Merge(defaults);
            data.Add(new KeyValuePair<string, string>("event", message));


            //this._api("add", data);
        }

        private void _api(string method, List<KeyValuePair<string, string>> data)
        {
            WebRequest request = WebRequest.Create(this._uri);
            ((HttpWebRequest)request).UserAgent = "uTorrent Notifier";
            request.ContentType = "appication/x-www-form-urlencoded";
            request.Method = "POST";

            StringBuilder sb = new StringBuilder();

            foreach (KeyValuePair<string, string> kv in data)
            {
                if (sb.Length > 0)
                    sb.Append("&");

                sb.Append(kv.Key);
                sb.Append("=");
                sb.Append(kv.Value);
            }

            byte[] bytes = Encoding.ASCII.GetBytes(sb.ToString());
            Stream os = null;

            request.ContentLength = bytes.Length;
            os = request.GetRequestStream();
            os.Write(bytes, 0, bytes.Length);

        }
    }
}
