using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Threading;
using ActiproSoftware.Windows;
using ActiproSoftware.Windows.Controls.Docking;
using ActiproSoftware.Windows.Media;

namespace ActiproSoftware.Internal;

internal static class cP
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass7_0
	{
		public UIElement N9M;

		public FrameworkElement Q9v;

		public int M97;

		private static _003C_003Ec__DisplayClass7_0 XMt;

		public _003C_003Ec__DisplayClass7_0()
		{
			IVH.CecNqz();
			base._002Ector();
		}

		internal void j9l()
		{
			if (M97 == YlH)
			{
				N9M.UpdateLayout();
				N9M = nlp(N9M);
				if (!YlP(N9M) && Q9v != null)
				{
					YlP(Q9v);
				}
			}
		}

		internal static bool uMp()
		{
			return XMt == null;
		}

		internal static _003C_003Ec__DisplayClass7_0 QM4()
		{
			return XMt;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass8_0
	{
		public DependencyObject y9S;

		internal static _003C_003Ec__DisplayClass8_0 LM2;

		public _003C_003Ec__DisplayClass8_0()
		{
			IVH.CecNqz();
			base._002Ector();
		}

		internal VisualDescendantFilterBehavior X9R(DependencyObject childObj)
		{
			if (FocusManager.GetFocusScope(childObj) != y9S)
			{
				return VisualDescendantFilterBehavior.ContinueSkipSelfAndChildren;
			}
			return VisualDescendantFilterBehavior.Continue;
		}

		internal static bool pM6()
		{
			return LM2 == null;
		}

		internal static _003C_003Ec__DisplayClass8_0 BMW()
		{
			return LM2;
		}
	}

	private static int YlH;

	private static DependencyProperty sl0;

	private static bool elh;

	internal static cP lYm;

	[SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
	private static UIElement nlp(UIElement P_0)
	{
		if (P_0 != null && VisualTreeHelper.GetParent(P_0) is Panel reference && VisualTreeHelper.GetParent(reference) is ItemsPresenter source)
		{
			ItemsControl ancestor = VisualTreeHelperExtended.GetAncestor<ItemsControl>(source);
			if (ancestor != null)
			{
				if (ancestor is Selector)
				{
					if (!Selector.GetIsSelected(P_0))
					{
						P_0 = ancestor;
					}
				}
				else
				{
					try
					{
						PropertyInfo property = ancestor.GetType().GetProperty(vVK.ssH(23204), BindingFlags.Instance | BindingFlags.Public);
						if (property != null && property.GetValue(ancestor, null) is IEnumerable source2)
						{
							object value = ((P_0 is ContentControl contentControl) ? contentControl.Content : null) ?? P_0;
							if (!source2.OfType<object>().Contains(value))
							{
								P_0 = ancestor;
							}
						}
					}
					catch
					{
					}
				}
			}
		}
		return P_0;
	}

	private static bool yls(UIElement P_0, FrameworkElement P_1)
	{
		int num = 1;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					throw new ArgumentNullException(vVK.ssH(19944));
				case 1:
					if (P_0 != null)
					{
						UIElement uIElement = klU(P_0);
						bool flag = false;
						flag = ((!(uIElement is DockingWindow dockingWindow)) ? ((!(uIElement is DockHost dockHost)) ? UlV(uIElement, P_1) : Qlq(dockHost)) : zlF(dockingWindow));
						if (!flag && uIElement != P_0 && P_0.Focusable)
						{
							flag = elb(P_0);
						}
						return flag;
					}
					num2 = 0;
					if (xYB() == null)
					{
						break;
					}
					goto end_IL_0012;
				}
				continue;
				end_IL_0012:
				break;
			}
		}
	}

	private static bool Qlq(DockHost P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(vVK.ssH(9182));
		}
		if (!NlZ(P_0))
		{
			IList<b4<DockingWindow>> list = pL.Mxl<DockingWindow>(P_0, null);
			if (list != null)
			{
				DockingWindow dockingWindow = (from r in list
					select r.dx3() into w
					orderby w.LastActiveDateTime descending
					select w).FirstOrDefault();
				if (dockingWindow != null)
				{
					return zlF(dockingWindow);
				}
			}
			return false;
		}
		return true;
	}

	private static bool zlF(DockingWindow P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(vVK.ssH(9098));
		}
		UIElement uIElement = P_0.Hkc();
		if (uIElement != null && P_0 != uIElement && P_0.IsAncestorOf(uIElement))
		{
			uIElement = nlp(uIElement);
			if (uIElement != null && uIElement.Visibility == Visibility.Visible)
			{
				return yls(uIElement, P_0);
			}
		}
		if (P_0.Content is UIElement uIElement2)
		{
			return yls(uIElement2, P_0);
		}
		return UlV(P_0, null);
	}

	private static bool UlV(UIElement P_0, FrameworkElement P_1)
	{
		_003C_003Ec__DisplayClass7_0 CS_0024_003C_003E8__locals16 = new _003C_003Ec__DisplayClass7_0();
		CS_0024_003C_003E8__locals16.N9M = P_0;
		CS_0024_003C_003E8__locals16.Q9v = P_1;
		if (CS_0024_003C_003E8__locals16.N9M != null)
		{
			YlH = ((YlH <= 1000000) ? (YlH + 1) : 0);
			bool flag = CS_0024_003C_003E8__locals16.N9M is HwndHost;
			if (!NlZ(CS_0024_003C_003E8__locals16.N9M))
			{
				if (flag || !YlP(CS_0024_003C_003E8__locals16.N9M))
				{
					CS_0024_003C_003E8__locals16.M97 = YlH;
					CS_0024_003C_003E8__locals16.N9M.Dispatcher.BeginInvoke(DispatcherPriority.Send, (Action)delegate
					{
						if (CS_0024_003C_003E8__locals16.M97 == YlH)
						{
							CS_0024_003C_003E8__locals16.N9M.UpdateLayout();
							CS_0024_003C_003E8__locals16.N9M = nlp(CS_0024_003C_003E8__locals16.N9M);
							if (!YlP(CS_0024_003C_003E8__locals16.N9M) && CS_0024_003C_003E8__locals16.Q9v != null)
							{
								YlP(CS_0024_003C_003E8__locals16.Q9v);
							}
						}
					});
					return false;
				}
			}
			else if (flag)
			{
				int num = 0;
				if (xYB() != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				Mlc(CS_0024_003C_003E8__locals16.N9M);
			}
			return true;
		}
		throw new ArgumentNullException(vVK.ssH(19944));
	}

	private static bool YlP(UIElement P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(vVK.ssH(19944));
		}
		Control control = P_0 as Control;
		if (control != null || !(P_0 is HwndHost))
		{
			_003C_003Ec__DisplayClass8_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass8_0();
			if (control != null && (control.IsTabStop || control is TreeViewItem) && elb(control))
			{
				return true;
			}
			if (SecurityHelper.IsFullTrust && control is ItemsControl itemsControl && Flf(itemsControl) is Control { IsTabStop: not false } control2 && elb(control2))
			{
				return true;
			}
			CS_0024_003C_003E8__locals2.y9S = FocusManager.GetFocusScope(P_0);
			UIElement firstFocusableDescendant = VisualTreeHelperExtended.GetFirstFocusableDescendant(P_0, (DependencyObject childObj) => (FocusManager.GetFocusScope(childObj) == CS_0024_003C_003E8__locals2.y9S) ? VisualDescendantFilterBehavior.Continue : VisualDescendantFilterBehavior.ContinueSkipSelfAndChildren);
			if (firstFocusableDescendant != null && elb(firstFocusableDescendant))
			{
				return true;
			}
			if (P_0.MoveFocus(new TraversalRequest(FocusNavigationDirection.First)))
			{
				return true;
			}
		}
		if ((control == null || !control.IsTabStop) && elb(P_0))
		{
			return true;
		}
		return false;
	}

	[SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
	private static FrameworkElement Flf(FrameworkElement P_0)
	{
		if (P_0 != null)
		{
			if (!elh)
			{
				try
				{
					FieldInfo field = typeof(KeyboardNavigation).GetField(vVK.ssH(23234), BindingFlags.Static | BindingFlags.NonPublic);
					if (field != null)
					{
						sl0 = field.GetValue(null) as DependencyProperty;
					}
				}
				catch
				{
				}
				finally
				{
					elh = true;
				}
			}
			if (sl0 != null && P_0.GetValue(sl0) is WeakReference { IsAlive: not false } weakReference)
			{
				return weakReference.Target as FrameworkElement;
			}
		}
		return null;
	}

	private static UIElement klU(UIElement P_0)
	{
		if (P_0 is WindowControl windowControl)
		{
			if (windowControl.Content is UIElement uIElement)
			{
				P_0 = uIElement;
			}
		}
		else if (P_0 is ContentPresenter { Content: UIElement content })
		{
			P_0 = content;
		}
		return P_0;
	}

	private static void Mlc(UIElement P_0)
	{
		if (P_0 == null)
		{
			return;
		}
		DockingWindow ancestor = VisualTreeHelperExtended.GetAncestor<DockingWindow>(P_0);
		if (ancestor != null)
		{
			G0 g = ancestor.MkZ();
			if (g != null && !g.IsActive)
			{
				IlA(g);
			}
		}
	}

	public static bool Dl4(UIElement P_0)
	{
		return yls(P_0, null);
	}

	public static object hlj()
	{
		return Keyboard.FocusedElement;
	}

	public static bool NlZ(UIElement P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(vVK.ssH(19944));
		}
		return P_0.IsKeyboardFocusWithin;
	}

	public static bool elb(UIElement P_0)
	{
		bool flag = P_0.Focus() || P_0.IsKeyboardFocusWithin;
		if (!flag && P_0 is HwndHost hwndHost)
		{
			flag = InteropFocusTracking.GmZ() == hwndHost;
			if (!flag && P_0.IsVisible)
			{
				IKeyboardInputSink keyboardInputSink = hwndHost;
				if (keyboardInputSink != null)
				{
					keyboardInputSink.TabInto(new TraversalRequest(FocusNavigationDirection.First));
					flag = InteropFocusTracking.GmZ() == hwndHost;
				}
			}
		}
		return flag;
	}

	public static void IlA(G0 P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(vVK.ssH(9202));
		}
		DockSite dockSite = P_0.DockHost?.DockSite;
		bool flag = P_0 is UIElement uIElement && uIElement.IsKeyboardFocusWithin;
		if (!flag)
		{
			flag = dockSite != null && InteropFocusTracking.amq(P_0);
		}
		if (dockSite != null)
		{
			dockSite.s1M(P_0, flag);
		}
		else
		{
			P_0.IsActive = flag;
		}
	}

	internal static bool iYo()
	{
		return lYm == null;
	}

	internal static cP xYB()
	{
		return lYm;
	}
}
