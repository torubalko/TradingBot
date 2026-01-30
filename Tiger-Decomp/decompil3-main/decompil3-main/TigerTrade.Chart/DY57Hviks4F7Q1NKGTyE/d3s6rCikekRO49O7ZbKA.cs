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
using TigerTrade.Chart.Indicators.List;
using TigerTrade.Chart.Properties;
using TigerTrade.Dx;

namespace DY57Hviks4F7Q1NKGTyE;

[DataContract(Name = "DeltaIndicator", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
[Indicator("Delta", "Delta", false, Type = typeof(d3s6rCikekRO49O7ZbKA))]
internal sealed class d3s6rCikekRO49O7ZbKA : IndicatorBase
{
	private XBrush IOai1sUJ4IS;

	private XPen zw1i1XcskuA;

	private XColor UQDi1cOh325;

	private XBrush kWqi1jT2D6D;

	private XPen WB3i1E4RR1w;

	private XColor iTMi1QWdUCy;

	private DeltaViewType DBMi1dAR5gt;

	private bool bd1i1g2v6gK;

	private IndicatorNullIntParam IKMi1RxSjD5;

	private IndicatorNullIntParam moQi16h8kIt;

	private IndicatorNullIntParam WHUi1MTDZne;

	private XBrush ywZi1OCVCiO;

	private XPen mWVi1qCJChI;

	private XColor V9bi1IPLVMY;

	private XBrush Aoai1WGjIIH;

	private XPen aQSi1tCNwHP;

	private XColor MDvi1U4rYfa;

	private ChartAlertSettings TjNi1TGS2UR;

	private IndicatorNullIntParam YKji1yKeaqK;

	private IndicatorNullIntParam chRi1ZUMUau;

	private XBrush qGKi1VHjKUC;

	private XPen mBKi1C4GVSN;

	private XColor UrAi1rKK48H;

	private XBrush qY9i1KLpH2v;

	private XPen thmi1mUNOUi;

	private XColor tf3i1hu7JWX;

	private ChartAlertSettings Gqfi1wcVgjA;

	private IndicatorNullIntParam pDJi17PlHmI;

	private IndicatorNullIntParam H5Ei18KQclQ;

	private XBrush Da6i1ACsUEf;

	private XPen Xmui1PWTrPr;

	private XColor AFOi1JiP61K;

	private XBrush PhWi1F1AyEK;

	private XPen MmRi13jJWXf;

	private XColor Napi1piUGXD;

	private ChartAlertSettings vNUi1uucfH9;

	private int U0mi1zhi616;

	private int rhKi50kyUW3;

	private int hjii52jWuyS;

	private static d3s6rCikekRO49O7ZbKA mrsZGdebrcF4V744xGbC;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.Bar;

	[DataMember(Name = "DeltaPlusColor")]
	[DisplayName("Delta+")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsStyle")]
	public XColor DeltaPlusColor
	{
		get
		{
			return UQDi1cOh325;
		}
		set
		{
			if (xColor == UQDi1cOh325)
			{
				return;
			}
			UQDi1cOh325 = xColor;
			int num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_24c9cc26b2134967befd52549b065ea0 == 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					zw1i1XcskuA = new XPen(IOai1sUJ4IS, 1);
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1583344314 ^ -1583316492));
					return;
				}
				IOai1sUJ4IS = new XBrush(UQDi1cOh325);
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1e4f0311079548309df28e40c8b3397b != 0)
				{
					num = 1;
				}
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsStyle")]
	[DisplayName("Delta-")]
	[DataMember(Name = "DeltaMinusColor")]
	public XColor DeltaMinusColor
	{
		get
		{
			return iTMi1QWdUCy;
		}
		set
		{
			if (xColor == iTMi1QWdUCy)
			{
				return;
			}
			iTMi1QWdUCy = xColor;
			kWqi1jT2D6D = new XBrush(iTMi1QWdUCy);
			WB3i1E4RR1w = new XPen(kWqi1jT2D6D, 1);
			int num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9b268a4ae6bd40e28461cca24d9b841f != 0)
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
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x78D396D8 ^ 0x78D3020A));
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_b35db2c0f4de46efa9eb8ca63c778728 == 0)
				{
					num = 1;
				}
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[DefaultValue(DeltaViewType.Columns)]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsType")]
	[DataMember(Name = "DeltaType")]
	public DeltaViewType Type
	{
		get
		{
			return DBMi1dAR5gt;
		}
		set
		{
			if (deltaViewType != DBMi1dAR5gt)
			{
				DBMi1dAR5gt = deltaViewType;
				OnPropertyChanged((string)GTtmPEebhlsEnTx9lSfE(0x68C7EAE6 ^ 0x68C77BFE));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8bad63f401844feb8b319ab89401e7b9 == 0)
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

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsMinimize")]
	[DataMember(Name = "Minimize")]
	[DefaultValue(false)]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	public bool Minimize
	{
		get
		{
			return bd1i1g2v6gK;
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
					if (flag != bd1i1g2v6gK)
					{
						bd1i1g2v6gK = flag;
						OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x1AB79299 ^ 0x1AB7066D));
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bf5c5dff42eb4dbcb67f23c8a54dc750 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DataMember(Name = "MaxDeltaParam")]
	public IndicatorNullIntParam jY6ikOQFiCw
	{
		get
		{
			return IKMi1RxSjD5 ?? (IKMi1RxSjD5 = new IndicatorNullIntParam(null));
		}
		set
		{
			IKMi1RxSjD5 = iKMi1RxSjD;
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[DefaultValue(null)]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsMaxDelta")]
	public int? MaxDelta
	{
		get
		{
			return jY6ikOQFiCw.Get(base.SettingsLongKey);
		}
		set
		{
			if (jY6ikOQFiCw.Set(base.SettingsLongKey, value2, 0))
			{
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-2056710528 ^ -2056682616));
			}
		}
	}

	[DataMember(Name = "Filter1MinParam")]
	public IndicatorNullIntParam TH6ikU3lXPS
	{
		get
		{
			return moQi16h8kIt ?? (moQi16h8kIt = new IndicatorNullIntParam(null));
		}
		set
		{
			moQi16h8kIt = indicatorNullIntParam;
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsMinimum")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsFilter1")]
	[DefaultValue(null)]
	public int? Filter1Min
	{
		get
		{
			return TH6ikU3lXPS.Get(base.SettingsLongKey);
		}
		set
		{
			if (TH6ikU3lXPS.Set(base.SettingsLongKey, value2, 0))
			{
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-60853733 ^ -60823801));
			}
		}
	}

	[DataMember(Name = "Filter1MaxParam")]
	public IndicatorNullIntParam Xa2ikCtOKau
	{
		get
		{
			return WHUi1MTDZne ?? (WHUi1MTDZne = new IndicatorNullIntParam(null));
		}
		set
		{
			WHUi1MTDZne = wHUi1MTDZne;
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsFilter1")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsMaximum")]
	[DefaultValue(null)]
	public int? Filter1Max
	{
		get
		{
			return Xa2ikCtOKau.Get(base.SettingsLongKey);
		}
		set
		{
			if (Xa2ikCtOKau.Set(base.SettingsLongKey, value2, 0))
			{
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1736566656 ^ -1736536652));
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsColorPlus")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsFilter1")]
	[DataMember(Name = "Filter1PlusColor")]
	public XColor Filter1PlusColor
	{
		get
		{
			return V9bi1IPLVMY;
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
					return;
				case 2:
					if (!(xColor == V9bi1IPLVMY))
					{
						V9bi1IPLVMY = xColor;
						ywZi1OCVCiO = new XBrush(V9bi1IPLVMY);
						mWVi1qCJChI = new XPen(ywZi1OCVCiO, 1);
						OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-44540535 ^ -44513083));
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0b86e69c2a884980a2238f7088b49732 == 0)
						{
							num2 = 0;
						}
					}
					else
					{
						num2 = 1;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_fbc3ce86e86648d0ab473d06282ebe5e != 0)
						{
							num2 = 0;
						}
					}
					break;
				}
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsColorMinus")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsFilter1")]
	[DataMember(Name = "Filter1MinusColor")]
	public XColor Filter1MinusColor
	{
		get
		{
			return MDvi1U4rYfa;
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return;
				default:
					MDvi1U4rYfa = xColor;
					Aoai1WGjIIH = new XBrush(MDvi1U4rYfa);
					aQSi1tCNwHP = new XPen(Aoai1WGjIIH, 1);
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x4297C3EB ^ 0x4297569B));
					return;
				case 1:
					if (W6VLOLebwsNMrXQdoCk4(xColor, MDvi1U4rYfa))
					{
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_7618de9239454b7793ef28219529e5f8 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DataMember(Name = "Filter1Alert")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsAlert")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsFilter1")]
	public ChartAlertSettings Filter1Alert
	{
		get
		{
			return TjNi1TGS2UR ?? (TjNi1TGS2UR = new ChartAlertSettings());
		}
		set
		{
			if (!raiHENeb7smLmwXsW1AO(chartAlertSettings, TjNi1TGS2UR))
			{
				TjNi1TGS2UR = chartAlertSettings;
				OnPropertyChanged((string)GTtmPEebhlsEnTx9lSfE(-1192989954 ^ -1192951960));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8df0e84d43a842eca742d74a9772b346 != 0)
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

	[DataMember(Name = "Filter2MinParam")]
	public IndicatorNullIntParam wXdikFNSCKD
	{
		get
		{
			return YKji1yKeaqK ?? (YKji1yKeaqK = new IndicatorNullIntParam(null));
		}
		set
		{
			YKji1yKeaqK = yKji1yKeaqK;
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsMinimum")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsFilter2")]
	[DefaultValue(null)]
	public int? Filter2Min
	{
		get
		{
			return wXdikFNSCKD.Get(base.SettingsLongKey);
		}
		set
		{
			if (wXdikFNSCKD.Set(base.SettingsLongKey, value2, 0))
			{
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-342738082 ^ -342708500));
			}
		}
	}

	[DataMember(Name = "Filter2MaxParam")]
	public IndicatorNullIntParam fKXi10cpObe
	{
		get
		{
			return chRi1ZUMUau ?? (chRi1ZUMUau = new IndicatorNullIntParam(null));
		}
		set
		{
			chRi1ZUMUau = indicatorNullIntParam;
		}
	}

	[DefaultValue(null)]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsFilter2")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsMaximum")]
	public int? Filter2Max
	{
		get
		{
			return fKXi10cpObe.Get(base.SettingsLongKey);
		}
		set
		{
			if (fKXi10cpObe.Set(base.SettingsLongKey, value2, 0))
			{
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1848952786 ^ -1848922652));
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsColorPlus")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsFilter2")]
	[DataMember(Name = "Filter2PlusColor")]
	public XColor Filter2PlusColor
	{
		get
		{
			return UrAi1rKK48H;
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return;
				default:
					UrAi1rKK48H = xColor;
					qGKi1VHjKUC = new XBrush(UrAi1rKK48H);
					mBKi1C4GVSN = new XPen(qGKi1VHjKUC, 1);
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1774602229 ^ -1774637591));
					return;
				case 1:
					if (xColor == UrAi1rKK48H)
					{
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1e4f0311079548309df28e40c8b3397b != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsColorMinus")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsFilter2")]
	[DataMember(Name = "Filter2MinusColor")]
	public XColor Filter2MinusColor
	{
		get
		{
			return tf3i1hu7JWX;
		}
		set
		{
			if (W6VLOLebwsNMrXQdoCk4(xColor, tf3i1hu7JWX))
			{
				return;
			}
			tf3i1hu7JWX = xColor;
			qY9i1KLpH2v = new XBrush(tf3i1hu7JWX);
			int num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_be0348d4881e4572932fccb8442b1a1a == 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					OnPropertyChanged((string)GTtmPEebhlsEnTx9lSfE(-962524685 ^ -962486283));
					return;
				}
				thmi1mUNOUi = new XPen(qY9i1KLpH2v, 1);
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_343b2874cf5f4ef7b098544546ed76b2 != 0)
				{
					num = 0;
				}
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsAlert")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsFilter2")]
	[DataMember(Name = "Filter2Alert")]
	public ChartAlertSettings Filter2Alert
	{
		get
		{
			return Gqfi1wcVgjA ?? (Gqfi1wcVgjA = new ChartAlertSettings());
		}
		set
		{
			if (!raiHENeb7smLmwXsW1AO(chartAlertSettings, Gqfi1wcVgjA))
			{
				Gqfi1wcVgjA = chartAlertSettings;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x5EA8FF2A ^ 0x5EA86906));
			}
		}
	}

	[DataMember(Name = "Filter3MinParam")]
	public IndicatorNullIntParam U3Ri1axrSAX
	{
		get
		{
			return pDJi17PlHmI ?? (pDJi17PlHmI = new IndicatorNullIntParam(null));
		}
		set
		{
			pDJi17PlHmI = indicatorNullIntParam;
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsMinimum")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsFilter3")]
	[DefaultValue(null)]
	public int? Filter3Min
	{
		get
		{
			return U3Ri1axrSAX.Get(base.SettingsLongKey);
		}
		set
		{
			if (U3Ri1axrSAX.Set(base.SettingsLongKey, value2, 0))
			{
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x3E0426F0 ^ 0x3E04B0B8));
			}
		}
	}

	[DataMember(Name = "Filter3MaxParam")]
	public IndicatorNullIntParam rBii1b1UoTR
	{
		get
		{
			return H5Ei18KQclQ ?? (H5Ei18KQclQ = new IndicatorNullIntParam(null));
		}
		set
		{
			H5Ei18KQclQ = h5Ei18KQclQ;
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsMaximum")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsFilter3")]
	[DefaultValue(null)]
	public int? Filter3Max
	{
		get
		{
			return rBii1b1UoTR.Get(base.SettingsLongKey);
		}
		set
		{
			if (rBii1b1UoTR.Set(base.SettingsLongKey, value2, 0))
			{
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x2BD86B18 ^ 0x2BD8FD78));
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsFilter3")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsColorPlus")]
	[DataMember(Name = "Filter3PlusColor")]
	public XColor Filter3PlusColor
	{
		get
		{
			return AFOi1JiP61K;
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
					if (xColor == AFOi1JiP61K)
					{
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_db78327036c6481694d84ff5ec56fd0d == 0)
						{
							num2 = 0;
						}
						break;
					}
					AFOi1JiP61K = xColor;
					Da6i1ACsUEf = new XBrush(AFOi1JiP61K);
					Xmui1PWTrPr = new XPen(Da6i1ACsUEf, 1);
					OnPropertyChanged((string)GTtmPEebhlsEnTx9lSfE(-82860344 ^ -82890576));
					num2 = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_7e45d53bf40748f9915553e145413be0 == 0)
					{
						num2 = 2;
					}
					break;
				case 2:
					return;
				case 0:
					return;
				}
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsFilter3")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsColorMinus")]
	[DataMember(Name = "Filter3MinusColor")]
	public XColor Filter3MinusColor
	{
		get
		{
			return Napi1piUGXD;
		}
		set
		{
			if (xColor == Napi1piUGXD)
			{
				return;
			}
			Napi1piUGXD = xColor;
			int num = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_343b2874cf5f4ef7b098544546ed76b2 != 0)
			{
				num = 1;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					PhWi1F1AyEK = new XBrush(Napi1piUGXD);
					num = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3ef08b277e78467b833a3119d7297528 != 0)
					{
						num = 0;
					}
					break;
				default:
					MmRi13jJWXf = new XPen(PhWi1F1AyEK, 1);
					OnPropertyChanged((string)GTtmPEebhlsEnTx9lSfE(-203064540 ^ -203035208));
					return;
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
			return vNUi1uucfH9 ?? (vNUi1uucfH9 = new ChartAlertSettings());
		}
		set
		{
			if (!object.Equals(objA, vNUi1uucfH9))
			{
				vNUi1uucfH9 = objA;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9f8132c088e4447e83ec74ef15b8e944 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged((string)GTtmPEebhlsEnTx9lSfE(--927068468 ^ 0x374167F6));
			}
		}
	}

	[Browsable(false)]
	public override IndicatorCalculation Calculation => IndicatorCalculation.OnEachTick;

	public override bool IntegerValues => true;

	public d3s6rCikekRO49O7ZbKA()
	{
		b26nbseb83CjglNFeHE4();
		base._002Ector();
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
				Filter2PlusColor = Colors.Orange;
				Filter2MinusColor = Colors.Orange;
				num = 4;
				break;
			case 1:
				DeltaPlusColor = h408oDebAg8mh4a6LJtq(byte.MaxValue, 30, 144, byte.MaxValue);
				DeltaMinusColor = naDTSTebPQ3EPgRc8HMv(Color.FromArgb(byte.MaxValue, 178, 34, 34));
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_21e32bb06909412aa85d75d125f55184 == 0)
				{
					num = 2;
				}
				break;
			case 5:
				Filter1PlusColor = naDTSTebPQ3EPgRc8HMv(Colors.Orange);
				Filter1MinusColor = lZiHbZebJt14d6SU9Die();
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_842fd993a2b5414bb5dea11b59e24eb1 == 0)
				{
					num = 0;
				}
				break;
			case 2:
				Type = DeltaViewType.Columns;
				Minimize = false;
				num = 5;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_a0f7dd9205eb40fbb542085b90a19faa == 0)
				{
					num = 4;
				}
				break;
			case 3:
				return;
			case 4:
				Filter3PlusColor = Colors.Orange;
				Filter3MinusColor = naDTSTebPQ3EPgRc8HMv(lZiHbZebJt14d6SU9Die());
				U0mi1zhi616 = -1;
				rhKi50kyUW3 = -1;
				hjii52jWuyS = -1;
				num = 3;
				break;
			}
		}
	}

	protected override void Execute()
	{
		int num = 2;
		int num2 = num;
		decimal num5 = default(decimal);
		int num13 = default(int);
		int num6 = default(int);
		int? num4 = default(int?);
		decimal num10 = default(decimal);
		int num9 = default(int);
		int num8 = default(int);
		int num14 = default(int);
		int num16 = default(int);
		while (true)
		{
			int num12;
			int num7;
			int num11;
			int num3;
			IChartCluster cluster;
			int num15;
			switch (num2)
			{
			default:
				if (!(num5 <= c16GE0ebpjNohbwxTLX6(num13)))
				{
					num2 = 23;
					continue;
				}
				goto IL_010c;
			case 7:
				if (num5 >= (decimal)num6)
				{
					goto case 10;
				}
				goto case 23;
			case 4:
				num12 = -1;
				goto IL_05d4;
			case 8:
				if (!num4.HasValue)
				{
					goto case 4;
				}
				num12 = num4.GetValueOrDefault();
				goto IL_05d4;
			case 9:
				num5 = Math.Abs(num10);
				num2 = 14;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_4f0cf0da7be4416c854b8885e7290889 != 0)
				{
					num2 = 19;
				}
				continue;
			case 10:
				if (num13 >= 0)
				{
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_b6f1ae5199084abc84c46b275feb4dfd == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto IL_010c;
			case 5:
				if (!num4.HasValue)
				{
					num2 = 27;
					continue;
				}
				num7 = num4.GetValueOrDefault();
				break;
			case 6:
				return;
			case 13:
				return;
			case 21:
				return;
			case 12:
				if (num9 >= 0)
				{
					goto case 25;
				}
				goto case 18;
			case 26:
				AddAlert(Filter1Alert, string.Format(Resources.ChartIndicatorsDeltaFilterAlert, 1, base.DataProvider.Symbol.FormatSizeFull(num10)));
				goto case 23;
			case 27:
				num7 = -1;
				break;
			case 22:
				num4 = Filter3Max;
				num2 = 14;
				continue;
			case 23:
				if (Filter2Alert.IsActive && rhKi50kyUW3 < num8)
				{
					num2 = 29;
					continue;
				}
				goto case 18;
			case 19:
				if (!Filter1Alert.IsActive || U0mi1zhi616 >= num8)
				{
					goto case 23;
				}
				num4 = Filter1Min;
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_03398ebbe6224bea83047c33d24affe2 == 0)
				{
					num2 = 3;
				}
				continue;
			case 14:
				if (!num4.HasValue)
				{
					num2 = 17;
					continue;
				}
				num11 = num4.GetValueOrDefault();
				goto IL_063b;
			case 20:
				num4 = Filter2Max;
				num2 = 5;
				continue;
			case 15:
				hjii52jWuyS = num8;
				AddAlert(Filter3Alert, string.Format(Resources.ChartIndicatorsDeltaFilterAlert, 3, base.DataProvider.Symbol.FormatSizeFull(num10)));
				num2 = 21;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e9f58003753b4aa88a036bb6f675d81b == 0)
				{
					num2 = 20;
				}
				continue;
			case 11:
				rhKi50kyUW3 = -1;
				hjii52jWuyS = -1;
				goto IL_0179;
			case 1:
				U0mi1zhi616 = -1;
				num2 = 11;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e9f58003753b4aa88a036bb6f675d81b == 0)
				{
					num2 = 9;
				}
				continue;
			case 25:
				if (num5 >= (decimal)num9 && (num14 < 0 || iS7fAsebui2qdoSJIUlo(num5, c16GE0ebpjNohbwxTLX6(num14))))
				{
					rhKi50kyUW3 = num8;
					AddAlert(Filter2Alert, (string)i9tEqHeN0nfoy8DOswvn(Resources.ChartIndicatorsDeltaFilterAlert, 2, ((IChartSymbol)JbfqCwebzy9IU8WXUPoA(base.DataProvider)).FormatSizeFull(num10)));
					num2 = 18;
					continue;
				}
				goto case 18;
			case 18:
				if (!AJ69skeN2O61XSn4ktFF(Filter3Alert) || hjii52jWuyS >= num8)
				{
					return;
				}
				num4 = Filter3Min;
				num16 = num4 ?? (-1);
				num2 = 22;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f02aef63891d4dd388caae3711d082ae == 0)
				{
					num2 = 5;
				}
				continue;
			case 3:
				num6 = num4 ?? (-1);
				num4 = Filter1Max;
				num2 = 8;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_d4f52eaa7d9d4aa09bb6fdf0b3adf8b6 != 0)
				{
					num2 = 5;
				}
				continue;
			case 2:
				if (base.ClearData)
				{
					num2 = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_c47f9ac95ef6414e90317ead219c477c != 0)
					{
						num2 = 1;
					}
					continue;
				}
				goto IL_0179;
			case 17:
				num11 = -1;
				goto IL_063b;
			case 28:
				if (!num4.HasValue)
				{
					num2 = 24;
					continue;
				}
				num3 = num4.GetValueOrDefault();
				goto IL_05e2;
			case 29:
				num4 = Filter2Min;
				num2 = 28;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_51365cbe57344dc59bfcbecc60361463 == 0)
				{
					num2 = 25;
				}
				continue;
			case 24:
				num3 = -1;
				goto IL_05e2;
			case 16:
				return;
				IL_05e2:
				num9 = num3;
				num2 = 6;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bddbd469f60045dea35a495487f8a4fb != 0)
				{
					num2 = 20;
				}
				continue;
				IL_010c:
				U0mi1zhi616 = num8;
				num2 = 26;
				continue;
				IL_0179:
				num8 = ULwaiLebFUoNNJbPPa5o(base.DataProvider);
				cluster = base.DataProvider.GetCluster(num8 - 1);
				if (cluster == null)
				{
					num2 = 16;
					continue;
				}
				num10 = k8Jc5Heb3XGvxHMxTtCy(cluster);
				num2 = 9;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_123010c01d0b4fbbba06aee53a0dc75d == 0)
				{
					num2 = 5;
				}
				continue;
				IL_05d4:
				num13 = num12;
				if (num6 >= 0)
				{
					num2 = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8df0e84d43a842eca742d74a9772b346 == 0)
					{
						num2 = 7;
					}
					continue;
				}
				goto case 23;
				IL_063b:
				num15 = num11;
				if (num16 < 0)
				{
					return;
				}
				if (num5 >= (decimal)num16)
				{
					if (num15 >= 0 && !(num5 <= c16GE0ebpjNohbwxTLX6(num15)))
					{
						num2 = 13;
						continue;
					}
					goto case 15;
				}
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_239bac6736df482c97654364ff867959 == 0)
				{
					num2 = 6;
				}
				continue;
			}
			num14 = num7;
			num2 = 12;
		}
	}

	public override bool GetMinMax(out double P_0, out double P_1)
	{
		P_0 = double.MaxValue;
		P_1 = double.MinValue;
		int num = default(int);
		int num2;
		if (Type == DeltaViewType.Candles)
		{
			num = 0;
			num2 = 7;
			goto IL_0009;
		}
		goto IL_0408;
		IL_03bb:
		int num3 = default(int);
		int index = base.Canvas.GetIndex(num3);
		IChartCluster chartCluster = (IChartCluster)q1KTUVeNoUNKeAf6yBwt(base.DataProvider, index);
		num2 = 3;
		goto IL_0009;
		IL_0009:
		double num6 = default(double);
		IChartCluster cluster = default(IChartCluster);
		double num7 = default(double);
		int num8 = default(int);
		int i = default(int);
		double num4 = default(double);
		while (true)
		{
			int num5;
			switch (num2)
			{
			case 11:
				P_1 = Math.Max(P_1, num6);
				num2 = 4;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_96ae262178274a62bc28b3fded6ea751 != 0)
				{
					num2 = 4;
				}
				continue;
			case 8:
			case 18:
				break;
			case 7:
			case 15:
				goto IL_016b;
			case 10:
				if (aLdNkCeNnrRxBxnyLQsD(cluster.Delta, 0m))
				{
					num2 = 6;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_84ff815db08e468bb177d195221f5fb1 == 0)
					{
						num2 = 5;
					}
					continue;
				}
				goto IL_01db;
			case 17:
				goto IL_01d0;
			case 3:
				if (chartCluster == null)
				{
					goto case 4;
				}
				goto IL_034b;
			case 19:
				num7 = (double)cluster.DeltaLow;
				num2 = 12;
				continue;
			case 20:
				goto IL_02cb;
			case 4:
			case 13:
				num3++;
				goto IL_03f1;
			case 16:
				if (P_0 < (double)(-num8))
				{
					P_0 = -num8;
					num2 = 20;
					continue;
				}
				goto IL_02cb;
			case 6:
				P_1 = Math.Max(P_1, 0.0 - num7);
				num2 = 5;
				continue;
			case 9:
				P_1 = Math.Max(P_1, Math.Abs(num6));
				goto case 4;
			case 2:
				cluster = base.DataProvider.GetCluster(i);
				if (cluster != null && !xgpwnFeNf1nB77cNbDFE(cluster.Delta, 0m))
				{
					num2 = 14;
					continue;
				}
				goto IL_0323;
			case 5:
				P_0 = UYjFDIeNGlA9QG97cRq9(P_0, 0.0 - num4);
				goto IL_0323;
			case 12:
				if (Minimize)
				{
					num2 = 10;
					continue;
				}
				goto IL_01db;
			default:
				goto IL_03bb;
			case 1:
				goto IL_0408;
			case 14:
				{
					num4 = (double)PqlYHweN9bpukGuQlMl7(cluster);
					num5 = 19;
					goto IL_0005;
				}
				IL_0005:
				num2 = num5;
				continue;
				IL_01db:
				P_0 = Math.Min(P_0, num7);
				P_1 = Qsm9JIeNYGkgTjPTLhoj(P_1, num4);
				goto IL_0323;
				IL_0323:
				num++;
				num5 = 15;
				goto IL_0005;
			}
			break;
			IL_034b:
			if (!(chartCluster.Delta == 0m))
			{
				num6 = (double)chartCluster.Delta;
				if (!Minimize)
				{
					P_0 = UYjFDIeNGlA9QG97cRq9(P_0, num6);
					num2 = 11;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0b86e69c2a884980a2238f7088b49732 == 0)
					{
						num2 = 11;
					}
				}
				else
				{
					num2 = 9;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e74f04d60e394f2bbc3b9757a3df6bbb != 0)
					{
						num2 = 3;
					}
				}
			}
			else
			{
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9907a2dfacd24021aae0fe30c599035f == 0)
				{
					num2 = 13;
				}
			}
			continue;
			IL_016b:
			if (num >= base.Canvas.Count)
			{
				num2 = 8;
				continue;
			}
			i = PEbNJ0eNH5WFeUnhTnLw(base.Canvas, num);
			num2 = 2;
		}
		goto IL_015e;
		IL_0408:
		num3 = 0;
		goto IL_03f1;
		IL_0445:
		int num9;
		num8 = num9;
		if (num8 >= 0 && P_1 > (double)num8)
		{
			P_1 = num8;
		}
		if (num8 >= 0)
		{
			num2 = 16;
			goto IL_0009;
		}
		goto IL_02cb;
		IL_02cb:
		return true;
		IL_015e:
		int? num10 = MaxDelta;
		if (!num10.HasValue)
		{
			num2 = 17;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3ef08b277e78467b833a3119d7297528 == 0)
			{
				num2 = 4;
			}
			goto IL_0009;
		}
		num9 = num10.GetValueOrDefault();
		goto IL_0445;
		IL_01d0:
		num9 = -1;
		goto IL_0445;
		IL_03f1:
		if (num3 >= base.Canvas.Count)
		{
			if (Minimize)
			{
				P_0 = 0.0;
				num2 = 18;
				goto IL_0009;
			}
			goto IL_015e;
		}
		goto IL_03bb;
	}

	public override void Render(DxVisualQueue P_0)
	{
		int? num = Filter1Min;
		int num2;
		if (!num.HasValue)
		{
			num2 = 3;
			goto IL_0005;
		}
		int num3 = num.GetValueOrDefault();
		goto IL_0ecf;
		IL_0bf4:
		XBrush xBrush = qY9i1KLpH2v;
		XPen pen = thmi1mUNOUi;
		num2 = 38;
		goto IL_0005;
		IL_08d3:
		xBrush = qGKi1VHjKUC;
		num2 = 62;
		goto IL_0005;
		IL_0005:
		int num4 = num2;
		goto IL_0009;
		IL_0009:
		int num7 = default(int);
		decimal delta = default(decimal);
		IChartCluster cluster = default(IChartCluster);
		XBrush xBrush2 = default(XBrush);
		int num26 = default(int);
		double num24 = default(double);
		decimal num20 = default(decimal);
		IChartCluster cluster2 = default(IChartCluster);
		int num23 = default(int);
		int index2 = default(int);
		int num27 = default(int);
		int num28 = default(int);
		int num32 = default(int);
		int num16 = default(int);
		int num33 = default(int);
		int num25 = default(int);
		int val = default(int);
		int num29 = default(int);
		int num22 = default(int);
		int num11 = default(int);
		decimal num12 = default(decimal);
		int num14 = default(int);
		double x = default(double);
		double num5 = default(double);
		bool flag = default(bool);
		XPen xPen = default(XPen);
		int num21 = default(int);
		int num19 = default(int);
		decimal num10 = default(decimal);
		int num18 = default(int);
		double num15 = default(double);
		int num8 = default(int);
		int num17 = default(int);
		int index = default(int);
		int num13 = default(int);
		int num9 = default(int);
		DeltaViewType deltaViewType = default(DeltaViewType);
		Rect rect;
		while (true)
		{
			int num6;
			XPen wB3i1E4RR1w;
			switch (num4)
			{
			case 9:
				num7 = 1;
				goto case 72;
			case 79:
				return;
			case 70:
				num6 = -1;
				goto IL_0f50;
			case 77:
				delta = cluster.Delta;
				num4 = 6;
				continue;
			case 21:
				break;
			case 41:
				xBrush = ywZi1OCVCiO;
				num4 = 63;
				continue;
			case 56:
				goto IL_023d;
			case 46:
				xBrush2 = Da6i1ACsUEf;
				num4 = 22;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_4f0cf0da7be4416c854b8885e7290889 != 0)
				{
					num4 = 31;
				}
				continue;
			case 3:
				goto IL_02b8;
			case 67:
				num26 = (int)(base.Canvas.ColumnWidth * base.Canvas.ColumnPercent + 0.4);
				num24 = Math.Max((int)((double)num26 / 2.0), 1.0);
				num4 = 24;
				continue;
			case 64:
			{
				num20 = k8Jc5Heb3XGvxHMxTtCy(cluster2);
				bool num30 = num20 > 0m;
				num23 = (int)BfgkdTeNvqrh1fk1chcS(base.Canvas, index2);
				num27 = (int)GetY(cluster2.DeltaHigh);
				num28 = (int)GetY(d4MSwPeNBX9Dmghlqqdc(cluster2));
				int num31 = (int)GetY(num20);
				if (Minimize && aLdNkCeNnrRxBxnyLQsD(num20, 0m))
				{
					num27 = (int)GetY(jhaKmReNaKukEHp6CJG2(cluster2.DeltaLow));
					num28 = (int)GetY(-cluster2.DeltaHigh);
					num31 = (int)GetY(jhaKmReNaKukEHp6CJG2(num20));
				}
				if (num32 >= 0)
				{
					if (num20 > 0m || Minimize)
					{
						num31 = aLd7DQeNiwlbTPr5Q7iA(num31, num16);
						num27 = Math.Max(num27, num16);
						num28 = Math.Min(num28, num33);
					}
					else
					{
						num31 = Math.Min(num31, num33);
						num27 = aLd7DQeNiwlbTPr5Q7iA(num27, num16);
						num28 = Math.Min(num28, num33);
					}
				}
				num25 = Math.Min(val, num31);
				num29 = Math.Max(val, num31);
				num22 = num29 - num25;
				xBrush2 = (num30 ? IOai1sUJ4IS : kWqi1jT2D6D);
				if (!num30)
				{
					num4 = 76;
					continue;
				}
				wB3i1E4RR1w = zw1i1XcskuA;
				goto IL_10b4;
			}
			case 53:
				if (num11 >= 0 && num12 >= (decimal)num11)
				{
					num4 = 37;
					continue;
				}
				goto IL_0c1d;
			case 66:
				num14 = Filter3Max ?? (-1);
				num = MaxDelta;
				num4 = 14;
				continue;
			case 33:
				if (xBrush != null)
				{
					P_0.DrawLine(pen, x, num5, x, num5 + (double)num7);
				}
				else
				{
					R8Kw2weN1FGN7bhA3bYf(P_0, flag ? zw1i1XcskuA : WB3i1E4RR1w, x, num5, x, num5 + (double)num7);
				}
				goto case 4;
			case 36:
				xPen = aQSi1tCNwHP;
				num4 = 23;
				continue;
			case 10:
				num21 = 0;
				goto case 78;
			case 49:
				if (!mpJY5NeNkBSWN1tsgiA5(delta, 0m))
				{
					goto case 71;
				}
				xBrush = Da6i1ACsUEf;
				pen = Xmui1PWTrPr;
				goto case 38;
			case 52:
				xBrush2 = qY9i1KLpH2v;
				num4 = 65;
				continue;
			case 35:
				index2 = base.Canvas.GetIndex(num19);
				num4 = 12;
				continue;
			case 11:
				goto IL_04de;
			case 63:
				pen = mWVi1qCJChI;
				goto case 38;
			case 26:
				goto IL_053d;
			case 1:
				num7 = -num7;
				goto IL_042a;
			case 14:
				if (!num.HasValue)
				{
					num4 = 70;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_c47f9ac95ef6414e90317ead219c477c == 0)
					{
						num4 = 15;
					}
					continue;
				}
				num6 = num.GetValueOrDefault();
				goto IL_0f50;
			case 65:
				xPen = thmi1mUNOUi;
				goto case 23;
			case 22:
				if (num10 <= (decimal)num18)
				{
					goto IL_039a;
				}
				goto case 74;
			case 38:
				if (!(num15 > 1.0))
				{
					goto case 33;
				}
				goto IL_08f9;
			case 71:
				xBrush = PhWi1F1AyEK;
				num4 = 61;
				continue;
			case 50:
				num5 = num8 - 1;
				num7 = 1;
				num4 = 72;
				continue;
			case 57:
				num = Filter1Max;
				num17 = num ?? (-1);
				num4 = 47;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e9f58003753b4aa88a036bb6f675d81b != 0)
				{
					num4 = 56;
				}
				continue;
			case 62:
				pen = mBKi1C4GVSN;
				goto case 38;
			case 5:
				if (num17 >= 0)
				{
					num4 = 15;
					continue;
				}
				goto IL_04de;
			case 27:
				cluster = base.DataProvider.GetCluster(index);
				num4 = 73;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_239bac6736df482c97654364ff867959 != 0)
				{
					num4 = 30;
				}
				continue;
			case 48:
			case 69:
				num19++;
				num4 = 58;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0f9979478ba842a39155e14f5980ecce == 0)
				{
					num4 = 45;
				}
				continue;
			case 74:
				if (num13 >= 0 && num10 >= (decimal)num13 && (num14 < 0 || num10 <= c16GE0ebpjNohbwxTLX6(num14)))
				{
					goto IL_0482;
				}
				goto case 23;
			case 76:
				wB3i1E4RR1w = WB3i1E4RR1w;
				goto IL_10b4;
			case 25:
				if (HVOSZUeNlu60usDpJVtm(num12, num13))
				{
					if (num14 >= 0)
					{
						num4 = 28;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_26c70faf0c9c44d6abdd5939b8657847 != 0)
						{
							num4 = 7;
						}
						continue;
					}
					goto case 49;
				}
				goto case 38;
			case 19:
				xPen = MmRi13jJWXf;
				num4 = 51;
				continue;
			case 39:
				if (num32 >= 0)
				{
					if (Minimize)
					{
						num4 = 1;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_d4f52eaa7d9d4aa09bb6fdf0b3adf8b6 == 0)
						{
							num4 = 2;
						}
						continue;
					}
					num5 = (mpJY5NeNkBSWN1tsgiA5(delta, 0m) ? Math.Max(num5, num16) : UYjFDIeNGlA9QG97cRq9(num5, num33));
				}
				goto IL_0750;
			case 59:
				num12 = F8Kt8yeNNrukRHKKhVVd(delta);
				if (num9 < 0 || !HVOSZUeNlu60usDpJVtm(num12, c16GE0ebpjNohbwxTLX6(num9)))
				{
					goto case 53;
				}
				if (num17 >= 0)
				{
					num4 = 75;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e767fb04e1fb471592fd70a4ebcca575 != 0)
					{
						num4 = 5;
					}
					continue;
				}
				goto IL_0728;
			case 72:
				flag = delta > 0m;
				num4 = 44;
				continue;
			case 20:
				num28++;
				num4 = 33;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_77d26139d1074373ba3d17cb18b3ec16 == 0)
				{
					num4 = 40;
				}
				continue;
			case 42:
				goto IL_08d3;
			case 4:
			case 17:
				num21++;
				num4 = 78;
				continue;
			case 29:
			case 58:
				if (num19 >= HkprcCeNbG9uAlkyGduK(base.Canvas))
				{
					num4 = 79;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_16f1ffbaff15428c840c488e7b8380f5 == 0)
					{
						num4 = 26;
					}
					continue;
				}
				goto case 35;
			case 13:
				return;
			case 45:
				deltaViewType = Type;
				num4 = 26;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bddbd469f60045dea35a495487f8a4fb == 0)
				{
					num4 = 18;
				}
				continue;
			case 43:
				xBrush2 = ywZi1OCVCiO;
				xPen = mWVi1qCJChI;
				goto case 23;
			case 24:
				val = num8;
				num19 = 0;
				num4 = 29;
				continue;
			case 34:
				if (num12 <= c16GE0ebpjNohbwxTLX6(num18))
				{
					goto IL_049d;
				}
				goto IL_0c1d;
			case 68:
				if (num22 != 0)
				{
					ggJ4NLeNDZvFvQtLsX7k(P_0, xBrush2, new Rect((double)num23 - num24, num25, num24 * 2.0 + 1.0, num22));
					goto case 48;
				}
				P_0.DrawLine(xPen, new Point((double)num23 - num24, num25), new Point((double)num23 + num24 + 1.0, num25));
				num4 = 48;
				continue;
			case 73:
				if (cluster != null && !xgpwnFeNf1nB77cNbDFE(k8Jc5Heb3XGvxHMxTtCy(cluster), 0m))
				{
					num4 = 77;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0fb675c372064c2d9cad17812d8d65ed != 0)
					{
						num4 = 0;
					}
					continue;
				}
				goto case 4;
			case 18:
				xBrush2 = qGKi1VHjKUC;
				xPen = mBKi1C4GVSN;
				goto case 23;
			case 47:
				num10 = Math.Abs(num20);
				num4 = 54;
				continue;
			default:
				num8 = (int)GetY(0.0);
				num4 = 45;
				continue;
			case 60:
				if (num26 > 1)
				{
					num4 = 68;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f02aef63891d4dd388caae3711d082ae == 0)
					{
						num4 = 64;
					}
					continue;
				}
				goto case 48;
			case 55:
				if (num18 >= 0)
				{
					num4 = 20;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_7718f96c0b7741f0ab4250d28233bddf == 0)
					{
						num4 = 22;
					}
					continue;
				}
				goto IL_039a;
			case 40:
				zb6iqyeN4GEgwBupriFR(P_0, xPen, new Point(num23, num27), new Point(num23, num28));
				goto case 60;
			case 30:
				num11 = num ?? (-1);
				num4 = 32;
				continue;
			case 37:
				if (num18 >= 0)
				{
					num4 = 34;
					continue;
				}
				goto IL_049d;
			case 16:
				num = Filter3Min;
				num13 = num ?? (-1);
				num4 = 66;
				continue;
			case 75:
				if (!iS7fAsebui2qdoSJIUlo(num12, num17))
				{
					goto case 53;
				}
				goto IL_0728;
			case 44:
				xBrush = null;
				pen = null;
				num4 = 59;
				continue;
			case 12:
				cluster2 = base.DataProvider.GetCluster(index2);
				if (cluster2 == null)
				{
					num4 = 69;
					continue;
				}
				if (!(k8Jc5Heb3XGvxHMxTtCy(cluster2) == 0m))
				{
					num4 = 64;
					continue;
				}
				goto case 48;
			case 15:
				if (num10 <= (decimal)num17)
				{
					num4 = 4;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e74f04d60e394f2bbc3b9757a3df6bbb == 0)
					{
						num4 = 11;
					}
					continue;
				}
				goto IL_0e86;
			case 78:
				if (num21 < base.Canvas.Count)
				{
					index = base.Canvas.GetIndex(num21);
					num4 = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_86d84d52ab13483783040bb945a786b2 == 0)
					{
						num4 = 27;
					}
				}
				else
				{
					num4 = 13;
				}
				continue;
			case 28:
				if (iS7fAsebui2qdoSJIUlo(num12, c16GE0ebpjNohbwxTLX6(num14)))
				{
					num4 = 49;
					continue;
				}
				goto case 38;
			case 2:
				num5 = Math.Max(num5, num16);
				goto IL_0750;
			case 31:
				xPen = Xmui1PWTrPr;
				goto case 23;
			case 7:
				if (num10 >= (decimal)num11)
				{
					num4 = 55;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_4f0cf0da7be4416c854b8885e7290889 == 0)
					{
						num4 = 12;
					}
					continue;
				}
				goto case 74;
			case 32:
				num = Filter2Max;
				num4 = 14;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_a0f7dd9205eb40fbb542085b90a19faa != 0)
				{
					num4 = 21;
				}
				continue;
			case 54:
				if (num9 >= 0 && HVOSZUeNlu60usDpJVtm(num10, c16GE0ebpjNohbwxTLX6(num9)))
				{
					num4 = 5;
					continue;
				}
				goto IL_0e86;
			case 6:
				x = base.Canvas.GetX(index);
				num4 = 8;
				continue;
			case 23:
			case 51:
				if (num22 == 0 || num26 <= 1)
				{
					if (num27 == num28)
					{
						num4 = 20;
						continue;
					}
					goto case 40;
				}
				P_0.DrawLine(xPen, new Point(num23, num27), new Point(num23, num25));
				P_0.DrawLine(xPen, new Point(num23, num29), new Point(num23, num28));
				num4 = 60;
				continue;
			case 61:
				pen = MmRi13jJWXf;
				goto case 38;
			case 8:
				{
					num5 = GetY(Minimize ? F8Kt8yeNNrukRHKKhVVd(delta) : delta);
					num4 = 39;
					continue;
				}
				IL_0750:
				num7 = num8 - (int)num5;
				if ((double)num7 < 0.0)
				{
					num5 += (double)num7;
					num4 = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_900fe0d7516743c1bc15292a67b06048 != 0)
					{
						num4 = 0;
					}
					continue;
				}
				goto IL_042a;
				IL_042a:
				if (Minimize || delta > 0m)
				{
					if (num7 < 1)
					{
						num4 = 50;
						continue;
					}
				}
				else if (num7 < 1)
				{
					num5 = num8;
					num4 = 9;
					continue;
				}
				goto case 72;
				IL_10b4:
				xPen = wB3i1E4RR1w;
				num4 = 47;
				continue;
				IL_0c1d:
				if (num13 >= 0)
				{
					num4 = 25;
					continue;
				}
				goto case 38;
				IL_0e86:
				if (num11 >= 0)
				{
					num4 = 7;
					continue;
				}
				goto case 74;
				IL_039a:
				if (num20 > 0m)
				{
					num4 = 18;
					continue;
				}
				goto case 52;
				IL_0728:
				if (delta > 0m)
				{
					num4 = 41;
					continue;
				}
				xBrush = Aoai1WGjIIH;
				pen = aQSi1tCNwHP;
				goto case 38;
				IL_0f50:
				num32 = num6;
				num16 = (int)GetY((double)num32);
				num33 = (int)GetY((double)(-num32));
				num4 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_77d26139d1074373ba3d17cb18b3ec16 != 0)
				{
					num4 = 0;
				}
				continue;
			}
			break;
			IL_049d:
			if (delta > 0m)
			{
				num4 = 42;
				continue;
			}
			goto IL_0bf4;
			IL_08f9:
			rect = new Rect(x - num15 / 2.0, num5, num15, num7);
			if (xBrush != null)
			{
				goto IL_01b5;
			}
			P_0.FillRectangle(flag ? IOai1sUJ4IS : kWqi1jT2D6D, rect);
			num4 = 4;
			continue;
			IL_0482:
			if (!(num20 > 0m))
			{
				xBrush2 = PhWi1F1AyEK;
				num4 = 19;
			}
			else
			{
				num4 = 46;
			}
			continue;
			IL_053d:
			switch (deltaViewType)
			{
			case DeltaViewType.Columns:
				num15 = Math.Max(base.Canvas.ColumnWidth - 1.0, 1.0);
				num4 = 10;
				break;
			default:
				return;
			case DeltaViewType.Candles:
				num4 = 67;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9a8381dfafdf4cd0bdbdde184d2abaf1 == 0)
				{
					num4 = 44;
				}
				break;
			}
			continue;
			IL_04de:
			if (num20 > 0m)
			{
				num4 = 42;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_84ff815db08e468bb177d195221f5fb1 != 0)
				{
					num4 = 43;
				}
			}
			else
			{
				xBrush2 = Aoai1WGjIIH;
				num4 = 36;
			}
		}
		num18 = num ?? (-1);
		num2 = 16;
		goto IL_0005;
		IL_023d:
		num = Filter2Min;
		num2 = 30;
		goto IL_0005;
		IL_01b5:
		ggJ4NLeNDZvFvQtLsX7k(P_0, xBrush, rect);
		num2 = 17;
		goto IL_0005;
		IL_02b8:
		num3 = -1;
		goto IL_0ecf;
		IL_0ecf:
		num9 = num3;
		num4 = 57;
		goto IL_0009;
	}

	public override List<IndicatorValueInfo> GetValues(int cursorPos)
	{
		List<IndicatorValueInfo> list = new List<IndicatorValueInfo>();
		IChartCluster cluster = base.DataProvider.GetCluster(cursorPos);
		if (cluster == null)
		{
			return list;
		}
		string value = base.Canvas.FormatValue((double)cluster.Delta);
		list.Add(new IndicatorValueInfo(value, base.Canvas.Theme.ChartFontBrush));
		return list;
	}

	public override void GetLabels(ref List<IndicatorLabelInfo> P_0)
	{
		int num = 1;
		int num2 = num;
		IChartCluster cluster = default(IChartCluster);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 4:
				if (cluster != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_05d722d67d874d6fa7bb056304182294 == 0)
					{
						num2 = 2;
					}
					break;
				}
				return;
			case 0:
				return;
			case 2:
			{
				decimal num3 = (Minimize ? Math.Abs(cluster.Delta) : k8Jc5Heb3XGvxHMxTtCy(cluster));
				P_0.Add(new IndicatorLabelInfo((double)num3, (cluster.Delta > 0m) ? UQDi1cOh325 : iTMi1QWdUCy));
				num2 = 3;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f866dbb44e884db6a20dd750c320252b == 0)
				{
					num2 = 1;
				}
				break;
			}
			case 3:
				return;
			case 1:
				if (base.DataProvider.Count > IYDc7veN5fGYnpd2vIsF(base.Canvas))
				{
					cluster = base.DataProvider.GetCluster(base.DataProvider.Count - 1 - IYDc7veN5fGYnpd2vIsF(base.Canvas));
					num2 = 4;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_c6d928b106694fcbadc87b1b898a5509 != 0)
					{
						num2 = 1;
					}
				}
				else
				{
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_c6d928b106694fcbadc87b1b898a5509 != 0)
					{
						num2 = 0;
					}
				}
				break;
			}
		}
	}

	public override bool CheckAlert(double P_0, int P_1, ref int P_2, ref double P_3)
	{
		int num = 5;
		int num2 = num;
		bool flag = default(bool);
		double num3 = default(double);
		IChartCluster cluster = default(IChartCluster);
		while (true)
		{
			switch (num2)
			{
			case 5:
				if (ULwaiLebFUoNNJbPPa5o(base.DataProvider) == P_2)
				{
					num2 = 4;
					break;
				}
				goto IL_0063;
			case 6:
				return false;
			case 3:
				flag = true;
				goto IL_0101;
			default:
				if (num3 >= P_0 - (double)P_1)
				{
					num2 = 2;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_ebea16d83ff14ec5b816c14cbab4c1cf == 0)
					{
						num2 = 3;
					}
					break;
				}
				goto IL_00e8;
			case 7:
				if (num3 <= P_0 + (double)P_1)
				{
					num2 = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8bad63f401844feb8b319ab89401e7b9 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto IL_0101;
			case 2:
				if (cluster == null)
				{
					return false;
				}
				flag = false;
				num3 = (double)cluster.Delta;
				if (P_0 > 0.0)
				{
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_ffb93a04ce4c4a8e857e2e7fd646df59 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto IL_00e8;
			case 1:
				flag = true;
				goto IL_0101;
			case 4:
				{
					if (P_0 == P_3)
					{
						num2 = 6;
						break;
					}
					goto IL_0063;
				}
				IL_0063:
				cluster = base.DataProvider.GetCluster(base.DataProvider.Count - 1);
				num2 = 2;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_455a5cf7fae1454bbfd88da1f6361acc == 0)
				{
					num2 = 2;
				}
				break;
				IL_00e8:
				if (P_0 < 0.0)
				{
					num2 = 7;
					break;
				}
				goto IL_0101;
				IL_0101:
				if (flag)
				{
					P_2 = ULwaiLebFUoNNJbPPa5o(base.DataProvider);
					P_3 = P_0;
					return true;
				}
				return false;
			}
		}
	}

	public override void ApplyColors(IChartTheme P_0)
	{
		DeltaPlusColor = P_0.PaletteColor6;
		DeltaMinusColor = P_0.PaletteColor7;
		base.ApplyColors(P_0);
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9f8132c088e4447e83ec74ef15b8e944 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public override void CopyTemplate(IndicatorBase P_0, bool P_1)
	{
		d3s6rCikekRO49O7ZbKA d3s6rCikekRO49O7ZbKA2 = (d3s6rCikekRO49O7ZbKA)P_0;
		DeltaPlusColor = d3s6rCikekRO49O7ZbKA2.DeltaPlusColor;
		DeltaMinusColor = d3s6rCikekRO49O7ZbKA2.DeltaMinusColor;
		Type = D1nAABeNSEBbRfjeuGQP(d3s6rCikekRO49O7ZbKA2);
		Minimize = d3s6rCikekRO49O7ZbKA2.Minimize;
		int num = 1;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_265fe44b237843c0af011f50c2e58924 != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 10:
				Xa2ikCtOKau.Copy(d3s6rCikekRO49O7ZbKA2.Xa2ikCtOKau);
				OnPropertyChanged((string)GTtmPEebhlsEnTx9lSfE(-1192989954 ^ -1192951838));
				OnPropertyChanged((string)GTtmPEebhlsEnTx9lSfE(-894902996 ^ -894941160));
				Filter1PlusColor = d3s6rCikekRO49O7ZbKA2.Filter1PlusColor;
				Filter1MinusColor = d3s6rCikekRO49O7ZbKA2.Filter1MinusColor;
				num = 8;
				break;
			case 5:
				OnPropertyChanged((string)GTtmPEebhlsEnTx9lSfE(-225822163 ^ -225792947));
				Filter3PlusColor = d3s6rCikekRO49O7ZbKA2.Filter3PlusColor;
				Filter3MinusColor = d3s6rCikekRO49O7ZbKA2.Filter3MinusColor;
				Filter3Alert.Copy(d3s6rCikekRO49O7ZbKA2.Filter3Alert, !P_1);
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1799510641 ^ -1799539891));
				num = 3;
				break;
			default:
				OnPropertyChanged((string)GTtmPEebhlsEnTx9lSfE(-1435596783 ^ -1435624057));
				num = 12;
				break;
			case 7:
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-342738082 ^ -342708878));
				U3Ri1axrSAX.Copy(d3s6rCikekRO49O7ZbKA2.U3Ri1axrSAX);
				num = 4;
				break;
			case 9:
				fKXi10cpObe.Copy(d3s6rCikekRO49O7ZbKA2.fKXi10cpObe);
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1251569705 ^ -1251599771));
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-2056710528 ^ -2056682678));
				Filter2PlusColor = hkVH59eNe7HOLeUYN1KP(d3s6rCikekRO49O7ZbKA2);
				Filter2MinusColor = d3s6rCikekRO49O7ZbKA2.Filter2MinusColor;
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_5d6485f66cb24fc09096e66798254c7f == 0)
				{
					num = 6;
				}
				break;
			case 2:
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x37B74BDF ^ 0x37B7DD97));
				num = 5;
				break;
			case 6:
				Filter2Alert.Copy((ChartAlertSettings)QKxbAZeNsyDhQT8a7kkM(d3s6rCikekRO49O7ZbKA2), !P_1);
				num = 7;
				break;
			case 11:
				TH6ikU3lXPS.Copy((IndicatorParam<int?>)aKXQHDeNLHXuOC7UKhrD(d3s6rCikekRO49O7ZbKA2));
				num = 10;
				break;
			case 3:
				base.CopyTemplate(P_0, P_1);
				return;
			case 4:
				rBii1b1UoTR.Copy((IndicatorParam<int?>)iJB4DqeNXe06LtbaDaoG(d3s6rCikekRO49O7ZbKA2));
				num = 2;
				break;
			case 1:
				jY6ikOQFiCw.Copy((IndicatorParam<int?>)NpZn4CeNxJu606LgIg70(d3s6rCikekRO49O7ZbKA2));
				num = 11;
				break;
			case 12:
				wXdikFNSCKD.Copy(d3s6rCikekRO49O7ZbKA2.wXdikFNSCKD);
				num = 9;
				break;
			case 8:
				Filter1Alert.Copy(d3s6rCikekRO49O7ZbKA2.Filter1Alert, !P_1);
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9a8381dfafdf4cd0bdbdde184d2abaf1 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	static d3s6rCikekRO49O7ZbKA()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool NpI5D2ebKC2AI2dl0ZQY()
	{
		return mrsZGdebrcF4V744xGbC == null;
	}

	internal static d3s6rCikekRO49O7ZbKA v1pfmgebmqDZ5rPwYPVw()
	{
		return mrsZGdebrcF4V744xGbC;
	}

	internal static object GTtmPEebhlsEnTx9lSfE(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static bool W6VLOLebwsNMrXQdoCk4(XColor P_0, XColor P_1)
	{
		return P_0 == P_1;
	}

	internal static bool raiHENeb7smLmwXsW1AO(object P_0, object P_1)
	{
		return object.Equals(P_0, P_1);
	}

	internal static void b26nbseb83CjglNFeHE4()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
	}

	internal static Color h408oDebAg8mh4a6LJtq(byte P_0, byte P_1, byte P_2, byte P_3)
	{
		return Color.FromArgb(P_0, P_1, P_2, P_3);
	}

	internal static XColor naDTSTebPQ3EPgRc8HMv(Color P_0)
	{
		return P_0;
	}

	internal static Color lZiHbZebJt14d6SU9Die()
	{
		return Colors.Orange;
	}

	internal static int ULwaiLebFUoNNJbPPa5o(object P_0)
	{
		return ((IChartDataProvider)P_0).Count;
	}

	internal static decimal k8Jc5Heb3XGvxHMxTtCy(object P_0)
	{
		return ((IChartCluster)P_0).Delta;
	}

	internal static decimal c16GE0ebpjNohbwxTLX6(int P_0)
	{
		return P_0;
	}

	internal static bool iS7fAsebui2qdoSJIUlo(decimal P_0, decimal P_1)
	{
		return P_0 <= P_1;
	}

	internal static object JbfqCwebzy9IU8WXUPoA(object P_0)
	{
		return ((IChartDataProvider)P_0).Symbol;
	}

	internal static object i9tEqHeN0nfoy8DOswvn(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static bool AJ69skeN2O61XSn4ktFF(object P_0)
	{
		return ((ChartAlertSettings)P_0).IsActive;
	}

	internal static int PEbNJ0eNH5WFeUnhTnLw(object P_0, int i)
	{
		return ((IChartCanvas)P_0).GetIndex(i);
	}

	internal static bool xgpwnFeNf1nB77cNbDFE(decimal P_0, decimal P_1)
	{
		return P_0 == P_1;
	}

	internal static decimal PqlYHweN9bpukGuQlMl7(object P_0)
	{
		return ((IChartCluster)P_0).DeltaHigh;
	}

	internal static bool aLdNkCeNnrRxBxnyLQsD(decimal P_0, decimal P_1)
	{
		return P_0 < P_1;
	}

	internal static double UYjFDIeNGlA9QG97cRq9(double P_0, double P_1)
	{
		return Math.Min(P_0, P_1);
	}

	internal static double Qsm9JIeNYGkgTjPTLhoj(double P_0, double P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static object q1KTUVeNoUNKeAf6yBwt(object P_0, int i)
	{
		return ((IChartDataProvider)P_0).GetCluster(i);
	}

	internal static double BfgkdTeNvqrh1fk1chcS(object P_0, int i)
	{
		return ((IChartCanvas)P_0).GetX(i);
	}

	internal static decimal d4MSwPeNBX9Dmghlqqdc(object P_0)
	{
		return ((IChartCluster)P_0).DeltaLow;
	}

	internal static decimal jhaKmReNaKukEHp6CJG2(decimal P_0)
	{
		return -P_0;
	}

	internal static int aLd7DQeNiwlbTPr5Q7iA(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static bool HVOSZUeNlu60usDpJVtm(decimal P_0, decimal P_1)
	{
		return P_0 >= P_1;
	}

	internal static void zb6iqyeN4GEgwBupriFR(object P_0, object P_1, Point P_2, Point P_3)
	{
		((DxVisualQueue)P_0).DrawLine((XPen)P_1, P_2, P_3);
	}

	internal static void ggJ4NLeNDZvFvQtLsX7k(object P_0, object P_1, Rect P_2)
	{
		((DxVisualQueue)P_0).FillRectangle((XBrush)P_1, P_2);
	}

	internal static int HkprcCeNbG9uAlkyGduK(object P_0)
	{
		return ((IChartCanvas)P_0).Count;
	}

	internal static decimal F8Kt8yeNNrukRHKKhVVd(decimal P_0)
	{
		return Math.Abs(P_0);
	}

	internal static bool mpJY5NeNkBSWN1tsgiA5(decimal P_0, decimal P_1)
	{
		return P_0 > P_1;
	}

	internal static void R8Kw2weN1FGN7bhA3bYf(object P_0, object P_1, double P_2, double P_3, double P_4, double P_5)
	{
		((DxVisualQueue)P_0).DrawLine((XPen)P_1, P_2, P_3, P_4, P_5);
	}

	internal static int IYDc7veN5fGYnpd2vIsF(object P_0)
	{
		return ((IChartCanvas)P_0).Start;
	}

	internal static DeltaViewType D1nAABeNSEBbRfjeuGQP(object P_0)
	{
		return ((d3s6rCikekRO49O7ZbKA)P_0).Type;
	}

	internal static object NpZn4CeNxJu606LgIg70(object P_0)
	{
		return ((d3s6rCikekRO49O7ZbKA)P_0).jY6ikOQFiCw;
	}

	internal static object aKXQHDeNLHXuOC7UKhrD(object P_0)
	{
		return ((d3s6rCikekRO49O7ZbKA)P_0).TH6ikU3lXPS;
	}

	internal static XColor hkVH59eNe7HOLeUYN1KP(object P_0)
	{
		return ((d3s6rCikekRO49O7ZbKA)P_0).Filter2PlusColor;
	}

	internal static object QKxbAZeNsyDhQT8a7kkM(object P_0)
	{
		return ((d3s6rCikekRO49O7ZbKA)P_0).Filter2Alert;
	}

	internal static object iJB4DqeNXe06LtbaDaoG(object P_0)
	{
		return ((d3s6rCikekRO49O7ZbKA)P_0).rBii1b1UoTR;
	}
}
