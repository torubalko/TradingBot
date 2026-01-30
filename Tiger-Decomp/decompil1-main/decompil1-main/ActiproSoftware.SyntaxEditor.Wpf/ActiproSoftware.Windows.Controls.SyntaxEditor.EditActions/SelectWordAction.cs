using System;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class SelectWordAction : EditActionBase
{
	private static SelectWordAction yRt;

	public SelectWordAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandSelectWordText));
	}

	public override void Execute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		if (view.SyntaxEditor.IsSelectionModeAllowed(SelectionModes.ContinuousStream))
		{
			view.Selection.SelectRange(view.GetCurrentWordTextRange());
		}
	}

	internal static bool BRY()
	{
		return yRt == null;
	}

	internal static SelectWordAction vRb()
	{
		return yRt;
	}
}
