using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using TigerTrade.Tc.Data;
using x97CE55GhEYKgt7TSVZT;

namespace LdMlBAGPRW4Io3eaopBV;

internal sealed class JEjMCWGPgL6gmjDSXJ1W
{
	private readonly List<Bar> Qv5GPIa8vBg;

	[CompilerGenerated]
	private DateTime HaqGPWSjHXS;

	internal static JEjMCWGPgL6gmjDSXJ1W tArbQ25wDVp6tvYDNqjf;

	public DateTime LastTime
	{
		[CompilerGenerated]
		get
		{
			return HaqGPWSjHXS;
		}
		[CompilerGenerated]
		private set
		{
			HaqGPWSjHXS = haqGPWSjHXS;
		}
	}

	public void hslGP6XKwsU(Bar P_0)
	{
		Bar bar = ((Qv5GPIa8vBg.Count > 0) ? Qv5GPIa8vBg[Qv5GPIa8vBg.Count - 1] : null);
		int num = 3;
		while (true)
		{
			switch (num)
			{
			default:
				LastTime = P_0.Time;
				return;
			case 3:
				if (bar != null)
				{
					num = 2;
					continue;
				}
				break;
			case 1:
				Qv5GPIa8vBg[Qv5GPIa8vBg.Count - 1] = P_0;
				return;
			case 2:
				if (!w0XvVA5wkbal4m2Onod5(bar.Time, P_0.Time))
				{
					if (TulSAA5w1r7y6DvjrjKC(bar.Time, P_0.Time))
					{
						return;
					}
					break;
				}
				goto case 1;
			}
			Qv5GPIa8vBg.Add(P_0);
			num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_c39cf65fb9834816b04c914d068177cc != 0)
			{
				num = 0;
			}
		}
	}

	public List<Bar> PIZGPME0rEZ()
	{
		return Qv5GPIa8vBg.ToList();
	}

	public JEjMCWGPgL6gmjDSXJ1W()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		Qv5GPIa8vBg = new List<Bar>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_8ac3c5fcdf484302951e15fc405858a5 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static JEjMCWGPgL6gmjDSXJ1W()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		GDJvJy5w5Y6GKPPJoIy3();
	}

	internal static bool Ibb60E5wbBHxeAfSINhV()
	{
		return tArbQ25wDVp6tvYDNqjf == null;
	}

	internal static JEjMCWGPgL6gmjDSXJ1W pd7BfC5wNIMDoZbeg5lg()
	{
		return tArbQ25wDVp6tvYDNqjf;
	}

	internal static bool w0XvVA5wkbal4m2Onod5(DateTime P_0, DateTime P_1)
	{
		return P_0 == P_1;
	}

	internal static bool TulSAA5w1r7y6DvjrjKC(DateTime P_0, DateTime P_1)
	{
		return P_0 > P_1;
	}

	internal static void GDJvJy5w5Y6GKPPJoIy3()
	{
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}
}
