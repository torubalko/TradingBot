using System;
using MimeKit.Utils;

namespace MimeKit.Encodings;

public class HexEncoder : IMimeEncoder
{
	private static readonly byte[] hex_alphabet = new byte[16]
	{
		48, 49, 50, 51, 52, 53, 54, 55, 56, 57,
		65, 66, 67, 68, 69, 70
	};

	public ContentEncoding Encoding => ContentEncoding.Default;

	public IMimeEncoder Clone()
	{
		return new HexEncoder();
	}

	public int EstimateOutputLength(int inputLength)
	{
		return inputLength * 3;
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
			throw new ArgumentException("The output buffer is not large enough to contain the encoded input.", "output");
		}
	}

	private unsafe static int Encode(byte* input, int length, byte* output)
	{
		if (length == 0)
		{
			return 0;
		}
		byte* ptr = input + length;
		byte* ptr2 = output;
		byte* ptr3 = input;
		while (ptr3 < ptr)
		{
			byte b = *(ptr3++);
			if (b.IsAttr())
			{
				*(ptr2++) = b;
				continue;
			}
			*(ptr2++) = 37;
			*(ptr2++) = hex_alphabet[(b >> 4) & 0xF];
			*(ptr2++) = hex_alphabet[b & 0xF];
		}
		return (int)(ptr2 - output);
	}

	public unsafe int Encode(byte[] input, int startIndex, int length, byte[] output)
	{
		ValidateArguments(input, startIndex, length, output);
		fixed (byte* ptr = input)
		{
			fixed (byte* output2 = output)
			{
				return Encode(ptr + startIndex, length, output2);
			}
		}
	}

	public int Flush(byte[] input, int startIndex, int length, byte[] output)
	{
		return Encode(input, startIndex, length, output);
	}

	public void Reset()
	{
	}
}
