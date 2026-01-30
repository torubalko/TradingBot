using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.X509;

public class TbsCertificateStructure : Asn1Encodable
{
	internal Asn1Sequence seq;

	internal DerInteger version;

	internal DerInteger serialNumber;

	internal AlgorithmIdentifier signature;

	internal X509Name issuer;

	internal Time startDate;

	internal Time endDate;

	internal X509Name subject;

	internal SubjectPublicKeyInfo subjectPublicKeyInfo;

	internal DerBitString issuerUniqueID;

	internal DerBitString subjectUniqueID;

	internal X509Extensions extensions;

	public int Version => version.IntValueExact + 1;

	public DerInteger VersionNumber => version;

	public DerInteger SerialNumber => serialNumber;

	public AlgorithmIdentifier Signature => signature;

	public X509Name Issuer => issuer;

	public Time StartDate => startDate;

	public Time EndDate => endDate;

	public X509Name Subject => subject;

	public SubjectPublicKeyInfo SubjectPublicKeyInfo => subjectPublicKeyInfo;

	public DerBitString IssuerUniqueID => issuerUniqueID;

	public DerBitString SubjectUniqueID => subjectUniqueID;

	public X509Extensions Extensions => extensions;

	public static TbsCertificateStructure GetInstance(Asn1TaggedObject obj, bool explicitly)
	{
		return GetInstance(Asn1Sequence.GetInstance(obj, explicitly));
	}

	public static TbsCertificateStructure GetInstance(object obj)
	{
		if (obj is TbsCertificateStructure)
		{
			return (TbsCertificateStructure)obj;
		}
		if (obj != null)
		{
			return new TbsCertificateStructure(Asn1Sequence.GetInstance(obj));
		}
		return null;
	}

	internal TbsCertificateStructure(Asn1Sequence seq)
	{
		int seqStart = 0;
		this.seq = seq;
		if (seq[0] is Asn1TaggedObject)
		{
			version = DerInteger.GetInstance((Asn1TaggedObject)seq[0], isExplicit: true);
		}
		else
		{
			seqStart = -1;
			version = new DerInteger(0);
		}
		bool isV1 = false;
		bool isV2 = false;
		if (version.HasValue(0))
		{
			isV1 = true;
		}
		else if (version.HasValue(1))
		{
			isV2 = true;
		}
		else if (!version.HasValue(2))
		{
			throw new ArgumentException("version number not recognised");
		}
		serialNumber = DerInteger.GetInstance(seq[seqStart + 1]);
		signature = AlgorithmIdentifier.GetInstance(seq[seqStart + 2]);
		issuer = X509Name.GetInstance(seq[seqStart + 3]);
		Asn1Sequence dates = (Asn1Sequence)seq[seqStart + 4];
		startDate = Time.GetInstance(dates[0]);
		endDate = Time.GetInstance(dates[1]);
		subject = X509Name.GetInstance(seq[seqStart + 5]);
		subjectPublicKeyInfo = SubjectPublicKeyInfo.GetInstance(seq[seqStart + 6]);
		int extras = seq.Count - (seqStart + 6) - 1;
		if (extras != 0 && isV1)
		{
			throw new ArgumentException("version 1 certificate contains extra data");
		}
		while (extras > 0)
		{
			Asn1TaggedObject extra = Asn1TaggedObject.GetInstance(seq[seqStart + 6 + extras]);
			switch (extra.TagNo)
			{
			case 1:
				issuerUniqueID = DerBitString.GetInstance(extra, isExplicit: false);
				break;
			case 2:
				subjectUniqueID = DerBitString.GetInstance(extra, isExplicit: false);
				break;
			case 3:
				if (isV2)
				{
					throw new ArgumentException("version 2 certificate cannot contain extensions");
				}
				extensions = X509Extensions.GetInstance(Asn1Sequence.GetInstance(extra, explicitly: true));
				break;
			default:
				throw new ArgumentException("Unknown tag encountered in structure: " + extra.TagNo);
			}
			extras--;
		}
	}

	public override Asn1Object ToAsn1Object()
	{
		string property = Platform.GetEnvironmentVariable("Org.BouncyCastle.X509.Allow_Non-DER_TBSCert");
		if (property == null || Platform.EqualsIgnoreCase("true", property))
		{
			return seq;
		}
		Asn1EncodableVector v = new Asn1EncodableVector();
		if (!version.HasValue(0))
		{
			v.Add(new DerTaggedObject(explicitly: true, 0, version));
		}
		v.Add(serialNumber, signature, issuer);
		v.Add(new DerSequence(startDate, endDate));
		if (subject != null)
		{
			v.Add(subject);
		}
		else
		{
			v.Add(DerSequence.Empty);
		}
		v.Add(subjectPublicKeyInfo);
		v.AddOptionalTagged(isExplicit: false, 1, issuerUniqueID);
		v.AddOptionalTagged(isExplicit: false, 2, subjectUniqueID);
		v.AddOptionalTagged(isExplicit: true, 3, extensions);
		return new DerSequence(v);
	}
}
