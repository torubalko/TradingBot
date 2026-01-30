using System;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Esf;

public class SignerAttribute : Asn1Encodable
{
	private Asn1Sequence claimedAttributes;

	private AttributeCertificate certifiedAttributes;

	public virtual Asn1Sequence ClaimedAttributes => claimedAttributes;

	public virtual AttributeCertificate CertifiedAttributes => certifiedAttributes;

	public static SignerAttribute GetInstance(object obj)
	{
		if (obj == null || obj is SignerAttribute)
		{
			return (SignerAttribute)obj;
		}
		if (obj is Asn1Sequence)
		{
			return new SignerAttribute(obj);
		}
		throw new ArgumentException("Unknown object in 'SignerAttribute' factory: " + Platform.GetTypeName(obj), "obj");
	}

	private SignerAttribute(object obj)
	{
		DerTaggedObject taggedObject = (DerTaggedObject)((Asn1Sequence)obj)[0];
		if (taggedObject.TagNo == 0)
		{
			claimedAttributes = Asn1Sequence.GetInstance(taggedObject, explicitly: true);
			return;
		}
		if (taggedObject.TagNo == 1)
		{
			certifiedAttributes = AttributeCertificate.GetInstance(taggedObject);
			return;
		}
		throw new ArgumentException("illegal tag.", "obj");
	}

	public SignerAttribute(Asn1Sequence claimedAttributes)
	{
		this.claimedAttributes = claimedAttributes;
	}

	public SignerAttribute(AttributeCertificate certifiedAttributes)
	{
		this.certifiedAttributes = certifiedAttributes;
	}

	public override Asn1Object ToAsn1Object()
	{
		Asn1EncodableVector v = new Asn1EncodableVector();
		if (claimedAttributes != null)
		{
			v.Add(new DerTaggedObject(0, claimedAttributes));
		}
		else
		{
			v.Add(new DerTaggedObject(1, certifiedAttributes));
		}
		return new DerSequence(v);
	}
}
