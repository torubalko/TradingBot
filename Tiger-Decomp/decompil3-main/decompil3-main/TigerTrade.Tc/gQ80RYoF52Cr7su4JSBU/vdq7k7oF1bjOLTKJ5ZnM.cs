using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using lFFs11G39ohaRVknaFPC;
using TigerTrade.Tc.Data;
using x97CE55GhEYKgt7TSVZT;

namespace gQ80RYoF52Cr7su4JSBU;

internal abstract class vdq7k7oF1bjOLTKJ5ZnM
{
	private class prnUhsa70GbRcp4cvHv6 : IComparer<decimal>
	{
		internal static prnUhsa70GbRcp4cvHv6 qgutBjL4dy6VJF9dFllt;

		public int Compare(decimal P_0, decimal P_1)
		{
			return P_0.CompareTo(P_1);
		}

		public prnUhsa70GbRcp4cvHv6()
		{
			itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
			base._002Ector();
		}

		static prnUhsa70GbRcp4cvHv6()
		{
			S1gQuZL46NWbKbC48GyJ();
			pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
		}

		internal static bool sv8XrBL4gC8uBUTeduav()
		{
			return qgutBjL4dy6VJF9dFllt == null;
		}

		internal static prnUhsa70GbRcp4cvHv6 uD7iTFL4RFxAO76RCu9b()
		{
			return qgutBjL4dy6VJF9dFllt;
		}

		internal static void S1gQuZL46NWbKbC48GyJ()
		{
			F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		}
	}

	private class cYOWEwa72oY34LkIM3YD : IComparer<decimal>
	{
		internal static cYOWEwa72oY34LkIM3YD Hlxk4yL4Mdw4CJPMZNXH;

		public int Compare(decimal P_0, decimal P_1)
		{
			return P_1.CompareTo(P_0);
		}

		public cYOWEwa72oY34LkIM3YD()
		{
			itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
			base._002Ector();
		}

		static cYOWEwa72oY34LkIM3YD()
		{
			F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
			pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
		}

		internal static bool fsNOq7L4OHVZuhdkfu8G()
		{
			return Hlxk4yL4Mdw4CJPMZNXH == null;
		}

		internal static cYOWEwa72oY34LkIM3YD XdSeFXL4qZGcTSUSIwyU()
		{
			return Hlxk4yL4Mdw4CJPMZNXH;
		}
	}

	private readonly int WDooFXc1Via;

	protected readonly SortedList<decimal, decimal> NyAoFcXcgb8;

	protected readonly SortedList<decimal, decimal> NvsoFjJFZ1G;

	protected readonly HashSet<decimal> XhFoFEpdCjA;

	protected readonly HashSet<decimal> cbpoFQjs3lK;

	internal static vdq7k7oF1bjOLTKJ5ZnM enijaYx0ExfdKLKAbfR9;

	protected vdq7k7oF1bjOLTKJ5ZnM()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		WDooFXc1Via = Math.Min(5000, TXMYWdx0MxhJ3jenqo00(1, PFYxGsx062yISJfwyK2G(efN6Lax0R9ZWMJ7tEPOi(Ao32XYx0geCq193u2jTZ(), F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1306877528 ^ -1306838556)) ?? F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-448941864 ^ -449042256))));
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				NvsoFjJFZ1G = new SortedList<decimal, decimal>(new cYOWEwa72oY34LkIM3YD());
				num = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ca333d1f5b544c679e2f04abd45bbe97 == 0)
				{
					num = 1;
				}
				break;
			case 1:
				XhFoFEpdCjA = new HashSet<decimal>();
				cbpoFQjs3lK = new HashSet<decimal>();
				return;
			case 2:
				NyAoFcXcgb8 = new SortedList<decimal, decimal>(new prnUhsa70GbRcp4cvHv6());
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_c82b80986db149fc8e857dfed661c1a6 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	protected virtual long DNflvNiDi2o(decimal P_0, Symbol P_1)
	{
		return (long)Math.Round(gUgQJSx0OubVYY96s5uf(P_0, 100000000m), 8, MidpointRounding.AwayFromZero);
	}

	protected virtual long m23lvbn47Kv(decimal P_0, Symbol P_1)
	{
		return (long)Math.Round(P_0 * 100000000m, 8, MidpointRounding.AwayFromZero);
	}

	protected virtual long ScaleValue(long value, long scale, bool byLower)
	{
		int num = 1;
		int num2 = num;
		long num3 = default(long);
		while (true)
		{
			switch (num2)
			{
			default:
				return value;
			case 1:
				if (scale > 0)
				{
					num3 = value % scale;
					num2 = 2;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_c39cf65fb9834816b04c914d068177cc == 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_f19bbaca9e82419ba66f0bdafd2c824a == 0)
					{
						num2 = 0;
					}
				}
				break;
			case 2:
				if (byLower)
				{
					return (value - num3) / scale;
				}
				if (num3 > 0)
				{
					num3 = scale - num3;
				}
				return (value + num3) / scale;
			}
		}
	}

	protected void M6toFScMbcD(IDictionary<decimal, decimal> P_0, decimal P_1, decimal P_2)
	{
		if (P_2 == 0m)
		{
			P_0.Remove(P_1);
		}
		else
		{
			P_0[P_1] = P_2;
		}
	}

	protected void i5KoFxXiln5(double P_0, double P_1)
	{
		AnaoFel7mcS((decimal)P_0, (decimal)P_1);
	}

	protected void U4ioFLPLW7Z(double P_0, double P_1)
	{
		CLgoFsnYMr3((decimal)P_0, (decimal)P_1);
	}

	protected void AnaoFel7mcS(decimal P_0, decimal P_1)
	{
		M6toFScMbcD(NyAoFcXcgb8, P_0, P_1);
	}

	protected void CLgoFsnYMr3(decimal P_0, decimal P_1)
	{
		M6toFScMbcD(NvsoFjJFZ1G, P_0, P_1);
	}

	protected void Clear()
	{
		dy5pQWx0qdnDfOUIwu1Z(NyAoFcXcgb8);
		NvsoFjJFZ1G.Clear();
	}

	public virtual void odClvnSDwKl(Symbol P_0, MarketDepthFullEvent P_1)
	{
		int num = 5;
		long num3 = default(long);
		long num4 = default(long);
		KeyValuePair<decimal, decimal> current2 = default(KeyValuePair<decimal, decimal>);
		int num5 = default(int);
		int num7 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 7:
					return;
				case 1:
					foreach (decimal item in XhFoFEpdCjA)
					{
						int num10 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_e37b704f00fd438985274655b11b16b4 == 0)
						{
							num10 = 0;
						}
						switch (num10)
						{
						}
						NyAoFcXcgb8.Remove(item);
					}
					goto case 2;
				case 2:
				{
					using (HashSet<decimal>.Enumerator enumerator2 = cbpoFQjs3lK.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							decimal current3 = enumerator2.Current;
							NvsoFjJFZ1G.Remove(current3);
						}
						int num9 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_8ac3c5fcdf484302951e15fc405858a5 != 0)
						{
							num9 = 0;
						}
						switch (num9)
						{
						case 0:
							break;
						}
					}
					XhFoFEpdCjA.Clear();
					R9UW9Nx0UyK3UuYCQ6OV(cbpoFQjs3lK);
					num2 = 7;
					continue;
				}
				default:
					P_1.crlG3Y3Z6h4(num3, num4);
					num3 = 0L;
					num2 = 3;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_137abeaac6b54c2d909c4f75bdf9527a != 0)
					{
						num2 = 2;
					}
					continue;
				case 8:
				{
					using (IEnumerator<KeyValuePair<decimal, decimal>> enumerator = NvsoFjJFZ1G.GetEnumerator())
					{
						while (true)
						{
							int num8;
							if (enumerator.MoveNext())
							{
								current2 = enumerator.Current;
								if (current2.Key > 1000000m)
								{
									goto IL_014f;
								}
								num8 = 1;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_e68bfca50a3341a1ad5f97fbde9bcf8f == 0)
								{
									num8 = 2;
								}
							}
							else
							{
								num8 = 0;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_78f2003ea86d4a38b55c210d3b84bb0e == 0)
								{
									num8 = 0;
								}
							}
							while (true)
							{
								switch (num8)
								{
								case 3:
									num4 = m23lvbn47Kv(current2.Value, P_0);
									num8 = 1;
									if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_82741674950e4c70a0407e3b1a670169 != 0)
									{
										num8 = 0;
									}
									continue;
								case 1:
									goto IL_019b;
								case 2:
									goto IL_0213;
								case 0:
									break;
								}
								break;
								IL_0213:
								if (num5++ > WDooFXc1Via)
								{
									goto IL_014f;
								}
								num3 = ScaleValue(GWgriEx0tKOXu5kK4nCh(this, current2.Key, P_0), num7, byLower: true);
								num8 = 3;
							}
							break;
							IL_019b:
							P_1.YlHloi6rCYj(num3, num4);
							continue;
							IL_014f:
							cbpoFQjs3lK.Add(current2.Key);
						}
					}
					break;
				}
				case 5:
					num7 = (int)tY8AOFx0WLHtkBfAEeLw(10.0, 8 - IIuk2dx0IIcBajSW5obo(P_0));
					num2 = 4;
					continue;
				case 3:
					goto end_IL_0012;
				case 6:
					break;
				case 4:
					num3 = 0L;
					num4 = 0L;
					num5 = 0;
					foreach (KeyValuePair<decimal, decimal> item2 in NyAoFcXcgb8)
					{
						if (!(item2.Key > 1000000m))
						{
							int num6 = 1;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_cd6be7b090074d37a7e9c91ffedadb35 != 0)
							{
								num6 = 1;
							}
							while (true)
							{
								switch (num6)
								{
								case 1:
									break;
								case 3:
									goto end_IL_0323;
								case 2:
									goto IL_03ff;
								default:
									num4 = m23lvbn47Kv(item2.Value, P_0);
									P_1.AcdlolmAx8M(num3, num4);
									num6 = 3;
									continue;
								}
								if (num5++ > WDooFXc1Via)
								{
									num6 = 2;
									continue;
								}
								num3 = ScaleValue(GWgriEx0tKOXu5kK4nCh(this, item2.Key, P_0), num7, byLower: false);
								num6 = 0;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1d4a4f3099134e0e94d0aa5f4bb135c6 != 0)
								{
									num6 = 0;
								}
								continue;
								end_IL_0323:
								break;
							}
							continue;
						}
						goto IL_03ff;
						IL_03ff:
						XhFoFEpdCjA.Add(item2.Key);
					}
					goto default;
				}
				P_1.tvhG3Giodyj(num3, num4);
				num2 = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_4b62428db63649d1b023deac83179573 == 0)
				{
					num2 = 0;
				}
				continue;
				end_IL_0012:
				break;
			}
			num4 = 0L;
			num5 = 0;
			num = 8;
		}
	}

	static vdq7k7oF1bjOLTKJ5ZnM()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static object Ao32XYx0geCq193u2jTZ()
	{
		return ConfigurationManager.AppSettings;
	}

	internal static object efN6Lax0R9ZWMJ7tEPOi(object P_0, object P_1)
	{
		return ((NameValueCollection)P_0)[(string)P_1];
	}

	internal static int PFYxGsx062yISJfwyK2G(object P_0)
	{
		return Convert.ToInt32((string)P_0);
	}

	internal static int TXMYWdx0MxhJ3jenqo00(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static bool XnXQBIx0QYq0ZttBcDvS()
	{
		return enijaYx0ExfdKLKAbfR9 == null;
	}

	internal static vdq7k7oF1bjOLTKJ5ZnM FjHX6Ux0dtSdF60epqDp()
	{
		return enijaYx0ExfdKLKAbfR9;
	}

	internal static decimal gUgQJSx0OubVYY96s5uf(decimal P_0, decimal P_1)
	{
		return P_0 * P_1;
	}

	internal static void dy5pQWx0qdnDfOUIwu1Z(object P_0)
	{
		((SortedList<decimal, decimal>)P_0).Clear();
	}

	internal static int IIuk2dx0IIcBajSW5obo(object P_0)
	{
		return ((Symbol)P_0).Precision;
	}

	internal static double tY8AOFx0WLHtkBfAEeLw(double P_0, double P_1)
	{
		return Math.Pow(P_0, P_1);
	}

	internal static long GWgriEx0tKOXu5kK4nCh(object P_0, decimal P_1, object P_2)
	{
		return ((vdq7k7oF1bjOLTKJ5ZnM)P_0).DNflvNiDi2o(P_1, (Symbol)P_2);
	}

	internal static void R9UW9Nx0UyK3UuYCQ6OV(object P_0)
	{
		((HashSet<decimal>)P_0).Clear();
	}
}
