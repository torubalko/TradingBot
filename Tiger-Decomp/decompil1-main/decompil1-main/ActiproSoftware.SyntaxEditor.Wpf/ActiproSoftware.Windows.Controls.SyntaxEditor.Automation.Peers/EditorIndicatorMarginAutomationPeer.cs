using System.Windows.Automation.Peers;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Primitives;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Automation.Peers;

public class EditorIndicatorMarginAutomationPeer : FrameworkElementAutomationPeer
{
	internal static EditorIndicatorMarginAutomationPeer nRr;

	public EditorIndicatorMarginAutomationPeer(EditorIndicatorMargin owner)
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
		return Q7Z.tqM(196466);
	}

	internal static bool bRX()
	{
		return nRr == null;
	}

	internal static EditorIndicatorMarginAutomationPeer GRE()
	{
		return nRr;
	}
}
