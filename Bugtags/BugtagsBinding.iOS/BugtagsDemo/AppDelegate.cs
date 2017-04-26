using Foundation;
using UIKit;
using BugtagsBinding.iOS;

namespace BugtagsDemo
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
            Window = new UIWindow(UIScreen.MainScreen.Bounds);
            var navVC = new UINavigationController(new RootViewController());
            Window.RootViewController = navVC;
            Window.MakeKeyAndVisible();

            Bugtags.StartWithAppKey("", BTGInvocationEvent.Bubble);

            return true;
        }
    }
}


