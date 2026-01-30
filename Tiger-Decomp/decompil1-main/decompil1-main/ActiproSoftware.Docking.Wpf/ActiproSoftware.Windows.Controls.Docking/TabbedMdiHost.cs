using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Markup;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.Docking.Primitives;
using ActiproSoftware.Windows.Extensions;

namespace ActiproSoftware.Windows.Controls.Docking;

[ToolboxItem(false)]
[ContentProperty("Child")]
public class TabbedMdiHost : MdiHostBase, iy, IDockTarget, jJ, wH, lX
{
	public static readonly DependencyProperty CanDocumentsAttachProperty;

	public static readonly DependencyProperty CanDocumentsCloseOnMiddleClickProperty;

	public static readonly DependencyProperty CanDocumentsDockProperty;

	public static readonly DependencyProperty CanDocumentTabsDragProperty;

	public static readonly DependencyProperty ChildProperty;

	public static readonly DependencyProperty ContainersHaveNewTabButtonsProperty;

	public static readonly DependencyProperty EmptyContentProperty;

	public static readonly DependencyProperty EmptyContentTemplateProperty;

	public static readonly DependencyProperty HasTabCloseButtonsProperty;

	public static readonly DependencyProperty HasTabImagesProperty;

	public static readonly DependencyProperty HasTabPinButtonsProperty;

	public static readonly DependencyProperty HasTabPromoteButtonsProperty;

	public static readonly DependencyProperty TabControlStyleProperty;

	public static readonly DependencyProperty TabItemContainerStyleProperty;

	public static readonly DependencyProperty TabOverflowBehaviorProperty;

	public static readonly DependencyProperty TabStripPlacementProperty;

	[CompilerGenerated]
	private bool IB1;

	internal static TabbedMdiHost FHj;

	public bool CanDocumentsAttach
	{
		get
		{
			return (bool)GetValue(CanDocumentsAttachProperty);
		}
		set
		{
			SetValue(CanDocumentsAttachProperty, value);
		}
	}

	public bool CanDocumentsCloseOnMiddleClick
	{
		get
		{
			return (bool)GetValue(CanDocumentsCloseOnMiddleClickProperty);
		}
		set
		{
			SetValue(CanDocumentsCloseOnMiddleClickProperty, value);
		}
	}

	public bool CanDocumentsDock
	{
		get
		{
			return (bool)GetValue(CanDocumentsDockProperty);
		}
		set
		{
			SetValue(CanDocumentsDockProperty, value);
		}
	}

	public bool CanDocumentTabsDrag
	{
		get
		{
			return (bool)GetValue(CanDocumentTabsDragProperty);
		}
		set
		{
			SetValue(CanDocumentTabsDragProperty, value);
		}
	}

	public FrameworkElement Child
	{
		get
		{
			return (FrameworkElement)GetValue(ChildProperty);
		}
		set
		{
			SetValue(ChildProperty, value);
		}
	}

	public bool ContainersHaveNewTabButtons
	{
		get
		{
			return (bool)GetValue(ContainersHaveNewTabButtonsProperty);
		}
		set
		{
			SetValue(ContainersHaveNewTabButtonsProperty, value);
		}
	}

	public object EmptyContent
	{
		get
		{
			return GetValue(EmptyContentProperty);
		}
		set
		{
			SetValue(EmptyContentProperty, value);
		}
	}

	public DataTemplate EmptyContentTemplate
	{
		get
		{
			return (DataTemplate)GetValue(EmptyContentTemplateProperty);
		}
		set
		{
			SetValue(EmptyContentTemplateProperty, value);
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

	protected override IEnumerator LogicalChildren
	{
		get
		{
			FrameworkElement child = Child;
			if (child != null)
			{
				yield return child;
			}
		}
	}

	public Style TabControlStyle
	{
		get
		{
			return (Style)GetValue(TabControlStyleProperty);
		}
		set
		{
			SetValue(TabControlStyleProperty, value);
		}
	}

	public Style TabItemContainerStyle
	{
		get
		{
			return (Style)GetValue(TabItemContainerStyleProperty);
		}
		set
		{
			SetValue(TabItemContainerStyleProperty, value);
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

	public Side TabStripPlacement
	{
		get
		{
			return (Side)GetValue(TabStripPlacementProperty);
		}
		set
		{
			SetValue(TabStripPlacementProperty, value);
		}
	}

	bool iy.HasDockGuides => !xBk();

	bool iy.RequiresReverseOrderInsertion => false;

	bool wH.ContainsDockingWindows => xBk();

	bool wH.ContainsWorkspace => false;

	Size wH.DockedSize
	{
		get
		{
			return default(Size);
		}
		set
		{
			if (Child is TabbedMdiContainer tabbedMdiContainer)
			{
				tabbedMdiContainer.IEI(value);
			}
		}
	}

	DockHost wH.DockHost
	{
		get
		{
			return base.DockHost;
		}
		set
		{
			base.DockHost = value;
		}
	}

	Size wH.MaxSize
	{
		get
		{
			if (Child is wH wH)
			{
				return wH.MaxSize;
			}
			return new Size(double.PositiveInfinity, double.PositiveInfinity);
		}
	}

	Size wH.MinSize
	{
		get
		{
			if (!(Child is wH wH))
			{
				return default(Size);
			}
			return wH.MinSize;
		}
	}

	IEnumerable<lX> lX.ChildNodes
	{
		get
		{
			if (Child is lX lX)
			{
				yield return lX;
			}
		}
	}

	bool jJ.CanCascade => true;

	bool jJ.CanTile => true;

	MdiKind jJ.Kind => MdiKind.Tabbed;

	DockingWindow jJ.PrimaryWindow => base.PrimaryWindow;

	public TabbedMdiHost()
	{
		IVH.CecNqz();
		base._002Ector();
		base.DefaultStyleKey = typeof(TabbedMdiHost);
		base.Loaded += cWu;
	}

	[SpecialName]
	[CompilerGenerated]
	internal bool NBw()
	{
		return IB1;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void bB2(bool value)
	{
		IB1 = value;
	}

	private static void VW5(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		foreach (DockingWindow document in ((TabbedMdiHost)P_0).GetDocuments())
		{
			document.UpdateCanAttachResolved();
		}
	}

	private static void rWy(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		foreach (DockingWindow document in ((TabbedMdiHost)P_0).GetDocuments())
		{
			document.UpdateCanDockResolved();
		}
	}

	private static void tWo(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		foreach (DockingWindow document in ((TabbedMdiHost)P_0).GetDocuments())
		{
			document.UpdateCanDragTabResolved();
		}
	}

	private static void pWt(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		TabbedMdiHost tabbedMdiHost = (TabbedMdiHost)P_0;
		DependencyObject dependencyObject = P_1.OldValue as DependencyObject;
		int num;
		if (dependencyObject != null)
		{
			num = 0;
			if (!LHt())
			{
				goto IL_0005;
			}
			goto IL_0009;
		}
		goto IL_0114;
		IL_0114:
		if (P_1.NewValue is DependencyObject dependencyObject2 && LogicalTreeHelper.GetParent(dependencyObject2) == null)
		{
			tabbedMdiHost.AddLogicalChild(dependencyObject2);
		}
		wH wH = P_1.OldValue as wH;
		wH wH2 = P_1.NewValue as wH;
		if (wH != null && !tabbedMdiHost.NBw())
		{
			wH.DockHost = null;
		}
		if (wH2 != null)
		{
			wH2.DockHost = tabbedMdiHost.DockHost;
		}
		tabbedMdiHost.EWz(null);
		num = 1;
		if (iHp() != null)
		{
			goto IL_0005;
		}
		goto IL_0009;
		IL_0005:
		int num2 = default(int);
		num = num2;
		goto IL_0009;
		IL_0009:
		switch (num)
		{
		case 1:
			return;
		}
		if (LogicalTreeHelper.GetParent(dependencyObject) == tabbedMdiHost)
		{
			tabbedMdiHost.RemoveLogicalChild(dependencyObject);
		}
		goto IL_0114;
	}

	private void cWu(object P_0, RoutedEventArgs P_1)
	{
		LBd();
		EWz(null);
	}

	[SpecialName]
	internal TabbedMdiContainer XBG()
	{
		DockingWindow primaryWindow = base.PrimaryWindow;
		if (primaryWindow != null && primaryWindow.MkZ() is TabbedMdiContainer tabbedMdiContainer && tabbedMdiContainer.hWg() == this)
		{
			return tabbedMdiContainer;
		}
		return (from r in pL.Mxl<TabbedMdiContainer>(this, null)
			select r.dx3()).FirstOrDefault();
	}

	internal void EWz(TabbedMdiContainer P_0)
	{
		DockingWindow primaryWindow = base.PrimaryWindow;
		bool flag = primaryWindow == null || !primaryWindow.IsCurrentlyOpen || !primaryWindow.IsSelected;
		if (!flag)
		{
			flag = !(primaryWindow.MkZ() is TabbedMdiContainer tabbedMdiContainer) || tabbedMdiContainer.hWg() != this || (P_0 != null && P_0.SelectedWindow != null && P_0.SelectedWindow.LastActiveDateTime > primaryWindow.LastActiveDateTime);
		}
		if (flag)
		{
			base.PrimaryWindow = (P_0 ?? (from r in pL.Mxl<TabbedMdiContainer>(this, null)
				select r.dx3()).FirstOrDefault())?.SelectedWindow ?? GetDocuments().FirstOrDefault();
		}
	}

	public void Cascade()
	{
		base.DockSite?.s1t().AMX();
	}

	public sealed override IList<DockingWindow> GetDocuments()
	{
		return (from r in pL.Mxl<DockingWindow>(this, null)
			select r.dx3()).ToArray();
	}

	protected override void OnDockHostChanged(DockHost oldValue, DockHost newValue)
	{
		if (Child is wH wH)
		{
			wH.DockHost = newValue;
		}
	}

	public void TileHorizontally()
	{
		TileHorizontally(int.MaxValue);
	}

	public void TileHorizontally(int maxColumnCount)
	{
		base.DockSite?.s1t().UvQ(Orientation.Horizontal, maxColumnCount);
	}

	public void TileVertically()
	{
		TileVertically(int.MaxValue);
	}

	public void TileVertically(int maxRowCount)
	{
		base.DockSite?.s1t().UvQ(Orientation.Vertical, maxRowCount);
	}

	DockingWindowState IDockTarget.GetState(Side? side)
	{
		if (!side.HasValue)
		{
			return DockingWindowState.Document;
		}
		return DockingWindowState.Docked;
	}

	bool iy.SupportsAttach(DockHost draggedDockHost)
	{
		if (draggedDockHost != null)
		{
			return !pL.Mxl(draggedDockHost, (DockingWindow w) => !w.CanBecomeDocumentResolved).Any();
		}
		return true;
	}

	bool iy.SupportsInnerSideDock(DockHost draggedDockHost)
	{
		return false;
	}

	bool iy.SupportsOuterSideDock(DockHost draggedDockHost)
	{
		if (draggedDockHost != null)
		{
			kq kq = draggedDockHost.LayoutKind;
			if ((uint)(kq - 1) <= 1u)
			{
				DockHost dockHost = base.DockHost;
				if (dockHost == null)
				{
					return false;
				}
				return dockHost.GetVisibleToolWindowContainerCount(includeAutoHiddenContainers: false) > 0;
			}
		}
		return false;
	}

	int wH.GetVisibleToolWindowContainerCount()
	{
		return 0;
	}

	void jJ.AddRange(IEnumerable<DockingWindow> windowsToAdd)
	{
		TabbedMdiContainer tabbedMdiContainer = kBi();
		if (tabbedMdiContainer == null || windowsToAdd == null)
		{
			return;
		}
		IList<DockingWindow> documents = GetDocuments();
		foreach (DockingWindow item in windowsToAdd)
		{
			if (!documents.Contains(item))
			{
				tabbedMdiContainer.Windows.Add(item);
			}
		}
	}

	bool jJ.BringToFront(DockingWindow window)
	{
		if (window == null)
		{
			throw new ArgumentNullException(vVK.ssH(9098));
		}
		if (window.MkZ() is TabbedMdiContainer tabbedMdiContainer && tabbedMdiContainer.Windows.Contains(window))
		{
			if (tabbedMdiContainer.SelectedWindow != window)
			{
				tabbedMdiContainer.SelectedWindow = window;
				return true;
			}
			tabbedMdiContainer.YDT();
		}
		return false;
	}

	jJ jJ.CloneForFloatingDockHost()
	{
		TabbedMdiHost tabbedMdiHost = new TabbedMdiHost();
		tabbedMdiHost.BindToProperty(CanDocumentsAttachProperty, this, vVK.ssH(16906), BindingMode.OneWay);
		tabbedMdiHost.BindToProperty(CanDocumentsCloseOnMiddleClickProperty, this, vVK.ssH(16624), BindingMode.OneWay);
		tabbedMdiHost.BindToProperty(CanDocumentsDockProperty, this, vVK.ssH(16946), BindingMode.OneWay);
		tabbedMdiHost.BindToProperty(CanDocumentTabsDragProperty, this, vVK.ssH(16982), BindingMode.OneWay);
		tabbedMdiHost.BindToProperty(ContainersHaveNewTabButtonsProperty, this, vVK.ssH(16688), BindingMode.OneWay);
		tabbedMdiHost.BindToProperty(EmptyContentProperty, this, vVK.ssH(17024), BindingMode.OneWay);
		tabbedMdiHost.BindToProperty(EmptyContentTemplateProperty, this, vVK.ssH(17052), BindingMode.OneWay);
		tabbedMdiHost.BindToProperty(HasTabCloseButtonsProperty, this, vVK.ssH(678), BindingMode.OneWay);
		tabbedMdiHost.BindToProperty(HasTabImagesProperty, this, vVK.ssH(718), BindingMode.OneWay);
		tabbedMdiHost.BindToProperty(HasTabPinButtonsProperty, this, vVK.ssH(16746), BindingMode.OneWay);
		tabbedMdiHost.BindToProperty(HasTabPromoteButtonsProperty, this, vVK.ssH(16782), BindingMode.OneWay);
		tabbedMdiHost.BindToProperty(TabControlStyleProperty, this, vVK.ssH(16826), BindingMode.OneWay);
		tabbedMdiHost.BindToProperty(TabItemContainerStyleProperty, this, vVK.ssH(16860), BindingMode.OneWay);
		tabbedMdiHost.BindToProperty(TabOverflowBehaviorProperty, this, vVK.ssH(2998), BindingMode.OneWay);
		tabbedMdiHost.BindToProperty(TabStripPlacementProperty, this, vVK.ssH(3510), BindingMode.OneWay);
		return tabbedMdiHost;
	}

	void jJ.DetachFromPrimaryDockHost()
	{
		BindingOperations.ClearBinding(this, CanDocumentsAttachProperty);
		BindingOperations.ClearBinding(this, CanDocumentsCloseOnMiddleClickProperty);
		int num = 0;
		if (!LHt())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		BindingOperations.ClearBinding(this, CanDocumentsDockProperty);
		BindingOperations.ClearBinding(this, CanDocumentTabsDragProperty);
		BindingOperations.ClearBinding(this, ContainersHaveNewTabButtonsProperty);
		BindingOperations.ClearBinding(this, EmptyContentProperty);
		BindingOperations.ClearBinding(this, EmptyContentTemplateProperty);
		BindingOperations.ClearBinding(this, HasTabCloseButtonsProperty);
		BindingOperations.ClearBinding(this, HasTabImagesProperty);
		BindingOperations.ClearBinding(this, HasTabPinButtonsProperty);
		BindingOperations.ClearBinding(this, HasTabPromoteButtonsProperty);
		BindingOperations.ClearBinding(this, TabControlStyleProperty);
		BindingOperations.ClearBinding(this, TabItemContainerStyleProperty);
		BindingOperations.ClearBinding(this, TabOverflowBehaviorProperty);
		BindingOperations.ClearBinding(this, TabStripPlacementProperty);
	}

	IDockTarget jJ.GetDefaultDockTarget()
	{
		return kBi();
	}

	int jJ.GetIndexInContainer(DockingWindow window)
	{
		if (window == null)
		{
			throw new ArgumentNullException(vVK.ssH(9098));
		}
		if (!(window.MkZ() is TabbedMdiContainer tabbedMdiContainer))
		{
			return -1;
		}
		return tabbedMdiContainer.Windows.IndexOf(window);
	}

	void jJ.Remove(DockingWindow window, bool leaveBreadcrumb)
	{
		if (window == null)
		{
			throw new ArgumentNullException(vVK.ssH(9098));
		}
		if (GetDocuments().Contains(window) && window.MkZ() is TabbedMdiContainer tabbedMdiContainer)
		{
			if (!leaveBreadcrumb)
			{
				tabbedMdiContainer.Windows.Remove(window);
			}
			else
			{
				tabbedMdiContainer.pDp(window);
			}
		}
	}

	bool jJ.RestoreToDefaultLocation(DockingWindow window)
	{
		if (window == null)
		{
			throw new ArgumentNullException(vVK.ssH(9098));
		}
		if (!GetDocuments().Contains(window))
		{
			TabbedMdiContainer tabbedMdiContainer = kBi();
			if (tabbedMdiContainer != null)
			{
				if (tabbedMdiContainer.QE2())
				{
					window.ContainerDockedSize = tabbedMdiContainer.cEG();
				}
				bool flag = window.DockSite?.AreNewTabsInsertedBeforeExistingTabs ?? true;
				tabbedMdiContainer.Windows.Insert((!flag) ? tabbedMdiContainer.Windows.Count : 0, window);
				return true;
			}
		}
		return false;
	}

	void jJ.UpdateIsEmpty()
	{
		LBd();
	}

	[SpecialName]
	private bool xBk()
	{
		if (!(Child is wH wH))
		{
			return false;
		}
		return wH.ContainsDockingWindows;
	}

	private TabbedMdiContainer kBi()
	{
		TabbedMdiContainer tabbedMdiContainer = XBG();
		DockHost dockHost = base.DockHost;
		if (tabbedMdiContainer == null && dockHost != null && dockHost.DockSite != null)
		{
			tabbedMdiContainer = (TabbedMdiContainer)(Child = DockSite.gNd(dockHost));
		}
		return tabbedMdiContainer;
	}

	private void LBd()
	{
		base.IsEmpty = !pL.Mxl<DockingWindow>(this, null).Any();
	}

	static TabbedMdiHost()
	{
		IVH.CecNqz();
		CanDocumentsAttachProperty = DependencyProperty.Register(vVK.ssH(16906), typeof(bool), typeof(TabbedMdiHost), new PropertyMetadata(true, VW5));
		CanDocumentsCloseOnMiddleClickProperty = DependencyProperty.Register(vVK.ssH(16624), typeof(bool), typeof(TabbedMdiHost), new PropertyMetadata(true));
		CanDocumentsDockProperty = DependencyProperty.Register(vVK.ssH(16946), typeof(bool), typeof(TabbedMdiHost), new PropertyMetadata(true, rWy));
		CanDocumentTabsDragProperty = DependencyProperty.Register(vVK.ssH(16982), typeof(bool), typeof(TabbedMdiHost), new PropertyMetadata(true, tWo));
		ChildProperty = DependencyProperty.Register(vVK.ssH(7292), typeof(FrameworkElement), typeof(TabbedMdiHost), new PropertyMetadata(null, pWt));
		ContainersHaveNewTabButtonsProperty = DependencyProperty.Register(vVK.ssH(16688), typeof(bool), typeof(TabbedMdiHost), new PropertyMetadata(false));
		int num = 0;
		if (false)
		{
			int num2;
			num = num2;
		}
		switch (num)
		{
		}
		EmptyContentProperty = DependencyProperty.Register(vVK.ssH(17024), typeof(object), typeof(TabbedMdiHost), new PropertyMetadata(null));
		EmptyContentTemplateProperty = DependencyProperty.Register(vVK.ssH(17052), typeof(DataTemplate), typeof(TabbedMdiHost), new PropertyMetadata(new DataTemplate()));
		HasTabCloseButtonsProperty = DependencyProperty.Register(vVK.ssH(678), typeof(bool), typeof(TabbedMdiHost), new PropertyMetadata(true));
		HasTabImagesProperty = DependencyProperty.Register(vVK.ssH(718), typeof(bool), typeof(TabbedMdiHost), new PropertyMetadata(false));
		HasTabPinButtonsProperty = DependencyProperty.Register(vVK.ssH(16746), typeof(bool), typeof(TabbedMdiHost), new PropertyMetadata(false));
		HasTabPromoteButtonsProperty = DependencyProperty.Register(vVK.ssH(16782), typeof(bool), typeof(TabbedMdiHost), new PropertyMetadata(true));
		TabControlStyleProperty = DependencyProperty.Register(vVK.ssH(16826), typeof(Style), typeof(TabbedMdiHost), new PropertyMetadata(null));
		TabItemContainerStyleProperty = DependencyProperty.Register(vVK.ssH(16860), typeof(Style), typeof(TabbedMdiHost), new PropertyMetadata(null));
		TabOverflowBehaviorProperty = DependencyProperty.Register(vVK.ssH(2998), typeof(TabOverflowBehavior), typeof(TabbedMdiHost), new PropertyMetadata(TabOverflowBehavior.Menu));
		TabStripPlacementProperty = DependencyProperty.Register(vVK.ssH(3510), typeof(Side), typeof(TabbedMdiHost), new PropertyMetadata(Side.Top));
	}

	internal static bool LHt()
	{
		return FHj == null;
	}

	internal static TabbedMdiHost iHp()
	{
		return FHj;
	}
}
