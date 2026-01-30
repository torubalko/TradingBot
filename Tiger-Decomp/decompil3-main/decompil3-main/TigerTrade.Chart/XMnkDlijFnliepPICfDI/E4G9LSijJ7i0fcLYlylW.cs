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

namespace XMnkDlijFnliepPICfDI;

[DataContract(Name = "VolumeIndicator", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
[Indicator("Volume", "Volume", false, Type = typeof(E4G9LSijJ7i0fcLYlylW))]
internal sealed class E4G9LSijJ7i0fcLYlylW : IndicatorBase
{
	private XBrush oeDiEwYIC4e;

	private XPen aeNiE7ESSNs;

	private XColor ChsiE8K71W3;

	private XBrush VRTiEAUOksj;

	private XPen iPiiEPgntdU;

	private XColor YBHiEJa8Qo6;

	private bool PGxiEFjfyrQ;

	private IndicatorNullIntParam dAaiE3dnZVx;

	private IndicatorNullIntParam mQ2iEp2MyMD;

	private IndicatorNullIntParam hsLiEu6uQ0T;

	private XBrush xrGiEzZL3AO;

	private XPen OvZiQ0sFfNI;

	private XColor gGbiQ2AXC3o;

	private ChartAlertSettings wpYiQHU8hGX;

	private IndicatorNullIntParam n7qiQfvYQnc;

	private IndicatorNullIntParam qLFiQ9A9vcG;

	private XBrush EIoiQnL6prZ;

	private XPen UwoiQGyEvVe;

	private XColor be9iQYLo6qB;

	private ChartAlertSettings vGWiQorL5hd;

	private IndicatorNullIntParam T6HiQvE5S73;

	private IndicatorNullIntParam OvxiQBbKVV2;

	private XBrush UBuiQaTNvIl;

	private XPen D0hiQiSC07w;

	private XColor rQyiQl9gUYK;

	private ChartAlertSettings KjTiQ4ZpTln;

	private int VkLiQDonRsp;

	private int XcDiQbX7bRM;

	private int C06iQNgkhmx;

	private double WhKiQkggcv0;

	private static E4G9LSijJ7i0fcLYlylW aSxtN2exJYr1rxsBU9G0;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.Bar;

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsUpColor")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsStyle")]
	[DataMember(Name = "UpColor")]
	public XColor UpColor
	{
		get
		{
			return ChsiE8K71W3;
		}
		set
		{
			if (xColor == ChsiE8K71W3)
			{
				return;
			}
			ChsiE8K71W3 = xColor;
			int num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3619c4e2195548a982d8ce7a7eb0208e == 0)
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
				oeDiEwYIC4e = new XBrush(ChsiE8K71W3);
				aeNiE7ESSNs = new XPen(oeDiEwYIC4e, 1);
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x6AB40973 ^ 0x6AB49D07));
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_69212809764745e695cbac66765a5c5c != 0)
				{
					num = 1;
				}
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsDownColor")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsStyle")]
	[DataMember(Name = "DownColor")]
	public XColor DownColor
	{
		get
		{
			return YBHiEJa8Qo6;
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
					if (!(xColor == YBHiEJa8Qo6))
					{
						YBHiEJa8Qo6 = xColor;
						VRTiEAUOksj = new XBrush(YBHiEJa8Qo6);
						iPiiEPgntdU = new XPen(VRTiEAUOksj, 1);
						OnPropertyChanged((string)eSIyi8expGoceYC4ukUo(-1047165041 ^ -1047194871));
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_239bac6736df482c97654364ff867959 == 0)
						{
							num2 = 0;
						}
					}
					else
					{
						num2 = 1;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_daf6cb945fbc4987a518363c06ce80c2 == 0)
						{
							num2 = 0;
						}
					}
					break;
				}
			}
		}
	}

	[DataMember(Name = "DeltaColored")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsDeltaColored")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	public bool DeltaColored
	{
		get
		{
			return PGxiEFjfyrQ;
		}
		set
		{
			if (flag != PGxiEFjfyrQ)
			{
				PGxiEFjfyrQ = flag;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_16f1ffbaff15428c840c488e7b8380f5 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-203064540 ^ -203037466));
			}
		}
	}

	[DataMember(Name = "MaxVolumeParam")]
	public IndicatorNullIntParam SCYiEGLQVbu
	{
		get
		{
			return dAaiE3dnZVx ?? (dAaiE3dnZVx = new IndicatorNullIntParam(null));
		}
		set
		{
			dAaiE3dnZVx = indicatorNullIntParam;
		}
	}

	[DefaultValue(null)]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsMaxVolume")]
	public int? MaxVolume
	{
		get
		{
			return SCYiEGLQVbu.Get(base.SettingsLongKey);
		}
		set
		{
			if (SCYiEGLQVbu.Set(base.SettingsLongKey, value2, 0))
			{
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0xECA3F28 ^ 0xECA9F60));
			}
		}
	}

	[DataMember(Name = "Filter1MinParam")]
	public IndicatorNullIntParam vXoiEajPDvT
	{
		get
		{
			return mQ2iEp2MyMD ?? (mQ2iEp2MyMD = new IndicatorNullIntParam(null));
		}
		set
		{
			mQ2iEp2MyMD = indicatorNullIntParam;
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsMinimum")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsFilter1")]
	[DefaultValue(null)]
	public int? Filter1Min
	{
		get
		{
			return vXoiEajPDvT.Get(base.SettingsLongKey);
		}
		set
		{
			if (vXoiEajPDvT.Set(base.SettingsLongKey, value2, 0))
			{
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(--18459671 ^ 0x119390B));
			}
		}
	}

	[DataMember(Name = "Filter1MaxParam")]
	public IndicatorNullIntParam f3UiEb4pNbH
	{
		get
		{
			return hsLiEu6uQ0T ?? (hsLiEu6uQ0T = new IndicatorNullIntParam(null));
		}
		set
		{
			hsLiEu6uQ0T = indicatorNullIntParam;
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsFilter1")]
	[DefaultValue(null)]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsMaximum")]
	public int? Filter1Max
	{
		get
		{
			return f3UiEb4pNbH.Get(base.SettingsLongKey);
		}
		set
		{
			if (f3UiEb4pNbH.Set(base.SettingsLongKey, value2, 0))
			{
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1848952786 ^ -1848922854));
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsFilter1")]
	[DataMember(Name = "Filter1Color")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsColor")]
	public XColor Filter1Color
	{
		get
		{
			return gGbiQ2AXC3o;
		}
		set
		{
			if (xColor == gGbiQ2AXC3o)
			{
				return;
			}
			gGbiQ2AXC3o = xColor;
			int num = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_5bc14e9093324ecc8c5d7e08f50abd26 == 0)
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
					xrGiEzZL3AO = new XBrush(gGbiQ2AXC3o);
					OvZiQ0sFfNI = new XPen(xrGiEzZL3AO, 1);
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-176525661 ^ -176492201));
					num = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_578c88adb68d4c08b45439ab0955bb9b != 0)
					{
						num = 0;
					}
					break;
				}
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsFilter1")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsAlert")]
	[DataMember(Name = "Filter1Alert")]
	public ChartAlertSettings Filter1Alert
	{
		get
		{
			return wpYiQHU8hGX ?? (wpYiQHU8hGX = new ChartAlertSettings());
		}
		set
		{
			if (!object.Equals(objA, wpYiQHU8hGX))
			{
				wpYiQHU8hGX = objA;
				OnPropertyChanged((string)eSIyi8expGoceYC4ukUo(-176525661 ^ -176489675));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0d19152025c94f0b9078922cd1ec6aff == 0)
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
	public IndicatorNullIntParam CiaiEsV0uAL
	{
		get
		{
			return n7qiQfvYQnc ?? (n7qiQfvYQnc = new IndicatorNullIntParam(null));
		}
		set
		{
			n7qiQfvYQnc = indicatorNullIntParam;
		}
	}

	[DefaultValue(null)]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsFilter2")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsMinimum")]
	public int? Filter2Min
	{
		get
		{
			return CiaiEsV0uAL.Get(base.SettingsLongKey);
		}
		set
		{
			if (CiaiEsV0uAL.Set(base.SettingsLongKey, value2, 0))
			{
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x12620268 ^ 0x126297DA));
			}
		}
	}

	[DataMember(Name = "Filter2MaxParam")]
	public IndicatorNullIntParam SJYiEQlDnAJ
	{
		get
		{
			return qLFiQ9A9vcG ?? (qLFiQ9A9vcG = new IndicatorNullIntParam(null));
		}
		set
		{
			qLFiQ9A9vcG = indicatorNullIntParam;
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsMaximum")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsFilter2")]
	[DefaultValue(null)]
	public int? Filter2Max
	{
		get
		{
			return SJYiEQlDnAJ.Get(base.SettingsLongKey);
		}
		set
		{
			if (SJYiEQlDnAJ.Set(base.SettingsLongKey, value2, 0))
			{
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1161619942 ^ -1161591856));
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsFilter2")]
	[DataMember(Name = "Filter2Color")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsColor")]
	public XColor Filter2Color
	{
		get
		{
			return be9iQYLo6qB;
		}
		set
		{
			if (CUcug3exuMvdpZmn4TIl(xColor, be9iQYLo6qB))
			{
				return;
			}
			be9iQYLo6qB = xColor;
			int num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_239bac6736df482c97654364ff867959 != 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					UwoiQGyEvVe = new XPen(EIoiQnL6prZ, 1);
					OnPropertyChanged((string)eSIyi8expGoceYC4ukUo(0x86EFEF6 ^ 0x86E5EE6));
					return;
				}
				EIoiQnL6prZ = new XBrush(be9iQYLo6qB);
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9a8381dfafdf4cd0bdbdde184d2abaf1 == 0)
				{
					num = 1;
				}
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsFilter2")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsAlert")]
	[DataMember(Name = "Filter2Alert")]
	public ChartAlertSettings Filter2Alert
	{
		get
		{
			return vGWiQorL5hd ?? (vGWiQorL5hd = new ChartAlertSettings());
		}
		set
		{
			if (!object.Equals(objA, vGWiQorL5hd))
			{
				vGWiQorL5hd = objA;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x446AB724 ^ 0x446A2108));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_67043cdb3e78411cabdcd8aaa5ac8bc4 == 0)
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

	[DataMember(Name = "Filter3MinParam")]
	public IndicatorNullIntParam TtdiEWGGZBP
	{
		get
		{
			return T6HiQvE5S73 ?? (T6HiQvE5S73 = new IndicatorNullIntParam(null));
		}
		set
		{
			T6HiQvE5S73 = t6HiQvE5S;
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsMinimum")]
	[DefaultValue(null)]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsFilter3")]
	public int? Filter3Min
	{
		get
		{
			return TtdiEWGGZBP.Get(base.SettingsLongKey);
		}
		set
		{
			if (TtdiEWGGZBP.Set(base.SettingsLongKey, value2, 0))
			{
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1161619942 ^ -1161592750));
			}
		}
	}

	[DataMember(Name = "Filter3MaxParam")]
	public IndicatorNullIntParam rtXiEZGVHuA
	{
		get
		{
			return OvxiQBbKVV2 ?? (OvxiQBbKVV2 = new IndicatorNullIntParam(null));
		}
		set
		{
			OvxiQBbKVV2 = ovxiQBbKVV;
		}
	}

	[DefaultValue(null)]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsFilter3")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsMaximum")]
	public int? Filter3Max
	{
		get
		{
			return rtXiEZGVHuA.Get(base.SettingsLongKey);
		}
		set
		{
			if (rtXiEZGVHuA.Set(base.SettingsLongKey, value2, 0))
			{
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x746ED405 ^ 0x746E4265));
			}
		}
	}

	[DataMember(Name = "Filter3Color")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsFilter3")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsColor")]
	public XColor Filter3Color
	{
		get
		{
			return rQyiQl9gUYK;
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
					if (CUcug3exuMvdpZmn4TIl(xColor, rQyiQl9gUYK))
					{
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_96ae262178274a62bc28b3fded6ea751 != 0)
						{
							num2 = 0;
						}
						break;
					}
					rQyiQl9gUYK = xColor;
					UBuiQaTNvIl = new XBrush(rQyiQl9gUYK);
					num2 = 2;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3086d3efc49e46839e3f8d95f5cafecb == 0)
					{
						num2 = 2;
					}
					break;
				case 0:
					return;
				case 2:
					D0hiQiSC07w = new XPen(UBuiQaTNvIl, 1);
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x60620FC1 ^ 0x6062AFED));
					return;
				}
			}
		}
	}

	[DataMember(Name = "Filter3Alert")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsFilter3")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsAlert")]
	public ChartAlertSettings Filter3Alert
	{
		get
		{
			return KjTiQ4ZpTln ?? (KjTiQ4ZpTln = new ChartAlertSettings());
		}
		set
		{
			if (!object.Equals(chartAlertSettings, KjTiQ4ZpTln))
			{
				KjTiQ4ZpTln = chartAlertSettings;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-198991962 ^ -199030428));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_2dae9e7b16644e7ca6575920d9bcb6e3 != 0)
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

	public E4G9LSijJ7i0fcLYlylW()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		UpColor = z0M2ruexzOWZ0v5RHGe4(Color.FromArgb(byte.MaxValue, 30, 144, byte.MaxValue));
		DownColor = Idi9JMeL0ktlGSto6luh(byte.MaxValue, 178, 34, 34);
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1a52446ff7d24524a71087c98b41bbc6 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				DeltaColored = false;
				Filter1Color = Colors.Orange;
				Filter2Color = Colors.Orange;
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_555a94ebd4594650b107ef6bf239937f != 0)
				{
					num = 1;
				}
				break;
			case 2:
				return;
			case 3:
				VkLiQDonRsp = -1;
				XcDiQbX7bRM = -1;
				C06iQNgkhmx = -1;
				num = 2;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9b268a4ae6bd40e28461cca24d9b841f != 0)
				{
					num = 0;
				}
				break;
			case 1:
				Filter3Color = z0M2ruexzOWZ0v5RHGe4(ES5Gr6eL254Q0bvRZLan());
				num = 3;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_ebea16d83ff14ec5b816c14cbab4c1cf != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	protected override void Execute()
	{
		if (!base.ClearData)
		{
			goto IL_01b0;
		}
		VkLiQDonRsp = -1;
		XcDiQbX7bRM = -1;
		int num = 7;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_b6f1ae5199084abc84c46b275feb4dfd != 0)
		{
			num = 16;
		}
		goto IL_0009;
		IL_01b0:
		int count = base.DataProvider.Count;
		num = 24;
		goto IL_0009;
		IL_0009:
		int? num3 = default(int?);
		decimal num8 = default(decimal);
		int num13 = default(int);
		int num14 = default(int);
		int num12 = default(int);
		IChartCluster cluster = default(IChartCluster);
		int num10 = default(int);
		int num7 = default(int);
		while (true)
		{
			int num6;
			int num9;
			int num2;
			int num4;
			int num5;
			int num11;
			switch (num)
			{
			case 2:
				num3 = Filter2Min;
				num = 8;
				continue;
			case 4:
				if (!num3.HasValue)
				{
					num = 25;
					continue;
				}
				num6 = num3.GetValueOrDefault();
				goto IL_05a4;
			case 11:
				if (!num3.HasValue)
				{
					num = 12;
					continue;
				}
				num9 = num3.GetValueOrDefault();
				goto IL_0591;
			case 3:
				if (num8 <= YWUuayeLfh8WiHKBlI6w(num13))
				{
					num = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_caac71a6f9cb44c08459ac3c8bd80328 == 0)
					{
						num = 0;
					}
					continue;
				}
				goto case 13;
			case 19:
				if (num14 < 0 || num8 <= (decimal)num14)
				{
					VkLiQDonRsp = count;
					AddAlert(Filter1Alert, string.Format(Resources.ChartIndicatorsVolumeFilterAlert, 1, ((IChartSymbol)nGu8tBeL91khmiGDdKSk(base.DataProvider)).FormatSizeFull(num8)));
				}
				goto IL_024a;
			case 1:
				if (Filter1Alert.IsActive)
				{
					num = 18;
					continue;
				}
				goto IL_024a;
			case 17:
				num3 = Filter1Max;
				num = 15;
				continue;
			case 7:
				if (num8 >= (decimal)num12)
				{
					num = 22;
					continue;
				}
				goto case 13;
			case 23:
				return;
			case 25:
				num6 = -1;
				goto IL_05a4;
			case 24:
				cluster = base.DataProvider.GetCluster(count - 1);
				num = 21;
				continue;
			case 21:
				if (cluster != null)
				{
					num8 = lk9MrLeLHLMdVlLdgCmm(cluster);
					num = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1d290ee06e3247149fe255e31de353f8 == 0)
					{
						num = 0;
					}
				}
				else
				{
					num = 23;
				}
				continue;
			case 18:
				if (VkLiQDonRsp >= count)
				{
					goto IL_024a;
				}
				num3 = Filter1Min;
				if (!num3.HasValue)
				{
					num2 = -1;
					goto IL_0531;
				}
				num = 26;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_64274e2af1ab4c6db7e1ad660e8beb8f == 0)
				{
					num = 4;
				}
				continue;
			case 22:
				if (num13 < 0)
				{
					num = 9;
					continue;
				}
				goto case 3;
			default:
				XcDiQbX7bRM = count;
				AddAlert(Filter2Alert, string.Format(Resources.ChartIndicatorsVolumeFilterAlert, 2, ((IChartSymbol)nGu8tBeL91khmiGDdKSk(base.DataProvider)).FormatSizeFull(num8)));
				num = 13;
				continue;
			case 15:
				num14 = num3 ?? (-1);
				num = 10;
				continue;
			case 20:
				num4 = -1;
				goto IL_055b;
			case 6:
				num3 = Filter2Max;
				num13 = num3 ?? (-1);
				num = 5;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_cb7997a2f13d4554bdeb2d98b82239ee == 0)
				{
					num = 0;
				}
				continue;
			case 13:
				if (Filter3Alert.IsActive && C06iQNgkhmx < count)
				{
					num3 = Filter3Min;
					num = 9;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_331783b4349f408da28eb7270800e8f2 != 0)
					{
						num = 11;
					}
					continue;
				}
				return;
			case 5:
				if (num12 >= 0)
				{
					num = 7;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_676dd0a5ee95448585b63eb0094d7f85 == 0)
					{
						num = 5;
					}
					continue;
				}
				goto case 13;
			case 14:
				num3 = Filter3Max;
				num = 4;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0450b8b54d9e402da4e2f9dc872984ee == 0)
				{
					num = 0;
				}
				continue;
			case 10:
				if (num10 >= 0 && num8 >= YWUuayeLfh8WiHKBlI6w(num10))
				{
					goto case 19;
				}
				goto IL_024a;
			case 12:
				num9 = -1;
				goto IL_0591;
			case 8:
				if (!num3.HasValue)
				{
					num = 20;
					continue;
				}
				num4 = num3.GetValueOrDefault();
				goto IL_055b;
			case 16:
				break;
			case 26:
				{
					num2 = num3.GetValueOrDefault();
					goto IL_0531;
				}
				IL_024a:
				if (Filter2Alert.IsActive && XcDiQbX7bRM < count)
				{
					num = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_d4f52eaa7d9d4aa09bb6fdf0b3adf8b6 == 0)
					{
						num = 2;
					}
					continue;
				}
				goto case 13;
				IL_05a4:
				num5 = num6;
				if (num7 >= 0 && AbXheEeLnguiggFu2jE2(num8, YWUuayeLfh8WiHKBlI6w(num7)) && (num5 < 0 || num8 <= YWUuayeLfh8WiHKBlI6w(num5)))
				{
					C06iQNgkhmx = count;
					AddAlert(Filter3Alert, string.Format(Resources.ChartIndicatorsVolumeFilterAlert, 3, sP8Rx4eLGMXOtmkYlv6U(nGu8tBeL91khmiGDdKSk(base.DataProvider), num8)));
				}
				return;
				IL_0531:
				num10 = num2;
				num11 = 17;
				num = num11;
				continue;
				IL_0591:
				num7 = num9;
				num = 14;
				continue;
				IL_055b:
				num12 = num4;
				num = 6;
				continue;
			}
			break;
		}
		C06iQNgkhmx = -1;
		goto IL_01b0;
	}

	public override bool GetMinMax(out double P_0, out double P_1)
	{
		int num = 3;
		int num4 = default(int);
		int i = default(int);
		int num3 = default(int);
		IChartCluster chartCluster = default(IChartCluster);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					return true;
				case 5:
					if (num4 >= base.Canvas.Count)
					{
						num2 = 2;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_7d6ed381220347c0b7bad07060beb773 != 0)
						{
							num2 = 7;
						}
						continue;
					}
					i = C8ej9meLYUShZkbWFUJ5(base.Canvas, num4);
					num = 6;
					break;
				case 3:
					P_0 = 0.0;
					num2 = 2;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_96ae262178274a62bc28b3fded6ea751 != 0)
					{
						num2 = 1;
					}
					continue;
				case 7:
					num3 = MaxVolume ?? (-1);
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_66132b7977414fa9a4eabdda3db7b75c == 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					if (num3 >= 0 && P_1 > (double)num3)
					{
						P_1 = num3;
						num = 4;
						break;
					}
					goto case 4;
				case 2:
					P_1 = 0.0;
					num = 8;
					break;
				default:
				{
					double num5 = RixqdieLvjcu6gd1tTJn(chartCluster.Volume);
					if (P_1 < num5)
					{
						P_1 = num5;
					}
					goto IL_0149;
				}
				case 8:
					if (base.Canvas.IsStock)
					{
						return false;
					}
					num4 = 0;
					goto case 5;
				case 6:
					{
						chartCluster = (IChartCluster)E4LyZteLoqHjX0dZYRkl(base.DataProvider, i);
						if (chartCluster != null)
						{
							num2 = 0;
							if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9b268a4ae6bd40e28461cca24d9b841f == 0)
							{
								num2 = 0;
							}
							continue;
						}
						goto IL_0149;
					}
					IL_0149:
					num4++;
					num2 = 4;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_59aa80f4e54b43b381fcc4e95a4cfa2b != 0)
					{
						num2 = 5;
					}
					continue;
				}
				break;
			}
		}
	}

	private double rOOij3shl8L()
	{
		int num = 6;
		double num5 = default(double);
		int num3 = default(int);
		IChartCluster cluster = default(IChartCluster);
		int num7 = default(int);
		int? num4 = default(int?);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					num5 = num3;
					goto IL_00ca;
				case 2:
				{
					double num6 = (double)cluster.Volume;
					if (num5 < num6)
					{
						num5 = num6;
						num2 = 3;
						continue;
					}
					goto default;
				}
				case 6:
					break;
				case 5:
					num7 = 0;
					num2 = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_86d84d52ab13483783040bb945a786b2 == 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					if (num7 < oWIIIdeLBgYxCddY8l7W(base.Canvas))
					{
						int index = base.Canvas.GetIndex(num7);
						cluster = base.DataProvider.GetCluster(index);
						if (cluster == null)
						{
							num2 = 0;
							if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_7d6ed381220347c0b7bad07060beb773 == 0)
							{
								num2 = 0;
							}
							continue;
						}
						goto case 2;
					}
					num2 = 7;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_cb7997a2f13d4554bdeb2d98b82239ee == 0)
					{
						num2 = 7;
					}
					continue;
				case 7:
					num4 = MaxVolume;
					num2 = 8;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_96ae262178274a62bc28b3fded6ea751 != 0)
					{
						num2 = 2;
					}
					continue;
				default:
					num7++;
					goto case 1;
				case 8:
					{
						num3 = num4 ?? (-1);
						if (num3 >= 0 && num5 > (double)num3)
						{
							num2 = 4;
							continue;
						}
						goto IL_00ca;
					}
					IL_00ca:
					return num5;
				}
				break;
			}
			num5 = 0.0;
			num = 5;
		}
	}

	public override void Render(DxVisualQueue P_0)
	{
		int? num = default(int?);
		int num2;
		int num3;
		if (!base.Canvas.IsStock)
		{
			num = Filter1Min;
			if (num.HasValue)
			{
				num2 = num.GetValueOrDefault();
				goto IL_06e3;
			}
			num3 = 3;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e767fb04e1fb471592fd70a4ebcca575 == 0)
			{
				num3 = 7;
			}
		}
		else
		{
			rPQijp4K3wi(P_0);
			num3 = 36;
		}
		goto IL_0009;
		IL_0340:
		int num4 = 14;
		goto IL_0005;
		IL_01e7:
		num4 = 13;
		goto IL_0005;
		IL_06e3:
		int num5 = num2;
		num4 = 20;
		goto IL_0005;
		IL_0679:
		num2 = -1;
		goto IL_06e3;
		IL_0005:
		num3 = num4;
		goto IL_0009;
		IL_0009:
		XPen xPen = default(XPen);
		int num15 = default(int);
		double num11 = default(double);
		double y2 = default(double);
		int num17 = default(int);
		double num14 = default(double);
		int num10 = default(int);
		int index = default(int);
		IChartCluster cluster = default(IChartCluster);
		double y = default(double);
		int num16 = default(int);
		XBrush xBrush = default(XBrush);
		int num19 = default(int);
		double num13 = default(double);
		int num7 = default(int);
		int num8 = default(int);
		bool flag = default(bool);
		int num6 = default(int);
		while (true)
		{
			int num9;
			int num12;
			bool num18;
			switch (num3)
			{
			case 5:
				xPen = UwoiQGyEvVe;
				goto IL_06a5;
			case 30:
				xPen = null;
				if (num5 >= 0)
				{
					num3 = 5;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3ef08b277e78467b833a3119d7297528 != 0)
					{
						num3 = 10;
					}
					continue;
				}
				goto IL_01f5;
			case 11:
				if (!num.HasValue)
				{
					num3 = 31;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_89f5b3f1a0294191b0997cd0b778a845 == 0)
					{
						num3 = 17;
					}
					continue;
				}
				num9 = num.GetValueOrDefault();
				goto IL_074a;
			default:
				if (num15 < 1)
				{
					num11 = (int)y2 - 1;
					num15 = 1;
					num3 = 21;
					continue;
				}
				goto case 21;
			case 1:
			case 22:
				if (num17 >= 0)
				{
					num3 = 2;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_d4f77fe62e8d47b39673b4a8ce5cbdc5 != 0)
					{
						num3 = 8;
					}
					continue;
				}
				goto IL_06a5;
			case 12:
				xPen = OvZiQ0sFfNI;
				goto IL_06a5;
			case 28:
				num14 = iW0HDHeLa6LCsfDXfwDd(base.Canvas.ColumnWidth - 1.0, 1.0);
				num10 = 0;
				num3 = 9;
				continue;
			case 9:
				if (num10 >= base.Canvas.Count)
				{
					return;
				}
				index = base.Canvas.GetIndex(num10);
				cluster = base.DataProvider.GetCluster(index);
				num3 = 33;
				continue;
			case 8:
				if (cluster.Volume >= YWUuayeLfh8WiHKBlI6w(num17))
				{
					goto IL_01e7;
				}
				goto IL_06a5;
			case 19:
				num12 = -1;
				goto IL_06fa;
			case 15:
				num11 = Math.Max(num11, y);
				num3 = 6;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_90e464bd7efc478ab3dc53f1263e96d9 != 0)
				{
					num3 = 6;
				}
				continue;
			case 31:
				num9 = -1;
				goto IL_074a;
			case 10:
				if (lk9MrLeLHLMdVlLdgCmm(cluster) >= (decimal)num5 && (num16 < 0 || cluster.Volume <= (decimal)num16))
				{
					xBrush = xrGiEzZL3AO;
					num3 = 12;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_22d3e151413e4c568d725fa731c4c03c == 0)
					{
						num3 = 9;
					}
					continue;
				}
				goto IL_01f5;
			case 13:
				if (num19 < 0)
				{
					goto case 16;
				}
				if (cluster.Volume <= (decimal)num19)
				{
					num3 = 12;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_be0348d4881e4572932fccb8442b1a1a == 0)
					{
						num3 = 16;
					}
					continue;
				}
				goto IL_06a5;
			case 18:
				P_0.DrawLine(xPen, new Point(num13, num11), new Point(num13, num11 + (double)num15));
				goto case 24;
			case 21:
				if (!DeltaColored)
				{
					goto IL_0340;
				}
				num18 = goNclXeLl5oE0GxJK8s8(cluster) > 0m;
				goto IL_0767;
			case 20:
				num = Filter1Max;
				if (!num.HasValue)
				{
					num3 = 19;
					continue;
				}
				num12 = num.GetValueOrDefault();
				goto IL_06fa;
			case 36:
				return;
			case 29:
				if (!(cluster.Volume <= (decimal)num7))
				{
					goto case 1;
				}
				goto IL_0369;
			case 14:
				num18 = cluster.IsUp;
				goto IL_0767;
			case 37:
				xPen = D0hiQiSC07w;
				goto IL_06a5;
			case 35:
				xBrush = null;
				num3 = 30;
				continue;
			case 23:
				num17 = num ?? (-1);
				num3 = 17;
				continue;
			case 16:
				xBrush = UBuiQaTNvIl;
				num3 = 9;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0f9979478ba842a39155e14f5980ecce != 0)
				{
					num3 = 37;
				}
				continue;
			case 17:
				break;
			case 2:
				y = GetY((double)num8);
				y2 = GetY(0.0);
				num3 = 28;
				continue;
			case 3:
				num = Filter2Min;
				num3 = 26;
				continue;
			case 24:
			case 27:
				num10++;
				goto case 9;
			case 4:
				num13 = SuMFAMeLigRucwu7lOL0(base.Canvas, index);
				num11 = GetY(cluster.Volume);
				if (num8 >= 0)
				{
					num3 = 15;
					continue;
				}
				goto case 6;
			case 32:
				goto IL_05b4;
			case 6:
				num15 = (int)y2 - (int)num11;
				if (num15 >= 0)
				{
					num3 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_16f1ffbaff15428c840c488e7b8380f5 == 0)
					{
						num3 = 0;
					}
					continue;
				}
				goto case 24;
			case 25:
				P_0.FillRectangle(xBrush, new Rect(num13 - num14 / 2.0, num11, num14, num15));
				num3 = 24;
				continue;
			case 7:
				goto IL_0679;
			case 34:
				if (xPen != null)
				{
					num3 = 15;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_a0f7dd9205eb40fbb542085b90a19faa != 0)
					{
						num3 = 18;
					}
				}
				else
				{
					P_0.DrawLine(flag ? aeNiE7ESSNs : iPiiEPgntdU, new Point(num13, num11), new Point(num13, num11 + (double)num15));
					num3 = 27;
				}
				continue;
			case 33:
				if (cluster != null)
				{
					num3 = 4;
					continue;
				}
				goto case 24;
			case 26:
				{
					num6 = num ?? (-1);
					num7 = Filter2Max ?? (-1);
					num = Filter3Min;
					num3 = 23;
					continue;
				}
				IL_074a:
				num8 = num9;
				num3 = 2;
				continue;
				IL_06fa:
				num16 = num12;
				num3 = 3;
				continue;
				IL_01f5:
				if (num6 >= 0)
				{
					num3 = 20;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e74f04d60e394f2bbc3b9757a3df6bbb == 0)
					{
						num3 = 32;
					}
					continue;
				}
				goto case 1;
				IL_06a5:
				if (num14 > 1.0)
				{
					if (xBrush != null)
					{
						num3 = 25;
						continue;
					}
					P_0.FillRectangle(flag ? oeDiEwYIC4e : VRTiEAUOksj, new Rect(num13 - num14 / 2.0, num11, num14, num15));
					goto case 24;
				}
				goto case 34;
				IL_0767:
				flag = num18;
				num3 = 35;
				continue;
			}
			break;
			IL_05b4:
			if (lk9MrLeLHLMdVlLdgCmm(cluster) >= (decimal)num6)
			{
				if (num7 >= 0)
				{
					num3 = 29;
					continue;
				}
				goto IL_0369;
			}
			num3 = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_39ef76bd8f0947d084200e4afe419409 != 0)
			{
				num3 = 1;
			}
			continue;
			IL_0369:
			xBrush = EIoiQnL6prZ;
			num3 = 5;
		}
		num19 = Filter3Max ?? (-1);
		num = MaxVolume;
		num4 = 11;
		goto IL_0005;
	}

	public void rPQijp4K3wi(DxVisualQueue P_0)
	{
		int? num = Filter1Min;
		int num2 = num ?? (-1);
		int num3 = 10;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e9f58003753b4aa88a036bb6f675d81b != 0)
		{
			num3 = 10;
		}
		XBrush xBrush = default(XBrush);
		double x = default(double);
		double num10 = default(double);
		double num5 = default(double);
		int num6 = default(int);
		double num16 = default(double);
		double val = default(double);
		double num17 = default(double);
		IChartCluster chartCluster = default(IChartCluster);
		int num19 = default(int);
		int num15 = default(int);
		XPen xPen = default(XPen);
		int num7 = default(int);
		bool flag = default(bool);
		int index = default(int);
		int num13 = default(int);
		int num12 = default(int);
		int num4 = default(int);
		int num8 = default(int);
		while (true)
		{
			int num11;
			int num14;
			int num18;
			int num9;
			switch (num3)
			{
			case 2:
				n9Pix6eLbd8j3io8tMjI(P_0, xBrush, new Rect(x - num10 / 2.0, num5, num10, num6));
				num3 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_feff692887f143cf88657f0c72ada1e9 != 0)
				{
					num3 = 0;
				}
				break;
			case 26:
				if (!num.HasValue)
				{
					num11 = 36;
					goto IL_0005;
				}
				num14 = num.GetValueOrDefault();
				goto IL_078a;
			case 15:
				WhKiQkggcv0 = rOOij3shl8L();
				num3 = 3;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_d4f52eaa7d9d4aa09bb6fdf0b3adf8b6 != 0)
				{
					num3 = 3;
				}
				break;
			case 23:
				num16 = base.Canvas.Rect.Bottom - 2.0;
				val = num16 - num17;
				num3 = 29;
				break;
			case 12:
				if (chartCluster.Volume >= (decimal)num2)
				{
					if (num19 < 0)
					{
						goto case 18;
					}
					if (chartCluster.Volume <= (decimal)num19)
					{
						num3 = 18;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9086474a3ab6467d99a5717f01834bdb == 0)
						{
							num3 = 11;
						}
						break;
					}
				}
				goto IL_0106;
			case 7:
				xBrush = UBuiQaTNvIl;
				num3 = 14;
				break;
			case 31:
				num = Filter2Max;
				num15 = num ?? (-1);
				num3 = 9;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_22d3e151413e4c568d725fa731c4c03c != 0)
				{
					num3 = 25;
				}
				break;
			case 21:
				if (!num.HasValue)
				{
					num3 = 11;
					break;
				}
				num18 = num.GetValueOrDefault();
				goto IL_0700;
			case 6:
			case 19:
			case 30:
			case 33:
				if (num10 > 1.0)
				{
					num3 = 13;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_feff692887f143cf88657f0c72ada1e9 == 0)
					{
						num3 = 27;
					}
					break;
				}
				goto case 34;
			case 9:
				if (num15 < 0 || lk9MrLeLHLMdVlLdgCmm(chartCluster) <= (decimal)num15)
				{
					xBrush = EIoiQnL6prZ;
					xPen = UwoiQGyEvVe;
					num3 = 30;
					break;
				}
				goto IL_023f;
			case 17:
				if (num2 >= 0)
				{
					num3 = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9086474a3ab6467d99a5717f01834bdb != 0)
					{
						num3 = 12;
					}
					break;
				}
				goto IL_0106;
			case 29:
				num10 = Math.Max(base.Canvas.ColumnWidth - 1.0, 1.0);
				num3 = 15;
				break;
			case 13:
				P_0.DrawLine(xPen, new Point(x, num5), new Point(x, num5 + (double)num6));
				goto default;
			case 24:
				num = Filter2Min;
				if (!num.HasValue)
				{
					num3 = 32;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_24721d7b74cc4b6284dde0332745cd84 == 0)
					{
						num3 = 18;
					}
					break;
				}
				num9 = num.GetValueOrDefault();
				goto IL_0723;
			case 36:
				num14 = -1;
				goto IL_078a;
			case 3:
				num7 = 0;
				num3 = 16;
				break;
			case 5:
				xPen = OvZiQ0sFfNI;
				num3 = 19;
				break;
			case 10:
				num = Filter1Max;
				num3 = 21;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e416c9fc31004f3e8e23d8bbcd45f47e == 0)
				{
					num3 = 8;
				}
				break;
			case 34:
				if (xPen != null)
				{
					num11 = 13;
					goto IL_0005;
				}
				aXUeyOeLNoONaa2UFlPj(P_0, flag ? aeNiE7ESSNs : iPiiEPgntdU, new Point(x, num5), new Point(x, num5 + (double)num6));
				num3 = 28;
				break;
			case 18:
				xBrush = xrGiEzZL3AO;
				num3 = 5;
				break;
			case 11:
				num18 = -1;
				goto IL_0700;
			case 25:
				num = Filter3Min;
				num3 = 20;
				break;
			case 1:
				num17 = base.Canvas.Rect.Height * 0.2;
				num3 = 23;
				break;
			case 14:
				xPen = D0hiQiSC07w;
				num3 = 33;
				break;
			case 8:
				index = base.Canvas.GetIndex(num7);
				chartCluster = (IChartCluster)E4LyZteLoqHjX0dZYRkl(base.DataProvider, index);
				num3 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_77d26139d1074373ba3d17cb18b3ec16 == 0)
				{
					num3 = 4;
				}
				break;
			default:
				num7++;
				goto case 16;
			case 4:
				if (chartCluster != null)
				{
					x = base.Canvas.GetX(index);
					num5 = num16 - num17 * (double)chartCluster.Volume / WhKiQkggcv0;
					if (num13 >= 0)
					{
						num5 = Math.Max(num5, val);
					}
					num6 = (int)num16 - (int)num5;
					if (num6 >= 0)
					{
						flag = (DeltaColored ? R14i3BeL4dS50RerKEgl(chartCluster.Delta, 0m) : chartCluster.IsUp);
						xBrush = null;
						xPen = null;
						num3 = 12;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_2768cd202ec04d099c20ba8e1925b378 == 0)
						{
							num3 = 17;
						}
						break;
					}
				}
				goto default;
			case 22:
				num12 = Filter3Max ?? (-1);
				num = MaxVolume;
				num3 = 26;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_90e464bd7efc478ab3dc53f1263e96d9 != 0)
				{
					num3 = 14;
				}
				break;
			case 27:
				if (xBrush != null)
				{
					num3 = 2;
					break;
				}
				goto case 35;
			case 32:
				num9 = -1;
				goto IL_0723;
			case 20:
				num4 = num ?? (-1);
				num3 = 22;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_7e45d53bf40748f9915553e145413be0 != 0)
				{
					num3 = 18;
				}
				break;
			case 16:
				if (num7 >= base.Canvas.Count)
				{
					return;
				}
				goto case 8;
			case 35:
				{
					P_0.FillRectangle(flag ? oeDiEwYIC4e : VRTiEAUOksj, new Rect(x - num10 / 2.0, num5, num10, num6));
					goto default;
				}
				IL_0723:
				num8 = num9;
				num3 = 31;
				break;
				IL_078a:
				num13 = num14;
				num3 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_69212809764745e695cbac66765a5c5c != 0)
				{
					num3 = 1;
				}
				break;
				IL_0005:
				num3 = num11;
				break;
				IL_0106:
				if (num8 >= 0 && lk9MrLeLHLMdVlLdgCmm(chartCluster) >= (decimal)num8)
				{
					num11 = 9;
					goto IL_0005;
				}
				goto IL_023f;
				IL_0700:
				num19 = num18;
				num3 = 24;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_6dab837cad8c4ebe913fccce41c2f99a != 0)
				{
					num3 = 11;
				}
				break;
				IL_023f:
				if (num4 >= 0)
				{
					if (!(lk9MrLeLHLMdVlLdgCmm(chartCluster) >= (decimal)num4))
					{
						num3 = 6;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e74f04d60e394f2bbc3b9757a3df6bbb != 0)
						{
							num3 = 2;
						}
						break;
					}
					if (num12 < 0)
					{
						goto case 7;
					}
					if (wGb8QleLDKKrKHJO1Yrt(lk9MrLeLHLMdVlLdgCmm(chartCluster), num12))
					{
						num3 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_05d722d67d874d6fa7bb056304182294 == 0)
						{
							num3 = 7;
						}
						break;
					}
				}
				goto case 6;
			}
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
		string value = base.Canvas.FormatValue((double)cluster.Volume);
		if (base.Canvas.IsStock)
		{
			value = base.DataProvider.Symbol.FormatSizeShort(cluster.Volume);
		}
		list.Add(new IndicatorValueInfo(value, new XBrush(cluster.IsUp ? ChsiE8K71W3 : YBHiEJa8Qo6)));
		return list;
	}

	public override void GetLabels(ref List<IndicatorLabelInfo> P_0)
	{
		if (xhXsb0eLkJCDVBE8VWZd(base.DataProvider) <= cB1R5xeL1AsaCAEu0Hrx(base.Canvas))
		{
			return;
		}
		IChartCluster chartCluster = (IChartCluster)E4LyZteLoqHjX0dZYRkl(base.DataProvider, base.DataProvider.Count - 1 - base.Canvas.Start);
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_900fe0d7516743c1bc15292a67b06048 == 0)
		{
			num = 0;
		}
		double? position = default(double?);
		while (true)
		{
			switch (num)
			{
			case 2:
				return;
			case 1:
				if (PU3DwteL5317M2Bl8spu(base.Canvas))
				{
					position = base.Canvas.Rect.Bottom - A6xKoZeLSdZDyAJVLGWG(base.Canvas).Height * 0.2 * RixqdieLvjcu6gd1tTJn(lk9MrLeLHLMdVlLdgCmm(chartCluster)) / WhKiQkggcv0;
				}
				P_0.Add(new IndicatorLabelInfo((double)chartCluster.Volume, ORA7M5eLxtRhxJMdoHBx(chartCluster) ? ChsiE8K71W3 : YBHiEJa8Qo6, position));
				num = 2;
				continue;
			}
			if (chartCluster == null)
			{
				return;
			}
			position = null;
			num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0ab04f3efbe746ef961577ea88d00fe3 != 0)
			{
				num = 1;
			}
		}
	}

	public override bool CheckAlert(double P_0, int P_1, ref int P_2, ref double P_3)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			IChartCluster chartCluster;
			switch (num2)
			{
			case 4:
				return false;
			default:
				return false;
			case 2:
				if (base.Canvas != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_578c88adb68d4c08b45439ab0955bb9b != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 4;
			case 3:
				if (P_0 == P_3)
				{
					return false;
				}
				goto IL_006e;
			case 1:
				{
					if (!base.Canvas.IsStock)
					{
						if (base.DataProvider.Count == P_2)
						{
							num2 = 3;
							break;
						}
						goto IL_006e;
					}
					num2 = 4;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8bad63f401844feb8b319ab89401e7b9 != 0)
					{
						num2 = 4;
					}
					break;
				}
				IL_006e:
				chartCluster = (IChartCluster)E4LyZteLoqHjX0dZYRkl(base.DataProvider, xhXsb0eLkJCDVBE8VWZd(base.DataProvider) - 1);
				if (chartCluster == null)
				{
					return false;
				}
				if (!(RixqdieLvjcu6gd1tTJn(chartCluster.Volume) < P_0 - (double)P_1))
				{
					P_2 = base.DataProvider.Count;
					P_3 = P_0;
					return true;
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

	public override void ApplyColors(IChartTheme P_0)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				DownColor = vpoiTZeLexxP2ASNGBDx(P_0);
				base.ApplyColors(P_0);
				return;
			case 1:
				UpColor = DWhVCteLLiOYAHBI3dwa(P_0);
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_4c510febac3445efbec11458d423f537 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override void CopyTemplate(IndicatorBase P_0, bool P_1)
	{
		E4G9LSijJ7i0fcLYlylW e4G9LSijJ7i0fcLYlylW = (E4G9LSijJ7i0fcLYlylW)P_0;
		UpColor = eFWunYeLsT9bXDkjcPRC(e4G9LSijJ7i0fcLYlylW);
		int num = 8;
		while (true)
		{
			int num2;
			switch (num)
			{
			case 4:
				CiaiEsV0uAL.Copy((IndicatorParam<int?>)nQa6sReLcWvueCYMofOn(e4G9LSijJ7i0fcLYlylW));
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_ff7ea8439ae74c169eea85409be2ee21 != 0)
				{
					num = 0;
				}
				break;
			case 6:
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x78D396D8 ^ 0x78D303EC));
				Filter1Color = e4G9LSijJ7i0fcLYlylW.Filter1Color;
				num = 2;
				break;
			case 11:
				SCYiEGLQVbu.Copy(e4G9LSijJ7i0fcLYlylW.SCYiEGLQVbu);
				num = 7;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_86d84d52ab13483783040bb945a786b2 != 0)
				{
					num = 5;
				}
				break;
			case 5:
				Filter3Color = e4G9LSijJ7i0fcLYlylW.Filter3Color;
				Filter3Alert.Copy(e4G9LSijJ7i0fcLYlylW.Filter3Alert, !P_1);
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1522697859 ^ -1522667585));
				base.CopyTemplate(P_0, P_1);
				return;
			case 8:
				DownColor = a34AvqeLXuQtwaON6M8Y(e4G9LSijJ7i0fcLYlylW);
				num = 7;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_64274e2af1ab4c6db7e1ad660e8beb8f != 0)
				{
					num = 9;
				}
				break;
			case 3:
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-991861155 ^ -991825807));
				TtdiEWGGZBP.Copy((IndicatorParam<int?>)CwVFGKeLEaJk79sxLcBr(e4G9LSijJ7i0fcLYlylW));
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_caac71a6f9cb44c08459ac3c8bd80328 != 0)
				{
					num = 1;
				}
				break;
			case 2:
				Filter1Alert.Copy(e4G9LSijJ7i0fcLYlylW.Filter1Alert, !P_1);
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x385FFAB ^ 0x3856A3D));
				num = 2;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8df0e84d43a842eca742d74a9772b346 == 0)
				{
					num = 4;
				}
				break;
			case 10:
				Filter2Color = e4G9LSijJ7i0fcLYlylW.Filter2Color;
				Filter2Alert.Copy((ChartAlertSettings)qnVCe0eLjAeAMpCxdrkl(e4G9LSijJ7i0fcLYlylW), !P_1);
				num2 = 3;
				goto IL_0005;
			case 7:
				vXoiEajPDvT.Copy(e4G9LSijJ7i0fcLYlylW.vXoiEajPDvT);
				f3UiEb4pNbH.Copy(e4G9LSijJ7i0fcLYlylW.f3UiEb4pNbH);
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-90307782 ^ -90270170));
				num = 6;
				break;
			case 9:
				DeltaColored = e4G9LSijJ7i0fcLYlylW.DeltaColored;
				num2 = 11;
				goto IL_0005;
			case 1:
				rtXiEZGVHuA.Copy((IndicatorParam<int?>)cU45mMeLQoXrcGVyLvKx(e4G9LSijJ7i0fcLYlylW));
				OnPropertyChanged((string)eSIyi8expGoceYC4ukUo(0x6D18F862 ^ 0x6D186E2A));
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-181342698 ^ -181372810));
				num = 2;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_025edf4a83be4acb8c8326612d0fc8c2 == 0)
				{
					num = 5;
				}
				break;
			default:
				{
					SJYiEQlDnAJ.Copy(e4G9LSijJ7i0fcLYlylW.SJYiEQlDnAJ);
					OnPropertyChanged((string)eSIyi8expGoceYC4ukUo(0xAD5B8B3 ^ 0xAD52D01));
					OnPropertyChanged((string)eSIyi8expGoceYC4ukUo(-520155535 ^ -520119365));
					num = 10;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_2dae9e7b16644e7ca6575920d9bcb6e3 == 0)
					{
						num = 8;
					}
					break;
				}
				IL_0005:
				num = num2;
				break;
			}
		}
	}

	static E4G9LSijJ7i0fcLYlylW()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool SlhXwaexFmOtCnGMTfMa()
	{
		return aSxtN2exJYr1rxsBU9G0 == null;
	}

	internal static E4G9LSijJ7i0fcLYlylW YgyWSbex3He3Wxr316I6()
	{
		return aSxtN2exJYr1rxsBU9G0;
	}

	internal static object eSIyi8expGoceYC4ukUo(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static bool CUcug3exuMvdpZmn4TIl(XColor P_0, XColor P_1)
	{
		return P_0 == P_1;
	}

	internal static XColor z0M2ruexzOWZ0v5RHGe4(Color P_0)
	{
		return P_0;
	}

	internal static Color Idi9JMeL0ktlGSto6luh(byte P_0, byte P_1, byte P_2, byte P_3)
	{
		return Color.FromArgb(P_0, P_1, P_2, P_3);
	}

	internal static Color ES5Gr6eL254Q0bvRZLan()
	{
		return Colors.Orange;
	}

	internal static decimal lk9MrLeLHLMdVlLdgCmm(object P_0)
	{
		return ((IChartCluster)P_0).Volume;
	}

	internal static decimal YWUuayeLfh8WiHKBlI6w(int P_0)
	{
		return P_0;
	}

	internal static object nGu8tBeL91khmiGDdKSk(object P_0)
	{
		return ((IChartDataProvider)P_0).Symbol;
	}

	internal static bool AbXheEeLnguiggFu2jE2(decimal P_0, decimal P_1)
	{
		return P_0 >= P_1;
	}

	internal static object sP8Rx4eLGMXOtmkYlv6U(object P_0, decimal size)
	{
		return ((IChartSymbol)P_0).FormatSizeFull(size);
	}

	internal static int C8ej9meLYUShZkbWFUJ5(object P_0, int i)
	{
		return ((IChartCanvas)P_0).GetIndex(i);
	}

	internal static object E4LyZteLoqHjX0dZYRkl(object P_0, int i)
	{
		return ((IChartDataProvider)P_0).GetCluster(i);
	}

	internal static double RixqdieLvjcu6gd1tTJn(decimal P_0)
	{
		return (double)P_0;
	}

	internal static int oWIIIdeLBgYxCddY8l7W(object P_0)
	{
		return ((IChartCanvas)P_0).Count;
	}

	internal static double iW0HDHeLa6LCsfDXfwDd(double P_0, double P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static double SuMFAMeLigRucwu7lOL0(object P_0, int i)
	{
		return ((IChartCanvas)P_0).GetX(i);
	}

	internal static decimal goNclXeLl5oE0GxJK8s8(object P_0)
	{
		return ((IChartCluster)P_0).Delta;
	}

	internal static bool R14i3BeL4dS50RerKEgl(decimal P_0, decimal P_1)
	{
		return P_0 > P_1;
	}

	internal static bool wGb8QleLDKKrKHJO1Yrt(decimal P_0, decimal P_1)
	{
		return P_0 <= P_1;
	}

	internal static void n9Pix6eLbd8j3io8tMjI(object P_0, object P_1, Rect P_2)
	{
		((DxVisualQueue)P_0).FillRectangle((XBrush)P_1, P_2);
	}

	internal static void aXUeyOeLNoONaa2UFlPj(object P_0, object P_1, Point P_2, Point P_3)
	{
		((DxVisualQueue)P_0).DrawLine((XPen)P_1, P_2, P_3);
	}

	internal static int xhXsb0eLkJCDVBE8VWZd(object P_0)
	{
		return ((IChartDataProvider)P_0).Count;
	}

	internal static int cB1R5xeL1AsaCAEu0Hrx(object P_0)
	{
		return ((IChartCanvas)P_0).Start;
	}

	internal static bool PU3DwteL5317M2Bl8spu(object P_0)
	{
		return ((IChartCanvas)P_0).IsStock;
	}

	internal static Rect A6xKoZeLSdZDyAJVLGWG(object P_0)
	{
		return ((IChartCanvas)P_0).Rect;
	}

	internal static bool ORA7M5eLxtRhxJMdoHBx(object P_0)
	{
		return ((IChartCluster)P_0).IsUp;
	}

	internal static XColor DWhVCteLLiOYAHBI3dwa(object P_0)
	{
		return ((IChartTheme)P_0).PaletteColor6;
	}

	internal static XColor vpoiTZeLexxP2ASNGBDx(object P_0)
	{
		return ((IChartTheme)P_0).PaletteColor7;
	}

	internal static XColor eFWunYeLsT9bXDkjcPRC(object P_0)
	{
		return ((E4G9LSijJ7i0fcLYlylW)P_0).UpColor;
	}

	internal static XColor a34AvqeLXuQtwaON6M8Y(object P_0)
	{
		return ((E4G9LSijJ7i0fcLYlylW)P_0).DownColor;
	}

	internal static object nQa6sReLcWvueCYMofOn(object P_0)
	{
		return ((E4G9LSijJ7i0fcLYlylW)P_0).CiaiEsV0uAL;
	}

	internal static object qnVCe0eLjAeAMpCxdrkl(object P_0)
	{
		return ((E4G9LSijJ7i0fcLYlylW)P_0).Filter2Alert;
	}

	internal static object CwVFGKeLEaJk79sxLcBr(object P_0)
	{
		return ((E4G9LSijJ7i0fcLYlylW)P_0).TtdiEWGGZBP;
	}

	internal static object cU45mMeLQoXrcGVyLvKx(object P_0)
	{
		return ((E4G9LSijJ7i0fcLYlylW)P_0).rtXiEZGVHuA;
	}
}
