using System.Windows.Media;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Adornments;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Internal;

internal class PAQ : LAu
{
	private static PAQ tle;

	public PAQ()
	{
		grA.DaB7cz();
		base._002Ector(AdornmentLayerDefinitions.Selection.Key, AdornmentLayerDefinitions.Selection.Orderings);
	}

	private static void W6p(TextViewDrawContext P_0, ITextPositionRangeCollection P_1, double P_2, double P_3, ITextViewLineCollection P_4, bool P_5)
	{
		if (!(P_0.View is IEditorView editorView) || P_4.Count == 0)
		{
			return;
		}
		int num = P_1.BinarySearch(P_4[0].StartPosition);
		if (num < 0)
		{
			num = ~num;
		}
		if (num >= P_1.Count)
		{
			return;
		}
		bool flag = P_1.Count > 1;
		while (num < P_1.Count)
		{
			TextPositionRange normalizedTextPositionRange = P_1[num++].NormalizedTextPositionRange;
			if (!normalizedTextPositionRange.IsZeroLength)
			{
				bool flag2 = editorView.Selection.Mode == SelectionModes.Block;
				YAT yAT = YAT.e6j(editorView, normalizedTextPositionRange, flag2, flag);
				if (yAT != null)
				{
					Brush brush = (P_5 ? P_0.SelectedTextBackground : P_0.InactiveSelectedTextBackground);
					yAT.i6H(P_0, P_2, P_3, brush);
				}
			}
		}
	}

	public override void Draw(TextViewDrawContext P_0)
	{
		if (P_0 != null && P_0.View is IEditorView { ContainsFocus: var containsFocus } editorView && (containsFocus || editorView.SyntaxEditor.IsMultiLine))
		{
			ITextViewLineCollection visibleViewLines = editorView.VisibleViewLines;
			if (visibleViewLines != null)
			{
				double x = P_0.TextAreaBounds.X;
				double y = P_0.TextAreaBounds.Y;
				double num = 0.0 - editorView.ScrollState.HorizontalAmount;
				W6p(P_0, editorView.Selection.Ranges, x + num, y, visibleViewLines, containsFocus);
			}
		}
	}

	internal static bool ilz()
	{
		return tle == null;
	}

	internal static PAQ eWm()
	{
		return tle;
	}
}
