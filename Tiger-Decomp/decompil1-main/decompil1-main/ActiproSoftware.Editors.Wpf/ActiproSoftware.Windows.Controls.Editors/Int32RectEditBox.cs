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

public class Int32RectEditBox : PartEditBoxBase<Int32Rect?>
{
	public static readonly DependencyProperty DefaultValueProperty;

	public static readonly DependencyProperty FormatProperty;

	public static readonly DependencyProperty LargeChangeProperty;

	public static readonly DependencyProperty MaximumProperty;

	public static readonly DependencyProperty MinimumProperty;

	public static readonly DependencyProperty ResolvedFormatProperty;

	public static readonly DependencyProperty SmallChangeProperty;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private EventHandler KPu;

	internal static Int32RectEditBox PWP;

	public Int32Rect DefaultValue
	{
		get
		{
			return (Int32Rect)GetValue(DefaultValueProperty);
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

	public Int32Rect LargeChange
	{
		get
		{
			return (Int32Rect)GetValue(LargeChangeProperty);
		}
		set
		{
			SetValue(LargeChangeProperty, value);
		}
	}

	public Int32Rect Maximum
	{
		get
		{
			return (Int32Rect)GetValue(MaximumProperty);
		}
		set
		{
			SetValue(MaximumProperty, value);
		}
	}

	public Int32Rect Minimum
	{
		get
		{
			return (Int32Rect)GetValue(MinimumProperty);
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

	public Int32Rect SmallChange
	{
		get
		{
			return (Int32Rect)GetValue(SmallChangeProperty);
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
			EventHandler eventHandler = KPu;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref KPu, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = KPu;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref KPu, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public Int32RectEditBox()
	{
		awj.QuEwGz();
		base._002Ector();
		base.DefaultStyleKey = typeof(Int32RectEditBox);
	}

	private static void kPb(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		Int32RectEditBox int32RectEditBox = (Int32RectEditBox)P_0;
		int32RectEditBox.ResolvedFormat = qdP.uD0(P_1.NewValue as string, CultureInfo.CurrentCulture);
		int32RectEditBox.InvalidateParts();
		int32RectEditBox.QTc();
	}

	private static void dPD(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		Int32RectEditBox int32RectEditBox = (Int32RectEditBox)P_0;
		int32RectEditBox.CoerceValue(PartEditBoxBase<Int32Rect?>.ValueProperty);
	}

	private static void aPG(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		Int32RectEditBox int32RectEditBox = (Int32RectEditBox)P_0;
		int32RectEditBox.CoerceValue(PartEditBoxBase<Int32Rect?>.ValueProperty);
	}

	protected override Int32Rect? CoerceValidValue(Int32Rect? value)
	{
		if (value.HasValue)
		{
			return Vd0.LGs(value.Value, Minimum, Maximum);
		}
		return base.CoerceValidValue(value);
	}

	protected internal override string ConvertToString(Int32Rect? valueToConvert)
	{
		return Vd0.eDz(valueToConvert, ResolvedFormat) ?? string.Empty;
	}

	protected override IncrementalChangeRequest<Int32Rect?> CreateIncrementalChangeRequest(IncrementalChangeRequestKind kind)
	{
		IncrementalChangeRequest<Int32Rect?> incrementalChangeRequest = new IncrementalChangeRequest<Int32Rect?>();
		incrementalChangeRequest.Kind = (base.IntermediateValue.HasValue ? kind : IncrementalChangeRequestKind.None);
		incrementalChangeRequest.LargeChange = LargeChange;
		incrementalChangeRequest.Maximum = Maximum;
		incrementalChangeRequest.Minimum = Minimum;
		incrementalChangeRequest.SmallChange = SmallChange;
		incrementalChangeRequest.SpinWrapping = base.SpinWrapping;
		incrementalChangeRequest.Value = base.IntermediateValue ?? Vd0.LGs(DefaultValue, Minimum, Maximum);
		return incrementalChangeRequest;
	}

	protected override IList<IPart> GenerateParts()
	{
		return Vd0.gGQ(ResolvedFormat, CultureInfo.CurrentCulture);
	}

	protected override bool IsValidValue(Int32Rect? value)
	{
		if (value.HasValue)
		{
			Int32Rect value2 = Vd0.LGs(value.Value, Minimum, Maximum);
			Int32Rect? int32Rect = value;
			return value2 == int32Rect;
		}
		return base.IsNullAllowed;
	}

	protected override void RaiseValueChangedEvent()
	{
		KPu?.Invoke(this, EventArgs.Empty);
	}

	protected override void ResetValue()
	{
		QTc();
		if (!base.IsNullAllowed)
		{
			SetCurrentValue(PartEditBoxBase<Int32Rect?>.ValueProperty, Vd0.LGs(DefaultValue, Minimum, Maximum));
		}
		else
		{
			SetCurrentValue(PartEditBoxBase<Int32Rect?>.ValueProperty, null);
		}
	}

	protected internal override bool TryConvertFromString(string textToConvert, bool canCoerce, out Int32Rect? value)
	{
		if (Vd0.iGj(textToConvert, ResolvedFormat, out value))
		{
			if (!value.HasValue)
			{
				return base.IsNullAllowed;
			}
			if (canCoerce)
			{
				value = Vd0.LGs(value.Value, Minimum, Maximum);
				int num = 0;
				if (!RW8())
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
			}
			return true;
		}
		return false;
	}

	static Int32RectEditBox()
	{
		awj.QuEwGz();
		DefaultValueProperty = DependencyProperty.Register(QdM.AR8(1898), typeof(Int32Rect), typeof(Int32RectEditBox), new PropertyMetadata(Vd0.gG2));
		FormatProperty = DependencyProperty.Register(QdM.AR8(1926), typeof(string), typeof(Int32RectEditBox), new PropertyMetadata(QdM.AR8(2648), kPb));
		LargeChangeProperty = DependencyProperty.Register(QdM.AR8(1948), typeof(Int32Rect), typeof(Int32RectEditBox), new PropertyMetadata(Vd0.HGP));
		MaximumProperty = DependencyProperty.Register(QdM.AR8(1974), typeof(Int32Rect), typeof(Int32RectEditBox), new PropertyMetadata(Vd0.uGa, dPD));
		MinimumProperty = DependencyProperty.Register(QdM.AR8(1992), typeof(Int32Rect), typeof(Int32RectEditBox), new PropertyMetadata(Vd0.gGf, aPG));
		ResolvedFormatProperty = DependencyProperty.Register(QdM.AR8(2034), typeof(string), typeof(Int32RectEditBox), new PropertyMetadata(qdP.uD0(QdM.AR8(2648), CultureInfo.CurrentCulture)));
		SmallChangeProperty = DependencyProperty.Register(QdM.AR8(2066), typeof(Int32Rect), typeof(Int32RectEditBox), new PropertyMetadata(Vd0.qGl));
	}

	internal static bool RW8()
	{
		return PWP == null;
	}

	internal static Int32RectEditBox oW1()
	{
		return PWP;
	}
}
