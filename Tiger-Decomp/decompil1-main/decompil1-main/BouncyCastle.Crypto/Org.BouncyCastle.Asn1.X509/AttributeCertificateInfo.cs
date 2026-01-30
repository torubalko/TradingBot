using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.X509;

public class AttributeCertificateInfo : Asn1Encodable
{
	internal readonly DerInteger version;

	internal readonly Holder holder;

	internal readonly AttCertIssuer issuer;

	internal readonly AlgorithmIdentifier signature;

	internal readonly DerInteger serialNumber;

	internal readonly AttCertValidityPeriod attrCertValidityPeriod;

	internal readonly Asn1Sequence attributes;

	internal readonly DerBitString issuerUniqueID;

	internal readonly X509Extensions extensions;

	public DerInteger Version => version;

	public Holder Holder => holder;

	public AttCertIssuer Issuer => issuer;

	public AlgorithmIdentifier Signature => signature;

	public DerInteger SerialNumber => serialNumber;

	public AttCertValidityPeriod AttrCertValidityPeriod => attrCertValidityPeriod;

	public Asn1Sequence Attributes => attributes;

	public DerBitString IssuerUniqueID => issuerUniqueID;

	public X509Extensions Extensions => extensions;

	public static AttributeCertificateInfo GetInstance(Asn1TaggedObject obj, bool isExplicit)
	{
		return GetInstance(Asn1Sequence.GetInstance(obj, isExplicit));
	}

	public static AttributeCertificateInfo GetInstance(object obj)
	{
		if (obj is AttributeCertificateInfo)
		{
			return (AttributeCertificateInfo)obj;
		}
		if (obj is Asn1Sequence)
		{
			return new AttributeCertificateInfo((Asn1Sequence)obj);
		}
		throw new ArgumentException("unknown object in factory: " + Platform.GetTypeName(obj), "obj");
	}

	private AttributeCertificateInfo(Asn1Sequence seq)
	{
		if (seq.Count < 6 || seq.Count > 9)
		{
			throw new ArgumentException("Bad sequence size: " + seq.Count);
		}
		int start;
		if (seq[0] is DerInteger)
		{
			version = DerInteger.GetInstance(seq[0]);
			start = 1;
		}
		else
		{
			version = new DerInteger(0);
			start = 0;
		}
		holder = Holder.GetInstance(seq[start]);
		issuer = AttCertIssuer.GetInstance(seq[start + 1]);
		signature = AlgorithmIdentifier.GetInstance(seq[start + 2]);
		serialNumber = DerInteger.GetInstance(seq[start + 3]);
		attrCertValidityPeriod = AttCertValidityPeriod.GetInstance(seq[start + 4]);
		attributes = Asn1Sequence.GetInstance(seq[start + 5]);
		for (int i = start + 6; i < seq.Count; i++)
		{
			Asn1Encodable obj = seq[i];
			if (obj is DerBitString)
			{
				issuerUniqueID = DerBitString.GetInstance(seq[i]);
			}
			else if (obj is Asn1Sequence || obj is X509Extensions)
			{
				extensions = X509Extensions.GetInstance(seq[i]);
			}
		}
	}

	public override Asn1Object ToAsn1Object()
	{
		Asn1EncodableVector v = new Asn1EncodableVector(9);
		if (!version.HasValue(0))
		{
			v.Add(version);
		}
		v.Add(holder, issuer, signature, serialNumber, attrCertValidityPeriod, attributes);
		v.AddOptional(issuerUniqueID, extensions);
		return new DerSequence(v);
	}
}
