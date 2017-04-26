using System;
using ObjCRuntime;

namespace UMengMessage
{
        [Native]
    public enum kUMessageError : long
    {
        Unknown = 0,
        ResponseErr = 1,
        OperateErr = 2,
        ParamErr = 3,
        DependsErr = 4,
        ServerSetErr = 5
    }
}

