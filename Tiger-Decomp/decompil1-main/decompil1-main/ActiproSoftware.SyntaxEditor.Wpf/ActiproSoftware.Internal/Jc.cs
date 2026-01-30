using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Outlining;

namespace ActiproSoftware.Internal;

internal class Jc
{
	[Flags]
	private enum m77
	{

	}

	private class q7r
	{
		private m77 FrP;

		private static q7r eH6;

		internal bool SVz(m77 P_0)
		{
			return (FrP & P_0) == P_0;
		}

		internal void xrW(m77 P_0, bool P_1)
		{
			if (!P_1)
			{
				FrP &= ~P_0;
			}
			else
			{
				FrP |= P_0;
			}
		}

		public q7r()
		{
			grA.DaB7cz();
			base._002Ector();
		}

		internal static bool WHK()
		{
			return eH6 == null;
		}

		internal static q7r THC()
		{
			return eH6;
		}
	}

	private List<Jc> Avz;

	private IOutliningNodeDefinition CmW;

	private q7r wmP;

	private int UmE;

	private int Hmc;

	internal static Jc t7A;

	public Jc(IOutliningNodeDefinition P_0)
	{
		grA.DaB7cz();
		wmP = new q7r();
		UmE = -1;
		base._002Ector();
		CmW = P_0;
	}

	[SpecialName]
	public IOutliningNodeDefinition lvr()
	{
		return CmW;
	}

	[SpecialName]
	public IList<Jc> Wvk()
	{
		if (Avz == null)
		{
			Avz = new List<Jc>(1);
		}
		return Avz;
	}

	[SpecialName]
	public bool iv9()
	{
		return Avz != null && Avz.Count > 0;
	}

	[SpecialName]
	public bool Gvq()
	{
		return wmP.SVz((m77)2);
	}

	[SpecialName]
	public void ev2(bool P_0)
	{
		wmP.xrW((m77)2, P_0);
	}

	[SpecialName]
	public bool Hvi()
	{
		return UmE == -1;
	}

	[SpecialName]
	public bool CvM()
	{
		return wmP.SVz((m77)1);
	}

	[SpecialName]
	public void lvO(bool P_0)
	{
		wmP.xrW((m77)1, P_0);
	}

	[SpecialName]
	public int RvJ()
	{
		return UmE;
	}

	[SpecialName]
	public void fvt(int P_0)
	{
		UmE = P_0;
	}

	[SpecialName]
	public int kvh()
	{
		return Hmc;
	}

	[SpecialName]
	public void EvN(int P_0)
	{
		Hmc = P_0;
	}

	public override string ToString()
	{
		return Q7Z.tqM(11716) + CmW.Key + Q7Z.tqM(11764) + Gvq() + Q7Z.tqM(11640);
	}

	internal static bool l7l()
	{
		return t7A == null;
	}

	internal static Jc s7W()
	{
		return t7A;
	}
}
