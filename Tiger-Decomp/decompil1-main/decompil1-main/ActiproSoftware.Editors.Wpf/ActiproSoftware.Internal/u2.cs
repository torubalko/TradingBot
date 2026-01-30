using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using ActiproSoftware.Products.Editors;

namespace ActiproSoftware.Internal;

[DefaultMember("Item")]
[SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
internal class u2 : ICollection<YH>, IEnumerable<YH>, IEnumerable
{
	[Flags]
	private enum md7
	{

	}

	private class fdr
	{
		private md7 PKf;

		internal static fdr DtL;

		public fdr()
		{
			awj.QuEwGz();
			base._002Ector();
		}

		internal bool kK2(md7 P_0)
		{
			return (PKf & P_0) == P_0;
		}

		internal void uKa(md7 P_0, bool P_1)
		{
			if (P_1)
			{
				PKf |= P_0;
			}
			else
			{
				PKf &= ~P_0;
			}
		}

		internal static bool Ftq()
		{
			return DtL == null;
		}

		internal static fdr Utn()
		{
			return DtL;
		}
	}

	private uint yY5;

	private uint rYc;

	private fdr oYH;

	private List<YH> rYL;

	private static Lazy<Dictionary<string, UnicodeCategory[]>> gYF;

	private static u2 va1;

	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "Whitespace")]
	public static u2 V0z
	{
		get
		{
			u2 u3 = new u2();
			u3.Add('\f');
			u3.Add('\n');
			u3.Add('\r');
			u3.Add('\t');
			u3.Add('\v');
			u3.Add('\u0085');
			u3.Add(' ');
			u3.Add('\u00a0');
			u3.Add('\u1680');
			u3.Add('\u2000', '\u2009');
			u3.Add('\u202f');
			u3.Add('\u205f');
			u3.Add('\u3000');
			u3.Add('\u2028');
			u3.Add('\u2029');
			return u3;
		}
	}

	public static u2 None => new u2();

	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "Whitespace")]
	public static u2 TYf
	{
		get
		{
			u2 u3 = V0z;
			u3.tYq(_0020: true);
			return u3;
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "Whitespace")]
	public static u2 YYX
	{
		get
		{
			u2 u3 = cYg;
			u3.tYq(_0020: true);
			return u3;
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "Whitespace")]
	public static u2 cYg
	{
		get
		{
			u2 u3 = new u2();
			u3.Add('\f');
			u3.Add('\t');
			u3.Add('\v');
			u3.Add('\u0085');
			u3.Add(' ');
			u3.Add('\u00a0');
			u3.Add('\u1680');
			u3.Add('\u2000', '\u2009');
			u3.Add('\u202f');
			u3.Add('\u205f');
			u3.Add('\u3000');
			return u3;
		}
	}

	public int Count => rYL.Count;

	public bool IsReadOnly => false;

	public u2()
	{
		awj.QuEwGz();
		oYH = new fdr();
		rYL = new List<YH>();
		base._002Ector();
	}

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "ch")]
	public u2(char P_0)
	{
		awj.QuEwGz();
		this._002Ector();
		Add(P_0);
	}

	public u2(string P_0)
	{
		awj.QuEwGz();
		this._002Ector();
		if (string.IsNullOrEmpty(P_0))
		{
			return;
		}
		int num = 0;
		if (1 == 0)
		{
			int num2;
			num = num2;
		}
		switch (num)
		{
		}
		foreach (char ch in P_0)
		{
			Add(ch);
		}
	}

	public u2(YH[] P_0)
	{
		awj.QuEwGz();
		this._002Ector();
		E08(P_0);
	}

	public u2(u2 P_0)
	{
		awj.QuEwGz();
		this._002Ector();
		t0r(P_0);
	}

	public u2(char P_0, char P_1)
	{
		awj.QuEwGz();
		this._002Ector();
		Add(P_0, P_1);
	}

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "ch")]
	public u2(char P_0, bool P_1)
	{
		awj.QuEwGz();
		this._002Ector(P_0);
		tYq(P_1);
	}

	public u2(char P_0, char P_1, bool P_2)
	{
		awj.QuEwGz();
		this._002Ector(P_0, P_1);
		tYq(P_2);
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return rYL.GetEnumerator();
	}

	internal bool C0c(u2 P_0)
	{
		if (P_0 == null)
		{
			return false;
		}
		if (xYG() || P_0.xYG())
		{
			return false;
		}
		if (rYc == 0 && Count == 0)
		{
			return true;
		}
		if (P_0.rYc == 0 && P_0.Count == 0)
		{
			return true;
		}
		return (rYc == 0 || rYc == (yY5 & rYc)) && (P_0.rYc == 0 || P_0.rYc == (P_0.yY5 & P_0.rYc));
	}

	private static Dictionary<string, UnicodeCategory[]> m0H()
	{
		Dictionary<string, UnicodeCategory[]> dictionary = new Dictionary<string, UnicodeCategory[]>();
		dictionary[QdM.AR8(23256)] = new UnicodeCategory[1] { UnicodeCategory.Control };
		dictionary[QdM.AR8(23264)] = new UnicodeCategory[1] { UnicodeCategory.Format };
		dictionary[QdM.AR8(23272)] = new UnicodeCategory[1] { UnicodeCategory.OtherNotAssigned };
		dictionary[QdM.AR8(23280)] = new UnicodeCategory[1] { UnicodeCategory.PrivateUse };
		dictionary[QdM.AR8(23288)] = new UnicodeCategory[1] { UnicodeCategory.Surrogate };
		dictionary[QdM.AR8(23296)] = new UnicodeCategory[5]
		{
			UnicodeCategory.Control,
			UnicodeCategory.Format,
			UnicodeCategory.OtherNotAssigned,
			UnicodeCategory.PrivateUse,
			UnicodeCategory.Surrogate
		};
		dictionary[QdM.AR8(23302)] = new UnicodeCategory[1] { UnicodeCategory.LowercaseLetter };
		dictionary[QdM.AR8(23310)] = new UnicodeCategory[1] { UnicodeCategory.ModifierLetter };
		dictionary[QdM.AR8(23318)] = new UnicodeCategory[1] { UnicodeCategory.OtherLetter };
		dictionary[QdM.AR8(17492)] = new UnicodeCategory[1] { UnicodeCategory.TitlecaseLetter };
		dictionary[QdM.AR8(23326)] = new UnicodeCategory[1];
		dictionary[QdM.AR8(17190)] = new UnicodeCategory[5]
		{
			UnicodeCategory.LowercaseLetter,
			UnicodeCategory.ModifierLetter,
			UnicodeCategory.OtherLetter,
			UnicodeCategory.TitlecaseLetter,
			UnicodeCategory.UppercaseLetter
		};
		dictionary[QdM.AR8(23334)] = new UnicodeCategory[1] { UnicodeCategory.SpacingCombiningMark };
		dictionary[QdM.AR8(23342)] = new UnicodeCategory[1] { UnicodeCategory.EnclosingMark };
		dictionary[QdM.AR8(23350)] = new UnicodeCategory[1] { UnicodeCategory.NonSpacingMark };
		dictionary[QdM.AR8(18832)] = new UnicodeCategory[3]
		{
			UnicodeCategory.SpacingCombiningMark,
			UnicodeCategory.EnclosingMark,
			UnicodeCategory.NonSpacingMark
		};
		dictionary[QdM.AR8(23358)] = new UnicodeCategory[1] { UnicodeCategory.DecimalDigitNumber };
		dictionary[QdM.AR8(23366)] = new UnicodeCategory[1] { UnicodeCategory.LetterNumber };
		dictionary[QdM.AR8(23374)] = new UnicodeCategory[1] { UnicodeCategory.OtherNumber };
		dictionary[QdM.AR8(3248)] = new UnicodeCategory[3]
		{
			UnicodeCategory.DecimalDigitNumber,
			UnicodeCategory.LetterNumber,
			UnicodeCategory.OtherNumber
		};
		dictionary[QdM.AR8(23382)] = new UnicodeCategory[1] { UnicodeCategory.ConnectorPunctuation };
		dictionary[QdM.AR8(23390)] = new UnicodeCategory[1] { UnicodeCategory.DashPunctuation };
		dictionary[QdM.AR8(23398)] = new UnicodeCategory[1] { UnicodeCategory.ClosePunctuation };
		dictionary[QdM.AR8(23406)] = new UnicodeCategory[1] { UnicodeCategory.FinalQuotePunctuation };
		dictionary[QdM.AR8(23414)] = new UnicodeCategory[1] { UnicodeCategory.InitialQuotePunctuation };
		dictionary[QdM.AR8(23422)] = new UnicodeCategory[1] { UnicodeCategory.OtherPunctuation };
		dictionary[QdM.AR8(23430)] = new UnicodeCategory[1] { UnicodeCategory.OpenPunctuation };
		dictionary[QdM.AR8(16712)] = new UnicodeCategory[7]
		{
			UnicodeCategory.ConnectorPunctuation,
			UnicodeCategory.DashPunctuation,
			UnicodeCategory.ClosePunctuation,
			UnicodeCategory.FinalQuotePunctuation,
			UnicodeCategory.InitialQuotePunctuation,
			UnicodeCategory.OtherPunctuation,
			UnicodeCategory.OpenPunctuation
		};
		dictionary[QdM.AR8(23438)] = new UnicodeCategory[1] { UnicodeCategory.CurrencySymbol };
		dictionary[QdM.AR8(23446)] = new UnicodeCategory[1] { UnicodeCategory.ModifierSymbol };
		dictionary[QdM.AR8(23454)] = new UnicodeCategory[1] { UnicodeCategory.MathSymbol };
		dictionary[QdM.AR8(23462)] = new UnicodeCategory[1] { UnicodeCategory.OtherSymbol };
		dictionary[QdM.AR8(17968)] = new UnicodeCategory[4]
		{
			UnicodeCategory.CurrencySymbol,
			UnicodeCategory.ModifierSymbol,
			UnicodeCategory.MathSymbol,
			UnicodeCategory.OtherSymbol
		};
		dictionary[QdM.AR8(23470)] = new UnicodeCategory[1] { UnicodeCategory.LineSeparator };
		dictionary[QdM.AR8(23478)] = new UnicodeCategory[1] { UnicodeCategory.ParagraphSeparator };
		dictionary[QdM.AR8(23486)] = new UnicodeCategory[1] { UnicodeCategory.SpaceSeparator };
		dictionary[QdM.AR8(23494)] = new UnicodeCategory[3]
		{
			UnicodeCategory.LineSeparator,
			UnicodeCategory.ParagraphSeparator,
			UnicodeCategory.SpaceSeparator
		};
		return dictionary;
	}

	private u2 v0L()
	{
		u2 u3 = new u2();
		if (rYL.Count > 0)
		{
			int num = -1;
			for (int i = 0; i < rYL.Count; i++)
			{
				YH yH = rYL[i];
				if (yH.IYp() > num + 1)
				{
					u3.Add(Convert.ToChar(num + 1), Convert.ToChar(yH.IYp() - 1));
				}
				num = yH.rY8();
				if (num >= 65535)
				{
					break;
				}
			}
			if (num < 65535)
			{
				u3.Add(Convert.ToChar(num + 1), Convert.ToChar(65535));
			}
		}
		else if (rYc == 0)
		{
			u3.t0r(F0J());
		}
		u3.rYc = rYc;
		u3.yY5 = yY5;
		for (int j = 0; j <= 29; j++)
		{
			uint num2 = (uint)(1 << j);
			if ((u3.rYc & num2) == num2)
			{
				if ((u3.yY5 & num2) == num2)
				{
					u3.oYH.uKa((md7)1, _0020: true);
				}
				u3.yY5 ^= num2;
			}
		}
		return u3;
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	private static string p0F(UnicodeCategory P_0)
	{
		return P_0 switch
		{
			UnicodeCategory.Control => QdM.AR8(23256), 
			UnicodeCategory.Format => QdM.AR8(23264), 
			UnicodeCategory.OtherNotAssigned => QdM.AR8(23272), 
			UnicodeCategory.PrivateUse => QdM.AR8(23280), 
			UnicodeCategory.Surrogate => QdM.AR8(23288), 
			UnicodeCategory.LowercaseLetter => QdM.AR8(23302), 
			UnicodeCategory.ModifierLetter => QdM.AR8(23310), 
			UnicodeCategory.OtherLetter => QdM.AR8(23318), 
			UnicodeCategory.TitlecaseLetter => QdM.AR8(17492), 
			UnicodeCategory.UppercaseLetter => QdM.AR8(23326), 
			UnicodeCategory.SpacingCombiningMark => QdM.AR8(23334), 
			UnicodeCategory.EnclosingMark => QdM.AR8(23342), 
			UnicodeCategory.NonSpacingMark => QdM.AR8(23350), 
			UnicodeCategory.DecimalDigitNumber => QdM.AR8(23358), 
			UnicodeCategory.LetterNumber => QdM.AR8(23366), 
			UnicodeCategory.OtherNumber => QdM.AR8(23374), 
			UnicodeCategory.ConnectorPunctuation => QdM.AR8(23382), 
			UnicodeCategory.DashPunctuation => QdM.AR8(23390), 
			UnicodeCategory.ClosePunctuation => QdM.AR8(23398), 
			UnicodeCategory.FinalQuotePunctuation => QdM.AR8(23406), 
			UnicodeCategory.InitialQuotePunctuation => QdM.AR8(23414), 
			UnicodeCategory.OtherPunctuation => QdM.AR8(23422), 
			UnicodeCategory.OpenPunctuation => QdM.AR8(23430), 
			UnicodeCategory.CurrencySymbol => QdM.AR8(23438), 
			UnicodeCategory.ModifierSymbol => QdM.AR8(23446), 
			UnicodeCategory.MathSymbol => QdM.AR8(23454), 
			UnicodeCategory.OtherSymbol => QdM.AR8(23462), 
			UnicodeCategory.LineSeparator => QdM.AR8(23470), 
			UnicodeCategory.ParagraphSeparator => QdM.AR8(23478), 
			UnicodeCategory.SpaceSeparator => QdM.AR8(23486), 
			_ => null, 
		};
	}

	private static UnicodeCategory[] P0A(string P_0)
	{
		if (!gYF.Value.TryGetValue(P_0, out var value))
		{
			throw new ArgumentException(SR.GetString(SRName.ExInvalidUnicodeCategoryName), QdM.AR8(23500));
		}
		return value;
	}

	internal static bool e03(string P_0, char P_1)
	{
		uint num = ((uint)P_0[2] << 16) | P_0[3];
		if (num != 0)
		{
			uint num2 = ((uint)P_0[4] << 16) | P_0[5];
			UnicodeCategory unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(P_1);
			uint num3 = (uint)(1 << (int)unicodeCategory);
			if ((num & num3) == num3)
			{
				if ((num2 & num3) == num3)
				{
					return P_0[0] == '0';
				}
			}
			else if (P_0[1] == '1')
			{
				return P_0[0] == '0';
			}
		}
		int num4 = 6;
		int num5 = P_0.Length;
		while (num4 != num5)
		{
			int num6 = (num4 + num5) / 2;
			if (P_1 < P_0[num6])
			{
				num5 = num6;
			}
			else
			{
				num4 = num6 + 1;
			}
		}
		return (P_0[0] == '0') ? ((num4 & 1) != 0) : ((num4 & 1) == 0);
	}

	internal string K0y()
	{
		StringBuilder stringBuilder = new StringBuilder(1 + Count * 2);
		stringBuilder.Append(xYG() ? QdM.AR8(2170) : QdM.AR8(2092));
		stringBuilder.Append(oYH.kK2((md7)1) ? QdM.AR8(2170) : QdM.AR8(2092));
		stringBuilder.Append((char)(rYc >> 16));
		stringBuilder.Append((char)(rYc & 0xFFFF));
		stringBuilder.Append((char)(yY5 >> 16));
		int num = 0;
		if (!oaQ())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		default:
			stringBuilder.Append((char)(yY5 & 0xFFFF));
			foreach (YH item in rYL)
			{
				stringBuilder.Append(item.IYp());
				stringBuilder.Append((char)(item.rY8() + 1));
			}
			return stringBuilder.ToString();
		}
	}

	private void E0m()
	{
		oYH.uKa((md7)1, _0020: false);
		for (int i = 0; i <= 29; i++)
		{
			if (N0i((UnicodeCategory)i) == false)
			{
				oYH.uKa((md7)1, _0020: true);
				break;
			}
		}
	}

	[SpecialName]
	public static u2 F0J()
	{
		return new u2('\0', '\uffff');
	}

	[SpecialName]
	public static u2 Q0k()
	{
		u2 u3 = new u2();
		u3.rYc = 31u;
		u3.yY5 = 31u;
		return u3;
	}

	[SpecialName]
	public static u2 z07()
	{
		u2 u3 = new u2();
		u3.rYc = 256u;
		u3.yY5 = 256u;
		return u3;
	}

	[SpecialName]
	public static u2 w0B()
	{
		u2 u3 = new u2();
		u3.Add('0', '9');
		u3.Add('a', 'f');
		u3.Add('A', 'F');
		return u3;
	}

	[SpecialName]
	public static u2 e0w()
	{
		u2 u3 = new u2();
		u3.Add('\n');
		u3.Add('\r');
		u3.Add('\u2028');
		u3.Add('\u2029');
		return u3;
	}

	[SpecialName]
	public static u2 aYQ()
	{
		u2 u3 = Q0k();
		u3.tYq(_0020: true);
		return u3;
	}

	[SpecialName]
	public static u2 RYC()
	{
		u2 u3 = z07();
		u3.tYq(_0020: true);
		return u3;
	}

	[SpecialName]
	public static u2 CYs()
	{
		u2 u3 = w0B();
		u3.tYq(_0020: true);
		return u3;
	}

	[SpecialName]
	public static u2 JYP()
	{
		u2 u3 = e0w();
		u3.tYq(_0020: true);
		return u3;
	}

	[SpecialName]
	public static u2 UYx()
	{
		u2 u3 = qYo();
		u3.tYq(_0020: true);
		return u3;
	}

	[SpecialName]
	public static u2 qYo()
	{
		u2 u3 = new u2();
		u3.rYc = 262431u;
		u3.yY5 = 262431u;
		return u3;
	}

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "ch")]
	public void Add(char ch)
	{
		Add(new YH(ch));
	}

	public void Add(char start, char end)
	{
		Add(new YH(start, end));
	}

	[SuppressMessage("Microsoft.Naming", "CA1725:ParameterNamesShouldMatchBaseDeclaration", MessageId = "0#")]
	public void Add(YH interval)
	{
		int num = rYL.Count;
		for (int i = 0; i < num; i++)
		{
			YH value = rYL[i];
			if (value.rY8() + 1 < interval.IYp())
			{
				continue;
			}
			if (value.XY3(interval))
			{
				return;
			}
			if (value.IYp() > interval.rY8() + 1)
			{
				rYL.Insert(i, interval);
				return;
			}
			if (interval.IYp() < value.IYp())
			{
				value.UYW(interval.IYp());
				rYL[i] = value;
			}
			if (interval.rY8() <= value.rY8())
			{
				return;
			}
			value.UYr(interval.rY8());
			rYL[i] = value;
			while (i + 1 < num)
			{
				YH yH = rYL[i + 1];
				if (yH.IYp() > value.rY8() + 1)
				{
					break;
				}
				value.UYr(yH.rY8());
				rYL[i] = value;
				rYL.RemoveAt(i + 1);
				num--;
			}
			return;
		}
		rYL.Add(interval);
	}

	public void R0S(UnicodeCategory P_0, bool P_1)
	{
		uint num = (uint)(1 << (int)P_0);
		if ((rYc & num) != num)
		{
			int num2 = 1;
			if (!oaQ())
			{
				int num3 = default(int);
				num2 = num3;
			}
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					rYc |= num;
					if (P_1)
					{
						yY5 &= ~num;
						oYH.uKa((md7)1, _0020: true);
						return;
					}
					yY5 |= num;
					num2 = 0;
					if (naZ() == null)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
		bool flag = (yY5 & num) == num;
		if (flag == P_1)
		{
			rYc &= ~num;
			yY5 &= ~num;
			if (!flag)
			{
				E0m();
			}
		}
	}

	public void P01(string P_0, bool P_1)
	{
		UnicodeCategory[] array = P0A(P_0);
		UnicodeCategory[] array2 = array;
		foreach (UnicodeCategory unicodeCategory in array2)
		{
			R0S(unicodeCategory, P_1);
		}
	}

	public void E08(YH[] P_0)
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
				case 1:
					break;
				default:
					if (!flag)
					{
						foreach (YH interval in P_0)
						{
							Add(interval);
						}
					}
					return;
				}
				flag = P_0 == null;
				num2 = 0;
			}
			while (oaQ());
		}
	}

	public void t0r(u2 P_0)
	{
		int num = 2;
		bool flag = default(bool);
		IEnumerator<YH> enumerator = default(IEnumerator<YH>);
		while (true)
		{
			int num2 = num;
			do
			{
				IL_0012:
				switch (num2)
				{
				case 1:
					if (flag)
					{
						return;
					}
					if (P_0.xYG())
					{
						P_0 = P_0.v0L();
					}
					goto IL_009a;
				default:
				{
					try
					{
						while (enumerator.MoveNext())
						{
							YH current = enumerator.Current;
							Add(new YH(current.IYp(), current.rY8()));
						}
					}
					finally
					{
						enumerator?.Dispose();
					}
					for (int i = 0; i <= 29; i++)
					{
						bool? flag2 = P_0.N0i((UnicodeCategory)i);
						if (flag2.HasValue)
						{
							R0S((UnicodeCategory)i, !flag2.Value);
						}
					}
					return;
				}
				case 2:
					flag = P_0 == null;
					num2 = 1;
					if (naZ() != null)
					{
						num2 = 1;
					}
					break;
				}
				goto IL_0012;
				IL_009a:
				enumerator = P_0.GetEnumerator();
				num2 = 0;
			}
			while (oaQ());
		}
	}

	[SpecialName]
	public int oYT()
	{
		int num = 0;
		using (IEnumerator<YH> enumerator = GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				num += enumerator.Current.lYS();
			}
		}
		return num;
	}

	public void Clear()
	{
		rYc = 0u;
		yY5 = 0u;
		oYH.uKa((md7)1, _0020: false);
		rYL.Clear();
	}

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "ch")]
	public bool q0v(char P_0)
	{
		if (rYc != 0)
		{
			UnicodeCategory unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(P_0);
			bool? flag = N0i(unicodeCategory);
			bool? flag2 = flag;
			bool? flag3 = flag2;
			if (flag3.HasValue)
			{
				if (flag3 == true)
				{
					return !xYG();
				}
			}
			else if (oYH.kK2((md7)1))
			{
				return !xYG();
			}
		}
		int num = rYL.Count - 1;
		if (num == 0 && rYL[num].AYA(P_0))
		{
			return !xYG();
		}
		if (num == -1)
		{
			return xYG();
		}
		int num2 = 0;
		if (P_0 < rYL[num2].IYp() || P_0 > rYL[num].rY8())
		{
			return xYG();
		}
		while (num2 < num)
		{
			int num3 = (num + num2) / 2;
			if (P_0 < rYL[num3].IYp())
			{
				num = num3 - 1;
				continue;
			}
			if (P_0 > rYL[num3].rY8())
			{
				num2 = num3 + 1;
				continue;
			}
			return !xYG();
		}
		if (num2 == num)
		{
			return xYG() ? (!rYL[num2].AYA(P_0)) : rYL[num2].AYA(P_0);
		}
		return xYG();
	}

	public bool L0p(char P_0, char P_1)
	{
		return Contains(new YH(P_0, P_1));
	}

	[SuppressMessage("Microsoft.Naming", "CA1725:ParameterNamesShouldMatchBaseDeclaration", MessageId = "0#")]
	public bool Contains(YH P_0)
	{
		char c = P_0.IYp();
		while (true)
		{
			if (c >= P_0.rY8())
			{
				return true;
			}
			if (!q0v(c))
			{
				break;
			}
			c = (char)(c + 1);
		}
		int num = 0;
		if (!oaQ())
		{
			int num2 = default(int);
			num = num2;
		}
		return num switch
		{
			_ => false, 
		};
	}

	public bool b0W(u2 P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(QdM.AR8(23528));
		}
		foreach (YH item in P_0)
		{
			if (!Contains(item))
			{
				return false;
			}
		}
		return true;
	}

	public void CopyTo(YH[] P_0, int P_1)
	{
		rYL.CopyTo(P_0, P_1);
	}

	public override bool Equals(object P_0)
	{
		if (!(P_0 is u2 u3))
		{
			return false;
		}
		if (Count == u3.Count)
		{
			int num = 0;
			int num3 = default(int);
			while (true)
			{
				if (num >= Count)
				{
					return true;
				}
				YH yH = rYL[num];
				int num2 = 1;
				if (naZ() != null)
				{
					num2 = num3;
				}
				switch (num2)
				{
				case 1:
					if (yH.Equals(u3.TYd(num)))
					{
						goto IL_0141;
					}
					return false;
				}
				break;
				IL_0141:
				num++;
			}
		}
		return false;
	}

	public bool? N0i(UnicodeCategory P_0)
	{
		uint num = (uint)(1 << (int)P_0);
		if ((rYc & num) == num)
		{
			return (yY5 & num) == num;
		}
		return null;
	}

	public IEnumerator<YH> GetEnumerator()
	{
		return rYL.GetEnumerator();
	}

	public override int GetHashCode()
	{
		return rYL.GetHashCode();
	}

	[SpecialName]
	public bool JYb()
	{
		return rYc != 0;
	}

	[SpecialName]
	public bool xYG()
	{
		return oYH.kK2((md7)2);
	}

	[SpecialName]
	public void tYq(bool P_0)
	{
		oYH.uKa((md7)2, P_0);
	}

	[SpecialName]
	public bool hYK()
	{
		if (rYL.Count != 1 || rYc != 0)
		{
			return false;
		}
		return rYL[0].IYp() == rYL[0].rY8();
	}

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "ch")]
	public bool M0Z(char P_0)
	{
		int num = 0;
		bool result = default(bool);
		int num3 = default(int);
		while (true)
		{
			int num2;
			if (num < rYL.Count)
			{
				if (rYL[num].AYA(P_0))
				{
					if (rYL[num].lYS() == 1)
					{
						rYL.RemoveAt(num);
						result = true;
						num2 = 0;
						if (naZ() != null)
						{
							goto IL_0005;
						}
					}
					else
					{
						if (rYL[num].IYp() == P_0)
						{
							rYL[num] = new YH((char)(P_0 + 1), rYL[num].rY8());
							result = true;
							break;
						}
						if (rYL[num].rY8() == P_0)
						{
							rYL[num] = new YH(rYL[num].IYp(), (char)(P_0 - 1));
							result = true;
							break;
						}
						rYL[num] = new YH(rYL[num].IYp(), (char)(P_0 - 1));
						rYL.Insert(num + 1, new YH((char)(P_0 + 1), rYL[num].rY8()));
						num2 = 1;
						if (!oaQ())
						{
							goto IL_0005;
						}
					}
					goto IL_0009;
				}
				num++;
				continue;
			}
			result = false;
			break;
			IL_0009:
			switch (num2)
			{
			case 1:
				result = true;
				break;
			}
			break;
			IL_0005:
			num2 = num3;
			goto IL_0009;
		}
		return result;
	}

	[SuppressMessage("Microsoft.Naming", "CA1725:ParameterNamesShouldMatchBaseDeclaration", MessageId = "0#")]
	public bool Remove(YH P_0)
	{
		return rYL.Remove(P_0);
	}

	public void J0t(UnicodeCategory P_0)
	{
		uint num = (uint)(1 << (int)P_0);
		rYc &= ~num;
		yY5 &= ~num;
		E0m();
	}

	public void a0n(string P_0)
	{
		UnicodeCategory[] array = P0A(P_0);
		UnicodeCategory[] array2 = array;
		foreach (UnicodeCategory unicodeCategory in array2)
		{
			J0t(unicodeCategory);
		}
	}

	[SpecialName]
	public YH TYd(int P_0)
	{
		return rYL[P_0];
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder(QdM.AR8(23550));
		if (xYG())
		{
			stringBuilder.Append(QdM.AR8(23556));
		}
		for (int i = 0; i <= 29; i++)
		{
			bool? flag = N0i((UnicodeCategory)i);
			if (flag.HasValue)
			{
				if (flag == true)
				{
					stringBuilder.Append(QdM.AR8(23562));
				}
				else
				{
					stringBuilder.Append(QdM.AR8(23572));
				}
				stringBuilder.Append(p0F((UnicodeCategory)i));
				stringBuilder.Append(QdM.AR8(23582));
			}
		}
		foreach (YH item in rYL)
		{
			stringBuilder.Append(item.ToString());
		}
		stringBuilder.Append(QdM.AR8(23588));
		return stringBuilder.ToString();
	}

	static u2()
	{
		awj.QuEwGz();
		gYF = new Lazy<Dictionary<string, UnicodeCategory[]>>(m0H);
	}

	internal static bool oaQ()
	{
		return va1 == null;
	}

	internal static u2 naZ()
	{
		return va1;
	}
}
