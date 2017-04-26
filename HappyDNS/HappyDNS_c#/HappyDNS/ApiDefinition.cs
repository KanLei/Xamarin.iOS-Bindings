using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;

namespace HappyDNS
{
	// The first step to creating a binding is to add your native library ("libNativeLibrary.a")
	// to the project by right-clicking (or Control-clicking) the folder containing this source
	// file and clicking "Add files..." and then simply select the native library (or libraries)
	// that you want to bind.
	//
	// When you do that, you'll notice that MonoDevelop generates a code-behind file for each
	// native library which will contain a [LinkWith] attribute. MonoDevelop auto-detects the
	// architectures that the native library supports and fills in that information for you,
	// however, it cannot auto-detect any Frameworks or other system libraries that the
	// native library may depend on, so you'll need to fill in that information yourself.
	//
	// Once you've done that, you're ready to move on to binding the API...
	//
	//
	// Here is where you'd define your API definition for the native Objective-C library.
	//
	// For example, to bind the following Objective-C class:
	//
	//     @interface Widget : NSObject {
	//     }
	//
	// The C# binding would look like this:
	//
	//     [BaseType (typeof (NSObject))]
	//     interface Widget {
	//     }
	//
	// To bind Objective-C properties, such as:
	//
	//     @property (nonatomic, readwrite, assign) CGPoint center;
	//
	// You would add a property definition in the C# interface like so:
	//
	//     [Export ("center")]
	//     CGPoint Center { get; set; }
	//
	// To bind an Objective-C method, such as:
	//
	//     -(void) doSomething:(NSObject *)object atIndex:(NSInteger)index;
	//
	// You would add a method definition to the C# interface like so:
	//
	//     [Export ("doSomething:atIndex:")]
	//     void DoSomething (NSObject object, int index);
	//
	// Objective-C "constructors" such as:
	//
	//     -(id)initWithElmo:(ElmoMuppet *)elmo;
	//
	// Can be bound as:
	//
	//     [Export ("initWithElmo:")]
	//     IntPtr Constructor (ElmoMuppet elmo);
	//
	// For more information, see http://developer.xamarin.com/guides/ios/advanced_topics/binding_objective-c/
	//

//	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const int kQNDomainHijackingCode;
		[Field ("kQNDomainHijackingCode", "__Internal")]
		int kQNDomainHijackingCode { get; }

		// extern const int kQNDomainNotOwnCode;
		[Field ("kQNDomainNotOwnCode", "__Internal")]
		int kQNDomainNotOwnCode { get; }

		// extern const int kQNDomainSeverError;
		[Field ("kQNDomainSeverError", "__Internal")]
		int kQNDomainSeverError { get; }
	}

	// @protocol QNResolverDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface QNResolverDelegate
	{
		// @required -(NSArray *)query:(QNDomain *)domain networkInfo:(QNNetworkInfo *)netInfo error:(NSError **)error;
		[Abstract]
		[Export ("query:networkInfo:error:")]
//		[Verify (StronglyTypedNSArray)]
		NSObject[] NetworkInfo (QNDomain domain, QNNetworkInfo netInfo, out NSError error);
	}

	interface IQNResolverDelegate{}

	// @interface QNResolver : NSObject <QNResolverDelegate>
	[BaseType (typeof(NSObject))]
	interface QNResolver : IQNResolverDelegate
	{
		// -(NSArray *)query:(QNDomain *)domain networkInfo:(QNNetworkInfo *)netInfo error:(NSError **)error;
		[Export ("query:networkInfo:error:")]
//		[Verify (StronglyTypedNSArray)]
		NSObject[] Query (QNDomain domain, QNNetworkInfo netInfo, out NSError error);

		// -(instancetype)initWithAddres:(NSString *)address;
		[Export ("initWithAddres:")]
		IntPtr Constructor (string address);

		// +(instancetype)systemResolver;
		[Static]
		[Export ("systemResolver")]
		QNResolver SystemResolver ();
	}

	// @interface QNDomain : NSObject
	[BaseType (typeof(NSObject))]
	interface QNDomain
	{
		// @property (readonly, nonatomic) NSString * domain;
		[Export ("domain")]
		string Domain { get; }

		// @property (readonly) BOOL hasCname;
		[Export ("hasCname")]
		bool HasCname { get; }

		// @property (readonly) int maxTtl;
		[Export ("maxTtl")]
		int MaxTtl { get; }

		// @property (readonly) BOOL hostsFirst;
		[Export ("hostsFirst")]
		bool HostsFirst { get; }

		// -(instancetype)init:(NSString *)domain;
		[Export ("init:")]
		IntPtr Constructor (string domain);

		// -(instancetype)init:(NSString *)domain hostsFirst:(BOOL)hostsFirst hasCname:(BOOL)hasCname;
		[Export ("init:hostsFirst:hasCname:")]
		IntPtr Constructor (string domain, bool hostsFirst, bool hasCname);

		// -(instancetype)init:(NSString *)domain hostsFirst:(BOOL)hostsFirst hasCname:(BOOL)hasCname maxTtl:(int)maxTtl;
		[Export ("init:hostsFirst:hasCname:maxTtl:")]
		IntPtr Constructor (string domain, bool hostsFirst, bool hasCname, int maxTtl);
	}

	// @protocol QNIpSorter <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface QNIpSorter
	{
		// @required -(NSArray *)sort:(NSArray *)ips;
		[Abstract]
		[Export ("sort:")]
//		[Verify (StronglyTypedNSArray), Verify (StronglyTypedNSArray)]
		NSObject[] Sort (NSObject[] ips);
	}

	// @interface QNDnsManager : NSObject
	[BaseType (typeof(NSObject))]
	interface QNDnsManager
	{
		// -(NSArray *)query:(NSString *)domain;
		[Export ("query:")]
//		[Verify (StronglyTypedNSArray)]
		NSObject[] Query (string domain);

		// -(NSArray *)queryWithDomain:(QNDomain *)domain;
		[Export ("queryWithDomain:")]
//		[Verify (StronglyTypedNSArray)]
		NSObject[] QueryWithDomain (QNDomain domain);

		// -(void)onNetworkChange:(QNNetworkInfo *)netInfo;
		[Export ("onNetworkChange:")]
		void OnNetworkChange (QNNetworkInfo netInfo);

		// -(instancetype)init:(NSArray *)resolvers networkInfo:(QNNetworkInfo *)netInfo;
		[Export ("init:networkInfo:")]
//		[Verify (StronglyTypedNSArray)]
		IntPtr Constructor (NSObject[] resolvers, QNNetworkInfo netInfo);

		// -(instancetype)init:(NSArray *)resolvers networkInfo:(QNNetworkInfo *)netInfo sorter:(id<QNIpSorter>)sorter;
		[Export ("init:networkInfo:sorter:")]
//		[Verify (StronglyTypedNSArray)]
		IntPtr Constructor (NSObject[] resolvers, QNNetworkInfo netInfo, QNIpSorter sorter);

		// -(instancetype)putHosts:(NSString *)domain ip:(NSString *)ip;
		[Export ("putHosts:ip:")]
		QNDnsManager PutHosts (string domain, string ip);

		// -(instancetype)putHosts:(NSString *)domain ip:(NSString *)ip provider:(int)provider;
		[Export ("putHosts:ip:provider:")]
		QNDnsManager PutHosts (string domain, string ip, int provider);
	}

//	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const int kQNTypeA;
		[Field ("kQNTypeA", "__Internal")]
		int kQNTypeA { get; }

		// extern const int kQNTypeCname;
		[Field ("kQNTypeCname", "__Internal")]
		int kQNTypeCname { get; }
	}

	// @interface QNRecord : NSObject
	[BaseType (typeof(NSObject))]
	interface QNRecord
	{
		// @property (readonly, nonatomic) NSString * value;
		[Export ("value")]
		string Value { get; }

		// @property (readonly) int ttl;
		[Export ("ttl")]
		int Ttl { get; }

		// @property (readonly) int type;
		[Export ("type")]
		int Type { get; }

		// @property (readonly) long long timeStamp;
		[Export ("timeStamp")]
		long TimeStamp { get; }

		// -(instancetype)init:(NSString *)value ttl:(int)ttl type:(int)type;
		[Export ("init:ttl:type:")]
		IntPtr Constructor (string value, int ttl, int type);

		// -(BOOL)expired:(long long)time;
		[Export ("expired:")]
		bool Expired (long time);
	}

//	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const int kQNNO_NETWORK;
		[Field ("kQNNO_NETWORK", "__Internal")]
		int kQNNO_NETWORK { get; }

		// extern const int kQNWIFI;
		[Field ("kQNWIFI", "__Internal")]
		int kQNWIFI { get; }

		// extern const int kQNMOBILE;
		[Field ("kQNMOBILE", "__Internal")]
		int kQNMOBILE { get; }

		// extern const int kQNISP_GENERAL;
		[Field ("kQNISP_GENERAL", "__Internal")]
		int kQNISP_GENERAL { get; }

		// extern const int kQNISP_CTC;
		[Field ("kQNISP_CTC", "__Internal")]
		int kQNISP_CTC { get; }

		// extern const int kQNISP_DIANXIN;
		[Field ("kQNISP_DIANXIN", "__Internal")]
		int kQNISP_DIANXIN { get; }

		// extern const int kQNISP_CNC;
		[Field ("kQNISP_CNC", "__Internal")]
		int kQNISP_CNC { get; }

		// extern const int kQNISP_LIANTONG;
		[Field ("kQNISP_LIANTONG", "__Internal")]
		int kQNISP_LIANTONG { get; }

		// extern const int kQNISP_CMCC;
		[Field ("kQNISP_CMCC", "__Internal")]
		int kQNISP_CMCC { get; }

		// extern const int kQNISP_YIDONG;
		[Field ("kQNISP_YIDONG", "__Internal")]
		int kQNISP_YIDONG { get; }

		// extern const int kQNISP_OTHER;
		[Field ("kQNISP_OTHER", "__Internal")]
		int kQNISP_OTHER { get; }
	}

	// @interface QNNetworkInfo : NSObject
	[BaseType (typeof(NSObject))]
	interface QNNetworkInfo
	{
		// @property (readonly) int networkConnection;
		[Export ("networkConnection")]
		int NetworkConnection { get; }

		// @property (readonly) int provider;
		[Export ("provider")]
		int Provider { get; }

		// -(instancetype)init:(int)connecton provider:(int)provider;
		[Export ("init:provider:")]
		IntPtr Constructor (int connecton, int provider);

		// -(BOOL)isEqual:(id)other;
		[Export ("isEqual:")]
		bool IsEqual (NSObject other);

		// -(BOOL)isEqualToInfo:(QNNetworkInfo *)info;
		[Export ("isEqualToInfo:")]
		bool IsEqualToInfo (QNNetworkInfo info);

		// +(instancetype)noNet;
		[Static]
		[Export ("noNet")]
		QNNetworkInfo NoNet ();

		// +(instancetype)normal;
		[Static]
		[Export ("normal")]
		QNNetworkInfo Normal ();

		// +(BOOL)isNetworkChanged;
		[Static]
		[Export ("isNetworkChanged")]
//		[Verify (MethodToProperty)]
		bool IsNetworkChanged { get; }

		// +(NSString *)getIp;
		[Static]
		[Export ("getIp")]
//		[Verify (MethodToProperty)]
		string Ip { get; }
	}

	// @interface QNHijackingDetectWrapper : NSObject <QNResolverDelegate>
	[BaseType (typeof(NSObject))]
	interface QNHijackingDetectWrapper : IQNResolverDelegate
	{
		// -(NSArray *)query:(QNDomain *)domain networkInfo:(QNNetworkInfo *)netInfo error:(NSError **)error;
		[Export ("query:networkInfo:error:")]
//		[Verify (StronglyTypedNSArray)]
		NSObject[] Query (QNDomain domain, QNNetworkInfo netInfo, out NSError error);

		// -(instancetype)initWithResolver:(QNResolver *)resolver;
		[Export ("initWithResolver:")]
		IntPtr Constructor (QNResolver resolver);
	}

	// @interface QNDnspodFree : NSObject <QNResolverDelegate>
	[BaseType (typeof(NSObject))]
	interface QNDnspodFree : IQNResolverDelegate
	{
		// @property (readonly, strong) NSString * server;
		[Export ("server", ArgumentSemantic.Strong)]
		string Server { get; }

		// -(NSArray *)query:(QNDomain *)domain networkInfo:(QNNetworkInfo *)netInfo error:(NSError **)error;
		[Export ("query:networkInfo:error:")]
//		[Verify (StronglyTypedNSArray)]
		NSObject[] Query (QNDomain domain, QNNetworkInfo netInfo, out NSError error);

		// -(instancetype)initWithServer:(NSString *)server;
		[Export ("initWithServer:")]
		IntPtr Constructor (string server);
	}

	[Static]
//	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const int kQN_ENCRYPT_FAILED;
		[Field ("kQN_ENCRYPT_FAILED", "__Internal")]
		int kQN_ENCRYPT_FAILED { get; }

		// extern const int kQN_DECRYPT_FAILED;
		[Field ("kQN_DECRYPT_FAILED", "__Internal")]
		int kQN_DECRYPT_FAILED { get; }
	}

	// @interface QNDnspodEnterprise : NSObject <QNResolverDelegate>
	[BaseType (typeof(NSObject))]
	interface QNDnspodEnterprise : IQNResolverDelegate
	{
		// @property (readonly, strong) NSString * server;
		[Export ("server", ArgumentSemantic.Strong)]
		string Server { get; }

		// -(instancetype)initWithId:(NSString *)userId key:(NSString *)key;
		[Export ("initWithId:key:")]
		IntPtr Constructor (string userId, string key);

		// -(instancetype)initWithId:(NSString *)userId key:(NSString *)key server:(NSString *)server;
		[Export ("initWithId:key:server:")]
		IntPtr Constructor (string userId, string key, string server);

		// -(NSArray *)query:(QNDomain *)domain networkInfo:(QNNetworkInfo *)netInfo error:(NSError **)error;
		[Export ("query:networkInfo:error:")]
//		[Verify (StronglyTypedNSArray)]
		NSObject[] Query (QNDomain domain, QNNetworkInfo netInfo, out NSError error);
	}

//	[Static]
////	[Verify (ConstantsInterfaceAssociation)]
//	partial interface Constants
//	{
//		// extern const int kQN_ENCRYPT_FAILED;
//		[Field ("kQN_ENCRYPT_FAILED", "__Internal")]
//		int kQN_ENCRYPT_FAILED { get; }
//
//		// extern const int kQN_DECRYPT_FAILED;
//		[Field ("kQN_DECRYPT_FAILED", "__Internal")]
//		int kQN_DECRYPT_FAILED { get; }
//	}

	// @interface QNDes : NSObject
	[BaseType (typeof(NSObject))]
	interface QNDes
	{
		// -(NSData *)encrypt:(NSData *)input;
		[Export ("encrypt:")]
		NSData Encrypt (NSData input);

		// -(NSData *)decrpyt:(NSData *)input;
		[Export ("decrpyt:")]
		NSData Decrpyt (NSData input);

		// -(instancetype)init:(NSData *)key;
		[Export ("init:")]
		IntPtr Constructor (NSData key);
	}

	// @interface QNHex : NSObject
	[BaseType (typeof(NSObject))]
	interface QNHex
	{
		// +(NSString *)encodeHexData:(NSData *)data;
		[Static]
		[Export ("encodeHexData:")]
		string EncodeHexData (NSData data);

		// +(NSString *)encodeHexString:(NSString *)str;
		[Static]
		[Export ("encodeHexString:")]
		string EncodeHexString (string str);

		// +(NSData *)decodeHexString:(NSString *)hex;
		[Static]
		[Export ("decodeHexString:")]
		NSData DecodeHexString (string hex);

		// +(NSString *)decodeHexToString:(NSString *)hex;
		[Static]
		[Export ("decodeHexToString:")]
		string DecodeHexToString (string hex);
	}

	// @interface QNHosts : NSObject
	[BaseType (typeof(NSObject))]
	interface QNHosts
	{
		// -(NSArray *)query:(QNDomain *)domain networkInfo:(QNNetworkInfo *)netInfo;
		[Export ("query:networkInfo:")]
//		[Verify (StronglyTypedNSArray)]
		NSObject[] Query (QNDomain domain, QNNetworkInfo netInfo);

		// -(void)put:(NSString *)domain ip:(NSString *)ip;
		[Export ("put:ip:")]
		void Put (string domain, string ip);

		// -(void)put:(NSString *)domain ip:(NSString *)ip provider:(int)provider;
		[Export ("put:ip:provider:")]
		void Put (string domain, string ip, int provider);
	}

	// @interface QNTxtResolver : NSObject <QNResolverDelegate>
	[BaseType (typeof(NSObject))]
	interface QNTxtResolver : IQNResolverDelegate
	{
		// -(NSArray *)query:(QNDomain *)domain networkInfo:(QNNetworkInfo *)netInfo error:(NSError **)error;
		[Export ("query:networkInfo:error:")]
//		[Verify (StronglyTypedNSArray)]
		NSObject[] Query (QNDomain domain, QNNetworkInfo netInfo, out NSError error);

		// -(instancetype)initWithAddres:(NSString *)address;
		[Export ("initWithAddres:")]
		IntPtr Constructor (string address);
	}

}

