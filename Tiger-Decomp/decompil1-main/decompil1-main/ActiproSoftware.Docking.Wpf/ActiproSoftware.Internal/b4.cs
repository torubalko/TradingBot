using System;
using System.Runtime.CompilerServices;

namespace ActiproSoftware.Internal;

internal class b4<Gs> where Gs : class, lX
{
	[CompilerGenerated]
	private int Nxq;

	[CompilerGenerated]
	private Gs ExF;

	[CompilerGenerated]
	private lX WxV;

	private static object kA2;

	public b4(int P_0, lX P_1, Gs hf)
	{
		IVH.CecNqz();
		base._002Ector();
		if (P_1 == null)
		{
			throw new ArgumentNullException(vVK.ssH(22928));
		}
		if (hf == null)
		{
			throw new ArgumentNullException(vVK.ssH(22952));
		}
		kxS(P_0);
		Hxp(P_1);
		px6(hf);
	}

	[SpecialName]
	[CompilerGenerated]
	public int OxR()
	{
		return Nxq;
	}

	[SpecialName]
	[CompilerGenerated]
	private void kxS(int P_0)
	{
		Nxq = P_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public Gs dx3()
	{
		return ExF;
	}

	[SpecialName]
	[CompilerGenerated]
	private void px6(Gs XQ)
	{
		ExF = XQ;
	}

	[SpecialName]
	[CompilerGenerated]
	public lX nxY()
	{
		return WxV;
	}

	[SpecialName]
	[CompilerGenerated]
	private void Hxp(lX P_0)
	{
		WxV = P_0;
	}

	internal static bool gA6()
	{
		return kA2 == null;
	}

	internal static object pAW()
	{
		return kA2;
	}
}
