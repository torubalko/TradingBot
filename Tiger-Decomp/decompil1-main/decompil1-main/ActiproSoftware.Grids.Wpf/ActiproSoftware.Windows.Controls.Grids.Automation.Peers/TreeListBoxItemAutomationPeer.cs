using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Grids.Automation.Peers;

public class TreeListBoxItemAutomationPeer : ItemAutomationPeer, IExpandCollapseProvider
{
	private static TreeListBoxItemAutomationPeer tcW;

	public ExpandCollapseState ExpandCollapseState
	{
		get
		{
			if (Mlg() is TreeListBoxItemWrapperAutomationPeer treeListBoxItemWrapperAutomationPeer)
			{
				return treeListBoxItemWrapperAutomationPeer.ExpandCollapseState;
			}
			return ExpandCollapseState.Collapsed;
		}
	}

	public TreeListBoxItemAutomationPeer(object item, TreeListBoxAutomationPeer itemsControlAutomationPeer)
	{
		fc.taYSkz();
		base._002Ector(item, itemsControlAutomationPeer);
	}

	private UIElement fll()
	{
		ItemsControlAutomationPeer itemsControlAutomationPeer = base.ItemsControlAutomationPeer;
		if (itemsControlAutomationPeer == null)
		{
			return null;
		}
		ItemsControl itemsControl = (ItemsControl)itemsControlAutomationPeer.Owner;
		if (itemsControl == null)
		{
			return null;
		}
		return itemsControl.ItemContainerGenerator.ContainerFromItem(base.Item) as UIElement;
	}

	private AutomationPeer Mlg()
	{
		UIElement uIElement = fll();
		if (uIElement == null)
		{
			return null;
		}
		AutomationPeer automationPeer = UIElementAutomationPeer.CreatePeerForElement(uIElement);
		if (automationPeer != null)
		{
			return automationPeer;
		}
		if (uIElement is FrameworkElement)
		{
			return new FrameworkElementAutomationPeer((FrameworkElement)uIElement);
		}
		return new UIElementAutomationPeer(uIElement);
	}

	public void Collapse()
	{
		if (Mlg() is TreeListBoxItemWrapperAutomationPeer treeListBoxItemWrapperAutomationPeer)
		{
			treeListBoxItemWrapperAutomationPeer.Collapse();
		}
	}

	public void Expand()
	{
		if (Mlg() is TreeListBoxItemWrapperAutomationPeer treeListBoxItemWrapperAutomationPeer)
		{
			treeListBoxItemWrapperAutomationPeer.Expand();
		}
	}

	protected override AutomationControlType GetAutomationControlTypeCore()
	{
		return AutomationControlType.TreeItem;
	}

	protected override string GetClassNameCore()
	{
		return xv.hTz(10398);
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

	internal static bool acC()
	{
		return tcW == null;
	}

	internal static TreeListBoxItemAutomationPeer oc6()
	{
		return tcW;
	}
}
