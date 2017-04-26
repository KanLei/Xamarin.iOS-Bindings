using System;
using System.Runtime.InteropServices;
using Foundation;

namespace BugtagsBinding.iOS
{
    public enum BTGInvocationEvent : uint
    {
        None,
        Shake,
        Bubble
    }

    public enum BTGDataMode : uint
    {
        Production,
        Testing,
        Local
    }

    public enum BTGRemoteConfigState : uint
    {
        None,
        LoadedFromCache,
        LoadedFromRemote
    }

    public enum BTGHotfixState : uint
    {
        None,
        ExecutedFromCache,
        ExecutedFromRemote,
        Update,
        UpdateDone
    }

    static class CFunctions
    {
        // extern void BTGLog (NSString *format, ...) __attribute__((format(NSString, 1, 2)));
        [DllImport ("__Internal")]
        static extern void BTGLog (NSString format, IntPtr varArgs);
    }
}

