using System.Net;

namespace MailKit.Net.Proxy;

public abstract class SocksClient : ProxyClient
{
	public int SocksVersion { get; private set; }

	protected SocksClient(int version, string host, int port)
		: base(host, port)
	{
		SocksVersion = version;
	}

	protected SocksClient(int version, string host, int port, NetworkCredential credentials)
		: base(host, port, credentials)
	{
		SocksVersion = version;
	}
}
