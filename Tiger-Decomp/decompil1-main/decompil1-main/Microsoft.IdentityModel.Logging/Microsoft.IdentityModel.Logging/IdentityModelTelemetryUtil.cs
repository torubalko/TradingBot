using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;

namespace Microsoft.IdentityModel.Logging;

public static class IdentityModelTelemetryUtil
{
	internal const string skuTelemetry = "x-client-SKU";

	internal const string versionTelemetry = "x-client-Ver";

	internal static readonly List<string> defaultTelemetryValues = new List<string> { "x-client-SKU", "x-client-Ver" };

	internal static readonly ConcurrentDictionary<string, string> telemetryData = new ConcurrentDictionary<string, string>
	{
		["x-client-SKU"] = ClientSku,
		["x-client-Ver"] = ClientVer
	};

	public static string ClientSku => "ID_NET472";

	public static string ClientVer => typeof(IdentityModelTelemetryUtil).GetTypeInfo().Assembly.GetName().Version.ToString();

	public static bool AddTelemetryData(string key, string value)
	{
		if (string.IsNullOrEmpty(key))
		{
			LogHelper.LogArgumentNullException("key");
			return false;
		}
		if (string.IsNullOrEmpty(value))
		{
			LogHelper.LogArgumentNullException("value");
			return false;
		}
		if (defaultTelemetryValues.Contains(key))
		{
			LogHelper.LogExceptionMessage(new ArgumentException("MIML10003: Sku and version telemetry cannot be manipulated. They are added by default."));
			return false;
		}
		telemetryData[key] = value;
		return true;
	}

	public static bool RemoveTelemetryData(string key)
	{
		if (string.IsNullOrEmpty(key))
		{
			LogHelper.LogArgumentNullException("key");
			return false;
		}
		if (defaultTelemetryValues.Contains(key))
		{
			LogHelper.LogExceptionMessage(new ArgumentException("MIML10003: Sku and version telemetry cannot be manipulated. They are added by default."));
			return false;
		}
		string value;
		return telemetryData.TryRemove(key, out value);
	}

	internal static void SetTelemetryData(HttpRequestMessage request, IDictionary<string, string> additionalHeaders)
	{
		if (request == null)
		{
			return;
		}
		foreach (KeyValuePair<string, string> telemetryDatum in telemetryData)
		{
			((HttpHeaders)request.Headers).Remove(telemetryDatum.Key);
			((HttpHeaders)request.Headers).Add(telemetryDatum.Key, telemetryDatum.Value);
		}
		if (additionalHeaders == null)
		{
			return;
		}
		foreach (KeyValuePair<string, string> additionalHeader in additionalHeaders)
		{
			((HttpHeaders)request.Headers).Add(additionalHeader.Key, additionalHeader.Value);
		}
	}

	internal static bool UpdateDefaultTelemetryData(string key, string value)
	{
		if (string.IsNullOrEmpty(key))
		{
			LogHelper.LogArgumentNullException("key");
			return false;
		}
		if (string.IsNullOrEmpty(value))
		{
			LogHelper.LogArgumentNullException("value");
			return false;
		}
		telemetryData[key] = value;
		return true;
	}
}
