using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace MimeKit.IO;

public class MeasuringStream : Stream
{
	private bool disposed;

	private long position;

	private long length;

	public override bool CanRead => false;

	public override bool CanWrite => true;

	public override bool CanSeek => true;

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
			return position;
		}
		set
		{
			Seek(value, SeekOrigin.Begin);
		}
	}

	private void CheckDisposed()
	{
		if (disposed)
		{
			throw new ObjectDisposedException("MeasuringStream");
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

	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
	{
		CheckDisposed();
		throw new NotSupportedException("The stream does not support reading");
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		CheckDisposed();
		ValidateArguments(buffer, offset, count);
		position += count;
		length = Math.Max(length, position);
	}

	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
	{
		Write(buffer, offset, count);
		return Task.FromResult(0);
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		CheckDisposed();
		long num = origin switch
		{
			SeekOrigin.Begin => offset, 
			SeekOrigin.Current => position + offset, 
			SeekOrigin.End => length + offset, 
			_ => throw new ArgumentOutOfRangeException("origin", "Invalid SeekOrigin specified"), 
		};
		if (num < 0)
		{
			throw new IOException("Cannot seek to a position before the beginning of the stream");
		}
		if (num == position)
		{
			return position;
		}
		if (num > length)
		{
			throw new IOException("Cannot seek beyond the end of the stream");
		}
		position = num;
		return position;
	}

	public override void Flush()
	{
		CheckDisposed();
	}

	public override Task FlushAsync(CancellationToken cancellationToken)
	{
		CheckDisposed();
		return Task.FromResult(0);
	}

	public override void SetLength(long value)
	{
		CheckDisposed();
		if (value < 0)
		{
			throw new ArgumentOutOfRangeException("value");
		}
		position = Math.Min(position, value);
		length = value;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		disposed = true;
	}
}
