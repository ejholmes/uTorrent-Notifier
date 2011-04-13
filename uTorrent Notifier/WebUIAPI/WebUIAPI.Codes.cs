using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace uTorrentNotifier
{
    public partial class WebUIAPI
    {

        public struct Action
        {
            public const string AddUrl = "add-url";
            public const string AddFile = "add-file";

            public const string Start = "start";
            public const string Stop = "stop";
            public const string Pause = "pause";
            public const string Unpause = "unpause";
            public const string ForceStart = "forcestart";
            public const string Recheck = "recheck";
            public const string Remove = "remove";
            public const string RemoveData = "removedata";
            public const string SetPriority = "setprio";
        }

        public struct Property
        {
            public const string Hash = "hash";
        }

        public struct StatusString
        {
            public const string Downloading = "Downloading";
            public const string Seeding = "Seeding";

        }

        protected enum TypeCode
        {
            Integer = 0,
            Boolean = 1,
            String = 2
        }

        protected enum StatusCode
        {
            None = 0,
            Started = 1,
            Checking = 2,
            StartAfterCheck = 4,
            Checked = 8,
            Error = 16,
            Paused = 32,
            Queued = 64,
            Loaded = 128
        }

        protected enum PriorityCode
        {
            DoNotDownload = 0,
            LowPriority = 1,
            NormalPriority = 2,
            HighPriority = 3
        }

        protected enum TrackerCode
        {
            NotAllowed = -1,
            Disabled = 0,
            Enabled = 1
        }
    }
}
