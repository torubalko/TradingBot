using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;
using ActiproSoftware.Windows.Controls;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Shapes;

public class Triangle : Shape
{
	public static readonly DependencyProperty ApexSideProperty;

	public static readonly DependencyProperty DataProperty;

	public static readonly DependencyProperty IsClosedProperty;

	internal static Triangle rfZ;

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

	public bool IsClosed
	{
		get
		{
			return (bool)GetValue(IsClosedProperty);
		}
		set
		{
			SetValue(IsClosedProperty, value);
		}
	}

	public Triangle()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
		base.Stretch = Stretch.Fill;
		lob();
	}

	private static void Dop(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		Triangle triangle = (Triangle)P_0;
		triangle.lob();
	}

	private void lob()
	{
		Point startPoint;
		Point point;
		Point point2;
		switch (ApexSide)
		{
		default:
		{
			startPoint = new Point(0.0, 0.0);
			point = new Point(1.0, 0.5);
			int num = 0;
			if (dfI() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			case 1:
				goto IL_0226;
			}
			point2 = new Point(0.0, 1.0);
			break;
		}
		case Side.Bottom:
			startPoint = new Point(0.0, 0.0);
			point = new Point(0.5, 1.0);
			point2 = new Point(1.0, 0.0);
			break;
		case Side.Top:
			goto IL_0226;
		case Side.Left:
			{
				startPoint = new Point(1.0, 0.0);
				point = new Point(0.0, 0.5);
				point2 = new Point(1.0, 1.0);
				break;
			}
			IL_0226:
			startPoint = new Point(0.0, 1.0);
			point = new Point(0.5, 0.0);
			point2 = new Point(1.0, 1.0);
			break;
		}
		Data = new PathGeometry
		{
			Figures = 
			{
				new PathFigure
				{
					IsClosed = IsClosed,
					StartPoint = startPoint,
					Segments = 
					{
						(PathSegment)new LineSegment
						{
							Point = point
						},
						(PathSegment)new LineSegment
						{
							Point = point2
						}
					}
				}
			}
		};
	}

	static Triangle()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		ApexSideProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(106018), typeof(Side), typeof(Triangle), new PropertyMetadata(Side.Top, Dop));
		DataProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(106038), typeof(Geometry), typeof(Triangle), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsMeasure | FrameworkPropertyMetadataOptions.AffectsRender));
		IsClosedProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(100774), typeof(bool), typeof(Triangle), new PropertyMetadata(true, Dop));
	}

	internal static bool kfr()
	{
		return rfZ == null;
	}

	internal static Triangle dfI()
	{
		return rfZ;
	}
}
