using System.Windows.Automation.Peers;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Grids.Automation.Peers;

public class TreeListViewAutomationPeer : TreeListBoxAutomationPeer
{
	internal static TreeListViewAutomationPeer DcR;

	public TreeListViewAutomationPeer(TreeListView owner)
	{
		fc.taYSkz();
		base._002Ector(owner);
	}

	protected override ItemAutomationPeer CreateItemAutomationPeer(object item)
	{
		return new TreeListViewItemAutomationPeer(item, this);
	}

	protected override string GetLocalizedControlTypeCore()
	{
		return xv.hTz(10472);
	}

	internal static bool KcX()
	{
		return DcR == null;
	}

	internal static TreeListViewAutomationPeer lc9()
	{
		return DcR;
	}
}
