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
using TigerTrade.Dx.Enums;

namespace suN1pmixjPnIpOJgQP0u;

[Indicator("Histogram", "Histogram", true, Type = typeof(kYtP6Tixcn838Vsnv2ea))]
[DataContract(Name = "HistogramIndicator", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
internal sealed class kYtP6Tixcn838Vsnv2ea : IndicatorBase
{
	private HistogramPeriodType TwEiLeuqEox;

	private int tt8iLsBjcYO;

	private bool zcSiLX3nPMR;

	private DateTime? GoIiLcoxtNm;

	private DateTime? bijiLjX7bWp;

	private HistogramViewType ICDiLEbv6ph;

	private HistogramCellViewType zHaiLQ5jJap;

	private bool kRQiLdlXCgu;

	private bool rx6iLgQpAm0;

	private bool j2iiLROeBLT;

	private IndicatorIntParam uMiiL6VKuTg;

	private bool BnoiLMFJQYt;

	private bool y9PiLOh47D7;

	private int MPZiLq6iHME;

	private bool GhPiLI8kHne;

	private bool Y97iLWRwjJ5;

	private XBrush p8wiLtEVrpS;

	private XColor A62iLUdufL8;

	private XBrush rRAiLTEerbg;

	private XColor jMviLy1sHNX;

	private XBrush R1siLZDUmWK;

	private XColor eAQiLVflMx8;

	private XBrush RoqiLCKsikK;

	private XColor rj7iLrOT0pq;

	private XBrush ksviLKC00Yu;

	private XColor F7giLmC0FFZ;

	private XBrush InjiLhNBGNU;

	private XColor JrUiLwx8ele;

	private XBrush wBdiL7H4swA;

	private XColor yOsiL8YbIHx;

	private XBrush kSYiLAlotVw;

	private XColor cNWiLPASQQq;

	private XBrush S83iLJok02v;

	private XPen YFmiLFwLsnQ;

	private XColor uBgiL3icuql;

	private XBrush b65iLp5uhrs;

	private XColor OpQiLucRr0N;

	private List<IndicatorLabelInfo> w6aiLzcGKeR;

	private long eLEie0inyrV;

	private RawCluster D3eie2uiSma;

	private static kYtP6Tixcn838Vsnv2ea qNt64ie1N4x5FbybCi5a;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.Cluster;

	[DataMember(Name = "PeriodType")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsPeriodType")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsPeriod")]
	public HistogramPeriodType PeriodType
	{
		get
		{
			return TwEiLeuqEox;
		}
		set
		{
			int num = 3;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return;
				case 1:
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-690510723 ^ -690536869));
					num2 = 4;
					break;
				case 4:
					OnPropertyChanged((string)UcSAeSe15koJFq2pZ90F(--146713930 ^ 0x8BE3776));
					return;
				case 3:
					if (histogramPeriodType != TwEiLeuqEox)
					{
						TwEiLeuqEox = histogramPeriodType;
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_51365cbe57344dc59bfcbecc60361463 != 0)
						{
							num2 = 0;
						}
					}
					else
					{
						num2 = 1;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0f9979478ba842a39155e14f5980ecce != 0)
						{
							num2 = 2;
						}
					}
					break;
				default:
					tt8iLsBjcYO = ((TwEiLeuqEox != HistogramPeriodType.Minute) ? 1 : 15);
					Clear();
					OnPropertyChanged((string)UcSAeSe15koJFq2pZ90F(0x4297C3EB ^ 0x42975AE1));
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x28B345BB ^ 0x28B3DC99));
					OnPropertyChanged((string)UcSAeSe15koJFq2pZ90F(0x2D3134C9 ^ 0x2D31AEC3));
					num2 = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_4c510febac3445efbec11458d423f537 == 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}
	}

	[DataMember(Name = "PeriodValue")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsPeriod")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsPeriodValue")]
	public int PeriodValue
	{
		get
		{
			return tt8iLsBjcYO;
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
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_66132b7977414fa9a4eabdda3db7b75c != 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1841489831 ^ -1841462917));
					return;
				}
				if (num3 == tt8iLsBjcYO)
				{
					return;
				}
				tt8iLsBjcYO = num3;
				Clear();
				num2 = 2;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0f9979478ba842a39155e14f5980ecce == 0)
				{
					num2 = 1;
				}
			}
		}
	}

	[DataMember(Name = "PeriodRevers")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsPeriodRevers")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsPeriod")]
	public bool PeriodRevers
	{
		get
		{
			return zcSiLX3nPMR;
		}
		set
		{
			if (flag != zcSiLX3nPMR)
			{
				zcSiLX3nPMR = flag;
				Clear();
				OnPropertyChanged((string)UcSAeSe15koJFq2pZ90F(0x42D899B5 ^ 0x42D803BF));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_ebea16d83ff14ec5b816c14cbab4c1cf == 0)
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

	[DataMember(Name = "StartDate")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsStartDate")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsPeriod")]
	public DateTime? StartDate
	{
		get
		{
			return GoIiLcoxtNm;
		}
		set
		{
			if (!goIiLcoxtNm.Equals(GoIiLcoxtNm))
			{
				GoIiLcoxtNm = goIiLcoxtNm;
				Clear();
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-45476899 ^ -45446661));
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsPeriod")]
	[DataMember(Name = "EndDate")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsEndDate")]
	public DateTime? EndDate
	{
		get
		{
			return bijiLjX7bWp;
		}
		set
		{
			if (!dateTime.Equals(bijiLjX7bWp))
			{
				bijiLjX7bWp = dateTime;
				Clear();
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-673683647 ^ -673645187));
			}
		}
	}

	[DataMember(Name = "HistogramViewType")]
	[DefaultValue(HistogramViewType.Volume)]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsHistogramType")]
	public HistogramViewType HistogramViewType
	{
		get
		{
			return ICDiLEbv6ph;
		}
		set
		{
			if (histogramViewType != ICDiLEbv6ph)
			{
				ICDiLEbv6ph = histogramViewType;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x7ADBF691 ^ 0x7ADB6CDF));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_900fe0d7516743c1bc15292a67b06048 == 0)
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

	[DefaultValue(HistogramCellViewType.Solid)]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsHistogramCellType")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[DataMember(Name = "HistogramCellViewType")]
	public HistogramCellViewType HistogramCellViewType
	{
		get
		{
			return zHaiLQ5jJap;
		}
		set
		{
			if (histogramCellViewType != zHaiLQ5jJap)
			{
				zHaiLQ5jJap = histogramCellViewType;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_929b6fa00f634070a51f43668e9cc32e == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged((string)UcSAeSe15koJFq2pZ90F(0x4297C3EB ^ 0x4297599F));
			}
		}
	}

	[DataMember(Name = "HistogramGradient")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsHistogramGradient")]
	[DefaultValue(true)]
	public bool HistogramGradient
	{
		get
		{
			return kRQiLdlXCgu;
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
					if (flag != kRQiLdlXCgu)
					{
						kRQiLdlXCgu = flag;
						OnPropertyChanged((string)UcSAeSe15koJFq2pZ90F(-90307782 ^ -90269288));
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f866dbb44e884db6a20dd750c320252b == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DefaultValue(true)]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsHistogramShowValues")]
	[DataMember(Name = "HistogramShowValues")]
	public bool HistogramShowValues
	{
		get
		{
			return rx6iLgQpAm0;
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
					if (flag == rx6iLgQpAm0)
					{
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_ffb93a04ce4c4a8e857e2e7fd646df59 == 0)
						{
							num2 = 0;
						}
						break;
					}
					rx6iLgQpAm0 = flag;
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1416986301 ^ -1417012341));
					return;
				case 0:
					return;
				}
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[DataMember(Name = "HistogramMinimizeValues")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsHistogramMinimizeValues")]
	public bool HistogramMinimizeValues
	{
		get
		{
			return j2iiLROeBLT;
		}
		set
		{
			if (flag != j2iiLROeBLT)
			{
				j2iiLROeBLT = flag;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e9f58003753b4aa88a036bb6f675d81b == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(--855742383 ^ 0x33010D5D));
			}
		}
	}

	[DataMember(Name = "HistogramRoundValuesParam")]
	public IndicatorIntParam m5Eix84b9h5
	{
		get
		{
			return uMiiL6VKuTg ?? (uMiiL6VKuTg = new IndicatorIntParam(0));
		}
		set
		{
			uMiiL6VKuTg = indicatorIntParam;
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsHistogramRoundValues")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[DefaultValue(0)]
	public int HistogramRoundValues
	{
		get
		{
			return m5Eix84b9h5.Get(base.SettingsLongKey);
		}
		set
		{
			if (m5Eix84b9h5.Set(base.SettingsLongKey, value2, -4, 4))
			{
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x28BBDCA ^ 0x28B26EE));
			}
		}
	}

	[DefaultValue(true)]
	[DataMember(Name = "HistogramShowValueArea")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsHistogramShowValueArea")]
	public bool HistogramShowValueArea
	{
		get
		{
			return BnoiLMFJQYt;
		}
		set
		{
			if (flag != BnoiLMFJQYt)
			{
				BnoiLMFJQYt = flag;
				OnPropertyChanged((string)UcSAeSe15koJFq2pZ90F(0x741B85CB ^ 0x741B1E9B));
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

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[DefaultValue(false)]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsHistogramExtendValueArea")]
	[DataMember(Name = "HistogramExtendValueArea")]
	public bool HistogramExtendValueArea
	{
		get
		{
			return y9PiLOh47D7;
		}
		set
		{
			if (flag != y9PiLOh47D7)
			{
				y9PiLOh47D7 = flag;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1306877528 ^ -1306904024));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1e4f0311079548309df28e40c8b3397b == 0)
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

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsValueAreaPercent")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[DataMember(Name = "HistogramValueAreaPercent")]
	public int HistogramValueAreaPercent
	{
		get
		{
			return MPZiLq6iHME;
		}
		set
		{
			num = d8GNMDe1SZxGvV1Mlchl(0, Math.Min(100, num));
			int num2;
			if (num == 0)
			{
				num = 70;
				num2 = 2;
				goto IL_0009;
			}
			goto IL_00a0;
			IL_00a0:
			if (num == MPZiLq6iHME)
			{
				return;
			}
			MPZiLq6iHME = num;
			num2 = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_77d26139d1074373ba3d17cb18b3ec16 == 0)
			{
				num2 = 0;
			}
			goto IL_0009;
			IL_0009:
			while (true)
			{
				switch (num2)
				{
				default:
					Clear();
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1878953018 ^ -1878923150));
					num2 = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_4c510febac3445efbec11458d423f537 == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					break;
				case 1:
					return;
				}
				break;
			}
			goto IL_00a0;
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsHistogramShowPoc")]
	[DataMember(Name = "HistogramShowPoc")]
	[DefaultValue(true)]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	public bool HistogramShowPoc
	{
		get
		{
			return GhPiLI8kHne;
		}
		set
		{
			if (flag != GhPiLI8kHne)
			{
				GhPiLI8kHne = flag;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-82860344 ^ -82887390));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_025edf4a83be4acb8c8326612d0fc8c2 == 0)
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

	[DefaultValue(false)]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[DataMember(Name = "HistogramExtendPoc")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsHistogramExtendPoc")]
	public bool HistogramExtendPoc
	{
		get
		{
			return Y97iLWRwjJ5;
		}
		set
		{
			if (flag != Y97iLWRwjJ5)
			{
				Y97iLWRwjJ5 = flag;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x42D899B5 ^ 0x42D805BB));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_331783b4349f408da28eb7270800e8f2 == 0)
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

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsHistogramVolumeColor")]
	[DataMember(Name = "VolumeColor")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsStyle")]
	public XColor VolumeColor
	{
		get
		{
			return A62iLUdufL8;
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
					if (!(xColor == A62iLUdufL8))
					{
						A62iLUdufL8 = xColor;
						p8wiLtEVrpS = new XBrush(A62iLUdufL8);
						OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x6AB40973 ^ 0x6AB49545));
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8c0cafc031434e41bde083ffe3129211 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsHistogramTradesColor")]
	[DataMember(Name = "TradesColor")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsStyle")]
	public XColor TradesColor
	{
		get
		{
			return jMviLy1sHNX;
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
					if (!(xColor == jMviLy1sHNX))
					{
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_88a7c33625fa4b38aecf07f72758e410 == 0)
						{
							num2 = 0;
						}
						break;
					}
					return;
				case 2:
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x24B0B9E6 ^ 0x24B025B6));
					return;
				default:
					jMviLy1sHNX = xColor;
					rRAiLTEerbg = new XBrush(jMviLy1sHNX);
					num2 = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_739f779654714fe286f27606d950a9d9 == 0)
					{
						num2 = 2;
					}
					break;
				}
			}
		}
	}

	[DataMember(Name = "DeltaPlusColor")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsHistogramDeltaPlusColor")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsStyle")]
	public XColor DeltaPlusColor
	{
		get
		{
			return eAQiLVflMx8;
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
					return;
				case 0:
					return;
				case 1:
					eAQiLVflMx8 = xColor;
					R1siLZDUmWK = new XBrush(eAQiLVflMx8);
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-2123795572 ^ -2123765954));
					return;
				case 2:
					if (xColor == eAQiLVflMx8)
					{
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_676dd0a5ee95448585b63eb0094d7f85 != 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsStyle")]
	[DataMember(Name = "DeltaMinusColor")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsHistogramDeltaMinusColor")]
	public XColor DeltaMinusColor
	{
		get
		{
			return rj7iLrOT0pq;
		}
		set
		{
			if (!(xColor == rj7iLrOT0pq))
			{
				rj7iLrOT0pq = xColor;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_ff7ea8439ae74c169eea85409be2ee21 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				RoqiLCKsikK = new XBrush(rj7iLrOT0pq);
				OnPropertyChanged((string)UcSAeSe15koJFq2pZ90F(0x2BD86B18 ^ 0x2BD8FFCA));
			}
		}
	}

	[DataMember(Name = "BidColor")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsHistogramBidColor")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsStyle")]
	public XColor BidColor
	{
		get
		{
			return F7giLmC0FFZ;
		}
		set
		{
			if (!(xColor == F7giLmC0FFZ))
			{
				F7giLmC0FFZ = xColor;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_4f0cf0da7be4416c854b8885e7290889 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				ksviLKC00Yu = new XBrush(F7giLmC0FFZ);
				OnPropertyChanged((string)UcSAeSe15koJFq2pZ90F(-1153206687 ^ -1153177967));
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsHistogramAskColor")]
	[DataMember(Name = "AskColor")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsStyle")]
	public XColor AskColor
	{
		get
		{
			return JrUiLwx8ele;
		}
		set
		{
			if (!jHL4Bce1xDLT7yKNXwmB(xColor, JrUiLwx8ele))
			{
				JrUiLwx8ele = xColor;
				InjiLhNBGNU = new XBrush(JrUiLwx8ele);
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0450b8b54d9e402da4e2f9dc872984ee == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged((string)UcSAeSe15koJFq2pZ90F(-1801468030 ^ -1801496954));
			}
		}
	}

	[DataMember(Name = "ValueAreaColor")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsStyle")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsHistogramValueAreaColor")]
	public XColor ValueAreaColor
	{
		get
		{
			return yOsiL8YbIHx;
		}
		set
		{
			if (!(xColor == yOsiL8YbIHx))
			{
				yOsiL8YbIHx = xColor;
				wBdiL7H4swA = new XBrush(yOsiL8YbIHx);
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x6E2DFBED ^ 0x6E2D7E8D));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_59aa80f4e54b43b381fcc4e95a4cfa2b == 0)
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

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsHistogramPocColor")]
	[DataMember(Name = "MaximumColor")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsStyle")]
	public XColor MaximumColor
	{
		get
		{
			return cNWiLPASQQq;
		}
		set
		{
			if (xColor == cNWiLPASQQq)
			{
				return;
			}
			cNWiLPASQQq = xColor;
			kSYiLAlotVw = new XBrush(cNWiLPASQQq);
			int num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9086474a3ab6467d99a5717f01834bdb == 0)
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
				OnPropertyChanged((string)UcSAeSe15koJFq2pZ90F(0x7F645F3C ^ 0x7F64DBDC));
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_caac71a6f9cb44c08459ac3c8bd80328 == 0)
				{
					num = 1;
				}
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsHistogramCellBorderColor")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsStyle")]
	[DataMember(Name = "CellBorderColor")]
	public XColor CellBorderColor
	{
		get
		{
			return uBgiL3icuql;
		}
		set
		{
			if (xColor == uBgiL3icuql)
			{
				return;
			}
			uBgiL3icuql = xColor;
			int num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_578c88adb68d4c08b45439ab0955bb9b == 0)
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
					S83iLJok02v = new XBrush(uBgiL3icuql);
					YFmiLFwLsnQ = new XPen(S83iLJok02v, 1);
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1999650146 ^ -1999675660));
					num = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0cda726836d64094b2c4c18a328cd3aa == 0)
					{
						num = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsStyle")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsHistogramTextColor")]
	[DataMember(Name = "TextColor")]
	public XColor TextColor
	{
		get
		{
			return OpQiLucRr0N;
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
					if (!(xColor == OpQiLucRr0N))
					{
						OpQiLucRr0N = xColor;
						b65iLp5uhrs = new XBrush(OpQiLucRr0N);
						OnPropertyChanged((string)UcSAeSe15koJFq2pZ90F(-1774602229 ^ -1774598315));
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_4f0cf0da7be4416c854b8885e7290889 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[Browsable(false)]
	public override bool ShowIndicatorValues => false;

	[Browsable(false)]
	public override IndicatorCalculation Calculation => IndicatorCalculation.OnEachTick;

	public kYtP6Tixcn838Vsnv2ea()
	{
		xiZm9ye1LaEEw2Tk85eP();
		base._002Ector();
		UpVAkhe1eihELJBiyTYW(this, false);
		PeriodType = HistogramPeriodType.Day;
		PeriodValue = 1;
		HistogramViewType = HistogramViewType.Volume;
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_2578ed133ed94d7cbc9cc23542d314a1 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				HistogramCellViewType = HistogramCellViewType.Solid;
				HistogramGradient = true;
				HistogramShowValues = true;
				num = 8;
				break;
			case 10:
				DeltaMinusColor = Color.FromArgb(byte.MaxValue, 178, 34, 34);
				BidColor = Color.FromArgb(byte.MaxValue, 178, 34, 34);
				AskColor = ew4AnDe1XYqQYdcMpUpn(Color.FromArgb(byte.MaxValue, 70, 130, 180));
				num = 5;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_739f779654714fe286f27606d950a9d9 != 0)
				{
					num = 1;
				}
				break;
			case 6:
				MaximumColor = Color.FromArgb(byte.MaxValue, 178, 34, 34);
				CellBorderColor = ew4AnDe1XYqQYdcMpUpn(Color.FromArgb(byte.MaxValue, 127, 127, 127));
				num = 3;
				break;
			case 8:
				HistogramMinimizeValues = false;
				HistogramShowValueArea = true;
				HistogramValueAreaPercent = 70;
				num = 7;
				break;
			case 4:
				DeltaPlusColor = uHN09We1sLftZIBK3lJO(byte.MaxValue, 46, 139, 87);
				num = 8;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8c0cafc031434e41bde083ffe3129211 == 0)
				{
					num = 10;
				}
				break;
			case 7:
				HistogramExtendValueArea = false;
				num = 2;
				break;
			case 9:
				VolumeColor = uHN09We1sLftZIBK3lJO(byte.MaxValue, 70, 130, 180);
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0d19152025c94f0b9078922cd1ec6aff == 0)
				{
					num = 1;
				}
				break;
			case 2:
				HistogramShowPoc = true;
				HistogramExtendPoc = false;
				num = 9;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_2dae9e7b16644e7ca6575920d9bcb6e3 == 0)
				{
					num = 6;
				}
				break;
			case 1:
				TradesColor = uHN09We1sLftZIBK3lJO(byte.MaxValue, 70, 130, 180);
				num = 4;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_daf6cb945fbc4987a518363c06ce80c2 == 0)
				{
					num = 3;
				}
				break;
			case 3:
				TextColor = ew4AnDe1XYqQYdcMpUpn(Color.FromArgb(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue));
				return;
			case 5:
				ValueAreaColor = Color.FromArgb(byte.MaxValue, 128, 128, 128);
				num = 6;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_5d6485f66cb24fc09096e66798254c7f != 0)
				{
					num = 5;
				}
				break;
			}
		}
	}

	protected override void Execute()
	{
		int num = 10;
		IRawCluster rawCluster4 = default(IRawCluster);
		int num10 = default(int);
		IRawCluster rawCluster2 = default(IRawCluster);
		List<IRawTick>.Enumerator enumerator = default(List<IRawTick>.Enumerator);
		int num5 = default(int);
		int num6 = default(int);
		double sessionOffset = default(double);
		int num7 = default(int);
		DateTime dateTime3 = default(DateTime);
		DateTime? dateTime2 = default(DateTime?);
		int num3 = default(int);
		IRawTick current2 = default(IRawTick);
		DateTime dateTime4 = default(DateTime);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				DateTime dateTime;
				switch (num2)
				{
				case 29:
					rawCluster4 = base.DataProvider.GetRawCluster(num10);
					num2 = 31;
					continue;
				case 1:
				case 15:
					D3eie2uiSma.AddCluster(rawCluster2);
					num2 = 30;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_2768cd202ec04d099c20ba8e1925b378 != 0)
					{
						num2 = 17;
					}
					continue;
				case 2:
					num10 = eLau7ie1gcJUdhOHjkKL(base.DataProvider) - 1;
					goto case 25;
				case 16:
					if (D3eie2uiSma == null)
					{
						D3eie2uiSma = new RawCluster(DateTime.MinValue);
						num2 = 23;
						continue;
					}
					goto case 23;
				case 24:
					try
					{
						while (enumerator.MoveNext())
						{
							IRawTick current = enumerator.Current;
							int num4 = 0;
							if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_a103e6559ac3474e9e79ab00912c861c == 0)
							{
								num4 = 0;
							}
							switch (num4)
							{
							}
							D3eie2uiSma.AddTick(current, base.DataProvider.Scale);
						}
					}
					finally
					{
						((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
					}
					goto case 4;
				case 20:
				{
					IRawCluster rawCluster = base.DataProvider.GetRawCluster(base.DataProvider.Count - 1);
					if (rawCluster == null)
					{
						num2 = 13;
						continue;
					}
					dateTime = rawCluster.OpenTime;
					goto IL_092c;
				}
				case 5:
				case 30:
					num5++;
					num2 = 3;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_77d26139d1074373ba3d17cb18b3ec16 == 0)
					{
						num2 = 14;
					}
					continue;
				case 6:
					num6 = pVQixQoHit0();
					num2 = 20;
					continue;
				case 31:
				{
					int num12 = tLgixEVJYSl(XnVh4Ce16wbHDfo1fogO(rawCluster4), sessionOffset);
					if (eLEie0inyrV == num12)
					{
						num2 = 17;
						continue;
					}
					goto case 4;
				}
				case 11:
				{
					IRawCluster rawCluster5 = base.DataProvider.GetRawCluster(num7);
					if (!(rawCluster5.Time < dateTime4))
					{
						D3eie2uiSma.AddCluster(rawCluster5);
					}
					num7++;
					num2 = 3;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_4c510febac3445efbec11458d423f537 != 0)
					{
						num2 = 3;
					}
					continue;
				}
				default:
				{
					if (eLEie0inyrV != base.DataProvider.Count)
					{
						num2 = 6;
						continue;
					}
					using (List<IRawTick>.Enumerator enumerator2 = base.DataProvider.GetRawTicks().GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							IRawTick current3 = enumerator2.Current;
							vd5r3Ne1dDHAf456tFxR(D3eie2uiSma, current3, base.DataProvider.Scale);
						}
						int num11 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8bad63f401844feb8b319ab89401e7b9 == 0)
						{
							num11 = 0;
						}
						switch (num11)
						{
						case 0:
							break;
						}
					}
					goto IL_057a;
				}
				case 14:
					if (num5 < base.DataProvider.Count)
					{
						rawCluster2 = base.DataProvider.GetRawCluster(num5);
						dateTime3 = rawCluster2.Time;
						dateTime2 = StartDate;
						num2 = 21;
					}
					else
					{
						eLEie0inyrV = 1L;
						num2 = 8;
					}
					continue;
				case 9:
					w6aiLzcGKeR = new List<IndicatorLabelInfo>();
					num2 = 16;
					continue;
				case 4:
					D3eie2uiSma.UpdateData();
					return;
				case 10:
					if (w6aiLzcGKeR == null)
					{
						num = 9;
						break;
					}
					goto case 16;
				case 23:
					if (base.ClearData)
					{
						Clear();
					}
					if (PeriodType != HistogramPeriodType.CustomDate)
					{
						if (!PeriodRevers || PeriodType == HistogramPeriodType.AllBars)
						{
							sessionOffset = TimeHelper.GetSessionOffset((string)wRhMEYe1RBluCNJqMQ7B(base.DataProvider.Symbol));
							IRawCluster rawCluster3 = base.DataProvider.GetRawCluster(eLau7ie1gcJUdhOHjkKL(base.DataProvider) - 1);
							if (rawCluster3 == null)
							{
								return;
							}
							num3 = tLgixEVJYSl(rawCluster3.Time, sessionOffset);
							num2 = 27;
						}
						else
						{
							num2 = 0;
							if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_6b60de74857647159a2dc2ecd595d1bd == 0)
							{
								num2 = 0;
							}
						}
						continue;
					}
					if (eLEie0inyrV != -1)
					{
						enumerator = base.DataProvider.GetRawTicks().GetEnumerator();
						try
						{
							while (true)
							{
								int num8;
								if (!enumerator.MoveNext())
								{
									num8 = 1;
									if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e74f04d60e394f2bbc3b9757a3df6bbb == 0)
									{
										num8 = 3;
									}
									goto IL_06c7;
								}
								goto IL_078f;
								IL_07ee:
								num8 = 0;
								if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_331783b4349f408da28eb7270800e8f2 != 0)
								{
									num8 = 5;
								}
								goto IL_06c7;
								IL_06c7:
								while (true)
								{
									switch (num8)
									{
									case 5:
									{
										dateTime3 = yfVJBOe1EgWLVr5MXJqM(current2);
										int num9 = 4;
										num8 = num9;
										continue;
									}
									case 4:
										dateTime2 = EndDate;
										if (!dateTime2.HasValue || !vdrFEue1cnH1bD55fNRC(dateTime3, dateTime2.GetValueOrDefault()))
										{
											vd5r3Ne1dDHAf456tFxR(D3eie2uiSma, current2, zWZ0ZTe1Qn0fTQ5Xiynt(base.DataProvider));
											num8 = 2;
											if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_455a5cf7fae1454bbfd88da1f6361acc == 0)
											{
												num8 = 2;
											}
											continue;
										}
										break;
									case 2:
										break;
									default:
										goto IL_078f;
									case 1:
										goto IL_07ee;
									case 3:
										goto end_IL_0718;
									}
									break;
								}
								continue;
								IL_078f:
								current2 = enumerator.Current;
								dateTime3 = current2.Time;
								dateTime2 = StartDate;
								if (!dateTime2.HasValue)
								{
									num8 = 1;
									if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_849738dd5158436baf2d7aeadba27136 == 0)
									{
										num8 = 1;
									}
									goto IL_06c7;
								}
								if (TSM8VMe1jTIOFYRMIyjZ(dateTime3, dateTime2.GetValueOrDefault()))
								{
									continue;
								}
								goto IL_07ee;
								continue;
								end_IL_0718:
								break;
							}
						}
						finally
						{
							((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
						}
						goto case 8;
					}
					num2 = 6;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_d4f77fe62e8d47b39673b4a8ce5cbdc5 != 0)
					{
						num2 = 26;
					}
					continue;
				case 17:
					D3eie2uiSma.AddCluster(rawCluster4);
					num10--;
					num2 = 25;
					continue;
				case 3:
					if (num7 >= eLau7ie1gcJUdhOHjkKL(base.DataProvider))
					{
						num2 = 7;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f7a77ea7857147f9bcad1eccff0c940f != 0)
						{
							num2 = 19;
						}
						continue;
					}
					goto case 11;
				case 26:
					D3eie2uiSma = new RawCluster(DateTime.MinValue);
					num5 = 0;
					goto case 14;
				case 28:
					return;
				case 18:
					dateTime2 = EndDate;
					if (!dateTime2.HasValue)
					{
						num2 = 1;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1e4f0311079548309df28e40c8b3397b != 0)
						{
							num2 = 1;
						}
						continue;
					}
					if (!vdrFEue1cnH1bD55fNRC(dateTime3, dateTime2.GetValueOrDefault()))
					{
						goto case 1;
					}
					goto case 5;
				case 25:
					if (num10 < 0)
					{
						num2 = 4;
						continue;
					}
					goto case 29;
				case 8:
				case 22:
					D3eie2uiSma.UpdateData();
					num2 = 28;
					continue;
				case 21:
					if (!dateTime2.HasValue)
					{
						num = 12;
						break;
					}
					if (dateTime3 < dateTime2.GetValueOrDefault())
					{
						num2 = 5;
						continue;
					}
					goto case 7;
				case 7:
				case 12:
					dateTime3 = rawCluster2.Time;
					num2 = 18;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_caac71a6f9cb44c08459ac3c8bd80328 != 0)
					{
						num2 = 10;
					}
					continue;
				case 19:
					eLEie0inyrV = eLau7ie1gcJUdhOHjkKL(base.DataProvider);
					goto IL_057a;
				case 27:
					if (eLEie0inyrV != num3)
					{
						D3eie2uiSma = new RawCluster(DateTime.MinValue);
						eLEie0inyrV = num3;
						num2 = 2;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_971675a329344000b7f54dccd3fcffa2 != 0)
						{
							num2 = 2;
						}
					}
					else
					{
						enumerator = base.DataProvider.GetRawTicks().GetEnumerator();
						num2 = 24;
					}
					continue;
				case 13:
					{
						dateTime = TimeHelper.GetCurrTime(base.DataProvider.Symbol.Exchange);
						goto IL_092c;
					}
					IL_092c:
					dateTime4 = dateTime;
					dateTime4 = dateTime4.AddSeconds(-num6);
					D3eie2uiSma = new RawCluster(DateTime.MinValue);
					num7 = 0;
					goto case 3;
					IL_057a:
					D3eie2uiSma.UpdateData();
					return;
				}
				break;
			}
		}
	}

	private int tLgixEVJYSl(DateTime P_0, double P_1)
	{
		int num = 5;
		int num2 = num;
		ChartPeriodType type = default(ChartPeriodType);
		while (true)
		{
			switch (num2)
			{
			case 3:
				type = ChartPeriodType.Month;
				goto IL_00ff;
			case 2:
				goto IL_006b;
			case 6:
				goto IL_00f5;
			default:
				goto IL_00fd;
			case 1:
				goto IL_00ff;
			case 5:
				type = ChartPeriodType.Hour;
				num2 = 3;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0d19152025c94f0b9078922cd1ec6aff == 0)
				{
					num2 = 4;
				}
				break;
			case 4:
				{
					switch (PeriodType)
					{
					case HistogramPeriodType.Month:
						break;
					case HistogramPeriodType.Hour:
						type = ChartPeriodType.Hour;
						goto IL_00ff;
					case HistogramPeriodType.Day:
						goto IL_006b;
					case HistogramPeriodType.Week:
						goto IL_00d8;
					case HistogramPeriodType.Minute:
						goto IL_00f5;
					case HistogramPeriodType.AllBars:
						goto IL_00fd;
					default:
						goto IL_00ff;
					}
					goto case 3;
				}
				IL_00d8:
				type = ChartPeriodType.Week;
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_51365cbe57344dc59bfcbecc60361463 == 0)
				{
					num2 = 0;
				}
				break;
				IL_00ff:
				return ((IChartPeriod)tsypBAe1MJRtZhLhebsf(base.DataProvider)).GetSequence(type, PeriodValue, P_0, P_1);
				IL_00fd:
				return 0;
				IL_00f5:
				type = ChartPeriodType.Minute;
				goto IL_00ff;
				IL_006b:
				type = ChartPeriodType.Day;
				goto IL_00ff;
			}
		}
	}

	public int pVQixQoHit0()
	{
		switch (PeriodType)
		{
		case HistogramPeriodType.Minute:
			return PeriodValue * 60;
		case HistogramPeriodType.Hour:
			return PeriodValue * 60 * 60;
		case HistogramPeriodType.Day:
			return PeriodValue * 60 * 60 * 24;
		case HistogramPeriodType.Week:
			return PeriodValue * 60 * 60 * 24 * 7;
		case HistogramPeriodType.Month:
			return PeriodValue * 60 * 60 * 24 * 30;
		default:
		{
			int num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_be0348d4881e4572932fccb8442b1a1a != 0)
			{
				num = 0;
			}
			return num switch
			{
				_ => 0, 
			};
		}
		}
	}

	private void Clear()
	{
		eLEie0inyrV = -1L;
	}

	public override void Render(DxVisualQueue P_0)
	{
		int num = 9;
		double step = default(double);
		IChartDataProvider dataProvider = default(IChartDataProvider);
		IChartSymbol symbol = default(IChartSymbol);
		long num13 = default(long);
		long num15 = default(long);
		IRawClusterValueArea rawClusterValueArea = default(IRawClusterValueArea);
		int num17 = default(int);
		XColor xColor = default(XColor);
		IRawClusterItem rawClusterItem = default(IRawClusterItem);
		long num14 = default(long);
		IRawClusterMaxValues maxValues = default(IRawClusterMaxValues);
		long num6 = default(long);
		double num7 = default(double);
		double num5 = default(double);
		Rect rect = default(Rect);
		int num3 = default(int);
		int num4 = default(int);
		string text = default(string);
		int round = default(int);
		XFont xFont = default(XFont);
		double num8 = default(double);
		XBrush brush = default(XBrush);
		Rect rect8 = default(Rect);
		Rect rect5 = default(Rect);
		HistogramViewType histogramViewType = default(HistogramViewType);
		XBrush brush2 = default(XBrush);
		Rect rect7 = default(Rect);
		double num12 = default(double);
		int num11 = default(int);
		XBrush xBrush7 = default(XBrush);
		double num10 = default(double);
		Size size = default(Size);
		Rect rect6 = default(Rect);
		Rect rect3 = default(Rect);
		Size size2 = default(Size);
		XBrush xBrush5 = default(XBrush);
		Rect rect4 = default(Rect);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				XBrush xBrush6;
				XBrush xBrush4;
				int num9;
				XBrush xBrush3;
				switch (num2)
				{
				case 20:
					step = dataProvider.Step;
					symbol = dataProvider.Symbol;
					num2 = 2;
					continue;
				case 41:
					if (num13 - num15 > 100000)
					{
						return;
					}
					rawClusterValueArea = (HistogramShowValueArea ? D3eie2uiSma.GetValueArea(HistogramValueAreaPercent) : null);
					num13 = Math.Min(D3eie2uiSma.High, num13 + 1);
					num15 = khjy8ve1W6ykifk5YXmH(D3eie2uiSma.Low, num15 - 1);
					num17 = (int)GetY((double)num13 * step + step / 2.0);
					num2 = 5;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_6dab837cad8c4ebe913fccce41c2f99a == 0)
					{
						num2 = 10;
					}
					continue;
				case 35:
					xBrush6 = new XBrush(xColor.ChangeOpacity(-rawClusterItem.Delta, num14, base.Canvas.Theme.ChartBackColor));
					goto IL_0fad;
				case 28:
					maxValues = D3eie2uiSma.MaxValues;
					num6 = num13;
					goto case 54;
				case 18:
				{
					num7 = num5 / (double)CfieT8e1UFtW5dbmOYDm(maxValues) * (double)vpEACbe1T6YBvxs2W9uY(rawClusterItem);
					XBrush xBrush;
					if (!HistogramGradient)
					{
						xBrush = p8wiLtEVrpS;
					}
					else
					{
						xColor = VolumeColor;
						xBrush = new XBrush(xColor.ChangeOpacity(rawClusterItem.Volume, CfieT8e1UFtW5dbmOYDm(maxValues), base.Canvas.Theme.ChartBackColor));
					}
					XBrush xBrush2 = xBrush;
					Rect rect2 = new Rect(rect.Left, num3, num7, num4);
					jQfAHbe1yileZg9R82PO(P_0, xBrush2, rect2);
					text = symbol.FormatRawSize(rawClusterItem.Volume, round, HistogramMinimizeValues);
					goto case 25;
				}
				case 44:
					xFont = new XFont((string)EsOC9Te1q4n4qVg4oL22(base.Canvas.ChartFont), num8);
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_2dae9e7b16644e7ca6575920d9bcb6e3 != 0)
					{
						num2 = 1;
					}
					continue;
				case 13:
					P_0.FillRectangle(brush, rect8);
					num2 = 14;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_2768cd202ec04d099c20ba8e1925b378 != 0)
					{
						num2 = 0;
					}
					continue;
				case 15:
					num7 = num5 / (double)num14 * (double)Math.Abs(rawClusterItem.Delta);
					num2 = 6;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_5d6485f66cb24fc09096e66798254c7f == 0)
					{
						num2 = 7;
					}
					continue;
				case 5:
					num7 = 0.0;
					num2 = 53;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_ffb93a04ce4c4a8e857e2e7fd646df59 == 0)
					{
						num2 = 23;
					}
					continue;
				case 10:
					round = HistogramRoundValues;
					num2 = 28;
					continue;
				case 55:
					if (HistogramExtendPoc)
					{
						K8WFyEe1mFjZnOD4Jimt(P_0, new XPen(kSYiLAlotVw, 3), new Point(rect.Left, num3 + num4 / 2), new Point(rect.Right, num3 + num4 / 2));
						w6aiLzcGKeR.Add(new IndicatorLabelInfo((double)num6 * step, MaximumColor));
						goto case 6;
					}
					P_0.DrawLine(new XPen(kSYiLAlotVw, 3), new Point(rect.Left, num3 + num4 / 2), new Point(rect.Left + num5, num3 + num4 / 2));
					num2 = 6;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_daf6cb945fbc4987a518363c06ce80c2 == 0)
					{
						num2 = 6;
					}
					continue;
				case 8:
					if (D3eie2uiSma == null)
					{
						return;
					}
					dataProvider = base.DataProvider;
					num2 = 20;
					continue;
				case 37:
					xBrush6 = R1siLZDUmWK;
					goto IL_0fad;
				case 52:
					rect5 = new Rect(rect.Left, num3, num5, num4);
					num2 = 48;
					continue;
				case 45:
					switch (histogramViewType)
					{
					case HistogramViewType.Volume:
						break;
					default:
						goto IL_04c2;
					case HistogramViewType.Delta:
						goto IL_0732;
					case HistogramViewType.Trades:
						goto IL_0af9;
					case HistogramViewType.BidAsk:
						goto IL_0c90;
					}
					goto case 18;
				case 16:
					if (rawClusterValueArea != null)
					{
						num2 = 40;
						continue;
					}
					goto IL_0c0c;
				case 40:
					if (num6 == gi3Rmce1wdNXsZ1JB2qr(rawClusterValueArea))
					{
						num2 = 52;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_5bc14e9093324ecc8c5d7e08f50abd26 == 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto IL_0c0c;
				case 43:
				{
					XBrush xBrush8;
					if (!HistogramGradient)
					{
						xBrush8 = rRAiLTEerbg;
					}
					else
					{
						xColor = TradesColor;
						xBrush8 = new XBrush(xColor.ChangeOpacity(ikq8QJe1ZBAkYWl9Knvi(rawClusterItem), maxValues.MaxTrades, base.Canvas.Theme.ChartBackColor));
					}
					brush2 = xBrush8;
					rect7 = new Rect(rect.Left, num3, num7, num4);
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_c47f9ac95ef6414e90317ead219c477c == 0)
					{
						num2 = 0;
					}
					continue;
				}
				case 25:
				case 32:
				case 50:
					if (HistogramCellViewType == HistogramCellViewType.BorderedBars && num12 + (double)num11 > 3.0)
					{
						num = 33;
						break;
					}
					goto IL_0d3d;
				case 26:
					if (num12 > 7.0)
					{
						num2 = 31;
						continue;
					}
					goto IL_0a7e;
				case 12:
					text = symbol.FormatRawSize(rawClusterItem.Volume, round, HistogramMinimizeValues);
					goto case 25;
				case 19:
				{
					Rect rect9 = new Rect(rect.Left, num3, num7, num4);
					jQfAHbe1yileZg9R82PO(P_0, xBrush7, rect9);
					text = symbol.FormatRawSize(rawClusterItem.Delta, round, HistogramMinimizeValues);
					num2 = 25;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1a52446ff7d24524a71087c98b41bbc6 == 0)
					{
						num2 = 8;
					}
					continue;
				}
				case 39:
					rect8 = new Rect(rect.Left, num3, num10, num4);
					if (HistogramGradient)
					{
						num2 = 49;
						continue;
					}
					goto case 17;
				case 1:
					num15 = (long)(L8iafxe1IR6wXHbMQUoK(base.Canvas) / step) - 1;
					num2 = 11;
					continue;
				case 3:
					P_0.DrawString(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(--134855371 ^ 0x8092647), (XFont)GVVFLYe17UyE04SGdMUh(base.Canvas), wBdiL7H4swA, rect5.Right - size.Width, rect5.Top - size.Height - 4.0);
					goto case 42;
				default:
					P_0.FillRectangle(brush2, rect7);
					text = symbol.FormatTrades(ikq8QJe1ZBAkYWl9Knvi(rawClusterItem), round, HistogramMinimizeValues);
					num2 = 50;
					continue;
				case 36:
					goto IL_0732;
				case 34:
					if (num6 == rawClusterValueArea.Val)
					{
						num2 = 24;
						continue;
					}
					goto case 42;
				case 11:
					num13 = (long)(base.Canvas.MaxY / step) + 1;
					num2 = 41;
					continue;
				case 51:
					num12 = Math.Max(GetY(0.0) - GetY(dataProvider.Step), 1.0);
					num2 = 38;
					continue;
				case 54:
					if (num6 < num15)
					{
						return;
					}
					goto case 4;
				case 7:
					if (rawClusterItem.Delta > 0)
					{
						if (!HistogramGradient)
						{
							num2 = 37;
							if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1c1cbcfc982140d18e7033a6f2f9ec87 == 0)
							{
								num2 = 12;
							}
							continue;
						}
						xColor = DeltaPlusColor;
						xBrush6 = new XBrush(xColor.ChangeOpacity(rawClusterItem.Delta, num14, base.Canvas.Theme.ChartBackColor));
					}
					else
					{
						if (HistogramGradient)
						{
							xColor = DeltaMinusColor;
							num2 = 35;
							continue;
						}
						xBrush6 = RoqiLCKsikK;
					}
					goto IL_0fad;
				case 27:
					rawClusterItem = (IRawClusterItem)Tfqgh2e1tVOTXCOrusvh(D3eie2uiSma, num6);
					num2 = 47;
					continue;
				case 22:
					rect6 = new Rect(rect.Left, num3, num5, num4);
					num2 = 55;
					continue;
				case 6:
				{
					Size size3 = gc6hKbe1h6M0psvuB7de(base.Canvas.ChartFontBold, UcSAeSe15koJFq2pZ90F(-45476899 ^ -45441717));
					P_0.DrawString((string)UcSAeSe15koJFq2pZ90F(-371631841 ^ -371599479), base.Canvas.ChartFontBold, kSYiLAlotVw, rect6.Right - size3.Width, rect6.Top - size3.Height - 4.0);
					goto case 42;
				}
				case 38:
					num8 = Math.Min(num12 + (double)num11 - 2.0, 18.0) * 96.0 / 72.0;
					num2 = 30;
					continue;
				case 24:
					rect3 = new Rect(rect.Left, num3, num5, num4);
					if (HistogramExtendValueArea)
					{
						K8WFyEe1mFjZnOD4Jimt(P_0, new XPen(wBdiL7H4swA, 3), new Point(rect.Left, num3 + num4 / 2), new Point(rect.Right, num3 + num4 / 2));
						w6aiLzcGKeR.Add(new IndicatorLabelInfo((double)num6 * step, ValueAreaColor));
					}
					else
					{
						P_0.DrawLine(new XPen(wBdiL7H4swA, 3), new Point(rect.Left, num3 + num4 / 2), new Point(rect.Left + num5, num3 + num4 / 2));
					}
					size2 = ((XFont)GVVFLYe17UyE04SGdMUh(base.Canvas)).GetSize(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-602153869 ^ -602193691));
					num = 29;
					break;
				case 14:
					jQfAHbe1yileZg9R82PO(P_0, xBrush5, rect4);
					num2 = 12;
					continue;
				case 47:
					if (rawClusterItem != null)
					{
						num2 = 5;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_89f5b3f1a0294191b0997cd0b778a845 == 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto IL_0a7e;
				case 17:
					xBrush4 = InjiLhNBGNU;
					goto IL_1031;
				case 23:
					histogramViewType = HistogramViewType;
					num2 = 45;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9b268a4ae6bd40e28461cca24d9b841f != 0)
					{
						num2 = 19;
					}
					continue;
				case 33:
					P_0.DrawRectangle(YFmiLFwLsnQ, new Rect(rect.Left - 1.0, num3, num7, num4 - 1));
					goto IL_0d3d;
				case 31:
					if (num3 > 15)
					{
						TYXHs8e18kc1AlsumnbV(P_0, text, xFont, b65iLp5uhrs, new Rect(rect.Left + 2.0, num3, num5, num4), XTextAlignment.Left);
					}
					goto IL_0a7e;
				case 21:
					goto IL_0c90;
				case 2:
					rect = base.Canvas.Rect;
					num2 = 28;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_343b2874cf5f4ef7b098544546ed76b2 == 0)
					{
						num2 = 46;
					}
					continue;
				case 4:
				{
					int num16 = (int)GetY((double)num6 * step - step / 2.0);
					num4 = Math.Max(num16 - num17 + num11, 1);
					num3 = num17;
					num17 = num16;
					num2 = 27;
					continue;
				}
				case 49:
					xColor = AskColor;
					xBrush4 = new XBrush(xColor.ChangeOpacity(rawClusterItem.Ask, khjy8ve1W6ykifk5YXmH(maxValues.MaxBid, tH9Jwqe1rXEl3a7FhfUo(maxValues)), base.Canvas.Theme.ChartBackColor));
					goto IL_1031;
				case 46:
					num5 = rect.Width * 0.2;
					if (HistogramCellViewType != HistogramCellViewType.Bars)
					{
						num2 = 56;
						continue;
					}
					goto IL_0eef;
				case 42:
					if (HistogramShowValues)
					{
						num2 = 26;
						continue;
					}
					goto IL_0a7e;
				case 29:
					P_0.DrawString(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1153206687 ^ -1153176841), (XFont)GVVFLYe17UyE04SGdMUh(base.Canvas), wBdiL7H4swA, rect3.Right - size2.Width, rect3.Top - size2.Height - 4.0);
					num2 = 28;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_2dae9e7b16644e7ca6575920d9bcb6e3 != 0)
					{
						num2 = 42;
					}
					continue;
				case 56:
					if (HistogramCellViewType == HistogramCellViewType.BorderedBars)
					{
						goto IL_0eef;
					}
					num9 = 0;
					goto IL_0ef0;
				case 53:
					text = "";
					num2 = 23;
					continue;
				case 30:
					num8 = idlndGe1OucrmLa01ial(num8, base.Canvas.ChartFont.Size);
					num2 = 2;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_35044ecf03034683aa5038f38795ec31 == 0)
					{
						num2 = 44;
					}
					continue;
				case 48:
					if (!HistogramExtendValueArea)
					{
						P_0.DrawLine(new XPen(wBdiL7H4swA, 3), new Point(rect.Left, num3 + num4 / 2), new Point(rect.Left + num5, num3 + num4 / 2));
					}
					else
					{
						P_0.DrawLine(new XPen(wBdiL7H4swA, 3), new Point(rect.Left, num3 + num4 / 2), new Point(rect.Right, num3 + num4 / 2));
						w6aiLzcGKeR.Add(new IndicatorLabelInfo((double)num6 * step, ValueAreaColor));
					}
					size = base.Canvas.ChartFontBold.GetSize(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1763895751 ^ -1763865931));
					num2 = 3;
					continue;
				case 9:
					{
						w6aiLzcGKeR.Clear();
						num2 = 8;
						continue;
					}
					IL_0c0c:
					if (rawClusterValueArea != null)
					{
						num2 = 34;
						continue;
					}
					goto case 42;
					IL_0a7e:
					num6--;
					num2 = 54;
					continue;
					IL_0c90:
					num7 = num5 / (double)maxValues.MaxVolume * (double)rawClusterItem.Volume;
					num10 = num7 / (double)rawClusterItem.Volume * (double)rawClusterItem.Bid;
					if (!HistogramGradient)
					{
						xBrush3 = ksviLKC00Yu;
					}
					else
					{
						xColor = BidColor;
						xBrush3 = new XBrush(xColor.ChangeOpacity(rawClusterItem.Bid, Math.Max(maxValues.MaxBid, maxValues.MaxAsk), ((IChartTheme)uiblXWe1Cxin0eys6Cf8(base.Canvas)).ChartBackColor));
					}
					brush = xBrush3;
					num2 = 39;
					continue;
					IL_0eef:
					num9 = -1;
					goto IL_0ef0;
					IL_0ef0:
					num11 = num9;
					num2 = 34;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0450b8b54d9e402da4e2f9dc872984ee != 0)
					{
						num2 = 51;
					}
					continue;
					IL_0af9:
					num7 = num5 / (double)maxValues.MaxTrades * (double)rawClusterItem.Trades;
					num2 = 43;
					continue;
					IL_0732:
					num14 = khjy8ve1W6ykifk5YXmH(maxValues.MaxDelta, -D56Ogre1V36LAOVxxgbL(maxValues));
					num2 = 15;
					continue;
					IL_04c2:
					num2 = 32;
					continue;
					IL_0d3d:
					if (num6 == cNcWBLe1KKTmvi3DRyLA(maxValues) && HistogramShowPoc)
					{
						num2 = 22;
						continue;
					}
					goto case 16;
					IL_1031:
					xBrush5 = xBrush4;
					rect4 = new Rect(rect.Left + num10, num3, num7 - num10, num4);
					num2 = 13;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_b6f1ae5199084abc84c46b275feb4dfd == 0)
					{
						num2 = 12;
					}
					continue;
					IL_0fad:
					xBrush7 = xBrush6;
					num2 = 19;
					continue;
				}
				break;
			}
		}
	}

	public override void GetLabels(ref List<IndicatorLabelInfo> P_0)
	{
		P_0.AddRange(w6aiLzcGKeR);
	}

	public override void CopyTemplate(IndicatorBase P_0, bool P_1)
	{
		int num = 8;
		kYtP6Tixcn838Vsnv2ea kYtP6Tixcn838Vsnv2ea2 = default(kYtP6Tixcn838Vsnv2ea);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 12:
					PeriodValue = pFLAn5e1AwXv2qX3W6qe(kYtP6Tixcn838Vsnv2ea2);
					num = 4;
					break;
				case 5:
					TextColor = kYtP6Tixcn838Vsnv2ea2.TextColor;
					base.CopyTemplate(P_0, P_1);
					return;
				case 10:
					BidColor = kYtP6Tixcn838Vsnv2ea2.BidColor;
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_84ff815db08e468bb177d195221f5fb1 != 0)
					{
						num2 = 1;
					}
					continue;
				case 7:
					PeriodType = kYtP6Tixcn838Vsnv2ea2.PeriodType;
					num2 = 12;
					continue;
				case 8:
					kYtP6Tixcn838Vsnv2ea2 = (kYtP6Tixcn838Vsnv2ea)P_0;
					num = 7;
					break;
				case 1:
					AskColor = kYtP6Tixcn838Vsnv2ea2.AskColor;
					ValueAreaColor = kYtP6Tixcn838Vsnv2ea2.ValueAreaColor;
					num2 = 11;
					continue;
				case 2:
					HistogramGradient = kYtP6Tixcn838Vsnv2ea2.HistogramGradient;
					HistogramShowValues = r48B9Xe1FhE1rauOQGeK(kYtP6Tixcn838Vsnv2ea2);
					HistogramMinimizeValues = Ye9lwte13AVLUKYmpeaC(kYtP6Tixcn838Vsnv2ea2);
					HistogramShowValueArea = kYtP6Tixcn838Vsnv2ea2.HistogramShowValueArea;
					HistogramExtendValueArea = aktoBue1pRpFKn6qvHaf(kYtP6Tixcn838Vsnv2ea2);
					HistogramValueAreaPercent = SaMBjge1uBTktyvFxW3Y(kYtP6Tixcn838Vsnv2ea2);
					HistogramShowPoc = kYtP6Tixcn838Vsnv2ea2.HistogramShowPoc;
					HistogramExtendPoc = EqLNPle1z34mYultbW98(kYtP6Tixcn838Vsnv2ea2);
					num2 = 6;
					continue;
				case 9:
					DeltaPlusColor = kYtP6Tixcn838Vsnv2ea2.DeltaPlusColor;
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_c0837a76d79b485ab2d4c68f864e6ad9 != 0)
					{
						num2 = 0;
					}
					continue;
				case 6:
					m5Eix84b9h5.Copy(kYtP6Tixcn838Vsnv2ea2.m5Eix84b9h5);
					VolumeColor = kYtP6Tixcn838Vsnv2ea2.VolumeColor;
					TradesColor = aL27WFe50On9fvgvs5OK(kYtP6Tixcn838Vsnv2ea2);
					num2 = 9;
					continue;
				case 4:
					PeriodRevers = kYtP6Tixcn838Vsnv2ea2.PeriodRevers;
					StartDate = kYtP6Tixcn838Vsnv2ea2.StartDate;
					EndDate = kYtP6Tixcn838Vsnv2ea2.EndDate;
					num2 = 3;
					continue;
				default:
					DeltaMinusColor = kYtP6Tixcn838Vsnv2ea2.DeltaMinusColor;
					num2 = 10;
					continue;
				case 3:
					HistogramViewType = XpI3xQe1PHvnQuBnt15a(kYtP6Tixcn838Vsnv2ea2);
					HistogramCellViewType = pZGODOe1JH4F1mNSLqKw(kYtP6Tixcn838Vsnv2ea2);
					num2 = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_5bc14e9093324ecc8c5d7e08f50abd26 != 0)
					{
						num2 = 2;
					}
					continue;
				case 11:
					MaximumColor = kYtP6Tixcn838Vsnv2ea2.MaximumColor;
					CellBorderColor = kYtP6Tixcn838Vsnv2ea2.CellBorderColor;
					num2 = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_feff692887f143cf88657f0c72ada1e9 == 0)
					{
						num2 = 5;
					}
					continue;
				}
				break;
			}
		}
	}

	public override bool GetPropertyVisibility(string P_0)
	{
		if (!(P_0 == (string)UcSAeSe15koJFq2pZ90F(0x34407BB ^ 0x3449D9D)) && !(P_0 == yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-45476899 ^ -45446687)))
		{
			int num;
			if (!MNhJFce5265OseIFYtiA(P_0, yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1522697859 ^ -1522671521)))
			{
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9a8381dfafdf4cd0bdbdde184d2abaf1 == 0)
				{
					num = 0;
				}
			}
			else
			{
				if (PeriodType == HistogramPeriodType.CustomDate)
				{
					return false;
				}
				num = 2;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					return PeriodType != HistogramPeriodType.AllBars;
				case 2:
					return PeriodType != HistogramPeriodType.AllBars;
				}
				if (!(P_0 == (string)UcSAeSe15koJFq2pZ90F(-1346994499 ^ -1346968393)))
				{
					return base.GetPropertyVisibility(P_0);
				}
				if (PeriodType == HistogramPeriodType.CustomDate)
				{
					return false;
				}
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_331783b4349f408da28eb7270800e8f2 != 0)
				{
					num = 1;
				}
			}
		}
		return PeriodType == HistogramPeriodType.CustomDate;
	}

	static kYtP6Tixcn838Vsnv2ea()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static object UcSAeSe15koJFq2pZ90F(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static bool MP7olwe1kTP3f4yRBHQj()
	{
		return qNt64ie1N4x5FbybCi5a == null;
	}

	internal static kYtP6Tixcn838Vsnv2ea xFLZOke11tAnh9Lnrjtu()
	{
		return qNt64ie1N4x5FbybCi5a;
	}

	internal static int d8GNMDe1SZxGvV1Mlchl(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static bool jHL4Bce1xDLT7yKNXwmB(XColor P_0, XColor P_1)
	{
		return P_0 == P_1;
	}

	internal static void xiZm9ye1LaEEw2Tk85eP()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
	}

	internal static void UpVAkhe1eihELJBiyTYW(object P_0, bool value)
	{
		((IndicatorBase)P_0).ShowIndicatorTitle = value;
	}

	internal static Color uHN09We1sLftZIBK3lJO(byte P_0, byte P_1, byte P_2, byte P_3)
	{
		return Color.FromArgb(P_0, P_1, P_2, P_3);
	}

	internal static XColor ew4AnDe1XYqQYdcMpUpn(Color P_0)
	{
		return P_0;
	}

	internal static bool vdrFEue1cnH1bD55fNRC(DateTime P_0, DateTime P_1)
	{
		return P_0 > P_1;
	}

	internal static bool TSM8VMe1jTIOFYRMIyjZ(DateTime P_0, DateTime P_1)
	{
		return P_0 < P_1;
	}

	internal static DateTime yfVJBOe1EgWLVr5MXJqM(object P_0)
	{
		return ((IRawTick)P_0).Time;
	}

	internal static int zWZ0ZTe1Qn0fTQ5Xiynt(object P_0)
	{
		return ((IChartDataProvider)P_0).Scale;
	}

	internal static void vd5r3Ne1dDHAf456tFxR(object P_0, object P_1, int scale)
	{
		((RawCluster)P_0).AddTick((IRawTick)P_1, scale);
	}

	internal static int eLau7ie1gcJUdhOHjkKL(object P_0)
	{
		return ((IChartDataProvider)P_0).Count;
	}

	internal static object wRhMEYe1RBluCNJqMQ7B(object P_0)
	{
		return ((IChartSymbol)P_0).Exchange;
	}

	internal static DateTime XnVh4Ce16wbHDfo1fogO(object P_0)
	{
		return ((IRawCluster)P_0).Time;
	}

	internal static object tsypBAe1MJRtZhLhebsf(object P_0)
	{
		return ((IChartDataProvider)P_0).Period;
	}

	internal static double idlndGe1OucrmLa01ial(double P_0, double P_1)
	{
		return Math.Min(P_0, P_1);
	}

	internal static object EsOC9Te1q4n4qVg4oL22(object P_0)
	{
		return ((XFont)P_0).Name;
	}

	internal static double L8iafxe1IR6wXHbMQUoK(object P_0)
	{
		return ((IChartCanvas)P_0).MinY;
	}

	internal static long khjy8ve1W6ykifk5YXmH(long P_0, long P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static object Tfqgh2e1tVOTXCOrusvh(object P_0, long price)
	{
		return ((RawCluster)P_0).GetItem(price);
	}

	internal static long CfieT8e1UFtW5dbmOYDm(object P_0)
	{
		return ((IRawClusterMaxValues)P_0).MaxVolume;
	}

	internal static long vpEACbe1T6YBvxs2W9uY(object P_0)
	{
		return ((IRawClusterItem)P_0).Volume;
	}

	internal static void jQfAHbe1yileZg9R82PO(object P_0, object P_1, Rect P_2)
	{
		((DxVisualQueue)P_0).FillRectangle((XBrush)P_1, P_2);
	}

	internal static int ikq8QJe1ZBAkYWl9Knvi(object P_0)
	{
		return ((IRawClusterItem)P_0).Trades;
	}

	internal static long D56Ogre1V36LAOVxxgbL(object P_0)
	{
		return ((IRawClusterMaxValues)P_0).MinDelta;
	}

	internal static object uiblXWe1Cxin0eys6Cf8(object P_0)
	{
		return ((IChartCanvas)P_0).Theme;
	}

	internal static long tH9Jwqe1rXEl3a7FhfUo(object P_0)
	{
		return ((IRawClusterMaxValues)P_0).MaxAsk;
	}

	internal static long cNcWBLe1KKTmvi3DRyLA(object P_0)
	{
		return ((IRawClusterMaxValues)P_0).Poc;
	}

	internal static void K8WFyEe1mFjZnOD4Jimt(object P_0, object P_1, Point P_2, Point P_3)
	{
		((DxVisualQueue)P_0).DrawLine((XPen)P_1, P_2, P_3);
	}

	internal static Size gc6hKbe1h6M0psvuB7de(object P_0, object P_1)
	{
		return ((XFont)P_0).GetSize((string)P_1);
	}

	internal static long gi3Rmce1wdNXsZ1JB2qr(object P_0)
	{
		return ((IRawClusterValueArea)P_0).Vah;
	}

	internal static object GVVFLYe17UyE04SGdMUh(object P_0)
	{
		return ((IChartCanvas)P_0).ChartFontBold;
	}

	internal static void TYXHs8e18kc1AlsumnbV(object P_0, object P_1, object P_2, object P_3, Rect P_4, XTextAlignment P_5)
	{
		((DxVisualQueue)P_0).DrawString((string)P_1, (XFont)P_2, (XBrush)P_3, P_4, P_5);
	}

	internal static int pFLAn5e1AwXv2qX3W6qe(object P_0)
	{
		return ((kYtP6Tixcn838Vsnv2ea)P_0).PeriodValue;
	}

	internal static HistogramViewType XpI3xQe1PHvnQuBnt15a(object P_0)
	{
		return ((kYtP6Tixcn838Vsnv2ea)P_0).HistogramViewType;
	}

	internal static HistogramCellViewType pZGODOe1JH4F1mNSLqKw(object P_0)
	{
		return ((kYtP6Tixcn838Vsnv2ea)P_0).HistogramCellViewType;
	}

	internal static bool r48B9Xe1FhE1rauOQGeK(object P_0)
	{
		return ((kYtP6Tixcn838Vsnv2ea)P_0).HistogramShowValues;
	}

	internal static bool Ye9lwte13AVLUKYmpeaC(object P_0)
	{
		return ((kYtP6Tixcn838Vsnv2ea)P_0).HistogramMinimizeValues;
	}

	internal static bool aktoBue1pRpFKn6qvHaf(object P_0)
	{
		return ((kYtP6Tixcn838Vsnv2ea)P_0).HistogramExtendValueArea;
	}

	internal static int SaMBjge1uBTktyvFxW3Y(object P_0)
	{
		return ((kYtP6Tixcn838Vsnv2ea)P_0).HistogramValueAreaPercent;
	}

	internal static bool EqLNPle1z34mYultbW98(object P_0)
	{
		return ((kYtP6Tixcn838Vsnv2ea)P_0).HistogramExtendPoc;
	}

	internal static XColor aL27WFe50On9fvgvs5OK(object P_0)
	{
		return ((kYtP6Tixcn838Vsnv2ea)P_0).TradesColor;
	}

	internal static bool MNhJFce5265OseIFYtiA(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}
}
