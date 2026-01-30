using System;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class IncrementalSearchAction : EditActionBase
{
	private static IncrementalSearchAction DJn;

	public IncrementalSearchAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandIncrementalSearchText));
	}

	public override void Execute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		if (!view.OverlayPanes.Contains(Q7Z.tqM(9576)))
		{
			view.Searcher.FindNextIncremental(searchUp: false);
		}
	}

	internal static bool TJq()
	{
		return DJn == null;
	}

	internal static IncrementalSearchAction SJx()
	{
		return DJn;
	}
}
