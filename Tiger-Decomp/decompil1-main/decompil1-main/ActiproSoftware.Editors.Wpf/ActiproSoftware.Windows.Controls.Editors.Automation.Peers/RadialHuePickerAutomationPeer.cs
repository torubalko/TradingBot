using System.Windows.Automation.Peers;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Editors.Automation.Peers;

public class RadialHuePickerAutomationPeer : FrameworkElementAutomationPeer
{
	internal static RadialHuePickerAutomationPeer YAv;

	public RadialHuePickerAutomationPeer(RadialHuePicker owner)
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
		return QdM.AR8(30264);
	}

	internal static bool gAp()
	{
		return YAv == null;
	}

	internal static RadialHuePickerAutomationPeer LA4()
	{
		return YAv;
	}
}
