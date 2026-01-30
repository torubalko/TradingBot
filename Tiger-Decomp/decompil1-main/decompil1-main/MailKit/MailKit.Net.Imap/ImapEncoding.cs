using System.Text;

namespace MailKit.Net.Imap;

internal static class ImapEncoding
{
	private const string utf7_alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+,";

	private static readonly byte[] utf7_rank = new byte[128]
	{
		255, 255, 255, 255, 255, 255, 255, 255, 255, 255,
		255, 255, 255, 255, 255, 255, 255, 255, 255, 255,
		255, 255, 255, 255, 255, 255, 255, 255, 255, 255,
		255, 255, 255, 255, 255, 255, 255, 255, 255, 255,
		255, 255, 255, 62, 63, 255, 255, 255, 52, 53,
		54, 55, 56, 57, 58, 59, 60, 61, 255, 255,
		255, 255, 255, 255, 255, 0, 1, 2, 3, 4,
		5, 6, 7, 8, 9, 10, 11, 12, 13, 14,
		15, 16, 17, 18, 19, 20, 21, 22, 23, 24,
		25, 255, 255, 255, 255, 255, 255, 26, 27, 28,
		29, 30, 31, 32, 33, 34, 35, 36, 37, 38,
		39, 40, 41, 42, 43, 44, 45, 46, 47, 48,
		49, 50, 51, 255, 255, 255, 255, 255
	};

	public static string Decode(string text)
	{
		StringBuilder stringBuilder = new StringBuilder();
		bool flag = false;
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		while (num3 < text.Length)
		{
			char c = text[num3++];
			if (flag)
			{
				if (c == '-')
				{
					flag = false;
					num = (num2 = 0);
					continue;
				}
				if (c > '\u007f')
				{
					return text;
				}
				byte b = utf7_rank[(byte)c];
				if (b == byte.MaxValue)
				{
					return text;
				}
				num2 = (num2 << 6) | b;
				num += 6;
				if (num >= 16)
				{
					char value = (char)((num2 >> num - 16) & 0xFFFF);
					stringBuilder.Append(value);
					num -= 16;
				}
			}
			else if (c == '&' && num3 < text.Length)
			{
				if (text[num3] == '-')
				{
					stringBuilder.Append('&');
					num3++;
				}
				else
				{
					flag = true;
				}
			}
			else
			{
				stringBuilder.Append(c);
			}
		}
		return stringBuilder.ToString();
	}

	private static void Utf7ShiftOut(StringBuilder output, int u, int bits)
	{
		if (bits > 0)
		{
			int index = (u << 6 - bits) & 0x3F;
			output.Append("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+,"[index]);
		}
		output.Append('-');
	}

	public static string Encode(string text)
	{
		StringBuilder stringBuilder = new StringBuilder();
		bool flag = false;
		int num = 0;
		int num2 = 0;
		foreach (char c in text)
		{
			if (c >= ' ' && c < '\u007f')
			{
				if (flag)
				{
					Utf7ShiftOut(stringBuilder, num2, num);
					flag = false;
					num = 0;
				}
				if (c == '&')
				{
					stringBuilder.Append("&-");
				}
				else
				{
					stringBuilder.Append(c);
				}
				continue;
			}
			if (!flag)
			{
				stringBuilder.Append('&');
				flag = true;
			}
			num2 = (num2 << 16) | (c & 0xFFFF);
			for (num += 16; num >= 6; num -= 6)
			{
				int index = (num2 >> num - 6) & 0x3F;
				stringBuilder.Append("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+,"[index]);
			}
		}
		if (flag)
		{
			Utf7ShiftOut(stringBuilder, num2, num);
		}
		return stringBuilder.ToString();
	}
}
