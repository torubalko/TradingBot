using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Grids.PropertyData;

public class CollectionPropertyDescriptorPropertyModel : PropertyDescriptorPropertyModel
{
	private WeakReference JWQ;

	[CompilerGenerated]
	private bool LWy;

	[CompilerGenerated]
	private bool lWd;

	internal static CollectionPropertyDescriptorPropertyModel X6i;

	public object AttachedCollectionValue
	{
		get
		{
			if (JWQ != null)
			{
				if (JWQ.IsAlive)
				{
					return JWQ.Target;
				}
				JWQ = null;
			}
			return null;
		}
		set
		{
			JWQ = ((value != null) ? new WeakReference(value) : null);
		}
	}

	public bool AreItemsReadOnly
	{
		[CompilerGenerated]
		get
		{
			return LWy;
		}
		[CompilerGenerated]
		private set
		{
			LWy = value;
		}
	}

	protected override bool CanAddChildCore
	{
		get
		{
			if (base.IsHostReadOnly)
			{
				return false;
			}
			if (!(Converter is ICollectionTypeConverter collectionTypeConverter))
			{
				if (IsCollectionReadOnly)
				{
					return false;
				}
				return u6.EWn(Value);
			}
			return collectionTypeConverter.CanAddItem(this);
		}
	}

	protected override TypeConverter ConverterCore
	{
		get
		{
			TypeConverter typeConverter = base.ConverterCore;
			if (typeConverter == null || typeConverter.GetType() == typeof(ArrayConverter) || typeConverter.GetType() == typeof(CollectionConverter) || typeConverter.GetType() == typeof(ReferenceConverter) || typeConverter.GetType() == typeof(TypeConverter))
			{
				typeConverter = CreateExpandableCollectionConverter();
			}
			return typeConverter;
		}
	}

	public bool IsCollectionReadOnly
	{
		[CompilerGenerated]
		get
		{
			return lWd;
		}
		[CompilerGenerated]
		private set
		{
			lWd = value;
		}
	}

	[SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
	public CollectionPropertyDescriptorPropertyModel(object target, PropertyDescriptor propertyDescriptor, bool isCollectionReadOnly, bool areItemsReadOnly)
	{
		fc.taYSkz();
		base._002Ector(target, propertyDescriptor);
		IsCollectionReadOnly = isCollectionReadOnly;
		AreItemsReadOnly = areItemsReadOnly;
		VWg();
	}

	private void VWg()
	{
		TWm();
		object value = Value;
		INotifyPropertyChanged notifyPropertyChanged = null;
		INotifyCollectionChanged notifyCollectionChanged = value as INotifyCollectionChanged;
		if (notifyCollectionChanged != null)
		{
			notifyCollectionChanged.CollectionChanged += eWo;
		}
		else
		{
			notifyPropertyChanged = value as INotifyPropertyChanged;
			if (notifyPropertyChanged != null)
			{
				notifyPropertyChanged.PropertyChanged += FWT;
				int num = 0;
				if (B6J() != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
			}
		}
		if (notifyPropertyChanged != null || notifyCollectionChanged != null)
		{
			AttachedCollectionValue = value;
		}
	}

	private void TWm()
	{
		object attachedCollectionValue = AttachedCollectionValue;
		if (attachedCollectionValue != null)
		{
			AttachedCollectionValue = null;
			if (attachedCollectionValue is INotifyCollectionChanged notifyCollectionChanged)
			{
				notifyCollectionChanged.CollectionChanged -= eWo;
			}
			else if (attachedCollectionValue is INotifyPropertyChanged notifyPropertyChanged)
			{
				notifyPropertyChanged.PropertyChanged -= FWT;
			}
		}
	}

	private void FWT(object P_0, PropertyChangedEventArgs P_1)
	{
		if (P_1 != null && string.Compare(P_1.PropertyName, xv.hTz(8748), StringComparison.OrdinalIgnoreCase) == 0)
		{
			Refresh(PropertyRefreshReason.ValueChanged);
		}
	}

	private void eWo(object P_0, NotifyCollectionChangedEventArgs P_1)
	{
		PropertyRefreshReason reason = PropertyRefreshReason.ValueChanged;
		if (P_1 != null)
		{
			switch (P_1.Action)
			{
			case NotifyCollectionChangedAction.Add:
				reason = PropertyRefreshReason.CollectionItemAdded;
				break;
			case NotifyCollectionChangedAction.Replace:
				return;
			case NotifyCollectionChangedAction.Remove:
				reason = PropertyRefreshReason.CollectionItemRemoved;
				break;
			}
		}
		Refresh(reason);
	}

	public override void AddChild()
	{
		ICollectionTypeConverter collectionTypeConverter = Converter as ICollectionTypeConverter;
		object obj;
		if (collectionTypeConverter == null)
		{
			int num = 0;
			if (B6J() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			obj = u6.vWp(Value);
		}
		else
		{
			obj = collectionTypeConverter.CreateItem(this);
		}
		object childValue = obj;
		PropertyModelChildChangeEventArgs e = new PropertyModelChildChangeEventArgs(this, childValue);
		RaiseChildPropertyAddingEvent(e);
		if (e.Cancel)
		{
			return;
		}
		if (collectionTypeConverter != null)
		{
			if (!collectionTypeConverter.AddItem(this, e.ChildValue))
			{
				return;
			}
		}
		else if (!u6.OWW(Value, e.ChildValue))
		{
			return;
		}
		if (!(Value is INotifyCollectionChanged))
		{
			Refresh(PropertyRefreshReason.CollectionItemAdded);
		}
		RaiseChildPropertyAddedEvent(new PropertyModelChildChangeEventArgs(this, e.ChildValue));
	}

	protected virtual TypeConverter CreateExpandableCollectionConverter()
	{
		return new ExpandableCollectionConverter(IsCollectionReadOnly, AreItemsReadOnly);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			TWm();
		}
		base.Dispose(disposing);
	}

	protected override void OnPropertyChanged(PropertyChangedEventArgs e)
	{
		base.OnPropertyChanged(e);
		if (e != null)
		{
			_ = e.PropertyName == xv.hTz(8634);
		}
	}

	internal static bool F6A()
	{
		return X6i == null;
	}

	internal static CollectionPropertyDescriptorPropertyModel B6J()
	{
		return X6i;
	}
}
