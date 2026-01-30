using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using ActiproSoftware.Windows.Controls;
using ActiproSoftware.Windows.Controls.Docking;
using ActiproSoftware.Windows.Controls.Docking.Primitives;
using ActiproSoftware.Windows.Extensions;
using ActiproSoftware.Windows.Input;

namespace ActiproSoftware.Internal;

internal abstract class Qi : xN
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass6_0
	{
		public Qi u93;

		public bool b96;

		private static _003C_003Ec__DisplayClass6_0 yMI;

		public _003C_003Ec__DisplayClass6_0()
		{
			IVH.CecNqz();
			base._002Ector();
		}

		internal void i9L()
		{
			u93.Pme(b96);
		}

		internal static bool jMa()
		{
			return yMI == null;
		}

		internal static _003C_003Ec__DisplayClass6_0 LMX()
		{
			return yMI;
		}
	}

	private InputAdapter AMI;

	private il WMk;

	private FloatingWindowControl lMC;

	private Point LM1;

	internal static Qi jYp;

	public override Point Location
	{
		get
		{
			if (lMC == null)
			{
				return default(Point);
			}
			return new Point(lMC.Left, lMC.Top);
		}
		set
		{
			if (lMC != null)
			{
				lMC.Left = point.X;
				lMC.Top = point.Y;
			}
		}
	}

	[SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
	protected Qi(DockHost P_0)
	{
		IVH.CecNqz();
		base._002Ector(P_0);
		KMw(new FloatingWindowControl(this));
		int num = 0;
		if (1 == 0)
		{
			int num2;
			num = num2;
		}
		switch (num)
		{
		}
		lMC.Width = Math.Max(lMC.MinWidth, Math.Min(lMC.MaxWidth, P_0.Hen().Width));
		lMC.Height = Math.Max(lMC.MinHeight, Math.Min(lMC.MaxHeight, P_0.Hen().Height));
		Point? point = P_0.GeB();
		if (point.HasValue)
		{
			lMC.Left = point.Value.X;
			lMC.Top = point.Value.Y;
		}
		Fmr();
	}

	private void Glg(InputPointerEventArgs P_0)
	{
		QlX(_0020: false);
		DockHost dockHost = base.DockHost;
		DockSite dockSite = base.DockSite;
		if (dockHost != null && dockSite != null && lMC != null)
		{
			AMI = new InputAdapter(dockSite);
			AMI.PointerCaptureLost += Blo;
			AMI.PointerMoved += Yly;
			AMI.PointerReleased += Blo;
			AMI.AttachedEventKinds = InputAdapterEventKinds.PointerCaptureLost | InputAdapterEventKinds.PointerMoved | InputAdapterEventKinds.PointerReleased;
			Point position = P_0.GetPosition(dockSite);
			int num = 0;
			if (!lY4())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			LM1 = new Point(lMC.Left - position.X, lMC.Top - position.Y);
			AMI.CapturePointer(P_0);
			WMk = dockSite.Q1S(this);
			WMk.VRC(Wl5);
		}
	}

	private void QlX(bool P_0)
	{
		_003C_003Ec__DisplayClass6_0 CS_0024_003C_003E8__locals5 = new _003C_003Ec__DisplayClass6_0();
		CS_0024_003C_003E8__locals5.u93 = this;
		CS_0024_003C_003E8__locals5.b96 = P_0;
		if (AMI == null)
		{
			return;
		}
		if (WMk != null)
		{
			WMk.GR1(Wl5);
			WMk = null;
		}
		DockSite dockSite = base.DockSite;
		if (dockSite != null)
		{
			Action action = delegate
			{
				CS_0024_003C_003E8__locals5.u93.Pme(CS_0024_003C_003E8__locals5.b96);
			};
			int num = 0;
			if (JY2() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			dockSite.J1L(this, CS_0024_003C_003E8__locals5.b96, action);
		}
		AMI.AttachedEventKinds = InputAdapterEventKinds.None;
		AMI.ReleasePointerCaptures();
		AMI = null;
	}

	private void Wl5(object P_0, EventArgs P_1)
	{
		HmR();
	}

	private void Yly(object P_0, InputPointerEventArgs P_1)
	{
		DockSite dockSite = ((AMI != null) ? (AMI.TargetElement as DockSite) : null);
		if (dockSite != null && lMC != null)
		{
			Point position = P_1.GetPosition(dockSite);
			Rect bounds = lMC.DJT();
			bounds.X = position.X + LM1.X;
			bounds.Y = position.Y + LM1.Y;
			bounds = lMC.GetAdjustedBounds(bounds, ResizeOperation.None);
			lMC.Left = bounds.X;
			lMC.Top = bounds.Y;
			dockSite.Q1R(position);
		}
	}

	private void Blo(object P_0, InputPointerEventArgs P_1)
	{
		QlX(_0020: true);
	}

	private void Nlt(object P_0, RoutedEventArgs P_1)
	{
		if (lMC != null && lMC.WindowState == WindowState.Normal)
		{
			Al3();
		}
		iMi();
	}

	private void tlu(object P_0, RoutedEventArgs P_1)
	{
		DockHost dockHost = base.DockHost;
		if (dockHost != null && lMC != null && lMC.WindowState == WindowState.Normal)
		{
			dockHost.beO(new Size(lMC.ActualWidth, lMC.ActualHeight));
		}
	}

	private void ulz(object P_0, RoutedEventArgs P_1)
	{
		DockHost dockHost = base.DockHost;
		FloatingWindowControl floatingWindowControl = FMd();
		if (dockHost != null && floatingWindowControl != null)
		{
			dockHost.Qeb(floatingWindowControl.WindowState);
		}
	}

	private void iMi()
	{
		if (lMC != null)
		{
			Canvas.SetLeft(lMC, lMC.Left);
			Canvas.SetTop(lMC, lMC.Top);
		}
	}

	[SpecialName]
	internal FloatingWindowControl FMd()
	{
		return lMC;
	}

	[SpecialName]
	internal void KMw(FloatingWindowControl P_0)
	{
		if (lMC == P_0)
		{
			return;
		}
		if (lMC != null)
		{
			lMC.LocationChanged -= Nlt;
			lMC.SizeChanged -= tlu;
			lMC.StateChanged -= ulz;
			BindingOperations.ClearBinding(lMC, WindowControl.IconProperty);
			BindingOperations.ClearBinding(lMC, WindowControl.TitleProperty);
		}
		lMC = P_0;
		if (lMC != null)
		{
			lMC.LocationChanged += Nlt;
			lMC.SizeChanged += tlu;
			lMC.StateChanged += ulz;
			DockHost dockHost = base.DockHost;
			if (dockHost != null)
			{
				lMC.BindToProperty(WindowControl.IconProperty, dockHost, vVK.ssH(7326), BindingMode.OneWay);
				lMC.BindToProperty(WindowControl.TitleProperty, dockHost, vVK.ssH(7338), BindingMode.OneWay);
			}
		}
	}

	protected override void gmm()
	{
		DockHost dockHost = base.DockHost;
		DockSite dockSite = base.DockSite;
		if (lMC != null && lMC.WindowState == WindowState.Normal && dockHost != null && dockSite != null)
		{
			Size size = dockHost.Hen();
			FloatingWindowOpeningEventArgs e = new FloatingWindowOpeningEventArgs(dockHost)
			{
				Size = size
			};
			dockSite.f13(e);
			Size size2 = e.Size;
			if (size.Width != size2.Width)
			{
				lMC.Width = size2.Width;
			}
			if (size.Height != size2.Height)
			{
				lMC.Height = size2.Height;
			}
		}
	}

	public override void Kmi()
	{
		QlX(_0020: false);
	}

	[SpecialName]
	protected il vMe()
	{
		return WMk;
	}

	protected override void gmo()
	{
		if (lMC != null)
		{
			DockSite dockSite = base.DockSite;
			lMC.Content = null;
			base.DockHost = null;
			dockSite?.GCo(lMC);
			KMw(null);
		}
	}

	protected override void im1(X9 P_0)
	{
		if (lMC == null)
		{
			return;
		}
		if (P_0 != null)
		{
			if (P_0.VIW().X != 0.0)
			{
				lMC.Left += P_0.VIW().X;
			}
			if (P_0.VIW().Y != 0.0)
			{
				lMC.Top += P_0.VIW().Y;
			}
		}
		if (!lMC.IsActive)
		{
			Vmu(_0020: false, _0020: true, _0020: false);
			int num = 0;
			if (JY2() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
		DockSite dockSite = base.DockSite;
		if (P_0 != null && P_0.sIJ() != null && dockSite != null)
		{
			dockSite.MCg();
			Glg(P_0.sIJ());
		}
	}

	protected override void Xmv()
	{
		DockHost dockHost = base.DockHost;
		FloatingWindowControl floatingWindowControl = FMd();
		if (dockHost != null && floatingWindowControl != null && floatingWindowControl.WindowState != dockHost.zeZ())
		{
			floatingWindowControl.WindowState = dockHost.zeZ();
		}
	}

	protected override void rmT()
	{
		Fmr();
	}

	protected override void LmI()
	{
		DockHost dockHost = base.DockHost;
		FloatingWindowControl floatingWindowControl = FMd();
		if (dockHost != null && floatingWindowControl != null)
		{
			Thickness borderThickness = floatingWindowControl.BorderThickness;
			Size size = dockHost.OG1();
			floatingWindowControl.MinWidth = borderThickness.Left + size.Width + borderThickness.Right;
			floatingWindowControl.MinHeight = borderThickness.Top + size.Height + borderThickness.Bottom;
		}
	}

	protected virtual void HmR()
	{
	}

	protected virtual void Pme(bool P_0)
	{
	}

	public override void Vmu(bool P_0, bool P_1, bool P_2)
	{
		DockSite dockSite = base.DockSite;
		if (dockSite == null || lMC == null)
		{
			return;
		}
		if (!P_2)
		{
			gmm();
			if (P_0 && dockSite.IsFloatingWindowSnapToScreenEnabled)
			{
				int num = 0;
				if (!lY4())
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				dmw();
			}
		}
		dockSite.YCA(lMC);
		if (P_2)
		{
			lMC.UpdateLayout();
			lMC.Width = double.NaN;
			lMC.Height = double.NaN;
			lMC.Measure(new Size(double.PositiveInfinity, double.PositiveInfinity));
			lMC.Width = Math.Ceiling(lMC.DesiredSize.Width);
			lMC.Height = Math.Ceiling(lMC.DesiredSize.Height);
		}
	}

	protected override void dmw()
	{
		DockSite dockSite = base.DockSite;
		if (dockSite != null && lMC != null)
		{
			Rect rect = new Rect(default(Point), dockSite.RenderSize);
			Rect rect2 = xN.XlL(lMC.DJT(), rect, dockSite.FloatingWindowSnapToScreenThreshold);
			if (lMC.Left != rect2.Left)
			{
				lMC.Left = rect2.Left;
			}
			if (lMC.Top != rect2.Top)
			{
				lMC.Top = rect2.Top;
			}
		}
	}

	protected abstract void Fmr();

	[SpecialName]
	public override FloatingWindowControl Qmq()
	{
		return lMC;
	}

	internal static bool lY4()
	{
		return jYp == null;
	}

	internal static Qi JY2()
	{
		return jYp;
	}
}
