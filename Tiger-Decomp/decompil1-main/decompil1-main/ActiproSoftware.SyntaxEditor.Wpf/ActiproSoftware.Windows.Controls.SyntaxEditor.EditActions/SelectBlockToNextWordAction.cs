using System;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class SelectBlockToNextWordAction : EditActionBase
{
	private static SelectBlockToNextWordAction rJo;

	public SelectBlockToNextWordAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandSelectBlockToNextWordText));
	}

	public override void Execute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		if (view.SyntaxEditor.IsSelectionModeAllowed(SelectionModes.Block))
		{
			int visibleOffset = view.CollapsedRegionManager.GetVisibleOffset(new TextSnapshotOffset(view.CurrentSnapshot, view.FindNextWordStart()), hasFarAffinity: true);
			view.Selection.SelectRange(view.Selection.StartPosition, view.OffsetToPosition(visibleOffset), SelectionModes.Block);
		}
	}

	internal static bool HJQ()
	{
		return rJo == null;
	}

	internal static SelectBlockToNextWordAction DJy()
	{
		return rJo;
	}
}
