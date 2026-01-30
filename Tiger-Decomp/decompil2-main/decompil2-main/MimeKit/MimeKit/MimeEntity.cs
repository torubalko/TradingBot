using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MimeKit.IO;
using MimeKit.Utils;

namespace MimeKit;

public abstract class MimeEntity
{
	internal bool EnsureNewLine;

	private ContentDisposition disposition;

	private string contentId;

	private Uri location;

	private Uri baseUri;

	public HeaderList Headers { get; private set; }

	public ContentDisposition ContentDisposition
	{
		get
		{
			return disposition;
		}
		set
		{
			if (disposition != value)
			{
				if (disposition != null)
				{
					disposition.Changed -= ContentDispositionChanged;
					RemoveHeader("Content-Disposition");
				}
				disposition = value;
				if (disposition != null)
				{
					disposition.Changed += ContentDispositionChanged;
					SerializeContentDisposition();
				}
			}
		}
	}

	public ContentType ContentType { get; private set; }

	public Uri ContentBase
	{
		get
		{
			return baseUri;
		}
		set
		{
			if (!(baseUri == value))
			{
				if (value != null && !value.IsAbsoluteUri)
				{
					throw new ArgumentException("The Content-Base URI may only be set to an absolute URI.", "value");
				}
				baseUri = value;
				if (value != null)
				{
					SetHeader("Content-Base", value.ToString());
				}
				else
				{
					RemoveHeader("Content-Base");
				}
			}
		}
	}

	public Uri ContentLocation
	{
		get
		{
			return location;
		}
		set
		{
			if (!(location == value))
			{
				location = value;
				if (value != null)
				{
					SetHeader("Content-Location", value.ToString());
				}
				else
				{
					RemoveHeader("Content-Location");
				}
			}
		}
	}

	public string ContentId
	{
		get
		{
			return contentId;
		}
		set
		{
			if (contentId == value)
			{
				return;
			}
			if (value == null)
			{
				RemoveHeader("Content-Id");
				contentId = null;
				return;
			}
			byte[] bytes = Encoding.UTF8.GetBytes(value);
			int index = 0;
			if (!ParseUtils.TryParseMsgId(bytes, ref index, bytes.Length, requireAngleAddr: false, throwOnError: false, out var msgid))
			{
				throw new ArgumentException("Invalid Content-Id format.", "value");
			}
			contentId = msgid;
			SetHeader("Content-Id", "<" + contentId + ">");
		}
	}

	public bool IsAttachment
	{
		get
		{
			if (ContentDisposition != null)
			{
				return ContentDisposition.IsAttachment;
			}
			return false;
		}
		set
		{
			if (value)
			{
				if (ContentDisposition == null)
				{
					ContentDisposition = new ContentDisposition("attachment");
				}
				else if (!ContentDisposition.IsAttachment)
				{
					ContentDisposition.Disposition = "attachment";
				}
			}
			else if (ContentDisposition != null && ContentDisposition.IsAttachment)
			{
				ContentDisposition.Disposition = "inline";
			}
		}
	}

	protected MimeEntity(MimeEntityConstructorArgs args)
	{
		if (args == null)
		{
			throw new ArgumentNullException("args");
		}
		Headers = new HeaderList(args.ParserOptions);
		ContentType = args.ContentType;
		ContentType.Changed += ContentTypeChanged;
		Headers.Changed += HeadersChanged;
		foreach (Header header in args.Headers)
		{
			if (!args.IsTopLevel || header.Field.StartsWith("Content-", StringComparison.OrdinalIgnoreCase))
			{
				Headers.Add(header);
			}
		}
	}

	protected MimeEntity(string mediaType, string mediaSubtype)
		: this(new ContentType(mediaType, mediaSubtype))
	{
	}

	protected MimeEntity(ContentType contentType)
	{
		if (contentType == null)
		{
			throw new ArgumentNullException("contentType");
		}
		Headers = new HeaderList();
		ContentType = contentType;
		ContentType.Changed += ContentTypeChanged;
		Headers.Changed += HeadersChanged;
		SerializeContentType();
	}

	protected bool TryInit(object obj)
	{
		if (obj is Header header)
		{
			Headers.Add(header);
			return true;
		}
		if (obj is IEnumerable<Header> enumerable)
		{
			foreach (Header item in enumerable)
			{
				Headers.Add(item);
			}
			return true;
		}
		return false;
	}

	public override string ToString()
	{
		using MemoryStream memoryStream = new MemoryStream();
		memoryStream.Write(FormatOptions.Default.NewLineBytes, 0, FormatOptions.Default.NewLineBytes.Length);
		WriteTo(memoryStream);
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
		visitor.VisitMimeEntity(this);
	}

	public abstract void Prepare(EncodingConstraint constraint, int maxLineLength = 78);

	public virtual void WriteTo(FormatOptions options, Stream stream, bool contentOnly, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (stream == null)
		{
			throw new ArgumentNullException("stream");
		}
		if (!contentOnly)
		{
			Headers.WriteTo(options, stream, cancellationToken);
		}
	}

	public virtual Task WriteToAsync(FormatOptions options, Stream stream, bool contentOnly, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (stream == null)
		{
			throw new ArgumentNullException("stream");
		}
		if (!contentOnly)
		{
			return Headers.WriteToAsync(options, stream, cancellationToken);
		}
		return Task.FromResult(0);
	}

	public void WriteTo(FormatOptions options, Stream stream, CancellationToken cancellationToken = default(CancellationToken))
	{
		WriteTo(options, stream, contentOnly: false, cancellationToken);
	}

	public Task WriteToAsync(FormatOptions options, Stream stream, CancellationToken cancellationToken = default(CancellationToken))
	{
		return WriteToAsync(options, stream, contentOnly: false, cancellationToken);
	}

	public void WriteTo(Stream stream, bool contentOnly, CancellationToken cancellationToken = default(CancellationToken))
	{
		WriteTo(FormatOptions.Default, stream, contentOnly, cancellationToken);
	}

	public Task WriteToAsync(Stream stream, bool contentOnly, CancellationToken cancellationToken = default(CancellationToken))
	{
		return WriteToAsync(FormatOptions.Default, stream, contentOnly, cancellationToken);
	}

	public void WriteTo(Stream stream, CancellationToken cancellationToken = default(CancellationToken))
	{
		WriteTo(FormatOptions.Default, stream, contentOnly: false, cancellationToken);
	}

	public Task WriteToAsync(Stream stream, CancellationToken cancellationToken = default(CancellationToken))
	{
		return WriteToAsync(FormatOptions.Default, stream, contentOnly: false, cancellationToken);
	}

	public void WriteTo(FormatOptions options, string fileName, bool contentOnly, CancellationToken cancellationToken = default(CancellationToken))
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
		WriteTo(options, stream, contentOnly, cancellationToken);
	}

	public async Task WriteToAsync(FormatOptions options, string fileName, bool contentOnly, CancellationToken cancellationToken = default(CancellationToken))
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
		await WriteToAsync(options, stream, contentOnly, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
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
		WriteTo(options, fileStream, contentOnly: false, cancellationToken);
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
		await WriteToAsync(options, stream, contentOnly: false, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		await stream.FlushAsync(cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
	}

	public void WriteTo(string fileName, bool contentOnly, CancellationToken cancellationToken = default(CancellationToken))
	{
		WriteTo(FormatOptions.Default, fileName, contentOnly, cancellationToken);
	}

	public Task WriteToAsync(string fileName, bool contentOnly, CancellationToken cancellationToken = default(CancellationToken))
	{
		return WriteToAsync(FormatOptions.Default, fileName, contentOnly, cancellationToken);
	}

	public void WriteTo(string fileName, CancellationToken cancellationToken = default(CancellationToken))
	{
		WriteTo(FormatOptions.Default, fileName, cancellationToken);
	}

	public Task WriteToAsync(string fileName, CancellationToken cancellationToken = default(CancellationToken))
	{
		return WriteToAsync(FormatOptions.Default, fileName, cancellationToken);
	}

	protected void RemoveHeader(string name)
	{
		Headers.Changed -= HeadersChanged;
		try
		{
			Headers.RemoveAll(name);
		}
		finally
		{
			Headers.Changed += HeadersChanged;
		}
	}

	protected void SetHeader(string name, string value)
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

	protected void SetHeader(string name, byte[] rawValue)
	{
		Header header = new Header(Headers.Options, name.ToHeaderId(), name, rawValue);
		Headers.Changed -= HeadersChanged;
		try
		{
			Headers.Replace(header);
		}
		finally
		{
			Headers.Changed += HeadersChanged;
		}
	}

	private void SerializeContentDisposition()
	{
		string s = disposition.Encode(FormatOptions.Default, Encoding.UTF8);
		byte[] bytes = Encoding.UTF8.GetBytes(s);
		SetHeader("Content-Disposition", bytes);
	}

	private void SerializeContentType()
	{
		string s = ContentType.Encode(FormatOptions.Default, Encoding.UTF8);
		byte[] bytes = Encoding.UTF8.GetBytes(s);
		SetHeader("Content-Type", bytes);
	}

	private void ContentDispositionChanged(object sender, EventArgs e)
	{
		SerializeContentDisposition();
	}

	private void ContentTypeChanged(object sender, EventArgs e)
	{
		SerializeContentType();
	}

	protected virtual void OnHeadersChanged(HeaderListChangedAction action, Header header)
	{
		int index = 0;
		switch (action)
		{
		case HeaderListChangedAction.Added:
		case HeaderListChangedAction.Changed:
			switch (header.Id)
			{
			case HeaderId.ContentDisposition:
				if (disposition != null)
				{
					disposition.Changed -= ContentDispositionChanged;
				}
				if (ContentDisposition.TryParse(Headers.Options, header.RawValue, out disposition))
				{
					disposition.Changed += ContentDispositionChanged;
				}
				break;
			case HeaderId.ContentLocation:
			{
				string uriString = header.Value.Trim();
				if (Uri.IsWellFormedUriString(uriString, UriKind.Absolute))
				{
					location = new Uri(uriString, UriKind.Absolute);
				}
				else if (Uri.IsWellFormedUriString(uriString, UriKind.Relative))
				{
					location = new Uri(uriString, UriKind.Relative);
				}
				else
				{
					location = null;
				}
				break;
			}
			case HeaderId.ContentBase:
			{
				string uriString = header.Value.Trim();
				if (Uri.IsWellFormedUriString(uriString, UriKind.Absolute))
				{
					baseUri = new Uri(uriString, UriKind.Absolute);
				}
				else
				{
					baseUri = null;
				}
				break;
			}
			case HeaderId.ContentId:
			{
				if (ParseUtils.TryParseMsgId(header.RawValue, ref index, header.RawValue.Length, requireAngleAddr: false, throwOnError: false, out var msgid))
				{
					contentId = msgid;
				}
				else
				{
					contentId = null;
				}
				break;
			}
			}
			break;
		case HeaderListChangedAction.Removed:
			switch (header.Id)
			{
			case HeaderId.ContentDisposition:
				if (disposition != null)
				{
					disposition.Changed -= ContentDispositionChanged;
				}
				disposition = null;
				break;
			case HeaderId.ContentLocation:
				location = null;
				break;
			case HeaderId.ContentBase:
				baseUri = null;
				break;
			case HeaderId.ContentId:
				contentId = null;
				break;
			}
			break;
		case HeaderListChangedAction.Cleared:
			if (disposition != null)
			{
				disposition.Changed -= ContentDispositionChanged;
			}
			disposition = null;
			contentId = null;
			location = null;
			baseUri = null;
			break;
		default:
			throw new ArgumentOutOfRangeException("action");
		}
	}

	private void HeadersChanged(object sender, HeaderListChangedEventArgs e)
	{
		OnHeadersChanged(e.Action, e.Header);
	}

	public static MimeEntity Load(ParserOptions options, Stream stream, bool persistent, CancellationToken cancellationToken = default(CancellationToken))
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
		return mimeParser.ParseEntity(cancellationToken);
	}

	public static Task<MimeEntity> LoadAsync(ParserOptions options, Stream stream, bool persistent, CancellationToken cancellationToken = default(CancellationToken))
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
		return mimeParser.ParseEntityAsync(cancellationToken);
	}

	public static MimeEntity Load(ParserOptions options, Stream stream, CancellationToken cancellationToken = default(CancellationToken))
	{
		return Load(options, stream, persistent: false, cancellationToken);
	}

	public static Task<MimeEntity> LoadAsync(ParserOptions options, Stream stream, CancellationToken cancellationToken = default(CancellationToken))
	{
		return LoadAsync(options, stream, persistent: false, cancellationToken);
	}

	public static MimeEntity Load(Stream stream, bool persistent, CancellationToken cancellationToken = default(CancellationToken))
	{
		return Load(ParserOptions.Default, stream, persistent, cancellationToken);
	}

	public static Task<MimeEntity> LoadAsync(Stream stream, bool persistent, CancellationToken cancellationToken = default(CancellationToken))
	{
		return LoadAsync(ParserOptions.Default, stream, persistent, cancellationToken);
	}

	public static MimeEntity Load(Stream stream, CancellationToken cancellationToken = default(CancellationToken))
	{
		return Load(ParserOptions.Default, stream, persistent: false, cancellationToken);
	}

	public static Task<MimeEntity> LoadAsync(Stream stream, CancellationToken cancellationToken = default(CancellationToken))
	{
		return LoadAsync(ParserOptions.Default, stream, persistent: false, cancellationToken);
	}

	public static MimeEntity Load(ParserOptions options, string fileName, CancellationToken cancellationToken = default(CancellationToken))
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

	public static async Task<MimeEntity> LoadAsync(ParserOptions options, string fileName, CancellationToken cancellationToken = default(CancellationToken))
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

	public static MimeEntity Load(string fileName, CancellationToken cancellationToken = default(CancellationToken))
	{
		return Load(ParserOptions.Default, fileName, cancellationToken);
	}

	public static Task<MimeEntity> LoadAsync(string fileName, CancellationToken cancellationToken = default(CancellationToken))
	{
		return LoadAsync(ParserOptions.Default, fileName, cancellationToken);
	}

	public static MimeEntity Load(ParserOptions options, ContentType contentType, Stream content, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (contentType == null)
		{
			throw new ArgumentNullException("contentType");
		}
		if (content == null)
		{
			throw new ArgumentNullException("content");
		}
		FormatOptions formatOptions = FormatOptions.CloneDefault();
		formatOptions.NewLineFormat = NewLineFormat.Dos;
		string arg = contentType.Encode(formatOptions, Encoding.UTF8);
		string s = $"Content-Type:{arg}\r\n";
		ChainedStream chainedStream = new ChainedStream();
		chainedStream.Add(new MemoryStream(Encoding.UTF8.GetBytes(s), writable: false));
		chainedStream.Add(content);
		return Load(options, chainedStream, cancellationToken);
	}

	public static Task<MimeEntity> LoadAsync(ParserOptions options, ContentType contentType, Stream content, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (contentType == null)
		{
			throw new ArgumentNullException("contentType");
		}
		if (content == null)
		{
			throw new ArgumentNullException("content");
		}
		FormatOptions formatOptions = FormatOptions.CloneDefault();
		formatOptions.NewLineFormat = NewLineFormat.Dos;
		string arg = contentType.Encode(formatOptions, Encoding.UTF8);
		string s = $"Content-Type:{arg}\r\n";
		ChainedStream chainedStream = new ChainedStream();
		chainedStream.Add(new MemoryStream(Encoding.UTF8.GetBytes(s), writable: false));
		chainedStream.Add(content);
		return LoadAsync(options, chainedStream, cancellationToken);
	}

	public static MimeEntity Load(ContentType contentType, Stream content, CancellationToken cancellationToken = default(CancellationToken))
	{
		return Load(ParserOptions.Default, contentType, content, cancellationToken);
	}

	public static Task<MimeEntity> LoadAsync(ContentType contentType, Stream content, CancellationToken cancellationToken = default(CancellationToken))
	{
		return LoadAsync(ParserOptions.Default, contentType, content, cancellationToken);
	}
}
