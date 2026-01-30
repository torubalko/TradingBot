using System;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Primitives;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class ReplaceAction : SearchActionBase
{
	private static ReplaceAction MJa;

	public ReplaceAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandReplaceText));
	}

	public override void Execute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		UpdateSearchOptionsFindTextFromSelection(view);
		if (!view.SyntaxEditor.IsMultiLine)
		{
			return;
		}
		IEditorSearchOptions searchOptions = view.SyntaxEditor.SearchOptions;
		if (searchOptions != null)
		{
			if (view.Selection.IsZeroLength)
			{
				searchOptions.Scope = EditorSearchScope.Document;
			}
			else if (!SearchActionBase.wnG(view))
			{
				searchOptions.Scope = EditorSearchScope.Selection;
			}
		}
		SearchOverlayPane searchOverlayPane = view.OverlayPanes[Q7Z.tqM(9576)] as SearchOverlayPane;
		if (searchOverlayPane != null)
		{
			searchOverlayPane.HasNoSearchResults = false;
			searchOverlayPane.IsReplaceVisible = true;
			searchOverlayPane.SearchOptions = searchOptions;
		}
		else
		{
			searchOverlayPane = view.OverlayPanes.AddSearch(isReplaceVisible: true) as SearchOverlayPane;
		}
		searchOverlayPane?.Activate();
	}

	internal static bool IJL()
	{
		return MJa == null;
	}

	internal static ReplaceAction kJg()
	{
		return MJa;
	}
}
