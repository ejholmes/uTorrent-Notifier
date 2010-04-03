using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace uTorrentNotifier
{
    public partial class WebUIAPI
    {
        public void AddFile(string filelocation)
        {
            this._Post(Action.AddFile, filelocation);
        }

        public void PauseAll()
        {
            this.current = this.List();

            try
            {
                List<KeyValuePair<string, string>> hashes = new List<KeyValuePair<string, string>>();
                foreach (TorrentFile f in this.current)
                {
                    hashes.Add(new KeyValuePair<string, string>(WebUIAPI.Property.Hash, f.Hash));
                }

                this.Send(Action.Pause, hashes.ToArray());
            }
            catch { }
        }

        public void StartAll()
        {
            this.current = this.List();

            try
            {
                List<KeyValuePair<string, string>> hashes = new List<KeyValuePair<string, string>>();
                foreach (TorrentFile f in this.current)
                {
                    hashes.Add(new KeyValuePair<string, string>(WebUIAPI.Property.Hash, f.Hash));
                }

                this.Send(Action.Start, hashes.ToArray());
            }
            catch { }
        }
    }
}
