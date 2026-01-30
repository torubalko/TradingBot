using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC;
using Org.BouncyCastle.Math.EC.Multiplier;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Signers;

public class ECGost3410Signer : IDsaExt, IDsa
{
	private ECKeyParameters key;

	private SecureRandom random;

	private bool forSigning;

	public virtual string AlgorithmName => key.AlgorithmName;

	public virtual BigInteger Order => key.Parameters.N;

	public virtual void Init(bool forSigning, ICipherParameters parameters)
	{
		this.forSigning = forSigning;
		if (forSigning)
		{
			if (parameters is ParametersWithRandom)
			{
				ParametersWithRandom rParam = (ParametersWithRandom)parameters;
				random = rParam.Random;
				parameters = rParam.Parameters;
			}
			else
			{
				random = new SecureRandom();
			}
			if (!(parameters is ECPrivateKeyParameters))
			{
				throw new InvalidKeyException("EC private key required for signing");
			}
			key = (ECPrivateKeyParameters)parameters;
		}
		else
		{
			if (!(parameters is ECPublicKeyParameters))
			{
				throw new InvalidKeyException("EC public key required for verification");
			}
			key = (ECPublicKeyParameters)parameters;
		}
	}

	public virtual BigInteger[] GenerateSignature(byte[] message)
	{
		if (!forSigning)
		{
			throw new InvalidOperationException("not initialized for signing");
		}
		byte[] mRev = Arrays.Reverse(message);
		BigInteger e = new BigInteger(1, mRev);
		ECDomainParameters ec = key.Parameters;
		BigInteger n = ec.N;
		BigInteger d = ((ECPrivateKeyParameters)key).D;
		BigInteger s = null;
		ECMultiplier basePointMultiplier = CreateBasePointMultiplier();
		BigInteger r;
		while (true)
		{
			BigInteger k = new BigInteger(n.BitLength, random);
			if (k.SignValue == 0)
			{
				continue;
			}
			r = basePointMultiplier.Multiply(ec.G, k).Normalize().AffineXCoord.ToBigInteger().Mod(n);
			if (r.SignValue != 0)
			{
				s = k.Multiply(e).Add(d.Multiply(r)).Mod(n);
				if (s.SignValue != 0)
				{
					break;
				}
			}
		}
		return new BigInteger[2] { r, s };
	}

	public virtual bool VerifySignature(byte[] message, BigInteger r, BigInteger s)
	{
		if (forSigning)
		{
			throw new InvalidOperationException("not initialized for verification");
		}
		byte[] mRev = Arrays.Reverse(message);
		BigInteger e = new BigInteger(1, mRev);
		BigInteger n = key.Parameters.N;
		if (r.CompareTo(BigInteger.One) < 0 || r.CompareTo(n) >= 0)
		{
			return false;
		}
		if (s.CompareTo(BigInteger.One) < 0 || s.CompareTo(n) >= 0)
		{
			return false;
		}
		BigInteger v = BigIntegers.ModOddInverseVar(n, e);
		BigInteger z1 = s.Multiply(v).Mod(n);
		BigInteger z2 = n.Subtract(r).Multiply(v).Mod(n);
		ECPoint g = key.Parameters.G;
		ECPoint Q = ((ECPublicKeyParameters)key).Q;
		ECPoint point = ECAlgorithms.SumOfTwoMultiplies(g, z1, Q, z2).Normalize();
		if (point.IsInfinity)
		{
			return false;
		}
		return point.AffineXCoord.ToBigInteger().Mod(n).Equals(r);
	}

	protected virtual ECMultiplier CreateBasePointMultiplier()
	{
		return new FixedPointCombMultiplier();
	}
}
