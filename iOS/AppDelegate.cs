using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;
using SQLite.Net.Platform.XamarinIOS;
using Toasts.Forms.Plugin.iOS;

namespace MboutiqueVisualElement.iOS
{
	[Register ("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init ();

			ToastNotificatorImplementation.Init();

			string dbPath = FileAccessHelper.GetLocalFilePath ("Mboutiquedatabse.db3");
			LoadApplication (new App (dbPath, new SQLitePlatformIOS ()));

			return base.FinishedLaunching (app, options);
		}
	}
}

