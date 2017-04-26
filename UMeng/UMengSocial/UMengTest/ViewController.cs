using System;

using UIKit;
using CoreGraphics;
using Foundation;
using UMengSocial;

namespace UMengTest
{
    public partial class ViewController : UIViewController
    {
        public ViewController (IntPtr handle)
            : base (handle)
        {
        }

        public override void ViewDidLoad ()
        {
            base.ViewDidLoad ();

            var btnWeichat = new UIButton (new CGRect (100, 50, 100, 100));
            btnWeichat.BackgroundColor = UIColor.Red;
            btnWeichat.SetTitle ("Wechat", UIControlState.Normal);
            View.Add (btnWeichat);

            btnWeichat.TouchUpInside += BtnWeichat_TouchUpInside;
            ;


            var btnSina = new UIButton (new CGRect (100, 200, 100, 100));
            btnSina.BackgroundColor = UIColor.Blue;
            btnSina.SetTitle ("Sina", UIControlState.Normal);
            View.Add (btnSina);

            btnSina.TouchUpInside += BtnSina_TouchUpInside;

            var btnQQ = new UIButton (new CGRect (100, 350, 100, 100));
            btnQQ.BackgroundColor = UIColor.Green;
            btnQQ.SetTitle ("QQ", UIControlState.Normal);
            View.Add (btnQQ);

            btnQQ.TouchUpInside += BtnQQ_TouchUpInside;

            var btnShare = new UIButton (new CGRect (100, 470, 100, 100));
            btnShare.BackgroundColor = UIColor.Cyan;
            btnShare.SetTitle ("分享", UIControlState.Normal);
            View.Add (btnShare);

            btnShare.TouchUpInside += (sender, e) =>
            {
                ShareText ();
            };
        }

        void BtnQQ_TouchUpInside (object sender, EventArgs e)
        {
            UMSocialQQHandler.DefaultManager.SetAppId ("1105448311", "MHZRh13c0ud7Bovd", "http://www.umeng.com/social");
            var result = QQApiInterface.IsQQInstalled;

            var alertView = new UIAlertView ("QQ", result ? "已安装" : "未安装", null, "OK", null);
            alertView.Show ();
        }

        void BtnWeichat_TouchUpInside (object sender, EventArgs e)
        {
            // 使用 WXApi.IsWXAppInstalled 之前注意事项
            // 1. 配置 NSAppTransportSecurity
            // 2. LSApplicationQueriesSchemes 增加 weixin
            // 3. 注册 App: WXApi.RegisterApp("");
            WXApi.RegisterApp ("wx4e176430f6f0560d");
            UMSocialWechatHandler.DefaultManager.SetAppId("wx4e176430f6f0560d", "586b357cd07033b781b0f66520720547", "http://www.umeng.com/social");

            var result = WXApi.IsWXAppInstalled;

            var alertView = new UIAlertView ("微信", result ? "已安装" : "未安装", null, "OK", null);
            alertView.Show ();
        }

        void BtnSina_TouchUpInside (object sender, EventArgs e)
        {
            // sinaweibo sinaweibohd
            WeiboSDK.EnableDebugMode (true);
            //            WeiboSDK.RegisterApp("2412524085");
            var result = WeiboSDK.IsWeiboAppInstalled;

            UMSocialSinaHandler.DefaultManager.SetAppId ("1147718133", "986ce11b42bb8301c528325fc0b2db1e", "https://api.weibo.com/oauth2/default.html");

            var alertView = new UIAlertView ("新浪微博", result ? "已安装" : "未安装", null, "OK", null);
            alertView.Show ();
        }

        public void TestApi ()
        {
            UMSocialWechatHandler.DefaultManager.SetAppId ("", "", url: "");

            UMSocialQQHandler.DefaultManager.SetAppId ("", "", url: "");
            UMSocialQQHandler.DefaultManager.SetSupportWebView (true);



        }


        private void ShareText ()
        {
            UMSocialMessageObject messageObject = UMSocialMessageObject.MessageObject;
            messageObject.Text = "分享文本内容";

            UMSocialManager.DefaultManager ().ShareToPlatform (UMSocialPlatformType.Sina,
                                                              messageObject,
                                                             new UIViewController (),
                                                             (data, error) =>
                                                             {
                                                                 if (error != null)
                                                                 {
                                                                     Console.WriteLine (error);
                                                                 }
                                                                 else
                                                                 {

                                                                     Console.WriteLine (data);
                                                                 }
                                                             });
        }

        private void ShareImage ()
        {
            UMSocialMessageObject messageObject = UMSocialMessageObject.MessageObject;

            UMShareImageObject shareObject = new UMShareImageObject ();
            // 如果有缩略图，则设置缩略图
            shareObject.ThumbImage = new UIImage ();
            shareObject.ShareImage = new NSString ("https://");

            messageObject.ShareObject = shareObject;

            UMSocialManager.DefaultManager ().ShareToPlatform (UMSocialPlatformType.Sina,
                                                              messageObject,
                                                             new UIViewController (),
                                                             (data, error) =>
                                                             {
                                                                 if (error != null)
                                                                 {
                                                                     Console.WriteLine (error);
                                                                 }
                                                                 else
                                                                 {

                                                                     Console.WriteLine (data);
                                                                 }
                                                             });
        }


        // 分享图文（新浪支持，微信、QQ 仅支持图片或文本分享）
        private void ShareImageAndText ()
        {
            UMSocialMessageObject messageObject = UMSocialMessageObject.MessageObject;

            // 设置文本
            messageObject.Text = "分享文本内容";

            // 创建图片内容对象
            UMShareImageObject shareObject = new UMShareImageObject ();
            // 如果有缩略图，则设置缩略图
            shareObject.ThumbImage = new UIImage ();
            shareObject.ShareImage = new NSString ("https://");

            messageObject.ShareObject = shareObject;

            UMSocialManager.DefaultManager ().ShareToPlatform (UMSocialPlatformType.Sina,
                                                              messageObject,
                                                             new UIViewController (),
                                                             (data, error) =>
                                                             {
                                                                 if (error != null)
                                                                 {
                                                                     Console.WriteLine (error);
                                                                 }
                                                                 else
                                                                 {

                                                                     Console.WriteLine (data);
                                                                 }
                                                             });
        }


        private void ShareWebPage ()
        {
            UMSocialMessageObject messageObject = UMSocialMessageObject.MessageObject;

            UMShareWebpageObject shareObject = UMShareWebpageObject.ShareObjectWithTitle ("分享标题", "分享内容描述", new UIImage ());
            // 设置网页
            shareObject.WebpageUrl = "http://";

            // 分享消息对象设置分享内容对象
            messageObject.ShareObject = shareObject;

            // 调用分享接口
            UMSocialManager.DefaultManager ().ShareToPlatform (UMSocialPlatformType.Sina,
                                                             messageObject,
                                                             new UIViewController (),
                                                             (data, error) =>
                                                             {
                                                                 if (error != null)
                                                                 {
                                                                     Console.WriteLine (error);
                                                                 }
                                                                 else
                                                                 {

                                                                     Console.WriteLine (data);
                                                                 }
                                                             });

        }

        private void ShareMusic ()
        {
            // 创建分享消息对象
            UMSocialMessageObject messageObject = UMSocialMessageObject.MessageObject;

            // 创建音乐内容对象
            UMShareMusicObject shareObject = UMShareMusicObject.ShareObjectWithTitle ("分享标题", "分享内容描述", new UIImage ());
            shareObject.MusicUrl = "http://";
            //shareObject.MusicDataUrl = "";  // 这里设置音乐数据流地址（如果有且分享平台支持）
            messageObject.ShareObject = shareObject;

            // 调用分享接口
            UMSocialManager.DefaultManager ().ShareToPlatform (UMSocialPlatformType.Sina,
                                                             messageObject,
                                                             new UIViewController (),
                                                             (data, error) =>
                                                             {
                                                                 if (error != null)
                                                                 {
                                                                     Console.WriteLine (error);
                                                                 }
                                                                 else
                                                                 {

                                                                     Console.WriteLine (data);
                                                                 }
                                                             });
        }

        private void ShareVideo ()
        {
            UMSocialMessageObject messageObject = UMSocialMessageObject.MessageObject;

            UMShareVideoObject shareObject = UMShareVideoObject.ShareObjectWithTitle ("分享标题", "分享内容描述", new UIImage ());
            // 设置网页播放地址
            shareObject.VideoUrl = "http://";
            //shareObject.VideoStreamUrl = @"这里设置视频数据流地址（如果有的话，而且也要看所分享的平台支不支持）";

            messageObject.ShareObject = shareObject;

            // 调用分享接口
            UMSocialManager.DefaultManager ().ShareToPlatform (UMSocialPlatformType.Sina,
                                                             messageObject,
                                                             new UIViewController (),
                                                             (data, error) =>
                                                             {
                                                                 if (error != null)
                                                                 {
                                                                     Console.WriteLine (error);
                                                                 }
                                                                 else
                                                                 {

                                                                     Console.WriteLine (data);
                                                                 }
                                                             });
        }


        /// <summary>
        /// 授权并获取用户信息
        /// </summary>
        private void GetAuthWithUserInfo ()
        {
            UMSocialManager.DefaultManager ().GetUserInfoWithPlatform (UMSocialPlatformType.WechatSession,
                                                                     new UIViewController (),
                                                                     (result, error) =>
                                                                     {
                                                                         if (error != null)
                                                                         {

                                                                         }
                                                                         else {
                                                                             UMSocialUserInfoResponse resp = (UMSocialUserInfoResponse)result;

                                                                             // 授权信息
                                                                             Console.WriteLine (@"Wechat uid: " + resp.Uid);
                                                                             Console.WriteLine (@"Wechat openid: " + resp.Openid);
                                                                             Console.WriteLine (@"Wechat accessToken:" + resp.AccessToken);
                                                                             Console.WriteLine (@"Wechat refreshToken:" + resp.RefreshToken);
                                                                             Console.WriteLine (@"Wechat expiration: " + resp.Expiration);

                                                                             // 用户信息
                                                                             Console.WriteLine (@"Wechat name: " + resp.Name);
                                                                             Console.WriteLine (@"Wechat iconurl: " + resp.Iconurl);
                                                                             Console.WriteLine (@"Wechat gender: " + resp.Gender);

                                                                             // 第三方平台SDK源数据
                                                                             Console.WriteLine (@"Wechat originalResponse: " + resp.OriginalResponse);
                                                                         }
                                                                     });
        }


        /// <summary>
        /// 授权仅获取 Token 和 UID
        /// </summary>
        private void GetAuth ()
        {
            UMSocialManager.DefaultManager ().AuthWithPlatform (UMSocialPlatformType.WechatSession, null, (result, error) =>
            {
                if (error != null)
                {

                }
                else {
                    UMSocialAuthResponse resp = (UMSocialAuthResponse)result;

                    // 授权信息
                    Console.WriteLine (@"Wechat uid: " + resp.Uid);
                    Console.WriteLine (@"Wechat openid: " + resp.Openid);
                    Console.WriteLine (@"Wechat accessToken: " + resp.AccessToken);
                    Console.WriteLine (@"Wechat refreshToken: " + resp.RefreshToken);
                    Console.WriteLine (@"Wechat expiration: " + resp.Expiration);


                    // 第三方平台SDK源数据
                    Console.WriteLine (@"Wechat originalResponse: %@", resp.OriginalResponse);
                }
            });

        }

        //private class WXPayApiDelegate:WXApiDelegate
        //{
        //    public override void OnReq(BaseReq req)
        //    {
        //        base.OnReq(req);
        //    }

        //    public override void OnResp(BaseResp resp)
        //    {
        //        base.OnResp(resp);

        //        // 微信支付回调
        //    }
        //}
    }


    public enum SharePlatformType
    {
        /// <summary>
        /// 微信
        /// </summary>
        WechatSession,
        /// <summary>
        /// 微信朋友圈
        /// </summary>
        WechatTimeline,
        /// <summary>
        /// 新浪微博
        /// </summary>
        Sina,
        /// <summary>
        /// QQ
        /// </summary>
        QQ,
        /// <summary>
        /// QQ空间
        /// </summary>
        Qzone,
        None
    }

    public class UMSocial
    {
        public bool HasWeiXinClient ()
        {
            return WXApi.IsWXAppInstalled;
        }

        public bool HasWeiboClient ()
        {
            return WeiboSDK.IsWeiboAppInstalled;
        }

        public bool HasQQClient ()
        {
            return QQApiInterface.IsQQInstalled;
        }

        public void Share (SharePlatformType sharePlatformType, string title, string content, string imageUrl, string url, Action callback)
        {
            //var service = UMSocialDataService.DefaultDataService;
            //var urlResource = new UMSocialUrlResource(UMSocialUrlResourceType.Image, imageUrl);

            //NSString[] platformTypes;
            //switch (sharePlatformType)
            //{
            //    case SharePlatformType.QQ:
            //        platformTypes = new []{ Constants.UMShareToQQ };
            //        UMSocialData.DefaultData.ExtConfig.QqData.Url = url;
            //        UMSocialData.DefaultData.ExtConfig.QqData.Title = title;
            //        UMSocialData.DefaultData.ExtConfig.QqData.ShareText = content;
            //        break;
            //    case SharePlatformType.Qzone:
            //        platformTypes = new []{ Constants.UMShareToQzone };
            //        UMSocialData.DefaultData.ExtConfig.QzoneData.Url = url;
            //        UMSocialData.DefaultData.ExtConfig.QzoneData.Title = title;
            //        UMSocialData.DefaultData.ExtConfig.QzoneData.ShareText = content;
            //        break;
            //    case SharePlatformType.Sina:
            //        platformTypes = new []{ Constants.UMShareToSina };
            //        break;
            //    case SharePlatformType.WechatSession:
            //        platformTypes = new []{ Constants.UMShareToWechatSession };
            //        UMSocialData.DefaultData.ExtConfig.WechatSessionData.Url = url;
            //        UMSocialData.DefaultData.ExtConfig.WechatSessionData.Title = title;
            //        UMSocialData.DefaultData.ExtConfig.WechatSessionData.ShareText = content;
            //        break;
            //    case SharePlatformType.WechatTimeline:
            //        platformTypes = new []{ Constants.UMShareToWechatTimeline };
            //        UMSocialData.DefaultData.ExtConfig.WechatTimelineData.Url = url;
            //        UMSocialData.DefaultData.ExtConfig.WechatTimelineData.Title = title;
            //        UMSocialData.DefaultData.ExtConfig.WechatTimelineData.ShareText = content;
            //        break;
            //    default:
            //        platformTypes = new NSString[0];
            //        break;
            //}

            //service.PostSNSWithTypes(platformTypes, content, new UIImage(), new CoreLocation.CLLocation(), urlResource, new UIViewController(), (a) =>
            //    {
            //        callback();
            //        if (a.ResponseCode == UMSResponseCode.esponseCodeSuccess)
            //        {
            //            // 分享成功
            //        }
            //        else
            //        {
            //            // 分享失败
            //        }
            //    });
        }
    }
}

