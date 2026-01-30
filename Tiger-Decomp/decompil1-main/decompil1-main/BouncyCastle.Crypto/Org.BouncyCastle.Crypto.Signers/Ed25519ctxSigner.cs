using System;
using System.IO;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math.EC.Rfc8032;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Signers;

public class Ed25519ctxSigner : ISigner
{
	private class Buffer : MemoryStream
	{
		internal byte[] GenerateSignature(Ed25519PrivateKeyParameters privateKey, byte[] ctx)
		{
			lock (this)
			{
				byte[] buf = GetBuffer();
				int count = (int)Position;
				byte[] signature = new byte[Ed25519PrivateKeyParameters.SignatureSize];
				privateKey.Sign(Ed25519.Algorithm.Ed25519ctx, ctx, buf, 0, count, signature, 0);
				Reset();
				return signature;
			}
		}

		internal bool VerifySignature(Ed25519PublicKeyParameters publicKey, byte[] ctx, byte[] signature)
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
				bool result = Ed25519.Verify(signature, 0, pk, 0, ctx, buf, 0, count);
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

	private readonly byte[] context;

	private bool forSigning;

	private Ed25519PrivateKeyParameters privateKey;

	private Ed25519PublicKeyParameters publicKey;

	public virtual string AlgorithmName => "Ed25519ctx";

	public Ed25519ctxSigner(byte[] context)
	{
		this.context = Arrays.Clone(context);
	}

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
			throw new InvalidOperationException("Ed25519ctxSigner not initialised for signature generation.");
		}
		return buffer.GenerateSignature(privateKey, context);
	}

	public virtual bool VerifySignature(byte[] signature)
	{
		if (forSigning || publicKey == null)
		{
			throw new InvalidOperationException("Ed25519ctxSigner not initialised for verification");
		}
		return buffer.VerifySignature(publicKey, context, signature);
	}

	public virtual void Reset()
	{
		buffer.Reset();
	}
}
