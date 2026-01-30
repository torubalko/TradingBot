using System.Windows;
using System.Windows.Controls;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.Grids.PropertyData;
using ActiproSoftware.Windows.Controls.Grids.PropertyEditors;

namespace ActiproSoftware.Windows.Controls.Grids;

public class PropertyGridNameTemplateSelector : DataTemplateSelector
{
	private static PropertyGridNameTemplateSelector lo;

	public override DataTemplate SelectTemplate(object item, DependencyObject container)
	{
		if (item is IPropertyModel propertyModel)
		{
			if (propertyModel.NameTemplate != null)
			{
				propertyModel.NamePropertyEditor = null;
				return propertyModel.NameTemplate;
			}
			if (propertyModel.NameTemplateSelector != null)
			{
				propertyModel.NamePropertyEditor = null;
				return propertyModel.NameTemplateSelector.SelectTemplate(item, container);
			}
			PropertyGrid propertyGrid = propertyModel.En9();
			if (propertyGrid != null)
			{
				if (propertyModel.NameTemplateKey != null && propertyGrid.FindResource(propertyModel.NameTemplateKey) is DataTemplate result)
				{
					propertyModel.NamePropertyEditor = null;
					return result;
				}
				PropertyEditorCollection propertyEditors = propertyGrid.PropertyEditors;
				if (propertyEditors != null)
				{
					PropertyEditor propertyEditor = propertyModel.NamePropertyEditor ?? propertyEditors.GetNameEditor(propertyModel);
					if (propertyEditor != null)
					{
						if (propertyEditor.NameTemplate != null)
						{
							propertyModel.NamePropertyEditor = propertyEditor;
							return propertyEditor.NameTemplate;
						}
						if (propertyEditor.NameTemplateSelector != null)
						{
							propertyModel.NamePropertyEditor = propertyEditor;
							return propertyEditor.NameTemplateSelector.SelectTemplate(item, container);
						}
						if (propertyEditor.NameTemplateKey != null && propertyGrid.FindResource(propertyEditor.NameTemplateKey) is DataTemplate result2)
						{
							propertyModel.NamePropertyEditor = propertyEditor;
							return result2;
						}
					}
				}
				propertyModel.NamePropertyEditor = null;
				return propertyGrid.DefaultStringNameTemplate;
			}
		}
		return null;
	}

	public PropertyGridNameTemplateSelector()
	{
		fc.taYSkz();
		base._002Ector();
	}

	internal static bool HZ()
	{
		return lo == null;
	}

	internal static PropertyGridNameTemplateSelector Hx()
	{
		return lo;
	}
}
