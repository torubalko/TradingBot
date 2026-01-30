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

public class DoubleEditBox : PartEditBoxBase<double?>
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
	private EventHandler vMe;

	internal static DoubleEditBox IBK;

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

	public double DefaultValue
	{
		get
		{
			return (double)GetValue(DefaultValueProperty);
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

	public double LargeChange
	{
		get
		{
			return (double)GetValue(LargeChangeProperty);
		}
		set
		{
			SetValue(LargeChangeProperty, value);
		}
	}

	public double Maximum
	{
		get
		{
			return (double)GetValue(MaximumProperty);
		}
		set
		{
			SetValue(MaximumProperty, value);
		}
	}

	public double Minimum
	{
		get
		{
			return (double)GetValue(MinimumProperty);
		}
		set
		{
			SetValue(MinimumProperty, value);
		}
	}

	public DoubleEditBoxPickerKind PickerKind
	{
		get
		{
			return (DoubleEditBoxPickerKind)GetValue(PickerKindProperty);
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

	public double SmallChange
	{
		get
		{
			return (double)GetValue(SmallChangeProperty);
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
			EventHandler eventHandler = vMe;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref vMe, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = vMe;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref vMe, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public DoubleEditBox()
	{
		awj.QuEwGz();
		base._002Ector();
		base.DefaultStyleKey = typeof(DoubleEditBox);
	}

	private static void IMt(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		DoubleEditBox doubleEditBox = (DoubleEditBox)P_0;
		doubleEditBox.ResolvedFormat = qdP.uD0(P_1.NewValue as string, CultureInfo.CurrentCulture);
		doubleEditBox.InvalidateParts();
		doubleEditBox.QTc();
	}

	private static void GMn(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		DoubleEditBox doubleEditBox = (DoubleEditBox)P_0;
		doubleEditBox.CoerceValue(PartEditBoxBase<double?>.ValueProperty);
	}

	protected override double? CoerceValidValue(double? value)
	{
		if (value.HasValue)
		{
			return qdP.JDT(value.Value, Minimum, Maximum, RoundingDecimalPlace, IsNaNAllowed, IsNegativeInfinityAllowed, IsPositiveInfinityAllowed);
		}
		return base.CoerceValidValue(value);
	}

	protected internal override string ConvertToString(double? valueToConvert)
	{
		return qdP.SDl(valueToConvert, ResolvedFormat) ?? string.Empty;
	}

	protected override IncrementalChangeRequest<double?> CreateIncrementalChangeRequest(IncrementalChangeRequestKind kind)
	{
		IncrementalChangeRequest<double?> incrementalChangeRequest = new IncrementalChangeRequest<double?>();
		incrementalChangeRequest.Kind = (base.IntermediateValue.HasValue ? kind : IncrementalChangeRequestKind.None);
		incrementalChangeRequest.LargeChange = LargeChange;
		incrementalChangeRequest.Maximum = Maximum;
		incrementalChangeRequest.Minimum = Minimum;
		incrementalChangeRequest.RoundingDecimalPlace = RoundingDecimalPlace;
		incrementalChangeRequest.SmallChange = SmallChange;
		incrementalChangeRequest.SpinWrapping = base.SpinWrapping;
		incrementalChangeRequest.Value = base.IntermediateValue ?? qdP.JDT(DefaultValue, Minimum, Maximum, RoundingDecimalPlace, IsNaNAllowed, IsNegativeInfinityAllowed, IsPositiveInfinityAllowed);
		return incrementalChangeRequest;
	}

	protected override IList<IPart> GenerateParts()
	{
		return qdP.tDX(ResolvedFormat, CultureInfo.CurrentCulture);
	}

	protected override bool IsValidValue(double? value)
	{
		if (value.HasValue)
		{
			double num = qdP.JDT(value.Value, Minimum, Maximum, RoundingDecimalPlace, IsNaNAllowed, IsNegativeInfinityAllowed, IsPositiveInfinityAllowed);
			if (double.IsNaN(num) && double.IsNaN(value.Value))
			{
				return true;
			}
			return num == value;
		}
		return base.IsNullAllowed;
	}

	protected override bool ProcessTextInput(string text)
	{
		if (NTJ() is yU yU)
		{
			if (!(text == QdM.AR8(3236)) && !(text == QdM.AR8(3242)))
			{
				if ((text == QdM.AR8(3248) || text == QdM.AR8(3254)) && IsNaNAllowed && (!base.IsEditable || base.CurrentSelectionStartOffset <= yU.StartOffset))
				{
					if (base.IsEditable)
					{
						string naNSymbol = CultureInfo.CurrentCulture.NumberFormat.NaNSymbol;
						LTu(yU, naNSymbol, 1);
					}
					else
					{
						base.Value = double.NaN;
					}
					return true;
				}
			}
			else if (base.IsEditable)
			{
				if (IsPositiveInfinityAllowed && base.CurrentSelectionStartOffset <= yU.StartOffset)
				{
					string positiveInfinitySymbol = CultureInfo.CurrentCulture.NumberFormat.PositiveInfinitySymbol;
					LTu(yU, positiveInfinitySymbol, positiveInfinitySymbol.Length);
					return true;
				}
				if (IsNegativeInfinityAllowed && base.CurrentSelectionStartOffset == yU.StartOffset + 1 && yU.StringValue != null && yU.StringValue.StartsWith(CultureInfo.CurrentCulture.NumberFormat.NegativeSign, StringComparison.Ordinal))
				{
					string negativeInfinitySymbol = CultureInfo.CurrentCulture.NumberFormat.NegativeInfinitySymbol;
					LTu(yU, negativeInfinitySymbol, negativeInfinitySymbol.Length);
					return true;
				}
			}
			else
			{
				if (yU.StringValue == CultureInfo.CurrentCulture.NumberFormat.PositiveInfinitySymbol && IsNegativeInfinityAllowed)
				{
					base.Value = double.NegativeInfinity;
					return true;
				}
				if (IsPositiveInfinityAllowed)
				{
					base.Value = double.PositiveInfinity;
					return true;
				}
			}
		}
		return false;
	}

	protected override void RaiseValueChangedEvent()
	{
		vMe?.Invoke(this, EventArgs.Empty);
	}

	protected override void ResetValue()
	{
		QTc();
		if (base.IsNullAllowed)
		{
			SetCurrentValue(PartEditBoxBase<double?>.ValueProperty, null);
		}
		else
		{
			SetCurrentValue(PartEditBoxBase<double?>.ValueProperty, qdP.JDT(DefaultValue, Minimum, Maximum, RoundingDecimalPlace, IsNaNAllowed, IsNegativeInfinityAllowed, IsPositiveInfinityAllowed));
		}
	}

	protected internal override bool TryConvertFromString(string textToConvert, bool canCoerce, out double? value)
	{
		if (qdP.DDI(textToConvert, ResolvedFormat, out value))
		{
			if (!value.HasValue)
			{
				return base.IsNullAllowed;
			}
			if (canCoerce)
			{
				value = qdP.JDT(value.Value, Minimum, Maximum, RoundingDecimalPlace, IsNaNAllowed, IsNegativeInfinityAllowed, IsPositiveInfinityAllowed);
			}
			return true;
		}
		return false;
	}

	static DoubleEditBox()
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
					CalculatorPopupPickerStyleProperty = DependencyProperty.Register(QdM.AR8(1842), typeof(Style), typeof(DoubleEditBox), new PropertyMetadata(null));
					DefaultValueProperty = DependencyProperty.Register(QdM.AR8(1898), typeof(double), typeof(DoubleEditBox), new PropertyMetadata(0.0));
					FormatProperty = DependencyProperty.Register(QdM.AR8(1926), typeof(string), typeof(DoubleEditBox), new PropertyMetadata(QdM.AR8(2648), IMt));
					IsNaNAllowedProperty = DependencyProperty.Register(QdM.AR8(3260), typeof(bool), typeof(DoubleEditBox), new PropertyMetadata(false, GMn));
					IsNegativeInfinityAllowedProperty = DependencyProperty.Register(QdM.AR8(3288), typeof(bool), typeof(DoubleEditBox), new PropertyMetadata(false, GMn));
					IsPositiveInfinityAllowedProperty = DependencyProperty.Register(QdM.AR8(3342), typeof(bool), typeof(DoubleEditBox), new PropertyMetadata(false, GMn));
					LargeChangeProperty = DependencyProperty.Register(QdM.AR8(1948), typeof(double), typeof(DoubleEditBox), new PropertyMetadata(5.0));
					MaximumProperty = DependencyProperty.Register(QdM.AR8(1974), typeof(double), typeof(DoubleEditBox), new PropertyMetadata(double.MaxValue, GMn));
					MinimumProperty = DependencyProperty.Register(QdM.AR8(1992), typeof(double), typeof(DoubleEditBox), new PropertyMetadata(double.MinValue, GMn));
					PickerKindProperty = DependencyProperty.Register(QdM.AR8(2010), typeof(DoubleEditBoxPickerKind), typeof(DoubleEditBox), new PropertyMetadata(DoubleEditBoxPickerKind.Default));
					ResolvedFormatProperty = DependencyProperty.Register(QdM.AR8(2034), typeof(string), typeof(DoubleEditBox), new PropertyMetadata(qdP.uD0(QdM.AR8(2648), CultureInfo.CurrentCulture)));
					RoundingDecimalPlaceProperty = DependencyProperty.Register(QdM.AR8(3396), typeof(int?), typeof(DoubleEditBox), new PropertyMetadata(8, GMn));
					SmallChangeProperty = DependencyProperty.Register(QdM.AR8(2066), typeof(double), typeof(DoubleEditBox), new PropertyMetadata(1.0));
					return;
				}
				awj.QuEwGz();
				num2 = 0;
			}
			while (true);
		}
	}

	internal static bool JBC()
	{
		return IBK == null;
	}

	internal static DoubleEditBox SBE()
	{
		return IBK;
	}
}
