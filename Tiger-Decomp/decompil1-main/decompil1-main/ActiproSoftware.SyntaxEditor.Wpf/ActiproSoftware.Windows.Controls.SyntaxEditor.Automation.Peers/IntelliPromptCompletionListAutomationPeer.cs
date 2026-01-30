using System.Diagnostics.CodeAnalysis;
using System.Windows.Automation.Peers;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Primitives;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Automation.Peers;

[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Intelli")]
public class IntelliPromptCompletionListAutomationPeer : FrameworkElementAutomationPeer
{
	private static IntelliPromptCompletionListAutomationPeer OOZ;

	public IntelliPromptCompletionListAutomationPeer(IntelliPromptCompletionList owner)
	{
		grA.DaB7cz();
		base._002Ector(owner);
	}

	protected override AutomationControlType GetAutomationControlTypeCore()
	{
		return AutomationControlType.Pane;
	}

	protected override string GetClassNameCore()
	{
		return base.Owner.GetType().Name;
	}

	protected override string GetLocalizedControlTypeCore()
	{
		return Q7Z.tqM(196898);
	}

	internal static bool lOF()
	{
		return OOZ == null;
	}

	internal static IntelliPromptCompletionListAutomationPeer CO9()
	{
		return OOZ;
	}
}
