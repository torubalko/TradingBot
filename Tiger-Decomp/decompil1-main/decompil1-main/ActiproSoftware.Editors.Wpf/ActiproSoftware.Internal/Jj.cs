using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using ActiproSoftware.Products.Editors;

namespace ActiproSoftware.Internal;

internal class Jj
{
	private fw qo1;

	private string qo8;

	private int Tor;

	internal static Jj Da0;

	private void eob(XA P_0, XA P_1)
	{
		if (P_0.Poe().Count > 0)
		{
			XA xA = P_0.Poe()[P_0.Poe().Count - 1];
			if (xA.poh == 16 && xA.Poe().Count > 0)
			{
				XA xA2 = xA.Poe()[xA.Poe().Count - 1];
				if (xA2.poh == 17)
				{
					xA2.Poe().Add(OoL(P_1));
					return;
				}
				XA xA3 = new XA(17);
				xA3.Poe().Add(xA2);
				xA3.Poe().Add(OoL(P_1));
				xA.Poe()[xA.Poe().Count - 1] = xA3;
				return;
			}
		}
		P_0.Poe().Add(OoL(P_1));
	}

	private static byte HoD(char P_0)
	{
		if (char.IsNumber(P_0))
		{
			return byte.Parse(P_0.ToString(), CultureInfo.InvariantCulture);
		}
		if (QdM.AR8(23682).IndexOf(P_0.ToString(), StringComparison.OrdinalIgnoreCase) != -1)
		{
			return (byte)(10 + (P_0.ToString().ToUpperInvariant()[0] - 65));
		}
		throw new oG(SR.GetString(SRName.ExInvalidEncodedCharacter));
	}

	private void IoG(out char P_0, out bool P_1)
	{
		P_0 = to9();
		if (P_0 == '\\' && !nom())
		{
			P_1 = true;
			P_0 = ToR();
			switch (P_0)
			{
			case 'a':
				P_0 = Convert.ToChar(7);
				to9();
				return;
			case 'e':
				P_0 = Convert.ToChar(27);
				to9();
				return;
			case 'f':
				P_0 = Convert.ToChar(12);
				to9();
				return;
			case 'n':
				P_0 = Convert.ToChar(10);
				to9();
				return;
			case 'r':
				P_0 = Convert.ToChar(13);
				to9();
				return;
			case 't':
				P_0 = Convert.ToChar(9);
				to9();
				return;
			case 'u':
			{
				int num2 = 0;
				to9();
				for (int j = 0; j < 4; j++)
				{
					P_0 = to9();
					byte b2 = HoD(P_0);
					num2 |= b2 << (3 - j) * 4;
				}
				P_0 = Convert.ToChar(num2);
				return;
			}
			case 'v':
				P_0 = Convert.ToChar(11);
				to9();
				return;
			case 'x':
			{
				int num = 0;
				to9();
				for (int i = 0; i < 2; i++)
				{
					P_0 = to9();
					byte b = HoD(P_0);
					num |= b << (1 - i) * 4;
				}
				P_0 = Convert.ToChar(num);
				return;
			}
			}
			string text = Xod(3);
			if (text.Length == 3)
			{
				int num3 = moq(text);
				if (num3 != -1)
				{
					P_0 = Convert.ToChar(num3);
					Ooy(3);
					return;
				}
			}
			P_0 = to9();
		}
		else
		{
			P_1 = false;
		}
	}

	[SpecialName]
	private bool nom()
	{
		return Tor >= qo8.Length;
	}

	private static int moq(string P_0)
	{
		int num = 0;
		for (int i = 0; i < P_0.Length; i++)
		{
			if (QdM.AR8(23698).IndexOf(P_0[i]) == -1)
			{
				return -1;
			}
			num |= HoD(P_0[i]) << (P_0.Length - 1 - i) * 3;
		}
		return num;
	}

	internal XA pou(string P_0, fw P_1)
	{
		return FoK(P_0, P_1).LoJ();
	}

	private XA FoK(string P_0, fw P_1)
	{
		qo8 = P_0;
		Tor = 0;
		qo1 = P_1;
		return QoH(0, _0020: false);
	}

	private char ToR()
	{
		return qo8[Tor];
	}

	private string Xod(int P_0)
	{
		string text = string.Empty;
		for (int i = 0; i < P_0 && Tor + i < qo8.Length; i++)
		{
			text += qo8[Tor + i];
		}
		return text;
	}

	private char to9()
	{
		return qo8[Tor++];
	}

	private XA Eo5()
	{
		string text = string.Empty;
		if (nom())
		{
			throw new oG(SR.GetString(SRName.ExRegexParserUnexpectedGroupingConstructEnd));
		}
		char c = to9();
		char c2 = c;
		char c3 = c2;
		int num;
		bool flag;
		XA result = default(XA);
		if ((uint)c3 <= 35u)
		{
			if (c3 != '!')
			{
				if (c3 != '#')
				{
					goto IL_0170;
				}
				to9();
				goto IL_00e6;
			}
		}
		else
		{
			if (c3 == '<')
			{
				if (nom())
				{
					num = 2;
					goto IL_0009;
				}
				IoG(out c, out flag);
				result = new XA((c == '=') ? 23 : 24, QoH(Tor, _0020: false));
				goto IL_017d;
			}
			if (c3 != '=')
			{
				goto IL_0170;
			}
		}
		result = new XA((c == '=') ? 21 : 22, QoH(Tor, _0020: false));
		goto IL_017d;
		IL_00e6:
		if (nom())
		{
			throw new oG(SR.GetString(SRName.ExRegexParserUnexpectedGroupingConstructEnd));
		}
		IoG(out c, out flag);
		bool flag2 = c == ')';
		num = 1;
		if (iaw() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		goto IL_0009;
		IL_0170:
		throw new oG(SR.GetString(SRName.ExRegexParserUnknownGroupingConstruct));
		IL_0009:
		while (true)
		{
			switch (num)
			{
			case 1:
				if (flag2)
				{
					goto default;
				}
				goto IL_022f;
			default:
				result = new XA(20, text);
				num = 3;
				continue;
			case 3:
				break;
			case 2:
				throw new oG(SR.GetString(SRName.ExRegexParserUnexpectedLookBehindConstructEnd));
			}
			break;
		}
		goto IL_017d;
		IL_022f:
		text += c;
		goto IL_00e6;
		IL_017d:
		return result;
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	private XA toc()
	{
		bool flag = false;
		u2 u3 = new u2();
		u2 u4 = new u2();
		if (nom())
		{
			throw new oG(SR.GetString(SRName.ExRegexParserUnexpectedCharClassEnd));
		}
		if (ToR() == '^')
		{
			to9();
			flag = true;
		}
		while (true)
		{
			if (nom())
			{
				throw new oG(SR.GetString(SRName.ExRegexParserUnexpectedCharClassEnd));
			}
			IoG(out var c, out var flag2);
			if (!flag2 && c == ']')
			{
				break;
			}
			if (flag2 && QdM.AR8(23718).IndexOf(c) != -1)
			{
				switch (c)
				{
				case 'd':
					u3.t0r(u2.z07());
					u4.t0r(u2.z07());
					break;
				case 'p':
					try
					{
						u3.P01(No3(), _0020: false);
						u4.P01(No3(), _0020: false);
					}
					catch (ArgumentException)
					{
						throw new oG(SR.GetString(SRName.ExInvalidUnicodeCategoryName));
					}
					break;
				case 's':
					u3.t0r(u2.V0z);
					u4.t0r(u2.V0z);
					break;
				case 'w':
					u3.t0r(u2.qYo());
					u4.t0r(u2.qYo());
					break;
				case 'D':
					u3.t0r(u2.RYC());
					u4.t0r(u2.RYC());
					break;
				case 'P':
					try
					{
						u3.P01(No3(), _0020: true);
						u4.P01(No3(), _0020: true);
					}
					catch (ArgumentException)
					{
						throw new oG(SR.GetString(SRName.ExInvalidUnicodeCategoryName));
					}
					break;
				case 'S':
					u3.t0r(u2.TYf);
					u4.t0r(u2.TYf);
					break;
				case 'W':
					u3.t0r(u2.UYx());
					u4.t0r(u2.UYx());
					break;
				}
			}
			else if (!nom() && ToR() == '-')
			{
				to9();
				IoG(out var c2, out flag2);
				u3.Add(c, c2);
				u4.Add(c, c2);
				if (qo1 == (fw)0)
				{
					continue;
				}
				char c3 = c;
				while (c3 <= c2 && c3 < '\uffff')
				{
					if (char.IsLower(c3))
					{
						char c4 = char.ToUpperInvariant(c3);
						if (!u3.q0v(c4))
						{
							u3.Add(c4);
						}
					}
					else if (char.IsUpper(c3))
					{
						char c4 = char.ToLowerInvariant(c3);
						if (!u3.q0v(c4))
						{
							u3.Add(c4);
						}
					}
					c3 = (char)(c3 + 1);
				}
			}
			else
			{
				if (qo1 == (fw)0 || !char.IsLetter(c))
				{
					u3.Add(c);
				}
				else
				{
					u3.Add(char.ToUpperInvariant(c));
					u3.Add(char.ToLowerInvariant(c));
				}
				u4.Add(c);
			}
		}
		return new XA(u3, u4, flag, qo1);
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	private XA QoH(int P_0, bool P_1)
	{
		XA xA = new XA(17);
		Tor = P_0;
		bool flag = P_1;
		while (!nom())
		{
			P_0 = Tor;
			IoG(out var c, out var flag2);
			if (flag2)
			{
				switch (c)
				{
				case 'd':
					eob(xA, new XA(38));
					break;
				case 'p':
				{
					u2 u5 = new u2();
					u2 u6 = new u2();
					try
					{
						u5.P01(No3(), _0020: false);
						u6.P01(No3(), _0020: false);
					}
					catch (ArgumentException)
					{
						throw new oG(SR.GetString(SRName.ExInvalidUnicodeCategoryName));
					}
					eob(xA, new XA(u5, u6, _0020: false, qo1));
					break;
				}
				case 's':
					eob(xA, new XA(46));
					break;
				case 'w':
					eob(xA, new XA(32));
					break;
				case 'D':
					eob(xA, new XA(39));
					break;
				case 'P':
				{
					u2 u3 = new u2();
					u2 u4 = new u2();
					try
					{
						u3.P01(No3(), _0020: true);
						u4.P01(No3(), _0020: true);
					}
					catch (ArgumentException)
					{
						throw new oG(SR.GetString(SRName.ExInvalidUnicodeCategoryName));
					}
					eob(xA, new XA(u3, u4, _0020: false, qo1));
					break;
				}
				case 'S':
					eob(xA, new XA(47));
					break;
				case 'W':
					eob(xA, new XA(33));
					break;
				default:
					eob(xA, new XA(1, c, qo1));
					break;
				}
			}
			else
			{
				switch (c)
				{
				case '.':
					eob(xA, new XA(2, '\n', (fw)0));
					break;
				case '"':
					eob(xA, goF());
					break;
				case '[':
					eob(xA, toc());
					break;
				case '{':
					eob(xA, new XA(1, '{', qo1));
					break;
				case '(':
				{
					XA xA4 = new XA(18);
					xA4.Poe().Add(QoH(Tor, _0020: false));
					eob(xA, xA4);
					break;
				}
				case ')':
					flag = true;
					break;
				case '\t':
				case '\n':
				case '\r':
				case ' ':
					eob(xA, new XA(1, c, qo1));
					break;
				case '|':
				{
					if (xA.Poe().Count == 0)
					{
						throw new oG(SR.GetString(SRName.ExRegexParserNoLeftExpressionForBarOperand));
					}
					XA xA2 = xA.Poe()[xA.Poe().Count - 1];
					if (xA2.poh == 16)
					{
						xA2.Poe().Add(QoH(Tor, _0020: true));
						break;
					}
					int num = xA.Poe().Count - 1;
					while (num >= 0 && xA.Poe()[num].poh != 16)
					{
						num--;
					}
					xA2 = new XA(17);
					for (int i = num + 1; i < xA.Poe().Count; i++)
					{
						xA2.Poe().Add(xA.Poe()[i]);
					}
					xA.Poe().RemoveRange(num + 1, xA.Poe().Count - (num + 1));
					XA xA3 = new XA(16);
					xA3.Poe().Add(xA2);
					xA3.Poe().Add(QoH(Tor, _0020: true));
					xA.Poe().Add(xA3);
					break;
				}
				default:
					eob(xA, new XA(1, c, qo1));
					break;
				}
			}
			if (flag)
			{
				break;
			}
		}
		if (xA.Poe().Count == 0)
		{
			throw new oG(SR.GetString(SRName.ExRegexParserNoRegularExpression));
		}
		if (xA.poh == 17 && xA.Poe().Count == 1)
		{
			return xA.Poe()[0];
		}
		return xA;
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	private XA OoL(XA P_0)
	{
		if (nom())
		{
			return P_0;
		}
		char c = ToR();
		switch (c)
		{
		case '*':
		case '+':
		case '?':
		case '{':
			to9();
			switch (c)
			{
			case '+':
				P_0 = P_0.Jon(1, int.MaxValue);
				break;
			case '*':
				P_0 = P_0.Jon(0, int.MaxValue);
				break;
			case '?':
				P_0 = P_0.Jon(0, 1);
				break;
			case '{':
			{
				string text = string.Empty;
				string text2 = string.Empty;
				bool flag = false;
				bool flag2 = false;
				while (!flag2)
				{
					c = to9();
					switch (c)
					{
					case '}':
						if (text.Length == 0)
						{
							throw new oG(SR.GetString(SRName.ExRegexParserNoRangeMinimum));
						}
						P_0 = ((text2.Length != 0) ? P_0.Jon(int.Parse(text, CultureInfo.InvariantCulture), int.Parse(text2, CultureInfo.InvariantCulture)) : ((!flag) ? P_0.Jon(int.Parse(text, CultureInfo.InvariantCulture), int.Parse(text, CultureInfo.InvariantCulture)) : P_0.Jon(int.Parse(text, CultureInfo.InvariantCulture), int.MaxValue)));
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
						throw new oG(string.Format(CultureInfo.CurrentCulture, SR.GetString(SRName.ExRegexParserInvalidRangeCharacter), new object[1] { c }));
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

	private XA goF()
	{
		string text = string.Empty;
		while (true)
		{
			if (nom())
			{
				throw new oG(SR.GetString(SRName.ExRegexParserUnexpectedQuotedStringEnd));
			}
			IoG(out var c, out var flag);
			if (!flag && c == '"')
			{
				break;
			}
			text += c;
		}
		return new XA(4, text, qo1);
	}

	private XA hoA()
	{
		string text = string.Empty;
		while (!nom())
		{
			char c = ToR();
			if (c == '0' || !char.IsDigit(c))
			{
				if (text.Length == 0)
				{
					switch (c)
					{
					case '$':
						to9();
						return new XA(1, '$', (fw)0);
					case '&':
					case '0':
						to9();
						return new XA(26, QdM.AR8(23738));
					}
				}
				break;
			}
			to9();
			text += c;
		}
		if (text.Length == 0)
		{
			throw new oG(SR.GetString(SRName.ExRegexParserInvalidSubstitutionGroupNumber));
		}
		return new XA(26, text);
	}

	private string No3()
	{
		string text = string.Empty;
		int num;
		if (nom())
		{
			num = 1;
			if (iaw() != null)
			{
				goto IL_0005;
			}
		}
		else
		{
			char c = to9();
			if (c != '{')
			{
				throw new oG(SR.GetString(SRName.ExRegexParserOpenCurlyBraceExpected));
			}
			while (true)
			{
				if (!nom())
				{
					c = to9();
					if (c != '}')
					{
						if (!char.IsLetter(c))
						{
							break;
						}
						text += c;
						continue;
					}
				}
				return text;
			}
			num = 0;
			if (!la7())
			{
				goto IL_0005;
			}
		}
		goto IL_0009;
		IL_0009:
		switch (num)
		{
		case 1:
			throw new oG(SR.GetString(SRName.ExRegexParserOpenCurlyBraceExpected));
		default:
			throw new oG(SR.GetString(SRName.ExInvalidUnicodeCategoryName));
		}
		IL_0005:
		int num2 = default(int);
		num = num2;
		goto IL_0009;
	}

	private void Ooy(int P_0)
	{
		Tor = Math.Min(qo8.Length, Tor + P_0);
	}

	public Jj()
	{
		awj.QuEwGz();
		base._002Ector();
	}

	internal static bool la7()
	{
		return Da0 == null;
	}

	internal static Jj iaw()
	{
		return Da0;
	}
}
