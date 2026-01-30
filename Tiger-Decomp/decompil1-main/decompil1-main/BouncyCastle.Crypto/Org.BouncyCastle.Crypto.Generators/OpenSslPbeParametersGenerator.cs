using System;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Generators;

public class OpenSslPbeParametersGenerator : PbeParametersGenerator
{
	private readonly IDigest digest;

	public OpenSslPbeParametersGenerator()
		: this(new MD5Digest())
	{
	}

	public OpenSslPbeParametersGenerator(IDigest digest)
	{
		this.digest = digest;
	}

	public override void Init(byte[] password, byte[] salt, int iterationCount)
	{
		base.Init(password, salt, 1);
	}

	public virtual void Init(byte[] password, byte[] salt)
	{
		base.Init(password, salt, 1);
	}

	private byte[] GenerateDerivedKey(int bytesNeeded)
	{
		byte[] buf = new byte[digest.GetDigestSize()];
		byte[] key = new byte[bytesNeeded];
		int offset = 0;
		while (true)
		{
			digest.BlockUpdate(mPassword, 0, mPassword.Length);
			digest.BlockUpdate(mSalt, 0, mSalt.Length);
			digest.DoFinal(buf, 0);
			int len = ((bytesNeeded > buf.Length) ? buf.Length : bytesNeeded);
			Array.Copy(buf, 0, key, offset, len);
			offset += len;
			bytesNeeded -= len;
			if (bytesNeeded == 0)
			{
				break;
			}
			digest.Reset();
			digest.BlockUpdate(buf, 0, buf.Length);
		}
		return key;
	}

	[Obsolete("Use version with 'algorithm' parameter")]
	public override ICipherParameters GenerateDerivedParameters(int keySize)
	{
		return GenerateDerivedMacParameters(keySize);
	}

	public override ICipherParameters GenerateDerivedParameters(string algorithm, int keySize)
	{
		keySize /= 8;
		byte[] dKey = GenerateDerivedKey(keySize);
		return ParameterUtilities.CreateKeyParameter(algorithm, dKey, 0, keySize);
	}

	[Obsolete("Use version with 'algorithm' parameter")]
	public override ICipherParameters GenerateDerivedParameters(int keySize, int ivSize)
	{
		keySize /= 8;
		ivSize /= 8;
		byte[] dKey = GenerateDerivedKey(keySize + ivSize);
		return new ParametersWithIV(new KeyParameter(dKey, 0, keySize), dKey, keySize, ivSize);
	}

	public override ICipherParameters GenerateDerivedParameters(string algorithm, int keySize, int ivSize)
	{
		keySize /= 8;
		ivSize /= 8;
		byte[] dKey = GenerateDerivedKey(keySize + ivSize);
		return new ParametersWithIV(ParameterUtilities.CreateKeyParameter(algorithm, dKey, 0, keySize), dKey, keySize, ivSize);
	}

	public override ICipherParameters GenerateDerivedMacParameters(int keySize)
	{
		keySize /= 8;
		return new KeyParameter(GenerateDerivedKey(keySize), 0, keySize);
	}
}
