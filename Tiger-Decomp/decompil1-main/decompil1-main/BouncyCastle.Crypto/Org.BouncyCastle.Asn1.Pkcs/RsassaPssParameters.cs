using System;
using Org.BouncyCastle.Asn1.Oiw;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Pkcs;

public class RsassaPssParameters : Asn1Encodable
{
	private AlgorithmIdentifier hashAlgorithm;

	private AlgorithmIdentifier maskGenAlgorithm;

	private DerInteger saltLength;

	private DerInteger trailerField;

	public static readonly AlgorithmIdentifier DefaultHashAlgorithm = new AlgorithmIdentifier(OiwObjectIdentifiers.IdSha1, DerNull.Instance);

	public static readonly AlgorithmIdentifier DefaultMaskGenFunction = new AlgorithmIdentifier(PkcsObjectIdentifiers.IdMgf1, DefaultHashAlgorithm);

	public static readonly DerInteger DefaultSaltLength = new DerInteger(20);

	public static readonly DerInteger DefaultTrailerField = new DerInteger(1);

	public AlgorithmIdentifier HashAlgorithm => hashAlgorithm;

	public AlgorithmIdentifier MaskGenAlgorithm => maskGenAlgorithm;

	public DerInteger SaltLength => saltLength;

	public DerInteger TrailerField => trailerField;

	public static RsassaPssParameters GetInstance(object obj)
	{
		if (obj == null || obj is RsassaPssParameters)
		{
			return (RsassaPssParameters)obj;
		}
		if (obj is Asn1Sequence)
		{
			return new RsassaPssParameters((Asn1Sequence)obj);
		}
		throw new ArgumentException("Unknown object in factory: " + Platform.GetTypeName(obj), "obj");
	}

	public RsassaPssParameters()
	{
		hashAlgorithm = DefaultHashAlgorithm;
		maskGenAlgorithm = DefaultMaskGenFunction;
		saltLength = DefaultSaltLength;
		trailerField = DefaultTrailerField;
	}

	public RsassaPssParameters(AlgorithmIdentifier hashAlgorithm, AlgorithmIdentifier maskGenAlgorithm, DerInteger saltLength, DerInteger trailerField)
	{
		this.hashAlgorithm = hashAlgorithm;
		this.maskGenAlgorithm = maskGenAlgorithm;
		this.saltLength = saltLength;
		this.trailerField = trailerField;
	}

	public RsassaPssParameters(Asn1Sequence seq)
	{
		hashAlgorithm = DefaultHashAlgorithm;
		maskGenAlgorithm = DefaultMaskGenFunction;
		saltLength = DefaultSaltLength;
		trailerField = DefaultTrailerField;
		for (int i = 0; i != seq.Count; i++)
		{
			Asn1TaggedObject o = (Asn1TaggedObject)seq[i];
			switch (o.TagNo)
			{
			case 0:
				hashAlgorithm = AlgorithmIdentifier.GetInstance(o, explicitly: true);
				break;
			case 1:
				maskGenAlgorithm = AlgorithmIdentifier.GetInstance(o, explicitly: true);
				break;
			case 2:
				saltLength = DerInteger.GetInstance(o, isExplicit: true);
				break;
			case 3:
				trailerField = DerInteger.GetInstance(o, isExplicit: true);
				break;
			default:
				throw new ArgumentException("unknown tag");
			}
		}
	}

	public override Asn1Object ToAsn1Object()
	{
		Asn1EncodableVector v = new Asn1EncodableVector();
		if (!hashAlgorithm.Equals(DefaultHashAlgorithm))
		{
			v.Add(new DerTaggedObject(explicitly: true, 0, hashAlgorithm));
		}
		if (!maskGenAlgorithm.Equals(DefaultMaskGenFunction))
		{
			v.Add(new DerTaggedObject(explicitly: true, 1, maskGenAlgorithm));
		}
		if (!saltLength.Equals(DefaultSaltLength))
		{
			v.Add(new DerTaggedObject(explicitly: true, 2, saltLength));
		}
		if (!trailerField.Equals(DefaultTrailerField))
		{
			v.Add(new DerTaggedObject(explicitly: true, 3, trailerField));
		}
		return new DerSequence(v);
	}
}
