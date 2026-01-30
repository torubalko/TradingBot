using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1;

public class BerSequence : DerSequence
{
	public new static readonly BerSequence Empty = new BerSequence();

	public new static BerSequence FromVector(Asn1EncodableVector elementVector)
	{
		if (elementVector.Count >= 1)
		{
			return new BerSequence(elementVector);
		}
		return Empty;
	}

	public BerSequence()
	{
	}

	public BerSequence(Asn1Encodable element)
		: base(element)
	{
	}

	public BerSequence(params Asn1Encodable[] elements)
		: base(elements)
	{
	}

	public BerSequence(Asn1EncodableVector elementVector)
		: base(elementVector)
	{
	}

	internal override int EncodedLength(bool withID)
	{
		throw Platform.CreateNotImplementedException("BerSequence.EncodedLength");
	}

	internal override void Encode(Asn1OutputStream asn1Out, bool withID)
	{
		if (asn1Out.IsBer)
		{
			asn1Out.WriteEncodingIL(withID, 48, elements);
		}
		else
		{
			base.Encode(asn1Out, withID);
		}
	}
}
