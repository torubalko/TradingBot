using System;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using aEpmU09nz6MEoNmc0pGJ;
using aeXChk9vAhkf7Zm8SpOk;
using AQB6mgf3wjOUxVfiEwwS;
using Bs9FfLq8LSV7wJhpolq;
using ECOEgqlSad8NUJZ2Dr9n;
using Fb8gFFHFUNPFVH1wej60;
using ft4IOl2kyqsXh3EvCREm;
using GP64KY3CUHG3w1gmqm1;
using q6Lcl3fBRQ8ycXy3QOHi;
using reuqbSHkyZtO3nPa1eKn;
using TigerTrade.Chart.Base;
using TigerTrade.Core.UI.Commands;
using TigerTrade.Market.Settings;
using TigerTrade.Tc.Data;
using TigerTrade.UI.DocControls.Common.Link;
using TigerTrade.UI.DocControls.Trading.Settings;
using TuAMtrl1Nd3XoZQQUXf0;
using uZqyk925mKGgabaJGJq6;
using v0gxFx27QfQao4Ot85dR;
using Wjaa7Lf712MotgnJ6D5Q;

namespace CrFtHPuvP7Ob5vDkI3B;

internal sealed class lFstfvuoXTH8701fWFf : xRgq7gHkTVINiHGAKc0y
{
	[Serializable]
	[CompilerGenerated]
	private sealed class vJM9QGnQyy0hEuXyg9Ll
	{
		public static readonly vJM9QGnQyy0hEuXyg9Ll bbBnQVCLbbh;

		public static Func<E6bgtHf7k2xZ0cuqWjOq, int> AqinQCEQyYY;

		private static vJM9QGnQyy0hEuXyg9Ll jFRHHkNlQ8P6s3aT4Kj3;

		static vJM9QGnQyy0hEuXyg9Ll()
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
					bbBnQVCLbbh = new vJM9QGnQyy0hEuXyg9Ll();
					return;
				case 1:
					sZvdQdNlRqn8hMEFnlVK();
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9cec884f01d949d294f11a9fcceef609 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		public vJM9QGnQyy0hEuXyg9Ll()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			base._002Ector();
		}

		internal int yhBnQZAgAeO(E6bgtHf7k2xZ0cuqWjOq c)
		{
			return c.Value;
		}

		internal static void sZvdQdNlRqn8hMEFnlVK()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}

		internal static bool qxElaMNldbq8mTbOoMWU()
		{
			return jFRHHkNlQ8P6s3aT4Kj3 == null;
		}

		internal static vJM9QGnQyy0hEuXyg9Ll uceZHiNlgo4f0Y0aDrNV()
		{
			return jFRHHkNlQ8P6s3aT4Kj3;
		}
	}

	[CompilerGenerated]
	private readonly TradingSettings Alsuhj71OP;

	private readonly jup2YO3VI1WuSPZJgwh myeuwh1NQI;

	private bool Hkqu737KRW;

	private bool s0Mu8xwitV;

	private bool PNduAJwlTW;

	private bool gXCuPlS3Fj;

	private DataCycle ocvuJfUVAS;

	private int MRQuFi1UnW;

	private ICommand y7Bu3LCBWx;

	private bool ntiupoGENk;

	private static lFstfvuoXTH8701fWFf fjJo5c4ExmLN3xtWolI9;

	public TradingSettings Settings
	{
		[CompilerGenerated]
		get
		{
			return Alsuhj71OP;
		}
	}

	public string CurrentSize
	{
		get
		{
			int num = 2;
			int num2 = num;
			string text = default(string);
			while (true)
			{
				switch (num2)
				{
				default:
					return string.Format(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-176525661 ^ -176492767) + text + (string)RRQtlg4EQgKimTx3SLj6(0x706541F3 ^ 0x7065C07F), N3sX4B4EIGcdhyA4UAwZ(fXETiE4EqAcArnvQKEvd(Settings.MarketSettings)));
				case 1:
					text = McPEV4q7m2685kMvrQH.bR1qJgPHqX(TIOkRY4EO1oJmnJJ1ARo(j18iDj9nukSCmEyZs5lH.Settings), _0020: false);
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6d472511f0d246a693dc7622dda5f390 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					if (!((MarketSettings)nwFL984Egvm73R658dx9(Settings)).ExecuteInQuoteCurrency)
					{
						if (Settings.MarketSettings.ExecuteInPercents)
						{
							return ((MarketSettings)nwFL984Egvm73R658dx9(Settings)).CurrentPreset.PercentSize.ToString(CultureInfo.InvariantCulture);
						}
						return Tm9bw04EWxf7cIUf3ZLO(((MarketSettings)nwFL984Egvm73R658dx9(Settings)).CurrentPreset.Size).ToString(CultureInfo.InvariantCulture);
					}
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a337f255b1bd4e8290c28001e28630dc != 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}
	}

	public bool IsDomToolBarsVisible
	{
		get
		{
			return Hkqu737KRW;
		}
		private set
		{
			if (flag != Hkqu737KRW)
			{
				Hkqu737KRW = flag;
				JZYHkZsWiJ6(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x32DEA4F1 ^ 0x32DE24E1));
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0fb8c8dbf8424ce68f439b7b66291a33 == 0)
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

	public bool TakeProfitIsChecked
	{
		get
		{
			return s0Mu8xwitV;
		}
		set
		{
			if (flag != s0Mu8xwitV)
			{
				s0Mu8xwitV = flag;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5dcb5c2a8274adf87bda91d76616538 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				JZYHkZsWiJ6((string)RRQtlg4EQgKimTx3SLj6(0x706541F3 ^ 0x7065C061));
			}
		}
	}

	public bool StopLossIsChecked
	{
		get
		{
			return PNduAJwlTW;
		}
		set
		{
			if (flag != PNduAJwlTW)
			{
				PNduAJwlTW = flag;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6d472511f0d246a693dc7622dda5f390 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				JZYHkZsWiJ6(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x68C7EAE6 ^ 0x68C76B5A));
			}
		}
	}

	public bool IsTradeAllowed
	{
		get
		{
			return gXCuPlS3Fj;
		}
		set
		{
			if (gXCuPlS3Fj != flag)
			{
				gXCuPlS3Fj = flag;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0b22b597497745f5ab911eaabff065eb != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				JZYHkZsWiJ6((string)RRQtlg4EQgKimTx3SLj6(0x6E2DFBED ^ 0x6E2D7A0F));
			}
		}
	}

	public bool IsLotsInDOMShowed
	{
		get
		{
			return pUMAJr4EtdGcFYrmN8ja(Settings);
		}
		set
		{
			if (Settings.IsLotsInDOMShowed != flag)
			{
				UBk1a74EUJV62ggFLWfB(Settings, flag);
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_08ac0ac701064383a00c80bff8cd4e3f == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				JZYHkZsWiJ6(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--146713930 ^ 0x8BE2DDA));
			}
		}
	}

	public string DataCycleShortName => (string)atXwm54ETQKvhsKldLYW(rPM5br4ERBMdR5UwpcgW(nwFL984Egvm73R658dx9(Settings)));

	public DataCycle DataCycle
	{
		get
		{
			return ocvuJfUVAS;
		}
		set
		{
			if (!object.Equals(objA, ocvuJfUVAS))
			{
				ocvuJfUVAS = objA;
				JZYHkZsWiJ6(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x746ED405 ^ 0x746E9DEF));
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_bcda8c444ccc4b27895bae9f13596743 == 0)
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

	public int DataScale
	{
		get
		{
			return MRQuFi1UnW;
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
					num3 = l6AQVI4EV4xxi6PW4DVS(1, num3);
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9d6f131f80d34ede83451138b928a86f == 0)
					{
						num2 = 0;
					}
					break;
				default:
					if (num3 != MRQuFi1UnW)
					{
						MRQuFi1UnW = num3;
						JZYHkZsWiJ6(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1309555870 ^ -1309560242));
					}
					return;
				}
			}
		}
	}

	public ICommand MenuCommand => y7Bu3LCBWx ?? (y7Bu3LCBWx = new RelayCommand(delegate(object P_0)
	{
		string text = P_0 as string;
		if (!string.IsNullOrEmpty(text))
		{
			myeuwh1NQI.t8Ypx81Ftn(text);
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6990919c9c0e45a99d17cb82a4a90a41 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}
	}));

	public bool IsSymbolsPopupOpen
	{
		get
		{
			return ntiupoGENk;
		}
		set
		{
			if (ntiupoGENk != flag)
			{
				ntiupoGENk = flag;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_12e8a768a5674e7d88b4e5ccd4fb7295 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				JZYHkZsWiJ6(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x1487846E ^ 0x1487066C));
				g2IuNeC9Ga();
			}
		}
	}

	public bfvIex27Er0lPTIgUD0b MarketLocked
	{
		get
		{
			if (!G6GsUZ4EC3Al7KsiLVnw(myeuwh1NQI))
			{
				return bfvIex27Er0lPTIgUD0b.None;
			}
			SymbolType symbolType = fLnf2m4EKNMGPf8hmA1h(igY6Lp4ErtsqUduN9u2U(myeuwh1NQI));
			if (symbolType != SymbolType.Future)
			{
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b17e829e94d54e7b87d666edd5b38bcd == 0)
				{
					num = 0;
				}
				switch (num)
				{
				default:
					if (symbolType == SymbolType.Crypto)
					{
						return (bfvIex27Er0lPTIgUD0b)2;
					}
					return bfvIex27Er0lPTIgUD0b.None;
				}
			}
			return (bfvIex27Er0lPTIgUD0b)1;
		}
	}

	public lFstfvuoXTH8701fWFf(jup2YO3VI1WuSPZJgwh P_0, TradingSettings P_1)
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		gXCuPlS3Fj = true;
		base._002Ector();
		myeuwh1NQI = P_0;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fce1ea768b8d4ccdb3b71310761c1e52 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				((EpdvD7f3hWq8UlJ32f6V)CqEiQ04EcK8XYb4W8Ffb(Settings.MarketSettings)).PropertyChanged += delegate(object obj, PropertyChangedEventArgs e)
				{
					XkQuaRMPVr(e.PropertyName);
				};
				num = 4;
				break;
			default:
				Alsuhj71OP = P_1;
				num = 3;
				break;
			case 4:
				((EpdvD7f3hWq8UlJ32f6V)q1u8j34EjvuuaPRAffsr(Settings.MarketSettings)).PropertyChanged += delegate(object obj, PropertyChangedEventArgs e)
				{
					XkQuaRMPVr(e.PropertyName);
				};
				num = 2;
				break;
			case 5:
				return;
			case 3:
				fKvKggHFteRddgHojOPb.i9QHFrSPdFy(d4nuiU2Ufa);
				APJmVS4Esb85I7VKAQaK(Settings, (PropertyChangedEventHandler)delegate(object obj, PropertyChangedEventArgs e)
				{
					XkQuaRMPVr(e.PropertyName);
				});
				Settings.MarketSettings.PropertyChanged += delegate(object obj, PropertyChangedEventArgs e)
				{
					XkQuaRMPVr((string)APeAQf4EmjurbFQqySGt(e));
				};
				j18iDj9nukSCmEyZs5lH.Settings.PropertyChanged += delegate(object obj, PropertyChangedEventArgs e)
				{
					z4JuB938gA(e.PropertyName);
				};
				IvnsYH4EXt75xR3A12PK(Settings.MarketSettings.Preset1, (PropertyChangedEventHandler)delegate(object obj, PropertyChangedEventArgs e)
				{
					XkQuaRMPVr(e.PropertyName);
				});
				IvnsYH4EXt75xR3A12PK(Settings.MarketSettings.Preset2, (PropertyChangedEventHandler)delegate(object obj, PropertyChangedEventArgs e)
				{
					XkQuaRMPVr(e.PropertyName);
				});
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_51aff79eb7764aeaade80ae2d6638ab5 == 0)
				{
					num = 1;
				}
				break;
			case 2:
				IvnsYH4EXt75xR3A12PK(Settings.MarketSettings.Preset5, (PropertyChangedEventHandler)delegate(object obj, PropertyChangedEventArgs e)
				{
					XkQuaRMPVr(e.PropertyName);
				});
				IsDomToolBarsVisible = Sn3SFU4EEEsTEkdWDnWi(j18iDj9nukSCmEyZs5lH.Settings);
				num = 5;
				break;
			}
		}
	}

	private void z4JuB938gA(string P_0)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				if (!OgJf2I4Edk9NdclE4MSH(P_0, RRQtlg4EQgKimTx3SLj6(0x6E2DFBED ^ 0x6E2D7BFD)))
				{
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9267d25a572643c4b072d1d18111abbd == 0)
					{
						num2 = 1;
					}
					break;
				}
				IsDomToolBarsVisible = j18iDj9nukSCmEyZs5lH.Settings.IsDomToolBarsVisible;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5dcb5c2a8274adf87bda91d76616538 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				return;
			case 1:
				if (!OgJf2I4Edk9NdclE4MSH(P_0, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1799510641 ^ -1799543373)))
				{
					if (!OgJf2I4Edk9NdclE4MSH(P_0, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-962524685 ^ -962495547)))
					{
						return;
					}
					JZYHkZsWiJ6((string)RRQtlg4EQgKimTx3SLj6(-5977659 ^ -6010445));
					num2 = 3;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cf96ea40632b4cc9a71884e2b5dceb8b == 0)
					{
						num2 = 3;
					}
					break;
				}
				myeuwh1NQI.Market.F13f5kxjM9I(_0020: false);
				myeuwh1NQI.Market.NeedRedraw(_0020: true);
				return;
			case 0:
				return;
			}
		}
	}

	private void XkQuaRMPVr(string P_0)
	{
		uint num = global::_003CPrivateImplementationDetails_003E.ComputeStringHash(P_0);
		int num2;
		if (num <= 1451698834)
		{
			if (num <= 272298094)
			{
				num2 = 9;
			}
			else
			{
				if (num == 362859610)
				{
					if (P_0 == (string)RRQtlg4EQgKimTx3SLj6(--737722733 ^ 0x2BF841B9))
					{
						goto IL_0322;
					}
					return;
				}
				num2 = 5;
			}
		}
		else
		{
			num2 = 7;
		}
		while (true)
		{
			int num3;
			switch (num2)
			{
			default:
				return;
			case 6:
				return;
			case 10:
				return;
			case 11:
				switch (num)
				{
				case 2136810001u:
					if (OgJf2I4Edk9NdclE4MSH(P_0, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x404ED0BE ^ 0x404EA192)))
					{
						p9Ox334EMqjrD4as8fdK(myeuwh1NQI, ((MarketSettings)nwFL984Egvm73R658dx9(Settings)).DataScale);
					}
					return;
				case 1506567441u:
					break;
				default:
					return;
				}
				if (!OgJf2I4Edk9NdclE4MSH(P_0, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-181342698 ^ -181375328)))
				{
					return;
				}
				break;
			case 5:
				if (num != 1451698834)
				{
					num3 = 2;
					goto IL_0005;
				}
				if (!(P_0 == (string)RRQtlg4EQgKimTx3SLj6(0x4662F6AF ^ 0x4662763F)))
				{
					num2 = 10;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44d9df62f7524f8eb2abdc23baf0c87b != 0)
					{
						num2 = 3;
					}
				}
				else
				{
					JZYHkZsWiJ6((string)RRQtlg4EQgKimTx3SLj6(-838841832 ^ -838808952));
					num2 = 12;
				}
				continue;
			case 1:
				return;
			case 4:
				if (num == 272298094)
				{
					if (!OgJf2I4Edk9NdclE4MSH(P_0, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x6AB40973 ^ 0x6AB48859)))
					{
						return;
					}
					break;
				}
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44265f4417e640c7a760a59a950624e5 != 0)
				{
					num2 = 0;
				}
				continue;
			case 8:
				return;
			case 3:
				if (num != 4035769824u || !OgJf2I4Edk9NdclE4MSH(P_0, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x1EFE0A28 ^ 0x1EFE781E)))
				{
					return;
				}
				break;
			case 0:
				return;
			case 9:
				if (num == 192205763)
				{
					if (!OgJf2I4Edk9NdclE4MSH(P_0, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0xC1DDB3B ^ 0xC1D5A7B)))
					{
						return;
					}
					break;
				}
				num2 = 4;
				continue;
			case 12:
				return;
			case 2:
				return;
			case 7:
				{
					if (num > 2136810001)
					{
						if (num == 2609711505u)
						{
							if (!OgJf2I4Edk9NdclE4MSH(P_0, RRQtlg4EQgKimTx3SLj6(0x7D553BE0 ^ 0x7D55720A)))
							{
								num2 = 6;
								continue;
							}
							M6iCIK4E6i9J1XbCBZKi(myeuwh1NQI, rPM5br4ERBMdR5UwpcgW(nwFL984Egvm73R658dx9(Settings)));
							JZYHkZsWiJ6(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-181342698 ^ -181375156));
							num2 = 8;
							continue;
						}
						if (num == 3270069581u)
						{
							if (!(P_0 == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-90307782 ^ -90275266)))
							{
								return;
							}
							break;
						}
						num3 = 3;
						goto IL_0005;
					}
					num2 = 11;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_11b8736b0585457b9538011988d6d2f9 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				IL_0005:
				num2 = num3;
				continue;
			}
			break;
		}
		goto IL_0322;
		IL_0322:
		JZYHkZsWiJ6(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-2017337494 ^ -2017370340));
	}

	private void d4nuiU2Ufa()
	{
		myeuwh1NQI?.JhtpL3N4Dx();
	}

	public void bxfulQM7Vl(int P_0)
	{
		Settings.MarketSettings.PresetID = P_0;
	}

	private void OY3u4rQsgf(bool P_0)
	{
		int num = 2;
		int num2 = num;
		int num4 = default(int);
		IOrderedEnumerable<E6bgtHf7k2xZ0cuqWjOq> source = default(IOrderedEnumerable<E6bgtHf7k2xZ0cuqWjOq>);
		E6bgtHf7k2xZ0cuqWjOq e6bgtHf7k2xZ0cuqWjOq2;
		while (true)
		{
			int num3;
			E6bgtHf7k2xZ0cuqWjOq e6bgtHf7k2xZ0cuqWjOq;
			int num5;
			switch (num2)
			{
			case 6:
				return;
			default:
				num3 = DataScale - num4;
				goto IL_019a;
			case 5:
				e6bgtHf7k2xZ0cuqWjOq = source.LastOrDefault((E6bgtHf7k2xZ0cuqWjOq e6bgtHf7k2xZ0cuqWjOq3) => heVJ4N4EZXojxfPkJ6wM(e6bgtHf7k2xZ0cuqWjOq3) < DataScale);
				break;
			case 2:
				if (((SH4fZjfBgpnJAYxtUbu4)urJDKp4EyRfDc2DRCw42(Settings.MarketSettings)).PriceScaleMultipliers.Count() == 0)
				{
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d9af442440454effa9efd8da8e33ec96 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				if (j18iDj9nukSCmEyZs5lH.Settings.FixedPriceScaleMultiplier)
				{
					num4 = heVJ4N4EZXojxfPkJ6wM(Settings.MarketSettings.VisualSettings.PriceScaleMultipliers.First());
					num2 = 4;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_390fe499a2cc4a5ca3d6279a99e6b610 == 0)
					{
						num2 = 4;
					}
					continue;
				}
				source = Settings.MarketSettings.VisualSettings.PriceScaleMultipliers.OrderBy((E6bgtHf7k2xZ0cuqWjOq c) => c.Value);
				if (P_0)
				{
					num2 = 3;
					continue;
				}
				goto case 5;
			case 1:
				return;
			case 4:
				if (!P_0)
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_08ac0ac701064383a00c80bff8cd4e3f == 0)
					{
						num2 = 0;
					}
					continue;
				}
				num3 = DataScale + num4;
				goto IL_019a;
			case 3:
				{
					e6bgtHf7k2xZ0cuqWjOq = source.FirstOrDefault((E6bgtHf7k2xZ0cuqWjOq e6bgtHf7k2xZ0cuqWjOq3) => e6bgtHf7k2xZ0cuqWjOq3.Value > DataScale);
					break;
				}
				IL_019a:
				num5 = num3;
				DataScale = num5 - num5 % num4;
				return;
			}
			e6bgtHf7k2xZ0cuqWjOq2 = e6bgtHf7k2xZ0cuqWjOq;
			if (e6bgtHf7k2xZ0cuqWjOq2 != null)
			{
				break;
			}
			num2 = 6;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_52f1b40ebe094208bc85ded04f1baa0b == 0)
			{
				num2 = 0;
			}
		}
		DataScale = heVJ4N4EZXojxfPkJ6wM(e6bgtHf7k2xZ0cuqWjOq2);
	}

	public void anUuD1ujYc()
	{
		OY3u4rQsgf(_0020: true);
	}

	public void tGvubgWA6Q()
	{
		OY3u4rQsgf(_0020: false);
	}

	public void g2IuNeC9Ga()
	{
		JZYHkZsWiJ6(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x6D18F862 ^ 0x6D187A48));
	}

	[CompilerGenerated]
	private void agRukC9TfR(object P_0, PropertyChangedEventArgs P_1)
	{
		XkQuaRMPVr(P_1.PropertyName);
	}

	[CompilerGenerated]
	private void krGu1Pnya7(object P_0, PropertyChangedEventArgs P_1)
	{
		XkQuaRMPVr((string)APeAQf4EmjurbFQqySGt(P_1));
	}

	[CompilerGenerated]
	private void teAu5poZ9M(object P_0, PropertyChangedEventArgs P_1)
	{
		z4JuB938gA(P_1.PropertyName);
	}

	[CompilerGenerated]
	private void EPmuSwLp8V(object P_0, PropertyChangedEventArgs P_1)
	{
		XkQuaRMPVr(P_1.PropertyName);
	}

	[CompilerGenerated]
	private void cLsuxw0Hxx(object P_0, PropertyChangedEventArgs P_1)
	{
		XkQuaRMPVr(P_1.PropertyName);
	}

	[CompilerGenerated]
	private void qMmuLapVU5(object P_0, PropertyChangedEventArgs P_1)
	{
		XkQuaRMPVr(P_1.PropertyName);
	}

	[CompilerGenerated]
	private void E0DueTvjim(object P_0, PropertyChangedEventArgs P_1)
	{
		XkQuaRMPVr(P_1.PropertyName);
	}

	[CompilerGenerated]
	private void Ui6usPqREL(object P_0, PropertyChangedEventArgs P_1)
	{
		XkQuaRMPVr(P_1.PropertyName);
	}

	[CompilerGenerated]
	private bool W2LuXTl6Dx(E6bgtHf7k2xZ0cuqWjOq P_0)
	{
		return P_0.Value > DataScale;
	}

	[CompilerGenerated]
	private bool OpFucUXbd2(E6bgtHf7k2xZ0cuqWjOq P_0)
	{
		return heVJ4N4EZXojxfPkJ6wM(P_0) < DataScale;
	}

	[CompilerGenerated]
	private void nxDujib5dl(object P_0)
	{
		string text = P_0 as string;
		if (!string.IsNullOrEmpty(text))
		{
			myeuwh1NQI.t8Ypx81Ftn(text);
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6990919c9c0e45a99d17cb82a4a90a41 != 0)
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

	static lFstfvuoXTH8701fWFf()
	{
		adhDEh4Eh9Teo0jmbZw2();
	}

	internal static void APJmVS4Esb85I7VKAQaK(object P_0, object P_1)
	{
		((KqZtUj2kTEAQfYBkeSKy)P_0).PropertyChanged += (PropertyChangedEventHandler)P_1;
	}

	internal static void IvnsYH4EXt75xR3A12PK(object P_0, object P_1)
	{
		((EpdvD7f3hWq8UlJ32f6V)P_0).PropertyChanged += (PropertyChangedEventHandler)P_1;
	}

	internal static object CqEiQ04EcK8XYb4W8Ffb(object P_0)
	{
		return ((MarketSettings)P_0).Preset3;
	}

	internal static object q1u8j34EjvuuaPRAffsr(object P_0)
	{
		return ((MarketSettings)P_0).Preset4;
	}

	internal static bool Sn3SFU4EEEsTEkdWDnWi(object P_0)
	{
		return ((MhMDPU9v8rkigy1ao0Th)P_0).IsDomToolBarsVisible;
	}

	internal static bool RnmR3U4ELbITEQAj2K1h()
	{
		return fjJo5c4ExmLN3xtWolI9 == null;
	}

	internal static lFstfvuoXTH8701fWFf hx1ki44Ee0NDweiAMaF5()
	{
		return fjJo5c4ExmLN3xtWolI9;
	}

	internal static object RRQtlg4EQgKimTx3SLj6(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static bool OgJf2I4Edk9NdclE4MSH(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static object nwFL984Egvm73R658dx9(object P_0)
	{
		return ((TradingSettings)P_0).MarketSettings;
	}

	internal static object rPM5br4ERBMdR5UwpcgW(object P_0)
	{
		return ((MarketSettings)P_0).DataCycle;
	}

	internal static void M6iCIK4E6i9J1XbCBZKi(object P_0, object P_1)
	{
		((jup2YO3VI1WuSPZJgwh)P_0).TkYpeAHLV1((DataCycle)P_1);
	}

	internal static void p9Ox334EMqjrD4as8fdK(object P_0, int P_1)
	{
		((jup2YO3VI1WuSPZJgwh)P_0).vx9pscng8q(P_1);
	}

	internal static int TIOkRY4EO1oJmnJJ1ARo(object P_0)
	{
		return ((MhMDPU9v8rkigy1ao0Th)P_0).QuoteCurrencyOrderDecimals;
	}

	internal static object fXETiE4EqAcArnvQKEvd(object P_0)
	{
		return ((MarketSettings)P_0).CurrentPreset;
	}

	internal static double N3sX4B4EIGcdhyA4UAwZ(object P_0)
	{
		return ((EpdvD7f3hWq8UlJ32f6V)P_0).QuoteSize;
	}

	internal static decimal Tm9bw04EWxf7cIUf3ZLO(double P_0)
	{
		return Convert.ToDecimal(P_0);
	}

	internal static bool pUMAJr4EtdGcFYrmN8ja(object P_0)
	{
		return ((TradingSettings)P_0).IsLotsInDOMShowed;
	}

	internal static void UBk1a74EUJV62ggFLWfB(object P_0, bool P_1)
	{
		((TradingSettings)P_0).IsLotsInDOMShowed = P_1;
	}

	internal static object atXwm54ETQKvhsKldLYW(object P_0)
	{
		return ((DataCycle)P_0).ShortName;
	}

	internal static object urJDKp4EyRfDc2DRCw42(object P_0)
	{
		return ((MarketSettings)P_0).VisualSettings;
	}

	internal static int heVJ4N4EZXojxfPkJ6wM(object P_0)
	{
		return ((E6bgtHf7k2xZ0cuqWjOq)P_0).Value;
	}

	internal static int l6AQVI4EV4xxi6PW4DVS(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static bool G6GsUZ4EC3Al7KsiLVnw(object P_0)
	{
		return ((jup2YO3VI1WuSPZJgwh)P_0).IsMarketLocked;
	}

	internal static object igY6Lp4ErtsqUduN9u2U(object P_0)
	{
		return ((z6kMSs25KYyGVf55FxBT)P_0).DocLinkContext;
	}

	internal static SymbolType fLnf2m4EKNMGPf8hmA1h(object P_0)
	{
		return ((DocLinkContext)P_0).SymbolType;
	}

	internal static object APeAQf4EmjurbFQqySGt(object P_0)
	{
		return ((PropertyChangedEventArgs)P_0).PropertyName;
	}

	internal static void adhDEh4Eh9Teo0jmbZw2()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}
}
