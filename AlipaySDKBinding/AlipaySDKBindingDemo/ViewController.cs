using System;

using UIKit;
using AlipaySDKBinding.iOS;
using System.Diagnostics;

namespace AlipaySDKBindingDemo
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle)
            : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);

           
            AlipaySDK.DefaultService.PayOrder("", "", (resultDic) =>
                {
                    Debug.WriteLine(resultDic);
                });
        }
    }
}

