using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using ActiproSoftware.Products.Text;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.RegularExpressions;

internal class RegexNode
{
	internal const int Char = 1;

	internal const int NotChar = 2;

	internal const int CharClass = 3;

	internal const int String = 4;

	internal const int DocumentStart = 5;

	internal const int DocumentEnd = 6;

	internal const int LineStart = 7;

	internal const int LineEnd = 8;

	internal const int WordBoundary = 9;

	internal const int NonWordBoundary = 10;

	internal const int Alternation = 16;

	internal const int Concatenation = 17;

	internal const int CapturingGroup = 18;

	internal const int NonCapturingGroup = 19;

	internal const int Comment = 20;

	internal const int PositiveLookAhead = 21;

	internal const int NegativeLookAhead = 22;

	internal const int PositiveLookBehind = 23;

	internal const int NegativeLookBehind = 24;

	internal const int Macro = 25;

	internal const int Substitution = 26;

	internal const int Quantifier = 27;

	internal const int WordChar = 32;

	internal const int NonWordChar = 33;

	internal const int AllChar = 34;

	internal const int NoneChar = 35;

	internal const int AlphaChar = 36;

	internal const int NonAlphaChar = 37;

	internal const int DigitChar = 38;

	internal const int NonDigitChar = 39;

	internal const int HexDigitChar = 40;

	internal const int NonHexDigitChar = 41;

	internal const int WhitespaceChar = 42;

	internal const int NonWhitespaceChar = 43;

	internal const int LineTerminatorChar = 44;

	internal const int NonLineTerminatorChar = 45;

	internal const int LineTerminatorWhitespaceChar = 46;

	internal const int NonLineTerminatorWhitespaceChar = 47;

	internal CaseSensitivity CaseSensitivity;

	internal CharClass CharClassData;

	internal int Maximum;

	internal int Minimum;

	internal int NodeType;

	internal string StringData;

	private List<RegexNode> g8C;

	private static RegexNode vbL;

	internal List<RegexNode> Children
	{
		get
		{
			if (g8C == null)
			{
				g8C = new List<RegexNode>();
			}
			return g8C;
		}
	}

	internal bool HasChildren => g8C != null;

	internal RegexNode(int nodeType)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		CaseSensitivity = CaseSensitivity.Sensitive;
		base._002Ector();
		NodeType = nodeType;
	}

	internal RegexNode(int nodeType, string stringData)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		CaseSensitivity = CaseSensitivity.Sensitive;
		base._002Ector();
		NodeType = nodeType;
		StringData = stringData;
	}

	internal RegexNode(int nodeType, char ch, CaseSensitivity caseSensitivity)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		CaseSensitivity = CaseSensitivity.Sensitive;
		base._002Ector();
		NodeType = nodeType;
		StringData = ch.ToString();
		CaseSensitivity = caseSensitivity;
	}

	internal RegexNode(int nodeType, string stringData, CaseSensitivity caseSensitivity)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		CaseSensitivity = CaseSensitivity.Sensitive;
		base._002Ector();
		NodeType = nodeType;
		StringData = stringData;
		CaseSensitivity = caseSensitivity;
	}

	internal RegexNode(int nodeType, int minimum, int maximum)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		CaseSensitivity = CaseSensitivity.Sensitive;
		base._002Ector();
		NodeType = nodeType;
		Minimum = minimum;
		Maximum = maximum;
	}

	internal RegexNode(int nodeType, RegexNode childNode)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		CaseSensitivity = CaseSensitivity.Sensitive;
		base._002Ector();
		NodeType = nodeType;
		Children.Add(childNode);
	}

	internal RegexNode(CharClass charClass, bool isComplement)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		CaseSensitivity = CaseSensitivity.Sensitive;
		base._002Ector();
		if (charClass.IsSingleCharacter)
		{
			NodeType = ((!isComplement) ? 1 : 2);
			StringData = charClass[0].Start.ToString();
			return;
		}
		NodeType = 3;
		if (isComplement)
		{
			charClass.IsNegated = !charClass.IsNegated;
		}
		StringData = charClass.ToLookupString();
		CharClassData = charClass;
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	internal RegexNode ExpandMacros(IRegexMacroMap macroMap)
	{
		if (NodeType == 25)
		{
			if (macroMap != null)
			{
				RegexNode regexNodeForMacro = macroMap.GetRegexNodeForMacro(StringData);
				if (regexNodeForMacro != null)
				{
					return regexNodeForMacro;
				}
			}
			string text = StringData;
			if (text != null && text.EndsWith(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7154), StringComparison.Ordinal))
			{
				text = text.Substring(0, text.Length - 5);
			}
			string text2 = text;
			string text3 = text2;
			switch (global::_003CPrivateImplementationDetails_003E.ComputeStringHash(text3))
			{
			case 1058975764u:
				if (!(text3 == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7168)))
				{
					break;
				}
				return new RegexNode(33);
			case 3938792989u:
				if (!(text3 == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7186)))
				{
					break;
				}
				return new RegexNode(32);
			case 55079499u:
				if (!(text3 == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7198)))
				{
					break;
				}
				return new RegexNode(36);
			case 1091300086u:
				if (!(text3 == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7212)))
				{
					break;
				}
				return new RegexNode(38);
			case 66056256u:
				if (!(text3 == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7226)))
				{
					break;
				}
				return new RegexNode(42);
			case 3969203378u:
				if (!(text3 == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7250)))
				{
					break;
				}
				return new RegexNode(44);
			case 1276283051u:
				if (!(text3 == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7282)))
				{
					break;
				}
				return new RegexNode(46);
			case 3945569440u:
				if (!(text3 == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7334)))
				{
					break;
				}
				return new RegexNode(37);
			case 1950800609u:
				if (!(text3 == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7354)))
				{
					break;
				}
				return new RegexNode(39);
			case 2481779275u:
				if (!(text3 == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7374)))
				{
					break;
				}
				return new RegexNode(45);
			case 1273607162u:
				if (!(text3 == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7412)))
				{
					break;
				}
				return new RegexNode(47);
			case 2120573545u:
				if (!(text3 == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7470)))
				{
					break;
				}
				return new RegexNode(43);
			case 3402511527u:
				if (!(text3 == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7500)))
				{
					break;
				}
				return new RegexNode(40);
			case 4190955562u:
				if (!(text3 == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7520)))
				{
					break;
				}
				return new RegexNode(41);
			case 1974461284u:
				if (!(text3 == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7546)))
				{
					break;
				}
				return new RegexNode(34);
			case 810547195u:
				if (!(text3 == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7556)))
				{
					break;
				}
				return new RegexNode(35);
			}
			throw new InvalidRegexPatternException(string.Format(CultureInfo.CurrentCulture, SR.GetString(SRName.ExInvalidMacroKey), new object[1] { StringData }));
		}
		if (g8C != null)
		{
			for (int num = g8C.Count - 1; num >= 0; num--)
			{
				g8C[num] = g8C[num].ExpandMacros(macroMap);
			}
		}
		return this;
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	internal bool GetPrefixCharacters(CharClass prefixChars)
	{
		switch (NodeType)
		{
		case 34:
			prefixChars.AddRange(ActiproSoftware.Text.RegularExpressions.CharClass.All);
			return true;
		case 36:
			prefixChars.AddRange(ActiproSoftware.Text.RegularExpressions.CharClass.Alpha);
			return true;
		case 16:
		{
			CharClass charClass = new CharClass();
			foreach (RegexNode child in Children)
			{
				if (!child.GetPrefixCharacters(charClass))
				{
					return false;
				}
			}
			prefixChars.AddRange(charClass);
			return true;
		}
		case 1:
			if (CaseSensitivity == CaseSensitivity.Sensitive || !char.IsLetter(StringData[0]))
			{
				prefixChars.Add(StringData[0]);
			}
			else
			{
				prefixChars.Add(char.ToLowerInvariant(StringData[0]));
				prefixChars.Add(char.ToUpperInvariant(StringData[0]));
			}
			return true;
		case 3:
			prefixChars.AddRange(CharClassData);
			return true;
		case 17:
			foreach (RegexNode child2 in Children)
			{
				if (!child2.GetPrefixCharacters(prefixChars))
				{
					return false;
				}
				if (prefixChars.Count > 0)
				{
					return true;
				}
			}
			return true;
		case 38:
			prefixChars.AddRange(ActiproSoftware.Text.RegularExpressions.CharClass.Digit);
			return true;
		case 44:
			prefixChars.AddRange(ActiproSoftware.Text.RegularExpressions.CharClass.LineTerminator);
			return true;
		case 46:
			prefixChars.AddRange(ActiproSoftware.Text.RegularExpressions.CharClass.LineTerminatorWhitespace);
			return true;
		case 40:
			prefixChars.AddRange(ActiproSoftware.Text.RegularExpressions.CharClass.HexDigit);
			return true;
		case 37:
			prefixChars.AddRange(ActiproSoftware.Text.RegularExpressions.CharClass.NonAlpha);
			return true;
		case 2:
		{
			CharClass charClass2 = new CharClass();
			if (CaseSensitivity == CaseSensitivity.Sensitive || !char.IsLetter(StringData[0]))
			{
				charClass2.Add(StringData[0]);
			}
			else
			{
				charClass2.Add(char.ToLowerInvariant(StringData[0]));
				charClass2.Add(char.ToUpperInvariant(StringData[0]));
			}
			charClass2.IsNegated = !charClass2.IsNegated;
			prefixChars.AddRange(charClass2);
			return true;
		}
		case 39:
			prefixChars.AddRange(ActiproSoftware.Text.RegularExpressions.CharClass.NonDigit);
			return true;
		case 41:
			prefixChars.AddRange(ActiproSoftware.Text.RegularExpressions.CharClass.NonHexDigit);
			return true;
		case 45:
			prefixChars.AddRange(ActiproSoftware.Text.RegularExpressions.CharClass.NonLineTerminator);
			return true;
		case 47:
			prefixChars.AddRange(ActiproSoftware.Text.RegularExpressions.CharClass.NonLineTerminatorWhitespace);
			return true;
		case 43:
			prefixChars.AddRange(ActiproSoftware.Text.RegularExpressions.CharClass.NonWhitespace);
			return true;
		case 33:
			prefixChars.AddRange(ActiproSoftware.Text.RegularExpressions.CharClass.NonWord);
			return true;
		case 27:
			if (Minimum == 0 || Children.Count == 0)
			{
				return false;
			}
			return g8C[0].GetPrefixCharacters(prefixChars);
		case 4:
			if (CaseSensitivity == CaseSensitivity.Sensitive || !char.IsLetter(StringData[0]))
			{
				prefixChars.Add(StringData[0]);
			}
			else
			{
				prefixChars.Add(char.ToLowerInvariant(StringData[0]));
				prefixChars.Add(char.ToUpperInvariant(StringData[0]));
			}
			return true;
		case 42:
			prefixChars.AddRange(ActiproSoftware.Text.RegularExpressions.CharClass.Whitespace);
			return true;
		case 32:
			prefixChars.AddRange(ActiproSoftware.Text.RegularExpressions.CharClass.Word);
			return true;
		case 18:
		case 19:
			if (Children.Count == 1)
			{
				return Children[0].GetPrefixCharacters(prefixChars);
			}
			return true;
		case 5:
		case 6:
		case 7:
		case 8:
		case 9:
		case 10:
		case 20:
		case 21:
		case 22:
		case 23:
		case 24:
			return true;
		default:
			return false;
		}
	}

	internal RegexNode Quantify(int minimum, int maximum)
	{
		if (minimum == 1 && maximum == 1)
		{
			return this;
		}
		RegexNode regexNode = new RegexNode(27, minimum, maximum);
		regexNode.Children.Add(this);
		return regexNode;
	}

	internal RegexNode Reduce()
	{
		RegexNode result = this;
		if (g8C != null)
		{
			for (int i = 0; i < g8C.Count; i++)
			{
				g8C[i] = g8C[i].Reduce();
				if (NodeType == 17 && g8C[i].NodeType == 17)
				{
					RegexNode regexNode = g8C[i];
					g8C.RemoveAt(i);
					g8C.InsertRange(i, regexNode.Children);
					i += regexNode.Children.Count - 1;
				}
			}
		}
		int nodeType = NodeType;
		int num = nodeType;
		if (num == 17 && g8C != null && g8C.Count > 0)
		{
			int nodeType2 = g8C[0].NodeType;
			int num2 = nodeType2;
			bool flag = ((num2 == 1 || num2 == 4) ? true : false);
			for (int j = 1; j < g8C.Count; j++)
			{
				int nodeType3 = g8C[j].NodeType;
				int num3 = nodeType3;
				bool flag2 = ((num3 == 1 || num3 == 4) ? true : false);
				if (flag && flag2)
				{
					g8C[j - 1].NodeType = 4;
					g8C[j - 1].StringData = g8C[j - 1].StringData + g8C[j].StringData;
					g8C.RemoveAt(j);
					j--;
				}
				flag = flag2;
			}
			if (g8C.Count == 1)
			{
				result = g8C[0];
			}
		}
		return result;
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	internal void ValidateMacros(HashSet<string> macroKeys)
	{
		if (NodeType == 25)
		{
			if (macroKeys != null && macroKeys.Contains(StringData))
			{
				return;
			}
			string text = StringData;
			if (text != null && text.EndsWith(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7154), StringComparison.Ordinal))
			{
				text = text.Substring(0, text.Length - 5);
			}
			string text2 = text;
			string text3 = text2;
			switch (global::_003CPrivateImplementationDetails_003E.ComputeStringHash(text3))
			{
			case 1058975764u:
				if (!(text3 == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7168)))
				{
					break;
				}
				return;
			case 3938792989u:
				if (!(text3 == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7186)))
				{
					break;
				}
				return;
			case 55079499u:
				if (!(text3 == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7198)))
				{
					break;
				}
				return;
			case 1091300086u:
				if (!(text3 == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7212)))
				{
					break;
				}
				return;
			case 66056256u:
				if (!(text3 == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7226)))
				{
					break;
				}
				return;
			case 3969203378u:
				if (!(text3 == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7250)))
				{
					break;
				}
				return;
			case 1276283051u:
				if (!(text3 == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7282)))
				{
					break;
				}
				return;
			case 3945569440u:
				if (!(text3 == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7334)))
				{
					break;
				}
				return;
			case 1950800609u:
				if (!(text3 == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7354)))
				{
					break;
				}
				return;
			case 2481779275u:
				if (!(text3 == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7374)))
				{
					break;
				}
				return;
			case 1273607162u:
				if (!(text3 == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7412)))
				{
					break;
				}
				return;
			case 2120573545u:
				if (!(text3 == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7470)))
				{
					break;
				}
				return;
			case 3402511527u:
				if (!(text3 == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7500)))
				{
					break;
				}
				return;
			case 4190955562u:
				if (!(text3 == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7520)))
				{
					break;
				}
				return;
			case 1974461284u:
				if (!(text3 == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7546)))
				{
					break;
				}
				return;
			case 810547195u:
				if (!(text3 == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7556)))
				{
					break;
				}
				return;
			}
			throw new InvalidRegexPatternException(string.Format(CultureInfo.CurrentCulture, SR.GetString(SRName.ExInvalidMacroKey), new object[1] { StringData }));
		}
		if (g8C != null)
		{
			for (int num = g8C.Count - 1; num >= 0; num--)
			{
				g8C[num].ValidateMacros(macroKeys);
			}
		}
	}

	internal static bool Vbs()
	{
		return vbL == null;
	}

	internal static RegexNode Yb4()
	{
		return vbL;
	}
}
