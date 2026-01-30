using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Utilities;

namespace Org.BouncyCastle.Crypto.Agreement.Kdf;

public class ConcatenationKdfGenerator : IDerivationFunction
{
	private readonly IDigest mDigest;

	private byte[] mShared;

	private byte[] mOtherInfo;

	private int mHLen;

	public virtual IDigest Digest => mDigest;

	public ConcatenationKdfGenerator(IDigest digest)
	{
		mDigest = digest;
		mHLen = digest.GetDigestSize();
	}

	public virtual void Init(IDerivationParameters param)
	{
		if (!(param is KdfParameters))
		{
			throw new ArgumentException("KDF parameters required for ConcatenationKdfGenerator");
		}
		KdfParameters p = (KdfParameters)param;
		mShared = p.GetSharedSecret();
		mOtherInfo = p.GetIV();
	}

	public virtual int GenerateBytes(byte[] outBytes, int outOff, int len)
	{
		if (outBytes.Length - len < outOff)
		{
			throw new DataLengthException("output buffer too small");
		}
		byte[] hashBuf = new byte[mHLen];
		byte[] C = new byte[4];
		uint counter = 1u;
		int outputLen = 0;
		mDigest.Reset();
		if (len > mHLen)
		{
			do
			{
				Pack.UInt32_To_BE(counter, C);
				mDigest.BlockUpdate(C, 0, C.Length);
				mDigest.BlockUpdate(mShared, 0, mShared.Length);
				mDigest.BlockUpdate(mOtherInfo, 0, mOtherInfo.Length);
				mDigest.DoFinal(hashBuf, 0);
				Array.Copy(hashBuf, 0, outBytes, outOff + outputLen, mHLen);
				outputLen += mHLen;
			}
			while (counter++ < len / mHLen);
		}
		if (outputLen < len)
		{
			Pack.UInt32_To_BE(counter, C);
			mDigest.BlockUpdate(C, 0, C.Length);
			mDigest.BlockUpdate(mShared, 0, mShared.Length);
			mDigest.BlockUpdate(mOtherInfo, 0, mOtherInfo.Length);
			mDigest.DoFinal(hashBuf, 0);
			Array.Copy(hashBuf, 0, outBytes, outOff + outputLen, len - outputLen);
		}
		return len;
	}
}
