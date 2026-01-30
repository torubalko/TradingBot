using System;
using MimeKit.Utils;

namespace MimeKit.Encodings;

public class YEncoder : IMimeEncoder
{
	private readonly int lineLength;

	private byte octets;

	private Crc32 crc;

	public int Checksum => crc.Checksum;

	public ContentEncoding Encoding => ContentEncoding.Default;

	public YEncoder(int maxLineLength = 128)
	{
		if (maxLineLength < 60 || maxLineLength > 998)
		{
			throw new ArgumentOutOfRangeException("maxLineLength");
		}
		lineLength = maxLineLength;
		crc = new Crc32(-1);
		Reset();
	}

	public IMimeEncoder Clone()
	{
		YEncoder yEncoder = new YEncoder(lineLength);
		yEncoder.crc = crc.Clone();
		yEncoder.octets = octets;
		return yEncoder;
	}

	public int EstimateOutputLength(int inputLength)
	{
		return inputLength * 2 + inputLength / lineLength + 1;
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
		byte* ptr = input + length;
		byte* ptr2 = output;
		byte* ptr3 = input;
		while (ptr3 < ptr)
		{
			byte b = *(ptr3++);
			crc.Update(b);
			b += 42;
			if (b == 0 || b == 9 || b == 13 || b == 10 || b == 61 || b == 46)
			{
				*(ptr2++) = 61;
				*(ptr2++) = (byte)(b + 64);
				octets += 2;
			}
			else
			{
				*(ptr2++) = b;
				octets++;
			}
			if (octets >= lineLength)
			{
				*(ptr2++) = 10;
				octets = 0;
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
		if (octets > 0)
		{
			*(ptr++) = 10;
			octets = 0;
		}
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
		crc.Reset();
		octets = 0;
	}
}
