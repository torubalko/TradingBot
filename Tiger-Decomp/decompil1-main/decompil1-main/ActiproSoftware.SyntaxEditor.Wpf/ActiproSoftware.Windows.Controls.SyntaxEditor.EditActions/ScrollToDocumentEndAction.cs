using System;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class ScrollToDocumentEndAction : EditActionBase
{
	internal static ScrollToDocumentEndAction Q9P;

	public ScrollToDocumentEndAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandScrollToDocumentEndText));
	}

	public override void Execute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		TextPosition position = view.CurrentSnapshot.OffsetToPosition(view.CurrentSnapshot.Length);
		view.Scroller.ScrollIntoView(position, scrollToVerticalMiddle: false);
	}

	internal static bool a9o()
	{
		return Q9P == null;
	}

	internal static ScrollToDocumentEndAction K9Q()
	{
		return Q9P;
	}
}
