using System.Diagnostics.CodeAnalysis;
using System.Windows;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Data.Filtering;

public abstract class BooleanFilterBase : DataFilterBase
{
	public static readonly DependencyProperty OperationProperty;

	public static readonly DependencyProperty ValueProperty;

	internal static BooleanFilterBase SOB;

	public BooleanFilterOperation Operation
	{
		get
		{
			return (BooleanFilterOperation)GetValue(OperationProperty);
		}
		set
		{
			SetValue(OperationProperty, value);
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1721:PropertyNamesShouldNotMatchGetMethods")]
	public bool Value
	{
		get
		{
			return (bool)GetValue(ValueProperty);
		}
		set
		{
			SetValue(ValueProperty, value);
		}
	}

	protected virtual bool FilterByBoolean(bool source)
	{
		bool value = Value;
		return Operation switch
		{
			BooleanFilterOperation.Xor => source ^ value, 
			BooleanFilterOperation.Or => source || value, 
			BooleanFilterOperation.Equals => source == value, 
			BooleanFilterOperation.And => source && value, 
			BooleanFilterOperation.NotEquals => source != value, 
			_ => false, 
		};
	}

	protected BooleanFilterBase()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	static BooleanFilterBase()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		OperationProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(112766), typeof(BooleanFilterOperation), typeof(BooleanFilterBase), new PropertyMetadata(BooleanFilterOperation.Equals, DataFilterBase.OnFilterRelatedPropertyValueChanged));
		ValueProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(112788), typeof(bool), typeof(BooleanFilterBase), new PropertyMetadata(true, DataFilterBase.OnFilterRelatedPropertyValueChanged));
	}

	internal static bool xOA()
	{
		return SOB == null;
	}

	internal static BooleanFilterBase SOV()
	{
		return SOB;
	}
}
