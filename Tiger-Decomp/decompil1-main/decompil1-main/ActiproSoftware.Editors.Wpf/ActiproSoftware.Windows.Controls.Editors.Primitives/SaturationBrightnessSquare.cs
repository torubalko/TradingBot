using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Media;

namespace ActiproSoftware.Windows.Controls.Editors.Primitives;

[ToolboxItem(false)]
public class SaturationBrightnessSquare : Control
{
	public static readonly DependencyProperty BrightnessBrushProperty;

	public static readonly DependencyProperty HueProperty;

	public static readonly DependencyProperty SaturationBrushProperty;

	internal static SaturationBrightnessSquare xhL;

	public Brush BrightnessBrush
	{
		get
		{
			return (Brush)GetValue(BrightnessBrushProperty);
		}
		private set
		{
			SetValue(BrightnessBrushProperty, value);
		}
	}

	public double Hue
	{
		get
		{
			return (double)GetValue(HueProperty);
		}
		set
		{
			SetValue(HueProperty, value);
		}
	}

	public Brush SaturationBrush
	{
		get
		{
			return (Brush)GetValue(SaturationBrushProperty);
		}
		private set
		{
			SetValue(SaturationBrushProperty, value);
		}
	}

	public SaturationBrightnessSquare()
	{
		awj.QuEwGz();
		base._002Ector();
		base.DefaultStyleKey = typeof(SaturationBrightnessSquare);
		nIE();
	}

	private static void rIk(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		SaturationBrightnessSquare saturationBrightnessSquare = (SaturationBrightnessSquare)P_0;
		saturationBrightnessSquare.nIE();
	}

	private void nIE()
	{
		LinearGradientBrush linearGradientBrush = new LinearGradientBrush();
		linearGradientBrush.EndPoint = new Point(0.0, 1.0);
		linearGradientBrush.GradientStops.Add(new GradientStop
		{
			Offset = 0.0,
			Color = Color.FromArgb(0, 0, 0, 0)
		});
		linearGradientBrush.GradientStops.Add(new GradientStop
		{
			Offset = 1.0,
			Color = Color.FromArgb(byte.MaxValue, 0, 0, 0)
		});
		BrightnessBrush = linearGradientBrush;
		LinearGradientBrush linearGradientBrush2 = new LinearGradientBrush();
		linearGradientBrush2.EndPoint = new Point(1.0, 0.0);
		linearGradientBrush2.GradientStops.Add(new GradientStop
		{
			Offset = 0.0,
			Color = Colors.White
		});
		linearGradientBrush2.GradientStops.Add(new GradientStop
		{
			Offset = 1.0,
			Color = UIColor.FromHsb(Hue, 1.0, 1.0).ToColor()
		});
		SaturationBrush = linearGradientBrush2;
	}

	static SaturationBrightnessSquare()
	{
		awj.QuEwGz();
		BrightnessBrushProperty = DependencyProperty.Register(QdM.AR8(26314), typeof(Brush), typeof(SaturationBrightnessSquare), new PropertyMetadata(null));
		HueProperty = DependencyProperty.Register(QdM.AR8(2608), typeof(double), typeof(SaturationBrightnessSquare), new PropertyMetadata(0.0, rIk));
		SaturationBrushProperty = DependencyProperty.Register(QdM.AR8(26348), typeof(Brush), typeof(SaturationBrightnessSquare), new PropertyMetadata(null));
	}

	internal static bool Shq()
	{
		return xhL == null;
	}

	internal static SaturationBrightnessSquare Fhn()
	{
		return xhL;
	}
}
