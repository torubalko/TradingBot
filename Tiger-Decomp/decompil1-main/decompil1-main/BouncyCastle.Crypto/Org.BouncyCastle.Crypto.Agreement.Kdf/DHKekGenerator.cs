using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Crypto.Utilities;

namespace Org.BouncyCastle.Crypto.Agreement.Kdf;

public class DHKekGenerator : IDerivationFunction
{
	private readonly IDigest digest;

	private DerObjectIdentifier algorithm;

	private int keySize;

	private byte[] z;

	private byte[] partyAInfo;

	public virtual IDigest Digest => digest;

	public DHKekGenerator(IDigest digest)
	{
		this.digest = digest;
	}

	public virtual void Init(IDerivationParameters param)
	{
		DHKdfParameters parameters = (DHKdfParameters)param;
		algorithm = parameters.Algorithm;
		keySize = parameters.KeySize;
		z = parameters.GetZ();
		partyAInfo = parameters.GetExtraInfo();
	}

	public virtual int GenerateBytes(byte[] outBytes, int outOff, int len)
	{
		if (outBytes.Length - len < outOff)
		{
			throw new DataLengthException("output buffer too small");
		}
		long oBytes = len;
		int outLen = digest.GetDigestSize();
		if (oBytes > 8589934591L)
		{
			throw new ArgumentException("Output length too large");
		}
		int cThreshold = (int)((oBytes + outLen - 1) / outLen);
		byte[] dig = new byte[digest.GetDigestSize()];
		uint counter = 1u;
		for (int i = 0; i < cThreshold; i++)
		{
			digest.BlockUpdate(z, 0, z.Length);
			DerSequence keyInfo = new DerSequence(algorithm, new DerOctetString(Pack.UInt32_To_BE(counter)));
			Asn1EncodableVector v1 = new Asn1EncodableVector(keyInfo);
			if (partyAInfo != null)
			{
				v1.Add(new DerTaggedObject(explicitly: true, 0, new DerOctetString(partyAInfo)));
			}
			v1.Add(new DerTaggedObject(explicitly: true, 2, new DerOctetString(Pack.UInt32_To_BE((uint)keySize))));
			byte[] other = new DerSequence(v1).GetDerEncoded();
			digest.BlockUpdate(other, 0, other.Length);
			digest.DoFinal(dig, 0);
			if (len > outLen)
			{
				Array.Copy(dig, 0, outBytes, outOff, outLen);
				outOff += outLen;
				len -= outLen;
			}
			else
			{
				Array.Copy(dig, 0, outBytes, outOff, len);
			}
			counter++;
		}
		digest.Reset();
		return (int)oBytes;
	}
}
