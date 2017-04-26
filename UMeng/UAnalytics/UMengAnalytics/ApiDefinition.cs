using System;
using CoreLocation;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace UMengAnalytics
{
    // typedef void (^CallbackBlock)();
    delegate void CallbackBlock ();

    // @interface UMAnalyticsConfig : NSObject
    [BaseType (typeof (NSObject))]
    interface UMAnalyticsConfig
    {
        // @property (copy, nonatomic) NSString * appKey;
        [Export ("appKey")]
        string AppKey { get; set; }

        // @property (copy, nonatomic) NSString * secret;
        [Export ("secret")]
        string Secret { get; set; }

        // @property (copy, nonatomic) NSString * channelId;
        [Export ("channelId")]
        string ChannelId { get; set; }

        // @property (nonatomic) BOOL bCrashReportEnabled;
        [Export ("bCrashReportEnabled")]
        bool BCrashReportEnabled { get; set; }

        // @property (nonatomic) ReportPolicy ePolicy;
        [Export ("ePolicy", ArgumentSemantic.Assign)]
        ReportPolicy EPolicy { get; set; }

        // @property (nonatomic) eScenarioType eSType;
        [Export ("eSType", ArgumentSemantic.Assign)]
        eScenarioType ESType { get; set; }

        // +(instancetype)sharedInstance;
        [Static]
        [Export ("sharedInstance")]
        UMAnalyticsConfig SharedInstance ();
    }

    // @interface MobClick : NSObject <UIAlertViewDelegate>
    [BaseType (typeof (NSObject))]
    interface MobClick : IUIAlertViewDelegate
    {
        // +(void)startWithConfigure:(UMAnalyticsConfig *)configure;
        [Static]
        [Export ("startWithConfigure:")]
        void StartWithConfigure (UMAnalyticsConfig configure);

        // +(void)setAppVersion:(NSString *)appVersion;
        [Static]
        [Export ("setAppVersion:")]
        void SetAppVersion (string appVersion);

        // +(void)setCrashReportEnabled:(BOOL)value;
        [Static]
        [Export ("setCrashReportEnabled:")]
        void SetCrashReportEnabled (bool value);

        // +(void)setLogEnabled:(BOOL)value;
        [Static]
        [Export ("setLogEnabled:")]
        void SetLogEnabled (bool value);

        // +(void)setBackgroundTaskEnabled:(BOOL)value;
        [Static]
        [Export ("setBackgroundTaskEnabled:")]
        void SetBackgroundTaskEnabled (bool value);

        // +(void)setEncryptEnabled:(BOOL)value;
        [Static]
        [Export ("setEncryptEnabled:")]
        void SetEncryptEnabled (bool value);

        // +(void)setLogSendInterval:(double)second;
        [Static]
        [Export ("setLogSendInterval:")]
        void SetLogSendInterval (double second);

        // +(void)logPageView:(NSString *)pageName seconds:(int)seconds;
        [Static]
        [Export ("logPageView:seconds:")]
        void LogPageView (string pageName, int seconds);

        // +(void)beginLogPageView:(NSString *)pageName;
        [Static]
        [Export ("beginLogPageView:")]
        void BeginLogPageView (string pageName);

        // +(void)endLogPageView:(NSString *)pageName;
        [Static]
        [Export ("endLogPageView:")]
        void EndLogPageView (string pageName);

        // +(void)event:(NSArray *)keyPath value:(int)value label:(NSString *)label;
        [Static]
        [Export ("event:value:label:")]
        void Event (NSObject [] keyPath, int value, string label);

        // +(void)event:(NSString *)eventId;
        [Static]
        [Export ("event:")]
        void Event (string eventId);

        // +(void)event:(NSString *)eventId label:(NSString *)label;
        [Static]
        [Export ("event:label:")]
        void Event (string eventId, string label);

        // +(void)event:(NSString *)eventId attributes:(NSDictionary *)attributes;
        [Static]
        [Export ("event:attributes:")]
        void Event (string eventId, NSDictionary attributes);

        // +(void)event:(NSString *)eventId attributes:(NSDictionary *)attributes counter:(int)number;
        [Static]
        [Export ("event:attributes:counter:")]
        void Event (string eventId, NSDictionary attributes, int number);

        // +(void)beginEvent:(NSString *)eventId;
        [Static]
        [Export ("beginEvent:")]
        void BeginEvent (string eventId);

        // +(void)endEvent:(NSString *)eventId;
        [Static]
        [Export ("endEvent:")]
        void EndEvent (string eventId);

        // +(void)beginEvent:(NSString *)eventId label:(NSString *)label;
        [Static]
        [Export ("beginEvent:label:")]
        void BeginEvent (string eventId, string label);

        // +(void)endEvent:(NSString *)eventId label:(NSString *)label;
        [Static]
        [Export ("endEvent:label:")]
        void EndEvent (string eventId, string label);

        // +(void)beginEvent:(NSString *)eventId primarykey:(NSString *)keyName attributes:(NSDictionary *)attributes;
        [Static]
        [Export ("beginEvent:primarykey:attributes:")]
        void BeginEvent (string eventId, string keyName, NSDictionary attributes);

        // +(void)endEvent:(NSString *)eventId primarykey:(NSString *)keyName;
        [Static]
        [Export ("endEvent:primarykey:")]
        void EndEventWithPrimaryKey (string eventId, string keyName);

        // +(void)event:(NSString *)eventId durations:(int)millisecond;
        [Static]
        [Export ("event:durations:")]
        void Event (string eventId, int millisecond);

        // +(void)event:(NSString *)eventId label:(NSString *)label durations:(int)millisecond;
        [Static]
        [Export ("event:label:durations:")]
        void Event (string eventId, string label, int millisecond);

        // +(void)event:(NSString *)eventId attributes:(NSDictionary *)attributes durations:(int)millisecond;
        [Static]
        [Export ("event:attributes:durations:")]
        void EventWithAttributes (string eventId, NSDictionary attributes, int millisecond);

        // +(void)profileSignInWithPUID:(NSString *)puid;
        [Static]
        [Export ("profileSignInWithPUID:")]
        void ProfileSignInWithPUID (string puid);

        // +(void)profileSignInWithPUID:(NSString *)puid provider:(NSString *)provider;
        [Static]
        [Export ("profileSignInWithPUID:provider:")]
        void ProfileSignInWithPUID (string puid, string provider);

        // +(void)profileSignOff;
        [Static]
        [Export ("profileSignOff")]
        void ProfileSignOff ();

        // +(void)setLatitude:(double)latitude longitude:(double)longitude;
        [Static]
        [Export ("setLatitude:longitude:")]
        void SetLatitude (double latitude, double longitude);

        // +(void)setLocation:(CLLocation *)location;
        [Static]
        [Export ("setLocation:")]
        void SetLocation (CLLocation location);

        // +(BOOL)isJailbroken;
        [Static]
        [Export ("isJailbroken")]
        bool IsJailbroken { get; }

        // +(BOOL)isPirated;
        [Static]
        [Export ("isPirated")]
        bool IsPirated { get; }

        // +(void)startSession:(NSNotification *)notification;
        [Static]
        [Export ("startSession:")]
        void StartSession (NSNotification notification);

        // +(void)setCrashCBBlock:(CallbackBlock)cbBlock;
        [Static]
        [Export ("setCrashCBBlock:")]
        void SetCrashCBBlock (CallbackBlock cbBlock);
    }


    // @interface MobClickGameAnalytics : NSObject
    [BaseType (typeof (NSObject))]
    interface MobClickGameAnalytics
    {
        // +(void)profileSignInWithPUID:(NSString *)puid;
        [Static]
        [Export ("profileSignInWithPUID:")]
        void ProfileSignInWithPUID (string puid);

        // +(void)profileSignInWithPUID:(NSString *)puid provider:(NSString *)provider;
        [Static]
        [Export ("profileSignInWithPUID:provider:")]
        void ProfileSignInWithPUID (string puid, string provider);

        // +(void)profileSignOff;
        [Static]
        [Export ("profileSignOff")]
        void ProfileSignOff ();

        // +(void)setUserLevelId:(int)level;
        [Static]
        [Export ("setUserLevelId:")]
        void SetUserLevelId (int level);

        // +(void)startLevel:(NSString *)level;
        [Static]
        [Export ("startLevel:")]
        void StartLevel (string level);

        // +(void)finishLevel:(NSString *)level;
        [Static]
        [Export ("finishLevel:")]
        void FinishLevel (string level);

        // +(void)failLevel:(NSString *)level;
        [Static]
        [Export ("failLevel:")]
        void FailLevel (string level);

        // +(void)exchange:(NSString *)orderId currencyAmount:(double)currencyAmount currencyType:(NSString *)currencyType virtualCurrencyAmount:(double)virtualAmount paychannel:(int)channel;
        [Static]
        [Export ("exchange:currencyAmount:currencyType:virtualCurrencyAmount:paychannel:")]
        void Exchange (string orderId, double currencyAmount, string currencyType, double virtualAmount, int channel);

        // +(void)pay:(double)cash source:(int)source coin:(double)coin;
        [Static]
        [Export ("pay:source:coin:")]
        void Pay (double cash, int source, double coin);

        // +(void)pay:(double)cash source:(int)source item:(NSString *)item amount:(int)amount price:(double)price;
        [Static]
        [Export ("pay:source:item:amount:price:")]
        void Pay (double cash, int source, string item, int amount, double price);

        // +(void)buy:(NSString *)item amount:(int)amount price:(double)price;
        [Static]
        [Export ("buy:amount:price:")]
        void Buy (string item, int amount, double price);

        // +(void)use:(NSString *)item amount:(int)amount price:(double)price;
        [Static]
        [Export ("use:amount:price:")]
        void Use (string item, int amount, double price);

        // +(void)bonus:(double)coin source:(int)source;
        [Static]
        [Export ("bonus:source:")]
        void Bonus (double coin, int source);

        // +(void)bonus:(NSString *)item amount:(int)amount price:(double)price source:(int)source;
        [Static]
        [Export ("bonus:amount:price:source:")]
        void Bonus (string item, int amount, double price, int source);

        // +(void)setUserLevel:(NSString *)level;
        [Static]
        [Export ("setUserLevel:")]
        void SetUserLevel (string level);

        // +(void)setUserID:(NSString *)userId sex:(int)sex age:(int)age platform:(NSString *)platform;
        [Static]
        [Export ("setUserID:sex:age:platform:")]
        void SetUserID (string userId, int sex, int age, string platform);
    }

    [Static]
    partial interface Constants
    {
        // extern const MobClickSocialTypeString MobClickSocialTypeSina;
        [Field ("MobClickSocialTypeSina", "__Internal")]
        NSString MobClickSocialTypeSina { get; }

        // extern const MobClickSocialTypeString MobClickSocialTypeTencent;
        [Field ("MobClickSocialTypeTencent", "__Internal")]
        NSString MobClickSocialTypeTencent { get; }

        // extern const MobClickSocialTypeString MobClickSocialTypeRenren;
        [Field ("MobClickSocialTypeRenren", "__Internal")]
        NSString MobClickSocialTypeRenren { get; }

        // extern const MobClickSocialTypeString MobClickSocialTypeQzone;
        [Field ("MobClickSocialTypeQzone", "__Internal")]
        NSString MobClickSocialTypeQzone { get; }

        // extern const MobClickSocialTypeString MobClickSocialTypeDouban;
        [Field ("MobClickSocialTypeDouban", "__Internal")]
        NSString MobClickSocialTypeDouban { get; }

        // extern const MobClickSocialTypeString MobClickSocialTypeWxsesion;
        [Field ("MobClickSocialTypeWxsesion", "__Internal")]
        NSString MobClickSocialTypeWxsesion { get; }

        // extern const MobClickSocialTypeString MobClickSocialTypeWxtimeline;
        [Field ("MobClickSocialTypeWxtimeline", "__Internal")]
        NSString MobClickSocialTypeWxtimeline { get; }

        // extern const MobClickSocialTypeString MobClickSocialTypeHuaban;
        [Field ("MobClickSocialTypeHuaban", "__Internal")]
        NSString MobClickSocialTypeHuaban { get; }

        // extern const MobClickSocialTypeString MobClickSocialTypeKaixin;
        [Field ("MobClickSocialTypeKaixin", "__Internal")]
        NSString MobClickSocialTypeKaixin { get; }

        // extern const MobClickSocialTypeString MobClickSocialTypeFacebook;
        [Field ("MobClickSocialTypeFacebook", "__Internal")]
        NSString MobClickSocialTypeFacebook { get; }

        // extern const MobClickSocialTypeString MobClickSocialTypeTwitter;
        [Field ("MobClickSocialTypeTwitter", "__Internal")]
        NSString MobClickSocialTypeTwitter { get; }

        // extern const MobClickSocialTypeString MobClickSocialTypeInstagram;
        [Field ("MobClickSocialTypeInstagram", "__Internal")]
        NSString MobClickSocialTypeInstagram { get; }

        // extern const MobClickSocialTypeString MobClickSocialTypeFlickr;
        [Field ("MobClickSocialTypeFlickr", "__Internal")]
        NSString MobClickSocialTypeFlickr { get; }

        // extern const MobClickSocialTypeString MobClickSocialTypeQQ;
        [Field ("MobClickSocialTypeQQ", "__Internal")]
        NSString MobClickSocialTypeQQ { get; }

        // extern const MobClickSocialTypeString MobClickSocialTypeWxfavorite;
        [Field ("MobClickSocialTypeWxfavorite", "__Internal")]
        NSString MobClickSocialTypeWxfavorite { get; }

        // extern const MobClickSocialTypeString MobClickSocialTypeLwsession;
        [Field ("MobClickSocialTypeLwsession", "__Internal")]
        NSString MobClickSocialTypeLwsession { get; }

        // extern const MobClickSocialTypeString MobClickSocialTypeLwtimeline;
        [Field ("MobClickSocialTypeLwtimeline", "__Internal")]
        NSString MobClickSocialTypeLwtimeline { get; }

        // extern const MobClickSocialTypeString MobClickSocialTypeYxsession;
        [Field ("MobClickSocialTypeYxsession", "__Internal")]
        NSString MobClickSocialTypeYxsession { get; }

        // extern const MobClickSocialTypeString MobClickSocialTypeYxtimeline;
        [Field ("MobClickSocialTypeYxtimeline", "__Internal")]
        NSString MobClickSocialTypeYxtimeline { get; }
    }


    // @interface MobClickSocialWeibo : NSObject
    [BaseType (typeof (NSObject))]
    interface MobClickSocialWeibo
    {
        // @property (copy, nonatomic) NSString * platformType;
        [Export ("platformType")]
        string PlatformType { get; set; }

        // @property (copy, nonatomic) NSString * weiboId;
        [Export ("weiboId")]
        string WeiboId { get; set; }

        // @property (copy, nonatomic) NSString * userId;
        [Export ("userId")]
        string UserId { get; set; }

        // @property (nonatomic, strong) NSDictionary * param;
        [Export ("param", ArgumentSemantic.Strong)]
        NSDictionary Param { get; set; }

        // -(id)initWithPlatformType:(MobClickSocialTypeString)platformType weiboId:(NSString *)weiboId usid:(NSString *)usid param:(NSDictionary *)param;
        [Export ("initWithPlatformType:weiboId:usid:param:")]
        IntPtr Constructor (string platformType, string weiboId, string usid, NSDictionary param);
    }

    // typedef void (^MobClickSocialAnalyticsCompletion)(NSDictionary *, NSError *);
    delegate void MobClickSocialAnalyticsCompletion (NSDictionary arg0, NSError arg1);

    // @interface MobClickSocialAnalytics : NSObject
    [BaseType (typeof (NSObject))]
    interface MobClickSocialAnalytics
    {
        // +(void)postWeiboCounts:(NSArray *)weibos appKey:(NSString *)appKey topic:(NSString *)topic completion:(MobClickSocialAnalyticsCompletion)completion;
        [Static]
        [Export ("postWeiboCounts:appKey:topic:completion:")]
        void PostWeiboCounts (NSObject [] weibos, string appKey, string topic, MobClickSocialAnalyticsCompletion completion);
    }

}

