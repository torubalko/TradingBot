using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.Docking.Automation.Peers;
using ActiproSoftware.Windows.Controls.Docking.Primitives;
using ActiproSoftware.Windows.Data;
using ActiproSoftware.Windows.Extensions;
using ActiproSoftware.Windows.Input;
using ActiproSoftware.Windows.Media;
using Microsoft.CSharp.RuntimeBinder;

namespace ActiproSoftware.Windows.Controls.Docking;

[TemplatePart(Name = "PART_SelectedContentHost", Type = typeof(ContentPresenter))]
[TemplateVisualState(Name = "TabStripBottom", GroupName = "TabStripPlacementStates")]
[TemplateVisualState(Name = "TabStripLeft", GroupName = "TabStripPlacementStates")]
[TemplateVisualState(Name = "TabStripRight", GroupName = "TabStripPlacementStates")]
[SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling")]
[TemplatePart(Name = "PART_NewTabButton", Type = typeof(NewTabButton))]
[TemplateVisualState(Name = "TabStripTop", GroupName = "TabStripPlacementStates")]
[TemplatePart(Name = "PART_MenuButton", Type = typeof(PopupButton))]
public class AdvancedTabControl : TabControl
{
	internal class vVB
	{
		[CompilerGenerated]
		private static class _003C_003Eo__14
		{
			public static CallSite<Action<CallSite, object, int, int>> KsS;
		}

		private InputAdapter dSE;

		private AdvancedTabItem NSr;

		private double jSx;

		private Point jSl;

		private Point HSM;

		private bool PSv;

		private bool fS7;

		private UIElement XSR;

		private AdvancedTabControl wSS;

		private AdvancedTabPanel SSL;

		private static vVB JKe;

		private vVB()
		{
			IVH.CecNqz();
			base._002Ector();
		}

		private void FSI(InputPointerEventArgs P_0)
		{
			dSE = new InputAdapter(wSS);
			dSE.CapturePointer(P_0);
			dSE.PointerCaptureLost += zSQ;
			dSE.PointerMoved += aSN;
			dSE.PointerReleased += zSQ;
			dSE.AttachedEventKinds = InputAdapterEventKinds.PointerCaptureLost | InputAdapterEventKinds.PointerMoved | InputAdapterEventKinds.PointerReleased;
		}

		[SpecialName]
		private bool HSB()
		{
			if (wSS.CanTabsDrag)
			{
				if (wSS.ItemsSource != null)
				{
					return wSS.ItemsSource is IList;
				}
				return true;
			}
			return false;
		}

		private void lSk(IList<AdvancedTabItem> P_0, AdvancedTabItem P_1)
		{
			int num = P_0.IndexOf(P_1);
			if (num == -1)
			{
				return;
			}
			if (wSS.ItemsSource != null)
			{
				if (!(wSS.ItemsSource is IList list))
				{
					return;
				}
				object obj = ((num > 0) ? wSS.ItemContainerGenerator.ItemFromContainer(P_0[num - 1]) : null);
				object obj2 = wSS.ItemContainerGenerator.ItemFromContainer(P_1);
				if (obj2 == null)
				{
					return;
				}
				int num2 = list.IndexOf(obj2);
				int num3 = ((obj != null) ? (list.IndexOf(obj) + 1) : 0);
				if (num2 == -1 || num3 == -1 || num2 == num3)
				{
					return;
				}
				Type type = list.GetType();
				bool num4 = type.IsGenericType && !type.IsGenericTypeDefinition && type.GetGenericTypeDefinition() == typeof(ObservableCollection<>);
				num3 += ((num3 > num2) ? (-1) : 0);
				P_1.IsLoadAnimationEnabled = false;
				if (num4)
				{
					object arg = list;
					P_1.Qwb(value: true);
					if (_003C_003Eo__14.KsS == null)
					{
						_003C_003Eo__14.KsS = CallSite<Action<CallSite, object, int, int>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, vVK.ssH(28156), null, typeof(vVB), new CSharpArgumentInfo[3]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
						}));
					}
					_003C_003Eo__14.KsS.Target(_003C_003Eo__14.KsS, arg, num2, num3);
					P_1.Qwb(value: false);
				}
				else
				{
					list.RemoveAt(num2);
					list.Insert(num3, obj2);
				}
				wSS.SelectedItem = obj2;
			}
			else
			{
				if (wSS.Items.Count <= 0)
				{
					return;
				}
				object obj3 = ((num > 0) ? wSS.ItemContainerGenerator.ItemFromContainer(P_0[num - 1]) : null);
				object obj4 = wSS.ItemContainerGenerator.ItemFromContainer(P_1);
				if (obj4 != null)
				{
					int num5 = wSS.Items.IndexOf(obj4);
					int num6 = ((obj3 != null) ? (wSS.Items.IndexOf(obj3) + 1) : 0);
					if (num5 != -1 && num6 != -1 && num5 != num6)
					{
						P_1.Qwb(value: true);
						P_1.IsLoadAnimationEnabled = false;
						wSS.Items.RemoveAt(num5);
						wSS.Items.Insert(num6 + ((num6 > num5) ? (-1) : 0), obj4);
						wSS.SelectedItem = obj4;
						P_1.Qwb(value: false);
					}
				}
			}
		}

		private void USC()
		{
			if (dSE != null)
			{
				dSE.PointerCaptureLost -= zSQ;
				dSE.PointerMoved -= aSN;
				dSE.PointerReleased -= zSQ;
				dSE.AttachedEventKinds = InputAdapterEventKinds.None;
				dSE = null;
			}
		}

		private void hS1()
		{
			USC();
			wSS.BU(1.0);
			wSS.rdz = null;
		}

		private void aSN(object P_0, InputPointerEventArgs P_1)
		{
			kSm(P_1);
		}

		private void zSQ(object P_0, InputPointerEventArgs P_1)
		{
			qSa(_0020: false);
		}

		private void kSm(InputPointerEventArgs P_0)
		{
			if (NSr == null)
			{
				return;
			}
			Point position = P_0.GetPosition(XSR ?? SSL);
			Point point = new Point(position.X - jSl.X, position.Y - jSl.Y);
			if (!PSv && HSB() && (Math.Abs(point.X) > 10.0 || Math.Abs(point.Y) > 10.0))
			{
				PSv = true;
				wSS.BU(0.0);
			}
			if (!PSv || SSL == null)
			{
				return;
			}
			int num;
			if (XSR != SSL)
			{
				position = P_0.GetPosition(SSL);
				num = 0;
				if (!PKJ())
				{
					num = 0;
				}
				goto IL_0009;
			}
			goto IL_0081;
			IL_02e3:
			Tuple<double, double> tuple = SSL.bOU(NSr.LayoutKind);
			Orientation orientation = default(Orientation);
			jSx = Math.Max(tuple.Item1, Math.Min(tuple.Item2 - ((orientation == Orientation.Horizontal) ? NSr.ActualWidth : NSr.ActualHeight), jSx));
			AdvancedTabItem[] array = SSL.GetTabItemElements(NSr.LayoutKind).ToArray();
			AdvancedTabItem[] array2 = array;
			int num2 = 0;
			goto IL_0262;
			IL_0262:
			AdvancedTabItem advancedTabItem = default(AdvancedTabItem);
			if (num2 < array2.Length)
			{
				advancedTabItem = array2[num2];
				num = 1;
				if (NKU() == null)
				{
					num = 1;
				}
				goto IL_0009;
			}
			goto IL_01f4;
			IL_00a1:
			jSx = position.Y - HSM.Y;
			goto IL_02e3;
			IL_0076:
			num2++;
			goto IL_0262;
			IL_0005:
			int num3 = default(int);
			num = num3;
			goto IL_0009;
			IL_01f4:
			wSS.uh();
			return;
			IL_012d:
			orientation = wSS.zdc();
			if (orientation != Orientation.Horizontal)
			{
				goto IL_00a1;
			}
			jSx = position.X - HSM.X;
			goto IL_02e3;
			IL_0009:
			Action action = default(Action);
			Rect rect = default(Rect);
			int num4 = default(int);
			bool flag4 = default(bool);
			int num5 = default(int);
			int num6 = default(int);
			while (true)
			{
				bool flag;
				switch (num)
				{
				case 1:
					break;
				default:
					goto end_IL_0009;
				case 3:
					goto IL_00a1;
				case 4:
					goto IL_013f;
				case 2:
					fS7 = true;
					action = wSS.ddQ(P_0, NSr, point);
					num = 6;
					continue;
				case 8:
					flag = wSS.Items.Count == 1;
					if (!flag)
					{
						rect = new Rect(-10.0, -10.0, SSL.ActualWidth + 20.0, SSL.ActualHeight + 20.0);
						num = 7;
						continue;
					}
					goto IL_0592;
				case 6:
					if (action != null)
					{
						qSa(_0020: true);
						action();
						return;
					}
					goto IL_012d;
				case 7:
					flag = !rect.Contains(position);
					goto IL_0592;
				case 5:
					goto IL_062d;
					IL_0592:
					if (!flag)
					{
						goto IL_012d;
					}
					goto case 2;
				}
				if (advancedTabItem != NSr)
				{
					Rect rect2 = AdvancedTabPanel.COF(advancedTabItem);
					bool flag2;
					bool flag3;
					if (orientation == Orientation.Horizontal)
					{
						if (NSr.DragSortOrder >= advancedTabItem.DragSortOrder)
						{
							position.X = jSx;
							flag2 = rect2.Contains(position);
							flag3 = position.X < rect2.X + rect2.Width * 0.4;
						}
						else
						{
							position.X = jSx + NSr.ActualWidth;
							flag2 = rect2.Contains(position);
							flag3 = position.X < rect2.X + rect2.Width * 0.6;
						}
					}
					else if (NSr.DragSortOrder < advancedTabItem.DragSortOrder)
					{
						position.Y = jSx + NSr.ActualHeight;
						flag2 = rect2.Contains(position);
						flag3 = position.Y < rect2.Y + rect2.Height * 0.6;
					}
					else
					{
						position.Y = jSx;
						flag2 = rect2.Contains(position);
						flag3 = position.Y < rect2.Y + rect2.Height * 0.4;
					}
					if (flag2)
					{
						num4 = NSr.DragSortOrder;
						flag4 = num4 < advancedTabItem.DragSortOrder;
						num5 = advancedTabItem.DragSortOrder + ((!flag4) ? ((!flag3) ? 1 : 0) : (flag3 ? (-1) : 0));
						if (num4 != num5)
						{
							num6 = 0;
							goto IL_013f;
						}
					}
				}
				goto IL_0076;
				IL_013f:
				if (num6 >= array.Length)
				{
					goto IL_01f4;
				}
				if (num6 != num4)
				{
					if (flag4)
					{
						if (num6 > num4 && num6 <= num5)
						{
							array[num6].DragSortOrder--;
						}
					}
					else if (num6 >= num5 && num6 < num4)
					{
						array[num6].DragSortOrder++;
					}
					goto IL_062d;
				}
				array[num6].DragSortOrder = num5;
				num = 5;
				continue;
				IL_062d:
				num6++;
				num = 4;
				if (NKU() == null)
				{
					continue;
				}
				goto IL_0005;
				continue;
				end_IL_0009:
				break;
			}
			goto IL_0081;
			IL_0081:
			if (!fS7)
			{
				num = 8;
				if (!PKJ())
				{
					goto IL_0005;
				}
				goto IL_0009;
			}
			goto IL_012d;
		}

		private void qSa(bool P_0)
		{
			AdvancedTabItem advancedTabItem = null;
			if (NSr != null)
			{
				AdvancedTabItem advancedTabItem2 = DSJ();
				AdvancedTabItem[] array = SSL.GetTabItemElements().ToArray();
				NSr = null;
				jSl = default(Point);
				PSv = false;
				XSR = null;
				if (advancedTabItem2 != null)
				{
					advancedTabItem2.WwD();
					if (!P_0)
					{
						lSk(array, advancedTabItem2);
						advancedTabItem = advancedTabItem2;
					}
					wSS.uh(_0020: true);
					wSS.NA(advancedTabItem2);
				}
				dSE.ReleasePointerCaptures();
			}
			hS1();
			if (advancedTabItem != null)
			{
				wSS.tdm(advancedTabItem);
			}
		}

		[SpecialName]
		public AdvancedTabItem DSJ()
		{
			if (PSv)
			{
				return NSr;
			}
			return null;
		}

		[SpecialName]
		public double mSO()
		{
			return jSx;
		}

		[SpecialName]
		public bool GS8()
		{
			return PSv;
		}

		public static vVB hSW(AdvancedTabItem P_0, InputPointerButtonEventArgs P_1)
		{
			if (P_0 == null)
			{
				throw new ArgumentNullException(vVK.ssH(28168));
			}
			if (P_1 == null)
			{
				throw new ArgumentNullException(vVK.ssH(3942));
			}
			AdvancedTabControl advancedTabControl = P_0.qwH();
			if (advancedTabControl != null)
			{
				if (advancedTabControl.rdz != null)
				{
					advancedTabControl.rdz.hS1();
				}
				AdvancedTabPanel advancedTabPanel = advancedTabControl.edP();
				if (advancedTabPanel != null)
				{
					vVB vVB = new vVB();
					vVB.NSr = P_0;
					vVB.wSS = advancedTabControl;
					vVB.SSL = advancedTabPanel;
					vVB.XSR = (VisualTreeHelperExtended.GetRoot(advancedTabPanel) as UIElement) ?? advancedTabPanel;
					vVB.jSl = P_1.GetPosition(vVB.XSR);
					vVB.HSM = P_1.GetPosition(P_0);
					vVB.FSI(P_1);
					advancedTabControl.rdz = vVB;
				}
			}
			return null;
		}

		internal static bool PKJ()
		{
			return JKe == null;
		}

		internal static vVB NKU()
		{
			return JKe;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass132_0
	{
		public AdvancedTabControl oS6;

		private static _003C_003Ec__DisplayClass132_0 SKF;

		public _003C_003Ec__DisplayClass132_0()
		{
			IVH.CecNqz();
			base._002Ector();
		}

		internal void FS3()
		{
			oS6.UpdateHighlightBrushes();
		}

		internal static bool vKd()
		{
			return SKF == null;
		}

		internal static _003C_003Ec__DisplayClass132_0 sK7()
		{
			return SKF;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass375_0
	{
		public object KSq;

		public AdvancedTabControl lSF;

		internal static _003C_003Ec__DisplayClass375_0 qKx;

		public _003C_003Ec__DisplayClass375_0()
		{
			IVH.CecNqz();
			base._002Ector();
		}

		internal void jSs()
		{
			if (KSq == lSF.SelectedItem)
			{
				lSF.qb(KSq);
			}
		}

		internal static bool kKR()
		{
			return qKx == null;
		}

		internal static _003C_003Ec__DisplayClass375_0 iKD()
		{
			return qKx;
		}
	}

	private InputAdapter Kdu;

	private vVB rdz;

	private PopupButton iwi;

	private NewTabButton fwd;

	private DelegateCommand<object> Bww;

	private DelegateCommand<object> hw2;

	private DelegateCommand<object> Hwe;

	private ContentPresenter wwG;

	private AdvancedTabPanel lwI;

	private double Rwk;

	public static readonly DependencyProperty AreScrollButtonsVisibleProperty;

	public static readonly DependencyProperty AreTabEmbeddedButtonsAlwaysVisibleProperty;

	public static readonly DependencyProperty CanScrollBackwardProperty;

	public static readonly DependencyProperty CanScrollForwardProperty;

	public static readonly DependencyProperty CanTabsCloseOnMiddleClickProperty;

	public static readonly DependencyProperty CanTabsDragProperty;

	public static readonly DependencyProperty CanTabsHighlightOnPointerOverWhenInactiveProperty;

	public static readonly DependencyProperty CanTabsPinProperty;

	public static readonly DependencyProperty CanTabsPromoteProperty;

	public static readonly DependencyProperty EmbeddedButtonStyleProperty;

	public static readonly DependencyProperty HasNewTabButtonProperty;

	public static readonly DependencyProperty HasTabCloseButtonsProperty;

	public static readonly DependencyProperty HasTabImagesProperty;

	public static readonly DependencyProperty HighlightBrushActiveProperty;

	public static readonly DependencyProperty HighlightBrushInactiveProperty;

	public static readonly DependencyProperty HighlightThicknessProperty;

	public static readonly DependencyProperty IsActiveProperty;

	public static readonly DependencyProperty IsMenuButtonVisibleProperty;

	public static readonly DependencyProperty IsLayoutAnimationEnabledProperty;

	public static readonly DependencyProperty IsOverflowedProperty;

	public static readonly DependencyProperty IsTabContentHorizontalProperty;

	public static readonly DependencyProperty IsTabKeyboardAccessEnabledProperty;

	public static readonly DependencyProperty IsTabKeyboardSwitchingEnabledProperty;

	public static readonly DependencyProperty IsTabStripVisibleProperty;

	public static readonly DependencyProperty MaxTabExtentProperty;

	public static readonly DependencyProperty MenuButtonContentTemplateProperty;

	public static readonly DependencyProperty MinTabExtentProperty;

	public static readonly DependencyProperty OverflowMenuButtonContentTemplateProperty;

	public static readonly DependencyProperty NewTabButtonStyleProperty;

	public static readonly DependencyProperty RotatedBorderThicknessProperty;

	public static readonly DependencyProperty RotatedHighlightThicknessProperty;

	public static readonly DependencyProperty RotatedPaddingProperty;

	public static readonly DependencyProperty ScrollBackwardButtonContentTemplateProperty;

	public static readonly DependencyProperty ScrollForwardButtonContentTemplateProperty;

	public static readonly DependencyProperty ScrollOffsetProperty;

	public static readonly DependencyProperty TabBackgroundProperty;

	public static readonly DependencyProperty TabBackgroundActiveSelectedProperty;

	public static readonly DependencyProperty TabBackgroundInactiveSelectedProperty;

	public static readonly DependencyProperty TabBackgroundPointerOverProperty;

	public static readonly DependencyProperty TabBackgroundPreviewProperty;

	public static readonly DependencyProperty TabBackgroundPreviewActiveSelectedProperty;

	public static readonly DependencyProperty TabBackgroundPreviewPointerOverProperty;

	public static readonly DependencyProperty TabBorderBrushProperty;

	public static readonly DependencyProperty TabBorderBrushActiveSelectedProperty;

	public static readonly DependencyProperty TabBorderBrushInactiveSelectedProperty;

	public static readonly DependencyProperty TabBorderBrushPointerOverProperty;

	public static readonly DependencyProperty TabBorderBrushPreviewProperty;

	public static readonly DependencyProperty TabBorderBrushPreviewActiveSelectedProperty;

	public static readonly DependencyProperty TabBorderBrushPreviewPointerOverProperty;

	public static readonly DependencyProperty TabCornerRadiusProperty;

	public static readonly DependencyProperty TabEmbeddedButtonStyleProperty;

	public static readonly DependencyProperty TabForegroundProperty;

	public static readonly DependencyProperty TabForegroundActiveSelectedProperty;

	public static readonly DependencyProperty TabForegroundInactiveSelectedProperty;

	public static readonly DependencyProperty TabForegroundPointerOverProperty;

	public static readonly DependencyProperty TabForegroundPreviewProperty;

	public static readonly DependencyProperty TabForegroundPreviewActiveSelectedProperty;

	public static readonly DependencyProperty TabForegroundPreviewPointerOverProperty;

	public static readonly DependencyProperty TabOverflowBehaviorProperty;

	public static readonly DependencyProperty TabPaddingProperty;

	public static readonly DependencyProperty TabSpacingProperty;

	[CompilerGenerated]
	private EventHandler<AdvancedTabControlMenuEventArgs> WwC;

	[CompilerGenerated]
	private EventHandler Ow1;

	[CompilerGenerated]
	private EventHandler<AdvancedTabItemEventArgs> GwN;

	[CompilerGenerated]
	private EventHandler<OB> CwQ;

	[CompilerGenerated]
	private EventHandler<AdvancedTabItemEventArgs> Bwm;

	[CompilerGenerated]
	private ICommand Fwa;

	public static readonly DependencyProperty CanTabsSelectOnDragOverProperty;

	public static readonly DependencyProperty HeaderBackgroundProperty;

	public static readonly DependencyProperty TabFarSlantExtentProperty;

	public static readonly DependencyProperty TabNearSlantExtentProperty;

	public static readonly DependencyProperty UseDefaultFocusHandlingProperty;

	private static AdvancedTabControl oh;

	public bool AreScrollButtonsVisible
	{
		get
		{
			return (bool)GetValue(AreScrollButtonsVisibleProperty);
		}
		private set
		{
			SetValue(AreScrollButtonsVisibleProperty, value);
		}
	}

	public bool AreTabEmbeddedButtonsAlwaysVisible
	{
		get
		{
			return (bool)GetValue(AreTabEmbeddedButtonsAlwaysVisibleProperty);
		}
		set
		{
			SetValue(AreTabEmbeddedButtonsAlwaysVisibleProperty, value);
		}
	}

	public bool CanScrollBackward
	{
		get
		{
			return (bool)GetValue(CanScrollBackwardProperty);
		}
		private set
		{
			SetValue(CanScrollBackwardProperty, value);
		}
	}

	public bool CanScrollForward
	{
		get
		{
			return (bool)GetValue(CanScrollForwardProperty);
		}
		private set
		{
			SetValue(CanScrollForwardProperty, value);
		}
	}

	public bool CanTabsCloseOnMiddleClick
	{
		get
		{
			return (bool)GetValue(CanTabsCloseOnMiddleClickProperty);
		}
		set
		{
			SetValue(CanTabsCloseOnMiddleClickProperty, value);
		}
	}

	public bool CanTabsDrag
	{
		get
		{
			return (bool)GetValue(CanTabsDragProperty);
		}
		set
		{
			SetValue(CanTabsDragProperty, value);
		}
	}

	public bool CanTabsHighlightOnPointerOverWhenInactive
	{
		get
		{
			return (bool)GetValue(CanTabsHighlightOnPointerOverWhenInactiveProperty);
		}
		set
		{
			SetValue(CanTabsHighlightOnPointerOverWhenInactiveProperty, value);
		}
	}

	public bool CanTabsPin
	{
		get
		{
			return (bool)GetValue(CanTabsPinProperty);
		}
		set
		{
			SetValue(CanTabsPinProperty, value);
		}
	}

	public bool CanTabsPromote
	{
		get
		{
			return (bool)GetValue(CanTabsPromoteProperty);
		}
		set
		{
			SetValue(CanTabsPromoteProperty, value);
		}
	}

	public Style EmbeddedButtonStyle
	{
		get
		{
			return (Style)GetValue(EmbeddedButtonStyleProperty);
		}
		set
		{
			SetValue(EmbeddedButtonStyleProperty, value);
		}
	}

	public bool HasNewTabButton
	{
		get
		{
			return (bool)GetValue(HasNewTabButtonProperty);
		}
		set
		{
			SetValue(HasNewTabButtonProperty, value);
		}
	}

	public bool HasTabCloseButtons
	{
		get
		{
			return (bool)GetValue(HasTabCloseButtonsProperty);
		}
		set
		{
			SetValue(HasTabCloseButtonsProperty, value);
		}
	}

	public bool HasTabImages
	{
		get
		{
			return (bool)GetValue(HasTabImagesProperty);
		}
		set
		{
			SetValue(HasTabImagesProperty, value);
		}
	}

	public Brush HighlightBrushActive
	{
		get
		{
			return (Brush)GetValue(HighlightBrushActiveProperty);
		}
		set
		{
			SetValue(HighlightBrushActiveProperty, value);
		}
	}

	public Brush HighlightBrushInactive
	{
		get
		{
			return (Brush)GetValue(HighlightBrushInactiveProperty);
		}
		set
		{
			SetValue(HighlightBrushInactiveProperty, value);
		}
	}

	public Thickness HighlightThickness
	{
		get
		{
			return (Thickness)GetValue(HighlightThicknessProperty);
		}
		set
		{
			SetValue(HighlightThicknessProperty, value);
		}
	}

	public bool IsActive
	{
		get
		{
			return (bool)GetValue(IsActiveProperty);
		}
		set
		{
			SetValue(IsActiveProperty, value);
		}
	}

	public bool IsMenuButtonVisible
	{
		get
		{
			return (bool)GetValue(IsMenuButtonVisibleProperty);
		}
		private set
		{
			SetValue(IsMenuButtonVisibleProperty, value);
		}
	}

	public bool IsLayoutAnimationEnabled
	{
		get
		{
			return (bool)GetValue(IsLayoutAnimationEnabledProperty);
		}
		set
		{
			SetValue(IsLayoutAnimationEnabledProperty, value);
		}
	}

	public bool IsOverflowed
	{
		get
		{
			return (bool)GetValue(IsOverflowedProperty);
		}
		private set
		{
			SetValue(IsOverflowedProperty, value);
		}
	}

	public bool IsTabContentHorizontal
	{
		get
		{
			return (bool)GetValue(IsTabContentHorizontalProperty);
		}
		set
		{
			SetValue(IsTabContentHorizontalProperty, value);
		}
	}

	public bool IsTabKeyboardAccessEnabled
	{
		get
		{
			return (bool)GetValue(IsTabKeyboardAccessEnabledProperty);
		}
		set
		{
			SetValue(IsTabKeyboardAccessEnabledProperty, value);
		}
	}

	public bool IsTabKeyboardSwitchingEnabled
	{
		get
		{
			return (bool)GetValue(IsTabKeyboardSwitchingEnabledProperty);
		}
		set
		{
			SetValue(IsTabKeyboardSwitchingEnabledProperty, value);
		}
	}

	public bool IsTabStripVisible
	{
		get
		{
			return (bool)GetValue(IsTabStripVisibleProperty);
		}
		set
		{
			SetValue(IsTabStripVisibleProperty, value);
		}
	}

	public double MaxTabExtent
	{
		get
		{
			return (double)GetValue(MaxTabExtentProperty);
		}
		set
		{
			SetValue(MaxTabExtentProperty, value);
		}
	}

	public DataTemplate MenuButtonContentTemplate
	{
		get
		{
			return (DataTemplate)GetValue(MenuButtonContentTemplateProperty);
		}
		set
		{
			SetValue(MenuButtonContentTemplateProperty, value);
		}
	}

	public double MinTabExtent
	{
		get
		{
			return (double)GetValue(MinTabExtentProperty);
		}
		set
		{
			SetValue(MinTabExtentProperty, value);
		}
	}

	public Style NewTabButtonStyle
	{
		get
		{
			return (Style)GetValue(NewTabButtonStyleProperty);
		}
		set
		{
			SetValue(NewTabButtonStyleProperty, value);
		}
	}

	public DataTemplate OverflowMenuButtonContentTemplate
	{
		get
		{
			return (DataTemplate)GetValue(OverflowMenuButtonContentTemplateProperty);
		}
		set
		{
			SetValue(OverflowMenuButtonContentTemplateProperty, value);
		}
	}

	public ICommand RequestNewTabCommand => Bww;

	public Thickness RotatedBorderThickness
	{
		get
		{
			return (Thickness)GetValue(RotatedBorderThicknessProperty);
		}
		set
		{
			SetValue(RotatedBorderThicknessProperty, value);
		}
	}

	public Thickness RotatedHighlightThickness
	{
		get
		{
			return (Thickness)GetValue(RotatedHighlightThicknessProperty);
		}
		set
		{
			SetValue(RotatedHighlightThicknessProperty, value);
		}
	}

	public Thickness RotatedPadding
	{
		get
		{
			return (Thickness)GetValue(RotatedPaddingProperty);
		}
		set
		{
			SetValue(RotatedPaddingProperty, value);
		}
	}

	public DataTemplate ScrollBackwardButtonContentTemplate
	{
		get
		{
			return (DataTemplate)GetValue(ScrollBackwardButtonContentTemplateProperty);
		}
		set
		{
			SetValue(ScrollBackwardButtonContentTemplateProperty, value);
		}
	}

	public ICommand ScrollBackwardCommand => hw2;

	public DataTemplate ScrollForwardButtonContentTemplate
	{
		get
		{
			return (DataTemplate)GetValue(ScrollForwardButtonContentTemplateProperty);
		}
		set
		{
			SetValue(ScrollForwardButtonContentTemplateProperty, value);
		}
	}

	public ICommand ScrollForwardCommand => Hwe;

	public double ScrollOffset
	{
		get
		{
			return (double)GetValue(ScrollOffsetProperty);
		}
		private set
		{
			SetValue(ScrollOffsetProperty, value);
		}
	}

	public ICommand SelectItemCommand
	{
		[CompilerGenerated]
		get
		{
			return Fwa;
		}
		[CompilerGenerated]
		private set
		{
			Fwa = value;
		}
	}

	public Brush TabBackground
	{
		get
		{
			return (Brush)GetValue(TabBackgroundProperty);
		}
		set
		{
			SetValue(TabBackgroundProperty, value);
		}
	}

	public Brush TabBackgroundActiveSelected
	{
		get
		{
			return (Brush)GetValue(TabBackgroundActiveSelectedProperty);
		}
		set
		{
			SetValue(TabBackgroundActiveSelectedProperty, value);
		}
	}

	public Brush TabBackgroundInactiveSelected
	{
		get
		{
			return (Brush)GetValue(TabBackgroundInactiveSelectedProperty);
		}
		set
		{
			SetValue(TabBackgroundInactiveSelectedProperty, value);
		}
	}

	public Brush TabBackgroundPointerOver
	{
		get
		{
			return (Brush)GetValue(TabBackgroundPointerOverProperty);
		}
		set
		{
			SetValue(TabBackgroundPointerOverProperty, value);
		}
	}

	public Brush TabBackgroundPreview
	{
		get
		{
			return (Brush)GetValue(TabBackgroundPreviewProperty);
		}
		set
		{
			SetValue(TabBackgroundPreviewProperty, value);
		}
	}

	public Brush TabBackgroundPreviewActiveSelected
	{
		get
		{
			return (Brush)GetValue(TabBackgroundPreviewActiveSelectedProperty);
		}
		set
		{
			SetValue(TabBackgroundPreviewActiveSelectedProperty, value);
		}
	}

	public Brush TabBackgroundPreviewPointerOver
	{
		get
		{
			return (Brush)GetValue(TabBackgroundPreviewPointerOverProperty);
		}
		set
		{
			SetValue(TabBackgroundPreviewPointerOverProperty, value);
		}
	}

	public Brush TabBorderBrush
	{
		get
		{
			return (Brush)GetValue(TabBorderBrushProperty);
		}
		set
		{
			SetValue(TabBorderBrushProperty, value);
		}
	}

	public Brush TabBorderBrushActiveSelected
	{
		get
		{
			return (Brush)GetValue(TabBorderBrushActiveSelectedProperty);
		}
		set
		{
			SetValue(TabBorderBrushActiveSelectedProperty, value);
		}
	}

	public Brush TabBorderBrushInactiveSelected
	{
		get
		{
			return (Brush)GetValue(TabBorderBrushInactiveSelectedProperty);
		}
		set
		{
			SetValue(TabBorderBrushInactiveSelectedProperty, value);
		}
	}

	public Brush TabBorderBrushPointerOver
	{
		get
		{
			return (Brush)GetValue(TabBorderBrushPointerOverProperty);
		}
		set
		{
			SetValue(TabBorderBrushPointerOverProperty, value);
		}
	}

	public Brush TabBorderBrushPreview
	{
		get
		{
			return (Brush)GetValue(TabBorderBrushPreviewProperty);
		}
		set
		{
			SetValue(TabBorderBrushPreviewProperty, value);
		}
	}

	public Brush TabBorderBrushPreviewActiveSelected
	{
		get
		{
			return (Brush)GetValue(TabBorderBrushPreviewActiveSelectedProperty);
		}
		set
		{
			SetValue(TabBorderBrushPreviewActiveSelectedProperty, value);
		}
	}

	public Brush TabBorderBrushPreviewPointerOver
	{
		get
		{
			return (Brush)GetValue(TabBorderBrushPreviewPointerOverProperty);
		}
		set
		{
			SetValue(TabBorderBrushPreviewPointerOverProperty, value);
		}
	}

	public CornerRadius TabCornerRadius
	{
		get
		{
			return (CornerRadius)GetValue(TabCornerRadiusProperty);
		}
		set
		{
			SetValue(TabCornerRadiusProperty, value);
		}
	}

	public Style TabEmbeddedButtonStyle
	{
		get
		{
			return (Style)GetValue(TabEmbeddedButtonStyleProperty);
		}
		set
		{
			SetValue(TabEmbeddedButtonStyleProperty, value);
		}
	}

	public Brush TabForeground
	{
		get
		{
			return (Brush)GetValue(TabForegroundProperty);
		}
		set
		{
			SetValue(TabForegroundProperty, value);
		}
	}

	public Brush TabForegroundActiveSelected
	{
		get
		{
			return (Brush)GetValue(TabForegroundActiveSelectedProperty);
		}
		set
		{
			SetValue(TabForegroundActiveSelectedProperty, value);
		}
	}

	public Brush TabForegroundInactiveSelected
	{
		get
		{
			return (Brush)GetValue(TabForegroundInactiveSelectedProperty);
		}
		set
		{
			SetValue(TabForegroundInactiveSelectedProperty, value);
		}
	}

	public Brush TabForegroundPointerOver
	{
		get
		{
			return (Brush)GetValue(TabForegroundPointerOverProperty);
		}
		set
		{
			SetValue(TabForegroundPointerOverProperty, value);
		}
	}

	public Brush TabForegroundPreview
	{
		get
		{
			return (Brush)GetValue(TabForegroundPreviewProperty);
		}
		set
		{
			SetValue(TabForegroundPreviewProperty, value);
		}
	}

	public Brush TabForegroundPreviewActiveSelected
	{
		get
		{
			return (Brush)GetValue(TabForegroundPreviewActiveSelectedProperty);
		}
		set
		{
			SetValue(TabForegroundPreviewActiveSelectedProperty, value);
		}
	}

	public Brush TabForegroundPreviewPointerOver
	{
		get
		{
			return (Brush)GetValue(TabForegroundPreviewPointerOverProperty);
		}
		set
		{
			SetValue(TabForegroundPreviewPointerOverProperty, value);
		}
	}

	public TabOverflowBehavior TabOverflowBehavior
	{
		get
		{
			return (TabOverflowBehavior)GetValue(TabOverflowBehaviorProperty);
		}
		set
		{
			SetValue(TabOverflowBehaviorProperty, value);
		}
	}

	public Thickness TabPadding
	{
		get
		{
			return (Thickness)GetValue(TabPaddingProperty);
		}
		set
		{
			SetValue(TabPaddingProperty, value);
		}
	}

	public double TabSpacing
	{
		get
		{
			return (double)GetValue(TabSpacingProperty);
		}
		set
		{
			SetValue(TabSpacingProperty, value);
		}
	}

	public bool CanTabsSelectOnDragOver
	{
		get
		{
			return (bool)GetValue(CanTabsSelectOnDragOverProperty);
		}
		set
		{
			SetValue(CanTabsSelectOnDragOverProperty, value);
		}
	}

	public Brush HeaderBackground
	{
		get
		{
			return (Brush)GetValue(HeaderBackgroundProperty);
		}
		set
		{
			SetValue(HeaderBackgroundProperty, value);
		}
	}

	public double TabFarSlantExtent
	{
		get
		{
			return (double)GetValue(TabFarSlantExtentProperty);
		}
		set
		{
			SetValue(TabFarSlantExtentProperty, value);
		}
	}

	public double TabNearSlantExtent
	{
		get
		{
			return (double)GetValue(TabNearSlantExtentProperty);
		}
		set
		{
			SetValue(TabNearSlantExtentProperty, value);
		}
	}

	public bool UseDefaultFocusHandling
	{
		get
		{
			return (bool)GetValue(UseDefaultFocusHandlingProperty);
		}
		set
		{
			SetValue(UseDefaultFocusHandlingProperty, value);
		}
	}

	public event EventHandler<AdvancedTabControlMenuEventArgs> MenuOpening
	{
		[CompilerGenerated]
		add
		{
			EventHandler<AdvancedTabControlMenuEventArgs> eventHandler = WwC;
			EventHandler<AdvancedTabControlMenuEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<AdvancedTabControlMenuEventArgs> value2 = (EventHandler<AdvancedTabControlMenuEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref WwC, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<AdvancedTabControlMenuEventArgs> eventHandler = WwC;
			EventHandler<AdvancedTabControlMenuEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<AdvancedTabControlMenuEventArgs> value2 = (EventHandler<AdvancedTabControlMenuEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref WwC, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler NewTabRequested
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = Ow1;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref Ow1, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = Ow1;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref Ow1, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<AdvancedTabItemEventArgs> TabClosing
	{
		[CompilerGenerated]
		add
		{
			EventHandler<AdvancedTabItemEventArgs> eventHandler = GwN;
			EventHandler<AdvancedTabItemEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<AdvancedTabItemEventArgs> value2 = (EventHandler<AdvancedTabItemEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref GwN, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<AdvancedTabItemEventArgs> eventHandler = GwN;
			EventHandler<AdvancedTabItemEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<AdvancedTabItemEventArgs> value2 = (EventHandler<AdvancedTabItemEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref GwN, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<AdvancedTabItemEventArgs> TabDragReordered
	{
		[CompilerGenerated]
		add
		{
			EventHandler<AdvancedTabItemEventArgs> eventHandler = Bwm;
			EventHandler<AdvancedTabItemEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<AdvancedTabItemEventArgs> value2 = (EventHandler<AdvancedTabItemEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref Bwm, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<AdvancedTabItemEventArgs> eventHandler = Bwm;
			EventHandler<AdvancedTabItemEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<AdvancedTabItemEventArgs> value2 = (EventHandler<AdvancedTabItemEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref Bwm, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal void Rdy(EventHandler<OB> value)
	{
		EventHandler<OB> eventHandler = CwQ;
		EventHandler<OB> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<OB> value2 = (EventHandler<OB>)Delegate.Combine(eventHandler2, value);
			eventHandler = Interlocked.CompareExchange(ref CwQ, value2, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal void Odo(EventHandler<OB> value)
	{
		EventHandler<OB> eventHandler = CwQ;
		EventHandler<OB> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<OB> value2 = (EventHandler<OB>)Delegate.Remove(eventHandler2, value);
			eventHandler = Interlocked.CompareExchange(ref CwQ, value2, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline")]
	static AdvancedTabControl()
	{
		IVH.CecNqz();
		AreScrollButtonsVisibleProperty = DependencyProperty.Register(vVK.ssH(184), typeof(bool), typeof(AdvancedTabControl), new PropertyMetadata(false));
		AreTabEmbeddedButtonsAlwaysVisibleProperty = DependencyProperty.Register(vVK.ssH(234), typeof(bool), typeof(AdvancedTabControl), new PropertyMetadata(false));
		CanScrollBackwardProperty = DependencyProperty.Register(vVK.ssH(306), typeof(bool), typeof(AdvancedTabControl), new PropertyMetadata(false, vy));
		CanScrollForwardProperty = DependencyProperty.Register(vVK.ssH(344), typeof(bool), typeof(AdvancedTabControl), new PropertyMetadata(false, Ao));
		CanTabsCloseOnMiddleClickProperty = DependencyProperty.Register(vVK.ssH(380), typeof(bool), typeof(AdvancedTabControl), new PropertyMetadata(true));
		CanTabsDragProperty = DependencyProperty.Register(vVK.ssH(434), typeof(bool), typeof(AdvancedTabControl), new PropertyMetadata(false));
		CanTabsHighlightOnPointerOverWhenInactiveProperty = DependencyProperty.Register(vVK.ssH(460), typeof(bool), typeof(AdvancedTabControl), new PropertyMetadata(false));
		CanTabsPinProperty = DependencyProperty.Register(vVK.ssH(546), typeof(bool), typeof(AdvancedTabControl), new PropertyMetadata(false));
		CanTabsPromoteProperty = DependencyProperty.Register(vVK.ssH(570), typeof(bool), typeof(AdvancedTabControl), new PropertyMetadata(true));
		EmbeddedButtonStyleProperty = DependencyProperty.Register(vVK.ssH(602), typeof(Style), typeof(AdvancedTabControl), new PropertyMetadata(null));
		HasNewTabButtonProperty = DependencyProperty.Register(vVK.ssH(644), typeof(bool), typeof(AdvancedTabControl), new PropertyMetadata(false, Udw));
		HasTabCloseButtonsProperty = DependencyProperty.Register(vVK.ssH(678), typeof(bool), typeof(AdvancedTabControl), new PropertyMetadata(false, Vt));
		HasTabImagesProperty = DependencyProperty.Register(vVK.ssH(718), typeof(bool), typeof(AdvancedTabControl), new PropertyMetadata(false, Du));
		HighlightBrushActiveProperty = DependencyProperty.Register(vVK.ssH(746), typeof(Brush), typeof(AdvancedTabControl), new PropertyMetadata(null));
		HighlightBrushInactiveProperty = DependencyProperty.Register(vVK.ssH(790), typeof(Brush), typeof(AdvancedTabControl), new PropertyMetadata(null));
		HighlightThicknessProperty = DependencyProperty.Register(vVK.ssH(838), typeof(Thickness), typeof(AdvancedTabControl), new PropertyMetadata(new Thickness(0.0)));
		IsActiveProperty = DependencyProperty.Register(vVK.ssH(878), typeof(bool), typeof(AdvancedTabControl), new PropertyMetadata(false, sz));
		IsMenuButtonVisibleProperty = DependencyProperty.Register(vVK.ssH(898), typeof(bool), typeof(AdvancedTabControl), new PropertyMetadata(false));
		IsLayoutAnimationEnabledProperty = DependencyProperty.Register(vVK.ssH(940), typeof(bool), typeof(AdvancedTabControl), new PropertyMetadata(true));
		IsOverflowedProperty = DependencyProperty.Register(vVK.ssH(992), typeof(bool), typeof(AdvancedTabControl), new PropertyMetadata(false, adi));
		IsTabContentHorizontalProperty = DependencyProperty.Register(vVK.ssH(1020), typeof(bool), typeof(AdvancedTabControl), new PropertyMetadata(true));
		IsTabKeyboardAccessEnabledProperty = DependencyProperty.Register(vVK.ssH(1068), typeof(bool), typeof(AdvancedTabControl), new PropertyMetadata(true));
		IsTabKeyboardSwitchingEnabledProperty = DependencyProperty.Register(vVK.ssH(1124), typeof(bool), typeof(AdvancedTabControl), new PropertyMetadata(true));
		IsTabStripVisibleProperty = DependencyProperty.Register(vVK.ssH(1186), typeof(bool), typeof(AdvancedTabControl), new PropertyMetadata(true, Xdd));
		MaxTabExtentProperty = DependencyProperty.Register(vVK.ssH(1224), typeof(double), typeof(AdvancedTabControl), new PropertyMetadata(260.0, Udw));
		MenuButtonContentTemplateProperty = DependencyProperty.Register(vVK.ssH(1252), typeof(DataTemplate), typeof(AdvancedTabControl), new PropertyMetadata(null));
		MinTabExtentProperty = DependencyProperty.Register(vVK.ssH(1306), typeof(double), typeof(AdvancedTabControl), new PropertyMetadata(30.0, Udw));
		OverflowMenuButtonContentTemplateProperty = DependencyProperty.Register(vVK.ssH(1334), typeof(DataTemplate), typeof(AdvancedTabControl), new PropertyMetadata(null));
		NewTabButtonStyleProperty = DependencyProperty.Register(vVK.ssH(1404), typeof(Style), typeof(AdvancedTabControl), new PropertyMetadata(null));
		RotatedBorderThicknessProperty = DependencyProperty.Register(vVK.ssH(1442), typeof(Thickness), typeof(AdvancedTabControl), new PropertyMetadata(new Thickness(0.0)));
		RotatedHighlightThicknessProperty = DependencyProperty.Register(vVK.ssH(1490), typeof(Thickness), typeof(AdvancedTabControl), new PropertyMetadata(new Thickness(0.0)));
		RotatedPaddingProperty = DependencyProperty.Register(vVK.ssH(1544), typeof(Thickness), typeof(AdvancedTabControl), new PropertyMetadata(new Thickness(0.0)));
		ScrollBackwardButtonContentTemplateProperty = DependencyProperty.Register(vVK.ssH(1576), typeof(DataTemplate), typeof(AdvancedTabControl), new PropertyMetadata(null));
		ScrollForwardButtonContentTemplateProperty = DependencyProperty.Register(vVK.ssH(1650), typeof(DataTemplate), typeof(AdvancedTabControl), new PropertyMetadata(null));
		ScrollOffsetProperty = DependencyProperty.Register(vVK.ssH(1722), typeof(double), typeof(AdvancedTabControl), new PropertyMetadata(0.0));
		TabBackgroundProperty = DependencyProperty.Register(vVK.ssH(1750), typeof(Brush), typeof(AdvancedTabControl), new PropertyMetadata(null));
		TabBackgroundActiveSelectedProperty = DependencyProperty.Register(vVK.ssH(1780), typeof(Brush), typeof(AdvancedTabControl), new PropertyMetadata(null));
		TabBackgroundInactiveSelectedProperty = DependencyProperty.Register(vVK.ssH(1838), typeof(Brush), typeof(AdvancedTabControl), new PropertyMetadata(null));
		TabBackgroundPointerOverProperty = DependencyProperty.Register(vVK.ssH(1900), typeof(Brush), typeof(AdvancedTabControl), new PropertyMetadata(null));
		TabBackgroundPreviewProperty = DependencyProperty.Register(vVK.ssH(1952), typeof(Brush), typeof(AdvancedTabControl), new PropertyMetadata(null));
		TabBackgroundPreviewActiveSelectedProperty = DependencyProperty.Register(vVK.ssH(1996), typeof(Brush), typeof(AdvancedTabControl), new PropertyMetadata(null));
		TabBackgroundPreviewPointerOverProperty = DependencyProperty.Register(vVK.ssH(2068), typeof(Brush), typeof(AdvancedTabControl), new PropertyMetadata(null));
		TabBorderBrushProperty = DependencyProperty.Register(vVK.ssH(2134), typeof(Brush), typeof(AdvancedTabControl), new PropertyMetadata(null));
		TabBorderBrushActiveSelectedProperty = DependencyProperty.Register(vVK.ssH(2166), typeof(Brush), typeof(AdvancedTabControl), new PropertyMetadata(null, dd2));
		TabBorderBrushInactiveSelectedProperty = DependencyProperty.Register(vVK.ssH(2226), typeof(Brush), typeof(AdvancedTabControl), new PropertyMetadata(null, dd2));
		TabBorderBrushPointerOverProperty = DependencyProperty.Register(vVK.ssH(2290), typeof(Brush), typeof(AdvancedTabControl), new PropertyMetadata(null));
		TabBorderBrushPreviewProperty = DependencyProperty.Register(vVK.ssH(2344), typeof(Brush), typeof(AdvancedTabControl), new PropertyMetadata(null));
		TabBorderBrushPreviewActiveSelectedProperty = DependencyProperty.Register(vVK.ssH(2390), typeof(Brush), typeof(AdvancedTabControl), new PropertyMetadata(null, dd2));
		TabBorderBrushPreviewPointerOverProperty = DependencyProperty.Register(vVK.ssH(2464), typeof(Brush), typeof(AdvancedTabControl), new PropertyMetadata(null));
		TabCornerRadiusProperty = DependencyProperty.Register(vVK.ssH(2532), typeof(CornerRadius), typeof(AdvancedTabControl), new PropertyMetadata(default(CornerRadius)));
		TabEmbeddedButtonStyleProperty = DependencyProperty.Register(vVK.ssH(2566), typeof(Style), typeof(AdvancedTabControl), new PropertyMetadata(null));
		TabForegroundProperty = DependencyProperty.Register(vVK.ssH(2614), typeof(Brush), typeof(AdvancedTabControl), new PropertyMetadata(null));
		TabForegroundActiveSelectedProperty = DependencyProperty.Register(vVK.ssH(2644), typeof(Brush), typeof(AdvancedTabControl), new PropertyMetadata(null));
		TabForegroundInactiveSelectedProperty = DependencyProperty.Register(vVK.ssH(2702), typeof(Brush), typeof(AdvancedTabControl), new PropertyMetadata(null));
		TabForegroundPointerOverProperty = DependencyProperty.Register(vVK.ssH(2764), typeof(Brush), typeof(AdvancedTabControl), new PropertyMetadata(null));
		TabForegroundPreviewProperty = DependencyProperty.Register(vVK.ssH(2816), typeof(Brush), typeof(AdvancedTabControl), new PropertyMetadata(null));
		TabForegroundPreviewActiveSelectedProperty = DependencyProperty.Register(vVK.ssH(2860), typeof(Brush), typeof(AdvancedTabControl), new PropertyMetadata(null));
		TabForegroundPreviewPointerOverProperty = DependencyProperty.Register(vVK.ssH(2932), typeof(Brush), typeof(AdvancedTabControl), new PropertyMetadata(null));
		TabOverflowBehaviorProperty = DependencyProperty.Register(vVK.ssH(2998), typeof(TabOverflowBehavior), typeof(AdvancedTabControl), new PropertyMetadata(TabOverflowBehavior.Shrink, hde));
		TabPaddingProperty = DependencyProperty.Register(vVK.ssH(3040), typeof(Thickness), typeof(AdvancedTabControl), new PropertyMetadata(new Thickness(5.0, 2.0, 5.0, 2.0), Udw));
		TabSpacingProperty = DependencyProperty.Register(vVK.ssH(3064), typeof(double), typeof(AdvancedTabControl), new PropertyMetadata(0.0, Udw));
		CanTabsSelectOnDragOverProperty = DependencyProperty.Register(vVK.ssH(3088), typeof(bool), typeof(AdvancedTabControl), new PropertyMetadata(true));
		HeaderBackgroundProperty = DependencyProperty.Register(vVK.ssH(3138), typeof(Brush), typeof(AdvancedTabControl), new PropertyMetadata(null));
		TabFarSlantExtentProperty = DependencyProperty.Register(vVK.ssH(3174), typeof(double), typeof(AdvancedTabControl), new PropertyMetadata(0.0));
		TabNearSlantExtentProperty = DependencyProperty.Register(vVK.ssH(3212), typeof(double), typeof(AdvancedTabControl), new PropertyMetadata(0.0));
		UseDefaultFocusHandlingProperty = DependencyProperty.Register(vVK.ssH(3252), typeof(bool), typeof(AdvancedTabControl), new PropertyMetadata(true));
		TabControl.TabStripPlacementProperty.OverrideMetadata(typeof(AdvancedTabControl), new FrameworkPropertyMetadata(Dock.Top, cdI));
	}

	public AdvancedTabControl()
	{
		IVH.CecNqz();
		base._002Ector();
		base.DefaultStyleKey = typeof(AdvancedTabControl);
		N4();
		bZ();
	}

	private void BU(double P_0)
	{
		if (fwd != null)
		{
			fwd.AnimateDoubleProperty(vVK.ssH(3302), Math.Min(1.0, Math.Max(0.0, P_0)));
		}
	}

	private void Ic(double P_0, bool P_1)
	{
		Rwk = Math.Min(TdR(), Math.Max(odL(), P_0));
		double num = Vdl();
		this.AnimateDoubleProperty(vVK.ssH(1722), Rwk, P_1 ? 0.0 : num);
		if (fwd != null)
		{
			Orientation num2 = zdc();
			string text = ((num2 == Orientation.Horizontal) ? vVK.ssH(3326) : vVK.ssH(3320));
			string text2 = ((num2 == Orientation.Horizontal) ? vVK.ssH(3320) : vVK.ssH(3326));
			fwd.AnimateDoubleProperty(vVK.ssH(3332) + text + vVK.ssH(3504), Rwk, P_1 ? 0.0 : num);
			fwd.AnimateDoubleProperty(vVK.ssH(3332) + text2 + vVK.ssH(3504), 0.0, 0.0);
		}
		EdB();
	}

	[SpecialName]
	internal double Vdl()
	{
		if (!IsLayoutAnimationEnabled)
		{
			return 0.0;
		}
		return 0.2;
	}

	private void N4()
	{
		Kdu = new InputAdapter(this);
		Kdu.PointerWheelChanged += RdG;
		Kdu.AttachedEventKinds = InputAdapterEventKinds.PointerWheelChanged;
	}

	internal bool Yj()
	{
		if (Math.Min(TdR(), Math.Max(odL(), Rwk)) != Rwk)
		{
			Ic(Rwk, _0020: true);
			return true;
		}
		return false;
	}

	private void bZ()
	{
		Bww = new DelegateCommand<object>(delegate
		{
			Mda();
		});
		hw2 = new DelegateCommand<object>(delegate
		{
			if (lwI != null)
			{
				Ic(Rwk + lwI.POc() * 0.9, _0020: false);
			}
		}, (object P_0) => CanScrollBackward);
		Hwe = new DelegateCommand<object>(delegate
		{
			if (lwI != null)
			{
				Ic(Rwk - lwI.POc() * 0.9, _0020: false);
			}
		}, (object P_0) => CanScrollForward);
		SelectItemCommand = new DelegateCommand<object>(delegate(object P_0)
		{
			if (base.Items.IndexOf(P_0) != -1)
			{
				if (base.SelectedItem == P_0)
				{
					qb(P_0);
				}
				else
				{
					base.SelectedItem = P_0;
				}
				sH();
			}
		});
	}

	[SpecialName]
	internal vVB Edv()
	{
		return rdz;
	}

	internal void qb(object P_0)
	{
		if (P_0 == null)
		{
			return;
		}
		int num = base.Items.IndexOf(P_0);
		if (num != -1)
		{
			AdvancedTabItem advancedTabItem = M0(num);
			if (advancedTabItem != null)
			{
				NA(advancedTabItem);
			}
		}
	}

	private void NA(AdvancedTabItem P_0, bool P_1 = false)
	{
		if (P_0 != null && lwI != null)
		{
			double num = lwI.rOf(P_0);
			if (num != 0.0)
			{
				Ic(Rwk + num, P_1);
			}
		}
	}

	internal void sH()
	{
		if (wwG != null)
		{
			cP.Dl4(wwG);
		}
	}

	internal AdvancedTabItem M0(int P_0)
	{
		if (P_0 < 0 || P_0 >= base.Items.Count)
		{
			return null;
		}
		AdvancedTabItem advancedTabItem = base.Items[P_0] as AdvancedTabItem;
		if (advancedTabItem == null)
		{
			advancedTabItem = base.ItemContainerGenerator.ContainerFromIndex(P_0) as AdvancedTabItem;
		}
		return advancedTabItem;
	}

	private void uh(bool P_0 = false)
	{
		if (edP() != null)
		{
			edP().InvalidateArrange();
			if (P_0)
			{
				edP().UpdateLayout();
			}
		}
	}

	private void ig()
	{
		if (edP() != null)
		{
			edP().InvalidateMeasure();
		}
	}

	[SpecialName]
	private static double TdR()
	{
		return 0.0;
	}

	[SpecialName]
	private double odL()
	{
		if (lwI != null)
		{
			double num = lwI.POc();
			double num2 = lwI.aTd();
			return Math.Min(0.0, num - num2);
		}
		return 0.0;
	}

	[SpecialName]
	internal NewTabButton od6()
	{
		return fwd;
	}

	[SpecialName]
	private void nd9(NewTabButton value)
	{
		if (fwd != value)
		{
			if (fwd != null)
			{
				fwd.RenderTransform = null;
			}
			fwd = value;
			if (fwd != null)
			{
				fwd.RenderTransform = new TransformGroup
				{
					Children = 
					{
						(Transform)new TranslateTransform(),
						(Transform)new TranslateTransform()
					}
				};
			}
		}
	}

	internal void iX(AdvancedTabItem P_0, Point? P_1)
	{
		AdvancedTabControlMenuEventArgs e = new AdvancedTabControlMenuEventArgs
		{
			TabItem = P_0
		};
		e.Menu = P_0?.ContextMenu;
		bdC(e);
		ContextMenu menu = e.Menu;
		if (menu != null && menu.Items.Count > 0)
		{
			if (P_1.HasValue)
			{
				menu.PlacementTarget = P_0;
				menu.Placement = PlacementMode.MousePoint;
			}
			else
			{
				menu.PlacementTarget = P_0;
				menu.Placement = PlacementMode.Bottom;
			}
			menu.IsOpen = true;
		}
	}

	internal static void F5(AdvancedTabItem P_0, InputPointerButtonEventArgs P_1)
	{
		vVB.hSW(P_0, P_1);
	}

	private static void vy(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((AdvancedTabControl)P_0).hw2.RaiseCanExecuteChanged();
	}

	private static void Ao(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((AdvancedTabControl)P_0).Hwe.RaiseCanExecuteChanged();
	}

	private static void Vt(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		AdvancedTabControl advancedTabControl = (AdvancedTabControl)P_0;
		for (int num = advancedTabControl.Items.Count - 1; num >= 0; num--)
		{
			advancedTabControl.M0(num)?.pws();
		}
	}

	private static void Du(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		AdvancedTabControl advancedTabControl = (AdvancedTabControl)P_0;
		for (int num = advancedTabControl.Items.Count - 1; num >= 0; num--)
		{
			advancedTabControl.M0(num)?.awq();
		}
	}

	private static void sz(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		AdvancedTabControl advancedTabControl = (AdvancedTabControl)P_0;
		advancedTabControl.Cdn(_0020: true);
		if (advancedTabControl.SelectedItem != null && advancedTabControl.ItemContainerGenerator.ContainerFromItem(advancedTabControl.SelectedItem) is AdvancedTabItem advancedTabItem)
		{
			advancedTabItem.ywf();
		}
	}

	private static void adi(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
	}

	private static void Xdd(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((AdvancedTabControl)P_0).Cdn(_0020: false);
	}

	private static void Udw(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((AdvancedTabControl)P_0).ig();
	}

	private static void dd2(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		_003C_003Ec__DisplayClass132_0 CS_0024_003C_003E8__locals3 = new _003C_003Ec__DisplayClass132_0();
		CS_0024_003C_003E8__locals3.oS6 = (AdvancedTabControl)P_0;
		CS_0024_003C_003E8__locals3.oS6.Dispatcher.BeginInvoke(DispatcherPriority.DataBind, (Action)delegate
		{
			CS_0024_003C_003E8__locals3.oS6.UpdateHighlightBrushes();
		});
	}

	private static void hde(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		AdvancedTabControl obj = (AdvancedTabControl)P_0;
		obj.mdW();
		obj.ig();
		obj.Ic(0.0, _0020: true);
	}

	private void RdG(object P_0, InputPointerWheelEventArgs P_1)
	{
		if (P_1 != null && !P_1.Handled && lwI != null && P_1.IsPositionOver(lwI))
		{
			TabOverflowBehavior tabOverflowBehavior = TabOverflowBehavior;
			if ((uint)tabOverflowBehavior <= 1u || (uint)(tabOverflowBehavior - 4) <= 1u)
			{
				int delta = P_1.Delta;
				int singleUnitDelta = P_1.SingleUnitDelta;
				int num = ((delta > 0) ? Math.Max(singleUnitDelta, delta) : Math.Min(-singleUnitDelta, delta)) / singleUnitDelta;
				Ic(Rwk + (double)num * 50.0, _0020: false);
				P_1.Handled = true;
			}
		}
	}

	private static void cdI(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		AdvancedTabControl obj = (AdvancedTabControl)P_0;
		obj.Cdn(_0020: false);
		obj.BdJ();
		obj.odK();
	}

	internal void jdk()
	{
		if (iwi != null)
		{
			iwi.IsPopupOpen = true;
		}
	}

	private void bdC(AdvancedTabControlMenuEventArgs P_0)
	{
		WwC?.Invoke(this, P_0);
	}

	private void Gd1()
	{
		Ow1?.Invoke(this, EventArgs.Empty);
	}

	internal bool fdN(AdvancedTabItem P_0)
	{
		AdvancedTabItemEventArgs e = new AdvancedTabItemEventArgs
		{
			TabItem = P_0
		};
		GwN?.Invoke(this, e);
		return e.Cancel;
	}

	private Action ddQ(InputPointerEventArgs P_0, AdvancedTabItem P_1, Point P_2)
	{
		OB oB = new OB();
		oB.t2C(P_0);
		oB.TabItem = P_1;
		oB.o2Q(P_2);
		OB oB2 = oB;
		CwQ?.Invoke(this, oB2);
		if (!oB2.Cancel)
		{
			return null;
		}
		return oB2.R2a() ?? ((Action)delegate
		{
		});
	}

	private void tdm(AdvancedTabItem P_0)
	{
		AdvancedTabItemEventArgs e = new AdvancedTabItemEventArgs
		{
			TabItem = P_0
		};
		Bwm?.Invoke(this, e);
	}

	private void Mda()
	{
		if (!base.IsKeyboardFocusWithin)
		{
			sH();
		}
		Gd1();
	}

	[SpecialName]
	private ContentPresenter bdp()
	{
		return wwG;
	}

	[SpecialName]
	private void Yds(ContentPresenter value)
	{
		if (wwG != value)
		{
			wwG = value;
		}
	}

	[SpecialName]
	internal AdvancedTabItem XdF()
	{
		AdvancedTabItem result = null;
		object selectedItem = base.SelectedItem;
		if (selectedItem != null)
		{
			result = base.ItemContainerGenerator.ContainerFromItem(selectedItem) as AdvancedTabItem;
		}
		return result;
	}

	[SpecialName]
	internal AdvancedTabPanel edP()
	{
		return lwI;
	}

	[SpecialName]
	internal void gdf(AdvancedTabPanel value)
	{
		if (lwI != value)
		{
			if (lwI != null)
			{
				BindingOperations.ClearBinding(lwI, FrameworkElement.MarginProperty);
				BindingOperations.ClearBinding(lwI, AdvancedTabPanel.OrientationProperty);
			}
			lwI = value;
			if (lwI != null)
			{
				BdJ();
				AdvancedTabPanel element = lwI;
				DependencyProperty orientationProperty = AdvancedTabPanel.OrientationProperty;
				string sourcePropertyName = vVK.ssH(3510);
				t5 t = new t5();
				t.zE4(_0020: true);
				element.BindToProperty(orientationProperty, this, sourcePropertyName, BindingMode.OneWay, t);
			}
		}
	}

	[SpecialName]
	internal Orientation zdc()
	{
		Dock tabStripPlacement = base.TabStripPlacement;
		if (tabStripPlacement == Dock.Top || tabStripPlacement == Dock.Bottom)
		{
			return Orientation.Horizontal;
		}
		return Orientation.Vertical;
	}

	private void mdW()
	{
		TabOverflowBehavior tabOverflowBehavior = TabOverflowBehavior;
		if ((uint)(tabOverflowBehavior - 4) <= 1u)
		{
			AreScrollButtonsVisible = true;
			int num = 0;
			if (!hL())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			EdB();
		}
		else
		{
			AreScrollButtonsVisible = false;
		}
		switch (TabOverflowBehavior)
		{
		default:
			IsMenuButtonVisible = false;
			break;
		case TabOverflowBehavior.Menu:
		case TabOverflowBehavior.ShrinkWithMenu:
		case TabOverflowBehavior.ScrollWithMenu:
			IsMenuButtonVisible = true;
			break;
		}
	}

	internal void EdB()
	{
		double num = odL();
		double num2 = TdR();
		TabOverflowBehavior tabOverflowBehavior = TabOverflowBehavior;
		if ((uint)(tabOverflowBehavior - 4) <= 1u)
		{
			CanScrollBackward = Rwk < num2;
			CanScrollForward = Rwk > num;
		}
		IsOverflowed = num != num2;
	}

	private void odK()
	{
		Mr converter = new Mr
		{
			TabStripPlacement = base.TabStripPlacement
		};
		this.BindToProperty(RotatedBorderThicknessProperty, this, vVK.ssH(3548), BindingMode.OneWay, converter);
		this.BindToProperty(RotatedHighlightThicknessProperty, this, vVK.ssH(838), BindingMode.OneWay, converter);
		this.BindToProperty(RotatedPaddingProperty, this, vVK.ssH(3582), BindingMode.OneWay, converter);
	}

	private void BdJ()
	{
		Sides sides = ((zdc() == Orientation.Horizontal) ? Sides.Left : Sides.Top);
		if (lwI != null)
		{
			lwI.BindToProperty(FrameworkElement.MarginProperty, this, vVK.ssH(1722), BindingMode.OneWay, new ActiproSoftware.Windows.Data.ThicknessConverter(), sides);
		}
	}

	private void Cdn(bool P_0)
	{
		switch (base.TabStripPlacement)
		{
		default:
			VisualStateManager.GoToState(this, vVK.ssH(3690), P_0);
			break;
		case Dock.Bottom:
			VisualStateManager.GoToState(this, vVK.ssH(3600), P_0);
			break;
		case Dock.Left:
			VisualStateManager.GoToState(this, vVK.ssH(3632), P_0);
			break;
		case Dock.Right:
			VisualStateManager.GoToState(this, vVK.ssH(3660), P_0);
			break;
		}
	}

	protected override Size ArrangeOverride(Size finalSize)
	{
		Size result = base.ArrangeOverride(finalSize);
		if (ScrollOffset != Rwk)
		{
			return result;
		}
		Ic(Rwk, _0020: true);
		return result;
	}

	protected override void ClearContainerForItemOverride(DependencyObject element, object item)
	{
		base.ClearContainerForItemOverride(element, item);
		if (element is AdvancedTabItem advancedTabItem && (advancedTabItem != item || !advancedTabItem.owZ()))
		{
			BindingOperations.ClearBinding(advancedTabItem, Control.BackgroundProperty);
			BindingOperations.ClearBinding(advancedTabItem, AdvancedTabItem.BackgroundActiveSelectedProperty);
			BindingOperations.ClearBinding(advancedTabItem, AdvancedTabItem.BackgroundInactiveSelectedProperty);
			BindingOperations.ClearBinding(advancedTabItem, AdvancedTabItem.BackgroundPointerOverProperty);
			BindingOperations.ClearBinding(advancedTabItem, AdvancedTabItem.BackgroundPreviewProperty);
			BindingOperations.ClearBinding(advancedTabItem, AdvancedTabItem.BackgroundPreviewActiveSelectedProperty);
			BindingOperations.ClearBinding(advancedTabItem, AdvancedTabItem.BackgroundPreviewPointerOverProperty);
			BindingOperations.ClearBinding(advancedTabItem, Control.BorderBrushProperty);
			BindingOperations.ClearBinding(advancedTabItem, AdvancedTabItem.BorderBrushActiveSelectedProperty);
			BindingOperations.ClearBinding(advancedTabItem, AdvancedTabItem.BorderBrushInactiveSelectedProperty);
			BindingOperations.ClearBinding(advancedTabItem, AdvancedTabItem.BorderBrushPointerOverProperty);
			BindingOperations.ClearBinding(advancedTabItem, AdvancedTabItem.BorderBrushPreviewProperty);
			BindingOperations.ClearBinding(advancedTabItem, AdvancedTabItem.BorderBrushPreviewActiveSelectedProperty);
			BindingOperations.ClearBinding(advancedTabItem, AdvancedTabItem.BorderBrushPreviewPointerOverProperty);
			BindingOperations.ClearBinding(advancedTabItem, Control.ForegroundProperty);
			BindingOperations.ClearBinding(advancedTabItem, AdvancedTabItem.ForegroundActiveSelectedProperty);
			BindingOperations.ClearBinding(advancedTabItem, AdvancedTabItem.ForegroundInactiveSelectedProperty);
			BindingOperations.ClearBinding(advancedTabItem, AdvancedTabItem.ForegroundPointerOverProperty);
			BindingOperations.ClearBinding(advancedTabItem, AdvancedTabItem.ForegroundPreviewProperty);
			BindingOperations.ClearBinding(advancedTabItem, AdvancedTabItem.ForegroundPreviewActiveSelectedProperty);
			BindingOperations.ClearBinding(advancedTabItem, AdvancedTabItem.ForegroundPreviewPointerOverProperty);
			BindingOperations.ClearBinding(advancedTabItem, AdvancedTabItem.AreEmbeddedButtonsAlwaysVisibleProperty);
			BindingOperations.ClearBinding(advancedTabItem, AdvancedTabItem.CanHighlightOnPointerOverWhenInactiveProperty);
			BindingOperations.ClearBinding(advancedTabItem, AdvancedTabItem.CanPinProperty);
			BindingOperations.ClearBinding(advancedTabItem, AdvancedTabItem.CanPromoteProperty);
			BindingOperations.ClearBinding(advancedTabItem, AdvancedTabItem.ContextContentProperty);
			BindingOperations.ClearBinding(advancedTabItem, AdvancedTabItem.CornerRadiusProperty);
			BindingOperations.ClearBinding(advancedTabItem, AdvancedTabItem.EmbeddedButtonStyleProperty);
			BindingOperations.ClearBinding(advancedTabItem, AdvancedTabItem.FarSlantExtentProperty);
			BindingOperations.ClearBinding(advancedTabItem, AdvancedTabItem.IsContentHorizontalProperty);
			BindingOperations.ClearBinding(advancedTabItem, AdvancedTabItem.NearSlantExtentProperty);
			BindingOperations.ClearBinding(advancedTabItem, Control.PaddingProperty);
		}
	}

	protected override DependencyObject GetContainerForItemOverride()
	{
		return new AdvancedTabItem();
	}

	protected override bool IsItemItsOwnContainerOverride(object item)
	{
		return item is AdvancedTabItem;
	}

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		gdf(null);
		SdX(GetTemplateChild(vVK.ssH(3716)) as PopupButton);
		nd9(GetTemplateChild(vVK.ssH(3750)) as NewTabButton);
		Yds(GetTemplateChild(vVK.ssH(3788)) as ContentPresenter);
		odK();
		Cdn(_0020: false);
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		return new AdvancedTabControlAutomationPeer(this);
	}

	protected override void PrepareContainerForItemOverride(DependencyObject element, object item)
	{
		base.PrepareContainerForItemOverride(element, item);
		if (!(element is AdvancedTabItem advancedTabItem) || (advancedTabItem == item && advancedTabItem.owZ()))
		{
			return;
		}
		advancedTabItem.pws();
		advancedTabItem.awq();
		if (IsLayoutAnimationEnabled)
		{
			advancedTabItem.IsLoadAnimationEnabled = true;
		}
		advancedTabItem.BindToProperty(Control.BackgroundProperty, this, vVK.ssH(1750), BindingMode.OneWay);
		advancedTabItem.BindToProperty(AdvancedTabItem.BackgroundActiveSelectedProperty, this, vVK.ssH(1780), BindingMode.OneWay);
		int num = 2;
		if (!hL())
		{
			goto IL_0005;
		}
		goto IL_0009;
		IL_0009:
		UIElement uIElement = default(UIElement);
		while (true)
		{
			switch (num)
			{
			default:
				if (base.SelectedItem == item)
				{
					advancedTabItem.IsSelected = true;
				}
				return;
			case 3:
				advancedTabItem.BindToProperty(Control.ForegroundProperty, this, vVK.ssH(2614), BindingMode.OneWay);
				advancedTabItem.BindToProperty(AdvancedTabItem.ForegroundActiveSelectedProperty, this, vVK.ssH(2644), BindingMode.OneWay);
				advancedTabItem.BindToProperty(AdvancedTabItem.ForegroundInactiveSelectedProperty, this, vVK.ssH(2702), BindingMode.OneWay);
				advancedTabItem.BindToProperty(AdvancedTabItem.ForegroundPointerOverProperty, this, vVK.ssH(2764), BindingMode.OneWay);
				advancedTabItem.BindToProperty(AdvancedTabItem.ForegroundPreviewProperty, this, vVK.ssH(2816), BindingMode.OneWay);
				advancedTabItem.BindToProperty(AdvancedTabItem.ForegroundPreviewActiveSelectedProperty, this, vVK.ssH(2860), BindingMode.OneWay);
				advancedTabItem.BindToProperty(AdvancedTabItem.ForegroundPreviewPointerOverProperty, this, vVK.ssH(2932), BindingMode.OneWay);
				advancedTabItem.BindToProperty(AdvancedTabItem.AreEmbeddedButtonsAlwaysVisibleProperty, this, vVK.ssH(234), BindingMode.OneWay);
				advancedTabItem.BindToProperty(AdvancedTabItem.CanHighlightOnPointerOverWhenInactiveProperty, this, vVK.ssH(460), BindingMode.OneWay);
				num = 1;
				if (Dl() == null)
				{
					continue;
				}
				break;
			case 1:
				advancedTabItem.BindToProperty(AdvancedTabItem.CanPinProperty, this, vVK.ssH(546), BindingMode.OneWay);
				advancedTabItem.BindToProperty(AdvancedTabItem.CanPromoteProperty, this, vVK.ssH(570), BindingMode.OneWay);
				advancedTabItem.BindToProperty(AdvancedTabItem.CornerRadiusProperty, this, vVK.ssH(2532), BindingMode.OneWay);
				advancedTabItem.BindToProperty(AdvancedTabItem.EmbeddedButtonStyleProperty, this, vVK.ssH(2566), BindingMode.OneWay);
				advancedTabItem.BindToProperty(AdvancedTabItem.IsContentHorizontalProperty, this, vVK.ssH(1020), BindingMode.OneWay);
				advancedTabItem.BindToProperty(Control.PaddingProperty, this, vVK.ssH(3040), BindingMode.OneWay);
				advancedTabItem.BindToProperty(AdvancedTabItem.FarSlantExtentProperty, this, vVK.ssH(3174), BindingMode.OneWay);
				advancedTabItem.BindToProperty(AdvancedTabItem.NearSlantExtentProperty, this, vVK.ssH(3212), BindingMode.OneWay);
				uIElement = item as UIElement;
				num = 4;
				if (Dl() == null)
				{
					continue;
				}
				break;
			case 2:
				advancedTabItem.BindToProperty(AdvancedTabItem.BackgroundInactiveSelectedProperty, this, vVK.ssH(1838), BindingMode.OneWay);
				advancedTabItem.BindToProperty(AdvancedTabItem.BackgroundPointerOverProperty, this, vVK.ssH(1900), BindingMode.OneWay);
				advancedTabItem.BindToProperty(AdvancedTabItem.BackgroundPreviewProperty, this, vVK.ssH(1952), BindingMode.OneWay);
				advancedTabItem.BindToProperty(AdvancedTabItem.BackgroundPreviewActiveSelectedProperty, this, vVK.ssH(1996), BindingMode.OneWay);
				advancedTabItem.BindToProperty(AdvancedTabItem.BackgroundPreviewPointerOverProperty, this, vVK.ssH(2068), BindingMode.OneWay);
				advancedTabItem.BindToProperty(Control.BorderBrushProperty, this, vVK.ssH(2134), BindingMode.OneWay);
				advancedTabItem.BindToProperty(AdvancedTabItem.BorderBrushActiveSelectedProperty, this, vVK.ssH(2166), BindingMode.OneWay);
				advancedTabItem.BindToProperty(AdvancedTabItem.BorderBrushInactiveSelectedProperty, this, vVK.ssH(2226), BindingMode.OneWay);
				advancedTabItem.BindToProperty(AdvancedTabItem.BorderBrushPointerOverProperty, this, vVK.ssH(2290), BindingMode.OneWay);
				advancedTabItem.BindToProperty(AdvancedTabItem.BorderBrushPreviewProperty, this, vVK.ssH(2344), BindingMode.OneWay);
				advancedTabItem.BindToProperty(AdvancedTabItem.BorderBrushPreviewActiveSelectedProperty, this, vVK.ssH(2390), BindingMode.OneWay);
				advancedTabItem.BindToProperty(AdvancedTabItem.BorderBrushPreviewPointerOverProperty, this, vVK.ssH(2464), BindingMode.OneWay);
				num = 3;
				if (Dl() != null)
				{
					num = 1;
				}
				continue;
			case 4:
				if (uIElement == null)
				{
					advancedTabItem.BindToProperty(AdvancedTabItem.ContextContentProperty, element, vVK.ssH(3866), BindingMode.OneWay);
					num = 0;
					if (hL())
					{
						continue;
					}
					break;
				}
				advancedTabItem.BindToProperty(AdvancedTabItem.ContextContentProperty, uIElement, vVK.ssH(3840), BindingMode.OneWay, new NonUIElementConverter());
				goto default;
			}
			break;
		}
		goto IL_0005;
		IL_0005:
		int num2 = default(int);
		num = num2;
		goto IL_0009;
	}

	protected internal virtual void UpdateHighlightBrushes()
	{
	}

	[SpecialName]
	private PopupButton Xdg()
	{
		return iwi;
	}

	[SpecialName]
	private void SdX(PopupButton value)
	{
		if (iwi != null)
		{
			iwi.PopupOpening -= pdO;
		}
		iwi = value;
		if (iwi != null)
		{
			iwi.PopupMenu = new ContextMenu();
			iwi.PopupOpening += pdO;
		}
	}

	private void pdO(object P_0, CancelRoutedEventArgs P_1)
	{
		ContextMenu contextMenu = iwi.PopupMenu ?? new ContextMenu();
		contextMenu.Items.Clear();
		int num2 = default(int);
		for (int i = 0; i < base.Items.Count; i++)
		{
			while (true)
			{
				AdvancedTabItem advancedTabItem = M0(i);
				if (advancedTabItem != null)
				{
					int num = 1;
					if (Dl() != null)
					{
						num = num2;
					}
					switch (num)
					{
					default:
						continue;
					case 1:
						break;
					}
					string name = vVK.ssH(3884) + (i + 1) + vVK.ssH(3908);
					MenuItem menuItem = new MenuItem
					{
						Name = name,
						Header = ((advancedTabItem.Header != null) ? advancedTabItem.Header.ToString().Replace(vVK.ssH(3928), vVK.ssH(3934)) : null),
						Command = SelectItemCommand,
						CommandParameter = base.Items[i],
						IsChecked = advancedTabItem.IsSelected
					};
					if (advancedTabItem.ImageSource != null)
					{
						DynamicImage dynamicImage = new DynamicImage();
						dynamicImage.Width = 16.0;
						dynamicImage.Height = 16.0;
						dynamicImage.Stretch = Stretch.Uniform;
						dynamicImage.Source = advancedTabItem.ImageSource;
						menuItem.Icon = dynamicImage;
					}
					contextMenu.Items.Add(menuItem);
				}
				break;
			}
		}
		AdvancedTabControlMenuEventArgs e = new AdvancedTabControlMenuEventArgs
		{
			Menu = contextMenu
		};
		bdC(e);
		if (e.Menu != null)
		{
			iwi.PopupMenu = e.Menu;
			return;
		}
		P_1.Cancel = true;
		iwi.PopupMenu = new ContextMenu();
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	protected override void OnKeyDown(KeyEventArgs e)
	{
		int num = 2;
		AdvancedTabItem advancedTabItem = default(AdvancedTabItem);
		int num3 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					if (advancedTabItem != null && advancedTabItem.Visibility == Visibility.Visible)
					{
						if (advancedTabItem.IsSelected)
						{
							NA(advancedTabItem);
						}
						else
						{
							advancedTabItem.IsSelected = true;
							sH();
						}
						e.Handled = true;
					}
					return;
				case 3:
					if (IsTabKeyboardAccessEnabled)
					{
						num3 = -1;
						switch (e.Key)
						{
						case Key.D2:
							num3 = 1;
							break;
						case Key.D5:
							num3 = 4;
							break;
						case Key.D1:
							num3 = 0;
							break;
						case Key.D9:
							num3 = 8;
							break;
						case Key.D6:
							num3 = 5;
							break;
						case Key.D0:
							num3 = 9;
							break;
						case Key.D3:
							goto IL_019b;
						case Key.D4:
							num3 = 3;
							break;
						case Key.D7:
							num3 = 6;
							break;
						case Key.D8:
							num3 = 7;
							break;
						}
						goto case 5;
					}
					return;
				case 2:
					if (e != null)
					{
						num2 = 1;
						if (Dl() == null)
						{
							continue;
						}
						break;
					}
					throw new ArgumentNullException(vVK.ssH(3942));
				default:
					if (!e.Handled)
					{
						num2 = 3;
						if (hL())
						{
							continue;
						}
						break;
					}
					return;
				case 5:
					if (num3 != -1)
					{
						ModifierKeys modifiers = Keyboard.Modifiers;
						if ((uint)(modifiers - 2) > 1u || lwI == null)
						{
							return;
						}
						TabLayoutKind value = ((Keyboard.Modifiers != ModifierKeys.Control) ? TabLayoutKind.Pinned : TabLayoutKind.Normal);
						IEnumerable<AdvancedTabItem> tabItemElements = lwI.GetTabItemElements(value);
						if (tabItemElements != null)
						{
							advancedTabItem = tabItemElements.ElementAtOrDefault(num3);
							num2 = 4;
							if (Dl() == null)
							{
								continue;
							}
							break;
						}
						return;
					}
					return;
				case 1:
					{
						if (!IsTabKeyboardSwitchingEnabled && e.Key == Key.Tab)
						{
							ModifierKeys modifiers = Keyboard.Modifiers;
							if (modifiers == ModifierKeys.Control || modifiers == (ModifierKeys.Control | ModifierKeys.Shift))
							{
								return;
							}
						}
						base.OnKeyDown(e);
						num2 = 0;
						if (hL())
						{
							continue;
						}
						break;
					}
					IL_019b:
					num3 = 2;
					num2 = 5;
					if (Dl() == null)
					{
						continue;
					}
					break;
				}
				break;
			}
		}
	}

	protected override void OnSelectionChanged(SelectionChangedEventArgs e)
	{
		_003C_003Ec__DisplayClass375_0 CS_0024_003C_003E8__locals6 = new _003C_003Ec__DisplayClass375_0();
		CS_0024_003C_003E8__locals6.lSF = this;
		base.OnSelectionChanged(e);
		UpdateHighlightBrushes();
		CS_0024_003C_003E8__locals6.KSq = base.SelectedItem;
		base.Dispatcher.BeginInvoke(DispatcherPriority.Loaded, (Action)delegate
		{
			if (CS_0024_003C_003E8__locals6.KSq == CS_0024_003C_003E8__locals6.lSF.SelectedItem)
			{
				CS_0024_003C_003E8__locals6.lSF.qb(CS_0024_003C_003E8__locals6.KSq);
			}
		});
	}

	protected override void OnRenderSizeChanged(SizeChangedInfo sizeInfo)
	{
		base.OnRenderSizeChanged(sizeInfo);
		if (sizeInfo == null || !IsOverflowed)
		{
			return;
		}
		AdvancedTabItem advancedTabItem = XdF();
		if (advancedTabItem == null)
		{
			return;
		}
		if (zdc() == Orientation.Horizontal)
		{
			Size newSize = sizeInfo.NewSize;
			int num = 0;
			if (!hL())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			if (newSize.Width < sizeInfo.PreviousSize.Width)
			{
				NA(advancedTabItem, _0020: true);
			}
		}
		else if (sizeInfo.NewSize.Height < sizeInfo.PreviousSize.Height)
		{
			NA(advancedTabItem, _0020: true);
		}
	}

	[CompilerGenerated]
	private void TdT(object P_0)
	{
		Mda();
	}

	[CompilerGenerated]
	private void jd8(object P_0)
	{
		if (lwI != null)
		{
			Ic(Rwk + lwI.POc() * 0.9, _0020: false);
		}
	}

	[CompilerGenerated]
	private bool VdD(object P_0)
	{
		return CanScrollBackward;
	}

	[CompilerGenerated]
	private void AdE(object P_0)
	{
		if (lwI != null)
		{
			Ic(Rwk - lwI.POc() * 0.9, _0020: false);
		}
	}

	[CompilerGenerated]
	private bool bdr(object P_0)
	{
		return CanScrollForward;
	}

	[CompilerGenerated]
	private void Pdx(object P_0)
	{
		if (base.Items.IndexOf(P_0) != -1)
		{
			if (base.SelectedItem == P_0)
			{
				qb(P_0);
			}
			else
			{
				base.SelectedItem = P_0;
			}
			sH();
		}
	}

	internal static bool hL()
	{
		return oh == null;
	}

	internal static AdvancedTabControl Dl()
	{
		return oh;
	}
}
