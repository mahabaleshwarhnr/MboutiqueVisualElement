using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MboutiqueVisualElement
{
	public partial class ChangeCity : ContentPage
	{
		public ChangeCity (string currentCity)
		{
			
			InitializeComponent ();
			lblCurrentCity.SetBinding(Label.TextProperty,"City");
			CurrentCityValue.Text = currentCity;
			this.BindingContext = new ManageAddressModel ();



		}
		private void OnChageCityButtonClicked(object sender,EventArgs e)
		{
			if (pickerCountry.SelectedIndex == -1) {
				DisplayAlert ("Select Your Country", null, "OK");
			} else if (pickerState.SelectedIndex == -1) {
				DisplayAlert ("Select Your State", null, "OK");
			} else if (pickerCity.SelectedIndex == -1) {
				DisplayAlert ("Select Your City", null, "OK");
			} else {
				string countryName = pickerCountry.Items [pickerCountry.SelectedIndex];
				string cityName = pickerCity.Items [pickerCity.SelectedIndex];
				string stateName = pickerState.Items [pickerState.SelectedIndex];
				App.Database.ChangeCurrentCity (countryName,cityName,stateName);
				Navigation.PushAsync (new ChangePassword());
			}

		}

	}
}

