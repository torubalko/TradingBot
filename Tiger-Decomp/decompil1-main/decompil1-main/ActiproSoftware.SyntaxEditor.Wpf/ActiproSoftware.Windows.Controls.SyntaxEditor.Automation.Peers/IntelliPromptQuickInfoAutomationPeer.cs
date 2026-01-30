using System.Diagnostics.CodeAnalysis;
using System.Windows.Automation.Peers;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Primitives;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Automation.Peers;

[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Intelli")]
public class IntelliPromptQuickInfoAutomationPeer : FrameworkElementAutomationPeer
{
	private static IntelliPromptQuickInfoAutomationPeer HO1;

	public IntelliPromptQuickInfoAutomationPeer(IntelliPromptQuickInfo owner)
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
		return Q7Z.tqM(197020);
	}

	internal static bool IO5()
	{
		return HO1 == null;
	}

	internal static IntelliPromptQuickInfoAutomationPeer KOG()
	{
		return HO1;
	}
}
