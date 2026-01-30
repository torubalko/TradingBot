using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using BXtLF4GvnJ9TtDSoIul7;
using fZl77HkDbCF2hZri4dVV;
using H59IbFkNkUTQB7uIfts0;
using HUGc1iGvL73jwyqCtN04;
using kvtsvxkNBA3S7tECx5XS;

namespace TigerTrade.Dx;

public sealed class XFont
{
	private static readonly HashSet<string> FontsHashSet;

	private static readonly HashSet<string> _internalFonts;

	private static readonly Dictionary<string, GnvxFqGvxtP2TADa1T12> GlyphTypefaces;

	private static readonly Dictionary<string, Dictionary<string, Size>> TextSizeCache;

	private readonly Dictionary<string, Size> sizeCache;

	private readonly double _textHeight;

	private readonly double _sizePx;

	private readonly double _space;

	internal static XFont r7rsvXkEdXBU2E1l2aRX;

	public static IEnumerable<string> SortedFonts => KQjLWWGv9T0awfEPv2fW.wRWGvNkVkDn.Fonts;

	public string Name { get; }

	public int Size { get; }

	public bool Bold { get; }

	public string UniquID { get; }

	internal GnvxFqGvxtP2TADa1T12 Typeface { get; }

	public XFont()
	{
		t8OeS3kE6k4ovvrW8Wdd();
		this._002Ector(vpHjm6kDDRWPs2gcoFH7.bKykDIaot93(-1306877528 ^ -1306876282), 14.0, bold: false);
	}

	public XFont(bool bold)
	{
		qenpj1kNvArYd94Dp3W2.xFYkW4O7C9a();
		this._002Ector((string)aC8Lj2kEM9wV5C8hXBGI(-90307782 ^ -90307564), 14.0, bold);
	}

	public XFont(string fontName, double size)
	{
		qenpj1kNvArYd94Dp3W2.xFYkW4O7C9a();
		this._002Ector(fontName, size, bold: false);
	}

	public XFont(string fontName, double size, bool bold)
	{
		qenpj1kNvArYd94Dp3W2.xFYkW4O7C9a();
		sizeCache = new Dictionary<string, Size>();
		base._002Ector();
		int num = 5;
		if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_9dc87266080545b1b4e0ed15ee567184 != 0)
		{
			num = 5;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				Bold = bold;
				UniquID = string.Intern((string)oQmWMskEOo6myZmjOHWe(vpHjm6kDDRWPs2gcoFH7.bKykDIaot93(0x1487846E ^ 0x14878352), Name, Size, Bold));
				num = 3;
				if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_90af539e848d4c66b5ac1596d8ba32ec != 0)
				{
					num = 4;
				}
				break;
			case 4:
				Typeface = GetGlyphTypeface();
				_textHeight = GetTextHeight();
				_sizePx = _textHeight / Typeface.wJRGvcBt7jF() - 0.2;
				num = 1;
				if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_ded015a90dce459db73af52f540d8af2 == 0)
				{
					num = 0;
				}
				break;
			case 3:
			{
				if (!TextSizeCache.TryGetValue(UniquID, out var value))
				{
					TextSizeCache.Add(UniquID, value = new Dictionary<string, Size>());
				}
				return;
			}
			default:
				Size = (int)Math.Ceiling(Math.Max(size, 1.0));
				num = 2;
				break;
			case 5:
				Name = fontName;
				num = 0;
				if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_80f73fd0542d40589be6ac0a306f5ee4 == 0)
				{
					num = 0;
				}
				break;
			case 1:
			{
				_space = (Bold ? 1 : 0);
				int num2 = 3;
				num = num2;
				break;
			}
			}
		}
	}

	public double GetHeight()
	{
		return _textHeight;
	}

	public double GetWidth(string text)
	{
		return GetSize(text).Width;
	}

	public Size GetSize(string text)
	{
		if (!string.IsNullOrEmpty(text))
		{
			return GetTextSize(text);
		}
		return new Size(0.0, GetHeight());
	}

	public override string ToString()
	{
		return string.Format(vpHjm6kDDRWPs2gcoFH7.bKykDIaot93(-82860344 ^ -82861666), Name, Size);
	}

	public static FontFamily GetFont(string fontName)
	{
		if (_internalFonts.Contains(fontName))
		{
			return new FontFamily(new Uri(vpHjm6kDDRWPs2gcoFH7.bKykDIaot93(-45476899 ^ -45476681)), (string)aC8Lj2kEM9wV5C8hXBGI(-1799510641 ^ -1799511533) + fontName);
		}
		fontName = (string)Swel1PkEqHYwYbEq7u0N(fontName);
		int num = 0;
		if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_37442e8fbe0a4d0b81152928e1eb527c != 0)
		{
			num = 0;
		}
		switch (num)
		{
		default:
			if (_internalFonts.Contains(fontName))
			{
				return new FontFamily(new Uri(vpHjm6kDDRWPs2gcoFH7.bKykDIaot93(-2063361985 ^ -2063360171)), vpHjm6kDDRWPs2gcoFH7.bKykDIaot93(0x22BF43FC ^ 0x22BF4460) + fontName);
			}
			return new FontFamily((string)Swel1PkEqHYwYbEq7u0N(fontName));
		}
	}

	public static string GetFontName(FontFamily fontFamily)
	{
		if (fontFamily == null)
		{
			return vpHjm6kDDRWPs2gcoFH7.bKykDIaot93(-1380525184 ^ -1380524882);
		}
		return CorrectFont(fontFamily.Source.Replace(vpHjm6kDDRWPs2gcoFH7.bKykDIaot93(-1736566656 ^ -1736564964), ""));
	}

	internal static string CorrectFont(string fontName)
	{
		if (!FontsHashSet.Contains(fontName))
		{
			return vpHjm6kDDRWPs2gcoFH7.bKykDIaot93(0x37B74BDF ^ 0x37B74CF1);
		}
		return fontName;
	}

	private Size GetTextSize(string text)
	{
		int num = 3;
		int num2 = num;
		Size value = default(Size);
		double num3 = default(double);
		int num4 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (sizeCache.TryGetValue(text, out value))
				{
					num2 = 2;
					if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_dd9d08d16b46492585868817bd5b329f != 0)
					{
						num2 = 1;
					}
					break;
				}
				if (Typeface == null)
				{
					return default(Size);
				}
				num3 = 0.0;
				num4 = 0;
				num2 = 0;
				if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_a37a4622ccdb43ca9169ef0d80d56ae1 != 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				num3 += Typeface.zqTGvsga18W(text[num4]) * _sizePx + _space;
				num4++;
				goto case 1;
			default:
			{
				Size size = new Size(Math.Ceiling(num3), Math.Ceiling(_textHeight));
				sizeCache.Add(text, size);
				return size;
			}
			case 1:
				if (num4 >= F5usa7kEIes3PCLJH9pJ(text))
				{
					num2 = 0;
					if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_80f73fd0542d40589be6ac0a306f5ee4 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 4;
			case 2:
				return value;
			}
		}
	}

	private double GetTextHeight()
	{
		if (Typeface != null)
		{
			return Math.Ceiling(FXWIRAkEWbrWKLe0VI4N(Typeface) * (double)Size);
		}
		return 1.0;
	}

	private GnvxFqGvxtP2TADa1T12 GetGlyphTypeface()
	{
		if (GlyphTypefaces.TryGetValue(UniquID, out var value))
		{
			return value;
		}
		if (new Typeface(GetFont(Name), FontStyles.Normal, Bold ? FontWeights.Bold : FontWeights.Normal, Vfbhe6kEt2GngirdAR9y()).TryGetGlyphTypeface(out var glyphTypeface))
		{
			value = new GnvxFqGvxtP2TADa1T12(glyphTypeface);
			int num = 0;
			if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_ddce9f0563524ee592adad7a07e5ceaf == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			GlyphTypefaces.Add(UniquID, value);
		}
		return value;
	}

	static XFont()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				_internalFonts = new HashSet<string>
				{
					vpHjm6kDDRWPs2gcoFH7.bKykDIaot93(0x11D1040B ^ 0x11D10325),
					vpHjm6kDDRWPs2gcoFH7.bKykDIaot93(-2108526692 ^ -2108528574),
					(string)aC8Lj2kEM9wV5C8hXBGI(0x2BD86B18 ^ 0x2BD86CF6)
				};
				GlyphTypefaces = new Dictionary<string, GnvxFqGvxtP2TADa1T12>();
				num2 = 3;
				if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_e8d7b488a32d4c69b9cf5d320391d7ff != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				vpHjm6kDDRWPs2gcoFH7.YVLkDdJnH9g();
				num2 = 0;
				if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_c2e150130d354ba88208e31c0cb582bd == 0)
				{
					num2 = 0;
				}
				break;
			default:
				P6syMqkNNLI24Cmarav7.kLjw4iIsCLsZtxc4lksN0j();
				t8OeS3kE6k4ovvrW8Wdd();
				FontsHashSet = new HashSet<string>(SortedFonts);
				num2 = 1;
				if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_96140636b3f14f3d80555da48eaec1f2 != 0)
				{
					num2 = 2;
				}
				break;
			case 3:
				TextSizeCache = new Dictionary<string, Dictionary<string, Size>>();
				return;
			}
		}
	}

	internal static void t8OeS3kE6k4ovvrW8Wdd()
	{
		qenpj1kNvArYd94Dp3W2.xFYkW4O7C9a();
	}

	internal static bool eoLVC5kEgE52u7eTYtrp()
	{
		return r7rsvXkEdXBU2E1l2aRX == null;
	}

	internal static XFont MxKf3rkERKpBOMScPkiO()
	{
		return r7rsvXkEdXBU2E1l2aRX;
	}

	internal static object aC8Lj2kEM9wV5C8hXBGI(int P_0)
	{
		return vpHjm6kDDRWPs2gcoFH7.bKykDIaot93(P_0);
	}

	internal static object oQmWMskEOo6myZmjOHWe(object P_0, object P_1, object P_2, object P_3)
	{
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	internal static object Swel1PkEqHYwYbEq7u0N(object P_0)
	{
		return CorrectFont((string)P_0);
	}

	internal static int F5usa7kEIes3PCLJH9pJ(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static double FXWIRAkEWbrWKLe0VI4N(object P_0)
	{
		return ((GnvxFqGvxtP2TADa1T12)P_0).wJRGvcBt7jF();
	}

	internal static FontStretch Vfbhe6kEt2GngirdAR9y()
	{
		return FontStretches.Normal;
	}
}
