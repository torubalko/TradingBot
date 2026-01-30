using System.Windows.Automation.Peers;
using ActiproSoftware.Windows.Controls.Primitives;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Controls.Automation.Peers;

public class AutomationContentControlAutomationPeer : FrameworkElementAutomationPeer
{
	private static AutomationContentControlAutomationPeer L1e;

	public AutomationContentControlAutomationPeer(AutomationContentControl owner)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector(owner);
	}

	protected override AutomationControlType GetAutomationControlTypeCore()
	{
		AutomationContentControl automationContentControl = base.Owner as AutomationContentControl;
		return automationContentControl.ControlType;
	}

	protected override string GetClassNameCore()
	{
		return base.Owner.GetType().Name;
	}

	internal static bool z16()
	{
		return L1e == null;
	}

	internal static AutomationContentControlAutomationPeer J1w()
	{
		return L1e;
	}
}
