using System;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Cms;

public class AuthenticatedData : Asn1Encodable
{
	private DerInteger version;

	private OriginatorInfo originatorInfo;

	private Asn1Set recipientInfos;

	private AlgorithmIdentifier macAlgorithm;

	private AlgorithmIdentifier digestAlgorithm;

	private ContentInfo encapsulatedContentInfo;

	private Asn1Set authAttrs;

	private Asn1OctetString mac;

	private Asn1Set unauthAttrs;

	public DerInteger Version => version;

	public OriginatorInfo OriginatorInfo => originatorInfo;

	public Asn1Set RecipientInfos => recipientInfos;

	public AlgorithmIdentifier MacAlgorithm => macAlgorithm;

	public AlgorithmIdentifier DigestAlgorithm => digestAlgorithm;

	public ContentInfo EncapsulatedContentInfo => encapsulatedContentInfo;

	public Asn1Set AuthAttrs => authAttrs;

	public Asn1OctetString Mac => mac;

	public Asn1Set UnauthAttrs => unauthAttrs;

	public AuthenticatedData(OriginatorInfo originatorInfo, Asn1Set recipientInfos, AlgorithmIdentifier macAlgorithm, AlgorithmIdentifier digestAlgorithm, ContentInfo encapsulatedContent, Asn1Set authAttrs, Asn1OctetString mac, Asn1Set unauthAttrs)
	{
		if ((digestAlgorithm != null || authAttrs != null) && (digestAlgorithm == null || authAttrs == null))
		{
			throw new ArgumentException("digestAlgorithm and authAttrs must be set together");
		}
		version = new DerInteger(CalculateVersion(originatorInfo));
		this.originatorInfo = originatorInfo;
		this.macAlgorithm = macAlgorithm;
		this.digestAlgorithm = digestAlgorithm;
		this.recipientInfos = recipientInfos;
		encapsulatedContentInfo = encapsulatedContent;
		this.authAttrs = authAttrs;
		this.mac = mac;
		this.unauthAttrs = unauthAttrs;
	}

	private AuthenticatedData(Asn1Sequence seq)
	{
		int index = 0;
		version = (DerInteger)seq[index++];
		Asn1Encodable tmp = seq[index++];
		if (tmp is Asn1TaggedObject)
		{
			originatorInfo = OriginatorInfo.GetInstance((Asn1TaggedObject)tmp, explicitly: false);
			tmp = seq[index++];
		}
		recipientInfos = Asn1Set.GetInstance(tmp);
		macAlgorithm = AlgorithmIdentifier.GetInstance(seq[index++]);
		tmp = seq[index++];
		if (tmp is Asn1TaggedObject)
		{
			digestAlgorithm = AlgorithmIdentifier.GetInstance((Asn1TaggedObject)tmp, explicitly: false);
			tmp = seq[index++];
		}
		encapsulatedContentInfo = ContentInfo.GetInstance(tmp);
		tmp = seq[index++];
		if (tmp is Asn1TaggedObject)
		{
			authAttrs = Asn1Set.GetInstance((Asn1TaggedObject)tmp, explicitly: false);
			tmp = seq[index++];
		}
		mac = Asn1OctetString.GetInstance(tmp);
		if (seq.Count > index)
		{
			unauthAttrs = Asn1Set.GetInstance((Asn1TaggedObject)seq[index], explicitly: false);
		}
	}

	public static AuthenticatedData GetInstance(Asn1TaggedObject obj, bool isExplicit)
	{
		return GetInstance(Asn1Sequence.GetInstance(obj, isExplicit));
	}

	public static AuthenticatedData GetInstance(object obj)
	{
		if (obj == null || obj is AuthenticatedData)
		{
			return (AuthenticatedData)obj;
		}
		if (obj is Asn1Sequence)
		{
			return new AuthenticatedData((Asn1Sequence)obj);
		}
		throw new ArgumentException("Invalid AuthenticatedData: " + Platform.GetTypeName(obj));
	}

	public override Asn1Object ToAsn1Object()
	{
		Asn1EncodableVector v = new Asn1EncodableVector(version);
		v.AddOptionalTagged(isExplicit: false, 0, originatorInfo);
		v.Add(recipientInfos, macAlgorithm);
		v.AddOptionalTagged(isExplicit: false, 1, digestAlgorithm);
		v.Add(encapsulatedContentInfo);
		v.AddOptionalTagged(isExplicit: false, 2, authAttrs);
		v.Add(mac);
		v.AddOptionalTagged(isExplicit: false, 3, unauthAttrs);
		return new BerSequence(v);
	}

	public static int CalculateVersion(OriginatorInfo origInfo)
	{
		if (origInfo == null)
		{
			return 0;
		}
		int ver = 0;
		foreach (object obj in origInfo.Certificates)
		{
			if (obj is Asn1TaggedObject)
			{
				Asn1TaggedObject tag = (Asn1TaggedObject)obj;
				if (tag.TagNo == 2)
				{
					ver = 1;
				}
				else if (tag.TagNo == 3)
				{
					ver = 3;
					break;
				}
			}
		}
		foreach (object obj2 in origInfo.Crls)
		{
			if (obj2 is Asn1TaggedObject && ((Asn1TaggedObject)obj2).TagNo == 1)
			{
				ver = 3;
				break;
			}
		}
		return ver;
	}
}
