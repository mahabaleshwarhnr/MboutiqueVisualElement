using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MboutiqueVisualElement
{
	public partial class PostInFbSelectedItem : ContentPage
	{
		public PostInFbSelectedItem ()
		{
			InitializeComponent ();

		}
		private void OnPublishButton(object sender,EventArgs e)
		{
			
			 DisplayAlert ("Published", null, "OK");
			Navigation.PushAsync (new NoOrderToPayScreen ());
		
		}
	}
}

