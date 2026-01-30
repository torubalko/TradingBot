using System;
using System.Globalization;
using ActiproSoftware.Products.Text;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text;

[Serializable]
public struct TextPosition : ICloneable, IComparable
{
	private int IG;

	private bool Ne;

	private int Yy;

	public const int MaxCharacter = int.MaxValue;

	public const int MaxLine = int.MaxValue;

	public static readonly TextPosition Empty;

	public static readonly TextPosition Zero;

	internal static object Tt5;

	public int Character => IG;

	public int DisplayCharacter => IG + 1;

	public int DisplayLine => Yy + 1;

	public bool HasFarAffinity => Ne;

	public bool IsEmpty => Yy == -1 && IG == -1;

	public int Line => Yy;

	public TextPosition(int line, int character, bool hasFarAffinity = false)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		Yy = line;
		IG = character;
		Ne = hasFarAffinity;
	}

	public TextPosition(TextPosition position, bool hasFarAffinity = false)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		Yy = position.Yy;
		IG = position.IG;
		Ne = hasFarAffinity;
	}

	public object Clone()
	{
		return new TextPosition(Yy, IG, Ne);
	}

	public int CompareTo(object obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1366));
		}
		if (!(obj is TextPosition))
		{
			throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, SR.GetString(SRName.ExInvalidParameterType), new object[1] { typeof(TextPosition).FullName }), WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1366));
		}
		return CompareTo((TextPosition)obj);
	}

	public int CompareTo(TextPosition position)
	{
		if (Yy < position.Yy)
		{
			return -1;
		}
		int num2 = default(int);
		while (Yy > position.Yy)
		{
			int num = 0;
			if (htU() != null)
			{
				num = num2;
			}
			switch (num)
			{
			case 1:
				continue;
			}
			return 1;
		}
		if (IG < position.IG)
		{
			return -1;
		}
		if (IG > position.IG)
		{
			return 1;
		}
		return 0;
	}

	public override bool Equals(object obj)
	{
		if (obj == null || !(obj is TextPosition))
		{
			return false;
		}
		TextPosition textPosition = (TextPosition)obj;
		return Yy == textPosition.Yy && IG == textPosition.IG;
	}

	public static TextPosition First(TextPosition position1, TextPosition position2)
	{
		if (position1 <= position2)
		{
			return position1;
		}
		return position2;
	}

	public override int GetHashCode()
	{
		return Yy ^ IG;
	}

	public static TextPosition Last(TextPosition position1, TextPosition position2)
	{
		if (!(position1 <= position2))
		{
			return position1;
		}
		return position2;
	}

	public override string ToString()
	{
		return WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1376) + Yy.ToString(CultureInfo.CurrentCulture) + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1392) + IG.ToString(CultureInfo.CurrentCulture) + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1418);
	}

	public static bool operator ==(TextPosition left, TextPosition right)
	{
		return left.Equals(right);
	}

	public static bool operator !=(TextPosition left, TextPosition right)
	{
		return !(left == right);
	}

	public static bool operator >(TextPosition left, TextPosition right)
	{
		if (left.Yy == right.Yy)
		{
			return left.IG > right.IG;
		}
		return left.Yy > right.Yy;
	}

	public static bool operator >=(TextPosition left, TextPosition right)
	{
		return left == right || left > right;
	}

	public static bool operator <(TextPosition left, TextPosition right)
	{
		if (left.Yy == right.Yy)
		{
			return left.IG < right.IG;
		}
		return left.Yy < right.Yy;
	}

	public static bool operator <=(TextPosition left, TextPosition right)
	{
		return left == right || left < right;
	}

	static TextPosition()
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		Empty = new TextPosition(-1, -1);
		Zero = new TextPosition(0, 0);
	}

	internal static bool btP()
	{
		return Tt5 == null;
	}

	internal static object htU()
	{
		return Tt5;
	}
}
