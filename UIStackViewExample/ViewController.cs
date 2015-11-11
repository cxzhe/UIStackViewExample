using System;

using UIKit;

namespace UIStackViewExample
{
	public partial class ViewController : UIViewController
	{
		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			distributionSegmentControl.ValueChanged += DistributionSegmentControlValueChanged;
			alignmentSegmentControl.ValueChanged += AlignmentSegmentControlValueChanged;
		}

		public void DistributionSegmentControlValueChanged (object sender, EventArgs e)
		{
			UIView.Animate (0.5, () => {
				if (distributionSegmentControl.SelectedSegment == 0) {
					this.peopleStackView.Distribution = UIStackViewDistribution.Fill;
				}else if (distributionSegmentControl.SelectedSegment == 1) {
					this.peopleStackView.Distribution = UIStackViewDistribution.FillEqually;
				}else if (distributionSegmentControl.SelectedSegment == 2) {
					this.peopleStackView.Distribution = UIStackViewDistribution.EqualSpacing;
				}else if (distributionSegmentControl.SelectedSegment == 3) {
					this.peopleStackView.Distribution = UIStackViewDistribution.EqualCentering;
				}
			});
		}

		public void AlignmentSegmentControlValueChanged (object sender, EventArgs e)
		{
			UIView.Animate (0.5, () => {
				if (alignmentSegmentControl.SelectedSegment == 0) {
					this.peopleStackView.Alignment = UIStackViewAlignment.Fill;
				}else if (alignmentSegmentControl.SelectedSegment == 1) {
					this.peopleStackView.Alignment = UIStackViewAlignment.Top;
				}else if (alignmentSegmentControl.SelectedSegment == 2) {
					this.peopleStackView.Alignment = UIStackViewAlignment.Center;
				}else if (alignmentSegmentControl.SelectedSegment == 3) {
					this.peopleStackView.Alignment = UIStackViewAlignment.Bottom;
				}
			});

		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

