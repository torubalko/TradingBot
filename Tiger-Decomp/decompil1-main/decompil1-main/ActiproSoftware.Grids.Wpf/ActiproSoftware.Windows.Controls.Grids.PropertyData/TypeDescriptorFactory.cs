using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Data;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Grids.PropertyData;

public class TypeDescriptorFactory : DataFactoryBase
{
	private static ExpandableObjectConverter UEK;

	private static TypeDescriptorFactory AFV;

	private static bool LEC(object P_0, PropertyPath P_1, out object P_2, out Type P_3, out string P_4)
	{
		P_2 = null;
		P_3 = null;
		P_4 = null;
		string[] array;
		int num;
		if (P_0 != null && P_1 != null)
		{
			string path = P_1.Path;
			if (!string.IsNullOrEmpty(path))
			{
				array = path.Split(new char[1] { '.' }, StringSplitOptions.RemoveEmptyEntries);
				num = 1;
				if (!EFp())
				{
					goto IL_0005;
				}
				goto IL_0009;
			}
		}
		goto IL_002d;
		IL_0005:
		int num2 = default(int);
		num = num2;
		goto IL_0009;
		IL_0009:
		string text = default(string);
		DependencyProperty dependencyProperty = default(DependencyProperty);
		int num3 = default(int);
		while (true)
		{
			switch (num)
			{
			case 2:
				break;
			case 1:
				goto IL_00b6;
			default:
				P_2 = P_0;
				P_3 = P_0.GetType();
				P_4 = text;
				return true;
			}
			P_2 = P_0;
			P_3 = dependencyProperty.OwnerType;
			P_4 = dependencyProperty.Name;
			if (num3 == array.Length - 1)
			{
				return true;
			}
			goto IL_00f7;
			IL_00b6:
			if (array.Length == 0)
			{
				break;
			}
			num3 = 0;
			while (num3 < array.Length)
			{
				text = array[num3];
				if (text == null || !text.StartsWith(xv.hTz(9222), StringComparison.Ordinal) || !text.EndsWith(xv.hTz(9228), StringComparison.Ordinal))
				{
					if (num3 != array.Length - 1)
					{
						PropertyInfo property = P_0.GetType().GetProperty(text);
						if (property != null)
						{
							P_0 = property.GetValue(P_0, BindingFlags.Instance | BindingFlags.Public, null, null, CultureInfo.CurrentCulture);
							if (P_0 != null)
							{
								num3++;
								continue;
							}
						}
						return false;
					}
					goto IL_0106;
				}
				goto IL_00cb;
			}
			break;
			IL_00f7:
			return false;
			IL_0106:
			num = 0;
			if (EFp())
			{
				continue;
			}
			goto IL_0005;
			IL_00cb:
			if (int.TryParse(text.Substring(1, text.Length - 2), out var result) && result < P_1.PathParameters.Count)
			{
				dependencyProperty = P_1.PathParameters[result] as DependencyProperty;
				if (dependencyProperty != null)
				{
					num = 2;
					continue;
				}
			}
			goto IL_00f7;
		}
		goto IL_002d;
		IL_002d:
		return false;
	}

	protected override void AutoConfigurePropertyModel(PropertyModel propertyModel, IDataFactoryRequest request)
	{
		if (propertyModel == null)
		{
			throw new ArgumentNullException(xv.hTz(3262));
		}
		if (request == null)
		{
			throw new ArgumentNullException(xv.hTz(8834));
		}
		BindingExpression bindingExpression = propertyModel.GetBindingExpression(PropertyModel.ValueProperty);
		if (bindingExpression == null)
		{
			return;
		}
		object dataItem = bindingExpression.DataItem;
		if (dataItem == null)
		{
			return;
		}
		Binding parentBinding = bindingExpression.ParentBinding;
		if (parentBinding == null || !LEC(dataItem, parentBinding.Path, out dataItem, out var type, out var text) || dataItem == null || !(type != null) || string.IsNullOrEmpty(text))
		{
			return;
		}
		Type type2 = dataItem.GetType();
		PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(type);
		if (properties == null)
		{
			return;
		}
		PropertyDescriptor propertyDescriptor = properties[text];
		if (propertyDescriptor == null)
		{
			FieldInfo field = type.GetField(text + xv.hTz(9620));
			if (field != null && field.GetValue(null) is DependencyProperty dependencyProperty)
			{
				try
				{
					propertyDescriptor = DependencyPropertyDescriptor.FromProperty(dependencyProperty, type2);
				}
				catch
				{
				}
			}
		}
		if (propertyDescriptor == null)
		{
			return;
		}
		IPropertyModel propertyModel2 = CreatePropertyModel(dataItem, propertyDescriptor, request);
		if (propertyModel2 != null)
		{
			if (DependencyPropertyHelper.GetValueSource(propertyModel, PropertyModel.TargetProperty).BaseValueSource == BaseValueSource.Default)
			{
				propertyModel.Target = propertyModel2.Target;
			}
			if (DependencyPropertyHelper.GetValueSource(propertyModel, FrameworkElement.NameProperty).BaseValueSource == BaseValueSource.Default)
			{
				propertyModel.Name = text;
			}
			if (DependencyPropertyHelper.GetValueSource(propertyModel, PropertyModel.CategoryProperty).BaseValueSource == BaseValueSource.Default)
			{
				propertyModel.Category = propertyModel2.Category;
			}
			if (DependencyPropertyHelper.GetValueSource(propertyModel, PropertyModel.ConverterProperty).BaseValueSource == BaseValueSource.Default)
			{
				propertyModel.Converter = propertyModel2.Converter;
			}
			if (DependencyPropertyHelper.GetValueSource(propertyModel, PropertyModel.DisplayNameProperty).BaseValueSource == BaseValueSource.Default)
			{
				propertyModel.DisplayName = ((propertyModel2.DisplayName != propertyModel2.Name) ? propertyModel2.DisplayName : GetDisplayNameFromName(text));
			}
			if (DependencyPropertyHelper.GetValueSource(propertyModel, PropertyModel.IsImmutableProperty).BaseValueSource == BaseValueSource.Default)
			{
				propertyModel.IsImmutable = propertyModel2.IsImmutable;
			}
			if (DependencyPropertyHelper.GetValueSource(propertyModel, PropertyModel.IsLimitedToStandardValuesProperty).BaseValueSource == BaseValueSource.Default)
			{
				propertyModel.IsLimitedToStandardValues = propertyModel2.IsLimitedToStandardValues;
			}
			if (DependencyPropertyHelper.GetValueSource(propertyModel, PropertyModel.IsValueReadOnlyProperty).BaseValueSource == BaseValueSource.Default)
			{
				propertyModel.IsValueReadOnly = propertyModel2.IsValueReadOnly;
			}
			if (DependencyPropertyHelper.GetValueSource(propertyModel, PropertyModel.NamePropertyEditorProperty).BaseValueSource == BaseValueSource.Default)
			{
				propertyModel.NamePropertyEditor = propertyModel2.NamePropertyEditor;
			}
			if (DependencyPropertyHelper.GetValueSource(propertyModel, PropertyModel.NameTemplateProperty).BaseValueSource == BaseValueSource.Default)
			{
				propertyModel.NameTemplate = propertyModel2.NameTemplate;
			}
			if (DependencyPropertyHelper.GetValueSource(propertyModel, PropertyModel.NameTemplateKeyProperty).BaseValueSource == BaseValueSource.Default)
			{
				propertyModel.NameTemplateKey = propertyModel2.NameTemplateKey;
			}
			if (DependencyPropertyHelper.GetValueSource(propertyModel, PropertyModel.NameTemplateSelectorProperty).BaseValueSource == BaseValueSource.Default)
			{
				propertyModel.NameTemplateSelector = propertyModel2.NameTemplateSelector;
			}
			if (DependencyPropertyHelper.GetValueSource(propertyModel, PropertyModel.StandardValuesProperty).BaseValueSource == BaseValueSource.Default)
			{
				propertyModel.StandardValues = propertyModel2.StandardValues;
			}
			if (DependencyPropertyHelper.GetValueSource(propertyModel, PropertyModel.StandardValuesAsStringsProperty).BaseValueSource == BaseValueSource.Default)
			{
				propertyModel.StandardValuesAsStrings = propertyModel2.StandardValuesAsStrings;
			}
			if (DependencyPropertyHelper.GetValueSource(propertyModel, PropertyModel.StandardValuesDisplayMemberPathProperty).BaseValueSource == BaseValueSource.Default)
			{
				propertyModel.StandardValuesDisplayMemberPath = propertyModel2.StandardValuesDisplayMemberPath;
			}
			if (DependencyPropertyHelper.GetValueSource(propertyModel, PropertyModel.StandardValuesSelectedValuePathProperty).BaseValueSource == BaseValueSource.Default)
			{
				propertyModel.StandardValuesSelectedValuePath = propertyModel2.StandardValuesSelectedValuePath;
			}
			if (DependencyPropertyHelper.GetValueSource(propertyModel, PropertyModel.TargetTypeProperty).BaseValueSource == BaseValueSource.Default)
			{
				propertyModel.TargetType = propertyModel2.TargetType;
			}
			if (DependencyPropertyHelper.GetValueSource(propertyModel, PropertyModel.ValuePropertyEditorProperty).BaseValueSource == BaseValueSource.Default)
			{
				propertyModel.ValuePropertyEditor = propertyModel2.ValuePropertyEditor;
			}
			if (DependencyPropertyHelper.GetValueSource(propertyModel, PropertyModel.ValueTemplateProperty).BaseValueSource == BaseValueSource.Default)
			{
				propertyModel.ValueTemplate = propertyModel2.ValueTemplate;
			}
			if (DependencyPropertyHelper.GetValueSource(propertyModel, PropertyModel.ValueTemplateKeyProperty).BaseValueSource == BaseValueSource.Default)
			{
				propertyModel.ValueTemplateKey = propertyModel2.ValueTemplateKey;
			}
			if (DependencyPropertyHelper.GetValueSource(propertyModel, PropertyModel.ValueTemplateKindProperty).BaseValueSource == BaseValueSource.Default)
			{
				propertyModel.ValueTemplateKind = propertyModel2.ValueTemplateKind;
			}
			if (DependencyPropertyHelper.GetValueSource(propertyModel, PropertyModel.ValueTemplateSelectorProperty).BaseValueSource == BaseValueSource.Default)
			{
				propertyModel.ValueTemplateSelector = propertyModel2.ValueTemplateSelector;
			}
			if (DependencyPropertyHelper.GetValueSource(propertyModel, PropertyModel.ValueTypeProperty).BaseValueSource == BaseValueSource.Default)
			{
				propertyModel.ValueType = propertyModel2.ValueType;
			}
			propertyModel2.Dispose();
		}
	}

	protected virtual IPropertyModel CreateCollectionPropertyModel(object target, PropertyDescriptor propertyDescriptor, IDataFactoryRequest request)
	{
		bool flag = request != null && request.CollectionPropertyDisplayMode == CollectionPropertyDisplayMode.EditableInline;
		return new CollectionPropertyDescriptorPropertyModel(target, propertyDescriptor, !flag, areItemsReadOnly: false);
	}

	protected virtual IPropertyModel CreatePropertyModel(object target, PropertyDescriptor propertyDescriptor, IDataFactoryRequest request)
	{
		return new PropertyDescriptorPropertyModel(target, propertyDescriptor);
	}

	protected virtual string GetDisplayNameFromName(string name)
	{
		if (!string.IsNullOrEmpty(name))
		{
			name = string.Join(xv.hTz(3106), Regex.Split(name, xv.hTz(9640)));
			name = name[0].ToString().ToUpperInvariant() + name.Substring(1).ToLowerInvariant();
		}
		return name;
	}

	[SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	protected override IList<IPropertyModel> GetPropertyModels(object dataObject, IDataFactoryRequest request)
	{
		if (dataObject == null)
		{
			throw new ArgumentNullException(xv.hTz(3238));
		}
		if (request == null)
		{
			throw new ArgumentNullException(xv.hTz(8834));
		}
		List<IPropertyModel> list = null;
		try
		{
			Type type = dataObject.GetType();
			bool num = request.Parent == null || request.Parent.IsRoot;
			IList list2 = null;
			if (num)
			{
				TypeConverter converter = TypeDescriptor.GetConverter(dataObject);
				list2 = ((converter == null || !converter.GetPropertiesSupported()) ? TypeDescriptor.GetProperties(dataObject, request.BrowsableAttributes?.ToArray()) : converter.GetProperties(null, dataObject, request.BrowsableAttributes?.ToArray()));
			}
			else
			{
				TypeConverter typeConverter = ((request.Parent is IPropertyModel propertyModel) ? propertyModel.Converter : null);
				ITypeDescriptorContext context = request.Parent as ITypeDescriptorContext;
				if (!type.IsPrimitive)
				{
					switch (request.PropertyExpandability)
					{
					case PropertyExpandability.None:
						typeConverter = null;
						break;
					case PropertyExpandability.ForceSimple:
						if (typeConverter == null || typeConverter.GetType() == typeof(TypeConverter))
						{
							typeConverter = UEK;
						}
						break;
					case PropertyExpandability.ForceAlways:
						if (typeConverter == null || !typeConverter.GetPropertiesSupported(context))
						{
							typeConverter = UEK;
						}
						break;
					}
				}
				if (typeConverter != null && typeConverter.GetPropertiesSupported(context))
				{
					list2 = typeConverter.GetProperties(context, dataObject, request.BrowsableAttributes?.ToArray());
				}
			}
			if (list2 != null)
			{
				foreach (PropertyDescriptor item in list2)
				{
					if (item == null)
					{
						continue;
					}
					try
					{
						if (request.AreInheritedPropertiesBrowsable || !(item.ComponentType != null) || !(item.ComponentType != type))
						{
							if (request.AreAttachedPropertiesBrowsable)
							{
								goto IL_0229;
							}
							DependencyPropertyDescriptor dependencyPropertyDescriptor = DependencyPropertyDescriptor.FromProperty(item);
							if (dependencyPropertyDescriptor == null || !dependencyPropertyDescriptor.IsAttached)
							{
								goto IL_0229;
							}
						}
						goto end_IL_01c9;
						IL_0229:
						if (!request.AreReadOnlyPropertiesBrowsable && item.IsReadOnly)
						{
							continue;
						}
						IPropertyModel propertyModel2 = null;
						propertyModel2 = ((request.CollectionPropertyDisplayMode == CollectionPropertyDisplayMode.Default || !u6.KWl(item.PropertyType)) ? CreatePropertyModel(dataObject, item, request) : CreateCollectionPropertyModel(dataObject, item, request));
						if (propertyModel2 != null)
						{
							if (list == null)
							{
								list = new List<IPropertyModel>();
							}
							list.Add(propertyModel2);
						}
						end_IL_01c9:;
					}
					catch (InvalidOperationException)
					{
					}
					catch (TargetInvocationException)
					{
					}
				}
			}
		}
		catch
		{
		}
		return list;
	}

	public TypeDescriptorFactory()
	{
		fc.taYSkz();
		base._002Ector();
	}

	static TypeDescriptorFactory()
	{
		fc.taYSkz();
		UEK = new ExpandableObjectConverter();
	}

	internal static bool EFp()
	{
		return AFV == null;
	}

	internal static TypeDescriptorFactory hFr()
	{
		return AFV;
	}
}
