using System.Windows.Automation.Peers;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Primitives;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Automation.Peers;

public class EditorSelectionMarginAutomationPeer : FrameworkElementAutomationPeer
{
	private static EditorSelectionMarginAutomationPeer nO7;

	public EditorSelectionMarginAutomationPeer(EditorSelectionMargin owner)
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
		return Q7Z.tqM(196726);
	}

	internal static bool YOn()
	{
		return nO7 == null;
	}

	internal static EditorSelectionMarginAutomationPeer UOq()
	{
		return nO7;
	}
}
