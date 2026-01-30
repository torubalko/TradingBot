using System;
using MimeKit.Utils;

namespace MimeKit.Encodings;

public class HexDecoder : IMimeDecoder
{
	private enum HexDecoderState : byte
	{
		PassThrough,
		Percent,
		DecodeByte
	}

	private HexDecoderState state;

	private byte saved;

	public ContentEncoding Encoding => ContentEncoding.Default;

	public IMimeDecoder Clone()
	{
		HexDecoder hexDecoder = new HexDecoder();
		hexDecoder.state = state;
		hexDecoder.saved = saved;
		return hexDecoder;
	}

	public int EstimateOutputLength(int inputLength)
	{
		return state switch
		{
			HexDecoderState.PassThrough => inputLength, 
			HexDecoderState.Percent => inputLength + 1, 
			_ => inputLength + 2, 
		};
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
			switch (state)
			{
			case HexDecoderState.PassThrough:
				while (ptr3 < ptr)
				{
					byte b = *(ptr3++);
					if (b == 37)
					{
						state = HexDecoderState.Percent;
						break;
					}
					*(ptr2++) = b;
				}
				break;
			case HexDecoderState.Percent:
			{
				byte b = *(ptr3++);
				state = HexDecoderState.DecodeByte;
				saved = b;
				break;
			}
			case HexDecoderState.DecodeByte:
			{
				byte b = *(ptr3++);
				if (b.IsXDigit() && saved.IsXDigit())
				{
					saved = saved.ToXDigit();
					b = b.ToXDigit();
					*(ptr2++) = (byte)((saved << 4) | b);
				}
				else
				{
					*(ptr2++) = 37;
					*(ptr2++) = saved;
					*(ptr2++) = b;
				}
				state = HexDecoderState.PassThrough;
				break;
			}
			}
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
		state = HexDecoderState.PassThrough;
		saved = 0;
	}
}
