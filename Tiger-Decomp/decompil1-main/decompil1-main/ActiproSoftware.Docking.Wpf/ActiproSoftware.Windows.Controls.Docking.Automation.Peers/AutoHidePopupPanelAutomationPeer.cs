using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Docking.Automation.Peers;

public class AutoHidePopupPanelAutomationPeer : FrameworkElementAutomationPeer
{
	internal static AutoHidePopupPanelAutomationPeer WCK;

	public AutoHidePopupPanelAutomationPeer(Panel owner)
	{
		IVH.CecNqz();
		base._002Ector(owner);
	}

	protected override AutomationControlType GetAutomationControlTypeCore()
	{
		return AutomationControlType.Pane;
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
		return vVK.ssH(23568);
	}

	internal static bool GCG()
	{
		return WCK == null;
	}

	internal static AutoHidePopupPanelAutomationPeer iCc()
	{
		return WCK;
	}
}
