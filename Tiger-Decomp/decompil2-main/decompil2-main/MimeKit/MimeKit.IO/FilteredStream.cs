using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using MimeKit.IO.Filters;

namespace MimeKit.IO;

public class FilteredStream : Stream, ICancellableStream
{
	private enum IOOperation : byte
	{
		Read,
		Write
	}

	private const int ReadBufferSize = 4096;

	private List<IMimeFilter> filters = new List<IMimeFilter>();

	private IOOperation lastOp = IOOperation.Write;

	private int filteredLength;

	private int filteredIndex;

	private byte[] filtered;

	private byte[] readbuf;

	private bool disposed;

	private bool flushed;

	public Stream Source { get; private set; }

	public override bool CanRead => Source.CanRead;

	public override bool CanWrite => Source.CanWrite;

	public override bool CanSeek => false;

	public override bool CanTimeout => Source.CanTimeout;

	public override long Length
	{
		get
		{
			throw new NotSupportedException("Cannot get the length of the stream");
		}
	}

	public override long Position
	{
		get
		{
			throw new NotSupportedException("The stream does not support seeking");
		}
		set
		{
			throw new NotSupportedException("The stream does not support seeking");
		}
	}

	public override int ReadTimeout
	{
		get
		{
			return Source.ReadTimeout;
		}
		set
		{
			Source.ReadTimeout = value;
		}
	}

	public override int WriteTimeout
	{
		get
		{
			return Source.WriteTimeout;
		}
		set
		{
			Source.WriteTimeout = value;
		}
	}

	public FilteredStream(Stream source)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		Source = source;
	}

	public void Add(IMimeFilter filter)
	{
		if (filter == null)
		{
			throw new ArgumentNullException("filter");
		}
		filters.Add(filter);
	}

	public bool Contains(IMimeFilter filter)
	{
		if (filter == null)
		{
			throw new ArgumentNullException("filter");
		}
		return filters.Contains(filter);
	}

	public bool Remove(IMimeFilter filter)
	{
		if (filter == null)
		{
			throw new ArgumentNullException("filter");
		}
		return filters.Remove(filter);
	}

	private void CheckDisposed()
	{
		if (disposed)
		{
			throw new ObjectDisposedException("FilteredStream");
		}
	}

	private void CheckCanRead()
	{
		if (!Source.CanRead)
		{
			throw new NotSupportedException("The stream does not support reading");
		}
	}

	private void CheckCanWrite()
	{
		if (!Source.CanWrite)
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

	public int Read(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
	{
		CheckDisposed();
		CheckCanRead();
		ValidateArguments(buffer, offset, count);
		lastOp = IOOperation.Read;
		if (readbuf == null)
		{
			readbuf = new byte[4096];
		}
		int result;
		if (filteredLength == 0)
		{
			if (Source is ICancellableStream cancellableStream)
			{
				if ((result = cancellableStream.Read(readbuf, 0, 4096, cancellationToken)) <= 0)
				{
					return result;
				}
			}
			else
			{
				cancellationToken.ThrowIfCancellationRequested();
				if ((result = Source.Read(readbuf, 0, 4096)) <= 0)
				{
					return result;
				}
			}
			filteredLength = result;
			filteredIndex = 0;
			filtered = readbuf;
			foreach (IMimeFilter filter in filters)
			{
				filtered = filter.Filter(filtered, filteredIndex, filteredLength, out filteredIndex, out filteredLength);
			}
		}
		result = Math.Min(filteredLength, count);
		if (result > 0)
		{
			Buffer.BlockCopy(filtered, filteredIndex, buffer, offset, result);
			filteredLength -= result;
			filteredIndex += result;
		}
		return result;
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		return Read(buffer, offset, count, CancellationToken.None);
	}

	public override async Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
	{
		CheckDisposed();
		CheckCanRead();
		ValidateArguments(buffer, offset, count);
		lastOp = IOOperation.Read;
		if (readbuf == null)
		{
			readbuf = new byte[4096];
		}
		int result;
		if (filteredLength == 0)
		{
			if ((result = await Source.ReadAsync(readbuf, 0, 4096, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)) <= 0)
			{
				return result;
			}
			filteredLength = result;
			filteredIndex = 0;
			filtered = readbuf;
			foreach (IMimeFilter filter in filters)
			{
				filtered = filter.Filter(filtered, filteredIndex, filteredLength, out filteredIndex, out filteredLength);
			}
		}
		result = Math.Min(filteredLength, count);
		if (result > 0)
		{
			Buffer.BlockCopy(filtered, filteredIndex, buffer, offset, result);
			filteredLength -= result;
			filteredIndex += result;
		}
		return result;
	}

	public void Write(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
	{
		CheckDisposed();
		CheckCanWrite();
		ValidateArguments(buffer, offset, count);
		lastOp = IOOperation.Write;
		flushed = false;
		filteredIndex = offset;
		filteredLength = count;
		filtered = buffer;
		foreach (IMimeFilter filter in filters)
		{
			filtered = filter.Filter(filtered, filteredIndex, filteredLength, out filteredIndex, out filteredLength);
		}
		if (filteredLength != 0)
		{
			if (Source is ICancellableStream cancellableStream)
			{
				cancellableStream.Write(filtered, filteredIndex, filteredLength, cancellationToken);
				return;
			}
			cancellationToken.ThrowIfCancellationRequested();
			Source.Write(filtered, filteredIndex, filteredLength);
		}
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		Write(buffer, offset, count, CancellationToken.None);
	}

	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
	{
		CheckDisposed();
		CheckCanWrite();
		ValidateArguments(buffer, offset, count);
		lastOp = IOOperation.Write;
		flushed = false;
		filteredIndex = offset;
		filteredLength = count;
		filtered = buffer;
		foreach (IMimeFilter filter in filters)
		{
			filtered = filter.Filter(filtered, filteredIndex, filteredLength, out filteredIndex, out filteredLength);
		}
		return Source.WriteAsync(filtered, filteredIndex, filteredLength, cancellationToken);
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		throw new NotSupportedException("The stream does not support seeking");
	}

	public void Flush(CancellationToken cancellationToken)
	{
		CheckDisposed();
		CheckCanWrite();
		if (lastOp == IOOperation.Read)
		{
			return;
		}
		if (!flushed)
		{
			filtered = new byte[0];
			filteredIndex = 0;
			filteredLength = 0;
			foreach (IMimeFilter filter in filters)
			{
				filtered = filter.Flush(filtered, filteredIndex, filteredLength, out filteredIndex, out filteredLength);
			}
			flushed = true;
		}
		ICancellableStream cancellableStream = Source as ICancellableStream;
		if (filteredLength > 0)
		{
			if (cancellableStream != null)
			{
				cancellableStream.Write(filtered, filteredIndex, filteredLength, cancellationToken);
			}
			else
			{
				cancellationToken.ThrowIfCancellationRequested();
				Source.Write(filtered, filteredIndex, filteredLength);
			}
			filteredIndex = 0;
			filteredLength = 0;
		}
	}

	public override void Flush()
	{
		Flush(CancellationToken.None);
	}

	public override async Task FlushAsync(CancellationToken cancellationToken)
	{
		CheckDisposed();
		CheckCanWrite();
		if (lastOp == IOOperation.Read)
		{
			return;
		}
		if (!flushed)
		{
			filtered = new byte[0];
			filteredIndex = 0;
			filteredLength = 0;
			foreach (IMimeFilter filter in filters)
			{
				filtered = filter.Flush(filtered, filteredIndex, filteredLength, out filteredIndex, out filteredLength);
			}
			flushed = true;
		}
		if (filteredLength > 0)
		{
			await Source.WriteAsync(filtered, filteredIndex, filteredLength, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			filteredIndex = 0;
			filteredLength = 0;
		}
	}

	public override void SetLength(long value)
	{
		CheckDisposed();
		throw new NotSupportedException("Cannot set a length on the stream");
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			if (filters != null)
			{
				filters.Clear();
				filters = null;
			}
			readbuf = null;
		}
		base.Dispose(disposing);
		disposed = true;
	}
}
