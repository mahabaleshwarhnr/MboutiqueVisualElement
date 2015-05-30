using System;

using Xamarin.Forms;
using SQLite.Net.Interop;
using SQLite.Net;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using SQLite.Net.Attributes;


namespace MboutiqueVisualElement
{
	public class FavouriteData
	{
		public FavouriteData () {
			
			}
		[PrimaryKey,AutoIncrement]
		public int ID { get; set;}
		public string Image { get; set;}
		public string Name {get;set;}
		public string smallDetail{ get; set; }
		public int Price { get; set; }

	}

}


