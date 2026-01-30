using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace MailKit;

internal class DuplexStream : Stream
{
	private bool disposed;

	public Stream InputStream { get; private set; }

	public Stream OutputStream { get; private set; }

	public override bool CanRead => true;

	public override bool CanWrite => true;

	public override bool CanSeek => false;

	public override bool CanTimeout
	{
		get
		{
			if (InputStream.CanTimeout)
			{
				return OutputStream.CanTimeout;
			}
			return false;
		}
	}

	public override int ReadTimeout
	{
		get
		{
			return InputStream.ReadTimeout;
		}
		set
		{
			InputStream.ReadTimeout = value;
		}
	}

	public override int WriteTimeout
	{
		get
		{
			return OutputStream.WriteTimeout;
		}
		set
		{
			OutputStream.WriteTimeout = value;
		}
	}

	public override long Position
	{
		get
		{
			throw new NotSupportedException();
		}
		set
		{
			throw new NotSupportedException();
		}
	}

	public override long Length
	{
		get
		{
			throw new NotSupportedException();
		}
	}

	public DuplexStream(Stream istream, Stream ostream)
	{
		if (istream == null)
		{
			throw new ArgumentNullException("istream");
		}
		if (ostream == null)
		{
			throw new ArgumentNullException("ostream");
		}
		InputStream = istream;
		OutputStream = ostream;
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

	private void CheckDisposed()
	{
		if (disposed)
		{
			throw new ObjectDisposedException("DuplexStream");
		}
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		CheckDisposed();
		ValidateArguments(buffer, offset, count);
		return InputStream.Read(buffer, offset, count);
	}

	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
	{
		CheckDisposed();
		ValidateArguments(buffer, offset, count);
		return InputStream.ReadAsync(buffer, offset, count, cancellationToken);
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		CheckDisposed();
		ValidateArguments(buffer, offset, count);
		OutputStream.Write(buffer, offset, count);
	}

	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
	{
		CheckDisposed();
		ValidateArguments(buffer, offset, count);
		return OutputStream.WriteAsync(buffer, offset, count, cancellationToken);
	}

	public override void Flush()
	{
		CheckDisposed();
		OutputStream.Flush();
	}

	public override Task FlushAsync(CancellationToken cancellationToken)
	{
		CheckDisposed();
		return OutputStream.FlushAsync(cancellationToken);
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		throw new NotSupportedException();
	}

	public override void SetLength(long value)
	{
		throw new NotSupportedException();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && !disposed)
		{
			OutputStream.Dispose();
			InputStream.Dispose();
			disposed = true;
		}
		base.Dispose(disposing);
	}
}
