namespace Microsoft.ApplicationInsights.Extensibility.Implementation.Tracing;

internal class DiagnoisticsEventCounters
{
	private readonly object syncRoot = new object();

	private volatile int execCount;

	internal int ExecCount => execCount;

	internal DiagnoisticsEventCounters(int execCountInitial = 0)
	{
		execCount = execCountInitial;
	}

	internal int Increment()
	{
		syncRoot.ExecuteSpinWaitLock(delegate
		{
			if (int.MaxValue > execCount)
			{
				execCount++;
			}
		});
		return execCount;
	}
}
