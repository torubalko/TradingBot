using System;
using MimeKit.Utils;

namespace MimeKit.Encodings;

public class QuotedPrintableEncoder : IMimeEncoder
{
	private static readonly byte[] hex_alphabet = new byte[16]
	{
		48, 49, 50, 51, 52, 53, 54, 55, 56, 57,
		65, 66, 67, 68, 69, 70
	};

	private const int TripletsPerLine = 23;

	private const int DesiredLineLength = 69;

	private const int MaxLineLength = 71;

	private short currentLineLength;

	private short saved;

	public ContentEncoding Encoding => ContentEncoding.QuotedPrintable;

	public QuotedPrintableEncoder()
	{
		Reset();
	}

	public IMimeEncoder Clone()
	{
		QuotedPrintableEncoder quotedPrintableEncoder = new QuotedPrintableEncoder();
		quotedPrintableEncoder.currentLineLength = currentLineLength;
		quotedPrintableEncoder.saved = saved;
		return quotedPrintableEncoder;
	}

	public int EstimateOutputLength(int inputLength)
	{
		return inputLength / 23 * 71 + 71;
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
		byte* ptr = input + length;
		byte* ptr2 = output;
		byte* ptr3 = input;
		while (ptr3 < ptr)
		{
			byte b = *(ptr3++);
			switch (b)
			{
			case 13:
				if (saved != -1)
				{
					*(ptr2++) = 61;
					*(ptr2++) = hex_alphabet[(saved >> 4) & 0xF];
					*(ptr2++) = hex_alphabet[saved & 0xF];
					currentLineLength += 3;
				}
				saved = b;
				continue;
			case 10:
				if (saved != -1 && saved != 13)
				{
					*(ptr2++) = 61;
					*(ptr2++) = hex_alphabet[(saved >> 4) & 0xF];
					*(ptr2++) = hex_alphabet[saved & 0xF];
				}
				*(ptr2++) = 10;
				currentLineLength = 0;
				saved = -1;
				continue;
			}
			if (saved != -1)
			{
				byte b2 = (byte)saved;
				if (b2.IsQpSafe())
				{
					*(ptr2++) = b2;
					currentLineLength++;
				}
				else
				{
					*(ptr2++) = 61;
					*(ptr2++) = hex_alphabet[(saved >> 4) & 0xF];
					*(ptr2++) = hex_alphabet[saved & 0xF];
				}
			}
			if (currentLineLength > 69)
			{
				*(ptr2++) = 61;
				*(ptr2++) = 10;
				currentLineLength = 0;
			}
			if (b.IsQpSafe())
			{
				if (b.IsBlank())
				{
					saved = b;
					continue;
				}
				*(ptr2++) = b;
				currentLineLength++;
				saved = -1;
			}
			else
			{
				*(ptr2++) = 61;
				*(ptr2++) = hex_alphabet[(b >> 4) & 0xF];
				*(ptr2++) = hex_alphabet[b & 0xF];
				currentLineLength += 3;
				saved = -1;
			}
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

	private unsafe int Flush(byte* input, int length, byte* output)
	{
		byte* ptr = output;
		if (length > 0)
		{
			ptr += Encode(input, length, output);
		}
		if (saved != -1)
		{
			byte b = (byte)saved;
			if (b.IsBlank() || !b.IsQpSafe())
			{
				*(ptr++) = 61;
				*(ptr++) = hex_alphabet[(saved >> 4) & 0xF];
				*(ptr++) = hex_alphabet[saved & 0xF];
			}
			else
			{
				*(ptr++) = b;
			}
			*(ptr++) = 61;
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
		currentLineLength = 0;
		saved = -1;
	}
}
