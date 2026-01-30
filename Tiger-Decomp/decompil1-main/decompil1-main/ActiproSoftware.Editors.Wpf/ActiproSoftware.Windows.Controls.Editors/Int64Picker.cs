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

public class Int64Picker : RadialSliderPickerBase
{
	private bool APN;

	public static readonly DependencyProperty MaximumProperty;

	public static readonly DependencyProperty MinimumProperty;

	public static readonly DependencyProperty SmallChangeProperty;

	public static readonly DependencyProperty ValueProperty;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private EventHandler rPU;

	internal static Int64Picker BWy;

	public long Maximum
	{
		get
		{
			return (long)GetValue(MaximumProperty);
		}
		set
		{
			SetValue(MaximumProperty, value);
		}
	}

	public long Minimum
	{
		get
		{
			return (long)GetValue(MinimumProperty);
		}
		set
		{
			SetValue(MinimumProperty, value);
		}
	}

	public long SmallChange
	{
		get
		{
			return (long)GetValue(SmallChangeProperty);
		}
		set
		{
			SetValue(SmallChangeProperty, value);
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1721:PropertyNamesShouldNotMatchGetMethods")]
	public long Value
	{
		get
		{
			return (long)GetValue(ValueProperty);
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
			EventHandler eventHandler = rPU;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref rPU, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = rPU;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref rPU, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public Int64Picker()
	{
		awj.QuEwGz();
		base._002Ector();
		base.DefaultStyleKey = typeof(Int64Picker);
	}

	private void NPe()
	{
		if (base.SetValueAndClosePopupCommand == null)
		{
			base.SetValueAndClosePopupCommand = new DelegateCommand<object>(delegate(object P_0)
			{
				long result = 0L;
				if (P_0 is long)
				{
					result = (long)P_0;
				}
				else if (P_0 != null && !long.TryParse(P_0.ToString(), out result))
				{
					result = 0L;
				}
				Value = sdh.hGO(result, Minimum, Maximum);
				int num = 0;
				if (!wWX())
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				default:
				{
					Popup ancestorPopup = VisualTreeHelperExtended.GetAncestorPopup(this);
					if (ancestorPopup != null)
					{
						ancestorPopup.IsOpen = false;
					}
					break;
				}
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
		if (base.SmallIncrementValueCommand == null)
		{
			base.SmallIncrementValueCommand = new DelegateCommand<object>(delegate
			{
				Value = Math.Min(Maximum, Value + SmallChange);
			});
		}
	}

	private static void sPk(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		Int64Picker int64Picker = (Int64Picker)P_0;
		if (int64Picker.APN)
		{
			int64Picker.sP4();
		}
	}

	private static void ePE(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		Int64Picker int64Picker = (Int64Picker)P_0;
		int64Picker.cP7();
	}

	private void cP7()
	{
		rPU?.Invoke(this, EventArgs.Empty);
	}

	private void sP4()
	{
		bool flag = (double)Minimum <= 0.0 && (double)Maximum >= 0.0;
		long num = Math.Max(Math.Abs((Minimum == long.MinValue) ? (-9223372036854775807L) : Minimum), Math.Abs(Maximum));
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
			long num6 = long.MaxValue;
			double num7 = Math.Abs((double)Maximum - (double)Minimum);
			if (num7 < 9.223372036854776E+18)
			{
				num6 = (long)num7;
			}
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
		NPe();
		if (!APN)
		{
			APN = true;
			sP4();
		}
	}

	static Int64Picker()
	{
		awj.QuEwGz();
		MaximumProperty = DependencyProperty.Register(QdM.AR8(1974), typeof(long), typeof(Int64Picker), new PropertyMetadata(long.MaxValue, sPk));
		MinimumProperty = DependencyProperty.Register(QdM.AR8(1992), typeof(long), typeof(Int64Picker), new PropertyMetadata(long.MinValue, sPk));
		SmallChangeProperty = DependencyProperty.Register(QdM.AR8(2066), typeof(long), typeof(Int64Picker), new PropertyMetadata(1L, sPk));
		ValueProperty = DependencyProperty.Register(QdM.AR8(1828), typeof(long), typeof(Int64Picker), new PropertyMetadata(0L, ePE));
	}

	[CompilerGenerated]
	private void nPB(object P_0)
	{
		long result = 0L;
		if (P_0 is long)
		{
			result = (long)P_0;
		}
		else if (P_0 != null && !long.TryParse(P_0.ToString(), out result))
		{
			result = 0L;
		}
		Value = sdh.hGO(result, Minimum, Maximum);
		int num = 0;
		if (!wWX())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		Popup ancestorPopup = VisualTreeHelperExtended.GetAncestorPopup(this);
		if (ancestorPopup != null)
		{
			ancestorPopup.IsOpen = false;
		}
	}

	[CompilerGenerated]
	private void QPh(object P_0)
	{
		Value = Math.Max(Minimum, Value - SmallChange);
	}

	[CompilerGenerated]
	private void APw(object P_0)
	{
		Value = Math.Min(Maximum, Value + SmallChange);
	}

	internal static bool wWX()
	{
		return BWy == null;
	}

	internal static Int64Picker qWK()
	{
		return BWy;
	}
}
