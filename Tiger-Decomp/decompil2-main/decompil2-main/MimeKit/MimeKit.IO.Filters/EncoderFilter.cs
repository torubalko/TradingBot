using System;
using MimeKit.Encodings;
using MimeKit.Utils;

namespace MimeKit.IO.Filters;

public class EncoderFilter : MimeFilterBase
{
	public IMimeEncoder Encoder { get; private set; }

	public ContentEncoding Encoding => Encoder.Encoding;

	public EncoderFilter(IMimeEncoder encoder)
	{
		if (encoder == null)
		{
			throw new ArgumentNullException("encoder");
		}
		Encoder = encoder;
	}

	public static IMimeFilter Create(ContentEncoding encoding)
	{
		return encoding switch
		{
			ContentEncoding.Base64 => new EncoderFilter(new Base64Encoder()), 
			ContentEncoding.QuotedPrintable => new EncoderFilter(new QuotedPrintableEncoder()), 
			ContentEncoding.UUEncode => new EncoderFilter(new UUEncoder()), 
			_ => new PassThroughFilter(), 
		};
	}

	public static IMimeFilter Create(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (!MimeUtils.TryParse(name, out ContentEncoding encoding))
		{
			encoding = ContentEncoding.Default;
		}
		return Create(encoding);
	}

	protected override byte[] Filter(byte[] input, int startIndex, int length, out int outputIndex, out int outputLength, bool flush)
	{
		EnsureOutputSize(Encoder.EstimateOutputLength(length), keep: false);
		if (flush)
		{
			outputLength = Encoder.Flush(input, startIndex, length, base.OutputBuffer);
		}
		else
		{
			outputLength = Encoder.Encode(input, startIndex, length, base.OutputBuffer);
		}
		outputIndex = 0;
		return base.OutputBuffer;
	}

	public override void Reset()
	{
		Encoder.Reset();
		base.Reset();
	}
}
