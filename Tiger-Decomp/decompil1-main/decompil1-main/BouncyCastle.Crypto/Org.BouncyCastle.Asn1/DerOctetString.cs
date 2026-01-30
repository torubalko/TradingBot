namespace Org.BouncyCastle.Asn1;

public class DerOctetString : Asn1OctetString
{
	public DerOctetString(byte[] str)
		: base(str)
	{
	}

	public DerOctetString(IAsn1Convertible obj)
		: this(obj.ToAsn1Object())
	{
	}

	public DerOctetString(Asn1Encodable obj)
		: base(obj.GetEncoded("DER"))
	{
	}

	internal override int EncodedLength(bool withID)
	{
		return Asn1OutputStream.GetLengthOfEncodingDL(withID, str.Length);
	}

	internal override void Encode(Asn1OutputStream asn1Out, bool withID)
	{
		asn1Out.WriteEncodingDL(withID, 4, str);
	}

	internal static void Encode(Asn1OutputStream asn1Out, bool withID, byte[] buf, int off, int len)
	{
		asn1Out.WriteEncodingDL(withID, 4, buf, off, len);
	}

	internal static int EncodedLength(bool withID, int contentsLength)
	{
		return Asn1OutputStream.GetLengthOfEncodingDL(withID, contentsLength);
	}
}
