using System;
using System.Diagnostics.CodeAnalysis;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;
using ActiproSoftware.Windows.Controls;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Shapes;

[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Zag")]
[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "ZigZag")]
public class ZigZag : Shape
{
	public static readonly DependencyProperty ApexCountProperty;

	public static readonly DependencyProperty ApexSideProperty;

	public static readonly DependencyProperty DataProperty;

	public static readonly DependencyProperty IsInvertedProperty;

	private static ZigZag nfE;

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

	public ZigZag()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
		base.Stretch = Stretch.Fill;
		To9();
	}

	private static void RoJ(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		ZigZag zigZag = (ZigZag)P_0;
		zigZag.To9();
	}

	private void To9()
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
				pathFigure.Segments.Add(new LineSegment
				{
					Point = new Point(num4 + num2 / 2.0, 1.0)
				});
				num4 += num2;
				pathFigure.Segments.Add(new LineSegment
				{
					Point = new Point(num4, 0.0)
				});
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
				pathFigure.Segments.Add(new LineSegment
				{
					Point = new Point(0.0, num5 + num2 / 2.0)
				});
				num5 += num2;
				pathFigure.Segments.Add(new LineSegment
				{
					Point = new Point(1.0, num5)
				});
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
				pathFigure.Segments.Add(new LineSegment
				{
					Point = new Point(num6 + num2 / 2.0, 0.0)
				});
				num6 += num2;
				pathFigure.Segments.Add(new LineSegment
				{
					Point = new Point(num6, 1.0)
				});
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
				pathFigure.Segments.Add(new LineSegment
				{
					Point = new Point(1.0, num3 + num2 / 2.0)
				});
				num3 += num2;
				pathFigure.Segments.Add(new LineSegment
				{
					Point = new Point(0.0, num3)
				});
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

	static ZigZag()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		ApexCountProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(106050), typeof(int), typeof(ZigZag), new PropertyMetadata(20, RoJ));
		ApexSideProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(106018), typeof(Side), typeof(ZigZag), new PropertyMetadata(Side.Top, RoJ));
		DataProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(106038), typeof(Geometry), typeof(ZigZag), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsMeasure | FrameworkPropertyMetadataOptions.AffectsRender));
		IsInvertedProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(106072), typeof(bool), typeof(ZigZag), new PropertyMetadata(false, RoJ));
	}

	internal static bool Pfx()
	{
		return nfE == null;
	}

	internal static ZigZag QfS()
	{
		return nfE;
	}
}
