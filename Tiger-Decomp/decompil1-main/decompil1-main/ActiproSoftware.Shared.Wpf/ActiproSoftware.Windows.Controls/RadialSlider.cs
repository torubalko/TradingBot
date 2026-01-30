using System;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;
using ActiproSoftware.Compatibility;
using ActiproSoftware.Windows.Controls.Automation.Peers;
using ActiproSoftware.Windows.Controls.Primitives;
using ActiproSoftware.Windows.Extensions;
using ActiproSoftware.Windows.Input;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Controls;

[TemplatePart(Name = "PART_Thumb", Type = typeof(CircularThumb))]
public class RadialSlider : RangeBase
{
	private enum Hs
	{

	}

	private InputAdapter nCv;

	private bool ECX;

	private CircularThumb thumb;

	private InputAdapter BCT;

	public static readonly DependencyProperty IntermediateValueProperty;

	public static readonly DependencyProperty RadiusProperty;

	public static readonly DependencyProperty ThumbArrowAngleProperty;

	public static readonly DependencyProperty ThumbBackgroundProperty;

	public static readonly DependencyProperty ThumbPressedBackgroundProperty;

	public static readonly DependencyProperty ThumbStyleProperty;

	private static RadialSlider JGI;

	public double IntermediateValue
	{
		get
		{
			return (double)GetValue(IntermediateValueProperty);
		}
		set
		{
			SetValue(IntermediateValueProperty, value);
		}
	}

	public double Radius
	{
		get
		{
			return (double)GetValue(RadiusProperty);
		}
		set
		{
			SetValue(RadiusProperty, value);
		}
	}

	public double ThumbArrowAngle
	{
		get
		{
			return (double)GetValue(ThumbArrowAngleProperty);
		}
		set
		{
			SetValue(ThumbArrowAngleProperty, value);
		}
	}

	public Brush ThumbBackground
	{
		get
		{
			return (Brush)GetValue(ThumbBackgroundProperty);
		}
		set
		{
			SetValue(ThumbBackgroundProperty, value);
		}
	}

	public Brush ThumbPressedBackground
	{
		get
		{
			return (Brush)GetValue(ThumbPressedBackgroundProperty);
		}
		set
		{
			SetValue(ThumbPressedBackgroundProperty, value);
		}
	}

	public Style ThumbStyle
	{
		get
		{
			return (Style)GetValue(ThumbStyleProperty);
		}
		set
		{
			SetValue(ThumbStyleProperty, value);
		}
	}

	public RadialSlider()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		ECX = true;
		base._002Ector();
		base.DefaultStyleKey = typeof(RadialSlider);
		zAE();
	}

	private void zAE()
	{
		nCv = new InputAdapter(this);
		nCv.PointerWheelChanged += LAL;
		nCv.AttachedEventKinds = InputAdapterEventKinds.PointerWheelChanged;
	}

	[SpecialName]
	private bool qA1()
	{
		return base.Minimum == 0.0 && base.Maximum == 360.0;
	}

	private static void zAs(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		RadialSlider radialSlider = (RadialSlider)P_0;
		radialSlider.rAG();
	}

	private void LAL(object P_0, InputPointerWheelEventArgs P_1)
	{
		if (!P_1.Handled)
		{
			int delta = P_1.Delta;
			int singleUnitDelta = P_1.SingleUnitDelta;
			int num = ((delta > 0) ? Math.Max(singleUnitDelta, delta) : Math.Min(-singleUnitDelta, delta)) / singleUnitDelta;
			int num2 = 0;
			if (!cGD())
			{
				int num3 = default(int);
				num2 = num3;
			}
			switch (num2)
			{
			}
			oAD(base.Value + (double)num * base.LargeChange, (Hs)3);
			P_1.Handled = true;
		}
	}

	private static void rAd(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		RadialSlider radialSlider = (RadialSlider)P_0;
		radialSlider.WAP();
	}

	private void zAN(object P_0, InputKeyEventArgs P_1)
	{
		if (P_1 == null || P_1.Handled)
		{
			return;
		}
		ModifierKeys modifierKeys = CompatibilityHelper.ModifierKeys;
		ModifierKeys modifierKeys2 = modifierKeys;
		if (modifierKeys2 == ModifierKeys.None || modifierKeys2 == ModifierKeys.Shift)
		{
			switch (P_1.Key)
			{
			case Key.Up:
			case Key.Right:
			case Key.Add:
			case Key.OemPlus:
				oAD(base.Value + base.SmallChange, (Hs)0);
				P_1.Handled = true;
				break;
			case Key.Left:
			case Key.Down:
			case Key.Subtract:
			case Key.OemMinus:
				oAD(base.Value - base.SmallChange, (Hs)0);
				P_1.Handled = true;
				break;
			case Key.End:
				oAD(base.Maximum, (Hs)0);
				P_1.Handled = true;
				break;
			case Key.Home:
				oAD(base.Minimum, (Hs)0);
				P_1.Handled = true;
				break;
			case Key.Next:
				oAD(base.Value - base.LargeChange, (Hs)0);
				P_1.Handled = true;
				break;
			case Key.Prior:
				oAD(base.Value + base.LargeChange, (Hs)0);
				P_1.Handled = true;
				break;
			}
		}
	}

	private void mAM(object P_0, InputPointerEventArgs P_1)
	{
		fAK(P_1);
	}

	private void fAK(InputPointerEventArgs P_0)
	{
		if (P_0 != null && thumb != null && thumb.IsDragging)
		{
			Point position = P_0.GetPosition(this);
			Size currentSize = this.GetCurrentSize();
			Point centerPosition = new Point(currentSize.Height / 2.0, currentSize.Width / 2.0);
			double normalizedDegreeAngle = base.Value.GetNormalizedDegreeAngle();
			double normalizedDegreeAngle2 = centerPosition.GetDegreeAngle(position).GetNormalizedDegreeAngle();
			double num = ((normalizedDegreeAngle >= 270.0 && normalizedDegreeAngle2 <= 90.0) ? ((Math.Floor(base.Value / 360.0) + 1.0) * 360.0 + normalizedDegreeAngle2) : ((!(normalizedDegreeAngle <= 90.0) || !(normalizedDegreeAngle2 >= 270.0)) ? (base.Value + (normalizedDegreeAngle2 - normalizedDegreeAngle)) : ((Math.Floor(base.Value / 360.0) - 1.0) * 360.0 + normalizedDegreeAngle2)));
			oAD(num, (Hs)1);
		}
	}

	private void PAg(object P_0, InputPointerEventArgs P_1)
	{
		oAD(base.Value, (Hs)2);
	}

	[SpecialName]
	private double vCc()
	{
		return Math.Max(0.0, Radius);
	}

	private void cA8(double P_0, bool P_1, bool P_2)
	{
		if (P_1)
		{
			if (P_2)
			{
				this.AnimateDoubleProperty(IntermediateValueProperty, 360.0, 0.2, 0.0, 0.0);
				int num = 0;
				if (!cGD())
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
			else
			{
				this.AnimateDoubleProperty(IntermediateValueProperty, P_0);
			}
		}
		else
		{
			IntermediateValue = P_0;
		}
	}

	private void oAD(double P_0, Hs P_1)
	{
		if (qA1())
		{
			P_0 = P_0.GetNormalizedDegreeAngle();
		}
		else if (double.IsNaN(P_0))
		{
			P_0 = 0.0;
		}
		else if (double.IsNegativeInfinity(P_0))
		{
			P_0 = base.Minimum;
		}
		else if (double.IsPositiveInfinity(P_0))
		{
			P_0 = base.Maximum;
		}
		double num = Math.Max(0.01, base.SmallChange);
		double num2 = Math.Round((P_0 - base.Minimum) / num);
		double num3 = base.Minimum + num2 * num;
		double num4 = base.Minimum + (num2 + (double)((P_0 >= 0.0) ? 1 : (-1))) * num;
		if (num3 == num4)
		{
			num2 = Math.Round((P_0 - base.Value) / num);
			num3 = base.Value + num2 * num;
			num4 = base.Value + (num2 + (double)((P_0 >= 0.0) ? 1 : (-1))) * num;
		}
		double num5 = P_0;
		if (Math.Abs(num4 - P_0) <= Math.Abs(num3 - P_0))
		{
			num5 = num4;
			if (num5 >= 360.0 && qA1())
			{
				num5 = 0.0;
			}
		}
		else
		{
			num5 = num3;
		}
		P_0 = Math.Max(base.Minimum, Math.Min(base.Maximum, P_0));
		num5 = Math.Max(base.Minimum, Math.Min(base.Maximum, num5));
		switch (P_1)
		{
		case (Hs)1:
			cA8(P_0, _0020: false, _0020: false);
			ECX = false;
			break;
		case (Hs)2:
		{
			bool flag = qA1() && num5 == 0.0 && IntermediateValue > 180.0;
			cA8(P_0, _0020: true, flag);
			ECX = false;
			break;
		}
		}
		base.Value = num5;
		ECX = true;
	}

	private void WAP()
	{
		double num = ((thumb != null) ? thumb.GetCurrentSize().Height : 0.0);
		double height = (base.Width = 2.0 * vCc() + num);
		base.Height = height;
	}

	private void rAG()
	{
		if (thumb == null)
		{
			return;
		}
		RotateTransform rotateTransform = thumb.RenderTransform as RotateTransform;
		if (rotateTransform == null)
		{
			rotateTransform = new RotateTransform();
			thumb.RenderTransform = rotateTransform;
			int num = 0;
			if (!cGD())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
		double num3 = this.GetCurrentSize().Height / 2.0;
		if (rotateTransform.CenterY != num3)
		{
			rotateTransform.CenterY = num3;
		}
		if (thumb.RenderTransformOrigin != new Point(0.5, 0.0))
		{
			thumb.RenderTransformOrigin = new Point(0.5, 0.0);
		}
		rotateTransform.Angle = IntermediateValue.GetNormalizedDegreeAngle();
	}

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		if (BCT != null)
		{
			BCT.AttachedEventKinds = InputAdapterEventKinds.None;
			BCT.KeyDown -= zAN;
			BCT.PointerCaptureLost -= PAg;
			BCT.PointerMoved -= mAM;
			BCT.PointerReleased -= PAg;
			BCT = null;
		}
		thumb = GetTemplateChild(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(115664)) as CircularThumb;
		if (thumb != null)
		{
			BCT = new InputAdapter(thumb);
			BCT.KeyDown += zAN;
			BCT.PointerCaptureLost += PAg;
			BCT.PointerMoved += mAM;
			int num = 1;
			if (gG2() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					BCT.PointerReleased += PAg;
					BCT.AttachedEventKinds = InputAdapterEventKinds.PointerCaptureLost | InputAdapterEventKinds.PointerMoved | InputAdapterEventKinds.PointerReleased | InputAdapterEventKinds.KeyDown;
					num = 0;
					if (gG2() != null)
					{
						num = 0;
					}
					continue;
				}
				break;
			}
		}
		WAP();
		rAG();
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		return new RadialSliderAutomationPeer(this);
	}

	protected override void OnValueChanged(double oldValue, double newValue)
	{
		if (ECX)
		{
			cA8(newValue, _0020: false, _0020: false);
		}
		base.OnValueChanged(oldValue, newValue);
	}

	protected void SetValueCore(double value)
	{
		oAD(value, (Hs)4);
	}

	public void StartDrag(InputPointerButtonEventArgs sourceEventArgs)
	{
		if (sourceEventArgs != null && thumb != null)
		{
			thumb.StartDrag(sourceEventArgs);
			fAK(sourceEventArgs);
		}
	}

	static RadialSlider()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		IntermediateValueProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(115688), typeof(double), typeof(RadialSlider), new PropertyMetadata(0.0, zAs));
		RadiusProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(115726), typeof(double), typeof(RadialSlider), new PropertyMetadata(100.0, rAd));
		ThumbArrowAngleProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(115742), typeof(double), typeof(RadialSlider), new PropertyMetadata(180.0));
		ThumbBackgroundProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(115776), typeof(Brush), typeof(RadialSlider), new PropertyMetadata(null));
		ThumbPressedBackgroundProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(115810), typeof(Brush), typeof(RadialSlider), new PropertyMetadata(null));
		ThumbStyleProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(115858), typeof(Style), typeof(RadialSlider), new PropertyMetadata(null));
	}

	internal static bool cGD()
	{
		return JGI == null;
	}

	internal static RadialSlider gG2()
	{
		return JGI;
	}
}
