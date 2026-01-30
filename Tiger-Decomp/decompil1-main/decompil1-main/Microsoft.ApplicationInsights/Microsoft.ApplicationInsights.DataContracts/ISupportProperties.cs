using System.Collections.Generic;

namespace Microsoft.ApplicationInsights.DataContracts;

public interface ISupportProperties
{
	IDictionary<string, string> Properties { get; }
}
