using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Utilities;

namespace Org.BouncyCastle.Crypto.Generators;

public class BaseKdfBytesGenerator : IDerivationFunction
{
	private int counterStart;

	private IDigest digest;

	private byte[] shared;

	private byte[] iv;

	public virtual IDigest Digest => digest;

	public BaseKdfBytesGenerator(int counterStart, IDigest digest)
	{
		this.counterStart = counterStart;
		this.digest = digest;
	}

	public virtual void Init(IDerivationParameters parameters)
	{
		if (parameters is KdfParameters)
		{
			KdfParameters p = (KdfParameters)parameters;
			shared = p.GetSharedSecret();
			iv = p.GetIV();
			return;
		}
		if (parameters is Iso18033KdfParameters)
		{
			Iso18033KdfParameters p2 = (Iso18033KdfParameters)parameters;
			shared = p2.GetSeed();
			iv = null;
			return;
		}
		throw new ArgumentException("KDF parameters required for KDF Generator");
	}

	public virtual int GenerateBytes(byte[] output, int outOff, int length)
	{
		if (output.Length - length < outOff)
		{
			throw new DataLengthException("output buffer too small");
		}
		long oBytes = length;
		int outLen = digest.GetDigestSize();
		if (oBytes > 8589934591L)
		{
			throw new ArgumentException("Output length too large");
		}
		int cThreshold = (int)((oBytes + outLen - 1) / outLen);
		byte[] dig = new byte[digest.GetDigestSize()];
		byte[] C = new byte[4];
		Pack.UInt32_To_BE((uint)counterStart, C, 0);
		uint counterBase = (uint)(counterStart & -256);
		for (int i = 0; i < cThreshold; i++)
		{
			digest.BlockUpdate(shared, 0, shared.Length);
			digest.BlockUpdate(C, 0, 4);
			if (iv != null)
			{
				digest.BlockUpdate(iv, 0, iv.Length);
			}
			digest.DoFinal(dig, 0);
			if (length > outLen)
			{
				Array.Copy(dig, 0, output, outOff, outLen);
				outOff += outLen;
				length -= outLen;
			}
			else
			{
				Array.Copy(dig, 0, output, outOff, length);
			}
			if (++C[3] == 0)
			{
				counterBase += 256;
				Pack.UInt32_To_BE(counterBase, C, 0);
			}
		}
		digest.Reset();
		return (int)oBytes;
	}
}
