using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.Editors.Primitives;

namespace ActiproSoftware.Windows.Controls.Editors;

public class Int16EditBox : PartEditBoxBase<short?>
{
	public static readonly DependencyProperty CalculatorPopupPickerStyleProperty;

	public static readonly DependencyProperty DefaultValueProperty;

	public static readonly DependencyProperty FormatProperty;

	public static readonly DependencyProperty LargeChangeProperty;

	public static readonly DependencyProperty MaximumProperty;

	public static readonly DependencyProperty MinimumProperty;

	public static readonly DependencyProperty PickerKindProperty;

	public static readonly DependencyProperty ResolvedFormatProperty;

	public static readonly DependencyProperty SmallChangeProperty;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private EventHandler Ljh;

	private static Int16EditBox DBY;

	public Style CalculatorPopupPickerStyle
	{
		get
		{
			return (Style)GetValue(CalculatorPopupPickerStyleProperty);
		}
		set
		{
			SetValue(CalculatorPopupPickerStyleProperty, value);
		}
	}

	public short DefaultValue
	{
		get
		{
			return (short)GetValue(DefaultValueProperty);
		}
		set
		{
			SetValue(DefaultValueProperty, value);
		}
	}

	public string Format
	{
		get
		{
			return (string)GetValue(FormatProperty);
		}
		set
		{
			SetValue(FormatProperty, value);
		}
	}

	public short LargeChange
	{
		get
		{
			return (short)GetValue(LargeChangeProperty);
		}
		set
		{
			SetValue(LargeChangeProperty, value);
		}
	}

	public short Maximum
	{
		get
		{
			return (short)GetValue(MaximumProperty);
		}
		set
		{
			SetValue(MaximumProperty, value);
		}
	}

	public short Minimum
	{
		get
		{
			return (short)GetValue(MinimumProperty);
		}
		set
		{
			SetValue(MinimumProperty, value);
		}
	}

	public Int16EditBoxPickerKind PickerKind
	{
		get
		{
			return (Int16EditBoxPickerKind)GetValue(PickerKindProperty);
		}
		set
		{
			SetValue(PickerKindProperty, value);
		}
	}

	public string ResolvedFormat
	{
		get
		{
			return (string)GetValue(ResolvedFormatProperty);
		}
		private set
		{
			SetValue(ResolvedFormatProperty, value);
		}
	}

	public short SmallChange
	{
		get
		{
			return (short)GetValue(SmallChangeProperty);
		}
		set
		{
			SetValue(SmallChangeProperty, value);
		}
	}

	public event EventHandler ValueChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = Ljh;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref Ljh, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = Ljh;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref Ljh, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public Int16EditBox()
	{
		awj.QuEwGz();
		base._002Ector();
		base.DefaultStyleKey = typeof(Int16EditBox);
	}

	private static void fjE(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		Int16EditBox int16EditBox = (Int16EditBox)P_0;
		int16EditBox.ResolvedFormat = YdV.jDv(P_1.NewValue as string, CultureInfo.CurrentCulture);
		int16EditBox.InvalidateParts();
		int16EditBox.QTc();
	}

	private static void vj7(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		Int16EditBox int16EditBox = (Int16EditBox)P_0;
		int16EditBox.CoerceValue(PartEditBoxBase<short?>.ValueProperty);
	}

	private static void sj4(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		Int16EditBox int16EditBox = (Int16EditBox)P_0;
		int16EditBox.CoerceValue(PartEditBoxBase<short?>.ValueProperty);
	}

	protected override short? CoerceValidValue(short? value)
	{
		if (value.HasValue)
		{
			return YdV.zDZ(value.Value, Minimum, Maximum);
		}
		return base.CoerceValidValue(value);
	}

	protected internal override string ConvertToString(short? valueToConvert)
	{
		return YdV.MD8(valueToConvert, ResolvedFormat) ?? string.Empty;
	}

	protected override IncrementalChangeRequest<short?> CreateIncrementalChangeRequest(IncrementalChangeRequestKind kind)
	{
		IncrementalChangeRequest<short?> incrementalChangeRequest = new IncrementalChangeRequest<short?>();
		incrementalChangeRequest.Kind = (base.IntermediateValue.HasValue ? kind : IncrementalChangeRequestKind.None);
		incrementalChangeRequest.LargeChange = LargeChange;
		incrementalChangeRequest.Maximum = Maximum;
		incrementalChangeRequest.Minimum = Minimum;
		incrementalChangeRequest.SmallChange = SmallChange;
		incrementalChangeRequest.SpinWrapping = base.SpinWrapping;
		incrementalChangeRequest.Value = base.IntermediateValue ?? YdV.zDZ(DefaultValue, Minimum, Maximum);
		return incrementalChangeRequest;
	}

	protected override IList<IPart> GenerateParts()
	{
		return YdV.eDr(ResolvedFormat, CultureInfo.CurrentCulture);
	}

	protected override bool IsValidValue(short? value)
	{
		if (value.HasValue)
		{
			return YdV.zDZ(value.Value, Minimum, Maximum) == value;
		}
		return base.IsNullAllowed;
	}

	protected override void RaiseValueChangedEvent()
	{
		Ljh?.Invoke(this, EventArgs.Empty);
	}

	protected override void ResetValue()
	{
		QTc();
		if (base.IsNullAllowed)
		{
			SetCurrentValue(PartEditBoxBase<short?>.ValueProperty, null);
		}
		else
		{
			SetCurrentValue(PartEditBoxBase<short?>.ValueProperty, YdV.zDZ(DefaultValue, Minimum, Maximum));
		}
	}

	protected internal override bool TryConvertFromString(string textToConvert, bool canCoerce, out short? value)
	{
		if (YdV.pDt(textToConvert, ResolvedFormat, out value))
		{
			bool flag = !value.HasValue;
			int num = 0;
			if (!aBx())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			default:
				if (flag)
				{
					return base.IsNullAllowed;
				}
				if (canCoerce)
				{
					value = YdV.zDZ(value.Value, Minimum, Maximum);
				}
				return true;
			}
		}
		return false;
	}

	static Int16EditBox()
	{
		awj.QuEwGz();
		CalculatorPopupPickerStyleProperty = DependencyProperty.Register(QdM.AR8(1842), typeof(Style), typeof(Int16EditBox), new PropertyMetadata(null));
		DefaultValueProperty = DependencyProperty.Register(QdM.AR8(1898), typeof(short), typeof(Int16EditBox), new PropertyMetadata((short)0));
		FormatProperty = DependencyProperty.Register(QdM.AR8(1926), typeof(string), typeof(Int16EditBox), new PropertyMetadata(QdM.AR8(1942), fjE));
		LargeChangeProperty = DependencyProperty.Register(QdM.AR8(1948), typeof(short), typeof(Int16EditBox), new PropertyMetadata((short)5));
		MaximumProperty = DependencyProperty.Register(QdM.AR8(1974), typeof(short), typeof(Int16EditBox), new PropertyMetadata(short.MaxValue, vj7));
		MinimumProperty = DependencyProperty.Register(QdM.AR8(1992), typeof(short), typeof(Int16EditBox), new PropertyMetadata(short.MinValue, sj4));
		PickerKindProperty = DependencyProperty.Register(QdM.AR8(2010), typeof(Int16EditBoxPickerKind), typeof(Int16EditBox), new PropertyMetadata(Int16EditBoxPickerKind.Default));
		ResolvedFormatProperty = DependencyProperty.Register(QdM.AR8(2034), typeof(string), typeof(Int16EditBox), new PropertyMetadata(YdV.jDv(QdM.AR8(1942), CultureInfo.CurrentCulture)));
		SmallChangeProperty = DependencyProperty.Register(QdM.AR8(2066), typeof(short), typeof(Int16EditBox), new PropertyMetadata((short)1));
	}

	internal static bool aBx()
	{
		return DBY == null;
	}

	internal static Int16EditBox yBz()
	{
		return DBY;
	}
}
