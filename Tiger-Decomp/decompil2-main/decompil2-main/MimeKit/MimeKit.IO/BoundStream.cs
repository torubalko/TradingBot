using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace MimeKit.IO;

public class BoundStream : Stream
{
	private long position;

	private bool disposed;

	private bool eos;

	public Stream BaseStream { get; private set; }

	public long StartBoundary { get; private set; }

	public long EndBoundary { get; private set; }

	protected bool LeaveOpen { get; private set; }

	public override bool CanRead => BaseStream.CanRead;

	public override bool CanWrite => BaseStream.CanWrite;

	public override bool CanSeek => BaseStream.CanSeek;

	public override bool CanTimeout => BaseStream.CanTimeout;

	public override long Length
	{
		get
		{
			CheckDisposed();
			if (EndBoundary != -1)
			{
				return EndBoundary - StartBoundary;
			}
			if (eos)
			{
				return position;
			}
			return BaseStream.Length - StartBoundary;
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

	public override int ReadTimeout
	{
		get
		{
			return BaseStream.ReadTimeout;
		}
		set
		{
			BaseStream.ReadTimeout = value;
		}
	}

	public override int WriteTimeout
	{
		get
		{
			return BaseStream.WriteTimeout;
		}
		set
		{
			BaseStream.WriteTimeout = value;
		}
	}

	public BoundStream(Stream baseStream, long startBoundary, long endBoundary, bool leaveOpen)
	{
		if (baseStream == null)
		{
			throw new ArgumentNullException("baseStream");
		}
		if (startBoundary < 0)
		{
			throw new ArgumentOutOfRangeException("startBoundary");
		}
		if (endBoundary >= 0 && endBoundary < startBoundary)
		{
			throw new ArgumentOutOfRangeException("endBoundary");
		}
		EndBoundary = ((endBoundary < 0) ? (-1) : endBoundary);
		StartBoundary = startBoundary;
		BaseStream = baseStream;
		LeaveOpen = leaveOpen;
		position = 0L;
		eos = false;
	}

	private void CheckDisposed()
	{
		if (disposed)
		{
			throw new ObjectDisposedException("BoundStream");
		}
	}

	private void CheckCanSeek()
	{
		if (!BaseStream.CanSeek)
		{
			throw new NotSupportedException("The stream does not support seeking");
		}
	}

	private void CheckCanRead()
	{
		if (!BaseStream.CanRead)
		{
			throw new NotSupportedException("The stream does not support reading");
		}
	}

	private void CheckCanWrite()
	{
		if (!BaseStream.CanWrite)
		{
			throw new NotSupportedException("The stream does not support writing");
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
		CheckCanRead();
		ValidateArguments(buffer, offset, count);
		if (EndBoundary != -1 && StartBoundary + position >= EndBoundary)
		{
			eos = true;
			return 0;
		}
		if (BaseStream.Position != StartBoundary + position)
		{
			BaseStream.Seek(StartBoundary + position, SeekOrigin.Begin);
		}
		int count2 = (int)((EndBoundary != -1) ? Math.Min(EndBoundary - (StartBoundary + position), count) : count);
		int num = BaseStream.Read(buffer, offset, count2);
		if (num > 0)
		{
			position += num;
		}
		else if (num == 0)
		{
			eos = true;
		}
		return num;
	}

	public override async Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
	{
		CheckDisposed();
		CheckCanRead();
		ValidateArguments(buffer, offset, count);
		if (EndBoundary != -1 && StartBoundary + position >= EndBoundary)
		{
			eos = true;
			return 0;
		}
		if (BaseStream.Position != StartBoundary + position)
		{
			BaseStream.Seek(StartBoundary + position, SeekOrigin.Begin);
		}
		int count2 = (int)((EndBoundary != -1) ? Math.Min(EndBoundary - (StartBoundary + position), count) : count);
		int num = await BaseStream.ReadAsync(buffer, offset, count2, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		if (num > 0)
		{
			position += num;
		}
		else if (num == 0)
		{
			eos = true;
		}
		return num;
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		CheckDisposed();
		CheckCanWrite();
		ValidateArguments(buffer, offset, count);
		if (EndBoundary != -1 && StartBoundary + position + count > EndBoundary)
		{
			eos = StartBoundary + position >= EndBoundary;
			throw new IOException();
		}
		if (BaseStream.Position != StartBoundary + position)
		{
			BaseStream.Seek(StartBoundary + position, SeekOrigin.Begin);
		}
		BaseStream.Write(buffer, offset, count);
		position += count;
		if (EndBoundary != -1 && StartBoundary + position >= EndBoundary)
		{
			eos = true;
		}
	}

	public override async Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
	{
		CheckDisposed();
		CheckCanWrite();
		ValidateArguments(buffer, offset, count);
		if (EndBoundary != -1 && StartBoundary + position + count > EndBoundary)
		{
			eos = StartBoundary + position >= EndBoundary;
			throw new IOException();
		}
		if (BaseStream.Position != StartBoundary + position)
		{
			BaseStream.Seek(StartBoundary + position, SeekOrigin.Begin);
		}
		await BaseStream.WriteAsync(buffer, offset, count, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		position += count;
		if (EndBoundary != -1 && StartBoundary + position >= EndBoundary)
		{
			eos = true;
		}
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		CheckDisposed();
		CheckCanSeek();
		long num;
		switch (origin)
		{
		case SeekOrigin.Begin:
			num = StartBoundary + offset;
			break;
		case SeekOrigin.Current:
			num = StartBoundary + position + offset;
			break;
		case SeekOrigin.End:
			if (offset >= 0 || (EndBoundary == -1 && !eos))
			{
				if ((num = BaseStream.Seek(offset, origin)) == -1)
				{
					return -1L;
				}
			}
			else
			{
				num = ((EndBoundary != -1) ? (EndBoundary + offset) : (StartBoundary + position + offset));
			}
			break;
		default:
			throw new ArgumentOutOfRangeException("origin", "Invalid SeekOrigin specified");
		}
		if (num < StartBoundary)
		{
			throw new IOException("Cannot seek to a position before the beginning of the stream");
		}
		if (num == StartBoundary + position)
		{
			return position;
		}
		if (EndBoundary != -1 && num > EndBoundary)
		{
			throw new IOException("Cannot seek beyond the end of the stream");
		}
		if ((num = BaseStream.Seek(num, SeekOrigin.Begin)) == -1)
		{
			return -1L;
		}
		if ((EndBoundary != -1 && num < EndBoundary) || (eos && num < StartBoundary + position))
		{
			eos = false;
		}
		position = num - StartBoundary;
		return position;
	}

	public override void Flush()
	{
		CheckDisposed();
		CheckCanWrite();
		BaseStream.Flush();
	}

	public override Task FlushAsync(CancellationToken cancellationToken)
	{
		CheckDisposed();
		CheckCanWrite();
		return BaseStream.FlushAsync(cancellationToken);
	}

	public override void SetLength(long value)
	{
		CheckDisposed();
		if (EndBoundary == -1 || StartBoundary + value > EndBoundary)
		{
			long length = BaseStream.Length;
			if (StartBoundary + value > length)
			{
				BaseStream.SetLength(StartBoundary + value);
			}
			EndBoundary = StartBoundary + value;
		}
		else
		{
			EndBoundary = StartBoundary + value;
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && !LeaveOpen)
		{
			BaseStream.Dispose();
		}
		base.Dispose(disposing);
		disposed = true;
	}
}
