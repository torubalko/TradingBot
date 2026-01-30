using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC;

namespace Org.BouncyCastle.Crypto.Agreement;

public class ECDHCBasicAgreement : IBasicAgreement
{
	private ECPrivateKeyParameters privKey;

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
			throw new InvalidOperationException("ECDHC public key has wrong domain parameters");
		}
		BigInteger hd = dp.H.Multiply(privKey.D).Mod(dp.N);
		ECPoint eCPoint = ECAlgorithms.CleanPoint(dp.Curve, pub.Q);
		if (eCPoint.IsInfinity)
		{
			throw new InvalidOperationException("Infinity is not a valid public key for ECDHC");
		}
		ECPoint eCPoint2 = eCPoint.Multiply(hd).Normalize();
		if (eCPoint2.IsInfinity)
		{
			throw new InvalidOperationException("Infinity is not a valid agreement value for ECDHC");
		}
		return eCPoint2.AffineXCoord.ToBigInteger();
	}
}
