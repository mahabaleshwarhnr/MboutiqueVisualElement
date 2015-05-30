using System;

using Xamarin.Forms;
using SQLite.Net.Interop;

namespace MboutiqueVisualElement
{
	public class App : Application
	{
		public static MboutiqueDatabase Database { get; private set; }
		public App (string dbPath, ISQLitePlatform sqlitePlatform)
		{
			// The root page of your application
			Database=new MboutiqueDatabase(dbPath,sqlitePlatform);
			//RegistrationPage registerPage = new RegistrationPage ();
			//CatlogPageView catlogPage=new CatlogPageView();
			//AboutPage aboutMe= new AboutPage()

			MainPage = new NavigationPage (new ManagaeProfile()) {
				BarBackgroundColor=Device.OnPlatform(Color.FromHex("7E48E1"),Color.FromHex("8C546D"),Color.Default)
			  };
		}


	}
}

