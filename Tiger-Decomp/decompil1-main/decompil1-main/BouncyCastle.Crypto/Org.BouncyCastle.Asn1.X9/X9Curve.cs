using System;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.X9;

public class X9Curve : Asn1Encodable
{
	private readonly ECCurve curve;

	private readonly byte[] seed;

	private readonly DerObjectIdentifier fieldIdentifier;

	public ECCurve Curve => curve;

	public X9Curve(ECCurve curve)
		: this(curve, null)
	{
	}

	public X9Curve(ECCurve curve, byte[] seed)
	{
		if (curve == null)
		{
			throw new ArgumentNullException("curve");
		}
		this.curve = curve;
		this.seed = Arrays.Clone(seed);
		if (ECAlgorithms.IsFpCurve(curve))
		{
			fieldIdentifier = X9ObjectIdentifiers.PrimeField;
			return;
		}
		if (ECAlgorithms.IsF2mCurve(curve))
		{
			fieldIdentifier = X9ObjectIdentifiers.CharacteristicTwoField;
			return;
		}
		throw new ArgumentException("This type of ECCurve is not implemented");
	}

	[Obsolete("Use constructor including order/cofactor")]
	public X9Curve(X9FieldID fieldID, Asn1Sequence seq)
		: this(fieldID, null, null, seq)
	{
	}

	public X9Curve(X9FieldID fieldID, BigInteger order, BigInteger cofactor, Asn1Sequence seq)
	{
		if (fieldID == null)
		{
			throw new ArgumentNullException("fieldID");
		}
		if (seq == null)
		{
			throw new ArgumentNullException("seq");
		}
		fieldIdentifier = fieldID.Identifier;
		if (fieldIdentifier.Equals(X9ObjectIdentifiers.PrimeField))
		{
			BigInteger p = ((DerInteger)fieldID.Parameters).Value;
			BigInteger A = new BigInteger(1, Asn1OctetString.GetInstance(seq[0]).GetOctets());
			BigInteger B = new BigInteger(1, Asn1OctetString.GetInstance(seq[1]).GetOctets());
			curve = new FpCurve(p, A, B, order, cofactor);
		}
		else
		{
			if (!fieldIdentifier.Equals(X9ObjectIdentifiers.CharacteristicTwoField))
			{
				throw new ArgumentException("This type of ECCurve is not implemented");
			}
			DerSequence parameters = (DerSequence)fieldID.Parameters;
			int m = ((DerInteger)parameters[0]).IntValueExact;
			DerObjectIdentifier obj = (DerObjectIdentifier)parameters[1];
			int k1 = 0;
			int k2 = 0;
			int k3 = 0;
			if (obj.Equals(X9ObjectIdentifiers.TPBasis))
			{
				k1 = ((DerInteger)parameters[2]).IntValueExact;
			}
			else
			{
				DerSequence obj2 = (DerSequence)parameters[2];
				k1 = ((DerInteger)obj2[0]).IntValueExact;
				k2 = ((DerInteger)obj2[1]).IntValueExact;
				k3 = ((DerInteger)obj2[2]).IntValueExact;
			}
			BigInteger A2 = new BigInteger(1, Asn1OctetString.GetInstance(seq[0]).GetOctets());
			BigInteger B2 = new BigInteger(1, Asn1OctetString.GetInstance(seq[1]).GetOctets());
			curve = new F2mCurve(m, k1, k2, k3, A2, B2, order, cofactor);
		}
		if (seq.Count == 3)
		{
			seed = ((DerBitString)seq[2]).GetBytes();
		}
	}

	public byte[] GetSeed()
	{
		return Arrays.Clone(seed);
	}

	public override Asn1Object ToAsn1Object()
	{
		Asn1EncodableVector v = new Asn1EncodableVector();
		if (fieldIdentifier.Equals(X9ObjectIdentifiers.PrimeField) || fieldIdentifier.Equals(X9ObjectIdentifiers.CharacteristicTwoField))
		{
			v.Add(new X9FieldElement(curve.A).ToAsn1Object());
			v.Add(new X9FieldElement(curve.B).ToAsn1Object());
		}
		if (seed != null)
		{
			v.Add(new DerBitString(seed));
		}
		return new DerSequence(v);
	}
}
