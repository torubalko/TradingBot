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
[TemplatePart(Name = "PART_ValuePicker", Type = typeof(Int32Picker))]
public class Int32RectPicker : PickerBase
{
	private bool aP8;

	private bool hPr;

	private Selector DPv;

	private Int32Picker wPp;

	public static readonly DependencyProperty MaximumProperty;

	public static readonly DependencyProperty MinimumProperty;

	public static readonly DependencyProperty SmallChangeProperty;

	public static readonly DependencyProperty ValueProperty;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private EventHandler OPW;

	internal static Int32RectPicker xWQ;

	public Int32Rect Maximum
	{
		get
		{
			return (Int32Rect)GetValue(MaximumProperty);
		}
		set
		{
			SetValue(MaximumProperty, value);
		}
	}

	public Int32Rect Minimum
	{
		get
		{
			return (Int32Rect)GetValue(MinimumProperty);
		}
		set
		{
			SetValue(MinimumProperty, value);
		}
	}

	public Int32Rect SmallChange
	{
		get
		{
			return (Int32Rect)GetValue(SmallChangeProperty);
		}
		set
		{
			SetValue(SmallChangeProperty, value);
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1721:PropertyNamesShouldNotMatchGetMethods")]
	public Int32Rect Value
	{
		get
		{
			return (Int32Rect)GetValue(ValueProperty);
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
			EventHandler eventHandler = OPW;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref OPW, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = OPW;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref OPW, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public Int32RectPicker()
	{
		awj.QuEwGz();
		base._002Ector();
		base.DefaultStyleKey = typeof(Int32RectPicker);
	}

	private string LPK()
	{
		if (oPA() != null)
		{
			switch (oPA().SelectedIndex)
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

	private static void zPR(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		Int32RectPicker int32RectPicker = (Int32RectPicker)P_0;
		int32RectPicker.PPF(_0020: false, _0020: true, _0020: false, _0020: false);
	}

	private static void MPd(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		Int32RectPicker int32RectPicker = (Int32RectPicker)P_0;
		int32RectPicker.PPF(_0020: true, _0020: false, _0020: false, _0020: false);
	}

	private void OP9(object P_0, SelectionChangedEventArgs P_1)
	{
		PPF(_0020: true, _0020: true, _0020: true, _0020: true);
	}

	private static void aP5(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		Int32RectPicker int32RectPicker = (Int32RectPicker)P_0;
		int32RectPicker.PPF(_0020: false, _0020: false, _0020: true, _0020: false);
	}

	private void mPc(object P_0, EventArgs P_1)
	{
		if (hPr || aPm() == null)
		{
			return;
		}
		try
		{
			aP8 = true;
			string text = LPK();
			string text2 = text;
			if (!(text2 == QdM.AR8(20000)))
			{
				if (!(text2 == QdM.AR8(18844)))
				{
					if (!(text2 == QdM.AR8(19970)))
					{
						if (text2 == QdM.AR8(19984))
						{
							Value = new Int32Rect(Value.X, Value.Y, Value.Width, aPm().Value);
						}
					}
					else
					{
						Value = new Int32Rect(Value.X, Value.Y, aPm().Value, Value.Height);
					}
				}
				else
				{
					Value = new Int32Rect(Value.X, aPm().Value, Value.Width, Value.Height);
				}
			}
			else
			{
				Value = new Int32Rect(aPm().Value, Value.Y, Value.Width, Value.Height);
			}
		}
		finally
		{
			aP8 = false;
		}
	}

	private static void LPH(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		Int32RectPicker int32RectPicker = (Int32RectPicker)P_0;
		int32RectPicker.PPF(_0020: false, _0020: false, _0020: false, _0020: true);
		int32RectPicker.DPL();
	}

	[SpecialName]
	private Selector oPA()
	{
		return DPv;
	}

	[SpecialName]
	private void PP3(Selector value)
	{
		if (DPv == value)
		{
			return;
		}
		if (DPv != null)
		{
			DPv.SelectionChanged -= OP9;
		}
		DPv = value;
		if (DPv != null)
		{
			if (DPv.SelectedIndex == -1 && DPv.Items.Count > 0)
			{
				DPv.SelectedIndex = 0;
			}
			DPv.SelectionChanged += OP9;
		}
	}

	private void DPL()
	{
		OPW?.Invoke(this, EventArgs.Empty);
	}

	private void PPF(bool P_0, bool P_1, bool P_2, bool P_3)
	{
		if (aP8 || aPm() == null)
		{
			return;
		}
		string text = LPK();
		try
		{
			hPr = true;
			string text2 = LPK();
			string text3 = text2;
			if (!(text3 == QdM.AR8(20000)))
			{
				if (!(text3 == QdM.AR8(18844)))
				{
					if (!(text3 == QdM.AR8(19970)))
					{
						if (text3 == QdM.AR8(19984))
						{
							if (P_0)
							{
								aPm().Minimum = Minimum.Height;
							}
							if (P_1)
							{
								aPm().Maximum = Maximum.Height;
							}
							if (P_2)
							{
								aPm().SmallChange = SmallChange.Height;
							}
							if (P_3)
							{
								aPm().Value = Value.Height;
							}
						}
					}
					else
					{
						if (P_0)
						{
							aPm().Minimum = Minimum.Width;
						}
						if (P_1)
						{
							aPm().Maximum = Maximum.Width;
						}
						if (P_2)
						{
							aPm().SmallChange = SmallChange.Width;
						}
						if (P_3)
						{
							aPm().Value = Value.Width;
						}
					}
				}
				else
				{
					if (P_0)
					{
						aPm().Minimum = Minimum.Y;
					}
					if (P_1)
					{
						aPm().Maximum = Maximum.Y;
					}
					if (P_2)
					{
						aPm().SmallChange = SmallChange.Y;
					}
					if (P_3)
					{
						aPm().Value = Value.Y;
					}
				}
			}
			else
			{
				if (P_0)
				{
					aPm().Minimum = Minimum.X;
				}
				if (P_1)
				{
					aPm().Maximum = Maximum.X;
				}
				if (P_2)
				{
					aPm().SmallChange = SmallChange.X;
				}
				if (P_3)
				{
					aPm().Value = Value.X;
				}
			}
		}
		finally
		{
			hPr = false;
		}
	}

	[SpecialName]
	private Int32Picker aPm()
	{
		return wPp;
	}

	[SpecialName]
	private void OPS(Int32Picker value)
	{
		if (wPp != value)
		{
			if (wPp != null)
			{
				wPp.ValueChanged -= mPc;
			}
			wPp = value;
			if (wPp != null)
			{
				wPp.ValueChanged += mPc;
			}
		}
	}

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		PP3(GetTemplateChild(QdM.AR8(3528)) as Selector);
		OPS(GetTemplateChild(QdM.AR8(3566)) as Int32Picker);
		PPF(_0020: true, _0020: true, _0020: true, _0020: true);
	}

	static Int32RectPicker()
	{
		awj.QuEwGz();
		MaximumProperty = DependencyProperty.Register(QdM.AR8(1974), typeof(Int32Rect), typeof(Int32RectPicker), new PropertyMetadata(Vd0.uGa, zPR));
		MinimumProperty = DependencyProperty.Register(QdM.AR8(1992), typeof(Int32Rect), typeof(Int32RectPicker), new PropertyMetadata(Vd0.gGf, MPd));
		SmallChangeProperty = DependencyProperty.Register(QdM.AR8(2066), typeof(Int32Rect), typeof(Int32RectPicker), new PropertyMetadata(Vd0.qGl, aP5));
		ValueProperty = DependencyProperty.Register(QdM.AR8(1828), typeof(Int32Rect), typeof(Int32RectPicker), new PropertyMetadata(Vd0.gG2, LPH));
	}

	internal static bool gWZ()
	{
		return xWQ == null;
	}

	internal static Int32RectPicker jWR()
	{
		return xWQ;
	}
}
