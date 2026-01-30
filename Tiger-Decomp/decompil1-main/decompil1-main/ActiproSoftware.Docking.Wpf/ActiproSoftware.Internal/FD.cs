using System;
using System.Runtime.CompilerServices;
using System.Windows.Threading;
using ActiproSoftware.Windows.Controls.Docking;

namespace ActiproSoftware.Internal;

internal class FD
{
	private DockHost ilI;

	private bool Tlk;

	private DispatcherTimer ylC;

	private DispatcherTimer tl1;

	private ToolWindow XlN;

	internal static FD YYn;

	public FD(DockHost P_0)
	{
		IVH.CecNqz();
		base._002Ector();
		if (P_0 == null)
		{
			throw new ArgumentNullException(vVK.ssH(9182));
		}
		ilI = P_0;
	}

	private void ixg(object P_0, object P_1)
	{
		Vxo();
		if (ilI.IsAutoHidePopupOpen && !Tlk && (XlN == null || ilI.AutoHidePopupToolWindow != XlN) && !ilI.uGr())
		{
			ilI.CloseAutoHidePopup(closeImmediately: false, blurFocus: false);
		}
	}

	private void IxX(object P_0, object P_1)
	{
		Rxt();
		if (XlN != null)
		{
			XlN.Activate(focus: false);
		}
	}

	[SpecialName]
	private double Ulw()
	{
		DockSite dockSite = ilI.DockSite;
		if (dockSite != null)
		{
			return Math.Max(100.0, dockSite.AutoHidePopupCloseDelay);
		}
		return 500.0;
	}

	[SpecialName]
	private double dle()
	{
		DockSite dockSite = ilI.DockSite;
		if (dockSite != null)
		{
			return Math.Max(100.0, dockSite.AutoHidePopupOpenDelay);
		}
		return 200.0;
	}

	private void gx5()
	{
		if (ylC == null)
		{
			ylC = new DispatcherTimer();
			ylC.Tick += ixg;
		}
		if (!ylC.IsEnabled)
		{
			ylC.Interval = TimeSpan.FromMilliseconds(Ulw());
			ylC.Start();
		}
	}

	private void Mxy()
	{
		Rxt();
		if (tl1 == null)
		{
			tl1 = new DispatcherTimer();
			tl1.Tick += IxX;
		}
		tl1.Interval = TimeSpan.FromMilliseconds(dle());
		tl1.Start();
	}

	private void Vxo()
	{
		if (ylC != null)
		{
			ylC.Stop();
		}
	}

	private void Rxt()
	{
		if (tl1 != null)
		{
			tl1.Stop();
		}
	}

	public void Yxu()
	{
		Tlk = true;
		if (ilI.IsAutoHidePopupOpen)
		{
			Vxo();
		}
	}

	public void exz()
	{
		Tlk = false;
		if (ilI.IsAutoHidePopupOpen && ilI.DockSite != null && !ilI.uGr())
		{
			gx5();
		}
	}

	public void Fli(ToolWindow P_0, bool P_1)
	{
		Tlk = false;
		if (P_0 != null && ilI.AutoHidePopupToolWindow == P_0)
		{
			Vxo();
		}
		if (P_0 != null)
		{
			int num = 0;
			if (LYY() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			if (ilI.DockSite != null && (P_1 || ilI.DockSite.AutoHidePopupOpensOnMouseHover))
			{
				if (ilI.AutoHidePopupToolWindow != P_0)
				{
					XlN = P_0;
					Mxy();
				}
				return;
			}
		}
		XlN = null;
		Rxt();
	}

	public void Kld(ToolWindow P_0, bool P_1)
	{
		Tlk = false;
		XlN = null;
		Rxt();
		if (ilI.IsAutoHidePopupOpen && ilI.DockSite != null && !ilI.uGr() && (P_1 || ilI.DockSite.AutoHidePopupOpensOnMouseHover || (P_0 != null && !P_0.IsActive)))
		{
			gx5();
		}
	}

	internal static bool uYA()
	{
		return YYn == null;
	}

	internal static FD LYY()
	{
		return YYn;
	}
}
