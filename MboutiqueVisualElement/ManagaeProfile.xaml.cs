using System;
using System.Collections.Generic;

using Xamarin.Forms;



namespace MboutiqueVisualElement
{
	public partial class ManagaeProfile : ContentPage
	{
		public ManagaeProfile ()
		{
			InitializeComponent ();
			BindingContext = new MangaeProfileViewModel();

		}

		private void OnManageSaveClicked(object sender,EventArgs e)
		{
			if (string.IsNullOrEmpty (entryName.Text)) {
				DisplayAlert ("Enter your name", null, "OK");
			} else if (string.IsNullOrEmpty (entryMobileNum.Text)) {
				DisplayAlert ("Enter mobile number", null, "OK");
			} else if (string.IsNullOrEmpty (entryPhoneNum.Text)) {
				DisplayAlert ("Enter phone number", null, "OK");
			} else {
				var theDob = pickerDob.Date;
				int year = theDob.Year;
				int month = theDob.Month;
				int day = theDob.Day;
				string newDate = year + "-" + month + "-" + day;
				string name = entryName.Text;
				string mobileNum = entryMobileNum.Text;
				string phoneNum = entryPhoneNum.Text;
				//DisplayAlert ("Date", "" + newDate, "OK");
				App.Database.SaveProfile (newDate, name, mobileNum, phoneNum);
				entryName.Text = string.Empty;
				entryMobileNum.Text = string.Empty;
				entryPhoneNum.Text = string.Empty;
				ManageAddress _manage = new ManageAddress ();
				Navigation.PushAsync (_manage);
			}
		}



		public void ShowAlert ()
		{
			DisplayAlert ("Event Fired", null, "OK");
		}
	}
}