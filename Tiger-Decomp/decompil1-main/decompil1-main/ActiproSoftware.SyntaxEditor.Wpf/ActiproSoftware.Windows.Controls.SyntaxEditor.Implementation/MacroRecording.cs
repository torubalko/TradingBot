using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

public class MacroRecording : IMacroRecording
{
	private IMacroAction swK;

	private IMacroAction Mwf;

	private MacroRecordingState OwD;

	private SyntaxEditor ewg;

	private static MacroRecording MlJ;

	public IMacroAction CurrentMacroAction => swK;

	public IMacroAction LastMacroAction => Mwf;

	public MacroRecordingState State => OwD;

	public MacroRecording(SyntaxEditor syntaxEditor)
	{
		grA.DaB7cz();
		OwD = MacroRecordingState.Stopped;
		base._002Ector();
		ewg = syntaxEditor;
	}

	private void KwX()
	{
		if (ewg != null)
		{
			ewg.Gx3();
		}
	}

	public void Cancel()
	{
		if (OwD != MacroRecordingState.Stopped)
		{
			swK = null;
			OwD = MacroRecordingState.Stopped;
			KwX();
		}
	}

	protected virtual IMacroAction CreateMacroAction()
	{
		return new MacroAction();
	}

	public virtual void NotifyEditAction(ITextView view, IEditAction action)
	{
		if (OwD == MacroRecordingState.Recording && action != null && action.CanRecordInMacro)
		{
			swK.Add(action);
		}
	}

	public void Pause()
	{
		if (OwD == MacroRecordingState.Recording)
		{
			OwD = MacroRecordingState.Paused;
			KwX();
		}
	}

	public void Record()
	{
		swK = CreateMacroAction();
		if (swK != null)
		{
			OwD = MacroRecordingState.Recording;
			KwX();
		}
	}

	public void Resume()
	{
		if (OwD == MacroRecordingState.Paused)
		{
			OwD = MacroRecordingState.Recording;
			KwX();
		}
	}

	public IMacroAction Stop()
	{
		if (OwD == MacroRecordingState.Stopped)
		{
			return null;
		}
		bool flag = !swK.IsEmpty;
		if (flag)
		{
			Mwf = swK;
		}
		swK = null;
		OwD = MacroRecordingState.Stopped;
		KwX();
		return flag ? Mwf : null;
	}

	internal static bool vlR()
	{
		return MlJ == null;
	}

	internal static MacroRecording TlO()
	{
		return MlJ;
	}
}
