using System;
using ObjCRuntime;

namespace MJRefresh
{
	[Native]
	public enum MJRefreshState : ulong
	{
	    Idle = 1,
	    Pulling,
	    Refreshing,
	    WillRefresh,
	    NoMoreData
	}
}
