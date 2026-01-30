using System;
using System.Windows;
using System.Windows.Controls.Primitives;

namespace ActiproSoftware.Internal;

internal class Dv
{
	private PlacementMode JFa;

	internal static Dv hLg;

	private Dv(PlacementMode P_0)
	{
		grA.DaB7cz();
		base._002Ector();
		JFa = P_0;
	}

	public CustomPopupPlacement[] KFE(Size P_0, Size P_1, Point P_2)
	{
		PlacementMode jFa = JFa;
		PlacementMode placementMode = jFa;
		CustomPopupPlacement[] result;
		if (placementMode != PlacementMode.Right)
		{
			if (placementMode != PlacementMode.Left)
			{
				if (placementMode != PlacementMode.Top)
				{
					result = new CustomPopupPlacement[4]
					{
						new CustomPopupPlacement(new Point(0.0 + P_2.X, P_1.Height + P_2.Y), PopupPrimaryAxis.Horizontal),
						new CustomPopupPlacement(new Point(0.0 + P_2.X, 0.0 - P_0.Height + P_2.Y), PopupPrimaryAxis.Horizontal),
						new CustomPopupPlacement(new Point(P_1.Width + P_2.X, 0.0 + P_2.Y), PopupPrimaryAxis.Vertical),
						new CustomPopupPlacement(new Point(0.0 - P_0.Width + P_2.X, 0.0 + P_2.Y), PopupPrimaryAxis.Vertical)
					};
					int num = 0;
					if (!YLA())
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
					result = new CustomPopupPlacement[4]
					{
						new CustomPopupPlacement(new Point(0.0 + P_2.X, 0.0 - P_0.Height + P_2.Y), PopupPrimaryAxis.Horizontal),
						new CustomPopupPlacement(new Point(0.0 + P_2.X, P_1.Height + P_2.Y), PopupPrimaryAxis.Horizontal),
						new CustomPopupPlacement(new Point(P_1.Width + P_2.X, 0.0 + P_2.Y), PopupPrimaryAxis.Vertical),
						new CustomPopupPlacement(new Point(0.0 - P_0.Width + P_2.X, 0.0 + P_2.Y), PopupPrimaryAxis.Vertical)
					};
				}
			}
			else
			{
				result = new CustomPopupPlacement[2]
				{
					new CustomPopupPlacement(new Point(0.0 - P_0.Width + P_2.X, 0.0 + P_2.Y), PopupPrimaryAxis.Vertical),
					new CustomPopupPlacement(new Point(P_1.Width + P_2.X, 0.0 + P_2.Y), PopupPrimaryAxis.Vertical)
				};
			}
		}
		else
		{
			result = new CustomPopupPlacement[2]
			{
				new CustomPopupPlacement(new Point(P_1.Width + P_2.X, 0.0 + P_2.Y), PopupPrimaryAxis.Vertical),
				new CustomPopupPlacement(new Point(0.0 - P_0.Width + P_2.X, 0.0 + P_2.Y), PopupPrimaryAxis.Vertical)
			};
		}
		return result;
	}

	public static void EFc(Popup P_0, PlacementMode P_1)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(191652));
		}
		if (P_1 == PlacementMode.Bottom || P_1 == PlacementMode.Right || (uint)(P_1 - 9) <= 1u)
		{
			P_0.Placement = PlacementMode.Custom;
			P_0.CustomPopupPlacementCallback = new Dv(P_1).KFE;
		}
		else
		{
			P_0.Placement = P_1;
		}
	}

	internal static bool YLA()
	{
		return hLg == null;
	}

	internal static Dv PLl()
	{
		return hLg;
	}
}
