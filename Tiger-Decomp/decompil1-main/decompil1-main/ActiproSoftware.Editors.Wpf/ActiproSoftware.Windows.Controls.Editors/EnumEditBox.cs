using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.Editors.Primitives;

namespace ActiproSoftware.Windows.Controls.Editors;

public class EnumEditBox : PartEditBoxBase<object>
{
	public static readonly DependencyProperty EnumSortComparerProperty;

	public static readonly DependencyProperty EnumTypeProperty;

	public static readonly DependencyProperty UseDisplayAttributesProperty;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private EventHandler QsM;

	internal static EnumEditBox fB0;

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
			return GetValue(EnumTypeProperty) as Type;
		}
		set
		{
			SetValue(EnumTypeProperty, value);
		}
	}

	protected override bool HasPopupButtonWhenReadOnly => Vdx.JDc(osC());

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

	public event EventHandler ValueChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = QsM;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref QsM, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = QsM;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref QsM, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public EnumEditBox()
	{
		awj.QuEwGz();
		base._002Ector();
		base.DefaultStyleKey = typeof(EnumEditBox);
	}

	private static void WsQ(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		EnumEditBox enumEditBox = (EnumEditBox)P_0;
		if (DependencyPropertyHelper.GetValueSource(enumEditBox, PartEditBoxBase<object>.ValueProperty).BaseValueSource == BaseValueSource.Default)
		{
			enumEditBox.kO4();
		}
	}

	private static void WsV(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		EnumEditBox enumEditBox = (EnumEditBox)P_0;
		enumEditBox.QTc();
	}

	[SpecialName]
	private Type osC()
	{
		return Vdx.PDG(EnumType, base.Value);
	}

	protected internal override string ConvertToString(object valueToConvert)
	{
		return Vdx.hDq(valueToConvert, UseDisplayAttributes) ?? string.Empty;
	}

	protected override IncrementalChangeRequest<object> CreateIncrementalChangeRequest(IncrementalChangeRequestKind kind)
	{
		IncrementalChangeRequest<object> incrementalChangeRequest = new IncrementalChangeRequest<object>();
		incrementalChangeRequest.Kind = ((base.IntermediateValue != null) ? kind : IncrementalChangeRequestKind.None);
		incrementalChangeRequest.SpinWrapping = base.SpinWrapping;
		incrementalChangeRequest.Value = (base.IntermediateValue as Enum) ?? Vdx.yDR(osC());
		if (incrementalChangeRequest.Value != null)
		{
			Type type = osC();
			if (type != null)
			{
				Array array = Vdx.BDK(osC());
				if (array != null && array.Length > 0)
				{
					Array.Reverse(array);
					int num = Array.IndexOf(array, incrementalChangeRequest.Value);
					if (array.Length > 0)
					{
						switch (incrementalChangeRequest.Kind)
						{
						case IncrementalChangeRequestKind.Decrease:
						case IncrementalChangeRequestKind.MultipleDecrease:
							incrementalChangeRequest.Minimum = array.GetValue(Math.Max(0, num - 1));
							incrementalChangeRequest.Maximum = array.GetValue(array.Length - 1);
							break;
						case IncrementalChangeRequestKind.Increase:
						case IncrementalChangeRequestKind.MultipleIncrease:
							incrementalChangeRequest.Minimum = array.GetValue(0);
							incrementalChangeRequest.Maximum = array.GetValue(Math.Min(array.Length - 1, num + 1));
							break;
						}
					}
				}
			}
		}
		return incrementalChangeRequest;
	}

	protected override IList<IPart> GenerateParts()
	{
		return Vdx.ADu();
	}

	protected override bool IsValidValue(object value)
	{
		int num = 1;
		bool flag = default(bool);
		while (true)
		{
			int num2 = num;
			do
			{
				switch (num2)
				{
				case 1:
					break;
				default:
				{
					if (!flag)
					{
						return base.IsNullAllowed;
					}
					Type type = osC();
					if (!(type != null))
					{
						return false;
					}
					return Vdx.IDH(type, value);
				}
				}
				flag = value != null;
				num2 = 0;
			}
			while (IBw() == null);
		}
	}

	protected override void RaiseValueChangedEvent()
	{
		QsM?.Invoke(this, EventArgs.Empty);
	}

	protected override void ResetValue()
	{
		QTc();
		if (!base.IsNullAllowed)
		{
			if (osC() != null)
			{
				SetCurrentValue(PartEditBoxBase<object>.ValueProperty, Vdx.yDR(osC()));
			}
		}
		else
		{
			SetCurrentValue(PartEditBoxBase<object>.ValueProperty, null);
		}
	}

	protected internal override bool TryConvertFromString(string textToConvert, bool canCoerce, out object value)
	{
		bool result;
		if (!Vdx.xDL(osC(), textToConvert, UseDisplayAttributes, out value))
		{
			result = false;
			int num = 0;
			if (!yB7())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
		else
		{
			result = value != null || base.IsNullAllowed;
		}
		return result;
	}

	static EnumEditBox()
	{
		awj.QuEwGz();
		EnumSortComparerProperty = DependencyProperty.Register(QdM.AR8(19226), typeof(IComparer<Enum>), typeof(EnumEditBox), new PropertyMetadata(null));
		EnumTypeProperty = DependencyProperty.Register(QdM.AR8(19262), typeof(Type), typeof(EnumEditBox), new PropertyMetadata(null, WsQ));
		UseDisplayAttributesProperty = DependencyProperty.Register(QdM.AR8(19282), typeof(bool), typeof(EnumEditBox), new PropertyMetadata(false, WsV));
	}

	internal static bool yB7()
	{
		return fB0 == null;
	}

	internal static EnumEditBox IBw()
	{
		return fB0;
	}
}
