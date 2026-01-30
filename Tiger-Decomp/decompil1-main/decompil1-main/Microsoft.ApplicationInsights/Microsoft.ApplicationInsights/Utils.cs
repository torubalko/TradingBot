using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Microsoft.ApplicationInsights.Extensibility.Implementation.Tracing;

namespace Microsoft.ApplicationInsights;

internal static class Utils
{
	public static bool IsNullOrWhiteSpace(this string value)
	{
		return value?.All(char.IsWhiteSpace) ?? true;
	}

	public static void CopyDictionary<TValue>(IDictionary<string, TValue> source, IDictionary<string, TValue> target)
	{
		foreach (KeyValuePair<string, TValue> item in source)
		{
			if (!string.IsNullOrEmpty(item.Key) && !target.ContainsKey(item.Key))
			{
				target[item.Key] = item.Value;
			}
		}
	}

	public static string PopulateRequiredStringValue(string value, string parameterName, string telemetryType)
	{
		if (string.IsNullOrEmpty(value))
		{
			CoreEventSource.Log.PopulateRequiredStringWithValue(parameterName, telemetryType);
			return "n/a";
		}
		return value;
	}

	public static TimeSpan ValidateDuration(string value)
	{
		if (!TimeSpan.TryParse(value, CultureInfo.InvariantCulture, out var result))
		{
			CoreEventSource.Log.TelemetryIncorrectDuration();
			return TimeSpan.Zero;
		}
		return result;
	}

	public static DateTimeOffset ValidateDateTimeOffset(string value)
	{
		if (!DateTimeOffset.TryParse(value, CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal, out var result))
		{
			return DateTimeOffset.MinValue;
		}
		return result;
	}

	public static double SanitizeNanAndInfinity(double value)
	{
		bool valueChanged;
		return SanitizeNanAndInfinity(value, out valueChanged);
	}

	public static double SanitizeNanAndInfinity(double value, out bool valueChanged)
	{
		valueChanged = false;
		if (double.IsInfinity(value) || double.IsNaN(value))
		{
			value = 0.0;
			valueChanged = true;
		}
		return value;
	}
}
