namespace Microsoft.ApplicationInsights.Extensibility.Implementation;

internal interface IRandomNumberBatchGenerator
{
	void NextBatch(ulong[] buffer, int index, int count);
}
