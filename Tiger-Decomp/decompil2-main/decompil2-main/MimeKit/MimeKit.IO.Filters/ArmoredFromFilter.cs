using System;
using System.Collections.Generic;

namespace MimeKit.IO.Filters;

public class ArmoredFromFilter : MimeFilterBase
{
	private const string From = "From ";

	private bool midline;

	private static bool StartsWithFrom(byte[] input, int startIndex, int endIndex)
	{
		int num = 0;
		int num2 = startIndex;
		while (num < "From ".Length && num2 < endIndex)
		{
			if (input[num2] != (byte)"From "[num])
			{
				return false;
			}
			num++;
			num2++;
		}
		return true;
	}

	protected override byte[] Filter(byte[] input, int startIndex, int length, out int outputIndex, out int outputLength, bool flush)
	{
		List<int> list = new List<int>();
		int num = startIndex + length;
		int num2 = startIndex;
		while (num2 < num)
		{
			byte b = 0;
			if (midline)
			{
				while (num2 < num)
				{
					b = input[num2++];
					if (b == 10)
					{
						break;
					}
				}
			}
			if (b != 10 && midline)
			{
				continue;
			}
			int num3;
			if ((num3 = num - num2) > 0)
			{
				midline = true;
				if (num3 < 5)
				{
					if (StartsWithFrom(input, num2, num))
					{
						SaveRemainingInput(input, num2, num3);
						num = num2;
						midline = false;
						break;
					}
				}
				else if (StartsWithFrom(input, num2, num))
				{
					list.Add(num2);
					num2 += 5;
				}
			}
			else
			{
				midline = false;
			}
		}
		if (list.Count > 0)
		{
			int size = num - startIndex + list.Count * 2;
			EnsureOutputSize(size, keep: false);
			outputLength = 0;
			outputIndex = 0;
			num2 = startIndex;
			foreach (int item in list)
			{
				if (num2 < item)
				{
					Buffer.BlockCopy(input, num2, base.OutputBuffer, outputLength, item - num2);
					outputLength += item - num2;
					num2 = item;
				}
				base.OutputBuffer[outputLength++] = 61;
				base.OutputBuffer[outputLength++] = 52;
				base.OutputBuffer[outputLength++] = 54;
				num2++;
			}
			Buffer.BlockCopy(input, num2, base.OutputBuffer, outputLength, num - num2);
			outputLength += num - num2;
			return base.OutputBuffer;
		}
		outputLength = num - startIndex;
		outputIndex = 0;
		return input;
	}

	public override void Reset()
	{
		midline = false;
		base.Reset();
	}
}
