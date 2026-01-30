using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.Editors.Primitives;

namespace ActiproSoftware.Windows.Controls.Editors;

[TemplatePart(Name = "PART_MonthCalendar", Type = typeof(MonthCalendar))]
public class DatePicker : PickerBase
{
	private MonthCalendar dMY;

	public static readonly DependencyProperty CanRetainTimeProperty;

	public static readonly DependencyProperty IsNullAllowedProperty;

	public static readonly DependencyProperty MaximumProperty;

	public static readonly DependencyProperty MinimumProperty;

	public static readonly DependencyProperty ValueProperty;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private EventHandler TMg;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private EventHandler zMo;

	internal static DatePicker SB1;

	public bool CanRetainTime
	{
		get
		{
			return (bool)GetValue(CanRetainTimeProperty);
		}
		set
		{
			SetValue(CanRetainTimeProperty, value);
		}
	}

	public bool IsNullAllowed
	{
		get
		{
			return (bool)GetValue(IsNullAllowedProperty);
		}
		set
		{
			SetValue(IsNullAllowedProperty, value);
		}
	}

	public DateTime Maximum
	{
		get
		{
			return (DateTime)GetValue(MaximumProperty);
		}
		set
		{
			SetValue(MaximumProperty, value);
		}
	}

	public DateTime Minimum
	{
		get
		{
			return (DateTime)GetValue(MinimumProperty);
		}
		set
		{
			SetValue(MinimumProperty, value);
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1721:PropertyNamesShouldNotMatchGetMethods")]
	public DateTime? Value
	{
		get
		{
			return (DateTime?)GetValue(ValueProperty);
		}
		set
		{
			SetValue(ValueProperty, value);
		}
	}

	public event EventHandler ValueChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = TMg;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref TMg, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = TMg;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref TMg, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler ValueCommitted
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = zMo;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref zMo, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = zMo;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref zMo, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public DatePicker()
	{
		awj.QuEwGz();
		base._002Ector();
		base.DefaultStyleKey = typeof(DatePicker);
	}

	private static object AMs(DependencyObject P_0, object P_1)
	{
		DatePicker datePicker = (DatePicker)P_0;
		if (P_1 == null)
		{
			return P_1;
		}
		return ldZ.BDP((DateTime)P_1, datePicker.Minimum, datePicker.Maximum);
	}

	[SpecialName]
	private MonthCalendar pMX()
	{
		return dMY;
	}

	[SpecialName]
	private void DMx(MonthCalendar value)
	{
		if (dMY == value)
		{
			return;
		}
		if (dMY != null)
		{
			dMY.SelectionCommitted -= HM2;
		}
		dMY = value;
		if (dMY != null)
		{
			dMY.SelectionCommitted += HM2;
			int num = 0;
			if (!VBQ())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}
	}

	private static void hMj(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		DatePicker datePicker = (DatePicker)P_0;
		datePicker.CoerceValue(ValueProperty);
	}

	private static void kMP(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		DatePicker datePicker = (DatePicker)P_0;
		datePicker.CoerceValue(ValueProperty);
	}

	private void HM2(object P_0, EventArgs P_1)
	{
		WMl();
	}

	private static void mMa(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		DatePicker datePicker = (DatePicker)P_0;
		datePicker.KMf();
	}

	private void KMf()
	{
		TMg?.Invoke(this, EventArgs.Empty);
	}

	private void WMl()
	{
		zMo?.Invoke(this, EventArgs.Empty);
	}

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		DMx(GetTemplateChild(QdM.AR8(18732)) as MonthCalendar);
	}

	static DatePicker()
	{
		awj.QuEwGz();
		CanRetainTimeProperty = DependencyProperty.Register(QdM.AR8(18702), typeof(bool), typeof(DatePicker), new PropertyMetadata(false));
		IsNullAllowedProperty = DependencyProperty.Register(QdM.AR8(1632), typeof(bool), typeof(DatePicker), new PropertyMetadata(false));
		MaximumProperty = DependencyProperty.Register(QdM.AR8(1974), typeof(DateTime), typeof(DatePicker), new PropertyMetadata(ldZ.YD2, hMj));
		MinimumProperty = DependencyProperty.Register(QdM.AR8(1992), typeof(DateTime), typeof(DatePicker), new PropertyMetadata(ldZ.ADa, kMP));
		ValueProperty = DependencyProperty.Register(QdM.AR8(1828), typeof(DateTime?), typeof(DatePicker), new PropertyMetadata(DateTime.Today, mMa, AMs));
	}

	internal static bool VBQ()
	{
		return SB1 == null;
	}

	internal static DatePicker eBZ()
	{
		return SB1;
	}
}
