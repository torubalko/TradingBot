using System.IO;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1;

public class DerSequence : Asn1Sequence
{
	public static readonly DerSequence Empty = new DerSequence();

	public static DerSequence FromVector(Asn1EncodableVector elementVector)
	{
		if (elementVector.Count >= 1)
		{
			return new DerSequence(elementVector);
		}
		return Empty;
	}

	public DerSequence()
	{
	}

	public DerSequence(Asn1Encodable element)
		: base(element)
	{
	}

	public DerSequence(params Asn1Encodable[] elements)
		: base(elements)
	{
	}

	public DerSequence(Asn1EncodableVector elementVector)
		: base(elementVector)
	{
	}

	internal override int EncodedLength(bool withID)
	{
		throw Platform.CreateNotImplementedException("DerSequence.EncodedLength");
	}

	internal override void Encode(Asn1OutputStream asn1Out, bool withID)
	{
		if (Count < 1)
		{
			asn1Out.WriteEncodingDL(withID, 48, Asn1OctetString.EmptyOctets);
			return;
		}
		MemoryStream memoryStream = new MemoryStream();
		Asn1OutputStream dOut = Asn1OutputStream.Create(memoryStream, "DER");
		dOut.WriteElements(elements);
		dOut.Flush();
		byte[] bytes = memoryStream.GetBuffer();
		int length = (int)memoryStream.Position;
		asn1Out.WriteEncodingDL(withID, 48, bytes, 0, length);
		Platform.Dispose(dOut);
	}
}
