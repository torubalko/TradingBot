namespace MimeKit.Cryptography;

internal class DkimSimpleBodyFilter : DkimBodyFilter
{
	public DkimSimpleBodyFilter()
	{
		LastWasNewLine = false;
		IsEmptyLine = true;
		EmptyLines = 0;
	}

	private unsafe int Filter(byte* inbuf, int length, byte* outbuf)
	{
		byte* ptr = inbuf + length;
		byte* ptr2 = outbuf;
		byte* ptr3 = inbuf;
		int num = 0;
		for (; ptr3 < ptr; ptr3++)
		{
			if (*ptr3 == 13)
			{
				if (!IsEmptyLine)
				{
					*(ptr2++) = *ptr3;
					num++;
				}
				continue;
			}
			if (*ptr3 == 10)
			{
				if (!IsEmptyLine)
				{
					*(ptr2++) = *ptr3;
					LastWasNewLine = true;
					IsEmptyLine = true;
					EmptyLines = 0;
					num++;
				}
				else
				{
					EmptyLines++;
				}
				continue;
			}
			if (EmptyLines > 0)
			{
				while (EmptyLines > 0)
				{
					*(ptr2++) = 13;
					*(ptr2++) = 10;
					EmptyLines--;
					num += 2;
				}
			}
			LastWasNewLine = false;
			IsEmptyLine = false;
			*(ptr2++) = *ptr3;
			num++;
		}
		return num;
	}

	protected unsafe override byte[] Filter(byte[] input, int startIndex, int length, out int outputIndex, out int outputLength, bool flush)
	{
		EnsureOutputSize(length + EmptyLines * 2 + 1, keep: false);
		fixed (byte* ptr = input)
		{
			fixed (byte* outputBuffer = base.OutputBuffer)
			{
				outputLength = Filter(ptr + startIndex, length, outputBuffer);
			}
		}
		outputIndex = 0;
		return base.OutputBuffer;
	}

	public override void Reset()
	{
		LastWasNewLine = false;
		IsEmptyLine = true;
		EmptyLines = 0;
		base.Reset();
	}
}
