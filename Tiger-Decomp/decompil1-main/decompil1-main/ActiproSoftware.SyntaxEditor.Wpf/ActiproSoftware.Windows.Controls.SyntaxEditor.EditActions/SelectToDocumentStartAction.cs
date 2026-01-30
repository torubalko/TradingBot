using System;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class SelectToDocumentStartAction : EditActionBase
{
	internal static SelectToDocumentStartAction DRL;

	public SelectToDocumentStartAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandSelectToDocumentStartText));
	}

	public override void Execute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		if (view.SyntaxEditor.IsSelectionModeAllowed(view.Selection.Mode))
		{
			view.Selection.EndOffset = 0;
		}
	}

	internal static bool ARg()
	{
		return DRL == null;
	}

	internal static SelectToDocumentStartAction gRA()
	{
		return DRL;
	}
}
