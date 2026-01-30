using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Docking.Automation.Peers;

public class ToolWindowAutomationPeer : DockingWindowAutomationPeerBase
{
	private static ToolWindowAutomationPeer kCq;

	public ToolWindowAutomationPeer(ToolWindow owner)
	{
		IVH.CecNqz();
		base._002Ector(owner);
	}

	protected override string GetLocalizedControlTypeCore()
	{
		return vVK.ssH(24132);
	}

	internal static bool HCw()
	{
		return kCq == null;
	}

	internal static ToolWindowAutomationPeer mCg()
	{
		return kCq;
	}
}
