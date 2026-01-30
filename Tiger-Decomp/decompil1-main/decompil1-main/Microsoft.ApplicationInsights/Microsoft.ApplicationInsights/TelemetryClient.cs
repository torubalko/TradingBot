using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Threading;
using Microsoft.ApplicationInsights.Channel;
using Microsoft.ApplicationInsights.DataContracts;
using Microsoft.ApplicationInsights.Extensibility;
using Microsoft.ApplicationInsights.Extensibility.Implementation;
using Microsoft.ApplicationInsights.Extensibility.Implementation.Platform;
using Microsoft.ApplicationInsights.Extensibility.Implementation.Tracing;

namespace Microsoft.ApplicationInsights;

public sealed class TelemetryClient
{
	private const string VersionPrefix = "dotnet:";

	private readonly TelemetryConfiguration configuration;

	private TelemetryContext context;

	private string sdkVersion;

	public TelemetryContext Context
	{
		get
		{
			return LazyInitializer.EnsureInitialized(ref context, () => new TelemetryContext());
		}
		internal set
		{
			context = value;
		}
	}

	public string InstrumentationKey
	{
		get
		{
			return Context.InstrumentationKey;
		}
		set
		{
			Context.InstrumentationKey = value;
		}
	}

	internal TelemetryConfiguration TelemetryConfiguration => configuration;

	public TelemetryClient()
		: this(TelemetryConfiguration.Active)
	{
	}

	public TelemetryClient(TelemetryConfiguration configuration)
	{
		if (configuration == null)
		{
			CoreEventSource.Log.TelemetryClientConstructorWithNoTelemetryConfiguration();
			configuration = TelemetryConfiguration.Active;
		}
		this.configuration = configuration;
	}

	public bool IsEnabled()
	{
		return !configuration.DisableTelemetry;
	}

	public void TrackEvent(string eventName, IDictionary<string, string> properties = null, IDictionary<string, double> metrics = null)
	{
		EventTelemetry eventTelemetry = new EventTelemetry(eventName);
		if (properties != null && properties.Count > 0)
		{
			Utils.CopyDictionary(properties, eventTelemetry.Context.Properties);
		}
		if (metrics != null && metrics.Count > 0)
		{
			Utils.CopyDictionary(metrics, eventTelemetry.Metrics);
		}
		TrackEvent(eventTelemetry);
	}

	public void TrackEvent(EventTelemetry telemetry)
	{
		if (telemetry == null)
		{
			telemetry = new EventTelemetry();
		}
		Track(telemetry);
	}

	public void TrackTrace(string message)
	{
		TrackTrace(new TraceTelemetry(message));
	}

	public void TrackTrace(string message, SeverityLevel severityLevel)
	{
		TrackTrace(new TraceTelemetry(message, severityLevel));
	}

	public void TrackTrace(string message, IDictionary<string, string> properties)
	{
		TraceTelemetry traceTelemetry = new TraceTelemetry(message);
		if (properties != null && properties.Count > 0)
		{
			Utils.CopyDictionary(properties, traceTelemetry.Context.Properties);
		}
		TrackTrace(traceTelemetry);
	}

	public void TrackTrace(string message, SeverityLevel severityLevel, IDictionary<string, string> properties)
	{
		TraceTelemetry traceTelemetry = new TraceTelemetry(message, severityLevel);
		if (properties != null && properties.Count > 0)
		{
			Utils.CopyDictionary(properties, traceTelemetry.Context.Properties);
		}
		TrackTrace(traceTelemetry);
	}

	public void TrackTrace(TraceTelemetry telemetry)
	{
		telemetry = telemetry ?? new TraceTelemetry();
		Track(telemetry);
	}

	public void TrackMetric(string name, double value, IDictionary<string, string> properties = null)
	{
		MetricTelemetry metricTelemetry = new MetricTelemetry(name, value);
		if (properties != null && properties.Count > 0)
		{
			Utils.CopyDictionary(properties, metricTelemetry.Properties);
		}
		TrackMetric(metricTelemetry);
	}

	public void TrackMetric(MetricTelemetry telemetry)
	{
		if (telemetry == null)
		{
			telemetry = new MetricTelemetry();
		}
		Track(telemetry);
	}

	public void TrackException(Exception exception, IDictionary<string, string> properties = null, IDictionary<string, double> metrics = null)
	{
		if (exception == null)
		{
			exception = new Exception(Utils.PopulateRequiredStringValue(null, "message", typeof(ExceptionTelemetry).FullName));
		}
		ExceptionTelemetry exceptionTelemetry = new ExceptionTelemetry(exception);
		if (properties != null && properties.Count > 0)
		{
			Utils.CopyDictionary(properties, exceptionTelemetry.Context.Properties);
		}
		if (metrics != null && metrics.Count > 0)
		{
			Utils.CopyDictionary(metrics, exceptionTelemetry.Metrics);
		}
		TrackException(exceptionTelemetry);
	}

	public void TrackException(ExceptionTelemetry telemetry)
	{
		if (telemetry == null)
		{
			telemetry = new ExceptionTelemetry(new Exception(Utils.PopulateRequiredStringValue(null, "message", typeof(ExceptionTelemetry).FullName)));
		}
		Track(telemetry);
	}

	public void TrackDependency(string dependencyName, string commandName, DateTimeOffset startTime, TimeSpan duration, bool success)
	{
		TrackDependency(new DependencyTelemetry(dependencyName, commandName, startTime, duration, success));
	}

	public void TrackDependency(string dependencyTypeName, string target, string dependencyName, string data, DateTimeOffset startTime, TimeSpan duration, string resultCode, bool success)
	{
		TrackDependency(new DependencyTelemetry(dependencyTypeName, target, dependencyName, data, startTime, duration, resultCode, success));
	}

	public void TrackDependency(DependencyTelemetry telemetry)
	{
		if (telemetry == null)
		{
			telemetry = new DependencyTelemetry();
		}
		Track(telemetry);
	}

	public void TrackAvailability(string name, DateTimeOffset timeStamp, TimeSpan duration, string runLocation, bool success, string message = null)
	{
		TrackAvailability(new AvailabilityTelemetry(name, timeStamp, duration, runLocation, success, message));
	}

	public void TrackAvailability(AvailabilityTelemetry telemetry)
	{
		if (telemetry == null)
		{
			telemetry = new AvailabilityTelemetry();
		}
		Track(telemetry);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void Track(ITelemetry telemetry)
	{
		if (!IsEnabled())
		{
			return;
		}
		Initialize(telemetry);
		if (string.IsNullOrEmpty(telemetry.Context.InstrumentationKey))
		{
			TelemetryDebugWriter.WriteTelemetry(telemetry);
			return;
		}
		if (configuration.TelemetryChannel == null)
		{
			configuration.TelemetryChannel = new InMemoryChannel();
		}
		configuration.TelemetryProcessorChain.Process(telemetry);
		telemetry.Sanitize();
		RichPayloadEventSource.Log.Process(telemetry);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void Initialize(ITelemetry telemetry)
	{
		string instrumentationKey = Context.InstrumentationKey;
		if (string.IsNullOrEmpty(instrumentationKey))
		{
			instrumentationKey = configuration.InstrumentationKey;
		}
		if (telemetry is ISupportProperties supportProperties)
		{
			if (configuration.TelemetryChannel != null && configuration.TelemetryChannel.DeveloperMode.HasValue && configuration.TelemetryChannel.DeveloperMode.Value && !supportProperties.Properties.ContainsKey("DeveloperMode"))
			{
				supportProperties.Properties.Add("DeveloperMode", "true");
			}
			Utils.CopyDictionary(Context.Properties, supportProperties.Properties);
		}
		telemetry.Context.Initialize(Context, instrumentationKey);
		foreach (ITelemetryInitializer telemetryInitializer in configuration.TelemetryInitializers)
		{
			try
			{
				telemetryInitializer.Initialize(telemetry);
			}
			catch (Exception arg)
			{
				CoreEventSource.Log.LogError(string.Format(CultureInfo.InvariantCulture, "Exception while initializing {0}, exception message - {1}", telemetryInitializer.GetType().FullName, arg));
			}
		}
		if (telemetry.Timestamp == default(DateTimeOffset))
		{
			telemetry.Timestamp = DateTimeOffset.UtcNow;
		}
		if (string.IsNullOrEmpty(telemetry.Context.Internal.SdkVersion))
		{
			string text = LazyInitializer.EnsureInitialized(ref sdkVersion, GetSdkVersion);
			telemetry.Context.Internal.SdkVersion = text;
		}
		if (string.IsNullOrEmpty(telemetry.Context.Internal.NodeName) && !string.IsNullOrEmpty(telemetry.Context.Cloud.RoleInstance))
		{
			telemetry.Context.Internal.NodeName = PlatformSingleton.Current.GetMachineName();
		}
		if (string.IsNullOrEmpty(telemetry.Context.Cloud.RoleInstance))
		{
			telemetry.Context.Cloud.RoleInstance = PlatformSingleton.Current.GetMachineName();
		}
	}

	public void TrackPageView(string name)
	{
		Track(new PageViewTelemetry(name));
	}

	public void TrackPageView(PageViewTelemetry telemetry)
	{
		if (telemetry == null)
		{
			telemetry = new PageViewTelemetry();
		}
		Track(telemetry);
	}

	public void TrackRequest(string name, DateTimeOffset startTime, TimeSpan duration, string responseCode, bool success)
	{
		Track(new RequestTelemetry(name, startTime, duration, responseCode, success));
	}

	public void TrackRequest(RequestTelemetry request)
	{
		if (request == null)
		{
			request = new RequestTelemetry();
		}
		Track(request);
	}

	public void Flush()
	{
		configuration.TelemetryChannel.Flush();
	}

	private string GetSdkVersion()
	{
		Version version = new Version(typeof(TelemetryClient).Assembly.GetCustomAttributes(inherit: false).OfType<AssemblyFileVersionAttribute>().First()
			.Version);
		return "dotnet:" + version.ToString(3) + "-" + version.Revision;
	}
}
