using System;
using System.Buffers;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MimeKit;

namespace MailKit.Net.Imap;

internal class ImapEngine : IDisposable
{
	internal const string GenericUntaggedResponseSyntaxErrorFormat = "Syntax error in untagged {0} response. {1}";

	internal const string GenericItemSyntaxErrorFormat = "Syntax error in {0}. {1}";

	internal const string FetchBodySyntaxErrorFormat = "Syntax error in BODY. {0}";

	private const string GenericResponseCodeSyntaxErrorFormat = "Syntax error in {0} response code. {1}";

	private const string GreetingSyntaxErrorFormat = "Syntax error in IMAP server greeting. {0}";

	private const int BufferSize = 4096;

	internal static readonly Encoding Latin1;

	internal static readonly Encoding UTF8;

	private static int TagPrefixIndex;

	internal readonly Dictionary<string, ImapFolder> FolderCache;

	private readonly CreateImapFolderDelegate createImapFolder;

	private readonly ImapFolderNameComparer cacheComparer;

	internal ImapQuirksMode QuirksMode;

	private readonly List<ImapCommand> queue;

	internal char TagPrefix;

	private ImapCommand current;

	private MimeParser parser;

	internal int Tag;

	private bool disposed;

	public HashSet<string> AuthenticationMechanisms { get; private set; }

	public HashSet<string> CompressionAlgorithms { get; private set; }

	public HashSet<ThreadingAlgorithm> ThreadingAlgorithms { get; private set; }

	public uint? AppendLimit { get; private set; }

	public int I18NLevel { get; private set; }

	public ImapCapabilities Capabilities { get; set; }

	internal bool IsBusy => current != null;

	public int CapabilitiesVersion { get; private set; }

	public ImapProtocolVersion ProtocolVersion { get; private set; }

	public AccessRights Rights { get; private set; }

	public HashSet<string> SupportedCharsets { get; private set; }

	public HashSet<string> SupportedContexts { get; private set; }

	public bool QResyncEnabled { get; internal set; }

	public bool UTF8Enabled { get; internal set; }

	public Uri Uri { get; internal set; }

	public ImapStream Stream { get; private set; }

	public ImapEngineState State { get; internal set; }

	public bool IsConnected
	{
		get
		{
			if (Stream != null)
			{
				return Stream.IsConnected;
			}
			return false;
		}
	}

	public FolderNamespaceCollection PersonalNamespaces { get; private set; }

	public FolderNamespaceCollection SharedNamespaces { get; private set; }

	public FolderNamespaceCollection OtherNamespaces { get; private set; }

	public ImapFolder Selected { get; internal set; }

	public bool IsDisposed => disposed;

	internal bool NotifySelectedNewExpunge { get; set; }

	public ImapFolder Inbox { get; private set; }

	public ImapFolder All { get; private set; }

	public ImapFolder Archive { get; private set; }

	public ImapFolder Drafts { get; private set; }

	public ImapFolder Flagged { get; private set; }

	public ImapFolder Important { get; private set; }

	public ImapFolder Junk { get; private set; }

	public ImapFolder Sent { get; private set; }

	public ImapFolder Trash { get; private set; }

	public event EventHandler<AlertEventArgs> Alert;

	public event EventHandler<WebAlertEventArgs> WebAlert;

	public event EventHandler<FolderCreatedEventArgs> FolderCreated;

	public event EventHandler<MetadataChangedEventArgs> MetadataChanged;

	public event EventHandler<EventArgs> NotificationOverflow;

	public event EventHandler<EventArgs> Disconnected;

	static ImapEngine()
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

	public ImapEngine(CreateImapFolderDelegate createImapFolderDelegate)
	{
		cacheComparer = new ImapFolderNameComparer('.');
		FolderCache = new Dictionary<string, ImapFolder>(cacheComparer);
		ThreadingAlgorithms = new HashSet<ThreadingAlgorithm>();
		AuthenticationMechanisms = new HashSet<string>(StringComparer.Ordinal);
		CompressionAlgorithms = new HashSet<string>(StringComparer.Ordinal);
		SupportedContexts = new HashSet<string>(StringComparer.Ordinal);
		SupportedCharsets = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
		Rights = new AccessRights();
		PersonalNamespaces = new FolderNamespaceCollection();
		SharedNamespaces = new FolderNamespaceCollection();
		OtherNamespaces = new FolderNamespaceCollection();
		ProtocolVersion = ImapProtocolVersion.Unknown;
		createImapFolder = createImapFolderDelegate;
		Capabilities = ImapCapabilities.None;
		QuirksMode = ImapQuirksMode.None;
		queue = new List<ImapCommand>();
	}

	internal ImapFolder CreateImapFolder(string encodedName, FolderAttributes attributes, char delim)
	{
		ImapFolderConstructorArgs args = new ImapFolderConstructorArgs(this, encodedName, attributes, delim);
		return createImapFolder(args);
	}

	internal static ImapProtocolException UnexpectedToken(string format, params object[] args)
	{
		for (int i = 0; i < args.Length; i++)
		{
			if (args[i] is ImapToken imapToken)
			{
				switch (imapToken.Type)
				{
				case ImapTokenType.Atom:
					args[i] = $"Unexpected atom token: {imapToken}";
					break;
				case ImapTokenType.Flag:
					args[i] = $"Unexpected flag token: {imapToken}";
					break;
				case ImapTokenType.QString:
					args[i] = $"Unexpected qstring token: {imapToken}";
					break;
				case ImapTokenType.Literal:
					args[i] = $"Unexpected literal token: {imapToken}";
					break;
				default:
					args[i] = $"Unexpected token: {imapToken}";
					break;
				}
				break;
			}
		}
		return new ImapProtocolException(string.Format(CultureInfo.InvariantCulture, format, args))
		{
			UnexpectedToken = true
		};
	}

	internal static void AssertToken(ImapToken token, ImapTokenType type, string format, params object[] args)
	{
		if (token.Type != type)
		{
			throw UnexpectedToken(format, args);
		}
	}

	internal static void AssertToken(ImapToken token, ImapTokenType type1, ImapTokenType type2, string format, params object[] args)
	{
		if (token.Type != type1 && token.Type != type2)
		{
			throw UnexpectedToken(format, args);
		}
	}

	internal static uint ParseNumber(ImapToken token, bool nonZero, string format, params object[] args)
	{
		AssertToken(token, ImapTokenType.Atom, format, args);
		if (!uint.TryParse((string)token.Value, NumberStyles.None, CultureInfo.InvariantCulture, out var result) || (nonZero && result == 0))
		{
			throw UnexpectedToken(format, args);
		}
		return result;
	}

	internal static ulong ParseNumber64(ImapToken token, bool nonZero, string format, params object[] args)
	{
		AssertToken(token, ImapTokenType.Atom, format, args);
		if (!ulong.TryParse((string)token.Value, NumberStyles.None, CultureInfo.InvariantCulture, out var result) || (nonZero && result == 0L))
		{
			throw UnexpectedToken(format, args);
		}
		return result;
	}

	internal static UniqueIdSet ParseUidSet(ImapToken token, uint validity, string format, params object[] args)
	{
		AssertToken(token, ImapTokenType.Atom, format, args);
		if (!UniqueIdSet.TryParse((string)token.Value, validity, out var uids))
		{
			throw UnexpectedToken(format, args);
		}
		return uids;
	}

	internal void SetStream(ImapStream stream)
	{
		Stream = stream;
	}

	public async Task ConnectAsync(ImapStream stream, bool doAsync, CancellationToken cancellationToken)
	{
		TagPrefix = (char)(65 + TagPrefixIndex++ % 26);
		ProtocolVersion = ImapProtocolVersion.Unknown;
		Capabilities = ImapCapabilities.None;
		AuthenticationMechanisms.Clear();
		CompressionAlgorithms.Clear();
		ThreadingAlgorithms.Clear();
		SupportedCharsets.Clear();
		SupportedContexts.Clear();
		Rights.Clear();
		State = ImapEngineState.Connecting;
		QuirksMode = ImapQuirksMode.None;
		SupportedCharsets.Add("US-ASCII");
		SupportedCharsets.Add("UTF-8");
		CapabilitiesVersion = 0;
		QResyncEnabled = false;
		UTF8Enabled = false;
		AppendLimit = null;
		Selected = null;
		Stream = stream;
		I18NLevel = 0;
		Tag = 0;
		try
		{
			ImapToken imapToken = await ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			AssertToken(imapToken, ImapTokenType.Asterisk, "Syntax error in IMAP server greeting. {0}", imapToken);
			imapToken = await ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			AssertToken(imapToken, ImapTokenType.Atom, "Syntax error in IMAP server greeting. {0}", imapToken);
			string text = (string)imapToken.Value;
			string text2 = string.Empty;
			ImapEngineState state = State;
			bool bye = false;
			switch (text.ToUpperInvariant())
			{
			case "BYE":
				bye = true;
				break;
			case "PREAUTH":
				state = ImapEngineState.Authenticated;
				break;
			case "OK":
				state = ImapEngineState.Connected;
				break;
			default:
				throw UnexpectedToken("Syntax error in IMAP server greeting. {0}", imapToken);
			}
			imapToken = await ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			if (imapToken.Type == ImapTokenType.OpenBracket)
			{
				ImapResponseCode imapResponseCode = await ParseResponseCodeAsync(isTagged: false, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				if (imapResponseCode.Type == ImapResponseCodeType.Alert)
				{
					OnAlert(imapResponseCode.Message);
					if (bye)
					{
						throw new ImapProtocolException(imapResponseCode.Message);
					}
				}
				else
				{
					text2 = imapResponseCode.Message;
				}
			}
			else if (imapToken.Type != ImapTokenType.Eoln)
			{
				text2 = (string)imapToken.Value;
				string text3 = text2;
				text2 = text3 + await ReadLineAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				text2 = text2.TrimEnd();
				if (bye)
				{
					throw new ImapProtocolException(text2);
				}
			}
			else if (bye)
			{
				throw new ImapProtocolException("The IMAP server unexpectedly refused the connection.");
			}
			if (text2.StartsWith("Courier-IMAP ready.", StringComparison.Ordinal))
			{
				QuirksMode = ImapQuirksMode.Courier;
			}
			else if (text2.Contains(" Cyrus IMAP "))
			{
				QuirksMode = ImapQuirksMode.Cyrus;
			}
			else if (text2.StartsWith("Domino IMAP4 Server", StringComparison.Ordinal))
			{
				QuirksMode = ImapQuirksMode.Domino;
			}
			else if (text2.StartsWith("Dovecot ready.", StringComparison.Ordinal))
			{
				QuirksMode = ImapQuirksMode.Dovecot;
			}
			else if (text2.StartsWith("Microsoft Exchange Server 2007 IMAP4 service is ready", StringComparison.Ordinal))
			{
				QuirksMode = ImapQuirksMode.Exchange;
			}
			else if (text2.StartsWith("The Microsoft Exchange IMAP4 service is ready.", StringComparison.Ordinal))
			{
				QuirksMode = ImapQuirksMode.Exchange;
			}
			else if (text2.StartsWith("Gimap ready", StringComparison.Ordinal))
			{
				QuirksMode = ImapQuirksMode.GMail;
			}
			else if (text2.StartsWith("IMAPrev1", StringComparison.Ordinal))
			{
				QuirksMode = ImapQuirksMode.hMailServer;
			}
			else if (text2.Contains(" IMAP4rev1 2007f.") || text2.Contains(" Panda IMAP "))
			{
				QuirksMode = ImapQuirksMode.UW;
			}
			else if (text2.Contains("SmarterMail"))
			{
				QuirksMode = ImapQuirksMode.SmarterMail;
			}
			else if (text2.Contains("Yandex IMAP4rev1 "))
			{
				QuirksMode = ImapQuirksMode.Yandex;
			}
			State = state;
		}
		catch
		{
			Disconnect();
			throw;
		}
	}

	public void Disconnect()
	{
		if (Selected != null)
		{
			Selected.Reset();
			Selected.OnClosed();
			Selected = null;
		}
		current = null;
		if (Stream != null)
		{
			Stream.Dispose();
			Stream = null;
		}
		if (State != ImapEngineState.Disconnected)
		{
			State = ImapEngineState.Disconnected;
			OnDisconnected();
		}
	}

	internal async Task<string> ReadLineAsync(bool doAsync, CancellationToken cancellationToken)
	{
		using MemoryStream memory = new MemoryStream();
		while (!((!doAsync) ? Stream.ReadLine(memory, cancellationToken) : (await Stream.ReadLineAsync(memory, cancellationToken).ConfigureAwait(continueOnCapturedContext: false))))
		{
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

	internal Task<ImapToken> ReadTokenAsync(string specials, bool doAsync, CancellationToken cancellationToken)
	{
		return Stream.ReadTokenAsync(specials, doAsync, cancellationToken);
	}

	internal Task<ImapToken> ReadTokenAsync(bool doAsync, CancellationToken cancellationToken)
	{
		return Stream.ReadTokenAsync("[](){%*\\\"\n", doAsync, cancellationToken);
	}

	internal async Task<ImapToken> PeekTokenAsync(string specials, bool doAsync, CancellationToken cancellationToken)
	{
		ImapToken imapToken = await ReadTokenAsync(specials, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		Stream.UngetToken(imapToken);
		return imapToken;
	}

	internal Task<ImapToken> PeekTokenAsync(bool doAsync, CancellationToken cancellationToken)
	{
		return PeekTokenAsync("[](){%*\\\"\n", doAsync, cancellationToken);
	}

	public ImapToken ReadToken(CancellationToken cancellationToken)
	{
		return Stream.ReadToken(cancellationToken);
	}

	internal async Task<string> ReadLiteralAsync(bool doAsync, CancellationToken cancellationToken)
	{
		if (Stream.Mode != ImapStreamMode.Literal)
		{
			throw new InvalidOperationException();
		}
		using MemoryStream memory = new MemoryStream(Stream.LiteralLength);
		byte[] buf = ArrayPool<byte>.Shared.Rent(4096);
		int count;
		try
		{
			if (doAsync)
			{
				while ((count = await Stream.ReadAsync(buf, 0, 4096, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)) > 0)
				{
					memory.Write(buf, 0, count);
				}
			}
			else
			{
				while ((count = Stream.Read(buf, 0, 4096, cancellationToken)) > 0)
				{
					memory.Write(buf, 0, count);
				}
			}
		}
		finally
		{
			ArrayPool<byte>.Shared.Return(buf);
		}
		count = (int)memory.Length;
		buf = memory.GetBuffer();
		return Latin1.GetString(buf, 0, count);
	}

	private async Task SkipLineAsync(bool doAsync, CancellationToken cancellationToken)
	{
		ImapToken token;
		do
		{
			token = await ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			if (token.Type != ImapTokenType.Literal)
			{
				continue;
			}
			byte[] buf = ArrayPool<byte>.Shared.Rent(4096);
			try
			{
				int num;
				do
				{
					num = ((!doAsync) ? Stream.Read(buf, 0, 4096, cancellationToken) : (await Stream.ReadAsync(buf, 0, 4096, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)));
				}
				while (num > 0);
			}
			finally
			{
				ArrayPool<byte>.Shared.Return(buf);
			}
		}
		while (token.Type != ImapTokenType.Eoln);
	}

	private async Task UpdateCapabilitiesAsync(ImapTokenType sentinel, bool doAsync, CancellationToken cancellationToken)
	{
		ProtocolVersion = ImapProtocolVersion.Unknown;
		Capabilities &= ImapCapabilities.StartTLS;
		AuthenticationMechanisms.Clear();
		CompressionAlgorithms.Clear();
		ThreadingAlgorithms.Clear();
		SupportedContexts.Clear();
		CapabilitiesVersion++;
		AppendLimit = null;
		Rights.Clear();
		I18NLevel = 0;
		ImapToken imapToken = await ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		while (imapToken.Type == ImapTokenType.Atom)
		{
			string text = (string)imapToken.Value;
			if (text.StartsWith("AUTH=", StringComparison.OrdinalIgnoreCase))
			{
				AuthenticationMechanisms.Add(text.Substring("AUTH=".Length));
			}
			else if (text.StartsWith("APPENDLIMIT=", StringComparison.OrdinalIgnoreCase))
			{
				if (uint.TryParse(text.Substring("APPENDLIMIT=".Length), NumberStyles.None, CultureInfo.InvariantCulture, out var result))
				{
					AppendLimit = result;
				}
				Capabilities |= ImapCapabilities.AppendLimit;
			}
			else if (text.StartsWith("COMPRESS=", StringComparison.OrdinalIgnoreCase))
			{
				CompressionAlgorithms.Add(text.Substring("COMPRESS=".Length));
				Capabilities |= ImapCapabilities.Compress;
			}
			else if (text.StartsWith("CONTEXT=", StringComparison.OrdinalIgnoreCase))
			{
				SupportedContexts.Add(text.Substring("CONTEXT=".Length));
				Capabilities |= ImapCapabilities.Context;
			}
			else if (text.StartsWith("I18NLEVEL=", StringComparison.OrdinalIgnoreCase))
			{
				int.TryParse(text.Substring("I18NLEVEL=".Length), NumberStyles.None, CultureInfo.InvariantCulture, out var result2);
				I18NLevel = result2;
				Capabilities |= ImapCapabilities.I18NLevel;
			}
			else if (text.StartsWith("RIGHTS=", StringComparison.OrdinalIgnoreCase))
			{
				string rights = text.Substring("RIGHTS=".Length);
				Rights.AddRange(rights);
			}
			else if (text.StartsWith("THREAD=", StringComparison.OrdinalIgnoreCase))
			{
				string text2 = text.Substring("THREAD=".Length);
				string text3 = text2.ToUpperInvariant();
				if (!(text3 == "ORDEREDSUBJECT"))
				{
					if (text3 == "REFERENCES")
					{
						ThreadingAlgorithms.Add(ThreadingAlgorithm.References);
					}
				}
				else
				{
					ThreadingAlgorithms.Add(ThreadingAlgorithm.OrderedSubject);
				}
				Capabilities |= ImapCapabilities.Thread;
			}
			else
			{
				switch (text.ToUpperInvariant())
				{
				case "IMAP4":
					Capabilities |= ImapCapabilities.IMAP4;
					break;
				case "IMAP4REV1":
					Capabilities |= ImapCapabilities.IMAP4rev1;
					break;
				case "STATUS":
					Capabilities |= ImapCapabilities.Status;
					break;
				case "ACL":
					Capabilities |= ImapCapabilities.Acl;
					break;
				case "QUOTA":
					Capabilities |= ImapCapabilities.Quota;
					break;
				case "LITERAL+":
					Capabilities |= ImapCapabilities.LiteralPlus;
					break;
				case "IDLE":
					Capabilities |= ImapCapabilities.Idle;
					break;
				case "MAILBOX-REFERRALS":
					Capabilities |= ImapCapabilities.MailboxReferrals;
					break;
				case "LOGIN-REFERRALS":
					Capabilities |= ImapCapabilities.LoginReferrals;
					break;
				case "NAMESPACE":
					Capabilities |= ImapCapabilities.Namespace;
					break;
				case "ID":
					Capabilities |= ImapCapabilities.Id;
					break;
				case "CHILDREN":
					Capabilities |= ImapCapabilities.Children;
					break;
				case "LOGINDISABLED":
					Capabilities |= ImapCapabilities.LoginDisabled;
					break;
				case "STARTTLS":
					Capabilities |= ImapCapabilities.StartTLS;
					break;
				case "MULTIAPPEND":
					Capabilities |= ImapCapabilities.MultiAppend;
					break;
				case "BINARY":
					Capabilities |= ImapCapabilities.Binary;
					break;
				case "UNSELECT":
					Capabilities |= ImapCapabilities.Unselect;
					break;
				case "UIDPLUS":
					Capabilities |= ImapCapabilities.UidPlus;
					break;
				case "CATENATE":
					Capabilities |= ImapCapabilities.Catenate;
					break;
				case "CONDSTORE":
					Capabilities |= ImapCapabilities.CondStore;
					break;
				case "ESEARCH":
					Capabilities |= ImapCapabilities.ESearch;
					break;
				case "SASL-IR":
					Capabilities |= ImapCapabilities.SaslIR;
					break;
				case "WITHIN":
					Capabilities |= ImapCapabilities.Within;
					break;
				case "ENABLE":
					Capabilities |= ImapCapabilities.Enable;
					break;
				case "QRESYNC":
					Capabilities |= ImapCapabilities.QuickResync;
					break;
				case "SEARCHRES":
					Capabilities |= ImapCapabilities.SearchResults;
					break;
				case "SORT":
					Capabilities |= ImapCapabilities.Sort;
					break;
				case "ANNOTATE-EXPERIMENT-1":
					Capabilities |= ImapCapabilities.Annotate;
					break;
				case "LIST-EXTENDED":
					Capabilities |= ImapCapabilities.ListExtended;
					break;
				case "CONVERT":
					Capabilities |= ImapCapabilities.Convert;
					break;
				case "LANGUAGE":
					Capabilities |= ImapCapabilities.Language;
					break;
				case "ESORT":
					Capabilities |= ImapCapabilities.ESort;
					break;
				case "METADATA":
					Capabilities |= ImapCapabilities.Metadata;
					break;
				case "METADATA-SERVER":
					Capabilities |= ImapCapabilities.MetadataServer;
					break;
				case "NOTIFY":
					Capabilities |= ImapCapabilities.Notify;
					break;
				case "LIST-STATUS":
					Capabilities |= ImapCapabilities.ListStatus;
					break;
				case "SORT=DISPLAY":
					Capabilities |= ImapCapabilities.SortDisplay;
					break;
				case "CREATE-SPECIAL-USE":
					Capabilities |= ImapCapabilities.CreateSpecialUse;
					break;
				case "SPECIAL-USE":
					Capabilities |= ImapCapabilities.SpecialUse;
					break;
				case "SEARCH=FUZZY":
					Capabilities |= ImapCapabilities.FuzzySearch;
					break;
				case "MULTISEARCH":
					Capabilities |= ImapCapabilities.MultiSearch;
					break;
				case "MOVE":
					Capabilities |= ImapCapabilities.Move;
					break;
				case "UTF8=ACCEPT":
					Capabilities |= ImapCapabilities.UTF8Accept;
					break;
				case "UTF8=ONLY":
					Capabilities |= ImapCapabilities.UTF8Only;
					break;
				case "LITERAL-":
					Capabilities |= ImapCapabilities.LiteralMinus;
					break;
				case "APPENDLIMIT":
					Capabilities |= ImapCapabilities.AppendLimit;
					break;
				case "UNAUTHENTICATE":
					Capabilities |= ImapCapabilities.Unauthenticate;
					break;
				case "STATUS=SIZE":
					Capabilities |= ImapCapabilities.StatusSize;
					break;
				case "LIST-MYRIGHTS":
					Capabilities |= ImapCapabilities.ListMyRights;
					break;
				case "OBJECTID":
					Capabilities |= ImapCapabilities.ObjectID;
					break;
				case "REPLACE":
					Capabilities |= ImapCapabilities.Replace;
					break;
				case "SAVEDATE":
					Capabilities |= ImapCapabilities.SaveDate;
					break;
				case "XLIST":
					Capabilities |= ImapCapabilities.XList;
					break;
				case "X-GM-EXT-1":
					Capabilities |= ImapCapabilities.GMailExt1;
					QuirksMode = ImapQuirksMode.GMail;
					break;
				case "XSTOP":
					QuirksMode = ImapQuirksMode.ProtonMail;
					break;
				case "X-SUN-IMAP":
					QuirksMode = ImapQuirksMode.SunMicrosystems;
					break;
				case "XYMHIGHESTMODSEQ":
					QuirksMode = ImapQuirksMode.Yahoo;
					break;
				}
			}
			imapToken = await ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		AssertToken(imapToken, sentinel, "Syntax error in {0}. {1}", "CAPABILITIES", imapToken);
		Stream.UngetToken(imapToken);
		if ((Capabilities & ImapCapabilities.IMAP4rev1) != ImapCapabilities.None)
		{
			ProtocolVersion = ImapProtocolVersion.IMAP4rev1;
			Capabilities |= ImapCapabilities.Status;
		}
		else if ((Capabilities & ImapCapabilities.IMAP4) != ImapCapabilities.None)
		{
			ProtocolVersion = ImapProtocolVersion.IMAP4;
		}
		if ((Capabilities & ImapCapabilities.QuickResync) != ImapCapabilities.None)
		{
			Capabilities |= ImapCapabilities.CondStore;
		}
		if ((Capabilities & ImapCapabilities.UTF8Only) != ImapCapabilities.None)
		{
			Capabilities |= ImapCapabilities.UTF8Accept;
		}
	}

	private async Task UpdateNamespacesAsync(bool doAsync, CancellationToken cancellationToken)
	{
		List<FolderNamespaceCollection> namespaces = new List<FolderNamespaceCollection> { PersonalNamespaces, OtherNamespaces, SharedNamespaces };
		int n = 0;
		PersonalNamespaces.Clear();
		SharedNamespaces.Clear();
		OtherNamespaces.Clear();
		ImapToken imapToken = await ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		do
		{
			if (imapToken.Type == ImapTokenType.OpenParen)
			{
				imapToken = await ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				while (imapToken.Type == ImapTokenType.OpenParen)
				{
					imapToken = await ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
					AssertToken(imapToken, ImapTokenType.Atom, ImapTokenType.QString, "Syntax error in untagged {0} response. {1}", "NAMESPACE", imapToken);
					string path = (string)imapToken.Value;
					imapToken = await ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
					AssertToken(imapToken, ImapTokenType.QString, ImapTokenType.Nil, "Syntax error in untagged {0} response. {1}", "NAMESPACE", imapToken);
					string text = ((imapToken.Type == ImapTokenType.Nil) ? string.Empty : ((string)imapToken.Value));
					char c;
					if (text.Length > 0)
					{
						c = text[0];
						path = path.TrimEnd(c);
					}
					else
					{
						c = '\0';
					}
					namespaces[n].Add(new FolderNamespace(c, DecodeMailboxName(path)));
					if (!GetCachedFolder(path, out var folder))
					{
						folder = CreateImapFolder(path, FolderAttributes.None, c);
						CacheFolder(folder);
					}
					folder.UpdateIsNamespace(value: true);
					while (true)
					{
						imapToken = await ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
						if (imapToken.Type == ImapTokenType.CloseParen)
						{
							break;
						}
						AssertToken(imapToken, ImapTokenType.Atom, ImapTokenType.QString, "Syntax error in untagged {0} response. {1}", "NAMESPACE", imapToken);
						imapToken = await ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
						AssertToken(imapToken, ImapTokenType.OpenParen, "Syntax error in untagged {0} response. {1}", "NAMESPACE", imapToken);
						while (true)
						{
							imapToken = await ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
							if (imapToken.Type == ImapTokenType.CloseParen)
							{
								break;
							}
							AssertToken(imapToken, ImapTokenType.Atom, ImapTokenType.QString, "Syntax error in untagged {0} response. {1}", "NAMESPACE", imapToken);
						}
					}
					imapToken = await ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				}
				AssertToken(imapToken, ImapTokenType.CloseParen, "Syntax error in untagged {0} response. {1}", "NAMESPACE", imapToken);
			}
			else
			{
				AssertToken(imapToken, ImapTokenType.Nil, "Syntax error in untagged {0} response. {1}", "NAMESPACE", imapToken);
			}
			imapToken = await ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			n++;
		}
		while (n < 3);
		while (imapToken.Type != ImapTokenType.Eoln)
		{
			imapToken = await ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
	}

	private void ProcessResponseCodes(ImapCommand ic)
	{
		foreach (ImapResponseCode respCode in ic.RespCodes)
		{
			switch (respCode.Type)
			{
			case ImapResponseCodeType.Alert:
				OnAlert(respCode.Message);
				break;
			case ImapResponseCodeType.WebAlert:
				OnWebAlert(((WebAlertResponseCode)respCode).WebUri, respCode.Message);
				break;
			case ImapResponseCodeType.NotificationOverflow:
				OnNotificationOverflow();
				break;
			}
		}
	}

	private void EmitMetadataChanged(Metadata metadata)
	{
		string encodedName = metadata.EncodedName;
		ImapFolder value;
		if (encodedName.Length == 0)
		{
			OnMetadataChanged(metadata);
		}
		else if (FolderCache.TryGetValue(encodedName, out value))
		{
			value.OnMetadataChanged(metadata);
		}
	}

	internal MetadataCollection FilterMetadata(MetadataCollection metadata, string encodedName)
	{
		for (int i = 0; i < metadata.Count; i++)
		{
			if (!(metadata[i].EncodedName == encodedName))
			{
				EmitMetadataChanged(metadata[i]);
				metadata.RemoveAt(i);
				i--;
			}
		}
		return metadata;
	}

	internal void ProcessMetadataChanges(MetadataCollection metadata)
	{
		for (int i = 0; i < metadata.Count; i++)
		{
			EmitMetadataChanged(metadata[i]);
		}
	}

	internal static ImapResponseCodeType GetResponseCodeType(string atom)
	{
		return atom.ToUpperInvariant() switch
		{
			"ALERT" => ImapResponseCodeType.Alert, 
			"BADCHARSET" => ImapResponseCodeType.BadCharset, 
			"CAPABILITY" => ImapResponseCodeType.Capability, 
			"NEWNAME" => ImapResponseCodeType.NewName, 
			"PARSE" => ImapResponseCodeType.Parse, 
			"PERMANENTFLAGS" => ImapResponseCodeType.PermanentFlags, 
			"READ-ONLY" => ImapResponseCodeType.ReadOnly, 
			"READ-WRITE" => ImapResponseCodeType.ReadWrite, 
			"TRYCREATE" => ImapResponseCodeType.TryCreate, 
			"UIDNEXT" => ImapResponseCodeType.UidNext, 
			"UIDVALIDITY" => ImapResponseCodeType.UidValidity, 
			"UNSEEN" => ImapResponseCodeType.Unseen, 
			"REFERRAL" => ImapResponseCodeType.Referral, 
			"UNKNOWN-CTE" => ImapResponseCodeType.UnknownCte, 
			"APPENDUID" => ImapResponseCodeType.AppendUid, 
			"COPYUID" => ImapResponseCodeType.CopyUid, 
			"UIDNOTSTICKY" => ImapResponseCodeType.UidNotSticky, 
			"URLMECH" => ImapResponseCodeType.UrlMech, 
			"BADURL" => ImapResponseCodeType.BadUrl, 
			"TOOBIG" => ImapResponseCodeType.TooBig, 
			"HIGHESTMODSEQ" => ImapResponseCodeType.HighestModSeq, 
			"MODIFIED" => ImapResponseCodeType.Modified, 
			"NOMODSEQ" => ImapResponseCodeType.NoModSeq, 
			"COMPRESSIONACTIVE" => ImapResponseCodeType.CompressionActive, 
			"CLOSED" => ImapResponseCodeType.Closed, 
			"NOTSAVED" => ImapResponseCodeType.NotSaved, 
			"BADCOMPARATOR" => ImapResponseCodeType.BadComparator, 
			"ANNOTATE" => ImapResponseCodeType.Annotate, 
			"ANNOTATIONS" => ImapResponseCodeType.Annotations, 
			"MAXCONVERTMESSAGES" => ImapResponseCodeType.MaxConvertMessages, 
			"MAXCONVERTPARTS" => ImapResponseCodeType.MaxConvertParts, 
			"TEMPFAIL" => ImapResponseCodeType.TempFail, 
			"NOUPDATE" => ImapResponseCodeType.NoUpdate, 
			"METADATA" => ImapResponseCodeType.Metadata, 
			"NOTIFICATIONOVERFLOW" => ImapResponseCodeType.NotificationOverflow, 
			"BADEVENT" => ImapResponseCodeType.BadEvent, 
			"UNDEFINED-FILTER" => ImapResponseCodeType.UndefinedFilter, 
			"UNAVAILABLE" => ImapResponseCodeType.Unavailable, 
			"AUTHENTICATIONFAILED" => ImapResponseCodeType.AuthenticationFailed, 
			"AUTHORIZATIONFAILED" => ImapResponseCodeType.AuthorizationFailed, 
			"EXPIRED" => ImapResponseCodeType.Expired, 
			"PRIVACYREQUIRED" => ImapResponseCodeType.PrivacyRequired, 
			"CONTACTADMIN" => ImapResponseCodeType.ContactAdmin, 
			"NOPERM" => ImapResponseCodeType.NoPerm, 
			"INUSE" => ImapResponseCodeType.InUse, 
			"EXPUNGEISSUED" => ImapResponseCodeType.ExpungeIssued, 
			"CORRUPTION" => ImapResponseCodeType.Corruption, 
			"SERVERBUG" => ImapResponseCodeType.ServerBug, 
			"CLIENTBUG" => ImapResponseCodeType.ClientBug, 
			"CANNOT" => ImapResponseCodeType.CanNot, 
			"LIMIT" => ImapResponseCodeType.Limit, 
			"OVERQUOTA" => ImapResponseCodeType.OverQuota, 
			"ALREADYEXISTS" => ImapResponseCodeType.AlreadyExists, 
			"NONEXISTENT" => ImapResponseCodeType.NonExistent, 
			"USEATTR" => ImapResponseCodeType.UseAttr, 
			"MAILBOXID" => ImapResponseCodeType.MailboxId, 
			"WEBALERT" => ImapResponseCodeType.WebAlert, 
			_ => ImapResponseCodeType.Unknown, 
		};
	}

	public async Task<ImapResponseCode> ParseResponseCodeAsync(bool isTagged, bool doAsync, CancellationToken cancellationToken)
	{
		uint validity = ((Selected != null) ? Selected.UidValidity : 0u);
		ImapToken imapToken = await ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		AssertToken(imapToken, ImapTokenType.Atom, "Syntax error in response code. {0}", imapToken);
		string atom = (string)imapToken.Value;
		imapToken = await ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		ImapResponseCode code = ImapResponseCode.Create(GetResponseCodeType(atom));
		code.IsTagged = isTagged;
		switch (code.Type)
		{
		case ImapResponseCodeType.BadCharset:
			if (imapToken.Type == ImapTokenType.OpenParen)
			{
				imapToken = await ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				SupportedCharsets.Clear();
				while (imapToken.Type == ImapTokenType.Atom || imapToken.Type == ImapTokenType.QString)
				{
					SupportedCharsets.Add((string)imapToken.Value);
					imapToken = await ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				}
				AssertToken(imapToken, ImapTokenType.CloseParen, "Syntax error in {0} response code. {1}", "BADCHARSET", imapToken);
				imapToken = await ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			}
			break;
		case ImapResponseCodeType.Capability:
			Stream.UngetToken(imapToken);
			await UpdateCapabilitiesAsync(ImapTokenType.CloseBracket, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			imapToken = await ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			break;
		case ImapResponseCodeType.PermanentFlags:
		{
			PermanentFlagsResponseCode permanentFlagsResponseCode = (PermanentFlagsResponseCode)code;
			Stream.UngetToken(imapToken);
			PermanentFlagsResponseCode permanentFlagsResponseCode2 = permanentFlagsResponseCode;
			permanentFlagsResponseCode2.Flags = await ImapUtils.ParseFlagsListAsync(this, "PERMANENTFLAGS", null, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			imapToken = await ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			break;
		}
		case ImapResponseCodeType.UidNext:
		{
			UidNextResponseCode uidNextResponseCode = (UidNextResponseCode)code;
			uint num2 = ParseNumber(imapToken, false, "Syntax error in {0} response code. {1}", "UIDNEXT", imapToken);
			uidNextResponseCode.Uid = ((num2 != 0) ? new UniqueId(num2) : UniqueId.Invalid);
			imapToken = await ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			break;
		}
		case ImapResponseCodeType.UidValidity:
		{
			UidValidityResponseCode uidValidityResponseCode = (UidValidityResponseCode)code;
			uidValidityResponseCode.UidValidity = ParseNumber(imapToken, false, "Syntax error in {0} response code. {1}", "UIDVALIDITY", imapToken);
			imapToken = await ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			break;
		}
		case ImapResponseCodeType.Unseen:
		{
			UnseenResponseCode unseenResponseCode = (UnseenResponseCode)code;
			uint num = ParseNumber(imapToken, false, "Syntax error in {0} response code. {1}", "UNSEEN", imapToken);
			unseenResponseCode.Index = (int)((num != 0) ? (num - 1) : 0);
			imapToken = await ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			break;
		}
		case ImapResponseCodeType.NewName:
		{
			NewNameResponseCode rename = (NewNameResponseCode)code;
			AssertToken(imapToken, ImapTokenType.Atom, ImapTokenType.QString, "Syntax error in {0} response code. {1}", "NEWNAME", imapToken);
			rename.OldName = (string)imapToken.Value;
			imapToken = await ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			AssertToken(imapToken, ImapTokenType.Atom, ImapTokenType.QString, "Syntax error in {0} response code. {1}", "NEWNAME", imapToken);
			rename.NewName = (string)imapToken.Value;
			imapToken = await ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			break;
		}
		case ImapResponseCodeType.AppendUid:
		{
			AppendUidResponseCode append = (AppendUidResponseCode)code;
			append.UidValidity = ParseNumber(imapToken, false, "Syntax error in {0} response code. {1}", "APPENDUID", imapToken);
			imapToken = await ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			append.UidSet = ParseUidSet(imapToken, append.UidValidity, "Syntax error in {0} response code. {1}", "APPENDUID", imapToken);
			imapToken = await ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			break;
		}
		case ImapResponseCodeType.CopyUid:
		{
			CopyUidResponseCode copy = (CopyUidResponseCode)code;
			copy.UidValidity = ParseNumber(imapToken, false, "Syntax error in {0} response code. {1}", "COPYUID", imapToken);
			imapToken = await ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			if (imapToken.Type != ImapTokenType.CloseBracket)
			{
				copy.SrcUidSet = ParseUidSet(imapToken, validity, "Syntax error in {0} response code. {1}", "COPYUID", imapToken);
			}
			else
			{
				copy.SrcUidSet = new UniqueIdSet();
				Stream.UngetToken(imapToken);
			}
			imapToken = await ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			if (imapToken.Type != ImapTokenType.CloseBracket)
			{
				copy.DestUidSet = ParseUidSet(imapToken, copy.UidValidity, "Syntax error in {0} response code. {1}", "COPYUID", imapToken);
			}
			else
			{
				copy.DestUidSet = new UniqueIdSet();
				Stream.UngetToken(imapToken);
			}
			imapToken = await ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			break;
		}
		case ImapResponseCodeType.BadUrl:
		{
			BadUrlResponseCode badUrlResponseCode = (BadUrlResponseCode)code;
			AssertToken(imapToken, ImapTokenType.Atom, ImapTokenType.QString, "Syntax error in {0} response code. {1}", "BADURL", imapToken);
			badUrlResponseCode.BadUrl = (string)imapToken.Value;
			imapToken = await ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			break;
		}
		case ImapResponseCodeType.HighestModSeq:
		{
			HighestModSeqResponseCode highestModSeqResponseCode = (HighestModSeqResponseCode)code;
			highestModSeqResponseCode.HighestModSeq = ParseNumber64(imapToken, false, "Syntax error in {0} response code. {1}", "HIGHESTMODSEQ", imapToken);
			imapToken = await ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			break;
		}
		case ImapResponseCodeType.Modified:
		{
			ModifiedResponseCode modifiedResponseCode = (ModifiedResponseCode)code;
			modifiedResponseCode.UidSet = ParseUidSet(imapToken, validity, "Syntax error in {0} response code. {1}", "MODIFIED", imapToken);
			imapToken = await ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			break;
		}
		case ImapResponseCodeType.MaxConvertMessages:
		case ImapResponseCodeType.MaxConvertParts:
		{
			MaxConvertResponseCode maxConvertResponseCode = (MaxConvertResponseCode)code;
			maxConvertResponseCode.MaxConvert = ParseNumber(imapToken, false, "Syntax error in {0} response code. {1}", atom, imapToken);
			imapToken = await ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			break;
		}
		case ImapResponseCodeType.NoUpdate:
		{
			NoUpdateResponseCode noUpdateResponseCode = (NoUpdateResponseCode)code;
			AssertToken(imapToken, ImapTokenType.Atom, ImapTokenType.QString, "Syntax error in {0} response code. {1}", "NOUPDATE", imapToken);
			noUpdateResponseCode.Tag = (string)imapToken.Value;
			imapToken = await ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			break;
		}
		case ImapResponseCodeType.Annotate:
		{
			AnnotateResponseCode annotateResponseCode = (AnnotateResponseCode)code;
			AssertToken(imapToken, ImapTokenType.Atom, "Syntax error in {0} response code. {1}", "ANNOTATE", imapToken);
			string text2 = ((string)imapToken.Value).ToUpperInvariant();
			if (!(text2 == "TOOBIG"))
			{
				if (text2 == "TOOMANY")
				{
					annotateResponseCode.SubType = AnnotateResponseCodeSubType.TooMany;
				}
			}
			else
			{
				annotateResponseCode.SubType = AnnotateResponseCodeSubType.TooBig;
			}
			imapToken = await ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			break;
		}
		case ImapResponseCodeType.Annotations:
		{
			AnnotationsResponseCode annotations = (AnnotationsResponseCode)code;
			AssertToken(imapToken, ImapTokenType.Atom, "Syntax error in {0} response code. {1}", "ANNOTATIONS", imapToken);
			string text = ((string)imapToken.Value).ToUpperInvariant();
			if (!(text == "NONE"))
			{
				if (text == "READ-ONLY")
				{
					annotations.Access = AnnotationAccess.ReadOnly;
				}
				else
				{
					annotations.Access = AnnotationAccess.ReadWrite;
					annotations.MaxSize = ParseNumber(imapToken, false, "Syntax error in {0} response code. {1}", "ANNOTATIONS", imapToken);
				}
			}
			imapToken = await ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			if (annotations.Access == AnnotationAccess.None)
			{
				break;
			}
			annotations.Scopes = AnnotationScope.Both;
			if (imapToken.Type != ImapTokenType.CloseBracket)
			{
				AssertToken(imapToken, ImapTokenType.Atom, "Syntax error in {0} response code. {1}", "ANNOTATIONS", imapToken);
				if (((string)imapToken.Value).Equals("NOPRIVATE", StringComparison.OrdinalIgnoreCase))
				{
					annotations.Scopes = AnnotationScope.Shared;
				}
				imapToken = await ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			}
			break;
		}
		case ImapResponseCodeType.Metadata:
		{
			MetadataResponseCode metadata = (MetadataResponseCode)code;
			AssertToken(imapToken, ImapTokenType.Atom, "Syntax error in {0} response code. {1}", "METADATA", imapToken);
			switch (((string)imapToken.Value).ToUpperInvariant())
			{
			case "LONGENTRIES":
				metadata.SubType = MetadataResponseCodeSubType.LongEntries;
				metadata.IsError = false;
				imapToken = await ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				metadata.Value = ParseNumber(imapToken, false, "Syntax error in {0} response code. {1}", "METADATA LONGENTRIES", imapToken);
				break;
			case "MAXSIZE":
				metadata.SubType = MetadataResponseCodeSubType.MaxSize;
				imapToken = await ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				metadata.Value = ParseNumber(imapToken, false, "Syntax error in {0} response code. {1}", "METADATA MAXSIZE", imapToken);
				break;
			case "TOOMANY":
				metadata.SubType = MetadataResponseCodeSubType.TooMany;
				break;
			case "NOPRIVATE":
				metadata.SubType = MetadataResponseCodeSubType.NoPrivate;
				break;
			}
			imapToken = await ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			break;
		}
		case ImapResponseCodeType.UndefinedFilter:
		{
			UndefinedFilterResponseCode undefinedFilterResponseCode = (UndefinedFilterResponseCode)code;
			AssertToken(imapToken, ImapTokenType.Atom, "Syntax error in {0} response code. {1}", "UNDEFINED-FILTER", imapToken);
			undefinedFilterResponseCode.Name = (string)imapToken.Value;
			imapToken = await ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			break;
		}
		case ImapResponseCodeType.MailboxId:
		{
			MailboxIdResponseCode mailboxid = (MailboxIdResponseCode)code;
			AssertToken(imapToken, ImapTokenType.OpenParen, "Syntax error in {0} response code. {1}", "MAILBOXID", imapToken);
			imapToken = await ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			AssertToken(imapToken, ImapTokenType.Atom, "Syntax error in {0} response code. {1}", "MAILBOXID", imapToken);
			mailboxid.MailboxId = (string)imapToken.Value;
			imapToken = await ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			AssertToken(imapToken, ImapTokenType.CloseParen, "Syntax error in {0} response code. {1}", "MAILBOXID", imapToken);
			imapToken = await ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			break;
		}
		case ImapResponseCodeType.WebAlert:
		{
			WebAlertResponseCode webAlertResponseCode = (WebAlertResponseCode)code;
			AssertToken(imapToken, ImapTokenType.Atom, "Syntax error in {0} response code. {1}", "WEBALERT", imapToken);
			Uri.TryCreate((string)imapToken.Value, UriKind.Absolute, out webAlertResponseCode.WebUri);
			imapToken = await ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			break;
		}
		default:
			while (imapToken.Type != ImapTokenType.CloseBracket && imapToken.Type != ImapTokenType.Eoln)
			{
				imapToken = await ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			}
			break;
		}
		AssertToken(imapToken, ImapTokenType.CloseBracket, "Syntax error in response code. {0}", imapToken);
		ImapResponseCode imapResponseCode = code;
		imapResponseCode.Message = (await ReadLineAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Trim();
		return code;
	}

	private async Task UpdateStatusAsync(bool doAsync, CancellationToken cancellationToken)
	{
		ImapToken imapToken = await ReadTokenAsync("(){%*\\\"\n", doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		string encodedName;
		switch (imapToken.Type)
		{
		case ImapTokenType.Literal:
			encodedName = await ReadLiteralAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			break;
		case ImapTokenType.Atom:
		case ImapTokenType.QString:
			encodedName = (string)imapToken.Value;
			break;
		case ImapTokenType.Nil:
			encodedName = "NIL";
			break;
		default:
			throw UnexpectedToken("Syntax error in untagged {0} response. {1}", "STATUS", imapToken);
		}
		GetCachedFolder(encodedName, out var folder);
		imapToken = await ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		AssertToken(imapToken, ImapTokenType.OpenParen, "Syntax error in untagged {0} response. {1}", "STATUS", imapToken);
		while (true)
		{
			imapToken = await ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			if (imapToken.Type == ImapTokenType.CloseParen)
			{
				break;
			}
			AssertToken(imapToken, ImapTokenType.Atom, "Syntax error in untagged {0} response. {1}", "STATUS", imapToken);
			string atom = (string)imapToken.Value;
			imapToken = await ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			switch (atom.ToUpperInvariant())
			{
			case "HIGHESTMODSEQ":
			{
				AssertToken(imapToken, ImapTokenType.Atom, "Syntax error in untagged {0} response. {1}", "STATUS", imapToken);
				ulong modseq = ParseNumber64(imapToken, false, "Syntax error in {0}. {1}", atom, imapToken);
				folder?.UpdateHighestModSeq(modseq);
				break;
			}
			case "MESSAGES":
			{
				AssertToken(imapToken, ImapTokenType.Atom, "Syntax error in untagged {0} response. {1}", "STATUS", imapToken);
				uint count = ParseNumber(imapToken, false, "Syntax error in {0}. {1}", atom, imapToken);
				folder?.OnExists((int)count);
				break;
			}
			case "RECENT":
			{
				AssertToken(imapToken, ImapTokenType.Atom, "Syntax error in untagged {0} response. {1}", "STATUS", imapToken);
				uint count = ParseNumber(imapToken, false, "Syntax error in {0}. {1}", atom, imapToken);
				folder?.OnRecent((int)count);
				break;
			}
			case "UIDNEXT":
			{
				AssertToken(imapToken, ImapTokenType.Atom, "Syntax error in untagged {0} response. {1}", "STATUS", imapToken);
				uint validity = ParseNumber(imapToken, false, "Syntax error in {0}. {1}", atom, imapToken);
				folder?.UpdateUidNext((validity != 0) ? new UniqueId(validity) : UniqueId.Invalid);
				break;
			}
			case "UIDVALIDITY":
			{
				AssertToken(imapToken, ImapTokenType.Atom, "Syntax error in untagged {0} response. {1}", "STATUS", imapToken);
				uint validity = ParseNumber(imapToken, false, "Syntax error in {0}. {1}", atom, imapToken);
				folder?.UpdateUidValidity(validity);
				break;
			}
			case "UNSEEN":
			{
				AssertToken(imapToken, ImapTokenType.Atom, "Syntax error in untagged {0} response. {1}", "STATUS", imapToken);
				uint count = ParseNumber(imapToken, false, "Syntax error in {0}. {1}", atom, imapToken);
				folder?.UpdateUnread((int)count);
				break;
			}
			case "APPENDLIMIT":
				if (imapToken.Type == ImapTokenType.Atom)
				{
					uint value2 = ParseNumber(imapToken, false, "Syntax error in {0}. {1}", atom, imapToken);
					folder?.UpdateAppendLimit(value2);
				}
				else
				{
					AssertToken(imapToken, ImapTokenType.Nil, "Syntax error in untagged {0} response. {1}", "STATUS", imapToken);
					folder?.UpdateAppendLimit(null);
				}
				break;
			case "SIZE":
			{
				AssertToken(imapToken, ImapTokenType.Atom, "Syntax error in untagged {0} response. {1}", "STATUS", imapToken);
				ulong value = ParseNumber64(imapToken, false, "Syntax error in {0}. {1}", atom, imapToken);
				folder?.UpdateSize(value);
				break;
			}
			case "MAILBOXID":
				AssertToken(imapToken, ImapTokenType.OpenParen, "Syntax error in untagged {0} response. {1}", "STATUS", imapToken);
				imapToken = await ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				AssertToken(imapToken, ImapTokenType.Atom, "Syntax error in {0}. {1}", atom, imapToken);
				folder?.UpdateId((string)imapToken.Value);
				imapToken = await ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				AssertToken(imapToken, ImapTokenType.CloseParen, "Syntax error in untagged {0} response. {1}", "STATUS", imapToken);
				break;
			}
		}
		imapToken = await ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		AssertToken(imapToken, ImapTokenType.Eoln, "Syntax error in untagged {0} response. {1}", "STATUS", imapToken);
	}

	internal async Task<ImapUntaggedResult> ProcessUntaggedResponseAsync(bool doAsync, CancellationToken cancellationToken)
	{
		ImapToken imapToken = await ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		ImapFolder folder = current.Folder ?? Selected;
		ImapUntaggedResult result = ImapUntaggedResult.Handled;
		string atom;
		if (imapToken.Type == ImapTokenType.OpenBracket)
		{
			Stream.UngetToken(imapToken);
			atom = "OK";
		}
		else
		{
			if (imapToken.Type != ImapTokenType.Atom)
			{
				Stream.UngetToken(imapToken);
				await SkipLineAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				return result;
			}
			atom = (string)imapToken.Value;
		}
		switch (atom.ToUpperInvariant())
		{
		case "BYE":
			imapToken = await ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			if (imapToken.Type == ImapTokenType.OpenBracket)
			{
				ImapResponseCode item = await ParseResponseCodeAsync(isTagged: false, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				current.RespCodes.Add(item);
			}
			else
			{
				string text = imapToken.Value.ToString();
				string text2 = text + await ReadLineAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				current.ResponseText = text2.TrimEnd();
			}
			current.Bye = true;
			if (QuirksMode == ImapQuirksMode.Yandex && !current.Logout)
			{
				current.Status = ImapCommandStatus.Complete;
			}
			break;
		case "CAPABILITY":
			await UpdateCapabilitiesAsync(ImapTokenType.Eoln, doAsync, cancellationToken);
			await ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			break;
		case "ENABLED":
			while (true)
			{
				imapToken = await ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				if (imapToken.Type == ImapTokenType.Eoln)
				{
					break;
				}
				AssertToken(imapToken, ImapTokenType.Atom, "Syntax error in untagged {0} response. {1}", atom, imapToken);
				string text4 = (string)imapToken.Value;
				string text5 = text4.ToUpperInvariant();
				if (!(text5 == "UTF8=ACCEPT"))
				{
					if (text5 == "QRESYNC")
					{
						QResyncEnabled = true;
					}
				}
				else
				{
					UTF8Enabled = true;
				}
			}
			break;
		case "FLAGS":
		{
			ImapFolder imapFolder = folder;
			imapFolder.UpdateAcceptedFlags(await ImapUtils.ParseFlagsListAsync(this, atom, null, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false));
			imapToken = await ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			AssertToken(imapToken, ImapTokenType.Eoln, "Syntax error in untagged {0} response. {1}", atom, imapToken);
			break;
		}
		case "NAMESPACE":
			await UpdateNamespacesAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			break;
		case "STATUS":
			await UpdateStatusAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			break;
		case "OK":
		case "NO":
		case "BAD":
			result = ((!atom.Equals("OK", StringComparison.OrdinalIgnoreCase)) ? (atom.Equals("NO", StringComparison.OrdinalIgnoreCase) ? ImapUntaggedResult.No : ImapUntaggedResult.Bad) : ImapUntaggedResult.Ok);
			imapToken = await ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			if (imapToken.Type == ImapTokenType.OpenBracket)
			{
				ImapResponseCode item2 = await ParseResponseCodeAsync(isTagged: false, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				current.RespCodes.Add(item2);
			}
			else if (imapToken.Type != ImapTokenType.Eoln)
			{
				string text = (string)imapToken.Value;
				string text3 = text + await ReadLineAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				current.ResponseText = text3.TrimEnd();
			}
			break;
		default:
		{
			ImapUntaggedHandler value;
			if (uint.TryParse(atom, NumberStyles.None, CultureInfo.InvariantCulture, out var number))
			{
				imapToken = await ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				AssertToken(imapToken, ImapTokenType.Atom, "Syntax error in untagged response. {0}", imapToken);
				atom = (string)imapToken.Value;
				if (current.UntaggedHandlers.TryGetValue(atom, out value))
				{
					await value(this, current, (int)(number - 1), doAsync).ConfigureAwait(continueOnCapturedContext: false);
				}
				else if (folder != null)
				{
					switch (atom.ToUpperInvariant())
					{
					case "EXISTS":
						folder.OnExists((int)number);
						break;
					case "EXPUNGE":
						if (number == 0)
						{
							throw UnexpectedToken("Syntax error in untagged EXPUNGE response. Unexpected message index: 0");
						}
						folder.OnExpunge((int)(number - 1));
						break;
					case "FETCH":
						await folder.OnFetchAsync(this, (int)(number - 1), doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
						break;
					case "RECENT":
						folder.OnRecent((int)number);
						break;
					}
				}
				await SkipLineAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			}
			else if (current.UntaggedHandlers.TryGetValue(atom, out value))
			{
				await value(this, current, -1, doAsync).ConfigureAwait(continueOnCapturedContext: false);
				await SkipLineAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			}
			else if (atom.Equals("LIST", StringComparison.OrdinalIgnoreCase))
			{
				await ImapUtils.ParseFolderListAsync(this, null, isLsub: false, returnsSubscribed: true, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				imapToken = await ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				AssertToken(imapToken, ImapTokenType.Eoln, "Syntax error in untagged LIST response. {0}", imapToken);
			}
			else if (atom.Equals("METADATA", StringComparison.OrdinalIgnoreCase))
			{
				MetadataCollection metadata = new MetadataCollection();
				await ImapUtils.ParseMetadataAsync(this, metadata, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				ProcessMetadataChanges(metadata);
				imapToken = await ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				AssertToken(imapToken, ImapTokenType.Eoln, "Syntax error in untagged LIST response. {0}", imapToken);
			}
			else if (!atom.Equals("VANISHED", StringComparison.OrdinalIgnoreCase) || folder == null)
			{
				await SkipLineAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			}
			else
			{
				await folder.OnVanishedAsync(this, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				await SkipLineAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			}
			break;
		}
		}
		return result;
	}

	private async Task IterateAsync(bool doAsync)
	{
		lock (queue)
		{
			if (queue.Count == 0)
			{
				throw new InvalidOperationException("The IMAP command queue is empty.");
			}
			if (IsBusy)
			{
				throw new InvalidOperationException("The ImapClient is currently busy processing a command in another thread. Lock the SyncRoot property to properly synchronize your threads.");
			}
			current = queue[0];
			queue.RemoveAt(0);
			try
			{
				current.CancellationToken.ThrowIfCancellationRequested();
			}
			catch
			{
				queue.RemoveAll((ImapCommand x) => x.CancellationToken.IsCancellationRequested);
				current = null;
				throw;
			}
		}
		current.Status = ImapCommandStatus.Active;
		try
		{
			while (await current.StepAsync(doAsync).ConfigureAwait(continueOnCapturedContext: false))
			{
			}
			if (current.Bye && !current.Logout)
			{
				throw new ImapProtocolException("Bye.");
			}
		}
		catch (ImapProtocolException)
		{
			ImapCommand imapCommand = current;
			Disconnect();
			if (imapCommand.Bye)
			{
				if (imapCommand.RespCodes.Count > 0)
				{
					ImapResponseCode imapResponseCode = imapCommand.RespCodes[imapCommand.RespCodes.Count - 1];
					if (imapResponseCode.Type == ImapResponseCodeType.Alert)
					{
						OnAlert(imapResponseCode.Message);
						throw new ImapProtocolException(imapResponseCode.Message);
					}
				}
				if (!string.IsNullOrEmpty(imapCommand.ResponseText))
				{
					throw new ImapProtocolException(imapCommand.ResponseText);
				}
			}
			throw;
		}
		catch
		{
			Disconnect();
			throw;
		}
		finally
		{
			current = null;
		}
	}

	public async Task RunAsync(ImapCommand ic, bool doAsync)
	{
		if (ic == null)
		{
			throw new ArgumentNullException("ic");
		}
		while (ic.Status < ImapCommandStatus.Complete)
		{
			await IterateAsync(doAsync).ConfigureAwait(continueOnCapturedContext: false);
		}
		ProcessResponseCodes(ic);
	}

	public IEnumerable<ImapCommand> CreateCommands(CancellationToken cancellationToken, ImapFolder folder, string format, IList<UniqueId> uids, params object[] args)
	{
		List<object> list = new List<object>();
		list.Add("1");
		for (int i = 0; i < args.Length; i++)
		{
			list.Add(args[i]);
		}
		args = list.ToArray();
		int maxLength;
		if (QuirksMode == ImapQuirksMode.Courier)
		{
			maxLength = 16384;
		}
		else
		{
			int num = ImapCommand.EstimateCommandLength(this, format, args);
			switch (QuirksMode)
			{
			case ImapQuirksMode.Dovecot:
				maxLength = Math.Max(66688 - num, 24);
				break;
			case ImapQuirksMode.GMail:
				maxLength = Math.Max(16672 - num, 24);
				break;
			case ImapQuirksMode.UW:
			case ImapQuirksMode.Yahoo:
				maxLength = Math.Max(1000 - num, 24);
				break;
			default:
				maxLength = Math.Max(8000 - num, 24);
				break;
			}
		}
		foreach (string item in UniqueIdSet.EnumerateSerializedSubsets(uids, maxLength))
		{
			args[0] = item;
			yield return new ImapCommand(this, cancellationToken, folder, format, args);
		}
	}

	public IEnumerable<ImapCommand> QueueCommands(CancellationToken cancellationToken, ImapFolder folder, string format, IList<UniqueId> uids, params object[] args)
	{
		foreach (ImapCommand item in CreateCommands(cancellationToken, folder, format, uids, args))
		{
			QueueCommand(item);
			yield return item;
		}
	}

	public ImapCommand QueueCommand(CancellationToken cancellationToken, ImapFolder folder, FormatOptions options, string format, params object[] args)
	{
		ImapCommand imapCommand = new ImapCommand(this, cancellationToken, folder, options, format, args);
		QueueCommand(imapCommand);
		return imapCommand;
	}

	public ImapCommand QueueCommand(CancellationToken cancellationToken, ImapFolder folder, string format, params object[] args)
	{
		return QueueCommand(cancellationToken, folder, FormatOptions.Default, format, args);
	}

	public void QueueCommand(ImapCommand ic)
	{
		lock (queue)
		{
			ic.Status = ImapCommandStatus.Queued;
			queue.Add(ic);
		}
	}

	public async Task<ImapCommandResponse> QueryCapabilitiesAsync(bool doAsync, CancellationToken cancellationToken)
	{
		ImapCommand ic = QueueCommand(cancellationToken, null, "CAPABILITY\r\n");
		await RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
		return ic.Response;
	}

	public void CacheFolder(ImapFolder folder)
	{
		if ((folder.Attributes & FolderAttributes.Inbox) != FolderAttributes.None)
		{
			cacheComparer.DirectorySeparator = folder.DirectorySeparator;
		}
		FolderCache.Add(folder.EncodedName, folder);
	}

	public bool GetCachedFolder(string encodedName, out ImapFolder folder)
	{
		return FolderCache.TryGetValue(encodedName, out folder);
	}

	internal async Task LookupParentFoldersAsync(IEnumerable<ImapFolder> folders, bool doAsync, CancellationToken cancellationToken)
	{
		List<ImapFolder> list = new List<ImapFolder>(folders);
		for (int i = 0; i < list.Count; i++)
		{
			ImapFolder folder = list[i];
			if (folder.ParentFolder != null)
			{
				continue;
			}
			int num;
			string encodedName;
			if ((num = folder.FullName.LastIndexOf(folder.DirectorySeparator)) != -1)
			{
				if (num == 0)
				{
					continue;
				}
				string mailboxName = folder.FullName.Substring(0, num);
				encodedName = EncodeMailboxName(mailboxName);
			}
			else
			{
				encodedName = string.Empty;
			}
			if (GetCachedFolder(encodedName, out var folder2))
			{
				folder.ParentFolder = folder2;
				continue;
			}
			string text = encodedName.Replace('*', '%');
			StringBuilder stringBuilder = new StringBuilder("LIST \"\" %S");
			bool listReturnsSubscribed = false;
			if ((Capabilities & ImapCapabilities.ListExtended) != ImapCapabilities.None)
			{
				stringBuilder.Append(" RETURN (SUBSCRIBED CHILDREN)");
				listReturnsSubscribed = true;
			}
			stringBuilder.Append("\r\n");
			ImapCommand imapCommand = new ImapCommand(this, cancellationToken, null, stringBuilder.ToString(), text);
			imapCommand.RegisterUntaggedHandler("LIST", ImapUtils.ParseFolderListAsync);
			imapCommand.ListReturnsSubscribed = listReturnsSubscribed;
			imapCommand.UserData = new List<ImapFolder>();
			QueueCommand(imapCommand);
			await RunAsync(imapCommand, doAsync).ConfigureAwait(continueOnCapturedContext: false);
			if (!GetCachedFolder(encodedName, out folder2))
			{
				folder2 = CreateImapFolder(encodedName, FolderAttributes.NonExistent, folder.DirectorySeparator);
				CacheFolder(folder2);
			}
			else if (folder2.ParentFolder == null && !folder2.IsNamespace)
			{
				list.Add(folder2);
			}
			folder.ParentFolder = folder2;
		}
	}

	public async Task<ImapCommandResponse> QueryNamespacesAsync(bool doAsync, CancellationToken cancellationToken)
	{
		ImapCommand ic;
		if ((Capabilities & ImapCapabilities.Namespace) != ImapCapabilities.None)
		{
			ic = QueueCommand(cancellationToken, null, "NAMESPACE\r\n");
			await RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
			if (QuirksMode == ImapQuirksMode.Exchange && ic.Response == ImapCommandResponse.Bad)
			{
				State = ImapEngineState.Connected;
				throw ImapCommandException.Create("NAMESPACE", ic);
			}
		}
		else
		{
			List<ImapFolder> list = new List<ImapFolder>();
			ic = new ImapCommand(this, cancellationToken, null, "LIST \"\" \"\"\r\n");
			ic.RegisterUntaggedHandler("LIST", ImapUtils.ParseFolderListAsync);
			ic.UserData = list;
			QueueCommand(ic);
			await RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
			PersonalNamespaces.Clear();
			SharedNamespaces.Clear();
			OtherNamespaces.Clear();
			if (list.Count > 0)
			{
				ImapFolder imapFolder = list.FirstOrDefault((ImapFolder x) => x.EncodedName.Length == 0);
				if (imapFolder == null)
				{
					imapFolder = CreateImapFolder(string.Empty, FolderAttributes.None, list[0].DirectorySeparator);
					CacheFolder(imapFolder);
				}
				PersonalNamespaces.Add(new FolderNamespace(imapFolder.DirectorySeparator, imapFolder.FullName));
				imapFolder.UpdateIsNamespace(value: true);
			}
			await LookupParentFoldersAsync(list, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		return ic.Response;
	}

	internal static ImapFolder GetFolder(List<ImapFolder> folders, string encodedName)
	{
		for (int i = 0; i < folders.Count; i++)
		{
			if (encodedName.Equals(folders[i].EncodedName, StringComparison.OrdinalIgnoreCase))
			{
				return folders[i];
			}
		}
		return null;
	}

	public void AssignSpecialFolder(ImapFolder folder)
	{
		if ((folder.Attributes & FolderAttributes.All) != FolderAttributes.None)
		{
			All = folder;
		}
		if ((folder.Attributes & FolderAttributes.Archive) != FolderAttributes.None)
		{
			Archive = folder;
		}
		if ((folder.Attributes & FolderAttributes.Drafts) != FolderAttributes.None)
		{
			Drafts = folder;
		}
		if ((folder.Attributes & FolderAttributes.Flagged) != FolderAttributes.None)
		{
			Flagged = folder;
		}
		if ((folder.Attributes & FolderAttributes.Important) != FolderAttributes.None)
		{
			Important = folder;
		}
		if ((folder.Attributes & FolderAttributes.Junk) != FolderAttributes.None)
		{
			Junk = folder;
		}
		if ((folder.Attributes & FolderAttributes.Sent) != FolderAttributes.None)
		{
			Sent = folder;
		}
		if ((folder.Attributes & FolderAttributes.Trash) != FolderAttributes.None)
		{
			Trash = folder;
		}
	}

	public void AssignSpecialFolders(IList<ImapFolder> list)
	{
		for (int i = 0; i < list.Count; i++)
		{
			AssignSpecialFolder(list[i]);
		}
	}

	public async Task QuerySpecialFoldersAsync(bool doAsync, CancellationToken cancellationToken)
	{
		StringBuilder command = new StringBuilder("LIST \"\" \"INBOX\"");
		List<ImapFolder> list = new List<ImapFolder>();
		bool listReturnsSubscribed = false;
		if ((Capabilities & ImapCapabilities.ListExtended) != ImapCapabilities.None)
		{
			command.Append(" RETURN (SUBSCRIBED CHILDREN)");
			listReturnsSubscribed = true;
		}
		command.Append("\r\n");
		ImapCommand imapCommand = new ImapCommand(this, cancellationToken, null, command.ToString());
		imapCommand.RegisterUntaggedHandler("LIST", ImapUtils.ParseFolderListAsync);
		imapCommand.ListReturnsSubscribed = listReturnsSubscribed;
		imapCommand.UserData = list;
		QueueCommand(imapCommand);
		await RunAsync(imapCommand, doAsync).ConfigureAwait(continueOnCapturedContext: false);
		GetCachedFolder("INBOX", out var folder);
		Inbox = folder;
		list.Clear();
		if ((Capabilities & ImapCapabilities.SpecialUse) != ImapCapabilities.None)
		{
			listReturnsSubscribed = false;
			command.Clear();
			command.Append("LIST ");
			if (QuirksMode != ImapQuirksMode.ProtonMail)
			{
				command.Append("(SPECIAL-USE) \"\" \"*\"");
			}
			else
			{
				command.Append("\"\" \"%%\"");
			}
			if ((Capabilities & ImapCapabilities.ListExtended) != ImapCapabilities.None)
			{
				command.Append(" RETURN (SUBSCRIBED CHILDREN)");
				listReturnsSubscribed = true;
			}
			command.Append("\r\n");
			imapCommand = new ImapCommand(this, cancellationToken, null, command.ToString());
			imapCommand.RegisterUntaggedHandler("LIST", ImapUtils.ParseFolderListAsync);
			imapCommand.ListReturnsSubscribed = listReturnsSubscribed;
			imapCommand.UserData = list;
			QueueCommand(imapCommand);
			await RunAsync(imapCommand, doAsync).ConfigureAwait(continueOnCapturedContext: false);
			await LookupParentFoldersAsync(list, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			AssignSpecialFolders(list);
		}
		else if ((Capabilities & ImapCapabilities.XList) != ImapCapabilities.None)
		{
			imapCommand = new ImapCommand(this, cancellationToken, null, "XLIST \"\" \"*\"\r\n");
			imapCommand.RegisterUntaggedHandler("XLIST", ImapUtils.ParseFolderListAsync);
			imapCommand.UserData = list;
			QueueCommand(imapCommand);
			await RunAsync(imapCommand, doAsync).ConfigureAwait(continueOnCapturedContext: false);
			await LookupParentFoldersAsync(list, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			AssignSpecialFolders(list);
		}
	}

	public async Task<ImapFolder> GetQuotaRootFolderAsync(string quotaRoot, bool doAsync, CancellationToken cancellationToken)
	{
		if (GetCachedFolder(quotaRoot, out var folder))
		{
			return folder;
		}
		StringBuilder stringBuilder = new StringBuilder("LIST \"\" %S");
		List<ImapFolder> list = new List<ImapFolder>();
		bool listReturnsSubscribed = false;
		if ((Capabilities & ImapCapabilities.ListExtended) != ImapCapabilities.None)
		{
			stringBuilder.Append(" RETURN (SUBSCRIBED CHILDREN)");
			listReturnsSubscribed = true;
		}
		stringBuilder.Append("\r\n");
		ImapCommand ic = new ImapCommand(this, cancellationToken, null, stringBuilder.ToString(), quotaRoot);
		ic.RegisterUntaggedHandler("LIST", ImapUtils.ParseFolderListAsync);
		ic.ListReturnsSubscribed = listReturnsSubscribed;
		ic.UserData = list;
		QueueCommand(ic);
		await RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
		if (ic.Response != ImapCommandResponse.Ok)
		{
			throw ImapCommandException.Create("LIST", ic);
		}
		ImapFolder folder2;
		folder = (folder2 = GetFolder(list, quotaRoot));
		if (folder2 == null)
		{
			folder = CreateImapFolder(quotaRoot, FolderAttributes.NonExistent, '.');
			CacheFolder(folder);
			return folder;
		}
		await LookupParentFoldersAsync(list, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		return folder;
	}

	public async Task<ImapFolder> GetFolderAsync(string path, bool doAsync, CancellationToken cancellationToken)
	{
		string encodedName = EncodeMailboxName(path);
		if (GetCachedFolder(encodedName, out var folder))
		{
			return folder;
		}
		StringBuilder stringBuilder = new StringBuilder("LIST \"\" %S");
		List<ImapFolder> list = new List<ImapFolder>();
		bool listReturnsSubscribed = false;
		if ((Capabilities & ImapCapabilities.ListExtended) != ImapCapabilities.None)
		{
			stringBuilder.Append(" RETURN (SUBSCRIBED CHILDREN)");
			listReturnsSubscribed = true;
		}
		stringBuilder.Append("\r\n");
		ImapCommand ic = new ImapCommand(this, cancellationToken, null, stringBuilder.ToString(), encodedName);
		ic.RegisterUntaggedHandler("LIST", ImapUtils.ParseFolderListAsync);
		ic.ListReturnsSubscribed = listReturnsSubscribed;
		ic.UserData = list;
		QueueCommand(ic);
		await RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
		if (ic.Response != ImapCommandResponse.Ok)
		{
			throw ImapCommandException.Create("LIST", ic);
		}
		ImapFolder folder2;
		folder = (folder2 = GetFolder(list, encodedName));
		if (folder2 == null)
		{
			throw new FolderNotFoundException(path);
		}
		await LookupParentFoldersAsync(list, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		return folder;
	}

	internal string GetStatusQuery(StatusItems items)
	{
		string text = string.Empty;
		if ((items & StatusItems.Count) != StatusItems.None)
		{
			text += "MESSAGES ";
		}
		if ((items & StatusItems.Recent) != StatusItems.None)
		{
			text += "RECENT ";
		}
		if ((items & StatusItems.UidNext) != StatusItems.None)
		{
			text += "UIDNEXT ";
		}
		if ((items & StatusItems.UidValidity) != StatusItems.None)
		{
			text += "UIDVALIDITY ";
		}
		if ((items & StatusItems.Unread) != StatusItems.None)
		{
			text += "UNSEEN ";
		}
		if ((Capabilities & ImapCapabilities.CondStore) != ImapCapabilities.None && (items & StatusItems.HighestModSeq) != StatusItems.None)
		{
			text += "HIGHESTMODSEQ ";
		}
		if ((Capabilities & ImapCapabilities.AppendLimit) != ImapCapabilities.None && !AppendLimit.HasValue && (items & StatusItems.AppendLimit) != StatusItems.None)
		{
			text += "APPENDLIMIT ";
		}
		if ((Capabilities & ImapCapabilities.StatusSize) != ImapCapabilities.None && (items & StatusItems.Size) != StatusItems.None)
		{
			text += "SIZE ";
		}
		if ((Capabilities & ImapCapabilities.ObjectID) != ImapCapabilities.None && (items & StatusItems.MailboxId) != StatusItems.None)
		{
			text += "MAILBOXID ";
		}
		return text.TrimEnd();
	}

	public async Task<IList<ImapFolder>> GetFoldersAsync(FolderNamespace @namespace, StatusItems items, bool subscribedOnly, bool doAsync, CancellationToken cancellationToken)
	{
		string text = EncodeMailboxName(@namespace.Path);
		string text2 = ((text.Length > 0) ? (text + @namespace.DirectorySeparator) : string.Empty);
		bool status = items != StatusItems.None;
		List<ImapFolder> list = new List<ImapFolder>();
		StringBuilder stringBuilder = new StringBuilder();
		bool listReturnsSubscribed = false;
		bool lsub = subscribedOnly;
		if (!GetCachedFolder(text, out var _))
		{
			throw new FolderNotFoundException(@namespace.Path);
		}
		if (subscribedOnly)
		{
			if ((Capabilities & ImapCapabilities.ListExtended) != ImapCapabilities.None)
			{
				stringBuilder.Append("LIST (SUBSCRIBED)");
				listReturnsSubscribed = true;
				lsub = false;
			}
			else
			{
				stringBuilder.Append("LSUB");
			}
		}
		else
		{
			stringBuilder.Append("LIST");
		}
		stringBuilder.Append(" \"\" %S");
		if (!lsub)
		{
			if (items != StatusItems.None && (Capabilities & ImapCapabilities.ListStatus) != ImapCapabilities.None)
			{
				stringBuilder.Append(" RETURN (");
				if ((Capabilities & ImapCapabilities.ListExtended) != ImapCapabilities.None)
				{
					if (!subscribedOnly)
					{
						stringBuilder.Append("SUBSCRIBED ");
						listReturnsSubscribed = true;
					}
					stringBuilder.Append("CHILDREN ");
				}
				stringBuilder.AppendFormat("STATUS ({0})", GetStatusQuery(items));
				stringBuilder.Append(')');
				status = false;
			}
			else if ((Capabilities & ImapCapabilities.ListExtended) != ImapCapabilities.None)
			{
				stringBuilder.Append(" RETURN (");
				if (!subscribedOnly)
				{
					stringBuilder.Append("SUBSCRIBED ");
					listReturnsSubscribed = true;
				}
				stringBuilder.Append("CHILDREN");
				stringBuilder.Append(')');
			}
		}
		stringBuilder.Append("\r\n");
		ImapCommand ic = new ImapCommand(this, cancellationToken, null, stringBuilder.ToString(), text2 + "*");
		ic.RegisterUntaggedHandler(lsub ? "LSUB" : "LIST", ImapUtils.ParseFolderListAsync);
		ic.ListReturnsSubscribed = listReturnsSubscribed;
		ic.UserData = list;
		ic.Lsub = lsub;
		QueueCommand(ic);
		await RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
		if (ic.Response != ImapCommandResponse.Ok)
		{
			throw ImapCommandException.Create(lsub ? "LSUB" : "LIST", ic);
		}
		await LookupParentFoldersAsync(list, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		if (status)
		{
			for (int i = 0; i < list.Count; i++)
			{
				if (list[i].Exists)
				{
					await list[i].StatusAsync(items, doAsync, throwNotFound: false, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				}
			}
		}
		return list;
	}

	public string DecodeMailboxName(string encodedName)
	{
		if (!UTF8Enabled)
		{
			return ImapEncoding.Decode(encodedName);
		}
		return encodedName;
	}

	public string EncodeMailboxName(string mailboxName)
	{
		if (!UTF8Enabled)
		{
			return ImapEncoding.Encode(mailboxName);
		}
		return mailboxName;
	}

	public bool IsValidMailboxName(string mailboxName, char delim)
	{
		foreach (char c in mailboxName)
		{
			if (c <= '\u001f' || (c >= '\u0080' && c <= '\u009f') || c == '\u007f' || c == '\u2028' || c == '\u2029' || c == delim)
			{
				return false;
			}
		}
		return mailboxName.Length > 0;
	}

	private void InitializeParser(Stream stream, bool persistent)
	{
		if (parser == null)
		{
			parser = new MimeParser(ParserOptions.Default, stream, persistent);
		}
		else
		{
			parser.SetStream(ParserOptions.Default, stream, persistent);
		}
	}

	public async Task<HeaderList> ParseHeadersAsync(Stream stream, bool doAsync, CancellationToken cancellationToken)
	{
		InitializeParser(stream, persistent: false);
		if (doAsync)
		{
			return await parser.ParseHeadersAsync(cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		return parser.ParseHeaders(cancellationToken);
	}

	public async Task<MimeMessage> ParseMessageAsync(Stream stream, bool persistent, bool doAsync, CancellationToken cancellationToken)
	{
		InitializeParser(stream, persistent);
		if (doAsync)
		{
			return await parser.ParseMessageAsync(cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		return parser.ParseMessage(cancellationToken);
	}

	public async Task<MimeEntity> ParseEntityAsync(Stream stream, bool persistent, bool doAsync, CancellationToken cancellationToken)
	{
		InitializeParser(stream, persistent);
		if (doAsync)
		{
			return await parser.ParseEntityAsync(cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		return parser.ParseEntity(cancellationToken);
	}

	internal void OnAlert(string message)
	{
		this.Alert?.Invoke(this, new AlertEventArgs(message));
	}

	internal void OnWebAlert(Uri uri, string message)
	{
		this.WebAlert?.Invoke(this, new WebAlertEventArgs(uri, message));
	}

	internal void OnFolderCreated(IMailFolder folder)
	{
		this.FolderCreated?.Invoke(this, new FolderCreatedEventArgs(folder));
	}

	internal void OnMetadataChanged(Metadata metadata)
	{
		this.MetadataChanged?.Invoke(this, new MetadataChangedEventArgs(metadata));
	}

	internal void OnNotificationOverflow()
	{
		NotifySelectedNewExpunge = false;
		this.NotificationOverflow?.Invoke(this, EventArgs.Empty);
	}

	private void OnDisconnected()
	{
		this.Disconnected?.Invoke(this, EventArgs.Empty);
	}

	public void Dispose()
	{
		disposed = true;
		Disconnect();
	}
}
