using System.Diagnostics.CodeAnalysis;
using System.Windows.Automation.Peers;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Primitives;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Automation.Peers;

[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Intelli")]
public class IntelliPromptParameterInfoAutomationPeer : FrameworkElementAutomationPeer
{
	private static IntelliPromptParameterInfoAutomationPeer UOJ;

	public IntelliPromptParameterInfoAutomationPeer(IntelliPromptParameterInfo owner)
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
		return Q7Z.tqM(196960);
	}

	internal static bool JOR()
	{
		return UOJ == null;
	}

	internal static IntelliPromptParameterInfoAutomationPeer JOO()
	{
		return UOJ;
	}
}
