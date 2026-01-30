using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MailKit.Security;

namespace MailKit.Net.Imap;

public class ImapClient : MailStore, IImapClient, IMailStore, IMailService, IDisposable
{
	private static readonly char[] ReservedUriCharacters = new char[11]
	{
		';', '/', '?', ':', '@', '&', '=', '+', '$', ',',
		'%'
	};

	private const string HexAlphabet = "0123456789ABCDEF";

	private readonly ImapAuthenticationSecretDetector detector = new ImapAuthenticationSecretDetector();

	private readonly ImapEngine engine;

	private int timeout = 120000;

	private string identifier;

	private bool disconnecting;

	private bool connecting;

	private bool disposed;

	private bool secure;

	public override object SyncRoot => engine;

	protected override string Protocol => "imap";

	public ImapCapabilities Capabilities
	{
		get
		{
			return engine.Capabilities;
		}
		set
		{
			if ((engine.Capabilities | value) > engine.Capabilities)
			{
				throw new ArgumentException("Capabilities cannot be enabled, they may only be disabled.", "value");
			}
			engine.Capabilities = value;
		}
	}

	public uint? AppendLimit => engine.AppendLimit;

	public int InternationalizationLevel => engine.I18NLevel;

	public AccessRights Rights => engine.Rights;

	public override HashSet<string> AuthenticationMechanisms => engine.AuthenticationMechanisms;

	public override HashSet<ThreadingAlgorithm> ThreadingAlgorithms => engine.ThreadingAlgorithms;

	public override int Timeout
	{
		get
		{
			return timeout;
		}
		set
		{
			if (IsConnected && engine.Stream.CanTimeout)
			{
				engine.Stream.WriteTimeout = value;
				engine.Stream.ReadTimeout = value;
			}
			timeout = value;
		}
	}

	public override bool IsConnected => engine.IsConnected;

	public override bool IsSecure
	{
		get
		{
			if (IsConnected)
			{
				return secure;
			}
			return false;
		}
	}

	public override bool IsEncrypted
	{
		get
		{
			if (IsSecure && engine.Stream.Stream is SslStream sslStream)
			{
				return sslStream.IsEncrypted;
			}
			return false;
		}
	}

	public override bool IsSigned
	{
		get
		{
			if (IsSecure && engine.Stream.Stream is SslStream sslStream)
			{
				return sslStream.IsSigned;
			}
			return false;
		}
	}

	public override SslProtocols SslProtocol
	{
		get
		{
			if (IsSecure && engine.Stream.Stream is SslStream sslStream)
			{
				return sslStream.SslProtocol;
			}
			return SslProtocols.None;
		}
	}

	public override CipherAlgorithmType? SslCipherAlgorithm
	{
		get
		{
			if (IsSecure && engine.Stream.Stream is SslStream sslStream)
			{
				return sslStream.CipherAlgorithm;
			}
			return null;
		}
	}

	public override int? SslCipherStrength
	{
		get
		{
			if (IsSecure && engine.Stream.Stream is SslStream sslStream)
			{
				return sslStream.CipherStrength;
			}
			return null;
		}
	}

	public override HashAlgorithmType? SslHashAlgorithm
	{
		get
		{
			if (IsSecure && engine.Stream.Stream is SslStream sslStream)
			{
				return sslStream.HashAlgorithm;
			}
			return null;
		}
	}

	public override int? SslHashStrength
	{
		get
		{
			if (IsSecure && engine.Stream.Stream is SslStream sslStream)
			{
				return sslStream.HashStrength;
			}
			return null;
		}
	}

	public override ExchangeAlgorithmType? SslKeyExchangeAlgorithm
	{
		get
		{
			if (IsSecure && engine.Stream.Stream is SslStream sslStream)
			{
				return sslStream.KeyExchangeAlgorithm;
			}
			return null;
		}
	}

	public override int? SslKeyExchangeStrength
	{
		get
		{
			if (IsSecure && engine.Stream.Stream is SslStream sslStream)
			{
				return sslStream.KeyExchangeStrength;
			}
			return null;
		}
	}

	public override bool IsAuthenticated => engine.State >= ImapEngineState.Authenticated;

	public bool IsIdle => engine.State == ImapEngineState.Idle;

	public override FolderNamespaceCollection PersonalNamespaces => engine.PersonalNamespaces;

	public override FolderNamespaceCollection SharedNamespaces => engine.SharedNamespaces;

	public override FolderNamespaceCollection OtherNamespaces => engine.OtherNamespaces;

	public override bool SupportsQuotas => (engine.Capabilities & ImapCapabilities.Quota) != 0;

	public override IMailFolder Inbox
	{
		get
		{
			CheckDisposed();
			CheckConnected();
			CheckAuthenticated();
			return engine.Inbox;
		}
	}

	public event EventHandler<WebAlertEventArgs> WebAlert;

	public Task CompressAsync(CancellationToken cancellationToken = default(CancellationToken))
	{
		return CompressAsync(doAsync: true, cancellationToken);
	}

	public override Task EnableQuickResyncAsync(CancellationToken cancellationToken = default(CancellationToken))
	{
		return EnableQuickResyncAsync(doAsync: true, cancellationToken);
	}

	public Task EnableUTF8Async(CancellationToken cancellationToken = default(CancellationToken))
	{
		return EnableUTF8Async(doAsync: true, cancellationToken);
	}

	public Task<ImapImplementation> IdentifyAsync(ImapImplementation clientImplementation, CancellationToken cancellationToken = default(CancellationToken))
	{
		return IdentifyAsync(clientImplementation, doAsync: true, cancellationToken);
	}

	public override Task AuthenticateAsync(SaslMechanism mechanism, CancellationToken cancellationToken = default(CancellationToken))
	{
		return AuthenticateAsync(mechanism, doAsync: true, cancellationToken);
	}

	public override Task AuthenticateAsync(Encoding encoding, ICredentials credentials, CancellationToken cancellationToken = default(CancellationToken))
	{
		return AuthenticateAsync(encoding, credentials, doAsync: true, cancellationToken);
	}

	public override Task ConnectAsync(string host, int port = 0, SecureSocketOptions options = SecureSocketOptions.Auto, CancellationToken cancellationToken = default(CancellationToken))
	{
		return ConnectAsync(host, port, options, doAsync: true, cancellationToken);
	}

	public override Task ConnectAsync(Socket socket, string host, int port = 0, SecureSocketOptions options = SecureSocketOptions.Auto, CancellationToken cancellationToken = default(CancellationToken))
	{
		return ConnectAsync(socket, host, port, options, doAsync: true, cancellationToken);
	}

	public override Task ConnectAsync(Stream stream, string host, int port = 0, SecureSocketOptions options = SecureSocketOptions.Auto, CancellationToken cancellationToken = default(CancellationToken))
	{
		return ConnectAsync(stream, host, port, options, doAsync: true, cancellationToken);
	}

	public override Task DisconnectAsync(bool quit, CancellationToken cancellationToken = default(CancellationToken))
	{
		return DisconnectAsync(quit, doAsync: true, cancellationToken);
	}

	public override Task NoOpAsync(CancellationToken cancellationToken = default(CancellationToken))
	{
		return NoOpAsync(doAsync: true, cancellationToken);
	}

	public Task IdleAsync(CancellationToken doneToken, CancellationToken cancellationToken = default(CancellationToken))
	{
		return IdleAsync(doneToken, doAsync: true, cancellationToken);
	}

	public Task NotifyAsync(bool status, IList<ImapEventGroup> eventGroups, CancellationToken cancellationToken = default(CancellationToken))
	{
		return NotifyAsync(status, eventGroups, doAsync: true, cancellationToken);
	}

	public Task DisableNotifyAsync(CancellationToken cancellationToken = default(CancellationToken))
	{
		return DisableNotifyAsync(doAsync: true, cancellationToken);
	}

	public override Task<IList<IMailFolder>> GetFoldersAsync(FolderNamespace @namespace, StatusItems items = StatusItems.None, bool subscribedOnly = false, CancellationToken cancellationToken = default(CancellationToken))
	{
		return GetFoldersAsync(@namespace, items, subscribedOnly, doAsync: true, cancellationToken);
	}

	public override async Task<IMailFolder> GetFolderAsync(string path, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		CheckDisposed();
		CheckConnected();
		CheckAuthenticated();
		return await engine.GetFolderAsync(path, doAsync: true, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
	}

	public override Task<string> GetMetadataAsync(MetadataTag tag, CancellationToken cancellationToken = default(CancellationToken))
	{
		return GetMetadataAsync(tag, doAsync: true, cancellationToken);
	}

	public override Task<MetadataCollection> GetMetadataAsync(MetadataOptions options, IEnumerable<MetadataTag> tags, CancellationToken cancellationToken = default(CancellationToken))
	{
		return GetMetadataAsync(options, tags, doAsync: true, cancellationToken);
	}

	public override Task SetMetadataAsync(MetadataCollection metadata, CancellationToken cancellationToken = default(CancellationToken))
	{
		return SetMetadataAsync(metadata, doAsync: true, cancellationToken);
	}

	public ImapClient()
		: this(new NullProtocolLogger())
	{
	}

	public ImapClient(IProtocolLogger protocolLogger)
		: base(protocolLogger)
	{
		protocolLogger.AuthenticationSecretDetector = detector;
		engine = new ImapEngine(CreateImapFolder);
		engine.MetadataChanged += OnEngineMetadataChanged;
		engine.FolderCreated += OnEngineFolderCreated;
		engine.Disconnected += OnEngineDisconnected;
		engine.WebAlert += OnEngineWebAlert;
		engine.Alert += OnEngineAlert;
	}

	private void CheckDisposed()
	{
		if (disposed)
		{
			throw new ObjectDisposedException("ImapClient");
		}
	}

	private void CheckConnected()
	{
		if (!IsConnected)
		{
			throw new ServiceNotConnectedException("The ImapClient is not connected.");
		}
	}

	private void CheckAuthenticated()
	{
		if (!IsAuthenticated)
		{
			throw new ServiceNotAuthenticatedException("The ImapClient is not authenticated.");
		}
	}

	protected virtual ImapFolder CreateImapFolder(ImapFolderConstructorArgs args)
	{
		ImapFolder imapFolder = new ImapFolder(args);
		imapFolder.UpdateAppendLimit(AppendLimit);
		return imapFolder;
	}

	private bool ValidateRemoteCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
	{
		if (base.ServerCertificateValidationCallback != null)
		{
			return base.ServerCertificateValidationCallback(engine.Uri.Host, certificate, chain, sslPolicyErrors);
		}
		if (ServicePointManager.ServerCertificateValidationCallback != null)
		{
			return ServicePointManager.ServerCertificateValidationCallback(engine.Uri.Host, certificate, chain, sslPolicyErrors);
		}
		return DefaultServerCertificateValidationCallback(engine.Uri.Host, certificate, chain, sslPolicyErrors);
	}

	private async Task CompressAsync(bool doAsync, CancellationToken cancellationToken)
	{
		CheckDisposed();
		CheckConnected();
		if ((engine.Capabilities & ImapCapabilities.Compress) == ImapCapabilities.None)
		{
			throw new NotSupportedException("The IMAP server does not support the COMPRESS extension.");
		}
		if (engine.State >= ImapEngineState.Selected)
		{
			throw new InvalidOperationException("Compression must be enabled before selecting a folder.");
		}
		_ = engine.CapabilitiesVersion;
		ImapCommand ic = engine.QueueCommand(cancellationToken, null, "COMPRESS DEFLATE\r\n");
		await engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
		if (ic.Response != ImapCommandResponse.Ok)
		{
			for (int i = 0; i < ic.RespCodes.Count; i++)
			{
				if (ic.RespCodes[i].Type == ImapResponseCodeType.CompressionActive)
				{
					return;
				}
			}
			throw ImapCommandException.Create("COMPRESS", ic);
		}
		engine.Stream.Stream = new CompressedStream(engine.Stream.Stream);
	}

	public void Compress(CancellationToken cancellationToken = default(CancellationToken))
	{
		CompressAsync(doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	private async Task EnableQuickResyncAsync(bool doAsync, CancellationToken cancellationToken)
	{
		CheckDisposed();
		CheckConnected();
		CheckAuthenticated();
		if (engine.State != ImapEngineState.Authenticated)
		{
			throw new InvalidOperationException("QRESYNC needs to be enabled immediately after authenticating.");
		}
		if ((engine.Capabilities & ImapCapabilities.QuickResync) == ImapCapabilities.None)
		{
			throw new NotSupportedException("The IMAP server does not support the QRESYNC extension.");
		}
		if (!engine.QResyncEnabled)
		{
			ImapCommand ic = engine.QueueCommand(cancellationToken, null, "ENABLE QRESYNC CONDSTORE\r\n");
			await engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
			if (ic.Response != ImapCommandResponse.Ok)
			{
				throw ImapCommandException.Create("ENABLE", ic);
			}
		}
	}

	public override void EnableQuickResync(CancellationToken cancellationToken = default(CancellationToken))
	{
		EnableQuickResyncAsync(doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	private async Task EnableUTF8Async(bool doAsync, CancellationToken cancellationToken)
	{
		CheckDisposed();
		CheckConnected();
		CheckAuthenticated();
		if (engine.State != ImapEngineState.Authenticated)
		{
			throw new InvalidOperationException("UTF8=ACCEPT needs to be enabled immediately after authenticating.");
		}
		if ((engine.Capabilities & ImapCapabilities.UTF8Accept) == ImapCapabilities.None)
		{
			throw new NotSupportedException("The IMAP server does not support the UTF8=ACCEPT extension.");
		}
		if (!engine.UTF8Enabled)
		{
			ImapCommand ic = engine.QueueCommand(cancellationToken, null, "ENABLE UTF8=ACCEPT\r\n");
			await engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
			if (ic.Response != ImapCommandResponse.Ok)
			{
				throw ImapCommandException.Create("ENABLE", ic);
			}
		}
	}

	public void EnableUTF8(CancellationToken cancellationToken = default(CancellationToken))
	{
		EnableUTF8Async(doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	private async Task<ImapImplementation> IdentifyAsync(ImapImplementation clientImplementation, bool doAsync, CancellationToken cancellationToken)
	{
		CheckDisposed();
		CheckConnected();
		if ((engine.Capabilities & ImapCapabilities.Id) == ImapCapabilities.None)
		{
			throw new NotSupportedException("The IMAP server does not support the ID extension.");
		}
		StringBuilder stringBuilder = new StringBuilder("ID ");
		List<object> list = new List<object>();
		if (clientImplementation != null && clientImplementation.Properties.Count > 0)
		{
			stringBuilder.Append('(');
			foreach (KeyValuePair<string, string> property in clientImplementation.Properties)
			{
				stringBuilder.Append("%Q ");
				list.Add(property.Key);
				if (property.Value != null)
				{
					stringBuilder.Append("%Q ");
					list.Add(property.Value);
				}
				else
				{
					stringBuilder.Append("NIL ");
				}
			}
			stringBuilder[stringBuilder.Length - 1] = ')';
			stringBuilder.Append("\r\n");
		}
		else
		{
			stringBuilder.Append("NIL\r\n");
		}
		ImapCommand ic = new ImapCommand(engine, cancellationToken, null, stringBuilder.ToString(), list.ToArray());
		ic.RegisterUntaggedHandler("ID", ImapUtils.ParseImplementationAsync);
		engine.QueueCommand(ic);
		await engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
		if (ic.Response != ImapCommandResponse.Ok)
		{
			throw ImapCommandException.Create("ID", ic);
		}
		return (ImapImplementation)ic.UserData;
	}

	public ImapImplementation Identify(ImapImplementation clientImplementation, CancellationToken cancellationToken = default(CancellationToken))
	{
		return IdentifyAsync(clientImplementation, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	private static MailKit.Security.AuthenticationException CreateAuthenticationException(ImapCommand ic)
	{
		for (int i = 0; i < ic.RespCodes.Count; i++)
		{
			if (ic.RespCodes[i].IsError || ic.RespCodes[i].Type == ImapResponseCodeType.Alert)
			{
				return new MailKit.Security.AuthenticationException(ic.RespCodes[i].Message);
			}
		}
		if (ic.ResponseText != null)
		{
			return new MailKit.Security.AuthenticationException(ic.ResponseText);
		}
		return new MailKit.Security.AuthenticationException();
	}

	private void EmitAndThrowOnAlert(ImapCommand ic)
	{
		for (int i = 0; i < ic.RespCodes.Count; i++)
		{
			if (ic.RespCodes[i].Type == ImapResponseCodeType.Alert)
			{
				OnAlert(ic.RespCodes[i].Message);
				throw new MailKit.Security.AuthenticationException(ic.ResponseText ?? ic.RespCodes[i].Message);
			}
		}
	}

	private static bool IsHexDigit(char c)
	{
		if ((c < '0' || c > '9') && (c < 'A' || c > 'F'))
		{
			if (c >= 'a')
			{
				return c <= 'f';
			}
			return false;
		}
		return true;
	}

	private static uint HexUnescape(uint c)
	{
		switch (c)
		{
		default:
			return c - 97 + 10;
		case 65u:
		case 66u:
		case 67u:
		case 68u:
		case 69u:
		case 70u:
		case 71u:
		case 72u:
		case 73u:
		case 74u:
		case 75u:
		case 76u:
		case 77u:
		case 78u:
		case 79u:
		case 80u:
		case 81u:
		case 82u:
		case 83u:
		case 84u:
		case 85u:
		case 86u:
		case 87u:
		case 88u:
		case 89u:
		case 90u:
		case 91u:
		case 92u:
		case 93u:
		case 94u:
		case 95u:
		case 96u:
			return c - 65 + 10;
		case 0u:
		case 1u:
		case 2u:
		case 3u:
		case 4u:
		case 5u:
		case 6u:
		case 7u:
		case 8u:
		case 9u:
		case 10u:
		case 11u:
		case 12u:
		case 13u:
		case 14u:
		case 15u:
		case 16u:
		case 17u:
		case 18u:
		case 19u:
		case 20u:
		case 21u:
		case 22u:
		case 23u:
		case 24u:
		case 25u:
		case 26u:
		case 27u:
		case 28u:
		case 29u:
		case 30u:
		case 31u:
		case 32u:
		case 33u:
		case 34u:
		case 35u:
		case 36u:
		case 37u:
		case 38u:
		case 39u:
		case 40u:
		case 41u:
		case 42u:
		case 43u:
		case 44u:
		case 45u:
		case 46u:
		case 47u:
		case 48u:
		case 49u:
		case 50u:
		case 51u:
		case 52u:
		case 53u:
		case 54u:
		case 55u:
		case 56u:
		case 57u:
		case 58u:
		case 59u:
		case 60u:
		case 61u:
		case 62u:
		case 63u:
		case 64u:
			return c - 48;
		}
	}

	private static char HexUnescape(string pattern, ref int index)
	{
		if (pattern[index++] != '%' || !IsHexDigit(pattern[index]) || !IsHexDigit(pattern[index + 1]))
		{
			return '%';
		}
		uint c = pattern[index++];
		uint num = HexUnescape(c) << 4;
		c = pattern[index++];
		num |= HexUnescape(c);
		return (char)num;
	}

	internal static string UnescapeUserName(string escaped)
	{
		int index;
		if ((index = escaped.IndexOf('%')) == -1)
		{
			return escaped;
		}
		StringBuilder stringBuilder = new StringBuilder();
		int num = 0;
		do
		{
			stringBuilder.Append(escaped, num, index - num);
			stringBuilder.Append(HexUnescape(escaped, ref index));
			num = index;
			if (num >= escaped.Length)
			{
				break;
			}
			index = escaped.IndexOf('%', num);
		}
		while (index != -1);
		if (index == -1)
		{
			stringBuilder.Append(escaped, num, escaped.Length - num);
		}
		return stringBuilder.ToString();
	}

	private static string HexEscape(char c)
	{
		return "%" + "0123456789ABCDEF"[((int)c >> 4) & 0xF] + "0123456789ABCDEF"[c & 0xF];
	}

	internal static string EscapeUserName(string userName)
	{
		int num;
		if ((num = userName.IndexOfAny(ReservedUriCharacters)) == -1)
		{
			return userName;
		}
		StringBuilder stringBuilder = new StringBuilder();
		int num2 = 0;
		do
		{
			stringBuilder.Append(userName, num2, num - num2);
			stringBuilder.Append(HexEscape(userName[num++]));
			num2 = num;
			if (num2 >= userName.Length)
			{
				break;
			}
			num = userName.IndexOfAny(ReservedUriCharacters, num2);
		}
		while (num != -1);
		if (num == -1)
		{
			stringBuilder.Append(userName, num2, userName.Length - num2);
		}
		return stringBuilder.ToString();
	}

	private string GetSessionIdentifier(string userName)
	{
		Uri uri = engine.Uri;
		return string.Format(CultureInfo.InvariantCulture, "{0}://{1}@{2}:{3}", uri.Scheme, EscapeUserName(userName), uri.Host, uri.Port);
	}

	private async Task OnAuthenticatedAsync(string message, bool doAsync, CancellationToken cancellationToken)
	{
		await engine.QueryNamespacesAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		await engine.QuerySpecialFoldersAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		OnAuthenticated(message);
	}

	private async Task AuthenticateAsync(SaslMechanism mechanism, bool doAsync, CancellationToken cancellationToken)
	{
		if (mechanism == null)
		{
			throw new ArgumentNullException("mechanism");
		}
		CheckDisposed();
		CheckConnected();
		if (engine.State >= ImapEngineState.Authenticated)
		{
			throw new InvalidOperationException("The ImapClient is already authenticated.");
		}
		int capabilitiesVersion = engine.CapabilitiesVersion;
		Uri uri = new Uri("imap://" + engine.Uri.Host);
		cancellationToken.ThrowIfCancellationRequested();
		mechanism.Uri = uri;
		string text = $"AUTHENTICATE {mechanism.MechanismName}";
		if ((engine.Capabilities & ImapCapabilities.SaslIR) != ImapCapabilities.None && mechanism.SupportsInitialResponse)
		{
			string text2 = mechanism.Challenge(null);
			text = text + " " + text2 + "\r\n";
		}
		else
		{
			text += "\r\n";
		}
		ImapCommand ic = engine.QueueCommand(cancellationToken, null, text);
		ic.ContinuationHandler = async delegate(ImapEngine imap, ImapCommand cmd, string token, bool xdoAsync)
		{
			string text3 = mechanism.Challenge(token);
			byte[] bytes = Encoding.ASCII.GetBytes(text3 + "\r\n");
			if (xdoAsync)
			{
				await imap.Stream.WriteAsync(bytes, 0, bytes.Length, cmd.CancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				await imap.Stream.FlushAsync(cmd.CancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			}
			else
			{
				imap.Stream.Write(bytes, 0, bytes.Length, cmd.CancellationToken);
				imap.Stream.Flush(cmd.CancellationToken);
			}
		};
		detector.IsAuthenticating = true;
		try
		{
			await engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
		}
		finally
		{
			detector.IsAuthenticating = false;
		}
		if (ic.Response != ImapCommandResponse.Ok)
		{
			EmitAndThrowOnAlert(ic);
			throw new MailKit.Security.AuthenticationException();
		}
		engine.State = ImapEngineState.Authenticated;
		NetworkCredential credential = mechanism.Credentials.GetCredential(mechanism.Uri, mechanism.MechanismName);
		string sessionIdentifier = GetSessionIdentifier(credential.UserName);
		if (sessionIdentifier != identifier)
		{
			engine.FolderCache.Clear();
			identifier = sessionIdentifier;
		}
		if (engine.CapabilitiesVersion == capabilitiesVersion)
		{
			await engine.QueryCapabilitiesAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		await OnAuthenticatedAsync(ic.ResponseText ?? string.Empty, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
	}

	public override void Authenticate(SaslMechanism mechanism, CancellationToken cancellationToken = default(CancellationToken))
	{
		AuthenticateAsync(mechanism, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	private async Task AuthenticateAsync(Encoding encoding, ICredentials credentials, bool doAsync, CancellationToken cancellationToken)
	{
		if (encoding == null)
		{
			throw new ArgumentNullException("encoding");
		}
		if (credentials == null)
		{
			throw new ArgumentNullException("credentials");
		}
		CheckDisposed();
		CheckConnected();
		if (engine.State >= ImapEngineState.Authenticated)
		{
			throw new InvalidOperationException("The ImapClient is already authenticated.");
		}
		int capabilitiesVersion = engine.CapabilitiesVersion;
		Uri uri = new Uri("imap://" + engine.Uri.Host);
		ImapCommand ic = null;
		string[] authMechanismRank = SaslMechanism.AuthMechanismRank;
		SaslMechanism sasl;
		NetworkCredential cred;
		string sessionIdentifier;
		foreach (string text in authMechanismRank)
		{
			if (!engine.AuthenticationMechanisms.Contains(text) || (sasl = SaslMechanism.Create(text, uri, encoding, credentials)) == null)
			{
				continue;
			}
			cancellationToken.ThrowIfCancellationRequested();
			string text2 = $"AUTHENTICATE {sasl.MechanismName}";
			if ((engine.Capabilities & ImapCapabilities.SaslIR) != ImapCapabilities.None && sasl.SupportsInitialResponse)
			{
				string text3 = sasl.Challenge(null);
				text2 = text2 + " " + text3 + "\r\n";
			}
			else
			{
				text2 += "\r\n";
			}
			ic = engine.QueueCommand(cancellationToken, null, text2);
			ic.ContinuationHandler = async delegate(ImapEngine imap, ImapCommand cmd, string token, bool xdoAsync)
			{
				string text4 = sasl.Challenge(token);
				byte[] bytes = Encoding.ASCII.GetBytes(text4 + "\r\n");
				if (xdoAsync)
				{
					await imap.Stream.WriteAsync(bytes, 0, bytes.Length, cmd.CancellationToken).ConfigureAwait(continueOnCapturedContext: false);
					await imap.Stream.FlushAsync(cmd.CancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				}
				else
				{
					imap.Stream.Write(bytes, 0, bytes.Length, cmd.CancellationToken);
					imap.Stream.Flush(cmd.CancellationToken);
				}
			};
			detector.IsAuthenticating = true;
			try
			{
				await engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
			}
			finally
			{
				detector.IsAuthenticating = false;
			}
			if (ic.Response != ImapCommandResponse.Ok)
			{
				EmitAndThrowOnAlert(ic);
				if (ic.Bye)
				{
					throw new ImapProtocolException(ic.ResponseText);
				}
				continue;
			}
			engine.State = ImapEngineState.Authenticated;
			cred = credentials.GetCredential(uri, sasl.MechanismName);
			sessionIdentifier = GetSessionIdentifier(cred.UserName);
			if (sessionIdentifier != identifier)
			{
				engine.FolderCache.Clear();
				identifier = sessionIdentifier;
			}
			if (engine.CapabilitiesVersion == capabilitiesVersion)
			{
				await engine.QueryCapabilitiesAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			}
			await OnAuthenticatedAsync(ic.ResponseText ?? string.Empty, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			return;
		}
		if ((Capabilities & ImapCapabilities.LoginDisabled) != ImapCapabilities.None)
		{
			if (ic == null)
			{
				throw new MailKit.Security.AuthenticationException("The LOGIN command is disabled.");
			}
			throw CreateAuthenticationException(ic);
		}
		cred = credentials.GetCredential(uri, "DEFAULT");
		ic = engine.QueueCommand(cancellationToken, null, "LOGIN %S %S\r\n", cred.UserName, cred.Password);
		detector.IsAuthenticating = true;
		try
		{
			await engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
		}
		finally
		{
			detector.IsAuthenticating = false;
		}
		if (ic.Response != ImapCommandResponse.Ok)
		{
			throw CreateAuthenticationException(ic);
		}
		engine.State = ImapEngineState.Authenticated;
		sessionIdentifier = GetSessionIdentifier(cred.UserName);
		if (sessionIdentifier != identifier)
		{
			engine.FolderCache.Clear();
			identifier = sessionIdentifier;
		}
		if (engine.CapabilitiesVersion == capabilitiesVersion)
		{
			await engine.QueryCapabilitiesAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		await OnAuthenticatedAsync(ic.ResponseText ?? string.Empty, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
	}

	public override void Authenticate(Encoding encoding, ICredentials credentials, CancellationToken cancellationToken = default(CancellationToken))
	{
		AuthenticateAsync(encoding, credentials, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	internal void ReplayConnect(string host, Stream replayStream, CancellationToken cancellationToken = default(CancellationToken))
	{
		CheckDisposed();
		if (host == null)
		{
			throw new ArgumentNullException("host");
		}
		if (replayStream == null)
		{
			throw new ArgumentNullException("replayStream");
		}
		engine.Uri = new Uri("imap://" + host + ":143");
		engine.ConnectAsync(new ImapStream(replayStream, base.ProtocolLogger), doAsync: false, cancellationToken).GetAwaiter().GetResult();
		engine.TagPrefix = 'A';
		secure = false;
		if (engine.CapabilitiesVersion == 0)
		{
			engine.QueryCapabilitiesAsync(doAsync: false, cancellationToken).GetAwaiter().GetResult();
		}
		bool flag = engine.State == ImapEngineState.Authenticated;
		OnConnected(host, 143, SecureSocketOptions.None);
		if (flag)
		{
			OnAuthenticatedAsync(string.Empty, doAsync: false, cancellationToken).GetAwaiter().GetResult();
		}
	}

	internal async Task ReplayConnectAsync(string host, Stream replayStream, CancellationToken cancellationToken = default(CancellationToken))
	{
		CheckDisposed();
		if (host == null)
		{
			throw new ArgumentNullException("host");
		}
		if (replayStream == null)
		{
			throw new ArgumentNullException("replayStream");
		}
		engine.Uri = new Uri("imap://" + host + ":143");
		await engine.ConnectAsync(new ImapStream(replayStream, base.ProtocolLogger), doAsync: true, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		engine.TagPrefix = 'A';
		secure = false;
		if (engine.CapabilitiesVersion == 0)
		{
			await engine.QueryCapabilitiesAsync(doAsync: true, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		bool flag = engine.State == ImapEngineState.Authenticated;
		OnConnected(host, 143, SecureSocketOptions.None);
		if (flag)
		{
			await OnAuthenticatedAsync(string.Empty, doAsync: true, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
	}

	internal static void ComputeDefaultValues(string host, ref int port, ref SecureSocketOptions options, out Uri uri, out bool starttls)
	{
		switch (options)
		{
		default:
			if (port == 0)
			{
				port = 143;
			}
			break;
		case SecureSocketOptions.Auto:
		{
			int num = port;
			if (num != 0)
			{
				if (num == 993)
				{
					options = SecureSocketOptions.SslOnConnect;
					break;
				}
			}
			else
			{
				port = 143;
			}
			options = SecureSocketOptions.StartTlsWhenAvailable;
			break;
		}
		case SecureSocketOptions.SslOnConnect:
			if (port == 0)
			{
				port = 993;
			}
			break;
		}
		if (IPAddress.TryParse(host, out var address) && address.AddressFamily == AddressFamily.InterNetworkV6)
		{
			host = "[" + host + "]";
		}
		switch (options)
		{
		case SecureSocketOptions.StartTlsWhenAvailable:
			uri = new Uri(string.Format(CultureInfo.InvariantCulture, "imap://{0}:{1}/?starttls=when-available", host, port));
			starttls = true;
			break;
		case SecureSocketOptions.StartTls:
			uri = new Uri(string.Format(CultureInfo.InvariantCulture, "imap://{0}:{1}/?starttls=always", host, port));
			starttls = true;
			break;
		case SecureSocketOptions.SslOnConnect:
			uri = new Uri(string.Format(CultureInfo.InvariantCulture, "imaps://{0}:{1}", host, port));
			starttls = false;
			break;
		default:
			uri = new Uri(string.Format(CultureInfo.InvariantCulture, "imap://{0}:{1}", host, port));
			starttls = false;
			break;
		}
	}

	private async Task ConnectAsync(string host, int port, SecureSocketOptions options, bool doAsync, CancellationToken cancellationToken)
	{
		if (host == null)
		{
			throw new ArgumentNullException("host");
		}
		if (host.Length == 0)
		{
			throw new ArgumentException("The host name cannot be empty.", "host");
		}
		if (port < 0 || port > 65535)
		{
			throw new ArgumentOutOfRangeException("port");
		}
		CheckDisposed();
		if (IsConnected)
		{
			throw new InvalidOperationException("The ImapClient is already connected.");
		}
		ComputeDefaultValues(host, ref port, ref options, out var uri, out var starttls);
		Stream stream = new NetworkStream(await ConnectSocket(host, port, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false), ownsSocket: true)
		{
			WriteTimeout = timeout,
			ReadTimeout = timeout
		};
		engine.Uri = uri;
		if (options == SecureSocketOptions.SslOnConnect)
		{
			SslStream ssl = new SslStream(stream, leaveInnerStreamOpen: false, ValidateRemoteCertificate);
			try
			{
				if (doAsync)
				{
					await ssl.AuthenticateAsClientAsync(host, base.ClientCertificates, base.SslProtocols, base.CheckCertificateRevocation).ConfigureAwait(continueOnCapturedContext: false);
				}
				else
				{
					ssl.AuthenticateAsClient(host, base.ClientCertificates, base.SslProtocols, base.CheckCertificateRevocation);
				}
			}
			catch (Exception ex)
			{
				ssl.Dispose();
				throw SslHandshakeException.Create(this, ex, false, "IMAP", host, port, 993, 143);
			}
			secure = true;
			stream = ssl;
		}
		else
		{
			secure = false;
		}
		try
		{
			base.ProtocolLogger.LogConnect(uri);
		}
		catch
		{
			stream.Dispose();
			secure = false;
			throw;
		}
		connecting = true;
		try
		{
			await engine.ConnectAsync(new ImapStream(stream, base.ProtocolLogger), doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		catch
		{
			connecting = false;
			secure = false;
			throw;
		}
		try
		{
			if (engine.CapabilitiesVersion == 0)
			{
				await engine.QueryCapabilitiesAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			}
			if (options == SecureSocketOptions.StartTls && (engine.Capabilities & ImapCapabilities.StartTLS) == ImapCapabilities.None)
			{
				throw new NotSupportedException("The IMAP server does not support the STARTTLS extension.");
			}
			if (starttls && (engine.Capabilities & ImapCapabilities.StartTLS) != ImapCapabilities.None)
			{
				ImapCommand ic = engine.QueueCommand(cancellationToken, null, "STARTTLS\r\n");
				await engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
				if (ic.Response == ImapCommandResponse.Ok)
				{
					try
					{
						SslStream sslStream = new SslStream(stream, leaveInnerStreamOpen: false, ValidateRemoteCertificate);
						engine.Stream.Stream = sslStream;
						if (doAsync)
						{
							await sslStream.AuthenticateAsClientAsync(host, base.ClientCertificates, base.SslProtocols, base.CheckCertificateRevocation).ConfigureAwait(continueOnCapturedContext: false);
						}
						else
						{
							sslStream.AuthenticateAsClient(host, base.ClientCertificates, base.SslProtocols, base.CheckCertificateRevocation);
						}
					}
					catch (Exception ex2)
					{
						throw SslHandshakeException.Create(this, ex2, true, "IMAP", host, port, 993, 143);
					}
					secure = true;
					if (engine.CapabilitiesVersion == 1)
					{
						await engine.QueryCapabilitiesAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
					}
				}
				else if (options == SecureSocketOptions.StartTls)
				{
					throw ImapCommandException.Create("STARTTLS", ic);
				}
			}
		}
		catch
		{
			secure = false;
			engine.Disconnect();
			throw;
		}
		finally
		{
			connecting = false;
		}
		bool flag = engine.State == ImapEngineState.Authenticated;
		OnConnected(host, port, options);
		if (flag)
		{
			await OnAuthenticatedAsync(string.Empty, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
	}

	public override void Connect(string host, int port = 0, SecureSocketOptions options = SecureSocketOptions.Auto, CancellationToken cancellationToken = default(CancellationToken))
	{
		ConnectAsync(host, port, options, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	private async Task ConnectAsync(Stream stream, string host, int port, SecureSocketOptions options, bool doAsync, CancellationToken cancellationToken)
	{
		if (stream == null)
		{
			throw new ArgumentNullException("stream");
		}
		if (host == null)
		{
			throw new ArgumentNullException("host");
		}
		if (host.Length == 0)
		{
			throw new ArgumentException("The host name cannot be empty.", "host");
		}
		if (port < 0 || port > 65535)
		{
			throw new ArgumentOutOfRangeException("port");
		}
		CheckDisposed();
		if (IsConnected)
		{
			throw new InvalidOperationException("The ImapClient is already connected.");
		}
		ComputeDefaultValues(host, ref port, ref options, out var uri, out var starttls);
		engine.Uri = uri;
		Stream network;
		if (options == SecureSocketOptions.SslOnConnect)
		{
			SslStream ssl = new SslStream(stream, leaveInnerStreamOpen: false, ValidateRemoteCertificate);
			try
			{
				if (doAsync)
				{
					await ssl.AuthenticateAsClientAsync(host, base.ClientCertificates, base.SslProtocols, base.CheckCertificateRevocation).ConfigureAwait(continueOnCapturedContext: false);
				}
				else
				{
					ssl.AuthenticateAsClient(host, base.ClientCertificates, base.SslProtocols, base.CheckCertificateRevocation);
				}
			}
			catch (Exception ex)
			{
				ssl.Dispose();
				throw SslHandshakeException.Create(this, ex, false, "IMAP", host, port, 993, 143);
			}
			network = ssl;
			secure = true;
		}
		else
		{
			network = stream;
			secure = false;
		}
		if (network.CanTimeout)
		{
			network.WriteTimeout = timeout;
			network.ReadTimeout = timeout;
		}
		try
		{
			base.ProtocolLogger.LogConnect(uri);
		}
		catch
		{
			network.Dispose();
			secure = false;
			throw;
		}
		connecting = true;
		try
		{
			await engine.ConnectAsync(new ImapStream(network, base.ProtocolLogger), doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		catch
		{
			connecting = false;
			throw;
		}
		try
		{
			if (engine.CapabilitiesVersion == 0)
			{
				await engine.QueryCapabilitiesAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			}
			if (options == SecureSocketOptions.StartTls && (engine.Capabilities & ImapCapabilities.StartTLS) == ImapCapabilities.None)
			{
				throw new NotSupportedException("The IMAP server does not support the STARTTLS extension.");
			}
			if (starttls && (engine.Capabilities & ImapCapabilities.StartTLS) != ImapCapabilities.None)
			{
				ImapCommand ic = engine.QueueCommand(cancellationToken, null, "STARTTLS\r\n");
				await engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
				if (ic.Response == ImapCommandResponse.Ok)
				{
					SslStream sslStream = new SslStream(network, leaveInnerStreamOpen: false, ValidateRemoteCertificate);
					engine.Stream.Stream = sslStream;
					try
					{
						if (doAsync)
						{
							await sslStream.AuthenticateAsClientAsync(host, base.ClientCertificates, base.SslProtocols, base.CheckCertificateRevocation).ConfigureAwait(continueOnCapturedContext: false);
						}
						else
						{
							sslStream.AuthenticateAsClient(host, base.ClientCertificates, base.SslProtocols, base.CheckCertificateRevocation);
						}
					}
					catch (Exception ex2)
					{
						throw SslHandshakeException.Create(this, ex2, true, "IMAP", host, port, 993, 143);
					}
					secure = true;
					if (engine.CapabilitiesVersion == 1)
					{
						await engine.QueryCapabilitiesAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
					}
				}
				else if (options == SecureSocketOptions.StartTls)
				{
					throw ImapCommandException.Create("STARTTLS", ic);
				}
			}
		}
		catch
		{
			secure = false;
			engine.Disconnect();
			throw;
		}
		finally
		{
			connecting = false;
		}
		bool flag = engine.State == ImapEngineState.Authenticated;
		OnConnected(host, port, options);
		if (flag)
		{
			await OnAuthenticatedAsync(string.Empty, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
	}

	private Task ConnectAsync(Socket socket, string host, int port, SecureSocketOptions options, bool doAsync, CancellationToken cancellationToken)
	{
		if (socket == null)
		{
			throw new ArgumentNullException("socket");
		}
		if (!socket.Connected)
		{
			throw new ArgumentException("The socket is not connected.", "socket");
		}
		return ConnectAsync(new NetworkStream(socket, ownsSocket: true), host, port, options, doAsync, cancellationToken);
	}

	public override void Connect(Socket socket, string host, int port = 0, SecureSocketOptions options = SecureSocketOptions.Auto, CancellationToken cancellationToken = default(CancellationToken))
	{
		ConnectAsync(socket, host, port, options, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override void Connect(Stream stream, string host, int port = 0, SecureSocketOptions options = SecureSocketOptions.Auto, CancellationToken cancellationToken = default(CancellationToken))
	{
		ConnectAsync(stream, host, port, options, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	private async Task DisconnectAsync(bool quit, bool doAsync, CancellationToken cancellationToken)
	{
		CheckDisposed();
		if (!engine.IsConnected)
		{
			return;
		}
		if (quit)
		{
			try
			{
				ImapCommand ic = engine.QueueCommand(cancellationToken, null, "LOGOUT\r\n");
				await engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
			}
			catch (OperationCanceledException)
			{
			}
			catch (ImapProtocolException)
			{
			}
			catch (ImapCommandException)
			{
			}
			catch (IOException)
			{
			}
		}
		disconnecting = true;
		engine.Disconnect();
	}

	public override void Disconnect(bool quit, CancellationToken cancellationToken = default(CancellationToken))
	{
		DisconnectAsync(quit, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	private async Task NoOpAsync(bool doAsync, CancellationToken cancellationToken)
	{
		CheckDisposed();
		CheckConnected();
		CheckAuthenticated();
		ImapCommand ic = engine.QueueCommand(cancellationToken, null, "NOOP\r\n");
		await engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
		if (ic.Response != ImapCommandResponse.Ok)
		{
			throw ImapCommandException.Create("NOOP", ic);
		}
	}

	public override void NoOp(CancellationToken cancellationToken = default(CancellationToken))
	{
		NoOpAsync(doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	private async Task IdleAsync(CancellationToken doneToken, bool doAsync, CancellationToken cancellationToken)
	{
		if (!doneToken.CanBeCanceled)
		{
			throw new ArgumentException("The doneToken must be cancellable.", "doneToken");
		}
		CheckDisposed();
		CheckConnected();
		CheckAuthenticated();
		if ((engine.Capabilities & ImapCapabilities.Idle) == ImapCapabilities.None)
		{
			throw new NotSupportedException("The IMAP server does not support the IDLE extension.");
		}
		if (engine.State != ImapEngineState.Selected)
		{
			throw new InvalidOperationException("An ImapFolder has not been opened.");
		}
		if (doneToken.IsCancellationRequested)
		{
			return;
		}
		using ImapIdleContext context = new ImapIdleContext(engine, doneToken, cancellationToken);
		ImapCommand ic = engine.QueueCommand(cancellationToken, null, "IDLE\r\n");
		ic.ContinuationHandler = context.ContinuationHandler;
		ic.UserData = context;
		await engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
		if (ic.Response != ImapCommandResponse.Ok)
		{
			throw ImapCommandException.Create("IDLE", ic);
		}
	}

	public void Idle(CancellationToken doneToken, CancellationToken cancellationToken = default(CancellationToken))
	{
		IdleAsync(doneToken, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	private async Task NotifyAsync(bool status, IList<ImapEventGroup> eventGroups, bool doAsync, CancellationToken cancellationToken)
	{
		if (eventGroups == null)
		{
			throw new ArgumentNullException("eventGroups");
		}
		if (eventGroups.Count == 0)
		{
			throw new ArgumentException("No event groups specified.", "eventGroups");
		}
		CheckDisposed();
		CheckConnected();
		CheckAuthenticated();
		if ((engine.Capabilities & ImapCapabilities.Notify) == ImapCapabilities.None)
		{
			throw new NotSupportedException("The IMAP server does not support the NOTIFY extension.");
		}
		StringBuilder stringBuilder = new StringBuilder("NOTIFY SET");
		bool notifySelectedNewExpunge = false;
		List<object> list = new List<object>();
		if (status)
		{
			stringBuilder.Append(" STATUS");
		}
		foreach (ImapEventGroup eventGroup in eventGroups)
		{
			stringBuilder.Append(" ");
			eventGroup.Format(engine, stringBuilder, list, ref notifySelectedNewExpunge);
		}
		stringBuilder.Append("\r\n");
		ImapCommand ic = new ImapCommand(engine, cancellationToken, null, stringBuilder.ToString(), list.ToArray());
		engine.QueueCommand(ic);
		await engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
		if (ic.Response != ImapCommandResponse.Ok)
		{
			throw ImapCommandException.Create("NOTIFY", ic);
		}
		engine.NotifySelectedNewExpunge = notifySelectedNewExpunge;
	}

	public void Notify(bool status, IList<ImapEventGroup> eventGroups, CancellationToken cancellationToken = default(CancellationToken))
	{
		NotifyAsync(status, eventGroups, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	private async Task DisableNotifyAsync(bool doAsync, CancellationToken cancellationToken)
	{
		CheckDisposed();
		CheckConnected();
		CheckAuthenticated();
		if ((engine.Capabilities & ImapCapabilities.Notify) == ImapCapabilities.None)
		{
			throw new NotSupportedException("The IMAP server does not support the NOTIFY extension.");
		}
		ImapCommand ic = new ImapCommand(engine, cancellationToken, null, "NOTIFY NONE\r\n");
		engine.QueueCommand(ic);
		await engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
		if (ic.Response != ImapCommandResponse.Ok)
		{
			throw ImapCommandException.Create("NOTIFY", ic);
		}
		engine.NotifySelectedNewExpunge = false;
	}

	public void DisableNotify(CancellationToken cancellationToken = default(CancellationToken))
	{
		DisableNotifyAsync(doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override IMailFolder GetFolder(SpecialFolder folder)
	{
		CheckDisposed();
		CheckConnected();
		CheckAuthenticated();
		if ((Capabilities & (ImapCapabilities.SpecialUse | ImapCapabilities.XList)) == ImapCapabilities.None)
		{
			throw new NotSupportedException("The IMAP server does not support the SPECIAL-USE nor XLIST extensions.");
		}
		return folder switch
		{
			SpecialFolder.All => engine.All, 
			SpecialFolder.Archive => engine.Archive, 
			SpecialFolder.Drafts => engine.Drafts, 
			SpecialFolder.Flagged => engine.Flagged, 
			SpecialFolder.Important => engine.Important, 
			SpecialFolder.Junk => engine.Junk, 
			SpecialFolder.Sent => engine.Sent, 
			SpecialFolder.Trash => engine.Trash, 
			_ => throw new ArgumentOutOfRangeException("folder"), 
		};
	}

	public override IMailFolder GetFolder(FolderNamespace @namespace)
	{
		if (@namespace == null)
		{
			throw new ArgumentNullException("namespace");
		}
		CheckDisposed();
		CheckConnected();
		CheckAuthenticated();
		string encodedName = engine.EncodeMailboxName(@namespace.Path);
		if (engine.GetCachedFolder(encodedName, out var folder))
		{
			return folder;
		}
		throw new FolderNotFoundException(@namespace.Path);
	}

	private async Task<IList<IMailFolder>> GetFoldersAsync(FolderNamespace @namespace, StatusItems items, bool subscribedOnly, bool doAsync, CancellationToken cancellationToken)
	{
		if (@namespace == null)
		{
			throw new ArgumentNullException("namespace");
		}
		CheckDisposed();
		CheckConnected();
		CheckAuthenticated();
		IList<ImapFolder> list = await engine.GetFoldersAsync(@namespace, items, subscribedOnly, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		IMailFolder[] array = new IMailFolder[list.Count];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = list[i];
		}
		return array;
	}

	public override IList<IMailFolder> GetFolders(FolderNamespace @namespace, StatusItems items = StatusItems.None, bool subscribedOnly = false, CancellationToken cancellationToken = default(CancellationToken))
	{
		return GetFoldersAsync(@namespace, items, subscribedOnly, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override IMailFolder GetFolder(string path, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		CheckDisposed();
		CheckConnected();
		CheckAuthenticated();
		return engine.GetFolderAsync(path, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	private async Task<string> GetMetadataAsync(MetadataTag tag, bool doAsync, CancellationToken cancellationToken)
	{
		CheckDisposed();
		CheckConnected();
		CheckAuthenticated();
		if ((engine.Capabilities & (ImapCapabilities.Metadata | ImapCapabilities.MetadataServer)) == ImapCapabilities.None)
		{
			throw new NotSupportedException("The IMAP server does not support the METADATA extension.");
		}
		ImapCommand ic = new ImapCommand(engine, cancellationToken, null, "GETMETADATA \"\" %S\r\n", tag.Id);
		ic.RegisterUntaggedHandler("METADATA", ImapUtils.ParseMetadataAsync);
		MetadataCollection metadata = (MetadataCollection)(ic.UserData = new MetadataCollection());
		engine.QueueCommand(ic);
		await engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
		if (ic.Response != ImapCommandResponse.Ok)
		{
			throw ImapCommandException.Create("GETMETADATA", ic);
		}
		string result = null;
		for (int i = 0; i < metadata.Count; i++)
		{
			if (metadata[i].EncodedName.Length == 0 && metadata[i].Tag.Id == tag.Id)
			{
				result = metadata[i].Value;
				metadata.RemoveAt(i);
				break;
			}
		}
		engine.ProcessMetadataChanges(metadata);
		return result;
	}

	public override string GetMetadata(MetadataTag tag, CancellationToken cancellationToken = default(CancellationToken))
	{
		return GetMetadataAsync(tag, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	private async Task<MetadataCollection> GetMetadataAsync(MetadataOptions options, IEnumerable<MetadataTag> tags, bool doAsync, CancellationToken cancellationToken)
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (tags == null)
		{
			throw new ArgumentNullException("tags");
		}
		CheckDisposed();
		CheckConnected();
		CheckAuthenticated();
		if ((engine.Capabilities & (ImapCapabilities.Metadata | ImapCapabilities.MetadataServer)) == ImapCapabilities.None)
		{
			throw new NotSupportedException("The IMAP server does not support the METADATA or METADATA-SERVER extension.");
		}
		StringBuilder stringBuilder = new StringBuilder("GETMETADATA \"\"");
		List<object> list = new List<object>();
		bool flag = false;
		if (options.MaxSize.HasValue || options.Depth != 0)
		{
			stringBuilder.Append(" (");
			if (options.MaxSize.HasValue)
			{
				stringBuilder.AppendFormat("MAXSIZE {0} ", options.MaxSize.Value);
			}
			if (options.Depth > 0)
			{
				stringBuilder.AppendFormat("DEPTH {0} ", (options.Depth == int.MaxValue) ? "infinity" : "1");
			}
			stringBuilder[stringBuilder.Length - 1] = ')';
			stringBuilder.Append(' ');
			flag = true;
		}
		int length = stringBuilder.Length;
		foreach (MetadataTag tag in tags)
		{
			stringBuilder.Append(" %S");
			list.Add(tag.Id);
		}
		if (flag)
		{
			stringBuilder[length] = '(';
			stringBuilder.Append(')');
		}
		stringBuilder.Append("\r\n");
		if (list.Count == 0)
		{
			return new MetadataCollection();
		}
		ImapCommand ic = new ImapCommand(engine, cancellationToken, null, stringBuilder.ToString(), list.ToArray());
		ic.RegisterUntaggedHandler("METADATA", ImapUtils.ParseMetadataAsync);
		ic.UserData = new MetadataCollection();
		options.LongEntries = 0u;
		engine.QueueCommand(ic);
		await engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
		if (ic.Response != ImapCommandResponse.Ok)
		{
			throw ImapCommandException.Create("GETMETADATA", ic);
		}
		if (ic.RespCodes.Count > 0 && ic.RespCodes[ic.RespCodes.Count - 1].Type == ImapResponseCodeType.Metadata)
		{
			MetadataResponseCode metadataResponseCode = (MetadataResponseCode)ic.RespCodes[ic.RespCodes.Count - 1];
			if (metadataResponseCode.SubType == MetadataResponseCodeSubType.LongEntries)
			{
				options.LongEntries = metadataResponseCode.Value;
			}
		}
		return engine.FilterMetadata((MetadataCollection)ic.UserData, string.Empty);
	}

	public override MetadataCollection GetMetadata(MetadataOptions options, IEnumerable<MetadataTag> tags, CancellationToken cancellationToken = default(CancellationToken))
	{
		return GetMetadataAsync(options, tags, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	private async Task SetMetadataAsync(MetadataCollection metadata, bool doAsync, CancellationToken cancellationToken)
	{
		if (metadata == null)
		{
			throw new ArgumentNullException("metadata");
		}
		CheckDisposed();
		CheckConnected();
		CheckAuthenticated();
		if ((engine.Capabilities & (ImapCapabilities.Metadata | ImapCapabilities.MetadataServer)) == ImapCapabilities.None)
		{
			throw new NotSupportedException("The IMAP server does not support the METADATA or METADATA-SERVER extension.");
		}
		if (metadata.Count == 0)
		{
			return;
		}
		StringBuilder stringBuilder = new StringBuilder("SETMETADATA \"\" (");
		List<object> list = new List<object>();
		for (int i = 0; i < metadata.Count; i++)
		{
			if (i > 0)
			{
				stringBuilder.Append(' ');
			}
			if (metadata[i].Value != null)
			{
				stringBuilder.Append("%S %S");
				list.Add(metadata[i].Tag.Id);
				list.Add(metadata[i].Value);
			}
			else
			{
				stringBuilder.Append("%S NIL");
				list.Add(metadata[i].Tag.Id);
			}
		}
		stringBuilder.Append(")\r\n");
		ImapCommand ic = new ImapCommand(engine, cancellationToken, null, stringBuilder.ToString(), list.ToArray());
		engine.QueueCommand(ic);
		await engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
		if (ic.Response == ImapCommandResponse.Ok)
		{
			return;
		}
		throw ImapCommandException.Create("SETMETADATA", ic);
	}

	public override void SetMetadata(MetadataCollection metadata, CancellationToken cancellationToken = default(CancellationToken))
	{
		SetMetadataAsync(metadata, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	private void OnEngineMetadataChanged(object sender, MetadataChangedEventArgs e)
	{
		OnMetadataChanged(e.Metadata);
	}

	private void OnEngineFolderCreated(object sender, FolderCreatedEventArgs e)
	{
		OnFolderCreated(e.Folder);
	}

	private void OnEngineAlert(object sender, AlertEventArgs e)
	{
		OnAlert(e.Message);
	}

	private void OnEngineWebAlert(object sender, WebAlertEventArgs e)
	{
		OnWebAlert(e.WebUri, e.Message);
	}

	protected virtual void OnWebAlert(Uri uri, string message)
	{
		this.WebAlert?.Invoke(this, new WebAlertEventArgs(uri, message));
	}

	private void OnEngineDisconnected(object sender, EventArgs e)
	{
		if (!connecting)
		{
			bool requested = disconnecting;
			Uri uri = engine.Uri;
			disconnecting = false;
			secure = false;
			OnDisconnected(uri.Host, uri.Port, GetSecureSocketOptions(uri), requested);
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && !disposed)
		{
			engine.MetadataChanged -= OnEngineMetadataChanged;
			engine.FolderCreated -= OnEngineFolderCreated;
			engine.Disconnected -= OnEngineDisconnected;
			engine.WebAlert -= OnEngineWebAlert;
			engine.Alert -= OnEngineAlert;
			engine.Dispose();
			disposed = true;
		}
		base.Dispose(disposing);
	}
}
