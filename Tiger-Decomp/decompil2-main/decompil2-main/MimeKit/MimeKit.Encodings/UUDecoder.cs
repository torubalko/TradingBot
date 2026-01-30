using System;

namespace MimeKit.Encodings;

public class UUDecoder : IMimeDecoder
{
	private enum UUDecoderState : byte
	{
		ExpectBegin,
		B,
		Be,
		Beg,
		Begi,
		Begin,
		ExpectPayload,
		Payload,
		Ended
	}

	private static readonly byte[] uudecode_rank = new byte[256]
	{
		32, 33, 34, 35, 36, 37, 38, 39, 40, 41,
		42, 43, 44, 45, 46, 47, 48, 49, 50, 51,
		52, 53, 54, 55, 56, 57, 58, 59, 60, 61,
		62, 63, 0, 1, 2, 3, 4, 5, 6, 7,
		8, 9, 10, 11, 12, 13, 14, 15, 16, 17,
		18, 19, 20, 21, 22, 23, 24, 25, 26, 27,
		28, 29, 30, 31, 32, 33, 34, 35, 36, 37,
		38, 39, 40, 41, 42, 43, 44, 45, 46, 47,
		48, 49, 50, 51, 52, 53, 54, 55, 56, 57,
		58, 59, 60, 61, 62, 63, 0, 1, 2, 3,
		4, 5, 6, 7, 8, 9, 10, 11, 12, 13,
		14, 15, 16, 17, 18, 19, 20, 21, 22, 23,
		24, 25, 26, 27, 28, 29, 30, 31, 32, 33,
		34, 35, 36, 37, 38, 39, 40, 41, 42, 43,
		44, 45, 46, 47, 48, 49, 50, 51, 52, 53,
		54, 55, 56, 57, 58, 59, 60, 61, 62, 63,
		0, 1, 2, 3, 4, 5, 6, 7, 8, 9,
		10, 11, 12, 13, 14, 15, 16, 17, 18, 19,
		20, 21, 22, 23, 24, 25, 26, 27, 28, 29,
		30, 31, 32, 33, 34, 35, 36, 37, 38, 39,
		40, 41, 42, 43, 44, 45, 46, 47, 48, 49,
		50, 51, 52, 53, 54, 55, 56, 57, 58, 59,
		60, 61, 62, 63, 0, 1, 2, 3, 4, 5,
		6, 7, 8, 9, 10, 11, 12, 13, 14, 15,
		16, 17, 18, 19, 20, 21, 22, 23, 24, 25,
		26, 27, 28, 29, 30, 31
	};

	private readonly UUDecoderState initial;

	private UUDecoderState state;

	private byte nsaved;

	private byte uulen;

	private uint saved;

	public ContentEncoding Encoding => ContentEncoding.UUEncode;

	public UUDecoder(bool payloadOnly)
	{
		initial = (payloadOnly ? UUDecoderState.Payload : UUDecoderState.ExpectBegin);
		Reset();
	}

	public UUDecoder()
		: this(payloadOnly: false)
	{
	}

	public IMimeDecoder Clone()
	{
		UUDecoder uUDecoder = new UUDecoder(initial == UUDecoderState.Payload);
		uUDecoder.state = state;
		uUDecoder.nsaved = nsaved;
		uUDecoder.saved = saved;
		uUDecoder.uulen = uulen;
		return uUDecoder;
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

	private unsafe byte* ScanBeginMarker(byte* inptr, byte* inend)
	{
		while (inptr < inend)
		{
			if (state == UUDecoderState.ExpectBegin)
			{
				if (nsaved != 0 && nsaved != 10)
				{
					while (inptr < inend && *inptr != 10)
					{
						inptr++;
					}
					if (inptr == inend)
					{
						nsaved = *(inptr - 1);
						return inptr;
					}
					nsaved = *(inptr++);
					if (inptr == inend)
					{
						return inptr;
					}
				}
				nsaved = *(inptr++);
				if (nsaved != 98)
				{
					continue;
				}
				state = UUDecoderState.B;
				if (inptr == inend)
				{
					return inptr;
				}
			}
			if (state == UUDecoderState.B)
			{
				nsaved = *(inptr++);
				if (nsaved != 101)
				{
					state = UUDecoderState.ExpectBegin;
					continue;
				}
				state = UUDecoderState.Be;
				if (inptr == inend)
				{
					return inptr;
				}
			}
			if (state == UUDecoderState.Be)
			{
				nsaved = *(inptr++);
				if (nsaved != 103)
				{
					state = UUDecoderState.ExpectBegin;
					continue;
				}
				state = UUDecoderState.Beg;
				if (inptr == inend)
				{
					return inptr;
				}
			}
			if (state == UUDecoderState.Beg)
			{
				nsaved = *(inptr++);
				if (nsaved != 105)
				{
					state = UUDecoderState.ExpectBegin;
					continue;
				}
				state = UUDecoderState.Begi;
				if (inptr == inend)
				{
					return inptr;
				}
			}
			if (state == UUDecoderState.Begi)
			{
				nsaved = *(inptr++);
				if (nsaved != 110)
				{
					state = UUDecoderState.ExpectBegin;
					continue;
				}
				state = UUDecoderState.Begin;
				if (inptr == inend)
				{
					return inptr;
				}
			}
			if (state == UUDecoderState.Begin)
			{
				nsaved = *(inptr++);
				if (nsaved != 32)
				{
					state = UUDecoderState.ExpectBegin;
					continue;
				}
				state = UUDecoderState.ExpectPayload;
				if (inptr == inend)
				{
					return inptr;
				}
			}
			if (state == UUDecoderState.ExpectPayload)
			{
				while (inptr < inend && *inptr != 10)
				{
					inptr++;
				}
				if (inptr == inend)
				{
					return inptr;
				}
				state = UUDecoderState.Payload;
				nsaved = 0;
				return inptr + 1;
			}
		}
		return inptr;
	}

	public unsafe int Decode(byte* input, int length, byte* output)
	{
		if (state == UUDecoderState.Ended)
		{
			return 0;
		}
		bool flag = uulen == 0;
		byte* ptr = input + length;
		byte* ptr2 = output;
		byte* ptr3 = input;
		if ((int)state < 7 && (ptr3 = ScanBeginMarker(ptr3, ptr)) == ptr)
		{
			return 0;
		}
		while (ptr3 < ptr)
		{
			if (*ptr3 == 13)
			{
				ptr3++;
				continue;
			}
			if (*ptr3 == 10)
			{
				flag = true;
				ptr3++;
				continue;
			}
			if (uulen == 0 || flag)
			{
				uulen = uudecode_rank[*ptr3];
				flag = false;
				if (uulen == 0)
				{
					state = UUDecoderState.Ended;
					break;
				}
				ptr3++;
				continue;
			}
			byte b = *(ptr3++);
			if (uulen <= 0)
			{
				break;
			}
			saved = (saved << 8) | b;
			nsaved++;
			if (nsaved != 4)
			{
				continue;
			}
			byte b2 = (byte)((saved >> 24) & 0xFF);
			byte b3 = (byte)((saved >> 16) & 0xFF);
			byte b4 = (byte)((saved >> 8) & 0xFF);
			byte b5 = (byte)(saved & 0xFF);
			if (uulen >= 3)
			{
				*(ptr2++) = (byte)((uudecode_rank[b2] << 2) | (uudecode_rank[b3] >> 4));
				*(ptr2++) = (byte)((uudecode_rank[b3] << 4) | (uudecode_rank[b4] >> 2));
				*(ptr2++) = (byte)((uudecode_rank[b4] << 6) | uudecode_rank[b5]);
				uulen -= 3;
			}
			else
			{
				if (uulen >= 1)
				{
					*(ptr2++) = (byte)((uudecode_rank[b2] << 2) | (uudecode_rank[b3] >> 4));
					uulen--;
				}
				if (uulen >= 1)
				{
					*(ptr2++) = (byte)((uudecode_rank[b3] << 4) | (uudecode_rank[b4] >> 2));
					uulen--;
				}
			}
			nsaved = 0;
			saved = 0u;
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
		state = initial;
		nsaved = 0;
		saved = 0u;
		uulen = 0;
	}
}
