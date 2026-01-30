using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Shell;
using C0VbJ9kdTRpMSmcHClr;
using ECOEgqlSad8NUJZ2Dr9n;
using lrWa4mk6v8y8KGrueqb;
using MBadrGHx2q6CreCXt0bK;
using ttPdaPH4UIV7wakQ3boE;
using TuAMtrl1Nd3XoZQQUXf0;
using xCOmUuHDjdTrt2GotQpl;
using xfdMo0lS4TP9pN36Goka;

namespace TigerTrade.UI.Windows;

public class UiKitWindow : Window, IComponentConnector
{
	public static readonly RoutedCommand FullScreenCommand;

	private double DCnf0kHSnr;

	private double sXWf2OyOun;

	private double pk2fHk8P8o;

	private double z7bffhtLgS;

	private double Cbhf9dVdoQ;

	private double LqIfnF2Rq1;

	private readonly Be7Ye6Hx0lmaxm2L7oFg Th4fGEQhwO;

	private WindowChrome vovfYpBpXy;

	private static readonly Point NaN;

	internal YUcITXkQU2uSFdduB9b WindowContent;

	private bool DoCfoeBf5o;

	internal static UiKitWindow kcKwPmlZskFuU0E3ALHj;

	public UiKitWindow()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		InitializeComponent();
		IXRrdJlZdRUaSpFhga0k(this, qNbMIplZQxSluPUVtQcG(P81IdGlZj7pfW9XDZHmy(Application.Current), e7yTyhlZEOTyqB0jH0FJ(-1009517961 ^ -1009520051)) as FontFamily);
		int num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6b9913e777f24c1abc91fbc34d2bcc9c == 0)
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
				Th4fGEQhwO = new Be7Ye6Hx0lmaxm2L7oFg(this);
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f027e87a9f614f4a92c0338386fb11cd != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public void wlhHu998rE()
	{
		Th4fGEQhwO.a4kHxHpCp76();
	}

	protected override void OnSourceInitialized(EventArgs P_0)
	{
		GrV3nClZgejxl4nntdfp(this, P_0);
		if (S6BaSJHDc2pgAe1j8DZH.BNXHDqqPp02(this, out var s6BaSJHDc2pgAe1j8DZH))
		{
			base.MaxHeight = s6BaSJHDc2pgAe1j8DZH.Height - Xf3WIvlZR80O4M9CkRv7();
			base.MaxWidth = s6BaSJHDc2pgAe1j8DZH.Width;
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ebf7ae5938c3406ea71c3b7147ea041c != 0)
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

	protected override void OnKeyDown(KeyEventArgs P_0)
	{
		jAOih8lZ6f8AYZFddSy3(this, P_0);
		if (P_0.Key != Key.Escape)
		{
			return;
		}
		if (p8U1itlZMX5p48WDuI4n())
		{
			P_0.Handled = true;
			return;
		}
		yuHvx3kR3ngF1tatPtj obj = base.DataContext as yuHvx3kR3ngF1tatPtj;
		int num;
		if (obj == null)
		{
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a93c63471a5d4726b3bdf40a69cdb422 == 0)
			{
				num = 0;
			}
		}
		else
		{
			ICommand command = obj.CancelCommand;
			if (command == null)
			{
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dfd8fb340d494755970617a38d3a8729 == 0)
				{
					num = 1;
				}
			}
			else
			{
				command.Execute(P_0);
				num = 2;
			}
		}
		switch (num)
		{
		case 2:
			break;
		case 0:
			break;
		case 1:
			break;
		}
	}

	protected override void OnClosing(CancelEventArgs P_0)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				base.OnClosing(P_0);
				return;
			case 1:
				if (p8U1itlZMX5p48WDuI4n())
				{
					P_0.Cancel = true;
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_409738fae61f4f058345c98b7cfbcbac == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void OReHzIchCf(object P_0, ExecutedRoutedEventArgs P_1)
	{
		int num = 10;
		object parameter = default(object);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return;
				case 1:
					base.WindowStartupLocation = WindowStartupLocation.CenterScreen;
					num2 = 7;
					continue;
				case 7:
					base.ResizeMode = ResizeMode.NoResize;
					WindowChrome.SetWindowChrome(this, null);
					enomnglZq6A4tiZ3gpOH(this, Visibility.Visible);
					base.WindowState = WindowState.Maximized;
					return;
				case 8:
					base.WindowStartupLocation = WindowStartupLocation.CenterOwner;
					WindowChrome.SetWindowChrome(this, vovfYpBpXy);
					num2 = 6;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_bbcfc7b1c81d4568b6bd3ed19a340f5e == 0)
					{
						num2 = 5;
					}
					continue;
				case 10:
					parameter = P_1.Parameter;
					num2 = 9;
					continue;
				case 3:
					LqIfnF2Rq1 = base.Left;
					num = 11;
					break;
				case 12:
					base.MaxWidth = sXWf2OyOun;
					num = 14;
					break;
				case 11:
					base.MaxHeight = double.PositiveInfinity;
					num2 = 16;
					continue;
				case 4:
					base.WindowStyle = WindowStyle.SingleBorderWindow;
					num2 = 15;
					continue;
				case 9:
					if (!(parameter is bool))
					{
						return;
					}
					if (!(bool)parameter)
					{
						enomnglZq6A4tiZ3gpOH(this, Visibility.Collapsed);
						num2 = 3;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3023bd6c0f7846878513499bf5c36161 == 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 5;
				case 13:
					base.Width = z7bffhtLgS;
					base.Top = Cbhf9dVdoQ;
					base.Left = LqIfnF2Rq1;
					num2 = 2;
					continue;
				case 6:
					base.ResizeMode = ResizeMode.CanMinimize;
					base.Visibility = Visibility.Visible;
					base.MaxHeight = DCnf0kHSnr;
					num2 = 12;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1b729872d4424497a28393432ab4c541 == 0)
					{
						num2 = 3;
					}
					continue;
				case 14:
					base.Height = pk2fHk8P8o;
					num2 = 13;
					continue;
				case 16:
					base.MaxWidth = double.PositiveInfinity;
					vovfYpBpXy = WindowChrome.GetWindowChrome(this);
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9cec884f01d949d294f11a9fcceef609 != 0)
					{
						num2 = 0;
					}
					continue;
				default:
					base.Visibility = Visibility.Collapsed;
					base.SizeToContent = SizeToContent.Manual;
					base.WindowStyle = WindowStyle.None;
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_495802897f05476f875528905eba9a89 == 0)
					{
						num2 = 1;
					}
					continue;
				case 15:
					base.SizeToContent = SizeToContent.Manual;
					PQYI86lZIw3JqF1eK4Db(this, WindowState.Normal);
					num2 = 8;
					continue;
				case 5:
					DCnf0kHSnr = base.MaxHeight;
					sXWf2OyOun = base.MaxWidth;
					pk2fHk8P8o = yuS2m8lZOemEe7sySPjT(this);
					z7bffhtLgS = base.ActualWidth;
					Cbhf9dVdoQ = base.Top;
					num2 = 3;
					continue;
				}
				break;
			}
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!DoCfoeBf5o)
		{
			DoCfoeBf5o = true;
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8a9257c2b61741afa02a8ceb1f69ad69 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 1:
				return;
			}
			Uri resourceLocator = new Uri(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x4297C3EB ^ 0x4297CBBD), UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
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
				if (P_0 != 1)
				{
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3cfcda862e0540cbb9abf65446a10635 != 0)
					{
						num2 = 1;
					}
					break;
				}
				((CommandBinding)P_1).Executed += OReHzIchCf;
				return;
			case 1:
				if (P_0 != 2)
				{
					DoCfoeBf5o = true;
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_08ac0ac701064383a00c80bff8cd4e3f != 0)
					{
						num2 = 0;
					}
					break;
				}
				WindowContent = (YUcITXkQU2uSFdduB9b)P_1;
				return;
			case 0:
				return;
			}
		}
	}

	static UiKitWindow()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		FullScreenCommand = new RoutedCommand(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x68C7EAE6 ^ 0x68C7E25A), Type.GetTypeFromHandle(h8qvCwlZWZaA0wLdmg94(33554532)));
		NaN = new Point(double.NaN, double.NaN);
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c16c36b6197f4f30be0a8035f04288b3 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object P81IdGlZj7pfW9XDZHmy(object P_0)
	{
		return ((Application)P_0).Resources;
	}

	internal static object e7yTyhlZEOTyqB0jH0FJ(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static object qNbMIplZQxSluPUVtQcG(object P_0, object P_1)
	{
		return ((ResourceDictionary)P_0)[P_1];
	}

	internal static void IXRrdJlZdRUaSpFhga0k(object P_0, object P_1)
	{
		((Control)P_0).FontFamily = (FontFamily)P_1;
	}

	internal static bool ccNeurlZXTmpJVhQhk8C()
	{
		return kcKwPmlZskFuU0E3ALHj == null;
	}

	internal static UiKitWindow jVcg5glZcOSUhmpYNKRD()
	{
		return kcKwPmlZskFuU0E3ALHj;
	}

	internal static void GrV3nClZgejxl4nntdfp(object P_0, object P_1)
	{
		((Window)P_0).OnSourceInitialized((EventArgs)P_1);
	}

	internal static double Xf3WIvlZR80O4M9CkRv7()
	{
		return SystemParameters.CaptionHeight;
	}

	internal static void jAOih8lZ6f8AYZFddSy3(object P_0, object P_1)
	{
		((UIElement)P_0).OnKeyDown((KeyEventArgs)P_1);
	}

	internal static bool p8U1itlZMX5p48WDuI4n()
	{
		return T1PidKH4tUNimKjMkjFl.IsLocked;
	}

	internal static double yuS2m8lZOemEe7sySPjT(object P_0)
	{
		return ((FrameworkElement)P_0).ActualHeight;
	}

	internal static void enomnglZq6A4tiZ3gpOH(object P_0, Visibility P_1)
	{
		((UIElement)P_0).Visibility = P_1;
	}

	internal static void PQYI86lZIw3JqF1eK4Db(object P_0, WindowState P_1)
	{
		((Window)P_0).WindowState = P_1;
	}

	internal static RuntimeTypeHandle h8qvCwlZWZaA0wLdmg94(int token)
	{
		return zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(token);
	}
}
