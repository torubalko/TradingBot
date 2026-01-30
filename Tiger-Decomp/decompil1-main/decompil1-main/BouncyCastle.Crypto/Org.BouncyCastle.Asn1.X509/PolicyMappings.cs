using System.Collections;

namespace Org.BouncyCastle.Asn1.X509;

public class PolicyMappings : Asn1Encodable
{
	private readonly Asn1Sequence seq;

	public PolicyMappings(Asn1Sequence seq)
	{
		this.seq = seq;
	}

	public PolicyMappings(Hashtable mappings)
		: this((IDictionary)mappings)
	{
	}

	public PolicyMappings(IDictionary mappings)
	{
		Asn1EncodableVector v = new Asn1EncodableVector();
		foreach (string idp in mappings.Keys)
		{
			string sdp = (string)mappings[idp];
			v.Add(new DerSequence(new DerObjectIdentifier(idp), new DerObjectIdentifier(sdp)));
		}
		seq = new DerSequence(v);
	}

	public override Asn1Object ToAsn1Object()
	{
		return seq;
	}
}
