using System;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Signers;

public class ECNRSigner : IDsaExt, IDsa
{
	private bool forSigning;

	private ECKeyParameters key;

	private SecureRandom random;

	public virtual string AlgorithmName => "ECNR";

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
			throw new InvalidOperationException("not initialised for signing");
		}
		BigInteger n = Order;
		int nBitLength = n.BitLength;
		BigInteger e = new BigInteger(1, message);
		int bitLength = e.BitLength;
		ECPrivateKeyParameters privKey = (ECPrivateKeyParameters)key;
		if (bitLength > nBitLength)
		{
			throw new DataLengthException("input too large for ECNR key.");
		}
		BigInteger r = null;
		BigInteger s = null;
		AsymmetricCipherKeyPair tempPair;
		do
		{
			ECKeyPairGenerator eCKeyPairGenerator = new ECKeyPairGenerator();
			eCKeyPairGenerator.Init(new ECKeyGenerationParameters(privKey.Parameters, random));
			tempPair = eCKeyPairGenerator.GenerateKeyPair();
			r = ((ECPublicKeyParameters)tempPair.Public).Q.AffineXCoord.ToBigInteger().Add(e).Mod(n);
		}
		while (r.SignValue == 0);
		BigInteger x = privKey.D;
		s = ((ECPrivateKeyParameters)tempPair.Private).D.Subtract(r.Multiply(x)).Mod(n);
		return new BigInteger[2] { r, s };
	}

	public virtual bool VerifySignature(byte[] message, BigInteger r, BigInteger s)
	{
		if (forSigning)
		{
			throw new InvalidOperationException("not initialised for verifying");
		}
		ECPublicKeyParameters pubKey = (ECPublicKeyParameters)key;
		BigInteger n = pubKey.Parameters.N;
		int nBitLength = n.BitLength;
		BigInteger e = new BigInteger(1, message);
		if (e.BitLength > nBitLength)
		{
			throw new DataLengthException("input too large for ECNR key.");
		}
		if (r.CompareTo(BigInteger.One) < 0 || r.CompareTo(n) >= 0)
		{
			return false;
		}
		if (s.CompareTo(BigInteger.Zero) < 0 || s.CompareTo(n) >= 0)
		{
			return false;
		}
		ECPoint G = pubKey.Parameters.G;
		ECPoint W = pubKey.Q;
		ECPoint P = ECAlgorithms.SumOfTwoMultiplies(G, s, W, r).Normalize();
		if (P.IsInfinity)
		{
			return false;
		}
		BigInteger x = P.AffineXCoord.ToBigInteger();
		return r.Subtract(x).Mod(n).Equals(e);
	}
}
