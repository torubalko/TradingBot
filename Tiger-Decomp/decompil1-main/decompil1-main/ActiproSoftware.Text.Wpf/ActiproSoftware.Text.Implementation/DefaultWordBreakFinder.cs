using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using ActiproSoftware.Text.RegularExpressions;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Implementation;

[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "WordBreak")]
public class DefaultWordBreakFinder : IWordBreakFinder
{
	private CharClass Mcc;

	private CharClass Xch;

	private static DefaultWordBreakFinder yUl;

	public static CharClass DefaultWordContainsAdditionalCharacters => new CharClass('_');

	public static CharClass DefaultWordStandaloneCharacters
	{
		get
		{
			CharClass charClass = new CharClass();
			charClass.Add('.');
			charClass.Add(',');
			charClass.Add('(');
			charClass.Add(')');
			charClass.Add('<');
			charClass.Add('>');
			charClass.Add('[');
			charClass.Add(']');
			charClass.Add('{');
			charClass.Add('}');
			charClass.Add('?');
			charClass.Add('!');
			charClass.Add('\\');
			charClass.Add('/');
			charClass.Add(':');
			int num = 0;
			if (bUI() != null)
			{
				num = 0;
			}
			CharClass result = default(CharClass);
			int num2 = default(int);
			while (true)
			{
				switch (num)
				{
				case 1:
					return result;
				}
				charClass.Add(';');
				charClass.Add('\'');
				charClass.Add('"');
				result = charClass;
				num = 1;
				if (!xUo())
				{
					num = num2;
				}
			}
		}
	}

	[SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
	public CharClass WordContainsAdditionalCharacters
	{
		get
		{
			return Mcc;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6008));
			}
			Mcc = value;
		}
	}

	[SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
	public CharClass WordStandaloneCharacters
	{
		get
		{
			return Xch;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6008));
			}
			Xch = value;
		}
	}

	public DefaultWordBreakFinder()
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
		WordContainsAdditionalCharacters = new CharClass(DefaultWordContainsAdditionalCharacters);
		WordStandaloneCharacters = new CharClass(DefaultWordStandaloneCharacters);
	}

	private bool kc2(char P_0, ITextSnapshot P_1, bool P_2, ref int P_3)
	{
		if (char.IsLetterOrDigit(P_0) || Mcc.Contains(P_0))
		{
			return true;
		}
		if (P_2)
		{
			if (char.IsHighSurrogate(P_0) && P_3 < P_1.Length)
			{
				char c = P_1[P_3];
				if (char.IsLowSurrogate(c))
				{
					P_3++;
					string s = P_0.ToString() + c;
					return char.IsLetterOrDigit(s, 0);
				}
			}
		}
		else
		{
			if (char.IsLowSurrogate(P_0) && P_3 > 0)
			{
				P_0 = P_1[--P_3];
			}
			if (char.IsHighSurrogate(P_0) && P_3 < P_1.Length)
			{
				char c2 = P_1[P_3 + 1];
				if (char.IsLowSurrogate(c2))
				{
					string s2 = P_0.ToString() + c2;
					return char.IsLetterOrDigit(s2, 0);
				}
			}
		}
		return false;
	}

	private bool Lcm(char P_0)
	{
		bool result;
		if (Xch.Contains(P_0))
		{
			result = true;
		}
		else
		{
			UnicodeCategory unicodeCategory = char.GetUnicodeCategory(P_0);
			UnicodeCategory unicodeCategory2 = unicodeCategory;
			if ((uint)(unicodeCategory2 - 25) > 3u)
			{
				result = false;
			}
			else
			{
				result = true;
				int num = 0;
				if (bUI() != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
			}
		}
		return result;
	}

	public int FindCurrentWordEnd(TextSnapshotOffset snapshotOffset)
	{
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		int num = snapshotOffset.Offset;
		ITextSnapshot snapshot = snapshotOffset.Snapshot;
		while (num < snapshot.Length)
		{
			char c = snapshot[num++];
			if (c == '\n')
			{
				return --num;
			}
			if (char.IsWhiteSpace(c))
			{
				if (flag2)
				{
					return --num;
				}
				flag = true;
				continue;
			}
			flag2 = true;
			if (flag)
			{
				return --num;
			}
			if (flag3)
			{
				if (!kc2(c, snapshot, _0020: true, ref num))
				{
					return --num;
				}
			}
			else if (kc2(c, snapshot, _0020: true, ref num))
			{
				flag3 = true;
			}
			else if (char.IsHighSurrogate(c) && num < snapshot.Length)
			{
				char c2 = snapshot[num];
				if (char.IsLowSurrogate(c2))
				{
					num++;
					string s = c.ToString() + c2;
					if (char.IsLetterOrDigit(s, 0))
					{
						flag3 = true;
					}
				}
			}
			if (!Lcm(c))
			{
				continue;
			}
			return num;
		}
		return snapshot.Length;
	}

	public int FindCurrentWordStart(TextSnapshotOffset snapshotOffset)
	{
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		int num = snapshotOffset.Offset;
		ITextSnapshot snapshot = snapshotOffset.Snapshot;
		while (num > 0)
		{
			char c = snapshot[--num];
			if (char.IsWhiteSpace(c))
			{
				if (c == '\n' || flag2)
				{
					return ++num;
				}
				flag = true;
				continue;
			}
			flag2 = true;
			if (flag)
			{
				return ++num;
			}
			if (flag3)
			{
				if (!kc2(c, snapshot, _0020: false, ref num))
				{
					return ++num;
				}
			}
			else if (kc2(c, snapshot, _0020: false, ref num))
			{
				flag3 = true;
			}
			if (!Lcm(c))
			{
				continue;
			}
			return num;
		}
		return 0;
	}

	public int FindNextWordStart(TextSnapshotOffset snapshotOffset)
	{
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		int offset = snapshotOffset.Offset;
		ITextSnapshot snapshot = snapshotOffset.Snapshot;
		while (offset < snapshot.Length)
		{
			char c = snapshot[offset++];
			if (c == '\n' && offset - snapshotOffset.Offset > 1)
			{
				return --offset;
			}
			if (char.IsWhiteSpace(c))
			{
				flag = true;
				continue;
			}
			if (flag || flag3)
			{
				return --offset;
			}
			if (flag2)
			{
				if (!kc2(c, snapshot, _0020: true, ref offset))
				{
					return --offset;
				}
			}
			else if (kc2(c, snapshot, _0020: true, ref offset))
			{
				flag2 = true;
			}
			if (Lcm(c))
			{
				flag3 = true;
			}
		}
		return snapshot.Length;
	}

	public int FindPreviousWordStart(TextSnapshotOffset snapshotOffset)
	{
		bool flag = false;
		bool flag2 = false;
		int num = snapshotOffset.Offset;
		ITextSnapshot snapshot = snapshotOffset.Snapshot;
		while (num > 0)
		{
			char c = snapshot[--num];
			if (c == '\n' && snapshotOffset.Offset - num > 1)
			{
				return ++num;
			}
			if (char.IsWhiteSpace(c))
			{
				if (flag)
				{
					return ++num;
				}
				continue;
			}
			flag = true;
			if (flag2)
			{
				if (!kc2(c, snapshot, _0020: false, ref num))
				{
					return ++num;
				}
			}
			else if (kc2(c, snapshot, _0020: false, ref num))
			{
				flag2 = true;
			}
			if (!Lcm(c))
			{
				continue;
			}
			return num;
		}
		return 0;
	}

	internal static bool xUo()
	{
		return yUl == null;
	}

	internal static DefaultWordBreakFinder bUI()
	{
		return yUl;
	}
}
