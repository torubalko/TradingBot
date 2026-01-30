using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Signers;

public class DsaDigestSigner : ISigner
{
	private readonly IDsa dsa;

	private readonly IDigest digest;

	private readonly IDsaEncoding encoding;

	private bool forSigning;

	public virtual string AlgorithmName => digest.AlgorithmName + "with" + dsa.AlgorithmName;

	public DsaDigestSigner(IDsa dsa, IDigest digest)
	{
		this.dsa = dsa;
		this.digest = digest;
		encoding = StandardDsaEncoding.Instance;
	}

	public DsaDigestSigner(IDsaExt dsa, IDigest digest, IDsaEncoding encoding)
	{
		this.dsa = dsa;
		this.digest = digest;
		this.encoding = encoding;
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
		dsa.Init(forSigning, parameters);
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
			throw new InvalidOperationException("DSADigestSigner not initialised for signature generation.");
		}
		byte[] hash = new byte[digest.GetDigestSize()];
		digest.DoFinal(hash, 0);
		BigInteger[] sig = dsa.GenerateSignature(hash);
		try
		{
			return encoding.Encode(GetOrder(), sig[0], sig[1]);
		}
		catch (Exception)
		{
			throw new InvalidOperationException("unable to encode signature");
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
		try
		{
			BigInteger[] sig = encoding.Decode(GetOrder(), signature);
			return dsa.VerifySignature(hash, sig[0], sig[1]);
		}
		catch (Exception)
		{
			return false;
		}
	}

	public virtual void Reset()
	{
		digest.Reset();
	}

	protected virtual BigInteger GetOrder()
	{
		if (!(dsa is IDsaExt))
		{
			return null;
		}
		return ((IDsaExt)dsa).Order;
	}
}
