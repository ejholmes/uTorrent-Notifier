using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace uTorrentNotifier
{
    class CommandLine
    {
        private Config Config = new Config();
        private WebUIAPI utorrent;

        public CommandLine()
        {
            utorrent = new WebUIAPI(this.Config);
        }

        public void ProcessArgs(string[] args)
        {
        }
    }
}
