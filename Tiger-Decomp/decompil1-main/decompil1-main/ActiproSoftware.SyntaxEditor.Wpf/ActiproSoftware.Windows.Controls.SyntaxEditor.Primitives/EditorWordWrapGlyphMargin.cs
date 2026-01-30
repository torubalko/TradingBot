using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Media;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Automation.Peers;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Margins;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Primitives;

[ToolboxItem(false)]
public class EditorWordWrapGlyphMargin : EditorViewMarginBase
{
	private static EditorWordWrapGlyphMargin bBj;

	public EditorWordWrapGlyphMargin(IEditorView view)
	{
		grA.DaB7cz();
		base._002Ector(view, Q7Z.tqM(8266), EditorViewMarginPlacement.ScrollableRight, null);
		base.DefaultStyleKey = typeof(EditorWordWrapGlyphMargin);
	}

	public override void Draw(TextViewDrawContext context)
	{
		if (context == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(7756));
		}
		Rect bounds = context.Bounds;
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
		foreach (ITextViewLine item in visibleViewLines)
		{
			if (!item.HasHardLineBreak && !item.IsLastLine)
			{
				Rect textBounds = item.TextBounds;
				double y = bounds.Y + textBounds.Y;
				Rect rect = new Rect(bounds.X, y, bounds.Width, textBounds.Height);
				hQo(context, rect, wordWrapGlyphMarginForeground);
			}
		}
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		return new EditorWordWrapGlyphMarginAutomationPeer(this);
	}

	public override void UpdateVisibility()
	{
		base.Visibility = ((!base.View.SyntaxEditor.IsWordWrapGlyphMarginVisible) ? Visibility.Collapsed : Visibility.Visible);
	}

	internal static void hQo(TextViewDrawContext P_0, Rect P_1, Brush P_2)
	{
		Geometry geometry = Geometry.Parse(Q7Z.tqM(8300));
		Geometry geometry2 = Geometry.Parse(Q7Z.tqM(8462));
		Size size = new Size(9.0, 7.0);
		double x = P_1.X + (double)(int)((P_1.Width - size.Width) / 2.0);
		double y = P_1.Y + (double)(int)((P_1.Height - size.Height) / 2.0) + 1.0;
		P_0.DrawGeometry(new Point(x, y), geometry, P_0.JbG());
		P_0.FillGeometry(new Point(x, y), geometry2, P_2);
	}

	internal static bool GBM()
	{
		return bBj == null;
	}

	internal static EditorWordWrapGlyphMargin jB3()
	{
		return bBj;
	}
}
