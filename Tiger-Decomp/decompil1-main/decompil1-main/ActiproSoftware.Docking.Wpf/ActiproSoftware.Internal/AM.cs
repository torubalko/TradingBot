using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;
using ActiproSoftware.Windows.Controls.Docking;
using ActiproSoftware.Windows.Extensions;
using ActiproSoftware.Windows.Input;
using ActiproSoftware.Windows.Themes;

namespace ActiproSoftware.Internal;

internal abstract class AM : xN
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass30_0
	{
		public X9 Apg;

		public AM opX;

		public Point Gp5;

		public Point Gpy;

		internal static _003C_003Ec__DisplayClass30_0 Dha;

		public _003C_003Ec__DisplayClass30_0()
		{
			IVH.CecNqz();
			base._002Ector();
		}

		internal void lph(Window window)
		{
			if (((Apg != null && Apg.sIJ() != null) ? Apg.sIJ().DeviceKind : InputDeviceKind.Mouse) != InputDeviceKind.Touch && window.WindowStartupLocation == WindowStartupLocation.Manual)
			{
				Point point = hV.iN();
				Point point2 = new Point(point.X - Gp5.X, point.Y - Gp5.Y);
				if (point2.X != 0.0)
				{
					window.Left += point2.X * ((Gpy.X > 0.0) ? (1.0 / Gpy.X) : 1.0);
				}
				if (point2.Y != 0.0)
				{
					window.Top += point2.Y * ((Gpy.Y > 0.0) ? (1.0 / Gpy.Y) : 1.0);
				}
			}
			if (!hV.IG(window))
			{
				opX.Wv9();
			}
		}

		internal static bool qhX()
		{
			return Dha == null;
		}

		internal static _003C_003Ec__DisplayClass30_0 dhs()
		{
			return Dha;
		}
	}

	private il mvZ;

	private bool pvb;

	private Window FvA;

	[CompilerGenerated]
	private bool uvH;

	[CompilerGenerated]
	private Point? hv0;

	internal static AM HYb;

	public override Point Location
	{
		get
		{
			if (FvA == null)
			{
				return default(Point);
			}
			return new Point(FvA.Left, FvA.Top);
		}
		set
		{
			if (FvA != null)
			{
				FvA.Left = point.X;
				FvA.Top = point.Y;
			}
		}
	}

	[SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
	protected AM(DockHost P_0)
	{
		IVH.CecNqz();
		base._002Ector(P_0);
		voP();
		if (FvA == null)
		{
			return;
		}
		nvV(_0020: true);
		FvA.Width = Math.Max(FvA.MinWidth, Math.Min(FvA.MaxWidth, P_0.Hen().Width));
		FvA.Height = Math.Max(FvA.MinHeight, Math.Min(FvA.MaxHeight, P_0.Hen().Height));
		Point? point = P_0.GeB();
		if (point.HasValue)
		{
			FvA.WindowStartupLocation = WindowStartupLocation.Manual;
			FvA.Left = point.Value.X;
			FvA.Top = point.Value.Y;
			return;
		}
		FvA.WindowStartupLocation = WindowStartupLocation.CenterOwner;
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

	private void gvM(object P_0, EventArgs P_1)
	{
		HmR();
	}

	private void Gvv(object P_0, EventArgs P_1)
	{
		if (FvA != null)
		{
			FvA.Content = null;
		}
		QoE();
		Qvs(null);
	}

	private void fv7(object P_0, CancelEventArgs P_1)
	{
		if (pvb || P_1 == null || P_1.Cancel)
		{
			return;
		}
		DockHost dockHost = base.DockHost;
		if (dockHost == null)
		{
			return;
		}
		if (!dockHost.CanClose)
		{
			P_1.Cancel = true;
			return;
		}
		try
		{
			pvb = true;
			P_1.Cancel = !dockHost.Close(dockHost.aG2());
		}
		finally
		{
			pvb = false;
		}
	}

	private void fvR(object P_0, RoutedEventArgs P_1)
	{
		Eoc();
	}

	private void UvS(object P_0, EventArgs P_1)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (base.DockHost == null)
				{
					return;
				}
				num2 = 0;
				if (nYx() == null)
				{
					num2 = 0;
				}
				continue;
			}
			if (FvA != null)
			{
				if (FvA.WindowState == WindowState.Normal && Location != new Point(-32000.0, -32000.0))
				{
					Al3();
				}
				DockSite dockSite = base.DockSite;
				if (dockSite != null && dockSite.gQ6())
				{
					Point point = hV.iN();
					dockSite.Q1R(point);
				}
			}
			return;
		}
	}

	private void JvL(object P_0, SizeChangedEventArgs P_1)
	{
		DockHost dockHost = base.DockHost;
		if (dockHost == null || FvA == null)
		{
			return;
		}
		Size value = new Size(FvA.Width, FvA.Height);
		if (dockHost.Child is wH wH2)
		{
			int num = 0;
			if (nYx() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			if (dockHost.Hen().Width != value.Width)
			{
				wH2.DockedSize = new Size(value.Width, wH2.DockedSize.Height);
			}
			if (dockHost.Hen().Height != value.Height)
			{
				wH2.DockedSize = new Size(wH2.DockedSize.Width, value.Height);
			}
		}
		if (FvA.WindowState == WindowState.Normal)
		{
			dockHost.beO(value);
		}
	}

	private void Ev3(object P_0, EventArgs P_1)
	{
		DockHost dockHost = base.DockHost;
		if (dockHost != null && FvA != null)
		{
			dockHost.Qeb(FvA.WindowState);
			goy();
		}
	}

	[SpecialName]
	internal Window Bvp()
	{
		return FvA;
	}

	[SpecialName]
	internal void Qvs(Window P_0)
	{
		if (FvA == P_0)
		{
			return;
		}
		Window fvA = FvA;
		if (FvA != null)
		{
			FvA.Closed -= Gvv;
			FvA.Closing -= fv7;
			FvA.Loaded -= fvR;
			FvA.LocationChanged -= UvS;
			FvA.SizeChanged -= JvL;
			FvA.StateChanged -= Ev3;
			WindowChrome.SetChrome(FvA, null);
			BindingOperations.ClearBinding(FvA, Window.IconProperty);
			BindingOperations.ClearBinding(FvA, Window.TitleProperty);
			BindingOperations.ClearBinding(FvA, FrameworkElement.FlowDirectionProperty);
		}
		FvA = P_0;
		if (FvA != null)
		{
			FvA.Closed += Gvv;
			FvA.Closing += fv7;
			FvA.Loaded += fvR;
			FvA.LocationChanged += UvS;
			FvA.SizeChanged += JvL;
			FvA.StateChanged += Ev3;
			DockHost dockHost = base.DockHost;
			if (dockHost != null)
			{
				FvA.BindToProperty(Window.IconProperty, dockHost, vVK.ssH(7326), BindingMode.OneWay);
				FvA.BindToProperty(Window.TitleProperty, dockHost, vVK.ssH(7338), BindingMode.OneWay);
				DockSite dockSite = base.DockSite;
				if (dockSite != null)
				{
					FvA.BindToProperty(FrameworkElement.FlowDirectionProperty, dockSite, vVK.ssH(23354), BindingMode.OneWay);
					Size left = new Size(1.0, 1.0);
					Window window = Yp.iRU(dockSite, _0020: true);
					if (window != null)
					{
						left = dockSite.TransformToAncestor(window).TransformBounds(new Rect(0.0, 0.0, 1.0, 1.0)).Size;
					}
					if (left.IsEffectivelyEqual(new Size(1.0, 1.0)))
					{
						dockHost.LayoutTransform = null;
					}
					else
					{
						dockHost.LayoutTransform = new ScaleTransform(left.Width, left.Height);
					}
				}
			}
		}
		Qob(fvA, FvA);
	}

	protected override void gmm()
	{
		DockHost dockHost = base.DockHost;
		DockSite dockSite = base.DockSite;
		if (FvA == null || FvA.WindowState != WindowState.Normal || dockHost == null || dockSite == null)
		{
			return;
		}
		Size size = dockHost.Hen();
		FloatingWindowOpeningEventArgs e = new FloatingWindowOpeningEventArgs(dockHost)
		{
			Size = size
		};
		dockSite.f13(e);
		Size size2 = e.Size;
		if (size.Width != size2.Width)
		{
			FvA.Width = size2.Width;
		}
		if (size.Height != size2.Height)
		{
			FvA.Height = size2.Height;
			int num = 0;
			if (nYx() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}
	}

	protected void fv6()
	{
		DockSite dockSite = base.DockSite;
		if (mvZ == null && dockSite != null)
		{
			mvZ = dockSite.Q1S(this);
			mvZ.VRC(gvM);
		}
	}

	public override void Kmi()
	{
		base.DockSite?.J1L(this, _0020: false, null);
	}

	[SpecialName]
	[CompilerGenerated]
	public bool kvF()
	{
		return uvH;
	}

	[SpecialName]
	[CompilerGenerated]
	public void nvV(bool P_0)
	{
		uvH = P_0;
	}

	public void Wv9()
	{
		DockHost dockHost = base.DockHost;
		if (dockHost != null && dockHost.aG2())
		{
			dockHost.MGJ(null);
			dockHost.uGT(null);
			dockHost.Close(forceDestroy: true);
		}
	}

	protected void nvY()
	{
		if (mvZ != null)
		{
			mvZ.GR1(gvM);
			mvZ = null;
		}
	}

	[SpecialName]
	protected il dvf()
	{
		return mvZ;
	}

	protected abstract void voP();

	protected override void gmo()
	{
		if (base.DockHost != null)
		{
			base.DockHost = null;
			if (!pvb && FvA != null)
			{
				FvA.Close();
			}
		}
	}

	protected override void im1(X9 P_0)
	{
		_003C_003Ec__DisplayClass30_0 CS_0024_003C_003E8__locals19 = new _003C_003Ec__DisplayClass30_0();
		CS_0024_003C_003E8__locals19.Apg = P_0;
		CS_0024_003C_003E8__locals19.opX = this;
		if (FvA == null)
		{
			return;
		}
		if (CS_0024_003C_003E8__locals19.Apg != null)
		{
			if (CS_0024_003C_003E8__locals19.Apg.VIW().X != 0.0)
			{
				FvA.Left += CS_0024_003C_003E8__locals19.Apg.VIW().X;
			}
			if (CS_0024_003C_003E8__locals19.Apg.VIW().Y != 0.0)
			{
				FvA.Top += CS_0024_003C_003E8__locals19.Apg.VIW().Y;
			}
		}
		if (!FvA.IsActive)
		{
			Vmu(_0020: false, _0020: true, _0020: false);
		}
		if (hvc().HasValue)
		{
			CS_0024_003C_003E8__locals19.Gp5 = hvc().Value;
			gv4(null);
			CS_0024_003C_003E8__locals19.Gpy = hV.mC(FvA);
			Yp.gRf(FvA, delegate(Window window)
			{
				if (((CS_0024_003C_003E8__locals19.Apg != null && CS_0024_003C_003E8__locals19.Apg.sIJ() != null) ? CS_0024_003C_003E8__locals19.Apg.sIJ().DeviceKind : InputDeviceKind.Mouse) != InputDeviceKind.Touch && window.WindowStartupLocation == WindowStartupLocation.Manual)
				{
					Point point = hV.iN();
					Point point2 = new Point(point.X - CS_0024_003C_003E8__locals19.Gp5.X, point.Y - CS_0024_003C_003E8__locals19.Gp5.Y);
					if (point2.X != 0.0)
					{
						window.Left += point2.X * ((CS_0024_003C_003E8__locals19.Gpy.X > 0.0) ? (1.0 / CS_0024_003C_003E8__locals19.Gpy.X) : 1.0);
					}
					if (point2.Y != 0.0)
					{
						window.Top += point2.Y * ((CS_0024_003C_003E8__locals19.Gpy.Y > 0.0) ? (1.0 / CS_0024_003C_003E8__locals19.Gpy.Y) : 1.0);
					}
				}
				if (!hV.IG(window))
				{
					CS_0024_003C_003E8__locals19.opX.Wv9();
				}
			}, FvA);
		}
		else if (!hV.IG(FvA))
		{
			Wv9();
		}
	}

	protected override void LmI()
	{
		if (!kvF())
		{
			return;
		}
		DockHost dockHost = base.DockHost;
		Window window = Bvp();
		int num = 0;
		if (!WYT())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (dockHost != null && window != null)
		{
			Thickness borderThickness = window.BorderThickness;
			Size size = dockHost.OG1();
			window.MinWidth = borderThickness.Left + size.Width + borderThickness.Right;
			window.MinHeight = borderThickness.Top + size.Height + borderThickness.Bottom;
		}
	}

	protected virtual void HmR()
	{
	}

	protected virtual void Qob(Window P_0, Window P_1)
	{
	}

	protected virtual void QoE()
	{
	}

	protected virtual void Eoc()
	{
	}

	[SpecialName]
	[CompilerGenerated]
	public Point? hvc()
	{
		return hv0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void gv4(Point? P_0)
	{
		hv0 = P_0;
	}

	protected override void dmw()
	{
		DockSite dockSite = base.DockSite;
		if (dockSite != null && FvA != null)
		{
			Rect rect = hV.mI(new Rect(FvA.Left, FvA.Top, FvA.Width, FvA.Height), dockSite.FloatingWindowSnapToScreenThreshold);
			if (FvA.Left != rect.Left)
			{
				FvA.Left = rect.Left;
			}
			if (FvA.Top != rect.Top)
			{
				FvA.Top = rect.Top;
			}
		}
	}

	protected virtual void goy()
	{
	}

	protected virtual void Fmr()
	{
	}

	[SpecialName]
	public override Window NmX()
	{
		return FvA;
	}

	internal static bool WYT()
	{
		return HYb == null;
	}

	internal static AM nYx()
	{
		return HYb;
	}
}
