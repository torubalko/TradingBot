using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Windows.Automation.Peers;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.Docking.Primitives;

namespace ActiproSoftware.Windows.Controls.Docking.Automation.Peers;

public class DockingWindowContainerTabItemAutomationPeer : FrameworkElementAutomationPeer
{
	internal static DockingWindowContainerTabItemAutomationPeer QCW;

	public DockingWindowContainerTabItemAutomationPeer(AdvancedTabItem owner)
	{
		IVH.CecNqz();
		base._002Ector(owner);
	}

	private AutomationPeer URv()
	{
		if (base.Owner is DockingWindowContainerTabItem { Content: DockingWindow content })
		{
			return UIElementAutomationPeer.CreatePeerForElement(content);
		}
		return null;
	}

	protected override AutomationControlType GetAutomationControlTypeCore()
	{
		return AutomationControlType.TabItem;
	}

	protected override string GetAutomationIdCore()
	{
		AutomationPeer automationPeer = URv();
		if (automationPeer != null)
		{
			string automationId = automationPeer.GetAutomationId();
			if (!string.IsNullOrEmpty(automationId))
			{
				return automationId + vVK.ssH(23804);
			}
		}
		return base.GetAutomationIdCore();
	}

	[SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists")]
	protected override List<AutomationPeer> GetChildrenCore()
	{
		List<AutomationPeer> list = new List<AutomationPeer>();
		List<AutomationPeer> childrenCore = base.GetChildrenCore();
		if (childrenCore != null)
		{
			foreach (AutomationPeer item in childrenCore)
			{
				if (item != null && item.GetAutomationControlType() == AutomationControlType.Button)
				{
					list.Add(item);
				}
			}
		}
		AutomationPeer automationPeer = URv();
		if (automationPeer != null)
		{
			list.Add(automationPeer);
		}
		return list;
	}

	protected override string GetClassNameCore()
	{
		return base.Owner.GetType().Name;
	}

	protected override string GetNameCore()
	{
		if (base.Owner is DockingWindowContainerTabItem dockingWindowContainerTabItem)
		{
			string text = dockingWindowContainerTabItem.Header as string;
			if (!string.IsNullOrEmpty(text))
			{
				return text;
			}
		}
		return base.GetNameCore();
	}

	protected override string GetLocalizedControlTypeCore()
	{
		return vVK.ssH(23814);
	}

	internal static bool XCI()
	{
		return QCW == null;
	}

	internal static DockingWindowContainerTabItemAutomationPeer ICa()
	{
		return QCW;
	}
}
