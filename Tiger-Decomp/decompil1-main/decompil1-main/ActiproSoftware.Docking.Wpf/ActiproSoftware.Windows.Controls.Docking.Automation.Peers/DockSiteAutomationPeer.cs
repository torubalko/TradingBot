using System.Windows;
using System.Windows.Automation.Peers;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Docking.Automation.Peers;

public class DockSiteAutomationPeer : FrameworkElementAutomationPeer
{
	internal static DockSiteAutomationPeer eCX;

	public DockSiteAutomationPeer(DockSite owner)
	{
		IVH.CecNqz();
		base._002Ector(owner);
	}

	protected override AutomationControlType GetAutomationControlTypeCore()
	{
		return AutomationControlType.Group;
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
		return vVK.ssH(23874);
	}

	internal static bool ECs()
	{
		return eCX == null;
	}

	internal static DockSiteAutomationPeer CCQ()
	{
		return eCX;
	}
}
