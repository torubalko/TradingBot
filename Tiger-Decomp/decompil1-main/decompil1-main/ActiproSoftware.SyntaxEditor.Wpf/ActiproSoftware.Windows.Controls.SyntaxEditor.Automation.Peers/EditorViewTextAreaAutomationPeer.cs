using System.Windows.Automation.Peers;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Automation.Peers;

public class EditorViewTextAreaAutomationPeer : FrameworkElementAutomationPeer
{
	private static EditorViewTextAreaAutomationPeer vOg;

	internal EditorViewTextAreaAutomationPeer(nR owner)
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
		return Q7Z.tqM(196788);
	}

	protected override string GetLocalizedControlTypeCore()
	{
		return Q7Z.tqM(196828);
	}

	internal static bool TOA()
	{
		return vOg == null;
	}

	internal static EditorViewTextAreaAutomationPeer iOl()
	{
		return vOg;
	}
}
