using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MimeKit.Encodings;
using MimeKit.IO;
using MimeKit.IO.Filters;
using MimeKit.Utils;

namespace MimeKit;

public class MimePart : MimeEntity
{
	private static readonly string[] ContentTransferEncodings = new string[7] { null, "7bit", "8bit", "binary", "base64", "quoted-printable", "x-uuencode" };

	private ContentEncoding encoding;

	private string md5sum;

	private int? duration;

	public int? ContentDuration
	{
		get
		{
			return duration;
		}
		set
		{
			if (duration != value)
			{
				if (value.HasValue && value.Value < 0)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				duration = value;
				if (value.HasValue)
				{
					SetHeader("Content-Duration", value.Value.ToString());
				}
				else
				{
					RemoveHeader("Content-Duration");
				}
			}
		}
	}

	public string ContentMd5
	{
		get
		{
			return md5sum;
		}
		set
		{
			if (!(md5sum == value))
			{
				md5sum = value?.Trim();
				if (value != null)
				{
					SetHeader("Content-Md5", md5sum);
				}
				else
				{
					RemoveHeader("Content-Md5");
				}
			}
		}
	}

	public ContentEncoding ContentTransferEncoding
	{
		get
		{
			return encoding;
		}
		set
		{
			if (encoding != value)
			{
				if (value < ContentEncoding.Default || (int)value >= ContentTransferEncodings.Length)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				string text = ContentTransferEncodings[(int)value];
				encoding = value;
				if (text != null)
				{
					SetHeader("Content-Transfer-Encoding", text);
				}
				else
				{
					RemoveHeader("Content-Transfer-Encoding");
				}
			}
		}
	}

	public string FileName
	{
		get
		{
			string text = null;
			if (base.ContentDisposition != null)
			{
				text = base.ContentDisposition.FileName;
			}
			if (text == null)
			{
				text = base.ContentType.Name;
			}
			return text?.Trim();
		}
		set
		{
			if (value != null)
			{
				if (base.ContentDisposition == null)
				{
					base.ContentDisposition = new ContentDisposition("attachment");
				}
				base.ContentDisposition.FileName = value;
			}
			else if (base.ContentDisposition != null)
			{
				base.ContentDisposition.FileName = value;
			}
			base.ContentType.Name = value;
		}
	}

	public IMimeContent Content { get; set; }

	[Obsolete("Use the Content property instead.")]
	public IMimeContent ContentObject
	{
		get
		{
			return Content;
		}
		set
		{
			Content = value;
		}
	}

	public MimePart(MimeEntityConstructorArgs args)
		: base(args)
	{
	}

	public MimePart(string mediaType, string mediaSubtype, params object[] args)
		: this(mediaType, mediaSubtype)
	{
		if (args == null)
		{
			throw new ArgumentNullException("args");
		}
		IMimeContent mimeContent = null;
		foreach (object obj in args)
		{
			if (obj == null || TryInit(obj))
			{
				continue;
			}
			if (obj is IMimeContent mimeContent2)
			{
				if (mimeContent != null)
				{
					throw new ArgumentException("IMimeContent should not be specified more than once.");
				}
				mimeContent = mimeContent2;
				continue;
			}
			if (obj is Stream stream)
			{
				if (mimeContent != null)
				{
					throw new ArgumentException("Stream (used as content) should not be specified more than once.");
				}
				mimeContent = new MimeContent(stream);
				continue;
			}
			throw new ArgumentException("Unknown initialization parameter: " + obj.GetType());
		}
		if (mimeContent != null)
		{
			Content = mimeContent;
		}
	}

	public MimePart(string mediaType, string mediaSubtype)
		: base(mediaType, mediaSubtype)
	{
	}

	public MimePart(ContentType contentType)
		: base(contentType)
	{
	}

	public MimePart(string contentType)
		: base(ContentType.Parse(contentType))
	{
	}

	public MimePart()
		: this("application", "octet-stream")
	{
	}

	public override void Accept(MimeVisitor visitor)
	{
		if (visitor == null)
		{
			throw new ArgumentNullException("visitor");
		}
		visitor.VisitMimePart(this);
	}

	public ContentEncoding GetBestEncoding(EncodingConstraint constraint, CancellationToken cancellationToken = default(CancellationToken))
	{
		return GetBestEncoding(constraint, 78, cancellationToken);
	}

	public ContentEncoding GetBestEncoding(EncodingConstraint constraint, int maxLineLength, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (base.ContentType.IsMimeType("text", "*") || base.ContentType.IsMimeType("message", "*"))
		{
			if (Content == null)
			{
				return ContentEncoding.SevenBit;
			}
			using MeasuringStream source = new MeasuringStream();
			using FilteredStream filteredStream = new FilteredStream(source);
			BestEncodingFilter bestEncodingFilter = new BestEncodingFilter();
			filteredStream.Add(bestEncodingFilter);
			Content.DecodeTo(filteredStream, cancellationToken);
			filteredStream.Flush();
			return bestEncodingFilter.GetBestEncoding(constraint, maxLineLength);
		}
		if (constraint != EncodingConstraint.None)
		{
			return ContentEncoding.Base64;
		}
		return ContentEncoding.Binary;
	}

	public string ComputeContentMd5()
	{
		if (Content == null)
		{
			throw new InvalidOperationException("Cannot compute Md5 checksum without a ContentObject.");
		}
		using Stream source = Content.Open();
		byte[] array;
		using (FilteredStream filteredStream = new FilteredStream(source))
		{
			if (base.ContentType.IsMimeType("text", "*"))
			{
				filteredStream.Add(new Unix2DosFilter());
			}
			using MD5 mD = MD5.Create();
			array = mD.ComputeHash(filteredStream);
		}
		Base64Encoder base64Encoder = new Base64Encoder(rfc2047: true);
		byte[] array2 = new byte[base64Encoder.EstimateOutputLength(array.Length)];
		int count = base64Encoder.Flush(array, 0, array.Length, array2);
		return Encoding.ASCII.GetString(array2, 0, count);
	}

	private static bool IsNullOrWhiteSpace(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return true;
		}
		for (int i = 0; i < value.Length; i++)
		{
			if (!char.IsWhiteSpace(value[i]))
			{
				return false;
			}
		}
		return true;
	}

	public bool VerifyContentMd5()
	{
		if (IsNullOrWhiteSpace(md5sum) || Content == null)
		{
			return false;
		}
		return md5sum == ComputeContentMd5();
	}

	public override void Prepare(EncodingConstraint constraint, int maxLineLength = 78)
	{
		if (maxLineLength < 60 || maxLineLength > 998)
		{
			throw new ArgumentOutOfRangeException("maxLineLength");
		}
		switch (ContentTransferEncoding)
		{
		case ContentEncoding.Base64:
		case ContentEncoding.QuotedPrintable:
		case ContentEncoding.UUEncode:
			return;
		case ContentEncoding.Binary:
			if (constraint == EncodingConstraint.None)
			{
				return;
			}
			break;
		}
		ContentEncoding bestEncoding = GetBestEncoding(constraint, maxLineLength);
		if (ContentTransferEncoding != ContentEncoding.Default || bestEncoding != ContentEncoding.SevenBit)
		{
			ContentTransferEncoding = bestEncoding;
		}
	}

	public override void WriteTo(FormatOptions options, Stream stream, bool contentOnly, CancellationToken cancellationToken = default(CancellationToken))
	{
		base.WriteTo(options, stream, contentOnly, cancellationToken);
		if (Content == null)
		{
			return;
		}
		ICancellableStream cancellableStream = stream as ICancellableStream;
		if (Content.Encoding != encoding)
		{
			if (encoding == ContentEncoding.UUEncode)
			{
				string s = string.Format("begin 0644 {0}", FileName ?? "unknown");
				byte[] bytes = Encoding.UTF8.GetBytes(s);
				if (cancellableStream != null)
				{
					cancellableStream.Write(bytes, 0, bytes.Length, cancellationToken);
					cancellableStream.Write(options.NewLineBytes, 0, options.NewLineBytes.Length, cancellationToken);
				}
				else
				{
					cancellationToken.ThrowIfCancellationRequested();
					stream.Write(bytes, 0, bytes.Length);
					stream.Write(options.NewLineBytes, 0, options.NewLineBytes.Length);
				}
			}
			using (FilteredStream filteredStream = new FilteredStream(stream))
			{
				filteredStream.Add(EncoderFilter.Create(encoding));
				if (encoding != ContentEncoding.Binary)
				{
					filteredStream.Add(options.CreateNewLineFilter(EnsureNewLine));
				}
				Content.DecodeTo(filteredStream, cancellationToken);
				filteredStream.Flush(cancellationToken);
			}
			if (encoding == ContentEncoding.UUEncode)
			{
				byte[] bytes2 = Encoding.ASCII.GetBytes("end");
				if (cancellableStream != null)
				{
					cancellableStream.Write(bytes2, 0, bytes2.Length, cancellationToken);
					cancellableStream.Write(options.NewLineBytes, 0, options.NewLineBytes.Length, cancellationToken);
				}
				else
				{
					cancellationToken.ThrowIfCancellationRequested();
					stream.Write(bytes2, 0, bytes2.Length);
					stream.Write(options.NewLineBytes, 0, options.NewLineBytes.Length);
				}
			}
			return;
		}
		if (encoding == ContentEncoding.Binary)
		{
			Content.WriteTo(stream, cancellationToken);
			return;
		}
		if (options.VerifyingSignature && Content.NewLineFormat.HasValue && Content.NewLineFormat.Value == NewLineFormat.Mixed)
		{
			Content.WriteTo(stream, cancellationToken);
			return;
		}
		using FilteredStream filteredStream2 = new FilteredStream(stream);
		filteredStream2.Add(options.CreateNewLineFilter(EnsureNewLine));
		Content.WriteTo(filteredStream2, cancellationToken);
		filteredStream2.Flush(cancellationToken);
	}

	public override async Task WriteToAsync(FormatOptions options, Stream stream, bool contentOnly, CancellationToken cancellationToken = default(CancellationToken))
	{
		await base.WriteToAsync(options, stream, contentOnly, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		if (Content == null)
		{
			return;
		}
		if (!base.ContentType.IsMimeType("text", "*"))
		{
			base.ContentType.IsMimeType("message", "*");
		}
		if (Content.Encoding != encoding)
		{
			if (encoding == ContentEncoding.UUEncode)
			{
				string s = string.Format("begin 0644 {0}", FileName ?? "unknown");
				byte[] bytes = Encoding.UTF8.GetBytes(s);
				await stream.WriteAsync(bytes, 0, bytes.Length, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				await stream.WriteAsync(options.NewLineBytes, 0, options.NewLineBytes.Length, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			}
			using (FilteredStream filtered = new FilteredStream(stream))
			{
				filtered.Add(EncoderFilter.Create(encoding));
				if (encoding != ContentEncoding.Binary)
				{
					filtered.Add(options.CreateNewLineFilter(EnsureNewLine));
				}
				await Content.DecodeToAsync(filtered, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				await filtered.FlushAsync(cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			}
			if (encoding == ContentEncoding.UUEncode)
			{
				byte[] bytes2 = Encoding.ASCII.GetBytes("end");
				await stream.WriteAsync(bytes2, 0, bytes2.Length, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				await stream.WriteAsync(options.NewLineBytes, 0, options.NewLineBytes.Length, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			}
		}
		else if (encoding == ContentEncoding.Binary)
		{
			await Content.WriteToAsync(stream, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		else if (options.VerifyingSignature && Content.NewLineFormat.HasValue && Content.NewLineFormat.Value == NewLineFormat.Mixed)
		{
			await Content.WriteToAsync(stream, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		else
		{
			using FilteredStream filtered = new FilteredStream(stream);
			filtered.Add(options.CreateNewLineFilter(EnsureNewLine));
			await Content.WriteToAsync(filtered, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			await filtered.FlushAsync(cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
	}

	protected override void OnHeadersChanged(HeaderListChangedAction action, Header header)
	{
		base.OnHeadersChanged(action, header);
		switch (action)
		{
		case HeaderListChangedAction.Added:
		case HeaderListChangedAction.Changed:
			switch (header.Id)
			{
			case HeaderId.ContentTransferEncoding:
				MimeUtils.TryParse(header.Value, out encoding);
				break;
			case HeaderId.ContentDuration:
			{
				if (int.TryParse(header.Value, out var result))
				{
					duration = result;
				}
				else
				{
					duration = null;
				}
				break;
			}
			case HeaderId.ContentMd5:
				md5sum = header.Value.Trim();
				break;
			}
			break;
		case HeaderListChangedAction.Removed:
			switch (header.Id)
			{
			case HeaderId.ContentTransferEncoding:
				encoding = ContentEncoding.Default;
				break;
			case HeaderId.ContentDuration:
				duration = null;
				break;
			case HeaderId.ContentMd5:
				md5sum = null;
				break;
			}
			break;
		case HeaderListChangedAction.Cleared:
			encoding = ContentEncoding.Default;
			duration = null;
			md5sum = null;
			break;
		default:
			throw new ArgumentOutOfRangeException("action");
		}
	}
}
