using System;

namespace Microsoft.ApplicationInsights.DataContracts;

[Obsolete("Use custom properties to report exception handling layer")]
public enum ExceptionHandledAt
{
	Unhandled,
	UserCode,
	Platform
}
