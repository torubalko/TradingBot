using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using ActiproSoftware.Products.Docking;
using ActiproSoftware.Windows.Controls;
using ActiproSoftware.Windows.Controls.Docking;
using ActiproSoftware.Windows.Controls.Docking.Primitives;
using ActiproSoftware.Windows.Input;
using ActiproSoftware.Windows.Themes;

namespace ActiproSoftware.Internal;

[SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling")]
internal class Nx
{
	private class wVv
	{
		[CompilerGenerated]
		private DockHost t94;

		[CompilerGenerated]
		private DockingWindowState N9j;

		internal static wVv dMN;

		public wVv(DockingWindow P_0)
		{
			IVH.CecNqz();
			base._002Ector();
			if (P_0 == null)
			{
				throw new ArgumentNullException(vVK.ssH(9098));
			}
			d9V(P_0.DockHost);
			A9U(P_0.QkM());
		}

		[SpecialName]
		[CompilerGenerated]
		public DockHost M9F()
		{
			return t94;
		}

		[SpecialName]
		[CompilerGenerated]
		private void d9V(DockHost P_0)
		{
			t94 = P_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public DockingWindowState I9f()
		{
			return N9j;
		}

		[SpecialName]
		[CompilerGenerated]
		private void A9U(DockingWindowState P_0)
		{
			N9j = P_0;
		}

		internal static bool SMS()
		{
			return dMN == null;
		}

		internal static wVv IMP()
		{
			return dMN;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass7_0
	{
		public DockingWindow[] F9b;

		public Func<DockingWindow, bool> t9A;

		internal static _003C_003Ec__DisplayClass7_0 BMe;

		public _003C_003Ec__DisplayClass7_0()
		{
			IVH.CecNqz();
			base._002Ector();
		}

		internal bool C9Z(DockingWindow w)
		{
			return !F9b.Contains(w);
		}

		internal static bool nMJ()
		{
			return BMe == null;
		}

		internal static _003C_003Ec__DisplayClass7_0 BMU()
		{
			return BMe;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass8_0
	{
		public DockingWindow AYX;

		internal static _003C_003Ec__DisplayClass8_0 KMO;

		public _003C_003Ec__DisplayClass8_0()
		{
			IVH.CecNqz();
			base._002Ector();
		}

		internal bool SYg(DockingWindow w)
		{
			return w.MkZ() == AYX.MkZ();
		}

		internal static bool XMb()
		{
			return KMO == null;
		}

		internal static _003C_003Ec__DisplayClass8_0 vMT()
		{
			return KMO;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass8_1
	{
		public DockingWindow[] DYt;

		public DockingWindow EYu;

		public _003C_003Ec__DisplayClass8_0 AYz;

		internal static _003C_003Ec__DisplayClass8_1 LMx;

		public _003C_003Ec__DisplayClass8_1()
		{
			IVH.CecNqz();
			base._002Ector();
		}

		internal bool cY5(DockingWindow w)
		{
			if (w != AYz.AYX)
			{
				if (!DYt.Contains(w))
				{
					return w.QkM() != DockingWindowState.AutoHide;
				}
				return false;
			}
			return false;
		}

		internal bool MYy(DockingWindow w)
		{
			if (w != AYz.AYX)
			{
				if (!DYt.Contains(w))
				{
					return w.QkM() != DockingWindowState.AutoHide;
				}
				return false;
			}
			return false;
		}

		internal bool iYo(DockingWindow w)
		{
			return w.LastActiveDateTime == EYu.LastActiveDateTime;
		}

		internal static bool CMR()
		{
			return LMx == null;
		}

		internal static _003C_003Ec__DisplayClass8_1 QMD()
		{
			return LMx;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass11_0
	{
		public wH kpd;

		private static _003C_003Ec__DisplayClass11_0 DME;

		public _003C_003Ec__DisplayClass11_0()
		{
			IVH.CecNqz();
			base._002Ector();
		}

		internal bool lpi(wH c)
		{
			return c == kpd;
		}

		internal static bool OMk()
		{
			return DME == null;
		}

		internal static _003C_003Ec__DisplayClass11_0 qMq()
		{
			return DME;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass15_0
	{
		public Guid ep2;

		internal static _003C_003Ec__DisplayClass15_0 cMw;

		public _003C_003Ec__DisplayClass15_0()
		{
			IVH.CecNqz();
			base._002Ector();
		}

		internal bool gpw(bv b)
		{
			return b.UniqueId == ep2;
		}

		internal static bool IMg()
		{
			return cMw == null;
		}

		internal static _003C_003Ec__DisplayClass15_0 HMi()
		{
			return cMw;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass17_0
	{
		public Orientation ppG;

		internal static _003C_003Ec__DisplayClass17_0 SMZ;

		public _003C_003Ec__DisplayClass17_0()
		{
			IVH.CecNqz();
			base._002Ector();
		}

		internal bool Kpe(SplitContainer s)
		{
			if (s.Orientation == ppG)
			{
				return s.KaQ();
			}
			return false;
		}

		internal static bool BMu()
		{
			return SMZ == null;
		}

		internal static _003C_003Ec__DisplayClass17_0 TMy()
		{
			return SMZ;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass32_0
	{
		public Guid up1;

		internal static _003C_003Ec__DisplayClass32_0 zMz;

		public _003C_003Ec__DisplayClass32_0()
		{
			IVH.CecNqz();
			base._002Ector();
		}

		internal bool BpI(bv b)
		{
			return b.UniqueId == up1;
		}

		internal bool xpk(bv b)
		{
			return b.UniqueId == up1;
		}

		internal bool tpC(bv b)
		{
			return b.UniqueId == up1;
		}

		internal static bool Xh0()
		{
			return zMz == null;
		}

		internal static _003C_003Ec__DisplayClass32_0 Yh1()
		{
			return zMz;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass34_0
	{
		public DockingWindow GpQ;

		public DockingWindowState Dpm;

		public string fpa;

		private static _003C_003Ec__DisplayClass34_0 YhH;

		public _003C_003Ec__DisplayClass34_0()
		{
			IVH.CecNqz();
			base._002Ector();
		}

		internal bool SpN(DockingWindow w)
		{
			if (w != GpQ && w.IsCurrentlyOpen && w.QkM() == Dpm)
			{
				return w.WindowGroupName == fpa;
			}
			return false;
		}

		internal static bool xhf()
		{
			return YhH == null;
		}

		internal static _003C_003Ec__DisplayClass34_0 hh8()
		{
			return YhH;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass35_0
	{
		public Guid HpB;

		private static _003C_003Ec__DisplayClass35_0 Xhn;

		public _003C_003Ec__DisplayClass35_0()
		{
			IVH.CecNqz();
			base._002Ector();
		}

		internal bool upW(bv b)
		{
			return b.UniqueId == HpB;
		}

		internal static bool ehA()
		{
			return Xhn == null;
		}

		internal static _003C_003Ec__DisplayClass35_0 UhY()
		{
			return Xhn;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass49_0
	{
		public DockingWindow dpJ;

		private static _003C_003Ec__DisplayClass49_0 ahC;

		public _003C_003Ec__DisplayClass49_0()
		{
			IVH.CecNqz();
			base._002Ector();
		}

		internal bool bpK(DockingWindow tw)
		{
			return tw == dpJ;
		}

		internal static bool KhK()
		{
			return ahC == null;
		}

		internal static _003C_003Ec__DisplayClass49_0 ehG()
		{
			return ahC;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass55_0
	{
		public Guid dpO;

		internal static _003C_003Ec__DisplayClass55_0 Bhc;

		public _003C_003Ec__DisplayClass55_0()
		{
			IVH.CecNqz();
			base._002Ector();
		}

		internal bool Mpn(bv b)
		{
			return b.UniqueId == dpO;
		}

		internal static bool JhM()
		{
			return Bhc == null;
		}

		internal static _003C_003Ec__DisplayClass55_0 Khh()
		{
			return Bhc;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass56_0
	{
		public ToolWindowContainer Wp8;

		public Nx VpD;

		public bool dpE;

		public DockHost npr;

		public DockingWindow Tpx;

		private static _003C_003Ec__DisplayClass56_0 ihL;

		public _003C_003Ec__DisplayClass56_0()
		{
			IVH.CecNqz();
			base._002Ector();
		}

		internal lX gpT(Nx processor, DockHost targetDockHost, bool onlyRemove)
		{
			ToolWindowContainer toolWindowContainer = DockSite.dN2(targetDockHost);
			if (!onlyRemove)
			{
				targetDockHost.Child = toolWindowContainer;
			}
			lX[] array = ((lX)Wp8).ChildNodes.ToArray();
			int num2 = default(int);
			foreach (lX lX2 in array)
			{
				DockingWindow dockingWindow = lX2 as DockingWindow;
				int num;
				if (dockingWindow != null)
				{
					VpD.LMY(dockingWindow);
					processor.wMb(dockingWindow);
					if (onlyRemove & dpE)
					{
						dockingWindow.ContainerDockedSize = npr.Hen();
					}
					toolWindowContainer.Windows.Add(dockingWindow);
					num = 1;
					if (oh9() != null)
					{
						num = num2;
					}
				}
				else
				{
					if (!(lX2 is bv bv2))
					{
						continue;
					}
					Wp8.DD9(bv2);
					toolWindowContainer.sDO(new bv(bv2));
					num = 0;
					if (oh9() != null)
					{
						num = 0;
					}
				}
				switch (num)
				{
				case 1:
					if (!onlyRemove)
					{
						VpD.hMZ(dockingWindow.UniqueId, dockingWindow.QkM(), targetDockHost);
					}
					dockingWindow.PIg();
					break;
				}
			}
			if (Tpx != null)
			{
				VpD.qMD(Tpx, !dpE);
			}
			return toolWindowContainer;
		}

		internal static bool shl()
		{
			return ihL == null;
		}

		internal static _003C_003Ec__DisplayClass56_0 oh9()
		{
			return ihL;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass57_0
	{
		public Nx rpv;

		public DockingWindow Up7;

		public bool WpR;

		public ToolWindow ppS;

		public bool HpL;

		public DockHost op3;

		internal static _003C_003Ec__DisplayClass57_0 ehm;

		public _003C_003Ec__DisplayClass57_0()
		{
			IVH.CecNqz();
			base._002Ector();
		}

		internal lX Ypl(Nx processor, DockHost targetDockHost, bool onlyRemove)
		{
			rpv.LMY(Up7);
			processor.wMb(Up7);
			if (!onlyRemove)
			{
				if (!WpR)
				{
					rpv.bMU(new DockingWindow[1] { Up7 });
				}
				ToolWindowContainer toolWindowContainer = (ToolWindowContainer)(targetDockHost.Child = DockSite.dN2(targetDockHost));
				toolWindowContainer.Windows.Add(ppS);
				rpv.hMZ(ppS.UniqueId, ppS.QkM(), targetDockHost);
				Up7.PIg();
				if (!WpR)
				{
					rpv.hvW.d10(new DockingWindow[1] { Up7 });
				}
			}
			else if (HpL)
			{
				Up7.ContainerDockedSize = op3.Hen();
			}
			return Up7;
		}

		internal lX kpM(Nx processor, DockHost targetDockHost, bool onlyRemove)
		{
			rpv.LMY(Up7);
			processor.wMb(Up7);
			jJ jJ2 = rpv.hvW.cQ4();
			if (!onlyRemove && jJ2 != null)
			{
				Workspace workspace = DockSite.HNe();
				if (workspace != null && jJ2.CloneForFloatingDockHost() is TabbedMdiHost tabbedMdiHost)
				{
					if (!WpR)
					{
						rpv.bMU(new DockingWindow[1] { Up7 });
					}
					workspace.Content = tabbedMdiHost;
					targetDockHost.Child = workspace;
					TabbedMdiContainer tabbedMdiContainer = (TabbedMdiContainer)(tabbedMdiHost.Child = DockSite.gNd(targetDockHost));
					tabbedMdiContainer.Windows.Add(Up7);
					rpv.hMZ(Up7.UniqueId, Up7.QkM(), targetDockHost);
					Up7.PIg();
					if (!WpR)
					{
						rpv.hvW.d10(new DockingWindow[1] { Up7 });
					}
				}
			}
			else if (HpL)
			{
				Up7.ContainerDockedSize = op3.Hen();
			}
			return Up7;
		}

		internal static bool rho()
		{
			return ehm == null;
		}

		internal static _003C_003Ec__DisplayClass57_0 thB()
		{
			return ehm;
		}
	}

	private DockSite hvW;

	private HashSet<DockHost> GvB;

	private Dictionary<DockingWindow, wVv> mvK;

	internal static Nx qYS;

	public Nx(DockSite P_0)
	{
		IVH.CecNqz();
		GvB = new HashSet<DockHost>();
		mvK = new Dictionary<DockingWindow, wVv>();
		base._002Ector();
		if (P_0 == null)
		{
			throw new ArgumentNullException(vVK.ssH(10308));
		}
		hvW = P_0;
	}

	private bool IM8(DockingWindow P_0, IDockTarget P_1, int P_2)
	{
		TabbedMdiContainer tabbedMdiContainer2 = default(TabbedMdiContainer);
		ToolWindow toolWindow = default(ToolWindow);
		int num;
		if (P_0 != null && P_1 != null)
		{
			if (P_1 is jJ jJ2)
			{
				return jJ2.RestoreToDefaultLocation(P_0);
			}
			DockingWindow dockingWindow = P_1 as DockingWindow;
			if (dockingWindow == null && P_1 is TabbedMdiContainer tabbedMdiContainer)
			{
				dockingWindow = tabbedMdiContainer.Windows.FirstOrDefault();
			}
			if (dockingWindow != null && dockingWindow.IsCurrentlyOpen)
			{
				tabbedMdiContainer2 = dockingWindow.MkZ() as TabbedMdiContainer;
				if (tabbedMdiContainer2 != null)
				{
					P_0.ContainerDockedSize = tabbedMdiContainer2.cEG();
					if (P_2 == 0)
					{
						goto IL_0045;
					}
					goto IL_016b;
				}
			}
			toolWindow = P_0 as ToolWindow;
			if (toolWindow != null)
			{
				num = 1;
				if (QYe() != null)
				{
					goto IL_0005;
				}
				goto IL_0009;
			}
		}
		goto IL_014b;
		IL_014b:
		return false;
		IL_0286:
		ToolWindow toolWindow2 = default(ToolWindow);
		if (toolWindow2 != null && toolWindow2.IsCurrentlyOpen)
		{
			ToolWindowContainer toolWindowContainer = toolWindow2.DBR();
			if (toolWindowContainer != null)
			{
				P_0.ContainerDockedSize = toolWindowContainer.cEG();
				if (P_2 == 0 && !hvW.AreNewTabsInsertedBeforeExistingTabs)
				{
					P_2 = toolWindowContainer.Windows.Count;
				}
				P_2 = Math.Max(0, Math.Min(toolWindowContainer.Windows.Count, P_2));
				toolWindowContainer.Windows.Insert(P_2, toolWindow);
				DockHost dockHost = toolWindowContainer.DockHost;
				hMZ(P_0.UniqueId, P_0.QkM(), dockHost);
				if (dockHost != null)
				{
					gM9(dockHost);
				}
				return true;
			}
		}
		goto IL_014b;
		IL_0009:
		DockHost dockHost2 = default(DockHost);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			case 4:
				break;
			case 2:
				goto IL_009c;
			default:
				hMZ(P_0.UniqueId, P_0.QkM(), dockHost2);
				if (dockHost2 != null)
				{
					gM9(dockHost2);
				}
				return true;
			case 3:
				goto IL_0286;
			case 1:
				goto IL_030f;
			}
			break;
			IL_030f:
			toolWindow2 = P_1 as ToolWindow;
			num2 = 2;
			goto IL_0005;
			IL_009c:
			if (toolWindow2 == null && P_1 is ToolWindowContainer toolWindowContainer2)
			{
				toolWindow2 = toolWindowContainer2.Windows.FirstOrDefault() as ToolWindow;
				num = 3;
				if (pYP())
				{
					continue;
				}
				goto IL_0005;
			}
			goto IL_0286;
		}
		goto IL_0045;
		IL_016b:
		P_2 = Math.Max(0, Math.Min(tabbedMdiContainer2.Windows.Count, P_2));
		tabbedMdiContainer2.Windows.Insert(P_2, P_0);
		dockHost2 = tabbedMdiContainer2.DockHost;
		num = 0;
		if (QYe() == null)
		{
			num = 0;
		}
		goto IL_0009;
		IL_0005:
		num = num2;
		goto IL_0009;
		IL_0045:
		if (!hvW.AreNewTabsInsertedBeforeExistingTabs)
		{
			P_2 = tabbedMdiContainer2.Windows.Count;
		}
		goto IL_016b;
	}

	private void qMD(DockingWindow P_0, bool P_1)
	{
		if (P_0 == null)
		{
			return;
		}
		if (P_0.MkZ() is ac { MdiHost: var mdiHost })
		{
			mdiHost?.BringToFront(P_0);
		}
		else if (P_0 is ToolWindow toolWindow)
		{
			ToolWindowContainer toolWindowContainer = toolWindow.DBR();
			if (toolWindowContainer != null)
			{
				DockHost dockHost = toolWindowContainer.DockHost;
				if (toolWindowContainer.SelectedWindow != toolWindow)
				{
					if (P_1)
					{
						dockHost?.Focus();
					}
					toolWindowContainer.SelectedWindow = toolWindow;
				}
				if (toolWindowContainer.State == DockingWindowState.AutoHide && dockHost != null && (!dockHost.IsAutoHidePopupOpen || dockHost.AutoHidePopupToolWindow != P_0))
				{
					dockHost.l2L(toolWindow);
				}
			}
		}
		if (P_1)
		{
			if (!P_0.IsActive && P_0.DockSite != null)
			{
				P_0.DockSite.ActiveWindow = P_0;
			}
			cP.Dl4(P_0);
		}
	}

	private bool aME(IEnumerable<DockingWindow> P_0, wU P_1, bool P_2, bool P_3)
	{
		bool result = true;
		if (P_0 != null)
		{
			_003C_003Ec__DisplayClass7_0 CS_0024_003C_003E8__locals9 = new _003C_003Ec__DisplayClass7_0();
			CS_0024_003C_003E8__locals9.F9b = P_0.Where(delegate(DockingWindow dockingWindow4)
			{
				if (dockingWindow4 != null && dockingWindow4.IsCurrentlyOpen && dockingWindow4.DockHost != null)
				{
					DockSite dockSite = dockingWindow4.DockHost.DockSite;
					if (dockSite != null)
					{
						return dockSite == hvW;
					}
					return true;
				}
				return false;
			}).ToArray();
			if (CS_0024_003C_003E8__locals9.F9b.Length != 0)
			{
				DockingWindow[] array;
				if (!(!hvW.j1j(CS_0024_003C_003E8__locals9.F9b) || P_2))
				{
					array = CS_0024_003C_003E8__locals9.F9b;
					foreach (DockingWindow dockingWindow in array)
					{
						if (!dockingWindow.IsOpen)
						{
							dockingWindow.TIA(_0020: true);
						}
					}
					return false;
				}
				P_3 &= hvW.AreDocumentWindowsDestroyedOnClose;
				array = CS_0024_003C_003E8__locals9.F9b;
				foreach (DockingWindow dockingWindow2 in array)
				{
					dockingWindow2.LastCloseReason = P_1;
					nMr(dockingWindow2, CS_0024_003C_003E8__locals9.F9b);
					wMb(dockingWindow2);
					if (hvW.PrimaryDocument == dockingWindow2)
					{
						DockingWindow dockingWindow3 = (from w in hvW.jQP()
							where !CS_0024_003C_003E8__locals9.F9b.Contains(w)
							orderby w.LastActiveDateTime descending
							select w).FirstOrDefault();
						hvW.PrimaryDocument = dockingWindow3;
						if (dockingWindow3 != null)
						{
							dockingWindow3.IsSelected = true;
						}
					}
					if (hvW.ActiveWindow == dockingWindow2)
					{
						hvW.ActiveWindow = null;
					}
				}
				hvW.n14(CS_0024_003C_003E8__locals9.F9b);
				if (P_3)
				{
					foreach (DocumentWindow item in CS_0024_003C_003E8__locals9.F9b.OfType<DocumentWindow>())
					{
						zMx(item);
					}
				}
			}
		}
		return result;
	}

	private void nMr(DockingWindow P_0, IEnumerable<DockingWindow> P_1)
	{
		_003C_003Ec__DisplayClass8_0 _003C_003Ec__DisplayClass8_ = new _003C_003Ec__DisplayClass8_0();
		_003C_003Ec__DisplayClass8_.AYX = P_0;
		if (_003C_003Ec__DisplayClass8_.AYX == null || !_003C_003Ec__DisplayClass8_.AYX.IsActive)
		{
			return;
		}
		DockHost dockHost = _003C_003Ec__DisplayClass8_.AYX.DockHost;
		if (dockHost == null)
		{
			return;
		}
		_003C_003Ec__DisplayClass8_1 CS_0024_003C_003E8__locals15 = new _003C_003Ec__DisplayClass8_1();
		CS_0024_003C_003E8__locals15.AYz = _003C_003Ec__DisplayClass8_;
		CS_0024_003C_003E8__locals15.DYt = ((P_1 != null) ? P_1.ToArray() : new DockingWindow[0]);
		IOrderedEnumerable<DockingWindow> source = from r in pL.Mxl(dockHost, (DockingWindow w) => w != CS_0024_003C_003E8__locals15.AYz.AYX && !CS_0024_003C_003E8__locals15.DYt.Contains(w) && w.QkM() != DockingWindowState.AutoHide)
			select r.dx3() into w
			orderby w.LastActiveDateTime descending
			select w;
		CS_0024_003C_003E8__locals15.EYu = source.FirstOrDefault();
		if (CS_0024_003C_003E8__locals15.EYu == null)
		{
			source = from r in pL.Mxl(hvW, (DockingWindow w) => w != CS_0024_003C_003E8__locals15.AYz.AYX && !CS_0024_003C_003E8__locals15.DYt.Contains(w) && w.QkM() != DockingWindowState.AutoHide)
				select r.dx3() into w
				orderby w.LastActiveDateTime descending
				select w;
			CS_0024_003C_003E8__locals15.EYu = source.FirstOrDefault();
		}
		if (CS_0024_003C_003E8__locals15.EYu != null)
		{
			if (source.TakeWhile((DockingWindow w) => w.LastActiveDateTime == CS_0024_003C_003E8__locals15.EYu.LastActiveDateTime).ToArray().Count() > 1)
			{
				IEnumerable<DockingWindow> source2 = source.Where((DockingWindow w) => w.MkZ() == CS_0024_003C_003E8__locals15.AYz.AYX.MkZ());
				if (source2.Any())
				{
					CS_0024_003C_003E8__locals15.EYu = source2.FirstOrDefault();
				}
				else
				{
					jJ jJ2 = dockHost.veR() ?? ((hvW.PrimaryDockHost != null) ? hvW.PrimaryDockHost.veR() : null);
					if (jJ2 != null)
					{
						DockingWindow primaryWindow = jJ2.PrimaryWindow;
						if (primaryWindow != null && source.Contains(primaryWindow))
						{
							CS_0024_003C_003E8__locals15.EYu = primaryWindow;
						}
					}
				}
			}
			qMD(CS_0024_003C_003E8__locals15.EYu, _0020: true);
		}
		else
		{
			if (dockHost.Meg() && !source.Any() && hvW.PrimaryDockHost != null)
			{
				dockHost = hvW.PrimaryDockHost;
			}
			dockHost.Focus();
		}
	}

	private void zMx(DockingWindow P_0)
	{
		if (P_0 != null)
		{
			hMZ(P_0.UniqueId, null, null);
			P_0.DockSite = null;
		}
	}

	private bool IMl(DockingWindow P_0, IDockTarget P_1, Side P_2)
	{
		if (P_0 != null && P_1 != null)
		{
			DockHost dockHost = P_1.DockHost;
			if (dockHost != null)
			{
				ToolWindow toolWindow = P_0 as ToolWindow;
				TabbedMdiContainer tabbedMdiContainer = P_1 as TabbedMdiContainer;
				if (toolWindow == null || tabbedMdiContainer != null)
				{
					TabbedMdiContainer tabbedMdiContainer2 = DockSite.gNd(dockHost);
					tabbedMdiContainer2.Windows.Add(P_0);
					BMM(tabbedMdiContainer2, P_1, P_2);
					int num = 0;
					if (QYe() != null)
					{
						int num2 = default(int);
						num = num2;
					}
					switch (num)
					{
					}
				}
				else
				{
					ToolWindowContainer toolWindowContainer = DockSite.dN2(dockHost);
					toolWindowContainer.Windows.Add(toolWindow);
					BMM(toolWindowContainer, P_1, P_2);
				}
				return true;
			}
		}
		return false;
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	private void BMM(lX P_0, IDockTarget P_1, Side P_2)
	{
		FrameworkElement frameworkElement = P_0 as FrameworkElement;
		if (frameworkElement == null)
		{
			return;
		}
		bool flag = false;
		DockHost dockHost = P_1 as DockHost;
		if (dockHost == null)
		{
			_003C_003Ec__DisplayClass11_0 CS_0024_003C_003E8__locals8 = new _003C_003Ec__DisplayClass11_0();
			CS_0024_003C_003E8__locals8.kpd = P_1 as wH;
			if (CS_0024_003C_003E8__locals8.kpd == null && P_1 is DockingWindow dockingWindow)
			{
				CS_0024_003C_003E8__locals8.kpd = dockingWindow.MkZ() as wH;
			}
			if (CS_0024_003C_003E8__locals8.kpd != null)
			{
				dockHost = CS_0024_003C_003E8__locals8.kpd.DockHost;
				if (dockHost != null)
				{
					bool flag2 = CS_0024_003C_003E8__locals8.kpd is TabbedMdiContainer;
					if (flag2)
					{
						TabbedMdiContainer tabbedMdiContainer = DockSite.gNd(dockHost);
						Size containerDockedSize = tabbedMdiContainer.cEG();
						if (P_0 is wH wH2)
						{
							containerDockedSize = wH2.DockedSize;
						}
						DockingWindow[] array = (from r in pL.Mxl<DockingWindow>(P_0, null)
							select r.dx3()).ToArray();
						foreach (DockingWindow dockingWindow2 in array)
						{
							if (dockingWindow2 != null)
							{
								G0 g = dockingWindow2.MkZ();
								if (g != null && g.RemoveWindow(dockingWindow2))
								{
									dockingWindow2.ContainerDockedSize = containerDockedSize;
									tabbedMdiContainer.Windows.Add(dockingWindow2);
								}
							}
						}
						frameworkElement = tabbedMdiContainer;
					}
					Tuple<SplitContainer, Control> tuple = SplitContainer.Lm5(CS_0024_003C_003E8__locals8.kpd as Control);
					if (tuple != null)
					{
						SplitContainer splitContainer = tuple.Item1;
						Control item = tuple.Item2;
						if (splitContainer != null && item != null)
						{
							gM9(dockHost);
							int num2 = splitContainer.Children.IndexOf(item);
							if ((splitContainer.Orientation == Orientation.Horizontal && (P_2 == Side.Top || P_2 == Side.Bottom)) || (splitContainer.Orientation == Orientation.Vertical && (P_2 == Side.Left || P_2 == Side.Right)))
							{
								SplitContainer splitContainer2 = DockSite.y1z(dockHost, (P_2 != Side.Left && P_2 != Side.Right) ? Orientation.Vertical : Orientation.Horizontal);
								splitContainer.Ymt(num2, splitContainer2);
								splitContainer2.Children.Add(item);
								splitContainer2.ApplyTemplate();
								splitContainer = splitContainer2;
								num2 = 0;
							}
							if (P_2 == Side.Right || P_2 == Side.Bottom)
							{
								num2++;
							}
							splitContainer.wmy(num2, frameworkElement);
							flag = true;
						}
					}
					else if (flag2)
					{
						b4<wH> b5 = pL.Mxl(dockHost, (wH c) => c == CS_0024_003C_003E8__locals8.kpd).FirstOrDefault();
						if (b5 != null && b5.nxY() is TabbedMdiHost tabbedMdiHost)
						{
							gM9(dockHost);
							if (tabbedMdiHost.Child != null)
							{
								SplitContainer splitContainer3 = DockSite.y1z(dockHost, (P_2 != Side.Left && P_2 != Side.Right) ? Orientation.Vertical : Orientation.Horizontal);
								FrameworkElement child = tabbedMdiHost.Child;
								tabbedMdiHost.bB2(value: true);
								tabbedMdiHost.Child = splitContainer3;
								tabbedMdiHost.bB2(value: false);
								splitContainer3.Children.Add(child);
								int num3 = 0;
								if (P_2 == Side.Right || P_2 == Side.Bottom)
								{
									num3++;
								}
								splitContainer3.wmy(num3, frameworkElement);
								splitContainer3.ApplyTemplate();
							}
							else
							{
								tabbedMdiHost.Child = frameworkElement;
							}
							flag = true;
						}
					}
				}
			}
			else if (P_1 != null)
			{
				dockHost = P_1.DockHost;
			}
		}
		if (dockHost == null)
		{
			return;
		}
		gM9(dockHost);
		hMR(dockHost);
		if (flag)
		{
			return;
		}
		FrameworkElement child2 = dockHost.Child;
		SplitContainer splitContainer4 = child2 as SplitContainer;
		if (splitContainer4 == null || (splitContainer4.Orientation == Orientation.Horizontal && (P_2 == Side.Top || P_2 == Side.Bottom)) || (splitContainer4.Orientation == Orientation.Vertical && (P_2 == Side.Left || P_2 == Side.Right)))
		{
			SplitContainer splitContainer5 = DockSite.y1z(dockHost, (P_2 != Side.Left && P_2 != Side.Right) ? Orientation.Vertical : Orientation.Horizontal);
			dockHost.ner(value: true);
			dockHost.Child = splitContainer5;
			dockHost.ner(value: false);
			if (child2 != null)
			{
				splitContainer5.Children.Add(child2);
			}
			splitContainer5.ApplyTemplate();
			splitContainer4 = splitContainer5;
		}
		if (splitContainer4 != null)
		{
			int num4 = ((P_2 != Side.Left && P_2 != Side.Top) ? splitContainer4.Children.Count : 0);
			splitContainer4.wmy(num4, frameworkElement);
		}
	}

	private void YMv()
	{
		dMq();
		RM0();
		yMh();
		hvW.jNc();
		EM7();
		SMg();
		RMc();
		lM4();
	}

	private void EM7()
	{
		DockingWindow activeWindow = hvW.ActiveWindow;
		if (activeWindow == null || activeWindow.DockSite == hvW)
		{
			return;
		}
		DockingWindow dockingWindow = null;
		if (activeWindow == hvW.PrimaryDocument)
		{
			dockingWindow = (from w in hvW.jQP()
				orderby w.LastActiveDateTime descending
				select w).FirstOrDefault();
			int num = 0;
			if (QYe() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			hvW.PrimaryDocument = dockingWindow;
		}
		if (dockingWindow == null)
		{
			dockingWindow = (from w in hvW.lQs()
				orderby w.LastActiveDateTime descending
				select w).FirstOrDefault();
		}
		hvW.ActiveWindow = dockingWindow;
		if (dockingWindow != null)
		{
			qMD(dockingWindow, _0020: false);
		}
	}

	private static void hMR(DockHost P_0)
	{
		P_0?.o2F(_0020: true);
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling")]
	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	private bool uMS(IEnumerable<DockingWindow> P_0, Point? P_1, Size? P_2, bool P_3)
	{
		if (P_0 != null)
		{
			DockingWindow dockingWindow = P_0.FirstOrDefault((DockingWindow tw) => tw.IsSelected) ?? P_0.FirstOrDefault();
			if (dockingWindow != null)
			{
				if (!P_1.HasValue && !P_2.HasValue)
				{
					_003C_003Ec__DisplayClass15_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass15_0();
					CS_0024_003C_003E8__locals2.ep2 = dockingWindow.UniqueId;
					DockingWindowState dockingWindowState = ((!P_3) ? DockingWindowState.Document : DockingWindowState.Docked);
					foreach (b4<bv> item in pL.YxM(hvW.FloatingDockHosts, (bv bv2) => bv2.UniqueId == CS_0024_003C_003E8__locals2.ep2))
					{
						if (!(item.nxY() is Xk xk) || xk.State != dockingWindowState)
						{
							continue;
						}
						DockHost dockHost = xk.DockHost;
						if (dockHost == null)
						{
							continue;
						}
						wMb(dockingWindow);
						if (!EMH(dockingWindow, dockHost, dockingWindowState, null))
						{
							continue;
						}
						hMZ(dockingWindow.UniqueId, null, dockingWindow.DockHost);
						DockingWindow[] array = P_0.ToArray();
						int num = 0;
						DockingWindow[] array2 = array;
						foreach (DockingWindow dockingWindow2 in array2)
						{
							if (dockingWindow2 != dockingWindow)
							{
								jMs(dockingWindow2, dockingWindow, null, null, num);
								hMZ(dockingWindow2.UniqueId, null, dockingWindow2.DockHost);
							}
							num++;
						}
						return true;
					}
				}
				Size? size = P_2;
				if (!size.HasValue)
				{
					DockingWindowContainerBase parentContainer = dockingWindow.ParentContainer;
					if (parentContainer != null && parentContainer.ActualWidth > 0.0 && parentContainer.ActualHeight > 0.0)
					{
						size = new Size(Math.Max(Math.Min(100.0, dockingWindow.ContainerMaxSizeResolved.Width), parentContainer.ActualWidth), Math.Max(Math.Min(100.0, dockingWindow.ContainerMaxSizeResolved.Height), parentContainer.ActualHeight));
					}
					if (!size.HasValue)
					{
						size = dockingWindow.Skx();
					}
					if (P_3)
					{
						double num3 = 1.0;
						if (hvW.TryFindResource(AssetResourceKeys.WindowResizeBorderNormalThicknessKey) is Thickness thickness)
						{
							num3 = thickness.Left;
						}
						size = new Size(size.Value.Width + 2.0 * num3, size.Value.Height + 2.0 * num3);
					}
				}
				DockHost dockHost2 = hvW.i15();
				dockHost2.beO(size.Value);
				if (P_1.HasValue)
				{
					dockHost2.XeK(P_1.Value);
				}
				gM9(dockHost2);
				gh gh2 = hvW.I1o(dockHost2, null, default(Point), _0020: false);
				if (P_3)
				{
					ToolWindowContainer toolWindowContainer = (ToolWindowContainer)(dockHost2.Child = DockSite.dN2(dockHost2));
					DockingWindow[] array2 = P_0.ToArray();
					foreach (DockingWindow dockingWindow3 in array2)
					{
						wMb(dockingWindow3);
						toolWindowContainer.Windows.Add(dockingWindow3);
						hMZ(dockingWindow3.UniqueId, dockingWindow3.QkM(), dockHost2);
					}
				}
				else
				{
					jJ jJ2 = hvW.cQ4();
					if (jJ2 == null)
					{
						return false;
					}
					Workspace workspace = DockSite.HNe();
					if (workspace == null)
					{
						return false;
					}
					if (!(jJ2.CloneForFloatingDockHost() is TabbedMdiHost tabbedMdiHost))
					{
						return false;
					}
					workspace.Content = tabbedMdiHost;
					dockHost2.Child = workspace;
					TabbedMdiContainer tabbedMdiContainer = (TabbedMdiContainer)(tabbedMdiHost.Child = DockSite.gNd(dockHost2));
					wMb(dockingWindow);
					tabbedMdiContainer.Windows.Add(dockingWindow);
					hMZ(dockingWindow.UniqueId, dockingWindow.QkM(), dockHost2);
				}
				bool flag = !P_2.HasValue && (dockingWindow.SizeToContentModes & SizeToContentModes.Floating) == SizeToContentModes.Floating;
				gh2.Vmu(_0020: true, _0020: true, flag);
				return true;
			}
		}
		return false;
	}

	private static Side eML(ToolWindow P_0)
	{
		Side? side = P_0.GetCurrentSide();
		if (!side.HasValue)
		{
			side = Side.Right;
		}
		return side.Value;
	}

	private static ToolWindowContainer AM3(DockHost P_0, Side P_1)
	{
		ToolWindowContainer result = null;
		if (P_0 != null)
		{
			SplitContainer splitContainer = P_0.Child as SplitContainer;
			if (splitContainer != null && splitContainer.KaQ())
			{
				_003C_003Ec__DisplayClass17_0 CS_0024_003C_003E8__locals3 = new _003C_003Ec__DisplayClass17_0();
				CS_0024_003C_003E8__locals3.ppG = ((P_1 != Side.Left && P_1 != Side.Right) ? Orientation.Vertical : Orientation.Horizontal);
				if (splitContainer.Orientation != CS_0024_003C_003E8__locals3.ppG)
				{
					splitContainer = splitContainer.Children.OfType<SplitContainer>().FirstOrDefault((SplitContainer s) => s.Orientation == CS_0024_003C_003E8__locals3.ppG && s.KaQ());
				}
			}
			if (splitContainer != null)
			{
				if (P_1 == Side.Left || P_1 == Side.Top)
				{
					for (int num = 0; num < splitContainer.Children.Count && splitContainer.Children[num] is ToolWindowContainer toolWindowContainer; num++)
					{
						result = toolWindowContainer;
						if (toolWindowContainer.Windows.Count != 0)
						{
							break;
						}
					}
				}
				else
				{
					int num2 = splitContainer.Children.Count - 1;
					while (num2 >= 0 && splitContainer.Children[num2] is ToolWindowContainer toolWindowContainer2)
					{
						result = toolWindowContainer2;
						if (toolWindowContainer2.Windows.Count != 0)
						{
							break;
						}
						num2--;
					}
				}
			}
		}
		return result;
	}

	private static IEnumerable<Guid> zM6(DockHost P_0)
	{
		if (P_0 == null)
		{
			yield break;
		}
		if (((P_0.aG2() && P_0.pGK() != null) ? P_0.pGK() : P_0) is DockingWindow dockingWindow)
		{
			yield return dockingWindow.UniqueId;
			yield break;
		}
		IList<b4<DockingWindowContainerBase>> list = pL.Mxl<DockingWindowContainerBase>(P_0, null);
		foreach (b4<DockingWindowContainerBase> item in list)
		{
			if (item == null)
			{
				continue;
			}
			lX lX2 = item.dx3();
			if (lX2 == null)
			{
				continue;
			}
			IEnumerable<lX> childNodes = lX2.ChildNodes;
			if (childNodes == null)
			{
				continue;
			}
			foreach (lX item2 in childNodes)
			{
				if (item2 is DockingWindow dockingWindow2)
				{
					yield return dockingWindow2.UniqueId;
				}
				else if (item2 is bv bv2)
				{
					yield return bv2.UniqueId;
				}
			}
		}
	}

	private void gM9(DockHost P_0)
	{
		if (P_0 != null && !GvB.Contains(P_0))
		{
			GvB.Add(P_0);
			P_0.zez(value: true);
		}
	}

	private void LMY(DockingWindow P_0)
	{
		if (P_0 != null && !mvK.ContainsKey(P_0))
		{
			mvK[P_0] = new wVv(P_0);
		}
	}

	private void XMp(IEnumerable<DockingWindow> P_0)
	{
		if (P_0 == null)
		{
			return;
		}
		foreach (DockingWindow item in P_0)
		{
			LMY(item);
		}
	}

	private void jMs(DockingWindow P_0, IDockTarget P_1, DockingWindowState? P_2, Side? P_3, int P_4)
	{
		DockingWindowState dockingWindowState = P_2 ?? P_0.QkM();
		if (P_0 == null)
		{
			return;
		}
		DockHost dockHost = P_1 as DockHost;
		if (P_0.IsCurrentlyOpen)
		{
			if (dockHost == null && P_0.QkM() != dockingWindowState)
			{
				DockHost dockHost2 = P_0.DockHost;
				if (dockHost2 != null)
				{
					dockHost = ((dockingWindowState != DockingWindowState.Document || dockHost2.veR() != null) ? dockHost2 : hvW.PrimaryDockHost);
				}
			}
			wMb(P_0);
		}
		if ((P_1 == null || !IM8(P_0, P_1, P_4)) && !EMH(P_0, dockHost, dockingWindowState, P_3))
		{
			nMA(P_0, dockHost, dockingWindowState, P_3);
		}
		gM9(P_0.DockHost);
	}

	private void dMq()
	{
		foreach (DockHost item in hvW.eQY())
		{
			if (item != null)
			{
				MMF(item);
			}
		}
	}

	private void MMF(DockHost P_0)
	{
		if (P_0 == null)
		{
			return;
		}
		for (int num = P_0.AutoHideLeftContainers.Count - 1; num >= 0; num--)
		{
			if (!P_0.AutoHideLeftContainers[num].BD0())
			{
				P_0.AutoHideLeftContainers.RemoveAt(num);
			}
		}
		for (int num2 = P_0.AutoHideTopContainers.Count - 1; num2 >= 0; num2--)
		{
			if (!P_0.AutoHideTopContainers[num2].BD0())
			{
				P_0.AutoHideTopContainers.RemoveAt(num2);
			}
		}
		for (int num3 = P_0.AutoHideRightContainers.Count - 1; num3 >= 0; num3--)
		{
			if (!P_0.AutoHideRightContainers[num3].BD0())
			{
				P_0.AutoHideRightContainers.RemoveAt(num3);
			}
		}
		for (int num4 = P_0.AutoHideBottomContainers.Count - 1; num4 >= 0; num4--)
		{
			if (!P_0.AutoHideBottomContainers[num4].BD0())
			{
				P_0.AutoHideBottomContainers.RemoveAt(num4);
			}
		}
		if (P_0.Child is SplitContainer splitContainer)
		{
			qMV(splitContainer);
			switch (splitContainer.Children.Count)
			{
			case 0:
				P_0.Child = null;
				break;
			case 1:
			{
				FrameworkElement frameworkElement = splitContainer.Children[0];
				if (frameworkElement is wH wH2)
				{
					if (splitContainer.Orientation == Orientation.Horizontal)
					{
						wH2.DockedSize = new Size(splitContainer.RenderSize.Width, wH2.DockedSize.Height);
					}
					else
					{
						wH2.DockedSize = new Size(wH2.DockedSize.Width, splitContainer.RenderSize.Height);
					}
				}
				splitContainer.Ha2(value: true);
				splitContainer.Children.RemoveAt(0);
				splitContainer.Ha2(value: false);
				P_0.Child = frameworkElement;
				break;
			}
			}
		}
		else if (P_0.Child is ToolWindowContainer toolWindowContainer)
		{
			if (!toolWindowContainer.BD0())
			{
				P_0.Child = null;
			}
		}
		else if (P_0.Child is Workspace workspace)
		{
			uMf(workspace);
		}
	}

	private void qMV(SplitContainer P_0)
	{
		int num = 3;
		SplitContainer splitContainer = default(SplitContainer);
		int num3 = default(int);
		FrameworkElement frameworkElement = default(FrameworkElement);
		Workspace workspace = default(Workspace);
		TabbedMdiContainer tabbedMdiContainer = default(TabbedMdiContainer);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					splitContainer.Ha2(value: true);
					splitContainer.Children.RemoveAt(0);
					splitContainer.Ha2(value: false);
					P_0.Children.Insert(num3, frameworkElement);
					goto IL_0102;
				case 2:
					num3 = P_0.Children.Count - 1;
					goto IL_0314;
				case 1:
					if (P_0.Orientation == splitContainer.Orientation)
					{
						FrameworkElement[] array = splitContainer.Children.ToArray();
						P_0.Ha2(value: true);
						P_0.Children.RemoveAt(num3);
						P_0.Ha2(value: false);
						FrameworkElement[] array2 = array;
						foreach (FrameworkElement item in array2)
						{
							splitContainer.Ha2(value: true);
							splitContainer.Children.Remove(item);
							splitContainer.Ha2(value: false);
							P_0.Children.Insert(num3++, item);
						}
					}
					goto IL_0102;
				default:
					P_0.Children.RemoveAt(num3);
					goto IL_0102;
				case 5:
					if (workspace != null)
					{
						uMf(workspace);
					}
					goto IL_0102;
				case 3:
					if (P_0 == null)
					{
						return;
					}
					num2 = 2;
					continue;
				case 4:
					{
						if (!tabbedMdiContainer.BD0())
						{
							P_0.Children.RemoveAt(num3);
						}
						goto IL_0102;
					}
					IL_0314:
					if (num3 < 0)
					{
						return;
					}
					splitContainer = P_0.Children[num3] as SplitContainer;
					if (splitContainer != null)
					{
						qMV(splitContainer);
						int count = splitContainer.Children.Count;
						if (count != 0)
						{
							if (count == 1)
							{
								frameworkElement = splitContainer.Children[0];
								if (frameworkElement is wH wH2)
								{
									if (splitContainer.Orientation == Orientation.Horizontal)
									{
										wH2.DockedSize = new Size(splitContainer.RenderSize.Width, wH2.DockedSize.Height);
									}
									else
									{
										wH2.DockedSize = new Size(wH2.DockedSize.Width, splitContainer.RenderSize.Height);
									}
								}
								P_0.Ha2(value: true);
								P_0.Children.RemoveAt(num3);
								P_0.Ha2(value: false);
								num2 = 6;
								if (QYe() == null)
								{
									continue;
								}
							}
							else
							{
								num2 = 1;
								if (QYe() == null)
								{
									continue;
								}
							}
							break;
						}
						P_0.Children.RemoveAt(num3);
					}
					else
					{
						if (!(P_0.Children[num3] is ToolWindowContainer toolWindowContainer))
						{
							tabbedMdiContainer = P_0.Children[num3] as TabbedMdiContainer;
							if (tabbedMdiContainer != null)
							{
								num2 = 4;
								if (!pYP())
								{
									num2 = 0;
								}
								continue;
							}
							workspace = P_0.Children[num3] as Workspace;
							num = 5;
							break;
						}
						if (!toolWindowContainer.BD0())
						{
							num2 = 0;
							if (pYP())
							{
								continue;
							}
							break;
						}
					}
					goto IL_0102;
					IL_0102:
					num3--;
					goto IL_0314;
				}
				break;
			}
		}
	}

	private void QMP(TabbedMdiHost P_0)
	{
		if (P_0 == null)
		{
			return;
		}
		if (P_0.Child is SplitContainer splitContainer)
		{
			qMV(splitContainer);
			switch (splitContainer.Children.Count)
			{
			case 0:
				P_0.Child = null;
				break;
			case 1:
			{
				FrameworkElement frameworkElement = splitContainer.Children[0];
				if (frameworkElement is wH wH2)
				{
					if (splitContainer.Orientation == Orientation.Horizontal)
					{
						wH2.DockedSize = new Size(splitContainer.RenderSize.Width, wH2.DockedSize.Height);
					}
					else
					{
						wH2.DockedSize = new Size(wH2.DockedSize.Width, splitContainer.RenderSize.Height);
					}
				}
				splitContainer.Ha2(value: true);
				splitContainer.Children.RemoveAt(0);
				splitContainer.Ha2(value: false);
				P_0.Child = frameworkElement;
				break;
			}
			}
		}
		else if (P_0.Child is TabbedMdiContainer tabbedMdiContainer && !tabbedMdiContainer.BD0())
		{
			P_0.Child = null;
		}
	}

	private void uMf(Workspace P_0)
	{
		if (P_0 != null && P_0.Content is TabbedMdiHost tabbedMdiHost)
		{
			QMP(tabbedMdiHost);
		}
	}

	private void bMU(IEnumerable<DockingWindow> P_0)
	{
		if (P_0 != null)
		{
			foreach (DockingWindow item in P_0)
			{
				if (item != null)
				{
					hvW.ONL(item);
				}
			}
		}
		hvW.R1h(P_0);
	}

	private void RMc()
	{
		DockingWindow[] array = (from p in mvK
			where p.Key.DockHost != p.Value.M9F()
			select p.Key).ToArray();
		if (array.Length != 0)
		{
			hvW.g1Z(array);
		}
	}

	private void lM4()
	{
		DockingWindow[] array = (from p in mvK
			where p.Key.QkM() != p.Value.I9f()
			select p.Key).ToArray();
		if (array.Length != 0)
		{
			hvW.X1g(array);
		}
	}

	private void IMj(bool P_0)
	{
		foreach (b4<bv> item in pL.Mxl<bv>(hvW, null))
		{
			bv bv2 = item.dx3();
			if (bv2 == null)
			{
				continue;
			}
			DockingWindow dockingWindow = hvW.KNF(bv2.UniqueId);
			if ((dockingWindow == null || P_0 || dockingWindow is ToolWindow) && item.nxY() is Xk { DockHost: var dockHost } xk)
			{
				if (dockHost != null)
				{
					gM9(dockHost);
				}
				xk.RemoveBreadcrumb(bv2);
			}
		}
	}

	private void hMZ(Guid P_0, DockingWindowState? P_1, DockHost P_2)
	{
		_003C_003Ec__DisplayClass32_0 CS_0024_003C_003E8__locals4 = new _003C_003Ec__DisplayClass32_0();
		CS_0024_003C_003E8__locals4.up1 = P_0;
		IList<b4<bv>> list = ((P_2 == null) ? pL.Mxl(hvW, (bv bv2) => bv2.UniqueId == CS_0024_003C_003E8__locals4.up1) : ((!P_2.xGd()) ? pL.YxM(hvW.FloatingDockHosts, (bv bv2) => bv2.UniqueId == CS_0024_003C_003E8__locals4.up1) : pL.Mxl(P_2, (bv bv2) => bv2.UniqueId == CS_0024_003C_003E8__locals4.up1)));
		foreach (b4<bv> item in list)
		{
			if (item.nxY() is Xk xk && (!P_1.HasValue || xk.State == P_1))
			{
				DockHost dockHost = xk.DockHost;
				if (dockHost != null)
				{
					gM9(dockHost);
				}
				xk.RemoveBreadcrumb(item.dx3());
			}
		}
	}

	private void wMb(DockingWindow P_0)
	{
		if (P_0 == null)
		{
			return;
		}
		DockHost dockHost = P_0.DockHost;
		gM9(dockHost);
		switch (P_0.QkM())
		{
		case DockingWindowState.Docked:
		case DockingWindowState.AutoHide:
			if (P_0 is ToolWindow toolWindow)
			{
				hMZ(P_0.UniqueId, P_0.QkM(), dockHost);
				if (P_0.QkM() == DockingWindowState.AutoHide && hvW.AutoHidePopupToolWindow == P_0)
				{
					hvW.CCu(_0020: true);
				}
				toolWindow.DBR()?.pDp(toolWindow);
			}
			break;
		case DockingWindowState.Document:
			if (P_0.MkZ() is ac { MdiHost: { } mdiHost })
			{
				hMZ(P_0.UniqueId, P_0.QkM(), dockHost);
				mdiHost.Remove(P_0, _0020: true);
			}
			break;
		}
		P_0.IsCurrentlyOpen = false;
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	[SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling")]
	private void nMA(DockingWindow P_0, DockHost P_1, DockingWindowState P_2, Side? P_3)
	{
		_003C_003Ec__DisplayClass34_0 CS_0024_003C_003E8__locals26 = new _003C_003Ec__DisplayClass34_0();
		CS_0024_003C_003E8__locals26.GpQ = P_0;
		CS_0024_003C_003E8__locals26.Dpm = P_2;
		bool flag = P_1 != null;
		P_1 = P_1 ?? ((CS_0024_003C_003E8__locals26.Dpm == DockingWindowState.Document) ? hvW.kQU() : null) ?? hvW.PrimaryDockHost;
		if (P_1 == null)
		{
			hvW.ApplyTemplate();
			P_1 = P_1 ?? ((CS_0024_003C_003E8__locals26.Dpm == DockingWindowState.Document) ? hvW.kQU() : null) ?? hvW.PrimaryDockHost;
		}
		if (P_1 == null)
		{
			throw new InvalidOperationException(SR.GetString(SRName.ExDockSiteNoTargetDockHost));
		}
		DockingWindowDefaultLocationEventArgs e = new DockingWindowDefaultLocationEventArgs(CS_0024_003C_003E8__locals26.GpQ, CS_0024_003C_003E8__locals26.Dpm);
		CS_0024_003C_003E8__locals26.fpa = CS_0024_003C_003E8__locals26.GpQ.WindowGroupName;
		if (!string.IsNullOrEmpty(CS_0024_003C_003E8__locals26.fpa))
		{
			e.Target = (from r in pL.Mxl(hvW, (DockingWindow w) => w != CS_0024_003C_003E8__locals26.GpQ && w.IsCurrentlyOpen && w.QkM() == CS_0024_003C_003E8__locals26.Dpm && w.WindowGroupName == CS_0024_003C_003E8__locals26.fpa)
				orderby r.dx3().LastActiveDateTime descending
				select r.dx3()).FirstOrDefault();
		}
		e.ShouldFloat = !flag && CS_0024_003C_003E8__locals26.GpQ.IsFloating;
		CS_0024_003C_003E8__locals26.GpQ.oIy(e);
		e = new DockingWindowDefaultLocationEventArgs(e.Window ?? CS_0024_003C_003E8__locals26.GpQ, e.State)
		{
			ShouldFloat = e.ShouldFloat,
			Side = e.Side,
			Target = e.Target
		};
		hvW.n1f(e);
		if (e.ShouldFloat)
		{
			if (CS_0024_003C_003E8__locals26.GpQ is ToolWindow)
			{
				DockingWindowState state = e.State;
				if ((state == DockingWindowState.Docked || state == DockingWindowState.AutoHide) && uMS(new DockingWindow[1] { CS_0024_003C_003E8__locals26.GpQ }, e.FloatingLocation, null, _0020: true))
				{
					return;
				}
			}
			if (hvW.cQ4() is TabbedMdiHost && uMS(new DockingWindow[1] { CS_0024_003C_003E8__locals26.GpQ }, e.FloatingLocation, null, _0020: false))
			{
				return;
			}
		}
		if (e.Target != null && e.Target.GetState(e.Side) == CS_0024_003C_003E8__locals26.Dpm)
		{
			if (e.Side.HasValue)
			{
				if (IMl(CS_0024_003C_003E8__locals26.GpQ, e.Target, e.Side.Value))
				{
					return;
				}
			}
			else if (IM8(CS_0024_003C_003E8__locals26.GpQ, e.Target, 0))
			{
				return;
			}
		}
		if (CS_0024_003C_003E8__locals26.Dpm == DockingWindowState.Document)
		{
			jJ jJ2 = P_1.veR() ?? ((hvW.PrimaryDockHost != null) ? hvW.PrimaryDockHost.veR() : null);
			if (jJ2 == null)
			{
				throw new InvalidOperationException(SR.GetString(SRName.ExDockSiteNoMdiHost));
			}
			hMR(jJ2.DockHost);
			if (jJ2.RestoreToDefaultLocation(CS_0024_003C_003E8__locals26.GpQ))
			{
				gM9(jJ2.DockHost);
			}
		}
		else
		{
			if (!(CS_0024_003C_003E8__locals26.GpQ is ToolWindow toolWindow))
			{
				return;
			}
			Side side = P_3 ?? e.Side ?? toolWindow.DefaultDockSide;
			hMR(P_1);
			if (CS_0024_003C_003E8__locals26.Dpm == DockingWindowState.AutoHide)
			{
				ToolWindowContainerCollection toolWindowContainerCollection = P_1.a2E(side);
				if (toolWindowContainerCollection != null)
				{
					ToolWindowContainer toolWindowContainer = DockSite.dN2(P_1);
					toolWindowContainer.State = DockingWindowState.AutoHide;
					toolWindowContainer.Windows.Add(toolWindow);
					toolWindowContainerCollection.Add(toolWindowContainer);
					gM9(P_1);
				}
				return;
			}
			if (toolWindow.CanAttachResolved)
			{
				ToolWindowContainer toolWindowContainer2 = AM3(P_1, side);
				if (toolWindowContainer2 != null && IM8(CS_0024_003C_003E8__locals26.GpQ, toolWindowContainer2, 0))
				{
					return;
				}
			}
			IMl(toolWindow, P_1, side);
		}
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	private bool EMH(DockingWindow P_0, DockHost P_1, DockingWindowState P_2, Side? P_3)
	{
		bool flag = false;
		if (P_0 != null)
		{
			_003C_003Ec__DisplayClass35_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass35_0();
			CS_0024_003C_003E8__locals2.HpB = P_0.UniqueId;
			IList<b4<bv>> list = pL.Mxl(hvW, (bv bv2) => bv2.UniqueId == CS_0024_003C_003E8__locals2.HpB);
			if (P_1 != null && list.Any())
			{
				for (int num = list.Count - 1; num >= 0; num--)
				{
					if (list[num].nxY() is wH wH2 && wH2.DockHost != P_1)
					{
						list.RemoveAt(num);
					}
				}
			}
			foreach (b4<bv> item in list)
			{
				if (item.nxY() is ToolWindowContainer toolWindowContainer)
				{
					if (toolWindowContainer.State == P_2)
					{
						DockHost dockHost = toolWindowContainer.DockHost;
						if (dockHost != null)
						{
							gM9(dockHost);
						}
						if (!flag && P_0 is ToolWindow toolWindow && (!P_3.HasValue || P_2 != DockingWindowState.AutoHide || toolWindowContainer.xKI() == P_3))
						{
							flag = toolWindowContainer.nDY(item.dx3(), toolWindow);
							hMR(dockHost);
						}
						else if (P_2 != DockingWindowState.Docked || dockHost == null || dockHost.Meg())
						{
							toolWindowContainer.DD9(item.dx3());
						}
					}
				}
				else if (P_2 == DockingWindowState.Document && item.nxY() is TabbedMdiContainer { DockHost: var dockHost2 } tabbedMdiContainer)
				{
					if (!flag && dockHost2 != null)
					{
						gM9(dockHost2);
						flag = tabbedMdiContainer.nDY(item.dx3(), P_0);
						hMR(dockHost2);
					}
					else
					{
						tabbedMdiContainer.DD9(item.dx3());
					}
				}
			}
		}
		return flag;
	}

	private void RM0()
	{
		foreach (DockHost item in GvB)
		{
			item.zez(value: false);
			if (!item.a2A())
			{
				item.n2b();
			}
			item.veR()?.UpdateIsEmpty();
			if (!item.aG2())
			{
				item.m2p();
			}
			item.i2Z();
		}
		GvB.Clear();
	}

	private void yMh()
	{
		int num2 = default(int);
		foreach (KeyValuePair<DockingWindow, wVv> item in mvK)
		{
			int num = 0;
			if (!pYP())
			{
				num = num2;
			}
			switch (num)
			{
			}
			DockingWindow key = item.Key;
			key.UpdateCanAttachResolved();
			key.UpdateCanDockResolved();
			key.UpdateCanDragTabResolved();
			key.PIg();
			if (!key.IsCurrentlyOpen && key.IsActive)
			{
				key.IsActive = false;
			}
		}
	}

	private void SMg()
	{
		DockingWindow activeWindow = hvW.ActiveWindow;
		if (activeWindow != null && hvW.PrimaryDocument != activeWindow && activeWindow.IsCurrentlyOpen && activeWindow.QkM() == DockingWindowState.Document)
		{
			hvW.PrimaryDocument = activeWindow;
		}
	}

	public void Activate(DockingWindow window, bool focus)
	{
		if (window != null)
		{
			LMY(window);
			bool flag = window.IsCurrentlyOpen;
			if (!flag)
			{
				bMU(new DockingWindow[1] { window });
				jMs(window, null, null, null, 0);
				hvW.d10(new DockingWindow[1] { window });
			}
			if (focus)
			{
				hvW.ActiveWindow = window;
			}
			qMD(window, focus);
			if (!flag)
			{
				YMv();
			}
		}
	}

	public void AutoHide(IEnumerable<ToolWindow> windows, Side? side)
	{
		if (windows == null)
		{
			return;
		}
		ToolWindow[] array = windows.ToArray();
		ToolWindow toolWindow = array.FirstOrDefault();
		if (toolWindow == null)
		{
			return;
		}
		DockingWindowsAutoHidingEventArgs e = new DockingWindowsAutoHidingEventArgs(array)
		{
			Side = (side ?? eML(toolWindow))
		};
		hvW.L1c(e);
		Side side2 = e.Side;
		if (e.Cancel)
		{
			return;
		}
		XMp(array);
		ToolWindow[] array2 = array.Where((ToolWindow w) => !w.IsCurrentlyOpen).ToArray();
		if (array2.Length != 0)
		{
			bMU(array2);
		}
		ToolWindow toolWindow2 = null;
		int num = 0;
		ToolWindow[] array3 = array;
		foreach (ToolWindow toolWindow3 in array3)
		{
			ToolWindowContainer toolWindowContainer = toolWindow3.DBR();
			if (toolWindowContainer == null || toolWindowContainer.xKI() != side2)
			{
				if (toolWindow3.IsActive)
				{
					nMr(toolWindow3, array);
				}
				if (toolWindow2 == null)
				{
					jMs(toolWindow3, null, DockingWindowState.AutoHide, side2, 0);
					num = toolWindow3.sIv() + 1;
					toolWindow2 = toolWindow3;
				}
				else
				{
					jMs(toolWindow3, toolWindow2, DockingWindowState.AutoHide, side2, num++);
				}
			}
		}
		if (array2.Length != 0)
		{
			hvW.d10(array2);
		}
		YMv();
	}

	public void AutoHide(ToolWindow window, Side? side)
	{
		if (window == null)
		{
			return;
		}
		DockingWindowsAutoHidingEventArgs e = new DockingWindowsAutoHidingEventArgs(new DockingWindow[1] { window })
		{
			Side = (side ?? eML(window))
		};
		hvW.L1c(e);
		Side side2 = e.Side;
		if (e.Cancel)
		{
			return;
		}
		ToolWindowContainer toolWindowContainer = window.DBR();
		if (toolWindowContainer == null || toolWindowContainer.xKI() != side2)
		{
			LMY(window);
			bool flag = window.IsCurrentlyOpen;
			if (!flag)
			{
				bMU(new DockingWindow[1] { window });
			}
			if (window.IsActive)
			{
				SMo(window);
			}
			jMs(window, null, DockingWindowState.AutoHide, side2, 0);
			if (!flag)
			{
				hvW.d10(new DockingWindow[1] { window });
			}
			YMv();
		}
	}

	public void AMX()
	{
		int num2 = default(int);
		DockingWindow[] array = default(DockingWindow[]);
		DockingWindow primaryWindow = default(DockingWindow);
		bool flag = default(bool);
		DockingWindow[] array2 = default(DockingWindow[]);
		int num3 = default(int);
		DockingWindow dockingWindow = default(DockingWindow);
		TabbedMdiContainer tabbedMdiContainer = default(TabbedMdiContainer);
		foreach (DockHost item2 in hvW.eQY())
		{
			if (item2 == null || !(item2.veR() is TabbedMdiHost tabbedMdiHost))
			{
				continue;
			}
			int num = 1;
			if (!pYP())
			{
				goto IL_0023;
			}
			goto IL_0027;
			IL_0023:
			num = num2;
			goto IL_0027;
			IL_0027:
			do
			{
				IL_0027_2:
				switch (num)
				{
				case 2:
					break;
				case 3:
					goto IL_0134;
				default:
					goto IL_01c6;
				case 1:
					goto IL_0230;
				}
				if (array.Length <= 1)
				{
					goto IL_010b;
				}
				primaryWindow = tabbedMdiHost.PrimaryWindow;
				flag = primaryWindow != null && (hvW.ActiveWindow == primaryWindow || cP.NlZ(primaryWindow));
				array2 = array;
				num3 = 0;
				goto IL_0095;
				IL_0230:
				array = (from w in tabbedMdiHost.GetDocuments()
					orderby w.LastActiveDateTime descending
					select w).ToArray();
				num = 2;
				continue;
				IL_0134:
				nMr(dockingWindow, array);
				wMb(dockingWindow);
				num3++;
				goto IL_0095;
				IL_0095:
				if (num3 < array2.Length)
				{
					dockingWindow = array2[num3];
					num = 0;
					if (QYe() == null)
					{
						num = 3;
					}
				}
				else
				{
					tabbedMdiContainer = tabbedMdiHost.Child as TabbedMdiContainer;
					num = 0;
					if (!pYP())
					{
						break;
					}
				}
				goto IL_0027_2;
				IL_01c6:
				if (tabbedMdiContainer == null)
				{
					tabbedMdiContainer = (TabbedMdiContainer)(tabbedMdiHost.Child = DockSite.gNd(item2));
				}
				array2 = array;
				for (num3 = 0; num3 < array2.Length; num3++)
				{
					DockingWindow item = array2[num3];
					tabbedMdiContainer.Windows.Add(item);
				}
				if (primaryWindow != null)
				{
					qMD(primaryWindow, flag);
				}
				YMv();
				goto IL_010b;
			}
			while (pYP());
			goto IL_0023;
			IL_010b:;
		}
	}

	public void TM5(DockHost P_0, jJ P_1, jJ P_2)
	{
		if (P_2 != null)
		{
			P_2.DockHost = P_0 ?? P_1?.DockHost;
		}
		if (P_1 == null)
		{
			return;
		}
		DockingWindow[] array = (from r in pL.Mxl<DockingWindow>(P_1, null)
			select r.dx3() into w
			orderby w.LastActiveDateTime descending
			select w).ToArray();
		if (array != null)
		{
			XMp(array);
			DockingWindow primaryWindow = P_1.PrimaryWindow;
			bool flag = primaryWindow != null && (hvW.ActiveWindow == primaryWindow || cP.NlZ(primaryWindow));
			if (flag && P_1.DockHost != null)
			{
				P_1.DockHost.Focus();
			}
			if (P_2 != null)
			{
				DockingWindow[] array2 = array;
				foreach (DockingWindow dockingWindow in array2)
				{
					P_1.Remove(dockingWindow, _0020: false);
				}
				P_2.AddRange(array);
				if (primaryWindow != null)
				{
					qMD(primaryWindow, flag);
				}
			}
			else
			{
				Close(array, (wU)4, force: true, allowDocumentDestroy: true);
			}
		}
		P_1.DockHost = null;
		YMv();
	}

	public void nMy(bool P_0, bool P_1)
	{
		List<DockingWindow> list = new List<DockingWindow>(hvW.ToolWindows);
		if (P_0)
		{
			list.AddRange(hvW.DocumentWindows);
		}
		XMp(list);
		Close(list, (wU)4, force: true, P_1);
		IMj(P_0);
		YMv();
	}

	public bool Close(IEnumerable<DockingWindow> windows, wU closeReason, bool force, bool allowDocumentDestroy)
	{
		bool flag = true;
		if (windows != null)
		{
			XMp(windows);
			flag = aME(windows, closeReason, force, allowDocumentDestroy);
			if (flag && cP.hlj() is DockHost dockHost && dockHost.Meg() && dockHost.IsEmpty && hvW.PrimaryDockHost != null)
			{
				cP.Dl4(hvW.PrimaryDockHost);
			}
			YMv();
		}
		return flag;
	}

	public bool Close(DockingWindow window, wU closeReason, bool force, bool allowDocumentDestroy)
	{
		bool result = false;
		if (window != null)
		{
			LMY(window);
			result = aME(new DockingWindow[1] { window }, closeReason, force, allowDocumentDestroy);
			YMv();
		}
		return result;
	}

	public void SMo(DockingWindow P_0)
	{
		if (P_0 != null)
		{
			nMr(P_0, null);
		}
	}

	public void fMt(DockingWindow P_0)
	{
		if (P_0 != null)
		{
			LMY(P_0);
			aME(new DockingWindow[1] { P_0 }, wU.Close, _0020: true, _0020: false);
			zMx(P_0);
			YMv();
		}
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	public bool iMu(DockHost P_0, IDockTarget P_1, Side? P_2)
	{
		if (P_0 != null)
		{
			lX lX2 = P_0.pGK() ?? (P_0.Child as wH);
			if (lX2 != null && P_1 != null)
			{
				if (!P_2.HasValue)
				{
					IList<b4<DockingWindow>> list = pL.Mxl<DockingWindow>(P_0, null);
					if (list != null && list.Count > 0)
					{
						IEnumerable<DockingWindow> enumerable = list.Select((b4<DockingWindow> r) => r.dx3());
						XMp(enumerable);
						if (P_0.aG2())
						{
							P_0.MGJ(null);
							P_0.uGT(null);
						}
						gM9(P_0);
						WMz(enumerable, P_1.GetState(P_2), P_1);
						return true;
					}
				}
				else
				{
					DockHost dockHost = P_1.DockHost;
					if (dockHost != null && dockHost != P_0)
					{
						_003C_003Ec__DisplayClass49_0 CS_0024_003C_003E8__locals4 = new _003C_003Ec__DisplayClass49_0();
						IEnumerable<DockingWindow> enumerable2 = from r in pL.Mxl<DockingWindow>(P_0, null)
							select r.dx3();
						XMp(enumerable2);
						DockingWindow[] array = enumerable2.Where((DockingWindow w) => !w.IsCurrentlyOpen).ToArray();
						if (array.Length != 0)
						{
							bMU(array);
						}
						CS_0024_003C_003E8__locals4.dpJ = hvW.ActiveWindow;
						bool flag = CS_0024_003C_003E8__locals4.dpJ != null && enumerable2.Any((DockingWindow tw) => tw == CS_0024_003C_003E8__locals4.dpJ);
						if (flag)
						{
							cP.elb(dockHost);
						}
						DockingWindowState state = P_1.GetState(P_2);
						Guid[] array2 = zM6(P_0).ToArray();
						if (lX2 is ToolWindowContainer toolWindowContainer && !P_0.aG2())
						{
							ToolWindowContainer toolWindowContainer2 = DockSite.dN2(dockHost);
							lX[] array3 = ((lX)toolWindowContainer).ChildNodes.ToArray();
							foreach (lX lX3 in array3)
							{
								if (lX3 is DockingWindow dockingWindow)
								{
									LMY(dockingWindow);
									wMb(dockingWindow);
									toolWindowContainer2.Windows.Add(dockingWindow);
									dockingWindow.PIg();
								}
								else if (lX3 is bv bv2)
								{
									toolWindowContainer.DD9(bv2);
									toolWindowContainer2.sDO(new bv(bv2));
								}
							}
							lX2 = toolWindowContainer2;
						}
						else
						{
							P_0.ner(value: true);
							P_0.Child = null;
							P_0.ner(value: false);
							if (P_0.aG2())
							{
								P_0.MGJ(null);
								if (P_0.PGO() != null)
								{
									lX2 = P_0.PGO()(this, dockHost, arg3: true);
									P_0.uGT(null);
								}
							}
						}
						Guid[] array4 = array2;
						foreach (Guid guid in array4)
						{
							hMZ(guid, state, dockHost);
						}
						gM9(P_0);
						if (lX2 is DockingWindow dockingWindow2)
						{
							IMl(dockingWindow2, P_1, P_2.Value);
						}
						else
						{
							BMM(lX2, P_1, P_2.Value);
						}
						if (array.Length != 0)
						{
							hvW.d10(array);
						}
						if (flag)
						{
							qMD(CS_0024_003C_003E8__locals4.dpJ, _0020: true);
						}
						YMv();
						return true;
					}
				}
			}
		}
		return false;
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	public void WMz(IEnumerable<DockingWindow> P_0, DockingWindowState P_1, IDockTarget P_2)
	{
		if (P_0 == null)
		{
			return;
		}
		DockingWindow[] array = P_0.ToArray();
		if (array.Length == 0)
		{
			return;
		}
		XMp(array);
		if (P_2 is iy { RequiresReverseOrderInsertion: not false })
		{
			Array.Reverse(array);
		}
		DockingWindow[] array2 = array.Where((DockingWindow w) => !w.IsCurrentlyOpen).ToArray();
		if (array2.Length != 0)
		{
			bMU(array2);
		}
		DockingWindow activeWindow = hvW.ActiveWindow;
		DockingWindow dockingWindow = ((activeWindow != null && array.Contains(activeWindow)) ? activeWindow : null) ?? array.FirstOrDefault((DockingWindow w) => w.IsSelected) ?? array.OrderByDescending((DockingWindow w) => w.LastActiveDateTime).FirstOrDefault();
		bool flag = false;
		if (dockingWindow != null)
		{
			flag = dockingWindow.IsActive;
			if (flag)
			{
				nMr(dockingWindow, array);
			}
		}
		DockingWindow dockingWindow2 = null;
		int num = 0;
		DockingWindow[] array3 = array;
		foreach (DockingWindow dockingWindow3 in array3)
		{
			if (dockingWindow3.IsCurrentlyOpen && dockingWindow3.QkM() == P_1)
			{
				DockHost dockHost = dockingWindow3.DockHost;
				if ((dockHost == null || dockHost.xGd()) && (P_2 == null || dockingWindow3.MkZ() == P_2))
				{
					continue;
				}
				if (P_2 == null)
				{
					P_2 = hvW.PrimaryDockHost;
				}
			}
			if (dockingWindow2 == null)
			{
				Side? side = ((dockingWindow3 is ToolWindow toolWindow) ? toolWindow.uBl() : ((Side?)null));
				jMs(dockingWindow3, P_2, P_1, side, 0);
				num = dockingWindow3.sIv() + 1;
				dockingWindow2 = dockingWindow3;
			}
			else
			{
				jMs(dockingWindow3, dockingWindow2, P_1, null, num++);
			}
		}
		if (array2.Length != 0)
		{
			hvW.d10(array2);
		}
		if (dockingWindow != null)
		{
			qMD(dockingWindow, flag);
		}
		YMv();
	}

	public bool Evi(DockingWindow P_0, IDockTarget P_1, Side P_2)
	{
		if (P_0 != null && P_1 != null)
		{
			DockHost dockHost = P_1.DockHost;
			int num = 1;
			if (!pYP())
			{
				num = 1;
			}
			DockingWindow activeWindow = default(DockingWindow);
			int num2 = default(int);
			while (true)
			{
				switch (num)
				{
				case 1:
				{
					if (dockHost == null)
					{
						break;
					}
					LMY(P_0);
					bool flag = P_0.IsCurrentlyOpen;
					if (!flag)
					{
						bMU(new DockingWindow[1] { P_0 });
					}
					activeWindow = hvW.ActiveWindow;
					bool flag2 = activeWindow == P_0;
					if (flag2)
					{
						cP.elb(dockHost);
					}
					hMZ(P_0.UniqueId, P_1.GetState(P_2), dockHost);
					if (P_0.IsCurrentlyOpen)
					{
						DockHost dockHost2 = P_0.DockHost;
						if (dockHost2 != null)
						{
							gM9(dockHost2);
						}
						wMb(P_0);
					}
					IMl(P_0, P_1, P_2);
					if (!flag)
					{
						hvW.d10(new DockingWindow[1] { P_0 });
					}
					if (flag2)
					{
						num = 0;
						if (QYe() != null)
						{
							num = num2;
						}
						continue;
					}
					goto IL_0137;
				}
				default:
					{
						qMD(activeWindow, _0020: true);
						goto IL_0137;
					}
					IL_0137:
					YMv();
					return true;
				}
				break;
			}
		}
		return false;
	}

	public void evd(ToolWindow P_0, DockingWindowState P_1, IDockTarget P_2)
	{
		bool flag;
		int num;
		if (P_0 != null)
		{
			flag = P_0.IsCurrentlyOpen;
			num = 1;
			if (!pYP())
			{
				goto IL_0005;
			}
			goto IL_0009;
		}
		return;
		IL_0009:
		do
		{
			switch (num)
			{
			case 1:
				if (!flag || P_0.QkM() != P_1 || P_2 != null)
				{
					break;
				}
				goto IL_013b;
			default:
			{
				DockHost dockHost = P_0.DockHost;
				if (dockHost == null || dockHost.xGd())
				{
					return;
				}
				kq kq2 = dockHost.LayoutKind;
				if ((uint)(kq2 - 1) > 1u)
				{
					return;
				}
				P_2 = hvW.PrimaryDockHost;
				break;
			}
			}
			LMY(P_0);
			if (!flag)
			{
				bMU(new DockingWindow[1] { P_0 });
			}
			bool isSelected = P_0.IsSelected;
			bool isActive = P_0.IsActive;
			if (isActive)
			{
				SMo(P_0);
			}
			jMs(P_0, P_2, P_1, P_0.uBl(), 0);
			if (!flag)
			{
				hvW.d10(new DockingWindow[1] { P_0 });
			}
			if (isSelected)
			{
				qMD(P_0, isActive);
			}
			YMv();
			return;
			IL_013b:
			num = 0;
		}
		while (QYe() == null);
		goto IL_0005;
		IL_0005:
		int num2 = default(int);
		num = num2;
		goto IL_0009;
	}

	[SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
	public void gvw()
	{
		dMq();
		IList<b4<DockingWindowContainerBase>> list = pL.Mxl<DockingWindowContainerBase>(hvW, null);
		if (list == null)
		{
			return;
		}
		foreach (b4<DockingWindowContainerBase> item in list)
		{
			item.dx3().vDV();
		}
	}

	public void gv2(DocumentWindow P_0, Point? P_1, Size? P_2)
	{
		jJ jJ2 = hvW.cQ4();
		if (P_0 != null && jJ2 is TabbedMdiHost)
		{
			LMY(P_0);
			bool flag = P_0.IsCurrentlyOpen;
			if (!flag)
			{
				bMU(new DockingWindow[1] { P_0 });
			}
			uMS(new DockingWindow[1] { P_0 }, P_1, P_2, _0020: false);
			if (!flag)
			{
				hvW.d10(new DockingWindow[1] { P_0 });
			}
			qMD(P_0, _0020: true);
			YMv();
		}
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	public void Sve(IEnumerable<ToolWindow> P_0, Point? P_1, Size? P_2)
	{
		if (P_0 == null)
		{
			return;
		}
		ToolWindow toolWindow = P_0.FirstOrDefault((ToolWindow tw) => tw.IsSelected) ?? P_0.FirstOrDefault();
		if (toolWindow == null)
		{
			return;
		}
		if (!P_1.HasValue && !P_2.HasValue && !toolWindow.IsCurrentlyOpen && toolWindow.QkM() == DockingWindowState.Docked && P_0.Count() == 1)
		{
			_003C_003Ec__DisplayClass55_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass55_0();
			CS_0024_003C_003E8__locals2.dpO = toolWindow.UniqueId;
			foreach (b4<bv> item in pL.Mxl(hvW, (bv bv2) => bv2.UniqueId == CS_0024_003C_003E8__locals2.dpO))
			{
				if (item.nxY() is Xk { State: DockingWindowState.Docked, DockHost: { } dockHost } && dockHost.Meg())
				{
					wvN(toolWindow);
					return;
				}
			}
		}
		XMp(P_0);
		ToolWindow[] array = P_0.Where((ToolWindow w) => !w.IsCurrentlyOpen).ToArray();
		if (array.Length != 0)
		{
			bMU(array);
		}
		uMS(P_0, P_1, P_2, _0020: true);
		if (array.Length != 0)
		{
			hvW.d10(array);
		}
		if (toolWindow != null)
		{
			qMD(toolWindow, _0020: true);
		}
		YMv();
	}

	public void WvG(ToolWindowContainer P_0, Point P_1, InputPointerEventArgs P_2)
	{
		_003C_003Ec__DisplayClass56_0 CS_0024_003C_003E8__locals37 = new _003C_003Ec__DisplayClass56_0();
		CS_0024_003C_003E8__locals37.Wp8 = P_0;
		CS_0024_003C_003E8__locals37.VpD = this;
		if (CS_0024_003C_003E8__locals37.Wp8 == null || CS_0024_003C_003E8__locals37.Wp8.Windows.Count <= 0)
		{
			return;
		}
		CS_0024_003C_003E8__locals37.dpE = hvW.RQl() || CS_0024_003C_003E8__locals37.Wp8.Windows.Any((DockingWindow tw) => !tw.CanFloatResolved);
		CS_0024_003C_003E8__locals37.Tpx = CS_0024_003C_003E8__locals37.Wp8.SelectedWindow;
		DockHost dockHost = CS_0024_003C_003E8__locals37.Wp8.DockHost;
		CS_0024_003C_003E8__locals37.npr = hvW.i15();
		CS_0024_003C_003E8__locals37.npr.Cef(dockHost);
		CS_0024_003C_003E8__locals37.npr.me4(CS_0024_003C_003E8__locals37.Wp8.State);
		gM9(CS_0024_003C_003E8__locals37.npr);
		if (hvW.I1o(CS_0024_003C_003E8__locals37.npr, CS_0024_003C_003E8__locals37.Wp8, P_1, CS_0024_003C_003E8__locals37.dpE) is AM aM)
		{
			aM.gv4(hV.iN());
		}
		if (CS_0024_003C_003E8__locals37.Tpx != null && !CS_0024_003C_003E8__locals37.dpE)
		{
			nMr(CS_0024_003C_003E8__locals37.Tpx, CS_0024_003C_003E8__locals37.Wp8.Windows);
		}
		Func<Nx, DockHost, bool, lX> func = delegate(Nx processor, DockHost targetDockHost, bool onlyRemove)
		{
			ToolWindowContainer toolWindowContainer = DockSite.dN2(targetDockHost);
			if (!onlyRemove)
			{
				targetDockHost.Child = toolWindowContainer;
			}
			lX[] array = ((lX)CS_0024_003C_003E8__locals37.Wp8).ChildNodes.ToArray();
			int num4 = default(int);
			foreach (lX lX2 in array)
			{
				DockingWindow dockingWindow = lX2 as DockingWindow;
				int num3;
				if (dockingWindow != null)
				{
					CS_0024_003C_003E8__locals37.VpD.LMY(dockingWindow);
					processor.wMb(dockingWindow);
					if (onlyRemove & CS_0024_003C_003E8__locals37.dpE)
					{
						dockingWindow.ContainerDockedSize = CS_0024_003C_003E8__locals37.npr.Hen();
					}
					toolWindowContainer.Windows.Add(dockingWindow);
					num3 = 1;
					if (_003C_003Ec__DisplayClass56_0.oh9() != null)
					{
						num3 = num4;
					}
				}
				else
				{
					if (!(lX2 is bv bv2))
					{
						continue;
					}
					CS_0024_003C_003E8__locals37.Wp8.DD9(bv2);
					toolWindowContainer.sDO(new bv(bv2));
					num3 = 0;
					if (_003C_003Ec__DisplayClass56_0.oh9() != null)
					{
						num3 = 0;
					}
				}
				switch (num3)
				{
				case 1:
					if (!onlyRemove)
					{
						CS_0024_003C_003E8__locals37.VpD.hMZ(dockingWindow.UniqueId, dockingWindow.QkM(), targetDockHost);
					}
					dockingWindow.PIg();
					break;
				}
			}
			if (CS_0024_003C_003E8__locals37.Tpx != null)
			{
				CS_0024_003C_003E8__locals37.VpD.qMD(CS_0024_003C_003E8__locals37.Tpx, !CS_0024_003C_003E8__locals37.dpE);
			}
			return toolWindowContainer;
		};
		int num = 0;
		if (!pYP())
		{
			int num2 = default(int);
			num = num2;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				CS_0024_003C_003E8__locals37.npr.MGJ(CS_0024_003C_003E8__locals37.Wp8);
				CS_0024_003C_003E8__locals37.npr.uGT(func);
				goto IL_00ad;
			default:
				{
					if (!CS_0024_003C_003E8__locals37.dpE)
					{
						func(this, CS_0024_003C_003E8__locals37.npr, arg3: false);
						goto IL_00ad;
					}
					num = 1;
					if (pYP())
					{
						num = 1;
					}
					break;
				}
				IL_00ad:
				YMv();
				CS_0024_003C_003E8__locals37.npr.P2s(default(Point), P_2);
				return;
			}
		}
	}

	public void HvI(DockingWindow P_0, Point P_1, InputPointerEventArgs P_2)
	{
		_003C_003Ec__DisplayClass57_0 CS_0024_003C_003E8__locals66 = new _003C_003Ec__DisplayClass57_0();
		CS_0024_003C_003E8__locals66.rpv = this;
		CS_0024_003C_003E8__locals66.Up7 = P_0;
		if (CS_0024_003C_003E8__locals66.Up7 == null)
		{
			return;
		}
		CS_0024_003C_003E8__locals66.WpR = CS_0024_003C_003E8__locals66.Up7.IsCurrentlyOpen;
		CS_0024_003C_003E8__locals66.HpL = !CS_0024_003C_003E8__locals66.WpR || hvW.RQl() || !CS_0024_003C_003E8__locals66.Up7.CanFloatResolved;
		DockHost value = null;
		Control control = null;
		int num;
		if (CS_0024_003C_003E8__locals66.Up7.MkZ() is ToolWindowContainer toolWindowContainer)
		{
			control = toolWindowContainer;
			value = toolWindowContainer.DockHost;
			num = 0;
			if (!pYP())
			{
				goto IL_0005;
			}
			goto IL_0009;
		}
		if (CS_0024_003C_003E8__locals66.Up7.MkZ() is TabbedMdiContainer tabbedMdiContainer)
		{
			control = tabbedMdiContainer;
			value = tabbedMdiContainer.DockHost;
		}
		goto IL_0190;
		IL_01da:
		P_1 = P_2.GetPosition(hvW);
		goto IL_0176;
		IL_0005:
		int num2 = default(int);
		num = num2;
		goto IL_0009;
		IL_0176:
		if (!CS_0024_003C_003E8__locals66.HpL)
		{
			SMo(CS_0024_003C_003E8__locals66.Up7);
		}
		CS_0024_003C_003E8__locals66.op3 = hvW.i15();
		CS_0024_003C_003E8__locals66.op3.Cef(value);
		num = 0;
		if (pYP())
		{
			num = 3;
		}
		goto IL_0009;
		IL_0009:
		Func<Nx, DockHost, bool, lX> func;
		switch (num)
		{
		case 3:
			CS_0024_003C_003E8__locals66.op3.me4(CS_0024_003C_003E8__locals66.Up7.QkM());
			gM9(CS_0024_003C_003E8__locals66.op3);
			if (hvW.I1o(CS_0024_003C_003E8__locals66.op3, control, P_1, CS_0024_003C_003E8__locals66.HpL) is AM aM)
			{
				aM.gv4(hV.iN());
			}
			CS_0024_003C_003E8__locals66.ppS = CS_0024_003C_003E8__locals66.Up7 as ToolWindow;
			if (CS_0024_003C_003E8__locals66.ppS != null)
			{
				func = delegate(Nx processor, DockHost targetDockHost, bool onlyRemove)
				{
					CS_0024_003C_003E8__locals66.rpv.LMY(CS_0024_003C_003E8__locals66.Up7);
					processor.wMb(CS_0024_003C_003E8__locals66.Up7);
					if (!onlyRemove)
					{
						if (!CS_0024_003C_003E8__locals66.WpR)
						{
							CS_0024_003C_003E8__locals66.rpv.bMU(new DockingWindow[1] { CS_0024_003C_003E8__locals66.Up7 });
						}
						ToolWindowContainer toolWindowContainer2 = (ToolWindowContainer)(targetDockHost.Child = DockSite.dN2(targetDockHost));
						toolWindowContainer2.Windows.Add(CS_0024_003C_003E8__locals66.ppS);
						CS_0024_003C_003E8__locals66.rpv.hMZ(CS_0024_003C_003E8__locals66.ppS.UniqueId, CS_0024_003C_003E8__locals66.ppS.QkM(), targetDockHost);
						CS_0024_003C_003E8__locals66.Up7.PIg();
						if (!CS_0024_003C_003E8__locals66.WpR)
						{
							CS_0024_003C_003E8__locals66.rpv.hvW.d10(new DockingWindow[1] { CS_0024_003C_003E8__locals66.Up7 });
						}
					}
					else if (CS_0024_003C_003E8__locals66.HpL)
					{
						CS_0024_003C_003E8__locals66.Up7.ContainerDockedSize = CS_0024_003C_003E8__locals66.op3.Hen();
					}
					return CS_0024_003C_003E8__locals66.Up7;
				};
				goto IL_004c;
			}
			goto case 1;
		case 2:
			goto IL_01da;
		case 1:
			{
				func = delegate(Nx processor, DockHost targetDockHost, bool onlyRemove)
				{
					CS_0024_003C_003E8__locals66.rpv.LMY(CS_0024_003C_003E8__locals66.Up7);
					processor.wMb(CS_0024_003C_003E8__locals66.Up7);
					jJ jJ2 = CS_0024_003C_003E8__locals66.rpv.hvW.cQ4();
					if (!onlyRemove && jJ2 != null)
					{
						Workspace workspace = DockSite.HNe();
						if (workspace != null && jJ2.CloneForFloatingDockHost() is TabbedMdiHost tabbedMdiHost)
						{
							if (!CS_0024_003C_003E8__locals66.WpR)
							{
								CS_0024_003C_003E8__locals66.rpv.bMU(new DockingWindow[1] { CS_0024_003C_003E8__locals66.Up7 });
							}
							workspace.Content = tabbedMdiHost;
							targetDockHost.Child = workspace;
							TabbedMdiContainer tabbedMdiContainer2 = (TabbedMdiContainer)(tabbedMdiHost.Child = DockSite.gNd(targetDockHost));
							tabbedMdiContainer2.Windows.Add(CS_0024_003C_003E8__locals66.Up7);
							CS_0024_003C_003E8__locals66.rpv.hMZ(CS_0024_003C_003E8__locals66.Up7.UniqueId, CS_0024_003C_003E8__locals66.Up7.QkM(), targetDockHost);
							CS_0024_003C_003E8__locals66.Up7.PIg();
							if (!CS_0024_003C_003E8__locals66.WpR)
							{
								CS_0024_003C_003E8__locals66.rpv.hvW.d10(new DockingWindow[1] { CS_0024_003C_003E8__locals66.Up7 });
							}
						}
					}
					else if (CS_0024_003C_003E8__locals66.HpL)
					{
						CS_0024_003C_003E8__locals66.Up7.ContainerDockedSize = CS_0024_003C_003E8__locals66.op3.Hen();
					}
					return CS_0024_003C_003E8__locals66.Up7;
				};
				goto IL_004c;
			}
			IL_004c:
			if (CS_0024_003C_003E8__locals66.HpL)
			{
				CS_0024_003C_003E8__locals66.op3.MGJ(CS_0024_003C_003E8__locals66.Up7);
				CS_0024_003C_003E8__locals66.op3.uGT(func);
			}
			else
			{
				func(this, CS_0024_003C_003E8__locals66.op3, arg3: false);
				cP.Dl4(CS_0024_003C_003E8__locals66.Up7);
			}
			YMv();
			CS_0024_003C_003E8__locals66.op3.P2s(default(Point), P_2);
			return;
		}
		goto IL_0190;
		IL_0190:
		if (control == null)
		{
			num = 2;
			if (!pYP())
			{
				goto IL_0005;
			}
			goto IL_0009;
		}
		goto IL_0176;
	}

	public bool ovk(DockHost P_0)
	{
		if (P_0 != null)
		{
			IEnumerable<DockingWindow> source = from r in pL.Mxl<DockingWindow>(P_0, null)
				select r.dx3();
			if (source.Any() && source.All((DockingWindow dockingWindow) => dockingWindow.DockSite == hvW) && source.All((DockingWindow w) => w.CanFloatResolved))
			{
				gM9(P_0);
				DockHost dockHost = hvW.i15();
				dockHost.XeK(P_0.GeB());
				dockHost.beO(P_0.Hen());
				gM9(dockHost);
				gh obj = hvW.I1o(dockHost, null, default(Point), _0020: false);
				P_0.MGJ(null);
				if (P_0.PGO() != null)
				{
					P_0.PGO()(this, dockHost, arg3: false);
					P_0.uGT(null);
				}
				obj.Vmu(_0020: false, _0020: true, _0020: false);
				int num = 0;
				if (QYe() != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				default:
					cP.Dl4(dockHost);
					YMv();
					return true;
				}
			}
		}
		return false;
	}

	public bool ivC(DockingWindow P_0, int P_1)
	{
		if (P_0 != null)
		{
			DockingWindowContainerBase parentContainer = P_0.ParentContainer;
			if (parentContainer != null)
			{
				int num = parentContainer.WindowsCore.IndexOf(P_0);
				if (num == -1 || num == P_1)
				{
					return false;
				}
				LMY(P_0);
				bool isSelected = P_0.IsSelected;
				bool isActive = P_0.IsActive;
				if (isActive)
				{
					P_0.DockHost.Focus();
				}
				parentContainer.WindowsCore.RemoveAt(num);
				if (P_1 >= parentContainer.WindowsCore.Count)
				{
					parentContainer.WindowsCore.Add(P_0);
				}
				else
				{
					parentContainer.WindowsCore.Insert(Math.Max(P_1, 0), P_0);
				}
				if (isSelected)
				{
					qMD(P_0, isActive);
				}
				YMv();
				return true;
			}
		}
		return false;
	}

	public bool Nv1(DockingWindow P_0, IDockTarget P_1)
	{
		bool flag;
		bool isSelected;
		int num;
		if (P_0 != null)
		{
			DockHost dockHost = P_1 as DockHost;
			if (dockHost == null && P_1 != null)
			{
				dockHost = P_1.DockHost;
			}
			flag = P_0.IsCurrentlyOpen;
			if (flag && P_0.QkM() == DockingWindowState.Document && (P_1 == null || (P_1 == dockHost && P_0.DockHost == dockHost)))
			{
				return false;
			}
			LMY(P_0);
			if (!flag)
			{
				bMU(new DockingWindow[1] { P_0 });
			}
			isSelected = P_0.IsSelected;
			num = 0;
			if (!pYP())
			{
				goto IL_0005;
			}
			goto IL_0009;
		}
		return false;
		IL_0009:
		bool isActive = default(bool);
		do
		{
			switch (num)
			{
			default:
				isActive = P_0.IsActive;
				if (isActive)
				{
					SMo(P_0);
				}
				break;
			case 1:
				if (!flag)
				{
					hvW.d10(new DockingWindow[1] { P_0 });
				}
				if (isSelected)
				{
					qMD(P_0, isActive);
				}
				YMv();
				return true;
			}
			jMs(P_0, P_1, DockingWindowState.Document, null, 0);
			num = 1;
		}
		while (QYe() == null);
		goto IL_0005;
		IL_0005:
		int num2 = default(int);
		num = num2;
		goto IL_0009;
	}

	public void wvN(DockingWindow P_0)
	{
		if (P_0 != null)
		{
			if (!P_0.IsCurrentlyOpen)
			{
				LMY(P_0);
				bMU(new DockingWindow[1] { P_0 });
				jMs(P_0, null, null, null, 0);
				hvW.d10(new DockingWindow[1] { P_0 });
			}
			YMv();
		}
	}

	public void Restore(IEnumerable<DockingWindow> windows, DockHost preferredDockHost, DockingWindowState? state)
	{
		if (windows == null)
		{
			return;
		}
		DockingWindow[] array = windows.ToArray();
		if (array.Length == 0)
		{
			return;
		}
		XMp(array);
		DockingWindow[] array2 = array.Where((DockingWindow w) => !w.IsCurrentlyOpen).ToArray();
		if (array2.Length != 0)
		{
			bMU(array2);
		}
		DockingWindow activeWindow = hvW.ActiveWindow;
		DockingWindow dockingWindow = ((activeWindow != null && array.Contains(activeWindow)) ? activeWindow : null) ?? array.FirstOrDefault((DockingWindow w) => w.IsSelected);
		bool flag = false;
		if (dockingWindow != null)
		{
			flag = dockingWindow.IsActive;
			if (flag)
			{
				nMr(dockingWindow, array);
			}
		}
		DockingWindow dockingWindow2 = null;
		int num = 0;
		DockingWindow[] array3 = array;
		foreach (DockingWindow dockingWindow3 in array3)
		{
			if (dockingWindow2 == null)
			{
				jMs(dockingWindow3, preferredDockHost, state, null, 0);
				num = dockingWindow3.sIv() + 1;
				dockingWindow2 = dockingWindow3;
			}
			else
			{
				jMs(dockingWindow3, dockingWindow2, null, null, num++);
			}
		}
		if (array2.Length != 0)
		{
			hvW.d10(array2);
		}
		if (dockingWindow != null)
		{
			qMD(dockingWindow, flag);
		}
		YMv();
	}

	public void UvQ(Orientation P_0, int P_1)
	{
		foreach (DockHost item in hvW.eQY())
		{
			if (item == null || !(item.veR() is TabbedMdiHost tabbedMdiHost))
			{
				continue;
			}
			IList<DockingWindow> documents = tabbedMdiHost.GetDocuments();
			if (documents.Count <= 1)
			{
				continue;
			}
			DockingWindow primaryWindow = tabbedMdiHost.PrimaryWindow;
			bool flag = primaryWindow != null && (hvW.ActiveWindow == primaryWindow || cP.NlZ(primaryWindow));
			foreach (DockingWindow item2 in documents)
			{
				nMr(item2, documents);
				wMb(item2);
			}
			int num = (int)Math.Max(1.0, Math.Min(P_1, Math.Floor(Math.Sqrt(documents.Count))));
			int num2 = (int)Math.Ceiling((double)documents.Count / (double)num);
			int num3 = num * num2 - documents.Count;
			Orientation orientation = ((P_0 == Orientation.Horizontal) ? Orientation.Vertical : Orientation.Horizontal);
			SplitContainer splitContainer = DockSite.y1z(item, P_0);
			SplitContainer splitContainer2 = null;
			tabbedMdiHost.Child = splitContainer;
			int num4 = 0;
			int num5 = -1;
			foreach (DockingWindow item3 in documents)
			{
				if (num4 >= num5)
				{
					splitContainer2 = DockSite.y1z(item, orientation);
					splitContainer.Children.Add(splitContainer2);
					num4 = 0;
					num5 = num2 - ((num3 > 0) ? 1 : 0);
					if (num3 > 0)
					{
						num3--;
					}
				}
				TabbedMdiContainer tabbedMdiContainer = DockSite.gNd(item);
				tabbedMdiContainer.Windows.Add(item3);
				splitContainer2.Children.Add(tabbedMdiContainer);
				num4++;
			}
			splitContainer.ApplyTemplate();
			if (primaryWindow != null)
			{
				qMD(primaryWindow, flag);
			}
			YMv();
		}
	}

	[CompilerGenerated]
	private bool Avm(DockingWindow P_0)
	{
		if (P_0 != null && P_0.IsCurrentlyOpen && P_0.DockHost != null)
		{
			DockSite dockSite = P_0.DockHost.DockSite;
			if (dockSite != null)
			{
				return dockSite == hvW;
			}
			return true;
		}
		return false;
	}

	[CompilerGenerated]
	private bool mva(DockingWindow P_0)
	{
		return P_0.DockSite == hvW;
	}

	internal static bool pYP()
	{
		return qYS == null;
	}

	internal static Nx QYe()
	{
		return qYS;
	}
}
