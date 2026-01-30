using System;
using MailKit.Security;

namespace MailKit;

public class ConnectedEventArgs : EventArgs
{
	public string Host { get; private set; }

	public int Port { get; private set; }

	public SecureSocketOptions Options { get; private set; }

	public ConnectedEventArgs(string host, int port, SecureSocketOptions options)
	{
		Options = options;
		Host = host;
		Port = port;
	}
}
