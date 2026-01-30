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

public class VectorEditBox : PartEditBoxBase<Vector?>
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
	private EventHandler s0a;

	private static VectorEditBox sah;

	public Vector DefaultValue
	{
		get
		{
			return (Vector)GetValue(DefaultValueProperty);
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

	public Vector LargeChange
	{
		get
		{
			return (Vector)GetValue(LargeChangeProperty);
		}
		set
		{
			SetValue(LargeChangeProperty, value);
		}
	}

	public Vector Maximum
	{
		get
		{
			return (Vector)GetValue(MaximumProperty);
		}
		set
		{
			SetValue(MaximumProperty, value);
		}
	}

	public Vector Minimum
	{
		get
		{
			return (Vector)GetValue(MinimumProperty);
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

	public Vector SmallChange
	{
		get
		{
			return (Vector)GetValue(SmallChangeProperty);
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
			EventHandler eventHandler = s0a;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref s0a, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = s0a;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref s0a, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public VectorEditBox()
	{
		awj.QuEwGz();
		base._002Ector();
		base.DefaultStyleKey = typeof(VectorEditBox);
	}

	private static void x0j(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		VectorEditBox vectorEditBox = (VectorEditBox)P_0;
		vectorEditBox.ResolvedFormat = qdP.uD0(P_1.NewValue as string, CultureInfo.CurrentCulture);
		vectorEditBox.InvalidateParts();
		vectorEditBox.QTc();
	}

	private static void B0P(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		VectorEditBox vectorEditBox = (VectorEditBox)P_0;
		vectorEditBox.CoerceValue(PartEditBoxBase<Vector?>.ValueProperty);
	}

	protected override Vector? CoerceValidValue(Vector? value)
	{
		if (value.HasValue)
		{
			return Jdb.Xul(value.Value, Minimum, Maximum, RoundingDecimalPlace, IsNaNAllowed, IsNegativeInfinityAllowed, IsPositiveInfinityAllowed);
		}
		return base.CoerceValidValue(value);
	}

	protected internal override string ConvertToString(Vector? valueToConvert)
	{
		return Jdb.Tuj(valueToConvert, ResolvedFormat) ?? string.Empty;
	}

	protected override IncrementalChangeRequest<Vector?> CreateIncrementalChangeRequest(IncrementalChangeRequestKind kind)
	{
		IncrementalChangeRequest<Vector?> incrementalChangeRequest = new IncrementalChangeRequest<Vector?>();
		incrementalChangeRequest.Kind = (base.IntermediateValue.HasValue ? kind : IncrementalChangeRequestKind.None);
		incrementalChangeRequest.LargeChange = LargeChange;
		incrementalChangeRequest.Maximum = Maximum;
		incrementalChangeRequest.Minimum = Minimum;
		incrementalChangeRequest.RoundingDecimalPlace = RoundingDecimalPlace;
		incrementalChangeRequest.SmallChange = SmallChange;
		incrementalChangeRequest.SpinWrapping = base.SpinWrapping;
		incrementalChangeRequest.Value = base.IntermediateValue ?? Jdb.Xul(DefaultValue, Minimum, Maximum, RoundingDecimalPlace, IsNaNAllowed, IsNegativeInfinityAllowed, IsPositiveInfinityAllowed);
		return incrementalChangeRequest;
	}

	protected override IList<IPart> GenerateParts()
	{
		return Jdb.WuP(ResolvedFormat, CultureInfo.CurrentCulture);
	}

	protected override bool IsValidValue(Vector? value)
	{
		if (value.HasValue)
		{
			Vector vector = Jdb.Xul(value.Value, Minimum, Maximum, RoundingDecimalPlace, IsNaNAllowed, IsNegativeInfinityAllowed, IsPositiveInfinityAllowed);
			return (double.IsNaN(vector.X) ? double.IsNaN(value.Value.X) : (vector.X == value.Value.X)) && (double.IsNaN(vector.Y) ? double.IsNaN(value.Value.Y) : (vector.Y == value.Value.Y));
		}
		return base.IsNullAllowed;
	}

	protected override bool ProcessTextInput(string text)
	{
		yU yU;
		int num;
		if (base.IsEditable)
		{
			yU = NTJ() as yU;
			num = 2;
			if (PaA() != null)
			{
				goto IL_0005;
			}
			goto IL_0009;
		}
		goto IL_01cd;
		IL_01cd:
		bool result = false;
		goto IL_00a2;
		IL_0005:
		int num2 = default(int);
		num = num2;
		goto IL_0009;
		IL_0009:
		while (true)
		{
			switch (num)
			{
			case 1:
				goto IL_01cd;
			case 2:
				goto IL_024a;
			}
			break;
			IL_024a:
			if (yU != null)
			{
				if (text == QdM.AR8(3236) || text == QdM.AR8(3242))
				{
					goto IL_00c0;
				}
				if ((text == QdM.AR8(3248) || text == QdM.AR8(3254)) && IsNaNAllowed && base.CurrentSelectionStartOffset <= yU.StartOffset)
				{
					string naNSymbol = CultureInfo.CurrentCulture.NumberFormat.NaNSymbol;
					LTu(yU, naNSymbol, naNSymbol.Length);
					result = true;
					num = 3;
					if (PaA() == null)
					{
						continue;
					}
					goto IL_0005;
				}
			}
			goto IL_01cd;
		}
		goto IL_00a2;
		IL_00c0:
		if (IsPositiveInfinityAllowed && base.CurrentSelectionStartOffset <= yU.StartOffset)
		{
			string positiveInfinitySymbol = CultureInfo.CurrentCulture.NumberFormat.PositiveInfinitySymbol;
			LTu(yU, positiveInfinitySymbol, positiveInfinitySymbol.Length);
			result = true;
		}
		else
		{
			if (!IsNegativeInfinityAllowed || base.CurrentSelectionStartOffset != yU.StartOffset + 1 || yU.StringValue == null || !yU.StringValue.StartsWith(CultureInfo.CurrentCulture.NumberFormat.NegativeSign, StringComparison.Ordinal))
			{
				goto IL_01cd;
			}
			string negativeInfinitySymbol = CultureInfo.CurrentCulture.NumberFormat.NegativeInfinitySymbol;
			LTu(yU, negativeInfinitySymbol, negativeInfinitySymbol.Length);
			result = true;
		}
		goto IL_00a2;
		IL_00a2:
		return result;
	}

	protected override void RaiseValueChangedEvent()
	{
		s0a?.Invoke(this, EventArgs.Empty);
	}

	protected override void ResetValue()
	{
		QTc();
		if (base.IsNullAllowed)
		{
			SetCurrentValue(PartEditBoxBase<Vector?>.ValueProperty, null);
		}
		else
		{
			SetCurrentValue(PartEditBoxBase<Vector?>.ValueProperty, Jdb.Xul(DefaultValue, Minimum, Maximum, RoundingDecimalPlace, IsNaNAllowed, IsNegativeInfinityAllowed, IsPositiveInfinityAllowed));
		}
	}

	protected internal override bool TryConvertFromString(string textToConvert, bool canCoerce, out Vector? value)
	{
		if (!Jdb.luX(textToConvert, ResolvedFormat, out value))
		{
			return false;
		}
		if (!value.HasValue)
		{
			return base.IsNullAllowed;
		}
		if (canCoerce)
		{
			value = Jdb.Xul(value.Value, Minimum, Maximum, RoundingDecimalPlace, IsNaNAllowed, IsNegativeInfinityAllowed, IsPositiveInfinityAllowed);
		}
		return true;
	}

	static VectorEditBox()
	{
		awj.QuEwGz();
		DefaultValueProperty = DependencyProperty.Register(QdM.AR8(1898), typeof(Vector), typeof(VectorEditBox), new PropertyMetadata(Jdb.Bu0));
		FormatProperty = DependencyProperty.Register(QdM.AR8(1926), typeof(string), typeof(VectorEditBox), new PropertyMetadata(QdM.AR8(2648), x0j));
		IsNaNAllowedProperty = DependencyProperty.Register(QdM.AR8(3260), typeof(bool), typeof(VectorEditBox), new PropertyMetadata(false, B0P));
		IsNegativeInfinityAllowedProperty = DependencyProperty.Register(QdM.AR8(3288), typeof(bool), typeof(VectorEditBox), new PropertyMetadata(false, B0P));
		IsPositiveInfinityAllowedProperty = DependencyProperty.Register(QdM.AR8(3342), typeof(bool), typeof(VectorEditBox), new PropertyMetadata(false, B0P));
		LargeChangeProperty = DependencyProperty.Register(QdM.AR8(1948), typeof(Vector), typeof(VectorEditBox), new PropertyMetadata(Jdb.iux));
		MaximumProperty = DependencyProperty.Register(QdM.AR8(1974), typeof(Vector), typeof(VectorEditBox), new PropertyMetadata(Jdb.xuY, B0P));
		MinimumProperty = DependencyProperty.Register(QdM.AR8(1992), typeof(Vector), typeof(VectorEditBox), new PropertyMetadata(Jdb.pug, B0P));
		ResolvedFormatProperty = DependencyProperty.Register(QdM.AR8(2034), typeof(string), typeof(VectorEditBox), new PropertyMetadata(qdP.uD0(QdM.AR8(2648), CultureInfo.CurrentCulture)));
		RoundingDecimalPlaceProperty = DependencyProperty.Register(QdM.AR8(3396), typeof(int?), typeof(VectorEditBox), new PropertyMetadata(8, B0P));
		SmallChangeProperty = DependencyProperty.Register(QdM.AR8(2066), typeof(Vector), typeof(VectorEditBox), new PropertyMetadata(Jdb.Duo));
	}

	internal static bool jaS()
	{
		return sah == null;
	}

	internal static VectorEditBox PaA()
	{
		return sah;
	}
}
