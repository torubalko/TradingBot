using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using ActiproSoftware.Products.Editors;

namespace ActiproSoftware.Internal;

internal struct YH
{
	private char mYZ;

	private char MYt;

	private static object jaR;

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "ch")]
	public YH(char P_0)
	{
		awj.QuEwGz();
		this = new YH(P_0, P_0);
	}

	public YH(char P_0, char P_1)
	{
		awj.QuEwGz();
		mYZ = P_0;
		MYt = P_1;
	}

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "ch")]
	public bool AYA(char P_0)
	{
		return mYZ <= P_0 && P_0 <= MYt;
	}

	public bool XY3(YH P_0)
	{
		return mYZ <= P_0.mYZ && P_0.MYt <= MYt;
	}

	[SpecialName]
	public int lYS()
	{
		return MYt - mYZ + 1;
	}

	[SpecialName]
	public char rY8()
	{
		return MYt;
	}

	[SpecialName]
	public void UYr(char P_0)
	{
		MYt = P_0;
	}

	public override bool Equals(object P_0)
	{
		int num = 1;
		bool flag = default(bool);
		while (true)
		{
			int num2 = num;
			do
			{
				switch (num2)
				{
				default:
				{
					if (flag)
					{
						return false;
					}
					YH yH = (YH)P_0;
					return mYZ == yH.mYZ && MYt == yH.MYt;
				}
				case 1:
					break;
				}
				flag = !(P_0 is YH);
				num2 = 0;
			}
			while (hai());
		}
	}

	public override int GetHashCode()
	{
		return mYZ ^ MYt;
	}

	public bool EYy(YH P_0)
	{
		return rY8() >= P_0.IYp() && P_0.rY8() >= IYp();
	}

	public YH dYm(YH P_0)
	{
		if (rY8() < P_0.IYp() || P_0.rY8() < IYp())
		{
			throw new ArgumentOutOfRangeException(QdM.AR8(23594), SR.GetString(SRName.ExIntervalsDoNotIntersect));
		}
		return new YH((char)Math.Max(IYp(), P_0.IYp()), (char)Math.Min(rY8(), P_0.rY8()));
	}

	[SpecialName]
	public char IYp()
	{
		return mYZ;
	}

	[SpecialName]
	public void UYW(char P_0)
	{
		mYZ = P_0;
	}

	public override string ToString()
	{
		if (mYZ == MYt)
		{
			if (vO.aoW(mYZ) || mYZ == '-')
			{
				return string.Format(CultureInfo.InvariantCulture, QdM.AR8(23614), new object[1] { mYZ });
			}
			if (mYZ >= '\u0015' && mYZ <= '~')
			{
				return mYZ.ToString();
			}
			return string.Format(CultureInfo.InvariantCulture, QdM.AR8(23626), new object[1] { (int)mYZ });
		}
		string text = ((vO.aoW(mYZ) || mYZ == '-') ? string.Format(CultureInfo.InvariantCulture, QdM.AR8(23614), new object[1] { mYZ }) : ((mYZ < '\u0015' || mYZ > '~') ? string.Format(CultureInfo.InvariantCulture, QdM.AR8(23626), new object[1] { (int)mYZ }) : mYZ.ToString()));
		text += QdM.AR8(2098);
		return (vO.aoW(MYt) || MYt == '-') ? (text + string.Format(CultureInfo.InvariantCulture, QdM.AR8(23614), new object[1] { MYt })) : ((MYt < '\u0015' || MYt > '~') ? (text + string.Format(CultureInfo.InvariantCulture, QdM.AR8(23626), new object[1] { (int)MYt })) : (text + MYt));
	}

	public static bool operator ==(YH P_0, YH P_1)
	{
		return P_0.mYZ == P_1.mYZ && P_0.MYt == P_1.MYt;
	}

	public static bool operator !=(YH P_0, YH P_1)
	{
		return !(P_0 == P_1);
	}

	internal static bool hai()
	{
		return jaR == null;
	}

	internal static object Ka5()
	{
		return jaR;
	}
}
