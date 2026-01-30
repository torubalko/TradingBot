using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using MimeKit.Utils;

namespace MimeKit;

public class DomainList : IList<string>, ICollection<string>, IEnumerable<string>, IEnumerable
{
	private static readonly byte[] DomainSentinels = new byte[2] { 44, 58 };

	private readonly List<string> domains;

	public string this[int index]
	{
		get
		{
			return domains[index];
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (!(domains[index] == value))
			{
				domains[index] = value;
				OnChanged();
			}
		}
	}

	public int Count => domains.Count;

	public bool IsReadOnly => false;

	internal event EventHandler Changed;

	public DomainList(IEnumerable<string> domains)
	{
		if (domains == null)
		{
			throw new ArgumentNullException("domains");
		}
		this.domains = new List<string>(domains);
	}

	public DomainList()
	{
		domains = new List<string>();
	}

	public int IndexOf(string domain)
	{
		if (domain == null)
		{
			throw new ArgumentNullException("domain");
		}
		return domains.IndexOf(domain);
	}

	public void Insert(int index, string domain)
	{
		if (domain == null)
		{
			throw new ArgumentNullException("domain");
		}
		domains.Insert(index, domain);
		OnChanged();
	}

	public void RemoveAt(int index)
	{
		domains.RemoveAt(index);
		OnChanged();
	}

	public void Add(string domain)
	{
		if (domain == null)
		{
			throw new ArgumentNullException("domain");
		}
		domains.Add(domain);
		OnChanged();
	}

	public void Clear()
	{
		domains.Clear();
		OnChanged();
	}

	public bool Contains(string domain)
	{
		if (domain == null)
		{
			throw new ArgumentNullException("domain");
		}
		return domains.Contains(domain);
	}

	public void CopyTo(string[] array, int arrayIndex)
	{
		domains.CopyTo(array, arrayIndex);
	}

	public bool Remove(string domain)
	{
		if (domain == null)
		{
			throw new ArgumentNullException("domain");
		}
		if (domains.Remove(domain))
		{
			OnChanged();
			return true;
		}
		return false;
	}

	public IEnumerator<string> GetEnumerator()
	{
		return domains.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return domains.GetEnumerator();
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

	internal string Encode(FormatOptions options)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < domains.Count; i++)
		{
			if (!IsNullOrWhiteSpace(domains[i]))
			{
				if (stringBuilder.Length > 0)
				{
					stringBuilder.Append(',');
				}
				stringBuilder.Append('@');
				if (!options.International && ParseUtils.IsInternational(domains[i]))
				{
					string value = ParseUtils.IdnEncode(domains[i]);
					stringBuilder.Append(value);
				}
				else
				{
					stringBuilder.Append(domains[i]);
				}
			}
		}
		return stringBuilder.ToString();
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < domains.Count; i++)
		{
			if (!IsNullOrWhiteSpace(domains[i]))
			{
				if (stringBuilder.Length > 0)
				{
					stringBuilder.Append(',');
				}
				stringBuilder.Append('@');
				stringBuilder.Append(domains[i]);
			}
		}
		return stringBuilder.ToString();
	}

	private void OnChanged()
	{
		if (this.Changed != null)
		{
			this.Changed(this, EventArgs.Empty);
		}
	}

	internal static bool TryParse(byte[] buffer, ref int index, int endIndex, bool throwOnError, out DomainList route)
	{
		List<string> list = new List<string>();
		int num = index;
		route = null;
		do
		{
			index++;
			if (index >= endIndex)
			{
				if (throwOnError)
				{
					throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Incomplete domain-list at offset: {0}", num), num, index);
				}
				return false;
			}
			if (!ParseUtils.TryParseDomain(buffer, ref index, endIndex, DomainSentinels, throwOnError, out var domain))
			{
				return false;
			}
			list.Add(domain);
			while (true)
			{
				if (!ParseUtils.SkipCommentsAndWhiteSpace(buffer, ref index, endIndex, throwOnError))
				{
					return false;
				}
				if (index >= endIndex || buffer[index] != 44)
				{
					break;
				}
				index++;
			}
			if (!ParseUtils.SkipCommentsAndWhiteSpace(buffer, ref index, endIndex, throwOnError))
			{
				return false;
			}
		}
		while (index < buffer.Length && buffer[index] == 64);
		route = new DomainList(list);
		return true;
	}

	public static bool TryParse(string text, out DomainList route)
	{
		int index = 0;
		if (text == null)
		{
			throw new ArgumentNullException("text");
		}
		byte[] bytes = Encoding.UTF8.GetBytes(text);
		return TryParse(bytes, ref index, bytes.Length, throwOnError: false, out route);
	}
}
