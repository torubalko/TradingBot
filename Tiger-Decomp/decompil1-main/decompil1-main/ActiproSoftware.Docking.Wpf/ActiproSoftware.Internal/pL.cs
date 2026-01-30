using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Text;
using System.Windows;
using System.Windows.Media;
using ActiproSoftware.Windows.Controls;
using ActiproSoftware.Windows.Controls.Docking;

namespace ActiproSoftware.Internal;

internal static class pL
{
	private static pL mAt;

	private static void mxr<y1>(List<b4<y1>> P_0, Predicate<y1> P_1, int P_2, lX P_3) where y1 : class, lX
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(vVK.ssH(22334));
		}
		if (P_3 == null)
		{
			return;
		}
		foreach (lX childNode in P_3.ChildNodes)
		{
			if (childNode is y1 val && (P_1 == null || P_1(val)))
			{
				P_0.Add(new b4<y1>(P_2, P_3, val));
			}
			mxr(P_0, P_1, P_2 + 1, childNode);
		}
		if (P_0.Count > 1 && typeof(bv).IsAssignableFrom(typeof(y1)))
		{
			P_0.Sort(delegate(b4<y1> b5, b4<y1> y)
			{
				bv bv2 = b5.dx3() as bv;
				bv bv3 = y.dx3() as bv;
				return (bv2 != null && bv3 != null) ? bv3.lCM.CompareTo(bv2.lCM) : 0;
			});
		}
	}

	private static iy Qxx(DockHost P_0, Point P_1, wH P_2)
	{
		if (P_2 != null)
		{
			if (P_2 is iy { HasDockGuides: not false } iy2 && P_2 is FrameworkElement frameworkElement)
			{
				if (frameworkElement.Visibility != Visibility.Visible || !frameworkElement.IsVisible || VisualTreeHelper.GetParent(frameworkElement) == null)
				{
					return null;
				}
				int num = 0;
				if (!PAp())
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				Point point = P_0.TransformToVisual(frameworkElement).Transform(P_1);
				Rect rect = new Rect(default(Point), frameworkElement.RenderSize);
				if (rect.Contains(point))
				{
					return iy2;
				}
			}
			foreach (lX childNode in P_2.ChildNodes)
			{
				iy iy3 = Qxx(P_0, P_1, childNode as wH);
				if (iy3 != null)
				{
					return iy3;
				}
			}
		}
		return null;
	}

	public static IList<b4<Db>> Mxl<Db>(lX P_0, Predicate<Db> P_1) where Db : class, lX
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(vVK.ssH(22352));
		}
		List<b4<Db>> list = new List<b4<Db>>();
		mxr(list, P_1, 1, P_0);
		return list;
	}

	public static IList<b4<lm>> YxM<lm>(IEnumerable<lX> P_0, Predicate<lm> P_1) where lm : class, lX
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(vVK.ssH(22372));
		}
		List<b4<lm>> list = new List<b4<lm>>();
		foreach (lX item in P_0)
		{
			mxr(list, P_1, 1, item);
		}
		return list;
	}

	public static iy gxv(DockHost P_0, Point P_1)
	{
		return Qxx(P_0, P_1, P_0.Child as wH);
	}

	[SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase")]
	public static string mx7(DockSite P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(vVK.ssH(10308));
		}
		IList<b4<lX>> list = Mxl<lX>(P_0, null);
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine(vVK.ssH(7352));
		foreach (b4<lX> item in list)
		{
			if (item.dx3() is DockHost dockHost)
			{
				stringBuilder.AppendLine(string.Format(CultureInfo.InvariantCulture, vVK.ssH(22394), new object[2]
				{
					new string('\t', item.OxR()),
					(dockHost == P_0.PrimaryDockHost) ? vVK.ssH(22486) : string.Format(CultureInfo.InvariantCulture, (dockHost.Re5() ? vVK.ssH(22448) : vVK.ssH(22432)) + vVK.ssH(22468), new object[1] { dockHost.GeB() })
				}));
			}
			else if (item.dx3() is SplitContainer splitContainer)
			{
				stringBuilder.AppendLine(string.Format(CultureInfo.InvariantCulture, vVK.ssH(22504), new string('\t', item.OxR()), splitContainer.Orientation.ToString().ToLowerInvariant(), splitContainer.ActualWidth, splitContainer.ActualHeight));
			}
			else if (item.dx3() is ToolWindowContainer toolWindowContainer)
			{
				Side? side = null;
				if (toolWindowContainer.State == DockingWindowState.AutoHide)
				{
					DockHost dockHost2 = toolWindowContainer.DockHost;
					if (dockHost2 != null)
					{
						side = dockHost2.S2r(toolWindowContainer);
					}
				}
				stringBuilder.AppendLine(string.Format(CultureInfo.InvariantCulture, vVK.ssH(22574) + (side.HasValue ? vVK.ssH(22646) : vVK.ssH(22622)), new string('\t', item.OxR()), side.HasValue ? side.Value.ToString().ToLowerInvariant() : null, toolWindowContainer.ActualWidth, toolWindowContainer.ActualHeight));
			}
			else if (item.dx3() is DockingWindow dockingWindow)
			{
				stringBuilder.AppendLine(string.Format(CultureInfo.InvariantCulture, vVK.ssH(22682), new object[3]
				{
					new string('\t', item.OxR()),
					dockingWindow.GetType().Name,
					dockingWindow.Title
				}));
			}
			else if (item.dx3() is bv bv2)
			{
				DockingWindow dockingWindow2 = P_0.KNF(bv2.UniqueId);
				if (dockingWindow2 != null)
				{
					stringBuilder.AppendLine(string.Format(CultureInfo.InvariantCulture, vVK.ssH(22710), new object[3]
					{
						new string('\t', item.OxR()),
						dockingWindow2.GetType().Name,
						dockingWindow2.Title
					}));
				}
				else
				{
					stringBuilder.AppendLine(string.Format(CultureInfo.InvariantCulture, vVK.ssH(22768), new object[1]
					{
						new string('\t', item.OxR())
					}));
				}
			}
			else if (item.dx3() is Workspace workspace)
			{
				stringBuilder.AppendLine(string.Format(CultureInfo.InvariantCulture, vVK.ssH(22798), new object[3]
				{
					new string('\t', item.OxR()),
					workspace.ActualWidth,
					workspace.ActualHeight
				}));
			}
			else if (item.dx3() is jJ jJ2)
			{
				stringBuilder.AppendLine(string.Format(CultureInfo.InvariantCulture, vVK.ssH(22846), new object[2]
				{
					new string('\t', item.OxR()),
					jJ2.GetType().Name
				}));
			}
			else if (item.dx3() is TabbedMdiContainer tabbedMdiContainer)
			{
				stringBuilder.AppendLine(string.Format(CultureInfo.InvariantCulture, vVK.ssH(22862), new object[3]
				{
					new string('\t', item.OxR()),
					tabbedMdiContainer.ActualWidth,
					tabbedMdiContainer.ActualHeight
				}));
			}
			else if (item.dx3() is ac ac2)
			{
				stringBuilder.AppendLine(string.Format(CultureInfo.InvariantCulture, vVK.ssH(22846), new object[2]
				{
					new string('\t', item.OxR()),
					ac2.GetType().Name
				}));
			}
		}
		return stringBuilder.ToString();
	}

	internal static bool PAp()
	{
		return mAt == null;
	}

	internal static pL HA4()
	{
		return mAt;
	}
}
