using System.Diagnostics.CodeAnalysis;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt;

[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Intelli")]
public interface IIntelliPromptManager
{
	IIntelliPromptSessionCollection Sessions { get; }

	void CloseAllSessions();

	void CloseSessions(IIntelliPromptSessionType sessionType);

	void RepositionAll();
}
