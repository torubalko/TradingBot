using System;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto.Parameters;

public class RsaPrivateCrtKeyParameters : RsaKeyParameters
{
	private readonly BigInteger e;

	private readonly BigInteger p;

	private readonly BigInteger q;

	private readonly BigInteger dP;

	private readonly BigInteger dQ;

	private readonly BigInteger qInv;

	public BigInteger PublicExponent => e;

	public BigInteger P => p;

	public BigInteger Q => q;

	public BigInteger DP => dP;

	public BigInteger DQ => dQ;

	public BigInteger QInv => qInv;

	public RsaPrivateCrtKeyParameters(BigInteger modulus, BigInteger publicExponent, BigInteger privateExponent, BigInteger p, BigInteger q, BigInteger dP, BigInteger dQ, BigInteger qInv)
		: base(isPrivate: true, modulus, privateExponent)
	{
		ValidateValue(publicExponent, "publicExponent", "exponent");
		ValidateValue(p, "p", "P value");
		ValidateValue(q, "q", "Q value");
		ValidateValue(dP, "dP", "DP value");
		ValidateValue(dQ, "dQ", "DQ value");
		ValidateValue(qInv, "qInv", "InverseQ value");
		e = publicExponent;
		this.p = p;
		this.q = q;
		this.dP = dP;
		this.dQ = dQ;
		this.qInv = qInv;
	}

	public RsaPrivateCrtKeyParameters(RsaPrivateKeyStructure rsaPrivateKey)
		: this(rsaPrivateKey.Modulus, rsaPrivateKey.PublicExponent, rsaPrivateKey.PrivateExponent, rsaPrivateKey.Prime1, rsaPrivateKey.Prime2, rsaPrivateKey.Exponent1, rsaPrivateKey.Exponent2, rsaPrivateKey.Coefficient)
	{
	}

	public override bool Equals(object obj)
	{
		if (obj == this)
		{
			return true;
		}
		if (!(obj is RsaPrivateCrtKeyParameters kp))
		{
			return false;
		}
		if (kp.DP.Equals(dP) && kp.DQ.Equals(dQ) && kp.Exponent.Equals(base.Exponent) && kp.Modulus.Equals(base.Modulus) && kp.P.Equals(p) && kp.Q.Equals(q) && kp.PublicExponent.Equals(e))
		{
			return kp.QInv.Equals(qInv);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return DP.GetHashCode() ^ DQ.GetHashCode() ^ base.Exponent.GetHashCode() ^ base.Modulus.GetHashCode() ^ P.GetHashCode() ^ Q.GetHashCode() ^ PublicExponent.GetHashCode() ^ QInv.GetHashCode();
	}

	private static void ValidateValue(BigInteger x, string name, string desc)
	{
		if (x == null)
		{
			throw new ArgumentNullException(name);
		}
		if (x.SignValue <= 0)
		{
			throw new ArgumentException("Not a valid RSA " + desc, name);
		}
	}
}
