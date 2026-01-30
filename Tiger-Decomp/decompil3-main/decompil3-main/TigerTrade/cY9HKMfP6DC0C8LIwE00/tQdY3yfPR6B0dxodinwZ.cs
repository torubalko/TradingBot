using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Windows.Media;
using ECOEgqlSad8NUJZ2Dr9n;
using MIA3eC2ZXsuRyAB0mjn;
using NHkZqbf77HnCtq0ER8ta;
using TiCeIH2IsQBNx4GCkaT;
using TigerTrade.Chart.Alerts;
using TigerTrade.Dx;
using TigerTrade.Dx.Enums;
using TuAMtrl1Nd3XoZQQUXf0;

namespace cY9HKMfP6DC0C8LIwE00;

[DataContract(Name = "SignalPriceLevel", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Market.Common")]
internal class tQdY3yfPR6B0dxodinwZ : BpmEftf7wYbuVebk5Vku
{
	[CompilerGenerated]
	private bool Uy2fPwqprQ3;

	[CompilerGenerated]
	private XBrush ExBfP7i5BhL;

	[CompilerGenerated]
	private XPen leCfP8LCLmT;

	private XColor fOhfPADF5S9;

	[Browsable(false)]
	[DataMember(Name = "InactiveAlertLineColor")]
	public XColor LQ9fPPPgkL3;

	private ChartAlertSettings qkrfPJV8ZvX;

	internal static tQdY3yfPR6B0dxodinwZ N9OAt5bisAucgmTg0dQE;

	[Browsable(false)]
	[DataMember(Name = "IsDomLevel")]
	public bool YNJfPtJgce2
	{
		[CompilerGenerated]
		get
		{
			return Uy2fPwqprQ3;
		}
		[CompilerGenerated]
		set
		{
			Uy2fPwqprQ3 = uy2fPwqprQ;
		}
	}

	[Browsable(false)]
	public XBrush CsDfPysycdF
	{
		[CompilerGenerated]
		get
		{
			return ExBfP7i5BhL;
		}
		[CompilerGenerated]
		private set
		{
			ExBfP7i5BhL = exBfP7i5BhL;
		}
	}

	[Browsable(false)]
	public XPen IIHfPCpksB7
	{
		[CompilerGenerated]
		get
		{
			return leCfP8LCLmT;
		}
		[CompilerGenerated]
		private set
		{
			leCfP8LCLmT = xPen;
		}
	}

	[T4IXj62qBfXCaxs2RI5("PriceLevelStyle")]
	[bBo0Zd2ycQQr3LNHQf4("ActiveAlertPriceLevelLineColor")]
	[DataMember(Name = "ActiveAlertLineColor")]
	public XColor ActiveAlertLineColor
	{
		get
		{
			return fOhfPADF5S9;
		}
		set
		{
			if (xColor == fOhfPADF5S9)
			{
				return;
			}
			fOhfPADF5S9 = xColor;
			CsDfPysycdF = new XBrush(xColor);
			IIHfPCpksB7 = new XPen(CsDfPysycdF, base.LineWidth, base.LineStyle);
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8b6bac13ae314900826ed96af7afc27b != 0)
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
					W5Wf7JieErq(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--500511424 ^ 0x1DD105F6));
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b17e829e94d54e7b87d666edd5b38bcd != 0)
					{
						num = 0;
					}
					break;
				}
			}
		}
	}

	[DataMember(Name = "Alert")]
	[Browsable(false)]
	public ChartAlertSettings Alert
	{
		get
		{
			if (qkrfPJV8ZvX == null)
			{
				qkrfPJV8ZvX = new ChartAlertSettings();
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d9af442440454effa9efd8da8e33ec96 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				qkrfPJV8ZvX.PropertyChanged += a6lfPMeWDFp;
			}
			return qkrfPJV8ZvX;
		}
		set
		{
			if (S1aRcjbijuR6SAZiQQnD(chartAlertSettings, qkrfPJV8ZvX))
			{
				return;
			}
			int num2;
			if (qkrfPJV8ZvX != null)
			{
				int num = 2;
				num2 = num;
				goto IL_0009;
			}
			goto IL_006c;
			IL_0009:
			while (true)
			{
				switch (num2)
				{
				case 2:
					break;
				case 1:
					OWpQ5WbiQi6qQlUxopqu(qkrfPJV8ZvX, new PropertyChangedEventHandler(a6lfPMeWDFp));
					goto IL_00a9;
				default:
					{
						if (qkrfPJV8ZvX != null)
						{
							num2 = 1;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e38cca27b4f843e0acda58c2d2606b17 != 0)
							{
								num2 = 1;
							}
							continue;
						}
						goto IL_00a9;
					}
					IL_00a9:
					W5Wf7JieErq(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1047165041 ^ -1047416465));
					return;
				}
				break;
			}
			SIfJxSbiElhoLVbphwfS(qkrfPJV8ZvX, new PropertyChangedEventHandler(a6lfPMeWDFp));
			goto IL_006c;
			IL_006c:
			qkrfPJV8ZvX = chartAlertSettings;
			num2 = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_43d123ebfe574af38268397bb0ae2d1a != 0)
			{
				num2 = 0;
			}
			goto IL_0009;
		}
	}

	private void a6lfPMeWDFp(object P_0, PropertyChangedEventArgs P_1)
	{
		W5Wf7JieErq(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x446AB724 ^ 0x446E81C4));
	}

	public tQdY3yfPR6B0dxodinwZ()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		ActiveAlertLineColor = Colors.CornflowerBlue;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_84569ba2345a4be7ac2af6ab5d67eaf9 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	protected override void S8Ul9MSCTAl(int P_0, XDashStyle P_1)
	{
		base.S8Ul9MSCTAl(P_0, P_1);
		IIHfPCpksB7 = new XPen(CsDfPysycdF, P_0, P_1);
	}

	[OnDeserializing]
	private void hyhfPOVnH3Z(StreamingContext P_0)
	{
		BC0f78qnRkO(P_0);
		LQ9fPPPgkL3 = EaTYjsbid1smfNEAabuf();
		ActiveAlertLineColor = EaTYjsbid1smfNEAabuf();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dd6de048cd134da6b2674c002762ca45 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	[OnDeserialized]
	private void iGdfPq8PEMn(StreamingContext P_0)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (ActiveAlertLineColor == EaTYjsbid1smfNEAabuf())
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dfd8fb340d494755970617a38d3a8729 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			case 2:
				break;
			default:
				ActiveAlertLineColor = base.LineColor;
				if (LQ9fPPPgkL3 != XColor.IncorrectValue)
				{
					base.LineColor = LQ9fPPPgkL3;
					num2 = 2;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a057f43d61f46eca6f419bc48c31d04 != 0)
					{
						num2 = 2;
					}
					continue;
				}
				break;
			}
			break;
		}
		if (osIAAnbigen9D9rZ9XIr(LQ9fPPPgkL3, EaTYjsbid1smfNEAabuf()))
		{
			LQ9fPPPgkL3 = base.LineColor;
		}
	}

	protected override long mIjl9ITKC93()
	{
		return base.mIjl9ITKC93() + Alert.GetHashCode() + ActiveAlertLineColor.GetHashCode() + (YNJfPtJgce2 ? 1 : 2);
	}

	public override object Clone()
	{
		tQdY3yfPR6B0dxodinwZ obj = (tQdY3yfPR6B0dxodinwZ)MemberwiseClone();
		S6jQUlbiRVdFXZb4enu5(obj, Alert?.Clone());
		return obj;
	}

	static tQdY3yfPR6B0dxodinwZ()
	{
		XNPbcpbi66gRgpIU9yTr();
	}

	internal static bool jNbhQibiXnsHtsRSRc45()
	{
		return N9OAt5bisAucgmTg0dQE == null;
	}

	internal static tQdY3yfPR6B0dxodinwZ Y0uNsmbicCTM95FxdCpX()
	{
		return N9OAt5bisAucgmTg0dQE;
	}

	internal static bool S1aRcjbijuR6SAZiQQnD(object P_0, object P_1)
	{
		return object.Equals(P_0, P_1);
	}

	internal static void SIfJxSbiElhoLVbphwfS(object P_0, object P_1)
	{
		((ChartAlertSettings)P_0).PropertyChanged -= (PropertyChangedEventHandler)P_1;
	}

	internal static void OWpQ5WbiQi6qQlUxopqu(object P_0, object P_1)
	{
		((ChartAlertSettings)P_0).PropertyChanged += (PropertyChangedEventHandler)P_1;
	}

	internal static XColor EaTYjsbid1smfNEAabuf()
	{
		return XColor.IncorrectValue;
	}

	internal static bool osIAAnbigen9D9rZ9XIr(XColor P_0, XColor P_1)
	{
		return P_0 == P_1;
	}

	internal static void S6jQUlbiRVdFXZb4enu5(object P_0, object P_1)
	{
		((tQdY3yfPR6B0dxodinwZ)P_0).Alert = (ChartAlertSettings)P_1;
	}

	internal static void XNPbcpbi66gRgpIU9yTr()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}
}
