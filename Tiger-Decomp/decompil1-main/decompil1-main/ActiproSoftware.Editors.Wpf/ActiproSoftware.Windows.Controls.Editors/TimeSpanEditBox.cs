using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.Editors.Primitives;

namespace ActiproSoftware.Windows.Controls.Editors;

public class TimeSpanEditBox : PartEditBoxBase<TimeSpan?>
{
	public static readonly DependencyProperty DefaultValueProperty;

	public static readonly DependencyProperty FormatProperty;

	public static readonly DependencyProperty LargeChangeProperty;

	public static readonly DependencyProperty MaximumProperty;

	public static readonly DependencyProperty MinimumProperty;

	public static readonly DependencyProperty PickerEditablePartsProperty;

	public static readonly DependencyProperty ResolvedFormatProperty;

	public static readonly DependencyProperty SmallChangeProperty;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private EventHandler wxm;

	private static TimeSpanEditBox caW;

	public TimeSpan DefaultValue
	{
		get
		{
			return (TimeSpan)GetValue(DefaultValueProperty);
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

	protected override bool HasPopupButtonWhenReadOnly => true;

	public TimeSpan LargeChange
	{
		get
		{
			return (TimeSpan)GetValue(LargeChangeProperty);
		}
		set
		{
			SetValue(LargeChangeProperty, value);
		}
	}

	public TimeSpan Maximum
	{
		get
		{
			return (TimeSpan)GetValue(MaximumProperty);
		}
		set
		{
			SetValue(MaximumProperty, value);
		}
	}

	public TimeSpan Minimum
	{
		get
		{
			return (TimeSpan)GetValue(MinimumProperty);
		}
		set
		{
			SetValue(MinimumProperty, value);
		}
	}

	public TimeSpanEditableParts PickerEditableParts
	{
		get
		{
			return (TimeSpanEditableParts)GetValue(PickerEditablePartsProperty);
		}
		private set
		{
			SetValue(PickerEditablePartsProperty, value);
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

	public TimeSpan SmallChange
	{
		get
		{
			return (TimeSpan)GetValue(SmallChangeProperty);
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
			EventHandler eventHandler = wxm;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref wxm, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = wxm;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref wxm, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public TimeSpanEditBox()
	{
		awj.QuEwGz();
		base._002Ector();
		base.DefaultStyleKey = typeof(TimeSpanEditBox);
	}

	private static void BxL(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		TimeSpanEditBox timeSpanEditBox = (TimeSpanEditBox)P_0;
		timeSpanEditBox.ResolvedFormat = xdU.Iqk(P_1.NewValue as string);
		timeSpanEditBox.InvalidateParts();
		timeSpanEditBox.QTc();
	}

	private static void bxF(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		TimeSpanEditBox timeSpanEditBox = (TimeSpanEditBox)P_0;
		timeSpanEditBox.CoerceValue(PartEditBoxBase<TimeSpan?>.ValueProperty);
	}

	private static void LxA(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		TimeSpanEditBox timeSpanEditBox = (TimeSpanEditBox)P_0;
		timeSpanEditBox.CoerceValue(PartEditBoxBase<TimeSpan?>.ValueProperty);
	}

	protected override TimeSpan? CoerceValidValue(TimeSpan? value)
	{
		if (value.HasValue)
		{
			return xdU.UqU(value.Value, Minimum, Maximum);
		}
		return base.CoerceValidValue(value);
	}

	protected internal override string ConvertToString(TimeSpan? valueToConvert)
	{
		string result = string.Empty;
		if (valueToConvert.HasValue)
		{
			result = xdU.IqJ(base.Parts, valueToConvert.Value);
		}
		return result;
	}

	protected override IncrementalChangeRequest<TimeSpan?> CreateIncrementalChangeRequest(IncrementalChangeRequestKind kind)
	{
		IncrementalChangeRequest<TimeSpan?> incrementalChangeRequest = new IncrementalChangeRequest<TimeSpan?>();
		incrementalChangeRequest.Kind = (base.IntermediateValue.HasValue ? kind : IncrementalChangeRequestKind.None);
		incrementalChangeRequest.LargeChange = LargeChange;
		incrementalChangeRequest.Maximum = Maximum;
		incrementalChangeRequest.Minimum = Minimum;
		incrementalChangeRequest.SmallChange = SmallChange;
		incrementalChangeRequest.SpinWrapping = base.SpinWrapping;
		incrementalChangeRequest.Value = base.IntermediateValue ?? xdU.UqU(DefaultValue, Minimum, Maximum);
		return incrementalChangeRequest;
	}

	protected override IList<IPart> GenerateParts()
	{
		IList<IPart> list = xdU.Bqe(ResolvedFormat);
		TimeSpanEditableParts timeSpanEditableParts = TimeSpanEditableParts.None;
		if (list.OfType<HdO>().Any() || list.OfType<Wdk>().Any())
		{
			timeSpanEditableParts |= TimeSpanEditableParts.Days;
		}
		if (list.OfType<td1>().Any())
		{
			timeSpanEditableParts |= TimeSpanEditableParts.Hours;
		}
		if (list.OfType<Ddj>().Any())
		{
			timeSpanEditableParts |= TimeSpanEditableParts.Minutes;
		}
		if (list.OfType<xdI>().Any())
		{
			timeSpanEditableParts |= TimeSpanEditableParts.Seconds;
		}
		if (list.OfType<CdA>().Any() || list.OfType<Id4>().Any())
		{
			timeSpanEditableParts |= TimeSpanEditableParts.Milliseconds;
		}
		PickerEditableParts = timeSpanEditableParts;
		return list;
	}

	protected override bool IsValidValue(TimeSpan? value)
	{
		if (value.HasValue)
		{
			TimeSpan value2 = xdU.UqU(value.Value, Minimum, Maximum);
			TimeSpan? timeSpan = value;
			return value2 == timeSpan;
		}
		return base.IsNullAllowed;
	}

	protected override void RaiseValueChangedEvent()
	{
		wxm?.Invoke(this, EventArgs.Empty);
	}

	protected override void ResetValue()
	{
		QTc();
		if (base.IsNullAllowed)
		{
			SetCurrentValue(PartEditBoxBase<TimeSpan?>.ValueProperty, null);
		}
		else
		{
			SetCurrentValue(PartEditBoxBase<TimeSpan?>.ValueProperty, xdU.UqU(DefaultValue, Minimum, Maximum));
		}
	}

	protected internal override bool TryConvertFromString(string textToConvert, bool canCoerce, out TimeSpan? value)
	{
		if (!xdU.Hqz(textToConvert, ResolvedFormat, out value))
		{
			return false;
		}
		if (value.HasValue)
		{
			if (canCoerce)
			{
				value = xdU.UqU(value.Value, Minimum, Maximum);
				int num = 0;
				if (Waa() != null)
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
		return base.IsNullAllowed;
	}

	static TimeSpanEditBox()
	{
		awj.QuEwGz();
		DefaultValueProperty = DependencyProperty.Register(QdM.AR8(1898), typeof(TimeSpan), typeof(TimeSpanEditBox), new PropertyMetadata(xdU.duM));
		FormatProperty = DependencyProperty.Register(QdM.AR8(1926), typeof(string), typeof(TimeSpanEditBox), new PropertyMetadata(QdM.AR8(18772), BxL));
		LargeChangeProperty = DependencyProperty.Register(QdM.AR8(1948), typeof(TimeSpan), typeof(TimeSpanEditBox), new PropertyMetadata(xdU.vuQ));
		MaximumProperty = DependencyProperty.Register(QdM.AR8(1974), typeof(TimeSpan), typeof(TimeSpanEditBox), new PropertyMetadata(xdU.WuV, bxF));
		MinimumProperty = DependencyProperty.Register(QdM.AR8(1992), typeof(TimeSpan), typeof(TimeSpanEditBox), new PropertyMetadata(xdU.guC, LxA));
		PickerEditablePartsProperty = DependencyProperty.Register(QdM.AR8(23094), typeof(TimeSpanEditableParts), typeof(TimeSpanEditBox), new PropertyMetadata(TimeSpanEditableParts.All));
		ResolvedFormatProperty = DependencyProperty.Register(QdM.AR8(2034), typeof(string), typeof(TimeSpanEditBox), new PropertyMetadata(xdU.Iqk(QdM.AR8(18772))));
		SmallChangeProperty = DependencyProperty.Register(QdM.AR8(2066), typeof(TimeSpan), typeof(TimeSpanEditBox), new PropertyMetadata(xdU.Wu6));
	}

	internal static bool tar()
	{
		return caW == null;
	}

	internal static TimeSpanEditBox Waa()
	{
		return caW;
	}
}
