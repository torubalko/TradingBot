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
using MailKit.Net;
using MailKit.Net.Proxy;
using MailKit.Security;

namespace MailKit;

public abstract class MailService : IMailService, IDisposable
{
	private const SslProtocols DefaultSslProtocols = SslProtocols.Tls12 | SslProtocols.Tls13;

	private const string AppleCertificateIssuer = "C=US, S=California, O=Apple Inc., CN=Apple Public Server RSA CA 12 - G1";

	private const string GMailCertificateIssuer = "CN=GTS CA 1O1, O=Google Trust Services, C=US";

	private const string GMailCertificateIssuer2 = "CN=GTS CA 1C3, O=Google Trust Services LLC, C=US";

	private const string OutlookCertificateIssuer = "CN=DigiCert Cloud Services CA-1, O=DigiCert Inc, C=US";

	private const string YahooCertificateIssuer = "CN=DigiCert SHA2 High Assurance Server CA, OU=www.digicert.com, O=DigiCert Inc, C=US";

	private const string GmxDotComCertificateIssuer = "CN=GeoTrust RSA CA 2018, OU=www.digicert.com, O=DigiCert Inc, C=US";

	private const string GmxDotNetCertificateIssuer = "CN=TeleSec ServerPass Extended Validation Class 3 CA, STREET=Untere Industriestr. 20, L=Netphen, PostalCode=57250, S=Nordrhein Westfalen, OU=T-Systems Trust Center, O=T-Systems International GmbH, C=DE";

	internal SslCertificateValidationInfo SslCertificateValidationInfo;

	public abstract object SyncRoot { get; }

	protected abstract string Protocol { get; }

	public IProtocolLogger ProtocolLogger { get; private set; }

	public SslProtocols SslProtocols { get; set; }

	public X509CertificateCollection ClientCertificates { get; set; }

	public bool CheckCertificateRevocation { get; set; }

	public RemoteCertificateValidationCallback ServerCertificateValidationCallback { get; set; }

	public IPEndPoint LocalEndPoint { get; set; }

	public IProxyClient ProxyClient { get; set; }

	public abstract HashSet<string> AuthenticationMechanisms { get; }

	public abstract bool IsConnected { get; }

	public abstract bool IsSecure { get; }

	public abstract bool IsEncrypted { get; }

	public abstract bool IsSigned { get; }

	public abstract SslProtocols SslProtocol { get; }

	public abstract CipherAlgorithmType? SslCipherAlgorithm { get; }

	public abstract int? SslCipherStrength { get; }

	public abstract HashAlgorithmType? SslHashAlgorithm { get; }

	public abstract int? SslHashStrength { get; }

	public abstract ExchangeAlgorithmType? SslKeyExchangeAlgorithm { get; }

	public abstract int? SslKeyExchangeStrength { get; }

	public abstract bool IsAuthenticated { get; }

	public abstract int Timeout { get; set; }

	public event EventHandler<ConnectedEventArgs> Connected;

	public event EventHandler<DisconnectedEventArgs> Disconnected;

	public event EventHandler<AuthenticatedEventArgs> Authenticated;

	protected MailService(IProtocolLogger protocolLogger)
	{
		if (protocolLogger == null)
		{
			throw new ArgumentNullException("protocolLogger");
		}
		SslProtocols = SslProtocols.Tls12 | SslProtocols.Tls13;
		CheckCertificateRevocation = true;
		ProtocolLogger = protocolLogger;
	}

	protected MailService()
		: this(new NullProtocolLogger())
	{
	}

	~MailService()
	{
		Dispose(disposing: false);
	}

	internal static bool IsKnownMailServerCertificate(X509Certificate2 certificate)
	{
		string nameInfo = certificate.GetNameInfo(X509NameType.SimpleName, forIssuer: false);
		string thumbprint = certificate.Thumbprint;
		string serialNumber = certificate.SerialNumber;
		string issuer = certificate.Issuer;
		switch (nameInfo)
		{
		case "imap.gmail.com":
			if (issuer == "CN=GTS CA 1C3, O=Google Trust Services LLC, C=US")
			{
				if ((!(serialNumber == "00F2252BCEAD7C61830A00000000DC9A6F") || !(thumbprint == "671251A2594CB8A6E7AEC2CAD04C76A68755C592")) && (!(serialNumber == "00B66B3B6D37B3F5B60A00000000E05AF6") || !(thumbprint == "E7D9D439E4E40C078EFF84ED0A28B9B11C3570BC")) && (!(serialNumber == "00ED027E1C0FD7ACC60A00000000EB5848") || !(thumbprint == "714CE048CCB0352B166D5AE9B2F2279F7481442A")))
				{
					if (serialNumber == "33FF71640CD98A320A00000000F2C2B6")
					{
						return thumbprint == "76A80201E949827892DB74E4465EC4049CECE204";
					}
					return false;
				}
				return true;
			}
			return false;
		case "pop.gmail.com":
			if (!(issuer == "CN=GTS CA 1O1, O=Google Trust Services, C=US"))
			{
				if (issuer == "CN=GTS CA 1C3, O=Google Trust Services LLC, C=US")
				{
					if (!(serialNumber == "00D62A5751A788CE760A00000000EB585F") || !(thumbprint == "D501E373FE5EDC142611FB1A5C67AD5D562E81FF"))
					{
						if (serialNumber == "67782B7E5C429E710A00000000F2C2B8")
						{
							return thumbprint == "D40C001E88244BF11BC16984B06DD82B15F45896";
						}
						return false;
					}
					return true;
				}
				return false;
			}
			if (!(serialNumber == "00BA079BFB006A1E740300000000CC341B") || !(thumbprint == "B72F6D8385D8D2F3FC9EBEC3B587DD647678ABD8"))
			{
				if (serialNumber == "00BB5405B5EECFE18C050000000087EA40")
				{
					return thumbprint == "6E55F749282332F81AF3292D9EAC6FE329503C51";
				}
				return false;
			}
			return true;
		case "smtp.gmail.com":
			if (!(issuer == "CN=GTS CA 1O1, O=Google Trust Services, C=US"))
			{
				if (issuer == "CN=GTS CA 1C3, O=Google Trust Services LLC, C=US")
				{
					if (!(serialNumber == "00963FC0FB759465C70A00000000EB5901") || !(thumbprint == "8674A3D46170AF29F77F2BBF7865AB085B10866A"))
					{
						if (serialNumber == "1146A5973D10C2700A00000000F2C2CE")
						{
							return thumbprint == "14C1D4AC4A04A288A30D854F1F4100AD6852A11B";
						}
						return false;
					}
					return true;
				}
				return false;
			}
			if (!(serialNumber == "00C662770E90C81534050000000087E452") || !(thumbprint == "77678E4D2923F6A7FEE300FC083D1FA52DFCC07C"))
			{
				if (serialNumber == "627FD20711D64376050000000087EA44")
				{
					return thumbprint == "8F81D50252CB00658FD397497066240FC625F3C1";
				}
				return false;
			}
			return true;
		case "outlook.com":
			if (issuer == "CN=DigiCert Cloud Services CA-1, O=DigiCert Inc, C=US" && serialNumber == "0CCAC32B0EF281026392B8852AB15642")
			{
				return thumbprint == "CBAA1582F1E49AD1D108193B5D38B966BE4993C6";
			}
			return false;
		case "imap.mail.me.com":
			if (issuer == "C=US, S=California, O=Apple Inc., CN=Apple Public Server RSA CA 12 - G1" && serialNumber == "7693E9D2C3B5564F4F9A487D15A54116")
			{
				return thumbprint == "FACBDEB692021F6404BE8B88A563767B282F98EE";
			}
			return false;
		case "smtp.mail.me.com":
			if (issuer == "C=US, S=California, O=Apple Inc., CN=Apple Public Server RSA CA 12 - G1" && serialNumber == "0A3048DECAB5CAA796E163E011CAE82E")
			{
				return thumbprint == "B14CE4D4FF15FBC3C16C4848F1C632552184BD79";
			}
			return false;
		case "*.imap.mail.yahoo.com":
			if (issuer == "CN=DigiCert SHA2 High Assurance Server CA, OU=www.digicert.com, O=DigiCert Inc, C=US" && serialNumber == "090883C7E8D9B60E60ABA19D508BD988")
			{
				return thumbprint == "4018766D324ED3CC37A05D5997405E5B33A7CAEF";
			}
			return false;
		case "legacy.pop.mail.yahoo.com":
			if (issuer == "CN=DigiCert SHA2 High Assurance Server CA, OU=www.digicert.com, O=DigiCert Inc, C=US")
			{
				if (!(serialNumber == "0CFADAA16F51AA5B67DCD15DCE388CF0") || !(thumbprint == "443D3B8F6F9A2439D0F3B9B2A2F90BBA70D8677F"))
				{
					if (serialNumber == "09CC4977A4C14D4388D90CF6676385FE")
					{
						return thumbprint == "7BA05AF724299FF0688842ADEF2837DE25F3C4FD";
					}
					return false;
				}
				return true;
			}
			return false;
		case "smtp.mail.yahoo.com":
			if (issuer == "CN=DigiCert SHA2 High Assurance Server CA, OU=www.digicert.com, O=DigiCert Inc, C=US" && serialNumber == "0CFADAA16F51AA5B67DCD15DCE388CF0")
			{
				return thumbprint == "443D3B8F6F9A2439D0F3B9B2A2F90BBA70D8677F";
			}
			return false;
		case "mout.gmx.com":
			if (issuer == "CN=GeoTrust RSA CA 2018, OU=www.digicert.com, O=DigiCert Inc, C=US" && serialNumber == "06206F2270494CD7AD11F2B17E286C2C")
			{
				return thumbprint == "A7D3BCC363B307EC3BDE21269A2F05117D6614A8";
			}
			return false;
		case "mail.gmx.com":
			if (issuer == "CN=GeoTrust RSA CA 2018, OU=www.digicert.com, O=DigiCert Inc, C=US" && serialNumber == "0719A4D33A18B550133DDA3253AF6C96")
			{
				return thumbprint == "948B0C3FA22BC12C91EEE5B1631A6C41B4A01B9C";
			}
			return false;
		case "mail.gmx.net":
			if (issuer == "CN=TeleSec ServerPass Extended Validation Class 3 CA, STREET=Untere Industriestr. 20, L=Netphen, PostalCode=57250, S=Nordrhein Westfalen, OU=T-Systems Trust Center, O=T-Systems International GmbH, C=DE" && serialNumber == "070E7CD59BB7AFD73E8A206219C4F011")
			{
				return thumbprint == "E66DC8FE17C9A7718D17441CBE347D1D6F7BF3D2";
			}
			return false;
		default:
			return false;
		}
	}

	private static bool IsUntrustedRoot(X509Chain chain)
	{
		X509ChainStatus[] chainStatus = chain.ChainStatus;
		for (int i = 0; i < chainStatus.Length; i++)
		{
			X509ChainStatus x509ChainStatus = chainStatus[i];
			if (x509ChainStatus.Status != X509ChainStatusFlags.NoError && x509ChainStatus.Status != X509ChainStatusFlags.UntrustedRoot)
			{
				return false;
			}
		}
		return true;
	}

	protected bool DefaultServerCertificateValidationCallback(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
	{
		SslCertificateValidationInfo?.Dispose();
		SslCertificateValidationInfo = null;
		if (sslPolicyErrors == SslPolicyErrors.None)
		{
			return true;
		}
		if ((sslPolicyErrors & (SslPolicyErrors.RemoteCertificateNotAvailable | SslPolicyErrors.RemoteCertificateNameMismatch)) == 0 && IsUntrustedRoot(chain) && certificate is X509Certificate2 certificate2 && IsKnownMailServerCertificate(certificate2))
		{
			return true;
		}
		SslCertificateValidationInfo = new SslCertificateValidationInfo(sender, certificate, chain, sslPolicyErrors);
		return false;
	}

	internal async Task<Socket> ConnectSocket(string host, int port, bool doAsync, CancellationToken cancellationToken)
	{
		if (ProxyClient != null)
		{
			ProxyClient.LocalEndPoint = LocalEndPoint;
			if (doAsync)
			{
				return await ProxyClient.ConnectAsync(host, port, Timeout, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			}
			return ProxyClient.Connect(host, port, Timeout, cancellationToken);
		}
		return await SocketUtils.ConnectAsync(host, port, LocalEndPoint, Timeout, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
	}

	public abstract void Connect(string host, int port = 0, SecureSocketOptions options = SecureSocketOptions.Auto, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task ConnectAsync(string host, int port = 0, SecureSocketOptions options = SecureSocketOptions.Auto, CancellationToken cancellationToken = default(CancellationToken));

	public abstract void Connect(Socket socket, string host, int port = 0, SecureSocketOptions options = SecureSocketOptions.Auto, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task ConnectAsync(Socket socket, string host, int port = 0, SecureSocketOptions options = SecureSocketOptions.Auto, CancellationToken cancellationToken = default(CancellationToken));

	public abstract void Connect(Stream stream, string host, int port = 0, SecureSocketOptions options = SecureSocketOptions.Auto, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task ConnectAsync(Stream stream, string host, int port = 0, SecureSocketOptions options = SecureSocketOptions.Auto, CancellationToken cancellationToken = default(CancellationToken));

	internal SecureSocketOptions GetSecureSocketOptions(Uri uri)
	{
		IDictionary<string, string> dictionary = uri.ParsedQuery();
		string text = uri.Scheme;
		if (text.Equals("pop3s", StringComparison.OrdinalIgnoreCase))
		{
			text = "pops";
		}
		else if (text.Equals("pop3", StringComparison.OrdinalIgnoreCase))
		{
			text = "pop";
		}
		if (text.Equals(Protocol + "s", StringComparison.OrdinalIgnoreCase))
		{
			return SecureSocketOptions.SslOnConnect;
		}
		if (!text.Equals(Protocol, StringComparison.OrdinalIgnoreCase))
		{
			throw new ArgumentException("Unknown URI scheme.", "uri");
		}
		if (dictionary.TryGetValue("starttls", out var value))
		{
			switch (value.ToLowerInvariant())
			{
			default:
				return SecureSocketOptions.StartTlsWhenAvailable;
			case "always":
			case "true":
			case "yes":
				return SecureSocketOptions.StartTls;
			case "never":
			case "false":
			case "no":
				return SecureSocketOptions.None;
			}
		}
		return SecureSocketOptions.StartTlsWhenAvailable;
	}

	public void Connect(Uri uri, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (uri == null)
		{
			throw new ArgumentNullException("uri");
		}
		if (!uri.IsAbsoluteUri)
		{
			throw new ArgumentException("The uri must be absolute.", "uri");
		}
		SecureSocketOptions secureSocketOptions = GetSecureSocketOptions(uri);
		Connect(uri.Host, (uri.Port >= 0) ? uri.Port : 0, secureSocketOptions, cancellationToken);
	}

	public Task ConnectAsync(Uri uri, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (uri == null)
		{
			throw new ArgumentNullException("uri");
		}
		if (!uri.IsAbsoluteUri)
		{
			throw new ArgumentException("The uri must be absolute.", "uri");
		}
		SecureSocketOptions secureSocketOptions = GetSecureSocketOptions(uri);
		return ConnectAsync(uri.Host, (uri.Port >= 0) ? uri.Port : 0, secureSocketOptions, cancellationToken);
	}

	public void Connect(string host, int port, bool useSsl, CancellationToken cancellationToken = default(CancellationToken))
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
		Connect(host, port, useSsl ? SecureSocketOptions.SslOnConnect : SecureSocketOptions.StartTlsWhenAvailable, cancellationToken);
	}

	public Task ConnectAsync(string host, int port, bool useSsl, CancellationToken cancellationToken = default(CancellationToken))
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
		return ConnectAsync(host, port, useSsl ? SecureSocketOptions.SslOnConnect : SecureSocketOptions.StartTlsWhenAvailable, cancellationToken);
	}

	public abstract void Authenticate(Encoding encoding, ICredentials credentials, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task AuthenticateAsync(Encoding encoding, ICredentials credentials, CancellationToken cancellationToken = default(CancellationToken));

	public void Authenticate(ICredentials credentials, CancellationToken cancellationToken = default(CancellationToken))
	{
		Authenticate(Encoding.UTF8, credentials, cancellationToken);
	}

	public Task AuthenticateAsync(ICredentials credentials, CancellationToken cancellationToken = default(CancellationToken))
	{
		return AuthenticateAsync(Encoding.UTF8, credentials, cancellationToken);
	}

	public void Authenticate(Encoding encoding, string userName, string password, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (encoding == null)
		{
			throw new ArgumentNullException("encoding");
		}
		if (userName == null)
		{
			throw new ArgumentNullException("userName");
		}
		if (password == null)
		{
			throw new ArgumentNullException("password");
		}
		NetworkCredential credentials = new NetworkCredential(userName, password);
		Authenticate(encoding, credentials, cancellationToken);
	}

	public Task AuthenticateAsync(Encoding encoding, string userName, string password, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (encoding == null)
		{
			throw new ArgumentNullException("encoding");
		}
		if (userName == null)
		{
			throw new ArgumentNullException("userName");
		}
		if (password == null)
		{
			throw new ArgumentNullException("password");
		}
		NetworkCredential credentials = new NetworkCredential(userName, password);
		return AuthenticateAsync(encoding, credentials, cancellationToken);
	}

	public void Authenticate(string userName, string password, CancellationToken cancellationToken = default(CancellationToken))
	{
		Authenticate(Encoding.UTF8, userName, password, cancellationToken);
	}

	public Task AuthenticateAsync(string userName, string password, CancellationToken cancellationToken = default(CancellationToken))
	{
		return AuthenticateAsync(Encoding.UTF8, userName, password, cancellationToken);
	}

	public abstract void Authenticate(SaslMechanism mechanism, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task AuthenticateAsync(SaslMechanism mechanism, CancellationToken cancellationToken = default(CancellationToken));

	public abstract void Disconnect(bool quit, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task DisconnectAsync(bool quit, CancellationToken cancellationToken = default(CancellationToken));

	public abstract void NoOp(CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task NoOpAsync(CancellationToken cancellationToken = default(CancellationToken));

	protected virtual void OnConnected(string host, int port, SecureSocketOptions options)
	{
		this.Connected?.Invoke(this, new ConnectedEventArgs(host, port, options));
	}

	protected virtual void OnDisconnected(string host, int port, SecureSocketOptions options, bool requested)
	{
		this.Disconnected?.Invoke(this, new DisconnectedEventArgs(host, port, options, requested));
	}

	protected virtual void OnAuthenticated(string message)
	{
		this.Authenticated?.Invoke(this, new AuthenticatedEventArgs(message));
	}

	protected virtual void Dispose(bool disposing)
	{
		if (disposing)
		{
			SslCertificateValidationInfo?.Dispose();
			SslCertificateValidationInfo = null;
			ProtocolLogger.Dispose();
		}
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}
}
