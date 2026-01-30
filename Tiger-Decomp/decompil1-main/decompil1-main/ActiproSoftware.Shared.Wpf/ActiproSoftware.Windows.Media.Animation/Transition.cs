using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Reflection;
using System.Windows;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Media.Animation;

public abstract class Transition : DependencyObject, ICloneable
{
	public static readonly DependencyProperty ClipToBoundsProperty;

	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "TopMost")]
	public static readonly DependencyProperty IsToContentTopMostProperty;

	internal static Transition xHd;

	public bool ClipToBounds
	{
		get
		{
			return (bool)GetValue(ClipToBoundsProperty);
		}
		set
		{
			SetValue(ClipToBoundsProperty, value);
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "TopMost")]
	public bool IsToContentTopMost
	{
		get
		{
			return (bool)GetValue(IsToContentTopMostProperty);
		}
		set
		{
			SetValue(IsToContentTopMostProperty, value);
		}
	}

	internal void BeginTransition(TransitionPresenter presenter, FrameworkElement fromContent, FrameworkElement toContent)
	{
		OnStarted(presenter, fromContent, toContent);
	}

	object ICloneable.Clone()
	{
		return Clone();
	}

	public Transition Clone()
	{
		ConstructorInfo constructor = GetType().GetConstructor(BindingFlags.Instance | BindingFlags.Public, null, Type.EmptyTypes, null);
		if (constructor == null)
		{
			throw new InvalidOperationException(string.Format(CultureInfo.CurrentCulture, WP6RZJql8gZrNhVA9v.L3hoFlcqP6(109554), new object[1] { GetType().FullName }));
		}
		Transition transition = (Transition)constructor.Invoke(new object[0]);
		PropertyInfo[] properties = GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public);
		PropertyInfo[] array = properties;
		foreach (PropertyInfo propertyInfo in array)
		{
			MethodInfo getMethod = propertyInfo.GetGetMethod();
			MethodInfo setMethod = propertyInfo.GetSetMethod();
			if (getMethod != null && setMethod != null)
			{
				setMethod.Invoke(transition, new object[1] { getMethod.Invoke(this, null) });
			}
		}
		return transition;
	}

	protected void EndTransition(TransitionPresenter presenter, FrameworkElement fromContent, object fromContentData, FrameworkElement toContent, object toContentData)
	{
		if (presenter == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(109760));
		}
		OnCompleted(presenter, fromContent, fromContentData, toContent, toContentData);
		presenter.OnTransitionCompleted();
	}

	public static TransitionDirection GetOppositeDirection(TransitionDirection direction)
	{
		TransitionDirection result;
		int num;
		switch (direction)
		{
		case TransitionDirection.BackwardDown:
			result = TransitionDirection.ForwardUp;
			break;
		case TransitionDirection.BackwardUp:
			result = TransitionDirection.ForwardDown;
			num = 0;
			if (tHa() != null)
			{
				num = 0;
			}
			goto IL_0009;
		case TransitionDirection.ForwardUp:
			result = TransitionDirection.BackwardDown;
			break;
		case TransitionDirection.Forward:
			result = TransitionDirection.Backward;
			break;
		case TransitionDirection.Backward:
			result = TransitionDirection.Forward;
			break;
		case TransitionDirection.ForwardDown:
			result = TransitionDirection.BackwardUp;
			break;
		case TransitionDirection.Down:
			result = TransitionDirection.Up;
			num = 1;
			if (tHa() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			goto IL_0009;
		default:
			{
				result = TransitionDirection.Down;
				break;
			}
			IL_0009:
			switch (num)
			{
			}
			break;
		}
		return result;
	}

	public static TransitionMode GetOppositeMode(TransitionMode mode)
	{
		if (mode != TransitionMode.In)
		{
			return TransitionMode.In;
		}
		return TransitionMode.Out;
	}

	[SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
	public abstract Transition GetOppositeTransition();

	protected static TransitionDirection GetResolvedDirection(TransitionDirection instanceDirection, TransitionDirection defaultDirection)
	{
		TransitionDirection result;
		if (instanceDirection == TransitionDirection.Default)
		{
			if (defaultDirection == TransitionDirection.Default)
			{
				result = TransitionDirection.Forward;
				int num = 0;
				if (!pHv())
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
			}
			else
			{
				result = defaultDirection;
			}
		}
		else
		{
			result = instanceDirection;
		}
		return result;
	}

	protected virtual void OnCompleted(TransitionPresenter presenter, FrameworkElement fromContent, object fromContentData, FrameworkElement toContent, object toContentData)
	{
	}

	protected virtual void OnStarted(TransitionPresenter presenter, FrameworkElement fromContent, FrameworkElement toContent)
	{
		EndTransition(presenter, fromContent, null, toContent, null);
	}

	protected Transition()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	static Transition()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		ClipToBoundsProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(109782), typeof(bool), typeof(Transition), new FrameworkPropertyMetadata(false));
		IsToContentTopMostProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(109810), typeof(bool), typeof(Transition), new FrameworkPropertyMetadata(true));
	}

	internal static bool pHv()
	{
		return xHd == null;
	}

	internal static Transition tHa()
	{
		return xHd;
	}
}
