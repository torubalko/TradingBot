using System;
using System.Windows.Controls;
using System.Windows.Media;
using ActiproSoftware.Windows.Controls.Grids;

namespace ActiproSoftware.Internal;

internal class km : Grid
{
	private static km WsL;

	public km(TreeListViewColumnHeader P_0)
	{
		fc.taYSkz();
		base._002Ector();
		if (P_0 == null)
		{
			throw new ArgumentNullException(xv.hTz(9940));
		}
		Panel.SetZIndex(this, 10000);
		base.IsHitTestVisible = false;
		base.Width = P_0.RenderSize.Width;
		base.Height = P_0.RenderSize.Height;
		base.Background = new VisualBrush
		{
			Stretch = Stretch.None,
			TileMode = TileMode.None,
			AlignmentX = AlignmentX.Left,
			AlignmentY = AlignmentY.Top,
			Opacity = 0.4,
			Visual = P_0.gqZ()
		};
	}

	internal static bool JsB()
	{
		return WsL == null;
	}

	internal static km ust()
	{
		return WsL;
	}
}
