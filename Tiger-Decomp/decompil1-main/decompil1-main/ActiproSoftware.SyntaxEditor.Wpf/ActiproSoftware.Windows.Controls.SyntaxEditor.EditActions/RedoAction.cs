using System;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class RedoAction : EditActionBase
{
	internal static RedoAction OS9;

	public RedoAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandRedoText));
	}

	public override bool CanExecute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		return view.SyntaxEditor.Document.UndoHistory.CanRedo && !view.SyntaxEditor.Document.IsReadOnly;
	}

	public override void Execute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		if (!view.SyntaxEditor.Document.IsReadOnly)
		{
			view.SyntaxEditor.Document.UndoHistory.Redo();
		}
	}

	internal static bool SSJ()
	{
		return OS9 == null;
	}

	internal static RedoAction zSR()
	{
		return OS9;
	}
}
