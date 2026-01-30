using System;
using System.Windows;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Data.Filtering;

public class PredicateFilter : DataFilterBase
{
	public static readonly DependencyProperty PredicateProperty;

	private static PredicateFilter dqN;

	public Predicate<object> Predicate
	{
		get
		{
			return (Predicate<object>)GetValue(PredicateProperty);
		}
		set
		{
			SetValue(PredicateProperty, value);
		}
	}

	public PredicateFilter()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	public PredicateFilter(Predicate<object> predicate)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		this._002Ector();
		Predicate = predicate;
	}

	public override DataFilterResult Filter(object item, object context)
	{
		Predicate<object> predicate = Predicate;
		return (predicate != null) ? (predicate(item) ? base.IncludedFilterResult : DataFilterResult.IncludedByDescendants) : DataFilterResult.Included;
	}

	static PredicateFilter()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		PredicateProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(112868), typeof(Predicate<object>), typeof(PredicateFilter), new PropertyMetadata(null, DataFilterBase.OnFilterRelatedPropertyValueChanged));
	}

	internal static bool xqO()
	{
		return dqN == null;
	}

	internal static PredicateFilter Wqq()
	{
		return dqN;
	}
}
