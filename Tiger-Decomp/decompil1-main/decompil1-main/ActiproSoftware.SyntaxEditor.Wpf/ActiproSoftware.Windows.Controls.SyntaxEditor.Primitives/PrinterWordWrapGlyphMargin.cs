using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Media;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Margins;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Primitives;

[ToolboxItem(false)]
public class PrinterWordWrapGlyphMargin : PrinterViewMarginBase
{
	internal static PrinterWordWrapGlyphMargin Y0W;

	public PrinterWordWrapGlyphMargin(IPrinterView view)
	{
		grA.DaB7cz();
		base._002Ector(view, Q7Z.tqM(8266), PrinterViewMarginPlacement.Right, null);
		base.DefaultStyleKey = typeof(PrinterWordWrapGlyphMargin);
	}

	public override void Draw(TextViewDrawContext context)
	{
		if (context == null)
		{
			int num = 0;
			if (v0k() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			default:
				throw new ArgumentNullException(Q7Z.tqM(7756));
			}
		}
		Rect bounds = context.Bounds;
		if (bounds.Width == 0.0)
		{
			return;
		}
		Brush wordWrapGlyphMarginBackground = context.WordWrapGlyphMarginBackground;
		if (wordWrapGlyphMarginBackground != null)
		{
			context.FillRectangle(bounds, wordWrapGlyphMarginBackground);
		}
		Brush wordWrapGlyphMarginForeground = context.WordWrapGlyphMarginForeground;
		if (wordWrapGlyphMarginForeground == null)
		{
			return;
		}
		ITextViewLineCollection visibleViewLines = base.View.VisibleViewLines;
		int num4 = default(int);
		foreach (ITextViewLine item in visibleViewLines)
		{
			bool flag = !item.HasHardLineBreak && !item.IsLastLine;
			int num3 = 0;
			if (!O0S())
			{
				num3 = num4;
			}
			switch (num3)
			{
			}
			if (flag)
			{
				Rect textBounds = item.TextBounds;
				double y = bounds.Y + textBounds.Y;
				Rect rect = new Rect(bounds.X, y, bounds.Width, textBounds.Height);
				EditorWordWrapGlyphMargin.hQo(context, rect, wordWrapGlyphMarginForeground);
			}
		}
	}

	public override void UpdateVisibility()
	{
		IPrintSettings printSettings = base.View.SyntaxEditor.PrintSettings;
		base.Visibility = ((printSettings == null || !printSettings.IsWordWrapGlyphMarginVisible) ? Visibility.Collapsed : Visibility.Visible);
	}

	internal static bool O0S()
	{
		return Y0W == null;
	}

	internal static PrinterWordWrapGlyphMargin v0k()
	{
		return Y0W;
	}
}
