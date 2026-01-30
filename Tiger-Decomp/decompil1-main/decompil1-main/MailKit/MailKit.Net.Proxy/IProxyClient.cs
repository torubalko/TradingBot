using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;

namespace MailKit.Net.Proxy;

public interface IProxyClient
{
	NetworkCredential ProxyCredentials { get; }

	string ProxyHost { get; }

	int ProxyPort { get; }

	IPEndPoint LocalEndPoint { get; set; }

	Socket Connect(string host, int port, CancellationToken cancellationToken = default(CancellationToken));

	Task<Socket> ConnectAsync(string host, int port, CancellationToken cancellationToken = default(CancellationToken));

	Socket Connect(string host, int port, int timeout, CancellationToken cancellationToken = default(CancellationToken));

	Task<Socket> ConnectAsync(string host, int port, int timeout, CancellationToken cancellationToken = default(CancellationToken));
}
