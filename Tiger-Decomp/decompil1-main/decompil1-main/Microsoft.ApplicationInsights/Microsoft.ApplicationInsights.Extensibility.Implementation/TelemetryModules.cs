using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace Microsoft.ApplicationInsights.Extensibility.Implementation;

[EditorBrowsable(EditorBrowsableState.Never)]
public class TelemetryModules
{
	private static TelemetryModules instance;

	public static TelemetryModules Instance => LazyInitializer.EnsureInitialized(ref instance, () => new TelemetryModules());

	public IList<ITelemetryModule> Modules { get; private set; }

	protected TelemetryModules()
	{
		Modules = new SnapshottingList<ITelemetryModule>();
	}
}
