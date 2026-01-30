using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Signers;

public class X931Signer : ISigner
{
	[Obsolete("Use 'IsoTrailers' instead")]
	public const int TRAILER_IMPLICIT = 188;

	[Obsolete("Use 'IsoTrailers' instead")]
	public const int TRAILER_RIPEMD160 = 12748;

	[Obsolete("Use 'IsoTrailers' instead")]
	public const int TRAILER_RIPEMD128 = 13004;

	[Obsolete("Use 'IsoTrailers' instead")]
	public const int TRAILER_SHA1 = 13260;

	[Obsolete("Use 'IsoTrailers' instead")]
	public const int TRAILER_SHA256 = 13516;

	[Obsolete("Use 'IsoTrailers' instead")]
	public const int TRAILER_SHA512 = 13772;

	[Obsolete("Use 'IsoTrailers' instead")]
	public const int TRAILER_SHA384 = 14028;

	[Obsolete("Use 'IsoTrailers' instead")]
	public const int TRAILER_WHIRLPOOL = 14284;

	[Obsolete("Use 'IsoTrailers' instead")]
	public const int TRAILER_SHA224 = 14540;

	private IDigest digest;

	private IAsymmetricBlockCipher cipher;

	private RsaKeyParameters kParam;

	private int trailer;

	private int keyBits;

	private byte[] block;

	public virtual string AlgorithmName => digest.AlgorithmName + "with" + cipher.AlgorithmName + "/X9.31";

	public X931Signer(IAsymmetricBlockCipher cipher, IDigest digest, bool isImplicit)
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

	public X931Signer(IAsymmetricBlockCipher cipher, IDigest digest)
		: this(cipher, digest, isImplicit: false)
	{
	}

	public virtual void Init(bool forSigning, ICipherParameters parameters)
	{
		kParam = (RsaKeyParameters)parameters;
		cipher.Init(forSigning, kParam);
		keyBits = kParam.Modulus.BitLength;
		block = new byte[(keyBits + 7) / 8];
		Reset();
	}

	private void ClearBlock(byte[] block)
	{
		Array.Clear(block, 0, block.Length);
	}

	public virtual void Update(byte b)
	{
		digest.Update(b);
	}

	public virtual void BlockUpdate(byte[] input, int off, int len)
	{
		digest.BlockUpdate(input, off, len);
	}

	public virtual void Reset()
	{
		digest.Reset();
	}

	public virtual byte[] GenerateSignature()
	{
		CreateSignatureBlock();
		BigInteger t = new BigInteger(1, cipher.ProcessBlock(block, 0, block.Length));
		ClearBlock(block);
		t = t.Min(kParam.Modulus.Subtract(t));
		return BigIntegers.AsUnsignedByteArray(BigIntegers.GetUnsignedByteLength(kParam.Modulus), t);
	}

	private void CreateSignatureBlock()
	{
		int digSize = digest.GetDigestSize();
		int delta;
		if (trailer == 188)
		{
			delta = block.Length - digSize - 1;
			digest.DoFinal(block, delta);
			block[block.Length - 1] = 188;
		}
		else
		{
			delta = block.Length - digSize - 2;
			digest.DoFinal(block, delta);
			block[block.Length - 2] = (byte)(trailer >> 8);
			block[block.Length - 1] = (byte)trailer;
		}
		block[0] = 107;
		for (int i = delta - 2; i != 0; i--)
		{
			block[i] = 187;
		}
		block[delta - 1] = 186;
	}

	public virtual bool VerifySignature(byte[] signature)
	{
		try
		{
			block = cipher.ProcessBlock(signature, 0, signature.Length);
		}
		catch (Exception)
		{
			return false;
		}
		BigInteger t = new BigInteger(1, block);
		BigInteger f;
		if ((t.IntValue & 0xF) == 12)
		{
			f = t;
		}
		else
		{
			t = kParam.Modulus.Subtract(t);
			if ((t.IntValue & 0xF) != 12)
			{
				return false;
			}
			f = t;
		}
		CreateSignatureBlock();
		byte[] fBlock = BigIntegers.AsUnsignedByteArray(block.Length, f);
		bool result = Arrays.ConstantTimeAreEqual(block, fBlock);
		ClearBlock(block);
		ClearBlock(fBlock);
		return result;
	}
}
