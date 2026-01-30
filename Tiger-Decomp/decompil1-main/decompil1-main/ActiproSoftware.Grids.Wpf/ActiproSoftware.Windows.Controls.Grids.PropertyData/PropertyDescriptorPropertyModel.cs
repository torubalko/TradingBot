using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.Grids.PropertyEditors;

namespace ActiproSoftware.Windows.Controls.Grids.PropertyData;

public class PropertyDescriptorPropertyModel : CachedPropertyModelBase, ITypeDescriptorContext, IServiceProvider
{
	private class zB
	{
		private PropertyDescriptor ImE;

		private WeakReference jmC;

		private object omK;

		private object fmN;

		internal static zB gRV;

		private zB(PropertyDescriptorPropertyModel P_0, object P_1, PropertyDescriptor P_2)
		{
			fc.taYSkz();
			omK = new object();
			base._002Ector();
			int num = 0;
			if (1 == 0)
			{
				int num2;
				num = num2;
			}
			switch (num)
			{
			}
			jmC = new WeakReference(P_0);
			fmN = P_1;
			ImE = P_2;
			P_2.AddValueChanged(P_1, amW);
			if (P_2 is INotifyPropertyChanged notifyPropertyChanged)
			{
				notifyPropertyChanged.PropertyChanged += qm5;
			}
		}

		private void qm5(object P_0, PropertyChangedEventArgs P_1)
		{
			lock (omK)
			{
				if (jmC != null && jmC.IsAlive && jmC.Target is PropertyDescriptorPropertyModel propertyDescriptorPropertyModel)
				{
					propertyDescriptorPropertyModel.xpI(P_1.PropertyName);
					return;
				}
			}
			Fmn();
		}

		private void amW(object P_0, EventArgs P_1)
		{
			lock (omK)
			{
				if (jmC != null && jmC.IsAlive && jmC.Target is PropertyDescriptorPropertyModel propertyDescriptorPropertyModel)
				{
					propertyDescriptorPropertyModel.Kp1();
					return;
				}
			}
			Fmn();
		}

		public void Fmn()
		{
			lock (omK)
			{
				if (fmN != null)
				{
					if (ImE is INotifyPropertyChanged notifyPropertyChanged)
					{
						notifyPropertyChanged.PropertyChanged -= qm5;
					}
					ImE.RemoveValueChanged(fmN, amW);
					jmC = null;
					fmN = null;
					ImE = null;
				}
			}
		}

		public static zB ymp(PropertyDescriptorPropertyModel P_0, object P_1, PropertyDescriptor P_2)
		{
			if (P_0 != null && P_1 != null && P_2 != null && (P_2.SupportsChangeEvents || P_2 is INotifyPropertyChanged))
			{
				return new zB(P_0, P_1, P_2);
			}
			return null;
		}

		internal static bool kRp()
		{
			return gRV == null;
		}

		internal static zB QRr()
		{
			return gRV;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass18_0
	{
		public PropertyDescriptorPropertyModel bmg;

		public string emm;

		internal static _003C_003Ec__DisplayClass18_0 JRd;

		public _003C_003Ec__DisplayClass18_0()
		{
			fc.taYSkz();
			base._002Ector();
		}

		internal void Oml()
		{
			bmg.apP(emm);
		}

		internal static bool gRN()
		{
			return JRd == null;
		}

		internal static _003C_003Ec__DisplayClass18_0 JR3()
		{
			return JRd;
		}
	}

	private bool HpU;

	private bool lp6;

	private zB Apq;

	private PropertyDescriptor YpJ;

	private object Vp5;

	internal static PropertyDescriptorPropertyModel vFA;

	[SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
	IContainer ITypeDescriptorContext.Container => null;

	[SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
	object ITypeDescriptorContext.Instance
	{
		get
		{
			TypeConverter converter = Converter;
			if (converter != null)
			{
				if (!(converter is BrushConverter) && !(converter is CacheModeConverter) && !(converter is FontFamilyConverter) && !(converter is GeometryConverter) && !(converter is ImageSourceConverter) && !(converter is InputScopeNameConverter))
				{
					int num = 0;
					if (xFK() != null)
					{
						int num2 = default(int);
						num = num2;
					}
					switch (num)
					{
					}
					if (!(converter is KeyConverter) && !(converter is KeyGestureConverter) && !(converter is ModifierKeysConverter) && !(converter is MouseActionConverter) && !(converter is MouseGestureConverter) && !(converter is PathFigureCollectionConverter) && !(converter is TransformConverter))
					{
						goto IL_001e;
					}
				}
				return Value;
			}
			goto IL_001e;
			IL_001e:
			return Target;
		}
	}

	PropertyDescriptor ITypeDescriptorContext.PropertyDescriptor => YpJ;

	protected override bool CanRemoveCore
	{
		get
		{
			if (base.IsHostReadOnly)
			{
				return false;
			}
			if (!(YpJ is ICollectionItemPropertyDescriptor collectionItemPropertyDescriptor))
			{
				return false;
			}
			return collectionItemPropertyDescriptor.CanRemove;
		}
	}

	protected override bool CanResetValueCore => YpJ.CanResetValue(Vp5);

	protected override string CategoryCore
	{
		get
		{
			string text = null;
			if (YpJ.Attributes[typeof(DisplayAttribute)] is DisplayAttribute displayAttribute)
			{
				text = displayAttribute.GetGroupName();
			}
			if (string.IsNullOrEmpty(text))
			{
				text = YpJ.Category;
			}
			return text;
		}
	}

	protected override TypeConverter ConverterCore => YpJ.Converter ?? base.ConverterCore;

	protected override string DescriptionCore
	{
		get
		{
			string text = null;
			if (YpJ.Attributes[typeof(DisplayAttribute)] is DisplayAttribute displayAttribute)
			{
				text = displayAttribute.GetDescription();
			}
			if (string.IsNullOrEmpty(text))
			{
				text = YpJ.Description;
			}
			return text;
		}
	}

	protected override string DisplayNameCore
	{
		get
		{
			string text = null;
			if (YpJ.Attributes[typeof(DisplayAttribute)] is DisplayAttribute displayAttribute)
			{
				text = displayAttribute.GetShortName();
			}
			if (string.IsNullOrEmpty(text))
			{
				int num = 0;
				if (!eFJ())
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				text = YpJ.DisplayName;
			}
			if (YpJ.Attributes[typeof(ParenthesizePropertyNameAttribute)] is ParenthesizePropertyNameAttribute { NeedParenthesis: not false })
			{
				text = xv.hTz(9222) + text + xv.hTz(9228);
			}
			return text;
		}
	}

	protected override bool IsImmutableCore
	{
		get
		{
			if (YpJ.Attributes[typeof(ImmutableObjectAttribute)] is ImmutableObjectAttribute immutableObjectAttribute)
			{
				return immutableObjectAttribute.Immutable;
			}
			return false;
		}
	}

	protected override bool IsMergeableCore
	{
		get
		{
			if (YpJ.Attributes[typeof(MergablePropertyAttribute)] is MergablePropertyAttribute mergablePropertyAttribute)
			{
				return mergablePropertyAttribute.AllowMerge;
			}
			return true;
		}
	}

	protected override bool IsModifiedCore => YpJ.ShouldSerializeValue(Vp5);

	protected override bool IsValueReadOnlyCore
	{
		get
		{
			if (YpJ.IsReadOnly)
			{
				return true;
			}
			if (YpJ.Attributes[typeof(EditableAttribute)] is EditableAttribute { AllowEdit: false })
			{
				return true;
			}
			return false;
		}
	}

	protected override string NameCore => YpJ.Name;

	public PropertyDescriptor PropertyDescriptor => YpJ;

	protected override bool ShouldNotifyParentOnValueChangeCore
	{
		get
		{
			if (YpJ.Attributes[typeof(NotifyParentPropertyAttribute)] is NotifyParentPropertyAttribute notifyParentPropertyAttribute)
			{
				return notifyParentPropertyAttribute.NotifyParent;
			}
			return false;
		}
	}

	protected override int SortOrderCore
	{
		get
		{
			int? num = null;
			if (YpJ.Attributes[typeof(DisplayAttribute)] is DisplayAttribute displayAttribute)
			{
				num = displayAttribute.GetOrder();
			}
			return num.GetValueOrDefault();
		}
	}

	protected override object TargetCore => Vp5;

	protected override object ValueCore
	{
		get
		{
			return YpJ.GetValue(Vp5);
		}
		set
		{
			try
			{
				lp6 = true;
				object obj = value;
				if (obj != null)
				{
					TypeConverter converter = YpJ.Converter;
					if (converter != null)
					{
						Type type = obj.GetType();
						if (converter.CanConvertFrom(this, type))
						{
							obj = converter.ConvertFrom(this, null, obj);
						}
					}
				}
				YpJ.SetValue(Vp5, obj);
			}
			finally
			{
				lp6 = false;
			}
		}
	}

	protected override Type ValueTypeCore => YpJ.PropertyType;

	public PropertyDescriptorPropertyModel(object target, PropertyDescriptor propertyDescriptor)
	{
		fc.taYSkz();
		base._002Ector();
		int num = 0;
		if (0 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		if (target == null)
		{
			throw new ArgumentNullException(xv.hTz(9136));
		}
		if (propertyDescriptor == null)
		{
			throw new ArgumentNullException(xv.hTz(9152));
		}
		YpJ = propertyDescriptor;
		Vp5 = target;
		unS();
		if (propertyDescriptor.GetEditor(typeof(PropertyEditor)) is PropertyEditor propertyEditor)
		{
			if (propertyEditor.RJS())
			{
				base.NamePropertyEditor = propertyEditor;
			}
			if (propertyEditor.p5I())
			{
				base.ValuePropertyEditor = propertyEditor;
			}
		}
	}

	[SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
	object IServiceProvider.GetService(Type serviceType)
	{
		return null;
	}

	[SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
	void ITypeDescriptorContext.OnComponentChanged()
	{
		throw new NotSupportedException();
	}

	[SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
	bool ITypeDescriptorContext.OnComponentChanging()
	{
		throw new NotSupportedException();
	}

	private void unS()
	{
		Snz();
		Apq = zB.ymp(this, Vp5, YpJ);
	}

	private void Snz()
	{
		if (Apq != null)
		{
			Apq.Fmn();
			Apq = null;
		}
	}

	private void xpI(string P_0)
	{
		_003C_003Ec__DisplayClass18_0 CS_0024_003C_003E8__locals5 = new _003C_003Ec__DisplayClass18_0();
		CS_0024_003C_003E8__locals5.bmg = this;
		CS_0024_003C_003E8__locals5.emm = P_0;
		PropertyGrid propertyGrid = this.En9();
		int num = 0;
		if (xFK() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (propertyGrid != null)
		{
			Dispatcher dispatcher = propertyGrid.Dispatcher;
			if (dispatcher != null && !dispatcher.CheckAccess())
			{
				dispatcher.Invoke(DispatcherPriority.Send, (Action)delegate
				{
					CS_0024_003C_003E8__locals5.bmg.apP(CS_0024_003C_003E8__locals5.emm);
				});
				return;
			}
		}
		apP(CS_0024_003C_003E8__locals5.emm);
	}

	private void apP(string P_0)
	{
		switch (global::_003CPrivateImplementationDetails_003E.ComputeStringHash(P_0))
		{
		case 2243437917u:
			if (!(P_0 == xv.hTz(8162)))
			{
				break;
			}
			goto IL_0167;
		case 2865759377u:
			if (!(P_0 == xv.hTz(8184)))
			{
				break;
			}
			goto IL_0167;
		case 2947802513u:
			if (!(P_0 == xv.hTz(7708)))
			{
				break;
			}
			goto IL_0167;
		case 3652684527u:
			if (!(P_0 == xv.hTz(8214)))
			{
				break;
			}
			goto IL_0167;
		case 1725856265u:
			if (!(P_0 == xv.hTz(7728)))
			{
				break;
			}
			goto IL_0167;
		case 4176258230u:
			if (!(P_0 == xv.hTz(7754)))
			{
				break;
			}
			goto IL_0167;
		case 266367750u:
			if (!(P_0 == xv.hTz(8404)))
			{
				break;
			}
			goto IL_0167;
		case 3656290791u:
			if (P_0 == xv.hTz(890))
			{
				NotifyPropertyChanged(xv.hTz(9192));
			}
			break;
		case 3894392736u:
			{
				if (P_0 == xv.hTz(7902))
				{
					NotifyPropertyChanged(xv.hTz(8694));
				}
				break;
			}
			IL_0167:
			NotifyPropertyChanged(P_0);
			break;
		}
	}

	private void Kp1()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (lp6)
				{
					return;
				}
				num2 = 0;
				if (xFK() == null)
				{
					num2 = 0;
				}
				continue;
			}
			if (HpU)
			{
				HpU = false;
				RaisePropertyValueChangedEvent(new PropertyModelValueChangeEventArgs(this, Value));
			}
			PropertyGrid propertyGrid = this.En9();
			if (propertyGrid != null)
			{
				Dispatcher dispatcher = propertyGrid.Dispatcher;
				if (dispatcher != null && !dispatcher.CheckAccess())
				{
					dispatcher.Invoke(DispatcherPriority.Send, (Action)delegate
					{
						Refresh(PropertyRefreshReason.ValueChanged);
					});
					return;
				}
			}
			Refresh(PropertyRefreshReason.ValueChanged);
			return;
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			Snz();
		}
		base.Dispose(disposing);
	}

	public override void Remove()
	{
		int num = 1;
		int num2 = num;
		ICollectionItemPropertyDescriptor collectionItemPropertyDescriptor = default(ICollectionItemPropertyDescriptor);
		while (true)
		{
			switch (num2)
			{
			case 1:
				collectionItemPropertyDescriptor = YpJ as ICollectionItemPropertyDescriptor;
				num2 = 0;
				if (xFK() == null)
				{
					num2 = 0;
				}
				continue;
			}
			if (collectionItemPropertyDescriptor == null)
			{
				return;
			}
			IPropertyModel propertyModel = base.Parent as IPropertyModel;
			PropertyModelChildChangeEventArgs e = new PropertyModelChildChangeEventArgs(propertyModel, this);
			RaiseChildPropertyRemovingEvent(e);
			if (!e.Cancel && collectionItemPropertyDescriptor.Remove())
			{
				if (propertyModel != null && !(propertyModel.Value is INotifyCollectionChanged))
				{
					propertyModel.Refresh(PropertyRefreshReason.CollectionItemRemoved);
				}
				RaiseChildPropertyRemovedEvent(new PropertyModelChildChangeEventArgs(propertyModel, this));
			}
			return;
		}
	}

	public override void ResetValue()
	{
		try
		{
			HpU = true;
			YpJ.ResetValue(Vp5);
		}
		finally
		{
			HpU = false;
		}
	}

	[CompilerGenerated]
	private void vpt()
	{
		Refresh(PropertyRefreshReason.ValueChanged);
	}

	internal static bool eFJ()
	{
		return vFA == null;
	}

	internal static PropertyDescriptorPropertyModel xFK()
	{
		return vFA;
	}
}
