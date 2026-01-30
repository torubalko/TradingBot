using System;

namespace MimeKit.Encodings;

public class Base64Decoder : IMimeDecoder
{
	private static readonly byte[] base64_rank = new byte[256]
	{
		255, 255, 255, 255, 255, 255, 255, 255, 255, 255,
		255, 255, 255, 255, 255, 255, 255, 255, 255, 255,
		255, 255, 255, 255, 255, 255, 255, 255, 255, 255,
		255, 255, 255, 255, 255, 255, 255, 255, 255, 255,
		255, 255, 255, 62, 255, 255, 255, 63, 52, 53,
		54, 55, 56, 57, 58, 59, 60, 61, 255, 255,
		255, 0, 255, 255, 255, 0, 1, 2, 3, 4,
		5, 6, 7, 8, 9, 10, 11, 12, 13, 14,
		15, 16, 17, 18, 19, 20, 21, 22, 23, 24,
		25, 255, 255, 255, 255, 255, 255, 26, 27, 28,
		29, 30, 31, 32, 33, 34, 35, 36, 37, 38,
		39, 40, 41, 42, 43, 44, 45, 46, 47, 48,
		49, 50, 51, 255, 255, 255, 255, 255, 255, 255,
		255, 255, 255, 255, 255, 255, 255, 255, 255, 255,
		255, 255, 255, 255, 255, 255, 255, 255, 255, 255,
		255, 255, 255, 255, 255, 255, 255, 255, 255, 255,
		255, 255, 255, 255, 255, 255, 255, 255, 255, 255,
		255, 255, 255, 255, 255, 255, 255, 255, 255, 255,
		255, 255, 255, 255, 255, 255, 255, 255, 255, 255,
		255, 255, 255, 255, 255, 255, 255, 255, 255, 255,
		255, 255, 255, 255, 255, 255, 255, 255, 255, 255,
		255, 255, 255, 255, 255, 255, 255, 255, 255, 255,
		255, 255, 255, 255, 255, 255, 255, 255, 255, 255,
		255, 255, 255, 255, 255, 255, 255, 255, 255, 255,
		255, 255, 255, 255, 255, 255, 255, 255, 255, 255,
		255, 255, 255, 255, 255, 255
	};

	private int previous;

	private uint saved;

	private byte bytes;

	public ContentEncoding Encoding => ContentEncoding.Base64;

	public IMimeDecoder Clone()
	{
		Base64Decoder base64Decoder = new Base64Decoder();
		base64Decoder.previous = previous;
		base64Decoder.saved = saved;
		base64Decoder.bytes = bytes;
		return base64Decoder;
	}

	public int EstimateOutputLength(int inputLength)
	{
		return inputLength + 3;
	}

	private void ValidateArguments(byte[] input, int startIndex, int length, byte[] output)
	{
		if (input == null)
		{
			throw new ArgumentNullException("input");
		}
		if (startIndex < 0 || startIndex > input.Length)
		{
			throw new ArgumentOutOfRangeException("startIndex");
		}
		if (length < 0 || length > input.Length - startIndex)
		{
			throw new ArgumentOutOfRangeException("length");
		}
		if (output == null)
		{
			throw new ArgumentNullException("output");
		}
		if (output.Length < EstimateOutputLength(length))
		{
			throw new ArgumentException("The output buffer is not large enough to contain the decoded input.", "output");
		}
	}

	public unsafe int Decode(byte* input, int length, byte* output)
	{
		byte* ptr = input + length;
		byte* ptr2 = output;
		byte* ptr3 = input;
		while (ptr3 < ptr)
		{
			byte b2;
			byte b = base64_rank[b2 = *(ptr3++)];
			if (b == byte.MaxValue)
			{
				continue;
			}
			previous = (previous << 8) | b2;
			saved = (saved << 6) | b;
			bytes++;
			if (bytes != 4)
			{
				continue;
			}
			if ((previous & 0xFF0000) != 3997696)
			{
				*(ptr2++) = (byte)((saved >> 16) & 0xFF);
				if ((previous & 0xFF00) != 15616)
				{
					*(ptr2++) = (byte)((saved >> 8) & 0xFF);
					if ((previous & 0xFF) != 61)
					{
						*(ptr2++) = (byte)(saved & 0xFF);
					}
				}
			}
			saved = 0u;
			bytes = 0;
		}
		return (int)(ptr2 - output);
	}

	public unsafe int Decode(byte[] input, int startIndex, int length, byte[] output)
	{
		ValidateArguments(input, startIndex, length, output);
		fixed (byte* ptr = input)
		{
			fixed (byte* output2 = output)
			{
				return Decode(ptr + startIndex, length, output2);
			}
		}
	}

	public void Reset()
	{
		previous = 0;
		saved = 0u;
		bytes = 0;
	}
}
