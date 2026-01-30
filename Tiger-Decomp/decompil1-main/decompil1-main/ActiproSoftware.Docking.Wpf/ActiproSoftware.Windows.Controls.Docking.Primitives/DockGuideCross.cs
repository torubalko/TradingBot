using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Windows;
using System.Windows.Controls;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Docking.Primitives;

[TemplatePart(Name = "PART_OuterBottomDockGuide", Type = typeof(DockGuideOuterBottom))]
[TemplatePart(Name = "PART_CenterDockGuide", Type = typeof(DockGuideCenter))]
[TemplatePart(Name = "PART_InnerRightDockGuide", Type = typeof(DockGuideInnerRight))]
[TemplatePart(Name = "PART_InnerTopDockGuide", Type = typeof(DockGuideInnerTop))]
[ToolboxItem(false)]
[TemplatePart(Name = "PART_InnerBottomDockGuide", Type = typeof(DockGuideInnerBottom))]
[TemplatePart(Name = "PART_OuterTopDockGuide", Type = typeof(DockGuideOuterTop))]
[TemplatePart(Name = "PART_OuterRightDockGuide", Type = typeof(DockGuideOuterRight))]
[TemplatePart(Name = "PART_InnerLeftDockGuide", Type = typeof(DockGuideInnerLeft))]
[TemplatePart(Name = "PART_OuterLeftDockGuide", Type = typeof(DockGuideOuterLeft))]
public class DockGuideCross : Control
{
	private iy R87;

	private DockGuideKinds N8R;

	private iy A8S;

	private iy G8L;

	private DockGuideCenter R83;

	private DockGuideInnerBottom B86;

	private DockGuideInnerLeft Y89;

	private DockGuideInnerRight u8Y;

	private DockGuideInnerTop R8p;

	private DockGuideOuterBottom c8s;

	private DockGuideOuterLeft t8q;

	private DockGuideOuterRight h8F;

	private DockGuideOuterTop h8V;

	private static DockGuideCross g8b;

	public DockGuideCross()
	{
		IVH.CecNqz();
		base._002Ector();
		base.DefaultStyleKey = typeof(DockGuideCross);
	}

	internal void T8M(iy P_0, iy P_1, iy P_2, DockGuideKinds P_3)
	{
		G8L = P_0;
		A8S = P_1;
		R87 = P_2;
		N8R = P_3;
		n8v();
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	private void n8v()
	{
		int num = 3;
		int num2 = 2;
		int num3 = 1;
		int num4 = 0;
		if (c8s != null)
		{
			bool flag = G8L != null && (N8R & DockGuideKinds.OuterBottom) == DockGuideKinds.OuterBottom;
			c8s.Target = G8L;
			c8s.Visibility = ((!flag) ? Visibility.Collapsed : Visibility.Visible);
			Panel.SetZIndex(c8s, flag ? num : num4);
		}
		if (t8q != null)
		{
			bool flag2 = G8L != null && (N8R & DockGuideKinds.OuterLeft) == DockGuideKinds.OuterLeft;
			t8q.Target = G8L;
			t8q.Visibility = ((!flag2) ? Visibility.Collapsed : Visibility.Visible);
			Panel.SetZIndex(t8q, flag2 ? num : num4);
		}
		if (h8F != null)
		{
			bool flag3 = G8L != null && (N8R & DockGuideKinds.OuterRight) == DockGuideKinds.OuterRight;
			h8F.Target = G8L;
			h8F.Visibility = ((!flag3) ? Visibility.Collapsed : Visibility.Visible);
			Panel.SetZIndex(h8F, flag3 ? num : num4);
		}
		if (h8V != null)
		{
			bool flag4 = G8L != null && (N8R & DockGuideKinds.OuterTop) == DockGuideKinds.OuterTop;
			h8V.Target = G8L;
			h8V.Visibility = ((!flag4) ? Visibility.Collapsed : Visibility.Visible);
			Panel.SetZIndex(h8V, flag4 ? num : num4);
		}
		if (B86 != null)
		{
			bool flag5 = A8S != null && (N8R & DockGuideKinds.InnerBottom) == DockGuideKinds.InnerBottom;
			B86.Target = A8S;
			B86.Visibility = ((!flag5) ? Visibility.Collapsed : Visibility.Visible);
			Panel.SetZIndex(B86, flag5 ? num2 : num4);
		}
		if (Y89 != null)
		{
			bool flag6 = A8S != null && (N8R & DockGuideKinds.InnerLeft) == DockGuideKinds.InnerLeft;
			Y89.Target = A8S;
			Y89.Visibility = ((!flag6) ? Visibility.Collapsed : Visibility.Visible);
			Panel.SetZIndex(Y89, flag6 ? num2 : num4);
		}
		if (u8Y != null)
		{
			bool flag7 = A8S != null && (N8R & DockGuideKinds.InnerRight) == DockGuideKinds.InnerRight;
			u8Y.Target = A8S;
			u8Y.Visibility = ((!flag7) ? Visibility.Collapsed : Visibility.Visible);
			Panel.SetZIndex(u8Y, flag7 ? num2 : num4);
		}
		if (R8p != null)
		{
			bool flag8 = A8S != null && (N8R & DockGuideKinds.InnerTop) == DockGuideKinds.InnerTop;
			R8p.Target = A8S;
			R8p.Visibility = ((!flag8) ? Visibility.Collapsed : Visibility.Visible);
			Panel.SetZIndex(R8p, flag8 ? num2 : num4);
		}
		if (R83 != null)
		{
			bool flag9 = R87 != null && (N8R & DockGuideKinds.Center) == DockGuideKinds.Center;
			R83.Target = R87;
			R83.Visibility = ((!flag9) ? Visibility.Collapsed : Visibility.Visible);
			Panel.SetZIndex(R83, flag9 ? num3 : num4);
		}
	}

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		R83 = GetTemplateChild(vVK.ssH(20596)) as DockGuideCenter;
		B86 = GetTemplateChild(vVK.ssH(20640)) as DockGuideInnerBottom;
		Y89 = GetTemplateChild(vVK.ssH(20694)) as DockGuideInnerLeft;
		u8Y = GetTemplateChild(vVK.ssH(20744)) as DockGuideInnerRight;
		int num = 0;
		if (I8x() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		R8p = GetTemplateChild(vVK.ssH(20796)) as DockGuideInnerTop;
		c8s = GetTemplateChild(vVK.ssH(20844)) as DockGuideOuterBottom;
		t8q = GetTemplateChild(vVK.ssH(20898)) as DockGuideOuterLeft;
		h8F = GetTemplateChild(vVK.ssH(20948)) as DockGuideOuterRight;
		h8V = GetTemplateChild(vVK.ssH(21000)) as DockGuideOuterTop;
		n8v();
	}

	internal static bool s8T()
	{
		return g8b == null;
	}

	internal static DockGuideCross I8x()
	{
		return g8b;
	}
}
