using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Grids.Automation.Peers;

public class TreeListBoxItemWrapperAutomationPeer : FrameworkElementAutomationPeer, IExpandCollapseProvider
{
	private static TreeListBoxItemWrapperAutomationPeer RcF;

	public ExpandCollapseState ExpandCollapseState
	{
		get
		{
			if (!((TreeListBoxItem)base.Owner).IsExpanded)
			{
				return ExpandCollapseState.Collapsed;
			}
			return ExpandCollapseState.Expanded;
		}
	}

	public TreeListBoxItemWrapperAutomationPeer(TreeListBoxItem owner)
	{
		fc.taYSkz();
		base._002Ector(owner);
	}

	public void Collapse()
	{
		TreeListBoxItem treeListBoxItem = (TreeListBoxItem)base.Owner;
		if (treeListBoxItem.IsExpandable && treeListBoxItem.IsExpanded)
		{
			treeListBoxItem.IsExpanded = false;
		}
	}

	public void Expand()
	{
		TreeListBoxItem treeListBoxItem = (TreeListBoxItem)base.Owner;
		if (treeListBoxItem.IsExpandable && !treeListBoxItem.IsExpanded)
		{
			treeListBoxItem.IsExpanded = true;
		}
	}

	protected override AutomationControlType GetAutomationControlTypeCore()
	{
		return AutomationControlType.TreeItem;
	}

	protected override string GetClassNameCore()
	{
		return base.Owner.GetType().Name;
	}

	protected override string GetLocalizedControlTypeCore()
	{
		return xv.hTz(10432);
	}

	public override object GetPattern(PatternInterface patternInterface)
	{
		if (patternInterface == PatternInterface.ExpandCollapse)
		{
			return this;
		}
		return base.GetPattern(patternInterface);
	}

	internal static bool ucs()
	{
		return RcF == null;
	}

	internal static TreeListBoxItemWrapperAutomationPeer Jcc()
	{
		return RcF;
	}
}
