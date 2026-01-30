using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;
using Microsoft.ApplicationInsights.Extensibility.Implementation;

namespace Microsoft.ApplicationInsights.DataContracts;

public sealed class TelemetryContext
{
	private readonly IDictionary<string, string> properties;

	private readonly IDictionary<string, string> tags;

	private string instrumentationKey;

	private ComponentContext component;

	private DeviceContext device;

	private CloudContext cloud;

	private SessionContext session;

	private UserContext user;

	private OperationContext operation;

	private LocationContext location;

	private InternalContext internalContext;

	public string InstrumentationKey
	{
		get
		{
			return instrumentationKey ?? string.Empty;
		}
		set
		{
			Property.Set(ref instrumentationKey, value);
		}
	}

	public ComponentContext Component => LazyInitializer.EnsureInitialized(ref component, () => new ComponentContext(Tags));

	public DeviceContext Device => LazyInitializer.EnsureInitialized(ref device, () => new DeviceContext(Tags, Properties));

	public CloudContext Cloud => LazyInitializer.EnsureInitialized(ref cloud, () => new CloudContext(Tags));

	public SessionContext Session => LazyInitializer.EnsureInitialized(ref session, () => new SessionContext(Tags));

	public UserContext User => LazyInitializer.EnsureInitialized(ref user, () => new UserContext(Tags));

	public OperationContext Operation => LazyInitializer.EnsureInitialized(ref operation, () => new OperationContext(Tags));

	public LocationContext Location => LazyInitializer.EnsureInitialized(ref location, () => new LocationContext(Tags));

	public IDictionary<string, string> Properties => properties;

	internal InternalContext Internal => LazyInitializer.EnsureInitialized(ref internalContext, () => new InternalContext(Tags));

	internal IDictionary<string, string> Tags => tags;

	public TelemetryContext()
		: this(new ConcurrentDictionary<string, string>())
	{
	}

	internal TelemetryContext(IDictionary<string, string> properties)
	{
		this.properties = properties;
		tags = new ConcurrentDictionary<string, string>();
	}

	internal void Initialize(TelemetryContext source, string instrumentationKey)
	{
		Property.Initialize(ref this.instrumentationKey, instrumentationKey);
		if (source.tags != null && source.tags.Count > 0)
		{
			Utils.CopyDictionary(source.tags, Tags);
		}
	}
}
