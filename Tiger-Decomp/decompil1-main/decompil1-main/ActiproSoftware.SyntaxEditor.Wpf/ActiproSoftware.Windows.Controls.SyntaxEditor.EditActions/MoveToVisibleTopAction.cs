using System;
using System.Linq;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class MoveToVisibleTopAction : EditActionBase
{
	private static MoveToVisibleTopAction xF6;

	public MoveToVisibleTopAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandMoveToVisibleTopText));
	}

	public override void Execute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		ITextViewLine textViewLine = view.VisibleViewLines.FirstOrDefault((ITextViewLine l) => l.Visibility == TextViewLineVisibility.FullyVisible);
		if (textViewLine == null)
		{
			return;
		}
		double x = view.Selection.GetPreferredCaretHorizontalLocations()[view.Selection.Ranges.PrimaryIndex];
		TextPosition position = textViewLine.LocationToPosition(x, LocationToPositionAlgorithm.BestFit);
		using (view.Selection.CreateBatch(EditorViewSelectionBatchOptions.NoPreferredCaretHorizontalLocationsUpdate))
		{
			view.Selection.SelectRange(new TextPositionRange(position), view.Selection.Mode);
		}
	}

	internal static bool bFK()
	{
		return xF6 == null;
	}

	internal static MoveToVisibleTopAction cFC()
	{
		return xF6;
	}
}
