using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Windows;
using System.Windows.Automation.Peers;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Docking.Automation.Peers;

public class StandardMdiHostAutomationPeer : FrameworkElementAutomationPeer
{
	internal static StandardMdiHostAutomationPeer MCU;

	public StandardMdiHostAutomationPeer(StandardMdiHost owner)
	{
		IVH.CecNqz();
		base._002Ector(owner);
	}

	protected override AutomationControlType GetAutomationControlTypeCore()
	{
		return AutomationControlType.Group;
	}

	[SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists")]
	protected override List<AutomationPeer> GetChildrenCore()
	{
		List<AutomationPeer> list = new List<AutomationPeer>();
		if (base.Owner is StandardMdiHost standardMdiHost)
		{
			foreach (DockingWindow window in standardMdiHost.Windows)
			{
				if (window != null)
				{
					AutomationPeer automationPeer = UIElementAutomationPeer.CreatePeerForElement(window);
					if (automationPeer != null)
					{
						list.Add(automationPeer);
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
		return vVK.ssH(23964);
	}

	internal static bool nCF()
	{
		return MCU == null;
	}

	internal static StandardMdiHostAutomationPeer bCd()
	{
		return MCU;
	}
}
