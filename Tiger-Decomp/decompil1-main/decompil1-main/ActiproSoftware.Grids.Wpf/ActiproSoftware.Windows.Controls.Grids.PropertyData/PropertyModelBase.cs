using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.Grids.PropertyEditors;
using ActiproSoftware.Windows.Input;

namespace ActiproSoftware.Windows.Controls.Grids.PropertyData;

public abstract class PropertyModelBase : DataModelBase, IDataErrorInfo
{
	[CompilerGenerated]
	private sealed class _003CGetErrorMessages_003Ed__28 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IDisposable, IEnumerator
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private string columnName;

		public string _003C_003E3__columnName;

		public PropertyModelBase _003C_003E4__this;

		private static _003CGetErrorMessages_003Ed__28 fRD;

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
		public _003CGetErrorMessages_003Ed__28(int _003C_003E1__state)
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
			PropertyModelBase propertyModelBase = _003C_003E4__this;
			string text;
			int num2;
			IDataErrorInfo dataErrorInfo = default(IDataErrorInfo);
			int num3 = default(int);
			switch (num)
			{
			case 2:
				_003C_003E1__state = -1;
				break;
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				text = columnName;
				if (!(text == xv.hTz(8634)))
				{
					num2 = 0;
					if (!FRb())
					{
						goto IL_0005;
					}
					goto IL_0009;
				}
				goto IL_016e;
			case 1:
				{
					_003C_003E1__state = -1;
					break;
				}
				IL_0009:
				while (true)
				{
					switch (num2)
					{
					case 1:
						break;
					default:
						goto IL_00be;
					}
					if (dataErrorInfo == null)
					{
						goto end_IL_00a8;
					}
					_003C_003E2__current = dataErrorInfo.Error;
					_003C_003E1__state = 2;
					return true;
					IL_00be:
					if (text == xv.hTz(8648))
					{
						break;
					}
					if (columnName != null)
					{
						goto end_IL_00a8;
					}
					dataErrorInfo = propertyModelBase.TargetResolved as IDataErrorInfo;
					num2 = 1;
					if (FRb())
					{
						continue;
					}
					goto IL_0005;
				}
				goto IL_016e;
				IL_0005:
				num2 = num3;
				goto IL_0009;
				IL_016e:
				if (propertyModelBase.TargetResolved is IDataErrorInfo dataErrorInfo2)
				{
					_003C_003E2__current = dataErrorInfo2[propertyModelBase.NameResolved];
					_003C_003E1__state = 1;
					return true;
				}
				break;
				end_IL_00a8:
				break;
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
			_003CGetErrorMessages_003Ed__28 _003CGetErrorMessages_003Ed__;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				_003CGetErrorMessages_003Ed__ = this;
			}
			else
			{
				_003CGetErrorMessages_003Ed__ = new _003CGetErrorMessages_003Ed__28(0)
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

		internal static bool FRb()
		{
			return fRD == null;
		}

		internal static _003CGetErrorMessages_003Ed__28 wRz()
		{
			return fRD;
		}
	}

	private DelegateCommand<object> xpF;

	private bool Ipc;

	private PropertyEditor vpV;

	private DelegateCommand<object> rpf;

	private DelegateCommand<object> mp0;

	private string CpA;

	private string Op4;

	private PropertyEditor YpS;

	internal static PropertyModelBase lFH;

	string IDataErrorInfo.Error => GetErrorMessages(null)?.OfType<string>().FirstOrDefault();

	string IDataErrorInfo.this[string propertyName] => GetErrorMessages(propertyName)?.OfType<string>().FirstOrDefault();

	public ICommand AddChildCommand
	{
		get
		{
			if (xpF == null)
			{
				xpF = new DelegateCommand<object>(delegate
				{
					AddChild();
				}, (object P_0) => CanAddChildResolved);
			}
			return xpF;
		}
	}

	protected abstract bool CanAddChildResolved { get; }

	protected abstract bool CanRemoveResolved { get; }

	protected abstract bool CanResetValueResolved { get; }

	protected abstract TypeConverter ConverterResolved { get; }

	public virtual bool HasStandardValues
	{
		get
		{
			IEnumerable standardValuesResolved = StandardValuesResolved;
			if (standardValuesResolved != null)
			{
				{
					IEnumerator enumerator = standardValuesResolved.GetEnumerator();
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

	public bool IsHostReadOnly
	{
		get
		{
			return Ipc;
		}
		set
		{
			if (Ipc != value)
			{
				Ipc = value;
				NotifyPropertyChanged(xv.hTz(9298));
				NotifyPropertyChanged(xv.hTz(890));
			}
		}
	}

	protected abstract bool IsImmutableResolved { get; }

	public bool IsReadOnly
	{
		get
		{
			PropertyEditor propertyEditor = ValuePropertyEditor ?? NamePropertyEditor;
			if (propertyEditor != null && this is IPropertyModel propertyModel)
			{
				bool? isReadOnly = propertyEditor.GetIsReadOnly(propertyModel);
				if (isReadOnly.HasValue)
				{
					return isReadOnly.Value;
				}
			}
			if (IsHostReadOnly || IsValueReadOnlyResolved)
			{
				return true;
			}
			for (IDataModel parent = base.Parent; parent != null; parent = parent.Parent)
			{
				if (parent is IPropertyModel { IsImmutable: not false })
				{
					return true;
				}
			}
			return false;
		}
	}

	protected abstract bool IsValueReadOnlyResolved { get; }

	public PropertyEditor NamePropertyEditor
	{
		get
		{
			return vpV;
		}
		set
		{
			if (vpV != value)
			{
				vpV = value;
				NotifyPropertyChanged(xv.hTz(9330));
				NotifyPropertyChanged(xv.hTz(890));
			}
		}
	}

	public ICommand RemoveCommand
	{
		get
		{
			if (rpf == null)
			{
				rpf = new DelegateCommand<object>(delegate
				{
					Remove();
				}, (object P_0) => CanRemoveResolved);
			}
			return rpf;
		}
	}

	public ICommand ResetValueCommand
	{
		get
		{
			if (mp0 == null)
			{
				mp0 = new DelegateCommand<object>(delegate
				{
					ResetValue();
				}, (object P_0) => !IsReadOnly && CanResetValueResolved);
			}
			return mp0;
		}
	}

	protected abstract bool ShouldNotifyParentOnValueChangeResolved { get; }

	public string StandardValuesDisplayMemberPath
	{
		get
		{
			return CpA;
		}
		set
		{
			if (!(CpA == value))
			{
				CpA = value;
				NotifyPropertyChanged(xv.hTz(9370));
			}
		}
	}

	public string StandardValuesSelectedValuePath
	{
		get
		{
			return Op4;
		}
		set
		{
			if (!(Op4 == value))
			{
				Op4 = value;
				NotifyPropertyChanged(xv.hTz(9436));
			}
		}
	}

	protected abstract IEnumerable StandardValuesResolved { get; }

	protected abstract object TargetResolved { get; }

	protected abstract object ValueResolved { get; set; }

	public PropertyEditor ValuePropertyEditor
	{
		get
		{
			return YpS;
		}
		set
		{
			if (YpS != value)
			{
				YpS = value;
				NotifyPropertyChanged(xv.hTz(9526));
				NotifyPropertyChanged(xv.hTz(890));
			}
		}
	}

	protected abstract Type ValueTypeResolved { get; }

	private void spi()
	{
		NotifyPropertyChanged(xv.hTz(8536));
		NotifyPropertyChanged(xv.hTz(8568));
	}

	private void ppb()
	{
		NotifyPropertyChanged(xv.hTz(8634));
		NotifyPropertyChanged(xv.hTz(8648));
		int num = 0;
		if (gF0() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		NotifyPropertyChanged(xv.hTz(8678));
		NotifyPropertyChanged(xv.hTz(8380));
		NotifyPropertyChanged(xv.hTz(8184));
		if (base.Parent is IPropertyModel propertyModel && ShouldNotifyParentOnValueChangeResolved)
		{
			propertyModel.Refresh(PropertyRefreshReason.ChildPropertyValueChanged);
		}
	}

	public virtual void AddChild()
	{
		throw new NotImplementedException();
	}

	[SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "string")]
	protected virtual object ConvertFromString(string stringValue)
	{
		TypeConverter converterResolved = ConverterResolved;
		ITypeDescriptorContext context = this as ITypeDescriptorContext;
		if (converterResolved == null || !converterResolved.CanConvertFrom(context, typeof(string)))
		{
			Type valueTypeResolved = ValueTypeResolved;
			if (valueTypeResolved == typeof(string) || valueTypeResolved == typeof(object))
			{
				return stringValue;
			}
			return null;
		}
		return converterResolved.ConvertFrom(context, null, stringValue);
	}

	protected virtual string ConvertToString(object value)
	{
		TypeConverter converterResolved = ConverterResolved;
		ITypeDescriptorContext context = this as ITypeDescriptorContext;
		if (converterResolved != null && converterResolved.CanConvertTo(context, typeof(string)))
		{
			return converterResolved.ConvertTo(context, null, value, typeof(string)) as string;
		}
		return value?.ToString();
	}

	public virtual bool CycleToNextStandardValue()
	{
		if (!IsReadOnly)
		{
			IEnumerable standardValuesResolved = StandardValuesResolved;
			if (standardValuesResolved != null)
			{
				object[] array = standardValuesResolved.OfType<object>().ToArray();
				if (array.Length != 0)
				{
					int num = Array.IndexOf(array, ValueResolved);
					if (num < array.Length - 1)
					{
						ValueResolved = array[num + 1];
					}
					else
					{
						ValueResolved = array[0];
					}
					return true;
				}
			}
		}
		return false;
	}

	protected virtual IEnumerable GetErrorMessages(string columnName)
	{
		int num;
		if (!(columnName == xv.hTz(8634)))
		{
			num = 0;
			if (!_003CGetErrorMessages_003Ed__28.FRb())
			{
				goto IL_0005;
			}
			goto IL_0009;
		}
		goto IL_0080;
		IL_0080:
		if (TargetResolved is IDataErrorInfo dataErrorInfo)
		{
			yield return dataErrorInfo[NameResolved];
		}
		yield break;
		IL_0005:
		int num2 = default(int);
		num = num2;
		goto IL_0009;
		IL_0009:
		IDataErrorInfo dataErrorInfo2 = default(IDataErrorInfo);
		while (true)
		{
			switch (num)
			{
			case 1:
				if (dataErrorInfo2 != null)
				{
					yield return dataErrorInfo2.Error;
				}
				yield break;
			}
			if (columnName == xv.hTz(8648))
			{
				break;
			}
			if (columnName != null)
			{
				yield break;
			}
			dataErrorInfo2 = TargetResolved as IDataErrorInfo;
			num = 1;
			if (_003CGetErrorMessages_003Ed__28.FRb())
			{
				continue;
			}
			goto IL_0005;
		}
		goto IL_0080;
	}

	protected override void OnPropertyChanged(PropertyChangedEventArgs e)
	{
		if (e != null)
		{
			string propertyName = e.PropertyName;
			if (propertyName == xv.hTz(8136))
			{
				if (xpF != null)
				{
					int num = 0;
					if (gF0() != null)
					{
						int num2 = default(int);
						num = num2;
					}
					switch (num)
					{
					}
					xpF.RaiseCanExecuteChanged();
				}
			}
			else if (propertyName == xv.hTz(8162))
			{
				if (rpf != null)
				{
					rpf.RaiseCanExecuteChanged();
				}
			}
			else if ((propertyName == xv.hTz(8184) || propertyName == xv.hTz(890)) && mp0 != null)
			{
				mp0.RaiseCanExecuteChanged();
			}
		}
		base.OnPropertyChanged(e);
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
		case PropertyRefreshReason.ChildPropertyValueChanged:
			ppb();
			break;
		case PropertyRefreshReason.ValueChanged:
		case PropertyRefreshReason.CollectionItemAdded:
		case PropertyRefreshReason.CollectionItemRemoved:
			ppb();
			RefreshChildren();
			break;
		case PropertyRefreshReason.StandardValuesChanged:
			spi();
			break;
		}
	}

	public virtual void Remove()
	{
		throw new NotImplementedException();
	}

	public virtual void ResetValue()
	{
		throw new NotImplementedException();
	}

	protected PropertyModelBase()
	{
		fc.taYSkz();
		base._002Ector();
	}

	[CompilerGenerated]
	private void Wph(object P_0)
	{
		AddChild();
	}

	[CompilerGenerated]
	private bool NpZ(object P_0)
	{
		return CanAddChildResolved;
	}

	[CompilerGenerated]
	private void epH(object P_0)
	{
		Remove();
	}

	[CompilerGenerated]
	private bool rpD(object P_0)
	{
		return CanRemoveResolved;
	}

	[CompilerGenerated]
	private void Xp7(object P_0)
	{
		ResetValue();
	}

	[CompilerGenerated]
	private bool Dps(object P_0)
	{
		if (!IsReadOnly)
		{
			return CanResetValueResolved;
		}
		return false;
	}

	internal static bool FFG()
	{
		return lFH == null;
	}

	internal static PropertyModelBase gF0()
	{
		return lFH;
	}
}
