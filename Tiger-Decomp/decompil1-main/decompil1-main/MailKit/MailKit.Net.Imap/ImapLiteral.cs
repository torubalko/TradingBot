using System;
using System.Threading;
using System.Threading.Tasks;
using MimeKit;
using MimeKit.IO;

namespace MailKit.Net.Imap;

internal class ImapLiteral
{
	public readonly ImapLiteralType Type;

	public readonly object Literal;

	private readonly FormatOptions format;

	private readonly Action<int> update;

	public long Length
	{
		get
		{
			if (Type == ImapLiteralType.String)
			{
				return ((byte[])Literal).Length;
			}
			using MeasuringStream measuringStream = new MeasuringStream();
			((MimeMessage)Literal).WriteTo(format, measuringStream);
			return measuringStream.Length;
		}
	}

	public ImapLiteral(FormatOptions options, MimeMessage message, Action<int> action = null)
	{
		format = options.Clone();
		format.NewLineFormat = NewLineFormat.Dos;
		update = action;
		Type = ImapLiteralType.MimeMessage;
		Literal = message;
	}

	public ImapLiteral(FormatOptions options, byte[] literal)
	{
		format = options.Clone();
		format.NewLineFormat = NewLineFormat.Dos;
		Type = ImapLiteralType.String;
		Literal = literal;
	}

	public async Task WriteToAsync(ImapStream stream, bool doAsync, CancellationToken cancellationToken)
	{
		if (Type == ImapLiteralType.String)
		{
			byte[] array = (byte[])Literal;
			if (doAsync)
			{
				await stream.WriteAsync(array, 0, array.Length, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				await stream.FlushAsync(cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			}
			else
			{
				stream.Write(array, 0, array.Length, cancellationToken);
				stream.Flush(cancellationToken);
			}
			return;
		}
		MimeMessage mimeMessage = (MimeMessage)Literal;
		using ProgressStream s = new ProgressStream(stream, update);
		if (doAsync)
		{
			await mimeMessage.WriteToAsync(format, s, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			await s.FlushAsync(cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		else
		{
			mimeMessage.WriteTo(format, s, cancellationToken);
			s.Flush(cancellationToken);
		}
	}
}
