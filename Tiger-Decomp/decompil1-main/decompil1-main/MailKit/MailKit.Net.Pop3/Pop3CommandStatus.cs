namespace MailKit.Net.Pop3;

internal enum Pop3CommandStatus
{
	Queued = -5,
	Active,
	Continue,
	ProtocolError,
	Error,
	Ok
}
