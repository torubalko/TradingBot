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
public class PointPicker : PickerBase
{
	private bool FfA;

	private bool jf3;

	private Selector lfy;

	private DoublePicker Lfm;

	public static readonly DependencyProperty MaximumProperty;

	public static readonly DependencyProperty MinimumProperty;

	public static readonly DependencyProperty RoundingDecimalPlaceProperty;

	public static readonly DependencyProperty SmallChangeProperty;

	public static readonly DependencyProperty ValueProperty;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private EventHandler PfS;

	private static PointPicker Ora;

	public Point Maximum
	{
		get
		{
			return (Point)GetValue(MaximumProperty);
		}
		set
		{
			SetValue(MaximumProperty, value);
		}
	}

	public Point Minimum
	{
		get
		{
			return (Point)GetValue(MinimumProperty);
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

	public Point SmallChange
	{
		get
		{
			return (Point)GetValue(SmallChangeProperty);
		}
		set
		{
			SetValue(SmallChangeProperty, value);
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1721:PropertyNamesShouldNotMatchGetMethods")]
	public Point Value
	{
		get
		{
			return (Point)GetValue(ValueProperty);
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
			EventHandler eventHandler = PfS;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref PfS, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = PfS;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref PfS, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public PointPicker()
	{
		awj.QuEwGz();
		base._002Ector();
		base.DefaultStyleKey = typeof(PointPicker);
	}

	private string jfI()
	{
		if (Vf9() != null)
		{
			int selectedIndex = Vf9().SelectedIndex;
			int num = selectedIndex;
			if (num == 1)
			{
				return QdM.AR8(18844);
			}
		}
		return QdM.AR8(20000);
	}

	private static void bfb(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		PointPicker pointPicker = (PointPicker)P_0;
		pointPicker.Tfd(_0020: false, _0020: true, _0020: false, _0020: false);
	}

	private static void CfD(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		PointPicker pointPicker = (PointPicker)P_0;
		pointPicker.Tfd(_0020: true, _0020: false, _0020: false, _0020: false);
	}

	private void EfG(object P_0, SelectionChangedEventArgs P_1)
	{
		Tfd(_0020: true, _0020: true, _0020: true, _0020: true);
	}

	private static void lfq(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		PointPicker pointPicker = (PointPicker)P_0;
		pointPicker.Tfd(_0020: false, _0020: false, _0020: true, _0020: false);
	}

	private void Lfu(object P_0, EventArgs P_1)
	{
		if (jf3 || rfH() == null)
		{
			return;
		}
		try
		{
			FfA = true;
			string text = jfI();
			string text2 = text;
			if (!(text2 == QdM.AR8(20000)))
			{
				if (text2 == QdM.AR8(18844))
				{
					Value = new Point(Value.X, rfH().Value);
				}
			}
			else
			{
				Value = new Point(rfH().Value, Value.Y);
			}
		}
		finally
		{
			FfA = false;
		}
	}

	private static void jfK(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		PointPicker pointPicker = (PointPicker)P_0;
		pointPicker.Tfd(_0020: false, _0020: false, _0020: false, _0020: true);
		pointPicker.MfR();
	}

	[SpecialName]
	private Selector Vf9()
	{
		return lfy;
	}

	[SpecialName]
	private void Nf5(Selector value)
	{
		if (lfy == value)
		{
			return;
		}
		if (lfy != null)
		{
			int num = 0;
			if (ArG() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			lfy.SelectionChanged -= EfG;
		}
		lfy = value;
		if (lfy != null)
		{
			if (lfy.SelectedIndex == -1 && lfy.Items.Count > 0)
			{
				lfy.SelectedIndex = 0;
			}
			lfy.SelectionChanged += EfG;
		}
	}

	private void MfR()
	{
		PfS?.Invoke(this, EventArgs.Empty);
	}

	private void Tfd(bool P_0, bool P_1, bool P_2, bool P_3)
	{
		if (FfA || rfH() == null)
		{
			return;
		}
		string text = jfI();
		try
		{
			jf3 = true;
			string text2 = jfI();
			string text3 = text2;
			if (!(text3 == QdM.AR8(20000)))
			{
				if (text3 == QdM.AR8(18844))
				{
					if (P_0)
					{
						rfH().Minimum = Minimum.Y;
					}
					if (P_1)
					{
						rfH().Maximum = Maximum.Y;
					}
					if (P_2)
					{
						rfH().SmallChange = SmallChange.Y;
					}
					if (P_3)
					{
						rfH().Value = Value.Y;
					}
				}
			}
			else
			{
				if (P_0)
				{
					rfH().Minimum = Minimum.X;
				}
				if (P_1)
				{
					rfH().Maximum = Maximum.X;
				}
				if (P_2)
				{
					rfH().SmallChange = SmallChange.X;
				}
				if (P_3)
				{
					rfH().Value = Value.X;
				}
			}
		}
		finally
		{
			jf3 = false;
		}
	}

	[SpecialName]
	private DoublePicker rfH()
	{
		return Lfm;
	}

	[SpecialName]
	private void ifL(DoublePicker value)
	{
		if (Lfm != value)
		{
			if (Lfm != null)
			{
				Lfm.ValueChanged -= Lfu;
			}
			Lfm = value;
			if (Lfm != null)
			{
				Lfm.ValueChanged += Lfu;
			}
		}
	}

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		Nf5(GetTemplateChild(QdM.AR8(3528)) as Selector);
		ifL(GetTemplateChild(QdM.AR8(3566)) as DoublePicker);
		Tfd(_0020: true, _0020: true, _0020: true, _0020: true);
	}

	static PointPicker()
	{
		awj.QuEwGz();
		MaximumProperty = DependencyProperty.Register(QdM.AR8(1974), typeof(Point), typeof(PointPicker), new PropertyMetadata(HdN.YGy, bfb));
		MinimumProperty = DependencyProperty.Register(QdM.AR8(1992), typeof(Point), typeof(PointPicker), new PropertyMetadata(HdN.tGm, CfD));
		RoundingDecimalPlaceProperty = DependencyProperty.Register(QdM.AR8(3396), typeof(int?), typeof(PointPicker), new PropertyMetadata(8));
		SmallChangeProperty = DependencyProperty.Register(QdM.AR8(2066), typeof(Point), typeof(PointPicker), new PropertyMetadata(HdN.xGS, lfq));
		ValueProperty = DependencyProperty.Register(QdM.AR8(1828), typeof(Point), typeof(PointPicker), new PropertyMetadata(HdN.FG3, jfK));
	}

	internal static bool krj()
	{
		return Ora == null;
	}

	internal static PointPicker ArG()
	{
		return Ora;
	}
}
