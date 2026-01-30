using System;
using EDugZvNwF6e5LYsQZ3C5;
using nff6NvN8pYC4xeKDOd05;

namespace TigerTrade.Core.Utils.Time;

public static class StaticFunctions
{
	private static StaticFunctions MYhqlUk2VwZolqUeksxR;

	public static DateTime Round(this DateTime datetime, TimeSpan roundingInterval)
	{
		return new DateTime((datetime - DateTime.MinValue).Ticks / roundingInterval.Ticks * roundingInterval.Ticks);
	}

	public static DateTime Round(this DateTime datetime, TimeSpan roundingInterval, TimeSpan offset)
	{
		return new DateTime(k01y3Uk2Khvcd1JhRcIw(datetime, offset).Ticks / roundingInterval.Ticks * roundingInterval.Ticks + offset.Ticks);
	}

	static StaticFunctions()
	{
		RUVZnUNwJg2VA9xTOL2q.hFyN7BZEP4e();
		a3PXAGN83gwBrevdAXnH.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool LQIeoZk2CuvhljZeOlnj()
	{
		return MYhqlUk2VwZolqUeksxR == null;
	}

	internal static StaticFunctions eBKNwAk2rHcKK6NXkQU1()
	{
		return MYhqlUk2VwZolqUeksxR;
	}

	internal static DateTime k01y3Uk2Khvcd1JhRcIw(DateTime P_0, TimeSpan P_1)
	{
		return P_0 - P_1;
	}
}
