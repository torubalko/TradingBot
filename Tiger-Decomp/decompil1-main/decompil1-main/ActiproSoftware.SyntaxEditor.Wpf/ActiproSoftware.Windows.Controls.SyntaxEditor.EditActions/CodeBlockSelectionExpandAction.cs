using System;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class CodeBlockSelectionExpandAction : EditActionBase
{
	internal static CodeBlockSelectionExpandAction bJR;

	public CodeBlockSelectionExpandAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandCodeBlockSelectionExpandText));
	}

	public override bool CanExecute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		IEditorDocument document = view.SyntaxEditor.Document;
		if (document == null || document.IsReadOnly)
		{
			return false;
		}
		return document.Language != null && document.Language.GetCodeBlockFinder() != null;
	}

	public override void Execute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		view.Selection.CodeBlockExpand();
	}

	internal static bool GJO()
	{
		return bJR == null;
	}

	internal static CodeBlockSelectionExpandAction KJ1()
	{
		return bJR;
	}
}
