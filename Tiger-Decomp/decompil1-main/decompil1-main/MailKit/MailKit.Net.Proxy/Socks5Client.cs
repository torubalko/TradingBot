using System;
using System.Globalization;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MailKit.Security;

namespace MailKit.Net.Proxy;

public class Socks5Client : SocksClient
{
	internal enum Socks5AddressType : byte
	{
		None = 0,
		IPv4 = 1,
		Domain = 3,
		IPv6 = 4
	}

	private enum Socks5AuthMethod : byte
	{
		Anonymous = 0,
		GSSAPI = 1,
		UserPassword = 2,
		NotSupported = byte.MaxValue
	}

	private enum Socks5Command : byte
	{
		Connect = 1,
		Bind,
		UdpAssociate
	}

	internal enum Socks5Reply : byte
	{
		Success,
		GeneralServerFailure,
		ConnectionNotAllowed,
		NetworkUnreachable,
		HostUnreachable,
		ConnectionRefused,
		TTLExpired,
		CommandNotSupported,
		AddressTypeNotSupported
	}

	public Socks5Client(string host, int port)
		: base(5, host, port)
	{
	}

	public Socks5Client(string host, int port, NetworkCredential credentials)
		: base(5, host, port, credentials)
	{
	}

	internal static string GetFailureReason(byte reply)
	{
		return (Socks5Reply)reply switch
		{
			Socks5Reply.GeneralServerFailure => "General server failure.", 
			Socks5Reply.ConnectionNotAllowed => "Connection not allowed.", 
			Socks5Reply.NetworkUnreachable => "Network unreachable.", 
			Socks5Reply.HostUnreachable => "Host unreachable.", 
			Socks5Reply.ConnectionRefused => "Connection refused.", 
			Socks5Reply.TTLExpired => "TTL expired.", 
			Socks5Reply.CommandNotSupported => "Command not supported.", 
			Socks5Reply.AddressTypeNotSupported => "Address type not supported.", 
			_ => string.Format(CultureInfo.InvariantCulture, "Unknown error ({0}).", (int)reply), 
		};
	}

	internal static Socks5AddressType GetAddressType(string host, out IPAddress ip)
	{
		if (!IPAddress.TryParse(host, out ip))
		{
			return Socks5AddressType.Domain;
		}
		return ip.AddressFamily switch
		{
			AddressFamily.InterNetworkV6 => Socks5AddressType.IPv6, 
			AddressFamily.InterNetwork => Socks5AddressType.IPv4, 
			_ => throw new ArgumentException("The host address must be an IPv4 or IPv6 address.", "host"), 
		};
	}

	private void VerifySocksVersion(byte version)
	{
		if (version != (byte)base.SocksVersion)
		{
			throw new ProxyProtocolException(string.Format(CultureInfo.InvariantCulture, "Proxy server responded with unknown SOCKS version: {0}", (int)version));
		}
	}

	private async Task<Socks5AuthMethod> NegotiateAuthMethodAsync(Socket socket, bool doAsync, CancellationToken cancellationToken, params Socks5AuthMethod[] methods)
	{
		byte[] buffer = new byte[2 + methods.Length];
		int n = 0;
		buffer[n++] = (byte)base.SocksVersion;
		buffer[n++] = (byte)methods.Length;
		for (int i = 0; i < methods.Length; i++)
		{
			buffer[n++] = (byte)methods[i];
		}
		await ProxyClient.SendAsync(socket, buffer, 0, n, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		n = 0;
		do
		{
			int num;
			if ((num = await ProxyClient.ReceiveAsync(socket, buffer, n, 2 - n, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)) > 0)
			{
				n += num;
			}
		}
		while (n < 2);
		VerifySocksVersion(buffer[0]);
		return (Socks5AuthMethod)buffer[1];
	}

	private async Task AuthenticateAsync(Socket socket, bool doAsync, CancellationToken cancellationToken)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(base.ProxyCredentials.UserName);
		if (bytes.Length > 255)
		{
			throw new AuthenticationException("User name too long.");
		}
		byte[] bytes2 = Encoding.UTF8.GetBytes(base.ProxyCredentials.Password);
		if (bytes2.Length > 255)
		{
			Array.Clear(bytes2, 0, bytes2.Length);
			throw new AuthenticationException("Password too long.");
		}
		byte[] buffer = new byte[bytes.Length + bytes2.Length + 3];
		int n = 0;
		buffer[n++] = 1;
		buffer[n++] = (byte)bytes.Length;
		Buffer.BlockCopy(bytes, 0, buffer, n, bytes.Length);
		n += bytes.Length;
		buffer[n++] = (byte)bytes2.Length;
		Buffer.BlockCopy(bytes2, 0, buffer, n, bytes2.Length);
		n += bytes2.Length;
		Array.Clear(bytes2, 0, bytes2.Length);
		await ProxyClient.SendAsync(socket, buffer, 0, n, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		n = 0;
		do
		{
			int num;
			if ((num = await ProxyClient.ReceiveAsync(socket, buffer, n, 2 - n, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)) > 0)
			{
				n += num;
			}
		}
		while (n < 2);
		if (buffer[1] != 0)
		{
			throw new AuthenticationException("Failed to authenticate with SOCKS5 proxy server.");
		}
	}

	private async Task<Socket> ConnectAsync(string host, int port, bool doAsync, CancellationToken cancellationToken)
	{
		ProxyClient.ValidateArguments(host, port);
		IPAddress ip;
		Socks5AddressType addrType = GetAddressType(host, out ip);
		cancellationToken.ThrowIfCancellationRequested();
		Socket socket = await SocketUtils.ConnectAsync(base.ProxyHost, base.ProxyPort, base.LocalEndPoint, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		byte[] domain = null;
		if (addrType == Socks5AddressType.Domain)
		{
			domain = Encoding.UTF8.GetBytes(host);
		}
		try
		{
			switch ((base.ProxyCredentials == null) ? (await NegotiateAuthMethodAsync(socket, doAsync, cancellationToken, default(Socks5AuthMethod)).ConfigureAwait(continueOnCapturedContext: false)) : (await NegotiateAuthMethodAsync(socket, doAsync, cancellationToken, Socks5AuthMethod.UserPassword, Socks5AuthMethod.Anonymous).ConfigureAwait(continueOnCapturedContext: false)))
			{
			case Socks5AuthMethod.UserPassword:
				await AuthenticateAsync(socket, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				break;
			default:
				throw new ProxyProtocolException("Failed to negotiate authentication method with the proxy server.");
			case Socks5AuthMethod.Anonymous:
				break;
			}
			byte[] buffer = new byte[263];
			int n = 0;
			buffer[n++] = (byte)base.SocksVersion;
			buffer[n++] = 1;
			buffer[n++] = 0;
			buffer[n++] = (byte)addrType;
			switch (addrType)
			{
			case Socks5AddressType.Domain:
				buffer[n++] = (byte)domain.Length;
				Buffer.BlockCopy(domain, 0, buffer, n, domain.Length);
				n += domain.Length;
				break;
			case Socks5AddressType.IPv6:
			{
				byte[] addressBytes = ip.GetAddressBytes();
				Buffer.BlockCopy(addressBytes, 0, buffer, n, addressBytes.Length);
				n += 16;
				break;
			}
			case Socks5AddressType.IPv4:
			{
				byte[] addressBytes = ip.GetAddressBytes();
				Buffer.BlockCopy(addressBytes, 0, buffer, n, addressBytes.Length);
				n += 4;
				break;
			}
			}
			buffer[n++] = (byte)(port >> 8);
			buffer[n++] = (byte)port;
			await ProxyClient.SendAsync(socket, buffer, 0, n, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			int need = 5;
			n = 0;
			do
			{
				int num;
				if ((num = await ProxyClient.ReceiveAsync(socket, buffer, n, need - n, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)) > 0)
				{
					n += num;
				}
			}
			while (n < need);
			VerifySocksVersion(buffer[0]);
			if (buffer[1] != 0)
			{
				throw new ProxyProtocolException(string.Format(CultureInfo.InvariantCulture, "Failed to connect to {0}:{1}: {2}", host, port, GetFailureReason(buffer[1])));
			}
			need = (Socks5AddressType)buffer[3] switch
			{
				Socks5AddressType.Domain => need + (buffer[4] + 2), 
				Socks5AddressType.IPv6 => need + 17, 
				Socks5AddressType.IPv4 => need + 5, 
				_ => throw new ProxyProtocolException("Proxy server returned unknown address type."), 
			};
			do
			{
				int num;
				if ((num = await ProxyClient.ReceiveAsync(socket, buffer, n, need - n, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)) > 0)
				{
					n += num;
				}
			}
			while (n < need);
			return socket;
		}
		catch
		{
			if (socket.Connected)
			{
				socket.Disconnect(reuseSocket: false);
			}
			socket.Dispose();
			throw;
		}
	}

	public override Socket Connect(string host, int port, CancellationToken cancellationToken = default(CancellationToken))
	{
		return ConnectAsync(host, port, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override Task<Socket> ConnectAsync(string host, int port, CancellationToken cancellationToken = default(CancellationToken))
	{
		return ConnectAsync(host, port, doAsync: true, cancellationToken);
	}
}
