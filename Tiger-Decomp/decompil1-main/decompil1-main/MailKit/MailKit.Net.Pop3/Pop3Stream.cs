using System;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using MimeKit.IO;

namespace MailKit.Net.Pop3;

internal class Pop3Stream : Stream, ICancellableStream
{
	private const int ReadAheadSize = 128;

	private const int BlockSize = 4096;

	private const int PadSize = 4;

	private readonly byte[] input = new byte[4228];

	private const int inputStart = 128;

	private readonly byte[] output = new byte[4096];

	private int outputIndex;

	private readonly IProtocolLogger logger;

	private int inputIndex = 128;

	private int inputEnd = 128;

	private Pop3StreamMode mode;

	private bool disposed;

	private bool midline;

	public Stream Stream { get; internal set; }

	public Pop3StreamMode Mode
	{
		get
		{
			return mode;
		}
		set
		{
			IsEndOfData = false;
			mode = value;
		}
	}

	public bool IsConnected { get; private set; }

	public bool IsEndOfData { get; private set; }

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

	public Pop3Stream(Stream source, IProtocolLogger protocolLogger)
	{
		logger = protocolLogger;
		IsConnected = true;
		Stream = source;
	}

	private async Task<int> ReadAheadAsync(bool doAsync, CancellationToken cancellationToken)
	{
		int num = inputEnd - inputIndex;
		int start = 128;
		int num2 = inputEnd;
		if (num > 0)
		{
			int num3 = inputIndex;
			if (num3 >= start)
			{
				start -= Math.Min(128, num);
				Buffer.BlockCopy(input, num3, input, start, num);
				num3 = start;
				start += num;
			}
			else if (num3 > 0)
			{
				int num4 = Math.Min(num3, num2 - start);
				Buffer.BlockCopy(input, num3, input, num3 - num4, num);
				num3 -= num4;
				start = num3 + num;
			}
			else
			{
				start = num2;
			}
			inputIndex = num3;
			inputEnd = start;
		}
		else
		{
			inputIndex = start;
			inputEnd = start;
		}
		num2 = input.Length - 4;
		try
		{
			NetworkStream networkStream = Stream as NetworkStream;
			cancellationToken.ThrowIfCancellationRequested();
			int num5;
			if (doAsync)
			{
				num5 = await Stream.ReadAsync(input, start, num2 - start, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			}
			else
			{
				networkStream?.Poll(SelectMode.SelectRead, cancellationToken);
				num5 = Stream.Read(input, start, num2 - start);
			}
			if (num5 <= 0)
			{
				throw new Pop3ProtocolException("The POP3 server has unexpectedly disconnected.");
			}
			logger.LogServer(input, start, num5);
			inputEnd += num5;
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
			throw new ObjectDisposedException("Pop3Stream");
		}
	}

	private bool NeedInput(int index, int inputLeft)
	{
		if (inputLeft == 2 && input[index] == 46 && input[index + 1] == 10)
		{
			return false;
		}
		return true;
	}

	private async Task<int> ReadAsync(byte[] buffer, int offset, int count, bool doAsync, CancellationToken cancellationToken)
	{
		CheckDisposed();
		ValidateArguments(buffer, offset, count);
		if (Mode != Pop3StreamMode.Data)
		{
			throw new InvalidOperationException();
		}
		if (IsEndOfData || count == 0)
		{
			return 0;
		}
		int end = offset + count;
		int index = offset;
		do
		{
			int num = inputEnd - inputIndex;
			if (num < 3 && (midline || NeedInput(inputIndex, num)))
			{
				if (index > offset)
				{
					break;
				}
				await ReadAheadAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			}
			input[inputEnd] = 10;
			while (inputIndex < inputEnd)
			{
				if (midline)
				{
					while (index < end && input[inputIndex] != 10)
					{
						buffer[index++] = input[inputIndex++];
					}
					if (inputIndex == inputEnd || index == end)
					{
						break;
					}
					buffer[index++] = input[inputIndex++];
					midline = false;
				}
				if (inputIndex == inputEnd)
				{
					break;
				}
				if (input[inputIndex] == 46)
				{
					num = inputEnd - inputIndex;
					if (num >= 3 && input[inputIndex + 1] == 13 && input[inputIndex + 2] == 10)
					{
						IsEndOfData = true;
						midline = false;
						inputIndex += 3;
						break;
					}
					if (num >= 2 && input[inputIndex + 1] == 10)
					{
						IsEndOfData = true;
						midline = false;
						inputIndex += 2;
						break;
					}
					if (num == 1 || (num == 2 && input[inputIndex + 1] == 13))
					{
						break;
					}
					if (input[inputIndex + 1] == 46)
					{
						inputIndex++;
					}
				}
				midline = true;
			}
		}
		while (index < end && !IsEndOfData);
		return index - offset;
	}

	public int Read(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
	{
		return ReadAsync(buffer, offset, count, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		return Read(buffer, offset, count, CancellationToken.None);
	}

	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
	{
		return ReadAsync(buffer, offset, count, doAsync: true, cancellationToken);
	}

	private unsafe async Task<bool> ReadLineAsync(Stream ostream, bool doAsync, CancellationToken cancellationToken)
	{
		CheckDisposed();
		if (inputIndex == inputEnd)
		{
			await ReadAheadAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		byte[] array = input;
		/*pinned*/byte[] array2 = array;
		byte* ptr = (byte*)((array != null && array2.Length != 0) ? System.Runtime.CompilerServices.Unsafe.AsPointer(ref array2[0]) : null);
		int offset = inputIndex;
		byte* ptr2 = ptr + inputIndex;
		byte* ptr3 = ptr + inputEnd;
		*ptr3 = 10;
		byte* ptr4;
		for (ptr4 = ptr2; *ptr4 != 10; ptr4++)
		{
		}
		inputIndex = (int)(ptr4 - ptr);
		int num = (int)(ptr4 - ptr2);
		if (ptr4 == ptr3)
		{
			ostream.Write(input, offset, num);
			midline = true;
			return false;
		}
		midline = false;
		inputIndex++;
		num++;
		ostream.Write(input, offset, num);
		return true;
	}

	internal bool ReadLine(Stream ostream, CancellationToken cancellationToken)
	{
		return ReadLineAsync(ostream, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	internal Task<bool> ReadLineAsync(Stream ostream, CancellationToken cancellationToken)
	{
		return ReadLineAsync(ostream, doAsync: true, cancellationToken);
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
		IsEndOfData = false;
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
