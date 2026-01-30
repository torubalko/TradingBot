using System;
using System.IO;
using System.Text;

namespace MimeKit.Text;

public class HtmlWriter : IDisposable
{
	private TextWriter html;

	private bool empty;

	public HtmlWriterState WriterState { get; private set; }

	public HtmlWriter(Stream stream, Encoding encoding)
	{
		if (stream == null)
		{
			throw new ArgumentNullException("stream");
		}
		if (encoding == null)
		{
			throw new ArgumentNullException("encoding");
		}
		html = new StreamWriter(stream, encoding, 4096);
	}

	public HtmlWriter(TextWriter output)
	{
		if (output == null)
		{
			throw new ArgumentNullException("output");
		}
		html = output;
	}

	~HtmlWriter()
	{
		Dispose(disposing: false);
	}

	private void CheckDisposed()
	{
		if (html == null)
		{
			throw new ObjectDisposedException("HtmlWriter");
		}
	}

	private static void ValidateArguments(char[] buffer, int index, int count)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (index < 0 || index > buffer.Length)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		if (count < 0 || count > buffer.Length - index)
		{
			throw new ArgumentOutOfRangeException("count");
		}
	}

	private static void ValidateAttributeName(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (name.Length == 0)
		{
			throw new ArgumentException("The attribute name cannot be empty.", "name");
		}
		if (!HtmlUtils.IsValidTokenName(name))
		{
			throw new ArgumentException("Invalid attribute name: " + name, "name");
		}
	}

	private static void ValidateTagName(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (name.Length == 0)
		{
			throw new ArgumentException("The tag name cannot be empty.", "name");
		}
		if (!HtmlUtils.IsValidTokenName(name))
		{
			throw new ArgumentException("Invalid tag name: " + name, "name");
		}
	}

	private void EncodeAttributeName(string name)
	{
		if (WriterState == HtmlWriterState.Default)
		{
			throw new InvalidOperationException("Cannot write attributes in the Default state.");
		}
		html.Write(' ');
		html.Write(name);
		WriterState = HtmlWriterState.Attribute;
	}

	private void EncodeAttributeValue(char[] value, int startIndex, int count)
	{
		if (WriterState != HtmlWriterState.Attribute)
		{
			throw new InvalidOperationException("Attribute values can only be written in the Attribute state.");
		}
		html.Write('=');
		HtmlUtils.HtmlAttributeEncode(html, value, startIndex, count);
		WriterState = HtmlWriterState.Tag;
	}

	private void EncodeAttributeValue(string value)
	{
		if (WriterState != HtmlWriterState.Attribute)
		{
			throw new InvalidOperationException("Attribute values can only be written in the Attribute state.");
		}
		html.Write('=');
		HtmlUtils.HtmlAttributeEncode(html, value);
		WriterState = HtmlWriterState.Tag;
	}

	private void EncodeAttribute(string name, char[] value, int startIndex, int count)
	{
		EncodeAttributeName(name);
		EncodeAttributeValue(value, startIndex, count);
	}

	private void EncodeAttribute(string name, string value)
	{
		EncodeAttributeName(name);
		EncodeAttributeValue(value);
	}

	public void WriteAttribute(HtmlAttributeId id, char[] buffer, int index, int count)
	{
		if (id == HtmlAttributeId.Unknown)
		{
			throw new ArgumentException("Invalid attribute.", "id");
		}
		ValidateArguments(buffer, index, count);
		CheckDisposed();
		EncodeAttribute(id.ToAttributeName(), buffer, index, count);
	}

	public void WriteAttribute(string name, char[] buffer, int index, int count)
	{
		ValidateAttributeName(name);
		ValidateArguments(buffer, index, count);
		CheckDisposed();
		EncodeAttribute(name, buffer, index, count);
	}

	public void WriteAttribute(HtmlAttributeId id, string value)
	{
		if (id == HtmlAttributeId.Unknown)
		{
			throw new ArgumentException("Invalid attribute.", "id");
		}
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		CheckDisposed();
		EncodeAttribute(id.ToAttributeName(), value);
	}

	public void WriteAttribute(string name, string value)
	{
		ValidateAttributeName(name);
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		CheckDisposed();
		EncodeAttribute(name, value);
	}

	public void WriteAttribute(HtmlAttribute attribute)
	{
		if (attribute == null)
		{
			throw new ArgumentNullException("attribute");
		}
		EncodeAttributeName(attribute.Name);
		if (attribute.Value != null)
		{
			EncodeAttributeValue(attribute.Value);
		}
	}

	public void WriteAttributeName(HtmlAttributeId id)
	{
		if (id == HtmlAttributeId.Unknown)
		{
			throw new ArgumentException("Invalid attribute.", "id");
		}
		if (WriterState == HtmlWriterState.Default)
		{
			throw new InvalidOperationException("Cannot write attributes in the Default state.");
		}
		CheckDisposed();
		EncodeAttributeName(id.ToAttributeName());
	}

	public void WriteAttributeName(string name)
	{
		ValidateAttributeName(name);
		if (WriterState == HtmlWriterState.Default)
		{
			throw new InvalidOperationException("Cannot write attributes in the Default state.");
		}
		CheckDisposed();
		EncodeAttributeName(name);
	}

	public void WriteAttributeValue(char[] buffer, int index, int count)
	{
		ValidateArguments(buffer, index, count);
		CheckDisposed();
		EncodeAttributeValue(buffer, index, count);
	}

	public void WriteAttributeValue(string value)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		CheckDisposed();
		EncodeAttributeValue(value);
	}

	public void WriteEmptyElementTag(HtmlTagId id)
	{
		if (id == HtmlTagId.Unknown)
		{
			throw new ArgumentException("Invalid tag.", "id");
		}
		CheckDisposed();
		if (WriterState != HtmlWriterState.Default)
		{
			WriterState = HtmlWriterState.Default;
			html.Write(empty ? "/>" : ">");
		}
		html.Write($"<{id.ToHtmlTagName()}");
		WriterState = HtmlWriterState.Tag;
		empty = true;
	}

	public void WriteEmptyElementTag(string name)
	{
		ValidateTagName(name);
		CheckDisposed();
		if (WriterState != HtmlWriterState.Default)
		{
			WriterState = HtmlWriterState.Default;
			html.Write(empty ? "/>" : ">");
		}
		html.Write($"<{name}");
		WriterState = HtmlWriterState.Tag;
		empty = true;
	}

	public void WriteEndTag(HtmlTagId id)
	{
		if (id == HtmlTagId.Unknown)
		{
			throw new ArgumentException("Invalid tag.", "id");
		}
		CheckDisposed();
		if (WriterState != HtmlWriterState.Default)
		{
			WriterState = HtmlWriterState.Default;
			html.Write(empty ? "/>" : ">");
			empty = false;
		}
		html.Write($"</{id.ToHtmlTagName()}>");
	}

	public void WriteEndTag(string name)
	{
		ValidateTagName(name);
		CheckDisposed();
		if (WriterState != HtmlWriterState.Default)
		{
			WriterState = HtmlWriterState.Default;
			html.Write(empty ? "/>" : ">");
			empty = false;
		}
		html.Write($"</{name}>");
	}

	public void WriteMarkupText(char[] buffer, int index, int count)
	{
		ValidateArguments(buffer, index, count);
		CheckDisposed();
		if (WriterState != HtmlWriterState.Default)
		{
			WriterState = HtmlWriterState.Default;
			html.Write(empty ? "/>" : ">");
			empty = false;
		}
		html.Write(buffer, index, count);
	}

	public void WriteMarkupText(string value)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		CheckDisposed();
		if (WriterState != HtmlWriterState.Default)
		{
			WriterState = HtmlWriterState.Default;
			html.Write(empty ? "/>" : ">");
			empty = false;
		}
		html.Write(value);
	}

	public void WriteStartTag(HtmlTagId id)
	{
		if (id == HtmlTagId.Unknown)
		{
			throw new ArgumentException("Invalid tag.", "id");
		}
		CheckDisposed();
		if (WriterState != HtmlWriterState.Default)
		{
			html.Write(empty ? "/>" : ">");
			empty = false;
		}
		html.Write($"<{id.ToHtmlTagName()}");
		WriterState = HtmlWriterState.Tag;
	}

	public void WriteStartTag(string name)
	{
		ValidateTagName(name);
		CheckDisposed();
		if (WriterState != HtmlWriterState.Default)
		{
			html.Write(empty ? "/>" : ">");
			empty = false;
		}
		html.Write($"<{name}");
		WriterState = HtmlWriterState.Tag;
	}

	public void WriteText(char[] buffer, int index, int count)
	{
		ValidateArguments(buffer, index, count);
		CheckDisposed();
		if (WriterState != HtmlWriterState.Default)
		{
			WriterState = HtmlWriterState.Default;
			html.Write(empty ? "/>" : ">");
			empty = false;
		}
		if (count > 0)
		{
			HtmlUtils.HtmlEncode(html, buffer, index, count);
		}
	}

	public void WriteText(string value)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		CheckDisposed();
		if (WriterState != HtmlWriterState.Default)
		{
			WriterState = HtmlWriterState.Default;
			html.Write(empty ? "/>" : ">");
			empty = false;
		}
		if (value.Length > 0)
		{
			HtmlUtils.HtmlEncode(html, value.ToCharArray(), 0, value.Length);
		}
	}

	public void WriteText(string format, params object[] args)
	{
		WriteText(string.Format(format, args));
	}

	public void WriteToken(HtmlToken token)
	{
		if (token == null)
		{
			throw new ArgumentNullException("token");
		}
		CheckDisposed();
		if (WriterState != HtmlWriterState.Default)
		{
			WriterState = HtmlWriterState.Default;
			html.Write(empty ? "/>" : ">");
			empty = false;
		}
		token.WriteTo(html);
	}

	public void Flush()
	{
		CheckDisposed();
		if (WriterState != HtmlWriterState.Default)
		{
			WriterState = HtmlWriterState.Default;
			html.Write(empty ? "/>" : ">");
			empty = false;
		}
		html.Flush();
	}

	protected virtual void Dispose(bool disposing)
	{
		if (disposing)
		{
			html = null;
		}
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}
}
