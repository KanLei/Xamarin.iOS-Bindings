using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;

namespace UMengWechat.iOS
{
    #region UMSocialWechatHandler

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


    // @interface UMSocialWechatHandler
    [BaseType (typeof (UMSocialHandler))]
    interface UMSocialWechatHandler
    {
        // +(UMSocialWechatHandler *)defaultManager;
        [Static]
        [Export ("defaultManager")]
        UMSocialWechatHandler DefaultManager { get; }
    }

    #endregion


    #region WXApi

    // @interface BaseReq : NSObject
    [BaseType (typeof (NSObject))]
    interface BaseReq
    {
        // @property (assign, nonatomic) int type;
        [Export ("type")]
        int Type { get; set; }

        // @property (retain, nonatomic) NSString * openID;
        [Export ("openID", ArgumentSemantic.Retain)]
        string OpenID { get; set; }
    }

    // @interface BaseResp : NSObject
    [BaseType (typeof (NSObject))]
    interface BaseResp
    {
        // @property (assign, nonatomic) int errCode;
        [Export ("errCode")]
        int ErrCode { get; set; }

        // @property (retain, nonatomic) NSString * errStr;
        [Export ("errStr", ArgumentSemantic.Retain)]
        string ErrStr { get; set; }

        // @property (assign, nonatomic) int type;
        [Export ("type")]
        int Type { get; set; }
    }

    // @interface PayReq : BaseReq
    [BaseType (typeof (BaseReq))]
    interface PayReq
    {
        // @property (retain, nonatomic) NSString * partnerId;
        [Export ("partnerId", ArgumentSemantic.Retain)]
        string PartnerId { get; set; }

        // @property (retain, nonatomic) NSString * prepayId;
        [Export ("prepayId", ArgumentSemantic.Retain)]
        string PrepayId { get; set; }

        // @property (retain, nonatomic) NSString * nonceStr;
        [Export ("nonceStr", ArgumentSemantic.Retain)]
        string NonceStr { get; set; }

        // @property (assign, nonatomic) UInt32 timeStamp;
        [Export ("timeStamp")]
        uint TimeStamp { get; set; }

        // @property (retain, nonatomic) NSString * package;
        [Export ("package", ArgumentSemantic.Retain)]
        string Package { get; set; }

        // @property (retain, nonatomic) NSString * sign;
        [Export ("sign", ArgumentSemantic.Retain)]
        string Sign { get; set; }
    }

    // @interface PayResp : BaseResp
    [BaseType (typeof (BaseResp))]
    interface PayResp
    {
        // @property (retain, nonatomic) NSString * returnKey;
        [Export ("returnKey", ArgumentSemantic.Retain)]
        string ReturnKey { get; set; }
    }

    // @interface HBReq : BaseReq
    [BaseType (typeof (BaseReq))]
    interface HBReq
    {
        // @property (retain, nonatomic) NSString * nonceStr;
        [Export ("nonceStr", ArgumentSemantic.Retain)]
        string NonceStr { get; set; }

        // @property (assign, nonatomic) UInt32 timeStamp;
        [Export ("timeStamp")]
        uint TimeStamp { get; set; }

        // @property (retain, nonatomic) NSString * package;
        [Export ("package", ArgumentSemantic.Retain)]
        string Package { get; set; }

        // @property (retain, nonatomic) NSString * sign;
        [Export ("sign", ArgumentSemantic.Retain)]
        string Sign { get; set; }
    }

    // @interface HBResp : BaseResp
    [BaseType (typeof (BaseResp))]
    interface HBResp
    {
    }

    // @interface SendAuthReq : BaseReq
    [BaseType (typeof (BaseReq))]
    interface SendAuthReq
    {
        // @property (retain, nonatomic) NSString * scope;
        [Export ("scope", ArgumentSemantic.Retain)]
        string Scope { get; set; }

        // @property (retain, nonatomic) NSString * state;
        [Export ("state", ArgumentSemantic.Retain)]
        string State { get; set; }
    }

    // @interface SendAuthResp : BaseResp
    [BaseType (typeof (BaseResp))]
    interface SendAuthResp
    {
        // @property (retain, nonatomic) NSString * code;
        [Export ("code", ArgumentSemantic.Retain)]
        string Code { get; set; }

        // @property (retain, nonatomic) NSString * state;
        [Export ("state", ArgumentSemantic.Retain)]
        string State { get; set; }

        // @property (retain, nonatomic) NSString * lang;
        [Export ("lang", ArgumentSemantic.Retain)]
        string Lang { get; set; }

        // @property (retain, nonatomic) NSString * country;
        [Export ("country", ArgumentSemantic.Retain)]
        string Country { get; set; }
    }

    // @interface SendMessageToWXReq : BaseReq
    [BaseType (typeof (BaseReq))]
    interface SendMessageToWXReq
    {
        // @property (retain, nonatomic) NSString * text;
        [Export ("text", ArgumentSemantic.Retain)]
        string Text { get; set; }

        // @property (retain, nonatomic) WXMediaMessage * message;
        [Export ("message", ArgumentSemantic.Retain)]
        WXMediaMessage Message { get; set; }

        // @property (assign, nonatomic) BOOL bText;
        [Export ("bText")]
        bool BText { get; set; }

        // @property (assign, nonatomic) int scene;
        [Export ("scene")]
        int Scene { get; set; }
    }

    // @interface SendMessageToWXResp : BaseResp
    [BaseType (typeof (BaseResp))]
    interface SendMessageToWXResp
    {
        // @property (retain, nonatomic) NSString * lang;
        [Export ("lang", ArgumentSemantic.Retain)]
        string Lang { get; set; }

        // @property (retain, nonatomic) NSString * country;
        [Export ("country", ArgumentSemantic.Retain)]
        string Country { get; set; }
    }

    // @interface GetMessageFromWXReq : BaseReq
    [BaseType (typeof (BaseReq))]
    interface GetMessageFromWXReq
    {
        // @property (retain, nonatomic) NSString * lang;
        [Export ("lang", ArgumentSemantic.Retain)]
        string Lang { get; set; }

        // @property (retain, nonatomic) NSString * country;
        [Export ("country", ArgumentSemantic.Retain)]
        string Country { get; set; }
    }

    // @interface GetMessageFromWXResp : BaseResp
    [BaseType (typeof (BaseResp))]
    interface GetMessageFromWXResp
    {
        // @property (retain, nonatomic) NSString * text;
        [Export ("text", ArgumentSemantic.Retain)]
        string Text { get; set; }

        // @property (retain, nonatomic) WXMediaMessage * message;
        [Export ("message", ArgumentSemantic.Retain)]
        WXMediaMessage Message { get; set; }

        // @property (assign, nonatomic) BOOL bText;
        [Export ("bText")]
        bool BText { get; set; }
    }

    // @interface ShowMessageFromWXReq : BaseReq
    [BaseType (typeof (BaseReq))]
    interface ShowMessageFromWXReq
    {
        // @property (retain, nonatomic) WXMediaMessage * message;
        [Export ("message", ArgumentSemantic.Retain)]
        WXMediaMessage Message { get; set; }

        // @property (retain, nonatomic) NSString * lang;
        [Export ("lang", ArgumentSemantic.Retain)]
        string Lang { get; set; }

        // @property (retain, nonatomic) NSString * country;
        [Export ("country", ArgumentSemantic.Retain)]
        string Country { get; set; }
    }

    // @interface ShowMessageFromWXResp : BaseResp
    [BaseType (typeof (BaseResp))]
    interface ShowMessageFromWXResp
    {
    }

    // @interface LaunchFromWXReq : BaseReq
    [BaseType (typeof (BaseReq))]
    interface LaunchFromWXReq
    {
        // @property (retain, nonatomic) WXMediaMessage * message;
        [Export ("message", ArgumentSemantic.Retain)]
        WXMediaMessage Message { get; set; }

        // @property (retain, nonatomic) NSString * lang;
        [Export ("lang", ArgumentSemantic.Retain)]
        string Lang { get; set; }

        // @property (retain, nonatomic) NSString * country;
        [Export ("country", ArgumentSemantic.Retain)]
        string Country { get; set; }
    }

    // @interface OpenTempSessionReq : BaseReq
    [BaseType (typeof (BaseReq))]
    interface OpenTempSessionReq
    {
        // @property (retain, nonatomic) NSString * username;
        [Export ("username", ArgumentSemantic.Retain)]
        string Username { get; set; }

        // @property (retain, nonatomic) NSString * sessionFrom;
        [Export ("sessionFrom", ArgumentSemantic.Retain)]
        string SessionFrom { get; set; }
    }

    // @interface OpenWebviewReq : BaseReq
    [BaseType (typeof (BaseReq))]
    interface OpenWebviewReq
    {
        // @property (retain, nonatomic) NSString * url;
        [Export ("url", ArgumentSemantic.Retain)]
        string Url { get; set; }
    }

    // @interface OpenWebviewResp : BaseResp
    [BaseType (typeof (BaseResp))]
    interface OpenWebviewResp
    {
    }

    // @interface OpenTempSessionResp : BaseResp
    [BaseType (typeof (BaseResp))]
    interface OpenTempSessionResp
    {
    }

    // @interface OpenRankListReq : BaseReq
    [BaseType (typeof (BaseReq))]
    interface OpenRankListReq
    {
    }

    // @interface OpenRankListResp : BaseResp
    [BaseType (typeof (BaseResp))]
    interface OpenRankListResp
    {
    }

    // @interface JumpToBizProfileReq : BaseReq
    [BaseType (typeof (BaseReq))]
    interface JumpToBizProfileReq
    {
        // @property (retain, nonatomic) NSString * username;
        [Export ("username", ArgumentSemantic.Retain)]
        string Username { get; set; }

        // @property (retain, nonatomic) NSString * extMsg;
        [Export ("extMsg", ArgumentSemantic.Retain)]
        string ExtMsg { get; set; }

        // @property (assign, nonatomic) int profileType;
        [Export ("profileType")]
        int ProfileType { get; set; }
    }

    // @interface JumpToBizWebviewReq : BaseReq
    [BaseType (typeof (BaseReq))]
    interface JumpToBizWebviewReq
    {
        // @property (assign, nonatomic) int webType;
        [Export ("webType")]
        int WebType { get; set; }

        // @property (retain, nonatomic) NSString * tousrname;
        [Export ("tousrname", ArgumentSemantic.Retain)]
        string Tousrname { get; set; }

        // @property (retain, nonatomic) NSString * extMsg;
        [Export ("extMsg", ArgumentSemantic.Retain)]
        string ExtMsg { get; set; }
    }

    // @interface WXCardItem : NSObject
    [BaseType (typeof (NSObject))]
    interface WXCardItem
    {
        // @property (retain, nonatomic) NSString * cardId;
        [Export ("cardId", ArgumentSemantic.Retain)]
        string CardId { get; set; }

        // @property (retain, nonatomic) NSString * extMsg;
        [Export ("extMsg", ArgumentSemantic.Retain)]
        string ExtMsg { get; set; }

        // @property (assign, nonatomic) UInt32 cardState;
        [Export ("cardState")]
        uint CardState { get; set; }

        // @property (retain, nonatomic) NSString * encryptCode;
        [Export ("encryptCode", ArgumentSemantic.Retain)]
        string EncryptCode { get; set; }

        // @property (retain, nonatomic) NSString * appID;
        [Export ("appID", ArgumentSemantic.Retain)]
        string AppID { get; set; }
    }

    // @interface AddCardToWXCardPackageReq : BaseReq
    [BaseType (typeof (BaseReq))]
    interface AddCardToWXCardPackageReq
    {
        // @property (retain, nonatomic) NSArray * cardAry;
        [Export ("cardAry", ArgumentSemantic.Retain)]
        NSObject [] CardAry { get; set; }
    }

    // @interface AddCardToWXCardPackageResp : BaseResp
    [BaseType (typeof (BaseResp))]
    interface AddCardToWXCardPackageResp
    {
        // @property (retain, nonatomic) NSArray * cardAry;
        [Export ("cardAry", ArgumentSemantic.Retain)]
        NSObject [] CardAry { get; set; }
    }

    // @interface WXChooseCardReq : BaseReq
    [BaseType (typeof (BaseReq))]
    interface WXChooseCardReq
    {
        // @property (nonatomic, strong) NSString * appID;
        [Export ("appID", ArgumentSemantic.Strong)]
        string AppID { get; set; }

        // @property (assign, nonatomic) UInt32 shopID;
        [Export ("shopID")]
        uint ShopID { get; set; }

        // @property (assign, nonatomic) UInt32 canMultiSelect;
        [Export ("canMultiSelect")]
        uint CanMultiSelect { get; set; }

        // @property (nonatomic, strong) NSString * cardType;
        [Export ("cardType", ArgumentSemantic.Strong)]
        string CardType { get; set; }

        // @property (nonatomic, strong) NSString * cardTpID;
        [Export ("cardTpID", ArgumentSemantic.Strong)]
        string CardTpID { get; set; }

        // @property (nonatomic, strong) NSString * signType;
        [Export ("signType", ArgumentSemantic.Strong)]
        string SignType { get; set; }

        // @property (nonatomic, strong) NSString * cardSign;
        [Export ("cardSign", ArgumentSemantic.Strong)]
        string CardSign { get; set; }

        // @property (assign, nonatomic) UInt32 timeStamp;
        [Export ("timeStamp")]
        uint TimeStamp { get; set; }

        // @property (nonatomic, strong) NSString * nonceStr;
        [Export ("nonceStr", ArgumentSemantic.Strong)]
        string NonceStr { get; set; }
    }

    // @interface WXChooseCardResp : BaseResp
    [BaseType (typeof (BaseResp))]
    interface WXChooseCardResp
    {
        // @property (retain, nonatomic) NSArray * cardAry;
        [Export ("cardAry", ArgumentSemantic.Retain)]
        NSObject [] CardAry { get; set; }
    }

    // @interface WXMediaMessage : NSObject
    [BaseType (typeof (NSObject))]
    interface WXMediaMessage
    {
        // +(WXMediaMessage *)message;
        [Static]
        [Export ("message")]
        WXMediaMessage Message { get; }

        // @property (retain, nonatomic) NSString * title;
        [Export ("title", ArgumentSemantic.Retain)]
        string Title { get; set; }

        // @property (retain, nonatomic) NSString * description;
        [Export ("description", ArgumentSemantic.Retain)]
        string Description { get; set; }

        // @property (retain, nonatomic) NSData * thumbData;
        [Export ("thumbData", ArgumentSemantic.Retain)]
        NSData ThumbData { get; set; }

        // @property (retain, nonatomic) NSString * mediaTagName;
        [Export ("mediaTagName", ArgumentSemantic.Retain)]
        string MediaTagName { get; set; }

        // @property (retain, nonatomic) NSString * messageExt;
        [Export ("messageExt", ArgumentSemantic.Retain)]
        string MessageExt { get; set; }

        // @property (retain, nonatomic) NSString * messageAction;
        [Export ("messageAction", ArgumentSemantic.Retain)]
        string MessageAction { get; set; }

        // @property (retain, nonatomic) id mediaObject;
        [Export ("mediaObject", ArgumentSemantic.Retain)]
        NSObject MediaObject { get; set; }

        // -(void)setThumbImage:(id)image;
        [Export ("setThumbImage:")]
        void SetThumbImage (NSObject image);
    }

    // @interface WXImageObject : NSObject
    [BaseType (typeof (NSObject))]
    interface WXImageObject
    {
        // +(WXImageObject *)object;
        [Static]
        [Export ("object")]
        WXImageObject Object { get; }

        // @property (retain, nonatomic) NSData * imageData;
        [Export ("imageData", ArgumentSemantic.Retain)]
        NSData ImageData { get; set; }
    }

    // @interface WXMusicObject : NSObject
    [BaseType (typeof (NSObject))]
    interface WXMusicObject
    {
        // +(WXMusicObject *)object;
        [Static]
        [Export ("object")]
        WXMusicObject Object { get; }

        // @property (retain, nonatomic) NSString * musicUrl;
        [Export ("musicUrl", ArgumentSemantic.Retain)]
        string MusicUrl { get; set; }

        // @property (retain, nonatomic) NSString * musicLowBandUrl;
        [Export ("musicLowBandUrl", ArgumentSemantic.Retain)]
        string MusicLowBandUrl { get; set; }

        // @property (retain, nonatomic) NSString * musicDataUrl;
        [Export ("musicDataUrl", ArgumentSemantic.Retain)]
        string MusicDataUrl { get; set; }

        // @property (retain, nonatomic) NSString * musicLowBandDataUrl;
        [Export ("musicLowBandDataUrl", ArgumentSemantic.Retain)]
        string MusicLowBandDataUrl { get; set; }
    }

    // @interface WXVideoObject : NSObject
    [BaseType (typeof (NSObject))]
    interface WXVideoObject
    {
        // +(WXVideoObject *)object;
        [Static]
        [Export ("object")]
        WXVideoObject Object { get; }

        // @property (retain, nonatomic) NSString * videoUrl;
        [Export ("videoUrl", ArgumentSemantic.Retain)]
        string VideoUrl { get; set; }

        // @property (retain, nonatomic) NSString * videoLowBandUrl;
        [Export ("videoLowBandUrl", ArgumentSemantic.Retain)]
        string VideoLowBandUrl { get; set; }
    }

    // @interface WXWebpageObject : NSObject
    [BaseType (typeof (NSObject))]
    interface WXWebpageObject
    {
        // +(WXWebpageObject *)object;
        [Static]
        [Export ("object")]
        WXWebpageObject Object { get; }

        // @property (retain, nonatomic) NSString * webpageUrl;
        [Export ("webpageUrl", ArgumentSemantic.Retain)]
        string WebpageUrl { get; set; }
    }

    // @interface WXAppExtendObject : NSObject
    [BaseType (typeof (NSObject))]
    interface WXAppExtendObject
    {
        // +(WXAppExtendObject *)object;
        [Static]
        [Export ("object")]
        WXAppExtendObject Object { get; }

        // @property (retain, nonatomic) NSString * url;
        [Export ("url", ArgumentSemantic.Retain)]
        string Url { get; set; }

        // @property (retain, nonatomic) NSString * extInfo;
        [Export ("extInfo", ArgumentSemantic.Retain)]
        string ExtInfo { get; set; }

        // @property (retain, nonatomic) NSData * fileData;
        [Export ("fileData", ArgumentSemantic.Retain)]
        NSData FileData { get; set; }
    }

    // @interface WXEmoticonObject : NSObject
    [BaseType (typeof (NSObject))]
    interface WXEmoticonObject
    {
        // +(WXEmoticonObject *)object;
        [Static]
        [Export ("object")]
        WXEmoticonObject Object { get; }

        // @property (retain, nonatomic) NSData * emoticonData;
        [Export ("emoticonData", ArgumentSemantic.Retain)]
        NSData EmoticonData { get; set; }
    }

    // @interface WXFileObject : NSObject
    [BaseType (typeof (NSObject))]
    interface WXFileObject
    {
        // +(WXFileObject *)object;
        [Static]
        [Export ("object")]
        WXFileObject Object { get; }

        // @property (retain, nonatomic) NSString * fileExtension;
        [Export ("fileExtension", ArgumentSemantic.Retain)]
        string FileExtension { get; set; }

        // @property (retain, nonatomic) NSData * fileData;
        [Export ("fileData", ArgumentSemantic.Retain)]
        NSData FileData { get; set; }
    }

    // @interface WXLocationObject : NSObject
    [BaseType (typeof (NSObject))]
    interface WXLocationObject
    {
        // +(WXLocationObject *)object;
        [Static]
        [Export ("object")]
        WXLocationObject Object { get; }

        // @property (assign, nonatomic) double lng;
        [Export ("lng")]
        double Lng { get; set; }

        // @property (assign, nonatomic) double lat;
        [Export ("lat")]
        double Lat { get; set; }
    }

    // @interface WXTextObject : NSObject
    [BaseType (typeof (NSObject))]
    interface WXTextObject
    {
        // +(WXTextObject *)object;
        [Static]
        [Export ("object")]
        WXTextObject Object { get; }

        // @property (retain, nonatomic) NSString * contentText;
        [Export ("contentText", ArgumentSemantic.Retain)]
        string ContentText { get; set; }
    }

    // @protocol WXApiDelegate <NSObject>
    [Protocol, Model]
    [BaseType (typeof (NSObject))]
    interface WXApiDelegate
    {
        // @optional -(void)onReq:(BaseReq *)req;
        [Export ("onReq:")]
        void OnReq (BaseReq req);

        // @optional -(void)onResp:(BaseResp *)resp;
        [Export ("onResp:")]
        void OnResp (BaseResp resp);
    }

    // @interface WXApi : NSObject
    [BaseType (typeof (NSObject))]
    interface WXApi
    {
        // +(BOOL)registerApp:(NSString *)appid;
        [Static]
        [Export ("registerApp:")]
        bool RegisterApp (string appid);

        // +(BOOL)registerApp:(NSString *)appid withDescription:(NSString *)appdesc;
        [Static]
        [Export ("registerApp:withDescription:")]
        bool RegisterApp (string appid, string appdesc);

        // +(void)registerAppSupportContentFlag:(UInt64)typeFlag;
        [Static]
        [Export ("registerAppSupportContentFlag:")]
        void RegisterAppSupportContentFlag (ulong typeFlag);

        // +(BOOL)handleOpenURL:(NSURL *)url delegate:(id<WXApiDelegate>)delegate;
        [Static]
        [Export ("handleOpenURL:delegate:")]
        bool HandleOpenURL (NSUrl url, WXApiDelegate @delegate);

        // +(BOOL)isWXAppInstalled;
        [Static]
        [Export ("isWXAppInstalled")]
        bool IsWXAppInstalled { get; }

        // +(BOOL)isWXAppSupportApi;
        [Static]
        [Export ("isWXAppSupportApi")]
        bool IsWXAppSupportApi { get; }

        // +(NSString *)getWXAppInstallUrl;
        [Static]
        [Export ("getWXAppInstallUrl")]
        string WXAppInstallUrl { get; }

        // +(NSString *)getApiVersion;
        [Static]
        [Export ("getApiVersion")]
        string ApiVersion { get; }

        // +(BOOL)openWXApp;
        [Static]
        [Export ("openWXApp")]
        bool OpenWXApp { get; }

        // +(BOOL)sendReq:(BaseReq *)req;
        [Static]
        [Export ("sendReq:")]
        bool SendReq (BaseReq req);

        // +(BOOL)sendAuthReq:(SendAuthReq *)req viewController:(id)viewController delegate:(id<WXApiDelegate>)delegate;
        [Static]
        [Export ("sendAuthReq:viewController:delegate:")]
        bool SendAuthReq (SendAuthReq req, NSObject viewController, WXApiDelegate @delegate);

        // +(BOOL)sendResp:(BaseResp *)resp;
        [Static]
        [Export ("sendResp:")]
        bool SendResp (BaseResp resp);
    }


    #endregion
}

