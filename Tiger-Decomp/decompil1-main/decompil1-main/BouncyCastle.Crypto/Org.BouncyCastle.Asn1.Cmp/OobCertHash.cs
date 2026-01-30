using System;
using Org.BouncyCastle.Asn1.Crmf;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Cmp;

public class OobCertHash : Asn1Encodable
{
	private readonly AlgorithmIdentifier hashAlg;

	private readonly CertId certId;

	private readonly DerBitString hashVal;

	public virtual AlgorithmIdentifier HashAlg => hashAlg;

	public virtual CertId CertID => certId;

	private OobCertHash(Asn1Sequence seq)
	{
		int index = seq.Count - 1;
		hashVal = DerBitString.GetInstance(seq[index--]);
		for (int i = index; i >= 0; i--)
		{
			Asn1TaggedObject tObj = (Asn1TaggedObject)seq[i];
			if (tObj.TagNo == 0)
			{
				hashAlg = AlgorithmIdentifier.GetInstance(tObj, explicitly: true);
			}
			else
			{
				certId = CertId.GetInstance(tObj, isExplicit: true);
			}
		}
	}

	public static OobCertHash GetInstance(object obj)
	{
		if (obj is OobCertHash)
		{
			return (OobCertHash)obj;
		}
		if (obj is Asn1Sequence)
		{
			return new OobCertHash((Asn1Sequence)obj);
		}
		throw new ArgumentException("Invalid object: " + Platform.GetTypeName(obj), "obj");
	}

	public override Asn1Object ToAsn1Object()
	{
		Asn1EncodableVector asn1EncodableVector = new Asn1EncodableVector();
		asn1EncodableVector.AddOptionalTagged(isExplicit: true, 0, hashAlg);
		asn1EncodableVector.AddOptionalTagged(isExplicit: true, 1, certId);
		asn1EncodableVector.Add(hashVal);
		return new DerSequence(asn1EncodableVector);
	}
}
