using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Signers;

public class Iso9796d2PssSigner : ISignerWithRecovery, ISigner
{
	[Obsolete("Use 'IsoTrailers' instead")]
	public const int TrailerImplicit = 188;

	[Obsolete("Use 'IsoTrailers' instead")]
	public const int TrailerRipeMD160 = 12748;

	[Obsolete("Use 'IsoTrailers' instead")]
	public const int TrailerRipeMD128 = 13004;

	[Obsolete("Use 'IsoTrailers' instead")]
	public const int TrailerSha1 = 13260;

	[Obsolete("Use 'IsoTrailers' instead")]
	public const int TrailerSha256 = 13516;

	[Obsolete("Use 'IsoTrailers' instead")]
	public const int TrailerSha512 = 13772;

	[Obsolete("Use 'IsoTrailers' instead")]
	public const int TrailerSha384 = 14028;

	[Obsolete("Use 'IsoTrailers' instead")]
	public const int TrailerWhirlpool = 14284;

	private IDigest digest;

	private IAsymmetricBlockCipher cipher;

	private SecureRandom random;

	private byte[] standardSalt;

	private int hLen;

	private int trailer;

	private int keyBits;

	private byte[] block;

	private byte[] mBuf;

	private int messageLength;

	private readonly int saltLength;

	private bool fullMessage;

	private byte[] recoveredMessage;

	private byte[] preSig;

	private byte[] preBlock;

	private int preMStart;

	private int preTLength;

	public virtual string AlgorithmName => digest.AlgorithmName + "withISO9796-2S2";

	public byte[] GetRecoveredMessage()
	{
		return recoveredMessage;
	}

	public Iso9796d2PssSigner(IAsymmetricBlockCipher cipher, IDigest digest, int saltLength, bool isImplicit)
	{
		this.cipher = cipher;
		this.digest = digest;
		hLen = digest.GetDigestSize();
		this.saltLength = saltLength;
		if (isImplicit)
		{
			trailer = 188;
			return;
		}
		if (IsoTrailers.NoTrailerAvailable(digest))
		{
			throw new ArgumentException("no valid trailer", "digest");
		}
		trailer = IsoTrailers.GetTrailer(digest);
	}

	public Iso9796d2PssSigner(IAsymmetricBlockCipher cipher, IDigest digest, int saltLength)
		: this(cipher, digest, saltLength, isImplicit: false)
	{
	}

	public virtual void Init(bool forSigning, ICipherParameters parameters)
	{
		RsaKeyParameters kParam;
		if (parameters is ParametersWithRandom)
		{
			ParametersWithRandom p = (ParametersWithRandom)parameters;
			kParam = (RsaKeyParameters)p.Parameters;
			if (forSigning)
			{
				random = p.Random;
			}
		}
		else if (parameters is ParametersWithSalt)
		{
			if (!forSigning)
			{
				throw new ArgumentException("ParametersWithSalt only valid for signing", "parameters");
			}
			ParametersWithSalt p2 = (ParametersWithSalt)parameters;
			kParam = (RsaKeyParameters)p2.Parameters;
			standardSalt = p2.GetSalt();
			if (standardSalt.Length != saltLength)
			{
				throw new ArgumentException("Fixed salt is of wrong length");
			}
		}
		else
		{
			kParam = (RsaKeyParameters)parameters;
			if (forSigning)
			{
				random = new SecureRandom();
			}
		}
		cipher.Init(forSigning, kParam);
		keyBits = kParam.Modulus.BitLength;
		block = new byte[(keyBits + 7) / 8];
		if (trailer == 188)
		{
			mBuf = new byte[block.Length - digest.GetDigestSize() - saltLength - 1 - 1];
		}
		else
		{
			mBuf = new byte[block.Length - digest.GetDigestSize() - saltLength - 1 - 2];
		}
		Reset();
	}

	private bool IsSameAs(byte[] a, byte[] b)
	{
		if (messageLength != b.Length)
		{
			return false;
		}
		bool isOkay = true;
		for (int i = 0; i != b.Length; i++)
		{
			if (a[i] != b[i])
			{
				isOkay = false;
			}
		}
		return isOkay;
	}

	private void ClearBlock(byte[] block)
	{
		Array.Clear(block, 0, block.Length);
	}

	public virtual void UpdateWithRecoveredMessage(byte[] signature)
	{
		byte[] block = cipher.ProcessBlock(signature, 0, signature.Length);
		if (block.Length < (keyBits + 7) / 8)
		{
			byte[] tmp = new byte[(keyBits + 7) / 8];
			Array.Copy(block, 0, tmp, tmp.Length - block.Length, block.Length);
			ClearBlock(block);
			block = tmp;
		}
		int tLength;
		if (((block[block.Length - 1] & 0xFF) ^ 0xBC) == 0)
		{
			tLength = 1;
		}
		else
		{
			int sigTrail = ((block[block.Length - 2] & 0xFF) << 8) | (block[block.Length - 1] & 0xFF);
			if (IsoTrailers.NoTrailerAvailable(digest))
			{
				throw new ArgumentException("unrecognised hash in signature");
			}
			if (sigTrail != IsoTrailers.GetTrailer(digest))
			{
				throw new InvalidOperationException("signer initialised with wrong digest for trailer " + sigTrail);
			}
			tLength = 2;
		}
		byte[] m2Hash = new byte[hLen];
		digest.DoFinal(m2Hash, 0);
		byte[] dbMask = MaskGeneratorFunction1(block, block.Length - hLen - tLength, hLen, block.Length - hLen - tLength);
		for (int i = 0; i != dbMask.Length; i++)
		{
			block[i] ^= dbMask[i];
		}
		block[0] &= 127;
		int mStart = 0;
		while (mStart < block.Length && block[mStart++] != 1)
		{
		}
		if (mStart >= block.Length)
		{
			ClearBlock(block);
		}
		fullMessage = mStart > 1;
		recoveredMessage = new byte[dbMask.Length - mStart - saltLength];
		Array.Copy(block, mStart, recoveredMessage, 0, recoveredMessage.Length);
		recoveredMessage.CopyTo(mBuf, 0);
		preSig = signature;
		preBlock = block;
		preMStart = mStart;
		preTLength = tLength;
	}

	public virtual void Update(byte input)
	{
		if (preSig == null && messageLength < mBuf.Length)
		{
			mBuf[messageLength++] = input;
		}
		else
		{
			digest.Update(input);
		}
	}

	public virtual void BlockUpdate(byte[] input, int inOff, int length)
	{
		if (preSig == null)
		{
			while (length > 0 && messageLength < mBuf.Length)
			{
				Update(input[inOff]);
				inOff++;
				length--;
			}
		}
		if (length > 0)
		{
			digest.BlockUpdate(input, inOff, length);
		}
	}

	public virtual void Reset()
	{
		digest.Reset();
		messageLength = 0;
		if (mBuf != null)
		{
			ClearBlock(mBuf);
		}
		if (recoveredMessage != null)
		{
			ClearBlock(recoveredMessage);
			recoveredMessage = null;
		}
		fullMessage = false;
		if (preSig != null)
		{
			preSig = null;
			ClearBlock(preBlock);
			preBlock = null;
		}
	}

	public virtual byte[] GenerateSignature()
	{
		byte[] m2Hash = new byte[digest.GetDigestSize()];
		digest.DoFinal(m2Hash, 0);
		byte[] C = new byte[8];
		LtoOSP(messageLength * 8, C);
		digest.BlockUpdate(C, 0, C.Length);
		digest.BlockUpdate(mBuf, 0, messageLength);
		digest.BlockUpdate(m2Hash, 0, m2Hash.Length);
		byte[] salt;
		if (standardSalt != null)
		{
			salt = standardSalt;
		}
		else
		{
			salt = new byte[saltLength];
			random.NextBytes(salt);
		}
		digest.BlockUpdate(salt, 0, salt.Length);
		byte[] hash = new byte[digest.GetDigestSize()];
		digest.DoFinal(hash, 0);
		int tLength = 2;
		if (trailer == 188)
		{
			tLength = 1;
		}
		int off = block.Length - messageLength - salt.Length - hLen - tLength - 1;
		block[off] = 1;
		Array.Copy(mBuf, 0, block, off + 1, messageLength);
		Array.Copy(salt, 0, block, off + 1 + messageLength, salt.Length);
		byte[] dbMask = MaskGeneratorFunction1(hash, 0, hash.Length, block.Length - hLen - tLength);
		for (int i = 0; i != dbMask.Length; i++)
		{
			block[i] ^= dbMask[i];
		}
		Array.Copy(hash, 0, block, block.Length - hLen - tLength, hLen);
		if (trailer == 188)
		{
			block[block.Length - 1] = 188;
		}
		else
		{
			block[block.Length - 2] = (byte)((uint)trailer >> 8);
			block[block.Length - 1] = (byte)trailer;
		}
		block[0] &= 127;
		byte[] result = cipher.ProcessBlock(block, 0, block.Length);
		ClearBlock(mBuf);
		ClearBlock(block);
		messageLength = 0;
		return result;
	}

	public virtual bool VerifySignature(byte[] signature)
	{
		byte[] m2Hash = new byte[hLen];
		digest.DoFinal(m2Hash, 0);
		int mStart = 0;
		if (preSig == null)
		{
			try
			{
				UpdateWithRecoveredMessage(signature);
			}
			catch (Exception)
			{
				return false;
			}
		}
		else if (!Arrays.AreEqual(preSig, signature))
		{
			throw new InvalidOperationException("UpdateWithRecoveredMessage called on different signature");
		}
		byte[] block = preBlock;
		mStart = preMStart;
		int tLength = preTLength;
		preSig = null;
		preBlock = null;
		byte[] C = new byte[8];
		LtoOSP(recoveredMessage.Length * 8, C);
		digest.BlockUpdate(C, 0, C.Length);
		if (recoveredMessage.Length != 0)
		{
			digest.BlockUpdate(recoveredMessage, 0, recoveredMessage.Length);
		}
		digest.BlockUpdate(m2Hash, 0, m2Hash.Length);
		if (standardSalt != null)
		{
			digest.BlockUpdate(standardSalt, 0, standardSalt.Length);
		}
		else
		{
			digest.BlockUpdate(block, mStart + recoveredMessage.Length, saltLength);
		}
		byte[] hash = new byte[digest.GetDigestSize()];
		digest.DoFinal(hash, 0);
		int off = block.Length - tLength - hash.Length;
		bool isOkay = true;
		for (int i = 0; i != hash.Length; i++)
		{
			if (hash[i] != block[off + i])
			{
				isOkay = false;
			}
		}
		ClearBlock(block);
		ClearBlock(hash);
		if (!isOkay)
		{
			fullMessage = false;
			messageLength = 0;
			ClearBlock(recoveredMessage);
			return false;
		}
		if (messageLength != 0 && !IsSameAs(mBuf, recoveredMessage))
		{
			messageLength = 0;
			ClearBlock(mBuf);
			return false;
		}
		messageLength = 0;
		ClearBlock(mBuf);
		return true;
	}

	public virtual bool HasFullMessage()
	{
		return fullMessage;
	}

	private void ItoOSP(int i, byte[] sp)
	{
		sp[0] = (byte)((uint)i >> 24);
		sp[1] = (byte)((uint)i >> 16);
		sp[2] = (byte)((uint)i >> 8);
		sp[3] = (byte)i;
	}

	private void LtoOSP(long l, byte[] sp)
	{
		sp[0] = (byte)((ulong)l >> 56);
		sp[1] = (byte)((ulong)l >> 48);
		sp[2] = (byte)((ulong)l >> 40);
		sp[3] = (byte)((ulong)l >> 32);
		sp[4] = (byte)((ulong)l >> 24);
		sp[5] = (byte)((ulong)l >> 16);
		sp[6] = (byte)((ulong)l >> 8);
		sp[7] = (byte)l;
	}

	private byte[] MaskGeneratorFunction1(byte[] Z, int zOff, int zLen, int length)
	{
		byte[] mask = new byte[length];
		byte[] hashBuf = new byte[hLen];
		byte[] C = new byte[4];
		int counter = 0;
		digest.Reset();
		do
		{
			ItoOSP(counter, C);
			digest.BlockUpdate(Z, zOff, zLen);
			digest.BlockUpdate(C, 0, C.Length);
			digest.DoFinal(hashBuf, 0);
			Array.Copy(hashBuf, 0, mask, counter * hLen, hLen);
		}
		while (++counter < length / hLen);
		if (counter * hLen < length)
		{
			ItoOSP(counter, C);
			digest.BlockUpdate(Z, zOff, zLen);
			digest.BlockUpdate(C, 0, C.Length);
			digest.DoFinal(hashBuf, 0);
			Array.Copy(hashBuf, 0, mask, counter * hLen, mask.Length - counter * hLen);
		}
		return mask;
	}
}
