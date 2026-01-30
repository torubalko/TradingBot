using System;
using System.IO;
using Org.BouncyCastle.Crypto;

namespace MimeKit.Cryptography;

internal class DkimSignatureStream : Stream
{
	private bool disposed;

	private long length;

	public ISigner Signer { get; private set; }

	public override bool CanRead => false;

	public override bool CanWrite => true;

	public override bool CanSeek => false;

	public override bool CanTimeout => false;

	public override long Length
	{
		get
		{
			CheckDisposed();
			return length;
		}
	}

	public override long Position
	{
		get
		{
			return length;
		}
		set
		{
			Seek(value, SeekOrigin.Begin);
		}
	}

	public DkimSignatureStream(ISigner signer)
	{
		if (signer == null)
		{
			throw new ArgumentNullException("signer");
		}
		Signer = signer;
	}

	public byte[] GenerateSignature()
	{
		return Signer.GenerateSignature();
	}

	public bool VerifySignature(string signature)
	{
		if (signature == null)
		{
			throw new ArgumentNullException("signature");
		}
		byte[] signature2 = Convert.FromBase64String(signature);
		return Signer.VerifySignature(signature2);
	}

	private void CheckDisposed()
	{
		if (disposed)
		{
			throw new ObjectDisposedException("DkimSignatureStream");
		}
	}

	private static void ValidateArguments(byte[] buffer, int offset, int count)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (offset < 0 || offset > buffer.Length)
		{
			throw new ArgumentOutOfRangeException("offset");
		}
		if (count < 0 || count > buffer.Length - offset)
		{
			throw new ArgumentOutOfRangeException("count");
		}
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		CheckDisposed();
		throw new NotSupportedException("The stream does not support reading");
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		CheckDisposed();
		ValidateArguments(buffer, offset, count);
		Signer.BlockUpdate(buffer, offset, count);
		length += count;
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		CheckDisposed();
		throw new NotSupportedException("The stream does not support seeking.");
	}

	public override void Flush()
	{
		CheckDisposed();
	}

	public override void SetLength(long value)
	{
		CheckDisposed();
		throw new NotSupportedException("The stream does not support setting the length.");
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && !disposed)
		{
			disposed = true;
		}
		base.Dispose(disposing);
	}
}
