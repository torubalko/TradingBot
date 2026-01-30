using System;
using System.Collections;
using Org.BouncyCastle.Asn1.X500;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.IsisMtt.X509;

public class ProcurationSyntax : Asn1Encodable
{
	private readonly string country;

	private readonly DirectoryString typeOfSubstitution;

	private readonly GeneralName thirdPerson;

	private readonly IssuerSerial certRef;

	public virtual string Country => country;

	public virtual DirectoryString TypeOfSubstitution => typeOfSubstitution;

	public virtual GeneralName ThirdPerson => thirdPerson;

	public virtual IssuerSerial CertRef => certRef;

	public static ProcurationSyntax GetInstance(object obj)
	{
		if (obj == null || obj is ProcurationSyntax)
		{
			return (ProcurationSyntax)obj;
		}
		if (obj is Asn1Sequence)
		{
			return new ProcurationSyntax((Asn1Sequence)obj);
		}
		throw new ArgumentException("unknown object in factory: " + Platform.GetTypeName(obj), "obj");
	}

	private ProcurationSyntax(Asn1Sequence seq)
	{
		if (seq.Count < 1 || seq.Count > 3)
		{
			throw new ArgumentException("Bad sequence size: " + seq.Count);
		}
		IEnumerator e = seq.GetEnumerator();
		while (e.MoveNext())
		{
			Asn1TaggedObject o = Asn1TaggedObject.GetInstance(e.Current);
			switch (o.TagNo)
			{
			case 1:
				country = DerPrintableString.GetInstance(o, isExplicit: true).GetString();
				break;
			case 2:
				typeOfSubstitution = DirectoryString.GetInstance(o, isExplicit: true);
				break;
			case 3:
			{
				Asn1Object signingFor = o.GetObject();
				if (signingFor is Asn1TaggedObject)
				{
					thirdPerson = GeneralName.GetInstance(signingFor);
				}
				else
				{
					certRef = IssuerSerial.GetInstance(signingFor);
				}
				break;
			}
			default:
				throw new ArgumentException("Bad tag number: " + o.TagNo);
			}
		}
	}

	public ProcurationSyntax(string country, DirectoryString typeOfSubstitution, IssuerSerial certRef)
	{
		this.country = country;
		this.typeOfSubstitution = typeOfSubstitution;
		thirdPerson = null;
		this.certRef = certRef;
	}

	public ProcurationSyntax(string country, DirectoryString typeOfSubstitution, GeneralName thirdPerson)
	{
		this.country = country;
		this.typeOfSubstitution = typeOfSubstitution;
		this.thirdPerson = thirdPerson;
		certRef = null;
	}

	public override Asn1Object ToAsn1Object()
	{
		Asn1EncodableVector v = new Asn1EncodableVector();
		if (country != null)
		{
			v.Add(new DerTaggedObject(explicitly: true, 1, new DerPrintableString(country, validate: true)));
		}
		v.AddOptionalTagged(isExplicit: true, 2, typeOfSubstitution);
		if (thirdPerson != null)
		{
			v.Add(new DerTaggedObject(explicitly: true, 3, thirdPerson));
		}
		else
		{
			v.Add(new DerTaggedObject(explicitly: true, 3, certRef));
		}
		return new DerSequence(v);
	}
}
