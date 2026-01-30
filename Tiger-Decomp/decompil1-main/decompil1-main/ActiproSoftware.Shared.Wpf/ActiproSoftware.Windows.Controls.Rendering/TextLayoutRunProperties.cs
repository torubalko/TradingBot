using System.Globalization;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.TextFormatting;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Controls.Rendering;

internal class TextLayoutRunProperties : TextRunProperties
{
	private CultureInfo OIA;

	private double PIC;

	private Brush FIY;

	private TextDecorationCollection GII;

	private Typeface rIx;

	private static TextLayoutRunProperties T0K;

	public sealed override Brush BackgroundBrush => null;

	public sealed override CultureInfo CultureInfo => OIA;

	public sealed override double FontHintingEmSize => PIC;

	public sealed override double FontRenderingEmSize => PIC;

	public sealed override Brush ForegroundBrush => FIY;

	public sealed override TextDecorationCollection TextDecorations => GII;

	public sealed override TextEffectCollection TextEffects => null;

	public sealed override Typeface Typeface => rIx;

	public TextLayoutRunProperties(Typeface typeface, double fontSize, Brush foreground, LineKind strikethroughKind, Brush strikethroughBrush, TextLineWeight strikethroughWeight, LineKind underlineKind, Brush underlineBrush, TextLineWeight underlineWeight)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
		rIx = typeface;
		PIC = fontSize;
		FIY = foreground;
		OIA = CultureInfo.CurrentCulture;
		if (strikethroughKind != LineKind.None)
		{
			if (GII == null)
			{
				GII = new TextDecorationCollection();
			}
			Pen pen = CanvasDrawContext.CreatePen(strikethroughBrush, strikethroughKind, 1f);
			if (strikethroughWeight == TextLineWeight.Double)
			{
				GII.Add(new TextDecoration(TextDecorationLocation.Strikethrough, pen, -1.0, TextDecorationUnit.Pixel, TextDecorationUnit.FontRecommended));
				GII.Add(new TextDecoration(TextDecorationLocation.Strikethrough, pen, 1.0, TextDecorationUnit.Pixel, TextDecorationUnit.FontRecommended));
			}
			else
			{
				GII.Add(new TextDecoration(TextDecorationLocation.Strikethrough, pen, 0.0, TextDecorationUnit.Pixel, TextDecorationUnit.FontRecommended));
			}
		}
		if (underlineKind != LineKind.None)
		{
			if (GII == null)
			{
				GII = new TextDecorationCollection();
			}
			Pen pen2 = CanvasDrawContext.CreatePen(underlineBrush, underlineKind, 1f);
			if (underlineWeight == TextLineWeight.Double)
			{
				GII.Add(new TextDecoration(TextDecorationLocation.Underline, pen2, -1.0, TextDecorationUnit.Pixel, TextDecorationUnit.FontRecommended));
				GII.Add(new TextDecoration(TextDecorationLocation.Underline, pen2, 1.0, TextDecorationUnit.Pixel, TextDecorationUnit.FontRecommended));
			}
			else
			{
				GII.Add(new TextDecoration(TextDecorationLocation.Underline, pen2, 0.0, TextDecorationUnit.Pixel, TextDecorationUnit.FontRecommended));
			}
		}
	}

	internal static bool Q0M()
	{
		return T0K == null;
	}

	internal static TextLayoutRunProperties e0Y()
	{
		return T0K;
	}
}
