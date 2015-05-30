using System;

using Xamarin.Forms;
using SQLite.Net.Interop;
using SQLite.Net;
using System.Diagnostics;

using SQLite.Net.Attributes;

namespace MboutiqueVisualElement
{
	[Table("NewUserProfileData")]
	public class NewUserProfileData
	{
				public NewUserProfileData () {
					
			}
		[PrimaryKey,AutoIncrement]
		public int ID{ get; set;}
		public string UserName{ get; set;}
		public string UserPassword { get; set;}
		public string UserMobileNum { get; set;}
		public string UserPhone { get; set;}
	}

}


