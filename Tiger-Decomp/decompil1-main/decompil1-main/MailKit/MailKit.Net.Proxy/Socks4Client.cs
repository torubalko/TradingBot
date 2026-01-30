using System;
using System.Globalization;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MailKit.Net.Proxy;

public class Socks4Client : SocksClient
{
	private enum Socks4Command : byte
	{
		Connect = 1,
		Bind
	}

	private enum Socks4Reply : byte
	{
		RequestGranted = 90,
		RequestRejected,
		RequestFailedNoIdentd,
		RequestFailedWrongId
	}

	private static readonly byte[] InvalidIPAddress = new byte[4] { 0, 0, 0, 1 };

	protected bool IsSocks4a { get; set; }

	public Socks4Client(string host, int port)
		: base(4, host, port)
	{
	}

	public Socks4Client(string host, int port, NetworkCredential credentials)
		: base(4, host, port, credentials)
	{
	}

	private static string GetFailureReason(byte reply)
	{
		return (Socks4Reply)reply switch
		{
			Socks4Reply.RequestRejected => "Request rejected or failed.", 
			Socks4Reply.RequestFailedNoIdentd => "Request failed; unable to contact client machine's identd service.", 
			Socks4Reply.RequestFailedWrongId => "Request failed; client ID does not match specified username.", 
			_ => "Unknown error.", 
		};
	}

	private async Task<IPAddress> ResolveAsync(string host, bool doAsync, CancellationToken cancellationToken)
	{
		IPAddress[] array = ((!doAsync) ? Dns.GetHostAddresses(host) : (await Dns.GetHostAddressesAsync(host).ConfigureAwait(continueOnCapturedContext: false)));
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i].AddressFamily == AddressFamily.InterNetwork)
			{
				return array[i];
			}
		}
		throw new ArgumentException("Could not resolve a suitable IPv4 address for '" + host + "'.", "host");
	}

	private async Task<Socket> ConnectAsync(string host, int port, bool doAsync, CancellationToken cancellationToken)
	{
		byte[] domain = null;
		ProxyClient.ValidateArguments(host, port);
		byte[] addr;
		if (!IPAddress.TryParse(host, out var address))
		{
			if (IsSocks4a)
			{
				domain = Encoding.UTF8.GetBytes(host);
				addr = InvalidIPAddress;
			}
			else
			{
				addr = (await ResolveAsync(host, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).GetAddressBytes();
			}
		}
		else
		{
			if (address.AddressFamily != AddressFamily.InterNetwork)
			{
				throw new ArgumentException("The specified host address must be IPv4.", "host");
			}
			addr = address.GetAddressBytes();
		}
		cancellationToken.ThrowIfCancellationRequested();
		Socket socket = await SocketUtils.ConnectAsync(base.ProxyHost, base.ProxyPort, base.LocalEndPoint, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		byte[] array = ((base.ProxyCredentials != null) ? Encoding.UTF8.GetBytes(base.ProxyCredentials.UserName) : new byte[0]);
		try
		{
			int num = 9 + array.Length + ((domain != null) ? (domain.Length + 1) : 0);
			byte[] buffer = new byte[num];
			int n = 0;
			buffer[n++] = (byte)base.SocksVersion;
			buffer[n++] = 1;
			buffer[n++] = (byte)(port >> 8);
			buffer[n++] = (byte)port;
			Buffer.BlockCopy(addr, 0, buffer, n, 4);
			n += 4;
			Buffer.BlockCopy(array, 0, buffer, n, array.Length);
			n += array.Length;
			buffer[n++] = 0;
			if (domain != null)
			{
				Buffer.BlockCopy(domain, 0, buffer, n, domain.Length);
				n += domain.Length;
				buffer[n++] = 0;
			}
			await ProxyClient.SendAsync(socket, buffer, 0, n, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			n = 0;
			do
			{
				int num2;
				if ((num2 = await ProxyClient.ReceiveAsync(socket, buffer, n, 8 - n, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)) > 0)
				{
					n += num2;
				}
			}
			while (n < 8);
			if (buffer[1] != 90)
			{
				throw new ProxyProtocolException(string.Format(CultureInfo.InvariantCulture, "Failed to connect to {0}:{1}: {2}", host, port, GetFailureReason(buffer[1])));
			}
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
