using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Animation;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Media.Animation;

public class WedgeWipeTransition : StoryboardTransitionBase
{
	public static readonly DependencyProperty BeginTimeProperty;

	public static readonly DependencyProperty DirectionProperty;

	public static readonly DependencyProperty DurationProperty;

	public static readonly DependencyProperty ModeProperty;

	internal static WedgeWipeTransition cHl;

	public TimeSpan BeginTime
	{
		get
		{
			return (TimeSpan)GetValue(BeginTimeProperty);
		}
		set
		{
			SetValue(BeginTimeProperty, value);
		}
	}

	public TransitionDirection Direction
	{
		get
		{
			return (TransitionDirection)GetValue(DirectionProperty);
		}
		set
		{
			SetValue(DirectionProperty, value);
		}
	}

	public Duration Duration
	{
		get
		{
			return (Duration)GetValue(DurationProperty);
		}
		set
		{
			SetValue(DurationProperty, value);
		}
	}

	public TransitionMode Mode
	{
		get
		{
			return (TransitionMode)GetValue(ModeProperty);
		}
		set
		{
			SetValue(ModeProperty, value);
		}
	}

	private static TransitionDirection UOQ(TransitionDirection P_0)
	{
		switch (P_0)
		{
		case TransitionDirection.Backward:
		case TransitionDirection.BackwardDown:
		case TransitionDirection.BackwardUp:
			return TransitionDirection.Backward;
		case TransitionDirection.Down:
			return TransitionDirection.Down;
		case TransitionDirection.Default:
		case TransitionDirection.Forward:
		case TransitionDirection.ForwardDown:
		case TransitionDirection.ForwardUp:
			return TransitionDirection.Forward;
		default:
			return TransitionDirection.Up;
		}
	}

	private Storyboard dOO(TransitionPresenter P_0, FrameworkElement P_1)
	{
		Duration duration = ((Duration == Duration.Automatic && P_0 != null) ? P_0.DefaultDuration : Duration);
		if (!duration.HasTimeSpan)
		{
			duration = new Duration(TimeSpan.FromMilliseconds(500.0));
		}
		string text;
		double toValue;
		switch (UOQ(Transition.GetResolvedDirection(Direction, P_0?.DefaultDirection ?? TransitionDirection.Default)))
		{
		case TransitionDirection.Backward:
			text = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(110396);
			toValue = ((Mode == TransitionMode.In) ? (-0.5) : 0.5) * P_1.ActualWidth;
			break;
		case TransitionDirection.Down:
			text = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(110402);
			toValue = (double)((Mode != TransitionMode.In) ? (-1) : 0) * P_1.ActualHeight;
			break;
		case TransitionDirection.Up:
			text = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(110402);
			toValue = ((Mode == TransitionMode.In) ? (-0.5) : 0.5) * P_1.ActualHeight;
			break;
		default:
			text = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(110396);
			toValue = (double)((Mode != TransitionMode.In) ? (-1) : 0) * P_1.ActualWidth;
			break;
		}
		Storyboard storyboard = new Storyboard();
		storyboard.BeginTime = BeginTime;
		storyboard.FillBehavior = FillBehavior.Stop;
		DoubleAnimation doubleAnimation = new DoubleAnimation(toValue, duration);
		Storyboard.SetTargetProperty(doubleAnimation, new PropertyPath(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(110408) + text));
		storyboard.Children.Add(doubleAnimation);
		return storyboard;
	}

	private Style PO0(TransitionPresenter P_0, FrameworkElement P_1)
	{
		TransitionDirection transitionDirection = UOQ(Transition.GetResolvedDirection(Direction, P_0?.DefaultDirection ?? TransitionDirection.Default));
		Style style = new Style(typeof(FrameworkElement));
		DrawingBrush drawingBrush = new DrawingBrush();
		double scaleX = 1.0;
		double scaleY = 1.0;
		PathFigure pathFigure;
		Point point;
		switch (transitionDirection)
		{
		case TransitionDirection.Backward:
			pathFigure = new PathFigure(new Point(0.0, 1.0), new PathSegment[4]
			{
				new LineSegment(new Point(1.0, 0.0), isStroked: true),
				new LineSegment(new Point(2.0, 0.0), isStroked: true),
				new LineSegment(new Point(2.0, 2.0), isStroked: true),
				new LineSegment(new Point(1.0, 2.0), isStroked: true)
			}, closed: true);
			point = new Point((Mode == TransitionMode.In) ? 0.5 : (-0.5), 0.0);
			scaleX = 2.0;
			break;
		case TransitionDirection.Down:
			pathFigure = new PathFigure(new Point(0.0, 0.0), new PathSegment[4]
			{
				new LineSegment(new Point(0.0, 1.0), isStroked: true),
				new LineSegment(new Point(1.0, 2.0), isStroked: true),
				new LineSegment(new Point(2.0, 1.0), isStroked: true),
				new LineSegment(new Point(2.0, 0.0), isStroked: true)
			}, closed: true);
			point = new Point(0.0, (Mode == TransitionMode.In) ? (-1) : 0);
			scaleY = 2.0;
			break;
		case TransitionDirection.Forward:
			pathFigure = new PathFigure(new Point(0.0, 0.0), new PathSegment[4]
			{
				new LineSegment(new Point(1.0, 0.0), isStroked: true),
				new LineSegment(new Point(2.0, 1.0), isStroked: true),
				new LineSegment(new Point(1.0, 2.0), isStroked: true),
				new LineSegment(new Point(0.0, 2.0), isStroked: true)
			}, closed: true);
			point = new Point((Mode == TransitionMode.In) ? (-1) : 0, 0.0);
			scaleX = 2.0;
			break;
		default:
			pathFigure = new PathFigure(new Point(1.0, 0.0), new PathSegment[4]
			{
				new LineSegment(new Point(0.0, 1.0), isStroked: true),
				new LineSegment(new Point(0.0, 2.0), isStroked: true),
				new LineSegment(new Point(2.0, 2.0), isStroked: true),
				new LineSegment(new Point(2.0, 1.0), isStroked: true)
			}, closed: true);
			point = new Point(0.0, (Mode == TransitionMode.In) ? 0.5 : (-0.5));
			scaleY = 2.0;
			break;
		}
		drawingBrush.Drawing = new GeometryDrawing(Brushes.Black, null, new PathGeometry(new PathFigure[1] { pathFigure }));
		TransformGroup transformGroup = new TransformGroup();
		transformGroup.Children.Add(new TranslateTransform(point.X * P_1.ActualWidth, point.Y * P_1.ActualHeight));
		transformGroup.Children.Add(new ScaleTransform(scaleX, scaleY, 0.0, 0.0));
		drawingBrush.Transform = transformGroup;
		style.Setters.Add(new Setter(UIElement.OpacityMaskProperty, drawingBrush));
		return style;
	}

	private static void fOk(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		WedgeWipeTransition wedgeWipeTransition = (WedgeWipeTransition)P_0;
		wedgeWipeTransition.IsToContentTopMost = wedgeWipeTransition.Mode == TransitionMode.In;
	}

	protected override Storyboard GetFromContentStoryboard(TransitionPresenter presenter, FrameworkElement content)
	{
		return (Mode == TransitionMode.Out) ? dOO(presenter, content) : null;
	}

	protected override Style GetFromContentStyle(TransitionPresenter presenter, FrameworkElement content)
	{
		return (Mode == TransitionMode.Out) ? PO0(presenter, content) : null;
	}

	public override Transition GetOppositeTransition()
	{
		WedgeWipeTransition wedgeWipeTransition = (WedgeWipeTransition)Clone();
		wedgeWipeTransition.Mode = Transition.GetOppositeMode(Mode);
		return wedgeWipeTransition;
	}

	protected override Storyboard GetToContentStoryboard(TransitionPresenter presenter, FrameworkElement content)
	{
		return (Mode == TransitionMode.In) ? dOO(presenter, content) : null;
	}

	protected override Style GetToContentStyle(TransitionPresenter presenter, FrameworkElement content)
	{
		return (Mode == TransitionMode.In) ? PO0(presenter, content) : null;
	}

	public WedgeWipeTransition()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	static WedgeWipeTransition()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		BeginTimeProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(107862), typeof(TimeSpan), typeof(WedgeWipeTransition), new FrameworkPropertyMetadata(TimeSpan.Zero));
		DirectionProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(107884), typeof(TransitionDirection), typeof(WedgeWipeTransition), new FrameworkPropertyMetadata(TransitionDirection.Default));
		DurationProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(107906), typeof(Duration), typeof(WedgeWipeTransition), new FrameworkPropertyMetadata(Duration.Automatic));
		ModeProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(107926), typeof(TransitionMode), typeof(WedgeWipeTransition), new FrameworkPropertyMetadata(TransitionMode.In, fOk));
	}

	internal static bool AHE()
	{
		return cHl == null;
	}

	internal static WedgeWipeTransition PHx()
	{
		return cHl;
	}
}
