using System.Collections.Generic;
using System.Threading;
using BcoytMGPUsbcVatGjnE4;
using bFLVeaGpb14YNScYcv2Q;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using TigerTrade.Tc.Data;
using x97CE55GhEYKgt7TSVZT;

namespace KOWlDaY1vtw5BYDxJyT0;

internal sealed class LrPEAGY1o6rbef20jWY7
{
	private readonly Dictionary<string, nmx7s7GPtwKBjsWDiN4X> DddY1idMlI7;

	private static LrPEAGY1o6rbef20jWY7 PUbi0tSlqChF8smT4UCE;

	public void qNhY1BfXGUZ(Symbol P_0, TickEvent P_1)
	{
		if (P_0 == null)
		{
			return;
		}
		while (P_1 != null)
		{
			Dictionary<string, nmx7s7GPtwKBjsWDiN4X> dddY1idMlI = DddY1idMlI7;
			int num = 2;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_6f5dc499481a49afb38f5cf60a5c6a60 == 0)
			{
				num = 2;
			}
			switch (num)
			{
			default:
				return;
			case 2:
			{
				bool lockTaken = false;
				try
				{
					Monitor.Enter(dddY1idMlI, ref lockTaken);
					int num2 = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_376f2bcb10134b91b6257ed8645d119a == 0)
					{
						num2 = 1;
					}
					while (true)
					{
						switch (num2)
						{
						default:
							return;
						case 1:
							if (DddY1idMlI7.ContainsKey(P_0.ID))
							{
								DddY1idMlI7[(string)yAYen9SltiN1WlLpend8(P_0)].B9CGPTomDT2(P_1);
								num2 = 0;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_2417c17afc5747a7a781c50dbd7d5d7c != 0)
								{
									num2 = 0;
								}
								break;
							}
							DddY1idMlI7.Add(P_0.ID, new nmx7s7GPtwKBjsWDiN4X(mAJs4LSlUjXh0NNgqxXk(P_0)));
							return;
						case 0:
							return;
						}
					}
				}
				finally
				{
					if (lockTaken)
					{
						Monitor.Exit(dddY1idMlI);
					}
				}
			}
			case 0:
				return;
			case 1:
				break;
			}
		}
	}

	public byte[] oU8Y1aNRUwX(string P_0)
	{
		Dictionary<string, nmx7s7GPtwKBjsWDiN4X> dddY1idMlI = DddY1idMlI7;
		bool lockTaken = false;
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_6f5dc499481a49afb38f5cf60a5c6a60 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		default:
			try
			{
				Monitor.Enter(dddY1idMlI, ref lockTaken);
				object result;
				if (!DddY1idMlI7.ContainsKey(P_0))
				{
					int num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_267b6e28e0b84cf5a9effc88636b52de == 0)
					{
						num2 = 0;
					}
					switch (num2)
					{
					}
					result = new byte[0];
				}
				else
				{
					result = l5TPwCSlTbPuGjfWdcRn(DddY1idMlI7[P_0]);
				}
				return (byte[])result;
			}
			finally
			{
				if (lockTaken)
				{
					Monitor.Exit(dddY1idMlI);
				}
			}
		}
	}

	public void Clear()
	{
		Dictionary<string, nmx7s7GPtwKBjsWDiN4X> dddY1idMlI = DddY1idMlI7;
		bool lockTaken = false;
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_b6dfeebb9aa04a23846c37da6e9b7d4d == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		try
		{
			Monitor.Enter(dddY1idMlI, ref lockTaken);
			cfd5qQSlyrdgKxrX8Ymm(DddY1idMlI7);
		}
		finally
		{
			if (lockTaken)
			{
				aICWv3SlZEQPo27bFbQj(dddY1idMlI);
			}
		}
	}

	public LrPEAGY1o6rbef20jWY7()
	{
		JjjPukSlVRQ1pnhRXweo();
		DddY1idMlI7 = new Dictionary<string, nmx7s7GPtwKBjsWDiN4X>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_6f5dc499481a49afb38f5cf60a5c6a60 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static LrPEAGY1o6rbef20jWY7()
	{
		gHl2ESSlCwg5gXhH3wDr();
		Ox8fd7SlraBudg4JL2Kt();
	}

	internal static object yAYen9SltiN1WlLpend8(object P_0)
	{
		return ((Symbol)P_0).ID;
	}

	internal static double mAJs4LSlUjXh0NNgqxXk(object P_0)
	{
		return ((SymbolBase)P_0).Step;
	}

	internal static bool XF0mMDSlIEfeQIeryakg()
	{
		return PUbi0tSlqChF8smT4UCE == null;
	}

	internal static LrPEAGY1o6rbef20jWY7 zMGiqQSlWSRM8bJvsbOp()
	{
		return PUbi0tSlqChF8smT4UCE;
	}

	internal static object l5TPwCSlTbPuGjfWdcRn(object P_0)
	{
		return ((nmx7s7GPtwKBjsWDiN4X)P_0).cTAGPyTyIW4();
	}

	internal static void cfd5qQSlyrdgKxrX8Ymm(object P_0)
	{
		((Dictionary<string, nmx7s7GPtwKBjsWDiN4X>)P_0).Clear();
	}

	internal static void aICWv3SlZEQPo27bFbQj(object P_0)
	{
		Monitor.Exit(P_0);
	}

	internal static void JjjPukSlVRQ1pnhRXweo()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
	}

	internal static void gHl2ESSlCwg5gXhH3wDr()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
	}

	internal static void Ox8fd7SlraBudg4JL2Kt()
	{
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}
}
