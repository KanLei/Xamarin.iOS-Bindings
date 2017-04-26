
namespace UMengMessage
{
    using System;
    using CoreLocation;
    using Foundation;
    using UIKit;

    partial interface Constants
    {
        // extern NSString *const _Nonnull kUMessageAliasTypeSina __attribute__((visibility("default")));
        [Field ("kUMessageAliasTypeSina", "__Internal")]
        NSString kUMessageAliasTypeSina { get; }

        // extern NSString *const _Nonnull kUMessageAliasTypeTencent __attribute__((visibility("default")));
        [Field ("kUMessageAliasTypeTencent", "__Internal")]
        NSString kUMessageAliasTypeTencent { get; }

        // extern NSString *const _Nonnull kUMessageAliasTypeQQ __attribute__((visibility("default")));
        [Field ("kUMessageAliasTypeQQ", "__Internal")]
        NSString kUMessageAliasTypeQQ { get; }

        // extern NSString *const _Nonnull kUMessageAliasTypeWeiXin __attribute__((visibility("default")));
        [Field ("kUMessageAliasTypeWeiXin", "__Internal")]
        NSString kUMessageAliasTypeWeiXin { get; }

        // extern NSString *const _Nonnull kUMessageAliasTypeBaidu __attribute__((visibility("default")));
        [Field ("kUMessageAliasTypeBaidu", "__Internal")]
        NSString kUMessageAliasTypeBaidu { get; }

        // extern NSString *const _Nonnull kUMessageAliasTypeRenRen __attribute__((visibility("default")));
        [Field ("kUMessageAliasTypeRenRen", "__Internal")]
        NSString kUMessageAliasTypeRenRen { get; }

        // extern NSString *const _Nonnull kUMessageAliasTypeKaixin __attribute__((visibility("default")));
        [Field ("kUMessageAliasTypeKaixin", "__Internal")]
        NSString kUMessageAliasTypeKaixin { get; }

        // extern NSString *const _Nonnull kUMessageAliasTypeDouban __attribute__((visibility("default")));
        [Field ("kUMessageAliasTypeDouban", "__Internal")]
        NSString kUMessageAliasTypeDouban { get; }

        // extern NSString *const _Nonnull kUMessageAliasTypeFacebook __attribute__((visibility("default")));
        [Field ("kUMessageAliasTypeFacebook", "__Internal")]
        NSString kUMessageAliasTypeFacebook { get; }

        // extern NSString *const _Nonnull kUMessageAliasTypeTwitter __attribute__((visibility("default")));
        [Field ("kUMessageAliasTypeTwitter", "__Internal")]
        NSString kUMessageAliasTypeTwitter { get; }

        // extern NSString *const _Nonnull kUMessageErrorDomain;
        [Field ("kUMessageErrorDomain", "__Internal")]
        NSString kUMessageErrorDomain { get; }
    }

    // @interface UMessage : NSObject
    [BaseType (typeof (NSObject))]
    interface UMessage
    {
        // +(void)startWithAppkey:(NSString * _Nonnull)appKey launchOptions:(NSDictionary * _Nullable)launchOptions;
        [Static]
        [Export ("startWithAppkey:launchOptions:")]
        void StartWithAppkey (string appKey, [NullAllowed] NSDictionary launchOptions);

        // +(void)startWithAppkey:(NSString * _Nonnull)appKey launchOptions:(NSDictionary * _Nullable)launchOptions httpsenable:(BOOL)value;
        [Static]
        [Export ("startWithAppkey:launchOptions:httpsenable:")]
        void StartWithAppkey (string appKey, [NullAllowed] NSDictionary launchOptions, bool value);

        // +(void)registerForRemoteNotifications;
        [Static]
        [Export ("registerForRemoteNotifications")]
        void RegisterForRemoteNotifications ();

        // +(void)registerForRemoteNotifications:(NSSet<UIUserNotificationCategory *> * _Nullable)categories8;
        [Static]
        [Export ("registerForRemoteNotifications:")]
        void RegisterForRemoteNotifications ([NullAllowed] NSSet<UIUserNotificationCategory> categories8);

        // +(void)registerForRemoteNotifications:(NSSet<UIUserNotificationCategory *> * _Nullable)categories8 withTypesForIos7:(UIRemoteNotificationType)types7 withTypesForIos8:(UIUserNotificationType)types8;
        [Static]
        [Export ("registerForRemoteNotifications:withTypesForIos7:withTypesForIos8:")]
        void RegisterForRemoteNotifications ([NullAllowed] NSSet<UIUserNotificationCategory> categories8, UIRemoteNotificationType types7, UIUserNotificationType types8);

        // +(void)unregisterForRemoteNotifications;
        [Static]
        [Export ("unregisterForRemoteNotifications")]
        void UnregisterForRemoteNotifications ();

        // +(void)registerDeviceToken:(NSData * _Nullable)deviceToken;
        [Static]
        [Export ("registerDeviceToken:")]
        void RegisterDeviceToken ([NullAllowed] NSData deviceToken);

        // +(void)didReceiveRemoteNotification:(NSDictionary * _Nullable)userInfo;
        [Static]
        [Export ("didReceiveRemoteNotification:")]
        void DidReceiveRemoteNotification ([NullAllowed] NSDictionary userInfo);

        // +(void)setLocation:(CLLocation * _Nullable)location;
        [Static]
        [Export ("setLocation:")]
        void SetLocation ([NullAllowed] CLLocation location);

        // +(void)setLogEnabled:(BOOL)value;
        [Static]
        [Export ("setLogEnabled:")]
        void SetLogEnabled (bool value);

        // +(void)setBadgeClear:(BOOL)value;
        [Static]
        [Export ("setBadgeClear:")]
        void SetBadgeClear (bool value);

        // +(void)setAutoAlert:(BOOL)value;
        [Static]
        [Export ("setAutoAlert:")]
        void SetAutoAlert (bool value);

        // +(void)setChannel:(NSString * _Nullable)channel;
        [Static]
        [Export ("setChannel:")]
        void SetChannel ([NullAllowed] string channel);

        // +(void)setUniqueID:(NSString * _Nullable)uniqueId;
        [Static]
        [Export ("setUniqueID:")]
        void SetUniqueID ([NullAllowed] string uniqueId);

        // +(void)sendClickReportForRemoteNotification:(NSDictionary * _Nullable)userInfo;
        [Static]
        [Export ("sendClickReportForRemoteNotification:")]
        void SendClickReportForRemoteNotification ([NullAllowed] NSDictionary userInfo);

        // +(void)getTags:(void (^ _Nullable)(NSSet * _Nonnull, NSInteger, NSError * _Nonnull))handle;
        [Static]
        [Export ("getTags:")]
        void GetTags ([NullAllowed] Action<NSSet, nint, NSError> handle);

        // +(void)addTag:(id _Nullable)tag response:(void (^ _Nullable)(id _Nonnull, NSInteger, NSError * _Nonnull))handle;
        [Static]
        [Export ("addTag:response:")]
        void AddTag ([NullAllowed] NSObject tag, [NullAllowed] Action<NSObject, nint, NSError> handle);

        // +(void)removeTag:(id _Nonnull)tag response:(void (^ _Nullable)(id _Nonnull, NSInteger, NSError * _Nonnull))handle;
        [Static]
        [Export ("removeTag:response:")]
        void RemoveTag (NSObject tag, [NullAllowed] Action<NSObject, nint, NSError> handle);

        // +(void)removeAllTags:(void (^ _Nullable)(id _Nonnull, NSInteger, NSError * _Nonnull))handle;
        [Static]
        [Export ("removeAllTags:")]
        void RemoveAllTags ([NullAllowed] Action<NSObject, nint, NSError> handle);

        // +(void)addAlias:(NSString * _Nonnull)name type:(NSString * _Nonnull)type response:(void (^ _Nullable)(id _Nonnull, NSError * _Nonnull))handle;
        [Static]
        [Export ("addAlias:type:response:")]
        void AddAlias (string name, string type, [NullAllowed] Action<NSObject, NSError> handle);

        // +(void)setAlias:(NSString * _Nonnull)name type:(NSString * _Nonnull)type response:(void (^ _Nullable)(id _Nonnull, NSError * _Nonnull))handle;
        [Static]
        [Export ("setAlias:type:response:")]
        void SetAlias (string name, string type, [NullAllowed] Action<NSObject, NSError> handle);

        // +(void)removeAlias:(NSString * _Nonnull)name type:(NSString * _Nonnull)type response:(void (^ _Nullable)(id _Nonnull, NSError * _Nonnull))handle;
        [Static]
        [Export ("removeAlias:type:response:")]
        void RemoveAlias (string name, string type, [NullAllowed] Action<NSObject, NSError> handle);
    }

}

