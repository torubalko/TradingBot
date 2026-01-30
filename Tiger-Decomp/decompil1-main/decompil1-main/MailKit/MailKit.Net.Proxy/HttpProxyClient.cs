using System;
using System.Buffers;
using System.Globalization;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MailKit.Net.Proxy;

public class HttpProxyClient : ProxyClient
{
	private const int BufferSize = 4096;

	public HttpProxyClient(string host, int port)
		: base(host, port)
	{
	}

	public HttpProxyClient(string host, int port, NetworkCredential credentials)
		: base(host, port, credentials)
	{
	}

	private async Task<Socket> ConnectAsync(string host, int port, bool doAsync, CancellationToken cancellationToken)
	{
		ProxyClient.ValidateArguments(host, port);
		cancellationToken.ThrowIfCancellationRequested();
		Socket socket = await SocketUtils.ConnectAsync(base.ProxyHost, base.ProxyPort, base.LocalEndPoint, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		StringBuilder builder = new StringBuilder();
		builder.AppendFormat(CultureInfo.InvariantCulture, "CONNECT {0}:{1} HTTP/1.1\r\n", host, port);
		builder.AppendFormat(CultureInfo.InvariantCulture, "Host: {0}:{1}\r\n", host, port);
		if (base.ProxyCredentials != null)
		{
			byte[] bytes = Encoding.UTF8.GetBytes(string.Format(CultureInfo.InvariantCulture, "{0}:{1}", base.ProxyCredentials.UserName, base.ProxyCredentials.Password));
			string arg = Convert.ToBase64String(bytes);
			builder.AppendFormat(CultureInfo.InvariantCulture, "Proxy-Authorization: Basic {0}\r\n", arg);
		}
		builder.Append("\r\n");
		byte[] bytes2 = Encoding.UTF8.GetBytes(builder.ToString());
		try
		{
			await ProxyClient.SendAsync(socket, bytes2, 0, bytes2.Length, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			byte[] buffer = ArrayPool<byte>.Shared.Rent(4096);
			try
			{
				bool endOfHeaders = false;
				bool newline = false;
				builder.Clear();
				do
				{
					int num = await ProxyClient.ReceiveAsync(socket, buffer, 0, 4096, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
					if (num <= 0)
					{
						continue;
					}
					int count = num;
					for (int i = 0; i < num; i++)
					{
						if (endOfHeaders)
						{
							break;
						}
						switch ((char)buffer[i])
						{
						case '\n':
							endOfHeaders = newline;
							newline = true;
							if (endOfHeaders)
							{
								count = i + 1;
							}
							break;
						default:
							newline = false;
							break;
						case '\r':
							break;
						}
					}
					builder.Append(Encoding.UTF8.GetString(buffer, 0, count));
				}
				while (!endOfHeaders);
			}
			finally
			{
				ArrayPool<byte>.Shared.Return(buffer);
			}
			int j;
			for (j = 0; builder[j] != '\n'; j++)
			{
			}
			if (j > 0 && builder[j - 1] == '\r')
			{
				j--;
			}
			builder.Length = j;
			string text = builder.ToString();
			if (text.Length >= 15 && text.StartsWith("HTTP/1.", StringComparison.OrdinalIgnoreCase) && (text[7] == '1' || text[7] == '0') && text[8] == ' ' && text[9] == '2' && text[10] == '0' && text[11] == '0' && text[12] == ' ')
			{
				return socket;
			}
			throw new ProxyProtocolException(string.Format(CultureInfo.InvariantCulture, "Failed to connect to {0}:{1}: {2}", host, port, text));
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
