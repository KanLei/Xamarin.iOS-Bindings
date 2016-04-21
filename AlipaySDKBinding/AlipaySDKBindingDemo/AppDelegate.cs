using Foundation;
using UIKit;
using AlipaySDKBinding.iOS;
using System.Diagnostics;

namespace AlipaySDKBindingDemo
{
    [Register("AppDelegate")]
    public class AppDelegate : UIApplicationDelegate
    {
        // class-level declarations

        public override UIWindow Window
        {
            get;
            set;
        }

        public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
        {
            
            return true;
        }

        public override bool OpenUrl(UIApplication application, NSUrl url, string sourceApplication, NSObject annotation)
        {
            AlipaySDK.DefaultService.ProcessOrderWithPaymentResult(url, (resultDic) =>
                {
                    Debug.WriteLine(resultDic);
                });

            return true;
        }
    }
}


