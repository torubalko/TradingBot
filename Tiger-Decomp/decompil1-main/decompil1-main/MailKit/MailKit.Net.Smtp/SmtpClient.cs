using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MailKit.Security;
using MimeKit;
using MimeKit.IO;

namespace MailKit.Net.Smtp;

public class SmtpClient : MailTransport, ISmtpClient, IMailTransport, IMailService, IDisposable
{
	private enum SmtpCommand
	{
		MailFrom,
		RcptTo
	}

	[Flags]
	private enum SmtpExtension
	{
		None = 0,
		EightBitMime = 1,
		BinaryMime = 2,
		UTF8 = 4
	}

	private class ContentTransferEncodingVisitor : MimeVisitor
	{
		private readonly SmtpCapabilities capabilities;

		public SmtpExtension SmtpExtensions { get; private set; }

		public ContentTransferEncodingVisitor(SmtpCapabilities capabilities)
		{
			this.capabilities = capabilities;
		}

		protected override void VisitMimePart(MimePart entity)
		{
			switch (entity.ContentTransferEncoding)
			{
			case ContentEncoding.EightBit:
				if ((capabilities & SmtpCapabilities.EightBitMime) != SmtpCapabilities.None)
				{
					SmtpExtensions |= SmtpExtension.EightBitMime;
				}
				break;
			case ContentEncoding.Binary:
				if ((capabilities & SmtpCapabilities.BinaryMime) != SmtpCapabilities.None)
				{
					SmtpExtensions |= SmtpExtension.BinaryMime;
				}
				break;
			}
		}
	}

	private class SendContext
	{
		private readonly ITransferProgress progress;

		private readonly long size;

		private long nwritten;

		public SendContext(ITransferProgress progress, long size)
		{
			this.progress = progress;
			this.size = size;
		}

		public void Update(int n)
		{
			nwritten += n;
			if (size != -1)
			{
				progress.Report(nwritten, size);
			}
			else
			{
				progress.Report(nwritten);
			}
		}
	}

	private static readonly byte[] EndData = Encoding.ASCII.GetBytes(".\r\n");

	private const int MaxLineLength = 998;

	private readonly HashSet<string> authenticationMechanisms = new HashSet<string>(StringComparer.Ordinal);

	private readonly SmtpAuthenticationSecretDetector detector = new SmtpAuthenticationSecretDetector();

	private readonly List<SmtpCommand> queued = new List<SmtpCommand>();

	private SmtpCapabilities capabilities;

	private int timeout = 120000;

	private bool authenticated;

	private bool connected;

	private bool disposed;

	private bool secure;

	private Uri uri;

	private SmtpStream Stream { get; set; }

	public override object SyncRoot => this;

	protected override string Protocol => "smtp";

	public SmtpCapabilities Capabilities
	{
		get
		{
			return capabilities;
		}
		set
		{
			if ((capabilities | value) > capabilities)
			{
				throw new ArgumentException("Capabilities cannot be enabled, they may only be disabled.", "value");
			}
			capabilities = value;
		}
	}

	public string LocalDomain { get; set; }

	protected virtual bool PreferSendAsBinaryData => false;

	public uint MaxSize { get; private set; }

	public override HashSet<string> AuthenticationMechanisms => authenticationMechanisms;

	public override int Timeout
	{
		get
		{
			return timeout;
		}
		set
		{
			if (IsConnected && Stream.CanTimeout)
			{
				Stream.WriteTimeout = value;
				Stream.ReadTimeout = value;
			}
			timeout = value;
		}
	}

	public override bool IsConnected => connected;

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
			if (IsSecure && Stream.Stream is SslStream sslStream)
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
			if (IsSecure && Stream.Stream is SslStream sslStream)
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
			if (IsSecure && Stream.Stream is SslStream sslStream)
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
			if (IsSecure && Stream.Stream is SslStream sslStream)
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
			if (IsSecure && Stream.Stream is SslStream sslStream)
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
			if (IsSecure && Stream.Stream is SslStream sslStream)
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
			if (IsSecure && Stream.Stream is SslStream sslStream)
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
			if (IsSecure && Stream.Stream is SslStream sslStream)
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
			if (IsSecure && Stream.Stream is SslStream sslStream)
			{
				return sslStream.KeyExchangeStrength;
			}
			return null;
		}
	}

	public override bool IsAuthenticated => authenticated;

	public DeliveryStatusNotificationType DeliveryStatusNotificationType { get; set; }

	protected Task<SmtpResponse> SendCommandAsync(string command, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (command == null)
		{
			throw new ArgumentNullException("command");
		}
		CheckDisposed();
		if (!IsConnected)
		{
			throw new ServiceNotConnectedException("The SmtpClient must be connected before you can send commands.");
		}
		return SendCommandAsync(command, doAsync: true, cancellationToken);
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

	public override Task SendAsync(FormatOptions options, MimeMessage message, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (message == null)
		{
			throw new ArgumentNullException("message");
		}
		IList<MailboxAddress> messageRecipients = GetMessageRecipients(message);
		MailboxAddress messageSender = GetMessageSender(message);
		if (messageSender == null)
		{
			throw new InvalidOperationException("No sender has been specified.");
		}
		if (messageRecipients.Count == 0)
		{
			throw new InvalidOperationException("No recipients have been specified.");
		}
		return SendAsync(options, message, messageSender, messageRecipients, doAsync: true, cancellationToken, progress);
	}

	public override Task SendAsync(FormatOptions options, MimeMessage message, MailboxAddress sender, IEnumerable<MailboxAddress> recipients, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (message == null)
		{
			throw new ArgumentNullException("message");
		}
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (recipients == null)
		{
			throw new ArgumentNullException("recipients");
		}
		HashSet<string> unique = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
		List<MailboxAddress> list = new List<MailboxAddress>();
		AddUnique(list, unique, recipients);
		if (list.Count == 0)
		{
			throw new InvalidOperationException("No recipients have been specified.");
		}
		return SendAsync(options, message, sender, list, doAsync: true, cancellationToken, progress);
	}

	public Task<InternetAddressList> ExpandAsync(string alias, CancellationToken cancellationToken = default(CancellationToken))
	{
		return ExpandAsync(alias, doAsync: true, cancellationToken);
	}

	public Task<MailboxAddress> VerifyAsync(string address, CancellationToken cancellationToken = default(CancellationToken))
	{
		return VerifyAsync(address, doAsync: true, cancellationToken);
	}

	public SmtpClient()
		: this(new NullProtocolLogger())
	{
	}

	public SmtpClient(IProtocolLogger protocolLogger)
		: base(protocolLogger)
	{
		protocolLogger.AuthenticationSecretDetector = detector;
	}

	private void CheckDisposed()
	{
		if (disposed)
		{
			throw new ObjectDisposedException("SmtpClient");
		}
	}

	private bool ValidateRemoteCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
	{
		if (base.ServerCertificateValidationCallback != null)
		{
			return base.ServerCertificateValidationCallback(uri.Host, certificate, chain, sslPolicyErrors);
		}
		if (ServicePointManager.ServerCertificateValidationCallback != null)
		{
			return ServicePointManager.ServerCertificateValidationCallback(uri.Host, certificate, chain, sslPolicyErrors);
		}
		return DefaultServerCertificateValidationCallback(uri.Host, certificate, chain, sslPolicyErrors);
	}

	private async Task QueueCommandAsync(SmtpCommand type, string command, bool doAsync, CancellationToken cancellationToken)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(command + "\r\n");
		if (doAsync)
		{
			await Stream.WriteAsync(bytes, 0, bytes.Length, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		else
		{
			Stream.Write(bytes, 0, bytes.Length, cancellationToken);
		}
		queued.Add(type);
	}

	protected virtual void OnNoRecipientsAccepted(MimeMessage message)
	{
	}

	private async Task FlushCommandQueueAsync(MimeMessage message, MailboxAddress sender, IList<MailboxAddress> recipients, bool doAsync, CancellationToken cancellationToken)
	{
		try
		{
			if (doAsync)
			{
				await Stream.FlushAsync(cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			}
			else
			{
				Stream.Flush(cancellationToken);
			}
		}
		catch
		{
			queued.Clear();
			throw;
		}
		List<SmtpResponse> responses = new List<SmtpResponse>();
		Exception rex = null;
		int accepted = 0;
		int rcpt = 0;
		try
		{
			for (int i = 0; i < queued.Count; i++)
			{
				SmtpResponse item = ((!doAsync) ? Stream.ReadResponse(cancellationToken) : (await Stream.ReadResponseAsync(cancellationToken).ConfigureAwait(continueOnCapturedContext: false)));
				responses.Add(item);
			}
		}
		catch (Exception ex)
		{
			rex = ex;
		}
		try
		{
			for (int j = 0; j < responses.Count; j++)
			{
				switch (queued[j])
				{
				case SmtpCommand.MailFrom:
					ProcessMailFromResponse(message, sender, responses[j]);
					break;
				case SmtpCommand.RcptTo:
					if (ProcessRcptToResponse(message, recipients[rcpt++], responses[j]))
					{
						accepted++;
					}
					break;
				}
			}
		}
		finally
		{
			queued.Clear();
		}
		if (rex != null)
		{
			throw rex;
		}
		if (accepted == 0)
		{
			OnNoRecipientsAccepted(message);
		}
	}

	private async Task<SmtpResponse> SendCommandAsync(string command, bool doAsync, CancellationToken cancellationToken)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(command + "\r\n");
		if (doAsync)
		{
			await Stream.WriteAsync(bytes, 0, bytes.Length, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			await Stream.FlushAsync(cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			return await Stream.ReadResponseAsync(cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		Stream.Write(bytes, 0, bytes.Length, cancellationToken);
		Stream.Flush(cancellationToken);
		return Stream.ReadResponse(cancellationToken);
	}

	protected SmtpResponse SendCommand(string command, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (command == null)
		{
			throw new ArgumentNullException("command");
		}
		CheckDisposed();
		if (!IsConnected)
		{
			throw new ServiceNotConnectedException("The SmtpClient must be connected before you can send commands.");
		}
		return SendCommandAsync(command, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	private async Task<SmtpResponse> SendEhloAsync(bool ehlo, bool doAsync, CancellationToken cancellationToken)
	{
		NetworkStream networkStream = NetworkStream.Get(Stream.Stream);
		string text = (ehlo ? "EHLO " : "HELO ");
		string text2 = null;
		IPAddress address = null;
		if (!string.IsNullOrEmpty(LocalDomain))
		{
			if (!IPAddress.TryParse(LocalDomain, out address))
			{
				text2 = LocalDomain;
			}
		}
		else if (networkStream != null)
		{
			if (!(networkStream.Socket.LocalEndPoint is IPEndPoint iPEndPoint))
			{
				text2 = ((DnsEndPoint)networkStream.Socket.LocalEndPoint).Host;
			}
			else
			{
				address = iPEndPoint.Address;
			}
		}
		else
		{
			text2 = "[127.0.0.1]";
		}
		if (address != null)
		{
			if (address.IsIPv4MappedToIPv6)
			{
				try
				{
					address = address.MapToIPv4();
				}
				catch (ArgumentOutOfRangeException)
				{
				}
			}
			text2 = ((address.AddressFamily != AddressFamily.InterNetworkV6) ? ("[" + address?.ToString() + "]") : ("[IPv6:" + address?.ToString() + "]"));
		}
		text += text2;
		return await SendCommandAsync(text, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
	}

	private async Task EhloAsync(bool doAsync, CancellationToken cancellationToken)
	{
		SmtpResponse smtpResponse = await SendEhloAsync(ehlo: true, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		if (authenticated && smtpResponse.StatusCode == SmtpStatusCode.BadCommandSequence)
		{
			return;
		}
		if (smtpResponse.StatusCode != SmtpStatusCode.Ok)
		{
			smtpResponse = await SendEhloAsync(ehlo: false, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			if (smtpResponse.StatusCode != SmtpStatusCode.Ok)
			{
				throw new SmtpCommandException(SmtpErrorCode.UnexpectedStatusCode, smtpResponse.StatusCode, smtpResponse.Response);
			}
			return;
		}
		capabilities &= SmtpCapabilities.StartTLS;
		AuthenticationMechanisms.Clear();
		MaxSize = 0u;
		string[] array = smtpResponse.Response.Split('\n');
		for (int i = 0; i < array.Length; i++)
		{
			string text = array[i].Trim().ToUpperInvariant();
			if (text.StartsWith("AUTH", StringComparison.Ordinal) || text.StartsWith("X-EXPS", StringComparison.Ordinal))
			{
				int num = ((text[0] == 'A') ? "AUTH".Length : "X-EXPS".Length);
				if (num < text.Length && (text[num] == ' ' || text[num] == '='))
				{
					capabilities |= SmtpCapabilities.Authentication;
					num++;
					string text2 = text.Substring(num);
					string[] array2 = text2.Split(new char[1] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
					foreach (string item in array2)
					{
						AuthenticationMechanisms.Add(item);
					}
				}
				continue;
			}
			if (text.StartsWith("SIZE", StringComparison.Ordinal))
			{
				int k = 4;
				capabilities |= SmtpCapabilities.Size;
				for (; k < text.Length && char.IsWhiteSpace(text[k]); k++)
				{
				}
				if (uint.TryParse(text.Substring(k), NumberStyles.None, CultureInfo.InvariantCulture, out var result))
				{
					MaxSize = result;
				}
				continue;
			}
			switch (text)
			{
			case "DSN":
				capabilities |= SmtpCapabilities.Dsn;
				break;
			case "BINARYMIME":
				capabilities |= SmtpCapabilities.BinaryMime;
				break;
			case "CHUNKING":
				capabilities |= SmtpCapabilities.Chunking;
				break;
			case "ENHANCEDSTATUSCODES":
				capabilities |= SmtpCapabilities.EnhancedStatusCodes;
				break;
			case "8BITMIME":
				capabilities |= SmtpCapabilities.EightBitMime;
				break;
			case "PIPELINING":
				capabilities |= SmtpCapabilities.Pipelining;
				break;
			case "STARTTLS":
				capabilities |= SmtpCapabilities.StartTLS;
				break;
			case "SMTPUTF8":
				capabilities |= SmtpCapabilities.UTF8;
				break;
			case "REQUIRETLS":
				capabilities |= SmtpCapabilities.RequireTLS;
				break;
			}
		}
	}

	private async Task AuthenticateAsync(SaslMechanism mechanism, bool doAsync, CancellationToken cancellationToken)
	{
		if (mechanism == null)
		{
			throw new ArgumentNullException("mechanism");
		}
		CheckDisposed();
		if (!IsConnected)
		{
			throw new ServiceNotConnectedException("The SmtpClient must be connected before you can authenticate.");
		}
		if (IsAuthenticated)
		{
			throw new InvalidOperationException("The SmtpClient is already authenticated.");
		}
		if ((capabilities & SmtpCapabilities.Authentication) == 0)
		{
			throw new NotSupportedException("The SMTP server does not support authentication.");
		}
		cancellationToken.ThrowIfCancellationRequested();
		SaslException saslException = null;
		mechanism.Uri = new Uri("smtp://" + uri.Host);
		string command;
		if (mechanism.SupportsInitialResponse)
		{
			string arg = mechanism.Challenge(null);
			command = $"AUTH {mechanism.MechanismName} {arg}";
		}
		else
		{
			command = $"AUTH {mechanism.MechanismName}";
		}
		detector.IsAuthenticating = true;
		SmtpResponse response;
		try
		{
			response = await SendCommandAsync(command, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			if (response.StatusCode == SmtpStatusCode.AuthenticationMechanismTooWeak)
			{
				throw new MailKit.Security.AuthenticationException(response.Response);
			}
			try
			{
				while (response.StatusCode == SmtpStatusCode.AuthenticationChallenge)
				{
					string arg = mechanism.Challenge(response.Response);
					response = await SendCommandAsync(arg, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				}
				saslException = null;
			}
			catch (SaslException ex)
			{
				response = await SendCommandAsync(string.Empty, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				saslException = ex;
			}
		}
		finally
		{
			detector.IsAuthenticating = false;
		}
		if (response.StatusCode == SmtpStatusCode.AuthenticationSuccessful)
		{
			if (mechanism.NegotiatedSecurityLayer)
			{
				await EhloAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			}
			authenticated = true;
			OnAuthenticated(response.Response);
			return;
		}
		string message = string.Format(CultureInfo.InvariantCulture, "{0}: {1}", (int)response.StatusCode, response.Response);
		if (saslException != null)
		{
			throw new MailKit.Security.AuthenticationException(message, saslException);
		}
		throw new MailKit.Security.AuthenticationException(message);
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
		if (!IsConnected)
		{
			throw new ServiceNotConnectedException("The SmtpClient must be connected before you can authenticate.");
		}
		if (IsAuthenticated)
		{
			throw new InvalidOperationException("The SmtpClient is already authenticated.");
		}
		if ((capabilities & SmtpCapabilities.Authentication) == 0)
		{
			throw new NotSupportedException("The SMTP server does not support authentication.");
		}
		Uri saslUri = new Uri("smtp://" + uri.Host);
		MailKit.Security.AuthenticationException authException = null;
		bool tried = false;
		string[] authMechanismRank = SaslMechanism.AuthMechanismRank;
		foreach (string text in authMechanismRank)
		{
			if (!AuthenticationMechanisms.Contains(text))
			{
				continue;
			}
			SaslMechanism saslMechanism;
			SaslMechanism sasl = (saslMechanism = SaslMechanism.Create(text, saslUri, encoding, credentials));
			if (saslMechanism == null)
			{
				continue;
			}
			tried = true;
			cancellationToken.ThrowIfCancellationRequested();
			string command;
			if (sasl.SupportsInitialResponse)
			{
				string arg = sasl.Challenge(null);
				command = $"AUTH {text} {arg}";
			}
			else
			{
				command = $"AUTH {text}";
			}
			detector.IsAuthenticating = true;
			SaslException saslException = null;
			SmtpResponse response;
			try
			{
				response = await SendCommandAsync(command, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				if (response.StatusCode == SmtpStatusCode.AuthenticationMechanismTooWeak)
				{
					continue;
				}
				try
				{
					while (!sasl.IsAuthenticated && response.StatusCode == SmtpStatusCode.AuthenticationChallenge)
					{
						string arg = sasl.Challenge(response.Response);
						response = await SendCommandAsync(arg, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
					}
					saslException = null;
				}
				catch (SaslException ex)
				{
					response = await SendCommandAsync(string.Empty, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
					saslException = ex;
				}
				goto IL_03d3;
			}
			finally
			{
				detector.IsAuthenticating = false;
			}
			IL_03d3:
			if (response.StatusCode == SmtpStatusCode.AuthenticationSuccessful)
			{
				if (sasl.NegotiatedSecurityLayer)
				{
					await EhloAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				}
				authenticated = true;
				OnAuthenticated(response.Response);
				return;
			}
			string message = string.Format(CultureInfo.InvariantCulture, "{0}: {1}", (int)response.StatusCode, response.Response);
			Exception innerException = ((saslException == null) ? new SmtpCommandException(SmtpErrorCode.UnexpectedStatusCode, response.StatusCode, response.Response) : new SmtpCommandException(SmtpErrorCode.UnexpectedStatusCode, response.StatusCode, response.Response, saslException));
			authException = new MailKit.Security.AuthenticationException(message, innerException);
		}
		if (tried)
		{
			throw authException ?? new MailKit.Security.AuthenticationException();
		}
		throw new NotSupportedException("No compatible authentication mechanisms found.");
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
		Stream = new SmtpStream(replayStream, base.ProtocolLogger);
		capabilities = SmtpCapabilities.None;
		AuthenticationMechanisms.Clear();
		uri = new Uri("smtp://" + host + ":25");
		secure = false;
		MaxSize = 0u;
		try
		{
			SmtpResponse smtpResponse = Stream.ReadResponse(cancellationToken);
			if (smtpResponse.StatusCode != SmtpStatusCode.ServiceReady)
			{
				throw new SmtpCommandException(SmtpErrorCode.UnexpectedStatusCode, smtpResponse.StatusCode, smtpResponse.Response);
			}
			EhloAsync(doAsync: false, cancellationToken).GetAwaiter().GetResult();
			connected = true;
		}
		catch
		{
			Stream.Dispose();
			Stream = null;
			throw;
		}
		OnConnected(host, 25, SecureSocketOptions.None);
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
		Stream = new SmtpStream(replayStream, base.ProtocolLogger);
		capabilities = SmtpCapabilities.None;
		AuthenticationMechanisms.Clear();
		uri = new Uri("smtp://" + host + ":25");
		secure = false;
		MaxSize = 0u;
		try
		{
			SmtpResponse smtpResponse = await Stream.ReadResponseAsync(cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			if (smtpResponse.StatusCode != SmtpStatusCode.ServiceReady)
			{
				throw new SmtpCommandException(SmtpErrorCode.UnexpectedStatusCode, smtpResponse.StatusCode, smtpResponse.Response);
			}
			await EhloAsync(doAsync: true, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			connected = true;
		}
		catch
		{
			Stream.Dispose();
			Stream = null;
			throw;
		}
		OnConnected(host, 25, SecureSocketOptions.None);
	}

	internal static void ComputeDefaultValues(string host, ref int port, ref SecureSocketOptions options, out Uri uri, out bool starttls)
	{
		switch (options)
		{
		default:
			if (port == 0)
			{
				port = 25;
			}
			break;
		case SecureSocketOptions.Auto:
		{
			int num = port;
			if (num != 0)
			{
				if (num == 465)
				{
					options = SecureSocketOptions.SslOnConnect;
					break;
				}
			}
			else
			{
				port = 25;
			}
			options = SecureSocketOptions.StartTlsWhenAvailable;
			break;
		}
		case SecureSocketOptions.SslOnConnect:
			if (port == 0)
			{
				port = 465;
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
			uri = new Uri(string.Format(CultureInfo.InvariantCulture, "smtp://{0}:{1}/?starttls=when-available", host, port));
			starttls = true;
			break;
		case SecureSocketOptions.StartTls:
			uri = new Uri(string.Format(CultureInfo.InvariantCulture, "smtp://{0}:{1}/?starttls=always", host, port));
			starttls = true;
			break;
		case SecureSocketOptions.SslOnConnect:
			uri = new Uri(string.Format(CultureInfo.InvariantCulture, "smtps://{0}:{1}", host, port));
			starttls = false;
			break;
		default:
			uri = new Uri(string.Format(CultureInfo.InvariantCulture, "smtp://{0}:{1}", host, port));
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
			throw new InvalidOperationException("The SmtpClient is already connected.");
		}
		capabilities = SmtpCapabilities.None;
		AuthenticationMechanisms.Clear();
		MaxSize = 0u;
		ComputeDefaultValues(host, ref port, ref options, out uri, out var starttls);
		Stream stream = new NetworkStream(await ConnectSocket(host, port, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false), ownsSocket: true)
		{
			WriteTimeout = timeout,
			ReadTimeout = timeout
		};
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
				throw SslHandshakeException.Create(this, ex, false, "SMTP", host, port, 465, 25, 587);
			}
			secure = true;
			stream = ssl;
		}
		else
		{
			secure = false;
		}
		Stream = new SmtpStream(stream, base.ProtocolLogger);
		try
		{
			base.ProtocolLogger.LogConnect(uri);
			SmtpResponse smtpResponse = ((!doAsync) ? Stream.ReadResponse(cancellationToken) : (await Stream.ReadResponseAsync(cancellationToken).ConfigureAwait(continueOnCapturedContext: false)));
			if (smtpResponse.StatusCode != SmtpStatusCode.ServiceReady)
			{
				throw new SmtpCommandException(SmtpErrorCode.UnexpectedStatusCode, smtpResponse.StatusCode, smtpResponse.Response);
			}
			await EhloAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			if (options == SecureSocketOptions.StartTls && (capabilities & SmtpCapabilities.StartTLS) == 0)
			{
				throw new NotSupportedException("The SMTP server does not support the STARTTLS extension.");
			}
			if (starttls && (capabilities & SmtpCapabilities.StartTLS) != SmtpCapabilities.None)
			{
				smtpResponse = await SendCommandAsync("STARTTLS", doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				if (smtpResponse.StatusCode != SmtpStatusCode.ServiceReady)
				{
					throw new SmtpCommandException(SmtpErrorCode.UnexpectedStatusCode, smtpResponse.StatusCode, smtpResponse.Response);
				}
				try
				{
					SslStream sslStream = new SslStream(stream, leaveInnerStreamOpen: false, ValidateRemoteCertificate);
					Stream.Stream = sslStream;
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
					throw SslHandshakeException.Create(this, ex2, true, "SMTP", host, port, 465, 25, 587);
				}
				secure = true;
				await EhloAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			}
			connected = true;
		}
		catch
		{
			Stream.Dispose();
			secure = false;
			Stream = null;
			throw;
		}
		OnConnected(host, port, options);
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
			throw new InvalidOperationException("The SmtpClient is already connected.");
		}
		capabilities = SmtpCapabilities.None;
		AuthenticationMechanisms.Clear();
		MaxSize = 0u;
		ComputeDefaultValues(host, ref port, ref options, out uri, out var starttls);
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
				throw SslHandshakeException.Create(this, ex, false, "SMTP", host, port, 465, 25, 587);
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
		Stream = new SmtpStream(network, base.ProtocolLogger);
		try
		{
			base.ProtocolLogger.LogConnect(uri);
			SmtpResponse smtpResponse = ((!doAsync) ? Stream.ReadResponse(cancellationToken) : (await Stream.ReadResponseAsync(cancellationToken).ConfigureAwait(continueOnCapturedContext: false)));
			if (smtpResponse.StatusCode != SmtpStatusCode.ServiceReady)
			{
				throw new SmtpCommandException(SmtpErrorCode.UnexpectedStatusCode, smtpResponse.StatusCode, smtpResponse.Response);
			}
			await EhloAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			if (options == SecureSocketOptions.StartTls && (capabilities & SmtpCapabilities.StartTLS) == 0)
			{
				throw new NotSupportedException("The SMTP server does not support the STARTTLS extension.");
			}
			if (starttls && (capabilities & SmtpCapabilities.StartTLS) != SmtpCapabilities.None)
			{
				smtpResponse = await SendCommandAsync("STARTTLS", doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				if (smtpResponse.StatusCode != SmtpStatusCode.ServiceReady)
				{
					throw new SmtpCommandException(SmtpErrorCode.UnexpectedStatusCode, smtpResponse.StatusCode, smtpResponse.Response);
				}
				SslStream sslStream = new SslStream(network, leaveInnerStreamOpen: false, ValidateRemoteCertificate);
				Stream.Stream = sslStream;
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
					throw SslHandshakeException.Create(this, ex2, true, "SMTP", host, port, 465, 25, 587);
				}
				secure = true;
				await EhloAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			}
			connected = true;
		}
		catch
		{
			Stream.Dispose();
			secure = false;
			Stream = null;
			throw;
		}
		OnConnected(host, port, options);
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
		if (!IsConnected)
		{
			return;
		}
		if (quit)
		{
			try
			{
				await SendCommandAsync("QUIT", doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			}
			catch (OperationCanceledException)
			{
			}
			catch (SmtpProtocolException)
			{
			}
			catch (SmtpCommandException)
			{
			}
			catch (IOException)
			{
			}
		}
		Disconnect(uri.Host, uri.Port, GetSecureSocketOptions(uri), requested: true);
	}

	public override void Disconnect(bool quit, CancellationToken cancellationToken = default(CancellationToken))
	{
		DisconnectAsync(quit, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	private async Task NoOpAsync(bool doAsync, CancellationToken cancellationToken)
	{
		CheckDisposed();
		if (!IsConnected)
		{
			throw new ServiceNotConnectedException("The SmtpClient is not connected.");
		}
		SmtpResponse smtpResponse;
		try
		{
			smtpResponse = await SendCommandAsync("NOOP", doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		catch
		{
			Disconnect(uri.Host, uri.Port, GetSecureSocketOptions(uri), requested: false);
			throw;
		}
		if (smtpResponse.StatusCode != SmtpStatusCode.Ok)
		{
			throw new SmtpCommandException(SmtpErrorCode.UnexpectedStatusCode, smtpResponse.StatusCode, smtpResponse.Response);
		}
	}

	public override void NoOp(CancellationToken cancellationToken = default(CancellationToken))
	{
		NoOpAsync(doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	private void Disconnect(string host, int port, SecureSocketOptions options, bool requested)
	{
		capabilities = SmtpCapabilities.None;
		authenticated = false;
		connected = false;
		secure = false;
		uri = null;
		if (Stream != null)
		{
			Stream.Dispose();
			Stream = null;
		}
		if (host != null)
		{
			OnDisconnected(host, port, options, requested);
		}
	}

	private static MailboxAddress GetMessageSender(MimeMessage message)
	{
		if (message.ResentSender != null)
		{
			return message.ResentSender;
		}
		if (message.ResentFrom.Count > 0)
		{
			return message.ResentFrom.Mailboxes.FirstOrDefault();
		}
		if (message.Sender != null)
		{
			return message.Sender;
		}
		return message.From.Mailboxes.FirstOrDefault();
	}

	private static void AddUnique(IList<MailboxAddress> recipients, HashSet<string> unique, IEnumerable<MailboxAddress> mailboxes)
	{
		foreach (MailboxAddress mailbox in mailboxes)
		{
			if (unique.Add(mailbox.Address))
			{
				recipients.Add(mailbox);
			}
		}
	}

	private static IList<MailboxAddress> GetMessageRecipients(MimeMessage message)
	{
		HashSet<string> unique = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
		List<MailboxAddress> list = new List<MailboxAddress>();
		if (message.ResentSender != null || message.ResentFrom.Count > 0)
		{
			AddUnique(list, unique, message.ResentTo.Mailboxes);
			AddUnique(list, unique, message.ResentCc.Mailboxes);
			AddUnique(list, unique, message.ResentBcc.Mailboxes);
		}
		else
		{
			AddUnique(list, unique, message.To.Mailboxes);
			AddUnique(list, unique, message.Cc.Mailboxes);
			AddUnique(list, unique, message.Bcc.Mailboxes);
		}
		return list;
	}

	protected virtual void OnSenderAccepted(MimeMessage message, MailboxAddress mailbox, SmtpResponse response)
	{
	}

	protected virtual void OnSenderNotAccepted(MimeMessage message, MailboxAddress mailbox, SmtpResponse response)
	{
		throw new SmtpCommandException(SmtpErrorCode.SenderNotAccepted, response.StatusCode, mailbox, response.Response);
	}

	private void ProcessMailFromResponse(MimeMessage message, MailboxAddress mailbox, SmtpResponse response)
	{
		if (response.StatusCode >= SmtpStatusCode.Ok && response.StatusCode < (SmtpStatusCode)260)
		{
			OnSenderAccepted(message, mailbox, response);
			return;
		}
		if (response.StatusCode == SmtpStatusCode.AuthenticationRequired)
		{
			throw new ServiceNotAuthenticatedException(response.Response);
		}
		OnSenderNotAccepted(message, mailbox, response);
	}

	protected virtual string GetEnvelopeId(MimeMessage message)
	{
		return null;
	}

	private async Task MailFromAsync(FormatOptions options, MimeMessage message, MailboxAddress mailbox, SmtpExtension extensions, long size, bool doAsync, CancellationToken cancellationToken)
	{
		bool flag = (extensions & SmtpExtension.UTF8) == 0;
		StringBuilder stringBuilder = new StringBuilder("MAIL FROM:<");
		string address = mailbox.GetAddress(flag);
		stringBuilder.Append(address);
		stringBuilder.Append('>');
		if (!flag)
		{
			stringBuilder.Append(" SMTPUTF8");
		}
		if ((Capabilities & SmtpCapabilities.Size) != SmtpCapabilities.None && size != -1)
		{
			stringBuilder.AppendFormat(CultureInfo.InvariantCulture, " SIZE={0}", size);
		}
		if ((extensions & SmtpExtension.BinaryMime) != SmtpExtension.None)
		{
			stringBuilder.Append(" BODY=BINARYMIME");
		}
		else if ((extensions & SmtpExtension.EightBitMime) != SmtpExtension.None)
		{
			stringBuilder.Append(" BODY=8BITMIME");
		}
		if ((capabilities & SmtpCapabilities.Dsn) != SmtpCapabilities.None)
		{
			string envelopeId = GetEnvelopeId(message);
			if (!string.IsNullOrEmpty(envelopeId))
			{
				stringBuilder.Append(" ENVID=");
				stringBuilder.Append(envelopeId);
			}
			switch (DeliveryStatusNotificationType)
			{
			case DeliveryStatusNotificationType.HeadersOnly:
				stringBuilder.Append(" RET=HDRS");
				break;
			case DeliveryStatusNotificationType.Full:
				stringBuilder.Append(" RET=FULL");
				break;
			}
		}
		string command = stringBuilder.ToString();
		if ((capabilities & SmtpCapabilities.Pipelining) != SmtpCapabilities.None)
		{
			await QueueCommandAsync(SmtpCommand.MailFrom, command, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		else
		{
			ProcessMailFromResponse(message, mailbox, await SendCommandAsync(command, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false));
		}
	}

	protected virtual void OnRecipientAccepted(MimeMessage message, MailboxAddress mailbox, SmtpResponse response)
	{
	}

	protected virtual void OnRecipientNotAccepted(MimeMessage message, MailboxAddress mailbox, SmtpResponse response)
	{
		throw new SmtpCommandException(SmtpErrorCode.RecipientNotAccepted, response.StatusCode, mailbox, response.Response);
	}

	private bool ProcessRcptToResponse(MimeMessage message, MailboxAddress mailbox, SmtpResponse response)
	{
		if (response.StatusCode < (SmtpStatusCode)300)
		{
			OnRecipientAccepted(message, mailbox, response);
			return true;
		}
		if (response.StatusCode == SmtpStatusCode.AuthenticationRequired)
		{
			throw new ServiceNotAuthenticatedException(response.Response);
		}
		OnRecipientNotAccepted(message, mailbox, response);
		return false;
	}

	protected virtual DeliveryStatusNotification? GetDeliveryStatusNotifications(MimeMessage message, MailboxAddress mailbox)
	{
		return null;
	}

	private static string GetNotifyString(DeliveryStatusNotification notify)
	{
		string text = string.Empty;
		if (notify == DeliveryStatusNotification.Never)
		{
			return "NEVER";
		}
		if ((notify & DeliveryStatusNotification.Success) != DeliveryStatusNotification.Never)
		{
			text += "SUCCESS,";
		}
		if ((notify & DeliveryStatusNotification.Failure) != DeliveryStatusNotification.Never)
		{
			text += "FAILURE,";
		}
		if ((notify & DeliveryStatusNotification.Delay) != DeliveryStatusNotification.Never)
		{
			text += "DELAY";
		}
		return text.TrimEnd(',');
	}

	private async Task<bool> RcptToAsync(FormatOptions options, MimeMessage message, MailboxAddress mailbox, bool doAsync, CancellationToken cancellationToken)
	{
		bool idnEncode = (Capabilities & SmtpCapabilities.UTF8) == 0;
		string text = $"RCPT TO:<{mailbox.GetAddress(idnEncode)}>";
		if ((capabilities & SmtpCapabilities.Dsn) != SmtpCapabilities.None)
		{
			DeliveryStatusNotification? deliveryStatusNotifications = GetDeliveryStatusNotifications(message, mailbox);
			if (deliveryStatusNotifications.HasValue)
			{
				text = text + " NOTIFY=" + GetNotifyString(deliveryStatusNotifications.Value);
			}
		}
		if ((capabilities & SmtpCapabilities.Pipelining) != SmtpCapabilities.None)
		{
			await QueueCommandAsync(SmtpCommand.RcptTo, text, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			return false;
		}
		return ProcessRcptToResponse(message, mailbox, await SendCommandAsync(text, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false));
	}

	private async Task BdatAsync(FormatOptions options, MimeMessage message, long size, bool doAsync, CancellationToken cancellationToken, ITransferProgress progress)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(string.Format(CultureInfo.InvariantCulture, "BDAT {0} LAST\r\n", size));
		if (doAsync)
		{
			await Stream.WriteAsync(bytes, 0, bytes.Length, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		else
		{
			Stream.Write(bytes, 0, bytes.Length, cancellationToken);
		}
		if (progress != null)
		{
			SendContext sendContext = new SendContext(progress, size);
			using ProgressStream stream = new ProgressStream(Stream, sendContext.Update);
			if (doAsync)
			{
				await message.WriteToAsync(options, stream, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				await stream.FlushAsync(cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			}
			else
			{
				message.WriteTo(options, stream, cancellationToken);
				stream.Flush(cancellationToken);
			}
		}
		else if (doAsync)
		{
			await message.WriteToAsync(options, Stream, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			await Stream.FlushAsync(cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		else
		{
			message.WriteTo(options, Stream, cancellationToken);
			Stream.Flush(cancellationToken);
		}
		SmtpResponse smtpResponse = ((!doAsync) ? Stream.ReadResponse(cancellationToken) : (await Stream.ReadResponseAsync(cancellationToken).ConfigureAwait(continueOnCapturedContext: false)));
		switch (smtpResponse.StatusCode)
		{
		default:
			throw new SmtpCommandException(SmtpErrorCode.MessageNotAccepted, smtpResponse.StatusCode, smtpResponse.Response);
		case SmtpStatusCode.AuthenticationRequired:
			throw new ServiceNotAuthenticatedException(smtpResponse.Response);
		case SmtpStatusCode.Ok:
			OnMessageSent(new MessageSentEventArgs(message, smtpResponse.Response));
			break;
		}
	}

	private async Task DataAsync(FormatOptions options, MimeMessage message, long size, bool doAsync, CancellationToken cancellationToken, ITransferProgress progress)
	{
		SmtpResponse smtpResponse = await SendCommandAsync("DATA", doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		if (smtpResponse.StatusCode != SmtpStatusCode.StartMailInput)
		{
			throw new SmtpCommandException(SmtpErrorCode.UnexpectedStatusCode, smtpResponse.StatusCode, smtpResponse.Response);
		}
		if (progress != null)
		{
			SendContext sendContext = new SendContext(progress, size);
			using ProgressStream stream = new ProgressStream(Stream, sendContext.Update);
			using FilteredStream filtered = new FilteredStream(stream);
			filtered.Add(new SmtpDataFilter());
			if (doAsync)
			{
				await message.WriteToAsync(options, filtered, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				await filtered.FlushAsync(cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			}
			else
			{
				message.WriteTo(options, filtered, cancellationToken);
				filtered.Flush(cancellationToken);
			}
		}
		else
		{
			using FilteredStream filtered = new FilteredStream(Stream);
			filtered.Add(new SmtpDataFilter());
			if (doAsync)
			{
				await message.WriteToAsync(options, filtered, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				await filtered.FlushAsync(cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			}
			else
			{
				message.WriteTo(options, filtered, cancellationToken);
				filtered.Flush(cancellationToken);
			}
		}
		if (doAsync)
		{
			await Stream.WriteAsync(EndData, 0, EndData.Length, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			await Stream.FlushAsync(cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			smtpResponse = await Stream.ReadResponseAsync(cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		else
		{
			Stream.Write(EndData, 0, EndData.Length, cancellationToken);
			Stream.Flush(cancellationToken);
			smtpResponse = Stream.ReadResponse(cancellationToken);
		}
		switch (smtpResponse.StatusCode)
		{
		default:
			throw new SmtpCommandException(SmtpErrorCode.MessageNotAccepted, smtpResponse.StatusCode, smtpResponse.Response);
		case SmtpStatusCode.AuthenticationRequired:
			throw new ServiceNotAuthenticatedException(smtpResponse.Response);
		case SmtpStatusCode.Ok:
			OnMessageSent(new MessageSentEventArgs(message, smtpResponse.Response));
			break;
		}
	}

	private async Task ResetAsync(bool doAsync, CancellationToken cancellationToken)
	{
		try
		{
			if ((await SendCommandAsync("RSET", doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).StatusCode != SmtpStatusCode.Ok)
			{
				Disconnect(uri.Host, uri.Port, GetSecureSocketOptions(uri), requested: false);
			}
		}
		catch (SmtpCommandException)
		{
		}
		catch
		{
			Disconnect(uri.Host, uri.Port, GetSecureSocketOptions(uri), requested: false);
		}
	}

	protected virtual void Prepare(FormatOptions options, MimeMessage message, EncodingConstraint constraint, int maxLineLength)
	{
		if (!message.Headers.Contains(HeaderId.DomainKeySignature) && !message.Headers.Contains(HeaderId.DkimSignature) && !message.Headers.Contains(HeaderId.ArcSeal))
		{
			message.Prepare(constraint, maxLineLength);
		}
		else
		{
			options.International = false;
		}
	}

	private static async Task<long> GetSizeAsync(FormatOptions options, MimeMessage message, bool doAsync, CancellationToken cancellationToken)
	{
		using MeasuringStream measure = new MeasuringStream();
		if (doAsync)
		{
			await message.WriteToAsync(options, measure, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		else
		{
			message.WriteTo(options, measure, cancellationToken);
		}
		return measure.Length;
	}

	protected virtual long GetSize(FormatOptions options, MimeMessage message, CancellationToken cancellationToken)
	{
		return GetSizeAsync(options, message, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	protected virtual Task<long> GetSizeAsync(FormatOptions options, MimeMessage message, CancellationToken cancellationToken)
	{
		return GetSizeAsync(options, message, doAsync: true, cancellationToken);
	}

	private async Task SendAsync(FormatOptions options, MimeMessage message, MailboxAddress sender, IList<MailboxAddress> recipients, bool doAsync, CancellationToken cancellationToken, ITransferProgress progress)
	{
		CheckDisposed();
		if (!IsConnected)
		{
			throw new ServiceNotConnectedException("The SmtpClient is not connected.");
		}
		FormatOptions format = options.Clone();
		format.NewLineFormat = NewLineFormat.Dos;
		format.EnsureNewLine = true;
		if (format.International && (Capabilities & SmtpCapabilities.UTF8) == 0)
		{
			format.International = false;
		}
		if (format.International && (Capabilities & SmtpCapabilities.EightBitMime) == 0)
		{
			throw new NotSupportedException("The SMTP server does not support the 8BITMIME extension.");
		}
		EncodingConstraint constraint = (((Capabilities & SmtpCapabilities.BinaryMime) == 0) ? (((Capabilities & SmtpCapabilities.EightBitMime) != SmtpCapabilities.None) ? EncodingConstraint.EightBit : EncodingConstraint.SevenBit) : EncodingConstraint.None);
		Prepare(format, message, constraint, 998);
		ContentTransferEncodingVisitor contentTransferEncodingVisitor = new ContentTransferEncodingVisitor(capabilities);
		contentTransferEncodingVisitor.Visit(message);
		SmtpExtension extensions = contentTransferEncodingVisitor.SmtpExtensions;
		if ((Capabilities & SmtpCapabilities.UTF8) != SmtpCapabilities.None && (format.International || sender.IsInternational || recipients.Any((MailboxAddress x) => x.IsInternational)))
		{
			extensions |= SmtpExtension.UTF8;
		}
		long size = (((Capabilities & (SmtpCapabilities.Size | SmtpCapabilities.Chunking)) == 0 && progress == null) ? (-1) : ((!doAsync) ? GetSize(format, message, cancellationToken) : (await GetSizeAsync(format, message, cancellationToken))));
		try
		{
			await MailFromAsync(format, message, sender, extensions, size, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			int accepted = 0;
			for (int i = 0; i < recipients.Count; i++)
			{
				if (await RcptToAsync(format, message, recipients[i], doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false))
				{
					accepted++;
				}
			}
			if (queued.Count > 0)
			{
				await FlushCommandQueueAsync(message, sender, recipients, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			}
			else if (accepted == 0)
			{
				OnNoRecipientsAccepted(message);
			}
			if ((extensions & SmtpExtension.BinaryMime) == 0 && (!PreferSendAsBinaryData || (Capabilities & SmtpCapabilities.BinaryMime) == 0))
			{
				await DataAsync(format, message, size, doAsync, cancellationToken, progress).ConfigureAwait(continueOnCapturedContext: false);
			}
			else
			{
				await BdatAsync(format, message, size, doAsync, cancellationToken, progress).ConfigureAwait(continueOnCapturedContext: false);
			}
		}
		catch (ServiceNotAuthenticatedException)
		{
			throw;
		}
		catch (SmtpCommandException)
		{
			await ResetAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			throw;
		}
		catch
		{
			Disconnect(uri.Host, uri.Port, GetSecureSocketOptions(uri), requested: false);
			throw;
		}
	}

	public override void Send(FormatOptions options, MimeMessage message, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (message == null)
		{
			throw new ArgumentNullException("message");
		}
		IList<MailboxAddress> messageRecipients = GetMessageRecipients(message);
		MailboxAddress messageSender = GetMessageSender(message);
		if (messageSender == null)
		{
			throw new InvalidOperationException("No sender has been specified.");
		}
		if (messageRecipients.Count == 0)
		{
			throw new InvalidOperationException("No recipients have been specified.");
		}
		SendAsync(options, message, messageSender, messageRecipients, doAsync: false, cancellationToken, progress).GetAwaiter().GetResult();
	}

	public override void Send(FormatOptions options, MimeMessage message, MailboxAddress sender, IEnumerable<MailboxAddress> recipients, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (message == null)
		{
			throw new ArgumentNullException("message");
		}
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (recipients == null)
		{
			throw new ArgumentNullException("recipients");
		}
		HashSet<string> unique = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
		List<MailboxAddress> list = new List<MailboxAddress>();
		AddUnique(list, unique, recipients);
		if (list.Count == 0)
		{
			throw new InvalidOperationException("No recipients have been specified.");
		}
		SendAsync(options, message, sender, list, doAsync: false, cancellationToken, progress).GetAwaiter().GetResult();
	}

	private async Task<InternetAddressList> ExpandAsync(string alias, bool doAsync, CancellationToken cancellationToken)
	{
		if (alias == null)
		{
			throw new ArgumentNullException("alias");
		}
		if (alias.Length == 0)
		{
			throw new ArgumentException("The alias cannot be empty.", "alias");
		}
		if (alias.IndexOfAny(new char[2] { '\r', '\n' }) != -1)
		{
			throw new ArgumentException("The alias cannot contain newline characters.", "alias");
		}
		CheckDisposed();
		if (!IsConnected)
		{
			throw new ServiceNotConnectedException("The SmtpClient is not connected.");
		}
		SmtpResponse smtpResponse = await SendCommandAsync($"EXPN {alias}", doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		if (smtpResponse.StatusCode != SmtpStatusCode.Ok)
		{
			throw new SmtpCommandException(SmtpErrorCode.UnexpectedStatusCode, smtpResponse.StatusCode, smtpResponse.Response);
		}
		string[] array = smtpResponse.Response.Split('\n');
		InternetAddressList internetAddressList = new InternetAddressList();
		for (int i = 0; i < array.Length; i++)
		{
			if (InternetAddress.TryParse(array[i], out var address))
			{
				internetAddressList.Add(address);
			}
		}
		return internetAddressList;
	}

	public InternetAddressList Expand(string alias, CancellationToken cancellationToken = default(CancellationToken))
	{
		return ExpandAsync(alias, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	private async Task<MailboxAddress> VerifyAsync(string address, bool doAsync, CancellationToken cancellationToken)
	{
		if (address == null)
		{
			throw new ArgumentNullException("address");
		}
		if (address.Length == 0)
		{
			throw new ArgumentException("The address cannot be empty.", "address");
		}
		if (address.IndexOfAny(new char[2] { '\r', '\n' }) != -1)
		{
			throw new ArgumentException("The address cannot contain newline characters.", "address");
		}
		CheckDisposed();
		if (!IsConnected)
		{
			throw new ServiceNotConnectedException("The SmtpClient is not connected.");
		}
		SmtpResponse smtpResponse = await SendCommandAsync($"VRFY {address}", doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		if (smtpResponse.StatusCode == SmtpStatusCode.Ok)
		{
			return MailboxAddress.Parse(smtpResponse.Response);
		}
		throw new SmtpCommandException(SmtpErrorCode.UnexpectedStatusCode, smtpResponse.StatusCode, smtpResponse.Response);
	}

	public MailboxAddress Verify(string address, CancellationToken cancellationToken = default(CancellationToken))
	{
		return VerifyAsync(address, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && !disposed)
		{
			disposed = true;
			Disconnect(null, 0, SecureSocketOptions.None, requested: false);
		}
		base.Dispose(disposed);
	}
}
