using System;

namespace Microsoft.IdentityModel.Tokens;

public static class DateTimeUtil
{
	public static DateTime Add(DateTime time, TimeSpan timespan)
	{
		if (timespan == TimeSpan.Zero)
		{
			return time;
		}
		if (timespan > TimeSpan.Zero && DateTime.MaxValue - time <= timespan)
		{
			return GetMaxValue(time.Kind);
		}
		if (timespan < TimeSpan.Zero && DateTime.MinValue - time >= timespan)
		{
			return GetMinValue(time.Kind);
		}
		return time + timespan;
	}

	public static DateTime GetMaxValue(DateTimeKind kind)
	{
		if (kind == DateTimeKind.Unspecified)
		{
			return new DateTime(DateTime.MaxValue.Ticks, DateTimeKind.Utc);
		}
		return new DateTime(DateTime.MaxValue.Ticks, kind);
	}

	public static DateTime GetMinValue(DateTimeKind kind)
	{
		if (kind == DateTimeKind.Unspecified)
		{
			return new DateTime(DateTime.MinValue.Ticks, DateTimeKind.Utc);
		}
		return new DateTime(DateTime.MinValue.Ticks, kind);
	}

	public static DateTime? ToUniversalTime(DateTime? value)
	{
		if (!value.HasValue || value.Value.Kind == DateTimeKind.Utc)
		{
			return value;
		}
		return ToUniversalTime(value.Value);
	}

	public static DateTime ToUniversalTime(DateTime value)
	{
		if (value.Kind == DateTimeKind.Utc)
		{
			return value;
		}
		return value.ToUniversalTime();
	}
}
