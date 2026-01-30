using System;
using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Authentication;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MailKit.Security;
using MimeKit;
using MimeKit.IO;

namespace MailKit.Net.Pop3;

public class Pop3Client : MailSpool, IPop3Client, IMailSpool, IMailService, IDisposable, IEnumerable<MimeMessage>, IEnumerable
{
	[Flags]
	private enum ProbedCapabilities : byte
	{
		None = 0,
		Top = 1,
		UIDL = 2
	}

	private class SaslAuthContext
	{
		private readonly SaslMechanism mechanism;

		private readonly Pop3Client client;

		public string AuthMessage { get; private set; }

		private Pop3Engine Engine => client.engine;

		public SaslAuthContext(Pop3Client client, SaslMechanism mechanism)
		{
			this.mechanism = mechanism;
			this.client = client;
		}

		private async Task OnDataReceived(Pop3Engine pop3, Pop3Command pc, string text, bool doAsync)
		{
			while (pc.Status == Pop3CommandStatus.Continue && !mechanism.IsAuthenticated)
			{
				string text2 = mechanism.Challenge(text);
				byte[] bytes = Encoding.ASCII.GetBytes(text2 + "\r\n");
				string text3;
				if (doAsync)
				{
					await pop3.Stream.WriteAsync(bytes, 0, bytes.Length, pc.CancellationToken).ConfigureAwait(continueOnCapturedContext: false);
					await pop3.Stream.FlushAsync(pc.CancellationToken).ConfigureAwait(continueOnCapturedContext: false);
					text3 = (await pop3.ReadLineAsync(pc.CancellationToken).ConfigureAwait(continueOnCapturedContext: false)).TrimEnd();
				}
				else
				{
					pop3.Stream.Write(bytes, 0, bytes.Length, pc.CancellationToken);
					pop3.Stream.Flush(pc.CancellationToken);
					text3 = pop3.ReadLine(pc.CancellationToken).TrimEnd();
				}
				pc.Status = Pop3Engine.GetCommandStatus(text3, out text);
				pc.StatusText = text;
				if (pc.Status == Pop3CommandStatus.ProtocolError)
				{
					throw new Pop3ProtocolException($"Unexpected response from server: {text3}");
				}
			}
			AuthMessage = text;
		}

		public async Task<Pop3Command> AuthenticateAsync(bool doAsync, CancellationToken cancellationToken)
		{
			Pop3Command pc = Engine.QueueCommand(cancellationToken, OnDataReceived, "AUTH {0}", mechanism.MechanismName);
			AuthMessage = string.Empty;
			client.detector.IsAuthenticating = true;
			try
			{
				int num;
				do
				{
					num = ((!doAsync) ? Engine.Iterate() : (await Engine.IterateAsync().ConfigureAwait(continueOnCapturedContext: false)));
				}
				while (num < pc.Id);
				return pc;
			}
			finally
			{
				client.detector.IsAuthenticating = false;
			}
		}
	}

	private class MessageUidContext
	{
		private readonly Pop3Client client;

		private readonly int seqid;

		private string uid;

		private Pop3Engine Engine => client.engine;

		public MessageUidContext(Pop3Client client, int seqid)
		{
			this.client = client;
			this.seqid = seqid;
		}

		private Task OnDataReceived(Pop3Engine pop3, Pop3Command pc, string text, bool doAsync)
		{
			if (pc.Status != Pop3CommandStatus.Ok)
			{
				return Task.FromResult(result: true);
			}
			string[] array = text.Split(new char[1] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
			if (array.Length < 2)
			{
				pc.Exception = CreatePop3ParseException("Pop3 server returned an incomplete response to the UIDL command.");
				return Task.FromResult(result: true);
			}
			if (!int.TryParse(array[0], NumberStyles.None, CultureInfo.InvariantCulture, out var result) || result != seqid)
			{
				pc.Exception = CreatePop3ParseException("Pop3 server returned an unexpected response to the UIDL command.");
				return Task.FromResult(result: true);
			}
			uid = array[1];
			return Task.FromResult(result: true);
		}

		public async Task<string> GetUidAsync(bool doAsync, CancellationToken cancellationToken)
		{
			Pop3Command pc = Engine.QueueCommand(cancellationToken, OnDataReceived, "UIDL {0}", seqid.ToString(CultureInfo.InvariantCulture));
			int num;
			do
			{
				num = ((!doAsync) ? Engine.Iterate() : (await Engine.IterateAsync().ConfigureAwait(continueOnCapturedContext: false)));
			}
			while (num < pc.Id);
			client.probed |= ProbedCapabilities.UIDL;
			if (pc.Status != Pop3CommandStatus.Ok)
			{
				if (!client.SupportsUids)
				{
					throw new NotSupportedException("The POP3 server does not support the UIDL extension.");
				}
				throw CreatePop3Exception(pc);
			}
			if (pc.Exception != null)
			{
				throw pc.Exception;
			}
			Engine.Capabilities |= Pop3Capabilities.UIDL;
			return uid;
		}
	}

	private class MessageUidsContext
	{
		private readonly Pop3Client client;

		private readonly List<string> uids;

		private Pop3Engine Engine => client.engine;

		public MessageUidsContext(Pop3Client client)
		{
			uids = new List<string>();
			this.client = client;
		}

		private async Task OnDataReceived(Pop3Engine pop3, Pop3Command pc, string text, bool doAsync)
		{
			if (pc.Status != Pop3CommandStatus.Ok)
			{
				return;
			}
			while (true)
			{
				string text2 = ((!doAsync) ? Engine.ReadLine(pc.CancellationToken) : (await Engine.ReadLineAsync(pc.CancellationToken).ConfigureAwait(continueOnCapturedContext: false)));
				if (text2 == ".")
				{
					break;
				}
				if (pc.Exception == null)
				{
					string[] array = text2.Split(new char[1] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
					int result;
					if (array.Length < 2)
					{
						pc.Exception = CreatePop3ParseException("Pop3 server returned an incomplete response to the UIDL command.");
					}
					else if (!int.TryParse(array[0], NumberStyles.None, CultureInfo.InvariantCulture, out result) || result != uids.Count + 1)
					{
						pc.Exception = CreatePop3ParseException("Pop3 server returned an invalid response to the UIDL command.");
					}
					else
					{
						uids.Add(array[1]);
					}
				}
			}
		}

		public async Task<IList<string>> GetUidsAsync(bool doAsync, CancellationToken cancellationToken)
		{
			Pop3Command pc = Engine.QueueCommand(cancellationToken, OnDataReceived, "UIDL");
			int num;
			do
			{
				num = ((!doAsync) ? Engine.Iterate() : (await Engine.IterateAsync().ConfigureAwait(continueOnCapturedContext: false)));
			}
			while (num < pc.Id);
			client.probed |= ProbedCapabilities.UIDL;
			if (pc.Status != Pop3CommandStatus.Ok)
			{
				if (!client.SupportsUids)
				{
					throw new NotSupportedException("The POP3 server does not support the UIDL extension.");
				}
				throw CreatePop3Exception(pc);
			}
			if (pc.Exception != null)
			{
				throw pc.Exception;
			}
			Engine.Capabilities |= Pop3Capabilities.UIDL;
			return uids;
		}
	}

	private class MessageSizeContext
	{
		private readonly Pop3Client client;

		private readonly int seqid;

		private int size;

		private Pop3Engine Engine => client.engine;

		public MessageSizeContext(Pop3Client client, int seqid)
		{
			this.client = client;
			this.seqid = seqid;
		}

		private Task OnDataReceived(Pop3Engine pop3, Pop3Command pc, string text, bool doAsync)
		{
			if (pc.Status != Pop3CommandStatus.Ok)
			{
				return Task.FromResult(result: true);
			}
			string[] array = text.Split(new char[1] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
			if (array.Length < 2)
			{
				pc.Exception = CreatePop3ParseException("Pop3 server returned an incomplete response to the LIST command: {0}", text);
				return Task.FromResult(result: true);
			}
			if (!int.TryParse(array[0], NumberStyles.None, CultureInfo.InvariantCulture, out var result) || result != seqid)
			{
				pc.Exception = CreatePop3ParseException("Pop3 server returned an unexpected sequence-id token to the LIST command: {0}", array[0]);
				return Task.FromResult(result: true);
			}
			if (!int.TryParse(array[1], NumberStyles.None, CultureInfo.InvariantCulture, out size) || size < 0)
			{
				pc.Exception = CreatePop3ParseException("Pop3 server returned an unexpected size token to the LIST command: {0}", array[1]);
				return Task.FromResult(result: true);
			}
			return Task.FromResult(result: true);
		}

		public async Task<int> GetSizeAsync(bool doAsync, CancellationToken cancellationToken)
		{
			Pop3Command pc = Engine.QueueCommand(cancellationToken, OnDataReceived, "LIST {0}", seqid.ToString(CultureInfo.InvariantCulture));
			int num;
			do
			{
				num = ((!doAsync) ? Engine.Iterate() : (await Engine.IterateAsync().ConfigureAwait(continueOnCapturedContext: false)));
			}
			while (num < pc.Id);
			if (pc.Status != Pop3CommandStatus.Ok)
			{
				throw CreatePop3Exception(pc);
			}
			if (pc.Exception != null)
			{
				throw pc.Exception;
			}
			return size;
		}
	}

	private class MessageSizesContext
	{
		private readonly Pop3Client client;

		private readonly List<int> sizes;

		private Pop3Engine Engine => client.engine;

		public MessageSizesContext(Pop3Client client)
		{
			sizes = new List<int>();
			this.client = client;
		}

		private async Task OnDataReceived(Pop3Engine pop3, Pop3Command pc, string text, bool doAsync)
		{
			if (pc.Status != Pop3CommandStatus.Ok)
			{
				return;
			}
			while (true)
			{
				string text2 = ((!doAsync) ? Engine.ReadLine(pc.CancellationToken) : (await Engine.ReadLineAsync(pc.CancellationToken).ConfigureAwait(continueOnCapturedContext: false)));
				if (text2 == ".")
				{
					break;
				}
				if (pc.Exception == null)
				{
					string[] array = text2.Split(new char[1] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
					int result;
					int result2;
					if (array.Length < 2)
					{
						pc.Exception = CreatePop3ParseException("Pop3 server returned an incomplete response to the LIST command: {0}", text2);
					}
					else if (!int.TryParse(array[0], NumberStyles.None, CultureInfo.InvariantCulture, out result) || result != sizes.Count + 1)
					{
						pc.Exception = CreatePop3ParseException("Pop3 server returned an unexpected sequence-id token to the LIST command: {0}", array[0]);
					}
					else if (!int.TryParse(array[1], NumberStyles.None, CultureInfo.InvariantCulture, out result2) || result2 < 0)
					{
						pc.Exception = CreatePop3ParseException("Pop3 server returned an unexpected size token to the LIST command: {0}", array[1]);
					}
					else
					{
						sizes.Add(result2);
					}
				}
			}
		}

		public async Task<IList<int>> GetSizesAsync(bool doAsync, CancellationToken cancellationToken)
		{
			Pop3Command pc = Engine.QueueCommand(cancellationToken, OnDataReceived, "LIST");
			int num;
			do
			{
				num = ((!doAsync) ? Engine.Iterate() : (await Engine.IterateAsync().ConfigureAwait(continueOnCapturedContext: false)));
			}
			while (num < pc.Id);
			if (pc.Status != Pop3CommandStatus.Ok)
			{
				throw CreatePop3Exception(pc);
			}
			if (pc.Exception != null)
			{
				throw pc.Exception;
			}
			return sizes;
		}
	}

	private abstract class DownloadContext<T>
	{
		private readonly ITransferProgress progress;

		private readonly Pop3Client client;

		private T[] downloaded;

		private long nread;

		private int index;

		protected Pop3Engine Engine => client.engine;

		protected DownloadContext(Pop3Client client, ITransferProgress progress)
		{
			this.progress = progress;
			this.client = client;
		}

		protected abstract T Parse(Pop3Stream data, CancellationToken cancellationToken);

		protected abstract Task<T> ParseAsync(Pop3Stream data, CancellationToken cancellationToken);

		protected void Update(int n)
		{
			if (progress != null)
			{
				nread += n;
				progress.Report(nread);
			}
		}

		private async Task OnDataReceived(Pop3Engine pop3, Pop3Command pc, string text, bool doAsync)
		{
			if (pc.Status != Pop3CommandStatus.Ok)
			{
				return;
			}
			try
			{
				pop3.Stream.Mode = Pop3StreamMode.Data;
				T val = ((!doAsync) ? Parse(pop3.Stream, pc.CancellationToken) : (await ParseAsync(pop3.Stream, pc.CancellationToken).ConfigureAwait(continueOnCapturedContext: false)));
				downloaded[index++] = val;
			}
			catch (FormatException innerException)
			{
				pc.Exception = CreatePop3ParseException(innerException, "Failed to parse data.");
				if (doAsync)
				{
					await pop3.Stream.CopyToAsync(Stream.Null, 4096, pc.CancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				}
				else
				{
					pop3.Stream.CopyTo(Stream.Null, 4096);
				}
			}
			finally
			{
				pop3.Stream.Mode = Pop3StreamMode.Line;
			}
		}

		private Pop3Command QueueCommand(int seqid, bool headersOnly, CancellationToken cancellationToken)
		{
			if (headersOnly)
			{
				return Engine.QueueCommand(cancellationToken, OnDataReceived, "TOP {0} 0", seqid.ToString(CultureInfo.InvariantCulture));
			}
			return Engine.QueueCommand(cancellationToken, OnDataReceived, "RETR {0}", seqid.ToString(CultureInfo.InvariantCulture));
		}

		private async Task DownloadItemAsync(int seqid, bool headersOnly, bool doAsync, CancellationToken cancellationToken)
		{
			Pop3Command pc = QueueCommand(seqid, headersOnly, cancellationToken);
			int num;
			do
			{
				num = ((!doAsync) ? Engine.Iterate() : (await Engine.IterateAsync().ConfigureAwait(continueOnCapturedContext: false)));
			}
			while (num < pc.Id);
			if (pc.Status != Pop3CommandStatus.Ok)
			{
				throw CreatePop3Exception(pc);
			}
			if (pc.Exception != null)
			{
				throw pc.Exception;
			}
		}

		public async Task<T> DownloadAsync(int seqid, bool headersOnly, bool doAsync, CancellationToken cancellationToken)
		{
			downloaded = new T[1];
			index = 0;
			await DownloadItemAsync(seqid, headersOnly, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			return downloaded[0];
		}

		public async Task<IList<T>> DownloadAsync(IList<int> seqids, bool headersOnly, bool doAsync, CancellationToken cancellationToken)
		{
			downloaded = new T[seqids.Count];
			index = 0;
			if ((Engine.Capabilities & Pop3Capabilities.Pipelining) == 0)
			{
				for (int i = 0; i < seqids.Count; i++)
				{
					await DownloadItemAsync(seqids[i], headersOnly, doAsync, cancellationToken);
				}
				return downloaded;
			}
			Pop3Command[] commands = new Pop3Command[seqids.Count];
			for (int j = 0; j < seqids.Count; j++)
			{
				commands[j] = QueueCommand(seqids[j], headersOnly, cancellationToken);
			}
			Pop3Command pc = commands[commands.Length - 1];
			int num;
			do
			{
				num = ((!doAsync) ? Engine.Iterate() : (await Engine.IterateAsync().ConfigureAwait(continueOnCapturedContext: false)));
			}
			while (num < pc.Id);
			for (int k = 0; k < commands.Length; k++)
			{
				if (commands[k].Status != Pop3CommandStatus.Ok)
				{
					throw CreatePop3Exception(commands[k]);
				}
				if (commands[k].Exception != null)
				{
					throw commands[k].Exception;
				}
			}
			return downloaded;
		}
	}

	private class DownloadStreamContext : DownloadContext<Stream>
	{
		private const int BufferSize = 4096;

		public DownloadStreamContext(Pop3Client client, ITransferProgress progress = null)
			: base(client, progress)
		{
		}

		protected override Stream Parse(Pop3Stream data, CancellationToken cancellationToken)
		{
			cancellationToken.ThrowIfCancellationRequested();
			byte[] array = ArrayPool<byte>.Shared.Rent(4096);
			try
			{
				MemoryBlockStream memoryBlockStream = new MemoryBlockStream();
				int num;
				while ((num = data.Read(array, 0, 4096, cancellationToken)) > 0)
				{
					memoryBlockStream.Write(array, 0, num);
					Update(num);
				}
				memoryBlockStream.Position = 0L;
				return memoryBlockStream;
			}
			finally
			{
				ArrayPool<byte>.Shared.Return(array);
			}
		}

		protected override async Task<Stream> ParseAsync(Pop3Stream data, CancellationToken cancellationToken)
		{
			cancellationToken.ThrowIfCancellationRequested();
			byte[] buffer = ArrayPool<byte>.Shared.Rent(4096);
			try
			{
				MemoryBlockStream stream = new MemoryBlockStream();
				int num;
				while ((num = await data.ReadAsync(buffer, 0, 4096, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)) > 0)
				{
					stream.Write(buffer, 0, num);
					Update(num);
				}
				stream.Position = 0L;
				return stream;
			}
			finally
			{
				ArrayPool<byte>.Shared.Return(buffer);
			}
		}
	}

	private class DownloadHeaderContext : DownloadContext<HeaderList>
	{
		private readonly MimeParser parser;

		public DownloadHeaderContext(Pop3Client client, MimeParser parser)
			: base(client, (ITransferProgress)null)
		{
			this.parser = parser;
		}

		protected override HeaderList Parse(Pop3Stream data, CancellationToken cancellationToken)
		{
			using ProgressStream stream = new ProgressStream(data, base.Update);
			parser.SetStream(ParserOptions.Default, stream);
			return parser.ParseMessage(cancellationToken).Headers;
		}

		protected override async Task<HeaderList> ParseAsync(Pop3Stream data, CancellationToken cancellationToken)
		{
			using ProgressStream stream = new ProgressStream(data, base.Update);
			parser.SetStream(ParserOptions.Default, stream);
			return (await parser.ParseMessageAsync(cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Headers;
		}
	}

	private class DownloadMessageContext : DownloadContext<MimeMessage>
	{
		private readonly MimeParser parser;

		public DownloadMessageContext(Pop3Client client, MimeParser parser, ITransferProgress progress = null)
			: base(client, progress)
		{
			this.parser = parser;
		}

		protected override MimeMessage Parse(Pop3Stream data, CancellationToken cancellationToken)
		{
			using ProgressStream stream = new ProgressStream(data, base.Update);
			parser.SetStream(ParserOptions.Default, stream);
			return parser.ParseMessage(cancellationToken);
		}

		protected override Task<MimeMessage> ParseAsync(Pop3Stream data, CancellationToken cancellationToken)
		{
			using ProgressStream stream = new ProgressStream(data, base.Update);
			parser.SetStream(ParserOptions.Default, stream);
			return parser.ParseMessageAsync(cancellationToken);
		}
	}

	private readonly Pop3AuthenticationSecretDetector detector = new Pop3AuthenticationSecretDetector();

	private readonly MimeParser parser = new MimeParser(Stream.Null);

	private readonly Pop3Engine engine;

	private ProbedCapabilities probed;

	private bool disposed;

	private bool disconnecting;

	private bool secure;

	private bool utf8;

	private int timeout = 120000;

	private long octets;

	private int total;

	public override object SyncRoot => engine;

	protected override string Protocol => "pop";

	public Pop3Capabilities Capabilities
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

	public int ExpirePolicy => engine.ExpirePolicy;

	public string Implementation => engine.Implementation;

	public int LoginDelay => engine.LoginDelay;

	public override HashSet<string> AuthenticationMechanisms => engine.AuthenticationMechanisms;

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

	public override bool IsAuthenticated => engine.State == Pop3EngineState.Transaction;

	public override int Count
	{
		get
		{
			CheckDisposed();
			CheckConnected();
			CheckAuthenticated();
			return total;
		}
	}

	public override bool SupportsUids
	{
		get
		{
			CheckDisposed();
			CheckConnected();
			CheckAuthenticated();
			return (engine.Capabilities & Pop3Capabilities.UIDL) != 0;
		}
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

	public override async Task<int> GetMessageCountAsync(CancellationToken cancellationToken = default(CancellationToken))
	{
		CheckDisposed();
		CheckConnected();
		CheckAuthenticated();
		await UpdateMessageCountAsync(doAsync: true, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		return Count;
	}

	public override Task NoOpAsync(CancellationToken cancellationToken = default(CancellationToken))
	{
		return NoOpAsync(doAsync: true, cancellationToken);
	}

	public Task EnableUTF8Async(CancellationToken cancellationToken = default(CancellationToken))
	{
		return EnableUTF8Async(doAsync: true, cancellationToken);
	}

	public Task<IList<Pop3Language>> GetLanguagesAsync(CancellationToken cancellationToken = default(CancellationToken))
	{
		return GetLanguagesAsync(doAsync: true, cancellationToken);
	}

	public Task SetLanguageAsync(string lang, CancellationToken cancellationToken = default(CancellationToken))
	{
		return SetLanguageAsync(lang, doAsync: true, cancellationToken);
	}

	public override Task<string> GetMessageUidAsync(int index, CancellationToken cancellationToken = default(CancellationToken))
	{
		return GetMessageUidAsync(index, doAsync: true, cancellationToken);
	}

	public override Task<IList<string>> GetMessageUidsAsync(CancellationToken cancellationToken = default(CancellationToken))
	{
		return GetMessageUidsAsync(doAsync: true, cancellationToken);
	}

	public override Task<int> GetMessageSizeAsync(int index, CancellationToken cancellationToken = default(CancellationToken))
	{
		return GetMessageSizeAsync(index, doAsync: true, cancellationToken);
	}

	public override Task<IList<int>> GetMessageSizesAsync(CancellationToken cancellationToken = default(CancellationToken))
	{
		return GetMessageSizesAsync(doAsync: true, cancellationToken);
	}

	public override Task<HeaderList> GetMessageHeadersAsync(int index, CancellationToken cancellationToken = default(CancellationToken))
	{
		CheckDisposed();
		CheckConnected();
		CheckAuthenticated();
		if (index < 0 || index >= total)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		DownloadHeaderContext downloadHeaderContext = new DownloadHeaderContext(this, parser);
		return downloadHeaderContext.DownloadAsync(index + 1, headersOnly: true, doAsync: true, cancellationToken);
	}

	public override Task<IList<HeaderList>> GetMessageHeadersAsync(IList<int> indexes, CancellationToken cancellationToken = default(CancellationToken))
	{
		CheckDisposed();
		CheckConnected();
		CheckAuthenticated();
		if (indexes == null)
		{
			throw new ArgumentNullException("indexes");
		}
		if (indexes.Count == 0)
		{
			return Task.FromResult((IList<HeaderList>)new HeaderList[0]);
		}
		int[] array = new int[indexes.Count];
		for (int i = 0; i < indexes.Count; i++)
		{
			if (indexes[i] < 0 || indexes[i] >= total)
			{
				throw new ArgumentException("One or more of the indexes are invalid.", "indexes");
			}
			array[i] = indexes[i] + 1;
		}
		DownloadHeaderContext downloadHeaderContext = new DownloadHeaderContext(this, parser);
		return downloadHeaderContext.DownloadAsync(array, headersOnly: true, doAsync: true, cancellationToken);
	}

	public override Task<IList<HeaderList>> GetMessageHeadersAsync(int startIndex, int count, CancellationToken cancellationToken = default(CancellationToken))
	{
		CheckDisposed();
		CheckConnected();
		CheckAuthenticated();
		if (startIndex < 0 || startIndex >= total)
		{
			throw new ArgumentOutOfRangeException("startIndex");
		}
		if (count < 0 || count > total - startIndex)
		{
			throw new ArgumentOutOfRangeException("count");
		}
		if (count == 0)
		{
			return Task.FromResult((IList<HeaderList>)new HeaderList[0]);
		}
		int[] array = new int[count];
		for (int i = 0; i < count; i++)
		{
			array[i] = startIndex + i + 1;
		}
		DownloadHeaderContext downloadHeaderContext = new DownloadHeaderContext(this, parser);
		return downloadHeaderContext.DownloadAsync(array, headersOnly: true, doAsync: true, cancellationToken);
	}

	public override Task<MimeMessage> GetMessageAsync(int index, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		CheckDisposed();
		CheckConnected();
		CheckAuthenticated();
		if (index < 0 || index >= total)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		DownloadMessageContext downloadMessageContext = new DownloadMessageContext(this, parser, progress);
		return downloadMessageContext.DownloadAsync(index + 1, headersOnly: false, doAsync: true, cancellationToken);
	}

	public override Task<IList<MimeMessage>> GetMessagesAsync(IList<int> indexes, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		CheckDisposed();
		CheckConnected();
		CheckAuthenticated();
		if (indexes == null)
		{
			throw new ArgumentNullException("indexes");
		}
		if (indexes.Count == 0)
		{
			return Task.FromResult((IList<MimeMessage>)new MimeMessage[0]);
		}
		int[] array = new int[indexes.Count];
		for (int i = 0; i < indexes.Count; i++)
		{
			if (indexes[i] < 0 || indexes[i] >= total)
			{
				throw new ArgumentException("One or more of the indexes are invalid.", "indexes");
			}
			array[i] = indexes[i] + 1;
		}
		DownloadMessageContext downloadMessageContext = new DownloadMessageContext(this, parser, progress);
		return downloadMessageContext.DownloadAsync(array, headersOnly: false, doAsync: true, cancellationToken);
	}

	public override Task<IList<MimeMessage>> GetMessagesAsync(int startIndex, int count, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		CheckDisposed();
		CheckConnected();
		CheckAuthenticated();
		if (startIndex < 0 || startIndex >= total)
		{
			throw new ArgumentOutOfRangeException("startIndex");
		}
		if (count < 0 || count > total - startIndex)
		{
			throw new ArgumentOutOfRangeException("count");
		}
		if (count == 0)
		{
			return Task.FromResult((IList<MimeMessage>)new MimeMessage[0]);
		}
		int[] array = new int[count];
		for (int i = 0; i < count; i++)
		{
			array[i] = startIndex + i + 1;
		}
		DownloadMessageContext downloadMessageContext = new DownloadMessageContext(this, parser, progress);
		return downloadMessageContext.DownloadAsync(array, headersOnly: false, doAsync: true, cancellationToken);
	}

	public override Task<Stream> GetStreamAsync(int index, bool headersOnly = false, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		CheckDisposed();
		CheckConnected();
		CheckAuthenticated();
		if (index < 0 || index >= total)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		DownloadStreamContext downloadStreamContext = new DownloadStreamContext(this, progress);
		return downloadStreamContext.DownloadAsync(index + 1, headersOnly, doAsync: true, cancellationToken);
	}

	public override Task<IList<Stream>> GetStreamsAsync(IList<int> indexes, bool headersOnly = false, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		CheckDisposed();
		CheckConnected();
		CheckAuthenticated();
		if (indexes == null)
		{
			throw new ArgumentNullException("indexes");
		}
		if (indexes.Count == 0)
		{
			return Task.FromResult((IList<Stream>)new Stream[0]);
		}
		int[] array = new int[indexes.Count];
		for (int i = 0; i < indexes.Count; i++)
		{
			if (indexes[i] < 0 || indexes[i] >= total)
			{
				throw new ArgumentException("One or more of the indexes are invalid.", "indexes");
			}
			array[i] = indexes[i] + 1;
		}
		DownloadStreamContext downloadStreamContext = new DownloadStreamContext(this, progress);
		return downloadStreamContext.DownloadAsync(array, headersOnly, doAsync: true, cancellationToken);
	}

	public override Task<IList<Stream>> GetStreamsAsync(int startIndex, int count, bool headersOnly = false, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		CheckDisposed();
		CheckConnected();
		CheckAuthenticated();
		if (startIndex < 0 || startIndex >= total)
		{
			throw new ArgumentOutOfRangeException("startIndex");
		}
		if (count < 0 || count > total - startIndex)
		{
			throw new ArgumentOutOfRangeException("count");
		}
		if (count == 0)
		{
			return Task.FromResult((IList<Stream>)new Stream[0]);
		}
		int[] array = new int[count];
		for (int i = 0; i < count; i++)
		{
			array[i] = startIndex + i + 1;
		}
		DownloadStreamContext downloadStreamContext = new DownloadStreamContext(this, progress);
		return downloadStreamContext.DownloadAsync(array, headersOnly, doAsync: true, cancellationToken);
	}

	public override Task DeleteMessageAsync(int index, CancellationToken cancellationToken = default(CancellationToken))
	{
		return DeleteMessageAsync(index, doAsync: true, cancellationToken);
	}

	public override Task DeleteMessagesAsync(IList<int> indexes, CancellationToken cancellationToken = default(CancellationToken))
	{
		return DeleteMessagesAsync(indexes, doAsync: true, cancellationToken);
	}

	public override Task DeleteMessagesAsync(int startIndex, int count, CancellationToken cancellationToken = default(CancellationToken))
	{
		return DeleteMessagesAsync(startIndex, count, doAsync: true, cancellationToken);
	}

	public override async Task DeleteAllMessagesAsync(CancellationToken cancellationToken = default(CancellationToken))
	{
		if (total > 0)
		{
			await DeleteMessagesAsync(0, total, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
	}

	public override Task ResetAsync(CancellationToken cancellationToken = default(CancellationToken))
	{
		return ResetAsync(doAsync: true, cancellationToken);
	}

	public Pop3Client(IProtocolLogger protocolLogger)
		: base(protocolLogger)
	{
		protocolLogger.AuthenticationSecretDetector = detector;
		engine = new Pop3Engine();
	}

	public Pop3Client()
		: this(new NullProtocolLogger())
	{
	}

	private void CheckDisposed()
	{
		if (disposed)
		{
			throw new ObjectDisposedException("Pop3Client");
		}
	}

	private void CheckConnected()
	{
		if (!IsConnected)
		{
			throw new ServiceNotConnectedException("The Pop3Client is not connected.");
		}
	}

	private void CheckAuthenticated()
	{
		if (!IsAuthenticated)
		{
			throw new ServiceNotAuthenticatedException("The Pop3Client has not been authenticated.");
		}
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

	private static Exception CreatePop3Exception(Pop3Command pc)
	{
		string arg = pc.Command.Split(' ')[0].TrimEnd();
		string message = $"POP3 server did not respond with a +OK response to the {arg} command.";
		if (pc.Status == Pop3CommandStatus.Error)
		{
			return new Pop3CommandException(message, pc.StatusText);
		}
		return new Pop3ProtocolException(message);
	}

	private static ProtocolException CreatePop3ParseException(Exception innerException, string format, params object[] args)
	{
		return new Pop3ProtocolException(string.Format(CultureInfo.InvariantCulture, format, args), innerException);
	}

	private static ProtocolException CreatePop3ParseException(string format, params object[] args)
	{
		return new Pop3ProtocolException(string.Format(CultureInfo.InvariantCulture, format, args));
	}

	private async Task SendCommandAsync(bool doAsync, CancellationToken token, string command)
	{
		Pop3Command pc = engine.QueueCommand(token, null, Encoding.ASCII, command);
		int num;
		do
		{
			num = ((!doAsync) ? engine.Iterate() : (await engine.IterateAsync().ConfigureAwait(continueOnCapturedContext: false)));
		}
		while (num < pc.Id);
		if (pc.Status != Pop3CommandStatus.Ok)
		{
			throw CreatePop3Exception(pc);
		}
	}

	private Task<string> SendCommandAsync(bool doAsync, CancellationToken token, string format, params object[] args)
	{
		return SendCommandAsync(doAsync, token, Encoding.ASCII, format, args);
	}

	private async Task<string> SendCommandAsync(bool doAsync, CancellationToken token, Encoding encoding, string format, params object[] args)
	{
		string okText = string.Empty;
		Pop3Command pc = engine.QueueCommand(token, delegate(Pop3Engine pop3, Pop3Command cmd, string text, bool xdoAsync)
		{
			if (cmd.Status == Pop3CommandStatus.Ok)
			{
				okText = text;
			}
			return Task.FromResult(result: true);
		}, encoding, format, args);
		int num;
		do
		{
			num = ((!doAsync) ? engine.Iterate() : (await engine.IterateAsync().ConfigureAwait(continueOnCapturedContext: false)));
		}
		while (num < pc.Id);
		if (pc.Status != Pop3CommandStatus.Ok)
		{
			throw CreatePop3Exception(pc);
		}
		return okText;
	}

	private async Task UpdateMessageCountAsync(bool doAsync, CancellationToken cancellationToken)
	{
		Pop3Command pc = engine.QueueCommand(cancellationToken, delegate(Pop3Engine pop3, Pop3Command cmd, string text, bool xdoAsync)
		{
			if (cmd.Status != Pop3CommandStatus.Ok)
			{
				return Task.FromResult(result: false);
			}
			string[] array = text.Split(new char[1] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
			if (array.Length < 2)
			{
				cmd.Exception = CreatePop3ParseException("Pop3 server returned an incomplete response to the STAT command: {0}", text);
				return Task.FromResult(result: false);
			}
			if (!int.TryParse(array[0], NumberStyles.None, CultureInfo.InvariantCulture, out total) || total < 0)
			{
				cmd.Exception = CreatePop3ParseException("Pop3 server returned an invalid response to the STAT command: {0}", text);
				return Task.FromResult(result: false);
			}
			if (!long.TryParse(array[1], NumberStyles.Integer, CultureInfo.InvariantCulture, out octets))
			{
				cmd.Exception = CreatePop3ParseException("Pop3 server returned an invalid response to the STAT command: {0}", text);
				return Task.FromResult(result: false);
			}
			return Task.FromResult(result: true);
		}, "STAT");
		int num;
		do
		{
			num = ((!doAsync) ? engine.Iterate() : (await engine.IterateAsync().ConfigureAwait(continueOnCapturedContext: false)));
		}
		while (num < pc.Id);
		if (pc.Status != Pop3CommandStatus.Ok)
		{
			throw CreatePop3Exception(pc);
		}
		if (pc.Exception != null)
		{
			throw pc.Exception;
		}
	}

	private async Task ProbeCapabilitiesAsync(bool doAsync, CancellationToken cancellationToken)
	{
		if ((engine.Capabilities & Pop3Capabilities.UIDL) == 0 && (probed & ProbedCapabilities.UIDL) == 0 && total > 0)
		{
			try
			{
				MessageUidContext messageUidContext = new MessageUidContext(this, 1);
				await messageUidContext.GetUidAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			}
			catch (NotSupportedException)
			{
			}
		}
	}

	private async Task QueryCapabilitiesAsync(bool doAsync, CancellationToken cancellationToken)
	{
		if (doAsync)
		{
			await engine.QueryCapabilitiesAsync(cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		else
		{
			engine.QueryCapabilities(cancellationToken);
		}
	}

	private async Task AuthenticateAsync(SaslMechanism mechanism, bool doAsync, CancellationToken cancellationToken)
	{
		if (mechanism == null)
		{
			throw new ArgumentNullException("mechanism");
		}
		if (!IsConnected)
		{
			throw new ServiceNotConnectedException("The Pop3Client must be connected before you can authenticate.");
		}
		if (IsAuthenticated)
		{
			throw new InvalidOperationException("The Pop3Client is already authenticated.");
		}
		CheckDisposed();
		cancellationToken.ThrowIfCancellationRequested();
		mechanism.Uri = new Uri("pop://" + engine.Uri.Host);
		SaslAuthContext ctx = new SaslAuthContext(this, mechanism);
		Pop3Command pop3Command = await ctx.AuthenticateAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		if (pop3Command.Status == Pop3CommandStatus.Error)
		{
			throw new MailKit.Security.AuthenticationException();
		}
		if (pop3Command.Status != Pop3CommandStatus.Ok)
		{
			throw CreatePop3Exception(pop3Command);
		}
		if (pop3Command.Exception != null)
		{
			throw pop3Command.Exception;
		}
		engine.State = Pop3EngineState.Transaction;
		await QueryCapabilitiesAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		await UpdateMessageCountAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		await ProbeCapabilitiesAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		OnAuthenticated(ctx.AuthMessage);
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
		if (!IsConnected)
		{
			throw new ServiceNotConnectedException("The Pop3Client must be connected before you can authenticate.");
		}
		if (IsAuthenticated)
		{
			throw new InvalidOperationException("The Pop3Client is already authenticated.");
		}
		CheckDisposed();
		Uri saslUri = new Uri("pop://" + engine.Uri.Host);
		string message = null;
		NetworkCredential credential;
		string text;
		if ((engine.Capabilities & Pop3Capabilities.Apop) != Pop3Capabilities.None)
		{
			credential = credentials.GetCredential(saslUri, "APOP");
			text = (utf8 ? SaslMechanism.SaslPrep(credential.UserName) : credential.UserName);
			string s = string.Concat(str1: utf8 ? SaslMechanism.SaslPrep(credential.Password) : credential.Password, str0: engine.ApopToken);
			StringBuilder stringBuilder = new StringBuilder();
			byte[] array;
			using (MD5 mD = MD5.Create())
			{
				array = mD.ComputeHash(encoding.GetBytes(s));
			}
			for (int i = 0; i < array.Length; i++)
			{
				stringBuilder.Append(array[i].ToString("x2"));
			}
			detector.IsAuthenticating = true;
			try
			{
				message = await SendCommandAsync(doAsync, cancellationToken, encoding, "APOP {0} {1}", text, stringBuilder).ConfigureAwait(continueOnCapturedContext: false);
				engine.State = Pop3EngineState.Transaction;
			}
			catch (Pop3CommandException)
			{
			}
			finally
			{
				detector.IsAuthenticating = false;
			}
			if (engine.State == Pop3EngineState.Transaction)
			{
				await QueryCapabilitiesAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				await UpdateMessageCountAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				await ProbeCapabilitiesAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				OnAuthenticated(message ?? string.Empty);
				return;
			}
		}
		if ((engine.Capabilities & Pop3Capabilities.Sasl) != Pop3Capabilities.None)
		{
			string[] authMechanismRank = SaslMechanism.AuthMechanismRank;
			foreach (string text2 in authMechanismRank)
			{
				SaslMechanism mechanism;
				if (!engine.AuthenticationMechanisms.Contains(text2) || (mechanism = SaslMechanism.Create(text2, saslUri, encoding, credentials)) == null)
				{
					continue;
				}
				cancellationToken.ThrowIfCancellationRequested();
				SaslAuthContext ctx = new SaslAuthContext(this, mechanism);
				Pop3Command pop3Command = await ctx.AuthenticateAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				if (pop3Command.Status != Pop3CommandStatus.Error)
				{
					if (pop3Command.Status != Pop3CommandStatus.Ok)
					{
						throw CreatePop3Exception(pop3Command);
					}
					if (pop3Command.Exception != null)
					{
						throw pop3Command.Exception;
					}
					engine.State = Pop3EngineState.Transaction;
					await QueryCapabilitiesAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
					await UpdateMessageCountAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
					await ProbeCapabilitiesAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
					OnAuthenticated(ctx.AuthMessage);
					return;
				}
			}
		}
		credential = credentials.GetCredential(saslUri, "DEFAULT");
		text = (utf8 ? SaslMechanism.SaslPrep(credential.UserName) : credential.UserName);
		string password = (utf8 ? SaslMechanism.SaslPrep(credential.Password) : credential.Password);
		detector.IsAuthenticating = true;
		try
		{
			await SendCommandAsync(doAsync, cancellationToken, encoding, "USER {0}", text).ConfigureAwait(continueOnCapturedContext: false);
			message = await SendCommandAsync(doAsync, cancellationToken, encoding, "PASS {0}", password).ConfigureAwait(continueOnCapturedContext: false);
		}
		catch (Pop3CommandException)
		{
			throw new MailKit.Security.AuthenticationException();
		}
		finally
		{
			detector.IsAuthenticating = false;
		}
		engine.State = Pop3EngineState.Transaction;
		await QueryCapabilitiesAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		await UpdateMessageCountAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		await ProbeCapabilitiesAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		OnAuthenticated(message);
	}

	public override void Authenticate(Encoding encoding, ICredentials credentials, CancellationToken cancellationToken = default(CancellationToken))
	{
		AuthenticateAsync(encoding, credentials, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	internal void ReplayConnect(string host, Stream replayStream, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (host == null)
		{
			throw new ArgumentNullException("host");
		}
		if (replayStream == null)
		{
			throw new ArgumentNullException("replayStream");
		}
		CheckDisposed();
		probed = ProbedCapabilities.None;
		secure = false;
		engine.Uri = new Uri("pop://" + host + ":110");
		engine.Connect(new Pop3Stream(replayStream, base.ProtocolLogger), cancellationToken);
		engine.QueryCapabilities(cancellationToken);
		engine.Disconnected += OnEngineDisconnected;
		OnConnected(host, 110, SecureSocketOptions.None);
	}

	internal async Task ReplayConnectAsync(string host, Stream replayStream, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (host == null)
		{
			throw new ArgumentNullException("host");
		}
		if (replayStream == null)
		{
			throw new ArgumentNullException("replayStream");
		}
		CheckDisposed();
		probed = ProbedCapabilities.None;
		secure = false;
		engine.Uri = new Uri("pop://" + host + ":110");
		await engine.ConnectAsync(new Pop3Stream(replayStream, base.ProtocolLogger), cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		await engine.QueryCapabilitiesAsync(cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		engine.Disconnected += OnEngineDisconnected;
		OnConnected(host, 110, SecureSocketOptions.None);
	}

	internal static void ComputeDefaultValues(string host, ref int port, ref SecureSocketOptions options, out Uri uri, out bool starttls)
	{
		switch (options)
		{
		default:
			if (port == 0)
			{
				port = 110;
			}
			break;
		case SecureSocketOptions.Auto:
		{
			int num = port;
			if (num != 0)
			{
				if (num == 995)
				{
					options = SecureSocketOptions.SslOnConnect;
					break;
				}
			}
			else
			{
				port = 110;
			}
			options = SecureSocketOptions.StartTlsWhenAvailable;
			break;
		}
		case SecureSocketOptions.SslOnConnect:
			if (port == 0)
			{
				port = 995;
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
			uri = new Uri(string.Format(CultureInfo.InvariantCulture, "pop://{0}:{1}/?starttls=when-available", host, port));
			starttls = true;
			break;
		case SecureSocketOptions.StartTls:
			uri = new Uri(string.Format(CultureInfo.InvariantCulture, "pop://{0}:{1}/?starttls=always", host, port));
			starttls = true;
			break;
		case SecureSocketOptions.SslOnConnect:
			uri = new Uri(string.Format(CultureInfo.InvariantCulture, "pops://{0}:{1}", host, port));
			starttls = false;
			break;
		default:
			uri = new Uri(string.Format(CultureInfo.InvariantCulture, "pop://{0}:{1}", host, port));
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
			throw new InvalidOperationException("The Pop3Client is already connected.");
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
				throw SslHandshakeException.Create(this, ex, false, "POP3", host, port, 995, 110);
			}
			secure = true;
			stream = ssl;
		}
		else
		{
			secure = false;
		}
		probed = ProbedCapabilities.None;
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
		Pop3Stream pop = new Pop3Stream(stream, base.ProtocolLogger);
		if (doAsync)
		{
			await engine.ConnectAsync(pop, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		else
		{
			engine.Connect(pop, cancellationToken);
		}
		try
		{
			await QueryCapabilitiesAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			if (options == SecureSocketOptions.StartTls && (engine.Capabilities & Pop3Capabilities.StartTLS) == 0)
			{
				throw new NotSupportedException("The POP3 server does not support the STLS extension.");
			}
			if (starttls && (engine.Capabilities & Pop3Capabilities.StartTLS) != Pop3Capabilities.None)
			{
				await SendCommandAsync(doAsync, cancellationToken, "STLS").ConfigureAwait(continueOnCapturedContext: false);
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
					throw SslHandshakeException.Create(this, ex2, true, "POP3", host, port, 995, 110);
				}
				secure = true;
				await QueryCapabilitiesAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			}
		}
		catch
		{
			engine.Disconnect();
			secure = false;
			throw;
		}
		engine.Disconnected += OnEngineDisconnected;
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
			throw new InvalidOperationException("The Pop3Client is already connected.");
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
				throw SslHandshakeException.Create(this, ex, false, "POP3", host, port, 995, 110);
			}
			network = ssl;
			secure = true;
		}
		else
		{
			network = stream;
			secure = false;
		}
		probed = ProbedCapabilities.None;
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
		Pop3Stream pop = new Pop3Stream(network, base.ProtocolLogger);
		if (doAsync)
		{
			await engine.ConnectAsync(pop, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		else
		{
			engine.Connect(pop, cancellationToken);
		}
		try
		{
			await QueryCapabilitiesAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			if (options == SecureSocketOptions.StartTls && (engine.Capabilities & Pop3Capabilities.StartTLS) == 0)
			{
				throw new NotSupportedException("The POP3 server does not support the STLS extension.");
			}
			if (starttls && (engine.Capabilities & Pop3Capabilities.StartTLS) != Pop3Capabilities.None)
			{
				await SendCommandAsync(doAsync, cancellationToken, "STLS").ConfigureAwait(continueOnCapturedContext: false);
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
					throw SslHandshakeException.Create(this, ex2, true, "POP3", host, port, 995, 110);
				}
				secure = true;
				await QueryCapabilitiesAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			}
		}
		catch
		{
			engine.Disconnect();
			secure = false;
			throw;
		}
		engine.Disconnected += OnEngineDisconnected;
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
		if (!engine.IsConnected)
		{
			return;
		}
		if (quit)
		{
			try
			{
				await SendCommandAsync(doAsync, cancellationToken, "QUIT").ConfigureAwait(continueOnCapturedContext: false);
			}
			catch (OperationCanceledException)
			{
			}
			catch (Pop3ProtocolException)
			{
			}
			catch (Pop3CommandException)
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

	public override int GetMessageCount(CancellationToken cancellationToken = default(CancellationToken))
	{
		CheckDisposed();
		CheckConnected();
		CheckAuthenticated();
		UpdateMessageCountAsync(doAsync: false, cancellationToken).GetAwaiter().GetResult();
		return Count;
	}

	private Task NoOpAsync(bool doAsync, CancellationToken cancellationToken)
	{
		CheckDisposed();
		CheckConnected();
		CheckAuthenticated();
		return SendCommandAsync(doAsync, cancellationToken, "NOOP");
	}

	public override void NoOp(CancellationToken cancellationToken = default(CancellationToken))
	{
		NoOpAsync(doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	private void OnEngineDisconnected(object sender, EventArgs e)
	{
		SecureSocketOptions options = SecureSocketOptions.None;
		bool requested = disconnecting;
		string text = null;
		int port = 0;
		if (engine.Uri != null)
		{
			options = GetSecureSocketOptions(engine.Uri);
			text = engine.Uri.Host;
			port = engine.Uri.Port;
		}
		engine.Disconnected -= OnEngineDisconnected;
		disconnecting = (secure = (utf8 = false));
		octets = (total = 0);
		engine.Uri = null;
		if (text != null)
		{
			OnDisconnected(text, port, options, requested);
		}
	}

	private async Task EnableUTF8Async(bool doAsync, CancellationToken cancellationToken)
	{
		CheckDisposed();
		CheckConnected();
		if (engine.State != Pop3EngineState.Connected)
		{
			throw new InvalidOperationException("You must enable UTF-8 mode before authenticating.");
		}
		if ((engine.Capabilities & Pop3Capabilities.UTF8) == 0)
		{
			throw new NotSupportedException("The POP3 server does not support the UTF8 extension.");
		}
		if (!utf8)
		{
			await SendCommandAsync(doAsync, cancellationToken, "UTF8").ConfigureAwait(continueOnCapturedContext: false);
			utf8 = true;
		}
	}

	public void EnableUTF8(CancellationToken cancellationToken = default(CancellationToken))
	{
		EnableUTF8Async(doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	private async Task<IList<Pop3Language>> GetLanguagesAsync(bool doAsync, CancellationToken cancellationToken)
	{
		CheckDisposed();
		CheckConnected();
		if ((Capabilities & Pop3Capabilities.Lang) == 0)
		{
			throw new NotSupportedException("The POP3 server does not support the LANG extension.");
		}
		List<Pop3Language> langs = new List<Pop3Language>();
		Pop3Command pc = engine.QueueCommand(cancellationToken, async delegate(Pop3Engine pop3, Pop3Command cmd, string text, bool xdoAsync)
		{
			if (cmd.Status == Pop3CommandStatus.Ok)
			{
				while (true)
				{
					string text2 = ((!xdoAsync) ? engine.ReadLine(cmd.CancellationToken) : (await engine.ReadLineAsync(cmd.CancellationToken).ConfigureAwait(continueOnCapturedContext: false)));
					if (text2 == ".")
					{
						break;
					}
					string[] array = text2.Split(new char[1] { ' ' }, 2);
					if (array.Length == 2)
					{
						langs.Add(new Pop3Language(array[0], array[1]));
					}
				}
			}
		}, "LANG");
		int num;
		do
		{
			num = ((!doAsync) ? engine.Iterate() : (await engine.IterateAsync().ConfigureAwait(continueOnCapturedContext: false)));
		}
		while (num < pc.Id);
		if (pc.Status != Pop3CommandStatus.Ok)
		{
			throw CreatePop3Exception(pc);
		}
		if (pc.Exception != null)
		{
			throw pc.Exception;
		}
		return new ReadOnlyCollection<Pop3Language>(langs);
	}

	public IList<Pop3Language> GetLanguages(CancellationToken cancellationToken = default(CancellationToken))
	{
		return GetLanguagesAsync(doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	private Task SetLanguageAsync(string lang, bool doAsync, CancellationToken cancellationToken)
	{
		CheckDisposed();
		CheckConnected();
		if (lang == null)
		{
			throw new ArgumentNullException("lang");
		}
		if (lang.Length == 0)
		{
			throw new ArgumentException("The language code cannot be empty.", "lang");
		}
		if ((Capabilities & Pop3Capabilities.Lang) == 0)
		{
			throw new NotSupportedException("The POP3 server does not support the LANG extension.");
		}
		return SendCommandAsync(doAsync, cancellationToken, "LANG {0}", lang);
	}

	public void SetLanguage(string lang, CancellationToken cancellationToken = default(CancellationToken))
	{
		SetLanguageAsync(lang, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	private Task<string> GetMessageUidAsync(int index, bool doAsync, CancellationToken cancellationToken)
	{
		CheckDisposed();
		CheckConnected();
		CheckAuthenticated();
		if (index < 0 || index >= total)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		if (!SupportsUids && (probed & ProbedCapabilities.UIDL) != ProbedCapabilities.None)
		{
			throw new NotSupportedException("The POP3 server does not support the UIDL extension.");
		}
		MessageUidContext messageUidContext = new MessageUidContext(this, index + 1);
		return messageUidContext.GetUidAsync(doAsync, cancellationToken);
	}

	public override string GetMessageUid(int index, CancellationToken cancellationToken = default(CancellationToken))
	{
		return GetMessageUidAsync(index, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	private Task<IList<string>> GetMessageUidsAsync(bool doAsync, CancellationToken cancellationToken)
	{
		CheckDisposed();
		CheckConnected();
		CheckAuthenticated();
		if (!SupportsUids && (probed & ProbedCapabilities.UIDL) != ProbedCapabilities.None)
		{
			throw new NotSupportedException("The POP3 server does not support the UIDL extension.");
		}
		MessageUidsContext messageUidsContext = new MessageUidsContext(this);
		return messageUidsContext.GetUidsAsync(doAsync, cancellationToken);
	}

	public override IList<string> GetMessageUids(CancellationToken cancellationToken = default(CancellationToken))
	{
		return GetMessageUidsAsync(doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	private Task<int> GetMessageSizeAsync(int index, bool doAsync, CancellationToken cancellationToken)
	{
		CheckDisposed();
		CheckConnected();
		CheckAuthenticated();
		if (index < 0 || index >= total)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		MessageSizeContext messageSizeContext = new MessageSizeContext(this, index + 1);
		return messageSizeContext.GetSizeAsync(doAsync, cancellationToken);
	}

	public override int GetMessageSize(int index, CancellationToken cancellationToken = default(CancellationToken))
	{
		return GetMessageSizeAsync(index, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	private Task<IList<int>> GetMessageSizesAsync(bool doAsync, CancellationToken cancellationToken)
	{
		CheckDisposed();
		CheckConnected();
		CheckAuthenticated();
		MessageSizesContext messageSizesContext = new MessageSizesContext(this);
		return messageSizesContext.GetSizesAsync(doAsync, cancellationToken);
	}

	public override IList<int> GetMessageSizes(CancellationToken cancellationToken = default(CancellationToken))
	{
		return GetMessageSizesAsync(doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override HeaderList GetMessageHeaders(int index, CancellationToken cancellationToken = default(CancellationToken))
	{
		CheckDisposed();
		CheckConnected();
		CheckAuthenticated();
		if (index < 0 || index >= total)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		DownloadHeaderContext downloadHeaderContext = new DownloadHeaderContext(this, parser);
		return downloadHeaderContext.DownloadAsync(index + 1, headersOnly: true, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override IList<HeaderList> GetMessageHeaders(IList<int> indexes, CancellationToken cancellationToken = default(CancellationToken))
	{
		CheckDisposed();
		CheckConnected();
		CheckAuthenticated();
		if (indexes == null)
		{
			throw new ArgumentNullException("indexes");
		}
		if (indexes.Count == 0)
		{
			return new HeaderList[0];
		}
		int[] array = new int[indexes.Count];
		for (int i = 0; i < indexes.Count; i++)
		{
			if (indexes[i] < 0 || indexes[i] >= total)
			{
				throw new ArgumentException("One or more of the indexes are invalid.", "indexes");
			}
			array[i] = indexes[i] + 1;
		}
		DownloadHeaderContext downloadHeaderContext = new DownloadHeaderContext(this, parser);
		return downloadHeaderContext.DownloadAsync(array, headersOnly: true, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override IList<HeaderList> GetMessageHeaders(int startIndex, int count, CancellationToken cancellationToken = default(CancellationToken))
	{
		CheckDisposed();
		CheckConnected();
		CheckAuthenticated();
		if (startIndex < 0 || startIndex >= total)
		{
			throw new ArgumentOutOfRangeException("startIndex");
		}
		if (count < 0 || count > total - startIndex)
		{
			throw new ArgumentOutOfRangeException("count");
		}
		if (count == 0)
		{
			return new HeaderList[0];
		}
		int[] array = new int[count];
		for (int i = 0; i < count; i++)
		{
			array[i] = startIndex + i + 1;
		}
		DownloadHeaderContext downloadHeaderContext = new DownloadHeaderContext(this, parser);
		return downloadHeaderContext.DownloadAsync(array, headersOnly: true, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override MimeMessage GetMessage(int index, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		CheckDisposed();
		CheckConnected();
		CheckAuthenticated();
		if (index < 0 || index >= total)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		DownloadMessageContext downloadMessageContext = new DownloadMessageContext(this, parser, progress);
		return downloadMessageContext.DownloadAsync(index + 1, headersOnly: false, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override IList<MimeMessage> GetMessages(IList<int> indexes, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		CheckDisposed();
		CheckConnected();
		CheckAuthenticated();
		if (indexes == null)
		{
			throw new ArgumentNullException("indexes");
		}
		if (indexes.Count == 0)
		{
			return new MimeMessage[0];
		}
		int[] array = new int[indexes.Count];
		for (int i = 0; i < indexes.Count; i++)
		{
			if (indexes[i] < 0 || indexes[i] >= total)
			{
				throw new ArgumentException("One or more of the indexes are invalid.", "indexes");
			}
			array[i] = indexes[i] + 1;
		}
		DownloadMessageContext downloadMessageContext = new DownloadMessageContext(this, parser, progress);
		return downloadMessageContext.DownloadAsync(array, headersOnly: false, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override IList<MimeMessage> GetMessages(int startIndex, int count, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		CheckDisposed();
		CheckConnected();
		CheckAuthenticated();
		if (startIndex < 0 || startIndex >= total)
		{
			throw new ArgumentOutOfRangeException("startIndex");
		}
		if (count < 0 || count > total - startIndex)
		{
			throw new ArgumentOutOfRangeException("count");
		}
		if (count == 0)
		{
			return new MimeMessage[0];
		}
		int[] array = new int[count];
		for (int i = 0; i < count; i++)
		{
			array[i] = startIndex + i + 1;
		}
		DownloadMessageContext downloadMessageContext = new DownloadMessageContext(this, parser, progress);
		return downloadMessageContext.DownloadAsync(array, headersOnly: false, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override Stream GetStream(int index, bool headersOnly = false, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		CheckDisposed();
		CheckConnected();
		CheckAuthenticated();
		if (index < 0 || index >= total)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		DownloadStreamContext downloadStreamContext = new DownloadStreamContext(this, progress);
		return downloadStreamContext.DownloadAsync(index + 1, headersOnly, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override IList<Stream> GetStreams(IList<int> indexes, bool headersOnly = false, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		CheckDisposed();
		CheckConnected();
		CheckAuthenticated();
		if (indexes == null)
		{
			throw new ArgumentNullException("indexes");
		}
		if (indexes.Count == 0)
		{
			return new Stream[0];
		}
		int[] array = new int[indexes.Count];
		for (int i = 0; i < indexes.Count; i++)
		{
			if (indexes[i] < 0 || indexes[i] >= total)
			{
				throw new ArgumentException("One or more of the indexes are invalid.", "indexes");
			}
			array[i] = indexes[i] + 1;
		}
		DownloadStreamContext downloadStreamContext = new DownloadStreamContext(this, progress);
		return downloadStreamContext.DownloadAsync(array, headersOnly, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override IList<Stream> GetStreams(int startIndex, int count, bool headersOnly = false, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		CheckDisposed();
		CheckConnected();
		CheckAuthenticated();
		if (startIndex < 0 || startIndex >= total)
		{
			throw new ArgumentOutOfRangeException("startIndex");
		}
		if (count < 0 || count > total - startIndex)
		{
			throw new ArgumentOutOfRangeException("count");
		}
		if (count == 0)
		{
			return new Stream[0];
		}
		int[] array = new int[count];
		for (int i = 0; i < count; i++)
		{
			array[i] = startIndex + i + 1;
		}
		DownloadStreamContext downloadStreamContext = new DownloadStreamContext(this, progress);
		return downloadStreamContext.DownloadAsync(array, headersOnly, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	private Task DeleteMessageAsync(int index, bool doAsync, CancellationToken cancellationToken)
	{
		CheckDisposed();
		CheckConnected();
		CheckAuthenticated();
		if (index < 0 || index >= total)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		string text = (index + 1).ToString(CultureInfo.InvariantCulture);
		return SendCommandAsync(doAsync, cancellationToken, "DELE {0}", text);
	}

	public override void DeleteMessage(int index, CancellationToken cancellationToken = default(CancellationToken))
	{
		DeleteMessageAsync(index, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	private async Task DeleteMessagesAsync(IList<int> indexes, bool doAsync, CancellationToken cancellationToken = default(CancellationToken))
	{
		CheckDisposed();
		CheckConnected();
		CheckAuthenticated();
		if (indexes == null)
		{
			throw new ArgumentNullException("indexes");
		}
		if (indexes.Count == 0)
		{
			return;
		}
		string[] seqids = new string[indexes.Count];
		for (int i = 0; i < indexes.Count; i++)
		{
			if (indexes[i] < 0 || indexes[i] >= total)
			{
				throw new ArgumentException("One or more of the indexes are invalid.", "indexes");
			}
			seqids[i] = (indexes[i] + 1).ToString(CultureInfo.InvariantCulture);
		}
		if ((Capabilities & Pop3Capabilities.Pipelining) == 0)
		{
			for (int j = 0; j < seqids.Length; j++)
			{
				await SendCommandAsync(doAsync, cancellationToken, "DELE {0}", seqids[j]).ConfigureAwait(continueOnCapturedContext: false);
			}
			return;
		}
		Pop3Command[] commands = new Pop3Command[seqids.Length];
		Pop3Command pc = null;
		for (int k = 0; k < seqids.Length; k++)
		{
			pc = (commands[k] = engine.QueueCommand(cancellationToken, null, "DELE {0}", seqids[k]));
		}
		int num;
		do
		{
			num = ((!doAsync) ? engine.Iterate() : (await engine.IterateAsync().ConfigureAwait(continueOnCapturedContext: false)));
		}
		while (num < pc.Id);
		for (int l = 0; l < commands.Length; l++)
		{
			if (commands[l].Status != Pop3CommandStatus.Ok)
			{
				throw CreatePop3Exception(commands[l]);
			}
		}
	}

	public override void DeleteMessages(IList<int> indexes, CancellationToken cancellationToken = default(CancellationToken))
	{
		DeleteMessagesAsync(indexes, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	private async Task DeleteMessagesAsync(int startIndex, int count, bool doAsync, CancellationToken cancellationToken = default(CancellationToken))
	{
		CheckDisposed();
		CheckConnected();
		CheckAuthenticated();
		if (startIndex < 0 || startIndex >= total)
		{
			throw new ArgumentOutOfRangeException("startIndex");
		}
		if (count < 0 || count > total - startIndex)
		{
			throw new ArgumentOutOfRangeException("count");
		}
		if (count == 0)
		{
			return;
		}
		if ((Capabilities & Pop3Capabilities.Pipelining) == 0)
		{
			for (int i = 0; i < count; i++)
			{
				string text = (startIndex + i + 1).ToString(CultureInfo.InvariantCulture);
				await SendCommandAsync(doAsync, cancellationToken, "DELE {0}", text).ConfigureAwait(continueOnCapturedContext: false);
			}
			return;
		}
		Pop3Command[] commands = new Pop3Command[count];
		Pop3Command pc = null;
		for (int j = 0; j < count; j++)
		{
			string text2 = (startIndex + j + 1).ToString(CultureInfo.InvariantCulture);
			pc = (commands[j] = engine.QueueCommand(cancellationToken, null, "DELE {0}", text2));
		}
		int num;
		do
		{
			num = ((!doAsync) ? engine.Iterate() : (await engine.IterateAsync().ConfigureAwait(continueOnCapturedContext: false)));
		}
		while (num < pc.Id);
		for (int k = 0; k < commands.Length; k++)
		{
			if (commands[k].Status != Pop3CommandStatus.Ok)
			{
				throw CreatePop3Exception(commands[k]);
			}
		}
	}

	public override void DeleteMessages(int startIndex, int count, CancellationToken cancellationToken = default(CancellationToken))
	{
		DeleteMessagesAsync(startIndex, count, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override void DeleteAllMessages(CancellationToken cancellationToken = default(CancellationToken))
	{
		if (total > 0)
		{
			DeleteMessages(0, total, cancellationToken);
		}
	}

	private Task ResetAsync(bool doAsync, CancellationToken cancellationToken)
	{
		CheckDisposed();
		CheckConnected();
		CheckAuthenticated();
		return SendCommandAsync(doAsync, cancellationToken, "RSET");
	}

	public override void Reset(CancellationToken cancellationToken = default(CancellationToken))
	{
		ResetAsync(doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override IEnumerator<MimeMessage> GetEnumerator()
	{
		CheckDisposed();
		CheckConnected();
		CheckAuthenticated();
		for (int i = 0; i < total; i++)
		{
			yield return GetMessage(i, CancellationToken.None);
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && !disposed)
		{
			engine.Disconnect();
			disposed = true;
		}
		base.Dispose(disposing);
	}
}
