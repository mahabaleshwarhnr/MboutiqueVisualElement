using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Dynamic;

namespace MboutiqueVisualElement
{
	public partial class ChangePassword : ContentPage
	{  // NewRegistration register = new NewRegistration ();
		public ChangePassword ()
		{
			InitializeComponent ();
			this.BindingContext = new ManageAddressModel ();

		}
		private void OnChangePasswordBtnClicked(object sender,EventArgs e)
		{
			string oldPass = entryOldPass.Text;
			string newPass = entryNewPass.Text;
			App.Database.SetNewPassword (oldPass, newPass);
			Navigation.PushAsync (new CatlogPageView());
		}
	}
}

