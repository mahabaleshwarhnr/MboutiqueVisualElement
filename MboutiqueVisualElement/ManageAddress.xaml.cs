using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MboutiqueVisualElement
{
	public partial class ManageAddress : ContentPage
	{ 
		
		public ManageAddress ()
		{
			InitializeComponent ();
			this.BindingContext = new ManageAddressModel ();

		}
		private void OnChageCityButtonClicked(object sender,EventArgs e)
		{
			
			//var deliveryAddress = new Editor ();
			if (string.IsNullOrEmpty (houseName.Text))
				DisplayAlert ("Enter House Number", null, "OK");
			else if (string.IsNullOrEmpty (streetName.Text))
				DisplayAlert ("Enter the street Name", null, "OK");
			else if (cityPicker.SelectedIndex == -1)
				DisplayAlert ("Pick the CityName", null, "OK");
			else if (statePicker.SelectedIndex == -1)
				DisplayAlert ("pick the state", null, "OK");
			else if (countryPicker.SelectedIndex == -1)
				DisplayAlert ("pick the country", null, "OK");
			else if (string.IsNullOrEmpty (ZipCode.Text))
				DisplayAlert ("Enter The ZipCode", null, "OK");
			else {
				var cityName = cityPicker.Items [cityPicker.SelectedIndex];
				var stateName = statePicker.Items [statePicker.SelectedIndex];
				var countryName = countryPicker.Items [countryPicker.SelectedIndex];
				var zipCode = ZipCode.Text;
				var housename = houseName.Text;
				var street = streetName.Text;
				App.Database.SaveAddress(cityName,stateName,countryName,zipCode,housename,street);
				houseName.Text = string.Empty;
				streetName.Text = string.Empty;
				ZipCode.Text = string.Empty;
				countryPicker.SelectedIndex = 1;
				statePicker.SelectedIndex = 1;
				cityPicker.SelectedIndex = 1;
				Navigation.PushAsync (new ChangeCity (cityName));
			}
		}


	}
}


