using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using ActiproSoftware.Windows.Controls;
using ActiproSoftware.Windows.Controls.Docking;
using ActiproSoftware.Windows.Controls.Docking.Primitives;
using ActiproSoftware.Windows.Extensions;
using ActiproSoftware.Windows.Media;

namespace ActiproSoftware.Internal;

internal class QK : Grid
{
	[Flags]
	private enum GV9
	{

	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass22_0
	{
		public QK c6O;

		public DockHost w6T;

		public bool W68;

		public DockHost L6D;

		internal static _003C_003Ec__DisplayClass22_0 icT;

		public _003C_003Ec__DisplayClass22_0()
		{
			IVH.CecNqz();
			base._002Ector();
		}

		internal void C6n(object sender, RoutedEventArgs e)
		{
			if (c6O.pDd)
			{
				return;
			}
			iy iy2 = w6T;
			bool flag2;
			bool flag3;
			int num2;
			if (W68 && iy2.HasDockGuides && iy2.SupportsOuterSideDock(L6D))
			{
				DockGuideKinds dockGuideKinds = DockGuideKinds.Outer;
				DockSite dockSite = iy2.DockSite;
				if (L6D != null && dockSite != null)
				{
					dockGuideKinds = dockSite.R1H(L6D, iy2, dockGuideKinds);
				}
				bool num = (dockGuideKinds & DockGuideKinds.OuterLeft) == DockGuideKinds.OuterLeft;
				bool flag = (dockGuideKinds & DockGuideKinds.OuterTop) == DockGuideKinds.OuterTop;
				flag2 = (dockGuideKinds & DockGuideKinds.OuterRight) == DockGuideKinds.OuterRight;
				flag3 = (dockGuideKinds & DockGuideKinds.OuterBottom) == DockGuideKinds.OuterBottom;
				if (num)
				{
					c6O.HDC.Visibility = Visibility.Visible;
				}
				if (flag)
				{
					c6O.lDN.Visibility = Visibility.Visible;
				}
				if (flag2)
				{
					c6O.mD1.Visibility = Visibility.Visible;
				}
				if (flag3)
				{
					c6O.IDI.Visibility = Visibility.Visible;
				}
				if (num)
				{
					c6O.m8P(c6O.HDC, _0020: false, (GV9)1, 0.2, 0.0, 1.0);
				}
				if (flag)
				{
					c6O.m8P(c6O.lDN, _0020: false, (GV9)1, 0.2, 0.0, 1.0);
					num2 = 1;
					if (YcR() != null)
					{
						goto IL_0005;
					}
					goto IL_0009;
				}
				goto IL_001b;
			}
			goto IL_0138;
			IL_01b8:
			if (flag3)
			{
				c6O.m8P(c6O.IDI, _0020: false, (GV9)1, 0.2, 0.0, 1.0);
			}
			goto IL_0138;
			IL_0138:
			c6O.pDd = true;
			return;
			IL_0009:
			switch (num2)
			{
			case 1:
				break;
			default:
				goto IL_01b8;
			}
			goto IL_001b;
			IL_001b:
			if (flag2)
			{
				c6O.m8P(c6O.mD1, _0020: false, (GV9)1, 0.2, 0.0, 1.0);
				num2 = 0;
				if (!mcx())
				{
					goto IL_0005;
				}
				goto IL_0009;
			}
			goto IL_01b8;
			IL_0005:
			int num3 = default(int);
			num2 = num3;
			goto IL_0009;
		}

		internal static bool mcx()
		{
			return icT == null;
		}

		internal static _003C_003Ec__DisplayClass22_0 YcR()
		{
			return icT;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass38_0
	{
		public DockGuideBase d6r;

		internal static _003C_003Ec__DisplayClass38_0 JcD;

		public _003C_003Ec__DisplayClass38_0()
		{
			IVH.CecNqz();
			base._002Ector();
		}

		internal HitTestFilterBehavior l6E(DependencyObject obj)
		{
			d6r = obj as DockGuideBase;
			if (d6r != null && d6r.Visibility == Visibility.Visible && d6r.Opacity > 0.0)
			{
				DockGuideCross ancestor = VisualTreeHelperExtended.GetAncestor<DockGuideCross>(d6r);
				if (ancestor == null || ancestor.Opacity > 0.0)
				{
					return HitTestFilterBehavior.Stop;
				}
			}
			d6r = null;
			return HitTestFilterBehavior.Continue;
		}

		internal static bool dcE()
		{
			return JcD == null;
		}

		internal static _003C_003Ec__DisplayClass38_0 jck()
		{
			return JcD;
		}
	}

	private bool pDd;

	private bool ADw;

	private bool TD2;

	private bool DDe;

	private Size jDG;

	private DockGuideOuterBottom IDI;

	private DockGuideCross qDk;

	private DockGuideOuterLeft HDC;

	private DockGuideOuterRight mD1;

	private DockGuideOuterTop lDN;

	private DockPreview fDQ;

	private DockPreview zDm;

	private DockHost MDa;

	private iy XDW;

	private Canvas uDB;

	private iy QDK;

	private DockHost kDJ;

	private fF pDn;

	private static QK SnK;

	[SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
	private iy o8y
	{
		get
		{
			return QDK;
		}
		set
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
					case 0:
						return;
					case 1:
						if (QDK != iy2)
						{
							if (QDK != null)
							{
								m8P(qDk, _0020: true, (GV9)1, (iy2 != null) ? 0.0 : 0.1, 1.0, 0.0);
							}
							QDK = iy2;
							if (QDK != null && QDK is FrameworkElement frameworkElement && a8H())
							{
								Point point = new Point(Math.Round(frameworkElement.ActualWidth / 2.0), Math.Round(frameworkElement.ActualHeight / 2.0));
								point = frameworkElement.TransformToVisual(kDJ).Transform(point);
								qDk.Measure(new Size(1000.0, 1000.0));
								double length = point.X - Math.Round(qDk.DesiredSize.Width / 2.0);
								double length2 = point.Y - Math.Round(qDk.DesiredSize.Height / 2.0);
								Canvas.SetLeft(qDk, length);
								Canvas.SetTop(qDk, length2);
								m8P(qDk, _0020: false, (GV9)1, 0.2, 0.0, 1.0);
							}
							return;
						}
						num2 = 0;
						if (Knc() == null)
						{
							break;
						}
						goto end_IL_0012;
					}
					continue;
					end_IL_0012:
					break;
				}
			}
		}
	}

	public QK(DockHost P_0, DockHost P_1, Size P_2, bool P_3, bool P_4, bool P_5)
	{
		IVH.CecNqz();
		_003C_003Ec__DisplayClass22_0 CS_0024_003C_003E8__locals34 = new _003C_003Ec__DisplayClass22_0();
		CS_0024_003C_003E8__locals34.w6T = P_1;
		CS_0024_003C_003E8__locals34.W68 = P_3;
		CS_0024_003C_003E8__locals34.L6D = P_0;
		base._002Ector();
		CS_0024_003C_003E8__locals34.c6O = this;
		if (CS_0024_003C_003E8__locals34.L6D == null)
		{
			throw new ArgumentNullException(vVK.ssH(9114));
		}
		if (CS_0024_003C_003E8__locals34.w6T == null)
		{
			throw new ArgumentNullException(vVK.ssH(21048));
		}
		MDa = CS_0024_003C_003E8__locals34.L6D;
		kDJ = CS_0024_003C_003E8__locals34.w6T;
		jDG = P_2;
		DDe = CS_0024_003C_003E8__locals34.W68;
		ADw = P_4;
		TD2 = P_5;
		XDW = CS_0024_003C_003E8__locals34.L6D.pGK() as iy;
		uDB = new Canvas();
		base.Children.Add(uDB);
		fDQ = new DockPreview
		{
			IsHitTestVisible = false,
			Opacity = 0.0,
			RenderTransform = new ScaleTransform(),
			RenderTransformOrigin = new Point(0.5, 0.5)
		};
		zDm = new DockPreview
		{
			IsHitTestVisible = false,
			Opacity = 0.0,
			RenderTransform = new ScaleTransform(),
			RenderTransformOrigin = new Point(0.5, 0.5)
		};
		uDB.Children.Add(fDQ);
		uDB.Children.Add(zDm);
		qDk = new DockGuideCross
		{
			Opacity = 0.0,
			RenderTransform = new ScaleTransform(),
			RenderTransformOrigin = new Point(0.5, 0.5)
		};
		uDB.Children.Add(qDk);
		HDC = new DockGuideOuterLeft
		{
			Target = CS_0024_003C_003E8__locals34.w6T,
			Opacity = 0.0,
			Visibility = Visibility.Collapsed,
			RenderTransform = new ScaleTransform(),
			RenderTransformOrigin = new Point(0.5, 0.5)
		};
		base.Children.Add(HDC);
		lDN = new DockGuideOuterTop
		{
			Target = CS_0024_003C_003E8__locals34.w6T,
			Opacity = 0.0,
			Visibility = Visibility.Collapsed,
			RenderTransform = new ScaleTransform(),
			RenderTransformOrigin = new Point(0.5, 0.5)
		};
		base.Children.Add(lDN);
		mD1 = new DockGuideOuterRight
		{
			Target = CS_0024_003C_003E8__locals34.w6T,
			Opacity = 0.0,
			Visibility = Visibility.Collapsed,
			RenderTransform = new ScaleTransform(),
			RenderTransformOrigin = new Point(0.5, 0.5)
		};
		base.Children.Add(mD1);
		IDI = new DockGuideOuterBottom
		{
			Target = CS_0024_003C_003E8__locals34.w6T,
			Opacity = 0.0,
			Visibility = Visibility.Collapsed,
			RenderTransform = new ScaleTransform(),
			RenderTransformOrigin = new Point(0.5, 0.5)
		};
		base.Children.Add(IDI);
		kq kq2 = CS_0024_003C_003E8__locals34.w6T.LayoutKind;
		if (kq2 != 0 && (uint)(kq2 - 2) > 2u)
		{
			return;
		}
		base.Loaded += delegate
		{
			if (CS_0024_003C_003E8__locals34.c6O.pDd)
			{
				return;
			}
			iy iy2 = CS_0024_003C_003E8__locals34.w6T;
			bool flag2;
			bool flag3;
			int num2;
			if (CS_0024_003C_003E8__locals34.W68 && iy2.HasDockGuides && iy2.SupportsOuterSideDock(CS_0024_003C_003E8__locals34.L6D))
			{
				DockGuideKinds dockGuideKinds = DockGuideKinds.Outer;
				DockSite dockSite = iy2.DockSite;
				if (CS_0024_003C_003E8__locals34.L6D != null && dockSite != null)
				{
					dockGuideKinds = dockSite.R1H(CS_0024_003C_003E8__locals34.L6D, iy2, dockGuideKinds);
				}
				bool num = (dockGuideKinds & DockGuideKinds.OuterLeft) == DockGuideKinds.OuterLeft;
				bool flag = (dockGuideKinds & DockGuideKinds.OuterTop) == DockGuideKinds.OuterTop;
				flag2 = (dockGuideKinds & DockGuideKinds.OuterRight) == DockGuideKinds.OuterRight;
				flag3 = (dockGuideKinds & DockGuideKinds.OuterBottom) == DockGuideKinds.OuterBottom;
				if (num)
				{
					CS_0024_003C_003E8__locals34.c6O.HDC.Visibility = Visibility.Visible;
				}
				if (flag)
				{
					CS_0024_003C_003E8__locals34.c6O.lDN.Visibility = Visibility.Visible;
				}
				if (flag2)
				{
					CS_0024_003C_003E8__locals34.c6O.mD1.Visibility = Visibility.Visible;
				}
				if (flag3)
				{
					CS_0024_003C_003E8__locals34.c6O.IDI.Visibility = Visibility.Visible;
				}
				if (num)
				{
					CS_0024_003C_003E8__locals34.c6O.m8P(CS_0024_003C_003E8__locals34.c6O.HDC, _0020: false, (GV9)1, 0.2, 0.0, 1.0);
				}
				if (flag)
				{
					CS_0024_003C_003E8__locals34.c6O.m8P(CS_0024_003C_003E8__locals34.c6O.lDN, _0020: false, (GV9)1, 0.2, 0.0, 1.0);
					num2 = 1;
					if (_003C_003Ec__DisplayClass22_0.YcR() != null)
					{
						goto IL_0005;
					}
					goto IL_0009;
				}
				goto IL_001b;
			}
			goto IL_0138;
			IL_01b8:
			if (flag3)
			{
				CS_0024_003C_003E8__locals34.c6O.m8P(CS_0024_003C_003E8__locals34.c6O.IDI, _0020: false, (GV9)1, 0.2, 0.0, 1.0);
			}
			goto IL_0138;
			IL_0138:
			CS_0024_003C_003E8__locals34.c6O.pDd = true;
			return;
			IL_0009:
			switch (num2)
			{
			case 1:
				break;
			default:
				goto IL_01b8;
			}
			goto IL_001b;
			IL_001b:
			if (flag2)
			{
				CS_0024_003C_003E8__locals34.c6O.m8P(CS_0024_003C_003E8__locals34.c6O.mD1, _0020: false, (GV9)1, 0.2, 0.0, 1.0);
				num2 = 0;
				if (!_003C_003Ec__DisplayClass22_0.mcx())
				{
					goto IL_0005;
				}
				goto IL_0009;
			}
			goto IL_01b8;
			IL_0005:
			int num3 = default(int);
			num2 = num3;
			goto IL_0009;
		};
	}

	private void m8P(Control P_0, bool P_1, GV9 P_2, double P_3, double P_4, double P_5)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(vVK.ssH(21080));
		}
		double num = (P_1 ? 1.0 : 0.92);
		double num2 = (P_1 ? 0.92 : 1.0);
		bool flag = (P_2 & (GV9)1) == (GV9)1;
		bool flag2 = (P_2 & (GV9)2) == (GV9)2;
		DockSite dockSite = ((kDJ != null) ? kDJ.DockSite : null);
		if (dockSite == null || !dockSite.IsDockGuideAnimationEnabled || P_2 == (GV9)0)
		{
			P_3 = 0.0;
		}
		zn.Yxf(P_0, P_3, flag, flag2, P_4, P_5, num, num2);
	}

	private static Geometry t8f(Rect P_0, Side P_1, double P_2)
	{
		bool flag = false;
		double num;
		if (P_1 == Side.Left || P_1 == Side.Right)
		{
			flag = P_0.Width - P_2 > 5.0;
			num = Math.Min(30.0, P_0.Height / 2.0);
		}
		else
		{
			flag = P_0.Height - P_2 > 5.0;
			num = Math.Min(70.0, P_0.Width / 2.0);
		}
		if (!flag)
		{
			return new RectangleGeometry
			{
				Rect = P_0
			};
		}
		return P_1 switch
		{
			Side.Left => new PathGeometry
			{
				Figures = 
				{
					new PathFigure
					{
						IsClosed = true,
						StartPoint = new Point(P_0.Left, P_0.Top),
						Segments = 
						{
							(PathSegment)new LineSegment
							{
								Point = new Point(P_0.Right, P_0.Top)
							},
							(PathSegment)new LineSegment
							{
								Point = new Point(P_0.Right, P_0.Bottom)
							},
							(PathSegment)new LineSegment
							{
								Point = new Point(P_0.Left + P_2, P_0.Bottom)
							},
							(PathSegment)new LineSegment
							{
								Point = new Point(P_0.Left + P_2, P_0.Top + num)
							},
							(PathSegment)new LineSegment
							{
								Point = new Point(P_0.Left, P_0.Top + num)
							}
						}
					}
				}
			}, 
			Side.Top => new PathGeometry
			{
				Figures = 
				{
					new PathFigure
					{
						IsClosed = true,
						StartPoint = new Point(P_0.Left, P_0.Top),
						Segments = 
						{
							(PathSegment)new LineSegment
							{
								Point = new Point(P_0.Left + num, P_0.Top)
							},
							(PathSegment)new LineSegment
							{
								Point = new Point(P_0.Left + num, P_0.Top + P_2)
							},
							(PathSegment)new LineSegment
							{
								Point = new Point(P_0.Right, P_0.Top + P_2)
							},
							(PathSegment)new LineSegment
							{
								Point = new Point(P_0.Right, P_0.Bottom)
							},
							(PathSegment)new LineSegment
							{
								Point = new Point(P_0.Left, P_0.Bottom)
							}
						}
					}
				}
			}, 
			Side.Right => new PathGeometry
			{
				Figures = 
				{
					new PathFigure
					{
						IsClosed = true,
						StartPoint = new Point(P_0.Left, P_0.Top),
						Segments = 
						{
							(PathSegment)new LineSegment
							{
								Point = new Point(P_0.Right, P_0.Top)
							},
							(PathSegment)new LineSegment
							{
								Point = new Point(P_0.Right, P_0.Top + num)
							},
							(PathSegment)new LineSegment
							{
								Point = new Point(P_0.Right - P_2, P_0.Top + num)
							},
							(PathSegment)new LineSegment
							{
								Point = new Point(P_0.Right - P_2, P_0.Bottom)
							},
							(PathSegment)new LineSegment
							{
								Point = new Point(P_0.Left, P_0.Bottom)
							}
						}
					}
				}
			}, 
			_ => new PathGeometry
			{
				Figures = 
				{
					new PathFigure
					{
						IsClosed = true,
						StartPoint = new Point(P_0.Left, P_0.Top),
						Segments = 
						{
							(PathSegment)new LineSegment
							{
								Point = new Point(P_0.Right, P_0.Top)
							},
							(PathSegment)new LineSegment
							{
								Point = new Point(P_0.Right, P_0.Bottom - P_2)
							},
							(PathSegment)new LineSegment
							{
								Point = new Point(P_0.Left + num, P_0.Bottom - P_2)
							},
							(PathSegment)new LineSegment
							{
								Point = new Point(P_0.Left + num, P_0.Bottom)
							},
							(PathSegment)new LineSegment
							{
								Point = new Point(P_0.Left, P_0.Bottom)
							}
						}
					}
				}
			}, 
		};
	}

	private Rect W8U(Rect P_0)
	{
		double num = ((fDQ != null) ? fDQ.BorderThickness.Left : 0.0);
		return new Rect(P_0.X + num / 2.0, P_0.Y + num / 2.0, Math.Max(0.0, P_0.Width - num), Math.Max(0.0, P_0.Height - num));
	}

	private void G8c()
	{
		X84(0.0, 0.0, null);
	}

	private void X84(double P_0, double P_1, Geometry P_2)
	{
		if (fDQ != null && zDm != null)
		{
			if (fDQ.Opacity > 0.0)
			{
				m8P(fDQ, _0020: true, (GV9)3, 0.1, (P_2 != null) ? 0.0 : 0.4, 0.0);
				DockPreview dockPreview = fDQ;
				fDQ = zDm;
				zDm = dockPreview;
			}
			Canvas.SetLeft(fDQ, P_0);
			Canvas.SetTop(fDQ, P_1);
			fDQ.Geometry = P_2;
			if (P_2 != null)
			{
				m8P(fDQ, _0020: false, (GV9)3, 0.2, 0.0, 0.4);
			}
		}
	}

	private bool I8j()
	{
		if (pDn != null && pDn.UlT() != null)
		{
			int num = 0;
			if (Knc() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			if (pDn.UlJ().HasValue)
			{
				if (pDn.UlT() == kDJ)
				{
					return E8Z(pDn.UlJ().Value);
				}
				if (pDn.UlT() is jJ jJ2)
				{
					return N8b(jJ2 as Control, pDn.UlJ().Value);
				}
				if (pDn.UlT() is zj zj2)
				{
					return N8b(zj2 as Control, pDn.UlJ().Value);
				}
				if (pDn.UlT() is Workspace workspace)
				{
					return N8b(workspace, pDn.UlJ().Value);
				}
			}
			else if (pDn.UlT() is FrameworkElement frameworkElement)
			{
				return g8A(frameworkElement);
			}
		}
		return false;
	}

	private bool E8Z(Side P_0)
	{
		if (kDJ != null && kDJ.dem() != null)
		{
			Rect rect = z80(kDJ, P_0, jDG);
			Rect rect2 = W8U(new Rect(0.0, 0.0, rect.Width, rect.Height));
			X84(rect.X, rect.Y, new RectangleGeometry
			{
				Rect = rect2
			});
			return true;
		}
		return false;
	}

	private bool N8b(Control P_0, Side P_1)
	{
		if (kDJ != null && P_0 != null)
		{
			Rect rect = k8h(kDJ, P_0, P_1, jDG);
			Rect rect2 = W8U(new Rect(0.0, 0.0, rect.Width, rect.Height));
			X84(rect.X, rect.Y, new RectangleGeometry
			{
				Rect = rect2
			});
			return true;
		}
		return false;
	}

	private bool g8A(FrameworkElement P_0)
	{
		if (P_0 == null)
		{
			return false;
		}
		Rect rect = P_0.TransformToVisual(kDJ).TransformBounds(new Rect(default(Point), P_0.RenderSize));
		Rect rect2 = W8U(new Rect(0.0, 0.0, rect.Width, rect.Height));
		Geometry geometry = null;
		if (P_0 is zj zj2)
		{
			int num = 0;
			if (Knc() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			double num3 = zj2.GetSizeAscent(zj2.TabPanelSize);
			if (num3.IsEffectivelyEqual(0.0))
			{
				num3 = 20.0;
			}
			geometry = t8f(rect2, zj2.TabStripPlacement, num3);
		}
		if (geometry == null)
		{
			geometry = new RectangleGeometry
			{
				Rect = rect2
			};
		}
		X84(rect.X, rect.Y, geometry);
		return true;
	}

	private bool a8H()
	{
		DockGuideKinds dockGuideKinds = DockGuideKinds.None;
		if (QDK != null && QDK.HasDockGuides)
		{
			bool flag = QDK is ac || QDK is jJ;
			if (DDe && QDK.SupportsOuterSideDock(MDa))
			{
				dockGuideKinds |= DockGuideKinds.Outer;
			}
			if (((flag && TD2) || !flag) && DDe && QDK.SupportsInnerSideDock(MDa))
			{
				dockGuideKinds |= DockGuideKinds.Inner;
			}
			if (ADw && QDK.SupportsAttach(MDa))
			{
				dockGuideKinds |= DockGuideKinds.Center;
			}
			DockSite dockSite = QDK.DockSite;
			if (MDa != null && dockSite != null)
			{
				dockGuideKinds = dockSite.R1H(MDa, QDK, dockGuideKinds);
			}
		}
		bool num = (dockGuideKinds & DockGuideKinds.Outer) != 0;
		bool flag2 = (dockGuideKinds & DockGuideKinds.Inner) != 0;
		bool flag3 = (dockGuideKinds & DockGuideKinds.Center) == DockGuideKinds.Center;
		iy iy2 = (num ? QDK : null);
		iy iy3 = (flag2 ? QDK : null);
		iy iy4 = (flag3 ? QDK : null);
		if (iy2 != null && iy2 is ac ac2)
		{
			iy2 = ac2.MdiHost as iy;
		}
		qDk.T8M(iy2, iy3, iy4, dockGuideKinds);
		return num || flag2 || flag3;
	}

	public static Rect z80(DockHost P_0, Side P_1, Size P_2)
	{
		int num = 1;
		Rect rect = default(Rect);
		double x7 = default(double);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				double num3;
				double num4;
				double y;
				switch (num2)
				{
				case 2:
					if (P_1 == Side.Left || P_1 == Side.Right)
					{
						num3 = Math.Max(0.0, Math.Min(rect.Width / 2.0, P_2.Width));
						num4 = rect.Height;
					}
					else
					{
						num3 = rect.Width;
						num4 = Math.Max(0.0, Math.Min(rect.Height / 2.0, P_2.Height));
					}
					if (P_1 != Side.Right)
					{
						if (P_1 == Side.Bottom)
						{
							x7 = rect.X;
							y = rect.Bottom - num4;
						}
						else
						{
							x7 = rect.X;
							y = rect.Y;
						}
					}
					else
					{
						x7 = rect.Right - num3;
						y = rect.Y;
					}
					goto IL_009e;
				default:
					y = 0.0;
					num3 = 200.0;
					num4 = 200.0;
					if (P_0 != null && P_0.dem() != null)
					{
						rect = P_0.dem().TransformToVisual(P_0).TransformBounds(new Rect(default(Point), P_0.dem().RenderSize));
						num2 = 2;
						if (Knc() == null)
						{
							continue;
						}
						break;
					}
					goto IL_009e;
				case 1:
					{
						x7 = 0.0;
						num2 = 0;
						if (Knc() == null)
						{
							continue;
						}
						break;
					}
					IL_009e:
					return new Rect(x7, y, num3, num4);
				}
				break;
			}
		}
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	public static Rect k8h(DockHost P_0, Control P_1, Side P_2, Size P_3)
	{
		double x7 = 0.0;
		double y = 0.0;
		double num = 200.0;
		double num2 = 200.0;
		if (P_0 != null && P_1 != null)
		{
			Orientation orientation = ((P_2 != Side.Left && P_2 != Side.Right) ? Orientation.Vertical : Orientation.Horizontal);
			SplitContainer splitContainer = SplitContainer.Lm5(P_1)?.Item1;
			bool flag = splitContainer != null && splitContainer.Orientation == orientation;
			Tuple<int, int, wH, wH> tuple = (flag ? splitContainer.PmX(P_1) : Tuple.Create<int, int, wH, wH>(-1, 0, null, null));
			int item = tuple.Item1;
			int item2 = tuple.Item2;
			bool flag2 = tuple.Item3 != null && tuple.Item3.ContainsWorkspace;
			bool flag3 = tuple.Item4 != null && tuple.Item4.ContainsWorkspace;
			Size size = new Size(Math.Floor(P_1.ActualWidth / 2.0), Math.Floor(P_1.ActualHeight / 2.0));
			Size size2 = (flag ? new Size(Math.Floor(splitContainer.ActualWidth / 2.0), Math.Floor(splitContainer.ActualHeight / 2.0)) : size);
			Workspace workspace = P_0.Workspace;
			Size size3 = ((flag && workspace != null) ? new Size(Math.Floor(workspace.ActualWidth / 2.0), Math.Floor(workspace.ActualHeight / 2.0)) : default(Size));
			Rect rect = P_1.TransformToVisual(P_0).TransformBounds(new Rect(default(Point), P_1.RenderSize));
			Rect rect2 = splitContainer?.TransformToVisual(P_0).TransformBounds(new Rect(default(Point), splitContainer.RenderSize)) ?? rect;
			if (P_2 == Side.Left || P_2 == Side.Right)
			{
				num = Math.Max(0.0, Math.Min(size2.Width, Math.Min(size.Width + size3.Width, P_3.Width)));
				num2 = rect.Height;
			}
			else
			{
				num = rect.Width;
				num2 = Math.Max(0.0, Math.Min(size2.Height, Math.Min(size.Height + size3.Height, P_3.Height)));
			}
			if (flag && item != -1)
			{
				switch (P_2)
				{
				case Side.Bottom:
					x7 = rect.X;
					y = Math.Max(rect2.Y, Math.Min(rect2.Bottom - num2, rect.Bottom - num2 + ((item >= item2 - 1) ? 0.0 : (flag3 ? (P_0.SplitterSize + num2) : Math.Round(num2 / 2.0)))));
					break;
				case Side.Left:
					x7 = Math.Max(rect2.X, Math.Min(rect2.Right - num, rect.X - ((item == 0) ? 0.0 : (flag2 ? (num + P_0.SplitterSize) : Math.Round(num / 2.0)))));
					y = rect.Y;
					break;
				case Side.Right:
					x7 = Math.Max(rect2.X, Math.Min(rect2.Right - num, rect.Right - num + ((item >= item2 - 1) ? 0.0 : (flag3 ? (P_0.SplitterSize + num) : Math.Round(num / 2.0)))));
					y = rect.Y;
					break;
				default:
					x7 = rect.X;
					y = Math.Max(rect2.Y, Math.Min(rect2.Bottom - num2, rect.Y - ((item == 0) ? 0.0 : (flag2 ? (num2 + P_0.SplitterSize) : Math.Round(num2 / 2.0)))));
					break;
				}
			}
			else
			{
				switch (P_2)
				{
				case Side.Bottom:
					x7 = rect.X;
					y = rect.Bottom - num2;
					break;
				case Side.Right:
					x7 = rect.Right - num;
					y = rect.Y;
					break;
				default:
					x7 = rect.X;
					y = rect.Y;
					break;
				}
			}
		}
		return new Rect(x7, y, num, num2);
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling")]
	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	public void Q8g(Point P_0)
	{
		_003C_003Ec__DisplayClass38_0 CS_0024_003C_003E8__locals10 = new _003C_003Ec__DisplayClass38_0();
		CS_0024_003C_003E8__locals10.d6r = null;
		VisualTreeHelper.HitTest(this, delegate(DependencyObject obj)
		{
			CS_0024_003C_003E8__locals10.d6r = obj as DockGuideBase;
			if (CS_0024_003C_003E8__locals10.d6r != null && CS_0024_003C_003E8__locals10.d6r.Visibility == Visibility.Visible && CS_0024_003C_003E8__locals10.d6r.Opacity > 0.0)
			{
				DockGuideCross ancestor = VisualTreeHelperExtended.GetAncestor<DockGuideCross>(CS_0024_003C_003E8__locals10.d6r);
				if (ancestor == null || ancestor.Opacity > 0.0)
				{
					return HitTestFilterBehavior.Stop;
				}
			}
			CS_0024_003C_003E8__locals10.d6r = null;
			return HitTestFilterBehavior.Continue;
		}, (HitTestResult result) => HitTestResultBehavior.Stop, new PointHitTestParameters(P_0));
		fF fF2 = null;
		if (CS_0024_003C_003E8__locals10.d6r != null)
		{
			Point point = TransformToVisual(CS_0024_003C_003E8__locals10.d6r).Transform(P_0);
			fF2 = CS_0024_003C_003E8__locals10.d6r.X8r(point);
		}
		else
		{
			iy iy2 = pL.gxv(kDJ, P_0);
			if (iy2 != null && XDW != null)
			{
				if (iy2 == XDW)
				{
					iy2 = null;
				}
				else if (XDW is DockingWindow dockingWindow && iy2 == dockingWindow.ParentContainer && dockingWindow.ParentContainer.WindowsCore.Count == 1)
				{
					iy2 = null;
				}
			}
			o8y = iy2;
			if (ADw && fF2 == null && iy2 is zj { HasDockGuides: not false } zj2 && zj2.SupportsAttach(MDa))
			{
				DockGuideKinds dockGuideKinds = DockGuideKinds.Center;
				DockSite dockSite = zj2.DockSite;
				if (MDa != null && dockSite != null)
				{
					dockGuideKinds = dockSite.R1H(MDa, zj2, dockGuideKinds);
				}
				if ((dockGuideKinds & DockGuideKinds.Center) == DockGuideKinds.Center && zj2 is Control visual)
				{
					Point point2 = kDJ.TransformToVisual(visual).Transform(P_0);
					if (zj2.IsOverTitleBar(point2) || zj2.IsOverTabStrip(point2))
					{
						fF2 = new fF(null, zj2, null);
					}
				}
			}
		}
		h8z(fF2);
	}

	[SpecialName]
	public DockHost j8o()
	{
		return kDJ;
	}

	[SpecialName]
	public fF Q8u()
	{
		return pDn;
	}

	[SpecialName]
	private void h8z(fF P_0)
	{
		bool flag = pDn == null && P_0 == null;
		if (!flag && pDn != null && P_0 != null)
		{
			flag = pDn.Equals(P_0);
		}
		if (flag)
		{
			return;
		}
		if (pDn != null && pDn.zlW() != null)
		{
			pDn.zlW().IsSelected = false;
		}
		pDn = P_0;
		if (pDn != null)
		{
			if (pDn.zlW() != null)
			{
				pDn.zlW().IsSelected = true;
			}
			if (I8j())
			{
				return;
			}
		}
		G8c();
	}

	internal static bool BnG()
	{
		return SnK == null;
	}

	internal static QK Knc()
	{
		return SnK;
	}
}
