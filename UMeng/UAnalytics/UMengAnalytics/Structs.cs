using System;
using ObjCRuntime;

namespace UMengAnalytics
{
    public enum ReportPolicy : uint
    {
        Realtime = 0,
        Batch = 1,
        SendInterval = 6,
        SmartPolicy = 8
    }

    [Native]
    public enum eScenarioType : ulong
    {
        Normal = 0,
        Game = 1
    }
}

