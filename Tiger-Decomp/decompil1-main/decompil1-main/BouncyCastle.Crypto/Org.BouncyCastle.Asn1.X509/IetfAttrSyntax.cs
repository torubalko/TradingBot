using System;

namespace Org.BouncyCastle.Asn1.X509;

public class IetfAttrSyntax : Asn1Encodable
{
	public const int ValueOctets = 1;

	public const int ValueOid = 2;

	public const int ValueUtf8 = 3;

	internal readonly GeneralNames policyAuthority;

	internal readonly Asn1EncodableVector values = new Asn1EncodableVector();

	internal int valueChoice = -1;

	public GeneralNames PolicyAuthority => policyAuthority;

	public int ValueType => valueChoice;

	public IetfAttrSyntax(Asn1Sequence seq)
	{
		int i = 0;
		if (seq[0] is Asn1TaggedObject)
		{
			policyAuthority = GeneralNames.GetInstance((Asn1TaggedObject)seq[0], explicitly: false);
			i++;
		}
		else if (seq.Count == 2)
		{
			policyAuthority = GeneralNames.GetInstance(seq[0]);
			i++;
		}
		if (!(seq[i] is Asn1Sequence))
		{
			throw new ArgumentException("Non-IetfAttrSyntax encoding");
		}
		seq = (Asn1Sequence)seq[i];
		foreach (Asn1Object obj in seq)
		{
			int type;
			if (obj is DerObjectIdentifier)
			{
				type = 2;
			}
			else if (obj is DerUtf8String)
			{
				type = 3;
			}
			else
			{
				if (!(obj is DerOctetString))
				{
					throw new ArgumentException("Bad value type encoding IetfAttrSyntax");
				}
				type = 1;
			}
			if (valueChoice < 0)
			{
				valueChoice = type;
			}
			if (type != valueChoice)
			{
				throw new ArgumentException("Mix of value types in IetfAttrSyntax");
			}
			values.Add(obj);
		}
	}

	public object[] GetValues()
	{
		if (ValueType == 1)
		{
			Asn1OctetString[] tmp = new Asn1OctetString[values.Count];
			for (int i = 0; i != tmp.Length; i++)
			{
				tmp[i] = (Asn1OctetString)values[i];
			}
			return tmp;
		}
		if (ValueType == 2)
		{
			DerObjectIdentifier[] tmp2 = new DerObjectIdentifier[values.Count];
			for (int j = 0; j != tmp2.Length; j++)
			{
				tmp2[j] = (DerObjectIdentifier)values[j];
			}
			return tmp2;
		}
		DerUtf8String[] tmp3 = new DerUtf8String[values.Count];
		for (int k = 0; k != tmp3.Length; k++)
		{
			tmp3[k] = (DerUtf8String)values[k];
		}
		return tmp3;
	}

	public override Asn1Object ToAsn1Object()
	{
		Asn1EncodableVector asn1EncodableVector = new Asn1EncodableVector();
		asn1EncodableVector.AddOptionalTagged(isExplicit: true, 0, policyAuthority);
		asn1EncodableVector.Add(new DerSequence(values));
		return new DerSequence(asn1EncodableVector);
	}
}
