using System;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class ScrollLineToVisibleMiddleAction : EditActionBase
{
	internal static ScrollLineToVisibleMiddleAction I9M;

	public ScrollLineToVisibleMiddleAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandScrollLineToVisibleMiddleText));
	}

	public override void Execute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		TextViewScrollState scrollState = new TextViewScrollState(view.Selection.CaretPosition, TextViewVerticalAnchorPlacement.Center, 0.0, 0.0);
		view.Scroller.ScrollTo(scrollState);
	}

	internal static bool R93()
	{
		return I9M == null;
	}

	internal static ScrollLineToVisibleMiddleAction b9v()
	{
		return I9M;
	}
}
