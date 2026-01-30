using System;
using System.Diagnostics.CodeAnalysis;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "InAction")]
public class ZoomInAction : ZoomActionBase
{
	internal static ZoomInAction AZ8;

	public ZoomInAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandZoomInText));
	}

	public override void Execute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		ZoomActionBase.IncrementZoomLevel(view, 1.0);
	}

	internal static bool fZU()
	{
		return AZ8 == null;
	}

	internal static ZoomInAction sZe()
	{
		return AZ8;
	}
}
