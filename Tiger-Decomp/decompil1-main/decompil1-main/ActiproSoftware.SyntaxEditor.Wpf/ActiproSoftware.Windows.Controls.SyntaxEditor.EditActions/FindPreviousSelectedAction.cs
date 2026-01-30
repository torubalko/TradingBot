using System;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Primitives;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class FindPreviousSelectedAction : FindAction
{
	private static FindPreviousSelectedAction NJB;

	public FindPreviousSelectedAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandFindPreviousSelectedText));
	}

	public override void Execute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		if (UpdateSearchOptionsFindTextFromSelection(view))
		{
			IEditorSearchOptions searchOptions = view.SyntaxEditor.SearchOptions;
			if (view.OverlayPanes[Q7Z.tqM(9576)] is SearchOverlayPane searchOverlayPane)
			{
				searchOverlayPane.HasNoSearchResults = false;
			}
			else
			{
				if (searchOptions != null)
				{
					searchOptions.Scope = EditorSearchScope.Document;
				}
				view.OverlayPanes.AddSearch(isReplaceVisible: false);
			}
			if (searchOptions != null && !string.IsNullOrEmpty(searchOptions.FindText))
			{
				bool searchUp = searchOptions.SearchUp;
				searchOptions.SearchUp = true;
				view.Searcher.FindNext(searchOptions);
				searchOptions.SearchUp = searchUp;
				return;
			}
		}
		base.Execute(view);
	}

	internal static bool sJ0()
	{
		return NJB == null;
	}

	internal static FindPreviousSelectedAction FJ7()
	{
		return NJB;
	}
}
