using System;
using UIKit;
using BugtagsInstaBinding;

namespace BugtagsInstaDemo
{
    public partial class ViewController : UIViewController
    {
        protected ViewController (IntPtr handle) : base (handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad ()
        {
            base.ViewDidLoad ();

            var temp = new BugtagsInsta ();
        }
    }
}

