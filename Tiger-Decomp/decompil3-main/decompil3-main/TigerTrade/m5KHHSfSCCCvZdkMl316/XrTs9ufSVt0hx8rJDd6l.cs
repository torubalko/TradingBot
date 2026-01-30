using System;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using aEpmU09nz6MEoNmc0pGJ;
using aeXChk9vAhkf7Zm8SpOk;
using Cok5gZfeOOYNUntqe0FS;
using ECOEgqlSad8NUJZ2Dr9n;
using JDQ6KCGfdXAs3N4Dq3K0;
using LkgWJcfsLbF5GV6NcGQ4;
using NsWD4W9miMxRbFU3fsu9;
using o1srKL9PWRC5v3sURMga;
using pieN9WfFYEsJTSrYSp5q;
using q6Lcl3fBRQ8ycXy3QOHi;
using ROhuQx9FcGTLTqPCaJ0j;
using TigerTrade.Dx;
using TigerTrade.Market.Settings;
using TigerTrade.Tc.Data;
using TigerTrade.UI.DocControls.Trading.Settings;
using TuAMtrl1Nd3XoZQQUXf0;
using Wf1kTvnGy6XhfTKJgfkM;
using xfdMo0lS4TP9pN36Goka;
using XUi8EWf1E6l7gdu7kUS9;
using zgMYdJf4fc58NIsUuLGN;

namespace m5KHHSfSCCCvZdkMl316;

internal abstract class XrTs9ufSVt0hx8rJDd6l : cXwoI5f1jl9EMXW8XL7D
{
	private int LaZfLMJcJdv;

	private double YGHfLOSnIEl;

	private double f4nfLqk7Qii;

	private int rJ9fLIKBmCG;

	private double OiwfLWuCqsK;

	private int nOOfLtdMGeZ;

	protected int VFrfLUehH2N;

	protected int up0fLTmDg1v;

	public bool ShowPanel;

	public bool ShowCluster;

	public bool ShowGraph;

	private int vLTfLyrmujt;

	protected bool FeAfLZnf8m4;

	protected bool DgVfLVq3cGG;

	protected bool v6kfLC4GCp6;

	public long GZbfLrJelZU;

	public long WWtfLK83ba1;

	private string hhHfLmkV336;

	public static readonly DependencyProperty lxYfLhgWJDA;

	private readonly wFFFvWfsxErbxn4XFmrR XdtfLwI78Lp;

	[CompilerGenerated]
	private bool NGcfL7qA0aO;

	[CompilerGenerated]
	private long ICgfL8mGGh5;

	[CompilerGenerated]
	private bool LeufLA1pvoe;

	private double sQrfLPdTQJd;

	private double dcyfLF6s0Mq;

	private double KAQfLpZakRw;

	private double ebBfLudh87b;

	private double I7Yfe2lwjNP;

	[CompilerGenerated]
	private double keIfeHHe41V;

	[CompilerGenerated]
	private double hAffefQHa5b;

	[CompilerGenerated]
	private double BBJfe9Z5ZPb;

	internal static XrTs9ufSVt0hx8rJDd6l IJopJlDP0eDG8PRWlLde;

	public ICommand EditViewOpenCommand
	{
		get
		{
			return (ICommand)GetValue(lxYfLhgWJDA);
		}
		set
		{
			SetValue(lxYfLhgWJDA, command);
			((smTKLVfeMIY6X8kUtDCi)fvFmCgDPfnbsSKH5UNFq(XdtfLwI78Lp)).YLqfeKT4faB(command);
		}
	}

	public double PanelWidth
	{
		get
		{
			if (!ShowPanel)
			{
				return 0.0;
			}
			return sQrfLPdTQJd;
		}
	}

	public double ClusterWidth
	{
		get
		{
			return (int)dcyfLF6s0Mq;
		}
		set
		{
			if (!(Math.Abs(dcyfLF6s0Mq - num) <= 2.0))
			{
				dcyfLF6s0Mq = x3GjYGDP17mctJxVwkyr(num, 10.0);
				int num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f3775e6a3cb04c0998106e46ff04d8ab == 0)
				{
					num2 = 0;
				}
				switch (num2)
				{
				}
				NeedRedraw(_0020: true);
			}
		}
	}

	public double DomWidth
	{
		get
		{
			int num = 0;
			if (ebBfLudh87b == 0.0)
			{
				ebBfLudh87b = (int)CdRh6sDPMQ9FugkOVT0f(base.TradingSettings);
				int num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3023bd6c0f7846878513499bf5c36161 != 0)
				{
					num2 = 0;
				}
				while (true)
				{
					switch (num2)
					{
					case 1:
						break;
					default:
						num = 30;
						num2 = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d3afdd6ad27a4c3b87071f1be51e7ef3 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					break;
				}
				NeedRedraw(_0020: true);
			}
			return (int)Math.Max(ebBfLudh87b + (double)num, ByafxzCuIsb());
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
					if (!(Math.Abs(ebBfLudh87b - num3) <= 2.0))
					{
						ebBfLudh87b = num3;
						B2dtktDPOlSIgWExEE7v(base.TradingSettings, ebBfLudh87b);
						NeedRedraw(_0020: true);
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6990919c9c0e45a99d17cb82a4a90a41 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[SpecialName]
	[CompilerGenerated]
	protected bool MJhfxosGfws()
	{
		return NGcfL7qA0aO;
	}

	[SpecialName]
	[CompilerGenerated]
	protected void e9gfxv6EseU(bool P_0)
	{
		NGcfL7qA0aO = P_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public long uj2fxa4sYHF()
	{
		return ICgfL8mGGh5;
	}

	[SpecialName]
	[CompilerGenerated]
	protected void fIZfxiWM7pU(long P_0)
	{
		ICgfL8mGGh5 = P_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public bool TAufx45q8iE()
	{
		return LeufLA1pvoe;
	}

	[SpecialName]
	[CompilerGenerated]
	protected void GfnfxDOG57x(bool P_0)
	{
		LeufLA1pvoe = P_0;
	}

	protected XrTs9ufSVt0hx8rJDd6l()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		YGHfLOSnIEl = 1.0;
		f4nfLqk7Qii = 1.0;
		ShowPanel = true;
		ShowCluster = true;
		ShowGraph = true;
		FeAfLZnf8m4 = true;
		sQrfLPdTQJd = 140.0;
		I7Yfe2lwjNP = double.NaN;
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03df70ea72bf4e3e81ab05550292a7c9 == 0)
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
				XdtfLwI78Lp = new wFFFvWfsxErbxn4XFmrR(this);
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_35216e71f4e34e739f4a05a1213f3579 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	protected bool dEEfSrvFDJZ(out Rect P_0, out Rect P_1)
	{
		return XdtfLwI78Lp.zFjfsFB6hDW().Ry7fXUCmsVq(out P_0, out P_1);
	}

	public void wyOfSKBQnal(out long P_0, out long P_1, out long P_2)
	{
		P_0 = XdtfLwI78Lp.MinPrice;
		P_1 = XdtfLwI78Lp.MaxPrice;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_152544ed8bd2470d8638a522e4a24d02 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		ypqMIv9maFM0tRwF0xMh ypqMIv9maFM0tRwF0xMh = base.DataProvider;
		P_2 = ((ypqMIv9maFM0tRwF0xMh == null) ? ((long?)null) : ((daEwNq9FXerRxid1xGMa)pE9F7PDP9y5I9lB1q1CQ(ypqMIv9maFM0tRwF0xMh))?.pWf9FdbBnRR()).GetValueOrDefault();
	}

	[SpecialName]
	private bool qiYfxNLGI6t()
	{
		if (VFrfLUehH2N > 0)
		{
			return (double)VFrfLUehH2N < DsQXRWDPnwYK2gj4isf4(XdtfLwI78Lp);
		}
		return false;
	}

	protected bool ePJfSmrnmFR(Point P_0)
	{
		return XdtfLwI78Lp.Dqefsj3caES(P_0);
	}

	protected bool RWufShwVZqV(Point P_0)
	{
		return XdtfLwI78Lp.YCQfsEfhsY1(P_0);
	}

	protected bool tEIfSwIpaNK(Point P_0)
	{
		return XdtfLwI78Lp.ko2fsQ6Z0lC(P_0);
	}

	protected bool twSfS7wclxO(Point P_0)
	{
		return UqxNIoDPG2O6ng2DMsWe(XdtfLwI78Lp, P_0);
	}

	protected void H13fS8q8euf(DxVisualQueue P_0, bool P_1)
	{
		Bv5fSPYZfRg(P_0, P_1);
		bool flag = hOhDPhDPYcC9LdV3Mb8I(XdtfLwI78Lp);
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_26fe5531b15948b7a2b6ffb2cd927204 != 0)
		{
			num = 0;
		}
		bool flag3 = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			switch (num)
			{
			default:
				flag3 = f4weqhDPoyvYATHEHRWj(XdtfLwI78Lp);
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dd6de048cd134da6b2674c002762ca45 != 0)
				{
					num = 1;
				}
				break;
			case 1:
			{
				jkytmbDPvDF8jrKovKvt(XdtfLwI78Lp, P_0, P_1);
				bool num2 = XdtfLwI78Lp.xXsfsgwrgMQ();
				flag2 = f4weqhDPoyvYATHEHRWj(XdtfLwI78Lp);
				if (num2 == flag)
				{
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dfd8fb340d494755970617a38d3a8729 != 0)
					{
						num = 2;
					}
					break;
				}
				goto IL_007f;
			}
			case 2:
				{
					if (flag2 == flag3)
					{
						return;
					}
					goto IL_007f;
				}
				IL_007f:
				NeedRedraw(_0020: true);
				return;
			}
		}
	}

	protected void de9fSAhQoUR(out double P_0, out double P_1)
	{
		((smTKLVfeMIY6X8kUtDCi)fvFmCgDPfnbsSKH5UNFq(XdtfLwI78Lp)).jo3feCFUEVG(out P_0, out P_1);
	}

	protected override void OnRenderSizeChanged(SizeChangedInfo P_0)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				u7ci6kDPB9ccWjftBIi9(this, P_0);
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03df70ea72bf4e3e81ab05550292a7c9 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				gbVfxqCgFxP(Math.Max((int)P_0.NewSize.Width, 1));
				ILlfx6JpKYe(G8IXeYDPaUSWexh3XDRL((int)P_0.NewSize.Height, 1));
				return;
			}
		}
	}

	protected override void OnMouseLeftButtonDown(MouseButtonEventArgs P_0)
	{
		base.OnMouseLeftButtonDown(P_0);
		Point point = r9BydqDPiJabQAe69SHy(P_0, this);
		P_0.Handled = XdtfLwI78Lp.G9kfsM9lpqr(point);
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f68538a410dc40459f303c1bac7938ac == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	protected override void OnMouseLeftButtonUp(MouseButtonEventArgs P_0)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
			{
				Point position = P_0.GetPosition(this);
				P_0.Handled = XdtfLwI78Lp.ywPfsOA87Ml(position);
				return;
			}
			case 1:
				base.OnMouseLeftButtonUp(P_0);
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_94f896a1c68c4274bf6a8960d175b5c2 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected override void OnMouseMove(MouseEventArgs P_0)
	{
		s1M4UdDPl9QrAFVFn5Tp(this, P_0);
		Point position = P_0.GetPosition(this);
		XdtfLwI78Lp.Pbpfs66RKOe(position);
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9d6f131f80d34ede83451138b928a86f != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	protected override void OnMouseDoubleClick(MouseButtonEventArgs P_0)
	{
		base.OnMouseMove(P_0);
		Point position = P_0.GetPosition(this);
		Cs8WsVDP4Yltn3cKO4ur(XdtfLwI78Lp, position);
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d9af442440454effa9efd8da8e33ec96 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	private void Bv5fSPYZfRg(DxVisualQueue P_0, bool P_1)
	{
		int num;
		if (base.TradingSettings.ShowPanel == ShowPanel && rnZg1ADPDVGoFPk6Qag1(base.TradingSettings) == ShowCluster)
		{
			if (a5yI93DPbxjm1n5hAAqA(base.TradingSettings) != ShowGraph)
			{
				num = 8;
				goto IL_0005;
			}
			goto IL_019b;
		}
		goto IL_05eb;
		IL_083d:
		double num2 = base.Settings.BaseFont.GetHeight() + 4.0;
		int num3 = 24;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_859c6249cb0f4f11b2da29d1228ce418 != 0)
		{
			num3 = 28;
		}
		goto IL_0009;
		IL_019b:
		if (vLTfLyrmujt != hlxMjhDPNdxWyKCB8lhb(base.Settings.VisualSettings))
		{
			vLTfLyrmujt = base.Settings.VisualSettings.DomQuoteExtraWidth;
			num = 24;
			goto IL_0005;
		}
		goto IL_052d;
		IL_052d:
		if (sQrfLPdTQJd != Math.Max(base.Settings.VisualSettings.PanelWidth, 140.0))
		{
			num3 = 31;
			goto IL_0009;
		}
		goto IL_083d;
		IL_0005:
		num3 = num;
		goto IL_0009;
		IL_0009:
		double num6 = default(double);
		long num4 = default(long);
		long num5 = default(long);
		string text2 = default(string);
		double num8 = default(double);
		string text = default(string);
		double num7 = default(double);
		double num9 = default(double);
		bool flag = default(bool);
		bool flag2 = default(bool);
		bool flag3 = default(bool);
		while (true)
		{
			switch (num3)
			{
			case 2:
				SnSfLHnDjUT(100.0 + num6);
				if (oxcfxc81mSM() == 0.0)
				{
					num3 = 17;
					continue;
				}
				goto case 13;
			case 6:
				Scroll();
				num3 = 13;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_57c2433b06714a1299d736aebe42caa2 == 0)
				{
					num3 = 15;
				}
				continue;
			case 10:
				break;
			case 28:
				if (I8MfLNiJ00B() != num2)
				{
					num3 = 21;
					continue;
				}
				goto case 5;
			case 31:
				sQrfLPdTQJd = x3GjYGDP17mctJxVwkyr(((SH4fZjfBgpnJAYxtUbu4)EVxSBKDPkpbXvmaZX6Ng(base.Settings)).PanelWidth, 140.0);
				gbVfxqCgFxP(dTDfxO2A1eG());
				num3 = 23;
				continue;
			default:
				goto IL_019b;
			case 12:
				F13f5kxjM9I(_0020: true);
				goto IL_0828;
			case 15:
				num4 = yrmfx0rxByf(0);
				num5 = yrmfx0rxByf((int)RT5fxR1KK3E());
				num3 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b17e829e94d54e7b87d666edd5b38bcd == 0)
				{
					num3 = 1;
				}
				continue;
			case 29:
				text2 = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x3E0426F0 ^ 0x3E041BE6);
				goto case 16;
			case 26:
				goto IL_021d;
			case 24:
				gbVfxqCgFxP(dTDfxO2A1eG());
				goto IL_083d;
			case 19:
				text2 = (string)DHnlVuDPslpxXOeg9180(base.DataProvider.Symbol, num5, true, LaZfLMJcJdv);
				goto case 16;
			case 4:
				if (!(Math.Abs(num8 - SeFfL5siOPX()) > 3.0) && !D4ef5NHwB0Q())
				{
					goto IL_058d;
				}
				SAlfLSAZUTr(num8);
				num3 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44265f4417e640c7a760a59a950624e5 == 0)
				{
					num3 = 18;
				}
				continue;
			case 18:
				gbVfxqCgFxP(dTDfxO2A1eG());
				num3 = 27;
				continue;
			case 9:
			case 30:
				num8 = Math.Max(((XFont)JTVA5bDPcnqgKT7eMZRf(base.Settings)).GetWidth(text), ((XFont)JTVA5bDPcnqgKT7eMZRf(base.Settings)).GetWidth(text2)) + 6.0;
				num3 = 33;
				continue;
			case 11:
				goto IL_04a1;
			case 16:
				if (num4 == 0L)
				{
					text = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x404ED0BE ^ 0x404EEDA8);
					goto case 9;
				}
				num7 = base.DataProvider.Symbol.Step * (double)num4;
				num3 = 25;
				continue;
			case 13:
				if (ip5fxQ0RjU4() == 0.0)
				{
					OxafxdXtG4e(0.5);
				}
				goto IL_0580;
			case 14:
				goto IL_052d;
			case 27:
				goto IL_058d;
			case 21:
				CdKfLkRkXP4(num2);
				zmafxxlZ8j4(0.0);
				num3 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9cec884f01d949d294f11a9fcceef609 == 0)
				{
					num3 = 5;
				}
				continue;
			case 8:
				goto IL_05eb;
			case 32:
				if (!D4ef5NHwB0Q() && Math.Abs(num9) < (double)PVMEKVDPxHWL5rOjm1UD(TQLEdrDPSWG0s410a6ah()))
				{
					F13f5kxjM9I(_0020: true);
					num3 = 11;
					continue;
				}
				goto IL_04a1;
			case 3:
				flag = base.TradingSettings.ShowCluster;
				flag2 = base.TradingSettings.ShowGraph;
				num6 = (flag3 ? sQrfLPdTQJd : 0.0);
				if ((flag3 || flag || flag2) && iDafL2mbSql() < 100.0 + num6 && DomWidth - 100.0 > 2.0 * SeFfL5siOPX() + QrafLjASmWS() + 10.0)
				{
					num3 = 2;
					continue;
				}
				goto IL_0580;
			case 22:
				XdtfLwI78Lp.vB1fscDUJ6w(P_1, EP2S6TDPEYJf97fMmoN8(this));
				return;
			case 7:
				goto IL_06fd;
			case 33:
				rEafLeNMgsY(x3GjYGDP17mctJxVwkyr(base.Settings.PositionStatsFont.GetWidth(base.DataProvider.Symbol.FormatRawPrice(num4, _0020: true)), ((XFont)pNhswRDPjaGdGLtptulO(base.Settings)).GetWidth(((ijsjhhnGTadfwpOyDdrx)fwJp4hDP5vn3UxGfuJGS(base.DataProvider)).FormatRawPrice(num5, _0020: true))) + 6.0);
				if (hhHfLmkV336 != L7mf55nJsxC())
				{
					num3 = 26;
					continue;
				}
				goto case 4;
			case 17:
				PdIfxj8xGqp(0.3);
				num3 = 13;
				continue;
			case 25:
				goto IL_07b9;
			case 1:
				goto IL_07fd;
			case 20:
				goto IL_0828;
			case 23:
				goto IL_083d;
			case 5:
				{
					v6kfLC4GCp6 = (double)VFrfLUehH2N > iDafL2mbSql() && (double)VFrfLUehH2N < nJ7fL9cL9PV() && up0fLTmDg1v >= 0 && (double)up0fLTmDg1v <= RT5fxR1KK3E();
					num3 = 6;
					continue;
				}
				IL_0580:
				ShowPanel = flag3;
				ShowCluster = flag;
				ShowGraph = flag2;
				gbVfxqCgFxP(dTDfxO2A1eG());
				goto IL_083d;
			}
			break;
			IL_07fd:
			if (num5 == 0L)
			{
				num3 = 25;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03df70ea72bf4e3e81ab05550292a7c9 == 0)
				{
					num3 = 29;
				}
				continue;
			}
			goto IL_03e8;
			IL_0828:
			if (D4ef5NHwB0Q())
			{
				num3 = 7;
				continue;
			}
			goto IL_038c;
			IL_038c:
			text = base.DataProvider.Symbol.FormatRawPrice(num4, _0020: true);
			num3 = 9;
			continue;
			IL_07b9:
			if (!D4ef5NHwB0Q())
			{
				if (Math.Abs(num7) < w7g6OvDPXdy3wVHgbRvR(j18iDj9nukSCmEyZs5lH.Settings.MaxPriceWithoutHidingZeroes))
				{
					num3 = 12;
					continue;
				}
				goto IL_0828;
			}
			num3 = 20;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ba87d68105604f98a891a0549ef4b7f9 != 0)
			{
				num3 = 6;
			}
			continue;
			IL_06fd:
			if (Math.Abs(num7) < 0.1)
			{
				num3 = 10;
				continue;
			}
			goto IL_038c;
			IL_04a1:
			if (D4ef5NHwB0Q() && PRWJCVDPLCFdBmnNL0D0(num9) < 0.1)
			{
				LaZfLMJcJdv = QogbLdDPetZ7MoK6NZbE(num9, 0);
				num3 = 19;
			}
			else
			{
				text2 = base.DataProvider.Symbol.FormatRawPrice(num5, _0020: true);
				num3 = 16;
			}
		}
		LaZfLMJcJdv = xJABt8GfQN3bpiGT4k9G.KV0Gf6GmrTy(num7);
		text = base.DataProvider.Symbol.FqunGmNxUTm(num4, _0020: true, LaZfLMJcJdv);
		num = 30;
		goto IL_0005;
		IL_021d:
		SAlfLSAZUTr(0.0);
		hhHfLmkV336 = L7mf55nJsxC();
		num = 4;
		goto IL_0005;
		IL_03e8:
		num9 = ((SymbolBase)fwJp4hDP5vn3UxGfuJGS(base.DataProvider)).Step * (double)num5;
		num = 32;
		goto IL_0005;
		IL_05eb:
		flag3 = base.TradingSettings.ShowPanel;
		num3 = 3;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2088b9a28522490e83dc44062c40a7c0 == 0)
		{
			num3 = 2;
		}
		goto IL_0009;
		IL_058d:
		XdtfLwI78Lp.UYTfse61jKX(num5, num4);
		XdtfLwI78Lp.IQXfssEAqYw(VFrfLUehH2N, up0fLTmDg1v);
		num = 22;
		goto IL_0005;
	}

	[SpecialName]
	protected double PmMfx1QrWWK()
	{
		return XdtfLwI78Lp.wD9fXGNmvlC();
	}

	protected MarketSettings OGnfSJrEZPV()
	{
		return XdtfLwI78Lp.Settings;
	}

	protected FX2hNmfFGUQfi0wdaZLW.Positions? KGMfSFVJnf4(double P_0, double P_1)
	{
		return XdtfLwI78Lp.RSnfsI2oSjF(P_0, P_1);
	}

	[SpecialName]
	protected double vTGfxShCfWR()
	{
		return OiwfLWuCqsK;
	}

	[SpecialName]
	protected void zmafxxlZ8j4(double P_0)
	{
		OiwfLWuCqsK = P_0;
		NeedRedraw(_0020: true);
	}

	[SpecialName]
	public int A4EfxeC5DlR()
	{
		return nOOfLtdMGeZ;
	}

	[SpecialName]
	public void Jrpfxs1LaXL(int P_0)
	{
		nOOfLtdMGeZ = ((P_0 > 0) ? P_0 : 0);
	}

	[SpecialName]
	private double oxcfxc81mSM()
	{
		return base.TradingSettings.nx0z180IRO;
	}

	[SpecialName]
	private void PdIfxj8xGqp(double P_0)
	{
		base.TradingSettings.nx0z180IRO = P_0;
	}

	[SpecialName]
	private double ip5fxQ0RjU4()
	{
		return Gr8JsXDPQCmb0oIEYa3g(base.TradingSettings);
	}

	[SpecialName]
	private void OxafxdXtG4e(double P_0)
	{
		base.TradingSettings.a0bzx3ZHvi = P_0;
	}

	[SpecialName]
	protected double RT5fxR1KK3E()
	{
		return YGHfLOSnIEl;
	}

	[SpecialName]
	protected void ILlfx6JpKYe(double P_0)
	{
		YGHfLOSnIEl = Math.Max(1, (int)P_0);
		NeedRedraw(_0020: true);
	}

	[SpecialName]
	protected double dTDfxO2A1eG()
	{
		return f4nfLqk7Qii;
	}

	[SpecialName]
	private void gbVfxqCgFxP(double P_0)
	{
		int num = 10;
		int num2 = num;
		double num4 = default(double);
		double num3 = default(double);
		while (true)
		{
			switch (num2)
			{
			case 16:
				if (ShowGraph)
				{
					num2 = 8;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dfd8fb340d494755970617a38d3a8729 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto IL_0217;
			case 14:
				if (!ShowGraph)
				{
					ClusterWidth = num4 - 3.0 - (double)((PanelWidth > 0.0) ? 1 : 0);
					kgWfx8fnbCa(0.0);
					num2 = 5;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_859c6249cb0f4f11b2da29d1228ce418 != 0)
					{
						num2 = 11;
					}
					break;
				}
				goto IL_00ad;
			case 13:
				kgWfx8fnbCa(0.0);
				if (f4nfLqk7Qii > PanelWidth + SeFfL5siOPX() + 2.0 * QrafLjASmWS())
				{
					DomWidth = f4nfLqk7Qii - ((PanelWidth > 0.0) ? (PanelWidth + 1.0) : 0.0);
					num2 = 2;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3023bd6c0f7846878513499bf5c36161 == 0)
					{
						num2 = 6;
					}
					break;
				}
				goto case 2;
			case 15:
				num4 = 0.0;
				num2 = 4;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2264c03640a14c8f930261fd70e85d60 == 0)
				{
					num2 = 4;
				}
				break;
			case 10:
				f4nfLqk7Qii = G8IXeYDPaUSWexh3XDRL(1, (int)P_0);
				num2 = 9;
				break;
			case 9:
				if (!(f4nfLqk7Qii < gaXfL4xlUvN() + PanelWidth))
				{
					goto IL_0217;
				}
				if (!ShowCluster)
				{
					num2 = 16;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d4c083a65c1546b8a09c928a8c95e140 != 0)
					{
						num2 = 16;
					}
					break;
				}
				goto case 8;
			case 2:
			case 6:
			case 11:
			case 12:
			case 17:
				NeedRedraw(_0020: true);
				return;
			case 5:
				if (ShowCluster)
				{
					num2 = 14;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b3744d11c0b24c8d993b100cbb22f9e7 == 0)
					{
						num2 = 10;
					}
					break;
				}
				goto IL_00ad;
			default:
				if (!ShowGraph)
				{
					ClusterWidth = 0.0;
					num2 = 12;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03df70ea72bf4e3e81ab05550292a7c9 == 0)
					{
						num2 = 13;
					}
					break;
				}
				goto case 5;
			case 3:
				if (num4 < 0.0)
				{
					num2 = 15;
					break;
				}
				goto case 4;
			case 4:
				if (ShowCluster)
				{
					if (!ShowGraph)
					{
						num2 = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5e7b68e9e95482ab88a9b839c4d448c == 0)
						{
							num2 = 1;
						}
						break;
					}
					ClusterWidth = (int)(oxcfxc81mSM() * (num4 - 4.0));
					kgWfx8fnbCa(num4 - (double)((PanelWidth > 0.0) ? 5 : 4) - ClusterWidth);
					goto case 2;
				}
				goto case 1;
			case 1:
				if (!ShowCluster)
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_152544ed8bd2470d8638a522e4a24d02 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 5;
			case 8:
				num3 = 2.0 * SeFfL5siOPX() + QrafLjASmWS();
				ClusterWidth = 0.0;
				kgWfx8fnbCa(0.0);
				num2 = 7;
				break;
			case 7:
				{
					DomWidth = ((f4nfLqk7Qii - PanelWidth < num3) ? num3 : (f4nfLqk7Qii - PanelWidth));
					num2 = 12;
					break;
				}
				IL_0217:
				num4 = f4nfLqk7Qii - gaXfL4xlUvN() - PanelWidth;
				if (DomWidth != gaXfL4xlUvN())
				{
					DomWidth = gaXfL4xlUvN();
					num2 = 3;
					break;
				}
				goto case 3;
				IL_00ad:
				if (!ShowCluster)
				{
					if (!ShowGraph)
					{
						num2 = 17;
						break;
					}
					kgWfx8fnbCa(num4 - 3.0 - (double)((PanelWidth > 0.0) ? 1 : 0));
					ClusterWidth = 0.0;
					num2 = 2;
					break;
				}
				goto case 2;
			}
		}
	}

	protected override void OnSetSettings()
	{
		ShowPanel = base.TradingSettings.ShowPanel;
		ShowCluster = base.TradingSettings.ShowCluster;
		ShowGraph = base.TradingSettings.ShowGraph;
		DomWidth = base.TradingSettings.DomWidth;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0aea3f4dc28f4bcb92a1f998dc5afbed == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	protected override void VisualReset()
	{
		zmafxxlZ8j4(0.0);
		FeAfLZnf8m4 = true;
		rJ9fLIKBmCG = 0;
		Jrpfxs1LaXL(0);
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3cfcda862e0540cbb9abf65446a10635 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	private long dVPfS33e5at()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (base.DataProvider != null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03df70ea72bf4e3e81ab05550292a7c9 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				return 0L;
			default:
			{
				long num3 = base.DataProvider.OpZl98KAYgk().E2o9FgnJ4m2();
				if (num3 <= 0)
				{
					num3 = ((kjc7Gl9PIEfKaxcEBwuk)JfMWtaDPdyQJsFPioSFK(base.DataProvider)).LastPrice;
				}
				return num3;
			}
			}
		}
	}

	public double O4qfSpNNA8v(long P_0)
	{
		return htQfSzN6bG1(base.DataProvider.sUYlnolEAnK(P_0));
	}

	public double YV0fSux3EkM(long P_0, bool P_1)
	{
		return htQfSzN6bG1(base.DataProvider.BeelnvYms8s(P_0, P_1));
	}

	public double htQfSzN6bG1(long P_0)
	{
		if (vTGfxShCfWR() == 0.0)
		{
			long num = dVPfS33e5at();
			int num2 = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_267ca8254fa648cbaa1ba685784f79c7 != 0)
			{
				num2 = 0;
			}
			switch (num2)
			{
			}
			if (num > 0)
			{
				zmafxxlZ8j4((double)num * I8MfLNiJ00B() + RT5fxR1KK3E() / 2.0);
			}
		}
		return (int)(vTGfxShCfWR() - (double)P_0 * I8MfLNiJ00B());
	}

	public long yrmfx0rxByf(int P_0)
	{
		return Wkgfx2UBnjw((int)iDafL2mbSql() + 1, P_0);
	}

	public long Wkgfx2UBnjw(int P_0, int P_1)
	{
		long num = dVPfS33e5at();
		long result = default(long);
		long num2 = default(long);
		int num3;
		if (num > 0)
		{
			result = 0L;
			num2 = num;
			if (!((double)P_0 > iDafL2mbSql()))
			{
				goto IL_009b;
			}
			num3 = 3;
		}
		else
		{
			num3 = 2;
		}
		double num5 = default(double);
		while (true)
		{
			double num4;
			switch (num3)
			{
			case 3:
				if (num2 <= 0)
				{
					break;
				}
				num5 = htQfSzN6bG1(num2);
				if (num5 > (double)P_1)
				{
					num3 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cf96ea40632b4cc9a71884e2b5dceb8b != 0)
					{
						num3 = 0;
					}
					continue;
				}
				goto case 4;
			case 2:
				return 0L;
			case 4:
				num4 = 0.0 - ((double)P_1 - num5) / I8MfLNiJ00B();
				goto IL_0027;
			case 1:
				{
					num4 = (num5 - (double)P_1) / I8MfLNiJ00B() + 1.0;
					goto IL_0027;
				}
				IL_0027:
				result = num2 + (int)num4;
				num3 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5dcb5c2a8274adf87bda91d76616538 != 0)
				{
					num3 = 0;
				}
				continue;
			}
			break;
		}
		goto IL_009b;
		IL_009b:
		return result;
	}

	public long XHMfxHGqWZ5(int P_0)
	{
		return yrmfx0rxByf(P_0) * PvZk6EDPgZj4f6scxkLq(base.DataProvider);
	}

	public long PrPfxfbFjuK(int P_0, int P_1)
	{
		return Wkgfx2UBnjw(P_0, P_1) * base.DataProvider.UJElnHayjot;
	}

	protected void Scroll()
	{
		int num = default(int);
		int num3;
		if (rJ9fLIKBmCG != 0)
		{
			num = 0;
			int num2 = 14;
			num3 = num2;
		}
		else
		{
			if (!FeAfLZnf8m4 || DgVfLVq3cGG || v6kfLC4GCp6)
			{
				return;
			}
			num3 = 15;
		}
		double num5 = default(double);
		while (true)
		{
			switch (num3)
			{
			case 3:
				if (rJ9fLIKBmCG < 0)
				{
					num3 = 7;
					continue;
				}
				goto case 1;
			case 15:
				if (RT5fxR1KK3E() != 1.0)
				{
					num3 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d3afdd6ad27a4c3b87071f1be51e7ef3 != 0)
					{
						num3 = 0;
					}
					continue;
				}
				return;
			case 7:
				rJ9fLIKBmCG = 0;
				num3 = 2;
				continue;
			case 19:
				return;
			case 18:
				rJ9fLIKBmCG += num;
				if (rJ9fLIKBmCG > 0)
				{
					rJ9fLIKBmCG = 0;
					num3 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5b6218c32bbf4af5965485469fa12538 != 0)
					{
						num3 = 1;
					}
					continue;
				}
				goto case 1;
			case 4:
				return;
			case 8:
				if (rJ9fLIKBmCG <= 300 && -rJ9fLIKBmCG <= 300)
				{
					if (rJ9fLIKBmCG <= 100)
					{
						num3 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1693d43c67f14e0eba9f86b0171ecbd6 == 0)
						{
							num3 = 13;
						}
						continue;
					}
					goto IL_00a4;
				}
				num = 200;
				num3 = 16;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f68538a410dc40459f303c1bac7938ac == 0)
				{
					num3 = 5;
				}
				continue;
			case 12:
				return;
			case 6:
				rJ9fLIKBmCG = (int)(RT5fxR1KK3E() / 2.0 - num5);
				num3 = 19;
				continue;
			case 13:
				if (-rJ9fLIKBmCG > 100)
				{
					goto IL_00a4;
				}
				goto case 9;
			case 20:
			{
				double num4 = RT5fxR1KK3E() / 22.0 * (double)((SH4fZjfBgpnJAYxtUbu4)EVxSBKDPkpbXvmaZX6Ng(base.Settings)).DomScrollValue;
				if (!(num5 < num4))
				{
					if (!(num5 > RT5fxR1KK3E() - num4))
					{
						return;
					}
					num3 = 6;
					continue;
				}
				goto case 6;
			}
			case 14:
				if (j18iDj9nukSCmEyZs5lH.Settings.MarketEnableAnimatedScrolling)
				{
					if (rJ9fLIKBmCG <= 500)
					{
						num3 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_976d29d6825c4c4995e3a2719d735c00 == 0)
						{
							num3 = 5;
						}
						continue;
					}
					goto IL_015a;
				}
				num = Math.Abs(rJ9fLIKBmCG);
				num3 = 11;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_976d29d6825c4c4995e3a2719d735c00 != 0)
				{
					num3 = 1;
				}
				continue;
			case 5:
				if (-rJ9fLIKBmCG > 500)
				{
					goto IL_015a;
				}
				goto case 8;
			case 17:
				rJ9fLIKBmCG -= num;
				num3 = 3;
				continue;
			case 10:
			case 11:
			case 16:
				if (rJ9fLIKBmCG > 0)
				{
					zmafxxlZ8j4(vTGfxShCfWR() + (double)num);
					num3 = 17;
					continue;
				}
				if (rJ9fLIKBmCG < 0)
				{
					zmafxxlZ8j4(vTGfxShCfWR() - (double)num);
					num3 = 18;
					continue;
				}
				goto case 1;
			case 9:
				if (rJ9fLIKBmCG > 40 || -rJ9fLIKBmCG > 40)
				{
					num = 40;
					goto case 10;
				}
				num = qKitmmDPRdddH4L3sBlG(rJ9fLIKBmCG);
				num3 = 5;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_26fe5531b15948b7a2b6ffb2cd927204 == 0)
				{
					num3 = 10;
				}
				continue;
			case 1:
			case 2:
				{
					if (rJ9fLIKBmCG == 0)
					{
						return;
					}
					NeedRedraw();
					num3 = 12;
					continue;
				}
				IL_00a4:
				num = 100;
				goto case 10;
				IL_015a:
				num = ((rJ9fLIKBmCG > 0) ? (rJ9fLIKBmCG - 500) : (-rJ9fLIKBmCG - 500));
				goto case 10;
			}
			if (aT7BV7DP6BvOXHrBDRDC(base.Settings.VisualSettings) == 0)
			{
				return;
			}
			long num6 = dVPfS33e5at();
			if (num6 <= 0)
			{
				num3 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44d9df62f7524f8eb2abdc23baf0c87b == 0)
				{
					num3 = 4;
				}
			}
			else
			{
				num5 = htQfSzN6bG1(num6);
				num3 = 20;
			}
		}
	}

	protected bool E49fx9916px()
	{
		return !qiYfxNLGI6t();
	}

	public void Scroll(int size)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				FeAfLZnf8m4 = false;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dfd8fb340d494755970617a38d3a8729 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				zmafxxlZ8j4(vTGfxShCfWR() + (double)size);
				NeedRedraw();
				return;
			}
		}
	}

	public void ScrollCenter()
	{
		int num = 3;
		int num2 = num;
		long num4 = default(long);
		while (true)
		{
			switch (num2)
			{
			case 3:
				num4 = dVPfS33e5at();
				num2 = 2;
				break;
			default:
				Jrpfxs1LaXL(0);
				num2 = 4;
				break;
			case 2:
				if (num4 <= 0)
				{
					return;
				}
				FeAfLZnf8m4 = true;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_267ca8254fa648cbaa1ba685784f79c7 == 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				NeedRedraw();
				return;
			case 1:
			{
				double num3 = htQfSzN6bG1(num4);
				if (num3 < RT5fxR1KK3E() / 2.0)
				{
					rJ9fLIKBmCG = (int)(RT5fxR1KK3E() / 2.0 - num3);
				}
				else if (num3 > RT5fxR1KK3E() / 2.0)
				{
					rJ9fLIKBmCG = (int)(RT5fxR1KK3E() / 2.0 - num3);
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3a7b10748dce4fec98054526a92d6ccf == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto default;
			}
			}
		}
	}

	[SpecialName]
	public double NrPfxtcKwrD()
	{
		return 0.0;
	}

	[SpecialName]
	public double lnIfxTv20Xx()
	{
		return NrPfxtcKwrD() + PanelWidth;
	}

	[SpecialName]
	public void xQLfxy0PBOC(double P_0)
	{
		if (P_0 > 140.0 && P_0 < nJ7fL9cL9PV() - ByafxzCuIsb() - 20.0)
		{
			base.Settings.VisualSettings.PanelWidth = Math.Max(P_0 - NrPfxtcKwrD(), 140.0);
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ff2c70a81f2141b98b88fc10875a3726 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			NeedRedraw(_0020: true);
		}
	}

	[SpecialName]
	public double VFtfxrtllDW()
	{
		return (int)(ShowPanel ? (lnIfxTv20Xx() + 1.0) : NrPfxtcKwrD());
	}

	[SpecialName]
	public double OXHfxmje5lw()
	{
		return VFtfxrtllDW() + ClusterWidth;
	}

	[SpecialName]
	public void TKRfxhAIgIG(double P_0)
	{
		if (!(P_0 > PanelWidth + 20.0) || !(P_0 < iDafL2mbSql() - 20.0))
		{
			return;
		}
		int num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_976d29d6825c4c4995e3a2719d735c00 != 0)
		{
			num = 0;
		}
		double num2 = default(double);
		while (true)
		{
			switch (num)
			{
			case 1:
				num2 = padfx7SrsRZ() + ClusterWidth;
				kgWfx8fnbCa(dTDfxO2A1eG() - P_0 - DomWidth - 2.0);
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f6b8a9ae320a40f994b0db08d42c2a95 == 0)
				{
					num = 0;
				}
				break;
			default:
				ClusterWidth = num2 - padfx7SrsRZ();
				GJ7fxnuLhYe();
				return;
			}
		}
	}

	private void GJ7fxnuLhYe()
	{
		bool flag = padfx7SrsRZ() > 0.0 && ShowGraph;
		bool flag2 = ClusterWidth > 0.0 && ShowCluster;
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				PdIfxj8xGqp(1.0 - 1.0 / (1.0 + ClusterWidth / padfx7SrsRZ()));
				goto IL_00b5;
			case 3:
				return;
			default:
				OxafxdXtG4e(1.0 - 1.0 / (1.0 + DomWidth / (padfx7SrsRZ() + ClusterWidth)));
				num2 = 3;
				break;
			case 2:
				{
					if (flag && flag2)
					{
						num2 = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_68b6172210394c1b93f49e43376ff3af == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto IL_00b5;
				}
				IL_00b5:
				if (!(flag2 || flag))
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0aea3f4dc28f4bcb92a1f998dc5afbed == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[SpecialName]
	public double padfx7SrsRZ()
	{
		return (int)Math.Max(KAQfLpZakRw, 10.0);
	}

	[SpecialName]
	public void kgWfx8fnbCa(double P_0)
	{
		if (!(Math.Abs(KAQfLpZakRw - P_0) <= 2.0))
		{
			KAQfLpZakRw = Math.Max(P_0, 10.0);
			NeedRedraw(_0020: true);
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_213ef2c0a30c421096ba2b26b8d94124 == 0)
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

	[SpecialName]
	public double AKnfxPJ5PuD()
	{
		if (!ShowCluster)
		{
			return VFtfxrtllDW();
		}
		return OXHfxmje5lw() + 1.0;
	}

	[SpecialName]
	public double LXJfxF1ydT3()
	{
		return AKnfxPJ5PuD() + padfx7SrsRZ();
	}

	[SpecialName]
	private double ByafxzCuIsb()
	{
		return SeFfL5siOPX() + QrafLjASmWS() + 20.0;
	}

	[SpecialName]
	public double iDafL2mbSql()
	{
		return (int)(ShowGraph ? (LXJfxF1ydT3() + 1.0) : AKnfxPJ5PuD());
	}

	[SpecialName]
	public void SnSfLHnDjUT(double P_0)
	{
		int num = 4;
		int num2 = num;
		double num4 = default(double);
		while (true)
		{
			switch (num2)
			{
			case 1:
			{
				double num3 = ClusterWidth;
				ClusterWidth = P_0 - PanelWidth;
				DomWidth += num3 - ClusterWidth;
				goto IL_0034;
			}
			case 2:
				return;
			default:
				if (OXHfxmje5lw() + 20.0 < P_0 && P_0 < dTDfxO2A1eG() - ByafxzCuIsb())
				{
					num4 = padfx7SrsRZ();
					num2 = 5;
					break;
				}
				goto IL_0034;
			case 4:
				if (!ShowGraph)
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c1a63437a5bc4d139ae2c4a2f19ec947 == 0)
					{
						num2 = 3;
					}
					break;
				}
				goto default;
			case 5:
				kgWfx8fnbCa(P_0 - ClusterWidth - PanelWidth);
				DomWidth += num4 - padfx7SrsRZ();
				goto IL_0034;
			case 3:
				{
					if (PanelWidth + 20.0 < P_0 && P_0 < nJ7fL9cL9PV() - ByafxzCuIsb())
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fc665aa6b49746ab985cf6653d959552 != 0)
						{
							num2 = 1;
						}
						break;
					}
					goto default;
				}
				IL_0034:
				GJ7fxnuLhYe();
				num2 = 2;
				break;
			}
		}
	}

	[SpecialName]
	public double nJ7fL9cL9PV()
	{
		return iDafL2mbSql() + DomWidth;
	}

	[SpecialName]
	public Rect xNOfLGFkNxj()
	{
		if (A4EfxeC5DlR() == 0)
		{
			return Rect.Empty;
		}
		return new Rect(OXHfxmje5lw() - 25.0, 5.0, 20.0, 20.0);
	}

	[SpecialName]
	public Rect Y5NfLoAqLjN()
	{
		int num = 1;
		int num2 = num;
		double num5 = default(double);
		int num4 = default(int);
		double num6 = default(double);
		while (true)
		{
			switch (num2)
			{
			case 1:
				num5 = (double)A4EfxeC5DlR() - (double)A4EfxeC5DlR() % JAafLBmjlIV();
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c1a63437a5bc4d139ae2c4a2f19ec947 != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
			{
				double num3 = ((num4 < YenfLiR5VYU()) ? (num5 / JAafLBmjlIV() * (num6 / (double)(YenfLiR5VYU() - num4))) : 0.0);
				return new Rect(new Point(OXHfxmje5lw() - 35.0 - (double)(int)num3, RT5fxR1KK3E() - I8MfLNiJ00B() - 1.0), new Point(OXHfxmje5lw() - 5.0 - (double)(int)num3, RT5fxR1KK3E() - 4.0));
			}
			}
			num4 = (int)((ClusterWidth - 10.0) / JAafLBmjlIV());
			num6 = ClusterWidth - 40.0;
			num2 = 2;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d4badf00eaf04a4c91e3397f36a429cf == 0)
			{
				num2 = 2;
			}
		}
	}

	[SpecialName]
	protected double JAafLBmjlIV()
	{
		return ((LYn4tAf4HSV4yrcb7PrO)Trq2HjDPqVn946J5pLB7(base.Settings)).ClusterWidth;
	}

	[SpecialName]
	protected int YenfLiR5VYU()
	{
		return base.DataProvider.Count;
	}

	[SpecialName]
	protected double gaXfL4xlUvN()
	{
		if (double.IsNaN(I7Yfe2lwjNP))
		{
			I7Yfe2lwjNP = DomWidth;
		}
		return I7Yfe2lwjNP;
	}

	[SpecialName]
	protected void wFDfLDyukVR(double P_0)
	{
		I7Yfe2lwjNP = P_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public double I8MfLNiJ00B()
	{
		return keIfeHHe41V;
	}

	[SpecialName]
	[CompilerGenerated]
	private void CdKfLkRkXP4(double P_0)
	{
		keIfeHHe41V = P_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public double SeFfL5siOPX()
	{
		return hAffefQHa5b;
	}

	[SpecialName]
	[CompilerGenerated]
	private void SAlfLSAZUTr(double P_0)
	{
		hAffefQHa5b = P_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public double xRqfLLPDWBF()
	{
		return BBJfe9Z5ZPb;
	}

	[SpecialName]
	[CompilerGenerated]
	private void rEafLeNMgsY(double P_0)
	{
		BBJfe9Z5ZPb = P_0;
	}

	[SpecialName]
	public double qNyfLX2JT9N()
	{
		return DomWidth - SeFfL5siOPX() - QrafLjASmWS();
	}

	[SpecialName]
	public double QrafLjASmWS()
	{
		return base.Settings.VisualSettings.DomQuoteExtraWidth;
	}

	[SpecialName]
	public bool SvffLQlYotG()
	{
		if ((double)VFrfLUehH2N > iDafL2mbSql() + 12.0)
		{
			return (double)VFrfLUehH2N < nJ7fL9cL9PV() - QrafLjASmWS() - 5.0;
		}
		return false;
	}

	[SpecialName]
	public double GjefLgjcNjp()
	{
		return I8MfLNiJ00B() - 2.0;
	}

	static XrTs9ufSVt0hx8rJDd6l()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		s2GS6FDPILn0mjJVVSyE();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a057f43d61f46eca6f419bc48c31d04 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		lxYfLhgWJDA = (DependencyProperty)pETW1hDPUkyR9qebOQvs(mao5mCDPWrSqy1nNbjaw(-520155535 ^ -520224341), qEBCHKDPtMUuqq0GGLAa(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777377)), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555695)));
	}

	internal static bool Cd01OJDP2sk2XTJscEWD()
	{
		return IJopJlDP0eDG8PRWlLde == null;
	}

	internal static XrTs9ufSVt0hx8rJDd6l xHAhHGDPHDVLIV2FrtHE()
	{
		return IJopJlDP0eDG8PRWlLde;
	}

	internal static object fvFmCgDPfnbsSKH5UNFq(object P_0)
	{
		return ((wFFFvWfsxErbxn4XFmrR)P_0).RaMfsPdL9Ew();
	}

	internal static object pE9F7PDP9y5I9lB1q1CQ(object P_0)
	{
		return ((ypqMIv9maFM0tRwF0xMh)P_0).OpZl98KAYgk();
	}

	internal static double DsQXRWDPnwYK2gj4isf4(object P_0)
	{
		return ((wFFFvWfsxErbxn4XFmrR)P_0).kbVfXfj9hKF();
	}

	internal static bool UqxNIoDPG2O6ng2DMsWe(object P_0, Point P_1)
	{
		return ((wFFFvWfsxErbxn4XFmrR)P_0).qO9fsdxJpJD(P_1);
	}

	internal static bool hOhDPhDPYcC9LdV3Mb8I(object P_0)
	{
		return ((wFFFvWfsxErbxn4XFmrR)P_0).xXsfsgwrgMQ();
	}

	internal static bool f4weqhDPoyvYATHEHRWj(object P_0)
	{
		return ((wFFFvWfsxErbxn4XFmrR)P_0).FbpfsRmJaqh();
	}

	internal static void jkytmbDPvDF8jrKovKvt(object P_0, object P_1, bool P_2)
	{
		((wFFFvWfsxErbxn4XFmrR)P_0).p0TfsW2WHvJ((DxVisualQueue)P_1, P_2);
	}

	internal static void u7ci6kDPB9ccWjftBIi9(object P_0, object P_1)
	{
		((FrameworkElement)P_0).OnRenderSizeChanged((SizeChangedInfo)P_1);
	}

	internal static int G8IXeYDPaUSWexh3XDRL(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static Point r9BydqDPiJabQAe69SHy(object P_0, object P_1)
	{
		return ((MouseEventArgs)P_0).GetPosition((IInputElement)P_1);
	}

	internal static void s1M4UdDPl9QrAFVFn5Tp(object P_0, object P_1)
	{
		((UIElement)P_0).OnMouseMove((MouseEventArgs)P_1);
	}

	internal static bool Cs8WsVDP4Yltn3cKO4ur(object P_0, Point P_1)
	{
		return ((wFFFvWfsxErbxn4XFmrR)P_0).y9WfsqVouY8(P_1);
	}

	internal static bool rnZg1ADPDVGoFPk6Qag1(object P_0)
	{
		return ((TradingSettings)P_0).ShowCluster;
	}

	internal static bool a5yI93DPbxjm1n5hAAqA(object P_0)
	{
		return ((TradingSettings)P_0).ShowGraph;
	}

	internal static int hlxMjhDPNdxWyKCB8lhb(object P_0)
	{
		return ((SH4fZjfBgpnJAYxtUbu4)P_0).DomQuoteExtraWidth;
	}

	internal static object EVxSBKDPkpbXvmaZX6Ng(object P_0)
	{
		return ((MarketSettings)P_0).VisualSettings;
	}

	internal static double x3GjYGDP17mctJxVwkyr(double P_0, double P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static object fwJp4hDP5vn3UxGfuJGS(object P_0)
	{
		return ((ypqMIv9maFM0tRwF0xMh)P_0).Symbol;
	}

	internal static object TQLEdrDPSWG0s410a6ah()
	{
		return j18iDj9nukSCmEyZs5lH.Settings;
	}

	internal static decimal PVMEKVDPxHWL5rOjm1UD(object P_0)
	{
		return ((MhMDPU9v8rkigy1ao0Th)P_0).MaxPriceWithoutHidingZeroes;
	}

	internal static double PRWJCVDPLCFdBmnNL0D0(double P_0)
	{
		return Math.Abs(P_0);
	}

	internal static int QogbLdDPetZ7MoK6NZbE(double P_0, int P_1)
	{
		return xJABt8GfQN3bpiGT4k9G.KV0Gf6GmrTy(P_0, P_1);
	}

	internal static object DHnlVuDPslpxXOeg9180(object P_0, long P_1, bool P_2, int P_3)
	{
		return ((ijsjhhnGTadfwpOyDdrx)P_0).FqunGmNxUTm(P_1, P_2, P_3);
	}

	internal static double w7g6OvDPXdy3wVHgbRvR(decimal P_0)
	{
		return (double)P_0;
	}

	internal static object JTVA5bDPcnqgKT7eMZRf(object P_0)
	{
		return ((MarketSettings)P_0).BaseBoldFont;
	}

	internal static object pNhswRDPjaGdGLtptulO(object P_0)
	{
		return ((MarketSettings)P_0).PositionStatsFont;
	}

	internal static Size EP2S6TDPEYJf97fMmoN8(object P_0)
	{
		return ((UIElement)P_0).RenderSize;
	}

	internal static double Gr8JsXDPQCmb0oIEYa3g(object P_0)
	{
		return ((TradingSettings)P_0).a0bzx3ZHvi;
	}

	internal static object JfMWtaDPdyQJsFPioSFK(object P_0)
	{
		return ((ypqMIv9maFM0tRwF0xMh)P_0).lEVl9w6fCd9();
	}

	internal static int PvZk6EDPgZj4f6scxkLq(object P_0)
	{
		return ((ypqMIv9maFM0tRwF0xMh)P_0).UJElnHayjot;
	}

	internal static int qKitmmDPRdddH4L3sBlG(int P_0)
	{
		return Math.Abs(P_0);
	}

	internal static int aT7BV7DP6BvOXHrBDRDC(object P_0)
	{
		return ((SH4fZjfBgpnJAYxtUbu4)P_0).DomScrollValue;
	}

	internal static double CdRh6sDPMQ9FugkOVT0f(object P_0)
	{
		return ((TradingSettings)P_0).DomWidth;
	}

	internal static void B2dtktDPOlSIgWExEE7v(object P_0, double P_1)
	{
		((TradingSettings)P_0).DomWidth = P_1;
	}

	internal static object Trq2HjDPqVn946J5pLB7(object P_0)
	{
		return ((MarketSettings)P_0).ClusterSettings;
	}

	internal static void s2GS6FDPILn0mjJVVSyE()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static object mao5mCDPWrSqy1nNbjaw(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static Type qEBCHKDPtMUuqq0GGLAa(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object pETW1hDPUkyR9qebOQvs(object P_0, Type P_1, Type P_2)
	{
		return DependencyProperty.Register((string)P_0, P_1, P_2);
	}
}
