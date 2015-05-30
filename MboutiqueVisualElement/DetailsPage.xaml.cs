using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Toasts.Forms.Plugin.Abstractions;

namespace MboutiqueVisualElement
{
	public partial class DetailsPage : ContentPage
	{
		//public MboutiqueVisualElement mVisualElement=new MboutiqueVisualElement();
		//public SubTotalViewModel SubTotalViewModel = new SubTotalViewModel();

		public DetailsPage (MboutiqueVisualElement catlouge)
		{
			InitializeComponent ();

			this.BindingContext = catlouge;
			BtnPick.Clicked += (sender, e) => Navigation.PushAsync (new ItemPriceScreen (catlouge));
			BtnFavourite.Clicked += (sender, e) => App.Database.InsertFavourite (catlouge);
		}
		
	}
}

