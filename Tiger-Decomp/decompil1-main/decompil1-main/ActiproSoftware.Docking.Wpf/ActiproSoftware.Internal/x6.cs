using ActiproSoftware.Windows.Controls.Docking;
using ActiproSoftware.Windows.Controls.Docking.Primitives;

namespace ActiproSoftware.Internal;

internal class x6 : Qi
{
	private static x6 HY5;

	public x6(DockHost P_0)
	{
		IVH.CecNqz();
		base._002Ector(P_0);
		FMd().Content = P_0;
	}

	protected override void Fmr()
	{
		DockHost dockHost = base.DockHost;
		FloatingWindowControl floatingWindowControl = FMd();
		if (dockHost != null && floatingWindowControl != null)
		{
			floatingWindowControl.HasTitleBar = dockHost.BGW();
			floatingWindowControl.HasMinimizeButton = false;
			floatingWindowControl.HasRestoreButton = true;
			int num = 0;
			if (!IYj())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			floatingWindowControl.HasMaximizeButton = false;
			floatingWindowControl.HasCloseButton = dockHost.CanClose;
		}
	}

	protected override void amx()
	{
		DockHost dockHost = base.DockHost;
		FloatingWindowControl floatingWindowControl = FMd();
		if (dockHost != null && floatingWindowControl != null)
		{
			floatingWindowControl.HasCloseButton = dockHost.CanClose;
		}
	}

	internal static bool IYj()
	{
		return HY5 == null;
	}

	internal static x6 WYt()
	{
		return HY5;
	}
}
