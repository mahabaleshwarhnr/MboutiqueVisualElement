using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MboutiqueVisualElement
{
	public partial class NewUserPage : ContentPage {
		public NewUserPage (Entry txtEmailID) {
			InitializeComponent ();
			UserID.Text = txtEmailID.Text;
			string Password = entryPass.Text;
			string ConfirmPass = entryConfirmPass.Text;
			if (!string.IsNullOrEmpty(entryConfirmPass.Text)) {
				
			}

		}
		private void OnNewUseSaveBtnClicked(object sender,EventArgs	e)
		{
			if (string.IsNullOrEmpty(entryPass.Text)) {
				DisplayAlert ("Enter the password",null,"OK");
			} else if(string.IsNullOrEmpty(entryConfirmPass.Text)) {
				DisplayAlert ("Enter the confirm password",null,"OK");
			}
			else if(string.IsNullOrEmpty(entryMobile.Text)) {
				DisplayAlert ("Enter the mobile number",null,"OK");
			} 
			else if(string.IsNullOrEmpty(entryPhone.Text)) {
				DisplayAlert ("Enter the phone number",null,"OK");
			}
			else {
				string userName = UserID.Text;
				string userPassword = entryPass.Text;
				string userMobileNum = entryMobile.Text;
				string userPhone = entryPhone.Text;
					bool IsPasswordEqual = entryPass.Text.Equals (entryConfirmPass.Text);
					if (!IsPasswordEqual) {
						DisplayAlert ("Password", "Your password does not match", "OK");
					}

				 else {
					App.Database.SaveNewUserProfile (userName,userPassword,userMobileNum,userPhone);
					entryPass.Text = "";
					entryMobile.Text = "";
					entryPhone.Text = "";
					Navigation.PushAsync (new CatlogPageView ());
				}

			}

		}
	}
}

