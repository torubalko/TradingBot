using System;
using System.IO;

namespace MimeKit.Tnef;

internal class TnefReaderStream : Stream
{
	private readonly int valueEndOffset;

	private readonly int dataEndOffset;

	private readonly TnefReader reader;

	private bool disposed;

	public override bool CanRead => true;

	public override bool CanWrite => false;

	public override bool CanSeek => false;

	public override long Length
	{
		get
		{
			throw new NotSupportedException("Cannot get the length of the stream.");
		}
	}

	public override long Position
	{
		get
		{
			throw new NotSupportedException("The stream does not support seeking.");
		}
		set
		{
			throw new NotSupportedException("The stream does not support seeking.");
		}
	}

	public TnefReaderStream(TnefReader tnefReader, int dataEndOffset, int valueEndOffset)
	{
		this.valueEndOffset = valueEndOffset;
		this.dataEndOffset = dataEndOffset;
		reader = tnefReader;
	}

	private void CheckDisposed()
	{
		if (disposed)
		{
			throw new ObjectDisposedException("TnefReaderStream");
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
		ValidateArguments(buffer, offset, count);
		CheckDisposed();
		int num = dataEndOffset - reader.StreamOffset;
		int num2 = Math.Min(num, count);
		int num3 = ((num2 > 0) ? reader.ReadAttributeRawValue(buffer, offset, num2) : 0);
		if (num - num3 == 0 && valueEndOffset > reader.StreamOffset)
		{
			int num4 = valueEndOffset - reader.StreamOffset;
			byte[] buffer2 = new byte[num4];
			reader.ReadAttributeRawValue(buffer2, 0, num4);
		}
		return num3;
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		throw new NotSupportedException("The stream does not support writing.");
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		throw new NotSupportedException("The stream does not support seeking.");
	}

	public override void Flush()
	{
		throw new NotSupportedException("The stream does not support writing.");
	}

	public override void SetLength(long value)
	{
		throw new NotSupportedException("The stream does not support setting the length.");
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		disposed = true;
	}
}
