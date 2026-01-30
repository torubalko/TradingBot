using System.ComponentModel;
using Microsoft.ApplicationInsights.DataContracts;

namespace Microsoft.ApplicationInsights.Extensibility.Implementation;

[EditorBrowsable(EditorBrowsableState.Never)]
public static class TelemetryContextExtensions
{
	public static InternalContext GetInternalContext(this TelemetryContext context)
	{
		return context.Internal;
	}
}
