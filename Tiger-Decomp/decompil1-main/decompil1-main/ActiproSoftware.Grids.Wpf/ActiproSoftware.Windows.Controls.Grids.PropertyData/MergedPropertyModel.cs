using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.Grids.PropertyEditors;

namespace ActiproSoftware.Windows.Controls.Grids.PropertyData;

public class MergedPropertyModel : CachedPropertyModelBase
{
	private bool tn0;

	private bool SnA;

	private IList<IPropertyModel> an4;

	internal static MergedPropertyModel lFk;

	protected override bool CanResetValueCore
	{
		get
		{
			foreach (IPropertyModel item in an4)
			{
				if (!item.CanResetValue)
				{
					return false;
				}
			}
			return true;
		}
	}

	protected override string CategoryCore => an4[0].Category;

	protected override TypeConverter ConverterCore => an4[0].Converter;

	protected override string DescriptionCore => an4[0].Description;

	protected override string DisplayNameCore => an4[0].DisplayName;

	public override bool HasStandardValues => an4[0].HasStandardValues;

	protected override bool IsImmutableCore
	{
		get
		{
			foreach (IPropertyModel item in an4)
			{
				if (item.IsImmutable)
				{
					return true;
				}
			}
			return false;
		}
	}

	protected override bool IsLimitedToStandardValuesCore
	{
		get
		{
			foreach (IPropertyModel item in an4)
			{
				if (item.IsLimitedToStandardValues)
				{
					return true;
				}
			}
			return false;
		}
	}

	protected override bool IsMergeableCore => false;

	protected override bool IsModifiedCore
	{
		get
		{
			foreach (IPropertyModel item in an4)
			{
				if (item.IsModified)
				{
					return true;
				}
			}
			return false;
		}
	}

	protected override bool IsValueReadOnlyCore
	{
		get
		{
			foreach (IPropertyModel item in an4)
			{
				if (item.IsValueReadOnly)
				{
					return true;
				}
			}
			return false;
		}
	}

	protected override string NameCore => an4[0].Name;

	protected override DataTemplate NameTemplateCore => an4[0].NameTemplate;

	protected override object NameTemplateKeyCore => an4[0].NameTemplateKey;

	protected override DataTemplateSelector NameTemplateSelectorCore => an4[0].NameTemplateSelector;

	protected override bool ShouldNotifyParentOnValueChangeCore
	{
		get
		{
			foreach (IPropertyModel item in an4)
			{
				if (!item.ShouldNotifyParentOnValueChange)
				{
					return true;
				}
			}
			return false;
		}
	}

	protected override DataModelSortImportance SortImportanceCore => an4[0].SortImportance;

	protected override int SortOrderCore => an4[0].SortOrder;

	protected override IEnumerable StandardValuesCore => an4[0].StandardValues;

	public override IEnumerable<string> StandardValuesAsStrings => an4[0].StandardValuesAsStrings;

	protected override object TargetCore
	{
		get
		{
			object[] array = new object[an4.Count];
			for (int num = an4.Count - 1; num >= 0; num--)
			{
				array[num] = an4[num].Target;
			}
			return array;
		}
	}

	public override Type TargetType
	{
		get
		{
			Type type = an4[0].TargetType;
			if (type != null)
			{
				for (int num = an4.Count - 1; num >= 1; num--)
				{
					Type targetType = an4[num].TargetType;
					while (!targetType.IsSubclassOf(type))
					{
						type = type.BaseType;
						if (type == null || type == typeof(object))
						{
							return typeof(object);
						}
					}
				}
			}
			return type;
		}
	}

	protected override object ValueCore
	{
		get
		{
			object value = an4[0].Value;
			if (value != null)
			{
				for (int num = an4.Count - 1; num >= 1; num--)
				{
					if (!value.Equals(an4[num].Value))
					{
						return null;
					}
				}
			}
			return value;
		}
		set
		{
			try
			{
				SnA = true;
				foreach (IPropertyModel item in an4)
				{
					item.Value = value;
				}
			}
			finally
			{
				SnA = false;
			}
		}
	}

	protected override IList<object> ValuesCore
	{
		get
		{
			object[] array = new object[an4.Count];
			for (int num = an4.Count - 1; num >= 0; num--)
			{
				array[num] = an4[num].Value;
			}
			return array;
		}
	}

	protected override DataTemplate ValueTemplateCore => an4[0].ValueTemplate;

	protected override object ValueTemplateKeyCore => an4[0].ValueTemplateKey;

	protected override DefaultValueTemplateKind ValueTemplateKindCore => an4[0].ValueTemplateKind;

	protected override DataTemplateSelector ValueTemplateSelectorCore => an4[0].ValueTemplateSelector;

	protected override Type ValueTypeCore => an4[0].ValueType;

	public MergedPropertyModel(IList<IPropertyModel> propertyModels)
	{
		fc.taYSkz();
		base._002Ector();
		if (propertyModels == null)
		{
			throw new ArgumentNullException(xv.hTz(8940));
		}
		if (propertyModels.Count == 0)
		{
			throw new ArgumentException(xv.hTz(8972), xv.hTz(8940));
		}
		foreach (IPropertyModel propertyModel in propertyModels)
		{
			if (propertyModel == null)
			{
				throw new ArgumentNullException(xv.hTz(8940), xv.hTz(9060));
			}
		}
		an4 = propertyModels;
		Fnc();
		base.NamePropertyEditor = propertyModels[0].NamePropertyEditor;
		base.StandardValuesDisplayMemberPath = propertyModels[0].StandardValuesDisplayMemberPath;
		base.StandardValuesSelectedValuePath = propertyModels[0].StandardValuesSelectedValuePath;
		base.ValuePropertyEditor = propertyModels[0].ValuePropertyEditor;
	}

	private void Fnc()
	{
		if (tn0)
		{
			return;
		}
		foreach (IPropertyModel item in an4)
		{
			if (item is INotifyPropertyChanged notifyPropertyChanged)
			{
				notifyPropertyChanged.PropertyChanged += Enf;
			}
		}
		tn0 = true;
	}

	private void enV()
	{
		if (!tn0)
		{
			return;
		}
		foreach (IPropertyModel item in an4)
		{
			if (item is INotifyPropertyChanged notifyPropertyChanged)
			{
				notifyPropertyChanged.PropertyChanged -= Enf;
			}
		}
		tn0 = false;
	}

	private void Enf(object P_0, PropertyChangedEventArgs P_1)
	{
		if (P_1 != null && P_1.PropertyName == xv.hTz(8634) && !SnA)
		{
			Refresh(PropertyRefreshReason.ValueChanged);
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			enV();
		}
		base.Dispose(disposing);
	}

	protected override IEnumerable GetErrorMessages(string columnName)
	{
		bool errorMessageYielded = false;
		foreach (IPropertyModel item in an4)
		{
			if (item is IDataErrorInfo dataErrorInfo)
			{
				string text = ((columnName != null) ? dataErrorInfo[columnName] : dataErrorInfo.Error);
				if (!string.IsNullOrEmpty(text))
				{
					errorMessageYielded = true;
					yield return text;
				}
			}
			if (errorMessageYielded)
			{
				break;
			}
		}
	}

	public override void ResetValue()
	{
		foreach (IPropertyModel item in an4)
		{
			item.ResetValue();
		}
	}

	internal static bool DFm()
	{
		return lFk == null;
	}

	internal static MergedPropertyModel FFi()
	{
		return lFk;
	}
}
