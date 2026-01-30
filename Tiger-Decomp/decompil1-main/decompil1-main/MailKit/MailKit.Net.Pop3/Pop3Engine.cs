using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MailKit.Net.Pop3;

internal class Pop3Engine
{
	private static readonly Encoding Latin1;

	private static readonly Encoding UTF8;

	private readonly List<Pop3Command> queue;

	private Pop3Stream stream;

	private int nextId;

	public Uri Uri { get; internal set; }

	public HashSet<string> AuthenticationMechanisms { get; private set; }

	public Pop3Capabilities Capabilities { get; set; }

	public Pop3Stream Stream => stream;

	public Pop3EngineState State { get; internal set; }

	public bool IsConnected
	{
		get
		{
			if (stream != null)
			{
				return stream.IsConnected;
			}
			return false;
		}
	}

	public string ApopToken { get; private set; }

	public int ExpirePolicy { get; private set; }

	public string Implementation { get; private set; }

	public int LoginDelay { get; private set; }

	public event EventHandler<EventArgs> Disconnected;

	static Pop3Engine()
	{
		UTF8 = Encoding.GetEncoding(65001, new EncoderExceptionFallback(), new DecoderExceptionFallback());
		try
		{
			Latin1 = Encoding.GetEncoding(28591);
		}
		catch (NotSupportedException)
		{
			Latin1 = Encoding.GetEncoding(1252);
		}
	}

	public Pop3Engine()
	{
		AuthenticationMechanisms = new HashSet<string>(StringComparer.Ordinal);
		Capabilities = Pop3Capabilities.User;
		queue = new List<Pop3Command>();
		nextId = 1;
	}

	private async Task ConnectAsync(Pop3Stream pop3, bool doAsync, CancellationToken cancellationToken)
	{
		if (stream != null)
		{
			stream.Dispose();
		}
		Capabilities = Pop3Capabilities.User;
		AuthenticationMechanisms.Clear();
		State = Pop3EngineState.Disconnected;
		ApopToken = null;
		stream = pop3;
		string text = (await ReadLineAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).TrimEnd();
		int i = text.IndexOf(' ');
		string text2;
		string text3;
		if (i != -1)
		{
			text2 = text.Substring(0, i);
			for (; i < text.Length && char.IsWhiteSpace(text[i]); i++)
			{
			}
			text3 = ((i >= text.Length) ? string.Empty : text.Substring(i));
		}
		else
		{
			text3 = string.Empty;
			text2 = text;
		}
		if (text2 != "+OK")
		{
			stream.Dispose();
			stream = null;
			throw new Pop3ProtocolException($"Unexpected greeting from server: {text}");
		}
		i = text3.IndexOf('<');
		if (i != -1 && i + 1 < text3.Length)
		{
			int num = text3.IndexOf('>', i + 1);
			if (num++ != -1)
			{
				ApopToken = text3.Substring(i, num - i);
				Capabilities |= Pop3Capabilities.Apop;
			}
		}
		State = Pop3EngineState.Connected;
	}

	public void Connect(Pop3Stream pop3, CancellationToken cancellationToken)
	{
		ConnectAsync(pop3, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public Task ConnectAsync(Pop3Stream pop3, CancellationToken cancellationToken)
	{
		return ConnectAsync(pop3, doAsync: true, cancellationToken);
	}

	private void OnDisconnected()
	{
		this.Disconnected?.Invoke(this, EventArgs.Empty);
	}

	public void Disconnect()
	{
		if (stream != null)
		{
			stream.Dispose();
			stream = null;
		}
		if (State != Pop3EngineState.Disconnected)
		{
			State = Pop3EngineState.Disconnected;
			OnDisconnected();
		}
	}

	private async Task<string> ReadLineAsync(bool doAsync, CancellationToken cancellationToken)
	{
		if (stream == null)
		{
			throw new InvalidOperationException();
		}
		using MemoryStream memory = new MemoryStream();
		while (!((!doAsync) ? stream.ReadLine(memory, cancellationToken) : (await stream.ReadLineAsync(memory, cancellationToken).ConfigureAwait(continueOnCapturedContext: false))))
		{
		}
		int num = (int)memory.Length;
		byte[] buffer = memory.GetBuffer();
		if (buffer[num - 1] == 10)
		{
			num--;
			if (buffer[num - 1] == 13)
			{
				num--;
			}
		}
		try
		{
			return UTF8.GetString(buffer, 0, num);
		}
		catch (DecoderFallbackException)
		{
			return Latin1.GetString(buffer, 0, num);
		}
	}

	public string ReadLine(CancellationToken cancellationToken)
	{
		return ReadLineAsync(doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public Task<string> ReadLineAsync(CancellationToken cancellationToken)
	{
		return ReadLineAsync(doAsync: true, cancellationToken);
	}

	public static Pop3CommandStatus GetCommandStatus(string response, out string text)
	{
		int i = response.IndexOf(' ');
		string text2;
		if (i != -1)
		{
			text2 = response.Substring(0, i);
			for (; i < response.Length && char.IsWhiteSpace(response[i]); i++)
			{
			}
			if (i < response.Length)
			{
				text = response.Substring(i);
			}
			else
			{
				text = string.Empty;
			}
		}
		else
		{
			text = string.Empty;
			text2 = response;
		}
		return text2 switch
		{
			"+OK" => Pop3CommandStatus.Ok, 
			"-ERR" => Pop3CommandStatus.Error, 
			"+" => Pop3CommandStatus.Continue, 
			_ => Pop3CommandStatus.ProtocolError, 
		};
	}

	private async Task SendCommandAsync(Pop3Command pc, bool doAsync, CancellationToken cancellationToken)
	{
		byte[] bytes = pc.Encoding.GetBytes(pc.Command + "\r\n");
		if (doAsync)
		{
			await stream.WriteAsync(bytes, 0, bytes.Length, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		else
		{
			stream.Write(bytes, 0, bytes.Length, cancellationToken);
		}
	}

	private async Task ReadResponseAsync(Pop3Command pc, bool doAsync)
	{
		string text;
		try
		{
			text = (await ReadLineAsync(doAsync, pc.CancellationToken).ConfigureAwait(continueOnCapturedContext: false)).TrimEnd();
		}
		catch
		{
			pc.Status = Pop3CommandStatus.ProtocolError;
			Disconnect();
			throw;
		}
		pc.Status = GetCommandStatus(text, out var text2);
		pc.StatusText = text2;
		switch (pc.Status)
		{
		case Pop3CommandStatus.ProtocolError:
			Disconnect();
			throw new Pop3ProtocolException($"Unexpected response from server: {text}");
		case Pop3CommandStatus.Continue:
		case Pop3CommandStatus.Ok:
			if (pc.Handler != null)
			{
				try
				{
					await pc.Handler(this, pc, text2, doAsync).ConfigureAwait(continueOnCapturedContext: false);
					break;
				}
				catch
				{
					pc.Status = Pop3CommandStatus.ProtocolError;
					Disconnect();
					throw;
				}
			}
			break;
		case Pop3CommandStatus.Error:
			break;
		}
	}

	private async Task<int> IterateAsync(bool doAsync)
	{
		if (stream == null)
		{
			throw new InvalidOperationException();
		}
		if (queue.Count == 0)
		{
			return 0;
		}
		int count = (((Capabilities & Pop3Capabilities.Pipelining) == 0) ? 1 : queue.Count);
		CancellationToken cancellationToken = queue[0].CancellationToken;
		List<Pop3Command> active = new List<Pop3Command>();
		if (cancellationToken.IsCancellationRequested)
		{
			queue.RemoveAll((Pop3Command x) => x.CancellationToken.IsCancellationRequested);
			cancellationToken.ThrowIfCancellationRequested();
		}
		for (int i = 0; i < count; i++)
		{
			Pop3Command pop3Command = queue[0];
			if (i > 0 && !pop3Command.CancellationToken.Equals(cancellationToken))
			{
				break;
			}
			queue.RemoveAt(0);
			pop3Command.Status = Pop3CommandStatus.Active;
			active.Add(pop3Command);
			await SendCommandAsync(pop3Command, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		if (doAsync)
		{
			await stream.FlushAsync(cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		else
		{
			stream.Flush(cancellationToken);
		}
		for (int i = 0; i < active.Count; i++)
		{
			await ReadResponseAsync(active[i], doAsync).ConfigureAwait(continueOnCapturedContext: false);
		}
		return active[active.Count - 1].Id;
	}

	public int Iterate()
	{
		return IterateAsync(doAsync: false).GetAwaiter().GetResult();
	}

	public Task<int> IterateAsync()
	{
		return IterateAsync(doAsync: true);
	}

	public Pop3Command QueueCommand(CancellationToken cancellationToken, Pop3CommandHandler handler, Encoding encoding, string format, params object[] args)
	{
		Pop3Command pop3Command = new Pop3Command(cancellationToken, handler, encoding, format, args);
		pop3Command.Id = nextId++;
		queue.Add(pop3Command);
		return pop3Command;
	}

	public Pop3Command QueueCommand(CancellationToken cancellationToken, Pop3CommandHandler handler, string format, params object[] args)
	{
		return QueueCommand(cancellationToken, handler, Encoding.ASCII, format, args);
	}

	private static async Task CapaHandler(Pop3Engine engine, Pop3Command pc, string text, bool doAsync)
	{
		if (pc.Status != Pop3CommandStatus.Ok)
		{
			return;
		}
		string text2;
		while (!((text2 = await engine.ReadLineAsync(doAsync, pc.CancellationToken).ConfigureAwait(continueOnCapturedContext: false)) == "."))
		{
			int i = text2.IndexOf(' ');
			string text3;
			string text4;
			if (i != -1)
			{
				text3 = text2.Substring(0, i);
				for (; i < text2.Length && char.IsWhiteSpace(text2[i]); i++)
				{
				}
				text4 = ((i >= text2.Length) ? string.Empty : text2.Substring(i));
			}
			else
			{
				text4 = string.Empty;
				text3 = text2;
			}
			int result;
			switch (text3)
			{
			case "EXPIRE":
			{
				engine.Capabilities |= Pop3Capabilities.Expire;
				string[] array2 = text4.Split(' ');
				if (int.TryParse(array2[0], NumberStyles.None, CultureInfo.InvariantCulture, out result))
				{
					engine.ExpirePolicy = result;
				}
				else if (array2[0] == "NEVER")
				{
					engine.ExpirePolicy = -1;
				}
				break;
			}
			case "IMPLEMENTATION":
				engine.Implementation = text4;
				break;
			case "LOGIN-DELAY":
				if (int.TryParse(text4, NumberStyles.None, CultureInfo.InvariantCulture, out result))
				{
					engine.Capabilities |= Pop3Capabilities.LoginDelay;
					engine.LoginDelay = result;
				}
				break;
			case "PIPELINING":
				engine.Capabilities |= Pop3Capabilities.Pipelining;
				break;
			case "RESP-CODES":
				engine.Capabilities |= Pop3Capabilities.ResponseCodes;
				break;
			case "SASL":
			{
				engine.Capabilities |= Pop3Capabilities.Sasl;
				string[] array3 = text4.Split(new char[1] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
				foreach (string item in array3)
				{
					engine.AuthenticationMechanisms.Add(item);
				}
				break;
			}
			case "STLS":
				engine.Capabilities |= Pop3Capabilities.StartTLS;
				break;
			case "TOP":
				engine.Capabilities |= Pop3Capabilities.Top;
				break;
			case "UIDL":
				engine.Capabilities |= Pop3Capabilities.UIDL;
				break;
			case "USER":
				engine.Capabilities |= Pop3Capabilities.User;
				break;
			case "UTF8":
			{
				engine.Capabilities |= Pop3Capabilities.UTF8;
				string[] array = text4.Split(' ');
				foreach (string text5 in array)
				{
					if (text5 == "USER")
					{
						engine.Capabilities |= Pop3Capabilities.UTF8User;
					}
				}
				break;
			}
			case "LANG":
				engine.Capabilities |= Pop3Capabilities.Lang;
				break;
			}
		}
	}

	private async Task<Pop3CommandStatus> QueryCapabilitiesAsync(bool doAsync, CancellationToken cancellationToken)
	{
		if (stream == null)
		{
			throw new InvalidOperationException();
		}
		Capabilities &= Pop3Capabilities.Apop | Pop3Capabilities.StartTLS | Pop3Capabilities.User;
		AuthenticationMechanisms.Clear();
		Implementation = null;
		ExpirePolicy = 0;
		LoginDelay = 0;
		Pop3Command pc = QueueCommand(cancellationToken, CapaHandler, "CAPA");
		while (await IterateAsync(doAsync).ConfigureAwait(continueOnCapturedContext: false) < pc.Id)
		{
		}
		return pc.Status;
	}

	public Pop3CommandStatus QueryCapabilities(CancellationToken cancellationToken)
	{
		return QueryCapabilitiesAsync(doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public Task<Pop3CommandStatus> QueryCapabilitiesAsync(CancellationToken cancellationToken)
	{
		return QueryCapabilitiesAsync(doAsync: true, cancellationToken);
	}
}
