using System;
using System.Windows;
using System.Windows.Media.TextFormatting;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Controls.Rendering;

internal class TextLayoutParagraphProperties : TextParagraphProperties
{
	private double JIk;

	private TextRunProperties KIl;

	internal static TextLayoutParagraphProperties rnP;

	public sealed override double DefaultIncrementalTab => JIk;

	public sealed override TextRunProperties DefaultTextRunProperties => KIl;

	public sealed override bool FirstLineInParagraph => false;

	public sealed override FlowDirection FlowDirection => FlowDirection.LeftToRight;

	public sealed override double Indent => 0.0;

	public sealed override double LineHeight => 0.0;

	public sealed override TextAlignment TextAlignment => TextAlignment.Left;

	public sealed override TextMarkerProperties TextMarkerProperties => null;

	public sealed override TextWrapping TextWrapping => TextWrapping.Wrap;

	public TextLayoutParagraphProperties(TextLayoutRunProperties defaultTextRunProperties, double spaceWidth, double tabSize)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
		if (defaultTextRunProperties == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(117844));
		}
		KIl = defaultTextRunProperties;
		JIk = spaceWidth * tabSize;
	}

	internal static bool bnW()
	{
		return rnP == null;
	}

	internal static TextLayoutParagraphProperties bnz()
	{
		return rnP;
	}
}
