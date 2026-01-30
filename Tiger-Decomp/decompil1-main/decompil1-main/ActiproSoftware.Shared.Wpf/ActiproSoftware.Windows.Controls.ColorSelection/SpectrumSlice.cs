using System;
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

public class SpectrumSlice : Control
{
	private Point Yno;

	private bool WnQ;

	public static readonly RoutedEvent SelectedColorChangedEvent;

	private static readonly DependencyPropertyKey EnO;

	private static readonly DependencyPropertyKey vn0;

	private static readonly DependencyPropertyKey hnk;

	public static readonly DependencyProperty BaseColorProperty;

	public static readonly DependencyProperty BaseColorBrushProperty;

	public static readonly DependencyProperty MarkedColorProperty;

	public static readonly DependencyProperty MarkedColorBrushProperty;

	public static readonly DependencyProperty SelectedColorProperty;

	internal static SpectrumSlice U1Y;

	public Color BaseColor
	{
		get
		{
			return (Color)GetValue(BaseColorProperty);
		}
		set
		{
			SetValue(BaseColorProperty, value);
		}
	}

	public Brush BaseColorBrush
	{
		get
		{
			return (Brush)GetValue(BaseColorBrushProperty);
		}
		private set
		{
			SetValue(EnO, value);
		}
	}

	public Color MarkedColor
	{
		get
		{
			return (Color)GetValue(MarkedColorProperty);
		}
		private set
		{
			SetValue(vn0, value);
		}
	}

	public Brush MarkedColorBrush
	{
		get
		{
			return (Brush)GetValue(MarkedColorBrushProperty);
		}
		private set
		{
			SetValue(hnk, value);
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
	static SpectrumSlice()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		SelectedColorChangedEvent = EventManager.RegisterRoutedEvent(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(121992), RoutingStrategy.Bubble, typeof(RoutedPropertyChangedEventHandler<Color>), typeof(SpectrumSlice));
		EnO = DependencyProperty.RegisterReadOnly(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(122740), typeof(Brush), typeof(SpectrumSlice), new FrameworkPropertyMetadata(null));
		vn0 = DependencyProperty.RegisterReadOnly(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(122772), typeof(Color), typeof(SpectrumSlice), new FrameworkPropertyMetadata(Colors.White, FrameworkPropertyMetadataOptions.AffectsRender, Wn9));
		hnk = DependencyProperty.RegisterReadOnly(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(122798), typeof(Brush), typeof(SpectrumSlice), new FrameworkPropertyMetadata(null));
		BaseColorProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(122834), typeof(Color), typeof(SpectrumSlice), new FrameworkPropertyMetadata(Colors.White, FrameworkPropertyMetadataOptions.AffectsRender, vnJ));
		BaseColorBrushProperty = EnO.DependencyProperty;
		MarkedColorProperty = vn0.DependencyProperty;
		MarkedColorBrushProperty = hnk.DependencyProperty;
		SelectedColorProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(122100), typeof(Color), typeof(SpectrumSlice), new FrameworkPropertyMetadata(Colors.White, FrameworkPropertyMetadataOptions.AffectsRender, snh));
		FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(SpectrumSlice), new FrameworkPropertyMetadata(typeof(SpectrumSlice)));
		Control.IsTabStopProperty.OverrideMetadata(typeof(SpectrumSlice), new FrameworkPropertyMetadata(false));
	}

	public SpectrumSlice()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		WnQ = true;
		base._002Ector();
		rnm();
		MarkedColorBrush = new SolidColorBrush(MarkedColor);
	}

	[SpecialName]
	private Path Snu()
	{
		return GetTemplateChild(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(122856)) as Path;
	}

	private static void vnJ(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		SpectrumSlice spectrumSlice = (SpectrumSlice)P_0;
		spectrumSlice.cn4(spectrumSlice.Yno);
		spectrumSlice.SelectedColor = spectrumSlice.MarkedColor;
		spectrumSlice.rnm();
	}

	private static void Wn9(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		SpectrumSlice spectrumSlice = (SpectrumSlice)P_0;
		spectrumSlice.MarkedColorBrush = new SolidColorBrush(spectrumSlice.MarkedColor);
		spectrumSlice.knw();
	}

	private static void snh(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		SpectrumSlice spectrumSlice = (SpectrumSlice)P_0;
		Color oldValue = (Color)P_1.OldValue;
		Color color = (Color)P_1.NewValue;
		if (spectrumSlice.MarkedColor != color)
		{
			spectrumSlice.MarkedColor = color;
		}
		spectrumSlice.OnSelectedColorChanged(oldValue, color);
	}

	private void rnm()
	{
		DrawingGroup drawingGroup = new DrawingGroup();
		GeometryDrawing geometryDrawing = new GeometryDrawing();
		geometryDrawing.Geometry = new RectangleGeometry(new Rect(0.0, 0.0, 1.0, 1.0));
		geometryDrawing.Brush = new SolidColorBrush(BaseColor);
		drawingGroup.Children.Add(geometryDrawing);
		geometryDrawing = new GeometryDrawing();
		int num = 0;
		if (d1f() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		geometryDrawing.Geometry = new RectangleGeometry(new Rect(0.0, 0.0, 1.0, 1.0));
		geometryDrawing.Brush = LinearGradientBrushExtension.CreateBrush(BaseColor, Colors.Black, LinearGradientType.TopToBottom);
		drawingGroup.Children.Add(geometryDrawing);
		DrawingGroup drawingGroup2 = new DrawingGroup();
		geometryDrawing = new GeometryDrawing();
		geometryDrawing.Geometry = new RectangleGeometry(new Rect(0.0, 0.0, 1.0, 1.0));
		geometryDrawing.Brush = LinearGradientBrushExtension.CreateBrush(Colors.White, Colors.Black, LinearGradientType.TopToBottom);
		drawingGroup2.Children.Add(geometryDrawing);
		drawingGroup2.OpacityMask = LinearGradientBrushExtension.CreateBrush(Colors.Black, Colors.Transparent, LinearGradientType.LeftToRight);
		drawingGroup.Children.Add(drawingGroup2);
		BaseColorBrush = new DrawingBrush(drawingGroup);
	}

	private void knw()
	{
		Path path = Snu();
		if (path != null)
		{
			UIColor uIColor = UIColor.FromColor(MarkedColor);
			if (WnQ)
			{
				Yno = new Point(uIColor.HsbSaturation * base.ActualWidth, (1.0 - uIColor.HsbBrightness) * base.ActualHeight);
			}
			path.RenderTransform = new TranslateTransform(Yno.X, Yno.Y);
			path.Stroke = (uIColor.ExceedsW3CBrightnessThreshold ? Brushes.Black : new SolidColorBrush(Color.FromArgb(200, byte.MaxValue, byte.MaxValue, byte.MaxValue)));
		}
	}

	private void cn4(Point P_0)
	{
		double saturation = Math.Max(0.0, Math.Min(1.0, P_0.X / base.ActualWidth));
		double brightness = 1.0 - Math.Max(0.0, Math.Min(1.0, P_0.Y / base.ActualHeight));
		try
		{
			WnQ = false;
			Yno = new Point(Math.Max(0.0, Math.Min(base.ActualWidth, P_0.X)), Math.Max(0.0, Math.Min(base.ActualHeight, P_0.Y)));
			MarkedColor = UIColor.FromAhsb(SelectedColor.A, UIColor.FromColor(BaseColor).HsbHue, saturation, brightness).ToColor();
		}
		finally
		{
			WnQ = true;
		}
	}

	protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
	{
		if (e == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(107336));
		}
		base.OnMouseLeftButtonDown(e);
		CaptureMouse();
		cn4(e.GetPosition(this));
		e.Handled = true;
	}

	protected override void OnMouseLeftButtonUp(MouseButtonEventArgs e)
	{
		if (e == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(107336));
		}
		if (base.IsMouseCaptured)
		{
			ReleaseMouseCapture();
			e.Handled = true;
			SelectedColor = MarkedColor;
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
		if (base.IsMouseCaptured)
		{
			cn4(e.GetPosition(this));
			e.Handled = true;
		}
	}

	protected override void OnRenderSizeChanged(SizeChangedInfo sizeInfo)
	{
		base.OnRenderSizeChanged(sizeInfo);
		knw();
	}

	protected virtual void OnSelectedColorChanged(Color oldValue, Color newValue)
	{
		RoutedPropertyChangedEventArgs<Color> e = new RoutedPropertyChangedEventArgs<Color>(oldValue, newValue, SelectedColorChangedEvent);
		e.Source = this;
		RaiseEvent(e);
	}

	internal static bool s1t()
	{
		return U1Y == null;
	}

	internal static SpectrumSlice d1f()
	{
		return U1Y;
	}
}
