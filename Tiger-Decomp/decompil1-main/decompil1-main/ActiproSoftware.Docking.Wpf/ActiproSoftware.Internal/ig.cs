using System;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using ActiproSoftware.Windows.Controls;
using ActiproSoftware.Windows.Controls.Docking;
using ActiproSoftware.Windows.Controls.Docking.Automation.Peers;
using ActiproSoftware.Windows.Controls.Docking.Primitives;
using ActiproSoftware.Windows.Extensions;
using ActiproSoftware.Windows.Input;

namespace ActiproSoftware.Internal;

internal class ig : Panel, IOrientedElement
{
	private InputAdapter mTA;

	private Storyboard KTH;

	private bool oT0;

	private DockHost yTh;

	private AutoHideContainerSplitter MTg;

	internal static ig C86;

	private DockSite DockSite
	{
		get
		{
			if (yTh == null)
			{
				return null;
			}
			return yTh.DockSite;
		}
	}

	public Orientation Orientation
	{
		get
		{
			Side side = MTg.nTn();
			if (side == Side.Left || side == Side.Right)
			{
				return Orientation.Horizontal;
			}
			return Orientation.Vertical;
		}
	}

	public ig(DockHost P_0)
	{
		IVH.CecNqz();
		base._002Ector();
		int num = 0;
		if (false)
		{
			int num2;
			num = num2;
		}
		switch (num)
		{
		}
		if (P_0 == null)
		{
			throw new ArgumentNullException(vVK.ssH(9182));
		}
		yTh = P_0;
		MTg = new AutoHideContainerSplitter();
		Panel.SetZIndex(MTg, 1);
		base.Children.Add(MTg);
		base.RenderTransform = new TranslateTransform();
		iTM();
		base.AllowDrop = true;
	}

	private void pTl(bool P_0, double P_1, double P_2, double P_3, double P_4, double P_5)
	{
		if (KTH != null)
		{
			KTH.Completed -= qT3;
		}
		oT0 = P_0;
		int num = 1;
		if (T8I() != null)
		{
			goto IL_0005;
		}
		goto IL_0009;
		IL_0009:
		TimeSpan timeSpan = default(TimeSpan);
		DoubleAnimationUsingKeyFrames doubleAnimationUsingKeyFrames = default(DoubleAnimationUsingKeyFrames);
		do
		{
			switch (num)
			{
			case 1:
				P_1 = Math.Max(0.0, P_1);
				timeSpan = TimeSpan.FromMilliseconds(P_1);
				KTH = new Storyboard();
				Storyboard.SetTarget(KTH, this);
				KTH.Completed += qT3;
				doubleAnimationUsingKeyFrames = new DoubleAnimationUsingKeyFrames
				{
					KeyFrames = { (DoubleKeyFrame)new EasingDoubleKeyFrame
					{
						EasingFunction = new QuadraticEase(),
						KeyTime = timeSpan,
						Value = P_3
					} }
				};
				if (!(P_1 > 0.0))
				{
					break;
				}
				goto IL_014d;
			}
			string path = vVK.ssH(3302);
			Storyboard.SetTargetProperty(doubleAnimationUsingKeyFrames, new PropertyPath(path));
			KTH.Children.Add(doubleAnimationUsingKeyFrames);
			doubleAnimationUsingKeyFrames = new DoubleAnimationUsingKeyFrames
			{
				KeyFrames = { (DoubleKeyFrame)new EasingDoubleKeyFrame
				{
					EasingFunction = new QuadraticEase(),
					KeyTime = timeSpan,
					Value = P_5
				} }
			};
			if (P_1 > 0.0)
			{
				doubleAnimationUsingKeyFrames.KeyFrames.Add(new EasingDoubleKeyFrame
				{
					KeyTime = TimeSpan.FromSeconds(0.0),
					Value = P_4
				});
			}
			path = vVK.ssH(20248) + ((Orientation == Orientation.Horizontal) ? vVK.ssH(4072) : vVK.ssH(4064));
			Storyboard.SetTargetProperty(doubleAnimationUsingKeyFrames, new PropertyPath(path));
			KTH.Children.Add(doubleAnimationUsingKeyFrames);
			doubleAnimationUsingKeyFrames = new DoubleAnimationUsingKeyFrames
			{
				KeyFrames = { (DoubleKeyFrame)new EasingDoubleKeyFrame
				{
					KeyTime = TimeSpan.FromSeconds(0.0),
					Value = 0.0
				} }
			};
			path = vVK.ssH(20248) + ((Orientation == Orientation.Vertical) ? vVK.ssH(4072) : vVK.ssH(4064));
			Storyboard.SetTargetProperty(doubleAnimationUsingKeyFrames, new PropertyPath(path));
			KTH.Children.Add(doubleAnimationUsingKeyFrames);
			KTH.Begin(this, HandoffBehavior.SnapshotAndReplace);
			return;
			IL_014d:
			doubleAnimationUsingKeyFrames.KeyFrames.Add(new EasingDoubleKeyFrame
			{
				KeyTime = TimeSpan.FromSeconds(0.0),
				Value = P_2
			});
			num = 0;
		}
		while (z8W());
		goto IL_0005;
		IL_0005:
		int num2 = default(int);
		num = num2;
		goto IL_0009;
	}

	private void iTM()
	{
		mTA = new InputAdapter(this);
		mTA.PointerEntered += FT6;
		mTA.PointerExited += XT9;
		mTA.AttachedEventKinds = InputAdapterEventKinds.PointerEntered | InputAdapterEventKinds.PointerExited;
	}

	private double jTv()
	{
		return dTU() switch
		{
			Side.Left => 0.0 - base.Width, 
			Side.Top => 0.0 - base.Height, 
			Side.Right => base.Width, 
			_ => base.Height, 
		};
	}

	private Point aT7()
	{
		return PointFromScreen(hV.Sk());
	}

	private double iTR()
	{
		return Math.Round(Math.Max(1.0, DockSite?.SplitterSize ?? 5.0));
	}

	private void HTS()
	{
		STP()?.few().Yxu();
	}

	private void tTL()
	{
		STP()?.few().exz();
	}

	private void qT3(object P_0, object P_1)
	{
		if (oT0)
		{
			oT0 = false;
			if (yTh != null)
			{
				yTh.CloseAutoHidePopup(closeImmediately: true, blurFocus: false);
			}
		}
	}

	private void FT6(object P_0, InputPointerEventArgs P_1)
	{
		HTS();
	}

	private void XT9(object P_0, InputPointerEventArgs P_1)
	{
		Point position = P_1.GetPosition(this);
		if (!new Rect(default(Point), this.GetCurrentSize()).Contains(position))
		{
			tTL();
		}
	}

	internal void TTY()
	{
		DockSite dockSite = DockSite;
		if (dockSite != null && dockSite.IQR() && dockSite.AutoHidePopupCloseAnimationDuration > 0.0)
		{
			double num = jTv();
			pTl(_0020: false, 0.0, 0.0, 0.0, num, num);
		}
		else
		{
			pTl(_0020: false, 0.0, 1.0, 1.0, 0.0, 0.0);
		}
	}

	internal void lTp()
	{
		DockSite dockSite = DockSite;
		if (dockSite != null && dockSite.IQR())
		{
			double autoHidePopupCloseAnimationDuration = dockSite.AutoHidePopupCloseAnimationDuration;
			double num = jTv();
			pTl(_0020: true, autoHidePopupCloseAnimationDuration, 1.0, 0.0, 0.0, num);
		}
		else if (yTh != null)
		{
			yTh.CloseAutoHidePopup(closeImmediately: true, blurFocus: false);
		}
	}

	internal void nTs()
	{
		DockSite dockSite = DockSite;
		if (dockSite != null && dockSite.IQR())
		{
			double autoHidePopupOpenAnimationDuration = dockSite.AutoHidePopupOpenAnimationDuration;
			double num = jTv();
			pTl(_0020: false, autoHidePopupOpenAnimationDuration, 0.0, 1.0, num, 0.0);
		}
	}

	private void JTq()
	{
		DockSite dockSite = DockSite;
		ToolWindowContainer toolWindowContainer = MTg.JT8();
		if (dockSite == null || toolWindowContainer == null || toolWindowContainer.SelectedWindow == null || yTh == null || yTh.dem() == null)
		{
			return;
		}
		double num = iTR();
		double sizeExtent = this.GetSizeExtent(toolWindowContainer.SelectedWindow.ContainerMaxSizeResolved);
		double num2 = Math.Max(this.GetSizeExtent(toolWindowContainer.SelectedWindow.ContainerMinSizeResolved), Math.Min(sizeExtent, this.GetSizeExtent(toolWindowContainer.bKn())));
		if (Orientation != Orientation.Horizontal)
		{
			base.Width = double.NaN;
			base.Height = Math.Max(num, Math.Min(num2 + num, yTh.dem().ActualHeight - 15.0));
			goto IL_0268;
		}
		base.Width = Math.Max(num, Math.Min(num2 + num, yTh.dem().ActualWidth - 15.0));
		base.Height = double.NaN;
		int num3 = 1;
		if (!z8W())
		{
			goto IL_0005;
		}
		goto IL_0009;
		IL_0009:
		while (true)
		{
			switch (num3)
			{
			case 2:
				return;
			default:
				goto IL_023f;
			case 1:
				break;
			}
			break;
			IL_023f:
			base.VerticalAlignment = VerticalAlignment.Stretch;
			num3 = 2;
			if (T8I() == null)
			{
				continue;
			}
			goto IL_0005;
		}
		goto IL_0268;
		IL_0005:
		int num4 = default(int);
		num3 = num4;
		goto IL_0009;
		IL_0268:
		if (!dockSite.IQR())
		{
			base.HorizontalAlignment = HorizontalAlignment.Stretch;
			base.VerticalAlignment = VerticalAlignment.Stretch;
			return;
		}
		switch (MTg.nTn())
		{
		case Side.Left:
			base.HorizontalAlignment = HorizontalAlignment.Left;
			base.VerticalAlignment = VerticalAlignment.Stretch;
			return;
		case Side.Right:
			break;
		default:
			base.HorizontalAlignment = HorizontalAlignment.Stretch;
			base.VerticalAlignment = VerticalAlignment.Bottom;
			return;
		case Side.Top:
			base.HorizontalAlignment = HorizontalAlignment.Stretch;
			base.VerticalAlignment = VerticalAlignment.Top;
			return;
		}
		base.HorizontalAlignment = HorizontalAlignment.Right;
		num3 = 0;
		if (T8I() != null)
		{
			num3 = 0;
		}
		goto IL_0009;
	}

	protected override Size ArrangeOverride(Size P_0)
	{
		double num = iTR();
		ToolWindowContainer toolWindowContainer = MTg.JT8();
		int num2;
		int num3 = default(int);
		switch (MTg.nTn())
		{
		case Side.Right:
			MTg.Arrange(new Rect(0.0, 0.0, num, P_0.Height));
			MTg.CrD(Math.Max(0.0, ((yTh.dem() != null) ? yTh.dem().ActualWidth : 0.0) - P_0.Width));
			num2 = 1;
			if (T8I() != null)
			{
				goto IL_0005;
			}
			goto IL_0009;
		case Side.Top:
			toolWindowContainer?.Arrange(new Rect(0.0, 0.0, P_0.Width, Math.Max(0.0, P_0.Height - num)));
			MTg.Arrange(new Rect(0.0, P_0.Height - num, P_0.Width, num));
			num2 = 0;
			if (!z8W())
			{
				goto IL_0005;
			}
			goto IL_0009;
		case Side.Left:
			toolWindowContainer?.Arrange(new Rect(0.0, 0.0, Math.Max(0.0, P_0.Width - num), P_0.Height));
			MTg.Arrange(new Rect(P_0.Width - num, 0.0, num, P_0.Height));
			MTg.CrD(Math.Max(0.0, P_0.Width - num));
			break;
		default:
			{
				MTg.Arrange(new Rect(0.0, 0.0, P_0.Width, num));
				MTg.CrD(Math.Max(0.0, ((yTh.dem() != null) ? yTh.dem().ActualHeight : 0.0) - P_0.Height));
				toolWindowContainer?.Arrange(new Rect(0.0, num, P_0.Width, Math.Max(0.0, P_0.Height - num)));
				break;
			}
			IL_0005:
			num2 = num3;
			goto IL_0009;
			IL_0009:
			switch (num2)
			{
			case 1:
				toolWindowContainer?.Arrange(new Rect(num, 0.0, Math.Max(0.0, P_0.Width - num), P_0.Height));
				break;
			default:
				MTg.CrD(Math.Max(0.0, P_0.Height - num));
				break;
			}
			break;
		}
		return P_0;
	}

	[SpecialName]
	public DockHost STP()
	{
		return yTh;
	}

	protected override Size MeasureOverride(Size P_0)
	{
		double num = iTR();
		double num2 = Math.Floor(this.GetSizeExtent(P_0));
		double ascent = Math.Floor(this.GetSizeAscent(P_0));
		int num3 = 0;
		if (T8I() != null)
		{
			int num4 = default(int);
			num3 = num4;
		}
		switch (num3)
		{
		default:
		{
			double num5 = num;
			ToolWindowContainer toolWindowContainer = MTg.JT8();
			if (toolWindowContainer != null)
			{
				if (!double.IsPositiveInfinity(this.GetSizeExtent(P_0)))
				{
					toolWindowContainer.Measure(this.CreateSize(Math.Max(0.0, num2 - num), ascent));
				}
				else
				{
					toolWindowContainer.Measure(P_0);
				}
				num5 += this.GetSizeExtent(toolWindowContainer.DesiredSize);
			}
			MTg.Measure(this.CreateSize(num, ascent));
			return this.CreateSize(num5, ascent);
		}
		}
	}

	public void uTF()
	{
		JTq();
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		return new AutoHidePopupPanelAutomationPeer(this);
	}

	protected override void OnDragEnter(DragEventArgs P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(vVK.ssH(3942));
		}
		base.OnDragOver(P_0);
		HTS();
	}

	protected override void OnIsKeyboardFocusWithinChanged(DependencyPropertyChangedEventArgs P_0)
	{
		base.OnIsKeyboardFocusWithinChanged(P_0);
		if (!base.IsKeyboardFocusWithin)
		{
			DockSite dockSite = DockSite;
			Point point = ((dockSite != null && !dockSite.qQv() && base.IsVisible) ? aT7() : Mouse.GetPosition(this));
			if (!new Rect(default(Point), this.GetCurrentSize()).Contains(point))
			{
				tTL();
			}
		}
	}

	protected override void OnPreviewKeyDown(KeyEventArgs P_0)
	{
		if (P_0 != null)
		{
			DockSite dockSite = DockSite;
			DockHost dockHost = STP();
			if (dockSite != null && dockHost != null && !dockSite.IQR() && dockHost.R2g(P_0))
			{
				dockSite.ProcessDockHostKeyDown(dockHost, P_0);
			}
			base.OnPreviewKeyDown(P_0);
			int num = 0;
			if (!z8W())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			case 0:
				break;
			}
			return;
		}
		throw new ArgumentNullException(vVK.ssH(3942));
	}

	[SpecialName]
	public Side dTU()
	{
		return MTg.nTn();
	}

	[SpecialName]
	public void VTc(Side P_0)
	{
		if (MTg.nTn() != P_0)
		{
			MTg.iTO(P_0);
			MTg.Orientation = Orientation;
			JTq();
			InvalidateArrange();
		}
	}

	[SpecialName]
	public ToolWindowContainer DTj()
	{
		return MTg.JT8();
	}

	[SpecialName]
	public void FTZ(ToolWindowContainer P_0)
	{
		int num = 1;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					if (MTg.JT8() == P_0)
					{
						num2 = 0;
						if (z8W())
						{
							break;
						}
						goto end_IL_0012;
					}
					if (MTg.JT8() != null && base.Children.Contains(MTg.JT8()))
					{
						base.Children.Remove(MTg.JT8());
					}
					MTg.vTD(P_0);
					if (MTg.JT8() != null)
					{
						base.Children.Insert(0, MTg.JT8());
						JTq();
					}
					return;
				case 0:
					return;
				}
				continue;
				end_IL_0012:
				break;
			}
		}
	}

	internal static bool z8W()
	{
		return C86 == null;
	}

	internal static ig T8I()
	{
		return C86;
	}
}
