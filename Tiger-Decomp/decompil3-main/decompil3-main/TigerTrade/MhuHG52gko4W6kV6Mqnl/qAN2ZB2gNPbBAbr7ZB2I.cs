using System;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using ECOEgqlSad8NUJZ2Dr9n;
using TuAMtrl1Nd3XoZQQUXf0;
using xfdMo0lS4TP9pN36Goka;

namespace MhuHG52gko4W6kV6Mqnl;

internal sealed class qAN2ZB2gNPbBAbr7ZB2I : Popup
{
	public struct A66PkWnMgMkOPpE3kc8m
	{
		public int Left;

		public int Top;

		public int Right;

		public int Bottom;
	}

	public static readonly DependencyProperty k8w2ggiw6Au;

	private bool? qO32gRy8r78;

	private bool AMk2g6XhcNr;

	private Window QrE2gMi1yRJ;

	private bool cXf2gOsGSH2;

	private static readonly IntPtr aaa2gqOB3eD;

	private static readonly IntPtr RVL2gICyJTw;

	private static readonly IntPtr oX62gWm0dqY;

	private static readonly IntPtr NDA2gt21SgR;

	internal static qAN2ZB2gNPbBAbr7ZB2I dnUKnK4P0hLQLJIh4U90;

	public bool IsTopmost
	{
		get
		{
			return (bool)GetValue(k8w2ggiw6Au);
		}
		set
		{
			GXf73n4PfSZxeyS9uIHg(this, k8w2ggiw6Au, flag);
		}
	}

	public qAN2ZB2gNPbBAbr7ZB2I()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f3775e6a3cb04c0998106e46ff04d8ab != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		base.Loaded += FkD2g5Z9DlM;
		base.Unloaded += aSP2gS1dKDd;
	}

	private void X4x2g19Sv7R(object P_0, EventArgs P_1)
	{
		double num = bk3cO04P9lA8TOecoJEv(this);
		base.HorizontalOffset = num + 1.0;
		int num2 = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_eb223d2975554a51b6c4f9fa9a65a93d == 0)
		{
			num2 = 0;
		}
		switch (num2)
		{
		}
		base.HorizontalOffset = num;
	}

	private void FkD2g5Z9DlM(object P_0, RoutedEventArgs P_1)
	{
		if (AMk2g6XhcNr)
		{
			return;
		}
		AMk2g6XhcNr = true;
		UIElement child = base.Child;
		if (child == null)
		{
			goto IL_0072;
		}
		child.AddHandler(UIElement.PreviewMouseLeftButtonDownEvent, new MouseButtonEventHandler(olX2gsIUvBi), handledEventsToo: true);
		int num = 2;
		goto IL_0009;
		IL_0072:
		QrE2gMi1yRJ = Window.GetWindow(this);
		if (QrE2gMi1yRJ == null)
		{
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f2434d508b7b4b77853ea03e1bcda658 != 0)
			{
				num = 3;
			}
		}
		else
		{
			MPIrkA4PnEevmUEJxQHB(QrE2gMi1yRJ, new EventHandler(kA52gxci9gO));
			GUixCC4PGsy5C5hwmyOj(QrE2gMi1yRJ, new EventHandler(TZN2gLKYHHP));
			FEIyTV4PYRSNhtlBgJ6x(QrE2gMi1yRJ, new EventHandler(xuS2geWB6AG));
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d9af442440454effa9efd8da8e33ec96 != 0)
			{
				num = 0;
			}
		}
		goto IL_0009;
		IL_0009:
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			case 2:
				break;
			default:
				QrE2gMi1yRJ.LocationChanged += X4x2g19Sv7R;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5dcb5c2a8274adf87bda91d76616538 != 0)
				{
					num = 1;
				}
				continue;
			case 3:
				return;
			}
			break;
		}
		goto IL_0072;
	}

	private void aSP2gS1dKDd(object P_0, RoutedEventArgs P_1)
	{
		if (QrE2gMi1yRJ == null)
		{
			return;
		}
		base.Child?.RemoveHandler(UIElement.PreviewMouseLeftButtonDownEvent, new MouseButtonEventHandler(olX2gsIUvBi));
		QrE2gMi1yRJ.Activated -= kA52gxci9gO;
		lEb8oh4PouJL8pWZIfU7(QrE2gMi1yRJ, new EventHandler(TZN2gLKYHHP));
		int num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_281cd373231b4974955fe570959430ac == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				return;
			case 1:
				QrE2gMi1yRJ.StateChanged -= xuS2geWB6AG;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6990919c9c0e45a99d17cb82a4a90a41 == 0)
				{
					num = 0;
				}
				continue;
			}
			QrE2gMi1yRJ.LocationChanged -= X4x2g19Sv7R;
			AMk2g6XhcNr = false;
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1c0cedb54d2b44a7af3d63420e8a1767 != 0)
			{
				num = 2;
			}
		}
	}

	private void kA52gxci9gO(object P_0, EventArgs P_1)
	{
		base.IsOpen = cXf2gOsGSH2;
		Ycx2gcCEHE4(_0020: true);
	}

	private void TZN2gLKYHHP(object P_0, EventArgs P_1)
	{
		int num;
		if (!IsTopmost)
		{
			Ycx2gcCEHE4(IsTopmost);
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_bbcfc7b1c81d4568b6bd3ed19a340f5e != 0)
			{
				num = 0;
			}
			goto IL_0009;
		}
		goto IL_0063;
		IL_0063:
		cXf2gOsGSH2 = base.IsOpen;
		base.IsOpen = false;
		num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a849a254fa6841d5989e377890b7578f == 0)
		{
			num = 1;
		}
		goto IL_0009;
		IL_0009:
		switch (num)
		{
		case 1:
			return;
		}
		goto IL_0063;
	}

	private void xuS2geWB6AG(object P_0, EventArgs P_1)
	{
		if (UED7mD4PvgwM67LhI9xj(QrE2gMi1yRJ) == WindowState.Minimized)
		{
			base.IsOpen = false;
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dfd8fb340d494755970617a38d3a8729 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}
		else
		{
			DBAG5m4PB1af5K3CHaUO(this, true);
		}
	}

	private void olX2gsIUvBi(object P_0, MouseButtonEventArgs P_1)
	{
		Ycx2gcCEHE4(_0020: true);
		if (!QrE2gMi1yRJ.IsActive && !IsTopmost)
		{
			CS9pcI4PaUndhwOQZbW2(QrE2gMi1yRJ);
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_34759ce292e54c39852852efd3a55773 == 0)
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

	private static void Xkl2gXYUvfB(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		qAN2ZB2gNPbBAbr7ZB2I obj = (qAN2ZB2gNPbBAbr7ZB2I)P_0;
		obj.Ycx2gcCEHE4(obj.IsTopmost);
	}

	protected override void OnOpened(EventArgs P_0)
	{
		Ycx2gcCEHE4(IsTopmost);
		base.OnOpened(P_0);
	}

	private void Ycx2gcCEHE4(bool P_0)
	{
		bool? flag = default(bool?);
		bool flag2 = default(bool);
		int num;
		if (qO32gRy8r78.HasValue)
		{
			flag = qO32gRy8r78;
			flag2 = P_0;
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_94f896a1c68c4274bf6a8960d175b5c2 == 0)
			{
				num = 0;
			}
			goto IL_0009;
		}
		goto IL_007b;
		IL_0009:
		IntPtr handle = default(IntPtr);
		HwndSource hwndSource = default(HwndSource);
		A66PkWnMgMkOPpE3kc8m a66PkWnMgMkOPpE3kc8m = default(A66PkWnMgMkOPpE3kc8m);
		while (true)
		{
			switch (num)
			{
			case 4:
				return;
			case 1:
				qO32gRy8r78 = P_0;
				return;
			case 2:
				return;
			case 5:
				return;
			case 3:
				handle = hwndSource.Handle;
				if (!TAx2gjfNL1i(handle, out a66PkWnMgMkOPpE3kc8m))
				{
					num = 5;
					continue;
				}
				if (P_0)
				{
					num = 6;
					continue;
				}
				bPA2gEivkFy(handle, NDA2gt21SgR, a66PkWnMgMkOPpE3kc8m.Left, a66PkWnMgMkOPpE3kc8m.Top, (int)rYE5nY4Plk1b6mCCAEXH(this), (int)base.Height, 1563u);
				bPA2gEivkFy(handle, oX62gWm0dqY, a66PkWnMgMkOPpE3kc8m.Left, a66PkWnMgMkOPpE3kc8m.Top, (int)base.Width, (int)kj4huo4P4A98x8HEw2Du(this), 1563u);
				bPA2gEivkFy(handle, RVL2gICyJTw, a66PkWnMgMkOPpE3kc8m.Left, a66PkWnMgMkOPpE3kc8m.Top, (int)rYE5nY4Plk1b6mCCAEXH(this), (int)kj4huo4P4A98x8HEw2Du(this), 1563u);
				goto case 1;
			case 6:
				bPA2gEivkFy(handle, aaa2gqOB3eD, a66PkWnMgMkOPpE3kc8m.Left, a66PkWnMgMkOPpE3kc8m.Top, (int)base.Width, (int)base.Height, 1563u);
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_495802897f05476f875528905eba9a89 == 0)
				{
					num = 1;
				}
				continue;
			}
			if (flag != flag2)
			{
				break;
			}
			num = 2;
		}
		goto IL_007b;
		IL_007b:
		if (base.Child != null)
		{
			hwndSource = AYinmW4PiZPfKYBG4Pu2(base.Child) as HwndSource;
			if (hwndSource == null)
			{
				return;
			}
			num = 3;
		}
		else
		{
			num = 4;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3cfcda862e0540cbb9abf65446a10635 == 0)
			{
				num = 3;
			}
		}
		goto IL_0009;
	}

	[DllImport("user32.dll", EntryPoint = "GetWindowRect")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool TAx2gjfNL1i(IntPtr P_0, out A66PkWnMgMkOPpE3kc8m P_1);

	[DllImport("user32.dll", EntryPoint = "SetWindowPos")]
	private static extern bool bPA2gEivkFy(IntPtr P_0, IntPtr P_1, int P_2, int P_3, int P_4, int P_5, uint P_6);

	static qAN2ZB2gNPbBAbr7ZB2I()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7573e3aca29a46a9959af01ed2386da5 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				RVL2gICyJTw = new IntPtr(-2);
				oX62gWm0dqY = new IntPtr(0);
				NDA2gt21SgR = new IntPtr(1);
				num2 = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5350e02b39f542f78529ac5e3c3f8ec6 == 0)
				{
					num2 = 1;
				}
				break;
			default:
				bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
				k8w2ggiw6Au = DependencyProperty.Register(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x7D553BE0 ^ 0x7D55FCF8), Type.GetTypeFromHandle(cKBPms4PD0K8UynrDT2F(16777221)), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555047)), new FrameworkPropertyMetadata(false, Xkl2gXYUvfB));
				aaa2gqOB3eD = new IntPtr(-1);
				num2 = 3;
				break;
			case 2:
				return;
			}
		}
	}

	internal static bool jY9q7r4P2tG0qGAx1Wsu()
	{
		return dnUKnK4P0hLQLJIh4U90 == null;
	}

	internal static qAN2ZB2gNPbBAbr7ZB2I xdYWIk4PHbbp6SBaXdJs()
	{
		return dnUKnK4P0hLQLJIh4U90;
	}

	internal static void GXf73n4PfSZxeyS9uIHg(object P_0, object P_1, object P_2)
	{
		((DependencyObject)P_0).SetValue((DependencyProperty)P_1, P_2);
	}

	internal static double bk3cO04P9lA8TOecoJEv(object P_0)
	{
		return ((Popup)P_0).HorizontalOffset;
	}

	internal static void MPIrkA4PnEevmUEJxQHB(object P_0, object P_1)
	{
		((Window)P_0).Activated += (EventHandler)P_1;
	}

	internal static void GUixCC4PGsy5C5hwmyOj(object P_0, object P_1)
	{
		((Window)P_0).Deactivated += (EventHandler)P_1;
	}

	internal static void FEIyTV4PYRSNhtlBgJ6x(object P_0, object P_1)
	{
		((Window)P_0).StateChanged += (EventHandler)P_1;
	}

	internal static void lEb8oh4PouJL8pWZIfU7(object P_0, object P_1)
	{
		((Window)P_0).Deactivated -= (EventHandler)P_1;
	}

	internal static WindowState UED7mD4PvgwM67LhI9xj(object P_0)
	{
		return ((Window)P_0).WindowState;
	}

	internal static void DBAG5m4PB1af5K3CHaUO(object P_0, bool P_1)
	{
		((Popup)P_0).IsOpen = P_1;
	}

	internal static bool CS9pcI4PaUndhwOQZbW2(object P_0)
	{
		return ((Window)P_0).Activate();
	}

	internal static object AYinmW4PiZPfKYBG4Pu2(object P_0)
	{
		return PresentationSource.FromVisual((Visual)P_0);
	}

	internal static double rYE5nY4Plk1b6mCCAEXH(object P_0)
	{
		return ((FrameworkElement)P_0).Width;
	}

	internal static double kj4huo4P4A98x8HEw2Du(object P_0)
	{
		return ((FrameworkElement)P_0).Height;
	}

	internal static RuntimeTypeHandle cKBPms4PD0K8UynrDT2F(int token)
	{
		return zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(token);
	}
}
