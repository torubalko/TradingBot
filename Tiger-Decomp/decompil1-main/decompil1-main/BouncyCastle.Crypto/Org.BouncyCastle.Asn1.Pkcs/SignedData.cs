using System;
using System.Collections;

namespace Org.BouncyCastle.Asn1.Pkcs;

public class SignedData : Asn1Encodable
{
	private readonly DerInteger version;

	private readonly Asn1Set digestAlgorithms;

	private readonly ContentInfo contentInfo;

	private readonly Asn1Set certificates;

	private readonly Asn1Set crls;

	private readonly Asn1Set signerInfos;

	public DerInteger Version => version;

	public Asn1Set DigestAlgorithms => digestAlgorithms;

	public ContentInfo ContentInfo => contentInfo;

	public Asn1Set Certificates => certificates;

	public Asn1Set Crls => crls;

	public Asn1Set SignerInfos => signerInfos;

	public static SignedData GetInstance(object obj)
	{
		if (obj == null)
		{
			return null;
		}
		if (obj is SignedData existing)
		{
			return existing;
		}
		return new SignedData(Asn1Sequence.GetInstance(obj));
	}

	public SignedData(DerInteger _version, Asn1Set _digestAlgorithms, ContentInfo _contentInfo, Asn1Set _certificates, Asn1Set _crls, Asn1Set _signerInfos)
	{
		version = _version;
		digestAlgorithms = _digestAlgorithms;
		contentInfo = _contentInfo;
		certificates = _certificates;
		crls = _crls;
		signerInfos = _signerInfos;
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
					certificates = Asn1Set.GetInstance(tagged, explicitly: false);
					break;
				case 1:
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
		Asn1EncodableVector asn1EncodableVector = new Asn1EncodableVector(version, digestAlgorithms, contentInfo);
		asn1EncodableVector.AddOptionalTagged(isExplicit: false, 0, certificates);
		asn1EncodableVector.AddOptionalTagged(isExplicit: false, 1, crls);
		asn1EncodableVector.Add(signerInfos);
		return new BerSequence(asn1EncodableVector);
	}
}
