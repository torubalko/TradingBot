using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;
using ActiproSoftware.Windows.Media;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Controls.Popups;

internal static class PopupManager
{
	private static List<IPopupAnchor> LZe;

	private static PopupManager TbS;

	private static void LZp(FrameworkElement P_0, bool P_1)
	{
		if (P_0 == null)
		{
			return;
		}
		if (P_1)
		{
			P_0.KeyDown += XZ9;
			P_0.LostMouseCapture += HZh;
			P_0.PreviewKeyUp += WZm;
			P_0.AddHandler(Mouse.PreviewMouseDownOutsideCapturedElementEvent, new MouseButtonEventHandler(UZJ));
			return;
		}
		P_0.KeyDown -= XZ9;
		P_0.LostMouseCapture -= HZh;
		P_0.PreviewKeyUp -= WZm;
		P_0.RemoveHandler(Mouse.PreviewMouseDownOutsideCapturedElementEvent, new MouseButtonEventHandler(UZJ));
		int num = 0;
		if (!ebB())
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

	private static void RZb(IPopupAnchor P_0)
	{
		FrameworkElement frameworkElement = CZ3(P_0);
		if (frameworkElement != null)
		{
			LZp(frameworkElement, _0020: false);
			if (!P_0.PopupStaysOpen && Mouse.Captured == frameworkElement)
			{
				if (LZe.Count > 0)
				{
					Mouse.Capture(CZ3(TZw()), CaptureMode.SubTree);
				}
				else
				{
					Mouse.Capture(null);
				}
			}
		}
		if (P_0.IsPopupOpen)
		{
			P_0.IsPopupOpen = false;
		}
	}

	private static bool WZy()
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
				case 1:
					break;
				default:
				{
					if (!flag)
					{
						return false;
					}
					IPopupAnchor popupAnchor = LZe[0];
					LZe.RemoveAt(0);
					RZb(popupAnchor);
					return true;
				}
				}
				flag = LZe.Count > 0;
				num2 = 0;
			}
			while (rbA() == null);
		}
	}

	private static DependencyObject JZf(DependencyObject P_0)
	{
		if (P_0 != null)
		{
			if (P_0.GetType().Name == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(121944) && ((FrameworkElement)P_0).Parent is Popup popup)
			{
				if (popup.Parent == null)
				{
					return popup.TemplatedParent ?? popup.PlacementTarget;
				}
				return popup.Parent;
			}
			if (VisualTreeHelperExtended.IsVisual(P_0))
			{
				DependencyObject parent = VisualTreeHelper.GetParent(P_0);
				if (parent != null)
				{
					return parent;
				}
			}
			return LogicalTreeHelper.GetParent(P_0);
		}
		return null;
	}

	private static IPopupAnchor HZi(DependencyObject P_0)
	{
		while (P_0 != null)
		{
			P_0 = JZf(P_0);
			if (P_0 is IPopupAnchor result)
			{
				return result;
			}
		}
		return null;
	}

	private static IPopupAnchor KZS(FrameworkElement P_0)
	{
		IPopupAnchor popupAnchor = P_0 as IPopupAnchor;
		if (popupAnchor == null && P_0 != null)
		{
			popupAnchor = P_0.TemplatedParent as IPopupAnchor;
		}
		return popupAnchor;
	}

	private static FrameworkElement CZ3(IPopupAnchor P_0)
	{
		return P_0 as FrameworkElement;
	}

	private static bool jZt(DependencyObject P_0, DependencyObject P_1)
	{
		while (P_1 != null)
		{
			P_1 = JZf(P_1);
			if (P_0 == P_1)
			{
				return true;
			}
		}
		return false;
	}

	private static void UZJ(object P_0, MouseButtonEventArgs P_1)
	{
		IPopupAnchor popupAnchor = KZS(P_0 as FrameworkElement);
		if (popupAnchor != null)
		{
			ClosePopup(popupAnchor);
		}
	}

	private static void XZ9(object P_0, KeyEventArgs P_1)
	{
		if (P_1 != null && !P_1.Handled)
		{
			IPopupAnchor popupAnchor = KZS(P_0 as FrameworkElement);
			if (popupAnchor != null)
			{
				ProcessKeyDown(popupAnchor, P_1);
			}
		}
	}

	private static void HZh(object P_0, MouseEventArgs P_1)
	{
		FrameworkElement frameworkElement = P_0 as FrameworkElement;
		if (P_1 == null || frameworkElement == null || Mouse.Captured == frameworkElement)
		{
			return;
		}
		IPopupAnchor popupAnchor = KZS(frameworkElement);
		if (popupAnchor == null)
		{
			return;
		}
		IInputElement captured = Mouse.Captured;
		if (P_1.OriginalSource == frameworkElement)
		{
			if (captured == null)
			{
				if (frameworkElement.IsKeyboardFocusWithin)
				{
					Mouse.Capture(frameworkElement, CaptureMode.SubTree);
				}
				else
				{
					ClosePopup(popupAnchor);
				}
			}
			else if (captured != popupAnchor && !jZt(frameworkElement, captured as DependencyObject))
			{
				ClosePopup(popupAnchor);
			}
			else if (captured == popupAnchor)
			{
				Mouse.Capture(frameworkElement, CaptureMode.SubTree);
			}
		}
		else if (jZt(frameworkElement, P_1.OriginalSource as DependencyObject))
		{
			if (popupAnchor.IsPopupOpen && captured == null)
			{
				Mouse.Capture(frameworkElement, CaptureMode.SubTree);
				P_1.Handled = true;
			}
		}
		else
		{
			ClosePopup(popupAnchor);
		}
	}

	private static void WZm(object P_0, KeyEventArgs P_1)
	{
		if (P_1 != null && !P_1.Handled && P_1.Key == Key.System)
		{
			Key systemKey = P_1.SystemKey;
			Key key = systemKey;
			if (key == Key.F10 || (uint)(key - 120) <= 1u)
			{
				FocusPopupAnchor(TZw());
				CloseAllPopups();
			}
		}
	}

	[SpecialName]
	private static IPopupAnchor TZw()
	{
		return (LZe.Count > 0) ? LZe[LZe.Count - 1] : null;
	}

	[SpecialName]
	private static IPopupAnchor MZu()
	{
		return (LZe.Count > 0) ? LZe[0] : null;
	}

	public static void CloseAllPopups()
	{
		while (WZy())
		{
		}
	}

	public static bool ClosePopup(IPopupAnchor popupAnchor)
	{
		if (popupAnchor == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(121966));
		}
		bool flag = !LZe.Contains(popupAnchor);
		int num = 1;
		if (!ebB())
		{
			goto IL_0005;
		}
		goto IL_0009;
		IL_0009:
		bool result = default(bool);
		do
		{
			switch (num)
			{
			case 1:
				{
					if (flag)
					{
						RZb(popupAnchor);
						result = false;
						break;
					}
					while (LZe.Count > 0)
					{
						bool flag2 = MZu() == popupAnchor;
						if (!WZy())
						{
							goto IL_001b;
						}
						if (!flag2)
						{
							continue;
						}
						goto IL_011e;
					}
					goto IL_00e7;
				}
				IL_001b:
				result = false;
				break;
				IL_011e:
				result = true;
				break;
			}
			return result;
			IL_00e7:
			result = false;
			num = 0;
		}
		while (rbA() == null);
		goto IL_0005;
		IL_0005:
		int num2 = default(int);
		num = num2;
		goto IL_0009;
	}

	public static bool FocusPopupAnchor(IPopupAnchor popupAnchor)
	{
		if (!(popupAnchor is UIElement uIElement))
		{
			return false;
		}
		return uIElement.Focus();
	}

	public static bool OpenPopup(IPopupAnchor popupAnchor)
	{
		if (popupAnchor == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(121966));
		}
		FrameworkElement frameworkElement = CZ3(popupAnchor);
		if (frameworkElement != null)
		{
			int num = LZe.IndexOf(popupAnchor);
			if (num != -1)
			{
				if (num > 0)
				{
					ClosePopup(LZe[num - 1]);
				}
				return true;
			}
			IPopupAnchor popupAnchor2 = HZi(popupAnchor as DependencyObject);
			while (popupAnchor2 != null && !popupAnchor2.IsPopupOpen)
			{
				popupAnchor2 = HZi(popupAnchor2 as DependencyObject);
			}
			if (popupAnchor2 != null)
			{
				while (LZe.Count > 0 && MZu() != popupAnchor2)
				{
					WZy();
				}
			}
			else
			{
				CloseAllPopups();
			}
			if (!popupAnchor.PopupStaysOpen && LZe.Count == 0)
			{
				Mouse.Capture(frameworkElement, CaptureMode.SubTree);
			}
			LZe.Insert(0, popupAnchor);
			if (!popupAnchor.IsPopupOpen)
			{
				popupAnchor.IsPopupOpen = true;
			}
			LZp(frameworkElement, _0020: true);
			return true;
		}
		return false;
	}

	public static void ProcessKeyDown(IPopupAnchor popupAnchor, KeyEventArgs e)
	{
		if (popupAnchor == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(121966));
		}
		if (e == null || e.Handled)
		{
			return;
		}
		bool? flag = null;
		switch (e.Key)
		{
		case Key.System:
			switch (e.SystemKey)
			{
			case Key.Down:
				if (popupAnchor.SupportsAltDownToOpen && Keyboard.Modifiers == ModifierKeys.Alt)
				{
					flag = true;
				}
				break;
			case Key.Up:
				if (Keyboard.Modifiers == ModifierKeys.Alt)
				{
					flag = false;
				}
				break;
			}
			break;
		case Key.Escape:
			flag = false;
			break;
		}
		if (flag.HasValue)
		{
			e.Handled = true;
			if (flag == true)
			{
				OpenPopup(popupAnchor);
				return;
			}
			FocusPopupAnchor(popupAnchor);
			ClosePopup(popupAnchor);
		}
	}

	static PopupManager()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		LZe = new List<IPopupAnchor>();
	}

	internal static bool ebB()
	{
		return TbS == null;
	}

	internal static PopupManager rbA()
	{
		return TbS;
	}
}
