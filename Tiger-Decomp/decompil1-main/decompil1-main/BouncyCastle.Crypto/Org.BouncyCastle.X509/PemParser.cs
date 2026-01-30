using System.IO;
using System.Text;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.X509;

internal class PemParser
{
	private readonly string _header1;

	private readonly string _header2;

	private readonly string _footer1;

	private readonly string _footer2;

	internal PemParser(string type)
	{
		_header1 = "-----BEGIN " + type + "-----";
		_header2 = "-----BEGIN X509 " + type + "-----";
		_footer1 = "-----END " + type + "-----";
		_footer2 = "-----END X509 " + type + "-----";
	}

	private string ReadLine(Stream inStream)
	{
		StringBuilder l = new StringBuilder();
		int c;
		while (true)
		{
			if ((c = inStream.ReadByte()) != 13 && c != 10 && c >= 0)
			{
				if (c != 13)
				{
					l.Append((char)c);
				}
			}
			else if (c < 0 || l.Length != 0)
			{
				break;
			}
		}
		if (c < 0)
		{
			return null;
		}
		return l.ToString();
	}

	internal Asn1Sequence ReadPemObject(Stream inStream)
	{
		StringBuilder pemBuf = new StringBuilder();
		string line;
		while ((line = ReadLine(inStream)) != null && !Platform.StartsWith(line, _header1) && !Platform.StartsWith(line, _header2))
		{
		}
		while ((line = ReadLine(inStream)) != null && !Platform.StartsWith(line, _footer1) && !Platform.StartsWith(line, _footer2))
		{
			pemBuf.Append(line);
		}
		if (pemBuf.Length != 0)
		{
			Asn1Object asn1Object = Asn1Object.FromByteArray(Base64.Decode(pemBuf.ToString()));
			if (!(asn1Object is Asn1Sequence))
			{
				throw new IOException("malformed PEM data encountered");
			}
			return (Asn1Sequence)asn1Object;
		}
		return null;
	}
}
