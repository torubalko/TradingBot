using System;

namespace MimeKit.IO.Filters;

public abstract class MimeFilterBase : IMimeFilter
{
	private int preloadLength;

	private byte[] preload;

	private byte[] output;

	private byte[] inbuf;

	protected byte[] OutputBuffer => output;

	protected abstract byte[] Filter(byte[] input, int startIndex, int length, out int outputIndex, out int outputLength, bool flush);

	private static int GetIdealBufferSize(int need)
	{
		return (need + 63) & -64;
	}

	private byte[] PreFilter(byte[] input, ref int startIndex, ref int length)
	{
		if (preloadLength == 0)
		{
			return input;
		}
		int num = length + preloadLength;
		if (inbuf == null || inbuf.Length < num)
		{
			inbuf = new byte[GetIdealBufferSize(num)];
		}
		Buffer.BlockCopy(preload, 0, inbuf, 0, preloadLength);
		Buffer.BlockCopy(input, startIndex, inbuf, preloadLength, length);
		length = num;
		preloadLength = 0;
		startIndex = 0;
		return inbuf;
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

	public byte[] Filter(byte[] input, int startIndex, int length, out int outputIndex, out int outputLength)
	{
		ValidateArguments(input, startIndex, length);
		input = PreFilter(input, ref startIndex, ref length);
		return Filter(input, startIndex, length, out outputIndex, out outputLength, flush: false);
	}

	public byte[] Flush(byte[] input, int startIndex, int length, out int outputIndex, out int outputLength)
	{
		ValidateArguments(input, startIndex, length);
		input = PreFilter(input, ref startIndex, ref length);
		return Filter(input, startIndex, length, out outputIndex, out outputLength, flush: true);
	}

	public virtual void Reset()
	{
		preloadLength = 0;
	}

	protected void SaveRemainingInput(byte[] input, int startIndex, int length)
	{
		if (length != 0)
		{
			if (preload == null || preload.Length < length)
			{
				preload = new byte[GetIdealBufferSize(length)];
			}
			Buffer.BlockCopy(input, startIndex, preload, 0, length);
			preloadLength = length;
		}
	}

	protected void EnsureOutputSize(int size, bool keep)
	{
		int num = ((output != null) ? output.Length : (-1));
		if (num < size)
		{
			if (keep && output != null)
			{
				Array.Resize(ref output, GetIdealBufferSize(size));
			}
			else
			{
				output = new byte[GetIdealBufferSize(size)];
			}
		}
	}
}
