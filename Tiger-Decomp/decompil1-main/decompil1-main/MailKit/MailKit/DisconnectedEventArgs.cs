using MailKit.Security;

namespace MailKit;

public class DisconnectedEventArgs : ConnectedEventArgs
{
	public bool IsRequested { get; private set; }

	public DisconnectedEventArgs(string host, int port, SecureSocketOptions options, bool requested)
		: base(host, port, options)
	{
		IsRequested = requested;
	}
}
