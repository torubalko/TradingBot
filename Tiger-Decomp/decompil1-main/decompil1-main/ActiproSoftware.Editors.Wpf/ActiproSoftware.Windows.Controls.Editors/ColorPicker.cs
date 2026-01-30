using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.Editors.Primitives;
using ActiproSoftware.Windows.Data;
using ActiproSoftware.Windows.Media;

namespace ActiproSoftware.Windows.Controls.Editors;

[TemplatePart(Name = "PART_Component2EditBox", Type = typeof(Int32EditBox))]
[TemplatePart(Name = "PART_Component1EditBox", Type = typeof(Int32EditBox))]
[TemplatePart(Name = "PART_Component3EditBox", Type = typeof(Int32EditBox))]
public class ColorPicker : PickerBase
{
	private enum Gde
	{
		None,
		A,
		R,
		G,
		B,
		Hue,
		Saturation,
		Brightness
	}

	private class uds : IValueConverter
	{
		private static uds ltP;

		public object Convert(object P_0, Type P_1, object P_2, CultureInfo P_3)
		{
			return (int)Math.Round((double)P_0);
		}

		public virtual object ConvertBack(object P_0, Type P_1, object P_2, CultureInfo P_3)
		{
			return (double)(int)P_0;
		}

		public uds()
		{
			awj.QuEwGz();
			base._002Ector();
		}

		internal static bool ft8()
		{
			return ltP == null;
		}

		internal static uds vt1()
		{
			return ltP;
		}
	}

	private class OdW : PercentageConverter
	{
		private static OdW ttQ;

		public override object Convert(object P_0, Type P_1, object P_2, CultureInfo P_3)
		{
			object obj = base.Convert(P_0, P_1, P_2, P_3);
			return (int)Math.Round((double)obj);
		}

		public OdW()
		{
			awj.QuEwGz();
			base._002Ector();
		}

		internal static bool gtZ()
		{
			return ttQ == null;
		}

		internal static OdW ltR()
		{
			return ttQ;
		}
	}

	private Int32EditBox I6G;

	private Int32EditBox g6q;

	private Int32EditBox h6u;

	private bool Q6K;

	public static readonly DependencyProperty AProperty;

	public static readonly DependencyProperty BProperty;

	public static readonly DependencyProperty BrightnessProperty;

	public static readonly DependencyProperty ComparisonValueProperty;

	public static readonly DependencyProperty Component1SwatchBrushProperty;

	public static readonly DependencyProperty Component2SwatchBrushProperty;

	public static readonly DependencyProperty Component3SwatchBrushProperty;

	public static readonly DependencyProperty DegreeInlineTemplateProperty;

	public static readonly DependencyProperty GProperty;

	public static readonly DependencyProperty HasColorEditBoxProperty;

	public static readonly DependencyProperty HueProperty;

	public static readonly DependencyProperty IsAlphaEnabledProperty;

	public static readonly DependencyProperty IsComparisonValueVisibleProperty;

	public static readonly DependencyProperty IsEditableProperty;

	public static readonly DependencyProperty PercentInlineTemplateProperty;

	public static readonly DependencyProperty RProperty;

	public static readonly DependencyProperty SaturationProperty;

	public static readonly DependencyProperty TextInputModeProperty;

	public static readonly DependencyProperty ValueProperty;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private EventHandler i6R;

	private static ColorPicker fM;

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "A")]
	public int A
	{
		get
		{
			return (int)GetValue(AProperty);
		}
		set
		{
			SetValue(AProperty, value);
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "B")]
	public int B
	{
		get
		{
			return (int)GetValue(BProperty);
		}
		set
		{
			SetValue(BProperty, value);
		}
	}

	public double Brightness
	{
		get
		{
			return (double)GetValue(BrightnessProperty);
		}
		set
		{
			SetValue(BrightnessProperty, value);
		}
	}

	public Color ComparisonValue
	{
		get
		{
			return (Color)GetValue(ComparisonValueProperty);
		}
		set
		{
			SetValue(ComparisonValueProperty, value);
		}
	}

	public Brush Component1SwatchBrush
	{
		get
		{
			return (Brush)GetValue(Component1SwatchBrushProperty);
		}
		private set
		{
			SetValue(Component1SwatchBrushProperty, value);
		}
	}

	public Brush Component2SwatchBrush
	{
		get
		{
			return (Brush)GetValue(Component2SwatchBrushProperty);
		}
		private set
		{
			SetValue(Component2SwatchBrushProperty, value);
		}
	}

	public Brush Component3SwatchBrush
	{
		get
		{
			return (Brush)GetValue(Component3SwatchBrushProperty);
		}
		private set
		{
			SetValue(Component3SwatchBrushProperty, value);
		}
	}

	public DataTemplate DegreeInlineTemplate
	{
		get
		{
			return (DataTemplate)GetValue(DegreeInlineTemplateProperty);
		}
		set
		{
			SetValue(DegreeInlineTemplateProperty, value);
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "G")]
	public int G
	{
		get
		{
			return (int)GetValue(GProperty);
		}
		set
		{
			SetValue(GProperty, value);
		}
	}

	public bool HasColorEditBox
	{
		get
		{
			return (bool)GetValue(HasColorEditBoxProperty);
		}
		set
		{
			SetValue(HasColorEditBoxProperty, value);
		}
	}

	public double Hue
	{
		get
		{
			return (double)GetValue(HueProperty);
		}
		set
		{
			SetValue(HueProperty, value);
		}
	}

	public bool IsAlphaEnabled
	{
		get
		{
			return (bool)GetValue(IsAlphaEnabledProperty);
		}
		set
		{
			SetValue(IsAlphaEnabledProperty, value);
		}
	}

	public bool IsComparisonValueVisible
	{
		get
		{
			return (bool)GetValue(IsComparisonValueVisibleProperty);
		}
		set
		{
			SetValue(IsComparisonValueVisibleProperty, value);
		}
	}

	public bool IsEditable
	{
		get
		{
			return (bool)GetValue(IsEditableProperty);
		}
		set
		{
			SetValue(IsEditableProperty, value);
		}
	}

	public DataTemplate PercentInlineTemplate
	{
		get
		{
			return (DataTemplate)GetValue(PercentInlineTemplateProperty);
		}
		set
		{
			SetValue(PercentInlineTemplateProperty, value);
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "R")]
	public int R
	{
		get
		{
			return (int)GetValue(RProperty);
		}
		set
		{
			SetValue(RProperty, value);
		}
	}

	public double Saturation
	{
		get
		{
			return (double)GetValue(SaturationProperty);
		}
		set
		{
			SetValue(SaturationProperty, value);
		}
	}

	public ColorPickerTextInputMode TextInputMode
	{
		get
		{
			return (ColorPickerTextInputMode)GetValue(TextInputModeProperty);
		}
		set
		{
			SetValue(TextInputModeProperty, value);
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1721:PropertyNamesShouldNotMatchGetMethods")]
	public Color? Value
	{
		get
		{
			return (Color?)GetValue(ValueProperty);
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
			EventHandler eventHandler = i6R;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref i6R, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = i6R;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref i6R, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public ColorPicker()
	{
		awj.QuEwGz();
		base._002Ector();
		base.DefaultStyleKey = typeof(ColorPicker);
	}

	[SpecialName]
	private Int32EditBox n6l()
	{
		return I6G;
	}

	[SpecialName]
	private void L6X(Int32EditBox value)
	{
		I6G = value;
	}

	[SpecialName]
	private Int32EditBox p60()
	{
		return g6q;
	}

	[SpecialName]
	private void i6Y(Int32EditBox value)
	{
		g6q = value;
	}

	[SpecialName]
	private Int32EditBox m6o()
	{
		return h6u;
	}

	[SpecialName]
	private void u6O(Int32EditBox value)
	{
		h6u = value;
	}

	private static void yCN(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		ColorPicker colorPicker = (ColorPicker)P_0;
		Color value = colorPicker.Value ?? VdT.abb;
		try
		{
			value.A = Convert.ToByte(P_1.NewValue, CultureInfo.InvariantCulture);
			colorPicker.G62(value, Gde.A);
		}
		catch (OverflowException)
		{
		}
	}

	private static void hCU(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		ColorPicker colorPicker = (ColorPicker)P_0;
		Color value = colorPicker.Value ?? VdT.abb;
		try
		{
			value.B = Convert.ToByte(P_1.NewValue, CultureInfo.InvariantCulture);
			colorPicker.G62(value, Gde.B);
		}
		catch (OverflowException)
		{
		}
	}

	private static void MCz(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		ColorPicker colorPicker = (ColorPicker)P_0;
		UIColor uIColor = UIColor.FromColor(colorPicker.Value ?? VdT.abb);
		try
		{
			uIColor.HsbHue = colorPicker.Hue;
			uIColor.HsbSaturation = colorPicker.Saturation;
			uIColor.HsbBrightness = Convert.ToDouble(P_1.NewValue, CultureInfo.InvariantCulture);
			colorPicker.G62(uIColor.ToColor(), Gde.Brightness);
		}
		catch (OverflowException)
		{
		}
	}

	private static void g6Q(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		ColorPicker colorPicker = (ColorPicker)P_0;
		if (!colorPicker.IsAlphaEnabled && colorPicker.A < 255)
		{
			colorPicker.A = 255;
		}
	}

	private static void K6V(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		ColorPicker colorPicker = (ColorPicker)P_0;
		Color value = colorPicker.Value ?? VdT.abb;
		try
		{
			value.G = Convert.ToByte(P_1.NewValue, CultureInfo.InvariantCulture);
			colorPicker.G62(value, Gde.G);
		}
		catch (OverflowException)
		{
		}
	}

	private static void x6C(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		ColorPicker colorPicker = (ColorPicker)P_0;
		UIColor uIColor = UIColor.FromColor(colorPicker.Value ?? VdT.abb);
		try
		{
			uIColor.HsbHue = Convert.ToDouble(P_1.NewValue, CultureInfo.InvariantCulture);
			uIColor.HsbSaturation = colorPicker.Saturation;
			uIColor.HsbBrightness = colorPicker.Brightness;
			colorPicker.G62(uIColor.ToColor(), Gde.Hue);
		}
		catch (OverflowException)
		{
		}
	}

	private static void s66(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		ColorPicker colorPicker = (ColorPicker)P_0;
		Color value = colorPicker.Value ?? VdT.abb;
		try
		{
			value.R = Convert.ToByte(P_1.NewValue, CultureInfo.InvariantCulture);
			colorPicker.G62(value, Gde.R);
		}
		catch (OverflowException)
		{
		}
	}

	private static void u6M(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		ColorPicker colorPicker = (ColorPicker)P_0;
		UIColor uIColor = UIColor.FromColor(colorPicker.Value ?? VdT.abb);
		try
		{
			uIColor.HsbHue = colorPicker.Hue;
			uIColor.HsbSaturation = Convert.ToDouble(P_1.NewValue, CultureInfo.InvariantCulture);
			uIColor.HsbBrightness = colorPicker.Brightness;
			colorPicker.G62(uIColor.ToColor(), Gde.Saturation);
		}
		catch (OverflowException)
		{
		}
	}

	private static void h6s(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		ColorPicker colorPicker = (ColorPicker)P_0;
		colorPicker.y6a();
	}

	private static void E6j(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		ColorPicker colorPicker = (ColorPicker)P_0;
		Color? color = P_1.NewValue as Color?;
		colorPicker.G62(color, Gde.None);
		colorPicker.A6f(_0020: false);
		colorPicker.K6P();
	}

	private void K6P()
	{
		i6R?.Invoke(this, EventArgs.Empty);
	}

	private void G62(Color? P_0, Gde P_1)
	{
		if (Q6K)
		{
			return;
		}
		Q6K = true;
		try
		{
			if (Value != P_0)
			{
				Value = P_0;
			}
			if (P_0.HasValue)
			{
				A = P_0.Value.A;
				R = P_0.Value.R;
				G = P_0.Value.G;
				B = P_0.Value.B;
				if ((uint)(P_1 - 5) > 2u)
				{
					UIColor uIColor = UIColor.FromColor(P_0.Value);
					Hue = uIColor.HsbHue;
					Saturation = uIColor.HsbSaturation;
					Brightness = uIColor.HsbBrightness;
				}
			}
			else
			{
				A = 0;
				R = 0;
				G = 0;
				B = 0;
			}
		}
		finally
		{
			Q6K = false;
		}
	}

	private void y6a()
	{
		Q6K = true;
		try
		{
			bool flag = TextInputMode == ColorPickerTextInputMode.Rgb;
			bool flag2 = I6G != null;
			int num = 0;
			if (qk() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					if (h6u != null)
					{
						h6u.Inlines = (flag ? null : new PartEditBoxInlineCollection
						{
							new PartEditBoxInline
							{
								ContentTemplate = PercentInlineTemplate
							}
						});
						h6u.Maximum = (flag ? 255 : 100);
						h6u.SetBinding(PartEditBoxBase<int?>.ValueProperty, Ldu.EIz(this, flag ? QdM.AR8(2678) : QdM.AR8(2654), BindingMode.TwoWay, flag ? null : new OdW()));
					}
					A6f(_0020: true);
					return;
				default:
					if (flag2)
					{
						I6G.Inlines = (flag ? null : new PartEditBoxInlineCollection
						{
							new PartEditBoxInline
							{
								ContentTemplate = DegreeInlineTemplate
							}
						});
						I6G.Maximum = 360;
						I6G.SetBinding(PartEditBoxBase<int?>.ValueProperty, Ldu.EIz(this, flag ? QdM.AR8(2618) : QdM.AR8(2608), BindingMode.TwoWay, flag ? null : new uds()));
						I6G.Maximum = (flag ? 255 : 360);
					}
					if (g6q != null)
					{
						g6q.Inlines = (flag ? null : new PartEditBoxInlineCollection
						{
							new PartEditBoxInline
							{
								ContentTemplate = PercentInlineTemplate
							}
						});
						g6q.Maximum = (flag ? 255 : 100);
						g6q.SetBinding(PartEditBoxBase<int?>.ValueProperty, Ldu.EIz(this, flag ? QdM.AR8(2648) : QdM.AR8(2624), BindingMode.TwoWay, flag ? null : new OdW()));
						num = 0;
						if (qk() == null)
						{
							num = 1;
						}
						break;
					}
					goto case 1;
				}
			}
		}
		finally
		{
			Q6K = false;
		}
	}

	private void A6f(bool P_0)
	{
		ColorPickerTextInputMode textInputMode = TextInputMode;
		ColorPickerTextInputMode colorPickerTextInputMode = textInputMode;
		if (colorPickerTextInputMode == ColorPickerTextInputMode.Hsb)
		{
			double num = 0.75;
			if (P_0)
			{
				LinearGradientBrush linearGradientBrush = new LinearGradientBrush
				{
					EndPoint = new Point(1.0, 0.0)
				};
				double num2 = 36.0;
				for (double num3 = 0.0; num3 <= 360.0; num3 += num2)
				{
					Color color = UIColor.FromHsb(num3, num, 1.0).ToColor();
					linearGradientBrush.GradientStops.Add(new GradientStop
					{
						Offset = num3 / 360.0,
						Color = color
					});
				}
				Component1SwatchBrush = linearGradientBrush;
			}
			double hsbHue = UIColor.FromColor(Value ?? VdT.abb).HsbHue;
			LinearGradientBrush linearGradientBrush2 = new LinearGradientBrush
			{
				EndPoint = new Point(1.0, 0.0)
			};
			linearGradientBrush2.GradientStops.Add(new GradientStop
			{
				Offset = 0.03,
				Color = UIColor.FromHsb(hsbHue, 0.0, num).ToColor()
			});
			linearGradientBrush2.GradientStops.Add(new GradientStop
			{
				Offset = 0.97,
				Color = UIColor.FromHsb(hsbHue, 1.0, num).ToColor()
			});
			Component2SwatchBrush = linearGradientBrush2;
			LinearGradientBrush linearGradientBrush3 = new LinearGradientBrush
			{
				EndPoint = new Point(1.0, 0.0)
			};
			linearGradientBrush3.GradientStops.Add(new GradientStop
			{
				Offset = 0.03,
				Color = Colors.Black
			});
			linearGradientBrush3.GradientStops.Add(new GradientStop
			{
				Offset = 0.5,
				Color = UIColor.FromHsb(hsbHue, 1.0, 1.0).ToColor()
			});
			linearGradientBrush3.GradientStops.Add(new GradientStop
			{
				Offset = 0.97,
				Color = Colors.White
			});
			Component3SwatchBrush = linearGradientBrush3;
		}
		else if (P_0)
		{
			Component1SwatchBrush = Brushes.Red;
			Component2SwatchBrush = Brushes.Lime;
			Component3SwatchBrush = Brushes.Blue;
		}
	}

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		L6X(GetTemplateChild(QdM.AR8(2684)) as Int32EditBox);
		i6Y(GetTemplateChild(QdM.AR8(2732)) as Int32EditBox);
		u6O(GetTemplateChild(QdM.AR8(2780)) as Int32EditBox);
		y6a();
	}

	static ColorPicker()
	{
		awj.QuEwGz();
		AProperty = DependencyProperty.Register(QdM.AR8(2828), typeof(int), typeof(ColorPicker), new PropertyMetadata(255, yCN));
		BProperty = DependencyProperty.Register(QdM.AR8(2678), typeof(int), typeof(ColorPicker), new PropertyMetadata(0, hCU));
		BrightnessProperty = DependencyProperty.Register(QdM.AR8(2654), typeof(double), typeof(ColorPicker), new PropertyMetadata(1.0, MCz));
		ComparisonValueProperty = DependencyProperty.Register(QdM.AR8(2834), typeof(Color), typeof(ColorPicker), new PropertyMetadata(VdT.abb));
		Component1SwatchBrushProperty = DependencyProperty.Register(QdM.AR8(2868), typeof(Brush), typeof(ColorPicker), new PropertyMetadata(null));
		Component2SwatchBrushProperty = DependencyProperty.Register(QdM.AR8(2914), typeof(Brush), typeof(ColorPicker), new PropertyMetadata(null));
		Component3SwatchBrushProperty = DependencyProperty.Register(QdM.AR8(2960), typeof(Brush), typeof(ColorPicker), new PropertyMetadata(null));
		DegreeInlineTemplateProperty = DependencyProperty.Register(QdM.AR8(3006), typeof(DataTemplate), typeof(ColorPicker), new PropertyMetadata(null));
		GProperty = DependencyProperty.Register(QdM.AR8(2648), typeof(int), typeof(ColorPicker), new PropertyMetadata(0, K6V));
		int num = 0;
		if (1 == 0)
		{
			goto IL_0005;
		}
		goto IL_0009;
		IL_0005:
		int num2;
		num = num2;
		goto IL_0009;
		IL_0009:
		do
		{
			switch (num)
			{
			case 1:
				HueProperty = DependencyProperty.Register(QdM.AR8(2608), typeof(double), typeof(ColorPicker), new PropertyMetadata(0.0, x6C));
				IsAlphaEnabledProperty = DependencyProperty.Register(QdM.AR8(1288), typeof(bool), typeof(ColorPicker), new PropertyMetadata(true, g6Q));
				IsComparisonValueVisibleProperty = DependencyProperty.Register(QdM.AR8(3084), typeof(bool), typeof(ColorPicker), new PropertyMetadata(false));
				IsEditableProperty = DependencyProperty.Register(QdM.AR8(3136), typeof(bool), typeof(ColorPicker), new PropertyMetadata(true));
				PercentInlineTemplateProperty = DependencyProperty.Register(QdM.AR8(3160), typeof(DataTemplate), typeof(ColorPicker), new PropertyMetadata(null));
				RProperty = DependencyProperty.Register(QdM.AR8(2618), typeof(int), typeof(ColorPicker), new PropertyMetadata(255, s66));
				SaturationProperty = DependencyProperty.Register(QdM.AR8(2624), typeof(double), typeof(ColorPicker), new PropertyMetadata(1.0, u6M));
				TextInputModeProperty = DependencyProperty.Register(QdM.AR8(3206), typeof(ColorPickerTextInputMode), typeof(ColorPicker), new PropertyMetadata(ColorPickerTextInputMode.Rgb, h6s));
				ValueProperty = DependencyProperty.Register(QdM.AR8(1828), typeof(Color?), typeof(ColorPicker), new PropertyMetadata(VdT.abb, E6j));
				return;
			}
			HasColorEditBoxProperty = DependencyProperty.Register(QdM.AR8(3050), typeof(bool), typeof(ColorPicker), new PropertyMetadata(true));
			num = 1;
		}
		while (true);
		goto IL_0005;
	}

	internal static bool wT()
	{
		return fM == null;
	}

	internal static ColorPicker qk()
	{
		return fM;
	}
}
