using System.Windows.Automation.Peers;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Primitives;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Automation.Peers;

public class EditorLineNumberMarginAutomationPeer : FrameworkElementAutomationPeer
{
	internal static EditorLineNumberMarginAutomationPeer wRw;

	public EditorLineNumberMarginAutomationPeer(EditorLineNumberMargin owner)
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
		return Q7Z.tqM(196502);
	}

	internal static bool oRu()
	{
		return wRw == null;
	}

	internal static EditorLineNumberMarginAutomationPeer ER8()
	{
		return wRw;
	}
}
