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

public class SingleEditBox : PartEditBoxBase<float?>
{
	public static readonly DependencyProperty CalculatorPopupPickerStyleProperty;

	public static readonly DependencyProperty DefaultValueProperty;

	public static readonly DependencyProperty FormatProperty;

	public static readonly DependencyProperty IsNaNAllowedProperty;

	public static readonly DependencyProperty IsNegativeInfinityAllowedProperty;

	public static readonly DependencyProperty IsPositiveInfinityAllowedProperty;

	public static readonly DependencyProperty LargeChangeProperty;

	public static readonly DependencyProperty MaximumProperty;

	public static readonly DependencyProperty MinimumProperty;

	public static readonly DependencyProperty PickerKindProperty;

	public static readonly DependencyProperty ResolvedFormatProperty;

	public static readonly DependencyProperty RoundingDecimalPlaceProperty;

	public static readonly DependencyProperty SmallChangeProperty;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private EventHandler fXT;

	internal static SingleEditBox yrX;

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

	public float DefaultValue
	{
		get
		{
			return (float)GetValue(DefaultValueProperty);
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

	public bool IsNaNAllowed
	{
		get
		{
			return (bool)GetValue(IsNaNAllowedProperty);
		}
		set
		{
			SetValue(IsNaNAllowedProperty, value);
		}
	}

	public bool IsNegativeInfinityAllowed
	{
		get
		{
			return (bool)GetValue(IsNegativeInfinityAllowedProperty);
		}
		set
		{
			SetValue(IsNegativeInfinityAllowedProperty, value);
		}
	}

	public bool IsPositiveInfinityAllowed
	{
		get
		{
			return (bool)GetValue(IsPositiveInfinityAllowedProperty);
		}
		set
		{
			SetValue(IsPositiveInfinityAllowedProperty, value);
		}
	}

	public float LargeChange
	{
		get
		{
			return (float)GetValue(LargeChangeProperty);
		}
		set
		{
			SetValue(LargeChangeProperty, value);
		}
	}

	public float Maximum
	{
		get
		{
			return (float)GetValue(MaximumProperty);
		}
		set
		{
			SetValue(MaximumProperty, value);
		}
	}

	public float Minimum
	{
		get
		{
			return (float)GetValue(MinimumProperty);
		}
		set
		{
			SetValue(MinimumProperty, value);
		}
	}

	public SingleEditBoxPickerKind PickerKind
	{
		get
		{
			return (SingleEditBoxPickerKind)GetValue(PickerKindProperty);
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

	public int? RoundingDecimalPlace
	{
		get
		{
			return (int?)GetValue(RoundingDecimalPlaceProperty);
		}
		set
		{
			SetValue(RoundingDecimalPlaceProperty, value);
		}
	}

	public float SmallChange
	{
		get
		{
			return (float)GetValue(SmallChangeProperty);
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
			EventHandler eventHandler = fXT;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref fXT, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = fXT;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref fXT, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public SingleEditBox()
	{
		awj.QuEwGz();
		base._002Ector();
		base.DefaultStyleKey = typeof(SingleEditBox);
	}

	private static void xXg(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		SingleEditBox singleEditBox = (SingleEditBox)P_0;
		singleEditBox.ResolvedFormat = ldK.Kqf(P_1.NewValue as string, CultureInfo.CurrentCulture);
		singleEditBox.InvalidateParts();
		singleEditBox.QTc();
	}

	private static void vXo(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		SingleEditBox singleEditBox = (SingleEditBox)P_0;
		singleEditBox.CoerceValue(PartEditBoxBase<float?>.ValueProperty);
	}

	protected override float? CoerceValidValue(float? value)
	{
		if (value.HasValue)
		{
			return ldK.kqY(value.Value, Minimum, Maximum, RoundingDecimalPlace, IsNaNAllowed, IsNegativeInfinityAllowed, IsPositiveInfinityAllowed);
		}
		return base.CoerceValidValue(value);
	}

	protected internal override string ConvertToString(float? valueToConvert)
	{
		return ldK.Hq2(valueToConvert, ResolvedFormat) ?? string.Empty;
	}

	protected override IncrementalChangeRequest<float?> CreateIncrementalChangeRequest(IncrementalChangeRequestKind kind)
	{
		IncrementalChangeRequest<float?> incrementalChangeRequest = new IncrementalChangeRequest<float?>();
		incrementalChangeRequest.Kind = (base.IntermediateValue.HasValue ? kind : IncrementalChangeRequestKind.None);
		incrementalChangeRequest.LargeChange = LargeChange;
		incrementalChangeRequest.Maximum = Maximum;
		incrementalChangeRequest.Minimum = Minimum;
		incrementalChangeRequest.RoundingDecimalPlace = RoundingDecimalPlace;
		incrementalChangeRequest.SmallChange = SmallChange;
		incrementalChangeRequest.SpinWrapping = base.SpinWrapping;
		incrementalChangeRequest.Value = base.IntermediateValue ?? ldK.kqY(DefaultValue, Minimum, Maximum, RoundingDecimalPlace, IsNaNAllowed, IsNegativeInfinityAllowed, IsPositiveInfinityAllowed);
		return incrementalChangeRequest;
	}

	protected override IList<IPart> GenerateParts()
	{
		return ldK.mqa(ResolvedFormat, CultureInfo.CurrentCulture);
	}

	protected override bool IsValidValue(float? value)
	{
		if (value.HasValue)
		{
			float num = ldK.kqY(value.Value, Minimum, Maximum, RoundingDecimalPlace, IsNaNAllowed, IsNegativeInfinityAllowed, IsPositiveInfinityAllowed);
			if (float.IsNaN(num) && float.IsNaN(value.Value))
			{
				return true;
			}
			return num == value;
		}
		return base.IsNullAllowed;
	}

	protected override bool ProcessTextInput(string text)
	{
		if (NTJ() is qdi qdi)
		{
			if (!(text == QdM.AR8(3236)) && !(text == QdM.AR8(3242)))
			{
				if ((text == QdM.AR8(3248) || text == QdM.AR8(3254)) && IsNaNAllowed && (!base.IsEditable || base.CurrentSelectionStartOffset <= qdi.StartOffset))
				{
					if (base.IsEditable)
					{
						string naNSymbol = CultureInfo.CurrentCulture.NumberFormat.NaNSymbol;
						LTu(qdi, naNSymbol, 1);
					}
					else
					{
						base.Value = float.NaN;
					}
					return true;
				}
			}
			else if (base.IsEditable)
			{
				if (IsPositiveInfinityAllowed && base.CurrentSelectionStartOffset <= qdi.StartOffset)
				{
					string positiveInfinitySymbol = CultureInfo.CurrentCulture.NumberFormat.PositiveInfinitySymbol;
					LTu(qdi, positiveInfinitySymbol, positiveInfinitySymbol.Length);
					return true;
				}
				if (IsNegativeInfinityAllowed && base.CurrentSelectionStartOffset == qdi.StartOffset + 1 && qdi.StringValue != null && qdi.StringValue.StartsWith(CultureInfo.CurrentCulture.NumberFormat.NegativeSign, StringComparison.Ordinal))
				{
					string negativeInfinitySymbol = CultureInfo.CurrentCulture.NumberFormat.NegativeInfinitySymbol;
					LTu(qdi, negativeInfinitySymbol, negativeInfinitySymbol.Length);
					return true;
				}
			}
			else
			{
				if (qdi.StringValue == CultureInfo.CurrentCulture.NumberFormat.PositiveInfinitySymbol && IsNegativeInfinityAllowed)
				{
					base.Value = float.NegativeInfinity;
					return true;
				}
				if (IsPositiveInfinityAllowed)
				{
					base.Value = float.PositiveInfinity;
					return true;
				}
			}
		}
		return false;
	}

	protected override void RaiseValueChangedEvent()
	{
		fXT?.Invoke(this, EventArgs.Empty);
	}

	protected override void ResetValue()
	{
		QTc();
		if (base.IsNullAllowed)
		{
			SetCurrentValue(PartEditBoxBase<float?>.ValueProperty, null);
		}
		else
		{
			SetCurrentValue(PartEditBoxBase<float?>.ValueProperty, ldK.kqY(DefaultValue, Minimum, Maximum, RoundingDecimalPlace, IsNaNAllowed, IsNegativeInfinityAllowed, IsPositiveInfinityAllowed));
		}
	}

	protected internal override bool TryConvertFromString(string textToConvert, bool canCoerce, out float? value)
	{
		if (ldK.Gqg(textToConvert, ResolvedFormat, out value))
		{
			if (!value.HasValue)
			{
				return base.IsNullAllowed;
			}
			if (canCoerce)
			{
				value = ldK.kqY(value.Value, Minimum, Maximum, RoundingDecimalPlace, IsNaNAllowed, IsNegativeInfinityAllowed, IsPositiveInfinityAllowed);
			}
			return true;
		}
		return false;
	}

	static SingleEditBox()
	{
		awj.QuEwGz();
		CalculatorPopupPickerStyleProperty = DependencyProperty.Register(QdM.AR8(1842), typeof(Style), typeof(SingleEditBox), new PropertyMetadata(null));
		DefaultValueProperty = DependencyProperty.Register(QdM.AR8(1898), typeof(float), typeof(SingleEditBox), new PropertyMetadata(0f));
		FormatProperty = DependencyProperty.Register(QdM.AR8(1926), typeof(string), typeof(SingleEditBox), new PropertyMetadata(QdM.AR8(2648), xXg));
		IsNaNAllowedProperty = DependencyProperty.Register(QdM.AR8(3260), typeof(bool), typeof(SingleEditBox), new PropertyMetadata(false, vXo));
		IsNegativeInfinityAllowedProperty = DependencyProperty.Register(QdM.AR8(3288), typeof(bool), typeof(SingleEditBox), new PropertyMetadata(false, vXo));
		IsPositiveInfinityAllowedProperty = DependencyProperty.Register(QdM.AR8(3342), typeof(bool), typeof(SingleEditBox), new PropertyMetadata(false, vXo));
		LargeChangeProperty = DependencyProperty.Register(QdM.AR8(1948), typeof(float), typeof(SingleEditBox), new PropertyMetadata(5f));
		MaximumProperty = DependencyProperty.Register(QdM.AR8(1974), typeof(float), typeof(SingleEditBox), new PropertyMetadata(float.MaxValue, vXo));
		MinimumProperty = DependencyProperty.Register(QdM.AR8(1992), typeof(float), typeof(SingleEditBox), new PropertyMetadata(float.MinValue, vXo));
		PickerKindProperty = DependencyProperty.Register(QdM.AR8(2010), typeof(SingleEditBoxPickerKind), typeof(SingleEditBox), new PropertyMetadata(SingleEditBoxPickerKind.Default));
		ResolvedFormatProperty = DependencyProperty.Register(QdM.AR8(2034), typeof(string), typeof(SingleEditBox), new PropertyMetadata(ldK.Kqf(QdM.AR8(2648), CultureInfo.CurrentCulture)));
		RoundingDecimalPlaceProperty = DependencyProperty.Register(QdM.AR8(3396), typeof(int?), typeof(SingleEditBox), new PropertyMetadata(7, vXo));
		SmallChangeProperty = DependencyProperty.Register(QdM.AR8(2066), typeof(float), typeof(SingleEditBox), new PropertyMetadata(1f));
	}

	internal static bool YrK()
	{
		return yrX == null;
	}

	internal static SingleEditBox DrC()
	{
		return yrX;
	}
}
