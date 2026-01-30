using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Docking.Automation.Peers;

public class SplitContainerAutomationPeer : FrameworkElementAutomationPeer
{
	internal static SplitContainerAutomationPeer hCP;

	public SplitContainerAutomationPeer(SplitContainer owner)
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
		return vVK.ssH(23930);
	}

	protected override AutomationOrientation GetOrientationCore()
	{
		if (!(base.Owner is SplitContainer splitContainer))
		{
			return AutomationOrientation.Horizontal;
		}
		if (splitContainer.Orientation != Orientation.Horizontal)
		{
			return AutomationOrientation.Vertical;
		}
		return AutomationOrientation.Horizontal;
	}

	internal static bool jCe()
	{
		return hCP == null;
	}

	internal static SplitContainerAutomationPeer DCJ()
	{
		return hCP;
	}
}
