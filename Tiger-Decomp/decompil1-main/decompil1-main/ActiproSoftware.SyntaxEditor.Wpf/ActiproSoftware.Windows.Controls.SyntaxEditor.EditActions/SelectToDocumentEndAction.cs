using System;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class SelectToDocumentEndAction : EditActionBase
{
	internal static SelectToDocumentEndAction URq;

	public SelectToDocumentEndAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandSelectToDocumentEndText));
	}

	public override void Execute(IEditorView view)
	{
		if (view != null)
		{
			if (view.SyntaxEditor.IsSelectionModeAllowed(view.Selection.Mode))
			{
				view.Selection.EndOffset = view.CurrentSnapshot.Length;
			}
			return;
		}
		throw new ArgumentNullException(Q7Z.tqM(952));
	}

	internal static bool zRx()
	{
		return URq == null;
	}

	internal static SelectToDocumentEndAction RRa()
	{
		return URq;
	}
}
