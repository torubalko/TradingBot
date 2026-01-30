using System;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class ResetZoomLevelAction : ZoomActionBase
{
	private static ResetZoomLevelAction pZH;

	public ResetZoomLevelAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandResetZoomLevelText));
	}

	public override void Execute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		view.SyntaxEditor.ZoomLevel = 1.0;
	}

	internal static bool KZj()
	{
		return pZH == null;
	}

	internal static ResetZoomLevelAction CZM()
	{
		return pZH;
	}
}
