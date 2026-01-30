using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Media.Animation;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Input;

namespace ActiproSoftware.Windows.Controls.Docking.Primitives;

[ToolboxItem(false)]
public class FloatingWindowControl : WindowControl
{
	private InputAdapter YES;

	private Storyboard MEL;

	private gh WE3;

	private bool FE6;

	private bool SE9;

	internal static FloatingWindowControl Xnj;

	public DockSite DockSite => WE3.DockHost?.DockSite;

	internal FloatingWindowControl(gh floatingWindow)
	{
		IVH.CecNqz();
		base._002Ector();
		if (floatingWindow == null)
		{
			throw new ArgumentNullException(vVK.ssH(21324));
		}
		WE3 = floatingWindow;
		base.DefaultStyleKey = typeof(FloatingWindowControl);
		IED();
	}

	private void IED()
	{
		YES = new InputAdapter(this);
		YES.PointerEntered += kEl;
		YES.PointerExited += wEM;
		YES.AttachedEventKinds = InputAdapterEventKinds.PointerEntered | InputAdapterEventKinds.PointerExited;
	}

	private static Storyboard wEE(double P_0, double P_1, double P_2)
	{
		Storyboard storyboard = new Storyboard();
		DoubleAnimation doubleAnimation = new DoubleAnimation
		{
			To = Math.Max(0.0, Math.Min(1.0, P_2)),
			Duration = new Duration(TimeSpan.FromMilliseconds(P_1)),
			BeginTime = TimeSpan.FromMilliseconds(P_0)
		};
		Storyboard.SetTargetProperty(doubleAnimation, new PropertyPath(UIElement.OpacityProperty));
		storyboard.Children.Add(doubleAnimation);
		return storyboard;
	}

	private void SEr()
	{
		if (MEL != null)
		{
			if (MEL.GetCurrentState(this) != ClockState.Stopped)
			{
				MEL.Stop(this);
			}
			MEL = null;
		}
	}

	private Rect VEx(Rect P_0)
	{
		DockSite dockSite = DockSite;
		if (dockSite != null)
		{
			Rect rect = dockSite.FQT();
			if (rect.Width > 0.0 && rect.Height > 0.0)
			{
				P_0.X = Math.Max(rect.X - P_0.Width + 100.0, Math.Min(rect.X + rect.Width - 100.0, P_0.X));
				P_0.Y = Math.Max(rect.Y, Math.Min(rect.Y + rect.Height - 40.0, P_0.Y));
			}
		}
		return P_0;
	}

	private void kEl(object P_0, InputPointerEventArgs P_1)
	{
		SE9 = true;
		hER();
	}

	private void wEM(object P_0, InputPointerEventArgs P_1)
	{
		SE9 = false;
		if (!base.IsActive && base.Visibility == Visibility.Visible && base.Opacity > 0.0)
		{
			NE7();
		}
	}

	internal void eEv()
	{
		hER();
		if (!base.IsActive && !SE9 && base.Visibility == Visibility.Visible && base.Opacity > 0.0)
		{
			NE7();
		}
	}

	internal override bool ShouldDragMoveWithExternalLogic(InputPointerEventArgs e)
	{
		if (e != null)
		{
			DockHost dockHost = WE3.DockHost;
			if (dockHost != null)
			{
				dockHost.P2s(default(Point), e);
				return true;
			}
		}
		return false;
	}

	private void NE7()
	{
		SEr();
		DockSite dockSite = DockSite;
		if (dockSite != null && dockSite.IsInactiveFloatingWindowFadeEnabled && !(dockSite.InactiveFloatingWindowFadeOpacity >= 1.0) && !(dockSite.InactiveFloatingWindowFadeDelay < 0.0) && !(dockSite.InactiveFloatingWindowFadeDuration < 0.0))
		{
			MEL = wEE(dockSite.InactiveFloatingWindowFadeDelay, dockSite.InactiveFloatingWindowFadeDuration, dockSite.InactiveFloatingWindowFadeOpacity);
			Storyboard.SetTarget(MEL, this);
			MEL.Begin(this, isControllable: true);
			int num = 0;
			if (!dnt())
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

	private void hER()
	{
		SEr();
	}

	public override bool Activate()
	{
		DockSite?.cC0(this);
		return base.Activate();
	}

	public override Rect GetAdjustedBounds(Rect bounds, ResizeOperation resizeOperation)
	{
		int num = 2;
		DockSite dockSite = default(DockSite);
		while (true)
		{
			int num2 = num;
			do
			{
				IL_0012:
				switch (num2)
				{
				default:
				{
					IEnumerable<FloatingWindowControl> enumerable = dockSite.SCh();
					if (resizeOperation == ResizeOperation.None)
					{
						bounds = CG.XvJ(dockSite.MagnetismGapDistance, dockSite.MagnetismSnapDistance, enumerable, this, bounds);
					}
					else
					{
						double num3 = bounds.Left;
						double num4 = bounds.Right;
						double num5 = bounds.Top;
						double num6 = bounds.Bottom;
						switch (resizeOperation)
						{
						case ResizeOperation.West:
						case ResizeOperation.NorthWest:
						case ResizeOperation.SouthWest:
							num3 = Math.Round(CG.Yvn(dockSite.MagnetismGapDistance, dockSite.MagnetismSnapDistance, enumerable, this, bounds, bounds.Left, Side.Left));
							break;
						case ResizeOperation.East:
						case ResizeOperation.NorthEast:
						case ResizeOperation.SouthEast:
							num4 = Math.Round(CG.Yvn(dockSite.MagnetismGapDistance, dockSite.MagnetismSnapDistance, enumerable, this, bounds, bounds.Right, Side.Right));
							break;
						}
						if ((uint)(resizeOperation - 61443) > 2u)
						{
							if ((uint)(resizeOperation - 61446) <= 2u)
							{
								num6 = Math.Round(CG.Yvn(dockSite.MagnetismGapDistance, dockSite.MagnetismSnapDistance, enumerable, this, bounds, bounds.Bottom, Side.Bottom));
							}
						}
						else
						{
							num5 = Math.Round(CG.Yvn(dockSite.MagnetismGapDistance, dockSite.MagnetismSnapDistance, enumerable, this, bounds, bounds.Top, Side.Top));
						}
						bounds = new Rect(num3, num5, num4 - num3, num6 - num5);
					}
					bounds = VEx(bounds);
					goto IL_0120;
				}
				case 1:
					if (dockSite != null && dockSite.MagnetismSnapDistance > 0.0)
					{
						goto IL_0076;
					}
					goto IL_0120;
				case 2:
					{
						dockSite = DockSite;
						num2 = 1;
						if (Enp() != null)
						{
							num2 = 1;
						}
						break;
					}
					IL_0120:
					return bounds;
				}
				goto IL_0012;
				IL_0076:
				num2 = 0;
			}
			while (Enp() == null);
		}
	}

	protected override void OnActivated(RoutedEventArgs e)
	{
		base.OnActivated(e);
		hER();
	}

	protected override void OnClosing(CancelRoutedEventArgs e)
	{
		base.OnClosing(e);
		if (FE6 || e == null || e.Cancel || WE3 == null)
		{
			return;
		}
		DockHost dockHost = WE3.DockHost;
		if (dockHost == null)
		{
			return;
		}
		int num = 0;
		if (Enp() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (dockHost.CanClose)
		{
			try
			{
				FE6 = true;
				e.Cancel = !dockHost.Close(forceDestroy: false);
				return;
			}
			finally
			{
				FE6 = false;
			}
		}
		e.Cancel = true;
	}

	protected override void OnDeactivated(RoutedEventArgs e)
	{
		base.OnDeactivated(e);
		if (!SE9 && base.Visibility == Visibility.Visible && base.Opacity > 0.0)
		{
			NE7();
		}
	}

	internal static bool dnt()
	{
		return Xnj == null;
	}

	internal static FloatingWindowControl Enp()
	{
		return Xnj;
	}
}
