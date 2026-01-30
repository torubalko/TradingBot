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

public class CornerRadiusEditBox : PartEditBoxBase<CornerRadius?>
{
	public static readonly DependencyProperty DefaultValueProperty;

	public static readonly DependencyProperty FormatProperty;

	public static readonly DependencyProperty IsNaNAllowedProperty;

	public static readonly DependencyProperty IsNegativeInfinityAllowedProperty;

	public static readonly DependencyProperty IsPositiveInfinityAllowedProperty;

	public static readonly DependencyProperty LargeChangeProperty;

	public static readonly DependencyProperty MaximumProperty;

	public static readonly DependencyProperty MinimumProperty;

	public static readonly DependencyProperty ResolvedFormatProperty;

	public static readonly DependencyProperty RoundingDecimalPlaceProperty;

	public static readonly DependencyProperty SmallChangeProperty;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private EventHandler M6c;

	internal static CornerRadiusEditBox gq;

	public CornerRadius DefaultValue
	{
		get
		{
			return (CornerRadius)GetValue(DefaultValueProperty);
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

	public CornerRadius LargeChange
	{
		get
		{
			return (CornerRadius)GetValue(LargeChangeProperty);
		}
		set
		{
			SetValue(LargeChangeProperty, value);
		}
	}

	public CornerRadius Maximum
	{
		get
		{
			return (CornerRadius)GetValue(MaximumProperty);
		}
		set
		{
			SetValue(MaximumProperty, value);
		}
	}

	public CornerRadius Minimum
	{
		get
		{
			return (CornerRadius)GetValue(MinimumProperty);
		}
		set
		{
			SetValue(MinimumProperty, value);
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

	public CornerRadius SmallChange
	{
		get
		{
			return (CornerRadius)GetValue(SmallChangeProperty);
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
			EventHandler eventHandler = M6c;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref M6c, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = M6c;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref M6c, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public CornerRadiusEditBox()
	{
		awj.QuEwGz();
		base._002Ector();
		base.DefaultStyleKey = typeof(CornerRadiusEditBox);
	}

	private static void t6d(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		CornerRadiusEditBox cornerRadiusEditBox = (CornerRadiusEditBox)P_0;
		cornerRadiusEditBox.ResolvedFormat = qdP.uD0(P_1.NewValue as string, CultureInfo.CurrentCulture);
		cornerRadiusEditBox.InvalidateParts();
		cornerRadiusEditBox.QTc();
	}

	private static void C69(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		CornerRadiusEditBox cornerRadiusEditBox = (CornerRadiusEditBox)P_0;
		cornerRadiusEditBox.CoerceValue(PartEditBoxBase<CornerRadius?>.ValueProperty);
	}

	protected override CornerRadius? CoerceValidValue(CornerRadius? value)
	{
		if (value.HasValue)
		{
			return XdB.Tb9(value.Value, Minimum, Maximum, RoundingDecimalPlace, IsNaNAllowed, IsNegativeInfinityAllowed, IsPositiveInfinityAllowed);
		}
		return base.CoerceValidValue(value);
	}

	protected internal override string ConvertToString(CornerRadius? valueToConvert)
	{
		return XdB.dbD(valueToConvert, ResolvedFormat) ?? string.Empty;
	}

	protected override IncrementalChangeRequest<CornerRadius?> CreateIncrementalChangeRequest(IncrementalChangeRequestKind kind)
	{
		IncrementalChangeRequest<CornerRadius?> incrementalChangeRequest = new IncrementalChangeRequest<CornerRadius?>();
		incrementalChangeRequest.Kind = (base.IntermediateValue.HasValue ? kind : IncrementalChangeRequestKind.None);
		incrementalChangeRequest.LargeChange = LargeChange;
		incrementalChangeRequest.Maximum = Maximum;
		incrementalChangeRequest.Minimum = Minimum;
		incrementalChangeRequest.RoundingDecimalPlace = RoundingDecimalPlace;
		incrementalChangeRequest.SmallChange = SmallChange;
		incrementalChangeRequest.SpinWrapping = base.SpinWrapping;
		incrementalChangeRequest.Value = base.IntermediateValue ?? XdB.Tb9(DefaultValue, Minimum, Maximum, RoundingDecimalPlace, IsNaNAllowed, IsNegativeInfinityAllowed, IsPositiveInfinityAllowed);
		return incrementalChangeRequest;
	}

	protected override IList<IPart> GenerateParts()
	{
		return XdB.PbG(ResolvedFormat, CultureInfo.CurrentCulture);
	}

	protected override bool IsValidValue(CornerRadius? value)
	{
		if (value.HasValue)
		{
			CornerRadius cornerRadius = XdB.Tb9(value.Value, Minimum, Maximum, RoundingDecimalPlace, IsNaNAllowed, IsNegativeInfinityAllowed, IsPositiveInfinityAllowed);
			return (double.IsNaN(cornerRadius.TopLeft) ? double.IsNaN(value.Value.TopLeft) : (cornerRadius.TopLeft == value.Value.TopLeft)) && (double.IsNaN(cornerRadius.TopRight) ? double.IsNaN(value.Value.TopRight) : (cornerRadius.TopRight == value.Value.TopRight)) && (double.IsNaN(cornerRadius.BottomRight) ? double.IsNaN(value.Value.BottomRight) : (cornerRadius.BottomRight == value.Value.BottomRight)) && (double.IsNaN(cornerRadius.BottomLeft) ? double.IsNaN(value.Value.BottomLeft) : (cornerRadius.BottomLeft == value.Value.BottomLeft));
		}
		return base.IsNullAllowed;
	}

	protected override bool ProcessTextInput(string text)
	{
		if (base.IsEditable && NTJ() is yU yU)
		{
			if (!(text == QdM.AR8(3236)) && !(text == QdM.AR8(3242)))
			{
				if ((text == QdM.AR8(3248) || text == QdM.AR8(3254)) && IsNaNAllowed && base.CurrentSelectionStartOffset <= yU.StartOffset)
				{
					string naNSymbol = CultureInfo.CurrentCulture.NumberFormat.NaNSymbol;
					LTu(yU, naNSymbol, naNSymbol.Length);
					return true;
				}
			}
			else
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
		}
		return false;
	}

	protected override void RaiseValueChangedEvent()
	{
		M6c?.Invoke(this, EventArgs.Empty);
	}

	protected override void ResetValue()
	{
		QTc();
		if (base.IsNullAllowed)
		{
			SetCurrentValue(PartEditBoxBase<CornerRadius?>.ValueProperty, null);
		}
		else
		{
			SetCurrentValue(PartEditBoxBase<CornerRadius?>.ValueProperty, XdB.Tb9(DefaultValue, Minimum, Maximum, RoundingDecimalPlace, IsNaNAllowed, IsNegativeInfinityAllowed, IsPositiveInfinityAllowed));
		}
	}

	protected internal override bool TryConvertFromString(string textToConvert, bool canCoerce, out CornerRadius? value)
	{
		if (!XdB.Gb5(textToConvert, ResolvedFormat, out value))
		{
			return false;
		}
		if (!value.HasValue)
		{
			return base.IsNullAllowed;
		}
		if (canCoerce)
		{
			value = XdB.Tb9(value.Value, Minimum, Maximum, RoundingDecimalPlace, IsNaNAllowed, IsNegativeInfinityAllowed, IsPositiveInfinityAllowed);
		}
		return true;
	}

	static CornerRadiusEditBox()
	{
		awj.QuEwGz();
		DefaultValueProperty = DependencyProperty.Register(QdM.AR8(1898), typeof(CornerRadius), typeof(CornerRadiusEditBox), new PropertyMetadata(XdB.Nbc));
		FormatProperty = DependencyProperty.Register(QdM.AR8(1926), typeof(string), typeof(CornerRadiusEditBox), new PropertyMetadata(QdM.AR8(2648), t6d));
		IsNaNAllowedProperty = DependencyProperty.Register(QdM.AR8(3260), typeof(bool), typeof(CornerRadiusEditBox), new PropertyMetadata(false, C69));
		IsNegativeInfinityAllowedProperty = DependencyProperty.Register(QdM.AR8(3288), typeof(bool), typeof(CornerRadiusEditBox), new PropertyMetadata(false, C69));
		int num = 0;
		if (1 == 0)
		{
			int num2;
			num = num2;
		}
		switch (num)
		{
		}
		IsPositiveInfinityAllowedProperty = DependencyProperty.Register(QdM.AR8(3342), typeof(bool), typeof(CornerRadiusEditBox), new PropertyMetadata(false, C69));
		LargeChangeProperty = DependencyProperty.Register(QdM.AR8(1948), typeof(CornerRadius), typeof(CornerRadiusEditBox), new PropertyMetadata(XdB.cbH));
		MaximumProperty = DependencyProperty.Register(QdM.AR8(1974), typeof(CornerRadius), typeof(CornerRadiusEditBox), new PropertyMetadata(XdB.cbL, C69));
		MinimumProperty = DependencyProperty.Register(QdM.AR8(1992), typeof(CornerRadius), typeof(CornerRadiusEditBox), new PropertyMetadata(XdB.FbF, C69));
		ResolvedFormatProperty = DependencyProperty.Register(QdM.AR8(2034), typeof(string), typeof(CornerRadiusEditBox), new PropertyMetadata(qdP.uD0(QdM.AR8(2648), CultureInfo.CurrentCulture)));
		RoundingDecimalPlaceProperty = DependencyProperty.Register(QdM.AR8(3396), typeof(int?), typeof(CornerRadiusEditBox), new PropertyMetadata(8, C69));
		SmallChangeProperty = DependencyProperty.Register(QdM.AR8(2066), typeof(CornerRadius), typeof(CornerRadiusEditBox), new PropertyMetadata(XdB.GbA));
	}

	internal static bool xn()
	{
		return gq == null;
	}

	internal static CornerRadiusEditBox Lg()
	{
		return gq;
	}
}
