using System.Windows;
using System.Windows.Automation.Peers;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.Docking.Primitives;

namespace ActiproSoftware.Windows.Controls.Docking.Automation.Peers;

public class AutoHideTabGroupAutomationPeer : FrameworkElementAutomationPeer
{
	private static AutoHideTabGroupAutomationPeer CCM;

	public AutoHideTabGroupAutomationPeer(AutoHideTabGroup owner)
	{
		IVH.CecNqz();
		base._002Ector(owner);
	}

	private static string iRl(DockHostAutomationPeer P_0, AutoHideTabStrip P_1, AutoHideTabGroup P_2)
	{
		if (P_1 != null)
		{
			for (int i = 0; i < P_1.Items.Count; i++)
			{
				if (P_1.ItemContainerGenerator.ContainerFromIndex(i) as AutoHideTabGroup == P_2)
				{
					string text = P_0.GetAutomationId();
					if (string.IsNullOrEmpty(text))
					{
						text = P_0.GetClassName();
					}
					return text + vVK.ssH(23562) + P_2.Placement.ToString() + vVK.ssH(23614) + i + vVK.ssH(23652);
				}
			}
		}
		return string.Empty;
	}

	protected override AutomationControlType GetAutomationControlTypeCore()
	{
		return AutomationControlType.Group;
	}

	protected override string GetAutomationIdCore()
	{
		string text = base.GetAutomationIdCore();
		if (string.IsNullOrEmpty(text) && base.Owner is AutoHideTabGroup autoHideTabGroup && GetParent() is DockHostAutomationPeer { Owner: DockHost owner } dockHostAutomationPeer)
		{
			text = iRl(dockHostAutomationPeer, owner.c2z(), autoHideTabGroup);
			if (string.IsNullOrEmpty(text))
			{
				text = iRl(dockHostAutomationPeer, owner.Re1(), autoHideTabGroup);
				if (string.IsNullOrEmpty(text))
				{
					text = iRl(dockHostAutomationPeer, owner.deI(), autoHideTabGroup);
					if (string.IsNullOrEmpty(text))
					{
						text = iRl(dockHostAutomationPeer, owner.C2o(), autoHideTabGroup);
					}
				}
			}
		}
		return text;
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
		return vVK.ssH(23658);
	}

	protected override AutomationOrientation GetOrientationCore()
	{
		if (!(base.Owner is AutoHideTabGroup { Placement: var placement }))
		{
			return AutomationOrientation.Horizontal;
		}
		if (placement == Side.Top || placement == Side.Bottom)
		{
			return AutomationOrientation.Horizontal;
		}
		return AutomationOrientation.Vertical;
	}

	internal static bool TCh()
	{
		return CCM == null;
	}

	internal static AutoHideTabGroupAutomationPeer DCL()
	{
		return CCM;
	}
}
