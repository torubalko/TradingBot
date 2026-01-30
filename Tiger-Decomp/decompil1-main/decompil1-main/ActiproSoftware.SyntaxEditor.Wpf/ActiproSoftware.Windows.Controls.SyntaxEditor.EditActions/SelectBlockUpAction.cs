using System;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class SelectBlockUpAction : EditActionBase
{
	private static SelectBlockUpAction RJC;

	public SelectBlockUpAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandSelectBlockUpText));
	}

	public override void Execute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		if (!view.SyntaxEditor.IsSelectionModeAllowed(SelectionModes.Block))
		{
			return;
		}
		using (view.Selection.CreateBatch(EditorViewSelectionBatchOptions.NoPreferredCaretHorizontalLocationsUpdate))
		{
			double value = view.Selection.GetPreferredCaretHorizontalLocations()[view.Selection.Ranges.PrimaryIndex];
			view.Selection.SelectRange(new TextPositionRange(view.Selection.StartPosition, view.PositionFinder.GetPositionForLineDelta(view.Selection.EndPosition, -1, value, forceVirtualSpace: true)), SelectionModes.Block);
		}
	}

	internal static bool cJr()
	{
		return RJC == null;
	}

	internal static SelectBlockUpAction yJX()
	{
		return RJC;
	}
}
