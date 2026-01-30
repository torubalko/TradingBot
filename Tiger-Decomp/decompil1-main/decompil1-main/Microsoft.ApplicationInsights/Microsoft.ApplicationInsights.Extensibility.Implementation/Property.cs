using System;
using System.Collections.Generic;
using Microsoft.ApplicationInsights.DataContracts;
using Microsoft.ApplicationInsights.Extensibility.Implementation.External;

namespace Microsoft.ApplicationInsights.Extensibility.Implementation;

internal static class Property
{
	public const int MaxDictionaryNameLength = 150;

	public const int MaxDependencyTypeLength = 1024;

	public const int MaxValueLength = 8192;

	public const int MaxResultCodeLength = 1024;

	public const int MaxEventNameLength = 512;

	public const int MaxNameLength = 1024;

	public const int MaxMessageLength = 32768;

	public const int MaxUrlLength = 2048;

	public const int MaxDataLength = 8192;

	public const int MaxTestNameLength = 1024;

	public const int MaxRunLocationLength = 2024;

	public const int MaxAvailabilityMessageLength = 8192;

	public static readonly IDictionary<string, int> TagSizeLimits = new Dictionary<string, int>
	{
		{
			ContextTagKeys.Keys.ApplicationVersion,
			1024
		},
		{
			ContextTagKeys.Keys.DeviceId,
			1024
		},
		{
			ContextTagKeys.Keys.DeviceModel,
			256
		},
		{
			ContextTagKeys.Keys.DeviceOEMName,
			256
		},
		{
			ContextTagKeys.Keys.DeviceOSVersion,
			256
		},
		{
			ContextTagKeys.Keys.DeviceType,
			64
		},
		{
			ContextTagKeys.Keys.LocationIp,
			45
		},
		{
			ContextTagKeys.Keys.OperationId,
			128
		},
		{
			ContextTagKeys.Keys.OperationName,
			1024
		},
		{
			ContextTagKeys.Keys.OperationParentId,
			128
		},
		{
			ContextTagKeys.Keys.OperationSyntheticSource,
			1024
		},
		{
			ContextTagKeys.Keys.OperationCorrelationVector,
			64
		},
		{
			ContextTagKeys.Keys.SessionId,
			64
		},
		{
			ContextTagKeys.Keys.UserId,
			128
		},
		{
			ContextTagKeys.Keys.UserAccountId,
			1024
		},
		{
			ContextTagKeys.Keys.UserAgent,
			2048
		},
		{
			ContextTagKeys.Keys.UserAuthUserId,
			1024
		},
		{
			ContextTagKeys.Keys.CloudRole,
			256
		},
		{
			ContextTagKeys.Keys.CloudRoleInstance,
			256
		},
		{
			ContextTagKeys.Keys.InternalSdkVersion,
			64
		},
		{
			ContextTagKeys.Keys.InternalAgentVersion,
			64
		},
		{
			ContextTagKeys.Keys.InternalNodeName,
			256
		}
	};

	public static void Set<T>(ref T property, T value) where T : class
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		property = value;
	}

	public static void Initialize<T>(ref T? property, T? value) where T : struct
	{
		if (!property.HasValue)
		{
			property = value;
		}
	}

	public static void Initialize(ref string property, string value)
	{
		if (string.IsNullOrEmpty(property))
		{
			property = value;
		}
	}

	public static string SanitizeEventName(this string name)
	{
		return TrimAndTruncate(name, 512);
	}

	public static string SanitizeName(this string name)
	{
		return TrimAndTruncate(name, 1024);
	}

	public static string SanitizeDependencyType(this string value)
	{
		return TrimAndTruncate(value, 1024);
	}

	public static string SanitizeResultCode(this string value)
	{
		return TrimAndTruncate(value, 1024);
	}

	public static string SanitizeValue(this string value)
	{
		return TrimAndTruncate(value, 8192);
	}

	public static string SanitizeMessage(this string message)
	{
		return TrimAndTruncate(message, 32768);
	}

	public static string SanitizeData(this string message)
	{
		return TrimAndTruncate(message, 8192);
	}

	public static Uri SanitizeUri(this Uri uri)
	{
		if (uri != null)
		{
			string text = uri.ToString();
			if (text.Length > 2048)
			{
				text = text.Substring(0, 2048);
				if (Uri.TryCreate(text, UriKind.RelativeOrAbsolute, out var result))
				{
					uri = result;
				}
			}
		}
		return uri;
	}

	public static string SanitizeTestName(this string value)
	{
		return TrimAndTruncate(value, 1024);
	}

	public static string SanitizeRunLocation(this string value)
	{
		return TrimAndTruncate(value, 2024);
	}

	public static string SanitizeAvailabilityMessage(this string value)
	{
		return TrimAndTruncate(value, 8192);
	}

	public static void SanitizeTelemetryContext(this TelemetryContext telemetryContext)
	{
		IDictionary<string, string> tags = telemetryContext.Tags;
		foreach (KeyValuePair<string, string> item in tags)
		{
			if (TagSizeLimits.TryGetValue(item.Key, out var value) && item.Value != null && item.Value.Length > value)
			{
				tags[item.Key] = TrimAndTruncate(item.Value, value);
			}
		}
	}

	public static void SanitizeProperties(this IDictionary<string, string> dictionary)
	{
		if (dictionary == null)
		{
			return;
		}
		Dictionary<string, KeyValuePair<string, string>> dictionary2 = new Dictionary<string, KeyValuePair<string, string>>(dictionary.Count);
		foreach (KeyValuePair<string, string> item in dictionary)
		{
			string text = SanitizeKey(item.Key);
			string text2 = item.Value.SanitizeValue();
			if (string.IsNullOrEmpty(text2) || string.CompareOrdinal(text, item.Key) != 0 || string.CompareOrdinal(text2, item.Value) != 0)
			{
				dictionary2.Add(item.Key, new KeyValuePair<string, string>(text, text2));
			}
		}
		foreach (KeyValuePair<string, KeyValuePair<string, string>> item2 in dictionary2)
		{
			dictionary.Remove(item2.Key);
			if (!string.IsNullOrEmpty(item2.Value.Value))
			{
				string key = MakeKeyUnique(item2.Value.Key, dictionary);
				dictionary.Add(key, item2.Value.Value);
			}
		}
	}

	public static void SanitizeMeasurements(this IDictionary<string, double> dictionary)
	{
		if (dictionary == null)
		{
			return;
		}
		Dictionary<string, KeyValuePair<string, double>> dictionary2 = new Dictionary<string, KeyValuePair<string, double>>(dictionary.Count);
		foreach (KeyValuePair<string, double> item in dictionary)
		{
			string text = SanitizeKey(item.Key);
			bool valueChanged;
			double value = Utils.SanitizeNanAndInfinity(item.Value, out valueChanged);
			if (string.CompareOrdinal(text, item.Key) != 0 || valueChanged)
			{
				dictionary2.Add(item.Key, new KeyValuePair<string, double>(text, value));
			}
		}
		foreach (KeyValuePair<string, KeyValuePair<string, double>> item2 in dictionary2)
		{
			dictionary.Remove(item2.Key);
			string key = MakeKeyUnique(item2.Value.Key, dictionary);
			dictionary.Add(key, item2.Value.Value);
		}
	}

	private static string TrimAndTruncate(string value, int maxLength)
	{
		if (value != null)
		{
			value = value.Trim();
			value = Truncate(value, maxLength);
		}
		return value;
	}

	private static string Truncate(string value, int maxLength)
	{
		if (value.Length <= maxLength)
		{
			return value;
		}
		return value.Substring(0, maxLength);
	}

	private static string SanitizeKey(string key)
	{
		return MakeKeyNonEmpty(TrimAndTruncate(key, 150));
	}

	private static string MakeKeyNonEmpty(string key)
	{
		if (!string.IsNullOrEmpty(key))
		{
			return key;
		}
		return "required";
	}

	private static string MakeKeyUnique<TValue>(string key, IDictionary<string, TValue> dictionary)
	{
		if (dictionary.ContainsKey(key))
		{
			string text = Truncate(key, 147);
			int num = 1;
			do
			{
				key = text + num;
				num++;
			}
			while (dictionary.ContainsKey(key));
		}
		return key;
	}
}
