using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using aEpmU09nz6MEoNmc0pGJ;
using ECOEgqlSad8NUJZ2Dr9n;
using jS3Y2j9pTQRy0FnOknFG;
using NHkZqbf77HnCtq0ER8ta;
using TigerTrade.Chart.Objects.List;
using TigerTrade.Core.Utils.Config;
using TigerTrade.Core.Utils.Logging;
using TigerTrade.Market.Settings;
using TigerTrade.UI.DocControls.Charting.Settings;
using TigerTrade.UI.DocControls.Trading.Settings;
using TuAMtrl1Nd3XoZQQUXf0;
using UQo6BdfP2mN8TGiUMEQT;

namespace XFouJw91ETyLclFXBXxS;

internal static class RpOpxq91jD3gNPA5cpBR
{
	[Serializable]
	[CompilerGenerated]
	private sealed class hiUYRUnFasMDg2KhXBQK
	{
		public static readonly hiUYRUnFasMDg2KhXBQK ibvnFlJkurL;

		public static Func<HorizontalLineObject, string> AvanF4fU9iX;

		private static hiUYRUnFasMDg2KhXBQK yo6ytkNqvwnVgCscyslv;

		static hiUYRUnFasMDg2KhXBQK()
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2264c03640a14c8f930261fd70e85d60 != 0)
					{
						num2 = 0;
					}
					break;
				default:
					bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
					ibvnFlJkurL = new hiUYRUnFasMDg2KhXBQK();
					return;
				}
			}
		}

		public hiUYRUnFasMDg2KhXBQK()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			base._002Ector();
		}

		internal string z6onFixsZtZ(HorizontalLineObject l)
		{
			return l.SymbolID;
		}

		internal static bool SchEvWNqBBjHHPUK05tq()
		{
			return yo6ytkNqvwnVgCscyslv == null;
		}

		internal static hiUYRUnFasMDg2KhXBQK DXdnGHNqaAyhrsvW2X74()
		{
			return yo6ytkNqvwnVgCscyslv;
		}
	}

	internal static RpOpxq91jD3gNPA5cpBR j50PydbSGc5PfiJPPecs;

	public static void UAQ91Qkq1t6()
	{
		qPl91glLpba();
		cmo91d1elhr();
	}

	private static void cmo91d1elhr()
	{
		try
		{
			if (!Directory.Exists(j18iDj9nukSCmEyZs5lH.mCD9GU85vS2()))
			{
				return;
			}
			int num5 = default(int);
			TradingSettings tradingSettings = default(TradingSettings);
			List<BpmEftf7wYbuVebk5Vku> value2 = default(List<BpmEftf7wYbuVebk5Vku>);
			Dictionary<string, List<BpmEftf7wYbuVebk5Vku>>.Enumerator enumerator = default(Dictionary<string, List<BpmEftf7wYbuVebk5Vku>>.Enumerator);
			MarketSettings marketSettings2 = default(MarketSettings);
			string fileName = default(string);
			MarketSettings marketSettings = default(MarketSettings);
			string fileName2 = default(string);
			while (true)
			{
				HashSet<string> hashSet = new HashSet<string>();
				string[] files = Directory.GetFiles(j18iDj9nukSCmEyZs5lH.mCD9GU85vS2());
				Dictionary<string, List<BpmEftf7wYbuVebk5Vku>> dictionary = new Dictionary<string, List<BpmEftf7wYbuVebk5Vku>>();
				string[] array = files;
				int num = 5;
				while (true)
				{
					switch (num)
					{
					case 5:
						num5 = 0;
						goto case 1;
					case 2:
					case 6:
					{
						string text = array[num5];
						if (oBxpINbSv7j5Eeop5TYl(text, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1435596783 ^ -1435617213)))
						{
							tradingSettings = ConfigSerializer.LoadFromFile<TradingSettings>(text);
							if (tradingSettings == null)
							{
								num = 4;
								continue;
							}
							if (!J136fubSBHiA10CmgeGr(tradingSettings.Qom210PQiuE))
							{
								num = 7;
								continue;
							}
						}
						goto default;
					}
					case 7:
					{
						using (Dictionary<string, List<BpmEftf7wYbuVebk5Vku>>.KeyCollection.Enumerator enumerator2 = tradingSettings.MarketSettings.Levels.Levels.Keys.GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								while (true)
								{
									IL_01b1:
									string current2 = enumerator2.Current;
									List<BpmEftf7wYbuVebk5Vku> list = ((YiXl9IfP06OkWU6fDkUP)uOdgVbbSag00GwCbqimY(tradingSettings.MarketSettings)).IDQfPHZll5G(current2);
									int num3 = 2;
									while (true)
									{
										switch (num3)
										{
										case 3:
											break;
										case 2:
											if (list.Count == 0)
											{
												break;
											}
											if (!dictionary.TryGetValue(current2, out value2))
											{
												value2 = new List<BpmEftf7wYbuVebk5Vku>();
												dictionary.Add(current2, value2);
												num3 = 0;
												if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c1a63437a5bc4d139ae2c4a2f19ec947 == 0)
												{
													num3 = 0;
												}
												continue;
											}
											goto default;
										case 1:
											goto IL_01b1;
										default:
											foreach (BpmEftf7wYbuVebk5Vku item in list)
											{
												if (hashSet.Contains(item.balf7pvwCJI))
												{
													continue;
												}
												hashSet.Add(item.balf7pvwCJI);
												int num4 = 0;
												if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6d365c300683408da8d70007bc278f93 != 0)
												{
													num4 = 0;
												}
												while (true)
												{
													switch (num4)
													{
													default:
														value2.Add(item);
														num4 = 1;
														if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a8990374f0e04177b45918e3dd7a2d4b == 0)
														{
															num4 = 1;
														}
														continue;
													case 1:
														break;
													}
													break;
												}
											}
											break;
										}
										break;
									}
									break;
								}
							}
						}
						goto default;
					}
					case 1:
						if (num5 >= array.Length)
						{
							if (!bp2n5YbSlNVXLK6EZvaS(SEjxFhbSilXFPgemYxK2()))
							{
								Directory.CreateDirectory(j18iDj9nukSCmEyZs5lH.das9Gr3ODK2());
							}
							enumerator = dictionary.GetEnumerator();
							num = 3;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7d3c6a8bf09f4ec887f577858231a719 != 0)
							{
								num = 2;
							}
						}
						else
						{
							num = 6;
						}
						continue;
					case 3:
						try
						{
							while (enumerator.MoveNext())
							{
								KeyValuePair<string, List<BpmEftf7wYbuVebk5Vku>> current = enumerator.Current;
								string key = current.Key;
								List<BpmEftf7wYbuVebk5Vku> value = current.Value;
								int num2 = 5;
								while (true)
								{
									switch (num2)
									{
									case 6:
										marketSettings2.Levels.Ia0fPf3Ad95(key, value);
										ConfigSerializer.SaveToFile(marketSettings2, fileName);
										break;
									case 3:
										fileName = (string)LHnZhMbSDOLN9MoEEdSK(SEjxFhbSilXFPgemYxK2(), stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1999650146 ^ -1999924966), key, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-962524685 ^ -962504203));
										num2 = 2;
										continue;
									case 2:
										marketSettings2 = ConfigSerializer.LoadFromFile<MarketSettings>(fileName, (DataContractResolver)AYxkDwbSbqIftODgro48());
										if (marketSettings2 == null)
										{
											break;
										}
										goto case 6;
									case 1:
										ConfigSerializer.SaveToFile(marketSettings, fileName2);
										num2 = 1;
										if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ebf7ae5938c3406ea71c3b7147ea041c == 0)
										{
											num2 = 3;
										}
										continue;
									case 5:
										fileName2 = (string)LHnZhMbSDOLN9MoEEdSK(j18iDj9nukSCmEyZs5lH.das9Gr3ODK2(), stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x769C7931 ^ 0x76982A47), key, dN56kabS4VOBZxwqoUog(0x5EA8FF2A ^ 0x5EA8AF2C));
										marketSettings = ConfigSerializer.LoadFromFile<MarketSettings>(fileName2, jjKtVJ9pUSOpdg38tqnP.PV29p3fNsns());
										num2 = 4;
										if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_68b6172210394c1b93f49e43376ff3af != 0)
										{
											num2 = 0;
										}
										continue;
									case 4:
										if (marketSettings != null)
										{
											marketSettings.Levels.Ia0fPf3Ad95(key, value);
											num2 = 1;
											if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5350e02b39f542f78529ac5e3c3f8ec6 == 0)
											{
												num2 = 0;
											}
										}
										else
										{
											num2 = 0;
											if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8692846774e94af58ff2b2b243743e02 != 0)
											{
												num2 = 0;
											}
										}
										continue;
									}
									break;
								}
							}
							return;
						}
						finally
						{
							((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
						}
					default:
						num5++;
						num = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6d365c300683408da8d70007bc278f93 == 0)
						{
							num = 1;
						}
						continue;
					case 8:
						break;
					}
					break;
				}
			}
		}
		catch (Exception e)
		{
			LogManager.WriteError(e);
		}
	}

	private static void qPl91glLpba()
	{
		try
		{
			int num;
			if (!Directory.Exists((string)MTLtShbSNSK1UvTpicJu()))
			{
				num = 5;
				goto IL_0024;
			}
			goto IL_0430;
			IL_0430:
			HashSet<string> hashSet = new HashSet<string>();
			string[] files = Directory.GetFiles(j18iDj9nukSCmEyZs5lH.mCD9GU85vS2());
			List<HorizontalLineObject> list = new List<HorizontalLineObject>();
			string[] array = files;
			num = 7;
			goto IL_0024;
			IL_0024:
			int num6 = default(int);
			ChartingSettings chartingSettings = default(ChartingSettings);
			IEnumerator<HorizontalLineObject> enumerator2 = default(IEnumerator<HorizontalLineObject>);
			IEnumerator<IGrouping<string, HorizontalLineObject>> enumerator = default(IEnumerator<IGrouping<string, HorizontalLineObject>>);
			IGrouping<string, HorizontalLineObject> current = default(IGrouping<string, HorizontalLineObject>);
			while (true)
			{
				switch (num)
				{
				case 1:
					return;
				case 5:
					return;
				case 7:
					num6 = 0;
					goto case 2;
				case 8:
					if (chartingSettings != null && chartingSettings.ChartSettings.Areas[0].Objects.Count != 0)
					{
						enumerator2 = chartingSettings.ChartSettings.Areas[0].Objects.OfType<HorizontalLineObject>().GetEnumerator();
						int num5 = 9;
						num = num5;
						continue;
					}
					goto IL_044c;
				case 6:
					Directory.CreateDirectory(j18iDj9nukSCmEyZs5lH.das9Gr3ODK2());
					goto IL_047d;
				case 9:
					try
					{
						while (tpJapEbSk0wGaQcvmXlO(enumerator2))
						{
							HorizontalLineObject current2 = enumerator2.Current;
							if (hashSet.Contains(current2.ObjectID))
							{
								continue;
							}
							int num4 = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_4aa3a79213674c27a6bc763076b8caed != 0)
							{
								num4 = 0;
							}
							while (true)
							{
								switch (num4)
								{
								case 1:
									break;
								default:
									hashSet.Add(current2.ObjectID);
									list.Add(current2);
									num4 = 1;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a8990374f0e04177b45918e3dd7a2d4b == 0)
									{
										num4 = 0;
									}
									continue;
								}
								break;
							}
						}
					}
					finally
					{
						enumerator2?.Dispose();
					}
					goto IL_044c;
				case 4:
					if (!bp2n5YbSlNVXLK6EZvaS(SEjxFhbSilXFPgemYxK2()))
					{
						goto case 6;
					}
					goto IL_047d;
				default:
					try
					{
						while (true)
						{
							int num2;
							if (enumerator.MoveNext())
							{
								current = enumerator.Current;
								num2 = 1;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d3afdd6ad27a4c3b87071f1be51e7ef3 == 0)
								{
									num2 = 1;
								}
							}
							else
							{
								num2 = 2;
							}
							while (true)
							{
								switch (num2)
								{
								case 2:
									return;
								case 1:
								{
									string fileName2 = (string)SEjxFhbSilXFPgemYxK2() + stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x2D3134C9 ^ 0x2D35674D) + current.Key + stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x28BBDCA ^ 0x28BEDCC);
									MarketSettings marketSettings2 = ConfigSerializer.LoadFromFile<MarketSettings>(fileName2, jjKtVJ9pUSOpdg38tqnP.PV29p3fNsns());
									if (marketSettings2 != null)
									{
										marketSettings2.UniversalSignalLevels = current.ToList();
										ConfigSerializer.SaveToFile(marketSettings2, fileName2);
										num2 = 3;
										continue;
									}
									num2 = 0;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_409738fae61f4f058345c98b7cfbcbac != 0)
									{
										num2 = 0;
									}
									continue;
								}
								case 3:
								{
									string fileName = j18iDj9nukSCmEyZs5lH.das9Gr3ODK2() + (string)dN56kabS4VOBZxwqoUog(-1435596783 ^ -1435837593) + current.Key + stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-2056710528 ^ -2056698234);
									MarketSettings marketSettings = ConfigSerializer.LoadFromFile<MarketSettings>(fileName, jjKtVJ9pUSOpdg38tqnP.PV29p3fNsns());
									marketSettings.UniversalSignalLevels = current.ToList();
									ConfigSerializer.SaveToFile(marketSettings, fileName);
									break;
								}
								}
								break;
							}
						}
					}
					finally
					{
						if (enumerator != null)
						{
							xKMAiebS1lkcOFMuHSnG(enumerator);
							int num3 = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a057f43d61f46eca6f419bc48c31d04 == 0)
							{
								num3 = 0;
							}
							switch (num3)
							{
							case 0:
								break;
							}
						}
					}
				case 3:
					break;
				case 2:
					{
						if (num6 >= array.Length)
						{
							if (list.Count == 0)
							{
								num = 1;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_35216e71f4e34e739f4a05a1213f3579 != 0)
								{
									num = 1;
								}
								continue;
							}
							goto case 4;
						}
						string text = array[num6];
						if (oBxpINbSv7j5Eeop5TYl(text, dN56kabS4VOBZxwqoUog(0x3544E813 ^ 0x35445875)))
						{
							chartingSettings = ConfigSerializer.LoadFromFile<ChartingSettings>(text, (DataContractResolver)AYxkDwbSbqIftODgro48());
							num = 8;
							continue;
						}
						goto IL_044c;
					}
					IL_044c:
					num6++;
					num = 2;
					continue;
					IL_047d:
					enumerator = (from l in list
						group l by l.SymbolID).GetEnumerator();
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_84569ba2345a4be7ac2af6ab5d67eaf9 == 0)
					{
						num = 0;
					}
					continue;
				}
				break;
			}
			goto IL_0430;
		}
		catch (Exception ex)
		{
			Jo1ytubS5cVaFVAWMbjm(ex);
		}
	}

	static RpOpxq91jD3gNPA5cpBR()
	{
		ygobWubSSmPK12C5GvgL();
	}

	internal static bool oBxpINbSv7j5Eeop5TYl(object P_0, object P_1)
	{
		return ((string)P_0).Contains((string)P_1);
	}

	internal static bool J136fubSBHiA10CmgeGr(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object uOdgVbbSag00GwCbqimY(object P_0)
	{
		return ((MarketSettings)P_0).Levels;
	}

	internal static object SEjxFhbSilXFPgemYxK2()
	{
		return j18iDj9nukSCmEyZs5lH.das9Gr3ODK2();
	}

	internal static bool bp2n5YbSlNVXLK6EZvaS(object P_0)
	{
		return Directory.Exists((string)P_0);
	}

	internal static object dN56kabS4VOBZxwqoUog(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static object LHnZhMbSDOLN9MoEEdSK(object P_0, object P_1, object P_2, object P_3)
	{
		return (string)P_0 + (string)P_1 + (string)P_2 + (string)P_3;
	}

	internal static object AYxkDwbSbqIftODgro48()
	{
		return jjKtVJ9pUSOpdg38tqnP.PV29p3fNsns();
	}

	internal static bool q7LCitbSYV4fmbruZsux()
	{
		return j50PydbSGc5PfiJPPecs == null;
	}

	internal static RpOpxq91jD3gNPA5cpBR bCkfl6bSoIc35glN5Imr()
	{
		return j50PydbSGc5PfiJPPecs;
	}

	internal static object MTLtShbSNSK1UvTpicJu()
	{
		return j18iDj9nukSCmEyZs5lH.mCD9GU85vS2();
	}

	internal static bool tpJapEbSk0wGaQcvmXlO(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void xKMAiebS1lkcOFMuHSnG(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void Jo1ytubS5cVaFVAWMbjm(object P_0)
	{
		LogManager.WriteError((Exception)P_0);
	}

	internal static void ygobWubSSmPK12C5GvgL()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}
}
