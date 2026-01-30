using System;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class ScrollRightAction : EditActionBase
{
	private static ScrollRightAction V9Y;

	public ScrollRightAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandScrollRightText));
	}

	public override void Execute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		view.Scroller.ScrollHorizontallyByPixels(view.DefaultCharacterWidth);
	}

	internal static bool h9b()
	{
		return V9Y == null;
	}

	internal static ScrollRightAction Q9s()
	{
		return V9Y;
	}
}
