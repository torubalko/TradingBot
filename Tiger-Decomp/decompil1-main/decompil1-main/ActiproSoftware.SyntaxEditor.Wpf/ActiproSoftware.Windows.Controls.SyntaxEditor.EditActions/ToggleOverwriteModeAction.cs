using System;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class ToggleOverwriteModeAction : EditActionBase
{
	private static ToggleOverwriteModeAction kZI;

	public ToggleOverwriteModeAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandToggleOverwriteModeText));
	}

	public override void Execute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		view.SyntaxEditor.IsOverwriteModeActive = !view.SyntaxEditor.IsOverwriteModeActive;
	}

	internal static bool VZc()
	{
		return kZI == null;
	}

	internal static ToggleOverwriteModeAction DZd()
	{
		return kZI;
	}
}
