using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Signers;

public class Gost3410DigestSigner : ISigner
{
	private readonly IDigest digest;

	private readonly IDsa dsaSigner;

	private readonly int size;

	private int halfSize;

	private bool forSigning;

	public virtual string AlgorithmName => digest.AlgorithmName + "with" + dsaSigner.AlgorithmName;

	public Gost3410DigestSigner(IDsa signer, IDigest digest)
	{
		dsaSigner = signer;
		this.digest = digest;
		halfSize = digest.GetDigestSize();
		size = halfSize * 2;
	}

	public virtual void Init(bool forSigning, ICipherParameters parameters)
	{
		this.forSigning = forSigning;
		AsymmetricKeyParameter k = ((!(parameters is ParametersWithRandom)) ? ((AsymmetricKeyParameter)parameters) : ((AsymmetricKeyParameter)((ParametersWithRandom)parameters).Parameters));
		if (forSigning && !k.IsPrivate)
		{
			throw new InvalidKeyException("Signing Requires Private Key.");
		}
		if (!forSigning && k.IsPrivate)
		{
			throw new InvalidKeyException("Verification Requires Public Key.");
		}
		Reset();
		dsaSigner.Init(forSigning, parameters);
	}

	public virtual void Update(byte input)
	{
		digest.Update(input);
	}

	public virtual void BlockUpdate(byte[] input, int inOff, int length)
	{
		digest.BlockUpdate(input, inOff, length);
	}

	public virtual byte[] GenerateSignature()
	{
		if (!forSigning)
		{
			throw new InvalidOperationException("GOST3410DigestSigner not initialised for signature generation.");
		}
		byte[] hash = new byte[digest.GetDigestSize()];
		digest.DoFinal(hash, 0);
		try
		{
			BigInteger[] array = dsaSigner.GenerateSignature(hash);
			byte[] sigBytes = new byte[size];
			byte[] r = array[0].ToByteArrayUnsigned();
			byte[] s = array[1].ToByteArrayUnsigned();
			s.CopyTo(sigBytes, halfSize - s.Length);
			r.CopyTo(sigBytes, size - r.Length);
			return sigBytes;
		}
		catch (Exception ex)
		{
			throw new SignatureException(ex.Message, ex);
		}
	}

	public virtual bool VerifySignature(byte[] signature)
	{
		if (forSigning)
		{
			throw new InvalidOperationException("DSADigestSigner not initialised for verification");
		}
		byte[] hash = new byte[digest.GetDigestSize()];
		digest.DoFinal(hash, 0);
		BigInteger R;
		BigInteger S;
		try
		{
			R = new BigInteger(1, signature, halfSize, halfSize);
			S = new BigInteger(1, signature, 0, halfSize);
		}
		catch (Exception exception)
		{
			throw new SignatureException("error decoding signature bytes.", exception);
		}
		return dsaSigner.VerifySignature(hash, R, S);
	}

	public virtual void Reset()
	{
		digest.Reset();
	}
}
