using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;
using ActiproSoftware.Windows.Extensions;
using ActiproSoftware.Windows.Media;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Controls.ColorSelection.Primitives;

[ToolboxItem(false)]
public class GradientBrushThumb : Thumb
{
	public static readonly RoutedEvent SelectedEvent;

	public static readonly RoutedEvent UnselectedEvent;

	public static readonly DependencyProperty IsSelectedProperty;

	public static readonly DependencyProperty OrientationProperty;

	public static readonly DependencyProperty StopProperty;

	internal static GradientBrushThumb U13;

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

	public Orientation Orientation
	{
		get
		{
			return (Orientation)GetValue(OrientationProperty);
		}
		set
		{
			SetValue(OrientationProperty, value);
		}
	}

	public GradientStop Stop
	{
		get
		{
			return (GradientStop)GetValue(StopProperty);
		}
		set
		{
			SetValue(StopProperty, value);
		}
	}

	[Description("Occurs when the thumb is selected")]
	public event RoutedEventHandler Selected
	{
		add
		{
			AddHandler(SelectedEvent, value);
		}
		remove
		{
			RemoveHandler(SelectedEvent, value);
		}
	}

	[Description("Occurs when the thumb is unselected")]
	public event RoutedEventHandler Unselected
	{
		add
		{
			AddHandler(UnselectedEvent, value);
		}
		remove
		{
			RemoveHandler(UnselectedEvent, value);
		}
	}

	[SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline")]
	static GradientBrushThumb()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		SelectedEvent = EventManager.RegisterRoutedEvent(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(122922), RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(GradientBrushThumb));
		UnselectedEvent = EventManager.RegisterRoutedEvent(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(122942), RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(GradientBrushThumb));
		IsSelectedProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(122966), typeof(bool), typeof(GradientBrushThumb), new FrameworkPropertyMetadata(false, Rnn));
		OrientationProperty = GradientBrushSlider.OrientationProperty.AddOwner(typeof(GradientBrushThumb));
		StopProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(122990), typeof(GradientStop), typeof(GradientBrushSlider), new FrameworkPropertyMetadata(null));
		FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(GradientBrushThumb), new FrameworkPropertyMetadata(typeof(GradientBrushThumb)));
		UIElement.FocusableProperty.OverrideMetadata(typeof(GradientBrushThumb), new FrameworkPropertyMetadata(true));
	}

	public GradientBrushThumb()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
		base.DragDelta += VnZ;
		base.DragCompleted += inr;
	}

	private void inr(object P_0, DragCompletedEventArgs P_1)
	{
		if (base.Parent is FrameworkElement { ActualWidth: not 0.0, ActualHeight: not 0.0 } frameworkElement && VisualTreeHelperExtended.GetAncestor(this, typeof(GradientBrushSlider)) is GradientBrushSlider gradientBrushSlider)
		{
			Point position = Mouse.GetPosition(frameworkElement);
			if ((Orientation == Orientation.Horizontal && position.Y > frameworkElement.ActualHeight + 10.0) || (Orientation == Orientation.Vertical && position.X > frameworkElement.ActualWidth + 10.0))
			{
				gradientBrushSlider.UpdateSlider();
			}
		}
	}

	private void VnZ(object P_0, DragDeltaEventArgs P_1)
	{
		xna(P_1.HorizontalChange, P_1.VerticalChange);
		P_1.Handled = true;
	}

	private static void Rnn(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		if (P_0 is GradientBrushThumb gradientBrushThumb)
		{
			gradientBrushThumb.RaiseEvent(new RoutedEventArgs(((bool)P_1.NewValue) ? SelectedEvent : UnselectedEvent, gradientBrushThumb));
		}
	}

	private void xna(double P_0, double P_1)
	{
		if (!(base.Parent is FrameworkElement { ActualWidth: not 0.0 } frameworkElement))
		{
			return;
		}
		GradientStop stop = Stop;
		if (stop == null)
		{
			return;
		}
		double num = ((Orientation != Orientation.Horizontal) ? (P_1 / frameworkElement.ActualHeight) : (P_0 / frameworkElement.ActualWidth));
		stop.Offset = (stop.Offset + num).Range(0.0, 1.0);
		if (VisualTreeHelperExtended.GetAncestor(this, typeof(GradientBrushSlider)) is GradientBrushSlider { CanRemoveStops: not false, ActiveGradientBrush: GradientBrush activeGradientBrush })
		{
			Point position = Mouse.GetPosition(frameworkElement);
			if ((Orientation == Orientation.Horizontal && position.Y > frameworkElement.ActualHeight + 10.0) || (Orientation == Orientation.Vertical && position.X > frameworkElement.ActualWidth + 10.0))
			{
				activeGradientBrush.GradientStops.Remove(stop);
				base.Opacity = 0.0;
			}
			else if (!activeGradientBrush.GradientStops.Contains(stop))
			{
				activeGradientBrush.GradientStops.Add(stop);
				ClearValue(UIElement.OpacityProperty);
			}
		}
		frameworkElement.InvalidateArrange();
	}

	protected override void OnIsKeyboardFocusWithinChanged(DependencyPropertyChangedEventArgs e)
	{
		if ((bool)e.NewValue)
		{
			IsSelected = true;
		}
		base.OnIsKeyboardFocusWithinChanged(e);
	}

	protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
	{
		if (!base.IsKeyboardFocusWithin)
		{
			Focus();
		}
		base.OnMouseLeftButtonDown(e);
	}

	internal static bool o1N()
	{
		return U13 == null;
	}

	internal static GradientBrushThumb R1O()
	{
		return U13;
	}
}
