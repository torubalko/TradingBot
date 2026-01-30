using System;

namespace MimeKit.Encodings;

public class PassThroughDecoder : IMimeDecoder
{
	public ContentEncoding Encoding { get; private set; }

	public PassThroughDecoder(ContentEncoding encoding)
	{
		Encoding = encoding;
	}

	public IMimeDecoder Clone()
	{
		return new PassThroughDecoder(Encoding);
	}

	public int EstimateOutputLength(int inputLength)
	{
		return inputLength;
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
			*(ptr2++) = *(ptr3++);
		}
		return length;
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
	}
}
