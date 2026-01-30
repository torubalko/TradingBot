using System;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Margins;

namespace ActiproSoftware.Internal;

internal class IQ : Panel
{
	private Size OeZ;

	private Rect jeh;

	private HTX veN;

	internal static IQ m0g;

	public IQ(HTX P_0)
	{
		grA.DaB7cz();
		base._002Ector();
		if (P_0 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		veN = P_0;
		pep();
	}

	private void pep()
	{
		int num = 1;
		UIElementCollection uIElementCollection = default(UIElementCollection);
		int num5 = default(int);
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
				{
					nR nR2 = veN.DAb();
					for (int num3 = uIElementCollection.Count - 1; num3 >= 0; num3--)
					{
						if (uIElementCollection[num3] != nR2)
						{
							uIElementCollection.RemoveAt(num3);
						}
					}
					if (nR2 != null && !uIElementCollection.Contains(nR2))
					{
						uIElementCollection.Add(nR2);
					}
					{
						foreach (IPrinterViewMargin margin in veN.Margins)
						{
							PrinterViewMarginPlacement placement = margin.Placement;
							PrinterViewMarginPlacement printerViewMarginPlacement = placement;
							if ((uint)printerViewMarginPlacement > 3u)
							{
								continue;
							}
							FrameworkElement visualElement = margin.VisualElement;
							if (visualElement != null)
							{
								uIElementCollection.Add(visualElement);
								int num4 = 0;
								if (y0l() != null)
								{
									num4 = num5;
								}
								switch (num4)
								{
								}
							}
						}
						return;
					}
				}
				}
				uIElementCollection = this.v0D();
				num2 = 0;
			}
			while (T0A());
		}
	}

	protected override Size ArrangeOverride(Size P_0)
	{
		double zoomLevel = veN.ZoomLevel;
		Rect rect = new Rect(0.0, 0.0, P_0.Width, P_0.Height);
		Rect rect2 = new Rect(rect.X / zoomLevel, rect.Y / zoomLevel, rect.Width / zoomLevel, rect.Height / zoomLevel);
		double num = 0.0;
		double num2 = 0.0;
		double num3 = 0.0;
		double num4 = 0.0;
		IPrinterViewMarginCollection margins = veN.Margins;
		int num5 = margins.Count - 1;
		FrameworkElement visualElement = default(FrameworkElement);
		double width2 = default(double);
		int num7 = default(int);
		double height2 = default(double);
		Size result = default(Size);
		while (true)
		{
			if (num5 >= 0)
			{
				IPrinterViewMargin printerViewMargin = margins[num5];
				visualElement = printerViewMargin.VisualElement;
				if (visualElement == null)
				{
					goto IL_0432;
				}
				switch (printerViewMargin.Placement)
				{
				case PrinterViewMarginPlacement.Right:
					break;
				case PrinterViewMarginPlacement.Left:
				{
					double width = visualElement.DesiredSize.Width;
					visualElement.Arrange(new Rect(rect2.X + num, rect2.Y + num2, Math.Max(0.0, width), Math.Max(0.0, rect2.Height - num2 - num4)));
					num += width;
					goto IL_0432;
				}
				case PrinterViewMarginPlacement.Top:
				{
					double height = visualElement.DesiredSize.Height;
					visualElement.Arrange(new Rect(rect2.X + num, rect2.Y + num2, Math.Max(0.0, rect2.Width - num - num3), Math.Max(0.0, height)));
					num2 += height;
					goto IL_0432;
				}
				default:
					goto IL_0432;
				case PrinterViewMarginPlacement.Bottom:
					goto IL_04ad;
				}
				goto IL_01fb;
			}
			OeZ = new Size(Math.Max(0.0, rect2.Width - num - num3), Math.Max(0.0, rect2.Height - num2 - num4));
			int num6 = 1;
			if (!T0A())
			{
				goto IL_0005;
			}
			goto IL_0009;
			IL_0251:
			num3 += width2;
			goto IL_0432;
			IL_0005:
			num6 = num7;
			goto IL_0009;
			IL_0432:
			num5--;
			continue;
			IL_04ad:
			height2 = visualElement.DesiredSize.Height;
			visualElement.Arrange(new Rect(rect2.X + num, rect2.Bottom - num4 - height2, Math.Max(0.0, rect2.Width - num - num3), Math.Max(0.0, height2)));
			num6 = 0;
			if (!T0A())
			{
				goto IL_0005;
			}
			goto IL_0009;
			IL_01fb:
			width2 = visualElement.DesiredSize.Width;
			visualElement.Arrange(new Rect(rect2.Right - num3 - width2, rect2.Y + num2, Math.Max(0.0, width2), Math.Max(0.0, rect2.Height - num2 - num4)));
			num6 = 2;
			if (!T0A())
			{
				goto IL_0005;
			}
			goto IL_0009;
			IL_0009:
			while (true)
			{
				switch (num6)
				{
				case 1:
					break;
				case 4:
					goto end_IL_0009;
				case 2:
					goto IL_0251;
				case 3:
					return result;
				default:
					goto IL_0406;
				}
				jeh = new Rect(num * zoomLevel, num2 * zoomLevel, Math.Max(0.0, rect.Width - (num + num3) * zoomLevel), Math.Max(0.0, rect.Height - (num2 + num4) * zoomLevel));
				nR nR2 = veN.DAb();
				if (nR2 != null)
				{
					Rect finalRect = new Rect(rect.X + num, rect.Y + num2, OeZ.Width, OeZ.Height);
					nR2.Arrange(finalRect);
				}
				else
				{
					OeZ = default(Size);
				}
				result = P_0;
				num6 = 3;
				if (T0A())
				{
					continue;
				}
				goto IL_0005;
				continue;
				end_IL_0009:
				break;
			}
			goto IL_01fb;
			IL_0406:
			num4 += height2;
			goto IL_0432;
		}
	}

	public void GeM()
	{
		pep();
	}

	[SpecialName]
	public Size PeO()
	{
		return OeZ;
	}

	[SpecialName]
	public Rect meJ()
	{
		return jeh;
	}

	protected override Size MeasureOverride(Size P_0)
	{
		UIElementCollection uIElementCollection = this.v0D();
		foreach (UIElement item in uIElementCollection)
		{
			item.Measure(P_0);
		}
		return default(Size);
	}

	internal static bool T0A()
	{
		return m0g == null;
	}

	internal static IQ y0l()
	{
		return m0g;
	}
}
