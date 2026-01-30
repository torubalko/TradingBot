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

public class SizeEditBox : PartEditBoxBase<Size?>
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
	private EventHandler NXL;

	internal static SizeEditBox pr4;

	public Size DefaultValue
	{
		get
		{
			return (Size)GetValue(DefaultValueProperty);
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

	public Size LargeChange
	{
		get
		{
			return (Size)GetValue(LargeChangeProperty);
		}
		set
		{
			SetValue(LargeChangeProperty, value);
		}
	}

	public Size Maximum
	{
		get
		{
			return (Size)GetValue(MaximumProperty);
		}
		set
		{
			SetValue(MaximumProperty, value);
		}
	}

	public Size Minimum
	{
		get
		{
			return (Size)GetValue(MinimumProperty);
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

	public Size SmallChange
	{
		get
		{
			return (Size)GetValue(SmallChangeProperty);
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
			EventHandler eventHandler = NXL;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref NXL, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = NXL;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref NXL, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public SizeEditBox()
	{
		awj.QuEwGz();
		base._002Ector();
		base.DefaultStyleKey = typeof(SizeEditBox);
	}

	private static void OX5(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		SizeEditBox sizeEditBox = (SizeEditBox)P_0;
		sizeEditBox.ResolvedFormat = qdP.uD0(P_1.NewValue as string, CultureInfo.CurrentCulture);
		sizeEditBox.InvalidateParts();
		sizeEditBox.QTc();
	}

	private static void RXc(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		SizeEditBox sizeEditBox = (SizeEditBox)P_0;
		sizeEditBox.CoerceValue(PartEditBoxBase<Size?>.ValueProperty);
	}

	protected override Size? CoerceValidValue(Size? value)
	{
		if (value.HasValue)
		{
			return ddD.jqq(value.Value, Minimum, Maximum, RoundingDecimalPlace, IsNaNAllowed, IsNegativeInfinityAllowed, IsPositiveInfinityAllowed);
		}
		return base.CoerceValidValue(value);
	}

	protected internal override string ConvertToString(Size? valueToConvert)
	{
		return ddD.NqT(valueToConvert, ResolvedFormat) ?? string.Empty;
	}

	protected override IncrementalChangeRequest<Size?> CreateIncrementalChangeRequest(IncrementalChangeRequestKind kind)
	{
		IncrementalChangeRequest<Size?> incrementalChangeRequest = new IncrementalChangeRequest<Size?>();
		incrementalChangeRequest.Kind = (base.IntermediateValue.HasValue ? kind : IncrementalChangeRequestKind.None);
		incrementalChangeRequest.LargeChange = LargeChange;
		incrementalChangeRequest.Maximum = Maximum;
		incrementalChangeRequest.Minimum = Minimum;
		incrementalChangeRequest.RoundingDecimalPlace = RoundingDecimalPlace;
		incrementalChangeRequest.SmallChange = SmallChange;
		incrementalChangeRequest.SpinWrapping = base.SpinWrapping;
		incrementalChangeRequest.Value = base.IntermediateValue ?? ddD.jqq(DefaultValue, Minimum, Maximum, RoundingDecimalPlace, IsNaNAllowed, IsNegativeInfinityAllowed, IsPositiveInfinityAllowed);
		return incrementalChangeRequest;
	}

	protected override IList<IPart> GenerateParts()
	{
		return ddD.EqI(ResolvedFormat, CultureInfo.CurrentCulture);
	}

	protected override bool IsValidValue(Size? value)
	{
		if (value.HasValue)
		{
			Size size = ddD.jqq(value.Value, Minimum, Maximum, RoundingDecimalPlace, IsNaNAllowed, IsNegativeInfinityAllowed, IsPositiveInfinityAllowed);
			return (double.IsNaN(size.Width) ? double.IsNaN(value.Value.Width) : (size.Width == value.Value.Width)) && (double.IsNaN(size.Height) ? double.IsNaN(value.Value.Height) : (size.Height == value.Value.Height));
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
		NXL?.Invoke(this, EventArgs.Empty);
	}

	protected override void ResetValue()
	{
		QTc();
		if (base.IsNullAllowed)
		{
			SetCurrentValue(PartEditBoxBase<Size?>.ValueProperty, null);
		}
		else
		{
			SetCurrentValue(PartEditBoxBase<Size?>.ValueProperty, ddD.jqq(DefaultValue, Minimum, Maximum, RoundingDecimalPlace, IsNaNAllowed, IsNegativeInfinityAllowed, IsPositiveInfinityAllowed));
		}
	}

	protected internal override bool TryConvertFromString(string textToConvert, bool canCoerce, out Size? value)
	{
		if (ddD.qqu(textToConvert, ResolvedFormat, out value))
		{
			if (!value.HasValue)
			{
				return base.IsNullAllowed;
			}
			if (canCoerce)
			{
				value = ddD.jqq(value.Value, Minimum, Maximum, RoundingDecimalPlace, IsNaNAllowed, IsNegativeInfinityAllowed, IsPositiveInfinityAllowed);
			}
			return true;
		}
		return false;
	}

	static SizeEditBox()
	{
		awj.QuEwGz();
		DefaultValueProperty = DependencyProperty.Register(QdM.AR8(1898), typeof(Size), typeof(SizeEditBox), new PropertyMetadata(ddD.jqR));
		FormatProperty = DependencyProperty.Register(QdM.AR8(1926), typeof(string), typeof(SizeEditBox), new PropertyMetadata(QdM.AR8(2648), OX5));
		IsNaNAllowedProperty = DependencyProperty.Register(QdM.AR8(3260), typeof(bool), typeof(SizeEditBox), new PropertyMetadata(false, RXc));
		IsNegativeInfinityAllowedProperty = DependencyProperty.Register(QdM.AR8(3288), typeof(bool), typeof(SizeEditBox), new PropertyMetadata(false, RXc));
		IsPositiveInfinityAllowedProperty = DependencyProperty.Register(QdM.AR8(3342), typeof(bool), typeof(SizeEditBox), new PropertyMetadata(false, RXc));
		LargeChangeProperty = DependencyProperty.Register(QdM.AR8(1948), typeof(Size), typeof(SizeEditBox), new PropertyMetadata(ddD.wqK));
		MaximumProperty = DependencyProperty.Register(QdM.AR8(1974), typeof(Size), typeof(SizeEditBox), new PropertyMetadata(ddD.rqd, RXc));
		MinimumProperty = DependencyProperty.Register(QdM.AR8(1992), typeof(Size), typeof(SizeEditBox), new PropertyMetadata(ddD.vq9, RXc));
		int num = 0;
		if (1 == 0)
		{
			int num2;
			num = num2;
		}
		switch (num)
		{
		}
		ResolvedFormatProperty = DependencyProperty.Register(QdM.AR8(2034), typeof(string), typeof(SizeEditBox), new PropertyMetadata(qdP.uD0(QdM.AR8(2648), CultureInfo.CurrentCulture)));
		RoundingDecimalPlaceProperty = DependencyProperty.Register(QdM.AR8(3396), typeof(int?), typeof(SizeEditBox), new PropertyMetadata(8, RXc));
		SmallChangeProperty = DependencyProperty.Register(QdM.AR8(2066), typeof(Size), typeof(SizeEditBox), new PropertyMetadata(ddD.oq5));
	}

	internal static bool ir0()
	{
		return pr4 == null;
	}

	internal static SizeEditBox Xr7()
	{
		return pr4;
	}
}
