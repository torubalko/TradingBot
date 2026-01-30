using System;
using System.Runtime.CompilerServices;
using System.Windows;
using ActiproSoftware.Windows.Controls.Docking.Primitives;
using ActiproSoftware.Windows.Extensions;

namespace ActiproSoftware.Internal;

internal class Iu : he
{
	private double? B7W;

	private UIElement t7B;

	private double? M7K;

	private UIElement Q7J;

	private double? W7n;

	private double? c7O;

	private SplitContainerPanel n7T;

	internal static Iu WYg;

	public Iu(SplitContainerPanel P_0, Va P_1, bool P_2, bool P_3)
	{
		IVH.CecNqz();
		base._002Ector(P_1, P_2, P_3);
		if (P_0 == null)
		{
			throw new ArgumentNullException(vVK.ssH(23384));
		}
		n7T = P_0;
		Q7J = P_1.ElementBefore;
		t7B = P_1.ElementAfter;
	}

	[SpecialName]
	private double h7N()
	{
		S71();
		return M7K.Value;
	}

	[SpecialName]
	private double d7m()
	{
		S71();
		return W7n.Value;
	}

	private void S71()
	{
		if (!B7W.HasValue)
		{
			W7n = SplitContainerPanel.GetSlotLength(Q7J);
			M7K = SplitContainerPanel.GetSlotLength(t7B);
			_ = n7l().Orientation;
			wH wH2 = Q7J as wH;
			double slotLength = SplitContainerPanel.GetSlotLength(Q7J);
			double num = 0.0;
			double num2 = double.PositiveInfinity;
			if (wH2 != null)
			{
				num = n7l().GetSizeExtent(wH2.MinSize);
				num2 = n7l().GetSizeExtent(wH2.MaxSize);
			}
			double val = Math.Max(0.0, slotLength - num);
			double val2 = Math.Max(0.0, num2 - slotLength);
			wH wH3 = t7B as wH;
			double slotLength2 = SplitContainerPanel.GetSlotLength(t7B);
			double num3 = 0.0;
			double num4 = double.PositiveInfinity;
			if (wH3 != null)
			{
				num3 = n7l().GetSizeExtent(wH3.MinSize);
				num4 = n7l().GetSizeExtent(wH3.MaxSize);
			}
			double val3 = Math.Max(0.0, slotLength2 - num3);
			double val4 = Math.Max(0.0, num4 - slotLength2);
			B7W = Math.Min(val, val4);
			c7O = Math.Min(val3, val2);
		}
	}

	protected override void rm4(double P_0)
	{
		wH obj = Q7J as wH;
		wH wH2 = t7B as wH;
		if (obj != null && wH2 != null)
		{
			SplitContainerPanel.SetSlotLength(Q7J, d7m() + P_0);
			SplitContainerPanel.SetSlotLength(t7B, h7N() - P_0);
			n7T.nEz();
			n7T.InvalidateMeasure();
			n7T.InvalidateArrange();
		}
	}

	[SpecialName]
	protected override double mms()
	{
		S71();
		return B7W.Value;
	}

	[SpecialName]
	protected override double Jmk()
	{
		S71();
		return c7O.Value;
	}

	[SpecialName]
	public override FrameworkElement Jm0()
	{
		return n7T;
	}

	internal static bool IYi()
	{
		return WYg == null;
	}

	internal static Iu uYZ()
	{
		return WYg;
	}
}
