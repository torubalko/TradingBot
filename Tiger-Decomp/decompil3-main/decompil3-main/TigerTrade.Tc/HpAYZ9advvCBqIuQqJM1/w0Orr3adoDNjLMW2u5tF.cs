using System;
using System.Collections.Generic;
using System.Threading;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using TigerTrade.Tc.Data;
using x97CE55GhEYKgt7TSVZT;

namespace HpAYZ9advvCBqIuQqJM1;

internal sealed class w0Orr3adoDNjLMW2u5tF
{
	private long qJWadb0BCyc;

	private readonly Dictionary<long, Order> JPjadNbULmF;

	private readonly Dictionary<string, Order> PBqadkQdsBx;

	private readonly object C3iad1328Kc;

	internal static w0Orr3adoDNjLMW2u5tF QGsHEUxAycKdg5Sr4US4;

	public w0Orr3adoDNjLMW2u5tF()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		qJWadb0BCyc = 1000L;
		JPjadNbULmF = new Dictionary<long, Order>();
		PBqadkQdsBx = new Dictionary<string, Order>();
		C3iad1328Kc = new object();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_af030adc5d834c7fa654aaa946f39572 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				qJWadb0BCyc = 1000L;
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9af6b53eda9a447491409b945b9ad16e == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public void eqHadBEplDl(long P_0)
	{
		qJWadb0BCyc = Math.Max(0L, P_0);
	}

	public void G25adaawyqS(Order P_0, bool P_1 = false)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				P_0.StrCookie = Guid.NewGuid().ToString();
				return;
			case 1:
				if (P_1)
				{
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_85518406d92c400aa3e0339f430d9d7a != 0)
					{
						num2 = 0;
					}
					break;
				}
				P_0.NumCookie = ++qJWadb0BCyc;
				return;
			}
		}
	}

	public void uUhadink4GI(Order P_0, bool P_1 = false)
	{
		int num = 1;
		int num2 = num;
		object c3iad1328Kc = default(object);
		while (true)
		{
			switch (num2)
			{
			case 1:
				c3iad1328Kc = C3iad1328Kc;
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_6914a7e965794704a147f3749924962d != 0)
				{
					num2 = 0;
				}
				continue;
			}
			bool lockTaken = false;
			try
			{
				Monitor.Enter(c3iad1328Kc, ref lockTaken);
				int num3 = 2;
				while (true)
				{
					switch (num3)
					{
					case 1:
						return;
					case 2:
						if (P_1)
						{
							break;
						}
						goto case 3;
					case 3:
						if (P_0.NumCookie == 0L)
						{
							P_0.NumCookie = ++qJWadb0BCyc;
						}
						JPjadNbULmF.Add(P_0.NumCookie, P_0);
						num3 = 1;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a492d58832fc437f977bce5ba015cace != 0)
						{
							num3 = 1;
						}
						continue;
					}
					break;
				}
				if (string.IsNullOrEmpty((string)YKrNsFxAC960TEP5CNcn(P_0)))
				{
					P_0.StrCookie = Guid.NewGuid().ToString(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x7ADBF691 ^ 0x7ADB1B23));
				}
				PBqadkQdsBx.Add(P_0.StrCookie, P_0);
				return;
			}
			finally
			{
				if (lockTaken)
				{
					cgTBORxArhddfkaV9h1K(c3iad1328Kc);
				}
			}
		}
	}

	public Order CTladlaQEbw(long P_0)
	{
		object c3iad1328Kc = C3iad1328Kc;
		bool lockTaken = false;
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_4f84702cc6834fdb9f44daed1fd8e55b == 0)
		{
			num = 0;
		}
		switch (num)
		{
		default:
			try
			{
				Monitor.Enter(c3iad1328Kc, ref lockTaken);
				if (!JPjadNbULmF.ContainsKey(P_0))
				{
					goto IL_007b;
				}
				object obj = JPjadNbULmF[P_0];
				goto IL_00a8;
				IL_007b:
				obj = null;
				goto IL_00a8;
				IL_00a8:
				Order result = (Order)obj;
				int num2 = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_5a00a8f236ab4094a78e373adc786558 == 0)
				{
					num2 = 0;
				}
				switch (num2)
				{
				case 1:
					return result;
				}
				goto IL_007b;
			}
			finally
			{
				if (lockTaken)
				{
					cgTBORxArhddfkaV9h1K(c3iad1328Kc);
				}
			}
		}
	}

	public bool VYUad4peLPf(string P_0)
	{
		if (!string.IsNullOrEmpty(P_0))
		{
			return PBqadkQdsBx.ContainsKey(P_0);
		}
		return false;
	}

	public Order DGKadD52Epx(string P_0)
	{
		int num = 1;
		int num2 = num;
		object c3iad1328Kc = default(object);
		Order result = default(Order);
		while (true)
		{
			switch (num2)
			{
			case 1:
				c3iad1328Kc = C3iad1328Kc;
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_8ac3c5fcdf484302951e15fc405858a5 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			bool lockTaken = false;
			try
			{
				Monitor.Enter(c3iad1328Kc, ref lockTaken);
				int num3 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_4f84702cc6834fdb9f44daed1fd8e55b == 0)
				{
					num3 = 0;
				}
				while (true)
				{
					switch (num3)
					{
					case 1:
						return result;
					}
					result = ((!string.IsNullOrEmpty(P_0) && PBqadkQdsBx.ContainsKey(P_0)) ? PBqadkQdsBx[P_0] : null);
					num3 = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_6f0ba3007e7244cca15e3c59471bb079 == 0)
					{
						num3 = 1;
					}
				}
			}
			finally
			{
				if (lockTaken)
				{
					cgTBORxArhddfkaV9h1K(c3iad1328Kc);
				}
			}
		}
	}

	public void Clear()
	{
	}

	static w0Orr3adoDNjLMW2u5tF()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool thCrBexAZGjcAk0lufm2()
	{
		return QGsHEUxAycKdg5Sr4US4 == null;
	}

	internal static w0Orr3adoDNjLMW2u5tF L2MDkLxAVDecjiepgygE()
	{
		return QGsHEUxAycKdg5Sr4US4;
	}

	internal static object YKrNsFxAC960TEP5CNcn(object P_0)
	{
		return ((Order)P_0).StrCookie;
	}

	internal static void cgTBORxArhddfkaV9h1K(object P_0)
	{
		Monitor.Exit(P_0);
	}
}
