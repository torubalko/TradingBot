using System;
using Org.BouncyCastle.Crypto.Parameters;

namespace Org.BouncyCastle.Crypto.Generators;

public class Mgf1BytesGenerator : IDerivationFunction
{
	private IDigest digest;

	private byte[] seed;

	private int hLen;

	public IDigest Digest => digest;

	public Mgf1BytesGenerator(IDigest digest)
	{
		this.digest = digest;
		hLen = digest.GetDigestSize();
	}

	public void Init(IDerivationParameters parameters)
	{
		if (!typeof(MgfParameters).IsInstanceOfType(parameters))
		{
			throw new ArgumentException("MGF parameters required for MGF1Generator");
		}
		MgfParameters p = (MgfParameters)parameters;
		seed = p.GetSeed();
	}

	private void ItoOSP(int i, byte[] sp)
	{
		sp[0] = (byte)((uint)i >> 24);
		sp[1] = (byte)((uint)i >> 16);
		sp[2] = (byte)((uint)i >> 8);
		sp[3] = (byte)i;
	}

	public int GenerateBytes(byte[] output, int outOff, int length)
	{
		if (output.Length - length < outOff)
		{
			throw new DataLengthException("output buffer too small");
		}
		byte[] hashBuf = new byte[hLen];
		byte[] C = new byte[4];
		int counter = 0;
		digest.Reset();
		if (length > hLen)
		{
			do
			{
				ItoOSP(counter, C);
				digest.BlockUpdate(seed, 0, seed.Length);
				digest.BlockUpdate(C, 0, C.Length);
				digest.DoFinal(hashBuf, 0);
				Array.Copy(hashBuf, 0, output, outOff + counter * hLen, hLen);
			}
			while (++counter < length / hLen);
		}
		if (counter * hLen < length)
		{
			ItoOSP(counter, C);
			digest.BlockUpdate(seed, 0, seed.Length);
			digest.BlockUpdate(C, 0, C.Length);
			digest.DoFinal(hashBuf, 0);
			Array.Copy(hashBuf, 0, output, outOff + counter * hLen, length - counter * hLen);
		}
		return length;
	}
}
