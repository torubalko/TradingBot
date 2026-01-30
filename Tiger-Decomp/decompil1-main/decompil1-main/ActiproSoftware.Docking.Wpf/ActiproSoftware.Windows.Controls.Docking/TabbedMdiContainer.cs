using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Markup;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.Docking.Automation.Peers;
using ActiproSoftware.Windows.Controls.Docking.Primitives;
using ActiproSoftware.Windows.Extensions;

namespace ActiproSoftware.Windows.Controls.Docking;

[ContentProperty("Windows")]
[ToolboxItem(false)]
public class TabbedMdiContainer : DockingWindowContainerBase, iy, IDockTarget, ac, G0, zj, IOrientedElement
{
	public static readonly DependencyProperty HasNewTabButtonProperty;

	public static readonly DependencyProperty HasTabCloseButtonsProperty;

	public static readonly DependencyProperty HasTabPinButtonsProperty;

	public static readonly DependencyProperty HasTabPromoteButtonsProperty;

	internal static TabbedMdiContainer hHo;

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

	public bool HasTabPinButtons
	{
		get
		{
			return (bool)GetValue(HasTabPinButtonsProperty);
		}
		set
		{
			SetValue(HasTabPinButtonsProperty, value);
		}
	}

	public bool HasTabPromoteButtons
	{
		get
		{
			return (bool)GetValue(HasTabPromoteButtonsProperty);
		}
		set
		{
			SetValue(HasTabPromoteButtonsProperty, value);
		}
	}

	[SuppressMessage("Microsoft.Security", "CA2119:SealMethodsThatSatisfyPrivateInterfaces")]
	public ObservableCollection<DockingWindow> Windows => base.WindowsCore;

	bool iy.HasDockGuides => true;

	bool iy.RequiresReverseOrderInsertion => false;

	bool ac.IsWrapper => false;

	jJ ac.MdiHost => hWg();

	Size zj.TabPanelSize => TDy();

	public TabbedMdiContainer()
	{
		IVH.CecNqz();
		base._002Ector();
		base.DefaultStyleKey = typeof(TabbedMdiContainer);
		base.State = DockingWindowState.Document;
	}

	[SpecialName]
	internal TabbedMdiHost hWg()
	{
		DockHost dockHost = base.DockHost;
		if (dockHost == null)
		{
			return null;
		}
		return dockHost.veR() as TabbedMdiHost;
	}

	private void AW0(object P_0, EventArgs P_1)
	{
		yWh();
	}

	private void yWh()
	{
		TabbedMdiHost tabbedMdiHost = hWg();
		int num;
		if (tabbedMdiHost == null)
		{
			BindingOperations.ClearBinding(this, DockingWindowContainerBase.CanTabsCloseOnMiddleClickProperty);
			BindingOperations.ClearBinding(this, HasNewTabButtonProperty);
			BindingOperations.ClearBinding(this, HasTabCloseButtonsProperty);
			BindingOperations.ClearBinding(this, DockingWindowContainerBase.HasTabImagesProperty);
			BindingOperations.ClearBinding(this, HasTabPinButtonsProperty);
			BindingOperations.ClearBinding(this, HasTabPromoteButtonsProperty);
			BindingOperations.ClearBinding(this, DockingWindowContainerBase.TabControlStyleProperty);
			BindingOperations.ClearBinding(this, DockingWindowContainerBase.TabItemContainerStyleProperty);
			BindingOperations.ClearBinding(this, DockingWindowContainerBase.TabOverflowBehaviorProperty);
			num = 1;
			if (kH5() != null)
			{
				goto IL_0005;
			}
		}
		else
		{
			this.BindToProperty(DockingWindowContainerBase.CanTabsCloseOnMiddleClickProperty, tabbedMdiHost, vVK.ssH(16624), BindingMode.OneWay);
			this.BindToProperty(HasNewTabButtonProperty, tabbedMdiHost, vVK.ssH(16688), BindingMode.OneWay);
			num = 0;
			if (!uHB())
			{
				goto IL_0005;
			}
		}
		goto IL_0009;
		IL_0009:
		switch (num)
		{
		case 1:
			BindingOperations.ClearBinding(this, DockingWindowContainerBase.TabStripPlacementProperty);
			return;
		}
		this.BindToProperty(HasTabCloseButtonsProperty, tabbedMdiHost, vVK.ssH(678), BindingMode.OneWay);
		this.BindToProperty(DockingWindowContainerBase.HasTabImagesProperty, tabbedMdiHost, vVK.ssH(718), BindingMode.OneWay);
		this.BindToProperty(HasTabPinButtonsProperty, tabbedMdiHost, vVK.ssH(16746), BindingMode.OneWay);
		this.BindToProperty(HasTabPromoteButtonsProperty, tabbedMdiHost, vVK.ssH(16782), BindingMode.OneWay);
		this.BindToProperty(DockingWindowContainerBase.TabControlStyleProperty, tabbedMdiHost, vVK.ssH(16826), BindingMode.OneWay);
		this.BindToProperty(DockingWindowContainerBase.TabItemContainerStyleProperty, tabbedMdiHost, vVK.ssH(16860), BindingMode.OneWay);
		this.BindToProperty(DockingWindowContainerBase.TabOverflowBehaviorProperty, tabbedMdiHost, vVK.ssH(2998), BindingMode.OneWay);
		this.BindToProperty(DockingWindowContainerBase.TabStripPlacementProperty, tabbedMdiHost, vVK.ssH(3510), BindingMode.OneWay);
		return;
		IL_0005:
		int num2 = default(int);
		num = num2;
		goto IL_0009;
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		return new TabbedMdiContainerAutomationPeer(this);
	}

	protected override void OnDockSiteChanged(DockSite oldDockSite, DockSite newDockSite)
	{
		base.OnDockSiteChanged(oldDockSite, newDockSite);
		oldDockSite?.FQH(AW0);
		if (newDockSite != null)
		{
			newDockSite.nQA(AW0);
			foreach (DockingWindow window in Windows)
			{
				if (window != null)
				{
					window.DockSite = newDockSite;
				}
			}
		}
		yWh();
	}

	protected override void OnSelectedWindowChanged(DockingWindow oldSelectedWindow, DockingWindow newSelectedWindow)
	{
		hWg()?.EWz(this);
	}

	protected override void OnTabControlMenuOpening(AdvancedTabControlMenuEventArgs e)
	{
		DockSite dockSite = base.DockSite;
		if (e == null || dockSite == null)
		{
			return;
		}
		DockingWindow dockingWindow = ((e.TabItem != null) ? (e.TabItem.Content as DockingWindow) : null) ?? base.SelectedWindow;
		if (dockingWindow != null)
		{
			DockingMenuEventArgs e2 = new DockingMenuEventArgs((e.TabItem != null) ? DockingMenuKind.TabbedMdiContainerTabContextMenu : DockingMenuKind.TabbedMdiContainerOverflowMenu)
			{
				Window = dockingWindow
			};
			if (e.TabItem != null)
			{
				e2.Menu = dockSite.INv(dockingWindow);
			}
			else
			{
				e2.Menu = e.Menu;
			}
			dockSite.C19(e2);
			e.Menu = e2.Menu;
		}
	}

	protected override void OnWindowsChanged(NotifyCollectionChangedEventArgs e)
	{
		hWg()?.EWz(this);
	}

	protected override void UpdateDockingWindowStates()
	{
		DockingWindowState dockingWindowState = DockingWindowState.Document;
		foreach (DockingWindow window in Windows)
		{
			if (window != null && window.QkM() != dockingWindowState)
			{
				window.zIH(dockingWindowState);
			}
		}
	}

	DockingWindowState IDockTarget.GetState(Side? side)
	{
		return DockingWindowState.Document;
	}

	bool iy.SupportsAttach(DockHost draggedDockHost)
	{
		if (draggedDockHost != null && Windows.All((DockingWindow w) => w.CanAttachResolved))
		{
			return !pL.Mxl(draggedDockHost, (DockingWindow w) => !w.CanBecomeDocumentResolved).Any();
		}
		return false;
	}

	bool iy.SupportsInnerSideDock(DockHost draggedDockHost)
	{
		if (draggedDockHost != null && !draggedDockHost.Ce8())
		{
			return !pL.Mxl(draggedDockHost, (DockingWindow w) => !w.CanBecomeDocumentResolved).Any();
		}
		return false;
	}

	bool iy.SupportsOuterSideDock(DockHost draggedDockHost)
	{
		return ((iy)hWg())?.SupportsOuterSideDock(draggedDockHost) ?? false;
	}

	bool zj.IsOverTabStrip(Point location)
	{
		return gDE(location);
	}

	bool zj.IsOverTitleBar(Point location)
	{
		return false;
	}

	protected override void OnKeyDown(KeyEventArgs e)
	{
		if (e == null)
		{
			throw new ArgumentNullException(vVK.ssH(3942));
		}
		base.OnKeyDown(e);
		if (e.Handled)
		{
			return;
		}
		if (e.Key == Key.System && e.SystemKey == Key.OemMinus)
		{
			DockingWindow selectedWindow = base.SelectedWindow;
			if (selectedWindow != null)
			{
				AdvancedTabControl tabControl = base.TabControl;
				if (tabControl != null && tabControl.ItemContainerGenerator.ContainerFromItem(selectedWindow) is AdvancedTabItem advancedTabItem)
				{
					e.Handled = true;
					tabControl.iX(advancedTabItem, null);
					return;
				}
			}
		}
		if (e.Key == Key.Down && Keyboard.Modifiers == (ModifierKeys.Alt | ModifierKeys.Control))
		{
			AdvancedTabControl tabControl2 = base.TabControl;
			if (tabControl2 != null && tabControl2.IsMenuButtonVisible)
			{
				e.Handled = true;
				tabControl2.jdk();
			}
		}
	}

	static TabbedMdiContainer()
	{
		IVH.CecNqz();
		HasNewTabButtonProperty = DependencyProperty.Register(vVK.ssH(644), typeof(bool), typeof(TabbedMdiContainer), new PropertyMetadata(false));
		HasTabCloseButtonsProperty = DependencyProperty.Register(vVK.ssH(678), typeof(bool), typeof(TabbedMdiContainer), new PropertyMetadata(true));
		HasTabPinButtonsProperty = DependencyProperty.Register(vVK.ssH(16746), typeof(bool), typeof(TabbedMdiContainer), new PropertyMetadata(false));
		HasTabPromoteButtonsProperty = DependencyProperty.Register(vVK.ssH(16782), typeof(bool), typeof(TabbedMdiContainer), new PropertyMetadata(true));
	}

	internal static bool uHB()
	{
		return hHo == null;
	}

	internal static TabbedMdiContainer kH5()
	{
		return hHo;
	}
}
