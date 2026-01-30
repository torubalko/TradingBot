using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;

namespace ActiproSoftware.Windows.Controls.Rendering;

public interface ICanvas
{
	IDisposable CreateTextBatch();

	ITextLayout CreateTextLayout(string text, float maxWidth, string fontFamilyName, float fontSize, Color foreground);

	ITextLayout CreateTextLayout(ITextProvider textProvider, float maxWidth, string fontFamilyName, float fontSize, Color foreground, IEnumerable<ITextSpacer> spacers);

	ITextLayout CreateTextLayout(ITextProvider textProvider, float maxWidth, string fontFamilyName, float fontSize, Color foreground, FontWeight fontWeight, FontStyle fontStyle, IEnumerable<ITextSpacer> spacers);

	ITextLayout CreateTextLayout(string text, float maxWidth, string fontFamilyName, float fontSize, Brush foreground);

	ITextLayout CreateTextLayout(ITextProvider textProvider, float maxWidth, string fontFamilyName, float fontSize, Brush foreground, IEnumerable<ITextSpacer> spacers);

	ITextLayout CreateTextLayout(ITextProvider textProvider, float maxWidth, string fontFamilyName, float fontSize, Brush foreground, FontWeight fontWeight, FontStyle fontStyle, IEnumerable<ITextSpacer> spacers);

	ITextSpacer CreateTextSpacer(int characterIndex, object key, Size size, double baseline);

	SolidColorBrush GetSolidColorBrush(Color color);

	Pen GetSquiggleLinePen(Color color);
}
