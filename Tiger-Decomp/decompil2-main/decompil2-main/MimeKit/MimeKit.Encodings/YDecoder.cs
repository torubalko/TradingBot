using System;
using MimeKit.Utils;

namespace MimeKit.Encodings;

public class YDecoder : IMimeDecoder
{
	private enum YDecoderState : byte
	{
		ExpectYBegin,
		YBeginEqual,
		YBeginEqualY,
		YBeginEqualYB,
		YBeginEqualYBe,
		YBeginEqualYBeg,
		YBeginEqualYBegi,
		YBeginEqualYBegin,
		ExpectYBeginNewLine,
		ExpectYPartOrPayload,
		YPartEqual,
		YPartEqualY,
		YPartEqualYP,
		YPartEqualYPa,
		YPartEqualYPar,
		YPartEqualYPart,
		ExpectYPartNewLine,
		Payload,
		Ended
	}

	private readonly YDecoderState initial;

	private YDecoderState state;

	private bool escaped;

	private byte octet;

	private bool eoln;

	private Crc32 crc;

	public int Checksum => crc.Checksum;

	public ContentEncoding Encoding => ContentEncoding.Default;

	public YDecoder(bool payloadOnly)
	{
		initial = (payloadOnly ? YDecoderState.Payload : YDecoderState.ExpectYBegin);
		crc = new Crc32(-1);
		Reset();
	}

	public YDecoder()
		: this(payloadOnly: false)
	{
	}

	public IMimeDecoder Clone()
	{
		YDecoder yDecoder = new YDecoder(initial == YDecoderState.Payload);
		yDecoder.crc = crc.Clone();
		yDecoder.escaped = escaped;
		yDecoder.state = state;
		yDecoder.octet = octet;
		yDecoder.eoln = eoln;
		return yDecoder;
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

	private unsafe byte* ScanYBeginMarker(byte* inptr, byte* inend)
	{
		while (inptr < inend)
		{
			if (state == YDecoderState.ExpectYBegin)
			{
				if (octet != 10)
				{
					while (inptr < inend && *inptr != 10)
					{
						inptr++;
					}
					if (inptr == inend)
					{
						octet = *(inptr - 1);
						break;
					}
					octet = *(inptr++);
					if (inptr == inend)
					{
						break;
					}
				}
				octet = *(inptr++);
				if (octet != 61)
				{
					continue;
				}
				state = YDecoderState.YBeginEqual;
				if (inptr == inend)
				{
					break;
				}
			}
			if (state == YDecoderState.YBeginEqual)
			{
				octet = *(inptr++);
				if (octet != 121)
				{
					state = YDecoderState.ExpectYBegin;
					continue;
				}
				state = YDecoderState.YBeginEqualY;
				if (inptr == inend)
				{
					break;
				}
			}
			if (state == YDecoderState.YBeginEqualY)
			{
				octet = *(inptr++);
				if (octet != 98)
				{
					state = YDecoderState.ExpectYBegin;
					continue;
				}
				state = YDecoderState.YBeginEqualYB;
				if (inptr == inend)
				{
					break;
				}
			}
			if (state == YDecoderState.YBeginEqualYB)
			{
				octet = *(inptr++);
				if (octet != 101)
				{
					state = YDecoderState.ExpectYBegin;
					continue;
				}
				state = YDecoderState.YBeginEqualYBe;
				if (inptr == inend)
				{
					break;
				}
			}
			if (state == YDecoderState.YBeginEqualYBe)
			{
				octet = *(inptr++);
				if (octet != 103)
				{
					state = YDecoderState.ExpectYBegin;
					continue;
				}
				state = YDecoderState.YBeginEqualYBeg;
				if (inptr == inend)
				{
					break;
				}
			}
			if (state == YDecoderState.YBeginEqualYBeg)
			{
				octet = *(inptr++);
				if (octet != 105)
				{
					state = YDecoderState.ExpectYBegin;
					continue;
				}
				state = YDecoderState.YBeginEqualYBegi;
				if (inptr == inend)
				{
					break;
				}
			}
			if (state == YDecoderState.YBeginEqualYBegi)
			{
				octet = *(inptr++);
				if (octet != 110)
				{
					state = YDecoderState.ExpectYBegin;
					continue;
				}
				state = YDecoderState.YBeginEqualYBegin;
				if (inptr == inend)
				{
					break;
				}
			}
			if (state == YDecoderState.YBeginEqualYBegin)
			{
				octet = *(inptr++);
				if (octet != 32)
				{
					state = YDecoderState.ExpectYBegin;
					continue;
				}
				state = YDecoderState.ExpectYBeginNewLine;
				if (inptr == inend)
				{
					break;
				}
			}
			if (state == YDecoderState.ExpectYBeginNewLine)
			{
				while (inptr < inend && *inptr != 10)
				{
					inptr++;
				}
				if (inptr == inend)
				{
					octet = *(inptr - 1);
					break;
				}
				state = YDecoderState.ExpectYPartOrPayload;
				octet = *(inptr++);
				if (inptr == inend)
				{
					break;
				}
			}
			if (state == YDecoderState.ExpectYPartOrPayload)
			{
				if (*inptr != 61)
				{
					state = YDecoderState.Payload;
					escaped = false;
					eoln = true;
					break;
				}
				state = YDecoderState.YPartEqual;
				octet = *(inptr++);
				escaped = true;
				if (inptr == inend)
				{
					break;
				}
			}
			if (state == YDecoderState.YPartEqual)
			{
				if (*inptr != 121)
				{
					state = YDecoderState.Payload;
					escaped = false;
					eoln = true;
					return inptr;
				}
				state = YDecoderState.YPartEqualY;
				octet = *(inptr++);
				if (inptr == inend)
				{
					break;
				}
			}
			if (state == YDecoderState.YPartEqualY)
			{
				if (*inptr == 101)
				{
					state = YDecoderState.Ended;
					return inptr;
				}
				if (*inptr != 112)
				{
					state = YDecoderState.ExpectYBeginNewLine;
					continue;
				}
				state = YDecoderState.YPartEqualYP;
				octet = *(inptr++);
				if (inptr == inend)
				{
					break;
				}
			}
			if (state == YDecoderState.YPartEqualYP)
			{
				if (*inptr != 97)
				{
					state = YDecoderState.ExpectYBeginNewLine;
					continue;
				}
				state = YDecoderState.YPartEqualYPa;
				octet = *(inptr++);
				if (inptr == inend)
				{
					break;
				}
			}
			if (state == YDecoderState.YPartEqualYPa)
			{
				if (*inptr != 114)
				{
					state = YDecoderState.ExpectYBeginNewLine;
					continue;
				}
				state = YDecoderState.YPartEqualYPar;
				octet = *(inptr++);
				if (inptr == inend)
				{
					break;
				}
			}
			if (state == YDecoderState.YPartEqualYPar)
			{
				if (*inptr != 116)
				{
					state = YDecoderState.ExpectYBeginNewLine;
					continue;
				}
				state = YDecoderState.YPartEqualYPart;
				octet = *(inptr++);
				if (inptr == inend)
				{
					break;
				}
			}
			if (state == YDecoderState.YPartEqualYPart)
			{
				if (*inptr != 32)
				{
					state = YDecoderState.ExpectYBeginNewLine;
					continue;
				}
				state = YDecoderState.ExpectYPartNewLine;
				octet = *(inptr++);
				if (inptr == inend)
				{
					break;
				}
			}
			if (state == YDecoderState.ExpectYPartNewLine)
			{
				while (inptr < inend && *inptr != 10)
				{
					inptr++;
				}
				if (inptr == inend)
				{
					octet = *(inptr - 1);
					break;
				}
				state = YDecoderState.Payload;
				octet = *(inptr++);
				escaped = false;
				eoln = true;
				break;
			}
		}
		return inptr;
	}

	public unsafe int Decode(byte* input, int length, byte* output)
	{
		byte* ptr = input + length;
		byte* ptr2 = output;
		byte* ptr3 = input;
		if ((int)state < 17 && (ptr3 = ScanYBeginMarker(ptr3, ptr)) == ptr)
		{
			return 0;
		}
		if (state == YDecoderState.Ended)
		{
			return 0;
		}
		while (ptr3 < ptr)
		{
			octet = *(ptr3++);
			if (octet == 13)
			{
				escaped = false;
				continue;
			}
			if (octet == 10)
			{
				escaped = false;
				eoln = true;
				continue;
			}
			if (escaped)
			{
				if (eoln && octet == 121)
				{
					state = YDecoderState.Ended;
					break;
				}
				escaped = false;
				eoln = false;
				octet -= 64;
			}
			else
			{
				if (octet == 61)
				{
					escaped = true;
					continue;
				}
				eoln = false;
			}
			octet -= 42;
			crc.Update(octet);
			*(ptr2++) = octet;
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
		octet = 10;
		state = initial;
		escaped = false;
		eoln = true;
		crc.Reset();
	}
}
