using System;

namespace MimeKit.Encodings;

public class PassThroughEncoder : IMimeEncoder
{
	public ContentEncoding Encoding { get; private set; }

	public PassThroughEncoder(ContentEncoding encoding)
	{
		Encoding = encoding;
	}

	public IMimeEncoder Clone()
	{
		return new PassThroughEncoder(Encoding);
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
			throw new ArgumentException("The output buffer is not large enough to contain the encoded input.", "output");
		}
	}

	public int Encode(byte[] input, int startIndex, int length, byte[] output)
	{
		ValidateArguments(input, startIndex, length, output);
		Buffer.BlockCopy(input, startIndex, output, 0, length);
		return length;
	}

	public int Flush(byte[] input, int startIndex, int length, byte[] output)
	{
		return Encode(input, startIndex, length, output);
	}

	public void Reset()
	{
	}
}
