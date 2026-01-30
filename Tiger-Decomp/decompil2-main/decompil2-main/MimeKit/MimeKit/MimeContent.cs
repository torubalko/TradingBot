using System;
using System.Buffers;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using MimeKit.IO;
using MimeKit.IO.Filters;

namespace MimeKit;

public class MimeContent : IMimeContent
{
	private const int BufferLength = 4096;

	public ContentEncoding Encoding { get; private set; }

	public NewLineFormat? NewLineFormat { get; set; }

	public Stream Stream { get; private set; }

	public MimeContent(Stream stream, ContentEncoding encoding = ContentEncoding.Default)
	{
		if (stream == null)
		{
			throw new ArgumentNullException("stream");
		}
		if (!stream.CanRead)
		{
			throw new ArgumentException("The stream does not support reading.", "stream");
		}
		if (!stream.CanSeek)
		{
			throw new ArgumentException("The stream does not support seeking.", "stream");
		}
		Encoding = encoding;
		Stream = stream;
	}

	public Stream Open()
	{
		Stream.Seek(0L, SeekOrigin.Begin);
		FilteredStream filteredStream = new FilteredStream(Stream);
		filteredStream.Add(DecoderFilter.Create(Encoding));
		return filteredStream;
	}

	public void WriteTo(Stream stream, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (stream == null)
		{
			throw new ArgumentNullException("stream");
		}
		Stream.Seek(0L, SeekOrigin.Begin);
		byte[] array = ArrayPool<byte>.Shared.Rent(4096);
		ICancellableStream cancellableStream = Stream as ICancellableStream;
		ICancellableStream cancellableStream2 = stream as ICancellableStream;
		try
		{
			while (true)
			{
				int count;
				if (cancellableStream != null)
				{
					if ((count = cancellableStream.Read(array, 0, 4096, cancellationToken)) <= 0)
					{
						break;
					}
				}
				else
				{
					cancellationToken.ThrowIfCancellationRequested();
					if ((count = Stream.Read(array, 0, 4096)) <= 0)
					{
						break;
					}
				}
				if (cancellableStream2 != null)
				{
					cancellableStream2.Write(array, 0, count, cancellationToken);
					continue;
				}
				cancellationToken.ThrowIfCancellationRequested();
				stream.Write(array, 0, count);
			}
			Stream.Seek(0L, SeekOrigin.Begin);
		}
		catch (OperationCanceledException)
		{
			try
			{
				Stream.Seek(0L, SeekOrigin.Begin);
			}
			catch (IOException)
			{
			}
			throw;
		}
		finally
		{
			ArrayPool<byte>.Shared.Return(array);
		}
	}

	public async Task WriteToAsync(Stream stream, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (stream == null)
		{
			throw new ArgumentNullException("stream");
		}
		Stream.Seek(0L, SeekOrigin.Begin);
		byte[] buf = ArrayPool<byte>.Shared.Rent(4096);
		try
		{
			int count;
			while ((count = await Stream.ReadAsync(buf, 0, buf.Length, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)) > 0)
			{
				await stream.WriteAsync(buf, 0, count, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			}
			Stream.Seek(0L, SeekOrigin.Begin);
		}
		catch (OperationCanceledException)
		{
			try
			{
				Stream.Seek(0L, SeekOrigin.Begin);
			}
			catch (IOException)
			{
			}
			throw;
		}
		finally
		{
			ArrayPool<byte>.Shared.Return(buf);
		}
	}

	public void DecodeTo(Stream stream, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (stream == null)
		{
			throw new ArgumentNullException("stream");
		}
		using FilteredStream filteredStream = new FilteredStream(stream);
		filteredStream.Add(DecoderFilter.Create(Encoding));
		WriteTo(filteredStream, cancellationToken);
		filteredStream.Flush(cancellationToken);
	}

	public async Task DecodeToAsync(Stream stream, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (stream == null)
		{
			throw new ArgumentNullException("stream");
		}
		using FilteredStream filtered = new FilteredStream(stream);
		filtered.Add(DecoderFilter.Create(Encoding));
		await WriteToAsync(filtered, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		await filtered.FlushAsync(cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
	}
}
