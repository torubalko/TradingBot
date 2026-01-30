using System;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class UndoAction : EditActionBase
{
	internal static UndoAction ASO;

	public UndoAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandUndoText));
	}

	public override bool CanExecute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		return view.SyntaxEditor.Document.UndoHistory.CanUndo && !view.SyntaxEditor.Document.IsReadOnly;
	}

	public override void Execute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		if (!view.SyntaxEditor.Document.IsReadOnly)
		{
			view.SyntaxEditor.Document.UndoHistory.Undo();
		}
	}

	internal static bool cS1()
	{
		return ASO == null;
	}

	internal static UndoAction MS5()
	{
		return ASO;
	}
}
