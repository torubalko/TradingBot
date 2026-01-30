using System;
using System.IO;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math.EC.Rfc8032;

namespace Org.BouncyCastle.Crypto.Signers;

public class Ed25519Signer : ISigner
{
	private class Buffer : MemoryStream
	{
		internal byte[] GenerateSignature(Ed25519PrivateKeyParameters privateKey)
		{
			lock (this)
			{
				byte[] buf = GetBuffer();
				int count = (int)Position;
				byte[] signature = new byte[Ed25519PrivateKeyParameters.SignatureSize];
				privateKey.Sign(Ed25519.Algorithm.Ed25519, null, buf, 0, count, signature, 0);
				Reset();
				return signature;
			}
		}

		internal bool VerifySignature(Ed25519PublicKeyParameters publicKey, byte[] signature)
		{
			if (Ed25519.SignatureSize != signature.Length)
			{
				Reset();
				return false;
			}
			lock (this)
			{
				byte[] buf = GetBuffer();
				int count = (int)Position;
				byte[] pk = publicKey.GetEncoded();
				bool result = Ed25519.Verify(signature, 0, pk, 0, buf, 0, count);
				Reset();
				return result;
			}
		}

		internal void Reset()
		{
			lock (this)
			{
				long count = Position;
				Array.Clear(GetBuffer(), 0, (int)count);
				Position = 0L;
			}
		}
	}

	private readonly Buffer buffer = new Buffer();

	private bool forSigning;

	private Ed25519PrivateKeyParameters privateKey;

	private Ed25519PublicKeyParameters publicKey;

	public virtual string AlgorithmName => "Ed25519";

	public virtual void Init(bool forSigning, ICipherParameters parameters)
	{
		this.forSigning = forSigning;
		if (forSigning)
		{
			privateKey = (Ed25519PrivateKeyParameters)parameters;
			publicKey = null;
		}
		else
		{
			privateKey = null;
			publicKey = (Ed25519PublicKeyParameters)parameters;
		}
		Reset();
	}

	public virtual void Update(byte b)
	{
		buffer.WriteByte(b);
	}

	public virtual void BlockUpdate(byte[] buf, int off, int len)
	{
		buffer.Write(buf, off, len);
	}

	public virtual byte[] GenerateSignature()
	{
		if (!forSigning || privateKey == null)
		{
			throw new InvalidOperationException("Ed25519Signer not initialised for signature generation.");
		}
		return buffer.GenerateSignature(privateKey);
	}

	public virtual bool VerifySignature(byte[] signature)
	{
		if (forSigning || publicKey == null)
		{
			throw new InvalidOperationException("Ed25519Signer not initialised for verification");
		}
		return buffer.VerifySignature(publicKey, signature);
	}

	public virtual void Reset()
	{
		buffer.Reset();
	}
}
