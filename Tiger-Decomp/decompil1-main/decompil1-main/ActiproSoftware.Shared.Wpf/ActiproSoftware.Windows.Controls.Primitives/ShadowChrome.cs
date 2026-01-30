using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Effects;
using System.Windows.Shapes;
using ActiproSoftware.Windows.Data;
using ActiproSoftware.Windows.Themes;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Controls.Primitives;

[ContentProperty("Child")]
public class ShadowChrome : FrameworkElement
{
	private enum TF
	{
		None,
		Default
	}

	private TF prG;

	private UIElementCollection Dr1;

	public static readonly DependencyProperty DirectionProperty;

	public static readonly DependencyProperty ElevationProperty;

	public static readonly DependencyProperty IsShadowEnabledProperty;

	public static readonly DependencyProperty RenderModeProperty;

	public static readonly DependencyProperty ShadowOpacityProperty;

	public static readonly DependencyProperty ShadowThicknessProperty;

	public const double DirectionDown = 270.0;

	public const double DirectionDownRight = 315.0;

	internal const int ElevationPopup = 8;

	internal const int ElevationToolTip = 4;

	private static ShadowChrome kbR;

	public UIElement Child
	{
		get
		{
			int? num = Dr1?.Count;
			int? num2 = num;
			if (num2.HasValue)
			{
				int valueOrDefault = num2.GetValueOrDefault();
				if (valueOrDefault == 1)
				{
					return Dr1[0];
				}
				int num3 = 0;
				if (!gb9())
				{
					int num4 = default(int);
					num3 = num4;
				}
				switch (num3)
				{
				}
				if (valueOrDefault == 3)
				{
					return Dr1[2];
				}
			}
			return null;
		}
		set
		{
			if (Child != value)
			{
				OrI();
				XrV(value);
				GrR();
			}
		}
	}

	public double Direction
	{
		get
		{
			return (double)GetValue(DirectionProperty);
		}
		set
		{
			SetValue(DirectionProperty, value);
		}
	}

	public int Elevation
	{
		get
		{
			return (int)GetValue(ElevationProperty);
		}
		set
		{
			SetValue(ElevationProperty, value);
		}
	}

	public bool IsShadowEnabled
	{
		get
		{
			return (bool)GetValue(IsShadowEnabledProperty);
		}
		set
		{
			SetValue(IsShadowEnabledProperty, value);
		}
	}

	protected override IEnumerator LogicalChildren => srE().GetEnumerator();

	public ShadowChromeRenderMode RenderMode
	{
		get
		{
			return (ShadowChromeRenderMode)GetValue(RenderModeProperty);
		}
		set
		{
			SetValue(RenderModeProperty, value);
		}
	}

	public double ShadowOpacity
	{
		get
		{
			return (double)GetValue(ShadowOpacityProperty);
		}
		set
		{
			SetValue(ShadowOpacityProperty, value);
		}
	}

	public Thickness ShadowThickness
	{
		get
		{
			return (Thickness)GetValue(ShadowThicknessProperty);
		}
		private set
		{
			SetValue(ShadowThicknessProperty, value);
		}
	}

	protected override int VisualChildrenCount => Dr1?.Count ?? 0;

	private void OrI()
	{
	}

	private GradientStopCollection Rrx(Color P_0, double P_1 = 0.0)
	{
		GradientStopCollection gradientStopCollection = new GradientStopCollection();
		double num = 1.0 - P_1;
		double num2 = (double)(int)P_0.A / 255.0;
		int num3 = 0;
		if (!gb9())
		{
			goto IL_0005;
		}
		goto IL_0009;
		IL_0005:
		int num4 = default(int);
		num3 = num4;
		goto IL_0009;
		IL_0009:
		do
		{
			switch (num3)
			{
			case 1:
				return gradientStopCollection;
			}
			P_0.A = (byte)(num2 * 1.0 * 255.0);
			gradientStopCollection.Add(new GradientStop(P_0, P_1 + num * 0.0));
			P_0.A = (byte)(num2 * 0.95 * 255.0);
			gradientStopCollection.Add(new GradientStop(P_0, P_1 + num * 0.1));
			P_0.A = (byte)(num2 * 0.76 * 255.0);
			gradientStopCollection.Add(new GradientStop(P_0, P_1 + num * 0.2));
			P_0.A = (byte)(num2 * 0.52 * 255.0);
			gradientStopCollection.Add(new GradientStop(P_0, P_1 + num * 0.3));
			P_0.A = (byte)(num2 * 0.33 * 255.0);
			gradientStopCollection.Add(new GradientStop(P_0, P_1 + num * 0.4));
			P_0.A = (byte)(num2 * 0.25 * 255.0);
			gradientStopCollection.Add(new GradientStop(P_0, P_1 + num * 0.5));
			P_0.A = (byte)(num2 * 0.18 * 255.0);
			gradientStopCollection.Add(new GradientStop(P_0, P_1 + num * 0.6));
			P_0.A = 0;
			gradientStopCollection.Add(new GradientStop(P_0, P_1 + num * 1.0));
			gradientStopCollection.Freeze();
			num3 = 1;
		}
		while (gb9());
		goto IL_0005;
	}

	private void wrr(DrawingContext P_0, Sides P_1, Color P_2, double P_3, double P_4, double P_5, double P_6)
	{
		if (!(P_5 <= 0.0) && !(P_6 <= 0.0))
		{
			Point startPoint;
			Point endPoint;
			switch (P_1)
			{
			case Sides.Left:
				startPoint = new Point(1.0, 0.0);
				endPoint = new Point(0.0, 0.0);
				break;
			case Sides.Top:
				startPoint = new Point(0.0, 1.0);
				endPoint = new Point(0.0, 0.0);
				break;
			case Sides.Right:
				startPoint = new Point(0.0, 0.0);
				endPoint = new Point(1.0, 0.0);
				break;
			default:
				startPoint = new Point(0.0, 0.0);
				endPoint = new Point(0.0, 1.0);
				break;
			}
			LinearGradientBrush linearGradientBrush = new LinearGradientBrush(Rrx(P_2), startPoint, endPoint);
			linearGradientBrush.Freeze();
			P_0.DrawRectangle(linearGradientBrush, null, new Rect(P_3, P_4, P_5, P_6));
		}
	}

	private void GrZ(DrawingContext P_0, Corner P_1, double P_2, Color P_3, double P_4, double P_5, double P_6, double P_7, double P_8)
	{
		if (P_6 <= 0.0 || P_7 <= 0.0)
		{
			return;
		}
		RadialGradientBrush radialGradientBrush = new RadialGradientBrush(Rrx(P_3, P_2));
		switch (P_1)
		{
		case Corner.TopRight:
			radialGradientBrush.Center = new Point(0.0, 1.0);
			radialGradientBrush.GradientOrigin = new Point(0.0, 1.0 + P_8);
			goto case (Corner)3;
		case Corner.TopLeft:
			radialGradientBrush.Center = new Point(1.0, 1.0);
			radialGradientBrush.GradientOrigin = new Point(1.0, 1.0 + P_8);
			goto case (Corner)3;
		default:
			if (P_1 == Corner.BottomLeft)
			{
				radialGradientBrush.Center = new Point(1.0, 0.0);
				radialGradientBrush.GradientOrigin = new Point(1.0, 0.0 - P_8);
			}
			goto case (Corner)3;
		case Corner.BottomRight:
			radialGradientBrush.Center = new Point(0.0, 0.0);
			radialGradientBrush.GradientOrigin = new Point(0.0, 0.0 - P_8);
			goto case (Corner)3;
		case (Corner)3:
		{
			radialGradientBrush.RadiusX = 1.0;
			int num = 2;
			int num2 = default(int);
			while (true)
			{
				switch (num)
				{
				case 1:
					radialGradientBrush.Freeze();
					P_0.DrawRectangle(radialGradientBrush, null, new Rect(P_4, P_5, P_6, P_7));
					return;
				case 2:
					radialGradientBrush.RadiusY = 1.0;
					num = 1;
					if (!gb9())
					{
						num = num2;
					}
					continue;
				}
				break;
			}
			goto default;
		}
		}
	}

	private static double urn(double P_0)
	{
		return Math.PI * P_0 / 180.0;
	}

	private static double GetCornerRadius(UIElement child)
	{
		if (child != null)
		{
			if (!(child is Border { CornerRadius: { BottomLeft: var bottomLeft } }))
			{
				if (child is AdornerDecorator adornerDecorator)
				{
					return GetCornerRadius(adornerDecorator.Child);
				}
				return ThemeProperties.GetCornerRadius(child).BottomLeft;
			}
			return bottomLeft;
		}
		return 0.0;
	}

	private void Lra(UIElement P_0)
	{
		if (prG == (TF)2)
		{
			Rectangle element = new Rectangle
			{
				IsHitTestVisible = false
			};
			Rectangle element2 = new Rectangle
			{
				IsHitTestVisible = false
			};
			srE().Add(element);
			srE().Add(element2);
		}
		srE().Add(P_0);
	}

	[SpecialName]
	private UIElementCollection srE()
	{
		if (Dr1 == null)
		{
			Dr1 = new UIElementCollection(this, this);
		}
		return Dr1;
	}

	[SpecialName]
	private Rectangle WrL()
	{
		UIElementCollection dr = Dr1;
		return (dr != null && dr.Count >= 3) ? (Dr1[1] as Rectangle) : null;
	}

	private static void zrq(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		ShadowChrome shadowChrome = (ShadowChrome)P_0;
		TF tF = shadowChrome.prG;
		TF tF2 = tF;
		if (tF2 != TF.Default)
		{
			int num;
			double direction = default(double);
			DropShadowEffect dropShadowEffect = default(DropShadowEffect);
			if (tF2 != (TF)2)
			{
				num = 0;
				if (Obc() == null)
				{
					num = 0;
				}
			}
			else
			{
				direction = shadowChrome.urN();
				dropShadowEffect = shadowChrome.cr8()?.Effect as DropShadowEffect;
				num = 1;
				if (Obc() != null)
				{
					int num2 = default(int);
					num = num2;
				}
			}
			switch (num)
			{
			case 1:
				if (dropShadowEffect != null)
				{
					dropShadowEffect.Direction = direction;
				}
				if (shadowChrome.WrL()?.Effect is DropShadowEffect dropShadowEffect2)
				{
					dropShadowEffect2.Direction = direction;
				}
				break;
			}
		}
		else
		{
			shadowChrome.InvalidateVisual();
		}
		shadowChrome.GrR();
	}

	private static void SrW(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		ShadowChrome shadowChrome = (ShadowChrome)P_0;
		shadowChrome.zr5(_0020: true);
		shadowChrome.GrR();
	}

	private static void orU(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		ShadowChrome shadowChrome = (ShadowChrome)P_0;
		shadowChrome.zr5(_0020: true);
		shadowChrome.GrR();
	}

	private static void ErH(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		ShadowChrome shadowChrome = (ShadowChrome)P_0;
		switch (shadowChrome.RenderMode)
		{
		case ShadowChromeRenderMode.ShaderEffectsPreferred:
			shadowChrome.prG = ((!ThemeManager.IsGraphicsHardwareAccelerationSupported) ? TF.Default : ((TF)2));
			break;
		case ShadowChromeRenderMode.ShaderEffectsRequired:
			shadowChrome.prG = (ThemeManager.IsGraphicsHardwareAccelerationSupported ? ((TF)2) : TF.None);
			break;
		default:
			shadowChrome.prG = TF.Default;
			break;
		}
		shadowChrome.InvalidateVisual();
		UIElement child = shadowChrome.Child;
		if (child != null)
		{
			shadowChrome.XrV(child);
		}
	}

	private static void Kr6(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		ShadowChrome shadowChrome = (ShadowChrome)P_0;
		shadowChrome.zr5(_0020: true);
	}

	private void XrV(UIElement P_0)
	{
		zr5(_0020: false);
		Dr1?.Clear();
		if (P_0 != null)
		{
			Lra(P_0);
			zr5(_0020: true);
		}
	}

	[SpecialName]
	private double urN()
	{
		return Direction;
	}

	[SpecialName]
	private int xrK()
	{
		return IsShadowEnabled ? Math.Max(0, Math.Min(24, Elevation)) : 0;
	}

	private void zr5(bool P_0)
	{
		switch (prG)
		{
		case (TF)2:
		{
			Rectangle rectangle = cr8();
			if (rectangle == null)
			{
				break;
			}
			Rectangle rectangle2 = WrL();
			UIElement child = Child;
			int num = xrK();
			bool flag = rectangle.Effect != null;
			bool flag2 = P_0 && num > 0;
			if (flag != flag2)
			{
				if (flag)
				{
					rectangle.Effect = null;
					rectangle.Fill = null;
					rectangle2.Effect = null;
					rectangle2.Fill = null;
				}
				if (flag2)
				{
					VisualBrush fill = (VisualBrush)(rectangle.Fill = new VisualBrush(child)
					{
						AlignmentX = AlignmentX.Left,
						AlignmentY = AlignmentY.Top,
						Stretch = Stretch.None,
						TileMode = TileMode.None,
						ViewboxUnits = BrushMappingMode.Absolute
					});
					rectangle2.Fill = fill;
					double direction = urN();
					rectangle.Effect = new DropShadowEffect
					{
						Direction = direction,
						RenderingBias = RenderingBias.Performance,
						Color = Colors.Black
					};
					rectangle2.Effect = new DropShadowEffect
					{
						Direction = direction,
						RenderingBias = RenderingBias.Performance,
						Color = Colors.Black
					};
				}
			}
			if (flag2)
			{
				DropShadowEffect dropShadowEffect = (DropShadowEffect)rectangle.Effect;
				DropShadowEffect dropShadowEffect2 = (DropShadowEffect)rectangle2.Effect;
				if (dropShadowEffect != null)
				{
					dropShadowEffect.ShadowDepth = num;
					dropShadowEffect.BlurRadius = (double)num * 1.9;
					dropShadowEffect.Opacity = Math.Max(0.0, Math.Min(1.0, 0.5 * ShadowOpacity));
				}
				if (dropShadowEffect2 != null)
				{
					dropShadowEffect2.ShadowDepth = Math.Round((double)num / 2.0, MidpointRounding.AwayFromZero);
					dropShadowEffect2.BlurRadius = Math.Round((double)num / 1.5, MidpointRounding.AwayFromZero);
					dropShadowEffect2.Opacity = Math.Max(0.0, Math.Min(1.0, 0.625 * ShadowOpacity));
				}
			}
			break;
		}
		case TF.Default:
			InvalidateVisual();
			break;
		}
	}

	private void GrR()
	{
		double direction = urN();
		int elevation = xrK();
		ShadowThickness = GetShadowThickness(direction, elevation);
	}

	[SpecialName]
	private Rectangle cr8()
	{
		UIElementCollection dr = Dr1;
		return (dr != null && dr.Count >= 3) ? (Dr1[0] as Rectangle) : null;
	}

	protected override Size ArrangeOverride(Size finalSize)
	{
		if (Dr1 != null)
		{
			foreach (UIElement item in Dr1)
			{
				item.Arrange(new Rect(finalSize));
			}
		}
		return finalSize;
	}

	public static Thickness GetShadowThickness(double direction, int elevation)
	{
		double num = 1.0;
		Thickness thickness = new Thickness(Math.Sin(urn(direction + 270.0)), Math.Sin(urn(direction)), Math.Sin(urn(direction + 90.0)), Math.Sin(urn(direction + 180.0)));
		return new Thickness(Math.Round((double)elevation * (num + thickness.Left), MidpointRounding.AwayFromZero), Math.Round((double)elevation * (num + thickness.Top), MidpointRounding.AwayFromZero), Math.Round((double)elevation * (num + thickness.Right), MidpointRounding.AwayFromZero), Math.Round((double)elevation * (num + thickness.Bottom), MidpointRounding.AwayFromZero));
	}

	protected override Visual GetVisualChild(int index)
	{
		if (Dr1 == null)
		{
			throw new ArgumentOutOfRangeException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(196));
		}
		return Dr1[index];
	}

	protected override HitTestResult HitTestCore(PointHitTestParameters hitTestParameters)
	{
		if (!new Rect(0.0, 0.0, base.ActualWidth, base.ActualHeight).Contains(hitTestParameters.HitPoint))
		{
			return null;
		}
		return base.HitTestCore(hitTestParameters);
	}

	protected override Size MeasureOverride(Size availableSize)
	{
		Size result = default(Size);
		if (Dr1 != null)
		{
			foreach (UIElement item in Dr1)
			{
				item.Measure(availableSize);
				result = item.DesiredSize;
			}
		}
		return result;
	}

	protected override void OnRender(DrawingContext drawingContext)
	{
		if (prG == TF.Default && xrK() > 0)
		{
			UIElement child = Child;
			if (child != null)
			{
				Rect rect;
				if (child is FrameworkElement frameworkElement)
				{
					rect = new Rect(0.0, 0.0, frameworkElement.ActualWidth, frameworkElement.ActualHeight);
					rect = frameworkElement.TransformToAncestor(this).TransformBounds(rect);
				}
				else
				{
					rect = new Rect(0.0, 0.0, base.ActualWidth, base.ActualHeight);
				}
				Thickness shadowThickness = ShadowThickness;
				Rect rect2 = new Rect(0.0 - shadowThickness.Left + rect.Left, 0.0 - shadowThickness.Top + rect.Top, Math.Max(0.0, shadowThickness.Left + rect.Width + shadowThickness.Right), Math.Max(0.0, shadowThickness.Top + rect.Height + shadowThickness.Bottom));
				Color color = Color.FromArgb((byte)(Math.Max(0.0, Math.Min(1.0, ShadowOpacity)) * 255.0), 0, 0, 0);
				double num = Math.Max(shadowThickness.Left, Math.Max(shadowThickness.Top, Math.Max(shadowThickness.Right, shadowThickness.Bottom)));
				double num2 = num;
				double num3 = rect2.Left + rect2.Width / 2.0;
				double num4 = rect2.Top + rect2.Height / 2.0;
				double num5 = Math.Floor(GetCornerRadius(child));
				if (rect2.Left + num + num5 >= num3 || rect2.Top + num2 + num5 >= num4)
				{
					num5 = 0.0;
				}
				double num6 = Math.Min(num3, rect2.Left + num);
				double num7 = Math.Max(num3, rect2.Right - num);
				double num8 = Math.Min(num4, rect2.Top + num2);
				double num9 = Math.Max(num4, rect2.Bottom - num2);
				double num10 = Math.Min(num3, num6 + num5);
				double num11 = Math.Max(num3, num7 - num5);
				double num12 = Math.Min(num4, num8 + num5);
				double num13 = Math.Max(num4, num9 - num5);
				bool flag = urN() == 270.0;
				if (flag)
				{
					num *= 0.66;
					num6 = Math.Min(num3, rect2.Left + num);
					num7 = Math.Max(num3, rect2.Right - num);
					num10 = Math.Min(num3, num6 + num5);
					num11 = Math.Max(num3, num7 - num5);
				}
				double[] guidelinesX = new double[6] { rect2.Left, num6, num10, num11, num7, rect2.Right };
				double[] guidelinesY = new double[6] { rect2.Top, num8, num12, num13, num9, rect2.Bottom };
				drawingContext.PushGuidelineSet(new GuidelineSet(guidelinesX, guidelinesY));
				if (num6 < num7 && num8 < num9)
				{
					SolidColorBrush solidColorBrush = new SolidColorBrush(color);
					solidColorBrush.Freeze();
					if (num10 < num11 && num12 < num13)
					{
						drawingContext.DrawRectangle(solidColorBrush, null, new Rect(num10, num8, num11 - num10, num12 - num8));
						drawingContext.DrawRectangle(solidColorBrush, null, new Rect(num6, num12, num7 - num6, num13 - num12));
						drawingContext.DrawRectangle(solidColorBrush, null, new Rect(num10, num13, num11 - num10, num9 - num13));
					}
					else if (num10 < num11)
					{
						drawingContext.DrawRectangle(solidColorBrush, null, new Rect(num10, num8, num11 - num10, num9 - num8));
					}
					else
					{
						drawingContext.DrawRectangle(solidColorBrush, null, new Rect(num6, num12, num7 - num6, num13 - num12));
					}
				}
				if (num12 < num13)
				{
					wrr(drawingContext, Sides.Left, color, rect2.Left, num12, num6 - rect2.Left, num13 - num12);
					wrr(drawingContext, Sides.Right, color, num7, num12, rect2.Right - num7, num13 - num12);
				}
				if (num10 < num11)
				{
					wrr(drawingContext, Sides.Top, color, num10, rect2.Top, num11 - num10, num8 - rect2.Top);
					wrr(drawingContext, Sides.Bottom, color, num10, num9, num11 - num10, rect2.Bottom - num9);
				}
				double num14 = Math.Max(1.0, num10 - rect2.Left);
				double num15 = Math.Max(1.0, num12 - rect2.Top);
				double val = (num14 - num) / num14;
				double num16 = (num15 - num2) / num15;
				double num17 = Math.Max(val, num16);
				double num18 = ((!flag) ? 0.0 : ((num12 < num13) ? (num16 * 0.66) : 0.0));
				GrZ(drawingContext, Corner.TopLeft, num17, color, rect2.Left, rect2.Top, num14, num15, num18);
				GrZ(drawingContext, Corner.TopRight, num17, color, rect2.Right - num14, rect2.Top, num14, num15, num18);
				GrZ(drawingContext, Corner.BottomRight, num17, color, rect2.Right - num14, rect2.Bottom - num15, num14, num15, num18);
				GrZ(drawingContext, Corner.BottomLeft, num17, color, rect2.Left, rect2.Bottom - num15, num14, num15, num18);
				drawingContext.Pop();
			}
		}
		base.OnRender(drawingContext);
	}

	public ShadowChrome()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		prG = TF.Default;
		base._002Ector();
	}

	static ShadowChrome()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		DirectionProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(107884), typeof(double), typeof(ShadowChrome), new FrameworkPropertyMetadata(270.0, zrq));
		ElevationProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(121496), typeof(int), typeof(ShadowChrome), new FrameworkPropertyMetadata(0, SrW));
		IsShadowEnabledProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(121518), typeof(bool), typeof(ShadowChrome), new FrameworkPropertyMetadata(true, orU));
		RenderModeProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(121552), typeof(ShadowChromeRenderMode), typeof(ShadowChrome), new FrameworkPropertyMetadata(ShadowChromeRenderMode.Default, ErH));
		ShadowOpacityProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(121576), typeof(double), typeof(ShadowChrome), new FrameworkPropertyMetadata(0.3, Kr6), ValidationHelper.ValidateDoubleIsPercentage);
		ShadowThicknessProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(121606), typeof(Thickness), typeof(ShadowChrome), new FrameworkPropertyMetadata(new Thickness(0.0)));
	}

	internal static bool gb9()
	{
		return kbR == null;
	}

	internal static ShadowChrome Obc()
	{
		return kbR;
	}
}
