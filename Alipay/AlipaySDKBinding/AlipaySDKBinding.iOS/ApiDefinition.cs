using System;
using Foundation;

namespace AlipaySDKBinding.iOS
{
    // @interface APayAuthInfo : NSObject
    [BaseType (typeof(NSObject))]
    interface APayAuthInfo
    {
        // @property (copy, nonatomic) NSString * appID;
        [Export ("appID")]
        string AppID { get; set; }

        // @property (copy, nonatomic) NSString * pid;
        [Export ("pid")]
        string Pid { get; set; }

        // @property (copy, nonatomic) NSString * redirectUri;
        [Export ("redirectUri")]
        string RedirectUri { get; set; }

        // -(id)initWithAppID:(NSString *)appIDStr pid:(NSString *)pidStr redirectUri:(NSString *)uriStr;
        [Export ("initWithAppID:pid:redirectUri:")]
        IntPtr Constructor (string appIDStr, string pidStr, string uriStr);

        // -(NSString *)description;
        [Export ("description")]
        string Description { get; }

        // -(NSString *)wapDescription;
        [Export ("wapDescription")]
        string WapDescription { get; }
    }

    // typedef void (^CompletionBlock)(NSDictionary *);
    delegate void CompletionBlock (NSDictionary arg0);

    // @interface AlipaySDK : NSObject
    [BaseType (typeof(NSObject))]
    interface AlipaySDK
    {
        // +(AlipaySDK *)defaultService;
        [Static]
        [Export ("defaultService")]
        AlipaySDK DefaultService { get; }

        // -(void)payOrder:(NSString *)orderStr fromScheme:(NSString *)schemeStr callback:(CompletionBlock)completionBlock;
        [Export ("payOrder:fromScheme:callback:")]
        void PayOrder (string orderStr, string schemeStr, CompletionBlock completionBlock);

        // -(void)processOrderWithPaymentResult:(NSURL *)resultUrl standbyCallback:(CompletionBlock)completionBlock;
        [Export ("processOrderWithPaymentResult:standbyCallback:")]
        void ProcessOrderWithPaymentResult (NSUrl resultUrl, CompletionBlock completionBlock);

        // -(NSString *)fetchTradeToken;
        [Export ("fetchTradeToken")]
        string FetchTradeToken { get; }

        // -(BOOL)isLogined;
        [Export ("isLogined")]
        bool IsLogined { get; }

        // -(NSString *)currentVersion;
        [Export ("currentVersion")]
        string CurrentVersion { get; }

        // -(NSString *)queryTidFactor:(AlipayTidFactor)factor;
        [Export ("queryTidFactor:")]
        string QueryTidFactor (AlipayTidFactor factor);

        // -(void)setUrl:(NSString *)url;
        [Export ("setUrl:")]
        void SetUrl (string url);

        // -(NSString *)fetchOrderInfoFromH5PayUrl:(NSString *)urlStr;
        [Export ("fetchOrderInfoFromH5PayUrl:")]
        string FetchOrderInfoFromH5PayUrl (string urlStr);

        // -(void)payUrlOrder:(NSString *)orderStr fromScheme:(NSString *)schemeStr callback:(CompletionBlock)completionBlock;
        [Export ("payUrlOrder:fromScheme:callback:")]
        void PayUrlOrder (string orderStr, string schemeStr, CompletionBlock completionBlock);

        // -(void)authWithInfo:(APayAuthInfo *)authInfo callback:(CompletionBlock)completionBlock;
        [Export ("authWithInfo:callback:")]
        void AuthWithInfo (APayAuthInfo authInfo, CompletionBlock completionBlock);

        // -(void)processAuthResult:(NSURL *)resultUrl standbyCallback:(CompletionBlock)completionBlock;
        [Export ("processAuthResult:standbyCallback:")]
        void ProcessAuthResult (NSUrl resultUrl, CompletionBlock completionBlock);

        // -(void)auth_V2WithInfo:(NSString *)infoStr fromScheme:(NSString *)schemeStr callback:(CompletionBlock)completionBlock;
        [Export ("auth_V2WithInfo:fromScheme:callback:")]
        void Auth_V2WithInfo (string infoStr, string schemeStr, CompletionBlock completionBlock);

        // -(void)processAuth_V2Result:(NSURL *)resultUrl standbyCallback:(CompletionBlock)completionBlock;
        [Export ("processAuth_V2Result:standbyCallback:")]
        void ProcessAuth_V2Result (NSUrl resultUrl, CompletionBlock completionBlock);
    }
}

