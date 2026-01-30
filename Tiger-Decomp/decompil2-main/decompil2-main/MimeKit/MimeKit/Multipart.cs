using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MimeKit.Encodings;
using MimeKit.IO;
using MimeKit.IO.Filters;
using MimeKit.Utils;

namespace MimeKit;

public class Multipart : MimeEntity, ICollection<MimeEntity>, IEnumerable<MimeEntity>, IEnumerable, IList<MimeEntity>
{
	private readonly List<MimeEntity> children;

	private string preamble;

	private string epilogue;

	public string Boundary
	{
		get
		{
			return base.ContentType.Boundary;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (!(Boundary == value))
			{
				base.ContentType.Boundary = value.Trim();
			}
		}
	}

	internal byte[] RawPreamble { get; set; }

	public string Preamble
	{
		get
		{
			if (preamble == null && RawPreamble != null)
			{
				preamble = CharsetUtils.ConvertToUnicode(base.Headers.Options, RawPreamble, 0, RawPreamble.Length);
			}
			return preamble;
		}
		set
		{
			if (!(Preamble == value))
			{
				if (value != null)
				{
					string s = FoldPreambleOrEpilogue(FormatOptions.Default, value, isEpilogue: false);
					RawPreamble = Encoding.UTF8.GetBytes(s);
					preamble = s;
				}
				else
				{
					RawPreamble = null;
					preamble = null;
				}
				WriteEndBoundary = true;
			}
		}
	}

	internal byte[] RawEpilogue { get; set; }

	public string Epilogue
	{
		get
		{
			if (epilogue == null && RawEpilogue != null)
			{
				int num = 0;
				if (RawEpilogue.Length > 1 && RawEpilogue[0] == 13 && RawEpilogue[1] == 10)
				{
					num += 2;
				}
				else if (RawEpilogue.Length > 1 && RawEpilogue[0] == 10)
				{
					num++;
				}
				epilogue = CharsetUtils.ConvertToUnicode(base.Headers.Options, RawEpilogue, num, RawEpilogue.Length - num);
			}
			return epilogue;
		}
		set
		{
			if (!(Epilogue == value))
			{
				if (value != null)
				{
					string s = FoldPreambleOrEpilogue(FormatOptions.Default, value, isEpilogue: true);
					RawEpilogue = Encoding.UTF8.GetBytes(s);
					epilogue = null;
				}
				else
				{
					RawEpilogue = null;
					epilogue = null;
				}
				WriteEndBoundary = true;
			}
		}
	}

	internal bool WriteEndBoundary { get; set; }

	public int Count => children.Count;

	public bool IsReadOnly => false;

	public MimeEntity this[int index]
	{
		get
		{
			return children[index];
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			WriteEndBoundary = true;
			children[index] = value;
		}
	}

	public Multipart(MimeEntityConstructorArgs args)
		: base(args)
	{
		children = new List<MimeEntity>();
	}

	public Multipart(string subtype, params object[] args)
		: this(subtype)
	{
		if (args == null)
		{
			throw new ArgumentNullException("args");
		}
		foreach (object obj in args)
		{
			if (obj != null && !TryInit(obj))
			{
				if (!(obj is MimeEntity part))
				{
					throw new ArgumentException("Unknown initialization parameter: " + obj.GetType());
				}
				Add(part);
			}
		}
	}

	public Multipart(string subtype)
		: base("multipart", subtype)
	{
		base.ContentType.Boundary = GenerateBoundary();
		children = new List<MimeEntity>();
		WriteEndBoundary = true;
	}

	public Multipart()
		: this("mixed")
	{
	}

	private static string GenerateBoundary()
	{
		Base64Encoder base64Encoder = new Base64Encoder(rfc2047: true);
		byte[] array = new byte[16];
		byte[] array2 = new byte[24];
		MimeUtils.GetRandomBytes(array);
		int count = base64Encoder.Flush(array, 0, array.Length, array2);
		return "=-" + Encoding.ASCII.GetString(array2, 0, count);
	}

	public override void Accept(MimeVisitor visitor)
	{
		if (visitor == null)
		{
			throw new ArgumentNullException("visitor");
		}
		visitor.VisitMultipart(this);
	}

	internal static string FoldPreambleOrEpilogue(FormatOptions options, string text, bool isEpilogue)
	{
		StringBuilder stringBuilder = new StringBuilder();
		int num = 0;
		int i = 0;
		if (isEpilogue)
		{
			stringBuilder.Append(options.NewLine);
		}
		while (i < text.Length)
		{
			int num2 = i;
			for (; i < text.Length && char.IsWhiteSpace(text[i]); i++)
			{
				if (text[i] == '\n')
				{
					stringBuilder.Append(options.NewLine);
					num2 = i + 1;
					num = 0;
				}
			}
			int num3 = i;
			for (; i < text.Length && !char.IsWhiteSpace(text[i]); i++)
			{
			}
			int num4 = i - num2;
			if (num > 0 && num + num4 >= options.MaxLineLength)
			{
				stringBuilder.Append(options.NewLine);
				num4 = i - num3;
				num2 = num3;
				num = 0;
			}
			if (num4 > 0)
			{
				stringBuilder.Append(text, num2, num4);
				num += num4;
			}
		}
		if (num > 0)
		{
			stringBuilder.Append(options.NewLine);
		}
		return stringBuilder.ToString();
	}

	private static void WriteBytes(FormatOptions options, Stream stream, byte[] bytes, bool ensureNewLine, CancellationToken cancellationToken)
	{
		ICancellableStream cancellableStream = stream as ICancellableStream;
		IMimeFilter mimeFilter = options.CreateNewLineFilter(ensureNewLine);
		int outputIndex;
		int outputLength;
		byte[] buffer = mimeFilter.Flush(bytes, 0, bytes.Length, out outputIndex, out outputLength);
		if (cancellableStream != null)
		{
			cancellableStream.Write(buffer, outputIndex, outputLength, cancellationToken);
			return;
		}
		cancellationToken.ThrowIfCancellationRequested();
		stream.Write(buffer, outputIndex, outputLength);
	}

	private static Task WriteBytesAsync(FormatOptions options, Stream stream, byte[] bytes, bool ensureNewLine, CancellationToken cancellationToken)
	{
		IMimeFilter mimeFilter = options.CreateNewLineFilter(ensureNewLine);
		int outputIndex;
		int outputLength;
		byte[] buffer = mimeFilter.Flush(bytes, 0, bytes.Length, out outputIndex, out outputLength);
		return stream.WriteAsync(buffer, outputIndex, outputLength, cancellationToken);
	}

	public override void Prepare(EncodingConstraint constraint, int maxLineLength = 78)
	{
		if (maxLineLength < 60 || maxLineLength > 998)
		{
			throw new ArgumentOutOfRangeException("maxLineLength");
		}
		for (int i = 0; i < children.Count; i++)
		{
			children[i].Prepare(constraint, maxLineLength);
		}
	}

	public override void WriteTo(FormatOptions options, Stream stream, bool contentOnly, CancellationToken cancellationToken = default(CancellationToken))
	{
		base.WriteTo(options, stream, contentOnly, cancellationToken);
		if (base.ContentType.IsMimeType("multipart", "signed") && (options.International || options.HiddenHeaders.Count > 0))
		{
			options = options.Clone();
			options.HiddenHeaders.Clear();
			options.International = false;
		}
		ICancellableStream cancellableStream = stream as ICancellableStream;
		if (RawPreamble != null && RawPreamble.Length != 0)
		{
			WriteBytes(options, stream, RawPreamble, children.Count > 0 || EnsureNewLine, cancellationToken);
		}
		byte[] bytes = Encoding.ASCII.GetBytes("--" + Boundary + "--");
		if (cancellableStream != null)
		{
			for (int i = 0; i < children.Count; i++)
			{
				MessagePart messagePart = children[i] as MessagePart;
				Multipart multipart = children[i] as Multipart;
				MimePart mimePart = children[i] as MimePart;
				cancellableStream.Write(bytes, 0, bytes.Length - 2, cancellationToken);
				cancellableStream.Write(options.NewLineBytes, 0, options.NewLineBytes.Length, cancellationToken);
				children[i].WriteTo(options, stream, contentOnly: false, cancellationToken);
				if (messagePart != null && messagePart.Message != null && messagePart.Message.Body != null)
				{
					multipart = messagePart.Message.Body as Multipart;
					mimePart = messagePart.Message.Body as MimePart;
				}
				if ((mimePart == null || mimePart.Content != null) && (multipart == null || multipart.WriteEndBoundary))
				{
					cancellableStream.Write(options.NewLineBytes, 0, options.NewLineBytes.Length, cancellationToken);
				}
			}
			if (!WriteEndBoundary)
			{
				return;
			}
			cancellableStream.Write(bytes, 0, bytes.Length, cancellationToken);
			if (RawEpilogue == null)
			{
				cancellableStream.Write(options.NewLineBytes, 0, options.NewLineBytes.Length, cancellationToken);
			}
		}
		else
		{
			for (int j = 0; j < children.Count; j++)
			{
				MessagePart messagePart2 = children[j] as MessagePart;
				Multipart multipart2 = children[j] as Multipart;
				MimePart mimePart2 = children[j] as MimePart;
				cancellationToken.ThrowIfCancellationRequested();
				stream.Write(bytes, 0, bytes.Length - 2);
				stream.Write(options.NewLineBytes, 0, options.NewLineBytes.Length);
				children[j].WriteTo(options, stream, contentOnly: false, cancellationToken);
				if (messagePart2 != null && messagePart2.Message != null && messagePart2.Message.Body != null)
				{
					multipart2 = messagePart2.Message.Body as Multipart;
					mimePart2 = messagePart2.Message.Body as MimePart;
				}
				if ((mimePart2 == null || mimePart2.Content != null) && (multipart2 == null || multipart2.WriteEndBoundary))
				{
					cancellationToken.ThrowIfCancellationRequested();
					stream.Write(options.NewLineBytes, 0, options.NewLineBytes.Length);
				}
			}
			if (!WriteEndBoundary)
			{
				return;
			}
			cancellationToken.ThrowIfCancellationRequested();
			stream.Write(bytes, 0, bytes.Length);
			if (RawEpilogue == null)
			{
				cancellationToken.ThrowIfCancellationRequested();
				stream.Write(options.NewLineBytes, 0, options.NewLineBytes.Length);
			}
		}
		if (RawEpilogue != null && RawEpilogue.Length != 0)
		{
			WriteBytes(options, stream, RawEpilogue, EnsureNewLine, cancellationToken);
		}
	}

	public override async Task WriteToAsync(FormatOptions options, Stream stream, bool contentOnly, CancellationToken cancellationToken = default(CancellationToken))
	{
		await base.WriteToAsync(options, stream, contentOnly, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		if (base.ContentType.IsMimeType("multipart", "signed") && (options.International || options.HiddenHeaders.Count > 0))
		{
			options = options.Clone();
			options.HiddenHeaders.Clear();
			options.International = false;
		}
		if (RawPreamble != null && RawPreamble.Length != 0)
		{
			await WriteBytesAsync(options, stream, RawPreamble, children.Count > 0 || EnsureNewLine, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		byte[] boundary = Encoding.ASCII.GetBytes("--" + Boundary + "--");
		for (int i = 0; i < children.Count; i++)
		{
			MessagePart msg = children[i] as MessagePart;
			Multipart multi = children[i] as Multipart;
			MimePart part = children[i] as MimePart;
			await stream.WriteAsync(boundary, 0, boundary.Length - 2, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			await stream.WriteAsync(options.NewLineBytes, 0, options.NewLineBytes.Length, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			await children[i].WriteToAsync(options, stream, contentOnly: false, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			if (msg != null && msg.Message != null && msg.Message.Body != null)
			{
				multi = msg.Message.Body as Multipart;
				part = msg.Message.Body as MimePart;
			}
			if ((part == null || part.Content != null) && (multi == null || multi.WriteEndBoundary))
			{
				await stream.WriteAsync(options.NewLineBytes, 0, options.NewLineBytes.Length, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			}
		}
		if (WriteEndBoundary)
		{
			await stream.WriteAsync(boundary, 0, boundary.Length, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			if (RawEpilogue == null)
			{
				await stream.WriteAsync(options.NewLineBytes, 0, options.NewLineBytes.Length, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			}
			if (RawEpilogue != null && RawEpilogue.Length != 0)
			{
				await WriteBytesAsync(options, stream, RawEpilogue, EnsureNewLine, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			}
		}
	}

	public void Add(MimeEntity part)
	{
		if (part == null)
		{
			throw new ArgumentNullException("part");
		}
		WriteEndBoundary = true;
		children.Add(part);
	}

	public void Clear()
	{
		WriteEndBoundary = true;
		children.Clear();
	}

	public bool Contains(MimeEntity part)
	{
		if (part == null)
		{
			throw new ArgumentNullException("part");
		}
		return children.Contains(part);
	}

	public void CopyTo(MimeEntity[] array, int arrayIndex)
	{
		children.CopyTo(array, arrayIndex);
	}

	public bool Remove(MimeEntity part)
	{
		if (part == null)
		{
			throw new ArgumentNullException("part");
		}
		if (!children.Remove(part))
		{
			return false;
		}
		WriteEndBoundary = true;
		return true;
	}

	public int IndexOf(MimeEntity part)
	{
		if (part == null)
		{
			throw new ArgumentNullException("part");
		}
		return children.IndexOf(part);
	}

	public void Insert(int index, MimeEntity part)
	{
		if (index < 0 || index > children.Count)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		if (part == null)
		{
			throw new ArgumentNullException("part");
		}
		children.Insert(index, part);
		WriteEndBoundary = true;
	}

	public void RemoveAt(int index)
	{
		children.RemoveAt(index);
		WriteEndBoundary = true;
	}

	public IEnumerator<MimeEntity> GetEnumerator()
	{
		return children.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return children.GetEnumerator();
	}
}
