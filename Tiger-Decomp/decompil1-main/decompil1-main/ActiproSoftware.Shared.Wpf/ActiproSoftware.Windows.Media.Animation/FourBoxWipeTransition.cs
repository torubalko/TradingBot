using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Animation;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Media.Animation;

public class FourBoxWipeTransition : StoryboardTransitionBase
{
	public static readonly DependencyProperty BeginTimeProperty;

	public static readonly DependencyProperty DurationProperty;

	public static readonly DependencyProperty ModeProperty;

	private static FourBoxWipeTransition gHJ;

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

	private Storyboard KQV(TransitionPresenter P_0)
	{
		Duration duration = ((Duration == Duration.Automatic && P_0 != null) ? P_0.DefaultDuration : Duration);
		if (!duration.HasTimeSpan)
		{
			duration = new Duration(TimeSpan.FromMilliseconds(500.0));
		}
		Storyboard storyboard = new Storyboard();
		storyboard.BeginTime = BeginTime;
		storyboard.FillBehavior = FillBehavior.Stop;
		DoubleAnimation doubleAnimation = new DoubleAnimation((Mode != TransitionMode.In) ? 2 : 0, (Mode == TransitionMode.In) ? 2 : 0, duration);
		Storyboard.SetTargetProperty(doubleAnimation, new PropertyPath(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(108464)));
		storyboard.Children.Add(doubleAnimation);
		DoubleAnimation doubleAnimation2 = new DoubleAnimation((Mode != TransitionMode.In) ? (-1) : 0, (Mode == TransitionMode.In) ? (-1) : 0, duration);
		Storyboard.SetTargetProperty(doubleAnimation2, new PropertyPath(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(108588)));
		storyboard.Children.Add(doubleAnimation2);
		doubleAnimation = new DoubleAnimation(doubleAnimation.From.Value, doubleAnimation.To.Value, duration);
		Storyboard.SetTargetProperty(doubleAnimation, new PropertyPath(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(108702)));
		storyboard.Children.Add(doubleAnimation);
		doubleAnimation2 = new DoubleAnimation(doubleAnimation2.From.Value, doubleAnimation2.To.Value, duration);
		Storyboard.SetTargetProperty(doubleAnimation2, new PropertyPath(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(108826)));
		storyboard.Children.Add(doubleAnimation2);
		return storyboard;
	}

	private Style AQ5()
	{
		Style style = new Style(typeof(FrameworkElement));
		DrawingBrush drawingBrush = new DrawingBrush();
		DrawingGroup drawingGroup = (DrawingGroup)(drawingBrush.Drawing = new DrawingGroup());
		double num = ((Mode == TransitionMode.In) ? 2 : 0);
		Point point = new Point(1.0, 0.0);
		DrawingGroup drawingGroup2 = new DrawingGroup();
		drawingGroup2.Children.Add(new GeometryDrawing(Brushes.Black, null, new RectangleGeometry(new Rect(point.X, point.Y, 1.0, 2.0))));
		TransformGroup transformGroup = new TransformGroup();
		transformGroup.Children.Add(new ScaleTransform(num, 1.0, point.X, point.Y));
		transformGroup.Children.Add(new TranslateTransform());
		drawingGroup2.Transform = transformGroup;
		drawingGroup.Children.Add(drawingGroup2);
		point = new Point(0.0, 1.0);
		drawingGroup2 = new DrawingGroup();
		drawingGroup2.Children.Add(new GeometryDrawing(Brushes.Black, null, new RectangleGeometry(new Rect(point.X, point.Y, 2.0, 1.0))));
		transformGroup = new TransformGroup();
		transformGroup.Children.Add(new ScaleTransform(1.0, num, point.X, point.Y));
		int num2 = 0;
		if (!iH3())
		{
			goto IL_0005;
		}
		goto IL_0009;
		IL_0009:
		do
		{
			switch (num2)
			{
			case 1:
				return style;
			}
			transformGroup.Children.Add(new TranslateTransform());
			drawingGroup2.Transform = transformGroup;
			drawingGroup.Children.Add(drawingGroup2);
			style.Setters.Add(new Setter(UIElement.OpacityMaskProperty, drawingBrush));
			num2 = 1;
		}
		while (iH3());
		goto IL_0005;
		IL_0005:
		int num3 = default(int);
		num2 = num3;
		goto IL_0009;
	}

	private static void YQR(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		FourBoxWipeTransition fourBoxWipeTransition = (FourBoxWipeTransition)P_0;
		fourBoxWipeTransition.IsToContentTopMost = fourBoxWipeTransition.Mode == TransitionMode.In;
	}

	protected override Storyboard GetFromContentStoryboard(TransitionPresenter presenter, FrameworkElement content)
	{
		return (Mode == TransitionMode.Out) ? KQV(presenter) : null;
	}

	protected override Style GetFromContentStyle(TransitionPresenter presenter, FrameworkElement content)
	{
		return (Mode == TransitionMode.Out) ? AQ5() : null;
	}

	public override Transition GetOppositeTransition()
	{
		FourBoxWipeTransition fourBoxWipeTransition = (FourBoxWipeTransition)Clone();
		fourBoxWipeTransition.Mode = Transition.GetOppositeMode(Mode);
		return fourBoxWipeTransition;
	}

	protected override Storyboard GetToContentStoryboard(TransitionPresenter presenter, FrameworkElement content)
	{
		return (Mode == TransitionMode.In) ? KQV(presenter) : null;
	}

	protected override Style GetToContentStyle(TransitionPresenter presenter, FrameworkElement content)
	{
		return (Mode == TransitionMode.In) ? AQ5() : null;
	}

	public FourBoxWipeTransition()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	static FourBoxWipeTransition()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		BeginTimeProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(107862), typeof(TimeSpan), typeof(FourBoxWipeTransition), new FrameworkPropertyMetadata(TimeSpan.Zero));
		DurationProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(107906), typeof(Duration), typeof(FourBoxWipeTransition), new FrameworkPropertyMetadata(Duration.Automatic));
		ModeProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(107926), typeof(TransitionMode), typeof(FourBoxWipeTransition), new FrameworkPropertyMetadata(TransitionMode.In, YQR));
	}

	internal static bool iH3()
	{
		return gHJ == null;
	}

	internal static FourBoxWipeTransition gHN()
	{
		return gHJ;
	}
}
