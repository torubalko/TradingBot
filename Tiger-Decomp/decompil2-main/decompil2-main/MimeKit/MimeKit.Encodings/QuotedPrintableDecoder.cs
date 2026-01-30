using System;
using MimeKit.Utils;

namespace MimeKit.Encodings;

public class QuotedPrintableDecoder : IMimeDecoder
{
	private enum QpDecoderState : byte
	{
		PassThrough,
		EqualSign,
		SoftBreak,
		DecodeByte
	}

	private readonly bool rfc2047;

	private QpDecoderState state;

	private byte saved;

	public ContentEncoding Encoding => ContentEncoding.QuotedPrintable;

	public QuotedPrintableDecoder(bool rfc2047)
	{
		this.rfc2047 = rfc2047;
	}

	public QuotedPrintableDecoder()
		: this(rfc2047: false)
	{
	}

	public IMimeDecoder Clone()
	{
		QuotedPrintableDecoder quotedPrintableDecoder = new QuotedPrintableDecoder(rfc2047);
		quotedPrintableDecoder.state = state;
		quotedPrintableDecoder.saved = saved;
		return quotedPrintableDecoder;
	}

	public int EstimateOutputLength(int inputLength)
	{
		return state switch
		{
			QpDecoderState.PassThrough => inputLength, 
			QpDecoderState.EqualSign => inputLength + 1, 
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
			case QpDecoderState.PassThrough:
				while (ptr3 < ptr)
				{
					byte b = *(ptr3++);
					if (b == 61)
					{
						state = QpDecoderState.EqualSign;
						break;
					}
					if (rfc2047 && b == 95)
					{
						*(ptr2++) = 32;
					}
					else
					{
						*(ptr2++) = b;
					}
				}
				break;
			case QpDecoderState.EqualSign:
			{
				byte b = *(ptr3++);
				if (b.IsXDigit())
				{
					state = QpDecoderState.DecodeByte;
					saved = b;
					break;
				}
				switch (b)
				{
				case 61:
					*(ptr2++) = 61;
					break;
				case 13:
					state = QpDecoderState.SoftBreak;
					break;
				case 10:
					state = QpDecoderState.PassThrough;
					break;
				default:
					state = QpDecoderState.PassThrough;
					*(ptr2++) = 61;
					*(ptr2++) = b;
					break;
				}
				break;
			}
			case QpDecoderState.SoftBreak:
			{
				state = QpDecoderState.PassThrough;
				byte b = *(ptr3++);
				if (b != 10)
				{
					*(ptr2++) = 61;
					*(ptr2++) = 13;
					*(ptr2++) = b;
				}
				break;
			}
			case QpDecoderState.DecodeByte:
			{
				byte b = *(ptr3++);
				if (b.IsXDigit())
				{
					saved = saved.ToXDigit();
					b = b.ToXDigit();
					*(ptr2++) = (byte)((saved << 4) | b);
				}
				else
				{
					*(ptr2++) = 61;
					*(ptr2++) = saved;
					*(ptr2++) = b;
				}
				state = QpDecoderState.PassThrough;
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
		state = QpDecoderState.PassThrough;
		saved = 0;
	}
}
