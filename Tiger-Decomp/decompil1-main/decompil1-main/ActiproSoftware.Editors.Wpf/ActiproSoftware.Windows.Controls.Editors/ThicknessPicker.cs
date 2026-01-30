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

[TemplatePart(Name = "PART_PartSelector", Type = typeof(Selector))]
[TemplatePart(Name = "PART_ValuePicker", Type = typeof(DoublePicker))]
public class ThicknessPicker : PickerBase
{
	private bool Yxl;

	private bool QxX;

	private Selector jxx;

	private DoublePicker vx0;

	public static readonly DependencyProperty MaximumProperty;

	public static readonly DependencyProperty MinimumProperty;

	public static readonly DependencyProperty RoundingDecimalPlaceProperty;

	public static readonly DependencyProperty SmallChangeProperty;

	public static readonly DependencyProperty ValueProperty;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private EventHandler fxY;

	private static ThicknessPicker wrf;

	public Thickness Maximum
	{
		get
		{
			return (Thickness)GetValue(MaximumProperty);
		}
		set
		{
			SetValue(MaximumProperty, value);
		}
	}

	public Thickness Minimum
	{
		get
		{
			return (Thickness)GetValue(MinimumProperty);
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

	public Thickness SmallChange
	{
		get
		{
			return (Thickness)GetValue(SmallChangeProperty);
		}
		set
		{
			SetValue(SmallChangeProperty, value);
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1721:PropertyNamesShouldNotMatchGetMethods")]
	public Thickness Value
	{
		get
		{
			return (Thickness)GetValue(ValueProperty);
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
			EventHandler eventHandler = fxY;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref fxY, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = fxY;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref fxY, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public ThicknessPicker()
	{
		awj.QuEwGz();
		base._002Ector();
		base.DefaultStyleKey = typeof(ThicknessPicker);
	}

	private string KXw()
	{
		if (uxs() == null)
		{
			goto IL_0054;
		}
		switch (uxs().SelectedIndex)
		{
		case 3:
			break;
		default:
			goto IL_0054;
		case 2:
			goto IL_00bf;
		case 1:
			goto IL_00da;
		}
		string result = QdM.AR8(22794);
		int num = 0;
		if (!erN())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		goto IL_0065;
		IL_0065:
		return result;
		IL_00da:
		result = QdM.AR8(22770);
		goto IL_0065;
		IL_00bf:
		result = QdM.AR8(22780);
		goto IL_0065;
		IL_0054:
		result = QdM.AR8(22810);
		goto IL_0065;
	}

	private static void KXN(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		ThicknessPicker thicknessPicker = (ThicknessPicker)P_0;
		thicknessPicker.dxM(_0020: false, _0020: true, _0020: false, _0020: false);
	}

	private static void LXU(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		ThicknessPicker thicknessPicker = (ThicknessPicker)P_0;
		thicknessPicker.dxM(_0020: true, _0020: false, _0020: false, _0020: false);
	}

	private void oXz(object P_0, SelectionChangedEventArgs P_1)
	{
		dxM(_0020: true, _0020: true, _0020: true, _0020: true);
	}

	private static void sxQ(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		ThicknessPicker thicknessPicker = (ThicknessPicker)P_0;
		thicknessPicker.dxM(_0020: false, _0020: false, _0020: true, _0020: false);
	}

	private void lxV(object P_0, EventArgs P_1)
	{
		if (QxX || fx2() == null)
		{
			return;
		}
		try
		{
			Yxl = true;
			string text = KXw();
			string text2 = text;
			if (text2 == QdM.AR8(22810))
			{
				Value = new Thickness(fx2().Value, Value.Top, Value.Right, Value.Bottom);
				int num = 0;
				if (RrL() != null)
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
			else if (!(text2 == QdM.AR8(22770)))
			{
				if (!(text2 == QdM.AR8(22780)))
				{
					if (text2 == QdM.AR8(22794))
					{
						Value = new Thickness(Value.Left, Value.Top, Value.Right, fx2().Value);
					}
				}
				else
				{
					Value = new Thickness(Value.Left, Value.Top, fx2().Value, Value.Bottom);
				}
			}
			else
			{
				Value = new Thickness(Value.Left, fx2().Value, Value.Right, Value.Bottom);
			}
		}
		finally
		{
			Yxl = false;
		}
	}

	private static void lxC(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		ThicknessPicker thicknessPicker = (ThicknessPicker)P_0;
		thicknessPicker.dxM(_0020: false, _0020: false, _0020: false, _0020: true);
		thicknessPicker.Vx6();
	}

	[SpecialName]
	private Selector uxs()
	{
		return jxx;
	}

	[SpecialName]
	private void dxj(Selector value)
	{
		if (jxx == value)
		{
			return;
		}
		if (jxx != null)
		{
			jxx.SelectionChanged -= oXz;
		}
		jxx = value;
		if (jxx != null)
		{
			if (jxx.SelectedIndex == -1 && jxx.Items.Count > 0)
			{
				jxx.SelectedIndex = 0;
			}
			jxx.SelectionChanged += oXz;
			int num = 0;
			if (!erN())
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

	private void Vx6()
	{
		fxY?.Invoke(this, EventArgs.Empty);
	}

	private void dxM(bool P_0, bool P_1, bool P_2, bool P_3)
	{
		if (Yxl || fx2() == null)
		{
			return;
		}
		string text = KXw();
		try
		{
			QxX = true;
			string text2 = KXw();
			string text3 = text2;
			if (!(text3 == QdM.AR8(22810)))
			{
				if (!(text3 == QdM.AR8(22770)))
				{
					if (!(text3 == QdM.AR8(22780)))
					{
						if (text3 == QdM.AR8(22794))
						{
							if (P_0)
							{
								fx2().Minimum = Minimum.Bottom;
							}
							if (P_1)
							{
								fx2().Maximum = Maximum.Bottom;
							}
							if (P_2)
							{
								fx2().SmallChange = SmallChange.Bottom;
							}
							if (P_3)
							{
								fx2().Value = Value.Bottom;
							}
						}
					}
					else
					{
						if (P_0)
						{
							fx2().Minimum = Minimum.Right;
						}
						if (P_1)
						{
							fx2().Maximum = Maximum.Right;
						}
						if (P_2)
						{
							fx2().SmallChange = SmallChange.Right;
						}
						if (P_3)
						{
							fx2().Value = Value.Right;
						}
					}
				}
				else
				{
					if (P_0)
					{
						fx2().Minimum = Minimum.Top;
					}
					if (P_1)
					{
						fx2().Maximum = Maximum.Top;
					}
					if (P_2)
					{
						fx2().SmallChange = SmallChange.Top;
					}
					if (P_3)
					{
						fx2().Value = Value.Top;
					}
				}
			}
			else
			{
				if (P_0)
				{
					fx2().Minimum = Minimum.Left;
				}
				if (P_1)
				{
					fx2().Maximum = Maximum.Left;
				}
				if (P_2)
				{
					fx2().SmallChange = SmallChange.Left;
				}
				if (P_3)
				{
					fx2().Value = Value.Left;
				}
			}
		}
		finally
		{
			QxX = false;
		}
	}

	[SpecialName]
	private DoublePicker fx2()
	{
		return vx0;
	}

	[SpecialName]
	private void Exa(DoublePicker value)
	{
		if (vx0 == value)
		{
			return;
		}
		if (vx0 != null)
		{
			vx0.ValueChanged -= lxV;
		}
		vx0 = value;
		bool flag = vx0 != null;
		int num = 0;
		if (!erN())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (flag)
		{
			vx0.ValueChanged += lxV;
		}
	}

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		dxj(GetTemplateChild(QdM.AR8(3528)) as Selector);
		Exa(GetTemplateChild(QdM.AR8(3566)) as DoublePicker);
		dxM(_0020: true, _0020: true, _0020: true, _0020: true);
	}

	static ThicknessPicker()
	{
		awj.QuEwGz();
		MaximumProperty = DependencyProperty.Register(QdM.AR8(1974), typeof(Thickness), typeof(ThicknessPicker), new PropertyMetadata(pdg.Fqr, KXN));
		MinimumProperty = DependencyProperty.Register(QdM.AR8(1992), typeof(Thickness), typeof(ThicknessPicker), new PropertyMetadata(pdg.qqv, LXU));
		RoundingDecimalPlaceProperty = DependencyProperty.Register(QdM.AR8(3396), typeof(int?), typeof(ThicknessPicker), new PropertyMetadata(8));
		SmallChangeProperty = DependencyProperty.Register(QdM.AR8(2066), typeof(Thickness), typeof(ThicknessPicker), new PropertyMetadata(pdg.qqp, sxQ));
		ValueProperty = DependencyProperty.Register(QdM.AR8(1828), typeof(Thickness), typeof(ThicknessPicker), new PropertyMetadata(pdg.Xq8, lxC));
	}

	internal static bool erN()
	{
		return wrf == null;
	}

	internal static ThicknessPicker RrL()
	{
		return wrf;
	}
}
