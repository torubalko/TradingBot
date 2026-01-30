using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Text;
using Microsoft.ApplicationInsights.Channel;
using Microsoft.ApplicationInsights.DataContracts;
using Microsoft.ApplicationInsights.Extensibility.Implementation.External;
using Microsoft.ApplicationInsights.Extensibility.Implementation.Tracing;

namespace Microsoft.ApplicationInsights.Extensibility.Implementation;

[EditorBrowsable(EditorBrowsableState.Never)]
public static class JsonSerializer
{
	private static readonly UTF8Encoding TransmissionEncoding = new UTF8Encoding(encoderShouldEmitUTF8Identifier: false);

	public static string CompressionType => "gzip";

	public static string ContentType => "application/x-json-stream";

	[SuppressMessage("Microsoft.Usage", "CA2202:Do not dispose objects multiple times", Justification = "Disposing a MemoryStream multiple times is harmless.")]
	public static byte[] Serialize(IEnumerable<ITelemetry> telemetryItems, bool compress = true)
	{
		MemoryStream memoryStream = new MemoryStream();
		using (Stream stream = (compress ? CreateCompressedStream(memoryStream) : memoryStream))
		{
			using StreamWriter streamWriter = new StreamWriter(stream, TransmissionEncoding);
			SeializeToStream(telemetryItems, streamWriter);
		}
		return memoryStream.ToArray();
	}

	[SuppressMessage("Microsoft.Usage", "CA2202:Do not dispose objects multiple times", Justification = "Disposing a MemoryStream multiple times is harmless.")]
	public static byte[] ConvertToByteArray(string telemetryItems, bool compress = true)
	{
		if (string.IsNullOrEmpty(telemetryItems))
		{
			throw new ArgumentNullException("telemetryItems");
		}
		MemoryStream memoryStream = new MemoryStream();
		using (Stream stream = (compress ? CreateCompressedStream(memoryStream) : memoryStream))
		{
			using StreamWriter streamWriter = new StreamWriter(stream, TransmissionEncoding);
			streamWriter.Write(telemetryItems);
		}
		return memoryStream.ToArray();
	}

	public static string Deserialize(byte[] telemetryItemsData, bool compress = true)
	{
		MemoryStream memoryStream = new MemoryStream(telemetryItemsData);
		using Stream stream = (compress ? ((Stream)new GZipStream(memoryStream, CompressionMode.Decompress)) : ((Stream)memoryStream));
		using MemoryStream memoryStream2 = new MemoryStream();
		stream.CopyTo(memoryStream2);
		byte[] array = memoryStream2.ToArray();
		return Encoding.UTF8.GetString(array, 0, array.Length);
	}

	[SuppressMessage("Microsoft.Usage", "CA2202:Do not dispose objects multiple times", Justification = "Disposing a MemoryStream multiple times is harmless.")]
	internal static byte[] Serialize(ITelemetry telemetryItem, bool compress = true)
	{
		return Serialize(new ITelemetry[1] { telemetryItem }, compress);
	}

	internal static string SerializeAsString(IEnumerable<ITelemetry> telemetryItems)
	{
		StringBuilder stringBuilder = new StringBuilder();
		using StringWriter streamWriter = new StringWriter(stringBuilder, CultureInfo.InvariantCulture);
		SeializeToStream(telemetryItems, streamWriter);
		return stringBuilder.ToString();
	}

	internal static string SerializeAsString(ITelemetry telemetry)
	{
		return SerializeAsString(new ITelemetry[1] { telemetry });
	}

	private static void SerializeExceptions(IEnumerable<ExceptionDetails> exceptions, IJsonWriter writer)
	{
		int num = 0;
		foreach (ExceptionDetails exception in exceptions)
		{
			if (num++ != 0)
			{
				writer.WriteComma();
			}
			writer.WriteStartObject();
			writer.WriteProperty("id", exception.id);
			if (exception.outerId != 0)
			{
				writer.WriteProperty("outerId", exception.outerId);
			}
			writer.WriteProperty("typeName", Utils.PopulateRequiredStringValue(exception.typeName, "typeName", typeof(ExceptionTelemetry).FullName));
			writer.WriteProperty("message", Utils.PopulateRequiredStringValue(exception.message, "message", typeof(ExceptionTelemetry).FullName));
			if (exception.hasFullStack)
			{
				writer.WriteProperty("hasFullStack", exception.hasFullStack);
			}
			writer.WriteProperty("stack", exception.stack);
			if (exception.parsedStack.Count > 0)
			{
				writer.WritePropertyName("parsedStack");
				writer.WriteStartArray();
				int num2 = 0;
				foreach (StackFrame item in exception.parsedStack)
				{
					if (num2++ != 0)
					{
						writer.WriteComma();
					}
					writer.WriteStartObject();
					SerializeStackFrame(item, writer);
					writer.WriteEndObject();
				}
				writer.WriteEndArray();
			}
			writer.WriteEndObject();
		}
	}

	private static void SerializeStackFrame(StackFrame frame, IJsonWriter writer)
	{
		writer.WriteProperty("level", frame.level);
		writer.WriteProperty("method", Utils.PopulateRequiredStringValue(frame.method, "StackFrameMethod", typeof(ExceptionTelemetry).FullName));
		writer.WriteProperty("assembly", frame.assembly);
		writer.WriteProperty("fileName", frame.fileName);
		if (frame.line != 0)
		{
			writer.WriteProperty("line", frame.line);
		}
	}

	private static Stream CreateCompressedStream(Stream stream)
	{
		return new GZipStream(stream, CompressionMode.Compress);
	}

	private static void SerializeTelemetryItem(ITelemetry telemetryItem, JsonWriter jsonWriter)
	{
		if (telemetryItem is EventTelemetry)
		{
			SerializeEventTelemetry(telemetryItem as EventTelemetry, jsonWriter);
			return;
		}
		if (telemetryItem is ExceptionTelemetry)
		{
			SerializeExceptionTelemetry(telemetryItem as ExceptionTelemetry, jsonWriter);
			return;
		}
		if (telemetryItem is MetricTelemetry)
		{
			SerializeMetricTelemetry(telemetryItem as MetricTelemetry, jsonWriter);
			return;
		}
		if (telemetryItem is PageViewTelemetry)
		{
			SerializePageViewTelemetry(telemetryItem as PageViewTelemetry, jsonWriter);
			return;
		}
		if (telemetryItem is DependencyTelemetry)
		{
			SerializeDependencyTelemetry(telemetryItem as DependencyTelemetry, jsonWriter);
			return;
		}
		if (telemetryItem is RequestTelemetry)
		{
			SerializeRequestTelemetry(telemetryItem as RequestTelemetry, jsonWriter);
			return;
		}
		if (telemetryItem is SessionStateTelemetry)
		{
			SerializeEventTelemetry((telemetryItem as SessionStateTelemetry).Data, jsonWriter);
			return;
		}
		if (telemetryItem is TraceTelemetry)
		{
			SerializeTraceTelemetry(telemetryItem as TraceTelemetry, jsonWriter);
			return;
		}
		if (telemetryItem is PerformanceCounterTelemetry)
		{
			SerializeMetricTelemetry((telemetryItem as PerformanceCounterTelemetry).Data, jsonWriter);
			return;
		}
		if (telemetryItem is AvailabilityTelemetry)
		{
			SerializeAvailability(telemetryItem as AvailabilityTelemetry, jsonWriter);
			return;
		}
		string msg = string.Format(CultureInfo.InvariantCulture, "Unknown telemtry type: {0}", telemetryItem.GetType());
		CoreEventSource.Log.LogVerbose(msg);
	}

	private static void SeializeToStream(IEnumerable<ITelemetry> telemetryItems, TextWriter streamWriter)
	{
		JsonWriter jsonWriter = new JsonWriter(streamWriter);
		int num = 0;
		foreach (ITelemetry telemetryItem in telemetryItems)
		{
			if (num++ > 0)
			{
				streamWriter.Write(Environment.NewLine);
			}
			telemetryItem.Sanitize();
			SerializeTelemetryItem(telemetryItem, jsonWriter);
		}
	}

	private static void SerializeEventTelemetry(EventTelemetry eventTelemetry, JsonWriter writer)
	{
		writer.WriteStartObject();
		eventTelemetry.WriteTelemetryName(writer, "Event");
		eventTelemetry.WriteEnvelopeProperties(writer);
		writer.WritePropertyName("data");
		writer.WriteStartObject();
		writer.WriteProperty("baseType", eventTelemetry.BaseType);
		writer.WritePropertyName("baseData");
		writer.WriteStartObject();
		writer.WriteProperty("ver", eventTelemetry.Data.ver);
		writer.WriteProperty("name", eventTelemetry.Data.name);
		writer.WriteProperty("measurements", eventTelemetry.Data.measurements);
		writer.WriteProperty("properties", eventTelemetry.Data.properties);
		writer.WriteEndObject();
		writer.WriteEndObject();
		writer.WriteEndObject();
	}

	private static void SerializeExceptionTelemetry(ExceptionTelemetry exceptionTelemetry, JsonWriter writer)
	{
		writer.WriteStartObject();
		exceptionTelemetry.WriteTelemetryName(writer, "Exception");
		exceptionTelemetry.WriteEnvelopeProperties(writer);
		writer.WritePropertyName("data");
		writer.WriteStartObject();
		writer.WriteProperty("baseType", exceptionTelemetry.BaseType);
		writer.WritePropertyName("baseData");
		writer.WriteStartObject();
		writer.WriteProperty("ver", exceptionTelemetry.Data.ver);
		writer.WriteProperty("properties", exceptionTelemetry.Data.properties);
		writer.WriteProperty("measurements", exceptionTelemetry.Data.measurements);
		writer.WritePropertyName("exceptions");
		writer.WriteStartArray();
		SerializeExceptions(exceptionTelemetry.Exceptions, writer);
		writer.WriteEndArray();
		if (exceptionTelemetry.Data.severityLevel.HasValue)
		{
			writer.WriteProperty("severityLevel", exceptionTelemetry.Data.severityLevel.Value.ToString());
		}
		writer.WriteEndObject();
		writer.WriteEndObject();
		writer.WriteEndObject();
	}

	private static void SerializeMetricTelemetry(MetricTelemetry metricTelemetry, JsonWriter writer)
	{
		writer.WriteStartObject();
		metricTelemetry.WriteTelemetryName(writer, "Metric");
		metricTelemetry.WriteEnvelopeProperties(writer);
		writer.WritePropertyName("data");
		writer.WriteStartObject();
		writer.WriteProperty("baseType", metricTelemetry.BaseType);
		writer.WritePropertyName("baseData");
		writer.WriteStartObject();
		writer.WriteProperty("ver", metricTelemetry.Data.ver);
		writer.WritePropertyName("metrics");
		writer.WriteStartArray();
		writer.WriteStartObject();
		writer.WriteProperty("name", metricTelemetry.Metric.name);
		writer.WriteProperty("kind", metricTelemetry.Metric.kind.ToString());
		writer.WriteProperty("value", metricTelemetry.Metric.value);
		writer.WriteProperty("count", metricTelemetry.Metric.count);
		writer.WriteProperty("min", metricTelemetry.Metric.min);
		writer.WriteProperty("max", metricTelemetry.Metric.max);
		writer.WriteProperty("stdDev", metricTelemetry.Metric.stdDev);
		writer.WriteEndObject();
		writer.WriteEndArray();
		writer.WriteProperty("properties", metricTelemetry.Data.properties);
		writer.WriteEndObject();
		writer.WriteEndObject();
		writer.WriteEndObject();
	}

	private static void SerializePageViewTelemetry(PageViewTelemetry pageViewTelemetry, JsonWriter writer)
	{
		writer.WriteStartObject();
		pageViewTelemetry.WriteTelemetryName(writer, "PageView");
		pageViewTelemetry.WriteEnvelopeProperties(writer);
		writer.WritePropertyName("data");
		writer.WriteStartObject();
		writer.WriteProperty("baseType", pageViewTelemetry.BaseType);
		writer.WritePropertyName("baseData");
		writer.WriteStartObject();
		writer.WriteProperty("ver", pageViewTelemetry.Data.ver);
		writer.WriteProperty("name", pageViewTelemetry.Data.name);
		writer.WriteProperty("url", pageViewTelemetry.Data.url);
		writer.WriteProperty("duration", pageViewTelemetry.Data.duration);
		writer.WriteProperty("measurements", pageViewTelemetry.Data.measurements);
		writer.WriteProperty("properties", pageViewTelemetry.Data.properties);
		writer.WriteEndObject();
		writer.WriteEndObject();
		writer.WriteEndObject();
	}

	private static void SerializeDependencyTelemetry(DependencyTelemetry dependencyTelemetry, JsonWriter writer)
	{
		writer.WriteStartObject();
		dependencyTelemetry.WriteTelemetryName(writer, "RemoteDependency");
		dependencyTelemetry.WriteEnvelopeProperties(writer);
		writer.WritePropertyName("data");
		writer.WriteStartObject();
		writer.WriteProperty("baseType", dependencyTelemetry.BaseType);
		writer.WritePropertyName("baseData");
		writer.WriteStartObject();
		writer.WriteProperty("ver", dependencyTelemetry.InternalData.ver);
		writer.WriteProperty("name", dependencyTelemetry.InternalData.name);
		writer.WriteProperty("id", dependencyTelemetry.InternalData.id);
		writer.WriteProperty("data", dependencyTelemetry.InternalData.data);
		writer.WriteProperty("duration", dependencyTelemetry.InternalData.duration);
		writer.WriteProperty("resultCode", dependencyTelemetry.InternalData.resultCode);
		writer.WriteProperty("success", dependencyTelemetry.InternalData.success);
		writer.WriteProperty("type", dependencyTelemetry.InternalData.type);
		writer.WriteProperty("target", dependencyTelemetry.InternalData.target);
		writer.WriteProperty("properties", dependencyTelemetry.InternalData.properties);
		writer.WriteProperty("measurements", dependencyTelemetry.InternalData.measurements);
		writer.WriteEndObject();
		writer.WriteEndObject();
		writer.WriteEndObject();
	}

	private static void SerializeRequestTelemetry(RequestTelemetry requestTelemetry, JsonWriter jsonWriter)
	{
		jsonWriter.WriteStartObject();
		requestTelemetry.WriteTelemetryName(jsonWriter, "Request");
		requestTelemetry.WriteEnvelopeProperties(jsonWriter);
		jsonWriter.WritePropertyName("data");
		jsonWriter.WriteStartObject();
		jsonWriter.WriteProperty("baseType", requestTelemetry.BaseType);
		jsonWriter.WritePropertyName("baseData");
		jsonWriter.WriteStartObject();
		jsonWriter.WriteProperty("ver", requestTelemetry.Data.ver);
		jsonWriter.WriteProperty("id", requestTelemetry.Data.id);
		jsonWriter.WriteProperty("source", requestTelemetry.Data.source);
		jsonWriter.WriteProperty("name", requestTelemetry.Data.name);
		jsonWriter.WriteProperty("duration", requestTelemetry.Duration);
		jsonWriter.WriteProperty("success", requestTelemetry.Data.success);
		jsonWriter.WriteProperty("responseCode", requestTelemetry.Data.responseCode);
		jsonWriter.WriteProperty("url", requestTelemetry.Data.url);
		jsonWriter.WriteProperty("measurements", requestTelemetry.Data.measurements);
		jsonWriter.WriteProperty("properties", requestTelemetry.Data.properties);
		jsonWriter.WriteEndObject();
		jsonWriter.WriteEndObject();
		jsonWriter.WriteEndObject();
	}

	private static void SerializeTraceTelemetry(TraceTelemetry traceTelemetry, JsonWriter writer)
	{
		writer.WriteStartObject();
		traceTelemetry.WriteTelemetryName(writer, "Message");
		traceTelemetry.WriteEnvelopeProperties(writer);
		writer.WritePropertyName("data");
		writer.WriteStartObject();
		writer.WriteProperty("baseType", traceTelemetry.BaseType);
		writer.WritePropertyName("baseData");
		writer.WriteStartObject();
		writer.WriteProperty("ver", traceTelemetry.Data.ver);
		writer.WriteProperty("message", traceTelemetry.Message);
		if (traceTelemetry.SeverityLevel.HasValue)
		{
			writer.WriteProperty("severityLevel", traceTelemetry.SeverityLevel.Value.ToString());
		}
		writer.WriteProperty("properties", traceTelemetry.Properties);
		writer.WriteEndObject();
		writer.WriteEndObject();
		writer.WriteEndObject();
	}

	private static void SerializeAvailability(AvailabilityTelemetry availabilityTelemetry, JsonWriter writer)
	{
		writer.WriteStartObject();
		availabilityTelemetry.WriteTelemetryName(writer, "Availability");
		availabilityTelemetry.WriteEnvelopeProperties(writer);
		writer.WritePropertyName("data");
		writer.WriteStartObject();
		writer.WriteProperty("baseType", availabilityTelemetry.BaseType);
		writer.WritePropertyName("baseData");
		writer.WriteStartObject();
		writer.WriteProperty("ver", availabilityTelemetry.Data.ver);
		writer.WriteProperty("id", availabilityTelemetry.Data.id);
		writer.WriteProperty("name", availabilityTelemetry.Data.name);
		writer.WriteProperty("duration", availabilityTelemetry.Duration);
		writer.WriteProperty("success", availabilityTelemetry.Data.success);
		writer.WriteProperty("runLocation", availabilityTelemetry.Data.runLocation);
		writer.WriteProperty("message", availabilityTelemetry.Data.message);
		writer.WriteProperty("properties", availabilityTelemetry.Data.properties);
		writer.WriteProperty("properties", availabilityTelemetry.Data.properties);
		writer.WriteProperty("measurements", availabilityTelemetry.Data.measurements);
		writer.WriteEndObject();
		writer.WriteEndObject();
		writer.WriteEndObject();
	}
}
