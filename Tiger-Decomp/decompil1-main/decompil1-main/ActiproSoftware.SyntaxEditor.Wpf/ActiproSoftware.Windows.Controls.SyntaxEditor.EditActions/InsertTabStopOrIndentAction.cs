using System;
using System.Windows.Input;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class InsertTabStopOrIndentAction : IndentAction
{
	private static InsertTabStopOrIndentAction UZn;

	public InsertTabStopOrIndentAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandInsertTabStopOrIndentText));
	}

	public override bool CanExecute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		if (!view.SyntaxEditor.AcceptsTab)
		{
			return true;
		}
		return base.CanExecute(view);
	}

	public override void Execute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		if (view.SyntaxEditor.AcceptsTab)
		{
			IndentAction.Dnc(view, _0020: false);
		}
		else
		{
			view.VisualElement.MoveFocus(new TraversalRequest(FocusNavigationDirection.Next));
		}
	}

	internal static bool tZq()
	{
		return UZn == null;
	}

	internal static InsertTabStopOrIndentAction SZx()
	{
		return UZn;
	}
}
