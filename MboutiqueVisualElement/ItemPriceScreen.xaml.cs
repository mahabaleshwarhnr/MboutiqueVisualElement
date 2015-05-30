using System;
using System.Collections.Generic;

using Xamarin.Forms;
using AjaxControlToolkit.HTMLEditor.ToolbarButton;
using System.ServiceModel.Channels;

namespace MboutiqueVisualElement
{
	
	public partial class ItemPriceScreen : ContentPage
	{
		
		public ItemPriceScreen (MboutiqueVisualElement Catlouge)
		{
			InitializeComponent ();
			this.BindingContext=Catlouge;

			EntryQuantity.TextChanged += (sender, e) => {
				
				if (!String.IsNullOrEmpty (EntryQuantity.Text) && EntryQuantity.Text.Trim () != "0") {
					EntryQuantity.Text=EntryQuantity.Text.TrimStart('0');
					subTotalLbl.Text = ((Int32.Parse (EntryQuantity.Text)) * (Int32.Parse (basicPrice.Text))).ToString ();
				}
			};
			BtnAddToCart.Clicked += (sender, e) => {
				if (String.IsNullOrEmpty (EntryQuantity.Text) || EntryQuantity.Text.Trim () == "0")
					DisplayAlert ("enter the Product Quantity",null, "OK");
				else {
					int productQuantity = Int32.Parse (EntryQuantity.Text);
					int productTotal = Int32.Parse(subTotalLbl.Text);
					var result=App.Database.SavePickedItem(Catlouge,productQuantity,productTotal);
					if (result!=0) {
						Navigation.PushAsync (new PlaceOrderPage ());
					}

				}
			};

		}
//		void productQuantityChanged(object sender, EventArgs e)
//		{
//			//subTotalLbl.BindingContext = new SubTotalViewModel ();
//			if (!String.IsNullOrEmpty (EntryQuantity.Text) && EntryQuantity.Text.Trim () != "0") {
//				subTotalLbl.Text = ((Int32.Parse (EntryQuantity.Text)) * (Int32.Parse (basicPrice.Text))).ToString ();
//				//string subTotalValue = subTotalLbl.Text.ToString;
//			}
//		}

//		public void AddToCartbtnClicked(object sender, EventArgs e)
//		{
//			if (String.IsNullOrEmpty (EntryQuantity.Text) || EntryQuantity.Text.Trim () == "0")
//				DisplayAlert ("info", "enter the quantity", "ok");
//			else {
//				int productQuantity = Int32.Parse (quantityEntry.Text);
//				var productTotal = subTotalLbl.Text;
//				var placeOrderBindingValue=new PlaceOrderViewModel(this.pickedItem,productQuantity,productTotal);
//				myParameter.BindingContext = placeOrderBindingValue;
//				Navigation.PushAsync (new PlaceOrderPage (this.pickedItem,productQuantity,productTotal));
//			}
//		}


		 

	}
}

