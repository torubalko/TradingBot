using MimeKit.IO.Filters;

namespace MailKit.Net.Smtp;

public class SmtpDataFilter : MimeFilterBase
{
	private bool bol;

	public SmtpDataFilter()
	{
		bol = true;
	}

	protected override byte[] Filter(byte[] input, int startIndex, int length, out int outputIndex, out int outputLength, bool flush)
	{
		int num = startIndex + length;
		bool flag = bol;
		int num2 = 0;
		int num3 = 0;
		for (int i = startIndex; i < num; i++)
		{
			byte b = input[i];
			if (b == 46 && flag)
			{
				flag = false;
				num2++;
			}
			else
			{
				flag = b == 10;
			}
		}
		if (flush && !flag)
		{
			num3 = 2;
		}
		if (num2 + num3 == 0)
		{
			outputIndex = startIndex;
			outputLength = length;
			bol = flag;
			return input;
		}
		EnsureOutputSize(length + num2 + num3, keep: false);
		int num4 = 0;
		for (int j = startIndex; j < num; j++)
		{
			byte b2 = input[j];
			if (b2 == 46 && bol)
			{
				base.OutputBuffer[num4++] = 46;
				bol = false;
			}
			else
			{
				bol = b2 == 10;
			}
			base.OutputBuffer[num4++] = b2;
		}
		if (num3 > 0)
		{
			base.OutputBuffer[num4++] = 13;
			base.OutputBuffer[num4++] = 10;
		}
		outputLength = num4;
		outputIndex = 0;
		return base.OutputBuffer;
	}

	public override void Reset()
	{
		base.Reset();
		bol = true;
	}
}
