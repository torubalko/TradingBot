using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using b1neT39sxtGuKbVPRyqn;
using C7UvAf9ri2R97XEwp7o2;
using ECOEgqlSad8NUJZ2Dr9n;
using Gw4lH797Nqi7S3NF78x1;
using LuhTk09IM2UNqIu1VNrV;
using MIA3eC2ZXsuRyAB0mjn;
using NsWD4W9miMxRbFU3fsu9;
using PGh1t097dKGNtpYw9WbJ;
using PMH7kB9LS7xf0LikQbe5;
using QmOgjd9h4C152q15GnsF;
using s8CVoTnYOlGDs7vDiB5f;
using TiCeIH2IsQBNx4GCkaT;
using TigerTrade.Chart.Base;
using TigerTrade.Chart.Base.Enums;
using TigerTrade.Chart.Clusters.Enums;
using TigerTrade.Chart.Data;
using TigerTrade.Chart.Indicators.Common;
using TigerTrade.Chart.Indicators.Enums;
using TigerTrade.Chart.Indicators.List;
using TigerTrade.Chart.Settings;
using TigerTrade.Chart.Theme;
using TigerTrade.Dx;
using TigerTrade.Dx.Enums;
using TigerTrade.Tc.Data;
using TuAMtrl1Nd3XoZQQUXf0;
using W7vgMFnvUmmoQloCDPpC;
using Wf1kTvnGy6XhfTKJgfkM;
using XYJVD39Q3kpWDdU6CuiD;

namespace yXucyU9VB08PQjMik8dX;

[Indicator("Price", "Price", false, Type = typeof(qEcb3w9VvrqaZ6RgPZhq))]
[DataContract(Name = "PriceIndicator", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
internal sealed class qEcb3w9VvrqaZ6RgPZhq : fi0dX39rarBK9dp2dGQR
{
	private static class fGBEm2nuLBtKTXBsve7d
	{
		private static readonly Dictionary<HeatmapTypes, BitmapImage> FJHnusOqoWX;

		private static readonly Dictionary<HeatmapTypes, List<Color>> d3inuXSNhrF;

		internal static fGBEm2nuLBtKTXBsve7d NBaO4dNtK1eem4pGWk6j;

		static fGBEm2nuLBtKTXBsve7d()
		{
			int num = 2;
			int num2 = num;
			Dictionary<HeatmapTypes, BitmapImage>.Enumerator enumerator = default(Dictionary<HeatmapTypes, BitmapImage>.Enumerator);
			BitmapSource value = default(BitmapSource);
			int num4 = default(int);
			List<Color> list = default(List<Color>);
			byte[] array = default(byte[]);
			int num6 = default(int);
			while (true)
			{
				switch (num2)
				{
				case 1:
					bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
					FJHnusOqoWX = new Dictionary<HeatmapTypes, BitmapImage>
					{
						{
							HeatmapTypes.DarkToOrange,
							new BitmapImage(new Uri((string)XIrxh3NtwHSsjLWoxVPU(-342738082 ^ -342448248)))
						},
						{
							HeatmapTypes.DarkToRed,
							new BitmapImage(new Uri(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x3E0426F0 ^ 0x3E00BB8E)))
						},
						{
							HeatmapTypes.Grayscale,
							new BitmapImage(new Uri(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x32DEA4F1 ^ 0x32DA3AD1)))
						}
					};
					d3inuXSNhrF = new Dictionary<HeatmapTypes, List<Color>>();
					enumerator = FJHnusOqoWX.GetEnumerator();
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44d9df62f7524f8eb2abdc23baf0c87b != 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_35216e71f4e34e739f4a05a1213f3579 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				try
				{
					while (enumerator.MoveNext())
					{
						while (true)
						{
							KeyValuePair<HeatmapTypes, BitmapImage> current = enumerator.Current;
							int num3 = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_68b6172210394c1b93f49e43376ff3af == 0)
							{
								num3 = 0;
							}
							while (true)
							{
								switch (num3)
								{
								case 6:
									value = current.Value;
									num4 = rOlgpVNt7cUBdWMeK5pO(value) * 4;
									num3 = 7;
									continue;
								case 4:
									d3inuXSNhrF.Add(current.Key, new List<Color>());
									goto case 5;
								case 5:
									list = d3inuXSNhrF[current.Key];
									num3 = 6;
									continue;
								case 2:
									break;
								case 1:
									P7LvTgNtALe9qUtgyLq0(value, array, num4, 0);
									num6 = 0;
									goto IL_017c;
								case 3:
								{
									int num5 = 4 * num6;
									byte a = array[num5 + 3];
									byte r = array[num5 + 2];
									byte g = array[num5 + 1];
									byte b = array[num5];
									Color item = Color.FromArgb(a, r, g, b);
									list.Add(item);
									num6++;
									goto IL_017c;
								}
								case 7:
									array = new byte[XUvPN6Nt8WxlyVt1c9uq(value) * num4];
									num3 = 1;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fa74d46e0c824e0b89c71deca0488611 == 0)
									{
										num3 = 1;
									}
									continue;
								default:
									if (d3inuXSNhrF.ContainsKey(current.Key))
									{
										num3 = 5;
										continue;
									}
									goto case 4;
								}
								break;
								IL_017c:
								if (num6 >= value.PixelWidth)
								{
									goto end_IL_01b1;
								}
								num3 = 3;
							}
							continue;
							end_IL_01b1:
							break;
						}
					}
					return;
				}
				finally
				{
					((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
				}
			}
		}

		public static Color MwSnue8wF52(HeatmapTypes P_0, int P_1, int P_2)
		{
			if (P_1 == 0)
			{
				goto IL_00de;
			}
			int num;
			if (!d3inuXSNhrF.ContainsKey(P_0))
			{
				num = 3;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8a9257c2b61741afa02a8ceb1f69ad69 == 0)
				{
					num = 2;
				}
				goto IL_0009;
			}
			object obj = d3inuXSNhrF[P_0];
			goto IL_014e;
			IL_0009:
			List<Color> list = default(List<Color>);
			int num2 = default(int);
			int num3 = default(int);
			while (true)
			{
				switch (num)
				{
				case 4:
					return list[num2];
				default:
					num2 = 0;
					goto IL_010e;
				case 2:
					num2 = Convert.ToInt32(CSYBLKNtFuKG99vqePFL(KbZRasNtJRvr536loBEX(P_1 * (oVpfqANtPfvJC7S38KWn(list) - 1 - num3)), 100m)) + num3;
					if (num2 < 0)
					{
						num = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cf96ea40632b4cc9a71884e2b5dceb8b == 0)
						{
							num = 0;
						}
						continue;
					}
					goto IL_010e;
				case 1:
					break;
				case 3:
					goto IL_0123;
					IL_010e:
					if (num2 > oVpfqANtPfvJC7S38KWn(list) - 1)
					{
						num2 = list.Count - 1;
						num = 4;
						continue;
					}
					goto case 4;
				}
				break;
			}
			goto IL_00de;
			IL_0123:
			obj = null;
			goto IL_014e;
			IL_00de:
			return Colors.Transparent;
			IL_014e:
			list = (List<Color>)obj;
			if (list == null)
			{
				return Colors.Transparent;
			}
			num3 = (int)((double)P_2 / 4.0);
			num = 2;
			goto IL_0009;
		}

		internal static object XIrxh3NtwHSsjLWoxVPU(int P_0)
		{
			return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
		}

		internal static int rOlgpVNt7cUBdWMeK5pO(object P_0)
		{
			return ((BitmapSource)P_0).PixelWidth;
		}

		internal static int XUvPN6Nt8WxlyVt1c9uq(object P_0)
		{
			return ((BitmapSource)P_0).PixelHeight;
		}

		internal static void P7LvTgNtALe9qUtgyLq0(object P_0, object P_1, int P_2, int P_3)
		{
			((BitmapSource)P_0).CopyPixels((Array)P_1, P_2, P_3);
		}

		internal static bool B3Y9mhNtmTb212coMTLv()
		{
			return NBaO4dNtK1eem4pGWk6j == null;
		}

		internal static fGBEm2nuLBtKTXBsve7d zSWcLkNthKjF6EDTDuTK()
		{
			return NBaO4dNtK1eem4pGWk6j;
		}

		internal static int oVpfqANtPfvJC7S38KWn(object P_0)
		{
			return ((List<Color>)P_0).Count;
		}

		internal static decimal KbZRasNtJRvr536loBEX(int P_0)
		{
			return P_0;
		}

		internal static decimal CSYBLKNtFuKG99vqePFL(decimal P_0, decimal P_1)
		{
			return P_0 / P_1;
		}
	}

	private sealed class NCmusEnucnxgidaxWgeo
	{
		private Rect R26nuQdOwqY;

		private readonly long NW8nudNvft7;

		private readonly long gCunugLY04w;

		private readonly Side kZpnuRoCpS5;

		private static NCmusEnucnxgidaxWgeo U3HTxoNt37YG7eJ03AkX;

		public NCmusEnucnxgidaxWgeo(Rect P_0, cLhcml97bc8jKEraVPl0 P_1)
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			base._002Ector();
			R26nuQdOwqY = P_0;
			NW8nudNvft7 = P_1.Price;
			int num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1693d43c67f14e0eba9f86b0171ecbd6 != 0)
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
					gCunugLY04w = P_1.Quantity;
					kZpnuRoCpS5 = P_1.Side;
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a93c63471a5d4726b3bdf40a69cdb422 == 0)
					{
						num = 0;
					}
					break;
				}
			}
		}

		public bool puhnuj6p6Rw(Point P_0)
		{
			return R26nuQdOwqY.Contains(P_0);
		}

		public string WXVnuEayIKO(ypqMIv9maFM0tRwF0xMh P_0)
		{
			return string.Format(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-53782092 ^ -53491846), kZpnuRoCpS5, c84N5wNtzaP4dFmkwo2L(P_0.Symbol, gCunugLY04w), P_0.Symbol.uhTnGh8ahcs(NW8nudNvft7));
		}

		static NCmusEnucnxgidaxWgeo()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}

		internal static bool jgYUhfNtpxya3sE9aqWc()
		{
			return U3HTxoNt37YG7eJ03AkX == null;
		}

		internal static NCmusEnucnxgidaxWgeo kvlnqXNtu0uI45QXc9NT()
		{
			return U3HTxoNt37YG7eJ03AkX;
		}

		internal static object c84N5wNtzaP4dFmkwo2L(object P_0, long P_1)
		{
			return ((SymbolBase)P_0).FormatRawSizeFull(P_1);
		}
	}

	private sealed class bcXA9Knu6oJtSapprNob
	{
		private Rect AmnnuqnhMH5;

		private readonly bool nwrnuIsD5Oe;

		private readonly DateTime VCXnuW3JqbV;

		private readonly double ETpnutcBYYX;

		private readonly Side K0FnuUrxqts;

		private readonly double nW8nuTGZw5S;

		private readonly double aIWnuyGOIf4;

		private readonly double J48nuZRKNyN;

		internal static bcXA9Knu6oJtSapprNob z4iTCSNU0LNOrPe5hLVb;

		public bcXA9Knu6oJtSapprNob(Rect P_0, IhHpoC9hliGX2eZqQA6k P_1, bool P_2)
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			base._002Ector();
			nwrnuIsD5Oe = P_2;
			AmnnuqnhMH5 = P_0;
			int num = 5;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ba87d68105604f98a891a0549ef4b7f9 != 0)
			{
				num = 4;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					ETpnutcBYYX = P_1.OpenPrice;
					goto case 4;
				case 4:
					K0FnuUrxqts = PufgTPNUfovPyOYqguIO(P_1);
					return;
				case 2:
					VCXnuW3JqbV = P_1.CloseTime;
					ETpnutcBYYX = P_1.ClosePrice;
					nW8nuTGZw5S = P_1.Quantity;
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_12e8a768a5674e7d88b4e5ccd4fb7295 != 0)
					{
						num = 0;
					}
					break;
				case 3:
					VCXnuW3JqbV = P_1.OpenTime;
					num = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2088b9a28522490e83dc44062c40a7c0 != 0)
					{
						num = 1;
					}
					break;
				case 5:
					if (P_2)
					{
						num = 3;
						break;
					}
					goto case 2;
				default:
					aIWnuyGOIf4 = P_1.Points;
					J48nuZRKNyN = P_1.Profit;
					num = 3;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2fa91f76013747d9b5f0073a2a323201 == 0)
					{
						num = 4;
					}
					break;
				}
			}
		}

		public bool nOtnuMXBQBM(Point P_0)
		{
			return AmnnuqnhMH5.Contains(P_0);
		}

		public List<string> cLbnuOrhNIn(ypqMIv9maFM0tRwF0xMh P_0)
		{
			if (nwrnuIsD5Oe)
			{
				string item = ((K0FnuUrxqts == Side.Buy) ? stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1127423276 ^ -1127711280) : stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x4220DA8 ^ 0x4269344));
				string item2 = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1583344314 ^ -1583052196) + P_0.Symbol.FormatTime(VCXnuW3JqbV, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1161619942 ^ -1161690768));
				string item3 = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-123775059 ^ -124008317) + P_0.Symbol.F7PnGKuif8P(ETpnutcBYYX);
				return new List<string> { item, item2, item3 };
			}
			string item4 = ((K0FnuUrxqts == Side.Buy) ? stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-490987856 ^ -491224594) : stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x735715F1 ^ 0x73538AB5));
			string item5 = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1087080834 ^ -1087313564) + P_0.Symbol.FormatTime(VCXnuW3JqbV, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x34407BB ^ 0x34510D1));
			string item6 = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x42D899B5 ^ 0x42DC069B) + P_0.Symbol.F7PnGKuif8P(ETpnutcBYYX);
			string item7 = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x3E0426F0 ^ 0x3E00B986) + P_0.Symbol.Fv5nGw2n73r(nW8nuTGZw5S);
			string item8 = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1380525184 ^ -1380826094) + P_0.Symbol.AYZnG3b2I7A(aIWnuyGOIf4);
			string item9 = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1461292091 ^ -1461523345) + P_0.Symbol.FormatMoneyPnl(J48nuZRKNyN);
			return new List<string> { item4, item5, item6, item7, item8, item9 };
		}

		static bcXA9Knu6oJtSapprNob()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}

		internal static Side PufgTPNUfovPyOYqguIO(object P_0)
		{
			return ((IhHpoC9hliGX2eZqQA6k)P_0).Side;
		}

		internal static bool GEqPkONU2U11sQKAx7Zs()
		{
			return z4iTCSNU0LNOrPe5hLVb == null;
		}

		internal static bcXA9Knu6oJtSapprNob M6P5lRNUHsM5mvFPGXj2()
		{
			return z4iTCSNU0LNOrPe5hLVb;
		}
	}

	private sealed class me021enuViEjoFdJlZYV
	{
		public int s7unuCGVyQQ;

		public bool Jf1nurJhVRO;

		public double YTXnuKOC1lk;

		public double ColumnWidth;

		public double v3TnumakUEq;

		public double XwNnuhiXaoi;

		public double CenterX;

		public double aYpnuwO8Vos;

		public double rB1nu7twWyg;

		public double Qjbnu8cIx4T;

		public double aWdnuAaPRkF;

		public double EOcnuPAGkSA;

		public double o1LnuJLdjKL;

		public double qOJnuFOtqYg;

		public bool q7Dnu3Ck9ZT;

		public bool X1tnupPKJ6Q;

		public XFont yoknuu2ELyt;

		public long XSTnuziHlxS;

		public long Cernz0EgckQ;

		public long QfInz2KpKYU;

		public long kbWnzHuOgBw;

		public long T9JnzfkRxZO;

		public long s67nz9oCZGJ;

		public long hHqnznKqJax;

		public long aKjnzGRd91Z;

		public long JexnzYY6iOg;

		public long b4nnzo6IioA;

		public long yminzv514RX;

		public long psbnzBHbgaI;

		public long Gapnza9HpFZ;

		public long l89nzi9PskI;

		public long GvknzlD2kYR;

		public List<IContainsSelection> eBdnz44CrCj;

		public bool KwBnzDPHQZd;

		public List<D8gyZXnz5m1y5iiw1dIF> hcQnzb4ilbk;

		public List<IContainsConditions> Conditions;

		public bool jRInzNcceFv;

		public double O1onzkr76U9;

		public long n5Rnz130BFd;

		public int Round;

		internal static me021enuViEjoFdJlZYV PBXRyPNU9rfMTRJ5EvZ4;

		public me021enuViEjoFdJlZYV()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			base._002Ector();
		}

		static me021enuViEjoFdJlZYV()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}

		internal static bool vci9TCNUnrGe5bqGBrcC()
		{
			return PBXRyPNU9rfMTRJ5EvZ4 == null;
		}

		internal static me021enuViEjoFdJlZYV uL9ObENUGn5Abv55dIKY()
		{
			return PBXRyPNU9rfMTRJ5EvZ4;
		}
	}

	private sealed class D8gyZXnz5m1y5iiw1dIF
	{
		public readonly ClusterFilterType ujrnzSm3Awj;

		public readonly long BZKnzxXwCj0;

		public readonly long MaxValue;

		public readonly XColor HiBnzLvMJQc;

		public readonly XColor HfFnze2YjU0;

		public readonly bool NjInzsEaa8e;

		public readonly bool a8RnzXVwbA2;

		public readonly bool yf8nzc7gswU;

		private static D8gyZXnz5m1y5iiw1dIF yUs879NUYvpcgvUZFbFK;

		public D8gyZXnz5m1y5iiw1dIF(qgZ6Li9QFC3a8WBFqHZ4 P_0)
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			base._002Ector();
			ujrnzSm3Awj = WNjxj8NUBY1s5oP5iy7P(P_0);
			HiBnzLvMJQc = P_0.BackColor;
			HfFnze2YjU0 = KI8eMiNUaIPTwhDHpIAY(P_0);
			long? num = P_0.MinValue;
			long? num2 = P_0.MaxValue;
			int num3 = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dfd8fb340d494755970617a38d3a8729 == 0)
			{
				num3 = 1;
			}
			long? num5 = default(long?);
			long num4 = default(long);
			while (true)
			{
				switch (num3)
				{
				case 5:
					if (num5 >= num4)
					{
						num3 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_53f0c1974ed349c3831704ecb4d3ce13 != 0)
						{
							num3 = 0;
						}
						continue;
					}
					return;
				case 7:
					yf8nzc7gswU = true;
					MaxValue = num2.Value;
					return;
				case 1:
					num5 = num;
					num3 = 3;
					continue;
				case 4:
					num4 = 0L;
					num3 = 5;
					continue;
				case 6:
					if (num5 >= num4)
					{
						NjInzsEaa8e = true;
						a8RnzXVwbA2 = true;
						BZKnzxXwCj0 = num.Value;
						num3 = 2;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03c20a54a7dc45f8a5130d4984fa4aea == 0)
						{
							num3 = 0;
						}
						continue;
					}
					break;
				default:
					NjInzsEaa8e = true;
					num3 = 7;
					continue;
				case 3:
					num4 = 0L;
					num3 = 6;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f3775e6a3cb04c0998106e46ff04d8ab != 0)
					{
						num3 = 6;
					}
					continue;
				case 2:
					break;
				}
				num5 = num2;
				num3 = 4;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7573e3aca29a46a9959af01ed2386da5 == 0)
				{
					num3 = 1;
				}
			}
		}

		static D8gyZXnz5m1y5iiw1dIF()
		{
			ix9MShNUiGk2Wq7HyMlD();
		}

		internal static ClusterFilterType WNjxj8NUBY1s5oP5iy7P(object P_0)
		{
			return ((qgZ6Li9QFC3a8WBFqHZ4)P_0).FilterType;
		}

		internal static XColor KI8eMiNUaIPTwhDHpIAY(object P_0)
		{
			return ((qgZ6Li9QFC3a8WBFqHZ4)P_0).TextColor;
		}

		internal static bool NTWr7dNUo7H6UOil6uHJ()
		{
			return yUs879NUYvpcgvUZFbFK == null;
		}

		internal static D8gyZXnz5m1y5iiw1dIF Wm62qnNUvv86WsMtdFf2()
		{
			return yUs879NUYvpcgvUZFbFK;
		}

		internal static void ix9MShNUiGk2Wq7HyMlD()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}
	}

	private static XBrush QIX9VmYrFEt;

	private PriceLinePosition M1Y9VhDHCJt;

	private bool H0l9VwqM8So;

	[CompilerGenerated]
	private XBrush caL9V7s0JRR;

	[CompilerGenerated]
	private XPen flS9V8kRRDH;

	private XColor KJb9VANIOaU;

	private int NbI9VPAClcv;

	private XDashStyle VjQ9VJuCMZh;

	private PriceBarType u1a9VFlUeEu;

	private int u2c9V3x6xn9;

	private IndicatorPriceType huv9Vpu4EwM;

	private int AVM9VuNOWXi;

	private KO34fu9L5FtbhDmWJ1ad evr9VzPFX3p;

	private dyykKj9sS7wbwJvEPZ4K lbJ9C0b0VnB;

	private List<NCmusEnucnxgidaxWgeo> hAd9C2jgUjO;

	private List<bcXA9Knu6oJtSapprNob> r2s9CHMS2Tr;

	private int G4N9Cf1ayhi;

	private double Ssq9C99Xnpu;

	private double iMI9CnJTSjk;

	internal static qEcb3w9VvrqaZ6RgPZhq LD5ulhbtgAW99LZ8OxDC;

	[DataMember(Name = "PriceLinePosition")]
	[T4IXj62qBfXCaxs2RI5("ChartIndicatorsPriceLine")]
	[bBo0Zd2ycQQr3LNHQf4("ChartIndicatorsPosition")]
	public PriceLinePosition PriceLinePosition
	{
		get
		{
			return M1Y9VhDHCJt;
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					if (priceLinePosition != M1Y9VhDHCJt)
					{
						M1Y9VhDHCJt = priceLinePosition;
						OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--737722733 ^ 0x2BFCB165));
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3023bd6c0f7846878513499bf5c36161 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DataMember(Name = "PriceLineCustomColor")]
	[bBo0Zd2ycQQr3LNHQf4("ChartIndicatorsCustomColor")]
	[T4IXj62qBfXCaxs2RI5("ChartIndicatorsPriceLine")]
	public bool PriceLineCustomColor
	{
		get
		{
			return H0l9VwqM8So;
		}
		set
		{
			if (flag != H0l9VwqM8So)
			{
				H0l9VwqM8So = flag;
				lLlYoQbtW7PI1d31Ggw0(this, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x2D3134C9 ^ 0x2D3544E7));
				OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x6D18F862 ^ 0x6D1C8838));
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9cec884f01d949d294f11a9fcceef609 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 0:
					break;
				}
			}
		}
	}

	[Browsable(false)]
	private XBrush Txt9Vdi4sxo
	{
		[CompilerGenerated]
		get
		{
			return caL9V7s0JRR;
		}
		[CompilerGenerated]
		set
		{
			caL9V7s0JRR = xBrush;
		}
	}

	[Browsable(false)]
	private XPen KVT9V6GgOrj
	{
		[CompilerGenerated]
		get
		{
			return flS9V8kRRDH;
		}
		[CompilerGenerated]
		set
		{
			flS9V8kRRDH = xPen;
		}
	}

	[bBo0Zd2ycQQr3LNHQf4("ChartIndicatorsLineColor")]
	[T4IXj62qBfXCaxs2RI5("ChartIndicatorsPriceLine")]
	[DataMember(Name = "PriceLineColor")]
	public XColor PriceLineColor
	{
		get
		{
			return KJb9VANIOaU;
		}
		set
		{
			if (xColor == KJb9VANIOaU)
			{
				return;
			}
			KJb9VANIOaU = xColor;
			int num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3a7b10748dce4fec98054526a92d6ccf == 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					Txt9Vdi4sxo = new XBrush(KJb9VANIOaU);
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1db4437ae4614880b2ad46efdc78cb73 == 0)
					{
						num = 0;
					}
					break;
				default:
					KVT9V6GgOrj = new XPen(Txt9Vdi4sxo, PriceLineWidth, PriceLineStyle);
					lLlYoQbtW7PI1d31Ggw0(this, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x446AB724 ^ 0x446EC77E));
					return;
				}
			}
		}
	}

	[bBo0Zd2ycQQr3LNHQf4("ChartIndicatorsLineWidth")]
	[T4IXj62qBfXCaxs2RI5("ChartIndicatorsPriceLine")]
	[DataMember(Name = "PriceLineWidth")]
	public int PriceLineWidth
	{
		get
		{
			return NbI9VPAClcv;
		}
		set
		{
			num = Math.Max(1, Math.Min(10, num));
			if (num == NbI9VPAClcv)
			{
				return;
			}
			NbI9VPAClcv = num;
			int num2 = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_de1b6b238ba046ff8910d780c42f0e95 != 0)
			{
				num2 = 0;
			}
			while (true)
			{
				switch (num2)
				{
				case 1:
					return;
				}
				KVT9V6GgOrj = new XPen(Txt9Vdi4sxo, NbI9VPAClcv, PriceLineStyle);
				OnPropertyChanged((string)W0Xj2UbttECO5feKGUVN(0x4662F6AF ^ 0x466686D5));
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03c20a54a7dc45f8a5130d4984fa4aea == 0)
				{
					num2 = 0;
				}
			}
		}
	}

	[bBo0Zd2ycQQr3LNHQf4("ChartIndicatorsLineStyle")]
	[T4IXj62qBfXCaxs2RI5("ChartIndicatorsPriceLine")]
	[DataMember(Name = "PriceLineStyle")]
	public XDashStyle PriceLineStyle
	{
		get
		{
			return VjQ9VJuCMZh;
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					if (xDashStyle == VjQ9VJuCMZh)
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9aa9dbd12b8a4a4ea59acea051cdddbf != 0)
						{
							num2 = 0;
						}
						break;
					}
					VjQ9VJuCMZh = xDashStyle;
					KVT9V6GgOrj = new XPen(Txt9Vdi4sxo, PriceLineWidth, VjQ9VJuCMZh);
					OnPropertyChanged((string)W0Xj2UbttECO5feKGUVN(0x60620FC1 ^ 0x60667F5B));
					return;
				case 0:
					return;
				}
			}
		}
	}

	[bBo0Zd2ycQQr3LNHQf4("ChartIndicatorsBarType")]
	[T4IXj62qBfXCaxs2RI5("ChartIndicatorsPriceBars")]
	[DataMember(Name = "BarType")]
	public PriceBarType BarType
	{
		get
		{
			return u1a9VFlUeEu;
		}
		set
		{
			if (priceBarType != u1a9VFlUeEu)
			{
				u1a9VFlUeEu = priceBarType;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0fb8c8dbf8424ce68f439b7b66291a33 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged((string)W0Xj2UbttECO5feKGUVN(-338769610 ^ -339035764));
			}
		}
	}

	[bBo0Zd2ycQQr3LNHQf4("ChartIndicatorsBarWidth")]
	[T4IXj62qBfXCaxs2RI5("ChartIndicatorsPriceBars")]
	[DataMember(Name = "BarWidth")]
	public int BarWidth
	{
		get
		{
			return u2c9V3x6xn9;
		}
		set
		{
			num = Math.Max(0, Math.Min(10, num));
			if (num == u2c9V3x6xn9)
			{
				int num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cf96ea40632b4cc9a71884e2b5dceb8b == 0)
				{
					num2 = 0;
				}
				switch (num2)
				{
				case 0:
					break;
				}
			}
			else
			{
				u2c9V3x6xn9 = num;
				OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x4662F6AF ^ 0x46668663));
			}
		}
	}

	[bBo0Zd2ycQQr3LNHQf4("ChartIndicatorsPriceType")]
	[T4IXj62qBfXCaxs2RI5("ChartIndicatorsPriceLineArea")]
	[DataMember(Name = "PriceType")]
	public IndicatorPriceType PriceType
	{
		get
		{
			return huv9Vpu4EwM;
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					if (indicatorPriceType != huv9Vpu4EwM)
					{
						huv9Vpu4EwM = indicatorPriceType;
						OnPropertyChanged((string)W0Xj2UbttECO5feKGUVN(-894902996 ^ -894652980));
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6d472511f0d246a693dc7622dda5f390 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[T4IXj62qBfXCaxs2RI5("ChartIndicatorsPriceLineArea")]
	[bBo0Zd2ycQQr3LNHQf4("ChartIndicatorsLineWidth")]
	[DataMember(Name = "LineWidth")]
	public int LineWidth
	{
		get
		{
			return AVM9VuNOWXi;
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (num3 != AVM9VuNOWXi)
					{
						AVM9VuNOWXi = num3;
						OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-530053095 ^ -529777057));
					}
					return;
				case 1:
					num3 = Math.Max(1, Math.Min(10, num3));
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dd6de048cd134da6b2674c002762ca45 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[Browsable(false)]
	public override IndicatorCalculation Calculation => IndicatorCalculation.OnEachTick;

	[Browsable(false)]
	public override ChartDataType ChartDataType
	{
		get
		{
			if (base.Settings != null)
			{
				if (cu18skbtCbtdIi1HguWH(base.Settings) == StockViewType.Clusters)
				{
					return ChartDataType.Cluster;
				}
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8c53e9716bd4846babfdefcdb92a575 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
			}
			return ChartDataType.Bar;
		}
	}

	public override bool IsStock => true;

	private XColor YbN9Vap3756(long P_0, long P_1)
	{
		decimal val = 100m / (decimal)P_0 * Qgth9rbtMXNkBS7lng2b(P_1);
		val = GVTixgbtOe1dSMnbBYrB(0m, Math.Min(100m, val));
		return VBMI3UbtILs3XS4Zp0uB(CqDL5vbtqRvT3wNfEJCa(HeatmapTypes.DarkToOrange, (int)val, 100));
	}

	public qEcb3w9VvrqaZ6RgPZhq()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		PriceLinePosition = PriceLinePosition.Right;
		PriceLineCustomColor = false;
		PriceLineColor = VBMI3UbtILs3XS4Zp0uB(Colors.Black);
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_53f0c1974ed349c3831704ecb4d3ce13 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 3:
				PriceType = IndicatorPriceType.Close;
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_426282f87bb443dbbfe9ea3327b81bb7 != 0)
				{
					num = 1;
				}
				continue;
			case 1:
				LineWidth = 1;
				return;
			case 2:
				BarWidth = 0;
				num = 3;
				continue;
			}
			PriceLineWidth = 1;
			PriceLineStyle = XDashStyle.Solid;
			BarType = PriceBarType.OHLC;
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c1a63437a5bc4d139ae2c4a2f19ec947 == 0)
			{
				num = 2;
			}
		}
	}

	public override void MV4l9mTDd9r(vJGfm5nYMCEZFuST02my P_0)
	{
		base.MV4l9mTDd9r(P_0);
		evr9VzPFX3p = base.Settings.ClusterSettings;
		lbJ9C0b0VnB = base.Settings.TradeSettings;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d49d1aa54d194934871b103e21669e22 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	protected override void Execute()
	{
	}

	public override bool GetMinMax(out double P_0, out double P_1)
	{
		long num = long.MinValue;
		long num2 = long.MaxValue;
		int num3 = 0;
		IRawCluster rawCluster = default(IRawCluster);
		while (true)
		{
			int num4;
			if (num3 < base.Canvas.Count)
			{
				int index = base.Canvas.GetIndex(num3);
				rawCluster = (IRawCluster)PpxyT5btUV5G1CSW8BO1(base.DataProvider, index);
				if (rawCluster == null)
				{
					goto IL_013a;
				}
				num4 = 3;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_26fe5531b15948b7a2b6ffb2cd927204 != 0)
				{
					num4 = 2;
				}
			}
			else
			{
				num4 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9aa9dbd12b8a4a4ea59acea051cdddbf == 0)
				{
					num4 = 0;
				}
			}
			while (true)
			{
				switch (num4)
				{
				case 3:
					num = Math.Max(num, rawCluster.High);
					num2 = RvrSVubtyeJxuWF7wHyF(num2, hx9tT7btT6uDeYpqmuqL(rawCluster));
					num4 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dfd8fb340d494755970617a38d3a8729 == 0)
					{
						num4 = 1;
					}
					continue;
				case 4:
					return true;
				default:
					P_0 = (double)num2 * UhtjVEbtZxO5x0nNH1Dx(base.DataProvider);
					num4 = 2;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_495802897f05476f875528905eba9a89 == 0)
					{
						num4 = 2;
					}
					continue;
				case 1:
					break;
				case 2:
					P_1 = (double)num * base.DataProvider.Step;
					num4 = 4;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_859c6249cb0f4f11b2da29d1228ce418 == 0)
					{
						num4 = 3;
					}
					continue;
				}
				break;
			}
			goto IL_013a;
			IL_013a:
			num3++;
		}
	}

	public override void Render(DxVisualQueue P_0)
	{
		Rect rect = ((IChartCanvas)q3DvdcbtVtoCkNGgtXcR(this)).Rect;
		int num;
		if (cu18skbtCbtdIi1HguWH(base.Settings) == StockViewType.Clusters)
		{
			nQ89V4ipZqx(P_0, base.Canvas.ColumnWidth, rect);
			num = 7;
		}
		else
		{
			oCG9Vi9rWKH(P_0, base.Canvas.ColumnWidth, rect);
			num = 6;
		}
		IEnumerator<cLhcml97bc8jKEraVPl0> enumerator2 = default(IEnumerator<cLhcml97bc8jKEraVPl0>);
		IEnumerator<IhHpoC9hliGX2eZqQA6k> enumerator = default(IEnumerator<IhHpoC9hliGX2eZqQA6k>);
		int num6 = default(int);
		double num8 = default(double);
		int num7 = default(int);
		IhHpoC9hliGX2eZqQA6k current = default(IhHpoC9hliGX2eZqQA6k);
		double x = default(double);
		double num4 = default(double);
		double y = default(double);
		double num3 = default(double);
		while (true)
		{
			switch (num)
			{
			default:
				if (Kp3PucbtFYlnVPmAlIOq(lbJ9C0b0VnB))
				{
					enumerator2 = ((t4J54f97Q2MUX30RSwuQ)WXdCBxbtm9IP8Mq69WxC(base.DataProvider)).Executions.GetEnumerator();
					num = 4;
					break;
				}
				return;
			case 3:
				enumerator = ((t4J54f97Q2MUX30RSwuQ)WXdCBxbtm9IP8Mq69WxC(base.DataProvider)).Deals.GetEnumerator();
				num = 2;
				break;
			case 1:
				r2s9CHMS2Tr = new List<bcXA9Knu6oJtSapprNob>();
				goto IL_099f;
			case 6:
			case 7:
				if (r2s9CHMS2Tr == null)
				{
					num = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9cec884f01d949d294f11a9fcceef609 != 0)
					{
						num = 0;
					}
					break;
				}
				aT4n6QbtrAFm3scwRPms(r2s9CHMS2Tr);
				goto IL_099f;
			case 4:
				try
				{
					while (enumerator2.MoveNext())
					{
						cLhcml97bc8jKEraVPl0 current2 = enumerator2.Current;
						int num5 = 7;
						while (true)
						{
							switch (num5)
							{
							default:
								if ((double)num6 > base.Canvas.Rect.Right)
								{
									break;
								}
								num8 = Math.Max(12.0, y0E4BubtuMiIJBYLpVJt(vOTKUObtpRsAuNn9uZB1(q3DvdcbtVtoCkNGgtXcR(this)) - 2.0, 16.0));
								if (current2.Side == Side.Buy)
								{
									Point[] array2 = new Point[3]
									{
										new Point((double)num6 + 0.5, num7),
										new Point((double)(num6 + 1) - num8 / 2.0, (double)num7 + num8 - 2.0),
										new Point((double)num6 + num8 / 2.0, (double)num7 + num8 - 2.0)
									};
									P_0.FillPolygon(cpI9r4xqdTB().Theme.BuyTradeBrush, array2);
									fA6DUQbtzK4WJ0UL0wjN(P_0, cpI9r4xqdTB().Theme.BuyTradeBorderPen, array2);
									int num9 = 5;
									num5 = num9;
									continue;
								}
								goto case 4;
							case 7:
								num6 = (int)IceOX4bt7SQJDh4njAZR(this, ((IChartCanvas)q3DvdcbtVtoCkNGgtXcR(this)).DateToIndex(current2.Time, -1));
								num7 = (int)GetY(J2ntFnbt3f4GdlTpKqYC(base.DataProvider, current2.Price));
								num5 = 1;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1db4437ae4614880b2ad46efdc78cb73 == 0)
								{
									num5 = 1;
								}
								continue;
							case 3:
							case 6:
								break;
							case 4:
							{
								Point[] array = new Point[3]
								{
									new Point((double)num6 + 0.5, num7),
									new Point((double)(num6 + 1) - num8 / 2.0, (double)num7 - num8 + 2.0),
									new Point((double)num6 + num8 / 2.0, (double)num7 - num8 + 2.0)
								};
								P_0.FillPolygon((XBrush)Jvh4wLbU0hxb29XtH0kN(cpI9r4xqdTB().Theme), array);
								fA6DUQbtzK4WJ0UL0wjN(P_0, cpI9r4xqdTB().Theme.SellTradeBorderPen, array);
								num5 = 2;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a337f255b1bd4e8290c28001e28630dc != 0)
								{
									num5 = 1;
								}
								continue;
							}
							case 2:
								hAd9C2jgUjO.Add(new NCmusEnucnxgidaxWgeo(new Rect(new Point((double)num6 - num8 / 2.0 - 2.0, (double)num7 - num8 - 2.0), new Point((double)num6 + num8 / 2.0 + 2.0, num7 + 2)), current2));
								num5 = 3;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7d3c6a8bf09f4ec887f577858231a719 != 0)
								{
									num5 = 1;
								}
								continue;
							case 5:
								hAd9C2jgUjO.Add(new NCmusEnucnxgidaxWgeo(new Rect(new Point((double)num6 - num8 / 2.0 - 2.0, num7 - 2), new Point((double)num6 + num8 / 2.0 + 2.0, (double)num7 + num8 + 2.0)), current2));
								num5 = 6;
								continue;
							case 1:
								if (!((double)num6 < base.Canvas.Rect.Left))
								{
									num5 = 0;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_281cd373231b4974955fe570959430ac == 0)
									{
										num5 = 0;
									}
									continue;
								}
								break;
							}
							break;
						}
					}
					return;
				}
				finally
				{
					if (enumerator2 != null)
					{
						N2bQHwbtJ6T1gTxkkIIX(enumerator2);
					}
				}
			case 2:
				try
				{
					while (true)
					{
						IL_08f9:
						int num2;
						if (enumerator.MoveNext())
						{
							current = enumerator.Current;
							x = GetX(rYAm3sbthtS4HBVxrJqS(base.Canvas, current.OpenTime, -1));
							num2 = 1;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a057f43d61f46eca6f419bc48c31d04 != 0)
							{
								num2 = 2;
							}
						}
						else
						{
							num2 = 7;
						}
						while (true)
						{
							switch (num2)
							{
							case 4:
								P_0.FillEllipse(base.Theme.CloseLongPositionBrush, new Point(num4, y), 5.0, 5.0);
								num2 = 6;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f68538a410dc40459f303c1bac7938ac == 0)
								{
									num2 = 5;
								}
								continue;
							case 3:
								r2s9CHMS2Tr.Add(new bcXA9Knu6oJtSapprNob(new Rect(new Point(num4 - 5.0, y - 5.0), new Point(num4 + 5.0, y + 5.0)), current, _0020: false));
								num2 = 0;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3a7b10748dce4fec98054526a92d6ccf == 0)
								{
									num2 = 0;
								}
								continue;
							case 1:
								P_0.DrawLine(base.Theme.PositionLinePen, new Point(x, num3), new Point(num4, y));
								num2 = 5;
								continue;
							case 6:
								r2s9CHMS2Tr.Add(new bcXA9Knu6oJtSapprNob(new Rect(new Point(num4 - 5.0, y - 5.0), new Point(num4 + 5.0, y + 5.0)), current, _0020: false));
								break;
							case 2:
								num3 = SXlNTDbtwj0C56ClRwuK(this, current.OpenPrice);
								num4 = IceOX4bt7SQJDh4njAZR(this, base.Canvas.DateToIndex(current.CloseTime, -1));
								y = GetY(current.ClosePrice);
								if (!(num4 < pr2IDnbt81xmsDnTdNh7(base.Canvas).Left) && !(x > base.Canvas.Rect.Right))
								{
									num2 = 1;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_12e8a768a5674e7d88b4e5ccd4fb7295 != 0)
									{
										num2 = 1;
									}
									continue;
								}
								break;
							case 5:
								if (current.Side == Side.Buy)
								{
									ALPcr2btPCIfrBpE9leg(P_0, h9iNW4btAtrn8nKAk8dC(base.Theme), new Point(x, num3), 5.0, 5.0);
									r2s9CHMS2Tr.Add(new bcXA9Knu6oJtSapprNob(new Rect(new Point(x - 5.0, num3 - 5.0), new Point(x + 5.0, num3 + 5.0)), current, _0020: true));
									num2 = 4;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f027e87a9f614f4a92c0338386fb11cd != 0)
									{
										num2 = 1;
									}
									continue;
								}
								P_0.FillEllipse(base.Theme.OpenShortPositionBrush, new Point(x, num3), 5.0, 5.0);
								r2s9CHMS2Tr.Add(new bcXA9Knu6oJtSapprNob(new Rect(new Point(x - 5.0, num3 - 5.0), new Point(x + 5.0, num3 + 5.0)), current, _0020: true));
								ALPcr2btPCIfrBpE9leg(P_0, base.Theme.CloseShortPositionBrush, new Point(num4, y), 5.0, 5.0);
								num2 = 3;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b3744d11c0b24c8d993b100cbb22f9e7 == 0)
								{
									num2 = 2;
								}
								continue;
							case 7:
								goto end_IL_057c;
							}
							goto IL_08f9;
							continue;
							end_IL_057c:
							break;
						}
						break;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						N2bQHwbtJ6T1gTxkkIIX(enumerator);
					}
				}
				goto default;
			case 5:
				{
					if (zUfh95btKlKgZqo391um(base.DataProvider) == 0)
					{
						return;
					}
					if (!lbJ9C0b0VnB.ShowDeals)
					{
						num = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_bbcfc7b1c81d4568b6bd3ed19a340f5e == 0)
						{
							num = 0;
						}
						break;
					}
					goto case 3;
				}
				IL_099f:
				if (hAd9C2jgUjO == null)
				{
					hAd9C2jgUjO = new List<NCmusEnucnxgidaxWgeo>();
					num = 5;
					break;
				}
				hAd9C2jgUjO.Clear();
				goto case 5;
			}
		}
	}

	public override void RenderCursor(DxVisualQueue P_0, int P_1, Point P_2, ref int P_3)
	{
		int num = 5;
		int num2 = num;
		double num10 = default(double);
		double num6 = default(double);
		double num11 = default(double);
		List<string> list = default(List<string>);
		double x = default(double);
		double num8 = default(double);
		double num12 = default(double);
		double num9 = default(double);
		double num5 = default(double);
		Rect rect = default(Rect);
		List<Tuple<string, Rect>>.Enumerator enumerator4 = default(List<Tuple<string, Rect>>.Enumerator);
		List<Tuple<string, Rect>> list2 = default(List<Tuple<string, Rect>>);
		bool flag = default(bool);
		string current3 = default(string);
		Rect item = default(Rect);
		List<NCmusEnucnxgidaxWgeo>.Enumerator enumerator = default(List<NCmusEnucnxgidaxWgeo>.Enumerator);
		while (true)
		{
			switch (num2)
			{
			case 2:
				num10 = 0.0;
				num6 = 0.0;
				num2 = 11;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1a625a5fe3334df88082832236dff5be != 0)
				{
					num2 = 5;
				}
				continue;
			case 6:
				num11 = P_2.Y + 15.0;
				num2 = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1b729872d4424497a28393432ab4c541 == 0)
				{
					num2 = 0;
				}
				continue;
			case 8:
				if (list.Count == 0)
				{
					return;
				}
				x = P_2.X + 15.0;
				num2 = 6;
				continue;
			case 1:
				num8 = P_2.X + 10.0;
				num12 = 0.0;
				num2 = 15;
				continue;
			case 15:
				if (num8 + num10 + 10.0 >= base.Canvas.Rect.Right)
				{
					num8 -= num10 + 30.0;
					num12 = 0.0 - (num10 + 30.0);
					num2 = 14;
					continue;
				}
				goto case 14;
			case 14:
				num9 = P_2.Y + 10.0;
				num5 = 0.0;
				if (num9 + num6 + 10.0 >= base.Canvas.Rect.Bottom)
				{
					num9 -= num6 + 30.0;
					num2 = 14;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8692846774e94af58ff2b2b243743e02 == 0)
					{
						num2 = 16;
					}
					continue;
				}
				goto IL_05c4;
			case 12:
				P_0.FillRectangle(base.Theme.ChartBackBrush, rect);
				num2 = 10;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8a9257c2b61741afa02a8ceb1f69ad69 == 0)
				{
					num2 = 3;
				}
				continue;
			case 10:
				P_0.DrawRectangle(base.Theme.ChartAxisPen, rect);
				enumerator4 = list2.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5e7b68e9e95482ab88a9b839c4d448c == 0)
				{
					num2 = 0;
				}
				continue;
			case 5:
				if ((Keyboard.Modifiers & ModifierKeys.Control) != ModifierKeys.None)
				{
					num2 = 4;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d3afdd6ad27a4c3b87071f1be51e7ef3 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				flag = false;
				list = new List<string>();
				num2 = 9;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2264c03640a14c8f930261fd70e85d60 != 0)
				{
					num2 = 9;
				}
				continue;
			case 11:
			{
				list2 = new List<Tuple<string, Rect>>();
				using (List<string>.Enumerator enumerator3 = list.GetEnumerator())
				{
					while (true)
					{
						IL_02f3:
						int num13;
						if (!enumerator3.MoveNext())
						{
							num13 = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fb3e1155cc384cc2a7c812423a76ea76 == 0)
							{
								num13 = 0;
							}
						}
						else
						{
							current3 = enumerator3.Current;
							Size size = base.Settings.ChartFont.GetSize(current3);
							num10 = nkhZRFbUHb2k7Sat25WR(num10, size.Width);
							item = new Rect(x, num11 + num6 + 2.0, num10, size.Height + 2.0);
							num13 = 2;
						}
						while (true)
						{
							switch (num13)
							{
							case 1:
								goto IL_02de;
							case 2:
								num6 += item.Height + 2.0;
								num13 = 0;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7d3c6a8bf09f4ec887f577858231a719 == 0)
								{
									num13 = 1;
								}
								continue;
							case 0:
								break;
							}
							break;
							IL_02de:
							list2.Add(new Tuple<string, Rect>(current3, item));
							goto IL_02f3;
						}
						break;
					}
				}
				goto case 1;
			}
			case 9:
				if (r2s9CHMS2Tr != null && MB760XbU2ErhspJElkXB(r2s9CHMS2Tr) != 0)
				{
					using List<bcXA9Knu6oJtSapprNob>.Enumerator enumerator2 = r2s9CHMS2Tr.GetEnumerator();
					while (true)
					{
						if (!enumerator2.MoveNext())
						{
							int num7 = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7bbe761a662b44b5ba6c0923e11b90ae == 0)
							{
								num7 = 0;
							}
							switch (num7)
							{
							default:
								goto end_IL_0800;
							case 1:
								break;
							case 0:
								goto end_IL_0800;
							}
						}
						bcXA9Knu6oJtSapprNob current2 = enumerator2.Current;
						if (current2.nOtnuMXBQBM(P_2))
						{
							list.AddRange(current2.cLbnuOrhNIn(base.DataProvider));
							flag = true;
						}
						continue;
						end_IL_0800:
						break;
					}
				}
				goto case 7;
			case 16:
				num5 = 0.0 - (num6 + 30.0);
				goto IL_05c4;
			case 3:
				return;
			case 13:
				try
				{
					while (enumerator.MoveNext())
					{
						NCmusEnucnxgidaxWgeo current = enumerator.Current;
						int num4;
						if (!current.puhnuj6p6Rw(P_2))
						{
							int num3 = 2;
							num4 = num3;
							goto IL_063c;
						}
						goto IL_069f;
						IL_0686:
						list.Add(current.WXVnuEayIKO(base.DataProvider));
						continue;
						IL_063c:
						while (true)
						{
							switch (num4)
							{
							case 2:
								break;
							default:
								goto IL_069f;
							case 1:
								list.Add((string)W0Xj2UbttECO5feKGUVN(0x4220DA8 ^ 0x422C892));
								num4 = 3;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8b6bac13ae314900826ed96af7afc27b == 0)
								{
									num4 = 3;
								}
								continue;
							case 3:
								goto IL_0720;
							}
							break;
						}
						continue;
						IL_069f:
						if (flag)
						{
							num4 = 1;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ff2c70a81f2141b98b88fc10875a3726 == 0)
							{
								num4 = 1;
							}
							goto IL_063c;
						}
						goto IL_0686;
						IL_0720:
						flag = false;
						goto IL_0686;
					}
				}
				finally
				{
					((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
				}
				goto case 8;
			case 7:
				if (hAd9C2jgUjO != null && hAd9C2jgUjO.Count != 0)
				{
					enumerator = hAd9C2jgUjO.GetEnumerator();
					num2 = 13;
					continue;
				}
				goto case 8;
			case 4:
				return;
				IL_05c4:
				rect = new Rect(num8, num9, num10 + 10.0, num6 + 10.0);
				num2 = 12;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_34c8a548a4724373aa05c97fa43f690a != 0)
				{
					num2 = 11;
				}
				continue;
			}
			try
			{
				while (enumerator4.MoveNext())
				{
					Tuple<string, Rect> current4 = enumerator4.Current;
					if (current4.Item1 == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x9F0F634 ^ 0x9F0330E))
					{
						Rect item2 = current4.Item2;
						int num14 = 2;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0fb8c8dbf8424ce68f439b7b66291a33 != 0)
						{
							num14 = 2;
						}
						while (true)
						{
							switch (num14)
							{
							case 1:
								break;
							default:
								goto IL_03ed;
							case 2:
								P_0.DrawLine(base.Theme.ChartAxisPen, new Point(rect.X + 4.0, item2.Y + item2.Height / 2.0 + num5), new Point(rect.X + rect.Width - 4.0, item2.Y + item2.Height / 2.0 + num5));
								num14 = 0;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ac6a9a8fc5c94cd6833091a6efebb474 == 0)
								{
									num14 = 1;
								}
								continue;
							}
							break;
						}
						continue;
					}
					goto IL_03ed;
					IL_03ed:
					P_0.DrawString(current4.Item1, base.Settings.ChartFont, (XBrush)Wv4GssbUfKy43vVgibTY(base.Theme), new Rect(current4.Item2.X + num12, current4.Item2.Y + num5, current4.Item2.Width, current4.Item2.Height));
				}
				return;
			}
			finally
			{
				((IDisposable)enumerator4/*cast due to .constrained prefix*/).Dispose();
			}
		}
	}

	public override IndicatorTitleInfo GetTitle()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
			{
				if (base.DataProvider == null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_4aa3a79213674c27a6bc763076b8caed != 0)
					{
						num2 = 0;
					}
					break;
				}
				string text = ((BVldZgbU9WThcriun4YH(base.DataProvider.Symbol) == SymbolType.Crypto) ? stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1763895751 ^ -1764137265) : "");
				return new IndicatorTitleInfo((string)LmUoT6bUnhOHEISfAy3L(base.DataProvider.Symbol) + stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x404ED0BE ^ 0x404E4B8A) + ((SymbolBase)FvaQTLbUGwpDkN52KMRw(base.DataProvider)).Exchange + text + (string)W0Xj2UbttECO5feKGUVN(-1461949456 ^ -1461915444), (XBrush)oIju9BbUolW2LhZPlLg2(dH4930bUYKHTYKqMObB0(base.Canvas)));
			}
			default:
				return base.GetTitle();
			}
		}
	}

	public override List<IndicatorValueInfo> GetValues(int cursorPos)
	{
		List<IndicatorValueInfo> list = new List<IndicatorValueInfo>();
		IRawCluster cluster = base.DataProvider.GetCluster(cursorPos);
		if (cluster == null)
		{
			return list;
		}
		StringBuilder stringBuilder = new StringBuilder();
		if (base.Settings.StockViewType == StockViewType.Candles || base.Settings.StockViewType == StockViewType.Bars || base.Settings.StockViewType == StockViewType.Clusters)
		{
			stringBuilder.Append(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1346994499 ^ -1347285063) + base.DataProvider.Symbol.FormatRawPrice(cluster.Open, _0020: true));
			stringBuilder.Append(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-520155535 ^ -520388737) + base.DataProvider.Symbol.FormatRawPrice(cluster.High, _0020: true));
			stringBuilder.Append(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-448941864 ^ -449199676) + base.DataProvider.Symbol.FormatRawPrice(cluster.Low, _0020: true));
			stringBuilder.Append(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1192989954 ^ -1193272364) + base.DataProvider.Symbol.FormatRawPrice(cluster.Close, _0020: true));
			stringBuilder.Append(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1435596783 ^ -1435829975) + base.DataProvider.Symbol.FormatRawSizeShort(cluster.Volume));
		}
		else
		{
			stringBuilder.Append(base.DataProvider.Symbol.FormatRawPrice(cluster.Close, _0020: true));
			stringBuilder.Append(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--18459671 ^ 0x11DDD51) + base.DataProvider.Symbol.FormatRawSizeShort(cluster.Volume));
		}
		IRawCluster cluster2 = base.DataProvider.GetCluster(cursorPos - 1);
		if (cluster2 != null && cluster2.Close != 0L)
		{
			double num = (double)(cluster.Close - cluster2.Close) / (double)cluster2.Close * 100.0;
			stringBuilder.Append(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x1A5F1B9E ^ 0x1A5B6AC4) + num.ToString(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x11D1040B ^ 0x11D57569)) + stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1416986301 ^ -1416695763));
		}
		list.Add(new IndicatorValueInfo(stringBuilder.ToString(), base.Theme.ChartFontBrush));
		return list;
	}

	public override void GetLabels(ref List<IndicatorLabelInfo> P_0)
	{
		if (base.DataProvider.Count <= base.Canvas.Start)
		{
			return;
		}
		IRawCluster cluster = base.DataProvider.GetCluster(base.DataProvider.Count - 1 - T8cBanbUv9XteB2vIH3X(base.Canvas));
		int num = 7;
		int num2 = num;
		double value = default(double);
		Color color = default(Color);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 6:
				return;
			case 2:
			case 8:
			case 11:
				P_0.Add(new IndicatorLabelInfo(value, color));
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0aea3f4dc28f4bcb92a1f998dc5afbed == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 5:
				P_0.Add(new IndicatorLabelInfo(value, PriceLineColor));
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_495802897f05476f875528905eba9a89 != 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				goto IL_0160;
			case 9:
				goto IL_0171;
			case 3:
				goto IL_01c6;
			case 10:
				switch (base.Settings.StockViewType)
				{
				case StockViewType.Bars:
					break;
				case StockViewType.Line:
					goto IL_0114;
				case StockViewType.Clusters:
					goto IL_0160;
				case StockViewType.Candles:
					goto IL_0171;
				case StockViewType.Area:
					goto IL_01c6;
				default:
					goto IL_0234;
				}
				color = (cluster.IsUp ? base.Theme.BarUpBarColor : base.Theme.BarDownBarColor);
				goto case 2;
			case 7:
				if (cluster == null)
				{
					return;
				}
				value = (double)qpXFaFbUBjM5dq5Ao8au(cluster) * base.DataProvider.Step;
				if (!PriceLineCustomColor)
				{
					color = HKZtTSbUaGJHdlvPVykH();
					num2 = 10;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dfd8fb340d494755970617a38d3a8729 == 0)
					{
						num2 = 2;
					}
				}
				else
				{
					num2 = 5;
				}
				break;
			case 1:
				return;
				IL_01c6:
				color = E6FErEbUipyGskHG7I54(J6UyJZbUlBq1VSuF3siK(base.Theme));
				goto case 2;
				IL_0171:
				color = (cluster.IsUp ? base.Theme.CandleUpBackColor : base.Theme.CandleDownBackColor);
				num2 = 2;
				break;
				IL_0234:
				num2 = 11;
				break;
				IL_0114:
				color = E6FErEbUipyGskHG7I54(base.Theme.LineColor);
				num2 = 4;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b3744d11c0b24c8d993b100cbb22f9e7 != 0)
				{
					num2 = 8;
				}
				break;
				IL_0160:
				color = (cluster.IsUp ? base.Theme.ClusterUpBarColor : dGhYudbU4y7ay4gmmrxD(base.Theme));
				goto case 2;
			}
		}
	}

	public override void OnSetSymbol()
	{
		G4N9Cf1ayhi = -1;
		Ssq9C99Xnpu = 0.0;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8b8f48487ce54157a86b0385feea16a6 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		iMI9CnJTSjk = 0.0;
	}

	public override void StartNextCheckAlertRound()
	{
		int num = 1;
		int num2 = num;
		IRawCluster rawCluster = default(IRawCluster);
		while (true)
		{
			switch (num2)
			{
			case 1:
				G4N9Cf1ayhi = base.DataProvider.Count - 1;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_495802897f05476f875528905eba9a89 != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				Ssq9C99Xnpu = (double)rawCluster.Close * UhtjVEbtZxO5x0nNH1Dx(base.DataProvider);
				return;
			}
			rawCluster = (IRawCluster)PpxyT5btUV5G1CSW8BO1(base.DataProvider, G4N9Cf1ayhi);
			if (rawCluster == null)
			{
				return;
			}
			iMI9CnJTSjk = Ssq9C99Xnpu;
			num2 = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9d6f131f80d34ede83451138b928a86f == 0)
			{
				num2 = 2;
			}
		}
	}

	public override bool CheckAlert(double P_0, int P_1, ref int P_2, ref double P_3)
	{
		if (G4N9Cf1ayhi < 0 || iMI9CnJTSjk == 0.0 || Ssq9C99Xnpu == 0.0)
		{
			return false;
		}
		int num;
		if (G4N9Cf1ayhi == P_2)
		{
			num = 3;
			goto IL_0009;
		}
		goto IL_00f1;
		IL_0009:
		while (true)
		{
			switch (num)
			{
			case 1:
				break;
			case 3:
				goto IL_005a;
			default:
				goto IL_007d;
			case 2:
				return false;
			}
			break;
			IL_007d:
			if (P_0 <= Ssq9C99Xnpu)
			{
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_34759ce292e54c39852852efd3a55773 != 0)
				{
					num = 1;
				}
				continue;
			}
			goto IL_00a5;
			IL_005a:
			if (P_0 == P_3)
			{
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0fb8c8dbf8424ce68f439b7b66291a33 != 0)
				{
					num = 2;
				}
				continue;
			}
			goto IL_00f1;
		}
		goto IL_003c;
		IL_00a5:
		return false;
		IL_00f1:
		if (P_0 >= Ssq9C99Xnpu && P_0 <= iMI9CnJTSjk)
		{
			goto IL_003c;
		}
		if (P_0 >= iMI9CnJTSjk)
		{
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6b48af76ce0b4c779ac34c27953eddda == 0)
			{
				num = 0;
			}
			goto IL_0009;
		}
		goto IL_00a5;
		IL_003c:
		P_2 = G4N9Cf1ayhi;
		P_3 = P_0;
		return true;
	}

	public override bool GetPropertyVisibility(string P_0)
	{
		if (P_0 == (string)W0Xj2UbttECO5feKGUVN(0x1A5F1B9E ^ 0x1A5B6BC4))
		{
			return PriceLineCustomColor;
		}
		return true;
	}

	public override void ApplyColors(IChartTheme P_0)
	{
		PriceLineColor = P_0.GetNextColor();
		base.ApplyColors(P_0);
	}

	public override void CopyTemplate(IndicatorBase P_0, bool P_1)
	{
		int num = 3;
		int num2 = num;
		qEcb3w9VvrqaZ6RgPZhq qEcb3w9VvrqaZ6RgPZhq2 = default(qEcb3w9VvrqaZ6RgPZhq);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				PriceLinePosition = qEcb3w9VvrqaZ6RgPZhq2.PriceLinePosition;
				PriceLineCustomColor = Le64BgbUDaF5HLuVkpu6(qEcb3w9VvrqaZ6RgPZhq2);
				PriceLineColor = UBTByrbUbt0dv93wmXDQ(qEcb3w9VvrqaZ6RgPZhq2);
				PriceLineWidth = kpMx3RbUNxlZww5qlrLj(qEcb3w9VvrqaZ6RgPZhq2);
				PriceLineStyle = qEcb3w9VvrqaZ6RgPZhq2.PriceLineStyle;
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a057f43d61f46eca6f419bc48c31d04 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				BarType = qEcb3w9VvrqaZ6RgPZhq2.BarType;
				BarWidth = esdOSYbUkRLT7MvZBNVu(qEcb3w9VvrqaZ6RgPZhq2);
				PriceType = vEI6dRbU1Xto4DvGlVBc(qEcb3w9VvrqaZ6RgPZhq2);
				LineWidth = qEcb3w9VvrqaZ6RgPZhq2.LineWidth;
				num2 = 4;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_281cd373231b4974955fe570959430ac != 0)
				{
					num2 = 4;
				}
				break;
			case 3:
				qEcb3w9VvrqaZ6RgPZhq2 = (qEcb3w9VvrqaZ6RgPZhq)P_0;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8bfdb836a7624a05a8616bddcf22e146 == 0)
				{
					num2 = 2;
				}
				break;
			case 0:
				return;
			case 4:
				base.CopyTemplate(P_0, P_1);
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_43d123ebfe574af38268397bb0ae2d1a != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void oCG9Vi9rWKH(DxVisualQueue P_0, double P_1, Rect P_2)
	{
		int num = 47;
		XPen xPen2 = default(XPen);
		double x2 = default(double);
		double num11 = default(double);
		double num12 = default(double);
		int num22 = default(int);
		List<Point> list = default(List<Point>);
		StockViewType stockViewType = default(StockViewType);
		Rect rect = default(Rect);
		Rect rect2 = default(Rect);
		int num17 = default(int);
		int index2 = default(int);
		IRawCluster cluster3 = default(IRawCluster);
		int num19 = default(int);
		IRawCluster cluster2 = default(IRawCluster);
		IndicatorPriceType indicatorPriceType = default(IndicatorPriceType);
		List<IContainsConditions>.Enumerator enumerator = default(List<IContainsConditions>.Enumerator);
		XBrush xBrush2 = default(XBrush);
		bool isUp = default(bool);
		XPen xPen = default(XPen);
		XBrush brush3 = default(XBrush);
		double num21 = default(double);
		int num23 = default(int);
		int num15 = default(int);
		int num16 = default(int);
		XBrush brush2 = default(XBrush);
		int num8 = default(int);
		double x = default(double);
		double num14 = default(double);
		double y3 = default(double);
		int num10 = default(int);
		double num4 = default(double);
		IRawCluster cluster = default(IRawCluster);
		double num7 = default(double);
		double num5 = default(double);
		double y = default(double);
		List<IContainsConditions> list2 = default(List<IContainsConditions>);
		Point[] array = default(Point[]);
		double y2 = default(double);
		double num13 = default(double);
		int num6 = default(int);
		double num9 = default(double);
		long num18 = default(long);
		int index = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				XBrush xBrush;
				switch (num2)
				{
				case 5:
					tGbENrbUETc0FW9rtJta(P_0, xPen2, new Point(x2, num11), new Point(x2, num12));
					num2 = 10;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d4c083a65c1546b8a09c928a8c95e140 == 0)
					{
						num2 = 2;
					}
					continue;
				case 7:
					if (num22 >= base.Canvas.Count)
					{
						num2 = 4;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03df70ea72bf4e3e81ab05550292a7c9 == 0)
						{
							num2 = 15;
						}
						continue;
					}
					goto case 50;
				case 3:
					if (P_1 > 3.0)
					{
						num = 40;
						break;
					}
					goto case 14;
				case 35:
					list = new List<Point>();
					num22 = 0;
					goto case 7;
				case 15:
					if (list.Count == 0)
					{
						num2 = 8;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2e936b892f094d0a971af950fe8f46f7 != 0)
						{
							num2 = 4;
						}
						continue;
					}
					if (stockViewType == StockViewType.Line)
					{
						num2 = 51;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_390fe499a2cc4a5ca3d6279a99e6b610 == 0)
						{
							num2 = 7;
						}
						continue;
					}
					goto default;
				case 56:
					rect = rect2;
					num2 = 39;
					continue;
				case 34:
					if (P_1 > 3.0 && BarType == PriceBarType.OHLC)
					{
						num2 = 41;
						continue;
					}
					goto case 3;
				case 30:
					if (num17 >= ((IChartCanvas)q3DvdcbtVtoCkNGgtXcR(this)).Count)
					{
						num = 29;
						break;
					}
					index2 = ((IChartCanvas)q3DvdcbtVtoCkNGgtXcR(this)).GetIndex(num17);
					cluster3 = base.DataProvider.GetCluster(index2);
					num2 = 6;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2fa91f76013747d9b5f0073a2a323201 == 0)
					{
						num2 = 9;
					}
					continue;
				case 50:
					num19 = eCgEWJbU5BVLFDmxw0Uo(q3DvdcbtVtoCkNGgtXcR(this), num22);
					cluster2 = base.DataProvider.GetCluster(num19);
					if (cluster2 != null)
					{
						indicatorPriceType = PriceType;
						num2 = 13;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a057f43d61f46eca6f419bc48c31d04 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 27;
				case 2:
					try
					{
						while (true)
						{
							IL_02d7:
							int num25;
							if (!enumerator.MoveNext())
							{
								num25 = 0;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_281cd373231b4974955fe570959430ac != 0)
								{
									num25 = 0;
								}
							}
							else
							{
								xBrush2 = (XBrush)ApZhqmbUdMtl8t2GdXNC(enumerator.Current, index2, isUp);
								num25 = 0;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c16c36b6197f4f30be0a8035f04288b3 == 0)
								{
									num25 = 2;
								}
							}
							while (true)
							{
								switch (num25)
								{
								default:
									goto end_IL_02c1;
								case 1:
									break;
								case 2:
									if (xBrush2 != null)
									{
										xPen = new XPen(xBrush2, 1);
										xPen2 = xPen;
										brush3 = xBrush2;
										num25 = 1;
										if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_43d123ebfe574af38268397bb0ae2d1a == 0)
										{
											num25 = 0;
										}
										continue;
									}
									break;
								case 0:
									goto end_IL_02c1;
								}
								goto IL_02d7;
								continue;
								end_IL_02c1:
								break;
							}
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
					}
					goto case 49;
				case 28:
					if (list.Count > 0)
					{
						num2 = 44;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1bb232d361564d93b9a5d5e53983bdb3 != 0)
						{
							num2 = 9;
						}
						continue;
					}
					goto IL_0b9f;
				case 19:
					xBrush = base.Theme.CandleDownBackBrush;
					goto IL_0f39;
				case 8:
					return;
				case 26:
					if (P_1 > 1.0)
					{
						if (num21 != 0.0)
						{
							if (num23 > 1)
							{
								rect2 = new Rect(x2 - (double)num15, num11, num15 * 2, num21);
								num2 = 56;
							}
							else
							{
								num2 = 5;
							}
							continue;
						}
						if (num23 > 1)
						{
							P_0.DrawLine(xPen2, new Point(x2 - (double)num15, num11), new Point(x2 + (double)num15 + 1.0, num11));
						}
					}
					goto case 10;
				case 37:
					num23 = num16;
					num2 = 21;
					continue;
				case 1:
					if (P_1 < 3.0)
					{
						num16 = (int)P_1;
						num2 = 37;
						continue;
					}
					goto case 37;
				case 17:
					xPen2 = (isUp ? base.Theme.CandleUpBorderPen : base.Theme.CandleDownBorderPen);
					num2 = 9;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_45006ec5334a406896281e648c9b6ca0 != 0)
					{
						num2 = 42;
					}
					continue;
				case 41:
					tGbENrbUETc0FW9rtJta(P_0, new XPen(brush2, num8), new Point(x - num14, y3), new Point(x - (double)num10 / 2.0, y3));
					num2 = 3;
					continue;
				case 40:
					if (BarType != PriceBarType.OHLC)
					{
						if (BarType == PriceBarType.HLC)
						{
							num2 = 4;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5350e02b39f542f78529ac5e3c3f8ec6 == 0)
							{
								num2 = 3;
							}
							continue;
						}
						goto case 14;
					}
					goto case 4;
				case 10:
				case 43:
					num17++;
					num2 = 30;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8b6bac13ae314900826ed96af7afc27b == 0)
					{
						num2 = 6;
					}
					continue;
				case 18:
				case 25:
					rgA9VlfGCXE(P_0, P_2, P_1);
					num2 = 11;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_57c2433b06714a1299d736aebe42caa2 != 0)
					{
						num2 = 10;
					}
					continue;
				case 29:
					return;
				case 31:
					num4 = SXlNTDbtwj0C56ClRwuK(this, (double)cluster.High * num7);
					num5 = GetY((double)cluster.Low * num7);
					y = GetY((double)cluster.Close * num7);
					num2 = 36;
					continue;
				case 39:
					rect.Width++;
					P_0.FillRectangle(brush3, rect);
					edtk2gbUgfliJIh880MA(P_0, xPen2, rect2);
					num2 = 43;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1db4437ae4614880b2ad46efdc78cb73 == 0)
					{
						num2 = 15;
					}
					continue;
				case 36:
					brush2 = (cluster.IsUp ? base.Theme.BarUpBarBrush : base.Theme.BarDownBarBrush);
					enumerator = list2.GetEnumerator();
					num2 = 52;
					continue;
				case 12:
				{
					IEnumerator<IndicatorBase> enumerator2 = ((hOOnlr9I6ptNbuV3ApFP)LI6FeYbUsZQs8595WFrb(cpI9r4xqdTB())).GetEnumerator();
					try
					{
						while (OXUDM2bUXGPBBjK2Zx8v(enumerator2))
						{
							while (true)
							{
								IL_0e27:
								IndicatorBase current = enumerator2.Current;
								int num24 = 0;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7070f82fb97740909616ccb4e69409c5 != 0)
								{
									num24 = 0;
								}
								while (true)
								{
									switch (num24)
									{
									case 2:
										break;
									default:
										if (!current.ShowIndicator || !(current is IContainsConditions item))
										{
											break;
										}
										list2.Add(item);
										num24 = 2;
										continue;
									case 1:
										goto IL_0e27;
									}
									break;
								}
								break;
							}
						}
					}
					finally
					{
						if (enumerator2 != null)
						{
							N2bQHwbtJ6T1gTxkkIIX(enumerator2);
						}
					}
					rgA9VlfGCXE(P_0, P_2, P_1);
					if (stockViewType == StockViewType.Bars)
					{
						num8 = BarWidth;
						if (num8 == 0)
						{
							num8 = Math.Max(1, (int)(P_1 * 0.3));
						}
						num10 = (int)(P_1 * 0.8);
						if (P_1 < (double)(3 + num8))
						{
							num2 = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_35216e71f4e34e739f4a05a1213f3579 == 0)
							{
								num2 = 48;
							}
							continue;
						}
						goto case 6;
					}
					num16 = (int)(P_1 * base.Canvas.ColumnPercent + 0.4);
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_68b6172210394c1b93f49e43376ff3af != 0)
					{
						num2 = 0;
					}
					continue;
				}
				case 45:
					if (stockViewType == StockViewType.Area)
					{
						num = 35;
						break;
					}
					list2 = new List<IContainsConditions>();
					num2 = 6;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8a9257c2b61741afa02a8ceb1f69ad69 != 0)
					{
						num2 = 12;
					}
					continue;
				case 51:
					P_0.DrawLines(new XPen((XBrush)nCpDJKbUxFC88PEpvOFw(base.Theme), LineWidth), list.ToArray());
					num2 = 18;
					continue;
				case 42:
					if (!isUp)
					{
						num2 = 19;
						continue;
					}
					xBrush = base.Theme.CandleUpBackBrush;
					goto IL_0f39;
				case 55:
					list.Add(new Point(array[0].X, P_2.Bottom));
					P_0.FillPolygon(base.Theme.AreaBrush, (Point[])LOA5mIbULxODic3T7PgW(list));
					goto IL_0b9f;
				case 44:
					list.Add(new Point(array[array.Length - 1].X, P_2.Bottom));
					num2 = 55;
					continue;
				case 54:
					tGbENrbUETc0FW9rtJta(P_0, xPen, new Point(x2, y2), new Point(x2, num13));
					goto case 26;
				case 14:
					num6++;
					goto IL_0481;
				case 4:
					P_0.DrawLine(new XPen(brush2, num8), new Point(x + num9, y), new Point(x + (double)num10 / 2.0, y));
					goto case 14;
				case 16:
					num4 -= 1.0;
					num5 += 1.0;
					goto IL_04b0;
				case 9:
					if (cluster3 != null)
					{
						isUp = cluster3.IsUp;
						x2 = GetX(index2);
						double num20 = SXlNTDbtwj0C56ClRwuK(this, (double)KtCqd9bUjcSd6nOk1CTk(cluster3) * num7);
						y2 = GetY((double)cluster3.High * num7);
						num13 = SXlNTDbtwj0C56ClRwuK(this, (double)cluster3.Low * num7);
						double y4 = GetY((double)qpXFaFbUBjM5dq5Ao8au(cluster3) * num7);
						num11 = y0E4BubtuMiIJBYLpVJt(num20, y4);
						num12 = Math.Max(num20, y4);
						num21 = num12 - num11;
						xPen = (isUp ? base.Theme.CandleUpWickPen : base.Theme.CandleDownWickPen);
						num2 = 17;
						continue;
					}
					goto case 10;
				case 49:
					if (num21 != 0.0)
					{
						num2 = 24;
						continue;
					}
					goto IL_0577;
				case 27:
					num22++;
					num2 = 7;
					continue;
				case 23:
					num14 = Math.Floor((double)num8 / 2.0);
					num6 = 0;
					goto IL_0481;
				case 33:
					list.Add(new Point(GetX(num19), GetY((double)num18 * num7)));
					num2 = 27;
					continue;
				case 22:
				case 53:
					num18 = cluster2.Close;
					goto case 33;
				case 13:
					switch (indicatorPriceType)
					{
					case IndicatorPriceType.Low:
						num18 = cluster2.Low;
						break;
					case IndicatorPriceType.High:
						num18 = iAHnNgbUS9p4IeuN1jb7(cluster2);
						break;
					case IndicatorPriceType.Open:
						num18 = cluster2.Open;
						num2 = 33;
						continue;
					default:
						num2 = 53;
						continue;
					}
					goto case 33;
				case 21:
					num15 = Math.Max((int)((double)num16 / 2.0), 1);
					num17 = 0;
					goto case 30;
				case 20:
					y3 = SXlNTDbtwj0C56ClRwuK(this, (double)KtCqd9bUjcSd6nOk1CTk(cluster) * num7);
					num2 = 31;
					continue;
				case 48:
					num10 = (int)P_1;
					num2 = 6;
					continue;
				case 32:
					index = ((IChartCanvas)q3DvdcbtVtoCkNGgtXcR(this)).GetIndex(num6);
					cluster = base.DataProvider.GetCluster(index);
					if (cluster != null)
					{
						x = GetX(index);
						num2 = 5;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f68538a410dc40459f303c1bac7938ac != 0)
						{
							num2 = 20;
						}
					}
					else
					{
						num2 = 14;
					}
					continue;
				default:
					array = list.ToArray();
					num2 = 28;
					continue;
				case 24:
					if (!(P_1 <= 1.0))
					{
						tGbENrbUETc0FW9rtJta(P_0, xPen, new Point(x2, y2), new Point(x2, num11));
						tGbENrbUETc0FW9rtJta(P_0, xPen, new Point(x2, num12), new Point(x2, num13));
						num2 = 26;
						continue;
					}
					goto IL_0577;
				case 38:
					return;
				case 47:
					stockViewType = base.Settings.StockViewType;
					num2 = 46;
					continue;
				case 46:
					num7 = UhtjVEbtZxO5x0nNH1Dx(base.DataProvider);
					if (stockViewType != StockViewType.Line)
					{
						num2 = 45;
						continue;
					}
					goto case 35;
				case 52:
					try
					{
						while (enumerator.MoveNext())
						{
							while (true)
							{
								XBrush brush = enumerator.Current.GetBrush(index, cluster.IsUp);
								if (brush != null)
								{
									brush2 = brush;
									int num3 = 1;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_51aff79eb7764aeaade80ae2d6638ab5 == 0)
									{
										num3 = 1;
									}
									switch (num3)
									{
									default:
										continue;
									case 1:
										break;
									}
								}
								break;
							}
						}
					}
					finally
					{
						((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
					}
					if ((int)num4 == (int)num5)
					{
						num2 = 7;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0aea3f4dc28f4bcb92a1f998dc5afbed == 0)
						{
							num2 = 16;
						}
						continue;
					}
					goto IL_04b0;
				case 11:
					return;
				case 6:
					{
						num9 = btZ8PabUcEDfERMivXg6((double)num8 / 2.0);
						num2 = 23;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_213ef2c0a30c421096ba2b26b8d94124 == 0)
						{
							num2 = 20;
						}
						continue;
					}
					IL_0481:
					if (num6 >= mGPMIbbUQpWmpa1cg6V3(base.Canvas))
					{
						num2 = 38;
						continue;
					}
					goto case 32;
					IL_04b0:
					tGbENrbUETc0FW9rtJta(P_0, new XPen(brush2, num8), new Point(x, num4 - num14), new Point(x, num5 + num9));
					num2 = 34;
					continue;
					IL_0f39:
					brush3 = xBrush;
					enumerator = list2.GetEnumerator();
					num2 = 2;
					continue;
					IL_0b9f:
					yPK6ClbUeLWlSB3gB2hj(P_0, new XPen(base.Theme.AreaLineBrush, LineWidth), array);
					num2 = 25;
					continue;
					IL_0577:
					if (y2 != num13)
					{
						num2 = 54;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_409738fae61f4f058345c98b7cfbcbac == 0)
						{
							num2 = 41;
						}
						continue;
					}
					P_0.DrawLine(xPen2, new Point(x2, y2), new Point(x2, y2 - 1.0));
					goto case 26;
				}
				break;
			}
		}
	}

	private void rgA9VlfGCXE(DxVisualQueue P_0, Rect P_1, double P_2)
	{
		if (PriceLinePosition == PriceLinePosition.Hide)
		{
			return;
		}
		IRawCluster rawCluster = (IRawCluster)PpxyT5btUV5G1CSW8BO1(base.DataProvider, base.DataProvider.Count - 1);
		int num = 4;
		XPen xPen = default(XPen);
		double num2 = default(double);
		double y = default(double);
		XBrush brush = default(XBrush);
		long close = default(long);
		while (true)
		{
			object obj;
			switch (num)
			{
			case 3:
				tGbENrbUETc0FW9rtJta(P_0, xPen, new Point(num2 + P_2 / 2.0 + 2.0, y), new Point(P_1.Right, y));
				return;
			case 11:
				return;
			case 5:
				brush = base.Theme.LineBrush;
				num = 2;
				break;
			case 6:
				obj = JIkQgTbUR2pLNtGndgWC(base.Theme);
				goto IL_032f;
			case 8:
				brush = (XBrush)GYxTgrbU6GhOcRYyuBW4(base.Theme);
				goto case 2;
			case 2:
				xPen = (PriceLineCustomColor ? KVT9V6GgOrj : new XPen(brush, PriceLineWidth, PriceLineStyle));
				switch (PriceLinePosition)
				{
				default:
					num = 9;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_43d123ebfe574af38268397bb0ae2d1a == 0)
					{
						num = 5;
					}
					break;
				case PriceLinePosition.Full:
					P_0.DrawLine(xPen, new Point(P_1.Left, y), new Point(P_1.Right, y));
					num = 11;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2aa1113717a74eb69caa8952fdc78508 != 0)
					{
						num = 11;
					}
					break;
				case PriceLinePosition.Left:
					tGbENrbUETc0FW9rtJta(P_0, xPen, new Point(num2 - P_2 / 2.0 - 2.0, y), new Point(P_1.Left, y));
					num = 7;
					break;
				case PriceLinePosition.Right:
					if (base.Canvas.AfterBars <= 0)
					{
						return;
					}
					num = 2;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f6b8a9ae320a40f994b0db08d42c2a95 == 0)
					{
						num = 3;
					}
					break;
				}
				break;
			case 10:
				num2 = IceOX4bt7SQJDh4njAZR(this, zUfh95btKlKgZqo391um(base.DataProvider) - 1);
				y = GetY((double)close * UhtjVEbtZxO5x0nNH1Dx(base.DataProvider));
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_426282f87bb443dbbfe9ea3327b81bb7 == 0)
				{
					num = 0;
				}
				break;
			case 4:
				if (rawCluster == null)
				{
					return;
				}
				close = rawCluster.Close;
				num = 10;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_51aff79eb7764aeaade80ae2d6638ab5 != 0)
				{
					num = 5;
				}
				break;
			case 7:
				return;
			case 1:
				num2 = P_1.Right;
				goto IL_00b4;
			default:
				if (num2 > P_1.Right)
				{
					num = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e38cca27b4f843e0acda58c2d2606b17 == 0)
					{
						num = 1;
					}
					break;
				}
				goto IL_00b4;
			case 9:
				return;
				IL_00b4:
				if (!rawCluster.IsUp)
				{
					goto case 6;
				}
				obj = base.Theme.BarUpBarBrush;
				goto IL_032f;
				IL_032f:
				brush = (XBrush)obj;
				if (cu18skbtCbtdIi1HguWH(base.Settings) != StockViewType.Area)
				{
					if (base.Settings.StockViewType == StockViewType.Line)
					{
						int num3 = 5;
						num = num3;
						break;
					}
					goto case 2;
				}
				num = 8;
				break;
			}
		}
	}

	private void nQ89V4ipZqx(DxVisualQueue P_0, double P_1, Rect P_2)
	{
		int num = 13;
		me021enuViEjoFdJlZYV me021enuViEjoFdJlZYV = default(me021enuViEjoFdJlZYV);
		long xSTnuziHlxS = default(long);
		long qfInz2KpKYU = default(long);
		long kbWnzHuOgBw = default(long);
		long t9JnzfkRxZO = default(long);
		long n5Rnz130BFd = default(long);
		int num8 = default(int);
		bool flag2 = default(bool);
		int? num10 = default(int?);
		bool flag = default(bool);
		IRawClusterMaxValues maxValues = default(IRawClusterMaxValues);
		IRawCluster rawCluster = default(IRawCluster);
		double num12 = default(double);
		double num6 = default(double);
		double num7 = default(double);
		int num5 = default(int);
		bool flag3 = default(bool);
		List<D8gyZXnz5m1y5iiw1dIF> list = default(List<D8gyZXnz5m1y5iiw1dIF>);
		D8gyZXnz5m1y5iiw1dIF d8gyZXnz5m1y5iiw1dIF = default(D8gyZXnz5m1y5iiw1dIF);
		double step = default(double);
		long cernz0EgckQ = default(long);
		int num3 = default(int);
		List<IContainsSelection> list3 = default(List<IContainsSelection>);
		int num4 = default(int);
		List<IContainsConditions> list2 = default(List<IContainsConditions>);
		IContainsConditions containsConditions = default(IContainsConditions);
		int val = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num15;
				double v3TnumakUEq;
				switch (num2)
				{
				case 22:
					me021enuViEjoFdJlZYV.psbnzBHbgaI = evr9VzPFX3p.BackMinValue2;
					me021enuViEjoFdJlZYV.Gapnza9HpFZ = seKn9SbUydsBTGYyg9wE(evr9VzPFX3p) * n6xViEbUTvM9JsE6rGuP(base.DataProvider.Symbol);
					me021enuViEjoFdJlZYV.l89nzi9PskI = evr9VzPFX3p.BackMinValue2 * base.DataProvider.Symbol.NOvnY43A4X4();
					me021enuViEjoFdJlZYV.GvknzlD2kYR = evr9VzPFX3p.BackMinValue2;
					num2 = 45;
					continue;
				case 47:
					me021enuViEjoFdJlZYV.XSTnuziHlxS = xSTnuziHlxS;
					num2 = 43;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7d3c6a8bf09f4ec887f577858231a719 != 0)
					{
						num2 = 20;
					}
					continue;
				case 1:
					me021enuViEjoFdJlZYV.QfInz2KpKYU = qfInz2KpKYU;
					me021enuViEjoFdJlZYV.kbWnzHuOgBw = kbWnzHuOgBw;
					me021enuViEjoFdJlZYV.T9JnzfkRxZO = t9JnzfkRxZO;
					num2 = 29;
					continue;
				case 44:
					me021enuViEjoFdJlZYV.n5Rnz130BFd = n5Rnz130BFd;
					rgA9VlfGCXE(P_0, P_2, P_1);
					num8 = 0;
					goto IL_0c4b;
				case 10:
					me021enuViEjoFdJlZYV.q7Dnu3Ck9ZT = flag2;
					if (flag2)
					{
						num10 = evr9VzPFX3p.FontSize;
						if (!num10.HasValue)
						{
							goto default;
						}
						num10 = evr9VzPFX3p.FontSize;
						num2 = 11;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_52f1b40ebe094208bc85ded04f1baa0b == 0)
						{
							num2 = 10;
						}
						continue;
					}
					goto IL_0ed3;
				case 30:
					me021enuViEjoFdJlZYV.s67nz9oCZGJ = evr9VzPFX3p.BackMinValue * n6xViEbUTvM9JsE6rGuP(base.DataProvider.Symbol);
					me021enuViEjoFdJlZYV.hHqnznKqJax = evr9VzPFX3p.BackMinValue;
					me021enuViEjoFdJlZYV.aKjnzGRd91Z = evr9VzPFX3p.BackMinValue * base.DataProvider.Symbol.NOvnY43A4X4();
					num = 34;
					break;
				case 7:
					me021enuViEjoFdJlZYV.Jf1nurJhVRO = flag;
					if (evr9VzPFX3p.ProportionType != ClusterProportionType.CurrentBar)
					{
						goto case 41;
					}
					maxValues = rawCluster.MaxValues;
					num2 = 15;
					continue;
				case 23:
					AsD9VbNH0VZ(P_0, rawCluster, me021enuViEjoFdJlZYV);
					num2 = 12;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1bb232d361564d93b9a5d5e53983bdb3 == 0)
					{
						num2 = 48;
					}
					continue;
				case 41:
					num12 = base.Canvas.MinY - base.DataProvider.Step;
					num = 2;
					break;
				default:
					num6 = num7 + (double)num5 - 2.0;
					num2 = 8;
					continue;
				case 21:
					if (yxtofMbUOtpuxhFA0xTn(evr9VzPFX3p))
					{
						num2 = 35;
						continue;
					}
					goto IL_0e3b;
				case 15:
					me021enuViEjoFdJlZYV.XSTnuziHlxS = maxValues.MaxVolume;
					me021enuViEjoFdJlZYV.Cernz0EgckQ = VWJFNFbUCdjatxwMQgnS(maxValues);
					num2 = 33;
					continue;
				case 2:
					flag3 = (sJSWqVbUKrGoMcTNEr62(base.Canvas) + base.DataProvider.Step - num12) / base.DataProvider.Step <= 20000.0;
					num = 32;
					break;
				case 16:
				{
					using (List<qgZ6Li9QFC3a8WBFqHZ4>.Enumerator enumerator = evr9VzPFX3p.ValueFilters.GetEnumerator())
					{
						while (true)
						{
							int num9;
							if (!enumerator.MoveNext())
							{
								num9 = 2;
								goto IL_0147;
							}
							goto IL_01b8;
							IL_0147:
							switch (num9)
							{
							case 1:
								goto IL_01b8;
							case 2:
								goto end_IL_0183;
							}
							list.Add(d8gyZXnz5m1y5iiw1dIF);
							continue;
							IL_01b8:
							qgZ6Li9QFC3a8WBFqHZ4 current = enumerator.Current;
							if (current.FilterType == ClusterFilterType.None)
							{
								continue;
							}
							d8gyZXnz5m1y5iiw1dIF = new D8gyZXnz5m1y5iiw1dIF(current);
							if (!d8gyZXnz5m1y5iiw1dIF.NjInzsEaa8e)
							{
								continue;
							}
							num9 = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_84569ba2345a4be7ac2af6ab5d67eaf9 != 0)
							{
								num9 = 0;
							}
							goto IL_0147;
							continue;
							end_IL_0183:
							break;
						}
					}
					goto case 28;
				}
				case 8:
					if (num6 > 8.0)
					{
						num2 = 50;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f3775e6a3cb04c0998106e46ff04d8ab == 0)
						{
							num2 = 38;
						}
						continue;
					}
					goto case 6;
				case 42:
				{
					double num14 = GetY(0.0) - SXlNTDbtwj0C56ClRwuK(this, step);
					num7 = Math.Max(num14, 1.0);
					me021enuViEjoFdJlZYV.o1LnuJLdjKL = num14;
					if (PhJyWFbUIBnAHq8yvVFk(evr9VzPFX3p) != ChartCellViewType.Bars)
					{
						if (PhJyWFbUIBnAHq8yvVFk(evr9VzPFX3p) == ChartCellViewType.BorderedBars)
						{
							num2 = 24;
							continue;
						}
						goto IL_04cd;
					}
					goto case 24;
				}
				case 32:
					switch (evr9VzPFX3p.ClusterPreset)
					{
					default:
						num2 = 49;
						continue;
					case ClusterViewPreset.Volume:
					case ClusterViewPreset.VolumeProfile:
					case ClusterViewPreset.VolumeHistogram:
					case ClusterViewPreset.VolumeDeltaColored:
					case ClusterViewPreset.VolumeProfileDeltaColored:
					case ClusterViewPreset.Trades:
					case ClusterViewPreset.TradesProfile:
					case ClusterViewPreset.TradesHistogram:
					case ClusterViewPreset.TradesDeltaColored:
					case ClusterViewPreset.TradesProfileDeltaColored:
					case ClusterViewPreset.Delta:
					case ClusterViewPreset.DeltaProfile:
					case ClusterViewPreset.DeltaHistogram:
					case ClusterViewPreset.OpenPos:
					case ClusterViewPreset.OpenPosProfile:
					case ClusterViewPreset.OpenPosHistogram:
						if (flag3)
						{
							num2 = 26;
							continue;
						}
						break;
					case ClusterViewPreset.VolumeTrade:
					case ClusterViewPreset.VolumeTradeProfile:
					case ClusterViewPreset.VolumeTradeHistogram:
					case ClusterViewPreset.VolumeDelta:
					case ClusterViewPreset.VolumeDeltaProfile:
					case ClusterViewPreset.VolumeDeltaHistogram:
					case ClusterViewPreset.BidAsk:
					case ClusterViewPreset.BidAskLadder:
					case ClusterViewPreset.BidAskProfile:
					case ClusterViewPreset.BidAskHistogram:
					case ClusterViewPreset.BidAskVolumeProfile:
					case ClusterViewPreset.BidAskDeltaProfile:
					case ClusterViewPreset.BidAskImbalance:
						if (flag3)
						{
							num2 = 23;
							continue;
						}
						break;
					}
					goto case 48;
				case 43:
					me021enuViEjoFdJlZYV.Cernz0EgckQ = cernz0EgckQ;
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_495802897f05476f875528905eba9a89 != 0)
					{
						num2 = 0;
					}
					continue;
				case 29:
					if (kVuJVobUUTyVykQPqtqQ(evr9VzPFX3p) > 0)
					{
						num2 = 30;
						continue;
					}
					goto IL_0a07;
				case 20:
					rawCluster = (IRawCluster)PpxyT5btUV5G1CSW8BO1(base.DataProvider, num3);
					if (rawCluster == null)
					{
						goto case 37;
					}
					goto case 4;
				case 35:
					if (P_1 > 2.0)
					{
						num2 = 3;
						continue;
					}
					goto IL_0e3b;
				case 50:
					num6 -= 2.0;
					num2 = 6;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_52f1b40ebe094208bc85ded04f1baa0b == 0)
					{
						num2 = 6;
					}
					continue;
				case 39:
					me021enuViEjoFdJlZYV.yoknuu2ELyt = new XFont(((XFont)vxjutfbUtdfG16FaVQkU(base.Settings)).Name, val);
					num2 = 5;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d3afdd6ad27a4c3b87071f1be51e7ef3 != 0)
					{
						num2 = 36;
					}
					continue;
				case 26:
					UUD9VDsTDl2(P_0, rawCluster, me021enuViEjoFdJlZYV);
					goto case 48;
				case 18:
					M829Vk4rSqu(P_0, me021enuViEjoFdJlZYV);
					num2 = 37;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f2434d508b7b4b77853ea03e1bcda658 == 0)
					{
						num2 = 29;
					}
					continue;
				case 31:
					me021enuViEjoFdJlZYV.eBdnz44CrCj = list3;
					me021enuViEjoFdJlZYV.KwBnzDPHQZd = list3.Count > 0;
					num2 = 51;
					continue;
				case 9:
					num4 = num10 ?? JZoXGhbUqltldevrBers(1, (int)(P_1 * 0.1));
					goto IL_0e3b;
				case 33:
					me021enuViEjoFdJlZYV.QfInz2KpKYU = Math.Max(maxValues.MaxDelta, -maxValues.MinDelta);
					me021enuViEjoFdJlZYV.kbWnzHuOgBw = Math.Max(maxValues.MaxBid, DP9TafbUrlvbWvYkl1xi(maxValues));
					me021enuViEjoFdJlZYV.T9JnzfkRxZO = Math.Max(maxValues.MaxOpenPos, -maxValues.MinOpenPos);
					num2 = 41;
					continue;
				case 45:
					list = new List<D8gyZXnz5m1y5iiw1dIF>();
					num2 = 16;
					continue;
				case 14:
					foreach (IndicatorBase item in cpI9r4xqdTB().Indicators)
					{
						IContainsSelection containsSelection = item as IContainsSelection;
						int num13 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2088b9a28522490e83dc44062c40a7c0 == 0)
						{
							num13 = 0;
						}
						while (true)
						{
							switch (num13)
							{
							case 1:
								list3.Add(containsSelection);
								break;
							default:
								if (containsSelection != null)
								{
									num13 = 1;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_53f0c1974ed349c3831704ecb4d3ce13 != 0)
									{
										num13 = 1;
									}
									continue;
								}
								break;
							}
							break;
						}
					}
					goto case 31;
				case 3:
					num10 = evr9VzPFX3p.DirMarkerWidth;
					num = 9;
					break;
				case 38:
					flag = G00p8fbUZ5Fqxr73ms1q(rawCluster);
					num2 = 40;
					continue;
				case 46:
					me021enuViEjoFdJlZYV.jRInzNcceFv = list.Count > 0;
					list3 = new List<IContainsSelection>();
					num2 = 2;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a849a254fa6841d5989e377890b7578f == 0)
					{
						num2 = 14;
					}
					continue;
				case 28:
					me021enuViEjoFdJlZYV.hcQnzb4ilbk = list;
					num2 = 46;
					continue;
				case 12:
					me021enuViEjoFdJlZYV = new me021enuViEjoFdJlZYV
					{
						YTXnuKOC1lk = step,
						ColumnWidth = P_1,
						Round = sybt83bUMwMZJX67SbqS(base.Settings.ClusterSettings)
					};
					num2 = 27;
					continue;
				case 37:
					num8++;
					goto IL_0c4b;
				case 19:
					me021enuViEjoFdJlZYV.EOcnuPAGkSA = num5;
					flag2 = JyPGBGbUWIeFZMunIEUK(evr9VzPFX3p) && me021enuViEjoFdJlZYV.v3TnumakUEq >= (double)evr9VzPFX3p.MinBarWidth && num7 > 8.0;
					num2 = 10;
					continue;
				case 5:
					return;
				case 27:
					num4 = 0;
					num2 = 21;
					continue;
				case 13:
					step = base.DataProvider.Step;
					num2 = 12;
					continue;
				case 48:
				case 49:
					qV49VNFV78v(P_0, rawCluster, me021enuViEjoFdJlZYV);
					ctQ9V10grm3(P_0, me021enuViEjoFdJlZYV);
					num2 = 18;
					continue;
				case 4:
					me021enuViEjoFdJlZYV.s7unuCGVyQQ = num3;
					num2 = 36;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dd6de048cd134da6b2674c002762ca45 != 0)
					{
						num2 = 38;
					}
					continue;
				case 51:
					list2 = new List<IContainsConditions>();
					foreach (IndicatorBase item2 in (hOOnlr9I6ptNbuV3ApFP)LI6FeYbUsZQs8595WFrb(cpI9r4xqdTB()))
					{
						int num11 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b3744d11c0b24c8d993b100cbb22f9e7 != 0)
						{
							num11 = 2;
						}
						while (true)
						{
							switch (num11)
							{
							case 2:
								if (item2.ShowIndicator)
								{
									num11 = 0;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_26fe5531b15948b7a2b6ffb2cd927204 != 0)
									{
										num11 = 0;
									}
									continue;
								}
								break;
							case 1:
								list2.Add(containsConditions);
								break;
							default:
								containsConditions = item2 as IContainsConditions;
								if (containsConditions != null)
								{
									num11 = 1;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a9d70160736846b58381afc3c46699f2 == 0)
									{
										num11 = 1;
									}
									continue;
								}
								break;
							}
							break;
						}
					}
					goto case 25;
				case 25:
					me021enuViEjoFdJlZYV.Conditions = list2;
					num2 = 17;
					continue;
				case 6:
					val = (int)(y0E4BubtuMiIJBYLpVJt(num6, 18.0) * 96.0 / 72.0);
					val = Math.Min(val, ((XFont)vxjutfbUtdfG16FaVQkU(base.Settings)).Size);
					goto case 39;
				case 17:
					me021enuViEjoFdJlZYV.O1onzkr76U9 = base.DataProvider.Symbol.SizeStep;
					n5Rnz130BFd = base.DataProvider.Symbol.NOvnY43A4X4();
					num2 = 44;
					continue;
				case 36:
					me021enuViEjoFdJlZYV.qOJnuFOtqYg = me021enuViEjoFdJlZYV.yoknuu2ELyt.GetSize((string)W0Xj2UbttECO5feKGUVN(-45476899 ^ -45206793)).Width;
					goto IL_0ed3;
				case 11:
					val = (int)((double)num10.Value * 96.0 / 72.0);
					num2 = 39;
					continue;
				case 40:
					me021enuViEjoFdJlZYV.CenterX = (double)(int)ovvDGKbUVNIl8GKXkWgt(base.Canvas, num3) + (double)num4 / 2.0;
					me021enuViEjoFdJlZYV.aYpnuwO8Vos = (int)GetY((double)rawCluster.High * step + step / 2.0);
					me021enuViEjoFdJlZYV.rB1nu7twWyg = (int)GetY((double)rawCluster.Low * step - step / 2.0) + num5;
					me021enuViEjoFdJlZYV.Qjbnu8cIx4T = (flag ? ((int)GetY((double)rawCluster.Close * step + step / 2.0)) : ((int)GetY((double)KtCqd9bUjcSd6nOk1CTk(rawCluster) * step + step / 2.0)));
					me021enuViEjoFdJlZYV.aWdnuAaPRkF = ((!flag) ? ((int)SXlNTDbtwj0C56ClRwuK(this, (double)qpXFaFbUBjM5dq5Ao8au(rawCluster) * step - step / 2.0) + num5) : ((int)GetY((double)rawCluster.Open * step - step / 2.0) + num5));
					num2 = 4;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c16c36b6197f4f30be0a8035f04288b3 == 0)
					{
						num2 = 7;
					}
					continue;
				case 34:
					me021enuViEjoFdJlZYV.JexnzYY6iOg = kVuJVobUUTyVykQPqtqQ(evr9VzPFX3p) * n6xViEbUTvM9JsE6rGuP(base.DataProvider.Symbol);
					me021enuViEjoFdJlZYV.b4nnzo6IioA = kVuJVobUUTyVykQPqtqQ(evr9VzPFX3p);
					goto IL_0a07;
				case 24:
					{
						if (!(num7 > 1.0))
						{
							goto IL_04cd;
						}
						num15 = -1;
						goto IL_0eb6;
					}
					IL_0ed3:
					me021enuViEjoFdJlZYV.X1tnupPKJ6Q = evr9VzPFX3p.CellType == ChartCellViewType.BorderedBars && num7 + (double)num5 > 3.0;
					if (evr9VzPFX3p.ProportionType != ClusterProportionType.CurrentBar)
					{
						tha9VxfdCO3(out xSTnuziHlxS, out cernz0EgckQ, out qfInz2KpKYU, out kbWnzHuOgBw, out t9JnzfkRxZO);
						num2 = 47;
						continue;
					}
					goto case 29;
					IL_0e3b:
					me021enuViEjoFdJlZYV.XwNnuhiXaoi = num4;
					v3TnumakUEq = nkhZRFbUHb2k7Sat25WR(P_1 - (double)num4 - 2.0, 1.0);
					me021enuViEjoFdJlZYV.v3TnumakUEq = v3TnumakUEq;
					num2 = 42;
					continue;
					IL_0c4b:
					if (num8 < mGPMIbbUQpWmpa1cg6V3(base.Canvas))
					{
						num3 = eCgEWJbU5BVLFDmxw0Uo(q3DvdcbtVtoCkNGgtXcR(this), num8);
						num2 = 20;
						continue;
					}
					num = 5;
					break;
					IL_0a07:
					if (seKn9SbUydsBTGYyg9wE(evr9VzPFX3p) > 0)
					{
						me021enuViEjoFdJlZYV.yminzv514RX = seKn9SbUydsBTGYyg9wE(evr9VzPFX3p) * n6xViEbUTvM9JsE6rGuP(base.DataProvider.Symbol);
						num2 = 22;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a80f370f27d471fab60f042c9fa7b49 != 0)
						{
							num2 = 22;
						}
						continue;
					}
					goto case 45;
					IL_04cd:
					num15 = 0;
					goto IL_0eb6;
					IL_0eb6:
					num5 = num15;
					num = 19;
					break;
				}
				break;
			}
		}
	}

	private void UUD9VDsTDl2(DxVisualQueue P_0, IRawCluster P_1, me021enuViEjoFdJlZYV P_2)
	{
		ClusterViewPreset clusterViewPreset = nsM5hWbUmUuOQvexdAuj(evr9VzPFX3p);
		double num = P_2.CenterX - P_2.v3TnumakUEq / 2.0;
		int num2 = 2;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8ebd61b38044e13aca9bf7790883fb0 == 0)
		{
			num2 = 20;
		}
		long value = default(long);
		IRawClusterItem rawClusterItem = default(IRawClusterItem);
		double num6 = default(double);
		Rect rect = default(Rect);
		bool flag = default(bool);
		bool flag4 = default(bool);
		List<XBrush>.Enumerator enumerator = default(List<XBrush>.Enumerator);
		XBrush brush = default(XBrush);
		XColor xColor = default(XColor);
		long num17 = default(long);
		bool flag2 = default(bool);
		string text = default(string);
		IRawClusterMaxValues rawClusterMaxValues = default(IRawClusterMaxValues);
		bool flag3 = default(bool);
		long num4 = default(long);
		long num11 = default(long);
		long value4 = default(long);
		Rect rect3 = default(Rect);
		long num10 = default(long);
		long num23 = default(long);
		long num14 = default(long);
		Rect rect2 = default(Rect);
		double num20 = default(double);
		double num21 = default(double);
		XBrush brush2 = default(XBrush);
		long num15 = default(long);
		long value3 = default(long);
		long num8 = default(long);
		double num13 = default(double);
		long value2 = default(long);
		double num26 = default(double);
		while (true)
		{
			XColor xColor2;
			int num5;
			XBrush xBrush5;
			XBrush xBrush4;
			XBrush xBrush;
			XColor xColor3;
			double num24;
			int num3;
			int num16;
			XBrush xBrush3;
			XBrush xBrush2;
			object obj;
			long num7;
			long num9;
			long num12;
			long num18;
			long num19;
			switch (num2)
			{
			case 9:
				xColor2 = spjTrtbU32UnA0xCQpUx(base.Theme);
				goto IL_17e3;
			case 64:
				value = RvrSVubtyeJxuWF7wHyF(P_2.QfInz2KpKYU, Math.Abs(rawClusterItem.Delta));
				num6 = rect.Width;
				num5 = 33;
				goto IL_0005;
			case 78:
				if (rawClusterItem.Delta < 0)
				{
					num2 = 57;
					continue;
				}
				xBrush5 = base.Theme.ClusterDeltaPlusBrush;
				goto IL_186d;
			case 26:
				flag = false;
				flag4 = false;
				num2 = 73;
				continue;
			case 7:
				enumerator = B1J9VLAewQ1(P_2.eBdnz44CrCj, P_2.s7unuCGVyQQ, kwCy1QbTnfcl1KZPBVH8(rawClusterItem), 0).GetEnumerator();
				num2 = 59;
				continue;
			case 48:
				brush = new XBrush(xColor.ChangeOpacity(Math.Min(P_2.QfInz2KpKYU, Math.Abs(rawClusterItem.Delta)), P_2.QfInz2KpKYU, qWeYdxbUpbmgW6DUY18o(base.Theme)));
				num2 = 10;
				continue;
			case 1:
				xColor = base.Theme.ClusterDeltaMinusColor;
				xBrush4 = new XBrush(xColor.ChangeOpacity(num17, P_2.QfInz2KpKYU, base.Theme.ChartBackColor));
				goto IL_1856;
			case 33:
				if (N1Pnf3bUu17ER1xpWR8O(rawClusterItem) >= 0)
				{
					xColor = base.Theme.ClusterDeltaPlusColor;
					num2 = 81;
					continue;
				}
				xColor = spjTrtbU32UnA0xCQpUx(base.Theme);
				xBrush = new XBrush(xColor.ChangeOpacity(value, P_2.QfInz2KpKYU, base.Theme.ChartBackColor));
				goto IL_1830;
			case 41:
			case 49:
				if (flag && flag2)
				{
					num5 = 68;
					goto IL_0005;
				}
				goto case 65;
			default:
				text = Hi99VSMfIpu(rawClusterItem.OpenPos, P_2.Round);
				goto case 41;
			case 80:
				flag4 = lJ83FGbUJnC2IkvWd4xP(rawClusterItem) == rawClusterMaxValues.MaxVolume;
				num2 = 25;
				continue;
			case 5:
				if (N1Pnf3bUu17ER1xpWR8O(rawClusterItem) < 0)
				{
					num2 = 37;
					continue;
				}
				xColor3 = LK4RW4bUzCTlsEJ7laoC(base.Theme);
				goto IL_17d1;
			case 19:
				P_0.DrawRectangle(base.Theme.ClusterCellBorderPen, new Rect(rect.X, rect.Y, Math.Max(num6 - 1.0, 1.0), nkhZRFbUHb2k7Sat25WR(rect.Height - 1.0, 1.0)));
				goto IL_0959;
			case 30:
				switch (clusterViewPreset)
				{
				case ClusterViewPreset.Delta:
					break;
				case ClusterViewPreset.Volume:
					goto IL_01f2;
				case ClusterViewPreset.TradesProfileDeltaColored:
					goto IL_0760;
				case ClusterViewPreset.TradesProfile:
					goto IL_0833;
				case ClusterViewPreset.OpenPos:
					goto IL_0860;
				case ClusterViewPreset.OpenPosHistogram:
					goto IL_08da;
				case ClusterViewPreset.VolumeDeltaColored:
					goto IL_0b29;
				case ClusterViewPreset.DeltaHistogram:
					goto IL_0e69;
				case ClusterViewPreset.DeltaProfile:
					goto IL_1142;
				case ClusterViewPreset.TradesDeltaColored:
					goto IL_12c6;
				case ClusterViewPreset.VolumeProfile:
					goto IL_1453;
				case ClusterViewPreset.VolumeHistogram:
					goto IL_14ac;
				case ClusterViewPreset.Trades:
					goto IL_14f4;
				case ClusterViewPreset.TradesHistogram:
					goto IL_1624;
				case ClusterViewPreset.VolumeProfileDeltaColored:
					goto IL_164d;
				default:
					goto IL_1666;
				case ClusterViewPreset.OpenPosProfile:
					goto IL_1735;
				}
				goto case 64;
			case 34:
				switch (clusterViewPreset)
				{
				case ClusterViewPreset.VolumeTrade:
				case ClusterViewPreset.VolumeTradeProfile:
				case ClusterViewPreset.VolumeTradeHistogram:
				case ClusterViewPreset.VolumeDelta:
				case ClusterViewPreset.VolumeDeltaProfile:
				case ClusterViewPreset.VolumeDeltaHistogram:
				case ClusterViewPreset.BidAsk:
				case ClusterViewPreset.BidAskLadder:
				case ClusterViewPreset.BidAskProfile:
				case ClusterViewPreset.BidAskHistogram:
				case ClusterViewPreset.BidAskVolumeProfile:
				case ClusterViewPreset.BidAskDeltaProfile:
				case ClusterViewPreset.BidAskImbalance:
					break;
				default:
					goto IL_05ee;
				case ClusterViewPreset.Delta:
				case ClusterViewPreset.DeltaProfile:
				case ClusterViewPreset.DeltaHistogram:
					goto IL_0745;
				case ClusterViewPreset.Volume:
				case ClusterViewPreset.VolumeProfile:
				case ClusterViewPreset.VolumeHistogram:
				case ClusterViewPreset.VolumeDeltaColored:
				case ClusterViewPreset.VolumeProfileDeltaColored:
					goto IL_09ca;
				case ClusterViewPreset.Trades:
				case ClusterViewPreset.TradesProfile:
				case ClusterViewPreset.TradesHistogram:
				case ClusterViewPreset.TradesDeltaColored:
				case ClusterViewPreset.TradesProfileDeltaColored:
					goto IL_09fa;
				case ClusterViewPreset.OpenPos:
				case ClusterViewPreset.OpenPosProfile:
				case ClusterViewPreset.OpenPosHistogram:
					goto IL_158c;
				}
				goto case 41;
			case 43:
				flag3 = true;
				num2 = 51;
				continue;
			case 87:
				if (!base.DataProvider.Symbol.IsDenomination)
				{
					num2 = 38;
					continue;
				}
				num24 = (double)D94SP8bTGSpxS7bbwM6W(evr9VzPFX3p) / (double)P_2.n5Rnz130BFd;
				goto IL_192a;
			case 55:
				goto IL_0745;
			case 44:
			case 62:
				if (num4 < num11)
				{
					return;
				}
				goto case 22;
			case 38:
				num24 = D94SP8bTGSpxS7bbwM6W(evr9VzPFX3p) * P_2.n5Rnz130BFd;
				goto IL_192a;
			case 77:
				if (P_2.v3TnumakUEq < 3.0)
				{
					goto IL_07aa;
				}
				goto IL_1314;
			case 52:
				num6 = rect.Width;
				xColor = base.Theme.ClusterTradesColor;
				num2 = 72;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5dcb5c2a8274adf87bda91d76616538 == 0)
				{
					num2 = 62;
				}
				continue;
			case 69:
				goto IL_0833;
			case 28:
				brush = new XBrush(xColor.ChangeOpacity(value4, P_2.XSTnuziHlxS, base.Theme.ChartBackColor));
				flag3 = lJ83FGbUJnC2IkvWd4xP(rawClusterItem) >= P_2.s67nz9oCZGJ;
				num2 = 18;
				continue;
			case 15:
				rect3 = default(Rect);
				num10 = (long)(t4mHOrbUhCfMoEoDkkbX(cpI9r4xqdTB().ybUnYpBPWvT(), pr2IDnbt81xmsDnTdNh7(q3DvdcbtVtoCkNGgtXcR(this)).Top) / base.DataProvider.Step);
				num11 = (long)(((NMHchMnvtxgoKNmDEII2)IHc6d8bUwtHnTqaLvNDH(cpI9r4xqdTB())).rPGnvCy3AGu(((IChartCanvas)q3DvdcbtVtoCkNGgtXcR(this)).Rect.Bottom) / base.DataProvider.Step);
				num2 = 59;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_281cd373231b4974955fe570959430ac == 0)
				{
					num2 = 86;
				}
				continue;
			case 66:
				goto IL_08da;
			case 84:
				if (flag && flag2)
				{
					num2 = 20;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9d6f131f80d34ede83451138b928a86f == 0)
					{
						num2 = 31;
					}
					continue;
				}
				goto case 41;
			case 83:
				num4 = num10;
				num5 = 44;
				goto IL_0005;
			case 37:
				xColor3 = base.Theme.ClusterDeltaMinusColor;
				goto IL_17d1;
			case 35:
				goto IL_09ca;
			case 17:
				goto IL_09fa;
			case 88:
				num6 = rect.Width / (double)P_2.Cernz0EgckQ * (double)num23;
				num2 = 47;
				continue;
			case 73:
				if (!P_2.q7Dnu3Ck9ZT)
				{
					num2 = 63;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8a9257c2b61741afa02a8ceb1f69ad69 == 0)
					{
						num2 = 35;
					}
					continue;
				}
				goto case 4;
			case 29:
				brush = new XBrush(xColor.ChangeOpacity(num14, P_2.XSTnuziHlxS, base.Theme.ChartBackColor));
				flag3 = rawClusterItem.Volume >= P_2.s67nz9oCZGJ;
				goto IL_1666;
			case 47:
				xColor = ((N1Pnf3bUu17ER1xpWR8O(rawClusterItem) >= 0) ? LK4RW4bUzCTlsEJ7laoC(base.Theme) : base.Theme.ClusterDeltaMinusColor);
				brush = new XBrush(xColor.ChangeOpacity(RvrSVubtyeJxuWF7wHyF(P_2.QfInz2KpKYU, Math.Abs(rawClusterItem.Delta)), P_2.QfInz2KpKYU, base.Theme.ChartBackColor));
				flag3 = rawClusterItem.Trades >= P_2.hHqnznKqJax;
				goto IL_1666;
			case 59:
				try
				{
					while (enumerator.MoveNext())
					{
						XBrush current = enumerator.Current;
						int num22 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ff2c70a81f2141b98b88fc10875a3726 != 0)
						{
							num22 = 0;
						}
						switch (num22)
						{
						}
						P_0.FillRectangle(current, rect2);
					}
				}
				finally
				{
					((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
				}
				goto case 8;
			case 32:
				rect = new Rect(num + 1.0, num20, P_2.v3TnumakUEq, nkhZRFbUHb2k7Sat25WR(num21 + P_2.EOcnuPAGkSA, 1.0));
				brush2 = (XBrush)MjWq8ZbUA8ltTTVRtmeX(base.Theme);
				num2 = 50;
				continue;
			case 70:
				xColor = base.Theme.ClusterVolumeColor;
				num2 = 28;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_976d29d6825c4c4995e3a2719d735c00 != 0)
				{
					num2 = 19;
				}
				continue;
			case 40:
				flag3 = Math.Abs(rawClusterItem.OpenPos) >= P_2.b4nnzo6IioA;
				goto IL_1666;
			case 68:
				P_0.DrawString(rect: new Rect(rect.Left + 1.0, rect.Top, rect.Width - 2.0, rect.Height), text: text, font: P_2.yoknuu2ELyt, brush: brush2);
				num2 = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9d6f131f80d34ede83451138b928a86f == 0)
				{
					num2 = 65;
				}
				continue;
			case 31:
				text = Hi99VSMfIpu(rawClusterItem.Trades, P_2.Round);
				goto case 41;
			case 79:
				flag3 = rawClusterItem.Trades >= P_2.hHqnznKqJax;
				num2 = 9;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_495802897f05476f875528905eba9a89 == 0)
				{
					num2 = 12;
				}
				continue;
			case 82:
				goto IL_0e69;
			case 74:
				flag3 = rawClusterItem.Trades >= P_2.hHqnznKqJax;
				goto IL_1666;
			case 11:
				xColor = ((rawClusterItem.Delta >= 0) ? base.Theme.ClusterDeltaPlusColor : spjTrtbU32UnA0xCQpUx(base.Theme));
				brush = new XBrush(xColor.ChangeOpacity(RvrSVubtyeJxuWF7wHyF(P_2.QfInz2KpKYU, Math.Abs(rawClusterItem.Delta)), P_2.QfInz2KpKYU, qWeYdxbUpbmgW6DUY18o(base.Theme)));
				flag3 = rawClusterItem.Volume >= P_2.s67nz9oCZGJ;
				num2 = 46;
				continue;
			case 4:
				num3 = ((rect.Width > 4.0) ? 1 : 0);
				break;
			case 65:
				if (P_2.X1tnupPKJ6Q)
				{
					num2 = 19;
					continue;
				}
				goto IL_0959;
			case 58:
				P_0.FillRectangle(brush, rect2);
				if (P_2.jRInzNcceFv)
				{
					D8gyZXnz5m1y5iiw1dIF d8gyZXnz5m1y5iiw1dIF = vTJ9VesTG0u(P_2.hcQnzb4ilbk, rawClusterItem);
					if (d8gyZXnz5m1y5iiw1dIF != null)
					{
						P_0.FillRectangle(new XBrush(d8gyZXnz5m1y5iiw1dIF.HiBnzLvMJQc), rect2);
						brush2 = new XBrush(d8gyZXnz5m1y5iiw1dIF.HfFnze2YjU0);
					}
				}
				if (!P_2.KwBnzDPHQZd)
				{
					num2 = 8;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ad0a44f3eae14332b41c0c5ef48d2cbb != 0)
					{
						num2 = 8;
					}
					continue;
				}
				goto case 7;
			case 21:
				num16 = ((Math.Abs(wv75gXbTfXFEwmrZJr0d(rawClusterItem)) == Math.Max(Sew83obTvEftY431syxx(rawClusterMaxValues), Math.Abs(rawClusterMaxValues.MinOpenPos))) ? 1 : 0);
				goto IL_1976;
			case 3:
				if (wv75gXbTfXFEwmrZJr0d(rawClusterItem) != 0L)
				{
					num2 = 21;
					continue;
				}
				num16 = 0;
				goto IL_1976;
			case 42:
				brush = new XBrush(xColor.ChangeOpacity(num15, P_2.Cernz0EgckQ, qWeYdxbUpbmgW6DUY18o(base.Theme)));
				num2 = 19;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9aa9dbd12b8a4a4ea59acea051cdddbf != 0)
				{
					num2 = 74;
				}
				continue;
			case 72:
				brush = new XBrush(xColor.ChangeOpacity(value3, P_2.Cernz0EgckQ, base.Theme.ChartBackColor));
				num2 = 79;
				continue;
			case 56:
				flag3 = Math.Abs(rawClusterItem.Delta) >= P_2.aKjnzGRd91Z;
				goto IL_1666;
			case 85:
				num6 = rect.Width / (double)P_2.T9JnzfkRxZO * (double)num8;
				num2 = 24;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_43d123ebfe574af38268397bb0ae2d1a == 0)
				{
					num2 = 14;
				}
				continue;
			case 67:
				flag3 = Math.Abs(wv75gXbTfXFEwmrZJr0d(rawClusterItem)) >= P_2.b4nnzo6IioA;
				num2 = 61;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9aa9dbd12b8a4a4ea59acea051cdddbf == 0)
				{
					num2 = 13;
				}
				continue;
			case 8:
			case 27:
				if (flag3)
				{
					text = "";
					num2 = 26;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_52f1b40ebe094208bc85ded04f1baa0b == 0)
					{
						num2 = 13;
					}
					continue;
				}
				goto case 36;
			case 54:
				xColor = base.Theme.ClusterOpenIntMinusColor;
				xBrush3 = new XBrush(xColor.ChangeOpacity(num8, P_2.T9JnzfkRxZO, base.Theme.ChartBackColor));
				goto IL_18cb;
			case 2:
				flag3 = Math.Abs(rawClusterItem.Delta) >= P_2.aKjnzGRd91Z;
				num2 = 14;
				continue;
			case 10:
				flag3 = rawClusterItem.Trades >= P_2.hHqnznKqJax;
				num2 = 76;
				continue;
			case 57:
				xBrush5 = base.Theme.ClusterDeltaMinusBrush;
				goto IL_186d;
			case 20:
				num13 = P_2.aYpnuwO8Vos;
				num2 = 13;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1bb232d361564d93b9a5d5e53983bdb3 == 0)
				{
					num2 = 15;
				}
				continue;
			case 71:
				brush = (XBrush)zGTuYMbT0NYEVJ2Aba0Y(base.Theme);
				flag3 = rawClusterItem.Trades >= P_2.hHqnznKqJax;
				num2 = 13;
				continue;
			case 25:
				if (flag && flag2)
				{
					text = mH99V5Vg5Cc(lJ83FGbUJnC2IkvWd4xP(rawClusterItem), P_2.Round);
					num2 = 41;
					continue;
				}
				goto case 41;
			case 39:
				goto IL_14ac;
			case 86:
				num10 = Math.Min(P_1.High, num10 + 1);
				num11 = YsnkW2bU7HYwKPreqJIl(P_1.Low, num11 - 1);
				rawClusterMaxValues = (IRawClusterMaxValues)fSoW1jbU85d1mI80w1Jb(P_1);
				num2 = 83;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c7e1deb64093431d91d263a2e49f884b == 0)
				{
					num2 = 39;
				}
				continue;
			case 24:
				if (wv75gXbTfXFEwmrZJr0d(rawClusterItem) >= 0)
				{
					xColor = base.Theme.ClusterOpenIntPlusColor;
					xBrush3 = new XBrush(xColor.ChangeOpacity(num8, P_2.T9JnzfkRxZO, qWeYdxbUpbmgW6DUY18o(base.Theme)));
					goto IL_18cb;
				}
				num2 = 54;
				continue;
			case 22:
			{
				int num25 = (int)GetY((double)num4 * P_2.YTXnuKOC1lk - P_2.YTXnuKOC1lk / 2.0);
				num21 = Math.Max((double)num25 - num13, 1.0);
				num20 = num13;
				num13 = num25;
				if (!(num20 + num21 < pr2IDnbt81xmsDnTdNh7(base.Canvas).Top) && !(num20 - num21 > pr2IDnbt81xmsDnTdNh7(base.Canvas).Bottom))
				{
					num2 = 32;
					continue;
				}
				goto case 36;
			}
			case 53:
				goto IL_158c;
			case 50:
				num6 = rect.Width;
				brush = QIX9VmYrFEt;
				num2 = 43;
				continue;
			case 36:
				num4--;
				num2 = 62;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_34c8a548a4724373aa05c97fa43f690a != 0)
				{
					num2 = 24;
				}
				continue;
			case 75:
				goto IL_164d;
			case 12:
			case 13:
			case 14:
			case 18:
			case 23:
			case 46:
			case 61:
			case 76:
				goto IL_1666;
			case 6:
				xBrush2 = new XBrush(xColor.ChangeOpacity(value2, P_2.T9JnzfkRxZO, base.Theme.ChartBackColor));
				goto IL_189c;
			case 16:
				num6 = rect.Width;
				if (P_1.OpenPos <= 0)
				{
					goto case 40;
				}
				if (rawClusterItem.OpenPos < 0)
				{
					num2 = 45;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d4c083a65c1546b8a09c928a8c95e140 == 0)
					{
						num2 = 13;
					}
					continue;
				}
				xColor = znoJY9bTHGvjexYB0ojT(base.Theme);
				xBrush2 = new XBrush(xColor.ChangeOpacity(value2, P_2.T9JnzfkRxZO, qWeYdxbUpbmgW6DUY18o(base.Theme)));
				goto IL_189c;
			case 45:
				xColor = base.Theme.ClusterOpenIntMinusColor;
				num2 = 6;
				continue;
			case 51:
				obj = hnuaxxbUPvuRUiIEpDgP(P_1, num4);
				if (obj != null)
				{
					goto IL_17a4;
				}
				num2 = 60;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dd6de048cd134da6b2674c002762ca45 == 0)
				{
					num2 = 26;
				}
				continue;
			case 60:
				obj = new RawClusterItem(num4);
				goto IL_17a4;
			case 81:
				xBrush = new XBrush(xColor.ChangeOpacity(value, P_2.QfInz2KpKYU, qWeYdxbUpbmgW6DUY18o(base.Theme)));
				goto IL_1830;
			case 63:
				{
					num3 = 0;
					break;
				}
				IL_17a4:
				rawClusterItem = (IRawClusterItem)obj;
				num5 = 30;
				goto IL_0005;
				IL_05ee:
				num2 = 49;
				continue;
				IL_164d:
				num7 = Math.Min(P_2.XSTnuziHlxS, rawClusterItem.Volume);
				num6 = rect.Width / (double)P_2.XSTnuziHlxS * (double)num7;
				num2 = 5;
				continue;
				IL_1735:
				num8 = RvrSVubtyeJxuWF7wHyF(P_2.T9JnzfkRxZO, Oua4jcbT2uyVXOCtLBm3(wv75gXbTfXFEwmrZJr0d(rawClusterItem)));
				num2 = 85;
				continue;
				IL_189c:
				brush = xBrush2;
				num5 = 40;
				goto IL_0005;
				IL_1624:
				num9 = Math.Min(P_2.Cernz0EgckQ, rawClusterItem.Trades);
				num6 = rect.Width / (double)P_2.Cernz0EgckQ * (double)num9;
				num2 = 27;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fa74d46e0c824e0b89c71deca0488611 == 0)
				{
					num2 = 71;
				}
				continue;
				IL_1856:
				brush = xBrush4;
				num2 = 56;
				continue;
				IL_14f4:
				value3 = Math.Min(P_2.Cernz0EgckQ, rawClusterItem.Trades);
				num2 = 52;
				continue;
				IL_14ac:
				num12 = RvrSVubtyeJxuWF7wHyF(P_2.XSTnuziHlxS, lJ83FGbUJnC2IkvWd4xP(rawClusterItem));
				num6 = rect.Width / (double)P_2.XSTnuziHlxS * (double)num12;
				brush = (XBrush)cD149dbUFy3O2HDx6cA1(base.Theme);
				flag3 = lJ83FGbUJnC2IkvWd4xP(rawClusterItem) >= P_2.s67nz9oCZGJ;
				goto IL_1666;
				IL_1453:
				num14 = RvrSVubtyeJxuWF7wHyF(P_2.XSTnuziHlxS, rawClusterItem.Volume);
				num6 = rect.Width / (double)P_2.XSTnuziHlxS * (double)num14;
				xColor = base.Theme.ClusterVolumeColor;
				num2 = 29;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9aa9dbd12b8a4a4ea59acea051cdddbf == 0)
				{
					num2 = 25;
				}
				continue;
				IL_18cb:
				brush = xBrush3;
				flag3 = Math.Abs(wv75gXbTfXFEwmrZJr0d(rawClusterItem)) >= P_2.b4nnzo6IioA;
				goto IL_1666;
				IL_0005:
				num2 = num5;
				continue;
				IL_12c6:
				num6 = rect.Width;
				if (rawClusterItem.Delta < 0)
				{
					num2 = 9;
					continue;
				}
				xColor2 = base.Theme.ClusterDeltaPlusColor;
				goto IL_17e3;
				IL_1142:
				num17 = Math.Min(P_2.QfInz2KpKYU, Oua4jcbT2uyVXOCtLBm3(rawClusterItem.Delta));
				num6 = rect.Width / (double)P_2.QfInz2KpKYU * (double)num17;
				if (N1Pnf3bUu17ER1xpWR8O(rawClusterItem) < 0)
				{
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_976d29d6825c4c4995e3a2719d735c00 != 0)
					{
						num2 = 1;
					}
					continue;
				}
				xColor = base.Theme.ClusterDeltaPlusColor;
				xBrush4 = new XBrush(xColor.ChangeOpacity(num17, P_2.QfInz2KpKYU, qWeYdxbUpbmgW6DUY18o(base.Theme)));
				goto IL_1856;
				IL_1976:
				flag4 = (byte)num16 != 0;
				if (!(flag && flag2))
				{
					goto case 41;
				}
				goto default;
				IL_1666:
				if (!(P_2.o1LnuJLdjKL >= 1.0))
				{
					num2 = 72;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_94f896a1c68c4274bf6a8960d175b5c2 != 0)
					{
						num2 = 77;
					}
					continue;
				}
				goto IL_07aa;
				IL_1830:
				brush = xBrush;
				flag3 = Math.Abs(rawClusterItem.Delta) >= P_2.aKjnzGRd91Z;
				goto IL_1666;
				IL_0e69:
				num18 = Math.Min(P_2.QfInz2KpKYU, Math.Abs(rawClusterItem.Delta));
				num6 = rect.Width / (double)P_2.QfInz2KpKYU * (double)num18;
				num2 = 78;
				continue;
				IL_0b29:
				num6 = rect.Width;
				num2 = 7;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f6b8a9ae320a40f994b0db08d42c2a95 == 0)
				{
					num2 = 11;
				}
				continue;
				IL_08da:
				num19 = Math.Min(P_2.T9JnzfkRxZO, Math.Abs(wv75gXbTfXFEwmrZJr0d(rawClusterItem)));
				num6 = rect.Width / (double)P_2.T9JnzfkRxZO * (double)num19;
				brush = (XBrush)((rawClusterItem.OpenPos >= 0) ? i08bDLbT9VnZPb5Im3Ff(base.Theme) : base.Theme.ClusterOpenIntMinusBrush);
				num2 = 38;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_409738fae61f4f058345c98b7cfbcbac != 0)
				{
					num2 = 67;
				}
				continue;
				IL_1314:
				if (num6 >= 1.0)
				{
					rect2 = new Rect(rect.Left, rect.Top, num6, rect.Height);
					if ((int)rect2.Y != (int)rect3.Y || rect2.Width > rect3.Width)
					{
						rect3 = rect2;
						if (flag3)
						{
							num2 = 58;
							continue;
						}
					}
				}
				goto case 8;
				IL_0833:
				num15 = Math.Min(P_2.Cernz0EgckQ, rawClusterItem.Trades);
				num6 = rect.Width / (double)P_2.Cernz0EgckQ * (double)num15;
				xColor = base.Theme.ClusterTradesColor;
				num2 = 42;
				continue;
				IL_0760:
				num23 = RvrSVubtyeJxuWF7wHyF(P_2.Cernz0EgckQ, rawClusterItem.Trades);
				num2 = 88;
				continue;
				IL_0860:
				value2 = Math.Min(P_2.T9JnzfkRxZO, Math.Abs(rawClusterItem.OpenPos));
				num2 = 16;
				continue;
				IL_01f2:
				value4 = RvrSVubtyeJxuWF7wHyF(P_2.XSTnuziHlxS, rawClusterItem.Volume);
				num6 = rect.Width;
				num2 = 70;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_426282f87bb443dbbfe9ea3327b81bb7 != 0)
				{
					num2 = 32;
				}
				continue;
				IL_07aa:
				num6 = Math.Max(num6, 1.0);
				goto IL_1314;
				IL_17e3:
				xColor = xColor2;
				num2 = 21;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2fa91f76013747d9b5f0073a2a323201 == 0)
				{
					num2 = 48;
				}
				continue;
				IL_17d1:
				xColor = xColor3;
				brush = new XBrush(xColor.ChangeOpacity(RvrSVubtyeJxuWF7wHyF(P_2.QfInz2KpKYU, Math.Abs(N1Pnf3bUu17ER1xpWR8O(rawClusterItem))), P_2.QfInz2KpKYU, qWeYdxbUpbmgW6DUY18o(base.Theme)));
				flag3 = rawClusterItem.Volume >= P_2.s67nz9oCZGJ;
				num2 = 23;
				continue;
				IL_192a:
				num26 = num24;
				num5 = 34;
				goto IL_0005;
				IL_158c:
				flag = Math.Abs(rawClusterItem.OpenPos) >= evr9VzPFX3p.MinValue;
				num2 = 3;
				continue;
				IL_09fa:
				flag = rawClusterItem.Trades >= evr9VzPFX3p.MinValue;
				flag4 = rawClusterItem.Trades == rawClusterMaxValues.MaxTrades;
				num2 = 84;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8ebd61b38044e13aca9bf7790883fb0 != 0)
				{
					num2 = 45;
				}
				continue;
				IL_186d:
				brush = xBrush5;
				num5 = 2;
				goto IL_0005;
				IL_09ca:
				flag = (double)rawClusterItem.Volume >= num26;
				num2 = 80;
				continue;
				IL_0745:
				flag = (double)Oua4jcbT2uyVXOCtLBm3(N1Pnf3bUu17ER1xpWR8O(rawClusterItem)) >= num26;
				flag4 = Math.Abs(rawClusterItem.Delta) == YsnkW2bU7HYwKPreqJIl(rawClusterMaxValues.MaxDelta, Oua4jcbT2uyVXOCtLBm3(lVhStobTYZFvafUNUMTP(rawClusterMaxValues)));
				if (flag && flag2)
				{
					text = mH99V5Vg5Cc(zbSkKobToxAt2nHXhPCf(evr9VzPFX3p) ? Math.Abs(rawClusterItem.Delta) : rawClusterItem.Delta, P_2.Round);
				}
				goto case 41;
				IL_0959:
				if (evr9VzPFX3p.ShowMaximum && flag4)
				{
					P_0.DrawRectangle((XPen)PrCvwkbTBqrUlmT575pY(base.Theme), new Rect(rect.X, rect.Y, Math.Max(rect.Width - 1.0, 1.0), nkhZRFbUHb2k7Sat25WR(rect.Height - 1.0, 1.0)));
					goto case 36;
				}
				num2 = 21;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3023bd6c0f7846878513499bf5c36161 == 0)
				{
					num2 = 36;
				}
				continue;
			}
			flag2 = (byte)num3 != 0;
			num2 = 42;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a337f255b1bd4e8290c28001e28630dc == 0)
			{
				num2 = 87;
			}
		}
	}

	private void AsD9VbNH0VZ(DxVisualQueue P_0, IRawCluster P_1, me021enuViEjoFdJlZYV P_2)
	{
		ClusterViewPreset clusterViewPreset = evr9VzPFX3p.ClusterPreset;
		double num = P_2.CenterX - P_2.v3TnumakUEq / 2.0;
		double num2 = P_2.aYpnuwO8Vos;
		int num3 = 104;
		bool flag8 = default(bool);
		bool flag6 = default(bool);
		string text = default(string);
		IRawClusterItem rawClusterItem = default(IRawClusterItem);
		bool flag4 = default(bool);
		bool flag7 = default(bool);
		List<XBrush>.Enumerator enumerator = default(List<XBrush>.Enumerator);
		int num18 = default(int);
		D8gyZXnz5m1y5iiw1dIF d8gyZXnz5m1y5iiw1dIF4 = default(D8gyZXnz5m1y5iiw1dIF);
		Rect rect7 = default(Rect);
		XBrush xBrush4 = default(XBrush);
		XBrush brush = default(XBrush);
		Rect rect5 = default(Rect);
		double num36 = default(double);
		long num6 = default(long);
		long num44 = default(long);
		long num41 = default(long);
		long num43 = default(long);
		double num34 = default(double);
		long num31 = default(long);
		long num46 = default(long);
		IRawClusterMaxValues maxValues = default(IRawClusterMaxValues);
		long num10 = default(long);
		long num24 = default(long);
		double num9 = default(double);
		int num28 = default(int);
		bool flag3 = default(bool);
		Rect rect8 = default(Rect);
		XColor xColor = default(XColor);
		bool flag13 = default(bool);
		Rect rect6 = default(Rect);
		double num11 = default(double);
		bool flag2 = default(bool);
		bool flag12 = default(bool);
		long num42 = default(long);
		XBrush xBrush5 = default(XBrush);
		XBrush xBrush2 = default(XBrush);
		long num14 = default(long);
		long value3 = default(long);
		Rect rect4 = default(Rect);
		long num8 = default(long);
		long num12 = default(long);
		double num22 = default(double);
		double num21 = default(double);
		Rect rect3 = default(Rect);
		bool flag = default(bool);
		D8gyZXnz5m1y5iiw1dIF d8gyZXnz5m1y5iiw1dIF2 = default(D8gyZXnz5m1y5iiw1dIF);
		long num17 = default(long);
		Rect rect2 = default(Rect);
		string text2 = default(string);
		Rect rect10 = default(Rect);
		long value2 = default(long);
		long num16 = default(long);
		double num13 = default(double);
		long value5 = default(long);
		bool flag5 = default(bool);
		long value7 = default(long);
		long num25 = default(long);
		D8gyZXnz5m1y5iiw1dIF d8gyZXnz5m1y5iiw1dIF = default(D8gyZXnz5m1y5iiw1dIF);
		long num32 = default(long);
		long num40 = default(long);
		bool flag11 = default(bool);
		bool flag10 = default(bool);
		long value6 = default(long);
		long num38 = default(long);
		long num26 = default(long);
		long num35 = default(long);
		long value = default(long);
		long num33 = default(long);
		bool flag9 = default(bool);
		long value4 = default(long);
		long num20 = default(long);
		long num30 = default(long);
		long num27 = default(long);
		Rect rect = default(Rect);
		long num19 = default(long);
		while (true)
		{
			int num7;
			Rect rect9;
			int num15;
			XBrush xBrush7;
			int num23;
			XBrush xBrush;
			XBrush xBrush6;
			int num4;
			double num45;
			int num5;
			XBrush xBrush3;
			object rawClusterItem2;
			long num29;
			long num37;
			double num48;
			long num49;
			switch (num3)
			{
			case 132:
				if (flag8 && flag6)
				{
					text = mH99V5Vg5Cc(rawClusterItem.Volume, P_2.Round);
				}
				if (flag4 && flag7)
				{
					num3 = 22;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6b48af76ce0b4c779ac34c27953eddda == 0)
					{
						num3 = 60;
					}
					break;
				}
				goto IL_23f2;
			case 37:
				if (evr9VzPFX3p.BidAskImbalanceTrades)
				{
					goto IL_2924;
				}
				goto case 69;
			case 149:
				enumerator = B1J9VLAewQ1(P_2.eBdnz44CrCj, P_2.s7unuCGVyQQ, kwCy1QbTnfcl1KZPBVH8(rawClusterItem), num18).GetEnumerator();
				num3 = 93;
				break;
			case 22:
				P_0.FillRectangle(new XBrush(d8gyZXnz5m1y5iiw1dIF4.HiBnzLvMJQc), rect7);
				num7 = 170;
				goto IL_0005;
			case 30:
				xBrush4 = base.Theme.ClusterNeutralBidAskBrush;
				brush = xBrush4;
				goto case 63;
			case 45:
				P_0.DrawString(rect: new Rect(rect5.Left + rect5.Width / 2.0 - P_2.qOJnuFOtqYg / 2.0, rect5.Top, P_2.qOJnuFOtqYg, rect5.Height), text: (string)W0Xj2UbttECO5feKGUVN(0x32DEA4F1 ^ 0x32DA85DB), font: P_2.yoknuu2ELyt, brush: base.Theme.ClusterTextBrush);
				num36 = P_2.qOJnuFOtqYg / 2.0;
				num3 = 156;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d49d1aa54d194934871b103e21669e22 != 0)
				{
					num3 = 65;
				}
				break;
			case 167:
				goto IL_049b;
			case 178:
				if (flag8 && flag6)
				{
					goto case 41;
				}
				goto IL_26ca;
			case 129:
				num6 = Math.Min(P_2.QfInz2KpKYU, Math.Abs(rawClusterItem.Delta));
				num3 = 42;
				break;
			case 124:
				brush = base.Theme.ClusterTextBrush;
				num3 = 27;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6d472511f0d246a693dc7622dda5f390 == 0)
				{
					num3 = 64;
				}
				break;
			case 40:
				if (num44 >= num41 && (double)num44 > (double)num43 * num34)
				{
					num3 = 188;
					break;
				}
				if (num43 >= num41)
				{
					num3 = 2;
					break;
				}
				goto IL_1ccc;
			case 166:
				if (P_2.qOJnuFOtqYg + 4.0 < rect5.Width)
				{
					num3 = 45;
					break;
				}
				goto case 156;
			case 35:
				num46 = (long)(t4mHOrbUhCfMoEoDkkbX(IHc6d8bUwtHnTqaLvNDH(cpI9r4xqdTB()), base.Canvas.Rect.Bottom) / UhtjVEbtZxO5x0nNH1Dx(base.DataProvider));
				num31 = Math.Min(P_1.High, num31 + 1);
				num46 = Math.Max(hx9tT7btT6uDeYpqmuqL(P_1), num46 - 1);
				maxValues = P_1.MaxValues;
				num10 = num31;
				num3 = 70;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a849a254fa6841d5989e377890b7578f == 0)
				{
					num3 = 142;
				}
				break;
			case 174:
				num24 = Math.Min(P_2.kbWnzHuOgBw, rawClusterItem.Bid);
				num3 = 154;
				break;
			case 101:
				if (!gawpg6bTxmCmJYey2I0Y(num9))
				{
					num3 = 50;
					break;
				}
				goto case 81;
			case 73:
				num18 = 5;
				num28 = 1;
				flag3 = rawClusterItem.Volume >= P_2.s67nz9oCZGJ;
				num3 = 161;
				break;
			case 70:
				if (rect7.Width > rect8.Width)
				{
					num3 = 168;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7070f82fb97740909616ccb4e69409c5 == 0)
					{
						num3 = 85;
					}
					break;
				}
				goto IL_211c;
			case 65:
				xColor = base.Theme.ClusterDeltaMinusColor;
				num3 = 136;
				break;
			case 56:
				if (flag13)
				{
					num3 = 112;
					break;
				}
				rect9 = new Rect(rect6.Right - num11, rect6.Top, num11, rect6.Height);
				goto IL_2ee4;
			case 96:
				if (P_2.jRInzNcceFv)
				{
					num3 = 128;
					break;
				}
				goto IL_0486;
			case 100:
				if (flag3 || flag2)
				{
					num3 = 86;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_51aff79eb7764aeaade80ae2d6638ab5 == 0)
					{
						num3 = 90;
					}
					break;
				}
				num15 = 0;
				goto IL_2fcc;
			case 80:
				flag12 = true;
				num42 = Math.Min(P_2.QfInz2KpKYU, Math.Abs(N1Pnf3bUu17ER1xpWR8O(rawClusterItem)));
				num11 = rect5.Width / (double)P_2.QfInz2KpKYU * (double)num42;
				num9 = double.NaN;
				if (rawClusterItem.Delta >= 0)
				{
					xColor = LK4RW4bUzCTlsEJ7laoC(base.Theme);
					xBrush7 = new XBrush(xColor.ChangeOpacity(num42, P_2.QfInz2KpKYU, qWeYdxbUpbmgW6DUY18o(base.Theme)));
					goto IL_2e63;
				}
				num3 = 25;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ac6a9a8fc5c94cd6833091a6efebb474 == 0)
				{
					num3 = 65;
				}
				break;
			case 64:
				xBrush5 = (XBrush)MjWq8ZbUA8ltTTVRtmeX(base.Theme);
				num3 = 28;
				break;
			case 106:
				goto IL_099c;
			case 190:
				num9 = double.NaN;
				num3 = 99;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a337f255b1bd4e8290c28001e28630dc != 0)
				{
					num3 = 44;
				}
				break;
			case 134:
				xBrush5 = xBrush2;
				goto case 74;
			case 41:
				text = mH99V5Vg5Cc(rawClusterItem.Bid, P_2.Round);
				goto IL_26ca;
			case 19:
				if (flag3)
				{
					FYZIRQbTLhodeP3tJkmg(P_0, xBrush4, rect7);
					num3 = 96;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dfd8fb340d494755970617a38d3a8729 == 0)
					{
						num3 = 52;
					}
					break;
				}
				goto IL_211c;
			case 165:
				if (rawClusterItem.Ask != num14)
				{
					num3 = 133;
					break;
				}
				num23 = 1;
				goto IL_2f5b;
			case 136:
				xBrush7 = new XBrush(xColor.ChangeOpacity(num42, P_2.QfInz2KpKYU, base.Theme.ChartBackColor));
				goto IL_2e63;
			case 76:
				value3 = RvrSVubtyeJxuWF7wHyF(P_2.Cernz0EgckQ, rawClusterItem.Trades);
				num11 = rect6.Width;
				num9 = rect4.Width;
				num7 = 163;
				goto IL_0005;
			case 42:
				num11 = rect6.Width / (double)P_2.XSTnuziHlxS * (double)num8;
				num7 = 171;
				goto IL_0005;
			case 31:
				flag4 = h1a1lcbTi8pJIH5Mo5CR(rawClusterItem) >= evr9VzPFX3p.MinValue2;
				num3 = 139;
				break;
			case 127:
			case 140:
				if (P_2.KwBnzDPHQZd)
				{
					enumerator = B1J9VLAewQ1(P_2.eBdnz44CrCj, P_2.s7unuCGVyQQ, kwCy1QbTnfcl1KZPBVH8(rawClusterItem), num28).GetEnumerator();
					num7 = 110;
					goto IL_0005;
				}
				goto case 38;
			case 102:
				num18 = 2;
				num28 = 1;
				num3 = 158;
				break;
			case 5:
				flag12 = true;
				num12 = RvrSVubtyeJxuWF7wHyF(P_2.XSTnuziHlxS, rawClusterItem.Volume);
				num3 = 111;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2aa1113717a74eb69caa8952fdc78508 != 0)
				{
					num3 = 81;
				}
				break;
			case 177:
				xBrush5 = xBrush2;
				num3 = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f10da6c70e49485dae21f57ce3741184 == 0)
				{
					num3 = 74;
				}
				break;
			case 142:
			{
				if (num10 < num46)
				{
					return;
				}
				int num47 = (int)SXlNTDbtwj0C56ClRwuK(this, (double)num10 * P_2.YTXnuKOC1lk - P_2.YTXnuKOC1lk / 2.0);
				num22 = Math.Max((double)num47 - num2, 1.0);
				num21 = num2;
				num2 = num47;
				num7 = 18;
				goto IL_0005;
			}
			case 110:
				try
				{
					while (enumerator.MoveNext())
					{
						XBrush current2 = enumerator.Current;
						P_0.FillRectangle(current2, rect3);
						int num39 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1db4437ae4614880b2ad46efdc78cb73 != 0)
						{
							num39 = 0;
						}
						switch (num39)
						{
						}
					}
				}
				finally
				{
					((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
				}
				goto case 38;
			case 28:
				flag = false;
				flag13 = false;
				flag12 = false;
				num3 = 113;
				break;
			case 172:
				num9 = rect4.Width;
				num3 = 11;
				break;
			case 93:
				try
				{
					while (enumerator.MoveNext())
					{
						XBrush current = enumerator.Current;
						FYZIRQbTLhodeP3tJkmg(P_0, current, rect7);
					}
				}
				finally
				{
					((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
				}
				goto IL_211c;
			case 184:
				flag2 = rawClusterItem.Trades >= P_2.psbnzBHbgaI;
				goto IL_14aa;
			case 62:
			{
				if (d8gyZXnz5m1y5iiw1dIF2 != null)
				{
					brush = new XBrush(d8gyZXnz5m1y5iiw1dIF2.HfFnze2YjU0);
				}
				D8gyZXnz5m1y5iiw1dIF d8gyZXnz5m1y5iiw1dIF3 = vTJ9VesTG0u(P_2.hcQnzb4ilbk, rawClusterItem, 3);
				if (d8gyZXnz5m1y5iiw1dIF3 != null)
				{
					xBrush5 = new XBrush(d8gyZXnz5m1y5iiw1dIF3.HfFnze2YjU0);
				}
				goto IL_0486;
			}
			case 48:
				xBrush2 = new XBrush(xColor.ChangeOpacity(num17, P_2.kbWnzHuOgBw, base.Theme.ChartBackColor));
				num18 = 4;
				num28 = 3;
				num3 = 130;
				break;
			case 97:
				rect2 = default(Rect);
				num31 = (long)(t4mHOrbUhCfMoEoDkkbX(cpI9r4xqdTB().ybUnYpBPWvT(), pr2IDnbt81xmsDnTdNh7(base.Canvas).Top) / base.DataProvider.Step);
				num3 = 35;
				break;
			case 118:
				xBrush4 = (XBrush)cD149dbUFy3O2HDx6cA1(base.Theme);
				xBrush2 = base.Theme.ClusterTradesBrush;
				num3 = 102;
				break;
			case 10:
				if ((int)rect7.Y == (int)rect8.Y)
				{
					num3 = 70;
					break;
				}
				goto case 168;
			case 179:
				num9 = rect4.Width;
				num3 = 159;
				break;
			case 90:
				num15 = (evr9VzPFX3p.ShowMaximum ? 1 : 0);
				goto IL_2fcc;
			case 85:
				text2 = mH99V5Vg5Cc(rawClusterItem.Ask, P_2.Round);
				goto IL_23f2;
			case 130:
				flag3 = rawClusterItem.Bid >= P_2.JexnzYY6iOg;
				num3 = 148;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_51aff79eb7764aeaade80ae2d6638ab5 != 0)
				{
					num3 = 139;
				}
				break;
			case 182:
				if (flag2 && flag4 && flag7)
				{
					rect10 = new Rect(rect4.Left + 1.0 + num36, rect4.Top, rect4.Width - 2.0 - num36, rect4.Height);
					num3 = 96;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b3744d11c0b24c8d993b100cbb22f9e7 != 0)
					{
						num3 = 144;
					}
					break;
				}
				goto case 72;
			case 114:
				xBrush4 = new XBrush(xColor.ChangeOpacity(value2, P_2.XSTnuziHlxS, base.Theme.ChartBackColor));
				xColor = base.Theme.ClusterTradesColor;
				xBrush2 = new XBrush(xColor.ChangeOpacity(value3, P_2.Cernz0EgckQ, base.Theme.ChartBackColor));
				num18 = 2;
				num3 = 3;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2039997ab6194b398d07bcb5d664c971 == 0)
				{
					num3 = 12;
				}
				break;
			case 103:
				if (P_2.X1tnupPKJ6Q)
				{
					num3 = 101;
					break;
				}
				goto case 81;
			case 82:
				num9 = nkhZRFbUHb2k7Sat25WR(num9, 1.0);
				num3 = 141;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1bb232d361564d93b9a5d5e53983bdb3 != 0)
				{
					num3 = 70;
				}
				break;
			case 55:
				num11 = rect6.Width / (double)P_2.kbWnzHuOgBw * (double)num16;
				num9 = rect4.Width / (double)P_2.kbWnzHuOgBw * (double)num17;
				num3 = 58;
				break;
			case 163:
				xColor = l38bF9bTanYsgd1U0yYI(base.Theme);
				num3 = 114;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8a9257c2b61741afa02a8ceb1f69ad69 == 0)
				{
					num3 = 59;
				}
				break;
			case 75:
				if (P_2.X1tnupPKJ6Q)
				{
					if (double.IsNaN(num11))
					{
						num3 = 173;
						break;
					}
					goto case 88;
				}
				goto case 78;
			case 152:
				flag4 = (double)MtqBeqbTDCwJtCsR0lYd(rawClusterItem) >= num13;
				num14 = Math.Max(maxValues.MaxAsk, maxValues.MaxBid);
				num3 = 165;
				break;
			case 88:
				P_0.DrawRectangle(base.Theme.ClusterCellBorderPen, new Rect(rect6.Right - nkhZRFbUHb2k7Sat25WR(num11, 1.0), rect6.Y, nkhZRFbUHb2k7Sat25WR(num11 - 1.0, 1.0), Math.Max(rect6.Height - 1.0, 1.0)));
				num3 = 78;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1bb232d361564d93b9a5d5e53983bdb3 != 0)
				{
					num3 = 25;
				}
				break;
			case 6:
				if (N1Pnf3bUu17ER1xpWR8O(rawClusterItem) < 0)
				{
					xColor = base.Theme.ClusterDeltaMinusColor;
					xBrush = new XBrush(xColor.ChangeOpacity(num6, P_2.QfInz2KpKYU, base.Theme.ChartBackColor));
					goto IL_2e00;
				}
				xColor = base.Theme.ClusterDeltaPlusColor;
				num7 = 183;
				goto IL_0005;
			case 135:
				num8 = RvrSVubtyeJxuWF7wHyF(P_2.XSTnuziHlxS, rawClusterItem.Volume);
				num3 = 42;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1b729872d4424497a28393432ab4c541 != 0)
				{
					num3 = 129;
				}
				break;
			case 39:
				num28 = 1;
				flag3 = lJ83FGbUJnC2IkvWd4xP(rawClusterItem) >= P_2.s67nz9oCZGJ;
				num7 = 24;
				goto IL_0005;
			case 128:
				d8gyZXnz5m1y5iiw1dIF4 = vTJ9VesTG0u(P_2.hcQnzb4ilbk, rawClusterItem, num18);
				if (d8gyZXnz5m1y5iiw1dIF4 != null)
				{
					num3 = 22;
					break;
				}
				goto case 170;
			case 16:
				if (!flag3)
				{
					num3 = 119;
					break;
				}
				goto case 122;
			case 3:
				xBrush6 = new XBrush(xColor.ChangeOpacity(value5, P_2.QfInz2KpKYU, base.Theme.ChartBackColor));
				goto IL_2e3d;
			case 144:
				hTG0jEbTXpGBZc12DhdJ(P_0, text2, P_2.yoknuu2ELyt, xBrush5, rect10, XTextAlignment.Left);
				num3 = 22;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d4badf00eaf04a4c91e3397f36a429cf != 0)
				{
					num3 = 72;
				}
				break;
			case 72:
				if (flag3 && !flag5)
				{
					num3 = 75;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7d3c6a8bf09f4ec887f577858231a719 != 0)
					{
						num3 = 56;
					}
					break;
				}
				goto case 78;
			case 21:
			case 26:
			case 67:
			case 89:
			case 123:
			case 126:
			case 145:
			case 186:
				goto IL_14aa;
			case 84:
				flag2 = rawClusterItem.Ask >= P_2.JexnzYY6iOg;
				goto IL_14aa;
			case 23:
				goto IL_158c;
			case 20:
				num11 = rect6.Width;
				num3 = 179;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fb3e1155cc384cc2a7c812423a76ea76 == 0)
				{
					num3 = 142;
				}
				break;
			case 180:
			{
				IRawClusterItem item2 = P_1.GetItem(rawClusterItem.Price + 1);
				if (item2 == null)
				{
					if (P_2.q7Dnu3Ck9ZT)
					{
						num3 = 7;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_57c2433b06714a1299d736aebe42caa2 != 0)
						{
							num3 = 3;
						}
						break;
					}
					goto IL_2b94;
				}
				num43 = (evr9VzPFX3p.BidAskImbalanceTrades ? item2.AskTrades : item2.Ask);
				num3 = 6;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d4c083a65c1546b8a09c928a8c95e140 != 0)
				{
					num3 = 40;
				}
				break;
			}
			case 159:
				xColor = l38bF9bTanYsgd1U0yYI(base.Theme);
				xBrush4 = new XBrush(xColor.ChangeOpacity(value7, P_2.XSTnuziHlxS, base.Theme.ChartBackColor));
				num7 = 143;
				goto IL_0005;
			case 94:
				goto IL_1617;
			case 54:
				num4 = (et5fR7bTjPGhLt5y6e91(evr9VzPFX3p) ? 1 : 0);
				goto IL_2fbe;
			case 109:
				P_0.FillRectangle(xBrush2, rect3);
				num3 = 34;
				break;
			case 154:
				num25 = Math.Min(P_2.kbWnzHuOgBw, MtqBeqbTDCwJtCsR0lYd(rawClusterItem));
				num7 = 68;
				goto IL_0005;
			case 34:
				if (P_2.jRInzNcceFv)
				{
					d8gyZXnz5m1y5iiw1dIF = vTJ9VesTG0u(P_2.hcQnzb4ilbk, rawClusterItem, num28);
					if (d8gyZXnz5m1y5iiw1dIF != null)
					{
						num3 = 105;
						break;
					}
					goto case 127;
				}
				num3 = 140;
				break;
			case 92:
				num28 = 3;
				num3 = 57;
				break;
			case 104:
				rect8 = default(Rect);
				num3 = 97;
				break;
			case 168:
				rect8 = rect7;
				num3 = 6;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2aa1113717a74eb69caa8952fdc78508 == 0)
				{
					num3 = 19;
				}
				break;
			case 162:
				if (!(rect3.Width > rect2.Width))
				{
					goto case 38;
				}
				goto IL_2854;
			case 7:
				num11 = double.NaN;
				goto IL_2b94;
			case 112:
				rect9 = new Rect(rect5.Left, rect5.Top, num11, rect5.Height);
				goto IL_2ee4;
			case 47:
			{
				IRawClusterItem item = P_1.GetItem(rawClusterItem.Price - 1);
				if (item == null)
				{
					num3 = 32;
					break;
				}
				num32 = (evr9VzPFX3p.BidAskImbalanceTrades ? item.BidTrades : item.Bid);
				num3 = 176;
				break;
			}
			case 27:
				xColor = base.Theme.ClusterVolumeColor;
				xBrush4 = new XBrush(xColor.ChangeOpacity(num40, P_2.XSTnuziHlxS, qWeYdxbUpbmgW6DUY18o(base.Theme)));
				num3 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2039997ab6194b398d07bcb5d664c971 == 0)
				{
					num3 = 44;
				}
				break;
			case 81:
				if (!((flag3 || flag2) && flag5))
				{
					goto case 16;
				}
				goto case 71;
			case 189:
				flag11 = Math.Abs(rawClusterItem.Delta) == Math.Max(maxValues.MaxDelta, Math.Abs(maxValues.MinDelta));
				num3 = 132;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b3744d11c0b24c8d993b100cbb22f9e7 == 0)
				{
					num3 = 56;
				}
				break;
			case 71:
				if (!P_2.X1tnupPKJ6Q)
				{
					goto case 16;
				}
				if (!double.IsNaN(num11))
				{
					num3 = 150;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ba87d68105604f98a891a0549ef4b7f9 != 0)
					{
						num3 = 21;
					}
					break;
				}
				num45 = rect5.Width;
				goto IL_2f93;
			case 131:
				flag5 = false;
				goto IL_2d2a;
			case 32:
			case 79:
				if (P_2.q7Dnu3Ck9ZT)
				{
					num9 = double.NaN;
				}
				goto IL_14aa;
			case 38:
				text = "";
				text2 = "";
				flag8 = false;
				num3 = 138;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5350e02b39f542f78529ac5e3c3f8ec6 == 0)
				{
					num3 = 47;
				}
				break;
			case 33:
				rect4 = new Rect(rect6.Right + 1.0, num21, (int)(P_2.v3TnumakUEq / 2.0), nkhZRFbUHb2k7Sat25WR(num22 + P_2.EOcnuPAGkSA, 1.0));
				num3 = 124;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c7e1deb64093431d91d263a2e49f884b == 0)
				{
					num3 = 30;
				}
				break;
			case 164:
				flag10 = false;
				flag11 = false;
				num3 = 59;
				break;
			case 83:
				xBrush2 = base.Theme.ClusterAskBrush;
				num18 = 4;
				num3 = 14;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_35216e71f4e34e739f4a05a1213f3579 == 0)
				{
					num3 = 92;
				}
				break;
			case 74:
				if (P_2.q7Dnu3Ck9ZT)
				{
					num9 = double.NaN;
					num3 = 16;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2039997ab6194b398d07bcb5d664c971 == 0)
					{
						num3 = 89;
					}
					break;
				}
				goto IL_14aa;
			case 99:
				xColor = l38bF9bTanYsgd1U0yYI(base.Theme);
				xBrush4 = new XBrush(xColor.ChangeOpacity(num12, P_2.XSTnuziHlxS, base.Theme.ChartBackColor));
				goto IL_14aa;
			case 36:
				value6 = RvrSVubtyeJxuWF7wHyF(P_2.kbWnzHuOgBw, MtqBeqbTDCwJtCsR0lYd(rawClusterItem));
				if (rawClusterItem.Bid > MtqBeqbTDCwJtCsR0lYd(rawClusterItem))
				{
					num11 = rect6.Width;
					num9 = double.NaN;
					num3 = 46;
					break;
				}
				goto case 120;
			case 157:
				flag2 = Oua4jcbT2uyVXOCtLBm3(N1Pnf3bUu17ER1xpWR8O(rawClusterItem)) >= P_2.Gapnza9HpFZ;
				num3 = 145;
				break;
			case 122:
				num5 = (evr9VzPFX3p.ShowMaximum ? 1 : 0);
				goto IL_2f9b;
			case 4:
				xBrush4 = new XBrush(xColor.ChangeOpacity(num8, P_2.XSTnuziHlxS, base.Theme.ChartBackColor));
				num3 = 6;
				break;
			case 120:
				num11 = double.NaN;
				num3 = 172;
				break;
			case 86:
				if (flag8 && flag6)
				{
					text = mH99V5Vg5Cc(lTWPtWbT40thIDnu3VTf(rawClusterItem), P_2.Round);
				}
				if (flag4 && flag7)
				{
					text2 = mH99V5Vg5Cc(MtqBeqbTDCwJtCsR0lYd(rawClusterItem), P_2.Round);
				}
				goto IL_23f2;
			case 9:
				num28 = 1;
				flag3 = rawClusterItem.Volume >= P_2.s67nz9oCZGJ;
				num3 = 157;
				break;
			case 11:
				xColor = base.Theme.ClusterAskColor;
				xBrush2 = new XBrush(xColor.ChangeOpacity(value6, P_2.kbWnzHuOgBw, base.Theme.ChartBackColor));
				goto IL_1268;
			default:
				P_0.DrawRectangle(base.Theme.ClusterCellBorderMaxPen, new Rect(rect6.X, rect6.Y, Math.Max(rect6.Width - 1.0, 1.0), Math.Max(rect6.Height - 1.0, 1.0)));
				goto IL_2909;
			case 146:
				num9 = rect4.Width / (double)P_2.Cernz0EgckQ * (double)num38;
				num3 = 118;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44265f4417e640c7a760a59a950624e5 != 0)
				{
					num3 = 107;
				}
				break;
			case 150:
				num45 = num11;
				goto IL_2f93;
			case 98:
				num41 *= P_2.n5Rnz130BFd;
				goto IL_2924;
			case 155:
				_ = 21;
				num3 = 178;
				break;
			case 153:
				num9 = rect4.Width / (double)P_2.QfInz2KpKYU * (double)num26;
				xBrush4 = (XBrush)cD149dbUFy3O2HDx6cA1(base.Theme);
				xBrush2 = (XBrush)((rawClusterItem.Delta >= 0) ? base.Theme.ClusterDeltaPlusBrush : wSg9HrbTlvUkjRDrqSWD(base.Theme));
				num18 = 5;
				num28 = 1;
				num3 = 66;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03df70ea72bf4e3e81ab05550292a7c9 != 0)
				{
					num3 = 23;
				}
				break;
			case 160:
				num34 = (double)evr9VzPFX3p.BidAskImbalanceRatio / 100.0;
				num35 = evr9VzPFX3p.MinValue;
				num41 = aZSA1XbTN4jJFqpw3977(evr9VzPFX3p);
				num3 = 37;
				break;
			case 113:
				num11 = rect6.Width;
				xBrush4 = QIX9VmYrFEt;
				num3 = 175;
				break;
			case 51:
				flag3 = rawClusterItem.Bid >= P_2.JexnzYY6iOg;
				flag2 = MtqBeqbTDCwJtCsR0lYd(rawClusterItem) >= P_2.JexnzYY6iOg;
				num3 = 126;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_859c6249cb0f4f11b2da29d1228ce418 == 0)
				{
					num3 = 50;
				}
				break;
			case 171:
				num9 = rect4.Width / (double)P_2.QfInz2KpKYU * (double)num6;
				num3 = 8;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0aea3f4dc28f4bcb92a1f998dc5afbed == 0)
				{
					num3 = 29;
				}
				break;
			case 143:
				if (rawClusterItem.Delta < 0)
				{
					xColor = base.Theme.ClusterDeltaMinusColor;
					xBrush3 = new XBrush(xColor.ChangeOpacity(value, P_2.QfInz2KpKYU, base.Theme.ChartBackColor));
					goto IL_2dda;
				}
				xColor = LK4RW4bUzCTlsEJ7laoC(base.Theme);
				num3 = 73;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8c53e9716bd4846babfdefcdb92a575 == 0)
				{
					num3 = 87;
				}
				break;
			case 185:
				edtk2gbUgfliJIh880MA(P_0, PrCvwkbTBqrUlmT575pY(base.Theme), new Rect(rect5.X, rect5.Y, Math.Max(rect5.Width - 1.0, 1.0), Math.Max(rect5.Height - 1.0, 1.0)));
				goto case 91;
			case 2:
				if ((double)num43 > (double)num44 * num34)
				{
					num3 = 12;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_aab13e7d663746898a6666b7303ea6c2 == 0)
					{
						num3 = 30;
					}
					break;
				}
				goto IL_1ccc;
			case 176:
				if (num33 >= num41)
				{
					num3 = 151;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f40a817752724303a7406a720886b183 == 0)
					{
						num3 = 99;
					}
					break;
				}
				goto IL_0bed;
			case 170:
				if (clusterViewPreset != ClusterViewPreset.BidAsk && clusterViewPreset != ClusterViewPreset.BidAskVolumeProfile && clusterViewPreset != ClusterViewPreset.BidAskDeltaProfile)
				{
					if (d8gyZXnz5m1y5iiw1dIF4 != null)
					{
						brush = new XBrush(d8gyZXnz5m1y5iiw1dIF4.HfFnze2YjU0);
					}
					goto IL_0486;
				}
				d8gyZXnz5m1y5iiw1dIF2 = vTJ9VesTG0u(P_2.hcQnzb4ilbk, rawClusterItem, 4);
				num3 = 62;
				break;
			case 25:
				num18 = 0;
				num3 = 108;
				break;
			case 14:
				xColor = base.Theme.ClusterDeltaMinusColor;
				num7 = 3;
				goto IL_0005;
			case 138:
				flag4 = false;
				flag9 = false;
				num3 = 164;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1db4437ae4614880b2ad46efdc78cb73 == 0)
				{
					num3 = 80;
				}
				break;
			case 108:
				num28 = 0;
				flag3 = true;
				flag2 = true;
				rawClusterItem2 = P_1.GetItem(num10);
				if (rawClusterItem2 == null)
				{
					num3 = 52;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_aab13e7d663746898a6666b7303ea6c2 != 0)
					{
						num3 = 44;
					}
					break;
				}
				goto IL_2db4;
			case 50:
				P_0.DrawRectangle((XPen)A2u34ebTcON44E7t6cvO(base.Theme), new Rect(rect4.X, rect4.Y, nkhZRFbUHb2k7Sat25WR(num9 - 1.0, 1.0), nkhZRFbUHb2k7Sat25WR(rect4.Height - 1.0, 1.0)));
				num3 = 81;
				break;
			case 125:
				text2 = Hi99VSMfIpu(rawClusterItem.Trades, P_2.Round);
				num3 = 43;
				break;
			case 24:
				flag2 = rawClusterItem.Trades >= P_2.psbnzBHbgaI;
				num3 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fb3e1155cc384cc2a7c812423a76ea76 != 0)
				{
					num3 = 67;
				}
				break;
			case 29:
				xColor = l38bF9bTanYsgd1U0yYI(base.Theme);
				num3 = 4;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fa74d46e0c824e0b89c71deca0488611 == 0)
				{
					num3 = 4;
				}
				break;
			case 151:
				if ((double)num33 > (double)num32 * num34)
				{
					num3 = 47;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2088b9a28522490e83dc44062c40a7c0 != 0)
					{
						num3 = 117;
					}
					break;
				}
				goto IL_0bed;
			case 181:
				if ((double)num32 > (double)num33 * num34)
				{
					xBrush2 = (XBrush)zv36GNbTSHsXsvpMjT6Z(base.Theme);
					num3 = 177;
					break;
				}
				goto IL_1a53;
			case 58:
				xBrush4 = new XBrush(base.Theme.ClusterBidColor.ChangeOpacity(num16, P_2.kbWnzHuOgBw, base.Theme.ChartBackColor));
				xColor = base.Theme.ClusterAskColor;
				num3 = 48;
				break;
			case 1:
				flag12 = true;
				num3 = 61;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0fb8c8dbf8424ce68f439b7b66291a33 == 0)
				{
					num3 = 57;
				}
				break;
			case 46:
				xColor = base.Theme.ClusterBidColor;
				xBrush4 = new XBrush(xColor.ChangeOpacity(value4, P_2.kbWnzHuOgBw, base.Theme.ChartBackColor));
				goto IL_1268;
			case 116:
				goto IL_23dc;
			case 43:
			case 77:
				goto IL_23f2;
			case 161:
				flag2 = Math.Abs(rawClusterItem.Delta) >= P_2.Gapnza9HpFZ;
				num3 = 26;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8ebd61b38044e13aca9bf7790883fb0 != 0)
				{
					num3 = 21;
				}
				break;
			case 61:
				num20 = RvrSVubtyeJxuWF7wHyF(P_2.kbWnzHuOgBw, rawClusterItem.Bid);
				num3 = 5;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_68b6172210394c1b93f49e43376ff3af == 0)
				{
					num3 = 13;
				}
				break;
			case 44:
				xColor = base.Theme.ClusterTradesColor;
				xBrush2 = new XBrush(xColor.ChangeOpacity(num30, P_2.Cernz0EgckQ, qWeYdxbUpbmgW6DUY18o(base.Theme)));
				num18 = 2;
				num7 = 39;
				goto IL_0005;
			case 158:
				flag3 = rawClusterItem.Volume >= P_2.s67nz9oCZGJ;
				num3 = 110;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_239772330c1f4196be911d4f334efb05 != 0)
				{
					num3 = 184;
				}
				break;
			case 105:
				FYZIRQbTLhodeP3tJkmg(P_0, new XBrush(d8gyZXnz5m1y5iiw1dIF.HiBnzLvMJQc), rect3);
				xBrush5 = new XBrush(d8gyZXnz5m1y5iiw1dIF.HfFnze2YjU0);
				num3 = 127;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a93c63471a5d4726b3bdf40a69cdb422 == 0)
				{
					num3 = 112;
				}
				break;
			case 188:
				xBrush4 = base.Theme.ClusterStrongBidBrush;
				brush = xBrush4;
				num3 = 63;
				break;
			case 17:
				if (!(num21 - num22 > base.Canvas.Rect.Bottom))
				{
					num3 = 147;
					break;
				}
				goto case 91;
			case 115:
				num29 = rawClusterItem.Bid;
				goto IL_2e77;
			case 18:
				if (!(num21 + num22 < pr2IDnbt81xmsDnTdNh7(base.Canvas).Top))
				{
					num3 = 17;
					break;
				}
				goto case 91;
			case 63:
				if (P_2.q7Dnu3Ck9ZT)
				{
					num11 = double.NaN;
				}
				goto IL_2b94;
			case 12:
				num28 = 1;
				flag3 = lJ83FGbUJnC2IkvWd4xP(rawClusterItem) >= P_2.s67nz9oCZGJ;
				flag2 = h1a1lcbTi8pJIH5Mo5CR(rawClusterItem) >= P_2.psbnzBHbgaI;
				goto IL_14aa;
			case 139:
				flag10 = rawClusterItem.Volume == maxValues.MaxVolume;
				flag11 = h1a1lcbTi8pJIH5Mo5CR(rawClusterItem) == VWJFNFbUCdjatxwMQgnS(maxValues);
				if (flag8 && flag6)
				{
					text = mH99V5Vg5Cc(rawClusterItem.Volume, P_2.Round);
				}
				if (!(flag4 && flag7))
				{
					num3 = 77;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ff2c70a81f2141b98b88fc10875a3726 != 0)
					{
						num3 = 17;
					}
					break;
				}
				goto case 125;
			case 107:
				num27 = Math.Min(P_2.XSTnuziHlxS, rawClusterItem.Volume);
				num3 = 95;
				break;
			case 95:
				num26 = Math.Min(P_2.QfInz2KpKYU, Math.Abs(N1Pnf3bUu17ER1xpWR8O(rawClusterItem)));
				num11 = rect6.Width / (double)P_2.XSTnuziHlxS * (double)num27;
				num3 = 153;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1c0cedb54d2b44a7af3d63420e8a1767 == 0)
				{
					num3 = 79;
				}
				break;
			case 156:
				if (flag3 && flag8 && flag6)
				{
					rect = new Rect(rect6.Left + 1.0, rect6.Top, rect6.Width - 2.0 - num36, rect6.Height);
					num3 = 66;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0fb8c8dbf8424ce68f439b7b66291a33 != 0)
					{
						num3 = 187;
					}
					break;
				}
				goto case 182;
			case 57:
				flag3 = rawClusterItem.Bid >= P_2.JexnzYY6iOg;
				num3 = 84;
				break;
			case 68:
				num11 = rect6.Width / (double)P_2.kbWnzHuOgBw * (double)num24;
				num9 = rect4.Width / (double)P_2.kbWnzHuOgBw * (double)num25;
				xBrush4 = (XBrush)wpxvhrbTbTi8r9vxDCpC(base.Theme);
				num3 = 83;
				break;
			case 133:
				num23 = ((lTWPtWbT40thIDnu3VTf(rawClusterItem) == num14) ? 1 : 0);
				goto IL_2f5b;
			case 147:
				rect5 = new Rect(num + 1.0, num21, P_2.v3TnumakUEq, Math.Max(num22 + P_2.EOcnuPAGkSA, 1.0));
				rect6 = new Rect(num + 1.0, num21, (int)(P_2.v3TnumakUEq / 2.0), Math.Max(num22 + P_2.EOcnuPAGkSA, 1.0));
				num3 = 33;
				break;
			case 15:
				value4 = Math.Min(P_2.kbWnzHuOgBw, lTWPtWbT40thIDnu3VTf(rawClusterItem));
				num3 = 36;
				break;
			case 69:
				num35 *= P_2.n5Rnz130BFd;
				num3 = 98;
				break;
			case 141:
				if (!(num9 >= 1.0))
				{
					goto case 38;
				}
				rect3 = new Rect(rect4.Left, rect4.Top, num9, rect4.Height);
				if ((int)rect3.Y == (int)rect2.Y)
				{
					num3 = 162;
					break;
				}
				goto IL_2854;
			case 91:
				num10--;
				goto case 142;
			case 137:
				num9 = rect4.Width / (double)P_2.kbWnzHuOgBw * (double)num19;
				num3 = 160;
				break;
			case 13:
				num19 = Math.Min(P_2.kbWnzHuOgBw, rawClusterItem.Ask);
				num11 = rect6.Width / (double)P_2.kbWnzHuOgBw * (double)num20;
				num3 = 137;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03c20a54a7dc45f8a5130d4984fa4aea == 0)
				{
					num3 = 38;
				}
				break;
			case 148:
				flag2 = rawClusterItem.Ask >= P_2.JexnzYY6iOg;
				goto IL_14aa;
			case 78:
			case 173:
				if (flag2)
				{
					num3 = 49;
					break;
				}
				goto case 81;
			case 169:
				goto IL_2b5a;
			case 8:
				goto IL_2b62;
			case 175:
				num9 = rect4.Width;
				xBrush2 = QIX9VmYrFEt;
				num3 = 18;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0b22b597497745f5ab911eaabff065eb == 0)
				{
					num3 = 25;
				}
				break;
			case 59:
				flag5 = false;
				flag6 = P_2.q7Dnu3Ck9ZT && rect6.Width > 4.0;
				flag7 = P_2.q7Dnu3Ck9ZT && rect4.Width > 4.0;
				num13 = (((SymbolBase)FvaQTLbUGwpDkN52KMRw(base.DataProvider)).IsDenomination ? ((double)evr9VzPFX3p.MinValue / (double)P_2.n5Rnz130BFd) : ((double)(evr9VzPFX3p.MinValue * P_2.n5Rnz130BFd)));
				switch (clusterViewPreset)
				{
				case ClusterViewPreset.VolumeTrade:
				case ClusterViewPreset.VolumeTradeProfile:
				case ClusterViewPreset.VolumeTradeHistogram:
					break;
				case ClusterViewPreset.BidAskLadder:
				case ClusterViewPreset.BidAskProfile:
				case ClusterViewPreset.BidAskHistogram:
					goto IL_158c;
				case ClusterViewPreset.VolumeDelta:
				case ClusterViewPreset.VolumeDeltaProfile:
				case ClusterViewPreset.VolumeDeltaHistogram:
					goto IL_23dc;
				default:
					goto IL_23f2;
				case ClusterViewPreset.BidAsk:
				case ClusterViewPreset.BidAskVolumeProfile:
				case ClusterViewPreset.BidAskDeltaProfile:
				case ClusterViewPreset.BidAskImbalance:
					goto IL_29e0;
				}
				flag8 = (double)rawClusterItem.Volume >= num13;
				num3 = 22;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d3afdd6ad27a4c3b87071f1be51e7ef3 != 0)
				{
					num3 = 31;
				}
				break;
			case 49:
				if (!flag5)
				{
					num3 = 103;
					break;
				}
				goto case 81;
			case 111:
				num11 = rect5.Width / (double)P_2.XSTnuziHlxS * (double)num12;
				num3 = 68;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9aa9dbd12b8a4a4ea59acea051cdddbf != 0)
				{
					num3 = 190;
				}
				break;
			case 121:
				goto IL_2d38;
			case 66:
				flag3 = lJ83FGbUJnC2IkvWd4xP(rawClusterItem) >= P_2.s67nz9oCZGJ;
				flag2 = Math.Abs(rawClusterItem.Delta) >= P_2.Gapnza9HpFZ;
				num3 = 123;
				break;
			case 117:
				xBrush2 = (XBrush)QvKJ9LbT5HPLt7quyyuc(base.Theme);
				num3 = 134;
				break;
			case 52:
				rawClusterItem2 = new RawClusterItem(num10);
				goto IL_2db4;
			case 87:
				xBrush3 = new XBrush(xColor.ChangeOpacity(value, P_2.QfInz2KpKYU, base.Theme.ChartBackColor));
				goto IL_2dda;
			case 183:
				xBrush = new XBrush(xColor.ChangeOpacity(num6, P_2.QfInz2KpKYU, qWeYdxbUpbmgW6DUY18o(base.Theme)));
				goto IL_2e00;
			case 60:
				text2 = mH99V5Vg5Cc(evr9VzPFX3p.DeltaHideSign ? Math.Abs(N1Pnf3bUu17ER1xpWR8O(rawClusterItem)) : rawClusterItem.Delta, P_2.Round);
				goto IL_23f2;
			case 187:
				P_0.DrawString(text, P_2.yoknuu2ELyt, brush, rect, flag ? XTextAlignment.Right : XTextAlignment.Left);
				num3 = 182;
				break;
			case 119:
				num5 = 0;
				goto IL_2f9b;
			case 53:
				{
					num4 = 0;
					goto IL_2fbe;
				}
				IL_2e00:
				xBrush2 = xBrush;
				num3 = 73;
				break;
				IL_2854:
				rect2 = rect3;
				if (flag2)
				{
					num3 = 109;
					break;
				}
				goto case 38;
				IL_1ccc:
				xBrush4 = (XBrush)MjWq8ZbUA8ltTTVRtmeX(base.Theme);
				goto case 63;
				IL_2fcc:
				if (((uint)num15 & (flag9 ? 1u : 0u)) == 0)
				{
					num3 = 91;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f40a817752724303a7406a720886b183 == 0)
					{
						num3 = 2;
					}
					break;
				}
				goto case 185;
				IL_29e0:
				flag8 = (double)rawClusterItem.Bid >= num13;
				num3 = 152;
				break;
				IL_26ca:
				if (flag4 && flag7)
				{
					num3 = 85;
					break;
				}
				goto IL_23f2;
				IL_049b:
				flag = true;
				num3 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6938a97537c94834bed9381eb4051eec == 0)
				{
					num3 = 0;
				}
				break;
				IL_23dc:
				flag8 = (double)lJ83FGbUJnC2IkvWd4xP(rawClusterItem) >= num13;
				flag4 = Oua4jcbT2uyVXOCtLBm3(rawClusterItem.Delta) >= NPsZ6obTeLoLX5baEWlD(evr9VzPFX3p) * P_2.n5Rnz130BFd;
				flag10 = lJ83FGbUJnC2IkvWd4xP(rawClusterItem) == maxValues.MaxVolume;
				num3 = 189;
				break;
				IL_2db4:
				rawClusterItem = (IRawClusterItem)rawClusterItem2;
				switch (clusterViewPreset)
				{
				case ClusterViewPreset.BidAskDeltaProfile:
					break;
				case ClusterViewPreset.BidAskImbalance:
					goto IL_049b;
				case ClusterViewPreset.VolumeTrade:
					goto IL_04b8;
				case ClusterViewPreset.VolumeDelta:
					goto IL_099c;
				case ClusterViewPreset.BidAskProfile:
					goto IL_0ae1;
				case ClusterViewPreset.BidAskLadder:
					goto IL_0f45;
				case ClusterViewPreset.VolumeTradeProfile:
					goto IL_112f;
				case ClusterViewPreset.Trades:
				case ClusterViewPreset.TradesProfile:
				case ClusterViewPreset.TradesHistogram:
				case ClusterViewPreset.TradesDeltaColored:
				case ClusterViewPreset.TradesProfileDeltaColored:
					goto IL_14aa;
				case ClusterViewPreset.BidAskHistogram:
					goto IL_1617;
				case ClusterViewPreset.BidAsk:
					goto IL_1e8a;
				case ClusterViewPreset.VolumeTradeHistogram:
					goto IL_1ff0;
				default:
					goto IL_2a82;
				case ClusterViewPreset.BidAskVolumeProfile:
					goto IL_2b5a;
				case ClusterViewPreset.VolumeDeltaHistogram:
					goto IL_2b62;
				case ClusterViewPreset.VolumeDeltaProfile:
					goto IL_2d38;
				}
				flag = true;
				flag13 = true;
				num3 = 80;
				break;
				IL_2d38:
				flag = true;
				num7 = 135;
				goto IL_0005;
				IL_2b62:
				flag = true;
				num3 = 107;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a337f255b1bd4e8290c28001e28630dc != 0)
				{
					num3 = 56;
				}
				break;
				IL_2b5a:
				flag = true;
				flag13 = true;
				num3 = 5;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f68538a410dc40459f303c1bac7938ac == 0)
				{
					num3 = 2;
				}
				break;
				IL_2a82:
				num3 = 186;
				break;
				IL_1ff0:
				flag = true;
				num37 = RvrSVubtyeJxuWF7wHyF(P_2.XSTnuziHlxS, rawClusterItem.Volume);
				num38 = RvrSVubtyeJxuWF7wHyF(P_2.Cernz0EgckQ, rawClusterItem.Trades);
				num11 = rect6.Width / (double)P_2.XSTnuziHlxS * (double)num37;
				num3 = 65;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7bbe761a662b44b5ba6c0923e11b90ae != 0)
				{
					num3 = 146;
				}
				break;
				IL_1e8a:
				flag = true;
				flag13 = true;
				flag12 = true;
				value5 = RvrSVubtyeJxuWF7wHyF(P_2.QfInz2KpKYU, Math.Abs(rawClusterItem.Delta));
				num11 = rect5.Width;
				num9 = double.NaN;
				if (N1Pnf3bUu17ER1xpWR8O(rawClusterItem) >= 0)
				{
					xColor = base.Theme.ClusterDeltaPlusColor;
					xBrush6 = new XBrush(xColor.ChangeOpacity(value5, P_2.QfInz2KpKYU, base.Theme.ChartBackColor));
					goto IL_2e3d;
				}
				num7 = 14;
				goto IL_0005;
				IL_112f:
				flag = true;
				num40 = RvrSVubtyeJxuWF7wHyF(P_2.XSTnuziHlxS, lJ83FGbUJnC2IkvWd4xP(rawClusterItem));
				num30 = Math.Min(P_2.Cernz0EgckQ, rawClusterItem.Trades);
				num11 = rect6.Width / (double)P_2.XSTnuziHlxS * (double)num40;
				num9 = rect4.Width / (double)P_2.Cernz0EgckQ * (double)num30;
				num3 = 27;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6b9913e777f24c1abc91fbc34d2bcc9c == 0)
				{
					num3 = 0;
				}
				break;
				IL_0f45:
				flag = true;
				num3 = 15;
				break;
				IL_0ae1:
				flag = true;
				num16 = Math.Min(P_2.kbWnzHuOgBw, lTWPtWbT40thIDnu3VTf(rawClusterItem));
				num17 = Math.Min(P_2.kbWnzHuOgBw, rawClusterItem.Ask);
				num3 = 21;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_53f0c1974ed349c3831704ecb4d3ce13 != 0)
				{
					num3 = 55;
				}
				break;
				IL_04b8:
				value2 = RvrSVubtyeJxuWF7wHyF(P_2.XSTnuziHlxS, lJ83FGbUJnC2IkvWd4xP(rawClusterItem));
				num3 = 35;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5b6218c32bbf4af5965485469fa12538 != 0)
				{
					num3 = 76;
				}
				break;
				IL_0bed:
				if (num32 >= num41)
				{
					num3 = 181;
					break;
				}
				goto IL_1a53;
				IL_1a53:
				xBrush2 = base.Theme.ClusterTextBrush;
				goto case 74;
				IL_2dda:
				xBrush2 = xBrush3;
				num18 = 5;
				num3 = 3;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5350e02b39f542f78529ac5e3c3f8ec6 != 0)
				{
					num3 = 9;
				}
				break;
				IL_2f5b:
				flag9 = (byte)num23 != 0;
				flag5 = true;
				if (clusterViewPreset == ClusterViewPreset.BidAskImbalance && !P_2.q7Dnu3Ck9ZT)
				{
					num3 = 131;
					break;
				}
				goto IL_2d2a;
				IL_2924:
				num18 = 4;
				num28 = 3;
				if (!evr9VzPFX3p.BidAskImbalanceTrades)
				{
					num3 = 115;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_35216e71f4e34e739f4a05a1213f3579 != 0)
					{
						num3 = 87;
					}
					break;
				}
				num29 = G3uq88bTkA8RFhvSMUu4(rawClusterItem);
				goto IL_2e77;
				IL_2d2a:
				if (clusterViewPreset != ClusterViewPreset.BidAsk && clusterViewPreset != ClusterViewPreset.BidAskVolumeProfile)
				{
					num3 = 155;
					break;
				}
				goto case 178;
				IL_2fbe:
				if (((uint)num4 & (flag11 ? 1u : 0u)) != 0)
				{
					P_0.DrawRectangle((XPen)PrCvwkbTBqrUlmT575pY(base.Theme), new Rect(rect4.X, rect4.Y, Math.Max(rect4.Width - 1.0, 1.0), Math.Max(rect4.Height - 1.0, 1.0)));
					num3 = 100;
					break;
				}
				goto case 100;
				IL_2e77:
				num44 = num29;
				if (num44 >= num35)
				{
					num7 = 180;
					goto IL_0005;
				}
				goto IL_2b94;
				IL_1268:
				num18 = 4;
				num28 = 3;
				num3 = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_43d123ebfe574af38268397bb0ae2d1a != 0)
				{
					num3 = 51;
				}
				break;
				IL_2b94:
				num33 = (evr9VzPFX3p.BidAskImbalanceTrades ? sysOklbT1bkSRZY25OBZ(rawClusterItem) : rawClusterItem.Ask);
				if (num33 >= num35)
				{
					num7 = 47;
					goto IL_0005;
				}
				goto IL_14aa;
				IL_2f93:
				num48 = num45;
				P_0.DrawRectangle(base.Theme.ClusterCellBorderPen, new Rect(rect5.X, rect5.Y, nkhZRFbUHb2k7Sat25WR(num48 - 1.0, 1.0), Math.Max(rect5.Height - 1.0, 1.0)));
				num7 = 16;
				goto IL_0005;
				IL_099c:
				value7 = RvrSVubtyeJxuWF7wHyF(P_2.XSTnuziHlxS, lJ83FGbUJnC2IkvWd4xP(rawClusterItem));
				value = Math.Min(P_2.QfInz2KpKYU, Oua4jcbT2uyVXOCtLBm3(N1Pnf3bUu17ER1xpWR8O(rawClusterItem)));
				num3 = 20;
				break;
				IL_23f2:
				num36 = 0.0;
				if ((flag3 || flag2) && flag12)
				{
					num3 = 100;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_495802897f05476f875528905eba9a89 == 0)
					{
						num3 = 166;
					}
					break;
				}
				goto case 156;
				IL_14aa:
				if (P_2.o1LnuJLdjKL >= 1.0 && !gawpg6bTxmCmJYey2I0Y(num11))
				{
					num11 = nkhZRFbUHb2k7Sat25WR(num11, 1.0);
				}
				if (num11 >= 1.0)
				{
					num3 = 56;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d9af442440454effa9efd8da8e33ec96 != 0)
					{
						num3 = 56;
					}
					break;
				}
				goto IL_211c;
				IL_2e63:
				xBrush4 = xBrush7;
				num3 = 21;
				break;
				IL_0005:
				num3 = num7;
				break;
				IL_0486:
				if (P_2.KwBnzDPHQZd)
				{
					num3 = 149;
					break;
				}
				goto IL_211c;
				IL_1617:
				flag = true;
				num3 = 174;
				break;
				IL_2f9b:
				if (((uint)num5 & (flag10 ? 1u : 0u)) != 0)
				{
					num3 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1a625a5fe3334df88082832236dff5be == 0)
					{
						num3 = 0;
					}
					break;
				}
				goto IL_2909;
				IL_211c:
				if (P_2.o1LnuJLdjKL >= 1.0 && !gawpg6bTxmCmJYey2I0Y(num9))
				{
					num3 = 28;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_84569ba2345a4be7ac2af6ab5d67eaf9 == 0)
					{
						num3 = 82;
					}
					break;
				}
				goto case 141;
				IL_2ee4:
				rect7 = rect9;
				num7 = 10;
				goto IL_0005;
				IL_158c:
				flag8 = (double)rawClusterItem.Bid >= num13;
				flag4 = (double)MtqBeqbTDCwJtCsR0lYd(rawClusterItem) >= num13;
				num49 = Math.Max(maxValues.MaxAsk, q11l5obTsifhqqKyuJW1(maxValues));
				flag10 = rawClusterItem.Bid == num49;
				flag11 = rawClusterItem.Ask == num49;
				num3 = 86;
				break;
				IL_2e3d:
				xBrush4 = xBrush6;
				goto IL_14aa;
				IL_2909:
				if (!flag2)
				{
					num3 = 53;
					break;
				}
				goto case 54;
			}
		}
	}

	private void qV49VNFV78v(DxVisualQueue P_0, IRawCluster P_1, me021enuViEjoFdJlZYV P_2)
	{
		int num = 2;
		int num2 = num;
		IRawClusterValueArea valueArea = default(IRawClusterValueArea);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 3:
			{
				double y = GetY((double)valueArea.Vah * P_2.YTXnuKOC1lk + P_2.YTXnuKOC1lk / 2.0) - 1.0;
				double y2 = GetY((double)valueArea.Val * P_2.YTXnuKOC1lk - P_2.YTXnuKOC1lk / 2.0) - 1.0;
				P_0.DrawLine(new XPen((XBrush)EkHBLgbTQENIsow0EuTY(base.Theme), 1, XDashStyle.Dash), new Point(P_2.CenterX - P_2.v3TnumakUEq / 2.0 + 1.0, y), new Point(P_2.CenterX + P_2.v3TnumakUEq / 2.0, y));
				tGbENrbUETc0FW9rtJta(P_0, new XPen((XBrush)EkHBLgbTQENIsow0EuTY(base.Theme), 1, XDashStyle.Dash), new Point(P_2.CenterX - P_2.v3TnumakUEq / 2.0 + 1.0, y2), new Point(P_2.CenterX + P_2.v3TnumakUEq / 2.0, y2));
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fce1ea768b8d4ccdb3b71310761c1e52 == 0)
				{
					num2 = 0;
				}
				break;
			}
			case 2:
				if (!evr9VzPFX3p.ShowValueArea)
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8b6bac13ae314900826ed96af7afc27b != 0)
					{
						num2 = 1;
					}
					break;
				}
				valueArea = P_1.GetValueArea(OpIDiAbTEm5TImllPd4U(evr9VzPFX3p));
				if (valueArea != null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dbdafa2a3c4c4a799fde97744d4aedd0 != 0)
					{
						num2 = 3;
					}
					break;
				}
				return;
			case 1:
				return;
			case 0:
				return;
			}
		}
	}

	private void M829Vk4rSqu(DxVisualQueue P_0, me021enuViEjoFdJlZYV P_1)
	{
		int num = 6;
		XPen xPen = default(XPen);
		XBrush brush = default(XBrush);
		ClusterBorderType clusterBorderType = default(ClusterBorderType);
		Rect rect = default(Rect);
		XBrush brush2 = default(XBrush);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 8:
					P_0.DrawLine(xPen, new Point(P_1.CenterX, P_1.aWdnuAaPRkF), new Point(P_1.CenterX, P_1.rB1nu7twWyg));
					return;
				case 6:
					if (evr9VzPFX3p.BorderType != ClusterBorderType.None)
					{
						num2 = 5;
						break;
					}
					return;
				case 7:
					xPen = new XPen(brush, evr9VzPFX3p.BorderWidth);
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_34c8a548a4724373aa05c97fa43f690a == 0)
					{
						num2 = 0;
					}
					break;
				default:
					clusterBorderType = XNP9pIbTdkOTKcbRHKJ2(evr9VzPFX3p);
					num2 = 3;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c7e1deb64093431d91d263a2e49f884b == 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					edtk2gbUgfliJIh880MA(P_0, xPen, rect);
					tGbENrbUETc0FW9rtJta(P_0, xPen, new Point(P_1.CenterX, P_1.aYpnuwO8Vos), new Point(P_1.CenterX, P_1.Qjbnu8cIx4T));
					num2 = 8;
					break;
				case 4:
					return;
				case 5:
				{
					brush = base.Theme.ClusterBorderBrush;
					if (evr9VzPFX3p.BorderType == ClusterBorderType.ColoredCandle || XNP9pIbTdkOTKcbRHKJ2(evr9VzPFX3p) == ClusterBorderType.ColoredBox)
					{
						brush = (XBrush)(P_1.Jf1nurJhVRO ? base.Theme.ClusterUpBarBrush : gAoLf4bTgrFpcli0SUnd(base.Theme));
					}
					using (List<IContainsConditions>.Enumerator enumerator = P_1.Conditions.GetEnumerator())
					{
						while (true)
						{
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 0;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fb3e1155cc384cc2a7c812423a76ea76 == 0)
								{
									num3 = 0;
								}
							}
							else
							{
								brush2 = enumerator.Current.GetBrush(P_1.s7unuCGVyQQ, P_1.Jf1nurJhVRO);
								num3 = 1;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cf96ea40632b4cc9a71884e2b5dceb8b == 0)
								{
									num3 = 1;
								}
							}
							switch (num3)
							{
							case 1:
								if (brush2 != null)
								{
									brush = brush2;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
					goto case 7;
				}
				case 3:
					if ((uint)(clusterBorderType - 1) <= 1u)
					{
						Rect rect2 = new Rect(P_1.CenterX - P_1.v3TnumakUEq / 2.0, P_1.aYpnuwO8Vos - 1.0, P_1.v3TnumakUEq + 1.0, P_1.rB1nu7twWyg - P_1.aYpnuwO8Vos + 1.0);
						P_0.DrawRectangle(xPen, rect2);
						return;
					}
					goto end_IL_0012;
				case 2:
					if ((uint)(clusterBorderType - 3) > 1u)
					{
						return;
					}
					rect = new Rect(P_1.CenterX - P_1.v3TnumakUEq / 2.0, P_1.Qjbnu8cIx4T, P_1.v3TnumakUEq + 1.0, Math.Max(P_1.aWdnuAaPRkF - P_1.Qjbnu8cIx4T, 1.0));
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8bfdb836a7624a05a8616bddcf22e146 == 0)
					{
						num2 = 1;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 2;
		}
	}

	private void ctQ9V10grm3(DxVisualQueue P_0, me021enuViEjoFdJlZYV P_1)
	{
		int num = 5;
		XBrush brush = default(XBrush);
		Rect rect = default(Rect);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				XBrush xBrush;
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 4:
					return;
				case 3:
				{
					using (List<IContainsConditions>.Enumerator enumerator = P_1.Conditions.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							while (true)
							{
								XBrush xBrush2 = (XBrush)ApZhqmbUdMtl8t2GdXNC(enumerator.Current, P_1.s7unuCGVyQQ, P_1.Jf1nurJhVRO);
								if (xBrush2 != null)
								{
									brush = xBrush2;
									int num3 = 0;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a337f255b1bd4e8290c28001e28630dc == 0)
									{
										num3 = 1;
									}
									switch (num3)
									{
									case 1:
										break;
									default:
										continue;
									}
								}
								break;
							}
						}
					}
					goto case 1;
				}
				case 5:
					if (evr9VzPFX3p.ShowDirMarker)
					{
						if (P_1.XwNnuhiXaoi <= 0.0)
						{
							num2 = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a849a254fa6841d5989e377890b7578f == 0)
							{
								num2 = 0;
							}
							continue;
						}
						rect = ((P_1.ColumnWidth < 3.0) ? new Rect(P_1.CenterX - 2.0, P_1.Qjbnu8cIx4T, P_1.XwNnuhiXaoi, Math.Max(P_1.aWdnuAaPRkF - P_1.Qjbnu8cIx4T, 1.0)) : new Rect(P_1.CenterX - P_1.v3TnumakUEq / 2.0 - P_1.XwNnuhiXaoi, P_1.Qjbnu8cIx4T, P_1.XwNnuhiXaoi, Math.Max(P_1.aWdnuAaPRkF - P_1.Qjbnu8cIx4T, 1.0)));
						if (P_1.Jf1nurJhVRO)
						{
							num2 = 2;
							continue;
						}
						xBrush = base.Theme.ClusterDownBarBrush;
						goto IL_025e;
					}
					num = 4;
					break;
				case 1:
					P_0.FillRectangle(brush, rect);
					return;
				case 2:
					{
						xBrush = base.Theme.ClusterUpBarBrush;
						goto IL_025e;
					}
					IL_025e:
					brush = xBrush;
					num = 3;
					break;
				}
				break;
			}
		}
	}

	private string mH99V5Vg5Cc(long P_0, int P_1)
	{
		return (string)zSvLADbT6tWthUcX9i7B(base.DataProvider.Symbol, P_0, P_1, i7ofx8bTR5W5IR0unWOw(evr9VzPFX3p));
	}

	private string Hi99VSMfIpu(long P_0, int P_1)
	{
		return (string)HFQ6p1bTMpUnqi8BRgZQ(FvaQTLbUGwpDkN52KMRw(base.DataProvider), P_0, P_1, i7ofx8bTR5W5IR0unWOw(evr9VzPFX3p));
	}

	private void tha9VxfdCO3(out long P_0, out long P_1, out long P_2, out long P_3, out long P_4)
	{
		int num = 11;
		int num2 = num;
		IRawClusterMaxValues maxValues2 = default(IRawClusterMaxValues);
		IRawCluster rawCluster2 = default(IRawCluster);
		IRawCluster rawCluster = default(IRawCluster);
		int num3 = default(int);
		int count = default(int);
		int num4 = default(int);
		IRawClusterMaxValues maxValues = default(IRawClusterMaxValues);
		ClusterProportionType clusterProportionType = default(ClusterProportionType);
		while (true)
		{
			switch (num2)
			{
			case 13:
				maxValues2 = rawCluster2.MaxValues;
				num2 = 6;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_390fe499a2cc4a5ca3d6279a99e6b610 != 0)
				{
					num2 = 16;
				}
				break;
			default:
				rawCluster = (IRawCluster)PpxyT5btUV5G1CSW8BO1(base.DataProvider, num3);
				if (rawCluster != null)
				{
					num2 = 4;
					break;
				}
				goto IL_03b1;
			case 16:
				P_0 = YsnkW2bU7HYwKPreqJIl(P_0, zpMesJbTOls0Jgjanqg0(maxValues2));
				num2 = 12;
				break;
			case 14:
				if (num3 >= count)
				{
					return;
				}
				goto default;
			case 15:
				num3 = 0;
				num2 = 13;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8c53e9716bd4846babfdefcdb92a575 == 0)
				{
					num2 = 14;
				}
				break;
			case 6:
				if (num4 >= base.Canvas.Count)
				{
					return;
				}
				rawCluster2 = (IRawCluster)PpxyT5btUV5G1CSW8BO1(base.DataProvider, eCgEWJbU5BVLFDmxw0Uo(base.Canvas, num4));
				num2 = 5;
				break;
			case 2:
				P_0 = Math.Max(P_0, maxValues.MaxVolume);
				num2 = 9;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_4aa3a79213674c27a6bc763076b8caed != 0)
				{
					num2 = 7;
				}
				break;
			case 8:
				P_4 = Math.Max(P_4, Math.Max(maxValues.MaxOpenPos, -maxValues.MinOpenPos));
				goto IL_03b1;
			case 1:
				switch (clusterProportionType)
				{
				default:
					return;
				case ClusterProportionType.VisibleBars:
					num4 = 0;
					num2 = 6;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_84569ba2345a4be7ac2af6ab5d67eaf9 != 0)
					{
						num2 = 3;
					}
					break;
				case ClusterProportionType.AllBars:
					count = base.DataProvider.Count;
					num2 = 15;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1693d43c67f14e0eba9f86b0171ecbd6 != 0)
					{
						num2 = 10;
					}
					break;
				case ClusterProportionType.CustomValue:
					P_0 = evr9VzPFX3p.ProportionCustomValue * base.DataProvider.Symbol.NOvnY43A4X4();
					P_1 = evr9VzPFX3p.ProportionCustomValue;
					P_2 = evr9VzPFX3p.ProportionCustomValue * n6xViEbUTvM9JsE6rGuP(base.DataProvider.Symbol);
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_de1b6b238ba046ff8910d780c42f0e95 == 0)
					{
						num2 = 7;
					}
					break;
				}
				break;
			case 3:
				P_4 = 0L;
				clusterProportionType = evr9VzPFX3p.ProportionType;
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_239772330c1f4196be911d4f334efb05 == 0)
				{
					num2 = 0;
				}
				break;
			case 10:
				P_1 = 0L;
				P_2 = 0L;
				P_3 = 0L;
				num2 = 3;
				break;
			case 12:
				P_1 = YsnkW2bU7HYwKPreqJIl(P_1, VWJFNFbUCdjatxwMQgnS(maxValues2));
				P_2 = YsnkW2bU7HYwKPreqJIl(P_2, Math.Max(maxValues2.MaxDelta, -lVhStobTYZFvafUNUMTP(maxValues2)));
				P_3 = Math.Max(P_3, Math.Max(maxValues2.MaxBid, maxValues2.MaxAsk));
				P_4 = Math.Max(P_4, Math.Max(maxValues2.MaxOpenPos, -owBRHJbTqKaIKB6721SW(maxValues2)));
				goto IL_021a;
			case 5:
				if (rawCluster2 != null)
				{
					num2 = 13;
					break;
				}
				goto IL_021a;
			case 7:
				P_3 = evr9VzPFX3p.ProportionCustomValue * base.DataProvider.Symbol.NOvnY43A4X4();
				P_4 = evr9VzPFX3p.ProportionCustomValue;
				return;
			case 9:
				P_1 = YsnkW2bU7HYwKPreqJIl(P_1, maxValues.MaxTrades);
				P_2 = Math.Max(P_2, Math.Max(maxValues.MaxDelta, -lVhStobTYZFvafUNUMTP(maxValues)));
				P_3 = Math.Max(P_3, Math.Max(q11l5obTsifhqqKyuJW1(maxValues), maxValues.MaxAsk));
				num2 = 8;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d4c083a65c1546b8a09c928a8c95e140 == 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				maxValues = rawCluster.MaxValues;
				num2 = 2;
				break;
			case 11:
				{
					P_0 = 0L;
					num2 = 10;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c1a63437a5bc4d139ae2c4a2f19ec947 == 0)
					{
						num2 = 10;
					}
					break;
				}
				IL_021a:
				num4++;
				goto case 6;
				IL_03b1:
				num3++;
				goto case 14;
			}
		}
	}

	public override object Clone()
	{
		qEcb3w9VvrqaZ6RgPZhq obj = new qEcb3w9VvrqaZ6RgPZhq();
		SMYoBNbTIhOljHt3RDvT(obj, PriceLinePosition);
		DI7HtsbTWZF4tttU2i6N(obj, PriceLineCustomColor);
		obj.PriceLineColor = PriceLineColor;
		obj.PriceLineWidth = PriceLineWidth;
		ggtAdebTtoCmlV3OKelG(obj, PriceLineStyle);
		CFa02RbTUPnoAfZJd8rv(obj, BarType);
		obj.BarWidth = BarWidth;
		obj.PriceType = PriceType;
		obj.LineWidth = LineWidth;
		return obj;
	}

	private static List<XBrush> B1J9VLAewQ1(List<IContainsSelection> P_0, int P_1, long P_2, int P_3)
	{
		List<XBrush> list = new List<XBrush>();
		foreach (IContainsSelection item in P_0)
		{
			XBrush selection = item.GetSelection(P_1, P_2, P_3);
			if (selection != null)
			{
				list.Add(selection);
			}
		}
		return list;
	}

	private D8gyZXnz5m1y5iiw1dIF vTJ9VesTG0u(List<D8gyZXnz5m1y5iiw1dIF> P_0, IRawClusterItem P_1, int P_2 = 0)
	{
		D8gyZXnz5m1y5iiw1dIF result = null;
		double num = (base.DataProvider.Symbol.IsDenomination ? base.DataProvider.Symbol.ContractValue : base.DataProvider.Symbol.SizeStep);
		foreach (D8gyZXnz5m1y5iiw1dIF item in P_0)
		{
			switch (item.ujrnzSm3Awj)
			{
			case ClusterFilterType.Volume:
			{
				double num6 = (double)P_1.Volume * num;
				if (P_2 != 1 && (!item.a8RnzXVwbA2 || num6 >= (double)item.BZKnzxXwCj0) && (!item.yf8nzc7gswU || num6 <= (double)item.MaxValue))
				{
					result = item;
				}
				break;
			}
			case ClusterFilterType.Trades:
				if (P_2 != 2 && (!item.a8RnzXVwbA2 || P_1.Trades >= item.BZKnzxXwCj0) && (!item.yf8nzc7gswU || P_1.Trades <= item.MaxValue))
				{
					result = item;
				}
				break;
			case ClusterFilterType.Bid:
			{
				double num4 = (double)P_1.Bid * num;
				if (P_2 != 3 && (!item.a8RnzXVwbA2 || num4 >= (double)item.BZKnzxXwCj0) && (!item.yf8nzc7gswU || num4 <= (double)item.MaxValue))
				{
					result = item;
				}
				break;
			}
			case ClusterFilterType.Ask:
			{
				double num5 = (double)P_1.Ask * num;
				if (P_2 != 4 && (!item.a8RnzXVwbA2 || num5 >= (double)item.BZKnzxXwCj0) && (!item.yf8nzc7gswU || num5 <= (double)item.MaxValue))
				{
					result = item;
				}
				break;
			}
			case ClusterFilterType.Delta:
			{
				double num3 = Math.Abs((double)P_1.Delta * num);
				if (P_2 != 5 && (!item.a8RnzXVwbA2 || num3 >= (double)item.BZKnzxXwCj0) && (!item.yf8nzc7gswU || num3 <= (double)item.MaxValue))
				{
					result = item;
				}
				break;
			}
			case ClusterFilterType.DeltaPlus:
			{
				double num7 = (double)P_1.Delta * num;
				if (P_2 != 5 && (!item.a8RnzXVwbA2 || num7 >= (double)item.BZKnzxXwCj0) && (!item.yf8nzc7gswU || num7 <= (double)item.MaxValue))
				{
					result = item;
				}
				break;
			}
			case ClusterFilterType.DeltaMinus:
			{
				double num2 = (double)P_1.Delta * num;
				if (P_2 != 5 && (!item.a8RnzXVwbA2 || 0.0 - num2 >= (double)item.BZKnzxXwCj0) && (!item.yf8nzc7gswU || 0.0 - num2 <= (double)item.MaxValue))
				{
					result = item;
				}
				break;
			}
			}
		}
		return result;
	}

	static qEcb3w9VvrqaZ6RgPZhq()
	{
		Rl0HBObTTgYNLo1ZiRm6();
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		QIX9VmYrFEt = new XBrush(VBMI3UbtILs3XS4Zp0uB(Colors.Transparent));
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7070f82fb97740909616ccb4e69409c5 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static decimal Qgth9rbtMXNkBS7lng2b(long P_0)
	{
		return P_0;
	}

	internal static decimal GVTixgbtOe1dSMnbBYrB(decimal P_0, decimal P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static Color CqDL5vbtqRvT3wNfEJCa(HeatmapTypes P_0, int P_1, int P_2)
	{
		return fGBEm2nuLBtKTXBsve7d.MwSnue8wF52(P_0, P_1, P_2);
	}

	internal static XColor VBMI3UbtILs3XS4Zp0uB(Color P_0)
	{
		return P_0;
	}

	internal static bool jD4RWBbtRWZlkCaoAW68()
	{
		return LD5ulhbtgAW99LZ8OxDC == null;
	}

	internal static qEcb3w9VvrqaZ6RgPZhq IXRhMObt6CI8pd4OgfkT()
	{
		return LD5ulhbtgAW99LZ8OxDC;
	}

	internal static void lLlYoQbtW7PI1d31Ggw0(object P_0, object P_1)
	{
		((IndicatorBase)P_0).OnPropertyChanged((string)P_1);
	}

	internal static object W0Xj2UbttECO5feKGUVN(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static object PpxyT5btUV5G1CSW8BO1(object P_0, int P_1)
	{
		return ((ypqMIv9maFM0tRwF0xMh)P_0).GetCluster(P_1);
	}

	internal static long hx9tT7btT6uDeYpqmuqL(object P_0)
	{
		return ((IRawCluster)P_0).Low;
	}

	internal static long RvrSVubtyeJxuWF7wHyF(long P_0, long P_1)
	{
		return Math.Min(P_0, P_1);
	}

	internal static double UhtjVEbtZxO5x0nNH1Dx(object P_0)
	{
		return ((ypqMIv9maFM0tRwF0xMh)P_0).Step;
	}

	internal static object q3DvdcbtVtoCkNGgtXcR(object P_0)
	{
		return ((IndicatorBase)P_0).Canvas;
	}

	internal static StockViewType cu18skbtCbtdIi1HguWH(object P_0)
	{
		return ((ChartSettings)P_0).StockViewType;
	}

	internal static void aT4n6QbtrAFm3scwRPms(object P_0)
	{
		((List<bcXA9Knu6oJtSapprNob>)P_0).Clear();
	}

	internal static int zUfh95btKlKgZqo391um(object P_0)
	{
		return ((ypqMIv9maFM0tRwF0xMh)P_0).Count;
	}

	internal static object WXdCBxbtm9IP8Mq69WxC(object P_0)
	{
		return ((ypqMIv9maFM0tRwF0xMh)P_0).d73l9JpDb23;
	}

	internal static int rYAm3sbthtS4HBVxrJqS(object P_0, DateTime P_1, int P_2)
	{
		return ((IChartCanvas)P_0).DateToIndex(P_1, P_2);
	}

	internal static double SXlNTDbtwj0C56ClRwuK(object P_0, double P_1)
	{
		return ((IndicatorBase)P_0).GetY(P_1);
	}

	internal static double IceOX4bt7SQJDh4njAZR(object P_0, int P_1)
	{
		return ((IndicatorBase)P_0).GetX(P_1);
	}

	internal static Rect pr2IDnbt81xmsDnTdNh7(object P_0)
	{
		return ((IChartCanvas)P_0).Rect;
	}

	internal static object h9iNW4btAtrn8nKAk8dC(object P_0)
	{
		return ((ChartTheme)P_0).OpenLongPositionBrush;
	}

	internal static void ALPcr2btPCIfrBpE9leg(object P_0, object P_1, Point P_2, double P_3, double P_4)
	{
		((DxVisualQueue)P_0).FillEllipse((XBrush)P_1, P_2, P_3, P_4);
	}

	internal static void N2bQHwbtJ6T1gTxkkIIX(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static bool Kp3PucbtFYlnVPmAlIOq(object P_0)
	{
		return ((dyykKj9sS7wbwJvEPZ4K)P_0).ShowExecutions;
	}

	internal static double J2ntFnbt3f4GdlTpKqYC(object P_0, long P_1)
	{
		return ((ypqMIv9maFM0tRwF0xMh)P_0).emBlnYovsAq(P_1);
	}

	internal static double vOTKUObtpRsAuNn9uZB1(object P_0)
	{
		return ((IChartCanvas)P_0).ColumnWidth;
	}

	internal static double y0E4BubtuMiIJBYLpVJt(double P_0, double P_1)
	{
		return Math.Min(P_0, P_1);
	}

	internal static void fA6DUQbtzK4WJ0UL0wjN(object P_0, object P_1, object P_2)
	{
		((DxVisualQueue)P_0).DrawPolygon((XPen)P_1, (Point[])P_2);
	}

	internal static object Jvh4wLbU0hxb29XtH0kN(object P_0)
	{
		return ((ChartTheme)P_0).SellTradeBrush;
	}

	internal static int MB760XbU2ErhspJElkXB(object P_0)
	{
		return ((List<bcXA9Knu6oJtSapprNob>)P_0).Count;
	}

	internal static double nkhZRFbUHb2k7Sat25WR(double P_0, double P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static object Wv4GssbUfKy43vVgibTY(object P_0)
	{
		return ((ChartTheme)P_0).ChartFontBrush;
	}

	internal static SymbolType BVldZgbU9WThcriun4YH(object P_0)
	{
		return ((ijsjhhnGTadfwpOyDdrx)P_0).Type;
	}

	internal static object LmUoT6bUnhOHEISfAy3L(object P_0)
	{
		return ((ijsjhhnGTadfwpOyDdrx)P_0).Name;
	}

	internal static object FvaQTLbUGwpDkN52KMRw(object P_0)
	{
		return ((ypqMIv9maFM0tRwF0xMh)P_0).Symbol;
	}

	internal static object dH4930bUYKHTYKqMObB0(object P_0)
	{
		return ((IChartCanvas)P_0).Theme;
	}

	internal static object oIju9BbUolW2LhZPlLg2(object P_0)
	{
		return ((IChartTheme)P_0).ChartFontBrush;
	}

	internal static int T8cBanbUv9XteB2vIH3X(object P_0)
	{
		return ((IChartCanvas)P_0).Start;
	}

	internal static long qpXFaFbUBjM5dq5Ao8au(object P_0)
	{
		return ((IRawCluster)P_0).Close;
	}

	internal static Color HKZtTSbUaGJHdlvPVykH()
	{
		return Colors.Black;
	}

	internal static Color E6FErEbUipyGskHG7I54(XColor P_0)
	{
		return P_0;
	}

	internal static XColor J6UyJZbUlBq1VSuF3siK(object P_0)
	{
		return ((ChartTheme)P_0).AreaLineColor;
	}

	internal static XColor dGhYudbU4y7ay4gmmrxD(object P_0)
	{
		return ((ChartTheme)P_0).ClusterDownBarColor;
	}

	internal static bool Le64BgbUDaF5HLuVkpu6(object P_0)
	{
		return ((qEcb3w9VvrqaZ6RgPZhq)P_0).PriceLineCustomColor;
	}

	internal static XColor UBTByrbUbt0dv93wmXDQ(object P_0)
	{
		return ((qEcb3w9VvrqaZ6RgPZhq)P_0).PriceLineColor;
	}

	internal static int kpMx3RbUNxlZww5qlrLj(object P_0)
	{
		return ((qEcb3w9VvrqaZ6RgPZhq)P_0).PriceLineWidth;
	}

	internal static int esdOSYbUkRLT7MvZBNVu(object P_0)
	{
		return ((qEcb3w9VvrqaZ6RgPZhq)P_0).BarWidth;
	}

	internal static IndicatorPriceType vEI6dRbU1Xto4DvGlVBc(object P_0)
	{
		return ((qEcb3w9VvrqaZ6RgPZhq)P_0).PriceType;
	}

	internal static int eCgEWJbU5BVLFDmxw0Uo(object P_0, int P_1)
	{
		return ((IChartCanvas)P_0).GetIndex(P_1);
	}

	internal static long iAHnNgbUS9p4IeuN1jb7(object P_0)
	{
		return ((IRawCluster)P_0).High;
	}

	internal static object nCpDJKbUxFC88PEpvOFw(object P_0)
	{
		return ((ChartTheme)P_0).LineBrush;
	}

	internal static object LOA5mIbULxODic3T7PgW(object P_0)
	{
		return ((List<Point>)P_0).ToArray();
	}

	internal static void yPK6ClbUeLWlSB3gB2hj(object P_0, object P_1, object P_2)
	{
		((DxVisualQueue)P_0).DrawLines((XPen)P_1, (Point[])P_2);
	}

	internal static object LI6FeYbUsZQs8595WFrb(object P_0)
	{
		return ((vJGfm5nYMCEZFuST02my)P_0).Indicators;
	}

	internal static bool OXUDM2bUXGPBBjK2Zx8v(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static double btZ8PabUcEDfERMivXg6(double P_0)
	{
		return Math.Ceiling(P_0);
	}

	internal static long KtCqd9bUjcSd6nOk1CTk(object P_0)
	{
		return ((IRawCluster)P_0).Open;
	}

	internal static void tGbENrbUETc0FW9rtJta(object P_0, object P_1, Point P_2, Point P_3)
	{
		((DxVisualQueue)P_0).DrawLine((XPen)P_1, P_2, P_3);
	}

	internal static int mGPMIbbUQpWmpa1cg6V3(object P_0)
	{
		return ((IChartCanvas)P_0).Count;
	}

	internal static object ApZhqmbUdMtl8t2GdXNC(object P_0, int P_1, bool P_2)
	{
		return ((IContainsConditions)P_0).GetBrush(P_1, P_2);
	}

	internal static void edtk2gbUgfliJIh880MA(object P_0, object P_1, Rect P_2)
	{
		((DxVisualQueue)P_0).DrawRectangle((XPen)P_1, P_2);
	}

	internal static object JIkQgTbUR2pLNtGndgWC(object P_0)
	{
		return ((ChartTheme)P_0).BarDownBarBrush;
	}

	internal static object GYxTgrbU6GhOcRYyuBW4(object P_0)
	{
		return ((ChartTheme)P_0).AreaLineBrush;
	}

	internal static int sybt83bUMwMZJX67SbqS(object P_0)
	{
		return ((KO34fu9L5FtbhDmWJ1ad)P_0).RoundValues;
	}

	internal static bool yxtofMbUOtpuxhFA0xTn(object P_0)
	{
		return ((KO34fu9L5FtbhDmWJ1ad)P_0).ShowDirMarker;
	}

	internal static int JZoXGhbUqltldevrBers(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static ChartCellViewType PhJyWFbUIBnAHq8yvVFk(object P_0)
	{
		return ((KO34fu9L5FtbhDmWJ1ad)P_0).CellType;
	}

	internal static bool JyPGBGbUWIeFZMunIEUK(object P_0)
	{
		return ((KO34fu9L5FtbhDmWJ1ad)P_0).ShowValues;
	}

	internal static object vxjutfbUtdfG16FaVQkU(object P_0)
	{
		return ((ChartSettings)P_0).ChartFont;
	}

	internal static int kVuJVobUUTyVykQPqtqQ(object P_0)
	{
		return ((KO34fu9L5FtbhDmWJ1ad)P_0).BackMinValue;
	}

	internal static long n6xViEbUTvM9JsE6rGuP(object P_0)
	{
		return ((ijsjhhnGTadfwpOyDdrx)P_0).NOvnY43A4X4();
	}

	internal static int seKn9SbUydsBTGYyg9wE(object P_0)
	{
		return ((KO34fu9L5FtbhDmWJ1ad)P_0).BackMinValue2;
	}

	internal static bool G00p8fbUZ5Fqxr73ms1q(object P_0)
	{
		return ((IRawCluster)P_0).IsUp;
	}

	internal static double ovvDGKbUVNIl8GKXkWgt(object P_0, int P_1)
	{
		return ((IChartCanvas)P_0).GetX(P_1);
	}

	internal static int VWJFNFbUCdjatxwMQgnS(object P_0)
	{
		return ((IRawClusterMaxValues)P_0).MaxTrades;
	}

	internal static long DP9TafbUrlvbWvYkl1xi(object P_0)
	{
		return ((IRawClusterMaxValues)P_0).MaxAsk;
	}

	internal static double sJSWqVbUKrGoMcTNEr62(object P_0)
	{
		return ((IChartCanvas)P_0).MaxY;
	}

	internal static ClusterViewPreset nsM5hWbUmUuOQvexdAuj(object P_0)
	{
		return ((KO34fu9L5FtbhDmWJ1ad)P_0).ClusterPreset;
	}

	internal static double t4mHOrbUhCfMoEoDkkbX(object P_0, double P_1)
	{
		return ((NMHchMnvtxgoKNmDEII2)P_0).rPGnvCy3AGu(P_1);
	}

	internal static object IHc6d8bUwtHnTqaLvNDH(object P_0)
	{
		return ((vJGfm5nYMCEZFuST02my)P_0).ybUnYpBPWvT();
	}

	internal static long YsnkW2bU7HYwKPreqJIl(long P_0, long P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static object fSoW1jbU85d1mI80w1Jb(object P_0)
	{
		return ((IRawCluster)P_0).MaxValues;
	}

	internal static object MjWq8ZbUA8ltTTVRtmeX(object P_0)
	{
		return ((ChartTheme)P_0).ClusterTextBrush;
	}

	internal static object hnuaxxbUPvuRUiIEpDgP(object P_0, long P_1)
	{
		return ((IRawCluster)P_0).GetItem(P_1);
	}

	internal static long lJ83FGbUJnC2IkvWd4xP(object P_0)
	{
		return ((IRawClusterItem)P_0).Volume;
	}

	internal static object cD149dbUFy3O2HDx6cA1(object P_0)
	{
		return ((ChartTheme)P_0).ClusterVolumeBrush;
	}

	internal static XColor spjTrtbU32UnA0xCQpUx(object P_0)
	{
		return ((ChartTheme)P_0).ClusterDeltaMinusColor;
	}

	internal static XColor qWeYdxbUpbmgW6DUY18o(object P_0)
	{
		return ((ChartTheme)P_0).ChartBackColor;
	}

	internal static long N1Pnf3bUu17ER1xpWR8O(object P_0)
	{
		return ((IRawClusterItem)P_0).Delta;
	}

	internal static XColor LK4RW4bUzCTlsEJ7laoC(object P_0)
	{
		return ((ChartTheme)P_0).ClusterDeltaPlusColor;
	}

	internal static object zGTuYMbT0NYEVJ2Aba0Y(object P_0)
	{
		return ((ChartTheme)P_0).ClusterTradesBrush;
	}

	internal static long Oua4jcbT2uyVXOCtLBm3(long P_0)
	{
		return Math.Abs(P_0);
	}

	internal static XColor znoJY9bTHGvjexYB0ojT(object P_0)
	{
		return ((ChartTheme)P_0).ClusterOpenIntPlusColor;
	}

	internal static long wv75gXbTfXFEwmrZJr0d(object P_0)
	{
		return ((IRawClusterItem)P_0).OpenPos;
	}

	internal static object i08bDLbT9VnZPb5Im3Ff(object P_0)
	{
		return ((ChartTheme)P_0).ClusterOpenIntPlusBrush;
	}

	internal static long kwCy1QbTnfcl1KZPBVH8(object P_0)
	{
		return ((IRawClusterItem)P_0).Price;
	}

	internal static long D94SP8bTGSpxS7bbwM6W(object P_0)
	{
		return ((KO34fu9L5FtbhDmWJ1ad)P_0).MinValue;
	}

	internal static long lVhStobTYZFvafUNUMTP(object P_0)
	{
		return ((IRawClusterMaxValues)P_0).MinDelta;
	}

	internal static bool zbSkKobToxAt2nHXhPCf(object P_0)
	{
		return ((KO34fu9L5FtbhDmWJ1ad)P_0).DeltaHideSign;
	}

	internal static long Sew83obTvEftY431syxx(object P_0)
	{
		return ((IRawClusterMaxValues)P_0).MaxOpenPos;
	}

	internal static object PrCvwkbTBqrUlmT575pY(object P_0)
	{
		return ((ChartTheme)P_0).ClusterCellBorderMaxPen;
	}

	internal static XColor l38bF9bTanYsgd1U0yYI(object P_0)
	{
		return ((ChartTheme)P_0).ClusterVolumeColor;
	}

	internal static int h1a1lcbTi8pJIH5Mo5CR(object P_0)
	{
		return ((IRawClusterItem)P_0).Trades;
	}

	internal static object wSg9HrbTlvUkjRDrqSWD(object P_0)
	{
		return ((ChartTheme)P_0).ClusterDeltaMinusBrush;
	}

	internal static long lTWPtWbT40thIDnu3VTf(object P_0)
	{
		return ((IRawClusterItem)P_0).Bid;
	}

	internal static long MtqBeqbTDCwJtCsR0lYd(object P_0)
	{
		return ((IRawClusterItem)P_0).Ask;
	}

	internal static object wpxvhrbTbTi8r9vxDCpC(object P_0)
	{
		return ((ChartTheme)P_0).ClusterBidBrush;
	}

	internal static int aZSA1XbTN4jJFqpw3977(object P_0)
	{
		return ((KO34fu9L5FtbhDmWJ1ad)P_0).BidAskImbalanceMinValue;
	}

	internal static int G3uq88bTkA8RFhvSMUu4(object P_0)
	{
		return ((IRawClusterItem)P_0).BidTrades;
	}

	internal static int sysOklbT1bkSRZY25OBZ(object P_0)
	{
		return ((IRawClusterItem)P_0).AskTrades;
	}

	internal static object QvKJ9LbT5HPLt7quyyuc(object P_0)
	{
		return ((ChartTheme)P_0).ClusterStrongAskBrush;
	}

	internal static object zv36GNbTSHsXsvpMjT6Z(object P_0)
	{
		return ((ChartTheme)P_0).ClusterNeutralBidAskBrush;
	}

	internal static bool gawpg6bTxmCmJYey2I0Y(double P_0)
	{
		return double.IsNaN(P_0);
	}

	internal static void FYZIRQbTLhodeP3tJkmg(object P_0, object P_1, Rect P_2)
	{
		((DxVisualQueue)P_0).FillRectangle((XBrush)P_1, P_2);
	}

	internal static long NPsZ6obTeLoLX5baEWlD(object P_0)
	{
		return ((KO34fu9L5FtbhDmWJ1ad)P_0).MinValue2;
	}

	internal static long q11l5obTsifhqqKyuJW1(object P_0)
	{
		return ((IRawClusterMaxValues)P_0).MaxBid;
	}

	internal static void hTG0jEbTXpGBZc12DhdJ(object P_0, object P_1, object P_2, object P_3, Rect P_4, XTextAlignment P_5)
	{
		((DxVisualQueue)P_0).DrawString((string)P_1, (XFont)P_2, (XBrush)P_3, P_4, P_5);
	}

	internal static object A2u34ebTcON44E7t6cvO(object P_0)
	{
		return ((ChartTheme)P_0).ClusterCellBorderPen;
	}

	internal static bool et5fR7bTjPGhLt5y6e91(object P_0)
	{
		return ((KO34fu9L5FtbhDmWJ1ad)P_0).ShowMaximum;
	}

	internal static int OpIDiAbTEm5TImllPd4U(object P_0)
	{
		return ((KO34fu9L5FtbhDmWJ1ad)P_0).ValueAreaPercent;
	}

	internal static object EkHBLgbTQENIsow0EuTY(object P_0)
	{
		return ((ChartTheme)P_0).ClusterValueAreaBrush;
	}

	internal static ClusterBorderType XNP9pIbTdkOTKcbRHKJ2(object P_0)
	{
		return ((KO34fu9L5FtbhDmWJ1ad)P_0).BorderType;
	}

	internal static object gAoLf4bTgrFpcli0SUnd(object P_0)
	{
		return ((ChartTheme)P_0).ClusterDownBarBrush;
	}

	internal static bool i7ofx8bTR5W5IR0unWOw(object P_0)
	{
		return ((KO34fu9L5FtbhDmWJ1ad)P_0).MinimizeValues;
	}

	internal static object zSvLADbT6tWthUcX9i7B(object P_0, long P_1, int P_2, bool P_3)
	{
		return ((ijsjhhnGTadfwpOyDdrx)P_0).FormatRawSize(P_1, P_2, P_3);
	}

	internal static object HFQ6p1bTMpUnqi8BRgZQ(object P_0, long P_1, int P_2, bool P_3)
	{
		return ((ijsjhhnGTadfwpOyDdrx)P_0).FormatTrades(P_1, P_2, P_3);
	}

	internal static long zpMesJbTOls0Jgjanqg0(object P_0)
	{
		return ((IRawClusterMaxValues)P_0).MaxVolume;
	}

	internal static long owBRHJbTqKaIKB6721SW(object P_0)
	{
		return ((IRawClusterMaxValues)P_0).MinOpenPos;
	}

	internal static void SMYoBNbTIhOljHt3RDvT(object P_0, PriceLinePosition P_1)
	{
		((qEcb3w9VvrqaZ6RgPZhq)P_0).PriceLinePosition = P_1;
	}

	internal static void DI7HtsbTWZF4tttU2i6N(object P_0, bool P_1)
	{
		((qEcb3w9VvrqaZ6RgPZhq)P_0).PriceLineCustomColor = P_1;
	}

	internal static void ggtAdebTtoCmlV3OKelG(object P_0, XDashStyle P_1)
	{
		((qEcb3w9VvrqaZ6RgPZhq)P_0).PriceLineStyle = P_1;
	}

	internal static void CFa02RbTUPnoAfZJd8rv(object P_0, PriceBarType P_1)
	{
		((qEcb3w9VvrqaZ6RgPZhq)P_0).BarType = P_1;
	}

	internal static void Rl0HBObTTgYNLo1ZiRm6()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}
}
