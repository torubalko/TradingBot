using System.Globalization;
using Microsoft.ApplicationInsights.Channel;
using Microsoft.ApplicationInsights.DataContracts;

namespace Microsoft.ApplicationInsights.Extensibility.Implementation;

internal static class Telemetry
{
	public static void WriteEnvelopeProperties(this ITelemetry telemetry, IJsonWriter json)
	{
		json.WriteProperty("time", telemetry.Timestamp.UtcDateTime.ToString("o", CultureInfo.InvariantCulture));
		if (telemetry is ISupportSampling { SamplingPercentage: not null, SamplingPercentage: var samplingPercentage } supportSampling && samplingPercentage.Value > 1E-12 && supportSampling.SamplingPercentage.Value < 99.999999999999)
		{
			json.WriteProperty("sampleRate", supportSampling.SamplingPercentage.Value);
		}
		json.WriteProperty("seq", telemetry.Sequence);
		WriteTelemetryContext(json, telemetry.Context);
	}

	public static void WriteTelemetryName(this ITelemetry telemetry, IJsonWriter json, string telemetryName)
	{
		bool result = false;
		if (telemetry is ISupportProperties supportProperties && supportProperties.Properties.TryGetValue("DeveloperMode", out var value))
		{
			bool.TryParse(value, out result);
		}
		string value2 = string.Format(CultureInfo.InvariantCulture, "{0}{1}{2}", result ? "Microsoft.ApplicationInsights.Dev." : "Microsoft.ApplicationInsights.", NormalizeInstrumentationKey(telemetry.Context.InstrumentationKey), telemetryName);
		json.WriteProperty("name", value2);
	}

	public static void WriteTelemetryContext(IJsonWriter json, TelemetryContext context)
	{
		if (context != null)
		{
			json.WriteProperty("iKey", context.InstrumentationKey);
			json.WriteProperty("tags", context.Tags);
		}
	}

	private static string NormalizeInstrumentationKey(string instrumentationKey)
	{
		if (instrumentationKey.IsNullOrWhiteSpace())
		{
			return string.Empty;
		}
		return instrumentationKey.Replace("-", string.Empty).ToLowerInvariant() + ".";
	}
}
