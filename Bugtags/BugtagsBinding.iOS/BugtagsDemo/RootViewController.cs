using System;
using UIKit;
using BugtagsBinding.iOS;
using System.Threading.Tasks;

namespace BugtagsDemo
{
    public class RootViewController:UIViewController
    {
        public RootViewController()
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            View.BackgroundColor = UIColor.White;
        }
    }
}

