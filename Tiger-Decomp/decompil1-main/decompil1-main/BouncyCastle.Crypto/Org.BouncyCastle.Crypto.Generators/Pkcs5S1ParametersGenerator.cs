using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Generators;

public class Pkcs5S1ParametersGenerator : PbeParametersGenerator
{
	private readonly IDigest digest;

	public Pkcs5S1ParametersGenerator(IDigest digest)
	{
		this.digest = digest;
	}

	private byte[] GenerateDerivedKey()
	{
		byte[] digestBytes = new byte[digest.GetDigestSize()];
		digest.BlockUpdate(mPassword, 0, mPassword.Length);
		digest.BlockUpdate(mSalt, 0, mSalt.Length);
		digest.DoFinal(digestBytes, 0);
		for (int i = 1; i < mIterationCount; i++)
		{
			digest.BlockUpdate(digestBytes, 0, digestBytes.Length);
			digest.DoFinal(digestBytes, 0);
		}
		return digestBytes;
	}

	public override ICipherParameters GenerateDerivedParameters(int keySize)
	{
		return GenerateDerivedMacParameters(keySize);
	}

	public override ICipherParameters GenerateDerivedParameters(string algorithm, int keySize)
	{
		keySize /= 8;
		if (keySize > digest.GetDigestSize())
		{
			throw new ArgumentException("Can't Generate a derived key " + keySize + " bytes long.");
		}
		byte[] dKey = GenerateDerivedKey();
		return ParameterUtilities.CreateKeyParameter(algorithm, dKey, 0, keySize);
	}

	public override ICipherParameters GenerateDerivedParameters(int keySize, int ivSize)
	{
		keySize /= 8;
		ivSize /= 8;
		if (keySize + ivSize > digest.GetDigestSize())
		{
			throw new ArgumentException("Can't Generate a derived key " + (keySize + ivSize) + " bytes long.");
		}
		byte[] dKey = GenerateDerivedKey();
		return new ParametersWithIV(new KeyParameter(dKey, 0, keySize), dKey, keySize, ivSize);
	}

	public override ICipherParameters GenerateDerivedParameters(string algorithm, int keySize, int ivSize)
	{
		keySize /= 8;
		ivSize /= 8;
		if (keySize + ivSize > digest.GetDigestSize())
		{
			throw new ArgumentException("Can't Generate a derived key " + (keySize + ivSize) + " bytes long.");
		}
		byte[] dKey = GenerateDerivedKey();
		return new ParametersWithIV(ParameterUtilities.CreateKeyParameter(algorithm, dKey, 0, keySize), dKey, keySize, ivSize);
	}

	public override ICipherParameters GenerateDerivedMacParameters(int keySize)
	{
		keySize /= 8;
		if (keySize > digest.GetDigestSize())
		{
			throw new ArgumentException("Can't Generate a derived key " + keySize + " bytes long.");
		}
		return new KeyParameter(GenerateDerivedKey(), 0, keySize);
	}
}
