using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace MboutiqueVisualElement
{
	public partial class FavouritesPage : ContentPage {

		private FavouriteData LastFavItem { get; set; }

		ObservableCollection<FavouriteData> FavCollection;

		public FavouritesPage () {
			InitializeComponent ();
			var FavouriteList=App.Database.GetFavouriteItem ();
			try {
				FavCollection = new ObservableCollection<FavouriteData> (FavouriteList);
				mBoutiquefavlog.ItemsSource = FavCollection;
			} catch (Exception ex) {
				DisplayAlert ("Favourites", "No Favourite item in the List", "OK");
			}

			}
//		protected override void OnAppearing ()
//		{
//			base.OnAppearing ();
//			mBoutiquefavlog.ItemsSource = App.Database.GetFavouriteItem ();
//		}
		public async void OnDeleteFavourites (object sender, EventArgs e)
		{
			var SelectedMenu = ((MenuItem)sender);
			bool UserResponse = await DisplayAlert (null, "Are you sure want to delete this item From Cart?", "Yes", "No");
			if (UserResponse) {
				LastFavItem = (FavouriteData)SelectedMenu.CommandParameter;
				FavCollection.Remove ((FavouriteData)SelectedMenu.CommandParameter);
				App.Database.UpdateFavouriteData (LastFavItem);
				

			}

		}

	}
}

