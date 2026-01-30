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

[TemplatePart(Name = "PART_ValuePicker", Type = typeof(DoublePicker))]
[TemplatePart(Name = "PART_PartSelector", Type = typeof(Selector))]
public class SizePicker : PickerBase
{
	private bool nXn;

	private bool tXJ;

	private Selector RXe;

	private DoublePicker DXk;

	public static readonly DependencyProperty MaximumProperty;

	public static readonly DependencyProperty MinimumProperty;

	public static readonly DependencyProperty RoundingDecimalPlaceProperty;

	public static readonly DependencyProperty SmallChangeProperty;

	public static readonly DependencyProperty ValueProperty;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private EventHandler hXE;

	private static SizePicker Wrw;

	public Size Maximum
	{
		get
		{
			return (Size)GetValue(MaximumProperty);
		}
		set
		{
			SetValue(MaximumProperty, value);
		}
	}

	public Size Minimum
	{
		get
		{
			return (Size)GetValue(MinimumProperty);
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

	public Size SmallChange
	{
		get
		{
			return (Size)GetValue(SmallChangeProperty);
		}
		set
		{
			SetValue(SmallChangeProperty, value);
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1721:PropertyNamesShouldNotMatchGetMethods")]
	public Size Value
	{
		get
		{
			return (Size)GetValue(ValueProperty);
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
			EventHandler eventHandler = hXE;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref hXE, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = hXE;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref hXE, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public SizePicker()
	{
		awj.QuEwGz();
		base._002Ector();
		base.DefaultStyleKey = typeof(SizePicker);
	}

	private string PXF()
	{
		if (XXv() != null)
		{
			int selectedIndex = XXv().SelectedIndex;
			int num = 0;
			if (!kro())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			int num3 = selectedIndex;
			if (num3 == 1)
			{
				return QdM.AR8(19984);
			}
		}
		return QdM.AR8(19970);
	}

	private static void YXA(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		SizePicker sizePicker = (SizePicker)P_0;
		sizePicker.LXr(_0020: false, _0020: true, _0020: false, _0020: false);
	}

	private static void EX3(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		SizePicker sizePicker = (SizePicker)P_0;
		sizePicker.LXr(_0020: true, _0020: false, _0020: false, _0020: false);
	}

	private void cXy(object P_0, SelectionChangedEventArgs P_1)
	{
		LXr(_0020: true, _0020: true, _0020: true, _0020: true);
	}

	private static void gXm(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		SizePicker sizePicker = (SizePicker)P_0;
		sizePicker.LXr(_0020: false, _0020: false, _0020: true, _0020: false);
	}

	private void uXS(object P_0, EventArgs P_1)
	{
		if (tXJ || LXi() == null)
		{
			return;
		}
		try
		{
			nXn = true;
			string text = PXF();
			string text2 = text;
			if (text2 == QdM.AR8(19970))
			{
				Value = new Size(LXi().Value, Value.Height);
			}
			else if (text2 == QdM.AR8(19984))
			{
				Value = new Size(Value.Width, LXi().Value);
			}
		}
		finally
		{
			nXn = false;
		}
	}

	private static void CX1(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		SizePicker sizePicker = (SizePicker)P_0;
		sizePicker.LXr(_0020: false, _0020: false, _0020: false, _0020: true);
		sizePicker.JX8();
	}

	[SpecialName]
	private Selector XXv()
	{
		return RXe;
	}

	[SpecialName]
	private void uXp(Selector value)
	{
		if (RXe == value)
		{
			return;
		}
		if (RXe != null)
		{
			RXe.SelectionChanged -= cXy;
		}
		RXe = value;
		if (RXe != null)
		{
			if (RXe.SelectedIndex == -1 && RXe.Items.Count > 0)
			{
				RXe.SelectedIndex = 0;
			}
			RXe.SelectionChanged += cXy;
		}
	}

	private void JX8()
	{
		hXE?.Invoke(this, EventArgs.Empty);
	}

	private void LXr(bool P_0, bool P_1, bool P_2, bool P_3)
	{
		if (nXn || LXi() == null)
		{
			return;
		}
		string text = PXF();
		try
		{
			tXJ = true;
			string text2 = PXF();
			string text3 = text2;
			if (!(text3 == QdM.AR8(19970)))
			{
				if (text3 == QdM.AR8(19984))
				{
					if (P_0)
					{
						LXi().Minimum = Minimum.Height;
					}
					if (P_1)
					{
						LXi().Maximum = Maximum.Height;
					}
					if (P_2)
					{
						LXi().SmallChange = SmallChange.Height;
					}
					if (P_3)
					{
						LXi().Value = Value.Height;
					}
				}
			}
			else
			{
				if (P_0)
				{
					LXi().Minimum = Minimum.Width;
				}
				if (P_1)
				{
					LXi().Maximum = Maximum.Width;
				}
				if (P_2)
				{
					LXi().SmallChange = SmallChange.Width;
				}
				if (P_3)
				{
					LXi().Value = Value.Width;
				}
			}
		}
		finally
		{
			tXJ = false;
		}
	}

	[SpecialName]
	private DoublePicker LXi()
	{
		return DXk;
	}

	[SpecialName]
	private void bXZ(DoublePicker value)
	{
		if (DXk == value)
		{
			int num = 0;
			if (sr2() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			case 0:
				break;
			}
			return;
		}
		if (DXk != null)
		{
			DXk.ValueChanged -= uXS;
		}
		DXk = value;
		if (DXk != null)
		{
			DXk.ValueChanged += uXS;
		}
	}

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		uXp(GetTemplateChild(QdM.AR8(3528)) as Selector);
		bXZ(GetTemplateChild(QdM.AR8(3566)) as DoublePicker);
		LXr(_0020: true, _0020: true, _0020: true, _0020: true);
	}

	static SizePicker()
	{
		awj.QuEwGz();
		MaximumProperty = DependencyProperty.Register(QdM.AR8(1974), typeof(Size), typeof(SizePicker), new PropertyMetadata(ddD.rqd, YXA));
		MinimumProperty = DependencyProperty.Register(QdM.AR8(1992), typeof(Size), typeof(SizePicker), new PropertyMetadata(ddD.vq9, EX3));
		RoundingDecimalPlaceProperty = DependencyProperty.Register(QdM.AR8(3396), typeof(int?), typeof(SizePicker), new PropertyMetadata(8));
		SmallChangeProperty = DependencyProperty.Register(QdM.AR8(2066), typeof(Size), typeof(SizePicker), new PropertyMetadata(ddD.oq5, gXm));
		ValueProperty = DependencyProperty.Register(QdM.AR8(1828), typeof(Size), typeof(SizePicker), new PropertyMetadata(ddD.jqR, CX1));
	}

	internal static bool kro()
	{
		return Wrw == null;
	}

	internal static SizePicker sr2()
	{
		return Wrw;
	}
}
