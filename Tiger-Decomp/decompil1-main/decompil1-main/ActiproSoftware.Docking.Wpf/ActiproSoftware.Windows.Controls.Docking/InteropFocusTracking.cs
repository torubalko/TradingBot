using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Media;

namespace ActiproSoftware.Windows.Controls.Docking;

public static class InteropFocusTracking
{
	private static WeakReference tmH;

	private static List<WeakReference> om0;

	public static readonly DependencyProperty IsEnabledProperty;

	internal static InteropFocusTracking w1u;

	internal static void pm6(DockingWindow P_0)
	{
		HwndHost hwndHost = GmZ();
		if (hwndHost == null)
		{
			return;
		}
		DockingWindow dockingWindow = Jm9(hwndHost);
		if (dockingWindow == null || dockingWindow == P_0)
		{
			return;
		}
		G0 g = dockingWindow.MkZ();
		if (g != null)
		{
			Ymb(null);
			cP.IlA(g);
			int num = 0;
			if (!K1y())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}
	}

	private static DockingWindow Jm9(HwndHost P_0)
	{
		FrameworkElement frameworkElement = P_0.Parent as FrameworkElement;
		if (frameworkElement == null)
		{
			frameworkElement = VisualTreeHelper.GetParent(P_0) as FrameworkElement;
		}
		int num2 = default(int);
		while (frameworkElement != null)
		{
			if (frameworkElement is DockingWindow result)
			{
				return result;
			}
			FrameworkElement frameworkElement2 = frameworkElement.Parent as FrameworkElement;
			if (frameworkElement2 == null)
			{
				frameworkElement2 = VisualTreeHelper.GetParent(frameworkElement) as FrameworkElement;
				int num = 0;
				if (L1V() != null)
				{
					num = num2;
				}
				switch (num)
				{
				}
			}
			frameworkElement = frameworkElement2;
		}
		return null;
	}

	[SpecialName]
	internal static HwndHost GmZ()
	{
		if (tmH != null && !tmH.IsAlive)
		{
			tmH = null;
		}
		if (tmH != null)
		{
			return tmH.Target as HwndHost;
		}
		return null;
	}

	[SpecialName]
	internal static void Ymb(HwndHost value)
	{
		if (value != null)
		{
			tmH = new WeakReference(value);
		}
		else
		{
			tmH = null;
		}
	}

	private static HwndHost emY(IntPtr P_0)
	{
		int num = om0.Count - 1;
		HwndHost hwndHost;
		int num3 = default(int);
		while (true)
		{
			if (num >= 0)
			{
				WeakReference weakReference = om0[num];
				if (weakReference != null && weakReference.IsAlive)
				{
					hwndHost = weakReference.Target as HwndHost;
					if (hwndHost != null && hwndHost.Handle == P_0)
					{
						break;
					}
				}
				else
				{
					om0.RemoveAt(num);
				}
				num--;
				int num2 = 0;
				if (L1V() != null)
				{
					num2 = num3;
				}
				switch (num2)
				{
				}
				continue;
			}
			return null;
		}
		return hwndHost;
	}

	private static WeakReference hmp(HwndHost P_0)
	{
		int num = om0.Count - 1;
		WeakReference weakReference;
		int num3 = default(int);
		while (true)
		{
			if (num < 0)
			{
				return null;
			}
			weakReference = om0[num];
			if (weakReference == null || !weakReference.IsAlive)
			{
				om0.RemoveAt(num);
				int num2 = 0;
				if (L1V() != null)
				{
					num2 = num3;
				}
				switch (num2)
				{
				}
			}
			else if (weakReference.Target == P_0)
			{
				break;
			}
			num--;
		}
		return weakReference;
	}

	private static bool Ums(HwndHost P_0)
	{
		if (!P_0.IsFocused || !(P_0.GetType().Name != vVK.ssH(15278)))
		{
			if (P_0 != null && ((IKeyboardInputSink)P_0).HasFocusWithin())
			{
				return true;
			}
			return false;
		}
		return true;
	}

	internal static bool amq(G0 P_0)
	{
		HwndHost hwndHost = GmZ();
		DockingWindow dockingWindow;
		int num;
		if (hwndHost != null)
		{
			if (!Ums(hwndHost))
			{
				Ymb(null);
			}
			else
			{
				dockingWindow = Jm9(hwndHost);
				if (dockingWindow != null)
				{
					num = 1;
					if (!K1y())
					{
						goto IL_0005;
					}
					goto IL_0009;
				}
			}
		}
		goto IL_0160;
		IL_0160:
		return false;
		IL_0009:
		DockHost dockHost2 = default(DockHost);
		DockHost dockHost = default(DockHost);
		while (true)
		{
			switch (num)
			{
			default:
			{
				if (dockHost2 == null || dockHost == dockHost2)
				{
					break;
				}
				DockSite dockSite = dockHost.DockSite;
				DockSite dockSite2 = dockHost2.DockSite;
				if (dockSite != null && dockSite2 != null && dockSite != dockSite2)
				{
					DockingWindow ancestor = VisualTreeHelperExtended.GetAncestor<DockingWindow>(dockHost);
					if (ancestor != null && ancestor.MkZ() == P_0)
					{
						return true;
					}
				}
				break;
			}
			case 1:
			{
				G0 g = dockingWindow.MkZ();
				if (g == P_0)
				{
					return true;
				}
				if (g == null || P_0 == null)
				{
					break;
				}
				dockHost = g.DockHost;
				dockHost2 = P_0.DockHost;
				if (dockHost == null)
				{
					break;
				}
				goto IL_0072;
			}
			}
			break;
			IL_0072:
			num = 0;
			if (L1V() == null)
			{
				continue;
			}
			goto IL_0005;
		}
		goto IL_0160;
		IL_0005:
		int num2 = default(int);
		num = num2;
		goto IL_0009;
	}

	private static void imF(object P_0, RoutedEventArgs P_1)
	{
		if (P_0 is HwndHost hwndHost)
		{
			cmc(hwndHost, _0020: false);
		}
	}

	private static void WmV(object P_0, RoutedEventArgs P_1)
	{
		if (!(P_0 is HwndHost hwndHost))
		{
			return;
		}
		DockingWindow dockingWindow = Jm9(hwndHost);
		if (dockingWindow != null)
		{
			G0 g = dockingWindow.MkZ();
			if (g != null)
			{
				cP.IlA(g);
			}
		}
	}

	private static void jmP(object P_0, KeyEventArgs P_1)
	{
		if (P_1 != null && Keyboard.FocusedElement is StandardSwitcher standardSwitcher)
		{
			standardSwitcher.urh();
		}
	}

	private static IntPtr Emf(IntPtr P_0, int P_1, IntPtr P_2, IntPtr P_3, ref bool P_4)
	{
		if ((uint)(P_1 - 6) <= 1u || P_1 == 33)
		{
			HwndHost hwndHost = emY(P_0);
			if (hwndHost != null)
			{
				cmc(hwndHost, P_1 == 33);
			}
		}
		return IntPtr.Zero;
	}

	private static void DmU(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		if (P_0 is HwndHost hwndHost && P_1.OldValue != P_1.NewValue)
		{
			if (!true.Equals(P_1.NewValue))
			{
				ymj(hwndHost);
			}
			else
			{
				gm4(hwndHost);
			}
		}
	}

	private static void cmc(HwndHost P_0, bool P_1)
	{
		if (Ums(P_0))
		{
			Ymb(P_0);
		}
		DockingWindow dockingWindow = Jm9(P_0);
		if (dockingWindow == null)
		{
			return;
		}
		if (dockingWindow.DockSite != null && dockingWindow.DockSite.ActiveWindow != dockingWindow)
		{
			dockingWindow.DockSite.ActiveWindow = dockingWindow;
		}
		G0 g = dockingWindow.MkZ();
		for (int i = 0; i < 2; i++)
		{
			if (g == null)
			{
				continue;
			}
			cP.IlA(g);
			if (P_1)
			{
				DockSite dockSite = dockingWindow.DockSite;
				if (dockSite != null && dockSite.AutoHidePopupToolWindow != null && dockSite.AutoHidePopupToolWindow != dockingWindow)
				{
					dockSite.CCu(_0020: true);
				}
			}
			DockHost dockHost = g.DockHost;
			if (dockHost != null)
			{
				dockingWindow = VisualTreeHelperExtended.GetAncestor<DockingWindow>(dockHost);
				g = dockingWindow?.MkZ();
			}
			else
			{
				g = null;
			}
		}
	}

	private static void gm4(HwndHost P_0)
	{
		P_0.GotFocus += imF;
		P_0.LostFocus += WmV;
		P_0.KeyUp += jmP;
		P_0.MessageHook += Emf;
		if (om0 == null)
		{
			om0 = new List<WeakReference>();
		}
		if (hmp(P_0) == null)
		{
			om0.Add(new WeakReference(P_0));
		}
	}

	private static void ymj(HwndHost P_0)
	{
		P_0.GotFocus -= imF;
		P_0.LostFocus -= WmV;
		P_0.KeyUp -= jmP;
		P_0.MessageHook -= Emf;
		if (om0 != null)
		{
			WeakReference weakReference = hmp(P_0);
			if (weakReference != null)
			{
				om0.Remove(weakReference);
			}
		}
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static bool GetIsEnabled(HwndHost obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(vVK.ssH(15298));
		}
		return (bool)obj.GetValue(IsEnabledProperty);
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static void SetIsEnabled(HwndHost obj, bool value)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(vVK.ssH(15298));
		}
		obj.SetValue(IsEnabledProperty, value);
	}

	static InteropFocusTracking()
	{
		IVH.CecNqz();
		IsEnabledProperty = DependencyProperty.RegisterAttached(vVK.ssH(15308), typeof(bool), typeof(InteropFocusTracking), new PropertyMetadata(false, DmU));
	}

	internal static bool K1y()
	{
		return w1u == null;
	}

	internal static InteropFocusTracking L1V()
	{
		return w1u;
	}
}
