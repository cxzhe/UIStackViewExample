//
// This file has been generated automatically by MonoDevelop to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using UIKit;
using Foundation;

namespace UIStackViewExample
{
	[Register ("ViewController")]
	partial class ViewController
	{	
		[Outlet]
		UIStackView peopleStackView{ get; set;}

		[Outlet]
		UISegmentedControl distributionSegmentControl{ get; set;}

		[Outlet]
		UISegmentedControl alignmentSegmentControl{ get; set;}

		void ReleaseDesignerOutlets ()
		{
			if (peopleStackView != null) {
				peopleStackView.Dispose ();
				peopleStackView = null;
			}
			if (distributionSegmentControl != null) {
				distributionSegmentControl.Dispose ();
				distributionSegmentControl = null;
			}
			if (alignmentSegmentControl != null) {
				alignmentSegmentControl.Dispose ();
				alignmentSegmentControl = null;
			}

		}
	}
}
