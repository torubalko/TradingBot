using System;
using System.Collections;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.X509.Qualified;

public class SemanticsInformation : Asn1Encodable
{
	private readonly DerObjectIdentifier semanticsIdentifier;

	private readonly GeneralName[] nameRegistrationAuthorities;

	public DerObjectIdentifier SemanticsIdentifier => semanticsIdentifier;

	public static SemanticsInformation GetInstance(object obj)
	{
		if (obj == null || obj is SemanticsInformation)
		{
			return (SemanticsInformation)obj;
		}
		if (obj is Asn1Sequence)
		{
			return new SemanticsInformation(Asn1Sequence.GetInstance(obj));
		}
		throw new ArgumentException("unknown object in GetInstance: " + Platform.GetTypeName(obj), "obj");
	}

	public SemanticsInformation(Asn1Sequence seq)
	{
		if (seq.Count < 1)
		{
			throw new ArgumentException("no objects in SemanticsInformation");
		}
		IEnumerator e = seq.GetEnumerator();
		e.MoveNext();
		object obj = e.Current;
		if (obj is DerObjectIdentifier)
		{
			semanticsIdentifier = DerObjectIdentifier.GetInstance(obj);
			obj = ((!e.MoveNext()) ? null : e.Current);
		}
		if (obj != null)
		{
			Asn1Sequence generalNameSeq = Asn1Sequence.GetInstance(obj);
			nameRegistrationAuthorities = new GeneralName[generalNameSeq.Count];
			for (int i = 0; i < generalNameSeq.Count; i++)
			{
				nameRegistrationAuthorities[i] = GeneralName.GetInstance(generalNameSeq[i]);
			}
		}
	}

	public SemanticsInformation(DerObjectIdentifier semanticsIdentifier, GeneralName[] generalNames)
	{
		this.semanticsIdentifier = semanticsIdentifier;
		nameRegistrationAuthorities = generalNames;
	}

	public SemanticsInformation(DerObjectIdentifier semanticsIdentifier)
	{
		this.semanticsIdentifier = semanticsIdentifier;
	}

	public SemanticsInformation(GeneralName[] generalNames)
	{
		nameRegistrationAuthorities = generalNames;
	}

	public GeneralName[] GetNameRegistrationAuthorities()
	{
		return nameRegistrationAuthorities;
	}

	public override Asn1Object ToAsn1Object()
	{
		Asn1EncodableVector v = new Asn1EncodableVector();
		v.AddOptional(semanticsIdentifier);
		if (nameRegistrationAuthorities != null)
		{
			Asn1Encodable[] elements = nameRegistrationAuthorities;
			v.Add(new DerSequence(elements));
		}
		return new DerSequence(v);
	}
}
