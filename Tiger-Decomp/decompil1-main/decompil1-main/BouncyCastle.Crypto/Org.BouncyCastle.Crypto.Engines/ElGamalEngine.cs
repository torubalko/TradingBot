using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Engines;

public class ElGamalEngine : IAsymmetricBlockCipher
{
	private ElGamalKeyParameters key;

	private SecureRandom random;

	private bool forEncryption;

	private int bitSize;

	public virtual string AlgorithmName => "ElGamal";

	public virtual void Init(bool forEncryption, ICipherParameters parameters)
	{
		if (parameters is ParametersWithRandom)
		{
			ParametersWithRandom p = (ParametersWithRandom)parameters;
			key = (ElGamalKeyParameters)p.Parameters;
			random = p.Random;
		}
		else
		{
			key = (ElGamalKeyParameters)parameters;
			random = new SecureRandom();
		}
		this.forEncryption = forEncryption;
		bitSize = key.Parameters.P.BitLength;
		if (forEncryption)
		{
			if (!(key is ElGamalPublicKeyParameters))
			{
				throw new ArgumentException("ElGamalPublicKeyParameters are required for encryption.");
			}
		}
		else if (!(key is ElGamalPrivateKeyParameters))
		{
			throw new ArgumentException("ElGamalPrivateKeyParameters are required for decryption.");
		}
	}

	public virtual int GetInputBlockSize()
	{
		if (forEncryption)
		{
			return (bitSize - 1) / 8;
		}
		return 2 * ((bitSize + 7) / 8);
	}

	public virtual int GetOutputBlockSize()
	{
		if (forEncryption)
		{
			return 2 * ((bitSize + 7) / 8);
		}
		return (bitSize - 1) / 8;
	}

	public virtual byte[] ProcessBlock(byte[] input, int inOff, int length)
	{
		if (key == null)
		{
			throw new InvalidOperationException("ElGamal engine not initialised");
		}
		int maxLength = (forEncryption ? ((bitSize - 1 + 7) / 8) : GetInputBlockSize());
		if (length > maxLength)
		{
			throw new DataLengthException("input too large for ElGamal cipher.\n");
		}
		BigInteger p = key.Parameters.P;
		byte[] output;
		if (key is ElGamalPrivateKeyParameters)
		{
			int halfLength = length / 2;
			BigInteger bigInteger = new BigInteger(1, input, inOff, halfLength);
			BigInteger phi = new BigInteger(1, input, inOff + halfLength, halfLength);
			ElGamalPrivateKeyParameters priv = (ElGamalPrivateKeyParameters)key;
			output = bigInteger.ModPow(p.Subtract(BigInteger.One).Subtract(priv.X), p).Multiply(phi).Mod(p)
				.ToByteArrayUnsigned();
		}
		else
		{
			BigInteger tmp = new BigInteger(1, input, inOff, length);
			if (tmp.BitLength >= p.BitLength)
			{
				throw new DataLengthException("input too large for ElGamal cipher.\n");
			}
			ElGamalPublicKeyParameters pub = (ElGamalPublicKeyParameters)key;
			BigInteger pSub2 = p.Subtract(BigInteger.Two);
			BigInteger k;
			do
			{
				k = new BigInteger(p.BitLength, random);
			}
			while (k.SignValue == 0 || k.CompareTo(pSub2) > 0);
			BigInteger gamma = key.Parameters.G.ModPow(k, p);
			BigInteger bigInteger2 = tmp.Multiply(pub.Y.ModPow(k, p)).Mod(p);
			output = new byte[GetOutputBlockSize()];
			byte[] out1 = gamma.ToByteArrayUnsigned();
			byte[] out2 = bigInteger2.ToByteArrayUnsigned();
			out1.CopyTo(output, output.Length / 2 - out1.Length);
			out2.CopyTo(output, output.Length - out2.Length);
		}
		return output;
	}
}
