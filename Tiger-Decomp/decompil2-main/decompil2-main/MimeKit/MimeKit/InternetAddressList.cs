using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;
using MimeKit.Utils;

namespace MimeKit;

public class InternetAddressList : IList<InternetAddress>, ICollection<InternetAddress>, IEnumerable<InternetAddress>, IEnumerable, IEquatable<InternetAddressList>, IComparable<InternetAddressList>
{
	private readonly List<InternetAddress> list = new List<InternetAddress>();

	public IEnumerable<MailboxAddress> Mailboxes
	{
		get
		{
			foreach (InternetAddress item in list)
			{
				if (item is GroupAddress groupAddress)
				{
					foreach (MailboxAddress mailbox in groupAddress.Members.Mailboxes)
					{
						yield return mailbox;
					}
				}
				else
				{
					yield return (MailboxAddress)item;
				}
			}
		}
	}

	public InternetAddress this[int index]
	{
		get
		{
			return list[index];
		}
		set
		{
			if (index < 0 || index >= list.Count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (list[index] != value)
			{
				list[index].Changed -= AddressChanged;
				value.Changed += AddressChanged;
				list[index] = value;
				OnChanged();
			}
		}
	}

	public int Count => list.Count;

	public bool IsReadOnly => false;

	internal event EventHandler Changed;

	public InternetAddressList(IEnumerable<InternetAddress> addresses)
	{
		if (addresses == null)
		{
			throw new ArgumentNullException("addresses");
		}
		foreach (InternetAddress address in addresses)
		{
			address.Changed += AddressChanged;
			list.Add(address);
		}
	}

	public InternetAddressList()
	{
	}

	public int IndexOf(InternetAddress address)
	{
		if (address == null)
		{
			throw new ArgumentNullException("address");
		}
		return list.IndexOf(address);
	}

	public void Insert(int index, InternetAddress address)
	{
		if (index < 0 || index > list.Count)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		if (address == null)
		{
			throw new ArgumentNullException("address");
		}
		address.Changed += AddressChanged;
		list.Insert(index, address);
		OnChanged();
	}

	public void RemoveAt(int index)
	{
		if (index < 0 || index >= list.Count)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		list[index].Changed -= AddressChanged;
		list.RemoveAt(index);
		OnChanged();
	}

	public void Add(InternetAddress address)
	{
		if (address == null)
		{
			throw new ArgumentNullException("address");
		}
		address.Changed += AddressChanged;
		list.Add(address);
		OnChanged();
	}

	public void AddRange(IEnumerable<InternetAddress> addresses)
	{
		if (addresses == null)
		{
			throw new ArgumentNullException("addresses");
		}
		bool flag = false;
		foreach (InternetAddress address in addresses)
		{
			address.Changed += AddressChanged;
			list.Add(address);
			flag = true;
		}
		if (flag)
		{
			OnChanged();
		}
	}

	public void Clear()
	{
		if (list.Count != 0)
		{
			for (int i = 0; i < list.Count; i++)
			{
				list[i].Changed -= AddressChanged;
			}
			list.Clear();
			OnChanged();
		}
	}

	public bool Contains(InternetAddress address)
	{
		if (address == null)
		{
			throw new ArgumentNullException("address");
		}
		return list.Contains(address);
	}

	public void CopyTo(InternetAddress[] array, int arrayIndex)
	{
		list.CopyTo(array, arrayIndex);
	}

	public bool Remove(InternetAddress address)
	{
		if (address == null)
		{
			throw new ArgumentNullException("address");
		}
		if (list.Remove(address))
		{
			address.Changed -= AddressChanged;
			OnChanged();
			return true;
		}
		return false;
	}

	public IEnumerator<InternetAddress> GetEnumerator()
	{
		return list.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return list.GetEnumerator();
	}

	public bool Equals(InternetAddressList other)
	{
		if (other == null)
		{
			return false;
		}
		if (other.Count != Count)
		{
			return false;
		}
		for (int i = 0; i < Count; i++)
		{
			if (!this[i].Equals(other[i]))
			{
				return false;
			}
		}
		return true;
	}

	public int CompareTo(InternetAddressList other)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		for (int i = 0; i < Math.Min(Count, other.Count); i++)
		{
			int result;
			if ((result = this[i].CompareTo(other[i])) != 0)
			{
				return result;
			}
		}
		return Count - other.Count;
	}

	public override bool Equals(object obj)
	{
		return Equals(obj as InternetAddressList);
	}

	public override int GetHashCode()
	{
		return ToString().GetHashCode();
	}

	internal void Encode(FormatOptions options, StringBuilder builder, bool firstToken, ref int lineLength)
	{
		for (int i = 0; i < list.Count; i++)
		{
			if (i > 0)
			{
				builder.Append(", ");
				lineLength += 2;
			}
			list[i].Encode(options, builder, firstToken && i == 0, ref lineLength);
		}
	}

	public string ToString(FormatOptions options, bool encode)
	{
		StringBuilder stringBuilder = new StringBuilder();
		if (encode)
		{
			int lineLength = 0;
			Encode(options, stringBuilder, firstToken: true, ref lineLength);
			return stringBuilder.ToString();
		}
		for (int i = 0; i < list.Count; i++)
		{
			if (i > 0)
			{
				stringBuilder.Append(", ");
			}
			stringBuilder.Append(list[i].ToString(options, encode: false));
		}
		return stringBuilder.ToString();
	}

	public string ToString(bool encode)
	{
		return ToString(FormatOptions.Default, encode);
	}

	public override string ToString()
	{
		return ToString(FormatOptions.Default, encode: false);
	}

	private void OnChanged()
	{
		if (this.Changed != null)
		{
			this.Changed(this, EventArgs.Empty);
		}
	}

	private void AddressChanged(object sender, EventArgs e)
	{
		OnChanged();
	}

	internal static bool TryParse(ParserOptions options, byte[] text, ref int index, int endIndex, bool isGroup, int groupDepth, bool throwOnError, out List<InternetAddress> addresses)
	{
		InternetAddress.AddressParserFlags flags = (throwOnError ? InternetAddress.AddressParserFlags.Parse : InternetAddress.AddressParserFlags.TryParse);
		List<InternetAddress> list = new List<InternetAddress>();
		addresses = null;
		if (!ParseUtils.SkipCommentsAndWhiteSpace(text, ref index, endIndex, throwOnError))
		{
			return false;
		}
		if (index == endIndex)
		{
			if (throwOnError)
			{
				throw new ParseException("No addresses found.", index, index);
			}
			return false;
		}
		while (index < endIndex && (!isGroup || text[index] != 59))
		{
			if (!InternetAddress.TryParse(options, text, ref index, endIndex, groupDepth, flags, out var address))
			{
				while (index < endIndex && text[index] != 44 && (!isGroup || text[index] != 59))
				{
					index++;
				}
			}
			else
			{
				list.Add(address);
			}
			while (true)
			{
				if (!ParseUtils.SkipCommentsAndWhiteSpace(text, ref index, endIndex, throwOnError))
				{
					return false;
				}
				if (index >= endIndex || text[index] != 44)
				{
					break;
				}
				index++;
			}
		}
		addresses = list;
		return true;
	}

	public static bool TryParse(ParserOptions options, byte[] buffer, int startIndex, int length, out InternetAddressList addresses)
	{
		ParseUtils.ValidateArguments(options, buffer, startIndex, length);
		int index = startIndex;
		if (!TryParse(options, buffer, ref index, startIndex + length, isGroup: false, 0, throwOnError: false, out var addresses2))
		{
			addresses = null;
			return false;
		}
		addresses = new InternetAddressList(addresses2);
		return true;
	}

	public static bool TryParse(byte[] buffer, int startIndex, int length, out InternetAddressList addresses)
	{
		return TryParse(ParserOptions.Default, buffer, startIndex, length, out addresses);
	}

	public static bool TryParse(ParserOptions options, byte[] buffer, int startIndex, out InternetAddressList addresses)
	{
		ParseUtils.ValidateArguments(options, buffer, startIndex);
		int index = startIndex;
		if (!TryParse(options, buffer, ref index, buffer.Length, isGroup: false, 0, throwOnError: false, out var addresses2))
		{
			addresses = null;
			return false;
		}
		addresses = new InternetAddressList(addresses2);
		return true;
	}

	public static bool TryParse(byte[] buffer, int startIndex, out InternetAddressList addresses)
	{
		return TryParse(ParserOptions.Default, buffer, startIndex, out addresses);
	}

	public static bool TryParse(ParserOptions options, byte[] buffer, out InternetAddressList addresses)
	{
		ParseUtils.ValidateArguments(options, buffer);
		int index = 0;
		if (!TryParse(options, buffer, ref index, buffer.Length, isGroup: false, 0, throwOnError: false, out var addresses2))
		{
			addresses = null;
			return false;
		}
		addresses = new InternetAddressList(addresses2);
		return true;
	}

	public static bool TryParse(byte[] buffer, out InternetAddressList addresses)
	{
		return TryParse(ParserOptions.Default, buffer, out addresses);
	}

	public static bool TryParse(ParserOptions options, string text, out InternetAddressList addresses)
	{
		ParseUtils.ValidateArguments(options, text);
		byte[] bytes = Encoding.UTF8.GetBytes(text);
		int index = 0;
		if (!TryParse(options, bytes, ref index, bytes.Length, isGroup: false, 0, throwOnError: false, out var addresses2))
		{
			addresses = null;
			return false;
		}
		addresses = new InternetAddressList(addresses2);
		return true;
	}

	public static bool TryParse(string text, out InternetAddressList addresses)
	{
		return TryParse(ParserOptions.Default, text, out addresses);
	}

	public static InternetAddressList Parse(ParserOptions options, byte[] buffer, int startIndex, int length)
	{
		ParseUtils.ValidateArguments(options, buffer, startIndex, length);
		int index = startIndex;
		TryParse(options, buffer, ref index, startIndex + length, isGroup: false, 0, throwOnError: true, out var addresses);
		return new InternetAddressList(addresses);
	}

	public static InternetAddressList Parse(byte[] buffer, int startIndex, int length)
	{
		return Parse(ParserOptions.Default, buffer, startIndex, length);
	}

	public static InternetAddressList Parse(ParserOptions options, byte[] buffer, int startIndex)
	{
		ParseUtils.ValidateArguments(options, buffer, startIndex);
		int index = startIndex;
		TryParse(options, buffer, ref index, buffer.Length, isGroup: false, 0, throwOnError: true, out var addresses);
		return new InternetAddressList(addresses);
	}

	public static InternetAddressList Parse(byte[] buffer, int startIndex)
	{
		return Parse(ParserOptions.Default, buffer, startIndex);
	}

	public static InternetAddressList Parse(ParserOptions options, byte[] buffer)
	{
		ParseUtils.ValidateArguments(options, buffer);
		int index = 0;
		TryParse(options, buffer, ref index, buffer.Length, isGroup: false, 0, throwOnError: true, out var addresses);
		return new InternetAddressList(addresses);
	}

	public static InternetAddressList Parse(byte[] buffer)
	{
		return Parse(ParserOptions.Default, buffer);
	}

	public static InternetAddressList Parse(ParserOptions options, string text)
	{
		ParseUtils.ValidateArguments(options, text);
		byte[] bytes = Encoding.UTF8.GetBytes(text);
		int index = 0;
		TryParse(options, bytes, ref index, bytes.Length, isGroup: false, 0, throwOnError: true, out var addresses);
		return new InternetAddressList(addresses);
	}

	public static InternetAddressList Parse(string text)
	{
		return Parse(ParserOptions.Default, text);
	}

	public static explicit operator MailAddressCollection(InternetAddressList addresses)
	{
		if (addresses == null)
		{
			return null;
		}
		MailAddressCollection mailAddressCollection = new MailAddressCollection();
		for (int i = 0; i < addresses.Count; i++)
		{
			if (addresses[i] is GroupAddress)
			{
				throw new InvalidCastException("Cannot cast a MailKit.GroupAddress to a System.Net.Mail.MailAddress.");
			}
			MailboxAddress mailboxAddress = (MailboxAddress)addresses[i];
			mailAddressCollection.Add((MailAddress)mailboxAddress);
		}
		return mailAddressCollection;
	}

	public static explicit operator InternetAddressList(MailAddressCollection addresses)
	{
		if (addresses == null)
		{
			return null;
		}
		InternetAddressList internetAddressList = new InternetAddressList();
		foreach (MailAddress address in addresses)
		{
			internetAddressList.Add((MailboxAddress)address);
		}
		return internetAddressList;
	}
}
