using System.Windows.Automation.Peers;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Controls.Automation.Peers;

public class AdvancedTextBlockAutomationPeer : FrameworkElementAutomationPeer
{
	internal static AdvancedTextBlockAutomationPeer X10;

	public AdvancedTextBlockAutomationPeer(AdvancedTextBlock owner)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector(owner);
	}

	protected override AutomationControlType GetAutomationControlTypeCore()
	{
		return AutomationControlType.Text;
	}

	protected override string GetClassNameCore()
	{
		return base.Owner.GetType().Name;
	}

	protected override string GetLocalizedControlTypeCore()
	{
		return WP6RZJql8gZrNhVA9v.L3hoFlcqP6(117076);
	}

	protected override string GetNameCore()
	{
		AdvancedTextBlock advancedTextBlock = (AdvancedTextBlock)base.Owner;
		return advancedTextBlock.Text;
	}

	internal static bool z1b()
	{
		return X10 == null;
	}

	internal static AdvancedTextBlockAutomationPeer k11()
	{
		return X10;
	}
}
