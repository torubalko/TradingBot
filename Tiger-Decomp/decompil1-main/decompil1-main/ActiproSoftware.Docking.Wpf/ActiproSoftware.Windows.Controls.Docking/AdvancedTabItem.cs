using System;
using System.Collections;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.Docking.Automation.Peers;
using ActiproSoftware.Windows.Extensions;
using ActiproSoftware.Windows.Input;

namespace ActiproSoftware.Windows.Controls.Docking;

[TemplateVisualState(Name = "PointerOver", GroupName = "HighlightStates")]
[TemplateVisualState(Name = "ActiveSelected", GroupName = "HighlightStates")]
[TemplateVisualState(Name = "InactiveSelected", GroupName = "HighlightStates")]
[TemplateVisualState(Name = "PreviewPointerOver", GroupName = "HighlightStates")]
[ToolboxItem(false)]
[TemplateVisualState(Name = "None", GroupName = "HighlightStates")]
[TemplateVisualState(Name = "Preview", GroupName = "HighlightStates")]
[TemplateVisualState(Name = "PinnedLayout", GroupName = "LayoutKindStates")]
[TemplateVisualState(Name = "PreviewLayout", GroupName = "LayoutKindStates")]
[TemplateVisualState(Name = "Editable", GroupName = "ReadOnlyStates")]
[TemplateVisualState(Name = "PreviewActiveSelected", GroupName = "HighlightStates")]
[TemplateVisualState(Name = "ReadOnly", GroupName = "ReadOnlyStates")]
[TemplateVisualState(Name = "NormalLayout", GroupName = "LayoutKindStates")]
public class AdvancedTabItem : TabItem
{
	private InputAdapter J2i;

	private DelegateCommand<object> s2d;

	private bool z2w;

	private DelegateCommand<object> l22;

	public static readonly DependencyProperty ArrangeHeightAnimatedProperty;

	public static readonly DependencyProperty ArrangeWidthAnimatedProperty;

	public static readonly DependencyProperty ArrangeXAnimatedProperty;

	public static readonly DependencyProperty ArrangeYAnimatedProperty;

	public static readonly DependencyProperty AreEmbeddedButtonsAlwaysVisibleProperty;

	public static readonly DependencyProperty BackgroundActiveSelectedProperty;

	public static readonly DependencyProperty BackgroundInactiveSelectedProperty;

	public static readonly DependencyProperty BackgroundPointerOverProperty;

	public static readonly DependencyProperty BackgroundPreviewProperty;

	public static readonly DependencyProperty BackgroundPreviewActiveSelectedProperty;

	public static readonly DependencyProperty BackgroundPreviewPointerOverProperty;

	public static readonly DependencyProperty BorderBrushActiveSelectedProperty;

	public static readonly DependencyProperty BorderBrushInactiveSelectedProperty;

	public static readonly DependencyProperty BorderBrushPointerOverProperty;

	public static readonly DependencyProperty BorderBrushPreviewProperty;

	public static readonly DependencyProperty BorderBrushPreviewActiveSelectedProperty;

	public static readonly DependencyProperty BorderBrushPreviewPointerOverProperty;

	public static readonly DependencyProperty CanCloseProperty;

	public static readonly DependencyProperty CanHighlightOnPointerOverWhenInactiveProperty;

	public static readonly DependencyProperty CanPinProperty;

	public static readonly DependencyProperty CanPromoteProperty;

	public static readonly DependencyProperty CloseButtonContentTemplateProperty;

	public static readonly DependencyProperty ContextContentProperty;

	public static readonly DependencyProperty ContextContentTemplateProperty;

	public static readonly DependencyProperty CornerRadiusProperty;

	internal static readonly DependencyProperty K2e;

	public static readonly DependencyProperty EmbeddedButtonStyleProperty;

	public static readonly DependencyProperty FlashColorProperty;

	public static readonly DependencyProperty FlashModeProperty;

	public static readonly DependencyProperty ForegroundActiveSelectedProperty;

	public static readonly DependencyProperty ForegroundInactiveSelectedProperty;

	public static readonly DependencyProperty ForegroundPointerOverProperty;

	public static readonly DependencyProperty ForegroundPreviewProperty;

	public static readonly DependencyProperty ForegroundPreviewActiveSelectedProperty;

	public static readonly DependencyProperty ForegroundPreviewPointerOverProperty;

	public static readonly DependencyProperty HasCloseButtonProperty;

	public static readonly DependencyProperty HasToggleLayoutKindButtonProperty;

	public static readonly DependencyProperty HighlightKindProperty;

	public static readonly DependencyProperty ImageSourceProperty;

	public static readonly DependencyProperty IsCloseButtonVisibleProperty;

	public static readonly DependencyProperty IsContentHorizontalProperty;

	public static readonly DependencyProperty IsImageVisibleProperty;

	public static readonly DependencyProperty IsLoadAnimationEnabledProperty;

	public static readonly DependencyProperty IsReadOnlyProperty;

	public static readonly DependencyProperty IsToggleLayoutKindButtonVisibleProperty;

	public static readonly DependencyProperty LayoutKindProperty;

	public static readonly DependencyProperty PinButtonContentTemplateProperty;

	public static readonly DependencyProperty PromoteButtonContentTemplateProperty;

	public static readonly DependencyProperty ReadOnlyContextContentTemplateProperty;

	public static readonly DependencyProperty TintColorProperty;

	public static readonly DependencyProperty UnpinButtonContentTemplateProperty;

	[CompilerGenerated]
	private bool y2G;

	private DateTime n2I;

	public static readonly DependencyProperty FarSlantExtentProperty;

	public static readonly DependencyProperty NearSlantExtentProperty;

	internal static AdvancedTabItem rB;

	internal int DragSortOrder
	{
		get
		{
			return (int)GetValue(K2e);
		}
		set
		{
			SetValue(K2e, value);
		}
	}

	public double ArrangeHeightAnimated
	{
		get
		{
			return (double)GetValue(ArrangeHeightAnimatedProperty);
		}
		set
		{
			SetValue(ArrangeHeightAnimatedProperty, value);
		}
	}

	public double ArrangeWidthAnimated
	{
		get
		{
			return (double)GetValue(ArrangeWidthAnimatedProperty);
		}
		set
		{
			SetValue(ArrangeWidthAnimatedProperty, value);
		}
	}

	public double ArrangeXAnimated
	{
		get
		{
			return (double)GetValue(ArrangeXAnimatedProperty);
		}
		set
		{
			SetValue(ArrangeXAnimatedProperty, value);
		}
	}

	public double ArrangeYAnimated
	{
		get
		{
			return (double)GetValue(ArrangeYAnimatedProperty);
		}
		set
		{
			SetValue(ArrangeYAnimatedProperty, value);
		}
	}

	public bool AreEmbeddedButtonsAlwaysVisible
	{
		get
		{
			return (bool)GetValue(AreEmbeddedButtonsAlwaysVisibleProperty);
		}
		set
		{
			SetValue(AreEmbeddedButtonsAlwaysVisibleProperty, value);
		}
	}

	public Brush BackgroundActiveSelected
	{
		get
		{
			return (Brush)GetValue(BackgroundActiveSelectedProperty);
		}
		set
		{
			SetValue(BackgroundActiveSelectedProperty, value);
		}
	}

	public Brush BackgroundInactiveSelected
	{
		get
		{
			return (Brush)GetValue(BackgroundInactiveSelectedProperty);
		}
		set
		{
			SetValue(BackgroundInactiveSelectedProperty, value);
		}
	}

	public Brush BackgroundPointerOver
	{
		get
		{
			return (Brush)GetValue(BackgroundPointerOverProperty);
		}
		set
		{
			SetValue(BackgroundPointerOverProperty, value);
		}
	}

	public Brush BackgroundPreview
	{
		get
		{
			return (Brush)GetValue(BackgroundPreviewProperty);
		}
		set
		{
			SetValue(BackgroundPreviewProperty, value);
		}
	}

	public Brush BackgroundPreviewActiveSelected
	{
		get
		{
			return (Brush)GetValue(BackgroundPreviewActiveSelectedProperty);
		}
		set
		{
			SetValue(BackgroundPreviewActiveSelectedProperty, value);
		}
	}

	public Brush BackgroundPreviewPointerOver
	{
		get
		{
			return (Brush)GetValue(BackgroundPreviewPointerOverProperty);
		}
		set
		{
			SetValue(BackgroundPreviewPointerOverProperty, value);
		}
	}

	public Brush BorderBrushActiveSelected
	{
		get
		{
			return (Brush)GetValue(BorderBrushActiveSelectedProperty);
		}
		set
		{
			SetValue(BorderBrushActiveSelectedProperty, value);
		}
	}

	public Brush BorderBrushInactiveSelected
	{
		get
		{
			return (Brush)GetValue(BorderBrushInactiveSelectedProperty);
		}
		set
		{
			SetValue(BorderBrushInactiveSelectedProperty, value);
		}
	}

	public Brush BorderBrushPointerOver
	{
		get
		{
			return (Brush)GetValue(BorderBrushPointerOverProperty);
		}
		set
		{
			SetValue(BorderBrushPointerOverProperty, value);
		}
	}

	public Brush BorderBrushPreview
	{
		get
		{
			return (Brush)GetValue(BorderBrushPreviewProperty);
		}
		set
		{
			SetValue(BorderBrushPreviewProperty, value);
		}
	}

	public Brush BorderBrushPreviewActiveSelected
	{
		get
		{
			return (Brush)GetValue(BorderBrushPreviewActiveSelectedProperty);
		}
		set
		{
			SetValue(BorderBrushPreviewActiveSelectedProperty, value);
		}
	}

	public Brush BorderBrushPreviewPointerOver
	{
		get
		{
			return (Brush)GetValue(BorderBrushPreviewPointerOverProperty);
		}
		set
		{
			SetValue(BorderBrushPreviewPointerOverProperty, value);
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

	public bool CanHighlightOnPointerOverWhenInactive
	{
		get
		{
			return (bool)GetValue(CanHighlightOnPointerOverWhenInactiveProperty);
		}
		set
		{
			SetValue(CanHighlightOnPointerOverWhenInactiveProperty, value);
		}
	}

	public bool CanPin
	{
		get
		{
			return (bool)GetValue(CanPinProperty);
		}
		set
		{
			SetValue(CanPinProperty, value);
		}
	}

	public bool CanPromote
	{
		get
		{
			return (bool)GetValue(CanPromoteProperty);
		}
		set
		{
			SetValue(CanPromoteProperty, value);
		}
	}

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

	public ICommand CloseCommand => s2d;

	public object ContextContent
	{
		get
		{
			return GetValue(ContextContentProperty);
		}
		internal set
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

	public Color FlashColor
	{
		get
		{
			return (Color)GetValue(FlashColorProperty);
		}
		set
		{
			SetValue(FlashColorProperty, value);
		}
	}

	public TabFlashMode FlashMode
	{
		get
		{
			return (TabFlashMode)GetValue(FlashModeProperty);
		}
		set
		{
			SetValue(FlashModeProperty, value);
		}
	}

	public Brush ForegroundActiveSelected
	{
		get
		{
			return (Brush)GetValue(ForegroundActiveSelectedProperty);
		}
		set
		{
			SetValue(ForegroundActiveSelectedProperty, value);
		}
	}

	public Brush ForegroundInactiveSelected
	{
		get
		{
			return (Brush)GetValue(ForegroundInactiveSelectedProperty);
		}
		set
		{
			SetValue(ForegroundInactiveSelectedProperty, value);
		}
	}

	public Brush ForegroundPointerOver
	{
		get
		{
			return (Brush)GetValue(ForegroundPointerOverProperty);
		}
		set
		{
			SetValue(ForegroundPointerOverProperty, value);
		}
	}

	public Brush ForegroundPreview
	{
		get
		{
			return (Brush)GetValue(ForegroundPreviewProperty);
		}
		set
		{
			SetValue(ForegroundPreviewProperty, value);
		}
	}

	public Brush ForegroundPreviewActiveSelected
	{
		get
		{
			return (Brush)GetValue(ForegroundPreviewActiveSelectedProperty);
		}
		set
		{
			SetValue(ForegroundPreviewActiveSelectedProperty, value);
		}
	}

	public Brush ForegroundPreviewPointerOver
	{
		get
		{
			return (Brush)GetValue(ForegroundPreviewPointerOverProperty);
		}
		set
		{
			SetValue(ForegroundPreviewPointerOverProperty, value);
		}
	}

	public bool HasCloseButton
	{
		get
		{
			return (bool)GetValue(HasCloseButtonProperty);
		}
		private set
		{
			SetValue(HasCloseButtonProperty, value);
		}
	}

	public bool HasToggleLayoutKindButton
	{
		get
		{
			return (bool)GetValue(HasToggleLayoutKindButtonProperty);
		}
		private set
		{
			SetValue(HasToggleLayoutKindButtonProperty, value);
		}
	}

	public TabHighlightKind HighlightKind
	{
		get
		{
			return (TabHighlightKind)GetValue(HighlightKindProperty);
		}
		private set
		{
			SetValue(HighlightKindProperty, value);
		}
	}

	public ImageSource ImageSource
	{
		get
		{
			return (ImageSource)GetValue(ImageSourceProperty);
		}
		set
		{
			SetValue(ImageSourceProperty, value);
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

	public bool IsContentHorizontal
	{
		get
		{
			return (bool)GetValue(IsContentHorizontalProperty);
		}
		set
		{
			SetValue(IsContentHorizontalProperty, value);
		}
	}

	public bool IsImageVisible
	{
		get
		{
			return (bool)GetValue(IsImageVisibleProperty);
		}
		private set
		{
			SetValue(IsImageVisibleProperty, value);
		}
	}

	public bool IsLoadAnimationEnabled
	{
		get
		{
			return (bool)GetValue(IsLoadAnimationEnabledProperty);
		}
		set
		{
			SetValue(IsLoadAnimationEnabledProperty, value);
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

	public bool IsToggleLayoutKindButtonVisible
	{
		get
		{
			return (bool)GetValue(IsToggleLayoutKindButtonVisibleProperty);
		}
		private set
		{
			SetValue(IsToggleLayoutKindButtonVisibleProperty, value);
		}
	}

	public TabLayoutKind LayoutKind
	{
		get
		{
			return (TabLayoutKind)GetValue(LayoutKindProperty);
		}
		set
		{
			SetValue(LayoutKindProperty, value);
		}
	}

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

	public DataTemplate PromoteButtonContentTemplate
	{
		get
		{
			return (DataTemplate)GetValue(PromoteButtonContentTemplateProperty);
		}
		set
		{
			SetValue(PromoteButtonContentTemplateProperty, value);
		}
	}

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

	public Color TintColor
	{
		get
		{
			return (Color)GetValue(TintColorProperty);
		}
		set
		{
			SetValue(TintColorProperty, value);
		}
	}

	public ICommand ToggleLayoutKindCommand => l22;

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

	public double FarSlantExtent
	{
		get
		{
			return (double)GetValue(FarSlantExtentProperty);
		}
		set
		{
			SetValue(FarSlantExtentProperty, value);
		}
	}

	public double NearSlantExtent
	{
		get
		{
			return (double)GetValue(NearSlantExtentProperty);
		}
		set
		{
			SetValue(NearSlantExtentProperty, value);
		}
	}

	public AdvancedTabItem()
	{
		IVH.CecNqz();
		n2I = DateTime.Now;
		base._002Ector();
		base.DefaultStyleKey = typeof(AdvancedTabItem);
		awJ();
		GwO();
		base.Loaded += Pw3;
		base.AllowDrop = true;
	}

	private void awJ()
	{
		J2i = new InputAdapter(this);
		J2i.PointerEntered += ww6;
		J2i.PointerExited += Kw9;
		J2i.PointerMoved += qwY;
		J2i.PointerPressed += Wwp;
		J2i.AttachedEventKinds = InputAdapterEventKinds.PointerEntered | InputAdapterEventKinds.PointerExited | InputAdapterEventKinds.PointerMoved | InputAdapterEventKinds.PointerPressed;
	}

	private void Fwn()
	{
		Orientation orientation = qwH()?.zdc() ?? Orientation.Horizontal;
		base.Opacity = 0.5;
		base.RenderTransform = ((orientation == Orientation.Horizontal) ? new ScaleTransform
		{
			ScaleX = 0.5,
			ScaleY = 1.0
		} : new ScaleTransform
		{
			ScaleX = 1.0,
			ScaleY = 0.5
		});
		this.AnimateDoubleProperty(vVK.ssH(3302), 1.0);
		this.AnimateDoubleProperty(vVK.ssH(3948) + ((orientation == Orientation.Horizontal) ? vVK.ssH(4072) : vVK.ssH(4064)), 1.0);
	}

	private void GwO()
	{
		s2d = new DelegateCommand<object>(delegate
		{
			AdvancedTabControl advancedTabControl = qwH();
			if (advancedTabControl != null && !advancedTabControl.fdN(this))
			{
				Close();
			}
		});
		l22 = new DelegateCommand<object>(delegate
		{
			ToggleLayoutKind();
		});
	}

	internal Rect qwT()
	{
		return new Rect(ArrangeXAnimated, ArrangeYAnimated, ArrangeWidthAnimated, ArrangeHeightAnimated);
	}

	private void rw8()
	{
		if (VisualTreeHelper.GetParent(this) is FrameworkElement frameworkElement)
		{
			frameworkElement.InvalidateArrange();
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal bool owZ()
	{
		return y2G;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void Qwb(bool value)
	{
		y2G = value;
	}

	internal void WwD()
	{
		z2w = false;
	}

	private static void LwE(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		AdvancedTabItem advancedTabItem = (AdvancedTabItem)P_0;
		if (P_1.OldValue != P_1.NewValue)
		{
			advancedTabItem.rw8();
		}
	}

	private static void Awr(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		AdvancedTabItem obj = (AdvancedTabItem)P_0;
		obj.pws();
		obj.WwF();
	}

	private static void Vwx(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((AdvancedTabItem)P_0).pws();
	}

	private static void Kwl(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((AdvancedTabItem)P_0).WwF();
	}

	private static void BwM(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((AdvancedTabItem)P_0).WwF();
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		return new AdvancedTabItemWrapperAutomationPeer(this);
	}

	private static void Qwv(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((AdvancedTabItem)P_0).awq();
	}

	private static void cw7(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		AdvancedTabItem obj = (AdvancedTabItem)P_0;
		obj.pws();
		obj.WwF();
		obj.DwP(_0020: true);
	}

	private static void owR(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		AdvancedTabItem advancedTabItem = (AdvancedTabItem)P_0;
		advancedTabItem.Opacity = ((advancedTabItem.IsLoaded || !advancedTabItem.IsLoadAnimationEnabled) ? 1.0 : 0.5);
	}

	private static void XwS(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((AdvancedTabItem)P_0).DwP(_0020: true);
	}

	private static void lwL(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		AdvancedTabItem obj = (AdvancedTabItem)P_0;
		obj.AwV();
		obj.WwF();
		obj.qwH()?.UpdateHighlightBrushes();
		obj.rw8();
	}

	private void Pw3(object P_0, RoutedEventArgs P_1)
	{
		if (IsLoadAnimationEnabled)
		{
			AdvancedTabControl advancedTabControl = qwH();
			if (advancedTabControl == null || advancedTabControl.IsLayoutAnimationEnabled)
			{
				Fwn();
			}
			IsLoadAnimationEnabled = false;
		}
	}

	private void ww6(object P_0, InputPointerEventArgs P_1)
	{
		z2w = true;
		AwV();
	}

	private void Kw9(object P_0, InputPointerEventArgs P_1)
	{
		z2w = false;
		AwV();
	}

	private void qwY(object P_0, InputPointerEventArgs P_1)
	{
		z2w = true;
		AwV();
	}

	private void Wwp(object P_0, InputPointerButtonEventArgs P_1)
	{
		if (P_1 == null || !P_1.IsPositionOver(this))
		{
			return;
		}
		P_1.Handled = true;
		if (P_1.ButtonKind == InputPointerButtonKind.Middle && CanClose)
		{
			AdvancedTabControl advancedTabControl = qwH();
			if (advancedTabControl != null)
			{
				int num = 0;
				if (!B5())
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				if (advancedTabControl.CanTabsCloseOnMiddleClick)
				{
					if (!advancedTabControl.fdN(this))
					{
						Close();
					}
					return;
				}
			}
		}
		if (!base.IsSelected)
		{
			base.IsSelected = true;
		}
		AdvancedTabControl advancedTabControl2 = qwH();
		if (advancedTabControl2 != null)
		{
			DragMove(P_1);
			advancedTabControl2.sH();
		}
	}

	[SpecialName]
	internal AdvancedTabControl qwH()
	{
		return ItemsControl.ItemsControlFromItemContainer(this) as AdvancedTabControl;
	}

	[SpecialName]
	private Orientation Uwh()
	{
		Dock tabStripPlacement = base.TabStripPlacement;
		if (tabStripPlacement == Dock.Top || tabStripPlacement == Dock.Bottom)
		{
			return Orientation.Horizontal;
		}
		return Orientation.Vertical;
	}

	internal void pws()
	{
		AdvancedTabControl advancedTabControl = qwH();
		bool flag = CanClose && (advancedTabControl?.HasTabCloseButtons ?? false);
		HasCloseButton = flag;
		IsCloseButtonVisible = flag && (HighlightKind != TabHighlightKind.None || AreEmbeddedButtonsAlwaysVisible);
	}

	internal void awq()
	{
		AdvancedTabControl advancedTabControl = qwH();
		IsImageVisible = ImageSource != null && (advancedTabControl?.HasTabImages ?? false);
	}

	private void WwF()
	{
		bool flag = false;
		switch (LayoutKind)
		{
		case TabLayoutKind.Pinned:
			flag = true;
			break;
		default:
			flag = CanPin;
			break;
		case TabLayoutKind.Preview:
		{
			flag = CanPromote;
			int num = 0;
			if (uj() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			break;
		}
		}
		HasToggleLayoutKindButton = flag;
		IsToggleLayoutKindButtonVisible = flag && (HighlightKind != TabHighlightKind.None || LayoutKind == TabLayoutKind.Pinned || AreEmbeddedButtonsAlwaysVisible);
	}

	internal void AwV()
	{
		int num;
		if (base.IsSelected)
		{
			AdvancedTabControl advancedTabControl = qwH();
			if (advancedTabControl == null || advancedTabControl.IsActive)
			{
				if (LayoutKind == TabLayoutKind.Preview)
				{
					HighlightKind = TabHighlightKind.PreviewActiveSelected;
				}
				else
				{
					HighlightKind = TabHighlightKind.ActiveSelected;
				}
				return;
			}
			num = 1;
			if (!B5())
			{
				goto IL_0005;
			}
		}
		else
		{
			if (z2w)
			{
				if (LayoutKind == TabLayoutKind.Preview)
				{
					HighlightKind = TabHighlightKind.PreviewPointerOver;
				}
				else
				{
					HighlightKind = TabHighlightKind.PointerOver;
				}
				return;
			}
			if (LayoutKind != TabLayoutKind.Preview)
			{
				HighlightKind = TabHighlightKind.None;
				return;
			}
			HighlightKind = TabHighlightKind.Preview;
			num = 0;
			if (uj() != null)
			{
				goto IL_0005;
			}
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
			if (!z2w || !CanHighlightOnPointerOverWhenInactive)
			{
				HighlightKind = TabHighlightKind.InactiveSelected;
			}
			else if (LayoutKind == TabLayoutKind.Preview)
			{
				HighlightKind = TabHighlightKind.PreviewPointerOver;
			}
			else
			{
				HighlightKind = TabHighlightKind.PointerOver;
			}
			break;
		case 0:
			break;
		}
	}

	private void DwP(bool P_0)
	{
		int num = 2;
		TabHighlightKind highlightKind = default(TabHighlightKind);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					highlightKind = HighlightKind;
					num2 = 1;
					if (B5())
					{
						continue;
					}
					break;
				case 1:
					switch (highlightKind)
					{
					case TabHighlightKind.ActiveSelected:
						break;
					case TabHighlightKind.PreviewPointerOver:
						goto IL_00a1;
					case TabHighlightKind.Preview:
						goto IL_00dd;
					case TabHighlightKind.PointerOver:
						goto IL_012b;
					default:
						goto IL_0163;
					case TabHighlightKind.InactiveSelected:
						goto IL_0178;
					case TabHighlightKind.PreviewActiveSelected:
						goto IL_01b0;
					}
					VisualStateManager.GoToState(this, vVK.ssH(4080), P_0);
					goto case 3;
				default:
					VisualStateManager.GoToState(this, vVK.ssH(4278), P_0);
					goto case 3;
				case 3:
					{
						TabLayoutKind layoutKind = LayoutKind;
						if (layoutKind != TabLayoutKind.Pinned)
						{
							if (layoutKind == TabLayoutKind.Preview)
							{
								VisualStateManager.GoToState(this, vVK.ssH(4318), P_0);
							}
							else
							{
								VisualStateManager.GoToState(this, vVK.ssH(4348), P_0);
							}
						}
						else
						{
							VisualStateManager.GoToState(this, vVK.ssH(4290), P_0);
						}
						if (!IsReadOnly)
						{
							VisualStateManager.GoToState(this, vVK.ssH(4396), P_0);
						}
						else
						{
							VisualStateManager.GoToState(this, vVK.ssH(4376), P_0);
						}
						return;
					}
					IL_01b0:
					VisualStateManager.GoToState(this, vVK.ssH(4192), P_0);
					goto case 3;
					IL_0178:
					VisualStateManager.GoToState(this, vVK.ssH(4112), P_0);
					goto case 3;
					IL_0163:
					num2 = 0;
					if (uj() == null)
					{
						continue;
					}
					break;
					IL_012b:
					VisualStateManager.GoToState(this, vVK.ssH(4148), P_0);
					goto case 3;
					IL_00dd:
					VisualStateManager.GoToState(this, vVK.ssH(4174), P_0);
					goto case 3;
					IL_00a1:
					VisualStateManager.GoToState(this, vVK.ssH(4238), P_0);
					num2 = 3;
					if (!B5())
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
		}
	}

	public void Close()
	{
		AdvancedTabControl advancedTabControl = qwH();
		if (advancedTabControl == null)
		{
			return;
		}
		object obj = advancedTabControl.ItemContainerGenerator.ItemFromContainer(this);
		int num = 0;
		if (uj() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (obj == null)
		{
			return;
		}
		if (advancedTabControl.ItemsSource != null)
		{
			if (advancedTabControl.ItemsSource is IList list)
			{
				int num3 = list.IndexOf(obj);
				if (num3 != -1)
				{
					list.RemoveAt(num3);
				}
			}
		}
		else if (advancedTabControl.Items.Count > 0)
		{
			int num4 = advancedTabControl.Items.IndexOf(obj);
			if (num4 != -1)
			{
				advancedTabControl.Items.RemoveAt(num4);
			}
		}
	}

	public void DragMove(InputPointerButtonEventArgs sourceEventArgs)
	{
		if (sourceEventArgs == null)
		{
			throw new ArgumentNullException(vVK.ssH(4416));
		}
		if (qwH() != null && sourceEventArgs.IsPrimaryButton)
		{
			AdvancedTabControl.F5(this, sourceEventArgs);
		}
	}

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		DwP(_0020: false);
		AwV();
		pws();
		WwF();
	}

	public void ToggleLayoutKind()
	{
		if (LayoutKind == TabLayoutKind.Normal)
		{
			LayoutKind = TabLayoutKind.Pinned;
		}
		else
		{
			LayoutKind = TabLayoutKind.Normal;
		}
	}

	internal void ywf()
	{
		AwV();
	}

	protected override void OnContextMenuOpening(ContextMenuEventArgs e)
	{
		base.OnContextMenuOpening(e);
		if (e == null || e.Handled || !ContextMenuService.GetIsEnabled(this))
		{
			return;
		}
		AdvancedTabControl advancedTabControl = qwH();
		if (advancedTabControl == null || !base.IsVisible)
		{
			return;
		}
		Point? point = ((e.CursorLeft != -1.0) ? new Point?(new Point(e.CursorLeft, e.CursorTop)) : ((Point?)null));
		if (point.HasValue)
		{
			Visual visual = e.OriginalSource as Visual;
			if (visual == null && e.OriginalSource is FrameworkContentElement frameworkContentElement)
			{
				visual = frameworkContentElement.Parent as Visual;
			}
			if (visual == null || !advancedTabControl.IsAncestorOf(visual))
			{
				return;
			}
			point = visual.TransformToVisual(this).Transform(point.Value);
			if (!new Rect(new Point(0.0, 0.0), base.RenderSize).Contains(point.Value))
			{
				return;
			}
		}
		e.Handled = true;
		advancedTabControl.iX(this, point);
	}

	protected override void OnDragEnter(DragEventArgs e)
	{
		base.OnDragEnter(e);
		n2I = DateTime.Now;
		if (e != null)
		{
			e.Effects = DragDropEffects.None;
			e.Handled = true;
		}
	}

	protected override void OnDragOver(DragEventArgs e)
	{
		base.OnDragOver(e);
		if (e == null)
		{
			return;
		}
		if (!e.Handled && !base.IsSelected && DateTime.Now.Subtract(n2I).TotalMilliseconds >= 500.0)
		{
			AdvancedTabControl advancedTabControl = qwH();
			int num = 0;
			if (!B5())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			if (advancedTabControl != null && advancedTabControl.CanTabsSelectOnDragOver)
			{
				base.IsSelected = true;
			}
		}
		e.Effects = DragDropEffects.None;
		e.Handled = true;
	}

	protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
	{
		if (qwH() == null || qwH().UseDefaultFocusHandling)
		{
			base.OnMouseLeftButtonDown(e);
		}
		if (e != null && e.Handled && base.IsSelected)
		{
			e.Handled = false;
		}
	}

	protected override void OnPreviewGotKeyboardFocus(KeyboardFocusChangedEventArgs e)
	{
		if (e != null && !e.Handled && e.NewFocus == this && !base.IsSelected && qwH() != null && !qwH().UseDefaultFocusHandling)
		{
			base.IsSelected = true;
			int num = 0;
			if (!B5())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			e.Handled = true;
		}
		base.OnPreviewGotKeyboardFocus(e);
	}

	protected override void OnSelected(RoutedEventArgs e)
	{
		base.OnSelected(e);
		AwV();
	}

	protected override void OnUnselected(RoutedEventArgs e)
	{
		base.OnUnselected(e);
		AwV();
	}

	static AdvancedTabItem()
	{
		IVH.CecNqz();
		ArrangeHeightAnimatedProperty = DependencyProperty.Register(vVK.ssH(4450), typeof(double), typeof(AdvancedTabItem), new PropertyMetadata(0.0, LwE));
		ArrangeWidthAnimatedProperty = DependencyProperty.Register(vVK.ssH(4496), typeof(double), typeof(AdvancedTabItem), new PropertyMetadata(0.0, LwE));
		ArrangeXAnimatedProperty = DependencyProperty.Register(vVK.ssH(4540), typeof(double), typeof(AdvancedTabItem), new PropertyMetadata(0.0, LwE));
		int num = 4;
		while (true)
		{
			int num2 = num;
			do
			{
				IL_0009:
				switch (num2)
				{
				case 2:
					BorderBrushPreviewPointerOverProperty = DependencyProperty.Register(vVK.ssH(5264), typeof(Brush), typeof(AdvancedTabItem), new PropertyMetadata(null));
					CanCloseProperty = DependencyProperty.Register(vVK.ssH(5326), typeof(bool), typeof(AdvancedTabItem), new PropertyMetadata(false, Vwx));
					CanHighlightOnPointerOverWhenInactiveProperty = DependencyProperty.Register(vVK.ssH(5346), typeof(bool), typeof(AdvancedTabItem), new PropertyMetadata(false));
					CanPinProperty = DependencyProperty.Register(vVK.ssH(5424), typeof(bool), typeof(AdvancedTabItem), new PropertyMetadata(false, Kwl));
					CanPromoteProperty = DependencyProperty.Register(vVK.ssH(5440), typeof(bool), typeof(AdvancedTabItem), new PropertyMetadata(true, BwM));
					CloseButtonContentTemplateProperty = DependencyProperty.Register(vVK.ssH(5464), typeof(DataTemplate), typeof(AdvancedTabItem), new PropertyMetadata(null));
					ContextContentProperty = DependencyProperty.Register(vVK.ssH(5520), typeof(object), typeof(AdvancedTabItem), new PropertyMetadata(null));
					ContextContentTemplateProperty = DependencyProperty.Register(vVK.ssH(5552), typeof(DataTemplate), typeof(AdvancedTabItem), new PropertyMetadata(new DataTemplate()));
					CornerRadiusProperty = DependencyProperty.Register(vVK.ssH(5600), typeof(CornerRadius), typeof(AdvancedTabItem), new PropertyMetadata(default(CornerRadius)));
					num2 = 3;
					if (1 == 0)
					{
						num2 = 3;
					}
					goto IL_0009;
				case 4:
					break;
				default:
					FlashColorProperty = DependencyProperty.Register(vVK.ssH(5658), typeof(Color), typeof(AdvancedTabItem), new PropertyMetadata(Color.FromArgb(128, byte.MaxValue, 160, 0)));
					FlashModeProperty = DependencyProperty.Register(vVK.ssH(5682), typeof(TabFlashMode), typeof(AdvancedTabItem), new PropertyMetadata(TabFlashMode.None));
					ForegroundActiveSelectedProperty = DependencyProperty.Register(vVK.ssH(5704), typeof(Brush), typeof(AdvancedTabItem), new PropertyMetadata(null));
					ForegroundInactiveSelectedProperty = DependencyProperty.Register(vVK.ssH(5756), typeof(Brush), typeof(AdvancedTabItem), new PropertyMetadata(null));
					num2 = 5;
					goto IL_0009;
				case 5:
					ForegroundPointerOverProperty = DependencyProperty.Register(vVK.ssH(5812), typeof(Brush), typeof(AdvancedTabItem), new PropertyMetadata(null));
					ForegroundPreviewProperty = DependencyProperty.Register(vVK.ssH(5858), typeof(Brush), typeof(AdvancedTabItem), new PropertyMetadata(null));
					ForegroundPreviewActiveSelectedProperty = DependencyProperty.Register(vVK.ssH(5896), typeof(Brush), typeof(AdvancedTabItem), new PropertyMetadata(null));
					ForegroundPreviewPointerOverProperty = DependencyProperty.Register(vVK.ssH(5962), typeof(Brush), typeof(AdvancedTabItem), new PropertyMetadata(null));
					HasCloseButtonProperty = DependencyProperty.Register(vVK.ssH(6022), typeof(bool), typeof(AdvancedTabItem), new PropertyMetadata(false));
					HasToggleLayoutKindButtonProperty = DependencyProperty.Register(vVK.ssH(6054), typeof(bool), typeof(AdvancedTabItem), new PropertyMetadata(false));
					HighlightKindProperty = DependencyProperty.Register(vVK.ssH(6108), typeof(TabHighlightKind), typeof(AdvancedTabItem), new PropertyMetadata(TabHighlightKind.None, cw7));
					ImageSourceProperty = DependencyProperty.Register(vVK.ssH(6138), typeof(ImageSource), typeof(AdvancedTabItem), new PropertyMetadata(null, Qwv));
					IsCloseButtonVisibleProperty = DependencyProperty.Register(vVK.ssH(6164), typeof(bool), typeof(AdvancedTabItem), new PropertyMetadata(false));
					IsContentHorizontalProperty = DependencyProperty.Register(vVK.ssH(6208), typeof(bool), typeof(AdvancedTabItem), new PropertyMetadata(true));
					IsImageVisibleProperty = DependencyProperty.Register(vVK.ssH(6250), typeof(bool), typeof(AdvancedTabItem), new PropertyMetadata(false));
					IsLoadAnimationEnabledProperty = DependencyProperty.Register(vVK.ssH(6282), typeof(bool), typeof(AdvancedTabItem), new PropertyMetadata(false, owR));
					IsReadOnlyProperty = DependencyProperty.Register(vVK.ssH(6330), typeof(bool), typeof(AdvancedTabItem), new PropertyMetadata(false, XwS));
					IsToggleLayoutKindButtonVisibleProperty = DependencyProperty.Register(vVK.ssH(6354), typeof(bool), typeof(AdvancedTabItem), new PropertyMetadata(false));
					LayoutKindProperty = DependencyProperty.Register(vVK.ssH(6420), typeof(TabLayoutKind), typeof(AdvancedTabItem), new PropertyMetadata(TabLayoutKind.Normal, lwL));
					PinButtonContentTemplateProperty = DependencyProperty.Register(vVK.ssH(6444), typeof(DataTemplate), typeof(AdvancedTabItem), new PropertyMetadata(null));
					PromoteButtonContentTemplateProperty = DependencyProperty.Register(vVK.ssH(6496), typeof(DataTemplate), typeof(AdvancedTabItem), new PropertyMetadata(null));
					ReadOnlyContextContentTemplateProperty = DependencyProperty.Register(vVK.ssH(6556), typeof(DataTemplate), typeof(AdvancedTabItem), new PropertyMetadata(null));
					TintColorProperty = DependencyProperty.Register(vVK.ssH(6620), typeof(Color), typeof(AdvancedTabItem), new PropertyMetadata(Colors.Transparent));
					UnpinButtonContentTemplateProperty = DependencyProperty.Register(vVK.ssH(6642), typeof(DataTemplate), typeof(AdvancedTabItem), new PropertyMetadata(null));
					FarSlantExtentProperty = DependencyProperty.Register(vVK.ssH(6698), typeof(double), typeof(AdvancedTabItem), new PropertyMetadata(0.0));
					NearSlantExtentProperty = DependencyProperty.Register(vVK.ssH(6730), typeof(double), typeof(AdvancedTabItem), new PropertyMetadata(0.0));
					return;
				case 3:
					K2e = DependencyProperty.Register(vVK.ssH(5628), typeof(int), typeof(AdvancedTabItem), new PropertyMetadata(0));
					EmbeddedButtonStyleProperty = DependencyProperty.Register(vVK.ssH(602), typeof(Style), typeof(AdvancedTabItem), new PropertyMetadata(null));
					num2 = 0;
					if (false)
					{
						num2 = 0;
					}
					goto IL_0009;
				case 1:
					BackgroundPreviewProperty = DependencyProperty.Register(vVK.ssH(4832), typeof(Brush), typeof(AdvancedTabItem), new PropertyMetadata(null));
					BackgroundPreviewActiveSelectedProperty = DependencyProperty.Register(vVK.ssH(4870), typeof(Brush), typeof(AdvancedTabItem), new PropertyMetadata(null));
					BackgroundPreviewPointerOverProperty = DependencyProperty.Register(vVK.ssH(4936), typeof(Brush), typeof(AdvancedTabItem), new PropertyMetadata(null));
					BorderBrushActiveSelectedProperty = DependencyProperty.Register(vVK.ssH(4996), typeof(Brush), typeof(AdvancedTabItem), new PropertyMetadata(null));
					BorderBrushInactiveSelectedProperty = DependencyProperty.Register(vVK.ssH(5050), typeof(Brush), typeof(AdvancedTabItem), new PropertyMetadata(null));
					BorderBrushPointerOverProperty = DependencyProperty.Register(vVK.ssH(5108), typeof(Brush), typeof(AdvancedTabItem), new PropertyMetadata(null));
					BorderBrushPreviewProperty = DependencyProperty.Register(vVK.ssH(5156), typeof(Brush), typeof(AdvancedTabItem), new PropertyMetadata(null));
					BorderBrushPreviewActiveSelectedProperty = DependencyProperty.Register(vVK.ssH(5196), typeof(Brush), typeof(AdvancedTabItem), new PropertyMetadata(null));
					num2 = 2;
					goto IL_0009;
				}
				ArrangeYAnimatedProperty = DependencyProperty.Register(vVK.ssH(4576), typeof(double), typeof(AdvancedTabItem), new PropertyMetadata(0.0, LwE));
				AreEmbeddedButtonsAlwaysVisibleProperty = DependencyProperty.Register(vVK.ssH(4612), typeof(bool), typeof(AdvancedTabItem), new PropertyMetadata(false, Awr));
				BackgroundActiveSelectedProperty = DependencyProperty.Register(vVK.ssH(4678), typeof(Brush), typeof(AdvancedTabItem), new PropertyMetadata(null));
				BackgroundInactiveSelectedProperty = DependencyProperty.Register(vVK.ssH(4730), typeof(Brush), typeof(AdvancedTabItem), new PropertyMetadata(null));
				BackgroundPointerOverProperty = DependencyProperty.Register(vVK.ssH(4786), typeof(Brush), typeof(AdvancedTabItem), new PropertyMetadata(null));
				num2 = 1;
			}
			while (0 == 0);
		}
	}

	[CompilerGenerated]
	private void awU(object P_0)
	{
		AdvancedTabControl advancedTabControl = qwH();
		if (advancedTabControl != null && !advancedTabControl.fdN(this))
		{
			Close();
		}
	}

	[CompilerGenerated]
	private void wwc(object P_0)
	{
		ToggleLayoutKind();
	}

	internal static bool B5()
	{
		return rB == null;
	}

	internal static AdvancedTabItem uj()
	{
		return rB;
	}
}
