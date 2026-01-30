using System;
using System.Collections.Generic;
using System.Numerics;
using BfZtb759KlUg4482QKym;
using bK4Ou0GuYw3lorTWdXps;
using IqjG5RGpM8HpdaZSkjjx;
using K1GcsD5GTtMSlaiJI0Xh;
using TigerTrade.Tc.Data;
using x97CE55GhEYKgt7TSVZT;

namespace e0tg0qGuDoh0eXwhVNbg;

internal class iX4EiJGu4abnchWZgLga : ThVuvSGuGmsOKEbslc6A
{
	private readonly Queue<uioCmvGp6sXANp11eX6R> Q6kGuN4s7g1;

	internal static iX4EiJGu4abnchWZgLga u4VeVe5PRvmZfg2MvvPe;

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
		p0hGubb0QCX(P_0, P_1);
	}

	public override void Remove(UserPosition userPosition, uioCmvGp6sXANp11eX6R execution)
	{
		base.Remove(userPosition, execution);
		p0hGubb0QCX(userPosition, execution);
	}

	public override void Clear(UserPosition userPosition)
	{
		base.Clear(userPosition);
		Q6kGuN4s7g1.Clear();
	}

	private void p0hGubb0QCX(UserPosition P_0, uioCmvGp6sXANp11eX6R P_1)
	{
		iW3UyI5POxqQ7jq2uRAs(P_0, default(BigInteger));
		jsUo9w5PqAlhPprEx4Km(P_0, default(BigInteger));
		UoEed95PIFvgFsHjVhGy(P_0, 0L);
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_376f2bcb10134b91b6257ed8645d119a == 0)
		{
			num = 0;
		}
		uioCmvGp6sXANp11eX6R uioCmvGp6sXANp11eX6R = default(uioCmvGp6sXANp11eX6R);
		long num2 = default(long);
		List<uioCmvGp6sXANp11eX6R>.Enumerator enumerator = default(List<uioCmvGp6sXANp11eX6R>.Enumerator);
		uioCmvGp6sXANp11eX6R uioCmvGp6sXANp11eX6R2 = default(uioCmvGp6sXANp11eX6R);
		uioCmvGp6sXANp11eX6R current2 = default(uioCmvGp6sXANp11eX6R);
		while (true)
		{
			switch (num)
			{
			case 2:
				uioCmvGp6sXANp11eX6R = P_0.Executions[0];
				num2 = 0L;
				enumerator = P_0.Executions.GetEnumerator();
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_2b9e363b0abc4a32a96694deb0f4f698 != 0)
				{
					num = 1;
				}
				break;
			default:
				mOoYFa5PWWqMvNlE3I3T(Q6kGuN4s7g1);
				num = 2;
				break;
			case 1:
			{
				try
				{
					while (enumerator.MoveNext())
					{
						while (true)
						{
							IL_02ac:
							uioCmvGp6sXANp11eX6R current = enumerator.Current;
							P_0.Pnl = QCohbF5PyRe2bRSaHGIx(Aax7V45Pthq9m9AKGtNH(P_0), BigInteger.Multiply(kFOF8W5PU0gLbOyHHQja(current), lMceoY5PTIIcm2kFY1Bf(current.Quantity)));
							if (Math.Sign(current.Quantity) != gDj36K5PVxNm8R8Pgu6P(BC6qHd5PZJ3yJUFq8Tc2(uioCmvGp6sXANp11eX6R)))
							{
								num2 += Math.Abs(current.Quantity);
								goto IL_01de;
							}
							int num3 = 0;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_67356183f8464ca6962cfffbcb53813d == 0)
							{
								num3 = 0;
							}
							goto IL_0193;
							IL_0193:
							while (true)
							{
								switch (num3)
								{
								case 4:
									break;
								case 5:
									if (uioCmvGp6sXANp11eX6R2.Quantity == 0L)
									{
										num3 = 2;
										continue;
									}
									goto case 8;
								case 2:
									Q6kGuN4s7g1.Dequeue();
									break;
								case 8:
									if (Math.Abs(BC6qHd5PZJ3yJUFq8Tc2(uioCmvGp6sXANp11eX6R2)) < num2)
									{
										num2 -= Math.Abs(uioCmvGp6sXANp11eX6R2.Quantity);
										num3 = 1;
										if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_f19bbaca9e82419ba66f0bdafd2c824a == 0)
										{
											num3 = 1;
										}
										continue;
									}
									goto IL_02ba;
								case 6:
									goto IL_02ac;
								case 3:
									goto IL_02ba;
								case 7:
									goto IL_02e6;
								default:
									goto IL_0334;
								case 1:
									uBnCBw5PCLCmXasuiSrC(uioCmvGp6sXANp11eX6R2, 0L);
									break;
								}
								break;
							}
							goto IL_01de;
							IL_02ba:
							uioCmvGp6sXANp11eX6R uioCmvGp6sXANp11eX6R3 = uioCmvGp6sXANp11eX6R2;
							uioCmvGp6sXANp11eX6R3.Quantity = BC6qHd5PZJ3yJUFq8Tc2(uioCmvGp6sXANp11eX6R3) - gDj36K5PVxNm8R8Pgu6P(uioCmvGp6sXANp11eX6R2.Quantity) * num2;
							num2 = 0L;
							break;
							IL_0334:
							Q6kGuN4s7g1.Enqueue(current.bX7GpOLl1qd());
							break;
							IL_01de:
							if (Q6kGuN4s7g1.Count <= 0)
							{
								break;
							}
							goto IL_02e6;
							IL_02e6:
							uioCmvGp6sXANp11eX6R2 = Q6kGuN4s7g1.Peek();
							int num4 = 5;
							num3 = num4;
							goto IL_0193;
						}
					}
				}
				finally
				{
					((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
				}
				using Queue<uioCmvGp6sXANp11eX6R>.Enumerator enumerator2 = Q6kGuN4s7g1.GetEnumerator();
				while (true)
				{
					int num5;
					if (!enumerator2.MoveNext())
					{
						num5 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_67356183f8464ca6962cfffbcb53813d == 0)
						{
							num5 = 0;
						}
					}
					else
					{
						current2 = enumerator2.Current;
						num5 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_85518406d92c400aa3e0339f430d9d7a == 0)
						{
							num5 = 1;
						}
					}
					switch (num5)
					{
					default:
						return;
					case 1:
						break;
					case 0:
						return;
					}
					jsUo9w5PqAlhPprEx4Km(P_0, P_0.PriceSum + cwdplT5Prgfki005D7LE(current2.Price, current2.Quantity));
					P_0.Price = FrSGuotdFjC(P_0);
				}
			}
			case 3:
				return;
			}
		}
	}

	public iX4EiJGu4abnchWZgLga()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		Q6kGuN4s7g1 = new Queue<uioCmvGp6sXANp11eX6R>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_7ea79d38f01f491fa0470ff9768a1574 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static iX4EiJGu4abnchWZgLga()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool I0rDry5P6EhmF5qI90SF()
	{
		return u4VeVe5PRvmZfg2MvvPe == null;
	}

	internal static iX4EiJGu4abnchWZgLga aJluCR5PMjQFcjmQKDLN()
	{
		return u4VeVe5PRvmZfg2MvvPe;
	}

	internal static void iW3UyI5POxqQ7jq2uRAs(object P_0, BigInteger value)
	{
		((UserPosition)P_0).Pnl = value;
	}

	internal static void jsUo9w5PqAlhPprEx4Km(object P_0, BigInteger value)
	{
		((UserPosition)P_0).PriceSum = value;
	}

	internal static void UoEed95PIFvgFsHjVhGy(object P_0, long value)
	{
		((UserPosition)P_0).Price = value;
	}

	internal static void mOoYFa5PWWqMvNlE3I3T(object P_0)
	{
		((Queue<uioCmvGp6sXANp11eX6R>)P_0).Clear();
	}

	internal static BigInteger Aax7V45Pthq9m9AKGtNH(object P_0)
	{
		return ((UserPosition)P_0).Pnl;
	}

	internal static long kFOF8W5PU0gLbOyHHQja(object P_0)
	{
		return ((uioCmvGp6sXANp11eX6R)P_0).Price;
	}

	internal static BigInteger lMceoY5PTIIcm2kFY1Bf(long P_0)
	{
		return P_0;
	}

	internal static BigInteger QCohbF5PyRe2bRSaHGIx(BigInteger P_0, BigInteger P_1)
	{
		return P_0 + P_1;
	}

	internal static long BC6qHd5PZJ3yJUFq8Tc2(object P_0)
	{
		return ((uioCmvGp6sXANp11eX6R)P_0).Quantity;
	}

	internal static int gDj36K5PVxNm8R8Pgu6P(long P_0)
	{
		return Math.Sign(P_0);
	}

	internal static void uBnCBw5PCLCmXasuiSrC(object P_0, long P_1)
	{
		((uioCmvGp6sXANp11eX6R)P_0).Quantity = P_1;
	}

	internal static BigInteger cwdplT5Prgfki005D7LE(BigInteger P_0, BigInteger P_1)
	{
		return BigInteger.Multiply(P_0, P_1);
	}
}
