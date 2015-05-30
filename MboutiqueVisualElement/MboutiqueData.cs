using System;

using Xamarin.Forms;
using SQLite.Net.Interop;
using SQLite.Net;
using SQLite.Net.Attributes;

namespace MboutiqueVisualElement
{
	[Table ("ManageProfileData")]
	public class MboutiqueData {
		public MboutiqueData () {
			
			}

		[PrimaryKey,AutoIncrement]
		public int ID{ get; set; }

		public string Name{ get; set; }

		public string Date{ get; set; }

		public string MobileNum{ get; set; }

		public string PhoneNum{ get; set; }
		public string Image { get; set;}
	}

}




