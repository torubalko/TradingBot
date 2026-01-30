using System;

namespace MimeKit.Cryptography;

public class ArcHeaderValidationResult
{
	public ArcSignatureValidationResult Signature { get; internal set; }

	public Header Header { get; private set; }

	internal ArcHeaderValidationResult(Header header)
	{
		if (header == null)
		{
			throw new ArgumentNullException("header");
		}
		Header = header;
	}

	public ArcHeaderValidationResult(Header header, ArcSignatureValidationResult signature)
		: this(header)
	{
		Signature = signature;
	}
}
