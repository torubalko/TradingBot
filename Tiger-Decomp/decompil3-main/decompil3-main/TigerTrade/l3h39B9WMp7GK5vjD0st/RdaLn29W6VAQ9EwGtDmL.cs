using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using ECOEgqlSad8NUJZ2Dr9n;
using MIA3eC2ZXsuRyAB0mjn;
using TiCeIH2IsQBNx4GCkaT;
using TigerTrade.Chart.Base;
using TigerTrade.Chart.Data;
using TigerTrade.Chart.Indicators.Common;
using TigerTrade.Chart.Indicators.Enums;
using TigerTrade.Chart.Indicators.List;
using TigerTrade.Dx;
using TigerTrade.Dx.Enums;
using TuAMtrl1Nd3XoZQQUXf0;

namespace l3h39B9WMp7GK5vjD0st;

[DataContract(Name = "HeatmapIndicator", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
[Indicator("Heatmap", "Heatmap", true, Type = typeof(RdaLn29W6VAQ9EwGtDmL))]
internal sealed class RdaLn29W6VAQ9EwGtDmL : IndicatorBase
{
	private static class qIGyeinpxXL7Q0onc9gO
	{
		private static readonly Dictionary<HeatmapTypes, BitmapImage> dr9npePVimt;

		private static readonly Dictionary<HeatmapTypes, List<Color>> tV7npsAAFqU;

		internal static qIGyeinpxXL7Q0onc9gO cjOnt5NWJ0wVml7GFZF4;

		static qIGyeinpxXL7Q0onc9gO()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8692846774e94af58ff2b2b243743e02 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 1:
				return;
			}
			dr9npePVimt = new Dictionary<HeatmapTypes, BitmapImage>
			{
				{
					HeatmapTypes.DarkToOrange,
					new BitmapImage(new Uri(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-490987856 ^ -491224474)))
				},
				{
					HeatmapTypes.DarkToRed,
					new BitmapImage(new Uri(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-520155535 ^ -520383729)))
				},
				{
					HeatmapTypes.Grayscale,
					new BitmapImage(new Uri(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x86EFEF6 ^ 0x86A60D6)))
				}
			};
			tV7npsAAFqU = new Dictionary<HeatmapTypes, List<Color>>();
			int num6 = default(int);
			int num4 = default(int);
			byte[] array = default(byte[]);
			List<Color> list = default(List<Color>);
			BitmapSource value = default(BitmapSource);
			int num3 = default(int);
			foreach (KeyValuePair<HeatmapTypes, BitmapImage> item2 in dr9npePVimt)
			{
				int num2 = 2;
				while (true)
				{
					switch (num2)
					{
					case 6:
						num6 = 4 * num4;
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a9d70160736846b58381afc3c46699f2 == 0)
						{
							num2 = 0;
						}
						continue;
					default:
					{
						byte num7 = array[num6 + 3];
						byte b = array[num6 + 2];
						byte b2 = array[num6 + 1];
						byte b3 = array[num6];
						Color item = EXPnTuNWuQkMHTlviCok(num7, b, b2, b3);
						list.Add(item);
						num4++;
						num2 = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a8990374f0e04177b45918e3dd7a2d4b == 0)
						{
							num2 = 1;
						}
						continue;
					}
					case 4:
						list = tV7npsAAFqU[item2.Key];
						value = item2.Value;
						num3 = value.PixelWidth * 4;
						array = new byte[value.PixelHeight * num3];
						num2 = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0b22b597497745f5ab911eaabff065eb == 0)
						{
							num2 = 7;
						}
						continue;
					case 3:
						break;
					case 1:
					case 5:
						if (num4 >= QBEMJlNWzY67H3TOLHpN(value))
						{
							num2 = 3;
							continue;
						}
						goto case 6;
					case 2:
						if (!tV7npsAAFqU.ContainsKey(item2.Key))
						{
							tV7npsAAFqU.Add(item2.Key, new List<Color>());
							goto case 4;
						}
						num2 = 4;
						continue;
					case 7:
					{
						Yt6LkoNWpVSDsm8AATAL(value, array, num3, 0);
						num4 = 0;
						int num5 = 5;
						num2 = num5;
						continue;
					}
					}
					break;
				}
			}
		}

		public static Color f3HnpLFWPNl(HeatmapTypes P_0, int P_1, int P_2)
		{
			if (P_1 == 0)
			{
				return Colors.Transparent;
			}
			List<Color> list = (tV7npsAAFqU.ContainsKey(P_0) ? tV7npsAAFqU[P_0] : null);
			if (list == null)
			{
				return Colors.Transparent;
			}
			int num = (int)((double)P_2 / 4.0);
			int num2 = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_390fe499a2cc4a5ca3d6279a99e6b610 != 0)
			{
				num2 = 1;
			}
			int num3 = default(int);
			while (true)
			{
				switch (num2)
				{
				case 3:
					num3 = 0;
					goto IL_00f6;
				case 1:
					num3 = Convert.ToInt32((decimal)(P_1 * (KFRmZxNt0EYFuMJ5dd8k(list) - 1 - num)) / 100m) + num;
					num2 = 2;
					break;
				case 2:
					if (num3 < 0)
					{
						num2 = 3;
						break;
					}
					goto IL_00f6;
				default:
					{
						num3 = KFRmZxNt0EYFuMJ5dd8k(list) - 1;
						goto IL_00a4;
					}
					IL_00a4:
					return list[num3];
					IL_00f6:
					if (num3 > KFRmZxNt0EYFuMJ5dd8k(list) - 1)
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_152544ed8bd2470d8638a522e4a24d02 != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto IL_00a4;
				}
			}
		}

		internal static void Yt6LkoNWpVSDsm8AATAL(object P_0, object P_1, int P_2, int P_3)
		{
			((BitmapSource)P_0).CopyPixels((Array)P_1, P_2, P_3);
		}

		internal static Color EXPnTuNWuQkMHTlviCok(byte P_0, byte P_1, byte P_2, byte P_3)
		{
			return Color.FromArgb(P_0, P_1, P_2, P_3);
		}

		internal static int QBEMJlNWzY67H3TOLHpN(object P_0)
		{
			return ((BitmapSource)P_0).PixelWidth;
		}

		internal static bool bm022KNWFSv2yoy0KEVp()
		{
			return cjOnt5NWJ0wVml7GFZF4 == null;
		}

		internal static qIGyeinpxXL7Q0onc9gO FRFpbSNW3Z7e4Ix5afCn()
		{
			return cjOnt5NWJ0wVml7GFZF4;
		}

		internal static int KFRmZxNt0EYFuMJ5dd8k(object P_0)
		{
			return ((List<Color>)P_0).Count;
		}
	}

	private class MqHwYSnpXcMfyLAMcuJU
	{
		public Dictionary<long, long> qWGnpca7Di7;

		public Dictionary<long, long> Ah4npjwgP0j;

		public Dictionary<long, long> QELnpE21VfM;

		public Dictionary<long, long> ERNnpQ8ZhsM;

		public long bsTnpdFKDUv;

		public long mbhnpgtRaHO;

		public long neKnpRe2IdT;

		public long R09np6C6LFS;

		private static MqHwYSnpXcMfyLAMcuJU Mby318Nt2kxn4IDVQ7cK;

		public MqHwYSnpXcMfyLAMcuJU()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			base._002Ector();
			Ah4npjwgP0j = new Dictionary<long, long>();
			ERNnpQ8ZhsM = new Dictionary<long, long>();
			qWGnpca7Di7 = new Dictionary<long, long>();
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8c53e9716bd4846babfdefcdb92a575 == 0)
			{
				num = 1;
			}
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 1:
					QELnpE21VfM = new Dictionary<long, long>();
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3cfcda862e0540cbb9abf65446a10635 == 0)
					{
						num = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}

		static MqHwYSnpXcMfyLAMcuJU()
		{
			DBYn8oNt98bFedUEICeJ();
		}

		internal static bool z1TamDNtHjgKmmcXtCqT()
		{
			return Mby318Nt2kxn4IDVQ7cK == null;
		}

		internal static MqHwYSnpXcMfyLAMcuJU J3f5XYNtfkAXtsiopngQ()
		{
			return Mby318Nt2kxn4IDVQ7cK;
		}

		internal static void DBYn8oNt98bFedUEICeJ()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}
	}

	private class pwPsc9npM9uqIaIf8mgR
	{
		public long cHsnpIg2vd2;

		public long MaxValue;

		public long yKPnpWt19xy;

		private DateTime cMHnptGK6Bo;

		private bool G2RnpUX5u6K;

		private int t1SnpTAOmXJ;

		private int u0Snpy0poQ7;

		internal static pwPsc9npM9uqIaIf8mgR FvoMreNtn4P5ApvfsV7m;

		public pwPsc9npM9uqIaIf8mgR()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			base._002Ector();
			G2RnpUX5u6K = true;
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f63752baa0064bcb85a726ea90a210dc != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		public void YHAnpOuhfYw(long P_0, long P_1, long P_2)
		{
			cHsnpIg2vd2 = P_0;
			MaxValue = P_1;
			yKPnpWt19xy = P_2;
			cMHnptGK6Bo = DateTime.Now;
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e38cca27b4f843e0acda58c2d2606b17 != 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					return;
				}
				G2RnpUX5u6K = false;
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_239772330c1f4196be911d4f334efb05 == 0)
				{
					num = 1;
				}
			}
		}

		public bool LbXnpqatTMx(IChartCanvas P_0)
		{
			if (qY7xYnNtvKmBQKkUZvF3(DateTime.Now - cMHnptGK6Bo, rb1FDkNto9nuf3pfquI3(10.0)))
			{
				G2RnpUX5u6K = true;
			}
			int num;
			if (P_0.Start == t1SnpTAOmXJ)
			{
				num = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a80f370f27d471fab60f042c9fa7b49 == 0)
				{
					num = 2;
				}
				goto IL_0009;
			}
			goto IL_0046;
			IL_0046:
			t1SnpTAOmXJ = P_0.Start;
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a337f255b1bd4e8290c28001e28630dc == 0)
			{
				num = 1;
			}
			goto IL_0009;
			IL_0009:
			while (true)
			{
				switch (num)
				{
				case 2:
					if (P_0.Stop != u0Snpy0poQ7)
					{
						break;
					}
					goto default;
				case 1:
					u0Snpy0poQ7 = PdcZslNtB69t4RdayIW2(P_0);
					G2RnpUX5u6K = true;
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ad0a44f3eae14332b41c0c5ef48d2cbb != 0)
					{
						num = 0;
					}
					continue;
				default:
					return G2RnpUX5u6K;
				}
				break;
			}
			goto IL_0046;
		}

		public void Clear()
		{
			G2RnpUX5u6K = true;
		}

		static pwPsc9npM9uqIaIf8mgR()
		{
			lhXbGJNtaiBcBfPPQYlr();
		}

		internal static bool D5Xq6KNtGJNbjmGpZSMf()
		{
			return FvoMreNtn4P5ApvfsV7m == null;
		}

		internal static pwPsc9npM9uqIaIf8mgR sbjaqTNtYtPyC7E2KHT4()
		{
			return FvoMreNtn4P5ApvfsV7m;
		}

		internal static TimeSpan rb1FDkNto9nuf3pfquI3(double P_0)
		{
			return TimeSpan.FromSeconds(P_0);
		}

		internal static bool qY7xYnNtvKmBQKkUZvF3(TimeSpan P_0, TimeSpan P_1)
		{
			return P_0 > P_1;
		}

		internal static int PdcZslNtB69t4RdayIW2(object P_0)
		{
			return ((IChartCanvas)P_0).Stop;
		}

		internal static void lhXbGJNtaiBcBfPPQYlr()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}
	}

	private int kNS9tGMPnWf;

	private bool B1F9tYphijt;

	private HeatmapTypes xHt9toXenkK;

	private int BAL9tvDl8dq;

	private IndicatorSettingsSlider eTA9tB1ktRZ;

	private long? HoQ9taXp7VE;

	private int C0q9tiJRv04;

	private IndicatorSettingsSlider Kyr9tlDQFVH;

	private long? YUC9t4eICUE;

	private int DQ59tDxqyl9;

	private IndicatorSettingsSlider U3D9tbU43Av;

	private int yxp9tNKRqxg;

	private IndicatorSettingsSlider h039tkpCbas;

	private int Ppc9t1g0ns5;

	private IndicatorSettingsSlider Y9r9t5HBhm5;

	private bool U8B9tSQ1M5P;

	private Dictionary<int, MqHwYSnpXcMfyLAMcuJU> GTq9txaHdcP;

	private int QAr9tLUcIWA;

	private pwPsc9npM9uqIaIf8mgR YhL9teBN1lp;

	internal static RdaLn29W6VAQ9EwGtDmL KgsxOObqafFA90rOWwwK;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.Bar;

	[T4IXj62qBfXCaxs2RI5("ChartIndicatorsParameters")]
	[bBo0Zd2ycQQr3LNHQf4("ChartIndicatorsHeatmapMarketDepthMaxLevels")]
	[DataMember(Name = "MaxDepth")]
	public int MaxDepth
	{
		get
		{
			return kNS9tGMPnWf;
		}
		set
		{
			num = Math.Max(0, num);
			int num2;
			if (num != kNS9tGMPnWf)
			{
				kNS9tGMPnWf = num;
				OnPropertyChanged((string)HHnb6Kbq4OEEFOL97KoJ(0x50C1C840 ^ 0x50C5AED6));
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d4badf00eaf04a4c91e3397f36a429cf == 0)
				{
					num2 = 0;
				}
			}
			else
			{
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ebf7ae5938c3406ea71c3b7147ea041c != 0)
				{
					num2 = 0;
				}
			}
			switch (num2)
			{
			case 1:
				YhL9teBN1lp?.Clear();
				break;
			case 0:
				break;
			}
		}
	}

	[bBo0Zd2ycQQr3LNHQf4("ChartIndicatorsHeatmapExtendMarketDepth")]
	[T4IXj62qBfXCaxs2RI5("ChartIndicatorsParameters")]
	[DataMember(Name = "ExtendDepth")]
	public bool ExtendDepth
	{
		get
		{
			return B1F9tYphijt;
		}
		set
		{
			if (flag == B1F9tYphijt)
			{
				return;
			}
			B1F9tYphijt = flag;
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1b729872d4424497a28393432ab4c541 == 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					return;
				}
				OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x50C1C840 ^ 0x50C5AEEA));
				pwPsc9npM9uqIaIf8mgR yhL9teBN1lp = YhL9teBN1lp;
				if (yhL9teBN1lp == null)
				{
					return;
				}
				yhL9teBN1lp.Clear();
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2e936b892f094d0a971af950fe8f46f7 != 0)
				{
					num = 1;
				}
			}
		}
	}

	[DataMember(Name = "HeatmapType")]
	[T4IXj62qBfXCaxs2RI5("ChartIndicatorsParameters")]
	[bBo0Zd2ycQQr3LNHQf4("ChartIndicatorsHeatmapColorMap")]
	public HeatmapTypes HeatmapType
	{
		get
		{
			return xHt9toXenkK;
		}
		set
		{
			if (heatmapTypes != xHt9toXenkK)
			{
				xHt9toXenkK = heatmapTypes;
				OnPropertyChanged((string)HHnb6Kbq4OEEFOL97KoJ(-225822163 ^ -225551127));
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1db4437ae4614880b2ad46efdc78cb73 == 0)
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

	[DataMember(Name = "LowerCutOff")]
	[Browsable(false)]
	public int LowerCutOff
	{
		get
		{
			return BAL9tvDl8dq;
		}
		set
		{
			num = Math.Max(0, uoySlXbqD8ngt2EyLjZ9(80, num));
			if (num == BAL9tvDl8dq)
			{
				return;
			}
			BAL9tvDl8dq = num;
			cOcvqibqb8cgUxB8pHqk(Lep9WrW5Rvr, BAL9tvDl8dq);
			OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x7F645F3C ^ 0x7F6039E2));
			int num2 = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_26fe5531b15948b7a2b6ffb2cd927204 == 0)
			{
				num2 = 1;
			}
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
				{
					pwPsc9npM9uqIaIf8mgR yhL9teBN1lp = YhL9teBN1lp;
					if (yhL9teBN1lp == null)
					{
						num2 = 2;
						break;
					}
					yhL9teBN1lp.Clear();
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dfd8fb340d494755970617a38d3a8729 == 0)
					{
						num2 = 0;
					}
					break;
				}
				case 0:
					return;
				case 2:
					return;
				}
			}
		}
	}

	[T4IXj62qBfXCaxs2RI5("ChartIndicatorsParameters")]
	[bBo0Zd2ycQQr3LNHQf4("ChartIndicatorsHeatmapLowerCutOffPercent")]
	public IndicatorSettingsSlider Lep9WrW5Rvr
	{
		get
		{
			IndicatorSettingsSlider indicatorSettingsSlider = eTA9tB1ktRZ;
			if (indicatorSettingsSlider == null)
			{
				IndicatorSettingsSlider obj = new IndicatorSettingsSlider(this, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1848952786 ^ -1848680720), LowerCutOff, 0.0, 80.0)
				{
					SmallChange = 1.0,
					LargeChange = 10.0,
					TickFrequency = 10.0
				};
				IndicatorSettingsSlider indicatorSettingsSlider2 = obj;
				eTA9tB1ktRZ = obj;
				indicatorSettingsSlider = indicatorSettingsSlider2;
			}
			return indicatorSettingsSlider;
		}
	}

	[bBo0Zd2ycQQr3LNHQf4("ChartIndicatorsHeatmapLowerCutOffVolume")]
	[T4IXj62qBfXCaxs2RI5("ChartIndicatorsParameters")]
	[DataMember(Name = "LowerCutOffFixed")]
	public long? LowerCutOffFixed
	{
		get
		{
			return HoQ9taXp7VE;
		}
		set
		{
			if (num.HasValue)
			{
				num = Math.Max(0L, num.Value);
			}
			if (num != HoQ9taXp7VE)
			{
				HoQ9taXp7VE = num;
				OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0xAD5B8B3 ^ 0xAD1DE4B));
				YhL9teBN1lp?.Clear();
			}
		}
	}

	[DataMember(Name = "UpperCutOff")]
	[Browsable(false)]
	public int UpperCutOff
	{
		get
		{
			return C0q9tiJRv04;
		}
		set
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					num3 = Math.Max(80, Math.Min(100, num3));
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8b8f48487ce54157a86b0385feea16a6 == 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					if (num3 == C0q9tiJRv04)
					{
						return;
					}
					C0q9tiJRv04 = num3;
					ABx9W8KAFch.Value = C0q9tiJRv04;
					kae8LlbqNM07jP5ts8ct(this, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x20B584D2 ^ 0x20B1E3CE));
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7d3c6a8bf09f4ec887f577858231a719 != 0)
					{
						num2 = 0;
					}
					break;
				default:
				{
					pwPsc9npM9uqIaIf8mgR yhL9teBN1lp = YhL9teBN1lp;
					if (yhL9teBN1lp != null)
					{
						yhL9teBN1lp.Clear();
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_43d123ebfe574af38268397bb0ae2d1a != 0)
					{
						num2 = 3;
					}
					break;
				}
				case 3:
					return;
				}
			}
		}
	}

	[bBo0Zd2ycQQr3LNHQf4("ChartIndicatorsHeatmapUpperCutOffPercent")]
	[T4IXj62qBfXCaxs2RI5("ChartIndicatorsParameters")]
	public IndicatorSettingsSlider ABx9W8KAFch
	{
		get
		{
			IndicatorSettingsSlider indicatorSettingsSlider = Kyr9tlDQFVH;
			if (indicatorSettingsSlider == null)
			{
				IndicatorSettingsSlider indicatorSettingsSlider2 = new IndicatorSettingsSlider(this, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x1EFE0A28 ^ 0x1EFA6D34), UpperCutOff, 80.0, 100.0);
				z9fWJobqkavlO1aQK7Km(indicatorSettingsSlider2, 1.0);
				l5m6Gtbq1M3sf1yLhIrR(indicatorSettingsSlider2, 5.0);
				indicatorSettingsSlider2.TickFrequency = 5.0;
				IndicatorSettingsSlider indicatorSettingsSlider3 = indicatorSettingsSlider2;
				Kyr9tlDQFVH = indicatorSettingsSlider2;
				indicatorSettingsSlider = indicatorSettingsSlider3;
			}
			return indicatorSettingsSlider;
		}
	}

	[T4IXj62qBfXCaxs2RI5("ChartIndicatorsParameters")]
	[bBo0Zd2ycQQr3LNHQf4("ChartIndicatorsHeatmapUpperCutOffVolume")]
	[DataMember(Name = "UpperCutOffFixed")]
	public long? UpperCutOffFixed
	{
		get
		{
			return YUC9t4eICUE;
		}
		set
		{
			if (num.HasValue)
			{
				num = Math.Max(0L, num.Value);
			}
			if (num != YUC9t4eICUE)
			{
				YUC9t4eICUE = num;
				OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x315AB1E3 ^ 0x315ED6D5));
				YhL9teBN1lp?.Clear();
			}
		}
	}

	[DataMember(Name = "Contrast")]
	[Browsable(false)]
	public int Contrast
	{
		get
		{
			return DQ59tDxqyl9;
		}
		set
		{
			num = v6fYWlbq5Wfa1Li2nhhh(0, Math.Min(100, num));
			if (num == DQ59tDxqyl9)
			{
				return;
			}
			DQ59tDxqyl9 = num;
			int num2 = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_239772330c1f4196be911d4f334efb05 != 0)
			{
				num2 = 1;
			}
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					GrD9Wp1QKXh.Value = DQ59tDxqyl9;
					OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1461949456 ^ -1462235990));
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ebf7ae5938c3406ea71c3b7147ea041c == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	[T4IXj62qBfXCaxs2RI5("ChartIndicatorsParameters")]
	[bBo0Zd2ycQQr3LNHQf4("ChartIndicatorsHeatmapContrast")]
	public IndicatorSettingsSlider GrD9Wp1QKXh
	{
		get
		{
			IndicatorSettingsSlider indicatorSettingsSlider = U3D9tbU43Av;
			if (indicatorSettingsSlider == null)
			{
				IndicatorSettingsSlider obj = new IndicatorSettingsSlider(this, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-82860344 ^ -83115630), Contrast, 0.0, 100.0)
				{
					SmallChange = 1.0,
					LargeChange = 25.0,
					TickFrequency = 25.0
				};
				IndicatorSettingsSlider indicatorSettingsSlider2 = obj;
				U3D9tbU43Av = obj;
				indicatorSettingsSlider = indicatorSettingsSlider2;
			}
			return indicatorSettingsSlider;
		}
	}

	[Browsable(false)]
	[DataMember(Name = "LargeSizeHighLight")]
	public int LargeSizeHighLight
	{
		get
		{
			return yxp9tNKRqxg;
		}
		set
		{
			int num = 1;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 3:
						return;
					default:
						if (num3 == yxp9tNKRqxg)
						{
							return;
						}
						yxp9tNKRqxg = num3;
						num2 = 2;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8a9257c2b61741afa02a8ceb1f69ad69 == 0)
						{
							num2 = 2;
						}
						continue;
					case 1:
						num3 = Math.Max(0, uoySlXbqD8ngt2EyLjZ9(100, num3));
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ad0a44f3eae14332b41c0c5ef48d2cbb != 0)
						{
							num2 = 0;
						}
						continue;
					case 2:
					{
						I5L9t2UJgC4.Value = yxp9tNKRqxg;
						OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1311293279 ^ -1311561777));
						pwPsc9npM9uqIaIf8mgR yhL9teBN1lp = YhL9teBN1lp;
						if (yhL9teBN1lp == null)
						{
							return;
						}
						yhL9teBN1lp.Clear();
						num = 3;
						break;
					}
					}
					break;
				}
			}
		}
	}

	[bBo0Zd2ycQQr3LNHQf4("ChartIndicatorsHeatmapContrastBigSizes")]
	[T4IXj62qBfXCaxs2RI5("ChartIndicatorsParameters")]
	public IndicatorSettingsSlider I5L9t2UJgC4
	{
		get
		{
			IndicatorSettingsSlider indicatorSettingsSlider = h039tkpCbas;
			if (indicatorSettingsSlider == null)
			{
				IndicatorSettingsSlider obj = new IndicatorSettingsSlider(this, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1192989954 ^ -1193276016), LargeSizeHighLight, 0.0, 100.0)
				{
					SmallChange = 1.0,
					LargeChange = 25.0
				};
				K8tCEmbqSc54wEqN0xDV(obj, 25.0);
				IndicatorSettingsSlider indicatorSettingsSlider2 = obj;
				h039tkpCbas = obj;
				indicatorSettingsSlider = indicatorSettingsSlider2;
			}
			return indicatorSettingsSlider;
		}
	}

	[Browsable(false)]
	[DataMember(Name = "Brightness")]
	public int Brightness
	{
		get
		{
			return Ppc9t1g0ns5;
		}
		set
		{
			num = Math.Max(0, Math.Min(100, num));
			if (num == Ppc9t1g0ns5)
			{
				return;
			}
			Ppc9t1g0ns5 = num;
			int num2 = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8a9257c2b61741afa02a8ceb1f69ad69 == 0)
			{
				num2 = 1;
			}
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					kkm9tnHA1yD.Value = Ppc9t1g0ns5;
					OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x4297C3EB ^ 0x4293A47D));
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d4badf00eaf04a4c91e3397f36a429cf != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	[T4IXj62qBfXCaxs2RI5("ChartIndicatorsParameters")]
	[bBo0Zd2ycQQr3LNHQf4("ChartIndicatorsHeatmapContrastBrightness")]
	public IndicatorSettingsSlider kkm9tnHA1yD
	{
		get
		{
			IndicatorSettingsSlider indicatorSettingsSlider = Y9r9t5HBhm5;
			if (indicatorSettingsSlider == null)
			{
				IndicatorSettingsSlider indicatorSettingsSlider2 = new IndicatorSettingsSlider(this, (string)HHnb6Kbq4OEEFOL97KoJ(-1522697859 ^ -1522983189), Brightness, 0.0, 100.0);
				z9fWJobqkavlO1aQK7Km(indicatorSettingsSlider2, 1.0);
				indicatorSettingsSlider2.LargeChange = 25.0;
				indicatorSettingsSlider2.TickFrequency = 25.0;
				IndicatorSettingsSlider indicatorSettingsSlider3 = indicatorSettingsSlider2;
				Y9r9t5HBhm5 = indicatorSettingsSlider2;
				indicatorSettingsSlider = indicatorSettingsSlider3;
			}
			return indicatorSettingsSlider;
		}
	}

	[Browsable(false)]
	public override bool ShowIndicatorValues => false;

	[Browsable(false)]
	public override bool ShowIndicatorLabels => false;

	[Browsable(false)]
	public override IndicatorCalculation Calculation => IndicatorCalculation.OnEachTick;

	public override void SetSettingsParam(string P_0, object P_1)
	{
		nFrlQybqxKQZZfSOCB5X(this, P_0, P_1);
		int num;
		if (LPkvh7bqLe32isTVRdL0(P_0, HHnb6Kbq4OEEFOL97KoJ(-2123795572 ^ -2123557550)))
		{
			LowerCutOff = (int)(double)P_1;
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2039997ab6194b398d07bcb5d664c971 == 0)
			{
				num = 0;
			}
		}
		else
		{
			if (P_0 == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x37B74BDF ^ 0x37B32CC3))
			{
				UpperCutOff = (int)(double)P_1;
				goto IL_007f;
			}
			num = 4;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_4aa3a79213674c27a6bc763076b8caed != 0)
			{
				num = 2;
			}
		}
		goto IL_0009;
		IL_0009:
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			case 6:
				Contrast = (int)(double)P_1;
				break;
			case 5:
				if (!(P_0 == (string)HHnb6Kbq4OEEFOL97KoJ(0x7F645F3C ^ 0x7F6038AA)))
				{
					break;
				}
				Brightness = (int)(double)P_1;
				num = 3;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ac6a9a8fc5c94cd6833091a6efebb474 != 0)
				{
					num = 2;
				}
				continue;
			case 4:
				if (!(P_0 == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-2017337494 ^ -2017085392)))
				{
					if (!LPkvh7bqLe32isTVRdL0(P_0, HHnb6Kbq4OEEFOL97KoJ(-490987856 ^ -491226658)))
					{
						num = 5;
						continue;
					}
					LargeSizeHighLight = (int)(double)P_1;
					int num2 = 2;
					num = num2;
					continue;
				}
				goto case 6;
			}
			break;
		}
		goto IL_007f;
		IL_007f:
		U8B9tSQ1M5P = true;
		num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6b9913e777f24c1abc91fbc34d2bcc9c == 0)
		{
			num = 1;
		}
		goto IL_0009;
	}

	public override bool CheckNeedRedraw()
	{
		bool u8B9tSQ1M5P = U8B9tSQ1M5P;
		U8B9tSQ1M5P = false;
		return u8B9tSQ1M5P;
	}

	public RdaLn29W6VAQ9EwGtDmL()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		MaxDepth = 50;
		int num = 3;
		while (true)
		{
			switch (num)
			{
			case 4:
				UpperCutOffFixed = null;
				Contrast = 0;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_43d123ebfe574af38268397bb0ae2d1a == 0)
				{
					num = 0;
				}
				break;
			case 2:
				LowerCutOffFixed = null;
				UpperCutOff = 95;
				num = 4;
				break;
			case 1:
				HeatmapType = HeatmapTypes.DarkToOrange;
				LowerCutOff = 15;
				num = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_152544ed8bd2470d8638a522e4a24d02 == 0)
				{
					num = 1;
				}
				break;
			default:
				LargeSizeHighLight = 50;
				Brightness = 100;
				return;
			case 3:
				ExtendDepth = false;
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44265f4417e640c7a760a59a950624e5 == 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	protected override void Execute()
	{
		int num = 4;
		int num2 = num;
		int num3 = default(int);
		IChartDataProvider dataProvider = default(IChartDataProvider);
		Dictionary<long, long>.Enumerator enumerator = default(Dictionary<long, long>.Enumerator);
		KeyValuePair<long, long> current3 = default(KeyValuePair<long, long>);
		MqHwYSnpXcMfyLAMcuJU mqHwYSnpXcMfyLAMcuJU = default(MqHwYSnpXcMfyLAMcuJU);
		MqHwYSnpXcMfyLAMcuJU mqHwYSnpXcMfyLAMcuJU2 = default(MqHwYSnpXcMfyLAMcuJU);
		KeyValuePair<long, long> current4 = default(KeyValuePair<long, long>);
		IRawMarketDepth rawMarketDepth = default(IRawMarketDepth);
		KeyValuePair<long, long> current2 = default(KeyValuePair<long, long>);
		while (true)
		{
			switch (num2)
			{
			case 5:
			case 8:
			case 14:
				if (num3 < dataProvider.Count)
				{
					QAr9tLUcIWA++;
				}
				num3++;
				num2 = 9;
				break;
			case 16:
				if (num3 <= 0)
				{
					num2 = 8;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7d3c6a8bf09f4ec887f577858231a719 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 18;
			case 21:
				try
				{
					while (true)
					{
						int num6;
						if (enumerator.MoveNext())
						{
							current3 = enumerator.Current;
							if (current3.Key >= mqHwYSnpXcMfyLAMcuJU.R09np6C6LFS)
							{
								continue;
							}
							num6 = 1;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6b9913e777f24c1abc91fbc34d2bcc9c == 0)
							{
								num6 = 0;
							}
						}
						else
						{
							num6 = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6938a97537c94834bed9381eb4051eec == 0)
							{
								num6 = 0;
							}
						}
						switch (num6)
						{
						case 1:
							mqHwYSnpXcMfyLAMcuJU.QELnpE21VfM.Add(current3.Key, current3.Value);
							continue;
						case 0:
							break;
						}
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
				}
				enumerator = mqHwYSnpXcMfyLAMcuJU2.QELnpE21VfM.GetEnumerator();
				try
				{
					while (true)
					{
						int num7;
						if (enumerator.MoveNext())
						{
							current4 = enumerator.Current;
							num7 = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6d472511f0d246a693dc7622dda5f390 == 0)
							{
								num7 = 0;
							}
						}
						else
						{
							num7 = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6b48af76ce0b4c779ac34c27953eddda == 0)
							{
								num7 = 1;
							}
						}
						switch (num7)
						{
						default:
							if (current4.Key >= mqHwYSnpXcMfyLAMcuJU.R09np6C6LFS)
							{
								continue;
							}
							if (mqHwYSnpXcMfyLAMcuJU.QELnpE21VfM.ContainsKey(current4.Key))
							{
								mqHwYSnpXcMfyLAMcuJU.QELnpE21VfM[current4.Key] = current4.Value;
								continue;
							}
							break;
						case 2:
							break;
						case 1:
							goto end_IL_0539;
						}
						mqHwYSnpXcMfyLAMcuJU.QELnpE21VfM.Add(current4.Key, current4.Value);
						continue;
						end_IL_0539:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
				}
				mqHwYSnpXcMfyLAMcuJU.R09np6C6LFS = mqHwYSnpXcMfyLAMcuJU2.R09np6C6LFS;
				num2 = 5;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5e7b68e9e95482ab88a9b839c4d448c == 0)
				{
					num2 = 5;
				}
				break;
			default:
				if (!GTq9txaHdcP.ContainsKey(num3))
				{
					GTq9txaHdcP.Add(QAr9tLUcIWA, new MqHwYSnpXcMfyLAMcuJU());
				}
				mqHwYSnpXcMfyLAMcuJU = GTq9txaHdcP[num3];
				if (QAr9tLUcIWA == dataProvider.Count)
				{
					num2 = 20;
					break;
				}
				goto case 5;
			case 20:
				rawMarketDepth = dataProvider.GetRawMarketDepth();
				num2 = 13;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1c0cedb54d2b44a7af3d63420e8a1767 == 0)
				{
					num2 = 5;
				}
				break;
			case 2:
			case 17:
				mqHwYSnpXcMfyLAMcuJU.bsTnpdFKDUv = t6QSefbqXXvGjGYEEODG(rawMarketDepth.MinAskPrice + kNS9tGMPnWf, KkDsD4bqsU8w9wUaw7pg(rawMarketDepth));
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3a7b10748dce4fec98054526a92d6ccf == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				mqHwYSnpXcMfyLAMcuJU.R09np6C6LFS = Math.Max(rawMarketDepth.MaxBidPrice - kNS9tGMPnWf, rawMarketDepth.MinBidPrice);
				goto IL_0074;
			case 6:
				if (mqHwYSnpXcMfyLAMcuJU2.bsTnpdFKDUv > mqHwYSnpXcMfyLAMcuJU.bsTnpdFKDUv)
				{
					num2 = 2;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5e7b68e9e95482ab88a9b839c4d448c == 0)
					{
						num2 = 15;
					}
					break;
				}
				goto IL_0453;
			case 18:
				if (!B1F9tYphijt)
				{
					num2 = 8;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_495802897f05476f875528905eba9a89 == 0)
					{
						num2 = 14;
					}
				}
				else
				{
					mqHwYSnpXcMfyLAMcuJU.qWGnpca7Di7.Clear();
					num2 = 12;
				}
				break;
			case 19:
				num3 = QAr9tLUcIWA;
				goto case 9;
			case 10:
				mqHwYSnpXcMfyLAMcuJU.neKnpRe2IdT = rawMarketDepth.MaxBidPrice;
				zI79WOmyVuf(ref mqHwYSnpXcMfyLAMcuJU.Ah4npjwgP0j, rawMarketDepth.AskQuotes, rawMarketDepth.MinAskPrice, 1);
				zI79WOmyVuf(ref mqHwYSnpXcMfyLAMcuJU.ERNnpQ8ZhsM, rawMarketDepth.BidQuotes, ziwCvCbqclixKPSIhHmK(rawMarketDepth), -1);
				num2 = 12;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1a625a5fe3334df88082832236dff5be == 0)
				{
					num2 = 16;
				}
				break;
			case 7:
				mqHwYSnpXcMfyLAMcuJU.bsTnpdFKDUv = rawMarketDepth.MaxAskPrice;
				mqHwYSnpXcMfyLAMcuJU.R09np6C6LFS = RvwfbTbqeB8x4L2h6nG7(rawMarketDepth);
				goto IL_0074;
			case 4:
				if (base.ClearData)
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_426282f87bb443dbbfe9ea3327b81bb7 == 0)
					{
						num2 = 3;
					}
					break;
				}
				goto IL_088f;
			case 3:
				Clear();
				goto IL_088f;
			case 13:
				if (kNS9tGMPnWf != 0)
				{
					num2 = 16;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a849a254fa6841d5989e377890b7578f == 0)
					{
						num2 = 17;
					}
					break;
				}
				goto case 7;
			case 11:
				try
				{
					while (true)
					{
						int num4;
						if (!enumerator.MoveNext())
						{
							num4 = 1;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5b6218c32bbf4af5965485469fa12538 == 0)
							{
								num4 = 0;
							}
						}
						else
						{
							KeyValuePair<long, long> current = enumerator.Current;
							if (current.Key > mqHwYSnpXcMfyLAMcuJU.bsTnpdFKDUv)
							{
								mqHwYSnpXcMfyLAMcuJU.qWGnpca7Di7.Add(current.Key, current.Value);
								continue;
							}
							num4 = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f3775e6a3cb04c0998106e46ff04d8ab == 0)
							{
								num4 = 0;
							}
						}
						switch (num4)
						{
						case 1:
							goto end_IL_07c7;
						}
						continue;
						end_IL_07c7:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
				}
				enumerator = mqHwYSnpXcMfyLAMcuJU2.qWGnpca7Di7.GetEnumerator();
				try
				{
					while (true)
					{
						IL_0366:
						int num5;
						if (enumerator.MoveNext())
						{
							current2 = enumerator.Current;
							if (current2.Key <= mqHwYSnpXcMfyLAMcuJU.bsTnpdFKDUv)
							{
								continue;
							}
							num5 = 2;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_35216e71f4e34e739f4a05a1213f3579 != 0)
							{
								num5 = 1;
							}
						}
						else
						{
							num5 = 1;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_bcda8c444ccc4b27895bae9f13596743 != 0)
							{
								num5 = 0;
							}
						}
						while (true)
						{
							switch (num5)
							{
							case 2:
								if (mqHwYSnpXcMfyLAMcuJU.qWGnpca7Di7.ContainsKey(current2.Key))
								{
									goto IL_0315;
								}
								mqHwYSnpXcMfyLAMcuJU.qWGnpca7Di7.Add(current2.Key, current2.Value);
								break;
							default:
								goto IL_0315;
							case 3:
								break;
							case 1:
								goto end_IL_0288;
							}
							goto IL_0366;
							IL_0315:
							mqHwYSnpXcMfyLAMcuJU.qWGnpca7Di7[current2.Key] = current2.Value;
							num5 = 3;
							continue;
							end_IL_0288:
							break;
						}
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
				}
				mqHwYSnpXcMfyLAMcuJU.bsTnpdFKDUv = mqHwYSnpXcMfyLAMcuJU2.bsTnpdFKDUv;
				goto IL_0453;
			case 15:
				enumerator = mqHwYSnpXcMfyLAMcuJU2.Ah4npjwgP0j.GetEnumerator();
				num2 = 4;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8ebd61b38044e13aca9bf7790883fb0 == 0)
				{
					num2 = 11;
				}
				break;
			case 9:
				if (num3 > dataProvider.Count)
				{
					return;
				}
				goto default;
			case 12:
				{
					mqHwYSnpXcMfyLAMcuJU.QELnpE21VfM.Clear();
					mqHwYSnpXcMfyLAMcuJU2 = GTq9txaHdcP[num3 - 1];
					num2 = 6;
					break;
				}
				IL_0453:
				if (mqHwYSnpXcMfyLAMcuJU2.R09np6C6LFS < mqHwYSnpXcMfyLAMcuJU.R09np6C6LFS)
				{
					enumerator = mqHwYSnpXcMfyLAMcuJU2.ERNnpQ8ZhsM.GetEnumerator();
					num2 = 15;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_409738fae61f4f058345c98b7cfbcbac != 0)
					{
						num2 = 21;
					}
					break;
				}
				goto case 5;
				IL_088f:
				dataProvider = base.DataProvider;
				if (dataProvider.Count == 0)
				{
					return;
				}
				if (GTq9txaHdcP == null)
				{
					GTq9txaHdcP = new Dictionary<int, MqHwYSnpXcMfyLAMcuJU>();
					num2 = 14;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a93c63471a5d4726b3bdf40a69cdb422 != 0)
					{
						num2 = 19;
					}
					break;
				}
				goto case 19;
				IL_0074:
				mqHwYSnpXcMfyLAMcuJU.mbhnpgtRaHO = rawMarketDepth.MinAskPrice;
				num2 = 10;
				break;
			}
		}
	}

	private void zI79WOmyVuf(ref Dictionary<long, long> P_0, IReadOnlyDictionary<long, (long, long)> P_1, long P_2 = 0L, int P_3 = 0)
	{
		if (kNS9tGMPnWf == 0)
		{
			foreach (KeyValuePair<long, (long, long)> item in P_1)
			{
				if (P_0.ContainsKey(item.Key))
				{
					P_0[item.Key] = item.Value.Item1;
				}
				else
				{
					P_0.Add(item.Key, item.Value.Item1);
				}
			}
			return;
		}
		if (P_3 > 0)
		{
			foreach (KeyValuePair<long, (long, long)> item2 in P_1)
			{
				if (item2.Key >= P_2 && item2.Key <= P_2 + kNS9tGMPnWf)
				{
					if (P_0.ContainsKey(item2.Key))
					{
						P_0[item2.Key] = item2.Value.Item1;
					}
					else
					{
						P_0.Add(item2.Key, item2.Value.Item1);
					}
				}
			}
			return;
		}
		if (P_3 >= 0)
		{
			return;
		}
		foreach (KeyValuePair<long, (long, long)> item3 in P_1)
		{
			if (item3.Key >= P_2 - kNS9tGMPnWf && item3.Key <= P_2)
			{
				if (P_0.ContainsKey(item3.Key))
				{
					P_0[item3.Key] = item3.Value.Item1;
				}
				else
				{
					P_0.Add(item3.Key, item3.Value.Item1);
				}
			}
		}
	}

	private void Clear()
	{
		QAr9tLUcIWA = 0;
		GTq9txaHdcP = null;
		pwPsc9npM9uqIaIf8mgR yhL9teBN1lp = YhL9teBN1lp;
		if (yhL9teBN1lp == null)
		{
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7070f82fb97740909616ccb4e69409c5 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}
		else
		{
			yhL9teBN1lp.Clear();
		}
	}

	public override void Render(DxVisualQueue P_0)
	{
		int num = 2;
		Dictionary<long, long>.Enumerator enumerator = default(Dictionary<long, long>.Enumerator);
		HashSet<long> hashSet = default(HashSet<long>);
		IChartDataProvider chartDataProvider = default(IChartDataProvider);
		MqHwYSnpXcMfyLAMcuJU mqHwYSnpXcMfyLAMcuJU2 = default(MqHwYSnpXcMfyLAMcuJU);
		int index2 = default(int);
		int num14 = default(int);
		List<long> list = default(List<long>);
		int num22 = default(int);
		long num12 = default(long);
		long num11 = default(long);
		Dictionary<long, long> eRNnpQ8ZhsM = default(Dictionary<long, long>);
		MqHwYSnpXcMfyLAMcuJU mqHwYSnpXcMfyLAMcuJU = default(MqHwYSnpXcMfyLAMcuJU);
		double x = default(double);
		int index = default(int);
		Dictionary<long, long> ah4npjwgP0j = default(Dictionary<long, long>);
		int num18 = default(int);
		int num16 = default(int);
		long? num10 = default(long?);
		long num13 = default(long);
		long cHsnpIg2vd = default(long);
		Dictionary<long, long> qWGnpca7Di = default(Dictionary<long, long>);
		double step = default(double);
		double y2 = default(double);
		Rect rect3 = default(Rect);
		double columnWidth = default(double);
		double stepHeight = default(double);
		XBrush xBrush2 = default(XBrush);
		long num4 = default(long);
		long yKPnpWt19xy = default(long);
		int num5 = default(int);
		int num6 = default(int);
		Dictionary<long, long> qELnpE21VfM = default(Dictionary<long, long>);
		KeyValuePair<long, long> current4 = default(KeyValuePair<long, long>);
		double num26 = default(double);
		Rect rect4 = default(Rect);
		int num20 = default(int);
		double y = default(double);
		Rect rect = default(Rect);
		double num8 = default(double);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 7:
					try
					{
						while (enumerator.MoveNext())
						{
							hashSet.Add(enumerator.Current.Value);
						}
					}
					finally
					{
						((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
					}
					goto case 11;
				case 2:
					chartDataProvider = (IChartDataProvider)yKtcB2bqj1vCZkbNbgZP(this);
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f40a817752724303a7406a720886b183 == 0)
					{
						num2 = 1;
					}
					continue;
				case 28:
				{
					using (Dictionary<long, long>.Enumerator enumerator2 = mqHwYSnpXcMfyLAMcuJU2.ERNnpQ8ZhsM.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							hashSet.Add(enumerator2.Current.Value);
						}
						int num23 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_859c6249cb0f4f11b2da29d1228ce418 != 0)
						{
							num23 = 0;
						}
						switch (num23)
						{
						case 0:
							break;
						}
					}
					enumerator = mqHwYSnpXcMfyLAMcuJU2.QELnpE21VfM.GetEnumerator();
					num2 = 7;
					continue;
				}
				case 18:
					if (GTq9txaHdcP.ContainsKey(index2))
					{
						num2 = 2;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b17e829e94d54e7b87d666edd5b38bcd != 0)
						{
							num2 = 10;
						}
						continue;
					}
					goto case 32;
				case 13:
					index2 = base.Canvas.GetIndex(num14);
					num2 = 18;
					continue;
				case 19:
					return;
				case 16:
				{
					long val = list[num22];
					num12 = Math.Min(val, num12);
					num11 = Math.Max(val, num11);
					num22++;
					num2 = 11;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_426282f87bb443dbbfe9ea3327b81bb7 == 0)
					{
						num2 = 23;
					}
					continue;
				}
				case 25:
					YhL9teBN1lp = new pwPsc9npM9uqIaIf8mgR();
					num2 = 29;
					continue;
				case 5:
					eRNnpQ8ZhsM = mqHwYSnpXcMfyLAMcuJU.ERNnpQ8ZhsM;
					x = GetX(index);
					enumerator = ah4npjwgP0j.GetEnumerator();
					num2 = 31;
					continue;
				case 6:
					CCCU1AbqQVO1Qekrjt7C(list);
					num18 = UpperCutOff;
					num2 = 7;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_495802897f05476f875528905eba9a89 == 0)
					{
						num2 = 15;
					}
					continue;
				case 14:
				case 27:
					if (num16 < 0)
					{
						return;
					}
					goto default;
				case 3:
					if (num10.HasValue)
					{
						IChartSymbol symbol = chartDataProvider.Symbol;
						num10 = UpperCutOffFixed;
						num11 = x9RDfwbqdc8VnIl1mwmC(symbol, num10.Value);
					}
					if (num12 >= num11)
					{
						num2 = 8;
						continue;
					}
					xJJIEbbqg1ANjBsebVJU(YhL9teBN1lp, num12, num11, num13);
					num2 = 21;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_eb223d2975554a51b6c4f9fa9a65a93d != 0)
					{
						num2 = 21;
					}
					continue;
				case 26:
					if (YhL9teBN1lp == null)
					{
						num2 = 3;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fb3e1155cc384cc2a7c812423a76ea76 != 0)
						{
							num2 = 25;
						}
						continue;
					}
					goto case 29;
				case 4:
					enumerator = mqHwYSnpXcMfyLAMcuJU2.qWGnpca7Di7.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							hashSet.Add(enumerator.Current.Value);
						}
						int num15 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ebf7ae5938c3406ea71c3b7147ea041c == 0)
						{
							num15 = 0;
						}
						switch (num15)
						{
						case 0:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
					}
					goto case 32;
				case 11:
					foreach (KeyValuePair<long, long> item in mqHwYSnpXcMfyLAMcuJU2.Ah4npjwgP0j)
					{
						int num28 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c7e1deb64093431d91d263a2e49f884b != 0)
						{
							num28 = 0;
						}
						switch (num28)
						{
						}
						hashSet.Add(item.Value);
					}
					goto case 4;
				case 12:
					cHsnpIg2vd = YhL9teBN1lp.cHsnpIg2vd2;
					num2 = 22;
					continue;
				case 24:
					num16--;
					num2 = 27;
					continue;
				case 30:
				{
					using (Dictionary<long, long>.Enumerator enumerator2 = qWGnpca7Di.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							while (true)
							{
								KeyValuePair<long, long> current3 = enumerator2.Current;
								if (current3.Value < cHsnpIg2vd)
								{
									break;
								}
								int num24 = 2;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b3744d11c0b24c8d993b100cbb22f9e7 == 0)
								{
									num24 = 2;
								}
								while (true)
								{
									switch (num24)
									{
									case 2:
									{
										double d2 = step * (double)current3.Key;
										y2 = GetY(d2);
										num24 = 3;
										if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6990919c9c0e45a99d17cb82a4a90a41 != 0)
										{
											num24 = 2;
										}
										continue;
									}
									case 1:
										break;
									default:
										goto IL_08b4;
									case 3:
										rect3 = new Rect(new Point(x - columnWidth / 2.0, y2 - stepHeight / 2.0), new Point(x + columnWidth / 2.0, y2 + stepHeight / 2.0));
										xBrush2 = new XBrush(bgV9WqND3IE(num4, current3.Value, yKPnpWt19xy, num5, num6));
										num24 = 0;
										if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_52f1b40ebe094208bc85ded04f1baa0b == 0)
										{
											num24 = 0;
										}
										continue;
									}
									break;
								}
								continue;
								IL_08b4:
								sUuUtVbq6dXEvTlF6yn4(P_0, xBrush2, rect3);
								break;
							}
						}
					}
					enumerator = qELnpE21VfM.GetEnumerator();
					try
					{
						while (true)
						{
							int num25;
							if (!enumerator.MoveNext())
							{
								num25 = 2;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7070f82fb97740909616ccb4e69409c5 != 0)
								{
									num25 = 3;
								}
								goto IL_0a4c;
							}
							goto IL_0b2c;
							IL_0b2c:
							current4 = enumerator.Current;
							if (current4.Value < cHsnpIg2vd)
							{
								continue;
							}
							num26 = step * (double)current4.Key;
							num25 = 2;
							goto IL_0a4c;
							IL_0a4c:
							while (true)
							{
								switch (num25)
								{
								case 1:
									goto IL_0b2c;
								case 2:
								{
									double num27 = JigYXebqM2ZpK9eAN9Og(this, num26);
									rect4 = new Rect(new Point(x - columnWidth / 2.0, num27 - stepHeight / 2.0), new Point(x + columnWidth / 2.0, num27 + stepHeight / 2.0));
									num25 = 0;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fa74d46e0c824e0b89c71deca0488611 == 0)
									{
										num25 = 0;
									}
									continue;
								}
								case 3:
									goto end_IL_0b06;
								}
								break;
							}
							XBrush brush2 = new XBrush(bgV9WqND3IE(num4, current4.Value, yKPnpWt19xy, num5, num6));
							P_0.FillRectangle(brush2, rect4);
							continue;
							end_IL_0b06:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
					}
					goto case 24;
				}
				case 29:
					if (YhL9teBN1lp.LbXnpqatTMx(base.Canvas))
					{
						hashSet = new HashSet<long>();
						num14 = VvywSobqEMi7sxagvt1h(base.Canvas) - 1;
						goto IL_0518;
					}
					goto case 21;
				case 1:
					step = chartDataProvider.Step;
					stepHeight = base.Canvas.StepHeight;
					columnWidth = base.Canvas.ColumnWidth;
					num2 = 26;
					continue;
				case 10:
					mqHwYSnpXcMfyLAMcuJU2 = GTq9txaHdcP[index2];
					num2 = 28;
					continue;
				case 20:
				case 23:
					if (num22 >= num20)
					{
						if (num12 == long.MaxValue)
						{
							num12 = 0L;
						}
						if (num11 == long.MinValue)
						{
							num11 = 0L;
						}
						if (LowerCutOffFixed.HasValue)
						{
							num12 = x9RDfwbqdc8VnIl1mwmC(chartDataProvider.Symbol, LowerCutOffFixed.Value);
						}
						num10 = UpperCutOffFixed;
						num2 = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8b8f48487ce54157a86b0385feea16a6 != 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 16;
				case 15:
				{
					int num17 = LowerCutOff;
					int count = list.Count;
					if (num17 >= num18)
					{
						num17 = Math.Max(0, num18 - 1);
					}
					int num19 = count * num17 / 100;
					num20 = count * num18 / 100;
					int num21 = count * LargeSizeHighLight / 100;
					num21 = v6fYWlbq5Wfa1Li2nhhh(0, uoySlXbqD8ngt2EyLjZ9(count - 1, num21));
					num13 = list[num21];
					num12 = long.MaxValue;
					num11 = long.MinValue;
					num22 = num19;
					num = 20;
					break;
				}
				case 17:
					mqHwYSnpXcMfyLAMcuJU = GTq9txaHdcP[index];
					ah4npjwgP0j = mqHwYSnpXcMfyLAMcuJU.Ah4npjwgP0j;
					num2 = 5;
					continue;
				case 32:
					num14--;
					goto IL_0518;
				case 9:
					num16 = base.Canvas.Count - 1;
					num2 = 14;
					continue;
				case 8:
					return;
				case 21:
					num5 = Contrast;
					num6 = Brightness;
					num2 = 12;
					continue;
				default:
					index = base.Canvas.GetIndex(num16);
					if (!GTq9txaHdcP.ContainsKey(index))
					{
						num2 = 24;
						continue;
					}
					goto case 17;
				case 22:
				{
					long maxValue = YhL9teBN1lp.MaxValue;
					yKPnpWt19xy = YhL9teBN1lp.yKPnpWt19xy;
					num4 = maxValue - cHsnpIg2vd;
					num2 = 6;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_390fe499a2cc4a5ca3d6279a99e6b610 != 0)
					{
						num2 = 9;
					}
					continue;
				}
				case 31:
					{
						try
						{
							while (enumerator.MoveNext())
							{
								KeyValuePair<long, long> current = enumerator.Current;
								int num3 = 2;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c1a63437a5bc4d139ae2c4a2f19ec947 == 0)
								{
									num3 = 2;
								}
								while (true)
								{
									switch (num3)
									{
									case 2:
										if (current.Value >= cHsnpIg2vd)
										{
											double d = step * (double)current.Key;
											y = GetY(d);
											num3 = 3;
											if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6d472511f0d246a693dc7622dda5f390 == 0)
											{
												num3 = 3;
											}
											continue;
										}
										break;
									case 1:
									{
										XBrush xBrush = new XBrush(c6yB9qbqR8uFhNBB3Fdw(bgV9WqND3IE(num4, current.Value, yKPnpWt19xy, num5, num6)));
										sUuUtVbq6dXEvTlF6yn4(P_0, xBrush, rect);
										num3 = 0;
										if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c1a63437a5bc4d139ae2c4a2f19ec947 == 0)
										{
											num3 = 0;
										}
										continue;
									}
									case 3:
										rect = new Rect(new Point(x - columnWidth / 2.0, y - stepHeight / 2.0), new Point(x + columnWidth / 2.0, y + stepHeight / 2.0));
										num3 = 1;
										if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_495802897f05476f875528905eba9a89 == 0)
										{
											num3 = 1;
										}
										continue;
									}
									break;
								}
							}
						}
						finally
						{
							((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
						}
						enumerator = eRNnpQ8ZhsM.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								while (true)
								{
									KeyValuePair<long, long> current2 = enumerator.Current;
									int num7 = 3;
									while (true)
									{
										switch (num7)
										{
										case 1:
											break;
										case 2:
											num8 = step * (double)current2.Key;
											num7 = 1;
											if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ff2c70a81f2141b98b88fc10875a3726 != 0)
											{
												num7 = 0;
											}
											continue;
										default:
											goto end_IL_0d24;
										case 3:
											goto IL_0dea;
										}
										double num9 = JigYXebqM2ZpK9eAN9Og(this, num8);
										Rect rect2 = new Rect(new Point(x - columnWidth / 2.0, num9 - stepHeight / 2.0), new Point(x + columnWidth / 2.0, num9 + stepHeight / 2.0));
										XBrush brush = new XBrush(c6yB9qbqR8uFhNBB3Fdw(bgV9WqND3IE(num4, current2.Value, yKPnpWt19xy, num5, num6)));
										P_0.FillRectangle(brush, rect2);
										goto end_IL_0d85;
										IL_0dea:
										if (current2.Value < cHsnpIg2vd)
										{
											goto end_IL_0d85;
										}
										num7 = 2;
										if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c16c36b6197f4f30be0a8035f04288b3 != 0)
										{
											num7 = 1;
										}
										continue;
										end_IL_0d24:
										break;
									}
									continue;
									end_IL_0d85:
									break;
								}
							}
						}
						finally
						{
							((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
						}
						qWGnpca7Di = mqHwYSnpXcMfyLAMcuJU.qWGnpca7Di7;
						qELnpE21VfM = mqHwYSnpXcMfyLAMcuJU.QELnpE21VfM;
						num2 = 30;
						continue;
					}
					IL_0518:
					if (num14 < 0)
					{
						if (hashSet.Count >= 2)
						{
							list = hashSet.ToList();
							num2 = 3;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a93c63471a5d4726b3bdf40a69cdb422 != 0)
							{
								num2 = 6;
							}
							continue;
						}
						num = 19;
						break;
					}
					goto case 13;
				}
				break;
			}
		}
	}

	private Color bgV9WqND3IE(long P_0, long P_1, long P_2, int P_3, int P_4)
	{
		int num = 1;
		int num2 = num;
		decimal num3 = default(decimal);
		while (true)
		{
			switch (num2)
			{
			default:
				num3 = Math.Max(0m, Math.Min(100m, num3));
				num2 = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_267ca8254fa648cbaa1ba685784f79c7 != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
			{
				Color result = qIGyeinpxXL7Q0onc9gO.f3HnpLFWPNl(HeatmapType, eomHS6bqIFZo1DglNNID(num3), P_3);
				if (P_1 >= P_2)
				{
					return result;
				}
				return cxYqNkbqtbUvgMSjKZQ4((byte)k95cqJbqWGWhoOoVB1NF(0.0, Math.Min(255.0, 2.55 * (double)P_4)), result.R, result.G, result.B);
			}
			case 1:
				num3 = v3hf14bqq1fki2An89il(q4SxUIbqO34bcSl7EK5W(100m, P_0), P_1);
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fc665aa6b49746ab985cf6653d959552 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override void RenderCursor(DxVisualQueue P_0, int P_1, Point P_2, ref int P_3)
	{
		int num = 7;
		int num2 = num;
		string text = default(string);
		Rect rect = default(Rect);
		Size size = default(Size);
		MqHwYSnpXcMfyLAMcuJU mqHwYSnpXcMfyLAMcuJU = default(MqHwYSnpXcMfyLAMcuJU);
		long num4 = default(long);
		long num3 = default(long);
		while (true)
		{
			switch (num2)
			{
			default:
				P_0.DrawString(text, ((IChartCanvas)z9kAysbqU3Ry45VvCPsk(this)).ChartFont, new XBrush(base.Canvas.Theme.ClusterTextColor), rect, XTextAlignment.Center);
				return;
			case 7:
				if ((Keyboard.Modifiers & ModifierKeys.Control) != ModifierKeys.None)
				{
					num2 = 6;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d4c083a65c1546b8a09c928a8c95e140 == 0)
					{
						num2 = 5;
					}
					break;
				}
				return;
			case 8:
				rect = new Rect(new Point(P_2.X + 5.0, P_2.Y - 5.0), new Point(P_2.X + 15.0 + size.Width, P_2.Y - 15.0 - size.Height));
				num2 = 5;
				break;
			case 11:
				size = ((XFont)qkRFqObqyNjR8kD4WbUe(base.Canvas)).GetSize(text);
				num2 = 8;
				break;
			case 3:
				P_0.DrawRectangle(new XPen(new XBrush(base.Canvas.Theme.ChartAxisColor), 1), rect);
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5dcb5c2a8274adf87bda91d76616538 == 0)
				{
					num2 = 0;
				}
				break;
			case 10:
				if (P_1 < 0)
				{
					return;
				}
				mqHwYSnpXcMfyLAMcuJU = GTq9txaHdcP[P_1];
				num4 = (long)(((IChartCanvas)z9kAysbqU3Ry45VvCPsk(this)).GetValue(P_2.Y) / base.DataProvider.Step);
				num3 = 0L;
				if (num4 >= mqHwYSnpXcMfyLAMcuJU.mbhnpgtRaHO)
				{
					if (mqHwYSnpXcMfyLAMcuJU.qWGnpca7Di7.ContainsKey(num4))
					{
						num2 = 9;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6d472511f0d246a693dc7622dda5f390 != 0)
						{
							num2 = 8;
						}
						break;
					}
					if (mqHwYSnpXcMfyLAMcuJU.Ah4npjwgP0j.ContainsKey(num4))
					{
						num3 = mqHwYSnpXcMfyLAMcuJU.Ah4npjwgP0j[num4];
						num2 = 2;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_12e8a768a5674e7d88b4e5ccd4fb7295 == 0)
						{
							num2 = 2;
						}
						break;
					}
				}
				else if (num4 <= mqHwYSnpXcMfyLAMcuJU.neKnpRe2IdT)
				{
					if (mqHwYSnpXcMfyLAMcuJU.QELnpE21VfM.ContainsKey(num4))
					{
						num3 = mqHwYSnpXcMfyLAMcuJU.QELnpE21VfM[num4];
						num2 = 4;
						break;
					}
					if (mqHwYSnpXcMfyLAMcuJU.ERNnpQ8ZhsM.ContainsKey(num4))
					{
						num3 = mqHwYSnpXcMfyLAMcuJU.ERNnpQ8ZhsM[num4];
						num2 = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_43d123ebfe574af38268397bb0ae2d1a == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
				goto case 1;
			case 12:
				return;
			case 6:
				if (GTq9txaHdcP == null || GTq9txaHdcP.Count == 0)
				{
					return;
				}
				num2 = 8;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03df70ea72bf4e3e81ab05550292a7c9 == 0)
				{
					num2 = 10;
				}
				break;
			case 1:
			case 2:
			case 4:
				if (num3 == 0L)
				{
					return;
				}
				text = (string)bAN6RlbqTR7qaZWB7Z0B(base.DataProvider.Symbol, num3, 2);
				num2 = 11;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_267ca8254fa648cbaa1ba685784f79c7 != 0)
				{
					num2 = 2;
				}
				break;
			case 9:
				num3 = mqHwYSnpXcMfyLAMcuJU.qWGnpca7Di7[num4];
				goto case 1;
			case 5:
				P_0.FillRectangle(new XBrush(base.Canvas.Theme.ChartBackColor), rect);
				num2 = 3;
				break;
			}
		}
	}

	public override void CopyTemplate(IndicatorBase P_0, bool P_1)
	{
		if (P_0 is RdaLn29W6VAQ9EwGtDmL rdaLn29W6VAQ9EwGtDmL)
		{
			int num = 2;
			while (true)
			{
				switch (num)
				{
				case 2:
					MaxDepth = SM9hhJbqZGopQaDijEnQ(rdaLn29W6VAQ9EwGtDmL);
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6b9913e777f24c1abc91fbc34d2bcc9c == 0)
					{
						num = 0;
					}
					continue;
				default:
					ExtendDepth = rdaLn29W6VAQ9EwGtDmL.ExtendDepth;
					HeatmapType = DBZJQebqVXfrtox3HAO4(rdaLn29W6VAQ9EwGtDmL);
					LowerCutOff = hotSISbqC4TwZNj7wpgx(rdaLn29W6VAQ9EwGtDmL);
					UpperCutOff = rdaLn29W6VAQ9EwGtDmL.UpperCutOff;
					Contrast = GcdlZmbqrTS6RN7c4IbH(rdaLn29W6VAQ9EwGtDmL);
					num = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_35216e71f4e34e739f4a05a1213f3579 != 0)
					{
						num = 1;
					}
					continue;
				case 3:
					break;
				case 1:
					LargeSizeHighLight = rdaLn29W6VAQ9EwGtDmL.LargeSizeHighLight;
					Brightness = rdaLn29W6VAQ9EwGtDmL.Brightness;
					num = 3;
					continue;
				}
				break;
			}
		}
		base.CopyTemplate(P_0, P_1);
	}

	public override object Clone()
	{
		RdaLn29W6VAQ9EwGtDmL rdaLn29W6VAQ9EwGtDmL = new RdaLn29W6VAQ9EwGtDmL();
		UpljqtbqKsTWgW5mo4TZ(rdaLn29W6VAQ9EwGtDmL, this, true);
		return rdaLn29W6VAQ9EwGtDmL;
	}

	static RdaLn29W6VAQ9EwGtDmL()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static object HHnb6Kbq4OEEFOL97KoJ(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static bool Bw5KCObqiG9xLsvV63SJ()
	{
		return KgsxOObqafFA90rOWwwK == null;
	}

	internal static RdaLn29W6VAQ9EwGtDmL JR9PmSbqlZfsbNNAdmgb()
	{
		return KgsxOObqafFA90rOWwwK;
	}

	internal static int uoySlXbqD8ngt2EyLjZ9(int P_0, int P_1)
	{
		return Math.Min(P_0, P_1);
	}

	internal static void cOcvqibqb8cgUxB8pHqk(object P_0, double P_1)
	{
		((IndicatorSettingsSlider)P_0).Value = P_1;
	}

	internal static void kae8LlbqNM07jP5ts8ct(object P_0, object P_1)
	{
		((IndicatorBase)P_0).OnPropertyChanged((string)P_1);
	}

	internal static void z9fWJobqkavlO1aQK7Km(object P_0, double P_1)
	{
		((IndicatorSettingsSlider)P_0).SmallChange = P_1;
	}

	internal static void l5m6Gtbq1M3sf1yLhIrR(object P_0, double P_1)
	{
		((IndicatorSettingsSlider)P_0).LargeChange = P_1;
	}

	internal static int v6fYWlbq5Wfa1Li2nhhh(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static void K8tCEmbqSc54wEqN0xDV(object P_0, double P_1)
	{
		((IndicatorSettingsSlider)P_0).TickFrequency = P_1;
	}

	internal static void nFrlQybqxKQZZfSOCB5X(object P_0, object P_1, object P_2)
	{
		((IndicatorBase)P_0).SetSettingsParam((string)P_1, P_2);
	}

	internal static bool LPkvh7bqLe32isTVRdL0(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static long RvwfbTbqeB8x4L2h6nG7(object P_0)
	{
		return ((IRawMarketDepth)P_0).MinBidPrice;
	}

	internal static long KkDsD4bqsU8w9wUaw7pg(object P_0)
	{
		return ((IRawMarketDepth)P_0).MaxAskPrice;
	}

	internal static long t6QSefbqXXvGjGYEEODG(long P_0, long P_1)
	{
		return Math.Min(P_0, P_1);
	}

	internal static long ziwCvCbqclixKPSIhHmK(object P_0)
	{
		return ((IRawMarketDepth)P_0).MaxBidPrice;
	}

	internal static object yKtcB2bqj1vCZkbNbgZP(object P_0)
	{
		return ((IndicatorBase)P_0).DataProvider;
	}

	internal static int VvywSobqEMi7sxagvt1h(object P_0)
	{
		return ((IChartCanvas)P_0).Count;
	}

	internal static void CCCU1AbqQVO1Qekrjt7C(object P_0)
	{
		((List<long>)P_0).Sort();
	}

	internal static long x9RDfwbqdc8VnIl1mwmC(object P_0, double P_1)
	{
		return ((IChartSymbol)P_0).CorrectSizeFilter(P_1);
	}

	internal static void xJJIEbbqg1ANjBsebVJU(object P_0, long P_1, long P_2, long P_3)
	{
		((pwPsc9npM9uqIaIf8mgR)P_0).YHAnpOuhfYw(P_1, P_2, P_3);
	}

	internal static XColor c6yB9qbqR8uFhNBB3Fdw(Color P_0)
	{
		return P_0;
	}

	internal static void sUuUtVbq6dXEvTlF6yn4(object P_0, object P_1, Rect P_2)
	{
		((DxVisualQueue)P_0).FillRectangle((XBrush)P_1, P_2);
	}

	internal static double JigYXebqM2ZpK9eAN9Og(object P_0, double P_1)
	{
		return ((IndicatorBase)P_0).GetY(P_1);
	}

	internal static decimal q4SxUIbqO34bcSl7EK5W(decimal P_0, decimal P_1)
	{
		return P_0 / P_1;
	}

	internal static decimal v3hf14bqq1fki2An89il(decimal P_0, decimal P_1)
	{
		return P_0 * P_1;
	}

	internal static int eomHS6bqIFZo1DglNNID(decimal P_0)
	{
		return (int)P_0;
	}

	internal static double k95cqJbqWGWhoOoVB1NF(double P_0, double P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static Color cxYqNkbqtbUvgMSjKZQ4(byte P_0, byte P_1, byte P_2, byte P_3)
	{
		return Color.FromArgb(P_0, P_1, P_2, P_3);
	}

	internal static object z9kAysbqU3Ry45VvCPsk(object P_0)
	{
		return ((IndicatorBase)P_0).Canvas;
	}

	internal static object bAN6RlbqTR7qaZWB7Z0B(object P_0, long P_1, int P_2)
	{
		return ((IChartSymbol)P_0).FormatRawSize(P_1, P_2);
	}

	internal static object qkRFqObqyNjR8kD4WbUe(object P_0)
	{
		return ((IChartCanvas)P_0).ChartFont;
	}

	internal static int SM9hhJbqZGopQaDijEnQ(object P_0)
	{
		return ((RdaLn29W6VAQ9EwGtDmL)P_0).MaxDepth;
	}

	internal static HeatmapTypes DBZJQebqVXfrtox3HAO4(object P_0)
	{
		return ((RdaLn29W6VAQ9EwGtDmL)P_0).HeatmapType;
	}

	internal static int hotSISbqC4TwZNj7wpgx(object P_0)
	{
		return ((RdaLn29W6VAQ9EwGtDmL)P_0).LowerCutOff;
	}

	internal static int GcdlZmbqrTS6RN7c4IbH(object P_0)
	{
		return ((RdaLn29W6VAQ9EwGtDmL)P_0).Contrast;
	}

	internal static void UpljqtbqKsTWgW5mo4TZ(object P_0, object P_1, bool P_2)
	{
		((IndicatorBase)P_0).CopyTemplate((IndicatorBase)P_1, P_2);
	}
}
