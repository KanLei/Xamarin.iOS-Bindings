using System;
using System.Runtime.InteropServices;
using ObjCRuntime;

namespace ALITrade.iOS
{
    static class CFunctions
    {
        // extern int tbim_check_debugger ();
        [DllImport ("__Internal")]
        static extern int tbim_check_debugger ();
    }

    [Native]
    public enum MsgBusItemType : long
    {
        Filter,
        Top,
        Normal
    }

    [Native]
    public enum ALiEnvironment : long
    {
        None = -1,
        Daily = 0,
        PreRelease,
        Release
    }

    [Native]
    public enum AlibcTradeError : ulong
    {
        ProcessFailed = 3001,
        Cancelled = 3002,
        PaymentFailed = 3003,
        InvalidItemID = 3004,
        NullPageURL = 3005,
        InvalidShopID = 3006
    }

    [Native]
    public enum ALiTradeResultType : ulong
    {
        AddCard,
        PaySuccess
    }

    [Native]
    public enum ALiOpenType : ulong
    {
        Auto,
        Native,
        H5
    }
}

