using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MimeKit;
using MimeKit.Utils;

namespace MailKit.Net.Imap;

internal class ImapCommand
{
	private static readonly byte[] UTF8LiteralTokenPrefix = Encoding.ASCII.GetBytes("UTF8 (~{");

	private static readonly byte[] LiteralTokenSuffix = new byte[3] { 125, 13, 10 };

	private static readonly byte[] Nil = new byte[3] { 78, 73, 76 };

	private static readonly byte[] NewLine = new byte[2] { 13, 10 };

	private static readonly byte[] LiteralTokenPrefix = new byte[1] { 123 };

	public readonly List<ImapResponseCode> RespCodes;

	private readonly List<ImapCommandPart> parts = new List<ImapCommandPart>();

	private readonly ImapEngine Engine;

	private long totalSize;

	private long nwritten;

	private int current;

	public Dictionary<string, ImapUntaggedHandler> UntaggedHandlers { get; private set; }

	public ImapContinuationHandler ContinuationHandler { get; set; }

	public CancellationToken CancellationToken { get; private set; }

	public ImapCommandStatus Status { get; internal set; }

	public ImapCommandResponse Response { get; internal set; }

	public ITransferProgress Progress { get; internal set; }

	public Exception Exception { get; internal set; }

	public string ResponseText { get; internal set; }

	public ImapFolder Folder { get; private set; }

	public object UserData { get; internal set; }

	public bool ListReturnsSubscribed { get; internal set; }

	public bool Logout { get; private set; }

	public bool Lsub { get; internal set; }

	public string Tag { get; private set; }

	public bool Bye { get; internal set; }

	public ImapCommand(ImapEngine engine, CancellationToken cancellationToken, ImapFolder folder, FormatOptions options, string format, params object[] args)
	{
		UntaggedHandlers = new Dictionary<string, ImapUntaggedHandler>(StringComparer.OrdinalIgnoreCase);
		Logout = format.Equals("LOGOUT\r\n", StringComparison.Ordinal);
		RespCodes = new List<ImapResponseCode>();
		CancellationToken = cancellationToken;
		Response = ImapCommandResponse.None;
		Status = ImapCommandStatus.Created;
		Engine = engine;
		Folder = folder;
		using MemoryStream memoryStream = new MemoryStream();
		byte[] array = new byte[8];
		int num = 0;
		for (int i = 0; i < format.Length; i++)
		{
			if (format[i] == '%')
			{
				switch (format[++i])
				{
				case '%':
					memoryStream.WriteByte(37);
					break;
				case 'd':
				{
					string s = ((int)args[num++]).ToString(CultureInfo.InvariantCulture);
					byte[] bytes = Encoding.ASCII.GetBytes(s);
					memoryStream.Write(bytes, 0, bytes.Length);
					break;
				}
				case 'u':
				{
					string s = ((uint)args[num++]).ToString(CultureInfo.InvariantCulture);
					byte[] bytes = Encoding.ASCII.GetBytes(s);
					memoryStream.Write(bytes, 0, bytes.Length);
					break;
				}
				case 's':
				{
					string s = (string)args[num++];
					byte[] bytes = Encoding.ASCII.GetBytes(s);
					memoryStream.Write(bytes, 0, bytes.Length);
					break;
				}
				case 'F':
				{
					string encodedName = ((ImapFolder)args[num++]).EncodedName;
					AppendString(options, allowAtom: true, memoryStream, encodedName);
					break;
				}
				case 'L':
				{
					object obj = args[num++];
					byte[] array2;
					ImapLiteral imapLiteral;
					if (obj is MimeMessage message)
					{
						array2 = (options.International ? UTF8LiteralTokenPrefix : LiteralTokenPrefix);
						imapLiteral = new ImapLiteral(options, message, UpdateProgress);
					}
					else
					{
						imapLiteral = new ImapLiteral(options, (byte[])obj);
						array2 = LiteralTokenPrefix;
					}
					long length = imapLiteral.Length;
					bool wait = true;
					memoryStream.Write(array2, 0, array2.Length);
					byte[] bytes = Encoding.ASCII.GetBytes(length.ToString(CultureInfo.InvariantCulture));
					memoryStream.Write(bytes, 0, bytes.Length);
					if (CanUseNonSynchronizedLiteral(Engine, length))
					{
						memoryStream.WriteByte(43);
						wait = false;
					}
					memoryStream.Write(LiteralTokenSuffix, 0, LiteralTokenSuffix.Length);
					totalSize += length;
					parts.Add(new ImapCommandPart(memoryStream.ToArray(), imapLiteral, wait));
					memoryStream.SetLength(0L);
					if (array2 == UTF8LiteralTokenPrefix)
					{
						memoryStream.WriteByte(41);
					}
					break;
				}
				case 'S':
					AppendString(options, allowAtom: true, memoryStream, (string)args[num++]);
					break;
				case 'Q':
					AppendString(options, allowAtom: false, memoryStream, (string)args[num++]);
					break;
				default:
					throw new FormatException();
				}
			}
			else if (format[i] < '\u0080')
			{
				memoryStream.WriteByte((byte)format[i]);
			}
			else
			{
				int num2 = ((!char.IsSurrogate(format[i])) ? 1 : 2);
				int bytes2 = Encoding.UTF8.GetBytes(format, i, num2, array, 0);
				memoryStream.Write(array, 0, bytes2);
				i += num2 - 1;
			}
		}
		parts.Add(new ImapCommandPart(memoryStream.ToArray(), null));
	}

	public ImapCommand(ImapEngine engine, CancellationToken cancellationToken, ImapFolder folder, string format, params object[] args)
		: this(engine, cancellationToken, folder, FormatOptions.Default, format, args)
	{
	}

	internal static int EstimateCommandLength(ImapEngine engine, FormatOptions options, string format, params object[] args)
	{
		bool eoln = false;
		int num = 0;
		int num2 = 0;
		for (int i = 0; i < format.Length; i++)
		{
			if (format[i] == '%')
			{
				switch (format[++i])
				{
				case '%':
					num++;
					break;
				case 'd':
				{
					string text = ((int)args[num2++]).ToString(CultureInfo.InvariantCulture);
					num += text.Length;
					break;
				}
				case 'u':
				{
					string text = ((uint)args[num2++]).ToString(CultureInfo.InvariantCulture);
					num += text.Length;
					break;
				}
				case 's':
				{
					string text = (string)args[num2++];
					num += text.Length;
					break;
				}
				case 'F':
				{
					string encodedName = ((ImapFolder)args[num2++]).EncodedName;
					num += EstimateStringLength(engine, allowAtom: true, encodedName, out eoln);
					break;
				}
				case 'S':
					num += EstimateStringLength(engine, allowAtom: true, (string)args[num2++], out eoln);
					break;
				case 'Q':
					num += EstimateStringLength(engine, allowAtom: false, (string)args[num2++], out eoln);
					break;
				default:
					throw new FormatException();
				case 'L':
					break;
				}
				if (eoln)
				{
					break;
				}
			}
			else
			{
				num++;
			}
		}
		return num + 10;
	}

	internal static int EstimateCommandLength(ImapEngine engine, string format, params object[] args)
	{
		return EstimateCommandLength(engine, FormatOptions.Default, format, args);
	}

	private void UpdateProgress(int n)
	{
		nwritten += n;
		if (Progress != null)
		{
			Progress.Report(nwritten, totalSize);
		}
	}

	private static bool IsAtom(char c)
	{
		if (c < '\u0080' && !char.IsControl(c))
		{
			return "(){ \t%*\\\"]".IndexOf(c) == -1;
		}
		return false;
	}

	private static bool IsQuotedSafe(ImapEngine engine, char c)
	{
		if (c < '\u0080' || engine.UTF8Enabled)
		{
			return !char.IsControl(c);
		}
		return false;
	}

	internal static ImapStringType GetStringType(ImapEngine engine, string value, bool allowAtom)
	{
		ImapStringType result = ((!allowAtom) ? ImapStringType.QString : ImapStringType.Atom);
		if (value == null)
		{
			return ImapStringType.Nil;
		}
		if (value.Length == 0)
		{
			return ImapStringType.QString;
		}
		for (int i = 0; i < value.Length; i++)
		{
			if (!IsAtom(value[i]))
			{
				if (!IsQuotedSafe(engine, value[i]))
				{
					return ImapStringType.Literal;
				}
				result = ImapStringType.QString;
			}
		}
		return result;
	}

	private static bool CanUseNonSynchronizedLiteral(ImapEngine engine, long length)
	{
		if ((engine.Capabilities & ImapCapabilities.LiteralPlus) == ImapCapabilities.None)
		{
			if (length <= 4096)
			{
				return (engine.Capabilities & ImapCapabilities.LiteralMinus) != 0;
			}
			return false;
		}
		return true;
	}

	private static int EstimateStringLength(ImapEngine engine, bool allowAtom, string value, out bool eoln)
	{
		eoln = false;
		switch (GetStringType(engine, value, allowAtom))
		{
		case ImapStringType.Literal:
		{
			int byteCount = Encoding.UTF8.GetByteCount(value);
			bool flag = CanUseNonSynchronizedLiteral(engine, byteCount);
			int length = "{}\r\n".Length;
			length += byteCount.ToString(CultureInfo.InvariantCulture).Length;
			if (flag)
			{
				length++;
			}
			eoln = true;
			return length++;
		}
		case ImapStringType.QString:
			return Encoding.UTF8.GetByteCount(MimeUtils.Quote(value));
		case ImapStringType.Nil:
			return Nil.Length;
		default:
			return value.Length;
		}
	}

	private void AppendString(FormatOptions options, bool allowAtom, MemoryStream builder, string value)
	{
		switch (GetStringType(Engine, value, allowAtom))
		{
		case ImapStringType.Literal:
		{
			byte[] bytes2 = Encoding.UTF8.GetBytes(value);
			bool flag = CanUseNonSynchronizedLiteral(Engine, bytes2.Length);
			string s = bytes2.Length.ToString(CultureInfo.InvariantCulture);
			byte[] bytes = Encoding.ASCII.GetBytes(s);
			builder.WriteByte(123);
			builder.Write(bytes, 0, bytes.Length);
			if (flag)
			{
				builder.WriteByte(43);
			}
			builder.WriteByte(125);
			builder.WriteByte(13);
			builder.WriteByte(10);
			if (flag)
			{
				builder.Write(bytes2, 0, bytes2.Length);
				break;
			}
			parts.Add(new ImapCommandPart(builder.ToArray(), new ImapLiteral(options, bytes2)));
			builder.SetLength(0L);
			break;
		}
		case ImapStringType.QString:
		{
			byte[] bytes = Encoding.UTF8.GetBytes(MimeUtils.Quote(value));
			builder.Write(bytes, 0, bytes.Length);
			break;
		}
		case ImapStringType.Atom:
		{
			byte[] bytes = Encoding.UTF8.GetBytes(value);
			builder.Write(bytes, 0, bytes.Length);
			break;
		}
		case ImapStringType.Nil:
			builder.Write(Nil, 0, Nil.Length);
			break;
		}
	}

	public void RegisterUntaggedHandler(string atom, ImapUntaggedHandler handler)
	{
		if (atom == null)
		{
			throw new ArgumentNullException("atom");
		}
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		if (Status != ImapCommandStatus.Created)
		{
			throw new InvalidOperationException("Untagged handlers must be registered before the command has been queued.");
		}
		UntaggedHandlers.Add(atom, handler);
	}

	public async Task<bool> StepAsync(bool doAsync)
	{
		bool supportsLiteralPlus = (Engine.Capabilities & ImapCapabilities.LiteralPlus) != 0;
		_ = UserData is ImapIdleContext;
		ImapCommandResponse result = ImapCommandResponse.None;
		if (current == 0)
		{
			Tag = string.Format(CultureInfo.InvariantCulture, "{0}{1:D8}", Engine.TagPrefix, Engine.Tag++);
			byte[] bytes = Encoding.ASCII.GetBytes(Tag + " ");
			if (doAsync)
			{
				await Engine.Stream.WriteAsync(bytes, 0, bytes.Length, CancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			}
			else
			{
				Engine.Stream.Write(bytes, 0, bytes.Length, CancellationToken);
			}
		}
		while (true)
		{
			byte[] command = parts[current].Command;
			if (doAsync)
			{
				await Engine.Stream.WriteAsync(command, 0, command.Length, CancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			}
			else
			{
				Engine.Stream.Write(command, 0, command.Length, CancellationToken);
			}
			if (parts[current].WaitForContinuation)
			{
				break;
			}
			await parts[current].Literal.WriteToAsync(Engine.Stream, doAsync, CancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			if (current + 1 >= parts.Count)
			{
				break;
			}
			current++;
		}
		if (doAsync)
		{
			await Engine.Stream.FlushAsync(CancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		else
		{
			Engine.Stream.Flush(CancellationToken);
		}
		do
		{
			ImapToken token;
			if (Engine.State == ImapEngineState.Idle)
			{
				int timeout = -1;
				if (Engine.Stream.CanTimeout)
				{
					timeout = Engine.Stream.ReadTimeout;
					Engine.Stream.ReadTimeout = -1;
				}
				try
				{
					token = await Engine.ReadTokenAsync(doAsync, CancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				}
				finally
				{
					if (Engine.Stream != null && Engine.Stream.IsConnected && Engine.Stream.CanTimeout)
					{
						Engine.Stream.ReadTimeout = timeout;
					}
				}
			}
			else
			{
				token = await Engine.ReadTokenAsync(doAsync, CancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			}
			if (token.Type == ImapTokenType.Atom && token.Value.ToString() == "+")
			{
				string text = (await Engine.ReadLineAsync(doAsync, CancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Trim();
				if (!supportsLiteralPlus && parts[current].Literal != null)
				{
					await parts[current].Literal.WriteToAsync(Engine.Stream, doAsync, CancellationToken).ConfigureAwait(continueOnCapturedContext: false);
					break;
				}
				if (ContinuationHandler != null)
				{
					await ContinuationHandler(Engine, this, text, doAsync).ConfigureAwait(continueOnCapturedContext: false);
				}
				else if (doAsync)
				{
					await Engine.Stream.WriteAsync(NewLine, 0, NewLine.Length, CancellationToken).ConfigureAwait(continueOnCapturedContext: false);
					await Engine.Stream.FlushAsync(CancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				}
				else
				{
					Engine.Stream.Write(NewLine, 0, NewLine.Length, CancellationToken);
					Engine.Stream.Flush(CancellationToken);
				}
			}
			else if (token.Type == ImapTokenType.Asterisk)
			{
				await Engine.ProcessUntaggedResponseAsync(doAsync, CancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			}
			else if (token.Type == ImapTokenType.Atom && (string)token.Value == Tag)
			{
				token = await Engine.ReadTokenAsync(doAsync, CancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				ImapEngine.AssertToken(token, ImapTokenType.Atom, "Syntax error in tagged response. {0}", token);
				result = (string)token.Value switch
				{
					"BAD" => ImapCommandResponse.Bad, 
					"OK" => ImapCommandResponse.Ok, 
					"NO" => ImapCommandResponse.No, 
					_ => throw ImapEngine.UnexpectedToken("Syntax error in tagged response. {0}", token), 
				};
				token = await Engine.ReadTokenAsync(doAsync, CancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				if (token.Type == ImapTokenType.OpenBracket)
				{
					ImapResponseCode item = await Engine.ParseResponseCodeAsync(isTagged: true, doAsync, CancellationToken).ConfigureAwait(continueOnCapturedContext: false);
					RespCodes.Add(item);
					break;
				}
				if (token.Type != ImapTokenType.Eoln)
				{
					string text2 = await Engine.ReadLineAsync(doAsync, CancellationToken).ConfigureAwait(continueOnCapturedContext: false);
					ResponseText = ((string)token.Value + text2).TrimEnd();
					break;
				}
			}
			else
			{
				if (token.Type != ImapTokenType.OpenBracket)
				{
					throw ImapEngine.UnexpectedToken("Syntax error in response. Unexpected token: {0}", token);
				}
				ImapResponseCode item2 = await Engine.ParseResponseCodeAsync(isTagged: false, doAsync, CancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				RespCodes.Add(item2);
			}
		}
		while (Status == ImapCommandStatus.Active);
		if (Status == ImapCommandStatus.Active)
		{
			current++;
			if (current >= parts.Count || result != ImapCommandResponse.None)
			{
				Status = ImapCommandStatus.Complete;
				Response = result;
				return false;
			}
			return true;
		}
		return false;
	}

	public ImapResponseCode GetResponseCode(ImapResponseCodeType type)
	{
		for (int i = 0; i < RespCodes.Count; i++)
		{
			if (RespCodes[i].Type == type)
			{
				return RespCodes[i];
			}
		}
		return null;
	}
}
