using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using BfZtb759KlUg4482QKym;
using gQ80RYoF52Cr7su4JSBU;
using K1GcsD5GTtMSlaiJI0Xh;
using lFFs11G39ohaRVknaFPC;
using Newtonsoft.Json.Linq;
using TigerTrade.Tc.Data;
using UkMEhUotKVR5Zg929iec;
using x97CE55GhEYKgt7TSVZT;

namespace QP6INroRGqRK17GfvgCT;

internal sealed class bDFqPWoRnKMkgRTxPOBX : vdq7k7oF1bjOLTKJ5ZnM
{
	private long xpOoRvMj3CE;

	private long rFroRBkBAMS;

	private long nYNoRa9Z61I;

	private int ISQoRiMYPsS;

	private readonly List<OtttAkotrWisl0f6vdN7> dmqoRltb6n9;

	private bool twtoR4HHlsO;

	private readonly object RusoRDtuuDF;

	internal static bDFqPWoRnKMkgRTxPOBX TKFRlTS8JLvZN2XiBeuo;

	protected override long DNflvNiDi2o(decimal P_0, Symbol P_1)
	{
		return (long)Math.Round(P_0 / y1wPrPS8uZROMfJoPnTX(EBLIUwS8peHfmyIJNPip(P_1)), MidpointRounding.AwayFromZero);
	}

	protected override long m23lvbn47Kv(decimal P_0, Symbol P_1)
	{
		return m15jp0SA0J3FaqpnQCun(shuSKDS8zfLDYL8bOUSJ(P_0, (decimal)P_1.SizeStep));
	}

	protected override long ScaleValue(long value, long scale, bool byLower)
	{
		return base.ScaleValue(value, 1L, byLower);
	}

	public bDFqPWoRnKMkgRTxPOBX()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		dmqoRltb6n9 = new List<OtttAkotrWisl0f6vdN7>();
		RusoRDtuuDF = new object();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_3d8a38b1cb21466e854270ec8942c6ca != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				twtoR4HHlsO = false;
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ac3f8b71231e4b108fd519d939438d5a == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public void hYOoRYkcTXd(JArray P_0, JArray P_1, long P_2)
	{
		lock (RusoRDtuuDF)
		{
			int num = 3;
			IEnumerator<JToken> enumerator = default(IEnumerator<JToken>);
			while (true)
			{
				switch (num)
				{
				case 2:
					try
					{
						while (enumerator.MoveNext())
						{
							JToken current = enumerator.Current;
							double num2 = ((JToken)h6RIhNSA2u0QTJVU6bSy(current, 0)).ToObject<double>();
							double num3 = ((JToken)h6RIhNSA2u0QTJVU6bSy(current, 1)).ToObject<double>();
							U4ioFLPLW7Z(num2, num3);
						}
						int num4 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_f19bbaca9e82419ba66f0bdafd2c824a == 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
					}
					finally
					{
						enumerator?.Dispose();
					}
					goto IL_0148;
				case 3:
					twtoR4HHlsO = true;
					nYNoRa9Z61I = P_2;
					Clear();
					if (P_0 != null)
					{
						num = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_aec259916d0a4bcebababa49a58288c4 == 0)
						{
							num = 0;
						}
						break;
					}
					goto IL_0148;
				default:
					enumerator = P_0.GetEnumerator();
					num = 2;
					break;
				case 1:
					return;
					IL_0148:
					if (P_1 == null)
					{
						return;
					}
					enumerator = P_1.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							JToken current2 = enumerator.Current;
							double num5 = current2[(object)0].ToObject<double>();
							double num6 = current2[(object)1].ToObject<double>();
							i5KoFxXiln5(num5, num6);
							int num7 = 0;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_aec259916d0a4bcebababa49a58288c4 == 0)
							{
								num7 = 0;
							}
							switch (num7)
							{
							}
						}
						return;
					}
					finally
					{
						if (enumerator != null)
						{
							EVyWWwSAHJ6ZZD38kSXV(enumerator);
						}
					}
				}
			}
		}
	}

	public bool IsqoRo5hfqi(long P_0, long P_1, JArray P_2, JArray P_3, long P_4)
	{
		object rusoRDtuuDF = RusoRDtuuDF;
		bool lockTaken = false;
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_df9cc36c31bd47b69eead74fc374d2af != 0)
		{
			num = 0;
		}
		switch (num)
		{
		default:
		{
			bool result = default(bool);
			try
			{
				Monitor.Enter(rusoRDtuuDF, ref lockTaken);
				int num2 = 5;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_7101152ce069403f9cf307c1d31372ac != 0)
				{
					num2 = 0;
				}
				IEnumerator<JToken> enumerator = default(IEnumerator<JToken>);
				while (true)
				{
					switch (num2)
					{
					case 3:
						break;
					case 4:
						result = true;
						break;
					default:
						if (P_3 != null)
						{
							num2 = 2;
							continue;
						}
						goto IL_0096;
					case 1:
						result = false;
						break;
					case 5:
						if (twtoR4HHlsO)
						{
							if (P_0 > nYNoRa9Z61I + 1)
							{
								num2 = 4;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_41689ce5632e46808b581b3ddff97952 == 0)
								{
									num2 = 6;
								}
								continue;
							}
							if (P_1 > nYNoRa9Z61I)
							{
								ISQoRiMYPsS = Math.Max(0, (int)P_4);
								if (P_2 != null)
								{
									enumerator = P_2.GetEnumerator();
									try
									{
										while (enumerator.MoveNext())
										{
											JToken current2 = enumerator.Current;
											double num6 = ((JToken)h6RIhNSA2u0QTJVU6bSy(current2, 0)).ToObject<double>();
											double num7 = ((JToken)h6RIhNSA2u0QTJVU6bSy(current2, 1)).ToObject<double>();
											int num8 = 0;
											if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_6f0ba3007e7244cca15e3c59471bb079 != 0)
											{
												num8 = 0;
											}
											switch (num8)
											{
											}
											U4ioFLPLW7Z(num6, num7);
										}
									}
									finally
									{
										enumerator?.Dispose();
									}
								}
								goto default;
							}
							result = false;
							break;
						}
						num2 = 1;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_e37b704f00fd438985274655b11b16b4 == 0)
						{
							num2 = 1;
						}
						continue;
					case 6:
						result = false;
						num2 = 3;
						continue;
					case 2:
						enumerator = P_3.GetEnumerator();
						num2 = 1;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_067bb9a4251b4173906596508c60e32c != 0)
						{
							num2 = 7;
						}
						continue;
					case 7:
						{
							try
							{
								while (L9txf4SAfLy5SxPNYrJF(enumerator))
								{
									JToken current = enumerator.Current;
									double num3 = current[(object)0].ToObject<double>();
									double num4 = current[(object)1].ToObject<double>();
									i5KoFxXiln5(num3, num4);
								}
								int num5 = 0;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9db030806b504c748b649e391f655c9f == 0)
								{
									num5 = 0;
								}
								switch (num5)
								{
								case 0:
									break;
								}
							}
							finally
							{
								enumerator?.Dispose();
							}
							goto IL_0096;
						}
						IL_0096:
						nYNoRa9Z61I = P_1;
						num2 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ce4051eadf70452db4b28dca356319d1 != 0)
						{
							num2 = 4;
						}
						continue;
					}
					break;
				}
			}
			finally
			{
				if (lockTaken)
				{
					Monitor.Exit(rusoRDtuuDF);
				}
			}
			return result;
		}
		}
	}

	public override void odClvnSDwKl(Symbol P_0, MarketDepthFullEvent P_1)
	{
		int num = 2;
		int num2 = num;
		long num3 = default(long);
		long num4 = default(long);
		IEnumerator<KeyValuePair<decimal, decimal>> enumerator = default(IEnumerator<KeyValuePair<decimal, decimal>>);
		KeyValuePair<decimal, decimal> current = default(KeyValuePair<decimal, decimal>);
		while (true)
		{
			switch (num2)
			{
			case 2:
				num3 = 0L;
				num2 = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_267b6e28e0b84cf5a9effc88636b52de != 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				P_1.tvhG3Giodyj(num3, num4);
				return;
			default:
				try
				{
					while (L9txf4SAfLy5SxPNYrJF(enumerator))
					{
						KeyValuePair<decimal, decimal> current2 = enumerator.Current;
						int num6 = 1;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_4b62428db63649d1b023deac83179573 == 0)
						{
							num6 = 1;
						}
						while (true)
						{
							switch (num6)
							{
							case 1:
								num3 = lcakdESAGq9qwSRfXiKK(P_0, (double)current2.Key);
								num4 = IZhlWGSAYm0xt15tWhVm(P_0, (double)current2.Value * PEgrN2SAneexLYlllvcg(P_0));
								P_1.YlHloi6rCYj(num3, num4);
								num6 = 0;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_85518406d92c400aa3e0339f430d9d7a == 0)
								{
									num6 = 0;
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
				goto case 4;
			case 1:
				num4 = 0L;
				enumerator = NyAoFcXcgb8.GetEnumerator();
				try
				{
					while (true)
					{
						int num5;
						if (!enumerator.MoveNext())
						{
							num5 = 0;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9c60d0dfafa6408a9dd7ce15e9c500ee == 0)
							{
								num5 = 0;
							}
						}
						else
						{
							current = enumerator.Current;
							num3 = P_0.GetShortPrice(WhZkJKSA95LY6qgM8g1K(current.Key));
							num5 = 1;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_7101152ce069403f9cf307c1d31372ac == 0)
							{
								num5 = 1;
							}
						}
						switch (num5)
						{
						case 1:
							goto IL_01bf;
						case 0:
							break;
						}
						break;
						IL_01bf:
						num4 = P_0.GetShortSize((double)current.Value * PEgrN2SAneexLYlllvcg(P_0));
						P_1.AcdlolmAx8M(num3, num4);
					}
				}
				finally
				{
					enumerator?.Dispose();
				}
				P_1.crlG3Y3Z6h4(num3, num4);
				num2 = 3;
				break;
			case 3:
				num3 = 0L;
				num4 = 0L;
				enumerator = NvsoFjJFZ1G.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1eae27ac5d434a80846c6543fc10c643 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	static bDFqPWoRnKMkgRTxPOBX()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		OwhpeSSAo4yMwEWPBwWU();
	}

	internal static double EBLIUwS8peHfmyIJNPip(object P_0)
	{
		return ((SymbolBase)P_0).Step;
	}

	internal static decimal y1wPrPS8uZROMfJoPnTX(double P_0)
	{
		return (decimal)P_0;
	}

	internal static bool IY0iduS8FWbn4rBSmEml()
	{
		return TKFRlTS8JLvZN2XiBeuo == null;
	}

	internal static bDFqPWoRnKMkgRTxPOBX PlCRKLS83v6tMNDrjVm9()
	{
		return TKFRlTS8JLvZN2XiBeuo;
	}

	internal static decimal shuSKDS8zfLDYL8bOUSJ(decimal P_0, decimal P_1)
	{
		return P_0 / P_1;
	}

	internal static long m15jp0SA0J3FaqpnQCun(decimal P_0)
	{
		return (long)P_0;
	}

	internal static object h6RIhNSA2u0QTJVU6bSy(object P_0, object P_1)
	{
		return ((JToken)P_0)[P_1];
	}

	internal static void EVyWWwSAHJ6ZZD38kSXV(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static bool L9txf4SAfLy5SxPNYrJF(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static double WhZkJKSA95LY6qgM8g1K(decimal P_0)
	{
		return (double)P_0;
	}

	internal static double PEgrN2SAneexLYlllvcg(object P_0)
	{
		return ((SymbolBase)P_0).ContractValue;
	}

	internal static long lcakdESAGq9qwSRfXiKK(object P_0, double price)
	{
		return ((Symbol)P_0).GetShortPrice(price);
	}

	internal static long IZhlWGSAYm0xt15tWhVm(object P_0, double size)
	{
		return ((SymbolBase)P_0).GetShortSize(size);
	}

	internal static void OwhpeSSAo4yMwEWPBwWU()
	{
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}
}
