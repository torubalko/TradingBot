using System.Windows.Automation.Peers;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Primitives;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Automation.Peers;

public class EditorRulerMarginAutomationPeer : FrameworkElementAutomationPeer
{
	private static EditorRulerMarginAutomationPeer kOD;

	public EditorRulerMarginAutomationPeer(EditorRulerMargin owner)
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
		return Q7Z.tqM(196698);
	}

	internal static bool MOB()
	{
		return kOD == null;
	}

	internal static EditorRulerMarginAutomationPeer tO0()
	{
		return kOD;
	}
}
