using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Windows.Forms;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace uTorrentNotifier
{
    public partial class WebUIAPI
    {
        public delegate void DownloadFinishedEventHandler(List<TorrentFile> finished);
        public delegate void TorrentAddedEventHandler(List<TorrentFile> added);
        public delegate void WebUIErrorEventHandler(object sender, Exception e);
        public delegate void UpdatedListEventHandler(List<TorrentFile> torrents);

        public event DownloadFinishedEventHandler DownloadComplete;
        public event TorrentAddedEventHandler TorrentAdded;
        public event WebUIErrorEventHandler WebUIError;
        public event UpdatedListEventHandler UpdatedList;

        public class DownloadFinishedEventArgs : EventArgs
        {
        }

        public class TorrentAddedEventArgs : EventArgs
        {
        }

        public class LogOnErrorEventArgs : EventArgs
        {
        }

        public class UpdatedListEventArgs : EventArgs
        {
        }
    }
}