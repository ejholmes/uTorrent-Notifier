using System;
using System.Drawing;
using uTorrentNotifier.Properties;
using Growl.Connector;
using Growl.CoreLibrary;

namespace uTorrentNotifier
{
	public enum GrowlNotificationType
	{
		InfoAdded,
		InfoComplete,
		Error
	}

    public class Growl
    {
		private Config.GrowlConfig GrowlConfig;

		// growl connector
		private GrowlConnector growl;

		// registered growl application
		private Application application;

		// growl notification levels
		private NotificationType added;
		private NotificationType complete;
		private NotificationType error;

		public Growl(Config.GrowlConfig growlConfig)
		{
			this.GrowlConfig = growlConfig;
			RegisterApplication();
		}

		public void Add(GrowlNotificationType type, string message)
		{
			Notification notification = null;

			if (type == GrowlNotificationType.Error)
				notification = new Notification(application.Name, "error", null, "Login Error", message);
			else
				notification = new Notification(application.Name, (type == GrowlNotificationType.InfoAdded ? "Added" : "Complete"), null, (type == GrowlNotificationType.InfoAdded ? "Torrent Added" : "Torrent Downloaded"), message);
			
			growl.Notify(notification);
		}

		private void RegisterApplication()
		{
			if (string.IsNullOrEmpty(GrowlConfig.Host))
				growl = new GrowlConnector(GrowlConfig.Password);
			else
				growl = new GrowlConnector(GrowlConfig.Password, GrowlConfig.Host, int.Parse(GrowlConfig.Port));

			growl.EncryptionAlgorithm = Cryptography.SymmetricAlgorithmType.PlainText;

			application = new Application("uTorrent Notifier");
			application.Icon = GetIconData(Resources.utorrent_icon);

			added = new NotificationType("Added", "Torrent Added", GetIconData(Resources.utorrent_icon_added), true);
			complete = new NotificationType("Complete", "Download Complete", GetIconData(Resources.utorrent_icon_complete), true);
			error = new NotificationType("Error", "uTorrent Error", GetIconData(Resources.utorrent_icon_error), true);

			growl.Register(application, new NotificationType[] { added, complete, error });
		}

		private BinaryData GetIconData(Bitmap Icon)
		{
			return new BinaryData((byte[])System.ComponentModel.TypeDescriptor.GetConverter(Icon).ConvertTo(Icon, typeof(byte[])));
		}
	}
}
