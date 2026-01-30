using System.Windows.Automation.Peers;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Docking.Automation.Peers;

public class AdvancedTabItemAutomationPeer : TabItemAutomationPeer
{
	internal static AdvancedTabItemAutomationPeer iCf;

	public AdvancedTabItemAutomationPeer(object owner, AdvancedTabControlAutomationPeer tabControlAutomationPeer)
	{
		IVH.CecNqz();
		base._002Ector(owner, tabControlAutomationPeer);
	}

	internal static bool nC8()
	{
		return iCf == null;
	}

	internal static AdvancedTabItemAutomationPeer ECn()
	{
		return iCf;
	}
}
