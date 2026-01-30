using System;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class PauseResumeMacroRecordingAction : EditActionBase
{
	private static PauseResumeMacroRecordingAction ykf;

	public override bool CanRecordInMacro => false;

	public PauseResumeMacroRecordingAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandPauseResumeMacroRecordingText));
	}

	public override bool CanExecute(IEditorView view)
	{
		int num = 1;
		bool flag = default(bool);
		while (true)
		{
			int num2 = num;
			do
			{
				switch (num2)
				{
				default:
				{
					if (flag)
					{
						throw new ArgumentNullException(Q7Z.tqM(952));
					}
					MacroRecordingState state = view.SyntaxEditor.MacroRecording.State;
					MacroRecordingState macroRecordingState = state;
					if ((uint)(macroRecordingState - 1) > 1u)
					{
						return false;
					}
					return true;
				}
				case 1:
					break;
				}
				flag = view == null;
				num2 = 0;
			}
			while (aki());
		}
	}

	public override void Execute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		switch (view.SyntaxEditor.MacroRecording.State)
		{
		case MacroRecordingState.Recording:
			view.SyntaxEditor.MacroRecording.Pause();
			break;
		case MacroRecordingState.Paused:
			view.SyntaxEditor.MacroRecording.Resume();
			break;
		}
	}

	internal static bool aki()
	{
		return ykf == null;
	}

	internal static PauseResumeMacroRecordingAction lk2()
	{
		return ykf;
	}
}
