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

public class ByteEditBox : PartEditBoxBase<byte?>
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
	private EventHandler NVJ;

	internal static ByteEditBox uE;

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

	public byte DefaultValue
	{
		get
		{
			return (byte)GetValue(DefaultValueProperty);
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

	public byte LargeChange
	{
		get
		{
			return (byte)GetValue(LargeChangeProperty);
		}
		set
		{
			SetValue(LargeChangeProperty, value);
		}
	}

	public byte Maximum
	{
		get
		{
			return (byte)GetValue(MaximumProperty);
		}
		set
		{
			SetValue(MaximumProperty, value);
		}
	}

	public byte Minimum
	{
		get
		{
			return (byte)GetValue(MinimumProperty);
		}
		set
		{
			SetValue(MinimumProperty, value);
		}
	}

	public ByteEditBoxPickerKind PickerKind
	{
		get
		{
			return (ByteEditBoxPickerKind)GetValue(PickerKindProperty);
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

	public byte SmallChange
	{
		get
		{
			return (byte)GetValue(SmallChangeProperty);
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
			EventHandler eventHandler = NVJ;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref NVJ, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = NVJ;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref NVJ, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public ByteEditBox()
	{
		awj.QuEwGz();
		base._002Ector();
		base.DefaultStyleKey = typeof(ByteEditBox);
	}

	private static void UVi(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		ByteEditBox byteEditBox = (ByteEditBox)P_0;
		byteEditBox.ResolvedFormat = cda.Xbj(P_1.NewValue as string, CultureInfo.CurrentCulture);
		byteEditBox.InvalidateParts();
		byteEditBox.QTc();
	}

	private static void pVZ(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		ByteEditBox byteEditBox = (ByteEditBox)P_0;
		byteEditBox.CoerceValue(PartEditBoxBase<byte?>.ValueProperty);
	}

	private static void wVt(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		ByteEditBox byteEditBox = (ByteEditBox)P_0;
		byteEditBox.CoerceValue(PartEditBoxBase<byte?>.ValueProperty);
	}

	protected override byte? CoerceValidValue(byte? value)
	{
		if (value.HasValue)
		{
			return cda.zbf(value.Value, Minimum, Maximum);
		}
		return base.CoerceValidValue(value);
	}

	protected internal override string ConvertToString(byte? valueToConvert)
	{
		return cda.NbM(valueToConvert, ResolvedFormat) ?? string.Empty;
	}

	protected override IncrementalChangeRequest<byte?> CreateIncrementalChangeRequest(IncrementalChangeRequestKind kind)
	{
		IncrementalChangeRequest<byte?> incrementalChangeRequest = new IncrementalChangeRequest<byte?>();
		incrementalChangeRequest.Kind = (base.IntermediateValue.HasValue ? kind : IncrementalChangeRequestKind.None);
		incrementalChangeRequest.LargeChange = LargeChange;
		incrementalChangeRequest.Maximum = Maximum;
		incrementalChangeRequest.Minimum = Minimum;
		incrementalChangeRequest.SmallChange = SmallChange;
		incrementalChangeRequest.SpinWrapping = base.SpinWrapping;
		incrementalChangeRequest.Value = base.IntermediateValue ?? cda.zbf(DefaultValue, Minimum, Maximum);
		return incrementalChangeRequest;
	}

	protected override IList<IPart> GenerateParts()
	{
		return cda.jbs(ResolvedFormat, CultureInfo.CurrentCulture);
	}

	protected override bool IsValidValue(byte? value)
	{
		if (value.HasValue)
		{
			return cda.zbf(value.Value, Minimum, Maximum) == value;
		}
		return base.IsNullAllowed;
	}

	protected override void RaiseValueChangedEvent()
	{
		NVJ?.Invoke(this, EventArgs.Empty);
	}

	protected override void ResetValue()
	{
		QTc();
		if (base.IsNullAllowed)
		{
			SetCurrentValue(PartEditBoxBase<byte?>.ValueProperty, null);
		}
		else
		{
			SetCurrentValue(PartEditBoxBase<byte?>.ValueProperty, cda.zbf(DefaultValue, Minimum, Maximum));
		}
	}

	protected internal override bool TryConvertFromString(string textToConvert, bool canCoerce, out byte? value)
	{
		if (cda.Hbl(textToConvert, ResolvedFormat, out value))
		{
			int num = 0;
			if (Qb() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			default:
				if (!value.HasValue)
				{
					return base.IsNullAllowed;
				}
				if (canCoerce)
				{
					value = cda.zbf(value.Value, Minimum, Maximum);
				}
				return true;
			}
		}
		return false;
	}

	static ByteEditBox()
	{
		awj.QuEwGz();
		CalculatorPopupPickerStyleProperty = DependencyProperty.Register(QdM.AR8(1842), typeof(Style), typeof(ByteEditBox), new PropertyMetadata(null));
		DefaultValueProperty = DependencyProperty.Register(QdM.AR8(1898), typeof(byte), typeof(ByteEditBox), new PropertyMetadata((byte)0));
		FormatProperty = DependencyProperty.Register(QdM.AR8(1926), typeof(string), typeof(ByteEditBox), new PropertyMetadata(QdM.AR8(1942), UVi));
		int num = 0;
		if (false)
		{
			int num2;
			num = num2;
		}
		switch (num)
		{
		}
		LargeChangeProperty = DependencyProperty.Register(QdM.AR8(1948), typeof(byte), typeof(ByteEditBox), new PropertyMetadata((byte)8));
		MaximumProperty = DependencyProperty.Register(QdM.AR8(1974), typeof(byte), typeof(ByteEditBox), new PropertyMetadata(byte.MaxValue, pVZ));
		MinimumProperty = DependencyProperty.Register(QdM.AR8(1992), typeof(byte), typeof(ByteEditBox), new PropertyMetadata((byte)0, wVt));
		PickerKindProperty = DependencyProperty.Register(QdM.AR8(2010), typeof(ByteEditBoxPickerKind), typeof(ByteEditBox), new PropertyMetadata(ByteEditBoxPickerKind.Default));
		ResolvedFormatProperty = DependencyProperty.Register(QdM.AR8(2034), typeof(string), typeof(ByteEditBox), new PropertyMetadata(cda.Xbj(QdM.AR8(1942), CultureInfo.CurrentCulture)));
		SmallChangeProperty = DependencyProperty.Register(QdM.AR8(2066), typeof(byte), typeof(ByteEditBox), new PropertyMetadata((byte)1));
	}

	internal static bool x3()
	{
		return uE == null;
	}

	internal static ByteEditBox Qb()
	{
		return uE;
	}
}
