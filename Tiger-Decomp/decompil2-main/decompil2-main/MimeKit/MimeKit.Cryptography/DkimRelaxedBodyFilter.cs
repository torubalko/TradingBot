using MimeKit.Utils;

namespace MimeKit.Cryptography;

internal class DkimRelaxedBodyFilter : DkimBodyFilter
{
	private bool lwsp;

	private bool cr;

	public DkimRelaxedBodyFilter()
	{
		LastWasNewLine = true;
		IsEmptyLine = true;
	}

	private unsafe int Filter(byte* inbuf, int length, byte* outbuf)
	{
		byte* ptr = inbuf + length;
		byte* ptr2 = outbuf;
		byte* ptr3 = inbuf;
		int num = 0;
		for (; ptr3 < ptr; ptr3++)
		{
			if (*ptr3 == 10)
			{
				if (IsEmptyLine)
				{
					EmptyLines++;
				}
				else
				{
					if (cr)
					{
						*(ptr2++) = 13;
						num++;
					}
					*(ptr2++) = 10;
					LastWasNewLine = true;
					IsEmptyLine = true;
					num++;
				}
				lwsp = false;
				cr = false;
				continue;
			}
			if (cr)
			{
				*(ptr2++) = 13;
				cr = false;
				num++;
			}
			if (*ptr3 == 13)
			{
				lwsp = false;
				cr = true;
				continue;
			}
			if ((*ptr3).IsBlank())
			{
				lwsp = true;
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
			if (lwsp)
			{
				*(ptr2++) = 32;
				lwsp = false;
				num++;
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
		EnsureOutputSize(length + (lwsp ? 1 : 0) + EmptyLines * 2 + (cr ? 1 : 0) + 1, keep: false);
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
		LastWasNewLine = true;
		IsEmptyLine = true;
		EmptyLines = 0;
		lwsp = false;
		cr = false;
		base.Reset();
	}
}
