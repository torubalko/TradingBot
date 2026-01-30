using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;
using ActiproSoftware.Windows.Controls.Automation.Peers;
using ActiproSoftware.Windows.Controls.Popups;
using ActiproSoftware.Windows.Media;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Controls;

[TemplatePart(Name = "PART_Popup", Type = typeof(Popup))]
[TemplatePart(Name = "PART_IndicatorArea", Type = typeof(UIElement))]
public class PopupButton : Button, IPopupAnchor
{
	private enum pR
	{

	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass54_0
	{
		public PopupButton kHo;

		private static _003C_003Ec__DisplayClass54_0 oeX;

		public _003C_003Ec__DisplayClass54_0()
		{
			hHEYokUTtehNq5ji0d.LrmWXz();
			base._002Ector();
		}

		internal void aHF()
		{
			VisualTreeHelperExtended.GetFirstFocusableDescendant(kHo.QAq().Child)?.Focus();
		}

		internal static bool TeU()
		{
			return oeX == null;
		}

		internal static _003C_003Ec__DisplayClass54_0 reL()
		{
			return oeX;
		}
	}

	private bool EA6;

	private UIElement WAV;

	public static readonly RoutedEvent PopupClosedEvent;

	public static readonly RoutedEvent PopupOpenedEvent;

	public static readonly RoutedEvent PopupOpeningEvent;

	public static readonly DependencyProperty DisplayModeProperty;

	public static readonly DependencyProperty HasDropShadowProperty;

	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "AutoFocus")]
	public static readonly DependencyProperty IsAutoFocusOnOpenEnabledProperty;

	public static readonly DependencyProperty IsPopupOpenProperty;

	public static readonly DependencyProperty IsTransparencyModeEnabledProperty;

	public static readonly DependencyProperty PopupAllowsTransparencyProperty;

	public static readonly DependencyProperty PopupAnimationProperty;

	public static readonly DependencyProperty PopupBackgroundProperty;

	public static readonly DependencyProperty PopupBorderBrushProperty;

	public static readonly DependencyProperty PopupBorderThicknessProperty;

	public static readonly DependencyProperty PopupContentProperty;

	public static readonly DependencyProperty PopupContentTemplateProperty;

	public static readonly DependencyProperty PopupContentTemplateSelectorProperty;

	public static readonly DependencyProperty PopupCornerRadiusProperty;

	public static readonly DependencyProperty PopupHorizontalOffsetProperty;

	public static readonly DependencyProperty PopupIndicatorProperty;

	public static readonly DependencyProperty PopupIndicatorTemplateProperty;

	public static readonly DependencyProperty PopupIndicatorToolTipProperty;

	public static readonly DependencyProperty PopupMenuProperty;

	public static readonly DependencyProperty PopupMenuDataContextProperty;

	public static readonly DependencyProperty PopupPaddingProperty;

	public static readonly DependencyProperty PopupVerticalOffsetProperty;

	public static readonly DependencyProperty StaysOpenProperty;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Popup mA5;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private static RoutedCommand TAR;

	internal static PopupButton MGu;

	bool IPopupAnchor.PopupStaysOpen => StaysOpen;

	bool IPopupAnchor.SupportsAltDownToOpen => MAn() != (pR)0;

	public static RoutedCommand ClosePopupCommand
	{
		[CompilerGenerated]
		get
		{
			return TAR;
		}
		[CompilerGenerated]
		private set
		{
			TAR = value;
		}
	}

	public PopupButtonDisplayMode DisplayMode
	{
		get
		{
			return (PopupButtonDisplayMode)GetValue(DisplayModeProperty);
		}
		set
		{
			SetValue(DisplayModeProperty, value);
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

	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "AutoFocus")]
	public bool IsAutoFocusOnOpenEnabled
	{
		get
		{
			return (bool)GetValue(IsAutoFocusOnOpenEnabledProperty);
		}
		set
		{
			SetValue(IsAutoFocusOnOpenEnabledProperty, value);
		}
	}

	public bool IsPopupOpen
	{
		get
		{
			return (bool)GetValue(IsPopupOpenProperty);
		}
		set
		{
			SetValue(IsPopupOpenProperty, value);
		}
	}

	public bool IsTransparencyModeEnabled
	{
		get
		{
			return (bool)GetValue(IsTransparencyModeEnabledProperty);
		}
		set
		{
			SetValue(IsTransparencyModeEnabledProperty, value);
		}
	}

	protected override IEnumerator LogicalChildren
	{
		get
		{
			IEnumerator baseEnumerator = base.LogicalChildren;
			if (baseEnumerator != null)
			{
				while (baseEnumerator.MoveNext())
				{
					object baseChild = baseEnumerator.Current;
					if (baseChild != null)
					{
						yield return baseChild;
					}
				}
			}
			object popupContent = PopupContent;
			if (popupContent != null)
			{
				yield return popupContent;
			}
		}
	}

	public bool PopupAllowsTransparency
	{
		get
		{
			return (bool)GetValue(PopupAllowsTransparencyProperty);
		}
		set
		{
			SetValue(PopupAllowsTransparencyProperty, value);
		}
	}

	public PopupAnimation PopupAnimation
	{
		get
		{
			return (PopupAnimation)GetValue(PopupAnimationProperty);
		}
		set
		{
			SetValue(PopupAnimationProperty, value);
		}
	}

	public Brush PopupBackground
	{
		get
		{
			return (Brush)GetValue(PopupBackgroundProperty);
		}
		set
		{
			SetValue(PopupBackgroundProperty, value);
		}
	}

	public Brush PopupBorderBrush
	{
		get
		{
			return (Brush)GetValue(PopupBorderBrushProperty);
		}
		set
		{
			SetValue(PopupBorderBrushProperty, value);
		}
	}

	public Thickness PopupBorderThickness
	{
		get
		{
			return (Thickness)GetValue(PopupBorderThicknessProperty);
		}
		set
		{
			SetValue(PopupBorderThicknessProperty, value);
		}
	}

	public object PopupContent
	{
		get
		{
			return GetValue(PopupContentProperty);
		}
		set
		{
			SetValue(PopupContentProperty, value);
		}
	}

	public DataTemplate PopupContentTemplate
	{
		get
		{
			return (DataTemplate)GetValue(PopupContentTemplateProperty);
		}
		set
		{
			SetValue(PopupContentTemplateProperty, value);
		}
	}

	public DataTemplateSelector PopupContentTemplateSelector
	{
		get
		{
			return (DataTemplateSelector)GetValue(PopupContentTemplateSelectorProperty);
		}
		set
		{
			SetValue(PopupContentTemplateSelectorProperty, value);
		}
	}

	public CornerRadius PopupCornerRadius
	{
		get
		{
			return (CornerRadius)GetValue(PopupCornerRadiusProperty);
		}
		set
		{
			SetValue(PopupCornerRadiusProperty, value);
		}
	}

	public double PopupHorizontalOffset
	{
		get
		{
			return (double)GetValue(PopupHorizontalOffsetProperty);
		}
		set
		{
			SetValue(PopupHorizontalOffsetProperty, value);
		}
	}

	public UIElement PopupIndicator
	{
		get
		{
			return (UIElement)GetValue(PopupIndicatorProperty);
		}
		set
		{
			SetValue(PopupIndicatorProperty, value);
		}
	}

	public DataTemplate PopupIndicatorTemplate
	{
		get
		{
			return (DataTemplate)GetValue(PopupIndicatorTemplateProperty);
		}
		set
		{
			SetValue(PopupIndicatorTemplateProperty, value);
		}
	}

	[Localizability(LocalizationCategory.ToolTip)]
	public object PopupIndicatorToolTip
	{
		get
		{
			return GetValue(PopupIndicatorToolTipProperty);
		}
		set
		{
			SetValue(PopupIndicatorToolTipProperty, value);
		}
	}

	public ContextMenu PopupMenu
	{
		get
		{
			return (ContextMenu)GetValue(PopupMenuProperty);
		}
		set
		{
			SetValue(PopupMenuProperty, value);
		}
	}

	public object PopupMenuDataContext
	{
		get
		{
			return GetValue(PopupMenuDataContextProperty);
		}
		set
		{
			SetValue(PopupMenuDataContextProperty, value);
		}
	}

	public Thickness PopupPadding
	{
		get
		{
			return (Thickness)GetValue(PopupPaddingProperty);
		}
		set
		{
			SetValue(PopupPaddingProperty, value);
		}
	}

	public double PopupVerticalOffset
	{
		get
		{
			return (double)GetValue(PopupVerticalOffsetProperty);
		}
		set
		{
			SetValue(PopupVerticalOffsetProperty, value);
		}
	}

	public bool StaysOpen
	{
		get
		{
			return (bool)GetValue(StaysOpenProperty);
		}
		set
		{
			SetValue(StaysOpenProperty, value);
		}
	}

	[Description("Occurs when the IsPopupOpen property changes to false.")]
	public event RoutedEventHandler PopupClosed
	{
		add
		{
			AddHandler(PopupClosedEvent, value);
		}
		remove
		{
			RemoveHandler(PopupClosedEvent, value);
		}
	}

	[Description("Occurs when the IsPopupOpen property changes to true.")]
	public event RoutedEventHandler PopupOpened
	{
		add
		{
			AddHandler(PopupOpenedEvent, value);
		}
		remove
		{
			RemoveHandler(PopupOpenedEvent, value);
		}
	}

	[Description("Occurs before the IsPopupOpen property changes to true.")]
	public event EventHandler<CancelRoutedEventArgs> PopupOpening
	{
		add
		{
			AddHandler(PopupOpeningEvent, value);
		}
		remove
		{
			RemoveHandler(PopupOpeningEvent, value);
		}
	}

	[SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline")]
	static PopupButton()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		PopupClosedEvent = EventManager.RegisterRoutedEvent(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(114758), RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(PopupButton));
		int num = 0;
		if (false)
		{
			goto IL_0005;
		}
		goto IL_0009;
		IL_0005:
		int num2;
		num = num2;
		goto IL_0009;
		IL_0009:
		do
		{
			IL_0009_2:
			switch (num)
			{
			default:
				PopupOpenedEvent = EventManager.RegisterRoutedEvent(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(114784), RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(PopupButton));
				PopupOpeningEvent = EventManager.RegisterRoutedEvent(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(114810), RoutingStrategy.Bubble, typeof(EventHandler<CancelRoutedEventArgs>), typeof(PopupButton));
				DisplayModeProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(114838), typeof(PopupButtonDisplayMode), typeof(PopupButton), new FrameworkPropertyMetadata(PopupButtonDisplayMode.Merged, EAo));
				HasDropShadowProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(114864), typeof(bool), typeof(PopupButton), new FrameworkPropertyMetadata(true));
				IsAutoFocusOnOpenEnabledProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(114894), typeof(bool), typeof(PopupButton), new FrameworkPropertyMetadata(true));
				IsPopupOpenProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(114946), typeof(bool), typeof(PopupButton), new FrameworkPropertyMetadata(false, hAO, qA7));
				IsTransparencyModeEnabledProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(97770), typeof(bool), typeof(PopupButton), new FrameworkPropertyMetadata(false));
				PopupAllowsTransparencyProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(114972), typeof(bool), typeof(PopupButton), new FrameworkPropertyMetadata(true));
				num = 2;
				if (true)
				{
					num = 2;
				}
				goto IL_0009_2;
			case 1:
				PopupHorizontalOffsetProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(115268), typeof(double), typeof(PopupButton), new FrameworkPropertyMetadata(0.0));
				PopupIndicatorProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(115314), typeof(object), typeof(PopupButton), new FrameworkPropertyMetadata(null, null));
				PopupIndicatorTemplateProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(115346), typeof(DataTemplate), typeof(PopupButton), new FrameworkPropertyMetadata(null));
				PopupIndicatorToolTipProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(115394), typeof(object), typeof(PopupButton), new FrameworkPropertyMetadata(null));
				PopupMenuProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(115440), typeof(ContextMenu), typeof(PopupButton), new FrameworkPropertyMetadata(null, aAk));
				PopupMenuDataContextProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(115462), typeof(object), typeof(PopupButton), new FrameworkPropertyMetadata(null));
				PopupPaddingProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(115506), typeof(Thickness), typeof(PopupButton), new FrameworkPropertyMetadata(new Thickness(0.0)));
				PopupVerticalOffsetProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(115534), typeof(double), typeof(PopupButton), new FrameworkPropertyMetadata(0.0));
				StaysOpenProperty = Popup.StaysOpenProperty.AddOwner(typeof(PopupButton), new FrameworkPropertyMetadata(false));
				FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(PopupButton), new FrameworkPropertyMetadata(typeof(PopupButton)));
				UIElement.SnapsToDevicePixelsProperty.OverrideMetadata(typeof(PopupButton), new FrameworkPropertyMetadata(true));
				ClosePopupCommand = new RoutedCommand(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(115576), typeof(PopupButton));
				CommandManager.RegisterClassCommandBinding(typeof(UIElement), new CommandBinding(ClosePopupCommand, fAF));
				return;
			case 2:
				break;
			}
			PopupAnimationProperty = Popup.PopupAnimationProperty.AddOwner(typeof(PopupButton));
			PopupBackgroundProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(115022), typeof(Brush), typeof(PopupButton), new FrameworkPropertyMetadata(null));
			PopupBorderBrushProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(115056), typeof(Brush), typeof(PopupButton), new FrameworkPropertyMetadata(null));
			PopupBorderThicknessProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(115092), typeof(Thickness), typeof(PopupButton), new FrameworkPropertyMetadata(new Thickness(1.0)));
			PopupContentProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(115136), typeof(object), typeof(PopupButton), new FrameworkPropertyMetadata(null, jA0));
			PopupContentTemplateProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(115164), typeof(DataTemplate), typeof(PopupButton), new FrameworkPropertyMetadata(null));
			PopupContentTemplateSelectorProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(115208), typeof(DataTemplateSelector), typeof(PopupButton), new FrameworkPropertyMetadata(null));
			PopupCornerRadiusProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(105068), typeof(CornerRadius), typeof(PopupButton), new FrameworkPropertyMetadata(new CornerRadius(0.0)));
			num = 1;
		}
		while (0 == 0);
		goto IL_0005;
	}

	private static object qA7(DependencyObject P_0, object P_1)
	{
		PopupButton popupButton = (PopupButton)P_0;
		if (!true.Equals(P_1) || !popupButton.bAC())
		{
			return P_1;
		}
		int num = 0;
		if (yG5() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		return num switch
		{
			_ => false, 
		};
	}

	[SpecialName]
	private UIElement vAx()
	{
		return WAV;
	}

	[SpecialName]
	private void mAr(UIElement value)
	{
		if (WAV == value)
		{
			return;
		}
		if (WAV != null)
		{
			WAV.MouseDown -= kAQ;
		}
		WAV = value;
		if (WAV != null)
		{
			WAV.MouseDown += kAQ;
			int num = 0;
			if (yG5() != null)
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

	[SpecialName]
	private pR MAn()
	{
		if (PopupMenu != null)
		{
			return (pR)2;
		}
		if (PopupContent != null || PopupContentTemplate != null || PopupContentTemplateSelector != null)
		{
			return (pR)1;
		}
		if (DisplayMode != PopupButtonDisplayMode.ButtonOnly)
		{
			return (pR)2;
		}
		return (pR)0;
	}

	private static void fAF(object P_0, ExecutedRoutedEventArgs P_1)
	{
		Popup ancestorPopup = VisualTreeHelperExtended.GetAncestorPopup(P_0 as DependencyObject);
		if (ancestorPopup != null)
		{
			ancestorPopup.IsOpen = false;
		}
	}

	private static void EAo(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		PopupButton element = (PopupButton)P_0;
		if (UIElementAutomationPeer.FromElement(element) is PopupButtonAutomationPeer popupButtonAutomationPeer)
		{
			popupButtonAutomationPeer.InvalidatePeer();
		}
	}

	private void kAQ(object P_0, MouseButtonEventArgs P_1)
	{
		if (MAn() != 0)
		{
			if (!base.IsFocused)
			{
				Focus();
			}
			if (!EA6)
			{
				IsPopupOpen = !IsPopupOpen;
			}
			else
			{
				EA6 = false;
			}
			P_1.Handled = true;
		}
	}

	private static void hAO(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		_003C_003Ec__DisplayClass54_0 CS_0024_003C_003E8__locals17 = new _003C_003Ec__DisplayClass54_0();
		CS_0024_003C_003E8__locals17.kHo = (PopupButton)P_0;
		bool flag = CS_0024_003C_003E8__locals17.kHo.PopupMenu != null;
		if (CS_0024_003C_003E8__locals17.kHo.IsPopupOpen)
		{
			if (!flag)
			{
				PopupManager.OpenPopup(CS_0024_003C_003E8__locals17.kHo);
			}
			CS_0024_003C_003E8__locals17.kHo.XAA();
			if (!flag && CS_0024_003C_003E8__locals17.kHo.IsAutoFocusOnOpenEnabled && CS_0024_003C_003E8__locals17.kHo.QAq() != null)
			{
				CS_0024_003C_003E8__locals17.kHo.Dispatcher.BeginInvoke(DispatcherPriority.Loaded, (Action)delegate
				{
					VisualTreeHelperExtended.GetFirstFocusableDescendant(CS_0024_003C_003E8__locals17.kHo.QAq().Child)?.Focus();
				});
			}
		}
		else
		{
			if (flag && Mouse.LeftButton == MouseButtonState.Pressed && CS_0024_003C_003E8__locals17.kHo.vAx() != null && Mouse.PrimaryDevice != null && Mouse.Captured == CS_0024_003C_003E8__locals17.kHo.PopupMenu && new Rect(new Point(0.0, 0.0), CS_0024_003C_003E8__locals17.kHo.vAx().RenderSize).Contains(Mouse.PrimaryDevice.GetPosition(CS_0024_003C_003E8__locals17.kHo.vAx())))
			{
				CS_0024_003C_003E8__locals17.kHo.EA6 = true;
			}
			if (!flag)
			{
				PopupManager.ClosePopup(CS_0024_003C_003E8__locals17.kHo);
			}
			CS_0024_003C_003E8__locals17.kHo.rAl();
		}
		if (UIElementAutomationPeer.FromElement(CS_0024_003C_003E8__locals17.kHo) is PopupButtonAutomationPeer popupButtonAutomationPeer)
		{
			popupButtonAutomationPeer.RaiseExpandCollapseAutomationEvent((bool)P_1.OldValue, (bool)P_1.NewValue);
		}
	}

	private static void jA0(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		PopupButton popupButton = (PopupButton)P_0;
		popupButton.RemoveLogicalChild(P_1.OldValue);
		popupButton.AddLogicalChild(P_1.NewValue);
	}

	private static void aAk(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		PopupButton popupButton = (PopupButton)P_0;
		if (popupButton.IsPopupOpen)
		{
			popupButton.IsPopupOpen = false;
		}
		ContextMenu contextMenu = P_1.OldValue as ContextMenu;
		bool flag = default(bool);
		int num;
		if (contextMenu != null)
		{
			if (BindingOperations.IsDataBound(contextMenu, ContextMenu.HasDropShadowProperty))
			{
				BindingOperations.ClearBinding(contextMenu, ContextMenu.HasDropShadowProperty);
			}
			flag = BindingOperations.IsDataBound(contextMenu, ContextMenu.HorizontalOffsetProperty);
			num = 0;
			if (yG5() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			goto IL_0009;
		}
		goto IL_0265;
		IL_0009:
		bool flag2 = default(bool);
		ContextMenu contextMenu2 = default(ContextMenu);
		while (true)
		{
			switch (num)
			{
			case 2:
				BindingOperations.ClearBinding(contextMenu, ContextMenu.HorizontalOffsetProperty);
				break;
			case 1:
				if (flag2)
				{
					contextMenu2.SetBinding(FrameworkElement.DataContextProperty, new Binding(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(115462))
					{
						Source = popupButton
					});
				}
				return;
			default:
				if (flag)
				{
					num = 2;
					continue;
				}
				break;
			case 3:
				flag2 = contextMenu2.DataContext == null && !BindingOperations.IsDataBound(contextMenu2, FrameworkElement.DataContextProperty);
				num = 1;
				if (!HGo())
				{
					num = 0;
				}
				continue;
			}
			break;
		}
		if (BindingOperations.IsDataBound(contextMenu, ContextMenu.IsOpenProperty))
		{
			BindingOperations.ClearBinding(contextMenu, ContextMenu.IsOpenProperty);
		}
		if (BindingOperations.IsDataBound(contextMenu, ContextMenu.VerticalOffsetProperty))
		{
			BindingOperations.ClearBinding(contextMenu, ContextMenu.VerticalOffsetProperty);
		}
		if (BindingOperations.IsDataBound(contextMenu, FrameworkElement.DataContextProperty))
		{
			BindingOperations.ClearBinding(contextMenu, FrameworkElement.DataContextProperty);
		}
		goto IL_0265;
		IL_0265:
		contextMenu2 = P_1.NewValue as ContextMenu;
		if (contextMenu2 != null)
		{
			popupButton.AAY();
			contextMenu2.Placement = PlacementMode.Bottom;
			contextMenu2.SetBinding(ContextMenu.HasDropShadowProperty, new Binding(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(114864))
			{
				Source = popupButton
			});
			contextMenu2.SetBinding(ContextMenu.HorizontalOffsetProperty, new Binding(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(115268))
			{
				Source = popupButton
			});
			contextMenu2.SetBinding(ContextMenu.IsOpenProperty, new Binding(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(114946))
			{
				Source = popupButton
			});
			contextMenu2.SetBinding(ContextMenu.VerticalOffsetProperty, new Binding(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(115534))
			{
				Source = popupButton
			});
			num = 3;
			goto IL_0009;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	private Popup QAq()
	{
		return mA5;
	}

	[SpecialName]
	[CompilerGenerated]
	private void nAW(Popup value)
	{
		mA5 = value;
	}

	private void rAl()
	{
		RoutedEventArgs e = new RoutedEventArgs(PopupClosedEvent, this);
		OnPopupClosed(e);
		RaiseEvent(e);
	}

	private void XAA()
	{
		RoutedEventArgs e = new RoutedEventArgs(PopupOpenedEvent, this);
		OnPopupOpened(e);
		RaiseEvent(e);
	}

	private bool bAC()
	{
		CancelRoutedEventArgs e = new CancelRoutedEventArgs(PopupOpeningEvent, this);
		OnPopupOpening(e);
		RaiseEvent(e);
		return e.Cancel;
	}

	private void AAY()
	{
		ContextMenu popupMenu = PopupMenu;
		if (popupMenu == null)
		{
			return;
		}
		UIElement placementTarget = popupMenu.PlacementTarget;
		if (placementTarget == null || placementTarget == this || placementTarget == WAV)
		{
			popupMenu.PlacementTarget = this;
			int num = 0;
			if (!HGo())
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

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		mAr(GetTemplateChild(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(115600)) as UIElement);
		nAW(GetTemplateChild(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(115640)) as Popup);
		AAY();
	}

	protected override void OnClick()
	{
		if (MAn() != 0)
		{
			PopupButtonDisplayMode displayMode = DisplayMode;
			PopupButtonDisplayMode popupButtonDisplayMode = displayMode;
			if ((uint)popupButtonDisplayMode <= 1u || (uint)(popupButtonDisplayMode - 3) <= 1u)
			{
				IsPopupOpen = !IsPopupOpen;
				return;
			}
		}
		base.OnClick();
		int num = 0;
		if (!HGo())
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

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		return new PopupButtonAutomationPeer(this);
	}

	protected override void OnKeyDown(KeyEventArgs e)
	{
		PopupManager.ProcessKeyDown(this, e);
		base.OnKeyDown(e);
	}

	protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
	{
		if (e == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(107336));
		}
		if (IsPopupOpen && DisplayMode == PopupButtonDisplayMode.Split && e.OriginalSource is Visual descendant && IsAncestorOf(descendant))
		{
			IsPopupOpen = false;
		}
		base.OnMouseLeftButtonDown(e);
	}

	protected override void OnMouseLeftButtonUp(MouseButtonEventArgs e)
	{
		if (MAn() == (pR)0 || !IsPopupOpen)
		{
			base.OnMouseLeftButtonUp(e);
		}
	}

	protected override void OnMouseWheel(MouseWheelEventArgs e)
	{
		base.OnMouseWheel(e);
		if (e != null && !e.Handled && IsPopupOpen)
		{
			e.Handled = true;
		}
	}

	protected virtual void OnPopupClosed(RoutedEventArgs e)
	{
	}

	protected virtual void OnPopupOpened(RoutedEventArgs e)
	{
	}

	protected virtual void OnPopupOpening(CancelRoutedEventArgs e)
	{
	}

	public PopupButton()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	[CompilerGenerated]
	[DebuggerHidden]
	private IEnumerator dAI()
	{
		return base.LogicalChildren;
	}

	internal static bool HGo()
	{
		return MGu == null;
	}

	internal static PopupButton yG5()
	{
		return MGu;
	}
}
