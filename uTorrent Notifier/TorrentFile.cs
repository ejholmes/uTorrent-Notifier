using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace µTorrent
{
    public class TorrentFile
    {
        private string _Hash;
        private string _Name;
        private string _Label;
        private string _TorrentSource;
        private string _RssFeed;
        private string _StatusString;

        private int _Status;
        private int _PercentProgress;
        private int _Ratio;
        private int _UploadSpeed; // bytes per second
        private int _DownloadSpeed; // bytes per second
        private int _ETA; // seconds
        private int _PeersConnected;
        private int _PeersInSwarm;
        private int _SeedsConnected;
        private int _SeedsInSwarm;
        private int _TorrentQueueOrder;

        private double _Size; // in bytes
        private double _Downloaded; // in bytes
        private double _Uploaded; // in bytes
        private double _Availability; // integer in 1/65536ths
        private double _Remaining; // in bytes

        public static TorrentFile ConvertStringArray(string[] file)
        {
            TorrentFile f = new TorrentFile();

            f.Hash                  = file[0];
            f.Status                = Int32.Parse(file[1]);
            f.Name                  = file[2];
            f.Size                  = double.Parse(file[3]);
            f.PercentProgress       = Int32.Parse(file[4]);
            f.Downloaded            = double.Parse(file[5]);
            f.Uploaded              = double.Parse(file[6]);
            f.Ratio                 = Int32.Parse(file[7]);
            f.UploadSpeed           = Int32.Parse(file[8]);
            f.DownloadSpeed         = Int32.Parse(file[9]);
            f.ETA                   = Int32.Parse(file[10]);
            f.Label                 = file[11];
            f.PeersConnected        = Int32.Parse(file[12]);
            f.PeersInSwarm          = Int32.Parse(file[13]);
            f.SeedsConnected        = Int32.Parse(file[14]);
            f.SeedsInSwarm          = Int32.Parse(file[15]);
            f.Availability          = double.Parse(file[16]);
            f.TorrentQueueOrder     = Int32.Parse(file[17]);
            f.Remaining             = double.Parse(file[18]);
            f.TorrentSource         = file[19];
            f.RssFeed               = file[20];
            f.StatusString          = file[21];

            return f;
        }

        public string Hash
        {
            get { return this._Hash; }
            set { this._Hash = value; }
        }

        public string Name
        {
            get { return this._Name; }
            set { this._Name = value; }
        }

        public string Label
        {
            get { return this._Label; }
            set { this._Label = value; }
        }

        public int Status
        {
            get { return this._Status; }
            set { this._Status = value; }
        }

        public double Size
        {
            get { return this._Size; }
            set { this._Size = value; }
        }

        public int PercentProgress
        {
            get { return this._PercentProgress; }
            set { this._PercentProgress = value; }
        }

        public double Downloaded
        {
            get { return this._Downloaded; }
            set { this._Downloaded = value; }
        }

        public double Uploaded
        {
            get { return this._Uploaded; }
            set { this._Uploaded = value; }
        }

        public int Ratio
        {
            get { return this._Ratio; }
            set { this._Ratio = value; }
        }

        public int UploadSpeed
        {
            get { return this._UploadSpeed; }
            set { this._UploadSpeed = value; }
        }

        public int DownloadSpeed
        {
            get { return this._DownloadSpeed; }
            set { this._DownloadSpeed = value; }
        }

        public int ETA
        {
            get { return this._ETA; }
            set { this._ETA = value; }
        }

        public int PeersConnected
        {
            get { return this._PeersConnected; }
            set { this._PeersConnected = value; }
        }

        public int PeersInSwarm
        {
            get { return this._PeersInSwarm; }
            set { this._PeersInSwarm = value; }
        }

        public int SeedsConnected
        {
            get { return this._SeedsConnected; }
            set { this._SeedsConnected = value; }
        }

        public int SeedsInSwarm
        {
            get { return this._SeedsInSwarm; }
            set { this._SeedsInSwarm = value; }
        }

        public double Availability
        {
            get { return this._Availability; }
            set { this._Availability = value; }
        }

        public int TorrentQueueOrder
        {
            get { return this._TorrentQueueOrder; }
            set { this._TorrentQueueOrder = value; }
        }

        public double Remaining
        {
            get { return this._Remaining; }
            set { this._Remaining = value; }
        }

        public string TorrentSource
        {
            get { return this._TorrentSource; }
            set { this._TorrentSource = value; }
        }

        public string RssFeed
        {
            get { return this._RssFeed; }
            set { this._RssFeed = value; }
        }

        public string StatusString
        {
            get { return this._StatusString; }
            set { this._StatusString = value; }
        }
    }
}
