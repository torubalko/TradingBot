using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MailKit.Net.Imap;

internal sealed class ImapIdleContext : IDisposable
{
	private static readonly byte[] DoneCommand = Encoding.ASCII.GetBytes("DONE\r\n");

	private CancellationTokenRegistration registration;

	public ImapEngine Engine { get; private set; }

	public CancellationToken CancellationToken { get; private set; }

	public CancellationToken DoneToken { get; private set; }

	public ImapIdleContext(ImapEngine engine, CancellationToken doneToken, CancellationToken cancellationToken)
	{
		CancellationToken = cancellationToken;
		DoneToken = doneToken;
		Engine = engine;
	}

	private void IdleComplete()
	{
		if (Engine.State == ImapEngineState.Idle)
		{
			try
			{
				Engine.Stream.Write(DoneCommand, 0, DoneCommand.Length, CancellationToken);
				Engine.Stream.Flush(CancellationToken);
			}
			catch
			{
				return;
			}
			Engine.State = ImapEngineState.Selected;
		}
	}

	public Task ContinuationHandler(ImapEngine engine, ImapCommand ic, string text, bool doAsync)
	{
		Engine.State = ImapEngineState.Idle;
		registration = DoneToken.Register(IdleComplete);
		return Task.FromResult(result: true);
	}

	public void Dispose()
	{
		registration.Dispose();
	}
}
