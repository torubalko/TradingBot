using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using ActiproSoftware.Windows.Controls.Docking;
using ActiproSoftware.Windows.Controls.Docking.Primitives;
using ActiproSoftware.Windows.Media;

namespace ActiproSoftware.Internal;

internal class NI : il
{
	private Dictionary<DockHost, Tuple<DockSite, FloatingWindowControl>> GMJ;

	private DockSite DMn;

	private FloatingWindowControl eMO;

	private Point fMT;

	private static NI rYa;

	public NI(DockSite P_0, gh P_1)
	{
		IVH.CecNqz();
		base._002Ector(P_0, P_1);
		if (P_0 == null)
		{
			throw new ArgumentNullException(vVK.ssH(10308));
		}
		eMO = P_1?.Qmq();
		if (eMO != null)
		{
			fMT = new Point(eMO.Left, eMO.Top);
			P_0.cC0(eMO);
		}
	}

	[SpecialName]
	private Dictionary<DockHost, Tuple<DockSite, FloatingWindowControl>> NMB()
	{
		if (GMJ == null)
		{
			GMJ = new Dictionary<DockHost, Tuple<DockSite, FloatingWindowControl>>();
			DockHost dockHost = l70();
			DockSite dockSite = base.DockSite;
			if (dockSite != null)
			{
				foreach (DockHost item in dockSite.OQF())
				{
					if (item == null || item == dockHost)
					{
						continue;
					}
					DockSite dockSite2 = item.DockSite;
					if (dockSite2 == null)
					{
						continue;
					}
					if (dockSite2.PrimaryDockHost == item)
					{
						GMJ[item] = Tuple.Create<DockSite, FloatingWindowControl>(dockSite2, null);
						continue;
					}
					FloatingWindowControl ancestor = VisualTreeHelperExtended.GetAncestor<FloatingWindowControl>(item);
					if (ancestor != null && dockSite2.rCX(ancestor))
					{
						GMJ[item] = Tuple.Create(dockSite2, ancestor);
					}
				}
			}
		}
		return GMJ;
	}

	private void pMN()
	{
		DockHost dockHost = l70();
		if (dockHost == null)
		{
			return;
		}
		int num = 0;
		if (cYs() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (dockHost.aG2())
		{
			DockSite dockSite = base.DockSite;
			if (dockSite != null)
			{
				dockSite.KeyDown += yMQ;
				dockSite.KeyUp += iMm;
			}
		}
		else
		{
			dockHost.KeyDown += yMQ;
			dockHost.KeyUp += iMm;
		}
	}

	private void yMQ(object P_0, KeyEventArgs P_1)
	{
		if (P_1 != null)
		{
			switch (P_1.Key)
			{
			case Key.LeftCtrl:
			case Key.RightCtrl:
				P_1.Handled = true;
				k7X(_0020: true);
				J7U();
				break;
			case Key.Escape:
				P_1.Handled = true;
				q7p(fMT);
				break;
			case Key.LeftShift:
			case Key.RightShift:
				P_1.Handled = true;
				K7o(_0020: true);
				break;
			}
		}
	}

	private void iMm(object P_0, KeyEventArgs P_1)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (P_1 == null)
				{
					return;
				}
				num2 = 0;
				if (GYX())
				{
					num2 = 0;
				}
				continue;
			}
			switch (P_1.Key)
			{
			case Key.LeftCtrl:
			case Key.RightCtrl:
				P_1.Handled = true;
				k7X(_0020: false);
				J7U();
				break;
			case Key.LeftShift:
			case Key.RightShift:
				P_1.Handled = true;
				K7o(_0020: false);
				break;
			}
			return;
		}
	}

	private void JMa()
	{
		DockHost dockHost = l70();
		if (dockHost == null)
		{
			return;
		}
		if (dockHost.aG2())
		{
			DockSite dockSite = base.DockSite;
			if (dockSite != null)
			{
				int num = 0;
				if (cYs() != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				dockSite.KeyDown -= yMQ;
				dockSite.KeyUp -= iMm;
			}
		}
		else
		{
			dockHost.KeyDown -= yMQ;
			dockHost.KeyUp -= iMm;
		}
	}

	protected override void LmC()
	{
		if (DMn != null)
		{
			DMn.IQn(null);
			DMn = null;
		}
		base.LmC();
	}

	protected override Point Wmj(UIElement P_0, Point P_1)
	{
		if (DMn != null)
		{
			QK qK = DMn.dQJ();
			if (qK != null)
			{
				P_1 = DMn.TransformToVisual(qK).Transform(P_1);
			}
		}
		return P_1;
	}

	protected override Point dmD(DockSite P_0, Point P_1)
	{
		DockSite dockSite = base.DockSite;
		if (dockSite != null && P_0 != null && dockSite != P_0)
		{
			return dockSite.TransformToVisual(P_0).Transform(P_1);
		}
		return P_1;
	}

	protected override void RmY(QK P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(vVK.ssH(23294));
		}
		if (DMn != null)
		{
			DMn.IQn(null);
			DMn = null;
			int num = 0;
			if (cYs() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
		DockHost dockHost = KRi();
		if (dockHost != null)
		{
			DMn = dockHost.DockSite;
			if (DMn != null)
			{
				DMn.IQn(P_0);
			}
		}
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	protected override DockHost kmt(Point P_0)
	{
		List<Tuple<Rect, DockHost>> list = null;
		FloatingWindowControl floatingWindowControl = null;
		IEnumerable<Tuple<DockSite, FloatingWindowControl>> values = NMB().Values;
		if (values != null)
		{
			values = values.OrderByDescending(delegate(Tuple<DockSite, FloatingWindowControl> tuple)
			{
				if (tuple == null)
				{
					return 0;
				}
				return (tuple.Item2 != null) ? Panel.GetZIndex(tuple.Item2) : 0;
			});
			int num2 = default(int);
			foreach (Tuple<DockSite, FloatingWindowControl> item6 in values)
			{
				DockSite item = item6.Item1;
				if (item == null)
				{
					continue;
				}
				Point point = dmD(item, P_0);
				FloatingWindowControl item2 = item6.Item2;
				if (item2 == null)
				{
					Rect item3 = new Rect(0.0, 0.0, item.ActualWidth, item.ActualHeight);
					if (item3.Contains(point))
					{
						if (list == null)
						{
							list = new List<Tuple<Rect, DockHost>>();
						}
						list.Add(Tuple.Create(item3, item.PrimaryDockHost));
					}
					continue;
				}
				Rect rect = new Rect(0.0, 0.0, item2.ActualWidth, item2.ActualHeight);
				int num = 0;
				if (!GYX())
				{
					goto IL_02a8;
				}
				goto IL_02ac;
				IL_02a8:
				num = num2;
				goto IL_02ac;
				IL_02ac:
				while (true)
				{
					switch (num)
					{
					default:
						rect = item2.TransformToVisual(item).TransformBounds(rect);
						if (!rect.Contains(point))
						{
							break;
						}
						goto IL_0400;
					case 1:
						goto end_IL_02ac;
					}
					goto IL_03dc;
					IL_0400:
					floatingWindowControl = item2;
					num = 1;
					if (GYX())
					{
						continue;
					}
					goto IL_02a8;
					continue;
					end_IL_02ac:
					break;
				}
				break;
				IL_03dc:;
			}
		}
		if (floatingWindowControl != null)
		{
			int num4 = default(int);
			foreach (KeyValuePair<DockHost, Tuple<DockSite, FloatingWindowControl>> item7 in NMB())
			{
				DockSite item4 = item7.Value.Item1;
				FloatingWindowControl item5 = item7.Value.Item2;
				if (item4 == null)
				{
					continue;
				}
				int num3 = 0;
				if (!GYX())
				{
					num3 = num4;
				}
				switch (num3)
				{
				}
				if (item5 != floatingWindowControl)
				{
					continue;
				}
				Point point2 = dmD(item4, P_0);
				DockHost key = item7.Key;
				Rect rect2 = new Rect(0.0, 0.0, key.ActualWidth, key.ActualHeight);
				rect2 = key.TransformToVisual(item4).TransformBounds(rect2);
				if (rect2.Contains(point2))
				{
					if (list == null)
					{
						list = new List<Tuple<Rect, DockHost>>();
					}
					list.Add(Tuple.Create(rect2, key));
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
			int num5 = list.FindLastIndex((Tuple<Rect, DockHost> tuple) => tuple.Item2.DockSite == base.DockSite);
			if (num5 == -1)
			{
				int num6 = 0;
				DockHost ancestor = VisualTreeHelperExtended.GetAncestor<DockHost>(base.DockSite);
				int num8 = default(int);
				while (true)
				{
					int num7;
					if (ancestor != null)
					{
						if (!NMB().ContainsKey(ancestor))
						{
							goto IL_022d;
						}
						num7 = 0;
						if (!GYX())
						{
							num7 = num8;
						}
					}
					else
					{
						num5 = Math.Min(list.Count - 1, num6);
						num7 = 1;
						if (cYs() != null)
						{
							num7 = 0;
						}
					}
					switch (num7)
					{
					default:
						num6++;
						goto IL_022d;
					case 1:
						break;
					}
					break;
					IL_022d:
					ancestor = VisualTreeHelperExtended.GetAncestor<DockHost>(ancestor);
				}
			}
			if (num5 != -1)
			{
				if (m7y())
				{
					if (num5 == list.Count - 1)
					{
						return list[Math.Max(0, num5 - 1)].Item2;
					}
					return list[Math.Min(list.Count - 1, num5 + 1)].Item2;
				}
				return list[num5].Item2;
			}
			return list[Math.Max(0, list.Count - ((!m7y()) ? 1 : 2))].Item2;
		}
		return null;
	}

	protected override void Pmn()
	{
		pMN();
	}

	protected override void xm8()
	{
		JMa();
	}

	protected override void Om7()
	{
		DockHost dockHost = KRi();
		if (dockHost == null || eMO == null)
		{
			return;
		}
		DockSite dockSite = dockHost.DockSite;
		if (dockSite != null && NMB().TryGetValue(dockHost, out var value) && value != null)
		{
			FloatingWindowControl item = value.Item2;
			if (item != null && item != eMO)
			{
				dockSite.rC5(item, eMO);
			}
		}
	}

	[CompilerGenerated]
	private bool VMW(Tuple<Rect, DockHost> P_0)
	{
		return P_0.Item2.DockSite == base.DockSite;
	}

	internal static bool GYX()
	{
		return rYa == null;
	}

	internal static NI cYs()
	{
		return rYa;
	}
}
