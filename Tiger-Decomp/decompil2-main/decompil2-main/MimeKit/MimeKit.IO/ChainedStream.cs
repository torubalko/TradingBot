using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace MimeKit.IO;

public class ChainedStream : Stream
{
	private readonly List<Stream> streams;

	private readonly List<bool> leaveOpen;

	private long position;

	private bool disposed;

	private int current;

	private bool eos;

	public override bool CanRead
	{
		get
		{
			foreach (Stream stream in streams)
			{
				if (!stream.CanRead)
				{
					return false;
				}
			}
			return streams.Count > 0;
		}
	}

	public override bool CanWrite
	{
		get
		{
			foreach (Stream stream in streams)
			{
				if (!stream.CanWrite)
				{
					return false;
				}
			}
			return streams.Count > 0;
		}
	}

	public override bool CanSeek
	{
		get
		{
			foreach (Stream stream in streams)
			{
				if (!stream.CanSeek)
				{
					return false;
				}
			}
			return streams.Count > 0;
		}
	}

	public override bool CanTimeout => false;

	public override long Length
	{
		get
		{
			long num = 0L;
			CheckDisposed();
			foreach (Stream stream in streams)
			{
				num += stream.Length;
			}
			return num;
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

	public ChainedStream()
	{
		leaveOpen = new List<bool>();
		streams = new List<Stream>();
	}

	public void Add(Stream stream, bool leaveOpen = false)
	{
		if (stream == null)
		{
			throw new ArgumentNullException("stream");
		}
		this.leaveOpen.Add(leaveOpen);
		streams.Add(stream);
		eos = false;
	}

	private void CheckDisposed()
	{
		if (disposed)
		{
			throw new ObjectDisposedException("ChainedStream");
		}
	}

	private void CheckCanSeek()
	{
		if (!CanSeek)
		{
			throw new NotSupportedException("The stream does not support seeking");
		}
	}

	private void CheckCanRead()
	{
		if (!CanRead)
		{
			throw new NotSupportedException("The stream does not support reading");
		}
	}

	private void CheckCanWrite()
	{
		if (!CanWrite)
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
		if (count == 0 || eos)
		{
			return 0;
		}
		int i = 0;
		while (current < streams.Count)
		{
			int num;
			for (; i < count; i += num)
			{
				if ((num = streams[current].Read(buffer, offset + i, count - i)) <= 0)
				{
					break;
				}
			}
			if (i == count)
			{
				break;
			}
			current++;
		}
		if (i > 0)
		{
			position += i;
		}
		else
		{
			eos = true;
		}
		return i;
	}

	public override async Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
	{
		CheckDisposed();
		CheckCanRead();
		ValidateArguments(buffer, offset, count);
		if (count == 0 || eos)
		{
			return 0;
		}
		int nread = 0;
		while (current < streams.Count)
		{
			int num;
			for (; nread < count; nread += num)
			{
				if ((num = await streams[current].ReadAsync(buffer, offset + nread, count - nread, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)) <= 0)
				{
					break;
				}
			}
			if (nread == count)
			{
				break;
			}
			current++;
		}
		if (nread > 0)
		{
			position += nread;
		}
		else
		{
			eos = true;
		}
		return nread;
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		CheckDisposed();
		CheckCanWrite();
		ValidateArguments(buffer, offset, count);
		if (current >= streams.Count)
		{
			current = streams.Count - 1;
		}
		int num = 0;
		while (current < streams.Count && num < count)
		{
			int num2 = count - num;
			if (current + 1 < streams.Count)
			{
				long num3 = streams[current].Length - streams[current].Position;
				if (num3 < num2)
				{
					num2 = (int)num3;
				}
			}
			streams[current].Write(buffer, offset + num, num2);
			position += num2;
			num += num2;
			if (num < count)
			{
				streams[current].Flush();
				current++;
			}
		}
	}

	public override async Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
	{
		CheckDisposed();
		CheckCanWrite();
		ValidateArguments(buffer, offset, count);
		if (current >= streams.Count)
		{
			current = streams.Count - 1;
		}
		int nwritten = 0;
		while (current < streams.Count && nwritten < count)
		{
			int n = count - nwritten;
			if (current + 1 < streams.Count)
			{
				long num = streams[current].Length - streams[current].Position;
				if (num < n)
				{
					n = (int)num;
				}
			}
			await streams[current].WriteAsync(buffer, offset + nwritten, n, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			position += n;
			nwritten += n;
			if (nwritten < count)
			{
				await streams[current].FlushAsync(cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				current++;
			}
		}
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		CheckDisposed();
		CheckCanSeek();
		long num = -1L;
		long num2;
		switch (origin)
		{
		case SeekOrigin.Begin:
			num2 = offset;
			break;
		case SeekOrigin.Current:
			num2 = position + offset;
			break;
		case SeekOrigin.End:
			num = Length;
			num2 = num + offset;
			break;
		default:
			throw new ArgumentOutOfRangeException("origin", "Invalid SeekOrigin specified");
		}
		if (num2 < 0)
		{
			throw new IOException("Cannot seek to a position before the beginning of the stream");
		}
		if (num2 == position)
		{
			return position;
		}
		if (num2 > ((num < 0) ? Length : num))
		{
			throw new IOException("Cannot seek beyond the end of the stream");
		}
		if (num2 > position)
		{
			while (current < streams.Count && position < num2)
			{
				long val = streams[current].Length - streams[current].Position;
				long num3 = Math.Min(val, num2 - position);
				streams[current].Seek(num3, SeekOrigin.Current);
				position += num3;
				if (position < num2)
				{
					current++;
				}
			}
			eos = current >= streams.Count;
		}
		else
		{
			int num4 = Math.Min(streams.Count - 1, current);
			int i = 0;
			position = 0L;
			for (; i <= num4; i++)
			{
				num = streams[i].Length;
				if (num2 < position + num)
				{
					streams[i].Seek(num2 - position, SeekOrigin.Begin);
					position = num2;
					break;
				}
				position += num;
			}
			current = i++;
			while (i <= num4)
			{
				streams[i++].Seek(0L, SeekOrigin.Begin);
			}
			eos = false;
		}
		return position;
	}

	public override void Flush()
	{
		CheckDisposed();
		CheckCanWrite();
		if (current < streams.Count)
		{
			streams[current].Flush();
		}
	}

	public override async Task FlushAsync(CancellationToken cancellationToken)
	{
		CheckDisposed();
		CheckCanWrite();
		if (current < streams.Count)
		{
			await streams[current].FlushAsync(cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
	}

	public override void SetLength(long value)
	{
		CheckDisposed();
		throw new NotSupportedException("Cannot set a length on the stream");
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && !disposed)
		{
			for (int i = 0; i < streams.Count; i++)
			{
				if (!leaveOpen[i])
				{
					streams[i].Dispose();
				}
			}
		}
		base.Dispose(disposing);
		disposed = true;
	}
}
