using System;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class CancelMacroRecordingAction : EditActionBase
{
	internal static CancelMacroRecordingAction VkN;

	public override bool CanRecordInMacro => false;

	public CancelMacroRecordingAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandCancelMacroRecordingText));
	}

	public override bool CanExecute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		MacroRecordingState state = view.SyntaxEditor.MacroRecording.State;
		MacroRecordingState macroRecordingState = state;
		if ((uint)(macroRecordingState - 1) <= 1u)
		{
			return true;
		}
		return false;
	}

	public override void Execute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		view.SyntaxEditor.MacroRecording.Cancel();
	}

	internal static bool LkH()
	{
		return VkN == null;
	}

	internal static CancelMacroRecordingAction Ykj()
	{
		return VkN;
	}
}
