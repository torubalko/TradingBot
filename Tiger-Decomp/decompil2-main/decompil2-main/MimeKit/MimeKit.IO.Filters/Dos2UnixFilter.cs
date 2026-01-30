namespace MimeKit.IO.Filters;

public class Dos2UnixFilter : MimeFilterBase
{
	private readonly bool ensureNewLine;

	private byte pc;

	public Dos2UnixFilter(bool ensureNewLine = false)
	{
		this.ensureNewLine = ensureNewLine;
	}

	private unsafe int Filter(byte* inbuf, int length, byte* outbuf, bool flush)
	{
		byte* ptr = inbuf + length;
		byte* ptr2 = outbuf;
		byte* ptr3 = inbuf;
		while (ptr3 < ptr)
		{
			if (*ptr3 == 10)
			{
				*(ptr2++) = *ptr3;
			}
			else
			{
				if (pc == 13)
				{
					*(ptr2++) = pc;
				}
				if (*ptr3 != 13)
				{
					*(ptr2++) = *ptr3;
				}
			}
			pc = *(ptr3++);
		}
		if (flush && ensureNewLine && pc != 10)
		{
			*(ptr2++) = 10;
		}
		return (int)(ptr2 - outbuf);
	}

	protected unsafe override byte[] Filter(byte[] input, int startIndex, int length, out int outputIndex, out int outputLength, bool flush)
	{
		if (pc == 13)
		{
			EnsureOutputSize(length + ((!flush || !ensureNewLine) ? 1 : 2), keep: false);
		}
		else
		{
			EnsureOutputSize(length + ((flush && ensureNewLine) ? 1 : 0), keep: false);
		}
		outputIndex = 0;
		fixed (byte* ptr = input)
		{
			fixed (byte* outputBuffer = base.OutputBuffer)
			{
				outputLength = Filter(ptr + startIndex, length, outputBuffer, flush);
			}
		}
		return base.OutputBuffer;
	}

	public override void Reset()
	{
		pc = 0;
		base.Reset();
	}
}
