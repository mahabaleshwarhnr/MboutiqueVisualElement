using System;
using SQLite.Net;
using Xamarin.Forms;

namespace MboutiqueVisualElement
{
	public class AddressItemDatabase
	{
		static object locker = new object ();

		SQLiteConnection database;
		public AddressItemDatabase ()
		{
				database = DependencyService.Get<ISQLite> ().GetConnection ();
			database.CreateTable<AddressItem>();
		}
	}
}

