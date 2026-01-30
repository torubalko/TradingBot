using System;
using System.Drawing;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using System.Windows.Interop;
using bengxqsFHOBf5kWpcG0Y;
using gSJfigsFY1OGJ9yWyJhK;
using KvJdCOsJzwmqgaKKHKlv;
using lAZo0WsPn6tyQVhIALKn;

namespace UIKit.Core;

public sealed class Popup : System.Windows.Controls.Primitives.Popup
{
	private Window xSliPNkHn8N;

	private bool U1IiPkmc1j7;

	public static readonly DependencyProperty QgkiP1ks06h;

	public static readonly DependencyProperty i88iP5U1EH0;

	private static Popup lQnbbuXYHbelF9qSyAuy;

	public Placement DesiredPlacement
	{
		get
		{
			return (Placement)RNgqJgXYYUBJHM3qAETc(this, QgkiP1ks06h);
		}
		set
		{
			Ws6xokXYocXojbwbgKFG(this, QgkiP1ks06h, placement);
		}
	}

	public Placement RealPlacement
	{
		get
		{
			return (Placement)GetValue(i88iP5U1EH0);
		}
		set
		{
			Ws6xokXYocXojbwbgKFG(this, i88iP5U1EH0, placement);
		}
	}

	public Popup()
	{
		RwEN8CsJudtSqX6iB0vv.D4wX52wcDDu();
		base._002Ector();
		base.Loaded += GPniP90FnhY;
		int num = 0;
		if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_1c958f34803646f7bd8283df13e97b54 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				i3PPcRXYnCXsYqcuF4IG(this, new RoutedEventHandler(tuWiPYI0Mqp));
				num = 2;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_30b6a13fc6de439f86b8c44aa45349aa == 0)
				{
					num = 0;
				}
				break;
			case 1:
				base.CustomPopupPlacementCallback = U3IiPomJNUD;
				return;
			case 2:
				vtja6NXYGTtJk3AOTypx(this, new EventHandler(tFkiPHxitrT));
				base.Closed += NUuiP2ascFG;
				num = 1;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_95acc7c218cf41fca5a2921d69d7eb5c != 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	private void NUuiP2ascFG(object P_0, EventArgs P_1)
	{
		U6QI8gXYvwGdkQ5XprEr(xSliPNkHn8N, new EventHandler(yRkiPG1128h));
	}

	private void tFkiPHxitrT(object P_0, EventArgs P_1)
	{
		xSliPNkHn8N.LocationChanged += yRkiPG1128h;
		TAHiPf532vT();
	}

	private void TAHiPf532vT()
	{
		Screen screen = hXMiPvrOQ52(xSliPNkHn8N);
		FrameworkElement frameworkElement = yvhie3XYBWuwXsGAN13c(this) as FrameworkElement;
		int num;
		if (frameworkElement == null)
		{
			frameworkElement = base.Child as FrameworkElement;
			num = 8;
			if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_df0a40d144cf4cfbb9b3ae4d9199b671 == 0)
			{
				num = 9;
			}
			goto IL_0009;
		}
		goto IL_015f;
		IL_015f:
		System.Windows.Point? point = null;
		if (frameworkElement != null)
		{
			int num2 = 8;
			num = num2;
			goto IL_0009;
		}
		goto IL_00c1;
		IL_00c1:
		zX7kL9XYaVkcy01U1w0n(this, false);
		num = 8;
		if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_668c29c4a5854494b66fe0091e71ecb8 == 0)
		{
			num = 13;
		}
		goto IL_0009;
		IL_0009:
		Rectangle rectangle = default(Rectangle);
		double num5 = default(double);
		double num7 = default(double);
		bool flag = default(bool);
		bool flag2 = default(bool);
		double num3 = default(double);
		bool flag3 = default(bool);
		double num4 = default(double);
		while (true)
		{
			switch (num)
			{
			case 3:
				rectangle = screen.Bounds;
				num = 14;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_80afc7eb1a6e4a8ea5ca9a872ecf5362 != 0)
				{
					num = 3;
				}
				continue;
			case 11:
				break;
			case 7:
				return;
			case 9:
				goto end_IL_0009;
			case 4:
			{
				if (double.IsNaN(frameworkElement.Width))
				{
					num5 = wmQmcIXYldpbIJwE2eLX(frameworkElement);
				}
				double num6 = point.Value.X - (double)g2dlcOXY4LXBWfyrww6N(screen).X;
				rectangle = screen.WorkingArea;
				num7 = (double)rectangle.Width - (num6 + num5 + ((UIElement)F1BKtUXYDABhHCYDuH74(this)).DesiredSize.Width + 4.0);
				num = 17;
				continue;
			}
			case 1:
				goto IL_018e;
			case 12:
				flag = DesiredPlacement == UIKit.Core.Placement.Top;
				num = 11;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_5181c84710c64ff897e0d62573bc5717 != 0)
				{
					num = 15;
				}
				continue;
			case 8:
				if (PresentationSource.FromVisual(frameworkElement) == null)
				{
					goto IL_00c1;
				}
				goto case 19;
			case 13:
				flag2 = !point.HasValue;
				num = 2;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_0bd24d908e924c0b83abf9fb2f7c1f25 == 0)
				{
					num = 6;
				}
				continue;
			case 19:
				point = frameworkElement.PointToScreen(new System.Windows.Point(0.0, 0.0));
				goto case 13;
			case 14:
				num3 = (double)rectangle.Height - (point.Value.Y + dQZmeGXYNwKQqOD6GaCc(base.Child).Height + 4.0);
				num = 10;
				continue;
			case 6:
				if (flag2)
				{
					num = 18;
					continue;
				}
				break;
			default:
				if (flag3)
				{
					num = 2;
					continue;
				}
				goto case 12;
			case 15:
				if (flag)
				{
					num4 = point.Value.Y - ((UIElement)F1BKtUXYDABhHCYDuH74(this)).DesiredSize.Height - 4.0;
					num = 16;
					continue;
				}
				goto case 3;
			case 18:
				return;
			case 2:
			{
				double actualHeight = frameworkElement.ActualHeight;
				num = 8;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_e9984bb1541d41d58b47e3c8a388ab36 == 0)
				{
					num = 12;
				}
				continue;
			}
			case 5:
				return;
			case 17:
				RealPlacement = ((!(num7 < 0.0)) ? UIKit.Core.Placement.Right : UIKit.Core.Placement.Left);
				return;
			case 16:
				RealPlacement = ((num4 < 0.0) ? UIKit.Core.Placement.Bottom : UIKit.Core.Placement.Top);
				num = 7;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_e500693622c345f4b5a2910bf7d09298 != 0)
				{
					num = 3;
				}
				continue;
			case 10:
				RealPlacement = ((num3 < 0.0) ? UIKit.Core.Placement.Top : UIKit.Core.Placement.Bottom);
				num = 5;
				continue;
			}
			if (DesiredPlacement != UIKit.Core.Placement.Left)
			{
				if (DesiredPlacement == UIKit.Core.Placement.Right)
				{
					goto IL_018e;
				}
				double actualHeight = frameworkElement.Height;
				flag3 = PNHhteXYbUM2HQotBDbj(frameworkElement.Height);
				num = 0;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_0c51149f95a846678c44c1ff181aee24 != 0)
				{
					num = 0;
				}
				continue;
			}
			num = 0;
			if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_d8e6a87b8dc84e42a96070ff5524267e != 0)
			{
				num = 1;
			}
			continue;
			IL_018e:
			num5 = zk8y1WXYiCeoC4A7MbiO(frameworkElement);
			num = 4;
			continue;
			end_IL_0009:
			break;
		}
		goto IL_015f;
	}

	private void GPniP90FnhY(object P_0, RoutedEventArgs P_1)
	{
		xSliPNkHn8N = (Window)GyVs42XYk4mLl32dRgbg(this);
		bool flag = xSliPNkHn8N == null;
		int num = 1;
		if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_98790ccfa91e4cc4b8e56de14d056b9b != 0)
		{
			num = 1;
		}
		bool flag2 = default(bool);
		FrameworkElement frameworkElement = default(FrameworkElement);
		while (true)
		{
			switch (num)
			{
			case 4:
				return;
			case 3:
				if (flag2)
				{
					frameworkElement.SizeChanged += puPiPnwpG5B;
				}
				TAHiPf532vT();
				return;
			case 2:
				frameworkElement = base.Child as FrameworkElement;
				flag2 = frameworkElement != null;
				num = 3;
				continue;
			case 1:
				if (flag)
				{
					num = 4;
					continue;
				}
				break;
			}
			xSliPNkHn8N.Activated += io0iPBhjMlU;
			xSliPNkHn8N.Deactivated += d9GiPa9LvNg;
			xSliPNkHn8N.StateChanged += tiAiPi3yEKn;
			xSliPNkHn8N.LocationChanged += yRkiPG1128h;
			num = 1;
			if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_d0223d742fec4f149986da581d0284c4 == 0)
			{
				num = 2;
			}
		}
	}

	private void puPiPnwpG5B(object P_0, SizeChangedEventArgs P_1)
	{
		TAHiPf532vT();
	}

	private void yRkiPG1128h(object P_0, EventArgs P_1)
	{
		double horizontalOffset = base.HorizontalOffset;
		nHutHxXY1yVXI9qlGc4l(this, horizontalOffset + 1.0);
		base.HorizontalOffset = horizontalOffset;
		int num = 0;
		if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_5a3bf026df2e4752aeee32ca0b5dd9a8 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		TAHiPf532vT();
	}

	private void tuWiPYI0Mqp(object P_0, RoutedEventArgs P_1)
	{
		int num = 1;
		int num2 = num;
		bool flag = default(bool);
		FrameworkElement frameworkElement = default(FrameworkElement);
		while (true)
		{
			switch (num2)
			{
			case 4:
				if (flag)
				{
					goto case 5;
				}
				goto case 3;
			case 5:
				frameworkElement.SizeChanged -= puPiPnwpG5B;
				num2 = 3;
				break;
			case 6:
				xSliPNkHn8N.Deactivated -= d9GiPa9LvNg;
				xSliPNkHn8N.StateChanged -= tiAiPi3yEKn;
				return;
			case 2:
				return;
			default:
				sWZKZLXY5IIHUHvuUa82(this, new RoutedEventHandler(tuWiPYI0Mqp));
				frameworkElement = base.Child as FrameworkElement;
				flag = frameworkElement != null;
				num2 = 4;
				break;
			case 3:
				if (xSliPNkHn8N != null)
				{
					xSliPNkHn8N.LocationChanged -= yRkiPG1128h;
					xSliPNkHn8N.Activated -= io0iPBhjMlU;
					num2 = 6;
					break;
				}
				num2 = 2;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_b2da73a936724a80bf64a1fef17b1de8 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				base.Loaded -= GPniP90FnhY;
				num2 = 0;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_800979ef175f4570a283be4fa8173624 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private CustomPopupPlacement[] U3IiPomJNUD(System.Windows.Size P_0, System.Windows.Size P_1, System.Windows.Point P_2)
	{
		int num = 3;
		int num2 = num;
		CustomPopupPlacement customPopupPlacement = default(CustomPopupPlacement);
		CustomPopupPlacement customPopupPlacement2 = default(CustomPopupPlacement);
		Placement placement = default(Placement);
		while (true)
		{
			switch (num2)
			{
			case 6:
				customPopupPlacement = new CustomPopupPlacement(new System.Windows.Point(P_1.Width + 4.0, (0.0 - P_0.Height) / 2.0 + P_1.Height / 2.0), PopupPrimaryAxis.Vertical);
				num2 = 2;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_dae2a0acfd5b428ba7eb3ad10fcbb7da != 0)
				{
					num2 = 8;
				}
				break;
			case 4:
				goto IL_00c2;
			case 3:
				customPopupPlacement = default(CustomPopupPlacement);
				num2 = 2;
				break;
			default:
				goto IL_0143;
			case 8:
				customPopupPlacement2 = new CustomPopupPlacement(new System.Windows.Point(0.0 - P_0.Width, (0.0 - P_0.Height) / 2.0 + P_1.Height / 2.0), PopupPrimaryAxis.Horizontal);
				goto IL_0143;
			case 2:
				customPopupPlacement2 = default(CustomPopupPlacement);
				placement = DesiredPlacement;
				num2 = 9;
				break;
			case 7:
				customPopupPlacement2 = new CustomPopupPlacement(new System.Windows.Point(P_1.Width + 4.0, (0.0 - P_0.Height) / 2.0 + P_1.Height / 2.0), PopupPrimaryAxis.Vertical);
				num2 = 4;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_0bd24d908e924c0b83abf9fb2f7c1f25 == 0)
				{
					num2 = 5;
				}
				break;
			case 9:
				switch (placement)
				{
				case UIKit.Core.Placement.Right:
					break;
				case UIKit.Core.Placement.Top:
					goto IL_00c2;
				default:
					goto IL_0143;
				case UIKit.Core.Placement.Left:
					goto IL_0193;
				case UIKit.Core.Placement.Bottom:
					goto IL_02e6;
				}
				goto case 6;
			case 1:
				goto IL_02e6;
				IL_02e6:
				customPopupPlacement = new CustomPopupPlacement(new System.Windows.Point((0.0 - (P_0.Width - P_1.Width)) / 2.0, P_1.Height + 4.0), PopupPrimaryAxis.Vertical);
				customPopupPlacement2 = new CustomPopupPlacement(new System.Windows.Point((0.0 - (P_0.Width - P_1.Width)) / 2.0, 0.0 - P_0.Height - 4.0), PopupPrimaryAxis.Horizontal);
				goto IL_0143;
				IL_0193:
				customPopupPlacement = new CustomPopupPlacement(new System.Windows.Point(0.0 - P_0.Width, (0.0 - P_0.Height) / 2.0 + P_1.Height / 2.0), PopupPrimaryAxis.Horizontal);
				num2 = 7;
				break;
				IL_0143:
				return new CustomPopupPlacement[2] { customPopupPlacement, customPopupPlacement2 };
				IL_00c2:
				customPopupPlacement = new CustomPopupPlacement(new System.Windows.Point((0.0 - (P_0.Width - P_1.Width)) / 2.0, 0.0 - P_0.Height - 4.0), PopupPrimaryAxis.Horizontal);
				customPopupPlacement2 = new CustomPopupPlacement(new System.Windows.Point((0.0 - (P_0.Width - P_1.Width)) / 2.0, P_1.Height + 4.0), PopupPrimaryAxis.Vertical);
				num2 = 0;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_5fd60ba0c8914ea3b4e84bce73b6a8b9 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private Screen hXMiPvrOQ52(Window P_0)
	{
		WindowInteropHelper windowInteropHelper = new WindowInteropHelper(P_0);
		return (Screen)EuZLT8XYS3xgHr5WgLX8(windowInteropHelper.Handle);
	}

	private void io0iPBhjMlU(object P_0, EventArgs P_1)
	{
		base.IsOpen = U1IiPkmc1j7;
	}

	private void d9GiPa9LvNg(object P_0, EventArgs P_1)
	{
		U1IiPkmc1j7 = base.IsOpen;
		base.IsOpen = false;
	}

	private void tiAiPi3yEKn(object P_0, EventArgs P_1)
	{
		if (xSliPNkHn8N.WindowState == WindowState.Minimized)
		{
			base.IsOpen = false;
			return;
		}
		while (true)
		{
			zX7kL9XYaVkcy01U1w0n(this, U1IiPkmc1j7);
			int num = 1;
			if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_6d9219368a864c2d9c7ba55f24c4b4c6 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 1:
				return;
			}
		}
	}

	static Popup()
	{
		OQNZEtsP93U56NxbHlup.tMIsP5FCtWb();
		AQOYroXYxgNUWi7AJ7db();
		int num = 1;
		if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_d5cf9ea404004c488c3b0bf4ea818b28 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				i88iP5U1EH0 = DependencyProperty.Register(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(0x42D899B5 ^ 0x42D89CB9), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554460)), wbR6aJXYsGyaQYfuDlpv(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554461)));
				return;
			case 1:
				waA2IsXYLacYpY0uv7mv();
				QgkiP1ks06h = DependencyProperty.Register(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(-530053095 ^ -530051855), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554460)), Type.GetTypeFromHandle(AwVRyKXYep1j9rPouAPX(33554461)), new PropertyMetadata(UIKit.Core.Placement.Right));
				num = 0;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_6d9219368a864c2d9c7ba55f24c4b4c6 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	internal static void i3PPcRXYnCXsYqcuF4IG(object P_0, object P_1)
	{
		((FrameworkElement)P_0).Unloaded += (RoutedEventHandler)P_1;
	}

	internal static void vtja6NXYGTtJk3AOTypx(object P_0, object P_1)
	{
		((System.Windows.Controls.Primitives.Popup)P_0).Opened += (EventHandler)P_1;
	}

	internal static bool WJdUplXYfK7KCgLw8sWf()
	{
		return lQnbbuXYHbelF9qSyAuy == null;
	}

	internal static Popup q6xyuQXY9yyiZxjGTPX0()
	{
		return lQnbbuXYHbelF9qSyAuy;
	}

	internal static object RNgqJgXYYUBJHM3qAETc(object P_0, object P_1)
	{
		return ((DependencyObject)P_0).GetValue((DependencyProperty)P_1);
	}

	internal static void Ws6xokXYocXojbwbgKFG(object P_0, object P_1, object P_2)
	{
		((DependencyObject)P_0).SetValue((DependencyProperty)P_1, P_2);
	}

	internal static void U6QI8gXYvwGdkQ5XprEr(object P_0, object P_1)
	{
		((Window)P_0).LocationChanged -= (EventHandler)P_1;
	}

	internal static object yvhie3XYBWuwXsGAN13c(object P_0)
	{
		return ((System.Windows.Controls.Primitives.Popup)P_0).PlacementTarget;
	}

	internal static void zX7kL9XYaVkcy01U1w0n(object P_0, bool P_1)
	{
		((System.Windows.Controls.Primitives.Popup)P_0).IsOpen = P_1;
	}

	internal static double zk8y1WXYiCeoC4A7MbiO(object P_0)
	{
		return ((FrameworkElement)P_0).Width;
	}

	internal static double wmQmcIXYldpbIJwE2eLX(object P_0)
	{
		return ((FrameworkElement)P_0).ActualWidth;
	}

	internal static Rectangle g2dlcOXY4LXBWfyrww6N(object P_0)
	{
		return ((Screen)P_0).Bounds;
	}

	internal static object F1BKtUXYDABhHCYDuH74(object P_0)
	{
		return ((System.Windows.Controls.Primitives.Popup)P_0).Child;
	}

	internal static bool PNHhteXYbUM2HQotBDbj(double P_0)
	{
		return double.IsNaN(P_0);
	}

	internal static System.Windows.Size dQZmeGXYNwKQqOD6GaCc(object P_0)
	{
		return ((UIElement)P_0).DesiredSize;
	}

	internal static object GyVs42XYk4mLl32dRgbg(object P_0)
	{
		return Window.GetWindow((DependencyObject)P_0);
	}

	internal static void nHutHxXY1yVXI9qlGc4l(object P_0, double P_1)
	{
		((System.Windows.Controls.Primitives.Popup)P_0).HorizontalOffset = P_1;
	}

	internal static void sWZKZLXY5IIHUHvuUa82(object P_0, object P_1)
	{
		((FrameworkElement)P_0).Unloaded -= (RoutedEventHandler)P_1;
	}

	internal static object EuZLT8XYS3xgHr5WgLX8(IntPtr P_0)
	{
		return Screen.FromHandle(P_0);
	}

	internal static void AQOYroXYxgNUWi7AJ7db()
	{
		HandHqsFGhqpm8Ixav52.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static void waA2IsXYLacYpY0uv7mv()
	{
		RwEN8CsJudtSqX6iB0vv.D4wX52wcDDu();
	}

	internal static RuntimeTypeHandle AwVRyKXYep1j9rPouAPX(int token)
	{
		return H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(token);
	}

	internal static Type wbR6aJXYsGyaQYfuDlpv(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}
}
