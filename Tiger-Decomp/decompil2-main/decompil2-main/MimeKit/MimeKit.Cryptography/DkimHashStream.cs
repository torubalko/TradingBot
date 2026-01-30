using System;
using System.IO;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Digests;

namespace MimeKit.Cryptography;

internal class DkimHashStream : Stream
{
	private IDigest digest;

	private bool disposed;

	private int length;

	private int max;

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

	public DkimHashStream(DkimSignatureAlgorithm algorithm, int maxLength = -1)
	{
		if ((uint)(algorithm - 1) <= 1u)
		{
			digest = new Sha256Digest();
		}
		else
		{
			digest = new Sha1Digest();
		}
		max = maxLength;
	}

	public byte[] GenerateHash()
	{
		byte[] array = new byte[digest.GetDigestSize()];
		digest.DoFinal(array, 0);
		return array;
	}

	private void CheckDisposed()
	{
		if (disposed)
		{
			throw new ObjectDisposedException("DkimHashStream");
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
		int num = ((max >= 0 && length + count > max) ? (max - length) : count);
		digest.BlockUpdate(buffer, offset, num);
		length += num;
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
