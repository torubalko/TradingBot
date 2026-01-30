using System;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Threading;
using ActiproSoftware.Windows.Controls;
using ActiproSoftware.Windows.Interop;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Themes;

internal class WindowChromeShadow : Window
{
	private int xey;

	private Color Eef;

	private Color lei;

	private DropShadowChrome reS;

	private IntPtr de3;

	private Window jet;

	private IntPtr VeJ;

	private int Fe9;

	private static WindowChromeShadow GYX;

	public WindowChromeShadow(Window primaryWindow)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		Eef = Color.FromArgb(36, 0, 0, 0);
		lei = Color.FromArgb(28, 0, 0, 0);
		base._002Ector();
		if (primaryWindow == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(100836));
		}
		int num = 1;
		object obj = primaryWindow.TryFindResource(AssetResourceKeys.WindowResizeBorderNormalThicknessKey);
		int num2;
		if (obj is Thickness)
		{
			num = Math.Max(1, Math.Min(8, (int)((Thickness)obj).Left));
			num2 = 0;
			if (1 == 0)
			{
				goto IL_0044;
			}
			goto IL_0048;
		}
		goto IL_0165;
		IL_0165:
		xey = 13;
		obj = primaryWindow.TryFindResource(AssetResourceKeys.WindowBorderOuterGlowNormalThicknessKey);
		if (obj is Thickness)
		{
			xey = Math.Max(0, Math.Min(16, (int)((Thickness)obj).Left));
		}
		Fe9 = Math.Max(0, Math.Min(xey, (int)WindowChrome.SystemResizeBorderThickness.Left - num));
		V2L(primaryWindow);
		reS = Y2d();
		base.AllowsTransparency = true;
		base.Background = Brushes.Transparent;
		base.Content = reS;
		base.ForceCursor = true;
		base.ShowActivated = false;
		base.ShowInTaskbar = false;
		base.Title = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(100866);
		base.WindowStartupLocation = WindowStartupLocation.Manual;
		num2 = 2;
		if (1 == 0)
		{
			goto IL_0044;
		}
		goto IL_0048;
		IL_0048:
		while (true)
		{
			switch (num2)
			{
			case 1:
				keT();
				rec();
				return;
			case 2:
				base.WindowStyle = WindowStyle.None;
				Kev();
				T2z();
				yeX();
				num2 = 1;
				if (1 == 0)
				{
					num2 = 1;
				}
				continue;
			}
			break;
		}
		goto IL_0165;
		IL_0044:
		int num3;
		num2 = num3;
		goto IL_0048;
	}

	private void V2L(Window P_0)
	{
		jet = P_0;
		VeJ = IntPtr.Zero;
		jet.Activated += W28;
		jet.Closed += p2g;
		jet.Deactivated += W28;
		jet.IsVisibleChanged += J2D;
		jet.LocationChanged += e2P;
		jet.SizeChanged += H2G;
		jet.StateChanged += p21;
		int num = 0;
		if (!PYU())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		try
		{
			if (!WindowChromeManager.GetIsClosed(jet))
			{
				base.Owner = jet;
			}
		}
		catch (InvalidOperationException)
		{
		}
		Binding binding = new Binding
		{
			Source = jet,
			Path = new PropertyPath(Control.BorderBrushProperty),
			Mode = BindingMode.OneWay
		};
		SetBinding(Control.BorderBrushProperty, binding);
	}

	private DropShadowChrome Y2d()
	{
		return new DropShadowChrome
		{
			BorderThickness = new Thickness(xey),
			Color = lei,
			CornerRadius = new CornerRadius(6.0),
			IsHitTestVisible = false,
			Margin = new Thickness(xey),
			XOffset = 0.0,
			YOffset = 0.0,
			ZOffset = xey
		};
	}

	private void r2N()
	{
		base.Owner = null;
		if (jet != null)
		{
			BindingOperations.ClearBinding(this, Control.BorderBrushProperty);
			jet.Activated -= W28;
			jet.Closed -= p2g;
			jet.Deactivated -= W28;
			jet.IsVisibleChanged -= J2D;
			jet.LocationChanged -= e2P;
			jet.SizeChanged -= H2G;
			jet.StateChanged -= p21;
			jet = null;
			VeJ = IntPtr.Zero;
		}
	}

	private void O2M()
	{
		if (VeJ == IntPtr.Zero && jet != null)
		{
			VeJ = new WindowInteropHelper(jet).Handle;
		}
	}

	private ResizeOperation q2K(Point P_0)
	{
		bool flag = false;
		if (jet != null)
		{
			ResizeMode resizeMode = jet.ResizeMode;
			ResizeMode resizeMode2 = resizeMode;
			if ((uint)(resizeMode2 - 2) <= 1u)
			{
				flag = jet.WindowState == WindowState.Normal;
			}
		}
		if (flag)
		{
			Rect bounds = new Rect(0.0, 0.0, base.ActualWidth, base.ActualHeight);
			bounds.Inflate(Fe9 - xey, Fe9 - xey);
			if (bounds.Contains(P_0))
			{
				return NativeMethods.HitTest(resizeThickness: new Thickness(Fe9), bounds: bounds, location: P_0);
			}
		}
		return ResizeOperation.None;
	}

	private void p2g(object P_0, EventArgs P_1)
	{
		Close();
	}

	private void W28(object P_0, EventArgs P_1)
	{
		Kev();
		keT();
	}

	private void J2D(object P_0, DependencyPropertyChangedEventArgs P_1)
	{
		yeX();
	}

	private void e2P(object P_0, EventArgs P_1)
	{
		T2z();
	}

	private void H2G(object P_0, SizeChangedEventArgs P_1)
	{
		T2z();
	}

	private void p21(object P_0, EventArgs P_1)
	{
		yeX();
		if (jet != null && jet.OwnedWindows.Count > 0 && jet.WindowState == WindowState.Normal)
		{
			keT();
		}
	}

	private void T2z()
	{
		if (jet != null)
		{
			keT();
			double num = ((jet.ActualWidth > 0.0) ? jet.ActualWidth : jet.Width);
			double num2 = ((jet.ActualHeight > 0.0) ? jet.ActualHeight : jet.Height);
			base.Left = jet.Left - (double)xey;
			base.Top = jet.Top - (double)xey;
			base.Width = num + (double)(2 * xey);
			base.Height = num2 + (double)(2 * xey);
			Lej();
		}
	}

	private void rec()
	{
		base.Dispatcher.BeginInvoke(DispatcherPriority.Send, (Action)delegate
		{
			if (jet != null && jet.WindowState == WindowState.Normal && jet.SizeToContent != SizeToContent.Manual)
			{
				T2z();
			}
		});
	}

	private void Lej()
	{
		base.Clip = new CombinedGeometry(GeometryCombineMode.Exclude, new RectangleGeometry(new Rect(0.0, 0.0, base.Width, base.Height)), new RectangleGeometry(new Rect(xey, xey, Math.Max(0.0, base.Width - (double)(2 * xey) - 1.0), Math.Max(0.0, base.Height - (double)(2 * xey) - 1.0))));
	}

	private void Kev()
	{
		if (reS == null)
		{
			return;
		}
		int num2 = default(int);
		while (true)
		{
			bool flag = jet != null && jet.IsActive;
			int num = 1;
			if (!PYU())
			{
				num = num2;
			}
			switch (num)
			{
			case 1:
			{
				Color color = lei;
				if (flag)
				{
					color = Eef;
					if (!NativeMethods.IsWindows8OrLater && base.BorderBrush is SolidColorBrush solidColorBrush)
					{
						color = Color.FromArgb(Eef.A, solidColorBrush.Color.R, solidColorBrush.Color.G, solidColorBrush.Color.B);
					}
				}
				if (reS.Color != color)
				{
					reS.Color = color;
				}
				return;
			}
			}
		}
	}

	private void yeX()
	{
		if (jet == null)
		{
			return;
		}
		if (!jet.IsVisible)
		{
			if (base.IsVisible)
			{
				Hide();
			}
			return;
		}
		int num;
		if (jet.WindowState == WindowState.Normal)
		{
			if (base.IsVisible)
			{
				return;
			}
			jet.Dispatcher.BeginInvoke(DispatcherPriority.Input, (Action)delegate
			{
				if (jet != null && jet.IsVisible && jet.WindowState == WindowState.Normal && !base.IsVisible)
				{
					Show();
				}
			});
			num = 0;
			if (!PYU())
			{
				goto IL_0005;
			}
		}
		else
		{
			num = 1;
			if (!PYU())
			{
				goto IL_0005;
			}
		}
		goto IL_0009;
		IL_0009:
		switch (num)
		{
		case 0:
			break;
		case 1:
			if (base.IsVisible)
			{
				Hide();
			}
			break;
		}
		return;
		IL_0005:
		int num2 = default(int);
		num = num2;
		goto IL_0009;
	}

	private void keT()
	{
		O2M();
		if (VeJ != IntPtr.Zero && de3 != IntPtr.Zero)
		{
			NativeMethods.UpdateZOrderBehind(VeJ, de3);
		}
	}

	private IntPtr veB(IntPtr P_0, int P_1, IntPtr P_2, IntPtr P_3, ref bool P_4)
	{
		switch (P_1)
		{
		case 33:
			return NativeMethods.WmMouseActivate_NoActivate(ref P_4);
		case 24:
			if (P_2.ToInt32() == 1)
			{
				keT();
			}
			break;
		case 6:
			if (P_2.ToInt32() != 0 && !NativeMethods.ActivateWindowByHandle(P_3) && jet != null && jet.IsVisible)
			{
				jet.Activate();
				int num = 1;
				if (CYL() != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				default:
				{
					IntPtr result = default(IntPtr);
					return result;
				}
				case 1:
					break;
				}
			}
			break;
		}
		return IntPtr.Zero;
	}

	protected override void OnClosed(EventArgs e)
	{
		base.OnClosed(e);
		r2N();
	}

	protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
	{
		base.OnMouseLeftButtonDown(e);
		if (e == null || !(VeJ != IntPtr.Zero))
		{
			return;
		}
		switch (e.ClickCount)
		{
		case 1:
		{
			Point position2 = e.GetPosition(this);
			ResizeOperation resizeOperation2 = q2K(position2);
			if (resizeOperation2 != ResizeOperation.None)
			{
				base.Cursor = NativeMethods.GetCursor(resizeOperation2);
				Cursor cursor = jet.Cursor;
				jet.Cursor = base.Cursor;
				jet.ForceCursor = true;
				NativeMethods.StartResizeOperation(VeJ, resizeOperation2);
				base.Cursor = null;
				jet.ForceCursor = false;
				jet.Cursor = cursor;
			}
			break;
		}
		case 2:
		{
			Point position = e.GetPosition(this);
			ResizeOperation resizeOperation = q2K(position);
			if (resizeOperation != ResizeOperation.None)
			{
				NativeMethods.NotifyNonClientDoubleClick(VeJ, resizeOperation);
			}
			break;
		}
		}
	}

	protected override void OnMouseMove(MouseEventArgs e)
	{
		base.OnMouseMove(e);
		if (e != null)
		{
			Point position = e.GetPosition(this);
			ResizeOperation operation = q2K(position);
			base.Cursor = NativeMethods.GetCursor(operation);
		}
	}

	protected override void OnPropertyChanged(DependencyPropertyChangedEventArgs e)
	{
		base.OnPropertyChanged(e);
		if (e.Property == Control.BorderBrushProperty)
		{
			Kev();
		}
	}

	protected override void OnSourceInitialized(EventArgs e)
	{
		base.OnSourceInitialized(e);
		de3 = new WindowInteropHelper(this).Handle;
		if (de3 != IntPtr.Zero)
		{
			NativeMethods.ApplyToolWindowExStyle(de3);
			HwndSource.FromHwnd(de3).AddHook(veB);
		}
	}

	[CompilerGenerated]
	private void Dep()
	{
		if (jet != null && jet.WindowState == WindowState.Normal && jet.SizeToContent != SizeToContent.Manual)
		{
			T2z();
		}
	}

	[CompilerGenerated]
	private void oeb()
	{
		if (jet != null && jet.IsVisible && jet.WindowState == WindowState.Normal && !base.IsVisible)
		{
			Show();
		}
	}

	internal static bool PYU()
	{
		return GYX == null;
	}

	internal static WindowChromeShadow CYL()
	{
		return GYX;
	}
}
