using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Xml.Serialization;
using System.Reflection;
using System.IO;
using System.Xml.Linq;
using Newtonsoft.Json;

namespace MboutiqueVisualElement
{
	public partial class CatlogPageView : ContentPage
	{
		
		public CatlogPageView ()
		{
			InitializeComponent ();
			List<MboutiqueVisualElement> mboutique;
			var assembly = typeof(CatlogPageView).GetTypeInfo().Assembly;
			Stream stream = assembly.GetManifestResourceStream("MboutiqueVisualElement.MboutiqueXmlResource.xml");

			using (var reader = new System.IO.StreamReader (stream)) {
				var serializer = new XmlSerializer(typeof(List<MboutiqueVisualElement>));
				mboutique = (List<MboutiqueVisualElement>)serializer.Deserialize(reader);
			}
			mBoutiqueCatlog.ItemsSource=mboutique;
			BtnPickeditem.Clicked += (sender, e) => Navigation.PushAsync (new PlaceOrderPage ());
			BtnFavourites.Clicked += (sender, e) => Navigation.PushAsync (new FavouritesPage ()); 
		}

		public void OnItemSelected(object sender, ItemTappedEventArgs args)
		{
			var catlouge = args.Item as MboutiqueVisualElement;
			if (catlouge == null)
				return;
			Navigation.PushAsync(new DetailsPage(catlouge));
			// Reset the selected item
			mBoutiqueCatlog.SelectedItem = null;
		}


	}
}

