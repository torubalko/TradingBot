using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Editors.Primitives;

[ToolboxItem(false)]
public class SpinnerButtonPanel : Panel
{
	public static readonly DependencyProperty OrientationProperty;

	private static SpinnerButtonPanel Bhx;

	public Orientation Orientation
	{
		get
		{
			return (Orientation)GetValue(OrientationProperty);
		}
		set
		{
			SetValue(OrientationProperty, value);
		}
	}

	private static void jIw(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		SpinnerButtonPanel spinnerButtonPanel = (SpinnerButtonPanel)P_0;
		spinnerButtonPanel.InvalidateMeasure();
	}

	protected override Size ArrangeOverride(Size finalSize)
	{
		if (base.Children.Count == 2)
		{
			UIElement uIElement = base.Children[0];
			int num = 0;
			if (xSF() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			UIElement uIElement2 = default(UIElement);
			while (true)
			{
				switch (num)
				{
				default:
					uIElement2 = base.Children[1];
					if (uIElement != null)
					{
						num = 1;
						if (xSF() != null)
						{
							num = 0;
						}
						continue;
					}
					break;
				case 1:
					if (uIElement2 != null)
					{
						if (Orientation == Orientation.Horizontal)
						{
							double width = Math.Ceiling(finalSize.Width / 2.0);
							double num3 = Math.Floor(finalSize.Width / 2.0);
							uIElement2.Arrange(new Rect(0.0, 0.0, width, finalSize.Height));
							uIElement.Arrange(new Rect(finalSize.Width - num3, 0.0, num3, finalSize.Height));
						}
						else
						{
							double height = Math.Ceiling(finalSize.Height / 2.0);
							double num4 = Math.Floor(finalSize.Height / 2.0);
							uIElement.Arrange(new Rect(0.0, 0.0, finalSize.Width, height));
							uIElement2.Arrange(new Rect(0.0, finalSize.Height - num4, finalSize.Width, num4));
						}
					}
					break;
				}
				break;
			}
		}
		return finalSize;
	}

	protected override Size MeasureOverride(Size availableSize)
	{
		int num = 2;
		UIElement uIElement = default(UIElement);
		UIElement uIElement2 = default(UIElement);
		Size result = default(Size);
		while (true)
		{
			int num2 = num;
			do
			{
				IL_0012:
				switch (num2)
				{
				case 2:
					break;
				case 1:
					if (base.Children.Count == 2)
					{
						uIElement = base.Children[0];
						uIElement2 = base.Children[1];
						num2 = 0;
						if (!Ahz())
						{
							num2 = 0;
						}
						goto IL_0012;
					}
					goto IL_0049;
				default:
					{
						if (uIElement != null && uIElement2 != null)
						{
							uIElement.Measure(availableSize);
							uIElement2.Measure(availableSize);
							result = ((Orientation == Orientation.Horizontal) ? new Size(uIElement.DesiredSize.Width + uIElement2.DesiredSize.Width, Math.Max(uIElement.DesiredSize.Height, uIElement2.DesiredSize.Height)) : new Size(Math.Max(uIElement.DesiredSize.Width, uIElement2.DesiredSize.Width), uIElement.DesiredSize.Height + uIElement2.DesiredSize.Height));
						}
						goto IL_0049;
					}
					IL_0049:
					return result;
				}
				result = default(Size);
				num2 = 1;
			}
			while (xSF() == null);
		}
	}

	public SpinnerButtonPanel()
	{
		awj.QuEwGz();
		base._002Ector();
	}

	static SpinnerButtonPanel()
	{
		awj.QuEwGz();
		OrientationProperty = DependencyProperty.Register(QdM.AR8(22356), typeof(Orientation), typeof(SpinnerButtonPanel), new PropertyMetadata(Orientation.Vertical, jIw));
	}

	internal static bool Ahz()
	{
		return Bhx == null;
	}

	internal static SpinnerButtonPanel xSF()
	{
		return Bhx;
	}
}
