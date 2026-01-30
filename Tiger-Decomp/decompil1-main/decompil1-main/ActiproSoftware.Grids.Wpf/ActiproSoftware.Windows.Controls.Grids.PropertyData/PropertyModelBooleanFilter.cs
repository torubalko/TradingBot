using System.Windows;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Data.Filtering;

namespace ActiproSoftware.Windows.Controls.Grids.PropertyData;

public class PropertyModelBooleanFilter : BooleanFilterBase
{
	public static readonly DependencyProperty SourceProperty;

	private static PropertyModelBooleanFilter mFj;

	public PropertyModelBooleanFilterSource Source
	{
		get
		{
			return (PropertyModelBooleanFilterSource)GetValue(SourceProperty);
		}
		set
		{
			SetValue(SourceProperty, value);
		}
	}

	internal static void Ppz(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((PropertyModelBooleanFilter)P_0).RaiseFilterChangedEvent();
	}

	public override DataFilterResult Filter(object item, object context)
	{
		if (item is IPropertyModel propertyModel)
		{
			if (Source switch
			{
				PropertyModelBooleanFilterSource.HasStandardValues => FilterByBoolean(propertyModel.HasStandardValues) ? 1 : 0, 
				PropertyModelBooleanFilterSource.IsMergeable => FilterByBoolean(propertyModel.IsMergeable) ? 1 : 0, 
				PropertyModelBooleanFilterSource.IsLimitedToStandardValues => FilterByBoolean(propertyModel.IsLimitedToStandardValues) ? 1 : 0, 
				PropertyModelBooleanFilterSource.IsModified => FilterByBoolean(propertyModel.IsModified) ? 1 : 0, 
				PropertyModelBooleanFilterSource.CanResetValue => FilterByBoolean(propertyModel.CanResetValue) ? 1 : 0, 
				_ => FilterByBoolean(propertyModel.IsReadOnly) ? 1 : 0, 
			} == 0)
			{
				return DataFilterResult.IncludedByDescendants;
			}
			return base.IncludedFilterResult;
		}
		return FallbackFilterResult;
	}

	public PropertyModelBooleanFilter()
	{
		fc.taYSkz();
		base._002Ector();
	}

	static PropertyModelBooleanFilter()
	{
		fc.taYSkz();
		SourceProperty = DependencyProperty.Register(xv.hTz(9568), typeof(PropertyModelBooleanFilterSource), typeof(PropertyModelBooleanFilter), new PropertyMetadata(PropertyModelBooleanFilterSource.IsReadOnly, Ppz));
	}

	internal static bool BFL()
	{
		return mFj == null;
	}

	internal static PropertyModelBooleanFilter iFB()
	{
		return mFj;
	}
}
