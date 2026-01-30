using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Threading;
using ActiproSoftware.Windows.Interop;
using ActiproSoftware.Windows.Media;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Themes;

internal class WindowChromeManager : DependencyObject, NativeMethods.IWindowChromeManager
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass47_0
	{
		public WindowChromeElementKind rW9;

		internal static _003C_003Ec__DisplayClass47_0 P8R;

		public _003C_003Ec__DisplayClass47_0()
		{
			hHEYokUTtehNq5ji0d.LrmWXz();
			base._002Ector();
		}

		internal HitTestFilterBehavior wWJ(DependencyObject obj)
		{
			if (obj is UIElement uIElement)
			{
				if (uIElement.Visibility != Visibility.Visible || !(uIElement.Opacity > 0.0))
				{
					return HitTestFilterBehavior.ContinueSkipSelfAndChildren;
				}
				rW9 = WindowChrome.GetElementKind(uIElement);
				if (rW9 == WindowChromeElementKind.NonClientArea)
				{
					return HitTestFilterBehavior.Continue;
				}
				if (rW9 == WindowChromeElementKind.Unknown)
				{
					if (uIElement is Control { Background: null })
					{
						return HitTestFilterBehavior.Continue;
					}
					if (uIElement is Panel panel && (panel.Background == null || panel.Background == Brushes.Transparent))
					{
						return HitTestFilterBehavior.Continue;
					}
					if (uIElement is Border { Background: null })
					{
						return HitTestFilterBehavior.Continue;
					}
					if (uIElement is Shape { Fill: null })
					{
						return HitTestFilterBehavior.Continue;
					}
					if (uIElement is AdornerLayer || uIElement is ContentPresenter || uIElement is ItemsPresenter || uIElement is Decorator)
					{
						return HitTestFilterBehavior.Continue;
					}
				}
			}
			return HitTestFilterBehavior.Stop;
		}

		internal static bool j89()
		{
			return P8R == null;
		}

		internal static _003C_003Ec__DisplayClass47_0 K8c()
		{
			return P8R;
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec SW2;

		public static HitTestResultCallback CWe;

		public static VisualTreeHelperExtended.VisualResultCallback xW7;

		public static VisualTreeHelperExtended.VisualDescendantFilterCallback SWF;

		public static VisualTreeHelperExtended.VisualResultCallback GWo;

		public static VisualTreeHelperExtended.VisualDescendantFilterCallback DWQ;

		private static _003C_003Ec U8u;

		static _003C_003Ec()
		{
			hHEYokUTtehNq5ji0d.LrmWXz();
			SW2 = new _003C_003Ec();
		}

		public _003C_003Ec()
		{
			hHEYokUTtehNq5ji0d.LrmWXz();
			base._002Ector();
		}

		internal HitTestResultBehavior FWh(HitTestResult result)
		{
			return HitTestResultBehavior.Stop;
		}

		internal VisualResultBehavior CWm(DependencyObject obj)
		{
			if (obj is UIElement element)
			{
				WindowChromeElementKind elementKind = WindowChrome.GetElementKind(element);
				WindowChromeElementKind windowChromeElementKind = elementKind;
				WindowChromeElementKind windowChromeElementKind2 = windowChromeElementKind;
				if (windowChromeElementKind2 == WindowChromeElementKind.OverlayClientArea)
				{
					return VisualResultBehavior.Stop;
				}
			}
			return VisualResultBehavior.Continue;
		}

		internal VisualDescendantFilterBehavior CWw(DependencyObject obj)
		{
			if (obj is UIElement element)
			{
				WindowChromeElementKind elementKind = WindowChrome.GetElementKind(element);
				WindowChromeElementKind windowChromeElementKind = elementKind;
				WindowChromeElementKind windowChromeElementKind2 = windowChromeElementKind;
				if (windowChromeElementKind2 == WindowChromeElementKind.NonClientArea)
				{
					return VisualDescendantFilterBehavior.ContinueSkipSelf;
				}
				if (windowChromeElementKind2 == WindowChromeElementKind.OverlayClientArea)
				{
					return VisualDescendantFilterBehavior.Stop;
				}
				int num = 0;
				if (!S8o())
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
			}
			return VisualDescendantFilterBehavior.ContinueSkipSelfAndChildren;
		}

		internal VisualResultBehavior eW4(DependencyObject obj)
		{
			if (obj is UIElement element)
			{
				int num = 0;
				if (o85() != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				WindowChromeElementKind elementKind = WindowChrome.GetElementKind(element);
				WindowChromeElementKind windowChromeElementKind = elementKind;
				WindowChromeElementKind windowChromeElementKind2 = windowChromeElementKind;
				if (windowChromeElementKind2 == WindowChromeElementKind.SystemMenu)
				{
					return VisualResultBehavior.Stop;
				}
			}
			return VisualResultBehavior.Continue;
		}

		internal VisualDescendantFilterBehavior pWu(DependencyObject obj)
		{
			if (obj is UIElement element)
			{
				WindowChromeElementKind elementKind = WindowChrome.GetElementKind(element);
				WindowChromeElementKind windowChromeElementKind = elementKind;
				WindowChromeElementKind windowChromeElementKind2 = windowChromeElementKind;
				int num = 0;
				if (!S8o())
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				switch (windowChromeElementKind2)
				{
				case WindowChromeElementKind.NonClientArea:
				case WindowChromeElementKind.TitleBar:
					return VisualDescendantFilterBehavior.ContinueSkipSelf;
				case WindowChromeElementKind.SystemMenu:
					return VisualDescendantFilterBehavior.Stop;
				}
			}
			return VisualDescendantFilterBehavior.ContinueSkipSelfAndChildren;
		}

		internal static bool S8o()
		{
			return U8u == null;
		}

		internal static _003C_003Ec o85()
		{
			return U8u;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass55_0
	{
		public FrameworkElement wW0;

		public WindowChromeManager SWk;

		internal static _003C_003Ec__DisplayClass55_0 U8m;

		public _003C_003Ec__DisplayClass55_0()
		{
			hHEYokUTtehNq5ji0d.LrmWXz();
			base._002Ector();
		}

		internal void eWO()
		{
			if (SWk.A2U != null && WindowChrome.GetIsOverlayVisible(SWk.A2U))
			{
				wW0.MoveFocus(new TraversalRequest(FocusNavigationDirection.First));
			}
		}

		internal static bool l8Z()
		{
			return U8m == null;
		}

		internal static _003C_003Ec__DisplayClass55_0 K8r()
		{
			return U8m;
		}
	}

	private WindowChrome chrome;

	private bool m2x;

	private bool E2r;

	private bool O2Z;

	private bool T2n;

	private WindowChromeShadow V2a;

	private WeakReference v2q;

	private DateTime M2W;

	private Window A2U;

	private bool J2H;

	private bool x26;

	private IntPtr V2V;

	private HwndSourceHook o25;

	private static readonly DependencyProperty q2R;

	private static readonly DependencyProperty f2E;

	private static readonly DependencyProperty d2s;

	public static readonly DependencyProperty WindowChromeManagerProperty;

	private static WindowChromeManager WYA;

	bool NativeMethods.IWindowChromeManager.CanClose => WindowChrome.GetHasCloseButtonResolved(A2U);

	bool NativeMethods.IWindowChromeManager.CanMaximize => WindowChrome.GetHasMaximizeButtonResolved(A2U);

	bool NativeMethods.IWindowChromeManager.CanMinimize => WindowChrome.GetHasMinimizeButtonResolved(A2U);

	bool NativeMethods.IWindowChromeManager.CanRestore => WindowChrome.GetHasRestoreButtonResolved(A2U);

	bool NativeMethods.IWindowChromeManager.HasSetClip
	{
		get
		{
			return E2r;
		}
		set
		{
			E2r = value;
		}
	}

	public Window OuterGlow => V2a;

	NativeMethods.NonClientHitTestResult NativeMethods.IWindowChromeManager.HitTestNonClientArea(Rect bounds, Point location, Point relativeLocation)
	{
		NativeMethods.NonClientHitTestResult result = NativeMethods.NonClientHitTestResult.HTCLIENT;
		if (chrome != null && A2U != null)
		{
			if (bounds.Contains(location))
			{
				bool flag = false;
				ResizeMode resizeMode = A2U.ResizeMode;
				ResizeMode resizeMode2 = resizeMode;
				if ((uint)(resizeMode2 - 2) <= 1u)
				{
					flag = A2U.WindowState == WindowState.Normal;
				}
				if (flag)
				{
					Thickness thickness = A2Y();
					if (location.X < bounds.Left + thickness.Left || location.X >= bounds.Right - thickness.Right || location.Y < bounds.Top + thickness.Top || location.Y >= bounds.Bottom - thickness.Bottom)
					{
						result = ((location.X < bounds.Left + thickness.Left) ? ((location.Y < bounds.Top + 12.0) ? NativeMethods.NonClientHitTestResult.HTTOPLEFT : ((!(location.Y >= bounds.Bottom - 12.0)) ? NativeMethods.NonClientHitTestResult.HTLEFT : NativeMethods.NonClientHitTestResult.HTBOTTOMLEFT)) : ((location.X >= bounds.Right - thickness.Right) ? ((location.Y < bounds.Top + 12.0) ? NativeMethods.NonClientHitTestResult.HTTOPRIGHT : ((!(location.Y >= bounds.Bottom - 12.0)) ? NativeMethods.NonClientHitTestResult.HTRIGHT : NativeMethods.NonClientHitTestResult.HTBOTTOMRIGHT)) : ((location.Y < bounds.Top + thickness.Top) ? ((location.X < bounds.Left + 12.0) ? NativeMethods.NonClientHitTestResult.HTTOPLEFT : ((!(location.X >= bounds.Right - 12.0)) ? NativeMethods.NonClientHitTestResult.HTTOP : NativeMethods.NonClientHitTestResult.HTTOPRIGHT)) : ((location.X < bounds.Left + 12.0) ? NativeMethods.NonClientHitTestResult.HTBOTTOMLEFT : ((!(location.X >= bounds.Right - 12.0)) ? NativeMethods.NonClientHitTestResult.HTBOTTOM : NativeMethods.NonClientHitTestResult.HTBOTTOMRIGHT)))));
					}
				}
			}
			switch (r23(relativeLocation))
			{
			case WindowChromeElementKind.ResizeGrip:
				result = NativeMethods.NonClientHitTestResult.HTBOTTOMRIGHT;
				break;
			case WindowChromeElementKind.SystemMenu:
				result = NativeMethods.NonClientHitTestResult.HTSYSMENU;
				break;
			case WindowChromeElementKind.TitleBar:
				result = NativeMethods.NonClientHitTestResult.HTCAPTION;
				break;
			case WindowChromeElementKind.TitleBarButton:
				result = NativeMethods.NonClientHitTestResult.HTCLIENT;
				break;
			}
		}
		return result;
	}

	private void TuP()
	{
		int num = 1;
		bool flag = default(bool);
		while (true)
		{
			int num2 = num;
			do
			{
				switch (num2)
				{
				default:
					if (flag)
					{
						if (chrome.StyleKey != null)
						{
							A2U.Style = A2U.TryFindResource(chrome.StyleKey) as Style;
						}
						if (A2U != null)
						{
							NativeMethods.UpdateMenuEnabledStates(A2U, this);
							A2U.InvalidateMeasure();
							SuG();
						}
					}
					return;
				case 1:
					break;
				}
				flag = A2U != null;
				num2 = 0;
			}
			while (qYV());
		}
	}

	private void SuG()
	{
		if (chrome != null && A2U != null && V2a == null && y2j() && !GetIsClosed(A2U))
		{
			V2a = new WindowChromeShadow(A2U);
		}
	}

	private void Cu1()
	{
		bool flag = V2a != null;
		bool flag2 = y2j();
		if (chrome != null && flag != flag2)
		{
			if (flag2)
			{
				SuG();
			}
			else
			{
				m2c();
			}
		}
	}

	private void Kuz()
	{
		m2c();
		if (A2U != null)
		{
			A2U.ClearValue(FrameworkElement.StyleProperty);
			A2U.InvalidateMeasure();
		}
	}

	private void m2c()
	{
		if (V2a != null)
		{
			V2a.Close();
			V2a = null;
		}
	}

	[SpecialName]
	private Thickness A2Y()
	{
		Thickness? thickness = null;
		if (chrome != null && chrome.ResizeBorderThickness.HasValue)
		{
			thickness = chrome.ResizeBorderThickness.Value;
		}
		else if (A2U != null)
		{
			thickness = u20(A2U);
		}
		if (!thickness.HasValue)
		{
			thickness = new Thickness(4.0);
		}
		return thickness.Value;
	}

	private bool y2j()
	{
		bool result = false;
		if (A2U != null && chrome != null)
		{
			int num = 0;
			if (DYT() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			if (chrome.HasOuterGlow != false)
			{
				result = chrome.HasOuterGlow.HasValue || f29(A2U) == true;
			}
		}
		return result;
	}

	private void M2v()
	{
		if (A2U != null && chrome != null)
		{
			bool hasMinimizeButtonResolved = WindowChrome.GetHasMinimizeButtonResolved(A2U);
			bool hasMaximizeButtonResolved = WindowChrome.GetHasMaximizeButtonResolved(A2U);
			NativeMethods.ConfigureButtonVisibility(A2U, hasMinimizeButtonResolved, hasMaximizeButtonResolved, isCloseButtonVisible: true);
			NativeMethods.UpdateWindowClipRegion(this, A2U);
			NativeMethods.UpdateMenuEnabledStates(A2U, this);
			Cu1();
		}
	}

	private void d2X(ContextMenu P_0, bool P_1)
	{
		if (P_0 == null)
		{
			return;
		}
		bool flag = P_1;
		int num = 0;
		if (!qYV())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (flag)
		{
			Mouse.AddPreviewMouseDownOutsideCapturedElementHandler(P_0, i2T);
			P_0.Closed += f2B;
		}
		else
		{
			P_0.Closed -= f2B;
			Mouse.RemovePreviewMouseDownOutsideCapturedElementHandler(P_0, i2T);
		}
	}

	private void i2T(object P_0, MouseButtonEventArgs P_1)
	{
		if (A2U != null && P_1.LeftButton == MouseButtonState.Pressed && (DateTime.Now - M2W).TotalMilliseconds <= 500.0)
		{
			Point location = A2U.PointToScreen(P_1.GetPosition(A2U));
			NativeMethods.NonClientHitTestResult nonClientHitTestResult = NativeMethods.NonClientHitTest(A2U, location);
			if (nonClientHitTestResult == NativeMethods.NonClientHitTestResult.HTSYSMENU)
			{
				d2X(P_0 as ContextMenu, _0020: false);
				A2U.Close();
			}
		}
	}

	private void f2B(object P_0, RoutedEventArgs P_1)
	{
		d2X(P_0 as ContextMenu, _0020: false);
	}

	private bool X2p(bool P_0)
	{
		ContextMenu contextMenu = chrome.CreateSystemMenu(A2U, default(Point), NativeMethods.NonClientHitTestResult.HTSYSMENU);
		if (contextMenu != null && chrome != null)
		{
			contextMenu = chrome.RaiseWindowSystemMenuOpeningEvent(A2U, contextMenu);
		}
		if (contextMenu != null)
		{
			FrameworkElement frameworkElement = D2J();
			if (frameworkElement != null && frameworkElement.IsVisible)
			{
				contextMenu.PlacementTarget = frameworkElement;
				contextMenu.Placement = PlacementMode.Bottom;
				contextMenu.VerticalOffset = Math.Max(3.0, frameworkElement.Margin.Bottom);
				if (P_0)
				{
					d2X(contextMenu, _0020: true);
				}
			}
			else
			{
				contextMenu.PlacementTarget = A2U;
				contextMenu.Placement = PlacementMode.Relative;
				Thickness thickness = chrome.ResizeBorderThickness ?? new Thickness(4.0);
				contextMenu.HorizontalOffset = thickness.Left;
				contextMenu.VerticalOffset = thickness.Top;
			}
			M2W = DateTime.Now;
			contextMenu.IsOpen = true;
			return true;
		}
		return false;
	}

	private void y2b(FrameworkElement P_0)
	{
		if (P_0 == null)
		{
			v2q = null;
			return;
		}
		P_0.Visibility = Visibility.Collapsed;
		v2q = new WeakReference(P_0);
	}

	private void P2y(Window P_0)
	{
		if (A2U == P_0)
		{
			return;
		}
		f2i();
		P_0.SetResourceReference(q2R, AssetResourceKeys.WindowHasOuterGlowBooleanKey);
		P_0.SetResourceReference(d2s, AssetResourceKeys.WindowResizeBorderNormalThicknessKey);
		A2U = P_0;
		A2U.Closed += W2F;
		A2U.SourceInitialized += r2o;
		A2U.StateChanged += a2O;
		J2H = false;
		x26 = false;
		int num = 1;
		if (!qYV())
		{
			goto IL_0005;
		}
		goto IL_0009;
		IL_0009:
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				m2x = false;
				V2V = new WindowInteropHelper(A2U).Handle;
				if (!(V2V != IntPtr.Zero))
				{
					return;
				}
				A2U.ApplyTemplate();
				k2w();
				num = 0;
				if (DYT() == null)
				{
					break;
				}
				goto end_IL_0009;
			}
			continue;
			end_IL_0009:
			break;
		}
		goto IL_0005;
		IL_0005:
		int num2 = default(int);
		num = num2;
		goto IL_0009;
	}

	private void b2f()
	{
		if (o25 == null && V2V != IntPtr.Zero)
		{
			HwndSource hwndSource = HwndSource.FromHwnd(V2V);
			if (hwndSource != null)
			{
				o25 = Y2l;
				hwndSource.AddHook(o25);
			}
		}
	}

	private void f2i()
	{
		if (A2U == null)
		{
			return;
		}
		y2b(null);
		A2U.ClearValue(q2R);
		A2U.ClearValue(d2s);
		q2S();
		if (!J2H)
		{
			NativeMethods.RemoveClipRegion(V2V);
		}
		NativeMethods.ConfigureNonClientArea(A2U, isIconVisible: true, isTitleVisible: true);
		Kuz();
		J2H = true;
		x26 = false;
		A2U.Closed -= W2F;
		int num = 1;
		if (!qYV())
		{
			goto IL_0005;
		}
		goto IL_0009;
		IL_0005:
		int num2 = default(int);
		num = num2;
		goto IL_0009;
		IL_0009:
		do
		{
			switch (num)
			{
			case 1:
				break;
			default:
				m2x = false;
				E2r = false;
				return;
			}
			A2U.SourceInitialized -= r2o;
			A2U.StateChanged -= a2O;
			A2U = null;
			V2V = IntPtr.Zero;
			num = 0;
		}
		while (DYT() == null);
		goto IL_0005;
	}

	private void q2S()
	{
		if (o25 != null && V2V != IntPtr.Zero)
		{
			HwndSource hwndSource = HwndSource.FromHwnd(V2V);
			int num = 0;
			if (!qYV())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			hwndSource?.RemoveHook(o25);
			o25 = null;
		}
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	private WindowChromeElementKind r23(Point P_0)
	{
		_003C_003Ec__DisplayClass47_0 CS_0024_003C_003E8__locals5 = new _003C_003Ec__DisplayClass47_0();
		CS_0024_003C_003E8__locals5.rW9 = WindowChromeElementKind.Unknown;
		if (A2U != null && VisualTreeHelper.GetChildrenCount(A2U) >= 1)
		{
			Visual visual = VisualTreeHelper.GetChild(A2U, 0) as Visual;
			if (visual != null && VisualTreeHelper.GetParent(visual) == A2U)
			{
				if (visual is AdornerDecorator { Child: not null } adornerDecorator && VisualTreeHelper.GetParent(adornerDecorator.Child) == adornerDecorator)
				{
					visual = adornerDecorator.Child;
				}
				P_0 = A2U.TransformToDescendant(visual).Transform(P_0);
				VisualTreeHelper.HitTest(visual, delegate(DependencyObject obj)
				{
					if (obj is UIElement uIElement)
					{
						if (uIElement.Visibility != Visibility.Visible || !(uIElement.Opacity > 0.0))
						{
							return HitTestFilterBehavior.ContinueSkipSelfAndChildren;
						}
						CS_0024_003C_003E8__locals5.rW9 = WindowChrome.GetElementKind(uIElement);
						if (CS_0024_003C_003E8__locals5.rW9 == WindowChromeElementKind.NonClientArea)
						{
							return HitTestFilterBehavior.Continue;
						}
						if (CS_0024_003C_003E8__locals5.rW9 == WindowChromeElementKind.Unknown)
						{
							if (uIElement is Control { Background: null })
							{
								return HitTestFilterBehavior.Continue;
							}
							if (uIElement is Panel panel && (panel.Background == null || panel.Background == Brushes.Transparent))
							{
								return HitTestFilterBehavior.Continue;
							}
							if (uIElement is Border { Background: null })
							{
								return HitTestFilterBehavior.Continue;
							}
							if (uIElement is Shape { Fill: null })
							{
								return HitTestFilterBehavior.Continue;
							}
							if (uIElement is AdornerLayer || uIElement is ContentPresenter || uIElement is ItemsPresenter || uIElement is Decorator)
							{
								return HitTestFilterBehavior.Continue;
							}
						}
					}
					return HitTestFilterBehavior.Stop;
				}, (HitTestResult result) => HitTestResultBehavior.Stop, new PointHitTestParameters(P_0));
			}
		}
		return CS_0024_003C_003E8__locals5.rW9;
	}

	private FrameworkElement e2t()
	{
		if (A2U == null)
		{
			return null;
		}
		DependencyObject descendant = VisualTreeHelperExtended.GetDescendant(A2U, delegate(DependencyObject obj)
		{
			if (obj is UIElement element)
			{
				WindowChromeElementKind elementKind = WindowChrome.GetElementKind(element);
				WindowChromeElementKind windowChromeElementKind = elementKind;
				WindowChromeElementKind windowChromeElementKind2 = windowChromeElementKind;
				if (windowChromeElementKind2 == WindowChromeElementKind.OverlayClientArea)
				{
					return VisualResultBehavior.Stop;
				}
			}
			return VisualResultBehavior.Continue;
		}, delegate(DependencyObject obj)
		{
			if (obj is UIElement element)
			{
				WindowChromeElementKind elementKind = WindowChrome.GetElementKind(element);
				WindowChromeElementKind windowChromeElementKind = elementKind;
				WindowChromeElementKind windowChromeElementKind2 = windowChromeElementKind;
				if (windowChromeElementKind2 == WindowChromeElementKind.NonClientArea)
				{
					return VisualDescendantFilterBehavior.ContinueSkipSelf;
				}
				if (windowChromeElementKind2 == WindowChromeElementKind.OverlayClientArea)
				{
					return VisualDescendantFilterBehavior.Stop;
				}
				int num = 0;
				if (!_003C_003Ec.S8o())
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
			}
			return VisualDescendantFilterBehavior.ContinueSkipSelfAndChildren;
		});
		return descendant as FrameworkElement;
	}

	private FrameworkElement D2J()
	{
		if (A2U == null)
		{
			return null;
		}
		DependencyObject descendant = VisualTreeHelperExtended.GetDescendant(A2U, delegate(DependencyObject obj)
		{
			if (obj is UIElement element)
			{
				int num = 0;
				if (_003C_003Ec.o85() != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				WindowChromeElementKind elementKind = WindowChrome.GetElementKind(element);
				WindowChromeElementKind windowChromeElementKind = elementKind;
				WindowChromeElementKind windowChromeElementKind2 = windowChromeElementKind;
				if (windowChromeElementKind2 == WindowChromeElementKind.SystemMenu)
				{
					return VisualResultBehavior.Stop;
				}
			}
			return VisualResultBehavior.Continue;
		}, delegate(DependencyObject obj)
		{
			if (obj is UIElement element)
			{
				WindowChromeElementKind elementKind = WindowChrome.GetElementKind(element);
				WindowChromeElementKind windowChromeElementKind = elementKind;
				WindowChromeElementKind windowChromeElementKind2 = windowChromeElementKind;
				int num = 0;
				if (!_003C_003Ec.S8o())
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				switch (windowChromeElementKind2)
				{
				case WindowChromeElementKind.NonClientArea:
				case WindowChromeElementKind.TitleBar:
					return VisualDescendantFilterBehavior.ContinueSkipSelf;
				case WindowChromeElementKind.SystemMenu:
					return VisualDescendantFilterBehavior.Stop;
				}
			}
			return VisualDescendantFilterBehavior.ContinueSkipSelfAndChildren;
		});
		return descendant as FrameworkElement;
	}

	private static bool? f29(DependencyObject P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		return (bool?)P_0.GetValue(q2R);
	}

	private static void S2h(DependencyObject P_0, bool? P_1)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		P_0.SetValue(q2R, P_1);
	}

	private void m2m()
	{
		if (!(V2V == IntPtr.Zero))
		{
			if (chrome != null)
			{
				b2f();
				M2v();
				NativeMethods.ApplyWindowExStyle(V2V);
				TuP();
				A2U?.ApplyTemplate();
				y2b(e2t());
				NativeMethods.ConfigureNonClientArea(A2U, isIconVisible: false, isTitleVisible: false);
			}
			else
			{
				f2i();
			}
		}
	}

	private void k2w()
	{
		if (chrome != null)
		{
			m2m();
		}
	}

	private void n24()
	{
		if (!(V2V == IntPtr.Zero) && !m2x)
		{
			m2x = true;
			Dispatcher.CurrentDispatcher.BeginInvoke(DispatcherPriority.Loaded, (Action)delegate
			{
				m2x = false;
				M2v();
			});
		}
	}

	private void A2u(object P_0, RoutedEventArgs P_1)
	{
		if (A2U == null || v2q == null || !v2q.IsAlive)
		{
			return;
		}
		_003C_003Ec__DisplayClass55_0 CS_0024_003C_003E8__locals9 = new _003C_003Ec__DisplayClass55_0();
		CS_0024_003C_003E8__locals9.SWk = this;
		CS_0024_003C_003E8__locals9.wW0 = v2q.Target as FrameworkElement;
		if (CS_0024_003C_003E8__locals9.wW0 == null)
		{
			return;
		}
		bool isOverlayVisible = WindowChrome.GetIsOverlayVisible(A2U);
		OverlayAnimationKinds overlayAnimationKinds = WindowChrome.GetOverlayAnimationKinds(A2U);
		Visibility visibility = ((!isOverlayVisible) ? Visibility.Collapsed : Visibility.Visible);
		bool isAnimationSupported = ThemeManager.IsAnimationSupported;
		bool flag = isAnimationSupported && (overlayAnimationKinds & OverlayAnimationKinds.Fade) == OverlayAnimationKinds.Fade;
		bool flag2 = isAnimationSupported && (overlayAnimationKinds & OverlayAnimationKinds.Slide) == OverlayAnimationKinds.Slide;
		double value = ((!(flag || flag2)) ? 0.0 : (isOverlayVisible ? 0.2 : 0.1));
		EasingMode easingMode = (isOverlayVisible ? EasingMode.EaseOut : EasingMode.EaseIn);
		double value2 = ((!flag || !isOverlayVisible) ? 1.0 : 0.0);
		double value3 = ((!flag || isOverlayVisible) ? 1.0 : 0.0);
		double value4 = ((!flag2 || !isOverlayVisible) ? 0.0 : (-80.0));
		double value5 = ((!flag2 || isOverlayVisible) ? 0.0 : (-80.0));
		Storyboard storyboard = new Storyboard();
		ObjectAnimationUsingKeyFrames objectAnimationUsingKeyFrames = new ObjectAnimationUsingKeyFrames
		{
			KeyFrames = { (ObjectKeyFrame)new DiscreteObjectKeyFrame
			{
				KeyTime = KeyTime.FromTimeSpan(isOverlayVisible ? TimeSpan.Zero : TimeSpan.FromSeconds(value)),
				Value = visibility
			} }
		};
		Storyboard.SetTarget(objectAnimationUsingKeyFrames, CS_0024_003C_003E8__locals9.wW0);
		Storyboard.SetTargetProperty(objectAnimationUsingKeyFrames, new PropertyPath(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(100628)));
		storyboard.Children.Add(objectAnimationUsingKeyFrames);
		DoubleAnimation doubleAnimation = new DoubleAnimation
		{
			Duration = TimeSpan.FromSeconds(value),
			EasingFunction = new QuarticEase
			{
				EasingMode = easingMode
			},
			From = value2,
			To = value3
		};
		Storyboard.SetTarget(doubleAnimation, CS_0024_003C_003E8__locals9.wW0);
		Storyboard.SetTargetProperty(doubleAnimation, new PropertyPath(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(100652)));
		storyboard.Children.Add(doubleAnimation);
		DoubleAnimation doubleAnimation2 = new DoubleAnimation
		{
			Duration = TimeSpan.FromSeconds(value),
			EasingFunction = new QuarticEase
			{
				EasingMode = easingMode
			},
			From = value4,
			To = value5
		};
		Storyboard.SetTarget(doubleAnimation2, CS_0024_003C_003E8__locals9.wW0);
		Storyboard.SetTargetProperty(doubleAnimation2, new PropertyPath(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(100670)));
		storyboard.Children.Add(doubleAnimation2);
		storyboard.Begin();
		if (!isOverlayVisible)
		{
			return;
		}
		base.Dispatcher.BeginInvoke(DispatcherPriority.Loaded, (Action)delegate
		{
			if (CS_0024_003C_003E8__locals9.SWk.A2U != null && WindowChrome.GetIsOverlayVisible(CS_0024_003C_003E8__locals9.SWk.A2U))
			{
				CS_0024_003C_003E8__locals9.wW0.MoveFocus(new TraversalRequest(FocusNavigationDirection.First));
			}
		});
	}

	private void B22(object P_0, EventArgs P_1)
	{
		n24();
	}

	private static void c2e(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		if (P_0 is Window obj && (P_1.OldValue == null || !P_1.OldValue.Equals(P_1.NewValue)))
		{
			WindowChromeManager windowChromeManager = GetWindowChromeManager(obj);
			if (windowChromeManager != null && windowChromeManager.chrome != null && !windowChromeManager.chrome.HasOuterGlow.HasValue)
			{
				windowChromeManager.n24();
			}
		}
	}

	private static void L27(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		Window window = P_0 as Window;
		bool flag = window == null || (P_1.OldValue != null && P_1.OldValue.Equals(P_1.NewValue));
		int num = 1;
		if (!qYV())
		{
			goto IL_0005;
		}
		goto IL_0009;
		IL_0009:
		WindowChromeManager windowChromeManager = default(WindowChromeManager);
		Thickness? resizeBorderThickness = default(Thickness?);
		do
		{
			switch (num)
			{
			case 1:
				if (!flag)
				{
					windowChromeManager = GetWindowChromeManager(window);
					if (windowChromeManager != null && windowChromeManager.chrome != null)
					{
						break;
					}
					return;
				}
				return;
			default:
				if (!resizeBorderThickness.HasValue)
				{
					windowChromeManager.n24();
				}
				return;
			}
			resizeBorderThickness = windowChromeManager.chrome.ResizeBorderThickness;
			num = 0;
		}
		while (qYV());
		goto IL_0005;
		IL_0005:
		int num2 = default(int);
		num = num2;
		goto IL_0009;
	}

	private void W2F(object P_0, EventArgs P_1)
	{
		if (P_0 is Window window)
		{
			R2A(window, _0020: true);
		}
	}

	private void r2o(object P_0, EventArgs P_1)
	{
		if (A2U != null && V2V == IntPtr.Zero)
		{
			V2V = new WindowInteropHelper(A2U).Handle;
			k2w();
		}
	}

	private static void O2Q(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		if (P_0 is Window window && P_1.NewValue != P_1.OldValue)
		{
			if (P_1.NewValue is WindowChromeManager windowChromeManager)
			{
				windowChromeManager.P2y(window);
			}
			else if (P_1.OldValue is WindowChromeManager windowChromeManager2)
			{
				windowChromeManager2.f2i();
			}
		}
	}

	private void a2O(object P_0, EventArgs P_1)
	{
		if (A2U != null)
		{
			NativeMethods.UpdateMenuEnabledStates(A2U, this);
		}
	}

	private static Thickness? u20(DependencyObject P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		return (Thickness?)P_0.GetValue(d2s);
	}

	private static void W2k(DependencyObject P_0, Thickness? P_1)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		P_0.SetValue(d2s, P_1);
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	private IntPtr Y2l(IntPtr P_0, int P_1, IntPtr P_2, IntPtr P_3, ref bool P_4)
	{
		switch (P_1)
		{
		case 533:
			if (x26 && chrome != null && A2U != null)
			{
				x26 = false;
				chrome.RaiseWindowBoundsChangedEvent(A2U, T2n);
			}
			break;
		case 2:
			J2H = true;
			break;
		case 561:
			if (chrome != null && A2U != null)
			{
				x26 = true;
				chrome.RaiseWindowBoundsChangingEvent(A2U, T2n);
			}
			break;
		case 562:
			if (x26 && chrome != null && A2U != null)
			{
				x26 = false;
				chrome.RaiseWindowBoundsChangedEvent(A2U, T2n);
			}
			break;
		case 36:
			return NativeMethods.WmGetMinMaxInfo(A2U, P_0, P_3, ref P_4);
		case 134:
			return NativeMethods.WmNcActivate(P_0, P_2, ref P_4);
		case 131:
			return NativeMethods.WmNcCalcSize(P_0, P_3, ref P_4);
		case 132:
			return NativeMethods.WmNcHitTest(this, P_0, P_2, P_3, ref P_4);
		case 165:
			return NativeMethods.WmNcRButtonUp(A2U, chrome, P_0, P_2, P_3);
		case 12:
		case 128:
			return NativeMethods.WmSetTextOrIcon(P_0, P_1, P_2, P_3, ref P_4);
		case 274:
			switch (0xFFF0 & P_2.ToInt32())
			{
			case 61456:
				T2n = true;
				break;
			case 61696:
				T2n = false;
				P_4 = X2p(_0020: false);
				break;
			case 61584:
				T2n = false;
				P_4 = X2p(_0020: true);
				break;
			default:
				T2n = false;
				break;
			}
			break;
		case 71:
			if (A2U == null)
			{
				break;
			}
			try
			{
				if (O2Z)
				{
					break;
				}
				O2Z = true;
				return NativeMethods.WmWindowPosChanged(this, A2U, P_0, P_3);
			}
			finally
			{
				O2Z = false;
			}
		}
		return IntPtr.Zero;
	}

	[AttachedPropertyBrowsableForType(typeof(Window))]
	public static bool GetIsClosed(Window obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		return (bool)obj.GetValue(f2E);
	}

	private static void R2A(Window P_0, bool P_1)
	{
		if (P_0 != null)
		{
			P_0.SetValue(f2E, P_1);
			return;
		}
		throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
	}

	public void SetWindowStyle(WindowStyle style)
	{
		if (A2U != null)
		{
			A2U.WindowStyle = style;
		}
		if (V2V != IntPtr.Zero)
		{
			NativeMethods.ApplyWindowExStyle(V2V);
		}
	}

	public void UpdateWindowChrome(WindowChrome newChrome)
	{
		VerifyAccess();
		if (chrome == newChrome)
		{
			return;
		}
		if (chrome != null)
		{
			chrome.IsOverlayVisibleChanged -= A2u;
			chrome.RenderPropertyChanged -= B22;
		}
		chrome = newChrome;
		if (chrome != null)
		{
			int num = 0;
			if (!qYV())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			chrome.IsOverlayVisibleChanged += A2u;
			chrome.RenderPropertyChanged += B22;
		}
		m2m();
	}

	public static WindowChromeManager GetWindowChromeManager(DependencyObject obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		return (WindowChromeManager)obj.GetValue(WindowChromeManagerProperty);
	}

	public static void SetWindowChromeManager(DependencyObject obj, WindowChromeManager value)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		obj.SetValue(WindowChromeManagerProperty, value);
	}

	public WindowChromeManager()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		M2W = DateTime.Today;
		base._002Ector();
	}

	static WindowChromeManager()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		q2R = DependencyProperty.RegisterAttached(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(99216), typeof(bool?), typeof(WindowChromeManager), new FrameworkPropertyMetadata(false, c2e));
		f2E = DependencyProperty.RegisterAttached(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(100774), typeof(bool), typeof(WindowChromeManager), new FrameworkPropertyMetadata(false));
		d2s = DependencyProperty.RegisterAttached(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(99580), typeof(Thickness?), typeof(WindowChromeManager), new FrameworkPropertyMetadata(new Thickness(4.0), L27));
		WindowChromeManagerProperty = DependencyProperty.RegisterAttached(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(100794), typeof(WindowChromeManager), typeof(WindowChromeManager), new FrameworkPropertyMetadata(null, O2Q));
	}

	[CompilerGenerated]
	private void w2C()
	{
		m2x = false;
		M2v();
	}

	internal static bool qYV()
	{
		return WYA == null;
	}

	internal static WindowChromeManager DYT()
	{
		return WYA;
	}
}
