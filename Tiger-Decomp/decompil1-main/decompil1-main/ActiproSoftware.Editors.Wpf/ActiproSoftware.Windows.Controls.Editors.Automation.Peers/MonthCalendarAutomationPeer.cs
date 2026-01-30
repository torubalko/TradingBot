using System.Windows.Automation.Peers;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Editors.Automation.Peers;

public class MonthCalendarAutomationPeer : FrameworkElementAutomationPeer
{
	internal static MonthCalendarAutomationPeer KAD;

	public MonthCalendarAutomationPeer(MonthCalendar owner)
	{
		awj.QuEwGz();
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

	protected override string GetLocalizedControlTypeCore()
	{
		return QdM.AR8(30158);
	}

	internal static bool IAy()
	{
		return KAD == null;
	}

	internal static MonthCalendarAutomationPeer zAX()
	{
		return KAD;
	}
}
