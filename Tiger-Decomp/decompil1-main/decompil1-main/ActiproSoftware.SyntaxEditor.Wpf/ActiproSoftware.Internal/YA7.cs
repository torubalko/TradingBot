using System;
using System.Collections.Generic;
using System.Windows;
using ActiproSoftware.Windows.Controls.SyntaxEditor;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Adornments;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Highlighting;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Internal;

internal class YA7 : LAu
{
	internal static YA7 Ely;

	public YA7()
	{
		grA.DaB7cz();
		base._002Ector(AdornmentLayerDefinitions.TextBackground.Key, AdornmentLayerDefinitions.TextBackground.Orderings);
	}

	private static void F60(TextViewDrawContext P_0, Rect P_1, IHighlightingStyle P_2)
	{
		int num = 2;
		bool hasBackground = default(bool);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 2:
					hasBackground = P_2.HasBackground;
					num2 = 1;
					if (Vl6() == null)
					{
						continue;
					}
					break;
				case 1:
				{
					bool hasBorder = P_2.HasBorder;
					if (P_2.BackgroundSpansVirtualSpace && (hasBackground || hasBorder))
					{
						P_1.Width += Math.Max(0.0, P_0.Bounds.Right - P_1.Right + 2.0);
					}
					if (P_2.BorderCornerKind == HighlightingStyleBorderCornerKind.Rounded)
					{
						if (hasBackground)
						{
							P_0.FillRoundedRectangle(P_1, 1.75f, P_2.Background.Value);
						}
						if (hasBorder)
						{
							P_0.DrawRoundedRectangle(P_1, 1.75f, P_2.BorderColor.Value, P_2.BorderKind, 1f);
						}
						return;
					}
					if (hasBackground)
					{
						P_0.FillRectangle(P_1, P_2.Background.Value);
					}
					if (hasBorder)
					{
						P_0.DrawRectangle(P_1, P_2.BorderColor.Value, P_2.BorderKind, 1f);
						num2 = 0;
						if (Vl6() == null)
						{
							continue;
						}
						break;
					}
					return;
				}
				case 0:
					return;
				}
				break;
			}
		}
	}

	private static void I6B(TextViewDrawContext P_0, double P_1, double P_2, ITextViewLineCollection P_3)
	{
		foreach (DAp item in P_3)
		{
			IEnumerable<CAM> enumerable = item.cbl();
			foreach (CAM item2 in enumerable)
			{
				IHighlightingStyle highlightingStyle = item2.gHG();
				Rect? rect = null;
				IEnumerable<TextBounds> textBounds = item.GetTextBounds(item2.iHf());
				foreach (TextBounds item3 in textBounds)
				{
					if (!(item3.Width > 0.0))
					{
						continue;
					}
					Rect rect2 = item3.Rect;
					rect2.X += P_1;
					rect2.Y += P_2;
					rect2 = rect2.h0e();
					if (!P_0.ClipBounds.IntersectsWith(rect2))
					{
						continue;
					}
					if (rect.HasValue)
					{
						if (rect.Value.Right == rect2.X && rect.Value.Y == rect2.Y && rect.Value.Height == rect2.Height)
						{
							rect = new Rect(rect.Value.X, rect2.Y, rect.Value.Width + rect2.Width, rect2.Height);
							continue;
						}
						F60(P_0, rect.Value, highlightingStyle);
						rect = rect2;
					}
					else
					{
						rect = rect2;
					}
				}
				if (rect.HasValue)
				{
					F60(P_0, rect.Value, highlightingStyle);
				}
			}
		}
	}

	public override void Draw(TextViewDrawContext P_0)
	{
		if (P_0 == null)
		{
			return;
		}
		ITextView view = P_0.View;
		if (view == null)
		{
			return;
		}
		ITextViewLineCollection visibleViewLines = view.VisibleViewLines;
		if (visibleViewLines != null)
		{
			double x = P_0.TextAreaBounds.X;
			double y = P_0.TextAreaBounds.Y;
			double num = 0.0 - view.ScrollState.HorizontalAmount;
			int num2 = 0;
			if (Vl6() != null)
			{
				int num3 = default(int);
				num2 = num3;
			}
			switch (num2)
			{
			}
			I6B(P_0, x + num, y, visibleViewLines);
		}
	}

	internal static bool llh()
	{
		return Ely == null;
	}

	internal static YA7 Vl6()
	{
		return Ely;
	}
}
