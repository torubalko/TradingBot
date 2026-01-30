using System.Collections;
using System.Collections.Generic;
using BfZtb759KlUg4482QKym;
using gQ80RYoF52Cr7su4JSBU;
using K1GcsD5GTtMSlaiJI0Xh;
using lFFs11G39ohaRVknaFPC;
using TigerTrade.Tc.Data;
using x97CE55GhEYKgt7TSVZT;
using y9e8njonfEGtBInZHtcn;

namespace o5cuPYYJd2pZ4lpRAlek;

internal sealed class XaQvAHYJQjbrDJbfH8Zs : vdq7k7oF1bjOLTKJ5ZnM
{
	internal static XaQvAHYJQjbrDJbfH8Zs BN9m6KSMJVNncgOfn93k;

	public XaQvAHYJQjbrDJbfH8Zs(AEMJjhonHIXgcruji9oy P_0, Symbol P_1)
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		base._002Ector();
		if (P_0 != null)
		{
			TBJYJgovona(P_0, P_1);
			int num = 1;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_b6dfeebb9aa04a23846c37da6e9b7d4d == 0)
			{
				num = 1;
			}
			switch (num)
			{
			case 0:
				break;
			case 1:
				break;
			}
		}
	}

	public void TBJYJgovona(AEMJjhonHIXgcruji9oy P_0, Symbol P_1)
	{
		double[][] array = P_0.Bids;
		int num = 0;
		double[] array3 = default(double[]);
		while (true)
		{
			int num2;
			if (num < array.Length)
			{
				double[] array2 = array[num];
				U4ioFLPLW7Z(array2[0], array2[1]);
				num2 = 5;
			}
			else
			{
				array = P_0.Asks;
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_320dc241f2414298b90e22a730a02f87 == 0)
				{
					num2 = 0;
				}
			}
			while (true)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					array3 = array[num];
					num2 = 4;
					continue;
				case 4:
					i5KoFxXiln5(array3[0], array3[1]);
					num++;
					goto case 3;
				case 5:
					break;
				default:
					num = 0;
					num2 = 3;
					continue;
				case 3:
					if (num >= array.Length)
					{
						num2 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_4f84702cc6834fdb9f44daed1fd8e55b == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 2;
				}
				break;
			}
			num++;
		}
	}

	public override void odClvnSDwKl(Symbol P_0, MarketDepthFullEvent P_1)
	{
		long num = 0L;
		long num2 = 0L;
		int num3 = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_f2a416e6ad3f40c68e350adb5940cd75 == 0)
		{
			num3 = 1;
		}
		IEnumerator<KeyValuePair<decimal, decimal>> enumerator = default(IEnumerator<KeyValuePair<decimal, decimal>>);
		while (true)
		{
			switch (num3)
			{
			case 1:
				enumerator = NyAoFcXcgb8.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						KeyValuePair<decimal, decimal> current2 = enumerator.Current;
						int num5 = 1;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_7101152ce069403f9cf307c1d31372ac == 0)
						{
							num5 = 1;
						}
						while (true)
						{
							switch (num5)
							{
							case 1:
								num = bUWWJCSMpaD8jo2NEHrj(P_0, (double)current2.Key);
								num2 = P_0.GetShortSize(fQjOmPSMuH8VyYNsDPWC(P_0) ? fo2V0PSMz01jAhqvd0iX(current2.Value) : (fo2V0PSMz01jAhqvd0iX(current2.Value) * P_0.ContractValue));
								P_1.AcdlolmAx8M(num, num2);
								num5 = 0;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_01a9a95496084b1e91fc56ed159028fd != 0)
								{
									num5 = 0;
								}
								continue;
							}
							break;
						}
					}
				}
				finally
				{
					enumerator?.Dispose();
				}
				P_1.crlG3Y3Z6h4(num, num2);
				num3 = 3;
				break;
			default:
				P_1.tvhG3Giodyj(num, num2);
				return;
			case 3:
				num = 0L;
				num2 = 0L;
				enumerator = NvsoFjJFZ1G.GetEnumerator();
				num3 = 2;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_cd6be7b090074d37a7e9c91ffedadb35 == 0)
				{
					num3 = 2;
				}
				break;
			case 2:
				try
				{
					while (XhjZIWSO29AktOJahgHU(enumerator))
					{
						while (true)
						{
							KeyValuePair<decimal, decimal> current = enumerator.Current;
							num = P_0.GetShortPrice((double)current.Key);
							num2 = P_0.GetShortSize(fQjOmPSMuH8VyYNsDPWC(P_0) ? ((double)current.Value) : ((double)current.Value * maQjtmSO0TrkkPKqTxEi(P_0)));
							P_1.YlHloi6rCYj(num, num2);
							int num4 = 1;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_8ac3c5fcdf484302951e15fc405858a5 == 0)
							{
								num4 = 1;
							}
							switch (num4)
							{
							case 1:
								break;
							default:
								continue;
							}
							break;
						}
					}
				}
				finally
				{
					enumerator?.Dispose();
				}
				goto default;
			}
		}
	}

	static XaQvAHYJQjbrDJbfH8Zs()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool dH529ISMF8LUbm6ttIQ1()
	{
		return BN9m6KSMJVNncgOfn93k == null;
	}

	internal static XaQvAHYJQjbrDJbfH8Zs dqhm8wSM3HdsYORK38W6()
	{
		return BN9m6KSMJVNncgOfn93k;
	}

	internal static long bUWWJCSMpaD8jo2NEHrj(object P_0, double price)
	{
		return ((Symbol)P_0).GetShortPrice(price);
	}

	internal static bool fQjOmPSMuH8VyYNsDPWC(object P_0)
	{
		return ((SymbolBase)P_0).IsDenomination;
	}

	internal static double fo2V0PSMz01jAhqvd0iX(decimal P_0)
	{
		return (double)P_0;
	}

	internal static double maQjtmSO0TrkkPKqTxEi(object P_0)
	{
		return ((SymbolBase)P_0).ContractValue;
	}

	internal static bool XhjZIWSO29AktOJahgHU(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}
}
