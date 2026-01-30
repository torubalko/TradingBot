using System;

namespace MimeKit.Encodings;

public class UUEncoder : IMimeEncoder
{
	private const int MaxInputPerLine = 45;

	private const int MaxOutputPerLine = 62;

	private readonly byte[] uubuf = new byte[60];

	private uint saved;

	private byte nsaved;

	private byte uulen;

	public ContentEncoding Encoding => ContentEncoding.UUEncode;

	public IMimeEncoder Clone()
	{
		UUEncoder uUEncoder = new UUEncoder();
		Buffer.BlockCopy(uubuf, 0, uUEncoder.uubuf, 0, uubuf.Length);
		uUEncoder.nsaved = nsaved;
		uUEncoder.saved = saved;
		uUEncoder.uulen = uulen;
		return uUEncoder;
	}

	public int EstimateOutputLength(int inputLength)
	{
		return (inputLength + 2) / 45 * 62 + 62 + 2;
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

	private static byte Encode(int c)
	{
		if (c == 0)
		{
			return 96;
		}
		return (byte)(c + 32);
	}

	private unsafe int Encode(byte* input, int length, byte[] outbuf, byte* output, byte* uuptr)
	{
		if (length == 0)
		{
			return 0;
		}
		byte* ptr = input + length;
		byte* ptr2 = output;
		byte* ptr3 = input;
		byte* ptr4;
		if (length + nsaved + uulen < 45)
		{
			ptr4 = uuptr + uulen / 3 * 4;
		}
		else
		{
			ptr4 = ptr2 + 1;
			if (uulen > 0)
			{
				int num = uulen / 3 * 4;
				Buffer.BlockCopy(uubuf, 0, outbuf, 1, num);
				ptr4 += num;
			}
		}
		if (nsaved == 2)
		{
			byte b = (byte)((saved >> 8) & 0xFF);
			byte b2 = (byte)(saved & 0xFF);
			byte b3 = *(ptr3++);
			nsaved = 0;
			saved = 0u;
			*(ptr4++) = Encode((b >> 2) & 0x3F);
			*(ptr4++) = Encode(((b << 4) | ((b2 >> 4) & 0xF)) & 0x3F);
			*(ptr4++) = Encode(((b2 << 2) | ((b3 >> 6) & 3)) & 0x3F);
			*(ptr4++) = Encode(b3 & 0x3F);
			uulen += 3;
		}
		else if (nsaved == 1)
		{
			if (ptr3 + 2 < ptr)
			{
				byte b = (byte)(saved & 0xFF);
				byte b2 = *(ptr3++);
				byte b3 = *(ptr3++);
				nsaved = 0;
				saved = 0u;
				*(ptr4++) = Encode((b >> 2) & 0x3F);
				*(ptr4++) = Encode(((b << 4) | ((b2 >> 4) & 0xF)) & 0x3F);
				*(ptr4++) = Encode(((b2 << 2) | ((b3 >> 6) & 3)) & 0x3F);
				*(ptr4++) = Encode(b3 & 0x3F);
				uulen += 3;
			}
			else
			{
				while (ptr3 < ptr)
				{
					saved = (saved << 8) | *(ptr3++);
					nsaved++;
				}
			}
		}
		while (true)
		{
			if (uulen < 45 && ptr3 + 2 < ptr)
			{
				byte b = *(ptr3++);
				byte b2 = *(ptr3++);
				byte b3 = *(ptr3++);
				*(ptr4++) = Encode((b >> 2) & 0x3F);
				*(ptr4++) = Encode(((b << 4) | ((b2 >> 4) & 0xF)) & 0x3F);
				*(ptr4++) = Encode(((b2 << 2) | ((b3 >> 6) & 3)) & 0x3F);
				*(ptr4++) = Encode(b3 & 0x3F);
				uulen += 3;
				continue;
			}
			if (uulen >= 45)
			{
				*ptr2 = Encode(uulen);
				ptr2 += uulen / 3 * 4 + 1;
				*(ptr2++) = 10;
				uulen = 0;
				ptr4 = ((ptr3 + 45 > ptr) ? uuptr : (ptr2 + 1));
			}
			else
			{
				while (ptr3 < ptr)
				{
					saved = (saved << 8) | *(ptr3++);
					nsaved++;
				}
			}
			if (ptr3 >= ptr)
			{
				break;
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
				fixed (byte* uuptr = uubuf)
				{
					return Encode(ptr + startIndex, length, output, output2, uuptr);
				}
			}
		}
	}

	private unsafe int Flush(byte* input, int length, byte[] outbuf, byte* output, byte* uuptr)
	{
		byte* ptr = output;
		if (length > 0)
		{
			ptr += Encode(input, length, outbuf, output, uuptr);
		}
		byte* ptr2 = uuptr + uulen / 3 * 4;
		byte b = 0;
		if (nsaved > 0)
		{
			while (nsaved < 3)
			{
				saved <<= 8;
				b++;
				nsaved++;
			}
			if (nsaved == 3)
			{
				byte b2 = (byte)((saved >> 16) & 0xFF);
				byte b3 = (byte)((saved >> 8) & 0xFF);
				byte b4 = (byte)(saved & 0xFF);
				*(ptr2++) = Encode((b2 >> 2) & 0x3F);
				*(ptr2++) = Encode(((b2 << 4) | ((b3 >> 4) & 0xF)) & 0x3F);
				*(ptr2++) = Encode(((b3 << 2) | ((b4 >> 6) & 3)) & 0x3F);
				*(ptr2++) = Encode(b4 & 0x3F);
				uulen += 3;
				nsaved = 0;
				saved = 0u;
			}
		}
		if (uulen > 0)
		{
			int num = uulen / 3 * 4;
			*(ptr++) = Encode((uulen - b) & 0xFF);
			Buffer.BlockCopy(uubuf, 0, outbuf, (int)(ptr - output), num);
			ptr += num;
			*(ptr++) = 10;
			uulen = 0;
		}
		*(ptr++) = Encode(uulen & 0xFF);
		*(ptr++) = 10;
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
				fixed (byte* uuptr = uubuf)
				{
					return Flush(ptr + startIndex, length, output, output2, uuptr);
				}
			}
		}
	}

	public void Reset()
	{
		nsaved = 0;
		saved = 0u;
		uulen = 0;
	}
}
