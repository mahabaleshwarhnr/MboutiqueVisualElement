using System;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using MboutiqueVisualElement;
using MboutiqueVisualElement.Droid;

[assembly: ExportRenderer (typeof (MyEntry), typeof (MyEntryRenderer))]
namespace MboutiqueVisualElement.Droid
{
	public class MyEntryRenderer : EntryRenderer
	{
		// Override the OnElementChanged method so we can tweak this renderer post-initial setup
		protected override void OnElementChanged (ElementChangedEventArgs<Entry> e)
		{
			base.OnElementChanged (e);

			if (Control != null) { 
				// do whatever you want to the textField here!
				Control.SetBackgroundColor(global::Android.Graphics.Color.Gray);
				//Control.SetWidth(global::Android.Graphics.h
			}
		}
	}
}

