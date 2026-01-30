using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;
using ActiproSoftware.Windows.Controls;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Shapes;

public class SemiEllipse : Shape
{
	public static readonly DependencyProperty ApexSideProperty;

	public static readonly DependencyProperty DataProperty;

	public static readonly DependencyProperty IsClosedProperty;

	internal static SemiEllipse Mfo;

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

	public SemiEllipse()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
		base.Stretch = Stretch.Fill;
		zoX();
	}

	private static void Aov(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		SemiEllipse semiEllipse = (SemiEllipse)P_0;
		semiEllipse.zoX();
	}

	private void zoX()
	{
		Point startPoint = default(Point);
		Point point;
		SweepDirection sweepDirection;
		int num;
		switch (ApexSide)
		{
		case Side.Bottom:
			startPoint = new Point(0.0, 0.0);
			point = new Point(1.0, 0.0);
			sweepDirection = SweepDirection.Counterclockwise;
			break;
		case Side.Right:
			startPoint = new Point(0.0, 0.0);
			point = new Point(0.0, 1.0);
			sweepDirection = SweepDirection.Clockwise;
			break;
		case Side.Left:
			startPoint = new Point(1.0, 0.0);
			point = new Point(1.0, 1.0);
			sweepDirection = SweepDirection.Counterclockwise;
			break;
		case Side.Top:
			startPoint = new Point(0.0, 1.0);
			num = 0;
			if (tfm() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			goto IL_0009;
		default:
			{
				num = 1;
				if (tfm() != null)
				{
					num = 0;
				}
				goto IL_0009;
			}
			IL_0009:
			switch (num)
			{
			case 1:
				break;
			default:
				goto IL_0112;
			}
			goto case Side.Right;
			IL_0112:
			point = new Point(1.0, 1.0);
			sweepDirection = SweepDirection.Clockwise;
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
					Segments = { (PathSegment)new ArcSegment
					{
						SweepDirection = sweepDirection,
						IsLargeArc = true,
						Size = new Size(0.5, 0.5),
						Point = point
					} }
				}
			}
		};
	}

	static SemiEllipse()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		ApexSideProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(106018), typeof(Side), typeof(SemiEllipse), new PropertyMetadata(Side.Top, Aov));
		DataProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(106038), typeof(Geometry), typeof(SemiEllipse), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsMeasure | FrameworkPropertyMetadataOptions.AffectsRender));
		IsClosedProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(100774), typeof(bool), typeof(SemiEllipse), new PropertyMetadata(true, Aov));
	}

	internal static bool hf5()
	{
		return Mfo == null;
	}

	internal static SemiEllipse tfm()
	{
		return Mfo;
	}
}
