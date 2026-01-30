using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Org.BouncyCastle.Utilities.Zlib;

namespace MailKit;

internal class CompressedStream : Stream
{
	private readonly ZStream zIn;

	private readonly ZStream zOut;

	private bool eos;

	private bool disposed;

	public Stream InnerStream { get; private set; }

	public override bool CanRead => InnerStream.CanRead;

	public override bool CanWrite => InnerStream.CanWrite;

	public override bool CanSeek => false;

	public override bool CanTimeout => InnerStream.CanTimeout;

	public override int ReadTimeout
	{
		get
		{
			return InnerStream.ReadTimeout;
		}
		set
		{
			InnerStream.ReadTimeout = value;
		}
	}

	public override int WriteTimeout
	{
		get
		{
			return InnerStream.WriteTimeout;
		}
		set
		{
			InnerStream.WriteTimeout = value;
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

	public CompressedStream(Stream innerStream)
	{
		InnerStream = innerStream;
		zOut = new ZStream();
		zOut.deflateInit(5, nowrap: true);
		zOut.next_out = new byte[4096];
		zIn = new ZStream();
		zIn.inflateInit(nowrap: true);
		zIn.next_in = new byte[4096];
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
			throw new ObjectDisposedException("CompressedStream");
		}
	}

	private async Task<int> ReadAsync(byte[] buffer, int offset, int count, bool doAsync, CancellationToken cancellationToken)
	{
		CheckDisposed();
		ValidateArguments(buffer, offset, count);
		if (count == 0)
		{
			return 0;
		}
		zIn.next_out = buffer;
		zIn.next_out_index = offset;
		zIn.avail_out = count;
		do
		{
			if (zIn.avail_in == 0 && !eos)
			{
				cancellationToken.ThrowIfCancellationRequested();
				if (doAsync)
				{
					ZStream zStream = zIn;
					zStream.avail_in = await InnerStream.ReadAsync(zIn.next_in, 0, zIn.next_in.Length, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				}
				else
				{
					zIn.avail_in = InnerStream.Read(zIn.next_in, 0, zIn.next_in.Length);
				}
				eos = zIn.avail_in == 0;
				zIn.next_in_index = 0;
			}
			int num = zIn.inflate(3);
			if (num == 1)
			{
				break;
			}
			if (eos && num == -5)
			{
				return 0;
			}
			if (num != 0)
			{
				throw new IOException("Error inflating: " + zIn.msg);
			}
		}
		while (zIn.avail_out == count);
		return count - zIn.avail_out;
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		return ReadAsync(buffer, offset, count, doAsync: false, CancellationToken.None).GetAwaiter().GetResult();
	}

	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
	{
		return ReadAsync(buffer, offset, count, doAsync: true, cancellationToken);
	}

	private async Task WriteAsync(byte[] buffer, int offset, int count, bool doAsync, CancellationToken cancellationToken)
	{
		CheckDisposed();
		ValidateArguments(buffer, offset, count);
		if (count == 0)
		{
			return;
		}
		zOut.next_in = buffer;
		zOut.next_in_index = offset;
		zOut.avail_in = count;
		do
		{
			cancellationToken.ThrowIfCancellationRequested();
			zOut.avail_out = zOut.next_out.Length;
			zOut.next_out_index = 0;
			if (zOut.deflate(3) != 0)
			{
				throw new IOException("Error deflating: " + zOut.msg);
			}
			if (doAsync)
			{
				await InnerStream.WriteAsync(zOut.next_out, 0, zOut.next_out.Length - zOut.avail_out, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			}
			else
			{
				InnerStream.Write(zOut.next_out, 0, zOut.next_out.Length - zOut.avail_out);
			}
		}
		while (zOut.avail_in > 0 || zOut.avail_out == 0);
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		WriteAsync(buffer, offset, count, doAsync: false, CancellationToken.None).GetAwaiter().GetResult();
	}

	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
	{
		return WriteAsync(buffer, offset, count, doAsync: true, cancellationToken);
	}

	public override void Flush()
	{
		CheckDisposed();
		InnerStream.Flush();
	}

	public override Task FlushAsync(CancellationToken cancellationToken)
	{
		CheckDisposed();
		return InnerStream.FlushAsync(cancellationToken);
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
			InnerStream.Dispose();
			disposed = true;
			zOut.free();
			zIn.free();
		}
		base.Dispose(disposing);
	}
}
