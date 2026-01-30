using System;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class ScrollPageUpAction : EditActionBase
{
	internal static ScrollPageUpAction U9d;

	public ScrollPageUpAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandScrollPageUpText));
	}

	public override void Execute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		view.Scroller.ScrollVerticallyByLine(-view.VisibleViewLines.FullyVisibleCount);
	}

	internal static bool X9T()
	{
		return U9d == null;
	}

	internal static ScrollPageUpAction r9t()
	{
		return U9d;
	}
}
