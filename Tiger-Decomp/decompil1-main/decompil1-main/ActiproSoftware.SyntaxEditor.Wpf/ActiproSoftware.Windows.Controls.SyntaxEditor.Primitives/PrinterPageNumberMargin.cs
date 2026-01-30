using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using System.Windows.Media;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Windows.Controls.Rendering;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Margins;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Primitives;

[ToolboxItem(false)]
public class PrinterPageNumberMargin : PrinterViewMarginBase
{
	internal static PrinterPageNumberMargin V0D;

	public string PageNumberText => SR.GetString(SRName.UIPrinterPageNumberAndCountText, base.View.PageNumber, base.View.PageCount);

	public PrinterPageNumberMargin(IPrinterView view)
	{
		grA.DaB7cz();
		base._002Ector(view, Q7Z.tqM(9482), PrinterViewMarginPlacement.Bottom, null);
		base.DefaultStyleKey = typeof(PrinterPageNumberMargin);
	}

	public override void Draw(TextViewDrawContext context)
	{
		if (context == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(7756));
		}
		ICanvas canvas = context.Canvas;
		Rect bounds = context.Bounds;
		if (bounds.Height != 0.0)
		{
			bounds.X += base.Margin.Left;
			bounds.Y += base.Margin.Top;
			bounds.Width = Math.Max(0.0, bounds.Width - base.Margin.Left - base.Margin.Right);
			bounds.Height = Math.Max(0.0, bounds.Height - base.Margin.Top - base.Margin.Bottom);
			double top = base.BorderThickness.Top;
			if (top > 0.0)
			{
				Color color = ((base.BorderBrush is SolidColorBrush solidColorBrush) ? solidColorBrush.Color : DisplayItemClassificationTypeProvider.hPE);
				context.FillRectangle(new Rect(bounds.X, bounds.Y, bounds.Width, top), color);
				bounds.Y += top;
				bounds.Height = Math.Max(0.0, bounds.Height - top);
			}
			bounds.Y += base.Padding.Top;
			string source = base.FontFamily.Source;
			Color foreground = ((base.Foreground is SolidColorBrush solidColorBrush2) ? solidColorBrush2.Color : DisplayItemClassificationTypeProvider.APc);
			ITextLayout textLayout = canvas.CreateTextLayout(PageNumberText, (float)bounds.Width, source, (float)base.FontSize, foreground);
			if (textLayout.Lines.Count > 0)
			{
				ITextLayoutLine textLayoutLine = textLayout.Lines[0];
				int num = (int)(bounds.X + (bounds.Width - textLayoutLine.Width) / 2.0);
				context.DrawText(new Point(num, bounds.Y), textLayoutLine);
			}
		}
	}

	public override void UpdateVisibility()
	{
		IPrintSettings printSettings = base.View.SyntaxEditor.PrintSettings;
		base.Visibility = ((printSettings == null || !printSettings.IsPageNumberMarginVisible) ? Visibility.Collapsed : Visibility.Visible);
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
		FormattedText formattedText = new FormattedText(PageNumberText, CultureInfo.CurrentCulture, FlowDirection.LeftToRight, typeface, base.FontSize, base.Foreground, null, textFormattingMode);
		double height = formattedText.Height;
		int num = (int)Math.Ceiling(Math.Max(base.MinHeight, base.BorderThickness.Top + base.Padding.Top + height + base.Padding.Bottom));
		return new Size(availableSize.Width, num);
	}

	internal static bool p0B()
	{
		return V0D == null;
	}

	internal static PrinterPageNumberMargin h00()
	{
		return V0D;
	}
}
