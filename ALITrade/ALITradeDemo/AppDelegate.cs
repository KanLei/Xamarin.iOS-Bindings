using System.Diagnostics;
using Foundation;
using UIKit;
using ALITrade.iOS;

namespace ALITradeDemo
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the
    // User Interface of the application, as well as listening (and optionally responding) to application events from iOS.
    [Register ("AppDelegate")]
    public class AppDelegate : UIApplicationDelegate
    {
        // class-level declarations

        public override UIWindow Window
        {
            get;
            set;
        }

        public override bool FinishedLaunching (UIApplication application, NSDictionary launchOptions)
        {
            Window = new UIWindow (UIScreen.MainScreen.Bounds);
            var nav = new UINavigationController (new TestViewController ());
            Window.RootViewController = nav;
            Window.MakeKeyAndVisible ();

            //string appKey = "23082328";

            // 百川平台基础 SDK 初始化，加载并初始化各个业务能力插件
            AlibcTradeSDK.SharedInstance ().AsyncInitWithSuccess (() =>
              {
                  Debug.WriteLine ("Init Success");
              }, (error) =>
              {
                  Debug.WriteLine ("Init Fail" + error);
              });

            // 开发阶段打开日志开关，方便排查错误信息
            //默认调试模式打开日志,release关闭,可以不调用下面的函数
            AlibcTradeSDK.SharedInstance ().SetDebugLogOpen (true);

            // 配置全局的淘客参数
            //如果没有阿里妈妈的淘客账号,setTaokeParams函数需要调用
            AlibcTradeTaokeParams taokeParams = new AlibcTradeTaokeParams ();
            taokeParams.Pid = "mm_97100348_7476080_24834937";  // 你自己申请的阿里妈妈淘客pid
            AlibcTradeSDK.SharedInstance ().SetTaokeParams (taokeParams);

            //设置全局的app标识，在电商模块里等同于isv_code
            //没有申请过isv_code的接入方,默认不需要调用该函数
            AlibcTradeSDK.SharedInstance ().SetISVCode ("your_isv_code");

            // 设置全局配置，是否强制使用h5
            AlibcTradeSDK.SharedInstance ().SetIsForceH5 (false);

            return true;
        }


        public override bool OpenUrl (UIApplication application, NSUrl url, string sourceApplication, NSObject annotation)
        {
            // 如果百川处理过会返回YES
            if (AlibcTradeSDK.SharedInstance ().HandleOpenURL (url))
            {
                // 处理其他app跳转到自己的app
                return true;
            }
            return false;
        }

        //IOS9.0 系统新的处理openURL 的API
        public override bool OpenUrl (UIApplication app, NSUrl url, NSDictionary options)
        {
            //处理其他app跳转到自己的app，如果百川处理过会返回YES
            if (AlibcTradeSDK.SharedInstance ().HandleOpenURL (url))
            {
                return true;
            }
            return false;
        }

        public override void OnResignActivation (UIApplication application)
        {
            // Invoked when the application is about to move from active to inactive state.
            // This can occur for certain types of temporary interruptions (such as an incoming phone call or SMS message) 
            // or when the user quits the application and it begins the transition to the background state.
            // Games should use this method to pause the game.
        }

        public override void DidEnterBackground (UIApplication application)
        {
            // Use this method to release shared resources, save user data, invalidate timers and store the application state.
            // If your application supports background exection this method is called instead of WillTerminate when the user quits.
        }

        public override void WillEnterForeground (UIApplication application)
        {
            // Called as part of the transiton from background to active state.
            // Here you can undo many of the changes made on entering the background.
        }

        public override void OnActivated (UIApplication application)
        {
            // Restart any tasks that were paused (or not yet started) while the application was inactive. 
            // If the application was previously in the background, optionally refresh the user interface.
        }

        public override void WillTerminate (UIApplication application)
        {
            // Called when the application is about to terminate. Save data, if needed. See also DidEnterBackground.
        }
    }
}


