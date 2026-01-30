using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Windows;
using System.Windows.Media;
using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;
using MIGrPZi4v1c8N1FGp0Vb;
using nPFdaZi4fnexuP6NaG7M;
using TigerTrade.Chart.Base;
using TigerTrade.Chart.Data;
using TigerTrade.Chart.Indicators.Common;
using TigerTrade.Chart.Indicators.Drawings;
using TigerTrade.Chart.Indicators.Drawings.Enums;
using TigerTrade.Chart.Indicators.Enums;
using TigerTrade.Dx;
using TigerTrade.Dx.Enums;

namespace lPPb3XigSOKWPbF7w26h;

[Indicator("WeisWaveZigZag", "WeisWaveZigZag", true, Type = typeof(VWr5iiig50H4tDjriCFw))]
[DataContract(Name = "WeisWaveZigZagIndicator", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
internal sealed class VWr5iiig50H4tDjriCFw : IndicatorBase
{
	private class lT7wscimtLEvCIhOqnt6
	{
		public double LmCimU353JX;

		public double Volume;

		public double Delta;

		public bool GgoimTZ5tkV;

		private static lT7wscimtLEvCIhOqnt6 hBImo7eTYS7j7vEbK098;

		public lT7wscimtLEvCIhOqnt6()
		{
			W5O0v9eTBROwytyD8Xjp();
			base._002Ector();
		}

		static lT7wscimtLEvCIhOqnt6()
		{
			yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
			ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
		}

		internal static void W5O0v9eTBROwytyD8Xjp()
		{
			tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		}

		internal static bool auIU4deToxMInpWJOphh()
		{
			return hBImo7eTYS7j7vEbK098 == null;
		}

		internal static lT7wscimtLEvCIhOqnt6 ID3TwveTvWcAhUoxMJmU()
		{
			return hBImo7eTYS7j7vEbK098;
		}
	}

	private int DbWigTmLkMS;

	private bool z09igyuvouu;

	private bool nHMigZh1GAD;

	private int wIJigVYmPLP;

	private int JGjigC9ZW7o;

	private XBrush ILyigrDFsGD;

	private XColor Tb3igKYT0xC;

	private XBrush nO4igmF3USm;

	private XColor AWRighLh62w;

	private XBrush xjbigwcJ2Yx;

	private XColor VSKig7eYn3X;

	private XBrush Dnrig8vPVi5;

	private XColor rknigASrpIF;

	private ChartSeries r2AigPDJlAd;

	private Dictionary<int, lT7wscimtLEvCIhOqnt6> zamigJQYhW9;

	private static VWr5iiig50H4tDjriCFw mytyWVesNrXKCIqHq7Gg;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.Bar;

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsPeriod")]
	[DataMember(Name = "Period")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	public int Period
	{
		get
		{
			return DbWigTmLkMS;
		}
		set
		{
			num = zL4yx9es56EZlK2kqKA2(1, num);
			int num2;
			if (num != DbWigTmLkMS)
			{
				DbWigTmLkMS = num;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x3E0426F0 ^ 0x3E04A146));
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8bad63f401844feb8b319ab89401e7b9 != 0)
				{
					num2 = 0;
				}
			}
			else
			{
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_89f5b3f1a0294191b0997cd0b778a845 != 0)
				{
					num2 = 1;
				}
			}
			switch (num2)
			{
			case 1:
				return;
			}
			OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x1EFE0A28 ^ 0x1EFE9B0C));
		}
	}

	[DataMember(Name = "ShowVolume")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsShowVolume")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	public bool ShowVolume
	{
		get
		{
			return z09igyuvouu;
		}
		set
		{
			if (flag != z09igyuvouu)
			{
				z09igyuvouu = flag;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_849738dd5158436baf2d7aeadba27136 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged((string)GVpK65esSI6MoHny2ew1(--18459671 ^ 0x1193853));
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[DataMember(Name = "ShowDelta")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsShowDelta")]
	public bool ShowDelta
	{
		get
		{
			return nHMigZh1GAD;
		}
		set
		{
			if (flag != nHMigZh1GAD)
			{
				nHMigZh1GAD = flag;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1999650146 ^ -1999677776));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_a103e6559ac3474e9e79ab00912c861c == 0)
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

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsVolumeDivisor")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[DataMember(Name = "VolumeDivisor")]
	public int VolumeDivisor
	{
		get
		{
			return wIJigVYmPLP;
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					num3 = Math.Max(1, num3);
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_5bc14e9093324ecc8c5d7e08f50abd26 == 0)
					{
						num2 = 0;
					}
					break;
				default:
					if (num3 != wIJigVYmPLP)
					{
						wIJigVYmPLP = num3;
						OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-225822163 ^ -225797321));
					}
					return;
				}
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[DataMember(Name = "DeltaDivisor")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsDeltaDivisor")]
	public int DeltaDivisor
	{
		get
		{
			return JGjigC9ZW7o;
		}
		set
		{
			num = Math.Max(1, num);
			if (num == JGjigC9ZW7o)
			{
				int num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_fbc3ce86e86648d0ab473d06282ebe5e == 0)
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
				JGjigC9ZW7o = num;
				OnPropertyChanged((string)GVpK65esSI6MoHny2ew1(-842040449 ^ -842016185));
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsStyle")]
	[DataMember(Name = "Down")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsUpVolumeColor")]
	public XColor UpVolumeColor
	{
		get
		{
			return Tb3igKYT0xC;
		}
		set
		{
			if (!tb3igKYT0xC.Equals(Tb3igKYT0xC))
			{
				Tb3igKYT0xC = tb3igKYT0xC;
				int num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_35044ecf03034683aa5038f38795ec31 == 0)
				{
					num = 1;
				}
				switch (num)
				{
				case 1:
					ILyigrDFsGD = new XBrush(Tb3igKYT0xC);
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-2002318893 ^ -2002278265));
					break;
				case 0:
					break;
				}
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsStyle")]
	[DataMember(Name = "DownVolumeColor")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsDownVolumeColor")]
	public XColor DownVolumeColor
	{
		get
		{
			return AWRighLh62w;
		}
		set
		{
			if (!aWRighLh62w.Equals(AWRighLh62w))
			{
				AWRighLh62w = aWRighLh62w;
				nO4igmF3USm = new XBrush(AWRighLh62w);
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x6E2DFBED ^ 0x6E2D5A9F));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e9f58003753b4aa88a036bb6f675d81b == 0)
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

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsStyle")]
	[DataMember(Name = "DeltaPlusColor")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsDeltaPlusColor")]
	public XColor DeltaPlusColor
	{
		get
		{
			return VSKig7eYn3X;
		}
		set
		{
			if (!vSKig7eYn3X.Equals(VSKig7eYn3X))
			{
				VSKig7eYn3X = vSKig7eYn3X;
				xjbigwcJ2Yx = new XBrush(VSKig7eYn3X);
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1416986301 ^ -1417013775));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_22d3e151413e4c568d725fa731c4c03c == 0)
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

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsStyle")]
	[DataMember(Name = "DeltaMinusColor")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsDeltaMinusColor")]
	public XColor DeltaMinusColor
	{
		get
		{
			return rknigASrpIF;
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
					if (xColor.Equals(rknigASrpIF))
					{
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0cda726836d64094b2c4c18a328cd3aa != 0)
						{
							num2 = 0;
						}
						break;
					}
					rknigASrpIF = xColor;
					Dnrig8vPVi5 = new XBrush(rknigASrpIF);
					OnPropertyChanged((string)GVpK65esSI6MoHny2ew1(-617064403 ^ -617034497));
					return;
				case 0:
					return;
				}
			}
		}
	}

	[DisplayName("ZigZag")]
	[DataMember(Name = "ZigZag")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsCharts")]
	public ChartSeries ZigZagSeries
	{
		get
		{
			return r2AigPDJlAd ?? (r2AigPDJlAd = new ChartSeries(ChartSeriesType.Line, mQidYTesxZtE7q5COwDd(Colors.Blue)));
		}
		private set
		{
			if (!tWRcmqesLQDTZBYRjHYl(chartSeries, r2AigPDJlAd))
			{
				r2AigPDJlAd = chartSeries;
				OnPropertyChanged((string)GVpK65esSI6MoHny2ew1(-176525661 ^ -176500937));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3a22ea2a41c84163a97ae0a1f3b4c6b4 != 0)
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

	public VWr5iiig50H4tDjriCFw()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		Calculation = IndicatorCalculation.OnEachTick;
		Period = 3;
		ShowVolume = true;
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9a8381dfafdf4cd0bdbdde184d2abaf1 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				VolumeDivisor = 1;
				DeltaDivisor = 1;
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_db5715c3607e44409516f9862a59965c == 0)
				{
					num = 1;
				}
				break;
			default:
				ShowDelta = false;
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f32eaaa08a29412b875fc15d2e235a1b != 0)
				{
					num = 2;
				}
				break;
			case 1:
				return;
			}
		}
	}

	protected override void Execute()
	{
		int num = 54;
		double[] array8 = default(double[]);
		int num12 = default(int);
		double[] array7 = default(double[]);
		int num3 = default(int);
		double[] array4 = default(double[]);
		double num16 = default(double);
		double num13 = default(double);
		double[] close = default(double[]);
		double[] array5 = default(double[]);
		double[] array9 = default(double[]);
		int num5 = default(int);
		double num21 = default(double);
		int num14 = default(int);
		IChartDataProvider dataProvider = default(IChartDataProvider);
		double num4 = default(double);
		int num20 = default(int);
		int num17 = default(int);
		int num10 = default(int);
		double[] array2 = default(double[]);
		int num19 = default(int);
		int num6 = default(int);
		double[] high = default(double[]);
		double[] array6 = default(double[]);
		int num7 = default(int);
		int num8 = default(int);
		int num11 = default(int);
		int num18 = default(int);
		double[] array = default(double[]);
		int num15 = default(int);
		double num9 = default(double);
		double[] delta = default(double[]);
		double[] volume = default(double[]);
		double[] array3 = default(double[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					array8[num12 - 1] = array8[num12];
					goto IL_05f2;
				case 63:
					array7[num3] = 0.0;
					array4[num3] = num16;
					num = 72;
					break;
				case 68:
					if (LsZ9H7esXtl2GjXZXeXH(num13 - close[num12]) >= (double)Period * base.DataProvider.Step)
					{
						array5[num12] = array9[num12];
						num5 = 0;
					}
					else
					{
						array5[num12] = array5[num12 - 1];
						if (num5 == 0)
						{
							num2 = 25;
							if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_03398ebbe6224bea83047c33d24affe2 == 0)
							{
								num2 = 39;
							}
							continue;
						}
					}
					goto IL_018a;
				case 18:
					num21 = close[0];
					num14 = 0;
					num2 = 4;
					continue;
				case 37:
					array4 = new double[dataProvider.Count];
					num5 = 0;
					num4 = 0.0;
					num16 = 0.0;
					num20 = 0;
					goto case 14;
				case 51:
					num17 = num14;
					goto IL_0d21;
				case 26:
					return;
				case 23:
					num14 = num12;
					goto IL_0337;
				case 46:
					array4[num3] = 0.0;
					goto IL_0734;
				case 41:
					num10++;
					num = 30;
					break;
				case 3:
					array2[num19] = double.NaN;
					num19++;
					goto case 9;
				case 33:
					if (close[num12] < num21)
					{
						num21 = close[num12];
						num2 = 12;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_971675a329344000b7f54dccd3fcffa2 != 0)
						{
							num2 = 66;
						}
						continue;
					}
					goto IL_0337;
				case 27:
					array2[num6 - 1] = close[num6 - 1];
					zamigJQYhW9.Add(num6 - 1, new lT7wscimtLEvCIhOqnt6
					{
						GgoimTZ5tkV = true,
						LmCimU353JX = high[num6 - 1],
						Volume = array6[num6 - 1] / (double)num7,
						Delta = array7[num6 - 1] / (double)num8
					});
					goto IL_0e8d;
				case 19:
					if (array5[num12 - 1] == -1.0)
					{
						num13 = num21;
					}
					if (array9[num12] != array5[num12 - 1])
					{
						num2 = 68;
						continue;
					}
					goto case 21;
				case 38:
					if (array8[num12] == array8[num12 - 1])
					{
						goto IL_0164;
					}
					array9[num12] = array8[num12];
					goto case 1;
				case 29:
					array8[num12] = 1.0;
					goto IL_0d3d;
				case 52:
					if (!LMDt05escjqM7CKCV0XO(array2[num11]))
					{
						if (num18 >= 0)
						{
							num10 = num18 + 1;
							num2 = 13;
							if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_fbc3ce86e86648d0ab473d06282ebe5e != 0)
							{
								num2 = 10;
							}
							continue;
						}
						goto case 65;
					}
					goto case 22;
				case 67:
					array6[num12] = num4;
					array[num12] = 0.0;
					array7[num12] = num16;
					array4[num12] = 0.0;
					goto IL_028f;
				case 44:
					array5[num20] = double.NaN;
					num20++;
					num2 = 14;
					continue;
				case 59:
					if (double.IsNaN(array5[num12 - 1]))
					{
						num = 2;
						break;
					}
					goto IL_08ba;
				case 42:
					array4[num12] = num16;
					goto IL_0f4e;
				case 34:
					num17 = num15;
					goto IL_0d21;
				case 69:
					array9[num12 - 1] = array8[num12];
					num2 = 59;
					continue;
				case 17:
					array6[num12] = 0.0;
					num = 45;
					break;
				case 21:
					array5[num12] = array5[num12 - 1];
					num5 = 0;
					goto IL_018a;
				case 40:
					zamigJQYhW9 = new Dictionary<int, lT7wscimtLEvCIhOqnt6>();
					array2 = new double[LyxTx8eseBk5CQTNmXNi(dataProvider)];
					num2 = 6;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_ffb93a04ce4c4a8e857e2e7fd646df59 == 0)
					{
						num2 = 0;
					}
					continue;
				case 70:
					if (array5[num12] == 1.0)
					{
						num9 = close[num12];
						num14 = num12;
						num = 34;
						break;
					}
					goto case 62;
				case 58:
					num11 = 0;
					goto case 28;
				case 6:
					num7 = zL4yx9es56EZlK2kqKA2(1, VolumeDivisor);
					num8 = Math.Max(1, DeltaDivisor);
					num2 = 32;
					continue;
				case 4:
					num15 = 0;
					array8 = new double[LyxTx8eseBk5CQTNmXNi(dataProvider)];
					array9 = new double[dataProvider.Count];
					num2 = 31;
					continue;
				case 28:
					if (num11 >= array2.Length)
					{
						num2 = 7;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_39ef76bd8f0947d084200e4afe419409 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 52;
				case 12:
					num3 = num17 + 1;
					num2 = 57;
					continue;
				case 49:
				case 60:
					num18 = -1;
					num2 = 58;
					continue;
				default:
					num16 += delta[num3];
					if (array5[num12] == 1.0)
					{
						num2 = 43;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_4f0cf0da7be4416c854b8885e7290889 != 0)
						{
							num2 = 55;
						}
						continue;
					}
					goto IL_0734;
				case 7:
					base.Series.Add(new IndicatorSeriesData(array2, ZigZagSeries));
					num2 = 26;
					continue;
				case 11:
					zamigJQYhW9.Add(num6 - 1, new lT7wscimtLEvCIhOqnt6
					{
						GgoimTZ5tkV = true,
						LmCimU353JX = high[num6 - 1],
						Volume = array6[num6 - 1] / (double)num7,
						Delta = array7[num6 - 1] / (double)num8
					});
					num2 = 11;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0b86e69c2a884980a2238f7088b49732 == 0)
					{
						num2 = 20;
					}
					continue;
				case 10:
					if (num6 >= dataProvider.Count)
					{
						num2 = 19;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_578c88adb68d4c08b45439ab0955bb9b == 0)
						{
							num2 = 49;
						}
						continue;
					}
					goto case 36;
				case 54:
					dataProvider = base.DataProvider;
					num2 = 53;
					continue;
				case 57:
					if (num3 <= num12)
					{
						goto case 16;
					}
					goto case 15;
				case 43:
					num6++;
					num = 10;
					break;
				case 39:
					num5 = num12;
					goto IL_018a;
				case 48:
					if (num12 < LyxTx8eseBk5CQTNmXNi(dataProvider) - 1)
					{
						if (close[num12] > close[num12 - 1])
						{
							num2 = 7;
							if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_03398ebbe6224bea83047c33d24affe2 == 0)
							{
								num2 = 29;
							}
							continue;
						}
						goto IL_0d3d;
					}
					num2 = 40;
					continue;
				case 47:
					array8[num12] = 0.0;
					goto IL_0f8d;
				case 35:
					array2[num10] = (array2[num11] - array2[num18]) / (double)(num11 - num18) * (double)(num10 - num18) + array2[num18];
					num2 = 41;
					continue;
				case 36:
					array2[num6] = double.NaN;
					if (num6 == 0)
					{
						goto case 43;
					}
					if (array6[num6 - 1] == 0.0 && array6[num6] > 0.0)
					{
						num2 = 50;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0f9979478ba842a39155e14f5980ecce == 0)
						{
							num2 = 16;
						}
						continue;
					}
					if (array[num6 - 1] == 0.0 && array[num6] > 0.0)
					{
						num2 = 26;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_d4f52eaa7d9d4aa09bb6fdf0b3adf8b6 == 0)
						{
							num2 = 27;
						}
						continue;
					}
					goto IL_0e8d;
				case 45:
					array[num12] = num4;
					array7[num12] = 0.0;
					num2 = 42;
					continue;
				case 55:
					array6[num3] = num4;
					num2 = 56;
					continue;
				case 20:
					num19 = num6;
					num2 = 9;
					continue;
				case 16:
					num4 += volume[num3];
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_676dd0a5ee95448585b63eb0094d7f85 != 0)
					{
						num2 = 0;
					}
					continue;
				case 50:
					array2[num6 - 1] = close[num6 - 1];
					zamigJQYhW9.Add(num6 - 1, new lT7wscimtLEvCIhOqnt6
					{
						GgoimTZ5tkV = false,
						LmCimU353JX = array3[num6 - 1],
						Volume = array[num6 - 1] / (double)num7,
						Delta = array4[num6 - 1] / (double)num8
					});
					goto IL_0e8d;
				case 9:
					if (num19 >= LyxTx8eseBk5CQTNmXNi(dataProvider))
					{
						num2 = 60;
						continue;
					}
					goto case 3;
				case 2:
					array5[num12 - 1] = array8[num12];
					goto IL_08ba;
				case 56:
					array[num3] = 0.0;
					array7[num3] = num16;
					num2 = 23;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_a103e6559ac3474e9e79ab00912c861c == 0)
					{
						num2 = 46;
					}
					continue;
				case 66:
					num15 = num12;
					goto IL_0337;
				case 53:
					if (LyxTx8eseBk5CQTNmXNi(dataProvider) == 0)
					{
						return;
					}
					high = base.Helper.High;
					array3 = (double[])AO1F8FessWVtDXl0HrsY(base.Helper);
					num2 = 8;
					continue;
				case 1:
					num13 = 0.0;
					if (array5[num12 - 1] == 1.0)
					{
						num2 = 61;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_b6f1ae5199084abc84c46b275feb4dfd == 0)
						{
							num2 = 29;
						}
						continue;
					}
					goto case 19;
				case 14:
					if (num20 >= LyxTx8eseBk5CQTNmXNi(dataProvider))
					{
						num12 = 1;
						num2 = 1;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_16f1ffbaff15428c840c488e7b8380f5 != 0)
						{
							num2 = 48;
						}
					}
					else
					{
						array8[num20] = double.NaN;
						array9[num20] = double.NaN;
						num2 = 44;
					}
					continue;
				case 65:
					num18 = num11;
					num2 = 13;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_db5715c3607e44409516f9862a59965c == 0)
					{
						num2 = 22;
					}
					continue;
				case 71:
					if (array6[num6 - 1] > 0.0)
					{
						num2 = 3;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0ab04f3efbe746ef961577ea88d00fe3 != 0)
						{
							num2 = 25;
						}
						continue;
					}
					goto case 20;
				case 61:
					num13 = num9;
					num2 = 19;
					continue;
				case 64:
					array = new double[dataProvider.Count];
					array7 = new double[dataProvider.Count];
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e74f04d60e394f2bbc3b9757a3df6bbb == 0)
					{
						num2 = 37;
					}
					continue;
				case 15:
					if (array5[num12] == 1.0)
					{
						num2 = 67;
						continue;
					}
					goto IL_028f;
				case 13:
				case 30:
					if (num10 >= num11)
					{
						num = 65;
						break;
					}
					goto case 35;
				case 8:
					close = base.Helper.Close;
					volume = base.Helper.Volume;
					delta = base.Helper.Delta;
					num9 = close[0];
					num = 18;
					break;
				case 31:
					array5 = new double[dataProvider.Count];
					array6 = new double[dataProvider.Count];
					num2 = 64;
					continue;
				case 25:
					array2[num6 - 1] = close[num6 - 1];
					num2 = 11;
					continue;
				case 62:
					num21 = close[num12];
					num15 = num12;
					num2 = 51;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_900fe0d7516743c1bc15292a67b06048 != 0)
					{
						num2 = 0;
					}
					continue;
				case 32:
					if (num5 == 0)
					{
						num5 = LyxTx8eseBk5CQTNmXNi(dataProvider) - 1;
					}
					num6 = 0;
					goto case 10;
				case 22:
					num11++;
					num2 = 28;
					continue;
				case 24:
					array[num3] = num4;
					num2 = 63;
					continue;
				case 72:
					{
						num3++;
						goto case 57;
					}
					IL_0e8d:
					if (num6 != num5)
					{
						goto case 43;
					}
					if (array[num6 - 1] > 0.0)
					{
						array2[num6 - 1] = close[num6 - 1];
						zamigJQYhW9.Add(num6 - 1, new lT7wscimtLEvCIhOqnt6
						{
							GgoimTZ5tkV = false,
							LmCimU353JX = array3[num6 - 1],
							Volume = array[num6 - 1] / (double)num7,
							Delta = array4[num6 - 1] / (double)num8
						});
						goto case 20;
					}
					goto case 71;
					IL_0d21:
					num4 = 0.0;
					num16 = 0.0;
					num2 = 12;
					continue;
					IL_0734:
					if (array5[num12] == -1.0)
					{
						array6[num3] = 0.0;
						num2 = 13;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_fbc3ce86e86648d0ab473d06282ebe5e == 0)
						{
							num2 = 24;
						}
						continue;
					}
					goto case 72;
					IL_08ba:
					if (close[num12] > num9)
					{
						num9 = close[num12];
						num2 = 23;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_929b6fa00f634070a51f43668e9cc32e == 0)
						{
							num2 = 10;
						}
						continue;
					}
					goto case 33;
					IL_028f:
					if (array5[num12] == -1.0)
					{
						num2 = 17;
						continue;
					}
					goto IL_0f4e;
					IL_0f4e:
					num12++;
					goto case 48;
					IL_0d3d:
					if (close[num12] == close[num12 - 1])
					{
						num2 = 47;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_84ff815db08e468bb177d195221f5fb1 == 0)
						{
							num2 = 27;
						}
						continue;
					}
					goto IL_0f8d;
					IL_05f2:
					if (double.IsNaN(array9[num12 - 1]))
					{
						num2 = 33;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_c0837a76d79b485ab2d4c68f864e6ad9 != 0)
						{
							num2 = 69;
						}
						continue;
					}
					goto case 59;
					IL_0337:
					if (array8[num12] != 0.0)
					{
						num2 = 38;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_35044ecf03034683aa5038f38795ec31 != 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto IL_0164;
					IL_018a:
					if (array5[num12] != array5[num12 - 1])
					{
						num2 = 70;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_5bc14e9093324ecc8c5d7e08f50abd26 == 0)
						{
							num2 = 21;
						}
						continue;
					}
					num4 += volume[num12];
					num16 += delta[num12];
					num = 15;
					break;
					IL_0f8d:
					if (close[num12] < close[num12 - 1])
					{
						array8[num12] = -1.0;
					}
					if (double.IsNaN(array8[num12 - 1]))
					{
						goto case 5;
					}
					goto IL_05f2;
					IL_0164:
					array9[num12] = array9[num12 - 1];
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3619c4e2195548a982d8ce7a7eb0208e != 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			}
		}
	}

	public override void Render(DxVisualQueue P_0)
	{
		base.Render(P_0);
		if (zamigJQYhW9 == null)
		{
			return;
		}
		string text2 = default(string);
		double x = default(double);
		double width = default(double);
		double num4 = default(double);
		double height = default(double);
		double num3 = default(double);
		string text = default(string);
		int index = default(int);
		lT7wscimtLEvCIhOqnt6 lT7wscimtLEvCIhOqnt = default(lT7wscimtLEvCIhOqnt6);
		while (ShowVolume || ShowDelta)
		{
			int num = 0;
			int num2 = 2;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3ef08b277e78467b833a3119d7297528 == 0)
			{
				num2 = 2;
			}
			while (true)
			{
				switch (num2)
				{
				case 6:
					P_0.DrawString(text2, base.Canvas.ChartFontBold, ILyigrDFsGD, new Rect(new Point(x - width / 2.0 - 2.0, num4 - height - 10.0), new Point(x + width / 2.0 + 2.0, num4 - 10.0)), XTextAlignment.Center);
					num4 -= height + 5.0;
					goto IL_01d6;
				case 12:
					width = ((XFont)J2OyeAesjvRitdIAdsYJ(base.Canvas)).GetWidth(text2);
					num3 = O9yAn6esEWIrBI7aAEJo(J2OyeAesjvRitdIAdsYJ(base.Canvas), text);
					num2 = 13;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_5c9da2ed0d9f4b4dbc84580bf3b83e9f != 0)
					{
						num2 = 4;
					}
					continue;
				case 8:
					if (zamigJQYhW9.ContainsKey(index))
					{
						lT7wscimtLEvCIhOqnt = zamigJQYhW9[index];
						num2 = 3;
						continue;
					}
					goto case 1;
				case 13:
					if (lT7wscimtLEvCIhOqnt.GgoimTZ5tkV)
					{
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_88a7c33625fa4b38aecf07f72758e410 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					if (ShowVolume)
					{
						num2 = 11;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0d19152025c94f0b9078922cd1ec6aff != 0)
						{
							num2 = 8;
						}
						continue;
					}
					goto IL_0146;
				case 1:
					num++;
					num2 = 2;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1d290ee06e3247149fe255e31de353f8 != 0)
					{
						num2 = 4;
					}
					continue;
				case 2:
				case 4:
					if (num >= PSWC1aesdjMFk5rxorFE(base.Canvas))
					{
						return;
					}
					index = base.Canvas.GetIndex(num);
					num2 = 4;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9b268a4ae6bd40e28461cca24d9b841f == 0)
					{
						num2 = 8;
					}
					continue;
				default:
					if (ShowVolume)
					{
						num2 = 6;
						continue;
					}
					goto IL_01d6;
				case 11:
					P_0.DrawString(text2, (XFont)J2OyeAesjvRitdIAdsYJ(base.Canvas), nO4igmF3USm, new Rect(new Point(x - width / 2.0 - 2.0, num4 + 10.0), new Point(x + width / 2.0 + 2.0, num4 + 10.0 + height)), XTextAlignment.Center);
					num4 += height + 5.0;
					goto IL_0146;
				case 3:
					x = GetX(index);
					num2 = 5;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_ffb93a04ce4c4a8e857e2e7fd646df59 == 0)
					{
						num2 = 4;
					}
					continue;
				case 10:
					break;
				case 5:
					num4 = GetY(lT7wscimtLEvCIhOqnt.LmCimU353JX);
					num2 = 9;
					continue;
				case 9:
					text2 = lT7wscimtLEvCIhOqnt.Volume.ToString(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-60853733 ^ -60824881));
					text = lT7wscimtLEvCIhOqnt.Delta.ToString(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1346994499 ^ -1346965911));
					height = base.Canvas.ChartFontBold.GetHeight();
					num2 = 12;
					continue;
				case 7:
					{
						c4YMN6esQN5bdAFcyvwJ(P_0, text, base.Canvas.ChartFontBold, (lT7wscimtLEvCIhOqnt.Delta > 0.0) ? xjbigwcJ2Yx : Dnrig8vPVi5, new Rect(new Point(x - num3 / 2.0 - 2.0, num4 - height - 10.0), new Point(x + num3 / 2.0 + 2.0, num4 - 10.0)), XTextAlignment.Center);
						goto case 1;
					}
					IL_01d6:
					if (ShowDelta)
					{
						num2 = 7;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_db78327036c6481694d84ff5ec56fd0d == 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 1;
					IL_0146:
					if (!ShowDelta)
					{
						num2 = 1;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_2dae9e7b16644e7ca6575920d9bcb6e3 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					P_0.DrawString(text, (XFont)J2OyeAesjvRitdIAdsYJ(base.Canvas), (lT7wscimtLEvCIhOqnt.Delta > 0.0) ? xjbigwcJ2Yx : Dnrig8vPVi5, new Rect(new Point(x - num3 / 2.0 - 2.0, num4 + 10.0), new Point(x + num3 / 2.0 + 2.0, num4 + height + 10.0)), XTextAlignment.Center);
					goto case 1;
				}
				break;
			}
		}
	}

	public override List<IndicatorValueInfo> GetValues(int cursorPos)
	{
		List<IndicatorValueInfo> list = new List<IndicatorValueInfo>();
		foreach (IndicatorSeriesData item in base.Series)
		{
			if (!item.Style.DisableValue && cursorPos >= 0 && cursorPos < item.Length && !double.IsNaN(item[cursorPos]))
			{
				string text = "";
				if (!string.IsNullOrEmpty(item.Style.Name))
				{
					text = item.Style.Name + yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1306877528 ^ -1306918888);
				}
				text += base.Canvas.FormatValue(item[cursorPos]);
				list.Add(new IndicatorValueInfo(text, new XBrush(item.Style.Color)));
			}
		}
		return list;
	}

	public override void ApplyColors(IChartTheme P_0)
	{
		int num = 2;
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
				DownVolumeColor = vQ2BMResRKxMdpC6eWEW(P_0);
				DeltaPlusColor = Xmm7k6esgQcBtfP60k8d(P_0);
				DeltaMinusColor = vQ2BMResRKxMdpC6eWEW(P_0);
				ZigZagSeries.AllColors = OGENpYes6Co5uyuKIWHO(P_0);
				base.ApplyColors(P_0);
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f827d36f09784758a58ee73d00be2977 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				UpVolumeColor = Xmm7k6esgQcBtfP60k8d(P_0);
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f11cc1d6b7f3456db092304ccadade75 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public override void CopyTemplate(IndicatorBase P_0, bool P_1)
	{
		VWr5iiig50H4tDjriCFw vWr5iiig50H4tDjriCFw = (VWr5iiig50H4tDjriCFw)P_0;
		Period = vWr5iiig50H4tDjriCFw.Period;
		ShowVolume = vWr5iiig50H4tDjriCFw.ShowVolume;
		ShowDelta = vWr5iiig50H4tDjriCFw.ShowDelta;
		VolumeDivisor = vWr5iiig50H4tDjriCFw.VolumeDivisor;
		DeltaDivisor = nKYymbesMerbOfnwXcYs(vWr5iiig50H4tDjriCFw);
		int num = 3;
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 4:
				ZigZagSeries.CopyTheme(vWr5iiig50H4tDjriCFw.ZigZagSeries);
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_abb7f19926ed4d07ba9755366ca9a059 != 0)
				{
					num = 1;
				}
				break;
			case 3:
				UpVolumeColor = vWr5iiig50H4tDjriCFw.UpVolumeColor;
				num = 2;
				break;
			case 2:
				DownVolumeColor = vWr5iiig50H4tDjriCFw.DownVolumeColor;
				DeltaPlusColor = gg3pipesOQNSKKEhDCak(vWr5iiig50H4tDjriCFw);
				DeltaMinusColor = aA9NXmesqPXwLGdE6JoD(vWr5iiig50H4tDjriCFw);
				num = 3;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f32eaaa08a29412b875fc15d2e235a1b != 0)
				{
					num = 4;
				}
				break;
			case 1:
				base.CopyTemplate(P_0, P_1);
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e74f04d60e394f2bbc3b9757a3df6bbb != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public override string ToString()
	{
		return (string)osYKpyesIDADw5FiOtsU(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-377195341 ^ -377162941), base.Name, Period);
	}

	static VWr5iiig50H4tDjriCFw()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static int zL4yx9es56EZlK2kqKA2(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static bool EOuouaeskxfUDGW2ZdGP()
	{
		return mytyWVesNrXKCIqHq7Gg == null;
	}

	internal static VWr5iiig50H4tDjriCFw GJqTTTes1m5eY5YljHmN()
	{
		return mytyWVesNrXKCIqHq7Gg;
	}

	internal static object GVpK65esSI6MoHny2ew1(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static XColor mQidYTesxZtE7q5COwDd(Color P_0)
	{
		return P_0;
	}

	internal static bool tWRcmqesLQDTZBYRjHYl(object P_0, object P_1)
	{
		return object.Equals(P_0, P_1);
	}

	internal static int LyxTx8eseBk5CQTNmXNi(object P_0)
	{
		return ((IChartDataProvider)P_0).Count;
	}

	internal static object AO1F8FessWVtDXl0HrsY(object P_0)
	{
		return ((IndicatorsHelper)P_0).Low;
	}

	internal static double LsZ9H7esXtl2GjXZXeXH(double P_0)
	{
		return Math.Abs(P_0);
	}

	internal static bool LMDt05escjqM7CKCV0XO(double P_0)
	{
		return double.IsNaN(P_0);
	}

	internal static object J2OyeAesjvRitdIAdsYJ(object P_0)
	{
		return ((IChartCanvas)P_0).ChartFontBold;
	}

	internal static double O9yAn6esEWIrBI7aAEJo(object P_0, object P_1)
	{
		return ((XFont)P_0).GetWidth((string)P_1);
	}

	internal static void c4YMN6esQN5bdAFcyvwJ(object P_0, object P_1, object P_2, object P_3, Rect P_4, XTextAlignment P_5)
	{
		((DxVisualQueue)P_0).DrawString((string)P_1, (XFont)P_2, (XBrush)P_3, P_4, P_5);
	}

	internal static int PSWC1aesdjMFk5rxorFE(object P_0)
	{
		return ((IChartCanvas)P_0).Count;
	}

	internal static XColor Xmm7k6esgQcBtfP60k8d(object P_0)
	{
		return ((IChartTheme)P_0).PaletteColor6;
	}

	internal static XColor vQ2BMResRKxMdpC6eWEW(object P_0)
	{
		return ((IChartTheme)P_0).PaletteColor7;
	}

	internal static XColor OGENpYes6Co5uyuKIWHO(object P_0)
	{
		return ((IChartTheme)P_0).GetNextColor();
	}

	internal static int nKYymbesMerbOfnwXcYs(object P_0)
	{
		return ((VWr5iiig50H4tDjriCFw)P_0).DeltaDivisor;
	}

	internal static XColor gg3pipesOQNSKKEhDCak(object P_0)
	{
		return ((VWr5iiig50H4tDjriCFw)P_0).DeltaPlusColor;
	}

	internal static XColor aA9NXmesqPXwLGdE6JoD(object P_0)
	{
		return ((VWr5iiig50H4tDjriCFw)P_0).DeltaMinusColor;
	}

	internal static object osYKpyesIDADw5FiOtsU(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}
}
