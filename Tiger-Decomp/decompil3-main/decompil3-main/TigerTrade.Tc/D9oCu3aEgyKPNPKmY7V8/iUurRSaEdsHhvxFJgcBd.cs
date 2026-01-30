using System.Collections.Generic;
using System.Threading;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using lFFs11G39ohaRVknaFPC;
using sIFWheGF3OYNVQk97tur;
using TigerTrade.Tc.Data;
using x97CE55GhEYKgt7TSVZT;

namespace D9oCu3aEgyKPNPKmY7V8;

internal sealed class iUurRSaEdsHhvxFJgcBd
{
	private readonly Dictionary<string, MarketDepth> kncaEOojilr;

	private readonly object AEnaEqJ7SV4;

	internal static iUurRSaEdsHhvxFJgcBd PM0PRix85yW73GRpGINn;

	internal void oqkaERCumhV(MarketDepthFullEvent P_0)
	{
		object aEnaEqJ7SV = AEnaEqJ7SV4;
		bool lockTaken = false;
		try
		{
			Monitor.Enter(aEnaEqJ7SV, ref lockTaken);
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_262c45b675dc44e594e3edec7c08a152 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			if (!kncaEOojilr.TryGetValue(P_0.Symbol.ID, out var value))
			{
				value = (kncaEOojilr[(string)dUtb9ix8LEOswnovFn9A(P_0.Symbol)] = new MarketDepth(P_0.Symbol));
			}
			value.Apply(P_0);
		}
		finally
		{
			if (lockTaken)
			{
				UCr8v9x8egAIReyPuBFJ(aEnaEqJ7SV);
			}
		}
	}

	internal void fnKaE6MgkjL(MarketDepthDiffEvent P_0)
	{
		object aEnaEqJ7SV = AEnaEqJ7SV4;
		bool lockTaken = false;
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_af030adc5d834c7fa654aaa946f39572 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		try
		{
			Monitor.Enter(aEnaEqJ7SV, ref lockTaken);
			int num2 = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_2eeb07b76a6b47ee89babb98850d4c1d == 0)
			{
				num2 = 0;
			}
			switch (num2)
			{
			}
			if (kncaEOojilr.TryGetValue((string)dUtb9ix8LEOswnovFn9A(P_0.Symbol), out var value))
			{
				value.Apply(P_0);
			}
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(aEnaEqJ7SV);
			}
		}
	}

	public MarketDepth f0oaEMlfDjn(Symbol P_0)
	{
		int num = 1;
		int num2 = num;
		object aEnaEqJ7SV = default(object);
		while (true)
		{
			switch (num2)
			{
			case 1:
				aEnaEqJ7SV = AEnaEqJ7SV4;
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_f19bbaca9e82419ba66f0bdafd2c824a == 0)
				{
					num2 = 0;
				}
				continue;
			}
			bool lockTaken = false;
			MarketDepth result;
			try
			{
				Monitor.Enter(aEnaEqJ7SV, ref lockTaken);
				result = (kncaEOojilr.ContainsKey(P_0.ID) ? kncaEOojilr[(string)dUtb9ix8LEOswnovFn9A(P_0)] : null);
				int num3 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_82741674950e4c70a0407e3b1a670169 == 0)
				{
					num3 = 0;
				}
				switch (num3)
				{
				case 0:
					break;
				}
			}
			finally
			{
				if (lockTaken)
				{
					Monitor.Exit(aEnaEqJ7SV);
				}
			}
			return result;
		}
	}

	internal void Clear()
	{
		int num = 1;
		int num2 = num;
		object aEnaEqJ7SV = default(object);
		while (true)
		{
			switch (num2)
			{
			case 1:
				aEnaEqJ7SV = AEnaEqJ7SV4;
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_2b9e363b0abc4a32a96694deb0f4f698 != 0)
				{
					num2 = 0;
				}
				continue;
			}
			bool lockTaken = false;
			try
			{
				Monitor.Enter(aEnaEqJ7SV, ref lockTaken);
				Qth18Ix8sh52WFyAZOV5(kncaEOojilr);
				return;
			}
			finally
			{
				if (lockTaken)
				{
					Monitor.Exit(aEnaEqJ7SV);
				}
			}
		}
	}

	public iUurRSaEdsHhvxFJgcBd()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		kncaEOojilr = new Dictionary<string, MarketDepth>();
		AEnaEqJ7SV4 = new object();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_376f2bcb10134b91b6257ed8645d119a != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static iUurRSaEdsHhvxFJgcBd()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static object dUtb9ix8LEOswnovFn9A(object P_0)
	{
		return ((Symbol)P_0).ID;
	}

	internal static void UCr8v9x8egAIReyPuBFJ(object P_0)
	{
		Monitor.Exit(P_0);
	}

	internal static bool GK8HvEx8SwAbOfErKNhp()
	{
		return PM0PRix85yW73GRpGINn == null;
	}

	internal static iUurRSaEdsHhvxFJgcBd cODke2x8x7ns9UCFLhy4()
	{
		return PM0PRix85yW73GRpGINn;
	}

	internal static void Qth18Ix8sh52WFyAZOV5(object P_0)
	{
		((Dictionary<string, MarketDepth>)P_0).Clear();
	}
}
