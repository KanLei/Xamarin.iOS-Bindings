using System;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace ALITrade.iOS
{
    // @protocol ALiHintProtocol <NSObject>
    [Protocol, Model]
    [BaseType (typeof (NSObject))]
    interface ALiHintProtocol
    {
        // @required -(NSArray<NSString *> *)getHintList:(NSString *)bizID;
        [Abstract]
        [Export ("getHintList:")]
        string [] GetHintList (string bizID);

        // @required -(void)reportHintLost:(NSString *)bizID hintId:(NSString *)hintId;
        [Abstract]
        [Export ("reportHintLost:hintId:")]
        void ReportHintLost (string bizID, string hintId);
    }

    // @interface ALiAuthService : NSObject
    [BaseType (typeof (NSObject))]
    interface ALiAuthService
    {
        // +(instancetype _Nonnull)sharedInstantce;
        [Static]
        [Export ("sharedInstantce")]
        ALiAuthService SharedInstantce ();

        // -(void)installHintService:(id<ALiHintProtocol> _Nonnull)hint;
        [Export ("installHintService:")]
        void InstallHintService (ALiHintProtocol hint);
    }

    // @interface ALiHybridContext : NSObject
    [BaseType (typeof (NSObject))]
    interface ALiHybridContext
    {
        // @property (nonatomic, weak) UIViewController * vc;
        [Export ("vc", ArgumentSemantic.Weak)]
        UIViewController Vc { get; set; }

        // @property (nonatomic, weak) UIWebView * webView;
        [Export ("webView", ArgumentSemantic.Weak)]
        UIWebView WebView { get; set; }

        // -(instancetype)initWithVC:(UIViewController *)vc webView:(UIWebView *)webView requestId:(NSString *)requestId;
        [Export ("initWithVC:webView:requestId:")]
        IntPtr Constructor (UIViewController vc, UIWebView webView, string requestId);

        // -(void)fireSuccess:(NSDictionary *)returnData;
        [Export ("fireSuccess:")]
        void FireSuccess (NSDictionary returnData);

        // -(void)fireFail:(NSString *)code;
        [Export ("fireFail:")]
        void FireFail (string code);

        // -(void)fireFail:(NSString *)code msg:(NSString *)msg;
        [Export ("fireFail:msg:")]
        void FireFail (string code, string msg);

        // -(void)fireFail:(NSString *)code msg:(NSString *)msg data:(NSDictionary *)returnData;
        [Export ("fireFail:msg:data:")]
        void FireFail (string code, string msg, NSDictionary returnData);

        // -(void)fireEvent:(NSString *)eventId data:(NSDictionary *)returnData;
        [Export ("fireEvent:data:")]
        void FireEvent (string eventId, NSDictionary returnData);

        // -(NSString *)stringByEvaluatingJavaScriptFromString:(NSString *)script;
        [Export ("stringByEvaluatingJavaScriptFromString:")]
        string StringByEvaluatingJavaScriptFromString (string script);
    }

    // @interface ALiJSON : NSObject
    [BaseType (typeof (NSObject))]
    interface ALiJSON
    {
        // +(id)jsonDataToObject:(NSData *)jsonData class:(Class)clazz;
        [Static]
        [Export ("jsonDataToObject:class:")]
        NSObject JsonDataToObject (NSData jsonData, Class clazz);

        // +(NSDictionary *)jsonDataToDictionary:(NSData *)jsonData;
        [Static]
        [Export ("jsonDataToDictionary:")]
        NSDictionary JsonDataToDictionary (NSData jsonData);

        // +(NSArray *)jsonDataToArray:(NSData *)jsonData;
        [Static]
        [Export ("jsonDataToArray:")]
        NSObject [] JsonDataToArray (NSData jsonData);

        // +(NSData *)objectToJsonData:(id)object;
        [Static]
        [Export ("objectToJsonData:")]
        NSData ObjectToJsonData (NSObject @object);

        // +(id)jsonStringToObject:(NSString *)jsonString class:(Class)clazz;
        [Static]
        [Export ("jsonStringToObject:class:")]
        NSObject JsonStringToObject (string jsonString, Class clazz);

        // +(NSDictionary *)jsonStringToDictionary:(NSString *)jsonString;
        [Static]
        [Export ("jsonStringToDictionary:")]
        NSDictionary JsonStringToDictionary (string jsonString);

        // +(NSArray *)jsonStringToArray:(NSString *)jsonString;
        [Static]
        [Export ("jsonStringToArray:")]
        NSObject [] JsonStringToArray (string jsonString);

        // +(NSString *)objectToJsonString:(id)object;
        [Static]
        [Export ("objectToJsonString:")]
        string ObjectToJsonString (NSObject @object);

        // +(id)dictionaryToClass:(NSDictionary *)dictionary class:(Class)clazz;
        [Static]
        [Export ("dictionaryToClass:class:")]
        NSObject DictionaryToClass (NSDictionary dictionary, Class clazz);

        // +(id)asJsonableObject:(id)object;
        [Static]
        [Export ("asJsonableObject:")]
        NSObject AsJsonableObject (NSObject @object);

        // +(NSString *)fixJSON2JSBug:(NSString *)json;
        [Static]
        [Export ("fixJSON2JSBug:")]
        string FixJSON2JSBug (string json);
    }

    // @interface ALiLog : NSObject
    [BaseType (typeof (NSObject))]
    interface ALiLog
    {
        // +(instancetype)GetInstance;
        [Static]
        [Export ("GetInstance")]
        ALiLog GetInstance ();

        // -(NSString *)getLogFilePath;
        [Export ("getLogFilePath")]
        string LogFilePath { get; }

        //// -(void)showAssertAlert:(const char *)file funcName:(const char *)func line:(int)line msg:(NSString *)msg;
        //[Export ("showAssertAlert:funcName:line:msg:")]
        //unsafe void ShowAssertAlert (sbyte* file, sbyte* func, int line, string msg);

        //// -(void)logDebugMsg:(const char *)file funcName:(const char *)func line:(int)line msg:(NSString *)msg;
        //[Export ("logDebugMsg:funcName:line:msg:")]
        //unsafe void LogDebugMsg (sbyte* file, sbyte* func, int line, string msg);

        //// -(void)logInfoMsg:(const char *)file funcName:(const char *)func line:(int)line msg:(NSString *)msg;
        //[Export ("logInfoMsg:funcName:line:msg:")]
        //unsafe void LogInfoMsg (sbyte* file, sbyte* func, int line, string msg);

        //// -(void)logWarnMsg:(const char *)file funcName:(const char *)func line:(int)line msg:(NSString *)msg;
        //[Export ("logWarnMsg:funcName:line:msg:")]
        //unsafe void LogWarnMsg (sbyte* file, sbyte* func, int line, string msg);

        //// -(void)logErrorMsg:(const char *)file funcName:(const char *)func line:(int)line msg:(NSString *)msg;
        //[Export ("logErrorMsg:funcName:line:msg:")]
        //unsafe void LogErrorMsg (sbyte* file, sbyte* func, int line, string msg);

        // -(void)setDebugLogOpen:(BOOL)isDebugLogOpen;
        [Export ("setDebugLogOpen:")]
        void SetDebugLogOpen (bool isDebugLogOpen);
    }

    // @interface ALiMonitor : NSObject
    [BaseType (typeof (NSObject))]
    interface ALiMonitor
    {
        // -(NSString *)monitorModule;
        [Export ("monitorModule")]
        string MonitorModule { get; }

        // -(NSString *)monitorPoint;
        [Export ("monitorPoint")]
        string MonitorPoint { get; }

        // -(void)makeDimension:(NSMutableDictionary *)dimensionDic;
        [Export ("makeDimension:")]
        void MakeDimension (NSMutableDictionary dimensionDic);

        // -(void)makeMeasure:(NSMutableDictionary *)measureDic;
        [Export ("makeMeasure:")]
        void MakeMeasure (NSMutableDictionary measureDic);

        // -(void)commit;
        [Export ("commit")]
        void Commit ();

        // @property (nonatomic, strong) NSString * dimension_appkey;
        [Export ("dimension_appkey", ArgumentSemantic.Strong)]
        string Dimension_appkey { get; set; }

        // @property (nonatomic, strong) NSString * dimension_isv_version;
        [Export ("dimension_isv_version", ArgumentSemantic.Strong)]
        string Dimension_isv_version { get; set; }

        // @property (nonatomic, strong) NSString * dimension_nbsdk_version;
        [Export ("dimension_nbsdk_version", ArgumentSemantic.Strong)]
        string Dimension_nbsdk_version { get; set; }

        // @property (nonatomic, strong) NSString * dimension_platform;
        [Export ("dimension_platform", ArgumentSemantic.Strong)]
        string Dimension_platform { get; set; }

        // @property (nonatomic, strong) NSString * appkey;
        [Export ("appkey", ArgumentSemantic.Strong)]
        string Appkey { get; set; }

        // @property (nonatomic, strong) NSString * isv_version;
        [Export ("isv_version", ArgumentSemantic.Strong)]
        string Isv_version { get; set; }

        // @property (nonatomic, strong) NSString * nbsdk_version;
        [Export ("nbsdk_version", ArgumentSemantic.Strong)]
        string Nbsdk_version { get; set; }

        // @property (nonatomic, strong) NSString * platform;
        [Export ("platform", ArgumentSemantic.Strong)]
        string Platform { get; set; }
    }

    // @interface ALiMonitorUtil : NSObject
    [BaseType (typeof (NSObject))]
    interface ALiMonitorUtil
    {
        // +(instancetype)shareInstance;
        [Static]
        [Export ("shareInstance")]
        ALiMonitorUtil ShareInstance ();

        // -(void)registMonitorPoint:(ALiMonitor *)monitor;
        [Export ("registMonitorPoint:")]
        void RegistMonitorPoint (ALiMonitor monitor);

        // -(void)commitSuccessWithModule:(NSString *)module monitorPoint:(NSString *)monitorPoint arg:(NSString *)arg;
        [Export ("commitSuccessWithModule:monitorPoint:arg:")]
        void CommitSuccessWithModule (string module, string monitorPoint, string arg);

        // -(void)commitFailWithModule:(NSString *)module monitorPoint:(NSString *)monitorPoint errorCode:(NSString *)errorCode errorMsg:(NSString *)errorMsg arg:(NSString *)arg;
        [Export ("commitFailWithModule:monitorPoint:errorCode:errorMsg:arg:")]
        void CommitFailWithModule (string module, string monitorPoint, string errorCode, string errorMsg, string arg);

        // -(void)commitWithMonitor:(ALiMonitor *)monitor;
        [Export ("commitWithMonitor:")]
        void CommitWithMonitor (ALiMonitor monitor);

        // -(BOOL)beginTimeMonitor:(NSString *)key;
        [Export ("beginTimeMonitor:")]
        bool BeginTimeMonitor (string key);

        // -(NSString *)endTimeMonitor:(NSString *)key;
        [Export ("endTimeMonitor:")]
        string EndTimeMonitor (string key);

        // -(void)clearAllTimeMonitor;
        [Export ("clearAllTimeMonitor")]
        void ClearAllTimeMonitor ();

        // -(void)clearTimeMonitor:(NSString *)key;
        [Export ("clearTimeMonitor:")]
        void ClearTimeMonitor (string key);
    }

    // @interface ALiMsgBus : NSObject
    [BaseType (typeof (NSObject))]
    interface ALiMsgBus
    {
        // +(instancetype)sharedInstance;
        [Static]
        [Export ("sharedInstance")]
        ALiMsgBus SharedInstance ();

        // -(void)registerNotify:(NSString *)eventID target:(NSObject *)target action:(SEL)action dataType:(Class)dataType mainThread:(BOOL)bMain type:(MsgBusItemType)type;
        [Export ("registerNotify:target:action:dataType:mainThread:type:")]
        void RegisterNotify (string eventID, NSObject target, Selector action, Class dataType, bool bMain, MsgBusItemType type);

        // -(void)registerNotify:(NSString *)eventID target:(NSObject *)target action:(SEL)action dataType:(Class)dataType1 dataType:(Class)dataType2 mainThread:(BOOL)bMain type:(MsgBusItemType)type;
        [Export ("registerNotify:target:action:dataType:dataType:mainThread:type:")]
        void RegisterNotify (string eventID, NSObject target, Selector action, Class dataType1, Class dataType2, bool bMain, MsgBusItemType type);

        // -(void)registerNotify:(NSString *)eventID target:(NSObject *)target action:(SEL)action dataType:(Class)dataType1 dataType:(Class)dataType2 dataType:(Class)dataType3 mainThread:(BOOL)bMain type:(MsgBusItemType)type;
        [Export ("registerNotify:target:action:dataType:dataType:dataType:mainThread:type:")]
        void RegisterNotify (string eventID, NSObject target, Selector action, Class dataType1, Class dataType2, Class dataType3, bool bMain, MsgBusItemType type);

        // -(void)unregisterEventNotifyByTarget:(NSString *)eventID target:(NSObject *)target;
        [Export ("unregisterEventNotifyByTarget:target:")]
        void UnregisterEventNotifyByTarget (string eventID, NSObject target);

        // -(BOOL)fireEventNotify:(NSString *)eventID data:(id)data;
        [Export ("fireEventNotify:data:")]
        bool FireEventNotify (string eventID, NSObject data);

        // -(BOOL)fireEventNotify:(NSString *)eventID data1:(id)data1 data2:(id)data2;
        [Export ("fireEventNotify:data1:data2:")]
        bool FireEventNotify (string eventID, NSObject data1, NSObject data2);

        // -(BOOL)fireEventNotify:(NSString *)eventID data1:(id)data1 data2:(id)data2 data3:(id)data3;
        [Export ("fireEventNotify:data1:data2:data3:")]
        bool FireEventNotify (string eventID, NSObject data1, NSObject data2, NSObject data3);
    }

    // @protocol AMPMsgBusHelpProtocol <NSObject>
    [Protocol, Model]
    [BaseType (typeof (NSObject))]
    interface AMPMsgBusHelpProtocol
    {
        // @required -(void)registerEventFilter:(NSString * _Nonnull)eventID action:(SEL _Nonnull)action dataClass:(Class _Nonnull)dataClass;
        [Abstract]
        [Export ("registerEventFilter:action:dataClass:")]
        void RegisterEventFilter (string eventID, Selector action, Class dataClass);

        // @required -(void)registerEventFilter:(NSString * _Nonnull)eventID action:(SEL _Nonnull)action dataClass1:(Class _Nonnull)dataClass1 dataClass2:(Class _Nonnull)dataClass2;
        [Abstract]
        [Export ("registerEventFilter:action:dataClass1:dataClass2:")]
        void RegisterEventFilter (string eventID, Selector action, Class dataClass1, Class dataClass2);

        // @required -(void)registerEventFilter:(NSString * _Nonnull)eventID action:(SEL _Nonnull)action dataClass1:(Class _Nonnull)dataClass1 dataClass2:(Class _Nonnull)dataClass2 dataClass3:(Class _Nonnull)dataClass3;
        [Abstract]
        [Export ("registerEventFilter:action:dataClass1:dataClass2:dataClass3:")]
        void RegisterEventFilter (string eventID, Selector action, Class dataClass1, Class dataClass2, Class dataClass3);

        // @required -(void)registerEventTopNotify:(NSString * _Nonnull)eventID action:(SEL _Nonnull)action dataClass:(Class _Nonnull)dataClass;
        [Abstract]
        [Export ("registerEventTopNotify:action:dataClass:")]
        void RegisterEventTopNotify (string eventID, Selector action, Class dataClass);

        // @required -(void)registerEventTopNotify:(NSString * _Nonnull)eventID action:(SEL _Nonnull)action dataClass1:(Class _Nonnull)dataClass1 dataClass2:(Class _Nonnull)dataClass2;
        [Abstract]
        [Export ("registerEventTopNotify:action:dataClass1:dataClass2:")]
        void RegisterEventTopNotify (string eventID, Selector action, Class dataClass1, Class dataClass2);

        // @required -(void)registerEventTopNotify:(NSString * _Nonnull)eventID action:(SEL _Nonnull)action dataClass1:(Class _Nonnull)dataClass1 dataClass2:(Class _Nonnull)dataClass2 dataClass3:(Class _Nonnull)dataClass3;
        [Abstract]
        [Export ("registerEventTopNotify:action:dataClass1:dataClass2:dataClass3:")]
        void RegisterEventTopNotify (string eventID, Selector action, Class dataClass1, Class dataClass2, Class dataClass3);

        // @required -(void)registerEventNotify:(NSString * _Nonnull)eventID action:(SEL _Nonnull)action dataClass:(Class _Nonnull)dataClass;
        [Abstract]
        [Export ("registerEventNotify:action:dataClass:")]
        void RegisterEventNotify (string eventID, Selector action, Class dataClass);

        // @required -(void)registerEventNotify:(NSString * _Nonnull)eventID action:(SEL _Nonnull)action dataClass1:(Class _Nonnull)dataClass1 dataClass2:(Class _Nonnull)dataClass2;
        [Abstract]
        [Export ("registerEventNotify:action:dataClass1:dataClass2:")]
        void RegisterEventNotify (string eventID, Selector action, Class dataClass1, Class dataClass2);

        // @required -(void)registerEventNotify:(NSString * _Nonnull)eventID action:(SEL _Nonnull)action dataClass1:(Class _Nonnull)dataClass1 dataClass2:(Class _Nonnull)dataClass2 dataClass3:(Class _Nonnull)dataClass3;
        [Abstract]
        [Export ("registerEventNotify:action:dataClass1:dataClass2:dataClass3:")]
        void RegisterEventNotify (string eventID, Selector action, Class dataClass1, Class dataClass2, Class dataClass3);
    }

    interface IAMPMsgBusHelpProtocol { }

    // @interface ALiMsgBusHelp : NSObject <AMPMsgBusHelpProtocol>
    [BaseType (typeof (NSObject))]
    interface ALiMsgBusHelp : IAMPMsgBusHelpProtocol
    {
    }

    // @interface ALiMsgBusUIHelp : UIViewController <AMPMsgBusHelpProtocol>
    [BaseType (typeof (UIViewController))]
    interface ALiMsgBusUIHelp : IAMPMsgBusHelpProtocol
    {
    }

    // @interface ALiMtopCmd : NSObject
    [BaseType (typeof (NSObject))]
    interface ALiMtopCmd
    {
        // @property (nonatomic, strong) NSString * _Nonnull name;
        [Export ("name", ArgumentSemantic.Strong)]
        string Name { get; set; }

        // @property (nonatomic, strong) NSString * _Nonnull version;
        [Export ("version", ArgumentSemantic.Strong)]
        string Version { get; set; }

        // @property (assign, nonatomic) BOOL needLogin;
        [Export ("needLogin")]
        bool NeedLogin { get; set; }

        // @property (assign, nonatomic) BOOL needAuth;
        [Export ("needAuth")]
        bool NeedAuth { get; set; }

        // @property (assign, nonatomic) BOOL needWUA;
        [Export ("needWUA")]
        bool NeedWUA { get; set; }

        // +(instancetype _Nonnull)cmd;
        [Static]
        [Export ("cmd")]
        ALiMtopCmd Cmd ();
    }

    // @interface AlibcTradeSDK : NSObject
    [BaseType (typeof (NSObject))]
    interface AlibcTradeSDK
    {
        // +(instancetype)sharedInstance;
        [Static]
        [Export ("sharedInstance")]
        AlibcTradeSDK SharedInstance ();

        // -(void)asyncInitWithSuccess:(void (^)())onSuccess failure:(void (^)(NSError *))onFailure;
        [Export ("asyncInitWithSuccess:failure:")]
        void AsyncInitWithSuccess (Action onSuccess, Action<NSError> onFailure);

        // -(id)tradeService;
        [Export ("tradeService")]
        IAlibcTradeService TradeService { get; }

        // -(BOOL)handleOpenURL:(NSURL *)url;
        [Export ("handleOpenURL:")]
        bool HandleOpenURL (NSUrl url);
    }

    // @interface Settings (AlibcTradeSDK)
    [Category]
    [BaseType (typeof (AlibcTradeSDK))]
    interface AlibcTradeSDK_Settings
    {
        // -(void)setDebugLogOpen:(BOOL)isDebugLogOpen;
        [Export ("setDebugLogOpen:")]
        void SetDebugLogOpen (bool isDebugLogOpen);

        // -(void)setEnv:(ALiEnvironment)env;
        [Export ("setEnv:")]
        void SetEnv (ALiEnvironment env);

        // -(ALiEnvironment)getEnv;
        [Export ("getEnv")]
        ALiEnvironment Env ();

        // -(void)setIsForceH5:(BOOL)isForceH5;
        [Export ("setIsForceH5:")]
        void SetIsForceH5 (bool isForceH5);

        // -(void)setIsSyncForTaoke:(BOOL)isSync;
        [Export ("setIsSyncForTaoke:")]
        void SetIsSyncForTaoke (bool isSync);

        // -(void)setIsvVersion:(NSString *)version;
        [Export ("setIsvVersion:")]
        void SetIsvVersion (string version);

        // -(void)setISVCode:(NSString *)code;
        [Export ("setISVCode:")]
        void SetISVCode (string code);

        // -(void)setTaokeParams:(id)param;
        [Export ("setTaokeParams:")]
        void SetTaokeParams (NSObject param);

        // -(void)setChannel:(NSString *)type name:(NSString *)name;
        [Export ("setChannel:name:")]
        void SetChannel (string type, string name);

        // -(void)enableAuthVipMode;
        [Export ("enableAuthVipMode")]
        void EnableAuthVipMode ();

        // -(void)setShouldUseAlipayNative:(BOOL)shouldUseAlipayNative;
        [Export ("setShouldUseAlipayNative:")]
        void SetShouldUseAlipayNative (bool shouldUseAlipayNative);
    }

    // @interface ALiNetError : NSObject
    [BaseType (typeof (NSObject))]
    interface ALiNetError
    {
        // @property (copy, nonatomic) NSString * code;
        [Export ("code")]
        string Code { get; set; }

        // @property (copy, nonatomic) NSString * msg;
        [Export ("msg")]
        string Msg { get; set; }

        // @property (nonatomic, strong) NSError * rawError;
        [Export ("rawError", ArgumentSemantic.Strong)]
        NSError RawError { get; set; }

        // @property (assign, nonatomic) BOOL isLoginCancel;
        [Export ("isLoginCancel")]
        bool IsLoginCancel { get; set; }

        // @property (assign, nonatomic) BOOL isAuthCancel;
        [Export ("isAuthCancel")]
        bool IsAuthCancel { get; set; }
    }

    // typedef void (^MtopRequestCallback)(ALiNetError * _Nullable, id _Nullable);
    delegate void MtopRequestCallback ([NullAllowed] ALiNetError arg0, [NullAllowed] NSObject arg1);

    // @interface ALiMtopRequestHelp : NSObject
    [BaseType (typeof (NSObject))]
    interface ALiMtopRequestHelp
    {
        // +(void)initMtop;
        [Static]
        [Export ("initMtop")]
        void InitMtop ();

        // +(void)setEnvironment:(ALiEnvironment)env;
        [Static]
        [Export ("setEnvironment:")]
        void SetEnvironment (ALiEnvironment env);

        // +(void)ProcessMtopRequest:(ALiMtopCmd * _Nonnull)cmd data:(NSDictionary * _Nullable)dict complete:(MtopRequestCallback _Nullable)callback;
        [Static]
        [Export ("ProcessMtopRequest:data:complete:")]
        void ProcessMtopRequest (ALiMtopCmd cmd, [NullAllowed] NSDictionary dict, [NullAllowed] MtopRequestCallback callback);

        // +(void)ProcessMtopRequest:(ALiMtopCmd * _Nonnull)cmd data:(NSDictionary * _Nullable)dict uniqueKey:(NSString * _Nullable)uniqueKey complete:(MtopRequestCallback _Nullable)callback;
        [Static]
        [Export ("ProcessMtopRequest:data:uniqueKey:complete:")]
        void ProcessMtopRequest (ALiMtopCmd cmd, [NullAllowed] NSDictionary dict, [NullAllowed] string uniqueKey, [NullAllowed] MtopRequestCallback callback);

        // +(void)ProcessMtopRequest:(NSString * _Nonnull)cmd version:(NSString * _Nullable)version data:(NSDictionary * _Nullable)dict bizId:(NSString * _Nullable)bizId uniqueKey:(NSString * _Nullable)uniqueKey needLogin:(BOOL)needLogin needAuth:(BOOL)needAuth needWua:(BOOL)needWua complete:(MtopRequestCallback _Nullable)callback;
        [Static]
        [Export ("ProcessMtopRequest:version:data:bizId:uniqueKey:needLogin:needAuth:needWua:complete:")]
        void ProcessMtopRequest (string cmd, [NullAllowed] string version, [NullAllowed] NSDictionary dict, [NullAllowed] string bizId, [NullAllowed] string uniqueKey, bool needLogin, bool needAuth, bool needWua, [NullAllowed] MtopRequestCallback callback);
    }

    // @interface ALiReflectionUtil : NSObject
    [BaseType (typeof (NSObject))]
    interface ALiReflectionUtil
    {
        // +(id)getSharedInstance:(NSString *)className;
        [Static]
        [Export ("getSharedInstance:")]
        NSObject GetSharedInstance (string className);

        // +(id)getInstance:(NSString *)className instanceMethodName:(NSString *)instanceMethodName;
        [Static]
        [Export ("getInstance:instanceMethodName:")]
        NSObject GetInstance (string className, string instanceMethodName);

        // +(id)executeInstanceMethod:(NSString *)methodName instance:(id)instance params:(NSArray *)params;
        [Static]
        [Export ("executeInstanceMethod:instance:params:")]
        NSObject ExecuteInstanceMethod (string methodName, NSObject instance, NSObject [] @params);

        // +(id)executeClassMethod:(NSString *)methodName clazz:(Class)clazz;
        [Static]
        [Export ("executeClassMethod:clazz:")]
        NSObject ExecuteClassMethod (string methodName, Class clazz);

        // +(id)executeInstanceMethod:(NSString *)methodName instanceAndargs:(id)instance, ...;
        [Static, Internal]
        [Export ("executeInstanceMethod:instanceAndargs:", IsVariadic = true)]
        NSObject ExecuteInstanceMethod (string methodName, NSObject instance, IntPtr varArgs);
    }

    // @interface ALiSecurityGuardBridge : NSObject
    [BaseType (typeof (NSObject))]
    interface ALiSecurityGuardBridge
    {
        // +(void)pInitialize:(void (^)(NSError *))handler;
        [Static]
        [Export ("pInitialize:")]
        void PInitialize (Action<NSError> handler);

        // +(BOOL)isSecurityGuardAvaleable;
        [Static]
        [Export ("isSecurityGuardAvaleable")]
        bool IsSecurityGuardAvaleable { get; }

        // +(NSString *)authCode;
        [Static]
        [Export ("authCode")]
        string AuthCode { get; }

        // +(NSString *)getAppKey;
        [Static]
        [Export ("getAppKey")]
        string AppKey { get; }

        // +(NSNumber *)analyzeItemId:(NSString *)itemId;
        [Static]
        [Export ("analyzeItemId:")]
        NSNumber AnalyzeItemId (string itemId);

        // +(NSString *)getString:(NSString *)key;
        [Static]
        [Export ("getString:")]
        string GetString (string key);

        // +(int)putString:(NSString *)value forKey:(NSString *)key;
        [Static]
        [Export ("putString:forKey:")]
        int PutString (string value, string key);

        // +(NSData *)getData:(NSString *)key;
        [Static]
        [Export ("getData:")]
        NSData GetData (string key);

        // +(int)putData:(NSData *)value forKey:(NSString *)key;
        [Static]
        [Export ("putData:forKey:")]
        int PutData (NSData value, string key);
    }

    // @interface ALiTradeEnv : NSObject
    [BaseType (typeof (NSObject))]
    interface ALiTradeEnv
    {
        // +(NSString * _Nullable)itemURLWithItemType:(NSInteger)itemType itemID:(NSString * _Nonnull)itemID;
        [Static]
        [Export ("itemURLWithItemType:itemID:")]
        [return: NullAllowed]
        string ItemURLWithItemType (nint itemType, string itemID);

        // +(NSString * _Nullable)miniItemURLWithItemID:(NSString * _Nonnull)itemID;
        [Static]
        [Export ("miniItemURLWithItemID:")]
        [return: NullAllowed]
        string MiniItemURLWithItemID (string itemID);

        // +(NSString * _Nullable)addCardURL:(NSString * _Nonnull)itemID;
        [Static]
        [Export ("addCardURL:")]
        [return: NullAllowed]
        string AddCardURL (string itemID);

        // +(NSString * _Nullable)cartURL;
        [Static]
        [NullAllowed, Export ("cartURL")]
        string CartURL { get; }

        // +(NSString * _Nullable)myOrdersURLWithTabCode:(NSString * _Nonnull)tabCode condition:(NSString * _Nullable)condition;
        [Static]
        [Export ("myOrdersURLWithTabCode:condition:")]
        [return: NullAllowed]
        string MyOrdersURLWithTabCode (string tabCode, [NullAllowed] string condition);

        // +(NSString * _Nullable)shopURLWithShopID:(NSString * _Nonnull)shopID;
        [Static]
        [Export ("shopURLWithShopID:")]
        [return: NullAllowed]
        string ShopURLWithShopID (string shopID);

        // +(NSString * _Nullable)taobaoHomeURL;
        [Static]
        [NullAllowed, Export ("taobaoHomeURL")]
        string TaobaoHomeURL { get; }

        // +(NSString * _Nullable)configServerHost;
        [Static]
        [NullAllowed, Export ("configServerHost")]
        string ConfigServerHost { get; }
    }

    partial interface Constants
    {
        // extern ALiUTEventID *const ALiUTEventID$2201;
        //[Field ("ALiUTEventID$2201", "__Internal")]
        //NSString ALiUTEventID$2201 { get; }

        //// extern ALiUTEventID *const ALiUTEventID$2101;
        //[Field ("ALiUTEventID$2101", "__Internal")]
        //NSString ALiUTEventID$2101 { get; }

        // extern NSString *const ALiUTArgsKeyYBHPSS;
        [Field ("ALiUTArgsKeyYBHPSS", "__Internal")]
        NSString ALiUTArgsKeyYBHPSS { get; }

        // extern NSString *const ALiUTArgsKeyYBHPSS_LABEL;
        [Field ("ALiUTArgsKeyYBHPSS_LABEL", "__Internal")]
        NSString ALiUTArgsKeyYBHPSS_LABEL { get; }
    }

// @interface ALiUT : NSObject
[BaseType (typeof (NSObject))]
interface ALiUT
{
    // +(void)initUT;
    [Static]
    [Export ("initUT")]
    void InitUT ();

    // +(BOOL)isThird;
    [Static]
    [Export ("isThird")]
    bool IsThird { get; }

    // +(void)addTraceLog:(NSString *)page label:(NSString *)label interval:(NSInteger)interval propertys:(NSDictionary *)propertyDict;
    [Static]
    [Export ("addTraceLog:label:interval:propertys:")]
    void AddTraceLog (string page, string label, nint interval, NSDictionary propertyDict);

    // +(void)addTraceLog:(NSString *)label propertys:(NSDictionary *)propertyDict;
    [Static]
    [Export ("addTraceLog:propertys:")]
    void AddTraceLog (string label, NSDictionary propertyDict);

    // +(void)addTraceLog:(NSString *)label;
    [Static]
    [Export ("addTraceLog:")]
    void AddTraceLog (string label);

    // +(void)addTradeLogWithEventID:(ALiUTEventID *)eventID arg1:(NSString *)arg1 args:(NSDictionary *)args;
    [Static]
    [Export ("addTradeLogWithEventID:arg1:args:")]
    void AddTradeLogWithEventID (string eventID, string arg1, NSDictionary args);

    // +(void)addTrack4DAU;
    [Static]
    [Export ("addTrack4DAU")]
    void AddTrack4DAU ();

    // +(NSString *)ybhpssStringForDictionary:(NSDictionary *)params;
    [Static]
    [Export ("ybhpssStringForDictionary:")]
    string YbhpssStringForDictionary (NSDictionary @params);

    // +(BOOL)h5UT:(NSDictionary *)dataDict view:(UIWebView *)pView viewController:(UIViewController *)pViewController;
    [Static]
    [Export ("h5UT:view:viewController:")]
    bool H5UT (NSDictionary dataDict, UIWebView pView, UIViewController pViewController);
}

// @interface AliJSBridgeDynamicHandler : NSObject
[BaseType (typeof (NSObject))]
interface AliJSBridgeDynamicHandler
{
}

partial interface Constants
{
    // extern NSString *const AlibcTradeErrorDomain;
    [Field ("AlibcTradeErrorDomain", "__Internal")]
    NSString AlibcTradeErrorDomain { get; }
}

// @protocol AlibcTradePage <NSObject>
[Protocol, Model]
[BaseType (typeof (NSObject))]
interface AlibcTradePage
{
}

// @interface AlibcTradePageFactory : NSObject
[BaseType (typeof (NSObject))]
interface AlibcTradePageFactory
{
    // +(id<AlibcTradePage> _Nonnull)page:(NSString * _Nonnull)url;
    [Static]
    [Export ("page:")]
    AlibcTradePage Page (string url);

    // +(id<AlibcTradePage> _Nonnull)itemDetailPage:(NSString * _Nonnull)itemId;
    [Static]
    [Export ("itemDetailPage:")]
    AlibcTradePage ItemDetailPage (string itemId);

    // +(id<AlibcTradePage> _Nonnull)itemMiniDetailPage:(NSString * _Nonnull)itemId;
    [Static]
    [Export ("itemMiniDetailPage:")]
    AlibcTradePage ItemMiniDetailPage (string itemId);

    // +(id<AlibcTradePage> _Nonnull)myCartsPage;
    [Static]
    [Export ("myCartsPage")]
    AlibcTradePage MyCartsPage { get; }

    // +(id<AlibcTradePage> _Nonnull)myOrdersPage:(NSInteger)status isAllOrder:(BOOL)isAllOrder;
    [Static]
    [Export ("myOrdersPage:isAllOrder:")]
    AlibcTradePage MyOrdersPage (nint status, bool isAllOrder);

    // +(id<AlibcTradePage> _Nonnull)shopPage:(NSString * _Nonnull)shopId;
    [Static]
    [Export ("shopPage:")]
    AlibcTradePage ShopPage (string shopId);

    // +(id<AlibcTradePage> _Nonnull)addCartPage:(NSString * _Nonnull)itemId;
    [Static]
    [Export ("addCartPage:")]
    AlibcTradePage AddCartPage (string itemId);

    // +(id<AlibcTradePage> _Nonnull)requestPage:(NSMutableURLRequest * _Nonnull)request;
    [Static]
    [Export ("requestPage:")]
    AlibcTradePage RequestPage (NSMutableUrlRequest request);
}

// @interface AlibcTradePayResult : NSObject
[BaseType (typeof (NSObject))]
interface AlibcTradePayResult
{
    // @property (readonly, copy, nonatomic) NSArray * _Nullable paySuccessOrders;
    [NullAllowed, Export ("paySuccessOrders", ArgumentSemantic.Copy)]
    NSObject [] PaySuccessOrders { get; }

    // @property (readonly, copy, nonatomic) NSArray * _Nullable payFailedOrders;
    [NullAllowed, Export ("payFailedOrders", ArgumentSemantic.Copy)]
    NSObject [] PayFailedOrders { get; }
}

// @interface AlibcTradeResult : NSObject
[BaseType (typeof (NSObject))]
interface AlibcTradeResult
{
    // @property (assign, nonatomic) ALiTradeResultType result;
    [Export ("result", ArgumentSemantic.Assign)]
    ALiTradeResultType Result { get; set; }

    // @property (nonatomic, strong) AlibcTradePayResult * _Nullable payResult;
    [NullAllowed, Export ("payResult", ArgumentSemantic.Strong)]
    AlibcTradePayResult PayResult { get; set; }
}

    // @interface AlibcTradeTaokeParams : NSObject
    [BaseType (typeof (NSObject))]
    interface AlibcTradeTaokeParams
    {
        // @property (copy, nonatomic) NSString * pid;
        [NullAllowed, Export ("pid")]
        string Pid { get; set; }

        // @property (copy, nonatomic) NSString * unionId;
        [NullAllowed, Export ("unionId")]
        string UnionId { get; set; }

        // @property (copy, nonatomic) NSString * subPid;
        [NullAllowed, Export ("subPid")]
        string SubPid { get; set; }
    }

    // @interface AlibcTradeShowParams : NSObject
    [BaseType (typeof (NSObject))]
    interface AlibcTradeShowParams
    {
        // @property (assign, nonatomic) BOOL isNeedPush;
        [Export ("isNeedPush")]
        bool IsNeedPush { get; set; }

        // @property (assign, nonatomic) ALiOpenType openType;
        [Export ("openType", ArgumentSemantic.Assign)]
        ALiOpenType OpenType { get; set; }

        // @property (nonatomic, strong) NSString * backUrl;
        [Export ("backUrl", ArgumentSemantic.Strong)]
        string BackUrl { get; set; }

        // @property (nonatomic, strong) NSString * linkKey;
        [Export ("linkKey", ArgumentSemantic.Strong)]
        string LinkKey { get; set; }
    }

    // typedef void (^tradeProcessSuccessCallback)(AlibcTradeResult * _Nullable);
    delegate void tradeProcessSuccessCallback ([NullAllowed] AlibcTradeResult arg0);

    // typedef void (^tradeProcessFailedCallback)(NSError * _Nullable);
    delegate void tradeProcessFailedCallback ([NullAllowed] NSError arg0);

    interface IAlibcTradeService { }

    // @protocol AlibcTradeService <NSObject>
    [Protocol, Model]
    [BaseType (typeof (NSObject))]
    interface AlibcTradeService
    {
        // @required -(NSInteger)show:(UIViewController * _Nonnull)parentController page:(id<AlibcTradePage> _Nonnull)page showParams:(AlibcTradeShowParams * _Nullable)showParams taoKeParams:(AlibcTradeTaokeParams * _Nullable)taoKeParams trackParam:(NSDictionary * _Nullable)trackParam tradeProcessSuccessCallback:(void (^ _Nullable)(AlibcTradeResult * _Nullable))onSuccess tradeProcessFailedCallback:(void (^ _Nullable)(NSError * _Nullable))onFailure;
        [Abstract]
        [Export ("show:page:showParams:taoKeParams:trackParam:tradeProcessSuccessCallback:tradeProcessFailedCallback:")]
        nint Page (UIViewController parentController, AlibcTradePage page, [NullAllowed] AlibcTradeShowParams showParams, [NullAllowed] AlibcTradeTaokeParams taoKeParams, [NullAllowed] NSDictionary trackParam, [NullAllowed] Action<AlibcTradeResult> onSuccess, [NullAllowed] Action<NSError> onFailure);

        // @required -(NSInteger)show:(UIViewController * _Nonnull)parentController webView:(UIWebView * _Nullable)webView page:(id<AlibcTradePage> _Nonnull)page showParams:(AlibcTradeShowParams * _Nullable)showParams taoKeParams:(AlibcTradeTaokeParams * _Nullable)taoKeParams trackParam:(NSDictionary * _Nullable)trackParam tradeProcessSuccessCallback:(void (^ _Nullable)(AlibcTradeResult * _Nullable))onSuccess tradeProcessFailedCallback:(void (^ _Nullable)(NSError * _Nullable))onFailure;
        [Abstract]
        [Export ("show:webView:page:showParams:taoKeParams:trackParam:tradeProcessSuccessCallback:tradeProcessFailedCallback:")]
        nint WebView (UIViewController parentController, [NullAllowed] UIWebView webView, AlibcTradePage page, [NullAllowed] AlibcTradeShowParams showParams, [NullAllowed] AlibcTradeTaokeParams taoKeParams, [NullAllowed] NSDictionary trackParam, [NullAllowed] Action<AlibcTradeResult> onSuccess, [NullAllowed] Action<NSError> onFailure);
    }

    [Static]
    partial interface Constants
    {
        // extern NSString *const AlibcTradeEventId_Exposure;
        [Field ("AlibcTradeEventId_Exposure", "__Internal")]
        NSString AlibcTradeEventId_Exposure { get; }

        // extern NSString *const AlibcTradeEventId_ContentClick;
        [Field ("AlibcTradeEventId_ContentClick", "__Internal")]
        NSString AlibcTradeEventId_ContentClick { get; }
    }

    // @interface AlibcTrackParams : NSObject
    [BaseType (typeof (NSObject))]
    interface AlibcTrackParams
    {
        // @property (nonatomic, strong) NSString * scm;
        [Export ("scm", ArgumentSemantic.Strong)]
        string Scm { get; set; }

        // @property (nonatomic, strong) NSString * pvid;
        [Export ("pvid", ArgumentSemantic.Strong)]
        string Pvid { get; set; }

        // @property (nonatomic, strong) NSString * puid;
        [Export ("puid", ArgumentSemantic.Strong)]
        string Puid { get; set; }

        // @property (nonatomic, strong) NSString * page;
        [Export ("page", ArgumentSemantic.Strong)]
        string Page { get; set; }

        // @property (nonatomic, strong) NSString * label;
        [Export ("label", ArgumentSemantic.Strong)]
        string Label { get; set; }

        // -(NSDictionary *)toDictionary;
        [Export ("toDictionary")]
        NSDictionary ToDictionary { get; }
    }

    // @interface AlibcTradeTrackService : NSObject
    [BaseType (typeof (NSObject))]
    interface AlibcTradeTrackService
    {
        // +(void)addTraceLog:(NSString *)eventId param:(AlibcTrackParams *)params;
        [Static]
        [Export ("addTraceLog:param:")]
        void AddTraceLog (string eventId, AlibcTrackParams @params);
    }

    // @interface TrimNSNull (NSDictionary)
    [Category]
    [BaseType (typeof (NSDictionary))]
    interface NSDictionary_TrimNSNull
    {
        // -(id)aliObjectForKey:(id)aKey;
        [Export ("aliObjectForKey:")]
        NSObject AliObjectForKey (NSObject aKey);
    }
}
