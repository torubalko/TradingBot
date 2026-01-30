using System.Globalization;
using System.Text;
using System.Threading;

namespace MailKit.Net.Pop3;

internal class Pop3Command
{
	public CancellationToken CancellationToken { get; private set; }

	public Pop3CommandHandler Handler { get; private set; }

	public Encoding Encoding { get; private set; }

	public string Command { get; private set; }

	public int Id { get; internal set; }

	public Pop3CommandStatus Status { get; internal set; }

	public ProtocolException Exception { get; set; }

	public string StatusText { get; set; }

	public Pop3Command(CancellationToken cancellationToken, Pop3CommandHandler handler, Encoding encoding, string format, params object[] args)
	{
		Command = string.Format(CultureInfo.InvariantCulture, format, args);
		CancellationToken = cancellationToken;
		Encoding = encoding;
		Handler = handler;
	}
}
