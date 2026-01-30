using System;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Ocsp;

public class TbsRequest : Asn1Encodable
{
	private static readonly DerInteger V1 = new DerInteger(0);

	private readonly DerInteger version;

	private readonly GeneralName requestorName;

	private readonly Asn1Sequence requestList;

	private readonly X509Extensions requestExtensions;

	private bool versionSet;

	public DerInteger Version => version;

	public GeneralName RequestorName => requestorName;

	public Asn1Sequence RequestList => requestList;

	public X509Extensions RequestExtensions => requestExtensions;

	public static TbsRequest GetInstance(Asn1TaggedObject obj, bool explicitly)
	{
		return GetInstance(Asn1Sequence.GetInstance(obj, explicitly));
	}

	public static TbsRequest GetInstance(object obj)
	{
		if (obj == null || obj is TbsRequest)
		{
			return (TbsRequest)obj;
		}
		if (obj is Asn1Sequence)
		{
			return new TbsRequest((Asn1Sequence)obj);
		}
		throw new ArgumentException("unknown object in factory: " + Platform.GetTypeName(obj), "obj");
	}

	public TbsRequest(GeneralName requestorName, Asn1Sequence requestList, X509Extensions requestExtensions)
	{
		version = V1;
		this.requestorName = requestorName;
		this.requestList = requestList;
		this.requestExtensions = requestExtensions;
	}

	private TbsRequest(Asn1Sequence seq)
	{
		int index = 0;
		Asn1Encodable enc = seq[0];
		if (enc is Asn1TaggedObject)
		{
			Asn1TaggedObject o = (Asn1TaggedObject)enc;
			if (o.TagNo == 0)
			{
				versionSet = true;
				version = DerInteger.GetInstance(o, isExplicit: true);
				index++;
			}
			else
			{
				version = V1;
			}
		}
		else
		{
			version = V1;
		}
		if (seq[index] is Asn1TaggedObject)
		{
			requestorName = GeneralName.GetInstance((Asn1TaggedObject)seq[index++], explicitly: true);
		}
		requestList = (Asn1Sequence)seq[index++];
		if (seq.Count == index + 1)
		{
			requestExtensions = X509Extensions.GetInstance((Asn1TaggedObject)seq[index], explicitly: true);
		}
	}

	public override Asn1Object ToAsn1Object()
	{
		Asn1EncodableVector v = new Asn1EncodableVector();
		if (!version.Equals(V1) || versionSet)
		{
			v.Add(new DerTaggedObject(explicitly: true, 0, version));
		}
		v.AddOptionalTagged(isExplicit: true, 1, requestorName);
		v.Add(requestList);
		v.AddOptionalTagged(isExplicit: true, 2, requestExtensions);
		return new DerSequence(v);
	}
}
