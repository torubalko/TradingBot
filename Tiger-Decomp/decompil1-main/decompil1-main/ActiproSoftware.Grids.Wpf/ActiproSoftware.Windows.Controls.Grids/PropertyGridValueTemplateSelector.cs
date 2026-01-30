using System.Diagnostics.CodeAnalysis;
using System.Windows;
using System.Windows.Controls;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.Grids.PropertyData;
using ActiproSoftware.Windows.Controls.Grids.PropertyEditors;

namespace ActiproSoftware.Windows.Controls.Grids;

public class PropertyGridValueTemplateSelector : DataTemplateSelector
{
	private static PropertyGridValueTemplateSelector ES;

	[SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
	protected DataTemplate GetDefaultTemplate(PropertyGrid propGrid, DefaultValueTemplateKind kind)
	{
		if (propGrid != null)
		{
			switch (kind)
			{
			case DefaultValueTemplateKind.Boolean:
				return propGrid.DefaultBooleanValueTemplate;
			case DefaultValueTemplateKind.Brush:
				return propGrid.DefaultBrushValueTemplate;
			case DefaultValueTemplateKind.Color:
				return propGrid.DefaultColorValueTemplate;
			case DefaultValueTemplateKind.ExtendedString:
				return propGrid.DefaultExtendedStringValueTemplate;
			case DefaultValueTemplateKind.FontFamily:
				return propGrid.DefaultFontFamilyValueTemplate;
			case DefaultValueTemplateKind.FontStretch:
				return propGrid.DefaultFontStretchValueTemplate;
			case DefaultValueTemplateKind.FontStyle:
				return propGrid.DefaultFontStyleValueTemplate;
			case DefaultValueTemplateKind.FontWeight:
				return propGrid.DefaultFontWeightValueTemplate;
			case DefaultValueTemplateKind.ImmediateString:
				return propGrid.ImmediateStringValueTemplate;
			case DefaultValueTemplateKind.LimitedObject:
				return propGrid.DefaultLimitedObjectValueTemplate;
			case DefaultValueTemplateKind.LimitedString:
				return propGrid.DefaultLimitedStringValueTemplate;
			case DefaultValueTemplateKind.NullableBoolean:
				return propGrid.DefaultNullableBooleanValueTemplate;
			case DefaultValueTemplateKind.String:
				return propGrid.DefaultStringValueTemplate;
			case DefaultValueTemplateKind.SuggestedString:
				return propGrid.DefaultSuggestedStringValueTemplate;
			}
		}
		return null;
	}

	public override DataTemplate SelectTemplate(object item, DependencyObject container)
	{
		if (item is IPropertyModel propertyModel)
		{
			if (propertyModel.ValueTemplate != null)
			{
				propertyModel.ValuePropertyEditor = null;
				return propertyModel.ValueTemplate;
			}
			if (propertyModel.ValueTemplateSelector != null)
			{
				propertyModel.ValuePropertyEditor = null;
				return propertyModel.ValueTemplateSelector.SelectTemplate(item, container);
			}
			PropertyGrid propertyGrid = propertyModel.En9();
			if (propertyGrid != null)
			{
				if (propertyModel.ValueTemplateKey != null && propertyGrid.FindResource(propertyModel.ValueTemplateKey) is DataTemplate result)
				{
					propertyModel.ValuePropertyEditor = null;
					return result;
				}
				if (propertyModel.ValueTemplateKind != DefaultValueTemplateKind.None)
				{
					propertyModel.ValuePropertyEditor = null;
					return GetDefaultTemplate(propertyGrid, propertyModel.ValueTemplateKind);
				}
				PropertyEditorCollection propertyEditors = propertyGrid.PropertyEditors;
				if (propertyEditors != null)
				{
					PropertyEditor propertyEditor = propertyModel.ValuePropertyEditor ?? propertyEditors.GetValueEditor(propertyModel);
					if (propertyEditor != null)
					{
						if (propertyEditor.ValueTemplate != null)
						{
							propertyModel.ValuePropertyEditor = propertyEditor;
							return propertyEditor.ValueTemplate;
						}
						if (propertyEditor.ValueTemplateSelector != null)
						{
							propertyModel.ValuePropertyEditor = propertyEditor;
							return propertyEditor.ValueTemplateSelector.SelectTemplate(item, container);
						}
						if (propertyEditor.ValueTemplateKey != null && propertyGrid.FindResource(propertyEditor.ValueTemplateKey) is DataTemplate result2)
						{
							propertyModel.ValuePropertyEditor = propertyEditor;
							return result2;
						}
						if (propertyEditor.ValueTemplateKind != DefaultValueTemplateKind.None)
						{
							propertyModel.ValuePropertyEditor = propertyEditor;
							return GetDefaultTemplate(propertyGrid, propertyEditor.ValueTemplateKind);
						}
					}
				}
				propertyModel.ValuePropertyEditor = null;
				if (propertyModel.HasStandardValues)
				{
					if (propertyModel.IsLimitedToStandardValues)
					{
						return GetDefaultTemplate(propertyGrid, (propertyModel.ValueType == typeof(string)) ? DefaultValueTemplateKind.LimitedString : DefaultValueTemplateKind.LimitedObject);
					}
					return GetDefaultTemplate(propertyGrid, DefaultValueTemplateKind.SuggestedString);
				}
				return GetDefaultTemplate(propertyGrid, DefaultValueTemplateKind.String);
			}
		}
		return null;
	}

	public PropertyGridValueTemplateSelector()
	{
		fc.taYSkz();
		base._002Ector();
	}

	internal static bool I1()
	{
		return ES == null;
	}

	internal static PropertyGridValueTemplateSelector eU()
	{
		return ES;
	}
}
