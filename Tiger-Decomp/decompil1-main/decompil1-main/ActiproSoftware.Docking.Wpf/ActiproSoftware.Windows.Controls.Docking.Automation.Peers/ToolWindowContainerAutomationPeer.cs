using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Docking.Automation.Peers;

public class ToolWindowContainerAutomationPeer : DockingWindowContainerBaseAutomationPeer
{
	private static ToolWindowContainerAutomationPeer NCi;

	public ToolWindowContainerAutomationPeer(ToolWindowContainer owner)
	{
		IVH.CecNqz();
		base._002Ector(owner);
	}

	protected override string GetLocalizedControlTypeCore()
	{
		return vVK.ssH(24158);
	}

	internal static bool qCZ()
	{
		return NCi == null;
	}

	internal static ToolWindowContainerAutomationPeer dCu()
	{
		return NCi;
	}
}
