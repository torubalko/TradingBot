using System.Diagnostics.CodeAnalysis;
using System.Windows;
using System.Windows.Media.Animation;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Media.Animation;

public class StoryboardTransition : StoryboardTransitionBase
{
	public static readonly DependencyProperty FromContentStoryboardProperty;

	public static readonly DependencyProperty FromContentStyleProperty;

	public static readonly DependencyProperty ToContentStoryboardProperty;

	public static readonly DependencyProperty ToContentStyleProperty;

	internal static StoryboardTransition nH1;

	[SuppressMessage("Microsoft.Naming", "CA1721:PropertyNamesShouldNotMatchGetMethods")]
	public Storyboard FromContentStoryboard
	{
		get
		{
			return (Storyboard)GetValue(FromContentStoryboardProperty);
		}
		set
		{
			SetValue(FromContentStoryboardProperty, value);
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1721:PropertyNamesShouldNotMatchGetMethods")]
	public Style FromContentStyle
	{
		get
		{
			return (Style)GetValue(FromContentStyleProperty);
		}
		set
		{
			SetValue(FromContentStyleProperty, value);
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1721:PropertyNamesShouldNotMatchGetMethods")]
	public Storyboard ToContentStoryboard
	{
		get
		{
			return (Storyboard)GetValue(ToContentStoryboardProperty);
		}
		set
		{
			SetValue(ToContentStoryboardProperty, value);
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1721:PropertyNamesShouldNotMatchGetMethods")]
	public Style ToContentStyle
	{
		get
		{
			return (Style)GetValue(ToContentStyleProperty);
		}
		set
		{
			SetValue(ToContentStyleProperty, value);
		}
	}

	protected override Storyboard GetFromContentStoryboard(TransitionPresenter presenter, FrameworkElement content)
	{
		return FromContentStoryboard;
	}

	protected override Style GetFromContentStyle(TransitionPresenter presenter, FrameworkElement content)
	{
		return FromContentStyle;
	}

	public override Transition GetOppositeTransition()
	{
		return Clone();
	}

	protected override Storyboard GetToContentStoryboard(TransitionPresenter presenter, FrameworkElement content)
	{
		return ToContentStoryboard;
	}

	protected override Style GetToContentStyle(TransitionPresenter presenter, FrameworkElement content)
	{
		return ToContentStyle;
	}

	public StoryboardTransition()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	static StoryboardTransition()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		FromContentStoryboardProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(109086), typeof(Storyboard), typeof(StoryboardTransition), new FrameworkPropertyMetadata(null));
		FromContentStyleProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(109132), typeof(Style), typeof(StoryboardTransition), new FrameworkPropertyMetadata(null));
		ToContentStoryboardProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(109168), typeof(Storyboard), typeof(StoryboardTransition), new FrameworkPropertyMetadata(null));
		ToContentStyleProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(109210), typeof(Style), typeof(StoryboardTransition), new FrameworkPropertyMetadata(null));
	}

	internal static bool AHg()
	{
		return nH1 == null;
	}

	internal static StoryboardTransition bH8()
	{
		return nH1;
	}
}
