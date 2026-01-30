using System;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MimeKit.IO;

namespace MailKit.Net.Smtp;

internal class SmtpStream : Stream, ICancellableStream
{
	private static readonly Encoding Latin1;

	private static readonly Encoding UTF8;

	private const int BlockSize = 4096;

	private readonly byte[] input = new byte[4096];

	private readonly byte[] output = new byte[4096];

	private int outputIndex;

	private readonly IProtocolLogger logger;

	private int inputIndex;

	private int inputEnd;

	private bool disposed;

	public Stream Stream { get; internal set; }

	public bool IsConnected { get; private set; }

	public override bool CanRead => Stream.CanRead;

	public override bool CanWrite => Stream.CanWrite;

	public override bool CanSeek => false;

	public override bool CanTimeout => Stream.CanTimeout;

	public override int ReadTimeout
	{
		get
		{
			return Stream.ReadTimeout;
		}
		set
		{
			Stream.ReadTimeout = value;
		}
	}

	public override int WriteTimeout
	{
		get
		{
			return Stream.WriteTimeout;
		}
		set
		{
			Stream.WriteTimeout = value;
		}
	}

	public override long Position
	{
		get
		{
			return Stream.Position;
		}
		set
		{
			throw new NotSupportedException();
		}
	}

	public override long Length => Stream.Length;

	static SmtpStream()
	{
		UTF8 = Encoding.GetEncoding(65001, new EncoderExceptionFallback(), new DecoderExceptionFallback());
		try
		{
			Latin1 = Encoding.GetEncoding(28591);
		}
		catch (NotSupportedException)
		{
			Latin1 = Encoding.GetEncoding(1252);
		}
	}

	public SmtpStream(Stream source, IProtocolLogger protocolLogger)
	{
		logger = protocolLogger;
		IsConnected = true;
		Stream = source;
	}

	private async Task<int> ReadAheadAsync(bool doAsync, CancellationToken cancellationToken)
	{
		int num = inputEnd - inputIndex;
		if (num > 0)
		{
			if (inputIndex > 0)
			{
				Buffer.BlockCopy(input, inputIndex, input, 0, num);
				inputEnd = num;
				inputIndex = 0;
			}
		}
		else
		{
			inputIndex = 0;
			inputEnd = 0;
		}
		num = input.Length - inputEnd;
		int index = inputEnd;
		try
		{
			NetworkStream networkStream = Stream as NetworkStream;
			cancellationToken.ThrowIfCancellationRequested();
			int num2;
			if (doAsync)
			{
				num2 = await Stream.ReadAsync(input, index, num, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			}
			else
			{
				networkStream?.Poll(SelectMode.SelectRead, cancellationToken);
				num2 = Stream.Read(input, index, num);
			}
			if (num2 <= 0)
			{
				throw new SmtpProtocolException("The SMTP server has unexpectedly disconnected.");
			}
			logger.LogServer(input, index, num2);
			inputEnd += num2;
		}
		catch
		{
			IsConnected = false;
			throw;
		}
		return inputEnd - inputIndex;
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
			throw new ObjectDisposedException("SmtpStream");
		}
	}

	public int Read(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		return Read(buffer, offset, count, CancellationToken.None);
	}

	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}

	private static bool TryParseInt32(byte[] text, ref int index, int endIndex, out int value)
	{
		int num = index;
		value = 0;
		while (index < endIndex && text[index] >= 48 && text[index] <= 57)
		{
			value = value * 10 + (text[index++] - 48);
		}
		return index > num;
	}

	private async Task<SmtpResponse> ReadResponseAsync(bool doAsync, CancellationToken cancellationToken)
	{
		CheckDisposed();
		using MemoryStream memory = new MemoryStream();
		bool flag = inputIndex == inputEnd;
		bool newLine = true;
		bool more = true;
		int code = 0;
		bool flag2;
		do
		{
			if (flag)
			{
				await ReadAheadAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				flag = false;
			}
			flag2 = false;
			do
			{
				int num = inputIndex;
				if (newLine && inputIndex < inputEnd)
				{
					if (!TryParseInt32(input, ref inputIndex, inputEnd, out var value))
					{
						throw new SmtpProtocolException("Unable to parse status code returned by the server.");
					}
					if (inputIndex == inputEnd)
					{
						inputIndex = num;
						flag = true;
						break;
					}
					if (code == 0)
					{
						code = value;
					}
					else if (value != code)
					{
						throw new SmtpProtocolException("The status codes returned by the server did not match.");
					}
					newLine = false;
					more = input[inputIndex] != 13 && input[inputIndex] != 10 && input[inputIndex++] == 45;
					num = inputIndex;
				}
				while (inputIndex < inputEnd && input[inputIndex] != 13 && input[inputIndex] != 10)
				{
					inputIndex++;
				}
				memory.Write(input, num, inputIndex - num);
				if (inputIndex < inputEnd && input[inputIndex] == 13)
				{
					inputIndex++;
				}
				if (inputIndex < inputEnd && input[inputIndex] == 10)
				{
					if (more)
					{
						memory.WriteByte(input[inputIndex]);
					}
					flag2 = true;
					newLine = true;
					inputIndex++;
				}
			}
			while (more && inputIndex < inputEnd);
			if (inputIndex == inputEnd)
			{
				flag = true;
			}
		}
		while (more || !flag2);
		string response;
		try
		{
			response = UTF8.GetString(memory.GetBuffer(), 0, (int)memory.Length);
		}
		catch (DecoderFallbackException)
		{
			response = Latin1.GetString(memory.GetBuffer(), 0, (int)memory.Length);
		}
		return new SmtpResponse((SmtpStatusCode)code, response);
	}

	public SmtpResponse ReadResponse(CancellationToken cancellationToken)
	{
		return ReadResponseAsync(doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public Task<SmtpResponse> ReadResponseAsync(CancellationToken cancellationToken)
	{
		return ReadResponseAsync(doAsync: true, cancellationToken);
	}

	private async Task WriteAsync(byte[] buffer, int offset, int count, bool doAsync, CancellationToken cancellationToken)
	{
		CheckDisposed();
		ValidateArguments(buffer, offset, count);
		try
		{
			NetworkStream network = NetworkStream.Get(Stream);
			int index = offset;
			int left = count;
			while (left > 0)
			{
				int num = Math.Min(4096 - outputIndex, left);
				if (outputIndex > 0 || num < 4096)
				{
					Buffer.BlockCopy(buffer, index, output, outputIndex, num);
					outputIndex += num;
					index += num;
					left -= num;
				}
				if (outputIndex == 4096)
				{
					if (doAsync)
					{
						await Stream.WriteAsync(output, 0, 4096, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
					}
					else
					{
						network?.Poll(SelectMode.SelectWrite, cancellationToken);
						Stream.Write(output, 0, 4096);
					}
					logger.LogClient(output, 0, 4096);
					outputIndex = 0;
				}
				if (outputIndex != 0)
				{
					continue;
				}
				while (left >= 4096)
				{
					if (doAsync)
					{
						await Stream.WriteAsync(buffer, index, 4096, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
					}
					else
					{
						network?.Poll(SelectMode.SelectWrite, cancellationToken);
						Stream.Write(buffer, index, 4096);
					}
					logger.LogClient(buffer, index, 4096);
					index += 4096;
					left -= 4096;
				}
			}
		}
		catch (Exception ex)
		{
			IsConnected = false;
			if (!(ex is OperationCanceledException))
			{
				cancellationToken.ThrowIfCancellationRequested();
			}
			throw;
		}
	}

	public void Write(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
	{
		WriteAsync(buffer, offset, count, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		Write(buffer, offset, count, CancellationToken.None);
	}

	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
	{
		return WriteAsync(buffer, offset, count, doAsync: true, cancellationToken);
	}

	private async Task FlushAsync(bool doAsync, CancellationToken cancellationToken)
	{
		CheckDisposed();
		if (outputIndex == 0)
		{
			return;
		}
		try
		{
			if (doAsync)
			{
				await Stream.WriteAsync(output, 0, outputIndex, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				await Stream.FlushAsync(cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			}
			else
			{
				NetworkStream.Get(Stream)?.Poll(SelectMode.SelectWrite, cancellationToken);
				Stream.Write(output, 0, outputIndex);
				Stream.Flush();
			}
			logger.LogClient(output, 0, outputIndex);
			outputIndex = 0;
		}
		catch (Exception ex)
		{
			IsConnected = false;
			if (!(ex is OperationCanceledException))
			{
				cancellationToken.ThrowIfCancellationRequested();
			}
			throw;
		}
	}

	public void Flush(CancellationToken cancellationToken)
	{
		FlushAsync(doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override void Flush()
	{
		Flush(CancellationToken.None);
	}

	public override Task FlushAsync(CancellationToken cancellationToken)
	{
		return FlushAsync(doAsync: true, cancellationToken);
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
			IsConnected = false;
			Stream.Dispose();
		}
		disposed = true;
		base.Dispose(disposing);
	}
}
