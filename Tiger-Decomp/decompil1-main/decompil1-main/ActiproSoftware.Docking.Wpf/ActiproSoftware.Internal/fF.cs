using System;
using System.Runtime.CompilerServices;
using ActiproSoftware.Windows.Controls;
using ActiproSoftware.Windows.Controls.Docking.Primitives;

namespace ActiproSoftware.Internal;

internal class fF
{
	[CompilerGenerated]
	private DockGuideBase WlE;

	[CompilerGenerated]
	private Side? dlr;

	[CompilerGenerated]
	private iy rlx;

	internal static fF FYc;

	public fF(DockGuideBase P_0, iy P_1, Side? P_2)
	{
		IVH.CecNqz();
		base._002Ector();
		if (P_1 == null)
		{
			throw new ArgumentNullException(vVK.ssH(9148));
		}
		blB(P_0);
		el8(P_1);
		lln(P_2);
	}

	[SpecialName]
	[CompilerGenerated]
	public DockGuideBase zlW()
	{
		return WlE;
	}

	[SpecialName]
	[CompilerGenerated]
	private void blB(DockGuideBase P_0)
	{
		WlE = P_0;
	}

	public override bool Equals(object P_0)
	{
		if (!(P_0 is fF fF2))
		{
			return false;
		}
		if (zlW() == fF2.zlW() && UlT() == fF2.UlT())
		{
			return UlJ() == fF2.UlJ();
		}
		return false;
	}

	public override int GetHashCode()
	{
		int num = UlT().GetHashCode();
		if (UlJ().HasValue)
		{
			num ^= UlJ().GetHashCode();
		}
		return num;
	}

	[SpecialName]
	[CompilerGenerated]
	public Side? UlJ()
	{
		return dlr;
	}

	[SpecialName]
	[CompilerGenerated]
	private void lln(Side? P_0)
	{
		dlr = P_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public iy UlT()
	{
		return rlx;
	}

	[SpecialName]
	[CompilerGenerated]
	private void el8(iy P_0)
	{
		rlx = P_0;
	}

	internal static bool fYM()
	{
		return FYc == null;
	}

	internal static fF aYh()
	{
		return FYc;
	}
}
