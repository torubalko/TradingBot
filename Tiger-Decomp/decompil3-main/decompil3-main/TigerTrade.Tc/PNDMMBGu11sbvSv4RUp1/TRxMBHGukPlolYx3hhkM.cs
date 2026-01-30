using System;
using System.Collections.Generic;
using System.Numerics;
using BfZtb759KlUg4482QKym;
using bK4Ou0GuYw3lorTWdXps;
using IqjG5RGpM8HpdaZSkjjx;
using K1GcsD5GTtMSlaiJI0Xh;
using TigerTrade.Tc.Data;
using x97CE55GhEYKgt7TSVZT;

namespace PNDMMBGu11sbvSv4RUp1;

internal class TRxMBHGukPlolYx3hhkM : ThVuvSGuGmsOKEbslc6A
{
	private readonly Stack<uioCmvGp6sXANp11eX6R> wwVGuSnbrfB;

	private static TRxMBHGukPlolYx3hhkM Pb0Vgo5PK1ds64dYS71C;

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
		base.DTLlo4O5yI9(P_0, P_1);
		ebJGu51w7ux(P_0, P_1);
	}

	public override void Remove(UserPosition userPosition, uioCmvGp6sXANp11eX6R execution)
	{
		base.Remove(userPosition, execution);
		ebJGu51w7ux(userPosition, execution);
	}

	public override void Clear(UserPosition userPosition)
	{
		base.Clear(userPosition);
		wwVGuSnbrfB.Clear();
	}

	private void ebJGu51w7ux(UserPosition P_0, uioCmvGp6sXANp11eX6R P_1)
	{
		P_0.Pnl = default(BigInteger);
		P_0.PriceSum = default(BigInteger);
		P_0.Price = 0L;
		wwVGuSnbrfB.Clear();
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_aec259916d0a4bcebababa49a58288c4 == 0)
		{
			num = 0;
		}
		uioCmvGp6sXANp11eX6R uioCmvGp6sXANp11eX6R = default(uioCmvGp6sXANp11eX6R);
		long num4 = default(long);
		List<uioCmvGp6sXANp11eX6R>.Enumerator enumerator = default(List<uioCmvGp6sXANp11eX6R>.Enumerator);
		uioCmvGp6sXANp11eX6R uioCmvGp6sXANp11eX6R2 = default(uioCmvGp6sXANp11eX6R);
		Stack<uioCmvGp6sXANp11eX6R>.Enumerator enumerator2 = default(Stack<uioCmvGp6sXANp11eX6R>.Enumerator);
		while (true)
		{
			switch (num)
			{
			default:
				uioCmvGp6sXANp11eX6R = P_0.Executions[0];
				num4 = 0L;
				num = 3;
				break;
			case 2:
				try
				{
					while (enumerator.MoveNext())
					{
						uioCmvGp6sXANp11eX6R current2 = enumerator.Current;
						P_0.Pnl = oGMSno5PwbUDt2A9L1ch(P_0) + BigInteger.Multiply(current2.Price, current2.Quantity);
						int num3;
						if (Math.Sign(current2.Quantity) == zNw8h95P7tnTpgo1n8PH(uioCmvGp6sXANp11eX6R.Quantity))
						{
							num3 = 0;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_f3678a7908b24fbf90f40bdd06f93585 == 0)
							{
								num3 = 1;
							}
							goto IL_0046;
						}
						goto IL_00ce;
						IL_0262:
						uioCmvGp6sXANp11eX6R2 = wwVGuSnbrfB.Peek();
						if (uioCmvGp6sXANp11eX6R2.Quantity == 0L)
						{
							wwVGuSnbrfB.Pop();
							num3 = 0;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_137abeaac6b54c2d909c4f75bdf9527a == 0)
							{
								num3 = 0;
							}
							goto IL_0046;
						}
						goto IL_0221;
						IL_0221:
						if (wNDpya5P8JCtOFpY9fRu(UrqnwM5PAovhZkcdxAn3(uioCmvGp6sXANp11eX6R2)) < num4)
						{
							num4 -= Math.Abs(uioCmvGp6sXANp11eX6R2.Quantity);
							uioCmvGp6sXANp11eX6R2.Quantity = 0L;
							num3 = 6;
						}
						else
						{
							uioCmvGp6sXANp11eX6R uioCmvGp6sXANp11eX6R3 = uioCmvGp6sXANp11eX6R2;
							uioCmvGp6sXANp11eX6R3.Quantity = UrqnwM5PAovhZkcdxAn3(uioCmvGp6sXANp11eX6R3) - Math.Sign(uioCmvGp6sXANp11eX6R2.Quantity) * num4;
							num4 = 0L;
							num3 = 4;
						}
						goto IL_0046;
						IL_0046:
						switch (num3)
						{
						case 3:
						case 4:
							break;
						case 8:
							goto IL_00ce;
						default:
							goto IL_0169;
						case 1:
							wwVGuSnbrfB.Push(current2.bX7GpOLl1qd());
							break;
						case 5:
							goto IL_0221;
						case 2:
							goto IL_0262;
						}
						continue;
						IL_00ce:
						num4 += wNDpya5P8JCtOFpY9fRu(current2.Quantity);
						goto IL_0169;
						IL_0169:
						if (eZm54v5PPvd5t3gkPdSm(wwVGuSnbrfB) <= 0)
						{
							continue;
						}
						goto IL_0262;
					}
				}
				finally
				{
					((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
				}
				enumerator2 = wwVGuSnbrfB.GetEnumerator();
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_fa8be6623d5e44eaab7d6eddb44c1bc4 == 0)
				{
					num = 1;
				}
				break;
			case 1:
				try
				{
					while (enumerator2.MoveNext())
					{
						while (true)
						{
							uioCmvGp6sXANp11eX6R current = enumerator2.Current;
							P_0.PriceSum = kw538U5P3GNqSOOHPbTp(P_0.PriceSum, NY6Z4q5PFgFmqaPD2J43(current.Price, ayCGme5PJoP291mgNLBO(UrqnwM5PAovhZkcdxAn3(current))));
							P_0.Price = FrSGuotdFjC(P_0);
							int num2 = 0;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1100fc9af5ab4ad2ab8cefa34e531240 == 0)
							{
								num2 = 0;
							}
							switch (num2)
							{
							case 1:
								continue;
							}
							break;
						}
					}
					return;
				}
				finally
				{
					((IDisposable)enumerator2/*cast due to .constrained prefix*/).Dispose();
				}
			case 3:
				enumerator = P_0.Executions.GetEnumerator();
				num = 2;
				break;
			}
		}
	}

	public TRxMBHGukPlolYx3hhkM()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		wwVGuSnbrfB = new Stack<uioCmvGp6sXANp11eX6R>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_70b4b4a3c8d3471f9796e8c8caf6f35b != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static TRxMBHGukPlolYx3hhkM()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool yYWw9C5PmKl9QhCkF4WB()
	{
		return Pb0Vgo5PK1ds64dYS71C == null;
	}

	internal static TRxMBHGukPlolYx3hhkM rmsg4w5Ph3xbfvyShb9g()
	{
		return Pb0Vgo5PK1ds64dYS71C;
	}

	internal static BigInteger oGMSno5PwbUDt2A9L1ch(object P_0)
	{
		return ((UserPosition)P_0).Pnl;
	}

	internal static int zNw8h95P7tnTpgo1n8PH(long P_0)
	{
		return Math.Sign(P_0);
	}

	internal static long wNDpya5P8JCtOFpY9fRu(long P_0)
	{
		return Math.Abs(P_0);
	}

	internal static long UrqnwM5PAovhZkcdxAn3(object P_0)
	{
		return ((uioCmvGp6sXANp11eX6R)P_0).Quantity;
	}

	internal static int eZm54v5PPvd5t3gkPdSm(object P_0)
	{
		return ((Stack<uioCmvGp6sXANp11eX6R>)P_0).Count;
	}

	internal static BigInteger ayCGme5PJoP291mgNLBO(long P_0)
	{
		return P_0;
	}

	internal static BigInteger NY6Z4q5PFgFmqaPD2J43(BigInteger P_0, BigInteger P_1)
	{
		return BigInteger.Multiply(P_0, P_1);
	}

	internal static BigInteger kw538U5P3GNqSOOHPbTp(BigInteger P_0, BigInteger P_1)
	{
		return P_0 + P_1;
	}
}
