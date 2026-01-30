using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.Docking;
using ActiproSoftware.Windows.Controls.Docking.Automation.Peers;
using ActiproSoftware.Windows.Controls.Docking.Primitives;
using ActiproSoftware.Windows.Extensions;
using ActiproSoftware.Windows.Input;
using ActiproSoftware.Windows.Media;

namespace ActiproSoftware.Windows.Controls.Docking;

[TemplateVisualState(Name = "AutoHide", GroupName = "StateStates")]
[TemplateVisualState(Name = "Inactive", GroupName = "ActiveStates")]
[ToolboxItem(false)]
[TemplateVisualState(Name = "Docked", GroupName = "StateStates")]
[TemplatePart(Name = "PART_OptionsButton", Type = typeof(PopupButton))]
[ContentProperty("Windows")]
[TemplateVisualState(Name = "Active", GroupName = "ActiveStates")]
[TemplatePart(Name = "PART_TitleBar", Type = typeof(FrameworkElement))]
public class ToolWindowContainer : DockingWindowContainerBase, iy, IDockTarget, zj, IOrientedElement
{
	private InputAdapter HKr;

	private PopupButton QKx;

	private FrameworkElement zKl;

	private Point? fKM;

	private DelegateCommand<object> sKv;

	private DelegateCommand<object> pK7;

	private DelegateCommand<object> mKR;

	private DelegateCommand<object> OKS;

	private DelegateCommand<object> WKL;

	private DelegateCommand<object> JK3;

	private DelegateCommand<object> lK6;

	public static readonly DependencyProperty CloseButtonContentTemplateProperty;

	public static readonly DependencyProperty EmbeddedButtonStyleProperty;

	public static readonly DependencyProperty HasCloseButtonProperty;

	public static readonly DependencyProperty HasTitleBarIconProperty;

	public static readonly DependencyProperty HasToggleAutoHideButtonProperty;

	public static readonly DependencyProperty IsCloseButtonVisibleProperty;

	public static readonly DependencyProperty IsMaximizeButtonVisibleProperty;

	public static readonly DependencyProperty IsMinimizeButtonVisibleProperty;

	public static readonly DependencyProperty IsOptionsButtonVisibleProperty;

	public static readonly DependencyProperty IsRestoreButtonVisibleProperty;

	public static readonly DependencyProperty IsToggleAutoHideButtonVisibleProperty;

	public static readonly DependencyProperty MaximizeButtonContentTemplateProperty;

	public static readonly DependencyProperty MenuButtonContentTemplateProperty;

	public static readonly DependencyProperty MinimizeButtonContentTemplateProperty;

	public static readonly DependencyProperty PinButtonContentTemplateProperty;

	public static readonly DependencyProperty RestoreButtonContentTemplateProperty;

	public static readonly DependencyProperty SingleTabLayoutBehaviorProperty;

	public static readonly DependencyProperty TitleBarMinHeightProperty;

	public static readonly DependencyProperty TitleBarContextContentAlignmentProperty;

	public static readonly DependencyProperty TitleFontFamilyProperty;

	public static readonly DependencyProperty TitleFontSizeProperty;

	public static readonly DependencyProperty TitleFontWeightProperty;

	public static readonly DependencyProperty UnpinButtonContentTemplateProperty;

	public static readonly DependencyProperty HasTitleBarGripperProperty;

	internal static ToolWindowContainer jHU;

	private bool AutoHidePerContainer => base.DockSite?.AutoHidePerContainer ?? true;

	private FrameworkElement TitleBar
	{
		get
		{
			return zKl;
		}
		set
		{
			if (zKl != value)
			{
				zKl = value;
			}
		}
	}

	public ICommand AutoHideCommand => sKv;

	public DataTemplate CloseButtonContentTemplate
	{
		get
		{
			return (DataTemplate)GetValue(CloseButtonContentTemplateProperty);
		}
		set
		{
			SetValue(CloseButtonContentTemplateProperty, value);
		}
	}

	public ICommand CloseCommand => pK7;

	public ICommand DockCommand => mKR;

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

	public bool HasCloseButton
	{
		get
		{
			return (bool)GetValue(HasCloseButtonProperty);
		}
		set
		{
			SetValue(HasCloseButtonProperty, value);
		}
	}

	public bool HasTitleBarIcon
	{
		get
		{
			return (bool)GetValue(HasTitleBarIconProperty);
		}
		set
		{
			SetValue(HasTitleBarIconProperty, value);
		}
	}

	public bool HasToggleAutoHideButton
	{
		get
		{
			return (bool)GetValue(HasToggleAutoHideButtonProperty);
		}
		set
		{
			SetValue(HasToggleAutoHideButtonProperty, value);
		}
	}

	public bool IsCloseButtonVisible
	{
		get
		{
			return (bool)GetValue(IsCloseButtonVisibleProperty);
		}
		private set
		{
			SetValue(IsCloseButtonVisibleProperty, value);
		}
	}

	public bool IsMaximizeButtonVisible
	{
		get
		{
			return (bool)GetValue(IsMaximizeButtonVisibleProperty);
		}
		private set
		{
			SetValue(IsMaximizeButtonVisibleProperty, value);
		}
	}

	public bool IsMinimizeButtonVisible
	{
		get
		{
			return (bool)GetValue(IsMinimizeButtonVisibleProperty);
		}
		private set
		{
			SetValue(IsMinimizeButtonVisibleProperty, value);
		}
	}

	public bool IsOptionsButtonVisible
	{
		get
		{
			return (bool)GetValue(IsOptionsButtonVisibleProperty);
		}
		private set
		{
			SetValue(IsOptionsButtonVisibleProperty, value);
		}
	}

	public bool IsRestoreButtonVisible
	{
		get
		{
			return (bool)GetValue(IsRestoreButtonVisibleProperty);
		}
		private set
		{
			SetValue(IsRestoreButtonVisibleProperty, value);
		}
	}

	public bool IsToggleAutoHideButtonVisible
	{
		get
		{
			return (bool)GetValue(IsToggleAutoHideButtonVisibleProperty);
		}
		private set
		{
			SetValue(IsToggleAutoHideButtonVisibleProperty, value);
		}
	}

	public DataTemplate MaximizeButtonContentTemplate
	{
		get
		{
			return (DataTemplate)GetValue(MaximizeButtonContentTemplateProperty);
		}
		set
		{
			SetValue(MaximizeButtonContentTemplateProperty, value);
		}
	}

	public ICommand MaximizeCommand => OKS;

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

	public DataTemplate MinimizeButtonContentTemplate
	{
		get
		{
			return (DataTemplate)GetValue(MinimizeButtonContentTemplateProperty);
		}
		set
		{
			SetValue(MinimizeButtonContentTemplateProperty, value);
		}
	}

	public ICommand MinimizeCommand => WKL;

	public DataTemplate PinButtonContentTemplate
	{
		get
		{
			return (DataTemplate)GetValue(PinButtonContentTemplateProperty);
		}
		set
		{
			SetValue(PinButtonContentTemplateProperty, value);
		}
	}

	public DataTemplate RestoreButtonContentTemplate
	{
		get
		{
			return (DataTemplate)GetValue(RestoreButtonContentTemplateProperty);
		}
		set
		{
			SetValue(RestoreButtonContentTemplateProperty, value);
		}
	}

	public ICommand RestoreCommand => JK3;

	public ToolWindow SelectedToolWindow => base.SelectedWindow as ToolWindow;

	public SingleTabLayoutBehavior SingleTabLayoutBehavior
	{
		get
		{
			return (SingleTabLayoutBehavior)GetValue(SingleTabLayoutBehaviorProperty);
		}
		set
		{
			SetValue(SingleTabLayoutBehaviorProperty, value);
		}
	}

	public double TitleBarMinHeight
	{
		get
		{
			return (double)GetValue(TitleBarMinHeightProperty);
		}
		set
		{
			SetValue(TitleBarMinHeightProperty, value);
		}
	}

	public ContextContentAlignment TitleBarContextContentAlignment
	{
		get
		{
			return (ContextContentAlignment)GetValue(TitleBarContextContentAlignmentProperty);
		}
		set
		{
			SetValue(TitleBarContextContentAlignmentProperty, value);
		}
	}

	public FontFamily TitleFontFamily
	{
		get
		{
			return (FontFamily)GetValue(TitleFontFamilyProperty);
		}
		set
		{
			SetValue(TitleFontFamilyProperty, value);
		}
	}

	public double TitleFontSize
	{
		get
		{
			return (double)GetValue(TitleFontSizeProperty);
		}
		set
		{
			SetValue(TitleFontSizeProperty, value);
		}
	}

	public FontWeight TitleFontWeight
	{
		get
		{
			return (FontWeight)GetValue(TitleFontWeightProperty);
		}
		set
		{
			SetValue(TitleFontWeightProperty, value);
		}
	}

	public ICommand ToggleAutoHideCommand => lK6;

	public DataTemplate UnpinButtonContentTemplate
	{
		get
		{
			return (DataTemplate)GetValue(UnpinButtonContentTemplateProperty);
		}
		set
		{
			SetValue(UnpinButtonContentTemplateProperty, value);
		}
	}

	public ObservableCollection<DockingWindow> Windows => base.WindowsCore;

	bool iy.HasDockGuides => true;

	bool iy.RequiresReverseOrderInsertion => false;

	Size zj.TabPanelSize => TDy();

	public bool HasTitleBarGripper
	{
		get
		{
			return (bool)GetValue(HasTitleBarGripperProperty);
		}
		set
		{
			SetValue(HasTitleBarGripperProperty, value);
		}
	}

	public ToolWindowContainer()
	{
		IVH.CecNqz();
		base._002Ector();
		base.DefaultStyleKey = typeof(ToolWindowContainer);
		iBs();
		fBF();
	}

	private void iBs()
	{
		HKr = new InputAdapter(this);
		HKr.DoubleTapped += CBc;
		HKr.PointerCaptureLost += oBj;
		HKr.PointerMoved += lBZ;
		HKr.PointerPressed += sBb;
		HKr.PointerReleased += eBA;
		HKr.AttachedEventKinds = InputAdapterEventKinds.PointerCaptureLost | InputAdapterEventKinds.PointerMoved | InputAdapterEventKinds.PointerPressed | InputAdapterEventKinds.PointerReleased | InputAdapterEventKinds.DoubleTapped;
	}

	private void KBq(Side? P_0, bool P_1)
	{
		DockSite dockSite = base.DockSite;
		if (dockSite != null)
		{
			IEnumerable<ToolWindow> windows = (P_1 ? Windows.OfType<ToolWindow>() : (from tw in Windows.OfType<ToolWindow>()
				where tw.CanAutoHideResolved
				select tw));
			dockSite.s1t().AutoHide(windows, P_0);
		}
	}

	[SpecialName]
	internal Side? xKI()
	{
		return base.DockHost?.S2r(this);
	}

	[SpecialName]
	private bool sKC()
	{
		bool result = true;
		foreach (DockingWindow window in Windows)
		{
			if (window != null && !window.CanDragTabResolved)
			{
				result = false;
				break;
			}
		}
		return result;
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	private void fBF()
	{
		sKv = new DelegateCommand<object>(delegate(object P_0)
		{
			if (base.State != DockingWindowState.AutoHide && !AutoHidePerContainer)
			{
				ToolWindow selectedToolWindow = SelectedToolWindow;
				if (selectedToolWindow != null && selectedToolWindow.AutoHideCommand != null && selectedToolWindow.AutoHideCommand.CanExecute(P_0))
				{
					selectedToolWindow.AutoHideCommand.Execute(P_0);
					return;
				}
			}
			KBq(null, _0020: false);
		}, delegate
		{
			if (base.State == DockingWindowState.Docked)
			{
				DockHost dockHost = base.DockHost;
				if (dockHost != null && dockHost.Meg())
				{
					kq kq = dockHost.LayoutKind;
					if ((uint)kq <= 2u)
					{
						return false;
					}
				}
				return SelectedToolWindow?.CanAutoHideResolved ?? false;
			}
			return false;
		});
		pK7 = new DelegateCommand<object>(delegate
		{
			Close();
		}, (object P_0) => base.SelectedWindow?.CanCloseResolved ?? false);
		mKR = new DelegateCommand<object>(delegate(object P_0)
		{
			if (base.State == DockingWindowState.AutoHide && !AutoHidePerContainer)
			{
				ToolWindow selectedToolWindow = SelectedToolWindow;
				if (selectedToolWindow != null && selectedToolWindow.DockCommand != null && selectedToolWindow.DockCommand.CanExecute(P_0))
				{
					selectedToolWindow.DockCommand.Execute(P_0);
					return;
				}
			}
			zBV(_0020: false);
		}, delegate
		{
			ToolWindow selectedToolWindow = SelectedToolWindow;
			if (selectedToolWindow != null && selectedToolWindow.CanDockResolved)
			{
				if (base.State != DockingWindowState.Docked)
				{
					return true;
				}
				DockHost dockHost = base.DockHost;
				if (dockHost != null && dockHost.Meg())
				{
					kq kq = dockHost.LayoutKind;
					if ((uint)(kq - 1) <= 1u)
					{
						return true;
					}
				}
			}
			return false;
		});
		OKS = new DelegateCommand<object>(delegate
		{
			base.DockHost?.Qeb(WindowState.Maximized);
		});
		WKL = new DelegateCommand<object>(delegate
		{
			base.DockHost?.Qeb(WindowState.Minimized);
		});
		JK3 = new DelegateCommand<object>(delegate
		{
			base.DockHost?.Qeb(WindowState.Normal);
		});
		lK6 = new DelegateCommand<object>(delegate(object P_0)
		{
			if (base.State == DockingWindowState.AutoHide)
			{
				DockCommand.Execute(P_0);
			}
			else
			{
				AutoHideCommand.Execute(P_0);
			}
		}, (object P_0) => (base.State != DockingWindowState.AutoHide) ? AutoHideCommand.CanExecute(P_0) : DockCommand.CanExecute(P_0));
	}

	private void zBV(bool P_0)
	{
		DockSite dockSite = base.DockSite;
		if (dockSite == null)
		{
			return;
		}
		IEnumerable<DockingWindow> enumerable;
		if (P_0)
		{
			IEnumerable<DockingWindow> windows = Windows;
			enumerable = windows;
		}
		else
		{
			enumerable = Windows.Where((DockingWindow w) => w.CanDockResolved);
		}
		IEnumerable<DockingWindow> enumerable2 = enumerable;
		dockSite.s1t().WMz(enumerable2, DockingWindowState.Docked, null);
	}

	private void GBP(Point P_0, InputPointerEventArgs P_1)
	{
		DockHost dockHost = base.DockHost;
		if (dockHost != null && dockHost.Meg() && !dockHost.BGW())
		{
			int num = 0;
			if (pHd() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			dockHost.P2s(default(Point), P_1);
		}
		else
		{
			DockSite dockSite = base.DockSite;
			if (dockSite != null && sKC())
			{
				dockSite.s1t().WvG(this, P_0, P_1);
			}
		}
	}

	private void gBf()
	{
		base.DockSite?.s1t().Sve(from tw in Windows.OfType<ToolWindow>()
			where tw.CanFloatResolved
			select tw, null, null);
	}

	private void YBU()
	{
		DockingWindow selectedWindow = base.SelectedWindow;
		if (selectedWindow != null)
		{
			cP.Dl4(selectedWindow);
		}
	}

	private void CBc(object P_0, InputDoubleTappedEventArgs P_1)
	{
		if (P_1 == null || P_1.Handled || TitleBar == null || !P_1.IsPositionOver(TitleBar))
		{
			return;
		}
		DockHost dockHost = base.DockHost;
		if (dockHost != null)
		{
			kq kq = dockHost.LayoutKind;
			if (kq == (kq)2 || kq == (kq)4)
			{
				gBf();
			}
		}
		P_1.Handled = true;
	}

	private static void GB4(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((ToolWindowContainer)P_0).UpdateTitleBarButtonVisibility();
	}

	private void oBj(object P_0, InputPointerEventArgs P_1)
	{
		mBg(_0020: false);
	}

	private void lBZ(object P_0, InputPointerEventArgs P_1)
	{
		if (!fKM.HasValue)
		{
			return;
		}
		bool flag = false;
		Point point = default(Point);
		if (TitleBar != null)
		{
			Point position = P_1.GetPosition(TitleBar);
			point = new Point(position.X - fKM.Value.X, position.Y - fKM.Value.Y);
			if (!(Math.Abs(point.X) > 10.0) && !(Math.Abs(point.Y) > 10.0))
			{
				return;
			}
			flag = true;
		}
		mBg(_0020: true);
		if (flag)
		{
			GBP(point, P_1);
		}
	}

	private void sBb(object P_0, InputPointerButtonEventArgs P_1)
	{
		mBg(_0020: false);
		if (P_1 == null || P_1.Handled)
		{
			return;
		}
		if (!base.IsActive)
		{
			YBU();
		}
		if (!P_1.IsPrimaryButton || TitleBar == null || !P_1.IsPositionOver(TitleBar))
		{
			return;
		}
		if (P_1.DeviceKind == InputDeviceKind.Touch && P_1.WrappedEventArgs != null)
		{
			int num = 0;
			if (!LHF())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			case 1:
				return;
			}
			if (VisualTreeHelperExtended.GetAncestor(P_1.WrappedEventArgs.OriginalSource as Visual, typeof(ButtonBase), typeof(ToolWindowContainer)) is ButtonBase)
			{
				return;
			}
		}
		DockHost dockHost = base.DockHost;
		if (dockHost != null && dockHost.Meg() && !dockHost.BGW() && dockHost.zeZ() != WindowState.Maximized)
		{
			GBP(default(Point), P_1);
			P_1.Handled = true;
		}
		else
		{
			EBh(P_1);
		}
	}

	private void eBA(object P_0, InputPointerButtonEventArgs P_1)
	{
		mBg(_0020: true);
		if (P_1 != null && !P_1.Handled && P_1.ButtonKind == InputPointerButtonKind.Secondary && TitleBar != null && P_1.IsPositionOver(TitleBar))
		{
			P_1.Handled = tB0(P_1);
		}
	}

	private static void vBH(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((ToolWindowContainer)P_0).UpdateIsTabStripVisible();
	}

	[SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "e")]
	internal bool tB0(InputPointerButtonEventArgs P_0)
	{
		DockSite dockSite = base.DockSite;
		DockingWindow selectedWindow = base.SelectedWindow;
		int num;
		if (dockSite != null && selectedWindow != null && TitleBar != null)
		{
			num = 0;
			if (!LHF())
			{
				goto IL_0005;
			}
			goto IL_0009;
		}
		goto IL_0021;
		IL_0005:
		int num2 = default(int);
		num = num2;
		goto IL_0009;
		IL_0009:
		Point point = default(Point);
		Window window = default(Window);
		ContextMenu menu = default(ContextMenu);
		do
		{
			IL_0009_2:
			switch (num)
			{
			case 2:
				point.X += window.Left;
				point.Y += window.Top;
				goto IL_01c2;
			case 1:
				{
					if (window == null)
					{
						menu.Placement = PlacementMode.MousePoint;
						goto IL_003a;
					}
					if (P_0 == null)
					{
						point = hV.Sk();
						Point point2 = hV.mC(window);
						point.X /= point2.X;
						point.Y /= point2.Y;
						goto IL_01c2;
					}
					goto IL_00b9;
				}
				IL_003a:
				menu.IsOpen = true;
				return true;
				IL_01c2:
				menu.HorizontalOffset = point.X;
				menu.VerticalOffset = point.Y;
				menu.PlacementTarget = window;
				menu.Placement = PlacementMode.Absolute;
				goto IL_003a;
			}
			DockingMenuEventArgs e = new DockingMenuEventArgs(DockingMenuKind.ToolWindowContainerTitleBarContextMenu)
			{
				Window = selectedWindow
			};
			e.Menu = DockSite.nN7(this);
			dockSite.C19(e);
			menu = e.Menu;
			if (!e.Cancel && menu != null && menu.Items.Count > 0)
			{
				window = Yp.iRU(selectedWindow);
				num = 1;
				if (pHd() != null)
				{
					break;
				}
				goto IL_0009_2;
			}
			goto IL_0021;
			IL_00b9:
			point = P_0.GetPosition(window);
			num = 2;
		}
		while (LHF());
		goto IL_0005;
		IL_0021:
		return false;
	}

	private void EBh(InputPointerButtonEventArgs P_0)
	{
		fKM = P_0.GetPosition(TitleBar);
		HKr.CapturePointer(P_0);
	}

	private void mBg(bool P_0)
	{
		if (fKM.HasValue)
		{
			fKM = null;
			if (P_0)
			{
				HKr.ReleasePointerCaptures();
			}
		}
	}

	public void AutoHide()
	{
		KBq(null, _0020: true);
	}

	public void AutoHide(Side side)
	{
		KBq(side, _0020: true);
	}

	public bool Close()
	{
		DockSite dockSite = base.DockSite;
		if (dockSite != null)
		{
			Nx nx = dockSite.s1t();
			if (dockSite.ClosePerContainer)
			{
				return nx.Close(Windows, wU.Close, force: false, allowDocumentDestroy: true);
			}
			return nx.Close(base.SelectedWindow, wU.Close, force: false, allowDocumentDestroy: true);
		}
		return false;
	}

	public void Dock()
	{
		zBV(_0020: true);
	}

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		aKD(GetTemplateChild(vVK.ssH(17896)) as PopupButton);
		TitleBar = GetTemplateChild(vVK.ssH(17936)) as FrameworkElement;
		UpdateTitleBarButtonVisibility();
		UpdateVisualState(useTransitions: false);
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		return new ToolWindowContainerAutomationPeer(this);
	}

	protected override void OnDockSiteChanged(DockSite oldDockSite, DockSite newDockSite)
	{
		base.OnDockSiteChanged(oldDockSite, newDockSite);
		if (newDockSite != null)
		{
			this.BindToProperty(DockingWindowContainerBase.CanTabsCloseOnMiddleClickProperty, newDockSite, vVK.ssH(11726), BindingMode.OneWay);
			this.BindToProperty(HasCloseButtonProperty, newDockSite, vVK.ssH(12958), BindingMode.OneWay);
			this.BindToProperty(DockingWindowContainerBase.HasTabImagesProperty, newDockSite, vVK.ssH(13078), BindingMode.OneWay);
			this.BindToProperty(HasTitleBarIconProperty, newDockSite, vVK.ssH(13130), BindingMode.OneWay);
			this.BindToProperty(HasToggleAutoHideButtonProperty, newDockSite, vVK.ssH(13242), BindingMode.OneWay);
			this.BindToProperty(SingleTabLayoutBehaviorProperty, newDockSite, vVK.ssH(13318), BindingMode.OneWay);
			this.BindToProperty(DockingWindowContainerBase.TabItemContainerStyleProperty, newDockSite, vVK.ssH(13602), BindingMode.OneWay);
			this.BindToProperty(DockingWindowContainerBase.TabOverflowBehaviorProperty, newDockSite, vVK.ssH(13390), BindingMode.OneWay);
			this.BindToProperty(DockingWindowContainerBase.TabStripPlacementProperty, newDockSite, vVK.ssH(13454), BindingMode.OneWay);
			this.BindToProperty(TitleBarContextContentAlignmentProperty, newDockSite, vVK.ssH(13514), BindingMode.OneWay);
			DockingWindow[] array = Windows.ToArray();
			foreach (DockingWindow dockingWindow in array)
			{
				if (dockingWindow != null)
				{
					dockingWindow.DockSite = newDockSite;
				}
			}
		}
		else
		{
			BindingOperations.ClearBinding(this, DockingWindowContainerBase.CanTabsCloseOnMiddleClickProperty);
			BindingOperations.ClearBinding(this, HasCloseButtonProperty);
			BindingOperations.ClearBinding(this, DockingWindowContainerBase.HasTabImagesProperty);
			BindingOperations.ClearBinding(this, HasTitleBarIconProperty);
			BindingOperations.ClearBinding(this, HasToggleAutoHideButtonProperty);
			BindingOperations.ClearBinding(this, SingleTabLayoutBehaviorProperty);
			BindingOperations.ClearBinding(this, DockingWindowContainerBase.TabItemContainerStyleProperty);
			BindingOperations.ClearBinding(this, DockingWindowContainerBase.TabOverflowBehaviorProperty);
			BindingOperations.ClearBinding(this, DockingWindowContainerBase.TabStripPlacementProperty);
			BindingOperations.ClearBinding(this, TitleBarContextContentAlignmentProperty);
		}
	}

	protected override void OnTabControlMenuOpening(AdvancedTabControlMenuEventArgs e)
	{
		DockSite dockSite = base.DockSite;
		if (e == null || dockSite == null)
		{
			return;
		}
		ToolWindow toolWindow = ((e.TabItem != null) ? (e.TabItem.Content as ToolWindow) : null) ?? SelectedToolWindow;
		if (toolWindow != null)
		{
			DockingMenuEventArgs e2 = new DockingMenuEventArgs((e.TabItem != null) ? DockingMenuKind.ToolWindowContainerTabContextMenu : DockingMenuKind.ToolWindowContainerOverflowMenu)
			{
				Window = toolWindow
			};
			if (e.TabItem != null)
			{
				e2.Menu = DockSite.TNR(toolWindow);
			}
			else
			{
				e2.Menu = e.Menu;
			}
			dockSite.C19(e2);
			e.Menu = e2.Menu;
		}
	}

	public void OpenOptionsMenu()
	{
		OpenOptionsMenu(null);
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public void OpenOptionsMenu(FrameworkElement placementTarget)
	{
		DockSite dockSite = base.DockSite;
		ToolWindow selectedToolWindow = SelectedToolWindow;
		if (dockSite == null || selectedToolWindow == null)
		{
			return;
		}
		DockingMenuEventArgs e = new DockingMenuEventArgs(DockingMenuKind.ToolWindowContainerTitleBarOptionsMenu)
		{
			Window = selectedToolWindow
		};
		e.Menu = DockSite.TNR(selectedToolWindow);
		dockSite.C19(e);
		ContextMenu menu = e.Menu;
		if (e.Cancel || menu == null || menu.Items.Count <= 0)
		{
			return;
		}
		object obj = placementTarget;
		if (obj == null)
		{
			obj = aK8();
			if (obj == null)
			{
				int num = 0;
				if (!LHF())
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				obj = TitleBar;
			}
		}
		placementTarget = (FrameworkElement)obj;
		menu.PlacementTarget = placementTarget;
		menu.Placement = ((placementTarget != null) ? PlacementMode.Bottom : PlacementMode.MousePoint);
		menu.IsOpen = true;
	}

	protected override void UpdateCommands()
	{
		sKv.RaiseCanExecuteChanged();
		pK7.RaiseCanExecuteChanged();
		mKR.RaiseCanExecuteChanged();
		lK6.RaiseCanExecuteChanged();
	}

	protected override void UpdateDockingWindowStates()
	{
		DockingWindowState state = base.State;
		foreach (DockingWindow window in Windows)
		{
			if (window != null && window.QkM() != state)
			{
				window.zIH(state);
			}
		}
	}

	protected override void UpdateIsTabStripVisible()
	{
		base.IsTabStripVisible = base.State == DockingWindowState.Docked && (Windows.Count > 1 || SingleTabLayoutBehavior == SingleTabLayoutBehavior.Show);
	}

	protected override void UpdateTitleBarButtonVisibility()
	{
		ToolWindow selectedToolWindow = SelectedToolWindow;
		if (selectedToolWindow != null)
		{
			IsCloseButtonVisible = HasCloseButton && selectedToolWindow.CanCloseResolved;
			IsOptionsButtonVisible = selectedToolWindow.HasOptionsButtonResolved;
			IsToggleAutoHideButtonVisible = HasToggleAutoHideButton && ToggleAutoHideCommand.CanExecute(null);
		}
		else
		{
			IsCloseButtonVisible = false;
			IsOptionsButtonVisible = false;
			IsToggleAutoHideButtonVisible = false;
		}
		DockSite dockSite = base.DockSite;
		DockHost dockHost = base.DockHost;
		if (dockSite != null && !dockSite.qQv() && dockHost != null && dockHost.Meg() && dockHost.LayoutKind == (kq)1)
		{
			WindowState windowState = dockHost.zeZ();
			IsMinimizeButtonVisible = windowState != WindowState.Minimized && dockSite.FloatingToolWindowContainersHaveMinimizeButtons;
			IsRestoreButtonVisible = windowState != WindowState.Normal;
			IsMaximizeButtonVisible = windowState != WindowState.Maximized && dockSite.FloatingToolWindowContainersHaveMaximizeButtons;
		}
		else
		{
			IsMinimizeButtonVisible = false;
			IsRestoreButtonVisible = false;
			IsMaximizeButtonVisible = false;
		}
	}

	protected override void UpdateVisualState(bool useTransitions)
	{
		base.UpdateVisualState(useTransitions);
		VisualStateManager.GoToState(this, base.IsActive ? vVK.ssH(17986) : vVK.ssH(17966), useTransitions);
		VisualStateManager.GoToState(this, (base.State == DockingWindowState.AutoHide) ? vVK.ssH(18018) : vVK.ssH(18002), useTransitions);
	}

	protected override void ValidateChildType(DockingWindow window)
	{
		if (!(window is ToolWindow))
		{
			throw new ArgumentException(SR.GetString(SRName.ExToolWindowRequired, window));
		}
	}

	DockingWindowState IDockTarget.GetState(Side? side)
	{
		return base.State;
	}

	bool iy.SupportsAttach(DockHost draggedDockHost)
	{
		if (draggedDockHost != null)
		{
			kq kq = draggedDockHost.LayoutKind;
			if ((uint)(kq - 1) <= 1u)
			{
				return Windows.All((DockingWindow w) => w.CanAttachResolved);
			}
		}
		return false;
	}

	bool iy.SupportsInnerSideDock(DockHost draggedDockHost)
	{
		if (draggedDockHost != null && !draggedDockHost.Ce8())
		{
			kq kq = draggedDockHost.LayoutKind;
			if ((uint)(kq - 1) <= 1u)
			{
				return true;
			}
		}
		return false;
	}

	bool iy.SupportsOuterSideDock(DockHost draggedDockHost)
	{
		return false;
	}

	bool zj.IsOverTabStrip(Point location)
	{
		return gDE(location);
	}

	bool zj.IsOverTitleBar(Point location)
	{
		if (zKl != null)
		{
			return zKl.TransformToVisual(this).TransformBounds(new Rect(default(Point), zKl.RenderSize)).Contains(location);
		}
		return false;
	}

	[SpecialName]
	internal Size bKn()
	{
		return SelectedToolWindow?.ContainerAutoHideSize ?? default(Size);
	}

	[SpecialName]
	internal void hKO(Size value)
	{
		ToolWindow selectedToolWindow = SelectedToolWindow;
		if (selectedToolWindow != null)
		{
			selectedToolWindow.ContainerAutoHideSize = value;
		}
	}

	private void cBX(object P_0, CancelRoutedEventArgs P_1)
	{
		ContextMenu contextMenu = QKx.PopupMenu ?? new ContextMenu();
		contextMenu.Items.Clear();
		DockSite dockSite = base.DockSite;
		ToolWindow selectedToolWindow = SelectedToolWindow;
		if (dockSite != null && selectedToolWindow != null)
		{
			DockingMenuEventArgs e = new DockingMenuEventArgs(DockingMenuKind.ToolWindowContainerTitleBarOptionsMenu)
			{
				Window = selectedToolWindow
			};
			e.Menu = DockSite.TNR(selectedToolWindow);
			dockSite.C19(e);
			if (!e.Cancel && e.Menu != null && e.Menu.Items.Count > 0)
			{
				contextMenu.ItemContainerStyle = e.Menu.ItemContainerStyle;
				contextMenu.ItemContainerStyleSelector = e.Menu.ItemContainerStyleSelector;
				contextMenu.ItemTemplate = e.Menu.ItemTemplate;
				contextMenu.ItemTemplateSelector = e.Menu.ItemTemplateSelector;
				QKx.PopupMenu = contextMenu;
				object[] array = e.Menu.Items.OfType<object>().ToArray();
				e.Menu.Items.Clear();
				object[] array2 = array;
				foreach (object newItem in array2)
				{
					contextMenu.Items.Add(newItem);
				}
				return;
			}
		}
		P_1.Cancel = true;
		QKx.PopupMenu = new ContextMenu();
	}

	[SpecialName]
	private PopupButton aK8()
	{
		return QKx;
	}

	[SpecialName]
	private void aKD(PopupButton value)
	{
		if (QKx != null)
		{
			QKx.PopupOpening -= cBX;
		}
		QKx = value;
		if (QKx != null)
		{
			QKx.PopupMenu = new ContextMenu();
			QKx.PopupOpening += cBX;
		}
	}

	protected override void OnKeyDown(KeyEventArgs e)
	{
		if (e == null)
		{
			throw new ArgumentNullException(vVK.ssH(3942));
		}
		base.OnKeyDown(e);
		int num = 0;
		if (pHd() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (e.Handled)
		{
			return;
		}
		switch (e.Key)
		{
		case Key.System:
			if (e.SystemKey == Key.OemMinus && IsOptionsButtonVisible)
			{
				e.Handled = true;
				OpenOptionsMenu();
			}
			break;
		case Key.Escape:
			if (Yp.aR4() == ModifierKeys.Shift)
			{
				ToolWindow selectedToolWindow = SelectedToolWindow;
				if (selectedToolWindow != null && selectedToolWindow.CanCloseResolved)
				{
					selectedToolWindow.Close();
				}
			}
			break;
		}
	}

	static ToolWindowContainer()
	{
		IVH.CecNqz();
		CloseButtonContentTemplateProperty = DependencyProperty.Register(vVK.ssH(5464), typeof(DataTemplate), typeof(ToolWindowContainer), new PropertyMetadata(null));
		EmbeddedButtonStyleProperty = DependencyProperty.Register(vVK.ssH(602), typeof(Style), typeof(ToolWindowContainer), new PropertyMetadata(null));
		HasCloseButtonProperty = DependencyProperty.Register(vVK.ssH(6022), typeof(bool), typeof(ToolWindowContainer), new PropertyMetadata(true, GB4));
		HasTitleBarIconProperty = DependencyProperty.Register(vVK.ssH(18038), typeof(bool), typeof(ToolWindowContainer), new PropertyMetadata(false));
		HasToggleAutoHideButtonProperty = DependencyProperty.Register(vVK.ssH(18072), typeof(bool), typeof(ToolWindowContainer), new PropertyMetadata(true, GB4));
		IsCloseButtonVisibleProperty = DependencyProperty.Register(vVK.ssH(6164), typeof(bool), typeof(ToolWindowContainer), new PropertyMetadata(true));
		IsMaximizeButtonVisibleProperty = DependencyProperty.Register(vVK.ssH(18122), typeof(bool), typeof(ToolWindowContainer), new PropertyMetadata(false));
		IsMinimizeButtonVisibleProperty = DependencyProperty.Register(vVK.ssH(18172), typeof(bool), typeof(ToolWindowContainer), new PropertyMetadata(false));
		IsOptionsButtonVisibleProperty = DependencyProperty.Register(vVK.ssH(18222), typeof(bool), typeof(ToolWindowContainer), new PropertyMetadata(true));
		IsRestoreButtonVisibleProperty = DependencyProperty.Register(vVK.ssH(18270), typeof(bool), typeof(ToolWindowContainer), new PropertyMetadata(false));
		IsToggleAutoHideButtonVisibleProperty = DependencyProperty.Register(vVK.ssH(18318), typeof(bool), typeof(ToolWindowContainer), new PropertyMetadata(true));
		MaximizeButtonContentTemplateProperty = DependencyProperty.Register(vVK.ssH(18380), typeof(DataTemplate), typeof(ToolWindowContainer), new PropertyMetadata(null));
		MenuButtonContentTemplateProperty = DependencyProperty.Register(vVK.ssH(1252), typeof(DataTemplate), typeof(ToolWindowContainer), new PropertyMetadata(null));
		MinimizeButtonContentTemplateProperty = DependencyProperty.Register(vVK.ssH(18442), typeof(DataTemplate), typeof(ToolWindowContainer), new PropertyMetadata(null));
		PinButtonContentTemplateProperty = DependencyProperty.Register(vVK.ssH(6444), typeof(DataTemplate), typeof(ToolWindowContainer), new PropertyMetadata(null));
		RestoreButtonContentTemplateProperty = DependencyProperty.Register(vVK.ssH(18504), typeof(DataTemplate), typeof(ToolWindowContainer), new PropertyMetadata(null));
		SingleTabLayoutBehaviorProperty = DependencyProperty.Register(vVK.ssH(18564), typeof(SingleTabLayoutBehavior), typeof(ToolWindowContainer), new PropertyMetadata(SingleTabLayoutBehavior.Hide, vBH));
		TitleBarMinHeightProperty = DependencyProperty.Register(vVK.ssH(18614), typeof(double), typeof(ToolWindowContainer), new PropertyMetadata(22.0));
		TitleBarContextContentAlignmentProperty = DependencyProperty.Register(vVK.ssH(18652), typeof(ContextContentAlignment), typeof(ToolWindowContainer), new PropertyMetadata(ContextContentAlignment.Far));
		TitleFontFamilyProperty = DependencyProperty.Register(vVK.ssH(18718), typeof(FontFamily), typeof(ToolWindowContainer), new PropertyMetadata(TextBlock.FontFamilyProperty.DefaultMetadata.DefaultValue));
		TitleFontSizeProperty = DependencyProperty.Register(vVK.ssH(18752), typeof(double), typeof(ToolWindowContainer), new PropertyMetadata(TextBlock.FontSizeProperty.DefaultMetadata.DefaultValue));
		TitleFontWeightProperty = DependencyProperty.Register(vVK.ssH(18782), typeof(FontWeight), typeof(ToolWindowContainer), new PropertyMetadata(FontWeights.Normal));
		UnpinButtonContentTemplateProperty = DependencyProperty.Register(vVK.ssH(6642), typeof(DataTemplate), typeof(ToolWindowContainer), new PropertyMetadata(null));
		HasTitleBarGripperProperty = DependencyProperty.Register(vVK.ssH(18816), typeof(bool), typeof(ToolWindowContainer), new PropertyMetadata(false));
	}

	[CompilerGenerated]
	private void NB5(object P_0)
	{
		if (base.State != DockingWindowState.AutoHide && !AutoHidePerContainer)
		{
			ToolWindow selectedToolWindow = SelectedToolWindow;
			if (selectedToolWindow != null && selectedToolWindow.AutoHideCommand != null && selectedToolWindow.AutoHideCommand.CanExecute(P_0))
			{
				selectedToolWindow.AutoHideCommand.Execute(P_0);
				return;
			}
		}
		KBq(null, _0020: false);
	}

	[CompilerGenerated]
	private bool lBy(object P_0)
	{
		if (base.State == DockingWindowState.Docked)
		{
			DockHost dockHost = base.DockHost;
			if (dockHost != null && dockHost.Meg())
			{
				kq kq = dockHost.LayoutKind;
				if ((uint)kq <= 2u)
				{
					return false;
				}
			}
			return SelectedToolWindow?.CanAutoHideResolved ?? false;
		}
		return false;
	}

	[CompilerGenerated]
	private void gBo(object P_0)
	{
		Close();
	}

	[CompilerGenerated]
	private bool SBt(object P_0)
	{
		return base.SelectedWindow?.CanCloseResolved ?? false;
	}

	[CompilerGenerated]
	private void XBu(object P_0)
	{
		if (base.State == DockingWindowState.AutoHide && !AutoHidePerContainer)
		{
			ToolWindow selectedToolWindow = SelectedToolWindow;
			if (selectedToolWindow != null && selectedToolWindow.DockCommand != null && selectedToolWindow.DockCommand.CanExecute(P_0))
			{
				selectedToolWindow.DockCommand.Execute(P_0);
				return;
			}
		}
		zBV(_0020: false);
	}

	[CompilerGenerated]
	private bool cBz(object P_0)
	{
		ToolWindow selectedToolWindow = SelectedToolWindow;
		if (selectedToolWindow != null && selectedToolWindow.CanDockResolved)
		{
			if (base.State != DockingWindowState.Docked)
			{
				return true;
			}
			DockHost dockHost = base.DockHost;
			if (dockHost != null && dockHost.Meg())
			{
				kq kq = dockHost.LayoutKind;
				if ((uint)(kq - 1) <= 1u)
				{
					return true;
				}
			}
		}
		return false;
	}

	[CompilerGenerated]
	private void lKi(object P_0)
	{
		base.DockHost?.Qeb(WindowState.Maximized);
	}

	[CompilerGenerated]
	private void xKd(object P_0)
	{
		base.DockHost?.Qeb(WindowState.Minimized);
	}

	[CompilerGenerated]
	private void hKw(object P_0)
	{
		base.DockHost?.Qeb(WindowState.Normal);
	}

	[CompilerGenerated]
	private void VK2(object P_0)
	{
		if (base.State == DockingWindowState.AutoHide)
		{
			DockCommand.Execute(P_0);
		}
		else
		{
			AutoHideCommand.Execute(P_0);
		}
	}

	[CompilerGenerated]
	private bool CKe(object P_0)
	{
		if (base.State != DockingWindowState.AutoHide)
		{
			return AutoHideCommand.CanExecute(P_0);
		}
		return DockCommand.CanExecute(P_0);
	}

	internal static bool LHF()
	{
		return jHU == null;
	}

	internal static ToolWindowContainer pHd()
	{
		return jHU;
	}
}
