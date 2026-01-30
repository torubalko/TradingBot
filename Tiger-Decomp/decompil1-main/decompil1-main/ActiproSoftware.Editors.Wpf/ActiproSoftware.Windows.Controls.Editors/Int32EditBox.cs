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

public class Int32EditBox : PartEditBoxBase<int?>
{
	public static readonly DependencyProperty CalculatorPopupPickerStyleProperty;

	public static readonly DependencyProperty DefaultValueProperty;

	public static readonly DependencyProperty FormatProperty;

	public static readonly DependencyProperty LargeChangeProperty;

	public static readonly DependencyProperty MaximumProperty;

	public static readonly DependencyProperty MinimumProperty;

	public static readonly DependencyProperty PickerKindProperty;

	public static readonly DependencyProperty ResolvedFormatProperty;

	public static readonly DependencyProperty SmallChangeProperty;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private EventHandler gPf;

	private static Int32EditBox zWG;

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

	public int DefaultValue
	{
		get
		{
			return (int)GetValue(DefaultValueProperty);
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

	public int LargeChange
	{
		get
		{
			return (int)GetValue(LargeChangeProperty);
		}
		set
		{
			SetValue(LargeChangeProperty, value);
		}
	}

	public int Maximum
	{
		get
		{
			return (int)GetValue(MaximumProperty);
		}
		set
		{
			SetValue(MaximumProperty, value);
		}
	}

	public int Minimum
	{
		get
		{
			return (int)GetValue(MinimumProperty);
		}
		set
		{
			SetValue(MinimumProperty, value);
		}
	}

	public Int32EditBoxPickerKind PickerKind
	{
		get
		{
			return (Int32EditBoxPickerKind)GetValue(PickerKindProperty);
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

	public int SmallChange
	{
		get
		{
			return (int)GetValue(SmallChangeProperty);
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
			EventHandler eventHandler = gPf;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref gPf, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = gPf;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref gPf, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public Int32EditBox()
	{
		awj.QuEwGz();
		base._002Ector();
		base.DefaultStyleKey = typeof(Int32EditBox);
	}

	private static void MPj(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		Int32EditBox int32EditBox = (Int32EditBox)P_0;
		int32EditBox.ResolvedFormat = cdY.MDE(P_1.NewValue as string, CultureInfo.CurrentCulture);
		int32EditBox.InvalidateParts();
		int32EditBox.QTc();
	}

	private static void MPP(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		Int32EditBox int32EditBox = (Int32EditBox)P_0;
		int32EditBox.CoerceValue(PartEditBoxBase<int?>.ValueProperty);
	}

	private static void SP2(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		Int32EditBox int32EditBox = (Int32EditBox)P_0;
		int32EditBox.CoerceValue(PartEditBoxBase<int?>.ValueProperty);
	}

	protected override int? CoerceValidValue(int? value)
	{
		if (value.HasValue)
		{
			return cdY.vDh(value.Value, Minimum, Maximum);
		}
		return base.CoerceValidValue(value);
	}

	protected internal override string ConvertToString(int? valueToConvert)
	{
		return cdY.JDe(valueToConvert, ResolvedFormat) ?? string.Empty;
	}

	protected override IncrementalChangeRequest<int?> CreateIncrementalChangeRequest(IncrementalChangeRequestKind kind)
	{
		IncrementalChangeRequest<int?> incrementalChangeRequest = new IncrementalChangeRequest<int?>();
		incrementalChangeRequest.Kind = (base.IntermediateValue.HasValue ? kind : IncrementalChangeRequestKind.None);
		incrementalChangeRequest.LargeChange = LargeChange;
		incrementalChangeRequest.Maximum = Maximum;
		incrementalChangeRequest.Minimum = Minimum;
		incrementalChangeRequest.SmallChange = SmallChange;
		incrementalChangeRequest.SpinWrapping = base.SpinWrapping;
		incrementalChangeRequest.Value = base.IntermediateValue ?? cdY.vDh(DefaultValue, Minimum, Maximum);
		return incrementalChangeRequest;
	}

	protected override IList<IPart> GenerateParts()
	{
		return cdY.oDk(ResolvedFormat, CultureInfo.CurrentCulture);
	}

	protected override bool IsValidValue(int? value)
	{
		if (value.HasValue)
		{
			return cdY.vDh(value.Value, Minimum, Maximum) == value;
		}
		return base.IsNullAllowed;
	}

	protected override void RaiseValueChangedEvent()
	{
		gPf?.Invoke(this, EventArgs.Empty);
	}

	protected override void ResetValue()
	{
		QTc();
		if (!base.IsNullAllowed)
		{
			SetCurrentValue(PartEditBoxBase<int?>.ValueProperty, cdY.vDh(DefaultValue, Minimum, Maximum));
		}
		else
		{
			SetCurrentValue(PartEditBoxBase<int?>.ValueProperty, null);
		}
	}

	protected internal override bool TryConvertFromString(string textToConvert, bool canCoerce, out int? value)
	{
		if (cdY.cDw(textToConvert, ResolvedFormat, out value))
		{
			if (!value.HasValue)
			{
				return base.IsNullAllowed;
			}
			if (canCoerce)
			{
				value = cdY.vDh(value.Value, Minimum, Maximum);
			}
			return true;
		}
		return false;
	}

	static Int32EditBox()
	{
		awj.QuEwGz();
		CalculatorPopupPickerStyleProperty = DependencyProperty.Register(QdM.AR8(1842), typeof(Style), typeof(Int32EditBox), new PropertyMetadata(null));
		DefaultValueProperty = DependencyProperty.Register(QdM.AR8(1898), typeof(int), typeof(Int32EditBox), new PropertyMetadata(0));
		FormatProperty = DependencyProperty.Register(QdM.AR8(1926), typeof(string), typeof(Int32EditBox), new PropertyMetadata(QdM.AR8(1942), MPj));
		LargeChangeProperty = DependencyProperty.Register(QdM.AR8(1948), typeof(int), typeof(Int32EditBox), new PropertyMetadata(5));
		MaximumProperty = DependencyProperty.Register(QdM.AR8(1974), typeof(int), typeof(Int32EditBox), new PropertyMetadata(int.MaxValue, MPP));
		MinimumProperty = DependencyProperty.Register(QdM.AR8(1992), typeof(int), typeof(Int32EditBox), new PropertyMetadata(int.MinValue, SP2));
		int num = 0;
		if (1 == 0)
		{
			int num2;
			num = num2;
		}
		switch (num)
		{
		}
		PickerKindProperty = DependencyProperty.Register(QdM.AR8(2010), typeof(Int32EditBoxPickerKind), typeof(Int32EditBox), new PropertyMetadata(Int32EditBoxPickerKind.Default));
		ResolvedFormatProperty = DependencyProperty.Register(QdM.AR8(2034), typeof(string), typeof(Int32EditBox), new PropertyMetadata(cdY.MDE(QdM.AR8(1942), CultureInfo.CurrentCulture)));
		SmallChangeProperty = DependencyProperty.Register(QdM.AR8(2066), typeof(int), typeof(Int32EditBox), new PropertyMetadata(1));
	}

	internal static bool qWJ()
	{
		return zWG == null;
	}

	internal static Int32EditBox QWh()
	{
		return zWG;
	}
}
