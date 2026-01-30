using System;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class FindPreviousAction : FindAction
{
	private static FindPreviousAction xJp;

	public FindPreviousAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandFindPreviousText));
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
			bool searchUp = searchOptions.SearchUp;
			searchOptions.SearchUp = true;
			view.Searcher.FindNext(searchOptions);
			searchOptions.SearchUp = searchUp;
		}
		else
		{
			base.Execute(view);
		}
	}

	internal static bool CJ4()
	{
		return xJp == null;
	}

	internal static FindPreviousAction NJD()
	{
		return xJp;
	}
}
