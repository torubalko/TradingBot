using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Windows.Automation.Peers;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.Docking.Primitives;

namespace ActiproSoftware.Windows.Controls.Docking.Automation.Peers;

public abstract class DockingWindowContainerBaseAutomationPeer : FrameworkElementAutomationPeer
{
	internal static DockingWindowContainerBaseAutomationPeer cC4;

	protected DockingWindowContainerBaseAutomationPeer(DockingWindowContainerBase owner)
	{
		IVH.CecNqz();
		base._002Ector(owner);
	}

	protected override AutomationControlType GetAutomationControlTypeCore()
	{
		return AutomationControlType.Tab;
	}

	protected override string GetAutomationIdCore()
	{
		string text = base.GetAutomationIdCore();
		if (string.IsNullOrEmpty(text))
		{
			text = GetClassNameCore();
			AutomationPeer automationPeer = this;
			for (AutomationPeer parent = automationPeer.GetParent(); parent != null; parent = automationPeer.GetParent())
			{
				bool flag = parent is SplitContainerAutomationPeer;
				bool flag2 = parent is WorkspaceAutomationPeer;
				bool flag3 = parent is DockHostAutomationPeer;
				bool flag4 = parent is DockSiteAutomationPeer;
				if (!flag && !flag2 && !flag3 && !flag4)
				{
					break;
				}
				string text2 = parent.GetAutomationId();
				bool num = !string.IsNullOrEmpty(text2);
				if (!num)
				{
					text2 = parent.GetClassName();
				}
				if (flag)
				{
					List<AutomationPeer> children = parent.GetChildren();
					if (children != null)
					{
						int num2 = children.IndexOf(automationPeer);
						if (num2 != -1)
						{
							text2 = text2 + vVK.ssH(23798) + num2 + vVK.ssH(23652);
						}
					}
				}
				text = text2 + vVK.ssH(3934) + text;
				if (num || flag4)
				{
					break;
				}
				automationPeer = parent;
			}
		}
		return text;
	}

	[SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists")]
	protected override List<AutomationPeer> GetChildrenCore()
	{
		List<AutomationPeer> list = new List<AutomationPeer>();
		if (base.Owner is DockingWindowContainerBase dockingWindowContainerBase)
		{
			AdvancedTabItem[] array = dockingWindowContainerBase.zD8().ToArray();
			if (array != null && array.Length != 0)
			{
				AdvancedTabItem[] array2 = array;
				foreach (AdvancedTabItem advancedTabItem in array2)
				{
					if (advancedTabItem != null)
					{
						AutomationPeer automationPeer = UIElementAutomationPeer.CreatePeerForElement(advancedTabItem);
						if (automationPeer != null)
						{
							list.Add(automationPeer);
						}
					}
				}
			}
			else
			{
				foreach (DockingWindow item in dockingWindowContainerBase.WindowsCore)
				{
					if (item != null)
					{
						AutomationPeer automationPeer2 = UIElementAutomationPeer.CreatePeerForElement(item);
						if (automationPeer2 != null)
						{
							list.Add(automationPeer2);
						}
					}
				}
			}
		}
		return list;
	}

	protected override string GetClassNameCore()
	{
		return base.Owner.GetType().Name;
	}

	internal static bool oC2()
	{
		return cC4 == null;
	}

	internal static DockingWindowContainerBaseAutomationPeer DC6()
	{
		return cC4;
	}
}
