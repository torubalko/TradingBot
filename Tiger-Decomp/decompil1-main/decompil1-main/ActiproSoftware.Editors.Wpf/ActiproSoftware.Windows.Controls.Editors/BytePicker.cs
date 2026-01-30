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

public class BytePicker : RadialSliderPickerBase
{
	private bool tVN;

	public static readonly DependencyProperty MaximumProperty;

	public static readonly DependencyProperty MinimumProperty;

	public static readonly DependencyProperty SmallChangeProperty;

	public static readonly DependencyProperty ValueProperty;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private EventHandler IVU;

	private static BytePicker B4;

	public byte Maximum
	{
		get
		{
			return (byte)GetValue(MaximumProperty);
		}
		set
		{
			SetValue(MaximumProperty, value);
		}
	}

	public byte Minimum
	{
		get
		{
			return (byte)GetValue(MinimumProperty);
		}
		set
		{
			SetValue(MinimumProperty, value);
		}
	}

	public byte SmallChange
	{
		get
		{
			return (byte)GetValue(SmallChangeProperty);
		}
		set
		{
			SetValue(SmallChangeProperty, value);
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1721:PropertyNamesShouldNotMatchGetMethods")]
	public byte Value
	{
		get
		{
			return (byte)GetValue(ValueProperty);
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
			EventHandler eventHandler = IVU;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref IVU, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = IVU;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref IVU, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public BytePicker()
	{
		awj.QuEwGz();
		base._002Ector();
		base.DefaultStyleKey = typeof(BytePicker);
	}

	private void VVe()
	{
		if (base.SetValueAndClosePopupCommand == null)
		{
			int num = 0;
			if (X7() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			base.SetValueAndClosePopupCommand = new DelegateCommand<object>(delegate(object P_0)
			{
				byte result = 0;
				if (P_0 is byte)
				{
					result = (byte)P_0;
				}
				else if (P_0 != null && !byte.TryParse(P_0.ToString(), out result))
				{
					result = 0;
				}
				Value = cda.zbf(result, Minimum, Maximum);
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
				Value = (byte)Math.Max(Minimum, Value - SmallChange);
			});
		}
		if (base.SmallIncrementValueCommand == null)
		{
			base.SmallIncrementValueCommand = new DelegateCommand<object>(delegate
			{
				Value = (byte)Math.Min(Maximum, Value + SmallChange);
			});
		}
	}

	private static void UVk(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		BytePicker bytePicker = (BytePicker)P_0;
		if (bytePicker.tVN)
		{
			bytePicker.mV4();
		}
	}

	private static void EVE(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		BytePicker bytePicker = (BytePicker)P_0;
		bytePicker.TV7();
	}

	private void TV7()
	{
		IVU?.Invoke(this, EventArgs.Empty);
	}

	private void mV4()
	{
		bool flag = (double)(int)Minimum <= 0.0 && (double)(int)Maximum >= 0.0;
		int num = Math.Max(Math.Abs((Minimum == 0) ? 1 : Minimum), Math.Abs(Maximum));
		double num2 = 1000.0;
		double num3 = 0.0;
		bool flag2 = false;
		double num4 = 5.0;
		double num5 = 360.0 / num2;
		if (flag && (double)Math.Abs(num) >= 1.0 && (double)num <= num2)
		{
			num5 = 360.0 / (double)num;
			flag2 = (double)(int)Minimum == 0.0;
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
		base.DegreeSmallChange = (double)(int)SmallChange * num5;
		base.DegreeLargeChange = (double)(int)SmallChange * num5 * num4;
	}

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		VVe();
		if (!tVN)
		{
			tVN = true;
			mV4();
		}
	}

	static BytePicker()
	{
		awj.QuEwGz();
		MaximumProperty = DependencyProperty.Register(QdM.AR8(1974), typeof(byte), typeof(BytePicker), new PropertyMetadata(byte.MaxValue, UVk));
		MinimumProperty = DependencyProperty.Register(QdM.AR8(1992), typeof(byte), typeof(BytePicker), new PropertyMetadata((byte)0, UVk));
		SmallChangeProperty = DependencyProperty.Register(QdM.AR8(2066), typeof(byte), typeof(BytePicker), new PropertyMetadata((byte)1, UVk));
		ValueProperty = DependencyProperty.Register(QdM.AR8(1828), typeof(byte), typeof(BytePicker), new PropertyMetadata((byte)0, EVE));
	}

	[CompilerGenerated]
	private void gVB(object P_0)
	{
		byte result = 0;
		if (P_0 is byte)
		{
			result = (byte)P_0;
		}
		else if (P_0 != null && !byte.TryParse(P_0.ToString(), out result))
		{
			result = 0;
		}
		Value = cda.zbf(result, Minimum, Maximum);
		Popup ancestorPopup = VisualTreeHelperExtended.GetAncestorPopup(this);
		if (ancestorPopup != null)
		{
			ancestorPopup.IsOpen = false;
		}
	}

	[CompilerGenerated]
	private void AVh(object P_0)
	{
		Value = (byte)Math.Max(Minimum, Value - SmallChange);
	}

	[CompilerGenerated]
	private void tVw(object P_0)
	{
		Value = (byte)Math.Min(Maximum, Value + SmallChange);
	}

	internal static bool T0()
	{
		return B4 == null;
	}

	internal static BytePicker X7()
	{
		return B4;
	}
}
