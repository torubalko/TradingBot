using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using TigerTrade.Tc.Data;
using x97CE55GhEYKgt7TSVZT;

namespace HUGROmaQL20CgL29Z5vy;

internal sealed class Yf7Wh7aQx5n0OwURsfH6
{
	private readonly Dictionary<string, Portfolio> KYNaQEUSpsc;

	private readonly object EklaQQ0mv2h;

	private static Yf7Wh7aQx5n0OwURsfH6 yQTPMyx8mkg97BfILI8S;

	internal void vwgaQefLqWv(Portfolio P_0)
	{
		object eklaQQ0mv2h = EklaQQ0mv2h;
		bool lockTaken = false;
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_20e7e617d0f34403acbdcd4eaa1fe0e9 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		try
		{
			Monitor.Enter(eklaQQ0mv2h, ref lockTaken);
			if (KYNaQEUSpsc.ContainsKey(P_0.UniqueID))
			{
				int num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_5a00a8f236ab4094a78e373adc786558 != 0)
				{
					num2 = 0;
				}
				switch (num2)
				{
				case 0:
					break;
				}
			}
			else
			{
				KYNaQEUSpsc.Add(P_0.UniqueID, P_0);
			}
		}
		finally
		{
			if (lockTaken)
			{
				gMIQ5hx87nXopeb8E6I5(eklaQQ0mv2h);
			}
		}
	}

	internal Portfolio z74aQsYheGu(string P_0)
	{
		object eklaQQ0mv2h = EklaQQ0mv2h;
		bool lockTaken = false;
		Portfolio result = default(Portfolio);
		try
		{
			Monitor.Enter(eklaQQ0mv2h, ref lockTaken);
			int num = 1;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_3d8a38b1cb21466e854270ec8942c6ca != 0)
			{
				num = 1;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					if (!string.IsNullOrEmpty(P_0) && KYNaQEUSpsc.ContainsKey(P_0))
					{
						result = KYNaQEUSpsc[P_0];
						num = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a93fb37f4fb14fd7a8fe9a7679ccbe04 != 0)
						{
							num = 0;
						}
						continue;
					}
					result = null;
					break;
				case 0:
					break;
				}
				break;
			}
		}
		finally
		{
			if (lockTaken)
			{
				gMIQ5hx87nXopeb8E6I5(eklaQQ0mv2h);
			}
		}
		return result;
	}

	public List<Portfolio> ltcaQXEchQi()
	{
		lock (EklaQQ0mv2h)
		{
			return KYNaQEUSpsc.Values.ToList();
		}
	}

	internal void Clear()
	{
		int num = 1;
		int num2 = num;
		object eklaQQ0mv2h = default(object);
		while (true)
		{
			switch (num2)
			{
			case 1:
				eklaQQ0mv2h = EklaQQ0mv2h;
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_7b7109b795404d83aab2ffb6bac7cdab == 0)
				{
					num2 = 0;
				}
				continue;
			}
			bool lockTaken = false;
			try
			{
				Monitor.Enter(eklaQQ0mv2h, ref lockTaken);
				KYNaQEUSpsc.Clear();
				return;
			}
			finally
			{
				if (lockTaken)
				{
					Monitor.Exit(eklaQQ0mv2h);
				}
			}
		}
	}

	[SpecialName]
	public int G4YaQcE4XIH()
	{
		object eklaQQ0mv2h = EklaQQ0mv2h;
		bool lockTaken = false;
		try
		{
			Monitor.Enter(eklaQQ0mv2h, ref lockTaken);
			return Q2yhq8x884e2Kbv0Rjiw(KYNaQEUSpsc);
		}
		finally
		{
			if (lockTaken)
			{
				gMIQ5hx87nXopeb8E6I5(eklaQQ0mv2h);
				int num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_e37b704f00fd438985274655b11b16b4 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 0:
					break;
				}
			}
		}
	}

	public Yf7Wh7aQx5n0OwURsfH6()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		KYNaQEUSpsc = new Dictionary<string, Portfolio>();
		EklaQQ0mv2h = new object();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_0038f818f2704f70a8069fbdf675cc8a != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static Yf7Wh7aQx5n0OwURsfH6()
	{
		itrh0jx8AaXHvTvTPVAT();
		W4cH1Sx8PcZ8RMOqcfQj();
	}

	internal static void gMIQ5hx87nXopeb8E6I5(object P_0)
	{
		Monitor.Exit(P_0);
	}

	internal static bool yv905ix8hWNgBmsCITeG()
	{
		return yQTPMyx8mkg97BfILI8S == null;
	}

	internal static Yf7Wh7aQx5n0OwURsfH6 DsGD6tx8wk95Mjcq40K1()
	{
		return yQTPMyx8mkg97BfILI8S;
	}

	internal static int Q2yhq8x884e2Kbv0Rjiw(object P_0)
	{
		return ((Dictionary<string, Portfolio>)P_0).Count;
	}

	internal static void itrh0jx8AaXHvTvTPVAT()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
	}

	internal static void W4cH1Sx8PcZ8RMOqcfQj()
	{
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}
}
