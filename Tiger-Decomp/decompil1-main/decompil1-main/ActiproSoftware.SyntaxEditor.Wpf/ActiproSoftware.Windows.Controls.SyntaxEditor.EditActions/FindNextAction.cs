using System;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class FindNextAction : FindAction
{
	internal static FindNextAction z9u;

	public FindNextAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandFindNextText));
	}

	public override void Execute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		IEditorSearchOptions searchOptions = view.SyntaxEditor.SearchOptions;
		if (searchOptions != null && !string.IsNullOrEmpty(searchOptions.FindText))
		{
			view.Searcher.FindNext(searchOptions);
		}
		else
		{
			base.Execute(view);
		}
	}

	internal static bool Y98()
	{
		return z9u == null;
	}

	internal static FindNextAction b9U()
	{
		return z9u;
	}
}
