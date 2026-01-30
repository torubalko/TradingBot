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
using TigerTrade.Chart.Base.Enums;
using TigerTrade.Chart.Data;
using TigerTrade.Chart.Indicators.Common;
using TigerTrade.Chart.Indicators.Enums;
using TigerTrade.Chart.Indicators.List;
using TigerTrade.Core.Utils.Time;
using TigerTrade.Dx;

namespace cw0yLRiefXND2VFfAHq4;

[DataContract(Name = "OpenInterestIndicator", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
[Indicator("OpenInterest", "OpenInterest", false, Type = typeof(s78kgqieHSKNCKKjIcl2))]
internal sealed class s78kgqieHSKNCKKjIcl2 : IndicatorBase
{
	private class GgqECliK1JTZFNpZTou1
	{
		public long JSbiK5wlAH6;

		public long Qx7iKSOkY7p;

		public long faEiKxOa3fC;

		public long Close;

		public long JlwiKLQYKdn;

		public long OpenInt;

		public long tmGiKe5cknv;

		private static GgqECliK1JTZFNpZTou1 PNIEFQeU6xQPP38aZaL7;

		public GgqECliK1JTZFNpZTou1()
		{
			tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
			JlwiKLQYKdn = -1L;
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0fb675c372064c2d9cad17812d8d65ed != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		static GgqECliK1JTZFNpZTou1()
		{
			yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
			fXqQF4eUqNA6Drqo17BI();
		}

		internal static bool gwgprFeUMGxYelnDuMh8()
		{
			return PNIEFQeU6xQPP38aZaL7 == null;
		}

		internal static GgqECliK1JTZFNpZTou1 BFxLqkeUOV49pCPiwCex()
		{
			return PNIEFQeU6xQPP38aZaL7;
		}

		internal static void fXqQF4eUqNA6Drqo17BI()
		{
			ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
		}
	}

	private OpenInterestDataType Pclie1iPVSu;

	private OpenInterestPeriodType lreie5XlurX;

	private IndicatorViewType XkWieSf2Tul;

	private XBrush x3biexZJXap;

	private XPen HLoieLB2wJc;

	private XColor bxdieesWaTC;

	private XBrush UPWiesF5BR9;

	private XPen uHQieXcESXc;

	private XColor Jwsiecxyi69;

	private XBrush FrUiejIRTo1;

	private XPen IrQieEok0dK;

	private XColor k09ieQgYu7b;

	private int AKRiedRRYy3;

	private int Ul4iegkYqs0;

	private List<GgqECliK1JTZFNpZTou1> V4nieRsptak;

	internal static s78kgqieHSKNCKKjIcl2 pUGQ3Pe5oRT65CT3JZkF;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.Bar;

	[DataMember(Name = "DataType")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsOpenInterestDataType")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	public OpenInterestDataType DataType
	{
		get
		{
			return Pclie1iPVSu;
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
					if (openInterestDataType == Pclie1iPVSu)
					{
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_cb7997a2f13d4554bdeb2d98b82239ee == 0)
						{
							num2 = 0;
						}
						break;
					}
					Pclie1iPVSu = openInterestDataType;
					Clear();
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-2017337494 ^ -2017377334));
					num2 = 2;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f866dbb44e884db6a20dd750c320252b == 0)
					{
						num2 = 2;
					}
					break;
				case 2:
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-5977659 ^ -6006559));
					return;
				case 0:
					return;
				}
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsPeriod")]
	[DataMember(Name = "Period")]
	public OpenInterestPeriodType Period
	{
		get
		{
			return lreie5XlurX;
		}
		set
		{
			if (openInterestPeriodType == lreie5XlurX)
			{
				return;
			}
			lreie5XlurX = openInterestPeriodType;
			Clear();
			OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-837284864 ^ -837252170));
			int num = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8c0cafc031434e41bde083ffe3129211 != 0)
			{
				num = 0;
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
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-53782092 ^ -53753712));
					num = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3f2f2649293a4bcf83895b4d6c7abca6 == 0)
					{
						num = 0;
					}
					break;
				}
			}
		}
	}

	[DataMember(Name = "Type")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsType")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	public IndicatorViewType Type
	{
		get
		{
			return XkWieSf2Tul;
		}
		set
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x741B85CB ^ 0x741B11BF));
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1192989954 ^ -1192952200));
					OnPropertyChanged((string)S171DQe5atxgKn7ndmMO(0x78D396D8 ^ 0x78D31050));
					OnPropertyChanged((string)S171DQe5atxgKn7ndmMO(-673683647 ^ -673652257));
					num2 = 3;
					break;
				case 1:
					return;
				case 2:
					if (indicatorViewType != XkWieSf2Tul)
					{
						XkWieSf2Tul = indicatorViewType;
						OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x2D3134C9 ^ 0x2D31A5D1));
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_14b81aa01f3b465ba9caee83d494621b != 0)
						{
							num2 = 0;
						}
					}
					else
					{
						num2 = 1;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_2dae9e7b16644e7ca6575920d9bcb6e3 == 0)
						{
							num2 = 1;
						}
					}
					break;
				case 3:
					return;
				}
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsUpColor")]
	[DataMember(Name = "UpColor")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsStyle")]
	public XColor UpColor
	{
		get
		{
			return bxdieesWaTC;
		}
		set
		{
			if (!(xColor == bxdieesWaTC))
			{
				bxdieesWaTC = xColor;
				x3biexZJXap = new XBrush(bxdieesWaTC);
				int num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_66132b7977414fa9a4eabdda3db7b75c == 0)
				{
					num = 1;
				}
				switch (num)
				{
				case 1:
					HLoieLB2wJc = new XPen(x3biexZJXap, 1);
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-90307782 ^ -90269874));
					break;
				case 0:
					break;
				}
			}
		}
	}

	[DataMember(Name = "DownColor")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsDownColor")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsStyle")]
	public XColor DownColor
	{
		get
		{
			return Jwsiecxyi69;
		}
		set
		{
			if (xColor == Jwsiecxyi69)
			{
				return;
			}
			Jwsiecxyi69 = xColor;
			int num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_cb7997a2f13d4554bdeb2d98b82239ee != 0)
			{
				num = 1;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					UPWiesF5BR9 = new XBrush(Jwsiecxyi69);
					num = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_22d3e151413e4c568d725fa731c4c03c == 0)
					{
						num = 0;
					}
					break;
				default:
					uHQieXcESXc = new XPen(UPWiesF5BR9, 1);
					OnPropertyChanged((string)S171DQe5atxgKn7ndmMO(0x28C965BE ^ 0x28C9F138));
					return;
				}
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsStyle")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsLineColor")]
	[DataMember(Name = "LineColor")]
	public XColor LineColor
	{
		get
		{
			return k09ieQgYu7b;
		}
		set
		{
			if (inAUdwe5irG5K199oP6d(xColor, k09ieQgYu7b))
			{
				return;
			}
			k09ieQgYu7b = xColor;
			FrUiejIRTo1 = new XBrush(k09ieQgYu7b);
			IrQieEok0dK = new XPen(FrUiejIRTo1, LineWidth);
			int num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_900fe0d7516743c1bc15292a67b06048 == 0)
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
				OnPropertyChanged((string)S171DQe5atxgKn7ndmMO(-377195341 ^ -377163205));
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9907a2dfacd24021aae0fe30c599035f == 0)
				{
					num = 1;
				}
			}
		}
	}

	[DataMember(Name = "LineWidth")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsLineWidth")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsStyle")]
	public int LineWidth
	{
		get
		{
			return AKRiedRRYy3;
		}
		set
		{
			num = Math.Max(1, Math.Min(9, num));
			int num2;
			if (num != AKRiedRRYy3)
			{
				AKRiedRRYy3 = num;
				IrQieEok0dK = new XPen(FrUiejIRTo1, AKRiedRRYy3);
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x2CBEEA31 ^ 0x2CBE6CAF));
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_4c510febac3445efbec11458d423f537 != 0)
				{
					num2 = 1;
				}
			}
			else
			{
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_5bc14e9093324ecc8c5d7e08f50abd26 == 0)
				{
					num2 = 0;
				}
			}
			switch (num2)
			{
			case 0:
				break;
			case 1:
				break;
			}
		}
	}

	[Browsable(false)]
	public override IndicatorCalculation Calculation => IndicatorCalculation.OnEachTick;

	private List<GgqECliK1JTZFNpZTou1> Items => V4nieRsptak ?? (V4nieRsptak = new List<GgqECliK1JTZFNpZTou1>());

	public override bool IntegerValues => true;

	private void Clear()
	{
		Ul4iegkYqs0 = 0;
		Items.Clear();
	}

	public s78kgqieHSKNCKKjIcl2()
	{
		nF9hVye5lRBDCNIHt9bi();
		base._002Ector();
		DataType = OpenInterestDataType.All;
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 1:
				LineWidth = 1;
				return;
			case 3:
				Type = IndicatorViewType.Columns;
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e767fb04e1fb471592fd70a4ebcca575 != 0)
				{
					num = 0;
				}
				continue;
			case 2:
				Period = OpenInterestPeriodType.Bar;
				num = 3;
				continue;
			}
			UpColor = oFVFure54fvCCOPSccZa(byte.MaxValue, 30, 144, byte.MaxValue);
			DownColor = Color.FromArgb(byte.MaxValue, 178, 34, 34);
			LineColor = DkldZNe5DSIcO5jknFnP(Color.FromArgb(byte.MaxValue, 30, 144, byte.MaxValue));
			num = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1e4f0311079548309df28e40c8b3397b == 0)
			{
				num = 0;
			}
		}
	}

	protected override void Execute()
	{
		if (base.ClearData)
		{
			Clear();
		}
		double timeOffset = AcBlFye5NdCdeASTx2S6(d4Dn06e5b1JtpKInnL1h(base.DataProvider.Symbol));
		int num = Ul4iegkYqs0;
		int num2 = 28;
		long num4 = default(long);
		GgqECliK1JTZFNpZTou1 ggqECliK1JTZFNpZTou2 = default(GgqECliK1JTZFNpZTou1);
		long jSbiK5wlAH = default(long);
		long num5 = default(long);
		IRawCluster rawCluster = default(IRawCluster);
		GgqECliK1JTZFNpZTou1 ggqECliK1JTZFNpZTou = default(GgqECliK1JTZFNpZTou1);
		int num3 = default(int);
		while (true)
		{
			int num6;
			switch (num2)
			{
			case 10:
				num4 = ggqECliK1JTZFNpZTou2.tmGiKe5cknv;
				jSbiK5wlAH = ggqECliK1JTZFNpZTou2.OpenInt - num4;
				num5 = rawCluster.OpenPos - num4;
				num2 = 29;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_2768cd202ec04d099c20ba8e1925b378 != 0)
				{
					num2 = 15;
				}
				break;
			case 3:
				ggqECliK1JTZFNpZTou.faEiKxOa3fC = rawCluster.OpenPosLow - num4;
				goto case 6;
			case 25:
				ggqECliK1JTZFNpZTou.Close = num5;
				num2 = 23;
				break;
			case 7:
				ggqECliK1JTZFNpZTou.Qx7iKSOkY7p = RbA9m3e5S5ZbbWTxUg1j(rawCluster);
				ggqECliK1JTZFNpZTou.faEiKxOa3fC = rawCluster.OpenPosLow;
				num2 = 3;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_77d26139d1074373ba3d17cb18b3ec16 == 0)
				{
					num2 = 15;
				}
				break;
			case 6:
			case 31:
				num++;
				goto case 28;
			case 23:
				ggqECliK1JTZFNpZTou.JSbiK5wlAH6 = jSbiK5wlAH;
				ggqECliK1JTZFNpZTou.Qx7iKSOkY7p = rawCluster.OpenPosHigh - num4;
				num2 = 3;
				break;
			case 20:
				ggqECliK1JTZFNpZTou.JSbiK5wlAH6 = ggqECliK1JTZFNpZTou2.OpenInt;
				ggqECliK1JTZFNpZTou.Close = ggqECliK1JTZFNpZTou2.OpenInt + EYJduGe5Lv7mbMShuj0v(rawCluster);
				ggqECliK1JTZFNpZTou.Qx7iKSOkY7p = Math.Max(ggqECliK1JTZFNpZTou.JSbiK5wlAH6, ggqECliK1JTZFNpZTou.Close);
				num2 = 11;
				break;
			case 24:
				return;
			case 8:
				goto IL_02bf;
			case 21:
				ggqECliK1JTZFNpZTou.Close = ggqECliK1JTZFNpZTou2.OpenInt + zlTitue5e3fn9dWna2Fw(rawCluster);
				ggqECliK1JTZFNpZTou.Qx7iKSOkY7p = Math.Max(ggqECliK1JTZFNpZTou.JSbiK5wlAH6, ggqECliK1JTZFNpZTou.Close);
				ggqECliK1JTZFNpZTou.faEiKxOa3fC = Math.Min(ggqECliK1JTZFNpZTou.JSbiK5wlAH6, ggqECliK1JTZFNpZTou.Close);
				ggqECliK1JTZFNpZTou.OpenInt = ggqECliK1JTZFNpZTou.Close;
				num2 = 6;
				break;
			case 28:
				if (num >= base.DataProvider.Count)
				{
					num2 = 21;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_555a94ebd4594650b107ef6bf239937f != 0)
					{
						num2 = 32;
					}
					break;
				}
				goto case 18;
			case 5:
				ggqECliK1JTZFNpZTou2.OpenInt = 0L;
				goto IL_0293;
			case 9:
				num3 = WM9nNTe51HRwZpsVQhHQ(base.DataProvider.Period, ChartPeriodType.Day, 1, rawCluster.Time, timeOffset);
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_4c510febac3445efbec11458d423f537 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
			case 2:
				goto IL_03d0;
			default:
				ggqECliK1JTZFNpZTou.OpenInt = rawCluster.OpenPos;
				ggqECliK1JTZFNpZTou.tmGiKe5cknv = num4;
				num2 = 25;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bddbd469f60045dea35a495487f8a4fb == 0)
				{
					num2 = 17;
				}
				break;
			case 22:
				num4 = ggqECliK1JTZFNpZTou2.OpenInt;
				jSbiK5wlAH = 0L;
				num5 = rawCluster.OpenPos - ggqECliK1JTZFNpZTou2.OpenInt;
				if (num5 != 0L)
				{
					goto case 17;
				}
				num5 = rawCluster.OpenPosChg;
				num4 -= NxUb8Ie5x0js0QyuGmEG(rawCluster);
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bddbd469f60045dea35a495487f8a4fb != 0)
				{
					num2 = 17;
				}
				break;
			case 16:
				ggqECliK1JTZFNpZTou.JlwiKLQYKdn = num3;
				num2 = 17;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_d4f52eaa7d9d4aa09bb6fdf0b3adf8b6 == 0)
				{
					num2 = 20;
				}
				break;
			case 15:
				if (ggqECliK1JTZFNpZTou.JSbiK5wlAH6 == 0L)
				{
					ggqECliK1JTZFNpZTou.JSbiK5wlAH6 = ggqECliK1JTZFNpZTou.Close;
					num2 = 5;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bf5c5dff42eb4dbcb67f23c8a54dc750 == 0)
					{
						num2 = 31;
					}
					break;
				}
				goto case 6;
			case 26:
				ggqECliK1JTZFNpZTou = Items[num];
				num2 = 14;
				break;
			case 27:
				ggqECliK1JTZFNpZTou2.OpenInt = 0L;
				num2 = 7;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_88a7c33625fa4b38aecf07f72758e410 != 0)
				{
					num2 = 16;
				}
				break;
			case 18:
				rawCluster = base.DataProvider.GetRawCluster(num);
				if (AI4CeCe5kY3DKf3CSe5L(Items) < num + 1)
				{
					Items.Add(new GgqECliK1JTZFNpZTou1());
					num2 = 26;
					break;
				}
				goto case 26;
			case 4:
				goto IL_04e4;
			case 32:
				Ul4iegkYqs0 = Math.Max(HcIDx9e5sS8S53dVJLfC(base.DataProvider) - 2, 0);
				num2 = 18;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_14b81aa01f3b465ba9caee83d494621b == 0)
				{
					num2 = 24;
				}
				break;
			case 12:
				goto IL_0525;
			case 29:
				if (num3 != ggqECliK1JTZFNpZTou2.JlwiKLQYKdn)
				{
					num2 = 22;
					break;
				}
				goto case 17;
			case 30:
				ggqECliK1JTZFNpZTou.JSbiK5wlAH6 = ggqECliK1JTZFNpZTou2.OpenInt;
				num2 = 21;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_77d26139d1074373ba3d17cb18b3ec16 != 0)
				{
					num2 = 10;
				}
				break;
			case 17:
				ggqECliK1JTZFNpZTou.JlwiKLQYKdn = num3;
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1a52446ff7d24524a71087c98b41bbc6 != 0)
				{
					num2 = 0;
				}
				break;
			case 13:
				ggqECliK1JTZFNpZTou.OpenInt = ggqECliK1JTZFNpZTou.Close;
				goto case 6;
			case 14:
				ggqECliK1JTZFNpZTou2 = ((num > 0 && Items.Count > 1) ? Items[num - 1] : new GgqECliK1JTZFNpZTou1
				{
					OpenInt = rawCluster.OpenPos,
					tmGiKe5cknv = rawCluster.OpenPos
				});
				num3 = 1;
				switch (Period)
				{
				case OpenInterestPeriodType.Day:
					break;
				default:
					goto IL_03d0;
				case OpenInterestPeriodType.Bar:
					goto IL_04e4;
				case OpenInterestPeriodType.AllBars:
					goto IL_0525;
				case OpenInterestPeriodType.Week:
					num3 = WM9nNTe51HRwZpsVQhHQ(base.DataProvider.Period, ChartPeriodType.Week, 1, rawCluster.Time, timeOffset);
					goto IL_03d0;
				case OpenInterestPeriodType.Month:
					goto IL_0702;
				}
				goto case 9;
			case 19:
				goto IL_0702;
			case 11:
				{
					ggqECliK1JTZFNpZTou.faEiKxOa3fC = Math.Min(ggqECliK1JTZFNpZTou.JSbiK5wlAH6, ggqECliK1JTZFNpZTou.Close);
					num2 = 12;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0cda726836d64094b2c4c18a328cd3aa == 0)
					{
						num2 = 13;
					}
					break;
				}
				IL_0241:
				if (num3 != ggqECliK1JTZFNpZTou2.JlwiKLQYKdn)
				{
					num2 = 5;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9b268a4ae6bd40e28461cca24d9b841f != 0)
					{
						num2 = 5;
					}
					break;
				}
				goto IL_0293;
				IL_0702:
				num3 = base.DataProvider.Period.GetSequence(ChartPeriodType.Month, 1, rawCluster.Time, timeOffset);
				goto IL_03d0;
				IL_0293:
				ggqECliK1JTZFNpZTou.JlwiKLQYKdn = num3;
				num6 = 30;
				num2 = num6;
				break;
				IL_0525:
				num3 = -1;
				goto IL_03d0;
				IL_04e4:
				num3 = num;
				num2 = 2;
				break;
				IL_02bf:
				if (num3 != ggqECliK1JTZFNpZTou2.JlwiKLQYKdn)
				{
					num2 = 27;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_77d26139d1074373ba3d17cb18b3ec16 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 16;
				IL_03d0:
				switch (DataType)
				{
				case OpenInterestDataType.Sells:
					goto IL_0241;
				case OpenInterestDataType.Buys:
					goto IL_02bf;
				case OpenInterestDataType.All:
					goto IL_0692;
				}
				goto case 6;
				IL_0692:
				if (Period == OpenInterestPeriodType.AllBars)
				{
					ggqECliK1JTZFNpZTou.Close = Ev7sTFe55PvrQ8pOxY0o(rawCluster);
					ggqECliK1JTZFNpZTou.JSbiK5wlAH6 = ggqECliK1JTZFNpZTou2.Close;
					num2 = 2;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_fbc3ce86e86648d0ab473d06282ebe5e == 0)
					{
						num2 = 7;
					}
					break;
				}
				goto case 10;
			}
		}
	}

	public override bool GetMinMax(out double P_0, out double P_1)
	{
		int num = 1;
		int num2 = num;
		int num5 = default(int);
		int num4 = default(int);
		long num3 = default(long);
		GgqECliK1JTZFNpZTou1 ggqECliK1JTZFNpZTou2 = default(GgqECliK1JTZFNpZTou1);
		long num6 = default(long);
		int num7 = default(int);
		int index = default(int);
		GgqECliK1JTZFNpZTou1 ggqECliK1JTZFNpZTou = default(GgqECliK1JTZFNpZTou1);
		while (true)
		{
			switch (num2)
			{
			case 13:
				num5 = Xv0wA7e5X72Psc44bTUV(base.Canvas, num4);
				if (num5 >= 0 && num5 < AI4CeCe5kY3DKf3CSe5L(Items))
				{
					num2 = 4;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3f2f2649293a4bcf83895b4d6c7abca6 == 0)
					{
						num2 = 8;
					}
					break;
				}
				goto case 5;
			case 1:
				P_0 = double.MaxValue;
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_343b2874cf5f4ef7b098544546ed76b2 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				if (num3 < ggqECliK1JTZFNpZTou2.Close)
				{
					num3 = ggqECliK1JTZFNpZTou2.Close;
				}
				goto IL_02bb;
			case 7:
				num6 = ggqECliK1JTZFNpZTou2.Close;
				num2 = 3;
				break;
			case 15:
				num7 = 0;
				goto IL_02e0;
			case 10:
				ggqECliK1JTZFNpZTou2 = Items[index];
				if (num6 > ggqECliK1JTZFNpZTou2.Close)
				{
					num2 = 7;
					break;
				}
				goto case 3;
			case 4:
			case 9:
				if (num4 < Tsatuve5c1V5LxTf2Lti(base.Canvas))
				{
					goto case 13;
				}
				goto IL_024f;
			case 6:
				if (index < AI4CeCe5kY3DKf3CSe5L(Items))
				{
					num2 = 10;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_025edf4a83be4acb8c8326612d0fc8c2 != 0)
					{
						num2 = 4;
					}
					break;
				}
				goto IL_02bb;
			default:
				P_1 = double.MinValue;
				if (Items.Count != 0)
				{
					num6 = long.MaxValue;
					num3 = long.MinValue;
					if (Type == IndicatorViewType.Candles)
					{
						num2 = 14;
						break;
					}
					goto case 15;
				}
				num2 = 2;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bb112ee1b0d04deb878f0e8052d708a1 == 0)
				{
					num2 = 11;
				}
				break;
			case 11:
				return false;
			case 2:
				num6 = ggqECliK1JTZFNpZTou.faEiKxOa3fC;
				goto IL_016b;
			case 5:
				num4++;
				num2 = 4;
				break;
			case 8:
				ggqECliK1JTZFNpZTou = Items[num5];
				if (num6 > ggqECliK1JTZFNpZTou.faEiKxOa3fC)
				{
					num2 = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_14b81aa01f3b465ba9caee83d494621b == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto IL_016b;
			case 14:
				num4 = 0;
				num2 = 9;
				break;
			case 12:
				{
					P_1 = num3;
					return true;
				}
				IL_016b:
				if (num3 < ggqECliK1JTZFNpZTou.Qx7iKSOkY7p)
				{
					num3 = ggqECliK1JTZFNpZTou.Qx7iKSOkY7p;
					num2 = 5;
					break;
				}
				goto case 5;
				IL_02bb:
				num7++;
				goto IL_02e0;
				IL_02e0:
				if (num7 < base.Canvas.Count)
				{
					index = base.Canvas.GetIndex(num7);
					if (index >= 0)
					{
						num2 = 6;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1c1cbcfc982140d18e7033a6f2f9ec87 == 0)
						{
							num2 = 6;
						}
						break;
					}
					goto IL_02bb;
				}
				goto IL_024f;
				IL_024f:
				if (num6 > num3)
				{
					return false;
				}
				P_0 = num6;
				num2 = 12;
				break;
			}
		}
	}

	public override void Render(DxVisualQueue P_0)
	{
		double y = default(double);
		int num5;
		Point[] array = default(Point[]);
		int num2 = default(int);
		int num3 = default(int);
		double num4 = default(double);
		int num;
		double num20 = default(double);
		XPen xPen = default(XPen);
		int num9 = default(int);
		int num10 = default(int);
		int index = default(int);
		GgqECliK1JTZFNpZTou1 ggqECliK1JTZFNpZTou = default(GgqECliK1JTZFNpZTou1);
		int num17 = default(int);
		int index2 = default(int);
		int num6 = default(int);
		int num7 = default(int);
		int num8 = default(int);
		int num11 = default(int);
		double num19 = default(double);
		bool flag = default(bool);
		int num16 = default(int);
		double num18 = default(double);
		int num15 = default(int);
		Rect rect = default(Rect);
		XBrush brush = default(XBrush);
		int index3 = default(int);
		GgqECliK1JTZFNpZTou1 ggqECliK1JTZFNpZTou3 = default(GgqECliK1JTZFNpZTou1);
		switch (Type)
		{
		case IndicatorViewType.Columns:
			y = GetY(0.0);
			num5 = 17;
			goto IL_0005;
		case IndicatorViewType.Line:
			if (Items.Count < 2)
			{
				break;
			}
			array = new Point[base.Canvas.Count];
			num2 = 0;
			goto IL_060b;
		case IndicatorViewType.Candles:
			num3 = (int)(base.Canvas.ColumnWidth * base.Canvas.ColumnPercent + 0.4);
			num4 = Math.Max((int)((double)num3 / 2.0), 1.0);
			num = 14;
			goto IL_0009;
		default:
			{
				num = 19;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8c0cafc031434e41bde083ffe3129211 != 0)
				{
					num = 12;
				}
				goto IL_0009;
			}
			IL_01a3:
			num2++;
			num = 10;
			goto IL_0009;
			IL_0556:
			num5 = 6;
			goto IL_0005;
			IL_0005:
			num = num5;
			goto IL_0009;
			IL_0009:
			while (true)
			{
				XPen hLoieLB2wJc;
				switch (num)
				{
				case 11:
					if (num20 > 1.0)
					{
						num = 24;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_abb7f19926ed4d07ba9755366ca9a059 == 0)
						{
							num = 8;
						}
						continue;
					}
					goto case 8;
				case 27:
					if (num3 > 1)
					{
						num = 9;
						continue;
					}
					goto IL_0271;
				case 20:
					P_0.DrawLine(xPen, new Point((double)num9 - num4, num10), new Point((double)num9 + num4 + 1.0, num10));
					goto IL_0271;
				case 25:
					if (index < Items.Count)
					{
						ggqECliK1JTZFNpZTou = Items[index];
						num = 16;
						continue;
					}
					goto IL_0271;
				case 23:
					if (num17 >= Tsatuve5c1V5LxTf2Lti(base.Canvas))
					{
						return;
					}
					index2 = base.Canvas.GetIndex(num17);
					if (index2 >= 0)
					{
						num = 9;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9efcb4330c5f47718251cef6f720f6e6 == 0)
						{
							num = 13;
						}
						continue;
					}
					goto case 4;
				case 5:
					hLoieLB2wJc = uHQieXcESXc;
					goto IL_0727;
				case 2:
					if (num6 == 0 || num3 <= 1)
					{
						if (num7 == num8)
						{
							num8++;
						}
						w0gLdNe5QPciY95S6vSb(P_0, xPen, new Point(num9, num7), new Point(num9, num8));
						goto case 27;
					}
					P_0.DrawLine(xPen, new Point(num9, num7), new Point(num9, num10));
					num = 18;
					continue;
				case 26:
					num11 = -num11;
					goto IL_01fa;
				case 1:
					return;
				case 7:
					num11 = (int)y - (int)num19;
					flag = num11 > 0;
					num = 17;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_739f779654714fe286f27606d950a9d9 == 0)
					{
						num = 22;
					}
					continue;
				case 3:
					return;
				case 21:
					if (num16 < base.Canvas.Count)
					{
						index = base.Canvas.GetIndex(num16);
						if (index >= 0)
						{
							num = 25;
							continue;
						}
						goto IL_0271;
					}
					goto IL_02ff;
				case 13:
					if (index2 < Items.Count)
					{
						GgqECliK1JTZFNpZTou1 ggqECliK1JTZFNpZTou2 = Items[index2];
						num18 = Cjm4vre5jR4dnxnsYGcF(base.Canvas, index2);
						num19 = GetY((double)ggqECliK1JTZFNpZTou2.Close);
						num = 7;
						continue;
					}
					goto case 4;
				case 22:
					if ((double)num11 < 0.0)
					{
						num19 += (double)num11;
						num = 26;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_555a94ebd4594650b107ef6bf239937f == 0)
						{
							num = 7;
						}
						continue;
					}
					goto IL_01fa;
				case 4:
					num17++;
					goto case 23;
				case 14:
					num16 = 0;
					num = 21;
					continue;
				case 12:
					break;
				case 28:
					goto IL_03d9;
				case 18:
					P_0.DrawLine(xPen, new Point(num9, num15), new Point(num9, num8));
					num = 21;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_96ae262178274a62bc28b3fded6ea751 == 0)
					{
						num = 27;
					}
					continue;
				case 19:
					return;
				case 24:
					rect = new Rect(num18 - num20 / 2.0, num19, num20, num11);
					num = 15;
					continue;
				case 9:
					if (num6 == 0)
					{
						goto case 20;
					}
					goto IL_0556;
				default:
					P_0.FillRectangle(brush, new Rect((double)num9 - num4, num10, num4 * 2.0 + 1.0, num6));
					goto IL_0271;
				case 17:
					num20 = WKUu5Ke5dWdBafYflln7(base.Canvas.ColumnWidth - 1.0, 1.0);
					num17 = 0;
					num = 10;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_cb7997a2f13d4554bdeb2d98b82239ee != 0)
					{
						num = 23;
					}
					continue;
				case 10:
					goto end_IL_0009;
				case 16:
				{
					bool num12 = ggqECliK1JTZFNpZTou.Close > ggqECliK1JTZFNpZTou.JSbiK5wlAH6;
					num9 = (int)Cjm4vre5jR4dnxnsYGcF(base.Canvas, index);
					int num13 = (int)GetY((double)ggqECliK1JTZFNpZTou.JSbiK5wlAH6);
					num7 = (int)GetY((double)ggqECliK1JTZFNpZTou.Qx7iKSOkY7p);
					num8 = (int)GetY((double)ggqECliK1JTZFNpZTou.faEiKxOa3fC);
					int num14 = (int)GetY((double)ggqECliK1JTZFNpZTou.Close);
					num10 = Math.Min(num13, num14);
					num15 = lxmqVIe5EofDWLWycF9L(num13, num14);
					num6 = num15 - num10;
					brush = (num12 ? x3biexZJXap : UPWiesF5BR9);
					if (!num12)
					{
						goto IL_0713;
					}
					hLoieLB2wJc = HLoieLB2wJc;
					goto IL_0727;
				}
				case 15:
					P_0.FillRectangle(flag ? x3biexZJXap : UPWiesF5BR9, rect);
					num = 4;
					continue;
				case 8:
					{
						P_0.DrawLine(flag ? HLoieLB2wJc : uHQieXcESXc, num18, num19, num18, num19 + (double)num11);
						goto case 4;
					}
					IL_01fa:
					num11 = lxmqVIe5EofDWLWycF9L(1, num11);
					num = 11;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9b268a4ae6bd40e28461cca24d9b841f != 0)
					{
						num = 1;
					}
					continue;
					IL_0271:
					num16++;
					goto case 21;
					IL_0727:
					xPen = hLoieLB2wJc;
					num = 2;
					continue;
				}
				if (index3 < AI4CeCe5kY3DKf3CSe5L(Items))
				{
					ggqECliK1JTZFNpZTou3 = Items[index3];
					num = 28;
					continue;
				}
				goto IL_01a3;
				IL_03d9:
				double x = Cjm4vre5jR4dnxnsYGcF(base.Canvas, index3);
				double y2 = GetY((double)ggqECliK1JTZFNpZTou3.Close);
				array[num2] = new Point(x, y2);
				goto IL_01a3;
				continue;
				end_IL_0009:
				break;
			}
			goto IL_060b;
			IL_0713:
			num5 = 5;
			goto IL_0005;
			IL_060b:
			if (num2 < base.Canvas.Count)
			{
				index3 = base.Canvas.GetIndex(num2);
				if (index3 < 0)
				{
					goto IL_01a3;
				}
				num = 12;
			}
			else
			{
				P_0.DrawLines(IrQieEok0dK, array);
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_cb7997a2f13d4554bdeb2d98b82239ee == 0)
				{
					num = 0;
				}
			}
			goto IL_0009;
			IL_02ff:
			num5 = 3;
			goto IL_0005;
		}
	}

	public override List<IndicatorValueInfo> GetValues(int cursorPos)
	{
		List<IndicatorValueInfo> list = new List<IndicatorValueInfo>();
		if (cursorPos >= 0 && cursorPos < Items.Count)
		{
			string value = base.Canvas.FormatValue(Items[cursorPos].Close);
			list.Add(new IndicatorValueInfo(value, (Type == IndicatorViewType.Line) ? FrUiejIRTo1 : base.Canvas.Theme.ChartFontBrush));
		}
		return list;
	}

	public override void GetLabels(ref List<IndicatorLabelInfo> P_0)
	{
		if (AI4CeCe5kY3DKf3CSe5L(Items) == 0)
		{
			return;
		}
		int num = default(int);
		int num2;
		if (base.DataProvider.Count > base.Canvas.Start)
		{
			num = base.DataProvider.Count - 1 - base.Canvas.Start;
			num2 = 6;
		}
		else
		{
			num2 = 5;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f6da77aaa5ff4528962aa5751faa8c0b != 0)
			{
				num2 = 5;
			}
		}
		long close = default(long);
		GgqECliK1JTZFNpZTou1 ggqECliK1JTZFNpZTou = default(GgqECliK1JTZFNpZTou1);
		bool flag = default(bool);
		IndicatorViewType indicatorViewType = default(IndicatorViewType);
		while (true)
		{
			int num3;
			switch (num2)
			{
			default:
				if (!lnNsU8e5gAtDD9T74PVO(close))
				{
					goto case 8;
				}
				num3 = 0;
				goto IL_020d;
			case 1:
			{
				close = ggqECliK1JTZFNpZTou.Close;
				int num4 = 4;
				num2 = num4;
				continue;
			}
			case 5:
				return;
			case 4:
				if (Type == IndicatorViewType.Line)
				{
					P_0.Add(new IndicatorLabelInfo(close, k09ieQgYu7b));
					return;
				}
				flag = false;
				indicatorViewType = Type;
				num2 = 7;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_4f0cf0da7be4416c854b8885e7290889 == 0)
				{
					num2 = 4;
				}
				continue;
			case 8:
				num3 = ((close > 0) ? 1 : 0);
				goto IL_020d;
			case 6:
				if (num < 0 && num >= Items.Count)
				{
					return;
				}
				ggqECliK1JTZFNpZTou = Items[num];
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_22e7feb62ce84fd89a7a86f584263fcc == 0)
				{
					num2 = 1;
				}
				continue;
			case 7:
				switch (indicatorViewType)
				{
				case IndicatorViewType.Columns:
				case IndicatorViewType.Line:
					break;
				case IndicatorViewType.Candles:
					goto IL_010f;
				default:
					goto end_IL_0009;
				}
				goto default;
			case 2:
			case 3:
				break;
				IL_010f:
				flag = !double.IsNaN(close) && ggqECliK1JTZFNpZTou.Close > ggqECliK1JTZFNpZTou.JSbiK5wlAH6;
				num2 = 3;
				continue;
				IL_020d:
				flag = (byte)num3 != 0;
				num2 = 2;
				continue;
				end_IL_0009:
				break;
			}
			break;
		}
		P_0.Add(new IndicatorLabelInfo(close, flag ? UpColor : DownColor));
	}

	public override void ApplyColors(IChartTheme P_0)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				DownColor = P_0.PaletteColor7;
				LineColor = P_0.GetNextColor();
				base.ApplyColors(P_0);
				return;
			case 1:
				UpColor = fV5B0Re5RvfOytgHEtnn(P_0);
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1c1cbcfc982140d18e7033a6f2f9ec87 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override void CopyTemplate(IndicatorBase P_0, bool P_1)
	{
		s78kgqieHSKNCKKjIcl2 s78kgqieHSKNCKKjIcl3 = (s78kgqieHSKNCKKjIcl2)P_0;
		DataType = s78kgqieHSKNCKKjIcl3.DataType;
		int num = 3;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_6dab837cad8c4ebe913fccce41c2f99a != 0)
		{
			num = 3;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 2:
				UpColor = s78kgqieHSKNCKKjIcl3.UpColor;
				DownColor = s78kgqieHSKNCKKjIcl3.DownColor;
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_51ae13532ac34475801f72e10929a614 == 0)
				{
					num = 1;
				}
				break;
			case 0:
				return;
			case 3:
				Period = s78kgqieHSKNCKKjIcl3.Period;
				Type = dpBvMKe56g7xMqxUYxar(s78kgqieHSKNCKKjIcl3);
				num = 2;
				break;
			case 1:
				LineColor = s78kgqieHSKNCKKjIcl3.LineColor;
				LineWidth = Mjv026e5MRTVAb3p5UNK(s78kgqieHSKNCKKjIcl3);
				base.CopyTemplate(P_0, P_1);
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_5bc14e9093324ecc8c5d7e08f50abd26 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public override string ToString()
	{
		return (string)a65oGCe5OVaft1eAr7bZ(S171DQe5atxgKn7ndmMO(-1583344314 ^ -1583314446), base.Name, Period, DataType);
	}

	public override bool GetPropertyVisibility(string P_0)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!(P_0 == (string)S171DQe5atxgKn7ndmMO(-530053095 ^ -530018671)))
				{
					if (!U1DeeQe5qnJtXstB16TP(P_0, yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-342738082 ^ -342708438)) && !U1DeeQe5qnJtXstB16TP(P_0, yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1799510641 ^ -1799540471)))
					{
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_51365cbe57344dc59bfcbecc60361463 == 0)
						{
							num2 = 0;
						}
						break;
					}
					return Type != IndicatorViewType.Line;
				}
				goto IL_00b4;
			default:
				return true;
			case 2:
				{
					if (!(P_0 == (string)S171DQe5atxgKn7ndmMO(0x9F0F634 ^ 0x9F070AA)))
					{
						num2 = 1;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_7718f96c0b7741f0ab4250d28233bddf == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto IL_00b4;
				}
				IL_00b4:
				return Type == IndicatorViewType.Line;
			}
		}
	}

	static s78kgqieHSKNCKKjIcl2()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		C0F9XYe5IFIDp5o2kNW9();
	}

	internal static bool DxUEI4e5vULJCAgdugJH()
	{
		return pUGQ3Pe5oRT65CT3JZkF == null;
	}

	internal static s78kgqieHSKNCKKjIcl2 S27ty3e5BdYukCIVwLeB()
	{
		return pUGQ3Pe5oRT65CT3JZkF;
	}

	internal static object S171DQe5atxgKn7ndmMO(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static bool inAUdwe5irG5K199oP6d(XColor P_0, XColor P_1)
	{
		return P_0 == P_1;
	}

	internal static void nF9hVye5lRBDCNIHt9bi()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
	}

	internal static Color oFVFure54fvCCOPSccZa(byte P_0, byte P_1, byte P_2, byte P_3)
	{
		return Color.FromArgb(P_0, P_1, P_2, P_3);
	}

	internal static XColor DkldZNe5DSIcO5jknFnP(Color P_0)
	{
		return P_0;
	}

	internal static object d4Dn06e5b1JtpKInnL1h(object P_0)
	{
		return ((IChartSymbol)P_0).Exchange;
	}

	internal static double AcBlFye5NdCdeASTx2S6(object P_0)
	{
		return TimeHelper.GetSessionOffset((string)P_0);
	}

	internal static int AI4CeCe5kY3DKf3CSe5L(object P_0)
	{
		return ((List<GgqECliK1JTZFNpZTou1>)P_0).Count;
	}

	internal static int WM9nNTe51HRwZpsVQhHQ(object P_0, ChartPeriodType type, int interval, DateTime dateTime, double timeOffset)
	{
		return ((IChartPeriod)P_0).GetSequence(type, interval, dateTime, timeOffset);
	}

	internal static long Ev7sTFe55PvrQ8pOxY0o(object P_0)
	{
		return ((IRawCluster)P_0).OpenPos;
	}

	internal static long RbA9m3e5S5ZbbWTxUg1j(object P_0)
	{
		return ((IRawCluster)P_0).OpenPosHigh;
	}

	internal static long NxUb8Ie5x0js0QyuGmEG(object P_0)
	{
		return ((IRawCluster)P_0).OpenPosChg;
	}

	internal static long EYJduGe5Lv7mbMShuj0v(object P_0)
	{
		return ((IRawCluster)P_0).OpenPosAskChg;
	}

	internal static long zlTitue5e3fn9dWna2Fw(object P_0)
	{
		return ((IRawCluster)P_0).OpenPosBidChg;
	}

	internal static int HcIDx9e5sS8S53dVJLfC(object P_0)
	{
		return ((IChartDataProvider)P_0).Count;
	}

	internal static int Xv0wA7e5X72Psc44bTUV(object P_0, int i)
	{
		return ((IChartCanvas)P_0).GetIndex(i);
	}

	internal static int Tsatuve5c1V5LxTf2Lti(object P_0)
	{
		return ((IChartCanvas)P_0).Count;
	}

	internal static double Cjm4vre5jR4dnxnsYGcF(object P_0, int i)
	{
		return ((IChartCanvas)P_0).GetX(i);
	}

	internal static int lxmqVIe5EofDWLWycF9L(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static void w0gLdNe5QPciY95S6vSb(object P_0, object P_1, Point P_2, Point P_3)
	{
		((DxVisualQueue)P_0).DrawLine((XPen)P_1, P_2, P_3);
	}

	internal static double WKUu5Ke5dWdBafYflln7(double P_0, double P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static bool lnNsU8e5gAtDD9T74PVO(double P_0)
	{
		return double.IsNaN(P_0);
	}

	internal static XColor fV5B0Re5RvfOytgHEtnn(object P_0)
	{
		return ((IChartTheme)P_0).PaletteColor6;
	}

	internal static IndicatorViewType dpBvMKe56g7xMqxUYxar(object P_0)
	{
		return ((s78kgqieHSKNCKKjIcl2)P_0).Type;
	}

	internal static int Mjv026e5MRTVAb3p5UNK(object P_0)
	{
		return ((s78kgqieHSKNCKKjIcl2)P_0).LineWidth;
	}

	internal static object a65oGCe5OVaft1eAr7bZ(object P_0, object P_1, object P_2, object P_3)
	{
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	internal static bool U1DeeQe5qnJtXstB16TP(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static void C0F9XYe5IFIDp5o2kNW9()
	{
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}
}
