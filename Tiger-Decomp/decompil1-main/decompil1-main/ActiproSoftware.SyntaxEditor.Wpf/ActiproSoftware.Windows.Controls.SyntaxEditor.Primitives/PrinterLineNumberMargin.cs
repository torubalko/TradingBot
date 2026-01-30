using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using System.Windows.Media;
using ActiproSoftware.Internal;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.Rendering;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Highlighting;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Margins;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Primitives;

[ToolboxItem(false)]
public class PrinterLineNumberMargin : PrinterViewMarginBase
{
	private static PrinterLineNumberMargin n0m;

	public PrinterLineNumberMargin(IPrinterView view)
	{
		grA.DaB7cz();
		base._002Ector(view, Q7Z.tqM(7686), PrinterViewMarginPlacement.Left, null);
		base.DefaultStyleKey = typeof(PrinterLineNumberMargin);
	}

	private void EeI(out string P_0, out float P_1, out bool P_2, out bool P_3)
	{
		P_0 = null;
		P_1 = 0f;
		P_2 = false;
		P_3 = false;
		IPrinterView view = base.View;
		IHighlightingStyle highlightingStyle = view.HighlightingStyleRegistry?[cT.LineNumbers];
		P_0 = view.SyntaxEditor.LineNumberMarginFontFamily?.Source;
		P_1 = (float)view.SyntaxEditor.LineNumberMarginFontSize;
		if (string.IsNullOrEmpty(P_0) && highlightingStyle != null)
		{
			P_0 = highlightingStyle.FontFamilyName;
		}
		if (string.IsNullOrEmpty(P_0))
		{
			P_0 = view.DefaultFontFamilyName;
		}
		if (P_1 == 0f && highlightingStyle != null)
		{
			P_1 = highlightingStyle.FontSize;
		}
		if (P_1 == 0f)
		{
			P_1 = view.DefaultFontSize;
		}
	}

	private ITextViewLineNumberProvider Ke5()
	{
		ITextViewLineNumberProvider textViewLineNumberProvider = null;
		ICodeDocument document = base.View.SyntaxEditor.Document;
		if (document != null)
		{
			ISyntaxLanguage language = document.Language;
			if (language != null)
			{
				textViewLineNumberProvider = language.GetTextViewLineNumberProvider();
			}
		}
		return textViewLineNumberProvider ?? DefaultTextViewLineNumberProvider.fY4();
	}

	public override void Draw(TextViewDrawContext context)
	{
		if (context == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(7756));
		}
		ICanvas canvas = context.Canvas;
		Rect bounds = context.Bounds;
		bool flag = bounds.Width == 0.0;
		int num = 1;
		if (P04() != null)
		{
			goto IL_0005;
		}
		goto IL_0009;
		IL_0009:
		double right = default(double);
		bool flag2 = default(bool);
		Brush lineNumberMarginForeground = default(Brush);
		TextFormattingMode textFormattingMode = default(TextFormattingMode);
		int num3 = default(int);
		do
		{
			switch (num)
			{
			case 1:
			{
				if (flag)
				{
					return;
				}
				right = base.Padding.Right;
				Brush lineNumberMarginBackground = context.LineNumberMarginBackground;
				if (lineNumberMarginBackground != null)
				{
					context.FillRectangle(bounds, lineNumberMarginBackground);
				}
				break;
			}
			default:
			{
				if (!flag2)
				{
					return;
				}
				using IDisposable batch = canvas.CreateTextBatch();
				EeI(out var fontFamilyName, out var fontSize, out var flag3, out var flag4);
				ITextViewLineNumberProvider textViewLineNumberProvider = Ke5();
				ITextViewLineCollection visibleViewLines = base.View.VisibleViewLines;
				foreach (ITextViewLine item in visibleViewLines)
				{
					string lineNumberText = textViewLineNumberProvider.GetLineNumberText(item);
					if (string.IsNullOrEmpty(lineNumberText))
					{
						continue;
					}
					using ITextLayout textLayout = canvas.CreateTextLayout(lineNumberText, 0f, fontFamilyName, fontSize, lineNumberMarginForeground);
					textLayout.TextFormattingMode = textFormattingMode;
					bool flag5 = flag3;
					int num2 = 0;
					if (!b0p())
					{
						num2 = num3;
					}
					switch (num2)
					{
					}
					if (flag5)
					{
						textLayout.SetFontWeight(0, lineNumberText.Length, FontWeights.Bold);
					}
					if (flag4)
					{
						textLayout.SetFontStyle(0, lineNumberText.Length, FontStyles.Italic);
					}
					textLayout.RunTextFormatter(batch);
					ITextLayoutLine textLayoutLine = textLayout.Lines[0];
					double y = bounds.Y + item.TextBounds.Y + (double)(int)Math.Round(item.Baseline - textLayoutLine.Baseline, MidpointRounding.AwayFromZero);
					context.DrawText(new Point(bounds.Right - textLayoutLine.Width - right, y), textLayoutLine);
				}
				return;
			}
			}
			lineNumberMarginForeground = context.LineNumberMarginForeground;
			textFormattingMode = TextOptions.GetTextFormattingMode(this);
			flag2 = lineNumberMarginForeground != null;
			num = 0;
		}
		while (b0p());
		goto IL_0005;
		IL_0005:
		int num4 = default(int);
		num = num4;
		goto IL_0009;
	}

	public override void UpdateVisibility()
	{
		IPrintSettings printSettings = base.View.SyntaxEditor.PrintSettings;
		base.Visibility = ((printSettings == null || !printSettings.IsLineNumberMarginVisible) ? Visibility.Collapsed : Visibility.Visible);
	}

	protected override Size MeasureOverride(Size availableSize)
	{
		base.MeasureOverride(availableSize);
		if (double.IsPositiveInfinity(availableSize.Height))
		{
			availableSize.Height = 0.0;
		}
		ITextViewLineNumberProvider textViewLineNumberProvider = Ke5();
		int num = 0;
		if (!b0p())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		default:
		{
			string largestLineNumberText = textViewLineNumberProvider.GetLargestLineNumberText(base.View);
			EeI(out var familyName, out var num3, out var flag, out var flag2);
			Typeface typeface = new Typeface(new FontFamily(familyName), flag2 ? FontStyles.Italic : FontStyles.Normal, flag ? FontWeights.Bold : FontWeights.Normal, FontStretches.Normal);
			TextFormattingMode textFormattingMode = TextOptions.GetTextFormattingMode(this);
			FormattedText formattedText = new FormattedText(largestLineNumberText, CultureInfo.CurrentCulture, FlowDirection.LeftToRight, typeface, num3, base.Foreground, null, textFormattingMode);
			double widthIncludingTrailingWhitespace = formattedText.WidthIncludingTrailingWhitespace;
			int num4 = (int)Math.Ceiling(Math.Max(base.MinWidth, base.Padding.Left + widthIncludingTrailingWhitespace + base.Padding.Right));
			return new Size(num4, availableSize.Height);
		}
		}
	}

	internal static bool b0p()
	{
		return n0m == null;
	}

	internal static PrinterLineNumberMargin P04()
	{
		return n0m;
	}
}
