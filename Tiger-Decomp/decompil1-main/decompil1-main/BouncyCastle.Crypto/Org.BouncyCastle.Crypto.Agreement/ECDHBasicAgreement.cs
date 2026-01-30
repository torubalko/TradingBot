using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC;

namespace Org.BouncyCastle.Crypto.Agreement;

public class ECDHBasicAgreement : IBasicAgreement
{
	protected internal ECPrivateKeyParameters privKey;

	public virtual void Init(ICipherParameters parameters)
	{
		if (parameters is ParametersWithRandom)
		{
			parameters = ((ParametersWithRandom)parameters).Parameters;
		}
		privKey = (ECPrivateKeyParameters)parameters;
	}

	public virtual int GetFieldSize()
	{
		return (privKey.Parameters.Curve.FieldSize + 7) / 8;
	}

	public virtual BigInteger CalculateAgreement(ICipherParameters pubKey)
	{
		ECPublicKeyParameters pub = (ECPublicKeyParameters)pubKey;
		ECDomainParameters dp = privKey.Parameters;
		if (!dp.Equals(pub.Parameters))
		{
			throw new InvalidOperationException("ECDH public key has wrong domain parameters");
		}
		BigInteger d = privKey.D;
		ECPoint Q = ECAlgorithms.CleanPoint(dp.Curve, pub.Q);
		if (Q.IsInfinity)
		{
			throw new InvalidOperationException("Infinity is not a valid public key for ECDH");
		}
		BigInteger h = dp.H;
		if (!h.Equals(BigInteger.One))
		{
			d = dp.HInv.Multiply(d).Mod(dp.N);
			Q = ECAlgorithms.ReferenceMultiply(Q, h);
		}
		ECPoint eCPoint = Q.Multiply(d).Normalize();
		if (eCPoint.IsInfinity)
		{
			throw new InvalidOperationException("Infinity is not a valid agreement value for ECDH");
		}
		return eCPoint.AffineXCoord.ToBigInteger();
	}
}
