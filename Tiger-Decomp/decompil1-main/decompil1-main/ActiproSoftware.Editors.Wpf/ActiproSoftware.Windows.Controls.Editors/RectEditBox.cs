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

public class RectEditBox : PartEditBoxBase<Rect?>
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
	private EventHandler KlH;

	private static RectEditBox zrZ;

	public Rect DefaultValue
	{
		get
		{
			return (Rect)GetValue(DefaultValueProperty);
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

	public Rect LargeChange
	{
		get
		{
			return (Rect)GetValue(LargeChangeProperty);
		}
		set
		{
			SetValue(LargeChangeProperty, value);
		}
	}

	public Rect Maximum
	{
		get
		{
			return (Rect)GetValue(MaximumProperty);
		}
		set
		{
			SetValue(MaximumProperty, value);
		}
	}

	public Rect Minimum
	{
		get
		{
			return (Rect)GetValue(MinimumProperty);
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

	public Rect SmallChange
	{
		get
		{
			return (Rect)GetValue(SmallChangeProperty);
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
			EventHandler eventHandler = KlH;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref KlH, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = KlH;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref KlH, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public RectEditBox()
	{
		awj.QuEwGz();
		base._002Ector();
		base.DefaultStyleKey = typeof(RectEditBox);
	}

	private static void Ol9(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		RectEditBox rectEditBox = (RectEditBox)P_0;
		rectEditBox.ResolvedFormat = qdP.uD0(P_1.NewValue as string, CultureInfo.CurrentCulture);
		rectEditBox.InvalidateParts();
		rectEditBox.QTc();
	}

	private static void sl5(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		RectEditBox rectEditBox = (RectEditBox)P_0;
		rectEditBox.CoerceValue(PartEditBoxBase<Rect?>.ValueProperty);
	}

	protected override Rect? CoerceValidValue(Rect? value)
	{
		if (value.HasValue)
		{
			return kdo.XGZ(value.Value, Minimum, Maximum, RoundingDecimalPlace, IsNaNAllowed, IsNegativeInfinityAllowed, IsPositiveInfinityAllowed);
		}
		return base.CoerceValidValue(value);
	}

	protected internal override string ConvertToString(Rect? valueToConvert)
	{
		return kdo.QG1(valueToConvert, ResolvedFormat) ?? string.Empty;
	}

	protected override IncrementalChangeRequest<Rect?> CreateIncrementalChangeRequest(IncrementalChangeRequestKind kind)
	{
		IncrementalChangeRequest<Rect?> incrementalChangeRequest = new IncrementalChangeRequest<Rect?>();
		incrementalChangeRequest.Kind = (base.IntermediateValue.HasValue ? kind : IncrementalChangeRequestKind.None);
		incrementalChangeRequest.LargeChange = LargeChange;
		incrementalChangeRequest.Maximum = Maximum;
		incrementalChangeRequest.Minimum = Minimum;
		incrementalChangeRequest.RoundingDecimalPlace = RoundingDecimalPlace;
		incrementalChangeRequest.SmallChange = SmallChange;
		incrementalChangeRequest.SpinWrapping = base.SpinWrapping;
		incrementalChangeRequest.Value = base.IntermediateValue ?? kdo.XGZ(DefaultValue, Minimum, Maximum, RoundingDecimalPlace, IsNaNAllowed, IsNegativeInfinityAllowed, IsPositiveInfinityAllowed);
		return incrementalChangeRequest;
	}

	protected override IList<IPart> GenerateParts()
	{
		return kdo.PG8(ResolvedFormat, CultureInfo.CurrentCulture);
	}

	protected override bool IsValidValue(Rect? value)
	{
		if (value.HasValue)
		{
			Rect rect = kdo.XGZ(value.Value, Minimum, Maximum, RoundingDecimalPlace, IsNaNAllowed, IsNegativeInfinityAllowed, IsPositiveInfinityAllowed);
			return (double.IsNaN(rect.X) ? double.IsNaN(value.Value.X) : (rect.X == value.Value.X)) && (double.IsNaN(rect.Y) ? double.IsNaN(value.Value.Y) : (rect.Y == value.Value.Y)) && (double.IsNaN(rect.Width) ? double.IsNaN(value.Value.Width) : (rect.Width == value.Value.Width)) && (double.IsNaN(rect.Height) ? double.IsNaN(value.Value.Height) : (rect.Height == value.Value.Height));
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
		KlH?.Invoke(this, EventArgs.Empty);
	}

	protected override void ResetValue()
	{
		QTc();
		if (base.IsNullAllowed)
		{
			SetCurrentValue(PartEditBoxBase<Rect?>.ValueProperty, null);
		}
		else
		{
			SetCurrentValue(PartEditBoxBase<Rect?>.ValueProperty, kdo.XGZ(DefaultValue, Minimum, Maximum, RoundingDecimalPlace, IsNaNAllowed, IsNegativeInfinityAllowed, IsPositiveInfinityAllowed));
		}
	}

	protected internal override bool TryConvertFromString(string textToConvert, bool canCoerce, out Rect? value)
	{
		if (kdo.xGt(textToConvert, ResolvedFormat, out value))
		{
			int num = 0;
			if (!OrR())
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
					value = kdo.XGZ(value.Value, Minimum, Maximum, RoundingDecimalPlace, IsNaNAllowed, IsNegativeInfinityAllowed, IsPositiveInfinityAllowed);
				}
				return true;
			}
		}
		return false;
	}

	static RectEditBox()
	{
		awj.QuEwGz();
		DefaultValueProperty = DependencyProperty.Register(QdM.AR8(1898), typeof(Rect), typeof(RectEditBox), new PropertyMetadata(kdo.nGJ));
		FormatProperty = DependencyProperty.Register(QdM.AR8(1926), typeof(string), typeof(RectEditBox), new PropertyMetadata(QdM.AR8(2648), Ol9));
		IsNaNAllowedProperty = DependencyProperty.Register(QdM.AR8(3260), typeof(bool), typeof(RectEditBox), new PropertyMetadata(false, sl5));
		IsNegativeInfinityAllowedProperty = DependencyProperty.Register(QdM.AR8(3288), typeof(bool), typeof(RectEditBox), new PropertyMetadata(false, sl5));
		IsPositiveInfinityAllowedProperty = DependencyProperty.Register(QdM.AR8(3342), typeof(bool), typeof(RectEditBox), new PropertyMetadata(false, sl5));
		LargeChangeProperty = DependencyProperty.Register(QdM.AR8(1948), typeof(Rect), typeof(RectEditBox), new PropertyMetadata(kdo.nGn));
		MaximumProperty = DependencyProperty.Register(QdM.AR8(1974), typeof(Rect), typeof(RectEditBox), new PropertyMetadata(kdo.wGe, sl5));
		MinimumProperty = DependencyProperty.Register(QdM.AR8(1992), typeof(Rect), typeof(RectEditBox), new PropertyMetadata(kdo.bGk, sl5));
		ResolvedFormatProperty = DependencyProperty.Register(QdM.AR8(2034), typeof(string), typeof(RectEditBox), new PropertyMetadata(qdP.uD0(QdM.AR8(2648), CultureInfo.CurrentCulture)));
		RoundingDecimalPlaceProperty = DependencyProperty.Register(QdM.AR8(3396), typeof(int?), typeof(RectEditBox), new PropertyMetadata(8, sl5));
		int num = 0;
		if (1 == 0)
		{
			int num2;
			num = num2;
		}
		switch (num)
		{
		}
		SmallChangeProperty = DependencyProperty.Register(QdM.AR8(2066), typeof(Rect), typeof(RectEditBox), new PropertyMetadata(kdo.jGE));
	}

	internal static bool OrR()
	{
		return zrZ == null;
	}

	internal static RectEditBox Ari()
	{
		return zrZ;
	}
}
