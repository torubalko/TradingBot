using System;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class SelectBlockRightAction : EditActionBase
{
	internal static SelectBlockRightAction bJb;

	public SelectBlockRightAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandSelectBlockRightText));
	}

	public override void Execute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		if (view.SyntaxEditor.IsSelectionModeAllowed(SelectionModes.Block))
		{
			view.Selection.SelectRange(new TextPositionRange(view.Selection.StartPosition, view.PositionFinder.GetPositionForCharacterDelta(view.Selection.EndPosition, 1, wrapAtLineTerminators: false, forceVirtualSpace: true)), SelectionModes.Block);
		}
	}

	internal static bool wJs()
	{
		return bJb == null;
	}

	internal static SelectBlockRightAction HJP()
	{
		return bJb;
	}
}
