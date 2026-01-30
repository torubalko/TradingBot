using System;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math.EC.Rfc8032;

namespace MimeKit.Cryptography;

internal class Ed25519DigestSigner : ISigner
{
	private Ed25519PrivateKeyParameters privateKey;

	private Ed25519PublicKeyParameters publicKey;

	private readonly IDigest digest;

	public string AlgorithmName => digest.AlgorithmName + "withEd25519";

	public Ed25519DigestSigner(IDigest digest)
	{
		this.digest = digest;
	}

	public void Init(bool forSigning, ICipherParameters parameters)
	{
		if (forSigning)
		{
			privateKey = (Ed25519PrivateKeyParameters)parameters;
			publicKey = privateKey.GeneratePublicKey();
		}
		else
		{
			publicKey = (Ed25519PublicKeyParameters)parameters;
			privateKey = null;
		}
		Reset();
	}

	public void Update(byte input)
	{
		digest.Update(input);
	}

	public void BlockUpdate(byte[] input, int inOff, int length)
	{
		digest.BlockUpdate(input, inOff, length);
	}

	public byte[] GenerateSignature()
	{
		if (privateKey == null)
		{
			throw new InvalidOperationException("Ed25519DigestSigner not initialised for signature generation.");
		}
		byte[] array = new byte[digest.GetDigestSize()];
		digest.DoFinal(array, 0);
		byte[] array2 = new byte[Ed25519PrivateKeyParameters.SignatureSize];
		privateKey.Sign(Ed25519.Algorithm.Ed25519, null, array, 0, array.Length, array2, 0);
		Reset();
		return array2;
	}

	public bool VerifySignature(byte[] signature)
	{
		if (privateKey != null)
		{
			throw new InvalidOperationException("Ed25519DigestSigner not initialised for verification");
		}
		if (Ed25519.SignatureSize != signature.Length)
		{
			return false;
		}
		byte[] array = new byte[digest.GetDigestSize()];
		digest.DoFinal(array, 0);
		byte[] encoded = publicKey.GetEncoded();
		bool result = Ed25519.Verify(signature, 0, encoded, 0, array, 0, array.Length);
		Reset();
		return result;
	}

	public void Reset()
	{
		digest.Reset();
	}
}
