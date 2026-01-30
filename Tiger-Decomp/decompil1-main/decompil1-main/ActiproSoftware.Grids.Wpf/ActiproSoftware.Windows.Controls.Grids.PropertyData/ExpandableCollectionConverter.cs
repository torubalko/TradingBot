using System;
using System.Collections;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.Grids;

namespace ActiproSoftware.Windows.Controls.Grids.PropertyData;

public class ExpandableCollectionConverter : TypeConverter, ICollectionTypeConverter
{
	protected class CollectionItemPropertyDescriptor : SimplePropertyDescriptor
	{
		private object Jg0;

		private static CollectionItemPropertyDescriptor lRZ;

		public override bool IsReadOnly => true;

		public CollectionItemPropertyDescriptor(ICollection collection, int index, object item, Type itemType, Attribute[] attributes)
		{
			fc.taYSkz();
			base._002Ector((collection != null) ? collection.GetType() : typeof(ICollection), string.Format(CultureInfo.CurrentCulture, SR.GetString(SRName.UIExpandableCollectionConverterIndexFormat), new object[1] { index }), itemType, attributes);
			Jg0 = item;
		}

		public override object GetValue(object component)
		{
			return Jg0;
		}

		public override void SetValue(object component, object value)
		{
			throw new InvalidOperationException();
		}

		internal static bool pRx()
		{
			return lRZ == null;
		}

		internal static CollectionItemPropertyDescriptor yRS()
		{
			return lRZ;
		}
	}

	protected class DictionaryItemPropertyDescriptor : SimplePropertyDescriptor, ICollectionItemPropertyDescriptor
	{
		private bool QgS;

		private bool Igz;

		[CompilerGenerated]
		private IDictionary ImI;

		[CompilerGenerated]
		private object DmP;

		internal static DictionaryItemPropertyDescriptor ER1;

		public virtual bool CanRemove
		{
			get
			{
				IDictionary dictionary = Dictionary;
				if (!QgS && dictionary != null && !dictionary.IsReadOnly)
				{
					return !dictionary.IsFixedSize;
				}
				return false;
			}
		}

		public IDictionary Dictionary
		{
			[CompilerGenerated]
			get
			{
				return ImI;
			}
			[CompilerGenerated]
			private set
			{
				ImI = value;
			}
		}

		public override bool IsReadOnly
		{
			get
			{
				if (!Igz && !Dictionary.IsReadOnly)
				{
					return snb(PropertyType);
				}
				return true;
			}
		}

		public object Key
		{
			[CompilerGenerated]
			get
			{
				return DmP;
			}
			[CompilerGenerated]
			private set
			{
				DmP = value;
			}
		}

		public DictionaryItemPropertyDescriptor(IDictionary dictionary, object key, Type itemType, Attribute[] attributes, bool isCollectionReadOnly, bool isReadOnly)
		{
			fc.taYSkz();
			base._002Ector((dictionary != null) ? dictionary.GetType() : typeof(IDictionary), (key != null && !string.IsNullOrEmpty(key.ToString())) ? key.ToString() : SR.GetString(SRName.UIExpandableCollectionConverterNullText), itemType, attributes);
			Dictionary = dictionary;
			Key = key;
			QgS = isCollectionReadOnly;
			Igz = isReadOnly;
		}

		public override object GetValue(object component)
		{
			return ((component as IDictionary) ?? Dictionary)?[Key];
		}

		public virtual bool Remove()
		{
			object key = Key;
			IDictionary dictionary = Dictionary;
			if (dictionary != null && dictionary.Contains(key))
			{
				dictionary.Remove(key);
				return true;
			}
			return false;
		}

		public override void SetValue(object component, object value)
		{
			IDictionary dictionary = (component as IDictionary) ?? Dictionary;
			if (dictionary != null)
			{
				dictionary[Key] = value;
				OnValueChanged(component, EventArgs.Empty);
			}
		}

		internal static bool SRU()
		{
			return ER1 == null;
		}

		internal static DictionaryItemPropertyDescriptor ER5()
		{
			return ER1;
		}
	}

	protected class ListItemPropertyDescriptor : SimplePropertyDescriptor, ICollectionItemPropertyDescriptor
	{
		private bool jmU;

		private bool hm6;

		[CompilerGenerated]
		private int pmq;

		[CompilerGenerated]
		private IList kmJ;

		internal static ListItemPropertyDescriptor bRa;

		public virtual bool CanRemove
		{
			get
			{
				IList list = List;
				if (!jmU && list != null && !list.IsReadOnly)
				{
					return !list.IsFixedSize;
				}
				return false;
			}
		}

		public int Index
		{
			[CompilerGenerated]
			get
			{
				return pmq;
			}
			[CompilerGenerated]
			private set
			{
				pmq = value;
			}
		}

		public override bool IsReadOnly
		{
			get
			{
				if (!hm6 && !List.IsReadOnly)
				{
					return snb(PropertyType);
				}
				return true;
			}
		}

		public IList List
		{
			[CompilerGenerated]
			get
			{
				return kmJ;
			}
			[CompilerGenerated]
			private set
			{
				kmJ = value;
			}
		}

		public ListItemPropertyDescriptor(IList list, int index, Type itemType, Attribute[] attributes, bool isCollectionReadOnly, bool isReadOnly)
		{
			fc.taYSkz();
			base._002Ector((list != null) ? list.GetType() : typeof(IList), string.Format(CultureInfo.CurrentCulture, SR.GetString(SRName.UIExpandableCollectionConverterIndexFormat), new object[1] { index }), itemType, attributes);
			List = list;
			Index = index;
			jmU = isCollectionReadOnly;
			hm6 = isReadOnly;
		}

		public override object GetValue(object component)
		{
			IList list = (component as IList) ?? List;
			if (list != null && Index < list.Count)
			{
				return list[Index];
			}
			return null;
		}

		public virtual bool Remove()
		{
			IList list = List;
			if (list != null)
			{
				list.RemoveAt(Index);
				return true;
			}
			return false;
		}

		public override void SetValue(object component, object value)
		{
			IList list = (component as IList) ?? List;
			if (list != null && Index < list.Count && list[Index] != value)
			{
				list[Index] = value;
				OnValueChanged(component, EventArgs.Empty);
			}
		}

		internal static bool rRe()
		{
			return bRa == null;
		}

		internal static ListItemPropertyDescriptor NRv()
		{
			return bRa;
		}
	}

	[CompilerGenerated]
	private bool nnH;

	[CompilerGenerated]
	private bool mnD;

	[CompilerGenerated]
	private string Nn7;

	[CompilerGenerated]
	private string ens;

	[CompilerGenerated]
	private string inF;

	internal static ExpandableCollectionConverter T65;

	public bool AreItemsReadOnly
	{
		[CompilerGenerated]
		get
		{
			return nnH;
		}
		[CompilerGenerated]
		private set
		{
			nnH = value;
		}
	}

	public bool IsCollectionReadOnly
	{
		[CompilerGenerated]
		get
		{
			return mnD;
		}
		[CompilerGenerated]
		private set
		{
			mnD = value;
		}
	}

	public string MultipleItemsFormat
	{
		[CompilerGenerated]
		get
		{
			return Nn7;
		}
		[CompilerGenerated]
		set
		{
			Nn7 = value;
		}
	}

	public string NoItemsText
	{
		[CompilerGenerated]
		get
		{
			return ens;
		}
		[CompilerGenerated]
		set
		{
			ens = value;
		}
	}

	public string OneItemText
	{
		[CompilerGenerated]
		get
		{
			return inF;
		}
		[CompilerGenerated]
		set
		{
			inF = value;
		}
	}

	public ExpandableCollectionConverter()
	{
		fc.taYSkz();
		this._002Ector(isCollectionReadOnly: false, areItemsReadOnly: false);
	}

	public ExpandableCollectionConverter(bool isCollectionReadOnly, bool areItemsReadOnly)
	{
		fc.taYSkz();
		base._002Ector();
		IsCollectionReadOnly = isCollectionReadOnly;
		AreItemsReadOnly = areItemsReadOnly;
		NoItemsText = SR.GetString(SRName.UIExpandableCollectionConverterNoItemsText);
		OneItemText = SR.GetString(SRName.UIExpandableCollectionConverterOneItemText);
		MultipleItemsFormat = SR.GetString(SRName.UIExpandableCollectionConverterMultipleItemsFormat);
	}

	private static bool snb(Type P_0)
	{
		if (P_0 != null)
		{
			object[] customAttributes = P_0.GetCustomAttributes(typeof(ReadOnlyAttribute), inherit: false);
			if (customAttributes != null && customAttributes.Length != 0 && customAttributes[0] is ReadOnlyAttribute readOnlyAttribute)
			{
				return readOnlyAttribute.IsReadOnly;
			}
		}
		return false;
	}

	public virtual bool AddItem(IPropertyModel propertyModel, object item)
	{
		if (propertyModel != null)
		{
			return u6.OWW(propertyModel.Value, item);
		}
		return false;
	}

	public virtual bool CanAddItem(IPropertyModel propertyModel)
	{
		if (!IsCollectionReadOnly && propertyModel != null)
		{
			return u6.EWn(propertyModel.Value);
		}
		return false;
	}

	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
	{
		if (!(destinationType == typeof(string)))
		{
			return base.CanConvertTo(context, destinationType);
		}
		return true;
	}

	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
	{
		if (destinationType == typeof(string))
		{
			int num = u6.jWE(value);
			switch (num)
			{
			case 0:
				return NoItemsText;
			case 1:
				return OneItemText;
			default:
				if (MultipleItemsFormat == null)
				{
					return null;
				}
				return string.Format(CultureInfo.CurrentCulture, MultipleItemsFormat, new object[1] { num });
			}
		}
		return base.ConvertTo(context, culture, value, destinationType);
	}

	protected virtual PropertyDescriptor CreateCollectionItemPropertyDescriptor(ITypeDescriptorContext context, Attribute[] attributes, ICollection collection, int index, object item, Type itemType)
	{
		return new CollectionItemPropertyDescriptor(collection, index, item, itemType, null);
	}

	protected virtual PropertyDescriptor CreateDictionaryItemPropertyDescriptor(ITypeDescriptorContext context, Attribute[] attributes, IDictionary dictionary, object key, Type itemType)
	{
		return new DictionaryItemPropertyDescriptor(dictionary, key, itemType, null, IsCollectionReadOnly, AreItemsReadOnly);
	}

	public virtual object CreateItem(IPropertyModel propertyModel)
	{
		if (propertyModel != null)
		{
			return u6.vWp(propertyModel.Value);
		}
		return null;
	}

	protected virtual PropertyDescriptor CreateListItemPropertyDescriptor(ITypeDescriptorContext context, Attribute[] attributes, IList list, int index, Type itemType)
	{
		return new ListItemPropertyDescriptor(list, index, itemType, null, IsCollectionReadOnly, AreItemsReadOnly);
	}

	protected virtual PropertyDescriptor[] GetCollectionProperties(ITypeDescriptorContext context, Attribute[] attributes, ICollection collection)
	{
		if (collection == null)
		{
			throw new ArgumentNullException(xv.hTz(8762));
		}
		Type itemType = u6.oWC(collection) ?? typeof(object);
		PropertyDescriptor[] array = new PropertyDescriptor[collection.Count];
		int num = 0;
		foreach (object item in collection)
		{
			if (num >= array.Length)
			{
				break;
			}
			array[num] = CreateCollectionItemPropertyDescriptor(context, attributes, collection, num, item, itemType);
			num++;
		}
		return array;
	}

	protected virtual PropertyDescriptor[] GetDictionaryProperties(ITypeDescriptorContext context, Attribute[] attributes, IDictionary dictionary)
	{
		if (dictionary == null)
		{
			throw new ArgumentNullException(xv.hTz(8786));
		}
		Type itemType = u6.zWK(dictionary) ?? typeof(object);
		PropertyDescriptor[] array = new PropertyDescriptor[dictionary.Count];
		int num = 0;
		foreach (object key in dictionary.Keys)
		{
			if (num >= array.Length)
			{
				break;
			}
			array[num++] = CreateDictionaryItemPropertyDescriptor(context, attributes, dictionary, key, itemType);
		}
		return array;
	}

	protected virtual PropertyDescriptor[] GetListProperties(ITypeDescriptorContext context, Attribute[] attributes, IList list)
	{
		if (list == null)
		{
			throw new ArgumentNullException(xv.hTz(8810));
		}
		Type itemType = u6.TWN(list) ?? typeof(object);
		int num = 0;
		if (B6e() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		default:
		{
			PropertyDescriptor[] array = new PropertyDescriptor[list.Count];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = CreateListItemPropertyDescriptor(context, attributes, list, i, itemType);
			}
			return array;
		}
		}
	}

	public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
	{
		PropertyDescriptor[] properties = null;
		if (!(value is IList list))
		{
			if (value is IDictionary dictionary)
			{
				properties = GetDictionaryProperties(context, attributes, dictionary);
			}
			else if (value is ICollection collection)
			{
				properties = GetCollectionProperties(context, attributes, collection);
			}
		}
		else
		{
			int num = 0;
			if (!z6a())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			properties = GetListProperties(context, attributes, list);
		}
		return new PropertyDescriptorCollection(properties);
	}

	public override bool GetPropertiesSupported(ITypeDescriptorContext context)
	{
		return true;
	}

	internal static bool z6a()
	{
		return T65 == null;
	}

	internal static ExpandableCollectionConverter B6e()
	{
		return T65;
	}
}
