namespace MailKit.Net.Imap;

internal enum ImapEngineState
{
	Disconnected,
	Connecting,
	Connected,
	Authenticated,
	Selected,
	Idle
}
