using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Grids.Automation.Peers;

public class TreeListViewItemAutomationPeer : TreeListBoxItemAutomationPeer
{
	private static TreeListViewItemAutomationPeer vc8;

	public TreeListViewItemAutomationPeer(object item, TreeListViewAutomationPeer itemsControlAutomationPeer)
	{
		fc.taYSkz();
		base._002Ector(item, itemsControlAutomationPeer);
	}

	protected override string GetClassNameCore()
	{
		return xv.hTz(10504);
	}

	protected override string GetLocalizedControlTypeCore()
	{
		return xv.hTz(10540);
	}

	internal static bool hck()
	{
		return vc8 == null;
	}

	internal static TreeListViewItemAutomationPeer ocm()
	{
		return vc8;
	}
}
