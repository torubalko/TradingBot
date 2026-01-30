using System;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class InsertLineBreakAction : EditActionBase
{
	private static InsertLineBreakAction ySU;

	public InsertLineBreakAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandInsertLineBreakText));
	}

	public override bool CanExecute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		return !view.SyntaxEditor.Document.IsReadOnly;
	}

	public override void Execute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		view.ReplaceSelectedText(TextChangeTypes.Enter, Q7Z.tqM(7894), new EditorViewTextChangeOptions(view)
		{
			CanApplyToMultipleSelections = true,
			CheckReadOnly = true,
			VirtualCharacterFill = false
		});
	}

	internal static bool zSe()
	{
		return ySU == null;
	}

	internal static InsertLineBreakAction XSz()
	{
		return ySU;
	}
}
