using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Windows;
using System.Windows.Media;
using ECOEgqlSad8NUJZ2Dr9n;
using MIA3eC2ZXsuRyAB0mjn;
using TiCeIH2IsQBNx4GCkaT;
using TigerTrade.Chart.Indicators.Common;
using TigerTrade.Chart.Indicators.Enums;
using TigerTrade.Dx;
using TuAMtrl1Nd3XoZQQUXf0;

namespace QK4v3I9tXmho6PtyB6HP;

[DataContract(Name = "GradientIndicator", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
[Indicator("Gradient", "Gradient", true, Type = typeof(v9dTW69tsmS6DQKXAlcW))]
internal sealed class v9dTW69tsmS6DQKXAlcW : IndicatorBase
{
	[CompilerGenerated]
	private XBrush xMg9tIG9TT4;

	private XColor fOV9tW0q2kG;

	[CompilerGenerated]
	private XBrush dqG9ttAAimv;

	private XColor oZh9tUTNRSN;

	internal static v9dTW69tsmS6DQKXAlcW TVQjQGbqmNLJVFpQGenf;

	[Browsable(false)]
	private XBrush OH39tQnXw8S
	{
		[CompilerGenerated]
		get
		{
			return xMg9tIG9TT4;
		}
		[CompilerGenerated]
		set
		{
			xMg9tIG9TT4 = xBrush;
		}
	}

	[bBo0Zd2ycQQr3LNHQf4("ChartIndicatorsTopColor")]
	[T4IXj62qBfXCaxs2RI5("ChartIndicatorsStyle")]
	[DataMember(Name = "TopColor")]
	public XColor TopColor
	{
		get
		{
			return fOV9tW0q2kG;
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
					if (!(xColor == fOV9tW0q2kG))
					{
						num2 = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7d3c6a8bf09f4ec887f577858231a719 != 0)
						{
							num2 = 1;
						}
						break;
					}
					return;
				default:
					BID8i4bq8M8k2Ny2FGty(this, rwM8F4bq7MV52A6QnHX9(-1878953018 ^ -1878715288));
					return;
				case 1:
					fOV9tW0q2kG = xColor;
					OH39tQnXw8S = new XBrush(fOV9tW0q2kG);
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7573e3aca29a46a9959af01ed2386da5 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[Browsable(false)]
	private XBrush Mf09tMjd0xW
	{
		[CompilerGenerated]
		get
		{
			return dqG9ttAAimv;
		}
		[CompilerGenerated]
		set
		{
			dqG9ttAAimv = xBrush;
		}
	}

	[DataMember(Name = "BottomColor")]
	[T4IXj62qBfXCaxs2RI5("ChartIndicatorsStyle")]
	[bBo0Zd2ycQQr3LNHQf4("ChartIndicatorsBottomColor")]
	public XColor BottomColor
	{
		get
		{
			return oZh9tUTNRSN;
		}
		set
		{
			if (kAEC4ZbqA8I2puFkWlhj(xColor, oZh9tUTNRSN))
			{
				return;
			}
			oZh9tUTNRSN = xColor;
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5dcb5c2a8274adf87bda91d76616538 != 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0xECA3F28 ^ 0xECE58EA));
					return;
				}
				Mf09tMjd0xW = new XBrush(oZh9tUTNRSN);
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d4c083a65c1546b8a09c928a8c95e140 != 0)
				{
					num = 1;
				}
			}
		}
	}

	[Browsable(false)]
	public override bool ShowIndicatorValues => false;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.Bar;

	[Browsable(false)]
	public override bool ShowIndicatorLabels => false;

	[Browsable(false)]
	public override IndicatorCalculation Calculation => IndicatorCalculation.OnEachTick;

	public v9dTW69tsmS6DQKXAlcW()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		ShowIndicatorTitle = false;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3023bd6c0f7846878513499bf5c36161 != 0)
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
			TopColor = Color.FromArgb(byte.MaxValue, 0, 50, 100);
			BottomColor = Colors.Black;
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f6b8a9ae320a40f994b0db08d42c2a95 != 0)
			{
				num = 0;
			}
		}
	}

	protected override void Execute()
	{
	}

	public void lEU9tcrbHYK(DxVisualQueue P_0, Rect P_1)
	{
		if (TopColor != BottomColor)
		{
			P_0.FillGradientRectangle(OH39tQnXw8S, Mf09tMjd0xW, 0, P_1);
			return;
		}
		P_0.FillRectangle(OH39tQnXw8S, P_1);
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a80f370f27d471fab60f042c9fa7b49 != 0)
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
		int num = 1;
		int num2 = num;
		v9dTW69tsmS6DQKXAlcW v9dTW69tsmS6DQKXAlcW2 = default(v9dTW69tsmS6DQKXAlcW);
		while (true)
		{
			switch (num2)
			{
			default:
				TopColor = IXtJ88bqPbyFDxd7i71G(v9dTW69tsmS6DQKXAlcW2);
				BottomColor = v9dTW69tsmS6DQKXAlcW2.BottomColor;
				base.CopyTemplate(P_0, P_1);
				return;
			case 1:
				v9dTW69tsmS6DQKXAlcW2 = (v9dTW69tsmS6DQKXAlcW)P_0;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f027e87a9f614f4a92c0338386fb11cd == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override object Clone()
	{
		v9dTW69tsmS6DQKXAlcW obj = new v9dTW69tsmS6DQKXAlcW();
		obj.CopyTemplate(this, _0020: true);
		return obj;
	}

	static v9dTW69tsmS6DQKXAlcW()
	{
		lo9knebqJfGltZulnmXM();
	}

	internal static bool UO8XSdbqhstLgQdSn8to()
	{
		return TVQjQGbqmNLJVFpQGenf == null;
	}

	internal static v9dTW69tsmS6DQKXAlcW kU7b9Cbqw3iLryKCwrxD()
	{
		return TVQjQGbqmNLJVFpQGenf;
	}

	internal static object rwM8F4bq7MV52A6QnHX9(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static void BID8i4bq8M8k2Ny2FGty(object P_0, object P_1)
	{
		((IndicatorBase)P_0).OnPropertyChanged((string)P_1);
	}

	internal static bool kAEC4ZbqA8I2puFkWlhj(XColor P_0, XColor P_1)
	{
		return P_0 == P_1;
	}

	internal static XColor IXtJ88bqPbyFDxd7i71G(object P_0)
	{
		return ((v9dTW69tsmS6DQKXAlcW)P_0).TopColor;
	}

	internal static void lo9knebqJfGltZulnmXM()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}
}
