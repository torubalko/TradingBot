using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Windows;
using System.Windows.Automation.Peers;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.Docking.Primitives;

namespace ActiproSoftware.Windows.Controls.Docking.Automation.Peers;

public class DockHostAutomationPeer : FrameworkElementAutomationPeer
{
	private static DockHostAutomationPeer OCo;

	public DockHostAutomationPeer(DockHost owner)
	{
		IVH.CecNqz();
		base._002Ector(owner);
	}

	private static void rRM(List<AutomationPeer> P_0, AutoHideTabStrip P_1)
	{
		if (P_1 == null)
		{
			return;
		}
		foreach (ToolWindowContainer item in P_1.Items.OfType<ToolWindowContainer>())
		{
			if (item != null && P_1.ItemContainerGenerator.ContainerFromItem(item) is AutoHideTabGroup element)
			{
				AutomationPeer automationPeer = UIElementAutomationPeer.CreatePeerForElement(element);
				if (automationPeer != null)
				{
					P_0.Add(automationPeer);
				}
			}
		}
	}

	protected override AutomationControlType GetAutomationControlTypeCore()
	{
		return AutomationControlType.Group;
	}

	protected override string GetAutomationIdCore()
	{
		string text = base.GetAutomationIdCore();
		AutomationPeer parent = GetParent();
		if (parent is DockSiteAutomationPeer)
		{
			string text2 = parent.GetAutomationId();
			if (string.IsNullOrEmpty(text2))
			{
				text2 = parent.GetClassName();
			}
			text = text2 + vVK.ssH(23562) + text;
		}
		return text;
	}

	[SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists")]
	protected override List<AutomationPeer> GetChildrenCore()
	{
		List<AutomationPeer> list = new List<AutomationPeer>();
		if (base.Owner is DockHost dockHost)
		{
			rRM(list, dockHost.c2z());
			rRM(list, dockHost.Re1());
			rRM(list, dockHost.deI());
			rRM(list, dockHost.C2o());
			if (dockHost.Child != null)
			{
				AutomationPeer automationPeer = UIElementAutomationPeer.CreatePeerForElement(dockHost.Child);
				if (automationPeer != null)
				{
					list.Add(automationPeer);
				}
			}
			if (dockHost.IsAutoHidePopupOpen && dockHost.DockSite.IQR())
			{
				ig ig = dockHost.cee();
				if (ig != null)
				{
					AutomationPeer automationPeer2 = UIElementAutomationPeer.CreatePeerForElement(ig);
					if (automationPeer2 != null)
					{
						list.Add(automationPeer2);
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

	protected override Point GetClickablePointCore()
	{
		return new Point(double.NaN, double.NaN);
	}

	protected override string GetLocalizedControlTypeCore()
	{
		return vVK.ssH(23776);
	}

	internal static bool rCB()
	{
		return OCo == null;
	}

	internal static DockHostAutomationPeer MC5()
	{
		return OCo;
	}
}
