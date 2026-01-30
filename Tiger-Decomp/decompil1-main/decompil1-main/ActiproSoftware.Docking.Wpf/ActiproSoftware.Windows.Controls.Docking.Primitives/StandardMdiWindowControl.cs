using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Threading;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Docking.Primitives;

[ToolboxItem(false)]
public class StandardMdiWindowControl : WindowControl, ac, G0
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass23_0
	{
		public StandardMdiHost L9Q;

		public DockingWindow p9m;

		private static _003C_003Ec__DisplayClass23_0 RMG;

		public _003C_003Ec__DisplayClass23_0()
		{
			IVH.CecNqz();
			base._002Ector();
		}

		internal void c9N()
		{
			L9Q.Va3(p9m);
		}

		internal static bool OMc()
		{
			return RMG == null;
		}

		internal static _003C_003Ec__DisplayClass23_0 YMM()
		{
			return RMG;
		}
	}

	[CompilerGenerated]
	private double Vrs;

	[CompilerGenerated]
	private StandardMdiHost Mrq;

	internal static StandardMdiWindowControl Jny;

	internal override bool AreWindowStateBoundsChangedWithExternalLogic => true;

	public DockHost DockHost => lr9()?.DockHost;

	public DockSite DockSite => DockingWindow?.DockSite;

	public DockingWindow DockingWindow => base.Content as DockingWindow;

	bool G0.IsActive
	{
		get
		{
			return base.IsActive;
		}
		set
		{
			base.IsActive = value;
		}
	}

	DockingWindow G0.SelectedWindow
	{
		get
		{
			StandardMdiHost standardMdiHost = lr9();
			if (standardMdiHost != null)
			{
				return standardMdiHost.PrimaryWindow;
			}
			return DockingWindow;
		}
		set
		{
			if (value != null)
			{
				StandardMdiHost standardMdiHost = lr9();
				if (standardMdiHost != null && standardMdiHost.PrimaryWindow != value && DockingWindow == value)
				{
					standardMdiHost.waD(value);
				}
			}
		}
	}

	IEnumerable<DockingWindow> G0.Windows => new DockingWindow[1] { DockingWindow };

	bool ac.IsWrapper => true;

	jJ ac.MdiHost => lr9();

	public StandardMdiWindowControl()
	{
		IVH.CecNqz();
		base._002Ector();
		base.DefaultStyleKey = typeof(StandardMdiWindowControl);
	}

	private Rect xrS(Rect P_0)
	{
		StandardMdiHost standardMdiHost = lr9();
		if (standardMdiHost != null)
		{
			Rect rect = new Rect(default(Point), standardMdiHost.Jal());
			if (rect.Width > 0.0 && rect.Height > 0.0)
			{
				P_0.X = Math.Max(rect.X - P_0.Width + 100.0, Math.Min(rect.X + rect.Width - 100.0, P_0.X));
				P_0.Y = Math.Max(rect.Y, Math.Min(rect.Y + rect.Height - 40.0, P_0.Y));
			}
		}
		return P_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal double CrL()
	{
		return Vrs;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void Dr3(double value)
	{
		Vrs = value;
	}

	[SpecialName]
	[CompilerGenerated]
	internal StandardMdiHost lr9()
	{
		return Mrq;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void SrY(StandardMdiHost value)
	{
		Mrq = value;
	}

	public override Rect GetAdjustedBounds(Rect bounds, ResizeOperation resizeOperation)
	{
		StandardMdiHost standardMdiHost = lr9();
		DockHost dockHost = DockHost;
		DockSite dockSite = DockSite;
		int num;
		if (standardMdiHost != null)
		{
			num = 0;
			if (!bnV())
			{
				goto IL_0005;
			}
			goto IL_0009;
		}
		goto IL_0029;
		IL_0029:
		return bounds;
		IL_0005:
		int num2 = default(int);
		num = num2;
		goto IL_0009;
		IL_0009:
		double num3 = default(double);
		IEnumerable<StandardMdiWindowControl> enumerable = default(IEnumerable<StandardMdiWindowControl>);
		double num4 = default(double);
		double num5 = default(double);
		double num6 = default(double);
		while (true)
		{
			switch (num)
			{
			case 2:
				break;
			case 1:
				goto IL_01c9;
			default:
				goto IL_022a;
			}
			if ((uint)(resizeOperation - 61446) > 2u)
			{
				num = 1;
				if (bnV())
				{
					continue;
				}
				goto IL_0005;
			}
			num3 = Math.Round(CG.Yvn(dockSite.MagnetismGapDistance, dockSite.MagnetismSnapDistance, enumerable, this, bounds, bounds.Bottom, Side.Bottom));
			goto IL_01c9;
			IL_022a:
			if (dockHost == null || dockSite == null || !(dockSite.MagnetismSnapDistance > 0.0))
			{
				break;
			}
			enumerable = standardMdiHost.Jav();
			if (resizeOperation != ResizeOperation.None)
			{
				num4 = bounds.Left;
				num5 = bounds.Right;
				num6 = bounds.Top;
				num3 = bounds.Bottom;
				switch (resizeOperation)
				{
				case ResizeOperation.West:
				case ResizeOperation.NorthWest:
				case ResizeOperation.SouthWest:
					num4 = Math.Round(CG.Yvn(dockSite.MagnetismGapDistance, dockSite.MagnetismSnapDistance, enumerable, this, bounds, bounds.Left, Side.Left));
					break;
				case ResizeOperation.East:
				case ResizeOperation.NorthEast:
				case ResizeOperation.SouthEast:
					num5 = Math.Round(CG.Yvn(dockSite.MagnetismGapDistance, dockSite.MagnetismSnapDistance, enumerable, this, bounds, bounds.Right, Side.Right));
					break;
				}
				if ((uint)(resizeOperation - 61443) > 2u)
				{
					num2 = 2;
					goto IL_0005;
				}
				num6 = Math.Round(CG.Yvn(dockSite.MagnetismGapDistance, dockSite.MagnetismSnapDistance, enumerable, this, bounds, bounds.Top, Side.Top));
				goto IL_01c9;
			}
			bounds = CG.XvJ(dockSite.MagnetismGapDistance, dockSite.MagnetismSnapDistance, enumerable, this, bounds);
			goto IL_0260;
			IL_0260:
			bounds = xrS(bounds);
			break;
			IL_01c9:
			bounds = new Rect(num4, num6, num5 - num4, num3 - num6);
			goto IL_0260;
		}
		goto IL_0029;
	}

	protected override void OnActivated(RoutedEventArgs e)
	{
		if (!base.IsActive)
		{
			return;
		}
		DockingWindow dockingWindow = DockingWindow;
		if (dockingWindow == null)
		{
			return;
		}
		DockHost dockHost = DockHost;
		DockSite dockSite = DockSite;
		if (dockSite != null && dockHost != null && !dockHost.Veu())
		{
			int num = 0;
			if (!bnV())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			dockSite.ActiveWindow = dockingWindow;
		}
	}

	protected override void OnClosed(RoutedEventArgs e)
	{
		DockingWindow?.Close();
	}

	protected override void OnContentChanged(object oldContent, object newContent)
	{
		base.OnContentChanged(oldContent, newContent);
		DockingWindow dockingWindow = oldContent as DockingWindow;
		DockingWindow dockingWindow2 = newContent as DockingWindow;
		dockingWindow?.qkb(null);
		dockingWindow2?.qkb(this);
	}

	protected override void OnLocationChanged(RoutedEventArgs e)
	{
		Canvas.SetLeft(this, base.Left);
		Canvas.SetTop(this, base.Top);
		if (VisualTreeHelper.GetParent(this) is Panel panel)
		{
			panel.InvalidateMeasure();
		}
		if (base.WindowState != WindowState.Minimized)
		{
			return;
		}
		int num = 0;
		if (Kn3() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		StandardMdiHost standardMdiHost = lr9();
		if (standardMdiHost != null)
		{
			Dr3(standardMdiHost.ActualHeight - base.Top);
		}
	}

	protected override void OnStateChanged(RoutedEventArgs e)
	{
		_003C_003Ec__DisplayClass23_0 CS_0024_003C_003E8__locals8 = new _003C_003Ec__DisplayClass23_0();
		CS_0024_003C_003E8__locals8.L9Q = lr9();
		CS_0024_003C_003E8__locals8.p9m = DockingWindow;
		if (CS_0024_003C_003E8__locals8.L9Q == null || CS_0024_003C_003E8__locals8.p9m == null)
		{
			return;
		}
		if (base.WindowState == WindowState.Maximized)
		{
			CS_0024_003C_003E8__locals8.L9Q.Va3(CS_0024_003C_003E8__locals8.p9m);
			return;
		}
		base.Dispatcher.BeginInvoke(DispatcherPriority.Loaded, (Action)delegate
		{
			CS_0024_003C_003E8__locals8.L9Q.Va3(CS_0024_003C_003E8__locals8.p9m);
		});
	}

	protected override void OnTitleBarMenuOpening(DockingMenuEventArgs e)
	{
		DockSite dockSite = DockSite;
		if (e != null && dockSite != null)
		{
			DockingWindow dockingWindow = DockingWindow;
			if (dockingWindow != null)
			{
				DockingMenuEventArgs e2 = new DockingMenuEventArgs(DockingMenuKind.StandardMdiWindowControlContextMenu)
				{
					Window = dockingWindow
				};
				e2.Menu = dockSite.iNM(dockingWindow);
				dockSite.C19(e2);
				e.Menu = e2.Menu;
			}
		}
	}

	bool G0.RemoveWindow(DockingWindow window)
	{
		if (window == null)
		{
			throw new ArgumentNullException(vVK.ssH(9098));
		}
		if (DockingWindow == window)
		{
			StandardMdiHost standardMdiHost = lr9();
			if (standardMdiHost != null && standardMdiHost.Windows.Contains(window))
			{
				standardMdiHost.Windows.Remove(window);
				return true;
			}
		}
		return false;
	}

	protected override void OnIsKeyboardFocusWithinChanged(DependencyPropertyChangedEventArgs e)
	{
		base.OnIsKeyboardFocusWithinChanged(e);
		if (base.IsKeyboardFocusWithin)
		{
			cP.IlA(this);
		}
	}

	internal static bool bnV()
	{
		return Jny == null;
	}

	internal static StandardMdiWindowControl Kn3()
	{
		return Jny;
	}
}
