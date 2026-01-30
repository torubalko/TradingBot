using System;
using System.Collections.Generic;
using System.Numerics;
using BfZtb759KlUg4482QKym;
using IqjG5RGpM8HpdaZSkjjx;
using K1GcsD5GTtMSlaiJI0Xh;
using NIkKPXGuH9wBj6WnkSjx;
using TigerTrade.Tc.Data;
using x97CE55GhEYKgt7TSVZT;

namespace bK4Ou0GuYw3lorTWdXps;

internal abstract class ThVuvSGuGmsOKEbslc6A : n94DQwGu2NVuNQEJYC0O
{
	private static ThVuvSGuGmsOKEbslc6A lFfDUa5Amj57nDs0IqMy;

	public virtual void New(UserPosition userPosition, uioCmvGp6sXANp11eX6R execution)
	{
		whg8vq5AA8vmM1kX6vva(userPosition, fw3dE05A7KWxi9BA7QjX(userPosition) + BigInteger.Multiply(YN1wxC5A8TJWbFsJ9Go9(execution.Price), execution.Quantity));
		SsNTf95AJgqyJi5KyEpU(userPosition, hslO6a5APAv3u5o79wZI(execution.Price, YN1wxC5A8TJWbFsJ9Go9(execution.Quantity)));
		fhvNVc5A3MWmhKvoLHiI(userPosition, C1gXkm5AFKkTTh2kDiYH(execution));
		int num = 1;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_fa8be6623d5e44eaab7d6eddb44c1bc4 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				userPosition.Executions.Add(execution);
				return;
			case 1:
				c6D2Qk5ApOWmjPXnu958(userPosition, execution.Quantity);
				userPosition.RealSize = execution.SGpGph7S7WX;
				num = 2;
				break;
			case 2:
				userPosition.TotalValue = hslO6a5APAv3u5o79wZI(execution.Price, Math.Abs(execution.Quantity));
				num = 3;
				break;
			case 3:
				userPosition.TotalQuantity = PSkwwe5AuqytP3UlIN2R(execution.Quantity);
				userPosition.MaxQuantity = PSkwwe5AuqytP3UlIN2R(execution.Quantity);
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_fc8d4bf9d00d4601a17ae4647e849014 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public virtual void Close(UserPosition userPosition, uioCmvGp6sXANp11eX6R execution)
	{
		userPosition.Pnl = BigInteger.Multiply(YN1wxC5A8TJWbFsJ9Go9(execution.Price), eyDEhW5AznAX0uSD5sO6(userPosition)) - userPosition.Pnl;
		userPosition.PriceSum = default(BigInteger);
		int num = 3;
		while (true)
		{
			switch (num)
			{
			default:
				userPosition.Executions.Add(execution);
				return;
			case 1:
				userPosition.RealSize = null;
				num = 2;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_394443c57c4a451f88906434ea248e7b != 0)
				{
					num = 1;
				}
				break;
			case 3:
				fhvNVc5A3MWmhKvoLHiI(userPosition, 0L);
				userPosition.Size = 0L;
				num = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_13a5ccb7e7c94d3d800c9001e431102c != 0)
				{
					num = 0;
				}
				break;
			case 2:
				userPosition.TotalValue += BigInteger.Multiply(YN1wxC5A8TJWbFsJ9Go9(execution.Price), Math.Abs(EkAt7e5P0wlZxChS6TiJ(execution)));
				userPosition.TotalQuantity += PSkwwe5AuqytP3UlIN2R(execution.Quantity);
				userPosition.MaxQuantity = Math.Max(userPosition.MaxQuantity, PSkwwe5AuqytP3UlIN2R(userPosition.Size));
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_cd6be7b090074d37a7e9c91ffedadb35 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public virtual void DTLlo4O5yI9(UserPosition P_0, uioCmvGp6sXANp11eX6R P_1)
	{
		whg8vq5AA8vmM1kX6vva(P_0, L4ipZh5P2rQF4MVv2TOJ(P_0.Pnl, BigInteger.Multiply(YN1wxC5A8TJWbFsJ9Go9(C1gXkm5AFKkTTh2kDiYH(P_1)), P_1.Quantity)));
		c6D2Qk5ApOWmjPXnu958(P_0, P_0.Size + P_1.Quantity);
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_13e7dc070b7c4c79a18cbee083c6ec1e == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				return;
			case 1:
			{
				rI2Dvf5PfrkB6SFqWYDd(P_0, P_0.TotalQuantity + Math.Abs(P_1.Quantity));
				P_0.MaxQuantity = Math.Max(P_0.MaxQuantity, PSkwwe5AuqytP3UlIN2R(P_0.Size));
				P_0.Executions.Add(P_1);
				int num2 = 2;
				num = num2;
				continue;
			}
			}
			decimal? realSize = P_0.RealSize;
			decimal? num3 = P_1.SGpGph7S7WX;
			P_0.RealSize = ((realSize.HasValue & num3.HasValue) ? new decimal?(BpFxxQ5PH4V4PyUKkr3y(realSize.GetValueOrDefault(), num3.GetValueOrDefault())) : ((decimal?)null));
			P_0.TotalValue += BigInteger.Multiply(P_1.Price, PSkwwe5AuqytP3UlIN2R(P_1.Quantity));
			num = 1;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1100fc9af5ab4ad2ab8cefa34e531240 != 0)
			{
				num = 1;
			}
		}
	}

	public virtual void Remove(UserPosition userPosition, uioCmvGp6sXANp11eX6R execution)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				whg8vq5AA8vmM1kX6vva(userPosition, userPosition.Pnl + hslO6a5APAv3u5o79wZI(C1gXkm5AFKkTTh2kDiYH(execution), execution.Quantity));
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_41689ce5632e46808b581b3ddff97952 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				i31i2U5Pnadnqe4MpPWD(userPosition, L4ipZh5P2rQF4MVv2TOJ(Krjg7D5P9dMp8t059dEG(userPosition), BigInteger.Multiply(C1gXkm5AFKkTTh2kDiYH(execution), Math.Abs(execution.Quantity))));
				userPosition.TotalQuantity += Math.Abs(EkAt7e5P0wlZxChS6TiJ(execution));
				userPosition.MaxQuantity = Math.Max(userPosition.MaxQuantity, PSkwwe5AuqytP3UlIN2R(eyDEhW5AznAX0uSD5sO6(userPosition)));
				userPosition.Executions.Add(execution);
				return;
			default:
				userPosition.Size += execution.Quantity;
				num2 = 2;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_67356183f8464ca6962cfffbcb53813d == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				userPosition.RealSize += execution.SGpGph7S7WX;
				num2 = 3;
				break;
			}
		}
	}

	public virtual void Clear(UserPosition userPosition)
	{
		userPosition.Pnl = default(BigInteger);
		userPosition.PriceSum = default(BigInteger);
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a17177e4a01d43aa800589a27b3f7313 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				userPosition.TotalQuantity = 0L;
				num = 3;
				continue;
			case 3:
				FMbWus5PGYrnw1WKR7Eo(userPosition, 0L);
				k3tXeu5PY8cncRuN8tHZ(userPosition.Executions);
				return;
			case 1:
				c6D2Qk5ApOWmjPXnu958(userPosition, 0L);
				userPosition.RealSize = null;
				userPosition.TotalValue = default(BigInteger);
				num = 2;
				continue;
			}
			fhvNVc5A3MWmhKvoLHiI(userPosition, 0L);
			num = 1;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_13a5ccb7e7c94d3d800c9001e431102c == 0)
			{
				num = 1;
			}
		}
	}

	protected long FrSGuotdFjC(UserPosition P_0)
	{
		return dcYGuvnXtQv(wXwasY5PohVCd2rERxj8(P_0.PriceSum), P_0.Size);
	}

	protected long dcYGuvnXtQv(double P_0, double P_1)
	{
		if (P_1 == 0.0)
		{
			return 0L;
		}
		return (long)Math.Round(P_0 / P_1, MidpointRounding.AwayFromZero);
	}

	protected ThVuvSGuGmsOKEbslc6A()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		base._002Ector();
	}

	static ThVuvSGuGmsOKEbslc6A()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static BigInteger fw3dE05A7KWxi9BA7QjX(object P_0)
	{
		return ((UserPosition)P_0).Pnl;
	}

	internal static BigInteger YN1wxC5A8TJWbFsJ9Go9(long P_0)
	{
		return P_0;
	}

	internal static void whg8vq5AA8vmM1kX6vva(object P_0, BigInteger value)
	{
		((UserPosition)P_0).Pnl = value;
	}

	internal static BigInteger hslO6a5APAv3u5o79wZI(BigInteger P_0, BigInteger P_1)
	{
		return BigInteger.Multiply(P_0, P_1);
	}

	internal static void SsNTf95AJgqyJi5KyEpU(object P_0, BigInteger value)
	{
		((UserPosition)P_0).PriceSum = value;
	}

	internal static long C1gXkm5AFKkTTh2kDiYH(object P_0)
	{
		return ((uioCmvGp6sXANp11eX6R)P_0).Price;
	}

	internal static void fhvNVc5A3MWmhKvoLHiI(object P_0, long value)
	{
		((UserPosition)P_0).Price = value;
	}

	internal static void c6D2Qk5ApOWmjPXnu958(object P_0, long value)
	{
		((UserPosition)P_0).Size = value;
	}

	internal static long PSkwwe5AuqytP3UlIN2R(long P_0)
	{
		return Math.Abs(P_0);
	}

	internal static bool vZbTIE5Ah8MXa3cEYvS3()
	{
		return lFfDUa5Amj57nDs0IqMy == null;
	}

	internal static ThVuvSGuGmsOKEbslc6A VX0s4x5Awchv5F9iUc6Q()
	{
		return lFfDUa5Amj57nDs0IqMy;
	}

	internal static long eyDEhW5AznAX0uSD5sO6(object P_0)
	{
		return ((UserPosition)P_0).Size;
	}

	internal static long EkAt7e5P0wlZxChS6TiJ(object P_0)
	{
		return ((uioCmvGp6sXANp11eX6R)P_0).Quantity;
	}

	internal static BigInteger L4ipZh5P2rQF4MVv2TOJ(BigInteger P_0, BigInteger P_1)
	{
		return P_0 + P_1;
	}

	internal static decimal BpFxxQ5PH4V4PyUKkr3y(decimal P_0, decimal P_1)
	{
		return P_0 + P_1;
	}

	internal static void rI2Dvf5PfrkB6SFqWYDd(object P_0, long value)
	{
		((UserPosition)P_0).TotalQuantity = value;
	}

	internal static BigInteger Krjg7D5P9dMp8t059dEG(object P_0)
	{
		return ((UserPosition)P_0).TotalValue;
	}

	internal static void i31i2U5Pnadnqe4MpPWD(object P_0, BigInteger value)
	{
		((UserPosition)P_0).TotalValue = value;
	}

	internal static void FMbWus5PGYrnw1WKR7Eo(object P_0, long value)
	{
		((UserPosition)P_0).MaxQuantity = value;
	}

	internal static void k3tXeu5PY8cncRuN8tHZ(object P_0)
	{
		((List<uioCmvGp6sXANp11eX6R>)P_0).Clear();
	}

	internal static double wXwasY5PohVCd2rERxj8(BigInteger P_0)
	{
		return (double)P_0;
	}
}
