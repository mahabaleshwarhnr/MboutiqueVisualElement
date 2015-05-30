using System;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using MboutiqueVisualElement.Android;

[assembly: ExportRenderer (typeof (Button), typeof (ListButtonRenderer))]


namespace MboutiqueVisualElement.Android
{
	public class ListButtonRenderer : ButtonRenderer
	{

		protected override void OnElementChanged (ElementChangedEventArgs<Button> e)
		{
			base.OnElementChanged (e);

			Control.Focusable = false;
		}
	}
}

