using System;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Primitives;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class FindAction : SearchActionBase
{
	private static FindAction K9X;

	public FindAction()
	{
		grA.DaB7cz();
		this._002Ector(SR.GetString(SRName.UICommandFindText));
	}

	protected FindAction(string text)
	{
		grA.DaB7cz();
		base._002Ector(text);
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
		bool flag = default(bool);
		int num;
		if (searchOptions != null)
		{
			if (!view.Selection.IsZeroLength)
			{
				flag = !SearchActionBase.wnG(view);
				num = 1;
				if (B9w() != null)
				{
					num = 1;
				}
				goto IL_0009;
			}
			searchOptions.Scope = EditorSearchScope.Document;
		}
		goto IL_01ae;
		IL_0009:
		switch (num)
		{
		case 1:
			break;
		default:
			goto IL_013c;
		}
		if (flag)
		{
			searchOptions.Scope = EditorSearchScope.Selection;
		}
		goto IL_01ae;
		IL_013c:
		SearchOverlayPane searchOverlayPane = default(SearchOverlayPane);
		searchOverlayPane?.Activate();
		return;
		IL_01ae:
		searchOverlayPane = view.OverlayPanes[Q7Z.tqM(9576)] as SearchOverlayPane;
		if (searchOverlayPane == null)
		{
			searchOverlayPane = view.OverlayPanes.AddSearch(isReplaceVisible: false) as SearchOverlayPane;
			num = 0;
			if (!q9E())
			{
				int num2 = default(int);
				num = num2;
			}
			goto IL_0009;
		}
		searchOverlayPane.HasNoSearchResults = false;
		searchOverlayPane.IsReplaceVisible = false;
		searchOverlayPane.SearchOptions = searchOptions;
		goto IL_013c;
	}

	internal static bool q9E()
	{
		return K9X == null;
	}

	internal static FindAction B9w()
	{
		return K9X;
	}
}
