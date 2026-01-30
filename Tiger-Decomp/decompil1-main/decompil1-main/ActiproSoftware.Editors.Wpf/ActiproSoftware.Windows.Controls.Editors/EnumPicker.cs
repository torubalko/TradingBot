using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.Editors.Primitives;

namespace ActiproSoftware.Windows.Controls.Editors;

public class EnumPicker : PickerBase
{
	public static readonly DependencyProperty EnumSortComparerProperty;

	public static readonly DependencyProperty EnumTypeProperty;

	public static readonly DependencyProperty IsOnPopupProperty;

	public static readonly DependencyProperty UseDisplayAttributesProperty;

	public static readonly DependencyProperty ValueProperty;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private EventHandler WsJ;

	private static EnumPicker TBU;

	public IComparer<Enum> EnumSortComparer
	{
		get
		{
			return (IComparer<Enum>)GetValue(EnumSortComparerProperty);
		}
		set
		{
			SetValue(EnumSortComparerProperty, value);
		}
	}

	public Type EnumType
	{
		get
		{
			return (Type)GetValue(EnumTypeProperty);
		}
		set
		{
			SetValue(EnumTypeProperty, value);
		}
	}

	public bool IsOnPopup
	{
		get
		{
			return (bool)GetValue(IsOnPopupProperty);
		}
		set
		{
			SetValue(IsOnPopupProperty, value);
		}
	}

	public bool UseDisplayAttributes
	{
		get
		{
			return (bool)GetValue(UseDisplayAttributesProperty);
		}
		set
		{
			SetValue(UseDisplayAttributesProperty, value);
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1721:PropertyNamesShouldNotMatchGetMethods")]
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

	public event EventHandler ValueChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = WsJ;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref WsJ, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = WsJ;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref WsJ, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public EnumPicker()
	{
		awj.QuEwGz();
		base._002Ector();
		base.DefaultStyleKey = typeof(EnumPicker);
	}

	private static void Pst(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		EnumPicker enumPicker = (EnumPicker)P_0;
		enumPicker.Qsn();
	}

	private void Qsn()
	{
		WsJ?.Invoke(this, EventArgs.Empty);
	}

	static EnumPicker()
	{
		awj.QuEwGz();
		EnumSortComparerProperty = DependencyProperty.Register(QdM.AR8(19226), typeof(IComparer<Enum>), typeof(EnumPicker), new PropertyMetadata(null));
		EnumTypeProperty = DependencyProperty.Register(QdM.AR8(19262), typeof(Type), typeof(EnumPicker), new PropertyMetadata(null));
		IsOnPopupProperty = DependencyProperty.Register(QdM.AR8(19420), typeof(bool), typeof(EnumPicker), new PropertyMetadata(false));
		UseDisplayAttributesProperty = DependencyProperty.Register(QdM.AR8(19282), typeof(bool), typeof(EnumPicker), new PropertyMetadata(false));
		ValueProperty = DependencyProperty.Register(QdM.AR8(1828), typeof(object), typeof(EnumPicker), new PropertyMetadata(null, Pst));
	}

	internal static bool AB9()
	{
		return TBU == null;
	}

	internal static EnumPicker pBM()
	{
		return TBU;
	}
}
