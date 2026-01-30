using System;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.Grids.Primitives;
using ActiproSoftware.Windows.Input;
using ActiproSoftware.Windows.Media;

namespace ActiproSoftware.Windows.Controls.Grids;

[TemplatePart(Name = "PART_ResizeGripper", Type = typeof(FrameworkElement))]
[TemplatePart(Name = "PART_Chrome", Type = typeof(FrameworkElement))]
[TemplateVisualState(Name = "SortDescending", GroupName = "SortStates")]
[TemplateVisualState(Name = "Before", GroupName = "DropIndicatorAreaStates")]
[TemplateVisualState(Name = "Unfocused", GroupName = "FocusStates")]
[TemplateVisualState(Name = "After", GroupName = "DropIndicatorAreaStates")]
[TemplateVisualState(Name = "SortAscending", GroupName = "SortStates")]
[TemplateVisualState(Name = "Unsorted", GroupName = "SortStates")]
[TemplateVisualState(Name = "Normal", GroupName = "CommonStates")]
[TemplateVisualState(Name = "PointerOver", GroupName = "CommonStates")]
[ToolboxItem(false)]
[TemplateVisualState(Name = "Disabled", GroupName = "CommonStates")]
[TemplateVisualState(Name = "Off", GroupName = "DropIndicatorAreaStates")]
[TemplateVisualState(Name = "Focused", GroupName = "FocusStates")]
[TemplateVisualState(Name = "Pressed", GroupName = "CommonStates")]
public class TreeListViewColumnHeader : ContentControl
{
	private InputAdapter wJN;

	private TreeListViewColumn KJl;

	private FrameworkElement dJg;

	private InputAdapter NJm;

	private bool XJT;

	private bool kJo;

	private DateTime NJY;

	private Point RJk;

	private double RJQ;

	private double pJy;

	private Point? JJd;

	public static readonly DependencyProperty DropIndicatorAreaProperty;

	public static readonly DependencyProperty IsDraggingProperty;

	public static readonly DependencyProperty IsPressedProperty;

	public static readonly DependencyProperty IsResizeGripperEnabledProperty;

	public static readonly DependencyProperty RoleProperty;

	public static readonly DependencyProperty SortDirectionProperty;

	private static TreeListViewColumnHeader sWI;

	internal TreeListViewColumn Column
	{
		get
		{
			return KJl;
		}
		set
		{
			KJl = value;
		}
	}

	public TreeItemDropArea DropIndicatorArea
	{
		get
		{
			return (TreeItemDropArea)GetValue(DropIndicatorAreaProperty);
		}
		internal set
		{
			SetValue(DropIndicatorAreaProperty, value);
		}
	}

	public bool IsDragging
	{
		get
		{
			return (bool)GetValue(IsDraggingProperty);
		}
		private set
		{
			SetValue(IsDraggingProperty, value);
		}
	}

	public bool IsPressed
	{
		get
		{
			return (bool)GetValue(IsPressedProperty);
		}
		private set
		{
			SetValue(IsPressedProperty, value);
		}
	}

	public bool IsResizeGripperEnabled
	{
		get
		{
			return (bool)GetValue(IsResizeGripperEnabledProperty);
		}
		internal set
		{
			SetValue(IsResizeGripperEnabledProperty, value);
		}
	}

	public TreeListViewColumnHeaderRole Role
	{
		get
		{
			return (TreeListViewColumnHeaderRole)GetValue(RoleProperty);
		}
		set
		{
			SetValue(RoleProperty, value);
		}
	}

	public ColumnSortDirection? SortDirection
	{
		get
		{
			return (ColumnSortDirection?)GetValue(SortDirectionProperty);
		}
		set
		{
			SetValue(SortDirectionProperty, value);
		}
	}

	public TreeListViewColumnHeader()
	{
		fc.taYSkz();
		NJY = DateTime.Today;
		pJy = double.NaN;
		base._002Ector();
		base.DefaultStyleKey = typeof(TreeListViewColumnHeader);
		jqh();
	}

	private void jqh()
	{
		wJN = new InputAdapter(this);
		wJN.PointerCaptureLost += BqV;
		wJN.PointerEntered += iqf;
		wJN.PointerExited += cq0;
		wJN.PointerMoved += OqA;
		wJN.PointerPressed += Nq4;
		wJN.PointerReleased += PqS;
		wJN.AttachedEventKinds = InputAdapterEventKinds.PointerCaptureLost | InputAdapterEventKinds.PointerEntered | InputAdapterEventKinds.PointerExited | InputAdapterEventKinds.PointerMoved | InputAdapterEventKinds.PointerPressed | InputAdapterEventKinds.PointerReleased;
	}

	internal FrameworkElement gqZ()
	{
		return (GetTemplateChild(xv.hTz(7470)) as FrameworkElement) ?? this;
	}

	private int QqH()
	{
		if (KJl != null)
		{
			TreeListView treeListView = fJJ();
			int num = 0;
			if (!qWY())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			if (treeListView != null)
			{
				int num3 = treeListView.Columns.IndexOf(KJl);
				if (num3 != -1)
				{
					for (num3++; num3 < treeListView.Columns.Count; num3++)
					{
						if (treeListView.Columns[num3].IsVisible)
						{
							return num3;
						}
					}
				}
			}
		}
		return -1;
	}

	[SpecialName]
	private FrameworkElement aJU()
	{
		return dJg;
	}

	[SpecialName]
	private void mJ6(FrameworkElement value)
	{
		if (dJg != value)
		{
			if (NJm != null)
			{
				NJm.AttachedEventKinds = InputAdapterEventKinds.None;
				NJm.PointerCaptureLost -= Gq7;
				NJm.PointerMoved -= Nqs;
				NJm.PointerPressed -= TqF;
				NJm.PointerReleased -= oqc;
				NJm = null;
			}
			dJg = value;
			if (dJg != null)
			{
				NJm = new InputAdapter(dJg);
				NJm.PointerCaptureLost += Gq7;
				NJm.PointerMoved += Nqs;
				NJm.PointerPressed += TqF;
				NJm.PointerReleased += oqc;
				NJm.AttachedEventKinds = InputAdapterEventKinds.PointerCaptureLost | InputAdapterEventKinds.PointerMoved | InputAdapterEventKinds.PointerPressed | InputAdapterEventKinds.PointerReleased;
			}
		}
	}

	private static void xqD(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((TreeListViewColumnHeader)P_0).MJP(_0020: true);
	}

	private void Gq7(object P_0, InputPointerEventArgs P_1)
	{
		pJy = double.NaN;
		RJQ = 0.0;
	}

	private void Nqs(object P_0, InputPointerEventArgs P_1)
	{
		if (P_1 == null || KJl == null)
		{
			return;
		}
		int num = default(int);
		int num2;
		if (P_1.IsPositionOver(this))
		{
			num = QqH();
			num2 = 0;
			if (!qWY())
			{
				goto IL_0005;
			}
		}
		else
		{
			num2 = 2;
			if (!qWY())
			{
				goto IL_0005;
			}
		}
		goto IL_0009;
		IL_0009:
		TreeListViewColumnHeader treeListViewColumnHeader = default(TreeListViewColumnHeader);
		TreeListViewColumn treeListViewColumn = default(TreeListViewColumn);
		double num4 = default(double);
		while (true)
		{
			switch (num2)
			{
			case 2:
				P_1.Handled = true;
				WJI(_0020: false);
				break;
			default:
			{
				if (num == -1)
				{
					break;
				}
				TreeListViewHeaderRowPanel treeListViewHeaderRowPanel = UJW();
				if (treeListViewHeaderRowPanel == null || num >= treeListViewHeaderRowPanel.mCL().Count)
				{
					break;
				}
				treeListViewColumnHeader = treeListViewHeaderRowPanel.mCL()[num].Hmb() as TreeListViewColumnHeader;
				if (treeListViewColumnHeader == null || !P_1.IsPositionOver(treeListViewColumnHeader))
				{
					break;
				}
				num2 = 1;
				if (!qWY())
				{
					num2 = 1;
				}
				continue;
			}
			case 3:
			{
				if (treeListViewColumn == null)
				{
					return;
				}
				double num3 = KJl.ActualWidth + treeListViewColumn.ActualWidth;
				if (num3 > 0.0)
				{
					Math.Max(0.0, num3 - num4);
					if (num4 < KJl.ActualWidth)
					{
						num4 = Math.Max(KJl.NqT(), Math.Min(KJl.iqg(), num4));
					}
					else if (num4 > KJl.ActualWidth)
					{
						num4 = Math.Min(KJl.iqg(), Math.Max(KJl.NqT(), num4));
					}
					double num5 = Math.Max(0.0, Math.Min(1.0, num4 / num3));
					double num6 = 1.0 - num5;
					KJl.Width = new GridLength(num5 * RJQ, GridUnitType.Star);
					treeListViewColumn.Width = new GridLength(num6 * RJQ, GridUnitType.Star);
				}
				return;
			}
			case 1:
				P_1.Handled = true;
				treeListViewColumnHeader.WJI(_0020: true);
				break;
			}
			break;
		}
		if (double.IsNaN(pJy))
		{
			return;
		}
		TreeListView treeListView = fJJ();
		if (treeListView == null)
		{
			return;
		}
		P_1.Handled = true;
		Point position = P_1.GetPosition(treeListView);
		num4 = Math.Max(0.0, pJy + (position.X - RJk.X));
		if (KJl.Width.GridUnitType != GridUnitType.Star)
		{
			num4 = Math.Max(KJl.NqT(), Math.Min(KJl.iqg(), num4));
			KJl.Width = new GridLength(num4);
			return;
		}
		treeListViewColumn = treeListView.Q6t(KJl);
		int num7 = 3;
		goto IL_0005;
		IL_0005:
		num2 = num7;
		goto IL_0009;
	}

	private void TqF(object P_0, InputPointerButtonEventArgs P_1)
	{
		int num = 2;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
				{
					if (!P_1.IsPrimaryButton || dJg == null || KJl == null)
					{
						return;
					}
					WJI(_0020: false);
					DateTime nJY = NJY;
					NJY = DateTime.Now;
					if (KJl.Width.GridUnitType != GridUnitType.Star && NJY.Subtract(nJY).TotalMilliseconds < (double)LY.elG())
					{
						P_1.Handled = true;
						pJy = double.NaN;
						RJQ = 0.0;
						KJl.SizeToFit();
						return;
					}
					pJy = ((KJl.Width.GridUnitType == GridUnitType.Pixel) ? KJl.Width.Value : KJl.ActualWidth);
					RJQ = 0.0;
					TreeListView treeListView = fJJ();
					if (treeListView != null)
					{
						RJQ = KJl.Width.Value;
						TreeListViewColumn treeListViewColumn = treeListView.Q6t(KJl);
						if (treeListViewColumn != null)
						{
							RJQ += treeListViewColumn.Width.Value;
						}
						RJk = P_1.GetPosition(treeListView);
						P_1.Handled = true;
						NJm.CapturePointer(P_1);
						num2 = 0;
						if (LWM() == null)
						{
							continue;
						}
						break;
					}
					return;
				}
				case 0:
					return;
				case 2:
					if (P_1 == null)
					{
						return;
					}
					num2 = 1;
					if (LWM() == null)
					{
						continue;
					}
					break;
				}
				break;
			}
		}
	}

	private void oqc(object P_0, InputPointerButtonEventArgs P_1)
	{
		pJy = double.NaN;
		RJQ = 0.0;
		NJm.ReleasePointerCaptures();
	}

	private void BqV(object P_0, InputPointerEventArgs P_1)
	{
		if (kJo || IsPressed)
		{
			if (IsDragging)
			{
				UJW()?.SC1(_0020: true);
			}
			kJo = false;
			JJd = null;
			IsPressed = false;
			IsDragging = false;
			MJP(_0020: true);
			int num = 0;
			if (LWM() != null)
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

	private void iqf(object P_0, InputPointerEventArgs P_1)
	{
		WJI(_0020: true);
	}

	private void cq0(object P_0, InputPointerEventArgs P_1)
	{
		WJI(_0020: false);
	}

	private void OqA(object P_0, InputPointerEventArgs P_1)
	{
		WJI(_0020: true);
		if (IsDragging)
		{
			TreeListViewHeaderRowPanel treeListViewHeaderRowPanel = UJW();
			if (treeListViewHeaderRowPanel != null)
			{
				Point position = P_1.GetPosition(treeListViewHeaderRowPanel);
				treeListViewHeaderRowPanel.TCI(this, position);
			}
		}
		else
		{
			if (!JJd.HasValue || KJl == null)
			{
				return;
			}
			int num = 0;
			if (!qWY())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			if (!KJl.rqq())
			{
				return;
			}
			TreeListViewHeaderRowPanel treeListViewHeaderRowPanel2 = UJW();
			if (treeListViewHeaderRowPanel2 != null)
			{
				Point position2 = P_1.GetPosition(treeListViewHeaderRowPanel2);
				if (LY.vlR(JJd.Value, position2, P_1.DeviceKind == InputDeviceKind.Touch))
				{
					IsDragging = true;
					MJP(_0020: true);
					treeListViewHeaderRowPanel2.LCP(this, position2);
				}
			}
		}
	}

	private void Nq4(object P_0, InputPointerButtonEventArgs P_1)
	{
		if (P_1 != null && !P_1.Handled && base.IsEnabled && P_1.ButtonKind == InputPointerButtonKind.Primary && Role == TreeListViewColumnHeaderRole.Normal)
		{
			P_1.Handled = true;
			IsDragging = false;
			IsPressed = true;
			MJP(_0020: true);
			wJN.CapturePointer(P_1);
			TreeListViewHeaderRowPanel treeListViewHeaderRowPanel = UJW();
			if (treeListViewHeaderRowPanel != null)
			{
				JJd = P_1.GetPosition(treeListViewHeaderRowPanel);
				treeListViewHeaderRowPanel.kEz(0.0 - P_1.GetPosition(this).X);
			}
		}
	}

	private void PqS(object P_0, InputPointerButtonEventArgs P_1)
	{
		int num;
		if (!IsDragging)
		{
			if (KJl != null && P_1 != null && JJd.HasValue && P_1.IsPrimaryButton && P_1.IsPositionOver(this))
			{
				if (dJg == null || dJg.Visibility != Visibility.Visible)
				{
					goto IL_00b1;
				}
				if (!P_1.IsPositionOver(dJg))
				{
					num = 0;
					if (!qWY())
					{
						goto IL_0005;
					}
					goto IL_0009;
				}
			}
		}
		else
		{
			TreeListViewHeaderRowPanel treeListViewHeaderRowPanel = UJW();
			if (treeListViewHeaderRowPanel != null)
			{
				treeListViewHeaderRowPanel.SC1(_0020: false);
				num = 1;
				if (!qWY())
				{
					goto IL_0005;
				}
				goto IL_0009;
			}
		}
		goto IL_0154;
		IL_0005:
		int num2 = default(int);
		num = num2;
		goto IL_0009;
		IL_00b1:
		fJJ()?.T6g(new TreeListViewColumnEventArgs(KJl));
		goto IL_0154;
		IL_0154:
		JJd = null;
		IsPressed = false;
		IsDragging = false;
		MJP(_0020: true);
		wJN.ReleasePointerCaptures();
		return;
		IL_0009:
		switch (num)
		{
		case 1:
			goto IL_0154;
		}
		goto IL_00b1;
	}

	private static void Vqz(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((TreeListViewColumnHeader)P_0).MJP(_0020: true);
	}

	[SpecialName]
	private TreeListView fJJ()
	{
		return VisualTreeHelperExtended.GetAncestor<TreeListView>(this);
	}

	[SpecialName]
	private TreeListViewHeaderRowPanel UJW()
	{
		return VisualTreeHelperExtended.GetAncestor<TreeListViewHeaderRowPanel>(this);
	}

	private void WJI(bool P_0)
	{
		if (kJo != P_0)
		{
			kJo = P_0;
			MJP(_0020: true);
		}
	}

	internal void MJP(bool P_0)
	{
		if (!base.IsEnabled)
		{
			VisualStateManager.GoToState(this, xv.hTz(5192), P_0);
		}
		else if (IsDragging)
		{
			VisualStateManager.GoToState(this, xv.hTz(5346), P_0);
		}
		else if (Role == TreeListViewColumnHeaderRole.Padding)
		{
			VisualStateManager.GoToState(this, xv.hTz(5390), P_0);
		}
		else if (IsPressed)
		{
			VisualStateManager.GoToState(this, xv.hTz(5346), P_0);
		}
		else if (kJo)
		{
			VisualStateManager.GoToState(this, xv.hTz(5364), P_0);
		}
		else
		{
			VisualStateManager.GoToState(this, xv.hTz(5390), P_0);
		}
		if (XJT)
		{
			VisualStateManager.GoToState(this, xv.hTz(5406), P_0);
		}
		else
		{
			VisualStateManager.GoToState(this, xv.hTz(5424), P_0);
		}
		switch (DropIndicatorArea)
		{
		case TreeItemDropArea.After:
			VisualStateManager.GoToState(this, xv.hTz(5446), P_0);
			break;
		case TreeItemDropArea.Before:
			VisualStateManager.GoToState(this, xv.hTz(5460), P_0);
			break;
		default:
			VisualStateManager.GoToState(this, xv.hTz(5484), P_0);
			break;
		}
		switch (SortDirection)
		{
		case ColumnSortDirection.Ascending:
			VisualStateManager.GoToState(this, xv.hTz(7496), P_0);
			break;
		case ColumnSortDirection.Descending:
			VisualStateManager.GoToState(this, xv.hTz(7526), P_0);
			break;
		default:
			VisualStateManager.GoToState(this, xv.hTz(7558), P_0);
			break;
		}
	}

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		mJ6(GetTemplateChild(xv.hTz(7578)) as FrameworkElement);
		MJP(_0020: false);
	}

	protected override void OnGotFocus(RoutedEventArgs e)
	{
		base.OnGotFocus(e);
		XJT = true;
		MJP(_0020: true);
	}

	protected override void OnLostFocus(RoutedEventArgs e)
	{
		base.OnLostFocus(e);
		XJT = false;
		MJP(_0020: true);
	}

	public override string ToString()
	{
		return string.Format(CultureInfo.InvariantCulture, xv.hTz(5494), new object[2]
		{
			GetType().Name,
			base.Content
		});
	}

	protected override void OnContextMenuOpening(ContextMenuEventArgs e)
	{
		base.OnContextMenuOpening(e);
		if (e == null || e.Handled || !ContextMenuService.GetIsEnabled(this))
		{
			return;
		}
		TreeListView treeListView = fJJ();
		if (treeListView == null)
		{
			return;
		}
		TreeListViewColumnMenuEventArgs e2 = new TreeListViewColumnMenuEventArgs(KJl);
		treeListView.i6d(e2);
		if (e2.Cancel || e2.Menu == null)
		{
			e.Handled = e2.Handled;
			int num = 0;
			if (!qWY())
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
		else
		{
			e2.Menu.PlacementTarget = this;
			e2.Menu.IsOpen = true;
			e.Handled = true;
		}
	}

	static TreeListViewColumnHeader()
	{
		fc.taYSkz();
		DropIndicatorAreaProperty = DependencyProperty.Register(xv.hTz(5558), typeof(TreeItemDropArea), typeof(TreeListViewColumnHeader), new PropertyMetadata(TreeItemDropArea.None, xqD));
		IsDraggingProperty = DependencyProperty.Register(xv.hTz(7618), typeof(bool), typeof(TreeListViewColumnHeader), new PropertyMetadata(false));
		IsPressedProperty = DependencyProperty.Register(xv.hTz(7642), typeof(bool), typeof(TreeListViewColumnHeader), new PropertyMetadata(false));
		IsResizeGripperEnabledProperty = DependencyProperty.Register(xv.hTz(7116), typeof(bool), typeof(TreeListViewColumnHeader), new PropertyMetadata(false));
		RoleProperty = DependencyProperty.Register(xv.hTz(7664), typeof(TreeListViewColumnHeaderRole), typeof(TreeListViewColumnHeader), new PropertyMetadata(TreeListViewColumnHeaderRole.Normal));
		SortDirectionProperty = DependencyProperty.Register(xv.hTz(7226), typeof(ColumnSortDirection?), typeof(TreeListViewColumnHeader), new PropertyMetadata(null, Vqz));
	}

	internal static bool qWY()
	{
		return sWI == null;
	}

	internal static TreeListViewColumnHeader LWM()
	{
		return sWI;
	}
}
