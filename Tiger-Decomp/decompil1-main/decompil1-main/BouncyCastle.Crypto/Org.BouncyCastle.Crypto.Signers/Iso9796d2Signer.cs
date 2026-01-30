using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Signers;

public class Iso9796d2Signer : ISignerWithRecovery, ISigner
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

	private int trailer;

	private int keyBits;

	private byte[] block;

	private byte[] mBuf;

	private int messageLength;

	private bool fullMessage;

	private byte[] recoveredMessage;

	private byte[] preSig;

	private byte[] preBlock;

	public virtual string AlgorithmName => digest.AlgorithmName + "withISO9796-2S1";

	public byte[] GetRecoveredMessage()
	{
		return recoveredMessage;
	}

	public Iso9796d2Signer(IAsymmetricBlockCipher cipher, IDigest digest, bool isImplicit)
	{
		this.cipher = cipher;
		this.digest = digest;
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

	public Iso9796d2Signer(IAsymmetricBlockCipher cipher, IDigest digest)
		: this(cipher, digest, isImplicit: false)
	{
	}

	public virtual void Init(bool forSigning, ICipherParameters parameters)
	{
		RsaKeyParameters kParam = (RsaKeyParameters)parameters;
		cipher.Init(forSigning, kParam);
		keyBits = kParam.Modulus.BitLength;
		block = new byte[(keyBits + 7) / 8];
		if (trailer == 188)
		{
			mBuf = new byte[block.Length - digest.GetDigestSize() - 2];
		}
		else
		{
			mBuf = new byte[block.Length - digest.GetDigestSize() - 3];
		}
		Reset();
	}

	private bool IsSameAs(byte[] a, byte[] b)
	{
		int checkLen;
		if (messageLength > mBuf.Length)
		{
			if (mBuf.Length > b.Length)
			{
				return false;
			}
			checkLen = mBuf.Length;
		}
		else
		{
			if (messageLength != b.Length)
			{
				return false;
			}
			checkLen = b.Length;
		}
		bool isOkay = true;
		for (int i = 0; i != checkLen; i++)
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
		if (((block[0] & 0xC0) ^ 0x40) != 0)
		{
			throw new InvalidCipherTextException("malformed signature");
		}
		if (((block[block.Length - 1] & 0xF) ^ 0xC) != 0)
		{
			throw new InvalidCipherTextException("malformed signature");
		}
		int delta = 0;
		if (((block[block.Length - 1] & 0xFF) ^ 0xBC) == 0)
		{
			delta = 1;
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
			delta = 2;
		}
		int mStart = 0;
		for (mStart = 0; mStart != block.Length && ((block[mStart] & 0xF) ^ 0xA) != 0; mStart++)
		{
		}
		mStart++;
		int off = block.Length - delta - digest.GetDigestSize();
		if (off - mStart <= 0)
		{
			throw new InvalidCipherTextException("malformed block");
		}
		if ((block[0] & 0x20) == 0)
		{
			fullMessage = true;
			recoveredMessage = new byte[off - mStart];
			Array.Copy(block, mStart, recoveredMessage, 0, recoveredMessage.Length);
		}
		else
		{
			fullMessage = false;
			recoveredMessage = new byte[off - mStart];
			Array.Copy(block, mStart, recoveredMessage, 0, recoveredMessage.Length);
		}
		preSig = signature;
		preBlock = block;
		digest.BlockUpdate(recoveredMessage, 0, recoveredMessage.Length);
		messageLength = recoveredMessage.Length;
		recoveredMessage.CopyTo(mBuf, 0);
	}

	public virtual void Update(byte input)
	{
		digest.Update(input);
		if (messageLength < mBuf.Length)
		{
			mBuf[messageLength] = input;
		}
		messageLength++;
	}

	public virtual void BlockUpdate(byte[] input, int inOff, int length)
	{
		while (length > 0 && messageLength < mBuf.Length)
		{
			Update(input[inOff]);
			inOff++;
			length--;
		}
		digest.BlockUpdate(input, inOff, length);
		messageLength += length;
	}

	public virtual void Reset()
	{
		digest.Reset();
		messageLength = 0;
		ClearBlock(mBuf);
		if (recoveredMessage != null)
		{
			ClearBlock(recoveredMessage);
		}
		recoveredMessage = null;
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
		int digSize = digest.GetDigestSize();
		int t = 0;
		int delta = 0;
		if (trailer == 188)
		{
			t = 8;
			delta = block.Length - digSize - 1;
			digest.DoFinal(block, delta);
			block[block.Length - 1] = 188;
		}
		else
		{
			t = 16;
			delta = block.Length - digSize - 2;
			digest.DoFinal(block, delta);
			block[block.Length - 2] = (byte)((uint)trailer >> 8);
			block[block.Length - 1] = (byte)trailer;
		}
		byte header = 0;
		int x = (digSize + messageLength) * 8 + t + 4 - keyBits;
		if (x > 0)
		{
			int mR = messageLength - (x + 7) / 8;
			header = 96;
			delta -= mR;
			Array.Copy(mBuf, 0, block, delta, mR);
		}
		else
		{
			header = 64;
			delta -= messageLength;
			Array.Copy(mBuf, 0, block, delta, messageLength);
		}
		if (delta - 1 > 0)
		{
			for (int i = delta - 1; i != 0; i--)
			{
				block[i] = 187;
			}
			block[delta - 1] ^= 1;
			block[0] = 11;
			block[0] |= header;
		}
		else
		{
			block[0] = 10;
			block[0] |= header;
		}
		byte[] result = cipher.ProcessBlock(block, 0, block.Length);
		messageLength = 0;
		ClearBlock(mBuf);
		ClearBlock(block);
		return result;
	}

	public virtual bool VerifySignature(byte[] signature)
	{
		byte[] block;
		if (preSig == null)
		{
			try
			{
				block = cipher.ProcessBlock(signature, 0, signature.Length);
			}
			catch (Exception)
			{
				return false;
			}
		}
		else
		{
			if (!Arrays.AreEqual(preSig, signature))
			{
				throw new InvalidOperationException("updateWithRecoveredMessage called on different signature");
			}
			block = preBlock;
			preSig = null;
			preBlock = null;
		}
		if (((block[0] & 0xC0) ^ 0x40) != 0)
		{
			return ReturnFalse(block);
		}
		if (((block[block.Length - 1] & 0xF) ^ 0xC) != 0)
		{
			return ReturnFalse(block);
		}
		int delta = 0;
		if (((block[block.Length - 1] & 0xFF) ^ 0xBC) == 0)
		{
			delta = 1;
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
			delta = 2;
		}
		int mStart;
		for (mStart = 0; mStart != block.Length && ((block[mStart] & 0xF) ^ 0xA) != 0; mStart++)
		{
		}
		mStart++;
		byte[] hash = new byte[digest.GetDigestSize()];
		int off = block.Length - delta - hash.Length;
		if (off - mStart <= 0)
		{
			return ReturnFalse(block);
		}
		if ((block[0] & 0x20) == 0)
		{
			fullMessage = true;
			if (messageLength > off - mStart)
			{
				return ReturnFalse(block);
			}
			digest.Reset();
			digest.BlockUpdate(block, mStart, off - mStart);
			digest.DoFinal(hash, 0);
			bool isOkay = true;
			for (int i = 0; i != hash.Length; i++)
			{
				block[off + i] ^= hash[i];
				if (block[off + i] != 0)
				{
					isOkay = false;
				}
			}
			if (!isOkay)
			{
				return ReturnFalse(block);
			}
			recoveredMessage = new byte[off - mStart];
			Array.Copy(block, mStart, recoveredMessage, 0, recoveredMessage.Length);
		}
		else
		{
			fullMessage = false;
			digest.DoFinal(hash, 0);
			bool isOkay2 = true;
			for (int j = 0; j != hash.Length; j++)
			{
				block[off + j] ^= hash[j];
				if (block[off + j] != 0)
				{
					isOkay2 = false;
				}
			}
			if (!isOkay2)
			{
				return ReturnFalse(block);
			}
			recoveredMessage = new byte[off - mStart];
			Array.Copy(block, mStart, recoveredMessage, 0, recoveredMessage.Length);
		}
		if (messageLength != 0 && !IsSameAs(mBuf, recoveredMessage))
		{
			return ReturnFalse(block);
		}
		ClearBlock(mBuf);
		ClearBlock(block);
		messageLength = 0;
		return true;
	}

	private bool ReturnFalse(byte[] block)
	{
		messageLength = 0;
		ClearBlock(mBuf);
		ClearBlock(block);
		return false;
	}

	public virtual bool HasFullMessage()
	{
		return fullMessage;
	}
}
