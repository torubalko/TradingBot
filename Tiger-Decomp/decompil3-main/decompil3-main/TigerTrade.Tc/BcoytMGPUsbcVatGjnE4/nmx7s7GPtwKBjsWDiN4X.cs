using System;
using System.Runtime.CompilerServices;
using bFLVeaGpb14YNScYcv2Q;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using TigerTrade.Core.Utils.Binary;
using TigerTrade.Tc.Data;
using x97CE55GhEYKgt7TSVZT;

namespace BcoytMGPUsbcVatGjnE4;

internal sealed class nmx7s7GPtwKBjsWDiN4X : BinWriter
{
	[Flags]
	internal enum rx14TKaqofdKQhQWbsss
	{
		None = 0,
		Last = 2,
		LastSize = 4,
		Bid = 8,
		Ask = 0x10,
		Conditions = 0x80
	}

	private long OkQGPrcPO4c;

	private long GG8GPKZO5oq;

	private long w9WGPmJUfKc;

	private long jL5GPhc53Je;

	private long zKOGPwZ2p8P;

	private long g9jGP71nC14;

	private long K1yGP877IjF;

	private string hSvGPAEAeQ5;

	private readonly double KxhGPPshCg7;

	[CompilerGenerated]
	private DateTime tbPGPJbA5uI;

	private static nmx7s7GPtwKBjsWDiN4X YVM9nV5wqBrwHF2oLFpC;

	[SpecialName]
	[CompilerGenerated]
	internal DateTime KIlGPZKqjr6()
	{
		return tbPGPJbA5uI;
	}

	[SpecialName]
	[CompilerGenerated]
	private void lVMGPVSEoQ4(DateTime P_0)
	{
		tbPGPJbA5uI = P_0;
	}

	public nmx7s7GPtwKBjsWDiN4X(double P_0)
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_aec259916d0a4bcebababa49a58288c4 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				Write(P_0);
				KxhGPPshCg7 = P_0;
				lVMGPVSEoQ4(DateTime.MinValue);
				return;
			}
			Write(2);
			num = 1;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_057f21bc6e4d4f6f9153b4ca132ac862 == 0)
			{
				num = 0;
			}
		}
	}

	public void B9CGPTomDT2(TickEvent P_0)
	{
		if (KxhGPPshCg7 == 0.0)
		{
			return;
		}
		int num;
		if (!bVJivd5wtAcSbMh7e9fo(KIlGPZKqjr6(), P_0.Time))
		{
			lVMGPVSEoQ4(K8YWq95wUwqWXAQNm0gO(P_0));
			num = 17;
		}
		else
		{
			num = 9;
		}
		rx14TKaqofdKQhQWbsss rx14TKaqofdKQhQWbsss = default(rx14TKaqofdKQhQWbsss);
		string text = default(string);
		long ticks = default(long);
		while (true)
		{
			string obj2;
			object obj;
			switch (num)
			{
			default:
				if ((rx14TKaqofdKQhQWbsss & rx14TKaqofdKQhQWbsss.Last) != rx14TKaqofdKQhQWbsss.None)
				{
					WriteLeb128(P_0.Price - GG8GPKZO5oq);
					num = 3;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_0069558de67b47d29bc64855b3a11e20 != 0)
					{
						num = 5;
					}
					continue;
				}
				goto IL_02ba;
			case 11:
				hSvGPAEAeQ5 = text;
				num = 22;
				continue;
			case 14:
				Write(text);
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_8ac3c5fcdf484302951e15fc405858a5 != 0)
				{
					num = 11;
				}
				continue;
			case 16:
				if (zKOGPwZ2p8P != P_0.Ask)
				{
					num = 3;
					continue;
				}
				goto case 10;
			case 15:
				if (hSvGPAEAeQ5 != text)
				{
					num = 13;
					continue;
				}
				goto IL_0077;
			case 1:
				if ((rx14TKaqofdKQhQWbsss & rx14TKaqofdKQhQWbsss.Ask) != rx14TKaqofdKQhQWbsss.None)
				{
					WriteLeb128(P_0.Ask - zKOGPwZ2p8P);
					zKOGPwZ2p8P = JI03aq5wmSQ957awKD6G(P_0);
					num = 12;
					continue;
				}
				goto case 12;
			case 8:
				if ((rx14TKaqofdKQhQWbsss & rx14TKaqofdKQhQWbsss.Bid) != rx14TKaqofdKQhQWbsss.None)
				{
					pHIWEr5wKiq5fEIcMkQX(this, P_0.Bid - jL5GPhc53Je);
					jL5GPhc53Je = P_0.Bid;
					num = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_87bc9f389c844fd48eb0e7e8f7297794 == 0)
					{
						num = 1;
					}
					continue;
				}
				goto case 1;
			case 10:
				if (g9jGP71nC14 != hwcV6b5wyWAW0QdECMwl(P_0))
				{
					num = 20;
					continue;
				}
				goto IL_0224;
			case 9:
				return;
			case 2:
				if ((rx14TKaqofdKQhQWbsss & rx14TKaqofdKQhQWbsss.Conditions) != rx14TKaqofdKQhQWbsss.None)
				{
					num = 14;
					continue;
				}
				return;
			case 6:
				ticks = P_0.Time.Ticks;
				if (ticks < OkQGPrcPO4c)
				{
					return;
				}
				if (OkQGPrcPO4c != ticks)
				{
					rx14TKaqofdKQhQWbsss |= (rx14TKaqofdKQhQWbsss)1;
				}
				if (GG8GPKZO5oq != P_0.Price)
				{
					rx14TKaqofdKQhQWbsss |= rx14TKaqofdKQhQWbsss.Last;
				}
				if (w9WGPmJUfKc != P_0.Size)
				{
					rx14TKaqofdKQhQWbsss |= rx14TKaqofdKQhQWbsss.LastSize;
				}
				if (jL5GPhc53Je != RmWBKS5wTdnZVQF9vsCZ(P_0))
				{
					rx14TKaqofdKQhQWbsss |= rx14TKaqofdKQhQWbsss.Bid;
					num = 16;
					continue;
				}
				goto case 16;
			case 12:
				if ((rx14TKaqofdKQhQWbsss & (rx14TKaqofdKQhQWbsss)32) != rx14TKaqofdKQhQWbsss.None)
				{
					WriteLeb128(P_0.OpenInterest - g9jGP71nC14);
					num = 14;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_13355397408e4ea79e81e5e0aa0e3a16 == 0)
					{
						num = 24;
					}
					continue;
				}
				goto IL_02de;
			case 13:
				rx14TKaqofdKQhQWbsss |= rx14TKaqofdKQhQWbsss.Conditions;
				goto IL_0077;
			case 17:
				rx14TKaqofdKQhQWbsss = rx14TKaqofdKQhQWbsss.None;
				num = 6;
				continue;
			case 19:
				WriteLeb128(ticks - OkQGPrcPO4c);
				OkQGPrcPO4c = ticks;
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_cda90b2e8c4e4a1095d682ebf3835244 == 0)
				{
					num = 0;
				}
				continue;
			case 22:
				return;
			case 5:
				GG8GPKZO5oq = ODkFM15wCKgR5iEyMdZM(P_0);
				goto IL_02ba;
			case 24:
				g9jGP71nC14 = P_0.OpenInterest;
				goto IL_02de;
			case 21:
				obj2 = ((P_0.Side == Side.Buy) ? F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x7F55E538 ^ 0x7F55008C) : F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-3429745 ^ -3453131));
				break;
			case 20:
				rx14TKaqofdKQhQWbsss |= (rx14TKaqofdKQhQWbsss)32;
				goto IL_0224;
			case 23:
			{
				rx14TKaqofdKQhQWbsss |= (rx14TKaqofdKQhQWbsss)64;
				int num2 = 4;
				num = num2;
				continue;
			}
			case 18:
				if (P_0.Bid == 0L && P_0.Ask == 0L)
				{
					num = 21;
					continue;
				}
				goto case 15;
			case 3:
				rx14TKaqofdKQhQWbsss |= rx14TKaqofdKQhQWbsss.Ask;
				num = 10;
				continue;
			case 4:
				obj = JDTUfV5wZU0xndd3bbwH(P_0);
				if (obj != null)
				{
					goto IL_04ff;
				}
				num = 7;
				continue;
			case 7:
				{
					obj = "";
					goto IL_04ff;
				}
				IL_02ba:
				if ((rx14TKaqofdKQhQWbsss & rx14TKaqofdKQhQWbsss.LastSize) == 0)
				{
					goto case 8;
				}
				pHIWEr5wKiq5fEIcMkQX(this, wXIg7g5wrHCCD5fPoT7X(P_0));
				w9WGPmJUfKc = P_0.Size;
				num = 8;
				continue;
				IL_0224:
				if (K1yGP877IjF != P_0.MarketCenter)
				{
					num = 23;
					continue;
				}
				goto case 4;
				IL_04ff:
				text = (string)obj;
				num = 18;
				continue;
				IL_02de:
				if ((rx14TKaqofdKQhQWbsss & (rx14TKaqofdKQhQWbsss)64) != rx14TKaqofdKQhQWbsss.None)
				{
					WriteLeb128(rQS0lS5whh2R9YuWJQ14(P_0));
					K1yGP877IjF = rQS0lS5whh2R9YuWJQ14(P_0);
					num = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_f2a416e6ad3f40c68e350adb5940cd75 == 0)
					{
						num = 2;
					}
					continue;
				}
				goto case 2;
				IL_0077:
				rCg78r5wVviVntHBHpdM(this, (byte)rx14TKaqofdKQhQWbsss);
				if ((rx14TKaqofdKQhQWbsss & (rx14TKaqofdKQhQWbsss)1) != rx14TKaqofdKQhQWbsss.None)
				{
					num = 19;
					continue;
				}
				goto default;
			}
			text = obj2;
			num = 15;
		}
	}

	public byte[] cTAGPyTyIW4()
	{
		return GetStreamData();
	}

	static nmx7s7GPtwKBjsWDiN4X()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool O3OEkQ5wIlrxDiSncZM4()
	{
		return YVM9nV5wqBrwHF2oLFpC == null;
	}

	internal static nmx7s7GPtwKBjsWDiN4X GDwZFa5wWMifIj1wdxst()
	{
		return YVM9nV5wqBrwHF2oLFpC;
	}

	internal static bool bVJivd5wtAcSbMh7e9fo(DateTime P_0, DateTime P_1)
	{
		return P_0 > P_1;
	}

	internal static DateTime K8YWq95wUwqWXAQNm0gO(object P_0)
	{
		return ((TickEvent)P_0).Time;
	}

	internal static long RmWBKS5wTdnZVQF9vsCZ(object P_0)
	{
		return ((TickEvent)P_0).Bid;
	}

	internal static long hwcV6b5wyWAW0QdECMwl(object P_0)
	{
		return ((TickEvent)P_0).OpenInterest;
	}

	internal static object JDTUfV5wZU0xndd3bbwH(object P_0)
	{
		return ((TickEvent)P_0).Conditions;
	}

	internal static void rCg78r5wVviVntHBHpdM(object P_0, byte P_1)
	{
		((BinWriter)P_0).Write(P_1);
	}

	internal static long ODkFM15wCKgR5iEyMdZM(object P_0)
	{
		return ((TickEvent)P_0).Price;
	}

	internal static long wXIg7g5wrHCCD5fPoT7X(object P_0)
	{
		return ((TickEvent)P_0).Size;
	}

	internal static void pHIWEr5wKiq5fEIcMkQX(object P_0, long P_1)
	{
		((BinWriter)P_0).WriteLeb128(P_1);
	}

	internal static long JI03aq5wmSQ957awKD6G(object P_0)
	{
		return ((TickEvent)P_0).Ask;
	}

	internal static long rQS0lS5whh2R9YuWJQ14(object P_0)
	{
		return ((TickEvent)P_0).MarketCenter;
	}
}
