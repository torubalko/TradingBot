using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using ActiproSoftware.Windows.Controls;
using ActiproSoftware.Windows.Themes;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Interop;

internal static class NativeMethods
{
	public interface IWindowChromeManager
	{
		bool CanClose { get; }

		bool CanMaximize { get; }

		bool CanMinimize { get; }

		bool CanRestore { get; }

		bool HasSetClip { get; set; }

		NonClientHitTestResult HitTestNonClientArea(Rect bounds, Point location, Point relativeLocation);
	}

	private struct Vj
	{
		public uint IU0;

		public IntPtr mUk;

		public uint AUl;

		public uint vUA;

		public rH cUC;

		public int aUY;
	}

	private struct J6
	{
		public int Left;

		public int Right;

		public int Top;

		public int Bottom;

		internal static object QjE;

		public J6(Thickness P_0)
		{
			hHEYokUTtehNq5ji0d.LrmWXz();
			Left = (int)P_0.Left;
			Right = (int)P_0.Right;
			Top = (int)P_0.Top;
			Bottom = (int)P_0.Bottom;
		}

		internal static bool gjx()
		{
			return QjE == null;
		}

		internal static object ajS()
		{
			return QjE;
		}
	}

	private struct kT
	{
		public Vm uUI;

		public Vm TUx;

		public Vm pUr;

		public Vm YUZ;

		public Vm vUn;
	}

	[StructLayout(LayoutKind.Sequential)]
	private class g7
	{
		public int mUa;

		public rH rUq;

		public rH VUW;

		public int zUU;

		private static g7 njT;

		public g7()
		{
			hHEYokUTtehNq5ji0d.LrmWXz();
			mUa = Marshal.SizeOf(typeof(g7));
			base._002Ector();
		}

		internal static bool RjX()
		{
			return njT == null;
		}

		internal static g7 EjU()
		{
			return njT;
		}
	}

	private struct jQ
	{
		public rH dUH;

		public rH jU6;

		public rH cUV;

		public IntPtr sU5;
	}

	private struct Vm
	{
		public int UUR;

		public int yUE;
	}

	private struct rH
	{
		public int sUL;

		public int LUd;

		public int UUN;

		public int XUM;

		private static object djP;

		public Rect uUs()
		{
			return new Rect(sUL, LUd, UUN - sUL, XUM - LUd);
		}

		internal static bool rjW()
		{
			return djP == null;
		}

		internal static object njz()
		{
			return djP;
		}
	}

	internal struct UNSIGNED_RATIO
	{
		public uint uiNumerator;

		public uint uiDenominator;
	}

	[StructLayout(LayoutKind.Sequential)]
	private class zw
	{
		public int AUK;

		public int UUg;

		public int bU8;

		public Vm uUD;

		public Vm OUP;

		public rH eUG;

		private static zw Aet;

		public zw()
		{
			hHEYokUTtehNq5ji0d.LrmWXz();
			base._002Ector();
		}

		internal static bool Sef()
		{
			return Aet == null;
		}

		internal static zw De7()
		{
			return Aet;
		}
	}

	private struct Xl
	{
		public IntPtr AU1;

		public IntPtr wUz;

		public int wHc;

		public int YHj;

		public int wHv;

		public int fHX;

		public int CHT;
	}

	private struct SJ
	{
		public uint aHB;

		public uint mHp;
	}

	private enum vo
	{

	}

	public enum NonClientHitTestResult
	{
		HTERROR = -2,
		HTTRANSPARENT = -1,
		HTNOWHERE = 0,
		HTCLIENT = 1,
		HTCAPTION = 2,
		HTSYSMENU = 3,
		HTREDUCE = 8,
		HTMINBUTTON = 8,
		HTMAXBUTTON = 9,
		HTLEFT = 10,
		HTRIGHT = 11,
		HTTOP = 12,
		HTTOPLEFT = 13,
		HTTOPRIGHT = 14,
		HTBOTTOM = 15,
		HTBOTTOMLEFT = 16,
		HTBOTTOMRIGHT = 17,
		HTBORDER = 18,
		HTCLOSE = 20,
		HTHELP = 21
	}

	private static Matrix M03;

	private static bool? y0t;

	public const int WindowCornerLength = 12;

	internal const int SC_MOVE = 61456;

	internal const int SC_MOUSEMENU = 61584;

	internal const int SC_KEYMENU = 61696;

	internal const int WM_DESTROY = 2;

	internal const int WM_ACTIVATE = 6;

	internal const int WM_SETTEXT = 12;

	internal const int WM_SHOWWINDOW = 24;

	internal const int WM_SETTINGCHANGE = 26;

	internal const int WM_MOUSEACTIVATE = 33;

	internal const int WM_GETMINMAXINFO = 36;

	internal const int WM_WINDOWPOSCHANGED = 71;

	internal const int WM_SETICON = 128;

	internal const int WM_NCCALCSIZE = 131;

	internal const int WM_NCHITTEST = 132;

	internal const int WM_NCACTIVATE = 134;

	internal const int WM_NCLBUTTONDBLCLK = 163;

	internal const int WM_NCRBUTTONUP = 165;

	internal const int WM_SYSCOMMAND = 274;

	internal const int WM_CAPTURECHANGED = 533;

	internal const int WM_ENTERSIZEMOVE = 561;

	internal const int WM_EXITSIZEMOVE = 562;

	private static NativeMethods FHS;

	internal static bool IsWindows8OrLater
	{
		get
		{
			if (!y0t.HasValue)
			{
				y0t = Environment.OSVersion.Version.Major > 6 || (Environment.OSVersion.Version.Major == 6 && Environment.OSVersion.Version.Minor >= 2);
			}
			return y0t.Value;
		}
	}

	public static int MouseWheelScrollCharacters
	{
		get
		{
			int num = 3;
			int val = num;
			if (c0p(108, 0, ref val, 0))
			{
				return Math.Max(1, val);
			}
			return num;
		}
	}

	private static bool IOl(IntPtr P_0, uint P_1, uint P_2)
	{
		uint num = BOg(P_0, -20);
		uint num2 = (num & ~P_1) | P_2;
		if (num == num2 || B0j(P_0, -20, num2) == 0)
		{
			return false;
		}
		return true;
	}

	private static bool BOA(IntPtr P_0, uint P_1, uint P_2)
	{
		uint num = BOg(P_0, -16);
		uint num2 = (num & ~P_1) | P_2;
		if (num != num2 && B0j(P_0, -16, num2) != 0)
		{
			return true;
		}
		return false;
	}

	private static Point XOC(Point P_0)
	{
		return p0y().Transform(P_0);
	}

	private static Rect MOY(Rect P_0)
	{
		Point point = XOC(new Point(P_0.Left, P_0.Top));
		return new Rect(point, XOC(new Point(P_0.Right, P_0.Bottom)));
	}

	[SpecialName]
	private static Matrix p0y()
	{
		_ = M03;
		if (false)
		{
			M03 = Matrix.Identity;
			IntPtr zero = IntPtr.Zero;
			IntPtr intPtr = qOs(zero);
			try
			{
				int num = wOL(intPtr, (vo)88);
				int num2 = wOL(intPtr, (vo)90);
				M03.Scale(96.0 / (double)num, 96.0 / (double)num2);
			}
			finally
			{
				if (intPtr != IntPtr.Zero)
				{
					UO1(zero, intPtr);
				}
			}
		}
		return M03;
	}

	private static bool OOI(IntPtr P_0, out g7 P_1)
	{
		int num = 1;
		while (true)
		{
			int num2 = num;
			do
			{
				switch (num2)
				{
				case 1:
					break;
				default:
				{
					IntPtr intPtr = tOG(P_0, 2);
					if (!(intPtr != IntPtr.Zero))
					{
						return false;
					}
					DOd(intPtr, P_1);
					return true;
				}
				}
				P_1 = new g7();
				num2 = 0;
			}
			while (aHB());
		}
	}

	private static Point JOx(IntPtr P_0)
	{
		return new Point(KOa(P_0.ToInt64()), wOn(P_0.ToInt64()));
	}

	private static Rect QOr(IntPtr P_0)
	{
		rH rH = default(rH);
		IOD(P_0, ref rH);
		return rH.uUs();
	}

	[SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands")]
	private static WindowState AOZ(IntPtr P_0)
	{
		zw zw = new zw();
		zw.AUK = Marshal.SizeOf(typeof(zw));
		wO8(P_0, zw);
		return zw.bU8 switch
		{
			3 => WindowState.Maximized, 
			2 => WindowState.Minimized, 
			_ => WindowState.Normal, 
		};
	}

	private static short wOn(long P_0)
	{
		return (short)((P_0 >> 16) & 0xFFFF);
	}

	[SpecialName]
	private static bool S0i()
	{
		return Environment.OSVersion.Version.Major >= 6;
	}

	private static short KOa(long P_0)
	{
		return (short)(P_0 & 0xFFFF);
	}

	private static IntPtr tOq(Point P_0)
	{
		int value = ((ushort)(short)P_0.Y << 16) | (ushort)(short)P_0.X;
		return new IntPtr(value);
	}

	private static int NOW(ResizeOperation P_0)
	{
		return (int)(P_0 - 61431);
	}

	private static void WOU(IntPtr P_0, Point P_1)
	{
		int num = w0b(WON(P_0, _0020: false), 256u, (int)P_1.X, (int)P_1.Y, 0, P_0, IntPtr.Zero);
		if (num != 0)
		{
			x0c(P_0, 274, new IntPtr(num), IntPtr.Zero);
		}
	}

	private static bool TOH(IWindowChromeManager P_0, IntPtr P_1, Xl? P_2, CornerRadius P_3)
	{
		if (IsWindows8OrLater && !(P_3 != new CornerRadius(0.0)) && P_0 != null && !P_0.HasSetClip)
		{
			return false;
		}
		switch (AOZ(P_1))
		{
		case WindowState.Maximized:
		{
			if (IsWindows8OrLater)
			{
				RemoveClipRegion(P_1);
				return true;
			}
			if (P_0 != null)
			{
				P_0.HasSetClip = true;
			}
			Rect rect2 = QOr(P_1);
			int num2 = (P_2.HasValue ? P_2.Value.wHc : ((int)rect2.Left));
			int num3 = (P_2.HasValue ? P_2.Value.YHj : ((int)rect2.Top));
			if (OOI(P_1, out var g))
			{
				rH vUW = g.VUW;
				vUW.sUL -= num2;
				vUW.LUd -= num3;
				vUW.UUN -= num2;
				vUW.XUM -= num3;
				IntPtr intPtr2 = kOV(ref vUW);
				return T0X(P_1, intPtr2, _0020: true) != 0;
			}
			return false;
		}
		case WindowState.Normal:
		{
			if (P_0 != null)
			{
				P_0.HasSetClip = true;
			}
			Rect rect = QOr(P_1);
			int num = ((P_3.TopLeft > 0.0) ? Math.Max(0, Math.Min(20, (int)Math.Round(P_3.TopLeft))) : (-1));
			IntPtr intPtr = NO5(0, 0, (int)rect.Width + 1, (int)rect.Height + 1, num + 1, num + 1);
			return T0X(P_1, intPtr, _0020: false) != 0;
		}
		default:
			RemoveClipRegion(P_1);
			return true;
		}
	}

	private static IEnumerable<Window> cO6(IEnumerable<Window> P_0)
	{
		Dictionary<IntPtr, Window> windowsDictionary = new Dictionary<IntPtr, Window>();
		foreach (Window window in P_0)
		{
			if (window != null)
			{
				IntPtr hWnd = new WindowInteropHelper(window).Handle;
				if (hWnd != IntPtr.Zero)
				{
					windowsDictionary[hWnd] = window;
				}
			}
		}
		IntPtr hWnd2 = UOM(IntPtr.Zero);
		while (hWnd2 != IntPtr.Zero)
		{
			if (windowsDictionary.ContainsKey(hWnd2))
			{
				yield return windowsDictionary[hWnd2];
			}
			hWnd2 = gOK(hWnd2, 2u);
		}
	}

	public static bool ActivateWindowByHandle(IntPtr hwnd)
	{
		if (hwnd != IntPtr.Zero)
		{
			DOz(hwnd);
			return true;
		}
		return false;
	}

	public static void ApplyToolWindowExStyle(IntPtr hwnd)
	{
		BOA(hwnd, 983040u, 2147483648u);
		IOl(hwnd, 256u, 128u);
	}

	public static void ApplyWindowExStyle(IntPtr hwnd)
	{
		IOl(hwnd, 512u, 0u);
	}

	public static void ConfigureButtonVisibility(Window window, bool isMinimizeButtonVisible, bool isMaximizeButtonVisible, bool isCloseButtonVisible)
	{
		int num = 1;
		IntPtr handle = default(IntPtr);
		while (true)
		{
			int num2 = num;
			do
			{
				switch (num2)
				{
				default:
					if (!(handle == IntPtr.Zero))
					{
						uint num3 = (uint)(((!isMinimizeButtonVisible) ? 131072 : 0) | ((!isMaximizeButtonVisible) ? 65536 : 0) | ((!isCloseButtonVisible) ? 524288 : 0));
						uint num4 = (uint)((isMinimizeButtonVisible ? 131072 : 0) | (isMaximizeButtonVisible ? 65536 : 0) | (isCloseButtonVisible ? 524288 : 0));
						BOA(handle, num3, num4);
					}
					return;
				case 1:
					break;
				}
				handle = new WindowInteropHelper(window).Handle;
				num2 = 0;
			}
			while (KHA() == null);
		}
	}

	[SuppressMessage("Microsoft.Usage", "CA1806:DoNotIgnoreMethodResults", MessageId = "ActiproSoftware.Windows.Interop.NativeMethods.SetWindowThemeAttribute(System.IntPtr,System.UInt32,ActiproSoftware.Windows.Interop.NativeMethods+WTA_OPTIONS@,System.UInt32)")]
	public static void ConfigureNonClientArea(Window window, bool isIconVisible, bool isTitleVisible)
	{
		int num = 1;
		int num2 = num;
		IntPtr handle = default(IntPtr);
		while (true)
		{
			switch (num2)
			{
			case 1:
				handle = new WindowInteropHelper(window).Handle;
				num2 = 0;
				if (KHA() == null)
				{
					num2 = 0;
				}
				continue;
			}
			if (!(handle == IntPtr.Zero) && S0i())
			{
				SJ sJ = new SJ
				{
					aHB = (((!isTitleVisible) ? 1u : 0u) | (uint)((!isIconVisible) ? 6 : 0)),
					mHp = 7u
				};
				D0T(handle, 1u, ref sJ, (uint)Marshal.SizeOf(typeof(SJ)));
			}
			return;
		}
	}

	public static Cursor GetCursor(ResizeOperation operation)
	{
		switch (operation)
		{
		case ResizeOperation.West:
		case ResizeOperation.East:
			return Cursors.SizeWE;
		case ResizeOperation.North:
		case ResizeOperation.South:
			return Cursors.SizeNS;
		case ResizeOperation.NorthWest:
		case ResizeOperation.SouthEast:
			return Cursors.SizeNWSE;
		case ResizeOperation.NorthEast:
		case ResizeOperation.SouthWest:
			return Cursors.SizeNESW;
		default:
			return null;
		}
	}

	public static Point GetDpiMultiplier(IntPtr hwnd)
	{
		if (hwnd != IntPtr.Zero)
		{
			HwndSource hwndSource = HwndSource.FromHwnd(hwnd);
			if (hwndSource != null && hwndSource.CompositionTarget != null)
			{
				Matrix transformToDevice = hwndSource.CompositionTarget.TransformToDevice;
				return new Point(transformToDevice.M11, transformToDevice.M22);
			}
		}
		return new Point(1.0, 1.0);
	}

	[SuppressMessage("Microsoft.Usage", "CA1806:DoNotIgnoreMethodResults", MessageId = "ActiproSoftware.Windows.Interop.NativeMethods.ReleaseDC(System.IntPtr,System.IntPtr)")]
	public static Thickness GetSystemResizeBorderThickness()
	{
		int systemMetrics = GetSystemMetrics(32);
		int systemMetrics2 = GetSystemMetrics(33);
		Point point = new Point(1.0, 1.0);
		int num = 0;
		if (KHA() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		default:
		{
			int num3 = 0;
			if (S0i())
			{
				IntPtr zero = IntPtr.Zero;
				IntPtr intPtr = qOs(zero);
				try
				{
					int num4 = wOL(intPtr, (vo)88);
					if ((double)num4 > 96.0)
					{
						point.X = Math.Max(0.1, (double)num4 / 96.0);
						point.Y = Math.Max(0.1, (double)num4 / 96.0);
					}
					num3 = GetSystemMetrics(92);
				}
				finally
				{
					if (intPtr != IntPtr.Zero)
					{
						UO1(zero, intPtr);
					}
				}
			}
			return new Thickness(Math.Floor((double)(systemMetrics + num3) / point.X), Math.Floor((double)(systemMetrics2 + num3) / point.Y), Math.Floor((double)(systemMetrics + num3) / point.X), Math.Floor((double)(systemMetrics2 + num3) / point.Y));
		}
		}
	}

	public static Window GetTopWindow()
	{
		IEnumerable<Window> enumerable = Application.Current?.Windows.OfType<Window>();
		if (enumerable != null)
		{
			enumerable = cO6(enumerable);
			int num = 0;
			if (KHA() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			return num switch
			{
				_ => enumerable.FirstOrDefault(), 
			};
		}
		return null;
	}

	public static Point GetVisualDpiMultiplier(Visual visual)
	{
		if (visual != null)
		{
			PresentationSource presentationSource = PresentationSource.FromVisual(visual);
			if (presentationSource != null)
			{
				Matrix transformToDevice = presentationSource.CompositionTarget.TransformToDevice;
				return new Point(Math.Max(1.0, transformToDevice.M11), Math.Max(1.0, transformToDevice.M22));
			}
		}
		return new Point(1.0, 1.0);
	}

	public static ResizeOperation HitTest(Rect bounds, Thickness resizeThickness, Point location)
	{
		if (location.X < bounds.Left + resizeThickness.Left || location.X >= bounds.Right - resizeThickness.Right || location.Y < bounds.Top + resizeThickness.Top || location.Y >= bounds.Bottom - resizeThickness.Bottom)
		{
			if (location.X < bounds.Left + resizeThickness.Left)
			{
				if (location.Y < bounds.Top + (resizeThickness.Top + 12.0))
				{
					return ResizeOperation.NorthWest;
				}
				if (location.Y >= bounds.Bottom - (resizeThickness.Bottom + 12.0))
				{
					return ResizeOperation.SouthWest;
				}
				return ResizeOperation.West;
			}
			if (location.X >= bounds.Right - resizeThickness.Right)
			{
				if (location.Y < bounds.Top + (resizeThickness.Top + 12.0))
				{
					return ResizeOperation.NorthEast;
				}
				if (location.Y >= bounds.Bottom - (resizeThickness.Bottom + 12.0))
				{
					return ResizeOperation.SouthEast;
				}
				return ResizeOperation.East;
			}
			if (location.Y < bounds.Top + resizeThickness.Top)
			{
				if (location.X < bounds.Left + (resizeThickness.Left + 12.0))
				{
					return ResizeOperation.NorthWest;
				}
				if (location.X >= bounds.Right - (resizeThickness.Right + 12.0))
				{
					return ResizeOperation.NorthEast;
				}
				return ResizeOperation.North;
			}
			if (location.X < bounds.Left + (resizeThickness.Left + 12.0))
			{
				return ResizeOperation.SouthWest;
			}
			if (location.X >= bounds.Right - (resizeThickness.Right + 12.0))
			{
				return ResizeOperation.SouthEast;
			}
			return ResizeOperation.South;
		}
		return ResizeOperation.None;
	}

	public static NonClientHitTestResult NonClientHitTest(Window window, Point location)
	{
		IntPtr handle = new WindowInteropHelper(window).Handle;
		IntPtr intPtr = x0c(handle, 132, IntPtr.Zero, tOq(location));
		return (NonClientHitTestResult)(int)intPtr;
	}

	public static void NotifyNonClientDoubleClick(IntPtr hwnd, ResizeOperation operation)
	{
		int value = NOW(operation);
		x0c(hwnd, 163, new IntPtr(value), IntPtr.Zero);
	}

	[SuppressMessage("Microsoft.Usage", "CA1806:DoNotIgnoreMethodResults", MessageId = "ActiproSoftware.Windows.Interop.NativeMethods.SetWindowRgn(System.IntPtr,System.IntPtr,System.Boolean)")]
	public static void RemoveClipRegion(IntPtr hwnd)
	{
		T0X(hwnd, IntPtr.Zero, _0020: false);
	}

	public static void SetWindowState(Window window, WindowState state)
	{
		if (window != null)
		{
			IntPtr handle = new WindowInteropHelper(window).Handle;
			switch (state)
			{
			case WindowState.Maximized:
				x0c(handle, 274, new IntPtr(61488), IntPtr.Zero);
				break;
			case WindowState.Minimized:
				x0c(handle, 274, new IntPtr(61472), IntPtr.Zero);
				break;
			default:
				x0c(handle, 274, new IntPtr(61728), IntPtr.Zero);
				break;
			}
		}
	}

	public static void ShowSystemMenu(FrameworkElement element)
	{
		ShowSystemMenu(element, new Point(0.0, element.RenderSize.Height));
	}

	public static void ShowSystemMenu(FrameworkElement element, Point point)
	{
		Window window = Window.GetWindow(element);
		if (window != null)
		{
			IntPtr handle = new WindowInteropHelper(window).Handle;
			point = element.PointToScreen(point);
			WOU(handle, point);
		}
	}

	public static void StartResizeOperation(IntPtr hwnd, ResizeOperation operation)
	{
		x0c(hwnd, 274, new IntPtr((int)operation), IntPtr.Zero);
	}

	public static void StartWindowMove(Window window)
	{
		IntPtr handle = new WindowInteropHelper(window).Handle;
		x0c(handle, 274, new IntPtr(61456), IntPtr.Zero);
	}

	public static void StartWindowResize(Window window, ResizeOperation operation)
	{
		IntPtr handle = new WindowInteropHelper(window).Handle;
		StartResizeOperation(handle, operation);
	}

	public static void UpdateWindowClipRegion(IWindowChromeManager chromeManager, Window window)
	{
		IntPtr handle = new WindowInteropHelper(window).Handle;
		CornerRadius cornerRadius = ThemeProperties.GetCornerRadius(window);
		TOH(chromeManager, handle, null, cornerRadius);
	}

	[SuppressMessage("Microsoft.Usage", "CA1806:DoNotIgnoreMethodResults", MessageId = "ActiproSoftware.Windows.Interop.NativeMethods.EnableMenuItem(System.IntPtr,System.Int32,System.Int32)")]
	public static void UpdateMenuEnabledStates(Window window, IWindowChromeManager chromeManager)
	{
		IntPtr handle = new WindowInteropHelper(window).Handle;
		WindowState windowState = AOZ(handle);
		IntPtr intPtr = WON(handle, _0020: false);
		if (intPtr != IntPtr.Zero)
		{
			bool flag = windowState == WindowState.Normal;
			bool flag2 = windowState == WindowState.Normal;
			bool flag3 = windowState != WindowState.Minimized && chromeManager.CanMinimize;
			bool flag4 = windowState != WindowState.Normal && chromeManager.CanRestore;
			bool flag5 = windowState != WindowState.Maximized && chromeManager.CanMaximize;
			bool canClose = chromeManager.CanClose;
			switch (window.ResizeMode)
			{
			case ResizeMode.CanMinimize:
				flag5 = false;
				break;
			case ResizeMode.NoResize:
				flag2 = false;
				flag3 = false;
				flag5 = false;
				break;
			}
			OOE(intPtr, 61456, (!flag) ? 3 : 0);
			OOE(intPtr, 61440, (!flag2) ? 3 : 0);
			OOE(intPtr, 61472, (!flag3) ? 3 : 0);
			OOE(intPtr, 61728, (!flag4) ? 3 : 0);
			OOE(intPtr, 61488, (!flag5) ? 3 : 0);
			OOE(intPtr, 61536, (!canClose) ? 3 : 0);
		}
	}

	public static void UpdateZOrderBehind(IntPtr frontHwnd, IntPtr backHwnd)
	{
		z0v(backHwnd, frontHwnd, 0, 0, 0, 0, 19);
	}

	public static IntPtr WmGetMinMaxInfo(Window window, IntPtr hwnd, IntPtr lParam, ref bool handled)
	{
		kT structure = (kT)Marshal.PtrToStructure(lParam, typeof(kT));
		bool flag = false;
		if (OOI(hwnd, out var g))
		{
			rH vUW = g.VUW;
			rH rUq = g.rUq;
			int num = vUW.sUL;
			int num2 = vUW.LUd;
			if (g.zUU == 1)
			{
				if (!IsWindows8OrLater)
				{
					num = rUq.sUL;
					num2 = rUq.LUd;
				}
				Vj vj = default(Vj);
				vj.IU0 = (uint)Marshal.SizeOf(vj.GetType());
				if ((h0B(4, ref vj).ToInt32() & 1) == 1)
				{
					flag = true;
					if (h0B(5, ref vj).ToInt32() == 1)
					{
						switch (vj.vUA)
						{
						case 0u:
							num += 2;
							vUW.sUL += 2;
							break;
						case 1u:
							num2 += 2;
							vUW.LUd += 2;
							break;
						case 2u:
							vUW.UUN -= 2;
							break;
						case 3u:
							vUW.XUM -= 2;
							break;
						}
					}
				}
			}
			if (window != null)
			{
				WindowChrome.SetIsTaskbarAutoHidden(window, flag);
			}
			structure.pUr.UUR = Math.Abs(num - rUq.sUL);
			structure.pUr.yUE = Math.Abs(num2 - rUq.LUd);
			structure.TUx.UUR = Math.Abs(vUW.UUN - vUW.sUL);
			structure.TUx.yUE = Math.Abs(vUW.XUM - vUW.LUd);
			if (window != null)
			{
				Point dpiMultiplier = GetDpiMultiplier(hwnd);
				structure.YUZ.UUR = (int)Math.Ceiling(window.MinWidth * dpiMultiplier.X);
				structure.YUZ.yUE = (int)Math.Ceiling(window.MinHeight * dpiMultiplier.Y);
			}
			if (tOP(hwnd))
			{
				structure.vUn.UUR = structure.TUx.UUR;
				structure.vUn.yUE = structure.TUx.yUE;
			}
		}
		if (flag || (window != null && window.WindowStyle == WindowStyle.None))
		{
			Marshal.StructureToPtr(structure, lParam, fDeleteOld: true);
			handled = true;
		}
		return IntPtr.Zero;
	}

	public static IntPtr WmMouseActivate_NoActivate(ref bool handled)
	{
		handled = true;
		return new IntPtr(3);
	}

	public static IntPtr WmNcActivate(IntPtr hwnd, IntPtr wParam, ref bool handled)
	{
		handled = true;
		return TOR(hwnd, 134, wParam, new IntPtr(-1));
	}

	public static IntPtr WmNcCalcSize(IntPtr hwnd, IntPtr lParam, ref bool handled)
	{
		WindowState windowState = AOZ(hwnd);
		WindowState windowState2 = windowState;
		IntPtr result;
		if (windowState2 == WindowState.Minimized)
		{
			result = IntPtr.Zero;
			int num = 0;
			if (KHA() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
		else
		{
			handled = true;
			result = new IntPtr(768);
		}
		return result;
	}

	public static IntPtr WmNcHitTest(IWindowChromeManager chromeManager, IntPtr hwnd, IntPtr wParam, IntPtr lParam, ref bool handled)
	{
		Point point = JOx(lParam);
		Rect rect = QOr(hwnd);
		Point point2 = point;
		point2.Offset(0.0 - rect.X, 0.0 - rect.Y);
		Point dpiMultiplier = GetDpiMultiplier(hwnd);
		if (dpiMultiplier.X > 0.0 && dpiMultiplier.Y > 0.0)
		{
			dpiMultiplier.X = Math.Max(0.1, dpiMultiplier.X);
			dpiMultiplier.Y = Math.Max(0.1, dpiMultiplier.Y);
			rect.X /= dpiMultiplier.X;
			rect.Y /= dpiMultiplier.Y;
			rect.Width /= dpiMultiplier.X;
			rect.Height /= dpiMultiplier.Y;
			point.X /= dpiMultiplier.X;
			point.Y /= dpiMultiplier.Y;
			point2.X /= dpiMultiplier.X;
			point2.Y /= dpiMultiplier.Y;
		}
		NonClientHitTestResult value = chromeManager.HitTestNonClientArea(MOY(rect), XOC(point), XOC(point2));
		handled = true;
		return new IntPtr((int)value);
	}

	public static IntPtr WmNcRButtonUp(Window window, WindowChrome chrome, IntPtr hwnd, IntPtr wParam, IntPtr lParam)
	{
		bool flag = false;
		NonClientHitTestResult nonClientHitTestResult = (NonClientHitTestResult)wParam.ToInt32();
		switch (nonClientHitTestResult)
		{
		case NonClientHitTestResult.HTCAPTION:
			flag = chrome == null || window == null || !chrome.RaiseTitleBarContextMenuRequestedEvent(window);
			break;
		case NonClientHitTestResult.HTSYSMENU:
			flag = true;
			break;
		default:
			return IntPtr.Zero;
		}
		if (flag)
		{
			Point point = JOx(lParam);
			Point dpiMultiplier = GetDpiMultiplier(hwnd);
			if (dpiMultiplier.X > 0.0 && dpiMultiplier.Y > 0.0)
			{
				dpiMultiplier.X = Math.Max(0.1, dpiMultiplier.X);
				dpiMultiplier.Y = Math.Max(0.1, dpiMultiplier.Y);
				point.X /= dpiMultiplier.X;
				point.Y /= dpiMultiplier.Y;
			}
			if (chrome != null)
			{
				ContextMenu contextMenu = chrome.CreateSystemMenu(window, point, nonClientHitTestResult);
				if (contextMenu != null && chrome != null)
				{
					contextMenu = chrome.RaiseWindowSystemMenuOpeningEvent(window, contextMenu);
				}
				if (contextMenu != null)
				{
					contextMenu.IsOpen = true;
					return IntPtr.Zero;
				}
			}
			WOU(hwnd, point);
		}
		return IntPtr.Zero;
	}

	public static IntPtr WmSetTextOrIcon(IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam, ref bool handled)
	{
		bool flag = BOA(hwnd, 268435456u, 0u);
		IntPtr result = TOR(hwnd, msg, wParam, lParam);
		if (flag)
		{
			BOA(hwnd, 0u, 268435456u);
		}
		handled = true;
		return result;
	}

	public static IntPtr WmWindowPosChanged(IWindowChromeManager chromeManager, Window window, IntPtr hwnd, IntPtr lParam)
	{
		CornerRadius cornerRadius = ThemeProperties.GetCornerRadius(window);
		Xl value = (Xl)Marshal.PtrToStructure(lParam, typeof(Xl));
		TOH(chromeManager, hwnd, value, cornerRadius);
		return IntPtr.Zero;
	}

	[DllImport("Gdi32.dll", CharSet = CharSet.Auto, EntryPoint = "CreateRectRgnIndirect")]
	private static extern IntPtr kOV([In] ref rH P_0);

	[DllImport("Gdi32.dll", CharSet = CharSet.Auto, EntryPoint = "CreateRoundRectRgn")]
	private static extern IntPtr NO5(int P_0, int P_1, int P_2, int P_3, int P_4, int P_5);

	[DllImport("User32.dll", CharSet = CharSet.Auto, EntryPoint = "DefWindowProc")]
	private static extern IntPtr TOR(IntPtr P_0, int P_1, IntPtr P_2, IntPtr P_3);

	[DllImport("User32.dll", CharSet = CharSet.Auto, EntryPoint = "EnableMenuItem")]
	private static extern int OOE(IntPtr P_0, int P_1, int P_2);

	[DllImport("User32.dll", CharSet = CharSet.Auto, EntryPoint = "GetDC")]
	private static extern IntPtr qOs(IntPtr P_0);

	[DllImport("Gdi32.dll", CharSet = CharSet.Auto, EntryPoint = "GetDeviceCaps")]
	private static extern int wOL(IntPtr P_0, vo P_1);

	[DllImport("User32.dll", CharSet = CharSet.Auto, EntryPoint = "GetMonitorInfo")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool DOd(IntPtr P_0, g7 P_1);

	[DllImport("User32.dll", CharSet = CharSet.Auto, EntryPoint = "GetSystemMenu")]
	private static extern IntPtr WON(IntPtr P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1);

	[DllImport("User32.dll", CharSet = CharSet.Auto)]
	public static extern int GetSystemMetrics(int nIndex);

	[DllImport("User32.dll", CharSet = CharSet.Auto, EntryPoint = "GetTopWindow")]
	private static extern IntPtr UOM(IntPtr P_0);

	[DllImport("User32.dll", CharSet = CharSet.Auto, EntryPoint = "GetWindow")]
	private static extern IntPtr gOK(IntPtr P_0, uint P_1);

	[DllImport("User32.dll", CharSet = CharSet.Auto, EntryPoint = "GetWindowLong")]
	private static extern uint BOg(IntPtr P_0, int P_1);

	[DllImport("User32.dll", CharSet = CharSet.Auto, EntryPoint = "GetWindowPlacement")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool wO8(IntPtr P_0, zw P_1);

	[DllImport("User32.dll", CharSet = CharSet.Auto, EntryPoint = "GetWindowRect")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool IOD(IntPtr P_0, ref rH P_1);

	[DllImport("User32.dll", CharSet = CharSet.Auto, EntryPoint = "IsZoomed")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool tOP(IntPtr P_0);

	[DllImport("User32.dll", CharSet = CharSet.Auto, EntryPoint = "MonitorFromWindow")]
	private static extern IntPtr tOG(IntPtr P_0, int P_1);

	[DllImport("User32.dll", CharSet = CharSet.Auto, EntryPoint = "ReleaseDC")]
	private static extern int UO1(IntPtr P_0, IntPtr P_1);

	[DllImport("User32.dll", CharSet = CharSet.Auto, EntryPoint = "SetForegroundWindow")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool DOz(IntPtr P_0);

	[DllImport("User32.dll", CharSet = CharSet.Auto, EntryPoint = "SendMessage")]
	private static extern IntPtr x0c(IntPtr P_0, int P_1, IntPtr P_2, IntPtr P_3);

	[DllImport("User32.dll", CharSet = CharSet.Auto, EntryPoint = "SetWindowLong")]
	private static extern int B0j(IntPtr P_0, int P_1, uint P_2);

	[DllImport("User32.dll", CharSet = CharSet.Auto, EntryPoint = "SetWindowPos")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool z0v(IntPtr P_0, IntPtr P_1, int P_2, int P_3, int P_4, int P_5, int P_6);

	[DllImport("User32.dll", CharSet = CharSet.Auto, EntryPoint = "SetWindowRgn")]
	private static extern int T0X(IntPtr P_0, IntPtr P_1, [MarshalAs(UnmanagedType.Bool)] bool P_2);

	[DllImport("UxTheme.dll", EntryPoint = "SetWindowThemeAttribute")]
	private static extern int D0T(IntPtr P_0, uint P_1, ref SJ P_2, uint P_3);

	[DllImport("Shell32.dll", CharSet = CharSet.Auto, EntryPoint = "SHAppBarMessage")]
	private static extern IntPtr h0B(int P_0, ref Vj P_1);

	[DllImport("User32.dll", CharSet = CharSet.Auto, EntryPoint = "SystemParametersInfo")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool c0p(int P_0, int P_1, ref int P_2, int P_3);

	[DllImport("User32.dll", CharSet = CharSet.Auto, EntryPoint = "TrackPopupMenu")]
	private static extern int w0b(IntPtr P_0, uint P_1, int P_2, int P_3, int P_4, IntPtr P_5, IntPtr P_6);

	internal static bool aHB()
	{
		return FHS == null;
	}

	internal static NativeMethods KHA()
	{
		return FHS;
	}
}
