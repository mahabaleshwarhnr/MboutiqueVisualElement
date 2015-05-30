using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace MboutiqueVisualElement
{
	class SubTotalViewModel
	{  
		//public ItemPriceScreen item =new ItemPriceScreen();
		public ObservableCollection<SubTotalModel> getSubTotal { get; set; } 
		public SubTotalViewModel()
		{
			getSubTotal = new ObservableCollection<SubTotalModel>();
			getSubTotal.Add(new SubTotalModel
					{
						Subtotal=12000
					});
		}
	}

}

