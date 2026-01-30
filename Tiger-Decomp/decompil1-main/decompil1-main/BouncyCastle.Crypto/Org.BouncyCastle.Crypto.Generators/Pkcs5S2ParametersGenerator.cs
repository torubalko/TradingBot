using System;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Macs;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Generators;

public class Pkcs5S2ParametersGenerator : PbeParametersGenerator
{
	private readonly IMac hMac;

	private readonly byte[] state;

	public Pkcs5S2ParametersGenerator()
		: this(new Sha1Digest())
	{
	}

	public Pkcs5S2ParametersGenerator(IDigest digest)
	{
		hMac = new HMac(digest);
		state = new byte[hMac.GetMacSize()];
	}

	private void F(byte[] S, int c, byte[] iBuf, byte[] outBytes, int outOff)
	{
		if (c == 0)
		{
			throw new ArgumentException("iteration count must be at least 1.");
		}
		if (S != null)
		{
			hMac.BlockUpdate(S, 0, S.Length);
		}
		hMac.BlockUpdate(iBuf, 0, iBuf.Length);
		hMac.DoFinal(state, 0);
		Array.Copy(state, 0, outBytes, outOff, state.Length);
		for (int count = 1; count < c; count++)
		{
			hMac.BlockUpdate(state, 0, state.Length);
			hMac.DoFinal(state, 0);
			for (int j = 0; j < state.Length; j++)
			{
				outBytes[outOff + j] ^= state[j];
			}
		}
	}

	private byte[] GenerateDerivedKey(int dkLen)
	{
		int hLen = hMac.GetMacSize();
		int l = (dkLen + hLen - 1) / hLen;
		byte[] iBuf = new byte[4];
		byte[] outBytes = new byte[l * hLen];
		int outPos = 0;
		ICipherParameters param = new KeyParameter(mPassword);
		hMac.Init(param);
		for (int i = 1; i <= l; i++)
		{
			int pos = 3;
			while (++iBuf[pos] == 0)
			{
				pos--;
			}
			F(mSalt, mIterationCount, iBuf, outBytes, outPos);
			outPos += hLen;
		}
		return outBytes;
	}

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
