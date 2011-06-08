using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using Microsoft.Win32;

namespace uTorrentNotifier
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
        private int _Eta; // seconds
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
            TorrentFile torrentFile = new TorrentFile();

            torrentFile.Hash                  = file[0];
            torrentFile.Status                = Int32.Parse(file[1], CultureInfo.CurrentCulture);
            torrentFile.Name                  = file[2];
            torrentFile.Size                  = double.Parse(file[3], CultureInfo.CurrentCulture);
            torrentFile.PercentProgress       = Int32.Parse(file[4], CultureInfo.CurrentCulture);
            torrentFile.Downloaded            = double.Parse(file[5], CultureInfo.CurrentCulture);
            torrentFile.Uploaded              = double.Parse(file[6], CultureInfo.CurrentCulture);
            torrentFile.Ratio                 = Int32.Parse(file[7], CultureInfo.CurrentCulture);
            torrentFile.UploadSpeed           = Int32.Parse(file[8], CultureInfo.CurrentCulture);
            torrentFile.DownloadSpeed         = Int32.Parse(file[9], CultureInfo.CurrentCulture);
            torrentFile.Eta                   = Int32.Parse(file[10], CultureInfo.CurrentCulture);
            torrentFile.Label                 = file[11];
            torrentFile.PeersConnected        = Int32.Parse(file[12], CultureInfo.CurrentCulture);
            torrentFile.PeersInSwarm          = Int32.Parse(file[13], CultureInfo.CurrentCulture);
            torrentFile.SeedsConnected        = Int32.Parse(file[14], CultureInfo.CurrentCulture);
            torrentFile.SeedsInSwarm          = Int32.Parse(file[15], CultureInfo.CurrentCulture);
            torrentFile.Availability          = double.Parse(file[16], CultureInfo.CurrentCulture);
            torrentFile.TorrentQueueOrder     = Int32.Parse(file[17], CultureInfo.CurrentCulture);
            torrentFile.Remaining             = double.Parse(file[18], CultureInfo.CurrentCulture);
            torrentFile.TorrentSource         = "";
            torrentFile.RssFeed               = "";
            torrentFile.StatusString          = "";

            if (file.Length > 19)
            {
                torrentFile.TorrentSource = file[19];
                torrentFile.RssFeed = file[20];
                torrentFile.StatusString = file[21];
            }

            return torrentFile;
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

        public int Eta
        {
            get { return this._Eta; }
            set { this._Eta = value; }
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
