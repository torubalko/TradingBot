using System;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Primitives;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class FindNextSelectedAction : FindAction
{
	internal static FindNextSelectedAction y9e;

	public FindNextSelectedAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandFindNextSelectedText));
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
				view.Searcher.FindNext(searchOptions);
				return;
			}
		}
		base.Execute(view);
	}

	internal static bool a9z()
	{
		return y9e == null;
	}

	internal static FindNextSelectedAction fJm()
	{
		return y9e;
	}
}
