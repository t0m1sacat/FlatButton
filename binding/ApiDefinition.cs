using System;
using System.Drawing;
using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace QBFlatButton
{
	[BaseType (typeof (UIButton), Name ="QBFlatButton")]
	public partial interface FlatButton {

		[Export ("faceColor")]
		UIColor FaceColor { get; set; }

		[Export ("sideColor")]
		UIColor SideColor { get; set; }

		[Export ("radius")]
		float Radius { get; set; }

		[Export ("margin")]
		float Margin { get; set; }

		[Export ("depth")]
		float Depth { get; set; }

		[Export ("setFaceColor:forState:")]
		void SetFaceColor (UIColor faceColor, UIControlState state);

		[Export ("setSideColor:forState:")]
		void SetSideColor (UIColor sideColor, UIControlState state);

		[Export ("faceColorForState:")]
		UIColor FaceColorForState (UIControlState state);

		[Export ("sideColorForState:")]
		UIColor SideColorForState (UIControlState state);
	}
}

