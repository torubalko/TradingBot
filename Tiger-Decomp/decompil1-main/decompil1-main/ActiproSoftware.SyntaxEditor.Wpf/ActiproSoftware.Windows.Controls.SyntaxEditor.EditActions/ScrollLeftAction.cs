using System;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class ScrollLeftAction : EditActionBase
{
	internal static ScrollLeftAction v91;

	public ScrollLeftAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandScrollLeftText));
	}

	public override void Execute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		view.Scroller.ScrollHorizontallyByPixels(0.0 - view.DefaultCharacterWidth);
	}

	internal static bool V95()
	{
		return v91 == null;
	}

	internal static ScrollLeftAction g9G()
	{
		return v91;
	}
}
