using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows;
using bl7Or1fDrLHNeTtGhT82;
using Cok5gZfeOOYNUntqe0FS;
using ECOEgqlSad8NUJZ2Dr9n;
using Gw4lH797Nqi7S3NF78x1;
using k2djPS9h3aXysXOe0uK1;
using LkgWJcfsLbF5GV6NcGQ4;
using LKPssPfwOEBXRql5l3eT;
using m5KHHSfSCCCvZdkMl316;
using nDRVH5fO2N3bDxUGOOrY;
using NsWD4W9miMxRbFU3fsu9;
using PGh1t097dKGNtpYw9WbJ;
using TigerTrade.Dx;
using TigerTrade.Dx.Enums;
using TigerTrade.Market.Settings;
using TigerTrade.Tc.Data;
using TuAMtrl1Nd3XoZQQUXf0;
using u42gcKfgzsMRGivVmHf8;
using XUi8EWf1E6l7gdu7kUS9;

namespace IPJZaCfdHSw0REOq6MHH;

internal sealed class Aym3BMfd2Zf0QWlAXB7V : faw8pRfgu9tAi5EEEjfU
{
	private class qOBgb7nP47RayekufqXN
	{
		public long Size;

		public double nHLnPDWTSUy;

		internal static qOBgb7nP47RayekufqXN VnVW9jNM0Z6ScUSB3C7o;

		public qOBgb7nP47RayekufqXN()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			base._002Ector();
		}

		static qOBgb7nP47RayekufqXN()
		{
			Re0ie4NMflVTr5Fux8R3();
		}

		internal static bool LXKeVTNM2hCQpHWjJvvZ()
		{
			return VnVW9jNM0Z6ScUSB3C7o == null;
		}

		internal static qOBgb7nP47RayekufqXN u2e0UoNMHFm7cEVXks9D()
		{
			return VnVW9jNM0Z6ScUSB3C7o;
		}

		internal static void Re0ie4NMflVTr5Fux8R3()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}
	}

	[CompilerGenerated]
	private readonly smTKLVfeMIY6X8kUtDCi bvQfdGMj7UP;

	[CompilerGenerated]
	private readonly wFFFvWfsxErbxn4XFmrR jlSfdYmRbKw;

	private static Aym3BMfd2Zf0QWlAXB7V LiaAM1b2Yv3Ryr3EUer1;

	public wFFFvWfsxErbxn4XFmrR MarketView
	{
		[CompilerGenerated]
		get
		{
			return jlSfdYmRbKw;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public smTKLVfeMIY6X8kUtDCi Kt2fdflAdLh()
	{
		return bvQfdGMj7UP;
	}

	public Aym3BMfd2Zf0QWlAXB7V(wFFFvWfsxErbxn4XFmrR P_0, smTKLVfeMIY6X8kUtDCi P_1)
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		jlSfdYmRbKw = P_0;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_34c8a548a4724373aa05c97fa43f690a != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		bvQfdGMj7UP = P_1;
	}

	public bool CheckUpdate()
	{
		CoPfjK9hF3ASs5TbM8OK coPfjK9hF3ASs5TbM8OK = ((t4J54f97Q2MUX30RSwuQ)cx5vGrb2BgyMftQZNxZs(MarketView.Market.DataProvider)).Position;
		if (MarketView.Settings.TradeSettings.ShowExecutions && MarketView.Market.padfx7SrsRZ() > 20.0)
		{
			return DrGOSlb2a6WIGrQFv4RO(coPfjK9hF3ASs5TbM8OK);
		}
		return false;
	}

	public void Khal96VceVj(DxVisualQueue P_0)
	{
		if (!KGmkETb2lRF7cnPrldcn(((MarketSettings)bFFRWqb2iqF5TlKRZPG2(MarketView)).TradeSettings) || MarketView.Market.padfx7SrsRZ() < 20.0)
		{
			return;
		}
		CoPfjK9hF3ASs5TbM8OK coPfjK9hF3ASs5TbM8OK = ((t4J54f97Q2MUX30RSwuQ)cx5vGrb2BgyMftQZNxZs(MarketView.Market.DataProvider)).Position;
		int num;
		if (coPfjK9hF3ASs5TbM8OK == null)
		{
			num = 3;
			goto IL_0009;
		}
		object obj = coPfjK9hF3ASs5TbM8OK.XlV9wd4ELTW();
		goto IL_06ff;
		IL_06ff:
		if (obj == null)
		{
			return;
		}
		goto IL_06e7;
		IL_0009:
		DateTime openTime = default(DateTime);
		ICollection<cLhcml97bc8jKEraVPl0> collection = default(ICollection<cLhcml97bc8jKEraVPl0>);
		Dictionary<long, qOBgb7nP47RayekufqXN> dictionary = default(Dictionary<long, qOBgb7nP47RayekufqXN>);
		long key = default(long);
		qOBgb7nP47RayekufqXN value = default(qOBgb7nP47RayekufqXN);
		long num3 = default(long);
		bool flag = default(bool);
		string text2 = default(string);
		Rect rect = default(Rect);
		XBrush brush = default(XBrush);
		while (true)
		{
			switch (num)
			{
			case 1:
				openTime = coPfjK9hF3ASs5TbM8OK.XlV9wd4ELTW().OpenTime;
				if (collection != null && !(openTime == DateTime.MinValue))
				{
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9267d25a572643c4b072d1d18111abbd == 0)
					{
						num = 0;
					}
					continue;
				}
				return;
			case 4:
			{
				IEnumerator<cLhcml97bc8jKEraVPl0> enumerator = collection.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						cLhcml97bc8jKEraVPl0 current = enumerator.Current;
						if (JZc3Ueb2b4waCXY6dLhf(current) < openTime)
						{
							continue;
						}
						int num2 = 6;
						while (true)
						{
							switch (num2)
							{
							case 6:
								if (coPfjK9hF3ASs5TbM8OK.PositionSize > 0)
								{
									num2 = 0;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1bb232d361564d93b9a5d5e53983bdb3 == 0)
									{
										num2 = 0;
									}
									continue;
								}
								goto case 2;
							case 2:
								if (YaASaDb2k9kevLOEgBjP(coPfjK9hF3ASs5TbM8OK) < 0)
								{
									if (current.Side != Side.Buy)
									{
										num2 = 0;
										if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_976d29d6825c4c4995e3a2719d735c00 == 0)
										{
											num2 = 1;
										}
										continue;
									}
									break;
								}
								goto case 1;
							default:
								if (o5tPrmb2NTDOs9Iw5Idm(current) != Side.Sell)
								{
									num2 = 2;
									continue;
								}
								break;
							case 4:
								if (!dictionary.TryGetValue(key, out value))
								{
									num2 = 7;
									continue;
								}
								goto IL_04d6;
							case 3:
								dictionary.Add(key, value);
								goto IL_04d6;
							case 5:
								break;
							case 7:
								value = new qOBgb7nP47RayekufqXN();
								num2 = 3;
								continue;
							case 1:
								{
									key = MarketView.Market.DataProvider.sUYlnolEAnK(GWKyOeb21N2XRXPNwC5w(current));
									num3 = ((current.Side == Side.Buy) ? c02R50b25VpBepnY1Poi(current) : (-c02R50b25VpBepnY1Poi(current)));
									num2 = 0;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_84569ba2345a4be7ac2af6ab5d67eaf9 == 0)
									{
										num2 = 4;
									}
									continue;
								}
								IL_04d6:
								value.Size += num3;
								if (flag)
								{
									value.nHLnPDWTSUy += MarketView.Symbol.nlhnGCG2624(num3, current.Price);
									num2 = 5;
									continue;
								}
								break;
							}
							break;
						}
					}
				}
				finally
				{
					if (enumerator == null)
					{
						int num4 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3023bd6c0f7846878513499bf5c36161 != 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
					}
					else
					{
						enumerator.Dispose();
					}
				}
				goto case 5;
			}
			case 6:
				flag = ((MarketSettings)bFFRWqb2iqF5TlKRZPG2(MarketView)).TradeSettings.PositionSizeDisplayType == OnRZP7fwMaIGMRJa0UZR.RXcfwIii4Nl;
				num = 4;
				continue;
			case 3:
				break;
			default:
				goto IL_069c;
			case 7:
				return;
			case 5:
			{
				using Dictionary<long, qOBgb7nP47RayekufqXN>.Enumerator enumerator2 = dictionary.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					while (true)
					{
						KeyValuePair<long, qOBgb7nP47RayekufqXN> current2 = enumerator2.Current;
						if (current2.Value.Size == 0L)
						{
							break;
						}
						double num5 = D6rDZFb2Sln0sSce4ALt(MarketView.Market, current2.Key);
						if (num5 < 0.0 - qhHeVSb2xci7wFimFdXY(MarketView.Market))
						{
							break;
						}
						int num6 = 7;
						while (true)
						{
							object obj2;
							string text;
							switch (num6)
							{
							case 2:
								obj2 = GCJrUnb2cEy4QyAvJNoV(yQHM66b2Xhi4rQipaFxe(MarketView));
								goto IL_0384;
							case 4:
							{
								double num7 = Math.Min(Math.Max(((XFont)LohwDgb2L6Hg01TXt5N7(MarketView.Settings)).GetWidth(text2) + 6.0, 35.0), MyYCbcb2eNZfSRyKwME5(MarketView.Market) - 10.0);
								rect = new Rect(new Point((double)((int)((XrTs9ufSVt0hx8rJDd6l)X6T9hIb2sn2Bxb2Vbo0P(MarketView)).LXJfxF1ydT3() - 5) - num7, (int)num5), new Point((int)MarketView.Market.LXJfxF1ydT3() - 5, (double)(int)num5 + MarketView.Market.I8MfLNiJ00B()));
								if (current2.Value.Size <= 0)
								{
									int num8 = 2;
									num6 = num8;
									continue;
								}
								obj2 = MarketView.Theme.kbAfOyqJf1N;
								goto IL_0384;
							}
							case 6:
								break;
							case 7:
								goto IL_01c8;
							case 1:
								text = MarketView.Symbol.FormatRawSizeFull(current2.Value.Size);
								goto IL_0368;
							case 3:
								goto end_IL_0102;
							case 5:
								if (flag)
								{
									num6 = 0;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1db4437ae4614880b2ad46efdc78cb73 == 0)
									{
										num6 = 0;
									}
									continue;
								}
								goto case 1;
							default:
								{
									text = MarketView.Symbol.oFonGPo7jqW(current2.Value.nHLnPDWTSUy);
									goto IL_0368;
								}
								IL_0384:
								brush = (XBrush)obj2;
								num6 = 6;
								continue;
								IL_0368:
								text2 = text;
								num6 = 4;
								continue;
							}
							P_0.FillRectangle(brush, rect);
							P_0.DrawString(text2, MarketView.Settings.BaseFont, MarketView.Theme.cYJfOxYsuth, rect, XTextAlignment.Center);
							goto end_IL_02ce;
							IL_01c8:
							if (num5 > MarketView.wD9fXGNmvlC())
							{
								goto end_IL_02ce;
							}
							num6 = 5;
							continue;
							end_IL_0102:
							break;
						}
						continue;
						end_IL_02ce:
						break;
					}
				}
				return;
			}
			case 2:
				goto IL_06e7;
			}
			break;
			IL_069c:
			if (DOj3HJb2DCD94U236eGU(openTime, DateTime.MaxValue))
			{
				num = 7;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_45006ec5334a406896281e648c9b6ca0 == 0)
				{
					num = 4;
				}
			}
			else
			{
				dictionary = new Dictionary<long, qOBgb7nP47RayekufqXN>();
				num = 6;
			}
		}
		obj = null;
		goto IL_06ff;
		IL_06e7:
		if (coPfjK9hF3ASs5TbM8OK.PositionSize == 0L)
		{
			return;
		}
		collection = ((ypqMIv9maFM0tRwF0xMh)bfP9K2b246Uenpu5W4pK(MarketView.Market)).d73l9JpDb23.Executions;
		num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f027e87a9f614f4a92c0338386fb11cd == 0)
		{
			num = 1;
		}
		goto IL_0009;
	}

	static Aym3BMfd2Zf0QWlAXB7V()
	{
		uakTIRb2jW4JPGPDWE5V();
	}

	internal static bool eHm0ywb2o2LBMdVnEgrX()
	{
		return LiaAM1b2Yv3Ryr3EUer1 == null;
	}

	internal static Aym3BMfd2Zf0QWlAXB7V Y9yQyKb2vFHGYI3DiQ4b()
	{
		return LiaAM1b2Yv3Ryr3EUer1;
	}

	internal static object cx5vGrb2BgyMftQZNxZs(object P_0)
	{
		return ((ypqMIv9maFM0tRwF0xMh)P_0).d73l9JpDb23;
	}

	internal static bool DrGOSlb2a6WIGrQFv4RO(object P_0)
	{
		return ((CoPfjK9hF3ASs5TbM8OK)P_0).Ry49wLUnItu();
	}

	internal static object bFFRWqb2iqF5TlKRZPG2(object P_0)
	{
		return ((wFFFvWfsxErbxn4XFmrR)P_0).Settings;
	}

	internal static bool KGmkETb2lRF7cnPrldcn(object P_0)
	{
		return ((CR1isWfDCD1A4fwfUJUf)P_0).ShowExecutions;
	}

	internal static object bfP9K2b246Uenpu5W4pK(object P_0)
	{
		return ((cXwoI5f1jl9EMXW8XL7D)P_0).DataProvider;
	}

	internal static bool DOj3HJb2DCD94U236eGU(DateTime P_0, DateTime P_1)
	{
		return P_0 == P_1;
	}

	internal static DateTime JZc3Ueb2b4waCXY6dLhf(object P_0)
	{
		return ((cLhcml97bc8jKEraVPl0)P_0).Time;
	}

	internal static Side o5tPrmb2NTDOs9Iw5Idm(object P_0)
	{
		return ((cLhcml97bc8jKEraVPl0)P_0).Side;
	}

	internal static long YaASaDb2k9kevLOEgBjP(object P_0)
	{
		return ((CoPfjK9hF3ASs5TbM8OK)P_0).PositionSize;
	}

	internal static long GWKyOeb21N2XRXPNwC5w(object P_0)
	{
		return ((cLhcml97bc8jKEraVPl0)P_0).Price;
	}

	internal static long c02R50b25VpBepnY1Poi(object P_0)
	{
		return ((cLhcml97bc8jKEraVPl0)P_0).Quantity;
	}

	internal static double D6rDZFb2Sln0sSce4ALt(object P_0, long P_1)
	{
		return ((XrTs9ufSVt0hx8rJDd6l)P_0).htQfSzN6bG1(P_1);
	}

	internal static double qhHeVSb2xci7wFimFdXY(object P_0)
	{
		return ((XrTs9ufSVt0hx8rJDd6l)P_0).I8MfLNiJ00B();
	}

	internal static object LohwDgb2L6Hg01TXt5N7(object P_0)
	{
		return ((MarketSettings)P_0).BaseBoldFont;
	}

	internal static double MyYCbcb2eNZfSRyKwME5(object P_0)
	{
		return ((XrTs9ufSVt0hx8rJDd6l)P_0).padfx7SrsRZ();
	}

	internal static object X6T9hIb2sn2Bxb2Vbo0P(object P_0)
	{
		return ((wFFFvWfsxErbxn4XFmrR)P_0).Market;
	}

	internal static object yQHM66b2Xhi4rQipaFxe(object P_0)
	{
		return ((wFFFvWfsxErbxn4XFmrR)P_0).Theme;
	}

	internal static object GCJrUnb2cEy4QyAvJNoV(object P_0)
	{
		return ((brG9LqfO0TVwbKGahwYo)P_0).uX1fOwXKTT5;
	}

	internal static void uakTIRb2jW4JPGPDWE5V()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}
}
