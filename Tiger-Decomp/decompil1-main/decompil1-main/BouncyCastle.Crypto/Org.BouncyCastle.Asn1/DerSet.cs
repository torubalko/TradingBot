using System.IO;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1;

public class DerSet : Asn1Set
{
	public static readonly DerSet Empty = new DerSet();

	public static DerSet FromVector(Asn1EncodableVector elementVector)
	{
		if (elementVector.Count >= 1)
		{
			return new DerSet(elementVector);
		}
		return Empty;
	}

	internal static DerSet FromVector(Asn1EncodableVector elementVector, bool needsSorting)
	{
		if (elementVector.Count >= 1)
		{
			return new DerSet(elementVector, needsSorting);
		}
		return Empty;
	}

	public DerSet()
	{
	}

	public DerSet(Asn1Encodable element)
		: base(element)
	{
	}

	public DerSet(params Asn1Encodable[] elements)
		: base(elements)
	{
		Sort();
	}

	public DerSet(Asn1EncodableVector elementVector)
		: this(elementVector, needsSorting: true)
	{
	}

	internal DerSet(Asn1EncodableVector elementVector, bool needsSorting)
		: base(elementVector)
	{
		if (needsSorting)
		{
			Sort();
		}
	}

	internal override int EncodedLength(bool withID)
	{
		throw Platform.CreateNotImplementedException("DerSet.EncodedLength");
	}

	internal override void Encode(Asn1OutputStream asn1Out, bool withID)
	{
		if (Count < 1)
		{
			asn1Out.WriteEncodingDL(withID, 49, Asn1OctetString.EmptyOctets);
			return;
		}
		MemoryStream memoryStream = new MemoryStream();
		Asn1OutputStream dOut = Asn1OutputStream.Create(memoryStream, "DER");
		dOut.WriteElements(elements);
		dOut.Flush();
		byte[] bytes = memoryStream.GetBuffer();
		int length = (int)memoryStream.Position;
		asn1Out.WriteEncodingDL(withID, 49, bytes, 0, length);
		Platform.Dispose(dOut);
	}
}
