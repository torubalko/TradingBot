using System.Windows.Media;
using ActiproSoftware.Windows.Media;

namespace ActiproSoftware.Internal;

internal static class hW
{
	private static hW EYC;

	public static Brush RlQ(Brush P_0)
	{
		if (P_0 is LinearGradientBrush linearGradientBrush && linearGradientBrush.GradientStops.Count > 0)
		{
			GradientStop gradientStop = linearGradientBrush.GradientStops[linearGradientBrush.GradientStops.Count - 1];
			if (gradientStop != null)
			{
				P_0 = new SolidColorBrush(gradientStop.Color);
				P_0.Freeze();
			}
		}
		return P_0;
	}

	public static Brush ylm(Brush P_0, Color P_1, bool P_2)
	{
		if (P_0 == null)
		{
			return null;
		}
		Brush brush = P_0;
		if (P_1 != Colors.Transparent)
		{
			brush = P_0.CloneCurrentValue();
			if (!brush.IsFrozen)
			{
				if (brush is SolidColorBrush solidColorBrush)
				{
					solidColorBrush.Color = Hla(solidColorBrush.Color, P_1, P_2);
				}
				else if (brush is GradientBrush gradientBrush)
				{
					foreach (GradientStop gradientStop in gradientBrush.GradientStops)
					{
						gradientStop.Color = Hla(gradientStop.Color, P_1, P_2);
					}
				}
			}
		}
		else if (!P_0.IsFrozen)
		{
			brush = P_0.CloneCurrentValue();
		}
		if (brush.CanFreeze)
		{
			brush.Freeze();
		}
		return brush;
	}

	public static Color Hla(Color P_0, Color P_1, bool P_2)
	{
		Color color = UIColor.GetTintedColor(P_0, P_1);
		if (P_2)
		{
			double num = (double)(int)P_1.A / 255.0;
			UIColor uIColor = UIColor.FromMix(P_0, color, num);
			uIColor.A = (byte)((double)(int)P_0.A - (double)(P_0.A - uIColor.A) * num);
			color = uIColor.ToColor();
		}
		return color;
	}

	internal static bool sYK()
	{
		return EYC == null;
	}

	internal static hW zYG()
	{
		return EYC;
	}
}
