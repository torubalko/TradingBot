using System;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class ZoomOutAction : ZoomActionBase
{
	internal static ZoomOutAction EZz;

	public ZoomOutAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandZoomOutText));
	}

	public override void Execute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		ZoomActionBase.IncrementZoomLevel(view, -1.0);
	}

	internal static bool NFm()
	{
		return EZz == null;
	}

	internal static ZoomOutAction kFp()
	{
		return EZz;
	}
}
