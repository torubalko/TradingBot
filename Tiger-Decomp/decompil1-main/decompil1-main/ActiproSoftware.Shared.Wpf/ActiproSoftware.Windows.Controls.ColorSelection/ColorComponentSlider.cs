using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;
using ActiproSoftware.Windows.Themes;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Controls.ColorSelection;

public class ColorComponentSlider : Slider
{
	private Color OZk;

	private bool pZl;

	public static readonly RoutedEvent SelectedColorChangedEvent;

	private static readonly DependencyPropertyKey mZA;

	public static readonly DependencyProperty ActiveGradientBrushProperty;

	public static readonly DependencyProperty ComponentProperty;

	public static readonly DependencyProperty DisabledOpacityProperty;

	public static readonly DependencyProperty SelectedColorProperty;

	internal static ColorComponentSlider jbU;

	public Brush ActiveGradientBrush
	{
		get
		{
			return (Brush)GetValue(ActiveGradientBrushProperty);
		}
		private set
		{
			SetValue(mZA, value);
		}
	}

	public ColorComponent Component
	{
		get
		{
			return (ColorComponent)GetValue(ComponentProperty);
		}
		set
		{
			SetValue(ComponentProperty, value);
		}
	}

	public double DisabledOpacity
	{
		get
		{
			return (double)GetValue(DisabledOpacityProperty);
		}
		set
		{
			SetValue(DisabledOpacityProperty, value);
		}
	}

	public Color SelectedColor
	{
		get
		{
			return (Color)GetValue(SelectedColorProperty);
		}
		set
		{
			SetValue(SelectedColorProperty, value);
		}
	}

	[Description("Occurs when the value of the SelectedColor property is changed.")]
	public event RoutedPropertyChangedEventHandler<Color> SelectedColorChanged
	{
		add
		{
			AddHandler(SelectedColorChangedEvent, value);
		}
		remove
		{
			RemoveHandler(SelectedColorChangedEvent, value);
		}
	}

	[SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline")]
	static ColorComponentSlider()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		SelectedColorChangedEvent = EventManager.RegisterRoutedEvent(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(121992), RoutingStrategy.Bubble, typeof(RoutedPropertyChangedEventHandler<Color>), typeof(ColorComponentSlider));
		mZA = DependencyProperty.RegisterReadOnly(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(122036), typeof(Brush), typeof(ColorComponentSlider), new FrameworkPropertyMetadata(null));
		ActiveGradientBrushProperty = mZA.DependencyProperty;
		ComponentProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(122078), typeof(ColorComponent), typeof(ColorComponentSlider), new FrameworkPropertyMetadata(ColorComponent.Alpha, RZ7));
		DisabledOpacityProperty = ThemeProperties.DisabledOpacityProperty.AddOwner(typeof(ColorComponentSlider), new FrameworkPropertyMetadata(1.0));
		SelectedColorProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(122100), typeof(Color), typeof(ColorComponentSlider), new FrameworkPropertyMetadata(Colors.Red, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, iZo));
		FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(ColorComponentSlider), new FrameworkPropertyMetadata(typeof(ColorComponentSlider)));
		Control.IsTabStopProperty.OverrideMetadata(typeof(ColorComponentSlider), new FrameworkPropertyMetadata(false));
		RangeBase.MaximumProperty.OverrideMetadata(typeof(ColorComponentSlider), new FrameworkPropertyMetadata(255.0));
		RangeBase.MinimumProperty.OverrideMetadata(typeof(ColorComponentSlider), new FrameworkPropertyMetadata(0.0));
		Slider.OrientationProperty.OverrideMetadata(typeof(ColorComponentSlider), new FrameworkPropertyMetadata(tZF));
		int num = 0;
		if (false)
		{
			int num2;
			num = num2;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public ColorComponentSlider()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		OZk = Colors.Transparent;
		base._002Ector();
		BZQ(_0020: true);
	}

	private static void RZ7(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		if (P_0 is ColorComponentSlider colorComponentSlider)
		{
			colorComponentSlider.KZO();
			colorComponentSlider.BZQ(_0020: true);
		}
	}

	private static void tZF(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		if (P_0 is ColorComponentSlider colorComponentSlider)
		{
			colorComponentSlider.BZQ(_0020: true);
		}
	}

	private static void iZo(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		if (P_0 is ColorComponentSlider colorComponentSlider)
		{
			colorComponentSlider.KZO();
			colorComponentSlider.BZQ(_0020: false);
			colorComponentSlider.OnSelectedColorChanged((Color)P_1.OldValue, (Color)P_1.NewValue);
		}
	}

	private void BZQ(bool P_0)
	{
		Color selectedColor = SelectedColor;
		Color color = Colors.White;
		Color color2 = Colors.White;
		bool flag = false;
		switch (Component)
		{
		case ColorComponent.Alpha:
			flag = OZk.R != selectedColor.R || OZk.G != selectedColor.G || OZk.B != selectedColor.B;
			color = Color.FromArgb(byte.MaxValue, selectedColor.R, selectedColor.G, selectedColor.B);
			color2 = Color.FromArgb(0, selectedColor.R, selectedColor.G, selectedColor.B);
			break;
		case ColorComponent.Red:
			flag = OZk.A != selectedColor.A || OZk.G != selectedColor.G || OZk.B != selectedColor.B;
			color = Color.FromArgb(byte.MaxValue, byte.MaxValue, selectedColor.G, selectedColor.B);
			color2 = Color.FromArgb(byte.MaxValue, 0, selectedColor.G, selectedColor.B);
			break;
		case ColorComponent.Green:
			flag = OZk.A != selectedColor.A || OZk.R != selectedColor.R || OZk.B != selectedColor.B;
			color = Color.FromArgb(byte.MaxValue, selectedColor.R, byte.MaxValue, selectedColor.B);
			color2 = Color.FromArgb(byte.MaxValue, selectedColor.R, 0, selectedColor.B);
			break;
		case ColorComponent.Blue:
			flag = OZk.A != selectedColor.A || OZk.R != selectedColor.R || OZk.G != selectedColor.G;
			color = Color.FromArgb(byte.MaxValue, selectedColor.R, selectedColor.G, byte.MaxValue);
			color2 = Color.FromArgb(byte.MaxValue, selectedColor.R, selectedColor.G, 0);
			break;
		}
		if (flag || P_0)
		{
			OZk = selectedColor;
			bool flag2 = base.Orientation == Orientation.Horizontal;
			ActiveGradientBrush = new LinearGradientBrush
			{
				StartPoint = (flag2 ? new Point(1.0, 0.0) : new Point(0.0, 0.0)),
				EndPoint = (flag2 ? new Point(0.0, 0.0) : new Point(0.0, 1.0)),
				GradientStops = 
				{
					new GradientStop(color, 0.0),
					new GradientStop(color2, 1.0)
				}
			};
		}
	}

	private void KZO()
	{
		pZl = true;
		try
		{
			Color selectedColor = SelectedColor;
			switch (Component)
			{
			case ColorComponent.Blue:
				base.Value = (int)selectedColor.B;
				break;
			case ColorComponent.Alpha:
			{
				base.Value = (int)selectedColor.A;
				int num = 0;
				if (qb4() != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				case 0:
					break;
				}
				break;
			}
			case ColorComponent.Red:
				base.Value = (int)selectedColor.R;
				break;
			case ColorComponent.Green:
				base.Value = (int)selectedColor.G;
				break;
			}
		}
		finally
		{
			pZl = false;
		}
	}

	protected virtual void OnSelectedColorChanged(Color oldValue, Color newValue)
	{
		RoutedPropertyChangedEventArgs<Color> e = new RoutedPropertyChangedEventArgs<Color>(oldValue, newValue, SelectedColorChangedEvent);
		e.Source = this;
		RaiseEvent(e);
	}

	protected override void OnValueChanged(double oldValue, double newValue)
	{
		base.OnValueChanged(oldValue, newValue);
		if (!pZl)
		{
			Color selectedColor = SelectedColor;
			switch (Component)
			{
			case ColorComponent.Blue:
				SelectedColor = Color.FromArgb(selectedColor.A, selectedColor.R, selectedColor.G, (byte)newValue);
				break;
			case ColorComponent.Alpha:
				SelectedColor = Color.FromArgb((byte)newValue, selectedColor.R, selectedColor.G, selectedColor.B);
				break;
			case ColorComponent.Red:
				SelectedColor = Color.FromArgb(selectedColor.A, (byte)newValue, selectedColor.G, selectedColor.B);
				break;
			case ColorComponent.Green:
				SelectedColor = Color.FromArgb(selectedColor.A, selectedColor.R, (byte)newValue, selectedColor.B);
				break;
			}
		}
	}

	internal static bool gbL()
	{
		return jbU == null;
	}

	internal static ColorComponentSlider qb4()
	{
		return jbU;
	}
}
