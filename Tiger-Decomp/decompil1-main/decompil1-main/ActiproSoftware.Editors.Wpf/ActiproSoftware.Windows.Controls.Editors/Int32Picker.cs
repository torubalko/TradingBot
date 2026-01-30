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

public class Int32Picker : RadialSliderPickerBase
{
	private bool XPT;

	public static readonly DependencyProperty MaximumProperty;

	public static readonly DependencyProperty MinimumProperty;

	public static readonly DependencyProperty SmallChangeProperty;

	public static readonly DependencyProperty ValueProperty;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private EventHandler HPI;

	private static Int32Picker bWe;

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

	[SuppressMessage("Microsoft.Naming", "CA1721:PropertyNamesShouldNotMatchGetMethods")]
	public int Value
	{
		get
		{
			return (int)GetValue(ValueProperty);
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
			EventHandler eventHandler = HPI;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref HPI, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = HPI;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref HPI, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public Int32Picker()
	{
		awj.QuEwGz();
		base._002Ector();
		base.DefaultStyleKey = typeof(Int32Picker);
	}

	private void hPl()
	{
		if (base.SetValueAndClosePopupCommand == null)
		{
			base.SetValueAndClosePopupCommand = new DelegateCommand<object>(delegate(object P_0)
			{
				int result = 0;
				if (P_0 is int)
				{
					result = (int)P_0;
				}
				else if (P_0 != null && !int.TryParse(P_0.ToString(), out result))
				{
					result = 0;
				}
				Value = cdY.vDh(result, Minimum, Maximum);
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
				Value = Math.Max(Minimum, Value - SmallChange);
			});
			int num = 0;
			if (kWm() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
		if (base.SmallIncrementValueCommand == null)
		{
			base.SmallIncrementValueCommand = new DelegateCommand<object>(delegate
			{
				Value = Math.Min(Maximum, Value + SmallChange);
			});
		}
	}

	private static void xPX(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		Int32Picker int32Picker = (Int32Picker)P_0;
		if (int32Picker.XPT)
		{
			int32Picker.mPY();
		}
	}

	private static void BPx(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		Int32Picker int32Picker = (Int32Picker)P_0;
		int32Picker.VP0();
	}

	private void VP0()
	{
		HPI?.Invoke(this, EventArgs.Empty);
	}

	private void mPY()
	{
		bool flag = (double)Minimum <= 0.0 && (double)Maximum >= 0.0;
		int num = Math.Max(Math.Abs((Minimum == int.MinValue) ? (-2147483647) : Minimum), Math.Abs(Maximum));
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
		hPl();
		if (!XPT)
		{
			XPT = true;
			mPY();
		}
	}

	static Int32Picker()
	{
		awj.QuEwGz();
		MaximumProperty = DependencyProperty.Register(QdM.AR8(1974), typeof(int), typeof(Int32Picker), new PropertyMetadata(int.MaxValue, xPX));
		MinimumProperty = DependencyProperty.Register(QdM.AR8(1992), typeof(int), typeof(Int32Picker), new PropertyMetadata(int.MinValue, xPX));
		SmallChangeProperty = DependencyProperty.Register(QdM.AR8(2066), typeof(int), typeof(Int32Picker), new PropertyMetadata(1, xPX));
		ValueProperty = DependencyProperty.Register(QdM.AR8(1828), typeof(int), typeof(Int32Picker), new PropertyMetadata(0, BPx));
	}

	[CompilerGenerated]
	private void DPg(object P_0)
	{
		int result = 0;
		if (P_0 is int)
		{
			result = (int)P_0;
		}
		else if (P_0 != null && !int.TryParse(P_0.ToString(), out result))
		{
			result = 0;
		}
		Value = cdY.vDh(result, Minimum, Maximum);
		Popup ancestorPopup = VisualTreeHelperExtended.GetAncestorPopup(this);
		if (ancestorPopup != null)
		{
			ancestorPopup.IsOpen = false;
		}
	}

	[CompilerGenerated]
	private void KPo(object P_0)
	{
		Value = Math.Max(Minimum, Value - SmallChange);
	}

	[CompilerGenerated]
	private void dPO(object P_0)
	{
		Value = Math.Min(Maximum, Value + SmallChange);
	}

	internal static bool eWO()
	{
		return bWe == null;
	}

	internal static Int32Picker kWm()
	{
		return bWe;
	}
}
