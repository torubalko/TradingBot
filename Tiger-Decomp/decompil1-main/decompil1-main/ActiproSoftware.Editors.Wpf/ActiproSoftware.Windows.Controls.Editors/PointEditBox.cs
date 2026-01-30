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

public class PointEditBox : PartEditBoxBase<Point?>
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
	private EventHandler AfT;

	internal static PointEditBox srB;

	public Point DefaultValue
	{
		get
		{
			return (Point)GetValue(DefaultValueProperty);
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

	public Point LargeChange
	{
		get
		{
			return (Point)GetValue(LargeChangeProperty);
		}
		set
		{
			SetValue(LargeChangeProperty, value);
		}
	}

	public Point Maximum
	{
		get
		{
			return (Point)GetValue(MaximumProperty);
		}
		set
		{
			SetValue(MaximumProperty, value);
		}
	}

	public Point Minimum
	{
		get
		{
			return (Point)GetValue(MinimumProperty);
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

	public Point SmallChange
	{
		get
		{
			return (Point)GetValue(SmallChangeProperty);
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
			EventHandler eventHandler = AfT;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref AfT, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = AfT;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref AfT, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public PointEditBox()
	{
		awj.QuEwGz();
		base._002Ector();
		base.DefaultStyleKey = typeof(PointEditBox);
	}

	private static void dfg(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		PointEditBox pointEditBox = (PointEditBox)P_0;
		pointEditBox.ResolvedFormat = qdP.uD0(P_1.NewValue as string, CultureInfo.CurrentCulture);
		pointEditBox.InvalidateParts();
		pointEditBox.QTc();
	}

	private static void Rfo(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		PointEditBox pointEditBox = (PointEditBox)P_0;
		pointEditBox.CoerceValue(PartEditBoxBase<Point?>.ValueProperty);
	}

	protected override Point? CoerceValidValue(Point? value)
	{
		if (value.HasValue)
		{
			return HdN.mGL(value.Value, Minimum, Maximum, RoundingDecimalPlace, IsNaNAllowed, IsNegativeInfinityAllowed, IsPositiveInfinityAllowed);
		}
		return base.CoerceValidValue(value);
	}

	protected internal override string ConvertToString(Point? valueToConvert)
	{
		return HdN.hGd(valueToConvert, ResolvedFormat) ?? string.Empty;
	}

	protected override IncrementalChangeRequest<Point?> CreateIncrementalChangeRequest(IncrementalChangeRequestKind kind)
	{
		IncrementalChangeRequest<Point?> incrementalChangeRequest = new IncrementalChangeRequest<Point?>();
		incrementalChangeRequest.Kind = (base.IntermediateValue.HasValue ? kind : IncrementalChangeRequestKind.None);
		incrementalChangeRequest.LargeChange = LargeChange;
		incrementalChangeRequest.Maximum = Maximum;
		incrementalChangeRequest.Minimum = Minimum;
		incrementalChangeRequest.RoundingDecimalPlace = RoundingDecimalPlace;
		incrementalChangeRequest.SmallChange = SmallChange;
		incrementalChangeRequest.SpinWrapping = base.SpinWrapping;
		incrementalChangeRequest.Value = base.IntermediateValue ?? HdN.mGL(DefaultValue, Minimum, Maximum, RoundingDecimalPlace, IsNaNAllowed, IsNegativeInfinityAllowed, IsPositiveInfinityAllowed);
		return incrementalChangeRequest;
	}

	protected override IList<IPart> GenerateParts()
	{
		return HdN.AG9(ResolvedFormat, CultureInfo.CurrentCulture);
	}

	protected override bool IsValidValue(Point? value)
	{
		if (value.HasValue)
		{
			Point point = HdN.mGL(value.Value, Minimum, Maximum, RoundingDecimalPlace, IsNaNAllowed, IsNegativeInfinityAllowed, IsPositiveInfinityAllowed);
			return (double.IsNaN(point.X) ? double.IsNaN(value.Value.X) : (point.X == value.Value.X)) && (double.IsNaN(point.Y) ? double.IsNaN(value.Value.Y) : (point.Y == value.Value.Y));
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
		AfT?.Invoke(this, EventArgs.Empty);
	}

	protected override void ResetValue()
	{
		QTc();
		if (base.IsNullAllowed)
		{
			SetCurrentValue(PartEditBoxBase<Point?>.ValueProperty, null);
		}
		else
		{
			SetCurrentValue(PartEditBoxBase<Point?>.ValueProperty, HdN.mGL(DefaultValue, Minimum, Maximum, RoundingDecimalPlace, IsNaNAllowed, IsNegativeInfinityAllowed, IsPositiveInfinityAllowed));
		}
	}

	protected internal override bool TryConvertFromString(string textToConvert, bool canCoerce, out Point? value)
	{
		bool result;
		if (!HdN.QGF(textToConvert, ResolvedFormat, out value))
		{
			result = false;
		}
		else if (value.HasValue)
		{
			if (canCoerce)
			{
				value = HdN.mGL(value.Value, Minimum, Maximum, RoundingDecimalPlace, IsNaNAllowed, IsNegativeInfinityAllowed, IsPositiveInfinityAllowed);
			}
			result = true;
			int num = 0;
			if (!qrW())
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
			result = base.IsNullAllowed;
		}
		return result;
	}

	static PointEditBox()
	{
		awj.QuEwGz();
		DefaultValueProperty = DependencyProperty.Register(QdM.AR8(1898), typeof(Point), typeof(PointEditBox), new PropertyMetadata(HdN.FG3));
		FormatProperty = DependencyProperty.Register(QdM.AR8(1926), typeof(string), typeof(PointEditBox), new PropertyMetadata(QdM.AR8(2648), dfg));
		IsNaNAllowedProperty = DependencyProperty.Register(QdM.AR8(3260), typeof(bool), typeof(PointEditBox), new PropertyMetadata(false, Rfo));
		IsNegativeInfinityAllowedProperty = DependencyProperty.Register(QdM.AR8(3288), typeof(bool), typeof(PointEditBox), new PropertyMetadata(false, Rfo));
		IsPositiveInfinityAllowedProperty = DependencyProperty.Register(QdM.AR8(3342), typeof(bool), typeof(PointEditBox), new PropertyMetadata(false, Rfo));
		LargeChangeProperty = DependencyProperty.Register(QdM.AR8(1948), typeof(Point), typeof(PointEditBox), new PropertyMetadata(HdN.JGA));
		MaximumProperty = DependencyProperty.Register(QdM.AR8(1974), typeof(Point), typeof(PointEditBox), new PropertyMetadata(HdN.YGy, Rfo));
		MinimumProperty = DependencyProperty.Register(QdM.AR8(1992), typeof(Point), typeof(PointEditBox), new PropertyMetadata(HdN.tGm, Rfo));
		ResolvedFormatProperty = DependencyProperty.Register(QdM.AR8(2034), typeof(string), typeof(PointEditBox), new PropertyMetadata(qdP.uD0(QdM.AR8(2648), CultureInfo.CurrentCulture)));
		RoundingDecimalPlaceProperty = DependencyProperty.Register(QdM.AR8(3396), typeof(int?), typeof(PointEditBox), new PropertyMetadata(8, Rfo));
		SmallChangeProperty = DependencyProperty.Register(QdM.AR8(2066), typeof(Point), typeof(PointEditBox), new PropertyMetadata(HdN.xGS));
	}

	internal static bool qrW()
	{
		return srB == null;
	}

	internal static PointEditBox lrr()
	{
		return srB;
	}
}
