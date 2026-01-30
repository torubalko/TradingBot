using MimeKit.IO.Filters;
using MimeKit.Utils;

namespace MimeKit.Cryptography;

internal class OpenPgpBlockFilter : MimeFilterBase
{
	private readonly byte[] beginMarker;

	private readonly byte[] endMarker;

	private bool seenBeginMarker;

	private bool seenEndMarker;

	private bool midline;

	public OpenPgpBlockFilter(string beginMarker, string endMarker)
	{
		this.beginMarker = CharsetUtils.UTF8.GetBytes(beginMarker);
		this.endMarker = CharsetUtils.UTF8.GetBytes(endMarker);
	}

	private static bool IsMarker(byte[] input, int startIndex, byte[] marker)
	{
		int num = startIndex;
		for (int i = 0; i < marker.Length; i++)
		{
			if (input[num] != marker[i])
			{
				return false;
			}
			num++;
		}
		if (input[num] == 13)
		{
			num++;
		}
		return input[num] == 10;
	}

	private static bool IsPartialMatch(byte[] input, int startIndex, int endIndex, byte[] marker)
	{
		int num = startIndex;
		for (int i = 0; i < marker.Length; i++)
		{
			if (num >= endIndex)
			{
				break;
			}
			if (input[num] != marker[i])
			{
				return false;
			}
			num++;
		}
		if (num < endIndex && input[num] == 13)
		{
			num++;
		}
		return num == endIndex;
	}

	protected override byte[] Filter(byte[] input, int startIndex, int length, out int outputIndex, out int outputLength, bool flush)
	{
		int num = startIndex + length;
		int i = startIndex;
		outputIndex = startIndex;
		outputLength = 0;
		if (seenEndMarker || length == 0)
		{
			return input;
		}
		if (midline)
		{
			for (; i < num && input[i] != 10; i++)
			{
			}
			if (i == num)
			{
				if (seenBeginMarker)
				{
					outputLength = i - startIndex;
				}
				return input;
			}
			midline = false;
		}
		if (!seenBeginMarker)
		{
			do
			{
				int num2 = i;
				for (; i < num && input[i] != 10; i++)
				{
				}
				if (i == num)
				{
					if (IsPartialMatch(input, num2, i, beginMarker))
					{
						SaveRemainingInput(input, num2, i - num2);
					}
					else
					{
						midline = true;
					}
					return input;
				}
				i++;
				if (IsMarker(input, num2, beginMarker))
				{
					outputLength = i - num2;
					outputIndex = num2;
					seenBeginMarker = true;
					break;
				}
			}
			while (i < num);
			if (i == num)
			{
				return input;
			}
		}
		do
		{
			int num3 = i;
			for (; i < num && input[i] != 10; i++)
			{
			}
			if (i == num)
			{
				if (!flush)
				{
					if (IsPartialMatch(input, num3, i, endMarker))
					{
						SaveRemainingInput(input, num3, i - num3);
						outputLength = num3 - outputIndex;
					}
					else
					{
						outputLength = i - outputIndex;
						midline = true;
					}
					return input;
				}
				outputLength = i - outputIndex;
				return input;
			}
			i++;
			if (IsMarker(input, num3, endMarker))
			{
				seenEndMarker = true;
				break;
			}
		}
		while (i < num);
		outputLength = i - outputIndex;
		return input;
	}

	public override void Reset()
	{
		seenBeginMarker = false;
		seenEndMarker = false;
		midline = false;
		base.Reset();
	}
}
