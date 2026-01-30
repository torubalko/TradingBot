using System;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class ScrollLineToVisibleTopAction : EditActionBase
{
	private static ScrollLineToVisibleTopAction V9f;

	public ScrollLineToVisibleTopAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandScrollLineToVisibleTopText));
	}

	public override void Execute(IEditorView view)
	{
		if (view != null)
		{
			TextViewScrollState scrollState = new TextViewScrollState(view.Selection.CaretPosition, TextViewVerticalAnchorPlacement.Top, 0.0, 0.0);
			view.Scroller.ScrollTo(scrollState);
			return;
		}
		throw new ArgumentNullException(Q7Z.tqM(952));
	}

	internal static bool L9i()
	{
		return V9f == null;
	}

	internal static ScrollLineToVisibleTopAction w92()
	{
		return V9f;
	}
}
