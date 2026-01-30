using System.Windows.Automation.Peers;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Controls.Automation.Peers;

public class RadialSliderAutomationPeer : RangeBaseAutomationPeer
{
	private static RadialSliderAutomationPeer Y1v;

	public RadialSliderAutomationPeer(RadialSlider owner)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector(owner);
	}

	protected override AutomationControlType GetAutomationControlTypeCore()
	{
		return AutomationControlType.Slider;
	}

	protected override string GetClassNameCore()
	{
		return base.Owner.GetType().Name;
	}

	protected override string GetLocalizedControlTypeCore()
	{
		return WP6RZJql8gZrNhVA9v.L3hoFlcqP6(123194);
	}

	internal static bool c1a()
	{
		return Y1v == null;
	}

	internal static RadialSliderAutomationPeer c1y()
	{
		return Y1v;
	}
}
