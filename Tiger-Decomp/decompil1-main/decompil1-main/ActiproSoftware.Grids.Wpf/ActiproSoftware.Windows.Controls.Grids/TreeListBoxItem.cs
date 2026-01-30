using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.Grids.Automation.Peers;
using ActiproSoftware.Windows.Controls.Grids.Primitives;
using ActiproSoftware.Windows.Input;
using ActiproSoftware.Windows.Media;

namespace ActiproSoftware.Windows.Controls.Grids;

[TemplateVisualState(Name = "Disabled", GroupName = "CommonStates")]
[TemplateVisualState(Name = "Selected", GroupName = "CommonStates")]
[TemplateVisualState(Name = "Normal", GroupName = "CommonStates")]
[TemplateVisualState(Name = "Before", GroupName = "DropIndicatorAreaStates")]
[TemplateVisualState(Name = "Off", GroupName = "DropIndicatorAreaStates")]
[TemplateVisualState(Name = "Unfocused", GroupName = "FocusStates")]
[ToolboxItem(false)]
[TemplateVisualState(Name = "After", GroupName = "DropIndicatorAreaStates")]
[TemplateVisualState(Name = "On", GroupName = "DropIndicatorAreaStates")]
[TemplateVisualState(Name = "SelectedPointerOver", GroupName = "CommonStates")]
[TemplateVisualState(Name = "Pressed", GroupName = "CommonStates")]
[TemplateVisualState(Name = "PointerOver", GroupName = "CommonStates")]
[TemplateVisualState(Name = "SelectedUnfocused", GroupName = "CommonStates")]
[TemplateVisualState(Name = "Focused", GroupName = "FocusStates")]
[TemplateVisualState(Name = "SelectedPressed", GroupName = "CommonStates")]
public class TreeListBoxItem : ContentControl
{
	private static readonly DateTime KUI;

	private InputAdapter CUP;

	private bool gU1;

	private bool RUt;

	private bool UUU;

	private bool cU6;

	private bool EUq;

	private DateTime GUJ;

	private Point VU5;

	private DispatcherTimer RUW;

	private oT EUn;

	public static readonly DependencyProperty DefaultActionCommandProperty;

	public static readonly DependencyProperty DropIndicatorAreaProperty;

	public static readonly DependencyProperty IndentAmountProperty;

	public static readonly DependencyProperty IsExpandableProperty;

	public static readonly DependencyProperty IsExpandedProperty;

	public static readonly DependencyProperty IsSelectableProperty;

	public static readonly DependencyProperty IsSelectedProperty;

	public static readonly DependencyProperty ToggleExpansionButtonStyleProperty;

	public static readonly DependencyProperty InnerBorderThicknessProperty;

	public static readonly DependencyProperty TreeLineBrushProperty;

	private static TreeListBoxItem cWs;

	public ICommand DefaultActionCommand
	{
		get
		{
			return (ICommand)GetValue(DefaultActionCommandProperty);
		}
		set
		{
			SetValue(DefaultActionCommandProperty, value);
		}
	}

	public TreeItemDropArea DropIndicatorArea
	{
		get
		{
			return (TreeItemDropArea)GetValue(DropIndicatorAreaProperty);
		}
		private set
		{
			SetValue(DropIndicatorAreaProperty, value);
		}
	}

	public double IndentAmount
	{
		get
		{
			return (double)GetValue(IndentAmountProperty);
		}
		set
		{
			SetValue(IndentAmountProperty, value);
		}
	}

	public bool IsExpandable
	{
		get
		{
			return (bool)GetValue(IsExpandableProperty);
		}
		set
		{
			SetValue(IsExpandableProperty, value);
		}
	}

	public bool IsExpanded
	{
		get
		{
			return (bool)GetValue(IsExpandedProperty);
		}
		set
		{
			SetValue(IsExpandedProperty, value);
		}
	}

	public bool IsSelectable
	{
		get
		{
			return (bool)GetValue(IsSelectableProperty);
		}
		set
		{
			SetValue(IsSelectableProperty, value);
		}
	}

	public bool IsSelected
	{
		get
		{
			return (bool)GetValue(IsSelectedProperty);
		}
		set
		{
			SetValue(IsSelectedProperty, value);
		}
	}

	public Style ToggleExpansionButtonStyle
	{
		get
		{
			return (Style)GetValue(ToggleExpansionButtonStyleProperty);
		}
		set
		{
			SetValue(ToggleExpansionButtonStyleProperty, value);
		}
	}

	public Thickness InnerBorderThickness
	{
		get
		{
			return (Thickness)GetValue(InnerBorderThicknessProperty);
		}
		set
		{
			SetValue(InnerBorderThicknessProperty, value);
		}
	}

	public Brush TreeLineBrush
	{
		get
		{
			return (Brush)GetValue(TreeLineBrushProperty);
		}
		set
		{
			SetValue(TreeLineBrushProperty, value);
		}
	}

	public TreeListBoxItem()
	{
		fc.taYSkz();
		GUJ = KUI;
		base._002Ector();
		base.DefaultStyleKey = typeof(TreeListBoxItem);
		Ytw();
	}

	private void Ytw()
	{
		CUP = new InputAdapter(this);
		CUP.PointerCaptureLost += mta;
		CUP.PointerEntered += Yti;
		CUP.PointerExited += Vtb;
		CUP.PointerMoved += ath;
		CUP.PointerPressed += btZ;
		CUP.PointerReleased += stH;
		CUP.Tapped += stD;
		CUP.AttachedEventKinds = InputAdapterEventKinds.PointerCaptureLost | InputAdapterEventKinds.PointerEntered | InputAdapterEventKinds.PointerExited | InputAdapterEventKinds.PointerMoved | InputAdapterEventKinds.PointerPressed | InputAdapterEventKinds.PointerReleased | InputAdapterEventKinds.Tapped;
	}

	internal bool ztX(UC P_0)
	{
		if (P_0 == (UC)1)
		{
			if (EUn != null)
			{
				EUn.nNQ()?.o1O(EUn, _0020: false, _0020: true);
			}
			return Focus();
		}
		if (EUn != null && P_0 == (UC)2)
		{
			TreeListBox treeListBox = EUn.nNQ();
			treeListBox?.z1j(treeListBox.JtW(), EUn);
		}
		return Focus();
	}

	private TreeItemDropArea lt2(Point P_0)
	{
		TreeItemDropArea result = TreeItemDropArea.None;
		double actualHeight = base.ActualHeight;
		if (P_0.X >= 0.0 && P_0.X < base.ActualWidth && P_0.Y >= 0.0 && P_0.Y < actualHeight)
		{
			result = ((P_0.Y < actualHeight * 0.25) ? TreeItemDropArea.Before : ((!(P_0.Y > actualHeight * 0.75)) ? TreeItemDropArea.On : TreeItemDropArea.After));
		}
		return result;
	}

	private static bool ftv()
	{
		return Keyboard.IsKeyDown(Key.Tab);
	}

	private static void Pt8(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((TreeListBoxItem)P_0).Etf(_0020: true);
	}

	private static void ct9(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		TreeListBoxItem treeListBoxItem = (TreeListBoxItem)P_0;
		if (P_1.OldValue != P_1.NewValue)
		{
			treeListBoxItem.OnIndentAmountChanged();
		}
	}

	private static void Jt3(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		TreeListBoxItem treeListBoxItem = (TreeListBoxItem)P_0;
		bool? obj;
		bool? flag;
		if (treeListBoxItem != null)
		{
			obj = treeListBoxItem.EUn?.nNQ()?.HasTreeLines;
		}
		else
		{
			flag = null;
			int num = 0;
			if (YWR() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			obj = flag;
		}
		flag = obj;
		if (flag == true)
		{
			treeListBoxItem.Et0();
		}
	}

	private static void gtL(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		TreeListBoxItem treeListBoxItem = (TreeListBoxItem)P_0;
		if (treeListBoxItem.EUn != null)
		{
			treeListBoxItem.EUn.IsExpanded = (bool)P_1.NewValue;
		}
	}

	private static void ntj(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((TreeListBoxItem)P_0).Etf(_0020: true);
	}

	private static void Xtx(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		TreeListBoxItem treeListBoxItem = (TreeListBoxItem)P_0;
		if (treeListBoxItem.EUn != null)
		{
			treeListBoxItem.EUn.IsSelected = (bool)P_1.NewValue;
		}
		treeListBoxItem.Etf(_0020: true);
	}

	private void mta(object P_0, InputPointerEventArgs P_1)
	{
		if (UUU || cU6)
		{
			UUU = P_1.IsPositionOver(this);
			cU6 = false;
			EUq = false;
			Etf(_0020: true);
		}
	}

	private void Yti(object P_0, InputPointerEventArgs P_1)
	{
		UUU = true;
		Etf(_0020: true);
	}

	private void Vtb(object P_0, InputPointerEventArgs P_1)
	{
		UUU = false;
		Etf(_0020: true);
	}

	private void ath(object P_0, InputPointerEventArgs P_1)
	{
		UUU = true;
		Etf(_0020: true);
		if (!cU6 || gU1 || EUn == null || !EUn.IsSelected)
		{
			return;
		}
		TreeListBox treeListBox = EUn.nNQ();
		if (treeListBox == null)
		{
			return;
		}
		Point position = P_1.GetPosition(treeListBox);
		bool flag = P_1.DeviceKind == InputDeviceKind.Touch;
		if (LY.vlR(VU5, position, flag))
		{
			gU1 = true;
			treeListBox.d1U(P_1);
			int num = 0;
			if (YWR() != null)
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

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	private void btZ(object P_0, InputPointerButtonEventArgs P_1)
	{
		if (P_1 == null || P_1.Handled || !base.IsEnabled)
		{
			return;
		}
		itc();
		InputPointerButtonKind buttonKind = P_1.ButtonKind;
		if ((uint)buttonKind > 1u)
		{
			return;
		}
		gU1 = false;
		bool flag = false;
		TreeListBox treeListBox = ((EUn != null) ? EUn.nNQ() : null);
		if (P_1.ButtonKind == InputPointerButtonKind.Primary)
		{
			DateTime now = DateTime.Now;
			Point position = P_1.GetPosition((UIElement)(((object)treeListBox) ?? ((object)this)));
			int num = ((P_1.DeviceKind == InputDeviceKind.Touch) ? 10 : 3);
			flag = now.Subtract(GUJ).TotalMilliseconds <= (double)LY.elG() && new Rect(VU5.X - (double)num, VU5.Y - (double)num, 2 * num, 2 * num).Contains(position);
			GUJ = now;
			VU5 = position;
			cU6 = true;
			Etf(_0020: true);
			CUP.CapturePointer(P_1);
			if (flag)
			{
				GUJ = KUI;
			}
		}
		bool flag2 = LY.KlB(this);
		ztX((UC)0);
		if (EUn == null)
		{
			return;
		}
		if (flag)
		{
			OnDoubleTapped(P_1);
			P_1.Handled = true;
			return;
		}
		if (treeListBox != null)
		{
			EUq = true;
			switch (treeListBox.SelectionMode)
			{
			case SelectionMode.Extended:
				if ((LY.hle() & ModifierKeys.Control) == ModifierKeys.Control)
				{
					if (IsSelected)
					{
						treeListBox.M13(EUn);
					}
					else
					{
						treeListBox.o1O(EUn, _0020: true, _0020: true);
					}
				}
				else if ((LY.hle() & ModifierKeys.Shift) == ModifierKeys.Shift && treeListBox.JtW() != null)
				{
					treeListBox.z1j(treeListBox.JtW(), EUn);
				}
				else if (!IsSelected)
				{
					treeListBox.o1O(EUn, _0020: false, _0020: true);
				}
				else
				{
					EUq = false;
				}
				break;
			case SelectionMode.Multiple:
				if (P_1.ButtonKind != InputPointerButtonKind.Secondary || !IsSelected)
				{
					if (IsSelected)
					{
						treeListBox.M13(EUn);
					}
					else
					{
						treeListBox.o1O(EUn, _0020: true, _0020: true);
					}
				}
				break;
			default:
				if (!IsSelected)
				{
					treeListBox.o1O(EUn, _0020: false, _0020: true);
				}
				else
				{
					EUq = false;
				}
				break;
			}
		}
		P_1.Handled = !flag2 || EUq;
	}

	private void stH(object P_0, InputPointerButtonEventArgs P_1)
	{
		InputPointerButtonKind buttonKind = P_1.ButtonKind;
		if ((uint)buttonKind > 1u)
		{
			int num = 0;
			if (YWR() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			case 0:
				break;
			}
			return;
		}
		if (cU6 && !EUq && EUn != null)
		{
			TreeListBox treeListBox = EUn.nNQ();
			if (treeListBox != null && treeListBox.SelectedItems.Count > 1)
			{
				treeListBox.o1O(EUn, _0020: false, _0020: true);
			}
		}
		cU6 = false;
		EUq = false;
		Etf(_0020: true);
		CUP.ReleasePointerCaptures();
	}

	private void stD(object P_0, InputTappedEventArgs P_1)
	{
		if (EUn == null || !EUn.lKe())
		{
			return;
		}
		bool flag = false;
		int num = 0;
		if (!SWc())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		DependencyObject dependencyObject = VisualTreeHelper.HitTest(this, P_1.GetPosition(this))?.VisualHit;
		while (dependencyObject != null && dependencyObject != this)
		{
			if (!(dependencyObject is EditableContentControl))
			{
				dependencyObject = VisualTreeHelper.GetParent(dependencyObject);
				continue;
			}
			flag = true;
			break;
		}
		if (flag)
		{
			VtF();
		}
	}

	private void dt7(object P_0, object P_1)
	{
		itc();
		if (EUn != null && EUn.lKe())
		{
			EUn.oK7(_0020: true);
		}
	}

	private void kts()
	{
		RUt = false;
		UUU = false;
		cU6 = false;
		EUq = false;
	}

	private void VtF()
	{
		if (RUW == null)
		{
			RUW = new DispatcherTimer();
			RUW.Interval = TimeSpan.FromMilliseconds((double)LY.elG() * 1.5);
			RUW.Tick += dt7;
		}
		if (RUW.IsEnabled)
		{
			RUW.Stop();
		}
		RUW.Start();
	}

	private void itc()
	{
		if (RUW != null)
		{
			if (RUW.IsEnabled)
			{
				RUW.Stop();
			}
			RUW.Tick -= dt7;
			RUW = null;
		}
	}

	[SpecialName]
	internal oT ntA()
	{
		return EUn;
	}

	[SpecialName]
	internal void Et4(oT value)
	{
		if (EUn != value)
		{
			if (EUn != null)
			{
				itc();
				EUn.aKx(null);
			}
			EUn = value;
			if (EUn != null)
			{
				EUn.aKx(this);
				IsExpandable = EUn.IsExpandable;
				IsExpanded = EUn.IsExpanded;
				IsSelectable = EUn.IsSelectable;
				IsSelected = EUn.IsSelected;
				ctV();
				kts();
			}
		}
	}

	internal void ctV()
	{
		if (EUn != null)
		{
			TreeListBox treeListBox = EUn.nNQ();
			if (treeListBox != null)
			{
				TreeListBoxItemAdapter itemAdapter = treeListBox.ItemAdapter;
				if (itemAdapter == null)
				{
					IndentAmount = Math.Max(0.0, treeListBox.TopLevelIndent + (double)EUn.LKi() * treeListBox.IndentIncrement);
				}
				else
				{
					IndentAmount = itemAdapter.GetIndentAmount(treeListBox, EUn.sNm(), EUn.LKi());
				}
				return;
			}
		}
		IndentAmount = 20.0;
	}

	internal void Etf(bool P_0)
	{
		if (base.IsEnabled)
		{
			if (IsSelected)
			{
				if (cU6)
				{
					VisualStateManager.GoToState(this, xv.hTz(5212), P_0);
				}
				else if (!UUU)
				{
					if (EUn == null || EUn.nNQ() == null || !EUn.nNQ().IsKeyboardFocusWithin)
					{
						VisualStateManager.GoToState(this, xv.hTz(5308), P_0);
					}
					else
					{
						VisualStateManager.GoToState(this, xv.hTz(5288), P_0);
					}
				}
				else
				{
					VisualStateManager.GoToState(this, xv.hTz(5246), P_0);
				}
			}
			else
			{
				if ((!cU6 && !UUU) || !IsSelectable)
				{
					goto IL_01d4;
				}
				if (!cU6)
				{
					goto IL_00d6;
				}
				VisualStateManager.GoToState(this, xv.hTz(5346), P_0);
			}
		}
		else
		{
			VisualStateManager.GoToState(this, xv.hTz(5192), P_0);
		}
		goto IL_00ed;
		IL_00d6:
		VisualStateManager.GoToState(this, xv.hTz(5364), P_0);
		goto IL_00ed;
		IL_0009:
		int num;
		switch (num)
		{
		case 3:
			break;
		case 2:
			goto IL_00d6;
		case 1:
			goto IL_00ed;
		default:
			goto IL_01d4;
		}
		TreeItemDropArea dropIndicatorArea = default(TreeItemDropArea);
		switch (dropIndicatorArea)
		{
		case TreeItemDropArea.After:
			VisualStateManager.GoToState(this, xv.hTz(5446), P_0);
			break;
		case TreeItemDropArea.Before:
			VisualStateManager.GoToState(this, xv.hTz(5460), P_0);
			break;
		case TreeItemDropArea.On:
			VisualStateManager.GoToState(this, xv.hTz(5476), P_0);
			break;
		default:
			VisualStateManager.GoToState(this, xv.hTz(5484), P_0);
			break;
		}
		return;
		IL_01d4:
		VisualStateManager.GoToState(this, xv.hTz(5390), P_0);
		num = 1;
		if (!SWc())
		{
			int num2 = default(int);
			num = num2;
		}
		goto IL_0009;
		IL_00ed:
		if (RUt)
		{
			VisualStateManager.GoToState(this, xv.hTz(5406), P_0);
		}
		else
		{
			VisualStateManager.GoToState(this, xv.hTz(5424), P_0);
		}
		dropIndicatorArea = DropIndicatorArea;
		num = 3;
		if (YWR() == null)
		{
			num = 3;
		}
		goto IL_0009;
	}

	protected virtual bool IsLocationOverBackground(Point location)
	{
		return false;
	}

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		Etf(_0020: false);
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		return new TreeListBoxItemWrapperAutomationPeer(this);
	}

	protected virtual void OnDoubleTapped(InputPointerButtonEventArgs e)
	{
		if (EUn != null)
		{
			EUn.JKT();
		}
	}

	protected override void OnDragEnter(DragEventArgs e)
	{
		if (e == null)
		{
			throw new ArgumentNullException(xv.hTz(3406));
		}
		base.OnDragEnter(e);
		if (e.Handled)
		{
			DropIndicatorArea = TreeItemDropArea.None;
			return;
		}
		DropIndicatorArea = (EUn?.nNQ()?.jPs(e, this, lt2(e.GetPosition(this)))).GetValueOrDefault();
		e.Handled = true;
	}

	protected override void OnDragLeave(DragEventArgs e)
	{
		if (e == null)
		{
			throw new ArgumentNullException(xv.hTz(3406));
		}
		base.OnDragLeave(e);
		DropIndicatorArea = TreeItemDropArea.None;
		e.Handled = true;
	}

	protected override void OnDragOver(DragEventArgs e)
	{
		if (e == null)
		{
			throw new ArgumentNullException(xv.hTz(3406));
		}
		base.OnDragOver(e);
		if (e.Handled)
		{
			DropIndicatorArea = TreeItemDropArea.None;
			return;
		}
		DropIndicatorArea = (EUn?.nNQ()?.jPs(e, this, lt2(e.GetPosition(this)))).GetValueOrDefault();
		e.Handled = true;
	}

	protected override void OnDrop(DragEventArgs e)
	{
		if (e == null)
		{
			throw new ArgumentNullException(xv.hTz(3406));
		}
		base.OnDrop(e);
		TreeItemDropArea dropIndicatorArea = DropIndicatorArea;
		DropIndicatorArea = TreeItemDropArea.None;
		if (!e.Handled)
		{
			EUn?.nNQ()?.rPc(e, this, dropIndicatorArea);
		}
		e.Handled = true;
	}

	protected override void OnGotFocus(RoutedEventArgs e)
	{
		base.OnGotFocus(e);
		if (EUn != null)
		{
			EUn.nNQ()?.h1c(EUn);
		}
		RUt = true;
		Etf(_0020: true);
		if (IsSelected || !IsSelectable)
		{
			return;
		}
		oT oT = ntA();
		if (oT != null)
		{
			TreeListBox treeListBox = oT.nNQ();
			if (treeListBox != null && (treeListBox.SelectionMode == SelectionMode.Single || ftv()))
			{
				treeListBox.o1O(oT, _0020: false, _0020: true);
			}
		}
	}

	protected virtual void OnIndentAmountChanged()
	{
	}

	protected override void OnKeyDown(KeyEventArgs e)
	{
		base.OnKeyDown(e);
		if (e == null || EUn == null)
		{
			return;
		}
		if (EUn.pKD())
		{
			Key key = e.Key;
			int num = 0;
			if (!SWc())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			switch (key)
			{
			case Key.Left:
			case Key.Right:
				break;
			case Key.Prior:
			case Key.Next:
			case Key.End:
			case Key.Home:
			case Key.Up:
			case Key.Down:
				e.Handled = true;
				break;
			}
		}
		else
		{
			EUn.nNQ()?.ProcessKeyDown(e);
		}
	}

	protected override void OnLostFocus(RoutedEventArgs e)
	{
		base.OnLostFocus(e);
		RUt = false;
		Etf(_0020: true);
	}

	public override string ToString()
	{
		return string.Format(CultureInfo.InvariantCulture, xv.hTz(5494), new object[2]
		{
			GetType().Name,
			base.Content
		});
	}

	internal void Et0()
	{
		VisualTreeHelperExtended.GetDescendant<TreeLineDecorator>(this, 0)?.InvalidateVisual();
	}

	protected override void OnContextMenuOpening(ContextMenuEventArgs e)
	{
		base.OnContextMenuOpening(e);
		if (e == null || e.Handled || !ContextMenuService.GetIsEnabled(this) || EUn == null)
		{
			return;
		}
		int num = 1;
		if (YWR() != null)
		{
			goto IL_0005;
		}
		goto IL_0009;
		IL_0005:
		int num2 = default(int);
		num = num2;
		goto IL_0009;
		IL_0009:
		TreeListBoxItemMenuEventArgs e2 = default(TreeListBoxItemMenuEventArgs);
		TreeListBox treeListBox = default(TreeListBox);
		do
		{
			IL_0009_2:
			switch (num)
			{
			case 1:
				break;
			case 2:
				if (e2.Menu != null)
				{
					e2.Menu.PlacementTarget = this;
					e2.Menu.IsOpen = true;
					e.Handled = true;
					return;
				}
				goto IL_0179;
			default:
				{
					Point? pointerLocation = null;
					if (e.CursorLeft >= 0.0 && e.CursorTop >= 0.0)
					{
						pointerLocation = new Point(e.CursorLeft, e.CursorTop);
						Visual visual = e.OriginalSource as Visual;
						if (visual == null && e.OriginalSource is FrameworkContentElement frameworkContentElement)
						{
							visual = frameworkContentElement.Parent as Visual;
						}
						if (visual != null && visual != this)
						{
							try
							{
								if (visual.FindCommonVisualAncestor(this) != null)
								{
									pointerLocation = visual.TransformToVisual(this).Transform(pointerLocation.Value);
								}
							}
							catch (InvalidOperationException)
							{
							}
						}
					}
					bool isBackground = pointerLocation.HasValue && IsLocationOverBackground(pointerLocation.Value);
					e2 = new TreeListBoxItemMenuEventArgs(EUn.sNm(), this, pointerLocation, isBackground);
					treeListBox.U1g(e2);
					if (!e2.Cancel)
					{
						num = 2;
						goto IL_0009_2;
					}
					goto IL_0179;
				}
				IL_0179:
				e.Handled = e2.Handled;
				return;
			}
			treeListBox = EUn.nNQ();
			if (treeListBox != null)
			{
				num = 0;
				continue;
			}
			return;
		}
		while (YWR() == null);
		goto IL_0005;
	}

	protected override void OnIsKeyboardFocusWithinChanged(DependencyPropertyChangedEventArgs e)
	{
		base.OnIsKeyboardFocusWithinChanged(e);
		if (!e.NewValue.Equals(true) || Keyboard.FocusedElement == this)
		{
			return;
		}
		oT oT = ntA();
		if (oT != null)
		{
			TreeListBox treeListBox = oT.nNQ();
			if (treeListBox != null)
			{
				treeListBox.h1c(oT);
				treeListBox.o1O(oT, _0020: false, _0020: true);
			}
		}
	}

	protected override void OnTextInput(TextCompositionEventArgs e)
	{
		base.OnTextInput(e);
		if (e != null && !e.Handled && !string.IsNullOrEmpty(e.Text))
		{
			EUn?.nNQ()?.ptI().zEa(e.Text);
		}
	}

	static TreeListBoxItem()
	{
		int num = 1;
		while (true)
		{
			int num2 = num;
			do
			{
				switch (num2)
				{
				default:
					KUI = new DateTime(2016, 1, 1);
					DefaultActionCommandProperty = DependencyProperty.Register(xv.hTz(5514), typeof(ICommand), typeof(TreeListBoxItem), new PropertyMetadata(null));
					DropIndicatorAreaProperty = DependencyProperty.Register(xv.hTz(5558), typeof(TreeItemDropArea), typeof(TreeListBoxItem), new PropertyMetadata(TreeItemDropArea.None, Pt8));
					IndentAmountProperty = DependencyProperty.Register(xv.hTz(5596), typeof(double), typeof(TreeListBoxItem), new PropertyMetadata(20.0, ct9));
					IsExpandableProperty = DependencyProperty.Register(xv.hTz(5624), typeof(bool), typeof(TreeListBoxItem), new PropertyMetadata(false, Jt3));
					IsExpandedProperty = DependencyProperty.Register(xv.hTz(3132), typeof(bool), typeof(TreeListBoxItem), new PropertyMetadata(false, gtL));
					IsSelectableProperty = DependencyProperty.Register(xv.hTz(5652), typeof(bool), typeof(TreeListBoxItem), new PropertyMetadata(true, ntj));
					IsSelectedProperty = DependencyProperty.Register(xv.hTz(3156), typeof(bool), typeof(TreeListBoxItem), new PropertyMetadata(false, Xtx));
					ToggleExpansionButtonStyleProperty = DependencyProperty.Register(xv.hTz(5680), typeof(Style), typeof(TreeListBoxItem), new PropertyMetadata(null));
					InnerBorderThicknessProperty = DependencyProperty.Register(xv.hTz(5736), typeof(Thickness), typeof(TreeListBoxItem), new PropertyMetadata(new Thickness(1.0)));
					TreeLineBrushProperty = DependencyProperty.Register(xv.hTz(5780), typeof(Brush), typeof(TreeListBoxItem), new PropertyMetadata(Brushes.Black));
					return;
				case 1:
					break;
				}
				fc.taYSkz();
				num2 = 0;
			}
			while (0 == 0);
		}
	}

	internal static bool SWc()
	{
		return cWs == null;
	}

	internal static TreeListBoxItem YWR()
	{
		return cWs;
	}
}
