using System.Runtime.InteropServices;

namespace QiniuSDK
{
	static class CFunctions
	{
	//	// extern void QNAsyncRun (QNRun run);
	//	[DllImport ("__Internal")]
	//[Verify (PlatformInvoke)]
	//static extern void QNAsyncRun (QNRun run);

	//// extern void QNAsyncRunInMain (QNRun run);
	//[DllImport ("__Internal")]
	//[Verify (PlatformInvoke)]
	//static extern void QNAsyncRunInMain (QNRun run);

	// extern BOOL hasNSURLSession ();
	[DllImport ("__Internal")]
	//[Verify (PlatformInvoke)]
	static extern bool hasNSURLSession ();

	// extern BOOL hasAts ();
	[DllImport ("__Internal")]
	//[Verify (PlatformInvoke)]
	static extern bool hasAts ();

	// extern BOOL allowsArbitraryLoads ();
	[DllImport ("__Internal")]
	//[Verify (PlatformInvoke)]
	static extern bool allowsArbitraryLoads ();

	// extern BOOL isIpV6FullySupported ();
	[DllImport ("__Internal")]
	//[Verify (PlatformInvoke)]
	static extern bool isIpV6FullySupported ();
	}
}

