namespace Microsoft.ApplicationInsights.DataContracts;

public interface ISupportSampling
{
	double? SamplingPercentage { get; set; }
}
