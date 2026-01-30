using System;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class SelectBlockToPreviousWordAction : EditActionBase
{
	private static SelectBlockToPreviousWordAction OJh;

	public SelectBlockToPreviousWordAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandSelectBlockToPreviousWordText));
	}

	public override void Execute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		if (view.SyntaxEditor.IsSelectionModeAllowed(SelectionModes.Block))
		{
			int visibleOffset = view.CollapsedRegionManager.GetVisibleOffset(new TextSnapshotOffset(view.CurrentSnapshot, view.FindPreviousWordStart()), hasFarAffinity: false);
			view.Selection.SelectRange(view.Selection.StartPosition, view.OffsetToPosition(visibleOffset), SelectionModes.Block);
		}
	}

	internal static bool AJ6()
	{
		return OJh == null;
	}

	internal static SelectBlockToPreviousWordAction RJK()
	{
		return OJh;
	}
}
