using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Docking.Primitives;

[ToolboxItem(false)]
public class TitleBarPanel : Panel
{
	public static readonly DependencyProperty ContextContentAlignmentProperty;

	public static readonly DependencyProperty IsContextContentProperty;

	public static readonly DependencyProperty IsFillerProperty;

	public static readonly DependencyProperty IsHeaderProperty;

	public static readonly DependencyProperty IsIconProperty;

	public static readonly DependencyProperty IsReadOnlyContextContentProperty;

	private static TitleBarPanel wAh;

	public ContextContentAlignment ContextContentAlignment
	{
		get
		{
			return (ContextContentAlignment)GetValue(ContextContentAlignmentProperty);
		}
		set
		{
			SetValue(ContextContentAlignmentProperty, value);
		}
	}

	private static void uxT(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((TitleBarPanel)P_0).InvalidateMeasure();
	}

	protected override Size ArrangeOverride(Size finalSize)
	{
		double num = finalSize.Width;
		double height = finalSize.Height;
		FrameworkElement frameworkElement = null;
		FrameworkElement frameworkElement2 = null;
		FrameworkElement frameworkElement3 = null;
		FrameworkElement frameworkElement4 = null;
		FrameworkElement frameworkElement5 = null;
		for (int num2 = base.Children.Count - 1; num2 >= 0; num2--)
		{
			if (base.Children[num2] is FrameworkElement frameworkElement6)
			{
				if (GetIsIcon(frameworkElement6))
				{
					frameworkElement4 = frameworkElement6;
				}
				else if (GetIsContextContent(frameworkElement6))
				{
					frameworkElement2 = frameworkElement6;
				}
				else if (GetIsReadOnlyContextContent(frameworkElement6))
				{
					frameworkElement5 = frameworkElement6;
				}
				else if (GetIsHeader(frameworkElement6))
				{
					frameworkElement = frameworkElement6;
				}
				else if (GetIsFiller(frameworkElement6))
				{
					frameworkElement3 = frameworkElement6;
				}
				else
				{
					double num3 = num;
					num -= frameworkElement6.DesiredSize.Width;
					double y = (height - frameworkElement6.DesiredSize.Height) / 2.0;
					frameworkElement6.Arrange(new Rect(num, y, Math.Max(0.0, num3 - num), frameworkElement6.DesiredSize.Height));
				}
			}
		}
		double num4 = 0.0;
		if (frameworkElement5 != null && frameworkElement5.Visibility != Visibility.Collapsed)
		{
			double y2 = (height - frameworkElement5.DesiredSize.Height) / 2.0;
			num4 = Math.Min(frameworkElement5.DesiredSize.Width, Math.Max(0.0, num));
			num -= num4;
			frameworkElement5.Arrange(new Rect(num, y2, num4, frameworkElement5.DesiredSize.Height));
		}
		double num5 = 0.0;
		if (frameworkElement2 != null)
		{
			double y3 = (height - frameworkElement2.DesiredSize.Height) / 2.0;
			if (ContextContentAlignment == ContextContentAlignment.Near)
			{
				num5 = Math.Min(frameworkElement2.DesiredSize.Width, Math.Max(0.0, num));
				frameworkElement2.Arrange(new Rect(0.0, y3, num5, frameworkElement2.DesiredSize.Height));
			}
			else
			{
				num -= frameworkElement2.DesiredSize.Width;
				frameworkElement2.Arrange(new Rect(num, y3, frameworkElement2.DesiredSize.Width, frameworkElement2.DesiredSize.Height));
			}
		}
		double num6 = 0.0;
		if (frameworkElement4 != null)
		{
			Image image = frameworkElement4 as Image;
			if (frameworkElement4.Visibility != Visibility.Collapsed && (image == null || image.Source != null))
			{
				double y4 = (height - frameworkElement4.DesiredSize.Height) / 2.0;
				num6 = Math.Min(frameworkElement4.DesiredSize.Width, Math.Max(0.0, num - num5));
				frameworkElement4.Arrange(new Rect(num5, y4, num6, frameworkElement4.DesiredSize.Height));
			}
			else
			{
				frameworkElement4.Arrange(new Rect(-100.0, 0.0, 0.0, 0.0));
			}
		}
		double num7 = 0.0;
		if (frameworkElement != null)
		{
			double y5 = (height - frameworkElement.DesiredSize.Height) / 2.0;
			num7 = Math.Min(frameworkElement.DesiredSize.Width, Math.Max(0.0, num - num6 - num5));
			frameworkElement.Arrange(new Rect(num6 + num5, y5, num7, frameworkElement.DesiredSize.Height));
		}
		if (frameworkElement3 != null)
		{
			double y6 = (height - frameworkElement3.DesiredSize.Height) / 2.0;
			frameworkElement3.Arrange(new Rect(num6 + num5 + num7, y6, Math.Max(0.0, num - num7 - num6 - num5), frameworkElement3.DesiredSize.Height));
		}
		return finalSize;
	}

	[AttachedPropertyBrowsableForChildren]
	public static bool GetIsContextContent(DependencyObject obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(vVK.ssH(15298));
		}
		return (bool)obj.GetValue(IsContextContentProperty);
	}

	public static void SetIsContextContent(DependencyObject obj, bool value)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(vVK.ssH(15298));
		}
		obj.SetValue(IsContextContentProperty, value);
	}

	[AttachedPropertyBrowsableForChildren]
	public static bool GetIsFiller(DependencyObject obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(vVK.ssH(15298));
		}
		return (bool)obj.GetValue(IsFillerProperty);
	}

	public static void SetIsFiller(DependencyObject obj, bool value)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(vVK.ssH(15298));
		}
		obj.SetValue(IsFillerProperty, value);
	}

	[AttachedPropertyBrowsableForChildren]
	public static bool GetIsHeader(DependencyObject obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(vVK.ssH(15298));
		}
		return (bool)obj.GetValue(IsHeaderProperty);
	}

	public static void SetIsHeader(DependencyObject obj, bool value)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(vVK.ssH(15298));
		}
		obj.SetValue(IsHeaderProperty, value);
	}

	[AttachedPropertyBrowsableForChildren]
	public static bool GetIsIcon(DependencyObject obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(vVK.ssH(15298));
		}
		return (bool)obj.GetValue(IsIconProperty);
	}

	public static void SetIsIcon(DependencyObject obj, bool value)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(vVK.ssH(15298));
		}
		obj.SetValue(IsIconProperty, value);
	}

	[AttachedPropertyBrowsableForChildren]
	public static bool GetIsReadOnlyContextContent(DependencyObject obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(vVK.ssH(15298));
		}
		return (bool)obj.GetValue(IsReadOnlyContextContentProperty);
	}

	public static void SetIsReadOnlyContextContent(DependencyObject obj, bool value)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(vVK.ssH(15298));
		}
		obj.SetValue(IsReadOnlyContextContentProperty, value);
	}

	protected override Size MeasureOverride(Size availableSize)
	{
		double num = availableSize.Width;
		double height = availableSize.Height;
		double num2 = 0.0;
		double num3 = 0.0;
		FrameworkElement frameworkElement = null;
		FrameworkElement frameworkElement2 = null;
		for (int num4 = base.Children.Count - 1; num4 >= 0; num4--)
		{
			if (base.Children[num4] is FrameworkElement frameworkElement3)
			{
				if (GetIsHeader(frameworkElement3))
				{
					frameworkElement = frameworkElement3;
				}
				else if (GetIsFiller(frameworkElement3))
				{
					frameworkElement2 = frameworkElement3;
				}
				else
				{
					frameworkElement3.Measure(new Size(double.PositiveInfinity, height));
					if (frameworkElement3.Visibility != Visibility.Collapsed && (!GetIsIcon(frameworkElement3) || !(frameworkElement3 is Image { Source: null })))
					{
						num = Math.Max(0.0, num - frameworkElement3.DesiredSize.Width);
						num2 += frameworkElement3.DesiredSize.Width;
						num3 = Math.Max(num3, frameworkElement3.DesiredSize.Height);
					}
				}
			}
		}
		if (frameworkElement != null)
		{
			frameworkElement.Measure(new Size(num, height));
			if (frameworkElement.Visibility != Visibility.Collapsed)
			{
				num = Math.Max(0.0, num - frameworkElement.DesiredSize.Width);
				num2 += frameworkElement.DesiredSize.Width;
				num3 = Math.Max(num3, frameworkElement.DesiredSize.Height);
			}
		}
		if (frameworkElement2 != null)
		{
			frameworkElement2.Measure(new Size(num, height));
			if (frameworkElement2.Visibility != Visibility.Collapsed)
			{
				num2 += frameworkElement2.DesiredSize.Width;
				num3 = Math.Max(num3, frameworkElement2.DesiredSize.Height);
			}
		}
		num2 = Math.Ceiling(Math.Min(availableSize.Width, num2));
		num3 = Math.Ceiling(Math.Min(availableSize.Height, num3));
		if (num3 % 2.0 == 1.0)
		{
			num3 += 1.0;
		}
		return new Size(num2, num3);
	}

	public TitleBarPanel()
	{
		IVH.CecNqz();
		base._002Ector();
	}

	static TitleBarPanel()
	{
		IVH.CecNqz();
		ContextContentAlignmentProperty = DependencyProperty.Register(vVK.ssH(22130), typeof(ContextContentAlignment), typeof(TitleBarPanel), new PropertyMetadata(ContextContentAlignment.Far, uxT));
		IsContextContentProperty = DependencyProperty.RegisterAttached(vVK.ssH(22180), typeof(bool), typeof(TitleBarPanel), new PropertyMetadata(false));
		IsFillerProperty = DependencyProperty.RegisterAttached(vVK.ssH(22216), typeof(bool), typeof(TitleBarPanel), new PropertyMetadata(false));
		IsHeaderProperty = DependencyProperty.RegisterAttached(vVK.ssH(22236), typeof(bool), typeof(TitleBarPanel), new PropertyMetadata(false));
		IsIconProperty = DependencyProperty.RegisterAttached(vVK.ssH(22256), typeof(bool), typeof(TitleBarPanel), new PropertyMetadata(false));
		IsReadOnlyContextContentProperty = DependencyProperty.RegisterAttached(vVK.ssH(22272), typeof(bool), typeof(TitleBarPanel), new PropertyMetadata(false));
	}

	internal static bool zAL()
	{
		return wAh == null;
	}

	internal static TitleBarPanel uAl()
	{
		return wAh;
	}
}
