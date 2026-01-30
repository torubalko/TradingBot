using System;
using System.Numerics;
using BfZtb759KlUg4482QKym;
using bK4Ou0GuYw3lorTWdXps;
using IqjG5RGpM8HpdaZSkjjx;
using K1GcsD5GTtMSlaiJI0Xh;
using TigerTrade.Tc.Data;
using x97CE55GhEYKgt7TSVZT;

namespace rU0ObGGuLGgrPU67U4H0;

internal class HIpyYGGux8yDt3ZakUAG : ThVuvSGuGmsOKEbslc6A
{
	internal static HIpyYGGux8yDt3ZakUAG A98fCy5PpAa1Lup4DeGf;

	public override void New(UserPosition userPosition, uioCmvGp6sXANp11eX6R execution)
	{
		base.New(userPosition, execution);
	}

	public override void Close(UserPosition userPosition, uioCmvGp6sXANp11eX6R execution)
	{
		XbMRJF5J0uckMwE15Gil(userPosition, (execution.Price - userPosition.Price) * userPosition.Size);
		userPosition.PriceSum = default(BigInteger);
		userPosition.Price = 0L;
		userPosition.Size = 0L;
		userPosition.RealSize = null;
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_18fbecec0dfa44d6afb647cf0f10b685 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				userPosition.TotalQuantity += Math.Abs(LKZkoe5Jf0mRMpVsW3nj(execution));
				num = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a492d58832fc437f977bce5ba015cace == 0)
				{
					num = 1;
				}
				break;
			case 1:
				userPosition.MaxQuantity = p0aCEo5JnZDDAoqwKqxr(userPosition.MaxQuantity, O9i3cj5J9sCwLl0CHaqX(userPosition.Size));
				return;
			default:
				userPosition.TotalValue += bdneaG5JHxlvfSWFwVl7(bDYfVX5J2XWvsuJtPodH(execution), Math.Abs(execution.Quantity));
				num = 2;
				break;
			}
		}
	}

	public override void DTLlo4O5yI9(UserPosition P_0, uioCmvGp6sXANp11eX6R P_1)
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				P_0.Size = veh25F5JYwVEY4Fykasd(P_0) + LKZkoe5Jf0mRMpVsW3nj(P_1);
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_82741674950e4c70a0407e3b1a670169 == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				XbMRJF5J0uckMwE15Gil(P_0, P_0.Pnl + BigInteger.Multiply(P_1.Price, O7N6Fo5JGdAjOvognxg8(P_1.Quantity)));
				num2 = 2;
				break;
			case 2:
				P_0.PriceSum += BigInteger.Multiply(bDYfVX5J2XWvsuJtPodH(P_1), O7N6Fo5JGdAjOvognxg8(P_1.Quantity));
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a93fb37f4fb14fd7a8fe9a7679ccbe04 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
			{
				decimal? realSize = P_0.RealSize;
				decimal? num3 = P_1.SGpGph7S7WX;
				P_0.RealSize = ((realSize.HasValue & num3.HasValue) ? new decimal?(B6YV1j5JoaH7fJSgabgi(realSize.GetValueOrDefault(), num3.GetValueOrDefault())) : ((decimal?)null));
				P_0.Price = FrSGuotdFjC(P_0);
				P_0.TotalValue = zf65cP5JvjUB5C9w8brX(P_0) + BigInteger.Multiply(O7N6Fo5JGdAjOvognxg8(P_1.Price), Math.Abs(P_1.Quantity));
				P_0.TotalQuantity += Math.Abs(LKZkoe5Jf0mRMpVsW3nj(P_1));
				P_0.MaxQuantity = Math.Max(fBr4iB5JBB0wWMoE74ej(P_0), O9i3cj5J9sCwLl0CHaqX(P_0.Size));
				return;
			}
			}
		}
	}

	public override void Remove(UserPosition userPosition, uioCmvGp6sXANp11eX6R execution)
	{
		XbMRJF5J0uckMwE15Gil(userPosition, gLsMnx5JaKfLrZVPcJmE(userPosition) + BigInteger.Multiply(O7N6Fo5JGdAjOvognxg8(execution.Price), execution.Quantity));
		userPosition.Size += execution.Quantity;
		int num = 3;
		while (true)
		{
			switch (num)
			{
			case 1:
				userPosition.PriceSum = FSN3FL5JiT6t1ARKoawH(userPosition) + BigInteger.Multiply(userPosition.Price, execution.Quantity);
				userPosition.Price = FrSGuotdFjC(userPosition);
				num = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_057f21bc6e4d4f6f9153b4ca132ac862 != 0)
				{
					num = 2;
				}
				break;
			default:
				vFoOsp5JliO9brhMs6WD(userPosition, Math.Max(fBr4iB5JBB0wWMoE74ej(userPosition), O9i3cj5J9sCwLl0CHaqX(userPosition.Size)));
				dAMoZ55J49bxqhRDayHV(userPosition, 0.0);
				return;
			case 2:
				userPosition.TotalValue += BigInteger.Multiply(execution.Price, O7N6Fo5JGdAjOvognxg8(Math.Abs(LKZkoe5Jf0mRMpVsW3nj(execution))));
				userPosition.TotalQuantity -= O9i3cj5J9sCwLl0CHaqX(execution.Quantity);
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_050e60e270a54079b1a645031ef33369 == 0)
				{
					num = 0;
				}
				break;
			case 3:
				userPosition.RealSize += execution.SGpGph7S7WX;
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_6914a7e965794704a147f3749924962d == 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	public HIpyYGGux8yDt3ZakUAG()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		base._002Ector();
	}

	static HIpyYGGux8yDt3ZakUAG()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool Fe9UFb5Pu8L2nTOo9iaV()
	{
		return A98fCy5PpAa1Lup4DeGf == null;
	}

	internal static HIpyYGGux8yDt3ZakUAG kIU05C5Pz9m5D8lIvPMn()
	{
		return A98fCy5PpAa1Lup4DeGf;
	}

	internal static void XbMRJF5J0uckMwE15Gil(object P_0, BigInteger value)
	{
		((UserPosition)P_0).Pnl = value;
	}

	internal static long bDYfVX5J2XWvsuJtPodH(object P_0)
	{
		return ((uioCmvGp6sXANp11eX6R)P_0).Price;
	}

	internal static BigInteger bdneaG5JHxlvfSWFwVl7(BigInteger P_0, BigInteger P_1)
	{
		return BigInteger.Multiply(P_0, P_1);
	}

	internal static long LKZkoe5Jf0mRMpVsW3nj(object P_0)
	{
		return ((uioCmvGp6sXANp11eX6R)P_0).Quantity;
	}

	internal static long O9i3cj5J9sCwLl0CHaqX(long P_0)
	{
		return Math.Abs(P_0);
	}

	internal static long p0aCEo5JnZDDAoqwKqxr(long P_0, long P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static BigInteger O7N6Fo5JGdAjOvognxg8(long P_0)
	{
		return P_0;
	}

	internal static long veh25F5JYwVEY4Fykasd(object P_0)
	{
		return ((UserPosition)P_0).Size;
	}

	internal static decimal B6YV1j5JoaH7fJSgabgi(decimal P_0, decimal P_1)
	{
		return P_0 + P_1;
	}

	internal static BigInteger zf65cP5JvjUB5C9w8brX(object P_0)
	{
		return ((UserPosition)P_0).TotalValue;
	}

	internal static long fBr4iB5JBB0wWMoE74ej(object P_0)
	{
		return ((UserPosition)P_0).MaxQuantity;
	}

	internal static BigInteger gLsMnx5JaKfLrZVPcJmE(object P_0)
	{
		return ((UserPosition)P_0).Pnl;
	}

	internal static BigInteger FSN3FL5JiT6t1ARKoawH(object P_0)
	{
		return ((UserPosition)P_0).PriceSum;
	}

	internal static void vFoOsp5JliO9brhMs6WD(object P_0, long value)
	{
		((UserPosition)P_0).MaxQuantity = value;
	}

	internal static void dAMoZ55J49bxqhRDayHV(object P_0, double value)
	{
		((UserPosition)P_0).Comission = value;
	}
}
