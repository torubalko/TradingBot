using System;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class RunMacroAction : EditActionBase
{
	internal static RunMacroAction CkV;

	public override bool CanRecordInMacro => false;

	public RunMacroAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandRunMacroText));
	}

	public override bool CanExecute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		return view.SyntaxEditor.MacroRecording.State == MacroRecordingState.Stopped && view.SyntaxEditor.MacroRecording.LastMacroAction != null;
	}

	public override void Execute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		IMacroAction lastMacroAction = view.SyntaxEditor.MacroRecording.LastMacroAction;
		if (lastMacroAction != null)
		{
			view.SyntaxEditor.ActiveView.ExecuteEditAction(lastMacroAction);
		}
	}

	internal static bool CkI()
	{
		return CkV == null;
	}

	internal static RunMacroAction akc()
	{
		return CkV;
	}
}
