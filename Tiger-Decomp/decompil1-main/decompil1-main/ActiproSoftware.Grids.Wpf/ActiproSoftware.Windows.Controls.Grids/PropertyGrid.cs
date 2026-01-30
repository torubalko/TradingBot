using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Threading;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.Grids;
using ActiproSoftware.Windows.Controls.Grids.Automation.Peers;
using ActiproSoftware.Windows.Controls.Grids.PropertyData;
using ActiproSoftware.Windows.Controls.Grids.PropertyEditors;
using ActiproSoftware.Windows.Input;

namespace ActiproSoftware.Windows.Controls.Grids;

[SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling")]
[ContentProperty("Properties")]
public class PropertyGrid : TreeListView, IPropertyEditorsProvider
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass59_0
	{
		public bool Slw;

		internal static _003C_003Ec__DisplayClass59_0 Bco;

		public _003C_003Ec__DisplayClass59_0()
		{
			ActiproSoftware.Internal.fc.taYSkz();
			base._002Ector();
		}

		internal object NlO(oT n)
		{
			if (n.sNm() is IPropertyModel propertyModel)
			{
				propertyModel.IsHostReadOnly = Slw;
			}
			return null;
		}

		internal static bool ecZ()
		{
			return Bco == null;
		}

		internal static _003C_003Ec__DisplayClass59_0 Ucx()
		{
			return Bco;
		}
	}

	[CompilerGenerated]
	private sealed class _003Cget_LogicalChildren_003Ed__149 : IEnumerator<object>, IDisposable, IEnumerator
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PropertyGrid _003C_003E4__this;

		private IEnumerator _003CbaseEnumerator_003E5__2;

		private IEnumerator<IPropertyModel> _003C_003E7__wrap2;

		private static _003Cget_LogicalChildren_003Ed__149 tc5;

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
		public _003Cget_LogicalChildren_003Ed__149(int _003C_003E1__state)
		{
			ActiproSoftware.Internal.fc.taYSkz();
			base._002Ector();
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			int num = _003C_003E1__state;
			if (num == -3 || num == 2)
			{
				try
				{
				}
				finally
				{
					_003C_003Em__Finally1();
				}
			}
		}

		private bool MoveNext()
		{
			try
			{
				int num = _003C_003E1__state;
				PropertyGrid propertyGrid = _003C_003E4__this;
				object current;
				int num2;
				switch (num)
				{
				case 1:
					_003C_003E1__state = -1;
					goto IL_0084;
				default:
					return false;
				case 2:
					_003C_003E1__state = -3;
					goto IL_012d;
				case 0:
					{
						_003C_003E1__state = -1;
						_003CbaseEnumerator_003E5__2 = ((ItemsControl)propertyGrid).LogicalChildren;
						if (_003CbaseEnumerator_003E5__2 == null)
						{
							goto IL_0044;
						}
						goto IL_0084;
					}
					IL_0084:
					while (_003CbaseEnumerator_003E5__2.MoveNext())
					{
						current = _003CbaseEnumerator_003E5__2.Current;
						if (current == null)
						{
							continue;
						}
						goto IL_00ac;
					}
					goto IL_0044;
					IL_0044:
					if (propertyGrid.XL == null)
					{
						goto IL_0142;
					}
					_003C_003E7__wrap2 = propertyGrid.XL.GetEnumerator();
					_003C_003E1__state = -3;
					goto IL_012d;
					IL_0142:
					return false;
					IL_00ac:
					num2 = 1;
					if (Mce() != null)
					{
						int num3 = default(int);
						num2 = num3;
					}
					while (true)
					{
						switch (num2)
						{
						case 2:
							_003C_003E1__state = 1;
							return true;
						case 1:
							goto IL_0191;
						}
						break;
						IL_0191:
						_003C_003E2__current = current;
						num2 = 2;
					}
					goto case 2;
					IL_012d:
					while (_003C_003E7__wrap2.MoveNext())
					{
						if (_003C_003E7__wrap2.Current is DependencyObject dependencyObject)
						{
							_003C_003E2__current = dependencyObject;
							_003C_003E1__state = 2;
							return true;
						}
					}
					_003C_003Em__Finally1();
					_003C_003E7__wrap2 = null;
					goto IL_0142;
				}
			}
			catch
			{
				//try-fault
				((IDisposable)this).Dispose();
				throw;
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
			_003C_003E1__state = -1;
			if (_003C_003E7__wrap2 != null)
			{
				_003C_003E7__wrap2.Dispose();
			}
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		internal static bool tca()
		{
			return tc5 == null;
		}

		internal static _003Cget_LogicalChildren_003Ed__149 Mce()
		{
			return tc5;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass173_0
	{
		public PropertyGrid gli;

		public int olb;

		internal static _003C_003Ec__DisplayClass173_0 ocv;

		public _003C_003Ec__DisplayClass173_0()
		{
			ActiproSoftware.Internal.fc.taYSkz();
			base._002Ector();
		}

		internal void fla()
		{
			if (gli.oj == olb)
			{
				gli.yo();
			}
		}

		internal static bool Bcn()
		{
			return ocv == null;
		}

		internal static _003C_003Ec__DisplayClass173_0 zcw()
		{
			return ocv;
		}
	}

	private cJ k8;

	private CategoryEditorCollection d9;

	private TreeListViewColumn S3;

	private PropertyModelCollection XL;

	private int oj;

	private bool xx;

	private ICommand ba;

	private TreeListViewColumn Ni;

	[SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
	private static readonly IEnumerable<Attribute> Rb;

	internal static readonly string ch;

	public static readonly DependencyProperty AreAttachedPropertiesBrowsableProperty;

	public static readonly DependencyProperty AreCategoriesAutoExpandedProperty;

	public static readonly DependencyProperty AreInheritedPropertiesBrowsableProperty;

	public static readonly DependencyProperty AreNestedCategoriesSupportedProperty;

	public static readonly DependencyProperty ArePropertiesAutoExpandedProperty;

	public static readonly DependencyProperty AreReadOnlyPropertiesBrowsableProperty;

	public static readonly DependencyProperty BrowsableAttributesProperty;

	public static readonly DependencyProperty CanClearDataObjectOnUnloadProperty;

	public static readonly DependencyProperty CanSummaryAutoSizeProperty;

	public static readonly DependencyProperty CollectionPropertyDisplayModeProperty;

	public static readonly DependencyProperty DataFactoryProperty;

	public static readonly DependencyProperty DataObjectProperty;

	public static readonly DependencyProperty DataObjectsProperty;

	public static readonly DependencyProperty DefaultCategoryItemContainerStyleProperty;

	public static readonly DependencyProperty DefaultCategoryEditorItemContainerStyleProperty;

	public static readonly DependencyProperty DefaultPropertyItemContainerStyleProperty;

	public static readonly DependencyProperty IsCategorizedProperty;

	public static readonly DependencyProperty IsReadOnlyProperty;

	public static readonly DependencyProperty IsSummaryResizableProperty;

	public static readonly DependencyProperty IsSummaryToggleAllowedProperty;

	public static readonly DependencyProperty IsSummaryVisibleProperty;

	public static readonly DependencyProperty MiscCategoryNameProperty;

	public static readonly DependencyProperty NameColumnMaxWidthProperty;

	public static readonly DependencyProperty NameContainerStyleProperty;

	public static readonly DependencyProperty NameTemplateProperty;

	public static readonly DependencyProperty NameTemplateSelectorProperty;

	public static readonly DependencyProperty PropertyExpandabilityProperty;

	public static readonly DependencyProperty SortComparerProperty;

	public static readonly DependencyProperty SummaryHeightProperty;

	public static readonly DependencyProperty SummaryTemplateProperty;

	public static readonly DependencyProperty SummaryTemplateSelectorProperty;

	public static readonly DependencyProperty ValueContainerStyleProperty;

	public static readonly DependencyProperty ValueTemplateProperty;

	public static readonly DependencyProperty ValueTemplateSelectorProperty;

	[CompilerGenerated]
	private static PropertyGridItemActionHandlerDictionary qZ;

	[CompilerGenerated]
	private static PropertyGridItemActionHandlerDictionary TH;

	[CompilerGenerated]
	private static PropertyGridItemActionHandlerDictionary tD;

	public static readonly RoutedEvent ChildPropertyAddedEvent;

	public static readonly RoutedEvent ChildPropertyAddingEvent;

	public static readonly RoutedEvent ChildPropertyRemovedEvent;

	public static readonly RoutedEvent ChildPropertyRemovingEvent;

	public static readonly RoutedEvent PropertyValueChangedEvent;

	public static readonly RoutedEvent PropertyValueChangingEvent;

	private ICommand I7;

	private ICommand @is;

	private ICommand EF;

	public static readonly DependencyProperty AreClipboardMenuItemsEnabledProperty;

	public static readonly DependencyProperty IsDefaultItemContextMenuEnabledProperty;

	private PropertyEditorCollection fc;

	private static PropertyEditorCollection gV;

	public static readonly DependencyProperty DefaultBooleanValueTemplateProperty;

	public static readonly DependencyProperty DefaultBrushValueTemplateProperty;

	public static readonly DependencyProperty DefaultColorValueTemplateProperty;

	public static readonly DependencyProperty DefaultExtendedStringValueTemplateProperty;

	public static readonly DependencyProperty DefaultFontFamilyValueTemplateProperty;

	public static readonly DependencyProperty DefaultFontStretchValueTemplateProperty;

	public static readonly DependencyProperty DefaultFontStyleValueTemplateProperty;

	public static readonly DependencyProperty DefaultFontWeightValueTemplateProperty;

	public static readonly DependencyProperty DefaultLimitedObjectValueTemplateProperty;

	public static readonly DependencyProperty DefaultLimitedStringValueTemplateProperty;

	public static readonly DependencyProperty DefaultNullableBooleanValueTemplateProperty;

	public static readonly DependencyProperty DefaultStringNameTemplateProperty;

	public static readonly DependencyProperty DefaultStringValueTemplateProperty;

	public static readonly DependencyProperty DefaultSuggestedStringValueTemplateProperty;

	public static readonly DependencyProperty ImmediateStringValueTemplateProperty;

	private static PropertyGrid rK;

	public int NameColumnIndex
	{
		get
		{
			if (S3 == null)
			{
				return -1;
			}
			return base.Columns.IndexOf(S3);
		}
	}

	public int ValueColumnIndex
	{
		get
		{
			if (Ni == null)
			{
				return -1;
			}
			return base.Columns.IndexOf(Ni);
		}
	}

	public bool AreAttachedPropertiesBrowsable
	{
		get
		{
			return (bool)GetValue(AreAttachedPropertiesBrowsableProperty);
		}
		set
		{
			SetValue(AreAttachedPropertiesBrowsableProperty, value);
		}
	}

	public bool AreCategoriesAutoExpanded
	{
		get
		{
			return (bool)GetValue(AreCategoriesAutoExpandedProperty);
		}
		set
		{
			SetValue(AreCategoriesAutoExpandedProperty, value);
		}
	}

	public bool AreInheritedPropertiesBrowsable
	{
		get
		{
			return (bool)GetValue(AreInheritedPropertiesBrowsableProperty);
		}
		set
		{
			SetValue(AreInheritedPropertiesBrowsableProperty, value);
		}
	}

	public bool AreNestedCategoriesSupported
	{
		get
		{
			return (bool)GetValue(AreNestedCategoriesSupportedProperty);
		}
		set
		{
			SetValue(AreNestedCategoriesSupportedProperty, value);
		}
	}

	public bool ArePropertiesAutoExpanded
	{
		get
		{
			return (bool)GetValue(ArePropertiesAutoExpandedProperty);
		}
		set
		{
			SetValue(ArePropertiesAutoExpandedProperty, value);
		}
	}

	public bool AreReadOnlyPropertiesBrowsable
	{
		get
		{
			return (bool)GetValue(AreReadOnlyPropertiesBrowsableProperty);
		}
		set
		{
			SetValue(AreReadOnlyPropertiesBrowsableProperty, value);
		}
	}

	public IEnumerable<Attribute> BrowsableAttributes
	{
		get
		{
			return (IEnumerable<Attribute>)GetValue(BrowsableAttributesProperty);
		}
		set
		{
			SetValue(BrowsableAttributesProperty, value);
		}
	}

	public static PropertyGridItemActionHandlerDictionary CancelPropertyValueEditHandlers
	{
		[CompilerGenerated]
		get
		{
			return qZ;
		}
		[CompilerGenerated]
		private set
		{
			qZ = value;
		}
	}

	public bool CanClearDataObjectOnUnload
	{
		get
		{
			return (bool)GetValue(CanClearDataObjectOnUnloadProperty);
		}
		set
		{
			SetValue(CanClearDataObjectOnUnloadProperty, value);
		}
	}

	public bool CanSummaryAutoSize
	{
		get
		{
			return (bool)GetValue(CanSummaryAutoSizeProperty);
		}
		set
		{
			SetValue(CanSummaryAutoSizeProperty, value);
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public CategoryEditorCollection CategoryEditors => d9;

	public CollectionPropertyDisplayMode CollectionPropertyDisplayMode
	{
		get
		{
			return (CollectionPropertyDisplayMode)GetValue(CollectionPropertyDisplayModeProperty);
		}
		set
		{
			SetValue(CollectionPropertyDisplayModeProperty, value);
		}
	}

	public static PropertyGridItemActionHandlerDictionary CommitPropertyValueEditHandlers
	{
		[CompilerGenerated]
		get
		{
			return TH;
		}
		[CompilerGenerated]
		private set
		{
			TH = value;
		}
	}

	public IDataFactory DataFactory
	{
		get
		{
			return (IDataFactory)GetValue(DataFactoryProperty);
		}
		set
		{
			SetValue(DataFactoryProperty, value);
		}
	}

	public object DataObject
	{
		get
		{
			return GetValue(DataObjectProperty);
		}
		set
		{
			SetValue(DataObjectProperty, value);
		}
	}

	public IEnumerable DataObjects
	{
		get
		{
			return (IEnumerable)GetValue(DataObjectsProperty);
		}
		set
		{
			SetValue(DataObjectsProperty, value);
		}
	}

	public Style DefaultCategoryItemContainerStyle
	{
		get
		{
			return (Style)GetValue(DefaultCategoryItemContainerStyleProperty);
		}
		set
		{
			SetValue(DefaultCategoryItemContainerStyleProperty, value);
		}
	}

	public Style DefaultCategoryEditorItemContainerStyle
	{
		get
		{
			return (Style)GetValue(DefaultCategoryEditorItemContainerStyleProperty);
		}
		set
		{
			SetValue(DefaultCategoryEditorItemContainerStyleProperty, value);
		}
	}

	public Style DefaultPropertyItemContainerStyle
	{
		get
		{
			return (Style)GetValue(DefaultPropertyItemContainerStyleProperty);
		}
		set
		{
			SetValue(DefaultPropertyItemContainerStyleProperty, value);
		}
	}

	public bool IsCategorized
	{
		get
		{
			return (bool)GetValue(IsCategorizedProperty);
		}
		set
		{
			SetValue(IsCategorizedProperty, value);
		}
	}

	public bool IsReadOnly
	{
		get
		{
			return (bool)GetValue(IsReadOnlyProperty);
		}
		set
		{
			SetValue(IsReadOnlyProperty, value);
		}
	}

	public bool IsSummaryResizable
	{
		get
		{
			return (bool)GetValue(IsSummaryResizableProperty);
		}
		set
		{
			SetValue(IsSummaryResizableProperty, value);
		}
	}

	public bool IsSummaryToggleAllowed
	{
		get
		{
			return (bool)GetValue(IsSummaryToggleAllowedProperty);
		}
		set
		{
			SetValue(IsSummaryToggleAllowedProperty, value);
		}
	}

	public bool IsSummaryVisible
	{
		get
		{
			return (bool)GetValue(IsSummaryVisibleProperty);
		}
		set
		{
			SetValue(IsSummaryVisibleProperty, value);
		}
	}

	protected override IEnumerator LogicalChildren
	{
		get
		{
			IEnumerator baseEnumerator = base.LogicalChildren;
			if (baseEnumerator != null)
			{
				int num2 = default(int);
				while (baseEnumerator.MoveNext())
				{
					object current = baseEnumerator.Current;
					if (current == null)
					{
						continue;
					}
					int num = 1;
					if (_003Cget_LogicalChildren_003Ed__149.Mce() != null)
					{
						num = num2;
					}
					switch (num)
					{
					case 2:
						try
						{
							/*Error near IL_0007: Unexpected return in MoveNext()*/;
						}
						finally
						{
							/*Error: Could not find finallyMethod for state=1.
Possibly this method is affected by a C# compiler bug that causes the finally body
not to run in case of an exception or early 'break;' out of a loop consuming this iterable.*/;
						}
					case 1:
						yield return current;
						/*Error: Unable to find new state assignment for yield return*/;
					}
					goto IL_012d;
				}
			}
			if (XL != null)
			{
				using IEnumerator<IPropertyModel> enumerator = XL.GetEnumerator();
				goto IL_012d;
				IL_012d:
				while (enumerator.MoveNext())
				{
					if (enumerator.Current is DependencyObject dependencyObject)
					{
						yield return dependencyObject;
					}
				}
			}
		}
	}

	[Localizability(LocalizationCategory.Title)]
	public string MiscCategoryName
	{
		get
		{
			return (string)GetValue(MiscCategoryNameProperty);
		}
		set
		{
			SetValue(MiscCategoryNameProperty, value);
		}
	}

	public double NameColumnMaxWidth
	{
		get
		{
			return (double)GetValue(NameColumnMaxWidthProperty);
		}
		set
		{
			SetValue(NameColumnMaxWidthProperty, value);
		}
	}

	public Style NameContainerStyle
	{
		get
		{
			return (Style)GetValue(NameContainerStyleProperty);
		}
		set
		{
			SetValue(NameContainerStyleProperty, value);
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

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public PropertyModelCollection Properties => XL;

	public PropertyExpandability PropertyExpandability
	{
		get
		{
			return (PropertyExpandability)GetValue(PropertyExpandabilityProperty);
		}
		set
		{
			SetValue(PropertyExpandabilityProperty, value);
		}
	}

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

	public static PropertyGridItemActionHandlerDictionary StartPropertyValueEditHandlers
	{
		[CompilerGenerated]
		get
		{
			return tD;
		}
		[CompilerGenerated]
		private set
		{
			tD = value;
		}
	}

	[TypeConverter(typeof(LengthConverter))]
	public double SummaryHeight
	{
		get
		{
			return (double)GetValue(SummaryHeightProperty);
		}
		set
		{
			SetValue(SummaryHeightProperty, value);
		}
	}

	public DataTemplate SummaryTemplate
	{
		get
		{
			return (DataTemplate)GetValue(SummaryTemplateProperty);
		}
		set
		{
			SetValue(SummaryTemplateProperty, value);
		}
	}

	public DataTemplateSelector SummaryTemplateSelector
	{
		get
		{
			return (DataTemplateSelector)GetValue(SummaryTemplateSelectorProperty);
		}
		set
		{
			SetValue(SummaryTemplateSelectorProperty, value);
		}
	}

	public ICommand ToggleSummaryVisibilityCommand
	{
		get
		{
			if (ba == null)
			{
				ba = new DelegateCommand<object>(delegate
				{
					IsSummaryVisible = !IsSummaryVisible;
				});
			}
			return ba;
		}
	}

	public Style ValueContainerStyle
	{
		get
		{
			return (Style)GetValue(ValueContainerStyleProperty);
		}
		set
		{
			SetValue(ValueContainerStyleProperty, value);
		}
	}

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

	public bool AreClipboardMenuItemsEnabled
	{
		get
		{
			return (bool)GetValue(AreClipboardMenuItemsEnabledProperty);
		}
		set
		{
			SetValue(AreClipboardMenuItemsEnabledProperty, value);
		}
	}

	public ICommand CopyDisplayNameCommand
	{
		get
		{
			if (I7 == null)
			{
				I7 = new DelegateCommand<IDataModel>(delegate(IDataModel P_0)
				{
					if (P_0 != null)
					{
						CopyDisplayName(P_0);
					}
				}, (IDataModel m) => m != null);
			}
			return I7;
		}
	}

	public ICommand CopyPropertyValueCommand
	{
		get
		{
			if (@is == null)
			{
				@is = new DelegateCommand<IDataModel>(delegate(IDataModel P_0)
				{
					if (P_0 is IPropertyModel model)
					{
						CopyPropertyValue(model);
					}
				}, (IDataModel p) => p is IPropertyModel);
			}
			return @is;
		}
	}

	public bool IsDefaultItemContextMenuEnabled
	{
		get
		{
			return (bool)GetValue(IsDefaultItemContextMenuEnabledProperty);
		}
		set
		{
			SetValue(IsDefaultItemContextMenuEnabledProperty, value);
		}
	}

	public ICommand PastePropertyValueCommand
	{
		get
		{
			if (EF == null)
			{
				EF = new DelegateCommand<IDataModel>(delegate(IDataModel P_0)
				{
					if (P_0 is IPropertyModel model)
					{
						PastePropertyValue(model);
					}
				}, (IDataModel p) => p is IPropertyModel propertyModel && !propertyModel.IsReadOnly);
			}
			return EF;
		}
	}

	public DataTemplate DefaultBooleanValueTemplate
	{
		get
		{
			return (DataTemplate)GetValue(DefaultBooleanValueTemplateProperty);
		}
		set
		{
			SetValue(DefaultBooleanValueTemplateProperty, value);
		}
	}

	public DataTemplate DefaultBrushValueTemplate
	{
		get
		{
			return (DataTemplate)GetValue(DefaultBrushValueTemplateProperty);
		}
		set
		{
			SetValue(DefaultBrushValueTemplateProperty, value);
		}
	}

	public DataTemplate DefaultColorValueTemplate
	{
		get
		{
			return (DataTemplate)GetValue(DefaultColorValueTemplateProperty);
		}
		set
		{
			SetValue(DefaultColorValueTemplateProperty, value);
		}
	}

	public DataTemplate DefaultExtendedStringValueTemplate
	{
		get
		{
			return (DataTemplate)GetValue(DefaultExtendedStringValueTemplateProperty);
		}
		set
		{
			SetValue(DefaultExtendedStringValueTemplateProperty, value);
		}
	}

	public DataTemplate DefaultFontFamilyValueTemplate
	{
		get
		{
			return (DataTemplate)GetValue(DefaultFontFamilyValueTemplateProperty);
		}
		set
		{
			SetValue(DefaultFontFamilyValueTemplateProperty, value);
		}
	}

	public DataTemplate DefaultFontStretchValueTemplate
	{
		get
		{
			return (DataTemplate)GetValue(DefaultFontStretchValueTemplateProperty);
		}
		set
		{
			SetValue(DefaultFontStretchValueTemplateProperty, value);
		}
	}

	public DataTemplate DefaultFontStyleValueTemplate
	{
		get
		{
			return (DataTemplate)GetValue(DefaultFontStyleValueTemplateProperty);
		}
		set
		{
			SetValue(DefaultFontStyleValueTemplateProperty, value);
		}
	}

	public DataTemplate DefaultFontWeightValueTemplate
	{
		get
		{
			return (DataTemplate)GetValue(DefaultFontWeightValueTemplateProperty);
		}
		set
		{
			SetValue(DefaultFontWeightValueTemplateProperty, value);
		}
	}

	public DataTemplate DefaultLimitedObjectValueTemplate
	{
		get
		{
			return (DataTemplate)GetValue(DefaultLimitedObjectValueTemplateProperty);
		}
		set
		{
			SetValue(DefaultLimitedObjectValueTemplateProperty, value);
		}
	}

	public DataTemplate DefaultLimitedStringValueTemplate
	{
		get
		{
			return (DataTemplate)GetValue(DefaultLimitedStringValueTemplateProperty);
		}
		set
		{
			SetValue(DefaultLimitedStringValueTemplateProperty, value);
		}
	}

	public DataTemplate DefaultNullableBooleanValueTemplate
	{
		get
		{
			return (DataTemplate)GetValue(DefaultNullableBooleanValueTemplateProperty);
		}
		set
		{
			SetValue(DefaultNullableBooleanValueTemplateProperty, value);
		}
	}

	public static PropertyEditorCollection DefaultPropertyEditors
	{
		get
		{
			if (gV == null)
			{
				gV = new PropertyEditorCollection();
				gV.G5l();
			}
			return gV;
		}
	}

	public DataTemplate DefaultStringNameTemplate
	{
		get
		{
			return (DataTemplate)GetValue(DefaultStringNameTemplateProperty);
		}
		set
		{
			SetValue(DefaultStringNameTemplateProperty, value);
		}
	}

	public DataTemplate DefaultStringValueTemplate
	{
		get
		{
			return (DataTemplate)GetValue(DefaultStringValueTemplateProperty);
		}
		set
		{
			SetValue(DefaultStringValueTemplateProperty, value);
		}
	}

	public DataTemplate DefaultSuggestedStringValueTemplate
	{
		get
		{
			return (DataTemplate)GetValue(DefaultSuggestedStringValueTemplateProperty);
		}
		set
		{
			SetValue(DefaultSuggestedStringValueTemplateProperty, value);
		}
	}

	public DataTemplate ImmediateStringValueTemplate
	{
		get
		{
			return (DataTemplate)GetValue(ImmediateStringValueTemplateProperty);
		}
		set
		{
			SetValue(ImmediateStringValueTemplateProperty, value);
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public PropertyEditorCollection PropertyEditors => fc;

	public static object PropertyEditorsModifierKey => xv.hTz(2886);

	public event EventHandler<PropertyModelChildChangeEventArgs> ChildPropertyAdded
	{
		add
		{
			AddHandler(ChildPropertyAddedEvent, value);
		}
		remove
		{
			RemoveHandler(ChildPropertyAddedEvent, value);
		}
	}

	public event EventHandler<PropertyModelChildChangeEventArgs> ChildPropertyAdding
	{
		add
		{
			AddHandler(ChildPropertyAddingEvent, value);
		}
		remove
		{
			RemoveHandler(ChildPropertyAddingEvent, value);
		}
	}

	public event EventHandler<PropertyModelChildChangeEventArgs> ChildPropertyRemoved
	{
		add
		{
			AddHandler(ChildPropertyRemovedEvent, value);
		}
		remove
		{
			RemoveHandler(ChildPropertyRemovedEvent, value);
		}
	}

	public event EventHandler<PropertyModelChildChangeEventArgs> ChildPropertyRemoving
	{
		add
		{
			AddHandler(ChildPropertyRemovingEvent, value);
		}
		remove
		{
			RemoveHandler(ChildPropertyRemovingEvent, value);
		}
	}

	public event EventHandler<PropertyModelValueChangeEventArgs> PropertyValueChanged
	{
		add
		{
			AddHandler(PropertyValueChangedEvent, value);
		}
		remove
		{
			RemoveHandler(PropertyValueChangedEvent, value);
		}
	}

	public event EventHandler<PropertyModelValueChangeEventArgs> PropertyValueChanging
	{
		add
		{
			AddHandler(PropertyValueChangingEvent, value);
		}
		remove
		{
			RemoveHandler(PropertyValueChangingEvent, value);
		}
	}

	[SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline")]
	static PropertyGrid()
	{
		ActiproSoftware.Internal.fc.taYSkz();
		Rb = new Attribute[1] { BrowsableAttribute.Yes };
		ch = CategoryAttribute.Default.Category;
		AreAttachedPropertiesBrowsableProperty = DependencyProperty.Register(xv.hTz(0), typeof(bool), typeof(PropertyGrid), new PropertyMetadata(false, tW));
		AreCategoriesAutoExpandedProperty = DependencyProperty.Register(xv.hTz(64), typeof(bool), typeof(PropertyGrid), new PropertyMetadata(true, z5));
		AreInheritedPropertiesBrowsableProperty = DependencyProperty.Register(xv.hTz(118), typeof(bool), typeof(PropertyGrid), new PropertyMetadata(true, tW));
		AreNestedCategoriesSupportedProperty = DependencyProperty.Register(xv.hTz(184), typeof(bool), typeof(PropertyGrid), new PropertyMetadata(false, tW));
		ArePropertiesAutoExpandedProperty = DependencyProperty.Register(xv.hTz(244), typeof(bool), typeof(PropertyGrid), new PropertyMetadata(false, z5));
		AreReadOnlyPropertiesBrowsableProperty = DependencyProperty.Register(xv.hTz(298), typeof(bool), typeof(PropertyGrid), new PropertyMetadata(true, tW));
		BrowsableAttributesProperty = DependencyProperty.Register(xv.hTz(362), typeof(IEnumerable<Attribute>), typeof(PropertyGrid), new PropertyMetadata(Rb, tW));
		CanClearDataObjectOnUnloadProperty = DependencyProperty.Register(xv.hTz(404), typeof(bool), typeof(PropertyGrid), new PropertyMetadata(false));
		CanSummaryAutoSizeProperty = DependencyProperty.Register(xv.hTz(460), typeof(bool), typeof(PropertyGrid), new PropertyMetadata(false));
		CollectionPropertyDisplayModeProperty = DependencyProperty.Register(xv.hTz(500), typeof(CollectionPropertyDisplayMode), typeof(PropertyGrid), new PropertyMetadata(CollectionPropertyDisplayMode.Default, tW));
		DataFactoryProperty = DependencyProperty.Register(xv.hTz(562), typeof(IDataFactory), typeof(PropertyGrid), new PropertyMetadata(new TypeDescriptorFactory(), tW));
		DataObjectProperty = DependencyProperty.Register(xv.hTz(588), typeof(object), typeof(PropertyGrid), new PropertyMetadata(null, u6));
		DataObjectsProperty = DependencyProperty.Register(xv.hTz(612), typeof(IEnumerable), typeof(PropertyGrid), new PropertyMetadata(null, cJ));
		DefaultCategoryItemContainerStyleProperty = DependencyProperty.Register(xv.hTz(638), typeof(Style), typeof(PropertyGrid), new PropertyMetadata(null));
		DefaultCategoryEditorItemContainerStyleProperty = DependencyProperty.Register(xv.hTz(708), typeof(Style), typeof(PropertyGrid), new PropertyMetadata(null));
		DefaultPropertyItemContainerStyleProperty = DependencyProperty.Register(xv.hTz(790), typeof(Style), typeof(PropertyGrid), new PropertyMetadata(null));
		IsCategorizedProperty = DependencyProperty.Register(xv.hTz(860), typeof(bool), typeof(PropertyGrid), new PropertyMetadata(true, tW));
		IsReadOnlyProperty = DependencyProperty.Register(xv.hTz(890), typeof(bool), typeof(PropertyGrid), new PropertyMetadata(false, pn));
		IsSummaryResizableProperty = DependencyProperty.Register(xv.hTz(914), typeof(bool), typeof(PropertyGrid), new PropertyMetadata(true));
		IsSummaryToggleAllowedProperty = DependencyProperty.Register(xv.hTz(954), typeof(bool), typeof(PropertyGrid), new PropertyMetadata(true));
		IsSummaryVisibleProperty = DependencyProperty.Register(xv.hTz(1002), typeof(bool), typeof(PropertyGrid), new PropertyMetadata(true));
		MiscCategoryNameProperty = DependencyProperty.Register(xv.hTz(1038), typeof(string), typeof(PropertyGrid), new PropertyMetadata(ch, tW));
		NameColumnMaxWidthProperty = DependencyProperty.Register(xv.hTz(1074), typeof(double), typeof(PropertyGrid), new PropertyMetadata(180.0, up));
		NameContainerStyleProperty = DependencyProperty.Register(xv.hTz(1114), typeof(Style), typeof(PropertyGrid), new PropertyMetadata(null, DE));
		NameTemplateProperty = DependencyProperty.Register(xv.hTz(1154), typeof(DataTemplate), typeof(PropertyGrid), new PropertyMetadata(null, UC));
		NameTemplateSelectorProperty = DependencyProperty.Register(xv.hTz(1182), typeof(DataTemplateSelector), typeof(PropertyGrid), new PropertyMetadata(null, JK));
		PropertyExpandabilityProperty = DependencyProperty.Register(xv.hTz(1226), typeof(PropertyExpandability), typeof(PropertyGrid), new PropertyMetadata(PropertyExpandability.Default, tW));
		SortComparerProperty = DependencyProperty.Register(xv.hTz(1272), typeof(DataModelSortComparer), typeof(PropertyGrid), new PropertyMetadata(new DataModelSortComparer(), tW));
		SummaryHeightProperty = DependencyProperty.Register(xv.hTz(1300), typeof(double), typeof(PropertyGrid), new PropertyMetadata(78.0));
		SummaryTemplateProperty = DependencyProperty.Register(xv.hTz(1330), typeof(DataTemplate), typeof(PropertyGrid), new PropertyMetadata(null));
		SummaryTemplateSelectorProperty = DependencyProperty.Register(xv.hTz(1364), typeof(DataTemplateSelector), typeof(PropertyGrid), new PropertyMetadata(null));
		ValueContainerStyleProperty = DependencyProperty.Register(xv.hTz(1414), typeof(Style), typeof(PropertyGrid), new PropertyMetadata(null, ug));
		ValueTemplateProperty = DependencyProperty.Register(xv.hTz(1456), typeof(DataTemplate), typeof(PropertyGrid), new PropertyMetadata(null, km));
		ValueTemplateSelectorProperty = DependencyProperty.Register(xv.hTz(1486), typeof(DataTemplateSelector), typeof(PropertyGrid), new PropertyMetadata(null, oT));
		ChildPropertyAddedEvent = EventManager.RegisterRoutedEvent(xv.hTz(1532), RoutingStrategy.Bubble, typeof(EventHandler<PropertyModelChildChangeEventArgs>), typeof(PropertyGrid));
		ChildPropertyAddingEvent = EventManager.RegisterRoutedEvent(xv.hTz(1572), RoutingStrategy.Bubble, typeof(EventHandler<PropertyModelChildChangeEventArgs>), typeof(PropertyGrid));
		ChildPropertyRemovedEvent = EventManager.RegisterRoutedEvent(xv.hTz(1614), RoutingStrategy.Bubble, typeof(EventHandler<PropertyModelChildChangeEventArgs>), typeof(PropertyGrid));
		ChildPropertyRemovingEvent = EventManager.RegisterRoutedEvent(xv.hTz(1658), RoutingStrategy.Bubble, typeof(EventHandler<PropertyModelChildChangeEventArgs>), typeof(PropertyGrid));
		PropertyValueChangedEvent = EventManager.RegisterRoutedEvent(xv.hTz(1704), RoutingStrategy.Bubble, typeof(EventHandler<PropertyModelValueChangeEventArgs>), typeof(PropertyGrid));
		PropertyValueChangingEvent = EventManager.RegisterRoutedEvent(xv.hTz(1748), RoutingStrategy.Bubble, typeof(EventHandler<PropertyModelValueChangeEventArgs>), typeof(PropertyGrid));
		AreClipboardMenuItemsEnabledProperty = DependencyProperty.Register(xv.hTz(1794), typeof(bool), typeof(PropertyGrid), new PropertyMetadata(true));
		IsDefaultItemContextMenuEnabledProperty = DependencyProperty.Register(xv.hTz(1854), typeof(bool), typeof(PropertyGrid), new PropertyMetadata(true));
		DefaultBooleanValueTemplateProperty = DependencyProperty.Register(xv.hTz(1920), typeof(DataTemplate), typeof(PropertyGrid), new PropertyMetadata(null));
		DefaultBrushValueTemplateProperty = DependencyProperty.Register(xv.hTz(1978), typeof(DataTemplate), typeof(PropertyGrid), new PropertyMetadata(null));
		DefaultColorValueTemplateProperty = DependencyProperty.Register(xv.hTz(2032), typeof(DataTemplate), typeof(PropertyGrid), new PropertyMetadata(null));
		DefaultExtendedStringValueTemplateProperty = DependencyProperty.Register(xv.hTz(2086), typeof(DataTemplate), typeof(PropertyGrid), new PropertyMetadata(null));
		DefaultFontFamilyValueTemplateProperty = DependencyProperty.Register(xv.hTz(2158), typeof(DataTemplate), typeof(PropertyGrid), new PropertyMetadata(null));
		DefaultFontStretchValueTemplateProperty = DependencyProperty.Register(xv.hTz(2222), typeof(DataTemplate), typeof(PropertyGrid), new PropertyMetadata(null));
		DefaultFontStyleValueTemplateProperty = DependencyProperty.Register(xv.hTz(2288), typeof(DataTemplate), typeof(PropertyGrid), new PropertyMetadata(null));
		DefaultFontWeightValueTemplateProperty = DependencyProperty.Register(xv.hTz(2350), typeof(DataTemplate), typeof(PropertyGrid), new PropertyMetadata(null));
		DefaultLimitedObjectValueTemplateProperty = DependencyProperty.Register(xv.hTz(2414), typeof(DataTemplate), typeof(PropertyGrid), new PropertyMetadata(null));
		DefaultLimitedStringValueTemplateProperty = DependencyProperty.Register(xv.hTz(2484), typeof(DataTemplate), typeof(PropertyGrid), new PropertyMetadata(null));
		DefaultNullableBooleanValueTemplateProperty = DependencyProperty.Register(xv.hTz(2554), typeof(DataTemplate), typeof(PropertyGrid), new PropertyMetadata(null));
		DefaultStringNameTemplateProperty = DependencyProperty.Register(xv.hTz(2628), typeof(DataTemplate), typeof(PropertyGrid), new PropertyMetadata(null));
		DefaultStringValueTemplateProperty = DependencyProperty.Register(xv.hTz(2682), typeof(DataTemplate), typeof(PropertyGrid), new PropertyMetadata(null));
		DefaultSuggestedStringValueTemplateProperty = DependencyProperty.Register(xv.hTz(2738), typeof(DataTemplate), typeof(PropertyGrid), new PropertyMetadata(null));
		ImmediateStringValueTemplateProperty = DependencyProperty.Register(xv.hTz(2812), typeof(DataTemplate), typeof(PropertyGrid), new PropertyMetadata(null));
		CancelPropertyValueEditHandlers = PropertyGridItemActionHandlerDictionary.RPn();
		CommitPropertyValueEditHandlers = PropertyGridItemActionHandlerDictionary.XPp();
		StartPropertyValueEditHandlers = PropertyGridItemActionHandlerDictionary.wPE();
	}

	public PropertyGrid()
	{
		ActiproSoftware.Internal.fc.taYSkz();
		base._002Ector();
		base.DefaultStyleKey = typeof(PropertyGrid);
		base.ItemAdapter = new PropertyGridItemAdapter();
		d9 = new CategoryEditorCollection();
		d9.CollectionChanged += IU;
		XL = new PropertyModelCollection();
		XL.CollectionChanged += EN;
		int num = 0;
		if (false)
		{
			int num2;
			num = num2;
		}
		switch (num)
		{
		}
		fc = new PropertyEditorCollection();
		fc.CollectionChanged += Ne;
		tP();
		base.Unloaded += Fl;
	}

	private void tP()
	{
		S3 = new TreeListViewColumn
		{
			CellBorderThickness = new Thickness(0.0, 0.0, 1.0, 0.0),
			CellContainerStyle = NameContainerStyle,
			CellPadding = new Thickness(7.0, 0.0, 0.0, 0.0),
			CellTemplate = NameTemplate,
			CellTemplateSelector = NameTemplateSelector,
			Header = SR.GetString(SRName.UIPropertyGridColumnHeaderNameText),
			Width = new GridLength(1.0, GridUnitType.Star),
			MinWidth = 100.0,
			MaxWidth = Math.Max(16.0, NameColumnMaxWidth)
		};
		Ni = new TreeListViewColumn
		{
			CellContainerStyle = ValueContainerStyle,
			CellPadding = new Thickness(0.0),
			CellTemplate = ValueTemplate,
			CellTemplateSelector = ValueTemplateSelector,
			Header = SR.GetString(SRName.UIPropertyGridColumnHeaderValueText),
			Width = new GridLength(1.0, GridUnitType.Star),
			MinWidth = 60.0
		};
		base.Columns.Clear();
		base.Columns.Add(S3);
		base.Columns.Add(Ni);
	}

	internal cJ F1()
	{
		if (k8 == null)
		{
			IEnumerable<Attribute> browsableAttributes = BrowsableAttributes;
			cJ obj = new cJ();
			obj.AreAttachedPropertiesBrowsable = AreAttachedPropertiesBrowsable;
			obj.AreCategoriesAutoExpanded = AreCategoriesAutoExpanded;
			obj.AreInheritedPropertiesBrowsable = AreInheritedPropertiesBrowsable;
			obj.AreNestedCategoriesSupported = AreNestedCategoriesSupported;
			obj.ArePropertiesAutoExpanded = ArePropertiesAutoExpanded;
			obj.AreReadOnlyPropertiesBrowsable = AreReadOnlyPropertiesBrowsable;
			obj.BrowsableAttributes = browsableAttributes?.ToArray();
			obj.GWF(d9.ToArray());
			obj.CollectionPropertyDisplayMode = CollectionPropertyDisplayMode;
			obj.IsCategorized = IsCategorized;
			obj.IsHostReadOnly = IsReadOnly;
			obj.MiscCategoryName = MiscCategoryName;
			obj.bn1(XL.ToArray());
			obj.PropertyExpandability = PropertyExpandability;
			obj.SortComparer = SortComparer;
			obj.Source = this;
			k8 = obj;
		}
		return k8;
	}

	private void Pt()
	{
		k8 = null;
	}

	private void IU(object P_0, NotifyCollectionChangedEventArgs P_1)
	{
		Pt();
		RequestRefresh();
	}

	private static void u6(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		PropertyGrid propertyGrid = (PropertyGrid)P_0;
		if (propertyGrid.xx)
		{
			return;
		}
		try
		{
			propertyGrid.xx = true;
			if (P_1.NewValue != null)
			{
				propertyGrid.DataObjects = new object[1] { P_1.NewValue };
			}
			else
			{
				propertyGrid.DataObjects = null;
			}
		}
		finally
		{
			propertyGrid.xx = false;
		}
	}

	private void aq(object P_0, NotifyCollectionChangedEventArgs P_1)
	{
		RequestRefresh();
	}

	private static void cJ(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		PropertyGrid propertyGrid = (PropertyGrid)P_0;
		if (!propertyGrid.xx)
		{
			int num = 0;
			if (!mE())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			try
			{
				propertyGrid.xx = true;
				propertyGrid.DataObject = (P_1.NewValue as IEnumerable)?.OfType<object>().FirstOrDefault();
			}
			finally
			{
				propertyGrid.xx = false;
			}
		}
		if (P_1.OldValue is INotifyCollectionChanged notifyCollectionChanged)
		{
			notifyCollectionChanged.CollectionChanged -= propertyGrid.aq;
		}
		if (P_1.NewValue is INotifyCollectionChanged notifyCollectionChanged2)
		{
			notifyCollectionChanged2.CollectionChanged += propertyGrid.aq;
		}
		tW(P_0, P_1);
	}

	private static void z5(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((PropertyGrid)P_0).Pt();
	}

	private static void tW(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		PropertyGrid obj = (PropertyGrid)P_0;
		obj.Pt();
		obj.RequestRefresh();
	}

	private static void pn(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		_003C_003Ec__DisplayClass59_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass59_0();
		PropertyGrid propertyGrid = (PropertyGrid)P_0;
		CS_0024_003C_003E8__locals2.Slw = propertyGrid.IsReadOnly;
		propertyGrid.TP3(null, _0020: false, _0020: false, _0020: false, delegate(oT n)
		{
			if (n.sNm() is IPropertyModel propertyModel)
			{
				propertyModel.IsHostReadOnly = CS_0024_003C_003E8__locals2.Slw;
			}
			return (object)null;
		});
	}

	private static void up(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		PropertyGrid propertyGrid = (PropertyGrid)P_0;
		if (propertyGrid.S3 != null)
		{
			propertyGrid.S3.MaxWidth = Math.Max(16.0, propertyGrid.NameColumnMaxWidth);
		}
	}

	private static void DE(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		PropertyGrid propertyGrid = (PropertyGrid)P_0;
		if (propertyGrid.S3 != null)
		{
			propertyGrid.S3.CellContainerStyle = propertyGrid.NameContainerStyle;
		}
	}

	private static void UC(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		PropertyGrid propertyGrid = (PropertyGrid)P_0;
		if (propertyGrid.S3 != null)
		{
			propertyGrid.S3.CellTemplate = propertyGrid.NameTemplate;
		}
	}

	private static void JK(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		PropertyGrid propertyGrid = (PropertyGrid)P_0;
		if (propertyGrid.S3 != null)
		{
			propertyGrid.S3.CellTemplateSelector = propertyGrid.NameTemplateSelector;
		}
	}

	private void EN(object P_0, NotifyCollectionChangedEventArgs P_1)
	{
		if (P_1 != null)
		{
			if (P_1.OldItems != null)
			{
				foreach (object oldItem in P_1.OldItems)
				{
					if (oldItem is DependencyObject child)
					{
						RemoveLogicalChild(child);
					}
				}
			}
			if (P_1.NewItems != null)
			{
				foreach (object newItem in P_1.NewItems)
				{
					if (newItem is DependencyObject child2)
					{
						AddLogicalChild(child2);
					}
				}
			}
		}
		Pt();
		RequestRefresh();
	}

	private void Fl(object P_0, RoutedEventArgs P_1)
	{
		if (CanClearDataObjectOnUnload)
		{
			DataObject = null;
		}
	}

	private static void ug(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		PropertyGrid propertyGrid = (PropertyGrid)P_0;
		if (propertyGrid.Ni != null)
		{
			propertyGrid.Ni.CellContainerStyle = propertyGrid.ValueContainerStyle;
		}
	}

	private static void km(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		PropertyGrid propertyGrid = (PropertyGrid)P_0;
		if (propertyGrid.Ni != null)
		{
			propertyGrid.Ni.CellTemplate = propertyGrid.ValueTemplate;
		}
	}

	private static void oT(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		PropertyGrid propertyGrid = (PropertyGrid)P_0;
		if (propertyGrid.Ni != null)
		{
			propertyGrid.Ni.CellTemplateSelector = propertyGrid.ValueTemplateSelector;
		}
	}

	private void yo()
	{
		pn pn = base.RootItem as pn;
		IEnumerable dataObjects = DataObjects;
		if (dataObjects == null)
		{
			if (XL.Count <= 0)
			{
				base.RootItem = null;
			}
			else
			{
				base.RootItem = new pn(this, null)
				{
					IsHostReadOnly = IsReadOnly
				};
			}
		}
		else
		{
			base.RootItem = new pn(this, dataObjects.OfType<object>().ToArray())
			{
				IsHostReadOnly = IsReadOnly
			};
		}
		pn?.Dispose();
		LY();
	}

	private void LY()
	{
		IDataModel dataModel = base.Items.OfType<IDataModel>().FirstOrDefault((IDataModel m) => m is IPropertyModel || m is ICategoryEditorModel);
		if (dataModel != null)
		{
			base.SelectedItem = dataModel;
		}
	}

	protected override DependencyObject GetContainerForItemOverride()
	{
		return new PropertyGridItem();
	}

	protected override bool IsItemItsOwnContainerOverride(object item)
	{
		return item is PropertyGridItem;
	}

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		TryFindResource(PropertyEditorsModifierKey);
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		return new PropertyGridAutomationPeer(this);
	}

	protected override void OnKeyDown(KeyEventArgs e)
	{
		if (e != null && !e.Handled)
		{
			int num = 0;
			if (ag() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			if (ActiproSoftware.Internal.LY.hle() != ModifierKeys.Control)
			{
				switch (e.Key)
				{
				case Key.Back:
				case Key.Space:
				case Key.Multiply:
				case Key.Add:
				case Key.Subtract:
				case Key.Divide:
					if (base.SelectedItem is IPropertyModel)
					{
						return;
					}
					break;
				}
			}
		}
		base.OnKeyDown(e);
	}

	public void RequestRefresh()
	{
		_003C_003Ec__DisplayClass173_0 CS_0024_003C_003E8__locals5 = new _003C_003Ec__DisplayClass173_0();
		CS_0024_003C_003E8__locals5.gli = this;
		oj = (oj + 1) % 1000;
		CS_0024_003C_003E8__locals5.olb = oj;
		DispatcherPriority priority = (XL.Any() ? DispatcherPriority.DataBind : DispatcherPriority.Send);
		base.Dispatcher.BeginInvoke(priority, (Action)delegate
		{
			if (CS_0024_003C_003E8__locals5.gli.oj == CS_0024_003C_003E8__locals5.olb)
			{
				CS_0024_003C_003E8__locals5.gli.yo();
			}
		});
	}

	public bool TryCommitPropertyValueEdit()
	{
		object selectedItem = base.SelectedItem;
		if (selectedItem != null && base.ItemContainerGenerator.ContainerFromItem(selectedItem) is PropertyGridItem propertyGridItem)
		{
			return propertyGridItem.TryCommitPropertyValueEdit();
		}
		return false;
	}

	internal void Ik(PropertyModelChildChangeEventArgs P_0)
	{
		if (P_0.RoutedEvent == null)
		{
			P_0.RoutedEvent = ChildPropertyAddedEvent;
		}
		if (P_0.Source == null)
		{
			P_0.Source = this;
		}
		OnChildPropertyAdded(P_0);
		RaiseEvent(P_0);
	}

	internal void PQ(PropertyModelChildChangeEventArgs P_0)
	{
		if (P_0.RoutedEvent == null)
		{
			P_0.RoutedEvent = ChildPropertyAddingEvent;
		}
		if (P_0.Source == null)
		{
			P_0.Source = this;
		}
		OnChildPropertyAdding(P_0);
		RaiseEvent(P_0);
	}

	internal void Ny(PropertyModelChildChangeEventArgs P_0)
	{
		if (P_0.RoutedEvent == null)
		{
			P_0.RoutedEvent = ChildPropertyRemovedEvent;
		}
		if (P_0.Source == null)
		{
			P_0.Source = this;
		}
		OnChildPropertyRemoved(P_0);
		RaiseEvent(P_0);
	}

	internal void ad(PropertyModelChildChangeEventArgs P_0)
	{
		if (P_0.RoutedEvent == null)
		{
			P_0.RoutedEvent = ChildPropertyRemovingEvent;
		}
		if (P_0.Source == null)
		{
			P_0.Source = this;
		}
		OnChildPropertyRemoving(P_0);
		RaiseEvent(P_0);
	}

	internal void zB(PropertyModelValueChangeEventArgs P_0)
	{
		if (P_0.RoutedEvent == null)
		{
			P_0.RoutedEvent = PropertyValueChangedEvent;
		}
		if (P_0.Source == null)
		{
			P_0.Source = this;
		}
		OnPropertyValueChanged(P_0);
		RaiseEvent(P_0);
	}

	internal void DR(PropertyModelValueChangeEventArgs P_0)
	{
		if (P_0.RoutedEvent == null)
		{
			P_0.RoutedEvent = PropertyValueChangingEvent;
		}
		if (P_0.Source == null)
		{
			P_0.Source = this;
		}
		OnPropertyValueChanging(P_0);
		RaiseEvent(P_0);
	}

	protected virtual void OnChildPropertyAdded(PropertyModelChildChangeEventArgs e)
	{
	}

	protected virtual void OnChildPropertyAdding(PropertyModelChildChangeEventArgs e)
	{
	}

	protected virtual void OnChildPropertyRemoved(PropertyModelChildChangeEventArgs e)
	{
	}

	protected virtual void OnChildPropertyRemoving(PropertyModelChildChangeEventArgs e)
	{
	}

	protected virtual void OnPropertyValueChanged(PropertyModelValueChangeEventArgs e)
	{
	}

	protected virtual void OnPropertyValueChanging(PropertyModelValueChangeEventArgs e)
	{
	}

	private ContextMenu mM(IPropertyModel P_0)
	{
		List<object> list = new List<object>();
		if (P_0 != null)
		{
			list.Add(TreeListView.Q6Q(null, SR.GetString(SRName.UICommandResetText), P_0.ResetValueCommand));
			if (AreClipboardMenuItemsEnabled)
			{
				if (list.Count > 0)
				{
					int num = 0;
					if (ag() != null)
					{
						int num2 = default(int);
						num = num2;
					}
					switch (num)
					{
					}
					list.Add(TreeListView.j6y());
				}
				list.Add(TreeListView.Q6Q(null, SR.GetString(SRName.UICommandCopyNameText), CopyDisplayNameCommand, P_0));
				list.Add(TreeListView.Q6Q(null, SR.GetString(SRName.UICommandCopyValueText), CopyPropertyValueCommand, P_0));
				if (!P_0.IsReadOnly)
				{
					list.Add(TreeListView.Q6Q(null, SR.GetString(SRName.UICommandPasteValueText), PastePropertyValueCommand, P_0));
				}
			}
		}
		if (IsSummaryToggleAllowed)
		{
			if (list.Count > 0)
			{
				list.Add(TreeListView.j6y());
			}
			list.Add(TreeListView.Q6Q(null, SR.GetString(SRName.UICommandDescriptionText), ToggleSummaryVisibilityCommand, null, IsSummaryVisible));
		}
		if (list.Count == 0)
		{
			return null;
		}
		return TreeListView.F6k(list);
	}

	[SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
	public void CopyDisplayName(IDataModel model)
	{
		if (model == null)
		{
			throw new ArgumentNullException(xv.hTz(2872));
		}
		if (!(base.ItemAdapter is PropertyGridItemAdapter propertyGridItemAdapter))
		{
			return;
		}
		DataObject dataObject = new DataObject();
		if (!propertyGridItemAdapter.InitializeDataObjectWithDisplayName(this, dataObject, model))
		{
			return;
		}
		try
		{
			Clipboard.SetDataObject(dataObject);
		}
		catch
		{
		}
	}

	[SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
	public void CopyPropertyValue(IPropertyModel model)
	{
		if (model == null)
		{
			throw new ArgumentNullException(xv.hTz(2872));
		}
		if (!(base.ItemAdapter is PropertyGridItemAdapter propertyGridItemAdapter))
		{
			return;
		}
		DataObject dataObject = new DataObject();
		if (!propertyGridItemAdapter.InitializeDataObjectWithPropertyValue(this, dataObject, model))
		{
			return;
		}
		try
		{
			Clipboard.SetDataObject(dataObject);
		}
		catch
		{
		}
	}

	protected override void OnItemMenuRequested(TreeListBoxItemMenuEventArgs e)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				base.OnItemMenuRequested(e);
				num2 = 0;
				if (mE())
				{
					num2 = 0;
				}
				continue;
			}
			if (e == null || e.Cancel || !IsDefaultItemContextMenuEnabled)
			{
				return;
			}
			if (e.PointerLocation.HasValue && e.Item is IPropertyModel && e.Container is PropertyGridItem propertyGridItem)
			{
				Control control = propertyGridItem.U0();
				if (control != null)
				{
					Point point = propertyGridItem.TransformToVisual(control).Transform(e.PointerLocation.Value);
					if (new Rect(0.0, 0.0, control.ActualWidth, control.ActualHeight).Contains(point))
					{
						return;
					}
				}
			}
			e.Menu = mM(e.Item as IPropertyModel);
			return;
		}
	}

	[SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
	public void PastePropertyValue(IPropertyModel model)
	{
		if (model == null)
		{
			throw new ArgumentNullException(xv.hTz(2872));
		}
		if (!model.IsReadOnly && base.ItemAdapter is PropertyGridItemAdapter propertyGridItemAdapter)
		{
			IDataObject dataObject = null;
			try
			{
				dataObject = Clipboard.GetDataObject();
			}
			catch
			{
			}
			if (dataObject != null)
			{
				propertyGridItemAdapter.SetPropertyValueFromDataObject(this, dataObject, model);
			}
		}
	}

	private void Ne(object P_0, NotifyCollectionChangedEventArgs P_1)
	{
		Pt();
		RequestRefresh();
	}

	[DebuggerHidden]
	[CompilerGenerated]
	private IEnumerator Er()
	{
		return base.LogicalChildren;
	}

	[CompilerGenerated]
	private void dG(object P_0)
	{
		IsSummaryVisible = !IsSummaryVisible;
	}

	[CompilerGenerated]
	private void cu(IDataModel P_0)
	{
		if (P_0 != null)
		{
			CopyDisplayName(P_0);
		}
	}

	[CompilerGenerated]
	private void kO(IDataModel P_0)
	{
		if (P_0 is IPropertyModel model)
		{
			CopyPropertyValue(model);
		}
	}

	[CompilerGenerated]
	private void Vw(IDataModel P_0)
	{
		if (P_0 is IPropertyModel model)
		{
			PastePropertyValue(model);
		}
	}

	internal static bool mE()
	{
		return rK == null;
	}

	internal static PropertyGrid ag()
	{
		return rK;
	}
}
