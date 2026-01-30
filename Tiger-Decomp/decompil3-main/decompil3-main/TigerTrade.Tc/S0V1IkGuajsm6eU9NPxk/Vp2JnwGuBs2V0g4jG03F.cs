using System;
using System.Numerics;
using BfZtb759KlUg4482QKym;
using bK4Ou0GuYw3lorTWdXps;
using IqjG5RGpM8HpdaZSkjjx;
using K1GcsD5GTtMSlaiJI0Xh;
using TigerTrade.Tc.Data;
using x97CE55GhEYKgt7TSVZT;

namespace S0V1IkGuajsm6eU9NPxk;

internal class Vp2JnwGuBs2V0g4jG03F : ThVuvSGuGmsOKEbslc6A
{
	internal static Vp2JnwGuBs2V0g4jG03F HSQQXW5PvShqhUsUcIfl;

	public override void New(UserPosition userPosition, uioCmvGp6sXANp11eX6R execution)
	{
		base.New(userPosition, execution);
	}

	public override void Close(UserPosition userPosition, uioCmvGp6sXANp11eX6R execution)
	{
		base.Close(userPosition, execution);
	}

	public override void DTLlo4O5yI9(UserPosition P_0, uioCmvGp6sXANp11eX6R P_1)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				kVFnMf5PDiNEmheeYwrk(P_0, bQiosv5P44AF3n4EGQ8V(P_0.PriceSum, BigInteger.Multiply(P_1.Price, lenyTR5PlG8rIR97Go4U(P_1))));
				w1hVVi5PblrQohlnEIk5(P_0, P_0.Size + P_1.Quantity);
				num2 = 3;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_c82b80986db149fc8e857dfed661c1a6 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				P_0.Pnl += BigInteger.Multiply(IB4VOf5PillrNKTKwYUd(P_1), lenyTR5PlG8rIR97Go4U(P_1));
				num2 = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_db475a540dcc44d9a72c3f197bb7b1f7 != 0)
				{
					num2 = 1;
				}
				break;
			default:
				P_0.MaxQuantity = Math.Max(tKQxuj5PSTase0MXkBUE(P_0), Math.Abs(P_0.Size));
				return;
			case 3:
				P_0.RealSize += P_1.SGpGph7S7WX;
				ahadx25PNSkDsR2MWLSq(P_0, FrSGuotdFjC(P_0));
				P_0.TotalValue = bQiosv5P44AF3n4EGQ8V(P_0.TotalValue, BigInteger.Multiply(P_1.Price, vOi45V5PkTKBJLNbCsuB(lenyTR5PlG8rIR97Go4U(P_1))));
				BVl2cJ5P5mMNvsc7UHDb(P_0, Yo1gyF5P19TMnnFJjRxf(P_0) + Math.Abs(P_1.Quantity));
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_050e60e270a54079b1a645031ef33369 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override void Remove(UserPosition userPosition, uioCmvGp6sXANp11eX6R execution)
	{
		qOdUiB5PxhP7NiLcvACP(userPosition, bQiosv5P44AF3n4EGQ8V(userPosition.Pnl, BigInteger.Multiply(execution.Price, lenyTR5PlG8rIR97Go4U(execution))));
		userPosition.PriceSum = bQiosv5P44AF3n4EGQ8V(userPosition.PriceSum, BigInteger.Multiply(execution.Price, execution.Quantity));
		w1hVVi5PblrQohlnEIk5(userPosition, userPosition.Size + execution.Quantity);
		int num = 1;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_20e7e617d0f34403acbdcd4eaa1fe0e9 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				userPosition.Price = FrSGuotdFjC(userPosition);
				num = 2;
				break;
			case 2:
				userPosition.TotalValue += BigInteger.Multiply(execution.Price, Math.Abs(execution.Quantity));
				userPosition.TotalQuantity -= Math.Abs(execution.Quantity);
				userPosition.MaxQuantity = Math.Max(tKQxuj5PSTase0MXkBUE(userPosition), Math.Abs(userPosition.Size));
				return;
			case 1:
			{
				decimal? realSize = userPosition.RealSize;
				decimal? num2 = execution.SGpGph7S7WX;
				userPosition.RealSize = ((realSize.HasValue & num2.HasValue) ? new decimal?(GqKL5P5PLJZsuDnFX4Lv(realSize.GetValueOrDefault(), num2.GetValueOrDefault())) : ((decimal?)null));
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_18fbecec0dfa44d6afb647cf0f10b685 == 0)
				{
					num = 0;
				}
				break;
			}
			}
		}
	}

	public Vp2JnwGuBs2V0g4jG03F()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		base._002Ector();
	}

	static Vp2JnwGuBs2V0g4jG03F()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool rjibw65PB2vXGfrMZiBQ()
	{
		return HSQQXW5PvShqhUsUcIfl == null;
	}

	internal static Vp2JnwGuBs2V0g4jG03F JEpBRJ5PacVK9mbfwrft()
	{
		return HSQQXW5PvShqhUsUcIfl;
	}

	internal static long IB4VOf5PillrNKTKwYUd(object P_0)
	{
		return ((uioCmvGp6sXANp11eX6R)P_0).Price;
	}

	internal static long lenyTR5PlG8rIR97Go4U(object P_0)
	{
		return ((uioCmvGp6sXANp11eX6R)P_0).Quantity;
	}

	internal static BigInteger bQiosv5P44AF3n4EGQ8V(BigInteger P_0, BigInteger P_1)
	{
		return P_0 + P_1;
	}

	internal static void kVFnMf5PDiNEmheeYwrk(object P_0, BigInteger value)
	{
		((UserPosition)P_0).PriceSum = value;
	}

	internal static void w1hVVi5PblrQohlnEIk5(object P_0, long value)
	{
		((UserPosition)P_0).Size = value;
	}

	internal static void ahadx25PNSkDsR2MWLSq(object P_0, long value)
	{
		((UserPosition)P_0).Price = value;
	}

	internal static long vOi45V5PkTKBJLNbCsuB(long P_0)
	{
		return Math.Abs(P_0);
	}

	internal static long Yo1gyF5P19TMnnFJjRxf(object P_0)
	{
		return ((UserPosition)P_0).TotalQuantity;
	}

	internal static void BVl2cJ5P5mMNvsc7UHDb(object P_0, long value)
	{
		((UserPosition)P_0).TotalQuantity = value;
	}

	internal static long tKQxuj5PSTase0MXkBUE(object P_0)
	{
		return ((UserPosition)P_0).MaxQuantity;
	}

	internal static void qOdUiB5PxhP7NiLcvACP(object P_0, BigInteger value)
	{
		((UserPosition)P_0).Pnl = value;
	}

	internal static decimal GqKL5P5PLJZsuDnFX4Lv(decimal P_0, decimal P_1)
	{
		return P_0 + P_1;
	}
}
