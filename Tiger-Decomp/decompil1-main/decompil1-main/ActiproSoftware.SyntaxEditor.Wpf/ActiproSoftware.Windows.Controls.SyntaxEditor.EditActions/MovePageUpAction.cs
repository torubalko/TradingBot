using System;
using System.Collections.Generic;
using System.Linq;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class MovePageUpAction : EditActionBase
{
	internal static MovePageUpAction vFL;

	public MovePageUpAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandMovePageUpText));
	}

	public override void Execute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		TextPositionRange[] array = view.Selection.Ranges.ToArray();
		IList<double> preferredCaretHorizontalLocations = view.Selection.GetPreferredCaretHorizontalLocations();
		ITextPositionFinder positionFinder = view.PositionFinder;
		int fullyVisibleCount = view.VisibleViewLines.FullyVisibleCount;
		view.Scroller.ScrollVerticallyByLine(-fullyVisibleCount);
		for (int num = array.Length - 1; num >= 0; num--)
		{
			array[num] = new TextPositionRange(positionFinder.GetPositionForLineDelta(array[num].EndPosition, -fullyVisibleCount, preferredCaretHorizontalLocations[num], forceVirtualSpace: false));
		}
		using (view.Selection.CreateBatch(EditorViewSelectionBatchOptions.NoPreferredCaretHorizontalLocationsUpdate))
		{
			view.Selection.SelectRanges(array);
		}
	}

	internal static bool PFg()
	{
		return vFL == null;
	}

	internal static MovePageUpAction JFA()
	{
		return vFL;
	}
}
