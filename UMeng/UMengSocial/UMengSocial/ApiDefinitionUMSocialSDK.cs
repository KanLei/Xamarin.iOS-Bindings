using System;
using CoreGraphics;
using CoreLocation;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace UMengSocial
{
    #region UMSocialCore


    // @interface UMSBaeViewController : UIViewController
    [BaseType (typeof (UIViewController))]
    interface UMSBaeViewController
    {
        // @property (nonatomic, strong) NSString * titleString;
        [Export ("titleString", ArgumentSemantic.Strong)]
        string TitleString { get; set; }

        // -(CGFloat)viewOffsetY;
        [Export ("viewOffsetY")]
        nfloat ViewOffsetY { get; }
    }

    [Static]
    partial interface Constants
    {
        // extern double UMSocialCoreVersionNumber;
        [Field ("UMSocialCoreVersionNumber", "__Internal")]
        double UMSocialCoreVersionNumber { get; }

        // extern const unsigned char [] UMSocialCoreVersionString;
        //[Field ("UMSocialCoreVersionString", "__Internal")]
        //byte [] UMSocialCoreVersionString { get; }
    }

    // @interface UMSocialCoreImageUtils : NSObject
    [BaseType (typeof (NSObject))]
    interface UMSocialCoreImageUtils
    {
        // +(UIImage *)fixOrientation:(UIImage *)sourceImage;
        [Static]
        [Export ("fixOrientation:")]
        UIImage FixOrientation (UIImage sourceImage);

        // +(UIImage *)imageWithColor:(UIColor *)color;
        [Static]
        [Export ("imageWithColor:")]
        UIImage ImageWithColor (UIColor color);

        // +(UIImage *)imageByScalingImage:(UIImage *)image proportionallyToSize:(CGSize)targetSize;
        [Static]
        [Export ("imageByScalingImage:proportionallyToSize:")]
        UIImage ImageByScalingImage (UIImage image, CGSize targetSize);

        // +(NSData *)imageDataByCompressImage:(UIImage *)image toLength:(CGFloat)targetLength;
        [Static]
        [Export ("imageDataByCompressImage:toLength:")]
        NSData ImageDataByCompressImage (UIImage image, nfloat targetLength);

        // +(UIImage *)imageByCompressImage:(UIImage *)image toLength:(CGFloat)targetLength;
        [Static]
        [Export ("imageByCompressImage:toLength:")]
        UIImage ImageByCompressImage (UIImage image, nfloat targetLength);
    }

    partial interface Constants
    {
        // extern NSString *const UMSPlatformNameSina;
        [Field ("UMSPlatformNameSina", "__Internal")]
        NSString UMSPlatformNameSina { get; }

        // extern NSString *const UMSPlatformNameTencentWb;
        [Field ("UMSPlatformNameTencentWb", "__Internal")]
        NSString UMSPlatformNameTencentWb { get; }

        // extern NSString *const UMSPlatformNameDingDing;
        [Field ("UMSPlatformNameDingDing", "__Internal")]
        NSString UMSPlatformNameDingDing { get; }

        // extern NSString *const UMSPlatformNameRenren;
        [Field ("UMSPlatformNameRenren", "__Internal")]
        NSString UMSPlatformNameRenren { get; }

        // extern NSString *const UMSPlatformNameDouban;
        [Field ("UMSPlatformNameDouban", "__Internal")]
        NSString UMSPlatformNameDouban { get; }

        // extern NSString *const UMSPlatformNameQzone;
        [Field ("UMSPlatformNameQzone", "__Internal")]
        NSString UMSPlatformNameQzone { get; }

        // extern NSString *const UMSPlatformNameEmail;
        [Field ("UMSPlatformNameEmail", "__Internal")]
        NSString UMSPlatformNameEmail { get; }

        // extern NSString *const UMSPlatformNameSms;
        [Field ("UMSPlatformNameSms", "__Internal")]
        NSString UMSPlatformNameSms { get; }

        // extern NSString *const UMSPlatformNameWechatSession;
        [Field ("UMSPlatformNameWechatSession", "__Internal")]
        NSString UMSPlatformNameWechatSession { get; }

        // extern NSString *const UMSPlatformNameWechatTimeline;
        [Field ("UMSPlatformNameWechatTimeline", "__Internal")]
        NSString UMSPlatformNameWechatTimeline { get; }

        // extern NSString *const UMSPlatformNameWechatFavorite;
        [Field ("UMSPlatformNameWechatFavorite", "__Internal")]
        NSString UMSPlatformNameWechatFavorite { get; }

        // extern NSString *const UMSPlatformNameAlipaySession;
        [Field ("UMSPlatformNameAlipaySession", "__Internal")]
        NSString UMSPlatformNameAlipaySession { get; }

        // extern NSString *const UMSPlatformNameQQ;
        [Field ("UMSPlatformNameQQ", "__Internal")]
        NSString UMSPlatformNameQQ { get; }

        // extern NSString *const UMSPlatformNameFacebook;
        [Field ("UMSPlatformNameFacebook", "__Internal")]
        NSString UMSPlatformNameFacebook { get; }

        // extern NSString *const UMSPlatformNameTwitter;
        [Field ("UMSPlatformNameTwitter", "__Internal")]
        NSString UMSPlatformNameTwitter { get; }

        // extern NSString *const UMSPlatformNameYXSession;
        [Field ("UMSPlatformNameYXSession", "__Internal")]
        NSString UMSPlatformNameYXSession { get; }

        // extern NSString *const UMSPlatformNameYXTimeline;
        [Field ("UMSPlatformNameYXTimeline", "__Internal")]
        NSString UMSPlatformNameYXTimeline { get; }

        // extern NSString *const UMSPlatformNameLWSession;
        [Field ("UMSPlatformNameLWSession", "__Internal")]
        NSString UMSPlatformNameLWSession { get; }

        // extern NSString *const UMSPlatformNameLWTimeline;
        [Field ("UMSPlatformNameLWTimeline", "__Internal")]
        NSString UMSPlatformNameLWTimeline { get; }

        // extern NSString *const UMSPlatformNameInstagram;
        [Field ("UMSPlatformNameInstagram", "__Internal")]
        NSString UMSPlatformNameInstagram { get; }

        // extern NSString *const UMSPlatformNameWhatsapp;
        [Field ("UMSPlatformNameWhatsapp", "__Internal")]
        NSString UMSPlatformNameWhatsapp { get; }

        // extern NSString *const UMSPlatformNameLine;
        [Field ("UMSPlatformNameLine", "__Internal")]
        NSString UMSPlatformNameLine { get; }

        // extern NSString *const UMSPlatformNameTumblr;
        [Field ("UMSPlatformNameTumblr", "__Internal")]
        NSString UMSPlatformNameTumblr { get; }

        // extern NSString *const UMSPlatformNameLinkedin;
        [Field ("UMSPlatformNameLinkedin", "__Internal")]
        NSString UMSPlatformNameLinkedin { get; }

        // extern NSString *const UMSPlatformNamePinterest;
        [Field ("UMSPlatformNamePinterest", "__Internal")]
        NSString UMSPlatformNamePinterest { get; }

        // extern NSString *const UMSPlatformNameKakaoTalk;
        [Field ("UMSPlatformNameKakaoTalk", "__Internal")]
        NSString UMSPlatformNameKakaoTalk { get; }

        // extern NSString *const UMSPlatformNameFlickr;
        [Field ("UMSPlatformNameFlickr", "__Internal")]
        NSString UMSPlatformNameFlickr { get; }
    }

    // typedef void (^UMSocialRequestCompletionHandler)(id, NSError *);
    delegate void UMSocialRequestCompletionHandler (NSObject arg0, NSError arg1);

    // typedef void (^UMSocialShareCompletionHandler)(id, NSError *);
    delegate void UMSocialShareCompletionHandler (NSObject arg0, NSError arg1);

    // typedef void (^UMSocialAuthCompletionHandler)(id, NSError *);
    delegate void UMSocialAuthCompletionHandler (NSObject arg0, NSError arg1);

    // typedef void (^UMSocialGetUserInfoCompletionHandler)(id, NSError *);
    delegate void UMSocialGetUserInfoCompletionHandler (NSObject arg0, NSError arg1);

    partial interface Constants
    {
        // extern NSString *const UMSocialPlatformErrorDomain;
        [Field ("UMSocialPlatformErrorDomain", "__Internal")]
        NSString UMSocialPlatformErrorDomain { get; }
    }

    // @interface UMSocialPlatformConfig : NSObject
    [BaseType (typeof (NSObject))]
    interface UMSocialPlatformConfig
    {
        // @property (nonatomic, strong) NSString * appKey;
        [Export ("appKey", ArgumentSemantic.Strong)]
        string AppKey { get; set; }

        // @property (nonatomic, strong) NSString * appSecret;
        [Export ("appSecret", ArgumentSemantic.Strong)]
        string AppSecret { get; set; }

        // @property (nonatomic, strong) NSString * redirectURL;
        [Export ("redirectURL", ArgumentSemantic.Strong)]
        string RedirectURL { get; set; }

        // +(NSString *)platformNameWithPlatformType:(UMSocialPlatformType)platformType;
        [Static]
        [Export ("platformNameWithPlatformType:")]
        string PlatformNameWithPlatformType (UMSocialPlatformType platformType);

        // +(id)platformHandlerWithPlatformType:(UMSocialPlatformType)platformType;
        [Static]
        [Export ("platformHandlerWithPlatformType:")]
        NSObject PlatformHandlerWithPlatformType (UMSocialPlatformType platformType);

        // +(NSError *)errorWithSocialErrorType:(UMSocialPlatformErrorType)errorType userInfo:(id)userInfo;
        [Static]
        [Export ("errorWithSocialErrorType:userInfo:")]
        NSError ErrorWithSocialErrorType (UMSocialPlatformErrorType errorType, NSObject userInfo);
    }

    // @interface UMSocialCloudViewConfig : NSObject
    [BaseType (typeof (NSObject))]
    interface UMSocialCloudViewConfig
    {
        // @property (nonatomic, strong) NSString * authViewTitle;
        [Export ("authViewTitle", ArgumentSemantic.Strong)]
        string AuthViewTitle { get; set; }

        // @property (nonatomic, strong) UIColor * authViewTitleColor;
        [Export ("authViewTitleColor", ArgumentSemantic.Strong)]
        UIColor AuthViewTitleColor { get; set; }

        // @property (nonatomic, strong) UIColor * authViewNavBarColor;
        [Export ("authViewNavBarColor", ArgumentSemantic.Strong)]
        UIColor AuthViewNavBarColor { get; set; }

        // @property (nonatomic, strong) UIButton * authViewCloseButton;
        [Export ("authViewCloseButton", ArgumentSemantic.Strong)]
        UIButton AuthViewCloseButton { get; set; }

        // @property (nonatomic, strong) NSString * editViewTitle;
        [Export ("editViewTitle", ArgumentSemantic.Strong)]
        string EditViewTitle { get; set; }

        // @property (nonatomic, strong) UIColor * editViewTitleColor;
        [Export ("editViewTitleColor", ArgumentSemantic.Strong)]
        UIColor EditViewTitleColor { get; set; }

        // @property (nonatomic, strong) UIColor * editViewNavBarColor;
        [Export ("editViewNavBarColor", ArgumentSemantic.Strong)]
        UIColor EditViewNavBarColor { get; set; }

        // @property (nonatomic, strong) UIButton * editViewCloseButton;
        [Export ("editViewCloseButton", ArgumentSemantic.Strong)]
        UIButton EditViewCloseButton { get; set; }

        // @property (nonatomic, strong) UIButton * editViewShareButton;
        [Export ("editViewShareButton", ArgumentSemantic.Strong)]
        UIButton EditViewShareButton { get; set; }

        // +(instancetype)sharedInstance;
        [Static]
        [Export ("sharedInstance")]
        UMSocialCloudViewConfig SharedInstance ();
    }

    partial interface Constants
    {
        // extern NSString *const kUMSocialAuthUID;
        [Field ("kUMSocialAuthUID", "__Internal")]
        NSString kUMSocialAuthUID { get; }

        // extern NSString *const kUMSocialAuthAccessToken;
        [Field ("kUMSocialAuthAccessToken", "__Internal")]
        NSString kUMSocialAuthAccessToken { get; }

        // extern NSString *const kUMSocialAuthExpireDate;
        [Field ("kUMSocialAuthExpireDate", "__Internal")]
        NSString kUMSocialAuthExpireDate { get; }

        // extern NSString *const kUMSocialAuthRefreshToken;
        [Field ("kUMSocialAuthRefreshToken", "__Internal")]
        NSString kUMSocialAuthRefreshToken { get; }

        // extern NSString *const kUMSocialAuthOpenID;
        [Field ("kUMSocialAuthOpenID", "__Internal")]
        NSString kUMSocialAuthOpenID { get; }
    }

    // @interface UMSocialDataManager : NSObject
    [BaseType (typeof (NSObject))]
    interface UMSocialDataManager
    {
        // +(UMSocialDataManager *)defaultManager;
        [Static]
        [Export ("defaultManager")]
        UMSocialDataManager DefaultManager { get; }

        // @property (readonly, nonatomic, strong) NSMutableDictionary * allAuthorUserInfo;
        [Export ("allAuthorUserInfo", ArgumentSemantic.Strong)]
        NSMutableDictionary AllAuthorUserInfo { get; }

        // -(void)setAuthorUserInfo:(NSDictionary *)userInfo platform:(UMSocialPlatformType)platformType;
        [Export ("setAuthorUserInfo:platform:")]
        void SetAuthorUserInfo (NSDictionary userInfo, UMSocialPlatformType platformType);

        // -(NSDictionary *)getAuthorUserInfoWithPlatform:(UMSocialPlatformType)platformType;
        [Export ("getAuthorUserInfoWithPlatform:")]
        NSDictionary GetAuthorUserInfoWithPlatform (UMSocialPlatformType platformType);

        // -(void)deleteAuthorUserInfoWithPlatform:(UMSocialPlatformType)platformType;
        [Export ("deleteAuthorUserInfoWithPlatform:")]
        void DeleteAuthorUserInfoWithPlatform (UMSocialPlatformType platformType);

        // -(BOOL)isAuth:(UMSocialPlatformType)platformType;
        [Export ("isAuth:")]
        bool IsAuth (UMSocialPlatformType platformType);

        // -(void)clearAllAuthorUserInfo;
        [Export ("clearAllAuthorUserInfo")]
        void ClearAllAuthorUserInfo ();
    }

    // @interface UMSocialGlobal : NSObject
    [BaseType (typeof (NSObject))]
    interface UMSocialGlobal
    {
        // +(UMSocialGlobal *)shareInstance;
        [Static]
        [Export ("shareInstance")]
        UMSocialGlobal ShareInstance { get; }

        // @property (assign, readwrite, atomic) NSInteger use_coco2dx;
        [Export ("use_coco2dx")]
        nint Use_coco2dx { get; set; }

        // @property (readwrite, copy, atomic) NSString * dc;
        [Export ("dc")]
        string Dc { get; set; }

        // @property (assign, readwrite, atomic) BOOL isUrlRequest;
        [Export ("isUrlRequest")]
        bool IsUrlRequest { get; set; }

        // @property (readwrite, copy, atomic) NSString * type;
        [Export ("type")]
        string Type { get; set; }

        // +(NSString *)umSocialSDKVersion;
        [Static]
        [Export ("umSocialSDKVersion")]
        string UmSocialSDKVersion { get; }

        // @property (readwrite, copy, atomic) NSString * thumblr_Tag;
        [Export ("thumblr_Tag")]
        string Thumblr_Tag { get; set; }

        // @property (assign, readwrite, atomic) BOOL isTruncateShareText;
        [Export ("isTruncateShareText")]
        bool IsTruncateShareText { get; set; }

        // @property (assign, readwrite, atomic) BOOL isUsingHttpsWhenShareContent;
        [Export ("isUsingHttpsWhenShareContent")]
        bool IsUsingHttpsWhenShareContent { get; set; }

        // @property (assign, readwrite, atomic) BOOL isClearCacheWhenGetUserInfo;
        [Export ("isClearCacheWhenGetUserInfo")]
        bool IsClearCacheWhenGetUserInfo { get; set; }
    }

    // @protocol UMSocialPlatformProvider <NSObject>
    [Protocol, Model]
    [BaseType (typeof (NSObject))]
    interface UMSocialPlatformProvider
    {
        // @optional @property (assign, nonatomic) UMSocialPlatformType socialPlatformType;
        [Export ("socialPlatformType", ArgumentSemantic.Assign)]
        UMSocialPlatformType SocialPlatformType { get; set; }

        // @optional -(void)umSocial_setAppKey:(NSString *)appKey withAppSecret:(NSString *)appSecret withRedirectURL:(NSString *)redirectURL;
        [Export ("umSocial_setAppKey:withAppSecret:withRedirectURL:")]
        void UmSocial_setAppKey (string appKey, string appSecret, string redirectURL);

        // @optional -(void)umSocial_AuthorizeWithUserInfo:(NSDictionary *)userInfo withCompletionHandler:(UMSocialRequestCompletionHandler)completionHandler;
        [Export ("umSocial_AuthorizeWithUserInfo:withCompletionHandler:")]
        void UmSocial_AuthorizeWithUserInfo (NSDictionary userInfo, UMSocialRequestCompletionHandler completionHandler);

        // @optional -(void)umSocial_AuthorizeWithUserInfo:(NSDictionary *)userInfo withViewController:(UIViewController *)viewController withCompletionHandler:(UMSocialRequestCompletionHandler)completionHandler;
        [Export ("umSocial_AuthorizeWithUserInfo:withViewController:withCompletionHandler:")]
        void UmSocial_AuthorizeWithUserInfo (NSDictionary userInfo, UIViewController viewController, UMSocialRequestCompletionHandler completionHandler);

        // @optional -(void)umSocial_ShareWithObject:(UMSocialMessageObject *)object withCompletionHandler:(UMSocialRequestCompletionHandler)completionHandler;
        [Export ("umSocial_ShareWithObject:withCompletionHandler:")]
        void UmSocial_ShareWithObject (UMSocialMessageObject @object, UMSocialRequestCompletionHandler completionHandler);

        // @optional -(void)umSocial_ShareWithObject:(UMSocialMessageObject *)object withViewController:(UIViewController *)viewController withCompletionHandler:(UMSocialRequestCompletionHandler)completionHandler;
        [Export ("umSocial_ShareWithObject:withViewController:withCompletionHandler:")]
        void UmSocial_ShareWithObject (UMSocialMessageObject @object, UIViewController viewController, UMSocialRequestCompletionHandler completionHandler);

        // @optional -(void)umSocial_cancelAuthWithCompletionHandler:(UMSocialRequestCompletionHandler)completionHandler;
        [Export ("umSocial_cancelAuthWithCompletionHandler:")]
        void UmSocial_cancelAuthWithCompletionHandler (UMSocialRequestCompletionHandler completionHandler);

        // @optional -(void)umSocial_RequestForUserProfileWithCompletionHandler:(UMSocialRequestCompletionHandler)completionHandler;
        [Export ("umSocial_RequestForUserProfileWithCompletionHandler:")]
        void UmSocial_RequestForUserProfileWithCompletionHandler (UMSocialRequestCompletionHandler completionHandler);

        // @optional -(void)umSocial_RequestForUserProfileWithViewController:(id)currentViewController completion:(UMSocialRequestCompletionHandler)completion;
        [Export ("umSocial_RequestForUserProfileWithViewController:completion:")]
        void UmSocial_RequestForUserProfileWithViewController (NSObject currentViewController, UMSocialRequestCompletionHandler completion);

        // @optional -(void)umSocial_clearCacheData;
        [Export ("umSocial_clearCacheData")]
        void UmSocial_clearCacheData ();

        // @optional -(BOOL)umSocial_handleOpenURL:(NSURL *)url;
        [Export ("umSocial_handleOpenURL:")]
        bool UmSocial_handleOpenURL (NSUrl url);

        // @optional -(UMSocialPlatformFeature)umSocial_SupportedFeatures;
        [Export ("umSocial_SupportedFeatures")]
        UMSocialPlatformFeature UmSocial_SupportedFeatures { get; }

        // @optional -(NSString *)umSocial_PlatformSDKVersion;
        [Export ("umSocial_PlatformSDKVersion")]
        string UmSocial_PlatformSDKVersion { get; }

        // @optional -(BOOL)checkUrlSchema;
        [Export ("checkUrlSchema")]
        bool CheckUrlSchema { get; }

        // @optional -(BOOL)umSocial_isInstall;
        [Export ("umSocial_isInstall")]
        bool UmSocial_isInstall { get; }

        // @optional -(BOOL)umSocial_isSupport;
        [Export ("umSocial_isSupport")]
        bool UmSocial_isSupport { get; }
    }

    partial interface Constants
    {
        // extern NSString *const UMSocialErrorDomain;
        [Field ("UMSocialErrorDomain", "__Internal")]
        NSString UMSocialErrorDomain { get; }

        // extern NSString *const UMSocialShareDataTypeIllegalMessage;
        [Field ("UMSocialShareDataTypeIllegalMessage", "__Internal")]
        NSString UMSocialShareDataTypeIllegalMessage { get; }
    }

    interface IUMSocialPlatformProvider { }

    // @interface UMSocialHandler : NSObject <UMSocialPlatformProvider>
    [BaseType (typeof (NSObject))]
    interface UMSocialHandler : IUMSocialPlatformProvider
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

        // @property (copy, nonatomic) UMSocialRequestCompletionHandler shareCompletionBlock;
        [Export ("shareCompletionBlock", ArgumentSemantic.Copy)]
        UMSocialRequestCompletionHandler ShareCompletionBlock { get; set; }

        // @property (copy, nonatomic) UMSocialRequestCompletionHandler authCompletionBlock;
        [Export ("authCompletionBlock", ArgumentSemantic.Copy)]
        UMSocialRequestCompletionHandler AuthCompletionBlock { get; set; }

        // @property (copy, nonatomic) UMSocialRequestCompletionHandler userinfoCompletionBlock;
        [Export ("userinfoCompletionBlock", ArgumentSemantic.Copy)]
        UMSocialRequestCompletionHandler UserinfoCompletionBlock { get; set; }

        // -(BOOL)searchForURLSchemeWithPrefix:(NSString *)prefix;
        [Export ("searchForURLSchemeWithPrefix:")]
        bool SearchForURLSchemeWithPrefix (string prefix);

        // -(void)setAppId:(NSString *)appID appSecret:(NSString *)secret url:(NSString *)url;
        [Export ("setAppId:appSecret:url:")]
        void SetAppId (string appID, string secret, string url);

        // -(void)saveuid:(NSString *)uid openid:(NSString *)openid accesstoken:(NSString *)token refreshtoken:(NSString *)retoken expiration:(id)expiration;
        [Export ("saveuid:openid:accesstoken:refreshtoken:expiration:")]
        void Saveuid (string uid, string openid, string token, string retoken, NSObject expiration);

        // @property (readonly, nonatomic, strong) UMSocialHandlerConfig * handlerConfig;
        [Export ("handlerConfig", ArgumentSemantic.Strong)]
        UMSocialHandlerConfig HandlerConfig { get; }
    }

    // @interface UMSocialLimit (UMSocialHandler)
    [Category]
    [BaseType (typeof (UMSocialHandler))]
    interface UMSocialHandler_UMSocialLimit
    {
        // -(BOOL)checkText:(NSString *)text withTextLimit:(NSUInteger)textLimit;
        [Export ("checkText:withTextLimit:")]
        bool CheckText (string text, nuint textLimit);

        // -(BOOL)checkData:(NSData *)data withDataLimit:(NSUInteger)dataLimit;
        [Export ("checkData:withDataLimit:")]
        bool CheckData (NSData data, nuint dataLimit);

        // -(NSString *)truncationText:(NSString *)text withTextLimit:(NSUInteger)textLimit;
        [Export ("truncationText:withTextLimit:")]
        string TruncationText (string text, nuint textLimit);

        // -(NSData *)compressImageData:(NSData *)imageData withImageLimit:(NSUInteger)imageLimit;
        [Export ("compressImageData:withImageLimit:")]
        NSData CompressImageData (NSData imageData, nuint imageLimit);
    }

    // @interface UMSocialShareObjectConfig : NSObject
    [BaseType (typeof (NSObject))]
    interface UMSocialShareObjectConfig
    {
        // @property (assign, readwrite, nonatomic) NSUInteger titleLimit;
        [Export ("titleLimit")]
        nuint TitleLimit { get; set; }

        // @property (assign, readwrite, nonatomic) NSUInteger descrLimit;
        [Export ("descrLimit")]
        nuint DescrLimit { get; set; }

        // @property (assign, readwrite, nonatomic) NSUInteger thumbImageDataLimit;
        [Export ("thumbImageDataLimit")]
        nuint ThumbImageDataLimit { get; set; }

        // @property (assign, readwrite, nonatomic) NSUInteger thumbImageUrlLimit;
        [Export ("thumbImageUrlLimit")]
        nuint ThumbImageUrlLimit { get; set; }
    }

    // @interface UMSocialShareTextObjectConfig : UMSocialShareObjectConfig
    [BaseType (typeof (UMSocialShareObjectConfig))]
    interface UMSocialShareTextObjectConfig
    {
        // @property (assign, readwrite, nonatomic) NSUInteger textLimit;
        [Export ("textLimit")]
        nuint TextLimit { get; set; }
    }

    // @interface UMSocialShareImageObjectConfig : UMSocialShareObjectConfig
    [BaseType (typeof (UMSocialShareObjectConfig))]
    interface UMSocialShareImageObjectConfig
    {
        // @property (assign, readwrite, nonatomic) NSUInteger shareImageDataLimit;
        [Export ("shareImageDataLimit")]
        nuint ShareImageDataLimit { get; set; }

        // @property (assign, readwrite, nonatomic) NSUInteger shareImageURLLimit;
        [Export ("shareImageURLLimit")]
        nuint ShareImageURLLimit { get; set; }
    }

    // @interface UMSocialShareMusicObjectConfig : UMSocialShareObjectConfig
    [BaseType (typeof (UMSocialShareObjectConfig))]
    interface UMSocialShareMusicObjectConfig
    {
        // @property (assign, readwrite, nonatomic) NSUInteger musicUrlLimit;
        [Export ("musicUrlLimit")]
        nuint MusicUrlLimit { get; set; }

        // @property (assign, readwrite, nonatomic) NSUInteger musicLowBandUrlLimit;
        [Export ("musicLowBandUrlLimit")]
        nuint MusicLowBandUrlLimit { get; set; }

        // @property (assign, readwrite, nonatomic) NSUInteger musicDataUrlLimit;
        [Export ("musicDataUrlLimit")]
        nuint MusicDataUrlLimit { get; set; }

        // @property (assign, readwrite, nonatomic) NSUInteger musicLowBandDataUrlLimit;
        [Export ("musicLowBandDataUrlLimit")]
        nuint MusicLowBandDataUrlLimit { get; set; }
    }

    // @interface UMSocialShareVideoObjectConfig : UMSocialShareObjectConfig
    [BaseType (typeof (UMSocialShareObjectConfig))]
    interface UMSocialShareVideoObjectConfig
    {
        // @property (assign, readwrite, nonatomic) NSUInteger videoUrlLimit;
        [Export ("videoUrlLimit")]
        nuint VideoUrlLimit { get; set; }

        // @property (assign, readwrite, nonatomic) NSUInteger videoLowBandUrlLimit;
        [Export ("videoLowBandUrlLimit")]
        nuint VideoLowBandUrlLimit { get; set; }

        // @property (assign, readwrite, nonatomic) NSUInteger videoStreamUrlLimit;
        [Export ("videoStreamUrlLimit")]
        nuint VideoStreamUrlLimit { get; set; }

        // @property (assign, readwrite, nonatomic) NSUInteger videoLowBandStreamUrlLimit;
        [Export ("videoLowBandStreamUrlLimit")]
        nuint VideoLowBandStreamUrlLimit { get; set; }
    }

    // @interface UMSocialShareWebpageObjectConfig : UMSocialShareObjectConfig
    [BaseType (typeof (UMSocialShareObjectConfig))]
    interface UMSocialShareWebpageObjectConfig
    {
        // @property (assign, readwrite, nonatomic) NSUInteger webpageUrlLimit;
        [Export ("webpageUrlLimit")]
        nuint WebpageUrlLimit { get; set; }
    }

    // @interface UMSocialShareEmailObjectConfig : UMSocialShareObjectConfig
    [BaseType (typeof (UMSocialShareObjectConfig))]
    interface UMSocialShareEmailObjectConfig
    {
        // @property (assign, readwrite, nonatomic) NSUInteger toRecipientLimit;
        [Export ("toRecipientLimit")]
        nuint ToRecipientLimit { get; set; }

        // @property (assign, readwrite, nonatomic) NSUInteger ccRecipientLimit;
        [Export ("ccRecipientLimit")]
        nuint CcRecipientLimit { get; set; }

        // @property (assign, readwrite, nonatomic) NSUInteger bccRecipientLimit;
        [Export ("bccRecipientLimit")]
        nuint BccRecipientLimit { get; set; }

        // @property (assign, readwrite, nonatomic) NSUInteger emailContentLimit;
        [Export ("emailContentLimit")]
        nuint EmailContentLimit { get; set; }

        // @property (assign, readwrite, nonatomic) NSUInteger emailImageDataLimit;
        [Export ("emailImageDataLimit")]
        nuint EmailImageDataLimit { get; set; }

        // @property (assign, readwrite, nonatomic) NSUInteger emailImageUrlLimit;
        [Export ("emailImageUrlLimit")]
        nuint EmailImageUrlLimit { get; set; }

        // @property (assign, readwrite, nonatomic) NSUInteger emailSendDataLimit;
        [Export ("emailSendDataLimit")]
        nuint EmailSendDataLimit { get; set; }

        // @property (readwrite, nonatomic, strong) NSArray * fileType;
        [Export ("fileType", ArgumentSemantic.Strong)]
        NSObject [] FileType { get; set; }

        // @property (assign, readwrite, nonatomic) NSUInteger fileNameLimit;
        [Export ("fileNameLimit")]
        nuint FileNameLimit { get; set; }
    }

    // @interface UMSocialShareSmsObjectConfig : UMSocialShareObjectConfig
    [BaseType (typeof (UMSocialShareObjectConfig))]
    interface UMSocialShareSmsObjectConfig
    {
        // @property (assign, readwrite, nonatomic) NSUInteger recipientLimit;
        [Export ("recipientLimit")]
        nuint RecipientLimit { get; set; }

        // @property (assign, readwrite, nonatomic) NSUInteger smsContentLimit;
        [Export ("smsContentLimit")]
        nuint SmsContentLimit { get; set; }

        // @property (assign, readwrite, nonatomic) NSUInteger smsImageDataLimit;
        [Export ("smsImageDataLimit")]
        nuint SmsImageDataLimit { get; set; }

        // @property (assign, readwrite, nonatomic) NSUInteger smsImageUrlLimit;
        [Export ("smsImageUrlLimit")]
        nuint SmsImageUrlLimit { get; set; }

        // @property (assign, readwrite, nonatomic) NSUInteger smsSendDataLimit;
        [Export ("smsSendDataLimit")]
        nuint SmsSendDataLimit { get; set; }

        // @property (readwrite, nonatomic, strong) NSArray * fileType;
        [Export ("fileType", ArgumentSemantic.Strong)]
        NSObject [] FileType { get; set; }

        // @property (assign, readwrite, nonatomic) NSUInteger fileNameLimit;
        [Export ("fileNameLimit")]
        nuint FileNameLimit { get; set; }

        // @property (assign, readwrite, nonatomic) NSUInteger fileUrlLimit;
        [Export ("fileUrlLimit")]
        nuint FileUrlLimit { get; set; }
    }

    // @interface UMSocialShareEmotionObjectConfig : UMSocialShareObjectConfig
    [BaseType (typeof (UMSocialShareObjectConfig))]
    interface UMSocialShareEmotionObjectConfig
    {
        // @property (assign, readwrite, nonatomic) NSUInteger emotionDataLimit;
        [Export ("emotionDataLimit")]
        nuint EmotionDataLimit { get; set; }
    }

    // @interface UMSocialShareFileObjectConfig : UMSocialShareObjectConfig
    [BaseType (typeof (UMSocialShareObjectConfig))]
    interface UMSocialShareFileObjectConfig
    {
        // @property (assign, readwrite, nonatomic) NSUInteger fileExtensionLimit;
        [Export ("fileExtensionLimit")]
        nuint FileExtensionLimit { get; set; }

        // @property (assign, readwrite, nonatomic) NSUInteger fileDataLimit;
        [Export ("fileDataLimit")]
        nuint FileDataLimit { get; set; }
    }

    // @interface UMSocialShareExtendObjectConfig : UMSocialShareObjectConfig
    [BaseType (typeof (UMSocialShareObjectConfig))]
    interface UMSocialShareExtendObjectConfig
    {
        // @property (assign, readwrite, nonatomic) NSUInteger urlLimit;
        [Export ("urlLimit")]
        nuint UrlLimit { get; set; }

        // @property (assign, readwrite, nonatomic) NSUInteger extInfoLimit;
        [Export ("extInfoLimit")]
        nuint ExtInfoLimit { get; set; }

        // @property (assign, readwrite, nonatomic) NSUInteger fileDataLimit;
        [Export ("fileDataLimit")]
        nuint FileDataLimit { get; set; }
    }

    // @interface UMSocialHandlerConfig : NSObject
    [BaseType (typeof (NSObject))]
    interface UMSocialHandlerConfig
    {
        // @property (readwrite, nonatomic, strong) UMSocialShareTextObjectConfig * shareTextObjectConfig;
        [Export ("shareTextObjectConfig", ArgumentSemantic.Strong)]
        UMSocialShareTextObjectConfig ShareTextObjectConfig { get; set; }

        // @property (readwrite, nonatomic, strong) UMSocialShareImageObjectConfig * shareImageObjectConfig;
        [Export ("shareImageObjectConfig", ArgumentSemantic.Strong)]
        UMSocialShareImageObjectConfig ShareImageObjectConfig { get; set; }

        // @property (readwrite, nonatomic, strong) UMSocialShareMusicObjectConfig * shareMusicObjectConfig;
        [Export ("shareMusicObjectConfig", ArgumentSemantic.Strong)]
        UMSocialShareMusicObjectConfig ShareMusicObjectConfig { get; set; }

        // @property (readwrite, nonatomic, strong) UMSocialShareVideoObjectConfig * shareVideoObjectConfig;
        [Export ("shareVideoObjectConfig", ArgumentSemantic.Strong)]
        UMSocialShareVideoObjectConfig ShareVideoObjectConfig { get; set; }

        // @property (readwrite, nonatomic, strong) UMSocialShareWebpageObjectConfig * shareWebpageObjectConfig;
        [Export ("shareWebpageObjectConfig", ArgumentSemantic.Strong)]
        UMSocialShareWebpageObjectConfig ShareWebpageObjectConfig { get; set; }

        // @property (readwrite, nonatomic, strong) UMSocialShareEmailObjectConfig * shareEmailObjectConfig;
        [Export ("shareEmailObjectConfig", ArgumentSemantic.Strong)]
        UMSocialShareEmailObjectConfig ShareEmailObjectConfig { get; set; }

        // @property (readwrite, nonatomic, strong) UMSocialShareSmsObjectConfig * shareSmsObjectConfig;
        [Export ("shareSmsObjectConfig", ArgumentSemantic.Strong)]
        UMSocialShareSmsObjectConfig ShareSmsObjectConfig { get; set; }

        // @property (readwrite, nonatomic, strong) UMSocialShareEmotionObjectConfig * shareEmotionObjectConfig;
        [Export ("shareEmotionObjectConfig", ArgumentSemantic.Strong)]
        UMSocialShareEmotionObjectConfig ShareEmotionObjectConfig { get; set; }

        // @property (readwrite, nonatomic, strong) UMSocialShareFileObjectConfig * shareFileObjectConfig;
        [Export ("shareFileObjectConfig", ArgumentSemantic.Strong)]
        UMSocialShareFileObjectConfig ShareFileObjectConfig { get; set; }

        // @property (readwrite, nonatomic, strong) UMSocialShareExtendObjectConfig * shareExtendObjectConfig;
        [Export ("shareExtendObjectConfig", ArgumentSemantic.Strong)]
        UMSocialShareExtendObjectConfig ShareExtendObjectConfig { get; set; }

        // +(BOOL)checkText:(NSString *)text withTextLimit:(NSUInteger)textLimit;
        [Static]
        [Export ("checkText:withTextLimit:")]
        bool CheckText (string text, nuint textLimit);

        // +(BOOL)checkData:(NSData *)data withDataLimit:(NSUInteger)dataLimit;
        [Static]
        [Export ("checkData:withDataLimit:")]
        bool CheckData (NSData data, nuint dataLimit);

        // +(NSString *)truncationText:(NSString *)text withTextLimit:(NSUInteger)textLimit;
        [Static]
        [Export ("truncationText:withTextLimit:")]
        string TruncationText (string text, nuint textLimit);

        // +(NSData *)compressImageData:(NSData *)imageData toLength:(CGFloat)imageLimit;
        [Static]
        [Export ("compressImageData:toLength:")]
        NSData CompressImageData (NSData imageData, nfloat imageLimit);

        // +(NSData *)compressImage:(UIImage *)image toLength:(CGFloat)imageLimit;
        [Static]
        [Export ("compressImage:toLength:")]
        NSData CompressImage (UIImage image, nfloat imageLimit);
    }

    // @interface UMSocialImageUtil : NSObject
    [BaseType (typeof (NSObject))]
    interface UMSocialImageUtil
    {
        // +(UIImage *)scaleImage:(UIImage *)image ToSize:(CGSize)size;
        [Static]
        [Export ("scaleImage:ToSize:")]
        UIImage ScaleImage (UIImage image, CGSize size);
    }

    // @interface UMSocialManager : NSObject
    [BaseType (typeof (NSObject))]
    interface UMSocialManager
    {
        // +(instancetype)defaultManager;
        [Static]
        [Export ("defaultManager")]
        UMSocialManager DefaultManager ();

        // @property (nonatomic, strong) NSString * umSocialAppkey;
        [Export ("umSocialAppkey", ArgumentSemantic.Strong)]
        string UmSocialAppkey { get; set; }

        // @property (nonatomic, strong) NSString * umSocialAppSecret;
        [Export ("umSocialAppSecret", ArgumentSemantic.Strong)]
        string UmSocialAppSecret { get; set; }

        // @property (readonly, nonatomic, strong) NSArray * platformTypeArray;
        [Export ("platformTypeArray", ArgumentSemantic.Strong)]
        NSObject [] PlatformTypeArray { get; }

        // -(void)openLog:(BOOL)isOpen;
        [Export ("openLog:")]
        void OpenLog (bool isOpen);

        // -(BOOL)setPlaform:(UMSocialPlatformType)platformType appKey:(NSString *)appKey appSecret:(NSString *)appSecret redirectURL:(NSString *)redirectURL;
        [Export ("setPlaform:appKey:appSecret:redirectURL:")]
        bool SetPlaform (UMSocialPlatformType platformType, string appKey, string appSecret, string redirectURL);

        // -(void)shareToPlatform:(UMSocialPlatformType)platformType messageObject:(UMSocialMessageObject *)messageObject currentViewController:(id)currentViewController completion:(UMSocialRequestCompletionHandler)completion;
        [Export ("shareToPlatform:messageObject:currentViewController:completion:")]
        void ShareToPlatform (UMSocialPlatformType platformType, UMSocialMessageObject messageObject, NSObject currentViewController, UMSocialRequestCompletionHandler completion);

        // -(void)cancelAuthWithPlatform:(UMSocialPlatformType)platformType completion:(UMSocialRequestCompletionHandler)completion;
        [Export ("cancelAuthWithPlatform:completion:")]
        void CancelAuthWithPlatform (UMSocialPlatformType platformType, UMSocialRequestCompletionHandler completion);

        // -(void)getUserInfoWithPlatform:(UMSocialPlatformType)platformType currentViewController:(id)currentViewController completion:(UMSocialRequestCompletionHandler)completion;
        [Export ("getUserInfoWithPlatform:currentViewController:completion:")]
        void GetUserInfoWithPlatform (UMSocialPlatformType platformType, NSObject currentViewController, UMSocialRequestCompletionHandler completion);

        // -(BOOL)handleOpenURL:(NSURL *)url;
        [Export ("handleOpenURL:")]
        bool HandleOpenURL (NSUrl url);

        // -(BOOL)addAddUserDefinePlatformProvider:(id<UMSocialPlatformProvider>)userDefinePlatformProvider withUserDefinePlatformType:(UMSocialPlatformType)platformType;
        [Export ("addAddUserDefinePlatformProvider:withUserDefinePlatformType:")]
        bool AddAddUserDefinePlatformProvider (UMSocialPlatformProvider userDefinePlatformProvider, UMSocialPlatformType platformType);

        // -(id<UMSocialPlatformProvider>)platformProviderWithPlatformType:(UMSocialPlatformType)platformType;
        [Export ("platformProviderWithPlatformType:")]
        UMSocialPlatformProvider PlatformProviderWithPlatformType (UMSocialPlatformType platformType);

        // -(void)removePlatformProviderWithPlatformTypes:(NSArray *)platformTypeArray;
        [Export ("removePlatformProviderWithPlatformTypes:")]
        void RemovePlatformProviderWithPlatformTypes (NSObject [] platformTypeArray);

        // -(void)removePlatformProviderWithPlatformType:(UMSocialPlatformType)platformType;
        [Export ("removePlatformProviderWithPlatformType:")]
        void RemovePlatformProviderWithPlatformType (UMSocialPlatformType platformType);

        // -(BOOL)isInstall:(UMSocialPlatformType)platformType;
        [Export ("isInstall:")]
        bool IsInstall (UMSocialPlatformType platformType);

        // -(BOOL)isSupport:(UMSocialPlatformType)platformType;
        [Export ("isSupport:")]
        bool IsSupport (UMSocialPlatformType platformType);

        // -(void)authWithPlatform:(UMSocialPlatformType)platformType currentViewController:(id)currentViewController completion:(UMSocialRequestCompletionHandler)completion;
        [Export ("authWithPlatform:currentViewController:completion:")]
        void AuthWithPlatform (UMSocialPlatformType platformType, NSObject currentViewController, UMSocialRequestCompletionHandler completion);
    }

    // @interface UMSocialMessageObject : NSObject
    [BaseType (typeof (NSObject))]
    interface UMSocialMessageObject
    {
        // @property (copy, nonatomic) NSString * title;
        [Export ("title")]
        string Title { get; set; }

        // @property (copy, nonatomic) NSString * text;
        [Export ("text")]
        string Text { get; set; }

        // @property (nonatomic, strong) id shareObject;
        [Export ("shareObject", ArgumentSemantic.Strong)]
        NSObject ShareObject { get; set; }

        // @property (nonatomic, strong) NSDictionary * moreInfo;
        [Export ("moreInfo", ArgumentSemantic.Strong)]
        NSDictionary MoreInfo { get; set; }

        // +(UMSocialMessageObject *)messageObject;
        [Static]
        [Export ("messageObject")]
        UMSocialMessageObject MessageObject { get; }

        // +(UMSocialMessageObject *)messageObjectWithMediaObject:(id)mediaObject;
        [Static]
        [Export ("messageObjectWithMediaObject:")]
        UMSocialMessageObject MessageObjectWithMediaObject (NSObject mediaObject);
    }

    // @interface UMShareObject : NSObject
    [BaseType (typeof (NSObject))]
    interface UMShareObject
    {
        // @property (copy, nonatomic) NSString * title;
        [Export ("title")]
        string Title { get; set; }

        // @property (copy, nonatomic) NSString * descr;
        [Export ("descr")]
        string Descr { get; set; }

        // @property (nonatomic, strong) id thumbImage;
        [Export ("thumbImage", ArgumentSemantic.Strong)]
        NSObject ThumbImage { get; set; }

        // +(id)shareObjectWithTitle:(NSString *)title descr:(NSString *)descr thumImage:(id)thumImage;
        [Static]
        [Export ("shareObjectWithTitle:descr:thumImage:")]
        NSObject ShareObjectWithTitle (string title, string descr, NSObject thumImage);

        // +(void)um_imageDataWithImage:(id)image completion:(void (^)(NSData *))completion;
        [Static]
        [Export ("um_imageDataWithImage:completion:")]
        void Um_imageDataWithImage (NSObject image, Action<NSData> completion);

        // +(void)um_imageDataWithImage:(id)image withCompletion:(void (^)(NSData *, NSError *))completion;
        [Static]
        [Export ("um_imageDataWithImage:withCompletion:")]
        void Um_imageDataWithImage (NSObject image, Action<NSData, NSError> completion);
    }

    // @interface UMShareImageObject : UMShareObject
    [BaseType (typeof (UMShareObject))]
    interface UMShareImageObject
    {
        // @property (retain, nonatomic) id shareImage;
        [Export ("shareImage", ArgumentSemantic.Retain)]
        NSObject ShareImage { get; set; }

        // +(UMShareImageObject *)shareObjectWithTitle:(NSString *)title descr:(NSString *)descr thumImage:(id)thumImage;
        [Static]
        [Export ("shareObjectWithTitle:descr:thumImage:")]
        UMShareImageObject ShareObjectWithTitle (string title, string descr, NSObject thumImage);
    }

    // @interface UMShareMusicObject : UMShareObject
    [BaseType (typeof (UMShareObject))]
    interface UMShareMusicObject
    {
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

        // +(UMShareMusicObject *)shareObjectWithTitle:(NSString *)title descr:(NSString *)descr thumImage:(id)thumImage;
        [Static]
        [Export ("shareObjectWithTitle:descr:thumImage:")]
        UMShareMusicObject ShareObjectWithTitle (string title, string descr, NSObject thumImage);
    }

    // @interface UMShareVideoObject : UMShareObject
    [BaseType (typeof (UMShareObject))]
    interface UMShareVideoObject
    {
        // @property (nonatomic, strong) NSString * videoUrl;
        [Export ("videoUrl", ArgumentSemantic.Strong)]
        string VideoUrl { get; set; }

        // @property (nonatomic, strong) NSString * videoLowBandUrl;
        [Export ("videoLowBandUrl", ArgumentSemantic.Strong)]
        string VideoLowBandUrl { get; set; }

        // @property (nonatomic, strong) NSString * videoStreamUrl;
        [Export ("videoStreamUrl", ArgumentSemantic.Strong)]
        string VideoStreamUrl { get; set; }

        // @property (nonatomic, strong) NSString * videoLowBandStreamUrl;
        [Export ("videoLowBandStreamUrl", ArgumentSemantic.Strong)]
        string VideoLowBandStreamUrl { get; set; }

        // +(UMShareVideoObject *)shareObjectWithTitle:(NSString *)title descr:(NSString *)descr thumImage:(id)thumImage;
        [Static]
        [Export ("shareObjectWithTitle:descr:thumImage:")]
        UMShareVideoObject ShareObjectWithTitle (string title, string descr, NSObject thumImage);
    }

    // @interface UMShareWebpageObject : UMShareObject
    [BaseType (typeof (UMShareObject))]
    interface UMShareWebpageObject
    {
        // @property (retain, nonatomic) NSString * webpageUrl;
        [Export ("webpageUrl", ArgumentSemantic.Retain)]
        string WebpageUrl { get; set; }

        // +(UMShareWebpageObject *)shareObjectWithTitle:(NSString *)title descr:(NSString *)descr thumImage:(id)thumImage;
        [Static]
        [Export ("shareObjectWithTitle:descr:thumImage:")]
        UMShareWebpageObject ShareObjectWithTitle (string title, string descr, NSObject thumImage);
    }

    // @interface UMShareEmailObject : UMShareObject
    [BaseType (typeof (UMShareObject))]
    interface UMShareEmailObject
    {
        // @property (nonatomic, strong) NSString * subject;
        [Export ("subject", ArgumentSemantic.Strong)]
        string Subject { get; set; }

        // @property (nonatomic, strong) NSArray * toRecipients;
        [Export ("toRecipients", ArgumentSemantic.Strong)]
        NSObject [] ToRecipients { get; set; }

        // @property (nonatomic, strong) NSArray * ccRecipients;
        [Export ("ccRecipients", ArgumentSemantic.Strong)]
        NSObject [] CcRecipients { get; set; }

        // @property (nonatomic, strong) NSArray * bccRecipients;
        [Export ("bccRecipients", ArgumentSemantic.Strong)]
        NSObject [] BccRecipients { get; set; }

        // @property (copy, nonatomic) NSString * emailContent;
        [Export ("emailContent")]
        string EmailContent { get; set; }

        // @property (nonatomic, strong) id emailImage;
        [Export ("emailImage", ArgumentSemantic.Strong)]
        NSObject EmailImage { get; set; }

        // @property (copy, nonatomic) NSString * emailImageType;
        [Export ("emailImageType")]
        string EmailImageType { get; set; }

        // @property (copy, nonatomic) NSString * emailImageName;
        [Export ("emailImageName")]
        string EmailImageName { get; set; }

        // @property (nonatomic, strong) NSData * emailSendData;
        [Export ("emailSendData", ArgumentSemantic.Strong)]
        NSData EmailSendData { get; set; }

        // @property (copy, nonatomic) NSString * fileType;
        [Export ("fileType")]
        string FileType { get; set; }

        // @property (copy, nonatomic) NSString * fileName;
        [Export ("fileName")]
        string FileName { get; set; }
    }

    // @interface UMShareSmsObject : UMShareObject
    [BaseType (typeof (UMShareObject))]
    interface UMShareSmsObject
    {
        // @property (nonatomic, strong) NSArray * recipients;
        [Export ("recipients", ArgumentSemantic.Strong)]
        NSObject [] Recipients { get; set; }

        // @property (nonatomic, strong) NSString * subject;
        [Export ("subject", ArgumentSemantic.Strong)]
        string Subject { get; set; }

        // @property (copy, nonatomic) NSString * smsContent;
        [Export ("smsContent")]
        string SmsContent { get; set; }

        // @property (nonatomic, strong) id smsImage;
        [Export ("smsImage", ArgumentSemantic.Strong)]
        NSObject SmsImage { get; set; }

        // @property (copy, nonatomic) NSString * imageType;
        [Export ("imageType")]
        string ImageType { get; set; }

        // @property (copy, nonatomic) NSString * imageName;
        [Export ("imageName")]
        string ImageName { get; set; }

        // @property (nonatomic, strong) NSData * smsSendData;
        [Export ("smsSendData", ArgumentSemantic.Strong)]
        NSData SmsSendData { get; set; }

        // @property (copy, nonatomic) NSString * fileType;
        [Export ("fileType")]
        string FileType { get; set; }

        // @property (copy, nonatomic) NSString * fileName;
        [Export ("fileName")]
        string FileName { get; set; }

        // @property (copy, nonatomic) NSString * fileUrl;
        [Export ("fileUrl")]
        string FileUrl { get; set; }
    }

    // @interface UMShareEmotionObject : UMShareObject
    [BaseType (typeof (UMShareObject))]
    interface UMShareEmotionObject
    {
        // @property (nonatomic, strong) NSData * emotionData;
        [Export ("emotionData", ArgumentSemantic.Strong)]
        NSData EmotionData { get; set; }

        // +(UMShareEmotionObject *)shareObjectWithTitle:(NSString *)title descr:(NSString *)descr thumImage:(id)thumImage;
        [Static]
        [Export ("shareObjectWithTitle:descr:thumImage:")]
        UMShareEmotionObject ShareObjectWithTitle (string title, string descr, NSObject thumImage);
    }

    // @interface UMShareExtendObject : UMShareObject
    [BaseType (typeof (UMShareObject))]
    interface UMShareExtendObject
    {
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

    // @interface UMShareFileObject : UMShareObject
    [BaseType (typeof (UMShareObject))]
    interface UMShareFileObject
    {
        // @property (retain, nonatomic) NSString * fileExtension;
        [Export ("fileExtension", ArgumentSemantic.Retain)]
        string FileExtension { get; set; }

        // @property (retain, nonatomic) NSData * fileData;
        [Export ("fileData", ArgumentSemantic.Retain)]
        NSData FileData { get; set; }
    }

    // @interface UMSocialResponse : NSObject
    [BaseType (typeof (NSObject))]
    interface UMSocialResponse
    {
        // @property (copy, nonatomic) NSString * uid;
        [Export ("uid")]
        string Uid { get; set; }

        // @property (copy, nonatomic) NSString * openid;
        [Export ("openid")]
        string Openid { get; set; }

        // @property (copy, nonatomic) NSString * refreshToken;
        [Export ("refreshToken")]
        string RefreshToken { get; set; }

        // @property (copy, nonatomic) NSDate * expiration;
        [Export ("expiration", ArgumentSemantic.Copy)]
        NSDate Expiration { get; set; }

        // @property (copy, nonatomic) NSString * accessToken;
        [Export ("accessToken")]
        string AccessToken { get; set; }

        // @property (assign, nonatomic) UMSocialPlatformType platformType;
        [Export ("platformType", ArgumentSemantic.Assign)]
        UMSocialPlatformType PlatformType { get; set; }

        // @property (nonatomic, strong) id originalResponse;
        [Export ("originalResponse", ArgumentSemantic.Strong)]
        NSObject OriginalResponse { get; set; }
    }

    // @interface UMSocialShareResponse : UMSocialResponse
    [BaseType (typeof (UMSocialResponse))]
    interface UMSocialShareResponse
    {
        // @property (copy, nonatomic) NSString * message;
        [Export ("message")]
        string Message { get; set; }

        // +(UMSocialShareResponse *)shareResponseWithMessage:(NSString *)message;
        [Static]
        [Export ("shareResponseWithMessage:")]
        UMSocialShareResponse ShareResponseWithMessage (string message);
    }

    // @interface UMSocialAuthResponse : UMSocialResponse
    [BaseType (typeof (UMSocialResponse))]
    interface UMSocialAuthResponse
    {
    }

    // @interface UMSocialUserInfoResponse : UMSocialResponse
    [BaseType (typeof (UMSocialResponse))]
    interface UMSocialUserInfoResponse
    {
        // @property (copy, nonatomic) NSString * name;
        [Export ("name")]
        string Name { get; set; }

        // @property (copy, nonatomic) NSString * iconurl;
        [Export ("iconurl")]
        string Iconurl { get; set; }

        // @property (copy, nonatomic) NSString * gender;
        [Export ("gender")]
        string Gender { get; set; }
    }

    // @interface UMSocialSOAuthViewController : UMSBaeViewController <UIWebViewDelegate, UIAlertViewDelegate>
    [BaseType (typeof (UMSBaeViewController))]
    interface UMSocialSOAuthViewController : IUIWebViewDelegate, IUIAlertViewDelegate
    {
        // @property (nonatomic, strong) UIWebView * webView;
        [Export ("webView", ArgumentSemantic.Strong)]
        UIWebView WebView { get; set; }

        // @property (assign, nonatomic) UMSocialPlatformType platformType;
        [Export ("platformType", ArgumentSemantic.Assign)]
        UMSocialPlatformType PlatformType { get; set; }

        // @property (copy, nonatomic) UMSocialRequestCompletionHandler authCompletionBlock;
        [Export ("authCompletionBlock", ArgumentSemantic.Copy)]
        UMSocialRequestCompletionHandler AuthCompletionBlock { get; set; }

        // @property (nonatomic, strong) NSString * waitUrl;
        [Export ("waitUrl", ArgumentSemantic.Strong)]
        string WaitUrl { get; set; }
    }

    // @interface UMSocialShareEditViewController : UMSBaeViewController
    [BaseType (typeof (UMSBaeViewController))]
    interface UMSocialShareEditViewController
    {
        // @property (nonatomic, strong) UIImageView * editBar;
        [Export ("editBar", ArgumentSemantic.Strong)]
        UIImageView EditBar { get; set; }

        // @property (nonatomic, strong) UILabel * numLabel;
        [Export ("numLabel", ArgumentSemantic.Strong)]
        UILabel NumLabel { get; set; }

        // @property (nonatomic, strong) UIImageView * imageView;
        [Export ("imageView", ArgumentSemantic.Strong)]
        UIImageView ImageView { get; set; }

        // @property (nonatomic, strong) UIButton * delBtn;
        [Export ("delBtn", ArgumentSemantic.Strong)]
        UIButton DelBtn { get; set; }

        // @property (nonatomic, strong) UITextView * editView;
        [Export ("editView", ArgumentSemantic.Strong)]
        UITextView EditView { get; set; }

        // @property (nonatomic, strong) UIView * editViewBack;
        [Export ("editViewBack", ArgumentSemantic.Strong)]
        UIView EditViewBack { get; set; }

        // @property (nonatomic, strong) UILabel * titleLabel;
        [Export ("titleLabel", ArgumentSemantic.Strong)]
        UILabel TitleLabel { get; set; }

        // @property (nonatomic, strong) UILabel * desLabel;
        [Export ("desLabel", ArgumentSemantic.Strong)]
        UILabel DesLabel { get; set; }

        // @property (nonatomic, strong) UMSocialMessageObject * shareContent;
        [Export ("shareContent", ArgumentSemantic.Strong)]
        UMSocialMessageObject ShareContent { get; set; }

        // @property (copy, nonatomic) UMSocialRequestCompletionHandler shareCompletionBlock;
        [Export ("shareCompletionBlock", ArgumentSemantic.Copy)]
        UMSocialRequestCompletionHandler ShareCompletionBlock { get; set; }

        // @property (nonatomic, strong) NSString * usid;
        [Export ("usid", ArgumentSemantic.Strong)]
        string Usid { get; set; }

        // @property (assign, nonatomic) UMSocialPlatformType platformType;
        [Export ("platformType", ArgumentSemantic.Assign)]
        UMSocialPlatformType PlatformType { get; set; }
    }

    partial interface Constants
    {
        // extern NSString *const UMSocialLogClosedLevelString;
        [Field ("UMSocialLogClosedLevelString", "__Internal")]
        NSString UMSocialLogClosedLevelString { get; }

        // extern NSString *const UMSocialLogErrorLevelString;
        [Field ("UMSocialLogErrorLevelString", "__Internal")]
        NSString UMSocialLogErrorLevelString { get; }

        // extern NSString *const UMSocialLogWarnLevelString;
        [Field ("UMSocialLogWarnLevelString", "__Internal")]
        NSString UMSocialLogWarnLevelString { get; }

        // extern NSString *const UMSocialLogInfoLevelString;
        [Field ("UMSocialLogInfoLevelString", "__Internal")]
        NSString UMSocialLogInfoLevelString { get; }

        // extern NSString *const UMSocialLogDebugLevelString;
        [Field ("UMSocialLogDebugLevelString", "__Internal")]
        NSString UMSocialLogDebugLevelString { get; }

        // extern NSString *const UMSocialLogVerboseLevelString;
        [Field ("UMSocialLogVerboseLevelString", "__Internal")]
        NSString UMSocialLogVerboseLevelString { get; }

        // extern NSString *const UMSocialLogErrorFlagString;
        [Field ("UMSocialLogErrorFlagString", "__Internal")]
        NSString UMSocialLogErrorFlagString { get; }

        // extern NSString *const UMSocialLogWarnFlagString;
        [Field ("UMSocialLogWarnFlagString", "__Internal")]
        NSString UMSocialLogWarnFlagString { get; }

        // extern NSString *const UMSocialLogInfoFlagString;
        [Field ("UMSocialLogInfoFlagString", "__Internal")]
        NSString UMSocialLogInfoFlagString { get; }

        // extern NSString *const UMSocialLogDebugFlagString;
        [Field ("UMSocialLogDebugFlagString", "__Internal")]
        NSString UMSocialLogDebugFlagString { get; }

        // extern NSString *const UMSocialLogVerboseFlagString;
        [Field ("UMSocialLogVerboseFlagString", "__Internal")]
        NSString UMSocialLogVerboseFlagString { get; }
    }


    #endregion
}

