using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ActiproSoftware.Internal;

internal static class vO
{
	private static vO kao;

	public static string pov(string P_0)
	{
		return Iop(P_0, _0020: false);
	}

	public static string Iop(string P_0, bool P_1)
	{
		string result = default(string);
		if (!string.IsNullOrEmpty(P_0))
		{
			if (!P_1)
			{
				StringBuilder stringBuilder = new StringBuilder();
				int num = 0;
				int num3 = default(int);
				while (true)
				{
					int num2;
					if (num < P_0.Length)
					{
						char c = P_0[num];
						if (!aoW(c))
						{
							stringBuilder.Append(c);
							goto IL_00c8;
						}
						stringBuilder.Append(QdM.AR8(23744) + c);
						num2 = 1;
						if (Ral() != null)
						{
							goto IL_0005;
						}
					}
					else
					{
						result = stringBuilder.ToString();
						num2 = 0;
						if (Ral() != null)
						{
							goto IL_0005;
						}
					}
					goto IL_0009;
					IL_0005:
					num2 = num3;
					goto IL_0009;
					IL_0009:
					switch (num2)
					{
					case 1:
						goto IL_00c8;
					}
					break;
					IL_00c8:
					num++;
				}
			}
			else
			{
				result = P_0.Replace(QdM.AR8(23744), QdM.AR8(23750)).Replace(QdM.AR8(16484), QdM.AR8(23758));
			}
		}
		else
		{
			result = P_0;
		}
		return result;
	}

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "ch")]
	public static bool aoW(char P_0)
	{
		switch (P_0)
		{
		case '"':
		case '$':
		case '(':
		case ')':
		case '*':
		case '+':
		case '.':
		case '?':
		case '[':
		case '\\':
		case ']':
		case '^':
		case '{':
		case '|':
			return true;
		default:
			return false;
		}
	}

	public static string roi(string P_0)
	{
		if (P_0 == null)
		{
			return string.Empty;
		}
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < P_0.Length; i++)
		{
			char c = P_0[i];
			switch (c)
			{
			case '\t':
			case '\n':
			case ' ':
				stringBuilder.Append(QdM.AR8(23766));
				break;
			case '?':
				stringBuilder.Append(QdM.AR8(2104));
				break;
			case '#':
				stringBuilder.Append(QdM.AR8(23772));
				break;
			case '*':
				stringBuilder.Append(QdM.AR8(23780));
				break;
			case '[':
			{
				bool flag = ++i < P_0.Length && P_0[i] == '!';
				if (flag)
				{
					i++;
				}
				u2 u3 = new u2();
				for (; i < P_0.Length; i++)
				{
					c = P_0[i];
					if (c == ']')
					{
						break;
					}
					u3.Add(c);
				}
				if (flag)
				{
					u3.tYq(!u3.xYG());
				}
				stringBuilder.Append(u3.ToString());
				break;
			}
			default:
				if (aoW(c))
				{
					stringBuilder.Append(QdM.AR8(23744) + c);
				}
				else
				{
					stringBuilder.Append(c);
				}
				break;
			}
		}
		return stringBuilder.ToString();
	}

	internal static bool ea2()
	{
		return kao == null;
	}

	internal static vO Ral()
	{
		return kao;
	}
}
