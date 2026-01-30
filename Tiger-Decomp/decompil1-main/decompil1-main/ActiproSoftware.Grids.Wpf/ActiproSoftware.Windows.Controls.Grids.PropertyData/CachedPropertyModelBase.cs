using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.Grids.PropertyEditors;

namespace ActiproSoftware.Windows.Controls.Grids.PropertyData;

[SuppressMessage("Microsoft.Design", "CA1063:ImplementIDisposableCorrectly")]
public abstract class CachedPropertyModelBase : PropertyModelBase, IPropertyModel, IDataModel, IDisposable
{
	[Flags]
	private enum Ny
	{

	}

	private bool x5B;

	private bool w5R;

	private bool b5M;

	private string s5e;

	private TypeConverter T5r;

	private string F5G;

	private string V5u;

	private Ny J5O;

	private bool r5w;

	private bool m5X;

	private bool H52;

	private bool N5v;

	private bool F58;

	private bool S59;

	private bool z53;

	private string C5L;

	private DataTemplate f5j;

	private object y5x;

	private DataTemplateSelector s5a;

	private object g5i;

	private IList<object> x5b;

	private bool Y5h;

	private DataModelSortImportance n5Z;

	private int A5H;

	private IEnumerable w5D;

	private IEnumerable<string> D57;

	private object U5s;

	private string A5F;

	private DataTemplate V5c;

	private object w5V;

	private DefaultValueTemplateKind V5f;

	private DataTemplateSelector m50;

	private Type I5A;

	internal static CachedPropertyModelBase M6W;

	public virtual bool CanAddChild
	{
		get
		{
			if (!J5O.HasFlag((Ny)1))
			{
				x5B = CanAddChildCore;
				m5d((Ny)1, _0020: true);
			}
			return x5B;
		}
	}

	protected virtual bool CanAddChildCore => false;

	protected sealed override bool CanAddChildResolved => CanAddChild;

	public virtual bool CanRemove
	{
		get
		{
			if (!J5O.HasFlag((Ny)2))
			{
				w5R = CanRemoveCore;
				m5d((Ny)2, _0020: true);
			}
			return w5R;
		}
	}

	protected virtual bool CanRemoveCore => false;

	protected sealed override bool CanRemoveResolved => CanRemove;

	public virtual bool CanResetValue
	{
		get
		{
			if (!J5O.HasFlag((Ny)4))
			{
				b5M = CanResetValueCore;
				m5d((Ny)4, _0020: true);
			}
			return b5M;
		}
	}

	protected abstract bool CanResetValueCore { get; }

	protected sealed override bool CanResetValueResolved => CanResetValue;

	public virtual string Category
	{
		get
		{
			if (!J5O.HasFlag((Ny)8))
			{
				s5e = CategoryCore;
				m5d((Ny)8, _0020: true);
			}
			return s5e;
		}
	}

	protected virtual string CategoryCore => null;

	public virtual TypeConverter Converter
	{
		get
		{
			if (!J5O.HasFlag((Ny)16))
			{
				T5r = ConverterCore;
				m5d((Ny)16, _0020: true);
			}
			return T5r;
		}
	}

	protected virtual TypeConverter ConverterCore
	{
		get
		{
			object value = Value;
			if (value != null)
			{
				return TypeDescriptor.GetConverter(value);
			}
			Type valueType = ValueType;
			if (valueType != null)
			{
				return TypeDescriptor.GetConverter(valueType);
			}
			return null;
		}
	}

	protected sealed override TypeConverter ConverterResolved => Converter;

	public virtual string Description
	{
		get
		{
			if (!J5O.HasFlag((Ny)32))
			{
				F5G = DescriptionCore;
				m5d((Ny)32, _0020: true);
			}
			return F5G;
		}
	}

	protected virtual string DescriptionCore => null;

	protected sealed override string DescriptionResolved => Description;

	public virtual string DisplayName
	{
		get
		{
			if (!J5O.HasFlag((Ny)64))
			{
				V5u = DisplayNameCore;
				m5d((Ny)64, _0020: true);
			}
			return V5u;
		}
	}

	protected virtual string DisplayNameCore => Name;

	protected sealed override string DisplayNameResolved => DisplayName;

	public override bool HasStandardValues
	{
		get
		{
			if (!J5O.HasFlag((Ny)128))
			{
				r5w = HasStandardValuesCore;
				m5d((Ny)128, _0020: true);
			}
			return r5w;
		}
	}

	protected virtual bool HasStandardValuesCore => base.HasStandardValues;

	public virtual bool IsImmutable
	{
		get
		{
			if (!J5O.HasFlag((Ny)256))
			{
				m5X = IsImmutableCore;
				m5d((Ny)256, _0020: true);
			}
			return m5X;
		}
	}

	protected virtual bool IsImmutableCore => false;

	protected sealed override bool IsImmutableResolved => IsImmutable;

	public virtual bool IsLimitedToStandardValues
	{
		get
		{
			if (!J5O.HasFlag((Ny)512))
			{
				H52 = IsLimitedToStandardValuesCore;
				m5d((Ny)512, _0020: true);
			}
			return H52;
		}
	}

	protected virtual bool IsLimitedToStandardValuesCore => Converter?.GetStandardValuesExclusive(this as ITypeDescriptorContext) ?? false;

	public virtual bool IsMergeable
	{
		get
		{
			if (!J5O.HasFlag((Ny)1024))
			{
				N5v = IsMergeableCore;
				m5d((Ny)1024, _0020: true);
			}
			return N5v;
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Mergeable")]
	protected abstract bool IsMergeableCore { get; }

	public virtual bool IsModified
	{
		get
		{
			if (!J5O.HasFlag((Ny)2048))
			{
				F58 = IsModifiedCore;
				m5d((Ny)2048, _0020: true);
			}
			return F58;
		}
	}

	protected abstract bool IsModifiedCore { get; }

	protected sealed override bool IsModifiedResolved => IsModified;

	public virtual bool IsValueReadOnly
	{
		get
		{
			if (!J5O.HasFlag((Ny)4096))
			{
				S59 = IsValueReadOnlyCore;
				m5d((Ny)4096, _0020: true);
			}
			if (!S59)
			{
				return z53;
			}
			return true;
		}
		set
		{
			if (z53 != value)
			{
				z53 = value;
				NotifyPropertyChanged(xv.hTz(8102));
				NotifyPropertyChanged(xv.hTz(890));
			}
		}
	}

	protected abstract bool IsValueReadOnlyCore { get; }

	protected sealed override bool IsValueReadOnlyResolved => IsValueReadOnly;

	public virtual string Name
	{
		get
		{
			if (!J5O.HasFlag((Ny)8192))
			{
				C5L = NameCore;
				m5d((Ny)8192, _0020: true);
			}
			return C5L;
		}
	}

	protected abstract string NameCore { get; }

	protected sealed override string NameResolved => Name;

	public virtual DataTemplate NameTemplate
	{
		get
		{
			if (!J5O.HasFlag((Ny)16384))
			{
				f5j = NameTemplateCore;
				m5d((Ny)16384, _0020: true);
			}
			return f5j;
		}
	}

	protected virtual DataTemplate NameTemplateCore => null;

	public virtual object NameTemplateKey
	{
		get
		{
			if (!J5O.HasFlag((Ny)32768))
			{
				y5x = NameTemplateKeyCore;
				m5d((Ny)32768, _0020: true);
			}
			return y5x;
		}
	}

	protected virtual object NameTemplateKeyCore => null;

	public virtual DataTemplateSelector NameTemplateSelector
	{
		get
		{
			if (!J5O.HasFlag((Ny)65536))
			{
				s5a = NameTemplateSelectorCore;
				m5d((Ny)65536, _0020: true);
			}
			return s5a;
		}
	}

	protected virtual DataTemplateSelector NameTemplateSelectorCore => null;

	public virtual bool ShouldNotifyParentOnValueChange
	{
		get
		{
			if (!J5O.HasFlag((Ny)131072))
			{
				Y5h = ShouldNotifyParentOnValueChangeCore;
				m5d((Ny)131072, _0020: true);
			}
			return Y5h;
		}
	}

	protected virtual bool ShouldNotifyParentOnValueChangeCore => false;

	protected sealed override bool ShouldNotifyParentOnValueChangeResolved => ShouldNotifyParentOnValueChange;

	public virtual DataModelSortImportance SortImportance
	{
		get
		{
			if (!J5O.HasFlag((Ny)524288))
			{
				n5Z = SortImportanceCore;
				m5d((Ny)524288, _0020: true);
			}
			return n5Z;
		}
	}

	protected virtual DataModelSortImportance SortImportanceCore => DataModelSortImportance.Property;

	protected sealed override DataModelSortImportance SortImportanceResolved => SortImportance;

	public virtual int SortOrder
	{
		get
		{
			if (!J5O.HasFlag((Ny)262144))
			{
				A5H = SortOrderCore;
				m5d((Ny)262144, _0020: true);
			}
			return A5H;
		}
	}

	protected virtual int SortOrderCore => 0;

	protected sealed override int SortOrderResolved => SortOrder;

	public virtual IEnumerable StandardValues
	{
		get
		{
			if (!J5O.HasFlag((Ny)1048576))
			{
				w5D = StandardValuesCore;
				m5d((Ny)1048576, _0020: true);
			}
			return w5D;
		}
	}

	protected virtual IEnumerable StandardValuesCore
	{
		get
		{
			TypeConverter converter = Converter;
			if (converter != null)
			{
				ITypeDescriptorContext context = this as ITypeDescriptorContext;
				if (converter.GetStandardValuesSupported(context))
				{
					TypeConverter.StandardValuesCollection standardValues = converter.GetStandardValues(context);
					if (standardValues != null && standardValues.Count > 0)
					{
						return standardValues.OfType<object>().ToArray();
					}
				}
			}
			return null;
		}
	}

	protected sealed override IEnumerable StandardValuesResolved => StandardValues;

	public virtual IEnumerable<string> StandardValuesAsStrings
	{
		get
		{
			if (!J5O.HasFlag((Ny)2097152))
			{
				D57 = StandardValuesAsStringsCore;
				m5d((Ny)2097152, _0020: true);
			}
			return D57;
		}
	}

	protected virtual IEnumerable<string> StandardValuesAsStringsCore
	{
		get
		{
			IEnumerable standardValues = StandardValues;
			if (standardValues != null)
			{
				List<string> list = new List<string>();
				foreach (object item in standardValues)
				{
					string text = ConvertToString(item);
					if (text != null)
					{
						list.Add(text);
					}
				}
				if (list.Count > 0)
				{
					return list;
				}
			}
			return null;
		}
	}

	public virtual object Target
	{
		get
		{
			if (!J5O.HasFlag((Ny)4194304))
			{
				U5s = TargetCore;
				m5d((Ny)4194304, _0020: true);
			}
			return U5s;
		}
	}

	protected abstract object TargetCore { get; }

	protected sealed override object TargetResolved => Target;

	public virtual Type TargetType
	{
		get
		{
			object target = Target;
			if (target == null)
			{
				return typeof(object);
			}
			return target.GetType();
		}
	}

	public virtual object Value
	{
		get
		{
			if (!J5O.HasFlag((Ny)8388608))
			{
				g5i = ValueCore;
				m5d((Ny)8388608, _0020: true);
			}
			return g5i;
		}
		set
		{
			PropertyModelValueChangeEventArgs e = new PropertyModelValueChangeEventArgs(this, value);
			RaisePropertyValueChangingEvent(e);
			if (!e.Cancel)
			{
				ValueCore = e.Value;
				Refresh(PropertyRefreshReason.ValueChanged);
				RaisePropertyValueChangedEvent(new PropertyModelValueChangeEventArgs(this, e.Value));
			}
		}
	}

	protected abstract object ValueCore { get; set; }

	protected sealed override object ValueResolved
	{
		get
		{
			return Value;
		}
		set
		{
			Value = value;
		}
	}

	public virtual string ValueAsString
	{
		get
		{
			if (!J5O.HasFlag((Ny)16777216))
			{
				A5F = ValueAsStringCore;
				m5d((Ny)16777216, _0020: true);
			}
			return A5F;
		}
		set
		{
			ValueAsStringCore = value;
		}
	}

	protected virtual string ValueAsStringCore
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

	public virtual IList<object> Values
	{
		get
		{
			if (!J5O.HasFlag((Ny)33554432))
			{
				x5b = ValuesCore;
				m5d((Ny)33554432, _0020: true);
			}
			return x5b;
		}
	}

	protected virtual IList<object> ValuesCore => new object[1] { Value };

	public virtual DataTemplate ValueTemplate
	{
		get
		{
			if (!J5O.HasFlag((Ny)67108864))
			{
				V5c = ValueTemplateCore;
				m5d((Ny)67108864, _0020: true);
			}
			return V5c;
		}
	}

	protected virtual DataTemplate ValueTemplateCore => null;

	public virtual object ValueTemplateKey
	{
		get
		{
			if (!J5O.HasFlag((Ny)134217728))
			{
				w5V = ValueTemplateKeyCore;
				m5d((Ny)134217728, _0020: true);
			}
			return w5V;
		}
	}

	protected virtual object ValueTemplateKeyCore => null;

	public virtual DefaultValueTemplateKind ValueTemplateKind
	{
		get
		{
			if (!J5O.HasFlag((Ny)268435456))
			{
				V5f = ValueTemplateKindCore;
				m5d((Ny)268435456, _0020: true);
			}
			return V5f;
		}
	}

	protected virtual DefaultValueTemplateKind ValueTemplateKindCore => DefaultValueTemplateKind.None;

	public virtual DataTemplateSelector ValueTemplateSelector
	{
		get
		{
			if (!J5O.HasFlag((Ny)536870912))
			{
				m50 = ValueTemplateSelectorCore;
				m5d((Ny)536870912, _0020: true);
			}
			return m50;
		}
	}

	protected virtual DataTemplateSelector ValueTemplateSelectorCore => null;

	public virtual Type ValueType
	{
		get
		{
			if (!J5O.HasFlag((Ny)1073741824))
			{
				I5A = ValueTypeCore;
				m5d((Ny)1073741824, _0020: true);
			}
			return I5A;
		}
	}

	protected abstract Type ValueTypeCore { get; }

	protected sealed override Type ValueTypeResolved => ValueType;

	private void m5d(Ny P_0, bool P_1)
	{
		if (!P_1)
		{
			J5O &= ~P_0;
		}
		else
		{
			J5O |= P_0;
		}
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	protected override void OnPropertyChanged(PropertyChangedEventArgs e)
	{
		if (e != null)
		{
			string propertyName = e.PropertyName;
			switch (global::_003CPrivateImplementationDetails_003E.ComputeStringHash(propertyName))
			{
			case 1808238146u:
				if (propertyName == xv.hTz(8136))
				{
					m5d((Ny)1, _0020: false);
				}
				break;
			case 2243437917u:
				if (propertyName == xv.hTz(8162))
				{
					m5d((Ny)2, _0020: false);
				}
				break;
			case 2865759377u:
				if (propertyName == xv.hTz(8184))
				{
					m5d((Ny)4, _0020: false);
				}
				break;
			case 2947802513u:
				if (propertyName == xv.hTz(7708))
				{
					m5d((Ny)8, _0020: false);
				}
				break;
			case 3652684527u:
				if (propertyName == xv.hTz(8214))
				{
					m5d((Ny)16, _0020: false);
				}
				break;
			case 1725856265u:
				if (propertyName == xv.hTz(7728))
				{
					m5d((Ny)32, _0020: false);
				}
				break;
			case 4176258230u:
				if (propertyName == xv.hTz(7754))
				{
					m5d((Ny)64, _0020: false);
				}
				break;
			case 2219339384u:
				if (propertyName == xv.hTz(8236))
				{
					m5d((Ny)128, _0020: false);
				}
				break;
			case 1212885103u:
				if (propertyName == xv.hTz(8274))
				{
					m5d((Ny)256, _0020: false);
				}
				break;
			case 433733679u:
				if (propertyName == xv.hTz(8300))
				{
					m5d((Ny)512, _0020: false);
				}
				break;
			case 2825899955u:
				if (propertyName == xv.hTz(8354))
				{
					m5d((Ny)1024, _0020: false);
				}
				break;
			case 2070213090u:
				if (propertyName == xv.hTz(8380))
				{
					m5d((Ny)2048, _0020: false);
				}
				break;
			case 3194631332u:
				if (propertyName == xv.hTz(8102))
				{
					m5d((Ny)4096, _0020: false);
				}
				break;
			case 266367750u:
				if (propertyName == xv.hTz(8404))
				{
					m5d((Ny)8192, _0020: false);
				}
				break;
			case 2168803768u:
				if (propertyName == xv.hTz(1154))
				{
					m5d((Ny)16384, _0020: false);
				}
				break;
			case 4259577927u:
				if (propertyName == xv.hTz(7980))
				{
					m5d((Ny)32768, _0020: false);
				}
				break;
			case 3628512973u:
				if (propertyName == xv.hTz(1182))
				{
					m5d((Ny)65536, _0020: false);
				}
				break;
			case 3252777471u:
				if (propertyName == xv.hTz(8416))
				{
					m5d((Ny)131072, _0020: false);
				}
				break;
			case 339880675u:
				if (propertyName == xv.hTz(8482))
				{
					m5d((Ny)524288, _0020: false);
				}
				break;
			case 1347973507u:
				if (propertyName == xv.hTz(8514))
				{
					m5d((Ny)262144, _0020: false);
				}
				break;
			case 2009915774u:
				if (propertyName == xv.hTz(8536))
				{
					m5d((Ny)1048576, _0020: false);
				}
				break;
			case 3632387232u:
				if (propertyName == xv.hTz(8568))
				{
					m5d((Ny)2097152, _0020: false);
				}
				break;
			case 2338845032u:
				if (propertyName == xv.hTz(8618))
				{
					m5d((Ny)4194304, _0020: false);
				}
				break;
			case 3511155050u:
				if (propertyName == xv.hTz(8634))
				{
					m5d((Ny)8388608, _0020: false);
				}
				break;
			case 2179535575u:
				if (propertyName == xv.hTz(8648))
				{
					m5d((Ny)16777216, _0020: false);
				}
				break;
			case 2370642523u:
				if (propertyName == xv.hTz(8678))
				{
					m5d((Ny)33554432, _0020: false);
				}
				break;
			case 1434453900u:
				if (propertyName == xv.hTz(1456))
				{
					m5d((Ny)67108864, _0020: false);
				}
				break;
			case 4217391963u:
				if (propertyName == xv.hTz(8014))
				{
					m5d((Ny)134217728, _0020: false);
				}
				break;
			case 282533134u:
				if (propertyName == xv.hTz(8050))
				{
					m5d((Ny)268435456, _0020: false);
				}
				break;
			case 2889044009u:
				if (propertyName == xv.hTz(1486))
				{
					m5d((Ny)536870912, _0020: false);
				}
				break;
			case 85497770u:
				if (propertyName == xv.hTz(8694))
				{
					m5d((Ny)1073741824, _0020: false);
				}
				break;
			}
		}
		base.OnPropertyChanged(e);
	}

	protected CachedPropertyModelBase()
	{
		fc.taYSkz();
		base._002Ector();
	}

	internal static bool d6C()
	{
		return M6W == null;
	}

	internal static CachedPropertyModelBase B66()
	{
		return M6W;
	}
}
