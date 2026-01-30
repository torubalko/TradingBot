using System;

namespace Microsoft.ApplicationInsights.Extensibility.Implementation.Tracing;

internal class ThreadResourceLock : IDisposable
{
	[ThreadStatic]
	private static object syncObject;

	public static bool IsResourceLocked => syncObject != null;

	public ThreadResourceLock()
	{
		syncObject = new object();
	}

	public void Dispose()
	{
		syncObject = null;
	}
}
