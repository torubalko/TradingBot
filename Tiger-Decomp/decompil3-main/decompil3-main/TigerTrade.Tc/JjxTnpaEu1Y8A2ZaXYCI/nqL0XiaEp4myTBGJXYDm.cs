using System;
using System.Collections.Generic;
using System.Threading;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using TigerTrade.Tc.Data;
using x97CE55GhEYKgt7TSVZT;

namespace JjxTnpaEu1Y8A2ZaXYCI;

internal sealed class nqL0XiaEp4myTBGJXYDm
{
	private readonly Dictionary<string, double> Ri6aQflEx0k;

	private readonly object JcYaQ9YvREw;

	internal static nqL0XiaEp4myTBGJXYDm GXnVQdx8OU9dyRVGCkad;

	public double SacaEzspYXI(Symbol P_0)
	{
		return S6laQ0lDF14(P_0?.Code);
	}

	public double S6laQ0lDF14(string P_0)
	{
		if (string.IsNullOrEmpty(P_0))
		{
			return 0.0;
		}
		object jcYaQ9YvREw = JcYaQ9YvREw;
		bool lockTaken = false;
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_13e7dc070b7c4c79a18cbee083c6ec1e == 0)
		{
			num = 0;
		}
		switch (num)
		{
		default:
			try
			{
				Monitor.Enter(jcYaQ9YvREw, ref lockTaken);
				int num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_c39cf65fb9834816b04c914d068177cc != 0)
				{
					num2 = 0;
				}
				double value;
				return num2 switch
				{
					_ => Ri6aQflEx0k.TryGetValue(P_0, out value) ? value : 0.0, 
				};
			}
			finally
			{
				if (lockTaken)
				{
					b4vGZxx8WCd1NYymc5Km(jcYaQ9YvREw);
				}
			}
		}
	}

	public void GHvaQ2wNwbJ(Symbol P_0, double P_1)
	{
		J9gaQH5F7Jy(P_0?.Code, P_1);
	}

	public void J9gaQH5F7Jy(string P_0, double P_1)
	{
		if (pRu5ulx8tswkj744Ilg4(P_0))
		{
			return;
		}
		lock (JcYaQ9YvREw)
		{
			if (!Ri6aQflEx0k.TryGetValue(P_0, out var value))
			{
				goto IL_005b;
			}
			goto IL_009a;
			IL_005b:
			Ri6aQflEx0k[P_0] = P_1;
			int num = 1;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a93fb37f4fb14fd7a8fe9a7679ccbe04 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 1:
				return;
			}
			goto IL_009a;
			IL_009a:
			if (Math.Abs(value - P_1) > 0.001)
			{
				goto IL_005b;
			}
		}
	}

	public void Clear()
	{
		object jcYaQ9YvREw = JcYaQ9YvREw;
		bool lockTaken = false;
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_050e60e270a54079b1a645031ef33369 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		try
		{
			Monitor.Enter(jcYaQ9YvREw, ref lockTaken);
			Ri6aQflEx0k.Clear();
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(jcYaQ9YvREw);
			}
		}
	}

	public nqL0XiaEp4myTBGJXYDm()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		Ri6aQflEx0k = new Dictionary<string, double>();
		JcYaQ9YvREw = new object();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_633f94d6c17446778b227aa97d485f89 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static nqL0XiaEp4myTBGJXYDm()
	{
		kPStlxx8UGu08R7de9f8();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool OBZB5Ax8qvNLUUpi7hCN()
	{
		return GXnVQdx8OU9dyRVGCkad == null;
	}

	internal static nqL0XiaEp4myTBGJXYDm D600Kox8I9LHfKFIddPR()
	{
		return GXnVQdx8OU9dyRVGCkad;
	}

	internal static void b4vGZxx8WCd1NYymc5Km(object P_0)
	{
		Monitor.Exit(P_0);
	}

	internal static bool pRu5ulx8tswkj744Ilg4(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static void kPStlxx8UGu08R7de9f8()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
	}
}
