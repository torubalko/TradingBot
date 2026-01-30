namespace MimeKit.IO.Filters;

public class Unix2DosFilter : MimeFilterBase
{
	private readonly bool ensureNewLine;

	private byte pc;

	public Unix2DosFilter(bool ensureNewLine = false)
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
			if (*ptr3 == 13)
			{
				*(ptr2++) = *ptr3;
			}
			else if (*ptr3 == 10)
			{
				if (pc != 13)
				{
					*(ptr2++) = 13;
				}
				*(ptr2++) = *ptr3;
			}
			else
			{
				*(ptr2++) = *ptr3;
			}
			pc = *(ptr3++);
		}
		if (flush && ensureNewLine && pc != 10)
		{
			*(ptr2++) = 13;
			*(ptr2++) = 10;
		}
		return (int)(ptr2 - outbuf);
	}

	protected unsafe override byte[] Filter(byte[] input, int startIndex, int length, out int outputIndex, out int outputLength, bool flush)
	{
		EnsureOutputSize(length * 2 + ((flush && ensureNewLine) ? 2 : 0), keep: false);
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
