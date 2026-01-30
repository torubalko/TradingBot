using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.Editors.Primitives;
using ActiproSoftware.Windows.Input;
using ActiproSoftware.Windows.Media;

namespace ActiproSoftware.Windows.Controls.Editors;

public class Int16Picker : RadialSliderPickerBase
{
	private bool IPM;

	public static readonly DependencyProperty MaximumProperty;

	public static readonly DependencyProperty MinimumProperty;

	public static readonly DependencyProperty SmallChangeProperty;

	public static readonly DependencyProperty ValueProperty;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private EventHandler PPs;

	internal static Int16Picker tWr;

	public short Maximum
	{
		get
		{
			return (short)GetValue(MaximumProperty);
		}
		set
		{
			SetValue(MaximumProperty, value);
		}
	}

	public short Minimum
	{
		get
		{
			return (short)GetValue(MinimumProperty);
		}
		set
		{
			SetValue(MinimumProperty, value);
		}
	}

	public short SmallChange
	{
		get
		{
			return (short)GetValue(SmallChangeProperty);
		}
		set
		{
			SetValue(SmallChangeProperty, value);
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1721:PropertyNamesShouldNotMatchGetMethods")]
	public short Value
	{
		get
		{
			return (short)GetValue(ValueProperty);
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
			EventHandler eventHandler = PPs;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref PPs, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = PPs;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref PPs, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public Int16Picker()
	{
		awj.QuEwGz();
		base._002Ector();
		base.DefaultStyleKey = typeof(Int16Picker);
	}

	private void Vjw()
	{
		if (base.SetValueAndClosePopupCommand == null)
		{
			base.SetValueAndClosePopupCommand = new DelegateCommand<object>(delegate(object P_0)
			{
				short result = 0;
				if (P_0 is short)
				{
					result = (short)P_0;
					int num3 = 0;
					if (!hWa())
					{
						int num4 = default(int);
						num3 = num4;
					}
					switch (num3)
					{
					}
				}
				else if (P_0 != null && !short.TryParse(P_0.ToString(), out result))
				{
					result = 0;
				}
				Value = YdV.zDZ(result, Minimum, Maximum);
				Popup ancestorPopup = VisualTreeHelperExtended.GetAncestorPopup(this);
				if (ancestorPopup != null)
				{
					ancestorPopup.IsOpen = false;
				}
			});
		}
		if (base.SmallDecrementValueCommand == null)
		{
			base.SmallDecrementValueCommand = new DelegateCommand<object>(delegate
			{
				Value = (short)Math.Max(Minimum, Value - SmallChange);
			});
		}
		bool flag = base.SmallIncrementValueCommand == null;
		int num = 0;
		if (!hWa())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (flag)
		{
			base.SmallIncrementValueCommand = new DelegateCommand<object>(delegate
			{
				Value = (short)Math.Min(Maximum, Value + SmallChange);
			});
		}
	}

	private static void ljN(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		Int16Picker int16Picker = (Int16Picker)P_0;
		if (int16Picker.IPM)
		{
			int16Picker.jPQ();
		}
	}

	private static void zjU(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		Int16Picker int16Picker = (Int16Picker)P_0;
		int16Picker.hjz();
	}

	private void hjz()
	{
		PPs?.Invoke(this, EventArgs.Empty);
	}

	private void jPQ()
	{
		bool flag = (double)Minimum <= 0.0 && (double)Maximum >= 0.0;
		int num = Math.Max(Math.Abs((Minimum == short.MinValue) ? (-32767) : Minimum), Math.Abs(Maximum));
		double num2 = 1000.0;
		double num3 = 0.0;
		bool flag2 = false;
		double num4 = 5.0;
		double num5 = 360.0 / num2;
		if (flag && (double)Math.Abs(num) >= 1.0 && (double)num <= num2)
		{
			num5 = 360.0 / (double)num;
			flag2 = (double)Minimum == 0.0;
		}
		else
		{
			long num6 = Math.Abs((long)Maximum - (long)Minimum);
			if ((double)num6 >= 1.0 && (double)num6 <= num2)
			{
				num3 = -Minimum;
				num5 = 360.0 / (double)num6;
				flag2 = true;
				if ((double)num6 < 10.0)
				{
					num4 = 2.0;
				}
				else if ((double)num6 < 15.0)
				{
					num4 = 3.0;
				}
			}
		}
		SetBinding(RadialSliderPickerBase.DegreeMinimumProperty, Ldu.EIz(this, QdM.AR8(1992), BindingMode.OneWay, new mdS(num5, num3, _0020: false)));
		SetBinding(RadialSliderPickerBase.DegreeMaximumProperty, Ldu.EIz(this, QdM.AR8(1974), BindingMode.OneWay, new mdS(num5, num3, flag2)));
		SetBinding(RadialSliderPickerBase.DegreeValueProperty, Ldu.EIz(this, QdM.AR8(1828), BindingMode.TwoWay, new mdS(num5, num3, _0020: false)));
		base.DegreeSmallChange = (double)SmallChange * num5;
		base.DegreeLargeChange = (double)SmallChange * num5 * num4;
	}

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		Vjw();
		if (!IPM)
		{
			IPM = true;
			jPQ();
		}
	}

	static Int16Picker()
	{
		awj.QuEwGz();
		MaximumProperty = DependencyProperty.Register(QdM.AR8(1974), typeof(short), typeof(Int16Picker), new PropertyMetadata(short.MaxValue, ljN));
		MinimumProperty = DependencyProperty.Register(QdM.AR8(1992), typeof(short), typeof(Int16Picker), new PropertyMetadata(short.MinValue, ljN));
		SmallChangeProperty = DependencyProperty.Register(QdM.AR8(2066), typeof(short), typeof(Int16Picker), new PropertyMetadata((short)1, ljN));
		ValueProperty = DependencyProperty.Register(QdM.AR8(1828), typeof(short), typeof(Int16Picker), new PropertyMetadata((short)0, zjU));
	}

	[CompilerGenerated]
	private void NPV(object P_0)
	{
		short result = 0;
		if (P_0 is short)
		{
			result = (short)P_0;
			int num = 0;
			if (!hWa())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
		else if (P_0 != null && !short.TryParse(P_0.ToString(), out result))
		{
			result = 0;
		}
		Value = YdV.zDZ(result, Minimum, Maximum);
		Popup ancestorPopup = VisualTreeHelperExtended.GetAncestorPopup(this);
		if (ancestorPopup != null)
		{
			ancestorPopup.IsOpen = false;
		}
	}

	[CompilerGenerated]
	private void YPC(object P_0)
	{
		Value = (short)Math.Max(Minimum, Value - SmallChange);
	}

	[CompilerGenerated]
	private void yP6(object P_0)
	{
		Value = (short)Math.Min(Maximum, Value + SmallChange);
	}

	internal static bool hWa()
	{
		return tWr == null;
	}

	internal static Int16Picker yWj()
	{
		return tWr;
	}
}
