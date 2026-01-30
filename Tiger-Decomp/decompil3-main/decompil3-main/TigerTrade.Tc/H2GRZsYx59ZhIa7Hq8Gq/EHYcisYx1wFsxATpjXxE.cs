using System;
using bFLVeaGpb14YNScYcv2Q;
using BfZtb759KlUg4482QKym;
using fDaAnbYSYaWjWwFG6Wwg;
using K1GcsD5GTtMSlaiJI0Xh;
using lZa1RcYxpceOGCE3D2AW;
using TigerTrade.Core.Utils.Binary;
using TigerTrade.Tc.Data;
using TigerTrade.Tc.History;
using x97CE55GhEYKgt7TSVZT;

namespace H2GRZsYx59ZhIa7Hq8Gq;

internal sealed class EHYcisYx1wFsxATpjXxE : MZa5L2YSGdvn6R9rvcQn
{
	private readonly TicksReader fsXYxxsHoOB;

	private TickEvent zVkYxLo2wuh;

	internal static EHYcisYx1wFsxATpjXxE ViKKkjSbpAhAoUpJg2l1;

	public EHYcisYx1wFsxATpjXxE(Symbol P_0, byte[] P_1, DateTime P_2)
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_e37b704f00fd438985274655b11b16b4 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				uNaYSboPyWt(P_0);
				base.Symbol = new ac7kR4Yx3NknD6U6jcv9
				{
					XvdYL0y97HI = (string)agAjtFSN0W9JuElXwqSy(P_0),
					Type = (int)P_0.Type,
					Symbol = P_0.Code,
					HdcYL22OuqD = P_0.Exchange,
					Name = P_0.Name,
					ShortName = P_0.Name,
					KrWYLHKXf7w = gRxjWdSN2HaKDkVlQIB5(P_0),
					peOYLfOpD0D = P_0.Step
				};
				y80YS1SEk52(P_2);
				num = 3;
				break;
			case 2:
				if (!fsXYxxsHoOB.Read())
				{
					return;
				}
				zVkYxLo2wuh = fsXYxxsHoOB.LastItem;
				yxyYSx1pFQs(zVkYxLo2wuh.Time);
				FoWYSsTpo6P(_0020: true);
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_f19bbaca9e82419ba66f0bdafd2c824a == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			case 3:
				fsXYxxsHoOB = new TicksReader(P_0, P_1, P_0.Step, P_0.SizeStep, TimeSpan.Zero, P_0.Type == SymbolType.Forex);
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_0069558de67b47d29bc64855b3a11e20 != 0)
				{
					num = 2;
				}
				break;
			}
		}
	}

	public override void cFSloqb3PWY()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (fsXYxxsHoOB.LastItem != null)
				{
					zVkYxLo2wuh = fsXYxxsHoOB.LastItem;
					num2 = 4;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_2b9e363b0abc4a32a96694deb0f4f698 == 0)
					{
						num2 = 3;
					}
					break;
				}
				goto IL_0071;
			case 2:
				CBJYSiauC1x(zVkYxLo2wuh);
				IVcYSaFs0qC(base.Symbol, gmaYSkfmP6q(), XOhYSSErelt());
				goto default;
			case 1:
				if (zVkYxLo2wuh == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_f2a416e6ad3f40c68e350adb5940cd75 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 4:
				yxyYSx1pFQs(zVkYxLo2wuh.Time);
				return;
			default:
				{
					if (Q6g08VSNHCKVETs2CbKF(fsXYxxsHoOB))
					{
						num2 = 3;
						break;
					}
					goto IL_0071;
				}
				IL_0071:
				yxyYSx1pFQs(DateTime.MaxValue);
				return;
			}
		}
	}

	public override void kL3loIX78kK()
	{
		AgUDbZSNf2Wgh5rYMTTy(fsXYxxsHoOB);
		int num;
		while (true)
		{
			if (!fsXYxxsHoOB.Read())
			{
				zVkYxLo2wuh = null;
				num = 2;
				break;
			}
			if (!VcTYxSjXmbO(fsXYxxsHoOB.LastItem))
			{
				zVkYxLo2wuh = fsXYxxsHoOB.LastItem;
				yxyYSx1pFQs(SnDgToSN9gxlXUZpKEO6(zVkYxLo2wuh));
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_376f2bcb10134b91b6257ed8645d119a != 0)
				{
					num = 0;
				}
				break;
			}
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				yxyYSx1pFQs(DateTime.MinValue);
				num = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_41689ce5632e46808b581b3ddff97952 != 0)
				{
					num = 1;
				}
				break;
			case 1:
				return;
			}
		}
	}

	private bool VcTYxSjXmbO(TickEvent P_0)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				if (P_0.Time.Hour >= 10)
				{
					goto IL_00a8;
				}
				if (!((string)YDCxToSNnaWsRmwuqZNP(zrLYSDyV0le()) == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x16AD7E76 ^ 0x16AD904E)))
				{
					num2 = 2;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_09c5bd75193a4fbe995d693b67f9f226 == 0)
					{
						num2 = 2;
					}
					break;
				}
				return true;
			case 2:
				return zrLYSDyV0le().Exchange == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x684F243E ^ 0x684FCA7A);
			case 1:
				{
					if (zrLYSDyV0le().Type == SymbolType.Index)
					{
						num2 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_eb6cefc1df37468ab8b9384866953722 != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto IL_00a8;
				}
				IL_00a8:
				return false;
			}
		}
	}

	static EHYcisYx1wFsxATpjXxE()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static object agAjtFSN0W9JuElXwqSy(object P_0)
	{
		return ((Symbol)P_0).ID;
	}

	internal static int gRxjWdSN2HaKDkVlQIB5(object P_0)
	{
		return ((Symbol)P_0).Precision;
	}

	internal static bool w75xulSbux41cOQQENHE()
	{
		return ViKKkjSbpAhAoUpJg2l1 == null;
	}

	internal static EHYcisYx1wFsxATpjXxE HJBcppSbzgyrPXXkjspp()
	{
		return ViKKkjSbpAhAoUpJg2l1;
	}

	internal static bool Q6g08VSNHCKVETs2CbKF(object P_0)
	{
		return ((BinReader<TickEvent>)P_0).Read();
	}

	internal static void AgUDbZSNf2Wgh5rYMTTy(object P_0)
	{
		((BinReader<TickEvent>)P_0).Reset();
	}

	internal static DateTime SnDgToSN9gxlXUZpKEO6(object P_0)
	{
		return ((TickEvent)P_0).Time;
	}

	internal static object YDCxToSNnaWsRmwuqZNP(object P_0)
	{
		return ((SymbolBase)P_0).Exchange;
	}
}
