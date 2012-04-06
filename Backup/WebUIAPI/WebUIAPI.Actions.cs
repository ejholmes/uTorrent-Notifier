using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace uTorrentNotifier
{
    public partial class WebUIAPI
    {
        public void PauseAll()
        {
            this.Torrents.Current = this.ListTorrents();
            List<KeyValuePair<string, string>> hashes = new List<KeyValuePair<string, string>>();
            foreach (TorrentFile f in this.Torrents.Current)
            {
                hashes.Add(new KeyValuePair<string, string>(WebUIAPI.Property.Hash, f.Hash));
            }

            this.Send(Action.Pause, hashes.ToArray());
        }

        public void StartAll()
        {
            this.Torrents.Current = this.ListTorrents();
            List<KeyValuePair<string, string>> hashes = new List<KeyValuePair<string, string>>();
            foreach (TorrentFile f in this.Torrents.Current)
            {
                hashes.Add(new KeyValuePair<string, string>(WebUIAPI.Property.Hash, f.Hash));
            }

            this.Send(Action.Start, hashes.ToArray());
        }
    }
}
