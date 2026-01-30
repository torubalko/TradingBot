using System;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class ScrollPageDownAction : EditActionBase
{
	internal static ScrollPageDownAction w9V;

	public ScrollPageDownAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandScrollPageDownText));
	}

	public override void Execute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		view.Scroller.ScrollVerticallyByLine(view.VisibleViewLines.FullyVisibleCount);
	}

	internal static bool f9I()
	{
		return w9V == null;
	}

	internal static ScrollPageDownAction y9c()
	{
		return w9V;
	}
}
