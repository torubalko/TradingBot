using System;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using bengxqsFHOBf5kWpcG0Y;
using gSJfigsFY1OGJ9yWyJhK;
using KvJdCOsJzwmqgaKKHKlv;
using lAZo0WsPn6tyQVhIALKn;

namespace UIKit.Core.Behaviours;

public class ContextMenuBehavior
{
	[CompilerGenerated]
	private sealed class fCfNoEl2kpHq06NGtW5K
	{
		public ContextMenu IYil2S8SxcB;

		public UIElement Elvl2xiF7sb;

		private static fCfNoEl2kpHq06NGtW5K eIDmQ1XikOZfigN6wO77;

		public fCfNoEl2kpHq06NGtW5K()
		{
			RwEN8CsJudtSqX6iB0vv.D4wX52wcDDu();
			base._002Ector();
		}

		internal CustomPopupPlacement[] fhel21eoRlo(Size popupSize, Size targetSize, Point offset)
		{
			// Found self-referencing delegate construction. Abort transformation to avoid stack overflow.
			ContextMenu contextMenu = IYil2S8SxcB;
			ska8cZXixGsuaaoLVIL8(contextMenu, (CustomPopupPlacementCallback)cKncWAXiSYANN9uc78Zw(contextMenu.CustomPopupPlacementCallback, new CustomPopupPlacementCallback(fhel21eoRlo)));
			HorizontalAlignment horizontalAlignment = GetHorizontalAlignment(Elvl2xiF7sb);
			HorizontalAlignment horizontalAlignment2 = horizontalAlignment;
			HorizontalAlignment horizontalAlignment3 = horizontalAlignment2;
			int num = 2;
			CustomPopupPlacement[] result = default(CustomPopupPlacement[]);
			HwndSource hwndSource = default(HwndSource);
			Matrix transformToDevice = default(Matrix);
			while (true)
			{
				int num2;
				switch (num)
				{
				case 7:
					offset.X = Elvl2xiF7sb.RenderSize.Width - IqrCCLXiL6tufePUWuIC(IYil2S8SxcB).Width;
					offset.Y = Elvl2xiF7sb.RenderSize.Height + 2.0;
					goto default;
				case 2:
					if (horizontalAlignment3 == HorizontalAlignment.Right)
					{
						goto case 7;
					}
					goto case 8;
				case 8:
					offset.X = 0.0;
					offset.Y = Elvl2xiF7sb.RenderSize.Height + 2.0;
					goto default;
				case 3:
					result = new CustomPopupPlacement[1]
					{
						new CustomPopupPlacement(offset, PopupPrimaryAxis.Horizontal)
					};
					num = 5;
					break;
				default:
					hwndSource = (HwndSource)xacpIBXie5FItEhLFOTE(Elvl2xiF7sb);
					num2 = 6;
					goto IL_0005;
				case 5:
					return result;
				case 1:
					transformToDevice = ((CompositionTarget)vCyS8cXisTot91IJuxu0(hwndSource)).TransformToDevice;
					num2 = 4;
					goto IL_0005;
				case 6:
					if (hwndSource?.CompositionTarget == null)
					{
						num = 3;
						break;
					}
					goto case 1;
				case 4:
					{
						offset = transformToDevice.Transform(offset);
						goto case 3;
					}
					IL_0005:
					num = num2;
					break;
				}
			}
		}

		internal void yc9l25PttgD(object sender, RoutedEventArgs routedEventArgs)
		{
			// Found self-referencing delegate construction. Abort transformation to avoid stack overflow.
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					nHTXTEXiX223sv0gdkFP(Elvl2xiF7sb, false);
					num2 = 0;
					if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_e9984bb1541d41d58b47e3c8a388ab36 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				kpXMTqXicgXYkQNQiKCw(IYil2S8SxcB, new RoutedEventHandler(yc9l25PttgD));
				AXgkNtXijWsWdMpy6PUn(IYil2S8SxcB, (KeyEventHandler)delegate(object P_0, KeyEventArgs P_1)
				{
					if (x1CVXIXaRubB4CwdLaHO(P_1) == Key.Apps)
					{
						P_1.Handled = true;
						int num3 = 0;
						if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_737065c8a4b74d1d9d7a50423d7ba3fc != 0)
						{
							num3 = 0;
						}
						switch (num3)
						{
						case 0:
							break;
						}
					}
				});
				LrkavFXiEcaIakZUmdKC(Elvl2xiF7sb, null);
				return;
			}
		}

		static fCfNoEl2kpHq06NGtW5K()
		{
			OQNZEtsP93U56NxbHlup.tMIsP5FCtWb();
			wwQ0MQXiQlScCsxSO7xE();
		}

		internal static bool mTNkQYXi1cJ2ifT4NO5s()
		{
			return eIDmQ1XikOZfigN6wO77 == null;
		}

		internal static fCfNoEl2kpHq06NGtW5K AKYbn2Xi5hI9qCcN9IA8()
		{
			return eIDmQ1XikOZfigN6wO77;
		}

		internal static object cKncWAXiSYANN9uc78Zw(object P_0, object P_1)
		{
			return Delegate.Remove((Delegate)P_0, (Delegate)P_1);
		}

		internal static void ska8cZXixGsuaaoLVIL8(object P_0, object P_1)
		{
			((System.Windows.Controls.ContextMenu)P_0).CustomPopupPlacementCallback = (CustomPopupPlacementCallback)P_1;
		}

		internal static Size IqrCCLXiL6tufePUWuIC(object P_0)
		{
			return ((UIElement)P_0).RenderSize;
		}

		internal static object xacpIBXie5FItEhLFOTE(object P_0)
		{
			return PresentationSource.FromVisual((Visual)P_0);
		}

		internal static object vCyS8cXisTot91IJuxu0(object P_0)
		{
			return ((HwndSource)P_0).CompositionTarget;
		}

		internal static void nHTXTEXiX223sv0gdkFP(object P_0, bool value)
		{
			SetIsContextMenuOpened((DependencyObject)P_0, value);
		}

		internal static void kpXMTqXicgXYkQNQiKCw(object P_0, object P_1)
		{
			((System.Windows.Controls.ContextMenu)P_0).Closed -= (RoutedEventHandler)P_1;
		}

		internal static void AXgkNtXijWsWdMpy6PUn(object P_0, object P_1)
		{
			((UIElement)P_0).PreviewKeyUp -= (KeyEventHandler)P_1;
		}

		internal static void LrkavFXiEcaIakZUmdKC(object P_0, object P_1)
		{
			uU4l0WfqCPZ((DependencyObject)P_0, (ContextMenu)P_1);
		}

		internal static void wwQ0MQXiQlScCsxSO7xE()
		{
			HandHqsFGhqpm8Ixav52.kLjw4iIsCLsZtxc4lksN0j();
		}
	}

	public static readonly DependencyProperty IsEnabledProperty;

	public static readonly DependencyProperty IsContextMenuOpenedProperty;

	public static readonly DependencyProperty U9Rl0wXH9au;

	public static readonly DependencyProperty HorizontalAlignmentProperty;

	public static RoutedCommand ContextMenuOpening;

	internal static ContextMenuBehavior ugn6crXasFltgCXF5J8m;

	public static void SetHorizontalAlignment(DependencyObject element, HorizontalAlignment value)
	{
		element.SetValue(HorizontalAlignmentProperty, value);
	}

	public static HorizontalAlignment GetHorizontalAlignment(DependencyObject element)
	{
		return (HorizontalAlignment)v4pAdXXajpeiyxHAwABv(element, HorizontalAlignmentProperty);
	}

	public static void SetIsContextMenuOpened(DependencyObject element, bool value)
	{
		element.SetValue(IsContextMenuOpenedProperty, value);
	}

	public static bool GetIsContextMenuOpened(DependencyObject element)
	{
		return (bool)v4pAdXXajpeiyxHAwABv(element, IsContextMenuOpenedProperty);
	}

	public static void SetIsEnabled(DependencyObject element, bool value)
	{
		element.SetValue(IsEnabledProperty, value);
	}

	public static bool GetIsEnabled(DependencyObject element)
	{
		return (bool)v4pAdXXajpeiyxHAwABv(element, IsEnabledProperty);
	}

	public static void uU4l0WfqCPZ(DependencyObject P_0, ContextMenu P_1)
	{
		DWYt0GXaElCb1m1gFQak(P_0, U9Rl0wXH9au, P_1);
	}

	public static ContextMenu bChl0tBouU8(DependencyObject P_0)
	{
		return (ContextMenu)P_0.GetValue(U9Rl0wXH9au);
	}

	private static void G2Ll0UCbq01(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		if (!(P_0 is UIElement uIElement))
		{
			return;
		}
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 4:
				return;
			case 5:
				return;
			case 2:
			case 3:
				if ((bool)P_1.NewValue)
				{
					uIElement.PreviewMouseDown += jQDl0TL6elq;
					num = 0;
					if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_e1a6c635ab4940dbb3ffcd364da08562 != 0)
					{
						num = 0;
					}
				}
				else
				{
					QwNWXuXadILXViqDZsos(uIElement, new MouseButtonEventHandler(jQDl0TL6elq));
					num = 1;
					if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_eb5248e0c761453cb12954b91b9ede6d == 0)
					{
						num = 1;
					}
				}
				break;
			case 1:
				uIElement.PreviewKeyDown -= KItl0yoS0yx;
				nA5g8iXag0u8hSEUZ1Lg(uIElement, new KeyEventHandler(XJ6l0ZZcB8N));
				num = 5;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_42bc11c38b8e48eeaa3a7e6f002e0752 == 0)
				{
					num = 0;
				}
				break;
			default:
				uIElement.PreviewKeyDown += KItl0yoS0yx;
				LyCN6eXaQdhQ6UObVsvg(uIElement, new KeyEventHandler(XJ6l0ZZcB8N));
				num = 4;
				break;
			}
		}
	}

	private static void jQDl0TL6elq(object P_0, MouseButtonEventArgs P_1)
	{
		UIElement uIElement = P_0 as UIElement;
		jkWl0VcIayH(uIElement);
		P_1.Handled = true;
		int num = 0;
		if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_9e10945a24ab416eb40e04a5b259cd53 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	private static void KItl0yoS0yx(object P_0, KeyEventArgs P_1)
	{
		int num = 1;
		int num2 = num;
		bool flag = default(bool);
		UIElement uIElement = default(UIElement);
		while (true)
		{
			int num3;
			switch (num2)
			{
			case 2:
				return;
			case 3:
				if (!flag)
				{
					num2 = 0;
					if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_73192da35ad547548b56bccf34aa52bd == 0)
					{
						num2 = 2;
					}
					continue;
				}
				P_1.Handled = true;
				jkWl0VcIayH(uIElement);
				return;
			case 1:
				uIElement = P_0 as UIElement;
				num2 = 0;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_0bd24d908e924c0b83abf9fb2f7c1f25 == 0)
				{
					num2 = 0;
				}
				continue;
			case 4:
				if (x1CVXIXaRubB4CwdLaHO(P_1) != Key.Return && P_1.Key != Key.Return)
				{
					num3 = ((P_1.Key == Key.Space) ? 1 : 0);
					break;
				}
				goto IL_00e8;
			default:
				{
					if (P_1.Key != Key.Apps)
					{
						num2 = 4;
						continue;
					}
					goto IL_00e8;
				}
				IL_00e8:
				num3 = 1;
				break;
			}
			flag = (byte)num3 != 0;
			num2 = 3;
			if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_aaee87d70b4c49aab4b237d8e1fb4ee6 != 0)
			{
				num2 = 2;
			}
		}
	}

	private static void XJ6l0ZZcB8N(object P_0, KeyEventArgs P_1)
	{
		int num = 2;
		int num2 = num;
		UIElement uIElement = default(UIElement);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (P_1.Key == Key.Apps)
				{
					num2 = 0;
					if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_5a3bf026df2e4752aeee32ca0b5dd9a8 != 0)
					{
						num2 = 0;
					}
					break;
				}
				return;
			default:
				if (uIElement != null)
				{
					pEbLelXa6BeLerAMBymV(P_1, true);
				}
				return;
			case 2:
				uIElement = P_0 as UIElement;
				num2 = 1;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_a0279c4ba1c84315962e441eb713cbcc == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	private static void jkWl0VcIayH(UIElement P_0)
	{
		int num = 2;
		int num2 = num;
		ContextMenu contextMenu = default(ContextMenu);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				contextMenu = (ContextMenu)VjpltyXaMjg9NdxuN4D8(P_0);
				num2 = 1;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_7f9125e4d55540daa7e9de318d14253b != 0)
				{
					num2 = 0;
				}
				continue;
			case 0:
				return;
			case 1:
				if (contextMenu != null)
				{
					lQGvJSXaOVl605FWLW7a(contextMenu, false);
					num2 = 0;
					if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_950e000f8b8e487a9fb408c5cce03cd7 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			case 3:
				break;
			}
			break;
		}
		nFXl0Cw3L3E(P_0);
	}

	private static void nFXl0Cw3L3E(UIElement P_0)
	{
		ContextMenu contextMenu = qNIl0m4Qknb(P_0);
		uU4l0WfqCPZ(P_0, contextMenu);
		int num = 1;
		if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_d5cf9ea404004c488c3b0bf4ea818b28 != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				if (P_0 is FrameworkElement frameworkElement)
				{
					frameworkElement.ContextMenu = null;
					num = 3;
					break;
				}
				goto case 3;
			case 1:
				SetIsContextMenuOpened(P_0, value: true);
				num = 2;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_972dd0905aa74735b7862b8138b18a1d != 0)
				{
					num = 2;
				}
				break;
			case 2:
				P_0.Focus();
				lQGvJSXaOVl605FWLW7a(contextMenu, true);
				num = 0;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_1c958f34803646f7bd8283df13e97b54 != 0)
				{
					num = 0;
				}
				break;
			case 3:
				muNl0KuJUme(contextMenu);
				return;
			}
		}
	}

	public static et7C9MsAzBse1nG2D2Hg ypQl0rKQWeT<et7C9MsAzBse1nG2D2Hg>(DependencyObject P_0) where et7C9MsAzBse1nG2D2Hg : DependencyObject
	{
		int childrenCount = VisualTreeHelper.GetChildrenCount(P_0);
		int num = 0;
		if (num < childrenCount)
		{
			DependencyObject child = VisualTreeHelper.GetChild(P_0, num);
			if (child is et7C9MsAzBse1nG2D2Hg result)
			{
				return result;
			}
			return ypQl0rKQWeT<et7C9MsAzBse1nG2D2Hg>(child);
		}
		return null;
	}

	private static void muNl0KuJUme(ContextMenu P_0)
	{
		int num = 1;
		int num2 = num;
		MenuItem menuItem = default(MenuItem);
		while (true)
		{
			switch (num2)
			{
			default:
				if (menuItem != null)
				{
					EPN49eXaq61olbpXN4Zs(menuItem);
				}
				return;
			case 1:
				menuItem = ypQl0rKQWeT<MenuItem>(P_0);
				num2 = 0;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_d5cf9ea404004c488c3b0bf4ea818b28 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private static ContextMenu qNIl0m4Qknb(UIElement P_0)
	{
		int num = 2;
		int num2 = num;
		ContextMenu result = default(ContextMenu);
		fCfNoEl2kpHq06NGtW5K fCfNoEl2kpHq06NGtW5K = default(fCfNoEl2kpHq06NGtW5K);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return result;
			case 1:
			{
				fCfNoEl2kpHq06NGtW5K.Elvl2xiF7sb = P_0;
				fCfNoEl2kpHq06NGtW5K fCfNoEl2kpHq06NGtW5K2 = fCfNoEl2kpHq06NGtW5K;
				ContextMenu obj = new ContextMenu
				{
					PlacementTarget = fCfNoEl2kpHq06NGtW5K.Elvl2xiF7sb
				};
				bU0yc1XaIgoWcEul26mJ(obj, PlacementMode.Custom);
				fCfNoEl2kpHq06NGtW5K2.IYil2S8SxcB = obj;
				ContextMenu contextMenu = fCfNoEl2kpHq06NGtW5K.IYil2S8SxcB;
				contextMenu.CustomPopupPlacementCallback = (CustomPopupPlacementCallback)hOCYAIXaWJ5oLyOnY5Ug(contextMenu.CustomPopupPlacementCallback, new CustomPopupPlacementCallback(fCfNoEl2kpHq06NGtW5K.fhel21eoRlo));
				fCfNoEl2kpHq06NGtW5K.IYil2S8SxcB.Closed += fCfNoEl2kpHq06NGtW5K.yc9l25PttgD;
				yyRJtXXatYsswGeBTaUd(fCfNoEl2kpHq06NGtW5K.IYil2S8SxcB, (KeyEventHandler)delegate(object obj2, KeyEventArgs e)
				{
					if (x1CVXIXaRubB4CwdLaHO(e) == Key.Apps)
					{
						e.Handled = true;
						int num3 = 0;
						if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_737065c8a4b74d1d9d7a50423d7ba3fc != 0)
						{
							num3 = 0;
						}
						switch (num3)
						{
						case 0:
							break;
						}
					}
				});
				num2 = 0;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_45beddfe9d2c40369d7410b1ce3b00ea == 0)
				{
					num2 = 0;
				}
				break;
			}
			case 2:
				fCfNoEl2kpHq06NGtW5K = new fCfNoEl2kpHq06NGtW5K();
				num2 = 0;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_22d0d1251c144ffb8e08dee8f7ca9f9a == 0)
				{
					num2 = 1;
				}
				break;
			default:
				ContextMenuOpening.Execute(fCfNoEl2kpHq06NGtW5K.IYil2S8SxcB, fCfNoEl2kpHq06NGtW5K.Elvl2xiF7sb);
				num2 = 4;
				break;
			case 4:
				return fCfNoEl2kpHq06NGtW5K.IYil2S8SxcB;
			}
		}
	}

	public ContextMenuBehavior()
	{
		IJ8UUqXaUTuJieiPtxeG();
		base._002Ector();
	}

	static ContextMenuBehavior()
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				ContextMenuOpening = new RoutedCommand();
				return;
			case 2:
				Pe16l1XayIyGNK0n5cPe();
				RwEN8CsJudtSqX6iB0vv.D4wX52wcDDu();
				num2 = 0;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_e1a6c635ab4940dbb3ffcd364da08562 == 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
				uEZCtJXaT27j4Wo6II8q();
				num2 = 2;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_95acc7c218cf41fca5a2921d69d7eb5c == 0)
				{
					num2 = 1;
				}
				continue;
			}
			IsEnabledProperty = (DependencyProperty)CXXRteXaCLDk9j8qcQWZ(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(0x2D3134C9 ^ 0x2D313EFF), Type.GetTypeFromHandle(pPjGoTXaZ3Yl9DbNuAwJ(16777220)), ui15ckXaVcKiuRuSdD9S(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554488)), new PropertyMetadata(false, G2Ll0UCbq01));
			IsContextMenuOpenedProperty = (DependencyProperty)CXXRteXaCLDk9j8qcQWZ(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(0x6E2DFBED ^ 0x6E2DF1A1), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(16777220)), ui15ckXaVcKiuRuSdD9S(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554488)), new PropertyMetadata(false));
			U9Rl0wXH9au = (DependencyProperty)CXXRteXaCLDk9j8qcQWZ(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(0x28C965BE ^ 0x28C96FC8), Type.GetTypeFromHandle(pPjGoTXaZ3Yl9DbNuAwJ(33554454)), Type.GetTypeFromHandle(pPjGoTXaZ3Yl9DbNuAwJ(33554488)), new PropertyMetadata(null));
			HorizontalAlignmentProperty = DependencyProperty.RegisterAttached((string)skH2bgXarZfc65UXFfRN(0x60620FC1 ^ 0x60620551), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(16777381)), ui15ckXaVcKiuRuSdD9S(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554488)), new PropertyMetadata(HorizontalAlignment.Left));
			num2 = 1;
			if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_f613416004f048ed97d95a2596e7c9aa != 0)
			{
				num2 = 1;
			}
		}
	}

	[CompilerGenerated]
	internal static void cbql0h4mXfP(object P_0, KeyEventArgs P_1)
	{
		if (x1CVXIXaRubB4CwdLaHO(P_1) == Key.Apps)
		{
			P_1.Handled = true;
			int num = 0;
			if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_737065c8a4b74d1d9d7a50423d7ba3fc != 0)
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

	internal static bool aRINE7XaXOfZxfTNACxB()
	{
		return ugn6crXasFltgCXF5J8m == null;
	}

	internal static ContextMenuBehavior iHRKHKXacEy8FWSOugS4()
	{
		return ugn6crXasFltgCXF5J8m;
	}

	internal static object v4pAdXXajpeiyxHAwABv(object P_0, object P_1)
	{
		return ((DependencyObject)P_0).GetValue((DependencyProperty)P_1);
	}

	internal static void DWYt0GXaElCb1m1gFQak(object P_0, object P_1, object P_2)
	{
		((DependencyObject)P_0).SetValue((DependencyProperty)P_1, P_2);
	}

	internal static void LyCN6eXaQdhQ6UObVsvg(object P_0, object P_1)
	{
		((UIElement)P_0).KeyUp += (KeyEventHandler)P_1;
	}

	internal static void QwNWXuXadILXViqDZsos(object P_0, object P_1)
	{
		((UIElement)P_0).PreviewMouseDown -= (MouseButtonEventHandler)P_1;
	}

	internal static void nA5g8iXag0u8hSEUZ1Lg(object P_0, object P_1)
	{
		((UIElement)P_0).KeyUp -= (KeyEventHandler)P_1;
	}

	internal static Key x1CVXIXaRubB4CwdLaHO(object P_0)
	{
		return ((KeyEventArgs)P_0).Key;
	}

	internal static void pEbLelXa6BeLerAMBymV(object P_0, bool P_1)
	{
		((RoutedEventArgs)P_0).Handled = P_1;
	}

	internal static object VjpltyXaMjg9NdxuN4D8(object P_0)
	{
		return bChl0tBouU8((DependencyObject)P_0);
	}

	internal static void lQGvJSXaOVl605FWLW7a(object P_0, bool P_1)
	{
		((System.Windows.Controls.ContextMenu)P_0).IsOpen = P_1;
	}

	internal static bool EPN49eXaq61olbpXN4Zs(object P_0)
	{
		return ((UIElement)P_0).Focus();
	}

	internal static void bU0yc1XaIgoWcEul26mJ(object P_0, PlacementMode P_1)
	{
		((System.Windows.Controls.ContextMenu)P_0).Placement = P_1;
	}

	internal static object hOCYAIXaWJ5oLyOnY5Ug(object P_0, object P_1)
	{
		return Delegate.Combine((Delegate)P_0, (Delegate)P_1);
	}

	internal static void yyRJtXXatYsswGeBTaUd(object P_0, object P_1)
	{
		((UIElement)P_0).PreviewKeyUp += (KeyEventHandler)P_1;
	}

	internal static void IJ8UUqXaUTuJieiPtxeG()
	{
		RwEN8CsJudtSqX6iB0vv.D4wX52wcDDu();
	}

	internal static void uEZCtJXaT27j4Wo6II8q()
	{
		OQNZEtsP93U56NxbHlup.tMIsP5FCtWb();
	}

	internal static void Pe16l1XayIyGNK0n5cPe()
	{
		HandHqsFGhqpm8Ixav52.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static RuntimeTypeHandle pPjGoTXaZ3Yl9DbNuAwJ(int token)
	{
		return H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(token);
	}

	internal static Type ui15ckXaVcKiuRuSdD9S(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object CXXRteXaCLDk9j8qcQWZ(object P_0, Type P_1, Type P_2, object P_3)
	{
		return DependencyProperty.RegisterAttached((string)P_0, P_1, P_2, (PropertyMetadata)P_3);
	}

	internal static object skH2bgXarZfc65UXFfRN(int P_0)
	{
		return OQNZEtsP93U56NxbHlup.BeJsPcmdLda(P_0);
	}
}
