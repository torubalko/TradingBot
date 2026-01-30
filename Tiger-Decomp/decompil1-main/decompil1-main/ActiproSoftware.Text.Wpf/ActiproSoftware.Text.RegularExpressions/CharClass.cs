using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Text;
using ActiproSoftware.Products.Text;
using ActiproSoftware.Text.Utility;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.RegularExpressions;

[SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
public class CharClass : ICollection<CharInterval>, IEnumerable<CharInterval>, IEnumerable
{
	[Flags]
	private enum nO
	{

	}

	private class Bl
	{
		private nO HqX;

		internal static Bl nf0;

		public Bl()
		{
			hHEYokUTtehNq5ji0d.BN1hJz();
			base._002Ector();
		}

		internal bool pq3(nO P_0)
		{
			return (HqX & P_0) == P_0;
		}

		internal void jqJ(nO P_0, bool P_1)
		{
			if (!P_1)
			{
				HqX &= ~P_0;
			}
			else
			{
				HqX |= P_0;
			}
		}

		internal static bool KfN()
		{
			return nf0 == null;
		}

		internal static Bl Tfr()
		{
			return nf0;
		}
	}

	private uint FuH;

	private uint MuP;

	private Bl Dup;

	private List<CharInterval> kub;

	private static ActiproSoftware.Text.Utility.Lazy<Dictionary<string, UnicodeCategory[]>> HuC;

	internal static CharClass LVm;

	public static CharClass All => new CharClass('\0', '\uffff');

	public static CharClass Alpha
	{
		get
		{
			CharClass charClass = new CharClass();
			charClass.MuP = 31u;
			charClass.FuH = 31u;
			return charClass;
		}
	}

	public static CharClass Digit
	{
		get
		{
			CharClass charClass = new CharClass();
			charClass.MuP = 256u;
			charClass.FuH = 256u;
			return charClass;
		}
	}

	public static CharClass HexDigit
	{
		get
		{
			CharClass charClass = new CharClass();
			charClass.Add('0', '9');
			charClass.Add('a', 'f');
			charClass.Add('A', 'F');
			return charClass;
		}
	}

	public static CharClass LineTerminator
	{
		get
		{
			CharClass charClass = new CharClass();
			charClass.Add('\n');
			charClass.Add('\r');
			charClass.Add('\u2028');
			charClass.Add('\u2029');
			return charClass;
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "Whitespace")]
	public static CharClass LineTerminatorWhitespace
	{
		get
		{
			CharClass charClass = new CharClass();
			charClass.Add('\f');
			charClass.Add('\n');
			charClass.Add('\r');
			int num = 1;
			if (LVB() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					charClass.Add('\t');
					charClass.Add('\v');
					charClass.Add('\u0085');
					charClass.Add(' ');
					charClass.Add('\u00a0');
					charClass.Add('\u1680');
					charClass.Add('\u2000', '\u2009');
					charClass.Add('\u202f');
					num = 0;
					if (LVB() == null)
					{
						num = 0;
					}
					break;
				default:
					charClass.Add('\u205f');
					charClass.Add('\u3000');
					charClass.Add('\u2028');
					charClass.Add('\u2029');
					return charClass;
				}
			}
		}
	}

	public static CharClass NonAlpha
	{
		get
		{
			CharClass alpha = Alpha;
			alpha.IsNegated = true;
			return alpha;
		}
	}

	public static CharClass NonDigit
	{
		get
		{
			CharClass digit = Digit;
			digit.IsNegated = true;
			return digit;
		}
	}

	public static CharClass None => new CharClass();

	public static CharClass NonHexDigit
	{
		get
		{
			CharClass hexDigit = HexDigit;
			hexDigit.IsNegated = true;
			return hexDigit;
		}
	}

	public static CharClass NonLineTerminator
	{
		get
		{
			CharClass lineTerminator = LineTerminator;
			lineTerminator.IsNegated = true;
			return lineTerminator;
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "Whitespace")]
	public static CharClass NonLineTerminatorWhitespace
	{
		get
		{
			CharClass lineTerminatorWhitespace = LineTerminatorWhitespace;
			lineTerminatorWhitespace.IsNegated = true;
			return lineTerminatorWhitespace;
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "Whitespace")]
	public static CharClass NonWhitespace
	{
		get
		{
			CharClass whitespace = Whitespace;
			whitespace.IsNegated = true;
			return whitespace;
		}
	}

	public static CharClass NonWord
	{
		get
		{
			CharClass word = Word;
			word.IsNegated = true;
			return word;
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "Whitespace")]
	public static CharClass Whitespace
	{
		get
		{
			CharClass charClass = new CharClass();
			charClass.Add('\f');
			charClass.Add('\t');
			charClass.Add('\v');
			charClass.Add('\u0085');
			charClass.Add(' ');
			charClass.Add('\u00a0');
			charClass.Add('\u1680');
			charClass.Add('\u2000', '\u2009');
			charClass.Add('\u202f');
			charClass.Add('\u205f');
			int num = 0;
			if (LVB() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			default:
				charClass.Add('\u3000');
				return charClass;
			}
		}
	}

	public static CharClass Word
	{
		get
		{
			CharClass charClass = new CharClass();
			charClass.MuP = 262431u;
			charClass.FuH = 262431u;
			return charClass;
		}
	}

	public int CharacterCount
	{
		get
		{
			int num = 0;
			using (IEnumerator<CharInterval> enumerator = GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					num += enumerator.Current.Count;
				}
			}
			return num;
		}
	}

	public int Count => kub.Count;

	public bool HasCategorySpecification => MuP != 0;

	public bool IsNegated
	{
		get
		{
			return Dup.pq3((nO)2);
		}
		set
		{
			Dup.jqJ((nO)2, value);
		}
	}

	public bool IsReadOnly => false;

	public bool IsSingleCharacter
	{
		get
		{
			if (kub.Count != 1 || MuP != 0)
			{
				return false;
			}
			return kub[0].Start == kub[0].End;
		}
	}

	public CharInterval this[int index] => kub[index];

	public CharClass()
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		Dup = new Bl();
		kub = new List<CharInterval>();
		base._002Ector();
	}

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "ch")]
	public CharClass(char ch)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		this._002Ector();
		Add(ch);
	}

	public CharClass(string characters)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		this._002Ector();
		bool flag = !string.IsNullOrEmpty(characters);
		int num = 0;
		if (1 == 0)
		{
			int num2;
			num = num2;
		}
		switch (num)
		{
		}
		if (flag)
		{
			foreach (char ch in characters)
			{
				Add(ch);
			}
		}
	}

	public CharClass(CharInterval[] intervals)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		this._002Ector();
		AddRange(intervals);
	}

	public CharClass(CharClass charClass)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		this._002Ector();
		AddRange(charClass);
	}

	public CharClass(char start, char end)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		this._002Ector();
		Add(start, end);
	}

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "ch")]
	public CharClass(char ch, bool isNegated)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		this._002Ector(ch);
		IsNegated = isNegated;
	}

	public CharClass(char start, char end, bool isNegated)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		this._002Ector(start, end);
		IsNegated = isNegated;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return kub.GetEnumerator();
	}

	internal bool CanMergeWith(CharClass charClass)
	{
		if (charClass == null)
		{
			return false;
		}
		if (IsNegated || charClass.IsNegated)
		{
			return false;
		}
		if (MuP == 0 && Count == 0)
		{
			return true;
		}
		if (charClass.MuP == 0 && charClass.Count == 0)
		{
			return true;
		}
		return (MuP == 0 || MuP == (FuH & MuP)) && (charClass.MuP == 0 || charClass.MuP == (charClass.FuH & charClass.MuP));
	}

	private static Dictionary<string, UnicodeCategory[]> fus()
	{
		Dictionary<string, UnicodeCategory[]> dictionary = new Dictionary<string, UnicodeCategory[]>();
		dictionary[WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6638)] = new UnicodeCategory[1] { UnicodeCategory.Control };
		dictionary[WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6646)] = new UnicodeCategory[1] { UnicodeCategory.Format };
		dictionary[WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6654)] = new UnicodeCategory[1] { UnicodeCategory.OtherNotAssigned };
		dictionary[WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6662)] = new UnicodeCategory[1] { UnicodeCategory.PrivateUse };
		dictionary[WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6670)] = new UnicodeCategory[1] { UnicodeCategory.Surrogate };
		dictionary[WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6678)] = new UnicodeCategory[5]
		{
			UnicodeCategory.Control,
			UnicodeCategory.Format,
			UnicodeCategory.OtherNotAssigned,
			UnicodeCategory.PrivateUse,
			UnicodeCategory.Surrogate
		};
		dictionary[WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6684)] = new UnicodeCategory[1] { UnicodeCategory.LowercaseLetter };
		dictionary[WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6692)] = new UnicodeCategory[1] { UnicodeCategory.ModifierLetter };
		dictionary[WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6700)] = new UnicodeCategory[1] { UnicodeCategory.OtherLetter };
		dictionary[WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6708)] = new UnicodeCategory[1] { UnicodeCategory.TitlecaseLetter };
		dictionary[WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6716)] = new UnicodeCategory[1];
		dictionary[WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6724)] = new UnicodeCategory[5]
		{
			UnicodeCategory.LowercaseLetter,
			UnicodeCategory.ModifierLetter,
			UnicodeCategory.OtherLetter,
			UnicodeCategory.TitlecaseLetter,
			UnicodeCategory.UppercaseLetter
		};
		dictionary[WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6730)] = new UnicodeCategory[1] { UnicodeCategory.SpacingCombiningMark };
		dictionary[WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6738)] = new UnicodeCategory[1] { UnicodeCategory.EnclosingMark };
		dictionary[WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6746)] = new UnicodeCategory[1] { UnicodeCategory.NonSpacingMark };
		dictionary[WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6754)] = new UnicodeCategory[3]
		{
			UnicodeCategory.SpacingCombiningMark,
			UnicodeCategory.EnclosingMark,
			UnicodeCategory.NonSpacingMark
		};
		dictionary[WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6760)] = new UnicodeCategory[1] { UnicodeCategory.DecimalDigitNumber };
		dictionary[WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6768)] = new UnicodeCategory[1] { UnicodeCategory.LetterNumber };
		dictionary[WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6776)] = new UnicodeCategory[1] { UnicodeCategory.OtherNumber };
		dictionary[WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6784)] = new UnicodeCategory[3]
		{
			UnicodeCategory.DecimalDigitNumber,
			UnicodeCategory.LetterNumber,
			UnicodeCategory.OtherNumber
		};
		dictionary[WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6790)] = new UnicodeCategory[1] { UnicodeCategory.ConnectorPunctuation };
		dictionary[WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6798)] = new UnicodeCategory[1] { UnicodeCategory.DashPunctuation };
		dictionary[WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6806)] = new UnicodeCategory[1] { UnicodeCategory.ClosePunctuation };
		dictionary[WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6814)] = new UnicodeCategory[1] { UnicodeCategory.FinalQuotePunctuation };
		dictionary[WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6822)] = new UnicodeCategory[1] { UnicodeCategory.InitialQuotePunctuation };
		dictionary[WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6830)] = new UnicodeCategory[1] { UnicodeCategory.OtherPunctuation };
		dictionary[WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6838)] = new UnicodeCategory[1] { UnicodeCategory.OpenPunctuation };
		dictionary[WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6846)] = new UnicodeCategory[7]
		{
			UnicodeCategory.ConnectorPunctuation,
			UnicodeCategory.DashPunctuation,
			UnicodeCategory.ClosePunctuation,
			UnicodeCategory.FinalQuotePunctuation,
			UnicodeCategory.InitialQuotePunctuation,
			UnicodeCategory.OtherPunctuation,
			UnicodeCategory.OpenPunctuation
		};
		dictionary[WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6852)] = new UnicodeCategory[1] { UnicodeCategory.CurrencySymbol };
		dictionary[WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6860)] = new UnicodeCategory[1] { UnicodeCategory.ModifierSymbol };
		dictionary[WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6868)] = new UnicodeCategory[1] { UnicodeCategory.MathSymbol };
		dictionary[WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6876)] = new UnicodeCategory[1] { UnicodeCategory.OtherSymbol };
		dictionary[WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6884)] = new UnicodeCategory[4]
		{
			UnicodeCategory.CurrencySymbol,
			UnicodeCategory.ModifierSymbol,
			UnicodeCategory.MathSymbol,
			UnicodeCategory.OtherSymbol
		};
		dictionary[WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6890)] = new UnicodeCategory[1] { UnicodeCategory.LineSeparator };
		dictionary[WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6898)] = new UnicodeCategory[1] { UnicodeCategory.ParagraphSeparator };
		dictionary[WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6906)] = new UnicodeCategory[1] { UnicodeCategory.SpaceSeparator };
		dictionary[WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6914)] = new UnicodeCategory[3]
		{
			UnicodeCategory.LineSeparator,
			UnicodeCategory.ParagraphSeparator,
			UnicodeCategory.SpaceSeparator
		};
		return dictionary;
	}

	private CharClass WuI()
	{
		CharClass charClass = new CharClass();
		if (kub.Count > 0)
		{
			int num = -1;
			for (int i = 0; i < kub.Count; i++)
			{
				CharInterval charInterval = kub[i];
				if (charInterval.Start > num + 1)
				{
					charClass.Add(Convert.ToChar(num + 1), Convert.ToChar(charInterval.Start - 1));
				}
				num = charInterval.End;
				if (num >= 65535)
				{
					break;
				}
			}
			if (num < 65535)
			{
				charClass.Add(Convert.ToChar(num + 1), Convert.ToChar(65535));
			}
		}
		else if (MuP == 0)
		{
			charClass.AddRange(All);
		}
		charClass.MuP = MuP;
		charClass.FuH = FuH;
		for (int j = 0; j <= 29; j++)
		{
			uint num2 = (uint)(1 << j);
			if ((charClass.MuP & num2) == num2)
			{
				if ((charClass.FuH & num2) == num2)
				{
					charClass.Dup.jqJ((nO)1, _0020: true);
				}
				charClass.FuH ^= num2;
			}
		}
		return charClass;
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	private static string pu7(UnicodeCategory P_0)
	{
		return P_0 switch
		{
			UnicodeCategory.Control => WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6638), 
			UnicodeCategory.Format => WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6646), 
			UnicodeCategory.OtherNotAssigned => WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6654), 
			UnicodeCategory.PrivateUse => WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6662), 
			UnicodeCategory.Surrogate => WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6670), 
			UnicodeCategory.LowercaseLetter => WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6684), 
			UnicodeCategory.ModifierLetter => WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6692), 
			UnicodeCategory.OtherLetter => WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6700), 
			UnicodeCategory.TitlecaseLetter => WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6708), 
			UnicodeCategory.UppercaseLetter => WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6716), 
			UnicodeCategory.SpacingCombiningMark => WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6730), 
			UnicodeCategory.EnclosingMark => WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6738), 
			UnicodeCategory.NonSpacingMark => WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6746), 
			UnicodeCategory.DecimalDigitNumber => WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6760), 
			UnicodeCategory.LetterNumber => WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6768), 
			UnicodeCategory.OtherNumber => WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6776), 
			UnicodeCategory.ConnectorPunctuation => WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6790), 
			UnicodeCategory.DashPunctuation => WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6798), 
			UnicodeCategory.ClosePunctuation => WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6806), 
			UnicodeCategory.FinalQuotePunctuation => WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6814), 
			UnicodeCategory.InitialQuotePunctuation => WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6822), 
			UnicodeCategory.OtherPunctuation => WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6830), 
			UnicodeCategory.OpenPunctuation => WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6838), 
			UnicodeCategory.CurrencySymbol => WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6852), 
			UnicodeCategory.ModifierSymbol => WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6860), 
			UnicodeCategory.MathSymbol => WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6868), 
			UnicodeCategory.OtherSymbol => WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6876), 
			UnicodeCategory.LineSeparator => WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6890), 
			UnicodeCategory.ParagraphSeparator => WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6898), 
			UnicodeCategory.SpaceSeparator => WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6906), 
			_ => null, 
		};
	}

	private static UnicodeCategory[] NuM(string P_0)
	{
		if (HuC.Value.TryGetValue(P_0, out var value))
		{
			return value;
		}
		throw new ArgumentException(SR.GetString(SRName.ExInvalidUnicodeCategoryName), WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6920));
	}

	internal static bool IsLookupStringMatch(string lookupString, char ch)
	{
		uint num = ((uint)lookupString[2] << 16) | lookupString[3];
		if (num != 0)
		{
			uint num2 = ((uint)lookupString[4] << 16) | lookupString[5];
			UnicodeCategory unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(ch);
			uint num3 = (uint)(1 << (int)unicodeCategory);
			if ((num & num3) == num3)
			{
				if ((num2 & num3) == num3)
				{
					return lookupString[0] == '0';
				}
			}
			else if (lookupString[1] == '1')
			{
				return lookupString[0] == '0';
			}
		}
		int num4 = 6;
		int num5 = lookupString.Length;
		while (num4 != num5)
		{
			int num6 = (num4 + num5) / 2;
			if (ch < lookupString[num6])
			{
				num5 = num6;
			}
			else
			{
				num4 = num6 + 1;
			}
		}
		return (lookupString[0] == '0') ? ((num4 & 1) != 0) : ((num4 & 1) == 0);
	}

	internal string ToLookupString()
	{
		StringBuilder stringBuilder = new StringBuilder(1 + Count * 2);
		stringBuilder.Append(IsNegated ? WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6954) : WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6948));
		stringBuilder.Append(Dup.pq3((nO)1) ? WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6954) : WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6948));
		stringBuilder.Append((char)(MuP >> 16));
		stringBuilder.Append((char)(MuP & 0xFFFF));
		stringBuilder.Append((char)(FuH >> 16));
		int num = 0;
		if (LVB() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		default:
			stringBuilder.Append((char)(FuH & 0xFFFF));
			foreach (CharInterval item in kub)
			{
				stringBuilder.Append(item.Start);
				stringBuilder.Append((char)(item.End + 1));
			}
			return stringBuilder.ToString();
		}
	}

	private void huw()
	{
		Dup.jqJ((nO)1, _0020: false);
		int num3 = default(int);
		for (int num = 0; num <= 29; num++)
		{
			bool? categorySpecification = GetCategorySpecification((UnicodeCategory)num);
			int num2 = 0;
			if (LVB() != null)
			{
				num2 = num3;
			}
			switch (num2)
			{
			}
			if (categorySpecification == false)
			{
				Dup.jqJ((nO)1, _0020: true);
				return;
			}
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "ch")]
	public void Add(char ch)
	{
		Add(new CharInterval(ch));
	}

	public void Add(char start, char end)
	{
		Add(new CharInterval(start, end));
	}

	[SuppressMessage("Microsoft.Naming", "CA1725:ParameterNamesShouldMatchBaseDeclaration", MessageId = "0#")]
	public void Add(CharInterval interval)
	{
		int num = kub.Count;
		for (int i = 0; i < num; i++)
		{
			CharInterval value = kub[i];
			if (value.End + 1 < interval.Start)
			{
				continue;
			}
			if (value.Contains(interval))
			{
				return;
			}
			if (value.Start > interval.End + 1)
			{
				kub.Insert(i, interval);
				return;
			}
			if (interval.Start < value.Start)
			{
				value.Start = interval.Start;
				kub[i] = value;
			}
			if (interval.End <= value.End)
			{
				return;
			}
			value.End = interval.End;
			kub[i] = value;
			while (i + 1 < num)
			{
				CharInterval charInterval = kub[i + 1];
				if (charInterval.Start > value.End + 1)
				{
					break;
				}
				value.End = charInterval.End;
				kub[i] = value;
				kub.RemoveAt(i + 1);
				num--;
			}
			return;
		}
		kub.Add(interval);
	}

	public void AddCategory(UnicodeCategory category, bool negate)
	{
		uint num = (uint)(1 << (int)category);
		bool flag = default(bool);
		int num2;
		bool flag2 = default(bool);
		if ((MuP & num) == num)
		{
			flag = (FuH & num) == num;
			if (flag != negate)
			{
				return;
			}
			MuP &= ~num;
			num2 = 1;
			if (UVS())
			{
				num2 = 1;
			}
		}
		else
		{
			MuP |= num;
			flag2 = negate;
			num2 = 0;
			if (LVB() != null)
			{
				int num3 = default(int);
				num2 = num3;
			}
		}
		switch (num2)
		{
		case 1:
			FuH &= ~num;
			if (!flag)
			{
				huw();
			}
			return;
		}
		if (!flag2)
		{
			FuH |= num;
			return;
		}
		FuH &= ~num;
		Dup.jqJ((nO)1, _0020: true);
	}

	public void AddCategory(string categoryName, bool negate)
	{
		UnicodeCategory[] array = NuM(categoryName);
		UnicodeCategory[] array2 = array;
		foreach (UnicodeCategory category in array2)
		{
			AddCategory(category, negate);
		}
	}

	public void AddRange(CharInterval[] intervals)
	{
		if (intervals != null)
		{
			foreach (CharInterval interval in intervals)
			{
				Add(interval);
			}
		}
	}

	public void AddRange(CharClass charClass)
	{
		if (charClass == null)
		{
			return;
		}
		if (charClass.IsNegated)
		{
			charClass = charClass.WuI();
		}
		foreach (CharInterval item in charClass)
		{
			Add(new CharInterval(item.Start, item.End));
		}
		int num2 = default(int);
		for (int i = 0; i <= 29; i++)
		{
			bool? categorySpecification = charClass.GetCategorySpecification((UnicodeCategory)i);
			if (categorySpecification.HasValue)
			{
				AddCategory((UnicodeCategory)i, !categorySpecification.Value);
				int num = 0;
				if (LVB() != null)
				{
					num = num2;
				}
				switch (num)
				{
				}
			}
		}
	}

	public void Clear()
	{
		MuP = 0u;
		FuH = 0u;
		Dup.jqJ((nO)1, _0020: false);
		kub.Clear();
	}

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "ch")]
	public bool Contains(char ch)
	{
		if (MuP != 0)
		{
			UnicodeCategory unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(ch);
			bool? categorySpecification = GetCategorySpecification(unicodeCategory);
			bool? flag = categorySpecification;
			bool? flag2 = flag;
			if (flag2.HasValue)
			{
				if (flag2 == true)
				{
					return !IsNegated;
				}
			}
			else if (Dup.pq3((nO)1))
			{
				return !IsNegated;
			}
		}
		int num = kub.Count - 1;
		if (num == 0 && kub[num].Contains(ch))
		{
			return !IsNegated;
		}
		if (num == -1)
		{
			return IsNegated;
		}
		int num2 = 0;
		if (ch < kub[num2].Start || ch > kub[num].End)
		{
			return IsNegated;
		}
		while (num2 < num)
		{
			int num3 = (num + num2) / 2;
			if (ch < kub[num3].Start)
			{
				num = num3 - 1;
				continue;
			}
			if (ch > kub[num3].End)
			{
				num2 = num3 + 1;
				continue;
			}
			return !IsNegated;
		}
		if (num2 == num)
		{
			return IsNegated ? (!kub[num2].Contains(ch)) : kub[num2].Contains(ch);
		}
		return IsNegated;
	}

	public bool Contains(char start, char end)
	{
		return Contains(new CharInterval(start, end));
	}

	[SuppressMessage("Microsoft.Naming", "CA1725:ParameterNamesShouldMatchBaseDeclaration", MessageId = "0#")]
	public bool Contains(CharInterval interval)
	{
		for (char c = interval.Start; c < interval.End; c = (char)(c + 1))
		{
			if (!Contains(c))
			{
				return false;
			}
		}
		return true;
	}

	public bool Contains(CharClass charClass)
	{
		if (charClass == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6960));
		}
		foreach (CharInterval item in charClass)
		{
			if (!Contains(item))
			{
				return false;
			}
		}
		return true;
	}

	public void CopyTo(CharInterval[] array, int arrayIndex)
	{
		kub.CopyTo(array, arrayIndex);
	}

	public override bool Equals(object obj)
	{
		if (!(obj is CharClass charClass))
		{
			return false;
		}
		if (Count != charClass.Count)
		{
			return false;
		}
		for (int i = 0; i < Count; i++)
		{
			if (!kub[i].Equals(charClass[i]))
			{
				return false;
			}
		}
		return true;
	}

	public bool? GetCategorySpecification(UnicodeCategory category)
	{
		uint num = (uint)(1 << (int)category);
		if ((MuP & num) == num)
		{
			return (FuH & num) == num;
		}
		return null;
	}

	public IEnumerator<CharInterval> GetEnumerator()
	{
		return kub.GetEnumerator();
	}

	public override int GetHashCode()
	{
		return kub.GetHashCode();
	}

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "ch")]
	public bool Remove(char ch)
	{
		for (int i = 0; i < kub.Count; i++)
		{
			if (kub[i].Contains(ch))
			{
				if (kub[i].Count == 1)
				{
					kub.RemoveAt(i);
					return true;
				}
				if (kub[i].Start == ch)
				{
					kub[i] = new CharInterval((char)(ch + 1), kub[i].End);
					return true;
				}
				if (kub[i].End == ch)
				{
					kub[i] = new CharInterval(kub[i].Start, (char)(ch - 1));
					return true;
				}
				kub[i] = new CharInterval(kub[i].Start, (char)(ch - 1));
				kub.Insert(i + 1, new CharInterval((char)(ch + 1), kub[i].End));
				return true;
			}
		}
		return false;
	}

	[SuppressMessage("Microsoft.Naming", "CA1725:ParameterNamesShouldMatchBaseDeclaration", MessageId = "0#")]
	public bool Remove(CharInterval interval)
	{
		return kub.Remove(interval);
	}

	public void RemoveCategory(UnicodeCategory category)
	{
		uint num = (uint)(1 << (int)category);
		MuP &= ~num;
		FuH &= ~num;
		huw();
	}

	public void RemoveCategory(string categoryName)
	{
		UnicodeCategory[] array = NuM(categoryName);
		UnicodeCategory[] array2 = array;
		foreach (UnicodeCategory category in array2)
		{
			RemoveCategory(category);
		}
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6982));
		int num;
		if (IsNegated)
		{
			stringBuilder.Append(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6988));
			num = 0;
			if (!UVS())
			{
				goto IL_0005;
			}
			goto IL_0009;
		}
		goto IL_0195;
		IL_0195:
		int num2 = 0;
		goto IL_01ed;
		IL_0005:
		int num3 = default(int);
		num = num3;
		goto IL_0009;
		IL_0009:
		switch (num)
		{
		case 1:
			break;
		default:
			goto IL_0195;
		}
		bool? categorySpecification = default(bool?);
		if (categorySpecification == true)
		{
			stringBuilder.Append(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6994));
		}
		else
		{
			stringBuilder.Append(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7004));
		}
		stringBuilder.Append(pu7((UnicodeCategory)num2));
		stringBuilder.Append(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1418));
		goto IL_0101;
		IL_0101:
		num2++;
		goto IL_01ed;
		IL_01ed:
		if (num2 <= 29)
		{
			categorySpecification = GetCategorySpecification((UnicodeCategory)num2);
			if (categorySpecification.HasValue)
			{
				num = 1;
				if (!UVS())
				{
					goto IL_0005;
				}
				goto IL_0009;
			}
			goto IL_0101;
		}
		foreach (CharInterval item in kub)
		{
			stringBuilder.Append(item.ToString());
		}
		stringBuilder.Append(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7014));
		return stringBuilder.ToString();
	}

	static CharClass()
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		HuC = new ActiproSoftware.Text.Utility.Lazy<Dictionary<string, UnicodeCategory[]>>(fus);
	}

	internal static bool UVS()
	{
		return LVm == null;
	}

	internal static CharClass LVB()
	{
		return LVm;
	}
}
