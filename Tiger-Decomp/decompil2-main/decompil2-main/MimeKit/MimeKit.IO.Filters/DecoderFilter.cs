using System;
using MimeKit.Encodings;
using MimeKit.Utils;

namespace MimeKit.IO.Filters;

public class DecoderFilter : MimeFilterBase
{
	public IMimeDecoder Decoder { get; private set; }

	public ContentEncoding Encoding => Decoder.Encoding;

	public DecoderFilter(IMimeDecoder decoder)
	{
		if (decoder == null)
		{
			throw new ArgumentNullException("decoder");
		}
		Decoder = decoder;
	}

	public static IMimeFilter Create(ContentEncoding encoding)
	{
		return encoding switch
		{
			ContentEncoding.Base64 => new DecoderFilter(new Base64Decoder()), 
			ContentEncoding.QuotedPrintable => new DecoderFilter(new QuotedPrintableDecoder()), 
			ContentEncoding.UUEncode => new DecoderFilter(new UUDecoder()), 
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
		EnsureOutputSize(Decoder.EstimateOutputLength(length), keep: false);
		outputLength = Decoder.Decode(input, startIndex, length, base.OutputBuffer);
		outputIndex = 0;
		return base.OutputBuffer;
	}

	public override void Reset()
	{
		Decoder.Reset();
		base.Reset();
	}
}
