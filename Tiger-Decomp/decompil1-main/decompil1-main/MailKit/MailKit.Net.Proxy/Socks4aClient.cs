using System.Net;

namespace MailKit.Net.Proxy;

public class Socks4aClient : Socks4Client
{
	public Socks4aClient(string host, int port)
		: base(host, port)
	{
		base.IsSocks4a = true;
	}

	public Socks4aClient(string host, int port, NetworkCredential credentials)
		: base(host, port, credentials)
	{
		base.IsSocks4a = true;
	}
}
