using System;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace UMengSocial
{
    #region UMSocial

   [Native]
public enum UMSocialPlatformErrorType : long
{
    Unknow = 2000,
    NotSupport = 2001,
    AuthorizeFailed = 2002,
    ShareFailed = 2003,
    RequestForUserProfileFailed = 2004,
    ShareDataNil = 2005,
    ShareDataTypeIllegal = 2006,
    CheckUrlSchemaFail = 2007,
    NotInstall = 2008,
    Cancel = 2009,
    NotNetWork = 2010,
    SourceError = 2011,
    ProtocolNotOverride = 2013,
    NotUsingHttps = 2014
}

[Native]
public enum UMSocialPlatformFeature : ulong
{
    None = 0,
    IsAppInstalled = 1 << 0,
    IsCanOpenApp = 1 << 1,
    IsAppApiSupport = 1 << 2,
    IsCanAuthorize = 1 << 10,
    IsCanWebViewAuthorize = 1 << 11,
    IsCanShare_Text = 1 << 22,
    IsCanShare_Image = 1 << 23,
    IsCanShare_Media = 1 << 24,
    IsCanShare_TextAndImage = 1 << 25,
    IsCanShare_TextAndMedia = 1 << 26,
    Mask = 4294967295L
}

[Native]
public enum UMSocialPlatformType : long
{
    UnKnown = -2,
    Predefine_Begin = -1,
    Sina = 0,
    WechatSession = 1,
    WechatTimeLine = 2,
    WechatFavorite = 3,
    Qq = 4,
    Qzone = 5,
    TencentWb = 6,
    AlipaySession = 7,
    YixinSession = 8,
    YixinTimeLine = 9,
    YixinFavorite = 10,
    LaiWangSession = 11,
    LaiWangTimeLine = 12,
    Sms = 13,
    Email = 14,
    Renren = 15,
    Facebook = 16,
    Twitter = 17,
    Douban = 18,
    KakaoTalk = 19,
    Pinterest = 20,
    Line = 21,
    Linkedin = 22,
    Flickr = 23,
    Tumblr = 24,
    Instagram = 25,
    Whatsapp = 26,
    DingDing = 27,
    Predefine_end = 999,
    UserDefine_Begin = 1000,
    UserDefine_End = 2000
}

static class CFunctions
{
    // extern void setGlobalLogLevelString (NSString *levelString);
    [DllImport ("__Internal")]
    static extern void setGlobalLogLevelString (NSString levelString);

    // extern NSString * getGlobalLogLevelString ();
    [DllImport ("__Internal")]
    static extern NSString getGlobalLogLevelString ();

    // extern void UMSocialLog (NSString *flagString, const char *file, const char *function, NSUInteger line, NSString *format, ...) __attribute__((format(NSString, 5, 6)));
    [DllImport ("__Internal")]
    static extern unsafe void UMSocialLog (NSString flagString, sbyte* file, sbyte* function, nuint line, NSString format, IntPtr varArgs);
}
    #endregion

    #region QQ

    public enum QQApiSendResultCode
    {
        Sendsucess = 0,
        Qqnotinstalled = 1,
        Qqnotsupportapi = 2,
        Messagetypeinvalid = 3,
        Messagecontentnull = 4,
        Messagecontentinvalid = 5,
        Appnotregisted = 6,
        Appshareasync = 7,
        QqnotsupportapiWithErrorshow = 8,
        Sendfaild = -1,
        Qzonenotsupporttext = 10000,
        Qzonenotsupportimage = 10001
    }

    public enum kQQAPICtrlFlagQ : uint
    {
        ZoneShareOnStart = 1,
        ZoneShareForbid = 2,
        QShare = 4,
        QShareFavorites = 8,
        QShareDataline = 16
    }

    public enum QQApiURLTargetType : uint
    {
        NotSpecified = 0,
        Audio = 1,
        Video = 2,
        News = 3
    }

    public enum QQApiInterfaceReqType : uint
    {
        Getmessagefromqqreqtype = 0,
        Sendmessagetoqqreqtype = 1,
        Showmessagefromqqreqtype = 2
    }

    public enum QQApiInterfaceRespType : uint
    {
        Showmessagefromqqresptype = 0,
        Getmessagefromqqresptype = 1,
        Sendmessagetoqqresptype = 2
    }

    #endregion

    #region Sina

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

    #endregion
}

