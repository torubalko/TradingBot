using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using ActiproSoftware.Products.Text;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.RegularExpressions;

internal class RegexParser
{
	private bool E84;

	private CaseSensitivity P8K;

	private bool B8k;

	private string r8E;

	private int P8r;

	private static RegexParser FbK;

	private void f8U(RegexNode P_0, RegexNode P_1)
	{
		RegexNode regexNode;
		RegexNode regexNode2;
		bool flag;
		int num;
		if (P_0.Children.Count > 0)
		{
			regexNode = P_0.Children[P_0.Children.Count - 1];
			if (regexNode.NodeType == 16 && regexNode.Children.Count > 0)
			{
				regexNode2 = regexNode.Children[regexNode.Children.Count - 1];
				flag = regexNode2.NodeType == 17;
				num = 0;
				if (Tbo() != null)
				{
					goto IL_0005;
				}
				goto IL_0009;
			}
		}
		P_0.Children.Add(p8Z(P_1));
		return;
		IL_0009:
		RegexNode regexNode3 = default(RegexNode);
		do
		{
			switch (num)
			{
			default:
				if (flag)
				{
					regexNode2.Children.Add(p8Z(P_1));
					return;
				}
				break;
			case 1:
				regexNode.Children[regexNode.Children.Count - 1] = regexNode3;
				return;
			}
			regexNode3 = new RegexNode(17);
			regexNode3.Children.Add(regexNode2);
			regexNode3.Children.Add(p8Z(P_1));
			num = 1;
		}
		while (Tbo() == null);
		goto IL_0005;
		IL_0005:
		int num2 = default(int);
		num = num2;
		goto IL_0009;
	}

	private static byte i8a(char P_0)
	{
		if (char.IsNumber(P_0))
		{
			return byte.Parse(P_0.ToString(), CultureInfo.InvariantCulture);
		}
		if (WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7568).IndexOf(P_0.ToString(), StringComparison.OrdinalIgnoreCase) == -1)
		{
			throw new InvalidRegexPatternException(SR.GetString(SRName.ExInvalidEncodedCharacter));
		}
		return (byte)(10 + (P_0.ToString().ToUpperInvariant()[0] - 65));
	}

	private void p8j(out char P_0, out bool P_1)
	{
		P_0 = n8l();
		if (P_0 == '\\' && !C8D())
		{
			P_1 = true;
			P_0 = U8g();
			switch (P_0)
			{
			case 'a':
				P_0 = Convert.ToChar(7);
				n8l();
				return;
			case 'e':
				P_0 = Convert.ToChar(27);
				n8l();
				return;
			case 'f':
				P_0 = Convert.ToChar(12);
				n8l();
				return;
			case 'n':
				P_0 = Convert.ToChar(10);
				n8l();
				return;
			case 'r':
				P_0 = Convert.ToChar(13);
				n8l();
				return;
			case 't':
				P_0 = Convert.ToChar(9);
				n8l();
				return;
			case 'u':
			{
				int num2 = 0;
				n8l();
				for (int j = 0; j < 4; j++)
				{
					P_0 = n8l();
					byte b2 = i8a(P_0);
					num2 |= b2 << (3 - j) * 4;
				}
				P_0 = Convert.ToChar(num2);
				return;
			}
			case 'v':
				P_0 = Convert.ToChar(11);
				n8l();
				return;
			case 'x':
			{
				int num = 0;
				n8l();
				for (int i = 0; i < 2; i++)
				{
					P_0 = n8l();
					byte b = i8a(P_0);
					num |= b << (1 - i) * 4;
				}
				P_0 = Convert.ToChar(num);
				return;
			}
			}
			string text = y8O(3);
			if (text.Length == 3)
			{
				int num3 = h8F(text);
				if (num3 != -1)
				{
					P_0 = Convert.ToChar(num3);
					t8o(3);
					return;
				}
			}
			P_0 = n8l();
		}
		else
		{
			P_1 = false;
		}
	}

	[SpecialName]
	private bool C8D()
	{
		return P8r >= r8E.Length;
	}

	private static int h8F(string P_0)
	{
		int num = 0;
		int num2 = 0;
		int num4 = default(int);
		while (num2 < P_0.Length)
		{
			if (WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7584).IndexOf(P_0[num2]) == -1)
			{
				return -1;
			}
			num |= i8a(P_0[num2]) << (P_0.Length - 1 - num2) * 3;
			num2++;
			int num3 = 0;
			if (Tbo() != null)
			{
				num3 = num4;
			}
			switch (num3)
			{
			}
		}
		return num;
	}

	internal RegexNode ParsePattern(string requestPattern, bool requestAllowCapturing, bool requestIsReplacementPattern, CaseSensitivity requestCaseSensitivity)
	{
		return K8x(requestPattern, requestAllowCapturing, requestIsReplacementPattern, requestCaseSensitivity).Reduce();
	}

	internal RegexNode ParsePatternAndExpandMacros(string requestPattern, bool requestAllowCapturing, bool requestIsReplacementPattern, IRegexMacroMap macroMap, CaseSensitivity requestCaseSensitivity)
	{
		RegexNode regexNode = K8x(requestPattern, requestAllowCapturing, requestIsReplacementPattern, requestCaseSensitivity);
		regexNode = regexNode.ExpandMacros(macroMap);
		return regexNode.Reduce();
	}

	private RegexNode K8x(string P_0, bool P_1, bool P_2, CaseSensitivity P_3)
	{
		r8E = P_0;
		E84 = P_1;
		B8k = P_2;
		P8r = 0;
		P8K = P_3;
		return b86(0, _0020: false);
	}

	private char U8g()
	{
		return r8E[P8r];
	}

	private string y8O(int P_0)
	{
		string text = string.Empty;
		int num = 0;
		int num3 = default(int);
		while (num < P_0 && P8r + num < r8E.Length)
		{
			text += r8E[P8r + num];
			num++;
			int num2 = 0;
			if (Tbo() != null)
			{
				num2 = num3;
			}
			switch (num2)
			{
			}
		}
		return text;
	}

	private char n8l()
	{
		return r8E[P8r++];
	}

	private RegexNode W8i()
	{
		string text = string.Empty;
		if (C8D())
		{
			throw new InvalidRegexPatternException(SR.GetString(SRName.ExRegexParserUnexpectedGroupingConstructEnd));
		}
		char c = n8l();
		bool flag;
		switch (c)
		{
		case '#':
			n8l();
			while (true)
			{
				if (C8D())
				{
					throw new InvalidRegexPatternException(SR.GetString(SRName.ExRegexParserUnexpectedGroupingConstructEnd));
				}
				p8j(out c, out flag);
				if (c == ')')
				{
					break;
				}
				text += c;
			}
			return new RegexNode(20, text);
		case '!':
		case '=':
			return new RegexNode((c == '=') ? 21 : 22, b86(P8r, _0020: false));
		case '<':
			if (C8D())
			{
				throw new InvalidRegexPatternException(SR.GetString(SRName.ExRegexParserUnexpectedLookBehindConstructEnd));
			}
			p8j(out c, out flag);
			return new RegexNode((c == '=') ? 23 : 24, b86(P8r, _0020: false));
		default:
			throw new InvalidRegexPatternException(SR.GetString(SRName.ExRegexParserUnknownGroupingConstruct));
		}
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	private RegexNode x8W()
	{
		bool isComplement = false;
		CharClass charClass = new CharClass();
		if (C8D())
		{
			throw new InvalidRegexPatternException(SR.GetString(SRName.ExRegexParserUnexpectedCharClassEnd));
		}
		if (U8g() == '^')
		{
			n8l();
			isComplement = true;
		}
		while (true)
		{
			if (C8D())
			{
				throw new InvalidRegexPatternException(SR.GetString(SRName.ExRegexParserUnexpectedCharClassEnd));
			}
			p8j(out var c, out var flag);
			if (!flag && c == ']')
			{
				break;
			}
			if (flag && WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7604).IndexOf(c) != -1)
			{
				switch (c)
				{
				case 'd':
					charClass.AddRange(CharClass.Digit);
					break;
				case 'p':
					try
					{
						charClass.AddCategory(a8Y(), negate: false);
					}
					catch (ArgumentException)
					{
						throw new InvalidRegexPatternException(SR.GetString(SRName.ExInvalidUnicodeCategoryName));
					}
					break;
				case 's':
					charClass.AddRange(CharClass.LineTerminatorWhitespace);
					break;
				case 'w':
					charClass.AddRange(CharClass.Word);
					break;
				case 'D':
					charClass.AddRange(CharClass.NonDigit);
					break;
				case 'P':
					try
					{
						charClass.AddCategory(a8Y(), negate: true);
					}
					catch (ArgumentException)
					{
						throw new InvalidRegexPatternException(SR.GetString(SRName.ExInvalidUnicodeCategoryName));
					}
					break;
				case 'S':
					charClass.AddRange(CharClass.NonLineTerminatorWhitespace);
					break;
				case 'W':
					charClass.AddRange(CharClass.NonWord);
					break;
				}
			}
			else if (!C8D() && U8g() == '-')
			{
				n8l();
				p8j(out var c2, out flag);
				charClass.Add(c, c2);
				if (P8K == CaseSensitivity.Sensitive)
				{
					continue;
				}
				char c3 = c;
				while (c3 <= c2 && c3 < '\uffff')
				{
					if (char.IsLower(c3))
					{
						char ch = char.ToUpperInvariant(c3);
						if (!charClass.Contains(ch))
						{
							charClass.Add(ch);
						}
					}
					else if (char.IsUpper(c3))
					{
						char ch = char.ToLowerInvariant(c3);
						if (!charClass.Contains(ch))
						{
							charClass.Add(ch);
						}
					}
					c3 = (char)(c3 + 1);
				}
			}
			else if (P8K == CaseSensitivity.Sensitive || !char.IsLetter(c))
			{
				charClass.Add(c);
			}
			else
			{
				charClass.Add(char.ToUpperInvariant(c));
				charClass.Add(char.ToLowerInvariant(c));
			}
		}
		return new RegexNode(charClass, isComplement);
	}

	private RegexNode D85()
	{
		string text = string.Empty;
		while (true)
		{
			if (C8D())
			{
				throw new InvalidRegexPatternException(SR.GetString(SRName.ExRegexParserUnexpectedMacroReferenceEnd));
			}
			p8j(out var c, out var flag);
			if (!flag && c == '}')
			{
				break;
			}
			text += c;
		}
		return new RegexNode(25, text);
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	private RegexNode b86(int P_0, bool P_1)
	{
		RegexNode regexNode = new RegexNode(17);
		P8r = P_0;
		bool flag = P_1;
		while (!C8D())
		{
			P_0 = P8r;
			p8j(out var c, out var flag2);
			if (!B8k)
			{
				if (flag2)
				{
					switch (c)
					{
					case 'b':
						f8U(regexNode, new RegexNode(9));
						break;
					case 'd':
						f8U(regexNode, new RegexNode(38));
						break;
					case 'p':
					{
						CharClass charClass2 = new CharClass();
						try
						{
							charClass2.AddCategory(a8Y(), negate: false);
						}
						catch (ArgumentException)
						{
							throw new InvalidRegexPatternException(SR.GetString(SRName.ExInvalidUnicodeCategoryName));
						}
						f8U(regexNode, new RegexNode(charClass2, isComplement: false));
						break;
					}
					case 's':
						f8U(regexNode, new RegexNode(46));
						break;
					case 'w':
						f8U(regexNode, new RegexNode(32));
						break;
					case 'z':
						f8U(regexNode, new RegexNode(6));
						break;
					case 'A':
						f8U(regexNode, new RegexNode(5));
						break;
					case 'B':
						f8U(regexNode, new RegexNode(10));
						break;
					case 'D':
						f8U(regexNode, new RegexNode(39));
						break;
					case 'P':
					{
						CharClass charClass = new CharClass();
						try
						{
							charClass.AddCategory(a8Y(), negate: true);
						}
						catch (ArgumentException)
						{
							throw new InvalidRegexPatternException(SR.GetString(SRName.ExInvalidUnicodeCategoryName));
						}
						f8U(regexNode, new RegexNode(charClass, isComplement: false));
						break;
					}
					case 'S':
						f8U(regexNode, new RegexNode(47));
						break;
					case 'W':
						f8U(regexNode, new RegexNode(33));
						break;
					default:
						f8U(regexNode, new RegexNode(1, c, P8K));
						break;
					}
				}
				else
				{
					switch (c)
					{
					case '\t':
					case '\n':
					case '\r':
					case ' ':
						continue;
					case '.':
						f8U(regexNode, new RegexNode(2, '\n', CaseSensitivity.Sensitive));
						break;
					case '^':
						f8U(regexNode, new RegexNode(7));
						break;
					case '$':
						f8U(regexNode, new RegexNode(8));
						break;
					case '"':
						f8U(regexNode, u80());
						break;
					case '[':
						f8U(regexNode, x8W());
						break;
					case '{':
						if (E84)
						{
							f8U(regexNode, new RegexNode(1, '{', P8K));
						}
						else
						{
							f8U(regexNode, D85());
						}
						break;
					case '(':
						if (!C8D() && U8g() == '?')
						{
							n8l();
							f8U(regexNode, W8i());
						}
						else
						{
							RegexNode regexNode4 = new RegexNode(E84 ? 18 : 19);
							regexNode4.Children.Add(b86(P8r, _0020: false));
							f8U(regexNode, regexNode4);
						}
						break;
					case ')':
						flag = true;
						break;
					case '|':
					{
						if (regexNode.Children.Count == 0)
						{
							throw new InvalidRegexPatternException(SR.GetString(SRName.ExRegexParserNoLeftExpressionForBarOperand));
						}
						RegexNode regexNode2 = regexNode.Children[regexNode.Children.Count - 1];
						if (regexNode2.NodeType == 16)
						{
							regexNode2.Children.Add(b86(P8r, _0020: true));
							break;
						}
						int num = regexNode.Children.Count - 1;
						while (num >= 0 && regexNode.Children[num].NodeType != 16)
						{
							num--;
						}
						regexNode2 = new RegexNode(17);
						for (int i = num + 1; i < regexNode.Children.Count; i++)
						{
							regexNode2.Children.Add(regexNode.Children[i]);
						}
						regexNode.Children.RemoveRange(num + 1, regexNode.Children.Count - (num + 1));
						RegexNode regexNode3 = new RegexNode(16);
						regexNode3.Children.Add(regexNode2);
						regexNode3.Children.Add(b86(P8r, _0020: true));
						regexNode.Children.Add(regexNode3);
						break;
					}
					default:
						f8U(regexNode, new RegexNode(1, c, P8K));
						break;
					}
				}
			}
			else if (c == '$' && !flag2)
			{
				regexNode.Children.Add(U8v());
			}
			else
			{
				regexNode.Children.Add(new RegexNode(1, c, P8K));
			}
			if (!flag)
			{
				continue;
			}
			break;
		}
		if (regexNode.Children.Count == 0)
		{
			throw new InvalidRegexPatternException(SR.GetString(SRName.ExRegexParserNoRegularExpression));
		}
		if (regexNode.NodeType == 17 && regexNode.Children.Count == 1)
		{
			return regexNode.Children[0];
		}
		return regexNode;
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	private RegexNode p8Z(RegexNode P_0)
	{
		if (C8D())
		{
			return P_0;
		}
		char c = U8g();
		switch (c)
		{
		case '*':
		case '+':
		case '?':
		case '{':
			n8l();
			switch (c)
			{
			case '+':
				P_0 = P_0.Quantify(1, int.MaxValue);
				break;
			case '*':
				P_0 = P_0.Quantify(0, int.MaxValue);
				break;
			case '?':
				P_0 = P_0.Quantify(0, 1);
				break;
			case '{':
			{
				string text = string.Empty;
				string text2 = string.Empty;
				bool flag = false;
				bool flag2 = false;
				while (!flag2)
				{
					if (C8D())
					{
						throw new InvalidRegexPatternException(SR.GetString(SRName.ExRegexParserUnexpectedRangeEnd));
					}
					c = n8l();
					switch (c)
					{
					case '}':
						if (text.Length == 0)
						{
							throw new InvalidRegexPatternException(SR.GetString(SRName.ExRegexParserNoRangeMinimum));
						}
						P_0 = ((text2.Length != 0) ? P_0.Quantify(int.Parse(text, CultureInfo.InvariantCulture), int.Parse(text2, CultureInfo.InvariantCulture)) : ((!flag) ? P_0.Quantify(int.Parse(text, CultureInfo.InvariantCulture), int.Parse(text, CultureInfo.InvariantCulture)) : P_0.Quantify(int.Parse(text, CultureInfo.InvariantCulture), int.MaxValue)));
						flag2 = true;
						break;
					case ',':
						flag = true;
						break;
					case '0':
					case '1':
					case '2':
					case '3':
					case '4':
					case '5':
					case '6':
					case '7':
					case '8':
					case '9':
						if (flag)
						{
							text2 += c;
						}
						else
						{
							text += c;
						}
						break;
					default:
						throw new InvalidRegexPatternException(string.Format(CultureInfo.CurrentCulture, SR.GetString(SRName.ExRegexParserInvalidRangeCharacter), new object[1] { c }));
					}
				}
				break;
			}
			}
			return P_0;
		default:
			return P_0;
		}
	}

	private RegexNode u80()
	{
		string text = string.Empty;
		int num2 = default(int);
		while (!C8D())
		{
			p8j(out var c, out var flag);
			if (flag || c != '"')
			{
				text += c;
				continue;
			}
			if (text.Length == 0)
			{
				throw new InvalidRegexPatternException(SR.GetString(SRName.ExRegexParserEmptyQuotedString));
			}
			RegexNode regexNode = new RegexNode(4, text, P8K);
			int num = 0;
			if (Tbo() != null)
			{
				num = num2;
			}
			return num switch
			{
				_ => regexNode, 
			};
		}
		throw new InvalidRegexPatternException(SR.GetString(SRName.ExRegexParserUnexpectedQuotedStringEnd));
	}

	private RegexNode U8v()
	{
		string text = string.Empty;
		while (!C8D())
		{
			char c = U8g();
			if (c == '0' || !char.IsDigit(c))
			{
				if (text.Length == 0)
				{
					switch (c)
					{
					case '$':
						n8l();
						return new RegexNode(1, '$', CaseSensitivity.Sensitive);
					case '&':
					case '0':
						n8l();
						return new RegexNode(26, WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6510));
					}
				}
				break;
			}
			n8l();
			text += c;
		}
		if (text.Length == 0)
		{
			throw new InvalidRegexPatternException(SR.GetString(SRName.ExRegexParserInvalidSubstitutionGroupNumber));
		}
		return new RegexNode(26, text);
	}

	private string a8Y()
	{
		string text = string.Empty;
		if (C8D())
		{
			throw new InvalidRegexPatternException(SR.GetString(SRName.ExRegexParserOpenCurlyBraceExpected));
		}
		char c = n8l();
		if (c != '{')
		{
			throw new InvalidRegexPatternException(SR.GetString(SRName.ExRegexParserOpenCurlyBraceExpected));
		}
		bool flag = default(bool);
		int num2 = default(int);
		while (!C8D())
		{
			c = n8l();
			int num = 1;
			if (Tbo() != null)
			{
				num = 1;
			}
			while (true)
			{
				switch (num)
				{
				default:
					if (flag)
					{
						throw new InvalidRegexPatternException(SR.GetString(SRName.ExInvalidUnicodeCategoryName));
					}
					goto end_IL_0009;
				case 1:
					break;
				}
				if (c == '}')
				{
					goto end_IL_0112;
				}
				flag = !char.IsLetter(c);
				num = 0;
				if (!pbl())
				{
					num = num2;
				}
				continue;
				end_IL_0009:
				break;
			}
			text += c;
			continue;
			end_IL_0112:
			break;
		}
		return text;
	}

	private void t8o(int P_0)
	{
		P8r = Math.Min(r8E.Length, P8r + P_0);
	}

	public RegexParser()
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
	}

	internal static bool pbl()
	{
		return FbK == null;
	}

	internal static RegexParser Tbo()
	{
		return FbK;
	}
}
