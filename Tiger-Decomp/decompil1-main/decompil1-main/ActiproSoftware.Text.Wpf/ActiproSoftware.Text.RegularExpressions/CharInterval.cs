using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using ActiproSoftware.Products.Text;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.RegularExpressions;

public struct CharInterval
{
	private char kuU;

	private char Jua;

	internal static object kVz;

	public int Count => Jua - kuU + 1;

	public char End
	{
		get
		{
			return Jua;
		}
		set
		{
			Jua = value;
		}
	}

	public char Start
	{
		get
		{
			return kuU;
		}
		set
		{
			kuU = value;
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "ch")]
	public CharInterval(char ch)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		this = new CharInterval(ch, ch);
	}

	public CharInterval(char start, char end)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		kuU = start;
		Jua = end;
	}

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "ch")]
	public bool Contains(char ch)
	{
		return kuU <= ch && ch <= Jua;
	}

	public bool Contains(CharInterval interval)
	{
		return kuU <= interval.kuU && interval.Jua <= Jua;
	}

	public override bool Equals(object obj)
	{
		if (!(obj is CharInterval charInterval))
		{
			return false;
		}
		return kuU == charInterval.kuU && Jua == charInterval.Jua;
	}

	public override int GetHashCode()
	{
		return kuU ^ Jua;
	}

	public bool IntersectsWith(CharInterval interval)
	{
		return End >= interval.Start && interval.End >= Start;
	}

	public CharInterval GetIntersection(CharInterval interval)
	{
		if (End < interval.Start || interval.End < Start)
		{
			throw new ArgumentOutOfRangeException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7020), SR.GetString(SRName.ExIntervalsDoNotIntersect));
		}
		return new CharInterval((char)Math.Max(Start, interval.Start), (char)Math.Min(End, interval.End));
	}

	public override string ToString()
	{
		if (kuU == Jua)
		{
			if (RegexHelper.IsPatternSpecialChar(kuU) || kuU == '-')
			{
				return string.Format(CultureInfo.InvariantCulture, WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7040), new object[1] { kuU });
			}
			if (kuU >= '\u0015' && kuU <= '~')
			{
				return kuU.ToString();
			}
			return string.Format(CultureInfo.InvariantCulture, WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7052), new object[1] { (int)kuU });
		}
		string text = ((RegexHelper.IsPatternSpecialChar(kuU) || kuU == '-') ? string.Format(CultureInfo.InvariantCulture, WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7040), new object[1] { kuU }) : ((kuU < '\u0015' || kuU > '~') ? string.Format(CultureInfo.InvariantCulture, WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7052), new object[1] { (int)kuU }) : kuU.ToString()));
		text += WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7072);
		return (RegexHelper.IsPatternSpecialChar(Jua) || Jua == '-') ? (text + string.Format(CultureInfo.InvariantCulture, WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7040), new object[1] { Jua })) : ((Jua < '\u0015' || Jua > '~') ? (text + string.Format(CultureInfo.InvariantCulture, WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7052), new object[1] { (int)Jua })) : (text + Jua));
	}

	public static bool operator ==(CharInterval left, CharInterval right)
	{
		return left.kuU == right.kuU && left.Jua == right.Jua;
	}

	public static bool operator !=(CharInterval left, CharInterval right)
	{
		return !(left == right);
	}

	internal static bool xbd()
	{
		return kVz == null;
	}

	internal static object gbi()
	{
		return kVz;
	}
}
