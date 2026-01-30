using System.Windows;
using ActiproSoftware.Windows.Controls.Docking;
using ActiproSoftware.Windows.Controls.Docking.Primitives;

namespace ActiproSoftware.Internal;

internal class cC : Qi
{
	private static cC wY6;

	public cC(DockHost P_0)
	{
		IVH.CecNqz();
		base._002Ector(P_0);
		FloatPreview content = new FloatPreview
		{
			Opacity = 0.4
		};
		FMd().Content = content;
	}

	protected override void HmR()
	{
		FloatingWindowControl floatingWindowControl = FMd();
		il il2 = vMe();
		if (floatingWindowControl != null)
		{
			bool flag = il2 != null && il2.yR2() && il2.ARI() != null;
			int num = 0;
			if (OYI() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			floatingWindowControl.Opacity = (flag ? 0.0 : 1.0);
		}
	}

	protected override void Pme(bool P_0)
	{
		int num = 1;
		while (true)
		{
			int num2 = num;
			do
			{
				switch (num2)
				{
				default:
				{
					DockSite dockSite = base.DockSite;
					if (dockSite != null && dockSite.s1t().ovk(base.DockHost))
					{
						return;
					}
					break;
				}
				case 1:
					if (!P_0)
					{
						break;
					}
					goto IL_0045;
				}
				DockHost dockHost = base.DockHost;
				if (dockHost != null)
				{
					dockHost.MGJ(null);
					dockHost.uGT(null);
					dockHost.Close(forceDestroy: true);
				}
				return;
				IL_0045:
				num2 = 0;
			}
			while (OYI() == null);
		}
	}

	protected override void Fmr()
	{
		FloatingWindowControl floatingWindowControl = FMd();
		if (floatingWindowControl != null)
		{
			floatingWindowControl.Background = null;
			floatingWindowControl.BorderThickness = new Thickness(0.0);
			floatingWindowControl.HasDropShadow = false;
			floatingWindowControl.HasTitleBar = false;
		}
	}

	internal static bool NYW()
	{
		return wY6 == null;
	}

	internal static cC OYI()
	{
		return wY6;
	}
}
