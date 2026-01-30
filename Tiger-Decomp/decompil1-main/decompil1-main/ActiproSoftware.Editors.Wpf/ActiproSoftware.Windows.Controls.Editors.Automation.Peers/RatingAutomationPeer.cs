using System.Windows.Automation.Peers;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Editors.Automation.Peers;

public class RatingAutomationPeer : FrameworkElementAutomationPeer
{
	internal static RatingAutomationPeer jA0;

	public RatingAutomationPeer(Rating owner)
	{
		awj.QuEwGz();
		base._002Ector(owner);
	}

	protected override AutomationControlType GetAutomationControlTypeCore()
	{
		return AutomationControlType.Custom;
	}

	protected override string GetClassNameCore()
	{
		return base.Owner.GetType().Name;
	}

	protected override string GetLocalizedControlTypeCore()
	{
		return QdM.AR8(30302);
	}

	internal static bool xA7()
	{
		return jA0 == null;
	}

	internal static RatingAutomationPeer fAw()
	{
		return jA0;
	}
}
