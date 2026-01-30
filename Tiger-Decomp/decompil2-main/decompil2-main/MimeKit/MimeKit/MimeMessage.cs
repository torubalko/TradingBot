using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MimeKit.Cryptography;
using MimeKit.IO;
using MimeKit.Text;
using MimeKit.Utils;

namespace MimeKit;

public class MimeMessage
{
	private static readonly HeaderId[] StandardAddressHeaders = new HeaderId[10]
	{
		HeaderId.ResentFrom,
		HeaderId.ResentReplyTo,
		HeaderId.ResentTo,
		HeaderId.ResentCc,
		HeaderId.ResentBcc,
		HeaderId.From,
		HeaderId.ReplyTo,
		HeaderId.To,
		HeaderId.Cc,
		HeaderId.Bcc
	};

	private readonly Dictionary<HeaderId, InternetAddressList> addresses;

	private MessageImportance importance = MessageImportance.Normal;

	private XMessagePriority xpriority = XMessagePriority.Normal;

	private MessagePriority priority = MessagePriority.Normal;

	private readonly RfcComplianceMode compliance;

	private readonly MessageIdList references;

	private MailboxAddress resentSender;

	private DateTimeOffset resentDate;

	private string resentMessageId;

	private MailboxAddress sender;

	private DateTimeOffset date;

	private string messageId;

	private string inreplyto;

	private Version version;

	internal byte[] MboxMarker { get; set; }

	public HeaderList Headers { get; private set; }

	public MessageImportance Importance
	{
		get
		{
			return importance;
		}
		set
		{
			if (value != importance)
			{
				if ((uint)value > 2u)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				SetHeader("Importance", value.ToString().ToLowerInvariant());
				importance = value;
			}
		}
	}

	public MessagePriority Priority
	{
		get
		{
			return priority;
		}
		set
		{
			if (value != priority)
			{
				SetHeader("Priority", value switch
				{
					MessagePriority.NonUrgent => "non-urgent", 
					MessagePriority.Normal => "normal", 
					MessagePriority.Urgent => "urgent", 
					_ => throw new ArgumentOutOfRangeException("value"), 
				});
				priority = value;
			}
		}
	}

	public XMessagePriority XPriority
	{
		get
		{
			return xpriority;
		}
		set
		{
			if (value != xpriority)
			{
				SetHeader("X-Priority", value switch
				{
					XMessagePriority.Highest => "1 (Highest)", 
					XMessagePriority.High => "2 (High)", 
					XMessagePriority.Normal => "3 (Normal)", 
					XMessagePriority.Low => "4 (Low)", 
					XMessagePriority.Lowest => "5 (Lowest)", 
					_ => throw new ArgumentOutOfRangeException("value"), 
				});
				xpriority = value;
			}
		}
	}

	public MailboxAddress Sender
	{
		get
		{
			return sender;
		}
		set
		{
			if (value != sender)
			{
				if (value == null)
				{
					RemoveHeader(HeaderId.Sender);
					sender = null;
					return;
				}
				FormatOptions formatOptions = FormatOptions.Default;
				StringBuilder stringBuilder = new StringBuilder(" ");
				int lineLength = "Sender: ".Length;
				value.Encode(formatOptions, stringBuilder, firstToken: true, ref lineLength);
				stringBuilder.Append(formatOptions.NewLine);
				byte[] bytes = Encoding.UTF8.GetBytes(stringBuilder.ToString());
				ReplaceHeader(HeaderId.Sender, "Sender", bytes);
				sender = value;
			}
		}
	}

	public MailboxAddress ResentSender
	{
		get
		{
			return resentSender;
		}
		set
		{
			if (value != resentSender)
			{
				if (value == null)
				{
					RemoveHeader(HeaderId.ResentSender);
					resentSender = null;
					return;
				}
				FormatOptions formatOptions = FormatOptions.Default;
				StringBuilder stringBuilder = new StringBuilder(" ");
				int lineLength = "Resent-Sender: ".Length;
				value.Encode(formatOptions, stringBuilder, firstToken: true, ref lineLength);
				stringBuilder.Append(formatOptions.NewLine);
				byte[] bytes = Encoding.UTF8.GetBytes(stringBuilder.ToString());
				ReplaceHeader(HeaderId.ResentSender, "Resent-Sender", bytes);
				resentSender = value;
			}
		}
	}

	public InternetAddressList From => addresses[HeaderId.From];

	public InternetAddressList ResentFrom => addresses[HeaderId.ResentFrom];

	public InternetAddressList ReplyTo => addresses[HeaderId.ReplyTo];

	public InternetAddressList ResentReplyTo => addresses[HeaderId.ResentReplyTo];

	public InternetAddressList To => addresses[HeaderId.To];

	public InternetAddressList ResentTo => addresses[HeaderId.ResentTo];

	public InternetAddressList Cc => addresses[HeaderId.Cc];

	public InternetAddressList ResentCc => addresses[HeaderId.ResentCc];

	public InternetAddressList Bcc => addresses[HeaderId.Bcc];

	public InternetAddressList ResentBcc => addresses[HeaderId.ResentBcc];

	public string Subject
	{
		get
		{
			return Headers["Subject"];
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			SetHeader("Subject", value);
		}
	}

	public DateTimeOffset Date
	{
		get
		{
			return date;
		}
		set
		{
			if (!(date == value))
			{
				SetHeader("Date", DateUtils.FormatDate(value));
				date = value;
			}
		}
	}

	public DateTimeOffset ResentDate
	{
		get
		{
			return resentDate;
		}
		set
		{
			if (!(resentDate == value))
			{
				SetHeader("Resent-Date", DateUtils.FormatDate(value));
				resentDate = value;
			}
		}
	}

	public MessageIdList References => references;

	public string InReplyTo
	{
		get
		{
			return inreplyto;
		}
		set
		{
			if (inreplyto == value)
			{
				return;
			}
			if (value == null)
			{
				RemoveHeader(HeaderId.InReplyTo);
				inreplyto = null;
				return;
			}
			byte[] bytes = Encoding.UTF8.GetBytes(value);
			int index = 0;
			if (!MailboxAddress.TryParse(Headers.Options, bytes, ref index, bytes.Length, throwOnError: false, out var mailbox))
			{
				throw new ArgumentException("Invalid Message-Id format.", "value");
			}
			inreplyto = mailbox.Address;
			SetHeader("In-Reply-To", "<" + inreplyto + ">");
		}
	}

	public string MessageId
	{
		get
		{
			return messageId;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (!(messageId == value))
			{
				byte[] bytes = Encoding.UTF8.GetBytes(value);
				int index = 0;
				if (!MailboxAddress.TryParse(Headers.Options, bytes, ref index, bytes.Length, throwOnError: false, out var mailbox))
				{
					throw new ArgumentException("Invalid Message-Id format.", "value");
				}
				messageId = mailbox.Address;
				SetHeader("Message-Id", "<" + messageId + ">");
			}
		}
	}

	public string ResentMessageId
	{
		get
		{
			return resentMessageId;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (!(resentMessageId == value))
			{
				byte[] bytes = Encoding.UTF8.GetBytes(value);
				int index = 0;
				if (!MailboxAddress.TryParse(Headers.Options, bytes, ref index, bytes.Length, throwOnError: false, out var mailbox))
				{
					throw new ArgumentException("Invalid Resent-Message-Id format.", "value");
				}
				resentMessageId = mailbox.Address;
				SetHeader("Resent-Message-Id", "<" + resentMessageId + ">");
			}
		}
	}

	public Version MimeVersion
	{
		get
		{
			return version;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (!(version != null) || version.CompareTo(value) != 0)
			{
				SetHeader("MIME-Version", value.ToString());
				version = value;
			}
		}
	}

	public MimeEntity Body { get; set; }

	public string TextBody => GetTextBody(TextFormat.Plain);

	public string HtmlBody => GetTextBody(TextFormat.Html);

	public IEnumerable<MimeEntity> BodyParts => EnumerateMimeParts(Body);

	public IEnumerable<MimeEntity> Attachments => from x in EnumerateMimeParts(Body)
		where x.IsAttachment
		select x;

	internal MimeMessage(ParserOptions options, IEnumerable<Header> headers, RfcComplianceMode mode)
	{
		addresses = new Dictionary<HeaderId, InternetAddressList>();
		Headers = new HeaderList(options);
		compliance = mode;
		HeaderId[] standardAddressHeaders = StandardAddressHeaders;
		foreach (HeaderId key in standardAddressHeaders)
		{
			InternetAddressList internetAddressList = new InternetAddressList();
			internetAddressList.Changed += InternetAddressListChanged;
			addresses.Add(key, internetAddressList);
		}
		references = new MessageIdList();
		references.Changed += ReferencesChanged;
		inreplyto = null;
		Headers.Changed += HeadersChanged;
		foreach (Header header in headers)
		{
			if (!header.Field.StartsWith("Content-", StringComparison.OrdinalIgnoreCase))
			{
				Headers.Add(header);
			}
		}
	}

	internal MimeMessage(ParserOptions options)
	{
		addresses = new Dictionary<HeaderId, InternetAddressList>();
		Headers = new HeaderList(options);
		compliance = RfcComplianceMode.Strict;
		HeaderId[] standardAddressHeaders = StandardAddressHeaders;
		foreach (HeaderId key in standardAddressHeaders)
		{
			InternetAddressList internetAddressList = new InternetAddressList();
			internetAddressList.Changed += InternetAddressListChanged;
			addresses.Add(key, internetAddressList);
		}
		references = new MessageIdList();
		references.Changed += ReferencesChanged;
		inreplyto = null;
		Headers.Changed += HeadersChanged;
	}

	public MimeMessage(params object[] args)
		: this(ParserOptions.Default.Clone())
	{
		if (args == null)
		{
			throw new ArgumentNullException("args");
		}
		MimeEntity mimeEntity = null;
		foreach (object obj in args)
		{
			if (obj == null)
			{
				continue;
			}
			if (obj is Header header)
			{
				if (!header.Field.StartsWith("Content-", StringComparison.OrdinalIgnoreCase))
				{
					Headers.Add(header);
				}
				continue;
			}
			if (obj is IEnumerable<Header> enumerable)
			{
				foreach (Header item in enumerable)
				{
					if (!item.Field.StartsWith("Content-", StringComparison.OrdinalIgnoreCase))
					{
						Headers.Add(item);
					}
				}
				continue;
			}
			if (obj is MimeEntity mimeEntity2)
			{
				if (mimeEntity != null)
				{
					throw new ArgumentException("Message body should not be specified more than once.");
				}
				mimeEntity = mimeEntity2;
				continue;
			}
			throw new ArgumentException("Unknown initialization parameter: " + obj.GetType());
		}
		if (mimeEntity != null)
		{
			Body = mimeEntity;
		}
		if (!Headers.Contains(HeaderId.From))
		{
			Headers[HeaderId.From] = string.Empty;
		}
		if (date == default(DateTimeOffset))
		{
			Date = DateTimeOffset.Now;
		}
		if (!Headers.Contains(HeaderId.Subject))
		{
			Subject = string.Empty;
		}
		if (messageId == null)
		{
			MessageId = MimeUtils.GenerateMessageId();
		}
	}

	public MimeMessage(IEnumerable<InternetAddress> from, IEnumerable<InternetAddress> to, string subject, MimeEntity body)
		: this()
	{
		From.AddRange(from);
		To.AddRange(to);
		Subject = subject;
		Body = body;
	}

	public MimeMessage()
		: this(ParserOptions.Default.Clone())
	{
		Headers[HeaderId.From] = string.Empty;
		Date = DateTimeOffset.Now;
		Subject = string.Empty;
		MessageId = MimeUtils.GenerateMessageId();
	}

	private static bool TryGetMultipartBody(Multipart multipart, TextFormat format, out string body)
	{
		if (multipart is MultipartAlternative multipartAlternative)
		{
			body = multipartAlternative.GetTextBody(format);
			return body != null;
		}
		if (!(multipart is MultipartRelated { Root: var root }))
		{
			for (int i = 0; i < multipart.Count; i++)
			{
				if (multipart[i] is Multipart multipart2)
				{
					if (!TryGetMultipartBody(multipart2, format, out body))
					{
						break;
					}
					return true;
				}
				if (multipart[i] is TextPart { IsAttachment: false } textPart)
				{
					if (!textPart.IsFormat(format))
					{
						break;
					}
					body = MultipartAlternative.GetText(textPart);
					return true;
				}
			}
		}
		else
		{
			if (root is TextPart textPart2)
			{
				body = (textPart2.IsFormat(format) ? textPart2.Text : null);
				return body != null;
			}
			if (root is Multipart multipart3)
			{
				return TryGetMultipartBody(multipart3, format, out body);
			}
		}
		body = null;
		return false;
	}

	public string GetTextBody(TextFormat format)
	{
		if (Body is Multipart multipart)
		{
			if (TryGetMultipartBody(multipart, format, out var body))
			{
				return body;
			}
		}
		else if (Body is TextPart textPart && textPart.IsFormat(format) && !textPart.IsAttachment)
		{
			return textPart.Text;
		}
		return null;
	}

	private static IEnumerable<MimeEntity> EnumerateMimeParts(MimeEntity entity)
	{
		if (entity == null)
		{
			yield break;
		}
		if (entity is Multipart multipart)
		{
			foreach (MimeEntity item in multipart)
			{
				foreach (MimeEntity item2 in EnumerateMimeParts(item))
				{
					yield return item2;
				}
			}
		}
		else
		{
			yield return entity;
		}
	}

	public override string ToString()
	{
		using MemoryStream memoryStream = new MemoryStream();
		memoryStream.Write(FormatOptions.Default.NewLineBytes, 0, FormatOptions.Default.NewLineBytes.Length);
		WriteTo(FormatOptions.Default, memoryStream);
		byte[] buffer = memoryStream.GetBuffer();
		int count = (int)memoryStream.Length;
		return CharsetUtils.Latin1.GetString(buffer, 0, count);
	}

	public virtual void Accept(MimeVisitor visitor)
	{
		if (visitor == null)
		{
			throw new ArgumentNullException("visitor");
		}
		visitor.VisitMimeMessage(this);
	}

	public virtual void Prepare(EncodingConstraint constraint, int maxLineLength = 78)
	{
		if (maxLineLength < 60 || maxLineLength > 998)
		{
			throw new ArgumentOutOfRangeException("maxLineLength");
		}
		if (Body != null)
		{
			if (MimeVersion == null && Body.Headers.Count > 0)
			{
				MimeVersion = new Version(1, 0);
			}
			Body.Prepare(constraint, maxLineLength);
		}
	}

	public void WriteTo(FormatOptions options, Stream stream, bool headersOnly, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (stream == null)
		{
			throw new ArgumentNullException("stream");
		}
		if (compliance == RfcComplianceMode.Strict && Body != null && Body.Headers.Count > 0 && !Headers.Contains(HeaderId.MimeVersion))
		{
			MimeVersion = new Version(1, 0);
		}
		if (Body != null)
		{
			using (FilteredStream filteredStream = new FilteredStream(stream))
			{
				filteredStream.Add(options.CreateNewLineFilter());
				foreach (Header item in MergeHeaders())
				{
					if (!options.HiddenHeaders.Contains(item.Id))
					{
						filteredStream.Write(item.RawField, 0, item.RawField.Length, cancellationToken);
						if (!item.IsInvalid)
						{
							byte[] rawValue = item.GetRawValue(options);
							filteredStream.Write(Header.Colon, 0, Header.Colon.Length, cancellationToken);
							filteredStream.Write(rawValue, 0, rawValue.Length, cancellationToken);
						}
					}
				}
				filteredStream.Flush(cancellationToken);
			}
			if (stream is ICancellableStream cancellableStream)
			{
				cancellableStream.Write(options.NewLineBytes, 0, options.NewLineBytes.Length, cancellationToken);
			}
			else
			{
				cancellationToken.ThrowIfCancellationRequested();
				stream.Write(options.NewLineBytes, 0, options.NewLineBytes.Length);
			}
			if (!headersOnly)
			{
				try
				{
					Body.EnsureNewLine = compliance == RfcComplianceMode.Strict || options.EnsureNewLine;
					Body.WriteTo(options, stream, contentOnly: true, cancellationToken);
				}
				finally
				{
					Body.EnsureNewLine = false;
				}
			}
		}
		else
		{
			Headers.WriteTo(options, stream, cancellationToken);
		}
	}

	public async Task WriteToAsync(FormatOptions options, Stream stream, bool headersOnly, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (stream == null)
		{
			throw new ArgumentNullException("stream");
		}
		if (compliance == RfcComplianceMode.Strict && Body != null && Body.Headers.Count > 0 && !Headers.Contains(HeaderId.MimeVersion))
		{
			MimeVersion = new Version(1, 0);
		}
		if (Body != null)
		{
			using (FilteredStream filtered = new FilteredStream(stream))
			{
				filtered.Add(options.CreateNewLineFilter());
				foreach (Header header in MergeHeaders())
				{
					if (!options.HiddenHeaders.Contains(header.Id))
					{
						await filtered.WriteAsync(header.RawField, 0, header.RawField.Length, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
						if (!header.IsInvalid)
						{
							byte[] rawValue = header.GetRawValue(options);
							await filtered.WriteAsync(Header.Colon, 0, Header.Colon.Length, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
							await filtered.WriteAsync(rawValue, 0, rawValue.Length, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
						}
					}
				}
				await filtered.FlushAsync(cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			}
			await stream.WriteAsync(options.NewLineBytes, 0, options.NewLineBytes.Length, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			if (!headersOnly)
			{
				try
				{
					Body.EnsureNewLine = compliance == RfcComplianceMode.Strict || options.EnsureNewLine;
					await Body.WriteToAsync(options, stream, contentOnly: true, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				}
				finally
				{
					Body.EnsureNewLine = false;
				}
			}
		}
		else
		{
			await Headers.WriteToAsync(options, stream, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
	}

	public void WriteTo(FormatOptions options, Stream stream, CancellationToken cancellationToken = default(CancellationToken))
	{
		WriteTo(options, stream, headersOnly: false, cancellationToken);
	}

	public Task WriteToAsync(FormatOptions options, Stream stream, CancellationToken cancellationToken = default(CancellationToken))
	{
		return WriteToAsync(options, stream, headersOnly: false, cancellationToken);
	}

	public void WriteTo(Stream stream, bool headersOnly, CancellationToken cancellationToken = default(CancellationToken))
	{
		WriteTo(FormatOptions.Default, stream, headersOnly, cancellationToken);
	}

	public Task WriteToAsync(Stream stream, bool headersOnly, CancellationToken cancellationToken = default(CancellationToken))
	{
		return WriteToAsync(FormatOptions.Default, stream, headersOnly, cancellationToken);
	}

	public void WriteTo(Stream stream, CancellationToken cancellationToken = default(CancellationToken))
	{
		WriteTo(FormatOptions.Default, stream, headersOnly: false, cancellationToken);
	}

	public Task WriteToAsync(Stream stream, CancellationToken cancellationToken = default(CancellationToken))
	{
		return WriteToAsync(FormatOptions.Default, stream, headersOnly: false, cancellationToken);
	}

	public void WriteTo(FormatOptions options, string fileName, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (fileName == null)
		{
			throw new ArgumentNullException("fileName");
		}
		using FileStream fileStream = File.Open(fileName, FileMode.Create, FileAccess.Write);
		WriteTo(options, fileStream, cancellationToken);
		fileStream.Flush();
	}

	public async Task WriteToAsync(FormatOptions options, string fileName, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (fileName == null)
		{
			throw new ArgumentNullException("fileName");
		}
		using FileStream stream = File.Open(fileName, FileMode.Create, FileAccess.Write);
		await WriteToAsync(options, stream, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		await stream.FlushAsync(cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
	}

	public void WriteTo(string fileName, CancellationToken cancellationToken = default(CancellationToken))
	{
		WriteTo(FormatOptions.Default, fileName, cancellationToken);
	}

	public Task WriteToAsync(string fileName, CancellationToken cancellationToken = default(CancellationToken))
	{
		return WriteToAsync(FormatOptions.Default, fileName, cancellationToken);
	}

	private MailboxAddress GetMessageSigner()
	{
		if (ResentSender != null)
		{
			return ResentSender;
		}
		if (ResentFrom.Count > 0)
		{
			return ResentFrom.Mailboxes.FirstOrDefault();
		}
		if (Sender != null)
		{
			return Sender;
		}
		if (From.Count > 0)
		{
			return From.Mailboxes.FirstOrDefault();
		}
		return null;
	}

	private IList<MailboxAddress> GetMessageRecipients(bool includeSenders)
	{
		HashSet<MailboxAddress> hashSet = new HashSet<MailboxAddress>();
		if (ResentSender != null || ResentFrom.Count > 0)
		{
			if (includeSenders)
			{
				if (ResentSender != null)
				{
					hashSet.Add(ResentSender);
				}
				if (ResentFrom.Count > 0)
				{
					foreach (MailboxAddress mailbox in ResentFrom.Mailboxes)
					{
						hashSet.Add(mailbox);
					}
				}
			}
			foreach (MailboxAddress mailbox2 in ResentTo.Mailboxes)
			{
				hashSet.Add(mailbox2);
			}
			foreach (MailboxAddress mailbox3 in ResentCc.Mailboxes)
			{
				hashSet.Add(mailbox3);
			}
			foreach (MailboxAddress mailbox4 in ResentBcc.Mailboxes)
			{
				hashSet.Add(mailbox4);
			}
		}
		else
		{
			if (includeSenders)
			{
				if (Sender != null)
				{
					hashSet.Add(Sender);
				}
				if (From.Count > 0)
				{
					foreach (MailboxAddress mailbox5 in From.Mailboxes)
					{
						hashSet.Add(mailbox5);
					}
				}
			}
			foreach (MailboxAddress mailbox6 in To.Mailboxes)
			{
				hashSet.Add(mailbox6);
			}
			foreach (MailboxAddress mailbox7 in Cc.Mailboxes)
			{
				hashSet.Add(mailbox7);
			}
			foreach (MailboxAddress mailbox8 in Bcc.Mailboxes)
			{
				hashSet.Add(mailbox8);
			}
		}
		return hashSet.ToList();
	}

	internal byte[] HashBody(FormatOptions options, DkimSignatureAlgorithm signatureAlgorithm, DkimCanonicalizationAlgorithm bodyCanonicalizationAlgorithm, int maxLength)
	{
		using DkimHashStream dkimHashStream = new DkimHashStream(signatureAlgorithm, maxLength);
		using (FilteredStream filteredStream = new FilteredStream(dkimHashStream))
		{
			DkimBodyFilter dkimBodyFilter = ((bodyCanonicalizationAlgorithm != DkimCanonicalizationAlgorithm.Relaxed) ? ((DkimBodyFilter)new DkimSimpleBodyFilter()) : ((DkimBodyFilter)new DkimRelaxedBodyFilter()));
			filteredStream.Add(options.CreateNewLineFilter());
			filteredStream.Add(dkimBodyFilter);
			if (Body != null)
			{
				try
				{
					Body.EnsureNewLine = compliance == RfcComplianceMode.Strict || options.EnsureNewLine;
					Body.WriteTo(options, filteredStream, contentOnly: true, CancellationToken.None);
				}
				finally
				{
					Body.EnsureNewLine = false;
				}
			}
			filteredStream.Flush();
			if (!dkimBodyFilter.LastWasNewLine)
			{
				dkimHashStream.Write(options.NewLineBytes, 0, options.NewLineBytes.Length);
			}
		}
		return dkimHashStream.GenerateHash();
	}

	[Obsolete("Use DkimSigner.Sign() instead.")]
	public void Sign(FormatOptions options, DkimSigner signer, IList<string> headers, DkimCanonicalizationAlgorithm headerCanonicalizationAlgorithm = DkimCanonicalizationAlgorithm.Simple, DkimCanonicalizationAlgorithm bodyCanonicalizationAlgorithm = DkimCanonicalizationAlgorithm.Simple)
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (signer == null)
		{
			throw new ArgumentNullException("signer");
		}
		signer.HeaderCanonicalizationAlgorithm = headerCanonicalizationAlgorithm;
		signer.BodyCanonicalizationAlgorithm = bodyCanonicalizationAlgorithm;
		signer.Sign(options, this, headers);
	}

	[Obsolete("Use DkimSigner.Sign() instead.")]
	public void Sign(DkimSigner signer, IList<string> headers, DkimCanonicalizationAlgorithm headerCanonicalizationAlgorithm = DkimCanonicalizationAlgorithm.Simple, DkimCanonicalizationAlgorithm bodyCanonicalizationAlgorithm = DkimCanonicalizationAlgorithm.Simple)
	{
		Sign(FormatOptions.Default, signer, headers, headerCanonicalizationAlgorithm, bodyCanonicalizationAlgorithm);
	}

	[Obsolete("Use DkimSigner.Sign() instead.")]
	public void Sign(FormatOptions options, DkimSigner signer, IList<HeaderId> headers, DkimCanonicalizationAlgorithm headerCanonicalizationAlgorithm = DkimCanonicalizationAlgorithm.Simple, DkimCanonicalizationAlgorithm bodyCanonicalizationAlgorithm = DkimCanonicalizationAlgorithm.Simple)
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (signer == null)
		{
			throw new ArgumentNullException("signer");
		}
		signer.HeaderCanonicalizationAlgorithm = headerCanonicalizationAlgorithm;
		signer.BodyCanonicalizationAlgorithm = bodyCanonicalizationAlgorithm;
		signer.Sign(options, this, headers);
	}

	[Obsolete("Use DkimSigner.Sign() instead.")]
	public void Sign(DkimSigner signer, IList<HeaderId> headers, DkimCanonicalizationAlgorithm headerCanonicalizationAlgorithm = DkimCanonicalizationAlgorithm.Simple, DkimCanonicalizationAlgorithm bodyCanonicalizationAlgorithm = DkimCanonicalizationAlgorithm.Simple)
	{
		Sign(FormatOptions.Default, signer, headers, headerCanonicalizationAlgorithm, bodyCanonicalizationAlgorithm);
	}

	private Task<bool> DkimVerifyAsync(FormatOptions options, Header dkimSignature, IDkimPublicKeyLocator publicKeyLocator, bool doAsync, CancellationToken cancellationToken)
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (dkimSignature == null)
		{
			throw new ArgumentNullException("dkimSignature");
		}
		if (dkimSignature.Id != HeaderId.DkimSignature)
		{
			throw new ArgumentException("The signature parameter MUST be a DKIM-Signature header.", "dkimSignature");
		}
		DkimVerifier dkimVerifier = new DkimVerifier(publicKeyLocator);
		if (doAsync)
		{
			return dkimVerifier.VerifyAsync(options, this, dkimSignature, cancellationToken);
		}
		return Task.FromResult(dkimVerifier.Verify(options, this, dkimSignature, cancellationToken));
	}

	[Obsolete("Use the DkimVerifier class instead.")]
	public bool Verify(FormatOptions options, Header dkimSignature, IDkimPublicKeyLocator publicKeyLocator, CancellationToken cancellationToken = default(CancellationToken))
	{
		return DkimVerifyAsync(options, dkimSignature, publicKeyLocator, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	[Obsolete("Use the DkimVerifier class instead.")]
	public Task<bool> VerifyAsync(FormatOptions options, Header dkimSignature, IDkimPublicKeyLocator publicKeyLocator, CancellationToken cancellationToken = default(CancellationToken))
	{
		return DkimVerifyAsync(options, dkimSignature, publicKeyLocator, doAsync: true, cancellationToken);
	}

	[Obsolete("Use the DkimVerifier class instead.")]
	public bool Verify(Header dkimSignature, IDkimPublicKeyLocator publicKeyLocator, CancellationToken cancellationToken = default(CancellationToken))
	{
		return Verify(FormatOptions.Default, dkimSignature, publicKeyLocator, cancellationToken);
	}

	[Obsolete("Use the DkimVerifier class instead.")]
	public Task<bool> VerifyAsync(Header dkimSignature, IDkimPublicKeyLocator publicKeyLocator, CancellationToken cancellationToken = default(CancellationToken))
	{
		return VerifyAsync(FormatOptions.Default, dkimSignature, publicKeyLocator, cancellationToken);
	}

	public void Sign(CryptographyContext ctx, DigestAlgorithm digestAlgo)
	{
		if (ctx == null)
		{
			throw new ArgumentNullException("ctx");
		}
		if (Body == null)
		{
			throw new InvalidOperationException("No message body has been set.");
		}
		MailboxAddress messageSigner = GetMessageSigner();
		if (messageSigner == null)
		{
			throw new InvalidOperationException("The sender has not been set.");
		}
		Body = MultipartSigned.Create(ctx, messageSigner, digestAlgo, Body);
	}

	public void Sign(CryptographyContext ctx)
	{
		Sign(ctx, DigestAlgorithm.Sha1);
	}

	public void Encrypt(CryptographyContext ctx)
	{
		if (ctx == null)
		{
			throw new ArgumentNullException("ctx");
		}
		if (Body == null)
		{
			throw new InvalidOperationException("No message body has been set.");
		}
		IList<MailboxAddress> messageRecipients = GetMessageRecipients(includeSenders: true);
		if (messageRecipients.Count == 0)
		{
			throw new InvalidOperationException("No recipients have been set.");
		}
		if (ctx is SecureMimeContext)
		{
			Body = ApplicationPkcs7Mime.Encrypt((SecureMimeContext)ctx, messageRecipients, Body);
			return;
		}
		if (ctx is OpenPgpContext)
		{
			Body = MultipartEncrypted.Encrypt((OpenPgpContext)ctx, messageRecipients, Body);
			return;
		}
		throw new ArgumentException("Unknown type of cryptography context.", "ctx");
	}

	public void SignAndEncrypt(CryptographyContext ctx, DigestAlgorithm digestAlgo)
	{
		if (ctx == null)
		{
			throw new ArgumentNullException("ctx");
		}
		if (Body == null)
		{
			throw new InvalidOperationException("No message body has been set.");
		}
		MailboxAddress messageSigner = GetMessageSigner();
		if (messageSigner == null)
		{
			throw new InvalidOperationException("The sender has not been set.");
		}
		IList<MailboxAddress> messageRecipients = GetMessageRecipients(includeSenders: true);
		if (ctx is SecureMimeContext)
		{
			Body = ApplicationPkcs7Mime.SignAndEncrypt((SecureMimeContext)ctx, messageSigner, digestAlgo, messageRecipients, Body);
			return;
		}
		if (ctx is OpenPgpContext)
		{
			Body = MultipartEncrypted.SignAndEncrypt((OpenPgpContext)ctx, messageSigner, digestAlgo, messageRecipients, Body);
			return;
		}
		throw new ArgumentException("Unknown type of cryptography context.", "ctx");
	}

	public void SignAndEncrypt(CryptographyContext ctx)
	{
		SignAndEncrypt(ctx, DigestAlgorithm.Sha1);
	}

	private IEnumerable<Header> MergeHeaders()
	{
		int mesgIndex = 0;
		int bodyIndex = 0;
		for (; mesgIndex < Headers.Count; mesgIndex++)
		{
			Header header = Headers[mesgIndex];
			if (header.Offset.HasValue)
			{
				break;
			}
			yield return header;
		}
		while (mesgIndex < Headers.Count && bodyIndex < Body.Headers.Count)
		{
			Header header2 = Body.Headers[bodyIndex];
			if (!header2.Offset.HasValue)
			{
				break;
			}
			Header header3 = Headers[mesgIndex];
			if (header3.Offset.HasValue && header3.Offset < header2.Offset)
			{
				yield return header3;
				mesgIndex++;
			}
			else
			{
				yield return header2;
				bodyIndex++;
			}
		}
		while (mesgIndex < Headers.Count)
		{
			yield return Headers[mesgIndex++];
		}
		while (bodyIndex < Body.Headers.Count)
		{
			yield return Body.Headers[bodyIndex++];
		}
	}

	private void RemoveHeader(HeaderId id)
	{
		Headers.Changed -= HeadersChanged;
		try
		{
			Headers.RemoveAll(id);
		}
		finally
		{
			Headers.Changed += HeadersChanged;
		}
	}

	private void ReplaceHeader(HeaderId id, string name, byte[] raw)
	{
		Headers.Changed -= HeadersChanged;
		try
		{
			Headers.Replace(new Header(Headers.Options, id, name, raw));
		}
		finally
		{
			Headers.Changed += HeadersChanged;
		}
	}

	private void SetHeader(string name, string value)
	{
		Headers.Changed -= HeadersChanged;
		try
		{
			Headers[name] = value;
		}
		finally
		{
			Headers.Changed += HeadersChanged;
		}
	}

	private void SerializeAddressList(HeaderId id, InternetAddressList list)
	{
		if (list.Count == 0)
		{
			RemoveHeader(id);
			return;
		}
		StringBuilder stringBuilder = new StringBuilder(" ");
		FormatOptions formatOptions = FormatOptions.Default;
		string text = id.ToHeaderName();
		int lineLength = text.Length + 2;
		list.Encode(formatOptions, stringBuilder, firstToken: true, ref lineLength);
		stringBuilder.Append(formatOptions.NewLine);
		byte[] bytes = Encoding.UTF8.GetBytes(stringBuilder.ToString());
		ReplaceHeader(id, text, bytes);
	}

	private void InternetAddressListChanged(object addrlist, EventArgs e)
	{
		InternetAddressList internetAddressList = (InternetAddressList)addrlist;
		HeaderId[] standardAddressHeaders = StandardAddressHeaders;
		foreach (HeaderId headerId in standardAddressHeaders)
		{
			if (addresses[headerId] == internetAddressList)
			{
				SerializeAddressList(headerId, internetAddressList);
				break;
			}
		}
	}

	private void ReferencesChanged(object o, EventArgs e)
	{
		if (references.Count > 0)
		{
			int num = "References".Length + 1;
			FormatOptions formatOptions = FormatOptions.Default;
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < references.Count; i++)
			{
				if (i > 0 && num + references[i].Length + 2 >= formatOptions.MaxLineLength)
				{
					stringBuilder.Append(formatOptions.NewLine);
					stringBuilder.Append('\t');
					num = 1;
				}
				else
				{
					stringBuilder.Append(' ');
					num++;
				}
				num += references[i].Length;
				stringBuilder.Append("<" + references[i] + ">");
			}
			stringBuilder.Append(formatOptions.NewLine);
			byte[] bytes = Encoding.UTF8.GetBytes(stringBuilder.ToString());
			ReplaceHeader(HeaderId.References, "References", bytes);
		}
		else
		{
			RemoveHeader(HeaderId.References);
		}
	}

	private void AddAddresses(Header header, InternetAddressList list)
	{
		int endIndex = header.RawValue.Length;
		int index = 0;
		if (InternetAddressList.TryParse(Headers.Options, header.RawValue, ref index, endIndex, isGroup: false, 0, throwOnError: false, out var list2))
		{
			list.Changed -= InternetAddressListChanged;
			list.AddRange(list2);
			list.Changed += InternetAddressListChanged;
		}
	}

	private void ReloadAddressList(HeaderId id, InternetAddressList list)
	{
		list.Changed -= InternetAddressListChanged;
		list.Clear();
		foreach (Header header in Headers)
		{
			if (header.Id == id)
			{
				int endIndex = header.RawValue.Length;
				int index = 0;
				if (InternetAddressList.TryParse(Headers.Options, header.RawValue, ref index, endIndex, isGroup: false, 0, throwOnError: false, out var list2))
				{
					list.AddRange(list2);
				}
			}
		}
		list.Changed += InternetAddressListChanged;
	}

	private void ReloadHeader(HeaderId id)
	{
		switch (id)
		{
		case HeaderId.Unknown:
			return;
		case HeaderId.ResentMessageId:
			resentMessageId = null;
			break;
		case HeaderId.ResentSender:
			resentSender = null;
			break;
		case HeaderId.ResentDate:
			resentDate = DateTimeOffset.MinValue;
			break;
		case HeaderId.References:
			references.Changed -= ReferencesChanged;
			references.Clear();
			references.Changed += ReferencesChanged;
			break;
		case HeaderId.InReplyTo:
			inreplyto = null;
			break;
		case HeaderId.MessageId:
			messageId = null;
			break;
		case HeaderId.Sender:
			sender = null;
			break;
		case HeaderId.Importance:
			importance = MessageImportance.Normal;
			break;
		case HeaderId.XPriority:
			xpriority = XMessagePriority.Normal;
			break;
		case HeaderId.Priority:
			priority = MessagePriority.Normal;
			break;
		case HeaderId.Date:
			date = DateTimeOffset.MinValue;
			break;
		}
		foreach (Header header in Headers)
		{
			if (header.Id != id)
			{
				continue;
			}
			byte[] rawValue = header.RawValue;
			int index = 0;
			switch (id)
			{
			case HeaderId.MimeVersion:
				MimeUtils.TryParse(rawValue, 0, rawValue.Length, out version);
				break;
			case HeaderId.References:
				references.Changed -= ReferencesChanged;
				foreach (string item in MimeUtils.EnumerateReferences(rawValue, 0, rawValue.Length))
				{
					references.Add(item);
				}
				references.Changed += ReferencesChanged;
				break;
			case HeaderId.InReplyTo:
				inreplyto = MimeUtils.EnumerateReferences(rawValue, 0, rawValue.Length).FirstOrDefault();
				break;
			case HeaderId.ResentMessageId:
				resentMessageId = MimeUtils.ParseMessageId(rawValue, 0, rawValue.Length);
				break;
			case HeaderId.MessageId:
				messageId = MimeUtils.ParseMessageId(rawValue, 0, rawValue.Length);
				break;
			case HeaderId.ResentSender:
				MailboxAddress.TryParse(Headers.Options, rawValue, ref index, rawValue.Length, throwOnError: false, out resentSender);
				break;
			case HeaderId.Sender:
				MailboxAddress.TryParse(Headers.Options, rawValue, ref index, rawValue.Length, throwOnError: false, out sender);
				break;
			case HeaderId.ResentDate:
				DateUtils.TryParse(rawValue, 0, rawValue.Length, out resentDate);
				break;
			case HeaderId.Importance:
			{
				string text2 = header.Value.ToLowerInvariant().Trim();
				if (!(text2 == "high"))
				{
					if (text2 == "low")
					{
						importance = MessageImportance.Low;
					}
					else
					{
						importance = MessageImportance.Normal;
					}
				}
				else
				{
					importance = MessageImportance.High;
				}
				break;
			}
			case HeaderId.Priority:
			{
				string text = header.Value.ToLowerInvariant().Trim();
				if (!(text == "non-urgent"))
				{
					if (text == "urgent")
					{
						priority = MessagePriority.Urgent;
					}
					else
					{
						priority = MessagePriority.Normal;
					}
				}
				else
				{
					priority = MessagePriority.NonUrgent;
				}
				break;
			}
			case HeaderId.XPriority:
			{
				ParseUtils.SkipWhiteSpace(rawValue, ref index, rawValue.Length);
				if (ParseUtils.TryParseInt32(rawValue, ref index, rawValue.Length, out var value))
				{
					xpriority = (XMessagePriority)Math.Min(Math.Max(value, 1), 5);
				}
				else
				{
					xpriority = XMessagePriority.Normal;
				}
				break;
			}
			case HeaderId.Date:
				DateUtils.TryParse(rawValue, 0, rawValue.Length, out date);
				break;
			}
		}
	}

	private void HeadersChanged(object o, HeaderListChangedEventArgs e)
	{
		int index = 0;
		InternetAddressList value;
		switch (e.Action)
		{
		case HeaderListChangedAction.Added:
		{
			if (addresses.TryGetValue(e.Header.Id, out value))
			{
				AddAddresses(e.Header, value);
				break;
			}
			byte[] rawValue = e.Header.RawValue;
			switch (e.Header.Id)
			{
			case HeaderId.MimeVersion:
				MimeUtils.TryParse(rawValue, 0, rawValue.Length, out version);
				break;
			case HeaderId.References:
				references.Changed -= ReferencesChanged;
				foreach (string item in MimeUtils.EnumerateReferences(rawValue, 0, rawValue.Length))
				{
					references.Add(item);
				}
				references.Changed += ReferencesChanged;
				break;
			case HeaderId.InReplyTo:
				inreplyto = MimeUtils.EnumerateReferences(rawValue, 0, rawValue.Length).FirstOrDefault();
				break;
			case HeaderId.ResentMessageId:
				resentMessageId = MimeUtils.ParseMessageId(rawValue, 0, rawValue.Length);
				break;
			case HeaderId.MessageId:
				messageId = MimeUtils.ParseMessageId(rawValue, 0, rawValue.Length);
				break;
			case HeaderId.ResentSender:
				MailboxAddress.TryParse(Headers.Options, rawValue, ref index, rawValue.Length, throwOnError: false, out resentSender);
				break;
			case HeaderId.Sender:
				MailboxAddress.TryParse(Headers.Options, rawValue, ref index, rawValue.Length, throwOnError: false, out sender);
				break;
			case HeaderId.ResentDate:
				DateUtils.TryParse(rawValue, 0, rawValue.Length, out resentDate);
				break;
			case HeaderId.Importance:
			{
				string text2 = e.Header.Value.ToLowerInvariant().Trim();
				if (!(text2 == "high"))
				{
					if (text2 == "low")
					{
						importance = MessageImportance.Low;
					}
					else
					{
						importance = MessageImportance.Normal;
					}
				}
				else
				{
					importance = MessageImportance.High;
				}
				break;
			}
			case HeaderId.Priority:
			{
				string text = e.Header.Value.ToLowerInvariant().Trim();
				if (!(text == "non-urgent"))
				{
					if (text == "urgent")
					{
						priority = MessagePriority.Urgent;
					}
					else
					{
						priority = MessagePriority.Normal;
					}
				}
				else
				{
					priority = MessagePriority.NonUrgent;
				}
				break;
			}
			case HeaderId.XPriority:
			{
				ParseUtils.SkipWhiteSpace(rawValue, ref index, rawValue.Length);
				if (ParseUtils.TryParseInt32(rawValue, ref index, rawValue.Length, out var value2))
				{
					xpriority = (XMessagePriority)Math.Min(Math.Max(value2, 1), 5);
				}
				else
				{
					xpriority = XMessagePriority.Normal;
				}
				break;
			}
			case HeaderId.Date:
				DateUtils.TryParse(rawValue, 0, rawValue.Length, out date);
				break;
			}
			break;
		}
		case HeaderListChangedAction.Changed:
		case HeaderListChangedAction.Removed:
			if (addresses.TryGetValue(e.Header.Id, out value))
			{
				ReloadAddressList(e.Header.Id, value);
			}
			else
			{
				ReloadHeader(e.Header.Id);
			}
			break;
		case HeaderListChangedAction.Cleared:
			foreach (KeyValuePair<HeaderId, InternetAddressList> address in addresses)
			{
				address.Value.Changed -= InternetAddressListChanged;
				address.Value.Clear();
				address.Value.Changed += InternetAddressListChanged;
			}
			references.Changed -= ReferencesChanged;
			references.Clear();
			references.Changed += ReferencesChanged;
			resentDate = (date = DateTimeOffset.MinValue);
			importance = MessageImportance.Normal;
			xpriority = XMessagePriority.Normal;
			priority = MessagePriority.Normal;
			resentMessageId = null;
			resentSender = null;
			inreplyto = null;
			messageId = null;
			version = null;
			sender = null;
			break;
		default:
			throw new ArgumentOutOfRangeException();
		}
	}

	public static MimeMessage Load(ParserOptions options, Stream stream, bool persistent, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (stream == null)
		{
			throw new ArgumentNullException("stream");
		}
		MimeParser mimeParser = new MimeParser(options, stream, MimeFormat.Entity, persistent);
		return mimeParser.ParseMessage(cancellationToken);
	}

	public static Task<MimeMessage> LoadAsync(ParserOptions options, Stream stream, bool persistent, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (stream == null)
		{
			throw new ArgumentNullException("stream");
		}
		MimeParser mimeParser = new MimeParser(options, stream, MimeFormat.Entity, persistent);
		return mimeParser.ParseMessageAsync(cancellationToken);
	}

	public static MimeMessage Load(ParserOptions options, Stream stream, CancellationToken cancellationToken = default(CancellationToken))
	{
		return Load(options, stream, persistent: false, cancellationToken);
	}

	public static Task<MimeMessage> LoadAsync(ParserOptions options, Stream stream, CancellationToken cancellationToken = default(CancellationToken))
	{
		return LoadAsync(options, stream, persistent: false, cancellationToken);
	}

	public static MimeMessage Load(Stream stream, bool persistent, CancellationToken cancellationToken = default(CancellationToken))
	{
		return Load(ParserOptions.Default, stream, persistent, cancellationToken);
	}

	public static Task<MimeMessage> LoadAsync(Stream stream, bool persistent, CancellationToken cancellationToken = default(CancellationToken))
	{
		return LoadAsync(ParserOptions.Default, stream, persistent, cancellationToken);
	}

	public static MimeMessage Load(Stream stream, CancellationToken cancellationToken = default(CancellationToken))
	{
		return Load(ParserOptions.Default, stream, persistent: false, cancellationToken);
	}

	public static Task<MimeMessage> LoadAsync(Stream stream, CancellationToken cancellationToken = default(CancellationToken))
	{
		return LoadAsync(ParserOptions.Default, stream, persistent: false, cancellationToken);
	}

	public static MimeMessage Load(ParserOptions options, string fileName, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (fileName == null)
		{
			throw new ArgumentNullException("fileName");
		}
		using FileStream stream = File.OpenRead(fileName);
		return Load(options, stream, cancellationToken);
	}

	public static async Task<MimeMessage> LoadAsync(ParserOptions options, string fileName, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (fileName == null)
		{
			throw new ArgumentNullException("fileName");
		}
		using FileStream stream = File.OpenRead(fileName);
		return await LoadAsync(options, stream, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
	}

	public static MimeMessage Load(string fileName, CancellationToken cancellationToken = default(CancellationToken))
	{
		return Load(ParserOptions.Default, fileName, cancellationToken);
	}

	public static Task<MimeMessage> LoadAsync(string fileName, CancellationToken cancellationToken = default(CancellationToken))
	{
		return LoadAsync(ParserOptions.Default, fileName, cancellationToken);
	}

	private static MimePart GetMimePart(AttachmentBase item)
	{
		string text = item.ContentType.ToString();
		ContentType contentType = ContentType.Parse(text);
		Attachment attachment = item as Attachment;
		MimePart mimePart = ((!contentType.MediaType.Equals("text", StringComparison.OrdinalIgnoreCase)) ? new MimePart(contentType) : new TextPart(contentType));
		if (attachment != null)
		{
			string text2 = attachment.ContentDisposition.ToString();
			mimePart.ContentDisposition = ContentDisposition.Parse(text2);
		}
		switch (item.TransferEncoding)
		{
		case TransferEncoding.QuotedPrintable:
			mimePart.ContentTransferEncoding = ContentEncoding.QuotedPrintable;
			break;
		case TransferEncoding.Base64:
			mimePart.ContentTransferEncoding = ContentEncoding.Base64;
			break;
		case TransferEncoding.SevenBit:
			mimePart.ContentTransferEncoding = ContentEncoding.SevenBit;
			break;
		}
		if (item.ContentId != null)
		{
			mimePart.ContentId = item.ContentId;
		}
		MemoryBlockStream memoryBlockStream = new MemoryBlockStream();
		if (item.ContentStream.CanSeek)
		{
			item.ContentStream.Position = 0L;
		}
		item.ContentStream.CopyTo(memoryBlockStream);
		memoryBlockStream.Position = 0L;
		mimePart.Content = new MimeContent(memoryBlockStream);
		return mimePart;
	}

	public static MimeMessage CreateFromMailMessage(MailMessage message)
	{
		if (message == null)
		{
			throw new ArgumentNullException("message");
		}
		List<Header> list = new List<Header>();
		string[] allKeys = message.Headers.AllKeys;
		foreach (string text in allKeys)
		{
			string[] values = message.Headers.GetValues(text);
			foreach (string value in values)
			{
				list.Add(new Header(text, value));
			}
		}
		MimeMessage mimeMessage = new MimeMessage(ParserOptions.Default, list, RfcComplianceMode.Strict);
		MimeEntity mimeEntity = null;
		if (message.Sender != null)
		{
			mimeMessage.Sender = (MailboxAddress)message.Sender;
		}
		if (message.From != null)
		{
			mimeMessage.Headers.Replace(HeaderId.From, string.Empty);
			mimeMessage.From.Add((MailboxAddress)message.From);
		}
		if (message.ReplyToList.Count > 0)
		{
			mimeMessage.Headers.Replace(HeaderId.ReplyTo, string.Empty);
			mimeMessage.ReplyTo.AddRange((InternetAddressList)message.ReplyToList);
		}
		if (message.To.Count > 0)
		{
			mimeMessage.Headers.Replace(HeaderId.To, string.Empty);
			mimeMessage.To.AddRange((InternetAddressList)message.To);
		}
		if (message.CC.Count > 0)
		{
			mimeMessage.Headers.Replace(HeaderId.Cc, string.Empty);
			mimeMessage.Cc.AddRange((InternetAddressList)message.CC);
		}
		if (message.Bcc.Count > 0)
		{
			mimeMessage.Headers.Replace(HeaderId.Bcc, string.Empty);
			mimeMessage.Bcc.AddRange((InternetAddressList)message.Bcc);
		}
		if (message.SubjectEncoding != null)
		{
			mimeMessage.Headers.Replace(HeaderId.Subject, message.SubjectEncoding, message.Subject ?? string.Empty);
		}
		else
		{
			mimeMessage.Subject = message.Subject ?? string.Empty;
		}
		if (!mimeMessage.Headers.Contains(HeaderId.Date))
		{
			mimeMessage.Date = DateTimeOffset.Now;
		}
		switch (message.Priority)
		{
		case MailPriority.Normal:
			mimeMessage.Headers.RemoveAll(HeaderId.XMSMailPriority);
			mimeMessage.Headers.RemoveAll(HeaderId.Importance);
			mimeMessage.Headers.RemoveAll(HeaderId.XPriority);
			mimeMessage.Headers.RemoveAll(HeaderId.Priority);
			break;
		case MailPriority.High:
			mimeMessage.Headers.Replace(HeaderId.Priority, "urgent");
			mimeMessage.Headers.Replace(HeaderId.Importance, "high");
			mimeMessage.Headers.Replace(HeaderId.XPriority, "2 (High)");
			break;
		case MailPriority.Low:
			mimeMessage.Headers.Replace(HeaderId.Priority, "non-urgent");
			mimeMessage.Headers.Replace(HeaderId.Importance, "low");
			mimeMessage.Headers.Replace(HeaderId.XPriority, "4 (Low)");
			break;
		}
		if (!string.IsNullOrEmpty(message.Body))
		{
			TextPart textPart = new TextPart(message.IsBodyHtml ? "html" : "plain");
			textPart.SetText(message.BodyEncoding ?? Encoding.UTF8, message.Body);
			mimeEntity = textPart;
		}
		if (message.AlternateViews.Count > 0)
		{
			MultipartAlternative multipartAlternative = new MultipartAlternative();
			if (mimeEntity != null)
			{
				multipartAlternative.Add(mimeEntity);
			}
			foreach (AlternateView alternateView in message.AlternateViews)
			{
				MimePart mimePart = GetMimePart(alternateView);
				if (alternateView.LinkedResources.Count > 0)
				{
					string value2 = mimePart.ContentType.MediaType + "/" + mimePart.ContentType.MediaSubtype;
					MultipartRelated multipartRelated = new MultipartRelated();
					multipartRelated.ContentType.Parameters.Add("type", value2);
					multipartRelated.ContentBase = alternateView.BaseUri;
					multipartRelated.Add(mimePart);
					foreach (LinkedResource linkedResource in alternateView.LinkedResources)
					{
						mimePart = GetMimePart(linkedResource);
						if (linkedResource.ContentLink != null)
						{
							mimePart.ContentLocation = linkedResource.ContentLink;
						}
						multipartRelated.Add(mimePart);
					}
					multipartAlternative.Add(multipartRelated);
				}
				else
				{
					mimePart.ContentBase = alternateView.BaseUri;
					multipartAlternative.Add(mimePart);
				}
			}
			mimeEntity = multipartAlternative;
		}
		if (mimeEntity == null)
		{
			mimeEntity = new TextPart(message.IsBodyHtml ? "html" : "plain");
		}
		if (message.Attachments.Count > 0)
		{
			Multipart multipart = new Multipart("mixed");
			if (mimeEntity != null)
			{
				multipart.Add(mimeEntity);
			}
			foreach (Attachment attachment in message.Attachments)
			{
				multipart.Add(GetMimePart(attachment));
			}
			mimeEntity = multipart;
		}
		mimeMessage.Body = mimeEntity;
		return mimeMessage;
	}

	public static explicit operator MimeMessage(MailMessage message)
	{
		if (message == null)
		{
			return null;
		}
		return CreateFromMailMessage(message);
	}
}
