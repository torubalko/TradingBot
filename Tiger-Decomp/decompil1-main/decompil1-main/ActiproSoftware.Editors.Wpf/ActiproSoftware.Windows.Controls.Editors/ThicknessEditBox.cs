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

public class ThicknessEditBox : PartEditBoxBase<Thickness?>
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

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private EventHandler lXh;

	private static ThicknessEditBox LrM;

	public Thickness DefaultValue
	{
		get
		{
			return (Thickness)GetValue(DefaultValueProperty);
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

	public Thickness LargeChange
	{
		get
		{
			return (Thickness)GetValue(LargeChangeProperty);
		}
		set
		{
			SetValue(LargeChangeProperty, value);
		}
	}

	public Thickness Maximum
	{
		get
		{
			return (Thickness)GetValue(MaximumProperty);
		}
		set
		{
			SetValue(MaximumProperty, value);
		}
	}

	public Thickness Minimum
	{
		get
		{
			return (Thickness)GetValue(MinimumProperty);
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

	public Thickness SmallChange
	{
		get
		{
			return (Thickness)GetValue(SmallChangeProperty);
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
			EventHandler eventHandler = lXh;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref lXh, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = lXh;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref lXh, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public ThicknessEditBox()
	{
		awj.QuEwGz();
		base._002Ector();
		base.DefaultStyleKey = typeof(ThicknessEditBox);
	}

	private static void xX7(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		ThicknessEditBox thicknessEditBox = (ThicknessEditBox)P_0;
		thicknessEditBox.ResolvedFormat = qdP.uD0(P_1.NewValue as string, CultureInfo.CurrentCulture);
		thicknessEditBox.InvalidateParts();
		thicknessEditBox.QTc();
	}

	private static void OX4(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		ThicknessEditBox thicknessEditBox = (ThicknessEditBox)P_0;
		thicknessEditBox.CoerceValue(PartEditBoxBase<Thickness?>.ValueProperty);
	}

	protected override Thickness? CoerceValidValue(Thickness? value)
	{
		if (value.HasValue)
		{
			return pdg.mqm(value.Value, Minimum, Maximum, RoundingDecimalPlace, IsNaNAllowed, IsNegativeInfinityAllowed, IsPositiveInfinityAllowed);
		}
		return base.CoerceValidValue(value);
	}

	protected internal override string ConvertToString(Thickness? valueToConvert)
	{
		return pdg.Vqc(valueToConvert, ResolvedFormat) ?? string.Empty;
	}

	protected override IncrementalChangeRequest<Thickness?> CreateIncrementalChangeRequest(IncrementalChangeRequestKind kind)
	{
		IncrementalChangeRequest<Thickness?> incrementalChangeRequest = new IncrementalChangeRequest<Thickness?>();
		incrementalChangeRequest.Kind = (base.IntermediateValue.HasValue ? kind : IncrementalChangeRequestKind.None);
		incrementalChangeRequest.LargeChange = LargeChange;
		incrementalChangeRequest.Maximum = Maximum;
		incrementalChangeRequest.Minimum = Minimum;
		incrementalChangeRequest.RoundingDecimalPlace = RoundingDecimalPlace;
		incrementalChangeRequest.SmallChange = SmallChange;
		incrementalChangeRequest.SpinWrapping = base.SpinWrapping;
		incrementalChangeRequest.Value = base.IntermediateValue ?? pdg.mqm(DefaultValue, Minimum, Maximum, RoundingDecimalPlace, IsNaNAllowed, IsNegativeInfinityAllowed, IsPositiveInfinityAllowed);
		return incrementalChangeRequest;
	}

	protected override IList<IPart> GenerateParts()
	{
		return pdg.nqH(ResolvedFormat, CultureInfo.CurrentCulture);
	}

	protected override bool IsValidValue(Thickness? value)
	{
		if (value.HasValue)
		{
			Thickness thickness = pdg.mqm(value.Value, Minimum, Maximum, RoundingDecimalPlace, IsNaNAllowed, IsNegativeInfinityAllowed, IsPositiveInfinityAllowed);
			return (double.IsNaN(thickness.Left) ? double.IsNaN(value.Value.Left) : (thickness.Left == value.Value.Left)) && (double.IsNaN(thickness.Top) ? double.IsNaN(value.Value.Top) : (thickness.Top == value.Value.Top)) && (double.IsNaN(thickness.Right) ? double.IsNaN(value.Value.Right) : (thickness.Right == value.Value.Right)) && (double.IsNaN(thickness.Bottom) ? double.IsNaN(value.Value.Bottom) : (thickness.Bottom == value.Value.Bottom));
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
		lXh?.Invoke(this, EventArgs.Empty);
	}

	protected override void ResetValue()
	{
		QTc();
		if (base.IsNullAllowed)
		{
			SetCurrentValue(PartEditBoxBase<Thickness?>.ValueProperty, null);
		}
		else
		{
			SetCurrentValue(PartEditBoxBase<Thickness?>.ValueProperty, pdg.mqm(DefaultValue, Minimum, Maximum, RoundingDecimalPlace, IsNaNAllowed, IsNegativeInfinityAllowed, IsPositiveInfinityAllowed));
		}
	}

	protected internal override bool TryConvertFromString(string textToConvert, bool canCoerce, out Thickness? value)
	{
		bool result;
		if (!pdg.bqS(textToConvert, ResolvedFormat, out value))
		{
			result = false;
		}
		else if (!value.HasValue)
		{
			result = base.IsNullAllowed;
			int num = 0;
			if (!hrT())
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
			if (canCoerce)
			{
				value = pdg.mqm(value.Value, Minimum, Maximum, RoundingDecimalPlace, IsNaNAllowed, IsNegativeInfinityAllowed, IsPositiveInfinityAllowed);
			}
			result = true;
		}
		return result;
	}

	static ThicknessEditBox()
	{
		awj.QuEwGz();
		DefaultValueProperty = DependencyProperty.Register(QdM.AR8(1898), typeof(Thickness), typeof(ThicknessEditBox), new PropertyMetadata(pdg.Xq8));
		FormatProperty = DependencyProperty.Register(QdM.AR8(1926), typeof(string), typeof(ThicknessEditBox), new PropertyMetadata(QdM.AR8(2648), xX7));
		IsNaNAllowedProperty = DependencyProperty.Register(QdM.AR8(3260), typeof(bool), typeof(ThicknessEditBox), new PropertyMetadata(false, OX4));
		int num = 0;
		if (false)
		{
			int num2;
			num = num2;
		}
		switch (num)
		{
		}
		IsNegativeInfinityAllowedProperty = DependencyProperty.Register(QdM.AR8(3288), typeof(bool), typeof(ThicknessEditBox), new PropertyMetadata(false, OX4));
		IsPositiveInfinityAllowedProperty = DependencyProperty.Register(QdM.AR8(3342), typeof(bool), typeof(ThicknessEditBox), new PropertyMetadata(false, OX4));
		LargeChangeProperty = DependencyProperty.Register(QdM.AR8(1948), typeof(Thickness), typeof(ThicknessEditBox), new PropertyMetadata(pdg.Nq1));
		MaximumProperty = DependencyProperty.Register(QdM.AR8(1974), typeof(Thickness), typeof(ThicknessEditBox), new PropertyMetadata(pdg.Fqr, OX4));
		MinimumProperty = DependencyProperty.Register(QdM.AR8(1992), typeof(Thickness), typeof(ThicknessEditBox), new PropertyMetadata(pdg.qqv, OX4));
		ResolvedFormatProperty = DependencyProperty.Register(QdM.AR8(2034), typeof(string), typeof(ThicknessEditBox), new PropertyMetadata(qdP.uD0(QdM.AR8(2648), CultureInfo.CurrentCulture)));
		RoundingDecimalPlaceProperty = DependencyProperty.Register(QdM.AR8(3396), typeof(int?), typeof(ThicknessEditBox), new PropertyMetadata(8, OX4));
		SmallChangeProperty = DependencyProperty.Register(QdM.AR8(2066), typeof(Thickness), typeof(ThicknessEditBox), new PropertyMetadata(pdg.qqp));
	}

	internal static bool hrT()
	{
		return LrM == null;
	}

	internal static ThicknessEditBox Brk()
	{
		return LrM;
	}
}
