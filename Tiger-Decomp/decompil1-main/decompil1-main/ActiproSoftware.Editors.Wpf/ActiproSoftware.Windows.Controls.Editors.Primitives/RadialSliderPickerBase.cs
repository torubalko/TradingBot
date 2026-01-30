using System.Windows;
using System.Windows.Input;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Editors.Primitives;

public abstract class RadialSliderPickerBase : PickerBase
{
	public static readonly DependencyProperty DegreeLargeChangeProperty;

	public static readonly DependencyProperty DegreeMaximumProperty;

	public static readonly DependencyProperty DegreeMinimumProperty;

	public static readonly DependencyProperty DegreeSmallChangeProperty;

	public static readonly DependencyProperty DegreeValueProperty;

	public static readonly DependencyProperty SetValueAndClosePopupCommandProperty;

	public static readonly DependencyProperty SmallDecrementValueCommandProperty;

	public static readonly DependencyProperty SmallIncrementValueCommandProperty;

	internal static RadialSliderPickerBase gh9;

	public double DegreeLargeChange
	{
		get
		{
			return (double)GetValue(DegreeLargeChangeProperty);
		}
		set
		{
			SetValue(DegreeLargeChangeProperty, value);
		}
	}

	public double DegreeMaximum
	{
		get
		{
			return (double)GetValue(DegreeMaximumProperty);
		}
		set
		{
			SetValue(DegreeMaximumProperty, value);
		}
	}

	public double DegreeMinimum
	{
		get
		{
			return (double)GetValue(DegreeMinimumProperty);
		}
		set
		{
			SetValue(DegreeMinimumProperty, value);
		}
	}

	public double DegreeSmallChange
	{
		get
		{
			return (double)GetValue(DegreeSmallChangeProperty);
		}
		set
		{
			SetValue(DegreeSmallChangeProperty, value);
		}
	}

	public double DegreeValue
	{
		get
		{
			return (double)GetValue(DegreeValueProperty);
		}
		set
		{
			SetValue(DegreeValueProperty, value);
		}
	}

	public ICommand SetValueAndClosePopupCommand
	{
		get
		{
			return (ICommand)GetValue(SetValueAndClosePopupCommandProperty);
		}
		set
		{
			SetValue(SetValueAndClosePopupCommandProperty, value);
		}
	}

	public ICommand SmallDecrementValueCommand
	{
		get
		{
			return (ICommand)GetValue(SmallDecrementValueCommandProperty);
		}
		set
		{
			SetValue(SmallDecrementValueCommandProperty, value);
		}
	}

	public ICommand SmallIncrementValueCommand
	{
		get
		{
			return (ICommand)GetValue(SmallIncrementValueCommandProperty);
		}
		set
		{
			SetValue(SmallIncrementValueCommandProperty, value);
		}
	}

	protected RadialSliderPickerBase()
	{
		awj.QuEwGz();
		base._002Ector();
	}

	static RadialSliderPickerBase()
	{
		awj.QuEwGz();
		DegreeLargeChangeProperty = DependencyProperty.Register(QdM.AR8(25980), typeof(double), typeof(RadialSliderPickerBase), new PropertyMetadata(6.0));
		DegreeMaximumProperty = DependencyProperty.Register(QdM.AR8(26018), typeof(double), typeof(RadialSliderPickerBase), new PropertyMetadata(0.0));
		DegreeMinimumProperty = DependencyProperty.Register(QdM.AR8(26048), typeof(double), typeof(RadialSliderPickerBase), new PropertyMetadata(0.0));
		DegreeSmallChangeProperty = DependencyProperty.Register(QdM.AR8(26078), typeof(double), typeof(RadialSliderPickerBase), new PropertyMetadata(1.0));
		DegreeValueProperty = DependencyProperty.Register(QdM.AR8(26116), typeof(double), typeof(RadialSliderPickerBase), new PropertyMetadata(0.0));
		SetValueAndClosePopupCommandProperty = DependencyProperty.Register(QdM.AR8(26142), typeof(ICommand), typeof(RadialSliderPickerBase), new PropertyMetadata(null));
		SmallDecrementValueCommandProperty = DependencyProperty.Register(QdM.AR8(26202), typeof(ICommand), typeof(RadialSliderPickerBase), new PropertyMetadata(null));
		SmallIncrementValueCommandProperty = DependencyProperty.Register(QdM.AR8(26258), typeof(ICommand), typeof(RadialSliderPickerBase), new PropertyMetadata(null));
	}

	internal static bool ghM()
	{
		return gh9 == null;
	}

	internal static RadialSliderPickerBase hhT()
	{
		return gh9;
	}
}
