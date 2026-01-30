using System;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class SelectBlockLeftAction : EditActionBase
{
	internal static SelectBlockLeftAction uJT;

	public SelectBlockLeftAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandSelectBlockLeftText));
	}

	public override void Execute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		if (view.SyntaxEditor.IsSelectionModeAllowed(SelectionModes.Block))
		{
			view.Selection.SelectRange(new TextPositionRange(view.Selection.StartPosition, view.PositionFinder.GetPositionForCharacterDelta(view.Selection.EndPosition, -1, wrapAtLineTerminators: false, forceVirtualSpace: true)), SelectionModes.Block);
		}
	}

	internal static bool YJt()
	{
		return uJT == null;
	}

	internal static SelectBlockLeftAction XJY()
	{
		return uJT;
	}
}
