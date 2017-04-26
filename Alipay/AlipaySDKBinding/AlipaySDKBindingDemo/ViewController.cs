using System;

using UIKit;
using System.Diagnostics;
using AlipaySDKBinding;

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

            Debug.WriteLine(AlipaySDK.DefaultService.CurrentVersion);
           
            AlipaySDK.DefaultService.PayOrder("", "", (resultDic) =>
                {
                    Debug.WriteLine(resultDic);
                });
        }
    }
}

