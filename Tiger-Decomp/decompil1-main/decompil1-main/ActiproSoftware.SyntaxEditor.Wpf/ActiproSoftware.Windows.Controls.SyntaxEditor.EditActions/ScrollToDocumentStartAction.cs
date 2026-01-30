using System;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class ScrollToDocumentStartAction : EditActionBase
{
	private static ScrollToDocumentStartAction P9y;

	public ScrollToDocumentStartAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandScrollToDocumentStartText));
	}

	public override void Execute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		view.Scroller.ScrollIntoView(TextPosition.Zero, scrollToVerticalMiddle: false);
	}

	internal static bool a9h()
	{
		return P9y == null;
	}

	internal static ScrollToDocumentStartAction M96()
	{
		return P9y;
	}
}
