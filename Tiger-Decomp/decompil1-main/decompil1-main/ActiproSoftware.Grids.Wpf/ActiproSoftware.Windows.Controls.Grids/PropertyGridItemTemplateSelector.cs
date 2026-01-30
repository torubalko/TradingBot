using System.Windows;
using System.Windows.Controls;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.Grids.PropertyData;

namespace ActiproSoftware.Windows.Controls.Grids;

public class PropertyGridItemTemplateSelector : DataTemplateSelector
{
	private static PropertyGridItemTemplateSelector qM;

	public override DataTemplate SelectTemplate(object item, DependencyObject container)
	{
		if (item is ICategoryEditorModel categoryEditorModel)
		{
			if (categoryEditorModel.EditorTemplate != null)
			{
				return categoryEditorModel.EditorTemplate;
			}
			PropertyGrid propertyGrid = categoryEditorModel.En9();
			if (propertyGrid != null && categoryEditorModel.EditorTemplateKey != null && propertyGrid.FindResource(categoryEditorModel.EditorTemplateKey) is DataTemplate result)
			{
				return result;
			}
		}
		return null;
	}

	public PropertyGridItemTemplateSelector()
	{
		fc.taYSkz();
		base._002Ector();
	}

	internal static bool oy()
	{
		return qM == null;
	}

	internal static PropertyGridItemTemplateSelector xf()
	{
		return qM;
	}
}
