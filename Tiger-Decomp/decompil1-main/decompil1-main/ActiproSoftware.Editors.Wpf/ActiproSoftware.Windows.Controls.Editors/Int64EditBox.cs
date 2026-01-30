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

public class Int64EditBox : PartEditBoxBase<long?>
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

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private EventHandler IPJ;

	internal static Int64EditBox EWi;

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

	public long DefaultValue
	{
		get
		{
			return (long)GetValue(DefaultValueProperty);
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

	public long LargeChange
	{
		get
		{
			return (long)GetValue(LargeChangeProperty);
		}
		set
		{
			SetValue(LargeChangeProperty, value);
		}
	}

	public long Maximum
	{
		get
		{
			return (long)GetValue(MaximumProperty);
		}
		set
		{
			SetValue(MaximumProperty, value);
		}
	}

	public long Minimum
	{
		get
		{
			return (long)GetValue(MinimumProperty);
		}
		set
		{
			SetValue(MinimumProperty, value);
		}
	}

	public Int64EditBoxPickerKind PickerKind
	{
		get
		{
			return (Int64EditBoxPickerKind)GetValue(PickerKindProperty);
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

	public long SmallChange
	{
		get
		{
			return (long)GetValue(SmallChangeProperty);
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
			EventHandler eventHandler = IPJ;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref IPJ, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = IPJ;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref IPJ, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public Int64EditBox()
	{
		awj.QuEwGz();
		base._002Ector();
		base.DefaultStyleKey = typeof(Int64EditBox);
	}

	private static void wPi(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		Int64EditBox int64EditBox = (Int64EditBox)P_0;
		int64EditBox.ResolvedFormat = sdh.zG0(P_1.NewValue as string, CultureInfo.CurrentCulture);
		int64EditBox.InvalidateParts();
		int64EditBox.QTc();
	}

	private static void PPZ(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		Int64EditBox int64EditBox = (Int64EditBox)P_0;
		int64EditBox.CoerceValue(PartEditBoxBase<long?>.ValueProperty);
	}

	private static void RPt(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		Int64EditBox int64EditBox = (Int64EditBox)P_0;
		int64EditBox.CoerceValue(PartEditBoxBase<long?>.ValueProperty);
	}

	protected override long? CoerceValidValue(long? value)
	{
		if (value.HasValue)
		{
			return sdh.hGO(value.Value, Minimum, Maximum);
		}
		return base.CoerceValidValue(value);
	}

	protected internal override string ConvertToString(long? valueToConvert)
	{
		return sdh.VGX(valueToConvert, ResolvedFormat) ?? string.Empty;
	}

	protected override IncrementalChangeRequest<long?> CreateIncrementalChangeRequest(IncrementalChangeRequestKind kind)
	{
		IncrementalChangeRequest<long?> incrementalChangeRequest = new IncrementalChangeRequest<long?>();
		incrementalChangeRequest.Kind = (base.IntermediateValue.HasValue ? kind : IncrementalChangeRequestKind.None);
		incrementalChangeRequest.LargeChange = LargeChange;
		incrementalChangeRequest.Maximum = Maximum;
		incrementalChangeRequest.Minimum = Minimum;
		incrementalChangeRequest.SmallChange = SmallChange;
		incrementalChangeRequest.SpinWrapping = base.SpinWrapping;
		incrementalChangeRequest.Value = base.IntermediateValue ?? sdh.hGO(DefaultValue, Minimum, Maximum);
		return incrementalChangeRequest;
	}

	protected override IList<IPart> GenerateParts()
	{
		return sdh.LGx(ResolvedFormat, CultureInfo.CurrentCulture);
	}

	protected override bool IsValidValue(long? value)
	{
		if (value.HasValue)
		{
			return sdh.hGO(value.Value, Minimum, Maximum) == value;
		}
		return base.IsNullAllowed;
	}

	protected override void RaiseValueChangedEvent()
	{
		IPJ?.Invoke(this, EventArgs.Empty);
	}

	protected override void ResetValue()
	{
		QTc();
		if (base.IsNullAllowed)
		{
			SetCurrentValue(PartEditBoxBase<long?>.ValueProperty, null);
		}
		else
		{
			SetCurrentValue(PartEditBoxBase<long?>.ValueProperty, sdh.hGO(DefaultValue, Minimum, Maximum));
		}
	}

	protected internal override bool TryConvertFromString(string textToConvert, bool canCoerce, out long? value)
	{
		if (sdh.fGT(textToConvert, ResolvedFormat, out value))
		{
			if (value.HasValue)
			{
				if (canCoerce)
				{
					value = sdh.hGO(value.Value, Minimum, Maximum);
				}
				return true;
			}
			return base.IsNullAllowed;
		}
		return false;
	}

	static Int64EditBox()
	{
		int num = 1;
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
					CalculatorPopupPickerStyleProperty = DependencyProperty.Register(QdM.AR8(1842), typeof(Style), typeof(Int64EditBox), new PropertyMetadata(null));
					DefaultValueProperty = DependencyProperty.Register(QdM.AR8(1898), typeof(long), typeof(Int64EditBox), new PropertyMetadata(0L));
					FormatProperty = DependencyProperty.Register(QdM.AR8(1926), typeof(string), typeof(Int64EditBox), new PropertyMetadata(QdM.AR8(1942), wPi));
					LargeChangeProperty = DependencyProperty.Register(QdM.AR8(1948), typeof(long), typeof(Int64EditBox), new PropertyMetadata(5L));
					MaximumProperty = DependencyProperty.Register(QdM.AR8(1974), typeof(long), typeof(Int64EditBox), new PropertyMetadata(long.MaxValue, PPZ));
					MinimumProperty = DependencyProperty.Register(QdM.AR8(1992), typeof(long), typeof(Int64EditBox), new PropertyMetadata(long.MinValue, RPt));
					PickerKindProperty = DependencyProperty.Register(QdM.AR8(2010), typeof(Int64EditBoxPickerKind), typeof(Int64EditBox), new PropertyMetadata(Int64EditBoxPickerKind.Default));
					ResolvedFormatProperty = DependencyProperty.Register(QdM.AR8(2034), typeof(string), typeof(Int64EditBox), new PropertyMetadata(sdh.zG0(QdM.AR8(1942), CultureInfo.CurrentCulture)));
					SmallChangeProperty = DependencyProperty.Register(QdM.AR8(2066), typeof(long), typeof(Int64EditBox), new PropertyMetadata(1L));
					return;
				}
				awj.QuEwGz();
				num2 = 0;
			}
			while (0 == 0);
		}
	}

	internal static bool aW5()
	{
		return EWi == null;
	}

	internal static Int64EditBox vWI()
	{
		return EWi;
	}
}
