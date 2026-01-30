using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace ActiproSoftware.Internal;

internal class a3 : gf
{
	private int KOQ;

	private int hOV;

	private int iOC;

	private string dO6;

	private static a3 SaN;

	public int Length => KOQ;

	public int Offset
	{
		get
		{
			return hOV;
		}
		set
		{
			while (hOV < num)
			{
				hkk();
			}
			while (hOV > num)
			{
				Tk1();
			}
		}
	}

	public a3(string P_0)
	{
		awj.QuEwGz();
		this._002Ector(P_0, 0, 0);
	}

	private a3(string P_0, int P_1, int P_2)
	{
		awj.QuEwGz();
		base._002Ector();
		dO6 = P_0;
		hOV = P_1 - P_2;
		KOQ = P_0.Length - P_2;
		iOC = P_2;
	}

	[SuppressMessage("Microsoft.Naming", "CA1725:ParameterNamesShouldMatchBaseDeclaration", MessageId = "0#")]
	[SuppressMessage("Microsoft.Naming", "CA1725:ParameterNamesShouldMatchBaseDeclaration", MessageId = "1#")]
	public string nkw(int P_0, int P_1)
	{
		return dO6.Substring(P_0 + iOC, P_1);
	}

	[SpecialName]
	public bool CkP()
	{
		return hOV >= KOQ;
	}

	[SpecialName]
	public bool OkW()
	{
		return hOV <= -iOC;
	}

	[SpecialName]
	public int qkg()
	{
		return iOC;
	}

	public char gkB()
	{
		if (hOV < KOQ)
		{
			return dO6[hOV + iOC];
		}
		return '\0';
	}

	public char xoz(int P_0)
	{
		if (hOV + P_0 - 1 < KOQ)
		{
			return dO6[hOV + iOC + P_0 - 1];
		}
		return '\0';
	}

	public char MkA()
	{
		if (hOV > -iOC)
		{
			return dO6[hOV + iOC - 1];
		}
		return '\0';
	}

	public char hkk()
	{
		if (hOV < KOQ)
		{
			return dO6[hOV++ + iOC];
		}
		return '\0';
	}

	public char Tk1()
	{
		if (hOV > -iOC)
		{
			return dO6[--hOV + iOC];
		}
		return '\0';
	}

	public override string ToString()
	{
		return dO6;
	}

	internal static bool waL()
	{
		return SaN == null;
	}

	internal static a3 haq()
	{
		return SaN;
	}
}
