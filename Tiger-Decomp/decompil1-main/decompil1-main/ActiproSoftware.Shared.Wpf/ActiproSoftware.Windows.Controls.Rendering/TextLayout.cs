using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.TextFormatting;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Controls.Rendering;

internal class TextLayout : TextSource, ITextLayout, IDisposable
{
	private float LYG;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private CanvasDrawCache sY1;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private SpacerTextProvider JYz;

	private List<TextLayoutFormatChange> wIc;

	private ITextLayoutLine[] lIj;

	private int BIv;

	private TextLayoutWrapping XIX;

	private int kIT;

	private int VIB;

	private float? JIp;

	private static Regex iIb;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private bool FIy;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private TextFormattingMode KIf;

	internal static TextLayout PnD;

	internal CanvasDrawCache Cache
	{
		[CompilerGenerated]
		get
		{
			return sY1;
		}
		[CompilerGenerated]
		private set
		{
			sY1 = value;
		}
	}

	internal SpacerTextProvider TextProviderInternal
	{
		[CompilerGenerated]
		get
		{
			return JYz;
		}
		[CompilerGenerated]
		private set
		{
			JYz = value;
		}
	}

	public IList<ITextSpacer> Spacers => TextProviderInternal.Spacers;

	public ITextProvider TextProvider => TextProviderInternal;

	public IList<ITextLayoutLine> Lines
	{
		get
		{
			uYR();
			return lIj;
		}
	}

	public int TabSize
	{
		get
		{
			return BIv;
		}
		set
		{
			value = Math.Max(1, Math.Min(16, value));
			if (BIv != value)
			{
				BIv = value;
				NYE();
			}
		}
	}

	public TextLayoutWrapping TextWrapping
	{
		get
		{
			return XIX;
		}
		set
		{
			if (XIX != value)
			{
				XIX = value;
				NYE();
			}
		}
	}

	public bool IsDisposed
	{
		[CompilerGenerated]
		get
		{
			return FIy;
		}
		[CompilerGenerated]
		private set
		{
			FIy = value;
		}
	}

	public double SpaceWidth
	{
		get
		{
			if (!JIp.HasValue)
			{
				oYd(null);
			}
			return JIp.Value;
		}
	}

	public TextFormattingMode TextFormattingMode
	{
		[CompilerGenerated]
		get
		{
			return KIf;
		}
		[CompilerGenerated]
		set
		{
			KIf = value;
		}
	}

	internal TextLayout(CanvasDrawCache cache, ITextProvider textProvider, float maxWidth, string fontFamilyName, float fontSize, Brush foreground, FontWeight fontWeight, FontStyle fontStyle, IEnumerable<ITextSpacer> spacers)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		BIv = 4;
		XIX = TextLayoutWrapping.NoWrap;
		kIT = -1;
		base._002Ector();
		if (cache == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(117120));
		}
		if (textProvider == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(117134));
		}
		Cache = cache;
		TextProviderInternal = new SpacerTextProvider(textProvider, spacers);
		LYG = Math.Max(1f, maxWidth);
		CY6(fontFamilyName, fontSize, foreground, fontWeight, fontStyle);
		UIElement uIElement = Cache.Canvas as UIElement;
		TextFormattingMode = ((uIElement != null) ? TextOptions.GetTextFormattingMode(uIElement) : TextFormattingMode.Ideal);
	}

	public void RunTextFormatter(IDisposable batch)
	{
		if (!nY8())
		{
			if (batch is TextBatch textBatch)
			{
				ITextLayoutLine[] array = xYN(textBatch);
				lIj = array;
			}
			else
			{
				PYM();
			}
		}
	}

	private int HYH(int P_0)
	{
		int num = 0;
		int num2 = wIc.Count - 1;
		while (num <= num2)
		{
			int num3 = (num + num2) / 2;
			int characterIndex = wIc[num3].CharacterIndex;
			if (characterIndex == P_0)
			{
				return num3;
			}
			if (characterIndex > P_0)
			{
				num2 = num3 - 1;
			}
			else
			{
				num = num3 + 1;
			}
		}
		if (num2 >= 0)
		{
			if (wIc[num2].CharacterIndex > P_0)
			{
				return ~num2;
			}
			return ~(num2 + 1);
		}
		return -1;
	}

	private void CY6(string P_0, float P_1, Brush P_2, FontWeight P_3, FontStyle P_4)
	{
		if (string.IsNullOrEmpty(P_0))
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(117162));
		}
		if (P_2 == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(117194));
		}
		CanvasDrawCache cache = Cache;
		TextLayoutFormat textLayoutFormat = new TextLayoutFormat
		{
			FontFamilyIndex = cache.GetFontFamilyIndex(P_0),
			FontSizeIndex = cache.GetFontSizeIndex(P_1),
			ForegroundIndex = cache.GetBrushIndex(P_2),
			IsBold = (P_3 >= FontWeights.Bold),
			IsItalic = (P_4 == FontStyles.Italic)
		};
		wIc = new List<TextLayoutFormatChange>(4)
		{
			new TextLayoutFormatChange(0, textLayoutFormat)
		};
		SpacerTextProvider textProviderInternal = TextProviderInternal;
		IList<ITextSpacer> spacers = textProviderInternal.Spacers;
		if (spacers == null)
		{
			return;
		}
		foreach (ITextSpacer item in spacers)
		{
			int characterIndex = item.CharacterIndex;
			int num = HYH(characterIndex);
			if (num >= 0)
			{
				TextLayoutFormat format = wIc[num].Format;
				format.IsSpacer = true;
				wIc[num] = new TextLayoutFormatChange(characterIndex, format);
			}
			else
			{
				TextLayoutFormat format2 = textLayoutFormat;
				format2.IsSpacer = true;
				wIc.Insert(~num, new TextLayoutFormatChange(characterIndex, format2));
			}
			num = HYH(characterIndex + 1);
			if (num < 0)
			{
				wIc.Insert(~num, new TextLayoutFormatChange(characterIndex + 1, textLayoutFormat));
			}
		}
	}

	private void cYV(int P_0, int P_1, TextLayoutFormatChangeKinds P_2, TextLayoutFormat P_3, int P_4, TextLayoutFormatChange P_5)
	{
		if (P_5.Format == P_3)
		{
			return;
		}
		TextLayoutFormatChange textLayoutFormatChange = new TextLayoutFormatChange(P_0, P_3);
		if (P_4 >= 0)
		{
			wIc[P_4] = textLayoutFormatChange;
		}
		else
		{
			P_4 = ~P_4;
			wIc.Insert(P_4, textLayoutFormatChange);
		}
		P_4++;
		int num = P_0 + P_1;
		while (P_4 < wIc.Count)
		{
			TextLayoutFormatChange textLayoutFormatChange2 = wIc[P_4];
			if (textLayoutFormatChange2.CharacterIndex < num)
			{
				P_5 = textLayoutFormatChange2;
				TextLayoutFormat format = P_5.Format;
				switch (P_2)
				{
				case TextLayoutFormatChangeKinds.FontFamily:
					format.FontFamilyIndex = P_3.FontFamilyIndex;
					break;
				case TextLayoutFormatChangeKinds.FontSize:
					format.FontSizeIndex = P_3.FontSizeIndex;
					break;
				case TextLayoutFormatChangeKinds.FontStyle:
					format.IsItalic = P_3.IsItalic;
					break;
				case TextLayoutFormatChangeKinds.FontWeight:
					format.IsBold = P_3.IsBold;
					break;
				case TextLayoutFormatChangeKinds.Foreground:
					format.ForegroundIndex = P_3.ForegroundIndex;
					break;
				case TextLayoutFormatChangeKinds.Strikethrough:
					format.StrikethroughBrushIndex = P_3.StrikethroughBrushIndex;
					format.StrikethroughKind = P_3.StrikethroughKind;
					break;
				case TextLayoutFormatChangeKinds.Underline:
					format.UnderlineBrushIndex = P_3.UnderlineBrushIndex;
					format.UnderlineKind = P_3.UnderlineKind;
					format.UnderlineWeight = P_3.UnderlineWeight;
					break;
				default:
					throw new NotSupportedException();
				}
				wIc[P_4++] = new TextLayoutFormatChange(P_5.CharacterIndex, format);
				continue;
			}
			if (textLayoutFormatChange2.CharacterIndex == num)
			{
				if (textLayoutFormatChange2.Format == P_3)
				{
					wIc.RemoveAt(P_4);
				}
				return;
			}
			break;
		}
		if (num < TextProviderInternal.Length && P_5.Format != P_3)
		{
			TextLayoutFormatChange item = new TextLayoutFormatChange(num, P_5.Format);
			wIc.Insert(P_4, item);
		}
	}

	private void tY5(int P_0, int P_1)
	{
		int length = TextProvider.Length;
		if (P_0 < 0 || P_0 > length - 1)
		{
			throw new ArgumentOutOfRangeException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(117088));
		}
		if (P_1 <= 0 || P_1 > length - P_0)
		{
			throw new ArgumentOutOfRangeException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(117218));
		}
	}

	public void SetFontFamily(int characterIndex, int characterCount, string fontFamilyName)
	{
		tY5(characterIndex, characterCount);
		if (string.IsNullOrEmpty(fontFamilyName))
		{
			throw new ArgumentOutOfRangeException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(117162));
		}
		if (nY8())
		{
			NYE();
			int num = 0;
			if (!jn2())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
		int num3 = HYH(characterIndex);
		TextLayoutFormatChange textLayoutFormatChange = wIc[(num3 >= 0) ? num3 : Math.Max(0, ~num3 - 1)];
		TextLayoutFormat format = textLayoutFormatChange.Format;
		format.FontFamilyIndex = Cache.GetFontFamilyIndex(fontFamilyName);
		cYV(characterIndex, characterCount, TextLayoutFormatChangeKinds.FontFamily, format, num3, textLayoutFormatChange);
	}

	public void SetFontSize(int characterIndex, int characterCount, float fontSize)
	{
		tY5(characterIndex, characterCount);
		if ((double)fontSize <= 0.0)
		{
			throw new ArgumentOutOfRangeException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(117250));
		}
		if (nY8())
		{
			NYE();
		}
		int num = HYH(characterIndex);
		TextLayoutFormatChange textLayoutFormatChange = wIc[(num >= 0) ? num : Math.Max(0, ~num - 1)];
		TextLayoutFormat format = textLayoutFormatChange.Format;
		format.FontSizeIndex = Cache.GetFontSizeIndex(fontSize);
		cYV(characterIndex, characterCount, TextLayoutFormatChangeKinds.FontSize, format, num, textLayoutFormatChange);
	}

	public void SetFontStyle(int characterIndex, int characterCount, FontStyle fontStyle)
	{
		tY5(characterIndex, characterCount);
		bool isItalic = fontStyle == FontStyles.Italic;
		int num = 0;
		if (hnl() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (nY8())
		{
			NYE();
		}
		int num3 = HYH(characterIndex);
		TextLayoutFormatChange textLayoutFormatChange = wIc[(num3 >= 0) ? num3 : Math.Max(0, ~num3 - 1)];
		TextLayoutFormat format = textLayoutFormatChange.Format;
		format.IsItalic = isItalic;
		cYV(characterIndex, characterCount, TextLayoutFormatChangeKinds.FontStyle, format, num3, textLayoutFormatChange);
	}

	public void SetFontWeight(int characterIndex, int characterCount, FontWeight fontWeight)
	{
		tY5(characterIndex, characterCount);
		bool isBold = fontWeight >= FontWeights.Bold;
		if (nY8())
		{
			NYE();
		}
		int num = HYH(characterIndex);
		TextLayoutFormatChange textLayoutFormatChange = wIc[(num >= 0) ? num : Math.Max(0, ~num - 1)];
		TextLayoutFormat format = textLayoutFormatChange.Format;
		format.IsBold = isBold;
		cYV(characterIndex, characterCount, TextLayoutFormatChangeKinds.FontWeight, format, num, textLayoutFormatChange);
	}

	public void SetForeground(int characterIndex, int characterCount, Color color)
	{
		SolidColorBrush solidColorBrush = Cache.GetSolidColorBrush(color);
		SetForeground(characterIndex, characterCount, solidColorBrush);
	}

	public void SetForeground(int characterIndex, int characterCount, Brush brush)
	{
		tY5(characterIndex, characterCount);
		bool flag = brush == null;
		int num = 0;
		if (!jn2())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (flag)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(117270));
		}
		if (nY8())
		{
			NYE();
		}
		int num3 = HYH(characterIndex);
		TextLayoutFormatChange textLayoutFormatChange = wIc[(num3 >= 0) ? num3 : Math.Max(0, ~num3 - 1)];
		TextLayoutFormat format = textLayoutFormatChange.Format;
		format.ForegroundIndex = Cache.GetBrushIndex(brush);
		cYV(characterIndex, characterCount, TextLayoutFormatChangeKinds.Foreground, format, num3, textLayoutFormatChange);
	}

	public void SetStrikethrough(int characterIndex, int characterCount, bool hasStrikethrough)
	{
		LineKind lineKind = (hasStrikethrough ? LineKind.Solid : LineKind.None);
		SetStrikethrough(characterIndex, characterCount, lineKind, (Brush)null, TextLineWeight.Single);
	}

	public void SetStrikethrough(int characterIndex, int characterCount, LineKind lineKind, Color? color, TextLineWeight lineWeight = TextLineWeight.Single)
	{
		SolidColorBrush brush = (color.HasValue ? Cache.GetSolidColorBrush(color.Value) : null);
		SetStrikethrough(characterIndex, characterCount, lineKind, brush, lineWeight);
	}

	public void SetStrikethrough(int characterIndex, int characterCount, LineKind lineKind, Brush brush, TextLineWeight lineWeight = TextLineWeight.Single)
	{
		tY5(characterIndex, characterCount);
		if (nY8())
		{
			NYE();
		}
		int num = HYH(characterIndex);
		TextLayoutFormatChange textLayoutFormatChange = wIc[(num >= 0) ? num : Math.Max(0, ~num - 1)];
		TextLayoutFormat format = textLayoutFormatChange.Format;
		format.StrikethroughKind = lineKind;
		format.StrikethroughWeight = lineWeight;
		format.StrikethroughBrushIndex = ((brush != null) ? Cache.GetBrushIndex(brush) : (-1));
		cYV(characterIndex, characterCount, TextLayoutFormatChangeKinds.Strikethrough, format, num, textLayoutFormatChange);
	}

	public void SetUnderline(int characterIndex, int characterCount, bool hasUnderline)
	{
		LineKind lineKind = (hasUnderline ? LineKind.Solid : LineKind.None);
		SetUnderline(characterIndex, characterCount, lineKind, (Brush)null, TextLineWeight.Single);
	}

	public void SetUnderline(int characterIndex, int characterCount, LineKind lineKind, Color? color, TextLineWeight lineWeight = TextLineWeight.Single)
	{
		SolidColorBrush brush = (color.HasValue ? Cache.GetSolidColorBrush(color.Value) : null);
		SetUnderline(characterIndex, characterCount, lineKind, brush, lineWeight);
	}

	public void SetUnderline(int characterIndex, int characterCount, LineKind lineKind, Brush brush, TextLineWeight lineWeight = TextLineWeight.Single)
	{
		tY5(characterIndex, characterCount);
		if (nY8())
		{
			NYE();
		}
		int num = HYH(characterIndex);
		TextLayoutFormatChange textLayoutFormatChange = wIc[(num >= 0) ? num : Math.Max(0, ~num - 1)];
		TextLayoutFormat format = textLayoutFormatChange.Format;
		format.UnderlineKind = lineKind;
		format.UnderlineWeight = lineWeight;
		format.UnderlineBrushIndex = ((brush != null) ? Cache.GetBrushIndex(brush) : (-1));
		cYV(characterIndex, characterCount, TextLayoutFormatChangeKinds.Underline, format, num, textLayoutFormatChange);
	}

	[SpecialName]
	private bool nY8()
	{
		return lIj != null;
	}

	private void uYR()
	{
		if (!nY8())
		{
			PYM();
		}
	}

	private void NYE()
	{
		jYs();
		lIj = null;
	}

	public override TextSpan<CultureSpecificCharacterBufferRange> GetPrecedingText(int textSourceCharacterIndexLimit)
	{
		return new TextSpan<CultureSpecificCharacterBufferRange>(0, new CultureSpecificCharacterBufferRange(CultureInfo.CurrentUICulture, new CharacterBufferRange(string.Empty, 0, 0)));
	}

	public override int GetTextEffectCharacterIndexFromTextSourceCharacterIndex(int textSourceCharacterIndex)
	{
		return 0;
	}

	public override TextRun GetTextRun(int textSourceCharacterIndex)
	{
		SpacerTextProvider textProviderInternal = TextProviderInternal;
		int length = textProviderInternal.Length;
		if (textSourceCharacterIndex >= length)
		{
			return new TextEndOfParagraph(1);
		}
		int num;
		if (textSourceCharacterIndex == VIB)
		{
			num = kIT + 1;
		}
		else
		{
			num = HYH(textSourceCharacterIndex);
			num = ((num >= 0) ? num : Math.Max(0, ~num - 1));
		}
		TextLayoutFormat format = wIc[num].Format;
		TextLayoutRunProperties textRunProperties = Cache.GetTextRunProperties(format);
		VIB = ((num + 1 < wIc.Count) ? wIc[num + 1].CharacterIndex : length);
		kIT = num;
		if (format.IsSpacer)
		{
			ITextSpacer spacer = textProviderInternal.GetSpacer(textSourceCharacterIndex);
			if (spacer != null)
			{
				return new TextReservedSpace(spacer.Size, spacer.Baseline, textRunProperties);
			}
		}
		int num2 = Math.Min(500, VIB - textSourceCharacterIndex);
		string substring = textProviderInternal.GetSubstring(textSourceCharacterIndex, num2);
		return new TextCharacters(substring, 0, num2, textRunProperties);
	}

	~TextLayout()
	{
		Dispose(disposing: false);
	}

	private void jYs()
	{
		if (lIj == null)
		{
			return;
		}
		ITextLayoutLine[] array = lIj;
		for (int i = 0; i < array.Length; i++)
		{
			TextLayoutLine textLayoutLine = (TextLayoutLine)array[i];
			foreach (TextLine formattedLine in textLayoutLine.FormattedLines)
			{
				formattedLine.Dispose();
			}
		}
	}

	private static bool dYL(ITextProvider P_0)
	{
		if (iIb == null)
		{
			iIb = new Regex(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(117284), RegexOptions.Compiled);
		}
		return iIb.IsMatch(P_0.GetSubstring(0, P_0.Length));
	}

	private void oYd(TextBatch P_0)
	{
		if (JIp.HasValue)
		{
			return;
		}
		if (P_0 != null && P_0.SpaceWidth.HasValue)
		{
			JIp = P_0.SpaceWidth.Value;
			return;
		}
		CanvasDrawCache cache = Cache;
		TextLayoutFormat format = wIc[0].Format;
		TextLayoutRunProperties textRunProperties = cache.GetTextRunProperties(format);
		FormattedText formattedText = new FormattedText(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(106636), CultureInfo.CurrentCulture, FlowDirection.LeftToRight, textRunProperties.Typeface, textRunProperties.FontRenderingEmSize, Brushes.Black, null, TextFormattingMode);
		JIp = (float)formattedText.WidthIncludingTrailingWhitespace;
		if (P_0 != null)
		{
			P_0.SpaceWidth = JIp;
		}
	}

	private TextLayoutLine[] xYN(TextBatch P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(117338));
		}
		oYd(P_0);
		TextLayoutRunProperties textRunProperties = Cache.GetTextRunProperties(wIc[0].Format);
		TextLayoutParagraphProperties paragraphProperties = new TextLayoutParagraphProperties(textRunProperties, SpaceWidth, TabSize);
		bool flag = XIX > TextLayoutWrapping.NoWrap;
		SpacerTextProvider textProviderInternal = TextProviderInternal;
		float num = (flag ? LYG : ((float)((!dYL(textProviderInternal)) ? 5000 : 0)));
		List<TextLayoutLine> list = new List<TextLayoutLine>();
		TextLineBreak previousLineBreak = null;
		int i = 0;
		int length = textProviderInternal.Length;
		TextFormatter orCreateTextFormatter = Cache.GetOrCreateTextFormatter(TextFormattingMode);
		int num2 = 0;
		while (list.Count == 0 || i < length)
		{
			int startCharacterIndex = i;
			TextLine textLine = orCreateTextFormatter.FormatLine(this, i, num, paragraphProperties, previousLineBreak);
			previousLineBreak = textLine.GetTextLineBreak();
			i += textLine.Length;
			if (flag)
			{
				list.Add(new TextLayoutLine(this, num2++, startCharacterIndex, new TextLine[1] { textLine }));
				continue;
			}
			List<TextLine> list2 = new List<TextLine>(2) { textLine };
			for (; i < length; i += textLine.Length)
			{
				textLine = orCreateTextFormatter.FormatLine(this, i, num, paragraphProperties, previousLineBreak);
				list2.Add(textLine);
				previousLineBreak = textLine.GetTextLineBreak();
			}
			list.Add(new TextLayoutLine(this, num2++, startCharacterIndex, list2));
		}
		if (num2 > 0)
		{
			list[num2 - 1].HasHardLineBreak = textProviderInternal.Length > 0 && textProviderInternal.GetSubstring(textProviderInternal.Length - 1, 1) == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(117360);
		}
		return list.ToArray();
	}

	[SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope")]
	private void PYM()
	{
		ICanvas canvas = Cache?.Canvas;
		TextBatch textBatch = ((canvas != null) ? (canvas.CreateTextBatch() as TextBatch) : null) ?? new TextBatch(null);
		using (textBatch)
		{
			ITextLayoutLine[] array = xYN(textBatch);
			lIj = array;
		}
	}

	public void Dispose()
	{
		IsDisposed = true;
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	protected void Dispose(bool disposing)
	{
		if (disposing)
		{
			NYE();
		}
	}

	internal static bool jn2()
	{
		return PnD == null;
	}

	internal static TextLayout hnl()
	{
		return PnD;
	}
}
