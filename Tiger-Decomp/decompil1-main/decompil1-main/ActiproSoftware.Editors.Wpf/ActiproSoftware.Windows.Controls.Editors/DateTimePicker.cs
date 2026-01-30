using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.Editors.Primitives;

namespace ActiproSoftware.Windows.Controls.Editors;

[TemplateVisualState(Name = "TimeVisible", GroupName = "ComponentVisibilityStates")]
[TemplateVisualState(Name = "DateVisible", GroupName = "ComponentVisibilityStates")]
public class DateTimePicker : PickerBase
{
	private DatePicker rMp;

	private Selector HMW;

	private TimePicker mMi;

	public static readonly DependencyProperty IsNullAllowedProperty;

	public static readonly DependencyProperty MaximumProperty;

	public static readonly DependencyProperty MinimumProperty;

	public static readonly DependencyProperty ValueProperty;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private EventHandler mMZ;

	internal static DateTimePicker TBI;

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
			EventHandler eventHandler = mMZ;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref mMZ, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = mMZ;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref mMZ, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public DateTimePicker()
	{
		awj.QuEwGz();
		base._002Ector();
		base.DefaultStyleKey = typeof(DateTimePicker);
	}

	private static object qMd(DependencyObject P_0, object P_1)
	{
		DateTimePicker dateTimePicker = (DateTimePicker)P_0;
		if (P_1 == null)
		{
			return P_1;
		}
		return ldZ.BDP((DateTime)P_1, dateTimePicker.Minimum, dateTimePicker.Maximum);
	}

	[SpecialName]
	private DatePicker pMA()
	{
		return rMp;
	}

	[SpecialName]
	private void cM3(DatePicker value)
	{
		rMp = value;
	}

	private static void cM9(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		DateTimePicker dateTimePicker = (DateTimePicker)P_0;
		dateTimePicker.CoerceValue(ValueProperty);
	}

	private static void KM5(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		DateTimePicker dateTimePicker = (DateTimePicker)P_0;
		dateTimePicker.CoerceValue(ValueProperty);
	}

	private static void MMc(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		DateTimePicker dateTimePicker = (DateTimePicker)P_0;
		dateTimePicker.TML();
	}

	private void EMH(object P_0, SelectionChangedEventArgs P_1)
	{
		CMF(_0020: true);
	}

	[SpecialName]
	private Selector DMm()
	{
		return HMW;
	}

	[SpecialName]
	private void QMS(Selector value)
	{
		if (HMW == value)
		{
			return;
		}
		if (HMW != null)
		{
			HMW.SelectionChanged -= EMH;
		}
		HMW = value;
		if (HMW != null)
		{
			if (HMW.SelectedIndex == -1 && HMW.Items.Count > 0)
			{
				HMW.SelectedIndex = 0;
			}
			HMW.SelectionChanged += EMH;
		}
	}

	private void TML()
	{
		mMZ?.Invoke(this, EventArgs.Empty);
	}

	[SpecialName]
	private TimePicker JM8()
	{
		return mMi;
	}

	[SpecialName]
	private void fMr(TimePicker value)
	{
		mMi = value;
	}

	private void CMF(bool P_0)
	{
		if (DMm() == null || DMm().SelectedIndex != 1)
		{
			VisualStateManager.GoToState(this, QdM.AR8(19112), P_0);
		}
		else
		{
			VisualStateManager.GoToState(this, QdM.AR8(19086), P_0);
		}
	}

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		cM3(GetTemplateChild(QdM.AR8(19138)) as DatePicker);
		QMS(GetTemplateChild(QdM.AR8(3528)) as Selector);
		fMr(GetTemplateChild(QdM.AR8(19182)) as TimePicker);
		CMF(_0020: false);
	}

	static DateTimePicker()
	{
		awj.QuEwGz();
		IsNullAllowedProperty = DependencyProperty.Register(QdM.AR8(1632), typeof(bool), typeof(DateTimePicker), new PropertyMetadata(false));
		MaximumProperty = DependencyProperty.Register(QdM.AR8(1974), typeof(DateTime), typeof(DateTimePicker), new PropertyMetadata(ldZ.YD2, cM9));
		MinimumProperty = DependencyProperty.Register(QdM.AR8(1992), typeof(DateTime), typeof(DateTimePicker), new PropertyMetadata(ldZ.ADa, KM5));
		ValueProperty = DependencyProperty.Register(QdM.AR8(1828), typeof(DateTime?), typeof(DateTimePicker), new PropertyMetadata(DateTime.Today, MMc, qMd));
	}

	internal static bool WB6()
	{
		return TBI == null;
	}

	internal static DateTimePicker XBc()
	{
		return TBI;
	}
}
