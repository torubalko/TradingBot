using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1;

public class DerTaggedObject : Asn1TaggedObject
{
	public DerTaggedObject(int tagNo, Asn1Encodable obj)
		: base(tagNo, obj)
	{
	}

	public DerTaggedObject(bool explicitly, int tagNo, Asn1Encodable obj)
		: base(explicitly, tagNo, obj)
	{
	}

	public DerTaggedObject(int tagNo)
		: base(explicitly: false, tagNo, DerSequence.Empty)
	{
	}

	internal override int EncodedLength(bool withID)
	{
		throw Platform.CreateNotImplementedException("DerTaggedObject.EncodedLength");
	}

	internal override void Encode(Asn1OutputStream asn1Out, bool withID)
	{
		if (!IsEmpty())
		{
			byte[] bytes = obj.GetDerEncoded();
			if (explicitly)
			{
				asn1Out.WriteEncodingDL(withID, 160, tagNo, bytes);
				return;
			}
			if (withID)
			{
				int flags = (bytes[0] & 0x20) | 0x80;
				asn1Out.WriteIdentifier(withID: true, flags, tagNo);
			}
			asn1Out.Write(bytes, 1, bytes.Length - 1);
		}
		else
		{
			asn1Out.WriteEncodingDL(withID, 160, tagNo, Asn1OctetString.EmptyOctets);
		}
	}
}
