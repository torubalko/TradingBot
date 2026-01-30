using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Docking.Automation.Peers;

public class DocumentWindowAutomationPeer : DockingWindowAutomationPeerBase
{
	internal static DocumentWindowAutomationPeer ACv;

	public DocumentWindowAutomationPeer(DocumentWindow owner)
	{
		IVH.CecNqz();
		base._002Ector(owner);
	}

	protected override string GetLocalizedControlTypeCore()
	{
		return vVK.ssH(23896);
	}

	internal static bool HCN()
	{
		return ACv == null;
	}

	internal static DocumentWindowAutomationPeer UCS()
	{
		return ACv;
	}
}
