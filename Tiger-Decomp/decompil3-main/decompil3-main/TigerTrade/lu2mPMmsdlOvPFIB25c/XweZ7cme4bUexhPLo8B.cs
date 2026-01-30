using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using A7PBFkrUtbNj4gSdVX7;
using aEpmU09nz6MEoNmc0pGJ;
using bFLVeaGpb14YNScYcv2Q;
using De5nppfnpARnAi0A5Za4;
using ECOEgqlSad8NUJZ2Dr9n;
using GPyoH8nl49gHjhie6KCl;
using i4WYHmmGr6wQtBbGc24;
using J3rFECfGQmHQ9sLCyCue;
using kaGY6vnlotCyCWw7ZhD5;
using l5fyixCdr9wYCP9KK6I;
using NTmQ5FKKLKAqov4Q8M1;
using pj0D9xfYObu44WjqZJeq;
using QP1pXiZJsqJcfmyhm4k;
using TigerTrade.Chart.Alerts;
using TigerTrade.Config.Common;
using TigerTrade.Core.Utils.Logging;
using TigerTrade.Core.Utils.Time;
using TigerTrade.Dx;
using TigerTrade.Dx.Enums;
using TigerTrade.Properties;
using TigerTrade.Tc.Data;
using TigerTrade.UI.DocControls.SmartTape.Settings.Enums;
using TuAMtrl1Nd3XoZQQUXf0;
using vG0WidHawbhpKdkcelf8;
using xfdMo0lS4TP9pN36Goka;

namespace lu2mPMmsdlOvPFIB25c;

[ToolboxItem(false)]
internal class XweZ7cme4bUexhPLo8B : UserControl, IComponentConnector
{
	[Serializable]
	[CompilerGenerated]
	private sealed class aDnbJTnXxaSE5LH4py42
	{
		public static readonly aDnbJTnXxaSE5LH4py42 HKrnXc7lbqr;

		public static Func<DataGridColumn, bool> qT7nXjXiQnn;

		public static Func<DataGridColumn, int> CKFnXE5rwm2;

		public static Func<DataGridColumn, bool> dwPnXQ28JSv;

		public static Func<DataGridColumn, bool> GRFnXd7weQB;

		private static aDnbJTnXxaSE5LH4py42 yRSLUyNBrbHy1dw73xxL;

		static aDnbJTnXxaSE5LH4py42()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			HKrnXc7lbqr = new aDnbJTnXxaSE5LH4py42();
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44265f4417e640c7a760a59a950624e5 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		public aDnbJTnXxaSE5LH4py42()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			base._002Ector();
		}

		internal bool OennXLrMqFJ(DataGridColumn c)
		{
			return c.Visibility == Visibility.Visible;
		}

		internal int sVSnXeXvKsP(DataGridColumn c)
		{
			return c.DisplayIndex;
		}

		internal bool rg7nXssdPgA(DataGridColumn c)
		{
			return (string)jEUt1mNBhct80vgtoOVx(c) == (string)Rb07ggNBwoc9suxjA0CP(-1774602229 ^ -1774586325);
		}

		internal bool js8nXXIJL9t(DataGridColumn c)
		{
			return c.SortMemberPath == (string)Rb07ggNBwoc9suxjA0CP(-1251569705 ^ -1251565443);
		}

		internal static bool NWsjRONBKpgbMcHKhrP4()
		{
			return yRSLUyNBrbHy1dw73xxL == null;
		}

		internal static aDnbJTnXxaSE5LH4py42 hQ6r7bNBmeYmkaFN6WL1()
		{
			return yRSLUyNBrbHy1dw73xxL;
		}

		internal static object jEUt1mNBhct80vgtoOVx(object P_0)
		{
			return ((DataGridColumn)P_0).SortMemberPath;
		}

		internal static object Rb07ggNBwoc9suxjA0CP(int P_0)
		{
			return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
		}
	}

	private readonly DxVisualQueue pxLmF82mRY;

	private readonly double e1rm3oGsyr;

	private readonly double fW2mpSNNb9;

	[CompilerGenerated]
	private Gv6oHWnllm288kdP8Rlo ATFmugcUom;

	[CompilerGenerated]
	private string F10mzfbvbg;

	[CompilerGenerated]
	private u0GAIHHahyHxCr1XJKud fHHh0WTn0v;

	public static readonly DependencyProperty di4h2oG9vy;

	private f3LRAlrtSOUwGiXtTI7 lxNhHFREUZ;

	private Symbol lOqhfOH6B1;

	private readonly LinkedList<MkBOssmnh52O7dtV8L1> Brxh9y9kKD;

	private readonly mWBbBYKr0D7o7FHQ0gP UOthnLtVQQ;

	private int p6OhGeSTFM;

	private double jxLhY56dN4;

	private double iaxhopakMs;

	private LinkedListNode<MkBOssmnh52O7dtV8L1> jjOhv7Bviw;

	private LinkedListNode<MkBOssmnh52O7dtV8L1> woQhB2wYKq;

	private bool lNAhaOWUs4;

	private bool klRhi65EXJ;

	internal DxHwndHost HwndHost;

	private bool mAXhlrmxM2;

	internal static XweZ7cme4bUexhPLo8B wj8uYD4kn42NfMCsjrRV;

	public double HorizontalScrollOffset
	{
		get
		{
			return (double)GetValue(di4h2oG9vy);
		}
		set
		{
			n62W5n4kBTETGVIRphOf(this, di4h2oG9vy, num);
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public void eBZmARjN5d(Gv6oHWnllm288kdP8Rlo P_0)
	{
		int num = 2;
		int num2 = num;
		Gv6oHWnllm288kdP8Rlo gv6oHWnllm288kdP8Rlo2 = default(Gv6oHWnllm288kdP8Rlo);
		Gv6oHWnllm288kdP8Rlo gv6oHWnllm288kdP8Rlo = default(Gv6oHWnllm288kdP8Rlo);
		while (true)
		{
			switch (num2)
			{
			default:
			{
				Gv6oHWnllm288kdP8Rlo value = (Gv6oHWnllm288kdP8Rlo)pd653V4koBheydsijZv3(gv6oHWnllm288kdP8Rlo2, P_0);
				gv6oHWnllm288kdP8Rlo = Interlocked.CompareExchange(ref ATFmugcUom, value, gv6oHWnllm288kdP8Rlo2);
				if ((object)gv6oHWnllm288kdP8Rlo == gv6oHWnllm288kdP8Rlo2)
				{
					return;
				}
				goto case 1;
			}
			case 1:
				gv6oHWnllm288kdP8Rlo2 = gv6oHWnllm288kdP8Rlo;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a337f255b1bd4e8290c28001e28630dc != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				gv6oHWnllm288kdP8Rlo = ATFmugcUom;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1db4437ae4614880b2ad46efdc78cb73 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public void Vp0mPFCGYm(Gv6oHWnllm288kdP8Rlo P_0)
	{
		int num = 2;
		int num2 = num;
		Gv6oHWnllm288kdP8Rlo gv6oHWnllm288kdP8Rlo = default(Gv6oHWnllm288kdP8Rlo);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				gv6oHWnllm288kdP8Rlo = ATFmugcUom;
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f027e87a9f614f4a92c0338386fb11cd == 0)
				{
					num2 = 1;
				}
				continue;
			case 1:
				break;
			}
			Gv6oHWnllm288kdP8Rlo gv6oHWnllm288kdP8Rlo2;
			do
			{
				gv6oHWnllm288kdP8Rlo2 = gv6oHWnllm288kdP8Rlo;
				Gv6oHWnllm288kdP8Rlo value = (Gv6oHWnllm288kdP8Rlo)uJPRPa4kv7jx3BrdndI9(gv6oHWnllm288kdP8Rlo2, P_0);
				gv6oHWnllm288kdP8Rlo = Interlocked.CompareExchange(ref ATFmugcUom, value, gv6oHWnllm288kdP8Rlo2);
			}
			while ((object)gv6oHWnllm288kdP8Rlo != gv6oHWnllm288kdP8Rlo2);
			num2 = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6b48af76ce0b4c779ac34c27953eddda == 0)
			{
				num2 = 0;
			}
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public string wKYmC9PyOS()
	{
		return F10mzfbvbg;
	}

	[SpecialName]
	[CompilerGenerated]
	public void lQsmrrnqJu(string P_0)
	{
		F10mzfbvbg = P_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public u0GAIHHahyHxCr1XJKud aaNmmlZjW4()
	{
		return fHHh0WTn0v;
	}

	[SpecialName]
	[CompilerGenerated]
	public void kWemhIZUgv(u0GAIHHahyHxCr1XJKud P_0)
	{
		fHHh0WTn0v = P_0;
	}

	public XweZ7cme4bUexhPLo8B()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		pxLmF82mRY = new DxVisualQueue();
		e1rm3oGsyr = 2.0;
		fW2mpSNNb9 = 4.0;
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1c0cedb54d2b44a7af3d63420e8a1767 != 0)
		{
			num = 3;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				UOthnLtVQQ.TPyK7o8uVd(bJsmRU4DdQ);
				UOthnLtVQQ.m19KPipL6s(rOpm6qCMuS);
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8692846774e94af58ff2b2b243743e02 != 0)
				{
					num = 0;
				}
				break;
			case 3:
				InitializeComponent();
				Brxh9y9kKD = new LinkedList<MkBOssmnh52O7dtV8L1>();
				UOthnLtVQQ = new mWBbBYKr0D7o7FHQ0gP();
				num = 2;
				break;
			case 4:
				HwndHost.StartTimer(25);
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3cfcda862e0540cbb9abf65446a10635 != 0)
				{
					num = 1;
				}
				break;
			default:
				Ct8IyA4kaeen99le02ng(UOthnLtVQQ, new Action(x9nmMPgLXq));
				HwndHost.OnRenderVisual += WaLmIZlS7H;
				num = 4;
				break;
			case 1:
				return;
			}
		}
	}

	public void zJnmXteSEI()
	{
		int num = 1;
		int num2 = num;
		MkBOssmnh52O7dtV8L1 mkBOssmnh52O7dtV8L = default(MkBOssmnh52O7dtV8L1);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 3:
				if (RUq1kT4k4X4HIpgbmLN4(Wnd4Hl4klCpgRv4lUgoD() - mkBOssmnh52O7dtV8L.FkUmY8RiBU, TimeSpan.FromSeconds(2.0)))
				{
					HwndHost.InvalidateVisual();
				}
				return;
			case 2:
				if (mkBOssmnh52O7dtV8L == null)
				{
					return;
				}
				num2 = 3;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03c20a54a7dc45f8a5130d4984fa4aea == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 1:
				if (lNAhaOWUs4)
				{
					mkBOssmnh52O7dtV8L = ((vb70IB4kiOcny6jj1YFW(Brxh9y9kKD) > 0) ? Brxh9y9kKD.Last() : null);
					num2 = 2;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7573e3aca29a46a9959af01ed2386da5 != 0)
					{
						num2 = 2;
					}
				}
				else
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_45006ec5334a406896281e648c9b6ca0 == 0)
					{
						num2 = 0;
					}
				}
				break;
			}
		}
	}

	public void cv5mc00jwU(f3LRAlrtSOUwGiXtTI7 P_0)
	{
		lxNhHFREUZ = P_0;
		jdtmjYgcGe();
	}

	public void jdtmjYgcGe()
	{
		T4D9pR4kDvUwDMSI5bwP(UOthnLtVQQ, lxNhHFREUZ.GeneralSettings.AggregateTicks);
	}

	public void dkMmE8eXnr(TickEvent P_0)
	{
		Uhob4B4kbOPT5qSUJOEl(UOthnLtVQQ, P_0);
	}

	public void Jj8mQbnmRU(List<MkBOssmnh52O7dtV8L1> P_0)
	{
		x9nmMPgLXq();
		foreach (MkBOssmnh52O7dtV8L1 item in P_0)
		{
			Brxh9y9kKD.AddLast(item);
		}
		M7omOhidKy();
		DN2mtm0veC();
	}

	public Symbol p6ImdZyrIK()
	{
		return lOqhfOH6B1;
	}

	public void kgrmgEonhE(Symbol P_0)
	{
		lOqhfOH6B1 = P_0;
		Clear();
	}

	public void Clear()
	{
		p6OhGeSTFM = 0;
		abVjB24kNWAXQIC0r1kD(UOthnLtVQQ);
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5dcb5c2a8274adf87bda91d76616538 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		DN2mtm0veC();
	}

	private void bJsmRU4DdQ(MkBOssmnh52O7dtV8L1 P_0)
	{
		double num = m9D2Qc4kkJBZt2g9YqL5(lOqhfOH6B1, P_0.Size);
		double? num2 = lxNhHFREUZ.GeneralSettings.MinSize;
		double? num3 = ((miUjgiCQ4L4boFEaJpD)WgURgG4k1v9Da5blS0Pl(lxNhHFREUZ)).MaxSize;
		int num4 = 4;
		double? num5 = default(double?);
		while (true)
		{
			switch (num4)
			{
			case 3:
				num5 = num2;
				if (!(num < num5))
				{
					num4 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1bb232d361564d93b9a5d5e53983bdb3 == 0)
					{
						num4 = 1;
					}
					continue;
				}
				goto default;
			case 4:
				if (p6OhGeSTFM > 0)
				{
					num5 = num2;
					num4 = 2;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8692846774e94af58ff2b2b243743e02 != 0)
					{
						num4 = 1;
					}
					continue;
				}
				goto default;
			default:
				Brxh9y9kKD.AddLast(P_0);
				PrSmq5xa0S(P_0);
				M7omOhidKy();
				num4 = 6;
				continue;
			case 2:
				if (num5 >= 0.0)
				{
					num4 = 3;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6d472511f0d246a693dc7622dda5f390 != 0)
					{
						num4 = 0;
					}
					continue;
				}
				goto case 1;
			case 5:
				break;
			case 6:
				return;
			case 1:
				num5 = num3;
				if (!(num5 >= 0.0))
				{
					break;
				}
				num5 = num3;
				if (!(num > num5))
				{
					break;
				}
				goto default;
			}
			p6OhGeSTFM++;
			num4 = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d9af442440454effa9efd8da8e33ec96 == 0)
			{
				num4 = 0;
			}
		}
	}

	private void rOpm6qCMuS(MkBOssmnh52O7dtV8L1 P_0)
	{
		PrSmq5xa0S(P_0);
		M7omOhidKy();
	}

	private void x9nmMPgLXq()
	{
		Brxh9y9kKD.Clear();
		jjOhv7Bviw = null;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c7e1deb64093431d91d263a2e49f884b == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				iaxhopakMs = 0.0;
				return;
			}
			woQhB2wYKq = null;
			jxLhY56dN4 = 0.0;
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d49d1aa54d194934871b103e21669e22 == 0)
			{
				num = 1;
			}
		}
	}

	private void M7omOhidKy()
	{
		int num = 15;
		double num3 = default(double);
		DateTime? dateTime = default(DateTime?);
		DateTime time = default(DateTime);
		LinkedListNode<MkBOssmnh52O7dtV8L1> last = default(LinkedListNode<MkBOssmnh52O7dtV8L1>);
		DateTime dateTime2 = default(DateTime);
		double realSize = default(double);
		MkBOssmnh52O7dtV8L1 value = default(MkBOssmnh52O7dtV8L1);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					if (jxLhY56dN4 >= num3)
					{
						jxLhY56dN4 -= num3;
						num2 = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d9af442440454effa9efd8da8e33ec96 != 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto IL_00d6;
				case 15:
					if (!klRhi65EXJ)
					{
						return;
					}
					goto end_IL_0012;
				case 12:
					if (!dateTime.HasValue)
					{
						num2 = 10;
						continue;
					}
					if (!(dateTime.GetValueOrDefault() <= time))
					{
						break;
					}
					goto case 7;
				case 14:
					if (vb70IB4kiOcny6jj1YFW(Brxh9y9kKD) == 0)
					{
						num2 = 16;
						continue;
					}
					if (jjOhv7Bviw == null)
					{
						jjOhv7Bviw = Brxh9y9kKD.First;
					}
					if (woQhB2wYKq == null)
					{
						woQhB2wYKq = Brxh9y9kKD.Last;
					}
					last = Brxh9y9kKD.Last;
					dateTime2 = last.Value.Time.AddSeconds(-s06YC24k5G2cxbRp54D0(lxNhHFREUZ.GeneralSettings));
					goto IL_027c;
				case 1:
				case 8:
					iaxhopakMs += realSize;
					num2 = 6;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0fb8c8dbf8424ce68f439b7b66291a33 == 0)
					{
						num2 = 3;
					}
					continue;
				default:
					realSize = lOqhfOH6B1.GetRealSize(value.Size);
					num2 = 11;
					continue;
				case 16:
					return;
				case 11:
					if (value.UGTmvvUvFE != Side.Buy)
					{
						num2 = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f40a817752724303a7406a720886b183 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 3;
				case 13:
					dateTime = woQhB2wYKq?.Value.Time;
					num2 = 4;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dbdafa2a3c4c4a799fde97744d4aedd0 != 0)
					{
						num2 = 4;
					}
					continue;
				case 6:
					woQhB2wYKq = woQhB2wYKq.Next;
					num2 = 8;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dd6de048cd134da6b2674c002762ca45 != 0)
					{
						num2 = 13;
					}
					continue;
				case 4:
					time = last.Value.Time;
					num2 = 12;
					continue;
				case 3:
					jxLhY56dN4 += realSize;
					goto case 6;
				case 2:
					jjOhv7Bviw = jjOhv7Bviw.Next;
					goto IL_027c;
				case 9:
					return;
				case 7:
					value = woQhB2wYKq.Value;
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_35216e71f4e34e739f4a05a1213f3579 != 0)
					{
						num2 = 0;
					}
					continue;
				case 10:
					break;
					IL_027c:
					if (jjOhv7Bviw.Value.Time < dateTime2)
					{
						MkBOssmnh52O7dtV8L1 value2 = jjOhv7Bviw.Value;
						num3 = m9D2Qc4kkJBZt2g9YqL5(lOqhfOH6B1, value2.Size);
						if (value2.UGTmvvUvFE == Side.Buy)
						{
							num2 = 5;
							continue;
						}
						goto IL_00d6;
					}
					goto case 13;
					IL_00d6:
					if (iaxhopakMs >= num3)
					{
						iaxhopakMs -= num3;
					}
					goto case 2;
				}
				num2 = 9;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8692846774e94af58ff2b2b243743e02 != 0)
				{
					num2 = 5;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 14;
		}
	}

	private void PrSmq5xa0S(MkBOssmnh52O7dtV8L1 P_0)
	{
		int num = 16;
		double realSize = default(double);
		double? num7 = default(double?);
		double? num12 = default(double?);
		double? num4 = default(double?);
		syGBQLZPrWA2UUI6eRT syGBQLZPrWA2UUI6eRT = default(syGBQLZPrWA2UUI6eRT);
		double? num5 = default(double?);
		double num11 = default(double);
		ChartAlertSettings chartAlertSettings = default(ChartAlertSettings);
		double? num16 = default(double?);
		double? num13 = default(double?);
		double? num3 = default(double?);
		double? num17 = default(double?);
		double? num8 = default(double?);
		double? num19 = default(double?);
		double? num9 = default(double?);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				double num15;
				double num27;
				switch (num2)
				{
				case 16:
					realSize = lOqhfOH6B1.GetRealSize(P_0.Size);
					num2 = 15;
					continue;
				case 36:
				{
					double num26 = realSize;
					num7 = num12;
					if (num26 >= num7)
					{
						goto IL_0129;
					}
					goto case 22;
				}
				case 19:
					num4 = syGBQLZPrWA2UUI6eRT.MinSize1;
					num5 = syGBQLZPrWA2UUI6eRT.MaxSize1;
					num2 = 18;
					continue;
				case 6:
				{
					double num25 = realSize;
					num7 = num5;
					if (num25 <= num7)
					{
						num2 = 3;
						continue;
					}
					goto case 31;
				}
				case 14:
					if (wb7l284kxIByJ2CFjhAD(syGBQLZPrWA2UUI6eRT) != SmartTapeTickSide.Any)
					{
						if (syGBQLZPrWA2UUI6eRT.TickSide2 == SmartTapeTickSide.Buy)
						{
							num2 = 42;
							continue;
						}
						goto IL_0117;
					}
					goto IL_043e;
				case 8:
				case 20:
					num12 = syGBQLZPrWA2UUI6eRT.MinSize4;
					num2 = 35;
					continue;
				default:
					num11 = num12.Value;
					num2 = 32;
					continue;
				case 1:
					if (OJxfvV4kS07YWx5GTxqL(syGBQLZPrWA2UUI6eRT) == SmartTapeTickSide.Sell)
					{
						num2 = 12;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c7e1deb64093431d91d263a2e49f884b == 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 31;
				case 21:
					chartAlertSettings = syGBQLZPrWA2UUI6eRT.Alert2;
					num2 = 24;
					continue;
				case 40:
					if (P_0.UGTmvvUvFE != Side.Buy)
					{
						num2 = 27;
						continue;
					}
					goto default;
				case 27:
					if (syGBQLZPrWA2UUI6eRT.TickSide4 == SmartTapeTickSide.Sell && P_0.UGTmvvUvFE == Side.Sell)
					{
						goto default;
					}
					goto case 22;
				case 30:
				{
					double num21 = realSize;
					num7 = num16;
					if (!(num21 >= num7))
					{
						goto case 24;
					}
					goto IL_09ba;
				}
				case 17:
					if (chartAlertSettings.IsActive && !(P_0.mYPmiEPd6F >= num11))
					{
						P_0.mYPmiEPd6F = num11;
						ChartAlertInfo chartAlertInfo = new ChartAlertInfo(chartAlertSettings, string.Format((string)HbBYvZ4kXOmLDaaIeq3n(), lOqhfOH6B1.FormatSize(P_0.mYPmiEPd6F)));
						c8EcTUfGEuMy2llFqsdF.EysfGdYxekX(new Iafnb1fn3j4C49y3SFn7(wKYmC9PyOS(), (krjr6dfYMJotfdc9ATKx)3, lOqhfOH6B1.ID, (string)CDOVA44kcJ6Yt9Ypj1fq(lOqhfOH6B1), lOqhfOH6B1.Exchange, (string)E0cRWM4kjM0Hih1OTUIb(chartAlertInfo), chartAlertInfo.Duration, chartAlertInfo.ShowPopup, UZQAe64kEF6k7VFPkUWT(chartAlertInfo), chartAlertInfo.SendTelegram, chartAlertInfo.Message, chartAlertInfo.Log));
					}
					return;
				case 31:
					num16 = syGBQLZPrWA2UUI6eRT.MinSize2;
					num13 = syGBQLZPrWA2UUI6eRT.MaxSize2;
					if (!num16.HasValue)
					{
						num2 = 13;
						continue;
					}
					goto IL_03f0;
				case 18:
					if (!num4.HasValue && !num5.HasValue)
					{
						goto case 31;
					}
					if (num4.HasValue)
					{
						double num6 = realSize;
						num7 = num4;
						if (!(num6 >= num7))
						{
							goto case 31;
						}
					}
					if (num5.HasValue)
					{
						goto case 6;
					}
					goto case 3;
				case 25:
					num3 = syGBQLZPrWA2UUI6eRT.MaxSize3;
					num2 = 23;
					continue;
				case 29:
					if (OJxfvV4kS07YWx5GTxqL(syGBQLZPrWA2UUI6eRT) != SmartTapeTickSide.Any)
					{
						if (syGBQLZPrWA2UUI6eRT.TickSide1 != SmartTapeTickSide.Buy)
						{
							goto case 1;
						}
						if (P_0.UGTmvvUvFE != Side.Buy)
						{
							num2 = 1;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0b22b597497745f5ab911eaabff065eb == 0)
							{
								num2 = 1;
							}
							continue;
						}
					}
					goto case 38;
				case 38:
					num11 = num4.Value;
					num2 = 26;
					continue;
				case 42:
					if (P_0.UGTmvvUvFE != Side.Buy)
					{
						goto IL_0117;
					}
					goto IL_043e;
				case 11:
				{
					double num10 = num11;
					num7 = num12;
					if (!(num10 < num7))
					{
						goto case 22;
					}
					if (syGBQLZPrWA2UUI6eRT.TickSide4 == SmartTapeTickSide.Any)
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_43d123ebfe574af38268397bb0ae2d1a != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 10;
				}
				case 5:
					return;
				case 3:
				{
					double num18 = num11;
					num7 = num4;
					if (!(num18 < num7))
					{
						goto case 31;
					}
					goto case 29;
				}
				case 22:
					if (chartAlertSettings == null)
					{
						num2 = 5;
						continue;
					}
					goto case 17;
				case 13:
					if (num13.HasValue)
					{
						goto IL_03f0;
					}
					goto case 24;
				case 10:
					if (syGBQLZPrWA2UUI6eRT.TickSide4 == SmartTapeTickSide.Buy)
					{
						num2 = 40;
						continue;
					}
					goto case 27;
				case 34:
				{
					if (num3.HasValue)
					{
						double num23 = realSize;
						num7 = num3;
						if (!(num23 <= num7))
						{
							goto case 8;
						}
					}
					double num24 = num11;
					num7 = num17;
					if (num24 < num7)
					{
						if (qCfrTv4kLVDeKCyk7co7(syGBQLZPrWA2UUI6eRT) != SmartTapeTickSide.Any)
						{
							num2 = 1;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f10da6c70e49485dae21f57ce3741184 == 0)
							{
								num2 = 7;
							}
							continue;
						}
						goto case 37;
					}
					num2 = 5;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1bb232d361564d93b9a5d5e53983bdb3 == 0)
					{
						num2 = 20;
					}
					continue;
				}
				case 41:
				{
					double num22 = realSize;
					num7 = num17;
					if (num22 >= num7)
					{
						num2 = 12;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a93c63471a5d4726b3bdf40a69cdb422 != 0)
						{
							num2 = 34;
						}
						continue;
					}
					goto case 8;
				}
				case 7:
					if (syGBQLZPrWA2UUI6eRT.TickSide3 == SmartTapeTickSide.Buy && P_0.UGTmvvUvFE == Side.Buy)
					{
						goto case 37;
					}
					if (qCfrTv4kLVDeKCyk7co7(syGBQLZPrWA2UUI6eRT) == SmartTapeTickSide.Sell)
					{
						num2 = 4;
						continue;
					}
					goto case 8;
				case 2:
					if (realSize < num8)
					{
						return;
					}
					goto case 39;
				case 9:
					num11 = 0.0;
					chartAlertSettings = null;
					num2 = 19;
					continue;
				case 26:
					chartAlertSettings = syGBQLZPrWA2UUI6eRT.Alert1;
					num2 = 31;
					continue;
				case 33:
					if (num12.HasValue || num19.HasValue)
					{
						if (!num12.HasValue)
						{
							goto IL_0129;
						}
						goto case 36;
					}
					goto case 22;
				case 12:
					if (P_0.UGTmvvUvFE == Side.Sell)
					{
						num2 = 38;
						continue;
					}
					goto case 31;
				case 24:
					num17 = syGBQLZPrWA2UUI6eRT.MinSize3;
					num2 = 25;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8b8f48487ce54157a86b0385feea16a6 == 0)
					{
						num2 = 18;
					}
					continue;
				case 28:
					if (num7 >= 0.0)
					{
						double num20 = realSize;
						num7 = num9;
						if (num20 > num7)
						{
							return;
						}
					}
					syGBQLZPrWA2UUI6eRT = lxNhHFREUZ.AlertsSettings;
					num2 = 9;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_45006ec5334a406896281e648c9b6ca0 == 0)
					{
						num2 = 9;
					}
					continue;
				case 35:
					num19 = syGBQLZPrWA2UUI6eRT.MaxSize4;
					num2 = 9;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6b9913e777f24c1abc91fbc34d2bcc9c != 0)
					{
						num2 = 33;
					}
					continue;
				case 32:
					break;
				case 39:
					num7 = num9;
					num2 = 28;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2e936b892f094d0a971af950fe8f46f7 != 0)
					{
						num2 = 1;
					}
					continue;
				case 23:
					if (num17.HasValue || num3.HasValue)
					{
						if (num17.HasValue)
						{
							num2 = 41;
							continue;
						}
						goto case 34;
					}
					num2 = 8;
					continue;
				case 15:
					num8 = lxNhHFREUZ.GeneralSettings.MinSize;
					num9 = lxNhHFREUZ.GeneralSettings.MaxSize;
					num7 = num8;
					if (!(num7 >= 0.0))
					{
						num2 = 5;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8a9257c2b61741afa02a8ceb1f69ad69 != 0)
						{
							num2 = 39;
						}
						continue;
					}
					goto case 2;
				case 4:
					if (P_0.UGTmvvUvFE == Side.Sell)
					{
						num2 = 37;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8c53e9716bd4846babfdefcdb92a575 != 0)
						{
							num2 = 33;
						}
						continue;
					}
					goto case 8;
				case 37:
					{
						num11 = num17.Value;
						chartAlertSettings = (ChartAlertSettings)IF7gPp4ke0Bb0bDIMpPT(syGBQLZPrWA2UUI6eRT);
						goto case 8;
					}
					IL_09ba:
					if (num13.HasValue)
					{
						double num14 = realSize;
						num7 = num13;
						if (!(num14 <= num7))
						{
							goto case 24;
						}
					}
					num15 = num11;
					num7 = num16;
					if (num15 < num7)
					{
						goto case 14;
					}
					goto case 24;
					IL_0117:
					if (syGBQLZPrWA2UUI6eRT.TickSide2 == SmartTapeTickSide.Sell && P_0.UGTmvvUvFE == Side.Sell)
					{
						goto IL_043e;
					}
					goto case 24;
					IL_043e:
					num11 = num16.Value;
					num2 = 21;
					continue;
					IL_03f0:
					if (num16.HasValue)
					{
						num2 = 30;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8b6bac13ae314900826ed96af7afc27b == 0)
						{
							num2 = 7;
						}
						continue;
					}
					goto IL_09ba;
					IL_0129:
					if (!num19.HasValue)
					{
						goto case 11;
					}
					num27 = realSize;
					num7 = num19;
					if (num27 <= num7)
					{
						num2 = 11;
						continue;
					}
					goto case 22;
				}
				break;
			}
			chartAlertSettings = (ChartAlertSettings)z5dWmr4ksmpLGv5YbR2I(syGBQLZPrWA2UUI6eRT);
			num = 22;
		}
	}

	private void WaLmIZlS7H(bool P_0)
	{
		try
		{
			pxLmF82mRY.Set(HwndHost.ClientRect);
			pxLmF82mRY.Clear(SqgCUI4kd12HbpNUALxo((j18iDj9nukSCmEyZs5lH.Settings.AppTheme == AppTheme.MetroDark) ? GJbW8q4kQQ6PVrHVx7Fk(byte.MaxValue, 37, 37, 38) : Color.FromArgb(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue)));
			int num;
			if (aaNmmlZjW4() != null && lOqhfOH6B1 != null)
			{
				q4QmWaQBBw(pxLmF82mRY);
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9d6f131f80d34ede83451138b928a86f == 0)
				{
					num = 0;
				}
				goto IL_0026;
			}
			goto IL_0038;
			IL_0026:
			switch (num)
			{
			case 1:
				return;
			}
			goto IL_0038;
			IL_0038:
			HwndHost.Render(pxLmF82mRY, null);
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2039997ab6194b398d07bcb5d664c971 == 0)
			{
				num = 1;
			}
			goto IL_0026;
		}
		catch (Exception ex)
		{
			n5wkbE4kgRQ1W1wGwOry(ex);
		}
	}

	private void q4QmWaQBBw(DxVisualQueue P_0)
	{
		double? num = ((miUjgiCQ4L4boFEaJpD)WgURgG4k1v9Da5blS0Pl(lxNhHFREUZ)).MinSize;
		double? num2 = ((miUjgiCQ4L4boFEaJpD)WgURgG4k1v9Da5blS0Pl(lxNhHFREUZ)).MaxSize;
		double num3 = e1rm3oGsyr;
		int num4 = 62;
		int num27 = default(int);
		syGBQLZPrWA2UUI6eRT syGBQLZPrWA2UUI6eRT = default(syGBQLZPrWA2UUI6eRT);
		double num8 = default(double);
		double? num15 = default(double?);
		XBrush xBrush = default(XBrush);
		double? num10 = default(double?);
		double? num21 = default(double?);
		double realSize = default(double);
		double? num9 = default(double?);
		LinkedListNode<MkBOssmnh52O7dtV8L1> linkedListNode = default(LinkedListNode<MkBOssmnh52O7dtV8L1>);
		MkBOssmnh52O7dtV8L1 value = default(MkBOssmnh52O7dtV8L1);
		double? num11 = default(double?);
		double num5 = default(double);
		int num28 = default(int);
		double totalSeconds = default(double);
		TimeSpan timeSpan = default(TimeSpan);
		double? num29 = default(double?);
		int num17 = default(int);
		double? num13 = default(double?);
		double num6 = default(double);
		double? num30 = default(double?);
		DateTime dateTime = default(DateTime);
		List<DataGridColumn>.Enumerator enumerator = default(List<DataGridColumn>.Enumerator);
		List<DataGridColumn> list = default(List<DataGridColumn>);
		int num23 = default(int);
		DateTime dateTime2 = default(DateTime);
		DataGridColumn current = default(DataGridColumn);
		uint num37 = default(uint);
		string sortMemberPath = default(string);
		string text3 = default(string);
		XFont xFont = default(XFont);
		XBrush xBrush2 = default(XBrush);
		Rect rect2 = default(Rect);
		string text2 = default(string);
		double num39 = default(double);
		Rect rect = default(Rect);
		double num24 = default(double);
		double? num20 = default(double?);
		int num18 = default(int);
		while (true)
		{
			int num22;
			object obj2;
			object obj;
			double num14;
			switch (num4)
			{
			case 2:
				if (num3 >= base.ActualHeight)
				{
					goto IL_010f;
				}
				if (p6OhGeSTFM == 0)
				{
					num4 = 48;
					break;
				}
				goto IL_02da;
			case 55:
				num27 = Math.Max(0, p6OhGeSTFM);
				num4 = 4;
				break;
			case 28:
				if (num3 >= my6h4N4k6c139fXf8D71(this))
				{
					goto IL_010f;
				}
				goto IL_02da;
			case 31:
				if (syGBQLZPrWA2UUI6eRT.TickSide4 != SmartTapeTickSide.Any)
				{
					goto case 11;
				}
				goto case 52;
			case 39:
				num8 = num15.GetValueOrDefault();
				xBrush = syGBQLZPrWA2UUI6eRT.Brush3;
				goto case 10;
			case 17:
			case 54:
				if (num15.HasValue)
				{
					num4 = 9;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8b6bac13ae314900826ed96af7afc27b == 0)
					{
						num4 = 0;
					}
					break;
				}
				goto case 60;
			case 10:
				if (num10.HasValue || num21.HasValue)
				{
					if (!num10.HasValue)
					{
						goto case 51;
					}
					double num26 = realSize;
					num9 = num10;
					if (num26 >= num9)
					{
						num4 = 51;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b17e829e94d54e7b87d666edd5b38bcd == 0)
						{
							num4 = 29;
						}
						break;
					}
				}
				goto IL_03d2;
			case 50:
				num21 = syGBQLZPrWA2UUI6eRT.MaxSize4;
				linkedListNode = Brxh9y9kKD.Last;
				goto IL_1493;
			case 32:
				if (syGBQLZPrWA2UUI6eRT.TickSide3 == SmartTapeTickSide.Sell && value.UGTmvvUvFE == Side.Sell)
				{
					goto IL_0199;
				}
				goto case 10;
			case 19:
			case 42:
				num8 = num11.GetValueOrDefault();
				xBrush = (XBrush)JGkvPG4kMvBlFpaE8nvo(syGBQLZPrWA2UUI6eRT);
				goto IL_041c;
			case 40:
				num3 += num5;
				num28++;
				goto IL_010f;
			case 7:
				xBrush = null;
				num4 = 35;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fa74d46e0c824e0b89c71deca0488611 == 0)
				{
					num4 = 59;
				}
				break;
			case 43:
				totalSeconds = timeSpan.TotalSeconds;
				num4 = 61;
				break;
			case 4:
				num28 = num27;
				num22 = 23;
				goto IL_0005;
			case 53:
			{
				double num33 = num8;
				num9 = num29;
				if (!(num33 < num9))
				{
					num22 = 54;
					goto IL_0005;
				}
				num8 = num29.GetValueOrDefault();
				xBrush = syGBQLZPrWA2UUI6eRT.Brush2;
				num4 = 17;
				break;
			}
			case 34:
				num17++;
				num4 = 35;
				break;
			case 45:
				if (value.UGTmvvUvFE != Side.Sell)
				{
					goto case 17;
				}
				goto case 53;
			case 37:
				num9 = num;
				num4 = 29;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_409738fae61f4f058345c98b7cfbcbac == 0)
				{
					num4 = 21;
				}
				break;
			case 21:
				ATFmugcUom?.Invoke(this, new QiMs6anlYOxVtN4vT3de(num27, num28, 0, num17 - 1));
				return;
			case 36:
				if (!num13.HasValue)
				{
					goto IL_041c;
				}
				goto IL_07d3;
			case 30:
				num6 = 0.0;
				num4 = 58;
				break;
			case 51:
			{
				if (!num21.HasValue)
				{
					goto case 31;
				}
				double num35 = realSize;
				num9 = num21;
				if (num35 <= num9)
				{
					num4 = 31;
					break;
				}
				goto IL_03d2;
			}
			case 25:
				if (syGBQLZPrWA2UUI6eRT.TickSide4 == SmartTapeTickSide.Sell && value.UGTmvvUvFE == Side.Sell)
				{
					num4 = 52;
					break;
				}
				goto IL_03d2;
			case 14:
				if (!num30.HasValue)
				{
					num4 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9d6f131f80d34ede83451138b928a86f != 0)
					{
						num4 = 0;
					}
					break;
				}
				goto case 20;
			case 38:
				if (num13.HasValue)
				{
					double num16 = realSize;
					num9 = num13;
					if (!(num16 <= num9))
					{
						goto IL_041c;
					}
				}
				if (syGBQLZPrWA2UUI6eRT.TickSide1 == SmartTapeTickSide.Any)
				{
					num4 = 19;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6d365c300683408da8d70007bc278f93 == 0)
					{
						num4 = 12;
					}
					break;
				}
				if (OJxfvV4kS07YWx5GTxqL(syGBQLZPrWA2UUI6eRT) == SmartTapeTickSide.Buy)
				{
					if (value.UGTmvvUvFE != Side.Buy)
					{
						num4 = 57;
						break;
					}
					goto case 19;
				}
				goto case 57;
			case 61:
				dateTime = value.FkUmY8RiBU;
				num4 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7bbe761a662b44b5ba6c0923e11b90ae != 0)
				{
					num4 = 1;
				}
				break;
			case 18:
				if (value.UGTmvvUvFE == Side.Sell)
				{
					num4 = 42;
					break;
				}
				goto IL_041c;
			case 57:
				if (OJxfvV4kS07YWx5GTxqL(syGBQLZPrWA2UUI6eRT) == SmartTapeTickSide.Sell)
				{
					num22 = 18;
					goto IL_0005;
				}
				goto IL_041c;
			case 5:
				if (iaxhopakMs > 0.0)
				{
					num4 = 26;
					break;
				}
				goto IL_016a;
			case 56:
				enumerator = list.GetEnumerator();
				num4 = 15;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9267d25a572643c4b072d1d18111abbd != 0)
				{
					num4 = 16;
				}
				break;
			case 29:
				num6 = 0.0;
				num4 = 49;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1a625a5fe3334df88082832236dff5be != 0)
				{
					num4 = 31;
				}
				break;
			case 23:
				dateTime = Wnd4Hl4klCpgRv4lUgoD();
				num23 = lxNhHFREUZ.GeneralSettings.EmptyLineInterval;
				num17 = 0;
				dateTime2 = Wnd4Hl4klCpgRv4lUgoD();
				num22 = 3;
				goto IL_0005;
			case 49:
				if (num9 >= num6)
				{
					num4 = 13;
					break;
				}
				goto IL_160f;
			case 16:
				try
				{
					while (true)
					{
						int num36;
						if (!enumerator.MoveNext())
						{
							num36 = 25;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5e7b68e9e95482ab88a9b839c4d448c == 0)
							{
								num36 = 45;
							}
							goto IL_084a;
						}
						goto IL_0f4e;
						IL_0f4e:
						current = enumerator.Current;
						num36 = 25;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d3afdd6ad27a4c3b87071f1be51e7ef3 == 0)
						{
							num36 = 18;
						}
						goto IL_084a;
						IL_084a:
						while (true)
						{
							switch (num36)
							{
							case 28:
								if (num37 > 1111002218)
								{
									if (num37 == 1266317451)
									{
										if (!(sortMemberPath == (string)iAV8tm4kUVViI3JgncFE(-617064403 ^ -617056377)))
										{
											goto end_IL_084a;
										}
										goto case 29;
									}
									if (num37 != 2096980402)
									{
										goto end_IL_084a;
									}
									if (!(sortMemberPath == (string)iAV8tm4kUVViI3JgncFE(0x4297C3EB ^ 0x42978FD5)))
									{
										num36 = 23;
										if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_11b8736b0585457b9538011988d6d2f9 == 0)
										{
											num36 = 4;
										}
										continue;
									}
									goto case 17;
								}
								if (num37 != 995259257)
								{
									num36 = 19;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_267ca8254fa648cbaa1ba685784f79c7 == 0)
									{
										num36 = 50;
									}
									continue;
								}
								goto case 15;
							case 36:
								text3 = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x130FEA25 ^ 0x130FCE4F) + text3;
								goto IL_12c8;
							case 46:
								text3 = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1962651919 ^ -1962660193) + text3;
								goto IL_12c8;
							case 11:
							{
								if (num37 != 3711879114u || !(sortMemberPath == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1583344314 ^ -1583346998)))
								{
									goto end_IL_084a;
								}
								string text6 = (string)FQdhea4kVlpXcnmDseHX(lOqhfOH6B1, value.B7Tmo1HnRA, false);
								HTYtJ44ky0qvArhx9mf0(P_0, text6, xFont, xBrush2, rect2, XTextAlignment.Right);
								num36 = 16;
								continue;
							}
							case 41:
								P_0.DrawString(text2, xFont, xBrush2, rect2, XTextAlignment.Right);
								goto end_IL_084a;
							case 49:
								if (num37 != 2907914202u)
								{
									num36 = 14;
									continue;
								}
								if (!du8n4t4kThaQAohIQU81(sortMemberPath, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-29702950 ^ -29717804)))
								{
									goto end_IL_084a;
								}
								num36 = 1;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_34c8a548a4724373aa05c97fa43f690a != 0)
								{
									num36 = 0;
								}
								continue;
							case 47:
								if (num37 <= 3711879114u)
								{
									if (num37 != 3050396832u)
									{
										num36 = 11;
										if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d3afdd6ad27a4c3b87071f1be51e7ef3 == 0)
										{
											num36 = 6;
										}
										continue;
									}
									if (du8n4t4kThaQAohIQU81(sortMemberPath, iAV8tm4kUVViI3JgncFE(0x86EFEF6 ^ 0x86EB2C2)) && value.Bid > 0)
									{
										num36 = 38;
										if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a8990374f0e04177b45918e3dd7a2d4b == 0)
										{
											num36 = 12;
										}
										continue;
									}
									goto end_IL_084a;
								}
								goto case 42;
							case 27:
								sortMemberPath = current.SortMemberPath;
								num37 = cFKfVQ4ktPI4XKkNEfdP(sortMemberPath);
								if (num37 <= 2096980402)
								{
									if (num37 <= 555321499)
									{
										switch (num37)
										{
										default:
											num36 = 0;
											if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a849a254fa6841d5989e377890b7578f == 0)
											{
												num36 = 0;
											}
											continue;
										case 189732977u:
											if (!(sortMemberPath == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1461292091 ^ -1461305799)))
											{
												break;
											}
											P_0.DrawString(value.Time.ToString(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x50C1C840 ^ 0x50C1A81E)), xFont, xBrush2, rect2);
											num36 = 8;
											continue;
										case 174817312u:
										{
											if (!du8n4t4kThaQAohIQU81(sortMemberPath, iAV8tm4kUVViI3JgncFE(0x7F645F3C ^ 0x7F64111C)))
											{
												break;
											}
											timeSpan = dateTime2 - value.FkUmY8RiBU;
											double totalMilliseconds = timeSpan.TotalMilliseconds;
											if (!(totalMilliseconds > 0.0) || !(totalMilliseconds < 2000.0))
											{
												break;
											}
											num39 = 255.0 / (2000.0 / (2000.0 - totalMilliseconds));
											num36 = 2;
											if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6d365c300683408da8d70007bc278f93 != 0)
											{
												num36 = 34;
											}
											continue;
										}
										}
										goto end_IL_084a;
									}
									goto case 28;
								}
								if (num37 <= 2907914202u)
								{
									num36 = 12;
									continue;
								}
								goto case 47;
							case 2:
								if (num37 != 2789707388u)
								{
									num36 = 49;
									continue;
								}
								if (du8n4t4kThaQAohIQU81(sortMemberPath, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-203064540 ^ -203089118)))
								{
									text3 = (string)z7FGCf4kCR9IQJJoT2TX(lOqhfOH6B1, value.Size);
									num36 = 19;
									continue;
								}
								goto end_IL_084a;
							case 19:
								if (lxNhHFREUZ.GeneralSettings.ShowOpenIntChange)
								{
									if (value.yTZmaRQPnD > 0)
									{
										num36 = 46;
										continue;
									}
									if (value.yTZmaRQPnD < 0)
									{
										num36 = 36;
										continue;
									}
								}
								goto IL_12c8;
							case 34:
								I2ENhj4kKiV9RxAVlQ8h(P_0, new XBrush(new XColor((byte)num39, vyE4Fb4krL7pbS9FvKYC(lxNhHFREUZ.GeneralSettings))), rect2);
								goto end_IL_084a;
							default:
								if (num37 != 555321499)
								{
									num36 = 6;
									continue;
								}
								if (!(sortMemberPath == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-2063361985 ^ -2063337357)))
								{
									num36 = 39;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f6b8a9ae320a40f994b0db08d42c2a95 != 0)
									{
										num36 = 22;
									}
									continue;
								}
								goto case 3;
							case 1:
							case 9:
								if (value.OpenInt > 0)
								{
									num36 = 37;
									continue;
								}
								goto end_IL_084a;
							case 29:
								rect = rect2;
								num36 = 32;
								continue;
							case 15:
								if (!(sortMemberPath == (string)iAV8tm4kUVViI3JgncFE(0x2CBEEA31 ^ 0x2CBEF565)))
								{
									goto end_IL_084a;
								}
								goto case 18;
							case 18:
								HTYtJ44ky0qvArhx9mf0(P_0, lOqhfOH6B1.FormatTime(value.Time, (string)iAV8tm4kUVViI3JgncFE(0x78D396D8 ^ 0x78D3B6DE)), xFont, xBrush2, rect2, XTextAlignment.Left);
								goto end_IL_084a;
							case 25:
								rect2 = new Rect(new Point(num24 + 4.0 - HorizontalScrollOffset, num3), new Size(MiBOfc4kWGYTVrFLfaOP(current) - 8.0, num5));
								num36 = 27;
								continue;
							case 3:
								if (value.AskSize > 0)
								{
									num36 = 21;
									continue;
								}
								goto end_IL_084a;
							case 42:
								if (num37 != 3756319748u)
								{
									num36 = 26;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2088b9a28522490e83dc44062c40a7c0 == 0)
									{
										num36 = 24;
									}
									continue;
								}
								goto case 13;
							case 38:
							{
								string text8 = (string)FQdhea4kVlpXcnmDseHX(lOqhfOH6B1, value.Bid, false);
								P_0.DrawString(text8, xFont, xBrush2, rect2, XTextAlignment.Right);
								num36 = 26;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9267d25a572643c4b072d1d18111abbd != 0)
								{
									num36 = 30;
								}
								continue;
							}
							case 31:
								break;
							case 12:
								if (num37 == 2625753361u)
								{
									if (!du8n4t4kThaQAohIQU81(sortMemberPath, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x2D313048 ^ 0x2D315072)))
									{
										num36 = 4;
										continue;
									}
									goto case 35;
								}
								num36 = 2;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5e7b68e9e95482ab88a9b839c4d448c != 0)
								{
									num36 = 2;
								}
								continue;
							case 50:
								if (num37 != 1111002218)
								{
									goto end_IL_084a;
								}
								if (du8n4t4kThaQAohIQU81(sortMemberPath, iAV8tm4kUVViI3JgncFE(-602153869 ^ -602162089)))
								{
									if (string.IsNullOrEmpty(value.JfNmBlpHwm))
									{
										goto end_IL_084a;
									}
									num36 = 5;
									continue;
								}
								num36 = 14;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0fb8c8dbf8424ce68f439b7b66291a33 != 0)
								{
									num36 = 20;
								}
								continue;
							case 35:
								if (value.BidSize > 0)
								{
									num36 = 22;
									continue;
								}
								goto end_IL_084a;
							case 5:
								P_0.DrawString(value.JfNmBlpHwm, xFont, xBrush2, rect2);
								goto end_IL_084a;
							case 22:
							{
								string text5 = lOqhfOH6B1.FormatSize(value.BidSize);
								P_0.DrawString(text5, xFont, xBrush2, rect2, XTextAlignment.Right);
								goto end_IL_084a;
							}
							case 21:
							{
								string text4 = (string)z7FGCf4kCR9IQJJoT2TX(lOqhfOH6B1, value.AskSize);
								HTYtJ44ky0qvArhx9mf0(P_0, text4, xFont, xBrush2, rect2, XTextAlignment.Right);
								goto end_IL_084a;
							}
							case 26:
								if (num37 == 3942535562u)
								{
									if (!du8n4t4kThaQAohIQU81(sortMemberPath, iAV8tm4kUVViI3JgncFE(0x68C7EAE6 ^ 0x68C78AF4)))
									{
										num36 = 44;
										continue;
									}
									text2 = uw0myj1wmG(value.Size, value.Trades, lOqhfOH6B1);
									int num38 = 41;
									num36 = num38;
								}
								else
								{
									num36 = 43;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_976d29d6825c4c4995e3a2719d735c00 != 0)
									{
										num36 = 33;
									}
								}
								continue;
							case 17:
								if (value.Ask > 0)
								{
									string text7 = lOqhfOH6B1.FormatPrice(value.Ask);
									P_0.DrawString(text7, xFont, xBrush2, rect2, XTextAlignment.Right);
								}
								goto end_IL_084a;
							case 37:
							{
								string text = value.OpenInt.ToString((string)iAV8tm4kUVViI3JgncFE(--18459671 ^ 0x119E04B));
								P_0.DrawString(text, xFont, xBrush2, rect2, XTextAlignment.Right);
								num36 = 10;
								continue;
							}
							case 13:
								if (du8n4t4kThaQAohIQU81(sortMemberPath, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-198991962 ^ -198999866)))
								{
									HTYtJ44ky0qvArhx9mf0(P_0, yM0CCo4kZTDZ9vTkiSO5(lOqhfOH6B1, value.Time, iAV8tm4kUVViI3JgncFE(0x6AB40973 ^ 0x6AB40E47)), xFont, xBrush2, rect2, XTextAlignment.Left);
									num36 = 40;
								}
								else
								{
									num36 = 48;
								}
								continue;
							case 4:
							case 6:
							case 7:
							case 8:
							case 10:
							case 14:
							case 16:
							case 20:
							case 23:
							case 24:
							case 30:
							case 32:
							case 33:
							case 39:
							case 40:
							case 43:
							case 44:
							case 48:
								goto end_IL_084a;
							case 45:
								goto end_IL_0a96;
								IL_12c8:
								HTYtJ44ky0qvArhx9mf0(P_0, text3, xFont, xBrush2, rect2, XTextAlignment.Right);
								num36 = 24;
								continue;
							}
							goto IL_0f4e;
							continue;
							end_IL_084a:
							break;
						}
						num24 += current.ActualWidth;
						continue;
						end_IL_0a96:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
				}
				goto case 40;
			case 47:
				obj2 = W6cv2I4kqHmS4CSKVjH1(WgURgG4k1v9Da5blS0Pl(lxNhHFREUZ));
				goto IL_1af3;
			default:
				if (syGBQLZPrWA2UUI6eRT.TickSide2 == SmartTapeTickSide.Any)
				{
					num4 = 53;
					break;
				}
				if (syGBQLZPrWA2UUI6eRT.TickSide2 == SmartTapeTickSide.Buy)
				{
					if (value.UGTmvvUvFE != Side.Buy)
					{
						num4 = 24;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2aa1113717a74eb69caa8952fdc78508 != 0)
						{
							num4 = 10;
						}
						break;
					}
					goto case 53;
				}
				goto case 24;
			case 44:
			{
				double num34 = realSize;
				num9 = num29;
				if (num34 >= num9)
				{
					num4 = 14;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a80f370f27d471fab60f042c9fa7b49 == 0)
					{
						num4 = 1;
					}
					break;
				}
				goto case 17;
			}
			case 6:
				obj = null;
				goto IL_1b01;
			case 9:
			case 22:
				if (num15.HasValue)
				{
					double num32 = realSize;
					num9 = num15;
					if (!(num32 >= num9))
					{
						num4 = 10;
						break;
					}
				}
				if (num20.HasValue)
				{
					num4 = 27;
					break;
				}
				goto IL_052f;
			case 41:
				if (syGBQLZPrWA2UUI6eRT.TickSide3 == SmartTapeTickSide.Buy)
				{
					if (value.UGTmvvUvFE != Side.Buy)
					{
						num4 = 32;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8692846774e94af58ff2b2b243743e02 != 0)
						{
							num4 = 24;
						}
						break;
					}
					goto IL_0199;
				}
				goto case 32;
			case 13:
			{
				double num31 = realSize;
				num9 = num;
				if (num31 < num9)
				{
					goto IL_010f;
				}
				goto IL_160f;
			}
			case 59:
				num8 = -1.0;
				if (!num11.HasValue)
				{
					num4 = 36;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_08ac0ac701064383a00c80bff8cd4e3f == 0)
					{
						num4 = 18;
					}
					break;
				}
				goto IL_07d3;
			case 3:
				rect = f1By9v4kRnVLpq9pN8ZN();
				syGBQLZPrWA2UUI6eRT = lxNhHFREUZ.AlertsSettings;
				num11 = syGBQLZPrWA2UUI6eRT.MinSize1;
				num13 = syGBQLZPrWA2UUI6eRT.MaxSize1;
				num29 = syGBQLZPrWA2UUI6eRT.MinSize2;
				num30 = syGBQLZPrWA2UUI6eRT.MaxSize2;
				num15 = syGBQLZPrWA2UUI6eRT.MinSize3;
				num20 = syGBQLZPrWA2UUI6eRT.MaxSize3;
				num10 = syGBQLZPrWA2UUI6eRT.MinSize4;
				num4 = 50;
				break;
			case 58:
				if (num9 >= num6)
				{
					double num25 = realSize;
					num9 = num2;
					if (!(num25 > num9))
					{
						num4 = 34;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0aea3f4dc28f4bcb92a1f998dc5afbed != 0)
						{
							num4 = 32;
						}
						break;
					}
					goto IL_010f;
				}
				goto case 34;
			case 33:
				if (value.UGTmvvUvFE != Side.Buy)
				{
					num4 = 47;
					break;
				}
				obj2 = J75WtK4kIgWfvu1PPc90(lxNhHFREUZ.GeneralSettings);
				goto IL_1af3;
			case 8:
				num3 += (double)Math.Min((int)(totalSeconds / (double)num23), 5) * num5;
				num4 = 28;
				break;
			case 48:
				if (num23 > 0)
				{
					timeSpan = dateTime - value.FkUmY8RiBU;
					num4 = 43;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1c0cedb54d2b44a7af3d63420e8a1767 == 0)
					{
						num4 = 22;
					}
					break;
				}
				goto IL_02da;
			case 1:
				if (totalSeconds >= (double)num23)
				{
					num4 = 8;
					break;
				}
				goto IL_02da;
			case 11:
				if (syGBQLZPrWA2UUI6eRT.TickSide4 != SmartTapeTickSide.Buy)
				{
					goto case 25;
				}
				if (value.UGTmvvUvFE != Side.Buy)
				{
					num4 = 25;
					break;
				}
				goto case 52;
			case 52:
			{
				double num7 = num8;
				num9 = num10;
				if (num7 < num9)
				{
					xBrush = syGBQLZPrWA2UUI6eRT.Brush4;
				}
				goto IL_03d2;
			}
			case 24:
				if (syGBQLZPrWA2UUI6eRT.TickSide2 == SmartTapeTickSide.Sell)
				{
					num4 = 8;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0aea3f4dc28f4bcb92a1f998dc5afbed == 0)
					{
						num4 = 45;
					}
					break;
				}
				goto case 17;
			case 12:
				if (rect != f1By9v4kRnVLpq9pN8ZN())
				{
					num18 = (int)(base.ActualHeight / (jxLhY56dN4 + iaxhopakMs) * iaxhopakMs);
					num18 = Math.Max(3, num18);
					num4 = 5;
					break;
				}
				num4 = 21;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f63752baa0064bcb85a726ea90a210dc == 0)
				{
					num4 = 3;
				}
				break;
			case 20:
			{
				double num40 = realSize;
				num9 = num30;
				if (num40 <= num9)
				{
					num4 = 46;
					break;
				}
				goto case 17;
			}
			case 27:
			{
				double num19 = realSize;
				num9 = num20;
				if (!(num19 <= num9))
				{
					goto case 10;
				}
				goto IL_052f;
			}
			case 60:
				if (num20.HasValue)
				{
					num22 = 22;
					goto IL_0005;
				}
				goto case 10;
			case 26:
				P_0.FillRectangle((XBrush)x2K0Z94kmnhE18EsBDoA(lxNhHFREUZ.GeneralSettings), new Rect(new Point(rect.Left, 2.0), new Point(rect.Right, num18 - 1)));
				goto IL_016a;
			case 35:
				if (num17 >= p6OhGeSTFM)
				{
					num4 = 2;
					break;
				}
				goto IL_010f;
			case 62:
				list = (from c in aaNmmlZjW4().Columns
					where c.Visibility == Visibility.Visible
					orderby c.DisplayIndex
					select c).ToList();
				num4 = 7;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b3744d11c0b24c8d993b100cbb22f9e7 != 0)
				{
					num4 = 15;
				}
				break;
			case 15:
				{
					lNAhaOWUs4 = list.Any((DataGridColumn c) => (string)aDnbJTnXxaSE5LH4py42.jEUt1mNBhct80vgtoOVx(c) == (string)aDnbJTnXxaSE5LH4py42.Rb07ggNBwoc9suxjA0CP(-1774602229 ^ -1774586325));
					klRhi65EXJ = list.Any((DataGridColumn c) => c.SortMemberPath == (string)aDnbJTnXxaSE5LH4py42.Rb07ggNBwoc9suxjA0CP(-1251569705 ^ -1251565443));
					xFont = lxNhHFREUZ.OnprP3oVqe();
					num5 = xFont.GetHeight() + fW2mpSNNb9;
					num4 = 55;
					break;
				}
				IL_07d3:
				if (num11.HasValue)
				{
					double num12 = realSize;
					num9 = num11;
					if (num12 >= num9)
					{
						num4 = 38;
						break;
					}
					goto IL_041c;
				}
				goto case 38;
				IL_1b01:
				if (obj != null)
				{
					value = linkedListNode.Value;
					realSize = lOqhfOH6B1.GetRealSize(value.Size);
					num4 = 15;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_239772330c1f4196be911d4f334efb05 != 0)
					{
						num4 = 37;
					}
				}
				else
				{
					num4 = 12;
				}
				break;
				IL_0199:
				num14 = num8;
				num9 = num15;
				if (num14 < num9)
				{
					num4 = 39;
					break;
				}
				goto case 10;
				IL_02da:
				num24 = -1.0;
				num4 = 7;
				break;
				IL_1af3:
				xBrush2 = (XBrush)obj2;
				goto case 56;
				IL_010f:
				linkedListNode = linkedListNode.Previous;
				goto IL_1493;
				IL_03d2:
				if (xBrush != null)
				{
					P_0.FillRectangle(xBrush, new Rect(new Point(num24, num3), new Size(base.ActualWidth, num5)));
				}
				if (value.Trades > 1)
				{
					xBrush2 = (XBrush)((value.UGTmvvUvFE == Side.Buy) ? WYn2jG4kOuagAJx1Xp8O(lxNhHFREUZ.GeneralSettings) : ((miUjgiCQ4L4boFEaJpD)WgURgG4k1v9Da5blS0Pl(lxNhHFREUZ)).TETChKXBqd);
					num22 = 56;
					goto IL_0005;
				}
				goto case 33;
				IL_052f:
				if (syGBQLZPrWA2UUI6eRT.TickSide3 != SmartTapeTickSide.Any)
				{
					num4 = 41;
					break;
				}
				goto IL_0199;
				IL_041c:
				if (!num29.HasValue && !num30.HasValue)
				{
					goto case 17;
				}
				if (num29.HasValue)
				{
					num4 = 17;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fce1ea768b8d4ccdb3b71310761c1e52 == 0)
					{
						num4 = 44;
					}
					break;
				}
				goto case 14;
				IL_1493:
				if (linkedListNode == null)
				{
					num4 = 6;
					break;
				}
				obj = linkedListNode.Previous;
				goto IL_1b01;
				IL_160f:
				num9 = num2;
				num4 = 14;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7d3c6a8bf09f4ec887f577858231a719 == 0)
				{
					num4 = 30;
				}
				break;
				IL_0005:
				num4 = num22;
				break;
				IL_016a:
				if (jxLhY56dN4 > 0.0)
				{
					P_0.FillRectangle(lxNhHFREUZ.GeneralSettings.ju2CFqds4Z, new Rect(new Point(rect.Left, num18 + 1), new Point(rect.Right, base.ActualHeight - 4.0)));
				}
				goto case 21;
			}
		}
	}

	public void DN2mtm0veC()
	{
		A8Nqhi4khga7ta70KXro(HwndHost, false);
	}

	public void Scroll(int pos)
	{
		p6OhGeSTFM = pos;
	}

	private void WJhmUdlaTZ(object P_0, MouseWheelEventArgs P_1)
	{
		double num = gkrPRN4kwtOoclSUv5kr(lxNhHFREUZ.OnprP3oVqe()) + fW2mpSNNb9;
		int num2 = (int)((base.ActualHeight - e1rm3oGsyr) / num);
		p6OhGeSTFM = nD5Nqx4k7hQrBn79B6vr(Math.Max(p6OhGeSTFM - ((P_1.Delta > 0) ? 10 : (-10)), 0), Brxh9y9kKD.Count - num2);
		DN2mtm0veC();
		int num3 = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f10da6c70e49485dae21f57ce3741184 == 0)
		{
			num3 = 0;
		}
		switch (num3)
		{
		case 0:
			break;
		}
	}

	private void TFNmTOL6SA(object P_0, MouseButtonEventArgs P_1)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				p6OhGeSTFM = 0;
				goto IL_0030;
			case 1:
				{
					if (esAF3V4k8sqtVgW1LnwQ(P_1) == MouseButton.Middle)
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d3afdd6ad27a4c3b87071f1be51e7ef3 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto IL_0030;
				}
				IL_0030:
				DN2mtm0veC();
				return;
			}
		}
	}

	private static string uw0myj1wmG(long P_0, long P_1, Symbol P_2)
	{
		double realSize = P_2.GetRealSize(P_0);
		return P_2.FormatAvgSize(realSize / Math.Max(P_1, 1.0));
	}

	public void IgQmZCxNaj()
	{
		UOthnLtVQQ.Clear();
		UOthnLtVQQ.e08K8swppj(bJsmRU4DdQ);
		UOthnLtVQQ.KkpKJj1TNX(rOpm6qCMuS);
		UOthnLtVQQ.QnpKpdZ9Zd(x9nmMPgLXq);
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d4badf00eaf04a4c91e3397f36a429cf != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				HwndHost.Dispose();
				return;
			}
			HwndHost.OnRenderVisual -= WaLmIZlS7H;
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5b6218c32bbf4af5965485469fa12538 == 0)
			{
				num = 1;
			}
		}
	}

	private void v9umVb8xGW(object P_0, SizeChangedEventArgs P_1)
	{
		int num = 1;
		int num2 = num;
		int num3 = default(int);
		double num4 = default(double);
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (p6OhGeSTFM > num3)
				{
					p6OhGeSTFM = num3;
				}
				return;
			case 1:
				num4 = gkrPRN4kwtOoclSUv5kr(lxNhHFREUZ.OnprP3oVqe()) + fW2mpSNNb9;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7573e3aca29a46a9959af01ed2386da5 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			int num5 = (int)((base.ActualHeight - e1rm3oGsyr) / num4);
			num3 = Brxh9y9kKD.Count - num5;
			num2 = 2;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_859c6249cb0f4f11b2da29d1228ce418 == 0)
			{
				num2 = 2;
			}
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!mAXhlrmxM2)
		{
			mAXhlrmxM2 = true;
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0fb8c8dbf8424ce68f439b7b66291a33 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			Uri uri = new Uri(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1763895751 ^ -1763871155), UriKind.Relative);
			xYkOp74kAi4co7xwXEB8(this, uri);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int P_0, object P_1)
	{
		int num;
		if (P_0 != 1)
		{
			if (P_0 == 2)
			{
				HwndHost = (DxHwndHost)P_1;
				return;
			}
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_45006ec5334a406896281e648c9b6ca0 != 0)
			{
				num = 1;
			}
		}
		else
		{
			yf2R7e4kPmkHhGwhQm66((XweZ7cme4bUexhPLo8B)P_1, new MouseWheelEventHandler(WJhmUdlaTZ));
			num = 2;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				((XweZ7cme4bUexhPLo8B)P_1).MouseDown += TFNmTOL6SA;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b17e829e94d54e7b87d666edd5b38bcd == 0)
				{
					num = 0;
				}
				break;
			case 1:
				mAXhlrmxM2 = true;
				return;
			default:
				((XweZ7cme4bUexhPLo8B)P_1).SizeChanged += v9umVb8xGW;
				return;
			}
		}
	}

	static XweZ7cme4bUexhPLo8B()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
				di4h2oG9vy = DependencyProperty.Register(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1841489831 ^ -1841465001), rUp3Bk4kJkmaPCqkOymf(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777262)), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33554857)));
				return;
			case 1:
				stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f68538a410dc40459f303c1bac7938ac == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object pd653V4koBheydsijZv3(object P_0, object P_1)
	{
		return Delegate.Combine((Delegate)P_0, (Delegate)P_1);
	}

	internal static bool bTTPXM4kGKFU5KcoQdVH()
	{
		return wj8uYD4kn42NfMCsjrRV == null;
	}

	internal static XweZ7cme4bUexhPLo8B zFCSv64kYxWQopADPa9e()
	{
		return wj8uYD4kn42NfMCsjrRV;
	}

	internal static object uJPRPa4kv7jx3BrdndI9(object P_0, object P_1)
	{
		return Delegate.Remove((Delegate)P_0, (Delegate)P_1);
	}

	internal static void n62W5n4kBTETGVIRphOf(object P_0, object P_1, object P_2)
	{
		((DependencyObject)P_0).SetValue((DependencyProperty)P_1, P_2);
	}

	internal static void Ct8IyA4kaeen99le02ng(object P_0, object P_1)
	{
		((mWBbBYKr0D7o7FHQ0gP)P_0).DG6K39KMOG((Action)P_1);
	}

	internal static int vb70IB4kiOcny6jj1YFW(object P_0)
	{
		return ((LinkedList<MkBOssmnh52O7dtV8L1>)P_0).Count;
	}

	internal static DateTime Wnd4Hl4klCpgRv4lUgoD()
	{
		return TimeHelper.LocalTime;
	}

	internal static bool RUq1kT4k4X4HIpgbmLN4(TimeSpan P_0, TimeSpan P_1)
	{
		return P_0 < P_1;
	}

	internal static void T4D9pR4kDvUwDMSI5bwP(object P_0, bool P_1)
	{
		((mWBbBYKr0D7o7FHQ0gP)P_0).Aggregate = P_1;
	}

	internal static void Uhob4B4kbOPT5qSUJOEl(object P_0, object P_1)
	{
		((mWBbBYKr0D7o7FHQ0gP)P_0).B27KmOYAkL((TickEvent)P_1);
	}

	internal static void abVjB24kNWAXQIC0r1kD(object P_0)
	{
		((mWBbBYKr0D7o7FHQ0gP)P_0).Clear();
	}

	internal static double m9D2Qc4kkJBZt2g9YqL5(object P_0, long P_1)
	{
		return ((SymbolBase)P_0).GetRealSize(P_1);
	}

	internal static object WgURgG4k1v9Da5blS0Pl(object P_0)
	{
		return ((f3LRAlrtSOUwGiXtTI7)P_0).GeneralSettings;
	}

	internal static int s06YC24k5G2cxbRp54D0(object P_0)
	{
		return ((miUjgiCQ4L4boFEaJpD)P_0).BalanceIndicatorInterval;
	}

	internal static SmartTapeTickSide OJxfvV4kS07YWx5GTxqL(object P_0)
	{
		return ((syGBQLZPrWA2UUI6eRT)P_0).TickSide1;
	}

	internal static SmartTapeTickSide wb7l284kxIByJ2CFjhAD(object P_0)
	{
		return ((syGBQLZPrWA2UUI6eRT)P_0).TickSide2;
	}

	internal static SmartTapeTickSide qCfrTv4kLVDeKCyk7co7(object P_0)
	{
		return ((syGBQLZPrWA2UUI6eRT)P_0).TickSide3;
	}

	internal static object IF7gPp4ke0Bb0bDIMpPT(object P_0)
	{
		return ((syGBQLZPrWA2UUI6eRT)P_0).Alert3;
	}

	internal static object z5dWmr4ksmpLGv5YbR2I(object P_0)
	{
		return ((syGBQLZPrWA2UUI6eRT)P_0).Alert4;
	}

	internal static object HbBYvZ4kXOmLDaaIeq3n()
	{
		return TigerTrade.Properties.Resources.SmartTapeViewModelAlert;
	}

	internal static object CDOVA44kcJ6Yt9Ypj1fq(object P_0)
	{
		return ((Symbol)P_0).Name;
	}

	internal static object E0cRWM4kjM0Hih1OTUIb(object P_0)
	{
		return ((ChartAlertInfo)P_0).Signal;
	}

	internal static bool UZQAe64kEF6k7VFPkUWT(object P_0)
	{
		return ((ChartAlertInfo)P_0).SendEmail;
	}

	internal static Color GJbW8q4kQQ6PVrHVx7Fk(byte P_0, byte P_1, byte P_2, byte P_3)
	{
		return Color.FromArgb(P_0, P_1, P_2, P_3);
	}

	internal static XColor SqgCUI4kd12HbpNUALxo(Color P_0)
	{
		return P_0;
	}

	internal static void n5wkbE4kgRQ1W1wGwOry(object P_0)
	{
		LogManager.WriteError((Exception)P_0);
	}

	internal static Rect f1By9v4kRnVLpq9pN8ZN()
	{
		return Rect.Empty;
	}

	internal static double my6h4N4k6c139fXf8D71(object P_0)
	{
		return ((FrameworkElement)P_0).ActualHeight;
	}

	internal static object JGkvPG4kMvBlFpaE8nvo(object P_0)
	{
		return ((syGBQLZPrWA2UUI6eRT)P_0).Brush1;
	}

	internal static object WYn2jG4kOuagAJx1Xp8O(object P_0)
	{
		return ((miUjgiCQ4L4boFEaJpD)P_0).Iu8CtH2B1Y;
	}

	internal static object W6cv2I4kqHmS4CSKVjH1(object P_0)
	{
		return ((miUjgiCQ4L4boFEaJpD)P_0).MvmCVBF4Gl;
	}

	internal static object J75WtK4kIgWfvu1PPc90(object P_0)
	{
		return ((miUjgiCQ4L4boFEaJpD)P_0).nmBCMmE0e7;
	}

	internal static double MiBOfc4kWGYTVrFLfaOP(object P_0)
	{
		return ((DataGridColumn)P_0).ActualWidth;
	}

	internal static uint cFKfVQ4ktPI4XKkNEfdP(object P_0)
	{
		return global::_003CPrivateImplementationDetails_003E.ComputeStringHash((string)P_0);
	}

	internal static object iAV8tm4kUVViI3JgncFE(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static bool du8n4t4kThaQAohIQU81(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static void HTYtJ44ky0qvArhx9mf0(object P_0, object P_1, object P_2, object P_3, Rect P_4, XTextAlignment P_5)
	{
		((DxVisualQueue)P_0).DrawString((string)P_1, (XFont)P_2, (XBrush)P_3, P_4, P_5);
	}

	internal static object yM0CCo4kZTDZ9vTkiSO5(object P_0, DateTime P_1, object P_2)
	{
		return ((Symbol)P_0).FormatTime(P_1, (string)P_2);
	}

	internal static object FQdhea4kVlpXcnmDseHX(object P_0, long P_1, bool P_2)
	{
		return ((Symbol)P_0).FormatPrice(P_1, P_2);
	}

	internal static object z7FGCf4kCR9IQJJoT2TX(object P_0, long P_1)
	{
		return ((Symbol)P_0).FormatSize(P_1);
	}

	internal static XColor vyE4Fb4krL7pbS9FvKYC(object P_0)
	{
		return ((miUjgiCQ4L4boFEaJpD)P_0).SpeedIndicatorColor;
	}

	internal static void I2ENhj4kKiV9RxAVlQ8h(object P_0, object P_1, Rect P_2)
	{
		((DxVisualQueue)P_0).FillRectangle((XBrush)P_1, P_2);
	}

	internal static object x2K0Z94kmnhE18EsBDoA(object P_0)
	{
		return ((miUjgiCQ4L4boFEaJpD)P_0).zjcr0AvhTi;
	}

	internal static void A8Nqhi4khga7ta70KXro(object P_0, bool P_1)
	{
		((DxHwndHost)P_0).InvalidateVisual(P_1);
	}

	internal static double gkrPRN4kwtOoclSUv5kr(object P_0)
	{
		return ((XFont)P_0).GetHeight();
	}

	internal static int nD5Nqx4k7hQrBn79B6vr(int P_0, int P_1)
	{
		return Math.Min(P_0, P_1);
	}

	internal static MouseButton esAF3V4k8sqtVgW1LnwQ(object P_0)
	{
		return ((MouseButtonEventArgs)P_0).ChangedButton;
	}

	internal static void xYkOp74kAi4co7xwXEB8(object P_0, object P_1)
	{
		Application.LoadComponent(P_0, (Uri)P_1);
	}

	internal static void yf2R7e4kPmkHhGwhQm66(object P_0, object P_1)
	{
		((UIElement)P_0).MouseWheel += (MouseWheelEventHandler)P_1;
	}

	internal static Type rUp3Bk4kJkmaPCqkOymf(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}
}
