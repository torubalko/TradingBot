using System;
using System.Collections;

namespace Org.BouncyCastle.Asn1.Cms;

public class SignedData : Asn1Encodable
{
	private static readonly DerInteger Version1 = new DerInteger(1);

	private static readonly DerInteger Version3 = new DerInteger(3);

	private static readonly DerInteger Version4 = new DerInteger(4);

	private static readonly DerInteger Version5 = new DerInteger(5);

	private readonly DerInteger version;

	private readonly Asn1Set digestAlgorithms;

	private readonly ContentInfo contentInfo;

	private readonly Asn1Set certificates;

	private readonly Asn1Set crls;

	private readonly Asn1Set signerInfos;

	private readonly bool certsBer;

	private readonly bool crlsBer;

	public DerInteger Version => version;

	public Asn1Set DigestAlgorithms => digestAlgorithms;

	public ContentInfo EncapContentInfo => contentInfo;

	public Asn1Set Certificates => certificates;

	public Asn1Set CRLs => crls;

	public Asn1Set SignerInfos => signerInfos;

	public static SignedData GetInstance(object obj)
	{
		if (obj is SignedData)
		{
			return (SignedData)obj;
		}
		if (obj == null)
		{
			return null;
		}
		return new SignedData(Asn1Sequence.GetInstance(obj));
	}

	public SignedData(Asn1Set digestAlgorithms, ContentInfo contentInfo, Asn1Set certificates, Asn1Set crls, Asn1Set signerInfos)
	{
		version = CalculateVersion(contentInfo.ContentType, certificates, crls, signerInfos);
		this.digestAlgorithms = digestAlgorithms;
		this.contentInfo = contentInfo;
		this.certificates = certificates;
		this.crls = crls;
		this.signerInfos = signerInfos;
		crlsBer = crls is BerSet;
		certsBer = certificates is BerSet;
	}

	private DerInteger CalculateVersion(DerObjectIdentifier contentOid, Asn1Set certs, Asn1Set crls, Asn1Set signerInfs)
	{
		bool otherCert = false;
		bool otherCrl = false;
		bool attrCertV1Found = false;
		bool attrCertV2Found = false;
		if (certs != null)
		{
			foreach (object obj in certs)
			{
				if (obj is Asn1TaggedObject)
				{
					Asn1TaggedObject tagged = (Asn1TaggedObject)obj;
					if (tagged.TagNo == 1)
					{
						attrCertV1Found = true;
					}
					else if (tagged.TagNo == 2)
					{
						attrCertV2Found = true;
					}
					else if (tagged.TagNo == 3)
					{
						otherCert = true;
						break;
					}
				}
			}
		}
		if (otherCert)
		{
			return Version5;
		}
		if (crls != null)
		{
			foreach (object crl in crls)
			{
				if (crl is Asn1TaggedObject)
				{
					otherCrl = true;
					break;
				}
			}
		}
		if (otherCrl)
		{
			return Version5;
		}
		if (attrCertV2Found)
		{
			return Version4;
		}
		if (attrCertV1Found || !CmsObjectIdentifiers.Data.Equals(contentOid) || CheckForVersion3(signerInfs))
		{
			return Version3;
		}
		return Version1;
	}

	private bool CheckForVersion3(Asn1Set signerInfs)
	{
		foreach (object signerInf in signerInfs)
		{
			if (SignerInfo.GetInstance(signerInf).Version.HasValue(3))
			{
				return true;
			}
		}
		return false;
	}

	private SignedData(Asn1Sequence seq)
	{
		IEnumerator e = seq.GetEnumerator();
		e.MoveNext();
		version = (DerInteger)e.Current;
		e.MoveNext();
		digestAlgorithms = (Asn1Set)e.Current;
		e.MoveNext();
		contentInfo = ContentInfo.GetInstance(e.Current);
		while (e.MoveNext())
		{
			Asn1Object o = (Asn1Object)e.Current;
			if (o is Asn1TaggedObject)
			{
				Asn1TaggedObject tagged = (Asn1TaggedObject)o;
				switch (tagged.TagNo)
				{
				case 0:
					certsBer = tagged is BerTaggedObject;
					certificates = Asn1Set.GetInstance(tagged, explicitly: false);
					break;
				case 1:
					crlsBer = tagged is BerTaggedObject;
					crls = Asn1Set.GetInstance(tagged, explicitly: false);
					break;
				default:
					throw new ArgumentException("unknown tag value " + tagged.TagNo);
				}
			}
			else
			{
				signerInfos = (Asn1Set)o;
			}
		}
	}

	public override Asn1Object ToAsn1Object()
	{
		Asn1EncodableVector v = new Asn1EncodableVector(version, digestAlgorithms, contentInfo);
		if (certificates != null)
		{
			if (certsBer)
			{
				v.Add(new BerTaggedObject(explicitly: false, 0, certificates));
			}
			else
			{
				v.Add(new DerTaggedObject(explicitly: false, 0, certificates));
			}
		}
		if (crls != null)
		{
			if (crlsBer)
			{
				v.Add(new BerTaggedObject(explicitly: false, 1, crls));
			}
			else
			{
				v.Add(new DerTaggedObject(explicitly: false, 1, crls));
			}
		}
		v.Add(signerInfos);
		return new BerSequence(v);
	}
}
