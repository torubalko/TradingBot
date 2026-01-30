using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Utility;
using ActiproSoftware.Windows.Controls.SyntaxEditor;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Internal;

internal class YAT
{
	private List<Rect> d6b;

	private int P6T;

	private int c6L;

	private bool C6n;

	private static YAT qlY;

	public YAT(bool P_0)
	{
		grA.DaB7cz();
		d6b = new List<Rect>();
		P6T = 0;
		c6L = 0;
		base._002Ector();
		C6n = P_0;
	}

	private void X64(Rect P_0)
	{
		if (C6n)
		{
			for (int i = c6L; i < P6T; i++)
			{
				Rect rect = d6b[i];
				if (rect.Bottom == P_0.Y && rect.X < P_0.Right && rect.Right > P_0.X)
				{
					double num = Math.Max(P_0.X, rect.X);
					double width = Math.Max(0.0, Math.Min(P_0.Right, rect.Right) - num);
					d6b.Add(new Rect(num, P_0.Y, width, 1.0));
				}
			}
		}
		int num2 = (C6n ? 1 : 0);
		d6b.Add(new Rect(P_0.X, P_0.Y + (double)num2, P_0.Width, Math.Max(0.0, P_0.Height - (double)num2)));
	}

	private void w6o()
	{
		c6L = P6T;
		P6T = d6b.Count;
	}

	public static YAT e6j(IEditorView P_0, TextPositionRange P_1, bool P_2, bool P_3)
	{
		if (P_1.IsZeroLength)
		{
			return null;
		}
		P_1.Normalize();
		ITextViewLineCollection visibleViewLines = P_0.VisibleViewLines;
		if (visibleViewLines.Count == 0)
		{
			return null;
		}
		ITextViewLine textViewLine = visibleViewLines[0];
		ITextViewLine textViewLine2 = visibleViewLines[visibleViewLines.Count - 1];
		if (P_1.EndPosition < textViewLine.StartPosition || P_1.StartPosition > textViewLine2.MaxPosition)
		{
			return null;
		}
		Range range = (P_2 ? I66(P_0, P_1) : default(Range));
		YAT yAT = new YAT(P_3);
		ITextViewLine textViewLine3 = ((P_1.StartPosition < textViewLine.StartPosition) ? textViewLine.PreviousLine : null);
		foreach (ITextViewLine item in visibleViewLines)
		{
			if (P_1.EndPosition < item.StartPosition)
			{
				break;
			}
			TextPosition maxPosition = item.MaxPosition;
			if (P_1.StartPosition < maxPosition)
			{
				TextPositionRange positionRange;
				if (P_2)
				{
					positionRange = new TextPositionRange(item.LocationToPosition(range.Min, LocationToPositionAlgorithm.BestFit, forceVirtualSpace: true), item.LocationToPosition(range.Max, LocationToPositionAlgorithm.BestFit, forceVirtualSpace: true));
				}
				else
				{
					TextPosition endPositionIncludingLineTerminator = item.EndPositionIncludingLineTerminator;
					positionRange = new TextPositionRange(TextPosition.Last(item.StartPosition, P_1.StartPosition), TextPosition.First(((item.HasHardLineBreak || item.IsLastLine) && P_1.EndPosition.Line == endPositionIncludingLineTerminator.Line) ? P_1.EndPosition : TextPosition.Last(P_1.StartPosition, endPositionIncludingLineTerminator), P_1.EndPosition));
				}
				foreach (TextBounds textBound in item.GetTextBounds(positionRange))
				{
					Rect rect = textBound.Rect;
					rect.Width = Math.Max(1.0, rect.Width);
					yAT.X64(rect);
				}
				yAT.w6o();
			}
			textViewLine3 = item;
		}
		return yAT;
	}

	public static Rect? B6w(IEditorView P_0, ITextRangeProvider P_1)
	{
		if (P_1 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(193966));
		}
		TextRange normalizedTextRange = P_1.TextRange.NormalizedTextRange;
		if (normalizedTextRange.IsZeroLength)
		{
			return null;
		}
		List<ITextViewLine> list = new List<ITextViewLine>(P_0.VisibleViewLines);
		if (list == null || list.Count == 0)
		{
			return null;
		}
		double num = 2147483647.0;
		double num2 = 0.0;
		foreach (ITextViewLine item in list)
		{
			if (item.EndOffset >= normalizedTextRange.StartOffset && item.StartOffset <= normalizedTextRange.EndOffset)
			{
				Rect textBounds = item.TextBounds;
				num = Math.Min(num, textBounds.Top);
				num2 = Math.Max(num2, textBounds.Bottom);
			}
		}
		if (num >= num2)
		{
			return null;
		}
		return new Rect(0.0, num, 1000000.0, num2 - num);
	}

	public static Range I66(IEditorView P_0, TextPositionRange P_1)
	{
		ITextViewLine viewLine = P_0.GetViewLine(P_1.StartPosition);
		ITextViewLine textViewLine = (P_1.IsZeroLength ? viewLine : P_0.GetViewLine(P_1.EndPosition));
		TextBounds characterBounds = viewLine.GetCharacterBounds(P_1.StartPosition);
		TextBounds textBounds = (P_1.IsZeroLength ? characterBounds : textViewLine.GetCharacterBounds(P_1.EndPosition));
		Range result = new Range((int)Math.Round(characterBounds.IsLeftToRight ? characterBounds.Left : characterBounds.Right, MidpointRounding.AwayFromZero), (int)Math.Round(textBounds.IsLeftToRight ? textBounds.Left : textBounds.Right, MidpointRounding.AwayFromZero));
		result.Normalize();
		return result;
	}

	public void i6H(TextViewDrawContext P_0, double P_1, double P_2, Brush P_3)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(7756));
		}
		if (P_3 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(193994));
		}
		if (d6b.Count == 0)
		{
			return;
		}
		PathGeometry pathGeometry = new PathGeometry();
		pathGeometry.FillRule = FillRule.Nonzero;
		foreach (Rect item in d6b)
		{
			RectangleGeometry geometry = new RectangleGeometry(item);
			pathGeometry.AddGeometry(geometry);
		}
		pathGeometry.Freeze();
		pathGeometry = pathGeometry.GetOutlinedPathGeometry();
		P_0.FillGeometry(new Point(P_1, P_2), pathGeometry, P_3);
	}

	internal static bool Klb()
	{
		return qlY == null;
	}

	internal static YAT Lls()
	{
		return qlY;
	}
}
