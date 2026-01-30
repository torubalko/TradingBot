using System;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Ess;

[Obsolete("Use version in Asn1.Esf instead")]
public class OtherSigningCertificate : Asn1Encodable
{
	private Asn1Sequence certs;

	private Asn1Sequence policies;

	public static OtherSigningCertificate GetInstance(object o)
	{
		if (o == null || o is OtherSigningCertificate)
		{
			return (OtherSigningCertificate)o;
		}
		if (o is Asn1Sequence)
		{
			return new OtherSigningCertificate((Asn1Sequence)o);
		}
		throw new ArgumentException("unknown object in 'OtherSigningCertificate' factory : " + Platform.GetTypeName(o) + ".");
	}

	public OtherSigningCertificate(Asn1Sequence seq)
	{
		if (seq.Count < 1 || seq.Count > 2)
		{
			throw new ArgumentException("Bad sequence size: " + seq.Count);
		}
		certs = Asn1Sequence.GetInstance(seq[0]);
		if (seq.Count > 1)
		{
			policies = Asn1Sequence.GetInstance(seq[1]);
		}
	}

	public OtherSigningCertificate(OtherCertID otherCertID)
	{
		certs = new DerSequence(otherCertID);
	}

	public OtherCertID[] GetCerts()
	{
		OtherCertID[] cs = new OtherCertID[certs.Count];
		for (int i = 0; i != certs.Count; i++)
		{
			cs[i] = OtherCertID.GetInstance(certs[i]);
		}
		return cs;
	}

	public PolicyInformation[] GetPolicies()
	{
		if (policies == null)
		{
			return null;
		}
		PolicyInformation[] ps = new PolicyInformation[policies.Count];
		for (int i = 0; i != policies.Count; i++)
		{
			ps[i] = PolicyInformation.GetInstance(policies[i]);
		}
		return ps;
	}

	public override Asn1Object ToAsn1Object()
	{
		Asn1EncodableVector v = new Asn1EncodableVector(certs);
		v.AddOptional(policies);
		return new DerSequence(v);
	}
}
