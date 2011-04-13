using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace uTorrentNotifier
{
    public partial class Config
    {
		public class GrowlConfig
		{
			private string _Password = "";
			private string _Host = "";
			private string _Port = "";

			private bool _Enable = false;

			public GrowlConfig()
			{
				this._Password = Properties.Settings.Default.GrowlPassword;
				this._Host = Properties.Settings.Default.GrowlHost;
				this._Port = Properties.Settings.Default.GrowlPort;
				this._Enable = Properties.Settings.Default.GrowlEnable;
			}

			public string Password
			{
				get { return this._Password; }
				set
				{
					Properties.Settings.Default.GrowlPassword = value;
					this._Password = value;
				}
			}

			public string Host
			{
				get { return this._Host; }
				set
				{
					Properties.Settings.Default.GrowlHost = value;
					this._Host = value;
				}
			}

			public string Port
			{
				get { return this._Port; }
				set
				{
					Properties.Settings.Default.GrowlPort = value;
					this._Port = value;
				}
			}

			public bool Enable
			{
				get { return this._Enable; }
				set
				{
					Properties.Settings.Default.GrowlEnable = value;
					this._Enable = value;
				}
			}
		}
	}
}
