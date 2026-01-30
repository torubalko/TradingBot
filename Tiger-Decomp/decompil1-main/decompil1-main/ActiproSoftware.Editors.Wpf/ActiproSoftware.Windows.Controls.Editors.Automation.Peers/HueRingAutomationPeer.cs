using System.Windows.Automation.Peers;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.Editors.Primitives;

namespace ActiproSoftware.Windows.Controls.Editors.Automation.Peers;

public class HueRingAutomationPeer : FrameworkElementAutomationPeer
{
	internal static HueRingAutomationPeer rAI;

	public HueRingAutomationPeer(HueRing owner)
	{
		awj.QuEwGz();
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
		return QdM.AR8(30138);
	}

	internal static bool wA6()
	{
		return rAI == null;
	}

	internal static HueRingAutomationPeer iAc()
	{
		return rAI;
	}
}
