using System;
using System.Windows;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Data.Filtering;

namespace ActiproSoftware.Windows.Controls.Grids.PropertyData;

public class PropertyModelStringFilter : StringFilterBase
{
	public static readonly DependencyProperty SourceProperty;

	internal static PropertyModelStringFilter QFZ;

	public PropertyModelStringFilterSource Source
	{
		get
		{
			return (PropertyModelStringFilterSource)GetValue(SourceProperty);
		}
		set
		{
			SetValue(SourceProperty, value);
		}
	}

	internal static void LEI(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((PropertyModelStringFilter)P_0).RaiseFilterChangedEvent();
	}

	public override DataFilterResult Filter(object item, object context)
	{
		if (item is IPropertyModel propertyModel)
		{
			bool flag;
			switch (Source)
			{
			case PropertyModelStringFilterSource.Category:
				flag = FilterByString(propertyModel.Category, base.Value);
				break;
			case PropertyModelStringFilterSource.Description:
				flag = FilterByString(propertyModel.Description, base.Value);
				break;
			case PropertyModelStringFilterSource.Name:
				flag = FilterByString(propertyModel.Name, base.Value);
				break;
			case PropertyModelStringFilterSource.ValueType:
			{
				Type valueType = propertyModel.ValueType;
				flag = valueType != null && FilterByString(valueType.Name, base.Value);
				break;
			}
			default:
				flag = FilterByString(propertyModel.DisplayName, base.Value);
				break;
			}
			if (!flag)
			{
				return DataFilterResult.IncludedByDescendants;
			}
			return base.IncludedFilterResult;
		}
		return FallbackFilterResult;
	}

	public PropertyModelStringFilter()
	{
		fc.taYSkz();
		base._002Ector();
	}

	static PropertyModelStringFilter()
	{
		fc.taYSkz();
		SourceProperty = DependencyProperty.Register(xv.hTz(9568), typeof(PropertyModelStringFilterSource), typeof(PropertyModelStringFilter), new PropertyMetadata(PropertyModelStringFilterSource.DisplayName, LEI));
	}

	internal static bool IFx()
	{
		return QFZ == null;
	}

	internal static PropertyModelStringFilter SFS()
	{
		return QFZ;
	}
}
