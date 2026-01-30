using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Shapes;
using ActiproSoftware.Products.Shared;
using ActiproSoftware.Windows.Controls;
using ActiproSoftware.Windows.Data;
using ActiproSoftware.Windows.Interop;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Themes;

public class WindowChrome : Freezable
{
	private static RoutedCommand EuH;

	private static RoutedCommand Wu6;

	private static RoutedCommand guV;

	private static RoutedCommand Tu5;

	private static RoutedCommand JuR;

	private static RoutedCommand suE;

	private static Thickness? uus;

	private static Thickness? ouL;

	private static RoutedCommand Gud;

	public static readonly RoutedEvent IsOverlayVisibleChangedEvent;

	public static readonly RoutedEvent TitleBarContextMenuRequestedEvent;

	public static readonly RoutedEvent WindowBoundsChangedEvent;

	public static readonly RoutedEvent WindowBoundsChangingEvent;

	public static readonly RoutedEvent WindowSystemMenuOpeningEvent;

	internal static readonly DependencyPropertyKey IsTaskbarAutoHiddenPropertyKey;

	internal static readonly DependencyPropertyKey TitleBarHeightPropertyKey;

	internal static readonly DependencyPropertyKey TitleBarLeftContentWidthPropertyKey;

	internal static readonly DependencyPropertyKey TitleBarRightContentWidthPropertyKey;

	public static readonly DependencyProperty ChromeProperty;

	public static readonly DependencyProperty ElementKindProperty;

	public static readonly DependencyProperty HasCloseButtonProperty;

	public static readonly DependencyProperty HasIconProperty;

	public static readonly DependencyProperty HasMaximizeButtonProperty;

	public static readonly DependencyProperty HasMinimizeButtonProperty;

	public static readonly DependencyProperty HasOuterGlowProperty;

	public static readonly DependencyProperty HasRestoreButtonProperty;

	public static readonly DependencyProperty HasTitleBarProperty;

	public static readonly DependencyProperty IconMarginProperty;

	public static readonly DependencyProperty IconSourceProperty;

	public static readonly DependencyProperty IsOverlayVisibleProperty;

	public static readonly DependencyProperty IsTaskbarAutoHiddenProperty;

	public static readonly DependencyProperty OverlayAnimationKindsProperty;

	public static readonly DependencyProperty OverlayContentProperty;

	public static readonly DependencyProperty OverlayContentTemplateProperty;

	public static readonly DependencyProperty OverlayContentTemplateSelectorProperty;

	public static readonly DependencyProperty ResizeBorderThicknessProperty;

	public static readonly DependencyProperty StyleKeyProperty;

	public static readonly DependencyProperty ThemeNameProperty;

	public static readonly DependencyProperty TitleBarHeaderProperty;

	public static readonly DependencyProperty TitleBarHeaderAlignmentProperty;

	public static readonly DependencyProperty TitleBarHeaderMarginProperty;

	public static readonly DependencyProperty TitleBarHeaderMinWidthProperty;

	public static readonly DependencyProperty TitleBarHeaderTemplateProperty;

	public static readonly DependencyProperty TitleBarHeaderTemplateSelectorProperty;

	public static readonly DependencyProperty TitleBarHeightProperty;

	public static readonly DependencyProperty TitleBarLeftContentProperty;

	public static readonly DependencyProperty TitleBarLeftContentMaxWidthOverflowPercentageProperty;

	public static readonly DependencyProperty TitleBarLeftContentTemplateProperty;

	public static readonly DependencyProperty TitleBarLeftContentTemplateSelectorProperty;

	public static readonly DependencyProperty TitleBarLeftContentWidthProperty;

	public static readonly DependencyProperty TitleBarMergeKindProperty;

	public static readonly DependencyProperty TitleBarMinHeightProperty;

	public static readonly DependencyProperty TitleBarRightContentProperty;

	public static readonly DependencyProperty TitleBarRightContentMaxWidthOverflowPercentageProperty;

	public static readonly DependencyProperty TitleBarRightContentTemplateProperty;

	public static readonly DependencyProperty TitleBarRightContentTemplateSelectorProperty;

	public static readonly DependencyProperty TitleBarRightContentWidthProperty;

	public static readonly DependencyProperty UseAlternateTitleBarStyleProperty;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private RoutedEventHandler FuN;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private EventHandler duM;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private EventHandler<CancelRoutedEventArgs> yuK;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private EventHandler<WindowBoundsChangeEventArgs> Lug;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private EventHandler<WindowBoundsChangeEventArgs> Uu8;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private EventHandler<ContextMenuOpeningEventArgs> puD;

	private static WindowChrome pY2;

	internal static double WindowCaptionHeightCore => SystemParameters.WindowCaptionHeight;

	public static ICommand CloseCommand
	{
		get
		{
			if (EuH == null)
			{
				EuH = new RoutedUICommand(SR.GetString(SRName.UICommandCloseWindowText), WP6RZJql8gZrNhVA9v.L3hoFlcqP6(98460), typeof(Window));
				CommandManager.RegisterClassCommandBinding(typeof(Window), new CommandBinding(EuH, uuo, IuF));
			}
			return EuH;
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

	public bool? HasMaximizeButton
	{
		get
		{
			return (bool?)GetValue(HasMaximizeButtonProperty);
		}
		set
		{
			SetValue(HasMaximizeButtonProperty, value);
		}
	}

	public bool? HasMinimizeButton
	{
		get
		{
			return (bool?)GetValue(HasMinimizeButtonProperty);
		}
		set
		{
			SetValue(HasMinimizeButtonProperty, value);
		}
	}

	public bool? HasOuterGlow
	{
		get
		{
			return (bool?)GetValue(HasOuterGlowProperty);
		}
		set
		{
			SetValue(HasOuterGlowProperty, value);
		}
	}

	public bool? HasRestoreButton
	{
		get
		{
			return (bool?)GetValue(HasRestoreButtonProperty);
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

	public Thickness IconMargin
	{
		get
		{
			return (Thickness)GetValue(IconMarginProperty);
		}
		set
		{
			SetValue(IconMarginProperty, value);
		}
	}

	public ImageSource IconSource
	{
		get
		{
			return (ImageSource)GetValue(IconSourceProperty);
		}
		set
		{
			SetValue(IconSourceProperty, value);
		}
	}

	public static ICommand MaximizeCommand
	{
		get
		{
			if (Wu6 == null)
			{
				Wu6 = new RoutedUICommand(SR.GetString(SRName.UICommandMaximizeWindowText), WP6RZJql8gZrNhVA9v.L3hoFlcqP6(98492), typeof(Window));
				CommandManager.RegisterClassCommandBinding(typeof(Window), new CommandBinding(Wu6, KuO, TuQ));
			}
			return Wu6;
		}
	}

	public static ICommand MinimizeCommand
	{
		get
		{
			if (guV == null)
			{
				guV = new RoutedUICommand(SR.GetString(SRName.UICommandMinimizeWindowText), WP6RZJql8gZrNhVA9v.L3hoFlcqP6(98512), typeof(Window));
				CommandManager.RegisterClassCommandBinding(typeof(Window), new CommandBinding(guV, Guk, zu0));
			}
			return guV;
		}
	}

	public DataTemplate OverlayContentTemplate
	{
		get
		{
			return (DataTemplate)GetValue(OverlayContentTemplateProperty);
		}
		set
		{
			SetValue(OverlayContentTemplateProperty, value);
		}
	}

	public DataTemplateSelector OverlayContentTemplateSelector
	{
		get
		{
			return (DataTemplateSelector)GetValue(OverlayContentTemplateSelectorProperty);
		}
		set
		{
			SetValue(OverlayContentTemplateSelectorProperty, value);
		}
	}

	public Thickness? ResizeBorderThickness
	{
		get
		{
			return (Thickness?)GetValue(ResizeBorderThicknessProperty);
		}
		set
		{
			SetValue(ResizeBorderThicknessProperty, value);
		}
	}

	public static ICommand MoveCommand
	{
		get
		{
			if (Tu5 == null)
			{
				Tu5 = new RoutedUICommand(SR.GetString(SRName.UICommandMoveWindowText), WP6RZJql8gZrNhVA9v.L3hoFlcqP6(98532), typeof(Window));
				CommandManager.RegisterClassCommandBinding(typeof(Window), new CommandBinding(Tu5, EuA, gul));
			}
			return Tu5;
		}
	}

	public static ICommand RestoreCommand
	{
		get
		{
			if (JuR == null)
			{
				JuR = new RoutedUICommand(SR.GetString(SRName.UICommandRestoreWindowText), WP6RZJql8gZrNhVA9v.L3hoFlcqP6(98544), typeof(Window));
				CommandManager.RegisterClassCommandBinding(typeof(Window), new CommandBinding(JuR, tuY, nuC));
			}
			return JuR;
		}
	}

	public static ICommand SizeCommand
	{
		get
		{
			if (suE == null)
			{
				suE = new RoutedUICommand(SR.GetString(SRName.UICommandSizeWindowText), WP6RZJql8gZrNhVA9v.L3hoFlcqP6(98562), typeof(Window));
				CommandManager.RegisterClassCommandBinding(typeof(Window), new CommandBinding(suE, Hux, quI));
			}
			return suE;
		}
	}

	public object StyleKey
	{
		get
		{
			return GetValue(StyleKeyProperty);
		}
		set
		{
			SetValue(StyleKeyProperty, value);
		}
	}

	public static Thickness SystemResizeBorderThickness
	{
		get
		{
			if (!uus.HasValue)
			{
				uus = NativeMethods.GetSystemResizeBorderThickness();
			}
			return uus.Value;
		}
	}

	public static Thickness SystemTitleBarCaptionButtonMargin
	{
		get
		{
			if (!ouL.HasValue)
			{
				ouL = new Thickness(0.0, 0.0, SystemParameters.WindowCaptionButtonWidth * 3.0, 0.0);
			}
			return ouL.Value;
		}
	}

	public HorizontalAlignment TitleBarHeaderAlignment
	{
		get
		{
			return (HorizontalAlignment)GetValue(TitleBarHeaderAlignmentProperty);
		}
		set
		{
			SetValue(TitleBarHeaderAlignmentProperty, value);
		}
	}

	public Thickness TitleBarHeaderMargin
	{
		get
		{
			return (Thickness)GetValue(TitleBarHeaderMarginProperty);
		}
		set
		{
			SetValue(TitleBarHeaderMarginProperty, value);
		}
	}

	public double TitleBarHeaderMinWidth
	{
		get
		{
			return (double)GetValue(TitleBarHeaderMinWidthProperty);
		}
		set
		{
			SetValue(TitleBarHeaderMinWidthProperty, value);
		}
	}

	public DataTemplate TitleBarHeaderTemplate
	{
		get
		{
			return (DataTemplate)GetValue(TitleBarHeaderTemplateProperty);
		}
		set
		{
			SetValue(TitleBarHeaderTemplateProperty, value);
		}
	}

	public DataTemplateSelector TitleBarHeaderTemplateSelector
	{
		get
		{
			return (DataTemplateSelector)GetValue(TitleBarHeaderTemplateSelectorProperty);
		}
		set
		{
			SetValue(TitleBarHeaderTemplateSelectorProperty, value);
		}
	}

	public double TitleBarLeftContentMaxWidthOverflowPercentage
	{
		get
		{
			return (double)GetValue(TitleBarLeftContentMaxWidthOverflowPercentageProperty);
		}
		set
		{
			SetValue(TitleBarLeftContentMaxWidthOverflowPercentageProperty, value);
		}
	}

	public DataTemplate TitleBarLeftContentTemplate
	{
		get
		{
			return (DataTemplate)GetValue(TitleBarLeftContentTemplateProperty);
		}
		set
		{
			SetValue(TitleBarLeftContentTemplateProperty, value);
		}
	}

	public DataTemplateSelector TitleBarLeftContentTemplateSelector
	{
		get
		{
			return (DataTemplateSelector)GetValue(TitleBarLeftContentTemplateSelectorProperty);
		}
		set
		{
			SetValue(TitleBarLeftContentTemplateSelectorProperty, value);
		}
	}

	public WindowChromeTitleBarMergeKind TitleBarMergeKind
	{
		get
		{
			return (WindowChromeTitleBarMergeKind)GetValue(TitleBarMergeKindProperty);
		}
		set
		{
			SetValue(TitleBarMergeKindProperty, value);
		}
	}

	public double TitleBarRightContentMaxWidthOverflowPercentage
	{
		get
		{
			return (double)GetValue(TitleBarRightContentMaxWidthOverflowPercentageProperty);
		}
		set
		{
			SetValue(TitleBarRightContentMaxWidthOverflowPercentageProperty, value);
		}
	}

	public DataTemplate TitleBarRightContentTemplate
	{
		get
		{
			return (DataTemplate)GetValue(TitleBarRightContentTemplateProperty);
		}
		set
		{
			SetValue(TitleBarRightContentTemplateProperty, value);
		}
	}

	public DataTemplateSelector TitleBarRightContentTemplateSelector
	{
		get
		{
			return (DataTemplateSelector)GetValue(TitleBarRightContentTemplateSelectorProperty);
		}
		set
		{
			SetValue(TitleBarRightContentTemplateSelectorProperty, value);
		}
	}

	public static ICommand ToggleIsOverlayVisibleCommand
	{
		get
		{
			if (Gud == null)
			{
				Gud = new RoutedUICommand(SR.GetString(SRName.UICommandRestoreWindowText), WP6RZJql8gZrNhVA9v.L3hoFlcqP6(98574), typeof(Window));
				CommandManager.RegisterClassCommandBinding(typeof(Window), new CommandBinding(Gud, Kur));
			}
			return Gud;
		}
	}

	public event RoutedEventHandler IsOverlayVisibleChanged
	{
		[CompilerGenerated]
		add
		{
			RoutedEventHandler routedEventHandler = FuN;
			RoutedEventHandler routedEventHandler2;
			do
			{
				routedEventHandler2 = routedEventHandler;
				RoutedEventHandler value2 = (RoutedEventHandler)Delegate.Combine(routedEventHandler2, value);
				routedEventHandler = Interlocked.CompareExchange(ref FuN, value2, routedEventHandler2);
			}
			while ((object)routedEventHandler != routedEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			RoutedEventHandler routedEventHandler = FuN;
			RoutedEventHandler routedEventHandler2;
			do
			{
				routedEventHandler2 = routedEventHandler;
				RoutedEventHandler value2 = (RoutedEventHandler)Delegate.Remove(routedEventHandler2, value);
				routedEventHandler = Interlocked.CompareExchange(ref FuN, value2, routedEventHandler2);
			}
			while ((object)routedEventHandler != routedEventHandler2);
		}
	}

	internal event EventHandler RenderPropertyChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = duM;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref duM, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = duM;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref duM, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<CancelRoutedEventArgs> TitleBarContextMenuRequested
	{
		[CompilerGenerated]
		add
		{
			EventHandler<CancelRoutedEventArgs> eventHandler = yuK;
			EventHandler<CancelRoutedEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<CancelRoutedEventArgs> value2 = (EventHandler<CancelRoutedEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref yuK, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<CancelRoutedEventArgs> eventHandler = yuK;
			EventHandler<CancelRoutedEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<CancelRoutedEventArgs> value2 = (EventHandler<CancelRoutedEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref yuK, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<WindowBoundsChangeEventArgs> WindowBoundsChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler<WindowBoundsChangeEventArgs> eventHandler = Lug;
			EventHandler<WindowBoundsChangeEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<WindowBoundsChangeEventArgs> value2 = (EventHandler<WindowBoundsChangeEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref Lug, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<WindowBoundsChangeEventArgs> eventHandler = Lug;
			EventHandler<WindowBoundsChangeEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<WindowBoundsChangeEventArgs> value2 = (EventHandler<WindowBoundsChangeEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref Lug, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<WindowBoundsChangeEventArgs> WindowBoundsChanging
	{
		[CompilerGenerated]
		add
		{
			EventHandler<WindowBoundsChangeEventArgs> eventHandler = Uu8;
			EventHandler<WindowBoundsChangeEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<WindowBoundsChangeEventArgs> value2 = (EventHandler<WindowBoundsChangeEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref Uu8, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<WindowBoundsChangeEventArgs> eventHandler = Uu8;
			EventHandler<WindowBoundsChangeEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<WindowBoundsChangeEventArgs> value2 = (EventHandler<WindowBoundsChangeEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref Uu8, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<ContextMenuOpeningEventArgs> WindowSystemMenuOpening
	{
		[CompilerGenerated]
		add
		{
			EventHandler<ContextMenuOpeningEventArgs> eventHandler = puD;
			EventHandler<ContextMenuOpeningEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<ContextMenuOpeningEventArgs> value2 = (EventHandler<ContextMenuOpeningEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref puD, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<ContextMenuOpeningEventArgs> eventHandler = puD;
			EventHandler<ContextMenuOpeningEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<ContextMenuOpeningEventArgs> value2 = (EventHandler<ContextMenuOpeningEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref puD, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public WindowChrome()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	private static void IuF(object P_0, CanExecuteRoutedEventArgs P_1)
	{
		if (P_0 is Window window)
		{
			P_1.CanExecute = GetHasCloseButtonResolved(window);
			P_1.Handled = true;
		}
	}

	private static void uuo(object P_0, ExecutedRoutedEventArgs P_1)
	{
		if (P_0 is Window window)
		{
			window.Close();
		}
	}

	private static void TuQ(object P_0, CanExecuteRoutedEventArgs P_1)
	{
		if (P_0 is Window window)
		{
			P_1.CanExecute = GetHasMaximizeButtonResolved(window);
			P_1.Handled = true;
		}
	}

	private static void KuO(object P_0, ExecutedRoutedEventArgs P_1)
	{
		if (P_0 is Window window)
		{
			NativeMethods.SetWindowState(window, WindowState.Maximized);
		}
	}

	private static void zu0(object P_0, CanExecuteRoutedEventArgs P_1)
	{
		if (P_0 is Window window)
		{
			P_1.CanExecute = GetHasMinimizeButtonResolved(window);
			P_1.Handled = true;
		}
	}

	private static void Guk(object P_0, ExecutedRoutedEventArgs P_1)
	{
		if (P_0 is Window window)
		{
			NativeMethods.SetWindowState(window, WindowState.Minimized);
		}
	}

	private static void gul(object P_0, CanExecuteRoutedEventArgs P_1)
	{
		if (P_0 is Window)
		{
			P_1.CanExecute = true;
			P_1.Handled = true;
		}
	}

	private static void EuA(object P_0, ExecutedRoutedEventArgs P_1)
	{
		if (P_0 is Window window)
		{
			NativeMethods.StartWindowMove(window);
		}
	}

	private static void nuC(object P_0, CanExecuteRoutedEventArgs P_1)
	{
		if (P_0 is Window window)
		{
			P_1.CanExecute = GetHasRestoreButtonResolved(window);
			P_1.Handled = true;
		}
	}

	private static void tuY(object P_0, ExecutedRoutedEventArgs P_1)
	{
		if (P_0 is Window window)
		{
			NativeMethods.SetWindowState(window, WindowState.Normal);
		}
	}

	private static void quI(object P_0, CanExecuteRoutedEventArgs P_1)
	{
		if (P_0 is Window window)
		{
			P_1.CanExecute = GetIsResizableResolved(window);
			P_1.Handled = true;
		}
	}

	private static void Hux(object P_0, ExecutedRoutedEventArgs P_1)
	{
		if (P_0 is Window window)
		{
			NativeMethods.StartWindowResize(window, ResizeOperation.None);
		}
	}

	private static void Kur(object P_0, ExecutedRoutedEventArgs P_1)
	{
		if (P_0 is Window window)
		{
			WindowChrome chrome = GetChrome(window);
			if (chrome != null)
			{
				SetIsOverlayVisible(window, !GetIsOverlayVisible(window));
			}
		}
	}

	internal ContextMenu CreateSystemMenu(Window window, Point location, NativeMethods.NonClientHitTestResult hitTestResult)
	{
		if (window != null)
		{
			Path path = new Path
			{
				Width = 16.0,
				Height = 16.0,
				Opacity = 0.8,
				Data = Geometry.Parse(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(97960))
			};
			Path path2 = new Path
			{
				Width = 16.0,
				Height = 16.0,
				Opacity = 0.8,
				Data = Geometry.Parse(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(98018))
			};
			Path path3 = new Path
			{
				Width = 16.0,
				Height = 16.0,
				Opacity = 0.8,
				Data = Geometry.Parse(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(98112))
			};
			Path path4 = new Path
			{
				Width = 16.0,
				Height = 16.0,
				Opacity = 0.8,
				Data = Geometry.Parse(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(98170))
			};
			path.SetBinding(Shape.StrokeProperty, new Binding(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(98376))
			{
				RelativeSource = new RelativeSource(RelativeSourceMode.Self)
			});
			path2.SetBinding(Shape.StrokeProperty, new Binding(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(98376))
			{
				RelativeSource = new RelativeSource(RelativeSourceMode.Self)
			});
			path3.SetBinding(Shape.FillProperty, new Binding(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(98376))
			{
				RelativeSource = new RelativeSource(RelativeSourceMode.Self)
			});
			path4.SetBinding(Shape.StrokeProperty, new Binding(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(98376))
			{
				RelativeSource = new RelativeSource(RelativeSourceMode.Self)
			});
			int num = 4;
			if (WYE() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			ContextMenu contextMenu = default(ContextMenu);
			MenuItem menuItem3 = default(MenuItem);
			MenuItem newItem2 = default(MenuItem);
			MenuItem newItem3 = default(MenuItem);
			MenuItem menuItem2 = default(MenuItem);
			MenuItem menuItem = default(MenuItem);
			MenuItem newItem = default(MenuItem);
			ContextMenu result = default(ContextMenu);
			while (true)
			{
				switch (num)
				{
				case 1:
					contextMenu.HorizontalOffset = location.X;
					contextMenu.VerticalOffset = location.Y;
					contextMenu.PlacementTarget = window;
					contextMenu.Placement = PlacementMode.Absolute;
					contextMenu.Tag = (int)hitTestResult;
					return contextMenu;
				default:
					contextMenu = new ContextMenu();
					if (GetHasRestoreButtonResolved(window))
					{
						contextMenu.Items.Add(menuItem3);
					}
					contextMenu.Items.Add(newItem2);
					if (GetIsResizableResolved(window))
					{
						contextMenu.Items.Add(newItem3);
					}
					if (GetHasMinimizeButtonResolved(window))
					{
						contextMenu.Items.Add(menuItem2);
					}
					if (GetHasMaximizeButtonResolved(window))
					{
						contextMenu.Items.Add(menuItem);
					}
					if (GetHasCloseButtonResolved(window))
					{
						contextMenu.Items.Add(new Separator());
						contextMenu.Items.Add(newItem);
						num = 1;
						if (!jYl())
						{
							num = 1;
						}
						break;
					}
					goto case 1;
				case 4:
					newItem = new MenuItem
					{
						Icon = path,
						Header = SR.GetString(SRName.UICommandCloseWindowText),
						CommandTarget = window,
						Command = CloseCommand,
						InputGestureText = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(98428)
					};
					menuItem = new MenuItem
					{
						Icon = path2,
						Header = SR.GetString(SRName.UICommandMaximizeWindowText),
						CommandTarget = window,
						Command = MaximizeCommand
					};
					menuItem2 = new MenuItem
					{
						Icon = path3,
						Header = SR.GetString(SRName.UICommandMinimizeWindowText),
						CommandTarget = window,
						Command = MinimizeCommand
					};
					newItem2 = new MenuItem
					{
						Header = SR.GetString(SRName.UICommandMoveWindowText),
						CommandTarget = window,
						Command = MoveCommand
					};
					menuItem3 = new MenuItem
					{
						Icon = path4,
						Header = SR.GetString(SRName.UICommandRestoreWindowText),
						CommandTarget = window,
						Command = RestoreCommand
					};
					newItem3 = new MenuItem
					{
						Header = SR.GetString(SRName.UICommandSizeWindowText),
						CommandTarget = window,
						Command = SizeCommand
					};
					switch (window.WindowState)
					{
					case WindowState.Maximized:
						menuItem.IsEnabled = false;
						break;
					case WindowState.Normal:
						menuItem3.IsEnabled = false;
						break;
					case WindowState.Minimized:
						menuItem2.IsEnabled = false;
						num = 0;
						if (jYl())
						{
							num = 0;
						}
						goto end_IL_0009;
					}
					goto default;
				case 3:
					{
						return result;
					}
					end_IL_0009:
					break;
				}
			}
		}
		return null;
	}

	internal static bool GetHasCloseButtonResolved(Window window)
	{
		if (window != null)
		{
			return GetChrome(window)?.HasCloseButton ?? true;
		}
		return true;
	}

	internal static bool GetHasMaximizeButtonResolved(Window window)
	{
		bool result;
		if (window != null)
		{
			WindowChrome chrome = GetChrome(window);
			if (chrome != null)
			{
				bool? hasMaximizeButton = chrome.HasMaximizeButton;
				bool? flag = hasMaximizeButton;
				if (!flag.HasValue)
				{
					ResizeMode resizeMode = window.ResizeMode;
					ResizeMode resizeMode2 = resizeMode;
					if ((uint)resizeMode2 <= 1u)
					{
						result = false;
						int num = 1;
						if (!jYl())
						{
							int num2 = default(int);
							num = num2;
						}
						switch (num)
						{
						case 1:
							goto IL_013f;
						}
						goto IL_004f;
					}
				}
				else if (flag != true)
				{
					goto IL_004f;
				}
			}
		}
		result = true;
		goto IL_013f;
		IL_004f:
		result = false;
		goto IL_013f;
		IL_013f:
		return result;
	}

	internal static bool GetHasMinimizeButtonResolved(Window window)
	{
		bool result;
		if (window != null)
		{
			WindowChrome chrome = GetChrome(window);
			if (chrome != null)
			{
				bool? hasMinimizeButton = chrome.HasMinimizeButton;
				bool? flag = hasMinimizeButton;
				if (!flag.HasValue)
				{
					goto IL_00b6;
				}
				if (flag != true)
				{
					result = false;
					goto IL_006a;
				}
			}
		}
		goto IL_00fd;
		IL_00b6:
		if (window.ResizeMode != ResizeMode.NoResize)
		{
			goto IL_00fd;
		}
		result = false;
		goto IL_006a;
		IL_00fd:
		result = true;
		int num = 1;
		if (WYE() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		case 1:
			break;
		default:
			goto IL_00b6;
		}
		goto IL_006a;
		IL_006a:
		return result;
	}

	internal static bool GetHasRestoreButtonResolved(Window window)
	{
		if (window != null)
		{
			WindowChrome chrome = GetChrome(window);
			if (chrome != null)
			{
				bool? hasRestoreButton = chrome.HasRestoreButton;
				bool? flag = hasRestoreButton;
				if (!flag.HasValue)
				{
					ResizeMode resizeMode = window.ResizeMode;
					int num = 1;
					if (WYE() != null)
					{
						int num2 = default(int);
						num = num2;
					}
					switch (num)
					{
					case 1:
						break;
					default:
					{
						bool result = default(bool);
						return result;
					}
					}
					if (resizeMode == ResizeMode.NoResize)
					{
						return false;
					}
				}
				else if (flag != true)
				{
					return false;
				}
			}
		}
		return true;
	}

	internal static bool GetIsResizableResolved(Window window)
	{
		if (window != null)
		{
			ResizeMode resizeMode = window.ResizeMode;
			ResizeMode resizeMode2 = resizeMode;
			if ((uint)resizeMode2 <= 1u)
			{
				return false;
			}
		}
		return true;
	}

	private static void SuZ(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		int num = 2;
		bool isInDesignMode = default(bool);
		WindowChrome windowChrome = default(WindowChrome);
		WindowChromeManager windowChromeManager = default(WindowChromeManager);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (isInDesignMode || !(P_0 is Window obj))
					{
						return;
					}
					windowChrome = P_1.NewValue as WindowChrome;
					if (windowChrome != null)
					{
						windowChromeManager = WindowChromeManager.GetWindowChromeManager(obj);
						if (windowChromeManager == null)
						{
							windowChromeManager = new WindowChromeManager();
							WindowChromeManager.SetWindowChromeManager(obj, windowChromeManager);
							num2 = 0;
							if (jYl())
							{
								continue;
							}
							break;
						}
						goto default;
					}
					WindowChromeManager.SetWindowChromeManager(obj, null);
					return;
				case 2:
					isInDesignMode = DesignerProperties.GetIsInDesignMode(P_0);
					num2 = 1;
					if (jYl())
					{
						continue;
					}
					break;
				default:
					windowChromeManager.UpdateWindowChrome(windowChrome);
					return;
				}
				break;
			}
		}
	}

	private static void zun(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		if (P_0 is Window window)
		{
			GetChrome(window)?.Juq(window);
		}
	}

	private static void aua(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		if (P_1.OldValue != null && P_1.OldValue.Equals(P_1.NewValue))
		{
			return;
		}
		int num = 0;
		if (WYE() != null)
		{
			goto IL_0005;
		}
		goto IL_0009;
		IL_0009:
		bool flag = default(bool);
		WindowChrome windowChrome = default(WindowChrome);
		while (true)
		{
			switch (num)
			{
			case 1:
				if (flag)
				{
					windowChrome.duM?.Invoke(windowChrome, EventArgs.Empty);
				}
				return;
			}
			windowChrome = P_0 as WindowChrome;
			if (windowChrome == null && P_0 is Window window)
			{
				windowChrome = GetChrome(window);
			}
			flag = windowChrome != null;
			num = 1;
			if (jYl())
			{
				continue;
			}
			break;
		}
		goto IL_0005;
		IL_0005:
		int num2 = default(int);
		num = num2;
		goto IL_0009;
	}

	private void Juq(Window P_0)
	{
		RoutedEventArgs e = new RoutedEventArgs(IsOverlayVisibleChangedEvent, P_0);
		FuN?.Invoke(this, e);
	}

	internal bool RaiseTitleBarContextMenuRequestedEvent(Window window)
	{
		CancelRoutedEventArgs e = new CancelRoutedEventArgs(TitleBarContextMenuRequestedEvent, window);
		yuK?.Invoke(this, e);
		return e.Cancel;
	}

	internal void RaiseWindowBoundsChangedEvent(Window window, bool isMove)
	{
		WindowBoundsChangeEventArgs e = new WindowBoundsChangeEventArgs(isMove, WindowBoundsChangedEvent, window);
		Lug?.Invoke(this, e);
	}

	internal void RaiseWindowBoundsChangingEvent(Window window, bool isMove)
	{
		WindowBoundsChangeEventArgs e = new WindowBoundsChangeEventArgs(isMove, WindowBoundsChangingEvent, window);
		Uu8?.Invoke(this, e);
	}

	internal ContextMenu RaiseWindowSystemMenuOpeningEvent(Window window, ContextMenu menu)
	{
		ContextMenuOpeningEventArgs e = new ContextMenuOpeningEventArgs(WindowSystemMenuOpeningEvent, window, menu);
		puD?.Invoke(this, e);
		return e.Menu;
	}

	[SpecialName]
	private static double fuW()
	{
		if (BrowserInteropHelper.IsBrowserHosted)
		{
			return 30.0;
		}
		return WindowCaptionHeightCore;
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static WindowChrome GetChrome(Window window)
	{
		if (window == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(98444));
		}
		return (WindowChrome)window.GetValue(ChromeProperty);
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static void SetChrome(Window window, WindowChrome value)
	{
		if (window == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(98444));
		}
		window.SetValue(ChromeProperty, value);
	}

	protected override Freezable CreateInstanceCore()
	{
		return new WindowChrome();
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static WindowChromeElementKind GetElementKind(UIElement element)
	{
		if (element == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(98474));
		}
		return (WindowChromeElementKind)element.GetValue(ElementKindProperty);
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static void SetElementKind(UIElement element, WindowChromeElementKind value)
	{
		if (element == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(98474));
		}
		element.SetValue(ElementKindProperty, value);
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static Window GetOuterGlow(Window window)
	{
		if (window == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(98444));
		}
		return WindowChromeManager.GetWindowChromeManager(window)?.OuterGlow;
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static bool GetIsOverlayVisible(Window window)
	{
		if (window == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(98444));
		}
		return (bool)window.GetValue(IsOverlayVisibleProperty);
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static void SetIsOverlayVisible(Window window, bool value)
	{
		if (window == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(98444));
		}
		window.SetValue(IsOverlayVisibleProperty, value);
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static bool GetIsTaskbarAutoHidden(Window window)
	{
		if (window == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(98444));
		}
		return (bool)window.GetValue(IsTaskbarAutoHiddenProperty);
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	internal static void SetIsTaskbarAutoHidden(Window window, bool value)
	{
		if (window == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(98444));
		}
		window.SetValue(IsTaskbarAutoHiddenPropertyKey, value);
	}

	public static void OpenSystemMenu(FrameworkElement element, Point point)
	{
		if (element == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(98474));
		}
		NativeMethods.ShowSystemMenu(element, point);
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static OverlayAnimationKinds GetOverlayAnimationKinds(Window window)
	{
		if (window == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(98444));
		}
		return (OverlayAnimationKinds)window.GetValue(OverlayAnimationKindsProperty);
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static void SetOverlayAnimationKinds(Window window, OverlayAnimationKinds value)
	{
		if (window == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(98444));
		}
		window.SetValue(OverlayAnimationKindsProperty, value);
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static object GetOverlayContent(Window window)
	{
		if (window == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(98444));
		}
		return window.GetValue(OverlayContentProperty);
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static void SetOverlayContent(Window window, object value)
	{
		if (window == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(98444));
		}
		window.SetValue(OverlayContentProperty, value);
	}

	public static void SetWindowStyle(Window window, WindowStyle style)
	{
		if (window == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(98444));
		}
		WindowChromeManager windowChromeManager = WindowChromeManager.GetWindowChromeManager(window);
		if (windowChromeManager == null)
		{
			window.WindowStyle = style;
		}
		else
		{
			windowChromeManager.SetWindowStyle(style);
		}
	}

	public static void StartResize(Window window, ResizeOperation operation)
	{
		if (window == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(98444));
		}
		NativeMethods.StartWindowResize(window, operation);
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static string GetThemeName(Window window)
	{
		if (window == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(98444));
		}
		return (string)window.GetValue(ThemeNameProperty);
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static void SetThemeName(Window window, string value)
	{
		if (window == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(98444));
		}
		window.SetValue(ThemeNameProperty, value);
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static object GetTitleBarHeader(Window window)
	{
		if (window == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(98444));
		}
		return window.GetValue(TitleBarHeaderProperty);
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static void SetTitleBarHeader(Window window, object value)
	{
		if (window == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(98444));
		}
		window.SetValue(TitleBarHeaderProperty, value);
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static double GetTitleBarHeight(Window window)
	{
		if (window == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(98444));
		}
		return (double)window.GetValue(TitleBarHeightProperty);
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	internal static void SetTitleBarHeight(Window window, double value)
	{
		if (window == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(98444));
		}
		window.SetValue(TitleBarHeightPropertyKey, value);
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static object GetTitleBarLeftContent(Window window)
	{
		if (window == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(98444));
		}
		return window.GetValue(TitleBarLeftContentProperty);
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static void SetTitleBarLeftContent(Window window, object value)
	{
		if (window == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(98444));
		}
		window.SetValue(TitleBarLeftContentProperty, value);
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static double GetTitleBarLeftContentWidth(Window window)
	{
		if (window == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(98444));
		}
		return (double)window.GetValue(TitleBarLeftContentWidthProperty);
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	internal static void SetTitleBarLeftContentWidth(Window window, double value)
	{
		if (window == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(98444));
		}
		window.SetValue(TitleBarLeftContentWidthPropertyKey, value);
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static double GetTitleBarMinHeight(Window window)
	{
		if (window == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(98444));
		}
		return (double)window.GetValue(TitleBarMinHeightProperty);
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static void SetTitleBarMinHeight(Window window, double value)
	{
		if (window == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(98444));
		}
		window.SetValue(TitleBarMinHeightProperty, value);
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static object GetTitleBarRightContent(Window window)
	{
		if (window == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(98444));
		}
		return window.GetValue(TitleBarRightContentProperty);
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static void SetTitleBarRightContent(Window window, object value)
	{
		if (window == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(98444));
		}
		window.SetValue(TitleBarRightContentProperty, value);
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static double GetTitleBarRightContentWidth(Window window)
	{
		if (window == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(98444));
		}
		return (double)window.GetValue(TitleBarRightContentWidthProperty);
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	internal static void SetTitleBarRightContentWidth(Window window, double value)
	{
		if (window == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(98444));
		}
		window.SetValue(TitleBarRightContentWidthPropertyKey, value);
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static bool GetUseAlternateTitleBarStyle(Window window)
	{
		if (window == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(98444));
		}
		return (bool)window.GetValue(UseAlternateTitleBarStyleProperty);
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static void SetUseAlternateTitleBarStyle(Window window, bool value)
	{
		if (window == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(98444));
		}
		window.SetValue(UseAlternateTitleBarStyleProperty, value);
	}

	static WindowChrome()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		IsOverlayVisibleChangedEvent = EventManager.RegisterRoutedEvent(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(98622), RoutingStrategy.Direct, typeof(RoutedEventHandler), typeof(WindowChrome));
		TitleBarContextMenuRequestedEvent = EventManager.RegisterRoutedEvent(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(98672), RoutingStrategy.Direct, typeof(EventHandler<CancelRoutedEventArgs>), typeof(WindowChrome));
		WindowBoundsChangedEvent = EventManager.RegisterRoutedEvent(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(98732), RoutingStrategy.Direct, typeof(EventHandler<WindowBoundsChangeEventArgs>), typeof(WindowChrome));
		WindowBoundsChangingEvent = EventManager.RegisterRoutedEvent(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(98774), RoutingStrategy.Direct, typeof(EventHandler<WindowBoundsChangeEventArgs>), typeof(WindowChrome));
		WindowSystemMenuOpeningEvent = EventManager.RegisterRoutedEvent(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(98818), RoutingStrategy.Direct, typeof(EventHandler<ContextMenuOpeningEventArgs>), typeof(WindowChrome));
		int num = 1;
		if (false)
		{
			goto IL_0005;
		}
		goto IL_0009;
		IL_0005:
		int num2 = default(int);
		num = num2;
		goto IL_0009;
		IL_0009:
		while (true)
		{
			switch (num)
			{
			case 2:
				TitleBarRightContentTemplateProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(100438), typeof(DataTemplate), typeof(WindowChrome), new FrameworkPropertyMetadata(null));
				TitleBarRightContentTemplateSelectorProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(100498), typeof(DataTemplateSelector), typeof(WindowChrome), new FrameworkPropertyMetadata(null));
				TitleBarRightContentWidthProperty = TitleBarRightContentWidthPropertyKey.DependencyProperty;
				UseAlternateTitleBarStyleProperty = DependencyProperty.RegisterAttached(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(100574), typeof(bool), typeof(WindowChrome), new FrameworkPropertyMetadata(false));
				return;
			case 3:
				TitleBarMinHeightProperty = DependencyProperty.RegisterAttached(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(100260), typeof(double), typeof(WindowChrome), new FrameworkPropertyMetadata(28.0), (object obj) => ValidationHelper.ValidateDoubleIsPositive(obj));
				TitleBarRightContentProperty = DependencyProperty.RegisterAttached(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(100298), typeof(object), typeof(WindowChrome), new FrameworkPropertyMetadata(null));
				TitleBarRightContentMaxWidthOverflowPercentageProperty = DependencyProperty.RegisterAttached(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(100342), typeof(double), typeof(WindowChrome), new FrameworkPropertyMetadata(0.3), (object obj) => ValidationHelper.ValidateDoubleIsPercentage(obj));
				num = 2;
				continue;
			case 4:
				OverlayAnimationKindsProperty = DependencyProperty.RegisterAttached(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(99390), typeof(OverlayAnimationKinds), typeof(WindowChrome), new FrameworkPropertyMetadata(OverlayAnimationKinds.Fade));
				OverlayContentProperty = DependencyProperty.RegisterAttached(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(99436), typeof(object), typeof(WindowChrome), new FrameworkPropertyMetadata(null));
				OverlayContentTemplateProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(99468), typeof(DataTemplate), typeof(WindowChrome), new FrameworkPropertyMetadata(null));
				OverlayContentTemplateSelectorProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(99516), typeof(DataTemplateSelector), typeof(WindowChrome), new FrameworkPropertyMetadata(null));
				ResizeBorderThicknessProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(99580), typeof(Thickness?), typeof(WindowChrome), new FrameworkPropertyMetadata(null));
				StyleKeyProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(99626), typeof(object), typeof(WindowChrome), new FrameworkPropertyMetadata(SharedResourceKeys.WindowChromeStyleKey));
				ThemeNameProperty = DependencyProperty.RegisterAttached(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(99646), typeof(string), typeof(WindowChrome), new FrameworkPropertyMetadata(null));
				TitleBarHeaderProperty = DependencyProperty.RegisterAttached(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(99668), typeof(object), typeof(WindowChrome), new FrameworkPropertyMetadata(null));
				TitleBarHeaderAlignmentProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(99700), typeof(HorizontalAlignment), typeof(WindowChrome), new FrameworkPropertyMetadata(HorizontalAlignment.Left));
				TitleBarHeaderMarginProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(99750), typeof(Thickness), typeof(WindowChrome), new FrameworkPropertyMetadata(new Thickness(8.0, 0.0, 8.0, 0.0)));
				TitleBarHeaderMinWidthProperty = DependencyProperty.RegisterAttached(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(99794), typeof(double), typeof(WindowChrome), new FrameworkPropertyMetadata(50.0), (object obj) => ValidationHelper.ValidateDoubleIsPositive(obj));
				TitleBarHeaderTemplateProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(99842), typeof(DataTemplate), typeof(WindowChrome), new FrameworkPropertyMetadata(null));
				TitleBarHeaderTemplateSelectorProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(99890), typeof(DataTemplateSelector), typeof(WindowChrome), new FrameworkPropertyMetadata(new WindowChromeTitleBarHeaderTemplateSelector()));
				TitleBarHeightProperty = TitleBarHeightPropertyKey.DependencyProperty;
				num = 0;
				if (0 == 0)
				{
					continue;
				}
				break;
			default:
				TitleBarLeftContentProperty = DependencyProperty.RegisterAttached(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(99954), typeof(object), typeof(WindowChrome), new FrameworkPropertyMetadata(null));
				TitleBarLeftContentMaxWidthOverflowPercentageProperty = DependencyProperty.RegisterAttached(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(99996), typeof(double), typeof(WindowChrome), new FrameworkPropertyMetadata(0.3), (object obj) => ValidationHelper.ValidateDoubleIsPercentage(obj));
				TitleBarLeftContentTemplateProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(100090), typeof(DataTemplate), typeof(WindowChrome), new FrameworkPropertyMetadata(null));
				TitleBarLeftContentTemplateSelectorProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(100148), typeof(DataTemplateSelector), typeof(WindowChrome), new FrameworkPropertyMetadata(null));
				TitleBarLeftContentWidthProperty = TitleBarLeftContentWidthPropertyKey.DependencyProperty;
				TitleBarMergeKindProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(100222), typeof(WindowChromeTitleBarMergeKind), typeof(WindowChrome), new FrameworkPropertyMetadata(WindowChromeTitleBarMergeKind.None));
				num = 3;
				if (true)
				{
					continue;
				}
				break;
			case 1:
				IsTaskbarAutoHiddenPropertyKey = DependencyProperty.RegisterAttachedReadOnly(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(98868), typeof(bool), typeof(WindowChrome), new FrameworkPropertyMetadata(false));
				TitleBarHeightPropertyKey = DependencyProperty.RegisterAttachedReadOnly(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(98910), typeof(double), typeof(WindowChrome), new FrameworkPropertyMetadata(0.0));
				TitleBarLeftContentWidthPropertyKey = DependencyProperty.RegisterAttachedReadOnly(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(98942), typeof(double), typeof(WindowChrome), new FrameworkPropertyMetadata(0.0));
				TitleBarRightContentWidthPropertyKey = DependencyProperty.RegisterAttachedReadOnly(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(98994), typeof(double), typeof(WindowChrome), new FrameworkPropertyMetadata(0.0));
				ChromeProperty = DependencyProperty.RegisterAttached(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(99048), typeof(WindowChrome), typeof(WindowChrome), new FrameworkPropertyMetadata(null, SuZ));
				ElementKindProperty = DependencyProperty.RegisterAttached(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(99064), typeof(WindowChromeElementKind), typeof(WindowChrome), new FrameworkPropertyMetadata(WindowChromeElementKind.Unknown));
				HasCloseButtonProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(99090), typeof(bool), typeof(WindowChrome), new FrameworkPropertyMetadata(true, aua));
				HasIconProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(99122), typeof(bool), typeof(WindowChrome), new FrameworkPropertyMetadata(true));
				HasMaximizeButtonProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(99140), typeof(bool?), typeof(WindowChrome), new FrameworkPropertyMetadata(null, aua));
				HasMinimizeButtonProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(99178), typeof(bool?), typeof(WindowChrome), new FrameworkPropertyMetadata(null, aua));
				HasOuterGlowProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(99216), typeof(bool?), typeof(WindowChrome), new FrameworkPropertyMetadata(null, aua));
				HasRestoreButtonProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(99244), typeof(bool?), typeof(WindowChrome), new FrameworkPropertyMetadata(null, aua));
				HasTitleBarProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(99280), typeof(bool), typeof(WindowChrome), new FrameworkPropertyMetadata(true));
				IconMarginProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(99306), typeof(Thickness), typeof(WindowChrome), new FrameworkPropertyMetadata(new Thickness(8.0, 2.0, 8.0, 2.0)));
				IconSourceProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(99330), typeof(ImageSource), typeof(WindowChrome), new FrameworkPropertyMetadata(null));
				IsOverlayVisibleProperty = DependencyProperty.RegisterAttached(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(99354), typeof(bool), typeof(WindowChrome), new FrameworkPropertyMetadata(false, zun));
				IsTaskbarAutoHiddenProperty = IsTaskbarAutoHiddenPropertyKey.DependencyProperty;
				num = 3;
				if (0 == 0)
				{
					num = 4;
				}
				continue;
			}
			break;
		}
		goto IL_0005;
	}

	internal static bool jYl()
	{
		return pY2 == null;
	}

	internal static WindowChrome WYE()
	{
		return pY2;
	}
}
