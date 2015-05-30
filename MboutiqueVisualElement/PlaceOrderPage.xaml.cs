using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;
using System.Collections;

namespace MboutiqueVisualElement
{
	
	public partial class PlaceOrderPage : ContentPage {


		private CatlougeData LastDeletedItem { get; set; }

		ObservableCollection<CatlougeData> items;

		public PlaceOrderPage () {
			
			InitializeComponent ();
			var CartList = App.Database.GetAllItems ();
			items = new ObservableCollection<CatlougeData> (CartList);
			pickedItemList.ItemsSource = items;
			lblGrandTotal.Text = App.Database.GetGrandTotal ().ToString ();


			}

		void tapImage_Tapped (object sender, EventArgs e)
		{
			DisplayAlert("Alert", "This is an image button", "OK"); 
		}

		public async void OnDeleteMenu (object sender, EventArgs e)
		{
			var SelectedMenu = ((MenuItem)sender);
			bool UserResponse = await DisplayAlert (null, "Are you sure want to delete this item From Cart?", "Yes", "No");
			if (UserResponse) {
				LastDeletedItem = (CatlougeData)SelectedMenu.CommandParameter;
				items.Remove ((CatlougeData)SelectedMenu.CommandParameter);
				App.Database.UpdateCatlougData (LastDeletedItem);
				lblGrandTotal.Text = App.Database.GetGrandTotal ().ToString ();

			}
				
		}

		public void PlaceOrderButtonClicked (object sender, EventArgs e)
		{
			Navigation.PushAsync (new PaymentScreen (lblGrandTotal.Text));
			
		}

		}
}

