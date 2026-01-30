using System.Windows.Automation.Peers;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Docking.Automation.Peers;

public class AdvancedTabControlAutomationPeer : TabControlAutomationPeer
{
	private static AdvancedTabControlAutomationPeer aC0;

	public AdvancedTabControlAutomationPeer(AdvancedTabControl owner)
	{
		IVH.CecNqz();
		base._002Ector(owner);
	}

	protected override ItemAutomationPeer CreateItemAutomationPeer(object item)
	{
		return new AdvancedTabItemAutomationPeer(item, this);
	}

	protected override string GetAutomationIdCore()
	{
		string text = base.GetAutomationIdCore();
		AutomationPeer parent = GetParent();
		if (parent is DockingWindowContainerBaseAutomationPeer)
		{
			string automationId = parent.GetAutomationId();
			if (!string.IsNullOrEmpty(automationId))
			{
				text = automationId + vVK.ssH(23562) + text;
			}
		}
		return text;
	}

	internal static bool DC1()
	{
		return aC0 == null;
	}

	internal static AdvancedTabControlAutomationPeer QCH()
	{
		return aC0;
	}
}
