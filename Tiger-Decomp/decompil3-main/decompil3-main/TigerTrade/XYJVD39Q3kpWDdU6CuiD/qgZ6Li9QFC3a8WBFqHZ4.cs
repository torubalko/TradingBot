using System.ComponentModel;
using System.Runtime.Serialization;
using System.Windows.Media;
using ECOEgqlSad8NUJZ2Dr9n;
using LyhxtU2baEmYGKCYg2dY;
using MIA3eC2ZXsuRyAB0mjn;
using O4MOGg9s9Mb8ki42CBMv;
using TiCeIH2IsQBNx4GCkaT;
using TigerTrade.Chart.Clusters.Enums;
using TigerTrade.Dx;
using TigerTrade.Properties;
using TU1GsM2Dm9QaIaTGcmUQ;
using TuAMtrl1Nd3XoZQQUXf0;

namespace XYJVD39Q3kpWDdU6CuiD;

[DataContract(Name = "ChartClusterFilter", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Settings")]
[ReadOnly(true)]
[TypeConverter(typeof(ExpandableObjectConverter))]
internal sealed class qgZ6Li9QFC3a8WBFqHZ4 : VUcpcX9sfGdSlTmYZQvV
{
	private ClusterFilterType A0K9dNXgnnW;

	private jePqt32bBmSdvMA1gTDC uja9dklqpGn;

	private jePqt32bBmSdvMA1gTDC BtY9d1j3rFo;

	private XColor lSZ9d5yvBwA;

	private XColor crQ9dSYgu7C;

	private static qgZ6Li9QFC3a8WBFqHZ4 gkZ5pEbEzjLxDYYmgyAu;

	[bBo0Zd2ycQQr3LNHQf4("ChartClusterFilterType")]
	[T4IXj62qBfXCaxs2RI5("ChartClusterFilter")]
	[DefaultValue(ClusterFilterType.Volume)]
	[NotifyParentProperty(true)]
	[DataMember(Name = "FilterType")]
	public ClusterFilterType FilterType
	{
		get
		{
			return A0K9dNXgnnW;
		}
		set
		{
			if (clusterFilterType != A0K9dNXgnnW)
			{
				A0K9dNXgnnW = clusterFilterType;
				sQM9sYVV4VP(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--500511424 ^ 0x1DD1518E));
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8692846774e94af58ff2b2b243743e02 == 0)
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

	[DataMember(Name = "MinValueParam")]
	public jePqt32bBmSdvMA1gTDC zdY9dnPK7Yd
	{
		get
		{
			return uja9dklqpGn ?? (uja9dklqpGn = new jePqt32bBmSdvMA1gTDC(null));
		}
		set
		{
			uja9dklqpGn = jePqt32bBmSdvMA1gTDC;
		}
	}

	[T4IXj62qBfXCaxs2RI5("ChartClusterFilter")]
	[DefaultValue(null)]
	[NotifyParentProperty(true)]
	[bBo0Zd2ycQQr3LNHQf4("ChartClusterFilterMinValue")]
	public long? MinValue
	{
		get
		{
			return zdY9dnPK7Yd.Jva2DwEHfew(base.d8J9slSlLBq);
		}
		set
		{
			if (zdY9dnPK7Yd.GhN2biFSQFS(base.d8J9slSlLBq, num, 0L))
			{
				sQM9sYVV4VP(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x2D3134C9 ^ 0x2D31B07B));
			}
		}
	}

	[DataMember(Name = "MaxValueParam")]
	public jePqt32bBmSdvMA1gTDC EGr9dB8r7xb
	{
		get
		{
			return BtY9d1j3rFo ?? (BtY9d1j3rFo = new jePqt32bBmSdvMA1gTDC(null));
		}
		set
		{
			BtY9d1j3rFo = btY9d1j3rFo;
		}
	}

	[DefaultValue(null)]
	[NotifyParentProperty(true)]
	[T4IXj62qBfXCaxs2RI5("ChartClusterFilter")]
	[bBo0Zd2ycQQr3LNHQf4("ChartClusterFilterMaxValue")]
	public long? MaxValue
	{
		get
		{
			return EGr9dB8r7xb.Jva2DwEHfew(base.d8J9slSlLBq);
		}
		set
		{
			if (EGr9dB8r7xb.GhN2biFSQFS(base.d8J9slSlLBq, num, 0L))
			{
				sQM9sYVV4VP(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x9F0F634 ^ 0x9F4C006));
			}
		}
	}

	[bBo0Zd2ycQQr3LNHQf4("ChartClusterFilterBackColor")]
	[DataMember(Name = "BackColor")]
	[T4IXj62qBfXCaxs2RI5("ChartClusterFilter")]
	public XColor BackColor
	{
		get
		{
			return lSZ9d5yvBwA;
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
					if (KjTRqgbQHmX4LK3qhtLA(xColor, lSZ9d5yvBwA))
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cf96ea40632b4cc9a71884e2b5dceb8b != 0)
						{
							num2 = 0;
						}
						break;
					}
					lSZ9d5yvBwA = xColor;
					sQM9sYVV4VP(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-123775059 ^ -123747321));
					return;
				case 0:
					return;
				}
			}
		}
	}

	[DataMember(Name = "TextColor")]
	[bBo0Zd2ycQQr3LNHQf4("ChartClusterFilterTextColor")]
	[T4IXj62qBfXCaxs2RI5("ChartClusterFilter")]
	public XColor TextColor
	{
		get
		{
			return crQ9dSYgu7C;
		}
		set
		{
			if (!(xColor == crQ9dSYgu7C))
			{
				crQ9dSYgu7C = xColor;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ac6a9a8fc5c94cd6833091a6efebb474 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				sQM9sYVV4VP(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1736566656 ^ -1736537280));
			}
		}
	}

	public qgZ6Li9QFC3a8WBFqHZ4()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		FilterType = ClusterFilterType.None;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ba87d68105604f98a891a0549ef4b7f9 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				TextColor = Colors.White;
				return;
			}
			BackColor = Colors.Orange;
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2fa91f76013747d9b5f0073a2a323201 == 0)
			{
				num = 1;
			}
		}
	}

	public qgZ6Li9QFC3a8WBFqHZ4(qgZ6Li9QFC3a8WBFqHZ4 P_0, bool P_1)
	{
		dy1EywbQfU5sBq8aSluQ();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_26fe5531b15948b7a2b6ffb2cd927204 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		Tu79QzrdgrL(P_0, P_1);
	}

	public qgZ6Li9QFC3a8WBFqHZ4(qgZ6Li9QFC3a8WBFqHZ4 P_0)
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		N8Y9d0busYm(P_0);
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_426282f87bb443dbbfe9ea3327b81bb7 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public void Ka79Qp0HjOa(string P_0)
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
				if (!(base.d8J9slSlLBq == P_0))
				{
					base.d8J9slSlLBq = P_0;
					yMF9QuEIZyZ();
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fce1ea768b8d4ccdb3b71310761c1e52 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void yMF9QuEIZyZ()
	{
		sQM9sYVV4VP(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1325234765 ^ -1325268735));
		sQM9sYVV4VP(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x11D1040B ^ 0x11D53239));
	}

	private void Tu79QzrdgrL(qgZ6Li9QFC3a8WBFqHZ4 P_0, bool P_1)
	{
		FilterType = P_0.FilterType;
		int num;
		if (!P_1)
		{
			num = 2;
			goto IL_0009;
		}
		goto IL_0075;
		IL_0075:
		zdY9dnPK7Yd.QSM2D8R8ont((NeyDU62DKFU8Qyxyvfd6<long?>)Tl2EmdbQ9rteo9IPH6bO(P_0), _0020: true);
		int num2 = 3;
		num = num2;
		goto IL_0009;
		IL_0009:
		while (true)
		{
			switch (num)
			{
			case 2:
				MinValue = P_0.zdY9dnPK7Yd.Value;
				MaxValue = P_0.EGr9dB8r7xb.Value;
				goto case 1;
			case 3:
				EGr9dB8r7xb.QSM2D8R8ont(P_0.EGr9dB8r7xb, _0020: true);
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1a625a5fe3334df88082832236dff5be == 0)
				{
					num = 1;
				}
				continue;
			case 1:
				BackColor = P_0.BackColor;
				TextColor = G9uPFwbQnafGdwgsOS8l(P_0);
				yMF9QuEIZyZ();
				return;
			}
			break;
		}
		goto IL_0075;
	}

	private void N8Y9d0busYm(qgZ6Li9QFC3a8WBFqHZ4 P_0)
	{
		FilterType = P_0.FilterType;
		zdY9dnPK7Yd.QSM2D8R8ont(P_0.zdY9dnPK7Yd);
		EGr9dB8r7xb.QSM2D8R8ont(P_0.EGr9dB8r7xb);
		BackColor = P_0.BackColor;
		TextColor = P_0.TextColor;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a337f255b1bd4e8290c28001e28630dc == 0)
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
			yMF9QuEIZyZ();
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2264c03640a14c8f930261fd70e85d60 == 0)
			{
				num = 1;
			}
		}
	}

	public override string ToString()
	{
		if (FilterType != ClusterFilterType.None)
		{
			long? num = MinValue;
			int num2 = 3;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dd6de048cd134da6b2674c002762ca45 == 0)
			{
				num2 = 1;
			}
			string text2 = default(string);
			string text = default(string);
			while (true)
			{
				switch (num2)
				{
				case 2:
					break;
				case 1:
				{
					string text3;
					if (!num.HasValue)
					{
						text3 = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-60853733 ^ -60878663);
					}
					else
					{
						num = MaxValue;
						text3 = num.ToString();
					}
					text2 = text3;
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d49d1aa54d194934871b103e21669e22 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				case 4:
					num = MaxValue;
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03c20a54a7dc45f8a5130d4984fa4aea != 0)
					{
						num2 = 5;
					}
					continue;
				case 5:
					if (!num.HasValue)
					{
						num2 = 2;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_08ac0ac701064383a00c80bff8cd4e3f == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto IL_004b;
				case 3:
					if (!num.HasValue)
					{
						num2 = 4;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0fb8c8dbf8424ce68f439b7b66291a33 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto IL_004b;
				default:
					{
						return (string)YvMpk2bQoTgfVa0aB2lN(H1ludSbQYkZyp3g6t9bW(-90307782 ^ -90546084), FilterType, text, text2);
					}
					IL_004b:
					text = (string)(MinValue.HasValue ? MinValue.ToString() : H1ludSbQYkZyp3g6t9bW(0x6EC99CAF ^ 0x6EC9A1B9));
					num = MaxValue;
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2aa1113717a74eb69caa8952fdc78508 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			}
		}
		return (string)y3e3bsbQGpe4lTRE0xOs();
	}

	static qgZ6Li9QFC3a8WBFqHZ4()
	{
		hUf9IvbQvpM5FUq1fXNj();
	}

	internal static bool Aon01GbQ0a9JMk11MsAH()
	{
		return gkZ5pEbEzjLxDYYmgyAu == null;
	}

	internal static qgZ6Li9QFC3a8WBFqHZ4 Toyn7RbQ2f3nbE1re8sp()
	{
		return gkZ5pEbEzjLxDYYmgyAu;
	}

	internal static bool KjTRqgbQHmX4LK3qhtLA(XColor P_0, XColor P_1)
	{
		return P_0 == P_1;
	}

	internal static void dy1EywbQfU5sBq8aSluQ()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static object Tl2EmdbQ9rteo9IPH6bO(object P_0)
	{
		return ((qgZ6Li9QFC3a8WBFqHZ4)P_0).zdY9dnPK7Yd;
	}

	internal static XColor G9uPFwbQnafGdwgsOS8l(object P_0)
	{
		return ((qgZ6Li9QFC3a8WBFqHZ4)P_0).TextColor;
	}

	internal static object y3e3bsbQGpe4lTRE0xOs()
	{
		return Resources.ChartClusterFilterDisabled;
	}

	internal static object H1ludSbQYkZyp3g6t9bW(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static object YvMpk2bQoTgfVa0aB2lN(object P_0, object P_1, object P_2, object P_3)
	{
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	internal static void hUf9IvbQvpM5FUq1fXNj()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}
}
