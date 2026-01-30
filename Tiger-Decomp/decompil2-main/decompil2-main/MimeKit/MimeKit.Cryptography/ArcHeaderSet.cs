using System.Collections.Generic;

namespace MimeKit.Cryptography;

internal class ArcHeaderSet
{
	public Header ArcAuthenticationResult { get; private set; }

	public Dictionary<string, string> ArcMessageSignatureParameters { get; private set; }

	public Header ArcMessageSignature { get; private set; }

	public Dictionary<string, string> ArcSealParameters { get; private set; }

	public Header ArcSeal { get; private set; }

	public bool Add(Header header, Dictionary<string, string> parameters)
	{
		switch (header.Id)
		{
		case HeaderId.ArcAuthenticationResults:
			if (ArcAuthenticationResult != null)
			{
				return false;
			}
			ArcAuthenticationResult = header;
			break;
		case HeaderId.ArcMessageSignature:
			if (ArcMessageSignature != null)
			{
				return false;
			}
			ArcMessageSignatureParameters = parameters;
			ArcMessageSignature = header;
			break;
		case HeaderId.ArcSeal:
			if (ArcSeal != null)
			{
				return false;
			}
			ArcSealParameters = parameters;
			ArcSeal = header;
			break;
		default:
			return false;
		}
		return true;
	}
}
