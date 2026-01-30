using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.Grids;
using ActiproSoftware.Windows.Controls.Grids.Automation.Peers;
using ActiproSoftware.Windows.Input;

namespace ActiproSoftware.Windows.Controls.Grids;

public class TreeListView : TreeListBox
{
	private double S6e;

	private ug M6r;

	private double R6G;

	private bool I6u;

	private bool z6O;

	public static readonly DependencyProperty AreColumnHeadersVisibleProperty;

	public static readonly DependencyProperty CanColumnsReorderProperty;

	public static readonly DependencyProperty CanColumnsResizeProperty;

	public static readonly DependencyProperty CanColumnsToggleVisibilityProperty;

	public static readonly DependencyProperty ColumnHeaderHeightProperty;

	public static readonly DependencyProperty ColumnHeaderVisibilityProperty;

	public static readonly DependencyProperty ExpansionColumnIndexProperty;

	public static readonly DependencyProperty FrozenColumnCountProperty;

	public static readonly DependencyProperty FrozenColumnsWidthProperty;

	[CompilerGenerated]
	private ICommand y6w;

	public static readonly RoutedEvent ColumnHeaderMenuRequestedEvent;

	public static readonly RoutedEvent ColumnHeaderTappedEvent;

	public static readonly RoutedEvent ColumnIsVisibleChangedEvent;

	public static readonly RoutedEvent ColumnReorderedEvent;

	public static readonly RoutedEvent ColumnsResizedEvent;

	public static readonly DependencyProperty IsDefaultColumnHeaderContextMenuEnabledProperty;

	internal static TreeListView bWh;

	public bool AreColumnHeadersVisible
	{
		get
		{
			return (bool)GetValue(AreColumnHeadersVisibleProperty);
		}
		set
		{
			SetValue(AreColumnHeadersVisibleProperty, value);
		}
	}

	public bool CanColumnsReorder
	{
		get
		{
			return (bool)GetValue(CanColumnsReorderProperty);
		}
		set
		{
			SetValue(CanColumnsReorderProperty, value);
		}
	}

	public bool CanColumnsResize
	{
		get
		{
			return (bool)GetValue(CanColumnsResizeProperty);
		}
		set
		{
			SetValue(CanColumnsResizeProperty, value);
		}
	}

	public bool CanColumnsToggleVisibility
	{
		get
		{
			return (bool)GetValue(CanColumnsToggleVisibilityProperty);
		}
		set
		{
			SetValue(CanColumnsToggleVisibilityProperty, value);
		}
	}

	public double ColumnHeaderHeight
	{
		get
		{
			return (double)GetValue(ColumnHeaderHeightProperty);
		}
		private set
		{
			SetValue(ColumnHeaderHeightProperty, value);
		}
	}

	public ObservableCollection<TreeListViewColumn> Columns => M6r;

	public int ExpansionColumnIndex
	{
		get
		{
			return (int)GetValue(ExpansionColumnIndexProperty);
		}
		set
		{
			SetValue(ExpansionColumnIndexProperty, value);
		}
	}

	public int FrozenColumnCount
	{
		get
		{
			return (int)GetValue(FrozenColumnCountProperty);
		}
		set
		{
			SetValue(FrozenColumnCountProperty, value);
		}
	}

	protected override bool IsKeyboardFocusWithinContent
	{
		get
		{
			bool flag = base.IsKeyboardFocusWithin;
			if (flag)
			{
				int num = 0;
				if (!BWu())
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				UIElement uIElement = LY.zld() as UIElement;
				while (uIElement != null && uIElement != this)
				{
					if (!(uIElement is TreeListViewColumnHeader))
					{
						uIElement = VisualTreeHelper.GetParent(uIElement) as UIElement;
						continue;
					}
					flag = false;
					break;
				}
			}
			return flag;
		}
	}

	public ICommand SizeAllColumnsToFitCommand
	{
		[CompilerGenerated]
		get
		{
			return y6w;
		}
		[CompilerGenerated]
		private set
		{
			y6w = value;
		}
	}

	public bool IsDefaultColumnHeaderContextMenuEnabled
	{
		get
		{
			return (bool)GetValue(IsDefaultColumnHeaderContextMenuEnabledProperty);
		}
		set
		{
			SetValue(IsDefaultColumnHeaderContextMenuEnabledProperty, value);
		}
	}

	public event EventHandler<TreeListViewColumnMenuEventArgs> ColumnHeaderMenuRequested
	{
		add
		{
			AddHandler(ColumnHeaderMenuRequestedEvent, value);
		}
		remove
		{
			RemoveHandler(ColumnHeaderMenuRequestedEvent, value);
		}
	}

	public event EventHandler<TreeListViewColumnEventArgs> ColumnHeaderTapped
	{
		add
		{
			AddHandler(ColumnHeaderTappedEvent, value);
		}
		remove
		{
			RemoveHandler(ColumnHeaderTappedEvent, value);
		}
	}

	public event EventHandler<TreeListViewColumnEventArgs> ColumnIsVisibleChanged
	{
		add
		{
			AddHandler(ColumnIsVisibleChangedEvent, value);
		}
		remove
		{
			RemoveHandler(ColumnIsVisibleChangedEvent, value);
		}
	}

	public event EventHandler<TreeListViewColumnEventArgs> ColumnReordered
	{
		add
		{
			AddHandler(ColumnReorderedEvent, value);
		}
		remove
		{
			RemoveHandler(ColumnReorderedEvent, value);
		}
	}

	public event RoutedEventHandler ColumnsResized
	{
		add
		{
			AddHandler(ColumnsResizedEvent, value);
		}
		remove
		{
			RemoveHandler(ColumnsResizedEvent, value);
		}
	}

	public TreeListView()
	{
		fc.taYSkz();
		base._002Ector();
		base.DefaultStyleKey = typeof(TreeListView);
		M6r = new ug();
		M6r.CollectionChanged += Q6J;
		M6r.OE0(i65);
		a61();
	}

	private void a61()
	{
		SizeAllColumnsToFitCommand = new DelegateCommand<object>(delegate
		{
			SizeAllColumnsToFit();
		});
	}

	internal TreeListViewColumn Q6t(TreeListViewColumn P_0)
	{
		int num = M6r.IndexOf(P_0);
		if (num != -1)
		{
			int num3 = default(int);
			for (num++; num < M6r.Count; num++)
			{
				if (!M6r[num].IsVisible)
				{
					continue;
				}
				int num2 = 0;
				if (!BWu())
				{
					num2 = num3;
				}
				switch (num2)
				{
				}
				if (M6r[num].Width.GridUnitType == GridUnitType.Star)
				{
					return M6r[num];
				}
			}
		}
		return null;
	}

	internal void i6U()
	{
		if (z6O)
		{
			I6u = true;
		}
		else
		{
			G6o();
		}
	}

	private static void E66(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((TreeListView)P_0).r6E(null);
	}

	private static void f6q(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((TreeListView)P_0).O6K();
	}

	private void Q6J(object P_0, NotifyCollectionChangedEventArgs P_1)
	{
		if (P_1 == null || P_1 is ug.mM)
		{
			return;
		}
		IList oldItems = P_1.OldItems;
		if (oldItems != null)
		{
			foreach (TreeListViewColumn item in oldItems)
			{
				item.mqk(null);
			}
		}
		IList newItems = P_1.NewItems;
		if (newItems != null)
		{
			foreach (TreeListViewColumn item2 in newItems)
			{
				item2.mqk(this);
			}
		}
		if (P_1.Action != NotifyCollectionChangedAction.Move)
		{
			return;
		}
		int num = 1;
		if (!BWu())
		{
			num = 1;
		}
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				ExpansionColumnIndex++;
				return;
			case 1:
			{
				int expansionColumnIndex = ExpansionColumnIndex;
				if (P_1.OldStartingIndex == expansionColumnIndex)
				{
					ExpansionColumnIndex = P_1.NewStartingIndex;
					return;
				}
				if (P_1.OldStartingIndex > expansionColumnIndex && P_1.NewStartingIndex <= expansionColumnIndex)
				{
					num = 0;
					if (QWq() != null)
					{
						num = num2;
					}
					break;
				}
				if (P_1.OldStartingIndex < expansionColumnIndex && P_1.NewStartingIndex >= expansionColumnIndex)
				{
					ExpansionColumnIndex--;
				}
				return;
			}
			}
		}
	}

	private void i65(object P_0, NotifyCollectionChangedEventArgs P_1)
	{
		j6C();
		A6N();
		i6p();
		O6K();
	}

	private static void v6W(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((TreeListView)P_0).M6r.EEF();
	}

	private static void m6n(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		TreeListView obj = (TreeListView)P_0;
		obj.j6C();
		obj.A6N();
		obj.i6p();
	}

	private void i6p()
	{
		double num = 0.0;
		double num2 = i14()?.HorizontalOffset ?? 0.0;
		int num4 = default(int);
		for (int i = 0; i < M6r.Count; i++)
		{
			TreeListViewColumn treeListViewColumn = M6r[i];
			if (treeListViewColumn == null || !treeListViewColumn.IsVisible)
			{
				continue;
			}
			if (!treeListViewColumn.IsFrozen)
			{
				treeListViewColumn.ClipX = Math.Max(0.0, R6G - (num - num2));
				int num3 = 0;
				if (QWq() != null)
				{
					num3 = num4;
				}
				switch (num3)
				{
				}
			}
			else
			{
				treeListViewColumn.ClipX = 0.0;
			}
			num += treeListViewColumn.ActualWidth;
		}
	}

	internal void r6E(double? P_0)
	{
		if (P_0.HasValue)
		{
			S6e = P_0.Value;
		}
		double num = (AreColumnHeadersVisible ? S6e : 0.0);
		if (ColumnHeaderHeight != num)
		{
			ColumnHeaderHeight = num;
		}
	}

	private void j6C()
	{
		int frozenColumnCount = FrozenColumnCount;
		for (int i = 0; i < M6r.Count; i++)
		{
			TreeListViewColumn treeListViewColumn = M6r[i];
			if (treeListViewColumn != null)
			{
				treeListViewColumn.IsFrozen = i < frozenColumnCount;
			}
		}
	}

	internal void O6K()
	{
		foreach (TreeListViewColumn item in M6r)
		{
			item?.CqP();
		}
	}

	private void A6N(bool P_0 = false)
	{
		double num = 0.0;
		foreach (TreeListViewColumn item in M6r)
		{
			if (item.IsVisible)
			{
				if (!item.IsFrozen)
				{
					break;
				}
				num += item.ActualWidth;
			}
		}
		if (P_0 || R6G != num)
		{
			R6G = num;
			ScrollViewer scrollViewer = i14();
			if (scrollViewer != null)
			{
				SetFrozenColumnsWidth(scrollViewer, R6G);
			}
		}
	}

	protected override Size ArrangeOverride(Size finalSize)
	{
		z6O = true;
		I6u = false;
		try
		{
			Size result = base.ArrangeOverride(finalSize);
			foreach (TreeListViewColumn item in M6r)
			{
				if (item.nqK())
				{
					item.Width = new GridLength(item.ActualWidth);
					item.YqN(value: false);
				}
			}
			return result;
		}
		finally
		{
			z6O = false;
			if (I6u)
			{
				G6o();
				I6u = false;
			}
		}
	}

	protected override void ClearContainerForItemOverride(DependencyObject element, object item)
	{
		base.ClearContainerForItemOverride(element, item);
		if (element is TreeListViewItem treeListViewItem)
		{
			treeListViewItem.hJR(null);
		}
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static Visibility GetColumnHeaderVisibility(ScrollViewer obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(xv.hTz(3974));
		}
		return (Visibility)obj.GetValue(ColumnHeaderVisibilityProperty);
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static void SetColumnHeaderVisibility(ScrollViewer obj, Visibility value)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(xv.hTz(3974));
		}
		obj.SetValue(ColumnHeaderVisibilityProperty, value);
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static double GetFrozenColumnsWidth(ScrollViewer obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(xv.hTz(3974));
		}
		return (double)obj.GetValue(FrozenColumnsWidthProperty);
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static void SetFrozenColumnsWidth(ScrollViewer obj, double value)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(xv.hTz(3974));
		}
		obj.SetValue(FrozenColumnsWidthProperty, value);
	}

	protected override DependencyObject GetContainerForItemOverride()
	{
		return new TreeListViewItem();
	}

	protected override bool IsItemItsOwnContainerOverride(object item)
	{
		return item is TreeListViewItem;
	}

	protected override Size MeasureOverride(Size availableSize)
	{
		z6O = true;
		I6u = false;
		try
		{
			return base.MeasureOverride(availableSize);
		}
		finally
		{
			z6O = false;
			if (I6u)
			{
				G6o();
				I6u = false;
			}
		}
	}

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		A6N(_0020: true);
		i6p();
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		return new TreeListViewAutomationPeer(this);
	}

	protected override void OnScrollViewerScrollChanged(ScrollChangedEventArgs e)
	{
		base.OnScrollViewerScrollChanged(e);
		if (e != null && (e.HorizontalChange != 0.0 || e.ExtentWidthChange != 0.0 || e.ViewportWidth != 0.0))
		{
			i6p();
		}
	}

	protected override void PrepareContainerForItemOverride(DependencyObject element, object item)
	{
		base.PrepareContainerForItemOverride(element, item);
		if (element is TreeListViewItem treeListViewItem)
		{
			treeListViewItem.hJR(this);
		}
	}

	public void SizeAllColumnsToFit()
	{
		foreach (TreeListViewColumn item in M6r)
		{
			if (item.Width.GridUnitType != GridUnitType.Star)
			{
				item.SizeToFit();
			}
		}
	}

	private void k6l(TreeListViewColumnMenuEventArgs P_0)
	{
		if (P_0.RoutedEvent == null)
		{
			P_0.RoutedEvent = ColumnHeaderMenuRequestedEvent;
		}
		if (P_0.Source == null)
		{
			P_0.Source = this;
		}
		OnColumnHeaderMenuRequested(P_0);
		RaiseEvent(P_0);
	}

	internal void T6g(TreeListViewColumnEventArgs P_0)
	{
		if (P_0.RoutedEvent == null)
		{
			P_0.RoutedEvent = ColumnHeaderTappedEvent;
		}
		if (P_0.Source == null)
		{
			P_0.Source = this;
		}
		OnColumnHeaderTapped(P_0);
		RaiseEvent(P_0);
	}

	internal void X6m(TreeListViewColumnEventArgs P_0)
	{
		A6N();
		i6p();
		if (P_0.RoutedEvent == null)
		{
			P_0.RoutedEvent = ColumnIsVisibleChangedEvent;
		}
		if (P_0.Source == null)
		{
			P_0.Source = this;
		}
		OnColumnIsVisibleChanged(P_0);
		RaiseEvent(P_0);
	}

	internal void C6T(TreeListViewColumnEventArgs P_0)
	{
		if (P_0.RoutedEvent == null)
		{
			P_0.RoutedEvent = ColumnReorderedEvent;
		}
		if (P_0.Source == null)
		{
			P_0.Source = this;
		}
		OnColumnReordered(P_0);
		RaiseEvent(P_0);
	}

	private void G6o()
	{
		A6N();
		i6p();
		RoutedEventArgs e = new RoutedEventArgs();
		if (e.RoutedEvent == null)
		{
			e.RoutedEvent = ColumnsResizedEvent;
		}
		if (e.Source == null)
		{
			e.Source = this;
		}
		OnColumnsResized(e);
		RaiseEvent(e);
		int num = 0;
		if (QWq() != null)
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

	protected virtual void OnColumnHeaderMenuRequested(TreeListViewColumnMenuEventArgs e)
	{
	}

	protected virtual void OnColumnHeaderTapped(TreeListViewColumnEventArgs e)
	{
	}

	protected virtual void OnColumnIsVisibleChanged(TreeListViewColumnEventArgs e)
	{
	}

	protected virtual void OnColumnReordered(TreeListViewColumnEventArgs e)
	{
	}

	protected virtual void OnColumnsResized(RoutedEventArgs e)
	{
	}

	internal ContextMenu a6Y(TreeListViewColumn P_0)
	{
		List<object> list = new List<object>();
		if (P_0 != null && P_0.IsResizeGripperEnabled)
		{
			list.Add(Q6Q(null, SR.GetString(SRName.UICommandSizeColumnToFitText), P_0.SizeToFitCommand));
		}
		if (M6r.Any((TreeListViewColumn c) => c.IsResizeGripperEnabled))
		{
			list.Add(Q6Q(null, SR.GetString(SRName.UICommandSizeAllColumnsToFitText), SizeAllColumnsToFitCommand));
		}
		int num = ((list.Count > 0) ? list.Count : (-1));
		foreach (TreeListViewColumn item in M6r)
		{
			if (!item.yq5())
			{
				continue;
			}
			string text = item.cqy();
			if (!string.IsNullOrEmpty(text))
			{
				if (num != -1)
				{
					list.Add(j6y());
					num = -1;
				}
				MenuItem menuItem = Q6Q(null, text, item.ToggleVisibilityCommand, null, item.IsVisible);
				if (item.nqE())
				{
					menuItem.IsEnabled = false;
				}
				list.Add(menuItem);
			}
		}
		if (list.Count == 0)
		{
			return null;
		}
		return F6k(list);
	}

	internal static ContextMenu F6k(IEnumerable<object> P_0)
	{
		ContextMenu contextMenu = new ContextMenu();
		if (P_0 != null)
		{
			foreach (FrameworkElement item in P_0)
			{
				contextMenu.Items.Add(item);
			}
		}
		return contextMenu;
	}

	internal static MenuItem Q6Q(ImageSource P_0, string P_1, ICommand P_2, object P_3 = null, bool? P_4 = null)
	{
		MenuItem menuItem = new MenuItem();
		if (P_4.HasValue)
		{
			menuItem.IsCheckable = true;
			menuItem.IsChecked = P_4.Value;
		}
		menuItem.CommandParameter = P_3;
		menuItem.Command = P_2;
		if (P_1 != null)
		{
			menuItem.Header = P_1.Replace(xv.hTz(5810), xv.hTz(5816));
		}
		else
		{
			menuItem.Header = null;
		}
		if (P_0 != null)
		{
			DynamicImage dynamicImage = new DynamicImage();
			dynamicImage.Width = 16.0;
			dynamicImage.Height = 16.0;
			dynamicImage.Stretch = Stretch.Uniform;
			dynamicImage.Source = P_0;
			menuItem.Icon = dynamicImage;
		}
		return menuItem;
	}

	internal static Separator j6y()
	{
		return new Separator();
	}

	internal void i6d(TreeListViewColumnMenuEventArgs P_0)
	{
		if (P_0 != null)
		{
			if (IsDefaultColumnHeaderContextMenuEnabled)
			{
				P_0.Menu = a6Y(P_0.Column);
			}
			k6l(P_0);
			return;
		}
		throw new ArgumentNullException(xv.hTz(3406));
	}

	static TreeListView()
	{
		fc.taYSkz();
		AreColumnHeadersVisibleProperty = DependencyProperty.Register(xv.hTz(5824), typeof(bool), typeof(TreeListView), new PropertyMetadata(true, E66));
		CanColumnsReorderProperty = DependencyProperty.Register(xv.hTz(5874), typeof(bool), typeof(TreeListView), new PropertyMetadata(false));
		CanColumnsResizeProperty = DependencyProperty.Register(xv.hTz(5912), typeof(bool), typeof(TreeListView), new PropertyMetadata(true, f6q));
		CanColumnsToggleVisibilityProperty = DependencyProperty.Register(xv.hTz(5948), typeof(bool), typeof(TreeListView), new PropertyMetadata(false));
		ColumnHeaderHeightProperty = DependencyProperty.RegisterAttached(xv.hTz(6004), typeof(double), typeof(TreeListView), new PropertyMetadata(0.0));
		ColumnHeaderVisibilityProperty = DependencyProperty.RegisterAttached(xv.hTz(6044), typeof(Visibility), typeof(TreeListView), new PropertyMetadata(Visibility.Visible));
		ExpansionColumnIndexProperty = DependencyProperty.Register(xv.hTz(6092), typeof(int), typeof(TreeListView), new PropertyMetadata(0, v6W));
		FrozenColumnCountProperty = DependencyProperty.Register(xv.hTz(6136), typeof(int), typeof(TreeListView), new PropertyMetadata(0, m6n));
		FrozenColumnsWidthProperty = DependencyProperty.RegisterAttached(xv.hTz(6174), typeof(double), typeof(TreeListView), new PropertyMetadata(0.0));
		ColumnHeaderMenuRequestedEvent = EventManager.RegisterRoutedEvent(xv.hTz(6214), RoutingStrategy.Bubble, typeof(EventHandler<TreeListViewColumnMenuEventArgs>), typeof(TreeListView));
		ColumnHeaderTappedEvent = EventManager.RegisterRoutedEvent(xv.hTz(6268), RoutingStrategy.Bubble, typeof(EventHandler<TreeListViewColumnEventArgs>), typeof(TreeListView));
		ColumnIsVisibleChangedEvent = EventManager.RegisterRoutedEvent(xv.hTz(6308), RoutingStrategy.Bubble, typeof(EventHandler<TreeListViewColumnEventArgs>), typeof(TreeListView));
		ColumnReorderedEvent = EventManager.RegisterRoutedEvent(xv.hTz(6356), RoutingStrategy.Bubble, typeof(EventHandler<TreeListViewColumnEventArgs>), typeof(TreeListView));
		ColumnsResizedEvent = EventManager.RegisterRoutedEvent(xv.hTz(6390), RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(TreeListView));
		IsDefaultColumnHeaderContextMenuEnabledProperty = DependencyProperty.Register(xv.hTz(6422), typeof(bool), typeof(TreeListView), new PropertyMetadata(true));
	}

	[CompilerGenerated]
	private void U6B(object P_0)
	{
		SizeAllColumnsToFit();
	}

	internal static bool BWu()
	{
		return bWh == null;
	}

	internal static TreeListView QWq()
	{
		return bWh;
	}
}
