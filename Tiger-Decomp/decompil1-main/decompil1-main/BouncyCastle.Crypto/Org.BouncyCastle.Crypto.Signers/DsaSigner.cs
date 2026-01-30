using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Signers;

public class DsaSigner : IDsaExt, IDsa
{
	protected readonly IDsaKCalculator kCalculator;

	protected DsaKeyParameters key;

	protected SecureRandom random;

	public virtual string AlgorithmName => "DSA";

	public virtual BigInteger Order => key.Parameters.Q;

	public DsaSigner()
	{
		kCalculator = new RandomDsaKCalculator();
	}

	public DsaSigner(IDsaKCalculator kCalculator)
	{
		this.kCalculator = kCalculator;
	}

	public virtual void Init(bool forSigning, ICipherParameters parameters)
	{
		SecureRandom providedRandom = null;
		if (forSigning)
		{
			if (parameters is ParametersWithRandom)
			{
				ParametersWithRandom obj = (ParametersWithRandom)parameters;
				providedRandom = obj.Random;
				parameters = obj.Parameters;
			}
			if (!(parameters is DsaPrivateKeyParameters))
			{
				throw new InvalidKeyException("DSA private key required for signing");
			}
			key = (DsaPrivateKeyParameters)parameters;
		}
		else
		{
			if (!(parameters is DsaPublicKeyParameters))
			{
				throw new InvalidKeyException("DSA public key required for verification");
			}
			key = (DsaPublicKeyParameters)parameters;
		}
		random = InitSecureRandom(forSigning && !kCalculator.IsDeterministic, providedRandom);
	}

	public virtual BigInteger[] GenerateSignature(byte[] message)
	{
		DsaParameters parameters = key.Parameters;
		BigInteger q = parameters.Q;
		BigInteger m = CalculateE(q, message);
		BigInteger x = ((DsaPrivateKeyParameters)key).X;
		if (kCalculator.IsDeterministic)
		{
			kCalculator.Init(q, x, message);
		}
		else
		{
			kCalculator.Init(q, random);
		}
		BigInteger k = kCalculator.NextK();
		BigInteger r = parameters.G.ModPow(k, parameters.P).Mod(q);
		k = BigIntegers.ModOddInverse(q, k).Multiply(m.Add(x.Multiply(r)));
		BigInteger s = k.Mod(q);
		return new BigInteger[2] { r, s };
	}

	public virtual bool VerifySignature(byte[] message, BigInteger r, BigInteger s)
	{
		DsaParameters parameters = key.Parameters;
		BigInteger q = parameters.Q;
		BigInteger m = CalculateE(q, message);
		if (r.SignValue <= 0 || q.CompareTo(r) <= 0)
		{
			return false;
		}
		if (s.SignValue <= 0 || q.CompareTo(s) <= 0)
		{
			return false;
		}
		BigInteger w = BigIntegers.ModOddInverseVar(q, s);
		BigInteger u1 = m.Multiply(w).Mod(q);
		BigInteger u2 = r.Multiply(w).Mod(q);
		BigInteger p = parameters.P;
		u1 = parameters.G.ModPow(u1, p);
		u2 = ((DsaPublicKeyParameters)key).Y.ModPow(u2, p);
		return u1.Multiply(u2).Mod(p).Mod(q)
			.Equals(r);
	}

	protected virtual BigInteger CalculateE(BigInteger n, byte[] message)
	{
		int length = System.Math.Min(message.Length, n.BitLength / 8);
		return new BigInteger(1, message, 0, length);
	}

	protected virtual SecureRandom InitSecureRandom(bool needed, SecureRandom provided)
	{
		if (needed)
		{
			if (provided == null)
			{
				return new SecureRandom();
			}
			return provided;
		}
		return null;
	}
}
