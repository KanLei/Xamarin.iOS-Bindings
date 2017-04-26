using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;

namespace MPShareBinding
{
    // @protocol MPSDKProtocol <NSObject>
    [Protocol, Model]
    [BaseType (typeof (NSObject))]
    interface MPSDKProtocol
    {
        // @optional -(void)shareToMeipaiDidSucceed:(BOOL)success;
        [Export ("shareToMeipaiDidSucceed:")]
        void ShareToMeipaiDidSucceed (bool success);
    }

    // @interface MPShareSDK : NSObject
    [BaseType (typeof (NSObject))]
    interface MPShareSDK
    {
        // +(void)registerApp:(NSString *)appKey;
        [Static]
        [Export ("registerApp:")]
        void RegisterApp (string appKey);

        // +(BOOL)isMeipaiInstalled;
        [Static]
        [Export ("isMeipaiInstalled")]
        bool IsMeipaiInstalled { get; }

        // +(BOOL)isMeipaiSupportVideoSharing;
        [Static]
        [Export ("isMeipaiSupportVideoSharing")]
        bool IsMeipaiSupportVideoSharing { get; }

        // +(BOOL)isMeipaiSupportPhotoSharing;
        [Static]
        [Export ("isMeipaiSupportPhotoSharing")]
        bool IsMeipaiSupportPhotoSharing { get; }

        // +(void)shareVideoAtPathToMeiPai:(NSURL *)pathURL;
        [Static]
        [Export ("shareVideoAtPathToMeiPai:")]
        void ShareVideoAtPathToMeiPai (NSUrl pathURL);

        // +(void)sharePhotoAtPathToMeiPai:(NSURL *)pathURL;
        [Static]
        [Export ("sharePhotoAtPathToMeiPai:")]
        void SharePhotoAtPathToMeiPai (NSUrl pathURL);

        // +(BOOL)handleOpenURL:(NSURL *)url delegate:(id<MPSDKProtocol>)delegate;
        [Static]
        [Export ("handleOpenURL:delegate:")]
        bool HandleOpenURL (NSUrl url, MPSDKProtocol @delegate);

        // +(BOOL)isMeipaiSupportSharing __attribute__((deprecated("Use isMeipaiSupportVideoSharing instead. Deprecated in version 1.0")));
        [Static]
        [Export ("isMeipaiSupportSharing")]
        bool IsMeipaiSupportSharing { get; }
    }

}
