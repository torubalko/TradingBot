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
public class CornerRadiusPicker : PickerBase
{
	private bool U6Z;

	private bool q6t;

	private Selector E6n;

	private DoublePicker k6J;

	public static readonly DependencyProperty MaximumProperty;

	public static readonly DependencyProperty MinimumProperty;

	public static readonly DependencyProperty RoundingDecimalPlaceProperty;

	public static readonly DependencyProperty SmallChangeProperty;

	public static readonly DependencyProperty ValueProperty;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private EventHandler u6e;

	internal static CornerRadiusPicker Bs;

	public CornerRadius Maximum
	{
		get
		{
			return (CornerRadius)GetValue(MaximumProperty);
		}
		set
		{
			SetValue(MaximumProperty, value);
		}
	}

	public CornerRadius Minimum
	{
		get
		{
			return (CornerRadius)GetValue(MinimumProperty);
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

	public CornerRadius SmallChange
	{
		get
		{
			return (CornerRadius)GetValue(SmallChangeProperty);
		}
		set
		{
			SetValue(SmallChangeProperty, value);
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1721:PropertyNamesShouldNotMatchGetMethods")]
	public CornerRadius Value
	{
		get
		{
			return (CornerRadius)GetValue(ValueProperty);
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
			EventHandler eventHandler = u6e;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref u6e, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = u6e;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref u6e, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public CornerRadiusPicker()
	{
		awj.QuEwGz();
		base._002Ector();
		base.DefaultStyleKey = typeof(CornerRadiusPicker);
	}

	private string Y6H()
	{
		if (c68() != null)
		{
			switch (c68().SelectedIndex)
			{
			case 1:
				return QdM.AR8(3440);
			case 3:
				return QdM.AR8(3486);
			case 2:
				return QdM.AR8(3460);
			}
		}
		return QdM.AR8(3510);
	}

	private static void S6L(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		CornerRadiusPicker cornerRadiusPicker = (CornerRadiusPicker)P_0;
		cornerRadiusPicker.I61(_0020: false, _0020: true, _0020: false, _0020: false);
	}

	private static void v6F(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		CornerRadiusPicker cornerRadiusPicker = (CornerRadiusPicker)P_0;
		cornerRadiusPicker.I61(_0020: true, _0020: false, _0020: false, _0020: false);
	}

	private void c6A(object P_0, SelectionChangedEventArgs P_1)
	{
		I61(_0020: true, _0020: true, _0020: true, _0020: true);
	}

	private static void r63(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		CornerRadiusPicker cornerRadiusPicker = (CornerRadiusPicker)P_0;
		cornerRadiusPicker.I61(_0020: false, _0020: false, _0020: true, _0020: false);
	}

	private void c6y(object P_0, EventArgs P_1)
	{
		if (q6t || A6p() == null)
		{
			return;
		}
		try
		{
			U6Z = true;
			string text = Y6H();
			string text2 = text;
			if (!(text2 == QdM.AR8(3510)))
			{
				if (!(text2 == QdM.AR8(3440)))
				{
					if (!(text2 == QdM.AR8(3460)))
					{
						if (text2 == QdM.AR8(3486))
						{
							Value = new CornerRadius(Value.TopLeft, Value.TopRight, Value.BottomRight, A6p().Value);
						}
					}
					else
					{
						Value = new CornerRadius(Value.TopLeft, Value.TopRight, A6p().Value, Value.BottomLeft);
					}
				}
				else
				{
					Value = new CornerRadius(Value.TopLeft, A6p().Value, Value.BottomRight, Value.BottomLeft);
				}
			}
			else
			{
				Value = new CornerRadius(A6p().Value, Value.TopRight, Value.BottomRight, Value.BottomLeft);
			}
		}
		finally
		{
			U6Z = false;
		}
	}

	private static void F6m(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		CornerRadiusPicker cornerRadiusPicker = (CornerRadiusPicker)P_0;
		cornerRadiusPicker.I61(_0020: false, _0020: false, _0020: false, _0020: true);
		cornerRadiusPicker.n6S();
	}

	[SpecialName]
	private Selector c68()
	{
		return E6n;
	}

	[SpecialName]
	private void G6r(Selector value)
	{
		if (E6n == value)
		{
			return;
		}
		if (E6n != null)
		{
			E6n.SelectionChanged -= c6A;
		}
		E6n = value;
		if (E6n != null)
		{
			if (E6n.SelectedIndex == -1 && E6n.Items.Count > 0)
			{
				E6n.SelectedIndex = 0;
			}
			E6n.SelectionChanged += c6A;
		}
	}

	private void n6S()
	{
		u6e?.Invoke(this, EventArgs.Empty);
	}

	private void I61(bool P_0, bool P_1, bool P_2, bool P_3)
	{
		if (U6Z || A6p() == null)
		{
			return;
		}
		string text = Y6H();
		try
		{
			q6t = true;
			string text2 = Y6H();
			string text3 = text2;
			if (!(text3 == QdM.AR8(3510)))
			{
				if (!(text3 == QdM.AR8(3440)))
				{
					if (!(text3 == QdM.AR8(3460)))
					{
						if (text3 == QdM.AR8(3486))
						{
							if (P_0)
							{
								A6p().Minimum = Minimum.BottomLeft;
							}
							if (P_1)
							{
								A6p().Maximum = Maximum.BottomLeft;
							}
							if (P_2)
							{
								A6p().SmallChange = SmallChange.BottomLeft;
							}
							if (P_3)
							{
								A6p().Value = Value.BottomLeft;
							}
						}
					}
					else
					{
						if (P_0)
						{
							A6p().Minimum = Minimum.BottomRight;
						}
						if (P_1)
						{
							A6p().Maximum = Maximum.BottomRight;
						}
						if (P_2)
						{
							A6p().SmallChange = SmallChange.BottomRight;
						}
						if (P_3)
						{
							A6p().Value = Value.BottomRight;
						}
					}
				}
				else
				{
					if (P_0)
					{
						A6p().Minimum = Minimum.TopRight;
					}
					if (P_1)
					{
						A6p().Maximum = Maximum.TopRight;
					}
					if (P_2)
					{
						A6p().SmallChange = SmallChange.TopRight;
					}
					if (P_3)
					{
						A6p().Value = Value.TopRight;
					}
				}
			}
			else
			{
				if (P_0)
				{
					A6p().Minimum = Minimum.TopLeft;
				}
				if (P_1)
				{
					A6p().Maximum = Maximum.TopLeft;
				}
				if (P_2)
				{
					A6p().SmallChange = SmallChange.TopLeft;
				}
				if (P_3)
				{
					A6p().Value = Value.TopLeft;
				}
			}
		}
		finally
		{
			q6t = false;
		}
	}

	[SpecialName]
	private DoublePicker A6p()
	{
		return k6J;
	}

	[SpecialName]
	private void Y6W(DoublePicker value)
	{
		if (k6J == value)
		{
			return;
		}
		if (k6J != null)
		{
			k6J.ValueChanged -= c6y;
		}
		k6J = value;
		bool flag = k6J != null;
		int num = 0;
		if (ax() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (flag)
		{
			k6J.ValueChanged += c6y;
		}
	}

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		G6r(GetTemplateChild(QdM.AR8(3528)) as Selector);
		Y6W(GetTemplateChild(QdM.AR8(3566)) as DoublePicker);
		I61(_0020: true, _0020: true, _0020: true, _0020: true);
	}

	static CornerRadiusPicker()
	{
		awj.QuEwGz();
		MaximumProperty = DependencyProperty.Register(QdM.AR8(1974), typeof(CornerRadius), typeof(CornerRadiusPicker), new PropertyMetadata(XdB.cbL, S6L));
		MinimumProperty = DependencyProperty.Register(QdM.AR8(1992), typeof(CornerRadius), typeof(CornerRadiusPicker), new PropertyMetadata(XdB.FbF, v6F));
		RoundingDecimalPlaceProperty = DependencyProperty.Register(QdM.AR8(3396), typeof(int?), typeof(CornerRadiusPicker), new PropertyMetadata(8));
		SmallChangeProperty = DependencyProperty.Register(QdM.AR8(2066), typeof(CornerRadius), typeof(CornerRadiusPicker), new PropertyMetadata(XdB.GbA, r63));
		ValueProperty = DependencyProperty.Register(QdM.AR8(1828), typeof(CornerRadius), typeof(CornerRadiusPicker), new PropertyMetadata(XdB.Nbc, F6m));
	}

	internal static bool aY()
	{
		return Bs == null;
	}

	internal static CornerRadiusPicker ax()
	{
		return Bs;
	}
}
