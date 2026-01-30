using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.Docking.Automation.Peers;
using ActiproSoftware.Windows.Controls.Docking.Primitives;
using ActiproSoftware.Windows.Input;
using ActiproSoftware.Windows.Media;

namespace ActiproSoftware.Windows.Controls.Docking;

[TemplateVisualState(Name = "Restored", GroupName = "WindowStates")]
[TemplateVisualState(Name = "Minimized", GroupName = "WindowStates")]
[TemplatePart(Name = "PART_TitleBar", Type = typeof(FrameworkElement))]
[TemplatePart(Name = "PART_Icon", Type = typeof(FrameworkElement))]
[TemplateVisualState(Name = "FrameHidden", GroupName = "FrameStates")]
[TemplateVisualState(Name = "Inactive", GroupName = "ActiveStates")]
[TemplateVisualState(Name = "Active", GroupName = "ActiveStates")]
[TemplateVisualState(Name = "FrameVisible", GroupName = "FrameStates")]
[TemplateVisualState(Name = "Maximized", GroupName = "WindowStates")]
[TemplateVisualState(Name = "ReadOnly", GroupName = "ReadOnlyStates")]
[TemplateVisualState(Name = "Editable", GroupName = "ReadOnlyStates")]
public class WindowControl : ContentControl, X8
{
	private InputAdapter gJ6;

	private ResizeOperation XJ9;

	private Point xJY;

	private Point QJp;

	private Size gJs;

	private FrameworkElement lJq;

	private FrameworkElement wJF;

	private InputAdapter GJV;

	private DateTime rJP;

	private Point? sJf;

	private DelegateCommand<object> zJU;

	private DelegateCommand<object> WJc;

	private DelegateCommand<object> CJ4;

	private DelegateCommand<object> LJj;

	public static readonly DependencyProperty CanCloseProperty;

	public static readonly DependencyProperty CornerRadiusProperty;

	public static readonly DependencyProperty ContextContentProperty;

	public static readonly DependencyProperty ContextContentTemplateProperty;

	public static readonly DependencyProperty ContextContentTemplateSelectorProperty;

	public static readonly DependencyProperty HasCloseButtonProperty;

	public static readonly DependencyProperty HasDropShadowProperty;

	public static readonly DependencyProperty HasIconProperty;

	public static readonly DependencyProperty HasMaximizeButtonProperty;

	public static readonly DependencyProperty HasMinimizeButtonProperty;

	public static readonly DependencyProperty HasRestoreButtonProperty;

	public static readonly DependencyProperty HasTitleBarProperty;

	public static readonly DependencyProperty IconProperty;

	public static readonly DependencyProperty IsActiveProperty;

	public static readonly DependencyProperty IsCloseButtonVisibleProperty;

	public static readonly DependencyProperty IsMaximizeButtonVisibleProperty;

	public static readonly DependencyProperty IsMaximizedFrameVisibleProperty;

	public static readonly DependencyProperty IsMinimizeButtonVisibleProperty;

	public static readonly DependencyProperty IsMovingProperty;

	public static readonly DependencyProperty IsReadOnlyProperty;

	public static readonly DependencyProperty IsResizingProperty;

	public static readonly DependencyProperty IsRestoreButtonVisibleProperty;

	public static readonly DependencyProperty LeftProperty;

	public static readonly DependencyProperty ReadOnlyContextContentTemplateProperty;

	public static readonly DependencyProperty ResizeModeProperty;

	public static readonly DependencyProperty RestoredBoundsProperty;

	public static readonly DependencyProperty ShadowElevationProperty;

	public static readonly DependencyProperty TitleProperty;

	public static readonly DependencyProperty TitleBarFontWeightProperty;

	public static readonly DependencyProperty TopProperty;

	public static readonly DependencyProperty WindowStateProperty;

	public static readonly RoutedEvent ActivatedEvent;

	public static readonly RoutedEvent ClosedEvent;

	public static readonly RoutedEvent ClosingEvent;

	public static readonly RoutedEvent DeactivatedEvent;

	public static readonly RoutedEvent DragMovedEvent;

	public static readonly RoutedEvent DragMovingEvent;

	public static readonly RoutedEvent DragResizedEvent;

	public static readonly RoutedEvent DragResizingEvent;

	public static readonly RoutedEvent LocationChangedEvent;

	public static readonly RoutedEvent OpenedEvent;

	public static readonly RoutedEvent StateChangedEvent;

	public static readonly RoutedEvent TitleBarDoubleTappedEvent;

	public static readonly RoutedEvent TitleBarMenuOpeningEvent;

	private ContextMenu AJZ;

	internal static WindowControl aH7;

	Rect X8.Bounds => DJT();

	internal virtual bool AreWindowStateBoundsChangedWithExternalLogic => false;

	private FrameworkElement TitleBar
	{
		get
		{
			return wJF;
		}
		set
		{
			if (wJF != value)
			{
				if (GJV != null)
				{
					GJV.AttachedEventKinds = InputAdapterEventKinds.None;
					GJV.PointerPressed -= PKH;
					GJV.PointerReleased -= hK0;
					GJV = null;
				}
				wJF = value;
				if (wJF != null)
				{
					GJV = new InputAdapter(wJF);
					GJV.AttachedEventKinds = InputAdapterEventKinds.PointerPressed | InputAdapterEventKinds.PointerReleased;
					GJV.PointerPressed += PKH;
					GJV.PointerReleased += hK0;
				}
			}
		}
	}

	public bool CanClose
	{
		get
		{
			return (bool)GetValue(CanCloseProperty);
		}
		set
		{
			SetValue(CanCloseProperty, value);
		}
	}

	public ICommand CloseCommand => zJU;

	public object ContextContent
	{
		get
		{
			return GetValue(ContextContentProperty);
		}
		set
		{
			SetValue(ContextContentProperty, value);
		}
	}

	public DataTemplate ContextContentTemplate
	{
		get
		{
			return (DataTemplate)GetValue(ContextContentTemplateProperty);
		}
		set
		{
			SetValue(ContextContentTemplateProperty, value);
		}
	}

	public DataTemplateSelector ContextContentTemplateSelector
	{
		get
		{
			return (DataTemplateSelector)GetValue(ContextContentTemplateSelectorProperty);
		}
		set
		{
			SetValue(ContextContentTemplateSelectorProperty, value);
		}
	}

	public CornerRadius CornerRadius
	{
		get
		{
			return (CornerRadius)GetValue(CornerRadiusProperty);
		}
		set
		{
			SetValue(CornerRadiusProperty, value);
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

	public bool HasDropShadow
	{
		get
		{
			return (bool)GetValue(HasDropShadowProperty);
		}
		set
		{
			SetValue(HasDropShadowProperty, value);
		}
	}

	public bool HasIcon
	{
		get
		{
			return (bool)GetValue(HasIconProperty);
		}
		set
		{
			SetValue(HasIconProperty, value);
		}
	}

	public bool HasMaximizeButton
	{
		get
		{
			return (bool)GetValue(HasMaximizeButtonProperty);
		}
		set
		{
			SetValue(HasMaximizeButtonProperty, value);
		}
	}

	public bool HasMinimizeButton
	{
		get
		{
			return (bool)GetValue(HasMinimizeButtonProperty);
		}
		set
		{
			SetValue(HasMinimizeButtonProperty, value);
		}
	}

	public bool HasRestoreButton
	{
		get
		{
			return (bool)GetValue(HasRestoreButtonProperty);
		}
		set
		{
			SetValue(HasRestoreButtonProperty, value);
		}
	}

	public bool HasTitleBar
	{
		get
		{
			return (bool)GetValue(HasTitleBarProperty);
		}
		set
		{
			SetValue(HasTitleBarProperty, value);
		}
	}

	public ImageSource Icon
	{
		get
		{
			return (ImageSource)GetValue(IconProperty);
		}
		set
		{
			SetValue(IconProperty, value);
		}
	}

	public bool IsActive
	{
		get
		{
			return (bool)GetValue(IsActiveProperty);
		}
		protected set
		{
			SetValue(IsActiveProperty, value);
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

	public bool IsMaximizedFrameVisible
	{
		get
		{
			return (bool)GetValue(IsMaximizedFrameVisibleProperty);
		}
		set
		{
			SetValue(IsMaximizedFrameVisibleProperty, value);
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

	public bool IsMoving
	{
		get
		{
			return (bool)GetValue(IsMovingProperty);
		}
		private set
		{
			SetValue(IsMovingProperty, value);
		}
	}

	public bool IsReadOnly
	{
		get
		{
			return (bool)GetValue(IsReadOnlyProperty);
		}
		set
		{
			SetValue(IsReadOnlyProperty, value);
		}
	}

	public bool IsResizing
	{
		get
		{
			return (bool)GetValue(IsResizingProperty);
		}
		private set
		{
			SetValue(IsResizingProperty, value);
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

	public double Left
	{
		get
		{
			return (double)GetValue(LeftProperty);
		}
		set
		{
			SetValue(LeftProperty, value);
		}
	}

	public ICommand MaximizeCommand => WJc;

	public ICommand MinimizeCommand => CJ4;

	public DataTemplate ReadOnlyContextContentTemplate
	{
		get
		{
			return (DataTemplate)GetValue(ReadOnlyContextContentTemplateProperty);
		}
		set
		{
			SetValue(ReadOnlyContextContentTemplateProperty, value);
		}
	}

	public ResizeMode ResizeMode
	{
		get
		{
			return (ResizeMode)GetValue(ResizeModeProperty);
		}
		set
		{
			SetValue(ResizeModeProperty, value);
		}
	}

	public ICommand RestoreCommand => LJj;

	public Rect RestoredBounds
	{
		get
		{
			return (Rect)GetValue(RestoredBoundsProperty);
		}
		set
		{
			SetValue(RestoredBoundsProperty, value);
		}
	}

	public int ShadowElevation
	{
		get
		{
			return (int)GetValue(ShadowElevationProperty);
		}
		set
		{
			SetValue(ShadowElevationProperty, value);
		}
	}

	[Localizability(LocalizationCategory.Title)]
	public string Title
	{
		get
		{
			return (string)GetValue(TitleProperty);
		}
		set
		{
			SetValue(TitleProperty, value);
		}
	}

	public FontWeight TitleBarFontWeight
	{
		get
		{
			return (FontWeight)GetValue(TitleBarFontWeightProperty);
		}
		set
		{
			SetValue(TitleBarFontWeightProperty, value);
		}
	}

	public double Top
	{
		get
		{
			return (double)GetValue(TopProperty);
		}
		set
		{
			SetValue(TopProperty, value);
		}
	}

	public WindowState WindowState
	{
		get
		{
			return (WindowState)GetValue(WindowStateProperty);
		}
		set
		{
			SetValue(WindowStateProperty, value);
		}
	}

	public event RoutedEventHandler Activated
	{
		add
		{
			AddHandler(ActivatedEvent, value);
		}
		remove
		{
			RemoveHandler(ActivatedEvent, value);
		}
	}

	public event RoutedEventHandler Closed
	{
		add
		{
			AddHandler(ClosedEvent, value);
		}
		remove
		{
			RemoveHandler(ClosedEvent, value);
		}
	}

	public event EventHandler<CancelRoutedEventArgs> Closing
	{
		add
		{
			AddHandler(ClosingEvent, value);
		}
		remove
		{
			RemoveHandler(ClosingEvent, value);
		}
	}

	public event RoutedEventHandler Deactivated
	{
		add
		{
			AddHandler(DeactivatedEvent, value);
		}
		remove
		{
			RemoveHandler(DeactivatedEvent, value);
		}
	}

	public event RoutedEventHandler DragMoved
	{
		add
		{
			AddHandler(DragMovedEvent, value);
		}
		remove
		{
			RemoveHandler(DragMovedEvent, value);
		}
	}

	public event EventHandler<CancelRoutedEventArgs> DragMoving
	{
		add
		{
			AddHandler(DragMovingEvent, value);
		}
		remove
		{
			RemoveHandler(DragMovingEvent, value);
		}
	}

	public event RoutedEventHandler DragResized
	{
		add
		{
			AddHandler(DragResizedEvent, value);
		}
		remove
		{
			RemoveHandler(DragResizedEvent, value);
		}
	}

	public event EventHandler<CancelRoutedEventArgs> DragResizing
	{
		add
		{
			AddHandler(DragResizingEvent, value);
		}
		remove
		{
			RemoveHandler(DragResizingEvent, value);
		}
	}

	public event RoutedEventHandler LocationChanged
	{
		add
		{
			AddHandler(LocationChangedEvent, value);
		}
		remove
		{
			RemoveHandler(LocationChangedEvent, value);
		}
	}

	public event RoutedEventHandler Opened
	{
		add
		{
			AddHandler(OpenedEvent, value);
		}
		remove
		{
			RemoveHandler(OpenedEvent, value);
		}
	}

	public event RoutedEventHandler StateChanged
	{
		add
		{
			AddHandler(StateChangedEvent, value);
		}
		remove
		{
			RemoveHandler(StateChangedEvent, value);
		}
	}

	public event EventHandler<CancelRoutedEventArgs> TitleBarDoubleTapped
	{
		add
		{
			AddHandler(TitleBarDoubleTappedEvent, value);
		}
		remove
		{
			RemoveHandler(TitleBarDoubleTappedEvent, value);
		}
	}

	public event EventHandler<DockingMenuEventArgs> TitleBarMenuOpening
	{
		add
		{
			AddHandler(TitleBarMenuOpeningEvent, value);
		}
		remove
		{
			RemoveHandler(TitleBarMenuOpeningEvent, value);
		}
	}

	public WindowControl()
	{
		IVH.CecNqz();
		XJ9 = ResizeOperation.None;
		rJP = DateTime.Now;
		base._002Ector();
		base.DefaultStyleKey = typeof(WindowControl);
		kK9();
		aKY();
	}

	private void kK9()
	{
		gJ6 = new InputAdapter(this);
		gJ6.PointerCaptureLost += EKZ;
		gJ6.PointerPressed += sKj;
		gJ6.PointerMoved += KK4;
		gJ6.PointerReleased += EKZ;
		gJ6.AttachedEventKinds = InputAdapterEventKinds.PointerCaptureLost | InputAdapterEventKinds.PointerMoved | InputAdapterEventKinds.PointerPressed | InputAdapterEventKinds.PointerReleased;
	}

	[SpecialName]
	internal Rect DJT()
	{
		return new Rect(Left, Top, double.IsNaN(base.Width) ? base.ActualWidth : base.Width, double.IsNaN(base.Height) ? base.ActualHeight : base.Height);
	}

	[SpecialName]
	internal void yJ8(Rect value)
	{
		if (Left != value.X)
		{
			Left = value.X;
		}
		if (Top != value.Y)
		{
			Top = value.Y;
		}
		if (base.Width != value.Width)
		{
			base.Width = value.Width;
		}
		if (base.Height != value.Height)
		{
			base.Height = value.Height;
		}
	}

	private void aKY()
	{
		zJU = new DelegateCommand<object>(delegate
		{
			if (CanClose)
			{
				Close();
			}
		}, (object P_0) => CanClose);
		WJc = new DelegateCommand<object>(delegate
		{
			Activate();
			WindowState = WindowState.Maximized;
		});
		CJ4 = new DelegateCommand<object>(delegate
		{
			WindowState = WindowState.Minimized;
		});
		LJj = new DelegateCommand<object>(delegate
		{
			Activate();
			WindowState = WindowState.Normal;
		});
	}

	private Point EKp(InputPointerEventArgs P_0, bool P_1)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(vVK.ssH(4416));
		}
		UIElement uIElement = oKs();
		if (uIElement != null)
		{
			Point position = P_0.GetPosition(uIElement);
			Rect rect = new Rect(default(Point), uIElement.RenderSize);
			if (uIElement is ScrollViewer scrollViewer)
			{
				if (P_1)
				{
					if (scrollViewer.HorizontalScrollBarVisibility != ScrollBarVisibility.Disabled)
					{
						rect.Width -= 3.0;
					}
					if (scrollViewer.VerticalScrollBarVisibility != ScrollBarVisibility.Disabled)
					{
						rect.Height -= 3.0;
					}
				}
				else
				{
					if (scrollViewer.HorizontalScrollBarVisibility != ScrollBarVisibility.Disabled)
					{
						rect.Width -= SystemParameters.ScrollWidth;
					}
					if (scrollViewer.VerticalScrollBarVisibility != ScrollBarVisibility.Disabled)
					{
						rect.Height -= SystemParameters.ScrollHeight;
					}
				}
			}
			if (position.X >= rect.Right)
			{
				position.X = rect.Right - 1.0;
			}
			if (position.X < rect.Left)
			{
				position.X = rect.Left;
			}
			if (position.Y >= rect.Bottom)
			{
				position.Y = rect.Bottom - 1.0;
			}
			if (position.Y < rect.Top)
			{
				position.Y = rect.Top;
			}
			return position;
		}
		return default(Point);
	}

	private UIElement oKs()
	{
		DependencyObject dependencyObject = this;
		dependencyObject = base.TemplatedParent ?? dependencyObject;
		Panel panel = VisualTreeHelper.GetParent(dependencyObject) as Panel;
		if (panel != null)
		{
			ScrollViewer ancestor = VisualTreeHelperExtended.GetAncestor<ScrollViewer>(panel);
			if (ancestor != null && VisualTreeHelper.GetParent(ancestor) is StandardMdiItemsControl)
			{
				return ancestor;
			}
		}
		return panel;
	}

	[SpecialName]
	private FrameworkElement YJE()
	{
		return lJq;
	}

	[SpecialName]
	private void xJr(FrameworkElement value)
	{
		lJq = value;
	}

	private void wKq()
	{
		if (mJQ())
		{
			return;
		}
		switch (ResizeMode)
		{
		case ResizeMode.CanMinimize:
			if (WindowState != WindowState.Normal)
			{
				ToggleWindowState();
			}
			return;
		case ResizeMode.NoResize:
			return;
		}
		WindowState windowState = WindowState;
		if ((uint)(windowState - 1) <= 1u)
		{
			ToggleWindowState();
		}
		else if (HasMaximizeButton)
		{
			ToggleWindowState();
		}
	}

	private static void JKF(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((WindowControl)P_0).zJU.RaiseCanExecuteChanged();
	}

	private static void gKV(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((WindowControl)P_0).kKu();
	}

	private static void sKP(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		WindowControl windowControl = (WindowControl)P_0;
		if (windowControl.IsActive)
		{
			windowControl.GJi();
		}
		else
		{
			windowControl.cJ2();
		}
		if (UIElementAutomationPeer.FromElement(windowControl) is WindowControlAutomationPeer windowControlAutomationPeer)
		{
			windowControlAutomationPeer.aR6((bool)P_1.OldValue, (bool)P_1.NewValue);
		}
		windowControl.fKz(_0020: true);
	}

	private static void EKf(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((WindowControl)P_0).fKz(_0020: true);
	}

	private static void OKU(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((WindowControl)P_0).fKz(_0020: true);
	}

	private static void jKc(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((WindowControl)P_0).IJC();
	}

	private void KK4(object P_0, InputPointerEventArgs P_1)
	{
		if (P_1 == null)
		{
			throw new ArgumentNullException(vVK.ssH(3942));
		}
		Point position = P_1.GetPosition(this);
		Cursor cursor;
		int num;
		int num2 = default(int);
		switch (HitTestResizeOperation(position))
		{
		case ResizeOperation.North:
		case ResizeOperation.South:
			cursor = Cursors.SizeNS;
			num = 0;
			if (uHb() != null)
			{
				goto IL_0005;
			}
			goto IL_0009;
		case ResizeOperation.NorthWest:
		case ResizeOperation.SouthEast:
			cursor = Cursors.SizeNWSE;
			break;
		default:
			cursor = null;
			num = 1;
			if (!UHO())
			{
				goto IL_0005;
			}
			goto IL_0009;
		case ResizeOperation.West:
		case ResizeOperation.East:
			cursor = Cursors.SizeWE;
			break;
		case ResizeOperation.NorthEast:
		case ResizeOperation.SouthWest:
			{
				cursor = Cursors.SizeNESW;
				break;
			}
			IL_0005:
			num = num2;
			goto IL_0009;
			IL_0009:
			switch (num)
			{
			}
			break;
		}
		Yp.ARc(this, cursor);
		if (IsMoving)
		{
			uKX(P_1);
		}
		else if (XJ9 != ResizeOperation.None)
		{
			rK5(P_1);
		}
	}

	private void sKj(object P_0, InputPointerButtonEventArgs P_1)
	{
		if (P_1 == null)
		{
			throw new ArgumentNullException(vVK.ssH(3942));
		}
		Point position = P_1.GetPosition(this);
		ResizeOperation resizeOperation = HitTestResizeOperation(position);
		if (resizeOperation != ResizeOperation.None)
		{
			int num = 0;
			if (!UHO())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			yKo(P_1, resizeOperation);
		}
		else if (!IsActive)
		{
			Activate();
		}
		if (P_1.WrappedEventArgs != null)
		{
			P_1.WrappedEventArgs.Handled = true;
		}
	}

	private void EKZ(object P_0, InputPointerEventArgs P_1)
	{
		if (P_1 == null)
		{
			throw new ArgumentNullException(vVK.ssH(3942));
		}
		yKt();
	}

	private static void IKb(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		WindowControl windowControl = (WindowControl)P_0;
		bool isMinimizeButtonVisible = windowControl.IsMinimizeButtonVisible;
		bool isMaximizeButtonVisible = windowControl.IsMaximizeButtonVisible;
		windowControl.kKu();
		if (UIElementAutomationPeer.FromElement(windowControl) is WindowControlAutomationPeer windowControlAutomationPeer)
		{
			windowControlAutomationPeer.YR3(isMinimizeButtonVisible, windowControl.IsMinimizeButtonVisible);
			windowControlAutomationPeer.lRL(isMaximizeButtonVisible, windowControl.IsMaximizeButtonVisible);
		}
	}

	private static void MKA(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		WindowControl windowControl = (WindowControl)P_0;
		if (windowControl.WindowState != WindowState.Normal)
		{
			return;
		}
		Rect restoredBounds = windowControl.RestoredBounds;
		if (!restoredBounds.IsEmpty)
		{
			if (windowControl.Left != restoredBounds.Left)
			{
				windowControl.Left = restoredBounds.Left;
			}
			if (windowControl.Top != restoredBounds.Top)
			{
				windowControl.Top = restoredBounds.Top;
			}
			if (windowControl.Width != restoredBounds.Width)
			{
				windowControl.Width = restoredBounds.Width;
			}
			if (windowControl.Height != restoredBounds.Height)
			{
				windowControl.Height = restoredBounds.Height;
			}
		}
	}

	private void PKH(object P_0, InputPointerButtonEventArgs P_1)
	{
		if (P_1 == null || P_1.Handled || !P_1.IsPrimaryButton)
		{
			return;
		}
		int num = 2;
		Point position = default(Point);
		DateTime now = default(DateTime);
		DockingMenuEventArgs e = default(DockingMenuEventArgs);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			case 2:
				P_1.Handled = true;
				position = P_1.GetPosition(this);
				if (sJf.HasValue)
				{
					now = DateTime.Now;
					num = 0;
					if (uHb() == null)
					{
						continue;
					}
					goto IL_0005;
				}
				goto IL_0180;
			case 1:
			{
				WJm(e);
				ContextMenu menu = e.Menu;
				if (menu != null && menu.Items.Count > 0)
				{
					menu.Placement = PlacementMode.Bottom;
					menu.PlacementTarget = lJq;
					menu.IsOpen = true;
				}
				goto IL_026d;
			}
			default:
				if (now.Subtract(rJP).TotalMilliseconds <= 500.0 && Math.Abs(position.X - sJf.Value.X) < 10.0 && Math.Abs(position.Y - sJf.Value.Y) < 10.0)
				{
					if (lJq != null && lJq.Visibility == Visibility.Visible && lJq.IsHitTestVisible && P_1.IsPositionOver(lJq))
					{
						if (CanClose)
						{
							Close();
						}
						return;
					}
					break;
				}
				goto IL_0180;
			case 3:
				{
					if (lJq == null || lJq.Visibility != Visibility.Visible || !lJq.IsHitTestVisible || !P_1.IsPositionOver(lJq))
					{
						if (WindowState != WindowState.Maximized)
						{
							DKy(P_1);
						}
						goto IL_026d;
					}
					e = new DockingMenuEventArgs(DockingMenuKind.WindowControlContextMenu);
					num = 1;
					if (uHb() == null)
					{
						continue;
					}
					goto IL_0005;
				}
				IL_0180:
				Activate();
				num2 = 3;
				goto IL_0005;
				IL_026d:
				rJP = DateTime.Now;
				sJf = position;
				return;
				IL_0005:
				num = num2;
				continue;
			}
			break;
		}
		yKt();
		wKq();
	}

	private void hK0(object P_0, InputPointerButtonEventArgs P_1)
	{
		if (P_1 != null && !P_1.Handled && P_1.ButtonKind == InputPointerButtonKind.Secondary)
		{
			Activate();
			DockingMenuEventArgs e = new DockingMenuEventArgs(DockingMenuKind.WindowControlContextMenu);
			WJm(e);
			ContextMenu menu = e.Menu;
			if (menu != null && menu.Items.Count > 0)
			{
				FrameworkElement placementTarget = lJq ?? wJF ?? this;
				menu.PlacementTarget = placementTarget;
				menu.Placement = PlacementMode.MousePoint;
				menu.IsOpen = true;
			}
			P_1.Handled = true;
		}
	}

	private static void tKh(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((WindowControl)P_0).IJC();
	}

	private static void gKg(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		int num = 1;
		WindowControl windowControl = default(WindowControl);
		WindowState windowState = default(WindowState);
		WindowState windowState2 = default(WindowState);
		bool isMinimizeButtonVisible = default(bool);
		bool isMaximizeButtonVisible = default(bool);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					windowControl = (WindowControl)P_0;
					num2 = 0;
					if (UHO())
					{
						continue;
					}
					break;
				default:
					windowState = (WindowState)P_1.OldValue;
					windowState2 = (WindowState)P_1.NewValue;
					isMinimizeButtonVisible = windowControl.IsMinimizeButtonVisible;
					isMaximizeButtonVisible = windowControl.IsMaximizeButtonVisible;
					if (!windowControl.AreWindowStateBoundsChangedWithExternalLogic)
					{
						if (windowState == WindowState.Normal && windowControl.IsInitialized)
						{
							windowControl.RestoredBounds = windowControl.DJT();
						}
						if (windowState2 != WindowState.Minimized)
						{
							if (!windowControl.RestoredBounds.IsEmpty)
							{
								windowControl.yJ8(windowControl.RestoredBounds);
							}
						}
						else
						{
							windowControl.Width = 180.0;
							windowControl.ClearValue(FrameworkElement.HeightProperty);
						}
					}
					windowControl.kKu();
					num2 = 2;
					if (UHO())
					{
						continue;
					}
					break;
				case 2:
					windowControl.fKz(_0020: true);
					windowControl.IJN();
					if (UIElementAutomationPeer.FromElement(windowControl) is WindowControlAutomationPeer windowControlAutomationPeer)
					{
						windowControlAutomationPeer.lR9(windowState, windowState2);
						windowControlAutomationPeer.YR3(isMinimizeButtonVisible, windowControl.IsMinimizeButtonVisible);
						windowControlAutomationPeer.lRL(isMaximizeButtonVisible, windowControl.IsMaximizeButtonVisible);
					}
					return;
				}
				break;
			}
		}
	}

	private void uKX(InputPointerEventArgs P_0)
	{
		Point point = EKp(P_0, _0020: false);
		point.X -= xJY.X;
		point.Y -= xJY.Y;
		Rect bounds = new Rect(QJp.X + point.X, QJp.Y + point.Y, gJs.Width, gJs.Height);
		yJ8(GetAdjustedBounds(bounds, ResizeOperation.None));
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	private void rK5(InputPointerEventArgs P_0)
	{
		Point point = EKp(P_0, _0020: true);
		double num = gJs.Width;
		double num2 = gJs.Height;
		Rect bounds = new Rect(xJY, gJs);
		switch (XJ9)
		{
		case ResizeOperation.East:
			num += point.X - xJY.X;
			break;
		case ResizeOperation.North:
			num2 -= point.Y - xJY.Y;
			break;
		case ResizeOperation.NorthEast:
			num += point.X - xJY.X;
			num2 -= point.Y - xJY.Y;
			break;
		case ResizeOperation.NorthWest:
			num -= point.X - xJY.X;
			num2 -= point.Y - xJY.Y;
			break;
		case ResizeOperation.South:
			num2 += point.Y - xJY.Y;
			break;
		case ResizeOperation.SouthEast:
			num += point.X - xJY.X;
			num2 += point.Y - xJY.Y;
			break;
		case ResizeOperation.SouthWest:
			num -= point.X - xJY.X;
			num2 += point.Y - xJY.Y;
			break;
		case ResizeOperation.West:
			num -= point.X - xJY.X;
			break;
		}
		bounds.X = Left;
		bounds.Y = Top;
		bounds.Width = Math.Max(base.MinWidth, Math.Min(base.MaxWidth, num));
		bounds.Height = Math.Max(base.MinHeight, Math.Min(base.MaxHeight, num2));
		double num3 = bounds.Width - base.ActualWidth;
		double num4 = bounds.Height - base.ActualHeight;
		switch (XJ9)
		{
		case ResizeOperation.North:
			bounds.Y -= num4;
			break;
		case ResizeOperation.NorthEast:
			bounds.Y -= num4;
			break;
		case ResizeOperation.NorthWest:
			bounds.X -= num3;
			bounds.Y -= num4;
			break;
		case ResizeOperation.SouthWest:
			bounds.X -= num3;
			break;
		case ResizeOperation.West:
			bounds.X -= num3;
			break;
		}
		yJ8(GetAdjustedBounds(bounds, XJ9));
	}

	internal virtual bool ShouldDragMoveWithExternalLogic(InputPointerEventArgs e)
	{
		return false;
	}

	internal void DKy(InputPointerButtonEventArgs P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(vVK.ssH(4416));
		}
		if (ShouldDragMoveWithExternalLogic(P_0) || CJG())
		{
			return;
		}
		InputEventArgs wrappedEventArgs = P_0.WrappedEventArgs;
		if (wrappedEventArgs != null)
		{
			int num = 0;
			if (uHb() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			wrappedEventArgs.Handled = true;
		}
		if (gJ6.CapturePointer(P_0))
		{
			QJp = new Point(Left, Top);
			xJY = EKp(P_0, _0020: false);
			gJs = new Size(double.IsNaN(base.Width) ? base.ActualWidth : base.Width, double.IsNaN(base.Height) ? base.ActualHeight : base.Height);
			IsMoving = true;
		}
	}

	internal void yKo(InputPointerEventArgs P_0, ResizeOperation P_1)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(vVK.ssH(4416));
		}
		if (NJk())
		{
			return;
		}
		InputEventArgs wrappedEventArgs = P_0.WrappedEventArgs;
		if (wrappedEventArgs != null)
		{
			wrappedEventArgs.Handled = true;
			int num = 0;
			if (uHb() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
		if (gJ6.CapturePointer(P_0))
		{
			xJY = EKp(P_0, _0020: true);
			gJs = new Size(double.IsNaN(base.Width) ? base.ActualWidth : base.Width, double.IsNaN(base.Height) ? base.ActualHeight : base.Height);
			IsResizing = true;
			XJ9 = P_1;
		}
	}

	private void yKt()
	{
		if (IsMoving || XJ9 != ResizeOperation.None)
		{
			if (WindowState == WindowState.Normal && RestoredBounds != DJT())
			{
				RestoredBounds = DJT();
			}
			if (IsMoving)
			{
				IJe();
			}
			if (IsResizing)
			{
				GJI();
			}
			IsMoving = false;
			IsResizing = false;
			XJ9 = ResizeOperation.None;
			gJ6.ReleasePointerCaptures();
		}
	}

	private void kKu()
	{
		WindowState windowState = WindowState;
		IsMinimizeButtonVisible = HasMinimizeButton && windowState != WindowState.Minimized && ResizeMode != ResizeMode.NoResize;
		IsRestoreButtonVisible = HasRestoreButton && windowState != WindowState.Normal;
		IsMaximizeButtonVisible = HasMaximizeButton && windowState != WindowState.Maximized && ResizeMode != ResizeMode.NoResize && ResizeMode != ResizeMode.CanMinimize;
		IsCloseButtonVisible = HasCloseButton;
	}

	private void fKz(bool P_0)
	{
		VisualStateManager.GoToState(this, IsActive ? vVK.ssH(17986) : vVK.ssH(17966), P_0);
		WindowState windowState = WindowState;
		if (windowState == WindowState.Minimized)
		{
			VisualStateManager.GoToState(this, vVK.ssH(18878), P_0);
		}
		else
		{
			int num = 0;
			if (!UHO())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			if (windowState == WindowState.Maximized)
			{
				VisualStateManager.GoToState(this, vVK.ssH(18856), P_0);
			}
			else
			{
				VisualStateManager.GoToState(this, vVK.ssH(18900), P_0);
			}
		}
		VisualStateManager.GoToState(this, (!IsMaximizedFrameVisible && WindowState == WindowState.Maximized) ? vVK.ssH(18948) : vVK.ssH(18920), P_0);
		if (IsReadOnly)
		{
			VisualStateManager.GoToState(this, vVK.ssH(4376), P_0);
		}
		else
		{
			VisualStateManager.GoToState(this, vVK.ssH(4396), P_0);
		}
	}

	public virtual bool Activate()
	{
		if (!cP.NlZ(this))
		{
			return cP.Dl4(this);
		}
		return true;
	}

	public void Close()
	{
		if (base.IsVisible && !tJw())
		{
			pJd();
		}
	}

	public void DragMove(InputPointerButtonEventArgs e)
	{
		DKy(e);
	}

	public virtual Rect GetAdjustedBounds(Rect bounds, ResizeOperation resizeOperation)
	{
		return bounds;
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	public ResizeOperation HitTestResizeOperation(Point point)
	{
		bool flag;
		int num;
		if (WindowState == WindowState.Normal)
		{
			flag = false;
			ResizeMode resizeMode = ResizeMode;
			if ((uint)(resizeMode - 2) <= 1u)
			{
				flag = true;
				num = 0;
				if (uHb() != null)
				{
					goto IL_0005;
				}
				goto IL_0009;
			}
			goto IL_0214;
		}
		goto IL_03c4;
		IL_03c4:
		return ResizeOperation.None;
		IL_01d1:
		Rect rect = default(Rect);
		Thickness borderThickness = default(Thickness);
		double num2;
		if (point.X >= rect.Right - borderThickness.Right - num2 && point.X < rect.Right)
		{
			return ResizeOperation.SouthEast;
		}
		return ResizeOperation.South;
		IL_0005:
		int num3 = default(int);
		num = num3;
		goto IL_0009;
		IL_0009:
		double num4;
		while (true)
		{
			switch (num)
			{
			case 1:
				break;
			case 3:
				return ResizeOperation.SouthWest;
			default:
				goto end_IL_0009;
			case 4:
				goto IL_02bb;
			case 2:
				return ResizeOperation.NorthEast;
			}
			if (point.Y < rect.Top + borderThickness.Top || point.Y >= rect.Bottom - borderThickness.Bottom)
			{
				goto IL_0173;
			}
			goto IL_03c4;
			IL_02bb:
			borderThickness.Right = Math.Max(4.0, borderThickness.Right);
			borderThickness.Bottom = Math.Max(4.0, borderThickness.Bottom);
			if (!(point.X < rect.Left + borderThickness.Left) && !(point.X >= rect.Right - borderThickness.Right))
			{
				num = 1;
				if (uHb() == null)
				{
					continue;
				}
				goto IL_0005;
			}
			goto IL_0173;
			IL_0173:
			num4 = 0.0;
			num2 = 0.0;
			if (!(point.X >= rect.Left) || !(point.X < rect.Left + borderThickness.Left))
			{
				if (!(point.X >= rect.Right - borderThickness.Right) || !(point.X < rect.Right))
				{
					if (point.Y >= rect.Top && point.Y < rect.Top + borderThickness.Top)
					{
						if (point.X >= rect.Left && point.X < rect.Left + borderThickness.Left + num2)
						{
							return ResizeOperation.NorthWest;
						}
						if (point.X >= rect.Right - borderThickness.Right - num2 && point.X < rect.Right)
						{
							num = 2;
							if (UHO())
							{
								continue;
							}
							goto IL_0005;
						}
						return ResizeOperation.North;
					}
					if (point.Y >= rect.Bottom - borderThickness.Bottom && point.Y < rect.Bottom)
					{
						if (point.X >= rect.Left && point.X < rect.Left + borderThickness.Left + num2)
						{
							num = 3;
							continue;
						}
						goto IL_01d1;
					}
					goto IL_03c4;
				}
				goto IL_03a0;
			}
			goto IL_0183;
			continue;
			end_IL_0009:
			break;
		}
		goto IL_0214;
		IL_03a0:
		if (!(point.Y >= rect.Top) || !(point.Y < rect.Top + borderThickness.Top + num4))
		{
			if (point.Y >= rect.Bottom - borderThickness.Bottom - num4 && point.Y < rect.Bottom)
			{
				return ResizeOperation.SouthEast;
			}
			return ResizeOperation.East;
		}
		return ResizeOperation.NorthEast;
		IL_0214:
		rect = new Rect(-0.0, -0.0, base.ActualWidth + 0.0, base.ActualHeight + 0.0);
		if (flag && point.X >= rect.Left && point.X < rect.Right && point.Y >= rect.Top && point.Y < rect.Bottom)
		{
			borderThickness = base.BorderThickness;
			borderThickness.Left = Math.Max(4.0, borderThickness.Left);
			borderThickness.Top = Math.Max(4.0, borderThickness.Top);
			num = 4;
			if (!UHO())
			{
				goto IL_0005;
			}
			goto IL_0009;
		}
		goto IL_03c4;
		IL_0183:
		if (!(point.Y >= rect.Top) || !(point.Y < rect.Top + borderThickness.Top + num4))
		{
			if (point.Y >= rect.Bottom - borderThickness.Bottom - num4 && point.Y < rect.Bottom)
			{
				return ResizeOperation.SouthWest;
			}
			return ResizeOperation.West;
		}
		return ResizeOperation.NorthWest;
	}

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		TitleBar = GetTemplateChild(vVK.ssH(17936)) as FrameworkElement;
		xJr(GetTemplateChild(vVK.ssH(18974)) as FrameworkElement);
		kKu();
		fKz(_0020: false);
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		return new WindowControlAutomationPeer(this);
	}

	public void Show()
	{
		if (!base.IsVisible)
		{
			KJ1();
		}
	}

	public void ToggleWindowState()
	{
		if (WindowState == WindowState.Normal)
		{
			WindowState = WindowState.Maximized;
		}
		else
		{
			WindowState = WindowState.Normal;
		}
	}

	private void GJi()
	{
		RoutedEventArgs e = new RoutedEventArgs();
		if (e.RoutedEvent == null)
		{
			e.RoutedEvent = ActivatedEvent;
		}
		if (e.Source == null)
		{
			e.Source = this;
		}
		OnActivated(e);
		RaiseEvent(e);
	}

	private void pJd()
	{
		RoutedEventArgs e = new RoutedEventArgs();
		if (e.RoutedEvent == null)
		{
			e.RoutedEvent = ClosedEvent;
		}
		if (e.Source == null)
		{
			e.Source = this;
		}
		OnClosed(e);
		RaiseEvent(e);
	}

	private bool tJw()
	{
		CancelRoutedEventArgs e = new CancelRoutedEventArgs();
		if (e.RoutedEvent == null)
		{
			e.RoutedEvent = ClosingEvent;
		}
		if (e.Source == null)
		{
			e.Source = this;
		}
		OnClosing(e);
		RaiseEvent(e);
		return e.Cancel;
	}

	private void cJ2()
	{
		RoutedEventArgs e = new RoutedEventArgs();
		if (e.RoutedEvent == null)
		{
			e.RoutedEvent = DeactivatedEvent;
		}
		if (e.Source == null)
		{
			e.Source = this;
		}
		OnDeactivated(e);
		RaiseEvent(e);
	}

	private void IJe()
	{
		RoutedEventArgs e = new RoutedEventArgs();
		if (e.RoutedEvent == null)
		{
			e.RoutedEvent = DragMovedEvent;
		}
		if (e.Source == null)
		{
			e.Source = this;
		}
		OnDragMoved(e);
		RaiseEvent(e);
	}

	private bool CJG()
	{
		CancelRoutedEventArgs e = new CancelRoutedEventArgs();
		if (e.RoutedEvent == null)
		{
			e.RoutedEvent = DragMovingEvent;
		}
		if (e.Source == null)
		{
			e.Source = this;
		}
		OnDragMoving(e);
		RaiseEvent(e);
		return e.Cancel;
	}

	private void GJI()
	{
		RoutedEventArgs e = new RoutedEventArgs();
		if (e.RoutedEvent == null)
		{
			e.RoutedEvent = DragResizedEvent;
		}
		if (e.Source == null)
		{
			e.Source = this;
		}
		OnDragResized(e);
		RaiseEvent(e);
	}

	private bool NJk()
	{
		CancelRoutedEventArgs e = new CancelRoutedEventArgs();
		if (e.RoutedEvent == null)
		{
			e.RoutedEvent = DragResizingEvent;
		}
		if (e.Source == null)
		{
			e.Source = this;
		}
		OnDragResizing(e);
		RaiseEvent(e);
		return e.Cancel;
	}

	private void IJC()
	{
		RoutedEventArgs e = new RoutedEventArgs();
		if (e.RoutedEvent == null)
		{
			e.RoutedEvent = LocationChangedEvent;
		}
		if (e.Source == null)
		{
			e.Source = this;
		}
		OnLocationChanged(e);
		RaiseEvent(e);
	}

	private void KJ1()
	{
		RoutedEventArgs e = new RoutedEventArgs();
		if (e.RoutedEvent == null)
		{
			e.RoutedEvent = OpenedEvent;
		}
		if (e.Source == null)
		{
			e.Source = this;
		}
		OnOpened(e);
		RaiseEvent(e);
	}

	private void IJN()
	{
		RoutedEventArgs e = new RoutedEventArgs();
		if (e.RoutedEvent == null)
		{
			e.RoutedEvent = StateChangedEvent;
		}
		if (e.Source == null)
		{
			e.Source = this;
		}
		OnStateChanged(e);
		RaiseEvent(e);
	}

	private bool mJQ()
	{
		CancelRoutedEventArgs e = new CancelRoutedEventArgs();
		if (e.RoutedEvent == null)
		{
			e.RoutedEvent = TitleBarDoubleTappedEvent;
		}
		if (e.Source == null)
		{
			e.Source = this;
		}
		OnTitleBarDoubleTapped(e);
		RaiseEvent(e);
		return e.Cancel;
	}

	private void WJm(DockingMenuEventArgs P_0)
	{
		if (P_0.RoutedEvent == null)
		{
			P_0.RoutedEvent = TitleBarMenuOpeningEvent;
		}
		if (P_0.Source == null)
		{
			P_0.Source = this;
		}
		OnTitleBarMenuOpening(P_0);
		RaiseEvent(P_0);
	}

	protected virtual void OnActivated(RoutedEventArgs e)
	{
	}

	protected virtual void OnClosed(RoutedEventArgs e)
	{
	}

	protected virtual void OnClosing(CancelRoutedEventArgs e)
	{
	}

	protected virtual void OnDeactivated(RoutedEventArgs e)
	{
	}

	protected virtual void OnDragMoved(RoutedEventArgs e)
	{
	}

	protected virtual void OnDragMoving(CancelRoutedEventArgs e)
	{
	}

	protected virtual void OnDragResized(RoutedEventArgs e)
	{
	}

	protected virtual void OnDragResizing(CancelRoutedEventArgs e)
	{
	}

	protected virtual void OnLocationChanged(RoutedEventArgs e)
	{
	}

	protected virtual void OnOpened(RoutedEventArgs e)
	{
	}

	protected virtual void OnStateChanged(RoutedEventArgs e)
	{
	}

	protected virtual void OnTitleBarDoubleTapped(CancelRoutedEventArgs e)
	{
	}

	protected virtual void OnTitleBarMenuOpening(DockingMenuEventArgs e)
	{
	}

	private bool vJa()
	{
		if (cP.hlj() is ContextMenu { IsOpen: not false } contextMenu)
		{
			AJZ = contextMenu;
			AJZ.Closed += qJW;
			return true;
		}
		return false;
	}

	private void qJW(object P_0, RoutedEventArgs P_1)
	{
		((ContextMenu)P_0).Closed -= qJW;
		AJZ = null;
		if (!vJa())
		{
			IsActive = base.IsKeyboardFocusWithin;
		}
	}

	protected override void OnGotKeyboardFocus(KeyboardFocusChangedEventArgs e)
	{
		base.OnGotKeyboardFocus(e);
		IsActive = base.IsKeyboardFocusWithin;
	}

	protected override void OnLostKeyboardFocus(KeyboardFocusChangedEventArgs e)
	{
		base.OnLostKeyboardFocus(e);
		if (base.IsKeyboardFocusWithin || !vJa())
		{
			IsActive = base.IsKeyboardFocusWithin;
		}
	}

	static WindowControl()
	{
		IVH.CecNqz();
		CanCloseProperty = DependencyProperty.Register(vVK.ssH(5326), typeof(bool), typeof(WindowControl), new PropertyMetadata(true, JKF));
		CornerRadiusProperty = DependencyProperty.Register(vVK.ssH(5600), typeof(CornerRadius), typeof(WindowControl), new PropertyMetadata(new CornerRadius(0.0)));
		ContextContentProperty = DependencyProperty.Register(vVK.ssH(5520), typeof(object), typeof(WindowControl), new PropertyMetadata(null));
		ContextContentTemplateProperty = DependencyProperty.Register(vVK.ssH(5552), typeof(DataTemplate), typeof(WindowControl), new PropertyMetadata(null));
		ContextContentTemplateSelectorProperty = DependencyProperty.Register(vVK.ssH(18996), typeof(DataTemplateSelector), typeof(WindowControl), new PropertyMetadata(null));
		HasCloseButtonProperty = DependencyProperty.Register(vVK.ssH(6022), typeof(bool), typeof(WindowControl), new PropertyMetadata(true, gKV));
		int num = 3;
		if (1 == 0)
		{
			num = 0;
		}
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				TitleBarDoubleTappedEvent = EventManager.RegisterRoutedEvent(vVK.ssH(19718), RoutingStrategy.Bubble, typeof(EventHandler<CancelRoutedEventArgs>), typeof(WindowControl));
				TitleBarMenuOpeningEvent = EventManager.RegisterRoutedEvent(vVK.ssH(19762), RoutingStrategy.Bubble, typeof(EventHandler<DockingMenuEventArgs>), typeof(WindowControl));
				return;
			case 1:
				ReadOnlyContextContentTemplateProperty = DependencyProperty.Register(vVK.ssH(6556), typeof(DataTemplate), typeof(WindowControl), new PropertyMetadata(null));
				ResizeModeProperty = DependencyProperty.Register(vVK.ssH(19326), typeof(ResizeMode), typeof(WindowControl), new PropertyMetadata(ResizeMode.CanResize, IKb));
				RestoredBoundsProperty = DependencyProperty.Register(vVK.ssH(19350), typeof(Rect), typeof(WindowControl), new PropertyMetadata(new Rect(0.0, 0.0, 300.0, 200.0), MKA));
				ShadowElevationProperty = DependencyProperty.Register(vVK.ssH(16542), typeof(int), typeof(WindowControl), new PropertyMetadata(8));
				TitleProperty = DependencyProperty.Register(vVK.ssH(7338), typeof(string), typeof(WindowControl), new PropertyMetadata(null));
				TitleBarFontWeightProperty = DependencyProperty.Register(vVK.ssH(19382), typeof(FontWeight), typeof(WindowControl), new PropertyMetadata(FontWeights.Normal));
				TopProperty = DependencyProperty.Register(vVK.ssH(19422), typeof(double), typeof(WindowControl), new PropertyMetadata(0.0, tKh));
				WindowStateProperty = DependencyProperty.Register(vVK.ssH(19432), typeof(WindowState), typeof(WindowControl), new PropertyMetadata(WindowState.Normal, gKg));
				ActivatedEvent = EventManager.RegisterRoutedEvent(vVK.ssH(19458), RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(WindowControl));
				ClosedEvent = EventManager.RegisterRoutedEvent(vVK.ssH(19480), RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(WindowControl));
				ClosingEvent = EventManager.RegisterRoutedEvent(vVK.ssH(19496), RoutingStrategy.Bubble, typeof(EventHandler<CancelRoutedEventArgs>), typeof(WindowControl));
				DeactivatedEvent = EventManager.RegisterRoutedEvent(vVK.ssH(19514), RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(WindowControl));
				DragMovedEvent = EventManager.RegisterRoutedEvent(vVK.ssH(19540), RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(WindowControl));
				DragMovingEvent = EventManager.RegisterRoutedEvent(vVK.ssH(19562), RoutingStrategy.Bubble, typeof(EventHandler<CancelRoutedEventArgs>), typeof(WindowControl));
				DragResizedEvent = EventManager.RegisterRoutedEvent(vVK.ssH(19586), RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(WindowControl));
				DragResizingEvent = EventManager.RegisterRoutedEvent(vVK.ssH(19612), RoutingStrategy.Bubble, typeof(EventHandler<CancelRoutedEventArgs>), typeof(WindowControl));
				LocationChangedEvent = EventManager.RegisterRoutedEvent(vVK.ssH(19640), RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(WindowControl));
				OpenedEvent = EventManager.RegisterRoutedEvent(vVK.ssH(19674), RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(WindowControl));
				StateChangedEvent = EventManager.RegisterRoutedEvent(vVK.ssH(19690), RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(WindowControl));
				num = 0;
				if (0 == 0)
				{
					break;
				}
				goto IL_0005;
			case 2:
				IconProperty = DependencyProperty.Register(vVK.ssH(7326), typeof(ImageSource), typeof(WindowControl), new PropertyMetadata(null));
				IsActiveProperty = DependencyProperty.Register(vVK.ssH(878), typeof(bool), typeof(WindowControl), new PropertyMetadata(false, sKP));
				IsCloseButtonVisibleProperty = DependencyProperty.Register(vVK.ssH(6164), typeof(bool), typeof(WindowControl), new PropertyMetadata(true));
				IsMaximizeButtonVisibleProperty = DependencyProperty.Register(vVK.ssH(18122), typeof(bool), typeof(WindowControl), new PropertyMetadata(false));
				IsMaximizedFrameVisibleProperty = DependencyProperty.Register(vVK.ssH(19220), typeof(bool), typeof(WindowControl), new PropertyMetadata(true, EKf));
				IsMinimizeButtonVisibleProperty = DependencyProperty.Register(vVK.ssH(18172), typeof(bool), typeof(WindowControl), new PropertyMetadata(false));
				num2 = 4;
				goto IL_0005;
			case 4:
				IsMovingProperty = DependencyProperty.Register(vVK.ssH(19270), typeof(bool), typeof(WindowControl), new PropertyMetadata(false));
				IsReadOnlyProperty = DependencyProperty.Register(vVK.ssH(6330), typeof(bool), typeof(WindowControl), new PropertyMetadata(false, OKU));
				IsResizingProperty = DependencyProperty.Register(vVK.ssH(19290), typeof(bool), typeof(WindowControl), new PropertyMetadata(false));
				IsRestoreButtonVisibleProperty = DependencyProperty.Register(vVK.ssH(18270), typeof(bool), typeof(WindowControl), new PropertyMetadata(false));
				LeftProperty = DependencyProperty.Register(vVK.ssH(19314), typeof(double), typeof(WindowControl), new PropertyMetadata(0.0, jKc));
				num = 1;
				if (true)
				{
					break;
				}
				goto IL_0005;
			case 3:
				{
					HasDropShadowProperty = DependencyProperty.Register(vVK.ssH(19060), typeof(bool), typeof(WindowControl), new PropertyMetadata(false));
					HasIconProperty = DependencyProperty.Register(vVK.ssH(19090), typeof(bool), typeof(WindowControl), new PropertyMetadata(true));
					HasMaximizeButtonProperty = DependencyProperty.Register(vVK.ssH(19108), typeof(bool), typeof(WindowControl), new PropertyMetadata(true, gKV));
					HasMinimizeButtonProperty = DependencyProperty.Register(vVK.ssH(19146), typeof(bool), typeof(WindowControl), new PropertyMetadata(true, gKV));
					HasRestoreButtonProperty = DependencyProperty.Register(vVK.ssH(19184), typeof(bool), typeof(WindowControl), new PropertyMetadata(true, gKV));
					HasTitleBarProperty = DependencyProperty.Register(vVK.ssH(17592), typeof(bool), typeof(WindowControl), new PropertyMetadata(true));
					num = 2;
					if (false)
					{
						num = 1;
					}
					break;
				}
				IL_0005:
				num = num2;
				break;
			}
		}
	}

	[CompilerGenerated]
	private void vJB(object P_0)
	{
		if (CanClose)
		{
			Close();
		}
	}

	[CompilerGenerated]
	private bool cJK(object P_0)
	{
		return CanClose;
	}

	[CompilerGenerated]
	private void yJJ(object P_0)
	{
		Activate();
		WindowState = WindowState.Maximized;
	}

	[CompilerGenerated]
	private void aJn(object P_0)
	{
		WindowState = WindowState.Minimized;
	}

	[CompilerGenerated]
	private void PJO(object P_0)
	{
		Activate();
		WindowState = WindowState.Normal;
	}

	internal static bool UHO()
	{
		return aH7 == null;
	}

	internal static WindowControl uHb()
	{
		return aH7;
	}
}
