using System;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class ReverseIncrementalSearchAction : EditActionBase
{
	internal static ReverseIncrementalSearchAction UJA;

	public ReverseIncrementalSearchAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandReverseIncrementalSearchText));
	}

	public override void Execute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		if (!view.OverlayPanes.Contains(Q7Z.tqM(9576)))
		{
			view.Searcher.FindNextIncremental(searchUp: true);
		}
	}

	internal static bool XJl()
	{
		return UJA == null;
	}

	internal static ReverseIncrementalSearchAction mJW()
	{
		return UJA;
	}
}
