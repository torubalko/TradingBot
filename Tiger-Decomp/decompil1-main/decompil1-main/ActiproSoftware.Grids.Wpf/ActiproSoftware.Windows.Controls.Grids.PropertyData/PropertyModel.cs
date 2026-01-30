using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.Grids.PropertyEditors;
using ActiproSoftware.Windows.Input;

namespace ActiproSoftware.Windows.Controls.Grids.PropertyData;

[ContentProperty("ValuePropertyEditor")]
[ToolboxItem(false)]
public class PropertyModel : FrameworkElement, INotifyPropertyChanged, IPropertyModel, IDataModel, IDisposable, IDataErrorInfo
{
	[CompilerGenerated]
	private sealed class _003CGetErrorMessages_003Ed__61 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IDisposable, IEnumerator
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private string columnName;

		public string _003C_003E3__columnName;

		public PropertyModel _003C_003E4__this;

		private static _003CGetErrorMessages_003Ed__61 GRT;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public _003CGetErrorMessages_003Ed__61(int _003C_003E1__state)
		{
			fc.taYSkz();
			base._002Ector();
			this._003C_003E1__state = _003C_003E1__state;
			_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			int num = _003C_003E1__state;
			PropertyModel propertyModel = _003C_003E4__this;
			int num2;
			IDataErrorInfo dataErrorInfo = default(IDataErrorInfo);
			int num3 = default(int);
			switch (num)
			{
			default:
				num2 = 1;
				if (ERO() != null)
				{
					goto IL_0005;
				}
				goto IL_0009;
			case 2:
				_003C_003E1__state = -1;
				break;
			case 1:
				_003C_003E1__state = -1;
				break;
			case 0:
				{
					_003C_003E1__state = -1;
					string text = columnName;
					if (!(text == xv.hTz(8634)) && !(text == xv.hTz(8648)))
					{
						if (columnName == null)
						{
							dataErrorInfo = propertyModel.Target as IDataErrorInfo;
							if (dataErrorInfo == null)
							{
								break;
							}
							num2 = 0;
							if (ERO() != null)
							{
								goto IL_0005;
							}
							goto IL_0009;
						}
						break;
					}
					if (propertyModel.Target is IDataErrorInfo dataErrorInfo2)
					{
						_003C_003E2__current = dataErrorInfo2[propertyModel.Name];
						_003C_003E1__state = 1;
						return true;
					}
					break;
				}
				IL_0005:
				num2 = num3;
				goto IL_0009;
				IL_0009:
				switch (num2)
				{
				default:
					_003C_003E2__current = dataErrorInfo.Error;
					_003C_003E1__state = 2;
					return true;
				case 1:
					return false;
				}
			}
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		[DebuggerHidden]
		IEnumerator<object> IEnumerable<object>.GetEnumerator()
		{
			_003CGetErrorMessages_003Ed__61 _003CGetErrorMessages_003Ed__;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				_003CGetErrorMessages_003Ed__ = this;
			}
			else
			{
				_003CGetErrorMessages_003Ed__ = new _003CGetErrorMessages_003Ed__61(0)
				{
					_003C_003E4__this = _003C_003E4__this
				};
			}
			_003CGetErrorMessages_003Ed__.columnName = _003C_003E3__columnName;
			return _003CGetErrorMessages_003Ed__;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<object>)this).GetEnumerator();
		}

		internal static bool AR7()
		{
			return GRT == null;
		}

		internal static _003CGetErrorMessages_003Ed__61 ERO()
		{
			return GRT;
		}
	}

	private DelegateCommand<object> Ap8;

	private DataModelCollection Ep9;

	private bool Xp3;

	private bool IpL;

	private WeakReference Ypj;

	private DelegateCommand<object> Cpx;

	private DelegateCommand<object> spa;

	public static readonly DependencyProperty CanAutoConfigureProperty;

	public static readonly DependencyProperty CanResetValueProperty;

	public static readonly DependencyProperty CategoryProperty;

	public static readonly DependencyProperty ConverterProperty;

	public static readonly DependencyProperty DefaultValueProperty;

	public static readonly DependencyProperty DescriptionProperty;

	public static readonly DependencyProperty DisplayNameProperty;

	public static readonly DependencyProperty IsExpandedProperty;

	public static readonly DependencyProperty IsHostReadOnlyProperty;

	public static readonly DependencyProperty IsImmutableProperty;

	public static readonly DependencyProperty IsLimitedToStandardValuesProperty;

	public static readonly DependencyProperty IsModifiedProperty;

	public static readonly DependencyProperty IsReadOnlyProperty;

	public static readonly DependencyProperty IsSelectedProperty;

	public static readonly DependencyProperty IsValueReadOnlyProperty;

	public static readonly DependencyProperty NamePropertyEditorProperty;

	public static readonly DependencyProperty NameTemplateProperty;

	public static readonly DependencyProperty NameTemplateKeyProperty;

	public static readonly DependencyProperty NameTemplateSelectorProperty;

	public static readonly DependencyProperty SortComparerProperty;

	public static readonly DependencyProperty SortImportanceProperty;

	public static readonly DependencyProperty SortOrderProperty;

	public static readonly DependencyProperty StandardValuesProperty;

	public static readonly DependencyProperty StandardValuesAsStringsProperty;

	public static readonly DependencyProperty StandardValuesDisplayMemberPathProperty;

	public static readonly DependencyProperty StandardValuesSelectedValuePathProperty;

	public static readonly DependencyProperty TargetProperty;

	public static readonly DependencyProperty TargetTypeProperty;

	public static readonly DependencyProperty ValueProperty;

	public static readonly DependencyProperty ValuePropertyEditorProperty;

	public static readonly DependencyProperty ValueTemplateProperty;

	public static readonly DependencyProperty ValueTemplateKeyProperty;

	public static readonly DependencyProperty ValueTemplateKindProperty;

	public static readonly DependencyProperty ValueTemplateSelectorProperty;

	public static readonly DependencyProperty ValueTypeProperty;

	private static PropertyModel SFh;

	bool IPropertyModel.CanResetValue => CanResetValue;

	bool IDataModel.IsInitialized
	{
		get
		{
			return Xp3;
		}
		set
		{
			Xp3 = value;
		}
	}

	bool IDataModel.IsRoot => IsRoot;

	string IDataModel.Name => base.Name;

	IDataModel IDataModel.Parent
	{
		get
		{
			return dpw();
		}
		set
		{
			if (dpw() != value)
			{
				ypX(value);
				if (value == null && CanAutoDispose)
				{
					Dispose(disposing: true);
				}
			}
		}
	}

	string IDataErrorInfo.Error => GetErrorMessages(null)?.OfType<string>().FirstOrDefault();

	string IDataErrorInfo.this[string propertyName] => GetErrorMessages(propertyName)?.OfType<string>().FirstOrDefault();

	public ICommand AddChildCommand
	{
		get
		{
			if (Ap8 == null)
			{
				Ap8 = new DelegateCommand<object>(delegate
				{
					AddChild();
				}, (object P_0) => CanAddChild);
			}
			return Ap8;
		}
	}

	public virtual bool CanAddChild => false;

	public bool CanAutoConfigure
	{
		get
		{
			return (bool)GetValue(CanAutoConfigureProperty);
		}
		set
		{
			SetValue(CanAutoConfigureProperty, value);
		}
	}

	public bool CanAutoDispose => false;

	public virtual bool CanRemove => false;

	public bool CanResetValue
	{
		get
		{
			return (bool)GetValue(CanResetValueProperty);
		}
		set
		{
			SetValue(CanResetValueProperty, value);
		}
	}

	public string Category
	{
		get
		{
			return (string)GetValue(CategoryProperty);
		}
		set
		{
			SetValue(CategoryProperty, value);
		}
	}

	public DataModelCollection Children
	{
		get
		{
			if (Ep9 == null)
			{
				Ep9 = new DataModelCollection();
				Ep9.CollectionChanged += Upp;
			}
			return Ep9;
		}
	}

	public TypeConverter Converter
	{
		get
		{
			return (TypeConverter)GetValue(ConverterProperty);
		}
		set
		{
			SetValue(ConverterProperty, value);
		}
	}

	public object DefaultValue
	{
		get
		{
			return GetValue(DefaultValueProperty);
		}
		set
		{
			SetValue(DefaultValueProperty, value);
		}
	}

	public string Description
	{
		get
		{
			return (string)GetValue(DescriptionProperty);
		}
		set
		{
			SetValue(DescriptionProperty, value);
		}
	}

	public string DisplayName
	{
		get
		{
			return (string)GetValue(DisplayNameProperty);
		}
		set
		{
			SetValue(DisplayNameProperty, value);
		}
	}

	public virtual bool HasStandardValues
	{
		get
		{
			IEnumerable standardValues = StandardValues;
			if (standardValues != null)
			{
				{
					IEnumerator enumerator = standardValues.GetEnumerator();
					try
					{
						if (enumerator.MoveNext())
						{
							_ = enumerator.Current;
							return true;
						}
					}
					finally
					{
						IDisposable disposable = enumerator as IDisposable;
						if (disposable != null)
						{
							disposable.Dispose();
						}
					}
				}
			}
			return false;
		}
	}

	public bool IsExpanded
	{
		get
		{
			return (bool)GetValue(IsExpandedProperty);
		}
		set
		{
			SetValue(IsExpandedProperty, value);
		}
	}

	public bool IsHostReadOnly
	{
		get
		{
			return (bool)GetValue(IsHostReadOnlyProperty);
		}
		set
		{
			SetValue(IsHostReadOnlyProperty, value);
		}
	}

	public bool IsImmutable
	{
		get
		{
			return (bool)GetValue(IsImmutableProperty);
		}
		set
		{
			SetValue(IsImmutableProperty, value);
		}
	}

	public bool IsLimitedToStandardValues
	{
		get
		{
			return (bool)GetValue(IsLimitedToStandardValuesProperty);
		}
		set
		{
			SetValue(IsLimitedToStandardValuesProperty, value);
		}
	}

	public virtual bool IsMergeable => false;

	public bool IsModified
	{
		get
		{
			return (bool)GetValue(IsModifiedProperty);
		}
		set
		{
			SetValue(IsModifiedProperty, value);
		}
	}

	public bool IsReadOnly
	{
		get
		{
			return (bool)GetValue(IsReadOnlyProperty);
		}
		private set
		{
			SetValue(IsReadOnlyProperty, value);
		}
	}

	protected virtual bool IsRoot => false;

	public bool IsSelected
	{
		get
		{
			return (bool)GetValue(IsSelectedProperty);
		}
		set
		{
			SetValue(IsSelectedProperty, value);
		}
	}

	public bool IsValueReadOnly
	{
		get
		{
			return (bool)GetValue(IsValueReadOnlyProperty);
		}
		set
		{
			SetValue(IsValueReadOnlyProperty, value);
		}
	}

	public PropertyEditor NamePropertyEditor
	{
		get
		{
			return (PropertyEditor)GetValue(NamePropertyEditorProperty);
		}
		set
		{
			SetValue(NamePropertyEditorProperty, value);
		}
	}

	public DataTemplate NameTemplate
	{
		get
		{
			return (DataTemplate)GetValue(NameTemplateProperty);
		}
		set
		{
			SetValue(NameTemplateProperty, value);
		}
	}

	public object NameTemplateKey
	{
		get
		{
			return GetValue(NameTemplateKeyProperty);
		}
		set
		{
			SetValue(NameTemplateKeyProperty, value);
		}
	}

	public DataTemplateSelector NameTemplateSelector
	{
		get
		{
			return (DataTemplateSelector)GetValue(NameTemplateSelectorProperty);
		}
		set
		{
			SetValue(NameTemplateSelectorProperty, value);
		}
	}

	public ICommand RemoveCommand
	{
		get
		{
			if (Cpx == null)
			{
				Cpx = new DelegateCommand<object>(delegate
				{
					Remove();
				}, (object P_0) => CanRemove);
			}
			return Cpx;
		}
	}

	public ICommand ResetValueCommand
	{
		get
		{
			if (spa == null)
			{
				spa = new DelegateCommand<object>(delegate
				{
					ResetValue();
				}, (object P_0) => !IsReadOnly && CanResetValue);
			}
			return spa;
		}
	}

	public virtual bool ShouldNotifyParentOnValueChange => false;

	public DataModelSortComparer SortComparer
	{
		get
		{
			return (DataModelSortComparer)GetValue(SortComparerProperty);
		}
		set
		{
			SetValue(SortComparerProperty, value);
		}
	}

	public virtual DataModelSortImportance SortImportance
	{
		get
		{
			return (DataModelSortImportance)GetValue(SortImportanceProperty);
		}
		set
		{
			SetValue(SortImportanceProperty, value);
		}
	}

	public int SortOrder
	{
		get
		{
			return (int)GetValue(SortOrderProperty);
		}
		set
		{
			SetValue(SortOrderProperty, value);
		}
	}

	public IEnumerable StandardValues
	{
		get
		{
			return (IEnumerable)GetValue(StandardValuesProperty);
		}
		set
		{
			SetValue(StandardValuesProperty, value);
		}
	}

	public IEnumerable<string> StandardValuesAsStrings
	{
		get
		{
			return (IEnumerable<string>)GetValue(StandardValuesAsStringsProperty);
		}
		set
		{
			SetValue(StandardValuesAsStringsProperty, value);
		}
	}

	public string StandardValuesDisplayMemberPath
	{
		get
		{
			return (string)GetValue(StandardValuesDisplayMemberPathProperty);
		}
		set
		{
			SetValue(StandardValuesDisplayMemberPathProperty, value);
		}
	}

	public string StandardValuesSelectedValuePath
	{
		get
		{
			return (string)GetValue(StandardValuesSelectedValuePathProperty);
		}
		set
		{
			SetValue(StandardValuesSelectedValuePathProperty, value);
		}
	}

	public object Target
	{
		get
		{
			return GetValue(TargetProperty);
		}
		set
		{
			SetValue(TargetProperty, value);
		}
	}

	public Type TargetType
	{
		get
		{
			return (Type)GetValue(TargetTypeProperty);
		}
		set
		{
			SetValue(TargetTypeProperty, value);
		}
	}

	public object Value
	{
		get
		{
			return GetValue(ValueProperty);
		}
		set
		{
			SetValue(ValueProperty, value);
		}
	}

	public string ValueAsString
	{
		get
		{
			return ConvertToString(Value);
		}
		set
		{
			Value = ConvertFromString(value);
		}
	}

	public PropertyEditor ValuePropertyEditor
	{
		get
		{
			return (PropertyEditor)GetValue(ValuePropertyEditorProperty);
		}
		set
		{
			SetValue(ValuePropertyEditorProperty, value);
		}
	}

	public virtual IList<object> Values => new object[1] { Value };

	public DataTemplate ValueTemplate
	{
		get
		{
			return (DataTemplate)GetValue(ValueTemplateProperty);
		}
		set
		{
			SetValue(ValueTemplateProperty, value);
		}
	}

	public object ValueTemplateKey
	{
		get
		{
			return GetValue(ValueTemplateKeyProperty);
		}
		set
		{
			SetValue(ValueTemplateKeyProperty, value);
		}
	}

	public DefaultValueTemplateKind ValueTemplateKind
	{
		get
		{
			return (DefaultValueTemplateKind)GetValue(ValueTemplateKindProperty);
		}
		set
		{
			SetValue(ValueTemplateKindProperty, value);
		}
	}

	public DataTemplateSelector ValueTemplateSelector
	{
		get
		{
			return (DataTemplateSelector)GetValue(ValueTemplateSelectorProperty);
		}
		set
		{
			SetValue(ValueTemplateSelectorProperty, value);
		}
	}

	public Type ValueType
	{
		get
		{
			return (Type)GetValue(ValueTypeProperty);
		}
		set
		{
			SetValue(ValueTypeProperty, value);
		}
	}

	public event PropertyChangedEventHandler PropertyChanged;

	protected virtual IEnumerable GetErrorMessages(string columnName)
	{
		if (!(columnName == xv.hTz(8634)) && !(columnName == xv.hTz(8648)))
		{
			if (columnName == null && Target is IDataErrorInfo dataErrorInfo)
			{
				int num = 0;
				if (_003CGetErrorMessages_003Ed__61.ERO() != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				case 1:
					yield break;
				}
				yield return dataErrorInfo.Error;
			}
		}
		else if (Target is IDataErrorInfo dataErrorInfo2)
		{
			yield return dataErrorInfo2[base.Name];
		}
	}

	private void EpW()
	{
		NotifyPropertyChanged(xv.hTz(8536));
		NotifyPropertyChanged(xv.hTz(8568));
	}

	private void hpn()
	{
		NotifyPropertyChanged(xv.hTz(8634));
		NotifyPropertyChanged(xv.hTz(8648));
		NotifyPropertyChanged(xv.hTz(8678));
		NotifyPropertyChanged(xv.hTz(8380));
		NotifyPropertyChanged(xv.hTz(8184));
		if (dpw() is IPropertyModel propertyModel && ShouldNotifyParentOnValueChange)
		{
			propertyModel.Refresh(PropertyRefreshReason.ChildPropertyValueChanged);
		}
	}

	private void Upp(object P_0, NotifyCollectionChangedEventArgs P_1)
	{
		if (P_1 == null)
		{
			return;
		}
		IList oldItems = P_1.OldItems;
		if (oldItems != null)
		{
			foreach (object item in oldItems)
			{
				if (item is IDataModel dataModel && dataModel.Parent == this)
				{
					dataModel.Parent = null;
				}
			}
		}
		IList newItems = P_1.NewItems;
		if (newItems == null)
		{
			return;
		}
		foreach (object item2 in newItems)
		{
			if (item2 is IDataModel dataModel2)
			{
				dataModel2.Parent = this;
			}
		}
	}

	private static void EpE(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((PropertyModel)P_0).NotifyPropertyChanged(xv.hTz(8184));
	}

	private static void CpC(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((PropertyModel)P_0).NotifyPropertyChanged(xv.hTz(7754));
	}

	private static void upK(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((PropertyModel)P_0).NotifyPropertyChanged(xv.hTz(3132));
	}

	private static void CpN(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((PropertyModel)P_0).NotifyPropertyChanged(xv.hTz(8300));
	}

	private static void vpl(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((PropertyModel)P_0).NotifyPropertyChanged(xv.hTz(8380));
	}

	private static void fpg(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((PropertyModel)P_0).NotifyPropertyChanged(xv.hTz(890));
	}

	private static void Tpm(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((PropertyModel)P_0).NotifyPropertyChanged(xv.hTz(3156));
	}

	private static void bpT(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((PropertyModel)P_0).epB();
	}

	private static void Lpo(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((PropertyModel)P_0).NotifyPropertyChanged(xv.hTz(8536));
	}

	private static void PpY(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((PropertyModel)P_0).NotifyPropertyChanged(xv.hTz(8568));
	}

	private static void Apk(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((PropertyModel)P_0).dpR();
	}

	private static void zpQ(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		PropertyModel propertyModel = (PropertyModel)P_0;
		if (propertyModel.IpL)
		{
			return;
		}
		object newValue = P_1.NewValue;
		PropertyModelValueChangeEventArgs e = new PropertyModelValueChangeEventArgs(propertyModel, newValue);
		propertyModel.RaisePropertyValueChangingEvent(e);
		int num = 0;
		if (vFq() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (!e.Cancel)
		{
			propertyModel.Refresh(PropertyRefreshReason.ValueChanged);
			propertyModel.RaisePropertyValueChangedEvent(new PropertyModelValueChangeEventArgs(propertyModel, newValue));
		}
		else
		{
			propertyModel.wpd(P_1.OldValue);
		}
	}

	private static void qpy(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((PropertyModel)P_0).NotifyPropertyChanged(xv.hTz(8694));
	}

	[SpecialName]
	private IDataModel dpw()
	{
		if (Ypj != null)
		{
			if (Ypj.IsAlive)
			{
				return Ypj.Target as IDataModel;
			}
			Ypj = null;
		}
		return null;
	}

	[SpecialName]
	private void ypX(IDataModel value)
	{
		if (dpw() != value)
		{
			Ypj = ((value != null) ? new WeakReference(value) : null);
		}
	}

	internal void wpd(object P_0)
	{
		try
		{
			IpL = true;
			Value = P_0;
		}
		finally
		{
			IpL = false;
		}
	}

	private void epB()
	{
		DataModelSortComparer sortComparer = SortComparer;
		if (sortComparer == null || Ep9 == null || Ep9.Count <= 0)
		{
			return;
		}
		List<IDataModel> list = new List<IDataModel>(Ep9);
		list.Sort(sortComparer);
		int num3 = default(int);
		for (int num = Ep9.Count - 1; num >= 0; num--)
		{
			IDataModel dataModel = list[num];
			IDataModel dataModel2 = Ep9[num];
			if (dataModel != dataModel2)
			{
				int num2 = 0;
				if (vFq() != null)
				{
					num2 = num3;
				}
				switch (num2)
				{
				default:
				{
					int num4 = Ep9.IndexOf(dataModel);
					if (num4 != -1)
					{
						Ep9.Move(num4, num);
					}
					break;
				}
				}
			}
		}
	}

	private void dpR()
	{
		bool flag = false;
		if (IsHostReadOnly || IsValueReadOnly)
		{
			flag = true;
		}
		for (IDataModel dataModel = dpw(); dataModel != null; dataModel = dataModel.Parent)
		{
			if (dataModel is IPropertyModel { IsImmutable: not false })
			{
				flag = true;
			}
		}
		int num = 0;
		if (!zFu())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (IsReadOnly != flag)
		{
			IsReadOnly = flag;
		}
	}

	public virtual void AddChild()
	{
		throw new NotImplementedException();
	}

	[SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "string")]
	protected virtual object ConvertFromString(string stringValue)
	{
		TypeConverter converter = Converter;
		ITypeDescriptorContext context = this as ITypeDescriptorContext;
		if (converter != null && converter.CanConvertFrom(context, typeof(string)))
		{
			return converter.ConvertFrom(context, null, stringValue);
		}
		Type valueType = ValueType;
		if (valueType == null || valueType == typeof(string) || valueType == typeof(object))
		{
			return stringValue;
		}
		return null;
	}

	protected virtual string ConvertToString(object value)
	{
		TypeConverter converter = Converter;
		ITypeDescriptorContext context = this as ITypeDescriptorContext;
		if (converter != null && converter.CanConvertTo(context, typeof(string)))
		{
			return converter.ConvertTo(context, null, value, typeof(string)) as string;
		}
		return value?.ToString();
	}

	public virtual bool CycleToNextStandardValue()
	{
		if (!IsReadOnly)
		{
			IEnumerable standardValues = StandardValues;
			if (standardValues != null)
			{
				object[] array = standardValues.OfType<object>().ToArray();
				if (array.Length != 0)
				{
					int num = Array.IndexOf(array, Value);
					if (num < array.Length - 1)
					{
						Value = array[num + 1];
					}
					else
					{
						Value = array[0];
					}
					return true;
				}
			}
		}
		return false;
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (disposing)
		{
			this.Xn8();
		}
	}

	protected void NotifyPropertyChanged(string propertyName)
	{
		OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
	}

	protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
	{
		string propertyName = default(string);
		int num;
		if (e != null)
		{
			propertyName = e.PropertyName;
			if (!(propertyName == xv.hTz(8136)))
			{
				num = 0;
				if (!zFu())
				{
					int num2 = default(int);
					num = num2;
				}
				goto IL_0009;
			}
			if (Ap8 != null)
			{
				Ap8.RaiseCanExecuteChanged();
			}
		}
		goto IL_001b;
		IL_001b:
		PropertyChangedEventHandler propertyChangedEventHandler = this.PropertyChanged;
		num = 1;
		if (!zFu())
		{
			num = 1;
		}
		goto IL_0009;
		IL_0009:
		switch (num)
		{
		case 1:
			propertyChangedEventHandler?.Invoke(this, e);
			return;
		}
		if (propertyName == xv.hTz(8162))
		{
			if (Cpx != null)
			{
				Cpx.RaiseCanExecuteChanged();
			}
		}
		else if ((propertyName == xv.hTz(8184) || propertyName == xv.hTz(890)) && spa != null)
		{
			spa.RaiseCanExecuteChanged();
		}
		goto IL_001b;
	}

	[SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate")]
	protected void RaiseChildPropertyAddedEvent(PropertyModelChildChangeEventArgs e)
	{
		if (!IsRoot)
		{
			this.zn3()?.sE1(e);
		}
	}

	[SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate")]
	protected void RaiseChildPropertyAddingEvent(PropertyModelChildChangeEventArgs e)
	{
		if (!IsRoot)
		{
			this.zn3()?.AEt(e);
		}
	}

	[SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate")]
	protected void RaiseChildPropertyRemovedEvent(PropertyModelChildChangeEventArgs e)
	{
		if (!IsRoot)
		{
			this.zn3()?.PEU(e);
		}
	}

	[SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate")]
	protected void RaiseChildPropertyRemovingEvent(PropertyModelChildChangeEventArgs e)
	{
		if (!IsRoot)
		{
			this.zn3()?.pE6(e);
		}
	}

	[SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate")]
	protected void RaisePropertyValueChangedEvent(PropertyModelValueChangeEventArgs e)
	{
		if (!IsRoot)
		{
			this.zn3()?.CEq(e);
		}
	}

	[SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate")]
	protected void RaisePropertyValueChangingEvent(PropertyModelValueChangeEventArgs e)
	{
		if (!IsRoot)
		{
			this.zn3()?.sEJ(e);
		}
	}

	public virtual void Refresh(PropertyRefreshReason reason)
	{
		switch (reason)
		{
		case PropertyRefreshReason.ValueChanged:
		case PropertyRefreshReason.CollectionItemAdded:
		case PropertyRefreshReason.CollectionItemRemoved:
			hpn();
			RefreshChildren();
			break;
		case PropertyRefreshReason.ChildPropertyValueChanged:
			hpn();
			break;
		case PropertyRefreshReason.StandardValuesChanged:
			EpW();
			break;
		}
	}

	protected virtual void RefreshChildren()
	{
		Xp3 = false;
		this.zn3()?.gEP(this);
	}

	public virtual void Remove()
	{
		throw new NotImplementedException();
	}

	public virtual void ResetValue()
	{
		throw new NotImplementedException();
	}

	public override string ToString()
	{
		return string.Format(CultureInfo.InvariantCulture, xv.hTz(8910), new object[2]
		{
			GetType().Name,
			base.Name
		});
	}

	public PropertyModel()
	{
		fc.taYSkz();
		base._002Ector();
	}

	static PropertyModel()
	{
		int num = 1;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					TargetTypeProperty = DependencyProperty.Register(xv.hTz(9502), typeof(Type), typeof(PropertyModel), new PropertyMetadata(typeof(object)));
					ValueProperty = DependencyProperty.Register(xv.hTz(8634), typeof(object), typeof(PropertyModel), new PropertyMetadata(null, zpQ));
					ValuePropertyEditorProperty = DependencyProperty.Register(xv.hTz(9526), typeof(PropertyEditor), typeof(PropertyModel), new PropertyMetadata(null));
					ValueTemplateProperty = DependencyProperty.Register(xv.hTz(1456), typeof(DataTemplate), typeof(PropertyModel), new PropertyMetadata(null));
					ValueTemplateKeyProperty = DependencyProperty.Register(xv.hTz(8014), typeof(object), typeof(PropertyModel), new PropertyMetadata(null));
					ValueTemplateKindProperty = DependencyProperty.Register(xv.hTz(8050), typeof(DefaultValueTemplateKind), typeof(PropertyModel), new PropertyMetadata(DefaultValueTemplateKind.None));
					ValueTemplateSelectorProperty = DependencyProperty.Register(xv.hTz(1486), typeof(DataTemplateSelector), typeof(PropertyModel), new PropertyMetadata(null));
					ValueTypeProperty = DependencyProperty.Register(xv.hTz(8694), typeof(Type), typeof(PropertyModel), new PropertyMetadata(null, qpy));
					return;
				case 4:
					IsHostReadOnlyProperty = DependencyProperty.Register(xv.hTz(9298), typeof(bool), typeof(PropertyModel), new PropertyMetadata(false, Apk));
					IsImmutableProperty = DependencyProperty.Register(xv.hTz(8274), typeof(bool), typeof(PropertyModel), new PropertyMetadata(false, Apk));
					IsLimitedToStandardValuesProperty = DependencyProperty.Register(xv.hTz(8300), typeof(bool), typeof(PropertyModel), new PropertyMetadata(false, CpN));
					IsModifiedProperty = DependencyProperty.Register(xv.hTz(8380), typeof(bool), typeof(PropertyModel), new PropertyMetadata(false, vpl));
					IsReadOnlyProperty = DependencyProperty.Register(xv.hTz(890), typeof(bool), typeof(PropertyModel), new PropertyMetadata(false, fpg));
					IsSelectedProperty = DependencyProperty.Register(xv.hTz(3156), typeof(bool), typeof(PropertyModel), new PropertyMetadata(false, Tpm));
					IsValueReadOnlyProperty = DependencyProperty.Register(xv.hTz(8102), typeof(bool), typeof(PropertyModel), new PropertyMetadata(false, Apk));
					NamePropertyEditorProperty = DependencyProperty.Register(xv.hTz(9330), typeof(PropertyEditor), typeof(PropertyModel), new PropertyMetadata(null));
					NameTemplateProperty = DependencyProperty.Register(xv.hTz(1154), typeof(DataTemplate), typeof(PropertyModel), new PropertyMetadata(null));
					NameTemplateKeyProperty = DependencyProperty.Register(xv.hTz(7980), typeof(object), typeof(PropertyModel), new PropertyMetadata(null));
					NameTemplateSelectorProperty = DependencyProperty.Register(xv.hTz(1182), typeof(DataTemplateSelector), typeof(PropertyModel), new PropertyMetadata(null));
					SortComparerProperty = DependencyProperty.Register(xv.hTz(1272), typeof(DataModelSortComparer), typeof(PropertyModel), new PropertyMetadata(null, bpT));
					SortImportanceProperty = DependencyProperty.Register(xv.hTz(8482), typeof(DataModelSortImportance), typeof(PropertyModel), new PropertyMetadata(DataModelSortImportance.Property));
					SortOrderProperty = DependencyProperty.Register(xv.hTz(8514), typeof(int), typeof(PropertyModel), new PropertyMetadata(0));
					num2 = 2;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 2:
					StandardValuesProperty = DependencyProperty.Register(xv.hTz(8536), typeof(IEnumerable), typeof(PropertyModel), new PropertyMetadata(null, Lpo));
					StandardValuesAsStringsProperty = DependencyProperty.Register(xv.hTz(8568), typeof(IEnumerable<string>), typeof(PropertyModel), new PropertyMetadata(null, PpY));
					StandardValuesDisplayMemberPathProperty = DependencyProperty.Register(xv.hTz(9370), typeof(string), typeof(PropertyModel), new PropertyMetadata(null));
					StandardValuesSelectedValuePathProperty = DependencyProperty.Register(xv.hTz(9436), typeof(string), typeof(PropertyModel), new PropertyMetadata(null));
					TargetProperty = DependencyProperty.Register(xv.hTz(8618), typeof(object), typeof(PropertyModel), new PropertyMetadata(null));
					num2 = 3;
					continue;
				default:
					CanAutoConfigureProperty = DependencyProperty.Register(xv.hTz(9234), typeof(bool), typeof(PropertyModel), new PropertyMetadata(false));
					CanResetValueProperty = DependencyProperty.Register(xv.hTz(8184), typeof(bool), typeof(PropertyModel), new PropertyMetadata(false, EpE));
					CategoryProperty = DependencyProperty.Register(xv.hTz(7708), typeof(string), typeof(PropertyModel), new PropertyMetadata(null));
					ConverterProperty = DependencyProperty.Register(xv.hTz(8214), typeof(TypeConverter), typeof(PropertyModel), new PropertyMetadata(null));
					DefaultValueProperty = DependencyProperty.Register(xv.hTz(9270), typeof(object), typeof(PropertyModel), new PropertyMetadata(null));
					DescriptionProperty = DependencyProperty.Register(xv.hTz(7728), typeof(string), typeof(PropertyModel), new PropertyMetadata(null));
					DisplayNameProperty = DependencyProperty.Register(xv.hTz(7754), typeof(string), typeof(PropertyModel), new PropertyMetadata(null, CpC));
					IsExpandedProperty = DependencyProperty.Register(xv.hTz(3132), typeof(bool), typeof(PropertyModel), new PropertyMetadata(false, upK));
					num2 = 4;
					continue;
				case 1:
					fc.taYSkz();
					num2 = 0;
					if (0 == 0)
					{
						continue;
					}
					break;
				}
				break;
			}
		}
	}

	[SpecialName]
	object IDataModel.get_Tag()
	{
		return base.Tag;
	}

	[SpecialName]
	void IDataModel.set_Tag(object value)
	{
		base.Tag = value;
	}

	[CompilerGenerated]
	private void apM(object P_0)
	{
		AddChild();
	}

	[CompilerGenerated]
	private bool qpe(object P_0)
	{
		return CanAddChild;
	}

	[CompilerGenerated]
	private void rpr(object P_0)
	{
		Remove();
	}

	[CompilerGenerated]
	private bool rpG(object P_0)
	{
		return CanRemove;
	}

	[CompilerGenerated]
	private void vpu(object P_0)
	{
		ResetValue();
	}

	[CompilerGenerated]
	private bool zpO(object P_0)
	{
		if (!IsReadOnly)
		{
			return CanResetValue;
		}
		return false;
	}

	internal static bool zFu()
	{
		return SFh == null;
	}

	internal static PropertyModel vFq()
	{
		return SFh;
	}
}
