using System.Windows.Automation.Peers;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Grids.Automation.Peers;

public class TreeListBoxAutomationPeer : ItemsControlAutomationPeer
{
	internal static TreeListBoxAutomationPeer Dsb;

	public TreeListBoxAutomationPeer(TreeListBox owner)
	{
		fc.taYSkz();
		base._002Ector(owner);
	}

	protected override ItemAutomationPeer CreateItemAutomationPeer(object item)
	{
		return new TreeListBoxItemAutomationPeer(item, this);
	}

	protected override AutomationControlType GetAutomationControlTypeCore()
	{
		return AutomationControlType.Tree;
	}

	protected override string GetClassNameCore()
	{
		return base.Owner.GetType().Name;
	}

	protected override string GetLocalizedControlTypeCore()
	{
		return xv.hTz(10368);
	}

	internal static bool bsz()
	{
		return Dsb == null;
	}

	internal static TreeListBoxAutomationPeer KcQ()
	{
		return Dsb;
	}
}
