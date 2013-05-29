using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using QBFlatButton;

namespace FlatButtonDemo
{
	public class ViewController : UIViewController
	{
		public ViewController ()
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			View.BackgroundColor = UIColor.White;

			// Setup buttons
			var Button1 = new FlatButton () 
			{
				Depth = 3f,
				FaceColor = ColorConstant.BUTTON1FACE,
				Frame = new RectangleF (60, 80, 200, 60),
				Margin = 4f,
				Radius = 8f,
				SideColor = ColorConstant.BUTTON1SIDE
			};
			Button1.SetTitle ("Button", UIControlState.Normal);
			Button1.SetTitleColor (UIColor.White, UIControlState.Normal);

			var Button2 = new FlatButton () 
			{
				Depth = 6f,
				FaceColor = ColorConstant.BUTTON2FACE,
				Frame = new RectangleF (60, 180, 200, 60),
				Margin = 7f,
				Radius = 6f,
				SideColor = ColorConstant.BUTTON2SIDE
			};
			Button2.SetTitle ("Button", UIControlState.Normal);
			Button2.SetTitleColor (UIColor.White, UIControlState.Normal);

			var Button3 = new FlatButton () 
			{
				Enabled = false,
				Depth = 3f,
				FaceColor = ColorConstant.BUTTON3FACE,
				Frame = new RectangleF (60, 280, 200, 60),
				Margin = 4f,
				Radius = 8f,
				SideColor = ColorConstant.BUTTON3SIDE
			};
			Button3.SetTitle ("Disabled", UIControlState.Normal);
			Button3.SetTitleColor (UIColor.White, UIControlState.Normal);

			View.Add (Button1);
			View.Add (Button2);
			View.Add (Button3);
		}
	}
}