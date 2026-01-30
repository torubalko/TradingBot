using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Threading;
using ActiproSoftware.Windows.Controls.Docking;
using ActiproSoftware.Windows.Controls.Docking.Primitives;
using ActiproSoftware.Windows.Themes;

namespace ActiproSoftware.Internal;

internal class EY : AM
{
	private class vVo : Window
	{
		private Point? Rsk;

		private DockSite bsC;

		private bool us1;

		private bool HsN;

		private bool gsQ;

		public static readonly RoutedEvent Ysm;

		public static readonly RoutedEvent Hsa;

		[CompilerGenerated]
		private EventHandler<WindowBoundsChangeEventArgs> RsW;

		[CompilerGenerated]
		private EventHandler<WindowBoundsChangeEventArgs> OsB;

		private static vVo khQ;

		public event EventHandler<WindowBoundsChangeEventArgs> WindowBoundsChanged
		{
			[CompilerGenerated]
			add
			{
				EventHandler<WindowBoundsChangeEventArgs> eventHandler = RsW;
				EventHandler<WindowBoundsChangeEventArgs> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<WindowBoundsChangeEventArgs> value2 = (EventHandler<WindowBoundsChangeEventArgs>)Delegate.Combine(eventHandler2, b5);
					eventHandler = Interlocked.CompareExchange(ref RsW, value2, eventHandler2);
				}
				while ((object)eventHandler != eventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				EventHandler<WindowBoundsChangeEventArgs> eventHandler = RsW;
				EventHandler<WindowBoundsChangeEventArgs> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<WindowBoundsChangeEventArgs> value2 = (EventHandler<WindowBoundsChangeEventArgs>)Delegate.Remove(eventHandler2, value3);
					eventHandler = Interlocked.CompareExchange(ref RsW, value2, eventHandler2);
				}
				while ((object)eventHandler != eventHandler2);
			}
		}

		public event EventHandler<WindowBoundsChangeEventArgs> WindowBoundsChanging
		{
			[CompilerGenerated]
			add
			{
				EventHandler<WindowBoundsChangeEventArgs> eventHandler = OsB;
				EventHandler<WindowBoundsChangeEventArgs> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<WindowBoundsChangeEventArgs> value2 = (EventHandler<WindowBoundsChangeEventArgs>)Delegate.Combine(eventHandler2, b5);
					eventHandler = Interlocked.CompareExchange(ref OsB, value2, eventHandler2);
				}
				while ((object)eventHandler != eventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				EventHandler<WindowBoundsChangeEventArgs> eventHandler = OsB;
				EventHandler<WindowBoundsChangeEventArgs> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<WindowBoundsChangeEventArgs> value2 = (EventHandler<WindowBoundsChangeEventArgs>)Delegate.Remove(eventHandler2, value3);
					eventHandler = Interlocked.CompareExchange(ref OsB, value2, eventHandler2);
				}
				while ((object)eventHandler != eventHandler2);
			}
		}

		public vVo(DockSite P_0)
		{
			IVH.CecNqz();
			base._002Ector();
			bsC = P_0;
			HsN = SystemParameters.DragFullWindows;
			base.AllowsTransparency = true;
			base.Background = Brushes.Transparent;
			base.ResizeMode = ResizeMode.NoResize;
			base.ShowInTaskbar = false;
			base.WindowStyle = WindowStyle.None;
			int num = 0;
			if (false)
			{
				int num2;
				num = num2;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		private void gpo(IntPtr P_0)
		{
			Rect rect = ((hV.UVV)Marshal.PtrToStructure(P_0, typeof(hV.UVV))).DSd();
			Point point = hV.Sk();
			if (!Rsk.HasValue)
			{
				Rsk = new Point(point.X - rect.X, point.Y - rect.Y);
			}
			double num = point.X - (rect.X + Rsk.Value.X);
			double num2 = point.Y - (rect.Y + Rsk.Value.Y);
			hV.nK(P_0, num, num2);
		}

		private void xpt()
		{
			Lsd();
			us1 = true;
		}

		private void Epu()
		{
			if (us1 && !HsN && bsC != null)
			{
				Point point = hV.iN();
				bsC.Q1R(point);
			}
		}

		private void Bpz(bool P_0)
		{
			WindowBoundsChangeEventArgs e = new WindowBoundsChangeEventArgs(P_0, Ysm, this);
			RsW?.Invoke(this, e);
		}

		private void wsi(bool P_0)
		{
			WindowBoundsChangeEventArgs e = new WindowBoundsChangeEventArgs(P_0, Hsa, this);
			OsB?.Invoke(this, e);
		}

		private void Lsd()
		{
			us1 = false;
		}

		private IntPtr qsw(IntPtr P_0, int P_1, IntPtr P_2, IntPtr P_3, ref bool P_4)
		{
			if (P_1 > 533)
			{
				if (P_1 != 534)
				{
					if (P_1 != 561)
					{
						if (P_1 == 562)
						{
							Lsd();
							if (gsQ)
							{
								Bpz(gsQ);
							}
						}
					}
					else
					{
						xpt();
						if (gsQ)
						{
							wsi(gsQ);
						}
					}
				}
				else
				{
					gpo(P_3);
					Epu();
				}
			}
			else if (P_1 != 274)
			{
				if (P_1 == 533 && !us1 && !hV.cs())
				{
					Bpz(gsQ);
				}
			}
			else
			{
				gsQ = (0xFFF0 & P_2.ToInt32()) == 61456;
			}
			return IntPtr.Zero;
		}

		protected override void OnContentChanged(object P_0, object P_1)
		{
			base.OnContentChanged(P_0, P_1);
			if (!HsN && P_1 is UIElement uIElement)
			{
				uIElement.Opacity = 0.0;
			}
		}

		protected override void OnSourceInitialized(EventArgs P_0)
		{
			base.OnSourceInitialized(P_0);
			IntPtr handle = new WindowInteropHelper(this).Handle;
			if (handle != IntPtr.Zero)
			{
				HwndSource.FromHwnd(handle).AddHook(qsw);
			}
		}

		static vVo()
		{
			IVH.CecNqz();
			Ysm = EventManager.RegisterRoutedEvent(vVK.ssH(28186), RoutingStrategy.Direct, typeof(EventHandler<WindowBoundsChangeEventArgs>), typeof(vVo));
			Hsa = EventManager.RegisterRoutedEvent(vVK.ssH(28228), RoutingStrategy.Direct, typeof(EventHandler<WindowBoundsChangeEventArgs>), typeof(vVo));
		}

		internal static bool Xhv()
		{
			return khQ == null;
		}

		internal static vVo whN()
		{
			return khQ;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass4_0
	{
		public EY RsJ;

		public bool zsn;

		private static _003C_003Ec__DisplayClass4_0 LhS;

		public _003C_003Ec__DisplayClass4_0()
		{
			IVH.CecNqz();
			base._002Ector();
		}

		internal void GsK()
		{
			_003C_003Ec__DisplayClass4_1 _003C_003Ec__DisplayClass4_ = new _003C_003Ec__DisplayClass4_1
			{
				Qs8 = this,
				dsT = RsJ.DockSite
			};
			if (_003C_003Ec__DisplayClass4_.dsT != null)
			{
				Action action = _003C_003Ec__DisplayClass4_.fsO;
				_003C_003Ec__DisplayClass4_.dsT.J1L(RsJ, zsn, action);
			}
		}

		internal static bool bhP()
		{
			return LhS == null;
		}

		internal static _003C_003Ec__DisplayClass4_0 Khe()
		{
			return LhS;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass4_1
	{
		public DockSite dsT;

		public _003C_003Ec__DisplayClass4_0 Qs8;

		internal static _003C_003Ec__DisplayClass4_1 IhJ;

		public _003C_003Ec__DisplayClass4_1()
		{
			IVH.CecNqz();
			base._002Ector();
		}

		internal void fsO()
		{
			if (!Qs8.zsn || !dsT.s1t().ovk(Qs8.RsJ.DockHost))
			{
				Qs8.RsJ.Wv9();
			}
		}

		internal static bool chU()
		{
			return IhJ == null;
		}

		internal static _003C_003Ec__DisplayClass4_1 ChF()
		{
			return IhJ;
		}
	}

	private DispatcherTimer pvo;

	private static EY pYR;

	public EY(DockHost P_0)
	{
		IVH.CecNqz();
		base._002Ector(P_0);
		Window window = Bvp();
		if (window != null)
		{
			FloatPreview content = new FloatPreview
			{
				Opacity = 0.4
			};
			window.Content = content;
		}
	}

	private void svh(object P_0, EventArgs P_1)
	{
		Qvy();
		Window window = Bvp();
		if (window != null && window.IsActive && !hV.cs())
		{
			Wv9();
		}
	}

	private void bvg(object P_0, WindowBoundsChangeEventArgs P_1)
	{
		_003C_003Ec__DisplayClass4_0 CS_0024_003C_003E8__locals6 = new _003C_003Ec__DisplayClass4_0();
		CS_0024_003C_003E8__locals6.RsJ = this;
		nvY();
		Window window = Bvp();
		if (window == null)
		{
			return;
		}
		window.Opacity = 0.0;
		CS_0024_003C_003E8__locals6.zsn = !Keyboard.IsKeyDown(Key.Escape);
		window.Dispatcher.BeginInvoke(DispatcherPriority.Loaded, (Action)delegate
		{
			_003C_003Ec__DisplayClass4_1 _003C_003Ec__DisplayClass4_ = new _003C_003Ec__DisplayClass4_1();
			_003C_003Ec__DisplayClass4_.Qs8 = CS_0024_003C_003E8__locals6;
			_003C_003Ec__DisplayClass4_.dsT = CS_0024_003C_003E8__locals6.RsJ.DockSite;
			if (_003C_003Ec__DisplayClass4_.dsT != null)
			{
				Action action = _003C_003Ec__DisplayClass4_.fsO;
				_003C_003Ec__DisplayClass4_.dsT.J1L(CS_0024_003C_003E8__locals6.RsJ, CS_0024_003C_003E8__locals6.zsn, action);
			}
		});
	}

	private void FvX(object P_0, WindowBoundsChangeEventArgs P_1)
	{
		if (P_1 != null && P_1.IsMove)
		{
			DockSite dockSite = base.DockSite;
			DockHost dockHost = base.DockHost;
			if (dockSite != null && dockHost != null)
			{
				fv6();
			}
		}
	}

	private void nv5()
	{
		if (pvo == null)
		{
			pvo = new DispatcherTimer();
			pvo.Interval = TimeSpan.FromSeconds(1.0);
			pvo.Tick += svh;
			pvo.Start();
		}
	}

	private void Qvy()
	{
		if (pvo != null)
		{
			pvo.Tick -= svh;
			pvo.Stop();
			pvo = null;
		}
	}

	protected override void voP()
	{
		Qvs(new vVo(base.DockSite));
	}

	protected override void Xmv()
	{
	}

	protected override void rmT()
	{
	}

	protected override void HmR()
	{
		Window window = Bvp();
		il il2 = dvf();
		if (window != null)
		{
			bool flag = il2 != null && il2.yR2() && il2.ARI() != null;
			window.Opacity = (flag ? 0.0 : 1.0);
		}
	}

	protected override void Qob(Window P_0, Window P_1)
	{
		if (P_0 is vVo vVo)
		{
			vVo.WindowBoundsChanged -= bvg;
			vVo.WindowBoundsChanging -= FvX;
		}
		if (P_1 is vVo vVo2)
		{
			vVo2.WindowBoundsChanged += bvg;
			vVo2.WindowBoundsChanging += FvX;
		}
	}

	protected override void QoE()
	{
		Qvy();
	}

	public override void Vmu(bool P_0, bool P_1, bool P_2)
	{
		Window window = Bvp();
		if (window == null)
		{
			return;
		}
		DockSite dockSite = base.DockSite;
		if (dockSite != null)
		{
			Window window2 = Yp.iRU(dockSite);
			if (window.Owner != window2)
			{
				window.Owner = window2;
			}
			gmm();
			if (P_0 && dockSite.IsFloatingWindowSnapToScreenEnabled)
			{
				dmw();
			}
		}
		window.ShowActivated = P_1;
		window.Show();
		nv5();
	}

	internal static bool OYD()
	{
		return pYR == null;
	}

	internal static EY WYE()
	{
		return pYR;
	}
}
