using System;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ActiproSoftware.Internal;

internal static class wdv
{
	private static wdv YSl;

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	private static string bGD(string P_0, string P_1)
	{
		if (!string.IsNullOrEmpty(P_0) && !string.IsNullOrEmpty(P_1) && !gGq(P_1))
		{
			int? num = null;
			int num2 = -1;
			StringBuilder stringBuilder = null;
			StringBuilder stringBuilder2 = null;
			for (int i = 0; i < P_1.Length; i++)
			{
				char c = P_1[i];
				switch (c)
				{
				case '#':
				case '%':
				case ',':
				case '.':
				case '0':
				case '‰':
					if (!num.HasValue)
					{
						num = i;
					}
					else if (i != num2)
					{
						break;
					}
					num2 = i + 1;
					continue;
				case '\\':
					if (num.HasValue)
					{
						if (++i < P_1.Length)
						{
							if (stringBuilder2 == null)
							{
								stringBuilder2 = new StringBuilder();
							}
							stringBuilder2.Append(P_1[i]);
						}
					}
					else if (++i < P_1.Length)
					{
						if (stringBuilder == null)
						{
							stringBuilder = new StringBuilder();
						}
						stringBuilder.Append(P_1[i]);
					}
					continue;
				case '"':
				case '\'':
				{
					int num3 = i + 1;
					int num4 = P_1.Length;
					for (i = num3; i < P_1.Length; i++)
					{
						if (P_1[i] == c)
						{
							num4 = i;
							break;
						}
					}
					if (num3 >= num4)
					{
						continue;
					}
					if (num.HasValue)
					{
						if (stringBuilder2 == null)
						{
							stringBuilder2 = new StringBuilder();
						}
						stringBuilder2.Append(P_1.Substring(num3, num4 - num3));
					}
					else
					{
						if (stringBuilder == null)
						{
							stringBuilder = new StringBuilder();
						}
						stringBuilder.Append(P_1.Substring(num3, num4 - num3));
					}
					continue;
				}
				}
				if (num.HasValue)
				{
					if (stringBuilder2 == null)
					{
						stringBuilder2 = new StringBuilder();
					}
					stringBuilder2.Append(c);
				}
				else
				{
					if (stringBuilder == null)
					{
						stringBuilder = new StringBuilder();
					}
					stringBuilder.Append(c);
				}
			}
			if (stringBuilder != null)
			{
				string text = stringBuilder.ToString().TrimEnd();
				if (P_0.StartsWith(text, StringComparison.OrdinalIgnoreCase))
				{
					P_0 = P_0.Substring(text.Length);
				}
			}
			if (stringBuilder2 != null)
			{
				string text2 = stringBuilder2.ToString().TrimStart();
				if (P_0.EndsWith(text2, StringComparison.OrdinalIgnoreCase))
				{
					P_0 = P_0.Substring(0, P_0.Length - text2.Length);
				}
			}
		}
		return P_0;
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	public static string[] nGG(string P_0, string P_1)
	{
		if (!string.IsNullOrEmpty(P_1) && (!gGq(P_1) || P_1.Contains(QdM.AR8(28276))))
		{
			string text = P_1.Replace(QdM.AR8(23750), QdM.AR8(28282)).Replace(QdM.AR8(28290), QdM.AR8(28282));
			string text2 = null;
			string text3 = null;
			string text4 = null;
			int num = P_1.IndexOf(';');
			if (num != -1)
			{
				text2 = P_1.Substring(0, num);
				int num2 = P_1.IndexOf(';', num + 1);
				if (num2 != -1)
				{
					text3 = P_1.Substring(num + 1, num2 - num - 1);
					text4 = P_1.Substring(num2 + 1);
				}
				else
				{
					text3 = P_1.Substring(num + 1);
				}
			}
			else
			{
				text2 = P_1;
			}
			if (!string.IsNullOrEmpty(text4) && string.Compare(P_0, text4, StringComparison.OrdinalIgnoreCase) == 0)
			{
				return new string[2]
				{
					QdM.AR8(2092),
					null
				};
			}
			string text5 = null;
			string text6 = null;
			if (!string.IsNullOrEmpty(text3))
			{
				text6 = bGD(P_0, text3);
			}
			if (!string.IsNullOrEmpty(text2))
			{
				text5 = bGD(P_0, text2);
			}
			return new string[2]
			{
				text5 ?? P_0,
				text6
			};
		}
		return new string[2] { P_0, null };
	}

	public static bool gGq(string P_0)
	{
		return !string.IsNullOrEmpty(P_0) && QdM.AR8(28298).IndexOf(P_0[0]) != -1;
	}

	internal static bool eSV()
	{
		return YSl == null;
	}

	internal static wdv KSu()
	{
		return YSl;
	}
}
