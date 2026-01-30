using System;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class ToggleMacroRecordingAction : EditActionBase
{
	private static ToggleMacroRecordingAction lkd;

	public override bool CanRecordInMacro => false;

	public ToggleMacroRecordingAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandToggleMacroRecordingText));
	}

	public override void Execute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		if (view.SyntaxEditor.MacroRecording.State != MacroRecordingState.Stopped)
		{
			view.SyntaxEditor.MacroRecording.Stop();
		}
		else
		{
			view.SyntaxEditor.MacroRecording.Record();
		}
	}

	internal static bool hkT()
	{
		return lkd == null;
	}

	internal static ToggleMacroRecordingAction ykt()
	{
		return lkd;
	}
}
