namespace MailKit.Net.Imap;

internal class ImapCommandPart
{
	public readonly byte[] Command;

	public readonly ImapLiteral Literal;

	public readonly bool WaitForContinuation;

	public ImapCommandPart(byte[] command, ImapLiteral literal, bool wait = true)
	{
		WaitForContinuation = wait;
		Command = command;
		Literal = literal;
	}
}
