using System;
using System.Text;
using MimeKit.Utils;

namespace MimeKit.IO.Filters;

public class CharsetFilter : MimeFilterBase
{
	private readonly char[] chars = new char[1024];

	private readonly Decoder decoder;

	private readonly Encoder encoder;

	public Encoding SourceEncoding { get; private set; }

	public Encoding TargetEncoding { get; private set; }

	private static Encoding GetEncoding(string paramName, string encodingName)
	{
		if (encodingName == null)
		{
			throw new ArgumentNullException(paramName);
		}
		return CharsetUtils.GetEncoding(encodingName);
	}

	public CharsetFilter(string sourceEncodingName, string targetEncodingName)
		: this(GetEncoding("sourceEncodingName", sourceEncodingName), GetEncoding("targetEncodingName", targetEncodingName))
	{
	}

	public CharsetFilter(int sourceCodePage, int targetCodePage)
		: this(Encoding.GetEncoding(sourceCodePage), Encoding.GetEncoding(targetCodePage))
	{
	}

	public CharsetFilter(Encoding sourceEncoding, Encoding targetEncoding)
	{
		if (sourceEncoding == null)
		{
			throw new ArgumentNullException("sourceEncoding");
		}
		if (targetEncoding == null)
		{
			throw new ArgumentNullException("targetEncoding");
		}
		SourceEncoding = sourceEncoding;
		TargetEncoding = targetEncoding;
		decoder = SourceEncoding.GetDecoder();
		encoder = TargetEncoding.GetEncoder();
	}

	protected override byte[] Filter(byte[] input, int startIndex, int length, out int outputIndex, out int outputLength, bool flush)
	{
		int num = startIndex;
		int num2 = length;
		bool completed = false;
		bool completed2 = false;
		int num3 = 0;
		do
		{
			int charCount = chars.Length;
			int num4 = 0;
			int bytesUsed;
			int charsUsed;
			if (!completed && num2 > 0)
			{
				decoder.Convert(input, num, num2, chars, num4, charCount, flush, out bytesUsed, out charsUsed, out completed);
				if (charsUsed > 0)
				{
					completed2 = false;
				}
				num4 += charsUsed;
				num += bytesUsed;
				num2 -= bytesUsed;
			}
			else
			{
				completed = true;
			}
			charCount = num4;
			num4 = 0;
			while (!completed2)
			{
				EnsureOutputSize(num3 + TargetEncoding.GetMaxByteCount(charCount) + 4, keep: true);
				int byteCount = base.OutputBuffer.Length - num3;
				encoder.Convert(chars, num4, charCount, base.OutputBuffer, num3, byteCount, flush, out bytesUsed, out charsUsed, out completed2);
				num3 += charsUsed;
				num4 += bytesUsed;
				charCount -= bytesUsed;
			}
		}
		while (!completed);
		outputLength = num3;
		outputIndex = 0;
		return base.OutputBuffer;
	}

	public override void Reset()
	{
		decoder.Reset();
		encoder.Reset();
		base.Reset();
	}
}
