using System.Windows.Automation.Peers;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Editors.Automation.Peers;

public class SaturationBrightnessPickerAutomationPeer : FrameworkElementAutomationPeer
{
	private static SaturationBrightnessPickerAutomationPeer jAo;

	public SaturationBrightnessPickerAutomationPeer(SaturationBrightnessPicker owner)
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
		return QdM.AR8(30318);
	}

	internal static bool bA2()
	{
		return jAo == null;
	}

	internal static SaturationBrightnessPickerAutomationPeer kAl()
	{
		return jAo;
	}
}
