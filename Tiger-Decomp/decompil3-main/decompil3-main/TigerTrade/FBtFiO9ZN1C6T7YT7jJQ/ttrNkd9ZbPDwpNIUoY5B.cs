using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Windows;
using System.Windows.Media;
using C7UvAf9ri2R97XEwp7o2;
using ECOEgqlSad8NUJZ2Dr9n;
using MIA3eC2ZXsuRyAB0mjn;
using NsWD4W9miMxRbFU3fsu9;
using TiCeIH2IsQBNx4GCkaT;
using TigerTrade.Chart.Base;
using TigerTrade.Chart.Clusters.Enums;
using TigerTrade.Chart.Data;
using TigerTrade.Chart.Indicators.Common;
using TigerTrade.Chart.Indicators.Enums;
using TigerTrade.Dx;
using TigerTrade.Dx.Enums;
using TuAMtrl1Nd3XoZQQUXf0;
using U8g4nM9JuZySteT7noel;

namespace FBtFiO9ZN1C6T7YT7jJQ;

[DataContract(Name = "MaximumLevelsIndicator", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
[Indicator("MaximumLevels", "MaximumLevels", true, Type = typeof(ttrNkd9ZbPDwpNIUoY5B))]
internal sealed class ttrNkd9ZbPDwpNIUoY5B : fi0dX39rarBK9dp2dGQR
{
	private class tjJtdanukD66nXwkFOtH
	{
		[CompilerGenerated]
		private readonly double fpQnuSfu6oy;

		[CompilerGenerated]
		private readonly string DKWnuxxtCnO;

		private static tjJtdanukD66nXwkFOtH QRXpAlNtZg42aTDu2pav;

		public double Price
		{
			[CompilerGenerated]
			get
			{
				return fpQnuSfu6oy;
			}
		}

		public string Title
		{
			[CompilerGenerated]
			get
			{
				return DKWnuxxtCnO;
			}
		}

		public tjJtdanukD66nXwkFOtH(double P_0, string P_1)
		{
			dW96dHNtrJY1ixhKtxO8();
			base._002Ector();
			fpQnuSfu6oy = P_0;
			DKWnuxxtCnO = P_1;
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_35216e71f4e34e739f4a05a1213f3579 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		static tjJtdanukD66nXwkFOtH()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}

		internal static void dW96dHNtrJY1ixhKtxO8()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		}

		internal static bool IUd6fnNtVyDiUFSQ0coD()
		{
			return QRXpAlNtZg42aTDu2pav == null;
		}

		internal static tjJtdanukD66nXwkFOtH ViDX0dNtCtxtUNN4fAo6()
		{
			return QRXpAlNtZg42aTDu2pav;
		}
	}

	private ChartHistogramPeriodType zxe9ZAwg56i;

	private int kih9ZPTN53l;

	private bool XDM9ZJU2s2x;

	[CompilerGenerated]
	private XBrush TyI9ZFZJlUx;

	[CompilerGenerated]
	private XPen sBa9Z3rCigr;

	private XColor Inn9ZpD30BA;

	private int zMS9ZuyA57m;

	private XDashStyle UZC9ZzE1fhI;

	private bool bGg9V0NlCQ6;

	private bool BT39V2RGASQ;

	private bool qiA9VH8jibi;

	private bool B5x9VfpcRg7;

	private bool YQx9V9yrt0f;

	private bool NCO9Vn02lb8;

	private bool X919VG9jv8E;

	private bool jg79VYmP1Fc;

	private List<tjJtdanukD66nXwkFOtH> gcm9VodlOHY;

	private static ttrNkd9ZbPDwpNIUoY5B HDOEQMbWuGTXkrhyLGRO;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.Bar;

	[bBo0Zd2ycQQr3LNHQf4("ChartIndicatorsPeriod")]
	[T4IXj62qBfXCaxs2RI5("ChartIndicatorsParameters")]
	[DataMember(Name = "Period")]
	public ChartHistogramPeriodType Period
	{
		get
		{
			return zxe9ZAwg56i;
		}
		set
		{
			if (chartHistogramPeriodType != zxe9ZAwg56i)
			{
				zxe9ZAwg56i = chartHistogramPeriodType;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8b8f48487ce54157a86b0385feea16a6 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0xAD5B8B3 ^ 0xAD4B535));
			}
		}
	}

	[T4IXj62qBfXCaxs2RI5("ChartIndicatorsParameters")]
	[DataMember(Name = "LineLength")]
	[bBo0Zd2ycQQr3LNHQf4("ChartIndicatorsLineLength")]
	public int LineLength
	{
		get
		{
			return kih9ZPTN53l;
		}
		set
		{
			num = Math.Max(0, num);
			if (num != kih9ZPTN53l)
			{
				kih9ZPTN53l = num;
				int num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8a9257c2b61741afa02a8ceb1f69ad69 == 0)
				{
					num2 = 0;
				}
				switch (num2)
				{
				}
				OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--855742383 ^ 0x3305A13B));
			}
		}
	}

	[bBo0Zd2ycQQr3LNHQf4("ChartIndicatorsShowTitles")]
	[T4IXj62qBfXCaxs2RI5("ChartIndicatorsParameters")]
	[DataMember(Name = "ShowTitles")]
	public bool ShowTitles
	{
		get
		{
			return XDM9ZJU2s2x;
		}
		set
		{
			if (flag != XDM9ZJU2s2x)
			{
				XDM9ZJU2s2x = flag;
				WjOG9Ibt2AYsEqhdBLwV(this, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-991861155 ^ -991623163));
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c7e1deb64093431d91d263a2e49f884b == 0)
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
	public XBrush oAJ9ZjkMDSn
	{
		[CompilerGenerated]
		get
		{
			return TyI9ZFZJlUx;
		}
		[CompilerGenerated]
		private set
		{
			TyI9ZFZJlUx = tyI9ZFZJlUx;
		}
	}

	[Browsable(false)]
	public XPen IuR9ZdEyK90
	{
		[CompilerGenerated]
		get
		{
			return sBa9Z3rCigr;
		}
		[CompilerGenerated]
		private set
		{
			sBa9Z3rCigr = xPen;
		}
	}

	[T4IXj62qBfXCaxs2RI5("ChartIndicatorsStyle")]
	[bBo0Zd2ycQQr3LNHQf4("ChartCommonLineColor")]
	[DataMember(Name = "LineColor")]
	public XColor LineColor
	{
		get
		{
			return Inn9ZpD30BA;
		}
		set
		{
			if (!(xColor == Inn9ZpD30BA))
			{
				Inn9ZpD30BA = xColor;
				oAJ9ZjkMDSn = new XBrush(Inn9ZpD30BA);
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1a625a5fe3334df88082832236dff5be == 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 1:
					return;
				}
				IuR9ZdEyK90 = new XPen(oAJ9ZjkMDSn, LineWidth, LineStyle);
				OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1461949456 ^ -1462220386));
			}
		}
	}

	[bBo0Zd2ycQQr3LNHQf4("ChartCommonLineWidth")]
	[DataMember(Name = "LineWidth")]
	[T4IXj62qBfXCaxs2RI5("ChartIndicatorsStyle")]
	public int LineWidth
	{
		get
		{
			return zMS9ZuyA57m;
		}
		set
		{
			num = Math.Max(1, Math.Min(10, num));
			if (num == zMS9ZuyA57m)
			{
				return;
			}
			zMS9ZuyA57m = num;
			int num2 = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b3744d11c0b24c8d993b100cbb22f9e7 == 0)
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
				IuR9ZdEyK90 = new XPen(oAJ9ZjkMDSn, zMS9ZuyA57m, LineStyle);
				WjOG9Ibt2AYsEqhdBLwV(this, Wm1IeabtHVPjFIi7mat2(-45476899 ^ -45210213));
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ba87d68105604f98a891a0549ef4b7f9 != 0)
				{
					num2 = 0;
				}
			}
		}
	}

	[T4IXj62qBfXCaxs2RI5("ChartIndicatorsStyle")]
	[DataMember(Name = "LineStyle")]
	[bBo0Zd2ycQQr3LNHQf4("ChartCommonLineStyle")]
	public XDashStyle LineStyle
	{
		get
		{
			return UZC9ZzE1fhI;
		}
		set
		{
			if (xDashStyle != UZC9ZzE1fhI)
			{
				UZC9ZzE1fhI = xDashStyle;
				IuR9ZdEyK90 = new XPen(oAJ9ZjkMDSn, LineWidth, UZC9ZzE1fhI);
				OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1311293279 ^ -1311541747));
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e38cca27b4f843e0acda58c2d2606b17 == 0)
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

	[T4IXj62qBfXCaxs2RI5("ChartIndicatorsLevels")]
	[DataMember(Name = "MaxVolume")]
	[bBo0Zd2ycQQr3LNHQf4("ChartCommonMaxVolume")]
	public bool MaxVolume
	{
		get
		{
			return bGg9V0NlCQ6;
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
					if (flag != bGg9V0NlCQ6)
					{
						bGg9V0NlCQ6 = flag;
						OnPropertyChanged((string)Wm1IeabtHVPjFIi7mat2(-90307782 ^ -90289744));
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_aab13e7d663746898a6666b7303ea6c2 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[bBo0Zd2ycQQr3LNHQf4("ChartCommonMaxTrades")]
	[DataMember(Name = "MaxTrades")]
	[T4IXj62qBfXCaxs2RI5("ChartIndicatorsLevels")]
	public bool MaxTrades
	{
		get
		{
			return BT39V2RGASQ;
		}
		set
		{
			if (flag != BT39V2RGASQ)
			{
				BT39V2RGASQ = flag;
				OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x24085900 ^ 0x240813BA));
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03c20a54a7dc45f8a5130d4984fa4aea == 0)
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

	[bBo0Zd2ycQQr3LNHQf4("ChartCommonMaxBid")]
	[DataMember(Name = "MaxBid")]
	[T4IXj62qBfXCaxs2RI5("ChartIndicatorsLevels")]
	public bool MaxBid
	{
		get
		{
			return qiA9VH8jibi;
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
					if (flag != qiA9VH8jibi)
					{
						qiA9VH8jibi = flag;
						OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1009517961 ^ -1009536857));
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c1a63437a5bc4d139ae2c4a2f19ec947 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[T4IXj62qBfXCaxs2RI5("ChartIndicatorsLevels")]
	[bBo0Zd2ycQQr3LNHQf4("ChartCommonMaxAsk")]
	[DataMember(Name = "MaxAsk")]
	public bool MaxAsk
	{
		get
		{
			return B5x9VfpcRg7;
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
					if (flag == B5x9VfpcRg7)
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3cfcda862e0540cbb9abf65446a10635 != 0)
						{
							num2 = 0;
						}
						break;
					}
					B5x9VfpcRg7 = flag;
					OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x4220DA8 ^ 0x422475E));
					return;
				case 0:
					return;
				}
			}
		}
	}

	[DataMember(Name = "MaxDelta")]
	[T4IXj62qBfXCaxs2RI5("ChartIndicatorsLevels")]
	[bBo0Zd2ycQQr3LNHQf4("ChartCommonMaxDelta")]
	public bool MaxDelta
	{
		get
		{
			return YQx9V9yrt0f;
		}
		set
		{
			if (flag != YQx9V9yrt0f)
			{
				YQx9V9yrt0f = flag;
				WjOG9Ibt2AYsEqhdBLwV(this, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x4662F6AF ^ 0x4662BDB3));
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e38cca27b4f843e0acda58c2d2606b17 != 0)
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

	[bBo0Zd2ycQQr3LNHQf4("ChartCommonMinDelta")]
	[T4IXj62qBfXCaxs2RI5("ChartIndicatorsLevels")]
	[DataMember(Name = "MinDelta")]
	public bool MinDelta
	{
		get
		{
			return NCO9Vn02lb8;
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
					if (flag != NCO9Vn02lb8)
					{
						NCO9Vn02lb8 = flag;
						OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x60620FC1 ^ 0x606244F1));
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ad0a44f3eae14332b41c0c5ef48d2cbb == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[T4IXj62qBfXCaxs2RI5("ChartIndicatorsLevels")]
	[bBo0Zd2ycQQr3LNHQf4("ChartCommonHigh")]
	[DataMember(Name = "MaxPrice")]
	public bool MaxPrice
	{
		get
		{
			return X919VG9jv8E;
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
					if (flag == X919VG9jv8E)
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_53f0c1974ed349c3831704ecb4d3ce13 != 0)
						{
							num2 = 0;
						}
						break;
					}
					X919VG9jv8E = flag;
					OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-165474503 ^ -165191351));
					return;
				case 0:
					return;
				}
			}
		}
	}

	[T4IXj62qBfXCaxs2RI5("ChartIndicatorsLevels")]
	[bBo0Zd2ycQQr3LNHQf4("ChartCommonLow")]
	[DataMember(Name = "MinPrice")]
	public bool MinPrice
	{
		get
		{
			return jg79VYmP1Fc;
		}
		set
		{
			if (flag != jg79VYmP1Fc)
			{
				jg79VYmP1Fc = flag;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_4aa3a79213674c27a6bc763076b8caed == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--134855371 ^ 0x80DD44F));
			}
		}
	}

	[Browsable(false)]
	public override bool ShowIndicatorValues => false;

	[Browsable(false)]
	public override IndicatorCalculation Calculation => IndicatorCalculation.OnEachTick;

	public ttrNkd9ZbPDwpNIUoY5B()
	{
		JvYa0ybtfRMbn6Eq6wac();
		base._002Ector();
		qfUs93bt9Vrhv5WKaU49(this, false);
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dfd8fb340d494755970617a38d3a8729 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 5:
				return;
			case 6:
				LineColor = AxVcgnbtnGMW0l1ddN6N();
				LineWidth = 1;
				num = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2aa1113717a74eb69caa8952fdc78508 == 0)
				{
					num = 4;
				}
				break;
			case 4:
				LineStyle = XDashStyle.Solid;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_52f1b40ebe094208bc85ded04f1baa0b != 0)
				{
					num = 1;
				}
				break;
			default:
				Period = ChartHistogramPeriodType.CurrentDay;
				num = 2;
				break;
			case 3:
				MinDelta = false;
				MaxPrice = false;
				MinPrice = false;
				num = 5;
				break;
			case 2:
				LineLength = 0;
				ShowTitles = true;
				num = 6;
				break;
			case 1:
			{
				MaxVolume = true;
				MaxTrades = false;
				MaxBid = false;
				MaxAsk = false;
				MaxDelta = false;
				int num2 = 3;
				num = num2;
				break;
			}
			}
		}
	}

	protected override void Execute()
	{
		if (gcm9VodlOHY != null)
		{
			goto IL_00d0;
		}
		gcm9VodlOHY = new List<tjJtdanukD66nXwkFOtH>();
		goto IL_088b;
		IL_0009:
		int num;
		IEnumerator<IRawClusterItem> enumerator = default(IEnumerator<IRawClusterItem>);
		bool flag = default(bool);
		IRawClusterItem current = default(IRawClusterItem);
		IRawClusterMaxValues rawClusterMaxValues = default(IRawClusterMaxValues);
		string text = default(string);
		IRawCluster rawCluster = default(IRawCluster);
		while (true)
		{
			switch (num)
			{
			case 9:
				break;
			case 7:
				try
				{
					while (true)
					{
						IL_06f7:
						int num2;
						if (!enumerator.MoveNext())
						{
							num2 = 19;
							goto IL_012b;
						}
						goto IL_0646;
						IL_012b:
						while (true)
						{
							int num3;
							switch (num2)
							{
							case 19:
								return;
							case 7:
								flag = true;
								num2 = 2;
								continue;
							case 12:
								break;
							case 1:
							case 6:
								if (MinDelta && dZxlSIbtosUm7AWphcH1(current) == rawClusterMaxValues.MinDelta)
								{
									if (!flag)
									{
										flag = true;
										num2 = 11;
										continue;
									}
									text += stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1127423276 ^ -1127707248);
								}
								goto IL_0301;
							case 5:
							case 10:
								if (MinPrice)
								{
									num2 = 20;
									continue;
								}
								goto IL_0499;
							case 15:
								if (current.Bid == rawClusterMaxValues.MaxBid)
								{
									num3 = 4;
									goto IL_0127;
								}
								goto IL_0740;
							case 2:
								text = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--855742383 ^ 0x3305F945);
								goto IL_0740;
							case 26:
								if (!MaxDelta)
								{
									goto case 1;
								}
								goto case 9;
							case 28:
								text = "";
								if (MaxVolume)
								{
									num3 = 25;
									goto IL_0127;
								}
								goto IL_0654;
							case 21:
								if (!flag)
								{
									flag = true;
									num3 = 17;
									goto IL_0127;
								}
								text += (string)Wm1IeabtHVPjFIi7mat2(-838841832 ^ -838589272);
								goto case 3;
							case 13:
								text = (string)Wm1IeabtHVPjFIi7mat2(-1380525184 ^ -1380797160);
								goto IL_0654;
							default:
								text = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-57768881 ^ -58004527);
								goto IL_0499;
							case 9:
								if (dZxlSIbtosUm7AWphcH1(current) == rawClusterMaxValues.MaxDelta)
								{
									num2 = 0;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5dcb5c2a8274adf87bda91d76616538 != 0)
									{
										num2 = 18;
									}
									continue;
								}
								goto case 1;
							case 4:
								if (!flag)
								{
									num2 = 7;
									continue;
								}
								text += stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x4220DA8 ^ 0x4266374);
								goto IL_0740;
							case 3:
								if (MaxBid)
								{
									num2 = 15;
									continue;
								}
								goto IL_0740;
							case 25:
								if (current.Volume == rawClusterMaxValues.MaxVolume)
								{
									flag = true;
									num2 = 13;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ac6a9a8fc5c94cd6833091a6efebb474 != 0)
									{
										num2 = 10;
									}
									continue;
								}
								goto IL_0654;
							case 14:
								if (current.Trades == rawClusterMaxValues.MaxTrades)
								{
									num2 = 21;
									continue;
								}
								goto case 3;
							case 8:
							case 27:
								flag = true;
								text = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-842040449 ^ -842328837);
								num2 = 5;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fce1ea768b8d4ccdb3b71310761c1e52 != 0)
								{
									num2 = 0;
								}
								continue;
							case 22:
								if (!flag)
								{
									num2 = 8;
									continue;
								}
								goto case 16;
							case 11:
								text = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-338769610 ^ -339040664);
								goto IL_0301;
							case 18:
								goto IL_0566;
							case 20:
								if (e4x51xbtB1rB0WOJJjrg(current) == fsFlHSbtaskuqm16YLaV(rawCluster))
								{
									if (!flag)
									{
										break;
									}
									text = (string)uG4leUbti9UEdbKZQsOW(text, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1801468030 ^ -1801738222));
								}
								goto IL_0499;
							case 17:
								text = (string)Wm1IeabtHVPjFIi7mat2(-1380525184 ^ -1380797116);
								goto case 3;
							case 24:
								goto end_IL_012b;
							case 23:
								goto IL_06f7;
							case 16:
								{
									text += stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x404ED0BE ^ 0x404ABFCA);
									num2 = 10;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6938a97537c94834bed9381eb4051eec == 0)
									{
										num2 = 10;
									}
									continue;
								}
								IL_0301:
								if (MaxPrice && current.Price == n95CEobtvGumttRo3ycb(rawCluster))
								{
									num2 = 22;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1c0cedb54d2b44a7af3d63420e8a1767 == 0)
									{
										num2 = 6;
									}
									continue;
								}
								goto case 5;
								IL_0127:
								num2 = num3;
								continue;
								IL_0740:
								if (MaxAsk)
								{
									if (current.Ask == rawClusterMaxValues.MaxAsk)
									{
										if (!flag)
										{
											flag = true;
											text = (string)Wm1IeabtHVPjFIi7mat2(0x6E2DFBED ^ 0x6E2994E7);
										}
										else
										{
											text += (string)Wm1IeabtHVPjFIi7mat2(0x684F243E ^ 0x684B4AC2);
										}
									}
									goto case 26;
								}
								num2 = 26;
								continue;
								IL_0499:
								if (flag)
								{
									gcm9VodlOHY.Add(new tjJtdanukD66nXwkFOtH((double)current.Price * base.DataProvider.Step, text + (string)SdEf1pbtli2Av6XAwhuy(Period)));
									num2 = 23;
									continue;
								}
								goto IL_06f7;
								IL_0654:
								if (!MaxTrades)
								{
									num2 = 3;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_390fe499a2cc4a5ca3d6279a99e6b610 == 0)
									{
										num2 = 0;
									}
									continue;
								}
								goto case 14;
							}
							flag = true;
							num2 = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_426282f87bb443dbbfe9ea3327b81bb7 != 0)
							{
								num2 = 0;
							}
							continue;
							IL_0566:
							if (!flag)
							{
								flag = true;
								text = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-673683647 ^ -673445777);
								num2 = 1;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3a7b10748dce4fec98054526a92d6ccf == 0)
								{
									num2 = 1;
								}
							}
							else
							{
								text += stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x404ED0BE ^ 0x404ABFA2);
								num2 = 6;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8b6bac13ae314900826ed96af7afc27b == 0)
								{
									num2 = 4;
								}
							}
							continue;
							end_IL_012b:
							break;
						}
						goto IL_0646;
						IL_0646:
						current = enumerator.Current;
						flag = false;
						num2 = 28;
						goto IL_012b;
					}
				}
				finally
				{
					enumerator?.Dispose();
				}
			case 3:
				goto IL_07a1;
			case 2:
				goto IL_0809;
			case 4:
				goto IL_0850;
			case 5:
				switch (Period)
				{
				case ChartHistogramPeriodType.CurrentWeek:
					rawCluster = base.DataProvider.zWfln9vXkDc((sOa57v9Jprw32ZFaJ5BM)2);
					goto IL_087f;
				case ChartHistogramPeriodType.LastDay:
					rawCluster = base.DataProvider.zWfln9vXkDc((sOa57v9Jprw32ZFaJ5BM)1);
					goto IL_087f;
				case ChartHistogramPeriodType.CurrentDay:
					rawCluster = base.DataProvider.zWfln9vXkDc((sOa57v9Jprw32ZFaJ5BM)0);
					goto IL_087f;
				case ChartHistogramPeriodType.Contract:
					break;
				case ChartHistogramPeriodType.CurrentMonth:
					goto IL_07b9;
				case ChartHistogramPeriodType.LastMonth:
					goto IL_0809;
				case ChartHistogramPeriodType.LastWeek:
					goto IL_0850;
				default:
					goto IL_087f;
				}
				goto IL_07a1;
			default:
				goto IL_087f;
			case 10:
				goto IL_088b;
				IL_07b9:
				rawCluster = (IRawCluster)CCr5UsbtGO0Sf8OjR0HE(base.DataProvider, (sOa57v9Jprw32ZFaJ5BM)4);
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0fb8c8dbf8424ce68f439b7b66291a33 != 0)
				{
					num = 1;
				}
				continue;
				IL_087f:
				if (rawCluster == null)
				{
					return;
				}
				rawClusterMaxValues = (IRawClusterMaxValues)FBcH3bbtYNokuWc4xTVn(rawCluster);
				enumerator = rawCluster.Items.GetEnumerator();
				num = 7;
				continue;
			}
			break;
			IL_0850:
			rawCluster = base.DataProvider.zWfln9vXkDc((sOa57v9Jprw32ZFaJ5BM)3);
			num = 6;
			continue;
			IL_0809:
			rawCluster = base.DataProvider.zWfln9vXkDc((sOa57v9Jprw32ZFaJ5BM)5);
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_281cd373231b4974955fe570959430ac == 0)
			{
				num = 0;
			}
			continue;
			IL_07a1:
			rawCluster = base.DataProvider.zWfln9vXkDc((sOa57v9Jprw32ZFaJ5BM)6);
			num = 8;
		}
		goto IL_00d0;
		IL_088b:
		rawCluster = null;
		num = 3;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ff2c70a81f2141b98b88fc10875a3726 == 0)
		{
			num = 5;
		}
		goto IL_0009;
		IL_00d0:
		gcm9VodlOHY.Clear();
		num = 10;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0b22b597497745f5ab911eaabff065eb == 0)
		{
			num = 10;
		}
		goto IL_0009;
	}

	public override void Render(DxVisualQueue P_0)
	{
		base.Render(P_0);
		Rect rect = base.Canvas.Rect;
		double right = rect.Right;
		int num = 2;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_859c6249cb0f4f11b2da29d1228ce418 != 0)
		{
			num = 2;
		}
		List<tjJtdanukD66nXwkFOtH>.Enumerator enumerator = default(List<tjJtdanukD66nXwkFOtH>.Enumerator);
		double num4 = default(double);
		double num2 = default(double);
		Size size = default(Size);
		double num5 = default(double);
		while (true)
		{
			switch (num)
			{
			case 1:
				try
				{
					while (enumerator.MoveNext())
					{
						tjJtdanukD66nXwkFOtH current = enumerator.Current;
						int num3 = 2;
						while (true)
						{
							switch (num3)
							{
							case 2:
								num4 = sARdJHbt4HXOusSTdtxh(this, current.Price);
								Acxd1KbtDlgrveOPRKU2(P_0, IuR9ZdEyK90, new Point(right - num2, num4), new Point(right, num4));
								if (ShowTitles)
								{
									size = xMHmNUbtNwUxj94RS3O6(base.Settings.ChartFont, DluEMfbtb5atYBnUMo8Z(current));
									num3 = 0;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fc665aa6b49746ab985cf6653d959552 != 0)
									{
										num3 = 0;
									}
									continue;
								}
								break;
							case 1:
								break;
							default:
								num5 = (double)LineWidth / 2.0 + size.Height + 2.0;
								num3 = 3;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0b22b597497745f5ab911eaabff065eb == 0)
								{
									num3 = 3;
								}
								continue;
							case 3:
								P_0.DrawString((string)DluEMfbtb5atYBnUMo8Z(current), base.Settings.ChartFont, oAJ9ZjkMDSn, new Rect(new Point(right - size.Width - 5.0, num4 - num5 - 3.0), new Point(right - 5.0, num4 - 3.0)), XTextAlignment.Right);
								num3 = 1;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ad0a44f3eae14332b41c0c5ef48d2cbb == 0)
								{
									num3 = 1;
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
				enumerator = gcm9VodlOHY.GetEnumerator();
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3cfcda862e0540cbb9abf65446a10635 != 0)
				{
					num = 1;
				}
				break;
			case 2:
				num2 = ((LineLength == 0) ? (rect.Width / 3.0) : ((double)LineLength));
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f10da6c70e49485dae21f57ce3741184 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public override void GetLabels(ref List<IndicatorLabelInfo> P_0)
	{
		P_0.AddRange(gcm9VodlOHY.Select((tjJtdanukD66nXwkFOtH tjJtdanukD66nXwkFOtH) => new IndicatorLabelInfo(tjJtdanukD66nXwkFOtH.Price, LineColor)).ToList());
	}

	public override void ApplyColors(IChartTheme P_0)
	{
		LineColor = P_0.GetNextColor();
		base.ApplyColors(P_0);
	}

	public override void CopyTemplate(IndicatorBase P_0, bool P_1)
	{
		ttrNkd9ZbPDwpNIUoY5B ttrNkd9ZbPDwpNIUoY5B2 = (ttrNkd9ZbPDwpNIUoY5B)P_0;
		Period = VlUR3UbtkPSYN60nnHRu(ttrNkd9ZbPDwpNIUoY5B2);
		LineLength = ttrNkd9ZbPDwpNIUoY5B2.LineLength;
		ShowTitles = ttrNkd9ZbPDwpNIUoY5B2.ShowTitles;
		LineColor = ttrNkd9ZbPDwpNIUoY5B2.LineColor;
		LineWidth = I0CooBbt1SUMQqImsK3K(ttrNkd9ZbPDwpNIUoY5B2);
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d4c083a65c1546b8a09c928a8c95e140 != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 5:
				MinPrice = ttrNkd9ZbPDwpNIUoY5B2.MinPrice;
				num = 6;
				break;
			case 6:
				base.CopyTemplate(P_0, P_1);
				num = 4;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ff2c70a81f2141b98b88fc10875a3726 != 0)
				{
					num = 2;
				}
				break;
			case 3:
				MaxAsk = ttrNkd9ZbPDwpNIUoY5B2.MaxAsk;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_08ac0ac701064383a00c80bff8cd4e3f == 0)
				{
					num = 0;
				}
				break;
			case 2:
				MinDelta = SFrfKIbt5M3idd9LqORs(ttrNkd9ZbPDwpNIUoY5B2);
				MaxPrice = ttrNkd9ZbPDwpNIUoY5B2.MaxPrice;
				num = 4;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2039997ab6194b398d07bcb5d664c971 == 0)
				{
					num = 5;
				}
				break;
			default:
				MaxDelta = ttrNkd9ZbPDwpNIUoY5B2.MaxDelta;
				num = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0aea3f4dc28f4bcb92a1f998dc5afbed != 0)
				{
					num = 0;
				}
				break;
			case 4:
				return;
			case 1:
				LineStyle = ttrNkd9ZbPDwpNIUoY5B2.LineStyle;
				MaxVolume = ttrNkd9ZbPDwpNIUoY5B2.MaxVolume;
				MaxTrades = ttrNkd9ZbPDwpNIUoY5B2.MaxTrades;
				MaxBid = ttrNkd9ZbPDwpNIUoY5B2.MaxBid;
				num = 3;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6b9913e777f24c1abc91fbc34d2bcc9c == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public override object Clone()
	{
		ttrNkd9ZbPDwpNIUoY5B obj = new ttrNkd9ZbPDwpNIUoY5B
		{
			Period = Period
		};
		TjEE1YbtSUwnWA2G9fJP(obj, LineLength);
		asm0IHbtxahXK0rca7Vg(obj, ShowTitles);
		ieyl30btLQ2ct082tqJu(obj, LineColor);
		obj.LineWidth = LineWidth;
		DV8xT6bteA7GuSFfitrF(obj, LineStyle);
		obj.MaxVolume = MaxVolume;
		obj.MaxTrades = MaxTrades;
		obj.MaxBid = MaxBid;
		obj.MaxAsk = MaxAsk;
		obj.MaxDelta = MaxDelta;
		obj.MinDelta = MinDelta;
		obj.MaxPrice = MaxPrice;
		obj.MinPrice = MinPrice;
		return obj;
	}

	private static string Cid9ZkheK8d(ChartHistogramPeriodType P_0)
	{
		return P_0 switch
		{
			ChartHistogramPeriodType.CurrentDay => stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1878953018 ^ -1878713234), 
			ChartHistogramPeriodType.LastDay => stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x2D313048 ^ 0x2D355FFE), 
			ChartHistogramPeriodType.CurrentWeek => stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-673683647 ^ -673445755), 
			ChartHistogramPeriodType.LastWeek => (string)Wm1IeabtHVPjFIi7mat2(--134855371 ^ 0x80DD519), 
			ChartHistogramPeriodType.CurrentMonth => stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-448941864 ^ -449192136), 
			ChartHistogramPeriodType.LastMonth => stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1047165041 ^ -1047402399), 
			ChartHistogramPeriodType.Contract => (string)Wm1IeabtHVPjFIi7mat2(0x1487846E ^ 0x1483EB92), 
			_ => "", 
		};
	}

	[CompilerGenerated]
	private IndicatorLabelInfo r6l9Z1og8QN(tjJtdanukD66nXwkFOtH P_0)
	{
		return new IndicatorLabelInfo(P_0.Price, LineColor);
	}

	static ttrNkd9ZbPDwpNIUoY5B()
	{
		kVZRcdbtso9DHrH46BHi();
	}

	internal static bool Cj2KE4bWzOBiCQD5Vc6D()
	{
		return HDOEQMbWuGTXkrhyLGRO == null;
	}

	internal static ttrNkd9ZbPDwpNIUoY5B loww2Ybt00LhqZUEv4HY()
	{
		return HDOEQMbWuGTXkrhyLGRO;
	}

	internal static void WjOG9Ibt2AYsEqhdBLwV(object P_0, object P_1)
	{
		((IndicatorBase)P_0).OnPropertyChanged((string)P_1);
	}

	internal static object Wm1IeabtHVPjFIi7mat2(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static void JvYa0ybtfRMbn6Eq6wac()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static void qfUs93bt9Vrhv5WKaU49(object P_0, bool P_1)
	{
		((IndicatorBase)P_0).ShowIndicatorTitle = P_1;
	}

	internal static Color AxVcgnbtnGMW0l1ddN6N()
	{
		return Colors.Black;
	}

	internal static object CCr5UsbtGO0Sf8OjR0HE(object P_0, sOa57v9Jprw32ZFaJ5BM P_1)
	{
		return ((ypqMIv9maFM0tRwF0xMh)P_0).zWfln9vXkDc(P_1);
	}

	internal static object FBcH3bbtYNokuWc4xTVn(object P_0)
	{
		return ((IRawCluster)P_0).MaxValues;
	}

	internal static long dZxlSIbtosUm7AWphcH1(object P_0)
	{
		return ((IRawClusterItem)P_0).Delta;
	}

	internal static long n95CEobtvGumttRo3ycb(object P_0)
	{
		return ((IRawCluster)P_0).High;
	}

	internal static long e4x51xbtB1rB0WOJJjrg(object P_0)
	{
		return ((IRawClusterItem)P_0).Price;
	}

	internal static long fsFlHSbtaskuqm16YLaV(object P_0)
	{
		return ((IRawCluster)P_0).Low;
	}

	internal static object uG4leUbti9UEdbKZQsOW(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object SdEf1pbtli2Av6XAwhuy(ChartHistogramPeriodType P_0)
	{
		return Cid9ZkheK8d(P_0);
	}

	internal static double sARdJHbt4HXOusSTdtxh(object P_0, double P_1)
	{
		return ((IndicatorBase)P_0).GetY(P_1);
	}

	internal static void Acxd1KbtDlgrveOPRKU2(object P_0, object P_1, Point P_2, Point P_3)
	{
		((DxVisualQueue)P_0).DrawLine((XPen)P_1, P_2, P_3);
	}

	internal static object DluEMfbtb5atYBnUMo8Z(object P_0)
	{
		return ((tjJtdanukD66nXwkFOtH)P_0).Title;
	}

	internal static Size xMHmNUbtNwUxj94RS3O6(object P_0, object P_1)
	{
		return ((XFont)P_0).GetSize((string)P_1);
	}

	internal static ChartHistogramPeriodType VlUR3UbtkPSYN60nnHRu(object P_0)
	{
		return ((ttrNkd9ZbPDwpNIUoY5B)P_0).Period;
	}

	internal static int I0CooBbt1SUMQqImsK3K(object P_0)
	{
		return ((ttrNkd9ZbPDwpNIUoY5B)P_0).LineWidth;
	}

	internal static bool SFrfKIbt5M3idd9LqORs(object P_0)
	{
		return ((ttrNkd9ZbPDwpNIUoY5B)P_0).MinDelta;
	}

	internal static void TjEE1YbtSUwnWA2G9fJP(object P_0, int P_1)
	{
		((ttrNkd9ZbPDwpNIUoY5B)P_0).LineLength = P_1;
	}

	internal static void asm0IHbtxahXK0rca7Vg(object P_0, bool P_1)
	{
		((ttrNkd9ZbPDwpNIUoY5B)P_0).ShowTitles = P_1;
	}

	internal static void ieyl30btLQ2ct082tqJu(object P_0, XColor P_1)
	{
		((ttrNkd9ZbPDwpNIUoY5B)P_0).LineColor = P_1;
	}

	internal static void DV8xT6bteA7GuSFfitrF(object P_0, XDashStyle P_1)
	{
		((ttrNkd9ZbPDwpNIUoY5B)P_0).LineStyle = P_1;
	}

	internal static void kVZRcdbtso9DHrH46BHi()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}
}
