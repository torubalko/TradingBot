using System;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Signers;

public class PssSigner : ISigner
{
	public const byte TrailerImplicit = 188;

	private readonly IDigest contentDigest1;

	private readonly IDigest contentDigest2;

	private readonly IDigest mgfDigest;

	private readonly IAsymmetricBlockCipher cipher;

	private SecureRandom random;

	private int hLen;

	private int mgfhLen;

	private int sLen;

	private bool sSet;

	private int emBits;

	private byte[] salt;

	private byte[] mDash;

	private byte[] block;

	private byte trailer;

	public virtual string AlgorithmName => mgfDigest.AlgorithmName + "withRSAandMGF1";

	public static PssSigner CreateRawSigner(IAsymmetricBlockCipher cipher, IDigest digest)
	{
		return new PssSigner(cipher, new NullDigest(), digest, digest, digest.GetDigestSize(), null, 188);
	}

	public static PssSigner CreateRawSigner(IAsymmetricBlockCipher cipher, IDigest contentDigest, IDigest mgfDigest, int saltLen, byte trailer)
	{
		return new PssSigner(cipher, new NullDigest(), contentDigest, mgfDigest, saltLen, null, trailer);
	}

	public PssSigner(IAsymmetricBlockCipher cipher, IDigest digest)
		: this(cipher, digest, digest.GetDigestSize())
	{
	}

	public PssSigner(IAsymmetricBlockCipher cipher, IDigest digest, int saltLen)
		: this(cipher, digest, saltLen, 188)
	{
	}

	public PssSigner(IAsymmetricBlockCipher cipher, IDigest digest, byte[] salt)
		: this(cipher, digest, digest, digest, salt.Length, salt, 188)
	{
	}

	public PssSigner(IAsymmetricBlockCipher cipher, IDigest contentDigest, IDigest mgfDigest, int saltLen)
		: this(cipher, contentDigest, mgfDigest, saltLen, 188)
	{
	}

	public PssSigner(IAsymmetricBlockCipher cipher, IDigest contentDigest, IDigest mgfDigest, byte[] salt)
		: this(cipher, contentDigest, contentDigest, mgfDigest, salt.Length, salt, 188)
	{
	}

	public PssSigner(IAsymmetricBlockCipher cipher, IDigest digest, int saltLen, byte trailer)
		: this(cipher, digest, digest, saltLen, trailer)
	{
	}

	public PssSigner(IAsymmetricBlockCipher cipher, IDigest contentDigest, IDigest mgfDigest, int saltLen, byte trailer)
		: this(cipher, contentDigest, contentDigest, mgfDigest, saltLen, null, trailer)
	{
	}

	private PssSigner(IAsymmetricBlockCipher cipher, IDigest contentDigest1, IDigest contentDigest2, IDigest mgfDigest, int saltLen, byte[] salt, byte trailer)
	{
		this.cipher = cipher;
		this.contentDigest1 = contentDigest1;
		this.contentDigest2 = contentDigest2;
		this.mgfDigest = mgfDigest;
		hLen = contentDigest2.GetDigestSize();
		mgfhLen = mgfDigest.GetDigestSize();
		sLen = saltLen;
		sSet = salt != null;
		if (sSet)
		{
			this.salt = salt;
		}
		else
		{
			this.salt = new byte[saltLen];
		}
		mDash = new byte[8 + saltLen + hLen];
		this.trailer = trailer;
	}

	public virtual void Init(bool forSigning, ICipherParameters parameters)
	{
		if (parameters is ParametersWithRandom)
		{
			ParametersWithRandom p = (ParametersWithRandom)parameters;
			parameters = p.Parameters;
			random = p.Random;
		}
		else if (forSigning)
		{
			random = new SecureRandom();
		}
		cipher.Init(forSigning, parameters);
		RsaKeyParameters kParam = ((!(parameters is RsaBlindingParameters)) ? ((RsaKeyParameters)parameters) : ((RsaBlindingParameters)parameters).PublicKey);
		emBits = kParam.Modulus.BitLength - 1;
		if (emBits < 8 * hLen + 8 * sLen + 9)
		{
			throw new ArgumentException("key too small for specified hash and salt lengths");
		}
		block = new byte[(emBits + 7) / 8];
	}

	private void ClearBlock(byte[] block)
	{
		Array.Clear(block, 0, block.Length);
	}

	public virtual void Update(byte input)
	{
		contentDigest1.Update(input);
	}

	public virtual void BlockUpdate(byte[] input, int inOff, int length)
	{
		contentDigest1.BlockUpdate(input, inOff, length);
	}

	public virtual void Reset()
	{
		contentDigest1.Reset();
	}

	public virtual byte[] GenerateSignature()
	{
		contentDigest1.DoFinal(mDash, mDash.Length - hLen - sLen);
		if (sLen != 0)
		{
			if (!sSet)
			{
				random.NextBytes(salt);
			}
			salt.CopyTo(mDash, mDash.Length - sLen);
		}
		byte[] h = new byte[hLen];
		contentDigest2.BlockUpdate(mDash, 0, mDash.Length);
		contentDigest2.DoFinal(h, 0);
		block[block.Length - sLen - 1 - hLen - 1] = 1;
		salt.CopyTo(block, block.Length - sLen - hLen - 1);
		byte[] dbMask = MaskGeneratorFunction(h, 0, h.Length, block.Length - hLen - 1);
		for (int i = 0; i != dbMask.Length; i++)
		{
			block[i] ^= dbMask[i];
		}
		h.CopyTo(block, block.Length - hLen - 1);
		uint firstByteMask = 255u >> block.Length * 8 - emBits;
		block[0] &= (byte)firstByteMask;
		block[block.Length - 1] = trailer;
		byte[] result = cipher.ProcessBlock(block, 0, block.Length);
		ClearBlock(block);
		return result;
	}

	public virtual bool VerifySignature(byte[] signature)
	{
		contentDigest1.DoFinal(mDash, mDash.Length - hLen - sLen);
		byte[] b = cipher.ProcessBlock(signature, 0, signature.Length);
		Arrays.Fill(block, 0, block.Length - b.Length, 0);
		b.CopyTo(block, block.Length - b.Length);
		uint firstByteMask = 255u >> block.Length * 8 - emBits;
		if (block[0] != (byte)(block[0] & firstByteMask) || block[block.Length - 1] != trailer)
		{
			ClearBlock(block);
			return false;
		}
		byte[] dbMask = MaskGeneratorFunction(block, block.Length - hLen - 1, hLen, block.Length - hLen - 1);
		for (int i = 0; i != dbMask.Length; i++)
		{
			block[i] ^= dbMask[i];
		}
		block[0] &= (byte)firstByteMask;
		for (int j = 0; j != block.Length - hLen - sLen - 2; j++)
		{
			if (block[j] != 0)
			{
				ClearBlock(block);
				return false;
			}
		}
		if (block[block.Length - hLen - sLen - 2] != 1)
		{
			ClearBlock(block);
			return false;
		}
		if (sSet)
		{
			Array.Copy(salt, 0, mDash, mDash.Length - sLen, sLen);
		}
		else
		{
			Array.Copy(block, block.Length - sLen - hLen - 1, mDash, mDash.Length - sLen, sLen);
		}
		contentDigest2.BlockUpdate(mDash, 0, mDash.Length);
		contentDigest2.DoFinal(mDash, mDash.Length - hLen);
		int i2 = block.Length - hLen - 1;
		for (int k = mDash.Length - hLen; k != mDash.Length; k++)
		{
			if ((block[i2] ^ mDash[k]) != 0)
			{
				ClearBlock(mDash);
				ClearBlock(block);
				return false;
			}
			i2++;
		}
		ClearBlock(mDash);
		ClearBlock(block);
		return true;
	}

	private void ItoOSP(int i, byte[] sp)
	{
		sp[0] = (byte)((uint)i >> 24);
		sp[1] = (byte)((uint)i >> 16);
		sp[2] = (byte)((uint)i >> 8);
		sp[3] = (byte)i;
	}

	private byte[] MaskGeneratorFunction(byte[] Z, int zOff, int zLen, int length)
	{
		if (mgfDigest is IXof)
		{
			byte[] mask = new byte[length];
			mgfDigest.BlockUpdate(Z, zOff, zLen);
			((IXof)mgfDigest).DoFinal(mask, 0, mask.Length);
			return mask;
		}
		return MaskGeneratorFunction1(Z, zOff, zLen, length);
	}

	private byte[] MaskGeneratorFunction1(byte[] Z, int zOff, int zLen, int length)
	{
		byte[] mask = new byte[length];
		byte[] hashBuf = new byte[mgfhLen];
		byte[] C = new byte[4];
		int counter = 0;
		mgfDigest.Reset();
		for (; counter < length / mgfhLen; counter++)
		{
			ItoOSP(counter, C);
			mgfDigest.BlockUpdate(Z, zOff, zLen);
			mgfDigest.BlockUpdate(C, 0, C.Length);
			mgfDigest.DoFinal(hashBuf, 0);
			hashBuf.CopyTo(mask, counter * mgfhLen);
		}
		if (counter * mgfhLen < length)
		{
			ItoOSP(counter, C);
			mgfDigest.BlockUpdate(Z, zOff, zLen);
			mgfDigest.BlockUpdate(C, 0, C.Length);
			mgfDigest.DoFinal(hashBuf, 0);
			Array.Copy(hashBuf, 0, mask, counter * mgfhLen, mask.Length - counter * mgfhLen);
		}
		return mask;
	}
}
