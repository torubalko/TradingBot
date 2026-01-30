using System.Windows.Automation.Peers;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Editors.Automation.Peers;

public class GradientStopSliderAutomationPeer : FrameworkElementAutomationPeer
{
	internal static GradientStopSliderAutomationPeer CAR;

	public GradientStopSliderAutomationPeer(GradientStopSlider owner)
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
		return QdM.AR8(30094);
	}

	internal static bool YAi()
	{
		return CAR == null;
	}

	internal static GradientStopSliderAutomationPeer lA5()
	{
		return CAR;
	}
}
