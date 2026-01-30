using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;
using dIk3mX23l260LgpAo3U7;
using ECOEgqlSad8NUJZ2Dr9n;
using MQCU1r2JmS7RUTRpngQN;
using OWUMXkHkWgCUprHQ3jb9;
using TigerTrade.Tc.Data;
using TigerTrade.Tc.Manager;
using TuAMtrl1Nd3XoZQQUXf0;

namespace HhcaMaanMgJtkJUqAiP;

internal class Ab6hgWa9MJ9QmrqJvnf : PbGEeJHkI13kYvWpne18, IComponentConnector
{
	private string skiaeXK2ne;

	private string Fdkas30ZUv;

	private double LGSaX3UVU6;

	private double qXNacqDWv4;

	private double FnZaj97QhU;

	private double x9daE05MdW;

	[CompilerGenerated]
	private bool HblaQ9kCql;

	internal Li572t2JKH213AbsVVkS SymbolSearchCombo;

	internal Eh9FNq23i1JY9nplrMpW AccountSelectCombo;

	private bool TqCadqFHwo;

	private static Ab6hgWa9MJ9QmrqJvnf fSHRS1lA73fUwjpALCne;

	public string Symbol
	{
		get
		{
			return skiaeXK2ne;
		}
		set
		{
			int num = 2;
			int num2 = num;
			Symbol symbol = default(Symbol);
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
					if (!(text == skiaeXK2ne))
					{
						skiaeXK2ne = text;
						ifWlfmRSlkr(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-45476899 ^ -45478735));
						symbol = SymbolManager.Get(skiaeXK2ne);
						num2 = 2;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44265f4417e640c7a760a59a950624e5 == 0)
						{
							num2 = 3;
						}
					}
					else
					{
						num2 = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_239772330c1f4196be911d4f334efb05 != 0)
						{
							num2 = 1;
						}
					}
					break;
				case 3:
					if (symbol == null)
					{
						return;
					}
					PriceStep = symbol.Step;
					SizeStep = E0XK0BlAPaFuYuEPBRFl(symbol);
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e38cca27b4f843e0acda58c2d2606b17 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string Account
	{
		get
		{
			return Fdkas30ZUv;
		}
		set
		{
			if (!(text == Fdkas30ZUv))
			{
				Fdkas30ZUv = text;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6b48af76ce0b4c779ac34c27953eddda == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				ifWlfmRSlkr(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-198991962 ^ -198999128));
			}
		}
	}

	public double AvgPrice
	{
		get
		{
			return LGSaX3UVU6;
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
					if (lGSaX3UVU.Equals(LGSaX3UVU6))
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_34c8a548a4724373aa05c97fa43f690a != 0)
						{
							num2 = 0;
						}
						break;
					}
					LGSaX3UVU6 = lGSaX3UVU;
					ifWlfmRSlkr((string)kWVcV9lAJ2G3mSXGUC0j(-1999650146 ^ -1999641616));
					return;
				case 0:
					return;
				}
			}
		}
	}

	public double Quantity
	{
		get
		{
			return qXNacqDWv4;
		}
		set
		{
			if (num != qXNacqDWv4)
			{
				qXNacqDWv4 = num;
				ifWlfmRSlkr(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-991861155 ^ -991856185));
				int num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a80f370f27d471fab60f042c9fa7b49 != 0)
				{
					num2 = 0;
				}
				switch (num2)
				{
				case 0:
					break;
				}
			}
		}
	}

	public double PriceStep
	{
		get
		{
			return FnZaj97QhU;
		}
		set
		{
			if (!fnZaj97QhU.Equals(FnZaj97QhU))
			{
				FnZaj97QhU = fnZaj97QhU;
				ifWlfmRSlkr(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x28C965BE ^ 0x28C94DCC));
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_976d29d6825c4c4995e3a2719d735c00 == 0)
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

	public double SizeStep
	{
		get
		{
			return x9daE05MdW;
		}
		set
		{
			if (!num.Equals(x9daE05MdW))
			{
				x9daE05MdW = num;
				ifWlfmRSlkr((string)kWVcV9lAJ2G3mSXGUC0j(0x28BBDCA ^ 0x28B9542));
			}
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public bool t35aS7i1g4()
	{
		return HblaQ9kCql;
	}

	[SpecialName]
	[CompilerGenerated]
	public void aaAaxccfox(bool P_0)
	{
		HblaQ9kCql = P_0;
	}

	public Ab6hgWa9MJ9QmrqJvnf()
	{
		mjlccDlAF3wtkKqTqiwa();
		base._002Ector();
		PriceStep = 1.0;
		int num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c1a63437a5bc4d139ae2c4a2f19ec947 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				SizeStep = 1.0;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a849a254fa6841d5989e377890b7578f != 0)
				{
					num = 0;
				}
				break;
			default:
				InitializeComponent();
				return;
			}
		}
	}

	private void Window_Loaded(object sender, RoutedEventArgs e)
	{
		BZae7XlA3WZkxlfaA3wi(SymbolSearchCombo, t35aS7i1g4());
		AccountSelectCombo.IsEnabled = t35aS7i1g4();
	}

	private void oLYaGZRnJS(object P_0, RoutedEventArgs P_1)
	{
		base.DialogResult = true;
		Close();
	}

	private void NOEaYBZAqD(object P_0, RoutedEventArgs P_1)
	{
		Close();
	}

	public static void enpao7xyDO(Window P_0, bool P_1)
	{
		Ab6hgWa9MJ9QmrqJvnf ab6hgWa9MJ9QmrqJvnf = new Ab6hgWa9MJ9QmrqJvnf();
		ab6hgWa9MJ9QmrqJvnf.Owner = P_0;
		ab6hgWa9MJ9QmrqJvnf.aaAaxccfox(P_1);
		ab6hgWa9MJ9QmrqJvnf.ShowDialog();
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
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
				if (!TqCadqFHwo)
				{
					TqCadqFHwo = true;
					Uri resourceLocator = new Uri(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-203064540 ^ -203074632), UriKind.Relative);
					Application.LoadComponent(this, resourceLocator);
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f40a817752724303a7406a720886b183 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int P_0, object P_1)
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
				switch (P_0)
				{
				case 1:
					SymbolSearchCombo = (Li572t2JKH213AbsVVkS)P_1;
					return;
				case 4:
					wEvGKllApWKxfrwpOARb((Button)P_1, new RoutedEventHandler(NOEaYBZAqD));
					return;
				default:
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f68538a410dc40459f303c1bac7938ac == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					AccountSelectCombo = (Eh9FNq23i1JY9nplrMpW)P_1;
					num2 = 3;
					break;
				case 3:
					((Button)P_1).Click += oLYaGZRnJS;
					return;
				}
				break;
			case 0:
				return;
			case 1:
				TqCadqFHwo = true;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2039997ab6194b398d07bcb5d664c971 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				return;
			}
		}
	}

	static Ab6hgWa9MJ9QmrqJvnf()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static double E0XK0BlAPaFuYuEPBRFl(object P_0)
	{
		return ((SymbolBase)P_0).SizeStep;
	}

	internal static bool dpJXkGlA8i83ke2K0qSR()
	{
		return fSHRS1lA73fUwjpALCne == null;
	}

	internal static Ab6hgWa9MJ9QmrqJvnf wQDWZTlAAWwV1KWkAS6N()
	{
		return fSHRS1lA73fUwjpALCne;
	}

	internal static object kWVcV9lAJ2G3mSXGUC0j(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static void mjlccDlAF3wtkKqTqiwa()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static void BZae7XlA3WZkxlfaA3wi(object P_0, bool P_1)
	{
		((UIElement)P_0).IsEnabled = P_1;
	}

	internal static void wEvGKllApWKxfrwpOARb(object P_0, object P_1)
	{
		((ButtonBase)P_0).Click += (RoutedEventHandler)P_1;
	}
}
