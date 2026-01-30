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

public class DoublePicker : RadialSliderPickerBase
{
	private bool RMU;

	public static readonly DependencyProperty MaximumProperty;

	public static readonly DependencyProperty MinimumProperty;

	public static readonly DependencyProperty RoundingDecimalPlaceProperty;

	public static readonly DependencyProperty SmallChangeProperty;

	public static readonly DependencyProperty ValueProperty;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private EventHandler wMz;

	internal static DoublePicker FBv;

	public double Maximum
	{
		get
		{
			return (double)GetValue(MaximumProperty);
		}
		set
		{
			SetValue(MaximumProperty, value);
		}
	}

	public double Minimum
	{
		get
		{
			return (double)GetValue(MinimumProperty);
		}
		set
		{
			SetValue(MinimumProperty, value);
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

	public double SmallChange
	{
		get
		{
			return (double)GetValue(SmallChangeProperty);
		}
		set
		{
			SetValue(SmallChangeProperty, value);
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1721:PropertyNamesShouldNotMatchGetMethods")]
	public double Value
	{
		get
		{
			return (double)GetValue(ValueProperty);
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
			EventHandler eventHandler = wMz;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref wMz, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = wMz;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref wMz, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public DoublePicker()
	{
		awj.QuEwGz();
		base._002Ector();
		base.DefaultStyleKey = typeof(DoublePicker);
	}

	private void fMk()
	{
		if (base.SetValueAndClosePopupCommand == null)
		{
			base.SetValueAndClosePopupCommand = new DelegateCommand<object>(delegate(object P_0)
			{
				double result = 0.0;
				if (P_0 is double)
				{
					result = (double)P_0;
				}
				else if (P_0 != null && !double.TryParse(P_0.ToString(), out result))
				{
					result = 0.0;
				}
				Value = qdP.jDO(result, Minimum, Maximum, RoundingDecimalPlace);
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
		}
		if (base.SmallIncrementValueCommand != null)
		{
			return;
		}
		int num = 0;
		if (!cBp())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		base.SmallIncrementValueCommand = new DelegateCommand<object>(delegate
		{
			Value = Math.Min(Maximum, Value + SmallChange);
		});
	}

	private static void XME(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		DoublePicker doublePicker = (DoublePicker)P_0;
		if (doublePicker.RMU)
		{
			doublePicker.OMB();
		}
	}

	private static void LM7(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		DoublePicker doublePicker = (DoublePicker)P_0;
		doublePicker.dM4();
	}

	private void dM4()
	{
		wMz?.Invoke(this, EventArgs.Empty);
	}

	private void OMB()
	{
		bool flag = Minimum <= 0.0 && Maximum >= 0.0;
		double num = Math.Max(Math.Abs(Minimum), Math.Abs(Maximum));
		double num2 = 1000.0;
		double num3 = 0.0;
		bool flag2 = false;
		double num4 = 5.0;
		double num5 = 360.0 / num2;
		if (flag && Math.Abs(num) >= 1.0 && num <= num2)
		{
			num5 = 360.0 / num;
			flag2 = Minimum == 0.0;
		}
		else
		{
			double num6 = Math.Abs(Maximum - Minimum);
			if (!double.IsInfinity(num6) && num6 >= 0.01 && num6 <= num2)
			{
				num3 = 0.0 - Minimum;
				num5 = 360.0 / num6;
				flag2 = true;
				if (num6 <= 0.01)
				{
					num4 = 0.01;
				}
				else if (num6 < 0.2)
				{
					num4 = 0.02;
				}
				else if (num6 < 2.0)
				{
					num4 = 0.2;
				}
				else if (num6 < 10.0)
				{
					num4 = 2.0;
				}
				else if (num6 < 15.0)
				{
					num4 = 3.0;
				}
			}
		}
		SetBinding(RadialSliderPickerBase.DegreeMinimumProperty, Ldu.EIz(this, QdM.AR8(1992), BindingMode.OneWay, new mdS(num5, num3, _0020: false)));
		SetBinding(RadialSliderPickerBase.DegreeMaximumProperty, Ldu.EIz(this, QdM.AR8(1974), BindingMode.OneWay, new mdS(num5, num3, flag2)));
		SetBinding(RadialSliderPickerBase.DegreeValueProperty, Ldu.EIz(this, QdM.AR8(1828), BindingMode.TwoWay, new mdS(num5, num3, _0020: false)));
		base.DegreeSmallChange = SmallChange * num5;
		base.DegreeLargeChange = SmallChange * num5 * num4;
	}

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		fMk();
		if (!RMU)
		{
			RMU = true;
			OMB();
		}
	}

	static DoublePicker()
	{
		awj.QuEwGz();
		MaximumProperty = DependencyProperty.Register(QdM.AR8(1974), typeof(double), typeof(DoublePicker), new PropertyMetadata(double.MaxValue, XME));
		MinimumProperty = DependencyProperty.Register(QdM.AR8(1992), typeof(double), typeof(DoublePicker), new PropertyMetadata(double.MinValue, XME));
		RoundingDecimalPlaceProperty = DependencyProperty.Register(QdM.AR8(3396), typeof(int?), typeof(DoublePicker), new PropertyMetadata(8, XME));
		SmallChangeProperty = DependencyProperty.Register(QdM.AR8(2066), typeof(double), typeof(DoublePicker), new PropertyMetadata(1.0, XME));
		ValueProperty = DependencyProperty.Register(QdM.AR8(1828), typeof(double), typeof(DoublePicker), new PropertyMetadata(0.0, LM7));
	}

	[CompilerGenerated]
	private void iMh(object P_0)
	{
		double result = 0.0;
		if (P_0 is double)
		{
			result = (double)P_0;
		}
		else if (P_0 != null && !double.TryParse(P_0.ToString(), out result))
		{
			result = 0.0;
		}
		Value = qdP.jDO(result, Minimum, Maximum, RoundingDecimalPlace);
		Popup ancestorPopup = VisualTreeHelperExtended.GetAncestorPopup(this);
		if (ancestorPopup != null)
		{
			ancestorPopup.IsOpen = false;
		}
	}

	[CompilerGenerated]
	private void PMw(object P_0)
	{
		Value = Math.Max(Minimum, Value - SmallChange);
	}

	[CompilerGenerated]
	private void QMN(object P_0)
	{
		Value = Math.Min(Maximum, Value + SmallChange);
	}

	internal static bool cBp()
	{
		return FBv == null;
	}

	internal static DoublePicker qB4()
	{
		return FBv;
	}
}
