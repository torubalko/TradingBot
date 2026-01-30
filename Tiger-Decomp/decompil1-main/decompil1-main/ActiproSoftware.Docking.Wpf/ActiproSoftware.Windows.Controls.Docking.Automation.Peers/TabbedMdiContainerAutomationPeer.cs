using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Docking.Automation.Peers;

public class TabbedMdiContainerAutomationPeer : DockingWindowContainerBaseAutomationPeer
{
	private static TabbedMdiContainerAutomationPeer eCD;

	public TabbedMdiContainerAutomationPeer(TabbedMdiContainer owner)
	{
		IVH.CecNqz();
		base._002Ector(owner);
	}

	protected override string GetLocalizedControlTypeCore()
	{
		return vVK.ssH(24088);
	}

	internal static bool CCE()
	{
		return eCD == null;
	}

	internal static TabbedMdiContainerAutomationPeer cCk()
	{
		return eCD;
	}
}
