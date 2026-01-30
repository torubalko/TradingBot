using System.Windows;
using System.Windows.Automation.Peers;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Docking.Automation.Peers;

public class WorkspaceAutomationPeer : FrameworkElementAutomationPeer
{
	internal static WorkspaceAutomationPeer TCr;

	public WorkspaceAutomationPeer(Workspace owner)
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
		return vVK.ssH(24234);
	}

	internal static bool dCz()
	{
		return TCr == null;
	}

	internal static WorkspaceAutomationPeer NK0()
	{
		return TCr;
	}
}
