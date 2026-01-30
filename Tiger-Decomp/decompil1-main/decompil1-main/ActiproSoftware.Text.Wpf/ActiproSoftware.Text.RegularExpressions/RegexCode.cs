using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using ActiproSoftware.Products.Text;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.RegularExpressions;

internal class RegexCode
{
	internal const int Insensitive = 256;

	internal const int AutoCorrect = 512;

	private int JuQ;

	private int[] fun;

	private int[] CuG;

	private int[] rue;

	private int Wuy;

	private int[] duz;

	private int X8S;

	private int T8V;

	private bool A8B;

	private ITextBufferReader v89;

	private bool c8A;

	private string[] F8u;

	private int[] A88;

	private int u8T;

	private CharClass P82;

	private static RegexCode NbU;

	internal RegexCode(int[] codes, string[] stringTable, bool rightToLeft, int captureCount)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		P82 = CharClass.Word;
		base._002Ector();
		fun = codes;
		F8u = stringTable;
		A8B = rightToLeft;
		duz = new int[20];
		A88 = new int[40];
		rue = new int[4];
		CuG = new int[captureCount * 2];
		for (int i = 0; i < CuG.Length; i++)
		{
			CuG[i] = -1;
		}
	}

	private void iuj(int P_0, int P_1, int P_2)
	{
		if (Wuy >= rue.Length)
		{
			int[] destinationArray = new int[2 * rue.Length];
			Array.Copy(rue, 0, destinationArray, 0, Wuy);
			rue = destinationArray;
		}
		CuG[P_0 * 2] = P_1;
		CuG[P_0 * 2 + 1] = P_2;
		rue[Wuy++] = P_0;
	}

	private void quF()
	{
		int num = rue[--Wuy];
		CuG[num * 2] = -1;
		CuG[num * 2 + 1] = -1;
	}

	private int Bux(int P_0)
	{
		return fun[JuQ + P_0];
	}

	private void Fug(int P_0)
	{
		JuQ = P_0;
		T8V = fun[JuQ];
	}

	internal MatchType Match(ITextBufferReader targetReader, bool allowZeroLengthMatch)
	{
		v89 = targetReader;
		c8A = A8B;
		int offset = v89.Offset;
		Fug(0);
		bool flag = quO();
		bool flag2 = allowZeroLengthMatch && Wuy > 0;
		v89 = null;
		X8S = 0;
		u8T = 0;
		Wuy = 0;
		if (duz.Length > 20)
		{
			duz = new int[20];
		}
		if (A88.Length > 40)
		{
			A88 = new int[40];
		}
		if (rue.Length > 4)
		{
			rue = new int[4];
		}
		if (targetReader.Offset != offset || flag2)
		{
			return (!flag) ? MatchType.ExactMatch : MatchType.LooseMatch;
		}
		return MatchType.NoMatch;
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1505:AvoidUnmaintainableCode")]
	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	private bool quO()
	{
		bool result = false;
		while (true)
		{
			int num;
			switch (T8V)
			{
			case 29:
				return result;
			case 16:
				yuk(v89.Offset);
				RuN(2);
				continue;
			case 80:
				v89.Offset = CuD();
				Fug(Bux(1));
				continue;
			case 4:
				if (QuY(F8u[Bux(1)]))
				{
					RuN(2);
					continue;
				}
				break;
			case 1:
				if (ju5((char)Bux(1)))
				{
					RuN(2);
					continue;
				}
				break;
			case 3:
				if (Nui(F8u[Bux(1)]))
				{
					RuN(2);
					continue;
				}
				break;
			case 33:
				if (@out() <= 0 || P82.Contains(Kuf()))
				{
					break;
				}
				xuR();
				RuN(1);
				continue;
			case 2:
				if (PuZ((char)Bux(1)))
				{
					RuN(2);
					continue;
				}
				break;
			case 516:
			{
				MatchType matchType = Nu0(F8u[Bux(1)]);
				if (matchType != MatchType.NoMatch)
				{
					if (matchType == MatchType.LooseMatch)
					{
						result = true;
					}
					RuN(2);
					continue;
				}
				break;
			}
			case 513:
			{
				MatchType matchType = Bul((char)Bux(1));
				if (matchType != MatchType.NoMatch)
				{
					if (matchType == MatchType.LooseMatch)
					{
						result = true;
					}
					RuN(2);
					continue;
				}
				break;
			}
			case 42:
				if (@out() > 0 && char.IsWhiteSpace(Kuf()))
				{
					switch (Kuf())
					{
					default:
						xuR();
						RuN(1);
						continue;
					case '\n':
					case '\r':
					case '\u2028':
					case '\u2029':
						break;
					}
				}
				break;
			case 44:
				if (@out() > 0)
				{
					switch (Kuf())
					{
					case '\n':
					case '\r':
					case '\u2028':
					case '\u2029':
						xuR();
						RuN(1);
						continue;
					}
				}
				break;
			case 260:
				if (Tuv(F8u[Bux(1)]))
				{
					RuN(2);
					continue;
				}
				break;
			case 257:
				if (YuW((char)Bux(1)))
				{
					RuN(2);
					continue;
				}
				break;
			case 258:
			case 514:
				if (cu6((char)Bux(1)))
				{
					RuN(2);
					continue;
				}
				break;
			case 38:
				if (@out() <= 0 || !char.IsDigit(Kuf()))
				{
					break;
				}
				xuR();
				RuN(1);
				continue;
			case 36:
				if (@out() <= 0 || !char.IsLetter(Kuf()))
				{
					break;
				}
				xuR();
				RuN(1);
				continue;
			case 22:
				Eu1(v89.Offset);
				SuK();
				RuN(1);
				continue;
			case 21:
				Eu1(-1);
				SuK();
				RuN(1);
				continue;
			case 85:
			case 86:
				guo();
				break;
			case 17:
				num = guo();
				if (v89.Offset - num != 0)
				{
					buE(num, v89.Offset);
					Eu1(v89.Offset);
					Fug(Bux(1));
				}
				else
				{
					Bur(num);
					RuN(2);
				}
				continue;
			case 81:
			{
				num = CuD();
				int num2 = CuD();
				guo();
				v89.Offset = num;
				Bur(num2);
				RuN(2);
				continue;
			}
			case 145:
				Eu1(CuD());
				break;
			case 24:
				v89.Offset = guo();
				yuk(v89.Offset);
				RuN(1);
				continue;
			case 88:
				Eu1(CuD());
				break;
			case 23:
				num = guo();
				iuj(Bux(1), num, v89.Offset);
				yuk(num);
				RuN(2);
				continue;
			case 87:
				Eu1(CuD());
				quF();
				break;
			case 19:
				gu4(v89.Offset, Bux(1));
				SuK();
				RuN(2);
				continue;
			case 18:
				gu4(-1, Bux(1));
				SuK();
				RuN(2);
				continue;
			case 82:
			case 83:
				guo();
				guo();
				break;
			case 20:
			{
				num = guo();
				int num2 = guo();
				if (num < Bux(2) && (v89.Offset - num2 != 0 || num < 0))
				{
					yuk(num2);
					gu4(v89.Offset, num + 1);
					Fug(Bux(1));
				}
				else
				{
					Wu3(num2, num);
					RuN(3);
				}
				continue;
			}
			case 84:
			{
				num = CuD();
				int num2 = guo();
				if (num2 > 0)
				{
					v89.Offset = guo();
					Wu3(num, num2 - 1);
					RuN(3);
					continue;
				}
				gu4(guo(), num2 - 1);
				break;
			}
			case 148:
			{
				num = CuD();
				int num2 = CuD();
				gu4(num2, num);
				break;
			}
			case 28:
				Fug(Bux(1));
				continue;
			case 34:
				xuR();
				RuN(1);
				continue;
			case 40:
				if (@out() <= 0 || WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7078).IndexOf(Kuf().ToString(), StringComparison.OrdinalIgnoreCase) == -1)
				{
					break;
				}
				xuR();
				RuN(1);
				continue;
			case 46:
				if (@out() <= 0 || !char.IsWhiteSpace(Kuf()))
				{
					break;
				}
				xuR();
				RuN(1);
				continue;
			case 37:
				if (@out() <= 0 || char.IsLetter(Kuf()))
				{
					break;
				}
				xuR();
				RuN(1);
				continue;
			case 39:
				if (@out() <= 0 || char.IsDigit(Kuf()))
				{
					break;
				}
				xuR();
				RuN(1);
				continue;
			case 41:
				if (@out() > 0 && WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7078).IndexOf(Kuf().ToString(), StringComparison.OrdinalIgnoreCase) == -1)
				{
					xuR();
					RuN(1);
					continue;
				}
				break;
			case 45:
				if (@out() > 0)
				{
					switch (Kuf())
					{
					default:
						xuR();
						RuN(1);
						continue;
					case '\n':
					case '\r':
					case '\u2028':
					case '\u2029':
						break;
					}
				}
				break;
			case 47:
				if (@out() <= 0 || char.IsWhiteSpace(Kuf()))
				{
					break;
				}
				xuR();
				RuN(1);
				continue;
			case 43:
				if (@out() > 0)
				{
					if (!char.IsWhiteSpace(Kuf()))
					{
						xuR();
						RuN(1);
						continue;
					}
					switch (Kuf())
					{
					case '\n':
					case '\r':
					case '\u2028':
					case '\u2029':
						xuR();
						RuN(1);
						continue;
					}
				}
				break;
			case 32:
				if (@out() <= 0 || !P82.Contains(Kuf()))
				{
					break;
				}
				xuR();
				RuN(1);
				continue;
			case 9:
			{
				if (v89.IsAtStart || v89.IsAtEnd)
				{
					RuN(1);
					continue;
				}
				num = ((!v89.IsAtStart && P82.Contains(v89.PeekReverse())) ? 1 : 0);
				int num2 = ((!v89.IsAtEnd && P82.Contains(v89.Peek())) ? 1 : 0);
				if (num != num2)
				{
					RuN(1);
					continue;
				}
				break;
			}
			case 10:
				if (!v89.IsAtStart && !v89.IsAtEnd)
				{
					num = ((!v89.IsAtStart && P82.Contains(v89.PeekReverse())) ? 1 : 0);
					int num2 = ((!v89.IsAtEnd && P82.Contains(v89.Peek())) ? 1 : 0);
					if (num == num2)
					{
						RuN(1);
						continue;
					}
				}
				break;
			case 5:
				if (v89.IsAtStart)
				{
					RuN(1);
					continue;
				}
				break;
			case 6:
				if (@out() <= 0)
				{
					RuN(1);
					continue;
				}
				break;
			case 7:
				if (v89.IsAtStart)
				{
					RuN(1);
					continue;
				}
				switch (v89.PeekReverse())
				{
				case '\n':
				case '\r':
				case '\u2028':
				case '\u2029':
					RuN(1);
					continue;
				}
				break;
			case 8:
				if (@out() <= 0)
				{
					RuN(1);
					continue;
				}
				switch (Kuf())
				{
				case '\n':
				case '\r':
				case '\u2028':
				case '\u2029':
					RuN(1);
					continue;
				}
				break;
			case 25:
				gu4(u8T, Wuy);
				SuK();
				RuN(1);
				continue;
			case 89:
				guo();
				guo();
				break;
			case 26:
			{
				num = guo();
				int num2 = guo();
				while (u8T > num2)
				{
					CuD();
				}
				while (Wuy > num)
				{
					quF();
				}
				break;
			}
			case 27:
			{
				num = guo();
				int num2 = guo();
				while (u8T > num2)
				{
					CuD();
				}
				yuk(num);
				RuN(1);
				continue;
			}
			case 91:
				num = CuD();
				while (Wuy > num)
				{
					quF();
				}
				break;
			case 31:
				c8A = true;
				SuK();
				RuN(1);
				continue;
			case 95:
				c8A = false;
				break;
			case 30:
				c8A = false;
				SuK();
				RuN(1);
				continue;
			case 94:
				c8A = true;
				break;
			default:
				throw new InvalidOperationException(string.Format(CultureInfo.CurrentCulture, SR.GetString(SRName.ExInvalidRegexOpCode), new object[1] { T8V }));
			case 35:
				break;
			}
			num = CuD();
			if (num < 0)
			{
				JuQ = -num;
				T8V = fun[JuQ] | 0x80;
			}
			else
			{
				JuQ = num;
				T8V = fun[JuQ] | 0x40;
			}
		}
	}

	private MatchType Bul(char P_0)
	{
		if (@out() <= 0)
		{
			return MatchType.NoMatch;
		}
		if (Kuf() == P_0)
		{
			xuR();
			return MatchType.ExactMatch;
		}
		if (char.ToUpperInvariant(Kuf()) == char.ToUpperInvariant(P_0))
		{
			xuR();
			return MatchType.LooseMatch;
		}
		return MatchType.NoMatch;
	}

	private bool Nui(string P_0)
	{
		if (@out() <= 0)
		{
			return false;
		}
		if (CharClass.IsLookupStringMatch(P_0, Kuf()))
		{
			xuR();
			return true;
		}
		return false;
	}

	private bool YuW(char P_0)
	{
		if (@out() <= 0)
		{
			return false;
		}
		if (char.ToUpperInvariant(Kuf()) != char.ToUpperInvariant(P_0))
		{
			return false;
		}
		xuR();
		return true;
	}

	private bool ju5(char P_0)
	{
		bool result;
		if (@out() <= 0)
		{
			result = false;
			int num = 0;
			if (!Ob2())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
		else if (Kuf() == P_0)
		{
			xuR();
			result = true;
		}
		else
		{
			result = false;
		}
		return result;
	}

	private bool cu6(char P_0)
	{
		if (@out() <= 0)
		{
			return false;
		}
		if (char.ToUpperInvariant(Kuf()) == char.ToUpperInvariant(P_0))
		{
			return false;
		}
		xuR();
		return true;
	}

	private bool PuZ(char P_0)
	{
		if (@out() <= 0)
		{
			return false;
		}
		if (Kuf() != P_0)
		{
			xuR();
			int num = 0;
			if (mbq() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			return num switch
			{
				_ => true, 
			};
		}
		return false;
	}

	private MatchType Nu0(string P_0)
	{
		int length = P_0.Length;
		if (@out() < length)
		{
			return MatchType.NoMatch;
		}
		int offset = v89.Offset;
		bool flag = false;
		if (c8A)
		{
			int num = length;
			while (num > 0)
			{
				if (v89.ReadReverse() != P_0[--num])
				{
					if (char.ToUpperInvariant(v89.Peek()) != char.ToUpperInvariant(P_0[num]))
					{
						v89.Offset = offset;
						return MatchType.NoMatch;
					}
					flag = true;
				}
			}
		}
		else
		{
			int num2 = 0;
			while (num2 < length)
			{
				if (v89.Read() != P_0[num2++])
				{
					if (char.ToUpperInvariant(v89.PeekReverse()) != char.ToUpperInvariant(P_0[num2 - 1]))
					{
						v89.Offset = offset;
						return MatchType.NoMatch;
					}
					flag = true;
				}
			}
		}
		return (!flag) ? MatchType.ExactMatch : MatchType.LooseMatch;
	}

	private bool Tuv(string P_0)
	{
		int length = P_0.Length;
		bool flag = @out() < length;
		int num = 2;
		if (mbq() != null)
		{
			num = 2;
		}
		bool flag2 = default(bool);
		int offset = default(int);
		bool result = default(bool);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			switch (num)
			{
			case 1:
				if (flag2)
				{
					v89.Offset = offset;
					result = false;
					break;
				}
				goto IL_0105;
			case 2:
				{
					if (!flag)
					{
						offset = v89.Offset;
						if (!c8A)
						{
							int num2 = 0;
							while (num2 < length)
							{
								if (char.ToUpperInvariant(v89.Read()) == char.ToUpperInvariant(P_0[num2++]))
								{
									continue;
								}
								goto IL_01c0;
							}
							goto IL_00bc;
						}
						num3 = length;
						goto IL_0105;
					}
					result = false;
					num = 0;
					if (Ob2())
					{
						continue;
					}
					goto IL_0005;
				}
				IL_01c0:
				v89.Offset = offset;
				result = false;
				break;
				IL_0005:
				num = num4;
				continue;
				IL_0105:
				if (num3 <= 0)
				{
					goto IL_00bc;
				}
				flag2 = char.ToUpperInvariant(v89.ReadReverse()) != char.ToUpperInvariant(P_0[--num3]);
				num = 1;
				if (mbq() == null)
				{
					continue;
				}
				goto IL_0005;
				IL_00bc:
				result = true;
				break;
			}
			break;
		}
		return result;
	}

	private bool QuY(string P_0)
	{
		int length = P_0.Length;
		bool result;
		if (@out() < length)
		{
			result = false;
			goto IL_0095;
		}
		int offset = v89.Offset;
		int num = default(int);
		if (c8A)
		{
			num = length;
			goto IL_0119;
		}
		int num2 = 0;
		while (num2 < length)
		{
			if (v89.Read() == P_0[num2++])
			{
				continue;
			}
			goto IL_01dc;
		}
		goto IL_01b1;
		IL_0119:
		while (num > 0)
		{
			if (v89.ReadReverse() == P_0[--num])
			{
				continue;
			}
			goto IL_017b;
		}
		goto IL_01b1;
		IL_017b:
		v89.Offset = offset;
		result = false;
		goto IL_0095;
		IL_01b1:
		result = true;
		int num3 = 1;
		if (mbq() != null)
		{
			num3 = 0;
		}
		goto IL_0009;
		IL_0095:
		return result;
		IL_01dc:
		v89.Offset = offset;
		result = false;
		num3 = 0;
		if (!Ob2())
		{
			int num4 = default(int);
			num3 = num4;
		}
		goto IL_0009;
		IL_0009:
		switch (num3)
		{
		case 2:
			goto IL_0119;
		}
		goto IL_0095;
	}

	internal MatchType MatchWithCapture(ITextBufferReader targetReader, out int[] captureResults)
	{
		for (int i = 0; i < CuG.Length; i++)
		{
			CuG[i] = -1;
		}
		MatchType result = Match(targetReader, allowZeroLengthMatch: true);
		captureResults = CuG;
		return result;
	}

	private int guo()
	{
		return duz[--X8S];
	}

	private int CuD()
	{
		return A88[--u8T];
	}

	private void Eu1(int P_0)
	{
		if (X8S >= duz.Length)
		{
			VuJ();
		}
		duz[X8S++] = P_0;
	}

	private void gu4(int P_0, int P_1)
	{
		if (X8S + 1 >= duz.Length)
		{
			VuJ();
		}
		duz[X8S++] = P_0;
		duz[X8S++] = P_1;
	}

	private void SuK()
	{
		if (u8T >= A88.Length)
		{
			AuX();
		}
		A88[u8T++] = JuQ;
	}

	private void yuk(int P_0)
	{
		if (u8T + 1 >= A88.Length)
		{
			AuX();
		}
		A88[u8T++] = P_0;
		A88[u8T++] = JuQ;
	}

	private void buE(int P_0, int P_1)
	{
		if (u8T + 2 >= A88.Length)
		{
			AuX();
		}
		A88[u8T++] = P_0;
		A88[u8T++] = P_1;
		A88[u8T++] = JuQ;
	}

	private void Bur(int P_0)
	{
		if (u8T + 1 >= A88.Length)
		{
			AuX();
		}
		A88[u8T++] = P_0;
		A88[u8T++] = -JuQ;
	}

	private void Wu3(int P_0, int P_1)
	{
		if (u8T + 2 >= A88.Length)
		{
			AuX();
		}
		A88[u8T++] = P_0;
		A88[u8T++] = P_1;
		A88[u8T++] = -JuQ;
	}

	private void VuJ()
	{
		int[] destinationArray = new int[2 * duz.Length];
		Array.Copy(duz, 0, destinationArray, 0, X8S);
		duz = destinationArray;
	}

	private void AuX()
	{
		int[] array = new int[2 * A88.Length];
		Array.Copy(A88, 0, array, 0, u8T);
		A88 = array;
	}

	private void RuN(int P_0)
	{
		Fug(JuQ + P_0);
	}

	private void xuR()
	{
		if (c8A)
		{
			v89.ReadReverse();
		}
		else
		{
			v89.Read();
		}
	}

	private char Kuf()
	{
		return c8A ? v89.PeekReverse() : v89.Peek();
	}

	private int @out()
	{
		return c8A ? (v89.Offset + v89.OffsetDelta) : (v89.Length - v89.Offset);
	}

	internal static bool Ob2()
	{
		return NbU == null;
	}

	internal static RegexCode mbq()
	{
		return NbU;
	}
}
