using System;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using ActiproSoftware.Windows.Controls;
using ActiproSoftware.Windows.Controls.Docking;
using ActiproSoftware.Windows.Extensions;
using ActiproSoftware.Windows.Media;

namespace ActiproSoftware.Internal;

internal class Tw : he
{
	private double? pxZ;

	private ToolWindowContainer dxb;

	private double? OxA;

	private DockHost TxH;

	private double? Ox0;

	private Side Nxh;

	private static Tw qYH;

	public Tw(DockHost P_0, Va P_1, Side P_2, bool P_3, bool P_4)
	{
		IVH.CecNqz();
		base._002Ector(P_1, P_3, P_4);
		if (P_0 == null)
		{
			throw new ArgumentNullException(vVK.ssH(9182));
		}
		TxH = P_0;
		Nxh = P_2;
		dxb = (ToolWindowContainer)(P_1.ElementBefore ?? P_1.ElementAfter);
	}

	[SpecialName]
	private double Mx4()
	{
		CxU();
		return OxA.Value;
	}

	private void CxU()
	{
		if (pxZ.HasValue)
		{
			return;
		}
		OxA = n7l().GetSizeExtent(dxb.RenderSize);
		int num = 0;
		if (!IYf())
		{
			goto IL_0005;
		}
		goto IL_0009;
		IL_0009:
		DockingWindow selectedWindow = default(DockingWindow);
		Size renderSize = default(Size);
		Rect bounds = default(Rect);
		do
		{
			switch (num)
			{
			case 1:
			{
				Size size = selectedWindow?.ContainerMinSizeResolved ?? dxb.bEN();
				Size size2 = selectedWindow?.ContainerMaxSizeResolved ?? dxb.aEC();
				double num2 = Math.Max(0.0, Math.Min(n7l().GetSizeExtent(renderSize) - 15.0 - n7l().GetSizeExtent(bounds), n7l().GetSizeExtent(size)));
				double num3 = Math.Max(0.0, Math.Min(n7l().GetSizeExtent(renderSize) - 15.0 - n7l().GetSizeExtent(bounds), n7l().GetSizeExtent(size2)));
				Side nxh = Nxh;
				if ((uint)nxh <= 1u)
				{
					pxZ = Math.Max(0.0, OxA.Value - num2);
					Ox0 = Math.Max(0.0, num3 - OxA.Value);
				}
				else
				{
					pxZ = Math.Max(0.0, num3 - OxA.Value);
					Ox0 = Math.Max(0.0, OxA.Value - num2);
				}
				return;
			}
			}
			renderSize = Jm0().RenderSize;
			bounds = n7l().GetBounds();
			selectedWindow = dxb.SelectedWindow;
			num = 1;
		}
		while (IYf());
		goto IL_0005;
		IL_0005:
		int num4 = default(int);
		num = num4;
		goto IL_0009;
	}

	private void Sxc()
	{
		if (dxb.Parent is FrameworkElement source)
		{
			VisualTreeHelperExtended.GetAncestor<bO>(source)?.tOx();
		}
	}

	protected override void rm4(double P_0)
	{
		Side nxh = Nxh;
		if ((uint)(nxh - 2) <= 1u)
		{
			P_0 *= -1.0;
		}
		double sizeExtent = n7l().GetSizeExtent(n7l().GetBounds());
		double num = Math.Max(0.0, Mx4() + P_0);
		dxb.hKO(n7l().CreateSize(num, n7l().GetSizeAscent(dxb.bKn())));
		if (dxb.Parent is FrameworkElement frameworkElement)
		{
			if (n7l().Orientation == Orientation.Horizontal)
			{
				frameworkElement.Width = sizeExtent + num;
			}
			else
			{
				frameworkElement.Height = sizeExtent + num;
			}
			if (!base.UseHostedPopups)
			{
				Sxc();
			}
		}
	}

	[SpecialName]
	protected override double mms()
	{
		CxU();
		return pxZ.Value;
	}

	[SpecialName]
	protected override double Jmk()
	{
		CxU();
		return Ox0.Value;
	}

	[SpecialName]
	public override FrameworkElement Jm0()
	{
		return (FrameworkElement)(((object)TxH.dem()) ?? ((object)TxH));
	}

	internal static bool IYf()
	{
		return qYH == null;
	}

	internal static Tw QY8()
	{
		return qYH;
	}
}
