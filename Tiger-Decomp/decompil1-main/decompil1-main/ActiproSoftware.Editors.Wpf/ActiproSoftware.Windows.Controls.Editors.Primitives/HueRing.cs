using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Media;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.Editors.Automation.Peers;
using ActiproSoftware.Windows.Extensions;
using ActiproSoftware.Windows.Media;

namespace ActiproSoftware.Windows.Controls.Editors.Primitives;

[ToolboxItem(false)]
[TemplatePart(Name = "PART_Presenter", Type = typeof(Canvas))]
public class HueRing : Control
{
	private double wOt;

	private Canvas xOn;

	public static readonly DependencyProperty LengthProperty;

	internal static HueRing Kj6;

	public double Length
	{
		get
		{
			return (double)GetValue(LengthProperty);
		}
		set
		{
			SetValue(LengthProperty, value);
		}
	}

	public HueRing()
	{
		awj.QuEwGz();
		base._002Ector();
		base.DefaultStyleKey = typeof(HueRing);
	}

	private void eOZ(double P_0)
	{
		if (xOn == null || P_0 == wOt)
		{
			return;
		}
		wOt = P_0;
		double num = Math.Max(0.0, Math.Floor(wOt / 2.0));
		double num2 = Math.Max(2.0, Length);
		double num3 = Math.Max(0.0, num - num2);
		double num4 = 6.0;
		double saturation = 0.75;
		xOn.Children.Clear();
		if (wOt != 0.0)
		{
			for (double num5 = 0.0; num5 < 360.0; num5 += num4)
			{
				Point radiusPointAtRotation = default(Point).GetRadiusPointAtRotation(num5, 1.0);
				Point radiusPointAtRotation2 = default(Point).GetRadiusPointAtRotation(num5 + num4, 1.0);
				Point point = new Point(num + radiusPointAtRotation.X * num, num + radiusPointAtRotation.Y * num);
				Point point2 = new Point(num + radiusPointAtRotation2.X * num, num + radiusPointAtRotation2.Y * num);
				Point point3 = new Point(num + radiusPointAtRotation.X * num3, num + radiusPointAtRotation.Y * num3);
				Point point4 = new Point(num + radiusPointAtRotation2.X * num3, num + radiusPointAtRotation2.Y * num3);
				Rect rect = new Rect(new Point(Math.Min(point.X, Math.Min(point2.X, Math.Min(point3.X, point4.X))), Math.Min(point.Y, Math.Min(point2.Y, Math.Min(point3.Y, point4.Y)))), new Point(Math.Max(point.X, Math.Max(point2.X, Math.Max(point3.X, point4.X))), Math.Max(point.Y, Math.Max(point2.Y, Math.Max(point3.Y, point4.Y)))));
				Point startPoint = new Point((point.X - rect.X) / Math.Max(1.0, rect.Width), (point.Y - rect.Y) / Math.Max(1.0, rect.Height));
				Point endPoint = new Point((point2.X - rect.X) / Math.Max(1.0, rect.Width), (point2.Y - rect.Y) / Math.Max(1.0, rect.Height));
				Color color = UIColor.FromHsb(num5, saturation, 1.0).ToColor();
				Color color2 = UIColor.FromHsb(num5 + num4, saturation, 1.0).ToColor();
				LinearGradientBrush stroke = new LinearGradientBrush
				{
					MappingMode = BrushMappingMode.RelativeToBoundingBox,
					StartPoint = startPoint,
					EndPoint = endPoint,
					GradientStops = 
					{
						new GradientStop
						{
							Offset = 0.0,
							Color = color
						},
						new GradientStop
						{
							Offset = 1.0,
							Color = color2
						}
					}
				};
				RingSlice element = new RingSlice
				{
					Radius = num,
					StrokeThickness = num - num3,
					StartAngle = num5 - num4 / 2.0,
					EndAngle = num5 + num4 / 2.0,
					Stroke = new SolidColorBrush(color)
				};
				Panel.SetZIndex(element, -1);
				xOn.Children.Add(element);
				RingSlice element2 = new RingSlice
				{
					Radius = num,
					StrokeThickness = num - num3,
					StartAngle = num5,
					EndAngle = num5 + num4,
					Stroke = stroke
				};
				xOn.Children.Add(element2);
			}
		}
	}

	protected override Size ArrangeOverride(Size finalSize)
	{
		base.ArrangeOverride(finalSize);
		double num = Math.Floor(Math.Min(finalSize.Width, finalSize.Height));
		eOZ(num);
		return new Size(wOt, wOt);
	}

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		xOn = GetTemplateChild(QdM.AR8(20256)) as Canvas;
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		return new HueRingAutomationPeer(this);
	}

	static HueRing()
	{
		awj.QuEwGz();
		LengthProperty = DependencyProperty.Register(QdM.AR8(24500), typeof(double), typeof(HueRing), new PropertyMetadata(40.0));
	}

	internal static bool Ljc()
	{
		return Kj6 == null;
	}

	internal static HueRing KjD()
	{
		return Kj6;
	}
}
