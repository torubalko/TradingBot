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

public class SinglePicker : RadialSliderPickerBase
{
	private bool HXd;

	public static readonly DependencyProperty MaximumProperty;

	public static readonly DependencyProperty MinimumProperty;

	public static readonly DependencyProperty RoundingDecimalPlaceProperty;

	public static readonly DependencyProperty SmallChangeProperty;

	public static readonly DependencyProperty ValueProperty;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private EventHandler uX9;

	private static SinglePicker frd;

	public float Maximum
	{
		get
		{
			return (float)GetValue(MaximumProperty);
		}
		set
		{
			SetValue(MaximumProperty, value);
		}
	}

	public float Minimum
	{
		get
		{
			return (float)GetValue(MinimumProperty);
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

	public float SmallChange
	{
		get
		{
			return (float)GetValue(SmallChangeProperty);
		}
		set
		{
			SetValue(SmallChangeProperty, value);
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1721:PropertyNamesShouldNotMatchGetMethods")]
	public float Value
	{
		get
		{
			return (float)GetValue(ValueProperty);
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
			EventHandler eventHandler = uX9;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref uX9, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = uX9;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref uX9, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public SinglePicker()
	{
		awj.QuEwGz();
		base._002Ector();
		base.DefaultStyleKey = typeof(SinglePicker);
	}

	private void mXI()
	{
		if (base.SetValueAndClosePopupCommand == null)
		{
			base.SetValueAndClosePopupCommand = new DelegateCommand<object>(delegate(object P_0)
			{
				float result = 0f;
				if (P_0 is float)
				{
					result = (float)P_0;
				}
				else if (P_0 != null)
				{
					int num3 = 0;
					if (Crp() != null)
					{
						int num4 = default(int);
						num3 = num4;
					}
					switch (num3)
					{
					}
					if (!float.TryParse(P_0.ToString(), out result))
					{
						result = 0f;
					}
				}
				Value = ldK.vq0(result, Minimum, Maximum, RoundingDecimalPlace);
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
		bool flag = base.SmallIncrementValueCommand == null;
		int num = 0;
		if (Crp() != null)
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
				Value = Math.Min(Maximum, Value + SmallChange);
			});
		}
	}

	private static void tXb(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		SinglePicker singlePicker = (SinglePicker)P_0;
		if (singlePicker.HXd)
		{
			singlePicker.gXq();
		}
	}

	private static void bXD(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		SinglePicker singlePicker = (SinglePicker)P_0;
		singlePicker.hXG();
	}

	private void hXG()
	{
		uX9?.Invoke(this, EventArgs.Empty);
	}

	private void gXq()
	{
		bool flag = (double)Minimum <= 0.0 && (double)Maximum >= 0.0;
		float num = Math.Max(Math.Abs(Minimum), Math.Abs(Maximum));
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
			float num6 = Math.Abs(Maximum - Minimum);
			if (!float.IsInfinity(num6) && (double)num6 >= 0.01 && (double)num6 <= num2)
			{
				num3 = 0f - Minimum;
				num5 = 360.0 / (double)num6;
				flag2 = true;
				if ((double)num6 <= 0.01)
				{
					num4 = 0.01;
				}
				else if ((double)num6 < 0.2)
				{
					num4 = 0.02;
				}
				else if ((double)num6 < 2.0)
				{
					num4 = 0.2;
				}
				else if ((double)num6 < 10.0)
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
		mXI();
		if (!HXd)
		{
			HXd = true;
			gXq();
		}
	}

	static SinglePicker()
	{
		awj.QuEwGz();
		MaximumProperty = DependencyProperty.Register(QdM.AR8(1974), typeof(float), typeof(SinglePicker), new PropertyMetadata(float.MaxValue, tXb));
		MinimumProperty = DependencyProperty.Register(QdM.AR8(1992), typeof(float), typeof(SinglePicker), new PropertyMetadata(float.MinValue, tXb));
		RoundingDecimalPlaceProperty = DependencyProperty.Register(QdM.AR8(3396), typeof(int?), typeof(SinglePicker), new PropertyMetadata(7, tXb));
		SmallChangeProperty = DependencyProperty.Register(QdM.AR8(2066), typeof(float), typeof(SinglePicker), new PropertyMetadata(1f, tXb));
		ValueProperty = DependencyProperty.Register(QdM.AR8(1828), typeof(float), typeof(SinglePicker), new PropertyMetadata(0f, bXD));
	}

	[CompilerGenerated]
	private void UXu(object P_0)
	{
		float result = 0f;
		if (P_0 is float)
		{
			result = (float)P_0;
		}
		else if (P_0 != null)
		{
			int num = 0;
			if (Crp() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			if (!float.TryParse(P_0.ToString(), out result))
			{
				result = 0f;
			}
		}
		Value = ldK.vq0(result, Minimum, Maximum, RoundingDecimalPlace);
		Popup ancestorPopup = VisualTreeHelperExtended.GetAncestorPopup(this);
		if (ancestorPopup != null)
		{
			ancestorPopup.IsOpen = false;
		}
	}

	[CompilerGenerated]
	private void cXK(object P_0)
	{
		Value = Math.Max(Minimum, Value - SmallChange);
	}

	[CompilerGenerated]
	private void sXR(object P_0)
	{
		Value = Math.Min(Maximum, Value + SmallChange);
	}

	internal static bool srv()
	{
		return frd == null;
	}

	internal static SinglePicker Crp()
	{
		return frd;
	}
}
