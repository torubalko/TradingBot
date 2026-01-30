using System.Windows.Automation.Peers;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Docking.Automation.Peers;

public class AdvancedTabItemWrapperAutomationPeer : TabItemWrapperAutomationPeer
{
	private static AdvancedTabItemWrapperAutomationPeer fCA;

	public AdvancedTabItemWrapperAutomationPeer(AdvancedTabItem owner)
	{
		IVH.CecNqz();
		base._002Ector(owner);
	}

	internal static bool ACY()
	{
		return fCA == null;
	}

	internal static AdvancedTabItemWrapperAutomationPeer ICC()
	{
		return fCA;
	}
}
