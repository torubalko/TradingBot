using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;
using ActiproSoftware.Windows.Controls;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Shapes;

public class Wave : Shape
{
	public static readonly DependencyProperty ApexCountProperty;

	public static readonly DependencyProperty ApexSideProperty;

	public static readonly DependencyProperty DataProperty;

	public static readonly DependencyProperty IsInvertedProperty;

	private static Wave CfD;

	public int ApexCount
	{
		get
		{
			return (int)GetValue(ApexCountProperty);
		}
		set
		{
			SetValue(ApexCountProperty, value);
		}
	}

	public Side ApexSide
	{
		get
		{
			return (Side)GetValue(ApexSideProperty);
		}
		set
		{
			SetValue(ApexSideProperty, value);
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

	public bool IsInverted
	{
		get
		{
			return (bool)GetValue(IsInvertedProperty);
		}
		set
		{
			SetValue(IsInvertedProperty, value);
		}
	}

	public Wave()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
		base.Stretch = Stretch.Fill;
		RoS();
	}

	private static void Goi(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		Wave wave = (Wave)P_0;
		wave.RoS();
	}

	private void RoS()
	{
		int num = Math.Max(1, ApexCount);
		double num2 = 1.0 / Math.Max(1.0, num);
		PathFigure pathFigure = new PathFigure
		{
			IsClosed = false
		};
		switch (ApexSide)
		{
		case Side.Bottom:
		{
			if (IsInverted)
			{
				pathFigure.StartPoint = new Point(0.0, 1.0);
				pathFigure.Segments.Add(new LineSegment
				{
					Point = new Point(0.0, 0.0)
				});
			}
			else
			{
				pathFigure.StartPoint = new Point(0.0, 0.0);
			}
			double num4 = 0.0;
			for (int j = 0; j < num; j++)
			{
				pathFigure.Segments.Add(new BezierSegment
				{
					Point1 = new Point(num4 + 0.25 * num2, 0.0),
					Point2 = new Point(num4 + 0.25 * num2, 1.0),
					Point3 = new Point(num4 + 0.5 * num2, 1.0)
				});
				pathFigure.Segments.Add(new BezierSegment
				{
					Point1 = new Point(num4 + 0.75 * num2, 1.0),
					Point2 = new Point(num4 + 0.75 * num2, 0.0),
					Point3 = new Point(num4 + 1.0 * num2, 0.0)
				});
				num4 += num2;
			}
			if (IsInverted)
			{
				pathFigure.Segments.Add(new LineSegment
				{
					Point = new Point(1.0, 1.0)
				});
			}
			break;
		}
		case Side.Left:
		{
			if (IsInverted)
			{
				pathFigure.StartPoint = new Point(0.0, 0.0);
				pathFigure.Segments.Add(new LineSegment
				{
					Point = new Point(1.0, 0.0)
				});
			}
			else
			{
				pathFigure.StartPoint = new Point(1.0, 0.0);
			}
			double num5 = 0.0;
			for (int k = 0; k < num; k++)
			{
				pathFigure.Segments.Add(new BezierSegment
				{
					Point1 = new Point(1.0, num5 + 0.25 * num2),
					Point2 = new Point(0.0, num5 + 0.25 * num2),
					Point3 = new Point(0.0, num5 + 0.5 * num2)
				});
				pathFigure.Segments.Add(new BezierSegment
				{
					Point1 = new Point(0.0, num5 + 0.75 * num2),
					Point2 = new Point(1.0, num5 + 0.75 * num2),
					Point3 = new Point(1.0, num5 + 1.0 * num2)
				});
				num5 += num2;
			}
			if (IsInverted)
			{
				pathFigure.Segments.Add(new LineSegment
				{
					Point = new Point(0.0, 1.0)
				});
			}
			break;
		}
		case Side.Top:
		{
			if (IsInverted)
			{
				pathFigure.StartPoint = new Point(0.0, 0.0);
				pathFigure.Segments.Add(new LineSegment
				{
					Point = new Point(0.0, 1.0)
				});
			}
			else
			{
				pathFigure.StartPoint = new Point(0.0, 1.0);
			}
			double num6 = 0.0;
			for (int l = 0; l < num; l++)
			{
				pathFigure.Segments.Add(new BezierSegment
				{
					Point1 = new Point(num6 + 0.25 * num2, 1.0),
					Point2 = new Point(num6 + 0.25 * num2, 0.0),
					Point3 = new Point(num6 + 0.5 * num2, 0.0)
				});
				pathFigure.Segments.Add(new BezierSegment
				{
					Point1 = new Point(num6 + 0.75 * num2, 0.0),
					Point2 = new Point(num6 + 0.75 * num2, 1.0),
					Point3 = new Point(num6 + 1.0 * num2, 1.0)
				});
				num6 += num2;
			}
			if (IsInverted)
			{
				pathFigure.Segments.Add(new LineSegment
				{
					Point = new Point(1.0, 0.0)
				});
			}
			break;
		}
		default:
		{
			if (IsInverted)
			{
				pathFigure.StartPoint = new Point(1.0, 0.0);
				pathFigure.Segments.Add(new LineSegment
				{
					Point = new Point(0.0, 0.0)
				});
			}
			else
			{
				pathFigure.StartPoint = new Point(0.0, 0.0);
			}
			double num3 = 0.0;
			for (int i = 0; i < num; i++)
			{
				pathFigure.Segments.Add(new BezierSegment
				{
					Point1 = new Point(0.0, num3 + 0.25 * num2),
					Point2 = new Point(1.0, num3 + 0.25 * num2),
					Point3 = new Point(1.0, num3 + 0.5 * num2)
				});
				pathFigure.Segments.Add(new BezierSegment
				{
					Point1 = new Point(1.0, num3 + 0.75 * num2),
					Point2 = new Point(0.0, num3 + 0.75 * num2),
					Point3 = new Point(0.0, num3 + 1.0 * num2)
				});
				num3 += num2;
			}
			if (IsInverted)
			{
				pathFigure.Segments.Add(new LineSegment
				{
					Point = new Point(1.0, 1.0)
				});
			}
			break;
		}
		}
		Data = new PathGeometry
		{
			Figures = { pathFigure }
		};
	}

	static Wave()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		ApexCountProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(106050), typeof(int), typeof(Wave), new PropertyMetadata(20, Goi));
		ApexSideProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(106018), typeof(Side), typeof(Wave), new PropertyMetadata(Side.Top, Goi));
		DataProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(106038), typeof(Geometry), typeof(Wave), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsMeasure | FrameworkPropertyMetadataOptions.AffectsRender));
		IsInvertedProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(106072), typeof(bool), typeof(Wave), new PropertyMetadata(false, Goi));
	}

	internal static bool qf2()
	{
		return CfD == null;
	}

	internal static Wave zfl()
	{
		return CfD;
	}
}
