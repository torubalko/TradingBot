using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;

namespace ActiproSoftware.Windows.Controls.Rendering;

public interface ITextLayout : IDisposable
{
	IList<ITextLayoutLine> Lines { get; }

	IList<ITextSpacer> Spacers { get; }

	double SpaceWidth { get; }

	int TabSize { get; set; }

	TextFormattingMode TextFormattingMode { get; set; }

	ITextProvider TextProvider { get; }

	TextLayoutWrapping TextWrapping { get; set; }

	void RunTextFormatter(IDisposable batch);

	void SetFontFamily(int characterIndex, int characterCount, string fontFamilyName);

	void SetFontSize(int characterIndex, int characterCount, float fontSize);

	void SetFontStyle(int characterIndex, int characterCount, FontStyle fontStyle);

	void SetFontWeight(int characterIndex, int characterCount, FontWeight fontWeight);

	void SetForeground(int characterIndex, int characterCount, Color color);

	void SetForeground(int characterIndex, int characterCount, Brush brush);

	void SetStrikethrough(int characterIndex, int characterCount, bool hasStrikethrough);

	void SetStrikethrough(int characterIndex, int characterCount, LineKind lineKind, Color? color, TextLineWeight lineWeight);

	void SetStrikethrough(int characterIndex, int characterCount, LineKind lineKind, Brush brush, TextLineWeight lineWeight);

	void SetUnderline(int characterIndex, int characterCount, bool hasUnderline);

	void SetUnderline(int characterIndex, int characterCount, LineKind lineKind, Color? color, TextLineWeight lineWeight);

	void SetUnderline(int characterIndex, int characterCount, LineKind lineKind, Brush brush, TextLineWeight lineWeight);
}
