using System.Collections.Concurrent;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using k56rXOGpHcZIas56ia8y;
using TigerTrade.Tc.Data;
using U0vBVyGFnRQg4TAEWduY;
using x97CE55GhEYKgt7TSVZT;

namespace hLNgjdadfJmAYwpjL3jr;

internal sealed class XGPMikadHJMQKPWwUlio
{
	private readonly ConcurrentDictionary<Symbol, g62JgfGp2rGReTRRFt16> K5wadYR8Yf7;

	private static XGPMikadHJMQKPWwUlio USxlmNxAXNuFvpAaLwJF;

	public bool YF6ad9VHuyo(Symbol P_0)
	{
		if (P_0 != null)
		{
			return K5wadYR8Yf7.TryAdd(P_0, (g62JgfGp2rGReTRRFt16)Ilkx6exAESqJE1qmJFPb(P_0));
		}
		return false;
	}

	public g62JgfGp2rGReTRRFt16 nrWadns1HTl(Symbol P_0)
	{
		if (P_0 == null || !K5wadYR8Yf7.TryGetValue(P_0, out var value))
		{
			return null;
		}
		return value;
	}

	internal void kQkadG7VV1L(Symbol P_0)
	{
		if (P_0 != null && K5wadYR8Yf7.TryRemove(P_0, out var value))
		{
			IlvHiXGF9pA6U4gUK5bq.JFoGFjMJw5Q(value);
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ac3f8b71231e4b108fd519d939438d5a == 0)
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

	public XGPMikadHJMQKPWwUlio()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		K5wadYR8Yf7 = new ConcurrentDictionary<Symbol, g62JgfGp2rGReTRRFt16>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_dcfa3a019743403299410dca8ba03e4c != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static XGPMikadHJMQKPWwUlio()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static object Ilkx6exAESqJE1qmJFPb(object P_0)
	{
		return IlvHiXGF9pA6U4gUK5bq.ClyGF1WE29P((Symbol)P_0);
	}

	internal static bool x78EBjxAcYyCNNulb8LJ()
	{
		return USxlmNxAXNuFvpAaLwJF == null;
	}

	internal static XGPMikadHJMQKPWwUlio sRlkW4xAjhGukg0MZg7d()
	{
		return USxlmNxAXNuFvpAaLwJF;
	}
}
