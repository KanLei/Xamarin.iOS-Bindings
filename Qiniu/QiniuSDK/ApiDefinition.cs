using System;
using AssetsLibrary;
using Foundation;
using ObjCRuntime;
using Photos;

namespace QiniuSDK
{
	// @protocol QNFileDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof (NSObject))]
	interface QNFileDelegate
	{
		// @required -(NSData *)read:(long)offset size:(long)size;
		[Abstract]
		[Export ("read:size:")]
		NSData Read (nint offset, nint size);

		// @required -(NSData *)readAll;
		[Abstract]
		[Export ("readAll")]
		NSData ReadAll { get; }

		// @required -(void)close;
		[Abstract]
		[Export ("close")]
		void Close ();

		// @required -(NSString *)path;
		[Abstract]
		[Export ("path")]
		string Path { get; }

		// @required -(int64_t)modifyTime;
		[Abstract]
		[Export ("modifyTime")]
		long ModifyTime { get; }

		// @required -(int64_t)size;
		[Abstract]
		[Export ("size")]
		long Size { get; }
	}

	// typedef void (^QNRun)();
	delegate void QNRun ();

	// typedef NSString * (^QNRecorderKeyGenerator)(NSString *, NSString *);
	delegate string QNRecorderKeyGenerator (string arg0, string arg1);

	// @protocol QNRecorderDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof (NSObject))]
	interface QNRecorderDelegate
	{
		// @required -(NSError *)set:(NSString *)key data:(NSData *)value;
		[Abstract]
		[Export ("set:data:")]
		NSError Set (string key, NSData value);

		// @required -(NSData *)get:(NSString *)key;
		[Abstract]
		[Export ("get:")]
		NSData Get (string key);

		// @required -(NSError *)del:(NSString *)key;
		[Abstract]
		[Export ("del:")]
		NSError Del (string key);
	}

	partial interface Constants
	{
		// extern const UInt32 kQNBlockSize;
		[Field ("kQNBlockSize", "__Internal")]
		int kQNBlockSize { get; }
	}

	// typedef NSString * (^QNUrlConvert)(NSString *);
	delegate string QNUrlConvert (string arg0);

	// typedef void (^QNConfigurationBuilderBlock)(QNConfigurationBuilder *);
	delegate void QNConfigurationBuilderBlock (QNConfigurationBuilder arg0);

	// @interface QNConfiguration : NSObject
	[BaseType (typeof (NSObject))]
	interface QNConfiguration
	{
		// @property (readonly, copy, nonatomic) QNServiceAddress * up;
		[Export ("up", ArgumentSemantic.Copy)]
		QNServiceAddress Up { get; }

		// @property (readonly, copy, nonatomic) QNServiceAddress * upBackup;
		[Export ("upBackup", ArgumentSemantic.Copy)]
		QNServiceAddress UpBackup { get; }

		// @property (readonly) UInt32 chunkSize;
		[Export ("chunkSize")]
		uint ChunkSize { get; }

		// @property (readonly) UInt32 putThreshold;
		[Export ("putThreshold")]
		uint PutThreshold { get; }

		// @property (readonly) UInt32 retryMax;
		[Export ("retryMax")]
		uint RetryMax { get; }

		// @property (readonly) UInt32 timeoutInterval;
		[Export ("timeoutInterval")]
		uint TimeoutInterval { get; }

		// @property (readonly, nonatomic) id<QNRecorderDelegate> recorder;
		[Export ("recorder")]
		QNRecorderDelegate Recorder { get; }

		// @property (readonly, nonatomic) QNRecorderKeyGenerator recorderKeyGen;
		[Export ("recorderKeyGen")]
		QNRecorderKeyGenerator RecorderKeyGen { get; }

		// @property (readonly, nonatomic) NSDictionary * proxy;
		[Export ("proxy")]
		NSDictionary Proxy { get; }

		// @property (readonly, nonatomic) QNUrlConvert converter;
		[Export ("converter")]
		QNUrlConvert Converter { get; }

		// @property (readonly, nonatomic) QNDnsManager * dns;
		//[Export ("dns")]
		//QNDnsManager Dns { get; }

		// @property (readonly) BOOL disableATS;
		[Export ("disableATS")]
		bool DisableATS { get; }

		// +(instancetype)build:(QNConfigurationBuilderBlock)block;
		[Static]
		[Export ("build:")]
		QNConfiguration Build (QNConfigurationBuilderBlock block);
	}

	// @interface QNServiceAddress : NSObject
	[BaseType (typeof (NSObject))]
	interface QNServiceAddress
	{
		// -(instancetype)init:(NSString *)address ips:(NSArray *)ips;
		[Export ("init:ips:")]
		IntPtr Constructor (string address, NSObject [] ips);

		// @property (readonly, nonatomic) NSString * address;
		[Export ("address")]
		string Address { get; }

		// @property (readonly, nonatomic) NSArray * ips;
		[Export ("ips")]
		NSObject [] Ips { get; }
	}

	// @interface QNZone : NSObject
	[BaseType (typeof (NSObject))]
	interface QNZone
	{
		// @property (readonly, nonatomic) QNServiceAddress * up;
		[Export ("up")]
		QNServiceAddress Up { get; }

		// @property (readonly, nonatomic) QNServiceAddress * upBackup;
		[Export ("upBackup")]
		QNServiceAddress UpBackup { get; }

		// -(instancetype)initWithUp:(QNServiceAddress *)up upBackup:(QNServiceAddress *)upBackup;
		[Export ("initWithUp:upBackup:")]
		IntPtr Constructor (QNServiceAddress up, QNServiceAddress upBackup);

		// +(instancetype)zone0;
		[Static]
		[Export ("zone0")]
		QNZone Zone0 ();

		// +(instancetype)zone1;
		[Static]
		[Export ("zone1")]
		QNZone Zone1 ();
	}

	// @interface QNConfigurationBuilder : NSObject
	[BaseType (typeof (NSObject))]
	interface QNConfigurationBuilder
	{
		// @property (nonatomic, strong) QNZone * zone;
		[Export ("zone", ArgumentSemantic.Strong)]
		QNZone Zone { get; set; }

		// @property (assign) UInt32 chunkSize;
		[Export ("chunkSize")]
		uint ChunkSize { get; set; }

		// @property (assign) UInt32 putThreshold;
		[Export ("putThreshold")]
		uint PutThreshold { get; set; }

		// @property (assign) UInt32 retryMax;
		[Export ("retryMax")]
		uint RetryMax { get; set; }

		// @property (assign) UInt32 timeoutInterval;
		[Export ("timeoutInterval")]
		uint TimeoutInterval { get; set; }

		// @property (nonatomic, strong) id<QNRecorderDelegate> recorder;
		[Export ("recorder", ArgumentSemantic.Strong)]
		QNRecorderDelegate Recorder { get; set; }

		// @property (nonatomic, strong) QNRecorderKeyGenerator recorderKeyGen;
		[Export ("recorderKeyGen", ArgumentSemantic.Strong)]
		QNRecorderKeyGenerator RecorderKeyGen { get; set; }

		// @property (nonatomic, strong) NSDictionary * proxy;
		[Export ("proxy", ArgumentSemantic.Strong)]
		NSDictionary Proxy { get; set; }

		// @property (nonatomic, strong) QNUrlConvert converter;
		[Export ("converter", ArgumentSemantic.Strong)]
		QNUrlConvert Converter { get; set; }

		// @property (nonatomic, strong) QNDnsManager * dns;
		//[Export ("dns", ArgumentSemantic.Strong)]
		//QNDnsManager Dns { get; set; }

		// @property (assign) BOOL disableATS;
		[Export ("disableATS")]
		bool DisableATS { get; set; }
	}

	// @interface QNCrc32 : NSObject
	[BaseType (typeof (NSObject))]
	interface QNCrc32
	{
		// +(UInt32)file:(NSString *)filePath error:(NSError **)error;
		[Static]
		[Export ("file:error:")]
		uint File (string filePath, out NSError error);

		// +(UInt32)data:(NSData *)data;
		[Static]
		[Export ("data:")]
		uint Data (NSData data);
	}

	// @interface QNEtag : NSObject
	[BaseType (typeof (NSObject))]
	interface QNEtag
	{
		// +(NSString *)file:(NSString *)filePath error:(NSError **)error;
		[Static]
		[Export ("file:error:")]
		string File (string filePath, out NSError error);

		// +(NSString *)data:(NSData *)data;
		[Static]
		[Export ("data:")]
		string Data (NSData data);
	}


	// typedef void (^QNInternalProgressBlock)(long long, long long);
	delegate void QNInternalProgressBlock (long arg0, long arg1);

	// typedef void (^QNCompleteBlock)(QNResponseInfo *, NSDictionary *);
	delegate void QNCompleteBlock (QNResponseInfo arg0, NSDictionary arg1);

	// typedef BOOL (^QNCancelBlock)();
	delegate bool QNCancelBlock ();

	// @protocol QNHttpDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof (NSObject))]
	interface QNHttpDelegate
	{
		// @required -(void)multipartPost:(NSString *)url withData:(NSData *)data withParams:(NSDictionary *)params withFileName:(NSString *)key withMimeType:(NSString *)mime withCompleteBlock:(QNCompleteBlock)completeBlock withProgressBlock:(QNInternalProgressBlock)progressBlock withCancelBlock:(QNCancelBlock)cancelBlock;
		[Abstract]
		[Export ("multipartPost:withData:withParams:withFileName:withMimeType:withCompleteBlock:withProgressBlock:withCancelBlock:")]
		void MultipartPost (string url, NSData data, NSDictionary @params, string key, string mime, QNCompleteBlock completeBlock, QNInternalProgressBlock progressBlock, QNCancelBlock cancelBlock);

		// @required -(void)post:(NSString *)url withData:(NSData *)data withParams:(NSDictionary *)params withHeaders:(NSDictionary *)headers withCompleteBlock:(QNCompleteBlock)completeBlock withProgressBlock:(QNInternalProgressBlock)progressBlock withCancelBlock:(QNCancelBlock)cancelBlock;
		[Abstract]
		[Export ("post:withData:withParams:withHeaders:withCompleteBlock:withProgressBlock:withCancelBlock:")]
		void Post (string url, NSData data, NSDictionary @params, NSDictionary headers, QNCompleteBlock completeBlock, QNInternalProgressBlock progressBlock, QNCancelBlock cancelBlock);
	}

	// @interface QNUpToken : NSObject
	[BaseType (typeof (NSObject))]
	interface QNUpToken
	{
		// +(instancetype)parse:(NSString *)token;
		[Static]
		[Export ("parse:")]
		QNUpToken Parse (string token);

		// @property (readonly, copy, nonatomic) NSString * access;
		[Export ("access")]
		string Access { get; }

		// @property (readonly, copy, nonatomic) NSString * bucket;
		[Export ("bucket")]
		string Bucket { get; }

		// @property (readonly, copy, nonatomic) NSString * token;
		[Export ("token")]
		string Token { get; }

		// @property (readonly) BOOL hasReturnUrl;
		[Export ("hasReturnUrl")]
		bool HasReturnUrl { get; }
	}

	// typedef void (^QNUpCompletionHandler)(QNResponseInfo *, NSString *, NSDictionary *);
	delegate void QNUpCompletionHandler (QNResponseInfo arg0, string arg1, NSDictionary arg2);

	// @interface QNUploadManager : NSObject
	[BaseType (typeof (NSObject))]
	interface QNUploadManager
	{
		// -(instancetype)initWithRecorder:(id<QNRecorderDelegate>)recorder;
		[Export ("initWithRecorder:")]
		IntPtr Constructor (QNRecorderDelegate recorder);

		// -(instancetype)initWithRecorder:(id<QNRecorderDelegate>)recorder recorderKeyGenerator:(QNRecorderKeyGenerator)recorderKeyGenerator;
		[Export ("initWithRecorder:recorderKeyGenerator:")]
		IntPtr Constructor (QNRecorderDelegate recorder, QNRecorderKeyGenerator recorderKeyGenerator);

		// -(instancetype)initWithConfiguration:(QNConfiguration *)config;
		[Export ("initWithConfiguration:")]
		IntPtr Constructor (QNConfiguration config);

		// +(instancetype)sharedInstanceWithConfiguration:(QNConfiguration *)config;
		[Static]
		[Export ("sharedInstanceWithConfiguration:")]
		QNUploadManager SharedInstanceWithConfiguration (QNConfiguration config);

		// -(void)putData:(NSData *)data key:(NSString *)key token:(NSString *)token complete:(QNUpCompletionHandler)completionHandler option:(QNUploadOption *)option;
		[Export ("putData:key:token:complete:option:")]
		void PutData (NSData data, string key, string token, QNUpCompletionHandler completionHandler, [NullAllowed]QNUploadOption option);

		// -(void)putFile:(NSString *)filePath key:(NSString *)key token:(NSString *)token complete:(QNUpCompletionHandler)completionHandler option:(QNUploadOption *)option;
		[Export ("putFile:key:token:complete:option:")]
		void PutFile (string filePath, string key, string token, QNUpCompletionHandler completionHandler, [NullAllowed]QNUploadOption option);

		// -(void)putALAsset:(ALAsset *)asset key:(NSString *)key token:(NSString *)token complete:(QNUpCompletionHandler)completionHandler option:(QNUploadOption *)option;
		[Export ("putALAsset:key:token:complete:option:")]
		void PutALAsset (ALAsset asset, string key, string token, QNUpCompletionHandler completionHandler, [NullAllowed]QNUploadOption option);

		// -(void)putPHAsset:(PHAsset *)asset key:(NSString *)key token:(NSString *)token complete:(QNUpCompletionHandler)completionHandler option:(QNUploadOption *)option;
		[Export ("putPHAsset:key:token:complete:option:")]
		void PutPHAsset (PHAsset asset, string key, string token, QNUpCompletionHandler completionHandler, [NullAllowed]QNUploadOption option);

		// -(void)putPHAssetResource:(PHAssetResource *)assetResource key:(NSString *)key token:(NSString *)token complete:(QNUpCompletionHandler)completionHandler option:(QNUploadOption *)option;
		[Export ("putPHAssetResource:key:token:complete:option:")]
		void PutPHAssetResource (PHAssetResource assetResource, string key, string token, QNUpCompletionHandler completionHandler, [NullAllowed]QNUploadOption option);
	}

	// @interface QNFormUpload : NSObject
	[BaseType (typeof (NSObject))]
	interface QNFormUpload
	{
		// -(instancetype)initWithData:(NSData *)data withKey:(NSString *)key withToken:(QNUpToken *)token withCompletionHandler:(QNUpCompletionHandler)block withOption:(QNUploadOption *)option withHttpManager:(id<QNHttpDelegate>)http withConfiguration:(QNConfiguration *)config;
		[Export ("initWithData:withKey:withToken:withCompletionHandler:withOption:withHttpManager:withConfiguration:")]
		IntPtr Constructor (NSData data, string key, QNUpToken token, QNUpCompletionHandler block, QNUploadOption option, QNHttpDelegate http, QNConfiguration config);

		// -(void)put;
		[Export ("put")]
		void Put ();
	}


	[Static]
	partial interface Constants
	{
		// extern const int kQNRequestCancelled;
		[Field ("kQNRequestCancelled", "__Internal")]
		int kQNRequestCancelled { get; }

		// extern const int kQNNetworkError;
		[Field ("kQNNetworkError", "__Internal")]
		int kQNNetworkError { get; }

		// extern const int kQNInvalidArgument;
		[Field ("kQNInvalidArgument", "__Internal")]
		int kQNInvalidArgument { get; }

		// extern const int kQNZeroDataSize;
		[Field ("kQNZeroDataSize", "__Internal")]
		int kQNZeroDataSize { get; }

		// extern const int kQNInvalidToken;
		[Field ("kQNInvalidToken", "__Internal")]
		int kQNInvalidToken { get; }

		// extern const int kQNFileError;
		[Field ("kQNFileError", "__Internal")]
		int kQNFileError { get; }
	}

	// @interface QNResponseInfo : NSObject
	[BaseType (typeof (NSObject))]
	interface QNResponseInfo
	{
		// @property (readonly) int statusCode;
		[Export ("statusCode")]
		int StatusCode { get; }

		// @property (readonly, copy, nonatomic) NSString * reqId;
		[Export ("reqId")]
		string ReqId { get; }

		// @property (readonly, copy, nonatomic) NSString * xlog;
		[Export ("xlog")]
		string Xlog { get; }

		// @property (readonly, copy, nonatomic) NSString * xvia;
		[Export ("xvia")]
		string Xvia { get; }

		// @property (readonly, copy, nonatomic) NSError * error;
		[Export ("error", ArgumentSemantic.Copy)]
		NSError Error { get; }

		// @property (readonly, copy, nonatomic) NSString * host;
		[Export ("host")]
		string Host { get; }

		// @property (readonly, nonatomic) double duration;
		[Export ("duration")]
		double Duration { get; }

		// @property (readonly, nonatomic) NSString * serverIp;
		[Export ("serverIp")]
		string ServerIp { get; }

		// @property (readonly, nonatomic) NSString * id;
		[Export ("id")]
		string Id { get; }

		// @property (readonly) UInt64 timeStamp;
		[Export ("timeStamp")]
		ulong TimeStamp { get; }

		// @property (readonly, getter = isCancelled, nonatomic) BOOL canceled;
		[Export ("canceled")]
		bool Canceled { [Bind ("isCancelled")] get; }

		// @property (readonly, getter = isOK, nonatomic) BOOL ok;
		[Export ("ok")]
		bool Ok { [Bind ("isOK")] get; }

		// @property (readonly, getter = isConnectionBroken, nonatomic) BOOL broken;
		[Export ("broken")]
		bool Broken { [Bind ("isConnectionBroken")] get; }

		// @property (readonly, nonatomic) BOOL couldRetry;
		[Export ("couldRetry")]
		bool CouldRetry { get; }

		// @property (readonly, nonatomic) BOOL needSwitchServer;
		[Export ("needSwitchServer")]
		bool NeedSwitchServer { get; }

		// @property (readonly, getter = isNotQiniu, nonatomic) BOOL notQiniu;
		[Export ("notQiniu")]
		bool NotQiniu { [Bind ("isNotQiniu")] get; }

		// +(instancetype)cancel;
		[Static]
		[Export ("cancel")]
		QNResponseInfo Cancel ();

		// +(instancetype)responseInfoWithInvalidArgument:(NSString *)desc;
		[Static]
		[Export ("responseInfoWithInvalidArgument:")]
		QNResponseInfo ResponseInfoWithInvalidArgument (string desc);

		// +(instancetype)responseInfoWithInvalidToken:(NSString *)desc;
		[Static]
		[Export ("responseInfoWithInvalidToken:")]
		QNResponseInfo ResponseInfoWithInvalidToken (string desc);

		// +(instancetype)responseInfoWithNetError:(NSError *)error host:(NSString *)host duration:(double)duration;
		[Static]
		[Export ("responseInfoWithNetError:host:duration:")]
		QNResponseInfo ResponseInfoWithNetError (NSError error, string host, double duration);

		// +(instancetype)responseInfoWithFileError:(NSError *)error;
		[Static]
		[Export ("responseInfoWithFileError:")]
		QNResponseInfo ResponseInfoWithFileError (NSError error);

		// +(instancetype)responseInfoOfZeroData:(NSString *)path;
		[Static]
		[Export ("responseInfoOfZeroData:")]
		QNResponseInfo ResponseInfoOfZeroData (string path);

		// -(instancetype)init:(int)status withReqId:(NSString *)reqId withXLog:(NSString *)xlog withXVia:(NSString *)xvia withHost:(NSString *)host withIp:(NSString *)ip withDuration:(double)duration withBody:(NSData *)body;
		[Export ("init:withReqId:withXLog:withXVia:withHost:withIp:withDuration:withBody:")]
		IntPtr Constructor (int status, string reqId, string xlog, string xvia, string host, string ip, double duration, NSData body);
	}

	// @interface QNResumeUpload : NSObject
	[BaseType (typeof (NSObject))]
	interface QNResumeUpload
	{
		// -(instancetype)initWithFile:(id<QNFileDelegate>)file withKey:(NSString *)key withToken:(QNUpToken *)token withCompletionHandler:(QNUpCompletionHandler)block withOption:(QNUploadOption *)option withRecorder:(id<QNRecorderDelegate>)recorder withRecorderKey:(NSString *)recorderKey withHttpManager:(id<QNHttpDelegate>)http withConfiguration:(QNConfiguration *)config;
		[Export ("initWithFile:withKey:withToken:withCompletionHandler:withOption:withRecorder:withRecorderKey:withHttpManager:withConfiguration:")]
		IntPtr Constructor (QNFileDelegate file, string key, QNUpToken token, QNUpCompletionHandler block, QNUploadOption option, QNRecorderDelegate recorder, string recorderKey, QNHttpDelegate http, QNConfiguration config);

		// -(void)run;
		[Export ("run")]
		void Run ();
	}


	// typedef void (^QNUpProgressHandler)(NSString *, float);
	delegate void QNUpProgressHandler (string arg0, float arg1);

	// typedef BOOL (^QNUpCancellationSignal)();
	delegate bool QNUpCancellationSignal ();

	// @interface QNUploadOption : NSObject
	[BaseType (typeof (NSObject))]
	interface QNUploadOption
	{
		// @property (readonly, copy, nonatomic) NSDictionary * params;
		[Export ("params", ArgumentSemantic.Copy)]
		NSDictionary Params { get; }

		// @property (readonly, copy, nonatomic) NSString * mimeType;
		[Export ("mimeType")]
		string MimeType { get; }

		// @property (readonly) BOOL checkCrc;
		[Export ("checkCrc")]
		bool CheckCrc { get; }

		// @property (readonly, copy) QNUpProgressHandler progressHandler;
		[Export ("progressHandler", ArgumentSemantic.Copy)]
		QNUpProgressHandler ProgressHandler { get; }

		// @property (readonly, copy) QNUpCancellationSignal cancellationSignal;
		[Export ("cancellationSignal", ArgumentSemantic.Copy)]
		QNUpCancellationSignal CancellationSignal { get; }

		// -(instancetype)initWithMime:(NSString *)mimeType progressHandler:(QNUpProgressHandler)progress params:(NSDictionary *)params checkCrc:(BOOL)check cancellationSignal:(QNUpCancellationSignal)cancellation;
		[Export ("initWithMime:progressHandler:params:checkCrc:cancellationSignal:")]
		IntPtr Constructor (string mimeType, QNUpProgressHandler progress, NSDictionary @params, bool check, QNUpCancellationSignal cancellation);

		// -(instancetype)initWithProgessHandler:(QNUpProgressHandler)progress __attribute__((deprecated("")));
		[Export ("initWithProgessHandler:")]
		IntPtr Constructor (QNUpProgressHandler progress);

		// -(instancetype)initWithProgressHandler:(QNUpProgressHandler)progress;
		//[Export ("initWithProgressHandler:")]
		//IntPtr Constructor (QNUpProgressHandler progress);

		// +(instancetype)defaultOptions;
		[Static]
		[Export ("defaultOptions")]
		QNUploadOption DefaultOptions ();
	}

}
