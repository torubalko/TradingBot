using System;
using System.Windows;
using ActiproSoftware.Windows.Controls.Rendering;
using ActiproSoftware.Windows.Controls.SyntaxEditor;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Margins;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Primitives;

namespace ActiproSoftware.Internal;

internal class FAc
{
	private TextView KHw;

	internal static FAc kWA;

	public FAc(TextView P_0)
	{
		grA.DaB7cz();
		base._002Ector();
		KHw = P_0;
	}

	private void iHY(TextViewDrawContext P_0)
	{
		if (!(KHw is IEditorView { Margins: { } margins }))
		{
			return;
		}
		double num = 0.0;
		double num2 = 0.0;
		double num3 = 0.0;
		double num4 = 0.0;
		Rect bounds = P_0.Bounds;
		for (int num5 = margins.Count - 1; num5 >= 0; num5--)
		{
			IEditorViewMargin editorViewMargin = margins[num5];
			if (editorViewMargin.Visibility == Visibility.Visible)
			{
				FrameworkElement visualElement = editorViewMargin.VisualElement;
				if (visualElement != null)
				{
					Rect? rect = null;
					switch (editorViewMargin.Placement)
					{
					case EditorViewMarginPlacement.FixedBottom:
						rect = new Rect(bounds.X + num, bounds.Bottom - num4 - visualElement.DesiredSize.Height, Math.Max(0.0, bounds.Width - num - num3), Math.Max(0.0, visualElement.DesiredSize.Height));
						num4 += visualElement.DesiredSize.Height;
						break;
					case EditorViewMarginPlacement.FixedLeft:
						rect = new Rect(bounds.X + num, bounds.Y + num2, Math.Max(0.0, visualElement.DesiredSize.Width), Math.Max(0.0, bounds.Height - num2 - num4));
						num += visualElement.DesiredSize.Width;
						break;
					case EditorViewMarginPlacement.FixedRight:
						rect = new Rect(bounds.Right - num3 - visualElement.DesiredSize.Width, bounds.Y + num2, Math.Max(0.0, visualElement.DesiredSize.Width), Math.Max(0.0, bounds.Height - num2 - num4));
						num3 += visualElement.DesiredSize.Width;
						break;
					case EditorViewMarginPlacement.FixedTop:
						rect = new Rect(bounds.X + num, bounds.Y + num2, Math.Max(0.0, bounds.Width - num - num3), Math.Max(0.0, visualElement.DesiredSize.Height));
						num2 += visualElement.DesiredSize.Height;
						break;
					}
					if (rect.HasValue)
					{
						Rect value = rect.Value;
						value.Intersect(bounds);
						P_0.PushBounds(rect.Value);
						P_0.PushClip(value);
						editorViewMargin.Draw(P_0);
						P_0.PopClip();
						P_0.PopBounds();
					}
				}
			}
		}
	}

	private void HH4(TextViewDrawContext P_0, double P_1)
	{
		if (KHw is IEditorView { Margins: var margins })
		{
			if (margins == null)
			{
				return;
			}
			double num = 0.0;
			double num2 = 0.0;
			double num3 = 0.0;
			double num4 = 0.0;
			Rect rect = KHw.ScrollableContentHostBounds;
			rect = new Rect(P_0.Bounds.X + rect.X / P_1, P_0.Bounds.Y + rect.Y / P_1, rect.Width / P_1, rect.Height / P_1);
			for (int num5 = margins.Count - 1; num5 >= 0; num5--)
			{
				IEditorViewMargin editorViewMargin = margins[num5];
				if (editorViewMargin.Visibility == Visibility.Visible)
				{
					FrameworkElement visualElement = editorViewMargin.VisualElement;
					if (visualElement != null)
					{
						Rect? rect2 = null;
						switch (editorViewMargin.Placement)
						{
						case EditorViewMarginPlacement.ScrollableBottom:
							rect2 = new Rect(rect.X + num, rect.Bottom - num4 - visualElement.DesiredSize.Height, Math.Max(0.0, rect.Width - num - num3), Math.Max(0.0, visualElement.DesiredSize.Height));
							num4 += visualElement.DesiredSize.Height;
							break;
						case EditorViewMarginPlacement.ScrollableLeft:
							rect2 = new Rect(rect.X + num, rect.Y + num2, Math.Max(0.0, visualElement.DesiredSize.Width), Math.Max(0.0, rect.Height - num2 - num4));
							num += visualElement.DesiredSize.Width;
							break;
						case EditorViewMarginPlacement.ScrollableRight:
							rect2 = new Rect(rect.Right - num3 - visualElement.DesiredSize.Width, rect.Y + num2, Math.Max(0.0, visualElement.DesiredSize.Width), Math.Max(0.0, rect.Height - num2 - num4));
							num3 += visualElement.DesiredSize.Width;
							break;
						case EditorViewMarginPlacement.ScrollableTop:
							rect2 = new Rect(rect.X + num, rect.Y + num2, Math.Max(0.0, rect.Width - num - num3), Math.Max(0.0, visualElement.DesiredSize.Height));
							num2 += visualElement.DesiredSize.Height;
							break;
						}
						if (rect2.HasValue)
						{
							Rect value = rect2.Value;
							value.Intersect(rect);
							P_0.PushBounds(rect2.Value);
							P_0.PushClip(value);
							editorViewMargin.Draw(P_0);
							P_0.PopClip();
							P_0.PopBounds();
						}
					}
				}
			}
		}
		else
		{
			if (!(KHw is IPrinterView { Margins: { } margins2 }))
			{
				return;
			}
			double num6 = 0.0;
			double num7 = 0.0;
			double num8 = 0.0;
			double num9 = 0.0;
			Rect rect3 = KHw.ScrollableContentHostBounds;
			rect3 = new Rect(P_0.Bounds.X + rect3.X / P_1, P_0.Bounds.Y + rect3.Y / P_1, rect3.Width / P_1, rect3.Height / P_1);
			for (int num10 = margins2.Count - 1; num10 >= 0; num10--)
			{
				IPrinterViewMargin printerViewMargin = margins2[num10];
				FrameworkElement visualElement2 = printerViewMargin.VisualElement;
				if (visualElement2 != null)
				{
					Rect? rect4 = null;
					switch (printerViewMargin.Placement)
					{
					case PrinterViewMarginPlacement.Bottom:
						rect4 = new Rect(rect3.X + num6, rect3.Bottom - num9 - visualElement2.DesiredSize.Height, Math.Max(0.0, rect3.Width - num6 - num8), Math.Max(0.0, visualElement2.DesiredSize.Height));
						num9 += visualElement2.DesiredSize.Height;
						break;
					case PrinterViewMarginPlacement.Left:
						rect4 = new Rect(rect3.X + num6, rect3.Y + num7, Math.Max(0.0, visualElement2.DesiredSize.Width), Math.Max(0.0, rect3.Height - num7 - num9));
						num6 += visualElement2.DesiredSize.Width;
						break;
					case PrinterViewMarginPlacement.Right:
						rect4 = new Rect(rect3.Right - num8 - visualElement2.DesiredSize.Width, rect3.Y + num7, Math.Max(0.0, visualElement2.DesiredSize.Width), Math.Max(0.0, rect3.Height - num7 - num9));
						num8 += visualElement2.DesiredSize.Width;
						break;
					case PrinterViewMarginPlacement.Top:
						rect4 = new Rect(rect3.X + num6, rect3.Y + num7, Math.Max(0.0, rect3.Width - num6 - num8), Math.Max(0.0, visualElement2.DesiredSize.Height));
						num7 += visualElement2.DesiredSize.Height;
						break;
					}
					if (rect4.HasValue)
					{
						Rect value2 = rect4.Value;
						value2.Intersect(rect3);
						P_0.PushBounds(rect4.Value);
						P_0.PushClip(value2);
						printerViewMargin.Draw(P_0);
						P_0.PopClip();
						P_0.PopBounds();
					}
				}
			}
		}
	}

	private void rHo(TextViewDrawContext P_0)
	{
		nR nR2 = KHw.DAb();
		if (nR2 == null)
		{
			return;
		}
		foreach (MTG item in nR2.WAc())
		{
			item.Draw(P_0);
		}
	}

	internal void KHj(CanvasDrawEventArgs P_0)
	{
		if (P_0 == null)
		{
			return;
		}
		TextViewDrawContext textViewDrawContext = (TextViewDrawContext)P_0.Context;
		int num = 1;
		if (!UWl())
		{
			int num2 = default(int);
			num = num2;
		}
		double zoomLevel = default(double);
		while (true)
		{
			switch (num)
			{
			case 1:
			{
				Rect textAreaViewportBounds = KHw.TextAreaViewportBounds;
				Size textAreaSize = KHw.TextAreaSize;
				zoomLevel = KHw.ZoomLevel;
				ITextViewLineCollection visibleViewLines = KHw.VisibleViewLines;
				double x = textViewDrawContext.Bounds.X + (textAreaViewportBounds.X - KHw.BorderThickness.Left) / zoomLevel;
				double y = textViewDrawContext.Bounds.Y + (textAreaViewportBounds.Y - KHw.BorderThickness.Top) / zoomLevel;
				textViewDrawContext.TextAreaBounds = new Rect(x, y, textAreaSize.Width, textAreaSize.Height);
				textViewDrawContext.FillRectangle(textViewDrawContext.Bounds, textViewDrawContext.PlainTextBackground);
				iHY(textViewDrawContext);
				num = 0;
				if (UWl())
				{
					num = 0;
				}
				break;
			}
			default:
				textViewDrawContext.PushScaleTransform(zoomLevel);
				HH4(textViewDrawContext, zoomLevel);
				textViewDrawContext.PushBounds(textViewDrawContext.TextAreaBounds);
				textViewDrawContext.PushClip(textViewDrawContext.TextAreaBounds);
				rHo(textViewDrawContext);
				textViewDrawContext.PopClip();
				textViewDrawContext.PopBounds();
				textViewDrawContext.PopScaleTransform();
				KHw.OnRendered();
				return;
			}
		}
	}

	internal static bool UWl()
	{
		return kWA == null;
	}

	internal static FAc EWW()
	{
		return kWA;
	}
}
