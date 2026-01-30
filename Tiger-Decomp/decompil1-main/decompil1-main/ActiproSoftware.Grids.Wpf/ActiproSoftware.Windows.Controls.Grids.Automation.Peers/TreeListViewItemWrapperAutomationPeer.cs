using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Grids.Automation.Peers;

public class TreeListViewItemWrapperAutomationPeer : TreeListBoxItemWrapperAutomationPeer
{
	internal static TreeListViewItemWrapperAutomationPeer Bci;

	public TreeListViewItemWrapperAutomationPeer(TreeListViewItem owner)
	{
		fc.taYSkz();
		base._002Ector(owner);
	}

	protected override string GetLocalizedControlTypeCore()
	{
		return xv.hTz(10540);
	}

	internal static bool KcA()
	{
		return Bci == null;
	}

	internal static TreeListViewItemWrapperAutomationPeer ecJ()
	{
		return Bci;
	}
}
