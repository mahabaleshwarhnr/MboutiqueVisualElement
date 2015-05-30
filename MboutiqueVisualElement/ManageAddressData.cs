using System;

using Xamarin.Forms;
using SQLite.Net.Interop;
using SQLite.Net;
using System.Diagnostics;
using SQLite.Net.Attributes;

namespace MboutiqueVisualElement
{
	[Table("ManageAddressData")]
	public class ManageAddressData
	{
		public ManageAddressData () {
			 
			}
		[PrimaryKey,AutoIncrement]
		public int ID { get; set;}
		public string Housenumber{ get; set;}
		public string Streetname{ get; set;}
		public string Zipcode{ get; set;}
		public string CountryName { get; set;}
		public string StateName{ get; set;}
		public string CityName{ get; set;}

	}

}


