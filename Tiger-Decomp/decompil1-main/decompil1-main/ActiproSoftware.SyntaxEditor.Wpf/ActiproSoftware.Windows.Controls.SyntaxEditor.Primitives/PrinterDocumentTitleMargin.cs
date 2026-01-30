using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using System.Windows.Media;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.Rendering;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Margins;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Primitives;

[ToolboxItem(false)]
public class PrinterDocumentTitleMargin : PrinterViewMarginBase
{
	private static PrinterDocumentTitleMargin zBU;

	public string DocumentTitle => base.View.SyntaxEditor.PrintSettings?.DocumentTitle ?? string.Empty;

	public PrinterDocumentTitleMargin(IPrinterView view)
	{
		grA.DaB7cz();
		base._002Ector(view, Q7Z.tqM(9450), PrinterViewMarginPlacement.Top, null);
		base.DefaultStyleKey = typeof(PrinterDocumentTitleMargin);
	}

	public override void Draw(TextViewDrawContext context)
	{
		if (context == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(7756));
		}
		ICanvas canvas = context.Canvas;
		Rect bounds = context.Bounds;
		if (bounds.Height == 0.0)
		{
			return;
		}
		bounds.X += base.Margin.Left;
		bounds.Y += base.Margin.Top;
		bounds.Width = Math.Max(0.0, bounds.Width - base.Margin.Left - base.Margin.Right);
		bounds.Height = Math.Max(0.0, bounds.Height - base.Margin.Top - base.Margin.Bottom);
		double bottom = base.BorderThickness.Bottom;
		if (bottom > 0.0)
		{
			Color color = ((base.BorderBrush is SolidColorBrush solidColorBrush) ? solidColorBrush.Color : DisplayItemClassificationTypeProvider.hPE);
			context.FillRectangle(new Rect(bounds.X, bounds.Bottom - bottom, bounds.Width, bottom), color);
			bounds.Height = Math.Max(0.0, bounds.Height - bottom);
		}
		bounds.Y += base.Padding.Top;
		string source = base.FontFamily.Source;
		Color foreground = ((base.Foreground is SolidColorBrush solidColorBrush2) ? solidColorBrush2.Color : DisplayItemClassificationTypeProvider.APc);
		ITextLayout textLayout = canvas.CreateTextLayout(DocumentTitle, (float)bounds.Width, source, (float)base.FontSize, foreground);
		if (textLayout.Lines.Count <= 0)
		{
			return;
		}
		foreach (ITextLayoutLine line in textLayout.Lines)
		{
			int num = (int)(bounds.X + (bounds.Width - line.Width) / 2.0);
			context.DrawText(new Point(num, bounds.Y), line);
			bounds.Y += line.Height;
		}
	}

	public override void UpdateVisibility()
	{
		IPrintSettings printSettings = base.View.SyntaxEditor.PrintSettings;
		if (printSettings == null)
		{
			base.Visibility = Visibility.Collapsed;
		}
		else
		{
			base.Visibility = ((!printSettings.IsDocumentTitleMarginVisible || string.IsNullOrEmpty(DocumentTitle)) ? Visibility.Collapsed : Visibility.Visible);
		}
	}

	protected override Size MeasureOverride(Size availableSize)
	{
		base.MeasureOverride(availableSize);
		if (double.IsPositiveInfinity(availableSize.Width))
		{
			availableSize.Width = 0.0;
		}
		Typeface typeface = new Typeface(base.FontFamily, FontStyles.Normal, FontWeights.Normal, FontStretches.Normal);
		TextFormattingMode textFormattingMode = TextOptions.GetTextFormattingMode(this);
		int num = 0;
		if (!EBe())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		default:
		{
			FormattedText formattedText = new FormattedText(DocumentTitle, CultureInfo.CurrentCulture, FlowDirection.LeftToRight, typeface, base.FontSize, base.Foreground, null, textFormattingMode);
			double height = formattedText.Height;
			int num3 = (int)Math.Ceiling(Math.Max(base.MinHeight, base.Padding.Top + height + base.Padding.Bottom + base.BorderThickness.Bottom));
			return new Size(availableSize.Width, num3);
		}
		}
	}

	internal static bool EBe()
	{
		return zBU == null;
	}

	internal static PrinterDocumentTitleMargin TBz()
	{
		return zBU;
	}
}
