using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using MimeKit.IO;

namespace MimeKit;

public class MessagePart : MimeEntity
{
	public MimeMessage Message { get; set; }

	public MessagePart(MimeEntityConstructorArgs args)
		: base(args)
	{
	}

	public MessagePart(string subtype, params object[] args)
		: this(subtype)
	{
		if (args == null)
		{
			throw new ArgumentNullException("args");
		}
		MimeMessage mimeMessage = null;
		foreach (object obj in args)
		{
			if (obj != null && !TryInit(obj))
			{
				if (!(obj is MimeMessage mimeMessage2))
				{
					throw new ArgumentException("Unknown initialization parameter: " + obj.GetType());
				}
				if (mimeMessage != null)
				{
					throw new ArgumentException("MimeMessage should not be specified more than once.");
				}
				mimeMessage = mimeMessage2;
			}
		}
		if (mimeMessage != null)
		{
			Message = mimeMessage;
		}
	}

	protected MessagePart(string mediaType, string mediaSubtype)
		: base(mediaType, mediaSubtype)
	{
	}

	public MessagePart(string subtype)
		: this("message", subtype)
	{
	}

	public MessagePart()
		: this("rfc822")
	{
	}

	public override void Accept(MimeVisitor visitor)
	{
		if (visitor == null)
		{
			throw new ArgumentNullException("visitor");
		}
		visitor.VisitMessagePart(this);
	}

	public override void Prepare(EncodingConstraint constraint, int maxLineLength = 78)
	{
		if (maxLineLength < 60 || maxLineLength > 998)
		{
			throw new ArgumentOutOfRangeException("maxLineLength");
		}
		if (Message != null)
		{
			Message.Prepare(constraint, maxLineLength);
		}
	}

	public override void WriteTo(FormatOptions options, Stream stream, bool contentOnly, CancellationToken cancellationToken = default(CancellationToken))
	{
		base.WriteTo(options, stream, contentOnly, cancellationToken);
		if (Message == null)
		{
			return;
		}
		if (Message.MboxMarker != null && Message.MboxMarker.Length != 0)
		{
			if (stream is ICancellableStream cancellableStream)
			{
				cancellableStream.Write(Message.MboxMarker, 0, Message.MboxMarker.Length, cancellationToken);
				cancellableStream.Write(options.NewLineBytes, 0, options.NewLineBytes.Length, cancellationToken);
			}
			else
			{
				stream.Write(Message.MboxMarker, 0, Message.MboxMarker.Length);
				stream.Write(options.NewLineBytes, 0, options.NewLineBytes.Length);
			}
		}
		if (options.EnsureNewLine)
		{
			options = options.Clone();
			options.EnsureNewLine = false;
		}
		Message.WriteTo(options, stream, cancellationToken);
	}

	public override async Task WriteToAsync(FormatOptions options, Stream stream, bool contentOnly, CancellationToken cancellationToken = default(CancellationToken))
	{
		await base.WriteToAsync(options, stream, contentOnly, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		if (Message != null)
		{
			if (Message.MboxMarker != null && Message.MboxMarker.Length != 0)
			{
				await stream.WriteAsync(Message.MboxMarker, 0, Message.MboxMarker.Length, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				await stream.WriteAsync(options.NewLineBytes, 0, options.NewLineBytes.Length, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			}
			if (options.EnsureNewLine)
			{
				options = options.Clone();
				options.EnsureNewLine = false;
			}
			await Message.WriteToAsync(options, stream, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
	}
}
