using System;

namespace UMengQQ.iOS
{
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
}

