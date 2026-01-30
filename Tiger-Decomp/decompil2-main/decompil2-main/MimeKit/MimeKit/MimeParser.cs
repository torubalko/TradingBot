using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MimeKit.IO;
using MimeKit.Utils;

namespace MimeKit;

public class MimeParser : IEnumerable<MimeMessage>, IEnumerable
{
	private class ScanContentResult
	{
		public readonly NewLineFormat? Format;

		public readonly bool IsEmpty;

		public ScanContentResult(bool[] formats, bool isEmpty)
		{
			if (formats[0] && formats[1])
			{
				Format = NewLineFormat.Mixed;
			}
			else if (formats[0])
			{
				Format = NewLineFormat.Unix;
			}
			else if (formats[1])
			{
				Format = NewLineFormat.Dos;
			}
			else
			{
				Format = null;
			}
			IsEmpty = isEmpty;
		}
	}

	private static readonly byte[] UTF8ByteOrderMark = new byte[3] { 239, 187, 191 };

	private const int ReadAheadSize = 128;

	private const int BlockSize = 4096;

	private const int PadSize = 4;

	private readonly byte[] input = new byte[4228];

	private const int inputStart = 128;

	private int inputIndex = 128;

	private int inputEnd = 128;

	private byte[] mboxMarkerBuffer;

	private long mboxMarkerOffset;

	private int mboxMarkerLength;

	private byte[] preHeaderBuffer = new byte[128];

	private int preHeaderLength;

	private byte[] headerBuffer = new byte[512];

	private long headerOffset;

	private int headerIndex;

	private readonly List<Boundary> bounds = new List<Boundary>();

	private readonly List<Header> headers = new List<Header>();

	private MimeParserState state;

	private BoundaryType boundary;

	private MimeFormat format;

	private bool persistent;

	private bool toplevel;

	private bool eos;

	private ParserOptions options;

	private long headerBlockBegin;

	private long headerBlockEnd;

	private long contentEnd;

	private long prevLineBeginOffset;

	private long lineBeginOffset;

	private int lineNumber;

	private Stream stream;

	private long position;

	public bool IsEndOfStream => state == MimeParserState.Eos;

	public long Position => GetOffset(inputIndex);

	public long MboxMarkerOffset => mboxMarkerOffset;

	public string MboxMarker => Encoding.UTF8.GetString(mboxMarkerBuffer, 0, mboxMarkerLength);

	public event EventHandler<MimeMessageBeginEventArgs> MimeMessageBegin;

	public event EventHandler<MimeMessageEndEventArgs> MimeMessageEnd;

	public event EventHandler<MimeEntityBeginEventArgs> MimeEntityBegin;

	public event EventHandler<MimeEntityEndEventArgs> MimeEntityEnd;

	private async Task<int> ReadAheadAsync(int atleast, int save, CancellationToken cancellationToken)
	{
		if (!AlignReadAheadBuffer(atleast, save, out var left, out var start, out var end))
		{
			return left;
		}
		int num = await stream.ReadAsync(input, start, end - start, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		if (num > 0)
		{
			inputEnd += num;
			position += num;
		}
		else
		{
			eos = true;
		}
		return inputEnd - inputIndex;
	}

	private unsafe async Task<bool> StepByteOrderMarkAsync(CancellationToken cancellationToken)
	{
		int bomIndex = 0;
		do
		{
			if (await ReadAheadAsync(128, 0, cancellationToken).ConfigureAwait(continueOnCapturedContext: false) <= 0)
			{
				inputIndex = inputEnd;
				return false;
			}
			byte[] array = input;
			/*pinned*/byte[] array2 = array;
			byte* inbuf = (byte*)((array != null && array2.Length != 0) ? System.Runtime.CompilerServices.Unsafe.AsPointer(ref array2[0]) : null);
			StepByteOrderMark(inbuf, ref bomIndex);
			array2 = null;
		}
		while (inputIndex == inputEnd);
		return bomIndex == 0 || bomIndex == UTF8ByteOrderMark.Length;
	}

	private unsafe async Task StepMboxMarkerAsync(CancellationToken cancellationToken)
	{
		int left = 0;
		mboxMarkerLength = 0;
		bool flag;
		do
		{
			if (await ReadAheadAsync(Math.Max(128, left), 0, cancellationToken).ConfigureAwait(continueOnCapturedContext: false) <= left)
			{
				state = MimeParserState.Error;
				inputIndex = inputEnd;
				return;
			}
			byte[] array = input;
			/*pinned*/byte[] array2 = array;
			byte* inbuf = (byte*)((array != null && array2.Length != 0) ? System.Runtime.CompilerServices.Unsafe.AsPointer(ref array2[0]) : null);
			flag = StepMboxMarker(inbuf, ref left);
			array2 = null;
		}
		while (!flag);
		state = MimeParserState.MessageHeaders;
	}

	private unsafe async Task StepHeadersAsync(CancellationToken cancellationToken)
	{
		bool scanningFieldName = true;
		bool checkFolded = false;
		bool midline = false;
		bool blank = false;
		bool valid = true;
		int left = 0;
		headerBlockBegin = GetOffset(inputIndex);
		boundary = BoundaryType.None;
		ResetRawHeaderData();
		headers.Clear();
		await ReadAheadAsync(Math.Max(128, left), 0, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		while (true)
		{
			byte[] array2;
			try
			{
				byte[] array = input;
				array2 = array;
				byte* inbuf = (byte*)((array != null && array2.Length != 0) ? System.Runtime.CompilerServices.Unsafe.AsPointer(ref array2[0]) : null);
				if (!StepHeaders(inbuf, ref scanningFieldName, ref checkFolded, ref midline, ref blank, ref valid, ref left))
				{
					break;
				}
			}
			finally
			{
				array2 = null;
			}
			if (await ReadAheadAsync(left + 1, 0, cancellationToken).ConfigureAwait(continueOnCapturedContext: false) != left)
			{
				continue;
			}
			if (scanningFieldName && left > 0)
			{
				state = MimeParserState.Error;
				break;
			}
			if (left > 0)
			{
				AppendRawHeaderData(inputIndex, left);
				inputIndex = inputEnd;
			}
			ParseAndAppendHeader();
			state = MimeParserState.Content;
			break;
		}
		headerBlockEnd = GetOffset(inputIndex);
	}

	private unsafe async Task<bool> SkipLineAsync(bool consumeNewLine, CancellationToken cancellationToken)
	{
		do
		{
			byte[] array = input;
			/*pinned*/byte[] array2 = array;
			byte* inbuf = (byte*)((array != null && array2.Length != 0) ? System.Runtime.CompilerServices.Unsafe.AsPointer(ref array2[0]) : null);
			if (SkipLine(inbuf, consumeNewLine))
			{
				return true;
			}
			array2 = null;
		}
		while (await ReadAheadAsync(128, 1, cancellationToken).ConfigureAwait(continueOnCapturedContext: false) > 0);
		return false;
	}

	private async Task<MimeParserState> StepAsync(CancellationToken cancellationToken)
	{
		switch (state)
		{
		case MimeParserState.Initialized:
			if (!(await StepByteOrderMarkAsync(cancellationToken).ConfigureAwait(continueOnCapturedContext: false)))
			{
				state = MimeParserState.Eos;
			}
			else
			{
				state = ((format == MimeFormat.Mbox) ? MimeParserState.MboxMarker : MimeParserState.MessageHeaders);
			}
			break;
		case MimeParserState.MboxMarker:
			await StepMboxMarkerAsync(cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			break;
		case MimeParserState.MessageHeaders:
		case MimeParserState.Headers:
			await StepHeadersAsync(cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			toplevel = false;
			break;
		}
		return state;
	}

	private unsafe async Task<ScanContentResult> ScanContentAsync(Stream content, bool trimNewLine, CancellationToken cancellationToken)
	{
		int atleast = Math.Max(128, GetMaxBoundaryLength());
		int contentIndex = inputIndex;
		bool[] formats = new bool[2];
		bool midline = false;
		do
		{
			if (contentIndex < inputIndex)
			{
				content.Write(input, contentIndex, inputIndex - contentIndex);
			}
			int nleft = inputEnd - inputIndex;
			if (await ReadAheadAsync(atleast, 2, cancellationToken).ConfigureAwait(continueOnCapturedContext: false) <= 0)
			{
				boundary = BoundaryType.Eos;
				contentIndex = inputIndex;
				break;
			}
			byte[] array = input;
			/*pinned*/byte[] array2 = array;
			byte* inbuf = (byte*)((array != null && array2.Length != 0) ? System.Runtime.CompilerServices.Unsafe.AsPointer(ref array2[0]) : null);
			ScanContent(inbuf, ref contentIndex, ref nleft, ref midline, ref formats);
			array2 = null;
		}
		while (boundary == BoundaryType.None);
		if (contentIndex < inputIndex)
		{
			content.Write(input, contentIndex, inputIndex - contentIndex);
		}
		bool isEmpty = content.Length == 0;
		if (boundary != BoundaryType.Eos && trimNewLine && content.Length > 0)
		{
			if (input[inputIndex - 2] == 13)
			{
				content.SetLength(content.Length - 2);
			}
			else
			{
				content.SetLength(content.Length - 1);
			}
		}
		return new ScanContentResult(formats, isEmpty);
	}

	private async Task ConstructMimePartAsync(MimePart part, MimeEntityEndEventArgs args, CancellationToken cancellationToken)
	{
		long beginOffset = GetOffset(inputIndex);
		int beginLineNumber = lineNumber;
		ScanContentResult scanContentResult;
		long num;
		Stream content;
		if (persistent)
		{
			using (MeasuringStream measured = new MeasuringStream())
			{
				scanContentResult = await ScanContentAsync(measured, trimNewLine: true, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				num = beginOffset + measured.Length;
			}
			content = new BoundStream(stream, beginOffset, num, leaveOpen: true);
		}
		else
		{
			content = new MemoryBlockStream();
			try
			{
				scanContentResult = await ScanContentAsync(content, trimNewLine: true, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				content.Seek(0L, SeekOrigin.Begin);
			}
			catch
			{
				content.Dispose();
				throw;
			}
			num = beginOffset + content.Length;
		}
		args.Lines = GetLineCount(beginLineNumber, beginOffset, num);
		if (!scanContentResult.IsEmpty)
		{
			part.Content = new MimeContent(content, part.ContentTransferEncoding)
			{
				NewLineFormat = scanContentResult.Format
			};
		}
		else
		{
			content.Dispose();
		}
	}

	private unsafe async Task ConstructMessagePartAsync(MessagePart rfc822, MimeEntityEndEventArgs args, int depth, CancellationToken cancellationToken)
	{
		long beginOffset = GetOffset(inputIndex);
		int beginLineNumber = lineNumber;
		if (bounds.Count > 0)
		{
			int atleast = Math.Max(128, GetMaxBoundaryLength());
			if (await ReadAheadAsync(atleast, 0, cancellationToken).ConfigureAwait(continueOnCapturedContext: false) <= 0)
			{
				boundary = BoundaryType.Eos;
				return;
			}
			byte[] array = input;
			/*pinned*/byte[] array2 = array;
			byte* ptr = (byte*)((array != null && array2.Length != 0) ? System.Runtime.CompilerServices.Unsafe.AsPointer(ref array2[0]) : null);
			byte* ptr2 = ptr + inputIndex;
			byte* ptr3 = ptr + inputEnd;
			byte* ptr4 = ptr2;
			*ptr3 = 10;
			for (; *ptr4 != 10; ptr4++)
			{
			}
			boundary = CheckBoundary(inputIndex, ptr2, (int)(ptr4 - ptr2));
			switch (boundary)
			{
			case BoundaryType.ImmediateBoundary:
			case BoundaryType.ImmediateEndBoundary:
			case BoundaryType.ParentBoundary:
				return;
			case BoundaryType.ParentEndBoundary:
				if (!IsMboxMarker(ptr2))
				{
					return;
				}
				break;
			}
			array2 = null;
		}
		state = MimeParserState.MessageHeaders;
		if (await StepAsync(cancellationToken).ConfigureAwait(continueOnCapturedContext: false) == MimeParserState.Error)
		{
			boundary = BoundaryType.Eos;
			return;
		}
		MimeMessage message = new MimeMessage(options, headers, RfcComplianceMode.Loose);
		MimeMessageEndEventArgs messageArgs = new MimeMessageEndEventArgs(message, rfc822)
		{
			HeadersEndOffset = headerBlockEnd,
			BeginOffset = headerBlockBegin,
			LineNumber = beginLineNumber
		};
		OnMimeMessageBegin(messageArgs);
		if (preHeaderBuffer.Length != 0)
		{
			message.MboxMarker = new byte[preHeaderLength];
			Buffer.BlockCopy(preHeaderBuffer, 0, message.MboxMarker, 0, preHeaderLength);
		}
		ContentType contentType = GetContentType(null);
		MimeEntity mimeEntity = options.CreateEntity(contentType, headers, toplevel: true, depth);
		MimeEntityEndEventArgs entityArgs = new MimeEntityEndEventArgs(mimeEntity)
		{
			HeadersEndOffset = headerBlockEnd,
			BeginOffset = headerBlockBegin,
			LineNumber = beginLineNumber
		};
		OnMimeEntityBegin(entityArgs);
		message.Body = mimeEntity;
		if (mimeEntity is Multipart)
		{
			await ConstructMultipartAsync((Multipart)mimeEntity, entityArgs, depth + 1, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		else if (!(mimeEntity is MessagePart))
		{
			await ConstructMimePartAsync((MimePart)mimeEntity, entityArgs, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		else
		{
			await ConstructMessagePartAsync((MessagePart)mimeEntity, entityArgs, depth + 1, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		rfc822.Message = message;
		long endOffset = GetEndOffset(inputIndex);
		long headersEndOffset = (entityArgs.HeadersEndOffset = Math.Min(entityArgs.HeadersEndOffset, endOffset));
		messageArgs.HeadersEndOffset = headersEndOffset;
		headersEndOffset = (entityArgs.EndOffset = endOffset);
		messageArgs.EndOffset = headersEndOffset;
		OnMimeEntityEnd(entityArgs);
		OnMimeMessageEnd(messageArgs);
		args.Lines = GetLineCount(beginLineNumber, beginOffset, endOffset);
	}

	private async Task MultipartScanPreambleAsync(Multipart multipart, CancellationToken cancellationToken)
	{
		using MemoryStream memory = new MemoryStream();
		GetOffset(inputIndex);
		await ScanContentAsync(memory, trimNewLine: false, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		multipart.RawPreamble = memory.ToArray();
	}

	private async Task MultipartScanEpilogueAsync(Multipart multipart, CancellationToken cancellationToken)
	{
		using MemoryStream memory = new MemoryStream();
		GetOffset(inputIndex);
		multipart.RawEpilogue = ((await ScanContentAsync(memory, trimNewLine: true, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).IsEmpty ? null : memory.ToArray());
	}

	private async Task MultipartScanSubpartsAsync(Multipart multipart, int depth, CancellationToken cancellationToken)
	{
		do
		{
			if (!(await SkipLineAsync(consumeNewLine: true, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)))
			{
				boundary = BoundaryType.Eos;
				break;
			}
			int beginLineNumber = lineNumber;
			state = MimeParserState.Headers;
			if (await StepAsync(cancellationToken).ConfigureAwait(continueOnCapturedContext: false) == MimeParserState.Error)
			{
				boundary = BoundaryType.Eos;
				break;
			}
			if (state == MimeParserState.Boundary && headers.Count == 0)
			{
				if (boundary != BoundaryType.ImmediateBoundary)
				{
					break;
				}
				continue;
			}
			ContentType contentType = GetContentType(multipart.ContentType);
			MimeEntity entity = options.CreateEntity(contentType, headers, toplevel: false, depth);
			MimeEntityEndEventArgs entityArgs = new MimeEntityEndEventArgs(entity, multipart)
			{
				HeadersEndOffset = headerBlockEnd,
				BeginOffset = headerBlockBegin,
				LineNumber = beginLineNumber
			};
			OnMimeEntityBegin(entityArgs);
			if (entity is Multipart)
			{
				await ConstructMultipartAsync((Multipart)entity, entityArgs, depth + 1, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			}
			else if (!(entity is MessagePart))
			{
				await ConstructMimePartAsync((MimePart)entity, entityArgs, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			}
			else
			{
				await ConstructMessagePartAsync((MessagePart)entity, entityArgs, depth + 1, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			}
			long endOffset = GetEndOffset(inputIndex);
			entityArgs.HeadersEndOffset = Math.Min(entityArgs.HeadersEndOffset, endOffset);
			entityArgs.EndOffset = endOffset;
			OnMimeEntityEnd(entityArgs);
			multipart.Add(entity);
		}
		while (boundary == BoundaryType.ImmediateBoundary);
	}

	private unsafe async Task ConstructMultipartAsync(Multipart multipart, MimeEntityEndEventArgs args, int depth, CancellationToken cancellationToken)
	{
		long beginOffset = GetOffset(inputIndex);
		int beginLineNumber = lineNumber;
		string text = multipart.Boundary;
		long endOffset;
		if (text == null)
		{
			await MultipartScanPreambleAsync(multipart, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			endOffset = GetEndOffset(inputIndex);
			args.Lines = GetLineCount(beginLineNumber, beginOffset, endOffset);
			return;
		}
		PushBoundary(text);
		await MultipartScanPreambleAsync(multipart, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		if (boundary == BoundaryType.ImmediateBoundary)
		{
			await MultipartScanSubpartsAsync(multipart, depth, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		if (boundary == BoundaryType.ImmediateEndBoundary)
		{
			multipart.WriteEndBoundary = true;
			await SkipLineAsync(consumeNewLine: false, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			PopBoundary();
			await MultipartScanEpilogueAsync(multipart, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			endOffset = GetEndOffset(inputIndex);
			args.Lines = GetLineCount(beginLineNumber, beginOffset, endOffset);
			return;
		}
		endOffset = GetEndOffset(inputIndex);
		args.Lines = GetLineCount(beginLineNumber, beginOffset, endOffset);
		multipart.WriteEndBoundary = false;
		PopBoundary();
		byte[] array = input;
		/*pinned*/byte[] array2 = array;
		byte* inbuf = (byte*)((array != null && array2.Length != 0) ? System.Runtime.CompilerServices.Unsafe.AsPointer(ref array2[0]) : null);
		if (boundary == BoundaryType.ParentEndBoundary && FoundImmediateBoundary(inbuf, final: true))
		{
			boundary = BoundaryType.ImmediateEndBoundary;
		}
		else if (boundary == BoundaryType.ParentBoundary && FoundImmediateBoundary(inbuf, final: false))
		{
			boundary = BoundaryType.ImmediateBoundary;
		}
		array2 = null;
	}

	public async Task<HeaderList> ParseHeadersAsync(CancellationToken cancellationToken = default(CancellationToken))
	{
		state = MimeParserState.Headers;
		if (await StepAsync(cancellationToken).ConfigureAwait(continueOnCapturedContext: false) == MimeParserState.Error)
		{
			throw new FormatException("Failed to parse headers.");
		}
		state = (eos ? MimeParserState.Eos : MimeParserState.Complete);
		HeaderList headerList = new HeaderList(options);
		foreach (Header header in headers)
		{
			headerList.Add(header);
		}
		return headerList;
	}

	public async Task<MimeEntity> ParseEntityAsync(CancellationToken cancellationToken = default(CancellationToken))
	{
		if (persistent && stream.Position != position)
		{
			stream.Seek(position, SeekOrigin.Begin);
		}
		int beginLineNumber = lineNumber;
		state = MimeParserState.Headers;
		toplevel = true;
		if (await StepAsync(cancellationToken).ConfigureAwait(continueOnCapturedContext: false) == MimeParserState.Error)
		{
			throw new FormatException("Failed to parse entity headers.");
		}
		ContentType contentType = GetContentType(null);
		MimeEntity entity = options.CreateEntity(contentType, headers, toplevel: false, 0);
		MimeEntityEndEventArgs entityArgs = new MimeEntityEndEventArgs(entity)
		{
			HeadersEndOffset = headerBlockEnd,
			BeginOffset = headerBlockBegin,
			LineNumber = beginLineNumber
		};
		OnMimeEntityBegin(entityArgs);
		if (entity is Multipart)
		{
			await ConstructMultipartAsync((Multipart)entity, entityArgs, 0, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		else if (!(entity is MessagePart))
		{
			await ConstructMimePartAsync((MimePart)entity, entityArgs, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		else
		{
			await ConstructMessagePartAsync((MessagePart)entity, entityArgs, 0, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		long endOffset = GetEndOffset(inputIndex);
		entityArgs.HeadersEndOffset = Math.Min(entityArgs.HeadersEndOffset, endOffset);
		entityArgs.EndOffset = endOffset;
		if (boundary != BoundaryType.Eos)
		{
			state = MimeParserState.Complete;
		}
		else
		{
			state = MimeParserState.Eos;
		}
		OnMimeEntityEnd(entityArgs);
		return entity;
	}

	public async Task<MimeMessage> ParseMessageAsync(CancellationToken cancellationToken = default(CancellationToken))
	{
		if (persistent && stream.Position != position)
		{
			stream.Seek(position, SeekOrigin.Begin);
		}
		while (state != MimeParserState.MessageHeaders)
		{
			switch (await StepAsync(cancellationToken).ConfigureAwait(continueOnCapturedContext: false))
			{
			case MimeParserState.Error:
				throw new FormatException("Failed to find mbox From marker.");
			case MimeParserState.Eos:
				throw new FormatException("End of stream.");
			}
		}
		toplevel = true;
		int beginLineNumber = lineNumber;
		bool flag = state < MimeParserState.Content;
		bool flag2 = flag;
		if (flag2)
		{
			flag2 = await StepAsync(cancellationToken).ConfigureAwait(continueOnCapturedContext: false) == MimeParserState.Error;
		}
		if (flag2)
		{
			throw new FormatException("Failed to parse message headers.");
		}
		MimeMessage message = new MimeMessage(options, headers, RfcComplianceMode.Loose);
		MimeMessageEndEventArgs messageArgs = new MimeMessageEndEventArgs(message)
		{
			HeadersEndOffset = headerBlockEnd,
			BeginOffset = headerBlockBegin,
			LineNumber = beginLineNumber
		};
		OnMimeMessageBegin(messageArgs);
		if (format == MimeFormat.Mbox && options.RespectContentLength)
		{
			contentEnd = 0L;
			for (int i = 0; i < headers.Count; i++)
			{
				if (headers[i].Id == HeaderId.ContentLength)
				{
					byte[] rawValue = headers[i].RawValue;
					int index = 0;
					if (ParseUtils.SkipWhiteSpace(rawValue, ref index, rawValue.Length) && ParseUtils.TryParseInt32(rawValue, ref index, rawValue.Length, out var value))
					{
						contentEnd = GetOffset(inputIndex) + value;
						break;
					}
				}
			}
		}
		ContentType contentType = GetContentType(null);
		MimeEntity mimeEntity = options.CreateEntity(contentType, headers, toplevel: true, 0);
		MimeEntityEndEventArgs entityArgs = new MimeEntityEndEventArgs(mimeEntity)
		{
			HeadersEndOffset = headerBlockEnd,
			BeginOffset = headerBlockBegin,
			LineNumber = beginLineNumber
		};
		OnMimeEntityBegin(entityArgs);
		message.Body = mimeEntity;
		if (mimeEntity is Multipart)
		{
			await ConstructMultipartAsync((Multipart)mimeEntity, entityArgs, 0, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		else if (!(mimeEntity is MessagePart))
		{
			await ConstructMimePartAsync((MimePart)mimeEntity, entityArgs, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		else
		{
			await ConstructMessagePartAsync((MessagePart)mimeEntity, entityArgs, 0, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		long endOffset = GetEndOffset(inputIndex);
		long headersEndOffset = (entityArgs.HeadersEndOffset = Math.Min(entityArgs.HeadersEndOffset, endOffset));
		messageArgs.HeadersEndOffset = headersEndOffset;
		headersEndOffset = (entityArgs.EndOffset = endOffset);
		messageArgs.EndOffset = headersEndOffset;
		if (boundary != BoundaryType.Eos)
		{
			if (format == MimeFormat.Mbox)
			{
				state = MimeParserState.MboxMarker;
			}
			else
			{
				state = MimeParserState.Complete;
			}
		}
		else
		{
			state = MimeParserState.Eos;
		}
		OnMimeEntityEnd(entityArgs);
		OnMimeMessageEnd(messageArgs);
		return message;
	}

	public MimeParser(Stream stream, MimeFormat format, bool persistent = false)
		: this(ParserOptions.Default, stream, format, persistent)
	{
	}

	public MimeParser(Stream stream, bool persistent = false)
		: this(ParserOptions.Default, stream, MimeFormat.Entity, persistent)
	{
	}

	public MimeParser(ParserOptions options, Stream stream, bool persistent = false)
		: this(options, stream, MimeFormat.Entity, persistent)
	{
	}

	public MimeParser(ParserOptions options, Stream stream, MimeFormat format, bool persistent = false)
	{
		SetStream(options, stream, format, persistent);
	}

	public void SetStream(ParserOptions options, Stream stream, MimeFormat format, bool persistent = false)
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (stream == null)
		{
			throw new ArgumentNullException("stream");
		}
		this.persistent = persistent && stream.CanSeek;
		this.options = options.Clone();
		this.format = format;
		this.stream = stream;
		inputIndex = 128;
		inputEnd = 128;
		mboxMarkerOffset = 0L;
		mboxMarkerLength = 0;
		headerBlockBegin = 0L;
		headerBlockEnd = 0L;
		lineNumber = 1;
		contentEnd = 0L;
		position = (stream.CanSeek ? stream.Position : 0);
		prevLineBeginOffset = position;
		lineBeginOffset = position;
		preHeaderLength = 0;
		headers.Clear();
		headerOffset = 0L;
		headerIndex = 0;
		toplevel = false;
		eos = false;
		bounds.Clear();
		if (format == MimeFormat.Mbox)
		{
			bounds.Add(Boundary.CreateMboxBoundary());
			if (mboxMarkerBuffer == null)
			{
				mboxMarkerBuffer = new byte[128];
			}
		}
		state = MimeParserState.Initialized;
		boundary = BoundaryType.None;
	}

	public void SetStream(ParserOptions options, Stream stream, bool persistent = false)
	{
		SetStream(options, stream, MimeFormat.Entity, persistent);
	}

	public void SetStream(Stream stream, MimeFormat format, bool persistent = false)
	{
		SetStream(ParserOptions.Default, stream, format, persistent);
	}

	public void SetStream(Stream stream, bool persistent = false)
	{
		SetStream(ParserOptions.Default, stream, MimeFormat.Entity, persistent);
	}

	protected virtual void OnMimeMessageBegin(MimeMessageBeginEventArgs args)
	{
		this.MimeMessageBegin?.Invoke(this, args);
	}

	protected virtual void OnMimeMessageEnd(MimeMessageEndEventArgs args)
	{
		this.MimeMessageEnd?.Invoke(this, args);
	}

	protected virtual void OnMimeEntityBegin(MimeEntityBeginEventArgs args)
	{
		this.MimeEntityBegin?.Invoke(this, args);
	}

	protected virtual void OnMimeEntityEnd(MimeEntityEndEventArgs args)
	{
		this.MimeEntityEnd?.Invoke(this, args);
	}

	private static int NextAllocSize(int need)
	{
		return (need + 63) & -64;
	}

	private bool AlignReadAheadBuffer(int atleast, int save, out int left, out int start, out int end)
	{
		left = inputEnd - inputIndex;
		start = 128;
		end = inputEnd;
		if (left >= atleast || eos)
		{
			return false;
		}
		left += save;
		if (left > 0)
		{
			int num = inputIndex - save;
			if (num >= start)
			{
				start -= Math.Min(128, left);
				Buffer.BlockCopy(input, num, input, start, left);
				num = start;
				start += left;
			}
			else if (num > 0)
			{
				int num2 = Math.Min(num, end - start);
				Buffer.BlockCopy(input, num, input, num - num2, left);
				num -= num2;
				start = num + left;
			}
			else
			{
				start = end;
			}
			inputIndex = num + save;
			inputEnd = start;
		}
		else
		{
			inputIndex = start;
			inputEnd = start;
		}
		end = input.Length - 4;
		return true;
	}

	private int ReadAhead(int atleast, int save, CancellationToken cancellationToken)
	{
		if (!AlignReadAheadBuffer(atleast, save, out var left, out var start, out var end))
		{
			return left;
		}
		int num;
		if (stream is ICancellableStream cancellableStream)
		{
			num = cancellableStream.Read(input, start, end - start, cancellationToken);
		}
		else
		{
			cancellationToken.ThrowIfCancellationRequested();
			num = stream.Read(input, start, end - start);
		}
		if (num > 0)
		{
			inputEnd += num;
			position += num;
		}
		else
		{
			eos = true;
		}
		return inputEnd - inputIndex;
	}

	private long GetOffset(int index)
	{
		if (position == -1)
		{
			return -1L;
		}
		return position - (inputEnd - index);
	}

	private long GetEndOffset(int index)
	{
		if (boundary != BoundaryType.Eos && index > 1 && input[index - 1] == 10)
		{
			index--;
			if (index > 1 && input[index - 1] == 13)
			{
				index--;
			}
		}
		return GetOffset(index);
	}

	private int GetLineCount(int beginLineNumber, long beginOffset, long endOffset)
	{
		int num = lineNumber - beginLineNumber;
		if (lineBeginOffset >= beginOffset && endOffset > lineBeginOffset)
		{
			num++;
		}
		if (boundary != BoundaryType.Eos && endOffset == prevLineBeginOffset)
		{
			num--;
		}
		return num;
	}

	private unsafe static bool CStringsEqual(byte* str1, byte* str2, int length)
	{
		byte* ptr = str1 + length;
		byte* ptr2 = str1;
		byte* ptr3 = str2;
		while (ptr2 < ptr)
		{
			if (*(ptr2++) != *(ptr3++))
			{
				return false;
			}
		}
		return true;
	}

	private unsafe void StepByteOrderMark(byte* inbuf, ref int bomIndex)
	{
		byte* ptr = inbuf + inputIndex;
		for (byte* ptr2 = inbuf + inputEnd; ptr < ptr2; ptr++)
		{
			if (bomIndex >= UTF8ByteOrderMark.Length)
			{
				break;
			}
			if (*ptr != UTF8ByteOrderMark[bomIndex])
			{
				break;
			}
			bomIndex++;
		}
		inputIndex = (int)(ptr - inbuf);
	}

	private unsafe bool StepByteOrderMark(byte* inbuf, CancellationToken cancellationToken)
	{
		int bomIndex = 0;
		do
		{
			int num = ReadAhead(128, 0, cancellationToken);
			if (num <= 0)
			{
				inputIndex = inputEnd;
				return false;
			}
			StepByteOrderMark(inbuf, ref bomIndex);
		}
		while (inputIndex == inputEnd);
		if (bomIndex != 0)
		{
			return bomIndex == UTF8ByteOrderMark.Length;
		}
		return true;
	}

	private unsafe static bool IsMboxMarker(byte* text, bool allowMunged = false)
	{
		byte* ptr = text;
		if (allowMunged && *ptr == 62)
		{
			ptr++;
		}
		if (*(ptr++) == 70 && *(ptr++) == 114 && *(ptr++) == 111 && *(ptr++) == 109)
		{
			return *ptr == 32;
		}
		return false;
	}

	private unsafe bool StepMboxMarker(byte* inbuf, ref int left)
	{
		byte* ptr = inbuf + inputIndex;
		byte* ptr2 = inbuf + inputEnd;
		*ptr2 = 10;
		while (ptr < ptr2)
		{
			int num = inputIndex;
			byte* ptr3 = ptr;
			for (; *ptr != 10; ptr++)
			{
			}
			int num2 = (int)(ptr - ptr3);
			if (ptr > ptr3 && *(ptr - 1) == 13)
			{
				num2--;
			}
			ptr++;
			int num3 = (int)(ptr - ptr3);
			if (ptr >= ptr2)
			{
				left = num3;
				return false;
			}
			inputIndex += num3;
			prevLineBeginOffset = lineBeginOffset;
			lineBeginOffset = GetOffset(inputIndex);
			lineNumber++;
			if (num2 >= 5 && IsMboxMarker(ptr3))
			{
				mboxMarkerOffset = GetOffset(num);
				mboxMarkerLength = num2;
				if (mboxMarkerBuffer.Length < mboxMarkerLength)
				{
					Array.Resize(ref mboxMarkerBuffer, mboxMarkerLength);
				}
				Buffer.BlockCopy(input, num, mboxMarkerBuffer, 0, num2);
				return true;
			}
		}
		left = 0;
		return false;
	}

	private unsafe void StepMboxMarker(byte* inbuf, CancellationToken cancellationToken)
	{
		int left = 0;
		mboxMarkerLength = 0;
		do
		{
			int num = ReadAhead(Math.Max(128, left), 0, cancellationToken);
			if (num <= left)
			{
				state = MimeParserState.Error;
				inputIndex = inputEnd;
				return;
			}
		}
		while (!StepMboxMarker(inbuf, ref left));
		state = MimeParserState.MessageHeaders;
	}

	private void AppendRawHeaderData(int startIndex, int length)
	{
		int num = headerBuffer.Length - headerIndex;
		if (num < length)
		{
			Array.Resize(ref headerBuffer, NextAllocSize(headerIndex + length));
		}
		Buffer.BlockCopy(input, startIndex, headerBuffer, headerIndex, length);
		headerIndex += length;
	}

	private void ResetRawHeaderData()
	{
		preHeaderLength = 0;
		headerIndex = 0;
	}

	private unsafe void ParseAndAppendHeader()
	{
		if (headerIndex == 0)
		{
			return;
		}
		fixed (byte* ptr = headerBuffer)
		{
			if (Header.TryParse(options, ptr, headerIndex, strict: false, out var header))
			{
				header.Offset = headerOffset;
				headers.Add(header);
				headerIndex = 0;
			}
		}
	}

	private static bool IsControl(byte c)
	{
		return c.IsCtrl();
	}

	private static bool IsBlank(byte c)
	{
		return c.IsBlank();
	}

	private unsafe static bool IsEoln(byte* text)
	{
		if (*text == 13)
		{
			text++;
		}
		return *text == 10;
	}

	private unsafe bool StepHeaders(byte* inbuf, ref bool scanningFieldName, ref bool checkFolded, ref bool midline, ref bool blank, ref bool valid, ref int left)
	{
		byte* ptr = inbuf + inputIndex;
		byte* ptr2 = inbuf + inputEnd;
		bool flag = false;
		*ptr2 = 10;
		for (; ptr < ptr2; ptr++)
		{
			byte* ptr3 = ptr;
			if ((!midline & checkFolded) && !IsBlank(*ptr))
			{
				ParseAndAppendHeader();
				headerOffset = GetOffset((int)(ptr - inbuf));
				scanningFieldName = true;
				checkFolded = false;
				blank = false;
				valid = true;
			}
			bool flag2 = IsEoln(ptr);
			long num;
			if (scanningFieldName && !flag2)
			{
				if (*ptr != 58)
				{
					*ptr2 = 58;
					for (; *ptr != 58; ptr++)
					{
						if (IsBlank(*ptr))
						{
							blank = true;
						}
						else if (blank || IsControl(*ptr))
						{
							valid = false;
							break;
						}
					}
					if (ptr == ptr2)
					{
						left = (int)(ptr2 - ptr3);
						inputIndex = (int)(ptr3 - inbuf);
						flag = true;
						break;
					}
					*ptr2 = 10;
				}
				else
				{
					valid = false;
				}
				if (!valid)
				{
					num = ptr - ptr3;
					if (format == MimeFormat.Mbox && inputIndex >= contentEnd && num >= 5 && IsMboxMarker(ptr3))
					{
						inputIndex = (int)(ptr3 - inbuf);
						state = MimeParserState.Complete;
						headerIndex = 0;
						return false;
					}
					if (headers.Count == 0)
					{
						if (state == MimeParserState.MessageHeaders)
						{
							if (toplevel && (num < 5 || !IsMboxMarker(ptr3, allowMunged: true)))
							{
								inputIndex = (int)(ptr3 - inbuf);
								state = MimeParserState.Error;
								headerIndex = 0;
								return false;
							}
						}
						else if (toplevel && state == MimeParserState.Headers)
						{
							inputIndex = (int)(ptr3 - inbuf);
							state = MimeParserState.Error;
							headerIndex = 0;
							return false;
						}
					}
				}
			}
			scanningFieldName = false;
			for (; *ptr != 10; ptr++)
			{
			}
			if (ptr == ptr2)
			{
				num = ptr - ptr3;
				if (ptr > ptr3)
				{
					ptr--;
					if (*ptr == 13)
					{
						num--;
					}
					else
					{
						ptr++;
					}
				}
				if (num > 0)
				{
					AppendRawHeaderData((int)(ptr3 - inbuf), (int)num);
					midline = true;
				}
				inputIndex = (int)(ptr - inbuf);
				left = (int)(ptr2 - ptr);
				flag = true;
				break;
			}
			prevLineBeginOffset = lineBeginOffset;
			lineBeginOffset = GetOffset((int)(ptr - inbuf) + 1);
			lineNumber++;
			if (!midline && IsEoln(ptr3))
			{
				inputIndex = (int)(ptr - inbuf) + 1;
				state = MimeParserState.Content;
				ParseAndAppendHeader();
				headerIndex = 0;
				return false;
			}
			num = ptr + 1 - ptr3;
			if ((boundary = CheckBoundary((int)(ptr3 - inbuf), ptr3, (int)num)) != BoundaryType.None)
			{
				inputIndex = (int)(ptr3 - inbuf);
				state = MimeParserState.Boundary;
				headerIndex = 0;
				return false;
			}
			if (!valid && headers.Count == 0)
			{
				if (num > 0 && preHeaderLength == 0)
				{
					if (ptr[-1] == 13)
					{
						num--;
					}
					num--;
					preHeaderLength = (int)num;
					if (preHeaderLength > preHeaderBuffer.Length)
					{
						Array.Resize(ref preHeaderBuffer, NextAllocSize(preHeaderLength));
					}
					Buffer.BlockCopy(input, (int)(ptr3 - inbuf), preHeaderBuffer, 0, preHeaderLength);
				}
				scanningFieldName = true;
				checkFolded = false;
				blank = false;
				valid = true;
			}
			else
			{
				AppendRawHeaderData((int)(ptr3 - inbuf), (int)num);
				checkFolded = true;
			}
			midline = false;
		}
		if (!flag)
		{
			inputIndex = (int)(ptr - inbuf);
			left = (int)(ptr2 - ptr);
		}
		return true;
	}

	private unsafe void StepHeaders(byte* inbuf, CancellationToken cancellationToken)
	{
		bool scanningFieldName = true;
		bool checkFolded = false;
		bool midline = false;
		bool blank = false;
		bool valid = true;
		int left = 0;
		headerBlockBegin = GetOffset(inputIndex);
		boundary = BoundaryType.None;
		ResetRawHeaderData();
		headers.Clear();
		ReadAhead(128, 0, cancellationToken);
		while (StepHeaders(inbuf, ref scanningFieldName, ref checkFolded, ref midline, ref blank, ref valid, ref left))
		{
			int num = ReadAhead(left + 1, 0, cancellationToken);
			if (num != left)
			{
				continue;
			}
			if (scanningFieldName && left > 0)
			{
				state = MimeParserState.Error;
				break;
			}
			if (left > 0)
			{
				AppendRawHeaderData(inputIndex, left);
				inputIndex = inputEnd;
			}
			ParseAndAppendHeader();
			state = MimeParserState.Content;
			break;
		}
		headerBlockEnd = GetOffset(inputIndex);
	}

	private unsafe bool SkipLine(byte* inbuf, bool consumeNewLine)
	{
		byte* ptr = inbuf + inputIndex;
		byte* ptr2 = inbuf + inputEnd;
		*ptr2 = 10;
		for (; *ptr != 10; ptr++)
		{
		}
		if (ptr < ptr2)
		{
			inputIndex = (int)(ptr - inbuf);
			if (consumeNewLine)
			{
				inputIndex++;
				lineNumber++;
				prevLineBeginOffset = lineBeginOffset;
				lineBeginOffset = GetOffset(inputIndex);
			}
			else if (*(ptr - 1) == 13)
			{
				inputIndex--;
			}
			return true;
		}
		inputIndex = inputEnd;
		return false;
	}

	private unsafe bool SkipLine(byte* inbuf, bool consumeNewLine, CancellationToken cancellationToken)
	{
		do
		{
			if (SkipLine(inbuf, consumeNewLine))
			{
				return true;
			}
		}
		while (ReadAhead(128, 1, cancellationToken) > 0);
		return false;
	}

	private unsafe MimeParserState Step(byte* inbuf, CancellationToken cancellationToken)
	{
		switch (state)
		{
		case MimeParserState.Initialized:
			if (!StepByteOrderMark(inbuf, cancellationToken))
			{
				state = MimeParserState.Eos;
			}
			else
			{
				state = ((format == MimeFormat.Mbox) ? MimeParserState.MboxMarker : MimeParserState.MessageHeaders);
			}
			break;
		case MimeParserState.MboxMarker:
			StepMboxMarker(inbuf, cancellationToken);
			break;
		case MimeParserState.MessageHeaders:
		case MimeParserState.Headers:
			StepHeaders(inbuf, cancellationToken);
			toplevel = false;
			break;
		}
		return state;
	}

	private ContentType GetContentType(ContentType parent)
	{
		for (int i = 0; i < headers.Count; i++)
		{
			if (!headers[i].Field.Equals("Content-Type", StringComparison.OrdinalIgnoreCase))
			{
				continue;
			}
			byte[] rawValue = headers[i].RawValue;
			int j = 0;
			if (!ContentType.TryParse(options, rawValue, ref j, rawValue.Length, throwOnError: false, out var contentType) && contentType == null)
			{
				contentType = new ContentType("application", "octet-stream");
				for (; j < rawValue.Length && rawValue[j] != 59; j++)
				{
				}
				if (++j < rawValue.Length && ParameterList.TryParse(options, rawValue, ref j, rawValue.Length, throwOnError: false, out var paramList))
				{
					contentType.Parameters = paramList;
				}
			}
			return contentType;
		}
		if (parent == null || !parent.IsMimeType("multipart", "digest"))
		{
			return new ContentType("text", "plain");
		}
		return new ContentType("message", "rfc822");
	}

	private unsafe bool IsPossibleBoundary(byte* text, int length)
	{
		if (length < 2)
		{
			return false;
		}
		if (*text == 45 && text[1] == 45)
		{
			return true;
		}
		if (format == MimeFormat.Mbox && length >= 5 && IsMboxMarker(text))
		{
			return true;
		}
		return false;
	}

	private unsafe static bool IsBoundary(byte* text, int length, byte[] boundary, int boundaryLength)
	{
		if (boundaryLength > length)
		{
			return false;
		}
		fixed (byte* str = boundary)
		{
			if (!CStringsEqual(text, str, boundaryLength))
			{
				return false;
			}
			if (IsMboxMarker(text))
			{
				return true;
			}
			byte* ptr = text + boundaryLength;
			for (byte* ptr2 = text + length; ptr < ptr2; ptr++)
			{
				if (!(*ptr).IsWhitespace())
				{
					return false;
				}
			}
		}
		return true;
	}

	private unsafe BoundaryType CheckBoundary(int startIndex, byte* start, int length)
	{
		int num = bounds.Count;
		if (!IsPossibleBoundary(start, length))
		{
			return BoundaryType.None;
		}
		if (contentEnd > 0)
		{
			num--;
		}
		for (int i = 0; i < num; i++)
		{
			Boundary boundary = bounds[i];
			if (IsBoundary(start, length, boundary.Marker, boundary.FinalLength))
			{
				if (i != 0)
				{
					return BoundaryType.ParentEndBoundary;
				}
				return BoundaryType.ImmediateEndBoundary;
			}
			if (IsBoundary(start, length, boundary.Marker, boundary.Length))
			{
				if (i != 0)
				{
					return BoundaryType.ParentBoundary;
				}
				return BoundaryType.ImmediateBoundary;
			}
		}
		if (contentEnd > 0)
		{
			long offset = GetOffset(startIndex);
			Boundary boundary2 = bounds[num];
			if (offset >= contentEnd && IsBoundary(start, length, boundary2.Marker, boundary2.Length))
			{
				return BoundaryType.ImmediateEndBoundary;
			}
		}
		return BoundaryType.None;
	}

	private unsafe bool FoundImmediateBoundary(byte* inbuf, bool final)
	{
		int boundaryLength = (final ? bounds[0].FinalLength : bounds[0].Length);
		byte* ptr = inbuf + inputIndex;
		byte* ptr2 = inbuf + inputEnd;
		byte* ptr3 = ptr;
		*ptr2 = 10;
		for (; *ptr3 != 10; ptr3++)
		{
		}
		return IsBoundary(ptr, (int)(ptr3 - ptr), bounds[0].Marker, boundaryLength);
	}

	private int GetMaxBoundaryLength()
	{
		if (bounds.Count <= 0)
		{
			return 0;
		}
		return bounds[0].MaxLength + 2;
	}

	private unsafe void ScanContent(byte* inbuf, ref int contentIndex, ref int nleft, ref bool midline, ref bool[] formats)
	{
		int num = inputEnd - inputIndex;
		byte* ptr = inbuf + inputIndex;
		byte* ptr2 = inbuf + inputEnd;
		int num2 = inputIndex;
		contentIndex = inputIndex;
		if (midline && num == nleft)
		{
			boundary = BoundaryType.Eos;
		}
		*ptr2 = 10;
		while (ptr < ptr2)
		{
			int num3 = (num2 + 3) & -4;
			byte* ptr3 = inbuf + num3;
			byte* ptr4 = ptr;
			byte b = *ptr3;
			*ptr3 = 10;
			for (; *ptr != 10; ptr++)
			{
			}
			*ptr3 = b;
			if (ptr == ptr3 && b != 10)
			{
				uint* ptr5 = (uint*)ptr;
				uint num4;
				do
				{
					num4 = *(ptr5++) ^ 0xA0A0A0A;
				}
				while (((num4 - 16843009) & (~num4 & 0x80808080u)) == 0);
				for (ptr = (byte*)ptr5 - 4; *ptr != 10; ptr++)
				{
				}
			}
			num = (int)(ptr - ptr4);
			if (ptr < ptr2)
			{
				if ((boundary = CheckBoundary(num2, ptr4, num)) != BoundaryType.None)
				{
					break;
				}
				if (num > 0 && *(ptr - 1) == 13)
				{
					formats[1] = true;
				}
				else
				{
					formats[0] = true;
				}
				lineNumber++;
				num++;
				ptr++;
				prevLineBeginOffset = lineBeginOffset;
				lineBeginOffset = GetOffset((int)(ptr - inbuf));
			}
			else
			{
				midline = true;
				if (boundary == BoundaryType.None || (boundary = CheckBoundary(num2, ptr4, num)) != BoundaryType.None)
				{
					break;
				}
			}
			num2 += num;
		}
		inputIndex = num2;
	}

	private unsafe ScanContentResult ScanContent(byte* inbuf, Stream content, bool trimNewLine, CancellationToken cancellationToken)
	{
		int atleast = Math.Max(128, GetMaxBoundaryLength());
		int contentIndex = inputIndex;
		bool[] formats = new bool[2];
		bool midline = false;
		do
		{
			if (contentIndex < inputIndex)
			{
				content.Write(input, contentIndex, inputIndex - contentIndex);
			}
			int nleft = inputEnd - inputIndex;
			if (ReadAhead(atleast, 2, cancellationToken) <= 0)
			{
				boundary = BoundaryType.Eos;
				contentIndex = inputIndex;
				break;
			}
			ScanContent(inbuf, ref contentIndex, ref nleft, ref midline, ref formats);
		}
		while (boundary == BoundaryType.None);
		if (contentIndex < inputIndex)
		{
			content.Write(input, contentIndex, inputIndex - contentIndex);
		}
		bool isEmpty = content.Length == 0;
		if (boundary != BoundaryType.Eos && trimNewLine && content.Length > 0)
		{
			if (input[inputIndex - 2] == 13)
			{
				content.SetLength(content.Length - 2);
			}
			else
			{
				content.SetLength(content.Length - 1);
			}
		}
		return new ScanContentResult(formats, isEmpty);
	}

	private unsafe void ConstructMimePart(MimePart part, MimeEntityEndEventArgs args, byte* inbuf, CancellationToken cancellationToken)
	{
		long offset = GetOffset(inputIndex);
		int beginLineNumber = lineNumber;
		ScanContentResult scanContentResult;
		long num;
		Stream stream;
		if (persistent)
		{
			using (MeasuringStream measuringStream = new MeasuringStream())
			{
				scanContentResult = ScanContent(inbuf, measuringStream, trimNewLine: true, cancellationToken);
				num = offset + measuringStream.Length;
			}
			stream = new BoundStream(this.stream, offset, num, leaveOpen: true);
		}
		else
		{
			stream = new MemoryBlockStream();
			try
			{
				scanContentResult = ScanContent(inbuf, stream, trimNewLine: true, cancellationToken);
				stream.Seek(0L, SeekOrigin.Begin);
			}
			catch
			{
				stream.Dispose();
				throw;
			}
			num = offset + stream.Length;
		}
		args.Lines = GetLineCount(beginLineNumber, offset, num);
		if (!scanContentResult.IsEmpty)
		{
			part.Content = new MimeContent(stream, part.ContentTransferEncoding)
			{
				NewLineFormat = scanContentResult.Format
			};
		}
		else
		{
			stream.Dispose();
		}
	}

	private unsafe void ConstructMessagePart(MessagePart rfc822, MimeEntityEndEventArgs args, byte* inbuf, int depth, CancellationToken cancellationToken)
	{
		long offset = GetOffset(inputIndex);
		int beginLineNumber = lineNumber;
		if (bounds.Count > 0)
		{
			int atleast = Math.Max(128, GetMaxBoundaryLength());
			if (ReadAhead(atleast, 0, cancellationToken) <= 0)
			{
				boundary = BoundaryType.Eos;
				return;
			}
			byte* ptr = inbuf + inputIndex;
			byte* ptr2 = inbuf + inputEnd;
			byte* ptr3 = ptr;
			*ptr2 = 10;
			for (; *ptr3 != 10; ptr3++)
			{
			}
			boundary = CheckBoundary(inputIndex, ptr, (int)(ptr3 - ptr));
			switch (boundary)
			{
			case BoundaryType.ImmediateBoundary:
			case BoundaryType.ImmediateEndBoundary:
			case BoundaryType.ParentBoundary:
				return;
			case BoundaryType.ParentEndBoundary:
				if (!IsMboxMarker(ptr))
				{
					return;
				}
				break;
			}
		}
		state = MimeParserState.MessageHeaders;
		if (Step(inbuf, cancellationToken) == MimeParserState.Error)
		{
			boundary = BoundaryType.Eos;
			return;
		}
		MimeMessage mimeMessage = new MimeMessage(options, headers, RfcComplianceMode.Loose);
		MimeMessageEndEventArgs e = new MimeMessageEndEventArgs(mimeMessage, rfc822)
		{
			HeadersEndOffset = headerBlockEnd,
			BeginOffset = headerBlockBegin,
			LineNumber = beginLineNumber
		};
		OnMimeMessageBegin(e);
		if (preHeaderBuffer.Length != 0)
		{
			mimeMessage.MboxMarker = new byte[preHeaderLength];
			Buffer.BlockCopy(preHeaderBuffer, 0, mimeMessage.MboxMarker, 0, preHeaderLength);
		}
		ContentType contentType = GetContentType(null);
		MimeEntity mimeEntity = options.CreateEntity(contentType, headers, toplevel: true, depth);
		MimeEntityEndEventArgs e2 = new MimeEntityEndEventArgs(mimeEntity)
		{
			HeadersEndOffset = headerBlockEnd,
			BeginOffset = headerBlockBegin,
			LineNumber = beginLineNumber
		};
		OnMimeEntityBegin(e2);
		mimeMessage.Body = mimeEntity;
		if (mimeEntity is Multipart)
		{
			ConstructMultipart((Multipart)mimeEntity, e2, inbuf, depth + 1, cancellationToken);
		}
		else if (mimeEntity is MessagePart)
		{
			ConstructMessagePart((MessagePart)mimeEntity, e2, inbuf, depth + 1, cancellationToken);
		}
		else
		{
			ConstructMimePart((MimePart)mimeEntity, e2, inbuf, cancellationToken);
		}
		rfc822.Message = mimeMessage;
		long endOffset = GetEndOffset(inputIndex);
		long headersEndOffset = (e2.HeadersEndOffset = Math.Min(e2.HeadersEndOffset, endOffset));
		e.HeadersEndOffset = headersEndOffset;
		headersEndOffset = (e2.EndOffset = endOffset);
		e.EndOffset = headersEndOffset;
		OnMimeEntityEnd(e2);
		OnMimeMessageEnd(e);
		args.Lines = GetLineCount(beginLineNumber, offset, endOffset);
	}

	private unsafe void MultipartScanPreamble(Multipart multipart, byte* inbuf, CancellationToken cancellationToken)
	{
		using MemoryStream memoryStream = new MemoryStream();
		long offset = GetOffset(inputIndex);
		ScanContent(inbuf, memoryStream, trimNewLine: false, cancellationToken);
		multipart.RawPreamble = memoryStream.ToArray();
	}

	private unsafe void MultipartScanEpilogue(Multipart multipart, byte* inbuf, CancellationToken cancellationToken)
	{
		using MemoryStream memoryStream = new MemoryStream();
		long offset = GetOffset(inputIndex);
		ScanContentResult scanContentResult = ScanContent(inbuf, memoryStream, trimNewLine: true, cancellationToken);
		multipart.RawEpilogue = (scanContentResult.IsEmpty ? null : memoryStream.ToArray());
	}

	private unsafe void MultipartScanSubparts(Multipart multipart, byte* inbuf, int depth, CancellationToken cancellationToken)
	{
		do
		{
			if (!SkipLine(inbuf, consumeNewLine: true, cancellationToken))
			{
				boundary = BoundaryType.Eos;
				break;
			}
			int num = lineNumber;
			state = MimeParserState.Headers;
			if (Step(inbuf, cancellationToken) == MimeParserState.Error)
			{
				boundary = BoundaryType.Eos;
				break;
			}
			if (state == MimeParserState.Boundary && headers.Count == 0)
			{
				if (boundary != BoundaryType.ImmediateBoundary)
				{
					break;
				}
				continue;
			}
			ContentType contentType = GetContentType(multipart.ContentType);
			MimeEntity mimeEntity = options.CreateEntity(contentType, headers, toplevel: false, depth);
			MimeEntityEndEventArgs e = new MimeEntityEndEventArgs(mimeEntity, multipart)
			{
				HeadersEndOffset = headerBlockEnd,
				BeginOffset = headerBlockBegin,
				LineNumber = num
			};
			OnMimeEntityBegin(e);
			if (mimeEntity is Multipart)
			{
				ConstructMultipart((Multipart)mimeEntity, e, inbuf, depth + 1, cancellationToken);
			}
			else if (mimeEntity is MessagePart)
			{
				ConstructMessagePart((MessagePart)mimeEntity, e, inbuf, depth + 1, cancellationToken);
			}
			else
			{
				ConstructMimePart((MimePart)mimeEntity, e, inbuf, cancellationToken);
			}
			long endOffset = GetEndOffset(inputIndex);
			e.HeadersEndOffset = Math.Min(e.HeadersEndOffset, endOffset);
			e.EndOffset = endOffset;
			OnMimeEntityEnd(e);
			multipart.Add(mimeEntity);
		}
		while (boundary == BoundaryType.ImmediateBoundary);
	}

	private void PushBoundary(string boundary)
	{
		if (bounds.Count > 0)
		{
			bounds.Insert(0, new Boundary(boundary, bounds[0].MaxLength));
		}
		else
		{
			bounds.Add(new Boundary(boundary, 0));
		}
	}

	private void PopBoundary()
	{
		bounds.RemoveAt(0);
	}

	private unsafe void ConstructMultipart(Multipart multipart, MimeEntityEndEventArgs args, byte* inbuf, int depth, CancellationToken cancellationToken)
	{
		long offset = GetOffset(inputIndex);
		int beginLineNumber = lineNumber;
		string text = multipart.Boundary;
		long endOffset;
		if (text == null)
		{
			MultipartScanPreamble(multipart, inbuf, cancellationToken);
			endOffset = GetEndOffset(inputIndex);
			args.Lines = GetLineCount(beginLineNumber, offset, endOffset);
			return;
		}
		PushBoundary(text);
		MultipartScanPreamble(multipart, inbuf, cancellationToken);
		if (boundary == BoundaryType.ImmediateBoundary)
		{
			MultipartScanSubparts(multipart, inbuf, depth, cancellationToken);
		}
		if (boundary == BoundaryType.ImmediateEndBoundary)
		{
			multipart.WriteEndBoundary = true;
			SkipLine(inbuf, consumeNewLine: false, cancellationToken);
			PopBoundary();
			MultipartScanEpilogue(multipart, inbuf, cancellationToken);
			endOffset = GetEndOffset(inputIndex);
			args.Lines = GetLineCount(beginLineNumber, offset, endOffset);
			return;
		}
		endOffset = GetEndOffset(inputIndex);
		args.Lines = GetLineCount(beginLineNumber, offset, endOffset);
		multipart.WriteEndBoundary = false;
		PopBoundary();
		if (boundary == BoundaryType.ParentEndBoundary && FoundImmediateBoundary(inbuf, final: true))
		{
			boundary = BoundaryType.ImmediateEndBoundary;
		}
		else if (boundary == BoundaryType.ParentBoundary && FoundImmediateBoundary(inbuf, final: false))
		{
			boundary = BoundaryType.ImmediateBoundary;
		}
	}

	private unsafe HeaderList ParseHeaders(byte* inbuf, CancellationToken cancellationToken)
	{
		state = MimeParserState.Headers;
		if (Step(inbuf, cancellationToken) == MimeParserState.Error)
		{
			throw new FormatException("Failed to parse headers.");
		}
		state = (eos ? MimeParserState.Eos : MimeParserState.Complete);
		HeaderList headerList = new HeaderList(options);
		foreach (Header header in headers)
		{
			headerList.Add(header);
		}
		return headerList;
	}

	public unsafe HeaderList ParseHeaders(CancellationToken cancellationToken = default(CancellationToken))
	{
		fixed (byte* inbuf = input)
		{
			return ParseHeaders(inbuf, cancellationToken);
		}
	}

	private unsafe MimeEntity ParseEntity(byte* inbuf, CancellationToken cancellationToken)
	{
		if (persistent && stream.Position != position)
		{
			stream.Seek(position, SeekOrigin.Begin);
		}
		int num = lineNumber;
		state = MimeParserState.Headers;
		toplevel = true;
		if (Step(inbuf, cancellationToken) == MimeParserState.Error)
		{
			throw new FormatException("Failed to parse entity headers.");
		}
		ContentType contentType = GetContentType(null);
		MimeEntity mimeEntity = options.CreateEntity(contentType, headers, toplevel: false, 0);
		MimeEntityEndEventArgs e = new MimeEntityEndEventArgs(mimeEntity)
		{
			HeadersEndOffset = headerBlockEnd,
			BeginOffset = headerBlockBegin,
			LineNumber = num
		};
		OnMimeEntityBegin(e);
		if (mimeEntity is Multipart)
		{
			ConstructMultipart((Multipart)mimeEntity, e, inbuf, 0, cancellationToken);
		}
		else if (mimeEntity is MessagePart)
		{
			ConstructMessagePart((MessagePart)mimeEntity, e, inbuf, 0, cancellationToken);
		}
		else
		{
			ConstructMimePart((MimePart)mimeEntity, e, inbuf, cancellationToken);
		}
		long endOffset = GetEndOffset(inputIndex);
		e.HeadersEndOffset = Math.Min(e.HeadersEndOffset, endOffset);
		e.EndOffset = endOffset;
		if (boundary != BoundaryType.Eos)
		{
			state = MimeParserState.Complete;
		}
		else
		{
			state = MimeParserState.Eos;
		}
		OnMimeEntityEnd(e);
		return mimeEntity;
	}

	public unsafe MimeEntity ParseEntity(CancellationToken cancellationToken = default(CancellationToken))
	{
		fixed (byte* inbuf = input)
		{
			return ParseEntity(inbuf, cancellationToken);
		}
	}

	private unsafe MimeMessage ParseMessage(byte* inbuf, CancellationToken cancellationToken)
	{
		if (persistent && stream.Position != position)
		{
			stream.Seek(position, SeekOrigin.Begin);
		}
		while (state != MimeParserState.MessageHeaders)
		{
			switch (Step(inbuf, cancellationToken))
			{
			case MimeParserState.Error:
				throw new FormatException("Failed to find mbox From marker.");
			case MimeParserState.Eos:
				throw new FormatException("End of stream.");
			}
		}
		toplevel = true;
		int num = lineNumber;
		if (state < MimeParserState.Content && Step(inbuf, cancellationToken) == MimeParserState.Error)
		{
			throw new FormatException("Failed to parse message headers.");
		}
		MimeMessage mimeMessage = new MimeMessage(options, headers, RfcComplianceMode.Loose);
		MimeMessageEndEventArgs e = new MimeMessageEndEventArgs(mimeMessage)
		{
			HeadersEndOffset = headerBlockEnd,
			BeginOffset = headerBlockBegin,
			LineNumber = num
		};
		OnMimeMessageBegin(e);
		contentEnd = 0L;
		if (format == MimeFormat.Mbox && options.RespectContentLength)
		{
			for (int i = 0; i < headers.Count; i++)
			{
				if (headers[i].Id == HeaderId.ContentLength)
				{
					byte[] rawValue = headers[i].RawValue;
					int index = 0;
					if (ParseUtils.SkipWhiteSpace(rawValue, ref index, rawValue.Length) && ParseUtils.TryParseInt32(rawValue, ref index, rawValue.Length, out var value))
					{
						contentEnd = GetOffset(inputIndex) + value;
						break;
					}
				}
			}
		}
		ContentType contentType = GetContentType(null);
		MimeEntity mimeEntity = options.CreateEntity(contentType, headers, toplevel: true, 0);
		MimeEntityEndEventArgs e2 = new MimeEntityEndEventArgs(mimeEntity)
		{
			HeadersEndOffset = headerBlockEnd,
			BeginOffset = headerBlockBegin,
			LineNumber = num
		};
		OnMimeEntityBegin(e2);
		mimeMessage.Body = mimeEntity;
		if (mimeEntity is Multipart multipart)
		{
			ConstructMultipart(multipart, e2, inbuf, 0, cancellationToken);
		}
		else if (mimeEntity is MessagePart rfc)
		{
			ConstructMessagePart(rfc, e2, inbuf, 0, cancellationToken);
		}
		else
		{
			ConstructMimePart((MimePart)mimeEntity, e2, inbuf, cancellationToken);
		}
		long endOffset = GetEndOffset(inputIndex);
		long headersEndOffset = (e2.HeadersEndOffset = Math.Min(e2.HeadersEndOffset, endOffset));
		e.HeadersEndOffset = headersEndOffset;
		headersEndOffset = (e2.EndOffset = endOffset);
		e.EndOffset = headersEndOffset;
		if (boundary != BoundaryType.Eos)
		{
			if (format == MimeFormat.Mbox)
			{
				state = MimeParserState.MboxMarker;
			}
			else
			{
				state = MimeParserState.Complete;
			}
		}
		else
		{
			state = MimeParserState.Eos;
		}
		OnMimeEntityEnd(e2);
		OnMimeMessageEnd(e);
		return mimeMessage;
	}

	public unsafe MimeMessage ParseMessage(CancellationToken cancellationToken = default(CancellationToken))
	{
		fixed (byte* inbuf = input)
		{
			return ParseMessage(inbuf, cancellationToken);
		}
	}

	public IEnumerator<MimeMessage> GetEnumerator()
	{
		while (!IsEndOfStream)
		{
			yield return ParseMessage();
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}
