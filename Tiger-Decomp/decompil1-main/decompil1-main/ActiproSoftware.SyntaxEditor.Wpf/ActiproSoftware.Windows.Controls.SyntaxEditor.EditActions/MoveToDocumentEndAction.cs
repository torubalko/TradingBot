using System;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class MoveToDocumentEndAction : EditActionBase
{
	internal static MoveToDocumentEndAction FFk;

	public MoveToDocumentEndAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandMoveToDocumentEndText));
	}

	public override void Execute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		view.Selection.StartOffset = view.CurrentSnapshot.Length;
	}

	internal static bool CFZ()
	{
		return FFk == null;
	}

	internal static MoveToDocumentEndAction FFF()
	{
		return FFk;
	}
}
