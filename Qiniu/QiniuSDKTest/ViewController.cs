using System;
using System.Diagnostics;

using UIKit;
using QiniuSDK;
using Foundation;

namespace QiniuSDKTest
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

			NSString token = new NSString ("fromserver");
			QNUploadManager manager = new QNUploadManager ();
			NSData data = NSData.FromString ("Hello World!", NSStringEncoding.UTF8);
			manager.PutData (data, "hello", token, delegate(QNResponseInfo arg0, string arg1, NSDictionary arg2) {

				Debug.WriteLine ("arg0: " + arg0);
				Debug.WriteLine ("arg1: " + arg1);

			}, null);
		}
	}
}

