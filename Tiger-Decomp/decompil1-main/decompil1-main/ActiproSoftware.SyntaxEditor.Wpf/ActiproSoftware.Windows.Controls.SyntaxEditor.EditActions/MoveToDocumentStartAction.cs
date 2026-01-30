using System;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class MoveToDocumentStartAction : EditActionBase
{
	private static MoveToDocumentStartAction uF9;

	public MoveToDocumentStartAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandMoveToDocumentStartText));
	}

	public override void Execute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		view.Selection.StartOffset = 0;
	}

	internal static bool tFJ()
	{
		return uF9 == null;
	}

	internal static MoveToDocumentStartAction jFR()
	{
		return uF9;
	}
}
