using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

/* https://github.com/sinaweibosdk/weibo_ios_sdk */
namespace UMengSocial
{
    #region UMSocialSinaSSOHandler
    
    // @interface UMSocialSinaHandler
    [BaseType (typeof (UMSocialHandler))]
    interface UMSocialSinaHandler
    {
        // +(UMSocialSinaHandler *)defaultManager;
        [Static]
        [Export ("defaultManager")]
        UMSocialSinaHandler DefaultManager { get; }
    }

    #endregion


    #region WeiboSDK

    // @protocol WBHttpRequestDelegate <NSObject>
    [Protocol, Model]
    [BaseType (typeof (NSObject))]
    interface WBHttpRequestDelegate
    {
        // @optional -(void)request:(WBHttpRequest *)request didReceiveResponse:(NSURLResponse *)response;
        [Export ("request:didReceiveResponse:")]
        void DidReceiveResponse (WBHttpRequest request, NSUrlResponse response);

        // @optional -(void)request:(WBHttpRequest *)request didFailWithError:(NSError *)error;
        [Export ("request:didFailWithError:")]
        void DidFailWithError (WBHttpRequest request, NSError error);

        // @optional -(void)request:(WBHttpRequest *)request didFinishLoadingWithResult:(NSString *)result;
        [Export ("request:didFinishLoadingWithResult:")]
        void DidFinishLoadingWithResult (WBHttpRequest request, string result);

        // @optional -(void)request:(WBHttpRequest *)request didFinishLoadingWithDataResult:(NSData *)data;
        [Export ("request:didFinishLoadingWithDataResult:")]
        void DidFinishLoadingWithDataResult (WBHttpRequest request, NSData data);

        // @optional -(void)request:(WBHttpRequest *)request didReciveRedirectResponseWithURI:(NSURL *)redirectUrl;
        [Export ("request:didReciveRedirectResponseWithURI:")]
        void DidReciveRedirectResponseWithURI (WBHttpRequest request, NSUrl redirectUrl);
    }

    // @interface WBHttpRequest : NSObject
    [BaseType (typeof (NSObject))]
    interface WBHttpRequest
    {
        // @property (nonatomic, strong) NSString * url;
        [Export ("url", ArgumentSemantic.Strong)]
        string Url { get; set; }

        // @property (nonatomic, strong) NSString * httpMethod;
        [Export ("httpMethod", ArgumentSemantic.Strong)]
        string HttpMethod { get; set; }

        // @property (nonatomic, strong) NSDictionary * params;
        [Export ("params", ArgumentSemantic.Strong)]
        NSDictionary Params { get; set; }

        [Wrap ("WeakDelegate")]
        WBHttpRequestDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<WBHttpRequestDelegate> delegate;
        [NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (nonatomic, strong) NSString * tag;
        [Export ("tag", ArgumentSemantic.Strong)]
        string Tag { get; set; }

        // +(WBHttpRequest *)requestWithURL:(NSString *)url httpMethod:(NSString *)httpMethod params:(NSDictionary *)params delegate:(id<WBHttpRequestDelegate>)delegate withTag:(NSString *)tag;
        [Static]
        [Export ("requestWithURL:httpMethod:params:delegate:withTag:")]
        WBHttpRequest RequestWithURL (string url, string httpMethod, NSDictionary @params, WBHttpRequestDelegate @delegate, string tag);

        // +(WBHttpRequest *)requestWithAccessToken:(NSString *)accessToken url:(NSString *)url httpMethod:(NSString *)httpMethod params:(NSDictionary *)params delegate:(id<WBHttpRequestDelegate>)delegate withTag:(NSString *)tag;
        [Static]
        [Export ("requestWithAccessToken:url:httpMethod:params:delegate:withTag:")]
        WBHttpRequest RequestWithAccessToken (string accessToken, string url, string httpMethod, NSDictionary @params, WBHttpRequestDelegate @delegate, string tag);

        // -(void)disconnect;
        [Export ("disconnect")]
        void Disconnect ();

        // +(WBHttpRequest *)requestWithURL:(NSString *)url httpMethod:(NSString *)httpMethod params:(NSDictionary *)params queue:(NSOperationQueue *)queue withCompletionHandler:(WBRequestHandler)handler;
        [Static]
        [Export ("requestWithURL:httpMethod:params:queue:withCompletionHandler:")]
        WBHttpRequest RequestWithURL (string url, string httpMethod, NSDictionary @params, NSOperationQueue queue, WBRequestHandler handler);

        // +(WBHttpRequest *)requestWithAccessToken:(NSString *)accessToken url:(NSString *)url httpMethod:(NSString *)httpMethod params:(NSDictionary *)params queue:(NSOperationQueue *)queue withCompletionHandler:(WBRequestHandler)handler;
        [Static]
        [Export ("requestWithAccessToken:url:httpMethod:params:queue:withCompletionHandler:")]
        WBHttpRequest RequestWithAccessToken (string accessToken, string url, string httpMethod, NSDictionary @params, NSOperationQueue queue, WBRequestHandler handler);
    }

    // typedef void (^WBRequestHandler)(WBHttpRequest *, id, NSError *);
    delegate void WBRequestHandler (WBHttpRequest arg0, NSObject arg1, NSError arg2);

    // @interface WeiboUser (WBHttpRequest)
    [Category]
    [BaseType (typeof (WBHttpRequest))]
    interface WBHttpRequest_WeiboUser
    {
        // +(WBHttpRequest *)requestForFriendsListOfUser:(NSString *)currentUserID withAccessToken:(NSString *)accessToken andOtherProperties:(NSDictionary *)otherProperties queue:(NSOperationQueue *)queue withCompletionHandler:(WBRequestHandler)handler;
        [Static]
        [Export ("requestForFriendsListOfUser:withAccessToken:andOtherProperties:queue:withCompletionHandler:")]
        WBHttpRequest RequestForFriendsListOfUser (string currentUserID, string accessToken, NSDictionary otherProperties, NSOperationQueue queue, WBRequestHandler handler);

        // +(WBHttpRequest *)requestForFriendsUserIDListOfUser:(NSString *)currentUserID withAccessToken:(NSString *)accessToken andOtherProperties:(NSDictionary *)otherProperties queue:(NSOperationQueue *)queue withCompletionHandler:(WBRequestHandler)handler;
        [Static]
        [Export ("requestForFriendsUserIDListOfUser:withAccessToken:andOtherProperties:queue:withCompletionHandler:")]
        WBHttpRequest RequestForFriendsUserIDListOfUser (string currentUserID, string accessToken, NSDictionary otherProperties, NSOperationQueue queue, WBRequestHandler handler);

        // +(WBHttpRequest *)requestForCommonFriendsListBetweenUser:(NSString *)currentUserID andUser:(NSString *)anotherUserID withAccessToken:(NSString *)accessToken andOtherProperties:(NSDictionary *)otherProperties queue:(NSOperationQueue *)queue withCompletionHandler:(WBRequestHandler)handler;
        [Static]
        [Export ("requestForCommonFriendsListBetweenUser:andUser:withAccessToken:andOtherProperties:queue:withCompletionHandler:")]
        WBHttpRequest RequestForCommonFriendsListBetweenUser (string currentUserID, string anotherUserID, string accessToken, NSDictionary otherProperties, NSOperationQueue queue, WBRequestHandler handler);

        // +(WBHttpRequest *)requestForBilateralFriendsListOfUser:(NSString *)currentUserID withAccessToken:(NSString *)accessToken andOtherProperties:(NSDictionary *)otherProperties queue:(NSOperationQueue *)queue withCompletionHandler:(WBRequestHandler)handler;
        [Static]
        [Export ("requestForBilateralFriendsListOfUser:withAccessToken:andOtherProperties:queue:withCompletionHandler:")]
        WBHttpRequest RequestForBilateralFriendsListOfUser (string currentUserID, string accessToken, NSDictionary otherProperties, NSOperationQueue queue, WBRequestHandler handler);

        // +(WBHttpRequest *)requestForFollowersListOfUser:(NSString *)currentUserID withAccessToken:(NSString *)accessToken andOtherProperties:(NSDictionary *)otherProperties queue:(NSOperationQueue *)queue withCompletionHandler:(WBRequestHandler)handler;
        [Static]
        [Export ("requestForFollowersListOfUser:withAccessToken:andOtherProperties:queue:withCompletionHandler:")]
        WBHttpRequest RequestForFollowersListOfUser (string currentUserID, string accessToken, NSDictionary otherProperties, NSOperationQueue queue, WBRequestHandler handler);

        // +(WBHttpRequest *)requestForFollowersUserIDListOfUser:(NSString *)currentUserID withAccessToken:(NSString *)accessToken andOtherProperties:(NSDictionary *)otherProperties queue:(NSOperationQueue *)queue withCompletionHandler:(WBRequestHandler)handler;
        [Static]
        [Export ("requestForFollowersUserIDListOfUser:withAccessToken:andOtherProperties:queue:withCompletionHandler:")]
        WBHttpRequest RequestForFollowersUserIDListOfUser (string currentUserID, string accessToken, NSDictionary otherProperties, NSOperationQueue queue, WBRequestHandler handler);

        // +(WBHttpRequest *)requestForActiveFollowersListOfUser:(NSString *)currentUserID withAccessToken:(NSString *)accessToken andOtherProperties:(NSDictionary *)otherProperties queue:(NSOperationQueue *)queue withCompletionHandler:(WBRequestHandler)handler;
        [Static]
        [Export ("requestForActiveFollowersListOfUser:withAccessToken:andOtherProperties:queue:withCompletionHandler:")]
        WBHttpRequest RequestForActiveFollowersListOfUser (string currentUserID, string accessToken, NSDictionary otherProperties, NSOperationQueue queue, WBRequestHandler handler);

        // +(WBHttpRequest *)requestForBilateralFollowersListOfUser:(NSString *)currentUserID withAccessToken:(NSString *)accessToken andOtherProperties:(NSDictionary *)otherProperties queue:(NSOperationQueue *)queue withCompletionHandler:(WBRequestHandler)handler;
        [Static]
        [Export ("requestForBilateralFollowersListOfUser:withAccessToken:andOtherProperties:queue:withCompletionHandler:")]
        WBHttpRequest RequestForBilateralFollowersListOfUser (string currentUserID, string accessToken, NSDictionary otherProperties, NSOperationQueue queue, WBRequestHandler handler);

        // +(WBHttpRequest *)requestForFriendshipDetailBetweenTargetUser:(NSString *)targetUserID andSourceUser:(NSString *)sourceUserID withAccessToken:(NSString *)accessToken andOtherProperties:(NSDictionary *)otherProperties queue:(NSOperationQueue *)queue withCompletionHandler:(WBRequestHandler)handler;
        [Static]
        [Export ("requestForFriendshipDetailBetweenTargetUser:andSourceUser:withAccessToken:andOtherProperties:queue:withCompletionHandler:")]
        WBHttpRequest RequestForFriendshipDetailBetweenTargetUser (string targetUserID, string sourceUserID, string accessToken, NSDictionary otherProperties, NSOperationQueue queue, WBRequestHandler handler);

        // +(WBHttpRequest *)requestForFollowAUser:(NSString *)theUserToBeFollowed withAccessToken:(NSString *)accessToken andOtherProperties:(NSDictionary *)otherProperties queue:(NSOperationQueue *)queue withCompletionHandler:(WBRequestHandler)handler;
        [Static]
        [Export ("requestForFollowAUser:withAccessToken:andOtherProperties:queue:withCompletionHandler:")]
        WBHttpRequest RequestForFollowAUser (string theUserToBeFollowed, string accessToken, NSDictionary otherProperties, NSOperationQueue queue, WBRequestHandler handler);

        // +(WBHttpRequest *)requestForCancelFollowAUser:(NSString *)theUserThatYouDontLike withAccessToken:(NSString *)accessToken andOtherProperties:(NSDictionary *)otherProperties queue:(NSOperationQueue *)queue withCompletionHandler:(WBRequestHandler)handler;
        [Static]
        [Export ("requestForCancelFollowAUser:withAccessToken:andOtherProperties:queue:withCompletionHandler:")]
        WBHttpRequest RequestForCancelFollowAUser (string theUserThatYouDontLike, string accessToken, NSDictionary otherProperties, NSOperationQueue queue, WBRequestHandler handler);

        // +(WBHttpRequest *)requestForRemoveFollowerUser:(NSString *)theUserThatYouDontLike withAccessToken:(NSString *)accessToken andOtherProperties:(NSDictionary *)otherProperties queue:(NSOperationQueue *)queue withCompletionHandler:(WBRequestHandler)handler;
        [Static]
        [Export ("requestForRemoveFollowerUser:withAccessToken:andOtherProperties:queue:withCompletionHandler:")]
        WBHttpRequest RequestForRemoveFollowerUser (string theUserThatYouDontLike, string accessToken, NSDictionary otherProperties, NSOperationQueue queue, WBRequestHandler handler);

        // +(WBHttpRequest *)requestForInviteBilateralFriend:(NSString *)theUserThatShouldBeYourBilateralFriend withAccessToken:(NSString *)accessToken inviteText:(NSString *)text inviteUrl:(NSString *)url inviteLogoUrl:(NSString *)logoUrl queue:(NSOperationQueue *)queue withCompletionHandler:(WBRequestHandler)handler;
        [Static]
        [Export ("requestForInviteBilateralFriend:withAccessToken:inviteText:inviteUrl:inviteLogoUrl:queue:withCompletionHandler:")]
        WBHttpRequest RequestForInviteBilateralFriend (string theUserThatShouldBeYourBilateralFriend, string accessToken, string text, string url, string logoUrl, NSOperationQueue queue, WBRequestHandler handler);

        // +(WBHttpRequest *)requestForUserProfile:(NSString *)aUserID withAccessToken:(NSString *)accessToken andOtherProperties:(NSDictionary *)otherProperties queue:(NSOperationQueue *)queue withCompletionHandler:(WBRequestHandler)handler;
        [Static]
        [Export ("requestForUserProfile:withAccessToken:andOtherProperties:queue:withCompletionHandler:")]
        WBHttpRequest RequestForUserProfile (string aUserID, string accessToken, NSDictionary otherProperties, NSOperationQueue queue, WBRequestHandler handler);
    }

    // @interface WeiboShare (WBHttpRequest)
    [Category]
    [BaseType (typeof (WBHttpRequest))]
    interface WBHttpRequest_WeiboShare
    {
        // +(WBHttpRequest *)requestForStatusIDsFromCurrentUser:(NSString *)userID withAccessToken:(NSString *)accessToken andOtherProperties:(NSDictionary *)otherProperties queue:(NSOperationQueue *)queue withCompletionHandler:(WBRequestHandler)handler;
        [Static]
        [Export ("requestForStatusIDsFromCurrentUser:withAccessToken:andOtherProperties:queue:withCompletionHandler:")]
        WBHttpRequest RequestForStatusIDsFromCurrentUser (string userID, string accessToken, NSDictionary otherProperties, NSOperationQueue queue, WBRequestHandler handler);

        // +(WBHttpRequest *)requestForRepostAStatus:(NSString *)statusID repostText:(NSString *)text withAccessToken:(NSString *)accessToken andOtherProperties:(NSDictionary *)otherProperties queue:(NSOperationQueue *)queue withCompletionHandler:(WBRequestHandler)handler;
        [Static]
        [Export ("requestForRepostAStatus:repostText:withAccessToken:andOtherProperties:queue:withCompletionHandler:")]
        WBHttpRequest RequestForRepostAStatus (string statusID, string text, string accessToken, NSDictionary otherProperties, NSOperationQueue queue, WBRequestHandler handler);

        // +(WBHttpRequest *)requestForShareAStatus:(NSString *)statusText contatinsAPicture:(WBImageObject *)imageObject orPictureUrl:(NSString *)url withAccessToken:(NSString *)accessToken andOtherProperties:(NSDictionary *)otherProperties queue:(NSOperationQueue *)queue withCompletionHandler:(WBRequestHandler)handler;
        [Static]
        [Export ("requestForShareAStatus:contatinsAPicture:orPictureUrl:withAccessToken:andOtherProperties:queue:withCompletionHandler:")]
        WBHttpRequest RequestForShareAStatus (string statusText, WBImageObject imageObject, string url, string accessToken, NSDictionary otherProperties, NSOperationQueue queue, WBRequestHandler handler);
    }

    // @interface WeiboToken (WBHttpRequest)
    [Category]
    [BaseType (typeof (WBHttpRequest))]
    interface WBHttpRequest_WeiboToken
    {
        // +(WBHttpRequest *)requestForRenewAccessTokenWithRefreshToken:(NSString *)refreshToken queue:(NSOperationQueue *)queue withCompletionHandler:(WBRequestHandler)handler;
        [Static]
        [Export ("requestForRenewAccessTokenWithRefreshToken:queue:withCompletionHandler:")]
        WBHttpRequest RequestForRenewAccessTokenWithRefreshToken (string refreshToken, NSOperationQueue queue, WBRequestHandler handler);
    }

    // @interface WeiboGame (WBHttpRequest)
    [Category]
    [BaseType (typeof (WBHttpRequest))]
    interface WBHttpRequest_WeiboGame
    {
        // +(WBHttpRequest *)addGameObject:(NSString *)userID withAccessToken:(NSString *)accessToken andOtherProperties:(NSDictionary *)otherProperties queue:(NSOperationQueue *)queue withCompletionHandler:(WBRequestHandler)handler;
        [Static]
        [Export ("addGameObject:withAccessToken:andOtherProperties:queue:withCompletionHandler:")]
        WBHttpRequest AddGameObject (string userID, string accessToken, NSDictionary otherProperties, NSOperationQueue queue, WBRequestHandler handler);

        // +(WBHttpRequest *)addGameAchievementObject:(NSString *)userID withAccessToken:(NSString *)accessToken andOtherProperties:(NSDictionary *)otherProperties queue:(NSOperationQueue *)queue withCompletionHandler:(WBRequestHandler)handler;
        [Static]
        [Export ("addGameAchievementObject:withAccessToken:andOtherProperties:queue:withCompletionHandler:")]
        WBHttpRequest AddGameAchievementObject (string userID, string accessToken, NSDictionary otherProperties, NSOperationQueue queue, WBRequestHandler handler);

        // +(WBHttpRequest *)addGameAchievementGain:(NSString *)userID withAccessToken:(NSString *)accessToken andOtherProperties:(NSDictionary *)otherProperties queue:(NSOperationQueue *)queue withCompletionHandler:(WBRequestHandler)handler;
        [Static]
        [Export ("addGameAchievementGain:withAccessToken:andOtherProperties:queue:withCompletionHandler:")]
        WBHttpRequest AddGameAchievementGain (string userID, string accessToken, NSDictionary otherProperties, NSOperationQueue queue, WBRequestHandler handler);

        // +(WBHttpRequest *)addGameScoreGain:(NSString *)userID withAccessToken:(NSString *)accessToken andOtherProperties:(NSDictionary *)otherProperties queue:(NSOperationQueue *)queue withCompletionHandler:(WBRequestHandler)handler;
        [Static]
        [Export ("addGameScoreGain:withAccessToken:andOtherProperties:queue:withCompletionHandler:")]
        WBHttpRequest AddGameScoreGain (string userID, string accessToken, NSDictionary otherProperties, NSOperationQueue queue, WBRequestHandler handler);

        // +(WBHttpRequest *)requestForGameScore:(NSString *)userID withAccessToken:(NSString *)accessToken andOtherProperties:(NSDictionary *)otherProperties queue:(NSOperationQueue *)queue withCompletionHandler:(WBRequestHandler)handler;
        [Static]
        [Export ("requestForGameScore:withAccessToken:andOtherProperties:queue:withCompletionHandler:")]
        WBHttpRequest RequestForGameScore (string userID, string accessToken, NSDictionary otherProperties, NSOperationQueue queue, WBRequestHandler handler);

        // +(WBHttpRequest *)requestForFriendsGameScore:(NSString *)userID withAccessToken:(NSString *)accessToken andOtherProperties:(NSDictionary *)otherProperties queue:(NSOperationQueue *)queue withCompletionHandler:(WBRequestHandler)handler;
        [Static]
        [Export ("requestForFriendsGameScore:withAccessToken:andOtherProperties:queue:withCompletionHandler:")]
        WBHttpRequest RequestForFriendsGameScore (string userID, string accessToken, NSDictionary otherProperties, NSOperationQueue queue, WBRequestHandler handler);

        // +(WBHttpRequest *)requestForGameAchievementGain:(NSString *)userID withAccessToken:(NSString *)accessToken andOtherProperties:(NSDictionary *)otherProperties queue:(NSOperationQueue *)queue withCompletionHandler:(WBRequestHandler)handler;
        [Static]
        [Export ("requestForGameAchievementGain:withAccessToken:andOtherProperties:queue:withCompletionHandler:")]
        WBHttpRequest RequestForGameAchievementGain (string userID, string accessToken, NSDictionary otherProperties, NSOperationQueue queue, WBRequestHandler handler);
    }

    // typedef void (^WBSDKButtonHandler)(WBSDKBasicButton *, BOOL, NSDictionary *);
    delegate void WBSDKButtonHandler (WBSDKBasicButton arg0, bool arg1, NSDictionary arg2);

    // @interface WBSDKBasicButton : UIButton
    [BaseType (typeof (UIButton))]
    interface WBSDKBasicButton
    {
    }

    // @interface WBSDKRelationshipButton : WBSDKBasicButton
    [BaseType (typeof (WBSDKBasicButton))]
    interface WBSDKRelationshipButton
    {
        // -(id)initWithFrame:(CGRect)frame accessToken:(NSString *)accessToken currentUser:(NSString *)currentUserID followUser:(NSString *)followerUserID completionHandler:(WBSDKButtonHandler)handler;
        [Export ("initWithFrame:accessToken:currentUser:followUser:completionHandler:")]
        IntPtr Constructor (CGRect frame, string accessToken, string currentUserID, string followerUserID, WBSDKButtonHandler handler);

        // @property (nonatomic, strong) NSString * accessToken;
        [Export ("accessToken", ArgumentSemantic.Strong)]
        string AccessToken { get; set; }

        // @property (nonatomic, strong) NSString * currentUserID;
        [Export ("currentUserID", ArgumentSemantic.Strong)]
        string CurrentUserID { get; set; }

        // @property (nonatomic, strong) NSString * followUserID;
        [Export ("followUserID", ArgumentSemantic.Strong)]
        string FollowUserID { get; set; }

        // @property (assign, nonatomic) WBSDKRelationshipButtonState currentRelationShip;
        [Export ("currentRelationShip")]
        nuint CurrentRelationShip { get; set; }

        // -(void)checkCurrentRelationship;
        [Export ("checkCurrentRelationship")]
        void CheckCurrentRelationship ();
    }

    // @interface WBSDKCommentButton : WBSDKBasicButton
    [BaseType (typeof (WBSDKBasicButton))]
    interface WBSDKCommentButton
    {
        // -(id)initWithFrame:(CGRect)frame accessToken:(NSString *)accessToken keyword:(NSString *)keyWord urlString:(NSString *)urlString category:(NSString *)category completionHandler:(WBSDKButtonHandler)handler;
        [Export ("initWithFrame:accessToken:keyword:urlString:category:completionHandler:")]
        IntPtr Constructor (CGRect frame, string accessToken, string keyWord, string urlString, string category, WBSDKButtonHandler handler);

        // @property (nonatomic, strong) NSString * keyWord;
        [Export ("keyWord", ArgumentSemantic.Strong)]
        string KeyWord { get; set; }

        // @property (nonatomic, strong) NSString * accessToken;
        [Export ("accessToken", ArgumentSemantic.Strong)]
        string AccessToken { get; set; }

        // @property (nonatomic, strong) NSString * urlString;
        [Export ("urlString", ArgumentSemantic.Strong)]
        string UrlString { get; set; }

        // @property (nonatomic, strong) NSString * category;
        [Export ("category", ArgumentSemantic.Strong)]
        string Category { get; set; }
    }

    // @interface WeiboSDK : NSObject
    [BaseType (typeof (NSObject))]
    interface WeiboSDK
    {
        // +(BOOL)isWeiboAppInstalled;
        [Static]
        [Export ("isWeiboAppInstalled")]
        bool IsWeiboAppInstalled { get; }

        // +(BOOL)isCanShareInWeiboAPP;
        [Static]
        [Export ("isCanShareInWeiboAPP")]
        bool IsCanShareInWeiboAPP { get; }

        // +(BOOL)isCanSSOInWeiboApp;
        [Static]
        [Export ("isCanSSOInWeiboApp")]
        bool IsCanSSOInWeiboApp { get; }

        // +(BOOL)openWeiboApp;
        [Static]
        [Export ("openWeiboApp")]
        bool OpenWeiboApp { get; }

        // +(NSString *)getWeiboAppInstallUrl;
        [Static]
        [Export ("getWeiboAppInstallUrl")]
        string WeiboAppInstallUrl { get; }

        // +(NSString *)getWeiboAppSupportMaxSDKVersion __attribute__((deprecated("")));
        [Static]
        [Export ("getWeiboAppSupportMaxSDKVersion")]
        string WeiboAppSupportMaxSDKVersion { get; }

        // +(NSString *)getSDKVersion;
        [Static]
        [Export ("getSDKVersion")]
        string SDKVersion { get; }

        // +(NSString *)getWeiboAid;
        [Static]
        [Export ("getWeiboAid")]
        string WeiboAid { get; }

        // +(BOOL)registerApp:(NSString *)appKey;
        [Static]
        [Export ("registerApp:")]
        bool RegisterApp (string appKey);

        // +(BOOL)handleOpenURL:(NSURL *)url delegate:(id<WeiboSDKDelegate>)delegate;
        [Static]
        [Export ("handleOpenURL:delegate:")]
        bool HandleOpenURL (NSUrl url, WeiboSDKDelegate @delegate);

        // +(BOOL)sendRequest:(WBBaseRequest *)request;
        [Static]
        [Export ("sendRequest:")]
        bool SendRequest (WBBaseRequest request);

        // +(BOOL)sendResponse:(WBBaseResponse *)response;
        [Static]
        [Export ("sendResponse:")]
        bool SendResponse (WBBaseResponse response);

        // +(void)enableDebugMode:(BOOL)enabled;
        [Static]
        [Export ("enableDebugMode:")]
        void EnableDebugMode (bool enabled);

        // +(void)logOutWithToken:(NSString *)token delegate:(id<WBHttpRequestDelegate>)delegate withTag:(NSString *)tag;
        [Static]
        [Export ("logOutWithToken:delegate:withTag:")]
        void LogOutWithToken (string token, WBHttpRequestDelegate @delegate, string tag);

        // +(void)inviteFriend:(NSString *)data withUid:(NSString *)uid withToken:(NSString *)access_token delegate:(id<WBHttpRequestDelegate>)delegate withTag:(NSString *)tag;
        [Static]
        [Export ("inviteFriend:withUid:withToken:delegate:withTag:")]
        void InviteFriend (string data, string uid, string access_token, WBHttpRequestDelegate @delegate, string tag);

        // +(void)messageRegister:(NSString *)navTitle;
        [Static]
        [Export ("messageRegister:")]
        void MessageRegister (string navTitle);
    }

    partial interface Constants
    {
        // extern NSString *const WeiboSDKGetAidSucessNotification;
        [Field ("WeiboSDKGetAidSucessNotification", "__Internal")]
        NSString WeiboSDKGetAidSucessNotification { get; }

        // extern NSString *const WeiboSDKGetAidFailNotification;
        [Field ("WeiboSDKGetAidFailNotification", "__Internal")]
        NSString WeiboSDKGetAidFailNotification { get; }
    }

    // @protocol WeiboSDKDelegate <NSObject>
    [Protocol, Model]
    [BaseType (typeof (NSObject))]
    interface WeiboSDKDelegate
    {
        // @required -(void)didReceiveWeiboRequest:(WBBaseRequest *)request;
        [Abstract]
        [Export ("didReceiveWeiboRequest:")]
        void DidReceiveWeiboRequest (WBBaseRequest request);

        // @required -(void)didReceiveWeiboResponse:(WBBaseResponse *)response;
        [Abstract]
        [Export ("didReceiveWeiboResponse:")]
        void DidReceiveWeiboResponse (WBBaseResponse response);
    }

    // @interface WBDataTransferObject : NSObject
    [BaseType (typeof (NSObject))]
    interface WBDataTransferObject
    {
        // @property (nonatomic, strong) NSDictionary * userInfo;
        [Export ("userInfo", ArgumentSemantic.Strong)]
        NSDictionary UserInfo { get; set; }

        // @property (readonly, nonatomic, strong) NSString * sdkVersion;
        [Export ("sdkVersion", ArgumentSemantic.Strong)]
        string SdkVersion { get; }

        // @property (assign, nonatomic) BOOL shouldOpenWeiboAppInstallPageIfNotInstalled;
        [Export ("shouldOpenWeiboAppInstallPageIfNotInstalled")]
        bool ShouldOpenWeiboAppInstallPageIfNotInstalled { get; set; }
    }

    // @interface WBBaseRequest : WBDataTransferObject
    [BaseType (typeof (WBDataTransferObject))]
    interface WBBaseRequest
    {
        // +(id)request;
        [Static]
        [Export ("request")]
        NSObject Request { get; }
    }

    // @interface WBBaseResponse : WBDataTransferObject
    [BaseType (typeof (WBDataTransferObject))]
    interface WBBaseResponse
    {
        // @property (readonly, nonatomic, strong) NSDictionary * requestUserInfo;
        [Export ("requestUserInfo", ArgumentSemantic.Strong)]
        NSDictionary RequestUserInfo { get; }

        // @property (assign, nonatomic) WeiboSDKResponseStatusCode statusCode;
        [Export ("statusCode", ArgumentSemantic.Assign)]
        WeiboSDKResponseStatusCode StatusCode { get; set; }

        // +(id)response;
        [Static]
        [Export ("response")]
        NSObject Response { get; }
    }

    // @interface WBAuthorizeRequest : WBBaseRequest
    [BaseType (typeof (WBBaseRequest))]
    interface WBAuthorizeRequest
    {
        // @property (nonatomic, strong) NSString * redirectURI;
        [Export ("redirectURI", ArgumentSemantic.Strong)]
        string RedirectURI { get; set; }

        // @property (nonatomic, strong) NSString * scope;
        [Export ("scope", ArgumentSemantic.Strong)]
        string Scope { get; set; }

        // @property (assign, nonatomic) BOOL shouldShowWebViewForAuthIfCannotSSO;
        [Export ("shouldShowWebViewForAuthIfCannotSSO")]
        bool ShouldShowWebViewForAuthIfCannotSSO { get; set; }
    }

    // @interface WBAuthorizeResponse : WBBaseResponse
    [BaseType (typeof (WBBaseResponse))]
    interface WBAuthorizeResponse
    {
        // @property (nonatomic, strong) NSString * userID;
        [Export ("userID", ArgumentSemantic.Strong)]
        string UserID { get; set; }

        // @property (nonatomic, strong) NSString * accessToken;
        [Export ("accessToken", ArgumentSemantic.Strong)]
        string AccessToken { get; set; }

        // @property (nonatomic, strong) NSDate * expirationDate;
        [Export ("expirationDate", ArgumentSemantic.Strong)]
        NSDate ExpirationDate { get; set; }

        // @property (nonatomic, strong) NSString * refreshToken;
        [Export ("refreshToken", ArgumentSemantic.Strong)]
        string RefreshToken { get; set; }
    }

    // @interface WBProvideMessageForWeiboRequest : WBBaseRequest
    [BaseType (typeof (WBBaseRequest))]
    interface WBProvideMessageForWeiboRequest
    {
    }

    // @interface WBProvideMessageForWeiboResponse : WBBaseResponse
    [BaseType (typeof (WBBaseResponse))]
    interface WBProvideMessageForWeiboResponse
    {
        // @property (nonatomic, strong) WBMessageObject * message;
        [Export ("message", ArgumentSemantic.Strong)]
        WBMessageObject Message { get; set; }

        // +(id)responseWithMessage:(WBMessageObject *)message;
        [Static]
        [Export ("responseWithMessage:")]
        NSObject ResponseWithMessage (WBMessageObject message);
    }

    // @interface WBSendMessageToWeiboRequest : WBBaseRequest
    [BaseType (typeof (WBBaseRequest))]
    interface WBSendMessageToWeiboRequest
    {
        // @property (nonatomic, strong) WBMessageObject * message;
        [Export ("message", ArgumentSemantic.Strong)]
        WBMessageObject Message { get; set; }

        // +(id)requestWithMessage:(WBMessageObject *)message;
        [Static]
        [Export ("requestWithMessage:")]
        NSObject RequestWithMessage (WBMessageObject message);

        // +(id)requestWithMessage:(WBMessageObject *)message authInfo:(WBAuthorizeRequest *)authRequest access_token:(NSString *)access_token;
        [Static]
        [Export ("requestWithMessage:authInfo:access_token:")]
        NSObject RequestWithMessage (WBMessageObject message, WBAuthorizeRequest authRequest, string access_token);
    }

    // @interface WBSendMessageToWeiboResponse : WBBaseResponse
    [BaseType (typeof (WBBaseResponse))]
    interface WBSendMessageToWeiboResponse
    {
        // @property (nonatomic, strong) WBAuthorizeResponse * authResponse;
        [Export ("authResponse", ArgumentSemantic.Strong)]
        WBAuthorizeResponse AuthResponse { get; set; }
    }

    // @interface WBShareMessageToContactRequest : WBBaseRequest
    [BaseType (typeof (WBBaseRequest))]
    interface WBShareMessageToContactRequest
    {
        // @property (nonatomic, strong) WBMessageObject * message;
        [Export ("message", ArgumentSemantic.Strong)]
        WBMessageObject Message { get; set; }

        // +(id)requestWithMessage:(WBMessageObject *)message;
        [Static]
        [Export ("requestWithMessage:")]
        NSObject RequestWithMessage (WBMessageObject message);
    }

    // @interface WBShareMessageToContactResponse : WBBaseResponse
    [BaseType (typeof (WBBaseResponse))]
    interface WBShareMessageToContactResponse
    {
        // @property (nonatomic, strong) WBAuthorizeResponse * authResponse;
        [Export ("authResponse", ArgumentSemantic.Strong)]
        WBAuthorizeResponse AuthResponse { get; set; }
    }

    // @interface WBSDKAppRecommendRequest : WBBaseRequest
    [BaseType (typeof (WBBaseRequest))]
    interface WBSDKAppRecommendRequest
    {
        // +(id)requestWithUIDs:(NSArray *)uids access_token:(NSString *)access_token;
        [Static]
        [Export ("requestWithUIDs:access_token:")]
        NSObject RequestWithUIDs (NSObject [] uids, string access_token);

        // @property (nonatomic, strong) NSArray * uids;
        [Export ("uids", ArgumentSemantic.Strong)]
        NSObject [] Uids { get; set; }

        // @property (nonatomic, strong) NSString * access_token;
        [Export ("access_token", ArgumentSemantic.Strong)]
        string Access_token { get; set; }
    }

    // @interface WBSDKAppRecommendResponse : WBBaseResponse
    [BaseType (typeof (WBBaseResponse))]
    interface WBSDKAppRecommendResponse
    {
        // @property (nonatomic, strong) WBAuthorizeResponse * authResponse;
        [Export ("authResponse", ArgumentSemantic.Strong)]
        WBAuthorizeResponse AuthResponse { get; set; }

        // @property (nonatomic, strong) NSString * userID;
        [Export ("userID", ArgumentSemantic.Strong)]
        string UserID { get; set; }

        // @property (nonatomic, strong) NSString * accessToken;
        [Export ("accessToken", ArgumentSemantic.Strong)]
        string AccessToken { get; set; }

        // @property (nonatomic, strong) NSDate * expirationDate;
        [Export ("expirationDate", ArgumentSemantic.Strong)]
        NSDate ExpirationDate { get; set; }

        // @property (nonatomic, strong) NSString * refreshToken;
        [Export ("refreshToken", ArgumentSemantic.Strong)]
        string RefreshToken { get; set; }
    }

    // @interface WBPaymentRequest : WBBaseRequest
    [BaseType (typeof (WBBaseRequest))]
    interface WBPaymentRequest
    {
        // @property (nonatomic, strong) WBOrderObject * order;
        [Export ("order", ArgumentSemantic.Strong)]
        WBOrderObject Order { get; set; }

        // +(id)requestWithOrder:(WBOrderObject *)order;
        [Static]
        [Export ("requestWithOrder:")]
        NSObject RequestWithOrder (WBOrderObject order);
    }

    // @interface WBPaymentResponse : WBBaseResponse
    [BaseType (typeof (WBBaseResponse))]
    interface WBPaymentResponse
    {
        // @property (nonatomic, strong) NSString * payStatusCode;
        [Export ("payStatusCode", ArgumentSemantic.Strong)]
        string PayStatusCode { get; set; }

        // @property (nonatomic, strong) NSString * payStatusMessage;
        [Export ("payStatusMessage", ArgumentSemantic.Strong)]
        string PayStatusMessage { get; set; }
    }

    // @interface WBMessageObject : NSObject
    [BaseType (typeof (NSObject))]
    interface WBMessageObject
    {
        // @property (nonatomic, strong) NSString * text;
        [Export ("text", ArgumentSemantic.Strong)]
        string Text { get; set; }

        // @property (nonatomic, strong) WBImageObject * imageObject;
        [Export ("imageObject", ArgumentSemantic.Strong)]
        WBImageObject ImageObject { get; set; }

        // @property (nonatomic, strong) WBBaseMediaObject * mediaObject;
        [Export ("mediaObject", ArgumentSemantic.Strong)]
        WBBaseMediaObject MediaObject { get; set; }

        // +(id)message;
        [Static]
        [Export ("message")]
        NSObject Message { get; }
    }

    // @interface WBImageObject : NSObject
    [BaseType (typeof (NSObject))]
    interface WBImageObject
    {
        // @property (nonatomic, strong) NSData * imageData;
        [Export ("imageData", ArgumentSemantic.Strong)]
        NSData ImageData { get; set; }

        // +(id)object;
        [Static]
        [Export ("object")]
        NSObject Object { get; }

        // -(UIImage *)image;
        [Export ("image")]
        UIImage Image { get; }
    }

    // @interface WBBaseMediaObject : NSObject
    [BaseType (typeof (NSObject))]
    interface WBBaseMediaObject
    {
        // @property (nonatomic, strong) NSString * objectID;
        [Export ("objectID", ArgumentSemantic.Strong)]
        string ObjectID { get; set; }

        // @property (nonatomic, strong) NSString * title;
        [Export ("title", ArgumentSemantic.Strong)]
        string Title { get; set; }

        // @property (nonatomic, strong) NSString * description;
        [Export ("description", ArgumentSemantic.Strong)]
        string Description { get; set; }

        // @property (nonatomic, strong) NSData * thumbnailData;
        [Export ("thumbnailData", ArgumentSemantic.Strong)]
        NSData ThumbnailData { get; set; }

        // @property (nonatomic, strong) NSString * scheme;
        [Export ("scheme", ArgumentSemantic.Strong)]
        string Scheme { get; set; }

        // +(id)object;
        [Static]
        [Export ("object")]
        NSObject Object { get; }
    }

    // @interface WBVideoObject : WBBaseMediaObject
    [BaseType (typeof (WBBaseMediaObject))]
    interface WBVideoObject
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
    }

    // @interface WBMusicObject : WBBaseMediaObject
    [BaseType (typeof (WBBaseMediaObject))]
    interface WBMusicObject
    {
        // @property (nonatomic, strong) NSString * musicUrl;
        [Export ("musicUrl", ArgumentSemantic.Strong)]
        string MusicUrl { get; set; }

        // @property (nonatomic, strong) NSString * musicLowBandUrl;
        [Export ("musicLowBandUrl", ArgumentSemantic.Strong)]
        string MusicLowBandUrl { get; set; }

        // @property (nonatomic, strong) NSString * musicStreamUrl;
        [Export ("musicStreamUrl", ArgumentSemantic.Strong)]
        string MusicStreamUrl { get; set; }

        // @property (nonatomic, strong) NSString * musicLowBandStreamUrl;
        [Export ("musicLowBandStreamUrl", ArgumentSemantic.Strong)]
        string MusicLowBandStreamUrl { get; set; }
    }

    // @interface WBWebpageObject : WBBaseMediaObject
    [BaseType (typeof (WBBaseMediaObject))]
    interface WBWebpageObject
    {
        // @property (nonatomic, strong) NSString * webpageUrl;
        [Export ("webpageUrl", ArgumentSemantic.Strong)]
        string WebpageUrl { get; set; }
    }

    // @interface WBOrderObject : NSObject
    [BaseType (typeof (NSObject))]
    interface WBOrderObject
    {
        // @property (nonatomic, strong) NSString * orderString;
        [Export ("orderString", ArgumentSemantic.Strong)]
        string OrderString { get; set; }

        // +(id)order;
        [Static]
        [Export ("order")]
        NSObject Order { get; }
    }

    #endregion
}

