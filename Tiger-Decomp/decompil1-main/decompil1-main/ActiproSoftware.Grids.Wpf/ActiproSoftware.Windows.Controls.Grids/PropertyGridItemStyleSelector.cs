using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.Grids.PropertyData;

namespace ActiproSoftware.Windows.Controls.Grids;

public class PropertyGridItemStyleSelector : StyleSelector
{
	[CompilerGenerated]
	private Style vPQ;

	[CompilerGenerated]
	private Style EPy;

	[CompilerGenerated]
	private Style gPd;

	internal static PropertyGridItemStyleSelector Il;

	public Style CategoryEditorStyle
	{
		[CompilerGenerated]
		get
		{
			return vPQ;
		}
		[CompilerGenerated]
		set
		{
			vPQ = value;
		}
	}

	public Style CategoryStyle
	{
		[CompilerGenerated]
		get
		{
			return EPy;
		}
		[CompilerGenerated]
		set
		{
			EPy = value;
		}
	}

	public Style PropertyStyle
	{
		[CompilerGenerated]
		get
		{
			return gPd;
		}
		[CompilerGenerated]
		set
		{
			gPd = value;
		}
	}

	public override Style SelectStyle(object item, DependencyObject container)
	{
		if (item is ICategoryModel categoryModel)
		{
			if (CategoryStyle != null)
			{
				return CategoryStyle;
			}
			PropertyGrid propertyGrid = categoryModel.En9();
			if (propertyGrid != null)
			{
				return propertyGrid.DefaultCategoryItemContainerStyle;
			}
		}
		else if (!(item is ICategoryEditorModel categoryEditorModel))
		{
			if (item is IPropertyModel propertyModel)
			{
				if (PropertyStyle != null)
				{
					return PropertyStyle;
				}
				PropertyGrid propertyGrid2 = propertyModel.En9();
				if (propertyGrid2 != null)
				{
					return propertyGrid2.DefaultPropertyItemContainerStyle;
				}
			}
		}
		else
		{
			if (CategoryEditorStyle != null)
			{
				int num = 0;
				if (yY() != null)
				{
					int num2 = default(int);
					num = num2;
				}
				return num switch
				{
					_ => CategoryEditorStyle, 
				};
			}
			PropertyGrid propertyGrid3 = categoryEditorModel.En9();
			if (propertyGrid3 != null)
			{
				return propertyGrid3.DefaultCategoryEditorItemContainerStyle;
			}
		}
		return null;
	}

	public PropertyGridItemStyleSelector()
	{
		fc.taYSkz();
		base._002Ector();
	}

	internal static bool PI()
	{
		return Il == null;
	}

	internal static PropertyGridItemStyleSelector yY()
	{
		return Il;
	}
}
