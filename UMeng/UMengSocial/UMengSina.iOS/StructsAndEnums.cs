using System;
using ObjCRuntime;

namespace UMengSina.iOS
{
    public enum WBSDKRelationshipButtonState : uint
    {
        Follow,
        Unfollow
    }

    [Native]
    public enum WeiboSDKResponseStatusCode : long
    {
        Success = 0,
        UserCancel = -1,
        SentFail = -2,
        AuthDeny = -3,
        UserCancelInstall = -4,
        PayFail = -5,
        ShareInSDKFailed = -8,
        Unsupport = -99,
        Unknown = -100
    }
}

