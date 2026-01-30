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
public class VectorPicker : PickerBase
{
	private bool N0u;

	private bool A0K;

	private Selector n0R;

	private DoublePicker q0d;

	public static readonly DependencyProperty MaximumProperty;

	public static readonly DependencyProperty MinimumProperty;

	public static readonly DependencyProperty RoundingDecimalPlaceProperty;

	public static readonly DependencyProperty SmallChangeProperty;

	public static readonly DependencyProperty ValueProperty;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private EventHandler z09;

	internal static VectorPicker kat;

	public Vector Maximum
	{
		get
		{
			return (Vector)GetValue(MaximumProperty);
		}
		set
		{
			SetValue(MaximumProperty, value);
		}
	}

	public Vector Minimum
	{
		get
		{
			return (Vector)GetValue(MinimumProperty);
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

	public Vector SmallChange
	{
		get
		{
			return (Vector)GetValue(SmallChangeProperty);
		}
		set
		{
			SetValue(SmallChangeProperty, value);
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1721:PropertyNamesShouldNotMatchGetMethods")]
	public Vector Value
	{
		get
		{
			return (Vector)GetValue(ValueProperty);
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
			EventHandler eventHandler = z09;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref z09, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = z09;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref z09, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public VectorPicker()
	{
		awj.QuEwGz();
		base._002Ector();
		base.DefaultStyleKey = typeof(VectorPicker);
	}

	private string z0f()
	{
		if (D0T() != null)
		{
			int num = 0;
			if (!Kae())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			int selectedIndex = D0T().SelectedIndex;
			int num3 = selectedIndex;
			if (num3 == 1)
			{
				return QdM.AR8(18844);
			}
		}
		return QdM.AR8(20000);
	}

	private static void U0l(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		VectorPicker vectorPicker = (VectorPicker)P_0;
		vectorPicker.l0O(_0020: false, _0020: true, _0020: false, _0020: false);
	}

	private static void a0X(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		VectorPicker vectorPicker = (VectorPicker)P_0;
		vectorPicker.l0O(_0020: true, _0020: false, _0020: false, _0020: false);
	}

	private void x0x(object P_0, SelectionChangedEventArgs P_1)
	{
		l0O(_0020: true, _0020: true, _0020: true, _0020: true);
	}

	private static void o00(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		VectorPicker vectorPicker = (VectorPicker)P_0;
		vectorPicker.l0O(_0020: false, _0020: false, _0020: true, _0020: false);
	}

	private void M0Y(object P_0, EventArgs P_1)
	{
		if (A0K || A0D() == null)
		{
			return;
		}
		try
		{
			N0u = true;
			string text = z0f();
			string text2 = text;
			if (!(text2 == QdM.AR8(20000)))
			{
				if (text2 == QdM.AR8(18844))
				{
					Value = new Vector(Value.X, A0D().Value);
				}
			}
			else
			{
				Value = new Vector(A0D().Value, Value.Y);
			}
		}
		finally
		{
			N0u = false;
		}
	}

	private static void o0g(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		VectorPicker vectorPicker = (VectorPicker)P_0;
		vectorPicker.l0O(_0020: false, _0020: false, _0020: false, _0020: true);
		vectorPicker.H0o();
	}

	[SpecialName]
	private Selector D0T()
	{
		return n0R;
	}

	[SpecialName]
	private void P0I(Selector value)
	{
		int num = 1;
		bool flag = default(bool);
		while (true)
		{
			int num2 = num;
			do
			{
				switch (num2)
				{
				case 1:
					break;
				default:
					if (flag)
					{
						return;
					}
					if (n0R != null)
					{
						n0R.SelectionChanged -= x0x;
					}
					n0R = value;
					if (n0R != null)
					{
						if (n0R.SelectedIndex == -1 && n0R.Items.Count > 0)
						{
							n0R.SelectedIndex = 0;
						}
						n0R.SelectionChanged += x0x;
					}
					return;
				}
				flag = n0R == value;
				num2 = 0;
			}
			while (Kae());
		}
	}

	private void H0o()
	{
		z09?.Invoke(this, EventArgs.Empty);
	}

	private void l0O(bool P_0, bool P_1, bool P_2, bool P_3)
	{
		if (N0u || A0D() == null)
		{
			return;
		}
		string text = z0f();
		try
		{
			A0K = true;
			string text2 = z0f();
			string text3 = text2;
			if (!(text3 == QdM.AR8(20000)))
			{
				if (text3 == QdM.AR8(18844))
				{
					if (P_0)
					{
						A0D().Minimum = Minimum.Y;
					}
					if (P_1)
					{
						A0D().Maximum = Maximum.Y;
					}
					if (P_2)
					{
						A0D().SmallChange = SmallChange.Y;
					}
					if (P_3)
					{
						A0D().Value = Value.Y;
					}
				}
			}
			else
			{
				if (P_0)
				{
					A0D().Minimum = Minimum.X;
				}
				if (P_1)
				{
					A0D().Maximum = Maximum.X;
				}
				if (P_2)
				{
					A0D().SmallChange = SmallChange.X;
				}
				if (P_3)
				{
					A0D().Value = Value.X;
				}
			}
		}
		finally
		{
			A0K = false;
		}
	}

	[SpecialName]
	private DoublePicker A0D()
	{
		return q0d;
	}

	[SpecialName]
	private void c0G(DoublePicker value)
	{
		if (q0d != value)
		{
			if (q0d != null)
			{
				q0d.ValueChanged -= M0Y;
			}
			q0d = value;
			if (q0d != null)
			{
				q0d.ValueChanged += M0Y;
			}
		}
	}

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		P0I(GetTemplateChild(QdM.AR8(3528)) as Selector);
		c0G(GetTemplateChild(QdM.AR8(3566)) as DoublePicker);
		l0O(_0020: true, _0020: true, _0020: true, _0020: true);
	}

	static VectorPicker()
	{
		awj.QuEwGz();
		MaximumProperty = DependencyProperty.Register(QdM.AR8(1974), typeof(Vector), typeof(VectorPicker), new PropertyMetadata(Jdb.xuY, U0l));
		MinimumProperty = DependencyProperty.Register(QdM.AR8(1992), typeof(Vector), typeof(VectorPicker), new PropertyMetadata(Jdb.pug, a0X));
		RoundingDecimalPlaceProperty = DependencyProperty.Register(QdM.AR8(3396), typeof(int?), typeof(VectorPicker), new PropertyMetadata(8));
		SmallChangeProperty = DependencyProperty.Register(QdM.AR8(2066), typeof(Vector), typeof(VectorPicker), new PropertyMetadata(Jdb.Duo, o00));
		ValueProperty = DependencyProperty.Register(QdM.AR8(1828), typeof(Vector), typeof(VectorPicker), new PropertyMetadata(Jdb.Bu0, o0g));
	}

	internal static bool Kae()
	{
		return kat == null;
	}

	internal static VectorPicker LaO()
	{
		return kat;
	}
}
