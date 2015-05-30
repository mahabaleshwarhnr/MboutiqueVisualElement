using System;
using SQLite.Net.Attributes;

namespace MboutiqueVisualElement
{
	public class AddressItem
	{
		public AddressItem ()
		{
		}
		[PrimaryKey, AutoIncrement]
		public int ID { get; set; }
		public string Name { get; set; }
		public string Notes { get; set; }


	}
}

