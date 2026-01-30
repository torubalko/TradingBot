using System;

namespace MimeKit.Encodings;

public class Base64Encoder : IMimeEncoder
{
	private static readonly byte[] base64_alphabet = new byte[64]
	{
		65, 66, 67, 68, 69, 70, 71, 72, 73, 74,
		75, 76, 77, 78, 79, 80, 81, 82, 83, 84,
		85, 86, 87, 88, 89, 90, 97, 98, 99, 100,
		101, 102, 103, 104, 105, 106, 107, 108, 109, 110,
		111, 112, 113, 114, 115, 116, 117, 118, 119, 120,
		121, 122, 48, 49, 50, 51, 52, 53, 54, 55,
		56, 57, 43, 47
	};

	private readonly int quartetsPerLine;

	private readonly bool rfc2047;

	private int quartets;

	private byte saved1;

	private byte saved2;

	private byte saved;

	public ContentEncoding Encoding => ContentEncoding.Base64;

	internal Base64Encoder(bool rfc2047, int maxLineLength = 72)
	{
		if (maxLineLength < 60 || maxLineLength > 998)
		{
			throw new ArgumentOutOfRangeException("maxLineLength");
		}
		quartetsPerLine = maxLineLength / 4;
		this.rfc2047 = rfc2047;
	}

	public Base64Encoder(int maxLineLength = 72)
		: this(rfc2047: false, maxLineLength)
	{
	}

	public IMimeEncoder Clone()
	{
		Base64Encoder base64Encoder = new Base64Encoder(rfc2047, quartetsPerLine * 4);
		base64Encoder.quartets = quartets;
		base64Encoder.saved1 = saved1;
		base64Encoder.saved2 = saved2;
		base64Encoder.saved = saved;
		return base64Encoder;
	}

	public int EstimateOutputLength(int inputLength)
	{
		if (rfc2047)
		{
			return (inputLength + 2) / 3 * 4;
		}
		int num = quartetsPerLine * 4 + 1;
		int num2 = quartetsPerLine * 3;
		return (inputLength + 2) / num2 * num + num;
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

	private unsafe int Encode(byte* input, int length, byte* output)
	{
		if (length == 0)
		{
			return 0;
		}
		int num = length;
		byte* ptr = output;
		byte* ptr2 = input;
		if (length + saved > 2)
		{
			byte* ptr3 = ptr2 + length - 2;
			int num2 = ((saved < 1) ? (*(ptr2++)) : saved1);
			int num3 = ((saved < 2) ? (*(ptr2++)) : saved2);
			int num4 = *(ptr2++);
			while (true)
			{
				*(ptr++) = base64_alphabet[num2 >> 2];
				*(ptr++) = base64_alphabet[(num3 >> 4) | ((num2 & 3) << 4)];
				*(ptr++) = base64_alphabet[((num3 & 0xF) << 2) | (num4 >> 6)];
				*(ptr++) = base64_alphabet[num4 & 0x3F];
				if (!rfc2047 && ++quartets >= quartetsPerLine)
				{
					*(ptr++) = 10;
					quartets = 0;
				}
				if (ptr2 >= ptr3)
				{
					break;
				}
				num2 = *(ptr2++);
				num3 = *(ptr2++);
				num4 = *(ptr2++);
			}
			num = 2 - (int)(ptr2 - ptr3);
			saved = 0;
		}
		if (num > 0)
		{
			if (saved == 0)
			{
				saved = (byte)num;
				saved1 = *(ptr2++);
				if (num == 2)
				{
					saved2 = *ptr2;
				}
				else
				{
					saved2 = 0;
				}
			}
			else
			{
				saved2 = *(ptr2++);
				saved = 2;
			}
		}
		return (int)(ptr - output);
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

	private unsafe int Flush(byte* input, int length, byte* output)
	{
		byte* ptr = output;
		if (length > 0)
		{
			ptr += Encode(input, length, output);
		}
		if (saved >= 1)
		{
			int num = saved1;
			int num2 = saved2;
			*(ptr++) = base64_alphabet[num >> 2];
			*(ptr++) = base64_alphabet[(num2 >> 4) | ((num & 3) << 4)];
			if (saved == 2)
			{
				*(ptr++) = base64_alphabet[(num2 & 0xF) << 2];
			}
			else
			{
				*(ptr++) = 61;
			}
			*(ptr++) = 61;
			quartets++;
		}
		if (!rfc2047 && quartets > 0)
		{
			*(ptr++) = 10;
		}
		Reset();
		return (int)(ptr - output);
	}

	public unsafe int Flush(byte[] input, int startIndex, int length, byte[] output)
	{
		ValidateArguments(input, startIndex, length, output);
		fixed (byte* ptr = input)
		{
			fixed (byte* output2 = output)
			{
				return Flush(ptr + startIndex, length, output2);
			}
		}
	}

	public void Reset()
	{
		quartets = 0;
		saved1 = 0;
		saved2 = 0;
		saved = 0;
	}
}
