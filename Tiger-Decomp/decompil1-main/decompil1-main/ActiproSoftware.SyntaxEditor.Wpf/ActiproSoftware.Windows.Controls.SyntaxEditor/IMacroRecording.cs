using System.Diagnostics.CodeAnalysis;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor;

public interface IMacroRecording
{
	IMacroAction CurrentMacroAction { get; }

	IMacroAction LastMacroAction { get; }

	MacroRecordingState State { get; }

	void Cancel();

	void NotifyEditAction(ITextView view, IEditAction action);

	void Pause();

	void Record();

	[SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", MessageId = "Resume")]
	void Resume();

	[SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", MessageId = "Stop")]
	IMacroAction Stop();
}
