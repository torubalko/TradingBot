using Microsoft.ApplicationInsights.DataContracts;
using Microsoft.ApplicationInsights.Extensibility.Implementation.External;

namespace Microsoft.ApplicationInsights.Extensibility.Implementation;

internal static class SeverityLevelExtensions
{
	public static Microsoft.ApplicationInsights.DataContracts.SeverityLevel? TranslateSeverityLevel(this Microsoft.ApplicationInsights.Extensibility.Implementation.External.SeverityLevel? sdkSeverityLevel)
	{
		if (!sdkSeverityLevel.HasValue)
		{
			return null;
		}
		return sdkSeverityLevel.Value switch
		{
			Microsoft.ApplicationInsights.Extensibility.Implementation.External.SeverityLevel.Critical => Microsoft.ApplicationInsights.DataContracts.SeverityLevel.Critical, 
			Microsoft.ApplicationInsights.Extensibility.Implementation.External.SeverityLevel.Error => Microsoft.ApplicationInsights.DataContracts.SeverityLevel.Error, 
			Microsoft.ApplicationInsights.Extensibility.Implementation.External.SeverityLevel.Warning => Microsoft.ApplicationInsights.DataContracts.SeverityLevel.Warning, 
			Microsoft.ApplicationInsights.Extensibility.Implementation.External.SeverityLevel.Information => Microsoft.ApplicationInsights.DataContracts.SeverityLevel.Information, 
			_ => Microsoft.ApplicationInsights.DataContracts.SeverityLevel.Verbose, 
		};
	}

	public static Microsoft.ApplicationInsights.Extensibility.Implementation.External.SeverityLevel? TranslateSeverityLevel(this Microsoft.ApplicationInsights.DataContracts.SeverityLevel? dataPlatformSeverityLevel)
	{
		if (!dataPlatformSeverityLevel.HasValue)
		{
			return null;
		}
		return dataPlatformSeverityLevel.Value switch
		{
			Microsoft.ApplicationInsights.DataContracts.SeverityLevel.Critical => Microsoft.ApplicationInsights.Extensibility.Implementation.External.SeverityLevel.Critical, 
			Microsoft.ApplicationInsights.DataContracts.SeverityLevel.Error => Microsoft.ApplicationInsights.Extensibility.Implementation.External.SeverityLevel.Error, 
			Microsoft.ApplicationInsights.DataContracts.SeverityLevel.Warning => Microsoft.ApplicationInsights.Extensibility.Implementation.External.SeverityLevel.Warning, 
			Microsoft.ApplicationInsights.DataContracts.SeverityLevel.Information => Microsoft.ApplicationInsights.Extensibility.Implementation.External.SeverityLevel.Information, 
			_ => Microsoft.ApplicationInsights.Extensibility.Implementation.External.SeverityLevel.Verbose, 
		};
	}
}
