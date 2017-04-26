using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;

namespace UMengQQ.iOS
{
    #region UMSocialQQHandler

    // @interface UMSocialHandler : NSObject
    [BaseType (typeof (NSObject))]
    interface UMSocialHandler
    {
        // +(void)load;
        [Static]
        [Export ("load")]
        void Load ();

        // +(NSArray *)socialPlatformTypes;
        [Static]
        [Export ("socialPlatformTypes")]
        NSObject [] SocialPlatformTypes { get; }

        // +(UMSocialHandler *)defaultManager;
        [Static]
        [Export ("defaultManager")]
        UMSocialHandler DefaultManager { get; }

        // @property (copy, nonatomic) NSString * appID;
        [Export ("appID")]
        string AppID { get; set; }

        // @property (copy, nonatomic) NSString * appSecret;
        [Export ("appSecret")]
        string AppSecret { get; set; }

        // @property (copy, nonatomic) NSString * redirectURL;
        [Export ("redirectURL")]
        string RedirectURL { get; set; }

        // @property (nonatomic, strong) UIViewController * currentViewController;
        [Export ("currentViewController", ArgumentSemantic.Strong)]
        UIViewController CurrentViewController { get; set; }

        // @property (copy, nonatomic) int shareCompletionBlock;
        [Export ("shareCompletionBlock", ArgumentSemantic.Copy)]
        int ShareCompletionBlock { get; set; }

        // @property (copy, nonatomic) int authCompletionBlock;
        [Export ("authCompletionBlock", ArgumentSemantic.Copy)]
        int AuthCompletionBlock { get; set; }

        // @property (copy, nonatomic) int userinfoCompletionBlock;
        [Export ("userinfoCompletionBlock", ArgumentSemantic.Copy)]
        int UserinfoCompletionBlock { get; set; }

        // -(BOOL)searchForURLSchemeWithPrefix:(NSString *)prefix;
        [Export ("searchForURLSchemeWithPrefix:")]
        bool SearchForURLSchemeWithPrefix (string prefix);

        // -(void)setAppId:(NSString *)appID appSecret:(NSString *)secret url:(NSString *)url;
        [Export ("setAppId:appSecret:url:")]
        void SetAppId (string appID, string secret, string url);

        // -(void)saveuid:(NSString *)uid openid:(NSString *)openid accesstoken:(NSString *)token refreshtoken:(NSString *)retoken expiration:(id)expiration;
        [Export ("saveuid:openid:accesstoken:refreshtoken:expiration:")]
        void Saveuid (string uid, string openid, string token, string retoken, NSObject expiration);

        //// @property (readonly, nonatomic, strong) UMSocialHandlerConfig * handlerConfig;
        //[Export ("handlerConfig", ArgumentSemantic.Strong)]
        //UMSocialHandlerConfig HandlerConfig { get; }
    }

    // @interface UMSocialQQHandler : UMSocialHandler
    [BaseType (typeof (UMSocialHandler))]
    interface UMSocialQQHandler
    {
        // +(UMSocialQQHandler *)defaultManager;
        [Static]
        [Export ("defaultManager")]
        UMSocialQQHandler DefaultManager { get; }

        // -(void)setSupportWebView:(BOOL)support;
        [Export ("setSupportWebView:")]
        void SetSupportWebView (bool support);
    }

    #endregion

    #region QQApiInterface

    // @interface QQApiInterface : NSObject
    [BaseType (typeof (NSObject))]
    interface QQApiInterface
    {
        // +(BOOL)handleOpenURL:(NSURL *)url delegate:(id<QQApiInterfaceDelegate>)delegate;
        [Static]
        [Export ("handleOpenURL:delegate:")]
        bool HandleOpenURL (NSUrl url, QQApiInterfaceDelegate @delegate);

        // +(QQApiSendResultCode)sendReq:(QQBaseReq *)req;
        [Static]
        [Export ("sendReq:")]
        QQApiSendResultCode SendReq (QQBaseReq req);

        // +(QQApiSendResultCode)SendReqToQZone:(QQBaseReq *)req;
        [Static]
        [Export ("SendReqToQZone:")]
        QQApiSendResultCode SendReqToQZone (QQBaseReq req);

        // +(QQApiSendResultCode)SendReqToQQGroupTribe:(QQBaseReq *)req;
        [Static]
        [Export ("SendReqToQQGroupTribe:")]
        QQApiSendResultCode SendReqToQQGroupTribe (QQBaseReq req);

        // +(QQApiSendResultCode)sendResp:(QQBaseResp *)resp;
        [Static]
        [Export ("sendResp:")]
        QQApiSendResultCode SendResp (QQBaseResp resp);

        // +(BOOL)isQQInstalled;
        [Static]
        [Export ("isQQInstalled")]
        bool IsQQInstalled { get; }

        // +(void)getQQUinOnlineStatues:(NSArray *)QQUins delegate:(id<QQApiInterfaceDelegate>)delegate;
        [Static]
        [Export ("getQQUinOnlineStatues:delegate:")]
        void GetQQUinOnlineStatues (NSObject [] QQUins, QQApiInterfaceDelegate @delegate);

        // +(BOOL)isQQSupportApi;
        [Static]
        [Export ("isQQSupportApi")]
        bool IsQQSupportApi { get; }

        // +(BOOL)openQQ;
        [Static]
        [Export ("openQQ")]
        bool OpenQQ { get; }

        // +(NSString *)getQQInstallUrl;
        [Static]
        [Export ("getQQInstallUrl")]
        string QQInstallUrl { get; }
    }


    // @protocol QQApiInterfaceDelegate <NSObject>
    [Protocol, Model]
    [BaseType (typeof (NSObject))]
    interface QQApiInterfaceDelegate
    {
        // @required -(void)onReq:(QQBaseReq *)req;
        [Abstract]
        [Export ("onReq:")]
        void OnReq (QQBaseReq req);

        // @required -(void)onResp:(QQBaseResp *)resp;
        [Abstract]
        [Export ("onResp:")]
        void OnResp (QQBaseResp resp);

        // @required -(void)isOnlineResponse:(NSDictionary *)response;
        [Abstract]
        [Export ("isOnlineResponse:")]
        void IsOnlineResponse (NSDictionary response);
    }

    // @interface QQBaseReq : NSObject
    [BaseType (typeof (NSObject))]
    interface QQBaseReq
    {
        // @property (assign, nonatomic) int type;
        [Export ("type")]
        int Type { get; set; }
    }

    // @interface QQBaseResp : NSObject
    [BaseType (typeof (NSObject))]
    interface QQBaseResp
    {
        // @property (copy, nonatomic) NSString * result;
        [Export ("result")]
        string Result { get; set; }

        // @property (copy, nonatomic) NSString * errorDescription;
        [Export ("errorDescription")]
        string ErrorDescription { get; set; }

        // @property (assign, nonatomic) int type;
        [Export ("type")]
        int Type { get; set; }

        // @property (assign, nonatomic) NSString * extendInfo;
        [Export ("extendInfo")]
        string ExtendInfo { get; set; }
    }
    #endregion
}

