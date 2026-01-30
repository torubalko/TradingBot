using System;
using System.Collections;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Engines;

public class NaccacheSternEngine : IAsymmetricBlockCipher
{
	private bool forEncryption;

	private NaccacheSternKeyParameters key;

	private IList[] lookup;

	public string AlgorithmName => "NaccacheStern";

	[Obsolete("Remove: no longer used")]
	public virtual bool Debug
	{
		set
		{
		}
	}

	public virtual void Init(bool forEncryption, ICipherParameters parameters)
	{
		this.forEncryption = forEncryption;
		if (parameters is ParametersWithRandom)
		{
			parameters = ((ParametersWithRandom)parameters).Parameters;
		}
		key = (NaccacheSternKeyParameters)parameters;
		if (this.forEncryption)
		{
			return;
		}
		NaccacheSternPrivateKeyParameters priv = (NaccacheSternPrivateKeyParameters)key;
		IList primes = priv.SmallPrimesList;
		lookup = new IList[primes.Count];
		for (int i = 0; i < primes.Count; i++)
		{
			BigInteger actualPrime = (BigInteger)primes[i];
			int actualPrimeValue = actualPrime.IntValue;
			lookup[i] = Platform.CreateArrayList(actualPrimeValue);
			lookup[i].Add(BigInteger.One);
			BigInteger accJ = BigInteger.Zero;
			for (int j = 1; j < actualPrimeValue; j++)
			{
				accJ = accJ.Add(priv.PhiN);
				BigInteger comp = accJ.Divide(actualPrime);
				lookup[i].Add(priv.G.ModPow(comp, priv.Modulus));
			}
		}
	}

	public virtual int GetInputBlockSize()
	{
		if (forEncryption)
		{
			return (key.LowerSigmaBound + 7) / 8 - 1;
		}
		return key.Modulus.BitLength / 8 + 1;
	}

	public virtual int GetOutputBlockSize()
	{
		if (forEncryption)
		{
			return key.Modulus.BitLength / 8 + 1;
		}
		return (key.LowerSigmaBound + 7) / 8 - 1;
	}

	public virtual byte[] ProcessBlock(byte[] inBytes, int inOff, int length)
	{
		if (key == null)
		{
			throw new InvalidOperationException("NaccacheStern engine not initialised");
		}
		if (length > GetInputBlockSize() + 1)
		{
			throw new DataLengthException("input too large for Naccache-Stern cipher.\n");
		}
		if (!forEncryption && length < GetInputBlockSize())
		{
			throw new InvalidCipherTextException("BlockLength does not match modulus for Naccache-Stern cipher.\n");
		}
		BigInteger input = new BigInteger(1, inBytes, inOff, length);
		if (forEncryption)
		{
			return Encrypt(input);
		}
		IList plain = Platform.CreateArrayList();
		NaccacheSternPrivateKeyParameters priv = (NaccacheSternPrivateKeyParameters)key;
		IList primes = priv.SmallPrimesList;
		for (int i = 0; i < primes.Count; i++)
		{
			BigInteger exp = input.ModPow(priv.PhiN.Divide((BigInteger)primes[i]), priv.Modulus);
			IList al = lookup[i];
			if (lookup[i].Count != ((BigInteger)primes[i]).IntValue)
			{
				throw new InvalidCipherTextException("Error in lookup Array for " + ((BigInteger)primes[i]).IntValue + ": Size mismatch. Expected ArrayList with length " + ((BigInteger)primes[i]).IntValue + " but found ArrayList of length " + lookup[i].Count);
			}
			int lookedup = al.IndexOf(exp);
			if (lookedup == -1)
			{
				throw new InvalidCipherTextException("Lookup failed");
			}
			plain.Add(BigInteger.ValueOf(lookedup));
		}
		return chineseRemainder(plain, primes).ToByteArray();
	}

	public virtual byte[] Encrypt(BigInteger plain)
	{
		byte[] output = new byte[key.Modulus.BitLength / 8 + 1];
		byte[] tmp = key.G.ModPow(plain, key.Modulus).ToByteArray();
		Array.Copy(tmp, 0, output, output.Length - tmp.Length, tmp.Length);
		return output;
	}

	public virtual byte[] AddCryptedBlocks(byte[] block1, byte[] block2)
	{
		if (forEncryption)
		{
			if (block1.Length > GetOutputBlockSize() || block2.Length > GetOutputBlockSize())
			{
				throw new InvalidCipherTextException("BlockLength too large for simple addition.\n");
			}
		}
		else if (block1.Length > GetInputBlockSize() || block2.Length > GetInputBlockSize())
		{
			throw new InvalidCipherTextException("BlockLength too large for simple addition.\n");
		}
		BigInteger bigInteger = new BigInteger(1, block1);
		BigInteger m2Crypt = new BigInteger(1, block2);
		BigInteger bigInteger2 = bigInteger.Multiply(m2Crypt).Mod(key.Modulus);
		byte[] output = new byte[key.Modulus.BitLength / 8 + 1];
		byte[] m1m2CryptBytes = bigInteger2.ToByteArray();
		Array.Copy(m1m2CryptBytes, 0, output, output.Length - m1m2CryptBytes.Length, m1m2CryptBytes.Length);
		return output;
	}

	public virtual byte[] ProcessData(byte[] data)
	{
		if (data.Length > GetInputBlockSize())
		{
			int inBlocksize = GetInputBlockSize();
			int outBlocksize = GetOutputBlockSize();
			int datapos = 0;
			int retpos = 0;
			byte[] retval = new byte[(data.Length / inBlocksize + 1) * outBlocksize];
			while (datapos < data.Length)
			{
				byte[] tmp;
				if (datapos + inBlocksize < data.Length)
				{
					tmp = ProcessBlock(data, datapos, inBlocksize);
					datapos += inBlocksize;
				}
				else
				{
					tmp = ProcessBlock(data, datapos, data.Length - datapos);
					datapos += data.Length - datapos;
				}
				if (tmp != null)
				{
					tmp.CopyTo(retval, retpos);
					retpos += tmp.Length;
					continue;
				}
				throw new InvalidCipherTextException("cipher returned null");
			}
			byte[] ret = new byte[retpos];
			Array.Copy(retval, 0, ret, 0, retpos);
			return ret;
		}
		return ProcessBlock(data, 0, data.Length);
	}

	private static BigInteger chineseRemainder(IList congruences, IList primes)
	{
		BigInteger retval = BigInteger.Zero;
		BigInteger all = BigInteger.One;
		for (int i = 0; i < primes.Count; i++)
		{
			all = all.Multiply((BigInteger)primes[i]);
		}
		for (int j = 0; j < primes.Count; j++)
		{
			BigInteger a = (BigInteger)primes[j];
			BigInteger bigInteger = all.Divide(a);
			BigInteger b2 = bigInteger.ModInverse(a);
			BigInteger tmp = bigInteger.Multiply(b2);
			tmp = tmp.Multiply((BigInteger)congruences[j]);
			retval = retval.Add(tmp);
		}
		return retval.Mod(all);
	}
}
