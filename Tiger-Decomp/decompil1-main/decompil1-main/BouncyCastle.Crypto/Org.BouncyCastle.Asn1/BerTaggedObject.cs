using System.Collections;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1;

public class BerTaggedObject : DerTaggedObject
{
	public BerTaggedObject(int tagNo, Asn1Encodable obj)
		: base(tagNo, obj)
	{
	}

	public BerTaggedObject(bool explicitly, int tagNo, Asn1Encodable obj)
		: base(explicitly, tagNo, obj)
	{
	}

	public BerTaggedObject(int tagNo)
		: base(explicitly: false, tagNo, BerSequence.Empty)
	{
	}

	internal override int EncodedLength(bool withID)
	{
		throw Platform.CreateNotImplementedException("BerTaggedObject.EncodedLength");
	}

	internal override void Encode(Asn1OutputStream asn1Out, bool withID)
	{
		if (asn1Out.IsBer)
		{
			if (withID)
			{
				asn1Out.WriteIdentifier(withID: true, 160, tagNo);
			}
			asn1Out.WriteByte(128);
			if (!IsEmpty())
			{
				if (!explicitly)
				{
					IEnumerable eObj;
					if (obj is Asn1OctetString)
					{
						eObj = ((!(obj is BerOctetString)) ? new BerOctetString(((Asn1OctetString)obj).GetOctets()) : ((BerOctetString)obj));
					}
					else if (obj is Asn1Sequence)
					{
						eObj = (Asn1Sequence)obj;
					}
					else
					{
						if (!(obj is Asn1Set))
						{
							throw Platform.CreateNotImplementedException(Platform.GetTypeName(obj));
						}
						eObj = (Asn1Set)obj;
					}
					foreach (Asn1Encodable o in eObj)
					{
						asn1Out.WritePrimitive(o.ToAsn1Object(), withID: true);
					}
				}
				else
				{
					asn1Out.WritePrimitive(obj.ToAsn1Object(), withID: true);
				}
			}
			asn1Out.WriteByte(0);
			asn1Out.WriteByte(0);
		}
		else
		{
			base.Encode(asn1Out, withID);
		}
	}
}
