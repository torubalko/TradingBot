using System;
using System.Globalization;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MimeKit.IO;

namespace MailKit.Net.Imap;

internal class ImapStream : Stream, ICancellableStream
{
	public const string AtomSpecials = "(){%*\\\"\n";

	public const string DefaultSpecials = "[](){%*\\\"\n";

	private const int ReadAheadSize = 128;

	private const int BlockSize = 4096;

	private const int PadSize = 4;

	private static readonly Encoding Latin1;

	private static readonly Encoding UTF8;

	private readonly byte[] input = new byte[4228];

	private const int inputStart = 128;

	private int inputIndex = 128;

	private int inputEnd = 128;

	private readonly byte[] output = new byte[4096];

	private int outputIndex;

	private readonly IProtocolLogger logger;

	private int literalDataLeft;

	private ImapToken nextToken;

	private bool disposed;

	public Stream Stream { get; internal set; }

	public ImapStreamMode Mode { get; set; }

	public int LiteralLength
	{
		get
		{
			return literalDataLeft;
		}
		internal set
		{
			literalDataLeft = value;
		}
	}

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

	static ImapStream()
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

	public ImapStream(Stream source, IProtocolLogger protocolLogger)
	{
		logger = protocolLogger;
		IsConnected = true;
		Stream = source;
	}

	private async Task<int> ReadAheadAsync(int atleast, bool doAsync, CancellationToken cancellationToken)
	{
		int num = inputEnd - inputIndex;
		if (num >= atleast)
		{
			return num;
		}
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
			NetworkStream network = Stream as NetworkStream;
			cancellationToken.ThrowIfCancellationRequested();
			int num5;
			if (doAsync)
			{
				num5 = await Stream.ReadAsync(input, start, num2 - start, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			}
			else
			{
				network?.Poll(SelectMode.SelectRead, cancellationToken);
				num5 = Stream.Read(input, start, num2 - start);
			}
			if (num5 <= 0)
			{
				throw new ImapProtocolException("The IMAP server has unexpectedly disconnected.");
			}
			logger.LogServer(input, start, num5);
			inputEnd += num5;
			if (network == null)
			{
				cancellationToken.ThrowIfCancellationRequested();
			}
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
			throw new ObjectDisposedException("ImapStream");
		}
	}

	private async Task<int> ReadAsync(byte[] buffer, int offset, int count, bool doAsync, CancellationToken cancellationToken)
	{
		CheckDisposed();
		ValidateArguments(buffer, offset, count);
		if (Mode != ImapStreamMode.Literal)
		{
			return 0;
		}
		count = Math.Min(count, literalDataLeft);
		int num = inputEnd - inputIndex;
		if (num < count && num <= 128)
		{
			await ReadAheadAsync(4096, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		num = inputEnd - inputIndex;
		int num2 = Math.Min(count, num);
		Buffer.BlockCopy(input, inputIndex, buffer, offset, num2);
		literalDataLeft -= num2;
		inputIndex += num2;
		if (literalDataLeft == 0)
		{
			Mode = ImapStreamMode.Token;
		}
		return num2;
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

	private static bool IsAtom(byte c, string specials)
	{
		if (!IsCtrl(c) && !IsWhiteSpace(c))
		{
			return specials.IndexOf((char)c) == -1;
		}
		return false;
	}

	private static bool IsCtrl(byte c)
	{
		if (c > 31)
		{
			return c == 127;
		}
		return true;
	}

	private static bool IsWhiteSpace(byte c)
	{
		if (c != 32 && c != 9)
		{
			return c == 13;
		}
		return true;
	}

	private async Task<ImapToken> ReadQuotedStringTokenAsync(bool doAsync, CancellationToken cancellationToken)
	{
		bool escaped = false;
		inputIndex++;
		using MemoryStream memory = new MemoryStream();
		while (true)
		{
			if (inputIndex < inputEnd && (input[inputIndex] != 34 || escaped))
			{
				if (input[inputIndex] == 92 && !escaped)
				{
					escaped = true;
				}
				else
				{
					memory.WriteByte(input[inputIndex]);
					escaped = false;
				}
				inputIndex++;
			}
			else if (inputIndex + 1 < inputEnd)
			{
				inputIndex++;
				if ("]) \r\n".IndexOf((char)input[inputIndex]) != -1)
				{
					break;
				}
				memory.WriteByte(34);
			}
			else
			{
				await ReadAheadAsync(2, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			}
		}
		byte[] buffer = memory.GetBuffer();
		int count = (int)memory.Length;
		return new ImapToken(ImapTokenType.QString, Encoding.UTF8.GetString(buffer, 0, count));
	}

	private async Task<string> ReadAtomStringAsync(bool flag, string specials, bool doAsync, CancellationToken cancellationToken)
	{
		using MemoryStream memory = new MemoryStream();
		while (true)
		{
			input[inputEnd] = 10;
			if (flag && memory.Length == 0L && input[inputIndex] == 42)
			{
				inputIndex++;
				return "*";
			}
			while (IsAtom(input[inputIndex], specials))
			{
				memory.WriteByte(input[inputIndex++]);
			}
			if (inputIndex < inputEnd)
			{
				break;
			}
			await ReadAheadAsync(1, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		int count = (int)memory.Length;
		byte[] buffer = memory.GetBuffer();
		try
		{
			return UTF8.GetString(buffer, 0, count);
		}
		catch (DecoderFallbackException)
		{
			return Latin1.GetString(buffer, 0, count);
		}
	}

	private async Task<ImapToken> ReadAtomTokenAsync(string specials, bool doAsync, CancellationToken cancellationToken)
	{
		string text = await ReadAtomStringAsync(flag: false, specials, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		return (text == "NIL") ? new ImapToken(ImapTokenType.Nil, text) : new ImapToken(ImapTokenType.Atom, text);
	}

	private async Task<ImapToken> ReadFlagTokenAsync(string specials, bool doAsync, CancellationToken cancellationToken)
	{
		inputIndex++;
		string value = "\\" + await ReadAtomStringAsync(flag: true, specials, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		return new ImapToken(ImapTokenType.Flag, value);
	}

	private async Task<ImapToken> ReadLiteralTokenAsync(bool doAsync, CancellationToken cancellationToken)
	{
		StringBuilder builder = new StringBuilder();
		inputIndex++;
		while (true)
		{
			input[inputEnd] = 125;
			while (input[inputIndex] != 125 && input[inputIndex] != 43)
			{
				builder.Append((char)input[inputIndex++]);
			}
			if (inputIndex < inputEnd)
			{
				break;
			}
			await ReadAheadAsync(1, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		if (input[inputIndex] == 43)
		{
			inputIndex++;
		}
		await ReadAheadAsync(2, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		if (input[inputIndex] != 125)
		{
			while (true)
			{
				input[inputEnd] = 125;
				while (input[inputIndex] != 125)
				{
					inputIndex++;
				}
				if (inputIndex < inputEnd)
				{
					break;
				}
				await ReadAheadAsync(1, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			}
		}
		inputIndex++;
		while (true)
		{
			input[inputEnd] = 10;
			while (input[inputIndex] != 10)
			{
				inputIndex++;
			}
			if (inputIndex < inputEnd)
			{
				break;
			}
			await ReadAheadAsync(1, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		inputIndex++;
		if (!int.TryParse(builder.ToString(), NumberStyles.None, CultureInfo.InvariantCulture, out literalDataLeft) || literalDataLeft < 0)
		{
			return new ImapToken(ImapTokenType.Error, builder.ToString());
		}
		Mode = ImapStreamMode.Literal;
		return new ImapToken(ImapTokenType.Literal, literalDataLeft);
	}

	internal async Task<ImapToken> ReadTokenAsync(string specials, bool doAsync, CancellationToken cancellationToken)
	{
		CheckDisposed();
		if (nextToken != null)
		{
			ImapToken result = nextToken;
			nextToken = null;
			return result;
		}
		input[inputEnd] = 10;
		while (true)
		{
			if (IsWhiteSpace(input[inputIndex]))
			{
				inputIndex++;
				continue;
			}
			if (inputIndex < inputEnd)
			{
				break;
			}
			await ReadAheadAsync(1, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			input[inputEnd] = 10;
		}
		char c = (char)input[inputIndex];
		switch (c)
		{
		case '"':
			return await ReadQuotedStringTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		case '{':
			return await ReadLiteralTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		case '\\':
			return await ReadFlagTokenAsync(specials, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		default:
			if (IsAtom(input[inputIndex], specials))
			{
				return await ReadAtomTokenAsync(specials, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			}
			inputIndex++;
			return new ImapToken((ImapTokenType)c, c);
		}
	}

	internal Task<ImapToken> ReadTokenAsync(bool doAsync, CancellationToken cancellationToken)
	{
		return ReadTokenAsync("[](){%*\\\"\n", doAsync, cancellationToken);
	}

	public ImapToken ReadToken(CancellationToken cancellationToken)
	{
		return ReadTokenAsync(doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public Task<ImapToken> ReadTokenAsync(CancellationToken cancellationToken)
	{
		return ReadTokenAsync(doAsync: true, cancellationToken);
	}

	public void UngetToken(ImapToken token)
	{
		if (token == null)
		{
			throw new ArgumentNullException("token");
		}
		nextToken = token;
	}

	private unsafe async Task<bool> ReadLineAsync(Stream ostream, bool doAsync, CancellationToken cancellationToken)
	{
		CheckDisposed();
		if (inputIndex == inputEnd)
		{
			await ReadAheadAsync(1, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
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
			return false;
		}
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
