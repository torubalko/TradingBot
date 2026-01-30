using System;
using System.Diagnostics.CodeAnalysis;
using System.Windows.Input;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Outdent")]
public class RemoveTabStopOrOutdentAction : OutdentAction
{
	private static RemoveTabStopOrOutdentAction tZ5;

	public RemoveTabStopOrOutdentAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandRemoveTabStopOrOutdentText));
	}

	public override bool CanExecute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		if (view.SyntaxEditor.AcceptsTab)
		{
			return base.CanExecute(view);
		}
		return true;
	}

	public override void Execute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		if (!view.SyntaxEditor.AcceptsTab)
		{
			view.VisualElement.MoveFocus(new TraversalRequest(FocusNavigationDirection.Previous));
		}
		else
		{
			OutdentAction.znx(view, _0020: false);
		}
	}

	internal static bool uZG()
	{
		return tZ5 == null;
	}

	internal static RemoveTabStopOrOutdentAction OZN()
	{
		return tZ5;
	}
}
