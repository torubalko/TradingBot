using System;
using System.Collections;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Pkcs;

public class SignerInfo : Asn1Encodable
{
	private DerInteger version;

	private IssuerAndSerialNumber issuerAndSerialNumber;

	private AlgorithmIdentifier digAlgorithm;

	private Asn1Set authenticatedAttributes;

	private AlgorithmIdentifier digEncryptionAlgorithm;

	private Asn1OctetString encryptedDigest;

	private Asn1Set unauthenticatedAttributes;

	public DerInteger Version => version;

	public IssuerAndSerialNumber IssuerAndSerialNumber => issuerAndSerialNumber;

	public Asn1Set AuthenticatedAttributes => authenticatedAttributes;

	public AlgorithmIdentifier DigestAlgorithm => digAlgorithm;

	public Asn1OctetString EncryptedDigest => encryptedDigest;

	public AlgorithmIdentifier DigestEncryptionAlgorithm => digEncryptionAlgorithm;

	public Asn1Set UnauthenticatedAttributes => unauthenticatedAttributes;

	public static SignerInfo GetInstance(object obj)
	{
		if (obj is SignerInfo)
		{
			return (SignerInfo)obj;
		}
		if (obj is Asn1Sequence)
		{
			return new SignerInfo((Asn1Sequence)obj);
		}
		throw new ArgumentException("Unknown object in factory: " + Platform.GetTypeName(obj), "obj");
	}

	public SignerInfo(DerInteger version, IssuerAndSerialNumber issuerAndSerialNumber, AlgorithmIdentifier digAlgorithm, Asn1Set authenticatedAttributes, AlgorithmIdentifier digEncryptionAlgorithm, Asn1OctetString encryptedDigest, Asn1Set unauthenticatedAttributes)
	{
		this.version = version;
		this.issuerAndSerialNumber = issuerAndSerialNumber;
		this.digAlgorithm = digAlgorithm;
		this.authenticatedAttributes = authenticatedAttributes;
		this.digEncryptionAlgorithm = digEncryptionAlgorithm;
		this.encryptedDigest = encryptedDigest;
		this.unauthenticatedAttributes = unauthenticatedAttributes;
	}

	public SignerInfo(Asn1Sequence seq)
	{
		IEnumerator e = seq.GetEnumerator();
		e.MoveNext();
		version = (DerInteger)e.Current;
		e.MoveNext();
		issuerAndSerialNumber = IssuerAndSerialNumber.GetInstance(e.Current);
		e.MoveNext();
		digAlgorithm = AlgorithmIdentifier.GetInstance(e.Current);
		e.MoveNext();
		object obj = e.Current;
		if (obj is Asn1TaggedObject)
		{
			authenticatedAttributes = Asn1Set.GetInstance((Asn1TaggedObject)obj, explicitly: false);
			e.MoveNext();
			digEncryptionAlgorithm = AlgorithmIdentifier.GetInstance(e.Current);
		}
		else
		{
			authenticatedAttributes = null;
			digEncryptionAlgorithm = AlgorithmIdentifier.GetInstance(obj);
		}
		e.MoveNext();
		encryptedDigest = Asn1OctetString.GetInstance(e.Current);
		if (e.MoveNext())
		{
			unauthenticatedAttributes = Asn1Set.GetInstance((Asn1TaggedObject)e.Current, explicitly: false);
		}
		else
		{
			unauthenticatedAttributes = null;
		}
	}

	public override Asn1Object ToAsn1Object()
	{
		Asn1EncodableVector v = new Asn1EncodableVector(version, issuerAndSerialNumber, digAlgorithm);
		v.AddOptionalTagged(isExplicit: false, 0, authenticatedAttributes);
		v.Add(digEncryptionAlgorithm, encryptedDigest);
		v.AddOptionalTagged(isExplicit: false, 1, unauthenticatedAttributes);
		return new DerSequence(v);
	}
}
