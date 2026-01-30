using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using Microsoft.ApplicationInsights.Channel;
using Microsoft.ApplicationInsights.Extensibility.Implementation;
using Microsoft.ApplicationInsights.Extensibility.Implementation.Tracing;

namespace Microsoft.ApplicationInsights.Extensibility;

public sealed class TelemetryConfiguration : IDisposable
{
	private static object syncRoot = new object();

	private static TelemetryConfiguration active;

	private readonly SnapshottingList<ITelemetryInitializer> telemetryInitializers = new SnapshottingList<ITelemetryInitializer>();

	private TelemetryProcessorChain telemetryProcessorChain;

	private string instrumentationKey = string.Empty;

	private bool disableTelemetry;

	private TelemetryProcessorChainBuilder builder;

	public static TelemetryConfiguration Active
	{
		get
		{
			if (active == null)
			{
				lock (syncRoot)
				{
					if (active == null)
					{
						active = new TelemetryConfiguration();
						TelemetryConfigurationFactory.Instance.Initialize(active, TelemetryModules.Instance);
					}
				}
			}
			return active;
		}
		internal set
		{
			lock (syncRoot)
			{
				active = value;
			}
		}
	}

	public string InstrumentationKey
	{
		get
		{
			return instrumentationKey;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			instrumentationKey = value;
		}
	}

	public bool DisableTelemetry
	{
		get
		{
			return disableTelemetry;
		}
		set
		{
			if (value)
			{
				CoreEventSource.Log.TrackingWasDisabled();
			}
			else
			{
				CoreEventSource.Log.TrackingWasEnabled();
			}
			disableTelemetry = value;
		}
	}

	public IList<ITelemetryInitializer> TelemetryInitializers => telemetryInitializers;

	public ReadOnlyCollection<ITelemetryProcessor> TelemetryProcessors => new ReadOnlyCollection<ITelemetryProcessor>(TelemetryProcessorChain.TelemetryProcessors);

	public TelemetryProcessorChainBuilder TelemetryProcessorChainBuilder
	{
		get
		{
			LazyInitializer.EnsureInitialized(ref builder, () => new TelemetryProcessorChainBuilder(this));
			return builder;
		}
		internal set
		{
			builder = value;
		}
	}

	public ITelemetryChannel TelemetryChannel { get; set; }

	internal TelemetryProcessorChain TelemetryProcessorChain
	{
		get
		{
			if (telemetryProcessorChain == null)
			{
				TelemetryProcessorChainBuilder.Build();
			}
			return telemetryProcessorChain;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			telemetryProcessorChain = value;
		}
	}

	public static TelemetryConfiguration CreateDefault()
	{
		TelemetryConfiguration telemetryConfiguration = new TelemetryConfiguration();
		TelemetryConfigurationFactory.Instance.Initialize(telemetryConfiguration, null);
		return telemetryConfiguration;
	}

	public static TelemetryConfiguration CreateFromConfiguration(string config)
	{
		if (string.IsNullOrWhiteSpace(config))
		{
			throw new ArgumentNullException("config");
		}
		TelemetryConfiguration telemetryConfiguration = new TelemetryConfiguration();
		TelemetryConfigurationFactory.Instance.Initialize(telemetryConfiguration, null, config);
		return telemetryConfiguration;
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	private void Dispose(bool disposing)
	{
		if (disposing)
		{
			Interlocked.CompareExchange(ref active, null, this);
			TelemetryChannel?.Dispose();
			telemetryProcessorChain?.Dispose();
		}
	}
}
