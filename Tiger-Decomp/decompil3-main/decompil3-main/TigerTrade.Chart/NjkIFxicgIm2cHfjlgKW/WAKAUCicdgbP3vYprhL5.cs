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
using TigerTrade.Chart.Alerts;
using TigerTrade.Chart.Base;
using TigerTrade.Chart.Data;
using TigerTrade.Chart.Indicators.Common;
using TigerTrade.Chart.Indicators.Enums;
using TigerTrade.Chart.Properties;
using TigerTrade.Dx;

namespace NjkIFxicgIm2cHfjlgKW;

[DataContract(Name = "TradesIndicator", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
[Indicator("Trades", "Trades", false, Type = typeof(WAKAUCicdgbP3vYprhL5))]
internal sealed class WAKAUCicdgbP3vYprhL5 : IndicatorBase
{
	private XBrush jUAijXfJPYb;

	private XPen Q8yijcvfnZB;

	private XColor sWkijjxAfME;

	private XBrush wC7ijEavOND;

	private XPen qSTijQIPaPi;

	private XColor SgBijd0S5Wx;

	private bool ihrijgE0tUI;

	private IndicatorNullIntParam xY4ijRGwYGg;

	private IndicatorNullIntParam tt9ij60jS6g;

	private IndicatorNullIntParam jLcijM4HNsJ;

	private XBrush YuXijOvSTq5;

	private XPen DHdijq7x6qJ;

	private XColor uRJijIZK8qU;

	private ChartAlertSettings eDgijWfBhfj;

	private IndicatorNullIntParam s1kijtnVNHB;

	private IndicatorNullIntParam e9TijUxMd7L;

	private XBrush ai9ijTp2rHp;

	private XPen VrIijySveFZ;

	private XColor KRfijZTC7Cw;

	private ChartAlertSettings hotijVn3Oas;

	private IndicatorNullIntParam DlBijCn0ERH;

	private IndicatorNullIntParam advijrtBmv0;

	private XBrush DDqijK0Dr4F;

	private XPen qgmijmYh0bs;

	private XColor wPZijh9RYhl;

	private ChartAlertSettings WBhijwlRo3X;

	private int jRBij7svcuh;

	private int sq3ij8jfiPL;

	private int GaVijAenFtB;

	private double S3FijPmnLXb;

	internal static WAKAUCicdgbP3vYprhL5 j5e7e4exsTPMe7VykxNM;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.Bar;

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsStyle")]
	[DataMember(Name = "UpColor")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsUpColor")]
	public XColor UpColor
	{
		get
		{
			return sWkijjxAfME;
		}
		set
		{
			if (xColor == sWkijjxAfME)
			{
				return;
			}
			sWkijjxAfME = xColor;
			int num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_03398ebbe6224bea83047c33d24affe2 == 0)
			{
				num = 1;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					jUAijXfJPYb = new XBrush(sWkijjxAfME);
					Q8yijcvfnZB = new XPen(jUAijXfJPYb, 1);
					num = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_5d6485f66cb24fc09096e66798254c7f == 0)
					{
						num = 0;
					}
					break;
				default:
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x4220DA8 ^ 0x42299DC));
					return;
				}
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsStyle")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsDownColor")]
	[DataMember(Name = "DownColor")]
	public XColor DownColor
	{
		get
		{
			return SgBijd0S5Wx;
		}
		set
		{
			if (xColor == SgBijd0S5Wx)
			{
				return;
			}
			SgBijd0S5Wx = xColor;
			int num = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_77d26139d1074373ba3d17cb18b3ec16 != 0)
			{
				num = 1;
			}
			while (true)
			{
				switch (num)
				{
				default:
					OnPropertyChanged((string)FUfrOfexjo7r4DuweayL(0x5EA8FF2A ^ 0x5EA86BAC));
					return;
				case 1:
					wC7ijEavOND = new XBrush(SgBijd0S5Wx);
					qSTijQIPaPi = new XPen(wC7ijEavOND, 1);
					num = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_d4f52eaa7d9d4aa09bb6fdf0b3adf8b6 != 0)
					{
						num = 0;
					}
					break;
				}
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsDeltaColored")]
	[DataMember(Name = "DeltaColored")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	public bool DeltaColored
	{
		get
		{
			return ihrijgE0tUI;
		}
		set
		{
			if (flag != ihrijgE0tUI)
			{
				ihrijgE0tUI = flag;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-530053095 ^ -530016293));
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

	[DataMember(Name = "MaxTradesParam")]
	public IndicatorNullIntParam zN5icyraJu6
	{
		get
		{
			return xY4ijRGwYGg ?? (xY4ijRGwYGg = new IndicatorNullIntParam(null));
		}
		set
		{
			xY4ijRGwYGg = indicatorNullIntParam;
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsMaxTrades")]
	[DefaultValue(null)]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	public int? MaxTrades
	{
		get
		{
			return zN5icyraJu6.Get(base.SettingsLongKey);
		}
		set
		{
			if (zN5icyraJu6.Set(base.SettingsLongKey, value2, 0))
			{
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x24085900 ^ 0x2408C6DE));
			}
		}
	}

	[DataMember(Name = "Filter1MinParam")]
	public IndicatorNullIntParam oElicK88quh
	{
		get
		{
			return tt9ij60jS6g ?? (tt9ij60jS6g = new IndicatorNullIntParam(null));
		}
		set
		{
			tt9ij60jS6g = indicatorNullIntParam;
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsFilter1")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsMinimum")]
	[DefaultValue(null)]
	public int? Filter1Min
	{
		get
		{
			return oElicK88quh.Get(base.SettingsLongKey);
		}
		set
		{
			if (oElicK88quh.Set(base.SettingsLongKey, value2, 0))
			{
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1736566656 ^ -1736536676));
			}
		}
	}

	[DataMember(Name = "Filter1MaxParam")]
	public IndicatorNullIntParam PKgic8PsBMl
	{
		get
		{
			return jLcijM4HNsJ ?? (jLcijM4HNsJ = new IndicatorNullIntParam(null));
		}
		set
		{
			jLcijM4HNsJ = indicatorNullIntParam;
		}
	}

	[DefaultValue(null)]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsFilter1")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsMaximum")]
	public int? Filter1Max
	{
		get
		{
			return PKgic8PsBMl.Get(base.SettingsLongKey);
		}
		set
		{
			if (PKgic8PsBMl.Set(base.SettingsLongKey, value2, 0))
			{
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x5CD4F15 ^ 0x5CDDA21));
			}
		}
	}

	[DataMember(Name = "Filter1Color")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsFilter1")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsColor")]
	public XColor Filter1Color
	{
		get
		{
			return uRJijIZK8qU;
		}
		set
		{
			if (!(xColor == uRJijIZK8qU))
			{
				uRJijIZK8qU = xColor;
				YuXijOvSTq5 = new XBrush(uRJijIZK8qU);
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0ab04f3efbe746ef961577ea88d00fe3 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 1:
					return;
				}
				DHdijq7x6qJ = new XPen(YuXijOvSTq5, 1);
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x5EA8FF2A ^ 0x5EA860DE));
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsFilter1")]
	[DataMember(Name = "Filter1Alert")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsAlert")]
	public ChartAlertSettings Filter1Alert
	{
		get
		{
			return eDgijWfBhfj ?? (eDgijWfBhfj = new ChartAlertSettings());
		}
		set
		{
			if (!object.Equals(objA, eDgijWfBhfj))
			{
				eDgijWfBhfj = objA;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_5c9da2ed0d9f4b4dbc84580bf3b83e9f == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-165474503 ^ -165438801));
			}
		}
	}

	[DataMember(Name = "Filter2MinParam")]
	public IndicatorNullIntParam qXiij06mtFI
	{
		get
		{
			return s1kijtnVNHB ?? (s1kijtnVNHB = new IndicatorNullIntParam(null));
		}
		set
		{
			s1kijtnVNHB = indicatorNullIntParam;
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsMinimum")]
	[DefaultValue(null)]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsFilter2")]
	public int? Filter2Min
	{
		get
		{
			return qXiij06mtFI.Get(base.SettingsLongKey);
		}
		set
		{
			if (qXiij06mtFI.Set(base.SettingsLongKey, value2, 0))
			{
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x2C8374E4 ^ 0x2C83E156));
			}
		}
	}

	[DataMember(Name = "Filter2MaxParam")]
	public IndicatorNullIntParam YmwijnCZlrM
	{
		get
		{
			return e9TijUxMd7L ?? (e9TijUxMd7L = new IndicatorNullIntParam(null));
		}
		set
		{
			e9TijUxMd7L = indicatorNullIntParam;
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsMaximum")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsFilter2")]
	[DefaultValue(null)]
	public int? Filter2Max
	{
		get
		{
			return YmwijnCZlrM.Get(base.SettingsLongKey);
		}
		set
		{
			if (YmwijnCZlrM.Set(base.SettingsLongKey, value2, 0))
			{
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1127423276 ^ -1127450850));
			}
		}
	}

	[DataMember(Name = "Filter2Color")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsColor")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsFilter2")]
	public XColor Filter2Color
	{
		get
		{
			return KRfijZTC7Cw;
		}
		set
		{
			if (xColor == KRfijZTC7Cw)
			{
				return;
			}
			KRfijZTC7Cw = xColor;
			int num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_86d84d52ab13483783040bb945a786b2 == 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-45476899 ^ -45435955));
					return;
				}
				ai9ijTp2rHp = new XBrush(KRfijZTC7Cw);
				VrIijySveFZ = new XPen(ai9ijTp2rHp, 1);
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_4c510febac3445efbec11458d423f537 == 0)
				{
					num = 1;
				}
			}
		}
	}

	[DataMember(Name = "Filter2Alert")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsFilter2")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsAlert")]
	public ChartAlertSettings Filter2Alert
	{
		get
		{
			return hotijVn3Oas ?? (hotijVn3Oas = new ChartAlertSettings());
		}
		set
		{
			if (!object.Equals(objA, hotijVn3Oas))
			{
				hotijVn3Oas = objA;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1799510641 ^ -1799539805));
			}
		}
	}

	[DataMember(Name = "Filter3MinParam")]
	public IndicatorNullIntParam By5ij4SAgct
	{
		get
		{
			return DlBijCn0ERH ?? (DlBijCn0ERH = new IndicatorNullIntParam(null));
		}
		set
		{
			DlBijCn0ERH = dlBijCn0ERH;
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsMinimum")]
	[DefaultValue(null)]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsFilter3")]
	public int? Filter3Min
	{
		get
		{
			return By5ij4SAgct.Get(base.SettingsLongKey);
		}
		set
		{
			if (By5ij4SAgct.Set(base.SettingsLongKey, value2, 0))
			{
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x22BF43FC ^ 0x22BFD5B4));
			}
		}
	}

	[DataMember(Name = "Filter3MaxParam")]
	public IndicatorNullIntParam cPRij1fqHcC
	{
		get
		{
			return advijrtBmv0 ?? (advijrtBmv0 = new IndicatorNullIntParam(null));
		}
		set
		{
			advijrtBmv0 = indicatorNullIntParam;
		}
	}

	[DefaultValue(null)]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsFilter3")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsMaximum")]
	public int? Filter3Max
	{
		get
		{
			return cPRij1fqHcC.Get(base.SettingsLongKey);
		}
		set
		{
			if (cPRij1fqHcC.Set(base.SettingsLongKey, value2, 0))
			{
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x1AB79299 ^ 0x1AB704F9));
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsColor")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsFilter3")]
	[DataMember(Name = "Filter3Color")]
	public XColor Filter3Color
	{
		get
		{
			return wPZijh9RYhl;
		}
		set
		{
			if (wto7wmexEKqRJDO9PZsy(xColor, wPZijh9RYhl))
			{
				return;
			}
			wPZijh9RYhl = xColor;
			DDqijK0Dr4F = new XBrush(wPZijh9RYhl);
			int num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f827d36f09784758a58ee73d00be2977 == 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					OnPropertyChanged((string)FUfrOfexjo7r4DuweayL(-198991962 ^ -199016566));
					return;
				}
				qgmijmYh0bs = new XPen(DDqijK0Dr4F, 1);
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_ffb93a04ce4c4a8e857e2e7fd646df59 != 0)
				{
					num = 1;
				}
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsFilter3")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsAlert")]
	[DataMember(Name = "Filter3Alert")]
	public ChartAlertSettings Filter3Alert
	{
		get
		{
			return WBhijwlRo3X ?? (WBhijwlRo3X = new ChartAlertSettings());
		}
		set
		{
			if (!object.Equals(chartAlertSettings, WBhijwlRo3X))
			{
				WBhijwlRo3X = chartAlertSettings;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-671204305 ^ -671175955));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_971675a329344000b7f54dccd3fcffa2 == 0)
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
	public override IndicatorCalculation Calculation => IndicatorCalculation.OnEachTick;

	public override bool IntegerValues => true;

	public WAKAUCicdgbP3vYprhL5()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_ffb93a04ce4c4a8e857e2e7fd646df59 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				UpColor = Color.FromArgb(byte.MaxValue, 30, 144, byte.MaxValue);
				DownColor = AuReDsexQpH0OsmhW3gb(Color.FromArgb(byte.MaxValue, 178, 34, 34));
				DeltaColored = false;
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0cda726836d64094b2c4c18a328cd3aa == 0)
				{
					num = 2;
				}
				break;
			case 1:
				sq3ij8jfiPL = -1;
				num = 3;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_239bac6736df482c97654364ff867959 != 0)
				{
					num = 3;
				}
				break;
			case 3:
				GaVijAenFtB = -1;
				return;
			case 2:
				Filter1Color = Colors.Orange;
				Filter2Color = Colors.Orange;
				Filter3Color = Tf3f3xexdIj9tsrNhbxr();
				jRBij7svcuh = -1;
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8bad63f401844feb8b319ab89401e7b9 == 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	protected override void Execute()
	{
		if (!base.ClearData)
		{
			goto IL_007f;
		}
		jRBij7svcuh = -1;
		int num = 17;
		goto IL_0009;
		IL_0009:
		int trades = default(int);
		int num7 = default(int);
		int num9 = default(int);
		int num10 = default(int);
		int? num4 = default(int?);
		int num11 = default(int);
		IChartCluster cluster = default(IChartCluster);
		int num2 = default(int);
		int num12 = default(int);
		int num6 = default(int);
		while (true)
		{
			int num5;
			int num8;
			int num3;
			switch (num)
			{
			case 6:
				break;
			case 21:
				if (trades >= num7)
				{
					if (num9 >= 0)
					{
						num = 14;
						continue;
					}
					goto IL_0176;
				}
				goto case 1;
			case 2:
				num5 = -1;
				goto IL_0551;
			case 10:
				AddAlert(Filter1Alert, string.Format(Resources.ChartIndicatorsTradesFilterAlert, 1, ((IChartSymbol)pa62kSexRg6V5Ng0PA3a(base.DataProvider)).FormatTrades((long)trades)));
				goto case 1;
			case 16:
				if (num10 >= 0)
				{
					num = 22;
					continue;
				}
				return;
			default:
				if (!num4.HasValue)
				{
					goto case 9;
				}
				num8 = num4.GetValueOrDefault();
				goto IL_0522;
			case 3:
				num4 = Filter3Min;
				if (!num4.HasValue)
				{
					num = 23;
					continue;
				}
				num3 = num4.GetValueOrDefault();
				goto IL_0564;
			case 26:
				if (trades <= num11)
				{
					goto IL_0158;
				}
				return;
			case 15:
				num4 = Filter2Min;
				num = 11;
				continue;
			case 25:
				if (cluster == null)
				{
					return;
				}
				trades = cluster.Trades;
				if (!Filter1Alert.IsActive)
				{
					num = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_739f779654714fe286f27606d950a9d9 == 0)
					{
						num = 1;
					}
					continue;
				}
				goto case 18;
			case 20:
				AddAlert(Filter2Alert, string.Format((string)Cxk8XWex6QWIxmIOeigb(), 2, base.DataProvider.Symbol.FormatTrades(trades)));
				goto IL_0096;
			case 23:
				num3 = -1;
				goto IL_0564;
			case 1:
			case 4:
			case 12:
				if (Filter2Alert.IsActive && sq3ij8jfiPL < num2)
				{
					num = 15;
					continue;
				}
				goto IL_0096;
			case 11:
				num12 = num4 ?? (-1);
				num = 8;
				continue;
			case 13:
				if (num12 >= 0)
				{
					num = 19;
					continue;
				}
				goto IL_0096;
			case 19:
				if (trades >= num12 && (num6 < 0 || trades <= num6))
				{
					sq3ij8jfiPL = num2;
					num = 6;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bf9361639de74e0d899574b5f9abd2dd == 0)
					{
						num = 20;
					}
					continue;
				}
				goto IL_0096;
			case 7:
				num11 = num4 ?? (-1);
				num = 9;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_64274e2af1ab4c6db7e1ad660e8beb8f != 0)
				{
					num = 16;
				}
				continue;
			case 22:
				if (trades < num10)
				{
					return;
				}
				if (num11 >= 0)
				{
					num = 2;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_331783b4349f408da28eb7270800e8f2 != 0)
					{
						num = 26;
					}
					continue;
				}
				goto IL_0158;
			case 14:
				if (trades <= num9)
				{
					goto IL_0176;
				}
				goto case 1;
			case 8:
				num4 = Filter2Max;
				if (!num4.HasValue)
				{
					num = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_ff7ea8439ae74c169eea85409be2ee21 == 0)
					{
						num = 2;
					}
					continue;
				}
				num5 = num4.GetValueOrDefault();
				goto IL_0551;
			case 9:
				num8 = -1;
				goto IL_0522;
			case 17:
				sq3ij8jfiPL = -1;
				GaVijAenFtB = -1;
				num = 5;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_be0348d4881e4572932fccb8442b1a1a == 0)
				{
					num = 6;
				}
				continue;
			case 24:
				if (GaVijAenFtB >= num2)
				{
					return;
				}
				num = 3;
				continue;
			case 5:
				cluster = base.DataProvider.GetCluster(num2 - 1);
				num = 25;
				continue;
			case 18:
				{
					if (jRBij7svcuh < num2)
					{
						num4 = Filter1Min;
						num = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_90a598f03c844da79a9f9a1acc80d34f == 0)
						{
							num = 0;
						}
					}
					else
					{
						num = 12;
					}
					continue;
				}
				IL_0551:
				num6 = num5;
				num = 13;
				continue;
				IL_0522:
				num7 = num8;
				num4 = Filter1Max;
				num9 = num4 ?? (-1);
				if (num7 < 0)
				{
					num = 4;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_be0348d4881e4572932fccb8442b1a1a != 0)
					{
						num = 1;
					}
					continue;
				}
				goto case 21;
				IL_0096:
				if (Filter3Alert.IsActive)
				{
					num = 24;
					continue;
				}
				return;
				IL_0158:
				GaVijAenFtB = num2;
				AddAlert(Filter3Alert, string.Format(Resources.ChartIndicatorsTradesFilterAlert, 3, UoUplYexMsEMoR1SkSJu(base.DataProvider.Symbol, trades)));
				return;
				IL_0176:
				jRBij7svcuh = num2;
				num = 10;
				continue;
				IL_0564:
				num10 = num3;
				num4 = Filter3Max;
				num = 7;
				continue;
			}
			break;
		}
		goto IL_007f;
		IL_007f:
		num2 = YEnfrCexgSLA08eJtiO3(base.DataProvider);
		num = 5;
		goto IL_0009;
	}

	public override bool GetMinMax(out double P_0, out double P_1)
	{
		P_0 = 0.0;
		P_1 = 0.0;
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3a22ea2a41c84163a97ae0a1f3b4c6b4 != 0)
		{
			num = 0;
		}
		IChartCluster cluster = default(IChartCluster);
		double num4 = default(double);
		int? num5 = default(int?);
		int num3;
		int index = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			case 3:
				if (cluster != null)
				{
					num4 = cluster.Trades;
					if (P_1 < num4)
					{
						num = 5;
						continue;
					}
				}
				goto IL_0144;
			case 7:
				if (num5.HasValue)
				{
					num3 = num5.GetValueOrDefault();
					break;
				}
				goto case 8;
			case 8:
				num3 = -1;
				break;
			case 6:
				cluster = base.DataProvider.GetCluster(index);
				num = 3;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0450b8b54d9e402da4e2f9dc872984ee == 0)
				{
					num = 2;
				}
				continue;
			case 5:
				P_1 = num4;
				goto IL_0144;
			case 4:
				if (num2 >= base.Canvas.Count)
				{
					num = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_05d722d67d874d6fa7bb056304182294 == 0)
					{
						num = 1;
					}
					continue;
				}
				goto case 2;
			case 1:
				num5 = MaxTrades;
				num = 3;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_d4f52eaa7d9d4aa09bb6fdf0b3adf8b6 == 0)
				{
					num = 7;
				}
				continue;
			case 2:
				index = base.Canvas.GetIndex(num2);
				num = 6;
				continue;
			default:
				{
					if (base.Canvas.IsStock)
					{
						return false;
					}
					num2 = 0;
					num = 4;
					continue;
				}
				IL_0144:
				num2++;
				goto case 4;
			}
			break;
		}
		int num6 = num3;
		if (num6 >= 0 && P_1 > (double)num6)
		{
			P_1 = num6;
		}
		return true;
	}

	private double x4GicROkuly()
	{
		double num = 0.0;
		int num2 = 0;
		int num3 = 1;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3619c4e2195548a982d8ce7a7eb0208e != 0)
		{
			num3 = 1;
		}
		int num5 = default(int);
		double num4 = default(double);
		IChartCluster cluster = default(IChartCluster);
		int index = default(int);
		while (true)
		{
			switch (num3)
			{
			case 1:
				if (num2 >= base.Canvas.Count)
				{
					num5 = MaxTrades ?? (-1);
					if (num5 >= 0)
					{
						num3 = 2;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8c0cafc031434e41bde083ffe3129211 != 0)
						{
							num3 = 2;
						}
						continue;
					}
					break;
				}
				goto case 3;
			case 7:
				if (num < num4)
				{
					num = num4;
					num3 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e74f04d60e394f2bbc3b9757a3df6bbb == 0)
					{
						num3 = 0;
					}
					continue;
				}
				goto default;
			case 4:
				cluster = base.DataProvider.GetCluster(index);
				num3 = 2;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_88a7c33625fa4b38aecf07f72758e410 != 0)
				{
					num3 = 6;
				}
				continue;
			case 3:
				index = base.Canvas.GetIndex(num2);
				num3 = 4;
				continue;
			case 6:
				if (cluster != null)
				{
					num3 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e9f58003753b4aa88a036bb6f675d81b != 0)
					{
						num3 = 5;
					}
					continue;
				}
				goto default;
			case 2:
				if (num > (double)num5)
				{
					num = num5;
				}
				break;
			default:
				num2++;
				goto case 1;
			case 5:
				num4 = cluster.Trades;
				num3 = 7;
				continue;
			}
			break;
		}
		return num;
	}

	public override void Render(DxVisualQueue P_0)
	{
		int num = 12;
		int num2 = num;
		int? num4 = default(int?);
		int num14 = default(int);
		IChartCluster cluster = default(IChartCluster);
		double y2 = default(double);
		double num15 = default(double);
		int num9 = default(int);
		XBrush xBrush = default(XBrush);
		int num12 = default(int);
		double x = default(double);
		int index = default(int);
		XPen xPen = default(XPen);
		double num5 = default(double);
		int num6 = default(int);
		int num7 = default(int);
		int num10 = default(int);
		int num3 = default(int);
		int num8 = default(int);
		int num11 = default(int);
		bool flag = default(bool);
		double y = default(double);
		while (true)
		{
			int num13;
			switch (num2)
			{
			case 30:
				num4 = Filter3Max;
				num2 = 35;
				break;
			case 19:
				if (num14 >= 0 && cluster.Trades >= num14)
				{
					num2 = 6;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_22e7feb62ce84fd89a7a86f584263fcc == 0)
					{
						num2 = 27;
					}
					break;
				}
				goto case 34;
			case 9:
				if (!num4.HasValue)
				{
					num2 = 22;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_51365cbe57344dc59bfcbecc60361463 == 0)
					{
						num2 = 0;
					}
					break;
				}
				num13 = num4.GetValueOrDefault();
				goto IL_06e2;
			case 11:
				lefic6oa1ZY(P_0);
				num2 = 23;
				break;
			case 20:
				y2 = GetY(0.0);
				num15 = PTcf3bexqdHFyJHCd136(base.Canvas.ColumnWidth - 1.0, 1.0);
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_51ae13532ac34475801f72e10929a614 == 0)
				{
					num2 = 1;
				}
				break;
			case 16:
				if (num9 < 0 || cluster.Trades <= num9)
				{
					xBrush = DDqijK0Dr4F;
					num2 = 8;
					break;
				}
				goto IL_0469;
			case 17:
			case 25:
				num12++;
				goto case 6;
			case 31:
				x = base.Canvas.GetX(index);
				num2 = 14;
				break;
			case 21:
				if (xPen != null)
				{
					P_0.DrawLine(xPen, new Point(x, num5), new Point(x, num5 + (double)num6));
					num2 = 17;
					break;
				}
				goto case 33;
			case 26:
				if (cluster.Trades > num7)
				{
					goto case 19;
				}
				goto IL_0147;
			case 13:
				if (num6 >= 0)
				{
					num2 = 2;
					break;
				}
				goto case 17;
			case 37:
				xPen = VrIijySveFZ;
				goto IL_0469;
			case 6:
				if (num12 >= base.Canvas.Count)
				{
					return;
				}
				goto case 10;
			case 35:
				num9 = num4 ?? (-1);
				num2 = 18;
				break;
			case 10:
				index = base.Canvas.GetIndex(num12);
				cluster = base.DataProvider.GetCluster(index);
				num2 = 28;
				break;
			case 29:
				num7 = num4 ?? (-1);
				num4 = Filter2Min;
				num14 = num4 ?? (-1);
				num2 = 5;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_ebea16d83ff14ec5b816c14cbab4c1cf == 0)
				{
					num2 = 15;
				}
				break;
			case 27:
				if (num10 < 0)
				{
					goto case 5;
				}
				if (cluster.Trades <= num10)
				{
					num2 = 5;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_95275e3d621141038abe728ac8c7fa6c == 0)
					{
						num2 = 4;
					}
					break;
				}
				goto case 34;
			case 5:
				xBrush = ai9ijTp2rHp;
				num2 = 37;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9f8132c088e4447e83ec74ef15b8e944 == 0)
				{
					num2 = 31;
				}
				break;
			case 14:
				num5 = GetY((double)cluster.Trades);
				if (num3 >= 0)
				{
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_7d6ed381220347c0b7bad07060beb773 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto IL_047e;
			case 4:
				if (cluster.Trades < num8)
				{
					goto case 19;
				}
				if (num7 >= 0)
				{
					num2 = 17;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_ffb93a04ce4c4a8e857e2e7fd646df59 != 0)
					{
						num2 = 26;
					}
					break;
				}
				goto IL_0147;
			case 1:
				num12 = 0;
				num2 = 6;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_331783b4349f408da28eb7270800e8f2 == 0)
				{
					num2 = 0;
				}
				break;
			case 23:
				return;
			case 32:
				num10 = num4 ?? (-1);
				num2 = 3;
				break;
			case 3:
				num4 = Filter3Min;
				num2 = 9;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bddbd469f60045dea35a495487f8a4fb == 0)
				{
					num2 = 7;
				}
				break;
			case 34:
				if (num11 >= 0 && cluster.Trades >= num11)
				{
					num2 = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_c6d928b106694fcbadc87b1b898a5509 == 0)
					{
						num2 = 16;
					}
					break;
				}
				goto IL_0469;
			case 2:
				if (num6 < 1)
				{
					num5 = (int)y2 - 1;
					num6 = 1;
					num2 = 24;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9f8132c088e4447e83ec74ef15b8e944 == 0)
					{
						num2 = 24;
					}
					break;
				}
				goto case 24;
			case 18:
				num4 = MaxTrades;
				num2 = 36;
				break;
			case 22:
				num13 = -1;
				goto IL_06e2;
			case 8:
				xPen = qgmijmYh0bs;
				goto IL_0469;
			case 28:
				if (cluster != null)
				{
					num2 = 31;
					break;
				}
				goto case 17;
			case 7:
				xBrush = null;
				xPen = null;
				if (num8 >= 0)
				{
					num2 = 4;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_86d84d52ab13483783040bb945a786b2 == 0)
					{
						num2 = 4;
					}
					break;
				}
				goto case 19;
			case 15:
				num4 = Filter2Max;
				num2 = 32;
				break;
			case 24:
				flag = (DeltaColored ? (wxLa8iexWV0CQEESOKXG(cluster) > 0m) : HWCVIWexI7b3HKwkB1sM(cluster));
				num2 = 7;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e9f58003753b4aa88a036bb6f675d81b == 0)
				{
					num2 = 4;
				}
				break;
			case 12:
				if (!RXFyn2exOWacCmRNsTuq(base.Canvas))
				{
					num8 = Filter1Min ?? (-1);
					num4 = Filter1Max;
					num2 = 29;
				}
				else
				{
					num2 = 11;
				}
				break;
			default:
				num5 = Math.Max(num5, y);
				goto IL_047e;
			case 36:
				num3 = num4 ?? (-1);
				y = GetY((double)num3);
				num2 = 20;
				break;
			case 33:
				{
					OCBvfAextvsMTHxq0SUj(P_0, flag ? Q8yijcvfnZB : qSTijQIPaPi, new Point(x, num5), new Point(x, num5 + (double)num6));
					goto case 17;
				}
				IL_047e:
				num6 = (int)y2 - (int)num5;
				num2 = 13;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_4200640706544f569f191265929ec243 != 0)
				{
					num2 = 3;
				}
				break;
				IL_0147:
				xBrush = YuXijOvSTq5;
				xPen = DHdijq7x6qJ;
				goto IL_0469;
				IL_0469:
				if (num15 > 1.0)
				{
					if (xBrush != null)
					{
						P_0.FillRectangle(xBrush, new Rect(x - num15 / 2.0, num5, num15, num6));
						goto case 17;
					}
					P_0.FillRectangle(flag ? jUAijXfJPYb : wC7ijEavOND, new Rect(x - num15 / 2.0, num5, num15, num6));
					num2 = 25;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_35044ecf03034683aa5038f38795ec31 != 0)
					{
						num2 = 5;
					}
					break;
				}
				goto case 21;
				IL_06e2:
				num11 = num13;
				num2 = 30;
				break;
			}
		}
	}

	public void lefic6oa1ZY(DxVisualQueue P_0)
	{
		int num = 31;
		int? num3 = default(int?);
		IChartCluster chartCluster = default(IChartCluster);
		int num10 = default(int);
		int num22 = default(int);
		XBrush xBrush = default(XBrush);
		XPen xPen = default(XPen);
		int index = default(int);
		int num17 = default(int);
		double x = default(double);
		double num7 = default(double);
		double num14 = default(double);
		int num15 = default(int);
		double num5 = default(double);
		Rect rect = default(Rect);
		double val = default(double);
		double num6 = default(double);
		int num11 = default(int);
		int num8 = default(int);
		int num9 = default(int);
		bool flag = default(bool);
		int num21 = default(int);
		int num12 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num16;
				int num20;
				int num13;
				bool num23;
				int num4;
				int num18;
				int num19;
				switch (num2)
				{
				case 35:
					num3 = Filter3Min;
					if (!num3.HasValue)
					{
						num2 = 26;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_95275e3d621141038abe728ac8c7fa6c == 0)
						{
							num2 = 24;
						}
						break;
					}
					num16 = num3.GetValueOrDefault();
					goto IL_06c3;
				case 11:
					if (HyOUn4exyBxlXDww19Er(chartCluster) >= num10 && (num22 < 0 || chartCluster.Trades <= num22))
					{
						xBrush = DDqijK0Dr4F;
						xPen = qgmijmYh0bs;
					}
					goto case 7;
				case 19:
					xBrush = YuXijOvSTq5;
					num2 = 12;
					break;
				case 23:
					index = base.Canvas.GetIndex(num17);
					num2 = 36;
					break;
				case 18:
					if (!num3.HasValue)
					{
						goto case 16;
					}
					num20 = num3.GetValueOrDefault();
					goto IL_068f;
				case 2:
				case 3:
				case 22:
					num17++;
					num2 = 25;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3086d3efc49e46839e3f8d95f5cafecb != 0)
					{
						num2 = 27;
					}
					break;
				case 15:
					xh6QvpexZqeYBBFGrjkG(P_0, xBrush, new Rect(x - num7 / 2.0, num14, num7, num15));
					goto case 2;
				default:
					num13 = -1;
					goto IL_06b0;
				case 25:
					num5 = rect.Bottom - 2.0;
					val = num5 - num6;
					num7 = Math.Max(base.Canvas.ColumnWidth - 1.0, 1.0);
					num2 = 17;
					break;
				case 30:
					num11 = num3 ?? (-1);
					num2 = 29;
					break;
				case 10:
					x = base.Canvas.GetX(index);
					num2 = 34;
					break;
				case 17:
					S3FijPmnLXb = x4GicROkuly();
					num17 = 0;
					goto case 27;
				case 28:
					if (chartCluster != null)
					{
						num2 = 4;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e767fb04e1fb471592fd70a4ebcca575 == 0)
						{
							num2 = 10;
						}
						break;
					}
					goto case 2;
				case 5:
					num23 = chartCluster.IsUp;
					goto IL_06fc;
				case 1:
					if (num8 < 0 || HyOUn4exyBxlXDww19Er(chartCluster) < num8 || (num9 >= 0 && chartCluster.Trades > num9))
					{
						if (num10 >= 0)
						{
							num2 = 6;
							if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0450b8b54d9e402da4e2f9dc872984ee != 0)
							{
								num2 = 11;
							}
							break;
						}
						goto case 7;
					}
					xBrush = ai9ijTp2rHp;
					num2 = 9;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_7e45d53bf40748f9915553e145413be0 != 0)
					{
						num2 = 9;
					}
					break;
				case 16:
					num20 = -1;
					goto IL_068f;
				case 32:
					num15 = (int)num5 - (int)num14;
					if (num15 < 0)
					{
						goto case 2;
					}
					if (!DeltaColored)
					{
						num2 = 5;
						break;
					}
					num23 = chartCluster.Delta > 0m;
					goto IL_06fc;
				case 29:
					num3 = Filter1Max;
					num2 = 18;
					break;
				case 27:
					if (num17 >= base.Canvas.Count)
					{
						return;
					}
					goto case 23;
				case 36:
					chartCluster = (IChartCluster)G5Mw4RexTZfIAx3t5fdL(base.DataProvider, index);
					num2 = 28;
					break;
				case 21:
					if (xBrush != null)
					{
						num2 = 15;
						break;
					}
					P_0.FillRectangle(flag ? jUAijXfJPYb : wC7ijEavOND, new Rect(x - num7 / 2.0, num14, num7, num15));
					num2 = 22;
					break;
				case 24:
					num4 = -1;
					goto IL_06a2;
				case 9:
					xPen = VrIijySveFZ;
					num2 = 7;
					break;
				case 26:
					num16 = -1;
					goto IL_06c3;
				case 6:
					num3 = MaxTrades;
					num2 = 20;
					break;
				case 20:
					if (!num3.HasValue)
					{
						num2 = 10;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f11cc1d6b7f3456db092304ccadade75 == 0)
						{
							num2 = 14;
						}
						break;
					}
					num18 = num3.GetValueOrDefault();
					goto IL_06e4;
				case 4:
					num19 = -1;
					goto IL_06d1;
				case 34:
					num14 = num5 - num6 * (double)chartCluster.Trades / S3FijPmnLXb;
					if (num21 >= 0)
					{
						num14 = Math.Max(num14, val);
						num2 = 32;
						break;
					}
					goto case 32;
				case 13:
					if (!num3.HasValue)
					{
						goto end_IL_0012;
					}
					num19 = num3.GetValueOrDefault();
					goto IL_06d1;
				case 31:
					num3 = Filter1Min;
					num2 = 30;
					break;
				case 12:
					xPen = DHdijq7x6qJ;
					num2 = 37;
					break;
				case 14:
					num18 = -1;
					goto IL_06e4;
				case 33:
					if (num11 >= 0 && chartCluster.Trades >= num11)
					{
						if (num12 < 0)
						{
							goto case 19;
						}
						if (HyOUn4exyBxlXDww19Er(chartCluster) <= num12)
						{
							num2 = 19;
							break;
						}
					}
					goto case 1;
				case 8:
					num3 = Filter2Min;
					if (!num3.HasValue)
					{
						num2 = 24;
						break;
					}
					num4 = num3.GetValueOrDefault();
					goto IL_06a2;
				case 7:
				case 37:
					{
						if (!(num7 > 1.0))
						{
							if (xPen != null)
							{
								P_0.DrawLine(xPen, new Point(x, num14), new Point(x, num14 + (double)num15));
								num2 = 3;
							}
							else
							{
								OCBvfAextvsMTHxq0SUj(P_0, flag ? Q8yijcvfnZB : qSTijQIPaPi, new Point(x, num14), new Point(x, num14 + (double)num15));
								num2 = 2;
							}
						}
						else
						{
							num2 = 21;
						}
						break;
					}
					IL_06b0:
					num9 = num13;
					num2 = 35;
					break;
					IL_06c3:
					num10 = num16;
					num3 = Filter3Max;
					num2 = 13;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_ff7ea8439ae74c169eea85409be2ee21 != 0)
					{
						num2 = 9;
					}
					break;
					IL_06d1:
					num22 = num19;
					num2 = 6;
					break;
					IL_06e4:
					num21 = num18;
					num6 = KCkWZfexULP2G6es07j5(base.Canvas).Height * 0.2;
					rect = base.Canvas.Rect;
					num2 = 14;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f11cc1d6b7f3456db092304ccadade75 == 0)
					{
						num2 = 25;
					}
					break;
					IL_06fc:
					flag = num23;
					xBrush = null;
					xPen = null;
					num2 = 33;
					break;
					IL_06a2:
					num8 = num4;
					num3 = Filter2Max;
					if (!num3.HasValue)
					{
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_265fe44b237843c0af011f50c2e58924 != 0)
						{
							num2 = 0;
						}
						break;
					}
					num13 = num3.GetValueOrDefault();
					goto IL_06b0;
					IL_068f:
					num12 = num20;
					num2 = 8;
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 4;
		}
	}

	public override List<IndicatorValueInfo> GetValues(int cursorPos)
	{
		List<IndicatorValueInfo> list = new List<IndicatorValueInfo>();
		IChartCluster cluster = base.DataProvider.GetCluster(cursorPos);
		if (cluster == null)
		{
			return list;
		}
		string value = base.Canvas.FormatValue(cluster.Trades);
		if (base.Canvas.IsStock)
		{
			value = base.DataProvider.Symbol.FormatSizeShort(cluster.Trades);
		}
		list.Add(new IndicatorValueInfo(value, new XBrush(cluster.IsUp ? sWkijjxAfME : SgBijd0S5Wx)));
		return list;
	}

	public override void GetLabels(ref List<IndicatorLabelInfo> P_0)
	{
		int num = 1;
		int num2 = num;
		IChartCluster cluster = default(IChartCluster);
		double? position = default(double?);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				if (base.DataProvider.Count <= MMBl4yexV7WO1Ukqmsd8(base.Canvas))
				{
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_a103e6559ac3474e9e79ab00912c861c != 0)
					{
						num2 = 0;
					}
					break;
				}
				cluster = base.DataProvider.GetCluster(base.DataProvider.Count - 1 - base.Canvas.Start);
				if (cluster == null)
				{
					num2 = 3;
					break;
				}
				position = null;
				num2 = 2;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_b35db2c0f4de46efa9eb8ca63c778728 == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				if (RXFyn2exOWacCmRNsTuq(base.Canvas))
				{
					position = base.Canvas.Rect.Bottom - base.Canvas.Rect.Height * 0.2 * (double)cluster.Trades / S3FijPmnLXb;
				}
				P_0.Add(new IndicatorLabelInfo(HyOUn4exyBxlXDww19Er(cluster), cluster.IsUp ? sWkijjxAfME : SgBijd0S5Wx, position));
				return;
			case 0:
				return;
			case 3:
				return;
			}
		}
	}

	public override bool CheckAlert(double P_0, int P_1, ref int P_2, ref double P_3)
	{
		if (base.Canvas.IsStock)
		{
			return false;
		}
		int num;
		if (base.DataProvider.Count != P_2 || P_0 != P_3)
		{
			IChartCluster chartCluster = (IChartCluster)G5Mw4RexTZfIAx3t5fdL(base.DataProvider, base.DataProvider.Count - 1);
			if (chartCluster == null)
			{
				goto IL_006d;
			}
			if ((double)chartCluster.Trades < P_0 - (double)P_1)
			{
				return false;
			}
			P_2 = base.DataProvider.Count;
			num = 2;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_59aa80f4e54b43b381fcc4e95a4cfa2b == 0)
			{
				num = 2;
			}
		}
		else
		{
			num = 3;
		}
		while (true)
		{
			switch (num)
			{
			case 3:
				return false;
			case 1:
				return true;
			case 2:
				P_3 = P_0;
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_caac71a6f9cb44c08459ac3c8bd80328 == 0)
				{
					num = 1;
				}
				continue;
			}
			break;
		}
		goto IL_006d;
		IL_006d:
		return false;
	}

	public override void ApplyColors(IChartTheme P_0)
	{
		UpColor = P_0.PaletteColor6;
		DownColor = EKd3Z7exCUy0KnPig3fh(P_0);
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_90a598f03c844da79a9f9a1acc80d34f == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		base.ApplyColors(P_0);
	}

	public override void CopyTemplate(IndicatorBase P_0, bool P_1)
	{
		int num = 11;
		int num2 = num;
		WAKAUCicdgbP3vYprhL5 wAKAUCicdgbP3vYprhL = default(WAKAUCicdgbP3vYprhL5);
		while (true)
		{
			switch (num2)
			{
			case 2:
				Filter2Alert.Copy((ChartAlertSettings)ke6rjaex87297FwU5JF4(wAKAUCicdgbP3vYprhL), !P_1);
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-165474503 ^ -165439211));
				num2 = 6;
				break;
			case 10:
				UpColor = vf4sf8exrX3uPxGP01ie(wAKAUCicdgbP3vYprhL);
				DownColor = Wagu6AexKxiIw4NQnrTv(wAKAUCicdgbP3vYprhL);
				DeltaColored = chXFRHexmTss7tvpxuQp(wAKAUCicdgbP3vYprhL);
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_14b81aa01f3b465ba9caee83d494621b == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				oElicK88quh.Copy((IndicatorParam<int?>)bFcnxxexhmKe0H2u8vEw(wAKAUCicdgbP3vYprhL));
				PKgic8PsBMl.Copy(wAKAUCicdgbP3vYprhL.PKgic8PsBMl);
				num2 = 8;
				break;
			default:
				zN5icyraJu6.Copy(wAKAUCicdgbP3vYprhL.zN5icyraJu6);
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1522697859 ^ -1522669917));
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_39ef76bd8f0947d084200e4afe419409 != 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				Filter1Alert.Copy(wAKAUCicdgbP3vYprhL.Filter1Alert, !P_1);
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-671204305 ^ -671176263));
				qXiij06mtFI.Copy(wAKAUCicdgbP3vYprhL.qXiij06mtFI);
				YmwijnCZlrM.Copy(wAKAUCicdgbP3vYprhL.YmwijnCZlrM);
				OnPropertyChanged((string)FUfrOfexjo7r4DuweayL(-617064403 ^ -617034337));
				OnPropertyChanged((string)FUfrOfexjo7r4DuweayL(0x28C965BE ^ 0x28C9F074));
				Filter2Color = ddjiOYex78dgTwJhRyhF(wAKAUCicdgbP3vYprhL);
				num2 = 2;
				break;
			case 11:
				wAKAUCicdgbP3vYprhL = (WAKAUCicdgbP3vYprhL5)P_0;
				num2 = 10;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_abb7f19926ed4d07ba9755366ca9a059 == 0)
				{
					num2 = 6;
				}
				break;
			case 12:
				Filter3Color = wAKAUCicdgbP3vYprhL.Filter3Color;
				Filter3Alert.Copy(wAKAUCicdgbP3vYprhL.Filter3Alert, !P_1);
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1435596783 ^ -1435623725));
				base.CopyTemplate(P_0, P_1);
				num2 = 9;
				break;
			case 3:
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1799510641 ^ -1799540549));
				Filter1Color = wMhKk6exwchBNZVJqS8p(wAKAUCicdgbP3vYprhL);
				num2 = 4;
				break;
			case 8:
				OnPropertyChanged((string)FUfrOfexjo7r4DuweayL(--737722733 ^ 0x2BF85471));
				num2 = 3;
				break;
			case 7:
				cPRij1fqHcC.Copy((IndicatorParam<int?>)yLIIGZexAZW2o6HO0204(wAKAUCicdgbP3vYprhL));
				num2 = 5;
				break;
			case 9:
				return;
			case 6:
				By5ij4SAgct.Copy(wAKAUCicdgbP3vYprhL.By5ij4SAgct);
				num2 = 7;
				break;
			case 5:
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x2CBEEA31 ^ 0x2CBE7C79));
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-342738082 ^ -342708930));
				num2 = 12;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8bad63f401844feb8b319ab89401e7b9 == 0)
				{
					num2 = 12;
				}
				break;
			}
		}
	}

	static WAKAUCicdgbP3vYprhL5()
	{
		gxI1UTexPGrMIpnoRLPh();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool STlgylexXR5le48ogHQZ()
	{
		return j5e7e4exsTPMe7VykxNM == null;
	}

	internal static WAKAUCicdgbP3vYprhL5 ltsTLiexc8e3sjFIvC1m()
	{
		return j5e7e4exsTPMe7VykxNM;
	}

	internal static object FUfrOfexjo7r4DuweayL(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static bool wto7wmexEKqRJDO9PZsy(XColor P_0, XColor P_1)
	{
		return P_0 == P_1;
	}

	internal static XColor AuReDsexQpH0OsmhW3gb(Color P_0)
	{
		return P_0;
	}

	internal static Color Tf3f3xexdIj9tsrNhbxr()
	{
		return Colors.Orange;
	}

	internal static int YEnfrCexgSLA08eJtiO3(object P_0)
	{
		return ((IChartDataProvider)P_0).Count;
	}

	internal static object pa62kSexRg6V5Ng0PA3a(object P_0)
	{
		return ((IChartDataProvider)P_0).Symbol;
	}

	internal static object Cxk8XWex6QWIxmIOeigb()
	{
		return Resources.ChartIndicatorsTradesFilterAlert;
	}

	internal static object UoUplYexMsEMoR1SkSJu(object P_0, long trades)
	{
		return ((IChartSymbol)P_0).FormatTrades(trades);
	}

	internal static bool RXFyn2exOWacCmRNsTuq(object P_0)
	{
		return ((IChartCanvas)P_0).IsStock;
	}

	internal static double PTcf3bexqdHFyJHCd136(double P_0, double P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static bool HWCVIWexI7b3HKwkB1sM(object P_0)
	{
		return ((IChartCluster)P_0).IsUp;
	}

	internal static decimal wxLa8iexWV0CQEESOKXG(object P_0)
	{
		return ((IChartCluster)P_0).Delta;
	}

	internal static void OCBvfAextvsMTHxq0SUj(object P_0, object P_1, Point P_2, Point P_3)
	{
		((DxVisualQueue)P_0).DrawLine((XPen)P_1, P_2, P_3);
	}

	internal static Rect KCkWZfexULP2G6es07j5(object P_0)
	{
		return ((IChartCanvas)P_0).Rect;
	}

	internal static object G5Mw4RexTZfIAx3t5fdL(object P_0, int i)
	{
		return ((IChartDataProvider)P_0).GetCluster(i);
	}

	internal static int HyOUn4exyBxlXDww19Er(object P_0)
	{
		return ((IChartCluster)P_0).Trades;
	}

	internal static void xh6QvpexZqeYBBFGrjkG(object P_0, object P_1, Rect P_2)
	{
		((DxVisualQueue)P_0).FillRectangle((XBrush)P_1, P_2);
	}

	internal static int MMBl4yexV7WO1Ukqmsd8(object P_0)
	{
		return ((IChartCanvas)P_0).Start;
	}

	internal static XColor EKd3Z7exCUy0KnPig3fh(object P_0)
	{
		return ((IChartTheme)P_0).PaletteColor7;
	}

	internal static XColor vf4sf8exrX3uPxGP01ie(object P_0)
	{
		return ((WAKAUCicdgbP3vYprhL5)P_0).UpColor;
	}

	internal static XColor Wagu6AexKxiIw4NQnrTv(object P_0)
	{
		return ((WAKAUCicdgbP3vYprhL5)P_0).DownColor;
	}

	internal static bool chXFRHexmTss7tvpxuQp(object P_0)
	{
		return ((WAKAUCicdgbP3vYprhL5)P_0).DeltaColored;
	}

	internal static object bFcnxxexhmKe0H2u8vEw(object P_0)
	{
		return ((WAKAUCicdgbP3vYprhL5)P_0).oElicK88quh;
	}

	internal static XColor wMhKk6exwchBNZVJqS8p(object P_0)
	{
		return ((WAKAUCicdgbP3vYprhL5)P_0).Filter1Color;
	}

	internal static XColor ddjiOYex78dgTwJhRyhF(object P_0)
	{
		return ((WAKAUCicdgbP3vYprhL5)P_0).Filter2Color;
	}

	internal static object ke6rjaex87297FwU5JF4(object P_0)
	{
		return ((WAKAUCicdgbP3vYprhL5)P_0).Filter2Alert;
	}

	internal static object yLIIGZexAZW2o6HO0204(object P_0)
	{
		return ((WAKAUCicdgbP3vYprhL5)P_0).cPRij1fqHcC;
	}

	internal static void gxI1UTexPGrMIpnoRLPh()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
	}
}
