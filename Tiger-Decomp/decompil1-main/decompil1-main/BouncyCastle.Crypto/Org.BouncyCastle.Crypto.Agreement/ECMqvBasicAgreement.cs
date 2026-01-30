using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC;

namespace Org.BouncyCastle.Crypto.Agreement;

public class ECMqvBasicAgreement : IBasicAgreement
{
	protected internal MqvPrivateParameters privParams;

	public virtual void Init(ICipherParameters parameters)
	{
		if (parameters is ParametersWithRandom)
		{
			parameters = ((ParametersWithRandom)parameters).Parameters;
		}
		privParams = (MqvPrivateParameters)parameters;
	}

	public virtual int GetFieldSize()
	{
		return (privParams.StaticPrivateKey.Parameters.Curve.FieldSize + 7) / 8;
	}

	public virtual BigInteger CalculateAgreement(ICipherParameters pubKey)
	{
		MqvPublicParameters pubParams = (MqvPublicParameters)pubKey;
		ECPrivateKeyParameters staticPrivateKey = privParams.StaticPrivateKey;
		ECDomainParameters parameters = staticPrivateKey.Parameters;
		if (!parameters.Equals(pubParams.StaticPublicKey.Parameters))
		{
			throw new InvalidOperationException("ECMQV public key components have wrong domain parameters");
		}
		ECPoint eCPoint = CalculateMqvAgreement(parameters, staticPrivateKey, privParams.EphemeralPrivateKey, privParams.EphemeralPublicKey, pubParams.StaticPublicKey, pubParams.EphemeralPublicKey).Normalize();
		if (eCPoint.IsInfinity)
		{
			throw new InvalidOperationException("Infinity is not a valid agreement value for MQV");
		}
		return eCPoint.AffineXCoord.ToBigInteger();
	}

	private static ECPoint CalculateMqvAgreement(ECDomainParameters parameters, ECPrivateKeyParameters d1U, ECPrivateKeyParameters d2U, ECPublicKeyParameters Q2U, ECPublicKeyParameters Q1V, ECPublicKeyParameters Q2V)
	{
		BigInteger n = parameters.N;
		int e = (n.BitLength + 1) / 2;
		BigInteger powE = BigInteger.One.ShiftLeft(e);
		ECCurve curve = parameters.Curve;
		ECPoint q2u = ECAlgorithms.CleanPoint(curve, Q2U.Q);
		ECPoint q1v = ECAlgorithms.CleanPoint(curve, Q1V.Q);
		ECPoint q2v = ECAlgorithms.CleanPoint(curve, Q2V.Q);
		BigInteger Q2UBar = q2u.AffineXCoord.ToBigInteger().Mod(powE).SetBit(e);
		BigInteger s = d1U.D.Multiply(Q2UBar).Add(d2U.D).Mod(n);
		BigInteger Q2VBar = q2v.AffineXCoord.ToBigInteger().Mod(powE).SetBit(e);
		BigInteger hs = parameters.H.Multiply(s).Mod(n);
		return ECAlgorithms.SumOfTwoMultiplies(q1v, Q2VBar.Multiply(hs).Mod(n), q2v, hs);
	}
}
