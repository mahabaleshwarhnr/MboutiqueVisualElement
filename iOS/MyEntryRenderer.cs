using System;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;
using UIKit;

namespace MboutiqueVisualElement.iOS
{
	public class MyEntryRenderer : EntryRenderer
	{
		// Override the OnElementChanged method so we can tweak this renderer post-initial setup
		protected override void OnElementChanged (ElementChangedEventArgs<Entry> e)
		{
			base.OnElementChanged (e);

			if (Control != null) {   // perform initial setup
				// do whatever you want to the UITextField here!
				Control.BackgroundColor = UIColor.LightGray;
				Control.BorderStyle = UITextBorderStyle.Line;
				Control.TextColor = UIColor.White;
			
			}
		}
	}
}

