using System;
using System.ComponentModel;
using System.Globalization;
using System.Threading;

namespace Microsoft.ApplicationInsights.Extensibility.Implementation.Tracing;

[EditorBrowsable(EditorBrowsableState.Never)]
public static class Extensions
{
	public static string ToInvariantString(this Exception exception)
	{
		CultureInfo currentUICulture = Thread.CurrentThread.CurrentUICulture;
		try
		{
			Thread.CurrentThread.CurrentUICulture = CultureInfo.InvariantCulture;
			return exception.ToString();
		}
		finally
		{
			Thread.CurrentThread.CurrentUICulture = currentUICulture;
		}
	}
}
