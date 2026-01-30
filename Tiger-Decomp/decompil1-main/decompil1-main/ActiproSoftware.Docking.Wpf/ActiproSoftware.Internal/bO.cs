using System;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;
using ActiproSoftware.Windows.Controls;
using ActiproSoftware.Windows.Extensions;
using ActiproSoftware.Windows.Themes;

namespace ActiproSoftware.Internal;

internal class bO : Window
{
	private Side? EO6;

	private bool tO9;

	private AdornerDecorator nOY;

	private FrameworkElement EOp;

	[CompilerGenerated]
	private Thickness HOs;

	internal static bO m8m;

	public bO(FrameworkElement P_0, FrameworkElement P_1, bool P_2, bool P_3, bool P_4, bool P_5, bool P_6)
	{
		IVH.CecNqz();
		base._002Ector();
		if (P_0 == null)
		{
			throw new ArgumentNullException(vVK.ssH(19944));
		}
		if (P_1 == null)
		{
			throw new ArgumentNullException(vVK.ssH(19974));
		}
		EOp = P_0;
		tO9 = P_3;
		Window window = Yp.iRU(P_0);
		if (!P_6 && window != null)
		{
			P_6 |= window.Topmost;
		}
		base.WindowStyle = WindowStyle.None;
		base.AllowsTransparency = P_4;
		base.Background = null;
		base.IsHitTestVisible = P_3;
		base.Topmost = P_6;
		base.MinWidth = 0.0;
		base.MinHeight = 0.0;
		base.ResizeMode = ResizeMode.NoResize;
		base.ShowActivated = false;
		base.ShowInTaskbar = false;
		base.Focusable = false;
		if (P_2)
		{
			base.FlowDirection = FlowDirection.RightToLeft;
		}
		SetResourceReference(Control.FontFamilyProperty, SystemFonts.MessageFontFamilyKey);
		SetResourceReference(Control.FontSizeProperty, AssetResourceKeys.DefaultFontSizeDoubleKey);
		if (P_5)
		{
			if (window != null)
			{
				base.Owner = window;
				if (P_3)
				{
					window.LocationChanged += mOE;
					window.SizeChanged += gOr;
				}
			}
		}
		else
		{
			base.Loaded += pOD;
		}
		base.Content = (nOY = new AdornerDecorator());
		YO7(P_1);
	}

	private static Rect EOT(UIElement P_0, Rect P_1)
	{
		Point point = (SO8(P_0) ? P_1.TopRight : P_1.Location);
		point = P_0.PointToScreen(point);
		return new Rect(point, P_1.Size);
	}

	[SpecialName]
	private FrameworkElement XOv()
	{
		return nOY.Child as FrameworkElement;
	}

	[SpecialName]
	private void YO7(FrameworkElement P_0)
	{
		nOY.Child = P_0;
	}

	internal static bool SO8(UIElement P_0)
	{
		if (P_0 is FrameworkElement frameworkElement)
		{
			return frameworkElement.FlowDirection == FlowDirection.RightToLeft;
		}
		return false;
	}

	private void pOD(object P_0, RoutedEventArgs P_1)
	{
		if (base.IsVisible)
		{
			tOx();
		}
	}

	private void mOE(object P_0, EventArgs P_1)
	{
		tOx();
	}

	private void gOr(object P_0, SizeChangedEventArgs P_1)
	{
		tOx();
	}

	[SpecialName]
	[CompilerGenerated]
	public Thickness HOS()
	{
		return HOs;
	}

	[SpecialName]
	[CompilerGenerated]
	public void VOL(Thickness P_0)
	{
		HOs = P_0;
	}

	protected override void OnClosed(EventArgs P_0)
	{
		base.OnClosed(P_0);
		Window owner = base.Owner;
		if (owner != null)
		{
			if (tO9)
			{
				owner.LocationChanged -= mOE;
				owner.SizeChanged -= gOr;
			}
			base.Owner = null;
		}
		YO7(null);
	}

	public void tOx()
	{
		if (EOp == null)
		{
			return;
		}
		FrameworkElement frameworkElement = XOv();
		double num = frameworkElement?.Width ?? 0.0;
		double num2 = frameworkElement?.Height ?? 0.0;
		Rect rect = EO6 switch
		{
			Side.Left => new Rect(0.0, 0.0, num, EOp.ActualHeight), 
			Side.Top => new Rect(0.0, 0.0, EOp.ActualWidth, num2), 
			Side.Right => new Rect(EOp.ActualWidth - num, 0.0, num, EOp.ActualHeight), 
			Side.Bottom => new Rect(0.0, EOp.ActualHeight - num2, EOp.ActualWidth, num2), 
			_ => new Rect(0.0 - HOS().Left, 0.0 - HOS().Top, EOp.ActualWidth + HOS().Left + HOS().Right, EOp.ActualHeight + HOS().Top + HOS().Bottom), 
		};
		rect = EOT(EOp, rect);
		Size left = new Size(1.0, 1.0);
		Window window = Yp.iRU(EOp, _0020: true);
		if (window != null)
		{
			left = EOp.TransformToAncestor(window).TransformBounds(new Rect(0.0, 0.0, 1.0, 1.0)).Size;
		}
		window = window ?? this;
		Point point = hV.mC(window);
		if (EO6.HasValue && window != this)
		{
			Point point2 = (base.IsVisible ? hV.mC(this) : hV.s1(rect));
			if (point != point2)
			{
				point = point2;
				left = new Size(left.Width / point.X, left.Height / point.Y);
			}
		}
		if (left.IsEffectivelyEqual(new Size(1.0, 1.0)))
		{
			nOY.LayoutTransform = null;
		}
		else
		{
			rect.Width *= left.Width;
			rect.Height *= left.Height;
			nOY.LayoutTransform = new ScaleTransform(left.Width, left.Height);
		}
		base.Left = rect.X * ((point.X > 0.0) ? (1.0 / point.X) : 1.0);
		base.Top = rect.Y * ((point.Y > 0.0) ? (1.0 / point.Y) : 1.0);
		base.Width = rect.Width;
		base.Height = rect.Height;
	}

	public void KOl(Side P_0)
	{
		EO6 = P_0;
		tOx();
		Show();
	}

	public void MOM()
	{
		EO6 = null;
		tOx();
		Show();
	}

	internal static bool x8o()
	{
		return m8m == null;
	}

	internal static bO E8B()
	{
		return m8m;
	}
}
