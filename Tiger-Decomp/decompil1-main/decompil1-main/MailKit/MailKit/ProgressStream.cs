using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using MimeKit.IO;

namespace MailKit;

internal class ProgressStream : Stream, ICancellableStream
{
	private readonly ICancellableStream cancellable;

	public Stream Source { get; private set; }

	private Action<int> Update { get; set; }

	public override bool CanRead => Source.CanRead;

	public override bool CanWrite => Source.CanWrite;

	public override bool CanSeek => false;

	public override bool CanTimeout => Source.CanTimeout;

	public override long Length => Source.Length;

	public override long Position
	{
		get
		{
			return Source.Position;
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

	public ProgressStream(Stream source, Action<int> update)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (update == null)
		{
			throw new ArgumentNullException("update");
		}
		cancellable = source as ICancellableStream;
		Source = source;
		Update = update;
	}

	public int Read(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
	{
		int num;
		if (cancellable != null)
		{
			if ((num = cancellable.Read(buffer, offset, count, cancellationToken)) > 0)
			{
				Update(num);
			}
		}
		else if ((num = Source.Read(buffer, offset, count)) > 0)
		{
			Update(num);
		}
		return num;
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		int num;
		if ((num = Source.Read(buffer, offset, count)) > 0)
		{
			Update(num);
		}
		return num;
	}

	public override async Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
	{
		int num;
		if ((num = await Source.ReadAsync(buffer, offset, count, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)) > 0)
		{
			Update(num);
		}
		return num;
	}

	public void Write(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
	{
		if (cancellable != null)
		{
			cancellable.Write(buffer, offset, count, cancellationToken);
		}
		else
		{
			Source.Write(buffer, offset, count);
		}
		if (count > 0)
		{
			Update(count);
		}
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		Source.Write(buffer, offset, count);
		if (count > 0)
		{
			Update(count);
		}
	}

	public override async Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
	{
		await Source.WriteAsync(buffer, offset, count, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		if (count > 0)
		{
			Update(count);
		}
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		throw new NotSupportedException("The stream does not support seeking.");
	}

	public void Flush(CancellationToken cancellationToken)
	{
		if (cancellable != null)
		{
			cancellable.Flush(cancellationToken);
		}
		else
		{
			Source.Flush();
		}
	}

	public override void Flush()
	{
		Source.Flush();
	}

	public override Task FlushAsync(CancellationToken cancellationToken)
	{
		return Source.FlushAsync(cancellationToken);
	}

	public override void SetLength(long value)
	{
		throw new NotSupportedException("The stream does not support resizing.");
	}
}
