using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Diagnostics;
using System.ServiceModel.Channels;

namespace MboutiqueVisualElement
{
	public partial class PaymentScreen : ContentPage
	{

		public PaymentScreen (string grandTotal)
		{
				
			InitializeComponent ();
			totalLabel.SetValue (Label.TextProperty, grandTotal);
			lblGrandTotal.SetValue (Label.TextProperty, grandTotal);

				
			proceedButton.Clicked+=async (sender, e) => {

				string DeliveryAddress=App.Database.GetDeliveryAddress();
				var answer = await DisplayAlert ("Please Choose Order Type",null, "COD", "Pickup order at store");
				if(answer==true)
				{
					var selectLoaction=await DisplayAlert("Select Location",""+DeliveryAddress,"OK","Change Address");
					if(selectLoaction==false)
						await Navigation.PushAsync(new ManageAddress());
					else
						await Navigation.PushAsync(new PostInFbSelectedItem());
				}


			};

		}
//		public void ProceedButtonClicked(object sender, EventArgs e)
//		{
//			var answer=DisplayAlert ("Payment Options", "Please Choose Order Type", "COD", "Pickup order at store");
//			Debug.WriteLine("Answer: " + answer);
//			DisplayAlert ("Answer", "Answer is" + answer, "ok");
//		}
	}
}

