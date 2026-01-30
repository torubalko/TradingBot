using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Engines;

public class RsaBlindedEngine : IAsymmetricBlockCipher
{
	private readonly IRsa core;

	private RsaKeyParameters key;

	private SecureRandom random;

	public virtual string AlgorithmName => "RSA";

	public RsaBlindedEngine()
		: this(new RsaCoreEngine())
	{
	}

	public RsaBlindedEngine(IRsa rsa)
	{
		core = rsa;
	}

	public virtual void Init(bool forEncryption, ICipherParameters param)
	{
		core.Init(forEncryption, param);
		if (param is ParametersWithRandom)
		{
			ParametersWithRandom rParam = (ParametersWithRandom)param;
			key = (RsaKeyParameters)rParam.Parameters;
			if (key is RsaPrivateCrtKeyParameters)
			{
				random = rParam.Random;
			}
			else
			{
				random = null;
			}
		}
		else
		{
			key = (RsaKeyParameters)param;
			if (key is RsaPrivateCrtKeyParameters)
			{
				random = new SecureRandom();
			}
			else
			{
				random = null;
			}
		}
	}

	public virtual int GetInputBlockSize()
	{
		return core.GetInputBlockSize();
	}

	public virtual int GetOutputBlockSize()
	{
		return core.GetOutputBlockSize();
	}

	public virtual byte[] ProcessBlock(byte[] inBuf, int inOff, int inLen)
	{
		if (key == null)
		{
			throw new InvalidOperationException("RSA engine not initialised");
		}
		BigInteger input = core.ConvertInput(inBuf, inOff, inLen);
		BigInteger result;
		if (key is RsaPrivateCrtKeyParameters)
		{
			RsaPrivateCrtKeyParameters k = (RsaPrivateCrtKeyParameters)key;
			BigInteger e = k.PublicExponent;
			if (e != null)
			{
				BigInteger m = k.Modulus;
				BigInteger r = BigIntegers.CreateRandomInRange(BigInteger.One, m.Subtract(BigInteger.One), random);
				BigInteger blindedInput = r.ModPow(e, m).Multiply(input).Mod(m);
				BigInteger bigInteger = core.ProcessBlock(blindedInput);
				BigInteger rInv = BigIntegers.ModOddInverse(m, r);
				result = bigInteger.Multiply(rInv).Mod(m);
				if (!input.Equals(result.ModPow(e, m)))
				{
					throw new InvalidOperationException("RSA engine faulty decryption/signing detected");
				}
			}
			else
			{
				result = core.ProcessBlock(input);
			}
		}
		else
		{
			result = core.ProcessBlock(input);
		}
		return core.ConvertOutput(result);
	}
}
