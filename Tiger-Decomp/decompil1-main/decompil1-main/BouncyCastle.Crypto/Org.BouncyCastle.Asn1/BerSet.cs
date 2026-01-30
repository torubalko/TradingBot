using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1;

public class BerSet : DerSet
{
	public new static readonly BerSet Empty = new BerSet();

	public new static BerSet FromVector(Asn1EncodableVector elementVector)
	{
		if (elementVector.Count >= 1)
		{
			return new BerSet(elementVector);
		}
		return Empty;
	}

	internal new static BerSet FromVector(Asn1EncodableVector elementVector, bool needsSorting)
	{
		if (elementVector.Count >= 1)
		{
			return new BerSet(elementVector, needsSorting);
		}
		return Empty;
	}

	public BerSet()
	{
	}

	public BerSet(Asn1Encodable element)
		: base(element)
	{
	}

	public BerSet(Asn1EncodableVector elementVector)
		: base(elementVector, needsSorting: false)
	{
	}

	internal BerSet(Asn1EncodableVector elementVector, bool needsSorting)
		: base(elementVector, needsSorting)
	{
	}

	internal override int EncodedLength(bool withID)
	{
		throw Platform.CreateNotImplementedException("BerSet.EncodedLength");
	}

	internal override void Encode(Asn1OutputStream asn1Out, bool withID)
	{
		if (asn1Out.IsBer)
		{
			asn1Out.WriteEncodingIL(withID, 49, elements);
		}
		else
		{
			base.Encode(asn1Out, withID);
		}
	}
}
