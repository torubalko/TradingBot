using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
using ActiproSoftware.Windows.Media;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Controls.ColorSelection;

public class SpectrumSlider : Slider
{
	private LinearGradientBrush cnx;

	public static readonly RoutedEvent SelectedColorChangedEvent;

	internal static readonly DependencyProperty ColorSpectrumBrushProperty;

	public static readonly DependencyProperty SelectedColorProperty;

	internal static SpectrumSlider m17;

	internal Brush ColorSpectrumBrush
	{
		get
		{
			return (Brush)GetValue(ColorSpectrumBrushProperty);
		}
		set
		{
			SetValue(ColorSpectrumBrushProperty, value);
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
	static SpectrumSlider()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		SelectedColorChangedEvent = EventManager.RegisterRoutedEvent(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(121992), RoutingStrategy.Bubble, typeof(RoutedPropertyChangedEventHandler<Color>), typeof(SpectrumSlider));
		ColorSpectrumBrushProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(122882), typeof(Brush), typeof(SpectrumSlider), new FrameworkPropertyMetadata(null));
		SelectedColorProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(122100), typeof(Color), typeof(SpectrumSlider), new FrameworkPropertyMetadata(Colors.Red, TnA));
		FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(SpectrumSlider), new FrameworkPropertyMetadata(typeof(SpectrumSlider)));
		Control.IsTabStopProperty.OverrideMetadata(typeof(SpectrumSlider), new FrameworkPropertyMetadata(false));
	}

	public SpectrumSlider()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
		ColorSpectrumBrush = knl();
	}

	private Brush knl()
	{
		if (cnx == null)
		{
			List<Color> list = new List<Color>();
			for (double num = 360.0; num >= 0.0; num -= 12.0)
			{
				list.Add(UIColor.FromHsb(num, 1.0, 1.0).ToColor());
			}
			cnx = new LinearGradientBrush();
			cnx.StartPoint = new Point(0.0, 0.0);
			cnx.EndPoint = new Point(0.0, 1.0);
			double num2 = 1.0 / (double)(list.Count - 1);
			for (int i = 0; i < list.Count; i++)
			{
				cnx.GradientStops.Add(new GradientStop(list[i], (double)i * num2));
			}
			cnx.GradientStops[cnx.GradientStops.Count - 1].Offset = 1.0;
		}
		return cnx;
	}

	private static void TnA(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		SpectrumSlider spectrumSlider = (SpectrumSlider)P_0;
		Color oldValue = (Color)P_1.OldValue;
		Color color = (Color)P_1.NewValue;
		UIColor uIColor = UIColor.FromColor(color);
		if (Math.Abs(uIColor.HsbHue - spectrumSlider.Value) > 1.0)
		{
			spectrumSlider.Value = uIColor.HsbHue;
		}
		spectrumSlider.OnSelectedColorChanged(oldValue, color);
	}

	[SpecialName]
	private Rectangle MnY()
	{
		return GetTemplateChild(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(122392)) as Rectangle;
	}

	private void lnC(MouseEventArgs P_0)
	{
		base.Value = (1.0 - P_0.GetPosition(MnY()).Y / base.ActualHeight) * 360.0;
	}

	protected override void OnMouseLeftButtonUp(MouseButtonEventArgs e)
	{
		if (e == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(107336));
		}
		if (!e.Handled && base.IsMouseCaptured)
		{
			ReleaseMouseCapture();
			int num = 0;
			if (!v1H())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			e.Handled = true;
		}
		base.OnMouseLeftButtonUp(e);
	}

	protected override void OnMouseMove(MouseEventArgs e)
	{
		if (e == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(107336));
		}
		base.OnMouseMove(e);
		if (!e.Handled && base.IsMouseCaptured)
		{
			lnC(e);
			e.Handled = true;
		}
	}

	protected override void OnMouseWheel(MouseWheelEventArgs e)
	{
		if (e == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(107336));
		}
		base.OnMouseWheel(e);
		if (!e.Handled)
		{
			double num = e.Delta / 120;
			base.Value += num;
			e.Handled = true;
		}
	}

	protected override void OnPreviewMouseLeftButtonDown(MouseButtonEventArgs e)
	{
		if (e == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(107336));
		}
		base.OnPreviewMouseLeftButtonDown(e);
		if (!e.Handled)
		{
			CaptureMouse();
			lnC(e);
			e.Handled = true;
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
		SelectedColor = UIColor.FromHsb(newValue, 1.0, 1.0).ToColor();
	}

	internal static bool v1H()
	{
		return m17 == null;
	}

	internal static SpectrumSlider Y1J()
	{
		return m17;
	}
}
