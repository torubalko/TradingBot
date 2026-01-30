using MimeKit.Utils;

namespace MimeKit.IO.Filters;

public class TrailingWhitespaceFilter : MimeFilterBase
{
	private readonly PackedByteArray lwsp = new PackedByteArray();

	private unsafe int Filter(byte* inbuf, int length, byte* outbuf)
	{
		byte* ptr = inbuf + length;
		byte* ptr2 = outbuf;
		byte* ptr3 = inbuf;
		int num = 0;
		for (; ptr3 < ptr; ptr3++)
		{
			if ((*ptr3).IsBlank())
			{
				lwsp.Add(*ptr3);
				continue;
			}
			if (*ptr3 == 13)
			{
				*(ptr2++) = *ptr3;
				lwsp.Clear();
				num++;
				continue;
			}
			if (*ptr3 == 10)
			{
				*(ptr2++) = *ptr3;
				lwsp.Clear();
				num++;
				continue;
			}
			if (lwsp.Count > 0)
			{
				lwsp.CopyTo(base.OutputBuffer, num);
				ptr2 += lwsp.Count;
				num += lwsp.Count;
				lwsp.Clear();
			}
			*(ptr2++) = *ptr3;
			num++;
		}
		return num;
	}

	protected unsafe override byte[] Filter(byte[] input, int startIndex, int length, out int outputIndex, out int outputLength, bool flush)
	{
		if (length == 0)
		{
			if (flush)
			{
				lwsp.Clear();
			}
			outputIndex = startIndex;
			outputLength = length;
			return input;
		}
		EnsureOutputSize(length + lwsp.Count, keep: false);
		fixed (byte* ptr = input)
		{
			fixed (byte* outputBuffer = base.OutputBuffer)
			{
				outputLength = Filter(ptr + startIndex, length, outputBuffer);
			}
		}
		if (flush)
		{
			lwsp.Clear();
		}
		outputIndex = 0;
		return base.OutputBuffer;
	}

	public override void Reset()
	{
		lwsp.Clear();
		base.Reset();
	}
}
