
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.Threading.Tasks;
using System.Threading;
using Android.Content.PM;

namespace MboutiqueVisualElement.Droid
{
	[Activity (Label = "SplashScreen", ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation,
		MainLauncher=true,Theme = "@android:style/Theme.NoTitleBar")]	
	public class SplashScreen : Activity {
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.Main);

			// Create your application here
		}
		protected override async void OnResume()
		{
			base.OnResume();
			await Task.Run (() => Thread.Sleep (3000));
			StartActivity(typeof(MainActivity));
		}
	}
}

