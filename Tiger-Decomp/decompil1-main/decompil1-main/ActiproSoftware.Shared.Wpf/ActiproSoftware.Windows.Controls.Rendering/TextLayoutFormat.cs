using System.Globalization;
using System.Text;
using dg3ypDAonQcOidMs0w;

namespace ActiproSoftware.Windows.Controls.Rendering;

internal struct TextLayoutFormat
{
	private ulong TI9;

	public const int UndefinedBrushIndex = -1;

	internal static object GnB;

	public int FontFamilyIndex
	{
		get
		{
			return (int)((TI9 >> 12) & 0xFF);
		}
		set
		{
			ushort num = (ushort)(((ulong)value <= 255uL) ? ((uint)value) : 0u);
			ulong num2 = ((ulong)num & 0xFFuL) << 12;
			ulong num3 = 1044480uL;
			TI9 = (~num3 & TI9) | num2;
		}
	}

	public int FontSizeIndex
	{
		get
		{
			return (int)((TI9 >> 20) & 0xFF);
		}
		set
		{
			ushort num = (ushort)(((ulong)value <= 255uL) ? ((uint)value) : 0u);
			ulong num2 = ((ulong)num & 0xFFuL) << 20;
			ulong num3 = 267386880uL;
			TI9 = (~num3 & TI9) | num2;
		}
	}

	public int ForegroundIndex
	{
		get
		{
			return (int)(TI9 & 0xFFF);
		}
		set
		{
			ushort num = (ushort)(((ulong)value <= 4095uL) ? ((uint)value) : 0u);
			ulong num2 = (ulong)num & 0xFFFuL;
			ulong num3 = 4095uL;
			TI9 = (~num3 & TI9) | num2;
		}
	}

	public bool IsBold
	{
		get
		{
			return (TI9 & 0x80000000u) == 2147483648u;
		}
		set
		{
			if (!value)
			{
				TI9 &= 18446744071562067967uL;
			}
			else
			{
				TI9 |= 2147483648uL;
			}
		}
	}

	public bool IsItalic
	{
		get
		{
			return (TI9 & 0x40000000) == 1073741824;
		}
		set
		{
			if (value)
			{
				TI9 |= 1073741824uL;
			}
			else
			{
				TI9 &= 18446744072635809791uL;
			}
		}
	}

	public bool IsSpacer
	{
		get
		{
			return (TI9 & 0x20000000) == 536870912;
		}
		set
		{
			if (!value)
			{
				TI9 &= 18446744073172680703uL;
			}
			else
			{
				TI9 |= 536870912uL;
			}
		}
	}

	public int StrikethroughBrushIndex
	{
		get
		{
			return (int)((TI9 >> 48) & 0xFFF) - 1;
		}
		set
		{
			value++;
			ushort num = (ushort)(((ulong)value <= 4095uL) ? ((uint)value) : 0u);
			ulong num2 = ((ulong)num & 0xFFFuL) << 48;
			ulong num3 = 1152640029630136320uL;
			TI9 = (~num3 & TI9) | num2;
		}
	}

	public LineKind StrikethroughKind
	{
		get
		{
			return (LineKind)((TI9 >> 60) & 7);
		}
		set
		{
			byte b = (byte)(((ulong)value <= 7uL) ? value : LineKind.None);
			ulong num = ((ulong)b & 7uL) << 60;
			ulong num2 = 8070450532247928832uL;
			TI9 = (~num2 & TI9) | num;
		}
	}

	public TextLineWeight StrikethroughWeight
	{
		get
		{
			return ((TI9 & 0x8000000000000000uL) == 9223372036854775808uL) ? TextLineWeight.Double : TextLineWeight.Single;
		}
		set
		{
			if (value == TextLineWeight.Double)
			{
				TI9 |= 9223372036854775808uL;
			}
			else
			{
				TI9 &= 9223372036854775807uL;
			}
		}
	}

	public int UnderlineBrushIndex
	{
		get
		{
			return (int)((TI9 >> 32) & 0xFFF) - 1;
		}
		set
		{
			value++;
			ushort num = (ushort)(((ulong)value <= 4095uL) ? ((uint)value) : 0u);
			ulong num2 = ((ulong)num & 0xFFFuL) << 32;
			ulong num3 = 17587891077120uL;
			TI9 = (~num3 & TI9) | num2;
		}
	}

	public LineKind UnderlineKind
	{
		get
		{
			return (LineKind)((TI9 >> 44) & 7);
		}
		set
		{
			byte b = (byte)(((ulong)value <= 7uL) ? value : LineKind.None);
			ulong num = ((ulong)b & 7uL) << 44;
			ulong num2 = 123145302310912uL;
			TI9 = (~num2 & TI9) | num;
		}
	}

	public TextLineWeight UnderlineWeight
	{
		get
		{
			return ((TI9 & 0x800000000000L) == 140737488355328L) ? TextLineWeight.Double : TextLineWeight.Single;
		}
		set
		{
			if (value != TextLineWeight.Double)
			{
				TI9 &= 18446603336221196287uL;
			}
			else
			{
				TI9 |= 140737488355328uL;
			}
		}
	}

	public TextLayoutFormat Clone()
	{
		return new TextLayoutFormat
		{
			TI9 = TI9
		};
	}

	public override bool Equals(object obj)
	{
		if (obj is TextLayoutFormat)
		{
			return TI9 == ((TextLayoutFormat)obj).TI9;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return TI9.GetHashCode();
	}

	public TextLayoutFormat ToFontDataOnlyFormat()
	{
		return new TextLayoutFormat
		{
			TI9 = (TI9 & 0xEFFFF000u)
		};
	}

	public override string ToString()
	{
		bool flag = true;
		StringBuilder stringBuilder = new StringBuilder(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(117366));
		if (ForegroundIndex > 0)
		{
			if (!flag)
			{
				stringBuilder.Append(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(117404));
			}
			flag = false;
			stringBuilder.AppendFormat(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(117412), ForegroundIndex);
		}
		if (FontFamilyIndex > 0)
		{
			if (!flag)
			{
				stringBuilder.Append(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(117404));
			}
			flag = false;
			stringBuilder.AppendFormat(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(117454), FontFamilyIndex);
		}
		if (FontSizeIndex > 0)
		{
			if (!flag)
			{
				stringBuilder.Append(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(117404));
			}
			flag = false;
			stringBuilder.AppendFormat(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(117496), FontSizeIndex);
		}
		if (IsBold)
		{
			if (!flag)
			{
				stringBuilder.Append(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(117404));
			}
			flag = false;
			stringBuilder.Append(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(117534));
		}
		if (IsItalic)
		{
			if (!flag)
			{
				stringBuilder.Append(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(117404));
			}
			flag = false;
			stringBuilder.Append(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(117546));
		}
		if (StrikethroughKind != LineKind.None)
		{
			if (!flag)
			{
				stringBuilder.Append(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(117404));
			}
			flag = false;
			stringBuilder.AppendFormat(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(117562), StrikethroughKind, StrikethroughWeight, StrikethroughBrushIndex);
		}
		if (UnderlineKind != LineKind.None)
		{
			if (!flag)
			{
				stringBuilder.Append(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(117404));
			}
			flag = false;
			stringBuilder.AppendFormat(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(117640), UnderlineKind, UnderlineWeight, UnderlineBrushIndex);
		}
		if (IsSpacer)
		{
			if (!flag)
			{
				stringBuilder.Append(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(117404));
			}
			flag = false;
			stringBuilder.Append(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(117710));
		}
		if (flag)
		{
			stringBuilder.Append(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(117726));
		}
		stringBuilder.Append(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(117750));
		stringBuilder.Append(TI9.ToString(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(117762), CultureInfo.InvariantCulture));
		return stringBuilder.ToString();
	}

	public static bool operator ==(TextLayoutFormat left, TextLayoutFormat right)
	{
		return left.Equals(right);
	}

	public static bool operator !=(TextLayoutFormat left, TextLayoutFormat right)
	{
		return !left.Equals(right);
	}

	internal static bool TnA()
	{
		return GnB == null;
	}

	internal static object TnV()
	{
		return GnB;
	}
}
