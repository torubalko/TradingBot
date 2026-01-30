using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using ActiproSoftware.Windows.Controls.Docking;
using ActiproSoftware.Windows.Media;

namespace ActiproSoftware.Internal;

internal class vE : il
{
	private Dictionary<DockHost, Window> I7G;

	private bO q7I;

	private Window T7k;

	private hV.V2 S7C;

	internal static vE xYk;

	public vE(DockSite P_0, gh P_1)
	{
		IVH.CecNqz();
		base._002Ector(P_0, P_1);
		T7k = P_1?.NmX();
	}

	[SpecialName]
	private Dictionary<DockHost, Window> X72()
	{
		if (I7G == null)
		{
			I7G = new Dictionary<DockHost, Window>();
			DockHost dockHost = l70();
			DockSite dockSite = base.DockSite;
			if (dockSite != null)
			{
				foreach (DockHost item in dockSite.OQF())
				{
					if (item != null && item != dockHost && item.IsVisible)
					{
						Window window = Yp.iRU(item);
						if (window != T7k || window == null)
						{
							I7G[item] = window;
						}
					}
				}
			}
		}
		return I7G;
	}

	private void Uvt()
	{
		if (S7C == null)
		{
			S7C = new hV.V2(svz, s7i, Key.LeftCtrl, Key.RightCtrl, Key.Escape, Key.LeftShift, Key.RightShift);
			S7C.qRA();
		}
	}

	private static bool Pvu(DockHost P_0, Point P_1)
	{
		if (P_0 != null && P_0.IsVisible)
		{
			Rect rect = new Rect(0.0, 0.0, P_0.ActualWidth, P_0.ActualHeight);
			Point point = P_0.PointFromScreen(P_1);
			if (rect.Contains(point))
			{
				return true;
			}
		}
		return false;
	}

	private void svz(Key P_0)
	{
		switch (P_0)
		{
		case Key.LeftCtrl:
		case Key.RightCtrl:
			k7X(_0020: true);
			J7U();
			break;
		case Key.LeftShift:
		case Key.RightShift:
			K7o(_0020: true);
			break;
		case Key.Escape:
			q7p(null);
			break;
		}
	}

	private void s7i(Key P_0)
	{
		switch (P_0)
		{
		case Key.LeftCtrl:
		case Key.RightCtrl:
			k7X(_0020: false);
			J7U();
			break;
		case Key.LeftShift:
		case Key.RightShift:
			K7o(_0020: false);
			break;
		}
	}

	private void u7d()
	{
		if (S7C != null)
		{
			S7C.RRH();
			S7C = null;
		}
	}

	protected override void LmC()
	{
		if (q7I != null)
		{
			try
			{
				q7I.Close();
			}
			catch (InvalidOperationException)
			{
			}
			q7I = null;
		}
		base.LmC();
	}

	protected override Point Wmj(UIElement P_0, Point P_1)
	{
		return P_0?.PointFromScreen(P_1) ?? P_1;
	}

	protected override Point dmD(DockSite P_0, Point P_1)
	{
		return P_1;
	}

	protected override void RmY(QK P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(vVK.ssH(23294));
		}
		DockHost dockHost = KRi();
		q7I = new bO(dockHost, P_0, bO.SO8(dockHost), _0020: true, _0020: true, _0020: false, _0020: true);
		DockSite dockSite = base.DockSite;
		if (dockSite != null)
		{
			dockSite.InitializeDockingAdornmentWindow(q7I);
			int num = 0;
			if (!xYq())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
		P_0.Margin = new Thickness((!hV.TW()) ? 100 : 0);
		q7I.VOL(P_0.Margin);
		q7I.MOM();
	}

	protected override DockHost kmt(Point P_0)
	{
		List<Tuple<Rect, DockHost>> list = null;
		Window window = hV.NQ(X72().Values.Distinct(), P_0);
		if (window != null)
		{
			foreach (KeyValuePair<DockHost, Window> item3 in X72())
			{
				if (item3.Value != window)
				{
					continue;
				}
				DockHost key = item3.Key;
				if (Pvu(key, P_0))
				{
					if (list == null)
					{
						list = new List<Tuple<Rect, DockHost>>();
					}
					Rect item = new Rect(0.0, 0.0, key.ActualWidth, key.ActualHeight);
					list.Add(Tuple.Create(item, key));
				}
			}
		}
		else
		{
			DockSite dockSite = base.DockSite;
			if (dockSite != null)
			{
				DockHost primaryDockHost = dockSite.PrimaryDockHost;
				if (primaryDockHost != null && X72().TryGetValue(primaryDockHost, out var value) && value == null && Pvu(primaryDockHost, P_0))
				{
					if (list == null)
					{
						list = new List<Tuple<Rect, DockHost>>();
					}
					Rect item2 = new Rect(0.0, 0.0, primaryDockHost.ActualWidth, primaryDockHost.ActualHeight);
					list.Add(Tuple.Create(item2, primaryDockHost));
				}
			}
		}
		if (list != null)
		{
			if (list.Count == 1)
			{
				return list[0].Item2;
			}
			list.Sort((Tuple<Rect, DockHost> tuple, Tuple<Rect, DockHost> y) => (!tuple.Item1.Contains(y.Item1)) ? 1 : (-1));
			int num = list.FindLastIndex((Tuple<Rect, DockHost> tuple) => tuple.Item2.DockSite == base.DockSite);
			if (num == -1)
			{
				int num2 = 0;
				for (DockHost ancestor = VisualTreeHelperExtended.GetAncestor<DockHost>(base.DockSite); ancestor != null; ancestor = VisualTreeHelperExtended.GetAncestor<DockHost>(ancestor))
				{
					if (X72().ContainsKey(ancestor))
					{
						num2++;
					}
				}
				num = Math.Min(list.Count - 1, num2);
			}
			if (num != -1)
			{
				if (m7y())
				{
					if (num == list.Count - 1)
					{
						return list[Math.Max(0, num - 1)].Item2;
					}
					return list[Math.Min(list.Count - 1, num + 1)].Item2;
				}
				return list[num].Item2;
			}
			return list[Math.Max(0, list.Count - ((!m7y()) ? 1 : 2))].Item2;
		}
		return null;
	}

	protected override void Pmn()
	{
		Uvt();
	}

	protected override void xm8()
	{
		u7d();
	}

	protected override void Om7()
	{
		if (!h7u())
		{
			DockHost dockHost = KRi();
			if (dockHost != null && T7k != null && X72().TryGetValue(dockHost, out var value) && value != null && value != T7k)
			{
				hV.sB(value, T7k);
			}
		}
	}

	[CompilerGenerated]
	private bool z7w(Tuple<Rect, DockHost> P_0)
	{
		return P_0.Item2.DockSite == base.DockSite;
	}

	internal static bool xYq()
	{
		return xYk == null;
	}

	internal static vE EYw()
	{
		return xYk;
	}
}
