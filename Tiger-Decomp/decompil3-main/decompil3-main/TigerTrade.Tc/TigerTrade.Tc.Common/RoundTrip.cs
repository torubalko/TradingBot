using System.Diagnostics;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using x97CE55GhEYKgt7TSVZT;

namespace TigerTrade.Tc.Common;

public sealed class RoundTrip
{
	private long _waiting;

	private Stopwatch _stopwatch;

	private static RoundTrip dC2EtZx7t0mvdlb4UmIl;

	public int Value
	{
		get
		{
			if (_stopwatch == null)
			{
				return 0;
			}
			return (int)_stopwatch.Elapsed.TotalMilliseconds;
		}
	}

	public void Start(long waiting = 0L)
	{
		_stopwatch = Stopwatch.StartNew();
		_waiting = waiting;
	}

	public void Stop()
	{
		_stopwatch?.Stop();
	}

	public override string ToString()
	{
		return (string)Cj59QOx7ZwQN8c4BeYfv(DYpawkx7yEaVa5Fhi7Ot(--855742383 ^ 0x33006415), Value) + (string)((_waiting > 0) ? Cj59QOx7ZwQN8c4BeYfv(DYpawkx7yEaVa5Fhi7Ot(0x1487846E ^ 0x148677A2), _waiting) : string.Empty);
	}

	public RoundTrip()
	{
		Uegu3Rx7VUodRFK202gf();
		base._002Ector();
	}

	static RoundTrip()
	{
		V9EGeOx7CFMuhKCT2KDU();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool HrTtMWx7UMiOKQAZqiog()
	{
		return dC2EtZx7t0mvdlb4UmIl == null;
	}

	internal static RoundTrip rKckorx7TPInuyDHRj21()
	{
		return dC2EtZx7t0mvdlb4UmIl;
	}

	internal static object DYpawkx7yEaVa5Fhi7Ot(int P_0)
	{
		return F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(P_0);
	}

	internal static object Cj59QOx7ZwQN8c4BeYfv(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static void Uegu3Rx7VUodRFK202gf()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
	}

	internal static void V9EGeOx7CFMuhKCT2KDU()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
	}
}
