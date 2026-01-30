using System.Windows.Automation.Peers;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Editors.Automation.Peers;

public class CalculatorAutomationPeer : FrameworkElementAutomationPeer
{
	internal static CalculatorAutomationPeer QA1;

	public CalculatorAutomationPeer(Calculator owner)
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
		return QdM.AR8(30070);
	}

	internal static bool AAQ()
	{
		return QA1 == null;
	}

	internal static CalculatorAutomationPeer JAZ()
	{
		return QA1;
	}
}
