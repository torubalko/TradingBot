using System.IO;

namespace Org.BouncyCastle.Asn1;

public abstract class Asn1Encodable : IAsn1Convertible
{
	public const string Der = "DER";

	public const string Ber = "BER";

	public virtual void EncodeTo(Stream output)
	{
		ToAsn1Object().EncodeTo(output);
	}

	public virtual void EncodeTo(Stream output, string encoding)
	{
		ToAsn1Object().EncodeTo(output, encoding);
	}

	public byte[] GetEncoded()
	{
		MemoryStream bOut = new MemoryStream();
		EncodeTo(bOut);
		return bOut.ToArray();
	}

	public byte[] GetEncoded(string encoding)
	{
		MemoryStream bOut = new MemoryStream();
		EncodeTo(bOut, encoding);
		return bOut.ToArray();
	}

	public byte[] GetDerEncoded()
	{
		try
		{
			return GetEncoded("DER");
		}
		catch (IOException)
		{
			return null;
		}
	}

	public sealed override int GetHashCode()
	{
		return ToAsn1Object().CallAsn1GetHashCode();
	}

	public sealed override bool Equals(object obj)
	{
		if (obj == this)
		{
			return true;
		}
		if (!(obj is IAsn1Convertible other))
		{
			return false;
		}
		Asn1Object o1 = ToAsn1Object();
		Asn1Object o2 = other.ToAsn1Object();
		if (o1 != o2)
		{
			if (o2 != null)
			{
				return o1.CallAsn1Equals(o2);
			}
			return false;
		}
		return true;
	}

	public abstract Asn1Object ToAsn1Object();
}
