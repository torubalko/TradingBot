using System;
using Org.BouncyCastle.Utilities.Date;

namespace Org.BouncyCastle.Tls;

internal class Timeout
{
	private long durationMillis;

	private long startMillis;

	internal Timeout(long durationMillis)
		: this(durationMillis, DateTimeUtilities.CurrentUnixMs())
	{
	}

	internal Timeout(long durationMillis, long currentTimeMillis)
	{
		this.durationMillis = System.Math.Max(0L, durationMillis);
		startMillis = System.Math.Max(0L, currentTimeMillis);
	}

	internal long RemainingMillis(long currentTimeMillis)
	{
		lock (this)
		{
			if (startMillis > currentTimeMillis)
			{
				startMillis = currentTimeMillis;
				return durationMillis;
			}
			long elapsed = currentTimeMillis - startMillis;
			long remaining = durationMillis - elapsed;
			if (remaining <= 0)
			{
				return durationMillis = 0L;
			}
			return remaining;
		}
	}

	internal static int ConstrainWaitMillis(int waitMillis, Timeout timeout, long currentTimeMillis)
	{
		if (waitMillis < 0)
		{
			return -1;
		}
		int timeoutMillis = GetWaitMillis(timeout, currentTimeMillis);
		if (timeoutMillis < 0)
		{
			return -1;
		}
		if (waitMillis == 0)
		{
			return timeoutMillis;
		}
		if (timeoutMillis == 0)
		{
			return waitMillis;
		}
		return System.Math.Min(waitMillis, timeoutMillis);
	}

	internal static Timeout ForWaitMillis(int waitMillis)
	{
		return ForWaitMillis(waitMillis, DateTimeUtilities.CurrentUnixMs());
	}

	internal static Timeout ForWaitMillis(int waitMillis, long currentTimeMillis)
	{
		if (waitMillis < 0)
		{
			throw new ArgumentException("cannot be negative", "waitMillis");
		}
		if (waitMillis > 0)
		{
			return new Timeout(waitMillis, currentTimeMillis);
		}
		return null;
	}

	internal static int GetWaitMillis(Timeout timeout, long currentTimeMillis)
	{
		if (timeout == null)
		{
			return 0;
		}
		long remainingMillis = timeout.RemainingMillis(currentTimeMillis);
		if (remainingMillis < 1)
		{
			return -1;
		}
		if (remainingMillis > int.MaxValue)
		{
			return int.MaxValue;
		}
		return (int)remainingMillis;
	}

	internal static bool HasExpired(Timeout timeout)
	{
		return HasExpired(timeout, DateTimeUtilities.CurrentUnixMs());
	}

	internal static bool HasExpired(Timeout timeout, long currentTimeMillis)
	{
		if (timeout != null)
		{
			return timeout.RemainingMillis(currentTimeMillis) < 1;
		}
		return false;
	}
}
