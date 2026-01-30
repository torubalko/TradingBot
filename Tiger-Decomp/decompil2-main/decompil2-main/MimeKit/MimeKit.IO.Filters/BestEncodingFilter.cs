using System;

namespace MimeKit.IO.Filters;

public class BestEncodingFilter : IMimeFilter
{
	private readonly byte[] marker = new byte[6];

	private int maxline;

	private int linelen;

	private int count0;

	private int count8;

	private int markerLength;

	private bool hasMarker;

	private int total;

	private byte pc;

	public ContentEncoding GetBestEncoding(EncodingConstraint constraint, int maxLineLength = 78)
	{
		if (maxLineLength < 60 || maxLineLength > 998)
		{
			throw new ArgumentOutOfRangeException("maxLineLength");
		}
		switch (constraint)
		{
		case EncodingConstraint.SevenBit:
			if (count0 > 0)
			{
				return ContentEncoding.Base64;
			}
			if (count8 > 0)
			{
				if (count8 >= (int)((double)total * 0.17))
				{
					return ContentEncoding.Base64;
				}
				return ContentEncoding.QuotedPrintable;
			}
			if (hasMarker || maxline > maxLineLength)
			{
				return ContentEncoding.QuotedPrintable;
			}
			break;
		case EncodingConstraint.EightBit:
			if (count0 > 0)
			{
				return ContentEncoding.Base64;
			}
			if (hasMarker || maxline > maxLineLength)
			{
				return ContentEncoding.QuotedPrintable;
			}
			if (count8 > 0)
			{
				return ContentEncoding.EightBit;
			}
			break;
		case EncodingConstraint.None:
			if (hasMarker || maxline > maxLineLength)
			{
				if (count8 > (int)((double)total * 0.17))
				{
					return ContentEncoding.Base64;
				}
				return ContentEncoding.QuotedPrintable;
			}
			if (count0 > 0)
			{
				return ContentEncoding.Binary;
			}
			if (count8 > 0)
			{
				return ContentEncoding.EightBit;
			}
			break;
		default:
			throw new ArgumentOutOfRangeException("constraint");
		}
		return ContentEncoding.SevenBit;
	}

	private unsafe static bool IsMboxMarker(byte[] marker)
	{
		fixed (byte* ptr = marker)
		{
			uint* ptr2 = (uint*)ptr;
			if ((*ptr2 & 0xFFFFFFFFu) != 1836020294)
			{
				return false;
			}
			return ptr[4] == 32;
		}
	}

	private unsafe void Scan(byte* inptr, byte* inend)
	{
		while (inptr < inend)
		{
			byte b = 0;
			while (inptr < inend && (b = *(inptr++)) != 10)
			{
				if (b == 0)
				{
					count0++;
				}
				else if ((b & 0x80) != 0)
				{
					count8++;
				}
				if (!hasMarker && markerLength < 5)
				{
					marker[markerLength++] = b;
				}
				linelen++;
				pc = b;
			}
			if (b == 10)
			{
				if (pc == 13)
				{
					linelen--;
				}
				maxline = Math.Max(maxline, linelen);
				linelen = 0;
				if (!hasMarker && markerLength == 5 && IsMboxMarker(marker))
				{
					hasMarker = true;
				}
				markerLength = 0;
			}
		}
	}

	private static void ValidateArguments(byte[] input, int startIndex, int length)
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
	}

	public unsafe byte[] Filter(byte[] input, int startIndex, int length, out int outputIndex, out int outputLength)
	{
		ValidateArguments(input, startIndex, length);
		fixed (byte* ptr = input)
		{
			Scan(ptr + startIndex, ptr + startIndex + length);
		}
		maxline = Math.Max(maxline, linelen);
		total += length;
		outputIndex = startIndex;
		outputLength = length;
		return input;
	}

	public byte[] Flush(byte[] input, int startIndex, int length, out int outputIndex, out int outputLength)
	{
		return Filter(input, startIndex, length, out outputIndex, out outputLength);
	}

	public void Reset()
	{
		hasMarker = false;
		markerLength = 0;
		linelen = 0;
		maxline = 0;
		count0 = 0;
		count8 = 0;
		total = 0;
		pc = 0;
	}
}
