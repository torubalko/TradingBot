using System;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class ScrollLineToVisibleBottomAction : EditActionBase
{
	internal static ScrollLineToVisibleBottomAction l9N;

	public ScrollLineToVisibleBottomAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandScrollLineToVisibleBottomText));
	}

	public override void Execute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		TextViewScrollState scrollState = new TextViewScrollState(view.Selection.CaretPosition, TextViewVerticalAnchorPlacement.Bottom, 0.0, 0.0);
		view.Scroller.ScrollTo(scrollState);
	}

	internal static bool S9H()
	{
		return l9N == null;
	}

	internal static ScrollLineToVisibleBottomAction I9j()
	{
		return l9N;
	}
}
