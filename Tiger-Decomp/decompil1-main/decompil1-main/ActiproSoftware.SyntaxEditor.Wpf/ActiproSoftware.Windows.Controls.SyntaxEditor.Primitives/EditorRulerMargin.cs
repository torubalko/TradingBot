using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Media;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.Rendering;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Automation.Peers;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Margins;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Primitives;

[ToolboxItem(false)]
public class EditorRulerMargin : EditorViewMarginBase
{
	internal static EditorRulerMargin JDz;

	public EditorRulerMargin(IEditorView view)
	{
		grA.DaB7cz();
		base._002Ector(view, Q7Z.tqM(7774), EditorViewMarginPlacement.ScrollableTop, null);
		base.DefaultStyleKey = typeof(EditorRulerMargin);
	}

	public override void Draw(TextViewDrawContext context)
	{
		if (context == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(7756));
		}
		Rect bounds = context.Bounds;
		Brush rulerMarginBackground = context.RulerMarginBackground;
		if (rulerMarginBackground != null)
		{
			context.FillRectangle(bounds, rulerMarginBackground);
		}
		IEditorView view = base.View;
		ICanvas canvas = context.Canvas;
		double defaultCharacterWidth = view.DefaultCharacterWidth;
		Size textAreaSize = view.TextAreaSize;
		Rect textAreaViewportBounds = view.TextAreaViewportBounds;
		double zoomLevel = view.ZoomLevel;
		Color color = TextViewDrawContext.mHT(view.SyntaxEditor.BorderBrush) ?? DisplayItemClassificationTypeProvider.UZ;
		Brush rulerMarginForeground = context.RulerMarginForeground;
		context.FillRectangle(new Rect(bounds.X, bounds.Bottom - 1.0, bounds.Width, 1.0), color);
		FontFamily fontFamily = base.FontFamily;
		string fontFamilyName = ((fontFamily != null) ? fontFamily.Source : view.DefaultFontFamilyName);
		float fontSize = (float)base.FontSize;
		TextFormattingMode textFormattingMode = TextOptions.GetTextFormattingMode(this);
		using IDisposable batch = canvas.CreateTextBatch();
		int num = 0;
		double num2 = (textAreaViewportBounds.X - 1.0) / zoomLevel;
		double num3 = num2 + view.TextAreaPadding.Left - view.ScrollState.HorizontalAmount;
		double num4 = num2 + textAreaSize.Width;
		double top = bounds.Top;
		double num5 = num3;
		while (num5 < num4)
		{
			int num6 = (int)(bounds.Height * 0.75);
			if (num % 10 == 0)
			{
				num6 = (int)(bounds.Height * 0.15000000596046448);
				using ITextLayout textLayout = canvas.CreateTextLayout(num.ToString(CultureInfo.CurrentCulture), 0f, fontFamilyName, fontSize, rulerMarginForeground);
				textLayout.TextFormattingMode = textFormattingMode;
				textLayout.RunTextFormatter(batch);
				ITextLayoutLine line = textLayout.Lines[0];
				context.DrawText(new Point(num5 + 2.0, top), line);
			}
			else if (num % 5 == 0)
			{
				num6 = (int)(bounds.Height * 0.5);
			}
			double num7 = Math.Round(num5, MidpointRounding.AwayFromZero);
			if (num7 > 0.0)
			{
				context.FillRectangle(new Rect(num7, bounds.Y + (double)num6, 1.0, Math.Max(0.0, bounds.Height - (double)num6)), color);
			}
			num5 += defaultCharacterWidth;
			num++;
		}
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		return new EditorRulerMarginAutomationPeer(this);
	}

	public override void UpdateVisibility()
	{
		base.Visibility = ((!base.View.SyntaxEditor.IsRulerMarginVisible) ? Visibility.Collapsed : Visibility.Visible);
	}

	internal static bool XBm()
	{
		return JDz == null;
	}

	internal static EditorRulerMargin FBp()
	{
		return JDz;
	}
}
