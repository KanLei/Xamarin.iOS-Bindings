using System;
using UIKit;
using Foundation;
using CoreGraphics;

namespace ALITradeDemo
{
    public class TestWebViewController:UIViewController
    {
        public TestWebViewController ()
        {
        }

        public override void LoadView ()
        {
            View = new UIWebView ();
            View.BackgroundColor = UIColor.White;
        }
    }
}

