using System;

using Xamarin.Forms;
using SQLite.Net.Interop;
using SQLite.Net;
using System.Diagnostics;
using SQLite.Net.Attributes;


namespace MboutiqueVisualElement
{
	public class CatlougeData
	{
		public CatlougeData () {
			
			}
		[PrimaryKey,AutoIncrement]
		public int ID{ get; set;}
		public string Image{ get; set;}
		public string Name { get; set;}
		public int ProductQuantity{ get; set;}
		public int Price{ get; set;}
		public int SubTotal { get; set;}

		
	}

}


