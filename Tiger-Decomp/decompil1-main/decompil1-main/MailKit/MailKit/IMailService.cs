using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MailKit.Net.Proxy;
using MailKit.Security;

namespace MailKit;

public interface IMailService : IDisposable
{
	object SyncRoot { get; }

	SslProtocols SslProtocols { get; set; }

	X509CertificateCollection ClientCertificates { get; set; }

	bool CheckCertificateRevocation { get; set; }

	RemoteCertificateValidationCallback ServerCertificateValidationCallback { get; set; }

	IPEndPoint LocalEndPoint { get; set; }

	IProxyClient ProxyClient { get; set; }

	HashSet<string> AuthenticationMechanisms { get; }

	bool IsAuthenticated { get; }

	bool IsConnected { get; }

	bool IsSecure { get; }

	bool IsEncrypted { get; }

	bool IsSigned { get; }

	SslProtocols SslProtocol { get; }

	CipherAlgorithmType? SslCipherAlgorithm { get; }

	int? SslCipherStrength { get; }

	HashAlgorithmType? SslHashAlgorithm { get; }

	int? SslHashStrength { get; }

	ExchangeAlgorithmType? SslKeyExchangeAlgorithm { get; }

	int? SslKeyExchangeStrength { get; }

	int Timeout { get; set; }

	event EventHandler<ConnectedEventArgs> Connected;

	event EventHandler<DisconnectedEventArgs> Disconnected;

	event EventHandler<AuthenticatedEventArgs> Authenticated;

	void Connect(string host, int port, bool useSsl, CancellationToken cancellationToken = default(CancellationToken));

	Task ConnectAsync(string host, int port, bool useSsl, CancellationToken cancellationToken = default(CancellationToken));

	void Connect(string host, int port = 0, SecureSocketOptions options = SecureSocketOptions.Auto, CancellationToken cancellationToken = default(CancellationToken));

	Task ConnectAsync(string host, int port = 0, SecureSocketOptions options = SecureSocketOptions.Auto, CancellationToken cancellationToken = default(CancellationToken));

	void Connect(Socket socket, string host, int port = 0, SecureSocketOptions options = SecureSocketOptions.Auto, CancellationToken cancellationToken = default(CancellationToken));

	Task ConnectAsync(Socket socket, string host, int port = 0, SecureSocketOptions options = SecureSocketOptions.Auto, CancellationToken cancellationToken = default(CancellationToken));

	void Connect(Stream stream, string host, int port = 0, SecureSocketOptions options = SecureSocketOptions.Auto, CancellationToken cancellationToken = default(CancellationToken));

	Task ConnectAsync(Stream stream, string host, int port = 0, SecureSocketOptions options = SecureSocketOptions.Auto, CancellationToken cancellationToken = default(CancellationToken));

	void Authenticate(ICredentials credentials, CancellationToken cancellationToken = default(CancellationToken));

	Task AuthenticateAsync(ICredentials credentials, CancellationToken cancellationToken = default(CancellationToken));

	void Authenticate(Encoding encoding, ICredentials credentials, CancellationToken cancellationToken = default(CancellationToken));

	Task AuthenticateAsync(Encoding encoding, ICredentials credentials, CancellationToken cancellationToken = default(CancellationToken));

	void Authenticate(Encoding encoding, string userName, string password, CancellationToken cancellationToken = default(CancellationToken));

	Task AuthenticateAsync(Encoding encoding, string userName, string password, CancellationToken cancellationToken = default(CancellationToken));

	void Authenticate(string userName, string password, CancellationToken cancellationToken = default(CancellationToken));

	Task AuthenticateAsync(string userName, string password, CancellationToken cancellationToken = default(CancellationToken));

	void Authenticate(SaslMechanism mechanism, CancellationToken cancellationToken = default(CancellationToken));

	Task AuthenticateAsync(SaslMechanism mechanism, CancellationToken cancellationToken = default(CancellationToken));

	void Disconnect(bool quit, CancellationToken cancellationToken = default(CancellationToken));

	Task DisconnectAsync(bool quit, CancellationToken cancellationToken = default(CancellationToken));

	void NoOp(CancellationToken cancellationToken = default(CancellationToken));

	Task NoOpAsync(CancellationToken cancellationToken = default(CancellationToken));
}
