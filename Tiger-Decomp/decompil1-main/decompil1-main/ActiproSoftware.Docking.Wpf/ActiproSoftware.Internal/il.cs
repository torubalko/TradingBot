using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using ActiproSoftware.Windows.Controls;
using ActiproSoftware.Windows.Controls.Docking;
using ActiproSoftware.Windows.Extensions;

namespace ActiproSoftware.Internal;

internal abstract class il
{
	private bool GRQ;

	private bool sRm;

	private bool VRa;

	private bool vRW;

	private bool SRB;

	private Size? tRK;

	private QK DRJ;

	private DockSite KRn;

	private DockHost wRO;

	private gh DRT;

	private DockHost CR8;

	[CompilerGenerated]
	private EventHandler ERD;

	[CompilerGenerated]
	private bool NRE;

	[CompilerGenerated]
	private bool aRr;

	[CompilerGenerated]
	private bool ERx;

	internal static il RY3;

	internal DockSite DockSite => KRn;

	[SpecialName]
	[CompilerGenerated]
	public void VRC(EventHandler P_0)
	{
		EventHandler eventHandler = ERD;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, P_0);
			eventHandler = Interlocked.CompareExchange(ref ERD, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void GR1(EventHandler P_0)
	{
		EventHandler eventHandler = ERD;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, P_0);
			eventHandler = Interlocked.CompareExchange(ref ERD, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	protected il(DockSite P_0, gh P_1)
	{
		IVH.CecNqz();
		base._002Ector();
		if (P_0 == null)
		{
			throw new ArgumentNullException(vVK.ssH(10308));
		}
		if (P_1 == null)
		{
			throw new ArgumentNullException(vVK.ssH(23418));
		}
		if (P_1.DockHost == null)
		{
			throw new ArgumentException(vVK.ssH(23464), vVK.ssH(23418));
		}
		KRn = P_0;
		DRT = P_1;
		wRO = P_1.DockHost;
		k7X(M7s());
		K7o(h7q());
		int num = 0;
		if (false)
		{
			int num2;
			num = num2;
		}
		switch (num)
		{
		}
		HRe(_0020: true);
		P7f();
	}

	private void l7Y(fF P_0)
	{
		if (wRO == null || P_0 == null || !P_0.UlJ().HasValue || P_0.UlT() == null)
		{
			return;
		}
		if (wRO.Child is wH wH2)
		{
			if (P_0.UlT() is DockHost dockHost && dockHost.dem() != null)
			{
				Rect rect = QK.z80(dockHost, P_0.UlJ().Value, f7b());
				Side value = P_0.UlJ().Value;
				if (value == Side.Left || value == Side.Right)
				{
					wH2.DockedSize = new Size(rect.Width, wH2.DockedSize.Height);
				}
				else
				{
					wH2.DockedSize = new Size(wH2.DockedSize.Width, rect.Height);
				}
				return;
			}
			DockHost dockHost2 = P_0.UlT().DockHost;
			Control control = P_0.UlT() as Control;
			if (dockHost2 != null && control != null)
			{
				Rect rect2 = QK.k8h(dockHost2, control, P_0.UlJ().Value, f7b());
				Side value = P_0.UlJ().Value;
				if (value == Side.Left || value == Side.Right)
				{
					wH2.DockedSize = new Size(rect2.Width, wH2.DockedSize.Height);
				}
				else
				{
					wH2.DockedSize = new Size(wH2.DockedSize.Width, rect2.Height);
				}
			}
		}
		else
		{
			if (wRO == null || !(wRO.Hen().Width > 0.0) || !(wRO.Hen().Height > 0.0))
			{
				return;
			}
			if (P_0.UlT() is DockHost dockHost3 && dockHost3.dem() != null)
			{
				Rect rect3 = QK.z80(dockHost3, P_0.UlJ().Value, f7b());
				Side value = P_0.UlJ().Value;
				if (value == Side.Left || value == Side.Right)
				{
					wRO.beO(new Size(rect3.Width, wRO.Hen().Height));
				}
				else
				{
					wRO.beO(new Size(wRO.Hen().Width, rect3.Height));
				}
				return;
			}
			DockHost dockHost4 = P_0.UlT().DockHost;
			Control control2 = P_0.UlT() as Control;
			if (dockHost4 != null && control2 != null)
			{
				Rect rect4 = QK.k8h(dockHost4, control2, P_0.UlJ().Value, f7b());
				Side value = P_0.UlJ().Value;
				if (value == Side.Left || value == Side.Right)
				{
					wRO.beO(new Size(rect4.Width, wRO.Hen().Height));
				}
				else
				{
					wRO.beO(new Size(wRO.Hen().Width, rect4.Height));
				}
			}
		}
	}

	internal void q7p(Point? P_0)
	{
		if (KRn == null || DRT == null || wRO == null)
		{
			return;
		}
		DockingWindowState? dockingWindowState = wRO.Kec();
		DRT.Kmi();
		if (!wRO.aG2())
		{
			if (dockingWindowState.HasValue)
			{
				wRO.l26(dockingWindowState);
				wRO.Close(forceDestroy: true);
			}
			else if (P_0.HasValue)
			{
				DRT.Location = P_0.Value;
			}
		}
	}

	[SpecialName]
	private Size f7b()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return tRK.Value;
			case 1:
				if (tRK.HasValue)
				{
					num2 = 0;
					if (!vYr())
					{
						num2 = 0;
					}
					break;
				}
				tRK = new Size(200.0, 200.0);
				if (!(wRO.Child is wH wH2))
				{
					if (wRO != null && wRO.Hen().Width > 0.0 && wRO.Hen().Height > 0.0)
					{
						tRK = wRO.Hen();
					}
				}
				else
				{
					tRK = new Size(Math.Min(wH2.MaxSize.Width, Math.Max(wH2.MinSize.Width, wH2.DockedSize.Width)), Math.Min(wH2.MaxSize.Height, Math.Max(wH2.MinSize.Height, wH2.DockedSize.Height)));
				}
				goto default;
			}
		}
	}

	[SpecialName]
	internal DockHost l70()
	{
		return wRO;
	}

	private static bool M7s()
	{
		if (!Keyboard.IsKeyDown(Key.LeftCtrl))
		{
			return Keyboard.IsKeyDown(Key.RightCtrl);
		}
		return true;
	}

	private static bool h7q()
	{
		if (!Keyboard.IsKeyDown(Key.LeftShift))
		{
			return Keyboard.IsKeyDown(Key.RightShift);
		}
		return true;
	}

	private void o7F(Point P_0)
	{
		if (DRJ != null)
		{
			fF fF2 = ARI();
			Point point = Wmj(DRJ, P_0);
			DRJ.Q8g(point);
			if (ARI() != fF2)
			{
				j7P();
			}
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal bool E7g()
	{
		return NRE;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void k7X(bool P_0)
	{
		NRE = P_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal bool m7y()
	{
		return aRr;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void K7o(bool P_0)
	{
		aRr = P_0;
	}

	[SpecialName]
	internal bool h7u()
	{
		if (wRO != null)
		{
			kq kq2 = wRO.LayoutKind;
			if ((uint)(kq2 - 3) <= 1u)
			{
				if (!GRQ)
				{
					return !VRa;
				}
				return false;
			}
		}
		return false;
	}

	private void W7V(Point P_0)
	{
		if (CR8 != null)
		{
			LmC();
			DRJ = new QK(wRO, CR8, f7b(), VRa, GRQ, sRm);
			DRJ.Opacity = (yR2() ? 1.0 : 0.0);
			RmY(DRJ);
			o7F(P_0);
		}
	}

	private void j7P()
	{
		ERD?.Invoke(this, EventArgs.Empty);
	}

	[SpecialName]
	internal DockHost KRi()
	{
		return CR8;
	}

	[SpecialName]
	private void pRd(DockHost P_0)
	{
		if (CR8 != P_0)
		{
			CR8 = P_0;
			Om7();
		}
	}

	private void P7f()
	{
		GRQ = true;
		sRm = true;
		VRa = true;
		SRB = true;
		bool flag = false;
		IEnumerable<DockingWindow> enumerable = from r in pL.Mxl<DockingWindow>(wRO, null)
			select r.dx3();
		int num = 0;
		if (!vYr())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (enumerable != null)
		{
			foreach (DockingWindow item in enumerable)
			{
				if (item != null)
				{
					if (!item.CanAttachResolved)
					{
						GRQ = false;
					}
					if (!item.CanBecomeDocumentResolved)
					{
						sRm = false;
					}
					if (!item.CanDockResolved)
					{
						VRa = false;
					}
					if (!item.CanDragToLinkedDockSitesResolved)
					{
						SRB = false;
					}
					if (item is ToolWindow)
					{
						flag = true;
					}
				}
			}
		}
		vRW = !flag || KRn.CanToolWindowsDragToFloatingDockHostsWithWorkspaces;
	}

	internal void J7U()
	{
		if (yR2() != !E7g())
		{
			HRe(!E7g());
			if (ARI() != null)
			{
				j7P();
			}
			if (DRJ != null)
			{
				DRJ.AnimateDoubleProperty(vVK.ssH(3302), yR2() ? 1.0 : 0.0, 0.1);
			}
		}
	}

	private static void O7c(bool P_0)
	{
		if (!P_0)
		{
			if (Mouse.OverrideCursor == Cursors.Arrow)
			{
				Mouse.OverrideCursor = null;
			}
		}
		else if (Mouse.OverrideCursor != Cursors.Arrow)
		{
			Mouse.OverrideCursor = Cursors.Arrow;
		}
	}

	protected virtual void LmC()
	{
		if (DRJ != null)
		{
			DRJ = null;
		}
	}

	protected abstract Point Wmj(UIElement P_0, Point P_1);

	protected abstract Point dmD(DockSite P_0, Point P_1);

	protected abstract void RmY(QK P_0);

	protected abstract DockHost kmt(Point P_0);

	[SpecialName]
	[CompilerGenerated]
	public bool yR2()
	{
		return ERx;
	}

	[SpecialName]
	[CompilerGenerated]
	private void HRe(bool P_0)
	{
		ERx = P_0;
	}

	public void u74(Point P_0)
	{
		int num = 2;
		Point point = default(Point);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					W7V(point);
					return;
				case 2:
					O7c(_0020: true);
					num2 = 1;
					if (vYr())
					{
						continue;
					}
					break;
				case 1:
				{
					DockHost dockHost = kmt(P_0);
					point = dmD(dockHost?.DockSite, P_0);
					if (KRi() == dockHost)
					{
						o7F(point);
						return;
					}
					LmC();
					if (dockHost != null)
					{
						if (!SRB && wRO.DockSite != dockHost.DockSite)
						{
							pRd(null);
							return;
						}
						kq kq2 = dockHost.LayoutKind;
						if ((uint)(kq2 - 3) <= 1u && !vRW && !dockHost.xGd())
						{
							pRd(null);
							return;
						}
					}
					pRd(dockHost);
					num2 = 0;
					if (PYz() == null)
					{
						continue;
					}
					break;
				}
				}
				break;
			}
		}
	}

	protected abstract void Pmn();

	protected abstract void xm8();

	protected abstract void Om7();

	public void z7j()
	{
		KRn.CCu(_0020: true);
		Pmn();
	}

	public bool l7Z(bool P_0)
	{
		wRO.me4(null);
		xm8();
		fF fF2 = ARI();
		O7c(_0020: false);
		LmC();
		if (P_0 && yR2() && CR8 != null)
		{
			int num = 0;
			if (PYz() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			if (fF2 != null && fF2.UlT() != null)
			{
				l7Y(fF2);
				return KRn.s1t().iMu(wRO, fF2.UlT(), fF2.UlJ());
			}
		}
		return false;
	}

	[SpecialName]
	public fF ARI()
	{
		if (DRJ == null)
		{
			return null;
		}
		return DRJ.Q8u();
	}

	internal static bool vYr()
	{
		return RY3 == null;
	}

	internal static il PYz()
	{
		return RY3;
	}
}
