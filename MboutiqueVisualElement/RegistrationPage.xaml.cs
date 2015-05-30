using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MboutiqueVisualElement
{
	public partial class RegistrationPage : ContentPage
	{
		
		public RegistrationPage ()
		{
			InitializeComponent ();
			BindingContext = this;
		}
		private void OnBtnRegisterClicked(object sender,EventArgs e)
		{
			if (string.IsNullOrEmpty (txtEmailId.Text)) {
				DisplayAlert ("Enter UserID", null, "OK");
			} else {
				Navigation.PushAsync (new NewUserPage (txtEmailId));
			}

		}
		private void OnBtnSkipClicked(object sender,EventArgs e)
		{

			Navigation.PushAsync (new ManagaeProfile ());
		}
		private string _emailID="EmailID";
		private string _btnRegister="Register";
		private string _btnSkip="Skip";
		public string EmailID {
			get {
				return _emailID;
			}
			set
			{
				_emailID = value;
			}
				
		}
		public string ButtonRegister{
			get {
				return _btnRegister;
			}
			set {
				_btnRegister = value;
			}
		}
		public string ButtonSkip {
			get {
				return _btnSkip;
			}
			set {
				_btnSkip = value;
			}
		}

	}
}

