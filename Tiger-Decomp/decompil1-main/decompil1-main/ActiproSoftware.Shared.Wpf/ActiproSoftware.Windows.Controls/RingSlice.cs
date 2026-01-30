using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Shapes;
using ActiproSoftware.Windows.Extensions;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Controls;

public class RingSlice : Shape
{
	private bool rCq;

	public static readonly DependencyProperty DataProperty;

	public static readonly DependencyProperty EndAngleProperty;

	public static readonly DependencyProperty IsRenderedWhenFullCircleProperty;

	public static readonly DependencyProperty RadiusProperty;

	public static readonly DependencyProperty StartAngleProperty;

	private static readonly DependencyProperty wCW;

	private static RingSlice MGs;

	private double Thickness
	{
		get
		{
			return (double)GetValue(wCW);
		}
		set
		{
			SetValue(wCW, value);
		}
	}

	private Geometry Data
	{
		get
		{
			return (Geometry)GetValue(DataProperty);
		}
		set
		{
			SetValue(DataProperty, value);
		}
	}

	protected override Geometry DefiningGeometry => Data;

	public double EndAngle
	{
		get
		{
			return (double)GetValue(EndAngleProperty);
		}
		set
		{
			SetValue(EndAngleProperty, value);
		}
	}

	public bool IsRenderedWhenFullCircle
	{
		get
		{
			return (bool)GetValue(IsRenderedWhenFullCircleProperty);
		}
		set
		{
			SetValue(IsRenderedWhenFullCircleProperty, value);
		}
	}

	public double Radius
	{
		get
		{
			return (double)GetValue(RadiusProperty);
		}
		set
		{
			SetValue(RadiusProperty, value);
		}
	}

	public double StartAngle
	{
		get
		{
			return (double)GetValue(StartAngleProperty);
		}
		set
		{
			SetValue(StartAngleProperty, value);
		}
	}

	[SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline")]
	static RingSlice()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		DataProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(106038), typeof(Geometry), typeof(RingSlice), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsMeasure | FrameworkPropertyMetadataOptions.AffectsRender));
		EndAngleProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(116522), typeof(double), typeof(RingSlice), new PropertyMetadata(360.0, mCe));
		IsRenderedWhenFullCircleProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(116542), typeof(bool), typeof(RingSlice), new PropertyMetadata(true, iC7));
		RadiusProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(115726), typeof(double), typeof(RingSlice), new PropertyMetadata(40.0, JCF));
		StartAngleProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(116594), typeof(double), typeof(RingSlice), new PropertyMetadata(0.0, mCe));
		wCW = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(116618), typeof(double), typeof(RingSlice), new PropertyMetadata(0.0, mCo));
		Shape.StrokeThicknessProperty.OverrideMetadata(typeof(RingSlice), new FrameworkPropertyMetadata(20.0));
	}

	public RingSlice()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	private bool cC4()
	{
		double angle = kC0() - rCI();
		double normalizedDegreeAngle = angle.GetNormalizedDegreeAngle();
		return normalizedDegreeAngle >= 180.0;
	}

	private Point uCu(double P_0, double P_1)
	{
		double num = fCC();
		return new Point(num, num).GetRadiusPointAtRotation(P_0, P_1);
	}

	private void nC2()
	{
		if (!rCq)
		{
			this.BindToProperty(wCW, this, WP6RZJql8gZrNhVA9v.L3hoFlcqP6(116640), BindingMode.TwoWay);
			rCq = true;
		}
	}

	private static void mCe(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		RingSlice ringSlice = (RingSlice)P_0;
		ringSlice.PCQ();
	}

	private static void iC7(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		RingSlice ringSlice = (RingSlice)P_0;
		ringSlice.PCQ();
	}

	private static void JCF(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		RingSlice ringSlice = (RingSlice)P_0;
		ringSlice.LCO();
		ringSlice.PCQ();
	}

	private static void mCo(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		RingSlice ringSlice = (RingSlice)P_0;
		ringSlice.PCQ();
	}

	[SpecialName]
	private double kC0()
	{
		double endAngle = EndAngle;
		double normalizedDegreeAngle = endAngle.GetNormalizedDegreeAngle();
		if (IsRenderedWhenFullCircle)
		{
			double startAngle = StartAngle;
			if (startAngle != endAngle)
			{
				double normalizedDegreeAngle2 = startAngle.GetNormalizedDegreeAngle();
				if (normalizedDegreeAngle2 == normalizedDegreeAngle)
				{
					double angle = normalizedDegreeAngle + 360.0 - 1E-05;
					normalizedDegreeAngle = angle.GetNormalizedDegreeAngle();
				}
			}
		}
		return normalizedDegreeAngle;
	}

	[SpecialName]
	private double rCl()
	{
		return Math.Max(0.0, fCC() - Math.Max(0.0, base.StrokeThickness) / 2.0);
	}

	[SpecialName]
	private double fCC()
	{
		return Math.Max(0.0, Radius);
	}

	[SpecialName]
	private double rCI()
	{
		return StartAngle.GetNormalizedDegreeAngle();
	}

	private void PCQ()
	{
		double num = rCl();
		bool flag = cC4();
		double num2 = rCI();
		double num3 = kC0();
		if (flag)
		{
			Data = new PathGeometry
			{
				Figures = 
				{
					new PathFigure
					{
						IsClosed = false,
						StartPoint = uCu(num2, num),
						Segments = 
						{
							(PathSegment)new ArcSegment
							{
								IsLargeArc = true,
								Point = uCu((num2 + 180.0).GetNormalizedDegreeAngle(), num),
								Size = new Size(num, num),
								SweepDirection = SweepDirection.Clockwise
							},
							(PathSegment)new ArcSegment
							{
								IsLargeArc = false,
								Point = uCu(num3, num),
								Size = new Size(num, num),
								SweepDirection = SweepDirection.Clockwise
							}
						}
					}
				}
			};
		}
		else
		{
			Data = new PathGeometry
			{
				Figures = 
				{
					new PathFigure
					{
						IsClosed = false,
						StartPoint = uCu(num2, num),
						Segments = { (PathSegment)new ArcSegment
						{
							IsLargeArc = flag,
							Point = uCu(num3, num),
							Size = new Size(num, num),
							SweepDirection = SweepDirection.Clockwise
						} }
					}
				}
			};
		}
	}

	private void LCO()
	{
		double height = (base.Width = 2.0 * fCC());
		base.Height = height;
	}

	protected override Size ArrangeOverride(Size finalSize)
	{
		base.ArrangeOverride(finalSize);
		return new Size(Math.Max(0.0, Radius * 2.0), Math.Max(0.0, Radius * 2.0));
	}

	protected override Size MeasureOverride(Size availableSize)
	{
		nC2();
		return new Size(Math.Max(0.0, Radius * 2.0), Math.Max(0.0, Radius * 2.0));
	}

	internal static bool fGi()
	{
		return MGs == null;
	}

	internal static RingSlice qGp()
	{
		return MGs;
	}
}
