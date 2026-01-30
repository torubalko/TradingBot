using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;
using ActiproSoftware.Internal;
using ActiproSoftware.Products;
using ActiproSoftware.Products.Editors;
using ActiproSoftware.Windows.Controls.Editors.Primitives;
using ActiproSoftware.Windows.Extensions;
using ActiproSoftware.Windows.Media;

namespace ActiproSoftware.Windows.Controls.Editors;

[TemplatePart(Name = "PART_Checkerboard", Type = typeof(Path))]
[TemplatePart(Name = "PART_RadialHuePicker", Type = typeof(RadialHuePicker))]
[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Hsb")]
public class HsbColorPicker : PickerBase
{
	private double Ujn;

	public static readonly DependencyProperty AProperty;

	public static readonly DependencyProperty BrightnessProperty;

	public static readonly DependencyProperty ComparisonValueProperty;

	public static readonly DependencyProperty HueProperty;

	public static readonly DependencyProperty IsComparisonValueVisibleProperty;

	public static readonly DependencyProperty SaturationProperty;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private EventHandler SjJ;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private EventHandler Uje;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private EventHandler djk;

	internal static HsbColorPicker pBn;

	private Color SelectedColor
	{
		get
		{
			byte alpha = Convert.ToByte(A);
			double normalizedDegreeAngle = Hue.GetNormalizedDegreeAngle();
			double saturation = Saturation;
			double brightness = Brightness;
			return UIColor.FromAhsb(alpha, normalizedDegreeAngle, saturation, brightness).ToColor();
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "A")]
	public int A
	{
		get
		{
			return (int)GetValue(AProperty);
		}
		set
		{
			SetValue(AProperty, value);
		}
	}

	public double Brightness
	{
		get
		{
			return (double)GetValue(BrightnessProperty);
		}
		set
		{
			SetValue(BrightnessProperty, value);
		}
	}

	public Color ComparisonValue
	{
		get
		{
			return (Color)GetValue(ComparisonValueProperty);
		}
		set
		{
			SetValue(ComparisonValueProperty, value);
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

	public bool IsComparisonValueVisible
	{
		get
		{
			return (bool)GetValue(IsComparisonValueVisibleProperty);
		}
		set
		{
			SetValue(IsComparisonValueVisibleProperty, value);
		}
	}

	public double Saturation
	{
		get
		{
			return (double)GetValue(SaturationProperty);
		}
		set
		{
			SetValue(SaturationProperty, value);
		}
	}

	public event EventHandler BrightnessChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = SjJ;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref SjJ, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = SjJ;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref SjJ, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler HueChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = Uje;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref Uje, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = Uje;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref Uje, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler SaturationChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = djk;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref djk, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = djk;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref djk, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public HsbColorPicker()
	{
		awj.QuEwGz();
		Ujn = 180.0;
		base._002Ector();
		base.DefaultStyleKey = typeof(HsbColorPicker);
		ActiproLicenseValidator.ValidateLicense(ActiproSoftware.Products.Editors.AssemblyInfo.Instance, GetType(), this);
		base.SizeChanged += gjr;
	}

	private PathGeometry dj3()
	{
		PathGeometry pathGeometry = new PathGeometry();
		int num = 10;
		for (double num2 = 0.0; num2 < Ujn; num2 += (double)num)
		{
			for (double num3 = 0.0; num3 < Ujn; num3 += (double)num)
			{
				if ((num2 % (double)(2 * num) != 0.0 || num3 % (double)(2 * num) != (double)num) && (num2 % (double)(2 * num) != (double)num || num3 % (double)(2 * num) != 0.0) && (!(num2 < (double)(2 * num)) || !(num3 < (double)(2 * num))) && (!(num2 < (double)(2 * num)) || !(num3 >= Ujn - (double)(2 * num))) && (!(num2 >= Ujn - (double)(2 * num)) || !(num3 < (double)(2 * num))) && (!(num2 >= Ujn - (double)(2 * num)) || !(num3 >= Ujn - (double)(2 * num))))
				{
					PathFigure pathFigure = new PathFigure
					{
						IsClosed = true,
						StartPoint = new Point(num2, num3)
					};
					pathFigure.Segments.Add(new LineSegment
					{
						Point = new Point(num2 + (double)num, num3)
					});
					pathFigure.Segments.Add(new LineSegment
					{
						Point = new Point(num2 + (double)num, num3 + (double)num)
					});
					pathFigure.Segments.Add(new LineSegment
					{
						Point = new Point(num2, num3 + (double)num)
					});
					pathGeometry.Figures.Add(pathFigure);
				}
			}
		}
		return pathGeometry;
	}

	private static void Jjy(object P_0, DependencyPropertyChangedEventArgs P_1)
	{
		HsbColorPicker hsbColorPicker = (HsbColorPicker)P_0;
		hsbColorPicker.zji();
	}

	private static void Kjm(object P_0, DependencyPropertyChangedEventArgs P_1)
	{
		HsbColorPicker hsbColorPicker = (HsbColorPicker)P_0;
		hsbColorPicker.zji();
		hsbColorPicker.pjv();
	}

	private static void HjS(object P_0, DependencyPropertyChangedEventArgs P_1)
	{
		HsbColorPicker hsbColorPicker = (HsbColorPicker)P_0;
		hsbColorPicker.zji();
	}

	private static void Pj1(object P_0, DependencyPropertyChangedEventArgs P_1)
	{
		HsbColorPicker hsbColorPicker = (HsbColorPicker)P_0;
		hsbColorPicker.zji();
		hsbColorPicker.Yjp();
	}

	private static void lj8(object P_0, DependencyPropertyChangedEventArgs P_1)
	{
		HsbColorPicker hsbColorPicker = (HsbColorPicker)P_0;
		hsbColorPicker.zji();
		hsbColorPicker.fjW();
	}

	private void gjr(object P_0, SizeChangedEventArgs P_1)
	{
		double num = 40.0;
		if (GetTemplateChild(QdM.AR8(19926)) is RadialHuePicker radialHuePicker)
		{
			double num2 = (radialHuePicker.Radius - radialHuePicker.SliderRadius) * 2.0;
			if (num2 > 0.0)
			{
				num = num2;
			}
			double num3 = Math.Ceiling(Math.Max(radialHuePicker.ActualWidth, radialHuePicker.ActualHeight) - 2.0 * num);
			if (num3 > 0.0 && num3 != Ujn)
			{
				Ujn = num3;
				vjZ();
			}
		}
	}

	private void pjv()
	{
		SjJ?.Invoke(this, EventArgs.Empty);
	}

	private void Yjp()
	{
		Uje?.Invoke(this, EventArgs.Empty);
	}

	private void fjW()
	{
		djk?.Invoke(this, EventArgs.Empty);
	}

	private void zji()
	{
		if (!IsComparisonValueVisible)
		{
			base.Background = new SolidColorBrush(SelectedColor);
			return;
		}
		base.Background = new LinearGradientBrush
		{
			EndPoint = new Point(1.0, 0.0),
			GradientStops = 
			{
				new GradientStop
				{
					Offset = 0.49999,
					Color = ComparisonValue
				},
				new GradientStop
				{
					Offset = 0.5,
					Color = SelectedColor
				}
			}
		};
	}

	private void vjZ()
	{
		if (GetTemplateChild(QdM.AR8(19632)) is Path path)
		{
			path.Data = dj3();
		}
	}

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		vjZ();
		zji();
	}

	static HsbColorPicker()
	{
		awj.QuEwGz();
		AProperty = DependencyProperty.Register(QdM.AR8(2828), typeof(int), typeof(HsbColorPicker), new PropertyMetadata(255, Jjy));
		BrightnessProperty = DependencyProperty.Register(QdM.AR8(2654), typeof(double), typeof(HsbColorPicker), new PropertyMetadata(1.0, Kjm));
		ComparisonValueProperty = DependencyProperty.Register(QdM.AR8(2834), typeof(Color), typeof(HsbColorPicker), new PropertyMetadata(VdT.abb, HjS));
		HueProperty = DependencyProperty.Register(QdM.AR8(2608), typeof(double), typeof(HsbColorPicker), new PropertyMetadata(0.0, Pj1));
		IsComparisonValueVisibleProperty = DependencyProperty.Register(QdM.AR8(3084), typeof(bool), typeof(HsbColorPicker), new PropertyMetadata(false, HjS));
		SaturationProperty = DependencyProperty.Register(QdM.AR8(2624), typeof(double), typeof(HsbColorPicker), new PropertyMetadata(1.0, lj8));
	}

	internal static bool tBg()
	{
		return pBn == null;
	}

	internal static HsbColorPicker nBs()
	{
		return pBn;
	}
}
