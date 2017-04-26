using System;

using UIKit;
using HappyDNS;
using Foundation;

namespace HappyDNSDemo
{
	public partial class ViewController : UIViewController
	{
		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);

			// Network test
			Console.WriteLine (QNNetworkInfo.Ip);

			// des test
			NSData key = NSData.FromString("12345678", NSStringEncoding.UTF8);
			NSString origin = new NSString("abcdef");
			QNDes des = new QNDes (key);
			NSData enc = des.Encrypt (origin.Encode (NSStringEncoding.UTF8));
			NSData dec = des.Decrpyt (enc);
			NSString n = new NSString (dec, NSStringEncoding.UTF8);
			Console.WriteLine ("Origin:{0} n:{1}", origin, n);
		}
	}
}

