using System;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC;
using Org.BouncyCastle.Math.EC.Multiplier;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Engines;

public class SM2Engine
{
	private readonly IDigest mDigest;

	private bool mForEncryption;

	private ECKeyParameters mECKey;

	private ECDomainParameters mECParams;

	private int mCurveLength;

	private SecureRandom mRandom;

	public SM2Engine()
		: this(new SM3Digest())
	{
	}

	public SM2Engine(IDigest digest)
	{
		mDigest = digest;
	}

	public virtual void Init(bool forEncryption, ICipherParameters param)
	{
		mForEncryption = forEncryption;
		if (forEncryption)
		{
			ParametersWithRandom rParam = (ParametersWithRandom)param;
			mECKey = (ECKeyParameters)rParam.Parameters;
			mECParams = mECKey.Parameters;
			if (((ECPublicKeyParameters)mECKey).Q.Multiply(mECParams.H).IsInfinity)
			{
				throw new ArgumentException("invalid key: [h]Q at infinity");
			}
			mRandom = rParam.Random;
		}
		else
		{
			mECKey = (ECKeyParameters)param;
			mECParams = mECKey.Parameters;
		}
		mCurveLength = (mECParams.Curve.FieldSize + 7) / 8;
	}

	public virtual byte[] ProcessBlock(byte[] input, int inOff, int inLen)
	{
		if (mForEncryption)
		{
			return Encrypt(input, inOff, inLen);
		}
		return Decrypt(input, inOff, inLen);
	}

	protected virtual ECMultiplier CreateBasePointMultiplier()
	{
		return new FixedPointCombMultiplier();
	}

	private byte[] Encrypt(byte[] input, int inOff, int inLen)
	{
		byte[] c2 = new byte[inLen];
		Array.Copy(input, inOff, c2, 0, c2.Length);
		ECMultiplier multiplier = CreateBasePointMultiplier();
		byte[] c3;
		ECPoint kPB;
		do
		{
			BigInteger k = NextK();
			c3 = multiplier.Multiply(mECParams.G, k).Normalize().GetEncoded(compressed: false);
			kPB = ((ECPublicKeyParameters)mECKey).Q.Multiply(k).Normalize();
			Kdf(mDigest, kPB, c2);
		}
		while (NotEncrypted(c2, input, inOff));
		AddFieldElement(mDigest, kPB.AffineXCoord);
		mDigest.BlockUpdate(input, inOff, inLen);
		AddFieldElement(mDigest, kPB.AffineYCoord);
		byte[] c4 = DigestUtilities.DoFinal(mDigest);
		return Arrays.ConcatenateAll(c3, c2, c4);
	}

	private byte[] Decrypt(byte[] input, int inOff, int inLen)
	{
		byte[] c1 = new byte[mCurveLength * 2 + 1];
		Array.Copy(input, inOff, c1, 0, c1.Length);
		ECPoint c1P = mECParams.Curve.DecodePoint(c1);
		if (c1P.Multiply(mECParams.H).IsInfinity)
		{
			throw new InvalidCipherTextException("[h]C1 at infinity");
		}
		c1P = c1P.Multiply(((ECPrivateKeyParameters)mECKey).D).Normalize();
		byte[] c2 = new byte[inLen - c1.Length - mDigest.GetDigestSize()];
		Array.Copy(input, inOff + c1.Length, c2, 0, c2.Length);
		Kdf(mDigest, c1P, c2);
		AddFieldElement(mDigest, c1P.AffineXCoord);
		mDigest.BlockUpdate(c2, 0, c2.Length);
		AddFieldElement(mDigest, c1P.AffineYCoord);
		byte[] c3 = DigestUtilities.DoFinal(mDigest);
		int check = 0;
		for (int i = 0; i != c3.Length; i++)
		{
			check |= c3[i] ^ input[inOff + c1.Length + c2.Length + i];
		}
		Arrays.Fill(c1, 0);
		Arrays.Fill(c3, 0);
		if (check != 0)
		{
			Arrays.Fill(c2, 0);
			throw new InvalidCipherTextException("invalid cipher text");
		}
		return c2;
	}

	private bool NotEncrypted(byte[] encData, byte[] input, int inOff)
	{
		for (int i = 0; i != encData.Length; i++)
		{
			if (encData[i] != input[inOff + i])
			{
				return false;
			}
		}
		return true;
	}

	private void Kdf(IDigest digest, ECPoint c1, byte[] encData)
	{
		int digestSize = digest.GetDigestSize();
		byte[] buf = new byte[System.Math.Max(4, digestSize)];
		int off = 0;
		IMemoable memo = digest as IMemoable;
		IMemoable copy = null;
		if (memo != null)
		{
			AddFieldElement(digest, c1.AffineXCoord);
			AddFieldElement(digest, c1.AffineYCoord);
			copy = memo.Copy();
		}
		uint ct = 0u;
		int xorLen;
		for (; off < encData.Length; off += xorLen)
		{
			if (memo != null)
			{
				memo.Reset(copy);
			}
			else
			{
				AddFieldElement(digest, c1.AffineXCoord);
				AddFieldElement(digest, c1.AffineYCoord);
			}
			Pack.UInt32_To_BE(++ct, buf, 0);
			digest.BlockUpdate(buf, 0, 4);
			digest.DoFinal(buf, 0);
			xorLen = System.Math.Min(digestSize, encData.Length - off);
			Xor(encData, buf, off, xorLen);
		}
	}

	private void Xor(byte[] data, byte[] kdfOut, int dOff, int dRemaining)
	{
		for (int i = 0; i != dRemaining; i++)
		{
			data[dOff + i] ^= kdfOut[i];
		}
	}

	private BigInteger NextK()
	{
		int qBitLength = mECParams.N.BitLength;
		BigInteger k;
		do
		{
			k = new BigInteger(qBitLength, mRandom);
		}
		while (k.SignValue == 0 || k.CompareTo(mECParams.N) >= 0);
		return k;
	}

	private void AddFieldElement(IDigest digest, ECFieldElement v)
	{
		byte[] p = v.GetEncoded();
		digest.BlockUpdate(p, 0, p.Length);
	}
}
