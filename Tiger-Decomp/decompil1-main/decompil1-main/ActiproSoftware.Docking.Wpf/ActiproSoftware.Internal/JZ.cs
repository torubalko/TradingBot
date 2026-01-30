using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Interop;
using System.Windows.Threading;
using ActiproSoftware.Windows;
using ActiproSoftware.Windows.Controls;
using ActiproSoftware.Windows.Controls.Docking;
using ActiproSoftware.Windows.Themes;

namespace ActiproSoftware.Internal;

internal class JZ : AM
{
	private class UVU : Window, X8
	{
		private Point? IpV;

		private bool tpP;

		private bool dpf;

		private double ipU;

		private double mpc;

		private List<X8> Wp4;

		private bool Gpj;

		internal static UVU Gh5;

		public Rect Bounds => hV.sm(this);

		private void Yp6(IntPtr P_0)
		{
			if (Wp4 != null && Wp4.Count != 0)
			{
				Rect rect = ((hV.UVV)Marshal.PtrToStructure(P_0, typeof(hV.UVV))).DSd();
				Point point = hV.Sk();
				if (!IpV.HasValue)
				{
					IpV = new Point(point.X - rect.X, point.Y - rect.Y);
				}
				double num = point.X - (rect.X + IpV.Value.X);
				double num2 = point.Y - (rect.Y + IpV.Value.Y);
				hV.nK(P_0, num, num2);
				rect.X += num;
				rect.Y += num2;
				Rect rect2 = CG.XvJ(ipU, mpc, Wp4, this, rect);
				if (rect != rect2)
				{
					num = rect2.X - rect.X;
					num2 = rect2.Y - rect.Y;
					hV.nK(P_0, num, num2);
				}
			}
		}

		private void ip9(IntPtr P_0, IntPtr P_1)
		{
			if (Wp4 == null || Wp4.Count == 0)
			{
				return;
			}
			ResizeOperation? resizeOperation = hV.La(P_0);
			if (!resizeOperation.HasValue)
			{
				return;
			}
			Rect rect = ((hV.UVV)Marshal.PtrToStructure(P_1, typeof(hV.UVV))).DSd();
			double num = rect.Left;
			int num2 = 1;
			if (Cht() != null)
			{
				num2 = 1;
			}
			double num6;
			double num3 = default(double);
			double num4 = default(double);
			int num5 = default(int);
			while (true)
			{
				switch (num2)
				{
				case 2:
					num6 = Math.Round(CG.Yvn(ipU, mpc, Wp4, this, rect, rect.Bottom, Side.Bottom));
					break;
				default:
				{
					num6 = rect.Bottom;
					switch (resizeOperation.Value)
					{
					case ResizeOperation.East:
					case ResizeOperation.NorthEast:
					case ResizeOperation.SouthEast:
						num3 = Math.Round(CG.Yvn(ipU, mpc, Wp4, this, rect, rect.Right, Side.Right));
						break;
					case ResizeOperation.West:
					case ResizeOperation.NorthWest:
					case ResizeOperation.SouthWest:
						num = Math.Round(CG.Yvn(ipU, mpc, Wp4, this, rect, rect.Left, Side.Left));
						break;
					}
					if (!resizeOperation.HasValue)
					{
						break;
					}
					ResizeOperation valueOrDefault = resizeOperation.GetValueOrDefault();
					if ((uint)(valueOrDefault - 61443) > 2u)
					{
						if ((uint)(valueOrDefault - 61446) > 2u)
						{
							break;
						}
						goto case 2;
					}
					num4 = Math.Round(CG.Yvn(ipU, mpc, Wp4, this, rect, rect.Top, Side.Top));
					break;
				}
				case 1:
					num3 = rect.Right;
					num4 = rect.Top;
					num2 = 0;
					if (Cht() != null)
					{
						num2 = num5;
					}
					continue;
				}
				break;
			}
			Rect rect2 = new Rect(num, num4, num3 - num, num6 - num4);
			if (rect != rect2)
			{
				Marshal.StructureToPtr(new hV.UVV(rect2), P_1, fDeleteOld: false);
			}
		}

		private void tpY()
		{
			Cpq();
			tpP = true;
			dpf = SystemParameters.DragFullWindows;
			if (!(base.Content is DockHost { DockSite: { } dockSite } dockHost))
			{
				return;
			}
			ipU = dockSite.MagnetismGapDistance;
			mpc = dockSite.MagnetismSnapDistance;
			int num = 0;
			if (!hhj())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			if (!(mpc > 0.0))
			{
				return;
			}
			Wp4 = new List<X8>();
			foreach (DockHost item in dockSite.eQY())
			{
				if (item != null && item != dockHost)
				{
					Window window = Yp.iRU(item);
					if (window != null)
					{
						Wp4.Add(new pVR(window));
					}
				}
			}
		}

		private void ipp()
		{
			if (tpP && !dpf && base.Content is DockHost { DockSite: { } dockSite })
			{
				Point point = hV.iN();
				dockSite.Q1R(point);
			}
		}

		private void Gps(IntPtr P_0, IntPtr P_1)
		{
			if (P_0 == IntPtr.Zero && P_1.ToInt32() == 1)
			{
				Gpj = base.WindowState == WindowState.Maximized;
			}
		}

		private void Cpq()
		{
			Wp4 = null;
			IpV = null;
			tpP = false;
		}

		private IntPtr QpF(IntPtr P_0, int P_1, IntPtr P_2, IntPtr P_3, ref bool P_4)
		{
			switch (P_1)
			{
			case 561:
				tpY();
				break;
			case 562:
				Cpq();
				break;
			case 534:
				Yp6(P_3);
				ipp();
				break;
			case 24:
				Gps(P_2, P_3);
				break;
			case 532:
				ip9(P_2, P_3);
				break;
			}
			return IntPtr.Zero;
		}

		protected override void OnSourceInitialized(EventArgs P_0)
		{
			base.OnSourceInitialized(P_0);
			IntPtr handle = new WindowInteropHelper(this).Handle;
			if (handle != IntPtr.Zero)
			{
				HwndSource.FromHwnd(handle).AddHook(QpF);
			}
		}

		protected override void OnStateChanged(EventArgs P_0)
		{
			base.OnStateChanged(P_0);
			WindowState windowState = base.WindowState;
			if (Gpj && windowState != WindowState.Minimized)
			{
				Gpj = false;
				if (windowState == WindowState.Normal)
				{
					base.WindowState = WindowState.Maximized;
				}
			}
		}

		public UVU()
		{
			IVH.CecNqz();
			base._002Ector();
		}

		internal static bool hhj()
		{
			return Gh5 == null;
		}

		internal static UVU Cht()
		{
			return Gh5;
		}
	}

	private class pVR : X8
	{
		[CompilerGenerated]
		private Rect Spb;

		internal static pVR lhp;

		public Rect Bounds
		{
			[CompilerGenerated]
			get
			{
				return Spb;
			}
			[CompilerGenerated]
			private set
			{
				Spb = spb;
			}
		}

		public pVR(Window P_0)
		{
			IVH.CecNqz();
			base._002Ector();
			if (P_0 == null)
			{
				throw new ArgumentNullException(vVK.ssH(9098));
			}
			Bounds = hV.sm(P_0);
		}

		internal static bool Uh4()
		{
			return lhp == null;
		}

		internal static pVR Mh2()
		{
			return lhp;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass11_0
	{
		public Window DpH;

		public JZ op0;

		internal static _003C_003Ec__DisplayClass11_0 mh6;

		public _003C_003Ec__DisplayClass11_0()
		{
			IVH.CecNqz();
			base._002Ector();
		}

		internal void CpA()
		{
			if (DpH == null || !DpH.IsActive)
			{
				return;
			}
			object obj = cP.hlj();
			bool flag = obj == null || obj == DpH || !DpH.IsKeyboardFocusWithin;
			if (flag)
			{
				HwndHost hwndHost = InteropFocusTracking.GmZ();
				if (hwndHost != null && DpH == Window.GetWindow(hwndHost))
				{
					flag = false;
				}
			}
			if (flag)
			{
				DockHost dockHost = op0.DockHost;
				if (dockHost != null)
				{
					cP.Dl4(dockHost);
				}
			}
		}

		internal static bool zhW()
		{
			return mh6 == null;
		}

		internal static _003C_003Ec__DisplayClass11_0 DhI()
		{
			return mh6;
		}
	}

	private WindowChrome chrome;

	private WindowState? nvl;

	private static JZ hYd;

	[SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
	private WindowChrome evx
	{
		get
		{
			return chrome;
		}
		set
		{
			if (chrome == windowChrome)
			{
				return;
			}
			if (chrome != null)
			{
				chrome.TitleBarContextMenuRequested -= jvO;
				chrome.WindowBoundsChanged -= OvT;
				chrome.WindowBoundsChanging -= mv8;
			}
			chrome = windowChrome;
			int num = 0;
			if (!zY7())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			if (chrome != null)
			{
				chrome.TitleBarContextMenuRequested += jvO;
				chrome.WindowBoundsChanged += OvT;
				chrome.WindowBoundsChanging += mv8;
			}
		}
	}

	[SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
	public JZ(DockHost P_0)
	{
		IVH.CecNqz();
		base._002Ector(P_0);
		Window window = Bvp();
		if (window != null)
		{
			window.WindowState = P_0.zeZ();
			window.Content = P_0;
			Fmr();
		}
	}

	private void jvO(object P_0, CancelRoutedEventArgs P_1)
	{
		DockHost dockHost = base.DockHost;
		if (P_1 == null || dockHost == null || dockHost.BGW())
		{
			return;
		}
		int num = 0;
		if (!zY7())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		IList<b4<ToolWindowContainer>> list = pL.Mxl<ToolWindowContainer>(dockHost, null);
		if (list == null)
		{
			return;
		}
		foreach (b4<ToolWindowContainer> item in list)
		{
			ToolWindowContainer toolWindowContainer = item.dx3();
			if (toolWindowContainer != null && toolWindowContainer.SelectedWindow != null)
			{
				P_1.Cancel = toolWindowContainer.tB0(null);
				break;
			}
		}
	}

	private void OvT(object P_0, WindowBoundsChangeEventArgs P_1)
	{
		base.DockSite?.J1L(this, _0020: true, null);
	}

	private void mv8(object P_0, WindowBoundsChangeEventArgs P_1)
	{
		if (P_1 != null && P_1.IsMove)
		{
			DockSite dockSite = base.DockSite;
			DockHost dockHost = base.DockHost;
			if (dockSite != null && dockHost != null)
			{
				dockSite.Q1S(this);
			}
		}
	}

	private void avD(object P_0, EventArgs P_1)
	{
		_003C_003Ec__DisplayClass11_0 CS_0024_003C_003E8__locals10 = new _003C_003Ec__DisplayClass11_0();
		CS_0024_003C_003E8__locals10.op0 = this;
		CS_0024_003C_003E8__locals10.DpH = Bvp();
		if (CS_0024_003C_003E8__locals10.DpH == null)
		{
			return;
		}
		CS_0024_003C_003E8__locals10.DpH.Dispatcher.BeginInvoke(DispatcherPriority.Input, (Action)delegate
		{
			if (CS_0024_003C_003E8__locals10.DpH != null && CS_0024_003C_003E8__locals10.DpH.IsActive)
			{
				object obj = cP.hlj();
				bool flag = obj == null || obj == CS_0024_003C_003E8__locals10.DpH || !CS_0024_003C_003E8__locals10.DpH.IsKeyboardFocusWithin;
				if (flag)
				{
					HwndHost hwndHost = InteropFocusTracking.GmZ();
					if (hwndHost != null && CS_0024_003C_003E8__locals10.DpH == Window.GetWindow(hwndHost))
					{
						flag = false;
					}
				}
				if (flag)
				{
					DockHost dockHost = CS_0024_003C_003E8__locals10.op0.DockHost;
					if (dockHost != null)
					{
						cP.Dl4(dockHost);
					}
				}
			}
		});
	}

	protected override void voP()
	{
		if (Bvp() == null)
		{
			evx = new WindowChrome();
			Qvs(new UVU());
		}
	}

	protected override void Xmv()
	{
		DockHost dockHost = base.DockHost;
		Window window = Bvp();
		if (dockHost != null && window != null && window.WindowState != dockHost.zeZ())
		{
			if (dockHost.zeZ() == WindowState.Minimized)
			{
				window.ShowInTaskbar = true;
			}
			window.WindowState = dockHost.zeZ();
		}
	}

	protected override void rmT()
	{
		Fmr();
	}

	protected override void QoE()
	{
		evx = null;
	}

	protected override void Qob(Window P_0, Window P_1)
	{
		if (P_0 != null)
		{
			P_0.Activated -= avD;
		}
		if (P_1 != null)
		{
			P_1.Activated += avD;
			WindowChrome.SetChrome(P_1, chrome);
		}
	}

	protected override void Eoc()
	{
		if (nvl.HasValue)
		{
			WindowState value = nvl.Value;
			nvl = null;
			Window window = Bvp();
			if (window != null)
			{
				window.WindowState = value;
			}
		}
	}

	public override void Vmu(bool P_0, bool P_1, bool P_2)
	{
		Window window = Bvp();
		if (window == null)
		{
			return;
		}
		if (window.WindowState != WindowState.Normal)
		{
			nvl = window.WindowState;
			window.WindowState = WindowState.Normal;
		}
		else
		{
			nvl = null;
		}
		if (P_2)
		{
			window.SizeToContent = SizeToContent.WidthAndHeight;
		}
		else
		{
			gmm();
			DockSite dockSite = base.DockSite;
			if (P_0 && dockSite != null && dockSite.IsFloatingWindowSnapToScreenEnabled)
			{
				dmw();
			}
		}
		window.ShowActivated = P_1;
		window.Show();
		if (P_1)
		{
			window.Activate();
		}
		else
		{
			window.ShowActivated = true;
		}
		window.SizeToContent = SizeToContent.Manual;
	}

	protected override void goy()
	{
		Window window = Bvp();
		DockHost dockHost = base.DockHost;
		if (window != null && dockHost != null)
		{
			window.ShowInTaskbar = dockHost.feF() || window.WindowState == WindowState.Minimized;
		}
	}

	protected override void Fmr()
	{
		DockHost dockHost = base.DockHost;
		Window window = Bvp();
		if (dockHost == null || window == null || chrome == null)
		{
			return;
		}
		DockSite dockSite = base.DockSite;
		if (dockSite == null)
		{
			return;
		}
		WindowStyle windowStyle = (dockHost.BGW() ? WindowStyle.ThreeDBorderWindow : WindowStyle.None);
		if (window.WindowStyle != windowStyle)
		{
			WindowChrome.SetWindowStyle(window, windowStyle);
		}
		kq kq2 = dockHost.LayoutKind;
		if ((uint)(kq2 - 1) <= 1u)
		{
			chrome.HasMaximizeButton = dockSite.FloatingToolWindowContainersHaveMaximizeButtons;
			chrome.HasMinimizeButton = dockSite.FloatingToolWindowContainersHaveMinimizeButtons;
		}
		chrome.HasCloseButton = dockHost.CanClose;
		if (dockHost.wGm())
		{
			Window window2 = Yp.iRU(dockSite);
			if (window.Owner != window2)
			{
				window.Owner = window2;
			}
		}
		else if (window.Owner != null)
		{
			window.Owner = null;
		}
		goy();
		WindowChrome.SetElementKind(window, (!dockHost.BGW()) ? WindowChromeElementKind.NonClientArea : WindowChromeElementKind.ClientArea);
	}

	protected override void amx()
	{
		DockHost dockHost = base.DockHost;
		if (dockHost != null && chrome != null)
		{
			chrome.HasCloseButton = dockHost.CanClose;
		}
	}

	internal static bool zY7()
	{
		return hYd == null;
	}

	internal static JZ mYO()
	{
		return hYd;
	}
}
