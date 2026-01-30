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
public class RectPicker : PickerBase
{
	private bool vlt;

	private bool Uln;

	private Selector BlJ;

	private DoublePicker sle;

	public static readonly DependencyProperty MaximumProperty;

	public static readonly DependencyProperty MinimumProperty;

	public static readonly DependencyProperty RoundingDecimalPlaceProperty;

	public static readonly DependencyProperty SmallChangeProperty;

	public static readonly DependencyProperty ValueProperty;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private EventHandler Tlk;

	internal static RectPicker cr5;

	public Rect Maximum
	{
		get
		{
			return (Rect)GetValue(MaximumProperty);
		}
		set
		{
			SetValue(MaximumProperty, value);
		}
	}

	public Rect Minimum
	{
		get
		{
			return (Rect)GetValue(MinimumProperty);
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

	public Rect SmallChange
	{
		get
		{
			return (Rect)GetValue(SmallChangeProperty);
		}
		set
		{
			SetValue(SmallChangeProperty, value);
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1721:PropertyNamesShouldNotMatchGetMethods")]
	public Rect Value
	{
		get
		{
			return (Rect)GetValue(ValueProperty);
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
			EventHandler eventHandler = Tlk;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref Tlk, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = Tlk;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref Tlk, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public RectPicker()
	{
		awj.QuEwGz();
		base._002Ector();
		base.DefaultStyleKey = typeof(RectPicker);
	}

	private string ClL()
	{
		if (Ulr() != null)
		{
			switch (Ulr().SelectedIndex)
			{
			case 1:
				return QdM.AR8(18844);
			case 2:
				return QdM.AR8(19970);
			case 3:
				return QdM.AR8(19984);
			}
		}
		return QdM.AR8(20000);
	}

	private static void IlF(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		RectPicker rectPicker = (RectPicker)P_0;
		rectPicker.Cl8(_0020: false, _0020: true, _0020: false, _0020: false);
	}

	private static void UlA(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		RectPicker rectPicker = (RectPicker)P_0;
		rectPicker.Cl8(_0020: true, _0020: false, _0020: false, _0020: false);
	}

	private void il3(object P_0, SelectionChangedEventArgs P_1)
	{
		Cl8(_0020: true, _0020: true, _0020: true, _0020: true);
	}

	private static void qly(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		RectPicker rectPicker = (RectPicker)P_0;
		rectPicker.Cl8(_0020: false, _0020: false, _0020: true, _0020: false);
	}

	private void ylm(object P_0, EventArgs P_1)
	{
		if (Uln || DlW() == null)
		{
			return;
		}
		try
		{
			vlt = true;
			string text = ClL();
			string text2 = text;
			if (!(text2 == QdM.AR8(20000)))
			{
				if (text2 == QdM.AR8(18844))
				{
					Value = new Rect(Value.X, DlW().Value, Value.Width, Value.Height);
				}
				else if (text2 == QdM.AR8(19970))
				{
					Value = new Rect(Value.X, Value.Y, DlW().Value, Value.Height);
				}
				else if (text2 == QdM.AR8(19984))
				{
					Value = new Rect(Value.X, Value.Y, Value.Width, DlW().Value);
				}
			}
			else
			{
				Value = new Rect(DlW().Value, Value.Y, Value.Width, Value.Height);
			}
		}
		finally
		{
			vlt = false;
		}
	}

	private static void JlS(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		RectPicker rectPicker = (RectPicker)P_0;
		rectPicker.Cl8(_0020: false, _0020: false, _0020: false, _0020: true);
		rectPicker.ol1();
	}

	[SpecialName]
	private Selector Ulr()
	{
		return BlJ;
	}

	[SpecialName]
	private void ilv(Selector value)
	{
		if (BlJ == value)
		{
			return;
		}
		if (BlJ != null)
		{
			BlJ.SelectionChanged -= il3;
		}
		BlJ = value;
		if (BlJ != null)
		{
			if (BlJ.SelectedIndex == -1 && BlJ.Items.Count > 0)
			{
				BlJ.SelectedIndex = 0;
			}
			BlJ.SelectionChanged += il3;
		}
	}

	private void ol1()
	{
		Tlk?.Invoke(this, EventArgs.Empty);
	}

	private void Cl8(bool P_0, bool P_1, bool P_2, bool P_3)
	{
		if (vlt || DlW() == null)
		{
			return;
		}
		string text = ClL();
		try
		{
			Uln = true;
			string text2 = ClL();
			string text3 = text2;
			int num = 3;
			bool flag = default(bool);
			bool flag2 = default(bool);
			int num2 = default(int);
			while (true)
			{
				switch (num)
				{
				case 4:
					if (flag)
					{
						DlW().Value = Value.Height;
					}
					return;
				default:
					DlW().Minimum = Minimum.X;
					goto IL_0144;
				case 3:
					if (!(text3 == QdM.AR8(20000)))
					{
						if (text3 == QdM.AR8(18844))
						{
							if (P_0)
							{
								DlW().Minimum = Minimum.Y;
							}
							if (P_1)
							{
								DlW().Maximum = Maximum.Y;
							}
							break;
						}
						if (text3 == QdM.AR8(19970))
						{
							if (P_0)
							{
								DlW().Minimum = Minimum.Width;
							}
							if (P_1)
							{
								DlW().Maximum = Maximum.Width;
							}
							if (P_2)
							{
								DlW().SmallChange = SmallChange.Width;
							}
							if (P_3)
							{
								DlW().Value = Value.Width;
							}
							return;
						}
						num = 2;
						continue;
					}
					goto case 1;
				case 5:
					if (flag2)
					{
						DlW().SmallChange = SmallChange.Y;
					}
					if (P_3)
					{
						DlW().Value = Value.Y;
					}
					return;
				case 1:
					if (P_0)
					{
						num = 0;
						if (!lrI())
						{
							num = num2;
						}
						continue;
					}
					goto IL_0144;
				case 2:
					{
						if (!(text3 == QdM.AR8(19984)))
						{
							return;
						}
						if (P_0)
						{
							DlW().Minimum = Minimum.Height;
						}
						if (P_1)
						{
							DlW().Maximum = Maximum.Height;
						}
						if (P_2)
						{
							DlW().SmallChange = SmallChange.Height;
						}
						flag = P_3;
						num = 4;
						continue;
					}
					IL_0144:
					if (P_1)
					{
						DlW().Maximum = Maximum.X;
					}
					if (P_2)
					{
						DlW().SmallChange = SmallChange.X;
					}
					if (P_3)
					{
						DlW().Value = Value.X;
					}
					return;
				}
				flag2 = P_2;
				num = 5;
				if (Yr6() != null)
				{
					num = 0;
				}
			}
		}
		finally
		{
			Uln = false;
		}
	}

	[SpecialName]
	private DoublePicker DlW()
	{
		return sle;
	}

	[SpecialName]
	private void qli(DoublePicker value)
	{
		if (sle == value)
		{
			return;
		}
		if (sle != null)
		{
			sle.ValueChanged -= ylm;
		}
		sle = value;
		bool flag = sle != null;
		int num = 0;
		if (Yr6() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (flag)
		{
			sle.ValueChanged += ylm;
		}
	}

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		ilv(GetTemplateChild(QdM.AR8(3528)) as Selector);
		qli(GetTemplateChild(QdM.AR8(3566)) as DoublePicker);
		Cl8(_0020: true, _0020: true, _0020: true, _0020: true);
	}

	static RectPicker()
	{
		awj.QuEwGz();
		MaximumProperty = DependencyProperty.Register(QdM.AR8(1974), typeof(Rect), typeof(RectPicker), new PropertyMetadata(kdo.wGe, IlF));
		MinimumProperty = DependencyProperty.Register(QdM.AR8(1992), typeof(Rect), typeof(RectPicker), new PropertyMetadata(kdo.bGk, UlA));
		RoundingDecimalPlaceProperty = DependencyProperty.Register(QdM.AR8(3396), typeof(int?), typeof(RectPicker), new PropertyMetadata(8));
		SmallChangeProperty = DependencyProperty.Register(QdM.AR8(2066), typeof(Rect), typeof(RectPicker), new PropertyMetadata(kdo.jGE, qly));
		ValueProperty = DependencyProperty.Register(QdM.AR8(1828), typeof(Rect), typeof(RectPicker), new PropertyMetadata(kdo.nGJ, JlS));
	}

	internal static bool lrI()
	{
		return cr5 == null;
	}

	internal static RectPicker Yr6()
	{
		return cr5;
	}
}
