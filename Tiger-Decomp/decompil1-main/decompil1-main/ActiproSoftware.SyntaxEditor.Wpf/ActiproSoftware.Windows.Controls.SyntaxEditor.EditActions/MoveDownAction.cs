using System;
using System.Collections.Generic;
using System.Linq;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class MoveDownAction : EditActionBase
{
	private static MoveDownAction rF4;

	public MoveDownAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandMoveDownText));
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
		for (int num = array.Length - 1; num >= 0; num--)
		{
			array[num] = new TextPositionRange(positionFinder.GetPositionForLineDelta(array[num].EndPosition, 1, preferredCaretHorizontalLocations[num], forceVirtualSpace: false));
		}
		using (view.Selection.CreateBatch(EditorViewSelectionBatchOptions.NoPreferredCaretHorizontalLocationsUpdate))
		{
			view.Selection.SelectRanges(array);
		}
	}

	internal static bool MFD()
	{
		return rF4 == null;
	}

	internal static MoveDownAction PFB()
	{
		return rF4;
	}
}
