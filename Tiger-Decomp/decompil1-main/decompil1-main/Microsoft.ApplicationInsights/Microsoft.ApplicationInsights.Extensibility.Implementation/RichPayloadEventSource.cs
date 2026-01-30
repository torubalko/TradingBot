using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Globalization;
using Microsoft.ApplicationInsights.Channel;
using Microsoft.ApplicationInsights.DataContracts;
using Microsoft.ApplicationInsights.Extensibility.Implementation.Tracing;

namespace Microsoft.ApplicationInsights.Extensibility.Implementation;

internal sealed class RichPayloadEventSource : IDisposable
{
	public sealed class Keywords
	{
		public const EventKeywords Requests = (EventKeywords)1L;

		public const EventKeywords Traces = (EventKeywords)2L;

		public const EventKeywords Events = (EventKeywords)4L;

		public const EventKeywords Exceptions = (EventKeywords)8L;

		public const EventKeywords Dependencies = (EventKeywords)16L;

		public const EventKeywords Metrics = (EventKeywords)32L;

		public const EventKeywords PageViews = (EventKeywords)64L;

		public const EventKeywords Availability = (EventKeywords)512L;
	}

	public static readonly RichPayloadEventSource Log = new RichPayloadEventSource();

	internal readonly EventSource EventSourceInternal;

	private const string EventProviderName = "Microsoft-ApplicationInsights-Data";

	public RichPayloadEventSource()
	{
		EventSourceInternal = new EventSource("Microsoft-ApplicationInsights-Data", EventSourceSettings.EtwSelfDescribingEventFormat);
	}

	public void Process(ITelemetry item)
	{
		if (item is RequestTelemetry)
		{
			if (EventSourceInternal.IsEnabled(EventLevel.Verbose, (EventKeywords)1L))
			{
				RequestTelemetry requestTelemetry = item as RequestTelemetry;
				WriteEvent("Request", requestTelemetry.Context.InstrumentationKey, requestTelemetry.Context.Tags, requestTelemetry.Data, (EventKeywords)1L);
			}
		}
		else if (item is TraceTelemetry)
		{
			if (EventSourceInternal.IsEnabled(EventLevel.Verbose, (EventKeywords)2L))
			{
				TraceTelemetry traceTelemetry = item as TraceTelemetry;
				WriteEvent("Message", traceTelemetry.Context.InstrumentationKey, traceTelemetry.Context.Tags, traceTelemetry.Data, (EventKeywords)2L);
			}
		}
		else if (item is EventTelemetry)
		{
			if (EventSourceInternal.IsEnabled(EventLevel.Verbose, (EventKeywords)4L))
			{
				EventTelemetry eventTelemetry = item as EventTelemetry;
				WriteEvent("Event", eventTelemetry.Context.InstrumentationKey, eventTelemetry.Context.Tags, eventTelemetry.Data, (EventKeywords)4L);
			}
		}
		else if (item is DependencyTelemetry)
		{
			if (EventSourceInternal.IsEnabled(EventLevel.Verbose, (EventKeywords)16L))
			{
				DependencyTelemetry dependencyTelemetry = item as DependencyTelemetry;
				WriteEvent("RemoteDependency", dependencyTelemetry.Context.InstrumentationKey, dependencyTelemetry.Context.Tags, dependencyTelemetry.InternalData, (EventKeywords)16L);
			}
		}
		else if (item is MetricTelemetry)
		{
			if (EventSourceInternal.IsEnabled(EventLevel.Verbose, (EventKeywords)32L))
			{
				MetricTelemetry metricTelemetry = item as MetricTelemetry;
				WriteEvent("Metric", metricTelemetry.Context.InstrumentationKey, metricTelemetry.Context.Tags, metricTelemetry.Data, (EventKeywords)32L);
			}
		}
		else if (item is ExceptionTelemetry)
		{
			if (EventSourceInternal.IsEnabled(EventLevel.Verbose, (EventKeywords)8L))
			{
				ExceptionTelemetry exceptionTelemetry = item as ExceptionTelemetry;
				WriteEvent("Exception", exceptionTelemetry.Context.InstrumentationKey, exceptionTelemetry.Context.Tags, exceptionTelemetry.Data, (EventKeywords)8L);
			}
		}
		else if (item is PerformanceCounterTelemetry)
		{
			if (EventSourceInternal.IsEnabled(EventLevel.Verbose, (EventKeywords)32L))
			{
				MetricTelemetry data = (item as PerformanceCounterTelemetry).Data;
				WriteEvent("Metric", data.Context.InstrumentationKey, data.Context.Tags, data.Data, (EventKeywords)32L);
			}
		}
		else if (item is PageViewTelemetry)
		{
			if (EventSourceInternal.IsEnabled(EventLevel.Verbose, (EventKeywords)64L))
			{
				PageViewTelemetry pageViewTelemetry = item as PageViewTelemetry;
				WriteEvent("PageView", pageViewTelemetry.Context.InstrumentationKey, pageViewTelemetry.Context.Tags, pageViewTelemetry.Data, (EventKeywords)64L);
			}
		}
		else if (item is SessionStateTelemetry)
		{
			if (EventSourceInternal.IsEnabled(EventLevel.Verbose, (EventKeywords)4L))
			{
				EventTelemetry data2 = (item as SessionStateTelemetry).Data;
				WriteEvent("Event", data2.Context.InstrumentationKey, data2.Context.Tags, data2.Data, (EventKeywords)4L);
			}
		}
		else if (item is AvailabilityTelemetry)
		{
			if (EventSourceInternal.IsEnabled(EventLevel.Verbose, (EventKeywords)512L))
			{
				AvailabilityTelemetry availabilityTelemetry = item as AvailabilityTelemetry;
				WriteEvent("Availability", availabilityTelemetry.Context.InstrumentationKey, availabilityTelemetry.Context.Tags, availabilityTelemetry.Data, (EventKeywords)512L);
			}
		}
		else
		{
			string msg = string.Format(CultureInfo.InvariantCulture, "Unknown telemetry type: {0}", item.GetType());
			CoreEventSource.Log.LogVerbose(msg);
		}
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	private void Dispose(bool disposing)
	{
		if (disposing && EventSourceInternal != null)
		{
			EventSourceInternal.Dispose();
		}
	}

	private void WriteEvent<T>(string eventName, string instrumentationKey, IDictionary<string, string> tags, T data, EventKeywords keywords)
	{
		EventSourceInternal.Write(eventName, new EventSourceOptions
		{
			Keywords = keywords
		}, new
		{
			PartA_iKey = instrumentationKey,
			PartA_Tags = tags,
			_B = data
		});
	}
}
