using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MimeKit.IO;
using MimeKit.Utils;

namespace MimeKit;

public sealed class HeaderList : IList<Header>, ICollection<Header>, IEnumerable<Header>, IEnumerable
{
	internal readonly ParserOptions Options;

	private readonly Dictionary<string, Header> table;

	private readonly List<Header> headers;

	public string this[HeaderId id]
	{
		get
		{
			if (id == HeaderId.Unknown)
			{
				throw new ArgumentOutOfRangeException("id");
			}
			if (table.TryGetValue(id.ToHeaderName(), out var value))
			{
				return value.Value;
			}
			return null;
		}
		set
		{
			if (id == HeaderId.Unknown)
			{
				throw new ArgumentOutOfRangeException("id");
			}
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (table.TryGetValue(id.ToHeaderName(), out var value2))
			{
				value2.Value = value;
			}
			else
			{
				Add(id, value);
			}
		}
	}

	public string this[string field]
	{
		get
		{
			if (field == null)
			{
				throw new ArgumentNullException("field");
			}
			if (table.TryGetValue(field, out var value))
			{
				return value.Value;
			}
			return null;
		}
		set
		{
			if (field == null)
			{
				throw new ArgumentNullException("field");
			}
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (table.TryGetValue(field, out var value2))
			{
				value2.Value = value;
			}
			else
			{
				Add(field, value);
			}
		}
	}

	public int Count => headers.Count;

	public bool IsReadOnly => false;

	public Header this[int index]
	{
		get
		{
			if (index < 0 || index >= Count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			return headers[index];
		}
		set
		{
			if (index < 0 || index >= Count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			Header value2 = headers[index];
			if (value2 == value)
			{
				return;
			}
			value2.Changed -= HeaderChanged;
			value.Changed += HeaderChanged;
			if (value2.Field.Equals(value.Field, StringComparison.OrdinalIgnoreCase))
			{
				if (table[value2.Field] == value2)
				{
					table[value2.Field] = value;
				}
			}
			else
			{
				if (table[value2.Field] == value2)
				{
					table.Remove(value2.Field);
					for (int i = index + 1; i < headers.Count; i++)
					{
						if (headers[i].Field.Equals(value2.Field, StringComparison.OrdinalIgnoreCase))
						{
							table.Add(headers[i].Field, headers[i]);
							break;
						}
					}
				}
				if (table.TryGetValue(value.Field, out value2))
				{
					int num = headers.IndexOf(value2);
					if (num > index)
					{
						table[value2.Field] = value;
					}
				}
				else
				{
					table.Add(value.Field, value);
				}
			}
			headers[index] = value;
			if (value2.Field.Equals(value.Field, StringComparison.OrdinalIgnoreCase))
			{
				OnChanged(value, HeaderListChangedAction.Changed);
				return;
			}
			OnChanged(value2, HeaderListChangedAction.Removed);
			OnChanged(value, HeaderListChangedAction.Added);
		}
	}

	internal event EventHandler<HeaderListChangedEventArgs> Changed;

	internal HeaderList(ParserOptions options)
	{
		table = new Dictionary<string, Header>(MimeUtils.OrdinalIgnoreCase);
		headers = new List<Header>();
		Options = options;
	}

	public HeaderList()
		: this(ParserOptions.Default.Clone())
	{
	}

	public void Add(HeaderId id, string value)
	{
		Add(id, Encoding.UTF8, value);
	}

	public void Add(string field, string value)
	{
		Add(field, Encoding.UTF8, value);
	}

	public void Add(HeaderId id, Encoding encoding, string value)
	{
		Add(new Header(encoding, id, value));
	}

	public void Add(string field, Encoding encoding, string value)
	{
		Add(new Header(encoding, field, value));
	}

	public bool Contains(HeaderId id)
	{
		if (id == HeaderId.Unknown)
		{
			throw new ArgumentOutOfRangeException("id");
		}
		return table.ContainsKey(id.ToHeaderName());
	}

	public bool Contains(string field)
	{
		if (field == null)
		{
			throw new ArgumentNullException("field");
		}
		return table.ContainsKey(field);
	}

	public int IndexOf(HeaderId id)
	{
		if (id == HeaderId.Unknown)
		{
			throw new ArgumentOutOfRangeException("id");
		}
		for (int i = 0; i < headers.Count; i++)
		{
			if (headers[i].Id == id)
			{
				return i;
			}
		}
		return -1;
	}

	public int IndexOf(string field)
	{
		if (field == null)
		{
			throw new ArgumentNullException("field");
		}
		for (int i = 0; i < headers.Count; i++)
		{
			if (headers[i].Field.Equals(field, StringComparison.OrdinalIgnoreCase))
			{
				return i;
			}
		}
		return -1;
	}

	public void Insert(int index, HeaderId id, string value)
	{
		Insert(index, id, Encoding.UTF8, value);
	}

	public void Insert(int index, string field, string value)
	{
		Insert(index, field, Encoding.UTF8, value);
	}

	public void Insert(int index, HeaderId id, Encoding encoding, string value)
	{
		Insert(index, new Header(encoding, id, value));
	}

	public void Insert(int index, string field, Encoding encoding, string value)
	{
		Insert(index, new Header(encoding, field, value));
	}

	public int LastIndexOf(HeaderId id)
	{
		if (id == HeaderId.Unknown)
		{
			throw new ArgumentOutOfRangeException("id");
		}
		for (int num = headers.Count - 1; num >= 0; num--)
		{
			if (headers[num].Id == id)
			{
				return num;
			}
		}
		return -1;
	}

	public int LastIndexOf(string field)
	{
		if (field == null)
		{
			throw new ArgumentNullException("field");
		}
		for (int num = headers.Count - 1; num >= 0; num--)
		{
			if (headers[num].Field.Equals(field, StringComparison.OrdinalIgnoreCase))
			{
				return num;
			}
		}
		return -1;
	}

	public bool Remove(HeaderId id)
	{
		if (id == HeaderId.Unknown)
		{
			throw new ArgumentOutOfRangeException("id");
		}
		if (!table.TryGetValue(id.ToHeaderName(), out var value))
		{
			return false;
		}
		return Remove(value);
	}

	public bool Remove(string field)
	{
		if (field == null)
		{
			throw new ArgumentNullException("field");
		}
		if (!table.TryGetValue(field, out var value))
		{
			return false;
		}
		return Remove(value);
	}

	public void RemoveAll(HeaderId id)
	{
		if (id == HeaderId.Unknown)
		{
			throw new ArgumentOutOfRangeException("id");
		}
		table.Remove(id.ToHeaderName());
		for (int num = headers.Count - 1; num >= 0; num--)
		{
			if (headers[num].Id == id)
			{
				Header header = headers[num];
				headers.RemoveAt(num);
				OnChanged(header, HeaderListChangedAction.Removed);
			}
		}
	}

	public void RemoveAll(string field)
	{
		if (field == null)
		{
			throw new ArgumentNullException("field");
		}
		table.Remove(field);
		for (int num = headers.Count - 1; num >= 0; num--)
		{
			if (headers[num].Field.Equals(field, StringComparison.OrdinalIgnoreCase))
			{
				Header header = headers[num];
				headers.RemoveAt(num);
				OnChanged(header, HeaderListChangedAction.Removed);
			}
		}
	}

	public void Replace(HeaderId id, Encoding encoding, string value)
	{
		Replace(new Header(encoding, id, value));
	}

	public void Replace(HeaderId id, string value)
	{
		Replace(new Header(id, value));
	}

	public void Replace(string field, Encoding encoding, string value)
	{
		Replace(new Header(encoding, field, value));
	}

	public void Replace(string field, string value)
	{
		Replace(new Header(field, value));
	}

	public void WriteTo(FormatOptions options, Stream stream, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (stream == null)
		{
			throw new ArgumentNullException("stream");
		}
		using (FilteredStream filteredStream = new FilteredStream(stream))
		{
			filteredStream.Add(options.CreateNewLineFilter());
			foreach (Header header in headers)
			{
				filteredStream.Write(header.RawField, 0, header.RawField.Length, cancellationToken);
				if (!header.IsInvalid)
				{
					byte[] rawValue = header.GetRawValue(options);
					filteredStream.Write(Header.Colon, 0, Header.Colon.Length, cancellationToken);
					filteredStream.Write(rawValue, 0, rawValue.Length, cancellationToken);
				}
			}
			filteredStream.Flush(cancellationToken);
		}
		if (stream is ICancellableStream cancellableStream)
		{
			cancellableStream.Write(options.NewLineBytes, 0, options.NewLineBytes.Length, cancellationToken);
			return;
		}
		cancellationToken.ThrowIfCancellationRequested();
		stream.Write(options.NewLineBytes, 0, options.NewLineBytes.Length);
	}

	public async Task WriteToAsync(FormatOptions options, Stream stream, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (stream == null)
		{
			throw new ArgumentNullException("stream");
		}
		using (FilteredStream filtered = new FilteredStream(stream))
		{
			filtered.Add(options.CreateNewLineFilter());
			foreach (Header header in headers)
			{
				await filtered.WriteAsync(header.RawField, 0, header.RawField.Length, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				if (!header.IsInvalid)
				{
					byte[] rawValue = header.GetRawValue(options);
					await filtered.WriteAsync(Header.Colon, 0, Header.Colon.Length, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
					await filtered.WriteAsync(rawValue, 0, rawValue.Length, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				}
			}
			await filtered.FlushAsync(cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		await stream.WriteAsync(options.NewLineBytes, 0, options.NewLineBytes.Length, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
	}

	public void WriteTo(Stream stream, CancellationToken cancellationToken = default(CancellationToken))
	{
		WriteTo(FormatOptions.Default, stream, cancellationToken);
	}

	public Task WriteToAsync(Stream stream, CancellationToken cancellationToken = default(CancellationToken))
	{
		return WriteToAsync(FormatOptions.Default, stream, cancellationToken);
	}

	public void Add(Header header)
	{
		if (header == null)
		{
			throw new ArgumentNullException("header");
		}
		if (!table.ContainsKey(header.Field))
		{
			table.Add(header.Field, header);
		}
		header.Changed += HeaderChanged;
		headers.Add(header);
		OnChanged(header, HeaderListChangedAction.Added);
	}

	public void Clear()
	{
		foreach (Header header in headers)
		{
			header.Changed -= HeaderChanged;
		}
		headers.Clear();
		table.Clear();
		OnChanged(null, HeaderListChangedAction.Cleared);
	}

	public bool Contains(Header header)
	{
		if (header == null)
		{
			throw new ArgumentNullException("header");
		}
		return headers.Contains(header);
	}

	public void CopyTo(Header[] array, int arrayIndex)
	{
		headers.CopyTo(array, arrayIndex);
	}

	public bool Remove(Header header)
	{
		if (header == null)
		{
			throw new ArgumentNullException("header");
		}
		int num = headers.IndexOf(header);
		if (num == -1)
		{
			return false;
		}
		header.Changed -= HeaderChanged;
		if (table[header.Field] == header)
		{
			table.Remove(header.Field);
			for (int i = num + 1; i < headers.Count; i++)
			{
				if (headers[i].Field.Equals(header.Field, StringComparison.OrdinalIgnoreCase))
				{
					table.Add(headers[i].Field, headers[i]);
					break;
				}
			}
		}
		headers.RemoveAt(num);
		OnChanged(header, HeaderListChangedAction.Removed);
		return true;
	}

	public void Replace(Header header)
	{
		if (header == null)
		{
			throw new ArgumentNullException("header");
		}
		if (!table.TryGetValue(header.Field, out var value))
		{
			Add(header);
			return;
		}
		int num = headers.Count - 1;
		while (num >= 0 && headers[num] != value)
		{
			if (headers[num].Field.Equals(header.Field, StringComparison.OrdinalIgnoreCase))
			{
				headers[num].Changed -= HeaderChanged;
				headers.RemoveAt(num);
			}
			num--;
		}
		header.Changed += HeaderChanged;
		value.Changed -= HeaderChanged;
		table[header.Field] = header;
		headers[num] = header;
		OnChanged(value, HeaderListChangedAction.Removed);
		OnChanged(header, HeaderListChangedAction.Added);
	}

	public int IndexOf(Header header)
	{
		if (header == null)
		{
			throw new ArgumentNullException("header");
		}
		return headers.IndexOf(header);
	}

	public void Insert(int index, Header header)
	{
		if (index < 0 || index > Count)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		if (header == null)
		{
			throw new ArgumentNullException("header");
		}
		if (table.TryGetValue(header.Field, out var value))
		{
			int num = headers.IndexOf(value);
			if (num >= index)
			{
				table[header.Field] = header;
			}
		}
		else
		{
			table.Add(header.Field, header);
		}
		headers.Insert(index, header);
		header.Changed += HeaderChanged;
		OnChanged(header, HeaderListChangedAction.Added);
	}

	public void RemoveAt(int index)
	{
		if (index < 0 || index >= Count)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		Header header = headers[index];
		header.Changed -= HeaderChanged;
		if (table[header.Field] == header)
		{
			table.Remove(header.Field);
			for (int i = index + 1; i < headers.Count; i++)
			{
				if (headers[i].Field.Equals(header.Field, StringComparison.OrdinalIgnoreCase))
				{
					table.Add(headers[i].Field, headers[i]);
					break;
				}
			}
		}
		headers.RemoveAt(index);
		OnChanged(header, HeaderListChangedAction.Removed);
	}

	public IEnumerator<Header> GetEnumerator()
	{
		return headers.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return headers.GetEnumerator();
	}

	private void HeaderChanged(object sender, EventArgs args)
	{
		OnChanged((Header)sender, HeaderListChangedAction.Changed);
	}

	private void OnChanged(Header header, HeaderListChangedAction action)
	{
		if (this.Changed != null)
		{
			this.Changed(this, new HeaderListChangedEventArgs(header, action));
		}
	}

	internal bool TryGetHeader(string field, out Header header)
	{
		if (field == null)
		{
			throw new ArgumentNullException("field");
		}
		return table.TryGetValue(field, out header);
	}

	public static HeaderList Load(ParserOptions options, Stream stream, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (stream == null)
		{
			throw new ArgumentNullException("stream");
		}
		MimeParser mimeParser = new MimeParser(options, stream, MimeFormat.Entity);
		return mimeParser.ParseHeaders(cancellationToken);
	}

	public static Task<HeaderList> LoadAsync(ParserOptions options, Stream stream, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (stream == null)
		{
			throw new ArgumentNullException("stream");
		}
		MimeParser mimeParser = new MimeParser(options, stream, MimeFormat.Entity);
		return mimeParser.ParseHeadersAsync(cancellationToken);
	}

	public static HeaderList Load(Stream stream, CancellationToken cancellationToken = default(CancellationToken))
	{
		return Load(ParserOptions.Default, stream, cancellationToken);
	}

	public static Task<HeaderList> LoadAsync(Stream stream, CancellationToken cancellationToken = default(CancellationToken))
	{
		return LoadAsync(ParserOptions.Default, stream, cancellationToken);
	}

	public static HeaderList Load(ParserOptions options, string fileName, CancellationToken cancellationToken = default(CancellationToken))
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

	public static async Task<HeaderList> LoadAsync(ParserOptions options, string fileName, CancellationToken cancellationToken = default(CancellationToken))
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

	public static HeaderList Load(string fileName, CancellationToken cancellationToken = default(CancellationToken))
	{
		return Load(ParserOptions.Default, fileName, cancellationToken);
	}

	public static Task<HeaderList> LoadAsync(string fileName, CancellationToken cancellationToken = default(CancellationToken))
	{
		return LoadAsync(ParserOptions.Default, fileName, cancellationToken);
	}
}
