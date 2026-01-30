using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Data;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.Editors.Primitives;

namespace ActiproSoftware.Windows.Controls.Editors;

public class TimePicker : PickerBase
{
	private bool Vx5;

	private bool Rxc;

	public static readonly DependencyProperty HourProperty;

	public static readonly DependencyProperty HourDegreeMaximumProperty;

	public static readonly DependencyProperty HourDegreeMinimumProperty;

	public static readonly DependencyProperty HourDegreeValueProperty;

	public static readonly DependencyProperty IsNullAllowedProperty;

	public static readonly DependencyProperty IsPMProperty;

	public static readonly DependencyProperty MaximumProperty;

	public static readonly DependencyProperty MinimumProperty;

	public static readonly DependencyProperty MinuteProperty;

	public static readonly DependencyProperty MinuteDegreeMaximumProperty;

	public static readonly DependencyProperty MinuteDegreeMinimumProperty;

	public static readonly DependencyProperty MinuteDegreeValueProperty;

	public static readonly DependencyProperty ValueProperty;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private EventHandler DxH;

	private static TimePicker trs;

	public int Hour
	{
		get
		{
			return (int)GetValue(HourProperty);
		}
		set
		{
			SetValue(HourProperty, value);
		}
	}

	public double HourDegreeMaximum
	{
		get
		{
			return (double)GetValue(HourDegreeMaximumProperty);
		}
		private set
		{
			SetValue(HourDegreeMaximumProperty, value);
		}
	}

	public double HourDegreeMinimum
	{
		get
		{
			return (double)GetValue(HourDegreeMinimumProperty);
		}
		private set
		{
			SetValue(HourDegreeMinimumProperty, value);
		}
	}

	public int HourDegreeValue
	{
		get
		{
			return (int)GetValue(HourDegreeValueProperty);
		}
		set
		{
			SetValue(HourDegreeValueProperty, value);
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

	public bool IsPM
	{
		get
		{
			return (bool)GetValue(IsPMProperty);
		}
		private set
		{
			SetValue(IsPMProperty, value);
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

	public int Minute
	{
		get
		{
			return (int)GetValue(MinuteProperty);
		}
		set
		{
			SetValue(MinuteProperty, value);
		}
	}

	public double MinuteDegreeMaximum
	{
		get
		{
			return (double)GetValue(MinuteDegreeMaximumProperty);
		}
		private set
		{
			SetValue(MinuteDegreeMaximumProperty, value);
		}
	}

	public double MinuteDegreeMinimum
	{
		get
		{
			return (double)GetValue(MinuteDegreeMinimumProperty);
		}
		private set
		{
			SetValue(MinuteDegreeMinimumProperty, value);
		}
	}

	public int MinuteDegreeValue
	{
		get
		{
			return (int)GetValue(MinuteDegreeValueProperty);
		}
		set
		{
			SetValue(MinuteDegreeValueProperty, value);
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
			EventHandler eventHandler = DxH;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref DxH, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = DxH;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref DxH, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public TimePicker()
	{
		awj.QuEwGz();
		base._002Ector();
		base.DefaultStyleKey = typeof(TimePicker);
	}

	private static object Rxg(DependencyObject P_0, object P_1)
	{
		TimePicker timePicker = (TimePicker)P_0;
		if (P_1 == null)
		{
			return P_1;
		}
		return ldZ.BDP((DateTime)P_1, timePicker.Minimum, timePicker.Maximum);
	}

	private static void Yxo(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		TimePicker timePicker = (TimePicker)P_0;
		DateTime dateTime = timePicker.Value ?? DateTime.Today;
		int hour = Math.Max(0, Math.Min(23, (int)P_1.NewValue));
		dateTime = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, hour, dateTime.Minute, dateTime.Second, dateTime.Kind);
		dateTime = ldZ.BDP(dateTime, timePicker.Minimum, timePicker.Maximum);
		if (timePicker.Value != dateTime)
		{
			timePicker.Jxq(dateTime);
		}
	}

	private static void pxO(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		TimePicker timePicker = (TimePicker)P_0;
		DateTime dateTime = timePicker.Value ?? DateTime.Today;
		int minute = Math.Max(0, Math.Min(59, (int)P_1.NewValue));
		dateTime = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, minute, dateTime.Second, dateTime.Kind);
		dateTime = ldZ.BDP(dateTime, timePicker.Minimum, timePicker.Maximum);
		if (timePicker.Value != dateTime)
		{
			timePicker.Jxq(dateTime);
		}
	}

	private static void DxT(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		TimePicker timePicker = (TimePicker)P_0;
		timePicker.CoerceValue(ValueProperty);
		if (timePicker.Vx5)
		{
			timePicker.XxG();
		}
	}

	private static void xxI(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		TimePicker timePicker = (TimePicker)P_0;
		timePicker.XxG();
		if (P_1.NewValue != null)
		{
			timePicker.Jxq((DateTime)P_1.NewValue);
		}
		timePicker.lxb();
	}

	private void lxb()
	{
		DxH?.Invoke(this, EventArgs.Empty);
	}

	private void uxD()
	{
		SetBinding(HourDegreeValueProperty, Ldu.EIz(this, QdM.AR8(22822), BindingMode.TwoWay, new mdF(30.0)));
		SetBinding(MinuteDegreeValueProperty, Ldu.EIz(this, QdM.AR8(22834), BindingMode.TwoWay, new mdF(6.0)));
	}

	private void XxG()
	{
		double num = 0.0;
		double num2 = 720.0;
		double num3 = 0.0;
		double num4 = 360.0;
		DateTime dateTime = Value ?? DateTime.Today;
		if (Minimum.Date >= dateTime.Date)
		{
			num = (double)Minimum.Hour * 30.0;
			if (Minimum.Hour >= dateTime.Hour)
			{
				num3 = (double)Minimum.Minute * 6.0;
			}
		}
		if (Maximum.Date <= dateTime.Date)
		{
			num2 = (double)Maximum.Hour * 30.0;
			if (Maximum.Hour <= dateTime.Hour)
			{
				num4 = (double)Maximum.Minute * 6.0;
			}
		}
		if (MinuteDegreeMinimum != num3)
		{
			MinuteDegreeMinimum = num3;
		}
		if (MinuteDegreeMaximum != num4)
		{
			MinuteDegreeMaximum = num4;
		}
		if (HourDegreeMinimum != num)
		{
			HourDegreeMinimum = num;
		}
		if (HourDegreeMaximum != num2)
		{
			HourDegreeMaximum = num2;
		}
	}

	private void Jxq(DateTime P_0)
	{
		if (Rxc)
		{
			return;
		}
		Rxc = true;
		try
		{
			if (Value != P_0)
			{
				Value = P_0;
			}
			IsPM = P_0.Hour >= 12;
			Hour = P_0.Hour;
			int num = 0;
			if (Prx() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			Minute = P_0.Minute;
		}
		finally
		{
			Rxc = false;
		}
	}

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		if (!Vx5)
		{
			Vx5 = true;
			uxD();
			XxG();
		}
	}

	static TimePicker()
	{
		awj.QuEwGz();
		HourProperty = DependencyProperty.Register(QdM.AR8(22822), typeof(int), typeof(TimePicker), new PropertyMetadata(0, Yxo));
		HourDegreeMaximumProperty = DependencyProperty.Register(QdM.AR8(22850), typeof(double), typeof(TimePicker), new PropertyMetadata(720.0));
		HourDegreeMinimumProperty = DependencyProperty.Register(QdM.AR8(22888), typeof(double), typeof(TimePicker), new PropertyMetadata(0.0));
		HourDegreeValueProperty = DependencyProperty.Register(QdM.AR8(22926), typeof(double), typeof(TimePicker), new PropertyMetadata(0.0));
		IsNullAllowedProperty = DependencyProperty.Register(QdM.AR8(1632), typeof(bool), typeof(TimePicker), new PropertyMetadata(false));
		IsPMProperty = DependencyProperty.Register(QdM.AR8(22960), typeof(bool), typeof(TimePicker), new PropertyMetadata(false));
		MaximumProperty = DependencyProperty.Register(QdM.AR8(1974), typeof(DateTime), typeof(TimePicker), new PropertyMetadata(ldZ.YD2, DxT));
		MinimumProperty = DependencyProperty.Register(QdM.AR8(1992), typeof(DateTime), typeof(TimePicker), new PropertyMetadata(ldZ.ADa, DxT));
		MinuteProperty = DependencyProperty.Register(QdM.AR8(22834), typeof(int), typeof(TimePicker), new PropertyMetadata(0, pxO));
		MinuteDegreeMaximumProperty = DependencyProperty.Register(QdM.AR8(22972), typeof(double), typeof(TimePicker), new PropertyMetadata(360.0));
		MinuteDegreeMinimumProperty = DependencyProperty.Register(QdM.AR8(23014), typeof(double), typeof(TimePicker), new PropertyMetadata(0.0));
		MinuteDegreeValueProperty = DependencyProperty.Register(QdM.AR8(23056), typeof(double), typeof(TimePicker), new PropertyMetadata(0.0));
		ValueProperty = DependencyProperty.Register(QdM.AR8(1828), typeof(DateTime?), typeof(TimePicker), new PropertyMetadata(DateTime.Today, xxI, Rxg));
	}

	internal static bool prY()
	{
		return trs == null;
	}

	internal static TimePicker Prx()
	{
		return trs;
	}
}
