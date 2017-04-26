using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;

namespace UMengSocial
{
    #region UMSocialQQHandler

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

